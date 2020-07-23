'
' Visual Basic .NET Parser
'
' Copyright (C) 2005, Microsoft Corporation. All rights reserved.
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER
' EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF
' MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'

Imports System.IO
Imports System.Reflection
Imports System.Xml
Imports VBParser
Imports Xunit
Imports Xunit.Abstractions

' UNDONE: Need conformance tests for full-width characters

Public Enum ScenarioType
    Token
    Expression
    Statement
    Declaration
    TypeName
    File
End Enum

Public Class Test
    Implements IXunitSerializable
    Public Scenario As ScenarioType
    Public ErrorsExpected As Boolean
    Public Code As String
    Public Result As String
    Public Errors As String
    Public Version As LanguageVersion

    Public Sub Deserialize(info As IXunitSerializationInfo) Implements IXunitSerializable.Deserialize
        Scenario = info.GetValue(Of ScenarioType)("Scenario")
        ErrorsExpected = info.GetValue(Of Boolean)("ErrorsExpected")
        Code = info.GetValue(Of String)("Code")
        Result = info.GetValue(Of String)("Result")
        Errors = info.GetValue(Of String)("Errors")
        Version = info.GetValue(Of LanguageVersion)("Version")
    End Sub

    Public Sub Serialize(info As IXunitSerializationInfo) Implements IXunitSerializable.Serialize
        info.AddValue("Scenario", Me.Scenario)
        info.AddValue("ErrorsExpected", Me.ErrorsExpected)
        info.AddValue("Code", Me.Code)
        info.AddValue("Result", Me.Result)
        info.AddValue("Errors", Me.Errors)
        info.AddValue("Version", Me.Version)
    End Sub

    Public Overrides Function ToString() As String
        Return Code
    End Function
End Class

Public Class TestHarness

    Public Function LoadTests(fileName As String) As TheoryData(Of Test)
        Dim Assem As [Assembly] = [Assembly].GetExecutingAssembly()
        Dim resourceName = String.Join(".", Me.GetType().Namespace, fileName)

        Dim Stream As Stream = Assem.GetManifestResourceStream(resourceName)
        Dim Scenario As New ScenarioType
        Dim Tests As New TheoryData(Of Test)

        If Not resourceName.EndsWith(".xml") Then
            Throw New ArgumentOutOfRangeException(NameOf(resourceName))
        End If

        Dim Document = New XmlDocument
        Document.Load(Stream)
        Stream.Close()

        Dim ScenarioElement = Document("scenario")

        Select Case ScenarioElement.GetAttribute("type")
            Case "token"
                Scenario = ScenarioType.Token

            Case "expression"
                Scenario = ScenarioType.Expression

            Case "statement"
                Scenario = ScenarioType.Statement

            Case "declaration"
                Scenario = ScenarioType.Declaration

            Case "typename"
                Scenario = ScenarioType.TypeName

            Case "file"
                Scenario = ScenarioType.File
        End Select

        For Each ScenarioChildNode As XmlNode In ScenarioElement.ChildNodes
            Dim ValidElement As XmlElement = TryCast(ScenarioChildNode, XmlElement)
            Dim ErrorTests As Boolean

            If ValidElement Is Nothing Then
                Continue For
            End If

            If ValidElement.Name <> "valid" AndAlso ValidElement.Name <> "invalid" Then
                Continue For
            End If

            ErrorTests = ValidElement.Name = "invalid"

            For Each ChildNode As XmlNode In ValidElement.ChildNodes
                Dim Test As New Test

                Test.ErrorsExpected = ErrorTests
                Dim Element = TryCast(ChildNode, XmlElement)

                If Element Is Nothing Then
                    Continue For
                End If

                If Element.GetAttribute("version") = "8.0" Then
                    Test.Version = LanguageVersion.VisualBasic80
                ElseIf Element.GetAttribute("version") = "7.1" Then
                    Test.Version = LanguageVersion.VisualBasic71
                Else
                    Test.Version = LanguageVersion.All
                End If

                Test.Code = Element("code").InnerText.Trim(ControlChars.Cr, ControlChars.Lf)

                Debug.Assert(Element.GetElementsByTagName("result").Count < 2, "too many results!")

                If Not Element("result") Is Nothing Then
                    Dim StringWriter As StringWriter = New StringWriter
                    Dim Writer As XmlTextWriter = New XmlTextWriter(StringWriter)

                    Writer.Formatting = Formatting.Indented
                    Element("result").WriteContentTo(Writer)
                    Writer.Close()
                    StringWriter.Close()

                    Test.Result = StringWriter.ToString()
                Else
                    Test.Result = Nothing
                End If

                If Not Element("errors") Is Nothing Then
                    Dim StringWriter As StringWriter = New StringWriter
                    Dim Writer As XmlTextWriter = New XmlTextWriter(StringWriter)

                    Writer.Formatting = Formatting.Indented
                    Element("errors").WriteContentTo(Writer)
                    Writer.Close()
                    StringWriter.Close()

                    Test.Errors = StringWriter.ToString()
                Else
                    Test.Errors = Nothing
                End If

                Test.Scenario = Scenario

                Tests.Add(Test)
            Next
        Next

        Return Tests
    End Function

    Private Sub RunScanTest(ByVal Test As Test, ByVal Version As LanguageVersion, ByVal FormatResults As Boolean, ByRef Result As String, ByRef ErrorResult As String)
        Dim Scanner As Scanner = New Scanner(Test.Code, Version)
        Dim StringWriter As StringWriter = New StringWriter
        Dim Writer As XmlTextWriter = New XmlTextWriter(StringWriter)
        Dim Serializer As TokenXmlSerializer = New TokenXmlSerializer(Writer)
        Dim Tokens() As Token
        Dim HasErrors As Boolean = False

        If FormatResults Then
            Writer.Formatting = Formatting.Indented
        End If

        Tokens = Scanner.ReadToEnd()
        Serializer.Serialize(Tokens)
        Result = StringWriter.ToString()

        Writer.Close()
        StringWriter.Close()

        For Each Token As Token In Tokens
            If Token.Type = TokenType.LexicalError Then
                HasErrors = True
                Exit For
            End If
        Next

        If Test.ErrorsExpected <> HasErrors Then
            If Test.ErrorsExpected Then
                ErrorResult = "Expected errors but didn't get any."
            Else
                ErrorResult = "Didn't expect any errors but got some."
            End If
        End If
    End Sub

    Private Sub RunParseTest(ByVal Test As Test, ByVal Version As LanguageVersion, ByVal FormatResults As Boolean, ByRef Result As String, ByRef ErrorResult As String)
        Dim StringWriter As StringWriter = New StringWriter()
        Dim Writer As XmlTextWriter = New XmlTextWriter(StringWriter)
        Dim Serializer As TreeXmlSerializer = New TreeXmlSerializer(Writer)
        Dim ErrorStringWriter As StringWriter = New StringWriter()
        Dim ErrorWriter As XmlTextWriter = New XmlTextWriter(ErrorStringWriter)
        Dim ErrorSerializer As ErrorXmlSerializer = New ErrorXmlSerializer(ErrorWriter)
        Dim Errors As List(Of SyntaxError) = New List(Of SyntaxError)()

        If FormatResults Then
            Writer.Formatting = Formatting.Indented
            ErrorWriter.Formatting = Formatting.Indented
        End If

        Select Case Test.Scenario
            Case ScenarioType.Expression
                Dim Scanner As Scanner = New Scanner(Test.Code, Version)
                Dim Parser As Parser = New Parser
                Dim Expression As Expression = Parser.ParseExpression(Scanner, Errors)
                Serializer.Serialize(Expression)

            Case ScenarioType.Statement
                Dim Scanner As Scanner = New Scanner(Test.Code, Version)
                Dim Parser As Parser = New Parser
                Dim Statement As Statement = Parser.ParseStatement(Scanner, Errors)
                Serializer.Serialize(Statement)

            Case ScenarioType.Declaration
                Dim Scanner As Scanner = New Scanner(Test.Code.Trim(), Version)
                Dim Parser As Parser = New Parser
                Dim Declaration As Declaration = Parser.ParseDeclaration(Scanner, Errors)
                Serializer.Serialize(Declaration)

            Case ScenarioType.TypeName
                Dim Scanner As Scanner = New Scanner(Test.Code, Version)
                Dim Parser As Parser = New Parser
                Dim TypeName As TypeName = Parser.ParseTypeName(Scanner, Errors)
                Serializer.Serialize(TypeName)

            Case ScenarioType.File
                Dim Scanner As Scanner = New Scanner(Test.Code.Trim(), Version)
                Dim Parser As Parser = New Parser
                Dim File As VBParser.File = Parser.ParseFile(Scanner, Errors)
                Serializer.Serialize(File)
        End Select

        Result = StringWriter.ToString()
        Writer.Close()
        StringWriter.Close()

        ErrorSerializer.Serialize(Errors)
        ErrorResult = ErrorStringWriter.ToString()
        ErrorWriter.Close()
        ErrorStringWriter.Close()

        If Test.ErrorsExpected <> (Errors.Count <> 0) Then
            If Test.ErrorsExpected Then
                ErrorResult = "Expected errors but didn't get any."
            Else
                ErrorResult = "Didn't expect any errors but got some."
            End If
        End If
    End Sub

    Public Sub RunSingleTest(ByVal Test As Test, ByVal Version As LanguageVersion, ByRef Result As String, ByRef ErrorResult As String, Optional ByVal FormatResults As Boolean = True)
        Select Case Test.Scenario
            Case ScenarioType.Token
                RunScanTest(Test, Version, FormatResults, Result, ErrorResult)

            Case ScenarioType.Expression, ScenarioType.Statement, ScenarioType.Declaration, ScenarioType.TypeName, ScenarioType.File
                RunParseTest(Test, Version, FormatResults, Result, ErrorResult)

            Case Else
                Debug.Fail("Unexpected.")
        End Select
    End Sub

    Public Function RunSingleVersionTest(ByVal Test As Test, ByVal Version As LanguageVersion) As Boolean
        Dim ActualResult As String = ""
        Dim ActualErrors As String = ""

        RunSingleTest(Test, Version, ActualResult, ActualErrors, Not Test.Result Is Nothing)

        Dim Result As String = Test.Result
        Dim Errors As String = Test.Errors

        Return ActualResult = Result AndAlso ActualErrors = Errors
    End Function

    Public Function RunTest(ByVal Test As Test) As Boolean
        Dim TestResult As Boolean = False

        If Test.Version = LanguageVersion.None Then
            Return False
        End If

        If (Test.Version And LanguageVersion.VisualBasic71) <> 0 Then
            TestResult = RunSingleVersionTest(Test, LanguageVersion.VisualBasic71)

            If Not TestResult Then
                Return False
            End If
        End If

        If (Test.Version And LanguageVersion.VisualBasic80) <> 0 Then
            TestResult = RunSingleVersionTest(Test, LanguageVersion.VisualBasic80)

            If Not TestResult Then
                Return False
            End If
        End If

        Return True
    End Function

    Public Sub AssertTest(ByVal Test As Test)
        Dim TestResult = RunTest(Test)
        Assert.True(TestResult)
    End Sub

End Class
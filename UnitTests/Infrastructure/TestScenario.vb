'
' Visual Basic .NET Parser
'
' Copyright (C) 2005, Microsoft Corporation. All rights reserved.
'
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER
' EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF
' MERCHANTIBILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'

Imports VBParser
Imports Xunit.Abstractions

Public Class TestScenario
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
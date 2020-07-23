Imports Xunit

Public Class FileTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared AssemblyAttributeScenarios As TheoryData = Harness.LoadTests("AssemblyAttribute.xml")
    Public Shared FileCommentsScenarios As TheoryData = Harness.LoadTests("FileComments.xml")
    Public Shared ImportScenarios As TheoryData = Harness.LoadTests("Import.xml")
    Public Shared NamespaceScenarios As TheoryData = Harness.LoadTests("Namespace.xml")
    Public Shared OptionScenarios As TheoryData = Harness.LoadTests("Option.xml")

    <Theory>
    <MemberData(NameOf(AssemblyAttributeScenarios))>
    Public Sub AssemblyAttributeTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(FileCommentsScenarios))>
    Public Sub FileCommentsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ImportScenarios))>
    Public Sub ImportTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(NamespaceScenarios))>
    Public Sub NamespaceTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(OptionScenarios))>
    Public Sub OptionTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

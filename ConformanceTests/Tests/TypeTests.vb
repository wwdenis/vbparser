Imports Xunit

Public Class TypeTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared ClassScenarios As TheoryData = Harness.LoadTests("Class.xml")
    Public Shared DelegateScenarios As TheoryData = Harness.LoadTests("Delegate.xml")
    Public Shared EnumerationsScenarios As TheoryData = Harness.LoadTests("Enumerations.xml")
    Public Shared InterfaceScenarios As TheoryData = Harness.LoadTests("Interface.xml")
    Public Shared ModulesScenarios As TheoryData = Harness.LoadTests("Modules.xml")
    Public Shared StructureScenarios As TheoryData = Harness.LoadTests("Structure.xml")
    Public Shared TypeCommentsScenarios As TheoryData = Harness.LoadTests("TypeComments.xml")

    <Theory>
    <MemberData(NameOf(ClassScenarios))>
    Public Sub ClassTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(DelegateScenarios))>
    Public Sub DelegateTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(EnumerationsScenarios))>
    Public Sub EnumerationsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(InterfaceScenarios))>
    Public Sub InterfaceTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ModulesScenarios))>
    Public Sub ModulesTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(StructureScenarios))>
    Public Sub StructureTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(TypeCommentsScenarios))>
    Public Sub TypeCommentsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

Imports Xunit

Public Class ExpressionTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared AddressOfScenarios As TheoryData = Harness.LoadTests("AddressOf.xml")
    Public Shared CallOrIndexScenarios As TheoryData = Harness.LoadTests("CallOrIndex.xml")
    Public Shared CastsScenarios As TheoryData = Harness.LoadTests("Casts.xml")
    Public Shared InstancesScenarios As TheoryData = Harness.LoadTests("Instances.xml")
    Public Shared LiteralsScenarios As TheoryData = Harness.LoadTests("Literals.xml")
    Public Shared MemberAccessScenarios As TheoryData = Harness.LoadTests("MemberAccess.xml")
    Public Shared NewScenarios As TheoryData = Harness.LoadTests("New.xml")
    Public Shared OperatorExpressionsScenarios As TheoryData = Harness.LoadTests("OperatorExpressions.xml")
    Public Shared ParenthesisScenarios As TheoryData = Harness.LoadTests("Parenthesis.xml")
    Public Shared SimpleNamesScenarios As TheoryData = Harness.LoadTests("SimpleNames.xml")
    Public Shared TypeExpressionsScenarios As TheoryData = Harness.LoadTests("TypeExpressions.xml")

    <Theory>
    <MemberData(NameOf(AddressOfScenarios))>
    Public Sub AddressOfTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(CallOrIndexScenarios))>
    Public Sub CallOrIndexTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(CastsScenarios))>
    Public Sub CastsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(InstancesScenarios))>
    Public Sub InstancesTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LiteralsScenarios))>
    Public Sub LiteralsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(MemberAccessScenarios))>
    Public Sub MemberAccessTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(NewScenarios))>
    Public Sub NewTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(OperatorExpressionsScenarios))>
    Public Sub OperatorExpressionsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ParenthesisScenarios))>
    Public Sub ParenthesisTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(SimpleNamesScenarios))>
    Public Sub SimpleNamesTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(TypeExpressionsScenarios))>
    Public Sub TypeExpressionsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

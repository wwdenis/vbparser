Imports Xunit

Public Class StatementTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared ArraysScenarios As TheoryData = Harness.LoadTests("Arrays.xml")
    Public Shared AssignmentsScenarios As TheoryData = Harness.LoadTests("Assignments.xml")
    Public Shared BlocksScenarios As TheoryData = Harness.LoadTests("Blocks.xml")
    Public Shared BranchesScenarios As TheoryData = Harness.LoadTests("Branches.xml")
    Public Shared ConditionalsScenarios As TheoryData = Harness.LoadTests("Conditionals.xml")
    Public Shared EventHandlersScenarios As TheoryData = Harness.LoadTests("EventHandlers.xml")
    Public Shared ExceptionsScenarios As TheoryData = Harness.LoadTests("Exceptions.xml")
    Public Shared ExpressionBlocksScenarios As TheoryData = Harness.LoadTests("ExpressionBlocks.xml")
    Public Shared InvocationsScenarios As TheoryData = Harness.LoadTests("Invocations.xml")
    Public Shared LocalsScenarios As TheoryData = Harness.LoadTests("Locals.xml")
    Public Shared LoopsScenarios As TheoryData = Harness.LoadTests("Loops.xml")
    Public Shared StatementCommentsScenarios As TheoryData = Harness.LoadTests("StatementComments.xml")

    <Theory>
    <MemberData(NameOf(ArraysScenarios))>
    Public Sub ArraysTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(AssignmentsScenarios))>
    Public Sub AssignmentsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(BlocksScenarios))>
    Public Sub BlocksTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(BranchesScenarios))>
    Public Sub BranchesTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ConditionalsScenarios))>
    Public Sub ConditionalsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(EventHandlersScenarios))>
    Public Sub EventHandlersTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExceptionsScenarios))>
    Public Sub ExceptionsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExpressionBlocksScenarios))>
    Public Sub ExpressionBlocksTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(InvocationsScenarios))>
    Public Sub InvocationsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LocalsScenarios))>
    Public Sub LocalsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LoopsScenarios))>
    Public Sub LoopsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(StatementCommentsScenarios))>
    Public Sub StatementCommentsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

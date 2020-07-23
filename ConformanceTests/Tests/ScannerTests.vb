Imports Xunit

Public Class ScannerTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared CommentsScenarios As TheoryData = Harness.LoadTests("Comments.xml")
    Public Shared DateLiteralsScenarios As TheoryData = Harness.LoadTests("DateLiterals.xml")
    Public Shared FloatingPointLiteralsScenarios As TheoryData = Harness.LoadTests("FloatingPointLiterals.xml")
    Public Shared IdentifiersScenarios As TheoryData = Harness.LoadTests("Identifiers.xml")
    Public Shared IntegerLiteralsScenarios As TheoryData = Harness.LoadTests("IntegerLiterals.xml")
    Public Shared KeywordsScenarios As TheoryData = Harness.LoadTests("Keywords.xml")
    Public Shared LineContinuationsScenarios As TheoryData = Harness.LoadTests("LineContinuations.xml")
    Public Shared LineTerminatorsScenarios As TheoryData = Harness.LoadTests("LineTerminators.xml")
    Public Shared PunctuatorsScenarios As TheoryData = Harness.LoadTests("Punctuators.xml")
    Public Shared StringLiteralsScenarios As TheoryData = Harness.LoadTests("StringLiterals.xml")
    Public Shared TypeCharactersScenarios As TheoryData = Harness.LoadTests("TypeCharacters.xml")

    <Theory>
    <MemberData(NameOf(CommentsScenarios))>
    Public Sub CommentsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(DateLiteralsScenarios))>
    Public Sub DateLiteralsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(FloatingPointLiteralsScenarios))>
    Public Sub FloatingPointLiteralsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(IdentifiersScenarios))>
    Public Sub IdentifiersTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(IntegerLiteralsScenarios))>
    Public Sub IntegerLiteralsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(KeywordsScenarios))>
    Public Sub KeywordsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LineContinuationsScenarios))>
    Public Sub LineContinuationsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LineTerminatorsScenarios))>
    Public Sub LineTerminatorsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(PunctuatorsScenarios))>
    Public Sub PunctuatorsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(StringLiteralsScenarios))>
    Public Sub StringLiteralsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(TypeCharactersScenarios))>
    Public Sub TypeCharactersTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

Public Class ScannerTests
    Private Shared ReadOnly Runner As New TestRunner

    Public Shared CommentsScenarios As TheoryData = Runner.LoadTests("Scanner\Comments.xml")
    Public Shared DateLiteralsScenarios As TheoryData = Runner.LoadTests("Scanner\DateLiterals.xml")
    Public Shared FloatingPointLiteralsScenarios As TheoryData = Runner.LoadTests("Scanner\FloatingPointLiterals.xml")
    Public Shared IdentifiersScenarios As TheoryData = Runner.LoadTests("Scanner\Identifiers.xml")
    Public Shared IntegerLiteralsScenarios As TheoryData = Runner.LoadTests("Scanner\IntegerLiterals.xml")
    Public Shared KeywordsScenarios As TheoryData = Runner.LoadTests("Scanner\Keywords.xml")
    Public Shared LineContinuationsScenarios As TheoryData = Runner.LoadTests("Scanner\LineContinuations.xml")
    Public Shared LineTerminatorsScenarios As TheoryData = Runner.LoadTests("Scanner\LineTerminators.xml")
    Public Shared PunctuatorsScenarios As TheoryData = Runner.LoadTests("Scanner\Punctuators.xml")
    Public Shared StringLiteralsScenarios As TheoryData = Runner.LoadTests("Scanner\StringLiterals.xml")
    Public Shared TypeCharactersScenarios As TheoryData = Runner.LoadTests("Scanner\TypeCharacters.xml")

    Sub New()
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US")
    End Sub

    <Theory>
    <MemberData(NameOf(CommentsScenarios))>
    Public Sub CommentsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(DateLiteralsScenarios))>
    Public Sub DateLiteralsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(FloatingPointLiteralsScenarios))>
    Public Sub FloatingPointLiteralsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(IdentifiersScenarios))>
    Public Sub IdentifiersTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(IntegerLiteralsScenarios))>
    Public Sub IntegerLiteralsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(KeywordsScenarios))>
    Public Sub KeywordsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LineContinuationsScenarios))>
    Public Sub LineContinuationsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LineTerminatorsScenarios))>
    Public Sub LineTerminatorsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(PunctuatorsScenarios))>
    Public Sub PunctuatorsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(StringLiteralsScenarios))>
    Public Sub StringLiteralsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(TypeCharactersScenarios))>
    Public Sub TypeCharactersTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

End Class
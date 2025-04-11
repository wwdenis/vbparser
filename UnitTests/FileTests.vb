Public Class FileTests
    Private Shared ReadOnly Runner As New TestRunner

    Public Shared AssemblyAttributeScenarios As TheoryData = Runner.LoadTests("File\AssemblyAttribute.xml")
    Public Shared FileCommentsScenarios As TheoryData = Runner.LoadTests("File\FileComments.xml")
    Public Shared ImportScenarios As TheoryData = Runner.LoadTests("File\Import.xml")
    Public Shared NamespaceScenarios As TheoryData = Runner.LoadTests("File\Namespace.xml")
    Public Shared OptionScenarios As TheoryData = Runner.LoadTests("File\Option.xml")

    Sub New()
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US")
    End Sub

    <Theory>
    <MemberData(NameOf(AssemblyAttributeScenarios))>
    Public Sub AssemblyAttributeTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(FileCommentsScenarios))>
    Public Sub FileCommentsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ImportScenarios))>
    Public Sub ImportTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(NamespaceScenarios))>
    Public Sub NamespaceTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(OptionScenarios))>
    Public Sub OptionTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

End Class
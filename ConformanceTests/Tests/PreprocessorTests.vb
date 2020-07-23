Imports Xunit

Public Class PreprocessorTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared ConditionalCompilationScenarios As TheoryData = Harness.LoadTests("ConditionalCompilation.xml")
    Public Shared ConditionalConstantScenarios As TheoryData = Harness.LoadTests("ConditionalConstant.xml")
    Public Shared ExternalChecksumScenarios As TheoryData = Harness.LoadTests("ExternalChecksum.xml")
    Public Shared ExternalSourceScenarios As TheoryData = Harness.LoadTests("ExternalSource.xml")
    Public Shared PreprocessorCommentsScenarios As TheoryData = Harness.LoadTests("PreprocessorComments.xml")
    Public Shared RegionScenarios As TheoryData = Harness.LoadTests("Region.xml")

    <Theory>
    <MemberData(NameOf(ConditionalCompilationScenarios))>
    Public Sub ConditionalCompilationTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ConditionalConstantScenarios))>
    Public Sub ConditionalConstantTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExternalChecksumScenarios))>
    Public Sub ExternalChecksumTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExternalSourceScenarios))>
    Public Sub ExternalSourceTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(PreprocessorCommentsScenarios))>
    Public Sub PreprocessorCommentsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(RegionScenarios))>
    Public Sub RegionTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

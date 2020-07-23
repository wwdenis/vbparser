Imports Xunit

Public Class TypeNameTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared TypeNameScenarios As TheoryData = Harness.LoadTests("TypeName.xml")

    <Theory>
    <MemberData(NameOf(TypeNameScenarios))>
    Public Sub TypeNameTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

Imports Xunit

Public Class DeclarationTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared AttributeScenarios As TheoryData = Harness.LoadTests("Attribute.xml")

    <Theory>
    <MemberData(NameOf(AttributeScenarios))>
    Public Sub AttributeTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

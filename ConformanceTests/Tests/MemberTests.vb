Imports Xunit

Public Class MemberTests
    Private Shared ReadOnly Harness As New TestHarness

    Public Shared ConstructorsScenarios As TheoryData = Harness.LoadTests("Constructors.xml")
    Public Shared EventsScenarios As TheoryData = Harness.LoadTests("Events.xml")
    Public Shared ExternalMethodsScenarios As TheoryData = Harness.LoadTests("ExternalMethods.xml")
    Public Shared FieldsScenarios As TheoryData = Harness.LoadTests("Fields.xml")
    Public Shared HandlesScenarios As TheoryData = Harness.LoadTests("Handles.xml")
    Public Shared ImplementsScenarios As TheoryData = Harness.LoadTests("Implements.xml")
    Public Shared MemberCommentsScenarios As TheoryData = Harness.LoadTests("MemberComments.xml")
    Public Shared OperatorsScenarios As TheoryData = Harness.LoadTests("Operators.xml")
    Public Shared ParametersScenarios As TheoryData = Harness.LoadTests("Parameters.xml")
    Public Shared PropertiesScenarios As TheoryData = Harness.LoadTests("Properties.xml")
    Public Shared RegularMethodsScenarios As TheoryData = Harness.LoadTests("RegularMethods.xml")

    <Theory>
    <MemberData(NameOf(ConstructorsScenarios))>
    Public Sub ConstructorsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(EventsScenarios))>
    Public Sub EventsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExternalMethodsScenarios))>
    Public Sub ExternalMethodsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(FieldsScenarios))>
    Public Sub FieldsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(HandlesScenarios))>
    Public Sub HandlesTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ImplementsScenarios))>
    Public Sub ImplementsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(MemberCommentsScenarios))>
    Public Sub MemberCommentsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(OperatorsScenarios))>
    Public Sub OperatorsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ParametersScenarios))>
    Public Sub ParametersTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(PropertiesScenarios))>
    Public Sub PropertiesTests(test As Test)
        Harness.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(RegularMethodsScenarios))>
    Public Sub RegularMethodsTests(test As Test)
        Harness.AssertTest(test)
    End Sub

End Class

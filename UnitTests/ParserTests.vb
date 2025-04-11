Public Class ParserTests
    Private Shared ReadOnly Runner As New TestRunner

    Public Shared AttributeScenarios As TheoryData = Runner.LoadTests("Parser\Declaration\Attribute.xml")
    Public Shared AddressOfScenarios As TheoryData = Runner.LoadTests("Parser\Expression\AddressOf.xml")
    Public Shared CallOrIndexScenarios As TheoryData = Runner.LoadTests("Parser\Expression\CallOrIndex.xml")
    Public Shared CastsScenarios As TheoryData = Runner.LoadTests("Parser\Expression\Casts.xml")
    Public Shared InstancesScenarios As TheoryData = Runner.LoadTests("Parser\Expression\Instances.xml")
    Public Shared LiteralsScenarios As TheoryData = Runner.LoadTests("Parser\Expression\Literals.xml")
    Public Shared MemberAccessScenarios As TheoryData = Runner.LoadTests("Parser\Expression\MemberAccess.xml")
    Public Shared NewScenarios As TheoryData = Runner.LoadTests("Parser\Expression\New.xml")
    Public Shared OperatorExpressionsScenarios As TheoryData = Runner.LoadTests("Parser\Expression\OperatorExpressions.xml")
    Public Shared OperatorsScenarios As TheoryData = Runner.LoadTests("Parser\Expression\Operators.xml")
    Public Shared ParenthesesScenarios As TheoryData = Runner.LoadTests("Parser\Expression\Parentheses.xml")
    Public Shared ParenthesisScenarios As TheoryData = Runner.LoadTests("Parser\Expression\Parenthesis.xml")
    Public Shared SimpleNamesScenarios As TheoryData = Runner.LoadTests("Parser\Expression\SimpleNames.xml")
    Public Shared TypeExpressionsScenarios As TheoryData = Runner.LoadTests("Parser\Expression\TypeExpressions.xml")
    Public Shared ConstructorsScenarios As TheoryData = Runner.LoadTests("Parser\Member\Constructors.xml")
    Public Shared EventsScenarios As TheoryData = Runner.LoadTests("Parser\Member\Events.xml")
    Public Shared ExternalMethodsScenarios As TheoryData = Runner.LoadTests("Parser\Member\ExternalMethods.xml")
    Public Shared FieldsScenarios As TheoryData = Runner.LoadTests("Parser\Member\Fields.xml")
    Public Shared HandlesScenarios As TheoryData = Runner.LoadTests("Parser\Member\Handles.xml")
    Public Shared ImplementsScenarios As TheoryData = Runner.LoadTests("Parser\Member\Implements.xml")
    Public Shared MemberCommentsScenarios As TheoryData = Runner.LoadTests("Parser\Member\MemberComments.xml")
    Public Shared MemberOperatorsScenarios As TheoryData = Runner.LoadTests("Parser\Member\MemberOperators.xml")
    Public Shared ParametersScenarios As TheoryData = Runner.LoadTests("Parser\Member\Parameters.xml")
    Public Shared PropertiesScenarios As TheoryData = Runner.LoadTests("Parser\Member\Properties.xml")
    Public Shared RegularMethodsScenarios As TheoryData = Runner.LoadTests("Parser\Member\RegularMethods.xml")
    Public Shared ConditionalCompilationScenarios As TheoryData = Runner.LoadTests("Parser\Preprocessor\ConditionalCompilation.xml")
    Public Shared ConditionalConstantScenarios As TheoryData = Runner.LoadTests("Parser\Preprocessor\ConditionalConstant.xml")
    Public Shared ExternalChecksumScenarios As TheoryData = Runner.LoadTests("Parser\Preprocessor\ExternalChecksum.xml")
    Public Shared ExternalSourceScenarios As TheoryData = Runner.LoadTests("Parser\Preprocessor\ExternalSource.xml")
    Public Shared PreprocessorCommentsScenarios As TheoryData = Runner.LoadTests("Parser\Preprocessor\PreprocessorComments.xml")
    Public Shared RegionScenarios As TheoryData = Runner.LoadTests("Parser\Preprocessor\Region.xml")
    Public Shared ArraysScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Arrays.xml")
    Public Shared AssignmentsScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Assignments.xml")
    Public Shared BlocksScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Blocks.xml")
    Public Shared BranchesScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Branches.xml")
    Public Shared ConditionalsScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Conditionals.xml")
    Public Shared EventHandlersScenarios As TheoryData = Runner.LoadTests("Parser\Statement\EventHandlers.xml")
    Public Shared ExceptionsScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Exceptions.xml")
    Public Shared ExpressionBlocksScenarios As TheoryData = Runner.LoadTests("Parser\Statement\ExpressionBlocks.xml")
    Public Shared InvocationsScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Invocations.xml")
    Public Shared LocalsScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Locals.xml")
    Public Shared LoopsScenarios As TheoryData = Runner.LoadTests("Parser\Statement\Loops.xml")
    Public Shared StatementCommentsScenarios As TheoryData = Runner.LoadTests("Parser\Statement\StatementComments.xml")
    Public Shared ClassScenarios As TheoryData = Runner.LoadTests("Parser\Type\Class.xml")
    Public Shared DelegateScenarios As TheoryData = Runner.LoadTests("Parser\Type\Delegate.xml")
    Public Shared EnumerationsScenarios As TheoryData = Runner.LoadTests("Parser\Type\Enumerations.xml")
    Public Shared InterfaceScenarios As TheoryData = Runner.LoadTests("Parser\Type\Interface.xml")
    Public Shared ModulesScenarios As TheoryData = Runner.LoadTests("Parser\Type\Modules.xml")
    Public Shared StructureScenarios As TheoryData = Runner.LoadTests("Parser\Type\Structure.xml")
    Public Shared TypeCommentsScenarios As TheoryData = Runner.LoadTests("Parser\Type\TypeComments.xml")
    Public Shared TypeNameScenarios As TheoryData = Runner.LoadTests("Parser\TypeName\TypeName.xml")

    Sub New()
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US")
    End Sub

    <Theory>
    <MemberData(NameOf(AttributeScenarios))>
    Public Sub AttributeTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(AddressOfScenarios))>
    Public Sub AddressOfTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(CallOrIndexScenarios))>
    Public Sub CallOrIndexTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(CastsScenarios))>
    Public Sub CastsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(InstancesScenarios))>
    Public Sub InstancesTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LiteralsScenarios))>
    Public Sub LiteralsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(MemberAccessScenarios))>
    Public Sub MemberAccessTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(NewScenarios))>
    Public Sub NewTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(OperatorExpressionsScenarios))>
    Public Sub OperatorExpressionsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(OperatorsScenarios))>
    Public Sub OperatorsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ParenthesesScenarios))>
    Public Sub ParenthesesTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ParenthesisScenarios))>
    Public Sub ParenthesisTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(SimpleNamesScenarios))>
    Public Sub SimpleNamesTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(TypeExpressionsScenarios))>
    Public Sub TypeExpressionsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ConstructorsScenarios))>
    Public Sub ConstructorsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(EventsScenarios))>
    Public Sub EventsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExternalMethodsScenarios))>
    Public Sub ExternalMethodsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(FieldsScenarios))>
    Public Sub FieldsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(HandlesScenarios))>
    Public Sub HandlesTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ImplementsScenarios))>
    Public Sub ImplementsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(MemberCommentsScenarios))>
    Public Sub MemberCommentsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(MemberOperatorsScenarios))>
    Public Sub MemberOperatorsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ParametersScenarios))>
    Public Sub ParametersTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(PropertiesScenarios))>
    Public Sub PropertiesTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(RegularMethodsScenarios))>
    Public Sub RegularMethodsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ConditionalCompilationScenarios))>
    Public Sub ConditionalCompilationTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ConditionalConstantScenarios))>
    Public Sub ConditionalConstantTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExternalChecksumScenarios))>
    Public Sub ExternalChecksumTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExternalSourceScenarios))>
    Public Sub ExternalSourceTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(PreprocessorCommentsScenarios))>
    Public Sub PreprocessorCommentsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(RegionScenarios))>
    Public Sub RegionTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ArraysScenarios))>
    Public Sub ArraysTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(AssignmentsScenarios))>
    Public Sub AssignmentsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(BlocksScenarios))>
    Public Sub BlocksTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(BranchesScenarios))>
    Public Sub BranchesTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ConditionalsScenarios))>
    Public Sub ConditionalsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(EventHandlersScenarios))>
    Public Sub EventHandlersTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExceptionsScenarios))>
    Public Sub ExceptionsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ExpressionBlocksScenarios))>
    Public Sub ExpressionBlocksTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(InvocationsScenarios))>
    Public Sub InvocationsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LocalsScenarios))>
    Public Sub LocalsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(LoopsScenarios))>
    Public Sub LoopsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(StatementCommentsScenarios))>
    Public Sub StatementCommentsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ClassScenarios))>
    Public Sub ClassTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(DelegateScenarios))>
    Public Sub DelegateTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(EnumerationsScenarios))>
    Public Sub EnumerationsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(InterfaceScenarios))>
    Public Sub InterfaceTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(ModulesScenarios))>
    Public Sub ModulesTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(StructureScenarios))>
    Public Sub StructureTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(TypeCommentsScenarios))>
    Public Sub TypeCommentsTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

    <Theory>
    <MemberData(NameOf(TypeNameScenarios))>
    Public Sub TypeNameTests(test As TestScenario)
        Runner.AssertTest(test)
    End Sub

End Class
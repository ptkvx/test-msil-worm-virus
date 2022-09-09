namespace System.Linq.Expressions;

internal static class Strings
{
	internal static string OwningTeam => SR.GetString("OwningTeam");

	internal static string ArgumentMustBeArray => SR.GetString("ArgumentMustBeArray");

	internal static string ArgumentMustBeBoolean => SR.GetString("ArgumentMustBeBoolean");

	internal static string ArgumentMustBeComparable => SR.GetString("ArgumentMustBeComparable");

	internal static string ArgumentMustBeConvertible => SR.GetString("ArgumentMustBeConvertible");

	internal static string ArgumentMustBeFieldInfoOrPropertInfo => SR.GetString("ArgumentMustBeFieldInfoOrPropertInfo");

	internal static string ArgumentMustBeFieldInfoOrPropertInfoOrMethod => SR.GetString("ArgumentMustBeFieldInfoOrPropertInfoOrMethod");

	internal static string ArgumentMustBeInstanceMember => SR.GetString("ArgumentMustBeInstanceMember");

	internal static string ArgumentMustBeInteger => SR.GetString("ArgumentMustBeInteger");

	internal static string ArgumentMustBeInt32 => SR.GetString("ArgumentMustBeInt32");

	internal static string ArgumentMustBeCheckable => SR.GetString("ArgumentMustBeCheckable");

	internal static string ArgumentMustBeArrayIndexType => SR.GetString("ArgumentMustBeArrayIndexType");

	internal static string ArgumentMustBeIntegerOrBoolean => SR.GetString("ArgumentMustBeIntegerOrBoolean");

	internal static string ArgumentMustBeNumeric => SR.GetString("ArgumentMustBeNumeric");

	internal static string ArgumentMustBeSingleDimensionalArrayType => SR.GetString("ArgumentMustBeSingleDimensionalArrayType");

	internal static string ArgumentTypesMustMatch => SR.GetString("ArgumentTypesMustMatch");

	internal static string CoalesceUsedOnNonNullType => SR.GetString("CoalesceUsedOnNonNullType");

	internal static string IncorrectNumberOfIndexes => SR.GetString("IncorrectNumberOfIndexes");

	internal static string IncorrectNumberOfLambdaArguments => SR.GetString("IncorrectNumberOfLambdaArguments");

	internal static string IncorrectNumberOfLambdaDeclarationParameters => SR.GetString("IncorrectNumberOfLambdaDeclarationParameters");

	internal static string IncorrectNumberOfConstructorArguments => SR.GetString("IncorrectNumberOfConstructorArguments");

	internal static string IncorrectNumberOfMembersForGivenConstructor => SR.GetString("IncorrectNumberOfMembersForGivenConstructor");

	internal static string IncorrectNumberOfArgumentsForMembers => SR.GetString("IncorrectNumberOfArgumentsForMembers");

	internal static string LambdaParameterNotInScope => SR.GetString("LambdaParameterNotInScope");

	internal static string LambdaTypeMustBeDerivedFromSystemDelegate => SR.GetString("LambdaTypeMustBeDerivedFromSystemDelegate");

	internal static string ParameterNotCaptured => SR.GetString("ParameterNotCaptured");

	internal static string ListInitializerWithZeroMembers => SR.GetString("ListInitializerWithZeroMembers");

	internal static string ElementInitializerMethodNotAdd => SR.GetString("ElementInitializerMethodNotAdd");

	internal static string ElementInitializerMethodWithZeroArgs => SR.GetString("ElementInitializerMethodWithZeroArgs");

	internal static string ElementInitializerMethodStatic => SR.GetString("ElementInitializerMethodStatic");

	internal static string UnexpectedCoalesceOperator => SR.GetString("UnexpectedCoalesceOperator");

	internal static string UnhandledBinding => SR.GetString("UnhandledBinding");

	internal static string UnknownBindingType => SR.GetString("UnknownBindingType");

	internal static string IncorrectNumberOfTypeArgsForFunc => SR.GetString("IncorrectNumberOfTypeArgsForFunc");

	internal static string IncorrectNumberOfTypeArgsForAction => SR.GetString("IncorrectNumberOfTypeArgsForAction");

	internal static string ExpressionMayNotContainByrefParameters => SR.GetString("ExpressionMayNotContainByrefParameters");

	internal static string UserDefinedOperatorMustBeStatic(object p0)
	{
		return SR.GetString("UserDefinedOperatorMustBeStatic", p0);
	}

	internal static string UserDefinedOperatorMustNotBeVoid(object p0)
	{
		return SR.GetString("UserDefinedOperatorMustNotBeVoid", p0);
	}

	internal static string CoercionOperatorNotDefined(object p0, object p1)
	{
		return SR.GetString("CoercionOperatorNotDefined", p0, p1);
	}

	internal static string UnaryOperatorNotDefined(object p0, object p1)
	{
		return SR.GetString("UnaryOperatorNotDefined", p0, p1);
	}

	internal static string BinaryOperatorNotDefined(object p0, object p1, object p2)
	{
		return SR.GetString("BinaryOperatorNotDefined", p0, p1, p2);
	}

	internal static string OperandTypesDoNotMatchParameters(object p0, object p1)
	{
		return SR.GetString("OperandTypesDoNotMatchParameters", p0, p1);
	}

	internal static string CannotAutoInitializeValueTypeElementThroughProperty(object p0)
	{
		return SR.GetString("CannotAutoInitializeValueTypeElementThroughProperty", p0);
	}

	internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object p0)
	{
		return SR.GetString("CannotAutoInitializeValueTypeMemberThroughProperty", p0);
	}

	internal static string CannotCastTypeToType(object p0, object p1)
	{
		return SR.GetString("CannotCastTypeToType", p0, p1);
	}

	internal static string IncorrectTypeForTypeAs(object p0)
	{
		return SR.GetString("IncorrectTypeForTypeAs", p0);
	}

	internal static string ExpressionTypeCannotInitializeCollectionType(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeCannotInitializeCollectionType", p0, p1);
	}

	internal static string ExpressionTypeCannotInitializeArrayType(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeCannotInitializeArrayType", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchArrayType(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchArrayType", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchConstructorParameter", p0, p1);
	}

	internal static string ArgumentTypeDoesNotMatchMember(object p0, object p1)
	{
		return SR.GetString("ArgumentTypeDoesNotMatchMember", p0, p1);
	}

	internal static string ArgumentMemberNotDeclOnType(object p0, object p1)
	{
		return SR.GetString("ArgumentMemberNotDeclOnType", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchMethodParameter", p0, p1, p2);
	}

	internal static string ExpressionTypeDoesNotMatchParameter(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchParameter", p0, p1);
	}

	internal static string ExpressionTypeDoesNotMatchReturn(object p0, object p1)
	{
		return SR.GetString("ExpressionTypeDoesNotMatchReturn", p0, p1);
	}

	internal static string ExpressionTypeNotInvocable(object p0)
	{
		return SR.GetString("ExpressionTypeNotInvocable", p0);
	}

	internal static string FieldNotDefinedForType(object p0, object p1)
	{
		return SR.GetString("FieldNotDefinedForType", p0, p1);
	}

	internal static string IncorrectNumberOfMethodCallArguments(object p0)
	{
		return SR.GetString("IncorrectNumberOfMethodCallArguments", p0);
	}

	internal static string MemberNotFieldOrProperty(object p0)
	{
		return SR.GetString("MemberNotFieldOrProperty", p0);
	}

	internal static string MethodContainsGenericParameters(object p0)
	{
		return SR.GetString("MethodContainsGenericParameters", p0);
	}

	internal static string MethodIsGeneric(object p0)
	{
		return SR.GetString("MethodIsGeneric", p0);
	}

	internal static string MethodNotPropertyAccessor(object p0, object p1)
	{
		return SR.GetString("MethodNotPropertyAccessor", p0, p1);
	}

	internal static string PropertyDoesNotHaveGetter(object p0)
	{
		return SR.GetString("PropertyDoesNotHaveGetter", p0);
	}

	internal static string PropertyDoesNotHaveSetter(object p0)
	{
		return SR.GetString("PropertyDoesNotHaveSetter", p0);
	}

	internal static string NotAMemberOfType(object p0, object p1)
	{
		return SR.GetString("NotAMemberOfType", p0, p1);
	}

	internal static string OperatorNotImplementedForType(object p0, object p1)
	{
		return SR.GetString("OperatorNotImplementedForType", p0, p1);
	}

	internal static string ParameterExpressionNotValidAsDelegate(object p0, object p1)
	{
		return SR.GetString("ParameterExpressionNotValidAsDelegate", p0, p1);
	}

	internal static string PropertyNotDefinedForType(object p0, object p1)
	{
		return SR.GetString("PropertyNotDefinedForType", p0, p1);
	}

	internal static string MethodNotDefinedForType(object p0, object p1)
	{
		return SR.GetString("MethodNotDefinedForType", p0, p1);
	}

	internal static string TypeContainsGenericParameters(object p0)
	{
		return SR.GetString("TypeContainsGenericParameters", p0);
	}

	internal static string TypeIsGeneric(object p0)
	{
		return SR.GetString("TypeIsGeneric", p0);
	}

	internal static string TypeMissingDefaultConstructor(object p0)
	{
		return SR.GetString("TypeMissingDefaultConstructor", p0);
	}

	internal static string ElementInitializerMethodNoRefOutParam(object p0, object p1)
	{
		return SR.GetString("ElementInitializerMethodNoRefOutParam", p0, p1);
	}

	internal static string TypeNotIEnumerable(object p0)
	{
		return SR.GetString("TypeNotIEnumerable", p0);
	}

	internal static string TypeParameterIsNotDelegate(object p0)
	{
		return SR.GetString("TypeParameterIsNotDelegate", p0);
	}

	internal static string InvalidCast(object p0, object p1)
	{
		return SR.GetString("InvalidCast", p0, p1);
	}

	internal static string UnhandledCall(object p0)
	{
		return SR.GetString("UnhandledCall", p0);
	}

	internal static string UnhandledBinary(object p0)
	{
		return SR.GetString("UnhandledBinary", p0);
	}

	internal static string UnhandledBindingType(object p0)
	{
		return SR.GetString("UnhandledBindingType", p0);
	}

	internal static string UnhandledConvert(object p0)
	{
		return SR.GetString("UnhandledConvert", p0);
	}

	internal static string UnhandledConvertFromDecimal(object p0)
	{
		return SR.GetString("UnhandledConvertFromDecimal", p0);
	}

	internal static string UnhandledConvertToDecimal(object p0)
	{
		return SR.GetString("UnhandledConvertToDecimal", p0);
	}

	internal static string UnhandledExpressionType(object p0)
	{
		return SR.GetString("UnhandledExpressionType", p0);
	}

	internal static string UnhandledMemberAccess(object p0)
	{
		return SR.GetString("UnhandledMemberAccess", p0);
	}

	internal static string UnhandledUnary(object p0)
	{
		return SR.GetString("UnhandledUnary", p0);
	}

	internal static string LogicalOperatorMustHaveConsistentTypes(object p0, object p1)
	{
		return SR.GetString("LogicalOperatorMustHaveConsistentTypes", p0, p1);
	}

	internal static string LogicalOperatorMustHaveBooleanOperators(object p0, object p1)
	{
		return SR.GetString("LogicalOperatorMustHaveBooleanOperators", p0, p1);
	}

	internal static string MethodDoesNotExistOnType(object p0, object p1)
	{
		return SR.GetString("MethodDoesNotExistOnType", p0, p1);
	}

	internal static string MethodWithArgsDoesNotExistOnType(object p0, object p1)
	{
		return SR.GetString("MethodWithArgsDoesNotExistOnType", p0, p1);
	}

	internal static string MethodWithMoreThanOneMatch(object p0, object p1)
	{
		return SR.GetString("MethodWithMoreThanOneMatch", p0, p1);
	}
}

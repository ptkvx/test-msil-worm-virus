using System.Globalization;
using System.Resources;
using System.Threading;

namespace System.Linq.Expressions;

internal sealed class SR
{
	internal const string OwningTeam = "OwningTeam";

	internal const string UserDefinedOperatorMustBeStatic = "UserDefinedOperatorMustBeStatic";

	internal const string UserDefinedOperatorMustNotBeVoid = "UserDefinedOperatorMustNotBeVoid";

	internal const string CoercionOperatorNotDefined = "CoercionOperatorNotDefined";

	internal const string UnaryOperatorNotDefined = "UnaryOperatorNotDefined";

	internal const string BinaryOperatorNotDefined = "BinaryOperatorNotDefined";

	internal const string OperandTypesDoNotMatchParameters = "OperandTypesDoNotMatchParameters";

	internal const string ArgumentMustBeArray = "ArgumentMustBeArray";

	internal const string ArgumentMustBeBoolean = "ArgumentMustBeBoolean";

	internal const string ArgumentMustBeComparable = "ArgumentMustBeComparable";

	internal const string ArgumentMustBeConvertible = "ArgumentMustBeConvertible";

	internal const string ArgumentMustBeFieldInfoOrPropertInfo = "ArgumentMustBeFieldInfoOrPropertInfo";

	internal const string ArgumentMustBeFieldInfoOrPropertInfoOrMethod = "ArgumentMustBeFieldInfoOrPropertInfoOrMethod";

	internal const string ArgumentMustBeInstanceMember = "ArgumentMustBeInstanceMember";

	internal const string ArgumentMustBeInteger = "ArgumentMustBeInteger";

	internal const string ArgumentMustBeInt32 = "ArgumentMustBeInt32";

	internal const string ArgumentMustBeCheckable = "ArgumentMustBeCheckable";

	internal const string ArgumentMustBeArrayIndexType = "ArgumentMustBeArrayIndexType";

	internal const string ArgumentMustBeIntegerOrBoolean = "ArgumentMustBeIntegerOrBoolean";

	internal const string ArgumentMustBeNumeric = "ArgumentMustBeNumeric";

	internal const string ArgumentMustBeSingleDimensionalArrayType = "ArgumentMustBeSingleDimensionalArrayType";

	internal const string ArgumentTypesMustMatch = "ArgumentTypesMustMatch";

	internal const string CannotAutoInitializeValueTypeElementThroughProperty = "CannotAutoInitializeValueTypeElementThroughProperty";

	internal const string CannotAutoInitializeValueTypeMemberThroughProperty = "CannotAutoInitializeValueTypeMemberThroughProperty";

	internal const string CannotCastTypeToType = "CannotCastTypeToType";

	internal const string IncorrectTypeForTypeAs = "IncorrectTypeForTypeAs";

	internal const string CoalesceUsedOnNonNullType = "CoalesceUsedOnNonNullType";

	internal const string ExpressionTypeCannotInitializeCollectionType = "ExpressionTypeCannotInitializeCollectionType";

	internal const string ExpressionTypeCannotInitializeArrayType = "ExpressionTypeCannotInitializeArrayType";

	internal const string ExpressionTypeDoesNotMatchArrayType = "ExpressionTypeDoesNotMatchArrayType";

	internal const string ExpressionTypeDoesNotMatchConstructorParameter = "ExpressionTypeDoesNotMatchConstructorParameter";

	internal const string ArgumentTypeDoesNotMatchMember = "ArgumentTypeDoesNotMatchMember";

	internal const string ArgumentMemberNotDeclOnType = "ArgumentMemberNotDeclOnType";

	internal const string ExpressionTypeDoesNotMatchMethodParameter = "ExpressionTypeDoesNotMatchMethodParameter";

	internal const string ExpressionTypeDoesNotMatchParameter = "ExpressionTypeDoesNotMatchParameter";

	internal const string ExpressionTypeDoesNotMatchReturn = "ExpressionTypeDoesNotMatchReturn";

	internal const string ExpressionTypeNotInvocable = "ExpressionTypeNotInvocable";

	internal const string FieldNotDefinedForType = "FieldNotDefinedForType";

	internal const string IncorrectNumberOfIndexes = "IncorrectNumberOfIndexes";

	internal const string IncorrectNumberOfLambdaArguments = "IncorrectNumberOfLambdaArguments";

	internal const string IncorrectNumberOfLambdaDeclarationParameters = "IncorrectNumberOfLambdaDeclarationParameters";

	internal const string IncorrectNumberOfMethodCallArguments = "IncorrectNumberOfMethodCallArguments";

	internal const string IncorrectNumberOfConstructorArguments = "IncorrectNumberOfConstructorArguments";

	internal const string IncorrectNumberOfMembersForGivenConstructor = "IncorrectNumberOfMembersForGivenConstructor";

	internal const string IncorrectNumberOfArgumentsForMembers = "IncorrectNumberOfArgumentsForMembers";

	internal const string LambdaParameterNotInScope = "LambdaParameterNotInScope";

	internal const string LambdaTypeMustBeDerivedFromSystemDelegate = "LambdaTypeMustBeDerivedFromSystemDelegate";

	internal const string MemberNotFieldOrProperty = "MemberNotFieldOrProperty";

	internal const string MethodContainsGenericParameters = "MethodContainsGenericParameters";

	internal const string MethodIsGeneric = "MethodIsGeneric";

	internal const string MethodNotPropertyAccessor = "MethodNotPropertyAccessor";

	internal const string PropertyDoesNotHaveGetter = "PropertyDoesNotHaveGetter";

	internal const string PropertyDoesNotHaveSetter = "PropertyDoesNotHaveSetter";

	internal const string NotAMemberOfType = "NotAMemberOfType";

	internal const string OperatorNotImplementedForType = "OperatorNotImplementedForType";

	internal const string ParameterExpressionNotValidAsDelegate = "ParameterExpressionNotValidAsDelegate";

	internal const string ParameterNotCaptured = "ParameterNotCaptured";

	internal const string PropertyNotDefinedForType = "PropertyNotDefinedForType";

	internal const string MethodNotDefinedForType = "MethodNotDefinedForType";

	internal const string TypeContainsGenericParameters = "TypeContainsGenericParameters";

	internal const string TypeIsGeneric = "TypeIsGeneric";

	internal const string TypeMissingDefaultConstructor = "TypeMissingDefaultConstructor";

	internal const string ListInitializerWithZeroMembers = "ListInitializerWithZeroMembers";

	internal const string ElementInitializerMethodNotAdd = "ElementInitializerMethodNotAdd";

	internal const string ElementInitializerMethodNoRefOutParam = "ElementInitializerMethodNoRefOutParam";

	internal const string ElementInitializerMethodWithZeroArgs = "ElementInitializerMethodWithZeroArgs";

	internal const string ElementInitializerMethodStatic = "ElementInitializerMethodStatic";

	internal const string TypeNotIEnumerable = "TypeNotIEnumerable";

	internal const string TypeParameterIsNotDelegate = "TypeParameterIsNotDelegate";

	internal const string UnexpectedCoalesceOperator = "UnexpectedCoalesceOperator";

	internal const string InvalidCast = "InvalidCast";

	internal const string UnhandledCall = "UnhandledCall";

	internal const string UnhandledBinary = "UnhandledBinary";

	internal const string UnhandledBinding = "UnhandledBinding";

	internal const string UnhandledBindingType = "UnhandledBindingType";

	internal const string UnhandledConvert = "UnhandledConvert";

	internal const string UnhandledConvertFromDecimal = "UnhandledConvertFromDecimal";

	internal const string UnhandledConvertToDecimal = "UnhandledConvertToDecimal";

	internal const string UnhandledExpressionType = "UnhandledExpressionType";

	internal const string UnhandledMemberAccess = "UnhandledMemberAccess";

	internal const string UnhandledUnary = "UnhandledUnary";

	internal const string UnknownBindingType = "UnknownBindingType";

	internal const string LogicalOperatorMustHaveConsistentTypes = "LogicalOperatorMustHaveConsistentTypes";

	internal const string LogicalOperatorMustHaveBooleanOperators = "LogicalOperatorMustHaveBooleanOperators";

	internal const string MethodDoesNotExistOnType = "MethodDoesNotExistOnType";

	internal const string MethodWithArgsDoesNotExistOnType = "MethodWithArgsDoesNotExistOnType";

	internal const string MethodWithMoreThanOneMatch = "MethodWithMoreThanOneMatch";

	internal const string IncorrectNumberOfTypeArgsForFunc = "IncorrectNumberOfTypeArgsForFunc";

	internal const string IncorrectNumberOfTypeArgsForAction = "IncorrectNumberOfTypeArgsForAction";

	internal const string ExpressionMayNotContainByrefParameters = "ExpressionMayNotContainByrefParameters";

	private static SR loader;

	private ResourceManager resources;

	private static CultureInfo Culture => null;

	public static ResourceManager Resources => GetLoader().resources;

	internal SR()
	{
		resources = new ResourceManager("System.Linq.Expressions", GetType().Assembly);
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			SR value = new SR();
			Interlocked.CompareExchange(ref loader, value, null);
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string @string = sR.resources.GetString(name, Culture);
		if (args != null && args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] is string text && text.Length > 1024)
				{
					args[i] = text.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}
		return @string;
	}

	public static string GetString(string name)
	{
		return GetLoader()?.resources.GetString(name, Culture);
	}

	public static object GetObject(string name)
	{
		return GetLoader()?.resources.GetObject(name, Culture);
	}
}

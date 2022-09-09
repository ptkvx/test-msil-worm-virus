using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public abstract class Expression
{
	private ExpressionType nodeType;

	private Type type;

	private static Type[] lambdaTypes = new Type[2]
	{
		typeof(Expression),
		typeof(IEnumerable<ParameterExpression>)
	};

	private static readonly Type[] funcTypes = new Type[5]
	{
		typeof(Func<>),
		typeof(Func<, >),
		typeof(Func<, , >),
		typeof(Func<, , , >),
		typeof(Func<, , , , >)
	};

	private static readonly Type[] actionTypes = new Type[5]
	{
		typeof(Action),
		typeof(Action<>),
		typeof(Action<, >),
		typeof(Action<, , >),
		typeof(Action<, , , >)
	};

	public ExpressionType NodeType => nodeType;

	public Type Type => type;

	protected Expression(ExpressionType nodeType, Type type)
	{
		this.nodeType = nodeType;
		this.type = type;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		BuildString(stringBuilder);
		return stringBuilder.ToString();
	}

	internal virtual void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		builder.Append("[");
		builder.Append(nodeType.ToString());
		builder.Append("]");
	}

	public static BinaryExpression Add(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsArithmetic(left.Type))
		{
			return new BinaryExpression(ExpressionType.Add, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Add, "op_Addition", left, right, liftToNull: true);
	}

	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return Add(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Add, left, right, method, liftToNull: true);
	}

	public static BinaryExpression AddChecked(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsArithmetic(left.Type))
		{
			return new BinaryExpression(ExpressionType.AddChecked, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.AddChecked, "op_Addition", left, right, liftToNull: false);
	}

	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return AddChecked(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.AddChecked, left, right, method, liftToNull: true);
	}

	public static BinaryExpression And(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsIntegerOrBool(left.Type))
		{
			return new BinaryExpression(ExpressionType.And, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.And, "op_BitwiseAnd", left, right, liftToNull: true);
	}

	public static BinaryExpression And(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return And(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.And, left, right, method, liftToNull: true);
	}

	public static BinaryExpression AndAlso(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsBool(left.Type))
		{
			return new BinaryExpression(ExpressionType.AndAlso, left, right, left.Type);
		}
		MethodInfo userDefinedBinaryOperator = GetUserDefinedBinaryOperator(ExpressionType.AndAlso, left.Type, right.Type, "op_BitwiseAnd");
		if ((object)userDefinedBinaryOperator != null)
		{
			ValidateUserDefinedConditionalLogicOperator(ExpressionType.AndAlso, left.Type, right.Type, userDefinedBinaryOperator);
			Type type = ((!IsNullableType(left.Type) || (object)userDefinedBinaryOperator.ReturnType != GetNonNullableType(left.Type)) ? userDefinedBinaryOperator.ReturnType : left.Type);
			return new BinaryExpression(ExpressionType.AndAlso, left, right, userDefinedBinaryOperator, type);
		}
		throw Error.BinaryOperatorNotDefined(ExpressionType.AndAlso, left.Type, right.Type);
	}

	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return AndAlso(left, right);
		}
		ValidateUserDefinedConditionalLogicOperator(ExpressionType.AndAlso, left.Type, right.Type, method);
		Type type = ((!IsNullableType(left.Type) || (object)method.ReturnType != GetNonNullableType(left.Type)) ? method.ReturnType : left.Type);
		return new BinaryExpression(ExpressionType.AndAlso, left, right, method, type);
	}

	public static BinaryExpression ArrayIndex(Expression array, Expression index)
	{
		if (array == null)
		{
			throw Error.ArgumentNull("array");
		}
		if (index == null)
		{
			throw Error.ArgumentNull("index");
		}
		if ((object)index.Type != typeof(int))
		{
			throw Error.ArgumentMustBeArrayIndexType();
		}
		if (!array.Type.IsArray)
		{
			throw Error.ArgumentMustBeArray();
		}
		if (array.Type.GetArrayRank() != 1)
		{
			throw Error.IncorrectNumberOfIndexes();
		}
		return new BinaryExpression(ExpressionType.ArrayIndex, array, index, array.Type.GetElementType());
	}

	public static MethodCallExpression ArrayIndex(Expression array, params Expression[] indexes)
	{
		return ArrayIndex(array, (IEnumerable<Expression>)indexes);
	}

	public static MethodCallExpression ArrayIndex(Expression array, IEnumerable<Expression> indexes)
	{
		if (array == null)
		{
			throw Error.ArgumentNull("array");
		}
		if (indexes == null)
		{
			throw Error.ArgumentNull("indexes");
		}
		if (!array.Type.IsArray)
		{
			throw Error.ArgumentMustBeArray();
		}
		ReadOnlyCollection<Expression> readOnlyCollection = indexes.ToReadOnlyCollection();
		if (array.Type.GetArrayRank() != readOnlyCollection.Count)
		{
			throw Error.IncorrectNumberOfIndexes();
		}
		foreach (Expression item in readOnlyCollection)
		{
			if ((object)item.Type != typeof(int))
			{
				throw Error.ArgumentMustBeArrayIndexType();
			}
		}
		MethodInfo method = array.Type.GetMethod("Get", BindingFlags.Instance | BindingFlags.Public);
		return Call(array, method, readOnlyCollection);
	}

	public static UnaryExpression ArrayLength(Expression array)
	{
		if (array == null)
		{
			throw Error.ArgumentNull("array");
		}
		if (array.Type.IsArray && AreAssignable(typeof(Array), array.Type))
		{
			if (array.Type.GetArrayRank() != 1)
			{
				throw Error.ArgumentMustBeSingleDimensionalArrayType();
			}
			return new UnaryExpression(ExpressionType.ArrayLength, array, typeof(int));
		}
		throw Error.ArgumentMustBeArray();
	}

	public static MemberAssignment Bind(MemberInfo member, Expression expression)
	{
		if ((object)member == null)
		{
			throw Error.ArgumentNull("member");
		}
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		ValidateSettableFieldOrPropertyMember(member, out var memberType);
		if (!AreAssignable(memberType, expression.Type))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		return new MemberAssignment(member, expression);
	}

	private static PropertyInfo GetProperty(MethodInfo mi)
	{
		Type declaringType = mi.DeclaringType;
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | (mi.IsStatic ? BindingFlags.Static : BindingFlags.Instance);
		PropertyInfo[] properties = declaringType.GetProperties(bindingFlags);
		PropertyInfo[] array = properties;
		int num = 0;
		PropertyInfo propertyInfo;
		while (true)
		{
			if (num < array.Length)
			{
				propertyInfo = array[num];
				if (!propertyInfo.CanRead || !CheckMethod(mi, propertyInfo.GetGetMethod(nonPublic: true)))
				{
					if (propertyInfo.CanWrite && CheckMethod(mi, propertyInfo.GetSetMethod(nonPublic: true)))
					{
						break;
					}
					num++;
					continue;
				}
				return propertyInfo;
			}
			throw Error.MethodNotPropertyAccessor(mi.DeclaringType, mi.Name);
		}
		return propertyInfo;
	}

	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod)
	{
		if ((object)method == propertyMethod)
		{
			return true;
		}
		Type declaringType = method.DeclaringType;
		if (declaringType.IsInterface && method.Name == propertyMethod.Name && (object)declaringType.GetMethod(method.Name) == propertyMethod)
		{
			return true;
		}
		return false;
	}

	public static MemberAssignment Bind(MethodInfo propertyAccessor, Expression expression)
	{
		if ((object)propertyAccessor == null)
		{
			throw Error.ArgumentNull("propertyAccessor");
		}
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		ValidateMethodInfo(propertyAccessor);
		return Bind(GetProperty(propertyAccessor), expression);
	}

	public static MethodCallExpression Call(MethodInfo method, params Expression[] arguments)
	{
		return Call(null, method, arguments.ToReadOnlyCollection());
	}

	public static MethodCallExpression Call(Expression instance, MethodInfo method, params Expression[] arguments)
	{
		return Call(instance, method, arguments.ToReadOnlyCollection());
	}

	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments)
	{
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnlyCollection();
		ValidateCallArgs(instance, method, ref arguments2);
		return new MethodCallExpression(ExpressionType.Call, method, instance, arguments2);
	}

	public static MethodCallExpression Call(Expression instance, MethodInfo method)
	{
		return Call(instance, method, (Expression[])null);
	}

	private static void ValidateCallArgs(Expression instance, MethodInfo method, ref ReadOnlyCollection<Expression> arguments)
	{
		if ((object)method == null)
		{
			throw Error.ArgumentNull("method");
		}
		if (arguments == null)
		{
			throw Error.ArgumentNull("arguments");
		}
		ValidateMethodInfo(method);
		if (!method.IsStatic)
		{
			if (instance == null)
			{
				throw Error.ArgumentNull("instance");
			}
			ValidateCallInstanceType(instance.Type, method);
		}
		ValidateArgumentTypes(method, ref arguments);
	}

	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method)
	{
		if (!AreReferenceAssignable(method.DeclaringType, instanceType) && (!instanceType.IsValueType || (!AreReferenceAssignable(method.DeclaringType, typeof(object)) && !AreReferenceAssignable(method.DeclaringType, typeof(ValueType)) && !AreReferenceAssignable(method.DeclaringType, typeof(Enum)))))
		{
			throw Error.MethodNotDefinedForType(method, instanceType);
		}
	}

	private static void ValidateArgumentTypes(MethodInfo method, ref ReadOnlyCollection<Expression> arguments)
	{
		ParameterInfo[] parameters = method.GetParameters();
		if (parameters.Length > 0)
		{
			if (parameters.Length != arguments.Count)
			{
				throw Error.IncorrectNumberOfMethodCallArguments(method);
			}
			List<Expression> list = null;
			int num = 0;
			int num2 = parameters.Length;
			while (true)
			{
				if (num < num2)
				{
					Expression expression = arguments[num];
					ParameterInfo parameterInfo = parameters[num];
					if (expression != null)
					{
						Type type = parameterInfo.ParameterType;
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						ValidateType(type);
						if (!AreReferenceAssignable(type, expression.Type))
						{
							if (!IsSameOrSubclass(typeof(Expression), type) || !AreAssignable(type, expression.GetType()))
							{
								throw Error.ExpressionTypeDoesNotMatchMethodParameter(expression.Type, type, method);
							}
							expression = Quote(expression);
						}
						if (list == null && expression != arguments[num])
						{
							list = new List<Expression>(arguments.Count);
							for (int i = 0; i < num; i++)
							{
								list.Add(arguments[i]);
							}
						}
						list?.Add(expression);
						num++;
						continue;
					}
					throw Error.ArgumentNull("arguments");
				}
				if (list != null)
				{
					arguments = list.ToReadOnlyCollection();
				}
				break;
			}
		}
		else if (arguments.Count > 0)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
	}

	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, params Expression[] arguments)
	{
		if (instance == null)
		{
			throw Error.ArgumentNull("instance");
		}
		if (methodName == null)
		{
			throw Error.ArgumentNull("methodName");
		}
		if (arguments == null)
		{
			arguments = new Expression[0];
		}
		return Call(instance, FindMethod(instance.Type, methodName, typeArguments, arguments, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy), arguments);
	}

	public static MethodCallExpression Call(Type type, string methodName, Type[] typeArguments, params Expression[] arguments)
	{
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (methodName == null)
		{
			throw Error.ArgumentNull("methodName");
		}
		if (arguments == null)
		{
			arguments = new Expression[0];
		}
		return Call(null, FindMethod(type, methodName, typeArguments, arguments, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy), arguments);
	}

	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags)
	{
		MemberInfo[] array = type.FindMembers(MemberTypes.Method, flags, Type.FilterNameIgnoreCase, methodName);
		if (array != null && array.Length != 0)
		{
			MethodInfo method;
			int num = FindBestMethod(array.Cast<MethodInfo>(), typeArgs, args, out method);
			if (num == 0)
			{
				throw Error.MethodWithArgsDoesNotExistOnType(methodName, type);
			}
			if (num > 1)
			{
				throw Error.MethodWithMoreThanOneMatch(methodName, type);
			}
			return method;
		}
		throw Error.MethodDoesNotExistOnType(methodName, type);
	}

	private static int FindBestMethod(IEnumerable<MethodInfo> methods, Type[] typeArgs, Expression[] args, out MethodInfo method)
	{
		int num = 0;
		method = null;
		foreach (MethodInfo method2 in methods)
		{
			MethodInfo methodInfo = ApplyTypeArgs(method2, typeArgs);
			if ((object)methodInfo == null || !IsCompatible(methodInfo, args))
			{
				continue;
			}
			if ((object)method != null && (method.IsPublic || !methodInfo.IsPublic))
			{
				if (method.IsPublic == methodInfo.IsPublic)
				{
					num++;
				}
			}
			else
			{
				method = methodInfo;
				num = 1;
			}
		}
		return num;
	}

	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs)
	{
		if (typeArgs != null && typeArgs.Length != 0)
		{
			if (m.IsGenericMethodDefinition && m.GetGenericArguments().Length == typeArgs.Length)
			{
				return m.MakeGenericMethod(typeArgs);
			}
		}
		else if (!m.IsGenericMethodDefinition)
		{
			return m;
		}
		return null;
	}

	private static bool IsCompatible(MethodInfo m, Expression[] args)
	{
		ParameterInfo[] parameters = m.GetParameters();
		if (parameters.Length != args.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < args.Length)
			{
				Expression expression = args[num];
				if (expression != null)
				{
					Type src = expression.Type;
					Type type = parameters[num].ParameterType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!AreReferenceAssignable(type, src) && (!IsSameOrSubclass(typeof(Expression), type) || !AreAssignable(type, expression.GetType())))
					{
						break;
					}
					num++;
					continue;
				}
				throw Error.ArgumentNull("argument");
			}
			return true;
		}
		return false;
	}

	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if (conversion == null)
		{
			return Coalesce(left, right);
		}
		if (left.Type.IsValueType && !IsNullableType(left.Type))
		{
			throw Error.CoalesceUsedOnNonNullType();
		}
		Type type = conversion.Type;
		MethodInfo method = type.GetMethod("Invoke");
		if ((object)method.ReturnType == typeof(void))
		{
			throw Error.UserDefinedOperatorMustNotBeVoid(conversion);
		}
		ParameterInfo[] parameters = method.GetParameters();
		if (parameters.Length != 1)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(conversion);
		}
		if ((object)method.ReturnType != right.Type)
		{
			throw Error.OperandTypesDoNotMatchParameters(ExpressionType.Coalesce, conversion.ToString());
		}
		if (!ParameterIsAssignable(parameters[0], GetNonNullableType(left.Type)) && !ParameterIsAssignable(parameters[0], left.Type))
		{
			throw Error.OperandTypesDoNotMatchParameters(ExpressionType.Coalesce, conversion.ToString());
		}
		return new BinaryExpression(ExpressionType.Coalesce, left, right, conversion, right.Type);
	}

	public static BinaryExpression Coalesce(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		Type type = ValidateCoalesceArgTypes(left.Type, right.Type);
		return new BinaryExpression(ExpressionType.Coalesce, left, right, type);
	}

	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse)
	{
		if (test == null)
		{
			throw Error.ArgumentNull("test");
		}
		if (ifTrue == null)
		{
			throw Error.ArgumentNull("ifTrue");
		}
		if (ifFalse == null)
		{
			throw Error.ArgumentNull("ifFalse");
		}
		if ((object)test.Type != typeof(bool))
		{
			throw Error.ArgumentMustBeBoolean();
		}
		ValidateSameArgTypes(ifTrue.Type, ifFalse.Type);
		return new ConditionalExpression(test, ifTrue, ifFalse, ifTrue.Type);
	}

	public static ConstantExpression Constant(object value)
	{
		Type type = ((value != null) ? value.GetType() : typeof(object));
		return Constant(value, type);
	}

	public static ConstantExpression Constant(object value, Type type)
	{
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (value == null && type.IsValueType && !IsNullableType(type))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		if (value != null && !AreAssignable(type, value.GetType()))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		return new ConstantExpression(value, type);
	}

	private static bool HasIdentityPrimitiveOrNullableConversion(Type source, Type dest)
	{
		if ((object)source == dest)
		{
			return true;
		}
		if (IsNullableType(source) && (object)dest == GetNonNullableType(source))
		{
			return true;
		}
		if (IsNullableType(dest) && (object)source == GetNonNullableType(dest))
		{
			return true;
		}
		if (IsConvertible(source) && IsConvertible(dest) && (object)GetNonNullableType(dest) != typeof(bool))
		{
			return true;
		}
		return false;
	}

	private static bool HasReferenceConversion(Type source, Type dest)
	{
		Type nonNullableType = GetNonNullableType(source);
		Type nonNullableType2 = GetNonNullableType(dest);
		if (AreAssignable(nonNullableType, nonNullableType2))
		{
			return true;
		}
		if (AreAssignable(nonNullableType2, nonNullableType))
		{
			return true;
		}
		if (!source.IsInterface && !dest.IsInterface)
		{
			if ((object)source != typeof(object) && (object)dest != typeof(object))
			{
				return false;
			}
			return true;
		}
		return true;
	}

	public static UnaryExpression Convert(Expression expression, Type type)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (!HasIdentityPrimitiveOrNullableConversion(expression.Type, type) && !HasReferenceConversion(expression.Type, type))
		{
			return GetUserDefinedCoercionOrThrow(ExpressionType.Convert, expression, type);
		}
		return new UnaryExpression(ExpressionType.Convert, expression, type);
	}

	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)method == null)
		{
			return Convert(expression, type);
		}
		return GetMethodBasedCoercionOperator(ExpressionType.Convert, expression, type, method);
	}

	public static UnaryExpression ConvertChecked(Expression expression, Type type)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (HasIdentityPrimitiveOrNullableConversion(expression.Type, type))
		{
			return new UnaryExpression(ExpressionType.ConvertChecked, expression, type);
		}
		if (HasReferenceConversion(expression.Type, type))
		{
			return new UnaryExpression(ExpressionType.Convert, expression, type);
		}
		return GetUserDefinedCoercionOrThrow(ExpressionType.ConvertChecked, expression, type);
	}

	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)method == null)
		{
			return ConvertChecked(expression, type);
		}
		return GetMethodBasedCoercionOperator(ExpressionType.ConvertChecked, expression, type, method);
	}

	public static BinaryExpression Divide(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsArithmetic(left.Type))
		{
			return new BinaryExpression(ExpressionType.Divide, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Divide, "op_Division", left, right, liftToNull: true);
	}

	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return Divide(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Divide, left, right, method, liftToNull: true);
	}

	public static BinaryExpression Equal(Expression left, Expression right)
	{
		return Equal(left, right, liftToNull: false, null);
	}

	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return GetEqualityComparisonOperator(ExpressionType.Equal, "op_Equality", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Equal, left, right, method, liftToNull);
	}

	public static BinaryExpression ExclusiveOr(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsIntegerOrBool(left.Type))
		{
			return new BinaryExpression(ExpressionType.ExclusiveOr, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.ExclusiveOr, "op_ExclusiveOr", left, right, liftToNull: true);
	}

	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return ExclusiveOr(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.ExclusiveOr, left, right, method, liftToNull: true);
	}

	public static MemberExpression Field(Expression expression, FieldInfo field)
	{
		if ((object)field == null)
		{
			throw Error.ArgumentNull("field");
		}
		if (!field.IsStatic)
		{
			if (expression == null)
			{
				throw Error.ArgumentNull("expression");
			}
			if (!AreReferenceAssignable(field.DeclaringType, expression.Type))
			{
				throw Error.FieldNotDefinedForType(field, expression.Type);
			}
		}
		return new MemberExpression(expression, field, field.FieldType);
	}

	public static MemberExpression Field(Expression expression, string fieldName)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		FieldInfo field = expression.Type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if ((object)field == null)
		{
			field = expression.Type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		}
		if ((object)field == null)
		{
			throw Error.FieldNotDefinedForType(fieldName, expression.Type);
		}
		return Field(expression, field);
	}

	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right)
	{
		return GreaterThanOrEqual(left, right, liftToNull: false, null);
	}

	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return GetComparisonOperator(ExpressionType.GreaterThanOrEqual, "op_GreaterThanOrEqual", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.GreaterThanOrEqual, left, right, method, liftToNull);
	}

	public static BinaryExpression GreaterThan(Expression left, Expression right)
	{
		return GreaterThan(left, right, liftToNull: false, null);
	}

	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return GetComparisonOperator(ExpressionType.GreaterThan, "op_GreaterThan", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.GreaterThan, left, right, method, liftToNull);
	}

	public static InvocationExpression Invoke(Expression expression, params Expression[] arguments)
	{
		return Invoke(expression, arguments.ToReadOnlyCollection());
	}

	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		Type type = expression.Type;
		if ((object)type == typeof(Delegate))
		{
			throw Error.ExpressionTypeNotInvocable(type);
		}
		if (!AreAssignable(typeof(Delegate), expression.Type))
		{
			Type type2 = TypeHelper.FindGenericType(typeof(Expression<>), expression.Type);
			if ((object)type2 == null)
			{
				throw Error.ExpressionTypeNotInvocable(expression.Type);
			}
			type = type2.GetGenericArguments()[0];
		}
		MethodInfo method = type.GetMethod("Invoke");
		ParameterInfo[] parameters = method.GetParameters();
		ReadOnlyCollection<Expression> readOnlyCollection = arguments.ToReadOnlyCollection();
		if (parameters.Length > 0)
		{
			if (readOnlyCollection.Count != parameters.Length)
			{
				throw Error.IncorrectNumberOfLambdaArguments();
			}
			List<Expression> list = null;
			int i = 0;
			for (int count = readOnlyCollection.Count; i < count; i++)
			{
				Expression expression2 = readOnlyCollection[i];
				ParameterInfo parameterInfo = parameters[i];
				if (expression2 != null)
				{
					Type type3 = parameterInfo.ParameterType;
					if (type3.IsByRef)
					{
						type3 = type3.GetElementType();
					}
					if (!AreReferenceAssignable(type3, expression2.Type))
					{
						if (!IsSameOrSubclass(typeof(Expression), type3) || !AreAssignable(type3, expression2.GetType()))
						{
							throw Error.ExpressionTypeDoesNotMatchParameter(expression2.Type, type3);
						}
						expression2 = Quote(expression2);
					}
					if (list == null && expression2 != readOnlyCollection[i])
					{
						list = new List<Expression>(readOnlyCollection.Count);
						for (int j = 0; j < i; j++)
						{
							list.Add(readOnlyCollection[j]);
						}
					}
					list?.Add(expression2);
					continue;
				}
				throw Error.ArgumentNull("arguments");
			}
			if (list != null)
			{
				readOnlyCollection = list.ToReadOnlyCollection();
			}
		}
		else if (readOnlyCollection.Count > 0)
		{
			throw Error.IncorrectNumberOfLambdaArguments();
		}
		return new InvocationExpression(expression, method.ReturnType, readOnlyCollection);
	}

	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters)
	{
		return Lambda<TDelegate>(body, parameters.ToReadOnlyCollection());
	}

	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters)
	{
		if (body == null)
		{
			throw Error.ArgumentNull("body");
		}
		ReadOnlyCollection<ParameterExpression> parameters2 = parameters.ToReadOnlyCollection();
		ValidateLambdaArgs(typeof(TDelegate), ref body, parameters2);
		return new Expression<TDelegate>(body, parameters2);
	}

	public static LambdaExpression Lambda(Type delegateType, Expression body, params ParameterExpression[] parameters)
	{
		return Lambda(delegateType, body, parameters.ToReadOnlyCollection());
	}

	public static LambdaExpression Lambda(Type delegateType, Expression body, IEnumerable<ParameterExpression> parameters)
	{
		if ((object)delegateType == null)
		{
			throw Error.ArgumentNull("delegateType");
		}
		if (body == null)
		{
			throw Error.ArgumentNull("body");
		}
		ReadOnlyCollection<ParameterExpression> readOnlyCollection = parameters.ToReadOnlyCollection();
		ValidateLambdaArgs(delegateType, ref body, readOnlyCollection);
		MethodInfo method = typeof(Expression).GetMethod("Lambda", BindingFlags.Static | BindingFlags.Public, null, lambdaTypes, null);
		MethodInfo methodInfo = method.MakeGenericMethod(delegateType);
		return (LambdaExpression)methodInfo.Invoke(null, new object[2] { body, readOnlyCollection });
	}

	public static LambdaExpression Lambda(Expression body, params ParameterExpression[] parameters)
	{
		if (body == null)
		{
			throw Error.ArgumentNull("body");
		}
		bool flag = (object)body.Type == typeof(void);
		int num = ((parameters != null) ? parameters.Length : 0);
		Type[] array = new Type[num + ((!flag) ? 1 : 0)];
		int num2 = 0;
		Type delegateType;
		while (true)
		{
			if (num2 < num)
			{
				if (parameters[num2] != null)
				{
					array[num2] = parameters[num2].Type;
					num2++;
					continue;
				}
				throw Error.ArgumentNull("parameter");
			}
			if (flag)
			{
				delegateType = GetActionType(array);
				break;
			}
			array[num] = body.Type;
			delegateType = GetFuncType(array);
			break;
		}
		return Lambda(delegateType, body, parameters);
	}

	public static Type GetFuncType(params Type[] typeArgs)
	{
		if (typeArgs == null)
		{
			throw Error.ArgumentNull("typeArgs");
		}
		if (typeArgs.Length < 1 || typeArgs.Length > 5)
		{
			throw Error.IncorrectNumberOfTypeArgsForFunc();
		}
		return funcTypes[typeArgs.Length - 1].MakeGenericType(typeArgs);
	}

	public static Type GetActionType(params Type[] typeArgs)
	{
		if (typeArgs == null)
		{
			throw Error.ArgumentNull("typeArgs");
		}
		if (typeArgs.Length >= actionTypes.Length)
		{
			throw Error.IncorrectNumberOfTypeArgsForAction();
		}
		if (typeArgs.Length == 0)
		{
			return actionTypes[typeArgs.Length];
		}
		return actionTypes[typeArgs.Length].MakeGenericType(typeArgs);
	}

	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters)
	{
		if ((object)delegateType == null)
		{
			throw Error.ArgumentNull("delegateType");
		}
		if (body == null)
		{
			throw Error.ArgumentNull("body");
		}
		if (AreAssignable(typeof(Delegate), delegateType) && (object)delegateType != typeof(Delegate))
		{
			MethodInfo method = delegateType.GetMethod("Invoke");
			ParameterInfo[] parameters2 = method.GetParameters();
			if (parameters2.Length > 0)
			{
				if (parameters2.Length != parameters.Count)
				{
					throw Error.IncorrectNumberOfLambdaDeclarationParameters();
				}
				int i = 0;
				for (int num = parameters2.Length; i < num; i++)
				{
					Expression expression = parameters[i];
					ParameterInfo parameterInfo = parameters2[i];
					if (expression != null)
					{
						Type parameterType = parameterInfo.ParameterType;
						if (!parameterType.IsByRef && !expression.Type.IsByRef)
						{
							if (!AreReferenceAssignable(expression.Type, parameterType))
							{
								throw Error.ParameterExpressionNotValidAsDelegate(expression.Type, parameterType);
							}
							continue;
						}
						throw Error.ExpressionMayNotContainByrefParameters();
					}
					throw Error.ArgumentNull("parameters");
				}
			}
			else if (parameters.Count > 0)
			{
				throw Error.IncorrectNumberOfLambdaDeclarationParameters();
			}
			if ((object)method.ReturnType != typeof(void) && !AreReferenceAssignable(method.ReturnType, body.Type))
			{
				if (!IsSameOrSubclass(typeof(Expression), method.ReturnType) || !AreAssignable(method.ReturnType, body.GetType()))
				{
					throw Error.ExpressionTypeDoesNotMatchReturn(body.Type, method.ReturnType);
				}
				body = Quote(body);
			}
			return;
		}
		throw Error.LambdaTypeMustBeDerivedFromSystemDelegate();
	}

	public static BinaryExpression LeftShift(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if (IsInteger(left.Type) && (object)GetNonNullableType(right.Type) == typeof(int))
		{
			return new BinaryExpression(ExpressionType.LeftShift, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.LeftShift, "op_LeftShift", left, right, liftToNull: true);
	}

	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return LeftShift(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.LeftShift, left, right, method, liftToNull: true);
	}

	public static BinaryExpression LessThan(Expression left, Expression right)
	{
		return LessThan(left, right, liftToNull: false, null);
	}

	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return GetComparisonOperator(ExpressionType.LessThan, "op_LessThan", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.LessThan, left, right, method, liftToNull);
	}

	public static BinaryExpression LessThanOrEqual(Expression left, Expression right)
	{
		return LessThanOrEqual(left, right, liftToNull: false, null);
	}

	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return GetComparisonOperator(ExpressionType.LessThanOrEqual, "op_LessThanOrEqual", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.LessThanOrEqual, left, right, method, liftToNull);
	}

	internal static void ValidateLift(IEnumerable<ParameterExpression> parameters, IEnumerable<Expression> arguments)
	{
		ReadOnlyCollection<ParameterExpression> readOnlyCollection = parameters.ToReadOnlyCollection();
		ReadOnlyCollection<Expression> readOnlyCollection2 = arguments.ToReadOnlyCollection();
		if (readOnlyCollection.Count != readOnlyCollection2.Count)
		{
			throw Error.IncorrectNumberOfIndexes();
		}
		int num = 0;
		int count = readOnlyCollection.Count;
		while (true)
		{
			if (num < count)
			{
				if (!AreReferenceAssignable(readOnlyCollection[num].Type, GetNonNullableType(readOnlyCollection2[num].Type)))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		throw Error.ArgumentTypesMustMatch();
	}

	public static ListInitExpression ListInit(NewExpression newExpression, params Expression[] initializers)
	{
		if (newExpression == null)
		{
			throw Error.ArgumentNull("newExpression");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		return ListInit(newExpression, (IEnumerable<Expression>)initializers);
	}

	public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<Expression> initializers)
	{
		if (newExpression == null)
		{
			throw Error.ArgumentNull("newExpression");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		if (!initializers.Any())
		{
			throw Error.ListInitializerWithZeroMembers();
		}
		MethodInfo addMethod = FindMethod(newExpression.Type, "Add", null, new Expression[1] { initializers.First() }, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		return ListInit(newExpression, addMethod, initializers);
	}

	public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, params Expression[] initializers)
	{
		if (newExpression == null)
		{
			throw Error.ArgumentNull("newExpression");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		if ((object)addMethod == null)
		{
			return ListInit(newExpression, (IEnumerable<Expression>)initializers);
		}
		return ListInit(newExpression, addMethod, (IEnumerable<Expression>)initializers);
	}

	public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, IEnumerable<Expression> initializers)
	{
		if (newExpression == null)
		{
			throw Error.ArgumentNull("newExpression");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		if (!initializers.Any())
		{
			throw Error.ListInitializerWithZeroMembers();
		}
		if ((object)addMethod == null)
		{
			return ListInit(newExpression, initializers);
		}
		return ListInit(newExpression, from Expression initializer in initializers
			select ElementInit(addMethod, initializer));
	}

	public static ListInitExpression ListInit(NewExpression newExpression, params ElementInit[] initializers)
	{
		if (newExpression == null)
		{
			throw Error.ArgumentNull("newExpression");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		return ListInit(newExpression, initializers.ToReadOnlyCollection());
	}

	public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<ElementInit> initializers)
	{
		if (newExpression == null)
		{
			throw Error.ArgumentNull("newExpression");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		if (!initializers.Any())
		{
			throw Error.ListInitializerWithZeroMembers();
		}
		ReadOnlyCollection<ElementInit> initializers2 = initializers.ToReadOnlyCollection();
		ValidateListInitArgs(newExpression.Type, initializers2);
		return new ListInitExpression(newExpression, initializers2);
	}

	public static ElementInit ElementInit(MethodInfo addMethod, params Expression[] arguments)
	{
		return ElementInit(addMethod, (IEnumerable<Expression>)arguments);
	}

	public static ElementInit ElementInit(MethodInfo addMethod, IEnumerable<Expression> arguments)
	{
		if ((object)addMethod == null)
		{
			throw Error.ArgumentNull("addMethod");
		}
		if (arguments == null)
		{
			throw Error.ArgumentNull("arguments");
		}
		ValidateElementInitAddMethodInfo(addMethod);
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnlyCollection();
		ValidateArgumentTypes(addMethod, ref arguments2);
		return new ElementInit(addMethod, arguments2);
	}

	public static MemberListBinding ListBind(MemberInfo member, params ElementInit[] initializers)
	{
		if ((object)member == null)
		{
			throw Error.ArgumentNull("member");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		return ListBind(member, initializers.ToReadOnlyCollection());
	}

	public static MemberListBinding ListBind(MemberInfo member, IEnumerable<ElementInit> initializers)
	{
		if ((object)member == null)
		{
			throw Error.ArgumentNull("member");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		ValidateGettableFieldOrPropertyMember(member, out var memberType);
		ReadOnlyCollection<ElementInit> initializers2 = initializers.ToReadOnlyCollection();
		ValidateListInitArgs(memberType, initializers2);
		return new MemberListBinding(member, initializers2);
	}

	public static MemberListBinding ListBind(MethodInfo propertyAccessor, params ElementInit[] initializers)
	{
		if ((object)propertyAccessor == null)
		{
			throw Error.ArgumentNull("propertyAccessor");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		return ListBind(propertyAccessor, initializers.ToReadOnlyCollection());
	}

	public static MemberListBinding ListBind(MethodInfo propertyAccessor, IEnumerable<ElementInit> initializers)
	{
		if ((object)propertyAccessor == null)
		{
			throw Error.ArgumentNull("propertyAccessor");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		return ListBind(GetProperty(propertyAccessor), initializers);
	}

	private static void ValidateListInitArgs(Type listType, ReadOnlyCollection<ElementInit> initializers)
	{
		if (!AreAssignable(typeof(IEnumerable), listType))
		{
			throw Error.TypeNotIEnumerable(listType);
		}
		int num = 0;
		int count = initializers.Count;
		while (true)
		{
			if (num < count)
			{
				ElementInit elementInit = initializers[num];
				if (elementInit == null)
				{
					break;
				}
				ValidateCallInstanceType(listType, elementInit.AddMethod);
				num++;
				continue;
			}
			return;
		}
		throw Error.ArgumentNull("initializers");
	}

	public static MemberInitExpression MemberInit(NewExpression newExpression, params MemberBinding[] bindings)
	{
		if (newExpression == null)
		{
			throw Error.ArgumentNull("newExpression");
		}
		if (bindings == null)
		{
			throw Error.ArgumentNull("bindings");
		}
		return MemberInit(newExpression, bindings.ToReadOnlyCollection());
	}

	public static MemberInitExpression MemberInit(NewExpression newExpression, IEnumerable<MemberBinding> bindings)
	{
		if (newExpression == null)
		{
			throw Error.ArgumentNull("newExpression");
		}
		if (bindings == null)
		{
			throw Error.ArgumentNull("bindings");
		}
		ReadOnlyCollection<MemberBinding> bindings2 = bindings.ToReadOnlyCollection();
		ValidateMemberInitArgs(newExpression.Type, bindings2);
		return new MemberInitExpression(newExpression, bindings2);
	}

	public static MemberMemberBinding MemberBind(MemberInfo member, params MemberBinding[] bindings)
	{
		if ((object)member == null)
		{
			throw Error.ArgumentNull("member");
		}
		if (bindings == null)
		{
			throw Error.ArgumentNull("bindings");
		}
		return MemberBind(member, bindings.ToReadOnlyCollection());
	}

	public static MemberMemberBinding MemberBind(MemberInfo member, IEnumerable<MemberBinding> bindings)
	{
		if ((object)member == null)
		{
			throw Error.ArgumentNull("member");
		}
		if (bindings == null)
		{
			throw Error.ArgumentNull("bindings");
		}
		ReadOnlyCollection<MemberBinding> bindings2 = bindings.ToReadOnlyCollection();
		ValidateGettableFieldOrPropertyMember(member, out var memberType);
		ValidateMemberInitArgs(memberType, bindings2);
		return new MemberMemberBinding(member, bindings2);
	}

	public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, params MemberBinding[] bindings)
	{
		if ((object)propertyAccessor == null)
		{
			throw Error.ArgumentNull("propertyAccessor");
		}
		return MemberBind(GetProperty(propertyAccessor), bindings);
	}

	public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, IEnumerable<MemberBinding> bindings)
	{
		if ((object)propertyAccessor == null)
		{
			throw Error.ArgumentNull("propertyAccessor");
		}
		return MemberBind(GetProperty(propertyAccessor), bindings);
	}

	public static BinaryExpression Modulo(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsArithmetic(left.Type))
		{
			return new BinaryExpression(ExpressionType.Modulo, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Modulo, "op_Modulus", left, right, liftToNull: true);
	}

	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return Modulo(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Modulo, left, right, method, liftToNull: true);
	}

	public static BinaryExpression Multiply(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsArithmetic(left.Type))
		{
			return new BinaryExpression(ExpressionType.Multiply, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Multiply, "op_Multiply", left, right, liftToNull: true);
	}

	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return Multiply(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Multiply, left, right, method, liftToNull: true);
	}

	public static BinaryExpression MultiplyChecked(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsArithmetic(left.Type))
		{
			return new BinaryExpression(ExpressionType.MultiplyChecked, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.MultiplyChecked, "op_Multiply", left, right, liftToNull: true);
	}

	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return MultiplyChecked(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.MultiplyChecked, left, right, method, liftToNull: true);
	}

	public static UnaryExpression UnaryPlus(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if (IsArithmetic(expression.Type))
		{
			return new UnaryExpression(ExpressionType.UnaryPlus, expression, expression.Type);
		}
		return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.UnaryPlus, "op_UnaryPlus", expression);
	}

	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)method == null)
		{
			return UnaryPlus(expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.UnaryPlus, expression, method);
	}

	public static UnaryExpression Negate(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if (IsArithmetic(expression.Type) && !IsUnSigned(expression.Type))
		{
			return new UnaryExpression(ExpressionType.Negate, expression, expression.Type);
		}
		return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.Negate, "op_UnaryNegation", expression);
	}

	public static UnaryExpression Negate(Expression expression, MethodInfo method)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)method == null)
		{
			return Negate(expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.Negate, expression, method);
	}

	public static UnaryExpression NegateChecked(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if (IsArithmetic(expression.Type) && !IsUnSigned(expression.Type))
		{
			return new UnaryExpression(ExpressionType.NegateChecked, expression, expression.Type);
		}
		return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.NegateChecked, "op_UnaryNegation", expression);
	}

	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)method == null)
		{
			return NegateChecked(expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.NegateChecked, expression, method);
	}

	public static BinaryExpression NotEqual(Expression left, Expression right)
	{
		return NotEqual(left, right, liftToNull: false, null);
	}

	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return GetEqualityComparisonOperator(ExpressionType.NotEqual, "op_Inequality", left, right, liftToNull);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.NotEqual, left, right, method, liftToNull);
	}

	public static NewExpression New(ConstructorInfo constructor, params Expression[] arguments)
	{
		return New(constructor, arguments.ToReadOnlyCollection());
	}

	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments)
	{
		if ((object)constructor == null)
		{
			throw Error.ArgumentNull("constructor");
		}
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnlyCollection();
		ValidateNewArgs(constructor.DeclaringType, constructor, ref arguments2);
		return new NewExpression(constructor.DeclaringType, constructor, arguments2);
	}

	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members)
	{
		if ((object)constructor == null)
		{
			throw Error.ArgumentNull("constructor");
		}
		ReadOnlyCollection<MemberInfo> members2 = members.ToReadOnlyCollection();
		ReadOnlyCollection<Expression> arguments2 = arguments.ToReadOnlyCollection();
		ValidateNewArgs(constructor, ref arguments2, members2);
		return new NewExpression(constructor.DeclaringType, constructor, arguments2, members2);
	}

	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, params MemberInfo[] members)
	{
		return New(constructor, arguments, members.ToReadOnlyCollection());
	}

	public static NewExpression New(ConstructorInfo constructor)
	{
		return New(constructor, ((IEnumerable<Expression>)null).ToReadOnlyCollection());
	}

	public static NewExpression New(Type type)
	{
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		ConstructorInfo constructorInfo = null;
		if (!type.IsValueType)
		{
			constructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if ((object)constructorInfo == null)
			{
				throw Error.TypeMissingDefaultConstructor(type);
			}
			return New(constructorInfo);
		}
		ReadOnlyCollection<Expression> arguments = ((IEnumerable<Expression>)null).ToReadOnlyCollection();
		return new NewExpression(type, null, arguments);
	}

	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ReadOnlyCollection<MemberInfo> members)
	{
		ParameterInfo[] parameters;
		if ((parameters = constructor.GetParameters()).Length > 0)
		{
			if (arguments.Count != parameters.Length)
			{
				throw Error.IncorrectNumberOfConstructorArguments();
			}
			if (arguments.Count != members.Count)
			{
				throw Error.IncorrectNumberOfArgumentsForMembers();
			}
			List<Expression> list = null;
			int num = 0;
			int count = arguments.Count;
			while (true)
			{
				if (num < count)
				{
					Expression expression = arguments[num];
					if (expression != null)
					{
						MemberInfo memberInfo = members[num];
						if ((object)memberInfo != null)
						{
							if ((object)memberInfo.DeclaringType == constructor.DeclaringType)
							{
								ValidateAnonymousTypeMember(memberInfo, out var memberType);
								if (!AreReferenceAssignable(expression.Type, memberType))
								{
									if (!IsSameOrSubclass(typeof(Expression), memberType) || !AreAssignable(memberType, expression.GetType()))
									{
										throw Error.ArgumentTypeDoesNotMatchMember(expression.Type, memberType);
									}
									expression = Quote(expression);
								}
								ParameterInfo parameterInfo = parameters[num];
								Type type = parameterInfo.ParameterType;
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (!AreReferenceAssignable(type, expression.Type))
								{
									if (!IsSameOrSubclass(typeof(Expression), type) || !AreAssignable(type, expression.Type))
									{
										throw Error.ExpressionTypeDoesNotMatchConstructorParameter(expression.Type, type);
									}
									expression = Quote(expression);
								}
								if (list == null && expression != arguments[num])
								{
									list = new List<Expression>(arguments.Count);
									for (int i = 0; i < num; i++)
									{
										list.Add(arguments[i]);
									}
								}
								list?.Add(expression);
								num++;
								continue;
							}
							throw Error.ArgumentMemberNotDeclOnType(memberInfo.Name, constructor.DeclaringType!.Name);
						}
						throw Error.ArgumentNull("member");
					}
					throw Error.ArgumentNull("argument");
				}
				if (list != null)
				{
					arguments = list.ToReadOnlyCollection();
				}
				break;
			}
		}
		else
		{
			if (arguments != null && arguments.Count > 0)
			{
				throw Error.IncorrectNumberOfConstructorArguments();
			}
			if (members != null && members.Count > 0)
			{
				throw Error.IncorrectNumberOfMembersForGivenConstructor();
			}
		}
	}

	private static void ValidateNewArgs(Type type, ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments)
	{
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (!type.IsValueType && (object)constructor == null)
		{
			throw Error.ArgumentNull("constructor");
		}
		ParameterInfo[] parameters;
		if ((object)constructor != null && (parameters = constructor.GetParameters()).Length > 0)
		{
			if (arguments.Count != parameters.Length)
			{
				throw Error.IncorrectNumberOfConstructorArguments();
			}
			List<Expression> list = null;
			int num = 0;
			int count = arguments.Count;
			while (true)
			{
				if (num < count)
				{
					Expression expression = arguments[num];
					ParameterInfo parameterInfo = parameters[num];
					if (expression != null)
					{
						Type type2 = parameterInfo.ParameterType;
						if (type2.IsByRef)
						{
							type2 = type2.GetElementType();
						}
						if (!AreReferenceAssignable(type2, expression.Type))
						{
							if (!IsSameOrSubclass(typeof(Expression), type2) || !AreAssignable(type2, expression.GetType()))
							{
								throw Error.ExpressionTypeDoesNotMatchConstructorParameter(expression.Type, type2);
							}
							expression = Quote(expression);
						}
						if (list == null && expression != arguments[num])
						{
							list = new List<Expression>(arguments.Count);
							for (int i = 0; i < num; i++)
							{
								list.Add(arguments[i]);
							}
						}
						list?.Add(expression);
						num++;
						continue;
					}
					throw Error.ArgumentNull("arguments");
				}
				if (list != null)
				{
					arguments = list.ToReadOnlyCollection();
				}
				break;
			}
		}
		else if (arguments != null && arguments.Count > 0)
		{
			throw Error.IncorrectNumberOfConstructorArguments();
		}
	}

	public static NewArrayExpression NewArrayBounds(Type type, params Expression[] bounds)
	{
		if (bounds == null)
		{
			throw Error.ArgumentNull("bounds");
		}
		return NewArrayBounds(type, bounds.ToReadOnlyCollection());
	}

	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds)
	{
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (bounds == null)
		{
			throw Error.ArgumentNull("bounds");
		}
		ReadOnlyCollection<Expression> readOnlyCollection = bounds.ToReadOnlyCollection();
		int i = 0;
		for (int count = readOnlyCollection.Count; i < count; i++)
		{
			Expression expression = readOnlyCollection[i];
			if (expression != null)
			{
				ValidateIntegerArg(expression.Type);
				continue;
			}
			throw Error.ArgumentNull("bounds");
		}
		return new NewArrayExpression(ExpressionType.NewArrayBounds, type.MakeArrayType(readOnlyCollection.Count), readOnlyCollection);
	}

	public static NewArrayExpression NewArrayInit(Type type, params Expression[] initializers)
	{
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		return NewArrayInit(type, initializers.ToReadOnlyCollection());
	}

	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers)
	{
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (initializers == null)
		{
			throw Error.ArgumentNull("initializers");
		}
		ReadOnlyCollection<Expression> readOnlyCollection = initializers.ToReadOnlyCollection();
		List<Expression> list = null;
		int num = 0;
		int count = readOnlyCollection.Count;
		while (true)
		{
			if (num < count)
			{
				Expression expression = readOnlyCollection[num];
				if (expression != null)
				{
					if (!AreReferenceAssignable(type, expression.Type))
					{
						if (!IsSameOrSubclass(typeof(Expression), type) || !AreAssignable(type, expression.GetType()))
						{
							throw Error.ExpressionTypeCannotInitializeArrayType(expression.Type, type);
						}
						expression = Quote(expression);
					}
					if (list == null && expression != readOnlyCollection[num])
					{
						list = new List<Expression>(readOnlyCollection.Count);
						for (int i = 0; i < num; i++)
						{
							list.Add(readOnlyCollection[i]);
						}
					}
					list?.Add(expression);
					num++;
					continue;
				}
				throw Error.ArgumentNull("initializers");
			}
			if (list != null)
			{
				readOnlyCollection = list.ToReadOnlyCollection();
			}
			break;
		}
		return new NewArrayExpression(ExpressionType.NewArrayInit, type.MakeArrayType(), readOnlyCollection);
	}

	private static void ValidateSettableFieldOrPropertyMember(MemberInfo member, out Type memberType)
	{
		if (!(member is FieldInfo fieldInfo))
		{
			if (!(member is PropertyInfo propertyInfo))
			{
				throw Error.ArgumentMustBeFieldInfoOrPropertInfo();
			}
			if (!propertyInfo.CanWrite)
			{
				throw Error.PropertyDoesNotHaveSetter(propertyInfo);
			}
			memberType = propertyInfo.PropertyType;
		}
		else
		{
			memberType = fieldInfo.FieldType;
		}
	}

	private static void ValidateAnonymousTypeMember(MemberInfo member, out Type memberType)
	{
		switch (member.MemberType)
		{
		default:
			throw Error.ArgumentMustBeFieldInfoOrPropertInfoOrMethod();
		case MemberTypes.Property:
		{
			PropertyInfo propertyInfo = member as PropertyInfo;
			if (!propertyInfo.CanRead)
			{
				throw Error.PropertyDoesNotHaveGetter(propertyInfo);
			}
			if (propertyInfo.GetGetMethod()!.IsStatic)
			{
				throw Error.ArgumentMustBeInstanceMember();
			}
			memberType = propertyInfo.PropertyType;
			break;
		}
		case MemberTypes.Method:
		{
			MethodInfo methodInfo = member as MethodInfo;
			if (methodInfo.IsStatic)
			{
				throw Error.ArgumentMustBeInstanceMember();
			}
			memberType = methodInfo.ReturnType;
			break;
		}
		case MemberTypes.Field:
		{
			FieldInfo fieldInfo = member as FieldInfo;
			if (fieldInfo.IsStatic)
			{
				throw Error.ArgumentMustBeInstanceMember();
			}
			memberType = fieldInfo.FieldType;
			break;
		}
		}
	}

	private static void ValidateGettableFieldOrPropertyMember(MemberInfo member, out Type memberType)
	{
		if (!(member is FieldInfo fieldInfo))
		{
			if (!(member is PropertyInfo propertyInfo))
			{
				throw Error.ArgumentMustBeFieldInfoOrPropertInfo();
			}
			if (!propertyInfo.CanRead)
			{
				throw Error.PropertyDoesNotHaveGetter(propertyInfo);
			}
			memberType = propertyInfo.PropertyType;
		}
		else
		{
			memberType = fieldInfo.FieldType;
		}
	}

	private static void ValidateMemberInitArgs(Type type, ReadOnlyCollection<MemberBinding> bindings)
	{
		int num = 0;
		int count = bindings.Count;
		MemberBinding memberBinding;
		while (true)
		{
			if (num < count)
			{
				memberBinding = bindings[num];
				if (!AreReferenceAssignable(memberBinding.Member.DeclaringType, type))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		throw Error.NotAMemberOfType(memberBinding.Member.Name, type);
	}

	public static UnaryExpression Not(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if (IsIntegerOrBool(expression.Type))
		{
			return new UnaryExpression(ExpressionType.Not, expression, expression.Type);
		}
		UnaryExpression userDefinedUnaryOperator = GetUserDefinedUnaryOperator(ExpressionType.Not, "op_LogicalNot", expression);
		if (userDefinedUnaryOperator != null)
		{
			return userDefinedUnaryOperator;
		}
		return GetUserDefinedUnaryOperatorOrThrow(ExpressionType.Not, "op_OnesComplement", expression);
	}

	public static UnaryExpression Not(Expression expression, MethodInfo method)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)method == null)
		{
			return Not(expression);
		}
		return GetMethodBasedUnaryOperator(ExpressionType.Not, expression, method);
	}

	public static BinaryExpression Or(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsIntegerOrBool(left.Type))
		{
			return new BinaryExpression(ExpressionType.Or, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Or, "op_BitwiseOr", left, right, liftToNull: true);
	}

	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return Or(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Or, left, right, method, liftToNull: true);
	}

	public static BinaryExpression OrElse(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsBool(left.Type))
		{
			return new BinaryExpression(ExpressionType.OrElse, left, right, left.Type);
		}
		MethodInfo userDefinedBinaryOperator = GetUserDefinedBinaryOperator(ExpressionType.OrElse, left.Type, right.Type, "op_BitwiseOr");
		if ((object)userDefinedBinaryOperator != null)
		{
			ValidateUserDefinedConditionalLogicOperator(ExpressionType.OrElse, left.Type, right.Type, userDefinedBinaryOperator);
			Type type = ((!IsNullableType(left.Type) || (object)userDefinedBinaryOperator.ReturnType != GetNonNullableType(left.Type)) ? userDefinedBinaryOperator.ReturnType : left.Type);
			return new BinaryExpression(ExpressionType.OrElse, left, right, userDefinedBinaryOperator, type);
		}
		throw Error.BinaryOperatorNotDefined(ExpressionType.OrElse, left.Type, right.Type);
	}

	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return OrElse(left, right);
		}
		ValidateUserDefinedConditionalLogicOperator(ExpressionType.OrElse, left.Type, right.Type, method);
		Type type = ((!IsNullableType(left.Type) || (object)method.ReturnType != GetNonNullableType(left.Type)) ? method.ReturnType : left.Type);
		return new BinaryExpression(ExpressionType.OrElse, left, right, method, type);
	}

	public static ParameterExpression Parameter(Type type, string name)
	{
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		return new ParameterExpression(type, name);
	}

	public static BinaryExpression Power(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		Type typeFromHandle = typeof(Math);
		MethodInfo method = typeFromHandle.GetMethod("Pow", BindingFlags.Static | BindingFlags.Public);
		if ((object)method == null)
		{
			throw Error.BinaryOperatorNotDefined(ExpressionType.Power, left.Type, right.Type);
		}
		return Power(left, right, method);
	}

	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return Power(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Power, left, right, method, liftToNull: true);
	}

	public static MemberExpression Property(Expression expression, PropertyInfo property)
	{
		if ((object)property == null)
		{
			throw Error.ArgumentNull("property");
		}
		if (!property.CanRead)
		{
			throw Error.PropertyDoesNotHaveGetter(property);
		}
		if (!property.GetGetMethod(nonPublic: true)!.IsStatic)
		{
			if (expression == null)
			{
				throw Error.ArgumentNull("expression");
			}
			if (!AreReferenceAssignable(property.DeclaringType, expression.Type))
			{
				throw Error.PropertyNotDefinedForType(property, expression.Type);
			}
		}
		return new MemberExpression(expression, property, property.PropertyType);
	}

	public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor)
	{
		if ((object)propertyAccessor == null)
		{
			throw Error.ArgumentNull("propertyAccessor");
		}
		ValidateMethodInfo(propertyAccessor);
		return Property(expression, GetProperty(propertyAccessor));
	}

	public static MemberExpression Property(Expression expression, string propertyName)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		PropertyInfo property = expression.Type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if ((object)property == null)
		{
			property = expression.Type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		}
		if ((object)property == null)
		{
			throw Error.PropertyNotDefinedForType(propertyName, expression.Type);
		}
		return Property(expression, property);
	}

	public static MemberExpression PropertyOrField(Expression expression, string propertyOrFieldName)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		PropertyInfo property = expression.Type.GetProperty(propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if ((object)property != null)
		{
			return Property(expression, property);
		}
		FieldInfo field = expression.Type.GetField(propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
		if ((object)field != null)
		{
			return Field(expression, field);
		}
		property = expression.Type.GetProperty(propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		if ((object)property != null)
		{
			return Property(expression, property);
		}
		field = expression.Type.GetField(propertyOrFieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
		if ((object)field == null)
		{
			throw Error.NotAMemberOfType(propertyOrFieldName, expression.Type);
		}
		return Field(expression, field);
	}

	public static UnaryExpression Quote(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		return new UnaryExpression(ExpressionType.Quote, expression, expression.GetType());
	}

	public static BinaryExpression RightShift(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if (IsInteger(left.Type) && (object)GetNonNullableType(right.Type) == typeof(int))
		{
			return new BinaryExpression(ExpressionType.RightShift, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.RightShift, "op_RightShift", left, right, liftToNull: true);
	}

	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return RightShift(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.RightShift, left, right, method, liftToNull: true);
	}

	public static BinaryExpression Subtract(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsArithmetic(left.Type))
		{
			return new BinaryExpression(ExpressionType.Subtract, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.Subtract, "op_Subtraction", left, right, liftToNull: true);
	}

	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return Subtract(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.Subtract, left, right, method, liftToNull: true);
	}

	public static BinaryExpression SubtractChecked(Expression left, Expression right)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)left.Type == right.Type && IsArithmetic(left.Type))
		{
			return new BinaryExpression(ExpressionType.SubtractChecked, left, right, left.Type);
		}
		return GetUserDefinedBinaryOperatorOrThrow(ExpressionType.SubtractChecked, "op_Subtraction", left, right, liftToNull: true);
	}

	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method)
	{
		if (left == null)
		{
			throw Error.ArgumentNull("left");
		}
		if (right == null)
		{
			throw Error.ArgumentNull("right");
		}
		if ((object)method == null)
		{
			return SubtractChecked(left, right);
		}
		return GetMethodBasedBinaryOperator(ExpressionType.SubtractChecked, left, right, method, liftToNull: true);
	}

	public static UnaryExpression TypeAs(Expression expression, Type type)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (type.IsValueType && !IsNullableType(type))
		{
			throw Error.IncorrectTypeForTypeAs(type);
		}
		return new UnaryExpression(ExpressionType.TypeAs, expression, type);
	}

	public static TypeBinaryExpression TypeIs(Expression expression, Type type)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		return new TypeBinaryExpression(ExpressionType.TypeIs, expression, type, typeof(bool));
	}

	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type)
	{
		return MakeUnary(unaryType, operand, type, null);
	}

	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method)
	{
		return unaryType switch
		{
			ExpressionType.Negate => Negate(operand, method), 
			ExpressionType.NegateChecked => NegateChecked(operand, method), 
			ExpressionType.Convert => Convert(operand, type, method), 
			ExpressionType.ConvertChecked => ConvertChecked(operand, type, method), 
			ExpressionType.ArrayLength => ArrayLength(operand), 
			ExpressionType.TypeAs => TypeAs(operand, type), 
			ExpressionType.Quote => Quote(operand), 
			ExpressionType.Not => Not(operand, method), 
			_ => throw Error.UnhandledUnary(unaryType), 
		};
	}

	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right)
	{
		return MakeBinary(binaryType, left, right, liftToNull: false, null);
	}

	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method)
	{
		return MakeBinary(binaryType, left, right, liftToNull, method, null);
	}

	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion)
	{
		return binaryType switch
		{
			ExpressionType.Add => Add(left, right, method), 
			ExpressionType.AddChecked => AddChecked(left, right, method), 
			ExpressionType.And => And(left, right, method), 
			ExpressionType.AndAlso => AndAlso(left, right), 
			ExpressionType.ArrayIndex => ArrayIndex(left, right), 
			ExpressionType.Coalesce => Coalesce(left, right, conversion), 
			ExpressionType.Divide => Divide(left, right, method), 
			ExpressionType.Equal => Equal(left, right, liftToNull, method), 
			ExpressionType.ExclusiveOr => ExclusiveOr(left, right, method), 
			ExpressionType.GreaterThan => GreaterThan(left, right, liftToNull, method), 
			ExpressionType.GreaterThanOrEqual => GreaterThanOrEqual(left, right, liftToNull, method), 
			ExpressionType.LeftShift => LeftShift(left, right, method), 
			ExpressionType.LessThan => LessThan(left, right, liftToNull, method), 
			ExpressionType.LessThanOrEqual => LessThanOrEqual(left, right, liftToNull, method), 
			ExpressionType.Modulo => Modulo(left, right, method), 
			ExpressionType.Multiply => Multiply(left, right, method), 
			ExpressionType.MultiplyChecked => MultiplyChecked(left, right, method), 
			ExpressionType.NotEqual => NotEqual(left, right, liftToNull, method), 
			ExpressionType.Or => Or(left, right, method), 
			ExpressionType.OrElse => OrElse(left, right), 
			ExpressionType.Power => Power(left, right, method), 
			ExpressionType.RightShift => RightShift(left, right, method), 
			ExpressionType.Subtract => Subtract(left, right, method), 
			ExpressionType.SubtractChecked => SubtractChecked(left, right, method), 
			_ => throw Error.UnhandledBinary(binaryType), 
		};
	}

	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member)
	{
		if ((object)member == null)
		{
			throw Error.ArgumentNull("member");
		}
		if (member is FieldInfo field)
		{
			return Field(expression, field);
		}
		if (!(member is PropertyInfo property))
		{
			throw Error.MemberNotFieldOrProperty(member);
		}
		return Property(expression, property);
	}

	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
	{
		if ((object)left.Type == right.Type && (IsNumeric(left.Type) || (object)left.Type == typeof(object)))
		{
			if (IsNullableType(left.Type) && liftToNull)
			{
				return new BinaryExpression(binaryType, left, right, typeof(bool?));
			}
			return new BinaryExpression(binaryType, left, right, typeof(bool));
		}
		BinaryExpression userDefinedBinaryOperator = GetUserDefinedBinaryOperator(binaryType, opName, left, right, liftToNull);
		if (userDefinedBinaryOperator != null)
		{
			return userDefinedBinaryOperator;
		}
		if (!HasBuiltInEqualityOperator(left.Type, right.Type) && !IsNullComparison(left, right))
		{
			throw Error.BinaryOperatorNotDefined(binaryType, left.Type, right.Type);
		}
		if (IsNullableType(left.Type) && liftToNull)
		{
			return new BinaryExpression(binaryType, left, right, typeof(bool?));
		}
		return new BinaryExpression(binaryType, left, right, typeof(bool));
	}

	private static bool IsNullComparison(Expression left, Expression right)
	{
		if (IsNullConstant(left) && !IsNullConstant(right) && IsNullableType(right.Type))
		{
			return true;
		}
		if (IsNullConstant(right) && !IsNullConstant(left))
		{
			return IsNullableType(left.Type);
		}
		return false;
	}

	private static bool HasBuiltInEqualityOperator(Type left, Type right)
	{
		if (left.IsInterface && !right.IsValueType)
		{
			return true;
		}
		if (right.IsInterface && !left.IsValueType)
		{
			return true;
		}
		if (!left.IsValueType && !right.IsValueType && (AreReferenceAssignable(left, right) || AreReferenceAssignable(right, left)))
		{
			return true;
		}
		if ((object)left != right)
		{
			return false;
		}
		Type nonNullableType = GetNonNullableType(left);
		if ((object)nonNullableType != typeof(bool) && !IsNumeric(nonNullableType) && !nonNullableType.IsEnum)
		{
			return false;
		}
		return true;
	}

	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull)
	{
		if ((object)left.Type == right.Type && IsNumeric(left.Type))
		{
			if (IsNullableType(left.Type) && liftToNull)
			{
				return new BinaryExpression(binaryType, left, right, typeof(bool?));
			}
			return new BinaryExpression(binaryType, left, right, typeof(bool));
		}
		return GetUserDefinedBinaryOperatorOrThrow(binaryType, opName, left, right, liftToNull);
	}

	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType)
	{
		UnaryExpression userDefinedCoercion = GetUserDefinedCoercion(coercionType, expression, convertToType);
		if (userDefinedCoercion == null)
		{
			throw Error.CoercionOperatorNotDefined(expression.Type, convertToType);
		}
		return userDefinedCoercion;
	}

	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType)
	{
		Type nonNullableType = GetNonNullableType(expression.Type);
		Type nonNullableType2 = GetNonNullableType(convertToType);
		MethodInfo[] methods = nonNullableType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo methodInfo = FindConversionOperator(methods, expression.Type, convertToType);
		if ((object)methodInfo != null)
		{
			return new UnaryExpression(coercionType, expression, methodInfo, convertToType);
		}
		MethodInfo[] methods2 = nonNullableType2.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		methodInfo = FindConversionOperator(methods2, expression.Type, convertToType);
		if ((object)methodInfo != null)
		{
			return new UnaryExpression(coercionType, expression, methodInfo, convertToType);
		}
		if ((object)nonNullableType != expression.Type || (object)nonNullableType2 != convertToType)
		{
			methodInfo = FindConversionOperator(methods, nonNullableType, nonNullableType2);
			if ((object)methodInfo == null)
			{
				methodInfo = FindConversionOperator(methods2, nonNullableType, nonNullableType2);
			}
			if ((object)methodInfo != null)
			{
				return new UnaryExpression(coercionType, expression, methodInfo, convertToType);
			}
		}
		return null;
	}

	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo)
	{
		int num = 0;
		MethodInfo methodInfo;
		while (true)
		{
			if (num < methods.Length)
			{
				methodInfo = methods[num];
				if ((!(methodInfo.Name != "op_Implicit") || !(methodInfo.Name != "op_Explicit")) && (object)methodInfo.ReturnType == typeTo)
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if ((object)parameters[0].ParameterType == typeFrom)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return methodInfo;
	}

	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand)
	{
		UnaryExpression userDefinedUnaryOperator = GetUserDefinedUnaryOperator(unaryType, name, operand);
		if (userDefinedUnaryOperator == null)
		{
			throw Error.UnaryOperatorNotDefined(unaryType, operand.Type);
		}
		ValidateParamswithOperandsOrThrow(userDefinedUnaryOperator.Method.GetParameters()[0].ParameterType, operand.Type, unaryType, name);
		return userDefinedUnaryOperator;
	}

	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand)
	{
		Type type = operand.Type;
		Type[] array = new Type[1] { type };
		Type nonNullableType = GetNonNullableType(type);
		MethodInfo method = nonNullableType.GetMethod(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, array, null);
		if ((object)method != null)
		{
			return new UnaryExpression(unaryType, operand, method, method.ReturnType);
		}
		if (IsNullableType(type))
		{
			array[0] = nonNullableType;
			method = nonNullableType.GetMethod(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, array, null);
			if ((object)method != null && method.ReturnType.IsValueType && !IsNullableType(method.ReturnType))
			{
				return new UnaryExpression(unaryType, operand, method, GetNullableType(method.ReturnType));
			}
		}
		return null;
	}

	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name)
	{
		if (IsNullableType(paramType) && !IsNullableType(operandType))
		{
			throw Error.OperandTypesDoNotMatchParameters(exprType, name);
		}
	}

	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
	{
		BinaryExpression userDefinedBinaryOperator = GetUserDefinedBinaryOperator(binaryType, name, left, right, liftToNull);
		if (userDefinedBinaryOperator == null)
		{
			throw Error.BinaryOperatorNotDefined(binaryType, left.Type, right.Type);
		}
		ValidateParamswithOperandsOrThrow(userDefinedBinaryOperator.Method.GetParameters()[0].ParameterType, left.Type, binaryType, name);
		ValidateParamswithOperandsOrThrow(userDefinedBinaryOperator.Method.GetParameters()[1].ParameterType, right.Type, binaryType, name);
		return userDefinedBinaryOperator;
	}

	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name)
	{
		Type[] types = new Type[2] { leftType, rightType };
		Type nonNullableType = GetNonNullableType(leftType);
		Type nonNullableType2 = GetNonNullableType(rightType);
		BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		MethodInfo methodInfo = nonNullableType.GetMethod(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		if ((object)methodInfo == null)
		{
			methodInfo = nonNullableType2.GetMethod(name, bindingAttr, null, types, null);
		}
		if (IsLiftingConditionalLogicalOperator(leftType, rightType, methodInfo, binaryType))
		{
			methodInfo = GetUserDefinedBinaryOperator(binaryType, nonNullableType, nonNullableType2, name);
		}
		return methodInfo;
	}

	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType)
	{
		if (IsNullableType(right) && IsNullableType(left) && (object)method == null)
		{
			if (binaryType != ExpressionType.AndAlso)
			{
				return binaryType == ExpressionType.OrElse;
			}
			return true;
		}
		return false;
	}

	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull)
	{
		MethodInfo userDefinedBinaryOperator = GetUserDefinedBinaryOperator(binaryType, left.Type, right.Type, name);
		if ((object)userDefinedBinaryOperator != null)
		{
			return new BinaryExpression(binaryType, left, right, userDefinedBinaryOperator, userDefinedBinaryOperator.ReturnType);
		}
		if (IsNullableType(left.Type) && IsNullableType(right.Type))
		{
			Type nonNullableType = GetNonNullableType(left.Type);
			Type nonNullableType2 = GetNonNullableType(right.Type);
			userDefinedBinaryOperator = GetUserDefinedBinaryOperator(binaryType, nonNullableType, nonNullableType2, name);
			if ((object)userDefinedBinaryOperator != null && userDefinedBinaryOperator.ReturnType.IsValueType && !IsNullableType(userDefinedBinaryOperator.ReturnType))
			{
				if ((object)userDefinedBinaryOperator.ReturnType == typeof(bool) && !liftToNull)
				{
					return new BinaryExpression(binaryType, left, right, userDefinedBinaryOperator, typeof(bool));
				}
				return new BinaryExpression(binaryType, left, right, userDefinedBinaryOperator, GetNullableType(userDefinedBinaryOperator.ReturnType));
			}
		}
		return null;
	}

	private static void ValidateOperator(MethodInfo method)
	{
		ValidateMethodInfo(method);
		if (!method.IsStatic)
		{
			throw Error.UserDefinedOperatorMustBeStatic(method);
		}
		if ((object)method.ReturnType == typeof(void))
		{
			throw Error.UserDefinedOperatorMustNotBeVoid(method);
		}
	}

	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method)
	{
		ValidateOperator(method);
		ParameterInfo[] parameters = method.GetParameters();
		if (parameters.Length != 2)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
		if (!ParameterIsAssignable(parameters[0], left) && (!IsNullableType(left) || !ParameterIsAssignable(parameters[0], GetNonNullableType(left))))
		{
			throw Error.OperandTypesDoNotMatchParameters(nodeType, method.Name);
		}
		if (!ParameterIsAssignable(parameters[1], right) && (!IsNullableType(right) || !ParameterIsAssignable(parameters[1], GetNonNullableType(right))))
		{
			throw Error.OperandTypesDoNotMatchParameters(nodeType, method.Name);
		}
		if ((object)parameters[0].ParameterType != parameters[1].ParameterType)
		{
			throw Error.LogicalOperatorMustHaveConsistentTypes(nodeType, method.Name);
		}
		if ((object)method.ReturnType != parameters[0].ParameterType)
		{
			throw Error.LogicalOperatorMustHaveConsistentTypes(nodeType, method.Name);
		}
		if (IsValidLiftedConditionalLogicalOperator(left, right, parameters))
		{
			left = GetNonNullableType(left);
			right = GetNonNullableType(left);
		}
		Type[] types = new Type[1] { parameters[0].ParameterType };
		MethodInfo method2 = left.GetMethod("op_True", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		MethodInfo method3 = left.GetMethod("op_False", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		if ((object)method2 != null && (object)method3 != null)
		{
			if ((object)method2.ReturnType != typeof(bool))
			{
				throw Error.LogicalOperatorMustHaveBooleanOperators(nodeType, method.Name);
			}
			if ((object)method3.ReturnType != typeof(bool))
			{
				throw Error.LogicalOperatorMustHaveBooleanOperators(nodeType, method.Name);
			}
			return;
		}
		throw Error.LogicalOperatorMustHaveBooleanOperators(nodeType, method.Name);
	}

	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms)
	{
		if ((object)left == right && IsNullableType(right))
		{
			return (object)pms[1].ParameterType == GetNonNullableType(right);
		}
		return false;
	}

	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method)
	{
		ValidateOperator(method);
		ParameterInfo[] parameters = method.GetParameters();
		if (parameters.Length != 1)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
		if (ParameterIsAssignable(parameters[0], operand.Type) && (object)method.ReturnType == convertToType)
		{
			return new UnaryExpression(unaryType, operand, method, method.ReturnType);
		}
		if ((!IsNullableType(operand.Type) && !IsNullableType(convertToType)) || !ParameterIsAssignable(parameters[0], GetNonNullableType(operand.Type)) || (object)method.ReturnType != GetNonNullableType(convertToType))
		{
			throw Error.OperandTypesDoNotMatchParameters(unaryType, method.Name);
		}
		return new UnaryExpression(unaryType, operand, method, convertToType);
	}

	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method)
	{
		ValidateOperator(method);
		ParameterInfo[] parameters = method.GetParameters();
		if (parameters.Length != 1)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
		if (ParameterIsAssignable(parameters[0], operand.Type))
		{
			ValidateParamswithOperandsOrThrow(parameters[0].ParameterType, operand.Type, unaryType, method.Name);
			return new UnaryExpression(unaryType, operand, method, method.ReturnType);
		}
		if (!IsNullableType(operand.Type) || !ParameterIsAssignable(parameters[0], GetNonNullableType(operand.Type)) || !method.ReturnType.IsValueType || IsNullableType(method.ReturnType))
		{
			throw Error.OperandTypesDoNotMatchParameters(unaryType, method.Name);
		}
		return new UnaryExpression(unaryType, operand, method, GetNullableType(method.ReturnType));
	}

	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull)
	{
		ValidateOperator(method);
		ParameterInfo[] parameters = method.GetParameters();
		if (parameters.Length != 2)
		{
			throw Error.IncorrectNumberOfMethodCallArguments(method);
		}
		if (ParameterIsAssignable(parameters[0], left.Type) && ParameterIsAssignable(parameters[1], right.Type))
		{
			ValidateParamswithOperandsOrThrow(parameters[0].ParameterType, left.Type, binaryType, method.Name);
			ValidateParamswithOperandsOrThrow(parameters[1].ParameterType, right.Type, binaryType, method.Name);
			return new BinaryExpression(binaryType, left, right, method, method.ReturnType);
		}
		if (IsNullableType(left.Type) && IsNullableType(right.Type) && ParameterIsAssignable(parameters[0], GetNonNullableType(left.Type)) && ParameterIsAssignable(parameters[1], GetNonNullableType(right.Type)) && method.ReturnType.IsValueType && !IsNullableType(method.ReturnType))
		{
			if ((object)method.ReturnType == typeof(bool) && !liftToNull)
			{
				return new BinaryExpression(binaryType, left, right, method, typeof(bool));
			}
			return new BinaryExpression(binaryType, left, right, method, GetNullableType(method.ReturnType));
		}
		throw Error.OperandTypesDoNotMatchParameters(binaryType, method.Name);
	}

	private static bool ParameterIsAssignable(ParameterInfo pi, Type argType)
	{
		Type type = pi.ParameterType;
		if (type.IsByRef)
		{
			type = type.GetElementType();
		}
		return AreReferenceAssignable(type, argType);
	}

	private static void ValidateIntegerArg(Type type)
	{
		if (!IsInteger(type))
		{
			throw Error.ArgumentMustBeInteger();
		}
	}

	private static void ValidateIntegerOrBoolArg(Type type)
	{
		if (!IsIntegerOrBool(type))
		{
			throw Error.ArgumentMustBeIntegerOrBoolean();
		}
	}

	private static void ValidateNumericArg(Type type)
	{
		if (!IsNumeric(type))
		{
			throw Error.ArgumentMustBeNumeric();
		}
	}

	private static void ValidateConvertibleArg(Type type)
	{
		if (!IsConvertible(type))
		{
			throw Error.ArgumentMustBeConvertible();
		}
	}

	private static void ValidateBoolArg(Type type)
	{
		if (!IsBool(type))
		{
			throw Error.ArgumentMustBeBoolean();
		}
	}

	private static Type ValidateCoalesceArgTypes(Type left, Type right)
	{
		Type nonNullableType = GetNonNullableType(left);
		if (left.IsValueType && !IsNullableType(left))
		{
			throw Error.CoalesceUsedOnNonNullType();
		}
		if (IsNullableType(left) && IsImplicitlyConvertible(right, nonNullableType))
		{
			return nonNullableType;
		}
		if (IsImplicitlyConvertible(right, left))
		{
			return left;
		}
		if (!IsImplicitlyConvertible(nonNullableType, right))
		{
			throw Error.ArgumentTypesMustMatch();
		}
		return right;
	}

	private static void ValidateSameArgTypes(Type left, Type right)
	{
		if ((object)left != right)
		{
			throw Error.ArgumentTypesMustMatch();
		}
	}

	private static void ValidateElementInitAddMethodInfo(MethodInfo addMethod)
	{
		ValidateMethodInfo(addMethod);
		if (addMethod.GetParameters().Length == 0)
		{
			throw Error.ElementInitializerMethodWithZeroArgs();
		}
		if (!addMethod.Name.Equals("Add", StringComparison.OrdinalIgnoreCase))
		{
			throw Error.ElementInitializerMethodNotAdd();
		}
		if (addMethod.IsStatic)
		{
			throw Error.ElementInitializerMethodStatic();
		}
		ParameterInfo[] parameters = addMethod.GetParameters();
		int num = 0;
		ParameterInfo parameterInfo;
		while (true)
		{
			if (num < parameters.Length)
			{
				parameterInfo = parameters[num];
				if (parameterInfo.ParameterType.IsByRef)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		throw Error.ElementInitializerMethodNoRefOutParam(parameterInfo.Name, addMethod.Name);
	}

	private static void ValidateMethodInfo(MethodInfo method)
	{
		if (method.IsGenericMethodDefinition)
		{
			throw Error.MethodIsGeneric(method);
		}
		if (method.ContainsGenericParameters)
		{
			throw Error.MethodContainsGenericParameters(method);
		}
	}

	private static void ValidateType(Type type)
	{
		if (type.IsGenericTypeDefinition)
		{
			throw Error.TypeIsGeneric(type);
		}
		if (type.ContainsGenericParameters)
		{
			throw Error.TypeContainsGenericParameters(type);
		}
	}

	internal static Type GetNullableType(Type type)
	{
		if ((object)type == null)
		{
			throw Error.ArgumentNull("type");
		}
		if (type.IsValueType && !IsNullableType(type))
		{
			return typeof(Nullable<>).MakeGenericType(type);
		}
		return type;
	}

	private static bool IsSameOrSubclass(Type type, Type subType)
	{
		if ((object)type != subType)
		{
			return subType.IsSubclassOf(type);
		}
		return true;
	}

	private static bool AreReferenceAssignable(Type dest, Type src)
	{
		if ((object)dest == src)
		{
			return true;
		}
		if (!dest.IsValueType && !src.IsValueType && AreAssignable(dest, src))
		{
			return true;
		}
		return false;
	}

	private static bool AreAssignable(Type dest, Type src)
	{
		if ((object)dest == src)
		{
			return true;
		}
		if (dest.IsAssignableFrom(src))
		{
			return true;
		}
		if (dest.IsArray && src.IsArray && dest.GetArrayRank() == src.GetArrayRank() && AreAssignable(dest.GetElementType(), src.GetElementType()))
		{
			return true;
		}
		if (src.IsArray && dest.IsGenericType && ((object)dest.GetGenericTypeDefinition() == typeof(IEnumerable<>) || (object)dest.GetGenericTypeDefinition() == typeof(IList<>) || (object)dest.GetGenericTypeDefinition() == typeof(ICollection<>)) && (object)dest.GetGenericArguments()[0] == src.GetElementType())
		{
			return true;
		}
		return false;
	}

	internal static bool IsNullableType(Type type)
	{
		if (type.IsGenericType)
		{
			return (object)type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}
		return false;
	}

	internal static Type GetNonNullableType(Type type)
	{
		if (IsNullableType(type))
		{
			type = type.GetGenericArguments()[0];
		}
		return type;
	}

	private static bool IsNullConstant(Expression expr)
	{
		if (!(expr is ConstantExpression constantExpression))
		{
			return false;
		}
		return constantExpression.Value == null;
	}

	private static bool IsUnSigned(Type type)
	{
		type = GetNonNullableType(type);
		if (type.IsEnum)
		{
			return false;
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			return false;
		case TypeCode.UInt16:
		case TypeCode.UInt32:
		case TypeCode.UInt64:
			return true;
		}
	}

	private static bool IsArithmetic(Type type)
	{
		type = GetNonNullableType(type);
		if (type.IsEnum)
		{
			return false;
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			return false;
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
		case TypeCode.Single:
		case TypeCode.Double:
			return true;
		}
	}

	private static bool IsNumeric(Type type)
	{
		type = GetNonNullableType(type);
		if (type.IsEnum)
		{
			return false;
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			return false;
		case TypeCode.Char:
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
		case TypeCode.Single:
		case TypeCode.Double:
			return true;
		}
	}

	private static bool IsImplicitlyConvertible(Type source, Type destination)
	{
		if (!IsIdentityConversion(source, destination) && !IsImplicitNumericConversion(source, destination) && !IsImplicitReferenceConversion(source, destination) && !IsImplicitBoxingConversion(source, destination))
		{
			return IsImplicitNullableConversion(source, destination);
		}
		return true;
	}

	private static bool IsIdentityConversion(Type source, Type destination)
	{
		return (object)source == destination;
	}

	private static bool IsImplicitNumericConversion(Type source, Type destination)
	{
		TypeCode typeCode = Type.GetTypeCode(source);
		TypeCode typeCode2 = Type.GetTypeCode(destination);
		switch (typeCode)
		{
		default:
			return false;
		case TypeCode.Char:
			switch (typeCode2)
			{
			default:
				return false;
			case TypeCode.UInt16:
			case TypeCode.Int32:
			case TypeCode.UInt32:
			case TypeCode.Int64:
			case TypeCode.UInt64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			}
		case TypeCode.SByte:
			switch (typeCode2)
			{
			default:
				return false;
			case TypeCode.Int16:
			case TypeCode.Int32:
			case TypeCode.Int64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			}
		case TypeCode.Byte:
			switch (typeCode2)
			{
			default:
				return false;
			case TypeCode.Int16:
			case TypeCode.UInt16:
			case TypeCode.Int32:
			case TypeCode.UInt32:
			case TypeCode.Int64:
			case TypeCode.UInt64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			}
		case TypeCode.Int16:
			switch (typeCode2)
			{
			default:
				return false;
			case TypeCode.Int32:
			case TypeCode.Int64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			}
		case TypeCode.UInt16:
			switch (typeCode2)
			{
			default:
				return false;
			case TypeCode.Int32:
			case TypeCode.UInt32:
			case TypeCode.Int64:
			case TypeCode.UInt64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			}
		case TypeCode.Int32:
			switch (typeCode2)
			{
			default:
				return false;
			case TypeCode.Int64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			}
		case TypeCode.UInt32:
			switch (typeCode2)
			{
			default:
				return false;
			case TypeCode.UInt32:
			case TypeCode.UInt64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			}
		case TypeCode.Int64:
		case TypeCode.UInt64:
			switch (typeCode2)
			{
			default:
				return false;
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			}
		case TypeCode.Single:
			return typeCode2 == TypeCode.Double;
		}
	}

	private static bool IsImplicitReferenceConversion(Type source, Type destination)
	{
		return AreAssignable(destination, source);
	}

	private static bool IsImplicitBoxingConversion(Type source, Type destination)
	{
		if (source.IsValueType && ((object)destination == typeof(object) || (object)destination == typeof(ValueType)))
		{
			return true;
		}
		if (source.IsEnum && (object)destination == typeof(Enum))
		{
			return true;
		}
		return false;
	}

	private static bool IsImplicitNullableConversion(Type source, Type destination)
	{
		if (IsNullableType(destination))
		{
			return IsImplicitlyConvertible(GetNonNullableType(source), GetNonNullableType(destination));
		}
		return false;
	}

	private static bool IsConvertible(Type type)
	{
		type = GetNonNullableType(type);
		if (type.IsEnum)
		{
			return true;
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			return false;
		case TypeCode.Boolean:
		case TypeCode.Char:
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
		case TypeCode.Single:
		case TypeCode.Double:
			return true;
		}
	}

	private static bool IsInteger(Type type)
	{
		type = GetNonNullableType(type);
		if (type.IsEnum)
		{
			return false;
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			return false;
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
			return true;
		}
	}

	private static bool IsIntegerOrBool(Type type)
	{
		type = GetNonNullableType(type);
		if (type.IsEnum)
		{
			return false;
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			return false;
		case TypeCode.Boolean:
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
		case TypeCode.Int64:
		case TypeCode.UInt64:
			return true;
		}
	}

	private static bool IsBool(Type type)
	{
		type = GetNonNullableType(type);
		return (object)type == typeof(bool);
	}
}
public sealed class Expression<TDelegate> : LambdaExpression
{
	internal Expression(Expression body, ReadOnlyCollection<ParameterExpression> parameters)
		: base(body, typeof(TDelegate), parameters)
	{
	}

	public new TDelegate Compile()
	{
		return (TDelegate)(object)base.Compile();
	}
}

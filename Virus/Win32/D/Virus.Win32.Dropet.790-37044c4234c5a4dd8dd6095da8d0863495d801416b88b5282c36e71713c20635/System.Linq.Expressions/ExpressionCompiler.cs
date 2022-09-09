using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions;

internal class ExpressionCompiler
{
	internal class LambdaInfo
	{
		internal LambdaExpression Lambda;

		internal List<LambdaInfo> Lambdas;

		internal MethodInfo Method;

		internal Dictionary<ParameterExpression, int> HoistedLocals;

		internal LambdaInfo(LambdaExpression lambda, MethodInfo method, Dictionary<ParameterExpression, int> hoistedLocals, List<LambdaInfo> lambdas)
		{
			Lambda = lambda;
			Method = method;
			HoistedLocals = hoistedLocals;
			Lambdas = lambdas;
		}
	}

	private class CompileScope
	{
		internal CompileScope Parent;

		internal LambdaExpression Lambda;

		internal Dictionary<ParameterExpression, LocalBuilder> Locals;

		internal Dictionary<ParameterExpression, int> HoistedLocals;

		internal LocalBuilder HoistedLocalsVar;

		internal CompileScope(CompileScope parent, LambdaExpression lambda)
		{
			Parent = parent;
			Lambda = lambda;
			Locals = new Dictionary<ParameterExpression, LocalBuilder>();
			HoistedLocals = new Dictionary<ParameterExpression, int>();
		}
	}

	private enum StackType
	{
		Value,
		Address
	}

	private class Hoister : ExpressionVisitor
	{
		private CompileScope expressionScope;

		private LambdaExpression current;

		private List<ParameterExpression> locals;

		internal Hoister()
		{
		}

		internal void Hoist(CompileScope scope)
		{
			expressionScope = scope;
			current = scope.Lambda;
			locals = new List<ParameterExpression>(scope.Lambda.Parameters);
			Visit(scope.Lambda.Body);
		}

		internal override Expression VisitParameter(ParameterExpression p)
		{
			if (locals.Contains(p) && expressionScope.Lambda != current && !expressionScope.HoistedLocals.ContainsKey(p))
			{
				expressionScope.HoistedLocals.Add(p, expressionScope.HoistedLocals.Count);
			}
			return p;
		}

		internal override Expression VisitInvocation(InvocationExpression iv)
		{
			if (expressionScope.Lambda == current)
			{
				if (iv.Expression.NodeType == ExpressionType.Lambda)
				{
					LambdaExpression lambdaExpression = (LambdaExpression)iv.Expression;
					locals.AddRange(lambdaExpression.Parameters);
				}
				else if (iv.Expression.NodeType == ExpressionType.Quote && iv.Expression.Type.IsSubclassOf(typeof(LambdaExpression)))
				{
					LambdaExpression lambdaExpression2 = (LambdaExpression)((UnaryExpression)iv.Expression).Operand;
					locals.AddRange(lambdaExpression2.Parameters);
				}
			}
			return base.VisitInvocation(iv);
		}

		internal override Expression VisitLambda(LambdaExpression l)
		{
			LambdaExpression lambdaExpression = current;
			current = l;
			Visit(l.Body);
			current = lambdaExpression;
			return l;
		}
	}

	private struct WriteBack
	{
		public LocalBuilder loc;

		public Expression arg;

		public WriteBack(LocalBuilder loc, Expression arg)
		{
			this.loc = loc;
			this.arg = arg;
		}
	}

	private List<LambdaInfo> lambdas;

	private List<object> globals;

	private CompileScope scope;

	internal ExpressionCompiler()
	{
		lambdas = new List<LambdaInfo>();
		globals = new List<object>();
	}

	public D Compile<D>(Expression<D> lambda)
	{
		if (!typeof(Delegate).IsAssignableFrom(typeof(D)))
		{
			throw Error.TypeParameterIsNotDelegate(typeof(D));
		}
		return (D)(object)Compile((LambdaExpression)lambda);
	}

	public Delegate Compile(LambdaExpression lambda)
	{
		return CompileDynamicLambda(lambda);
	}

	private Delegate CompileDynamicLambda(LambdaExpression lambda)
	{
		lambdas = new List<LambdaInfo>();
		globals = new List<object>();
		int index = GenerateLambda(lambda);
		LambdaInfo lambdaInfo = lambdas[index];
		ExecutionScope target = new ExecutionScope(null, lambdaInfo, globals.ToArray(), null);
		return ((DynamicMethod)lambdaInfo.Method).CreateDelegate(lambda.Type, target);
	}

	private static void GenerateLoadExecutionScope(ILGenerator gen)
	{
		gen.Emit(OpCodes.Ldarg_0);
	}

	private void GenerateLoadHoistedLocals(ILGenerator gen)
	{
		gen.Emit(OpCodes.Ldloc, scope.HoistedLocalsVar);
	}

	private int GenerateLambda(LambdaExpression lambda)
	{
		scope = new CompileScope(scope, lambda);
		MethodInfo method = lambda.Type.GetMethod("Invoke");
		new Hoister().Hoist(scope);
		DynamicMethod dynamicMethod = new DynamicMethod("lambda_method", method.ReturnType, GetParameterTypes(method), restrictedSkipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		MethodInfo method2 = dynamicMethod;
		GenerateInitHoistedLocals(iLGenerator);
		Generate(iLGenerator, lambda.Body, StackType.Value);
		if ((object)method.ReturnType == typeof(void) && (object)lambda.Body.Type != typeof(void))
		{
			iLGenerator.Emit(OpCodes.Pop);
		}
		iLGenerator.Emit(OpCodes.Ret);
		int count = lambdas.Count;
		lambdas.Add(new LambdaInfo(lambda, method2, scope.HoistedLocals, lambdas));
		scope = scope.Parent;
		return count;
	}

	private void GenerateInitHoistedLocals(ILGenerator gen)
	{
		if (scope.HoistedLocals.Count == 0)
		{
			return;
		}
		scope.HoistedLocalsVar = gen.DeclareLocal(typeof(object[]));
		GenerateLoadExecutionScope(gen);
		gen.Emit(OpCodes.Callvirt, typeof(ExecutionScope).GetMethod("CreateHoistedLocals", BindingFlags.Instance | BindingFlags.Public));
		gen.Emit(OpCodes.Stloc, scope.HoistedLocalsVar);
		int count = scope.Lambda.Parameters.Count;
		for (int i = 0; i < count; i++)
		{
			ParameterExpression p = scope.Lambda.Parameters[i];
			if (IsHoisted(p))
			{
				PrepareInitLocal(gen, p);
				GenerateArgAccess(gen, i + 1, StackType.Value);
				GenerateInitLocal(gen, p);
			}
		}
	}

	private bool IsHoisted(ParameterExpression p)
	{
		return scope.HoistedLocals.ContainsKey(p);
	}

	private void PrepareInitLocal(ILGenerator gen, ParameterExpression p)
	{
		if (scope.HoistedLocals.TryGetValue(p, out var value))
		{
			GenerateLoadHoistedLocals(gen);
			GenerateConstInt(gen, value);
		}
		else
		{
			LocalBuilder value2 = gen.DeclareLocal(p.Type);
			scope.Locals.Add(p, value2);
		}
	}

	private static Type MakeStrongBoxType(Type type)
	{
		return typeof(StrongBox<>).MakeGenericType(type);
	}

	private void GenerateInitLocal(ILGenerator gen, ParameterExpression p)
	{
		if (scope.HoistedLocals.TryGetValue(p, out var _))
		{
			Type type = MakeStrongBoxType(p.Type);
			ConstructorInfo constructor = type.GetConstructor(new Type[1] { p.Type });
			gen.Emit(OpCodes.Newobj, constructor);
			gen.Emit(OpCodes.Stelem_Ref);
		}
		else
		{
			if (!scope.Locals.TryGetValue(p, out var value2))
			{
				throw Error.NotSupported();
			}
			gen.Emit(OpCodes.Stloc, value2);
		}
	}

	private Type[] GetParameterTypes(MethodInfo mi)
	{
		ParameterInfo[] parameters = mi.GetParameters();
		Type[] array = new Type[parameters.Length + 1];
		int i = 0;
		for (int num = parameters.Length; i < num; i++)
		{
			array[i + 1] = parameters[i].ParameterType;
		}
		array[0] = typeof(ExecutionScope);
		return array;
	}

	private StackType Generate(ILGenerator gen, Expression node, StackType ask)
	{
		switch (node.NodeType)
		{
		default:
			throw Error.UnhandledExpressionType(node.NodeType);
		case ExpressionType.Call:
			return GenerateMethodCall(gen, (MethodCallExpression)node, ask);
		case ExpressionType.Conditional:
			return GenerateConditional(gen, (ConditionalExpression)node);
		case ExpressionType.Constant:
			return GenerateConstant(gen, (ConstantExpression)node, ask);
		case ExpressionType.Convert:
		case ExpressionType.ConvertChecked:
			GenerateConvert(gen, (UnaryExpression)node);
			return StackType.Value;
		case ExpressionType.Invoke:
			return GenerateInvoke(gen, (InvocationExpression)node, ask);
		case ExpressionType.Lambda:
			GenerateCreateDelegate(gen, (LambdaExpression)node);
			return StackType.Value;
		case ExpressionType.ListInit:
			return GenerateListInit(gen, (ListInitExpression)node);
		case ExpressionType.MemberAccess:
			return GenerateMemberAccess(gen, (MemberExpression)node, ask);
		case ExpressionType.MemberInit:
			return GenerateMemberInit(gen, (MemberInitExpression)node);
		case ExpressionType.New:
			return GenerateNew(gen, (NewExpression)node, ask);
		case ExpressionType.NewArrayInit:
		case ExpressionType.NewArrayBounds:
			GenerateNewArray(gen, (NewArrayExpression)node);
			return StackType.Value;
		case ExpressionType.Parameter:
			return GenerateParameterAccess(gen, (ParameterExpression)node, ask);
		case ExpressionType.Quote:
			GenerateQuote(gen, (UnaryExpression)node);
			return StackType.Value;
		case ExpressionType.Add:
		case ExpressionType.AddChecked:
		case ExpressionType.And:
		case ExpressionType.AndAlso:
		case ExpressionType.ArrayIndex:
		case ExpressionType.Coalesce:
		case ExpressionType.Divide:
		case ExpressionType.Equal:
		case ExpressionType.ExclusiveOr:
		case ExpressionType.GreaterThan:
		case ExpressionType.GreaterThanOrEqual:
		case ExpressionType.LeftShift:
		case ExpressionType.LessThan:
		case ExpressionType.LessThanOrEqual:
		case ExpressionType.Modulo:
		case ExpressionType.Multiply:
		case ExpressionType.MultiplyChecked:
		case ExpressionType.NotEqual:
		case ExpressionType.Or:
		case ExpressionType.OrElse:
		case ExpressionType.Power:
		case ExpressionType.RightShift:
		case ExpressionType.Subtract:
		case ExpressionType.SubtractChecked:
			return GenerateBinary(gen, (BinaryExpression)node, ask);
		case ExpressionType.ArrayLength:
		case ExpressionType.Negate:
		case ExpressionType.UnaryPlus:
		case ExpressionType.NegateChecked:
		case ExpressionType.Not:
		case ExpressionType.TypeAs:
			return GenerateUnary(gen, (UnaryExpression)node, ask);
		case ExpressionType.TypeIs:
			GenerateTypeIs(gen, (TypeBinaryExpression)node);
			return StackType.Value;
		}
	}

	private StackType GenerateNew(ILGenerator gen, NewExpression nex, StackType ask)
	{
		LocalBuilder local = null;
		if (nex.Type.IsValueType)
		{
			local = gen.DeclareLocal(nex.Type);
		}
		if ((object)nex.Constructor != null)
		{
			ParameterInfo[] parameters = nex.Constructor.GetParameters();
			GenerateArgs(gen, parameters, nex.Arguments);
			gen.Emit(OpCodes.Newobj, nex.Constructor);
			if (nex.Type.IsValueType)
			{
				gen.Emit(OpCodes.Stloc, local);
			}
		}
		else if (nex.Type.IsValueType)
		{
			gen.Emit(OpCodes.Ldloca, local);
			gen.Emit(OpCodes.Initobj, nex.Type);
		}
		else
		{
			ConstructorInfo constructor = nex.Type.GetConstructor(Type.EmptyTypes);
			gen.Emit(OpCodes.Newobj, constructor);
		}
		if (nex.Type.IsValueType)
		{
			return ReturnFromLocal(gen, ask, local);
		}
		return StackType.Value;
	}

	private StackType GenerateInvoke(ILGenerator gen, InvocationExpression invoke, StackType ask)
	{
		LambdaExpression lambdaExpression = ((invoke.Expression.NodeType == ExpressionType.Quote) ? ((LambdaExpression)((UnaryExpression)invoke.Expression).Operand) : (invoke.Expression as LambdaExpression));
		if (lambdaExpression != null)
		{
			int i = 0;
			for (int count = invoke.Arguments.Count; i < count; i++)
			{
				ParameterExpression p = lambdaExpression.Parameters[i];
				PrepareInitLocal(gen, p);
				Generate(gen, invoke.Arguments[i], StackType.Value);
				GenerateInitLocal(gen, p);
			}
			return Generate(gen, lambdaExpression.Body, ask);
		}
		Expression expression = invoke.Expression;
		if (typeof(LambdaExpression).IsAssignableFrom(expression.Type))
		{
			expression = Expression.Call(expression, expression.Type.GetMethod("Compile", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
		}
		expression = Expression.Call(expression, expression.Type.GetMethod("Invoke"), invoke.Arguments);
		return Generate(gen, expression, ask);
	}

	private void GenerateQuote(ILGenerator gen, UnaryExpression quote)
	{
		GenerateLoadExecutionScope(gen);
		int iGlobal = AddGlobal(typeof(Expression), quote.Operand);
		GenerateGlobalAccess(gen, iGlobal, typeof(Expression), StackType.Value);
		if (scope.HoistedLocalsVar != null)
		{
			GenerateLoadHoistedLocals(gen);
		}
		else
		{
			gen.Emit(OpCodes.Ldnull);
		}
		MethodInfo method = typeof(ExecutionScope).GetMethod("IsolateExpression", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		gen.Emit(OpCodes.Callvirt, method);
		Type type = quote.Operand.GetType();
		if ((object)type != typeof(Expression))
		{
			gen.Emit(OpCodes.Castclass, type);
		}
	}

	private void GenerateBinding(ILGenerator gen, MemberBinding binding)
	{
		switch (binding.BindingType)
		{
		default:
			throw Error.UnknownBindingType();
		case MemberBindingType.Assignment:
			GenerateMemberAssignment(gen, (MemberAssignment)binding);
			break;
		case MemberBindingType.MemberBinding:
			GenerateMemberMemberBinding(gen, (MemberMemberBinding)binding);
			break;
		case MemberBindingType.ListBinding:
			GenerateMemberListBinding(gen, (MemberListBinding)binding);
			break;
		}
	}

	private void GenerateMemberAssignment(ILGenerator gen, MemberAssignment binding)
	{
		Generate(gen, binding.Expression, StackType.Value);
		if (binding.Member is FieldInfo field)
		{
			gen.Emit(OpCodes.Stfld, field);
			return;
		}
		PropertyInfo propertyInfo = binding.Member as PropertyInfo;
		MethodInfo setMethod = propertyInfo.GetSetMethod(nonPublic: true);
		if ((object)propertyInfo == null)
		{
			throw Error.UnhandledBinding();
		}
		gen.Emit(UseVirtual(setMethod) ? OpCodes.Callvirt : OpCodes.Call, setMethod);
	}

	private void GenerateMemberMemberBinding(ILGenerator gen, MemberMemberBinding binding)
	{
		Type memberType = GetMemberType(binding.Member);
		if (binding.Member is PropertyInfo && memberType.IsValueType)
		{
			throw Error.CannotAutoInitializeValueTypeMemberThroughProperty(binding.Member);
		}
		StackType stackType = (memberType.IsValueType ? StackType.Address : StackType.Value);
		StackType stackType2 = GenerateMemberAccess(gen, binding.Member, stackType);
		if (stackType2 != stackType && memberType.IsValueType)
		{
			LocalBuilder local = gen.DeclareLocal(memberType);
			gen.Emit(OpCodes.Stloc, local);
			gen.Emit(OpCodes.Ldloca, local);
		}
		if (binding.Bindings.Count == 0)
		{
			gen.Emit(OpCodes.Pop);
		}
		else
		{
			GenerateMemberInit(gen, binding.Bindings, keepOnStack: false);
		}
	}

	private void GenerateMemberListBinding(ILGenerator gen, MemberListBinding binding)
	{
		Type memberType = GetMemberType(binding.Member);
		if (binding.Member is PropertyInfo && memberType.IsValueType)
		{
			throw Error.CannotAutoInitializeValueTypeElementThroughProperty(binding.Member);
		}
		StackType ask = (memberType.IsValueType ? StackType.Address : StackType.Value);
		StackType stackType = GenerateMemberAccess(gen, binding.Member, ask);
		if (stackType != StackType.Address && memberType.IsValueType)
		{
			LocalBuilder local = gen.DeclareLocal(memberType);
			gen.Emit(OpCodes.Stloc, local);
			gen.Emit(OpCodes.Ldloca, local);
		}
		GenerateListInit(gen, binding.Initializers, keepOnStack: false, memberType);
	}

	private StackType GenerateMemberInit(ILGenerator gen, MemberInitExpression init)
	{
		Generate(gen, init.NewExpression, StackType.Value);
		LocalBuilder localBuilder = null;
		if (init.NewExpression.Type.IsValueType && init.Bindings.Count > 0)
		{
			localBuilder = gen.DeclareLocal(init.NewExpression.Type);
			gen.Emit(OpCodes.Stloc, localBuilder);
			gen.Emit(OpCodes.Ldloca, localBuilder);
		}
		GenerateMemberInit(gen, init.Bindings, localBuilder == null);
		if (localBuilder != null)
		{
			gen.Emit(OpCodes.Ldloc, localBuilder);
		}
		return StackType.Value;
	}

	private void GenerateMemberInit(ILGenerator gen, ReadOnlyCollection<MemberBinding> bindings, bool keepOnStack)
	{
		int i = 0;
		for (int count = bindings.Count; i < count; i++)
		{
			if (keepOnStack || i < count - 1)
			{
				gen.Emit(OpCodes.Dup);
			}
			GenerateBinding(gen, bindings[i]);
		}
	}

	private StackType GenerateListInit(ILGenerator gen, ListInitExpression init)
	{
		Generate(gen, init.NewExpression, StackType.Value);
		LocalBuilder localBuilder = null;
		if (init.NewExpression.Type.IsValueType)
		{
			localBuilder = gen.DeclareLocal(init.NewExpression.Type);
			gen.Emit(OpCodes.Stloc, localBuilder);
			gen.Emit(OpCodes.Ldloca, localBuilder);
		}
		GenerateListInit(gen, init.Initializers, localBuilder == null, init.NewExpression.Type);
		if (localBuilder != null)
		{
			gen.Emit(OpCodes.Ldloc, localBuilder);
		}
		return StackType.Value;
	}

	private void GenerateListInit(ILGenerator gen, ReadOnlyCollection<ElementInit> initializers, bool keepOnStack, Type objectType)
	{
		int i = 0;
		for (int count = initializers.Count; i < count; i++)
		{
			if (keepOnStack || i < count - 1)
			{
				gen.Emit(OpCodes.Dup);
			}
			GenerateMethodCall(gen, initializers[i].AddMethod, initializers[i].Arguments, objectType);
		}
	}

	private Type GetMemberType(MemberInfo member)
	{
		if (member is FieldInfo fieldInfo)
		{
			return fieldInfo.FieldType;
		}
		if (!(member is PropertyInfo propertyInfo))
		{
			throw Error.MemberNotFieldOrProperty(member);
		}
		return propertyInfo.PropertyType;
	}

	private void GenerateNewArray(ILGenerator gen, NewArrayExpression nex)
	{
		Type elementType = nex.Type.GetElementType();
		if (nex.NodeType == ExpressionType.NewArrayInit)
		{
			GenerateConstInt(gen, nex.Expressions.Count);
			gen.Emit(OpCodes.Newarr, elementType);
			int i = 0;
			for (int count = nex.Expressions.Count; i < count; i++)
			{
				gen.Emit(OpCodes.Dup);
				GenerateConstInt(gen, i);
				Generate(gen, nex.Expressions[i], StackType.Value);
				GenerateArrayAssign(gen, elementType);
			}
			return;
		}
		Type[] array = new Type[nex.Expressions.Count];
		int j = 0;
		for (int num = array.Length; j < num; j++)
		{
			array[j] = typeof(int);
		}
		int k = 0;
		for (int count2 = nex.Expressions.Count; k < count2; k++)
		{
			Expression expression = nex.Expressions[k];
			Generate(gen, expression, StackType.Value);
			if ((object)expression.Type != typeof(int))
			{
				GenerateConvertToType(gen, expression.Type, typeof(int), isChecked: true);
			}
		}
		if (nex.Expressions.Count > 1)
		{
			int[] lengths = new int[nex.Expressions.Count];
			ConstructorInfo constructor = Array.CreateInstance(elementType, lengths).GetType().GetConstructor(array);
			gen.Emit(OpCodes.Newobj, constructor);
		}
		else
		{
			gen.Emit(OpCodes.Newarr, elementType);
		}
	}

	private void GenerateConvert(ILGenerator gen, UnaryExpression u)
	{
		if ((object)u.Method != null)
		{
			if (u.IsLifted && (!u.Type.IsValueType || !u.Operand.Type.IsValueType))
			{
				ParameterInfo[] parameters = u.Method.GetParameters();
				Type parameterType = parameters[0].ParameterType;
				if (parameterType.IsByRef)
				{
					parameterType = parameterType.GetElementType();
				}
				Expression node = Expression.Convert(Expression.Call(null, u.Method, Expression.Convert(u.Operand, parameters[0].ParameterType)), u.Type);
				Generate(gen, node, StackType.Value);
			}
			else
			{
				GenerateUnaryMethod(gen, u, StackType.Value);
			}
		}
		else
		{
			Generate(gen, u.Operand, StackType.Value);
			GenerateConvertToType(gen, u.Operand.Type, u.Type, u.NodeType == ExpressionType.ConvertChecked);
		}
	}

	private void GenerateCreateDelegate(ILGenerator gen, LambdaExpression lambda)
	{
		int value = GenerateLambda(lambda);
		GenerateLoadExecutionScope(gen);
		GenerateConstInt(gen, value);
		if (scope.HoistedLocalsVar != null)
		{
			GenerateLoadHoistedLocals(gen);
		}
		else
		{
			gen.Emit(OpCodes.Ldnull);
		}
		gen.Emit(OpCodes.Callvirt, typeof(ExecutionScope).GetMethod("CreateDelegate", BindingFlags.Instance | BindingFlags.Public));
		gen.Emit(OpCodes.Castclass, lambda.Type);
	}

	private StackType GenerateMethodCall(ILGenerator gen, MethodCallExpression mc, StackType ask)
	{
		StackType result = StackType.Value;
		MethodInfo method = mc.Method;
		if (!mc.Method.IsStatic)
		{
			StackType stackType = (mc.Object.Type.IsValueType ? StackType.Address : StackType.Value);
			StackType stackType2 = Generate(gen, mc.Object, stackType);
			if (stackType2 != stackType)
			{
				LocalBuilder local = gen.DeclareLocal(mc.Object.Type);
				gen.Emit(OpCodes.Stloc, local);
				gen.Emit(OpCodes.Ldloca, local);
			}
			if (ask == StackType.Address && mc.Object.Type.IsArray && (object)method == mc.Object.Type.GetMethod("Get", BindingFlags.Instance | BindingFlags.Public))
			{
				method = mc.Object.Type.GetMethod("Address", BindingFlags.Instance | BindingFlags.Public);
				result = StackType.Address;
			}
		}
		GenerateMethodCall(gen, method, mc.Arguments, (mc.Object == null) ? null : mc.Object.Type);
		return result;
	}

	private void GenerateMethodCall(ILGenerator gen, MethodInfo mi, ReadOnlyCollection<Expression> args, Type objectType)
	{
		ParameterInfo[] parameters = mi.GetParameters();
		List<WriteBack> list = GenerateArgs(gen, parameters, args);
		OpCode opCode = (UseVirtual(mi) ? OpCodes.Callvirt : OpCodes.Call);
		if (opCode == OpCodes.Callvirt && objectType.IsValueType)
		{
			gen.Emit(OpCodes.Constrained, objectType);
		}
		if (mi.CallingConvention == CallingConventions.VarArgs)
		{
			Type[] array = new Type[args.Count];
			int i = 0;
			for (int num = array.Length; i < num; i++)
			{
				array[i] = args[i].Type;
			}
			gen.EmitCall(opCode, mi, array);
		}
		else
		{
			gen.Emit(opCode, mi);
		}
		foreach (WriteBack item in list)
		{
			GenerateWriteBack(gen, item);
		}
	}

	private List<WriteBack> GenerateArgs(ILGenerator gen, ParameterInfo[] pis, ReadOnlyCollection<Expression> args)
	{
		List<WriteBack> list = new List<WriteBack>();
		int i = 0;
		for (int num = pis.Length; i < num; i++)
		{
			ParameterInfo parameterInfo = pis[i];
			Expression expression = args[i];
			StackType stackType = (parameterInfo.ParameterType.IsByRef ? StackType.Address : StackType.Value);
			StackType stackType2 = Generate(gen, expression, stackType);
			if (stackType == StackType.Address && stackType2 != StackType.Address)
			{
				LocalBuilder localBuilder = gen.DeclareLocal(expression.Type);
				gen.Emit(OpCodes.Stloc, localBuilder);
				gen.Emit(OpCodes.Ldloca, localBuilder);
				if (args[i] is MemberExpression)
				{
					list.Add(new WriteBack(localBuilder, args[i]));
				}
			}
		}
		return list;
	}

	private StackType GenerateLift(ILGenerator gen, ExpressionType nodeType, Type resultType, MethodCallExpression mc, IEnumerable<ParameterExpression> parameters, IEnumerable<Expression> arguments)
	{
		ReadOnlyCollection<ParameterExpression> readOnlyCollection = parameters.ToReadOnlyCollection();
		ReadOnlyCollection<Expression> readOnlyCollection2 = arguments.ToReadOnlyCollection();
		switch (nodeType)
		{
		case ExpressionType.Equal:
		case ExpressionType.NotEqual:
		{
			if ((object)resultType == Expression.GetNullableType(mc.Type))
			{
				break;
			}
			Label label = gen.DefineLabel();
			Label label2 = gen.DefineLabel();
			Label label3 = gen.DefineLabel();
			LocalBuilder local = gen.DeclareLocal(typeof(bool));
			LocalBuilder local2 = gen.DeclareLocal(typeof(bool));
			gen.Emit(OpCodes.Ldc_I4_0);
			gen.Emit(OpCodes.Stloc, local);
			gen.Emit(OpCodes.Ldc_I4_1);
			gen.Emit(OpCodes.Stloc, local2);
			int i = 0;
			for (int count = readOnlyCollection.Count; i < count; i++)
			{
				ParameterExpression p = readOnlyCollection[i];
				Expression expression = readOnlyCollection2[i];
				PrepareInitLocal(gen, p);
				if (IsNullable(expression.Type))
				{
					if (Generate(gen, expression, StackType.Address) == StackType.Value)
					{
						LocalBuilder local3 = gen.DeclareLocal(expression.Type);
						gen.Emit(OpCodes.Stloc, local3);
						gen.Emit(OpCodes.Ldloca, local3);
					}
					gen.Emit(OpCodes.Dup);
					GenerateHasValue(gen, expression.Type);
					gen.Emit(OpCodes.Ldc_I4_0);
					gen.Emit(OpCodes.Ceq);
					gen.Emit(OpCodes.Dup);
					gen.Emit(OpCodes.Ldloc, local);
					gen.Emit(OpCodes.Or);
					gen.Emit(OpCodes.Stloc, local);
					gen.Emit(OpCodes.Ldloc, local2);
					gen.Emit(OpCodes.And);
					gen.Emit(OpCodes.Stloc, local2);
					GenerateGetValueOrDefault(gen, expression.Type);
				}
				else
				{
					Generate(gen, expression, StackType.Value);
					if (!expression.Type.IsValueType)
					{
						gen.Emit(OpCodes.Dup);
						gen.Emit(OpCodes.Ldnull);
						gen.Emit(OpCodes.Ceq);
						gen.Emit(OpCodes.Dup);
						gen.Emit(OpCodes.Ldloc, local);
						gen.Emit(OpCodes.Or);
						gen.Emit(OpCodes.Stloc, local);
						gen.Emit(OpCodes.Ldloc, local2);
						gen.Emit(OpCodes.And);
						gen.Emit(OpCodes.Stloc, local2);
					}
					else
					{
						gen.Emit(OpCodes.Ldc_I4_0);
						gen.Emit(OpCodes.Stloc, local2);
					}
				}
				GenerateInitLocal(gen, p);
			}
			gen.Emit(OpCodes.Ldloc, local2);
			gen.Emit(OpCodes.Brtrue, label2);
			gen.Emit(OpCodes.Ldloc, local);
			gen.Emit(OpCodes.Brtrue, label3);
			Generate(gen, mc, StackType.Value);
			if (IsNullable(resultType) && (object)resultType != mc.Type)
			{
				ConstructorInfo constructor = resultType.GetConstructor(new Type[1] { mc.Type });
				gen.Emit(OpCodes.Newobj, constructor);
			}
			gen.Emit(OpCodes.Br_S, label);
			gen.MarkLabel(label2);
			bool flag = nodeType == ExpressionType.Equal;
			GenerateConstant(gen, Expression.Constant(flag), StackType.Value);
			gen.Emit(OpCodes.Br_S, label);
			gen.MarkLabel(label3);
			flag = nodeType == ExpressionType.NotEqual;
			GenerateConstant(gen, Expression.Constant(flag), StackType.Value);
			gen.MarkLabel(label);
			return StackType.Value;
		}
		}
		Label label4 = gen.DefineLabel();
		Label label5 = gen.DefineLabel();
		LocalBuilder local4 = gen.DeclareLocal(typeof(bool));
		int j = 0;
		for (int count2 = readOnlyCollection.Count; j < count2; j++)
		{
			ParameterExpression p2 = readOnlyCollection[j];
			Expression expression2 = readOnlyCollection2[j];
			if (IsNullable(expression2.Type))
			{
				PrepareInitLocal(gen, p2);
				if (Generate(gen, expression2, StackType.Address) == StackType.Value)
				{
					LocalBuilder local5 = gen.DeclareLocal(expression2.Type);
					gen.Emit(OpCodes.Stloc, local5);
					gen.Emit(OpCodes.Ldloca, local5);
				}
				gen.Emit(OpCodes.Dup);
				GenerateHasValue(gen, expression2.Type);
				gen.Emit(OpCodes.Ldc_I4_0);
				gen.Emit(OpCodes.Ceq);
				gen.Emit(OpCodes.Stloc, local4);
				GenerateGetValueOrDefault(gen, expression2.Type);
				GenerateInitLocal(gen, p2);
			}
			else
			{
				PrepareInitLocal(gen, p2);
				Generate(gen, expression2, StackType.Value);
				if (!expression2.Type.IsValueType)
				{
					gen.Emit(OpCodes.Dup);
					gen.Emit(OpCodes.Ldnull);
					gen.Emit(OpCodes.Ceq);
					gen.Emit(OpCodes.Stloc, local4);
				}
				GenerateInitLocal(gen, p2);
			}
			gen.Emit(OpCodes.Ldloc, local4);
			gen.Emit(OpCodes.Brtrue, label5);
		}
		Generate(gen, mc, StackType.Value);
		if (IsNullable(resultType) && (object)resultType != mc.Type)
		{
			ConstructorInfo constructor2 = resultType.GetConstructor(new Type[1] { mc.Type });
			gen.Emit(OpCodes.Newobj, constructor2);
		}
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label5);
		if ((object)resultType == Expression.GetNullableType(mc.Type))
		{
			if (resultType.IsValueType)
			{
				LocalBuilder local6 = gen.DeclareLocal(resultType);
				gen.Emit(OpCodes.Ldloca, local6);
				gen.Emit(OpCodes.Initobj, resultType);
				gen.Emit(OpCodes.Ldloc, local6);
			}
			else
			{
				gen.Emit(OpCodes.Ldnull);
			}
		}
		else
		{
			switch (nodeType)
			{
			case ExpressionType.GreaterThan:
			case ExpressionType.GreaterThanOrEqual:
			case ExpressionType.LessThan:
			case ExpressionType.LessThanOrEqual:
				gen.Emit(OpCodes.Ldc_I4_0);
				break;
			}
		}
		gen.MarkLabel(label4);
		return StackType.Value;
	}

	private StackType GenerateMemberAccess(ILGenerator gen, MemberExpression m, StackType ask)
	{
		return GenerateMemberAccess(gen, m.Expression, m.Member, ask);
	}

	private StackType GenerateMemberAccess(ILGenerator gen, Expression expression, MemberInfo member, StackType ask)
	{
		if (member is FieldInfo fieldInfo)
		{
			if (!fieldInfo.IsStatic)
			{
				StackType stackType = (expression.Type.IsValueType ? StackType.Address : StackType.Value);
				StackType stackType2 = Generate(gen, expression, stackType);
				if (stackType2 != stackType)
				{
					LocalBuilder local = gen.DeclareLocal(expression.Type);
					gen.Emit(OpCodes.Stloc, local);
					gen.Emit(OpCodes.Ldloca, local);
				}
			}
			return GenerateMemberAccess(gen, member, ask);
		}
		if (member is PropertyInfo propertyInfo)
		{
			MethodInfo getMethod = propertyInfo.GetGetMethod(nonPublic: true);
			if (!getMethod.IsStatic)
			{
				StackType stackType3 = (expression.Type.IsValueType ? StackType.Address : StackType.Value);
				StackType stackType4 = Generate(gen, expression, stackType3);
				if (stackType4 != stackType3)
				{
					LocalBuilder local2 = gen.DeclareLocal(expression.Type);
					gen.Emit(OpCodes.Stloc, local2);
					gen.Emit(OpCodes.Ldloca, local2);
				}
			}
			return GenerateMemberAccess(gen, member, ask);
		}
		throw Error.UnhandledMemberAccess(member);
	}

	private void GenerateWriteBack(ILGenerator gen, WriteBack writeback)
	{
		if (writeback.arg is MemberExpression memberExpression)
		{
			GenerateMemberWriteBack(gen, memberExpression.Expression, memberExpression.Member, writeback.loc);
		}
	}

	private void GenerateMemberWriteBack(ILGenerator gen, Expression expression, MemberInfo member, LocalBuilder loc)
	{
		if (member is FieldInfo fieldInfo)
		{
			if (!fieldInfo.IsStatic)
			{
				StackType ask = (expression.Type.IsValueType ? StackType.Address : StackType.Value);
				Generate(gen, expression, ask);
				gen.Emit(OpCodes.Ldloc, loc);
				gen.Emit(OpCodes.Stfld, fieldInfo);
			}
			else
			{
				gen.Emit(OpCodes.Ldloc, loc);
				gen.Emit(OpCodes.Stsfld, fieldInfo);
			}
			return;
		}
		if (member is PropertyInfo propertyInfo)
		{
			MethodInfo setMethod = propertyInfo.GetSetMethod(nonPublic: true);
			if ((object)setMethod != null)
			{
				if (!setMethod.IsStatic)
				{
					StackType ask2 = (expression.Type.IsValueType ? StackType.Address : StackType.Value);
					Generate(gen, expression, ask2);
				}
				gen.Emit(OpCodes.Ldloc, loc);
				gen.Emit(UseVirtual(setMethod) ? OpCodes.Callvirt : OpCodes.Call, setMethod);
			}
			return;
		}
		throw Error.UnhandledMemberAccess(member);
	}

	private bool UseVirtual(MethodInfo mi)
	{
		if (mi.IsStatic)
		{
			return false;
		}
		if (mi.DeclaringType!.IsValueType)
		{
			return false;
		}
		return true;
	}

	private void GenerateFieldAccess(ILGenerator gen, FieldInfo fi, StackType ask)
	{
		StackType stackType;
		if (fi.IsLiteral)
		{
			stackType = GenerateConstant(gen, fi.FieldType, fi.GetRawConstantValue(), ask);
		}
		else
		{
			OpCode opcode;
			if (ask != 0 && !fi.IsInitOnly)
			{
				opcode = (fi.IsStatic ? OpCodes.Ldsflda : OpCodes.Ldflda);
				stackType = StackType.Address;
			}
			else
			{
				opcode = (fi.IsStatic ? OpCodes.Ldsfld : OpCodes.Ldfld);
				stackType = StackType.Value;
			}
			gen.Emit(opcode, fi);
		}
		if (ask == StackType.Address && stackType == StackType.Value)
		{
			LocalBuilder local = gen.DeclareLocal(fi.FieldType);
			gen.Emit(OpCodes.Stloc, local);
			gen.Emit(OpCodes.Ldloca, local);
		}
	}

	private StackType GenerateMemberAccess(ILGenerator gen, MemberInfo member, StackType ask)
	{
		if (member is FieldInfo fi)
		{
			GenerateFieldAccess(gen, fi, ask);
			return ask;
		}
		if (member is PropertyInfo propertyInfo)
		{
			MethodInfo getMethod = propertyInfo.GetGetMethod(nonPublic: true);
			gen.Emit(UseVirtual(getMethod) ? OpCodes.Callvirt : OpCodes.Call, getMethod);
			return StackType.Value;
		}
		throw Error.UnhandledMemberAccess(member);
	}

	private StackType GenerateParameterAccess(ILGenerator gen, ParameterExpression p, StackType ask)
	{
		if (scope.Locals.TryGetValue(p, out var value))
		{
			if (ask == StackType.Value)
			{
				gen.Emit(OpCodes.Ldloc, value);
			}
			else
			{
				gen.Emit(OpCodes.Ldloca, value);
			}
			return ask;
		}
		if (scope.HoistedLocals.TryGetValue(p, out var value2))
		{
			GenerateLoadHoistedLocals(gen);
			return GenerateHoistedLocalAccess(gen, value2, p.Type, ask);
		}
		int num = 0;
		int count = scope.Lambda.Parameters.Count;
		while (true)
		{
			if (num < count)
			{
				if (scope.Lambda.Parameters[num] == p)
				{
					break;
				}
				num++;
				continue;
			}
			GenerateLoadExecutionScope(gen);
			CompileScope parent = scope.Parent;
			while (true)
			{
				if (parent != null)
				{
					if (parent.HoistedLocals.TryGetValue(p, out value2))
					{
						break;
					}
					gen.Emit(OpCodes.Ldfld, typeof(ExecutionScope).GetField("Parent", BindingFlags.Instance | BindingFlags.Public));
					parent = parent.Parent;
					continue;
				}
				throw Error.LambdaParameterNotInScope();
			}
			gen.Emit(OpCodes.Ldfld, typeof(ExecutionScope).GetField("Locals", BindingFlags.Instance | BindingFlags.Public));
			return GenerateHoistedLocalAccess(gen, value2, p.Type, ask);
		}
		return GenerateArgAccess(gen, num + 1, ask);
	}

	private StackType GenerateConstant(ILGenerator gen, ConstantExpression c, StackType ask)
	{
		return GenerateConstant(gen, c.Type, c.Value, ask);
	}

	private StackType GenerateConstant(ILGenerator gen, Type type, object value, StackType ask)
	{
		if (value == null)
		{
			if (type.IsValueType)
			{
				LocalBuilder local = gen.DeclareLocal(type);
				gen.Emit(OpCodes.Ldloca, local);
				gen.Emit(OpCodes.Initobj, type);
				gen.Emit(OpCodes.Ldloc, local);
			}
			else
			{
				gen.Emit(OpCodes.Ldnull);
			}
		}
		else
		{
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Boolean:
				GenerateConstInt(gen, ((bool)value) ? 1 : 0);
				break;
			case TypeCode.SByte:
				GenerateConstInt(gen, (sbyte)value);
				gen.Emit(OpCodes.Conv_I1);
				break;
			case TypeCode.Int16:
				GenerateConstInt(gen, (short)value);
				gen.Emit(OpCodes.Conv_I2);
				break;
			case TypeCode.Int32:
				GenerateConstInt(gen, (int)value);
				break;
			case TypeCode.Int64:
				gen.Emit(OpCodes.Ldc_I8, (long)value);
				break;
			default:
			{
				int iGlobal = AddGlobal(type, value);
				return GenerateGlobalAccess(gen, iGlobal, type, ask);
			}
			case TypeCode.Single:
				gen.Emit(OpCodes.Ldc_R4, (float)value);
				break;
			case TypeCode.Double:
				gen.Emit(OpCodes.Ldc_R8, (double)value);
				break;
			}
		}
		return StackType.Value;
	}

	private StackType GenerateUnary(ILGenerator gen, UnaryExpression u, StackType ask)
	{
		if ((object)u.Method != null)
		{
			return GenerateUnaryMethod(gen, u, ask);
		}
		if (u.NodeType == ExpressionType.NegateChecked && IsInteger(u.Operand.Type))
		{
			GenerateConstInt(gen, 0);
			GenerateConvertToType(gen, typeof(int), u.Operand.Type, isChecked: false);
			Generate(gen, u.Operand, StackType.Value);
			return GenerateBinaryOp(gen, ExpressionType.SubtractChecked, u.Operand.Type, u.Operand.Type, u.Type, liftedToNull: false, ask);
		}
		Generate(gen, u.Operand, StackType.Value);
		return GenerateUnaryOp(gen, u.NodeType, u.Operand.Type, u.Type, ask);
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

	private StackType GenerateUnaryMethod(ILGenerator gen, UnaryExpression u, StackType ask)
	{
		if (u.IsLifted)
		{
			ParameterExpression parameterExpression = Expression.Parameter(Expression.GetNonNullableType(u.Operand.Type), null);
			MethodCallExpression methodCallExpression = Expression.Call(null, u.Method, parameterExpression);
			Type nullableType = Expression.GetNullableType(methodCallExpression.Type);
			GenerateLift(gen, u.NodeType, nullableType, methodCallExpression, new ParameterExpression[1] { parameterExpression }, new Expression[1] { u.Operand });
			GenerateConvertToType(gen, nullableType, u.Type, isChecked: false);
			return StackType.Value;
		}
		MethodCallExpression node = Expression.Call(null, u.Method, u.Operand);
		return Generate(gen, node, ask);
	}

	private StackType GenerateConditional(ILGenerator gen, ConditionalExpression b)
	{
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Generate(gen, b.Test, StackType.Value);
		gen.Emit(OpCodes.Brfalse, label);
		Generate(gen, b.IfTrue, StackType.Value);
		gen.Emit(OpCodes.Br, label2);
		gen.MarkLabel(label);
		Generate(gen, b.IfFalse, StackType.Value);
		gen.MarkLabel(label2);
		return StackType.Value;
	}

	private void GenerateCoalesce(ILGenerator gen, BinaryExpression b)
	{
		if (IsNullable(b.Left.Type))
		{
			GenerateNullableCoalesce(gen, b);
			return;
		}
		if (b.Left.Type.IsValueType)
		{
			throw Error.CoalesceUsedOnNonNullType();
		}
		if (b.Conversion != null)
		{
			GenerateLambdaReferenceCoalesce(gen, b);
		}
		else if ((object)b.Method != null)
		{
			GenerateUserDefinedReferenceCoalesce(gen, b);
		}
		else
		{
			GenerateReferenceCoalesceWithoutConversion(gen, b);
		}
	}

	private void GenerateNullableCoalesce(ILGenerator gen, BinaryExpression b)
	{
		LocalBuilder local = gen.DeclareLocal(b.Left.Type);
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, b.Left.Type);
		gen.Emit(OpCodes.Brfalse, label);
		Type nonNullableType = GetNonNullableType(b.Left.Type);
		if ((object)b.Method != null)
		{
			ParameterInfo[] parameters = b.Method.GetParameters();
			if (!parameters[0].ParameterType.IsAssignableFrom(b.Left.Type))
			{
				gen.Emit(OpCodes.Ldloca, local);
				GenerateGetValueOrDefault(gen, b.Left.Type);
			}
			else
			{
				gen.Emit(OpCodes.Ldloc, local);
			}
			gen.Emit(OpCodes.Call, b.Method);
		}
		else if (b.Conversion != null)
		{
			ParameterExpression parameterExpression = b.Conversion.Parameters[0];
			PrepareInitLocal(gen, parameterExpression);
			if (!parameterExpression.Type.IsAssignableFrom(b.Left.Type))
			{
				gen.Emit(OpCodes.Ldloca, local);
				GenerateGetValueOrDefault(gen, b.Left.Type);
			}
			else
			{
				gen.Emit(OpCodes.Ldloc, local);
			}
			GenerateInitLocal(gen, parameterExpression);
			Generate(gen, b.Conversion.Body, StackType.Value);
		}
		else if ((object)b.Type != nonNullableType)
		{
			gen.Emit(OpCodes.Ldloca, local);
			GenerateGetValueOrDefault(gen, b.Left.Type);
			GenerateConvertToType(gen, nonNullableType, b.Type, isChecked: true);
		}
		else
		{
			gen.Emit(OpCodes.Ldloca, local);
			GenerateGetValueOrDefault(gen, b.Left.Type);
		}
		gen.Emit(OpCodes.Br, label2);
		gen.MarkLabel(label);
		Generate(gen, b.Right, StackType.Value);
		if ((object)b.Right.Type != b.Type)
		{
			GenerateConvertToType(gen, b.Right.Type, b.Type, isChecked: true);
		}
		gen.MarkLabel(label2);
	}

	private void GenerateLambdaReferenceCoalesce(ILGenerator gen, BinaryExpression b)
	{
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Dup);
		gen.Emit(OpCodes.Ldnull);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brfalse, label2);
		gen.Emit(OpCodes.Pop);
		Generate(gen, b.Right, StackType.Value);
		gen.Emit(OpCodes.Br, label);
		gen.MarkLabel(label2);
		ParameterExpression p = b.Conversion.Parameters[0];
		PrepareInitLocal(gen, p);
		GenerateInitLocal(gen, p);
		Generate(gen, b.Conversion.Body, StackType.Value);
		gen.MarkLabel(label);
	}

	private void GenerateUserDefinedReferenceCoalesce(ILGenerator gen, BinaryExpression b)
	{
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Dup);
		gen.Emit(OpCodes.Ldnull);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brfalse, label2);
		gen.Emit(OpCodes.Pop);
		Generate(gen, b.Right, StackType.Value);
		gen.Emit(OpCodes.Br_S, label);
		gen.MarkLabel(label2);
		gen.Emit(OpCodes.Call, b.Method);
		gen.MarkLabel(label);
	}

	private void GenerateReferenceCoalesceWithoutConversion(ILGenerator gen, BinaryExpression b)
	{
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Dup);
		gen.Emit(OpCodes.Ldnull);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brfalse, label2);
		gen.Emit(OpCodes.Pop);
		Generate(gen, b.Right, StackType.Value);
		if ((object)b.Right.Type != b.Type)
		{
			gen.Emit(OpCodes.Castclass, b.Type);
		}
		gen.Emit(OpCodes.Br_S, label);
		gen.MarkLabel(label2);
		if ((object)b.Left.Type != b.Type)
		{
			gen.Emit(OpCodes.Castclass, b.Type);
		}
		gen.MarkLabel(label);
	}

	private StackType GenerateUserdefinedLiftedAndAlso(ILGenerator gen, BinaryExpression b, StackType ask)
	{
		Type type = b.Left.Type;
		Type nonNullableType = GetNonNullableType(type);
		gen.DefineLabel();
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		LocalBuilder local = gen.DeclareLocal(type);
		LocalBuilder local2 = gen.DeclareLocal(type);
		LocalBuilder local3 = gen.DeclareLocal(nonNullableType);
		LocalBuilder local4 = gen.DeclareLocal(nonNullableType);
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Stloc, local);
		Generate(gen, b.Right, StackType.Value);
		gen.Emit(OpCodes.Stloc, local2);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, type);
		gen.Emit(OpCodes.Brfalse, label2);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, type);
		Type[] types = new Type[1] { nonNullableType };
		MethodInfo method = nonNullableType.GetMethod("op_False", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		gen.Emit(OpCodes.Call, method);
		gen.Emit(OpCodes.Brtrue, label2);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateHasValue(gen, type);
		gen.Emit(OpCodes.Brfalse, label);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, type);
		gen.Emit(OpCodes.Stloc, local3);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateGetValueOrDefault(gen, type);
		gen.Emit(OpCodes.Stloc, local4);
		types = new Type[2] { nonNullableType, nonNullableType };
		MethodInfo method2 = nonNullableType.GetMethod("op_BitwiseAnd", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		gen.Emit(OpCodes.Ldloc, local3);
		gen.Emit(OpCodes.Ldloc, local4);
		gen.Emit(OpCodes.Call, method2);
		if ((object)method2.ReturnType != type)
		{
			GenerateConvertToType(gen, method2.ReturnType, type, isChecked: true);
		}
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Br, label2);
		gen.MarkLabel(label);
		gen.Emit(OpCodes.Ldloc, local2);
		gen.Emit(OpCodes.Stloc, local);
		gen.MarkLabel(label2);
		return ReturnFromLocal(gen, ask, local);
	}

	private StackType GenerateLiftedAndAlso(ILGenerator gen, BinaryExpression b, StackType ask)
	{
		Type typeFromHandle = typeof(bool?);
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Label label3 = gen.DefineLabel();
		Label label4 = gen.DefineLabel();
		Label label5 = gen.DefineLabel();
		LocalBuilder local = gen.DeclareLocal(typeFromHandle);
		LocalBuilder local2 = gen.DeclareLocal(typeFromHandle);
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse, label);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, typeFromHandle);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brtrue, label2);
		gen.MarkLabel(label);
		Generate(gen, b.Right, StackType.Value);
		gen.Emit(OpCodes.Stloc, local2);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse_S, label3);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateGetValueOrDefault(gen, typeFromHandle);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brtrue_S, label2);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse, label3);
		gen.Emit(OpCodes.Ldc_I4_1);
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label2);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label4);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[1] { typeof(bool) });
		gen.Emit(OpCodes.Newobj, constructor);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Br, label5);
		gen.MarkLabel(label3);
		gen.Emit(OpCodes.Ldloca, local);
		gen.Emit(OpCodes.Initobj, typeFromHandle);
		gen.MarkLabel(label5);
		return ReturnFromLocal(gen, ask, local);
	}

	private void GenerateMethodAndAlso(ILGenerator gen, BinaryExpression b)
	{
		Label label = gen.DefineLabel();
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Dup);
		Type parameterType = b.Method.GetParameters()[0].ParameterType;
		Type[] types = new Type[1] { parameterType };
		MethodInfo method = parameterType.GetMethod("op_False", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		gen.Emit(OpCodes.Call, method);
		gen.Emit(OpCodes.Brtrue, label);
		Generate(gen, b.Right, StackType.Value);
		gen.Emit(OpCodes.Call, b.Method);
		gen.MarkLabel(label);
	}

	private void GenerateUnliftedAndAlso(ILGenerator gen, BinaryExpression b)
	{
		Generate(gen, b.Left, StackType.Value);
		Label label = gen.DefineLabel();
		gen.Emit(OpCodes.Dup);
		gen.Emit(OpCodes.Brfalse, label);
		gen.Emit(OpCodes.Pop);
		Generate(gen, b.Right, StackType.Value);
		gen.MarkLabel(label);
	}

	private StackType GenerateAndAlso(ILGenerator gen, BinaryExpression b, StackType ask)
	{
		if ((object)b.Method != null && !IsLiftedLogicalBinaryOperator(b.Left.Type, b.Right.Type, b.Method))
		{
			GenerateMethodAndAlso(gen, b);
		}
		else
		{
			if ((object)b.Left.Type == typeof(bool?))
			{
				return GenerateLiftedAndAlso(gen, b, ask);
			}
			if (IsLiftedLogicalBinaryOperator(b.Left.Type, b.Right.Type, b.Method))
			{
				return GenerateUserdefinedLiftedAndAlso(gen, b, ask);
			}
			GenerateUnliftedAndAlso(gen, b);
		}
		return StackType.Value;
	}

	private static bool IsLiftedLogicalBinaryOperator(Type left, Type right, MethodInfo method)
	{
		if ((object)right == left && IsNullable(left) && (object)method != null)
		{
			return (object)method.ReturnType == GetNonNullableType(left);
		}
		return false;
	}

	private StackType GenerateUserdefinedLiftedOrElse(ILGenerator gen, BinaryExpression b, StackType ask)
	{
		Type type = b.Left.Type;
		Type nonNullableType = GetNonNullableType(type);
		gen.DefineLabel();
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		LocalBuilder local = gen.DeclareLocal(type);
		LocalBuilder local2 = gen.DeclareLocal(type);
		LocalBuilder local3 = gen.DeclareLocal(nonNullableType);
		LocalBuilder local4 = gen.DeclareLocal(nonNullableType);
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Stloc, local);
		Generate(gen, b.Right, StackType.Value);
		gen.Emit(OpCodes.Stloc, local2);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, type);
		gen.Emit(OpCodes.Brfalse, label);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, type);
		Type[] types = new Type[1] { nonNullableType };
		MethodInfo method = nonNullableType.GetMethod("op_True", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		gen.Emit(OpCodes.Call, method);
		gen.Emit(OpCodes.Brtrue, label2);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateHasValue(gen, type);
		gen.Emit(OpCodes.Brfalse, label);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, type);
		gen.Emit(OpCodes.Stloc, local3);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateGetValueOrDefault(gen, type);
		gen.Emit(OpCodes.Stloc, local4);
		types = new Type[2] { nonNullableType, nonNullableType };
		MethodInfo method2 = nonNullableType.GetMethod("op_BitwiseOr", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		gen.Emit(OpCodes.Ldloc, local3);
		gen.Emit(OpCodes.Ldloc, local4);
		gen.Emit(OpCodes.Call, method2);
		if ((object)method2.ReturnType != type)
		{
			GenerateConvertToType(gen, method2.ReturnType, type, isChecked: true);
		}
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Br, label2);
		gen.MarkLabel(label);
		gen.Emit(OpCodes.Ldloc, local2);
		gen.Emit(OpCodes.Stloc, local);
		gen.MarkLabel(label2);
		return ReturnFromLocal(gen, ask, local);
	}

	private StackType GenerateLiftedOrElse(ILGenerator gen, BinaryExpression b, StackType ask)
	{
		Type typeFromHandle = typeof(bool?);
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Label label3 = gen.DefineLabel();
		Label label4 = gen.DefineLabel();
		Label label5 = gen.DefineLabel();
		LocalBuilder local = gen.DeclareLocal(typeFromHandle);
		LocalBuilder local2 = gen.DeclareLocal(typeFromHandle);
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse, label);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, typeFromHandle);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brfalse, label2);
		gen.MarkLabel(label);
		Generate(gen, b.Right, StackType.Value);
		gen.Emit(OpCodes.Stloc, local2);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse_S, label3);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateGetValueOrDefault(gen, typeFromHandle);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brfalse_S, label2);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse, label3);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label2);
		gen.Emit(OpCodes.Ldc_I4_1);
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label4);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[1] { typeof(bool) });
		gen.Emit(OpCodes.Newobj, constructor);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Br, label5);
		gen.MarkLabel(label3);
		gen.Emit(OpCodes.Ldloca, local);
		gen.Emit(OpCodes.Initobj, typeFromHandle);
		gen.MarkLabel(label5);
		return ReturnFromLocal(gen, ask, local);
	}

	private void GenerateUnliftedOrElse(ILGenerator gen, BinaryExpression b)
	{
		Generate(gen, b.Left, StackType.Value);
		Label label = gen.DefineLabel();
		gen.Emit(OpCodes.Dup);
		gen.Emit(OpCodes.Brtrue, label);
		gen.Emit(OpCodes.Pop);
		Generate(gen, b.Right, StackType.Value);
		gen.MarkLabel(label);
	}

	private void GenerateMethodOrElse(ILGenerator gen, BinaryExpression b)
	{
		Label label = gen.DefineLabel();
		Generate(gen, b.Left, StackType.Value);
		gen.Emit(OpCodes.Dup);
		Type parameterType = b.Method.GetParameters()[0].ParameterType;
		Type[] types = new Type[1] { parameterType };
		MethodInfo method = parameterType.GetMethod("op_True", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
		gen.Emit(OpCodes.Call, method);
		gen.Emit(OpCodes.Brtrue, label);
		Generate(gen, b.Right, StackType.Value);
		gen.Emit(OpCodes.Call, b.Method);
		gen.MarkLabel(label);
	}

	private StackType GenerateOrElse(ILGenerator gen, BinaryExpression b, StackType ask)
	{
		if ((object)b.Method != null && !IsLiftedLogicalBinaryOperator(b.Left.Type, b.Right.Type, b.Method))
		{
			GenerateMethodOrElse(gen, b);
		}
		else
		{
			if ((object)b.Left.Type == typeof(bool?))
			{
				return GenerateLiftedOrElse(gen, b, ask);
			}
			if (IsLiftedLogicalBinaryOperator(b.Left.Type, b.Right.Type, b.Method))
			{
				return GenerateUserdefinedLiftedOrElse(gen, b, ask);
			}
			GenerateUnliftedOrElse(gen, b);
		}
		return StackType.Value;
	}

	private static bool IsNullConstant(Expression e)
	{
		if (e.NodeType == ExpressionType.Constant)
		{
			return ((ConstantExpression)e).Value == null;
		}
		return false;
	}

	private StackType GenerateBinary(ILGenerator gen, BinaryExpression b, StackType ask)
	{
		switch (b.NodeType)
		{
		case ExpressionType.Coalesce:
			GenerateCoalesce(gen, b);
			return StackType.Value;
		case ExpressionType.AndAlso:
			return GenerateAndAlso(gen, b, ask);
		case ExpressionType.OrElse:
			return GenerateOrElse(gen, b, ask);
		case ExpressionType.Equal:
		case ExpressionType.NotEqual:
			if (IsNullConstant(b.Left) && !IsNullConstant(b.Right) && IsNullable(b.Right.Type))
			{
				return GenerateNullEquality(gen, b.NodeType, b.Right, b.IsLiftedToNull);
			}
			if (IsNullConstant(b.Right) && !IsNullConstant(b.Left) && IsNullable(b.Left.Type))
			{
				return GenerateNullEquality(gen, b.NodeType, b.Left, b.IsLiftedToNull);
			}
			break;
		}
		if ((object)b.Method != null)
		{
			return GenerateBinaryMethod(gen, b, ask);
		}
		Generate(gen, b.Left, StackType.Value);
		Generate(gen, b.Right, StackType.Value);
		return GenerateBinaryOp(gen, b.NodeType, b.Left.Type, b.Right.Type, b.Type, b.IsLiftedToNull, ask);
	}

	private StackType GenerateNullEquality(ILGenerator gen, ExpressionType op, Expression e, bool isLiftedToNull)
	{
		Generate(gen, e, StackType.Value);
		if (isLiftedToNull)
		{
			gen.Emit(OpCodes.Pop);
			GenerateConstant(gen, Expression.Constant(null, typeof(bool?)), StackType.Value);
		}
		else
		{
			LocalBuilder local = gen.DeclareLocal(e.Type);
			gen.Emit(OpCodes.Stloc, local);
			gen.Emit(OpCodes.Ldloca, local);
			GenerateHasValue(gen, e.Type);
			if (op == ExpressionType.Equal)
			{
				gen.Emit(OpCodes.Ldc_I4_0);
				gen.Emit(OpCodes.Ceq);
			}
		}
		return StackType.Value;
	}

	private StackType GenerateBinaryMethod(ILGenerator gen, BinaryExpression b, StackType ask)
	{
		if (b.IsLifted)
		{
			ParameterExpression parameterExpression = Expression.Parameter(Expression.GetNonNullableType(b.Left.Type), null);
			ParameterExpression parameterExpression2 = Expression.Parameter(Expression.GetNonNullableType(b.Right.Type), null);
			MethodCallExpression methodCallExpression = Expression.Call(null, b.Method, parameterExpression, parameterExpression2);
			Type type = null;
			if (b.IsLiftedToNull)
			{
				type = Expression.GetNullableType(methodCallExpression.Type);
			}
			else
			{
				switch (b.NodeType)
				{
				default:
					type = Expression.GetNullableType(methodCallExpression.Type);
					break;
				case ExpressionType.Equal:
				case ExpressionType.GreaterThan:
				case ExpressionType.GreaterThanOrEqual:
				case ExpressionType.LessThan:
				case ExpressionType.LessThanOrEqual:
				case ExpressionType.NotEqual:
					if ((object)methodCallExpression.Type != typeof(bool))
					{
						throw Error.ArgumentMustBeBoolean();
					}
					type = typeof(bool);
					break;
				}
			}
			IEnumerable<ParameterExpression> parameters = new ParameterExpression[2] { parameterExpression, parameterExpression2 };
			IEnumerable<Expression> arguments = new Expression[2] { b.Left, b.Right };
			Expression.ValidateLift(parameters, arguments);
			return GenerateLift(gen, b.NodeType, type, methodCallExpression, parameters, arguments);
		}
		MethodCallExpression node = Expression.Call(null, b.Method, b.Left, b.Right);
		return Generate(gen, node, ask);
	}

	private void GenerateTypeIs(ILGenerator gen, TypeBinaryExpression b)
	{
		Generate(gen, b.Expression, StackType.Value);
		if (b.Expression.Type.IsValueType)
		{
			gen.Emit(OpCodes.Box, b.Expression.Type);
		}
		gen.Emit(OpCodes.Isinst, b.TypeOperand);
		gen.Emit(OpCodes.Ldnull);
		gen.Emit(OpCodes.Cgt_Un);
	}

	private StackType GenerateHoistedLocalAccess(ILGenerator gen, int hoistIndex, Type type, StackType ask)
	{
		GenerateConstInt(gen, hoistIndex);
		gen.Emit(OpCodes.Ldelem_Ref);
		Type type2 = MakeStrongBoxType(type);
		gen.Emit(OpCodes.Castclass, type2);
		FieldInfo field = type2.GetField("Value", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
		if (ask == StackType.Value)
		{
			gen.Emit(OpCodes.Ldfld, field);
		}
		else
		{
			gen.Emit(OpCodes.Ldflda, field);
		}
		return ask;
	}

	private StackType GenerateGlobalAccess(ILGenerator gen, int iGlobal, Type type, StackType ask)
	{
		GenerateLoadExecutionScope(gen);
		gen.Emit(OpCodes.Ldfld, typeof(ExecutionScope).GetField("Globals", BindingFlags.Instance | BindingFlags.Public));
		GenerateConstInt(gen, iGlobal);
		gen.Emit(OpCodes.Ldelem_Ref);
		Type type2 = MakeStrongBoxType(type);
		gen.Emit(OpCodes.Castclass, type2);
		FieldInfo field = type2.GetField("Value", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
		if (ask == StackType.Value)
		{
			gen.Emit(OpCodes.Ldfld, field);
		}
		else
		{
			gen.Emit(OpCodes.Ldflda, field);
		}
		return ask;
	}

	private int AddGlobal(Type type, object value)
	{
		int count = globals.Count;
		globals.Add(Activator.CreateInstance(MakeStrongBoxType(type), value));
		return count;
	}

	private void GenerateCastToType(ILGenerator gen, Type typeFrom, Type typeTo)
	{
		if (!typeFrom.IsValueType && typeTo.IsValueType)
		{
			gen.Emit(OpCodes.Unbox_Any, typeTo);
		}
		else if (typeFrom.IsValueType && !typeTo.IsValueType)
		{
			gen.Emit(OpCodes.Box, typeFrom);
			if ((object)typeTo != typeof(object))
			{
				gen.Emit(OpCodes.Castclass, typeTo);
			}
		}
		else
		{
			if (typeFrom.IsValueType || typeTo.IsValueType)
			{
				throw Error.InvalidCast(typeFrom, typeTo);
			}
			gen.Emit(OpCodes.Castclass, typeTo);
		}
	}

	private void GenerateNullableToNullableConversion(ILGenerator gen, Type typeFrom, Type typeTo, bool isChecked)
	{
		Label label = default(Label);
		Label label2 = default(Label);
		LocalBuilder localBuilder = null;
		LocalBuilder localBuilder2 = null;
		localBuilder = gen.DeclareLocal(typeFrom);
		gen.Emit(OpCodes.Stloc, localBuilder);
		localBuilder2 = gen.DeclareLocal(typeTo);
		gen.Emit(OpCodes.Ldloca, localBuilder);
		GenerateHasValue(gen, typeFrom);
		label = gen.DefineLabel();
		gen.Emit(OpCodes.Brfalse_S, label);
		gen.Emit(OpCodes.Ldloca, localBuilder);
		GenerateGetValueOrDefault(gen, typeFrom);
		Type nonNullableType = GetNonNullableType(typeFrom);
		Type nonNullableType2 = GetNonNullableType(typeTo);
		GenerateConvertToType(gen, nonNullableType, nonNullableType2, isChecked);
		ConstructorInfo constructor = typeTo.GetConstructor(new Type[1] { nonNullableType2 });
		gen.Emit(OpCodes.Newobj, constructor);
		gen.Emit(OpCodes.Stloc, localBuilder2);
		label2 = gen.DefineLabel();
		gen.Emit(OpCodes.Br_S, label2);
		gen.MarkLabel(label);
		gen.Emit(OpCodes.Ldloca, localBuilder2);
		gen.Emit(OpCodes.Initobj, typeTo);
		gen.MarkLabel(label2);
		gen.Emit(OpCodes.Ldloc, localBuilder2);
	}

	private void GenerateNonNullableToNullableConversion(ILGenerator gen, Type typeFrom, Type typeTo, bool isChecked)
	{
		LocalBuilder localBuilder = null;
		localBuilder = gen.DeclareLocal(typeTo);
		Type nonNullableType = GetNonNullableType(typeTo);
		GenerateConvertToType(gen, typeFrom, nonNullableType, isChecked);
		ConstructorInfo constructor = typeTo.GetConstructor(new Type[1] { nonNullableType });
		gen.Emit(OpCodes.Newobj, constructor);
		gen.Emit(OpCodes.Stloc, localBuilder);
		gen.Emit(OpCodes.Ldloc, localBuilder);
	}

	private void GenerateNullableToNonNullableConversion(ILGenerator gen, Type typeFrom, Type typeTo, bool isChecked)
	{
		if (typeTo.IsValueType)
		{
			GenerateNullableToNonNullableStructConversion(gen, typeFrom, typeTo, isChecked);
		}
		else
		{
			GenerateNullableToReferenceConversion(gen, typeFrom);
		}
	}

	private void GenerateNullableToNonNullableStructConversion(ILGenerator gen, Type typeFrom, Type typeTo, bool isChecked)
	{
		LocalBuilder localBuilder = null;
		localBuilder = gen.DeclareLocal(typeFrom);
		gen.Emit(OpCodes.Stloc, localBuilder);
		gen.Emit(OpCodes.Ldloca, localBuilder);
		GenerateGetValue(gen, typeFrom);
		Type nonNullableType = GetNonNullableType(typeFrom);
		GenerateConvertToType(gen, nonNullableType, typeTo, isChecked);
	}

	private void GenerateNullableToReferenceConversion(ILGenerator gen, Type typeFrom)
	{
		gen.Emit(OpCodes.Box, typeFrom);
	}

	private void GenerateNullableConversion(ILGenerator gen, Type typeFrom, Type typeTo, bool isChecked)
	{
		bool flag = IsNullable(typeFrom);
		bool flag2 = IsNullable(typeTo);
		if (flag && flag2)
		{
			GenerateNullableToNullableConversion(gen, typeFrom, typeTo, isChecked);
		}
		else if (flag)
		{
			GenerateNullableToNonNullableConversion(gen, typeFrom, typeTo, isChecked);
		}
		else
		{
			GenerateNonNullableToNullableConversion(gen, typeFrom, typeTo, isChecked);
		}
	}

	private void GenerateNumericConversion(ILGenerator gen, Type typeFrom, Type typeTo, bool isChecked)
	{
		bool flag = IsUnsigned(typeFrom);
		IsFloatingPoint(typeFrom);
		if ((object)typeTo == typeof(float))
		{
			if (flag)
			{
				gen.Emit(OpCodes.Conv_R_Un);
			}
			gen.Emit(OpCodes.Conv_R4);
			return;
		}
		if ((object)typeTo == typeof(double))
		{
			if (flag)
			{
				gen.Emit(OpCodes.Conv_R_Un);
			}
			gen.Emit(OpCodes.Conv_R8);
			return;
		}
		TypeCode typeCode = Type.GetTypeCode(typeTo);
		if (isChecked)
		{
			if (flag)
			{
				switch (typeCode)
				{
				default:
					throw Error.UnhandledConvert(typeTo);
				case TypeCode.SByte:
					gen.Emit(OpCodes.Conv_Ovf_I1_Un);
					break;
				case TypeCode.Byte:
					gen.Emit(OpCodes.Conv_Ovf_U1_Un);
					break;
				case TypeCode.Int16:
					gen.Emit(OpCodes.Conv_Ovf_I2_Un);
					break;
				case TypeCode.Char:
				case TypeCode.UInt16:
					gen.Emit(OpCodes.Conv_Ovf_U2_Un);
					break;
				case TypeCode.Int32:
					gen.Emit(OpCodes.Conv_Ovf_I4_Un);
					break;
				case TypeCode.UInt32:
					gen.Emit(OpCodes.Conv_Ovf_U4_Un);
					break;
				case TypeCode.Int64:
					gen.Emit(OpCodes.Conv_Ovf_I8_Un);
					break;
				case TypeCode.UInt64:
					gen.Emit(OpCodes.Conv_Ovf_U8_Un);
					break;
				}
			}
			else
			{
				switch (typeCode)
				{
				default:
					throw Error.UnhandledConvert(typeTo);
				case TypeCode.SByte:
					gen.Emit(OpCodes.Conv_Ovf_I1);
					break;
				case TypeCode.Byte:
					gen.Emit(OpCodes.Conv_Ovf_U1);
					break;
				case TypeCode.Int16:
					gen.Emit(OpCodes.Conv_Ovf_I2);
					break;
				case TypeCode.Char:
				case TypeCode.UInt16:
					gen.Emit(OpCodes.Conv_Ovf_U2);
					break;
				case TypeCode.Int32:
					gen.Emit(OpCodes.Conv_Ovf_I4);
					break;
				case TypeCode.UInt32:
					gen.Emit(OpCodes.Conv_Ovf_U4);
					break;
				case TypeCode.Int64:
					gen.Emit(OpCodes.Conv_Ovf_I8);
					break;
				case TypeCode.UInt64:
					gen.Emit(OpCodes.Conv_Ovf_U8);
					break;
				}
			}
		}
		else if (flag)
		{
			switch (typeCode)
			{
			default:
				throw Error.UnhandledConvert(typeTo);
			case TypeCode.SByte:
			case TypeCode.Byte:
				gen.Emit(OpCodes.Conv_U1);
				break;
			case TypeCode.Char:
			case TypeCode.Int16:
			case TypeCode.UInt16:
				gen.Emit(OpCodes.Conv_U2);
				break;
			case TypeCode.Int32:
			case TypeCode.UInt32:
				gen.Emit(OpCodes.Conv_U4);
				break;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				gen.Emit(OpCodes.Conv_U8);
				break;
			}
		}
		else
		{
			switch (typeCode)
			{
			default:
				throw Error.UnhandledConvert(typeTo);
			case TypeCode.SByte:
			case TypeCode.Byte:
				gen.Emit(OpCodes.Conv_I1);
				break;
			case TypeCode.Char:
			case TypeCode.Int16:
			case TypeCode.UInt16:
				gen.Emit(OpCodes.Conv_I2);
				break;
			case TypeCode.Int32:
			case TypeCode.UInt32:
				gen.Emit(OpCodes.Conv_I4);
				break;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				gen.Emit(OpCodes.Conv_I8);
				break;
			}
		}
	}

	private void GenerateConvertToType(ILGenerator gen, Type typeFrom, Type typeTo, bool isChecked)
	{
		if ((object)typeFrom == typeTo)
		{
			return;
		}
		bool flag = IsNullable(typeFrom);
		bool flag2 = IsNullable(typeTo);
		Type nonNullableType = GetNonNullableType(typeFrom);
		Type nonNullableType2 = GetNonNullableType(typeTo);
		if (!typeFrom.IsInterface && !typeTo.IsInterface && (object)typeFrom != typeof(object) && (object)typeTo != typeof(object))
		{
			if (!flag && !flag2)
			{
				if ((IsConvertible(typeFrom) && IsConvertible(typeTo)) || (!nonNullableType.IsAssignableFrom(nonNullableType2) && !nonNullableType2.IsAssignableFrom(nonNullableType)))
				{
					if (typeFrom.IsArray && typeTo.IsArray)
					{
						GenerateCastToType(gen, typeFrom, typeTo);
					}
					else
					{
						GenerateNumericConversion(gen, typeFrom, typeTo, isChecked);
					}
				}
				else
				{
					GenerateCastToType(gen, typeFrom, typeTo);
				}
			}
			else
			{
				GenerateNullableConversion(gen, typeFrom, typeTo, isChecked);
			}
		}
		else
		{
			GenerateCastToType(gen, typeFrom, typeTo);
		}
	}

	private StackType ReturnFromLocal(ILGenerator gen, StackType ask, LocalBuilder local)
	{
		if (ask == StackType.Address)
		{
			gen.Emit(OpCodes.Ldloca, local);
		}
		else
		{
			gen.Emit(OpCodes.Ldloc, local);
		}
		return ask;
	}

	private StackType GenerateUnaryOp(ILGenerator gen, ExpressionType op, Type operandType, Type resultType, StackType ask)
	{
		bool flag = IsNullable(operandType);
		if (op == ExpressionType.ArrayLength)
		{
			gen.Emit(OpCodes.Ldlen);
			return StackType.Value;
		}
		if (flag)
		{
			switch (op)
			{
			case ExpressionType.TypeAs:
				gen.Emit(OpCodes.Box, operandType);
				gen.Emit(OpCodes.Isinst, resultType);
				if (IsNullable(resultType))
				{
					gen.Emit(OpCodes.Unbox_Any, resultType);
				}
				return StackType.Value;
			default:
				throw Error.UnhandledUnary(op);
			case ExpressionType.Not:
				if ((object)operandType == typeof(bool?))
				{
					gen.DefineLabel();
					Label label = gen.DefineLabel();
					LocalBuilder local = gen.DeclareLocal(operandType);
					gen.Emit(OpCodes.Stloc, local);
					gen.Emit(OpCodes.Ldloca, local);
					GenerateHasValue(gen, operandType);
					gen.Emit(OpCodes.Brfalse_S, label);
					gen.Emit(OpCodes.Ldloca, local);
					GenerateGetValueOrDefault(gen, operandType);
					Type nonNullableType = GetNonNullableType(operandType);
					GenerateUnaryOp(gen, op, nonNullableType, typeof(bool), StackType.Value);
					ConstructorInfo constructor = resultType.GetConstructor(new Type[1] { typeof(bool) });
					gen.Emit(OpCodes.Newobj, constructor);
					gen.Emit(OpCodes.Stloc, local);
					gen.MarkLabel(label);
					return ReturnFromLocal(gen, ask, local);
				}
				break;
			case ExpressionType.Negate:
			case ExpressionType.UnaryPlus:
			case ExpressionType.NegateChecked:
				break;
			}
			Label label2 = gen.DefineLabel();
			Label label3 = gen.DefineLabel();
			LocalBuilder local2 = gen.DeclareLocal(operandType);
			gen.Emit(OpCodes.Stloc, local2);
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateHasValue(gen, operandType);
			gen.Emit(OpCodes.Brfalse_S, label2);
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateGetValueOrDefault(gen, operandType);
			Type nonNullableType2 = GetNonNullableType(resultType);
			GenerateUnaryOp(gen, op, nonNullableType2, nonNullableType2, StackType.Value);
			ConstructorInfo constructor2 = resultType.GetConstructor(new Type[1] { nonNullableType2 });
			gen.Emit(OpCodes.Newobj, constructor2);
			gen.Emit(OpCodes.Stloc, local2);
			gen.Emit(OpCodes.Br_S, label3);
			gen.MarkLabel(label2);
			gen.Emit(OpCodes.Ldloca, local2);
			gen.Emit(OpCodes.Initobj, resultType);
			gen.MarkLabel(label3);
			return ReturnFromLocal(gen, ask, local2);
		}
		switch (op)
		{
		case ExpressionType.TypeAs:
			if (operandType.IsValueType)
			{
				gen.Emit(OpCodes.Box, operandType);
			}
			gen.Emit(OpCodes.Isinst, resultType);
			if (IsNullable(resultType))
			{
				gen.Emit(OpCodes.Unbox_Any, resultType);
			}
			break;
		case ExpressionType.UnaryPlus:
			gen.Emit(OpCodes.Nop);
			break;
		case ExpressionType.Negate:
		case ExpressionType.NegateChecked:
			gen.Emit(OpCodes.Neg);
			break;
		default:
			throw Error.UnhandledUnary(op);
		case ExpressionType.Not:
			if ((object)operandType == typeof(bool))
			{
				gen.Emit(OpCodes.Ldc_I4_0);
				gen.Emit(OpCodes.Ceq);
			}
			else
			{
				gen.Emit(OpCodes.Not);
			}
			break;
		}
		return StackType.Value;
	}

	private StackType GenerateLiftedBinaryArithmetic(ILGenerator gen, ExpressionType op, Type leftType, Type rightType, Type resultType, StackType ask)
	{
		bool flag = IsNullable(leftType);
		bool flag2 = IsNullable(rightType);
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		LocalBuilder local = gen.DeclareLocal(leftType);
		LocalBuilder local2 = gen.DeclareLocal(rightType);
		LocalBuilder local3 = gen.DeclareLocal(resultType);
		gen.Emit(OpCodes.Stloc, local2);
		gen.Emit(OpCodes.Stloc, local);
		if (flag && flag2)
		{
			gen.Emit(OpCodes.Ldloca, local);
			GenerateHasValue(gen, leftType);
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateHasValue(gen, rightType);
			gen.Emit(OpCodes.And);
			gen.Emit(OpCodes.Brfalse_S, label);
		}
		else if (flag)
		{
			gen.Emit(OpCodes.Ldloca, local);
			GenerateHasValue(gen, leftType);
			gen.Emit(OpCodes.Brfalse_S, label);
		}
		else if (flag2)
		{
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateHasValue(gen, rightType);
			gen.Emit(OpCodes.Brfalse_S, label);
		}
		if (flag)
		{
			gen.Emit(OpCodes.Ldloca, local);
			GenerateGetValueOrDefault(gen, leftType);
		}
		else
		{
			gen.Emit(OpCodes.Ldloc, local);
		}
		if (flag2)
		{
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateGetValueOrDefault(gen, rightType);
		}
		else
		{
			gen.Emit(OpCodes.Ldloc, local2);
		}
		GenerateBinaryOp(gen, op, GetNonNullableType(leftType), GetNonNullableType(rightType), GetNonNullableType(resultType), liftedToNull: false, StackType.Value);
		ConstructorInfo constructor = resultType.GetConstructor(new Type[1] { GetNonNullableType(resultType) });
		gen.Emit(OpCodes.Newobj, constructor);
		gen.Emit(OpCodes.Stloc, local3);
		gen.Emit(OpCodes.Br_S, label2);
		gen.MarkLabel(label);
		gen.Emit(OpCodes.Ldloca, local3);
		gen.Emit(OpCodes.Initobj, resultType);
		gen.MarkLabel(label2);
		return ReturnFromLocal(gen, ask, local3);
	}

	private StackType GenerateLiftedRelational(ILGenerator gen, ExpressionType op, Type leftType, Type rightType, Type resultType, bool liftedToNull, StackType ask)
	{
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Label label3 = gen.DefineLabel();
		LocalBuilder local = gen.DeclareLocal(leftType);
		LocalBuilder local2 = gen.DeclareLocal(rightType);
		gen.Emit(OpCodes.Stloc, local2);
		gen.Emit(OpCodes.Stloc, local);
		switch (op)
		{
		case ExpressionType.Equal:
			gen.Emit(OpCodes.Ldloca, local);
			GenerateHasValue(gen, leftType);
			gen.Emit(OpCodes.Ldc_I4_0);
			gen.Emit(OpCodes.Ceq);
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateHasValue(gen, rightType);
			gen.Emit(OpCodes.Ldc_I4_0);
			gen.Emit(OpCodes.Ceq);
			gen.Emit(OpCodes.And);
			gen.Emit(OpCodes.Dup);
			if (liftedToNull)
			{
				gen.Emit(OpCodes.Brtrue_S, label);
			}
			else
			{
				gen.Emit(OpCodes.Brtrue_S, label2);
			}
			gen.Emit(OpCodes.Pop);
			gen.Emit(OpCodes.Ldloca, local);
			GenerateHasValue(gen, leftType);
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateHasValue(gen, rightType);
			gen.Emit(OpCodes.And);
			gen.Emit(OpCodes.Dup);
			if (liftedToNull)
			{
				gen.Emit(OpCodes.Brfalse_S, label);
			}
			else
			{
				gen.Emit(OpCodes.Brfalse_S, label2);
			}
			gen.Emit(OpCodes.Pop);
			break;
		case ExpressionType.NotEqual:
			gen.Emit(OpCodes.Ldloca, local);
			GenerateHasValue(gen, leftType);
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateHasValue(gen, rightType);
			gen.Emit(OpCodes.Or);
			gen.Emit(OpCodes.Dup);
			if (liftedToNull)
			{
				gen.Emit(OpCodes.Brfalse_S, label);
			}
			else
			{
				gen.Emit(OpCodes.Brfalse_S, label2);
			}
			gen.Emit(OpCodes.Pop);
			gen.Emit(OpCodes.Ldloca, local);
			GenerateHasValue(gen, leftType);
			gen.Emit(OpCodes.Ldc_I4_0);
			gen.Emit(OpCodes.Ceq);
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateHasValue(gen, rightType);
			gen.Emit(OpCodes.Ldc_I4_0);
			gen.Emit(OpCodes.Ceq);
			gen.Emit(OpCodes.Or);
			gen.Emit(OpCodes.Dup);
			if (liftedToNull)
			{
				gen.Emit(OpCodes.Brtrue_S, label);
			}
			else
			{
				gen.Emit(OpCodes.Brtrue_S, label2);
			}
			gen.Emit(OpCodes.Pop);
			break;
		default:
			gen.Emit(OpCodes.Ldloca, local);
			GenerateHasValue(gen, leftType);
			gen.Emit(OpCodes.Ldloca, local2);
			GenerateHasValue(gen, rightType);
			gen.Emit(OpCodes.And);
			gen.Emit(OpCodes.Dup);
			if (liftedToNull)
			{
				gen.Emit(OpCodes.Brfalse_S, label);
			}
			else
			{
				gen.Emit(OpCodes.Brfalse_S, label2);
			}
			gen.Emit(OpCodes.Pop);
			break;
		}
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, leftType);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateGetValueOrDefault(gen, rightType);
		StackType result = GenerateBinaryOp(gen, op, GetNonNullableType(leftType), GetNonNullableType(rightType), GetNonNullableType(resultType), liftedToNull: false, ask);
		gen.MarkLabel(label2);
		if ((object)resultType != GetNonNullableType(resultType))
		{
			GenerateConvertToType(gen, GetNonNullableType(resultType), resultType, isChecked: true);
		}
		gen.Emit(OpCodes.Br, label3);
		gen.MarkLabel(label);
		gen.Emit(OpCodes.Pop);
		gen.Emit(OpCodes.Ldnull);
		gen.Emit(OpCodes.Unbox_Any, resultType);
		gen.MarkLabel(label3);
		return result;
	}

	private StackType GenerateLiftedBooleanAnd(ILGenerator gen, StackType ask)
	{
		Type typeFromHandle = typeof(bool?);
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Label label3 = gen.DefineLabel();
		Label label4 = gen.DefineLabel();
		Label label5 = gen.DefineLabel();
		LocalBuilder local = gen.DeclareLocal(typeFromHandle);
		LocalBuilder local2 = gen.DeclareLocal(typeFromHandle);
		gen.Emit(OpCodes.Stloc, local2);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse, label);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, typeFromHandle);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brtrue, label2);
		gen.MarkLabel(label);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse_S, label3);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateGetValueOrDefault(gen, typeFromHandle);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brtrue_S, label2);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse, label3);
		gen.Emit(OpCodes.Ldc_I4_1);
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label2);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label4);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[1] { typeof(bool) });
		gen.Emit(OpCodes.Newobj, constructor);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Br, label5);
		gen.MarkLabel(label3);
		gen.Emit(OpCodes.Ldloca, local);
		gen.Emit(OpCodes.Initobj, typeFromHandle);
		gen.MarkLabel(label5);
		return ReturnFromLocal(gen, ask, local);
	}

	private StackType GenerateLiftedBooleanOr(ILGenerator gen, StackType ask)
	{
		Type typeFromHandle = typeof(bool?);
		Label label = gen.DefineLabel();
		Label label2 = gen.DefineLabel();
		Label label3 = gen.DefineLabel();
		Label label4 = gen.DefineLabel();
		Label label5 = gen.DefineLabel();
		LocalBuilder local = gen.DeclareLocal(typeFromHandle);
		LocalBuilder local2 = gen.DeclareLocal(typeFromHandle);
		gen.Emit(OpCodes.Stloc, local2);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse, label);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateGetValueOrDefault(gen, typeFromHandle);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brfalse, label2);
		gen.MarkLabel(label);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse_S, label3);
		gen.Emit(OpCodes.Ldloca, local2);
		GenerateGetValueOrDefault(gen, typeFromHandle);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Ceq);
		gen.Emit(OpCodes.Brfalse_S, label2);
		gen.Emit(OpCodes.Ldloca, local);
		GenerateHasValue(gen, typeFromHandle);
		gen.Emit(OpCodes.Brfalse, label3);
		gen.Emit(OpCodes.Ldc_I4_0);
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label2);
		gen.Emit(OpCodes.Ldc_I4_1);
		gen.Emit(OpCodes.Br_S, label4);
		gen.MarkLabel(label4);
		ConstructorInfo constructor = typeFromHandle.GetConstructor(new Type[1] { typeof(bool) });
		gen.Emit(OpCodes.Newobj, constructor);
		gen.Emit(OpCodes.Stloc, local);
		gen.Emit(OpCodes.Br, label5);
		gen.MarkLabel(label3);
		gen.Emit(OpCodes.Ldloca, local);
		gen.Emit(OpCodes.Initobj, typeFromHandle);
		gen.MarkLabel(label5);
		return ReturnFromLocal(gen, ask, local);
	}

	private StackType GenerateLiftedBinaryOp(ILGenerator gen, ExpressionType op, Type leftType, Type rightType, Type resultType, bool liftedToNull, StackType ask)
	{
		switch (op)
		{
		case ExpressionType.Or:
			if ((object)leftType == typeof(bool?))
			{
				return GenerateLiftedBooleanOr(gen, ask);
			}
			return GenerateLiftedBinaryArithmetic(gen, op, leftType, rightType, resultType, ask);
		case ExpressionType.And:
			if ((object)leftType == typeof(bool?))
			{
				return GenerateLiftedBooleanAnd(gen, ask);
			}
			return GenerateLiftedBinaryArithmetic(gen, op, leftType, rightType, resultType, ask);
		case ExpressionType.Equal:
		case ExpressionType.GreaterThan:
		case ExpressionType.GreaterThanOrEqual:
		case ExpressionType.LessThan:
		case ExpressionType.LessThanOrEqual:
		case ExpressionType.NotEqual:
			return GenerateLiftedRelational(gen, op, leftType, rightType, resultType, liftedToNull, ask);
		default:
			return StackType.Value;
		case ExpressionType.Add:
		case ExpressionType.AddChecked:
		case ExpressionType.Divide:
		case ExpressionType.ExclusiveOr:
		case ExpressionType.LeftShift:
		case ExpressionType.Modulo:
		case ExpressionType.Multiply:
		case ExpressionType.MultiplyChecked:
		case ExpressionType.RightShift:
		case ExpressionType.Subtract:
		case ExpressionType.SubtractChecked:
			return GenerateLiftedBinaryArithmetic(gen, op, leftType, rightType, resultType, ask);
		}
	}

	private static void GenerateUnliftedEquality(ILGenerator gen, ExpressionType op, Type type)
	{
		if (!type.IsPrimitive && type.IsValueType && !type.IsEnum)
		{
			throw Error.OperatorNotImplementedForType(op, type);
		}
		gen.Emit(OpCodes.Ceq);
		if (op == ExpressionType.NotEqual)
		{
			gen.Emit(OpCodes.Ldc_I4_0);
			gen.Emit(OpCodes.Ceq);
		}
	}

	private StackType GenerateUnliftedBinaryOp(ILGenerator gen, ExpressionType op, Type leftType, Type rightType)
	{
		if (op != ExpressionType.Equal && op != ExpressionType.NotEqual)
		{
			if (!leftType.IsPrimitive)
			{
				throw Error.OperatorNotImplementedForType(op, leftType);
			}
			switch (op)
			{
			case ExpressionType.Or:
			case ExpressionType.OrElse:
				gen.Emit(OpCodes.Or);
				break;
			case ExpressionType.RightShift:
			{
				Type nonNullableType = GetNonNullableType(rightType);
				if ((object)nonNullableType != typeof(int))
				{
					GenerateConvertToType(gen, nonNullableType, typeof(int), isChecked: true);
				}
				if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Shr_Un);
				}
				else
				{
					gen.Emit(OpCodes.Shr);
				}
				break;
			}
			case ExpressionType.Subtract:
				gen.Emit(OpCodes.Sub);
				break;
			case ExpressionType.SubtractChecked:
			{
				LocalBuilder local5 = gen.DeclareLocal(leftType);
				LocalBuilder local6 = gen.DeclareLocal(rightType);
				gen.Emit(OpCodes.Stloc, local6);
				gen.Emit(OpCodes.Stloc, local5);
				gen.Emit(OpCodes.Ldloc, local5);
				gen.Emit(OpCodes.Ldloc, local6);
				if (IsFloatingPoint(leftType))
				{
					gen.Emit(OpCodes.Sub);
				}
				else if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Sub_Ovf_Un);
				}
				else
				{
					gen.Emit(OpCodes.Sub_Ovf);
				}
				break;
			}
			case ExpressionType.Divide:
				if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Div_Un);
				}
				else
				{
					gen.Emit(OpCodes.Div);
				}
				break;
			case ExpressionType.ExclusiveOr:
				gen.Emit(OpCodes.Xor);
				break;
			case ExpressionType.GreaterThan:
				if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Cgt_Un);
				}
				else
				{
					gen.Emit(OpCodes.Cgt);
				}
				break;
			case ExpressionType.GreaterThanOrEqual:
			{
				Label label = gen.DefineLabel();
				Label label2 = gen.DefineLabel();
				if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Bge_Un_S, label);
				}
				else
				{
					gen.Emit(OpCodes.Bge_S, label);
				}
				gen.Emit(OpCodes.Ldc_I4_0);
				gen.Emit(OpCodes.Br_S, label2);
				gen.MarkLabel(label);
				gen.Emit(OpCodes.Ldc_I4_1);
				gen.MarkLabel(label2);
				break;
			}
			case ExpressionType.LeftShift:
			{
				Type nonNullableType2 = GetNonNullableType(rightType);
				if ((object)nonNullableType2 != typeof(int))
				{
					GenerateConvertToType(gen, nonNullableType2, typeof(int), isChecked: true);
				}
				gen.Emit(OpCodes.Shl);
				break;
			}
			case ExpressionType.LessThan:
				if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Clt_Un);
				}
				else
				{
					gen.Emit(OpCodes.Clt);
				}
				break;
			case ExpressionType.LessThanOrEqual:
			{
				Label label3 = gen.DefineLabel();
				Label label4 = gen.DefineLabel();
				if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Ble_Un_S, label3);
				}
				else
				{
					gen.Emit(OpCodes.Ble_S, label3);
				}
				gen.Emit(OpCodes.Ldc_I4_0);
				gen.Emit(OpCodes.Br_S, label4);
				gen.MarkLabel(label3);
				gen.Emit(OpCodes.Ldc_I4_1);
				gen.MarkLabel(label4);
				break;
			}
			default:
				throw Error.UnhandledBinary(op);
			case ExpressionType.Modulo:
				if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Rem_Un);
				}
				else
				{
					gen.Emit(OpCodes.Rem);
				}
				break;
			case ExpressionType.Multiply:
				gen.Emit(OpCodes.Mul);
				break;
			case ExpressionType.MultiplyChecked:
			{
				LocalBuilder local3 = gen.DeclareLocal(leftType);
				LocalBuilder local4 = gen.DeclareLocal(rightType);
				gen.Emit(OpCodes.Stloc, local4);
				gen.Emit(OpCodes.Stloc, local3);
				gen.Emit(OpCodes.Ldloc, local3);
				gen.Emit(OpCodes.Ldloc, local4);
				if (IsFloatingPoint(leftType))
				{
					gen.Emit(OpCodes.Mul);
				}
				else if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Mul_Ovf_Un);
				}
				else
				{
					gen.Emit(OpCodes.Mul_Ovf);
				}
				break;
			}
			case ExpressionType.Add:
				gen.Emit(OpCodes.Add);
				break;
			case ExpressionType.AddChecked:
			{
				LocalBuilder local = gen.DeclareLocal(leftType);
				LocalBuilder local2 = gen.DeclareLocal(rightType);
				gen.Emit(OpCodes.Stloc, local2);
				gen.Emit(OpCodes.Stloc, local);
				gen.Emit(OpCodes.Ldloc, local);
				gen.Emit(OpCodes.Ldloc, local2);
				if (IsFloatingPoint(leftType))
				{
					gen.Emit(OpCodes.Add);
				}
				else if (IsUnsigned(leftType))
				{
					gen.Emit(OpCodes.Add_Ovf_Un);
				}
				else
				{
					gen.Emit(OpCodes.Add_Ovf);
				}
				break;
			}
			case ExpressionType.And:
			case ExpressionType.AndAlso:
				gen.Emit(OpCodes.And);
				break;
			}
			return StackType.Value;
		}
		GenerateUnliftedEquality(gen, op, leftType);
		return StackType.Value;
	}

	private StackType GenerateBinaryOp(ILGenerator gen, ExpressionType op, Type leftType, Type rightType, Type resultType, bool liftedToNull, StackType ask)
	{
		bool flag = IsNullable(leftType);
		bool flag2 = IsNullable(rightType);
		switch (op)
		{
		case ExpressionType.ArrayIndex:
		{
			if (flag2)
			{
				LocalBuilder local = gen.DeclareLocal(rightType);
				gen.Emit(OpCodes.Stloc, local);
				gen.Emit(OpCodes.Ldloca, local);
				GenerateGetValue(gen, rightType);
			}
			Type nonNullableType = GetNonNullableType(rightType);
			if ((object)nonNullableType != typeof(int))
			{
				GenerateConvertToType(gen, nonNullableType, typeof(int), isChecked: true);
			}
			return GenerateArrayAccess(gen, leftType.GetElementType(), ask);
		}
		default:
			if (flag)
			{
				return GenerateLiftedBinaryOp(gen, op, leftType, rightType, resultType, liftedToNull, ask);
			}
			return GenerateUnliftedBinaryOp(gen, op, leftType, rightType);
		case ExpressionType.Coalesce:
			throw Error.UnexpectedCoalesceOperator();
		}
	}

	private StackType GenerateArgAccess(ILGenerator gen, int iArg, StackType ask)
	{
		if (ask == StackType.Value)
		{
			switch (iArg)
			{
			default:
				if (iArg < 128)
				{
					gen.Emit(OpCodes.Ldarg_S, (byte)iArg);
				}
				else
				{
					gen.Emit(OpCodes.Ldarg, iArg);
				}
				break;
			case 0:
				gen.Emit(OpCodes.Ldarg_0);
				break;
			case 1:
				gen.Emit(OpCodes.Ldarg_1);
				break;
			case 2:
				gen.Emit(OpCodes.Ldarg_2);
				break;
			case 3:
				gen.Emit(OpCodes.Ldarg_3);
				break;
			}
		}
		else if (iArg < 128)
		{
			gen.Emit(OpCodes.Ldarga_S, (byte)iArg);
		}
		else
		{
			gen.Emit(OpCodes.Ldarga, iArg);
		}
		return ask;
	}

	private void GenerateConstInt(ILGenerator gen, int value)
	{
		switch (value)
		{
		case 0:
			gen.Emit(OpCodes.Ldc_I4_0);
			return;
		case 1:
			gen.Emit(OpCodes.Ldc_I4_1);
			return;
		case 2:
			gen.Emit(OpCodes.Ldc_I4_2);
			return;
		case 3:
			gen.Emit(OpCodes.Ldc_I4_3);
			return;
		case 4:
			gen.Emit(OpCodes.Ldc_I4_4);
			return;
		case 5:
			gen.Emit(OpCodes.Ldc_I4_5);
			return;
		case 6:
			gen.Emit(OpCodes.Ldc_I4_6);
			return;
		case 7:
			gen.Emit(OpCodes.Ldc_I4_7);
			return;
		case 8:
			gen.Emit(OpCodes.Ldc_I4_8);
			return;
		}
		if (value == -1)
		{
			gen.Emit(OpCodes.Ldc_I4_M1);
		}
		else if (value >= -127 && value < 128)
		{
			gen.Emit(OpCodes.Ldc_I4_S, (sbyte)value);
		}
		else
		{
			gen.Emit(OpCodes.Ldc_I4, value);
		}
	}

	private void GenerateArrayAssign(ILGenerator gen, Type type)
	{
		if (type.IsEnum)
		{
			gen.Emit(OpCodes.Stelem, type);
			return;
		}
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.SByte:
		case TypeCode.Byte:
			gen.Emit(OpCodes.Stelem_I1);
			return;
		case TypeCode.Int16:
		case TypeCode.UInt16:
			gen.Emit(OpCodes.Stelem_I2);
			return;
		case TypeCode.Int32:
		case TypeCode.UInt32:
			gen.Emit(OpCodes.Stelem_I4);
			return;
		case TypeCode.Int64:
		case TypeCode.UInt64:
			gen.Emit(OpCodes.Stelem_I8);
			return;
		case TypeCode.Single:
			gen.Emit(OpCodes.Stelem_R4);
			return;
		case TypeCode.Double:
			gen.Emit(OpCodes.Stelem_R8);
			return;
		}
		if (type.IsValueType)
		{
			gen.Emit(OpCodes.Stelem, type);
		}
		else
		{
			gen.Emit(OpCodes.Stelem_Ref);
		}
	}

	private StackType GenerateArrayAccess(ILGenerator gen, Type type, StackType ask)
	{
		if (ask == StackType.Address)
		{
			gen.Emit(OpCodes.Ldelema, type);
		}
		else if (!type.IsValueType)
		{
			gen.Emit(OpCodes.Ldelem_Ref);
		}
		else if (type.IsEnum)
		{
			gen.Emit(OpCodes.Ldelem, type);
		}
		else
		{
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.SByte:
				gen.Emit(OpCodes.Ldelem_I1);
				break;
			case TypeCode.Int16:
				gen.Emit(OpCodes.Ldelem_I2);
				break;
			case TypeCode.Int32:
				gen.Emit(OpCodes.Ldelem_I4);
				break;
			case TypeCode.Int64:
				gen.Emit(OpCodes.Ldelem_I8);
				break;
			default:
				gen.Emit(OpCodes.Ldelem, type);
				break;
			case TypeCode.Single:
				gen.Emit(OpCodes.Ldelem_R4);
				break;
			case TypeCode.Double:
				gen.Emit(OpCodes.Ldelem_R8);
				break;
			}
		}
		return ask;
	}

	private void GenerateHasValue(ILGenerator gen, Type nullableType)
	{
		MethodInfo method = nullableType.GetMethod("get_HasValue", BindingFlags.Instance | BindingFlags.Public);
		gen.Emit(OpCodes.Call, method);
	}

	private void GenerateGetValue(ILGenerator gen, Type nullableType)
	{
		MethodInfo method = nullableType.GetMethod("get_Value", BindingFlags.Instance | BindingFlags.Public);
		gen.Emit(OpCodes.Call, method);
	}

	private void GenerateGetValueOrDefault(ILGenerator gen, Type nullableType)
	{
		MethodInfo method = nullableType.GetMethod("GetValueOrDefault", Type.EmptyTypes);
		gen.Emit(OpCodes.Call, method);
	}

	private static bool IsNullable(Type type)
	{
		if (type.IsGenericType)
		{
			return (object)type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}
		return false;
	}

	private static Type GetNonNullableType(Type type)
	{
		if (IsNullable(type))
		{
			Type[] genericArguments = type.GetGenericArguments();
			return genericArguments[0];
		}
		return type;
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

	private static bool IsUnsigned(Type type)
	{
		if (type.IsGenericType && (object)type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			type = type.GetGenericArguments()[0];
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			return false;
		case TypeCode.Char:
		case TypeCode.Byte:
		case TypeCode.UInt16:
		case TypeCode.UInt32:
		case TypeCode.UInt64:
			return true;
		}
	}

	private static bool IsFloatingPoint(Type type)
	{
		if (type.IsGenericType && (object)type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			type = type.GetGenericArguments()[0];
		}
		switch (Type.GetTypeCode(type))
		{
		default:
			return false;
		case TypeCode.Single:
		case TypeCode.Double:
			return true;
		}
	}
}

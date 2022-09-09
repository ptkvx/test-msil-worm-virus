using System.Linq.Expressions;
using System.Reflection.Emit;

namespace System.Runtime.CompilerServices;

public class ExecutionScope
{
	private class ExpressionIsolator : ExpressionVisitor
	{
		private ExecutionScope top;

		private object[] toplocals;

		internal ExpressionIsolator(ExecutionScope top, object[] toplocals)
		{
			this.top = top;
			this.toplocals = toplocals;
		}

		internal override Expression VisitParameter(ParameterExpression p)
		{
			ExecutionScope parent = top;
			object[] locals = toplocals;
			int value;
			while (true)
			{
				if (parent != null)
				{
					if (parent.Lambda.HoistedLocals.TryGetValue(p, out value))
					{
						break;
					}
					locals = parent.Locals;
					parent = parent.Parent;
					continue;
				}
				return p;
			}
			return Expression.Field(Expression.Convert(Expression.ArrayIndex(Expression.Constant(locals, typeof(object[])), Expression.Constant(value, typeof(int))), locals[value].GetType()), "Value");
		}
	}

	public ExecutionScope Parent;

	public object[] Globals;

	public object[] Locals;

	private ExpressionCompiler.LambdaInfo Lambda;

	internal ExecutionScope(ExecutionScope parent, ExpressionCompiler.LambdaInfo lambda, object[] globals, object[] locals)
	{
		Parent = parent;
		Lambda = lambda;
		Globals = globals;
		Locals = locals;
	}

	public object[] CreateHoistedLocals()
	{
		return new object[Lambda.HoistedLocals.Count];
	}

	public Delegate CreateDelegate(int indexLambda, object[] locals)
	{
		ExpressionCompiler.LambdaInfo lambdaInfo = Lambda.Lambdas[indexLambda];
		ExecutionScope target = new ExecutionScope(this, lambdaInfo, Globals, locals);
		return ((DynamicMethod)lambdaInfo.Method).CreateDelegate(lambdaInfo.Lambda.Type, target);
	}

	public Expression IsolateExpression(Expression expression, object[] locals)
	{
		ExpressionIsolator expressionIsolator = new ExpressionIsolator(this, locals);
		return expressionIsolator.Visit(expression);
	}
}

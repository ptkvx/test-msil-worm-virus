using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Linq;

internal abstract class EnumerableExecutor
{
	internal abstract object ExecuteBoxed();

	internal static EnumerableExecutor Create(Expression expression)
	{
		Type type = typeof(EnumerableExecutor<>).MakeGenericType(expression.Type);
		return (EnumerableExecutor)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { expression }, null);
	}
}
internal class EnumerableExecutor<T> : EnumerableExecutor
{
	private Expression expression;

	private Func<T> func;

	internal EnumerableExecutor(Expression expression)
	{
		this.expression = expression;
	}

	internal override object ExecuteBoxed()
	{
		return Execute();
	}

	internal T Execute()
	{
		if (func == null)
		{
			EnumerableRewriter enumerableRewriter = new EnumerableRewriter();
			Expression body = enumerableRewriter.Visit(expression);
			ExpressionCompiler expressionCompiler = new ExpressionCompiler();
			Expression<Func<T>> lambda = Expression.Lambda<Func<T>>(body, (IEnumerable<ParameterExpression>)null);
			func = expressionCompiler.Compile(lambda);
		}
		return func();
	}
}

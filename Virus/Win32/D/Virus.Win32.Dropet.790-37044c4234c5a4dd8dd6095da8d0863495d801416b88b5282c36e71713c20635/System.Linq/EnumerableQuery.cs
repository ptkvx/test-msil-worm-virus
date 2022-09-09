using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Linq;

internal abstract class EnumerableQuery
{
	internal abstract Expression Expression { get; }

	internal abstract IEnumerable Enumerable { get; }

	internal static IQueryable Create(Type elementType, IEnumerable sequence)
	{
		Type type = typeof(EnumerableQuery<>).MakeGenericType(elementType);
		return (IQueryable)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { sequence }, null);
	}

	internal static IQueryable Create(Type elementType, Expression expression)
	{
		Type type = typeof(EnumerableQuery<>).MakeGenericType(elementType);
		return (IQueryable)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[1] { expression }, null);
	}
}
internal class EnumerableQuery<T> : EnumerableQuery, IEnumerable<T>, IQueryable<T>, IEnumerable, IOrderedQueryable<T>, IQueryable, IQueryProvider, IOrderedQueryable
{
	private Expression expression;

	private IEnumerable<T> enumerable;

	IQueryProvider IQueryable.Provider => this;

	internal override Expression Expression => expression;

	internal override IEnumerable Enumerable => enumerable;

	Expression IQueryable.Expression => expression;

	Type IQueryable.ElementType => typeof(T);

	internal EnumerableQuery(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
		expression = Expression.Constant(this);
	}

	internal EnumerableQuery(Expression expression)
	{
		this.expression = expression;
	}

	IQueryable IQueryProvider.CreateQuery(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		Type type = TypeHelper.FindGenericType(typeof(IQueryable<>), expression.Type);
		if ((object)type == null)
		{
			throw Error.ArgumentNotValid("expression");
		}
		return EnumerableQuery.Create(type.GetGenericArguments()[0], expression);
	}

	IQueryable<S> IQueryProvider.CreateQuery<S>(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if (!typeof(IQueryable<S>).IsAssignableFrom(expression.Type))
		{
			throw Error.ArgumentNotValid("expression");
		}
		return new EnumerableQuery<S>(expression);
	}

	object IQueryProvider.Execute(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		typeof(EnumerableExecutor<>).MakeGenericType(expression.Type);
		return EnumerableExecutor.Create(expression).ExecuteBoxed();
	}

	S IQueryProvider.Execute<S>(Expression expression)
	{
		if (expression == null)
		{
			throw Error.ArgumentNull("expression");
		}
		if (!typeof(S).IsAssignableFrom(expression.Type))
		{
			throw Error.ArgumentNotValid("expression");
		}
		return new EnumerableExecutor<S>(expression).Execute();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return GetEnumerator();
	}

	private IEnumerator<T> GetEnumerator()
	{
		if (enumerable == null)
		{
			EnumerableRewriter enumerableRewriter = new EnumerableRewriter();
			Expression body = enumerableRewriter.Visit(expression);
			ExpressionCompiler expressionCompiler = new ExpressionCompiler();
			Expression<Func<IEnumerable<T>>> lambda = Expression.Lambda<Func<IEnumerable<T>>>(body, (IEnumerable<ParameterExpression>)null);
			enumerable = expressionCompiler.Compile(lambda)();
		}
		return enumerable.GetEnumerator();
	}

	public override string ToString()
	{
		if (expression is ConstantExpression constantExpression && constantExpression.Value == this)
		{
			if (enumerable != null)
			{
				return enumerable.ToString();
			}
			return "null";
		}
		return expression.ToString();
	}
}

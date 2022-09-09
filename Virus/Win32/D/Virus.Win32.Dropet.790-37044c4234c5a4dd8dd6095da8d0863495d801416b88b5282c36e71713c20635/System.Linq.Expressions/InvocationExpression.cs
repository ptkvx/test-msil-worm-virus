using System.Collections.ObjectModel;
using System.Text;

namespace System.Linq.Expressions;

public sealed class InvocationExpression : Expression
{
	private ReadOnlyCollection<Expression> arguments;

	private Expression lambda;

	public Expression Expression => lambda;

	public ReadOnlyCollection<Expression> Arguments => arguments;

	internal InvocationExpression(Expression lambda, Type returnType, ReadOnlyCollection<Expression> arguments)
		: base(ExpressionType.Invoke, returnType)
	{
		this.lambda = lambda;
		this.arguments = arguments;
	}

	internal override void BuildString(StringBuilder builder)
	{
		builder.Append("Invoke(");
		lambda.BuildString(builder);
		int i = 0;
		for (int count = arguments.Count; i < count; i++)
		{
			builder.Append(",");
			arguments[i].BuildString(builder);
		}
		builder.Append(")");
	}
}

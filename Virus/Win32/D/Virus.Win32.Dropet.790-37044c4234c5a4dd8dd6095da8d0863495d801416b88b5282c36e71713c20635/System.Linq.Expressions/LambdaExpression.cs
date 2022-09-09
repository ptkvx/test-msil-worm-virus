using System.Collections.ObjectModel;
using System.Text;

namespace System.Linq.Expressions;

public class LambdaExpression : Expression
{
	private ReadOnlyCollection<ParameterExpression> parameters;

	private Expression body;

	public Expression Body => body;

	public ReadOnlyCollection<ParameterExpression> Parameters => parameters;

	internal LambdaExpression(Expression body, Type type, ReadOnlyCollection<ParameterExpression> parameters)
		: base(ExpressionType.Lambda, type)
	{
		this.body = body;
		this.parameters = parameters;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (Parameters.Count == 1)
		{
			Parameters[0].BuildString(builder);
		}
		else
		{
			builder.Append("(");
			int i = 0;
			for (int count = Parameters.Count; i < count; i++)
			{
				if (i > 0)
				{
					builder.Append(", ");
				}
				Parameters[i].BuildString(builder);
			}
			builder.Append(")");
		}
		builder.Append(" => ");
		body.BuildString(builder);
	}

	public Delegate Compile()
	{
		ExpressionCompiler expressionCompiler = new ExpressionCompiler();
		return expressionCompiler.Compile(this);
	}
}

using System.Text;

namespace System.Linq.Expressions;

public sealed class ConditionalExpression : Expression
{
	private Expression test;

	private Expression ifTrue;

	private Expression ifFalse;

	public Expression Test => test;

	public Expression IfTrue => ifTrue;

	public Expression IfFalse => ifFalse;

	internal ConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse, Type type)
		: base(ExpressionType.Conditional, type)
	{
		this.test = test;
		this.ifTrue = ifTrue;
		this.ifFalse = ifFalse;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		builder.Append("IIF(");
		test.BuildString(builder);
		builder.Append(", ");
		ifTrue.BuildString(builder);
		builder.Append(", ");
		ifFalse.BuildString(builder);
		builder.Append(")");
	}
}

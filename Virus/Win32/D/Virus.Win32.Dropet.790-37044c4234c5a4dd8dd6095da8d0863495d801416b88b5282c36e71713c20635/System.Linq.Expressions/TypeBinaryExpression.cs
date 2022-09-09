using System.Text;

namespace System.Linq.Expressions;

public sealed class TypeBinaryExpression : Expression
{
	private Expression expression;

	private Type typeop;

	public Expression Expression => expression;

	public Type TypeOperand => typeop;

	internal TypeBinaryExpression(ExpressionType nt, Expression expression, Type typeop, Type resultType)
		: base(nt, resultType)
	{
		this.expression = expression;
		this.typeop = typeop;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		builder.Append("(");
		expression.BuildString(builder);
		builder.Append(" Is ");
		builder.Append(typeop.Name);
		builder.Append(")");
	}
}

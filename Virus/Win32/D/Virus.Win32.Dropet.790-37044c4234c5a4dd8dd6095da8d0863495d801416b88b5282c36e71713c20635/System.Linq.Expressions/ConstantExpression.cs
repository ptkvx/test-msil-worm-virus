using System.Text;

namespace System.Linq.Expressions;

public sealed class ConstantExpression : Expression
{
	private object value;

	public object Value => value;

	internal ConstantExpression(object value, Type type)
		: base(ExpressionType.Constant, type)
	{
		this.value = value;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		if (value != null)
		{
			if (value is string)
			{
				builder.Append("\"");
				builder.Append(value);
				builder.Append("\"");
			}
			else if (value.ToString() == value.GetType().ToString())
			{
				builder.Append("value(");
				builder.Append(value);
				builder.Append(")");
			}
			else
			{
				builder.Append(value);
			}
		}
		else
		{
			builder.Append("null");
		}
	}
}

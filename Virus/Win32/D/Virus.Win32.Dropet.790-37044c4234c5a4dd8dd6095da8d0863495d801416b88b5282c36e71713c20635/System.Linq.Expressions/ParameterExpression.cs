using System.Text;

namespace System.Linq.Expressions;

public sealed class ParameterExpression : Expression
{
	private string name;

	public string Name => name;

	internal ParameterExpression(Type type, string name)
		: base(ExpressionType.Parameter, type)
	{
		this.name = name;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		if (name != null)
		{
			builder.Append(name);
		}
		else
		{
			builder.Append("<param>");
		}
	}
}

using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public sealed class ElementInit
{
	private MethodInfo addMethod;

	private ReadOnlyCollection<Expression> arguments;

	public MethodInfo AddMethod => addMethod;

	public ReadOnlyCollection<Expression> Arguments => arguments;

	internal ElementInit(MethodInfo addMethod, ReadOnlyCollection<Expression> arguments)
	{
		this.addMethod = addMethod;
		this.arguments = arguments;
	}

	internal void BuildString(StringBuilder builder)
	{
		builder.Append(AddMethod);
		builder.Append("(");
		bool flag = true;
		foreach (Expression argument in arguments)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				builder.Append(",");
			}
			argument.BuildString(builder);
		}
		builder.Append(")");
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		BuildString(stringBuilder);
		return stringBuilder.ToString();
	}
}

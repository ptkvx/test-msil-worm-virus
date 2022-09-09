using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Linq.Expressions;

public sealed class MethodCallExpression : Expression
{
	private MethodInfo method;

	private Expression obj;

	private ReadOnlyCollection<Expression> arguments;

	public MethodInfo Method => method;

	public Expression Object => obj;

	public ReadOnlyCollection<Expression> Arguments => arguments;

	internal MethodCallExpression(ExpressionType type, MethodInfo method, Expression obj, ReadOnlyCollection<Expression> arguments)
		: base(type, method.ReturnType)
	{
		this.obj = obj;
		this.method = method;
		this.arguments = arguments;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		int num = 0;
		Expression expression = obj;
		if (Attribute.GetCustomAttribute(method, typeof(ExtensionAttribute)) != null)
		{
			num = 1;
			expression = arguments[0];
		}
		if (expression != null)
		{
			expression.BuildString(builder);
			builder.Append(".");
		}
		builder.Append(method.Name);
		builder.Append("(");
		int i = num;
		for (int count = arguments.Count; i < count; i++)
		{
			if (i > num)
			{
				builder.Append(", ");
			}
			arguments[i].BuildString(builder);
		}
		builder.Append(")");
	}
}

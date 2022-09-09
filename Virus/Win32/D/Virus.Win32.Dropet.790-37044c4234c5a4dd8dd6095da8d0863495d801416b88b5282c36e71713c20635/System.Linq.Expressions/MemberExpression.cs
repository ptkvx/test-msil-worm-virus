using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public sealed class MemberExpression : Expression
{
	private Expression expr;

	private MemberInfo member;

	public Expression Expression => expr;

	public MemberInfo Member => member;

	internal MemberExpression(Expression expression, MemberInfo member, Type type)
		: base(ExpressionType.MemberAccess, type)
	{
		expr = expression;
		this.member = member;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		if (expr != null)
		{
			expr.BuildString(builder);
		}
		else
		{
			builder.Append(member.DeclaringType!.Name);
		}
		builder.Append(".");
		builder.Append(member.Name);
	}
}

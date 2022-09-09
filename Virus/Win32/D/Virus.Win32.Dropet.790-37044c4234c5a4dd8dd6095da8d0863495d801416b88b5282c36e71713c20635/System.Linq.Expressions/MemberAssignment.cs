using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public sealed class MemberAssignment : MemberBinding
{
	private Expression expression;

	public Expression Expression => expression;

	internal MemberAssignment(MemberInfo member, Expression expression)
		: base(MemberBindingType.Assignment, member)
	{
		this.expression = expression;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		builder.Append(base.Member.Name);
		builder.Append(" = ");
		expression.BuildString(builder);
	}
}

using System.Collections.ObjectModel;
using System.Text;

namespace System.Linq.Expressions;

public sealed class MemberInitExpression : Expression
{
	private NewExpression newExpression;

	private ReadOnlyCollection<MemberBinding> bindings;

	public NewExpression NewExpression => newExpression;

	public ReadOnlyCollection<MemberBinding> Bindings => bindings;

	internal MemberInitExpression(NewExpression newExpression, ReadOnlyCollection<MemberBinding> bindings)
		: base(ExpressionType.MemberInit, newExpression.Type)
	{
		this.newExpression = newExpression;
		this.bindings = bindings;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (newExpression.Arguments.Count == 0 && newExpression.Type.Name.Contains("<"))
		{
			builder.Append("new");
		}
		else
		{
			newExpression.BuildString(builder);
		}
		builder.Append(" {");
		int i = 0;
		for (int count = bindings.Count; i < count; i++)
		{
			MemberBinding memberBinding = bindings[i];
			if (i > 0)
			{
				builder.Append(", ");
			}
			memberBinding.BuildString(builder);
		}
		builder.Append("}");
	}
}

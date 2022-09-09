using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public sealed class MemberMemberBinding : MemberBinding
{
	private ReadOnlyCollection<MemberBinding> bindings;

	public ReadOnlyCollection<MemberBinding> Bindings => bindings;

	internal MemberMemberBinding(MemberInfo member, ReadOnlyCollection<MemberBinding> bindings)
		: base(MemberBindingType.MemberBinding, member)
	{
		this.bindings = bindings;
	}

	internal override void BuildString(StringBuilder builder)
	{
		builder.Append(base.Member.Name);
		builder.Append(" = {");
		int i = 0;
		for (int count = bindings.Count; i < count; i++)
		{
			if (i > 0)
			{
				builder.Append(", ");
			}
			bindings[i].BuildString(builder);
		}
		builder.Append("}");
	}
}

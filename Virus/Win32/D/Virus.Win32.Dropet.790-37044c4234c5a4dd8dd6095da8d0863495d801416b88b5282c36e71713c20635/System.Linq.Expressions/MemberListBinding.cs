using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public sealed class MemberListBinding : MemberBinding
{
	private ReadOnlyCollection<ElementInit> initializers;

	public ReadOnlyCollection<ElementInit> Initializers => initializers;

	internal MemberListBinding(MemberInfo member, ReadOnlyCollection<ElementInit> initializers)
		: base(MemberBindingType.ListBinding, member)
	{
		this.initializers = initializers;
	}

	internal override void BuildString(StringBuilder builder)
	{
		builder.Append(base.Member.Name);
		builder.Append(" = {");
		int i = 0;
		for (int count = initializers.Count; i < count; i++)
		{
			if (i > 0)
			{
				builder.Append(", ");
			}
			initializers[i].BuildString(builder);
		}
		builder.Append("}");
	}
}

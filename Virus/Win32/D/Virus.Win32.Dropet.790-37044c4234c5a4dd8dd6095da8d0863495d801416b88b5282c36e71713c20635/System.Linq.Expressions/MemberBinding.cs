using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public abstract class MemberBinding
{
	private MemberBindingType type;

	private MemberInfo member;

	public MemberBindingType BindingType => type;

	public MemberInfo Member => member;

	protected MemberBinding(MemberBindingType type, MemberInfo member)
	{
		this.type = type;
		this.member = member;
	}

	internal abstract void BuildString(StringBuilder builder);

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		BuildString(stringBuilder);
		return stringBuilder.ToString();
	}
}

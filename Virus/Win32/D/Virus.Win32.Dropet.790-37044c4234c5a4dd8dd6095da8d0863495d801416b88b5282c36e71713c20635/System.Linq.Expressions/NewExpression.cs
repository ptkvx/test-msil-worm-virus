using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public sealed class NewExpression : Expression
{
	private ConstructorInfo constructor;

	private ReadOnlyCollection<Expression> arguments;

	private ReadOnlyCollection<MemberInfo> members;

	public ConstructorInfo Constructor => constructor;

	public ReadOnlyCollection<Expression> Arguments => arguments;

	public ReadOnlyCollection<MemberInfo> Members => members;

	internal NewExpression(Type type, ConstructorInfo constructor, ReadOnlyCollection<Expression> arguments)
		: base(ExpressionType.New, type)
	{
		this.constructor = constructor;
		this.arguments = arguments;
	}

	internal NewExpression(Type type, ConstructorInfo constructor, ReadOnlyCollection<Expression> arguments, ReadOnlyCollection<MemberInfo> members)
		: base(ExpressionType.New, type)
	{
		this.constructor = constructor;
		this.arguments = arguments;
		this.members = members;
	}

	private static PropertyInfo GetPropertyNoThrow(MethodInfo method)
	{
		if ((object)method == null)
		{
			return null;
		}
		Type declaringType = method.DeclaringType;
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | (method.IsStatic ? BindingFlags.Static : BindingFlags.Instance);
		PropertyInfo[] properties = declaringType.GetProperties(bindingFlags);
		PropertyInfo[] array = properties;
		int num = 0;
		PropertyInfo propertyInfo;
		while (true)
		{
			if (num < array.Length)
			{
				propertyInfo = array[num];
				if (!propertyInfo.CanRead || (object)method != propertyInfo.GetGetMethod(nonPublic: true))
				{
					if (propertyInfo.CanWrite && (object)method == propertyInfo.GetSetMethod(nonPublic: true))
					{
						break;
					}
					num++;
					continue;
				}
				return propertyInfo;
			}
			return null;
		}
		return propertyInfo;
	}

	internal override void BuildString(StringBuilder builder)
	{
		Type type = (((object)constructor != null) ? constructor.DeclaringType : (type = base.Type));
		builder.Append("new ");
		int count = arguments.Count;
		builder.Append(type.Name);
		builder.Append("(");
		if (count > 0)
		{
			for (int i = 0; i < count; i++)
			{
				if (i > 0)
				{
					builder.Append(", ");
				}
				if (members != null)
				{
					PropertyInfo propertyInfo = null;
					if (members[i].MemberType == MemberTypes.Method && (object)(propertyInfo = GetPropertyNoThrow((MethodInfo)members[i])) != null)
					{
						builder.Append(propertyInfo.Name);
					}
					else
					{
						builder.Append(members[i].Name);
					}
					builder.Append(" = ");
				}
				arguments[i].BuildString(builder);
			}
		}
		builder.Append(")");
	}
}

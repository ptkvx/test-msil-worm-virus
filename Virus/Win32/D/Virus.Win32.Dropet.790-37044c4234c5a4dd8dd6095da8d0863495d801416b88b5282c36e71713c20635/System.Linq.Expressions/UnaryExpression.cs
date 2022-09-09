using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public sealed class UnaryExpression : Expression
{
	private Expression operand;

	private MethodInfo method;

	public Expression Operand => operand;

	public MethodInfo Method => method;

	public bool IsLifted
	{
		get
		{
			if (base.NodeType != ExpressionType.TypeAs && base.NodeType != ExpressionType.Quote)
			{
				bool flag = Expression.IsNullableType(operand.Type);
				bool flag2 = Expression.IsNullableType(base.Type);
				if ((object)method != null)
				{
					if (flag && (object)method.GetParameters()[0].ParameterType != operand.Type)
					{
						return true;
					}
					if (flag2)
					{
						return (object)method.ReturnType != base.Type;
					}
					return false;
				}
				if (!flag)
				{
					return flag2;
				}
				return true;
			}
			return false;
		}
	}

	public bool IsLiftedToNull
	{
		get
		{
			if (IsLifted)
			{
				return Expression.IsNullableType(base.Type);
			}
			return false;
		}
	}

	internal UnaryExpression(ExpressionType nt, Expression operand, Type type)
		: this(nt, operand, null, type)
	{
	}

	internal UnaryExpression(ExpressionType nt, Expression operand, MethodInfo method, Type type)
		: base(nt, type)
	{
		this.operand = operand;
		this.method = method;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		switch (base.NodeType)
		{
		case ExpressionType.TypeAs:
			builder.Append("(");
			operand.BuildString(builder);
			builder.Append(" As ");
			builder.Append(base.Type.Name);
			builder.Append(")");
			break;
		case ExpressionType.Quote:
			operand.BuildString(builder);
			break;
		case ExpressionType.UnaryPlus:
			builder.Append("+");
			operand.BuildString(builder);
			break;
		case ExpressionType.Negate:
		case ExpressionType.NegateChecked:
			builder.Append("-");
			operand.BuildString(builder);
			break;
		default:
			builder.Append(base.NodeType);
			builder.Append("(");
			operand.BuildString(builder);
			builder.Append(")");
			break;
		case ExpressionType.Not:
			builder.Append("Not");
			builder.Append("(");
			operand.BuildString(builder);
			builder.Append(")");
			break;
		}
	}
}

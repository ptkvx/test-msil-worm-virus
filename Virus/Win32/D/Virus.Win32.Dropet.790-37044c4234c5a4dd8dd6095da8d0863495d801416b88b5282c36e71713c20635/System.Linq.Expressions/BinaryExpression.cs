using System.Reflection;
using System.Text;

namespace System.Linq.Expressions;

public sealed class BinaryExpression : Expression
{
	private Expression left;

	private Expression right;

	private MethodInfo method;

	private LambdaExpression conversion;

	public Expression Left => left;

	public Expression Right => right;

	public MethodInfo Method => method;

	public LambdaExpression Conversion => conversion;

	public bool IsLifted
	{
		get
		{
			if (base.NodeType == ExpressionType.Coalesce)
			{
				return false;
			}
			bool flag = Expression.IsNullableType(left.Type);
			if ((object)method != null)
			{
				if (flag)
				{
					return (object)method.GetParameters()[0].ParameterType != left.Type;
				}
				return false;
			}
			return flag;
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

	internal BinaryExpression(ExpressionType nt, Expression left, Expression right, Type type)
		: this(nt, left, right, null, null, type)
	{
	}

	internal BinaryExpression(ExpressionType nt, Expression left, Expression right, MethodInfo method, Type type)
		: this(nt, left, right, method, null, type)
	{
	}

	internal BinaryExpression(ExpressionType nt, Expression left, Expression right, LambdaExpression conversion, Type type)
		: this(nt, left, right, null, conversion, type)
	{
	}

	internal BinaryExpression(ExpressionType nt, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, Type type)
		: base(nt, type)
	{
		this.left = left;
		this.right = right;
		this.method = method;
		this.conversion = conversion;
	}

	internal override void BuildString(StringBuilder builder)
	{
		if (builder == null)
		{
			throw Error.ArgumentNull("builder");
		}
		ExpressionType expressionType = base.NodeType;
		if (expressionType == ExpressionType.ArrayIndex)
		{
			left.BuildString(builder);
			builder.Append("[");
			right.BuildString(builder);
			builder.Append("]");
			return;
		}
		string @operator = GetOperator();
		if (@operator != null)
		{
			builder.Append("(");
			left.BuildString(builder);
			builder.Append(" ");
			builder.Append(@operator);
			builder.Append(" ");
			right.BuildString(builder);
			builder.Append(")");
		}
		else
		{
			builder.Append(base.NodeType);
			builder.Append("(");
			left.BuildString(builder);
			builder.Append(", ");
			right.BuildString(builder);
			builder.Append(")");
		}
	}

	private string GetOperator()
	{
		switch (base.NodeType)
		{
		case ExpressionType.Add:
		case ExpressionType.AddChecked:
			return "+";
		case ExpressionType.And:
			if ((object)base.Type != typeof(bool) && (object)base.Type != typeof(bool?))
			{
				return "&";
			}
			return "And";
		case ExpressionType.AndAlso:
			return "&&";
		case ExpressionType.Coalesce:
			return "??";
		case ExpressionType.Divide:
			return "/";
		case ExpressionType.Equal:
			return "=";
		case ExpressionType.ExclusiveOr:
			return "^";
		case ExpressionType.GreaterThan:
			return ">";
		case ExpressionType.GreaterThanOrEqual:
			return ">=";
		case ExpressionType.LeftShift:
			return "<<";
		case ExpressionType.LessThan:
			return "<";
		case ExpressionType.LessThanOrEqual:
			return "<=";
		case ExpressionType.Modulo:
			return "%";
		case ExpressionType.Multiply:
		case ExpressionType.MultiplyChecked:
			return "*";
		case ExpressionType.NotEqual:
			return "!=";
		case ExpressionType.Or:
			if ((object)base.Type != typeof(bool) && (object)base.Type != typeof(bool?))
			{
				return "|";
			}
			return "Or";
		case ExpressionType.OrElse:
			return "||";
		case ExpressionType.Power:
			return "^";
		default:
			return null;
		case ExpressionType.RightShift:
			return ">>";
		case ExpressionType.Subtract:
		case ExpressionType.SubtractChecked:
			return "-";
		}
	}
}

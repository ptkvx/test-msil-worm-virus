using System.Collections.ObjectModel;
using System.Text;

namespace System.Linq.Expressions;

public sealed class NewArrayExpression : Expression
{
	private ReadOnlyCollection<Expression> expressions;

	public ReadOnlyCollection<Expression> Expressions => expressions;

	internal NewArrayExpression(ExpressionType eType, Type type, ReadOnlyCollection<Expression> expressions)
		: base(eType, type)
	{
		this.expressions = expressions;
	}

	internal override void BuildString(StringBuilder builder)
	{
		switch (base.NodeType)
		{
		case ExpressionType.NewArrayInit:
		{
			builder.Append("new ");
			builder.Append("[] {");
			int j = 0;
			for (int count2 = expressions.Count; j < count2; j++)
			{
				if (j > 0)
				{
					builder.Append(", ");
				}
				expressions[j].BuildString(builder);
			}
			builder.Append("}");
			break;
		}
		case ExpressionType.NewArrayBounds:
		{
			builder.Append("new ");
			builder.Append(base.Type.ToString());
			builder.Append("(");
			int i = 0;
			for (int count = expressions.Count; i < count; i++)
			{
				if (i > 0)
				{
					builder.Append(", ");
				}
				expressions[i].BuildString(builder);
			}
			builder.Append(")");
			break;
		}
		}
	}
}

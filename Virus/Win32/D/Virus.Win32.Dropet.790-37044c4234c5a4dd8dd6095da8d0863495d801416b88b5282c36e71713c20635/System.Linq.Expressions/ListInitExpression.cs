using System.Collections.ObjectModel;
using System.Text;

namespace System.Linq.Expressions;

public sealed class ListInitExpression : Expression
{
	private NewExpression newExpression;

	private ReadOnlyCollection<ElementInit> initializers;

	public NewExpression NewExpression => newExpression;

	public ReadOnlyCollection<ElementInit> Initializers => initializers;

	internal ListInitExpression(NewExpression newExpression, ReadOnlyCollection<ElementInit> initializers)
		: base(ExpressionType.ListInit, newExpression.Type)
	{
		this.newExpression = newExpression;
		this.initializers = initializers;
	}

	internal override void BuildString(StringBuilder builder)
	{
		newExpression.BuildString(builder);
		builder.Append(" {");
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

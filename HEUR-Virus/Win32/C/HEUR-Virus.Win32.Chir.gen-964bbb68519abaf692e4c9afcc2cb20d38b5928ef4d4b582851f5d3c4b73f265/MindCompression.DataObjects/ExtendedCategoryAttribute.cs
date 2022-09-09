using System;
using System.ComponentModel;

namespace MindCompression.DataObjects;

[AttributeUsage(AttributeTargets.Property)]
public sealed class ExtendedCategoryAttribute : CategoryAttribute
{
	private int _highOrder = 100;

	private int _lowOrder = 0;

	private int _order = 0;

	public int Order
	{
		get
		{
			return _order;
		}
		set
		{
			_order = value;
		}
	}

	public int HighOrder
	{
		get
		{
			return _highOrder;
		}
		set
		{
			_highOrder = value;
		}
	}

	public int LowOrder
	{
		get
		{
			return _lowOrder;
		}
		set
		{
			_lowOrder = value;
		}
	}

	public ExtendedCategoryAttribute(string category)
		: base(category)
	{
	}

	public ExtendedCategoryAttribute(string category, int order)
		: this(category)
	{
		Order = order;
	}

	protected override string GetLocalizedString(string value)
	{
		string text = "";
		for (int i = 0; i < HighOrder - (Order - LowOrder); i++)
		{
			text += "\t";
		}
		return text + value;
	}
}

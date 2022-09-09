using System;

namespace MindCompression.DataObjects;

[AttributeUsage(AttributeTargets.Property)]
public sealed class PropertyInfoAttribute : Attribute
{
	private int _highOrder = 100;

	private int _lowOrder = 0;

	private string _name;

	private string _description;

	private int _order = 0;

	public string Name
	{
		get
		{
			string text = "";
			for (int i = 0; i < HighOrder - (Order - LowOrder); i++)
			{
				text += "\t";
			}
			return text + _name;
		}
		set
		{
			_name = value;
		}
	}

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = value;
		}
	}

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

	public PropertyInfoAttribute(string name)
		: this(name, "")
	{
	}

	public PropertyInfoAttribute(string name, int order)
		: this(name, "", order)
	{
	}

	public PropertyInfoAttribute(string name, string description)
		: this(name, description, 0)
	{
	}

	public PropertyInfoAttribute(string name, string description, int order)
	{
		Name = name;
		Description = description;
		Order = order;
	}
}

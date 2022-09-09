using System;

namespace MindCompression.DataObjects;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class ExpandDescriptionAttribute : Attribute
{
	private string _discription;

	public string Discription
	{
		get
		{
			return _discription;
		}
		set
		{
			_discription = value;
		}
	}

	public ExpandDescriptionAttribute(string discription)
	{
		Discription = discription;
	}
}

using System;
using System.ComponentModel;
using MindCompression.Memory;

namespace MindCompression.DataObjects;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Skills : PropertyObject
{
	protected int _skillsAddress;

	private ProcessMemory _pm;

	protected internal ProcessMemory ProcMemory
	{
		get
		{
			return _pm;
		}
		set
		{
			_pm = value;
		}
	}

	public Skills(int skillsAddress, ProcessMemory pm)
	{
		_pm = pm;
		_skillsAddress = skillsAddress;
	}

	public override string ToString()
	{
		foreach (Attribute attribute in GetAttributes())
		{
			if (attribute.GetType().Equals(typeof(ExpandDescriptionAttribute)))
			{
				return (attribute as ExpandDescriptionAttribute).Discription;
			}
		}
		return "None of these skills are implemented yet.";
	}
}

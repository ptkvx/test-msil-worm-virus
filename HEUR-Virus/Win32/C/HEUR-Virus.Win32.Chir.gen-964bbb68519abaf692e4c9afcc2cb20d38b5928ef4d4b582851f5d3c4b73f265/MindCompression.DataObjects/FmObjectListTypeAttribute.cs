using System;

namespace MindCompression.DataObjects;

[AttributeUsage(AttributeTargets.Property)]
public sealed class FmObjectListTypeAttribute : Attribute
{
	private FmObjectType _type;

	public FmObjectType Type
	{
		get
		{
			return _type;
		}
		set
		{
			_type = value;
		}
	}

	public FmObjectListTypeAttribute(FmObjectType type)
	{
		Type = type;
	}
}

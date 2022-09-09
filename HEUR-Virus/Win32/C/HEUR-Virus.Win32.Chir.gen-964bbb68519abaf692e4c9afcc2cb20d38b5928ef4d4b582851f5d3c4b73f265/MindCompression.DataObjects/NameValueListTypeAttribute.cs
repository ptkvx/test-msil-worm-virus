using System;
using System.Collections;

namespace MindCompression.DataObjects;

[AttributeUsage(AttributeTargets.Property)]
public sealed class NameValueListTypeAttribute : Attribute
{
	private INameValueList _list;

	public ArrayList List => _list.List;

	public NameValueListTypeAttribute(Type type)
	{
		if ((object)type.GetInterface("INameValueList") != typeof(INameValueList))
		{
			throw new ArgumentOutOfRangeException("type", type, "The type should implement INameValueList.");
		}
		_list = (INameValueList)Activator.CreateInstance(type);
	}
}

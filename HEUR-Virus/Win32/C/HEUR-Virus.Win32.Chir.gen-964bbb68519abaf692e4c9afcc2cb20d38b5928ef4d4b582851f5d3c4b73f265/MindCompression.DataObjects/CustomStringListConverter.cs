using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace MindCompression.DataObjects;

public class CustomStringListConverter : StringConverter
{
	private ArrayList _list;

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		InitializeList(context);
		return new StandardValuesCollection(_list);
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType.Equals(typeof(string)))
		{
			return true;
		}
		return base.CanConvertFrom(context, sourceType);
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if (destinationType.Equals(typeof(string)))
		{
			return true;
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		InitializeList(context);
		if (value.GetType().Equals(typeof(string)))
		{
			foreach (NameValueObject item in _list)
			{
				if (item.Name.Equals(value.ToString()))
				{
					return item.Value;
				}
			}
			return base.ConvertFrom(context, culture, value);
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		InitializeList(context);
		if (destinationType.Equals(typeof(string)))
		{
			if (value.GetType().Equals(typeof(NameValueObject)))
			{
				return (value as NameValueObject).Name;
			}
			foreach (NameValueObject item in _list)
			{
				if (item.Value.Equals((object?)Convert.ToByte(value)))
				{
					return item.Name;
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	private void InitializeList(ITypeDescriptorContext context)
	{
		if (_list == null)
		{
			try
			{
				NameValueListTypeAttribute nameValueListTypeAttribute = context.PropertyDescriptor.Attributes[typeof(NameValueListTypeAttribute)] as NameValueListTypeAttribute;
				_list = nameValueListTypeAttribute.List;
			}
			catch
			{
				_list = new ArrayList();
			}
		}
	}
}

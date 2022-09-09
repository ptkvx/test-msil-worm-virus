using System;
using System.ComponentModel;

namespace MindCompression.DataObjects;

public class ExtendedPropertyDescriptor : PropertyDescriptor
{
	private PropertyDescriptor _basePropertyDescriptor;

	public override string DisplayName
	{
		get
		{
			foreach (Attribute attribute in _basePropertyDescriptor.Attributes)
			{
				if (attribute is PropertyInfoAttribute)
				{
					return (attribute as PropertyInfoAttribute).Name;
				}
			}
			return _basePropertyDescriptor.DisplayName;
		}
	}

	public override string Description
	{
		get
		{
			foreach (Attribute attribute in _basePropertyDescriptor.Attributes)
			{
				if (attribute is PropertyInfoAttribute)
				{
					return (attribute as PropertyInfoAttribute).Description;
				}
			}
			return _basePropertyDescriptor.Description;
		}
	}

	public override Type ComponentType => _basePropertyDescriptor.ComponentType;

	public override bool IsReadOnly => _basePropertyDescriptor.IsReadOnly;

	public override Type PropertyType => _basePropertyDescriptor.PropertyType;

	public ExtendedPropertyDescriptor(PropertyDescriptor basePropertyDescriptor)
		: base(basePropertyDescriptor)
	{
		_basePropertyDescriptor = basePropertyDescriptor;
	}

	public override object GetValue(object component)
	{
		return _basePropertyDescriptor.GetValue(component);
	}

	public override void ResetValue(object component)
	{
		_basePropertyDescriptor.ResetValue(component);
	}

	public override void SetValue(object component, object value)
	{
		_basePropertyDescriptor.SetValue(component, value);
	}

	public override bool ShouldSerializeValue(object component)
	{
		return _basePropertyDescriptor.ShouldSerializeValue(component);
	}

	public override bool CanResetValue(object component)
	{
		return _basePropertyDescriptor.CanResetValue(component);
	}
}

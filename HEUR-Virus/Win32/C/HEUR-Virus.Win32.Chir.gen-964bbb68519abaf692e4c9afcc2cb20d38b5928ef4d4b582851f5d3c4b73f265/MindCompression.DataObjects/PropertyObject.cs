using System;
using System.ComponentModel;

namespace MindCompression.DataObjects;

public class PropertyObject : ICustomTypeDescriptor
{
	private PropertyDescriptorCollection _extendedProperties;

	public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
	{
		if (_extendedProperties == null)
		{
			PropertyDescriptorCollection propertyDescriptorCollection = ((attributes != null) ? TypeDescriptor.GetProperties(this, attributes, noCustomTypeDesc: true) : TypeDescriptor.GetProperties(this, noCustomTypeDesc: true));
			_extendedProperties = new PropertyDescriptorCollection(null);
			int num = int.MinValue;
			int num2 = int.MaxValue;
			int num3 = int.MinValue;
			int num4 = int.MaxValue;
			foreach (PropertyDescriptor item in propertyDescriptorCollection)
			{
				foreach (Attribute attribute3 in item.Attributes)
				{
					if (attribute3.GetType().Equals(typeof(PropertyInfoAttribute)))
					{
						if ((attribute3 as PropertyInfoAttribute).Order < num2)
						{
							num2 = (attribute3 as PropertyInfoAttribute).Order;
						}
						if ((attribute3 as PropertyInfoAttribute).Order > num)
						{
							num = (attribute3 as PropertyInfoAttribute).Order;
						}
					}
					if (attribute3.GetType().Equals(typeof(ExtendedCategoryAttribute)))
					{
						if ((attribute3 as ExtendedCategoryAttribute).Order < num4)
						{
							num4 = (attribute3 as ExtendedCategoryAttribute).Order;
						}
						if ((attribute3 as ExtendedCategoryAttribute).Order > num3)
						{
							num3 = (attribute3 as ExtendedCategoryAttribute).Order;
						}
					}
				}
			}
			foreach (PropertyDescriptor item2 in propertyDescriptorCollection)
			{
				foreach (Attribute attribute4 in item2.Attributes)
				{
					if (attribute4.GetType().Equals(typeof(PropertyInfoAttribute)))
					{
						(attribute4 as PropertyInfoAttribute).LowOrder = num2;
						(attribute4 as PropertyInfoAttribute).HighOrder = num;
					}
					if (attribute4.GetType().Equals(typeof(ExtendedCategoryAttribute)))
					{
						(attribute4 as ExtendedCategoryAttribute).LowOrder = num4;
						(attribute4 as ExtendedCategoryAttribute).HighOrder = num3;
					}
				}
				_extendedProperties.Add(new ExtendedPropertyDescriptor(item2));
			}
		}
		return _extendedProperties;
	}

	public TypeConverter GetConverter()
	{
		return TypeDescriptor.GetConverter(this, noCustomTypeDesc: true);
	}

	public EventDescriptorCollection GetEvents(Attribute[] attributes)
	{
		return TypeDescriptor.GetEvents(this, attributes, noCustomTypeDesc: true);
	}

	public EventDescriptorCollection GetEvents()
	{
		return TypeDescriptor.GetEvents(this, noCustomTypeDesc: true);
	}

	public string GetComponentName()
	{
		return TypeDescriptor.GetComponentName(this, noCustomTypeDesc: true);
	}

	public object GetPropertyOwner(PropertyDescriptor pd)
	{
		return this;
	}

	public AttributeCollection GetAttributes()
	{
		return TypeDescriptor.GetAttributes(this, noCustomTypeDesc: true);
	}

	public PropertyDescriptorCollection GetProperties()
	{
		return GetProperties(null);
	}

	public object GetEditor(Type editorBaseType)
	{
		return TypeDescriptor.GetEditor(this, editorBaseType, noCustomTypeDesc: true);
	}

	public PropertyDescriptor GetDefaultProperty()
	{
		return TypeDescriptor.GetDefaultProperty(this, noCustomTypeDesc: true);
	}

	public EventDescriptor GetDefaultEvent()
	{
		return TypeDescriptor.GetDefaultEvent(this, noCustomTypeDesc: true);
	}

	public string GetClassName()
	{
		return TypeDescriptor.GetClassName(this, noCustomTypeDesc: true);
	}
}

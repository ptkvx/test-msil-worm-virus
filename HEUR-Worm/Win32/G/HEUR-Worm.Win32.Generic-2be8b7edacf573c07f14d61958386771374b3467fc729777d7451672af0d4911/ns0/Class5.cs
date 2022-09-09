using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class Class5
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private sealed class Class6
	{
		private readonly XNamespace[] xnamespace_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Class6(XNamespace[] xnamespace_1)
		{
			xnamespace_0 = xnamespace_1;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal XElement method_0(XElement xelement_0)
		{
			return smethod_4(xnamespace_0, xelement_0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal object method_1(object object_0)
		{
			XElement val = (XElement)((object_0 is XElement) ? object_0 : null);
			if (val != null)
			{
				return smethod_4(xnamespace_0, val);
			}
			return object_0;
		}
	}

	public static string Value
	{
		get
		{
			using (IEnumerator<XElement> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return current.get_Value();
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.set_Value(value);
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			using (IEnumerator<XElement> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return (string)current.Attribute(name);
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.SetAttributeValue(name, (object)value);
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			return (string)source.Attribute(name);
		}
		set
		{
			source.SetAttributeValue(name, (object)value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private Class5()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute smethod_0(XName xname_0, object object_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (object_0 == null)
		{
			return null;
		}
		return new XAttribute(xname_0, RuntimeHelpers.GetObjectValue(object_0));
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute smethod_1(XName xname_0, XNamespace xnamespace_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		XAttribute val = new XAttribute(xname_0, (object)xnamespace_0.get_NamespaceName());
		((XObject)val).AddAnnotation((object)xnamespace_0);
		return val;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static object smethod_2(XNamespace[] xnamespace_0, object object_0)
	{
		if ((xnamespace_0 != null && object_0 != null) ? true : false)
		{
			XElement val = (XElement)((object_0 is XElement) ? object_0 : null);
			if (val != null)
			{
				return smethod_4(xnamespace_0, val);
			}
			if (object_0 is IEnumerable ienumerable_)
			{
				return smethod_3(xnamespace_0, ienumerable_);
			}
		}
		return object_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable smethod_3(XNamespace[] xnamespace_0, IEnumerable ienumerable_0)
	{
		if ((xnamespace_0 != null && ienumerable_0 != null) ? true : false)
		{
			if (ienumerable_0 is IEnumerable<XElement> source)
			{
				return source.Select(new Class6(xnamespace_0).method_0);
			}
			return ienumerable_0.Cast<object>().Select(new Class6(xnamespace_0).method_1);
		}
		return ienumerable_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XElement smethod_4(XNamespace[] xnamespace_0, XElement xelement_0)
	{
		checked
		{
			if ((xnamespace_0 != null && xelement_0 != null) ? true : false)
			{
				XAttribute val = xelement_0.get_FirstAttribute();
				while (val != null)
				{
					XAttribute nextAttribute = val.get_NextAttribute();
					if (val.get_IsNamespaceDeclaration())
					{
						XNamespace val2 = ((XObject)val).Annotation<XNamespace>();
						if (val2 != null)
						{
							int num = xnamespace_0.Length - 1;
							int num2 = num;
							int num3 = 0;
							while (true)
							{
								int num4 = num3;
								int num5 = num2;
								if (num4 <= num5)
								{
									if (!(val2 == xnamespace_0[num3]))
									{
										num3++;
										continue;
									}
									val.Remove();
									break;
								}
								break;
							}
						}
					}
					val = nextAttribute;
				}
			}
			return xelement_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XNamespace smethod_5(ref XNamespace xnamespace_0, string string_0)
	{
		if (xnamespace_0 == null)
		{
			xnamespace_0 = XNamespace.Get(string_0);
		}
		return xnamespace_0;
	}
}

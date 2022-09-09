using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace t;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class e
{
	private static ResourceManager c;

	private static CultureInfo i;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager y
	{
		get
		{
			if (object.ReferenceEquals(c, null))
			{
				ResourceManager resourceManager = (c = new ResourceManager("t.e", typeof(e).Assembly));
			}
			return c;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo l
	{
		get
		{
			return i;
		}
		set
		{
			i = value;
		}
	}
}

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace My.Resources;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null) && 0 == 0)
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("δ.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceManager_0;
		}
	}

	internal static byte[] Byte_0
	{
		get
		{
			object @object = ResourceManager_0.GetObject("Θ", cultureInfo_0);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}

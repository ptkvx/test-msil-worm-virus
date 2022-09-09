using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace My.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Resources
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 180392)]
	private struct Struct3
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Resources", typeof(Resources).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	[SpecialName]
	internal static Bitmap smethod_0()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		return (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("Key0", cultureInfo_0));
	}

	static Resources()
	{
		char_1 = new char[90196];
		char[] array = new char[8];
		array[0] = '\u00b8';
		array[3] = '⌭';
		array[4] = 'ጲ';
		array[5] = 'ሟ';
		array[2] = 'त';
		array[1] = 'セ';
		array[6] = 'ჾ';
		array[7] = '⚣';
		string_0 = new string[474];
		char_0 = array;
	}
}

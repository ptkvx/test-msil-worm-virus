using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace System;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Res
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("System.Res", typeof(Res).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string BigIntInfinity => ResourceManager.GetString("BigIntInfinity", resourceCulture);

	internal static string InvalidCharactersInString => ResourceManager.GetString("InvalidCharactersInString", resourceCulture);

	internal static string MustBeBigInt => ResourceManager.GetString("MustBeBigInt", resourceCulture);

	internal static string MustBePositive => ResourceManager.GetString("MustBePositive", resourceCulture);

	internal static string NonNegative => ResourceManager.GetString("NonNegative", resourceCulture);

	internal static string NotANumber => ResourceManager.GetString("NotANumber", resourceCulture);

	internal static string Overflow_Byte => ResourceManager.GetString("Overflow_Byte", resourceCulture);

	internal static string Overflow_Decimal => ResourceManager.GetString("Overflow_Decimal", resourceCulture);

	internal static string Overflow_Double => ResourceManager.GetString("Overflow_Double", resourceCulture);

	internal static string Overflow_Int16 => ResourceManager.GetString("Overflow_Int16", resourceCulture);

	internal static string Overflow_Int32 => ResourceManager.GetString("Overflow_Int32", resourceCulture);

	internal static string Overflow_Int64 => ResourceManager.GetString("Overflow_Int64", resourceCulture);

	internal static string Overflow_SByte => ResourceManager.GetString("Overflow_SByte", resourceCulture);

	internal static string Overflow_Single => ResourceManager.GetString("Overflow_Single", resourceCulture);

	internal static string Overflow_UInt16 => ResourceManager.GetString("Overflow_UInt16", resourceCulture);

	internal static string Overflow_UInt32 => ResourceManager.GetString("Overflow_UInt32", resourceCulture);

	internal static string Overflow_UInt64 => ResourceManager.GetString("Overflow_UInt64", resourceCulture);

	internal static string ParsedStringWasInvalid => ResourceManager.GetString("ParsedStringWasInvalid", resourceCulture);

	internal static string UnsupportedNumberStyle => ResourceManager.GetString("UnsupportedNumberStyle", resourceCulture);

	internal Res()
	{
	}
}

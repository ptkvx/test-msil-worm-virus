using System;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class14
{
	public struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		public short short_0;

		public short short_1;

		public short short_2;

		public byte byte_0;

		public byte byte_1;
	}

	public static string smethod_0()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = "";
		if (oSVersion.Platform.ToString() == "Win32NT")
		{
			switch (smethod_1(oSVersion.Version))
			{
			case "4.1.2222":
				text = Class1.smethod_3("L0FGPEfYO8ENT0v4ERA=", bool_0: true);
				break;
			case "4.1.2600":
				text = Class1.smethod_3("L0FGPEdP2DvBDUv4ERArHQ==", bool_0: true);
				break;
			case "4.9.3000":
				text = Class1.smethod_3("[WINME]", bool_0: true);
				break;
			case "5.0.2195":
				text = Class1.smethod_3("L0FGPEdP2DvBDUv4CggICA==", bool_0: true);
				break;
			case "5.1.2600":
			case "5.2.3790":
				text = Class1.smethod_3("L0FGPEfYO8ENT0v4MCg=", bool_0: true);
				break;
			case "6.0.6000":
			case "6.0.6001":
			case "6.0.6002":
			case "6.0.6003":
				text = Class1.smethod_3("+w0SCBMbpHuKjhfE+g0XGAU=", bool_0: true);
				break;
			case "6.1.7600":
			case "6.1.7601":
			case "6.1.7602":
			case "6.1.7603":
				text = Class1.smethod_3("+w0SCKR7io4TGxfE2w==", bool_0: true);
				break;
			default:
				text = Class1.smethod_3("+RIPpHuKjhITGxI=", bool_0: true);
				break;
			}
		}
		Struct0 struct0_ = default(Struct0);
		struct0_.int_0 = Marshal.SizeOf(typeof(Struct0));
		if (GetVersionEx(ref struct0_))
		{
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("8wUSFgkDBaDMBSXA8AEDC8DR", bool_0: true)))
			{
				text += Class1.smethod_3("OGsYVzSwaEk=", bool_0: true);
			}
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("8wUSFgkDBaDMBSXA8AEDC8DS", bool_0: true)))
			{
				text += Class1.smethod_3("OGsYVzSwaEo=", bool_0: true);
			}
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("8wUSFgkDBaDMBSXA8AEDC8DT", bool_0: true)))
			{
				text += Class1.smethod_3("OGsYVzSwaEs=", bool_0: true);
			}
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("8wUSFgkDBaDMBSXA8AEDC8DU", bool_0: true)))
			{
				text += Class1.smethod_3("OGsYVzSwaEw=", bool_0: true);
			}
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("8wUSFgkDBaDMBSXA8AEDC8DV", bool_0: true)))
			{
				text += Class1.smethod_3("OGsYVzSwaE0=", bool_0: true);
			}
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("8wUSFgkDBaDMBSXA8AEDC8DW", bool_0: true)))
			{
				text += Class1.smethod_3("OGsYVzSwaE4=", bool_0: true);
			}
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("8wUSFgkDBaDMBSXA8AEDC8DX", bool_0: true)))
			{
				text += Class1.smethod_3("OGsYVzSwaE8=", bool_0: true);
			}
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("a32KjoF7fRhXNLA4aHl7gzhQ", bool_0: true)))
			{
				text += Class1.smethod_3("iLtoXUo8uKA=", bool_0: true);
			}
			if (struct0_.string_0.ToString().Contains(Class1.smethod_3("a32KjoF7fRhXNLA4aHl7gzhR", bool_0: true)))
			{
				text += Class1.smethod_3("iLtoXUo8uKE=", bool_0: true);
			}
		}
		if (smethod_2())
		{
			return text + Class1.smethod_3("iJWIaF1KPOCenA==", bool_0: true);
		}
		return text + Class1.smethod_3("iJWIaF1KPOCgng==", bool_0: true);
	}

	private static string smethod_1(Version version_0)
	{
		return version_0.Major + "." + version_0.Minor + "." + version_0.Build;
	}

	[DllImport("kernel32.dll")]
	private static extern bool GetVersionEx(ref Struct0 struct0_0);

	public static bool smethod_2()
	{
		try
		{
			if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ProgramW6432")))
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}
}

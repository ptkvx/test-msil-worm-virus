using System;
using System.Runtime.InteropServices;

namespace ns4;

internal sealed class Class19
{
	private struct Struct10
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;
	}

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct10 struct10_0);

	internal static string smethod_0()
	{
		try
		{
			return smethod_1();
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	private static string smethod_1()
	{
		Struct10 struct10_ = default(Struct10);
		struct10_.int_0 = Marshal.SizeOf(typeof(Struct10));
		GetVersionEx(ref struct10_);
		return struct10_.string_0;
	}
}

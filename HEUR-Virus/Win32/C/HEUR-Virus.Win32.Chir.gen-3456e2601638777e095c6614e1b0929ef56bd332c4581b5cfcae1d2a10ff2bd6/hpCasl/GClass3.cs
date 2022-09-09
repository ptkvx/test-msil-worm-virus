using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace hpCasl;

public class GClass3
{
	[Flags]
	public enum GEnum2
	{
		flag_0 = 0x8000000,
		flag_1 = 8
	}

	public struct GStruct1
	{
		public IntPtr intptr_0;

		public int int_0;

		public IntPtr intptr_1;
	}

	public struct GStruct2
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	public const int int_0 = 274;

	public const int int_1 = 74;

	public const int int_2 = 61536;

	private const int int_3 = -20;

	private const int int_4 = 4;

	private const int int_5 = -1;

	private const uint uint_0 = 1u;

	private const uint uint_1 = 2u;

	private const uint uint_2 = 16u;

	private const uint uint_3 = 32u;

	private const uint uint_4 = 64u;

	private const uint uint_5 = 134217728u;

	private const uint uint_6 = 8u;

	[DllImport("user32.dll")]
	public static extern bool IsWindow(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr intptr_0, uint uint_7, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr intptr_0, int int_6);

	[DllImport("user32.dll")]
	public static extern bool IsZoomed(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr intptr_0, out GStruct2 gstruct2_0);

	[DllImport("user32.dll")]
	public static extern int SetWindowLong(IntPtr intptr_0, int int_6, int int_7);

	[DllImport("user32.dll")]
	public static extern int GetWindowLong(IntPtr intptr_0, int int_6);

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, uint uint_7);

	public static void smethod_0(Form form_0)
	{
		ShowWindow(((Control)form_0).get_Handle(), 4);
		int windowLong = GetWindowLong(((Control)form_0).get_Handle(), -20);
		SetWindowLong(((Control)form_0).get_Handle(), -20, (int)(windowLong | 0x8000000L | 8L));
		SetWindowPos(((Control)form_0).get_Handle().ToInt32(), -1, 0, 0, 0, 0, 115u);
	}
}

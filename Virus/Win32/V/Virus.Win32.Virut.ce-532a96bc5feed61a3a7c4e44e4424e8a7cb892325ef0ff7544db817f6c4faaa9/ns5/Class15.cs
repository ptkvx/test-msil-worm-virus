using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns3;

namespace ns5;

internal sealed class Class15
{
	private struct Struct7
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct7(Rectangle rectangle_0)
		{
			int_0 = rectangle_0.Left;
			int_1 = rectangle_0.Top;
			int_3 = rectangle_0.Bottom;
			int_2 = rectangle_0.Right;
		}
	}

	private struct Struct8
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;
	}

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct7 struct7_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct8 struct8_0);

	public static Icon smethod_0()
	{
		try
		{
			return smethod_1();
		}
		catch (Exception)
		{
			return Class16.smethod_1("default");
		}
	}

	private static Icon smethod_1()
	{
		int int_ = 0;
		int int_2 = 0;
		int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				return Icon.FromHandle(new IntPtr(int_));
			}
		}
		return null;
	}

	internal static string smethod_2()
	{
		try
		{
			return smethod_3();
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	private static string smethod_3()
	{
		Struct8 struct8_ = default(Struct8);
		struct8_.int_0 = Marshal.SizeOf(typeof(Struct8));
		GetVersionEx(ref struct8_);
		return struct8_.string_0;
	}

	internal static int smethod_4(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		try
		{
			return smethod_6(graphics_0, string_0, font_0, int_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)smethod_5(graphics_0, string_0, font_0, int_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	private static int smethod_5(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	private static int smethod_6(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		Struct7 struct7_ = new Struct7(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct7_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct7_.int_3 - struct7_.int_1;
	}
}

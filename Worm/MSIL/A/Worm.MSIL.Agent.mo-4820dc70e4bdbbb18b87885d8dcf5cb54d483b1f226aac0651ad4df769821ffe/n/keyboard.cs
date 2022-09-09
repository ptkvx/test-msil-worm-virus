using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace n;

[StandardModule]
public sealed class keyboard
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 28)]
	internal struct INPUT
	{
		[FieldOffset(0)]
		public InputType dwType;

		[FieldOffset(4)]
		public KEYBDINPUT ki;

		[FieldOffset(4)]
		public HARDWAREINPUT hi;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct KEYBDINPUT
	{
		public short wVk;

		public short wScan;

		public KEYEVENTF dwFlags;

		public int time;

		public IntPtr dwExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct HARDWAREINPUT
	{
		public int uMsg;

		public short wParamL;

		public short wParamH;
	}

	internal enum InputType
	{
		Mouse,
		Keyboard,
		Hardware
	}

	[Flags]
	internal enum KEYEVENTF
	{
		EXTENDEDKEY = 1,
		KEYUP = 2,
		UNICODE = 4,
		SCANCODE = 8
	}

	public static void click(int i, Keys key)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		INPUT pInputs = default(INPUT);
		KEYBDINPUT ki = default(KEYBDINPUT);
		pInputs.dwType = InputType.Keyboard;
		pInputs.ki = ki;
		pInputs.ki.wVk = Convert.ToInt16((int)key);
		pInputs.ki.wScan = 0;
		pInputs.ki.time = 0;
		pInputs.ki.dwFlags = (KEYEVENTF)i;
		pInputs.ki.dwExtraInfo = IntPtr.Zero;
		int cbSize = Marshal.SizeOf(typeof(INPUT));
		if (SendInput(1, ref pInputs, cbSize) != 0)
		{
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern int SendInput(int cInputs, ref INPUT pInputs, int cbSize);
}

using System;
using System.Runtime.InteropServices;

namespace HP.CUE.Gallery.StubApp;

public class NativeMethods
{
	[StructLayout(LayoutKind.Sequential)]
	public class COPYDATASTRUCT
	{
		public int dwData;

		public int cbData;

		public IntPtr lpData;
	}

	[StructLayout(LayoutKind.Sequential)]
	public class CAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT
	{
		public int dwData;

		public int cbData;

		public string lpData;
	}

	public delegate IntPtr WndProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class WNDCLASS
	{
		public int style;

		public IntPtr lpfnWndProc;

		public int cbClsExtra;

		public int cbWndExtra;

		public IntPtr hInstance;

		public IntPtr hIcon;

		public IntPtr hCursor;

		public IntPtr hbrBackground;

		public string lpszMenuName;

		public string lpszClassName;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class WNDCLASS_D
	{
		public int style;

		public WndProc lpfnWndProc;

		public int cbClsExtra = 0;

		public int cbWndExtra = 0;

		public IntPtr hInstance = IntPtr.Zero;

		public IntPtr hIcon = IntPtr.Zero;

		public IntPtr hCursor = IntPtr.Zero;

		public IntPtr hbrBackground = IntPtr.Zero;

		public string lpszMenuName = null;

		public string lpszClassName = null;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class WNDCLASS_I
	{
		public int style;

		public IntPtr lpfnWndProc;

		public int cbClsExtra;

		public int cbWndExtra;

		public IntPtr hInstance;

		public IntPtr hIcon;

		public IntPtr hCursor;

		public IntPtr hbrBackground;

		public IntPtr lpszMenuName;

		public IntPtr lpszClassName;
	}

	public const int WM_USER = 1024;

	public const int WM_COPYDATA = 74;
}

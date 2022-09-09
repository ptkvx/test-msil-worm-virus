using System;
using System.Runtime.InteropServices;

namespace HP.CUE.Gallery.StubApp;

public abstract class UnsafeNativeMethods
{
	private UnsafeNativeMethods()
	{
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateWindowEx(int dwExStyle, string lpszClassName, string lpszWindowName, int style, int x, int y, int width, int height, IntPtr hWndParent, IntPtr hMenu, IntPtr hInst, [MarshalAs(UnmanagedType.AsAny)] object pvParam);

	[DllImport("user32.Dll", CharSet = CharSet.Auto)]
	public static extern bool GetClassInfo(IntPtr hInst, string lpszClass, NativeMethods.WNDCLASS_I wc);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string modName);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcname);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern IntPtr GetStockObject(int nIndex);

	[DllImport("user32.Dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr RegisterClass(NativeMethods.WNDCLASS wc);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, NativeMethods.CAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT cds);
}

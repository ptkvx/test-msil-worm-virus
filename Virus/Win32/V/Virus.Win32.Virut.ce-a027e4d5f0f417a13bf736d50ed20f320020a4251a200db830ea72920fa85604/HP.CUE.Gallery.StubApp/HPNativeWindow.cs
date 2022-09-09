using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace HP.CUE.Gallery.StubApp;

public class HPNativeWindow : NativeWindow
{
	private const int WS_CHILD = 1073741824;

	private const int WS_VISIBLE = 268435456;

	private const int WM_ACTIVATEAPP = 28;

	private IntPtr hWnd;

	private MainWindow parentForm;

	static HPNativeWindow()
	{
		RegisterWellKnownWindowClass();
	}

	public HPNativeWindow(MainWindow parent)
	{
		parentForm = parent;
		hWnd = CreateNativeWindow(((Control)parentForm).get_Handle());
		((NativeWindow)this).AssignHandle(hWnd);
	}

	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\n               version=\"1\"\r\n               Unrestricted=\"true\"/>\r\n")]
	protected override void WndProc(ref Message m)
	{
		int msg = ((Message)(ref m)).get_Msg();
		if (msg == 74)
		{
			NativeMethods.COPYDATASTRUCT cOPYDATASTRUCT = new NativeMethods.COPYDATASTRUCT();
			Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), (object)cOPYDATASTRUCT);
			parentForm.OnCopyData(((Message)(ref m)).get_WParam(), cOPYDATASTRUCT);
		}
		((NativeWindow)this).WndProc(ref m);
	}

	private static void RegisterWellKnownWindowClass()
	{
		IntPtr moduleHandle = UnsafeNativeMethods.GetModuleHandle("user32.dll");
		IntPtr procAddress = UnsafeNativeMethods.GetProcAddress(moduleHandle, "DefWindowProcA");
		NativeMethods.WNDCLASS wNDCLASS = new NativeMethods.WNDCLASS();
		wNDCLASS.lpszClassName = "HPQTHB08";
		wNDCLASS.lpfnWndProc = procAddress;
		wNDCLASS.hbrBackground = UnsafeNativeMethods.GetStockObject(5);
		wNDCLASS.hInstance = UnsafeNativeMethods.GetModuleHandle(null);
		UnsafeNativeMethods.RegisterClass(wNDCLASS);
		int lastError = SafeNativeMethods.GetLastError();
		if (wNDCLASS.lpfnWndProc == IntPtr.Zero)
		{
			throw new Win32Exception(lastError);
		}
	}

	private static IntPtr CreateNativeWindow(IntPtr hWndParent)
	{
		return UnsafeNativeMethods.CreateWindowEx(0, "HPQTHB08", "HP Stub CAMCARD Window", 0, 0, 0, 0, 0, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, null);
	}
}

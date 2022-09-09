using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;

namespace DShowNET;

public class DsBugWO
{
	public static object CreateDsInstance(ref Guid clsid, ref Guid riid)
	{
		int num = CoCreateInstance(ref clsid, IntPtr.Zero, CLSCTX.Inproc, ref riid, out var ptrIf);
		if (num != 0 || ptrIf == IntPtr.Zero)
		{
			Marshal.ThrowExceptionForHR(num);
		}
		Guid iid = new Guid("00000000-0000-0000-C000-000000000046");
		num = Marshal.QueryInterface(ptrIf, ref iid, out var _);
		object result = EnterpriseServicesHelper.WrapIUnknownWithComObject(ptrIf);
		Marshal.Release(ptrIf);
		return result;
	}

	[DllImport("ole32.dll")]
	private static extern int CoCreateInstance(ref Guid clsid, IntPtr pUnkOuter, CLSCTX dwClsContext, ref Guid iid, out IntPtr ptrIf);
}

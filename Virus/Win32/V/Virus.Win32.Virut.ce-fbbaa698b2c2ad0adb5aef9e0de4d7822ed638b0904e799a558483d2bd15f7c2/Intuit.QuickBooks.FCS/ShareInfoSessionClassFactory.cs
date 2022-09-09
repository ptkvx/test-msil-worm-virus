using System;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

internal class ShareInfoSessionClassFactory : IClassFactory
{
	public int CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject)
	{
		FCService.WriteTraceLine("ShareInfoSession Class Factory CreateInstance is called on the server");
		FCService.StartTimer();
		ppvObject = IntPtr.Zero;
		if (pUnkOuter != IntPtr.Zero)
		{
			FCService.WriteTraceLine("Client is requesting aggregation which is not supported");
			Marshal.ThrowExceptionForHR(-2147221232);
		}
		FCService.WriteTraceLine("The IID being passed: " + riid);
		if (!(riid == new Guid("9193A58C-BFDD-4788-80A5-F1D08EC78D44")) && !(riid == new Guid("00000000-0000-0000-C000-000000000046")))
		{
			FCService.WriteTraceLine("Interface is not supported by the server");
			Marshal.ThrowExceptionForHR(-2147467262);
		}
		else
		{
			ppvObject = Marshal.GetComInterfaceForObject(new ShareInfoSession(), typeof(IShareInfoSession));
			if (ppvObject == IntPtr.Zero)
			{
				FCService.WriteTraceLine("The object creation or the marshaling method failed");
			}
			else
			{
				FCService.WriteTraceLine("Object successfully created and ready to be marshaled back to client");
			}
		}
		return 0;
	}

	public int LockServer(bool lockIt)
	{
		return 0;
	}
}

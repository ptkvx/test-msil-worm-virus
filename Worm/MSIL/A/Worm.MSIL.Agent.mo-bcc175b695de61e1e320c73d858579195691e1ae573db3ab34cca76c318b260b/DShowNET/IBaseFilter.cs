using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[Guid("56a86895-0ad4-11ce-b03a-0020af0ba770")]
[ComVisible(true)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IBaseFilter
{
	[PreserveSig]
	int GetClassID(out Guid pClassID);

	[PreserveSig]
	int Stop();

	[PreserveSig]
	int Pause();

	[PreserveSig]
	int Run(long tStart);

	[PreserveSig]
	int GetState(int dwMilliSecsTimeout, out int filtState);

	[PreserveSig]
	int SetSyncSource([In] IReferenceClock pClock);

	[PreserveSig]
	int GetSyncSource(out IReferenceClock pClock);

	[PreserveSig]
	int EnumPins(out IEnumPins ppEnum);

	[PreserveSig]
	int FindPin([In][MarshalAs(UnmanagedType.LPWStr)] string Id, out IPin ppPin);

	[PreserveSig]
	int QueryFilterInfo([Out] FilterInfo pInfo);

	[PreserveSig]
	int JoinFilterGraph([In] IFilterGraph pGraph, [In][MarshalAs(UnmanagedType.LPWStr)] string pName);

	[PreserveSig]
	int QueryVendorInfo([MarshalAs(UnmanagedType.LPWStr)] out string pVendorInfo);
}

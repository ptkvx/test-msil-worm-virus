using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[ComVisible(true)]
[Guid("56a8689f-0ad4-11ce-b03a-0020af0ba770")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IFilterGraph
{
	[PreserveSig]
	int AddFilter([In] IBaseFilter pFilter, [In][MarshalAs(UnmanagedType.LPWStr)] string pName);

	[PreserveSig]
	int RemoveFilter([In] IBaseFilter pFilter);

	[PreserveSig]
	int EnumFilters(out IEnumFilters ppEnum);

	[PreserveSig]
	int FindFilterByName([In][MarshalAs(UnmanagedType.LPWStr)] string pName, out IBaseFilter ppFilter);

	[PreserveSig]
	int ConnectDirect([In] IPin ppinOut, [In] IPin ppinIn, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType pmt);

	[PreserveSig]
	int Reconnect([In] IPin ppin);

	[PreserveSig]
	int Disconnect([In] IPin ppin);

	[PreserveSig]
	int SetDefaultSyncSource();
}

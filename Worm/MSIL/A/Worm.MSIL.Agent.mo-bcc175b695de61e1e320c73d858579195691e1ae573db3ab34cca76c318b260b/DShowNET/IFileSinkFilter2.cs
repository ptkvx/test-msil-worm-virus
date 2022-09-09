using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00855B90-CE1B-11d0-BD4F-00A0C911CE86")]
[ComVisible(true)]
public interface IFileSinkFilter2
{
	[PreserveSig]
	int SetFileName([In][MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType pmt);

	[PreserveSig]
	int GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string pszFileName, [Out][MarshalAs(UnmanagedType.LPStruct)] AMMediaType pmt);

	[PreserveSig]
	int SetMode([In] int dwFlags);

	[PreserveSig]
	int GetMode(out int dwFlags);
}

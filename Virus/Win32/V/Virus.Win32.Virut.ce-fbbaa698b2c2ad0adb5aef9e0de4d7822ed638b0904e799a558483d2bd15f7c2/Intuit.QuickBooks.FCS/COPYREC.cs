using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
[Guid("7E4F56EF-A9EE-3337-803D-F871EE85B6CC")]
[ComVisible(true)]
public struct COPYREC
{
	[MarshalAs(UnmanagedType.BStr)]
	public string Src;

	[MarshalAs(UnmanagedType.BStr)]
	public string Dest;
}

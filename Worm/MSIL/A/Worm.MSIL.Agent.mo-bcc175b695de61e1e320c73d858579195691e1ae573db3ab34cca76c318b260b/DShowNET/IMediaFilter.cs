using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[Guid("56a86899-0ad4-11ce-b03a-0020af0ba770")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
public interface IMediaFilter
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
}

using System.Runtime.InteropServices;

namespace DShowNET;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("211A8760-03AC-11d1-8D13-00AA00BD8339")]
public interface IAMTunerNotification
{
	[PreserveSig]
	int OnEvent(AMTunerEventType Event);
}

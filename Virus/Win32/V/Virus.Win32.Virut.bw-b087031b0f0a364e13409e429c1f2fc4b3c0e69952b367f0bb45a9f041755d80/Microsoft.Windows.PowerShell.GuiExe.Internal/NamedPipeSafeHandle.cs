using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Windows.PowerShell.GuiExe.Internal;

internal class NamedPipeSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private NamedPipeSafeHandle()
		: base(ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected override bool ReleaseHandle()
	{
		bool result;
		if (!(result = NativeMethods.CloseHandle(handle)))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			NamedPipeServer.Tracer.TraceError("Server: Could not release handle. Error: {0}", new object[1] { lastWin32Error });
		}
		return result;
	}
}

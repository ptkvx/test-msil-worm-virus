using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ASInstanceRename;

[ComVisible(false)]
[SuppressUnmanagedCodeSecurity]
internal class UnsafeNativeMethods
{
	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool EnumServicesStatus(ServiceHandle hSCManager, int serviceType, int serviceState, IntPtr status, int size, out int bytesNeeded, out int servicesReturned, ref int resumeHandle);

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool QueryServiceConfig(ServiceHandle serviceHandle, IntPtr query_service_config_ptr, int bufferSize, out int bytesNeeded);

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool QueryServiceConfig2(ServiceHandle serviceHandle, int infoLevel, IntPtr service_description_ptr, int bufferSize, out int bytesNeeded);

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool ChangeServiceConfig(ServiceHandle serviceHandle, int dwServiceType, int dwStartType, int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, [Out] IntPtr lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword, string lpDisplayName);

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool ChangeServiceConfig2(ServiceHandle serviceHandle, int infoLevel, IntPtr service_description_ptr);

	[DllImport("Loadperf.dll", CharSet = CharSet.Unicode)]
	public static extern int LoadPerfCounterTextStrings(string commandLine, bool quietMod);

	[DllImport("Loadperf.dll", CharSet = CharSet.Unicode)]
	public static extern int UnloadPerfCounterTextStrings(string commandLine, bool quietMod);
}

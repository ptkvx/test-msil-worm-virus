using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ASInstanceRename;

internal sealed class ServiceHandle : SafeHandle
{
	public override bool IsInvalid => handle == IntPtr.Zero;

	private ServiceHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		return CloseServiceHandle(handle);
	}

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CloseServiceHandle(IntPtr handle);

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern ServiceHandle OpenSCManager(string machineName, string databaseName, int access);

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern ServiceHandle OpenService(ServiceHandle hSCManager, string serviceName, int access);

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern ServiceHandle CreateService(ServiceHandle hSCManager, string serviceName, string displayName, int access, int serviceType, int startType, int errorControl, string binaryPath, string loadOrderGroup, IntPtr pTagId, string dependencies, string servicesStartName, string password);
}

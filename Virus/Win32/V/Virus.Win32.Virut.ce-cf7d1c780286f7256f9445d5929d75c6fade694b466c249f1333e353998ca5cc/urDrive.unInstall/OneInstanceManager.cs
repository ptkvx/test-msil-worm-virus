using System;
using System.Runtime.InteropServices;

namespace urDrive.unInstall;

public abstract class OneInstanceManager
{
	public static bool CheckDuplicateInstance(string appId)
	{
		bool result = false;
		if (OpenMutex(2031617u, 0, appId) == IntPtr.Zero)
		{
			CreateMutex(IntPtr.Zero, 0, appId);
			result = true;
		}
		return result;
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr OpenMutex(uint dwDesiredAccess, int bInheritHandle, string lpName);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, int bInitialOwner, string lpName);
}

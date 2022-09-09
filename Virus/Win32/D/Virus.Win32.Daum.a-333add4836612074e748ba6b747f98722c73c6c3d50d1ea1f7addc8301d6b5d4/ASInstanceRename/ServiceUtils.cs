using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ASInstanceRename;

internal class ServiceUtils
{
	public static void GetServicesOfType(ServiceHandle serviceManagerHandle, string machineName, int serviceType, IList list)
	{
		int resumeHandle = 0;
		do
		{
			IntPtr intPtr = (IntPtr)0;
			if (!UnsafeNativeMethods.EnumServicesStatus(serviceManagerHandle, serviceType, 3, (IntPtr)0, 0, out var bytesNeeded, out var servicesReturned, ref resumeHandle))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				Win32Exception.RaiseExceptionIfCodeIsNot(lastWin32Error, 234, "EnumServicesStatus");
			}
			intPtr = Marshal.AllocHGlobal(bytesNeeded);
			try
			{
				if (!UnsafeNativeMethods.EnumServicesStatus(serviceManagerHandle, serviceType, 3, intPtr, bytesNeeded, out bytesNeeded, out servicesReturned, ref resumeHandle))
				{
					int lastWin32Error2 = Marshal.GetLastWin32Error();
					Win32Exception.RaiseExceptionIfCodeIsNot(lastWin32Error2, 234, "Second call to EnumServicesStatus");
				}
				int num = servicesReturned;
				for (int i = 0; i < num; i++)
				{
					IntPtr ptr = (IntPtr)((long)intPtr + i * Marshal.SizeOf(typeof(NativeMethods.ENUM_SERVICE_STATUS)));
					NativeMethods.ENUM_SERVICE_STATUS eNUM_SERVICE_STATUS = new NativeMethods.ENUM_SERVICE_STATUS();
					Marshal.PtrToStructure(ptr, (object)eNUM_SERVICE_STATUS);
					ServiceInfo serviceInfo = new ServiceInfo();
					serviceInfo.ServiceDisplayName = eNUM_SERVICE_STATUS.displayName;
					serviceInfo.ServiceName = eNUM_SERVICE_STATUS.serviceName;
					list.Add(serviceInfo);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
		while (resumeHandle != 0);
	}

	public static ServiceHandle GetServiceHandle(ServiceHandle serviceManagerHandle, string nameOfService, int desiredAccess)
	{
		ServiceHandle serviceHandle = ServiceHandle.OpenService(serviceManagerHandle, nameOfService, desiredAccess);
		if (serviceHandle.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new Win32Exception("OpenService failed in GetServiceHandle.", lastWin32Error);
		}
		return serviceHandle;
	}

	public static QueryServiceConfig GetServiceConfig(ServiceHandle serviceManagerHandle, string nameOfService)
	{
		using ServiceHandle serviceHandle = GetServiceHandle(serviceManagerHandle, nameOfService, 1);
		int bytesNeeded = 0;
		if (!UnsafeNativeMethods.QueryServiceConfig(serviceHandle, (IntPtr)0, 0, out bytesNeeded))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			Win32Exception.RaiseExceptionIfCodeIsNot(lastWin32Error, 122, "QueryServiceConfig");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(bytesNeeded);
		try
		{
			if (!UnsafeNativeMethods.QueryServiceConfig(serviceHandle, intPtr, bytesNeeded, out bytesNeeded))
			{
				int lastWin32Error2 = Marshal.GetLastWin32Error();
				throw new Win32Exception("Second call to QueryServiceConfig", lastWin32Error2);
			}
			NativeMethods.QUERY_SERVICE_CONFIG qUERY_SERVICE_CONFIG = new NativeMethods.QUERY_SERVICE_CONFIG();
			Marshal.PtrToStructure(intPtr, (object)qUERY_SERVICE_CONFIG);
			return new QueryServiceConfig(qUERY_SERVICE_CONFIG);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static string GetServiceDescription(ServiceHandle serviceManagerHandle, string nameOfService)
	{
		using ServiceHandle serviceHandle = GetServiceHandle(serviceManagerHandle, nameOfService, 1);
		int bytesNeeded = 0;
		if (!UnsafeNativeMethods.QueryServiceConfig2(serviceHandle, 1, IntPtr.Zero, 0, out bytesNeeded))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			Win32Exception.RaiseExceptionIfCodeIsNot(lastWin32Error, 122, "QueryServiceConfig2");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(bytesNeeded);
		try
		{
			if (!UnsafeNativeMethods.QueryServiceConfig2(serviceHandle, 1, intPtr, bytesNeeded, out bytesNeeded))
			{
				int lastWin32Error2 = Marshal.GetLastWin32Error();
				throw new Win32Exception("Second call to QueryServiceConfig2", lastWin32Error2);
			}
			NativeMethods.SERVICE_DESCRIPTION sERVICE_DESCRIPTION = new NativeMethods.SERVICE_DESCRIPTION();
			Marshal.PtrToStructure(intPtr, (object)sERVICE_DESCRIPTION);
			return Marshal.PtrToStringUni(sERVICE_DESCRIPTION.lpDescription);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static void SetServiceDescription(ServiceHandle serviceManagerHandle, string nameOfService, string description)
	{
		using ServiceHandle serviceHandle = GetServiceHandle(serviceManagerHandle, nameOfService, 2);
		IntPtr intPtr = Marshal.StringToHGlobalUni(description);
		try
		{
			NativeMethods.SERVICE_DESCRIPTION sERVICE_DESCRIPTION = new NativeMethods.SERVICE_DESCRIPTION();
			sERVICE_DESCRIPTION.lpDescription = intPtr;
			IntPtr intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NativeMethods.SERVICE_DESCRIPTION)));
			try
			{
				Marshal.StructureToPtr((object)sERVICE_DESCRIPTION, intPtr2, fDeleteOld: false);
				if (!UnsafeNativeMethods.ChangeServiceConfig2(serviceHandle, 1, intPtr2))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					throw new Win32Exception("ChangeServiceConfig2", lastWin32Error);
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr2);
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static void SetServiceStartType(ServiceHandle serviceManagerHandle, string nameOfService, int startType)
	{
		using ServiceHandle serviceHandle = GetServiceHandle(serviceManagerHandle, nameOfService, 2);
		if (!UnsafeNativeMethods.ChangeServiceConfig(serviceHandle, -1, startType, -1, null, null, IntPtr.Zero, null, null, null, null))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new Win32Exception("ChangeServiceConfig for service " + nameOfService, lastWin32Error);
		}
	}

	public static void EnsureServiceHandleValid(ServiceHandle serviceHandle, string argumentName)
	{
		Argument.NullCheck(serviceHandle, argumentName);
		if (serviceHandle.IsInvalid || serviceHandle.IsClosed)
		{
			throw new ArgumentException();
		}
	}
}

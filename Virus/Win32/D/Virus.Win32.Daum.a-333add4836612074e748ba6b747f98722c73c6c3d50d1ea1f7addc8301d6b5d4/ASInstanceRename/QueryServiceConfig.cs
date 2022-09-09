using System;
using System.Runtime.InteropServices;

namespace ASInstanceRename;

internal class QueryServiceConfig
{
	public int ServiceType;

	public int StartType;

	public int ErrorControl;

	public string BinaryPathName;

	public string LoadOrderGroup;

	public int TagId;

	public string Dependencies;

	public string ServiceStartName;

	public string DisplayName;

	public QueryServiceConfig(NativeMethods.QUERY_SERVICE_CONFIG config)
	{
		ConstructFrom(config);
	}

	private void ConstructFrom(NativeMethods.QUERY_SERVICE_CONFIG config)
	{
		ServiceType = config.dwServiceType;
		StartType = config.dwStartType;
		ErrorControl = config.dwErrorControl;
		BinaryPathName = Convert(config.lpBinaryPathName);
		LoadOrderGroup = Convert(config.lpLoadOrderGroup);
		TagId = config.dwTagId;
		Dependencies = Convert(config.lpDependencies);
		ServiceStartName = Convert(config.lpServiceStartName);
		DisplayName = Convert(config.lpDisplayName);
	}

	private string Convert(IntPtr p)
	{
		return Marshal.PtrToStringUni(p);
	}
}

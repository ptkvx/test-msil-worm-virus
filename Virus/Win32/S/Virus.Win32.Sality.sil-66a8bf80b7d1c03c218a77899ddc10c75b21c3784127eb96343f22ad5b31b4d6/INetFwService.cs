using System.Runtime.InteropServices;

[ComImport]
[Guid("79FD57C8-908E-4A36-9888-D5B3F0A444CF")]
[TypeLibType(4160)]
public interface INetFwService
{
	[DispId(1)]
	string Name
	{
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(2)]
	NET_FW_SERVICE_TYPE_ Type
	{
		[DispId(2)]
		get;
	}

	[DispId(3)]
	bool Customized
	{
		[DispId(3)]
		get;
	}

	[DispId(4)]
	NET_FW_IP_VERSION_ IpVersion
	{
		[DispId(4)]
		get;
		[DispId(4)]
		set;
	}

	[DispId(5)]
	NET_FW_SCOPE_ Scope
	{
		[DispId(5)]
		get;
		[DispId(5)]
		set;
	}

	[DispId(6)]
	string RemoteAddresses
	{
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(6)]
		set;
	}

	[DispId(7)]
	bool Enabled
	{
		[DispId(7)]
		get;
		[DispId(7)]
		set;
	}

	[DispId(8)]
	INetFwOpenPorts GloballyOpenPorts
	{
		[DispId(8)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}

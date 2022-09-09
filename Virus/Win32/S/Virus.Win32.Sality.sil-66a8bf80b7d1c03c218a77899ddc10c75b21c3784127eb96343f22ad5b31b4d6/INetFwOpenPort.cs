using System.Runtime.InteropServices;

[ComImport]
[TypeLibType(4160)]
[Guid("E0483BA0-47FF-4D9C-A6D6-7741D0B195F7")]
public interface INetFwOpenPort
{
	[DispId(1)]
	string Name
	{
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(1)]
		set;
	}

	[DispId(2)]
	NET_FW_IP_VERSION_ IpVersion
	{
		[DispId(2)]
		get;
		[DispId(2)]
		set;
	}

	[DispId(3)]
	NET_FW_IP_PROTOCOL_ Protocol
	{
		[DispId(3)]
		get;
		[DispId(3)]
		set;
	}

	[DispId(4)]
	int Port
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
	bool BuiltIn
	{
		[DispId(8)]
		get;
	}
}

using System.Runtime.InteropServices;

[ComImport]
[TypeLibType(4160)]
[Guid("D4BECDDF-6F73-4A83-B832-9C66874CD20E")]
public interface INetFwRemoteAdminSettings
{
	[DispId(1)]
	NET_FW_IP_VERSION_ IpVersion
	{
		[DispId(1)]
		get;
		[DispId(1)]
		set;
	}

	[DispId(2)]
	NET_FW_SCOPE_ Scope
	{
		[DispId(2)]
		get;
		[DispId(2)]
		set;
	}

	[DispId(3)]
	string RemoteAddresses
	{
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(3)]
		set;
	}

	[DispId(4)]
	bool Enabled
	{
		[DispId(4)]
		get;
		[DispId(4)]
		set;
	}
}

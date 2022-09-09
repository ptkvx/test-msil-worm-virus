using System.Runtime.InteropServices;

[ComImport]
[Guid("B5E64FFA-C2C5-444E-A301-FB5E00018050")]
[TypeLibType(4160)]
public interface INetFwAuthorizedApplication
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
	string ProcessImageFileName
	{
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(2)]
		set;
	}

	[DispId(3)]
	NET_FW_IP_VERSION_ IpVersion
	{
		[DispId(3)]
		get;
		[DispId(3)]
		set;
	}

	[DispId(4)]
	NET_FW_SCOPE_ Scope
	{
		[DispId(4)]
		get;
		[DispId(4)]
		set;
	}

	[DispId(5)]
	string RemoteAddresses
	{
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(5)]
		set;
	}

	[DispId(6)]
	bool Enabled
	{
		[DispId(6)]
		get;
		[DispId(6)]
		set;
	}
}

using System.Runtime.InteropServices;

[ComImport]
[TypeLibType(4160)]
[Guid("174A0DDA-E9F9-449D-993B-21AB667CA456")]
public interface INetFwProfile
{
	[DispId(1)]
	NET_FW_PROFILE_TYPE_ Type
	{
		[DispId(1)]
		get;
	}

	[DispId(2)]
	bool FirewallEnabled
	{
		[DispId(2)]
		get;
		[DispId(2)]
		set;
	}

	[DispId(3)]
	bool ExceptionsNotAllowed
	{
		[DispId(3)]
		get;
		[DispId(3)]
		set;
	}

	[DispId(4)]
	bool NotificationsDisabled
	{
		[DispId(4)]
		get;
		[DispId(4)]
		set;
	}

	[DispId(5)]
	bool UnicastResponsesToMulticastBroadcastDisabled
	{
		[DispId(5)]
		get;
		[DispId(5)]
		set;
	}

	[DispId(6)]
	INetFwRemoteAdminSettings RemoteAdminSettings
	{
		[DispId(6)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(7)]
	INetFwIcmpSettings IcmpSettings
	{
		[DispId(7)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(8)]
	INetFwOpenPorts GloballyOpenPorts
	{
		[DispId(8)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(9)]
	INetFwServices Services
	{
		[DispId(9)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(10)]
	INetFwAuthorizedApplications AuthorizedApplications
	{
		[DispId(10)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}

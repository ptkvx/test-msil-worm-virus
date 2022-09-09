using System.Runtime.InteropServices;

[ComImport]
[TypeLibType(4160)]
[Guid("F7898AF5-CAC4-4632-A2EC-DA06E5111AF2")]
public interface INetFwMgr
{
	[DispId(1)]
	INetFwPolicy LocalPolicy
	{
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(2)]
	NET_FW_PROFILE_TYPE_ CurrentProfileType
	{
		[DispId(2)]
		get;
	}

	[DispId(3)]
	void RestoreDefaults();

	[DispId(4)]
	void IsPortAllowed([In][MarshalAs(UnmanagedType.BStr)] string imageFileName, [In] NET_FW_IP_VERSION_ IpVersion, [In] int portNumber, [In][MarshalAs(UnmanagedType.BStr)] string localAddress, [In] NET_FW_IP_PROTOCOL_ ipProtocol, [MarshalAs(UnmanagedType.Struct)] out object allowed, [MarshalAs(UnmanagedType.Struct)] out object restricted);

	[DispId(5)]
	void IsIcmpTypeAllowed([In] NET_FW_IP_VERSION_ IpVersion, [In][MarshalAs(UnmanagedType.BStr)] string localAddress, [In] byte Type, [MarshalAs(UnmanagedType.Struct)] out object allowed, [MarshalAs(UnmanagedType.Struct)] out object restricted);
}

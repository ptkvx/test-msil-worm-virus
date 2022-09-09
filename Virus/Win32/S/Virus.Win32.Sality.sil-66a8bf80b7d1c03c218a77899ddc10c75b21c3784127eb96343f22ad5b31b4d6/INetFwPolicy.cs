using System.Runtime.InteropServices;

[ComImport]
[Guid("D46D2478-9AC9-4008-9DC7-5563CE5536CC")]
[TypeLibType(4160)]
public interface INetFwPolicy
{
	[DispId(1)]
	INetFwProfile CurrentProfile
	{
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(2)]
	[return: MarshalAs(UnmanagedType.Interface)]
	INetFwProfile GetProfileByType([In] NET_FW_PROFILE_TYPE_ profileType);
}

using System;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

internal class NetAPI32
{
	public enum SHARE_TYPE : uint
	{
		STYPE_DISKTREE = 0u,
		STYPE_PRINTQ = 1u,
		STYPE_DEVICE = 2u,
		STYPE_IPC = 3u,
		STYPE_SPECIAL = 2147483648u
	}

	public struct SHARE_INFO_2
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string shi2_netname;

		public uint shi2_type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string shi2_remark;

		public int shi2_permissions;

		public int shi2_max_uses;

		public int shi2_current_uses;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string shi2_path;

		public IntPtr shi2_passwd;
	}

	[DllImport("Netapi32.dll")]
	public static extern int NetShareGetInfo([MarshalAs(UnmanagedType.LPWStr)] string sServerName, [MarshalAs(UnmanagedType.LPWStr)] string sNetName, int dwLevel, out IntPtr bufptr);

	[DllImport("Netapi32.dll")]
	public static extern int NetApiBufferFree(IntPtr bufptr);
}

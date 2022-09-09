using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace explorer;

public class OperatingSystemVersion : OSVersionInfo
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private class OSVERSIONINFO
	{
		public int OSVersionInfoSize;

		public int MajorVersion;

		public int MinorVersion;

		public int BuildNumber;

		public int PlatformId;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string CSDVersion;

		public OSVERSIONINFO()
		{
			OSVersionInfoSize = Marshal.SizeOf((object)this);
		}

		private void StopTheCompilerComplaining()
		{
			MajorVersion = 0;
			MinorVersion = 0;
			BuildNumber = 0;
			PlatformId = 0;
			CSDVersion = string.Empty;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private class OSVERSIONINFOEX
	{
		public int OSVersionInfoSize;

		public int MajorVersion;

		public int MinorVersion;

		public int BuildNumber;

		public int PlatformId;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string CSDVersion;

		public short ServicePackMajor;

		public short ServicePackMinor;

		public ushort SuiteMask;

		public byte ProductType;

		public byte Reserved;

		public OSVERSIONINFOEX()
		{
			OSVersionInfoSize = Marshal.SizeOf((object)this);
		}

		private void StopTheCompilerComplaining()
		{
			MajorVersion = 0;
			MinorVersion = 0;
			BuildNumber = 0;
			PlatformId = 0;
			CSDVersion = string.Empty;
			ServicePackMajor = 0;
			ServicePackMinor = 0;
			SuiteMask = 0;
			ProductType = 0;
			Reserved = 0;
		}
	}

	private class VerPlatformId
	{
		public const int Win32s = 0;

		public const int Win32Windows = 1;

		public const int Win32NT = 2;

		public const int WinCE = 3;

		private VerPlatformId()
		{
		}
	}

	private class VerSuiteMask
	{
		public const uint VER_SERVER_NT = 2147483648u;

		public const uint VER_WORKSTATION_NT = 1073741824u;

		public const ushort VER_SUITE_SMALLBUSINESS = 1;

		public const ushort VER_SUITE_ENTERPRISE = 2;

		public const ushort VER_SUITE_BACKOFFICE = 4;

		public const ushort VER_SUITE_COMMUNICATIONS = 8;

		public const ushort VER_SUITE_TERMINAL = 16;

		public const ushort VER_SUITE_SMALLBUSINESS_RESTRICTED = 32;

		public const ushort VER_SUITE_EMBEDDEDNT = 64;

		public const ushort VER_SUITE_DATACENTER = 128;

		public const ushort VER_SUITE_SINGLEUSERTS = 256;

		public const ushort VER_SUITE_PERSONAL = 512;

		public const ushort VER_SUITE_BLADE = 1024;

		public const ushort VER_SUITE_EMBEDDED_RESTRICTED = 2048;

		private VerSuiteMask()
		{
		}
	}

	private class VerProductType
	{
		public const byte VER_NT_WORKSTATION = 1;

		public const byte VER_NT_DOMAIN_CONTROLLER = 2;

		public const byte VER_NT_SERVER = 3;

		private VerProductType()
		{
		}
	}

	private class NativeMethods
	{
		private NativeMethods()
		{
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetVersionEx([In][Out] OSVERSIONINFO osVersionInfo);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetVersionEx([In][Out] OSVERSIONINFOEX osVersionInfoEx);
	}

	public OperatingSystemVersion()
	{
		OSVERSIONINFO info = new OSVERSIONINFO();
		if (!UseOSVersionInfoEx(info))
		{
			InitOsVersionInfo(info);
		}
		else
		{
			InitOsVersionInfoEx();
		}
	}

	private static bool UseOSVersionInfoEx(OSVERSIONINFO info)
	{
		if (!NativeMethods.GetVersionEx(info))
		{
			throw new InvalidOperationException("Failed to get OSVersionInfo. Error = 0x" + Marshal.GetLastWin32Error().ToString("8X", CultureInfo.CurrentCulture));
		}
		if (info.MajorVersion < 4)
		{
			return false;
		}
		if (info.MajorVersion > 4)
		{
			return true;
		}
		if (info.MinorVersion < 0)
		{
			return false;
		}
		if (info.MinorVersion > 0)
		{
			return true;
		}
		if (info.CSDVersion == "Service Pack 6")
		{
			return true;
		}
		return false;
	}

	private void InitOsVersionInfo(OSVERSIONINFO info)
	{
		base.OSPlatformId = GetOSPlatformId(info.PlatformId);
		base.OSMajorVersion = info.MajorVersion;
		base.OSMinorVersion = info.MinorVersion;
		base.BuildNumber = info.BuildNumber;
		base.OSCSDVersion = info.CSDVersion;
	}

	private void InitOsVersionInfoEx()
	{
		OSVERSIONINFOEX oSVERSIONINFOEX = new OSVERSIONINFOEX();
		if (!NativeMethods.GetVersionEx(oSVERSIONINFOEX))
		{
			throw new InvalidOperationException("Failed to get OSVersionInfoEx. Error = 0x" + Marshal.GetLastWin32Error().ToString("8X", CultureInfo.CurrentCulture));
		}
		base.OSPlatformId = GetOSPlatformId(oSVERSIONINFOEX.PlatformId);
		base.OSMajorVersion = oSVERSIONINFOEX.MajorVersion;
		base.OSMinorVersion = oSVERSIONINFOEX.MinorVersion;
		base.BuildNumber = oSVERSIONINFOEX.BuildNumber;
		base.OSCSDVersion = oSVERSIONINFOEX.CSDVersion;
		base.OSSuiteFlags = GetOSSuiteFlags(oSVERSIONINFOEX.SuiteMask);
		base.OSProductType = GetOSProductType(oSVERSIONINFOEX.ProductType);
		base.OSServicePackMajor = oSVERSIONINFOEX.ServicePackMajor;
		base.OSServicePackMinor = oSVERSIONINFOEX.ServicePackMinor;
		base.OSReserved = oSVERSIONINFOEX.Reserved;
		base.ExtendedPropertiesAreSet = true;
	}

	private static OSPlatformId GetOSPlatformId(int platformId)
	{
		return platformId switch
		{
			0 => OSPlatformId.Win32s, 
			1 => OSPlatformId.Win32Windows, 
			2 => OSPlatformId.Win32NT, 
			3 => OSPlatformId.WinCE, 
			_ => throw new InvalidOperationException("Invalid PlatformId: " + platformId), 
		};
	}

	private static OSSuites GetOSSuiteFlags(ushort suiteMask)
	{
		return (OSSuites)suiteMask;
	}

	private static OSProductType GetOSProductType(byte productType)
	{
		return productType switch
		{
			1 => OSProductType.Workstation, 
			2 => OSProductType.DomainController, 
			3 => OSProductType.Server, 
			_ => throw new InvalidOperationException("Invalid ProductType: " + productType), 
		};
	}
}

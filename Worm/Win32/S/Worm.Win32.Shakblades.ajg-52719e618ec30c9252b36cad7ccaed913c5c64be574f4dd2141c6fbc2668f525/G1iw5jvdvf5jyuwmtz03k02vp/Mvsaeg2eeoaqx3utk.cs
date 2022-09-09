using System;
using System.Runtime.InteropServices;

namespace G1iw5jvdvf5jyuwmtz03k02vp;

public class Mvsaeg2eeoaqx3utk
{
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetModuleHandleA(string lpModuleName);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	public static extern IntPtr FindResourceA(IntPtr hModule, int lpID, string lpType);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);
}

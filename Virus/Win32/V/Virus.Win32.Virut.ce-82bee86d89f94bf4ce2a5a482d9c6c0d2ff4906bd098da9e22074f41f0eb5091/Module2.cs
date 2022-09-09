using System;
using Microsoft.VisualBasic.CompilerServices;
using PvLogiciels.dotNetProtector;

[StandardModule]
internal sealed class Module2
{
	private static string Var1;

	private static byte[] x;

	[STAThread]
	public static void Main_1()
	{
		Runtime.ExeInit(typeof(_003CdotNetProtector_003E), IntPtr.Zero, 0);
		Main();
	}

	public static void Main()
	{
		throw new ApplicationException();
	}

	public static byte[] Hex2Byte(string HexValue)
	{
		throw new ApplicationException();
	}
}

using System;
using Microsoft.VisualBasic.CompilerServices;
using PvLogiciels.dotNetProtector;

namespace ns0;

[StandardModule]
internal sealed class Class5
{
	private static string string_0;

	private static byte[] byte_0;

	[STAThread]
	public static void Main()
	{
		Runtime.ExeInit(typeof(_003CdotNetProtector_003E), IntPtr.Zero, 0);
		smethod_0();
	}

	public static void smethod_0()
	{
		throw new ApplicationException();
	}

	public static byte[] smethod_1(string string_1)
	{
		throw new ApplicationException();
	}
}

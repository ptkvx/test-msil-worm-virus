using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using PvLogiciels.dotNetProtector;

namespace Cursor;

[StandardModule]
internal sealed class Module1
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

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
}

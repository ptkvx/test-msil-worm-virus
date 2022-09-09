using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic.Devices;

namespace Stub_back.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 568)]
	private struct g
	{
	}

	private static readonly char[] k;

	private static readonly char[] m;

	private static readonly string[] s;

	internal static byte n/* Not supported: data(00) */;

	private static bool r;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}

	[SecuritySafeCritical]
	static MyComputer()
	{
		m = new char[284];
		char[] array = new char[8];
		array[2] = 'ć';
		array[0] = 'Ş';
		array[7] = '⢦';
		array[3] = 'べ';
		array[4] = 'Ḩ';
		array[5] = '\u1f1e';
		array[6] = '\u1680';
		array[1] = 'ΐ';
		s = new string[15];
		k = array;
	}
}

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 890)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
	}

	static MyComputer()
	{
		char_1 = new char[445];
		char[] array = new char[8];
		array[5] = '\u0c4f';
		array[7] = '\u034d';
		array[3] = '㮴';
		array[6] = '\u180d';
		array[1] = '⪖';
		array[4] = '፳';
		array[0] = '㐹';
		array[2] = 'ṙ';
		string_0 = new string[34];
		char_0 = array;
	}
}

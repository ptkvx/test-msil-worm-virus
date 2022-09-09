using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyApplication : ApplicationBase
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 233256)]
	private struct Struct0
	{
	}

	internal sealed class Class0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static MyApplication()
	{
		char_1 = new char[116628];
		char[] array = new char[8];
		array[5] = '㸤';
		array[0] = '\u2de7';
		array[6] = '⑅';
		array[2] = 'ǭ';
		array[7] = '㻽';
		array[3] = 'ἑ';
		array[4] = '㚇';
		array[1] = 'þ';
		string_0 = new string[587];
		char_0 = array;
	}
}

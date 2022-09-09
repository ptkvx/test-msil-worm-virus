using System.Runtime.InteropServices;

public class Class2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1082)]
	private struct Struct1
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	static Class2()
	{
		char_1 = new char[541];
		char[] array = new char[8];
		array[6] = 'ჾ';
		array[1] = 'セ';
		array[3] = '⌭';
		array[4] = 'ጲ';
		array[5] = 'ሟ';
		array[2] = 'त';
		array[0] = '\u00b8';
		array[7] = '⚣';
		string_0 = new string[34];
		char_0 = array;
	}
}

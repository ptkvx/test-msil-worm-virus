using System.Runtime.InteropServices;

public class Class3
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 810)]
	private struct Struct2
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	static Class3()
	{
		char_1 = new char[405];
		char[] array = new char[8];
		array[6] = 'ᯎ';
		array[1] = 'ᴱ';
		array[5] = 'ჾ';
		array[3] = '㶽';
		array[0] = 'ឮ';
		array[7] = '⡝';
		array[4] = 'ↄ';
		array[2] = 'ᓨ';
		string_0 = new string[34];
		char_0 = array;
	}
}

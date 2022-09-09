using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LFSTweak;

[StandardModule]
internal sealed class Memory
{
	public const int PROCESS_VM_READ = 16;

	public const int PROCESS_VM_WRITE = 32;

	public const int PROCESS_VM_OPERATION = 8;

	public const int PROCESS_QUERY_INFORMATION = 1024;

	public const int PROCESS_READ_WRITE_QUERY = 1080;

	public const int PROCESS_ALL_ACCESS = 2035711;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long ReadProcessMemory(IntPtr hProcess, int lpBaseAddress, ref int lpBuffer, int nSize, int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long ReadProcessMemory(IntPtr hProcess, int lpBaseAddress, ref byte[] lpBuffer, int nSize, int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, byte[] lpBuffer, int nSize, int lpNumberOfBytesWritten);

	[DllImport("KERNEL32", CharSet = CharSet.Ansi, EntryPoint = "WriteProcessMemory", ExactSpelling = true, SetLastError = true)]
	public static extern float WriteProcessMemory_1(int Handle, int Address, ref float Value, int Size = 4, ref int BytesWritten = 0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hHandle);

	public static int Game_Hwnd()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		Process[] processesByName = Process.GetProcessesByName("LFS");
		int num = 0;
		int id = default(int);
		if (0 < processesByName.Length)
		{
			Process process = processesByName[num];
			id = process.Id;
			flag = true;
		}
		if (flag)
		{
			return id;
		}
		Interaction.MsgBox((object)"Couldn't find Game", (MsgBoxStyle)0, (object)null);
		ProjectData.EndApp();
		int result = default(int);
		return result;
	}

	public static void WriteMemory(int Address, int Value, int Size)
	{
		try
		{
			int num = Game_Hwnd();
			int num2 = (int)OpenProcess(1080u, 0, checked((uint)num));
			byte[] bytes = BitConverter.GetBytes(Value);
			WriteProcessMemory((IntPtr)num2, Address, bytes, Size, 0);
			CloseHandle((IntPtr)num2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void WriteMemory(int Address, byte[] Value)
	{
		try
		{
			int num = Game_Hwnd();
			int num2 = (int)OpenProcess(1080u, 0, checked((uint)num));
			WriteProcessMemory((IntPtr)num2, Address, Value, Value.Length, 0);
			CloseHandle((IntPtr)num2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void WriteMemory(int Address, byte[] Value, int Offset, int Length)
	{
		checked
		{
			try
			{
				int num = Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						WriteMemory(Address + num2, Value[num2 + Offset], 1);
						num2++;
						continue;
					}
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void WriteMemory(int Address, string Value)
	{
		checked
		{
			try
			{
				int length = Value.Length;
				int num = length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					WriteMemory(Address + num2, Strings.Asc(Value[num2]), 1);
					num2++;
				}
				WriteMemory(Address + length, 0, 1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void WriteMemory(int Address, double Value)
	{
		checked
		{
			try
			{
				byte[] array = new byte[8];
				array = BitConverter.GetBytes(Value);
				int num = 0;
				do
				{
					WriteMemory(Address + num, array[num], 1);
					num++;
				}
				while (num <= 7);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void WriteMemorySingle(int Address, float Value)
	{
		try
		{
			int num = Game_Hwnd();
			int num2 = (int)OpenProcess(1080u, 0, checked((uint)num));
			int BytesWritten = 0;
			WriteProcessMemory_1(num2, Address, ref Value, 4, ref BytesWritten);
			CloseHandle((IntPtr)num2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ReadMemory(int Address, ref double Value)
	{
		checked
		{
			try
			{
				byte[] array = new byte[8];
				int num = 0;
				int Value2 = default(int);
				do
				{
					ReadMemory(Address + num, ref Value2, 1);
					array[num] = (byte)Value2;
					num++;
				}
				while (num <= 7);
				Value = BitConverter.ToDouble(array, 0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ReadMemory(int Address, ref int Value, int Size)
	{
		try
		{
			int num = Game_Hwnd();
			int num2 = (int)OpenProcess(1080u, 0, checked((uint)num));
			int lpBuffer = default(int);
			ReadProcessMemory((IntPtr)num2, Address, ref lpBuffer, Size, 0);
			Value = lpBuffer;
			CloseHandle((IntPtr)num2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ReadMemory(int Address, ref byte[] Value, int Length)
	{
		checked
		{
			try
			{
				byte[] array = new byte[Length - 1 + 1];
				int num = Length - 1;
				int num2 = 0;
				int Value2 = default(int);
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					ReadMemory(Address + num2, ref Value2, 1);
					array[num2] = (byte)Value2;
					num2++;
				}
				Value = array;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ReadMemory(int Address, ref string Value)
	{
		checked
		{
			try
			{
				string text = string.Empty;
				int num = 0;
				int Value2 = default(int);
				do
				{
					ReadMemory(Address + num, ref Value2, 1);
					if (Value2 != 0)
					{
						text += Conversions.ToString(Strings.Chr(Value2));
					}
					num++;
				}
				while (Value2 != 0);
				Value = text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ReadMemory(int Address, ref string Value, int Length)
	{
		checked
		{
			try
			{
				string text = string.Empty;
				int num = Length - 1;
				int num2 = 0;
				int Value2 = default(int);
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					ReadMemory(Address + num2, ref Value2, 1);
					text += Conversions.ToString(Strings.Chr(Value2));
					num2++;
				}
				Value = text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static object ReadByte(int Address)
	{
		int Value = default(int);
		ReadMemory(Address, ref Value, 4);
		return Value;
	}

	public static object ReadByte2(int Address)
	{
		int Value = default(int);
		ReadMemory(Address, ref Value, 1);
		return Value;
	}

	public static void WriteByte(int Address, int Value)
	{
		WriteMemory(Address, Value, 4);
	}

	public static void WriteByte2(int Address, int Value)
	{
		WriteMemory(Address, Value, 1);
	}

	public static void ReadSingle(int Address, ref float Value)
	{
		checked
		{
			try
			{
				byte[] array = new byte[8];
				int num = 0;
				int Value2 = default(int);
				do
				{
					ReadMemory(Address + num, ref Value2, 1);
					array[num] = (byte)Value2;
					num++;
				}
				while (num <= 7);
				Value = BitConverter.ToSingle(array, 0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}

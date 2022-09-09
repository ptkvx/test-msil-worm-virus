using System;
using System.Diagnostics;
using MindCompression.Utils;

namespace MindCompression.Memory;

public class ProcessMemory
{
	private Process _processToRead = null;

	private IntPtr _hProcess = IntPtr.Zero;

	private int _processStart = 4194304;

	private int _processEnd;

	public Process ProcessToRead
	{
		get
		{
			return _processToRead;
		}
		set
		{
			_processToRead = value;
		}
	}

	public int ProcessStart => _processStart;

	public int ProcessEnd => _processEnd;

	public int OpenProcess(string processName)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName.IndexOf(processName) > -1)
			{
				ProcessToRead = process;
				break;
			}
		}
		if (ProcessToRead == null)
		{
			return OldOpenProcess(processName);
		}
		_hProcess = ProcessMemoryApi.OpenProcess(56u, 1, (uint)ProcessToRead.Id);
		_processEnd = GetProcEnd();
		return 0;
	}

	public int OldOpenProcess(string processName)
	{
		Process[] processesByName = Process.GetProcessesByName(processName);
		if (processesByName.Length == 0)
		{
			return 1;
		}
		ProcessToRead = processesByName[0];
		_hProcess = ProcessMemoryApi.OpenProcess(56u, 1, (uint)ProcessToRead.Id);
		_processEnd = GetProcEnd();
		return 0;
	}

	public int EvenOlderOpenProcess(string windowName)
	{
		IntPtr hWnd = ProcessMemoryApi.FindWindow(null, windowName);
		if (hWnd.Equals((object?)(nint)IntPtr.Zero))
		{
			return 1;
		}
		ProcessMemoryApi.GetWindowThreadProcessId(hWnd, out var lpdwProcessId);
		if (lpdwProcessId.Equals((object?)(nint)IntPtr.Zero))
		{
			return 1;
		}
		_hProcess = ProcessMemoryApi.OpenProcess(56u, 1, (uint)lpdwProcessId.ToInt32());
		_processEnd = GetProcEnd();
		return 0;
	}

	public void CloseHandle()
	{
		if (ProcessMemoryApi.CloseHandle(_hProcess) == 0)
		{
			throw new Exception("CloseHandle failed");
		}
	}

	public byte[] ReadProcessMemory(int memoryAddress, uint bytesToRead, out int bytesRead)
	{
		byte[] array = new byte[bytesToRead];
		ProcessMemoryApi.ReadProcessMemory(_hProcess, (IntPtr)memoryAddress, array, bytesToRead, out var lpNumberOfBytesRead);
		bytesRead = lpNumberOfBytesRead.ToInt32();
		return array;
	}

	public byte[] ReadProcessMemory(int memoryAdress, uint bytesToRead)
	{
		int bytesRead;
		byte[] result = ReadProcessMemory(memoryAdress, bytesToRead, out bytesRead);
		if (bytesRead != bytesToRead)
		{
			throw new InvalidOperationException($"Only {bytesRead} bytes could be read from address {memoryAdress:X}, expected {bytesToRead}.");
		}
		return result;
	}

	public int ReadInt32(int addr)
	{
		byte[] array = ReadProcessMemory(addr, 4u);
		return array[0] + array[1] * 256 + array[2] * 65536 + array[3] * 16777216;
	}

	public int ReadInt16(int addr)
	{
		byte[] array = ReadProcessMemory(addr, 2u);
		return array[0] + array[1] * 256;
	}

	public DateTime ReadDateTime(int addr)
	{
		byte[] array = ReadProcessMemory(addr, 4u);
		return FmDateTime.FromFmDateTime(array[3] + array[2] * 256 + array[1] * 65536 + array[0] * 16777216);
	}

	public byte ReadByte(int addr)
	{
		byte[] array = ReadProcessMemory(addr, 1u);
		return array[0];
	}

	public sbyte ReadSByte(int addr)
	{
		byte[] array = ReadProcessMemory(addr, 1u);
		return (sbyte)array[0];
	}

	public int WriteProcessMemory(int memoryAddress, byte[] buffer, uint bytesToWrite)
	{
		ProcessMemoryApi.WriteProcessMemory(_hProcess, (IntPtr)memoryAddress, buffer, bytesToWrite, out var lpNumberOfBytesWritten);
		return lpNumberOfBytesWritten.ToInt32();
	}

	public void WriteInt32(int value, int addr, bool reverse)
	{
		byte[] array = new byte[4];
		if (!reverse)
		{
			array[0] = (byte)((uint)value & 0xFFu);
			array[1] = (byte)((value & 0xFF00) >> 8);
			array[2] = (byte)((value & 0xFF0000) >> 16);
			array[3] = (byte)((value & 0xFF000000L) >> 24);
		}
		else
		{
			array[3] = (byte)((uint)value & 0xFFu);
			array[2] = (byte)((value & 0xFF00) >> 8);
			array[1] = (byte)((value & 0xFF0000) >> 16);
			array[0] = (byte)((value & 0xFF000000L) >> 24);
		}
		WriteProcessMemory(addr, array, 4u);
	}

	public void WriteInt32(int value, int addr)
	{
		WriteInt32(value, addr, reverse: false);
	}

	public void WriteInt16(int value, int addr, bool reverse)
	{
		byte[] array = new byte[2];
		if (!reverse)
		{
			array[0] = (byte)((uint)value & 0xFFu);
			array[1] = (byte)((value & 0xFF00) >> 8);
		}
		else
		{
			array[1] = (byte)((uint)value & 0xFFu);
			array[0] = (byte)((value & 0xFF00) >> 8);
		}
		WriteProcessMemory(addr, array, 2u);
	}

	public void WriteInt16(int value, int addr)
	{
		WriteInt16(value, addr, reverse: false);
	}

	public void WriteDateTime(DateTime value, int addr)
	{
		WriteInt32(FmDateTime.ToFmDateTime(value), addr, reverse: true);
	}

	public void WriteByte(byte value, int addr)
	{
		WriteProcessMemory(addr, new byte[1] { value }, 1u);
	}

	public void WriteSByte(sbyte value, int addr)
	{
		WriteProcessMemory(addr, new byte[1] { (byte)value }, 1u);
	}

	private int GetProcEnd()
	{
		int bytesRead = 0;
		int num = 268435455;
		int num2 = 16777216;
		for (int i = 1; i <= 7; i++)
		{
			ReadProcessMemory(num, 1u, out bytesRead);
			while (bytesRead == 0)
			{
				num -= num2;
				ReadProcessMemory(num, 1u, out bytesRead);
			}
			num += num2;
			num2 /= 16;
		}
		return num;
	}
}

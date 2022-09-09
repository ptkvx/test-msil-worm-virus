using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

public class OutputWindow
{
	private static int WINDOW_SIZE = 32768;

	private static int WINDOW_MASK = WINDOW_SIZE - 1;

	private byte[] window = new byte[checked((uint)WINDOW_SIZE)];

	private int window_end = 0;

	private int window_filled = 0;

	public void Write(int abyte)
	{
		if (window_filled++ == WINDOW_SIZE)
		{
			throw new InvalidOperationException("Window full");
		}
		window[window_end++] = (byte)abyte;
		window_end &= WINDOW_MASK;
	}

	private void SlowRepeat(int rep_start, int len, int dist)
	{
		while (len-- > 0)
		{
			window[window_end++] = window[rep_start++];
			window_end &= WINDOW_MASK;
			rep_start &= WINDOW_MASK;
		}
	}

	public void Repeat(int len, int dist)
	{
		if ((window_filled += len) > WINDOW_SIZE)
		{
			throw new InvalidOperationException("Window full");
		}
		int num = (window_end - dist) & WINDOW_MASK;
		int num2 = WINDOW_SIZE - len;
		if (num <= num2 && window_end < num2)
		{
			if (len <= dist)
			{
				Array.Copy(window, num, window, window_end, len);
				window_end += len;
			}
			else
			{
				while (len-- > 0)
				{
					window[window_end++] = window[num++];
				}
			}
		}
		else
		{
			SlowRepeat(num, len, dist);
		}
	}

	public int CopyStored(StreamManipulator input, int len)
	{
		len = Math.Min(Math.Min(len, WINDOW_SIZE - window_filled), input.AvailableBytes);
		int num = WINDOW_SIZE - window_end;
		int num2;
		if (len > num)
		{
			num2 = input.CopyBytes(window, window_end, num);
			if (num2 == num)
			{
				num2 += input.CopyBytes(window, 0, len - num);
			}
		}
		else
		{
			num2 = input.CopyBytes(window, window_end, len);
		}
		window_end = (window_end + num2) & WINDOW_MASK;
		window_filled += num2;
		return num2;
	}

	public void CopyDict(byte[] dict, int offset, int len)
	{
		if (window_filled > 0)
		{
			throw new InvalidOperationException();
		}
		if (len > WINDOW_SIZE)
		{
			offset += len - WINDOW_SIZE;
			len = WINDOW_SIZE;
		}
		Array.Copy(dict, offset, window, 0, len);
		window_end = len & WINDOW_MASK;
	}

	public int GetFreeSpace()
	{
		return WINDOW_SIZE - window_filled;
	}

	public int GetAvailable()
	{
		return window_filled;
	}

	public int CopyOutput(byte[] output, int offset, int len)
	{
		int num = window_end;
		if (len > window_filled)
		{
			len = window_filled;
		}
		else
		{
			num = (window_end - window_filled + len) & WINDOW_MASK;
		}
		int num2 = len;
		int num3 = len - num;
		if (num3 > 0)
		{
			Array.Copy(window, WINDOW_SIZE - num3, output, offset, num3);
			offset += num3;
			len = num;
		}
		Array.Copy(window, num - len, output, offset, len);
		window_filled -= num2;
		if (window_filled < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	public void Reset()
	{
		window_end = 0;
		window_filled = 0;
	}
}

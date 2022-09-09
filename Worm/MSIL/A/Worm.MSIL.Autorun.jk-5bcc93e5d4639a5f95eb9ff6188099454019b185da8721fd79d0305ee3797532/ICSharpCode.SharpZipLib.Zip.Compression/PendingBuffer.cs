using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

public class PendingBuffer
{
	protected byte[] buf;

	private int start;

	private int end;

	private uint bits;

	private int bitCount;

	public int BitCount => bitCount;

	public bool IsFlushed => end == 0;

	public PendingBuffer()
		: this(4096)
	{
	}

	public PendingBuffer(int bufsize)
	{
		buf = new byte[checked((uint)bufsize)];
	}

	public void Reset()
	{
		bitCount = 0;
		end = 0;
		start = 0;
	}

	public void WriteByte(int b)
	{
		buf[end++] = (byte)b;
	}

	public void WriteShort(int s)
	{
		buf[end++] = (byte)s;
		buf[end++] = (byte)(s >> 8);
	}

	public void WriteInt(int s)
	{
		buf[end++] = (byte)s;
		buf[end++] = (byte)(s >> 8);
		buf[end++] = (byte)(s >> 16);
		buf[end++] = (byte)(s >> 24);
	}

	public void WriteBlock(byte[] block, int offset, int len)
	{
		Array.Copy(block, offset, buf, end, len);
		end += len;
	}

	public void AlignToByte()
	{
		if (bitCount > 0)
		{
			buf[end++] = (byte)bits;
			if (bitCount > 8)
			{
				buf[end++] = (byte)(bits >> 8);
			}
		}
		bits = 0u;
		bitCount = 0;
	}

	public void WriteBits(int b, int count)
	{
		bits |= (uint)(b << bitCount);
		bitCount += count;
		if (bitCount >= 16)
		{
			buf[end++] = (byte)bits;
			buf[end++] = (byte)(bits >> 8);
			bits >>= 16;
			bitCount -= 16;
		}
	}

	public void WriteShortMSB(int s)
	{
		buf[end++] = (byte)(s >> 8);
		buf[end++] = (byte)s;
	}

	public int Flush(byte[] output, int offset, int length)
	{
		if (bitCount >= 8)
		{
			buf[end++] = (byte)bits;
			bits >>= 8;
			bitCount -= 8;
		}
		if (length > end - start)
		{
			length = end - start;
			Array.Copy(buf, start, output, offset, length);
			start = 0;
			end = 0;
		}
		else
		{
			Array.Copy(buf, start, output, offset, length);
			start += length;
		}
		return length;
	}

	public byte[] ToByteArray()
	{
		checked
		{
			byte[] array = new byte[(uint)unchecked(end - start)];
			Array.Copy(buf, start, array, 0, array.Length);
			start = 0;
			end = 0;
			return array;
		}
	}
}
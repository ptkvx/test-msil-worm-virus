using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipFile : IEnumerable
{
	private class ZipEntryEnumeration : IEnumerator
	{
		private ZipEntry[] array;

		private int ptr = -1;

		public object Current => array[ptr];

		public ZipEntryEnumeration(ZipEntry[] arr)
		{
			array = arr;
		}

		public void Reset()
		{
			ptr = -1;
		}

		public bool MoveNext()
		{
			return ++ptr < array.Length;
		}
	}

	private class PartialInputStream : InflaterInputStream
	{
		private Stream baseStream;

		private long filepos;

		private long end;

		public override int Available
		{
			get
			{
				long num = end - filepos;
				if (num > 2147483647L)
				{
					return int.MaxValue;
				}
				return (int)num;
			}
		}

		public PartialInputStream(Stream baseStream, long start, long len)
			: base(baseStream)
		{
			this.baseStream = baseStream;
			filepos = start;
			end = start + len;
		}

		public override int ReadByte()
		{
			if (filepos == end)
			{
				return -1;
			}
			lock (baseStream)
			{
				baseStream.Seek(filepos++, SeekOrigin.Begin);
				return baseStream.ReadByte();
			}
		}

		public override int Read(byte[] b, int off, int len)
		{
			if (len > end - filepos)
			{
				len = (int)(end - filepos);
				if (len == 0)
				{
					return -1;
				}
			}
			lock (baseStream)
			{
				baseStream.Seek(filepos, SeekOrigin.Begin);
				int num = baseStream.Read(b, off, len);
				if (num > 0)
				{
					filepos += len;
				}
				return num;
			}
		}

		public long SkipBytes(long amount)
		{
			if (amount < 0L)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (amount > end - filepos)
			{
				amount = end - filepos;
			}
			filepos += amount;
			return amount;
		}
	}

	private string name;

	private string comment;

	private Stream baseStream;

	private ZipEntry[] entries;

	public string ZipFileComment
	{
		get
		{
			return comment;
		}
		set
		{
			comment = value;
		}
	}

	public string Name => name;

	public int Size
	{
		get
		{
			try
			{
				return entries.Length;
			}
			catch (Exception)
			{
				throw new InvalidOperationException("ZipFile has closed");
			}
		}
	}

	public ZipFile(string name)
		: this(File.OpenRead(name))
	{
	}

	public ZipFile(FileStream file)
	{
		baseStream = file;
		name = file.Name;
		ReadEntries();
	}

	public ZipFile(Stream baseStream)
	{
		this.baseStream = baseStream;
		name = null;
		ReadEntries();
	}

	private int ReadLeShort()
	{
		return baseStream.ReadByte() | (baseStream.ReadByte() << 8);
	}

	private int ReadLeInt()
	{
		return ReadLeShort() | (ReadLeShort() << 16);
	}

	private void ReadEntries()
	{
		long num = baseStream.Length - 22L;
		do
		{
			if (num >= 0L)
			{
				baseStream.Seek(num--, SeekOrigin.Begin);
				continue;
			}
			throw new ZipException("central directory not found, probably not a zip file");
		}
		while (ReadLeInt() != 101010256);
		long position = baseStream.Position;
		baseStream.Position += 6L;
		if (baseStream.Position - position != 6L)
		{
			throw new EndOfStreamException();
		}
		int num2 = ReadLeShort();
		position = baseStream.Position;
		baseStream.Position += 4L;
		if (baseStream.Position - position != 4L)
		{
			throw new EndOfStreamException();
		}
		int num3 = ReadLeInt();
		int num4 = ReadLeShort();
		int num5;
		checked
		{
			byte[] array = new byte[(uint)num4];
			baseStream.Read(array, 0, array.Length);
			comment = ZipConstants.ConvertToString(array);
			entries = new ZipEntry[(uint)num2];
			baseStream.Seek(num3, SeekOrigin.Begin);
			num5 = 0;
		}
		while (true)
		{
			if (num5 < num2)
			{
				if (ReadLeInt() == 33639248)
				{
					position = baseStream.Position;
					baseStream.Position += 6L;
					if (baseStream.Position - position == 6L)
					{
						int compressionMethod = ReadLeShort();
						int dosTime = ReadLeInt();
						int num6 = ReadLeInt();
						int num7 = ReadLeInt();
						int num8 = ReadLeInt();
						int num9 = ReadLeShort();
						int num10 = ReadLeShort();
						int num11 = ReadLeShort();
						position = baseStream.Position;
						baseStream.Position += 8L;
						if (baseStream.Position - position != 8L)
						{
							break;
						}
						int offset = ReadLeInt();
						byte[] array2 = new byte[checked((uint)Math.Max(num9, num11))];
						baseStream.Read(array2, 0, num9);
						string text = ZipConstants.ConvertToString(array2);
						ZipEntry zipEntry = new ZipEntry(text);
						zipEntry.CompressionMethod = (CompressionMethod)compressionMethod;
						zipEntry.Crc = num6 & 0xFFFFFFFFL;
						zipEntry.Size = num8 & 0xFFFFFFFFL;
						zipEntry.CompressedSize = num7 & 0xFFFFFFFFL;
						zipEntry.DosTime = (uint)dosTime;
						if (num10 > 0)
						{
							byte[] array3 = new byte[checked((uint)num10)];
							baseStream.Read(array3, 0, num10);
							zipEntry.ExtraData = array3;
						}
						if (num11 > 0)
						{
							baseStream.Read(array2, 0, num11);
							zipEntry.Comment = ZipConstants.ConvertToString(array2);
						}
						zipEntry.zipFileIndex = num5;
						zipEntry.offset = offset;
						entries[num5] = zipEntry;
						num5++;
						continue;
					}
					throw new EndOfStreamException();
				}
				throw new ZipException("Wrong Central Directory signature");
			}
			return;
		}
		throw new EndOfStreamException();
	}

	public void Close()
	{
		entries = null;
		lock (baseStream)
		{
			baseStream.Close();
		}
	}

	public IEnumerator GetEnumerator()
	{
		if (entries == null)
		{
			throw new InvalidOperationException("ZipFile has closed");
		}
		return new ZipEntryEnumeration(entries);
	}

	private int GetEntryIndex(string name)
	{
		int num = 0;
		while (true)
		{
			if (num < entries.Length)
			{
				if (name.Equals(entries[num].Name))
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public ZipEntry GetEntry(string name)
	{
		if (entries == null)
		{
			throw new InvalidOperationException("ZipFile has closed");
		}
		int entryIndex = GetEntryIndex(name);
		return (entryIndex >= 0) ? ((ZipEntry)entries[entryIndex].Clone()) : null;
	}

	private long CheckLocalHeader(ZipEntry entry)
	{
		lock (baseStream)
		{
			baseStream.Seek(entry.offset, SeekOrigin.Begin);
			if (ReadLeInt() != 67324752)
			{
				throw new ZipException("Wrong Local header signature");
			}
			long position = baseStream.Position;
			baseStream.Position += 4L;
			if (baseStream.Position - position != 4L)
			{
				throw new EndOfStreamException();
			}
			if (entry.CompressionMethod != (CompressionMethod)ReadLeShort())
			{
				throw new ZipException("Compression method mismatch");
			}
			position = baseStream.Position;
			baseStream.Position += 16L;
			if (baseStream.Position - position != 16L)
			{
				throw new EndOfStreamException();
			}
			if (entry.Name.Length != ReadLeShort())
			{
				throw new ZipException("file name length mismatch");
			}
			int num = entry.Name.Length + ReadLeShort();
			return entry.offset + 30 + num;
		}
	}

	public Stream GetInputStream(ZipEntry entry)
	{
		if (entries == null)
		{
			throw new InvalidOperationException("ZipFile has closed");
		}
		int num = entry.zipFileIndex;
		if (num < 0 || num >= entries.Length || entries[num].Name != entry.Name)
		{
			num = GetEntryIndex(entry.Name);
			if (num < 0)
			{
				throw new IndexOutOfRangeException();
			}
		}
		long start = CheckLocalHeader(entries[num]);
		CompressionMethod compressionMethod = entries[num].CompressionMethod;
		Stream stream = new PartialInputStream(baseStream, start, entries[num].CompressedSize);
		return compressionMethod switch
		{
			CompressionMethod.Deflated => new InflaterInputStream(stream, new Inflater(nowrap: true)), 
			CompressionMethod.Stored => stream, 
			_ => throw new ZipException("Unknown compression method " + compressionMethod), 
		};
	}
}

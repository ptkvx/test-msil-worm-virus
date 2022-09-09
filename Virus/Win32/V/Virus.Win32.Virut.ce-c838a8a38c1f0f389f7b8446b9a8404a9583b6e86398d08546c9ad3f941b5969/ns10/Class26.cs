using System.IO;
using System.IO.Compression;
using ns13;
using ns8;

namespace ns10;

internal class Class26 : Class23
{
	public Class26()
	{
		Class33.smethod_0();
		base._002Ector();
	}

	public override object vmethod_0(object[] object_0)
	{
		MemoryStream stream = new MemoryStream((byte[])object_0[0]);
		MemoryStream memoryStream = new MemoryStream();
		byte[] array = new byte[1024];
		using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress, leaveOpen: true))
		{
			while (true)
			{
				int num = deflateStream.Read(array, 0, array.Length);
				if (num > 0)
				{
					memoryStream.Write(array, 0, num);
					continue;
				}
				break;
			}
		}
		return memoryStream.ToArray();
	}
}

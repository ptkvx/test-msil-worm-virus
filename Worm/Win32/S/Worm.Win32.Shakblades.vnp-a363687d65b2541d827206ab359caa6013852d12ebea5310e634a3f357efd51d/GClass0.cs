using System;
using System.Text;

public class GClass0
{
	private string string_0;

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public GClass0(string string_1)
	{
		string_0 = "";
		String_0 = string_1;
	}

	public string method_0(string string_1)
	{
		return Encoding.Default.GetString(method_1(Encoding.Default.GetBytes(string_1)));
	}

	public byte[] method_1(byte[] byte_0)
	{
		byte_0 = method_3(byte_0, Encoding.Default.GetBytes(String_0));
		byte[] array = new byte[byte_0.Length - 2 + 1];
		for (int i = byte_0.Length - 1; i >= 1; i += -1)
		{
			array[i - 1] = method_2(byte_0[i], (short)(-byte_0[i - 1]));
		}
		return array;
	}

	private byte method_2(byte byte_0, short short_0)
	{
		while (short_0 < 0)
		{
			short_0 = (short)(short_0 + 256);
		}
		return Convert.ToByte((short)(byte_0 + short_0) % 256);
	}

	private byte[] method_3(byte[] byte_0, byte[] byte_1)
	{
		if (byte_1.Length != 0)
		{
			int num = byte_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				byte_0[i] = (byte)(byte_0[i] ^ method_2(byte_1[i % byte_1.Length], byte_1[(int)byte_1[i % byte_1.Length] % byte_1.Length]) ^ byte_1[(i + i % 7) % byte_1.Length % byte_1.Length]);
			}
		}
		return byte_0;
	}
}

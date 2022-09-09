using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

internal sealed class Class18
{
	private const int int_0 = 8;

	private const int int_1 = 20;

	private const int int_2 = 4;

	private static byte[] byte_0;

	private static byte[] byte_1;

	static Class18()
	{
		byte_0 = new byte[4];
		byte_1 = new byte[4];
		byte[] array = byte_0;
		byte_1[0] = 82;
		array[0] = 82;
		byte[] array2 = byte_0;
		byte_1[1] = 83;
		array2[1] = 83;
		byte[] array3 = byte_0;
		byte_1[2] = 65;
		array3[2] = 65;
		byte_0[3] = 49;
		byte_1[3] = 50;
	}

	public static MemoryStream smethod_0(Stream stream_0)
	{
		BinaryReader binaryReader = new BinaryReader(stream_0);
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		bool flag = binaryReader.ReadBoolean();
		int num = binaryReader.ReadUInt16();
		byte[] array = new byte[num];
		binaryReader.Read(array, 0, num);
		if (flag || 1 == 0)
		{
			byte[] array2 = new byte[8];
			binaryReader.Read(array2, 0, 8);
			for (int i = 0; i < num; i++)
			{
				array[i] = (byte)(array[i] ^ array2[i % 8]);
			}
		}
		BinaryReader binaryReader2 = new BinaryReader(new MemoryStream(array, writable: false));
		binaryReader2.ReadString();
		bool flag2 = binaryReader2.ReadBoolean();
		int num2 = binaryReader2.ReadByte();
		byte[] array3 = new byte[num2];
		binaryReader2.Read(array3, 0, num2);
		dESCryptoServiceProvider.IV = array3;
		bool flag3 = binaryReader2.ReadBoolean();
		int num3 = binaryReader2.ReadByte();
		byte[] array4 = new byte[num3];
		if (flag3)
		{
			binaryReader2.Read(array4, 0, num3);
		}
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		int num4 = binaryReader2.ReadInt32();
		byte[] array5 = new byte[num4];
		binaryReader2.Read(array5, 0, num4);
		if (!flag3)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			AssemblyName name = executingAssembly.GetName();
			byte[] publicKey = name.GetPublicKey();
			if (publicKey == null || publicKey.Length != 160)
			{
				throw new InvalidOperationException();
			}
			Buffer.BlockCopy(publicKey, 12, array4, 0, num3);
			array4[5] |= 128;
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.ImportParameters(smethod_3(publicKey));
		}
		dESCryptoServiceProvider.Key = array4;
		MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream stream_ = new CryptoStream(binaryReader.BaseStream, dESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
		{
			if (flag2)
			{
				Class5.smethod_0(stream_, memoryStream);
			}
			else
			{
				smethod_2(stream_, memoryStream);
			}
		}
		if (rSACryptoServiceProvider != null)
		{
			memoryStream.Position = 0L;
			if (!smethod_5(rSACryptoServiceProvider, memoryStream, array5))
			{
				throw new InvalidOperationException();
			}
		}
		memoryStream.Position = 0L;
		return memoryStream;
	}

	private static byte[] smethod_1(byte[] byte_2, int int_3, int int_4)
	{
		if ((byte_2 != null || 1 == 0) && byte_2.Length >= int_3 + int_4)
		{
			byte[] array = new byte[int_4];
			Array.Copy(byte_2, int_3, array, 0, int_4);
			return array;
		}
		return null;
	}

	private static void smethod_2(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[4096];
		while (true)
		{
			int num = stream_0.Read(array, 0, array.Length);
			if (num > 0)
			{
				stream_1.Write(array, 0, num);
				continue;
			}
			break;
		}
	}

	private static RSAParameters smethod_3(byte[] byte_2)
	{
		bool flag;
		if (((flag = byte_2.Length == 160) || 1 == 0) && !smethod_4(byte_2, byte_0, 20))
		{
			return default(RSAParameters);
		}
		if (!flag && !smethod_4(byte_2, byte_1, 8))
		{
			return default(RSAParameters);
		}
		RSAParameters result = default(RSAParameters);
		int num = (flag ? 20 : 8);
		num += 8;
		int num2 = 4;
		result.Exponent = smethod_1(byte_2, num, 4);
		Array.Reverse((Array)result.Exponent);
		num += 4;
		num2 = 128;
		result.Modulus = smethod_1(byte_2, num, 128);
		Array.Reverse((Array)result.Modulus);
		if (flag)
		{
			return result;
		}
		num += num2;
		num2 = 64;
		result.P = smethod_1(byte_2, num, 64);
		Array.Reverse((Array)result.P);
		num += 64;
		num2 = 64;
		result.Q = smethod_1(byte_2, num, 64);
		Array.Reverse((Array)result.Q);
		num += 64;
		num2 = 64;
		result.DP = smethod_1(byte_2, num, 64);
		Array.Reverse((Array)result.DP);
		num += 64;
		num2 = 64;
		result.DQ = smethod_1(byte_2, num, 64);
		Array.Reverse((Array)result.DQ);
		num += 64;
		num2 = 64;
		result.InverseQ = smethod_1(byte_2, num, 64);
		Array.Reverse((Array)result.InverseQ);
		num += 64;
		num2 = 128;
		result.D = smethod_1(byte_2, num, 128);
		Array.Reverse((Array)result.D);
		return result;
	}

	private static bool smethod_4(byte[] byte_2, byte[] byte_3, int int_3)
	{
		int num = 0;
		while (true)
		{
			if (num < byte_3.Length)
			{
				if (byte_2[num + int_3] != byte_3[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static bool smethod_5(RSACryptoServiceProvider rsacryptoServiceProvider_0, Stream stream_0, byte[] byte_2)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] array = (array = sHA1CryptoServiceProvider.ComputeHash(stream_0));
		string text = new string('S', 1);
		text += 'H';
		text += 'A';
		text += '1';
		return rsacryptoServiceProvider_0.VerifyHash(array, CryptoConfig.MapNameToOID(text), byte_2);
	}
}

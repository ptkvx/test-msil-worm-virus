using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

internal static class Class9
{
	private static readonly Dictionary<int, string> dictionary_0 = new Dictionary<int, string>(99);

	private static BinaryReader binaryReader_0;

	private static byte[] byte_0;

	private static short short_0;

	private static bool bool_0;

	private static byte[] byte_1;

	public static string smethod_0(int int_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(int_0, out var value))
			{
				return value;
			}
			if (binaryReader_0 == null)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				bool_0 = false;
				binaryReader_0 = new BinaryReader(executingAssembly.GetManifestResourceStream("\u2001\u200a\u2001\u200b\u2003\u2007\u200a\u2002\u2005\u2007\u2009\u2005"));
				short num = (short)(binaryReader_0.ReadInt16() ^ -11853);
				if (num == 0)
				{
					short_0 = (short)(binaryReader_0.ReadInt16() ^ 0x7ADD);
				}
				else
				{
					byte_0 = binaryReader_0.ReadBytes(num);
				}
				callingAssembly = executingAssembly;
				AssemblyName name = callingAssembly.GetName();
				byte_1 = name.GetPublicKeyToken();
				if (byte_1 != null && byte_1.Length == 0)
				{
					byte_1 = null;
				}
			}
			int num2 = int_0 ^ -51991212;
			binaryReader_0.BaseStream.Position = num2;
			byte[] array;
			if (byte_0 == null)
			{
				short num3 = ((short_0 != -1) ? short_0 : ((short)(binaryReader_0.ReadInt16() ^ -21422 ^ num2)));
				array = ((num3 != 0) ? binaryReader_0.ReadBytes(num3) : null);
			}
			else
			{
				array = byte_0;
			}
			int num4 = binaryReader_0.ReadInt32() ^ num2 ^ -1597407535;
			bool flag;
			if (flag = (num4 & int.MinValue) != 0)
			{
				num4 &= 0x7FFFFFFF;
			}
			byte[] array2 = Class10.smethod_0(array, binaryReader_0.ReadBytes(num4));
			if (byte_1 != null != bool_0)
			{
				for (int i = 0; i < num4; i++)
				{
					byte b = byte_1[i & 7];
					b = (byte)((b << 3) | (b >> 5));
					array2[i] = (byte)(array2[i] ^ b);
				}
			}
			if (flag && !bool_0)
			{
				char[] array3 = new char[num4];
				for (int j = 0; j < num4; j++)
				{
					array3[j] = (char)array2[j];
				}
				value = new string(array3);
			}
			else
			{
				value = Encoding.Unicode.GetString(array2, 0, array2.Length);
			}
			if (bool_0)
			{
				value = ((int_0 + num4) ^ 0xE4A78).ToString("X");
			}
			value = string.Intern(value);
			dictionary_0.Add(int_0, value);
			if (dictionary_0.Count == 99)
			{
				binaryReader_0.Close();
				binaryReader_0 = null;
				byte_0 = (byte_1 = null);
			}
			return value;
		}
	}
}

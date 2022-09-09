using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class8
{
	public class Class9
	{
		[DebuggerNonUserCode]
		public Class9()
		{
		}

		public static string smethod_0(string string_0, string string_1)
		{
			return Encoding.Default.GetString(smethod_1(Encoding.Default.GetBytes(string_0), Encoding.Default.GetBytes(string_1)));
		}

		public static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
		{
			int num = checked(byte_0.Length - 1);
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				byte_0[num2] = (byte)(checked((byte)unchecked(checked(unchecked((int)byte_0[num2]) + unchecked((int)byte_0[checked(num2 + 1) % byte_0.Length])) % 256)) ^ byte_1[num2 % byte_1.Length]);
				num2 = checked(num2 + 1);
			}
			return byte_0;
		}

		public static string smethod_2(string string_0, string string_1)
		{
			return Encoding.Default.GetString(smethod_3(Encoding.Default.GetBytes(string_0), Encoding.Default.GetBytes(string_1)));
		}

		public static byte[] smethod_3(byte[] byte_0, byte[] byte_1)
		{
			checked
			{
				for (int i = byte_0.Length - 1; i >= 0; i += -1)
				{
					byte_0[i] = (byte)unchecked(checked((byte_0[i] ^ byte_1[unchecked(i % byte_1.Length)]) - unchecked((int)byte_0[checked(i + 1) % byte_0.Length]) + 256) % 256);
				}
				return byte_0;
			}
		}
	}

	[DebuggerNonUserCode]
	public Class8()
	{
	}

	public static string smethod_0(string string_0, string string_1, bool bool_0)
	{
		byte[] array = Convert.FromBase64String(string_0);
		byte[] key;
		if (bool_0)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_1));
		}
		else
		{
			key = Encoding.UTF8.GetBytes(string_1);
		}
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string smethod_1(string string_0, string string_1)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = string_1.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = string_1.Substring(location % length, 1).ToCharArray()[0];
			array2[location] = Strings.Asc(c);
			array[location] = location;
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		int num3 = 0;
		int location2 = 0;
		while (location2 <= 255)
		{
			num3 = checked(num3 + array[location2] + array2[location2]) % 256;
			int num4 = array[location2];
			array[location2] = array[num3];
			array[num3] = num4;
			Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
		}
		location = 1;
		while (location <= string_0.Length)
		{
			int num5 = 0;
			num = checked(num + 1) % 256;
			num2 = checked(num2 + array[num]) % 256;
			num5 = array[num];
			array[num] = array[num2];
			array[num2] = num5;
			int num6 = array[checked(array[num] + array[num2]) % 256];
			checked
			{
				char c2 = string_0.Substring(location - 1, 1).ToCharArray()[0];
				num5 = Strings.Asc(c2);
				int num7 = num5 ^ num6;
				stringBuilder.Append(Strings.Chr(num7));
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
		empty = stringBuilder.ToString();
		stringBuilder.Length = 0;
		return empty;
	}

	public static object smethod_2(string string_0, string string_1)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			string_0 = Encoding.UTF8.GetString(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return string_0;
	}

	public static string smethod_3(string string_0, string string_1)
	{
		string text = "";
		checked
		{
			long num = (long)Math.Round((double)Strings.Len(string_1) / 2.0);
			long num2 = 1L;
			while (true)
			{
				long num3 = num2;
				long num4 = num;
				if (num3 > num4)
				{
					break;
				}
				int num5 = (int)Math.Round(Conversion.Val("&H" + Strings.Mid(string_1, (int)(2L * num2 - 1L), 2)));
				int num6 = Strings.Asc(Strings.Mid(string_0, (int)(unchecked(num2 % Strings.Len(string_0)) + 1L), 1));
				text += Conversions.ToString(Strings.Chr(num5 ^ num6));
				num2++;
			}
			return text;
		}
	}
}

using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ajhfsdlhjasnagfgewfwsg;

public class JHSAKDJHkjhakJHkjhUyiuYiuyIUyiUYiuyIuyiuYYrYTY
{
	[DebuggerNonUserCode]
	public JHSAKDJHkjhakJHkjhUyiuYiuyIUyiUYiuyIuyiuYYrYTY()
	{
	}

	public static byte[] dsfkjhxcivudsoifuoixuvoiusaduoasdzxc(byte[] bytes, byte[] key)
	{
		byte[] array = new byte[256];
		checked
		{
			int num = array.Length - 1;
			int i;
			for (i = 0; i <= num; i++)
			{
				array[i] = (byte)i;
			}
			int num2 = array.Length - 1;
			int num3 = default(int);
			for (i = 0; i <= num2; i++)
			{
				num3 = (num3 + unchecked((int)key[i % key.Length]) + unchecked((int)array[i])) & 0xFF;
				byte b = array[i];
				array[i] = array[num3];
				array[num3] = b;
			}
			i = 0;
			num3 = 0;
			byte[] array2 = new byte[bytes.Length - 1 + 1];
			int num4 = bytes.Length - 1;
			for (int j = 0; j <= num4; j++)
			{
				i = (i + 1) & 0xFF;
				num3 = (num3 + unchecked((int)array[i])) & 0xFF;
				byte b2 = array[i];
				array[i] = array[num3];
				array[num3] = b2;
				unchecked
				{
					array2[j] = (byte)(array[checked(unchecked((int)array[i]) + unchecked((int)array[num3])) & 0xFF] ^ bytes[j]);
				}
			}
			return array2;
		}
	}

	public static string asioduzxoicuoisaudoiasudoixzc(string b, string c, bool d)
	{
		byte[] array = Convert.FromBase64String(b);
		byte[] key;
		if (d)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(c));
		}
		else
		{
			key = Encoding.UTF8.GetBytes(c);
		}
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string xJHSAKDJHkjhakJHkjhUyiuYiuyIUyiUYiuyIuyiuYYrYTY(string CodeKey, string DataIn)
	{
		string text = "";
		checked
		{
			long num = (long)Math.Round((double)Strings.Len(DataIn) / 2.0);
			for (long num2 = 1L; num2 <= num; num2++)
			{
				int num3 = (int)Math.Round(Conversion.Val("&H" + Strings.Mid(DataIn, (int)(2L * num2 - 1L), 2)));
				int num4 = Strings.Asc(Strings.Mid(CodeKey, (int)(unchecked(num2 % Strings.Len(CodeKey)) + 1L), 1));
				text += Conversions.ToString(Strings.Chr(num3 ^ num4));
			}
			return text;
		}
	}

	public static object Rijndael(string Decrypt, string Key)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Key, salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		try
		{
			byte[] array = Convert.FromBase64String(Decrypt);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			Decrypt = Encoding.UTF8.GetString(memoryStream.ToArray());
			return Decrypt;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return Decrypt;
		}
	}
}

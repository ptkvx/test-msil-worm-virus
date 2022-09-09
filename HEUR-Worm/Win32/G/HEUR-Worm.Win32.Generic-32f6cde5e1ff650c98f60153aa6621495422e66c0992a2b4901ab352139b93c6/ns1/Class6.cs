using System;
using System.Security.Cryptography;
using System.Text;

namespace ns1;

internal class Class6
{
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
}

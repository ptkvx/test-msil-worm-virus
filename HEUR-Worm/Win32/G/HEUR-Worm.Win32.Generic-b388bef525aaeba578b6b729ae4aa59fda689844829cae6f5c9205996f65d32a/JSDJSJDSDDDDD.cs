using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class JSDJSJDSDDDDD
{
	public static string EhwQjD(string WuBwIL, string WJvWsG)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(WJvWsG));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] array = Convert.FromBase64String(WuBwIL);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
	}

	public static byte[] NxOSVM(byte[] WuBwIL, string WJvWsG)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(WJvWsG));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(WuBwIL, 0, WuBwIL.Length);
	}
}

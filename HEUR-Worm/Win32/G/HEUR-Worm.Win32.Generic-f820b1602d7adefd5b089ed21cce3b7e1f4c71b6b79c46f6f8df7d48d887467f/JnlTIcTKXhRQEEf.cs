using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class JnlTIcTKXhRQEEf
{
	public static string QOTEwE(string idHWpK, string bBomgy)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(bBomgy));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] array = Convert.FromBase64String(idHWpK);
		return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
	}

	public static byte[] rfBqhv(byte[] idHWpK, string bBomgy)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(bBomgy));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		return cryptoTransform.TransformFinalBlock(idHWpK, 0, idHWpK.Length);
	}
}

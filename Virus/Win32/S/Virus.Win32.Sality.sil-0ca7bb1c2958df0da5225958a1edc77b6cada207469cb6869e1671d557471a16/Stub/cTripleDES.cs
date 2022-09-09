using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

internal class cTripleDES
{
	private TripleDESCryptoServiceProvider m_des;

	private UTF8Encoding m_utf8;

	private byte[] m_key;

	private byte[] m_iv;

	public cTripleDES(byte[] key, byte[] iv)
	{
		m_des = new TripleDESCryptoServiceProvider();
		m_utf8 = new UTF8Encoding();
		m_key = key;
		m_iv = iv;
	}

	public byte[] Encrypt(byte[] input)
	{
		return Transform(input, m_des.CreateEncryptor(m_key, m_iv));
	}

	public byte[] Decrypt(byte[] input)
	{
		return Transform(input, m_des.CreateDecryptor(m_key, m_iv));
	}

	public string Encrypt(string text)
	{
		byte[] bytes = m_utf8.GetBytes(text);
		byte[] inArray = Transform(bytes, m_des.CreateEncryptor(m_key, m_iv));
		return Convert.ToBase64String(inArray);
	}

	public string Decrypt(string text)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		string @string = default(string);
		try
		{
			byte[] input = Convert.FromBase64String(text);
			byte[] bytes = Transform(input, m_des.CreateDecryptor(m_key, m_iv));
			@string = m_utf8.GetString(bytes);
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Error, Please check your characters.", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	private byte[] Transform(byte[] input, ICryptoTransform CryptoTransform)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, CryptoTransform, CryptoStreamMode.Write);
		cryptoStream.Write(input, 0, input.Length);
		cryptoStream.FlushFinalBlock();
		memoryStream.Position = 0L;
		byte[] array = new byte[checked((int)(memoryStream.Length - 1L) + 1)];
		memoryStream.Read(array, 0, array.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return array;
	}
}

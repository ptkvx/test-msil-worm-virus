using System;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace adudule;

internal class EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX
{
	[DebuggerNonUserCode]
	public EloJlpEOjwjWxUSuctfjJjuoHEbwVNKVmBWKTrmPRxSX()
	{
	}

	public static string bibiphoque(string Data, string key)
	{
		return Encoding.Default.GetString(bibiphoque(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
	}

	public static byte[] bibiphoque(byte[] Data, byte[] key)
	{
		checked
		{
			for (int i = Data.Length - 1; i >= 0; i += -1)
			{
				Data[i] = (byte)unchecked(checked((Data[i] ^ key[unchecked(i % key.Length)]) - unchecked((int)Data[checked(i + 1) % Data.Length]) + 256) % 256);
			}
			return Data;
		}
	}

	public static string ZPdnWWJKktGiCgFXjXUOgdBkuBwJZavxHeMpFlrLTJoj(string Input)
	{
		string text = null;
		string[] array = Input.Split(new char[1] { '|' });
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			try
			{
				text += Conversions.ToString(Strings.Chr(checked((int)Math.Round(Conversions.ToDouble(text2) - Conversions.ToDouble(array[0])))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		return text.Remove(0, 1);
	}
}

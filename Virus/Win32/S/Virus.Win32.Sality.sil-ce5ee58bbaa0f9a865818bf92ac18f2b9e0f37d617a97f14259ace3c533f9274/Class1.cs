using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using hotfile_link_generator;

internal class Class1
{
	public static string smethod_0(string string_0)
	{
		string text = "";
		for (int i = 0; i < string_0.Length; i++)
		{
			text = text + (string_0[i] + 7) * 3 + " ";
		}
		return text;
	}

	public static string smethod_1(string string_0)
	{
		string text = "";
		try
		{
			for (string text2 = smethod_13(ref string_0, " "); text2 != null; text2 = smethod_13(ref string_0, " "))
			{
				int num = int.Parse(text2);
				num = num / 3 - 7;
				text += (char)num;
			}
		}
		catch
		{
		}
		return text;
	}

	public static string[] smethod_2(string string_0, string string_1, bool bool_0)
	{
		if (string_0.Trim() == "")
		{
			return null;
		}
		string[] array = null;
		int num = smethod_15(string_0, string_1);
		array = new string[num + 1];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = smethod_14(ref string_0, string_1, bool_0: false);
			if (bool_0)
			{
				array[i] = Form2.dexor2(array[i]);
			}
		}
		return array;
	}

	public static void smethod_3(string string_0, ref string string_1, ref string string_2)
	{
		string_1 = smethod_14(ref string_0, "=", bool_0: false);
		string_2 = string_0;
		try
		{
			string_1 = string_1.Trim();
		}
		catch
		{
		}
		try
		{
			string_2 = string_2.Trim();
		}
		catch
		{
		}
	}

	public static string[] smethod_4(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TextBox val = new TextBox();
		try
		{
			StreamReader streamReader = new StreamReader(string_0);
			((Control)val).set_Text(streamReader.ReadToEnd());
			streamReader.Close();
			return ((TextBoxBase)val).get_Lines();
		}
		catch
		{
			return null;
		}
	}

	public static string smethod_5(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TextBox val = new TextBox();
		try
		{
			StreamReader streamReader = new StreamReader(string_0);
			((Control)val).set_Text(streamReader.ReadToEnd());
			streamReader.Close();
			return ((Control)val).get_Text();
		}
		catch
		{
			return null;
		}
	}

	public static bool smethod_6(string string_0, string string_1)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				File.Create(string_0).Close();
			}
			StreamWriter streamWriter = new StreamWriter(string_0);
			streamWriter.Write(string_1);
			streamWriter.Close();
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static string smethod_7(string string_0)
	{
		WebRequest webRequest = WebRequest.Create(string_0);
		WebResponse response;
		try
		{
			response = webRequest.GetResponse();
		}
		catch
		{
			return "";
		}
		string result = "";
		using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
		{
			result = streamReader.ReadToEnd();
		}
		return result;
	}

	public static string smethod_8(string string_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public static int smethod_9(string[,] string_0, string string_1)
	{
		try
		{
			int length = string_0.GetLength(0);
			int length2 = string_0.GetLength(1);
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					if (string_0[i, j] == string_1)
					{
						return i;
					}
				}
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	public static int smethod_10(string[] string_0, string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] == string_1)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public static string smethod_11(string string_0)
	{
		WebRequest webRequest = WebRequest.Create(string_0);
		WebResponse response = webRequest.GetResponse();
		Stream responseStream = response.GetResponseStream();
		Encoding encoding = Encoding.GetEncoding("utf-8");
		StreamReader streamReader = new StreamReader(responseStream, encoding);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		response.Close();
		return result;
	}

	public static string smethod_12(string string_0, string string_1, string string_2)
	{
		if (string_0.Contains(string_1))
		{
			string_0 = string_0.Substring(string_0.IndexOf(string_1) + string_1.Length);
			if (string_0.Contains(string_2))
			{
				string_0 = string_0.Substring(0, string_0.IndexOf(string_2));
				return string_0;
			}
		}
		return "";
	}

	public static string smethod_13(ref string string_0, string string_1)
	{
		string text = string_0;
		try
		{
			text = string_0.Substring(0, string_0.IndexOf(string_1));
			string_0 = string_0.Substring(string_0.IndexOf(string_1) + string_1.Length);
		}
		catch
		{
			return null;
		}
		return text;
	}

	public static string smethod_14(ref string string_0, string string_1, bool bool_0)
	{
		string text = string_0;
		try
		{
			text = string_0.Substring(0, string_0.IndexOf(string_1));
			string_0 = string_0.Substring(string_0.IndexOf(string_1) + string_1.Length);
		}
		catch
		{
			if (bool_0)
			{
				return null;
			}
			return string_0;
		}
		return text;
	}

	public static int smethod_15(string string_0, string string_1)
	{
		int num = -1;
		int num2 = 0;
		for (num = string_0.IndexOf(string_1); num != -1; num = string_0.IndexOf(string_1))
		{
			num2++;
			string_0 = string_0.Substring(num + 1);
		}
		return num2;
	}

	public static bool smethod_16(string string_0)
	{
		int num = smethod_15(string_0, ".");
		if (num != 3)
		{
			return false;
		}
		if (string_0[string_0.Length - 1] == '.')
		{
			return false;
		}
		for (int i = 0; i < 3; i++)
		{
			try
			{
				num = Convert.ToInt32(smethod_13(ref string_0, "."));
			}
			catch
			{
				return false;
			}
		}
		return true;
	}

	public static bool smethod_17(string string_0)
	{
		try
		{
			Convert.ToInt32(string_0);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool smethod_18(string string_0)
	{
		if (string_0[string_0.Length - 1] == '.')
		{
			return false;
		}
		int num = smethod_15(string_0, ".");
		for (int i = 0; i < num; i++)
		{
			try
			{
				Convert.ToInt32(smethod_13(ref string_0, "."));
			}
			catch
			{
				return false;
			}
		}
		return true;
	}

	public static int smethod_19(ArrayList arrayList_0, string string_0)
	{
		if (!arrayList_0.Contains(string_0))
		{
			return -1;
		}
		int num = 0;
		while (true)
		{
			if (num < arrayList_0.Count)
			{
				if (arrayList_0[num]!.ToString() == string_0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	private static string smethod_20(int[] int_0)
	{
		return int_0[0].ToString() + '.' + int_0[1].ToString() + '.' + int_0[2].ToString() + '.' + int_0[3].ToString();
	}

	public static string smethod_21(string string_0)
	{
		int[] array = smethod_22(string_0);
		if (array[3] >= 255)
		{
			array[3] = 1;
			array[2]++;
			if (array[2] >= 255)
			{
				array[2] = 1;
				array[1]++;
				if (array[1] >= 255)
				{
					array[1] = 1;
					array[0]++;
				}
			}
		}
		else
		{
			array[3]++;
		}
		return smethod_20(array);
	}

	private static int[] smethod_22(string string_0)
	{
		string_0 += '.';
		int[] array = new int[4];
		int num = string_0.IndexOf('.');
		for (int i = 0; i < 4; i++)
		{
			array[i] = Convert.ToInt32(string_0.Substring(0, num));
			string_0 = string_0.Substring(num + 1);
			num = string_0.IndexOf('.');
		}
		return array;
	}

	public static bool smethod_23(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.StartsWith(string_0))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		process.Kill();
		return true;
	}

	public static bool smethod_24(string string_0)
	{
		bool flag = false;
		Process[] processesByName = Process.GetProcessesByName(string_0);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
			flag = true;
		}
		if (flag)
		{
			return true;
		}
		return false;
	}

	public static bool smethod_25(string string_0)
	{
		Process[] processesByName = Process.GetProcessesByName(string_0);
		Process[] array = processesByName;
		if (0 >= array.Length)
		{
			return false;
		}
		return true;
	}

	public static string smethod_26(string string_0)
	{
		int num = string_0.LastIndexOf('\\');
		if (num == -1)
		{
			return string_0;
		}
		string_0 = string_0.Substring(num + 1);
		if (string_0[string_0.Length - 4] == '.')
		{
			string_0 = string_0.Substring(0, string_0.Length - 4);
		}
		return string_0;
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Toya.Upgrade;

public class AppFile
{
	private static string filePath = Application.get_StartupPath() + "\\Toya.ini";

	private static StringBuilder sbAdjustINIValues = new StringBuilder(2048);

	private static StringBuilder sbTemp = new StringBuilder(2048);

	private static string[] AdjustINIValues;

	private static string[] INIValues;

	private static int Count = 28;

	private static int index = 0;

	private static string temp;

	[DllImport("kernel32")]
	private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

	public static long Write(string section, string key, string val)
	{
		return WritePrivateProfileString(section, key, val, filePath);
	}

	public static string Read(string section, string key, string def, StringBuilder retVal, int size)
	{
		GetPrivateProfileString(section, key, def, sbTemp, size, filePath);
		return sbTemp.ToString();
	}

	public static string Read(string section, string key, int size)
	{
		GetPrivateProfileString(section, key, "无法读取对应数值", sbTemp, size, filePath);
		return sbTemp.ToString();
	}

	public static string Read(string section, string key, string def, int size)
	{
		GetPrivateProfileString(section, key, def, sbTemp, size, filePath);
		return sbTemp.ToString();
	}

	public static void AdjustINIValue(string section, string key, string val)
	{
		AdjustINIValue(section, key, val, filePath);
	}

	private static void AdjustINIValue(string section, string key, string val, string filePath)
	{
		try
		{
			if (val.Trim() == "")
			{
				return;
			}
			GetPrivateProfileString(section, key, "", sbAdjustINIValues, 2048, filePath);
			INIValues = sbAdjustINIValues.ToString().Split(new char[1] { '\\' });
			AdjustINIValues = val.Trim().Split(new char[1] { ' ' });
			string[] adjustINIValues = AdjustINIValues;
			foreach (string text in adjustINIValues)
			{
				if (!(text != ""))
				{
					continue;
				}
				index = -1;
				for (int j = 0; j < INIValues.Length; j++)
				{
					if (text == INIValues[j])
					{
						index = j;
						break;
					}
				}
				if (index == -1 && INIValues.Length < Count)
				{
					INIValues = (string[])Redim(INIValues, INIValues.Length + 1);
					INIValues[INIValues.Length - 1] = text;
				}
				if (index > 0 && index < INIValues.Length)
				{
					temp = INIValues[index - 1];
					INIValues[index - 1] = text;
					INIValues[index] = temp;
				}
				if (index == -1 && INIValues.Length >= Count)
				{
					INIValues[INIValues.Length - 2] = text;
				}
			}
			sbAdjustINIValues.Remove(0, sbAdjustINIValues.Length);
			string[] iNIValues = INIValues;
			foreach (string text2 in iNIValues)
			{
				if (text2 != "")
				{
					sbAdjustINIValues.Append(text2);
					sbAdjustINIValues.Append("\\");
				}
			}
			WritePrivateProfileString(section, key, sbAdjustINIValues.ToString(), filePath);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	private static Array Redim(Array origArray, int desiredSize)
	{
		Type elementType = origArray.GetType().GetElementType();
		Array array = Array.CreateInstance(elementType, desiredSize);
		Array.Copy(origArray, 0, array, 0, Math.Min(origArray.Length, desiredSize));
		return array;
	}
}

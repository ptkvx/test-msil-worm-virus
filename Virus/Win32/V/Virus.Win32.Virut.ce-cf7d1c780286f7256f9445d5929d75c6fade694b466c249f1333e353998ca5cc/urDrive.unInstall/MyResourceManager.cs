using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace urDrive.unInstall;

public class MyResourceManager
{
	public static string strConfigFullPath = Application.get_StartupPath() + "\\urDrive\\Config\\";

	public static void WriteDefaultLanguage(string strFullPath, string nodeValue)
	{
		try
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(strFullPath);
			DataTable dataTable = dataSet.Tables["AppLanguage"];
			dataTable.Rows[0]["DefaultLanguage"] = nodeValue.ToLower();
			dataSet.AcceptChanges();
			dataSet.WriteXml(strFullPath);
		}
		catch (Exception)
		{
		}
	}

	public static void InitResource()
	{
		ResourceManager resourceManager = null;
		CultureInfo cultureInfo = null;
		string text = strConfigFullPath;
		string text2 = "Resource_" + SystemInfo.DefaultLanguage.ToLower();
		string path = text + text2 + ".resources";
		string strFullPath = Application.get_StartupPath() + "\\urDrive\\Config\\AppConfig.xml";
		if (!File.Exists(path))
		{
			text2 = "Resource_EN";
			resourceManager = ResourceManager.CreateFileBasedResourceManager(text2, text, null);
			cultureInfo = new CultureInfo("en");
			SystemInfo.MyResManager = resourceManager;
			SystemInfo.MyCulture = cultureInfo;
			WriteDefaultLanguage(strFullPath, "en");
			SystemInfo.DefaultLanguage = "en";
			return;
		}
		resourceManager = ResourceManager.CreateFileBasedResourceManager(text2, text, null);
		try
		{
			cultureInfo = new CultureInfo(SystemInfo.DefaultLanguage);
		}
		catch
		{
			cultureInfo = new CultureInfo("en");
			SystemInfo.DefaultLanguage = "en";
		}
		SystemInfo.MyResManager = resourceManager;
		SystemInfo.MyCulture = cultureInfo;
	}
}

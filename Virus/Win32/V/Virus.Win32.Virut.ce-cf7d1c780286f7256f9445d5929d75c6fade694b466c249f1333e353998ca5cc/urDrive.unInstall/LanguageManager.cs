using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace urDrive.unInstall;

public class LanguageManager
{
	private static string strAppConfigPath = Application.get_StartupPath() + "\\urDrive\\Config\\AppConfig.xml";

	public static string[] strLanguageCode = new string[12]
	{
		"en", "zh-chs", "zh-cht", "fr", "it", "de", "es", "pt", "pl", "ru",
		"tr", "ja"
	};

	public static void GetDefaultLanguage()
	{
		if (LoadCustomerSelectedItem() != "Accept")
		{
			CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
			CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
			bool flag = false;
			CultureInfo[] array = cultures;
			foreach (CultureInfo cultureInfo in array)
			{
				if (cultureInfo.ToString().Trim().ToLower() == currentCulture.ToString().Trim().ToLower())
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				string text = "en";
				try
				{
					text = currentCulture.ToString();
				}
				catch
				{
					text = "en";
				}
				if (!string.IsNullOrEmpty(text))
				{
					string empty = string.Empty;
					if (!string.IsNullOrEmpty(currentCulture.ToString().ToLower()))
					{
						empty = currentCulture.ToString().ToLower();
						if (!empty.StartsWith("ja-") && !empty.Equals("ja"))
						{
							if (!empty.StartsWith("es-") && !empty.Equals("es"))
							{
								if (empty.StartsWith("zh-tw"))
								{
									text = "zh-cht";
								}
								else if (empty.StartsWith("zh-cn"))
								{
									text = "zh-chs";
								}
								else if (!empty.StartsWith("fr-") && !empty.Equals("fr"))
								{
									if (!empty.StartsWith("it-") && !empty.Equals("it"))
									{
										if (!empty.StartsWith("de-") && !empty.Equals("de"))
										{
											if (!empty.StartsWith("pt-") && !empty.Equals("pt"))
											{
												if (!empty.StartsWith("en-") && !empty.Equals("en"))
												{
													if (!empty.StartsWith("pl-") && !empty.Equals("pl"))
													{
														if (!empty.StartsWith("tr-") && !empty.Equals("tr"))
														{
															if (empty.StartsWith("ru-") || empty.Equals("ru"))
															{
																text = "ru";
															}
														}
														else
														{
															text = "tr";
														}
													}
													else
													{
														text = "pl";
													}
												}
												else
												{
													text = "en";
												}
											}
											else
											{
												text = "pt";
											}
										}
										else
										{
											text = "de";
										}
									}
									else
									{
										text = "it";
									}
								}
								else
								{
									text = "fr";
								}
							}
							else
							{
								text = "es";
							}
						}
						else
						{
							text = "ja";
						}
					}
					string[] array2 = strLanguageCode;
					foreach (string text2 in array2)
					{
						if (text.Trim().ToLower() == text2.Trim().ToLower())
						{
							SystemInfo.DefaultLanguage = text2;
							WriteDefaultLanguage(strAppConfigPath, text2);
							break;
						}
					}
				}
			}
			else
			{
				SystemInfo.DefaultLanguage = "en";
			}
		}
		else
		{
			string nodeName = "//AppLanguage/DefaultLanguage";
			SystemInfo.DefaultLanguage = ReadDefaultLanguage(strAppConfigPath, nodeName);
			if (string.IsNullOrEmpty(SystemInfo.DefaultLanguage))
			{
				SystemInfo.DefaultLanguage = "en";
			}
		}
		MyResourceManager.InitResource();
	}

	public static string ReadDefaultLanguage(string strFullPath, string nodeName)
	{
		string empty = string.Empty;
		if (nodeName == "UpdateWhatsNew")
		{
			nodeName = "WhatsNew";
		}
		empty = string.Empty;
		XmlReader xmlReader = new XmlTextReader(strFullPath);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(xmlReader);
		XmlNode documentElement = xmlDocument.DocumentElement;
		XmlNode xmlNode = documentElement.SelectSingleNode(nodeName);
		if (xmlNode != null)
		{
			empty = xmlNode.InnerText;
		}
		xmlReader.Close();
		return empty;
	}

	public static void WriteDefaultLanguage(string strFullPath, string nodeValue)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(strFullPath);
			if (fileInfo.Exists)
			{
				fileInfo.Attributes = FileAttributes.Normal;
			}
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

	public static string LoadCustomerSelectedItem()
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(strAppConfigPath);
			XmlNode xmlNode = xmlDocument.DocumentElement!.SelectSingleNode("/Root");
			foreach (XmlNode item in xmlNode)
			{
				if (item.Name == "CustomerSelected")
				{
					return (item.Attributes!["SelectedItemName"]!.Value == null) ? "" : item.Attributes!["SelectedItemName"]!.Value;
				}
			}
			return "";
		}
		catch
		{
			return string.Empty;
		}
	}

	public static Hashtable ReadResource(string frmName, string lang)
	{
		Hashtable hashtable = new Hashtable();
		XmlReader xmlReader = null;
		FileInfo fileInfo = new FileInfo(Application.get_StartupPath() + "\\..\\..\\Config\\AppResource_" + lang + ".xml");
		xmlReader = (fileInfo.Exists ? new XmlTextReader(Application.get_StartupPath() + "\\..\\..\\Config\\AppResource_" + lang + ".xml") : new XmlTextReader("resources/AppResource.xml"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(xmlReader);
		XmlNode documentElement = xmlDocument.DocumentElement;
		string xpath = "Form[Name='" + frmName + "']/Controls/Control";
		XmlNodeList xmlNodeList = documentElement.SelectNodes(xpath);
		foreach (XmlNode item in xmlNodeList)
		{
			try
			{
				XmlNode xmlNode2 = item.SelectSingleNode("@name");
				XmlNode xmlNode3 = item.SelectSingleNode("@text");
				if (xmlNode2 != null)
				{
					hashtable.Add(xmlNode2.InnerText.ToLower(), xmlNode3.InnerText);
				}
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
		xmlReader.Close();
		return hashtable;
	}

	public static void SetupText(Control ct, string strVariableName)
	{
		if (ct != null && SystemInfo.MyCulture != null)
		{
			ct.set_Text(SystemInfo.MyResManager.GetString(strVariableName, SystemInfo.MyCulture));
		}
	}

	public static void SetupText(ListViewItem ct, string strVariableName)
	{
		if (ct != null && SystemInfo.MyCulture != null)
		{
			ct.set_Text(SystemInfo.MyResManager.GetString(strVariableName, SystemInfo.MyCulture));
		}
	}

	public static void SetupToolTipsText(ListViewItem ct, string strVariableName)
	{
		if (ct != null && SystemInfo.MyCulture != null)
		{
			ct.set_ToolTipText(SystemInfo.MyResManager.GetString(strVariableName, SystemInfo.MyCulture));
		}
	}
}

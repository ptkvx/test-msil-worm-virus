using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace dgfgfgfgf;

[StandardModule]
internal sealed class Module1
{
	public static string GetPage(string pageUrl)
	{
		string result = "";
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(pageUrl);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			result = streamReader.ReadToEnd();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string ExtractBody(string page)
	{
		return Regex.Replace(page, ".*<body[^>]*>(.*)</body>.*", "$1", RegexOptions.IgnoreCase);
	}

	public static void Main()
	{
		string page = GetPage("http://yoururl.foo");
		ExtractBody(page);
	}

	public static void JuNk_KCn5x5()
	{
		new decimal(639262226L);
		new decimal(-1906460187L);
		while (true)
		{
			new decimal(1458363811L);
		}
	}

	public static void JuNk_Maken0xg8LcYOP1nl9()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		checked
		{
			for (int i = 657055; i <= 544014; i++)
			{
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					new decimal(-599250744L);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			for (int j = 9792984; j <= 4438625; j++)
			{
				try
				{
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	public static void JuNk_ZGe8o2()
	{
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			new decimal(2094495306L);
			ProjectData.ClearProjectError();
		}
		checked
		{
			for (int i = 9604228; i <= 1146233; i++)
			{
				new decimal(1563317091L);
				try
				{
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				new decimal(-424519722L);
				try
				{
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					new decimal(1173235849L);
					ProjectData.ClearProjectError();
				}
			}
			new decimal(-1579117878L);
			for (int j = 9229546; j <= 5382463; j++)
			{
				try
				{
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
				new decimal(122188085L);
				try
				{
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				new decimal(-1536874805L);
				ProjectData.ClearProjectError();
			}
			int num = 1737734;
			do
			{
				try
				{
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					new decimal(-412000272L);
					ProjectData.ClearProjectError();
				}
				num++;
			}
			while (num <= 4811889);
		}
	}
}

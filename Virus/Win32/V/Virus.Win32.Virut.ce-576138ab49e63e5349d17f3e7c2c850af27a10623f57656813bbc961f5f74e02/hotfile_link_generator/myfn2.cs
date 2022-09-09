using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace hotfile_link_generator;

internal class myfn2
{
	public static int findinarry(string[,] searched, string targed)
	{
		try
		{
			int length = searched.GetLength(0);
			int length2 = searched.GetLength(1);
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					if (searched[i, j] == targed)
					{
						return i;
					}
				}
			}
			return -1;
		}
		catch
		{
			return -1;
		}
	}

	public static int findinarry(string[] searched, string targed)
	{
		int num = 0;
		while (true)
		{
			if (num < searched.Length)
			{
				if (searched[num] == targed)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public static string DownloadWebPage(string strURL)
	{
		WebRequest webRequest = WebRequest.Create(strURL);
		WebResponse response = webRequest.GetResponse();
		Stream responseStream = response.GetResponseStream();
		Encoding encoding = Encoding.GetEncoding("utf-8");
		StreamReader streamReader = new StreamReader(responseStream, encoding);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		response.Close();
		return result;
	}

	public static string stringpart(string main, string search_Start, string search_end)
	{
		if (main.Contains(search_Start))
		{
			main = main.Substring(main.IndexOf(search_Start) + search_Start.Length);
			if (main.Contains(search_end))
			{
				main = main.Substring(0, main.IndexOf(search_end));
				return main;
			}
		}
		return "";
	}

	public static string cut_this(ref string mainstring, string separate)
	{
		string text = mainstring;
		try
		{
			text = mainstring.Substring(0, mainstring.IndexOf(separate));
			mainstring = mainstring.Substring(mainstring.IndexOf(separate) + separate.Length);
		}
		catch
		{
			return null;
		}
		return text;
	}

	public static int string_count(string mainstrig, string ch)
	{
		int num = -1;
		int num2 = 0;
		for (num = mainstrig.IndexOf(ch); num != -1; num = mainstrig.IndexOf(ch))
		{
			num2++;
			mainstrig = mainstrig.Substring(num + 1);
		}
		return num2;
	}

	public static bool vaildip(string ip)
	{
		int num = string_count(ip, ".");
		if (num != 3)
		{
			return false;
		}
		if (ip[ip.Length - 1] == '.')
		{
			return false;
		}
		for (int i = 0; i < 3; i++)
		{
			try
			{
				num = Convert.ToInt32(cut_this(ref ip, "."));
			}
			catch
			{
				return false;
			}
		}
		return true;
	}

	public static bool vaildno(string number)
	{
		try
		{
			Convert.ToInt32(number);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool vaildmib(string mib)
	{
		if (mib[mib.Length - 1] == '.')
		{
			return false;
		}
		int num = string_count(mib, ".");
		for (int i = 0; i < num; i++)
		{
			try
			{
				Convert.ToInt32(cut_this(ref mib, "."));
			}
			catch
			{
				return false;
			}
		}
		return true;
	}

	public static int findinarraylist(ArrayList serachedarray, string targed)
	{
		if (!serachedarray.Contains(targed))
		{
			return -1;
		}
		int num = 0;
		while (true)
		{
			if (num < serachedarray.Count)
			{
				if (serachedarray[num]!.ToString() == targed)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	private static string intarr_to_ip(int[] ip_int)
	{
		return ip_int[0].ToString() + '.' + ip_int[1].ToString() + '.' + ip_int[2].ToString() + '.' + ip_int[3].ToString();
	}

	public static string incrementIP(string ip)
	{
		int[] array = ipIntoArray(ip);
		if (array[3] >= 255)
		{
			array[3] = 1;
			array[2]++;
			if (array[2] >= 255)
			{
				array[2] = 1;
				array[1]++;
				if (array[1] >= 255)
				{
					array[1] = 1;
					array[0]++;
				}
			}
		}
		else
		{
			array[3]++;
		}
		return intarr_to_ip(array);
	}

	private static int[] ipIntoArray(string ip)
	{
		ip += '.';
		int[] array = new int[4];
		int num = ip.IndexOf('.');
		for (int i = 0; i < 4; i++)
		{
			array[i] = Convert.ToInt32(ip.Substring(0, num));
			ip = ip.Substring(num + 1);
			num = ip.IndexOf('.');
		}
		return array;
	}

	public static bool FindAndKillProcess(string name)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.StartsWith(name))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		process.Kill();
		return true;
	}

	public static bool FindAndKillProcess2(string name)
	{
		bool flag = false;
		Process[] processesByName = Process.GetProcessesByName(name);
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
			flag = true;
		}
		if (flag)
		{
			return true;
		}
		return false;
	}

	public static bool isWorkingProcess(string name)
	{
		Process[] processesByName = Process.GetProcessesByName(name);
		Process[] array = processesByName;
		if (0 >= array.Length)
		{
			return false;
		}
		return true;
	}

	public static string findFileNameFromPath(string path)
	{
		int num = path.LastIndexOf('\\');
		if (num == -1)
		{
			return path;
		}
		path = path.Substring(num + 1);
		if (path[path.Length - 4] == '.')
		{
			path = path.Substring(0, path.Length - 4);
		}
		return path;
	}
}

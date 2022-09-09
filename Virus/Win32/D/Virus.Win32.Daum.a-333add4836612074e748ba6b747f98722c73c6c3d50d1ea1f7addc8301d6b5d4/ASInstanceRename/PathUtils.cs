using System.IO;

namespace ASInstanceRename;

internal class PathUtils
{
	public static string MakeFullPath(string path, string fileName)
	{
		return Path.Combine(path, fileName);
	}

	public static string GetPathFromCommandLine(string commandLine)
	{
		commandLine = commandLine.Trim();
		int num = -1;
		bool flag = false;
		int i = 0;
		for (int length = commandLine.Length; i < length; i++)
		{
			switch (commandLine[i])
			{
			case ' ':
				if (flag)
				{
					continue;
				}
				break;
			case '"':
				flag = !flag;
				continue;
			default:
				continue;
			}
			num = i;
			break;
		}
		if (num >= 0)
		{
			commandLine = commandLine.Substring(0, num);
		}
		commandLine = commandLine.Replace("\"", string.Empty);
		return Path.GetDirectoryName(commandLine);
	}
}

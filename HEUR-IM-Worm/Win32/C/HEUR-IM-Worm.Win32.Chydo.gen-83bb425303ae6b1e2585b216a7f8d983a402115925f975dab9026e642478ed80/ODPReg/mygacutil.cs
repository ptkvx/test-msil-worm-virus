using System;

namespace ODPReg;

internal class mygacutil
{
	[STAThread]
	private static void Main(string[] args)
	{
		string text = null;
		try
		{
			bool flag;
			if (args.Length == 1)
			{
				text = args[0];
				flag = true;
			}
			else
			{
				if (args.Length != 2 || string.Compare(args[1], "/u") != 0)
				{
					return;
				}
				text = args[0];
				flag = false;
			}
			if (flag)
			{
				RegUtility.RegFile(text);
				return;
			}
			string fileRegInfo = RegUtility.GetFileRegInfo(text);
			RegUtility.UnRegFile(fileRegInfo);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}

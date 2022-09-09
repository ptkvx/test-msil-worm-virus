using System;
using System.Text;
using System.Text.RegularExpressions;

namespace AntiHack;

public class Helper
{
	public static void DumpBytes(byte[] dumpdBlock, string sMsg, int dumpdBlockLen)
	{
		int num = 16;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string.Format("=> Begin Dump. {0}; {1}\n", sMsg, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
		while (num3 != dumpdBlockLen)
		{
			stringBuilder.Append(string.Format("{0} ", (num2 * num).ToString("X4")));
			string text = string.Empty;
			for (num4 = 0; num4 < num; num4++)
			{
				if (dumpdBlock[num3] < 128)
				{
					char c = (char)dumpdBlock[num3];
					text = ((!char.IsLetterOrDigit(c) && !char.IsPunctuation(c)) ? (text + ".") : (text + char.ToString(c)));
				}
				else
				{
					text += ".";
				}
				stringBuilder.Append(string.Format("{0} ", dumpdBlock[num3++].ToString("X2")));
				if (num3 == dumpdBlockLen)
				{
					break;
				}
			}
			if (num4 < num)
			{
				for (int i = num4 + 1; i < num; i++)
				{
					stringBuilder.Append("   ");
				}
			}
			stringBuilder.Append($"|{text}\n");
			num2++;
		}
		stringBuilder.Append("=> End Dump.\n");
		SrvrRedirectorSocket.OnServerDumpDataEventHandler(new ServerDumpDataEventArgs(stringBuilder.ToString()));
	}

	public static bool IsHostDottedQuad(string sHost)
	{
		Regex regex = new Regex("(?<ip_addr_full_quad>(?<ip_addr_First>2[0-4]\\d|25[0-5]|[01]?\\d\\d?)\\.(?<ip_addr_Second>2[0-4]\\d|25[0-5]|[01]?\\d\\d?)\\.(?<ip_addr_Third>2[0-4]\\d|25[0-5]|[01]?\\d\\d?)\\.(?<ip_addr_Fourth>2[0-4]\\d|25[0-5]|[01]?\\d\\d?))", RegexOptions.Compiled);
		Match match = regex.Match(sHost);
		if (match.Success)
		{
			return true;
		}
		return false;
	}
}

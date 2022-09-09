using System;
using System.IO;

namespace DsLauncher;

internal class UILoger
{
	private static StreamWriter FILE_4_LOG_STREAM_WRITER;

	private static string FILE_PATH = "DSLog.log";

	private static string LOG_FORMAT = "{0}:{1}";

	public static bool Log(string text2Log)
	{
		if (FILE_4_LOG_STREAM_WRITER == null)
		{
			try
			{
				if (File.Exists(FILE_PATH))
				{
					File.Delete(FILE_PATH);
				}
				FILE_4_LOG_STREAM_WRITER = File.AppendText(FILE_PATH);
			}
			catch
			{
				return false;
			}
		}
		try
		{
			FILE_4_LOG_STREAM_WRITER.WriteLine(string.Format(LOG_FORMAT, new object[2]
			{
				DateTime.Now.ToString(),
				text2Log
			}));
			FILE_4_LOG_STREAM_WRITER.Flush();
			return true;
		}
		catch
		{
			return false;
		}
	}
}

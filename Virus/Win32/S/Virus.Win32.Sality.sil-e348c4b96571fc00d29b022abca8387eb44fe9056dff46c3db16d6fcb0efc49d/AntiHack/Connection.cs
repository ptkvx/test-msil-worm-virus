using System;
using System.Net.Sockets;

namespace AntiHack;

public class Connection
{
	private Socket _sock;

	private int _port = -1;

	private string sHostName = string.Empty;

	private string sRedirectHost = string.Empty;

	private int _redirPort = -1;

	private bool _verboseFlag = false;

	private bool _doDump = false;

	public string TargetConnectionIPAddr
	{
		get
		{
			return sRedirectHost;
		}
		set
		{
			sRedirectHost = value;
		}
	}

	public int TargetConnectionPort
	{
		get
		{
			return _redirPort;
		}
		set
		{
			_redirPort = value;
		}
	}

	public Connection(Socket sock, int port, bool verboseFlag, bool doDump)
	{
		_sock = sock;
		_port = port;
		_verboseFlag = verboseFlag;
		_doDump = doDump;
	}

	public Connection(string hostName, int port)
	{
		sHostName = hostName.ToLower();
		_port = port;
	}

	public void cbHandleIncomingExternalConnection(IAsyncResult result)
	{
		ConnectionDetails connectionDetails = new ConnectionDetails();
		try
		{
			Socket socket = (Socket)result.AsyncState;
			connectionDetails.ConnectionSocketExternal = socket.EndAccept(result);
			connectionDetails.ConnectionExternalBuffer = new byte[SrvrRedirectorSocket._StaticBufferSize];
			connectionDetails.ConnectionInternalBuffer = new byte[SrvrRedirectorSocket._StaticBufferSize];
			connectionDetails.ConnectionBegan = DateTime.Now;
			SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs(string.Format("CON> {0} connected on {1}.", connectionDetails.ToString(), DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))));
			if (connectionDetails.OpenInternalConnection(sRedirectHost, _redirPort))
			{
				connectionDetails.ConnectionSocketExternal.BeginReceive(connectionDetails.ConnectionExternalBuffer, 0, connectionDetails.ConnectionExternalBuffer.Length, SocketFlags.None, cbHandleIncomingExternalTraffic, connectionDetails);
				connectionDetails.ConnectionSocketInternal.BeginReceive(connectionDetails.ConnectionInternalBuffer, 0, connectionDetails.ConnectionInternalBuffer.Length, SocketFlags.None, cbHandleIncomingInternalTraffic, connectionDetails);
				SrvrRedirectorSocket._StaticSockRedir.BeginAccept(cbHandleIncomingExternalConnection, result.AsyncState);
			}
		}
		catch (SocketException ex)
		{
			if (ex.NativeErrorCode == 10053 || ex.NativeErrorCode == 10054)
			{
				SrvrRedirectorSocket.CloseConnection(connectionDetails);
			}
			else
			{
				SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR> Socket Exception @ cbHandleIncomingConnection(...); Message: {ex.Message}"));
			}
		}
		catch (InvalidOperationException)
		{
			SrvrRedirectorSocket.CloseConnection(connectionDetails);
		}
		catch (Exception)
		{
			SrvrRedirectorSocket.CloseConnection(connectionDetails);
			SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"CON> {connectionDetails.ToString()} connected on {DateTime.Now.ToUniversalTime()} (UTC)."));
		}
	}

	public void cbHandleIncomingExternalTraffic(IAsyncResult result)
	{
		ConnectionDetails connectionDetails = (ConnectionDetails)result.AsyncState;
		bool flag = false;
		try
		{
			int num = -1;
			try
			{
				num = connectionDetails.ConnectionSocketExternal.EndReceive(result);
			}
			catch (ObjectDisposedException)
			{
				flag = true;
			}
			catch (InvalidOperationException)
			{
				flag = true;
			}
			catch (Exception)
			{
				flag = true;
			}
			if (flag)
			{
				return;
			}
			if (connectionDetails.ConnectionSocketExternal.Available == 0 && num == 0)
			{
				SrvrRedirectorSocket.CloseConnection(connectionDetails);
			}
			else if (num != 0)
			{
				if (_verboseFlag)
				{
					SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"RCV> [srcIPAddr] <{'{'}---- {num} Bytes ----= [{connectionDetails.ConnectionSocketExternal.RemoteEndPoint!.ToString()}]"));
				}
				connectionDetails.ConnectionBytesReceived += num;
				if (_doDump)
				{
					Helper.DumpBytes(connectionDetails.ConnectionExternalBuffer, connectionDetails.ConnectionSocketExternal.RemoteEndPoint!.ToString(), num);
				}
				connectionDetails.ConnectionSocketInternal.Send(connectionDetails.ConnectionExternalBuffer, 0, num, SocketFlags.None);
				if (_verboseFlag)
				{
					SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"SNT> [srcIPAddr] =---- {num} Bytes ----{'}'}> [dstIPAddr]"));
				}
				connectionDetails.ConnectionSocketExternal.BeginReceive(connectionDetails.ConnectionExternalBuffer, 0, connectionDetails.ConnectionExternalBuffer.Length, SocketFlags.None, cbHandleIncomingExternalTraffic, connectionDetails);
			}
		}
		catch (SocketException ex4)
		{
			if (ex4.NativeErrorCode == 10053 || ex4.NativeErrorCode == 10054)
			{
				SrvrRedirectorSocket.CloseConnection(connectionDetails);
			}
			else
			{
				SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR> Socket Exception @ cbHandleIncomingExternalTraffic(...); Message: {ex4.Message}"));
			}
		}
		catch (ObjectDisposedException)
		{
		}
		catch (Exception ex6)
		{
			SrvrRedirectorSocket.CloseConnection(connectionDetails);
			SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR> Exception @ cbHandleIncomingExternalTraffic(...); Message: {ex6.Message}"));
		}
	}

	public void cbHandleIncomingInternalTraffic(IAsyncResult result)
	{
		ConnectionDetails connectionDetails = (ConnectionDetails)result.AsyncState;
		bool flag = false;
		try
		{
			int num = -1;
			try
			{
				num = connectionDetails.ConnectionSocketInternal.EndReceive(result);
			}
			catch (ObjectDisposedException)
			{
				flag = true;
			}
			if (!flag && (connectionDetails.ConnectionSocketInternal.Available != 0 || num != 0) && num != 0)
			{
				if (_verboseFlag)
				{
					SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"RCV> [srcIPAddr] <{'{'}---- {num} Bytes ----= [dstIPAddr]"));
				}
				connectionDetails.ConnectionSocketExternal.Send(connectionDetails.ConnectionInternalBuffer, 0, num, SocketFlags.None);
				if (_verboseFlag)
				{
					SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"SNT> [srcIPAddr] =---- {num} Bytes ---{'}'}> [{connectionDetails.ConnectionSocketExternal.RemoteEndPoint!.ToString()}]"));
				}
				if (_doDump)
				{
					Helper.DumpBytes(connectionDetails.ConnectionInternalBuffer, connectionDetails.ConnectionSocketInternal.RemoteEndPoint!.ToString(), num);
				}
				connectionDetails.ConnectionBytesSent += num;
				connectionDetails.ConnectionSocketInternal.BeginReceive(connectionDetails.ConnectionInternalBuffer, 0, connectionDetails.ConnectionInternalBuffer.Length, SocketFlags.None, cbHandleIncomingInternalTraffic, connectionDetails);
			}
		}
		catch (SocketException ex2)
		{
			if (ex2.NativeErrorCode == 10053 || ex2.NativeErrorCode == 10054)
			{
				SrvrRedirectorSocket.CloseConnection(connectionDetails);
			}
			else
			{
				SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR> Socket Exception @ cbHandleIncomingTrafficServer(...); Message: {ex2.Message}"));
			}
		}
		catch (ObjectDisposedException)
		{
		}
		catch (Exception ex4)
		{
			SrvrRedirectorSocket.CloseConnection(connectionDetails);
			SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR> Exception @ cbHandleIncomingTrafficServer(...); Message: {ex4.Message}"));
		}
	}
}

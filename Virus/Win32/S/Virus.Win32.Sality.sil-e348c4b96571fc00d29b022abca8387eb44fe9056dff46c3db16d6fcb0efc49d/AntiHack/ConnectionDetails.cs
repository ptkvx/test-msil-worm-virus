using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace AntiHack;

public class ConnectionDetails : IDisposable
{
	private Socket extSocket = null;

	private Socket intSocket = null;

	private IPEndPoint extEp = null;

	private byte[] bBufExt = null;

	private byte[] bBufInt = null;

	private bool bIntSocketOk = false;

	private long lBytesSent = 0L;

	private long lBytesReceived = 0L;

	private DateTime dtBeginRedirecting;

	private DateTime dtEndRedirecting;

	private bool disposed = false;

	public Socket ConnectionSocketExternal
	{
		get
		{
			return extSocket;
		}
		set
		{
			SetUpConnectionExternalEndPoint(value);
		}
	}

	public Socket ConnectionSocketInternal => intSocket;

	public IPAddress ConnectionExternalAddress => extEp.Address;

	public int ConnectionExternalPort => extEp.Port;

	public byte[] ConnectionExternalBuffer
	{
		get
		{
			return bBufExt;
		}
		set
		{
			bBufExt = value;
		}
	}

	public byte[] ConnectionInternalBuffer
	{
		get
		{
			return bBufInt;
		}
		set
		{
			bBufInt = value;
		}
	}

	public long ConnectionBytesSent
	{
		get
		{
			return lBytesSent;
		}
		set
		{
			lBytesSent = value;
		}
	}

	public long ConnectionBytesReceived
	{
		get
		{
			return lBytesReceived;
		}
		set
		{
			lBytesReceived = value;
		}
	}

	public bool ConnectionSocketInternalOk => bIntSocketOk;

	public DateTime ConnectionBegan
	{
		get
		{
			return dtBeginRedirecting;
		}
		set
		{
			dtBeginRedirecting = value;
		}
	}

	public DateTime ConnectionEnded
	{
		get
		{
			return dtEndRedirecting;
		}
		set
		{
			dtEndRedirecting = value;
		}
	}

	~ConnectionDetails()
	{
		Dispose(disposing: true);
	}

	private void SetUpConnectionExternalEndPoint(Socket _sock)
	{
		extSocket = _sock;
		extEp = (IPEndPoint)extSocket.RemoteEndPoint;
	}

	public bool OpenInternalConnection(string DestIPAddr, int DestIPPort)
	{
		try
		{
			string text = DestIPAddr.ToLower();
			IPHostEntry iPHostEntry = null;
			try
			{
				if (Helper.IsHostDottedQuad(text))
				{
					try
					{
						iPHostEntry = Dns.GetHostByAddress(text);
					}
					catch
					{
						iPHostEntry = Dns.GetHostEntry(text);
					}
				}
				else
				{
					iPHostEntry = Dns.GetHostEntry(text);
				}
			}
			catch (SocketException)
			{
				SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($">> Unable to resolve {text}. Terminating."));
				return false;
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
			IPEndPoint iPEndPoint = new IPEndPoint(iPHostEntry.AddressList[num], DestIPPort);
			intSocket = new Socket(iPEndPoint.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			intSocket.Connect(iPEndPoint);
			bIntSocketOk = true;
		}
		catch (SocketException ex2)
		{
			if (ex2.NativeErrorCode != 10053 && ex2.NativeErrorCode != 10054)
			{
				if (ex2.NativeErrorCode == 10061)
				{
					SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR>> Could not connect to [{DestIPAddr}:{DestIPPort}]"));
				}
				else
				{
					SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR>> Socket Exception @ OpenInternalConnection(...); #[{ex2.NativeErrorCode}] Message: {ex2.Message}"));
				}
			}
			bIntSocketOk = false;
		}
		catch (Exception ex3)
		{
			SrvrRedirectorSocket.OnServerMessagesEventHandler(new ServerMessagesEventArgs($"ERR> Exception @ OpenInternalConnection(...); Message: {ex3.Message}"));
			bIntSocketOk = false;
		}
		return bIntSocketOk;
	}

	public override bool Equals(object obj)
	{
		if (obj is ConnectionDetails connectionDetails)
		{
			if (ConnectionExternalAddress == connectionDetails.ConnectionExternalAddress && ConnectionExternalPort.Equals(connectionDetails.ConnectionExternalPort) && ConnectionSocketExternal.Equals(connectionDetails.ConnectionSocketExternal))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return GetHashCode();
	}

	public override string ToString()
	{
		return $"[{extEp.Address.ToString()}:{extEp.Port}]";
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (!disposed)
		{
			if (intSocket != null)
			{
				try
				{
					intSocket.Shutdown(SocketShutdown.Both);
					intSocket.Close();
				}
				catch
				{
					MessageBox.Show("Unexpected error. Try again");
				}
			}
			if (extSocket != null)
			{
				try
				{
					extSocket.Shutdown(SocketShutdown.Both);
					extSocket.Close();
				}
				catch
				{
					MessageBox.Show("Unexpected error. Try again");
				}
			}
			extEp = null;
			bBufExt = null;
			bBufInt = null;
			if (disposing)
			{
			}
		}
		disposed = true;
	}
}

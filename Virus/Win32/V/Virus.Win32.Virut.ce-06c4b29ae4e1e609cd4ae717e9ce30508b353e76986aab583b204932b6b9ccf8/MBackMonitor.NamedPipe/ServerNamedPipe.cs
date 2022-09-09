using System;
using System.Threading;
using Arbus.Common.NamedPipe;

namespace MBackMonitor.NamedPipe;

public sealed class ServerNamedPipe : IDisposable
{
	internal Thread PipeThread;

	internal ServerPipeConnection PipeConnection;

	internal bool Listen = true;

	internal DateTime LastAction;

	private bool disposed = false;

	private int _iMessageId = 0;

	public event MessageReceived OnMessageReceived;

	private void PipeListener()
	{
		CheckIfDisposed();
		try
		{
			while (Listen)
			{
				LastAction = DateTime.Now;
				string text = ((APipeConnection)PipeConnection).Read();
				LastAction = DateTime.Now;
				if (text.Trim() != string.Empty)
				{
					_iMessageId++;
					if (this.OnMessageReceived != null)
					{
						this.OnMessageReceived(this, new MessageString(_iMessageId, text));
					}
				}
				LastAction = DateTime.Now;
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			PipeThread = null;
		}
	}

	internal void Connect()
	{
		CheckIfDisposed();
		((APipeConnection)PipeConnection).Connect();
	}

	internal void Close()
	{
		CheckIfDisposed();
		Listen = false;
		Dispose();
	}

	internal void Start()
	{
		CheckIfDisposed();
		Listen = true;
		PipeThread = new Thread(PipeListener);
		PipeThread.IsBackground = true;
		PipeThread.Name = "Pipe Thread " + ((APipeConnection)PipeConnection).get_NativeHandle();
		PipeThread.Start();
	}

	private void CheckIfDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("ServerNamedPipe");
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (!disposed)
		{
			((APipeConnection)PipeConnection).Dispose();
			if (PipeThread != null)
			{
				try
				{
					PipeThread.Abort();
				}
				catch (ThreadAbortException)
				{
				}
				catch (ThreadStateException)
				{
				}
				catch (Exception)
				{
				}
			}
		}
		disposed = true;
	}

	~ServerNamedPipe()
	{
		Dispose(disposing: false);
	}

	internal void Disconnect()
	{
		Listen = false;
		PipeConnection.Disconnect();
		PipeThread = null;
	}

	internal ServerNamedPipe(string name, uint outBuffer, uint inBuffer, int maxReadBytes, bool secure)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		PipeConnection = new ServerPipeConnection(name, outBuffer, inBuffer, maxReadBytes, secure);
		LastAction = DateTime.Now;
	}
}

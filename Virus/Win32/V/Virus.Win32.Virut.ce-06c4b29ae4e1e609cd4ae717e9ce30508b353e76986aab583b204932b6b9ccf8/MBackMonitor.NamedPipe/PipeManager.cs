using System;
using System.Threading;
using Arbus.Common.NamedPipe;
using Arbus.Common.NamedPipe.InterProcessComm;

namespace MBackMonitor.NamedPipe;

public sealed class PipeManager
{
	private const int MAX_READ_BYTES = 5000;

	private uint OutBuffer = 512u;

	private uint InBuffer = 512u;

	private bool _listen = true;

	private ServerNamedPipe _serverPipe = null;

	private Thread MainThread;

	private bool isMessageRecieveStarted = false;

	public bool Listen
	{
		get
		{
			return _listen;
		}
		set
		{
			_listen = value;
		}
	}

	public event MessageReceived OnMessageRecieved;

	public PipeManager()
	{
		_serverPipe = new ServerNamedPipe("F3431557-F808-4dbd-9B23-BE093C2738A1", OutBuffer, InBuffer, 5000, secure: false);
		_serverPipe.OnMessageReceived += _serverPipe_OnMessageReceived;
		MainThread = new Thread(Start);
		MainThread.IsBackground = true;
		MainThread.Name = "Main Pipe Thread";
		MainThread.Start();
	}

	private void Start()
	{
		try
		{
			while (_listen)
			{
				try
				{
					_serverPipe.Connect();
					if (!_listen)
					{
						break;
					}
				}
				catch (InterProcessIOException)
				{
					_serverPipe.Dispose();
				}
				catch (Exception)
				{
				}
				_serverPipe.LastAction = DateTime.Now;
				_serverPipe.Start();
				MainThread.Suspend();
			}
		}
		finally
		{
			MainThread = null;
		}
	}

	public void Stop()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		_listen = false;
		_serverPipe.OnMessageReceived -= _serverPipe_OnMessageReceived;
		if (_serverPipe != null)
		{
			while ((int)((APipeConnection)_serverPipe.PipeConnection).GetState() == 5)
			{
				Thread.Sleep(2000);
			}
			StopServerPipe();
			_serverPipe.Close();
		}
	}

	public void WakeUp()
	{
		if (MainThread != null)
		{
			MainThread.Resume();
		}
	}

	private void StopServerPipe()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			ClientPipeConnection val = new ClientPipeConnection("F3431557-F808-4dbd-9B23-BE093C2738A1");
			if (val.TryConnect())
			{
				((APipeConnection)val).Close();
			}
		}
		catch
		{
		}
	}

	public void RemoveServerChannel(object param)
	{
	}

	private void _serverPipe_OnMessageReceived(ServerNamedPipe sender, MessageString eventargs)
	{
		if (eventargs.Message.Equals("Start-LoggedIn") && !isMessageRecieveStarted)
		{
			isMessageRecieveStarted = true;
		}
		else if (eventargs.Message.Equals("Stop-LoggedOff") && isMessageRecieveStarted)
		{
			isMessageRecieveStarted = false;
			_serverPipe.Disconnect();
			WakeUp();
		}
		else if (isMessageRecieveStarted && this.OnMessageRecieved != null)
		{
			this.OnMessageRecieved(null, eventargs);
		}
	}
}

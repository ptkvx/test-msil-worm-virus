using System;

namespace AntiHack;

public class ServerMessagesEventArgs : EventArgs
{
	public readonly string ServerMessage;

	public ServerMessagesEventArgs(string _ServerMessage)
	{
		ServerMessage = _ServerMessage;
	}
}

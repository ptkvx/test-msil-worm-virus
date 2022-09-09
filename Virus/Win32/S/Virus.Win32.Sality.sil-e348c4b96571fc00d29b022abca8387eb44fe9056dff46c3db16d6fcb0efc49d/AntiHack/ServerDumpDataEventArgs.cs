using System;

namespace AntiHack;

public class ServerDumpDataEventArgs : EventArgs
{
	public readonly string ServerDumpData;

	public ServerDumpDataEventArgs(string _ServerDumpData)
	{
		ServerDumpData = _ServerDumpData;
	}
}

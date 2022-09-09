using System;

namespace AntiHack;

public class StatisticsEventArgs : EventArgs
{
	public readonly string Statistics;

	public StatisticsEventArgs(string _Statistics)
	{
		Statistics = _Statistics;
	}
}

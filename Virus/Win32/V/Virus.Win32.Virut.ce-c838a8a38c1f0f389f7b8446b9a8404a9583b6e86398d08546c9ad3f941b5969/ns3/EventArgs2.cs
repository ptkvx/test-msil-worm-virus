using System;
using System.Runtime.CompilerServices;

namespace ns3;

internal class EventArgs2 : EventArgs
{
	private Exception exception_0;

	[SpecialName]
	public Exception method_0()
	{
		return exception_0;
	}

	internal EventArgs2(Exception exception_1)
	{
		exception_0 = exception_1;
	}
}

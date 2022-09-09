using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class13
{
	[DebuggerNonUserCode]
	public Class13()
	{
	}

	public static bool smethod_0()
	{
		if (Operators.CompareString(Environment.GetEnvironmentVariable("ProgramW6432"), "", false) != 0)
		{
			return true;
		}
		return false;
	}
}

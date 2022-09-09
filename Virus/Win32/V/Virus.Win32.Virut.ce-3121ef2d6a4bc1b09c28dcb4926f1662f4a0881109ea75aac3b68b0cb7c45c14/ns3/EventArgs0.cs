using System;
using System.Runtime.CompilerServices;
using ns2;

namespace ns3;

internal sealed class EventArgs0 : EventArgs
{
	private Enum0 enum0_0;

	private bool bool_0;

	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	[SpecialName]
	public void method_0(string string_2)
	{
		string_1 = string_2;
	}

	internal EventArgs0(Enum0 enum0_1)
		: this(enum0_1, string.Empty)
	{
	}

	internal EventArgs0(Enum0 enum0_1, string string_2)
	{
		enum0_0 = enum0_1;
		bool_0 = string_2 != null && string_2.Length > 0;
		string_0 = string_2;
	}
}

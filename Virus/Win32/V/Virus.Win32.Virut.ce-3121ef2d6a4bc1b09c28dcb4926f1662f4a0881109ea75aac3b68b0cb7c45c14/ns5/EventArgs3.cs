using System;
using System.Runtime.CompilerServices;
using ns3;

namespace ns5;

internal sealed class EventArgs3 : EventArgs
{
	private Class16 class16_0;

	private Exception exception_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3;

	internal void method_0()
	{
		bool_0 = true;
	}

	internal void method_1()
	{
		bool_1 = false;
	}

	internal void method_2()
	{
		bool_2 = false;
	}

	[SpecialName]
	public bool method_3()
	{
		return bool_3;
	}

	[SpecialName]
	public void method_4(bool bool_4)
	{
		bool_3 = bool_4;
	}

	public bool method_5()
	{
		if (!bool_1)
		{
			return false;
		}
		return class16_0.method_15();
	}

	internal EventArgs3(Class16 class16_1, Exception exception_1)
	{
		class16_0 = class16_1;
		exception_0 = exception_1;
	}
}

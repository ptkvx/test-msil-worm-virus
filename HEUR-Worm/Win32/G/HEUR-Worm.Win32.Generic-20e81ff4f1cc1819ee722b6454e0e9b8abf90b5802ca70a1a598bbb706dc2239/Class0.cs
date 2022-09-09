using System;
using My.Resources;

internal sealed class Class0
{
	public static void smethod_0()
	{
		AppDomain.CurrentDomain.Load(Resources.Byte_0).GetType("L1.Class1")!.GetMethod("Main")!.Invoke(null, new object[0]);
	}

	public static void Main()
	{
		smethod_0();
	}
}

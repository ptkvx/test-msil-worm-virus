using System;
using System.Runtime.InteropServices;
using ns13;
using ns14;
using ns8;
using ns9;

namespace ns11;

internal sealed class Class30 : Class25
{
	private delegate IntPtr Delegate8(IntPtr intptr_0, IntPtr intptr_1);

	private delegate IntPtr Delegate9(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	private delegate int Delegate10(IntPtr intptr_0, IntPtr intptr_1);

	private delegate IntPtr Delegate11(IntPtr intptr_0);

	private Delegate9 delegate9_0;

	private Delegate8 delegate8_0;

	private Delegate11 delegate11_0;

	private Delegate10 delegate10_0;

	public Class30()
	{
		Class35.smethod_0();
		base._002Ector();
		Class24.class25_0 = new Class32();
		delegate9_0 = (Delegate9)Class24.class25_0.vmethod_0(new object[3]
		{
			Class34.smethod_0(374),
			Class34.smethod_0(394),
			typeof(Delegate9)
		});
		delegate8_0 = (Delegate8)Class24.class25_0.vmethod_0(new object[3]
		{
			Class34.smethod_0(424),
			Class34.smethod_0(444),
			typeof(Delegate8)
		});
		delegate11_0 = (Delegate11)Class24.class25_0.vmethod_0(new object[3]
		{
			Class34.smethod_0(472),
			Class34.smethod_0(492),
			typeof(Delegate11)
		});
		delegate10_0 = (Delegate10)Class24.class25_0.vmethod_0(new object[3]
		{
			Class34.smethod_0(520),
			Class34.smethod_0(540),
			typeof(Delegate10)
		});
	}

	public override object vmethod_0(object[] object_0)
	{
		byte[] array = new byte[0];
		object result;
		try
		{
			IntPtr intptr_ = delegate9_0(IntPtr.Zero, (IntPtr)(int)object_0[0], (IntPtr)4);
			IntPtr intptr_2 = delegate8_0(IntPtr.Zero, intptr_);
			IntPtr source = delegate11_0(intptr_2);
			int num = delegate10_0(IntPtr.Zero, intptr_);
			array = new byte[num];
			Marshal.Copy(source, array, 0, num);
		}
		catch
		{
			result = array;
			goto IL_0077;
		}
		return array;
		IL_0077:
		return result;
	}
}

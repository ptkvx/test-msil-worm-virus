using System;
using ns6;
using ns7;

namespace ns3;

internal sealed class Class24 : Class23
{
	private delegate uint Delegate1(IntPtr intptr_0, IntPtr intptr_1);

	private delegate int Delegate2(IntPtr intptr_0, IntPtr intptr_1);

	private delegate int Delegate3(IntPtr intptr_0, IntPtr intptr_1);

	private delegate int Delegate4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_0, IntPtr intptr_3);

	private delegate IntPtr Delegate5(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, uint uint_2);

	private delegate bool Delegate6(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, byte[] byte_0, int[] int_0);

	private delegate uint Delegate7(IntPtr intptr_0, IntPtr intptr_1);

	private Delegate6 delegate6_0;

	private Delegate5 delegate5_0;

	private Delegate1 delegate1_0;

	private Delegate4 delegate4_0;

	private Delegate2 delegate2_0;

	private Delegate3 delegate3_0;

	private Delegate7 delegate7_0;

	public Class24()
	{
		Class33.smethod_0();
		base._002Ector();
		Class22.class23_0 = new Class30();
		delegate6_0 = (Delegate6)Class22.class23_0.vmethod_0(new object[3]
		{
			Class32.smethod_0(0),
			Class32.smethod_0(20),
			typeof(Delegate6)
		});
		delegate5_0 = (Delegate5)Class22.class23_0.vmethod_0(new object[3]
		{
			Class32.smethod_0(52),
			Class32.smethod_0(72),
			typeof(Delegate5)
		});
		delegate1_0 = (Delegate1)Class22.class23_0.vmethod_0(new object[3]
		{
			Class32.smethod_0(104),
			Class32.smethod_0(118),
			typeof(Delegate1)
		});
		delegate4_0 = (Delegate4)Class22.class23_0.vmethod_0(new object[3]
		{
			Class32.smethod_0(162),
			Class32.smethod_0(176),
			typeof(Delegate4)
		});
		delegate2_0 = (Delegate2)Class22.class23_0.vmethod_0(new object[3]
		{
			Class32.smethod_0(220),
			Class32.smethod_0(234),
			typeof(Delegate2)
		});
		delegate3_0 = (Delegate3)Class22.class23_0.vmethod_0(new object[3]
		{
			Class32.smethod_0(274),
			Class32.smethod_0(288),
			typeof(Delegate3)
		});
		delegate7_0 = (Delegate7)Class22.class23_0.vmethod_0(new object[3]
		{
			Class32.smethod_0(328),
			Class32.smethod_0(342),
			typeof(Delegate7)
		});
	}

	public unsafe override object vmethod_0(object[] object_0)
	{
		byte[] array = new byte[64];
		byte[] array2 = new byte[248];
		byte[] array3 = new byte[40];
		byte[] array4 = new byte[716];
		int[] array5 = new int[4];
		fixed (byte* ptr = &array[0])
		{
		}
		fixed (byte* ptr2 = &array2[0])
		{
		}
		fixed (byte* ptr3 = &array3[0])
		{
		}
		fixed (byte* ptr4 = &array4[0])
		{
		}
		string string_ = string.Join(Convert.ToChar(32).ToString(), (string[])object_0[1]);
		*(int*)ptr4 = 65543;
		Buffer.BlockCopy((byte[])object_0[0], 0, array, 0, array.Length);
		int num = *(int*)(ptr + 60);
		Buffer.BlockCopy((byte[])object_0[0], num, array2, 0, array2.Length);
		if (*(uint*)ptr2 == 17744 && *(ushort*)ptr == 23117)
		{
			int num2 = *(int*)(ptr2 + 52);
			if (!delegate6_0((string)object_0[2], string_, IntPtr.Zero, IntPtr.Zero, bool_0: false, 4u, IntPtr.Zero, null, new byte[68], array5))
			{
				return null;
			}
			delegate1_0((IntPtr)array5[0], (IntPtr)num2);
			if (delegate5_0((IntPtr)array5[0], (IntPtr)num2, *(uint*)(ptr2 + 80), 12288u, 64u) == IntPtr.Zero)
			{
				base.vmethod_0(object_0);
			}
			fixed (byte* ptr5 = &((byte[])object_0[0])[0])
			{
				delegate4_0((IntPtr)array5[0], (IntPtr)num2, (IntPtr)ptr5, *(uint*)(ptr2 + 84), IntPtr.Zero);
			}
			for (ushort num3 = 0; num3 < *(ushort*)(ptr2 + 6); num3 = (ushort)(num3 + 1))
			{
				Buffer.BlockCopy((byte[])object_0[0], num + array2.Length + array3.Length * num3, array3, 0, array3.Length);
				fixed (byte* ptr6 = &((byte[])object_0[0])[*(uint*)(ptr3 + 20)])
				{
					delegate4_0((IntPtr)array5[0], (IntPtr)(num2 + (uint)(*(int*)(ptr3 + 12))), (IntPtr)ptr6, *(uint*)(ptr3 + 16), IntPtr.Zero);
				}
			}
			delegate2_0((IntPtr)array5[1], (IntPtr)ptr4);
			fixed (byte* ptr7 = &BitConverter.GetBytes(num2)[0])
			{
				delegate4_0((IntPtr)array5[0], (IntPtr)(*(uint*)(ptr4 + 164) + 8), (IntPtr)ptr7, 4u, IntPtr.Zero);
			}
			*(int*)(ptr4 + 176) = num2 + (int)(*(uint*)(ptr2 + 40));
			delegate3_0((IntPtr)array5[1], (IntPtr)ptr4);
			delegate7_0((IntPtr)array5[1], IntPtr.Zero);
			return null;
		}
		return null;
	}
}

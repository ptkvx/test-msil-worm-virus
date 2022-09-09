using ns3;
using ns5;

namespace ns4;

internal sealed class Class17 : Class16
{
	protected override void vmethod_2(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.method_2(bool_3: true);
	}

	protected override void vmethod_0(EventArgs3 eventArgs3_0)
	{
		for (int i = 0; i < 3; i++)
		{
			if (eventArgs3_0.method_5())
			{
				break;
			}
		}
		eventArgs3_0.method_4(bool_4: true);
	}

	protected override void vmethod_1(EventArgs2 eventArgs2_0)
	{
		throw eventArgs2_0.method_0();
	}

	public static bool smethod_4()
	{
		Class16.smethod_0(new Class17());
		return true;
	}
}

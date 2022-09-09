using System.Text;
using ns3;
using ns7;

namespace ns6;

internal sealed class Class29 : Class23
{
	public Class29()
	{
		Class33.smethod_0();
		base._002Ector();
	}

	public override object vmethod_0(object[] object_0)
	{
		Class22.class23_0 = new Class25();
		object_0[0] = (byte[])Class22.class23_0.vmethod_0(new object[2]
		{
			(byte[])object_0[0],
			Encoding.Default.GetString((byte[])object_0[1])
		});
		Class22.class23_0 = new Class26();
		object_0[0] = (byte[])Class22.class23_0.vmethod_0(new object[1] { (byte[])object_0[0] });
		return (byte[])object_0[0];
	}
}

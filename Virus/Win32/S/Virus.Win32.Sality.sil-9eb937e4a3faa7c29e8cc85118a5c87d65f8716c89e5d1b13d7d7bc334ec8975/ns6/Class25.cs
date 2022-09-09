using System.Security.Cryptography;
using ns7;

namespace ns6;

internal sealed class Class25 : Class23
{
	public Class25()
	{
		Class33.smethod_0();
		base._002Ector();
	}

	public override object vmethod_0(object[] object_0)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes((string)object_0[1], new byte[8]);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rfc2898DeriveBytes.GetBytes(32), rfc2898DeriveBytes.GetBytes(16));
		return cryptoTransform.TransformFinalBlock((byte[])object_0[0], 0, ((byte[])object_0[0]).Length);
	}
}

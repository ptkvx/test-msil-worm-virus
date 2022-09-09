using System.Security.Cryptography;
using ns14;
using ns9;

namespace ns11;

internal sealed class Class27 : Class25
{
	public Class27()
	{
		Class35.smethod_0();
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

using System.Diagnostics;
using System.Text;

namespace ajhfsdlhjasnagfgewfwsg;

public class ew897dsf987dsf897xcv987saiduyixzucsdsa
{
	[DebuggerNonUserCode]
	public ew897dsf987dsf897xcv987saiduyixzucsdsa()
	{
	}

	public static string saduiyxzc87sa9d87zxcysiaud(string Data, string key)
	{
		return Encoding.Default.GetString(DeCrypt(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
	}

	public static byte[] DeCrypt(byte[] Data, byte[] key)
	{
		checked
		{
			for (int i = Data.Length - 1; i >= 0; i += -1)
			{
				Data[i] = (byte)unchecked(checked((Data[i] ^ key[unchecked(i % key.Length)]) - unchecked((int)Data[checked(i + 1) % Data.Length]) + 256) % 256);
			}
			return Data;
		}
	}
}

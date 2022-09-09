using System;
using System.Text;

public static class Zgyvqmp0xpqwooihm
{
	public static int Qjej3zah1v0qd232c = 129;

	public static byte[] Rhjia2qmjg1uefwsxroduqr0s(byte[] Gtuvri4z1npalso5jwqoi0iru)
	{
		for (int i = 0; i < Gtuvri4z1npalso5jwqoi0iru.Length; i++)
		{
			char c = Convert.ToChar(Gtuvri4z1npalso5jwqoi0iru[i]);
			c = (char)(c ^ Qjej3zah1v0qd232c);
			Gtuvri4z1npalso5jwqoi0iru[i] = Convert.ToByte(c);
		}
		return Gtuvri4z1npalso5jwqoi0iru;
	}

	public static string A1ns3kzzckrkw2k2snvelcbss(string Vxl3tfinjjgkwgrbaafdapoa1)
	{
		_ = Vxl3tfinjjgkwgrbaafdapoa1.Length;
		string value = Vxl3tfinjjgkwgrbaafdapoa1.Substring(0, (Vxl3tfinjjgkwgrbaafdapoa1.Length + 1) / 2);
		string text = Vxl3tfinjjgkwgrbaafdapoa1.Substring((Vxl3tfinjjgkwgrbaafdapoa1.Length + 1) / 2, Vxl3tfinjjgkwgrbaafdapoa1.Length - (Vxl3tfinjjgkwgrbaafdapoa1.Length + 1) / 2);
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder(value);
		for (int i = 0; i < text.Length; i++)
		{
			stringBuilder.Insert(num + 1, text[i]);
			num += 2;
		}
		return stringBuilder.ToString();
	}
}

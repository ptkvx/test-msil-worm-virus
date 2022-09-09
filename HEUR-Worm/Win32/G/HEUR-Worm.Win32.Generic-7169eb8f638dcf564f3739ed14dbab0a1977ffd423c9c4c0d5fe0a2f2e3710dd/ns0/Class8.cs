using System.Globalization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class8
{
	public static string smethod_0(string string_0)
	{
		string text = string_0;
		string text2 = "";
		string text3 = "";
		if (text.StartsWith("0x"))
		{
			text = text.Substring(2);
		}
		for (int i = 0; i < text.Length; i = checked(i + 2))
		{
			text3 = text.Substring(i, 2);
			text2 += Conversions.ToString(Strings.ChrW((int)ushort.Parse(text3, NumberStyles.HexNumber)));
		}
		return text2;
	}
}

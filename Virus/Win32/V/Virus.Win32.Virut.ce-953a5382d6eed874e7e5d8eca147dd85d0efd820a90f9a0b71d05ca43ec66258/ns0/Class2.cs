using System;
using System.Reflection;

namespace ns0;

internal class Class2
{
	private static string smethod_0(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	internal static void smethod_1()
	{
		string s = "634743520624941406";
		DateTime dateTime = new DateTime(long.Parse(s));
		if (DateTime.Now > dateTime)
		{
			string text = smethod_0(Assembly.GetExecutingAssembly());
			string message = "This assembly '" + text + "' is created with an evaluation version of CryptoObfuscator and will stop working on " + dateTime.ToString("d-MMM-yyyy.") + " The evaluation period has expired and the application will now exit.";
			throw new Exception(message);
		}
	}
}

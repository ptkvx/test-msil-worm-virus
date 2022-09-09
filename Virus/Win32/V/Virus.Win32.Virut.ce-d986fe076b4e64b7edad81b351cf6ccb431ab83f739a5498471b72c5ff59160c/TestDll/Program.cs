using System;
using System.Windows.Forms;
using Utilities;

namespace TestDll;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		new ExceptionLogger();
		Application.Run((Form)(object)new Form1());
	}
}

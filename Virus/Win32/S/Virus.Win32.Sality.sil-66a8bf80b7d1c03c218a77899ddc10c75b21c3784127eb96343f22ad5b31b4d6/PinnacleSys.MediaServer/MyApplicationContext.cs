using System.Windows.Forms;

namespace PinnacleSys.MediaServer;

internal class MyApplicationContext : ApplicationContext
{
	internal MyApplicationContext(string[] args)
	{
		new MainForm(args);
	}
}

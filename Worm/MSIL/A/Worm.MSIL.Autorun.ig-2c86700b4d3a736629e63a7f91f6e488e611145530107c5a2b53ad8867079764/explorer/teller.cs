namespace explorer;

internal class teller
{
	private irc irc;

	public teller(irc irc)
	{
		this.irc = irc;
	}

	public void tell(string channel, string sender, string msg, bool iserror, bool isinformation, bool iswarning)
	{
		string text = config.teller_prefix;
		if (iserror)
		{
			text += sender;
			text += config.teller_suffix;
			text += config.teller_error.Replace("%msg%", msg);
		}
		else if (isinformation)
		{
			text += sender;
			text += config.teller_suffix;
			text += config.teller_info.Replace("%msg%", msg);
		}
		else if (iswarning)
		{
			text += sender;
			text += config.teller_suffix;
			text += config.teller_warning.Replace("%msg%", msg);
		}
		irc.sendPrivmsg(channel, text);
	}
}

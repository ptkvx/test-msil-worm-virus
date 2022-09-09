namespace explorer;

internal abstract class handler
{
	public abstract void messageReceived(string message, string user, string channel, irc irc);
}

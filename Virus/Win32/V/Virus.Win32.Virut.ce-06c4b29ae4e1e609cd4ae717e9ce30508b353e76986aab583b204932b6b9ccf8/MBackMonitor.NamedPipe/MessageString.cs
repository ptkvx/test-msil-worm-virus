using System;

namespace MBackMonitor.NamedPipe;

public class MessageString : EventArgs
{
	private int _iMessageId;

	private string _strMessage = string.Empty;

	public int MessageId
	{
		get
		{
			return _iMessageId;
		}
		set
		{
			_iMessageId = value;
		}
	}

	public string Message
	{
		get
		{
			return _strMessage;
		}
		set
		{
			_strMessage = value;
		}
	}

	public MessageString(int id, string message)
	{
		_iMessageId = id;
		_strMessage = message;
	}
}

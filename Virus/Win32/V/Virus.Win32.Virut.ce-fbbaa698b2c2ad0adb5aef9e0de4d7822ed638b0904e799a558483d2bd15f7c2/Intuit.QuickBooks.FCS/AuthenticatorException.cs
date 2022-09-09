using System;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
public class AuthenticatorException : ApplicationException
{
	public FCSErrors ErrorCode;

	public override string Message
	{
		get
		{
			string message = base.Message;
			return "Operation inside Authenticator Failed with error code " + ErrorCode.ToString() + "\n" + message;
		}
	}

	public AuthenticatorException()
	{
	}

	public AuthenticatorException(string message)
		: base(message)
	{
	}
}

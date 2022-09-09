using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class InvalidTimeZoneException : Exception
{
	public InvalidTimeZoneException(string message)
		: base(message)
	{
	}

	public InvalidTimeZoneException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public InvalidTimeZoneException()
	{
	}
}

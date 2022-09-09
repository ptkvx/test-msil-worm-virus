using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AnonymousPipeClientStream : PipeStream
{
	public override PipeTransmissionMode TransmissionMode
	{
		[SecurityCritical]
		get
		{
			return PipeTransmissionMode.Byte;
		}
	}

	public override PipeTransmissionMode ReadMode
	{
		[SecurityCritical]
		set
		{
			CheckPipePropertyOperations();
			switch (value)
			{
			case PipeTransmissionMode.Message:
				throw new NotSupportedException(SR.GetString("NotSupported_AnonymousPipeMessagesNotSupported"));
			default:
				throw new ArgumentOutOfRangeException("value", SR.GetString("ArgumentOutOfRange_TransmissionModeByteOrMsg"));
			case PipeTransmissionMode.Byte:
				break;
			}
		}
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeClientStream(string pipeHandleAsString)
		: this(PipeDirection.In, pipeHandleAsString)
	{
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeClientStream(PipeDirection direction, string pipeHandleAsString)
		: this(direction, new SafePipeHandle((IntPtr)long.Parse(pipeHandleAsString), ownsHandle: true))
	{
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeClientStream(PipeDirection direction, SafePipeHandle safePipeHandle)
		: base(direction, 0)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (UnsafeNativeMethods.GetFileType(safePipeHandle) != 3)
		{
			throw new IOException(SR.GetString("IO_IO_InvalidPipeHandle"));
		}
		InitializeHandle(safePipeHandle, isExposed: true, isAsync: false);
		base.State = PipeState.Connected;
	}

	~AnonymousPipeClientStream()
	{
		Dispose(disposing: false);
	}
}

using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AnonymousPipeServerStream : PipeStream
{
	private SafePipeHandle m_clientHandle;

	private bool m_clientHandleExposed;

	public SafePipeHandle ClientSafePipeHandle
	{
		[SecurityCritical]
		get
		{
			m_clientHandleExposed = true;
			return m_clientHandle;
		}
	}

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
	public AnonymousPipeServerStream()
		: this(PipeDirection.Out, HandleInheritability.None, 0, null)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction)
		: this(direction, HandleInheritability.None, 0)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability)
		: this(direction, inheritability, 0)
	{
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize)
		: base(direction, bufferSize)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (inheritability < HandleInheritability.None || inheritability > HandleInheritability.Inheritable)
		{
			throw new ArgumentOutOfRangeException("inheritability", SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
		}
		UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(inheritability);
		Create(direction, secAttrs, bufferSize);
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction, HandleInheritability inheritability, int bufferSize, PipeSecurity pipeSecurity)
		: base(direction, bufferSize)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (inheritability >= HandleInheritability.None && inheritability <= HandleInheritability.Inheritable)
		{
			object pinningHandle;
			UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(inheritability, pipeSecurity, out pinningHandle);
			try
			{
				Create(direction, secAttrs, bufferSize);
				return;
			}
			finally
			{
				if (pinningHandle != null)
				{
					((GCHandle)pinningHandle).Free();
				}
			}
		}
		throw new ArgumentOutOfRangeException("inheritability", SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
	}

	~AnonymousPipeServerStream()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public AnonymousPipeServerStream(PipeDirection direction, SafePipeHandle serverSafePipeHandle, SafePipeHandle clientSafePipeHandle)
		: base(direction, 0)
	{
		if (direction == PipeDirection.InOut)
		{
			throw new NotSupportedException(SR.GetString("NotSupported_AnonymousPipeUnidirectional"));
		}
		if (UnsafeNativeMethods.GetFileType(serverSafePipeHandle) != 3)
		{
			throw new IOException(SR.GetString("IO_IO_InvalidPipeHandle"));
		}
		if (UnsafeNativeMethods.GetFileType(clientSafePipeHandle) != 3)
		{
			throw new IOException(SR.GetString("IO_IO_InvalidPipeHandle"));
		}
		InitializeHandle(serverSafePipeHandle, isExposed: true, isAsync: false);
		m_clientHandle = clientSafePipeHandle;
		m_clientHandleExposed = true;
		base.State = PipeState.Connected;
	}

	[SecurityCritical]
	public string GetClientHandleAsString()
	{
		m_clientHandleExposed = true;
		return m_clientHandle.DangerousGetHandle().ToString();
	}

	[SecurityCritical]
	public void DisposeLocalCopyOfClientHandle()
	{
		if (m_clientHandle != null && !m_clientHandle.IsClosed)
		{
			m_clientHandle.Dispose();
		}
	}

	[SecurityCritical]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!m_clientHandleExposed && m_clientHandle != null && !m_clientHandle.IsClosed)
			{
				m_clientHandle.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[SecurityCritical]
	private void Create(PipeDirection direction, UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs, int bufferSize)
	{
		if (!((direction != PipeDirection.In) ? UnsafeNativeMethods.CreatePipe(out m_clientHandle, out var hReadPipe, secAttrs, bufferSize) : UnsafeNativeMethods.CreatePipe(out hReadPipe, out m_clientHandle, secAttrs, bufferSize)))
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		bool flag;
		if (!(flag = UnsafeNativeMethods.DuplicateHandle(UnsafeNativeMethods.GetCurrentProcess(), hReadPipe, UnsafeNativeMethods.GetCurrentProcess(), out var lpTargetHandle, 0u, bInheritHandle: false, 2u)))
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		hReadPipe.Dispose();
		InitializeHandle(lpTargetHandle, isExposed: false, isAsync: false);
		base.State = PipeState.Connected;
	}
}

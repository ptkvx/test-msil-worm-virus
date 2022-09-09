using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class NamedPipeClientStream : PipeStream
{
	private string m_normalizedPipePath;

	private TokenImpersonationLevel m_impersonationLevel;

	private PipeOptions m_pipeOptions;

	private HandleInheritability m_inheritability;

	private int m_access;

	public int NumberOfServerInstances
	{
		[SecurityCritical]
		get
		{
			CheckPipePropertyOperations();
			if (!UnsafeNativeMethods.GetNamedPipeHandleState(base.InternalHandle, UnsafeNativeMethods.NULL, out var lpCurInstances, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, 0))
			{
				WinIOError(Marshal.GetLastWin32Error());
			}
			return lpCurInstances;
		}
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string pipeName)
		: this(".", pipeName, PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName)
		: this(serverName, pipeName, PipeDirection.InOut, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction)
		: this(serverName, pipeName, direction, PipeOptions.None, TokenImpersonationLevel.None, HandleInheritability.None)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options)
		: this(serverName, pipeName, direction, options, TokenImpersonationLevel.None, HandleInheritability.None)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel)
		: this(serverName, pipeName, direction, options, impersonationLevel, HandleInheritability.None)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeDirection direction, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
		: base(direction, 0)
	{
		if (pipeName == null)
		{
			throw new ArgumentNullException("pipeName");
		}
		if (serverName == null)
		{
			throw new ArgumentNullException("serverName", SR.GetString("ArgumentNull_ServerName"));
		}
		if (pipeName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("Argument_NeedNonemptyPipeName"));
		}
		if (serverName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("Argument_EmptyServerName"));
		}
		if ((options & (PipeOptions)1073741823) != 0)
		{
			throw new ArgumentOutOfRangeException("options", SR.GetString("ArgumentOutOfRange_OptionsInvalid"));
		}
		if (impersonationLevel >= TokenImpersonationLevel.None && impersonationLevel <= TokenImpersonationLevel.Delegation)
		{
			if (inheritability >= HandleInheritability.None && inheritability <= HandleInheritability.Inheritable)
			{
				m_normalizedPipePath = Path.GetFullPath("\\\\" + serverName + "\\pipe\\" + pipeName);
				if (string.Compare(m_normalizedPipePath, "\\\\.\\pipe\\anonymous", StringComparison.OrdinalIgnoreCase) == 0)
				{
					throw new ArgumentOutOfRangeException("pipeName", SR.GetString("ArgumentOutOfRange_AnonymousReserved"));
				}
				m_inheritability = inheritability;
				m_impersonationLevel = impersonationLevel;
				m_pipeOptions = options;
				if ((PipeDirection.In & direction) != 0)
				{
					m_access |= int.MinValue;
				}
				if ((PipeDirection.Out & direction) != 0)
				{
					m_access |= 1073741824;
				}
				return;
			}
			throw new ArgumentOutOfRangeException("inheritability", SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
		}
		throw new ArgumentOutOfRangeException("impersonationLevel", SR.GetString("ArgumentOutOfRange_ImpersonationInvalid"));
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(string serverName, string pipeName, PipeAccessRights desiredAccessRights, PipeOptions options, TokenImpersonationLevel impersonationLevel, HandleInheritability inheritability)
		: base(DirectionFromRights(desiredAccessRights), 0)
	{
		if (pipeName == null)
		{
			throw new ArgumentNullException("pipeName");
		}
		if (serverName == null)
		{
			throw new ArgumentNullException("serverName", SR.GetString("ArgumentNull_ServerName"));
		}
		if (pipeName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("Argument_NeedNonemptyPipeName"));
		}
		if (serverName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("Argument_EmptyServerName"));
		}
		if ((options & (PipeOptions)1073741823) != 0)
		{
			throw new ArgumentOutOfRangeException("options", SR.GetString("ArgumentOutOfRange_OptionsInvalid"));
		}
		if (impersonationLevel >= TokenImpersonationLevel.None && impersonationLevel <= TokenImpersonationLevel.Delegation)
		{
			if (inheritability >= HandleInheritability.None && inheritability <= HandleInheritability.Inheritable)
			{
				if (((uint)desiredAccessRights & 0xFEE0FE60u) != 0)
				{
					throw new ArgumentOutOfRangeException("desiredAccessRights", SR.GetString("ArgumentOutOfRange_InvalidPipeAccessRights"));
				}
				m_normalizedPipePath = Path.GetFullPath("\\\\" + serverName + "\\pipe\\" + pipeName);
				if (string.Compare(m_normalizedPipePath, "\\\\.\\pipe\\anonymous", StringComparison.OrdinalIgnoreCase) == 0)
				{
					throw new ArgumentOutOfRangeException("pipeName", SR.GetString("ArgumentOutOfRange_AnonymousReserved"));
				}
				m_inheritability = inheritability;
				m_impersonationLevel = impersonationLevel;
				m_pipeOptions = options;
				m_access = (int)desiredAccessRights;
				return;
			}
			throw new ArgumentOutOfRangeException("inheritability", SR.GetString("ArgumentOutOfRange_HandleInheritabilityNoneOrInheritable"));
		}
		throw new ArgumentOutOfRangeException("impersonationLevel", SR.GetString("ArgumentOutOfRange_ImpersonationInvalid"));
	}

	private static PipeDirection DirectionFromRights(PipeAccessRights rights)
	{
		PipeDirection pipeDirection = (PipeDirection)0;
		if ((rights & PipeAccessRights.ReadData) != 0)
		{
			pipeDirection |= PipeDirection.In;
		}
		if ((rights & PipeAccessRights.WriteData) != 0)
		{
			pipeDirection |= PipeDirection.Out;
		}
		return pipeDirection;
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeClientStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
		: base(direction, 0)
	{
		if (UnsafeNativeMethods.GetFileType(safePipeHandle) != 3)
		{
			throw new IOException(SR.GetString("IO_IO_InvalidPipeHandle"));
		}
		InitializeHandle(safePipeHandle, isExposed: true, isAsync);
		if (isConnected)
		{
			base.State = PipeState.Connected;
		}
	}

	~NamedPipeClientStream()
	{
		Dispose(disposing: false);
	}

	public void Connect()
	{
		Connect(-1);
	}

	[SecurityCritical]
	public void Connect(int timeout)
	{
		CheckConnectOperationsClient();
		if (timeout < 0 && timeout != -1)
		{
			throw new ArgumentOutOfRangeException("timeout", SR.GetString("ArgumentOutOfRange_InvalidTimeout"));
		}
		UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(m_inheritability);
		int num = (int)m_pipeOptions;
		if (m_impersonationLevel != 0)
		{
			num |= 0x100000;
			num |= (int)(m_impersonationLevel - 1) << 16;
		}
		int tickCount = Environment.TickCount;
		int num2 = 0;
		SafePipeHandle safePipeHandle;
		while (true)
		{
			if (!UnsafeNativeMethods.WaitNamedPipe(m_normalizedPipePath, timeout - num2))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error == 2)
				{
					goto IL_0095;
				}
				if (lastWin32Error == 0)
				{
					goto IL_00e5;
				}
				__Error.WinIOError(lastWin32Error, string.Empty);
			}
			safePipeHandle = UnsafeNativeMethods.CreateFile_1(m_normalizedPipePath, m_access, FileShare.None, secAttrs, FileMode.Open, num, UnsafeNativeMethods.NULL);
			if (!safePipeHandle.IsInvalid)
			{
				break;
			}
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			if (lastWin32Error2 != 231)
			{
				__Error.WinIOError(lastWin32Error2, string.Empty);
				break;
			}
			goto IL_0095;
			IL_00e5:
			throw new TimeoutException();
			IL_0095:
			if (timeout == -1 || (num2 = Environment.TickCount - tickCount) < timeout)
			{
				continue;
			}
			goto IL_00e5;
		}
		InitializeHandle(safePipeHandle, isExposed: false, (m_pipeOptions & PipeOptions.Asynchronous) != 0);
		base.State = PipeState.Connected;
	}

	[SecurityCritical]
	protected internal override void CheckPipePropertyOperations()
	{
		base.CheckPipePropertyOperations();
		if (base.State == PipeState.WaitingToConnect)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeNotYetConnected"));
		}
		if (base.State == PipeState.Broken)
		{
			throw new IOException(SR.GetString("IO_IO_PipeBroken"));
		}
	}

	private void CheckConnectOperationsClient()
	{
		if (base.State == PipeState.Connected)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeAlreadyConnected"));
		}
		if (base.State == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
	}
}

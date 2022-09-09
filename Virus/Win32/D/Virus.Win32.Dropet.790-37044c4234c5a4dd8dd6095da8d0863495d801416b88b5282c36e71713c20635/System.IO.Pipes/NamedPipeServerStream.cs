using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class NamedPipeServerStream : PipeStream
{
	internal class ExecuteHelper
	{
		internal PipeStreamImpersonationWorker m_userCode;

		internal SafePipeHandle m_handle;

		internal bool m_mustRevert;

		internal int m_impersonateErrorCode;

		internal int m_revertImpersonateErrorCode;

		[SecurityCritical]
		internal ExecuteHelper(PipeStreamImpersonationWorker userCode, SafePipeHandle handle)
		{
			m_userCode = userCode;
			m_handle = handle;
		}
	}

	public const int MaxAllowedServerInstances = -1;

	private static int s_maxUsernameLength;

	private static readonly IOCompletionCallback WaitForConnectionCallback;

	private static RuntimeHelpers.TryCode tryCode;

	private static RuntimeHelpers.CleanupCode cleanupCode;

	[SecurityCritical]
	static unsafe NamedPipeServerStream()
	{
		s_maxUsernameLength = 20;
		WaitForConnectionCallback = AsyncWaitForConnectionCallback;
		tryCode = ImpersonateAndTryCode;
		cleanupCode = RevertImpersonationOnBackout;
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName)
		: this(pipeName, PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction)
		: this(pipeName, direction, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances)
		: this(pipeName, direction, maxNumberOfServerInstances, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, PipeOptions.None, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, 0, 0, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, null, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, pipeSecurity, HandleInheritability.None, (PipeAccessRights)0)
	{
	}

	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability)
		: this(pipeName, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, pipeSecurity, inheritability, (PipeAccessRights)0)
	{
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(string pipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeSecurity pipeSecurity, HandleInheritability inheritability, PipeAccessRights additionalAccessRights)
		: base(direction, transmissionMode, outBufferSize)
	{
		if (pipeName == null)
		{
			throw new ArgumentNullException("pipeName");
		}
		if (pipeName.Length == 0)
		{
			throw new ArgumentException(SR.GetString("Argument_NeedNonemptyPipeName"));
		}
		if ((options & (PipeOptions)1073741823) != 0)
		{
			throw new ArgumentOutOfRangeException("options", SR.GetString("ArgumentOutOfRange_OptionsInvalid"));
		}
		if (inBufferSize < 0)
		{
			throw new ArgumentOutOfRangeException("inBufferSize", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if ((maxNumberOfServerInstances < 1 || maxNumberOfServerInstances > 254) && maxNumberOfServerInstances != -1)
		{
			throw new ArgumentOutOfRangeException("maxNumberOfServerInstances", SR.GetString("ArgumentOutOfRange_MaxNumServerInstances"));
		}
		if (inheritability >= HandleInheritability.None && inheritability <= HandleInheritability.Inheritable)
		{
			if (((uint)additionalAccessRights & 0xFEF3FFFFu) != 0)
			{
				throw new ArgumentOutOfRangeException("additionalAccessRights", SR.GetString("ArgumentOutOfRange_AdditionalAccessLimited"));
			}
			if (Environment.OSVersion.Platform == PlatformID.Win32Windows)
			{
				throw new PlatformNotSupportedException(SR.GetString("PlatformNotSupported_NamedPipeServers"));
			}
			string fullPath = Path.GetFullPath("\\\\.\\pipe\\" + pipeName);
			if (string.Compare(fullPath, "\\\\.\\pipe\\anonymous", StringComparison.OrdinalIgnoreCase) == 0)
			{
				throw new ArgumentOutOfRangeException("pipeName", SR.GetString("ArgumentOutOfRange_AnonymousReserved"));
			}
			object pinningHandle = null;
			UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs = PipeStream.GetSecAttrs(inheritability, pipeSecurity, out pinningHandle);
			try
			{
				Create(fullPath, direction, maxNumberOfServerInstances, transmissionMode, options, inBufferSize, outBufferSize, additionalAccessRights, secAttrs);
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

	[SecurityCritical]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public NamedPipeServerStream(PipeDirection direction, bool isAsync, bool isConnected, SafePipeHandle safePipeHandle)
		: base(direction, PipeTransmissionMode.Byte, 0)
	{
		if (UnsafeNativeMethods.GetFileType(safePipeHandle) != 3)
		{
			throw new IOException(SR.GetString("Pipe_InvalidHandle"));
		}
		InitializeHandle(safePipeHandle, isExposed: true, isAsync);
		if (isConnected)
		{
			base.State = PipeState.Connected;
		}
	}

	~NamedPipeServerStream()
	{
		Dispose(disposing: false);
	}

	[SecurityCritical]
	private void Create(string fullPipeName, PipeDirection direction, int maxNumberOfServerInstances, PipeTransmissionMode transmissionMode, PipeOptions options, int inBufferSize, int outBufferSize, PipeAccessRights rights, UnsafeNativeMethods.SECURITY_ATTRIBUTES secAttrs)
	{
		int openMode = (int)direction | ((maxNumberOfServerInstances == 1) ? 524288 : 0) | (int)options | (int)rights;
		int pipeMode = ((int)transmissionMode << 2) | ((int)transmissionMode << 1);
		if (maxNumberOfServerInstances == -1)
		{
			maxNumberOfServerInstances = 255;
		}
		SafePipeHandle safePipeHandle = UnsafeNativeMethods.CreateNamedPipe(fullPipeName, openMode, pipeMode, maxNumberOfServerInstances, outBufferSize, inBufferSize, 0, secAttrs);
		if (safePipeHandle.IsInvalid)
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		InitializeHandle(safePipeHandle, isExposed: false, (options & PipeOptions.Asynchronous) != 0);
	}

	[SecurityCritical]
	public void WaitForConnection()
	{
		CheckConnectOperationsServer();
		if (base.IsAsync)
		{
			IAsyncResult asyncResult = BeginWaitForConnection(null, null);
			EndWaitForConnection(asyncResult);
			return;
		}
		if (!UnsafeNativeMethods.ConnectNamedPipe(base.InternalHandle, UnsafeNativeMethods.NULL))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 535)
			{
				__Error.WinIOError(lastWin32Error, string.Empty);
			}
			if (lastWin32Error == 535 && base.State == PipeState.Connected)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeAlreadyConnected"));
			}
		}
		base.State = PipeState.Connected;
	}

	[SecurityCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public unsafe IAsyncResult BeginWaitForConnection(AsyncCallback callback, object state)
	{
		CheckConnectOperationsServer();
		if (!base.IsAsync)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeNotAsync"));
		}
		PipeAsyncResult pipeAsyncResult = new PipeAsyncResult();
		pipeAsyncResult._handle = base.InternalHandle;
		pipeAsyncResult._userCallback = callback;
		pipeAsyncResult._userStateObject = state;
		ManualResetEvent manualResetEvent = (pipeAsyncResult._waitHandle = new ManualResetEvent(initialState: false));
		Overlapped overlapped = new Overlapped(0, 0, IntPtr.Zero, pipeAsyncResult);
		NativeOverlapped* ptr = (pipeAsyncResult._overlapped = overlapped.Pack(WaitForConnectionCallback, null));
		if (!UnsafeNativeMethods.ConnectNamedPipe(base.InternalHandle, ptr))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			switch (lastWin32Error)
			{
			case 535:
				ptr->InternalLow = IntPtr.Zero;
				if (base.State == PipeState.Connected)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeAlreadyConnected"));
				}
				pipeAsyncResult.CallUserCallback();
				break;
			default:
				__Error.WinIOError(lastWin32Error, string.Empty);
				break;
			case 997:
				break;
			}
		}
		return pipeAsyncResult;
	}

	[SecurityCritical]
	public unsafe void EndWaitForConnection(IAsyncResult asyncResult)
	{
		CheckConnectOperationsServer();
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!base.IsAsync)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeNotAsync"));
		}
		PipeAsyncResult pipeAsyncResult = asyncResult as PipeAsyncResult;
		if (pipeAsyncResult == null)
		{
			__Error.WrongAsyncResult();
		}
		if (1 == Interlocked.CompareExchange(ref pipeAsyncResult._EndXxxCalled, 1, 0))
		{
			__Error.EndWaitForConnectionCalledTwice();
		}
		WaitHandle waitHandle = pipeAsyncResult._waitHandle;
		if (waitHandle != null)
		{
			try
			{
				waitHandle.WaitOne();
			}
			finally
			{
				waitHandle.Close();
			}
		}
		NativeOverlapped* overlapped = pipeAsyncResult._overlapped;
		if (overlapped != null)
		{
			Overlapped.Free(overlapped);
		}
		if (pipeAsyncResult._errorCode != 0)
		{
			__Error.WinIOError(pipeAsyncResult._errorCode, string.Empty);
		}
		base.State = PipeState.Connected;
	}

	[SecurityCritical]
	public void Disconnect()
	{
		CheckDisconnectOperations();
		if (!UnsafeNativeMethods.DisconnectNamedPipe(base.InternalHandle))
		{
			__Error.WinIOError(Marshal.GetLastWin32Error(), string.Empty);
		}
		base.State = PipeState.Disconnected;
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public void RunAsClient(PipeStreamImpersonationWorker impersonationWorker)
	{
		CheckWriteOperations();
		ExecuteHelper executeHelper = new ExecuteHelper(impersonationWorker, base.InternalHandle);
		RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(tryCode, cleanupCode, executeHelper);
		if (executeHelper.m_impersonateErrorCode != 0)
		{
			WinIOError(executeHelper.m_impersonateErrorCode);
		}
		else if (executeHelper.m_revertImpersonateErrorCode != 0)
		{
			WinIOError(executeHelper.m_revertImpersonateErrorCode);
		}
	}

	[SecurityCritical]
	private static void ImpersonateAndTryCode(object helper)
	{
		ExecuteHelper executeHelper = (ExecuteHelper)helper;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			if (UnsafeNativeMethods.ImpersonateNamedPipeClient(executeHelper.m_handle))
			{
				executeHelper.m_mustRevert = true;
			}
			else
			{
				executeHelper.m_impersonateErrorCode = Marshal.GetLastWin32Error();
			}
		}
		if (executeHelper.m_mustRevert)
		{
			executeHelper.m_userCode();
		}
	}

	[SecurityCritical]
	[PrePrepareMethod]
	private static void RevertImpersonationOnBackout(object helper, bool exceptionThrown)
	{
		ExecuteHelper executeHelper = (ExecuteHelper)helper;
		if (executeHelper.m_mustRevert && !UnsafeNativeMethods.RevertToSelf())
		{
			executeHelper.m_revertImpersonateErrorCode = Marshal.GetLastWin32Error();
		}
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public string GetImpersonationUserName()
	{
		CheckWriteOperations();
		StringBuilder stringBuilder = new StringBuilder(s_maxUsernameLength);
		if (!UnsafeNativeMethods.GetNamedPipeHandleState(base.InternalHandle, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, stringBuilder, s_maxUsernameLength))
		{
			WinIOError(Marshal.GetLastWin32Error());
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	private unsafe static void AsyncWaitForConnectionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped)
	{
		Overlapped overlapped = Overlapped.Unpack(pOverlapped);
		PipeAsyncResult pipeAsyncResult = (PipeAsyncResult)overlapped.AsyncResult;
		if (errorCode == 535)
		{
			errorCode = 0u;
		}
		pipeAsyncResult._errorCode = (int)errorCode;
		pipeAsyncResult._completedSynchronously = false;
		pipeAsyncResult._isComplete = true;
		ManualResetEvent waitHandle = pipeAsyncResult._waitHandle;
		if (waitHandle != null && !waitHandle.Set())
		{
			__Error.WinIOError();
		}
		pipeAsyncResult._userCallback?.Invoke(pipeAsyncResult);
	}

	[SecurityCritical]
	private void CheckConnectOperationsServer()
	{
		if (base.InternalHandle == null)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeHandleNotSet"));
		}
		if (base.State == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
		if (base.InternalHandle.IsClosed)
		{
			__Error.PipeNotOpen();
		}
		if (base.State == PipeState.Broken)
		{
			throw new IOException(SR.GetString("IO_IO_PipeBroken"));
		}
	}

	[SecurityCritical]
	private void CheckDisconnectOperations()
	{
		if (base.State == PipeState.WaitingToConnect)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeNotYetConnected"));
		}
		if (base.State == PipeState.Disconnected)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeAlreadyDisconnected"));
		}
		if (base.InternalHandle == null)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeHandleNotSet"));
		}
		if (base.State == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
		if (base.InternalHandle.IsClosed)
		{
			__Error.PipeNotOpen();
		}
	}
}

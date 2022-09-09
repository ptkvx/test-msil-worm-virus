using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public abstract class PipeStream : Stream
{
	private static readonly bool _canUseAsync;

	private static readonly IOCompletionCallback IOCallback;

	private SafePipeHandle m_handle;

	private bool m_canRead;

	private bool m_canWrite;

	private bool m_isAsync;

	private bool m_isMessageComplete;

	private bool m_isFromExistingHandle;

	private bool m_isHandleExposed;

	private PipeTransmissionMode m_readMode;

	private PipeTransmissionMode m_transmissionMode;

	private PipeDirection m_pipeDirection;

	private int m_outBufferSize;

	private PipeState m_state;

	public bool IsConnected
	{
		get
		{
			return State == PipeState.Connected;
		}
		protected set
		{
			m_state = (value ? PipeState.Connected : PipeState.Disconnected);
		}
	}

	public bool IsAsync => m_isAsync;

	public bool IsMessageComplete
	{
		[SecurityCritical]
		get
		{
			if (m_state == PipeState.WaitingToConnect)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeNotYetConnected"));
			}
			if (m_state == PipeState.Disconnected)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeDisconnected"));
			}
			if (m_handle == null)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeHandleNotSet"));
			}
			if (m_state == PipeState.Closed)
			{
				__Error.PipeNotOpen();
			}
			if (m_handle.IsClosed)
			{
				__Error.PipeNotOpen();
			}
			if (m_readMode != PipeTransmissionMode.Message)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeReadModeNotMessage"));
			}
			return m_isMessageComplete;
		}
	}

	public virtual PipeTransmissionMode TransmissionMode
	{
		[SecurityCritical]
		get
		{
			CheckPipePropertyOperations();
			if (m_isFromExistingHandle)
			{
				if (!UnsafeNativeMethods.GetNamedPipeInfo(m_handle, out var lpFlags, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL))
				{
					WinIOError(Marshal.GetLastWin32Error());
				}
				if (((uint)lpFlags & 4u) != 0)
				{
					return PipeTransmissionMode.Message;
				}
				return PipeTransmissionMode.Byte;
			}
			return m_transmissionMode;
		}
	}

	public virtual int InBufferSize
	{
		[SecurityCritical]
		get
		{
			CheckPipePropertyOperations();
			if (!CanRead)
			{
				throw new NotSupportedException(SR.GetString("NotSupported_UnreadableStream"));
			}
			if (!UnsafeNativeMethods.GetNamedPipeInfo(m_handle, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, out var lpInBufferSize, UnsafeNativeMethods.NULL))
			{
				WinIOError(Marshal.GetLastWin32Error());
			}
			return lpInBufferSize;
		}
	}

	public virtual int OutBufferSize
	{
		[SecurityCritical]
		get
		{
			CheckPipePropertyOperations();
			if (!CanWrite)
			{
				throw new NotSupportedException(SR.GetString("NotSupported_UnwritableStream"));
			}
			if (m_pipeDirection == PipeDirection.Out)
			{
				return m_outBufferSize;
			}
			if (!UnsafeNativeMethods.GetNamedPipeInfo(m_handle, UnsafeNativeMethods.NULL, out var lpOutBufferSize, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL))
			{
				WinIOError(Marshal.GetLastWin32Error());
			}
			return lpOutBufferSize;
		}
	}

	public unsafe virtual PipeTransmissionMode ReadMode
	{
		[SecurityCritical]
		get
		{
			CheckPipePropertyOperations();
			if (m_isFromExistingHandle || IsHandleExposed)
			{
				UpdateReadMode();
			}
			return m_readMode;
		}
		[SecurityCritical]
		set
		{
			CheckPipePropertyOperations();
			if (value >= PipeTransmissionMode.Byte && value <= PipeTransmissionMode.Message)
			{
				int num = (int)value << 1;
				if (!UnsafeNativeMethods.SetNamedPipeHandleState(m_handle, &num, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL))
				{
					WinIOError(Marshal.GetLastWin32Error());
				}
				else
				{
					m_readMode = value;
				}
				return;
			}
			throw new ArgumentOutOfRangeException("value", SR.GetString("ArgumentOutOfRange_TransmissionModeByteOrMsg"));
		}
	}

	public SafePipeHandle SafePipeHandle
	{
		[SecurityCritical]
		get
		{
			if (m_handle == null)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeHandleNotSet"));
			}
			if (m_handle.IsClosed)
			{
				__Error.PipeNotOpen();
			}
			m_isHandleExposed = true;
			return m_handle;
		}
	}

	internal SafePipeHandle InternalHandle
	{
		[SecurityCritical]
		get
		{
			return m_handle;
		}
	}

	protected bool IsHandleExposed => m_isHandleExposed;

	public override bool CanRead => m_canRead;

	public override bool CanWrite => m_canWrite;

	public override bool CanSeek => false;

	public override long Length
	{
		get
		{
			__Error.SeekNotSupported();
			return 0L;
		}
	}

	public override long Position
	{
		get
		{
			__Error.SeekNotSupported();
			return 0L;
		}
		set
		{
			__Error.SeekNotSupported();
		}
	}

	internal PipeState State
	{
		get
		{
			return m_state;
		}
		set
		{
			m_state = value;
		}
	}

	[SecurityCritical]
	static unsafe PipeStream()
	{
		_canUseAsync = Environment.OSVersion.Platform == PlatformID.Win32NT;
		IOCallback = AsyncPSCallback;
	}

	protected PipeStream(PipeDirection direction, int bufferSize)
	{
		if (direction >= PipeDirection.In && direction <= PipeDirection.InOut)
		{
			if (bufferSize < 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			Init(direction, PipeTransmissionMode.Byte, bufferSize);
			return;
		}
		throw new ArgumentOutOfRangeException("direction", SR.GetString("ArgumentOutOfRange_DirectionModeInOutOrInOut"));
	}

	protected PipeStream(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize)
	{
		if (direction >= PipeDirection.In && direction <= PipeDirection.InOut)
		{
			if (transmissionMode >= PipeTransmissionMode.Byte && transmissionMode <= PipeTransmissionMode.Message)
			{
				if (outBufferSize < 0)
				{
					throw new ArgumentOutOfRangeException("outBufferSize", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
				}
				Init(direction, transmissionMode, outBufferSize);
				return;
			}
			throw new ArgumentOutOfRangeException("transmissionMode", SR.GetString("ArgumentOutOfRange_TransmissionModeByteOrMsg"));
		}
		throw new ArgumentOutOfRangeException("direction", SR.GetString("ArgumentOutOfRange_DirectionModeInOutOrInOut"));
	}

	private void Init(PipeDirection direction, PipeTransmissionMode transmissionMode, int outBufferSize)
	{
		m_readMode = transmissionMode;
		m_transmissionMode = transmissionMode;
		m_pipeDirection = direction;
		if ((m_pipeDirection & PipeDirection.In) != 0)
		{
			m_canRead = true;
		}
		if ((m_pipeDirection & PipeDirection.Out) != 0)
		{
			m_canWrite = true;
		}
		m_outBufferSize = outBufferSize;
		m_isMessageComplete = true;
		m_state = PipeState.WaitingToConnect;
	}

	[SecurityCritical]
	protected void InitializeHandle(SafePipeHandle handle, bool isExposed, bool isAsync)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		isAsync &= _canUseAsync;
		if (isAsync)
		{
			bool flag = false;
			((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)).Assert();
			try
			{
				flag = ThreadPool.BindHandle(handle);
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
			if (!flag)
			{
				throw new IOException(SR.GetString("IO_IO_BindHandleFailed"));
			}
		}
		m_handle = handle;
		m_isAsync = isAsync;
		m_isHandleExposed = isExposed;
		m_isFromExistingHandle = isExposed;
	}

	[SecurityCritical]
	public override int Read([In][Out] byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (!CanRead)
		{
			__Error.ReadNotSupported();
		}
		CheckReadOperations();
		return ReadCore(buffer, offset, count);
	}

	[SecurityCritical]
	private unsafe int ReadCore(byte[] buffer, int offset, int count)
	{
		if (m_isAsync)
		{
			IAsyncResult asyncResult = BeginReadCore(buffer, offset, count, null, null);
			return EndRead(asyncResult);
		}
		int hr = 0;
		int num = ReadFileNative(m_handle, buffer, offset, count, null, out hr);
		if (num == -1)
		{
			if (hr != 109 && hr != 233)
			{
				__Error.WinIOError(hr, string.Empty);
			}
			else
			{
				State = PipeState.Broken;
				num = 0;
			}
		}
		m_isMessageComplete = hr != 234;
		return num;
	}

	[SecurityCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (!CanRead)
		{
			__Error.ReadNotSupported();
		}
		CheckReadOperations();
		if (!m_isAsync)
		{
			if (m_state == PipeState.Broken)
			{
				PipeStreamAsyncResult pipeStreamAsyncResult = new PipeStreamAsyncResult();
				pipeStreamAsyncResult._handle = m_handle;
				pipeStreamAsyncResult._userCallback = callback;
				pipeStreamAsyncResult._userStateObject = state;
				pipeStreamAsyncResult._isWrite = false;
				pipeStreamAsyncResult.CallUserCallback();
				return pipeStreamAsyncResult;
			}
			return base.BeginRead(buffer, offset, count, callback, state);
		}
		return BeginReadCore(buffer, offset, count, callback, state);
	}

	[SecurityCritical]
	private unsafe PipeStreamAsyncResult BeginReadCore(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		PipeStreamAsyncResult pipeStreamAsyncResult = new PipeStreamAsyncResult();
		pipeStreamAsyncResult._handle = m_handle;
		pipeStreamAsyncResult._userCallback = callback;
		pipeStreamAsyncResult._userStateObject = state;
		pipeStreamAsyncResult._isWrite = false;
		if (buffer.Length == 0)
		{
			pipeStreamAsyncResult.CallUserCallback();
		}
		else
		{
			ManualResetEvent manualResetEvent = (pipeStreamAsyncResult._waitHandle = new ManualResetEvent(initialState: false));
			Overlapped overlapped = new Overlapped(0, 0, IntPtr.Zero, pipeStreamAsyncResult);
			NativeOverlapped* ptr = (pipeStreamAsyncResult._overlapped = overlapped.Pack(IOCallback, buffer));
			int hr = 0;
			int num = ReadFileNative(m_handle, buffer, offset, count, ptr, out hr);
			if (num == -1)
			{
				switch (hr)
				{
				default:
					__Error.WinIOError(hr, string.Empty);
					break;
				case 109:
				case 233:
					State = PipeState.Broken;
					ptr->InternalLow = IntPtr.Zero;
					pipeStreamAsyncResult.CallUserCallback();
					break;
				case 997:
					break;
				}
			}
		}
		return pipeStreamAsyncResult;
	}

	[SecurityCritical]
	public unsafe override int EndRead(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!m_isAsync)
		{
			return base.EndRead(asyncResult);
		}
		PipeStreamAsyncResult pipeStreamAsyncResult = asyncResult as PipeStreamAsyncResult;
		if (pipeStreamAsyncResult == null || pipeStreamAsyncResult._isWrite)
		{
			__Error.WrongAsyncResult();
		}
		if (1 == Interlocked.CompareExchange(ref pipeStreamAsyncResult._EndXxxCalled, 1, 0))
		{
			__Error.EndReadCalledTwice();
		}
		WaitHandle waitHandle = pipeStreamAsyncResult._waitHandle;
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
		NativeOverlapped* overlapped = pipeStreamAsyncResult._overlapped;
		if (overlapped != null)
		{
			Overlapped.Free(overlapped);
		}
		if (pipeStreamAsyncResult._errorCode != 0)
		{
			WinIOError(pipeStreamAsyncResult._errorCode);
		}
		m_isMessageComplete = m_state == PipeState.Broken || pipeStreamAsyncResult._isMessageComplete;
		return pipeStreamAsyncResult._numBytes;
	}

	[SecurityCritical]
	public override void Write(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
		CheckWriteOperations();
		WriteCore(buffer, offset, count);
	}

	[SecurityCritical]
	private unsafe void WriteCore(byte[] buffer, int offset, int count)
	{
		if (m_isAsync)
		{
			IAsyncResult asyncResult = BeginWriteCore(buffer, offset, count, null, null);
			EndWrite(asyncResult);
			return;
		}
		int hr = 0;
		int num = WriteFileNative(m_handle, buffer, offset, count, null, out hr);
		if (num == -1)
		{
			WinIOError(hr);
		}
	}

	[SecurityCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
		}
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
		CheckWriteOperations();
		if (!m_isAsync)
		{
			return base.BeginWrite(buffer, offset, count, callback, state);
		}
		return BeginWriteCore(buffer, offset, count, callback, state);
	}

	[SecurityCritical]
	private unsafe PipeStreamAsyncResult BeginWriteCore(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		PipeStreamAsyncResult pipeStreamAsyncResult = new PipeStreamAsyncResult();
		pipeStreamAsyncResult._userCallback = callback;
		pipeStreamAsyncResult._userStateObject = state;
		pipeStreamAsyncResult._isWrite = true;
		pipeStreamAsyncResult._handle = m_handle;
		if (buffer.Length == 0)
		{
			pipeStreamAsyncResult.CallUserCallback();
		}
		else
		{
			ManualResetEvent manualResetEvent = (pipeStreamAsyncResult._waitHandle = new ManualResetEvent(initialState: false));
			Overlapped overlapped = new Overlapped(0, 0, IntPtr.Zero, pipeStreamAsyncResult);
			NativeOverlapped* ptr = (pipeStreamAsyncResult._overlapped = overlapped.Pack(IOCallback, buffer));
			int hr = 0;
			int num = WriteFileNative(m_handle, buffer, offset, count, ptr, out hr);
			if (num == -1 && hr != 997)
			{
				if (ptr != null)
				{
					Overlapped.Free(ptr);
				}
				WinIOError(hr);
			}
		}
		return pipeStreamAsyncResult;
	}

	[SecurityCritical]
	public unsafe override void EndWrite(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!m_isAsync)
		{
			base.EndWrite(asyncResult);
			return;
		}
		PipeStreamAsyncResult pipeStreamAsyncResult = asyncResult as PipeStreamAsyncResult;
		if (pipeStreamAsyncResult == null || !pipeStreamAsyncResult._isWrite)
		{
			__Error.WrongAsyncResult();
		}
		if (1 == Interlocked.CompareExchange(ref pipeStreamAsyncResult._EndXxxCalled, 1, 0))
		{
			__Error.EndWriteCalledTwice();
		}
		WaitHandle waitHandle = pipeStreamAsyncResult._waitHandle;
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
		NativeOverlapped* overlapped = pipeStreamAsyncResult._overlapped;
		if (overlapped != null)
		{
			Overlapped.Free(overlapped);
		}
		if (pipeStreamAsyncResult._errorCode != 0)
		{
			WinIOError(pipeStreamAsyncResult._errorCode);
		}
	}

	[SecurityCritical]
	private unsafe int ReadFileNative(SafePipeHandle handle, byte[] buffer, int offset, int count, NativeOverlapped* overlapped, out int hr)
	{
		if (buffer.Length == 0)
		{
			hr = 0;
			return 0;
		}
		int num = 0;
		int numBytesRead = 0;
		fixed (byte* ptr = buffer)
		{
			num = ((!m_isAsync) ? UnsafeNativeMethods.ReadFile(handle, ptr + offset, count, out numBytesRead, IntPtr.Zero) : UnsafeNativeMethods.ReadFile(handle, ptr + offset, count, IntPtr.Zero, overlapped));
		}
		if (num == 0)
		{
			hr = Marshal.GetLastWin32Error();
			if (hr == 234)
			{
				return numBytesRead;
			}
			return -1;
		}
		hr = 0;
		return numBytesRead;
	}

	[SecurityCritical]
	private unsafe int WriteFileNative(SafePipeHandle handle, byte[] buffer, int offset, int count, NativeOverlapped* overlapped, out int hr)
	{
		if (buffer.Length == 0)
		{
			hr = 0;
			return 0;
		}
		int numBytesWritten = 0;
		int num = 0;
		fixed (byte* ptr = buffer)
		{
			num = ((!m_isAsync) ? UnsafeNativeMethods.WriteFile(handle, ptr + offset, count, out numBytesWritten, IntPtr.Zero) : UnsafeNativeMethods.WriteFile(handle, ptr + offset, count, IntPtr.Zero, overlapped));
		}
		if (num == 0)
		{
			hr = Marshal.GetLastWin32Error();
			return -1;
		}
		hr = 0;
		return numBytesWritten;
	}

	[SecurityCritical]
	public override int ReadByte()
	{
		CheckReadOperations();
		if (!CanRead)
		{
			__Error.ReadNotSupported();
		}
		byte[] array = new byte[1];
		if (ReadCore(array, 0, 1) == 0)
		{
			return -1;
		}
		return array[0];
	}

	[SecurityCritical]
	public override void WriteByte(byte value)
	{
		CheckWriteOperations();
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
		WriteCore(new byte[1] { value }, 0, 1);
	}

	[SecurityCritical]
	public override void Flush()
	{
		CheckWriteOperations();
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
	}

	[SecurityCritical]
	public void WaitForPipeDrain()
	{
		CheckWriteOperations();
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
		if (!UnsafeNativeMethods.FlushFileBuffers(m_handle))
		{
			WinIOError(Marshal.GetLastWin32Error());
		}
	}

	[SecurityCritical]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (m_handle != null && !m_handle.IsClosed)
			{
				m_handle.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
		m_state = PipeState.Closed;
	}

	[SecurityCritical]
	private void UpdateReadMode()
	{
		if (!UnsafeNativeMethods.GetNamedPipeHandleState(SafePipeHandle, out var lpState, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, UnsafeNativeMethods.NULL, 0))
		{
			WinIOError(Marshal.GetLastWin32Error());
		}
		if (((uint)lpState & 2u) != 0)
		{
			m_readMode = PipeTransmissionMode.Message;
		}
		else
		{
			m_readMode = PipeTransmissionMode.Byte;
		}
	}

	[SecurityCritical]
	public PipeSecurity GetAccessControl()
	{
		if (m_state == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
		if (m_handle == null)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeHandleNotSet"));
		}
		if (m_handle.IsClosed)
		{
			__Error.PipeNotOpen();
		}
		return new PipeSecurity(m_handle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	[SecurityCritical]
	public void SetAccessControl(PipeSecurity pipeSecurity)
	{
		if (pipeSecurity == null)
		{
			throw new ArgumentNullException("pipeSecurity");
		}
		CheckPipePropertyOperations();
		pipeSecurity.Persist(m_handle);
	}

	public override void SetLength(long value)
	{
		__Error.SeekNotSupported();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		__Error.SeekNotSupported();
		return 0L;
	}

	[SecurityCritical]
	protected internal virtual void CheckPipePropertyOperations()
	{
		if (m_handle == null)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeHandleNotSet"));
		}
		if (m_state == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
		if (m_handle.IsClosed)
		{
			__Error.PipeNotOpen();
		}
	}

	[SecurityCritical]
	protected internal void CheckReadOperations()
	{
		if (m_state == PipeState.WaitingToConnect)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeNotYetConnected"));
		}
		if (m_state == PipeState.Disconnected)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeDisconnected"));
		}
		if (m_handle == null)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeHandleNotSet"));
		}
		if (m_state == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
		if (m_handle.IsClosed)
		{
			__Error.PipeNotOpen();
		}
	}

	[SecurityCritical]
	protected internal void CheckWriteOperations()
	{
		if (m_state == PipeState.WaitingToConnect)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeNotYetConnected"));
		}
		if (m_state == PipeState.Disconnected)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeDisconnected"));
		}
		if (m_handle == null)
		{
			throw new InvalidOperationException(SR.GetString("InvalidOperation_PipeHandleNotSet"));
		}
		if (m_state == PipeState.Broken)
		{
			throw new IOException(SR.GetString("IO_IO_PipeBroken"));
		}
		if (m_state == PipeState.Closed)
		{
			__Error.PipeNotOpen();
		}
		if (m_handle.IsClosed)
		{
			__Error.PipeNotOpen();
		}
	}

	[SecurityCritical]
	internal void WinIOError(int errorCode)
	{
		switch (errorCode)
		{
		case 38:
			__Error.EndOfFile();
			return;
		case 6:
			m_handle.SetHandleAsInvalid();
			m_state = PipeState.Broken;
			break;
		case 109:
		case 232:
		case 233:
			m_state = PipeState.Broken;
			throw new IOException(SR.GetString("IO_IO_PipeBroken"), UnsafeNativeMethods.MakeHRFromErrorCode(errorCode));
		}
		__Error.WinIOError(errorCode, string.Empty);
	}

	[SecurityCritical]
	internal unsafe static UnsafeNativeMethods.SECURITY_ATTRIBUTES GetSecAttrs(HandleInheritability inheritability, PipeSecurity pipeSecurity, out object pinningHandle)
	{
		pinningHandle = null;
		UnsafeNativeMethods.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if ((inheritability & HandleInheritability.Inheritable) != 0 || pipeSecurity != null)
		{
			sECURITY_ATTRIBUTES = new UnsafeNativeMethods.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf((object)sECURITY_ATTRIBUTES);
			if ((inheritability & HandleInheritability.Inheritable) != 0)
			{
				sECURITY_ATTRIBUTES.bInheritHandle = 1;
			}
			if (pipeSecurity != null)
			{
				byte[] securityDescriptorBinaryForm = pipeSecurity.GetSecurityDescriptorBinaryForm();
				pinningHandle = GCHandle.Alloc(securityDescriptorBinaryForm, GCHandleType.Pinned);
				fixed (byte* pSecurityDescriptor = securityDescriptorBinaryForm)
				{
					sECURITY_ATTRIBUTES.pSecurityDescriptor = pSecurityDescriptor;
				}
			}
		}
		return sECURITY_ATTRIBUTES;
	}

	[SecurityCritical]
	internal static UnsafeNativeMethods.SECURITY_ATTRIBUTES GetSecAttrs(HandleInheritability inheritability)
	{
		UnsafeNativeMethods.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if ((inheritability & HandleInheritability.Inheritable) != 0)
		{
			sECURITY_ATTRIBUTES = new UnsafeNativeMethods.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf((object)sECURITY_ATTRIBUTES);
			sECURITY_ATTRIBUTES.bInheritHandle = 1;
		}
		return sECURITY_ATTRIBUTES;
	}

	[SecurityCritical]
	private unsafe static void AsyncPSCallback(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped)
	{
		Overlapped overlapped = Overlapped.Unpack(pOverlapped);
		PipeStreamAsyncResult pipeStreamAsyncResult = (PipeStreamAsyncResult)overlapped.AsyncResult;
		pipeStreamAsyncResult._numBytes = (int)numBytes;
		if (!pipeStreamAsyncResult._isWrite && (errorCode == 109 || errorCode == 233 || errorCode == 232))
		{
			errorCode = 0u;
			numBytes = 0u;
		}
		if (errorCode == 234)
		{
			errorCode = 0u;
			pipeStreamAsyncResult._isMessageComplete = false;
		}
		else
		{
			pipeStreamAsyncResult._isMessageComplete = true;
		}
		pipeStreamAsyncResult._errorCode = (int)errorCode;
		pipeStreamAsyncResult._completedSynchronously = false;
		pipeStreamAsyncResult._isComplete = true;
		ManualResetEvent waitHandle = pipeStreamAsyncResult._waitHandle;
		if (waitHandle != null && !waitHandle.Set())
		{
			__Error.WinIOError();
		}
		pipeStreamAsyncResult._userCallback?.Invoke(pipeStreamAsyncResult);
	}
}

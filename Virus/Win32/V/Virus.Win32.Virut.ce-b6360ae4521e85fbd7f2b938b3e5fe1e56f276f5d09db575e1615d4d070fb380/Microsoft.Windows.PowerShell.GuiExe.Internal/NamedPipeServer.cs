using System;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace Microsoft.Windows.PowerShell.GuiExe.Internal;

internal class NamedPipeServer
{
	internal enum TestResults
	{
		ConnectionPending = 1,
		CancelConnection,
		ConnectionResultFailedBeforeWait,
		ConnectionResultFailedAfterWait,
		ConnectionSuccededWithErrorConnected,
		ConnectionSuccededAfterWait,
		ConnectionReadyToGetResult,
		ConnectionResultSuccesfull,
		ReadResultSuccessfull,
		CancelRead,
		ReadOverlappedResultSuccessfull,
		ReadMoreData,
		ReadFailureWaiting,
		ReadFailureNoWaiting,
		DisconnectionFailure,
		DisconnectionSuccess
	}

	[TraceSource("PowerShellISENamedPipe", "tracer for NamedPipe")]
	internal static readonly PSTraceSource Tracer = PSTraceSource.GetTracer("PowerShellISENamedPipe", "tracer for NamedPipe");

	private static readonly uint BufferSize = 1024u;

	private static SecurityIdentifier logonSid = null;

	private static bool useTestName;

	private Thread startListeningThread;

	private IntPtr stopListeningEvent;

	private MethodInfo openMethod;

	private NamedPipeSafeHandle pipeHandle;

	private FileInfo pipeNameFile;

	private IntPtr pipeEvent;

	private AutoResetEvent testServerPauseEvent;

	private AutoResetEvent testPauseEvent;

	private SendOrPostCallback testResultCallback;

	internal static SecurityIdentifier LogonSid
	{
		get
		{
			if (logonSid == null)
			{
				logonSid = GetLogonSid();
			}
			return logonSid;
		}
	}

	internal static bool UseTestName
	{
		get
		{
			return useTestName;
		}
		set
		{
			useTestName = value;
		}
	}

	internal AutoResetEvent TestServerPauseEvent
	{
		get
		{
			return testServerPauseEvent;
		}
		set
		{
			testServerPauseEvent = value;
		}
	}

	internal AutoResetEvent TestPauseEvent
	{
		get
		{
			return testPauseEvent;
		}
		set
		{
			testPauseEvent = value;
		}
	}

	internal SendOrPostCallback TestResultCallback
	{
		get
		{
			return testResultCallback;
		}
		set
		{
			testResultCallback = value;
		}
	}

	internal NamedPipeServer(MethodInfo openMethod)
	{
		this.openMethod = openMethod;
	}

	internal static string[] GetLogonSidPath()
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(typeof(NamedPipeServer).Assembly.Location);
		return new string[3]
		{
			"microsoft",
			fileNameWithoutExtension,
			LogonSid.ToString()
		};
	}

	internal static string GetPipeNameStart()
	{
		return "PowerShellISEPipeName_" + (UseTestName ? "2" : (IsAdmin() ? "1" : "0")) + "_";
	}

	internal static DirectoryInfo GetApplicationDataPath(string[] path)
	{
		DirectoryInfo directoryInfo = CreateDirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		if (directoryInfo != null && directoryInfo.Exists)
		{
			int num = 0;
			while (true)
			{
				if (num < path.Length)
				{
					string path2 = path[num];
					directoryInfo = CreateDirectoryInfo(Path.Combine(directoryInfo.FullName, path2));
					if (directoryInfo == null || !directoryInfo.Exists)
					{
						break;
					}
					num++;
					continue;
				}
				return directoryInfo;
			}
			return null;
		}
		return null;
	}

	internal static FileInfo GetFirstFileInfoStartingWith(DirectoryInfo parent, string str)
	{
		FileInfo[] files = parent.GetFiles();
		int num = 0;
		FileInfo fileInfo;
		while (true)
		{
			if (num < files.Length)
			{
				fileInfo = files[num];
				if (fileInfo.Name.StartsWith(str, StringComparison.Ordinal))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return fileInfo;
	}

	internal void StopListening()
	{
		if (!NativeMethods.SetEvent(stopListeningEvent))
		{
			Tracer.TraceError("Server: Could not set the cancelling event.", new object[0]);
		}
		startListeningThread.Join();
		if (pipeEvent != IntPtr.Zero)
		{
			NativeMethods.CloseHandle(pipeEvent);
		}
		if (stopListeningEvent != IntPtr.Zero)
		{
			NativeMethods.CloseHandle(stopListeningEvent);
		}
		pipeHandle.Dispose();
		TryDecrementCountOrDeletePipeNameFile();
	}

	internal bool CreateNamedPipe(bool resetReferenceCount)
	{
		if (LogonSid == null)
		{
			Tracer.TraceError("Server: Error retrieving log on sid, creation of pipe canceled", new object[0]);
			return false;
		}
		stopListeningEvent = NativeMethods.CreateEvent(IntPtr.Zero, bManualReset: true, bInitialState: false, null);
		if (stopListeningEvent == IntPtr.Zero)
		{
			Tracer.TraceError("Server: Could not create cancelation event", new object[0]);
			return false;
		}
		pipeEvent = NativeMethods.CreateEvent(IntPtr.Zero, bManualReset: true, bInitialState: true, null);
		if (pipeEvent == IntPtr.Zero)
		{
			Tracer.TraceError("Server: Could not create pipe event", new object[0]);
			return false;
		}
		pipeNameFile = CreatePipeNameIfNecessary();
		if (pipeNameFile == null)
		{
			Tracer.TraceError("Server: Error retrieving pipe name, creation of pipe canceled", new object[0]);
			return false;
		}
		string lpName = "\\\\.\\pipe\\" + pipeNameFile.Name;
		GCHandle securityDescriptor = CreateSecurityDescriptor(LogonSid);
		pipeHandle = NativeMethods.CreateNamedPipe(lpName, 1073741825u, 6u, 255u, 0u, 2 * BufferSize, 0u, GetSessionSecurityAttributes(securityDescriptor));
		int lastWin32Error = Marshal.GetLastWin32Error();
		securityDescriptor.Free();
		if (pipeHandle.IsInvalid)
		{
			Tracer.TraceError("Server: Invalid Handle. error: '{0}'", new object[1] { lastWin32Error });
			return false;
		}
		int value;
		if (resetReferenceCount)
		{
			if (!TrySetPipeNameReferenceCount(pipeNameFile, 1))
			{
				Tracer.TraceError("Server: Could not set Named pipe reference count", new object[0]);
			}
		}
		else if (TryGetPipeNameReferenceCount(pipeNameFile, out value))
		{
			if (!TrySetPipeNameReferenceCount(pipeNameFile, value + 1))
			{
				Tracer.TraceError("Server: Could not set decremented Named pipe reference count", new object[0]);
			}
		}
		else
		{
			Tracer.TraceError("Server: Could not get initial Named pipe reference count", new object[0]);
		}
		Tracer.WriteLine("Server: Created Pipe", new object[0]);
		return true;
	}

	internal void StartListening()
	{
		startListeningThread = new Thread(StartListeningThreadStart);
		startListeningThread.Name = "PowerShell ISE NamedPipe Server";
		startListeningThread.Start();
	}

	private static bool TryCreateText(FileInfo file, out StreamWriter stream)
	{
		stream = null;
		try
		{
			stream = file.CreateText();
		}
		catch (IOException ex)
		{
			Tracer.TraceException((Exception)ex);
			return false;
		}
		catch (UnauthorizedAccessException ex2)
		{
			Tracer.TraceException((Exception)ex2);
			return false;
		}
		catch (SecurityException ex3)
		{
			Tracer.TraceException((Exception)ex3);
			return false;
		}
		return true;
	}

	private static bool TryOpenText(FileInfo file, out StreamReader stream)
	{
		stream = null;
		try
		{
			stream = file.OpenText();
		}
		catch (FileNotFoundException ex)
		{
			Tracer.TraceException((Exception)ex);
			return false;
		}
		catch (DirectoryNotFoundException ex2)
		{
			Tracer.TraceException((Exception)ex2);
			return false;
		}
		catch (UnauthorizedAccessException ex3)
		{
			Tracer.TraceException((Exception)ex3);
			return false;
		}
		catch (SecurityException ex4)
		{
			Tracer.TraceException((Exception)ex4);
			return false;
		}
		return true;
	}

	private static bool TryGetPipeNameReferenceCount(FileInfo file, out int value)
	{
		value = 0;
		if (!TryOpenText(file, out var stream))
		{
			return false;
		}
		using (stream)
		{
			try
			{
				string s = stream.ReadToEnd();
				if (!int.TryParse(s, out value) || value < 0)
				{
					Tracer.TraceError("Server: NamedPipe file contents was not a positive integer", new object[0]);
					return false;
				}
			}
			catch (IOException ex)
			{
				Tracer.TraceException((Exception)ex);
				return false;
			}
		}
		return true;
	}

	private static bool TrySetPipeNameReferenceCount(FileInfo file, int value)
	{
		if (!TryCreateText(file, out var stream))
		{
			return false;
		}
		using (stream)
		{
			try
			{
				stream.WriteLine(value.ToString(CultureInfo.InvariantCulture));
			}
			catch (IOException ex)
			{
				Tracer.TraceException((Exception)ex);
				return false;
			}
		}
		return true;
	}

	private static SecurityIdentifier GetLogonSid()
	{
		IntPtr currentProcess = NativeMethods.GetCurrentProcess();
		if (currentProcess == IntPtr.Zero)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			Tracer.TraceError("Retrieved null process handle: '{0}'.", new object[1] { lastWin32Error });
			return null;
		}
		if (!NativeMethods.OpenProcessToken(currentProcess, 8u, out var TokenHandle))
		{
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			Tracer.TraceError("Could not retrieve process token: '{0}'.", new object[1] { lastWin32Error2 });
			return null;
		}
		uint ReturnLength = 0u;
		if (NativeMethods.GetTokenInformation(TokenHandle, 2, IntPtr.Zero, 0u, ref ReturnLength) != 0)
		{
			int lastWin32Error3 = Marshal.GetLastWin32Error();
			Tracer.TraceError("Error retrieving group byte length for process token: '{0}'.", new object[1] { lastWin32Error3 });
			return null;
		}
		IntPtr intPtr = Marshal.AllocHGlobal((int)ReturnLength);
		try
		{
			if (NativeMethods.GetTokenInformation(TokenHandle, 2, intPtr, ReturnLength, ref ReturnLength) == 0)
			{
				int lastWin32Error4 = Marshal.GetLastWin32Error();
				Tracer.TraceError("Error retrieving groups for process token: '{0}'.", new object[1] { lastWin32Error4 });
				return null;
			}
			NativeMethods.TOKEN_GROUPS tOKEN_GROUPS = (NativeMethods.TOKEN_GROUPS)Marshal.PtrToStructure(intPtr, typeof(NativeMethods.TOKEN_GROUPS));
			IntPtr ptr = new IntPtr(intPtr.ToInt64() + Marshal.SizeOf(typeof(NativeMethods.TOKEN_GROUPS)) - Marshal.SizeOf(typeof(NativeMethods.SID_AND_ATTRIBUTES)));
			for (int i = 0; i < tOKEN_GROUPS.GroupCount; i++)
			{
				NativeMethods.SID_AND_ATTRIBUTES sID_AND_ATTRIBUTES = (NativeMethods.SID_AND_ATTRIBUTES)Marshal.PtrToStructure(ptr, typeof(NativeMethods.SID_AND_ATTRIBUTES));
				if ((sID_AND_ATTRIBUTES.Attributes & 0xC0000000u) == 0)
				{
					ptr = new IntPtr(ptr.ToInt64() + Marshal.SizeOf((object)sID_AND_ATTRIBUTES));
					continue;
				}
				return new SecurityIdentifier(sID_AND_ATTRIBUTES.Sid);
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return null;
	}

	private static DirectoryInfo CreateDirectoryInfo(string fullPath)
	{
		try
		{
			return new DirectoryInfo(fullPath);
		}
		catch (SecurityException ex)
		{
			Tracer.TraceException((Exception)ex);
			return null;
		}
	}

	private static DirectoryInfo CreateChildPathIfNecessary(DirectoryInfo parent, string childPath)
	{
		DirectoryInfo directoryInfo = CreateDirectoryInfo(Path.Combine(parent.FullName, childPath));
		if (directoryInfo == null)
		{
			return null;
		}
		if (!directoryInfo.Exists)
		{
			try
			{
				directoryInfo.Create();
			}
			catch (IOException ex)
			{
				Tracer.TraceException((Exception)ex);
				return null;
			}
			directoryInfo.Refresh();
		}
		return directoryInfo;
	}

	private static DirectoryInfo CreateApplicationDataPath(string[] path)
	{
		DirectoryInfo directoryInfo = CreateDirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		if (directoryInfo != null && directoryInfo.Exists)
		{
			int num = 0;
			while (true)
			{
				if (num < path.Length)
				{
					string childPath = path[num];
					directoryInfo = CreateChildPathIfNecessary(directoryInfo, childPath);
					if (directoryInfo == null)
					{
						break;
					}
					num++;
					continue;
				}
				return directoryInfo;
			}
			return null;
		}
		return null;
	}

	private static FileInfo CreatePipeNameIfNecessary()
	{
		if (LogonSid == null)
		{
			return null;
		}
		DirectoryInfo directoryInfo = CreateApplicationDataPath(GetLogonSidPath());
		if (directoryInfo == null)
		{
			return null;
		}
		string pipeNameStart = GetPipeNameStart();
		FileInfo firstFileInfoStartingWith = GetFirstFileInfoStartingWith(directoryInfo, pipeNameStart);
		if (firstFileInfoStartingWith != null)
		{
			return firstFileInfoStartingWith;
		}
		string text = Path.Combine(directoryInfo.FullName, pipeNameStart + Guid.NewGuid());
		try
		{
			File.CreateText(text).Close();
		}
		catch (UnauthorizedAccessException ex)
		{
			Tracer.TraceException((Exception)ex);
			return null;
		}
		return new FileInfo(text);
	}

	private static bool IsAdmin()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static GCHandle CreateSecurityDescriptor(SecurityIdentifier sid)
	{
		DiscretionaryAcl discretionaryAcl = new DiscretionaryAcl(isContainer: false, isDS: false, 1);
		discretionaryAcl.AddAccess(AccessControlType.Allow, sid, -1, InheritanceFlags.None, PropagationFlags.None);
		CommonSecurityDescriptor commonSecurityDescriptor = new CommonSecurityDescriptor(isContainer: false, isDS: false, ControlFlags.OwnerDefaulted | ControlFlags.GroupDefaulted | ControlFlags.DiscretionaryAclPresent, null, null, null, discretionaryAcl);
		byte[] array = new byte[commonSecurityDescriptor.BinaryLength];
		commonSecurityDescriptor.GetBinaryForm(array, 0);
		return GCHandle.Alloc(array, GCHandleType.Pinned);
	}

	private static NativeMethods.SECURITY_ATTRIBUTES GetSessionSecurityAttributes(GCHandle securityDescriptor)
	{
		NativeMethods.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = new NativeMethods.SECURITY_ATTRIBUTES();
		sECURITY_ATTRIBUTES.InheritHandle = true;
		sECURITY_ATTRIBUTES.NLength = Marshal.SizeOf((object)sECURITY_ATTRIBUTES);
		sECURITY_ATTRIBUTES.LPSecurityDescriptor = securityDescriptor.AddrOfPinnedObject();
		return sECURITY_ATTRIBUTES;
	}

	private static bool TryDeleteFile(FileInfo file)
	{
		try
		{
			file.Delete();
		}
		catch (SecurityException ex)
		{
			Tracer.TraceException((Exception)ex);
			return false;
		}
		catch (IOException ex2)
		{
			Tracer.TraceException((Exception)ex2);
			return false;
		}
		catch (UnauthorizedAccessException ex3)
		{
			Tracer.TraceException((Exception)ex3);
			return false;
		}
		return true;
	}

	private static bool TryDeleteDirectory(DirectoryInfo directory)
	{
		try
		{
			directory.Delete();
		}
		catch (SecurityException ex)
		{
			Tracer.TraceException((Exception)ex);
			return false;
		}
		catch (IOException ex2)
		{
			Tracer.TraceException((Exception)ex2);
			return false;
		}
		return true;
	}

	private void StartListeningThreadStart()
	{
		byte[] array = new byte[BufferSize];
		NativeOverlapped lpOverlapped = default(NativeOverlapped);
		lpOverlapped.EventHandle = pipeEvent;
		IntPtr[] lpHandles = new IntPtr[2] { pipeEvent, stopListeningEvent };
		while (true)
		{
			TestPause();
			bool flag = NativeMethods.ConnectNamedPipe(pipeHandle, ref lpOverlapped);
			int lastWin32Error = Marshal.GetLastWin32Error();
			uint lpNumberOfBytesTransferred;
			if (lastWin32Error != 997L)
			{
				if (lastWin32Error != 535L)
				{
					TestCallback(TestResults.ConnectionResultFailedBeforeWait);
					TestCallback((TestResults)lastWin32Error);
					if (!NativeMethods.DisconnectNamedPipe(pipeHandle))
					{
						int lastWin32Error2 = Marshal.GetLastWin32Error();
						TestCallback(TestResults.DisconnectionFailure);
						Tracer.TraceError("Server: DisconnectNamedPipe failed with {0}", new object[1] { lastWin32Error2 });
					}
					Tracer.TraceError("Server: ConnectNamedPipe failed with {0}.", new object[1] { lastWin32Error });
					continue;
				}
				TestCallback(TestResults.ConnectionSuccededWithErrorConnected);
			}
			else
			{
				TestCallback(TestResults.ConnectionPending);
				TestPause();
				if (NativeMethods.WaitForMultipleObjects(2u, lpHandles, bWaitAll: false, uint.MaxValue) != 0)
				{
					break;
				}
				TestCallback(TestResults.ConnectionReadyToGetResult);
				flag = NativeMethods.GetOverlappedResult(pipeHandle, ref lpOverlapped, out lpNumberOfBytesTransferred, bWait: false);
				lastWin32Error = Marshal.GetLastWin32Error();
				if (!flag)
				{
					TestCallback(TestResults.ConnectionResultFailedAfterWait);
					TestCallback((TestResults)lastWin32Error);
					Tracer.TraceError("Server: GetOverlappedResult after a ConnectNamedPipe failed with {0}", new object[1] { lastWin32Error });
					continue;
				}
				TestCallback(TestResults.ConnectionSuccededAfterWait);
			}
			TestCallback(TestResults.ConnectionResultSuccesfull);
			StringBuilder stringBuilder = new StringBuilder();
			while (true)
			{
				TestPause();
				flag = NativeMethods.ReadFile(pipeHandle, array, BufferSize, out lpNumberOfBytesTransferred, ref lpOverlapped);
				lastWin32Error = Marshal.GetLastWin32Error();
				if (!flag)
				{
					if (lastWin32Error == 234L || lastWin32Error == 997L)
					{
						TestPause();
						if (NativeMethods.WaitForMultipleObjects(2u, lpHandles, bWaitAll: false, uint.MaxValue) == 0)
						{
							flag = NativeMethods.GetOverlappedResult(pipeHandle, ref lpOverlapped, out lpNumberOfBytesTransferred, bWait: false);
							lastWin32Error = Marshal.GetLastWin32Error();
							if (!flag)
							{
								if (lastWin32Error == 234L)
								{
									TestCallback(TestResults.ReadMoreData);
									string @string = Encoding.Unicode.GetString(array, 0, (int)lpNumberOfBytesTransferred);
									Tracer.WriteLine("Server: Read partial string: {0}", new object[1] { @string });
									stringBuilder.Append(@string);
									continue;
								}
								TestCallback(TestResults.ReadFailureWaiting);
								TestCallback((TestResults)lastWin32Error);
								Tracer.TraceError("Server: GetOverlappedResult after a ReadFile failed with{0}", new object[1] { lastWin32Error });
								break;
							}
							TestCallback(TestResults.ReadOverlappedResultSuccessfull);
							string string2 = Encoding.Unicode.GetString(array, 0, (int)lpNumberOfBytesTransferred);
							InvokeOpenMethod(stringBuilder, string2);
							break;
						}
						if (!NativeMethods.DisconnectNamedPipe(pipeHandle))
						{
							lastWin32Error = Marshal.GetLastWin32Error();
							TestCallback((TestResults)lastWin32Error);
							Tracer.TraceError("Server: DisconnectNamedPipe failed after cancelling with {0}", new object[1] { lastWin32Error });
						}
						TestCallback(TestResults.CancelRead);
						return;
					}
					TestCallback(TestResults.ReadFailureNoWaiting);
					TestCallback((TestResults)lastWin32Error);
					Tracer.TraceError("Server: ReadFile failed with {0}", new object[1] { lastWin32Error });
					break;
				}
				TestCallback(TestResults.ReadResultSuccessfull);
				string string3 = Encoding.Unicode.GetString(array, 0, (int)lpNumberOfBytesTransferred);
				InvokeOpenMethod(stringBuilder, string3);
				break;
			}
			TestPause();
			if (!NativeMethods.DisconnectNamedPipe(pipeHandle))
			{
				int lastWin32Error3 = Marshal.GetLastWin32Error();
				TestCallback(TestResults.DisconnectionFailure);
				Tracer.TraceError("Server: DisconnectNamedPipe failed with {0}", new object[1] { lastWin32Error3 });
			}
			TestCallback(TestResults.DisconnectionSuccess);
		}
		TestCallback(TestResults.CancelConnection);
	}

	private void TestCallback(TestResults result)
	{
		if (testResultCallback != null)
		{
			testResultCallback(result);
		}
	}

	private void TestPause()
	{
		if (testServerPauseEvent != null && testPauseEvent != null)
		{
			testPauseEvent.Set();
			testServerPauseEvent.WaitOne();
		}
	}

	private void InvokeOpenMethod(StringBuilder stringSoFar, string finalString)
	{
		stringSoFar.Append(finalString);
		finalString = stringSoFar.ToString();
		if (!finalString.Equals("fe886c82-edda-4016-bcbb-bd5788201338", StringComparison.Ordinal))
		{
			openMethod.Invoke(null, new object[1] { new string[1] { finalString } });
		}
		Tracer.WriteLine("Server: Read final string: {0}", new object[1] { finalString });
	}

	private void TryDecrementCountOrDeletePipeNameFile()
	{
		if (!TryGetPipeNameReferenceCount(pipeNameFile, out var value))
		{
			Tracer.TraceError("Server: Could not get Named pipe reference count, will try to delete the file.", new object[0]);
			TryDeletePipeNameFile();
		}
		else if (value == 1)
		{
			TryDeletePipeNameFile();
		}
		else if (!TrySetPipeNameReferenceCount(pipeNameFile, value - 1))
		{
			Tracer.TraceError("Server: Could not decrement Named pipe reference count", new object[0]);
		}
	}

	private void TryDeletePipeNameFile()
	{
		if (!TryDeleteFile(pipeNameFile))
		{
			Tracer.TraceError("Server: Could not delete pipe name file '{0}'.", new object[1] { pipeNameFile.FullName });
		}
		else if (pipeNameFile.Directory!.GetFiles().Length == 0 && !TryDeleteDirectory(pipeNameFile.Directory))
		{
			Tracer.TraceError("Server: Could not delete pipe name directory '{0}'.", new object[1] { pipeNameFile.Directory!.FullName });
		}
	}
}

#define TRACE
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using Arbus.Client.Base;
using Arbus.Client.BusinessObjects;
using Arbus.Common;
using MBackMonitor.NamedPipe;
using Microsoft.Win32;

namespace MBackMonitor;

public class MBackMonitor : ServiceBase
{
	private const string SHRED_DRV_START = "Global\\SHRED_DRV_START";

	private const string SHRED_DRV_END = "Global\\SHRED_DRV_END";

	private const string MBK_DRV_WATCH = "Global\\MBK_DRV_WATCH";

	private const string sProductPath1 = "McAfee\\MBK";

	private Container components = null;

	private PAEAgent objPAEAgent;

	private PCEAgent objPCEAgent;

	private static Mutex mtx = null;

	private bool bShouldExit;

	private bool bAlreadyStarted;

	private bool bHasAnyUserLoggedIn;

	private ApplicationMode objApplicationMode;

	private Thread thrdMutexWatcher;

	private PipeManager oPipeManager = null;

	private Thread messageThread = null;

	public bool AlreadyStarted
	{
		get
		{
			lock (this)
			{
				return bAlreadyStarted;
			}
		}
		set
		{
			lock (this)
			{
				bAlreadyStarted = value;
			}
		}
	}

	public MBackMonitor()
	{
		InitializeComponent();
		bShouldExit = false;
		bAlreadyStarted = false;
		((ServiceBase)this).set_CanHandlePowerEvent(true);
		bHasAnyUserLoggedIn = false;
	}

	private static void Main()
	{
		ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
		{
			new MBackMonitor()
		};
		ServiceBase.Run(array);
	}

	private void InitializeComponent()
	{
		components = new Container();
		((ServiceBase)this).set_ServiceName("MBackMonitor");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	public static ApplicationMode GetApplicationMode()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		ApplicationMode val = (ApplicationMode)0;
		try
		{
			RegistryPermission val2 = new RegistryPermission((RegistryPermissionAccess)1, "HKEY_LOCAL_MACHINE\\Software");
			((CodeAccessPermission)val2).Demand();
		}
		catch (SecurityException ex)
		{
			ExceptionPublisher.Publish((Exception)ex);
			val = (ApplicationMode)2;
			return (ApplicationMode)2;
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\McAfee\\MBK\\Remote");
			if (registryKey == null)
			{
				val = (ApplicationMode)2;
				return (ApplicationMode)2;
			}
			object value = registryKey.GetValue("Remote");
			if (value == null)
			{
				val = (ApplicationMode)2;
				return (ApplicationMode)2;
			}
			uint num = Convert.ToUInt32(value);
			if (num == 1)
			{
				return (ApplicationMode)3;
			}
			return (ApplicationMode)2;
		}
		catch (Exception ex2)
		{
			ExceptionPublisher.Publish(ex2);
			return (ApplicationMode)2;
		}
	}

	protected override void OnStart(string[] args)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			AddLoginAppToStartup("LogOnHook.exe");
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
		}
		try
		{
			objApplicationMode = GetApplicationMode();
			oPipeManager = new PipeManager();
			oPipeManager.OnMessageRecieved += oPipeManager_OnMessageRecieved;
			thrdMutexWatcher = new Thread(MutexWatcher);
			thrdMutexWatcher.Name = "Mutex Watcher";
			thrdMutexWatcher.IsBackground = true;
			thrdMutexWatcher.Start();
		}
		catch (Exception ex2)
		{
			ExceptionPublisher.Publish(ex2);
			Environment.Exit(1);
		}
	}

	protected override void OnStop()
	{
		try
		{
			bShouldExit = true;
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
		}
		finally
		{
			oPipeManager.Stop();
		}
	}

	protected override void OnShutdown()
	{
		((ServiceBase)this).OnShutdown();
		bShouldExit = true;
		ScheduleHelper scheduleHelper = ScheduleHelper.CreateScheduleHelper();
		scheduleHelper.PersistSystemShutdown(SessionEndReason.ShutDown, DateTime.Now);
		Environment.Exit(0);
	}

	private bool CheckAppCloseTime()
	{
		ScheduleHelper scheduleHelper = ScheduleHelper.CreateScheduleHelper();
		return scheduleHelper.CheckAppEndTimeDiffrenece(allowableTimeSpan: new TimeSpan(0, 0, 0, 5), dtTimeToCheck: DateTime.Now);
	}

	private void objPAEAgent_OnWatcherError(object sender, EventArgs e)
	{
		ScheduleHelper scheduleHelper = ScheduleHelper.CreateScheduleHelper();
		scheduleHelper.PersistShouldVerify(shouldVerify: true);
	}

	private void objPCEAgent_OnWatcherError(object sender, EventArgs e)
	{
		ScheduleHelper scheduleHelper = ScheduleHelper.CreateScheduleHelper();
		scheduleHelper.PersistShouldVerify(shouldVerify: true);
	}

	private void ShredderHandler()
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Invalid comparison between Unknown and I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Invalid comparison between Unknown and I4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Invalid comparison between Unknown and I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Invalid comparison between Unknown and I4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Invalid comparison between Unknown and I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Invalid comparison between Unknown and I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Invalid comparison between Unknown and I4
		Mutex mutex = null;
		Mutex mutex2 = null;
		Thread.Sleep(3000);
		IntPtr zero = IntPtr.Zero;
		int num = 0;
		zero = MutexWrapper.CreateMutexManaged(true, "Global\\MBK_DRV_WATCH", false, ref num);
		if (zero == IntPtr.Zero)
		{
			ExceptionPublisher.Publish(new Exception("Unable to create MBK mutex required for shredder communication. Error Code =" + num));
			return;
		}
		try
		{
			while (true)
			{
				try
				{
					int num2 = MutexWrapper.WaitForSingleObjectManaged(zero, 2000);
					if (num2 != 0)
					{
						ExceptionPublisher.Publish(new Exception("Inside Shredder Handler; The reason for the wait abandon is other then the normal. Error Code =" + num2));
						break;
					}
					bool flag = false;
					while (mutex2 == null && (flag = AlreadyStarted))
					{
						mutex2 = new Mutex(initiallyOwned: false, "Global\\SHRED_DRV_START", out var createdNew);
						if (createdNew)
						{
							mutex2.Close();
							mutex2 = null;
						}
						Thread.Sleep(500);
					}
					if (!flag)
					{
						break;
					}
					mutex2.WaitOne();
					mutex2.Close();
					WatchInfo[] array = null;
					if ((int)objApplicationMode == 3 || (int)objApplicationMode == 1)
					{
						WatchManager watchManager = objPCEAgent.WatchManager;
						watchManager.RemoveDrivewatcher();
						Watcher[] watchers = watchManager.GetWatchers();
						array = (WatchInfo[])(object)new WatchInfo[watchers.Length];
						int num3 = 0;
						Watcher[] array2 = watchers;
						foreach (Watcher val in array2)
						{
							array[num3] = val.get_WatchInfo();
							num3++;
						}
						watchManager.DeleteAllWatchers();
					}
					WatchInfo[] array3 = null;
					if ((int)objApplicationMode == 3 || (int)objApplicationMode == 2)
					{
						WatchManager watchManager2 = objPAEAgent.WatchManager;
						watchManager2.RemoveDrivewatcher();
						Watcher[] watchers2 = watchManager2.GetWatchers();
						int num4 = 0;
						array3 = (WatchInfo[])(object)new WatchInfo[watchers2.Length];
						Watcher[] array2 = watchers2;
						foreach (Watcher val2 in array2)
						{
							array3[num4] = val2.get_WatchInfo();
							num4++;
						}
						watchManager2.DeleteAllWatchers();
					}
					int num5 = MutexWrapper.ReleaseMutexManaged(zero);
					if (num5 != 0)
					{
						ExceptionPublisher.Publish(new Exception("An exception occured while releasing the MBK_DRV_WATCH mutex. Error Code=" + num5));
					}
					mutex = new Mutex(initiallyOwned: false, "Global\\SHRED_DRV_END", out var _);
					mutex.WaitOne();
					if ((int)objApplicationMode == 3 || (int)objApplicationMode == 1)
					{
						ReEngageAllXWatchers(objPCEAgent.WatchManager, array);
					}
					if ((int)objApplicationMode == 3 || (int)objApplicationMode == 2)
					{
						ReEngageAllXWatchers(objPAEAgent.WatchManager, array3);
					}
					mutex.Close();
				}
				catch (Exception ex)
				{
					ExceptionPublisher.Publish(ex);
				}
				finally
				{
					mutex = null;
					mutex2 = null;
				}
			}
		}
		finally
		{
			if (zero != IntPtr.Zero)
			{
				Win32Interop.ReleaseMutex(zero);
				Win32Interop.CloseHandle(zero);
				zero = IntPtr.Zero;
			}
		}
	}

	private void ReEngageAllXWatchers(WatchManager watchManager, WatchInfo[] watchinfos)
	{
		watchManager.CreateDriveWatcher();
		foreach (WatchInfo val in watchinfos)
		{
			try
			{
				watchManager.AddWatch(val);
			}
			catch (Exception ex)
			{
				ExceptionPublisher.Publish(ex);
			}
		}
	}

	private void AddLoginAppToStartup(string appName)
	{
		string value = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogOnHook.exe");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("MBkLogOnHook", value);
	}

	private void MutexWatcher()
	{
		while (!bShouldExit)
		{
			mtx = new Mutex(initiallyOwned: false, "Global\\C490284A-59A0-4b14-BB0B-9A90E3978C68", out var createdNew);
			if (createdNew)
			{
				mtx.Close();
				mtx = null;
				if (!bAlreadyStarted && bHasAnyUserLoggedIn)
				{
					try
					{
						Trace.WriteLine("Application Exited");
						AlreadyStarted = true;
						StartWatching();
					}
					catch (Exception ex)
					{
						bAlreadyStarted = false;
						Trace.WriteLine("Application Exited Exception");
						ExceptionPublisher.Publish(ex);
						ScheduleHelper scheduleHelper = ScheduleHelper.CreateScheduleHelper();
						try
						{
							scheduleHelper.PersistShouldVerify(shouldVerify: true);
						}
						catch (Exception ex2)
						{
							ExceptionPublisher.Publish(ex2);
						}
					}
				}
				Thread.Sleep(1500);
				continue;
			}
			try
			{
				Trace.WriteLine("Application Started");
				StopWatching();
				AlreadyStarted = false;
			}
			catch (Exception ex3)
			{
				Trace.WriteLine("Application Started Exception");
				ExceptionPublisher.Publish(ex3);
				ScheduleHelper scheduleHelper2 = ScheduleHelper.CreateScheduleHelper();
				try
				{
					scheduleHelper2.PersistShouldVerify(shouldVerify: true);
				}
				catch (Exception ex4)
				{
					ExceptionPublisher.Publish(ex4);
				}
			}
			try
			{
				int num = 0;
				while (num < 3)
				{
					num++;
					if (messageThread == null)
					{
						Thread.Sleep(1000);
						continue;
					}
					messageThread.Resume();
					break;
				}
			}
			catch (Exception ex5)
			{
				ExceptionPublisher.Publish(ex5);
			}
			mtx.WaitOne();
			mtx.ReleaseMutex();
			mtx.Close();
			mtx = null;
		}
	}

	private void StartWatching()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		Thread.Sleep(1000);
		ScheduleHelper scheduleHelper = ScheduleHelper.CreateScheduleHelper();
		scheduleHelper.PersistStartTime(DateTime.Now);
		if ((int)objApplicationMode == 2 || (int)objApplicationMode == 3)
		{
			objPAEAgent = PAEAgent.CreatePAEAgent();
			if (objPAEAgent != null)
			{
				objPAEAgent.OnWatcherError += objPAEAgent_OnWatcherError;
			}
		}
		if ((int)objApplicationMode == 1 || (int)objApplicationMode == 3)
		{
			objPCEAgent = PCEAgent.CreatePCEAgent();
			if (objPCEAgent != null)
			{
				objPCEAgent.OnWatcherError += objPCEAgent_OnWatcherError;
			}
		}
		Thread thread = new Thread(ShredderHandler);
		thread.IsBackground = true;
		thread.Start();
	}

	private void StopWatching()
	{
		ScheduleHelper scheduleHelper = ScheduleHelper.CreateScheduleHelper();
		try
		{
			if (bAlreadyStarted)
			{
				scheduleHelper.PersistEndTime(DateTime.Now);
			}
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
		}
		finally
		{
			if (objPCEAgent != null)
			{
				objPCEAgent.Dispose();
				objPCEAgent = null;
			}
			if (objPAEAgent != null)
			{
				objPAEAgent.Dispose();
				objPAEAgent = null;
			}
		}
	}

	private bool IsPreviouslyLoggedUserSame(string currentUserDir)
	{
		FileStream fileStream = null;
		bool result;
		try
		{
			string loggedOnUserFilePath = Helper.GetLoggedOnUserFilePath();
			fileStream = new FileStream(loggedOnUserFilePath, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			string @string = Encoding.Unicode.GetString(array);
			result = ((string.Compare(@string, currentUserDir) == 0) ? true : false);
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
			result = false;
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream = null;
			}
		}
		SetPreviouslyLoggedUserName(currentUserDir);
		return result;
	}

	private void SetPreviouslyLoggedUserName(string currentUserDir)
	{
		FileStream fileStream = null;
		try
		{
			string loggedOnUserFilePath = Helper.GetLoggedOnUserFilePath();
			if (!File.Exists(loggedOnUserFilePath))
			{
				IntPtr intPtr = Win32Interop.CreateFileWrapper(loggedOnUserFilePath, (EFileAccess)536870912, (EFileShare)2, false, (ECreationDisposition)1);
				if (intPtr.ToInt32() != -1)
				{
					Win32Interop.CloseHandle(intPtr);
				}
			}
			byte[] bytes = Encoding.Unicode.GetBytes(currentUserDir);
			fileStream = new FileStream(loggedOnUserFilePath, FileMode.Truncate, FileAccess.Write);
			fileStream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception ex)
		{
			ExceptionPublisher.Publish(ex);
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream = null;
			}
		}
	}

	private void oPipeManager_OnMessageRecieved(ServerNamedPipe sender, MessageString eventargs)
	{
		if (eventargs.Message.Equals("Application-Started"))
		{
			if (bHasAnyUserLoggedIn)
			{
				messageThread = Thread.CurrentThread;
				Thread.CurrentThread.Suspend();
				messageThread = null;
			}
			return;
		}
		try
		{
			thrdMutexWatcher.Suspend();
			string message = eventargs.Message;
			Directory.CreateDirectory(message);
			LogOffUser();
			Helper.SetApplicationDataDirectory(message);
			AlreadyStarted = false;
			if (!IsPreviouslyLoggedUserSame(message))
			{
				try
				{
					ScheduleHelper scheduleHelper = ScheduleHelper.CreateScheduleHelper();
					scheduleHelper.PersistShouldVerify(shouldVerify: true);
				}
				catch (Exception ex)
				{
					ExceptionPublisher.Publish(ex);
				}
			}
			bHasAnyUserLoggedIn = true;
		}
		catch (Exception ex2)
		{
			ExceptionPublisher.Publish(ex2);
		}
		finally
		{
			try
			{
				thrdMutexWatcher.Resume();
			}
			catch (Exception ex3)
			{
				ExceptionPublisher.Publish(ex3);
			}
		}
	}

	private void LogOffUser()
	{
		if (bHasAnyUserLoggedIn)
		{
			SetPreviouslyLoggedUserName(Helper.GetApplicationDataDirectory());
		}
		StopWatching();
	}
}

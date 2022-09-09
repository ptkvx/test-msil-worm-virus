using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using Com.HP.App.HPTools;
using Com.HP.App.HPTools.HPDebug;
using Interop.MarsCore;
using Microsoft.Win32;

namespace Com.HP.PLS.UsageTracking.PE;

public class MarsHost
{
	private Timer _appTimer = new Timer(OrwellConstants.MAIN_SLEEP_TIME);

	private Timer _appShutdownTimer = new Timer(OrwellConstants.ONE_TIME_OPTOUT_SHUTDOWN_CHECK_INTERVAL);

	private UsageTrackingManager _utMgr;

	private Mars _mars;

	private short _intervalCounter = 0;

	private uint prevCapabilities = 0u;

	public MarsHost()
	{
		_appTimer.Elapsed += _appTimer_Elapsed;
		_appShutdownTimer.Elapsed += _appShutdownTimer_Elapsed;
		_appShutdownTimer.AutoReset = false;
		_appShutdownTimer.Enabled = true;
		Application.add_ApplicationExit((EventHandler)Application_ApplicationExit);
	}

	public void StartHosting()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		try
		{
			DebugOutput.WriteLine("StartHosting() >>", 3);
			_mars = (Mars)new MarsClass();
			_utMgr = new UsageTrackingManager(_mars);
			DebugOutput.WriteLine("After calling the UsageTrackingManager constructor", 3);
			_utMgr.CreateTrackers();
			_utMgr.InitTrackers();
			_appTimer.Start();
			UniqueStringCollection val = new UniqueStringCollection();
			val.Add(OrwellConstants.IS_FIRST_RUN);
			PersistenceManager.SetObject(OrwellConstants.ANY_STRINGS_DATA, (IObjectPersistence)(object)val);
			DebugOutput.WriteLine("StartHosting() <<", 3);
		}
		catch (COMException ex)
		{
			DebugOutput.WriteLine("COM Exception caught - {0}", 1, new object[1] { ex.Message });
		}
	}

	public void StopHosting()
	{
	}

	private bool DidUserDeclineOrOptOut()
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OrwellConstants.HPPUSG_REG_KEY_NAME, writable: true);
		if (registryKey.GetValue(OrwellConstants.STOP_RUNNING_VALUE_NAME) != null)
		{
			DebugOutput.WriteLine("The stop running value exists.  Stop running!", 3);
			registryKey.DeleteValue(OrwellConstants.STOP_RUNNING_VALUE_NAME);
			result = true;
		}
		if (++_intervalCounter >= OrwellConstants.INTERVAL_TO_CHECK_OPT_OUT)
		{
			_intervalCounter = 0;
			try
			{
				uint num = 0u;
				bool flag = true;
				try
				{
					if (_mars != null)
					{
						((IMars)_mars).GetEnabledCapabilities(ref num);
						flag = true;
						if (prevCapabilities != num)
						{
							DebugOutput.WriteLine("capabilities = {0}", 3, new object[1] { num });
							prevCapabilities = num;
						}
					}
				}
				catch (Exception ex)
				{
					flag = false;
					DebugOutput.WriteLine("Mars object is not null, but method call throws an exception! - {0}", 1, new object[1] { ex.Message });
				}
				bool flag2 = false;
				bool flag3 = false;
				int num2 = 0;
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(MarsConstants.USG_REG_KEY_NAME);
				if (registryKey2 != null)
				{
					num2 = registryKey2.SubKeyCount;
					string[] subKeyNames = registryKey2.GetSubKeyNames();
					RegistryKey registryKey3 = null;
					DebugOutput.WriteLine("The number of Mars device keys in the registry is {0}", 3, new object[1] { num2 });
					for (int i = 0; i < num2; i++)
					{
						registryKey3 = registryKey2.OpenSubKey(subKeyNames[i]);
						if (registryKey3 == null)
						{
							continue;
						}
						DebugOutput.WriteLine("product Instance ID Key - {0}", 3, new object[1] { registryKey3.ToString() });
						if (registryKey3.Name.IndexOf(OrwellConstants.LASERJET_NAME) != -1)
						{
							flag3 = true;
							string text = (string)registryKey3.GetValue(MarsConstants.DATA_FOLDER);
							if (text.IndexOf(OrwellConstants.HPPUSG) != -1)
							{
								string text2 = (string)registryKey3.GetValue(MarsConstants.PROPERTY_USER_OPTED_IN_NAME);
								if (text2 != null)
								{
									if (!text2.Equals(MarsConstants.OPTED_IN_DEVICE_YES))
									{
										DebugOutput.WriteLine("The user is opted out for the device", 3);
										flag2 = true;
										string text3 = (string)registryKey3.GetValue(MarsConstants.INSTANCE_ID);
										DebugOutput.WriteLine("ProdInstanceIDKeyValue = {0}", 3, new object[1] { text3 });
										if (text3 != null)
										{
											string text4 = text3.Substring(text3.LastIndexOf('#') + 1);
											if (text4 != null)
											{
												DebugOutput.WriteLine("User has opted out of device - serial number = {0}", 3, new object[1] { text4 });
												CleanUpAfterOptOutUninstall();
											}
										}
									}
									else
									{
										DebugOutput.WriteLine("The user is opted in for the device", 3);
									}
								}
								else if (_mars != null && flag && (prevCapabilities & MarsConstants.MARS_CAPABILITY_MARKET_RESEARCH) == MarsConstants.MARS_CAPABILITY_MARKET_RESEARCH)
								{
									DebugOutput.WriteLine("optedInDevice object is null - Mars capabilities = {0} - user has probably not opted in!", 3, new object[1] { prevCapabilities.ToString() });
								}
							}
						}
						else
						{
							DebugOutput.WriteLine("The string - LaserJet - was not found in the product instance ID - {0}", 3, new object[1] { registryKey3.ToString() });
						}
						registryKey3.Close();
						registryKey3 = null;
					}
					registryKey2.Close();
					if (!flag && !flag3 && num2 == 0 && 0 < ((StringCollection)(object)_utMgr.get_InstalledSerialNumbers()).Count)
					{
						DebugOutput.WriteLine("It appears that  HP Extended Capabilities - Mars - has been uninstalled - shutdown Orwell", 3);
						DebugOutput.WriteLine("isPLSDeviceInMarsUsg = {0}, number of subkeys in usg folder = {1}", 3, new object[2]
						{
							flag3.ToString(),
							num2.ToString()
						});
						DebugOutput.WriteLine("Number of persisted serial numbers/installed PLS devices = {0}", 3, new object[1] { ((StringCollection)(object)_utMgr.get_InstalledSerialNumbers()).Count });
						CleanUpAfterOptOutUninstall();
						flag2 = true;
					}
				}
				if (flag2)
				{
					DebugOutput.WriteLine("The user has opted out of UsageTracking or uninstalled HP Extended Capabilities - shutdown the program", 3);
				}
				result = flag2;
				return result;
			}
			catch (Exception ex2)
			{
				DebugOutput.WriteLine("Exception caught in DidUserDeclineOrOptOut!!! - {0}", 1, new object[1] { ex2.Message });
				return result;
			}
		}
		return result;
	}

	private static void SetPrefs(string[] args)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		string text;
		if (args.Length > 0)
		{
			text = args[0].TrimEnd(new char[1] { '"' });
			text = text.TrimStart(new char[1] { '"' });
			text = text.TrimEnd(new char[1] { '\\' });
			if (!Directory.Exists(text))
			{
				throw new HPUsageTrackingException("The directory - {0} - does not exist.", new object[1] { text });
			}
		}
		else
		{
			text = "..";
		}
		Preferences.SetElement((object)"RootDirectory", (object)text);
		Preferences.SetElement((object)"DefaultsDirectory", (object)(text + "\\defaults"));
		Preferences.SetElement((object)"ProductsDirectory", (object)(text + "\\products"));
		new Preferences(text);
	}

	public bool CheckStuff()
	{
		bool result = true;
		if (!DidUserDeclineOrOptOut())
		{
			_utMgr.CheckStuff();
			result = true;
		}
		else if (_utMgr.get_NumberOfOutstandingDevices() < 1)
		{
			DebugOutput.WriteLine("User does not want to participate - shut down.", 1);
			Disable();
			result = false;
		}
		UsageTrackingManager.ReSetWorkingSet();
		return result;
	}

	public void Disable()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(OrwellConstants.WINDOWS_RUN_KEY, writable: true);
			registryKey.DeleteValue(OrwellConstants.HP_USAGE_VALUE_NAME, throwOnMissingValue: false);
		}
		catch (Exception ex)
		{
			DebugOutput.WriteLine("Exception caught trying to disable usage tracking - {0}", 1, new object[1] { ex.Message });
		}
	}

	private void CheckIfUserHasAlreadyOptedOut()
	{
		if (!CheckStuff())
		{
			Application.Exit();
		}
		else
		{
			_appShutdownTimer.Dispose();
		}
	}

	private void CleanUpAfterOptOutUninstall()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((StringCollection)(object)_utMgr.get_InstalledSerialNumbers()).Clear();
		((StringCollection)(object)_utMgr.get_FoundSerialNumbers()).Clear();
		((StringCollection)(UniqueStringCollection)PersistenceManager.GetObject(OrwellConstants.ANY_STRINGS_DATA))?.Clear();
	}

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			SetPrefs(args);
			MarsHost marsHost = new MarsHost();
			marsHost.StartHosting();
			UsageTrackingManager.ReSetWorkingSet();
			Application.Run();
		}
		catch (Exception ex)
		{
			string text = ex.Message;
			if (ex.InnerException != null)
			{
				text += ex.InnerException!.Message;
			}
			DebugOutput.WriteLine("Exception caught in main! - {0}", 1, new object[1] { text });
		}
	}

	private void _appTimer_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (!CheckStuff())
		{
			Application.Exit();
		}
	}

	private void _appShutdownTimer_Elapsed(object sender, ElapsedEventArgs e)
	{
		CheckIfUserHasAlreadyOptedOut();
	}

	private void Application_ApplicationExit(object sender, EventArgs e)
	{
		DebugOutput.WriteLine("Application is exiting - close timer.", 3);
		_appTimer.Stop();
		_appTimer.Close();
		_appTimer.Dispose();
		_appShutdownTimer.Stop();
		_appShutdownTimer.Close();
		_appShutdownTimer.Dispose();
	}
}

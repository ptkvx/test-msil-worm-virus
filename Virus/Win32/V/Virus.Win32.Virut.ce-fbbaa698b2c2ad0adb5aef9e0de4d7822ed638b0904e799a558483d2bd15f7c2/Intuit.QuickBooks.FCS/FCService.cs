#define TRACE
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading;
using System.Timers;
using Microsoft.Win32;

namespace Intuit.QuickBooks.FCS;

[ComVisible(false)]
public class FCService : ServiceBase
{
	private const string TraceFileName = "\\Fcs.trace";

	public const string FCSServiceName = "QBFCService";

	public const string AppID_FCS = "DAF8CB2B-159D-4133-B355-86B3D78A4653";

	public const string Itf_guidIFcsSession = "B1453A02-A0B8-349F-9371-CEAB24C8AC7D";

	public const string Itf_guidIShareInfoSession = "9193A58C-BFDD-4788-80A5-F1D08EC78D44";

	public const string Clsid_guidShareInfoSession = "72C315AC-5A15-4f70-9CB3-899012406150";

	public const string Clsid_guidFcsSession = "E2F551B5-D7E4-351C-A975-2E8EEE4D1917";

	public const string RecordId_guidCOPYREC = "7E4F56EF-A9EE-3337-803D-F871EE85B6CC";

	private int _cookie;

	private static int IdleTimeOutValue = 900;

	private static System.Timers.Timer fcsTimer = null;

	private static Stream traceStream = null;

	private static string FullTraceFileName;

	private static int TraceMaxSize = 10485760;

	private IContainer components;

	public FCService()
	{
		uint num = 0u;
		try
		{
			Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
			Guid AppID = new Guid("DAF8CB2B-159D-4133-B355-86B3D78A4653");
			num = ComAPI.CoInitializeSecurity(ref AppID, -1, IntPtr.Zero, IntPtr.Zero, 0u, 0u, IntPtr.Zero, 8u, IntPtr.Zero);
		}
		catch (Exception ex)
		{
			Trace.Write("CoIntializeSecurity() threw an exception: " + ex.Message);
			DumpStackTrace(ex);
		}
		WriteTraceLine("CoIntializeSecurity() method returned code: HRESULT: 0X" + num.ToString("X"));
		InitializeComponent();
	}

	public static void StartTimer()
	{
		if (fcsTimer == null)
		{
			fcsTimer = new System.Timers.Timer(IdleTimeOutValue * 1000);
			fcsTimer.Elapsed += ShutDown;
		}
		WriteTraceLine("FCS timer activated/started: " + IdleTimeOutValue + " seconds.");
		fcsTimer.Start();
	}

	public static void StopTimer()
	{
		if (fcsTimer != null)
		{
			WriteTraceLine("FCS timer deactivated/stopped");
			fcsTimer.Stop();
		}
	}

	private static void ShutDown(object sender, ElapsedEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		WriteTraceLine("FCS will shutdown. The service detected no activity for quite some time");
		ServiceController val = new ServiceController("QBFCService");
		val.Stop();
	}

	protected override void OnStart(string[] args)
	{
		TextWriterTraceListener listener = new TextWriterTraceListener(Console.Out);
		Trace.Listeners.Add(listener);
		FixRegistry();
		string text = "";
		try
		{
			text = GetWorkingRootDir();
		}
		catch (Exception ex)
		{
			WriteTraceLine("Setting the working Dir: " + ex.Message);
			DumpStackTrace(ex);
			text = ".";
		}
		text += "\\Trace";
		try
		{
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
		}
		catch (Exception ex2)
		{
			WriteTraceLine("Failed to create the root working directory: " + ex2.Message);
			DumpStackTrace(ex2);
			text = ".";
		}
		FullTraceFileName = text + "\\Fcs.trace";
		CreateTraceFile(FullTraceFileName);
		if (traceStream != null)
		{
			TextWriterTraceListener listener2 = new TextWriterTraceListener(traceStream);
			Trace.Listeners.Add(listener2);
		}
		WriteTraceLine("Registering all the class objects supported by FCS");
		WriteTraceLine("Registering FcsSession Class object");
		Guid rclsid = new Guid("E2F551B5-D7E4-351C-A975-2E8EEE4D1917");
		uint num = ComAPI.CoRegisterClassObject(ref rclsid, new FcsSessionClassFactory(), 4, 1, out _cookie);
		if (num != 0)
		{
			WriteTraceLine("CoRegisterClassObject() method returned an error. HRESULT: " + num.ToString("X"));
			throw new ApplicationException("CoRegisterClassObject failed: " + num.ToString("X"));
		}
		WriteTraceLine("CoRegisterClassObject() succeeded.");
		WriteTraceLine("Registering ShareInfoSession Class object");
		Guid rclsid2 = new Guid("72C315AC-5A15-4f70-9CB3-899012406150");
		num = ComAPI.CoRegisterClassObject(ref rclsid2, new ShareInfoSessionClassFactory(), 4, 1, out _cookie);
		if (num != 0)
		{
			WriteTraceLine("CoRegisterClassObject() method returned an error. HRESULT: " + num.ToString("X"));
			throw new ApplicationException("CoRegisterClassObject failed: " + num.ToString("X"));
		}
		WriteTraceLine("CoRegisterClassObject() succeeded.");
	}

	protected override void OnStop()
	{
		if (_cookie != 0)
		{
			ComAPI.CoRevokeClassObject(_cookie);
		}
		if (traceStream != null)
		{
			traceStream.Close();
		}
	}

	public static void DumpStackTrace(Exception ex)
	{
		Trace.WriteLine("@@********************************************************@@");
		WriteTraceLine("Dumping the Call Stack trace for more detailed information:");
		Trace.WriteLine(ex.StackTrace);
		Trace.WriteLine("@@********************************************************@@");
	}

	public static void AdjustTraceFileSize()
	{
		if (traceStream != null && traceStream.Length > TraceMaxSize)
		{
			try
			{
				File.Copy(FullTraceFileName, FullTraceFileName + ".previous", overwrite: true);
				traceStream.SetLength(0L);
			}
			catch (Exception ex)
			{
				WriteTraceLine("Failed to adjust the trace file size: " + ex.Message);
				DumpStackTrace(ex);
			}
			Trace.WriteLine("========================================================================================");
			Trace.WriteLine("========================================================================================");
			Trace.WriteLine("Copyright 2006 Intuit Inc.");
			WriteTraceLine("Intuit.QuickBooks.FCS trace: FCS.Trace");
			Trace.WriteLine("========================================================================================");
			Trace.WriteLine("========================================================================================");
			Trace.WriteLine("");
		}
	}

	public static void WriteTraceLine(string sLine)
	{
		Trace.WriteLine(DateTime.Now.ToString("G") + ". FCS: " + sLine);
		Trace.Flush();
	}

	protected void CreateTraceFile(string sTraceFile)
	{
		WriteTraceLine("Trace File: " + sTraceFile);
		try
		{
			traceStream = new FileStream(sTraceFile, FileMode.OpenOrCreate, FileAccess.Write);
			traceStream.Seek(0L, SeekOrigin.End);
		}
		catch (Exception ex)
		{
			WriteTraceLine("Failed to create Trace File: " + ex.Message);
			DumpStackTrace(ex);
			WriteTraceLine("Will automatically recover and find an alternative");
			string tempPath = Path.GetTempPath();
			string fileName = Path.GetFileName(sTraceFile);
			sTraceFile = Path.Combine(tempPath, fileName);
			WriteTraceLine("Trace file: " + sTraceFile);
			try
			{
				traceStream = new FileStream(sTraceFile, FileMode.OpenOrCreate, FileAccess.Write);
				traceStream.Seek(0L, SeekOrigin.End);
			}
			catch (Exception ex2)
			{
				WriteTraceLine("2nd trial to creat trace file failed: " + ex2.Message);
				DumpStackTrace(ex);
				WriteTraceLine("will will send trace messages to only debugging console");
				traceStream = null;
			}
		}
	}

	public static void FixRegistry()
	{
		WriteTraceLine("Fixing the registry if necessary");
		DeleteRegSubKeyTree(Registry.ClassesRoot, "CLSID\\{E2F551B5-D7E4-351C-A975-2E8EEE4D1917}\\InprocServer32");
		DeleteRegSubKeyTree(Registry.ClassesRoot, "CLSID\\{72C315AC-5A15-4f70-9CB3-899012406150}\\InprocServer32");
		DeleteRegSubKeyTree(Registry.ClassesRoot, "TypeLib\\{B71987D4-E3AB-4903-8AF2-3F51E183E904}\\1.0");
	}

	public static bool DeleteRegSubKeyTree(RegistryKey Parent, string KeyName)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = Parent.OpenSubKey(KeyName);
		}
		catch (Exception)
		{
			return false;
		}
		if (registryKey == null)
		{
			return false;
		}
		try
		{
			registryKey.Close();
			Parent.DeleteSubKeyTree(KeyName);
		}
		catch (Exception ex2)
		{
			WriteTraceLine("Failed to Delete Key: " + KeyName);
			WriteTraceLine("Details: " + ex2.Message);
			return false;
		}
		return true;
	}

	public static string GetWorkingRootDir()
	{
		string text = "";
		string text2 = "";
		try
		{
			text = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + "\\Intuit\\QuickBooks";
		}
		catch (Exception ex)
		{
			WriteTraceLine("Warning: " + ex.Message);
			DumpStackTrace(ex);
			text = "C:\\Program Files\\Common Files\\Intuit\\QuickBooks";
		}
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Intuit\\QuickBooksCommon");
			if (registryKey != null)
			{
				text2 = (string)registryKey.GetValue("CommonFilesPath", text);
			}
			else
			{
				text2 = text;
				WriteTraceLine("Could not read QuickBooks common path, Default path will be used: " + text2);
			}
		}
		catch (Exception ex2)
		{
			WriteTraceLine("Warning:-> " + ex2.Message);
			WriteTraceLine("Could not read QuickBooks common path: " + ex2.Message);
			DumpStackTrace(ex2);
		}
		if (text2 == null || text2.Length == 0)
		{
			text2 = text;
		}
		text2 += "\\FCS";
		try
		{
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
				return text2;
			}
			return text2;
		}
		catch (Exception ex3)
		{
			WriteTraceLine("Failed to create the root working directory: " + ex3.Message);
			DumpStackTrace(ex3);
			return text2;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
		((ServiceBase)this).set_ServiceName("QBFCService");
	}
}

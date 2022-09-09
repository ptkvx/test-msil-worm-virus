using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HP.CUE.Gallery.StubApp;

public class MainWindow : Form
{
	private const int WM_USER_CAMCARD_UPLOAD_SETPATH = 1282;

	private const int WM_USER_CAMCARD_UPLOAD_INIT_TV = 1536;

	private const int WM_USER_CAMCARD_UPLOAD_SENDFILE_TO_TV = 1537;

	private const int WM_USER_CAMCARD_UPLOAD_ALLDONE_TO_TV = 1538;

	private const int WM_USER_CAMCARD_UPLOAD_SHUTDOWN_TV = 1539;

	private const int WM_USER_SCAN_UPLOAD_SENDFILE_TO_TV_ASIS = 1541;

	private const int WM_USER_CAMCARD_UPLOAD_INIT_READY_FROM_TV = 1794;

	private IContainer components;

	private HPNativeWindow hpWindow;

	private StringCollection fileCollection;

	private Timer uploadTimer;

	public MainWindow()
	{
		components = null;
		InitializeComponent();
		hpWindow = new HPNativeWindow(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(292, 245));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainWindow");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Camcard Upload");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Closed((EventHandler)OnClosed);
	}

	private void exitMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal virtual void OnCopyData(IntPtr hWndSender, NativeMethods.COPYDATASTRUCT cds)
	{
		switch (cds.dwData)
		{
		case 1541:
			lock (this)
			{
				if (fileCollection == null)
				{
					fileCollection = new StringCollection();
				}
				string text = Marshal.PtrToStringAnsi(cds.lpData, cds.cbData);
				if (text.StartsWith("DEVICEID "))
				{
					text = text.Substring(9);
				}
				Application.fileOrDirectoryToBrowse = text;
				fileCollection.Add(text);
				if (uploadTimer == null)
				{
					TimerCallback callback = ScanUploadsCompleted;
					uploadTimer = new Timer(callback, null, 500, -1);
				}
				else
				{
					uploadTimer.Change(500, -1);
				}
				break;
			}
		case 1536:
		{
			NativeMethods.CAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT cAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT = new NativeMethods.CAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT();
			cAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT.dwData = 1794;
			cAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT.cbData = "HPQTHB08".Length;
			cAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT.lpData = "HPQTHB08";
			UnsafeNativeMethods.SendMessage(hWndSender, 74, ((Control)this).get_Handle(), cAMCARD_UPLOAD_INIT_READY_FROM_TV_STRUCT);
			break;
		}
		case 1282:
			Application.commandLine = "-activate hpqmyimg -param \"-dir " + (Application.fileOrDirectoryToBrowse = Marshal.PtrToStringAnsi(cds.lpData, cds.cbData)) + "";
			((Form)this).Close();
			break;
		}
	}

	private void ScanUploadsCompleted(object o)
	{
		lock (this)
		{
			if (uploadTimer != null)
			{
				uploadTimer.Dispose();
				uploadTimer = null;
			}
			string tempFileName = Path.GetTempFileName();
			StreamWriter streamWriter = new StreamWriter(tempFileName);
			for (int i = 0; i < fileCollection.Count; i++)
			{
				streamWriter.WriteLine(fileCollection[i]);
			}
			streamWriter.Close();
			Application.commandLine = "-activate hpqmyimg -param \"-scan " + tempFileName + "\"";
			fileCollection = null;
		}
		((Form)this).Close();
	}

	private void OnClosed(object sender, EventArgs e)
	{
		((NativeWindow)hpWindow).DestroyHandle();
	}
}

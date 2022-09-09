using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace hotfile_link_generator;

public class add_cookies : Form
{
	public static string cookie;

	private IContainer icontainer_0 = null;

	private TextBox textBox1;

	private Button button1;

	private Button button2;

	public add_cookies()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		cookie = ((Control)textBox1).get_Text();
		((Form)this).Close();
	}

	private void add_cookies_Load(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(cookie);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		cookie = "";
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(add_cookies));
		textBox1 = new TextBox();
		button1 = new Button();
		button2 = new Button();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(51, 20));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(293, 20));
		((Control)textBox1).set_TabIndex(0);
		((Control)button1).set_Location(new Point(110, 52));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(79, 32));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Add");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(195, 52));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(79, 32));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("Delete");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(375, 96));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("add_cookies");
		((Control)this).set_Text("add_cookies");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)add_cookies_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static add_cookies()
	{
		cookie = "";
	}
}

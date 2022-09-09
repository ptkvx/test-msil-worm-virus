using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Google.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Google;

[DesignerGenerated]
public class chat : Form
{
	private IContainer components;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("refrsh")]
	private Timer _refrsh;

	internal virtual ListView ListView1
	{
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = ListView1_SelectedIndexChanged;
			if (_ListView1 != null)
			{
				_ListView1.remove_SelectedIndexChanged(eventHandler);
			}
			_ListView1 = value;
			if (_ListView1 != null)
			{
				_ListView1.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ColumnHeader ColumnHeader1
	{
		get
		{
			return _ColumnHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ColumnHeader1 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader2
	{
		get
		{
			return _ColumnHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ColumnHeader2 = value;
		}
	}

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Timer refrsh
	{
		get
		{
			return _refrsh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = refrsh_Tick;
			if (_refrsh != null)
			{
				_refrsh.remove_Tick(eventHandler);
			}
			_refrsh = value;
			if (_refrsh != null)
			{
				_refrsh.add_Tick(eventHandler);
			}
		}
	}

	public chat()
	{
		((Form)this).add_Load((EventHandler)chat_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(chat));
		ListView1 = new ListView();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		Button1 = new Button();
		TextBox1 = new TextBox();
		refrsh = new Timer(components);
		((Control)this).SuspendLayout();
		ListView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader1, ColumnHeader2 });
		ListView listView = ListView1;
		Point location = new Point(12, 12);
		((Control)listView).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView2 = ListView1;
		Size size = new Size(547, 276);
		((Control)listView2).set_Size(size);
		((Control)ListView1).set_TabIndex(1);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		ListView1.set_View((View)1);
		ColumnHeader1.set_Text("Nick");
		ColumnHeader1.set_Width(91);
		ColumnHeader2.set_Text("Message");
		ColumnHeader2.set_Width(450);
		Button button = Button1;
		location = new Point(484, 294);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("SEND");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox1;
		location = new Point(11, 296);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(467, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(3);
		refrsh.set_Enabled(true);
		refrsh.set_Interval(3000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		size = new Size(571, 328);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)ListView1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("chat");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Chat");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void refrsh_Tick(object sender, EventArgs e)
	{
		GetChatMessage();
	}

	public object GetChatMessage()
	{
		object result = default(object);
		try
		{
			WebClient webClient = new WebClient();
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(MyProject.Forms.Form1.site, (object)"other/chat/data.php?action=read") }, (string[])null, (Type[])null, (bool[])null));
			int num = Conversions.ToInteger("0");
			ListView1.get_Items().Clear();
			string[] array = Strings.Split(Conversions.ToString(objectValue), "\r\n", -1, (CompareMethod)0);
			foreach (string text in array)
			{
				if (text.ToString().Contains("|"))
				{
					string[] array2 = Strings.Split(text, "|", -1, (CompareMethod)0);
					ListView1.get_Items().Add(array2[0]);
					ListView1.get_Items().get_Item(num).get_SubItems()
						.Add(array2[1]);
					num = checked((int)Math.Round(Conversion.Val((object)num) + Conversion.Val("1")));
				}
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void chat_Load(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		WebClient webClient = new WebClient();
		NewLateBinding.LateCall((object)webClient, (Type)null, "DownloadString", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.AddObject(MyProject.Forms.Form1.site, (object)"other/chat/data.php?action=write&data="), MyProject.Forms.Form1.mynick), (object)"|"), (object)TextBox1.get_Text()) }, (string[])null, (Type[])null, (bool[])null, true);
		TextBox1.set_Text("");
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}

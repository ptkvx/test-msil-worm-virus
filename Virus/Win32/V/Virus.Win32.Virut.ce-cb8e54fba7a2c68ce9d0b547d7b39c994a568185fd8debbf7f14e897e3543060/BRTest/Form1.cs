using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BRWrapper;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BRTest;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("dlgOpen")]
	private OpenFileDialog _dlgOpen;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtFilename")]
	private TextBox _txtFilename;

	[AccessedThroughProperty("btnRead")]
	private Button _btnRead;

	[AccessedThroughProperty("txtResult")]
	private TextBox _txtResult;

	[AccessedThroughProperty("btnOpen")]
	private Button _btnOpen;

	internal virtual OpenFileDialog dlgOpen
	{
		[DebuggerNonUserCode]
		get
		{
			return _dlgOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dlgOpen = value;
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

	internal virtual TextBox txtFilename
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtFilename;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtFilename = value;
		}
	}

	internal virtual Button btnRead
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnRead;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnRead != null)
			{
				((Control)_btnRead).remove_Click((EventHandler)btnRead_Click);
			}
			_btnRead = value;
			if (_btnRead != null)
			{
				((Control)_btnRead).add_Click((EventHandler)btnRead_Click);
			}
		}
	}

	internal virtual TextBox txtResult
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtResult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtResult = value;
		}
	}

	internal virtual Button btnOpen
	{
		[DebuggerNonUserCode]
		get
		{
			return _btnOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btnOpen != null)
			{
				((Control)_btnOpen).remove_Click((EventHandler)btnOpen_Click);
			}
			_btnOpen = value;
			if (_btnOpen != null)
			{
				((Control)_btnOpen).add_Click((EventHandler)btnOpen_Click);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
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
		dlgOpen = new OpenFileDialog();
		Label1 = new Label();
		txtFilename = new TextBox();
		btnRead = new Button();
		txtResult = new TextBox();
		btnOpen = new Button();
		((Control)this).SuspendLayout();
		((FileDialog)dlgOpen).set_FileName("OpenFileDialog1");
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(12, 43);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(51, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("FileName");
		TextBox obj = txtFilename;
		location = new Point(83, 40);
		((Control)obj).set_Location(location);
		((Control)txtFilename).set_Name("txtFilename");
		TextBox obj2 = txtFilename;
		size = new Size(206, 20);
		((Control)obj2).set_Size(size);
		((Control)txtFilename).set_TabIndex(1);
		Button obj3 = btnRead;
		location = new Point(115, 78);
		((Control)obj3).set_Location(location);
		((Control)btnRead).set_Name("btnRead");
		Button obj4 = btnRead;
		size = new Size(95, 22);
		((Control)obj4).set_Size(size);
		((Control)btnRead).set_TabIndex(2);
		((ButtonBase)btnRead).set_Text("Read Barcodes");
		((ButtonBase)btnRead).set_UseVisualStyleBackColor(true);
		TextBox obj5 = txtResult;
		location = new Point(62, 131);
		((Control)obj5).set_Location(location);
		txtResult.set_Multiline(true);
		((Control)txtResult).set_Name("txtResult");
		TextBox obj6 = txtResult;
		size = new Size(226, 79);
		((Control)obj6).set_Size(size);
		((Control)txtResult).set_TabIndex(3);
		Button obj7 = btnOpen;
		location = new Point(295, 39);
		((Control)obj7).set_Location(location);
		((Control)btnOpen).set_Name("btnOpen");
		Button obj8 = btnOpen;
		size = new Size(64, 21);
		((Control)obj8).set_Size(size);
		((Control)btnOpen).set_TabIndex(4);
		((ButtonBase)btnOpen).set_Text("Open");
		((ButtonBase)btnOpen).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(388, 230);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)btnOpen);
		((Control)this).get_Controls().Add((Control)(object)txtResult);
		((Control)this).get_Controls().Add((Control)(object)btnRead);
		((Control)this).get_Controls().Add((Control)(object)txtFilename);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("BarCode Reader");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void btnOpen_Click(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		txtFilename.set_Text("");
		if ((int)((CommonDialog)dlgOpen).ShowDialog() == 1)
		{
			txtFilename.set_Text(((FileDialog)dlgOpen).get_FileName());
		}
	}

	private void btnRead_Click(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (Operators.CompareString(Strings.Trim(txtFilename.get_Text()), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please select a file to read barcode(s)", (MsgBoxStyle)0, (object)null);
		}
		BRReader val = new BRReader();
		txtResult.set_Text(val.WReadBars(txtFilename.get_Text()));
	}
}

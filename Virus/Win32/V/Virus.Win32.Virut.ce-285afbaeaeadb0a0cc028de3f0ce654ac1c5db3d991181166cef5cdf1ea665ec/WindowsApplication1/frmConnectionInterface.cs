using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class frmConnectionInterface : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("CmdClose")]
	private Button _CmdClose;

	[AccessedThroughProperty("cmdNew")]
	private Button _cmdNew;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("chknetwork")]
	private CheckBox _chknetwork;

	[AccessedThroughProperty("chkLocal")]
	private CheckBox _chkLocal;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("msksDatabaseName")]
	private MaskedTextBox _msksDatabaseName;

	[AccessedThroughProperty("lblPort")]
	private Label _lblPort;

	[AccessedThroughProperty("lblIPAddress")]
	private Label _lblIPAddress;

	[AccessedThroughProperty("MskSQLPort")]
	private MaskedTextBox _MskSQLPort;

	[AccessedThroughProperty("mskIPAddress")]
	private MaskedTextBox _mskIPAddress;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("MskPassword")]
	private MaskedTextBox _MskPassword;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("MskUserName")]
	private MaskedTextBox _MskUserName;

	[AccessedThroughProperty("objconnectionconfig")]
	private CconnectionConfig _objconnectionconfig;

	private bool isEditing;

	private bool ConnOK;

	private long Ans;

	internal virtual Button CmdClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CmdClose != null)
			{
				((Control)_CmdClose).remove_Click((EventHandler)CmdClose_Click);
			}
			_CmdClose = value;
			if (_CmdClose != null)
			{
				((Control)_CmdClose).add_Click((EventHandler)CmdClose_Click);
			}
		}
	}

	internal virtual Button cmdNew
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdNew != null)
			{
				((Control)_cmdNew).remove_Click((EventHandler)cmdNew_Click);
			}
			_cmdNew = value;
			if (_cmdNew != null)
			{
				((Control)_cmdNew).add_Click((EventHandler)cmdNew_Click);
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual CheckBox chknetwork
	{
		[DebuggerNonUserCode]
		get
		{
			return _chknetwork;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_chknetwork != null)
			{
				_chknetwork.remove_CheckedChanged((EventHandler)chknetwork_CheckedChanged);
			}
			_chknetwork = value;
			if (_chknetwork != null)
			{
				_chknetwork.add_CheckedChanged((EventHandler)chknetwork_CheckedChanged);
			}
		}
	}

	internal virtual CheckBox chkLocal
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkLocal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_chkLocal != null)
			{
				((Control)_chkLocal).remove_TextChanged((EventHandler)chkLocal_TextChanged);
				_chkLocal.remove_CheckedChanged((EventHandler)chkLocal_CheckedChanged);
			}
			_chkLocal = value;
			if (_chkLocal != null)
			{
				((Control)_chkLocal).add_TextChanged((EventHandler)chkLocal_TextChanged);
				_chkLocal.add_CheckedChanged((EventHandler)chkLocal_CheckedChanged);
			}
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual MaskedTextBox msksDatabaseName
	{
		[DebuggerNonUserCode]
		get
		{
			return _msksDatabaseName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			if (_msksDatabaseName != null)
			{
				_msksDatabaseName.remove_MaskInputRejected(new MaskInputRejectedEventHandler(msksDatabaseName_MaskInputRejected));
				((Control)_msksDatabaseName).remove_TextChanged((EventHandler)msksDatabaseName_TextChanged);
				((Control)_msksDatabaseName).remove_KeyDown(new KeyEventHandler(msksDatabaseName_KeyDown));
				((Control)_msksDatabaseName).remove_GotFocus((EventHandler)msksDatabaseName_GotFocus);
			}
			_msksDatabaseName = value;
			if (_msksDatabaseName != null)
			{
				_msksDatabaseName.add_MaskInputRejected(new MaskInputRejectedEventHandler(msksDatabaseName_MaskInputRejected));
				((Control)_msksDatabaseName).add_TextChanged((EventHandler)msksDatabaseName_TextChanged);
				((Control)_msksDatabaseName).add_KeyDown(new KeyEventHandler(msksDatabaseName_KeyDown));
				((Control)_msksDatabaseName).add_GotFocus((EventHandler)msksDatabaseName_GotFocus);
			}
		}
	}

	internal virtual Label lblPort
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPort = value;
		}
	}

	internal virtual Label lblIPAddress
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblIPAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblIPAddress = value;
		}
	}

	internal virtual MaskedTextBox MskSQLPort
	{
		[DebuggerNonUserCode]
		get
		{
			return _MskSQLPort;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_MskSQLPort != null)
			{
				((Control)_MskSQLPort).remove_GotFocus((EventHandler)MskSQLPort_GotFocus);
				((Control)_MskSQLPort).remove_TextChanged((EventHandler)MskSQLPort_TextChanged);
				((Control)_MskSQLPort).remove_KeyDown(new KeyEventHandler(MskSQLPort_KeyDown));
			}
			_MskSQLPort = value;
			if (_MskSQLPort != null)
			{
				((Control)_MskSQLPort).add_GotFocus((EventHandler)MskSQLPort_GotFocus);
				((Control)_MskSQLPort).add_TextChanged((EventHandler)MskSQLPort_TextChanged);
				((Control)_MskSQLPort).add_KeyDown(new KeyEventHandler(MskSQLPort_KeyDown));
			}
		}
	}

	internal virtual MaskedTextBox mskIPAddress
	{
		[DebuggerNonUserCode]
		get
		{
			return _mskIPAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			if (_mskIPAddress != null)
			{
				((Control)_mskIPAddress).remove_TextChanged((EventHandler)mskIPAddress_TextChanged);
				((Control)_mskIPAddress).remove_KeyDown(new KeyEventHandler(mskIPAddress_KeyDown));
				((Control)_mskIPAddress).remove_GotFocus((EventHandler)mskIPAddress_GotFocus);
				_mskIPAddress.remove_MaskInputRejected(new MaskInputRejectedEventHandler(mskIPAddress_MaskInputRejected));
			}
			_mskIPAddress = value;
			if (_mskIPAddress != null)
			{
				((Control)_mskIPAddress).add_TextChanged((EventHandler)mskIPAddress_TextChanged);
				((Control)_mskIPAddress).add_KeyDown(new KeyEventHandler(mskIPAddress_KeyDown));
				((Control)_mskIPAddress).add_GotFocus((EventHandler)mskIPAddress_GotFocus);
				_mskIPAddress.add_MaskInputRejected(new MaskInputRejectedEventHandler(mskIPAddress_MaskInputRejected));
			}
		}
	}

	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox3 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual MaskedTextBox MskPassword
	{
		[DebuggerNonUserCode]
		get
		{
			return _MskPassword;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_MskPassword != null)
			{
				((Control)_MskPassword).remove_TextChanged((EventHandler)MskPassword_TextChanged);
				((Control)_MskPassword).remove_KeyDown(new KeyEventHandler(MskPassword_KeyDown));
				((Control)_MskPassword).remove_GotFocus((EventHandler)MskPassword_GotFocus);
			}
			_MskPassword = value;
			if (_MskPassword != null)
			{
				((Control)_MskPassword).add_TextChanged((EventHandler)MskPassword_TextChanged);
				((Control)_MskPassword).add_KeyDown(new KeyEventHandler(MskPassword_KeyDown));
				((Control)_MskPassword).add_GotFocus((EventHandler)MskPassword_GotFocus);
			}
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual MaskedTextBox MskUserName
	{
		[DebuggerNonUserCode]
		get
		{
			return _MskUserName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_MskUserName != null)
			{
				((Control)_MskUserName).remove_TextChanged((EventHandler)MskUserName_TextChanged);
				((Control)_MskUserName).remove_KeyDown(new KeyEventHandler(MskUserName_KeyDown));
				((Control)_MskUserName).remove_GotFocus((EventHandler)MskUserName_GotFocus);
			}
			_MskUserName = value;
			if (_MskUserName != null)
			{
				((Control)_MskUserName).add_TextChanged((EventHandler)MskUserName_TextChanged);
				((Control)_MskUserName).add_KeyDown(new KeyEventHandler(MskUserName_KeyDown));
				((Control)_MskUserName).add_GotFocus((EventHandler)MskUserName_GotFocus);
			}
		}
	}

	private virtual CconnectionConfig objconnectionconfig
	{
		[DebuggerNonUserCode]
		get
		{
			return _objconnectionconfig;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objconnectionconfig != null)
			{
				_objconnectionconfig.Notconfigured -= objconnectionconfig_Notconfigured;
				_objconnectionconfig.InvalidDataSource -= objconnectionconfig_InvalidDataSource;
				_objconnectionconfig.DataValidated -= objconnectionconfig_DataValidated;
				_objconnectionconfig.Configured -= objconnectionconfig_Configured;
			}
			_objconnectionconfig = value;
			if (_objconnectionconfig != null)
			{
				_objconnectionconfig.Notconfigured += objconnectionconfig_Notconfigured;
				_objconnectionconfig.InvalidDataSource += objconnectionconfig_InvalidDataSource;
				_objconnectionconfig.DataValidated += objconnectionconfig_DataValidated;
				_objconnectionconfig.Configured += objconnectionconfig_Configured;
			}
		}
	}

	public frmConnectionInterface()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Control)this).add_KeyDown(new KeyEventHandler(frmConnectionInterface_KeyDown));
		((Form)this).add_Load((EventHandler)frmConnectionInterface_Load);
		__ENCList.Add(new WeakReference(this));
		objconnectionconfig = new CconnectionConfig();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		CmdClose = new Button();
		cmdNew = new Button();
		GroupBox1 = new GroupBox();
		chknetwork = new CheckBox();
		chkLocal = new CheckBox();
		GroupBox2 = new GroupBox();
		Label3 = new Label();
		msksDatabaseName = new MaskedTextBox();
		lblPort = new Label();
		lblIPAddress = new Label();
		MskSQLPort = new MaskedTextBox();
		mskIPAddress = new MaskedTextBox();
		GroupBox3 = new GroupBox();
		Label4 = new Label();
		MskPassword = new MaskedTextBox();
		Label5 = new Label();
		MskUserName = new MaskedTextBox();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		Button cmdClose = CmdClose;
		Point location = new Point(308, 125);
		((Control)cmdClose).set_Location(location);
		((Control)CmdClose).set_Name("CmdClose");
		Button cmdClose2 = CmdClose;
		Size size = new Size(64, 32);
		((Control)cmdClose2).set_Size(size);
		((Control)CmdClose).set_TabIndex(66);
		((ButtonBase)CmdClose).set_Text("&Close");
		((ButtonBase)CmdClose).set_UseVisualStyleBackColor(true);
		Button obj = cmdNew;
		location = new Point(308, 87);
		((Control)obj).set_Location(location);
		((Control)cmdNew).set_Name("cmdNew");
		Button obj2 = cmdNew;
		size = new Size(64, 32);
		((Control)obj2).set_Size(size);
		((Control)cmdNew).set_TabIndex(55);
		((ButtonBase)cmdNew).set_Text("&New");
		((ButtonBase)cmdNew).set_UseVisualStyleBackColor(true);
		((Control)GroupBox1).get_Controls().Add((Control)(object)chknetwork);
		((Control)GroupBox1).get_Controls().Add((Control)(object)chkLocal);
		GroupBox1.set_FlatStyle((FlatStyle)1);
		GroupBox groupBox = GroupBox1;
		location = new Point(28, 12);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(263, 41);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(80);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("SQL Source");
		((ButtonBase)chknetwork).set_AutoSize(true);
		chknetwork.set_CheckAlign((ContentAlignment)1);
		CheckBox obj3 = chknetwork;
		location = new Point(131, 18);
		((Control)obj3).set_Location(location);
		((Control)chknetwork).set_Name("chknetwork");
		CheckBox obj4 = chknetwork;
		size = new Size(115, 17);
		((Control)obj4).set_Size(size);
		((Control)chknetwork).set_TabIndex(81);
		((ButtonBase)chknetwork).set_Text("Network Database");
		chknetwork.set_TextAlign((ContentAlignment)64);
		((ButtonBase)chknetwork).set_UseVisualStyleBackColor(true);
		((ButtonBase)chkLocal).set_AutoSize(true);
		chkLocal.set_CheckAlign((ContentAlignment)1);
		CheckBox obj5 = chkLocal;
		location = new Point(25, 18);
		((Control)obj5).set_Location(location);
		((Control)chkLocal).set_Name("chkLocal");
		CheckBox obj6 = chkLocal;
		size = new Size(113, 17);
		((Control)obj6).set_Size(size);
		((Control)chkLocal).set_TabIndex(80);
		((ButtonBase)chkLocal).set_Text("Local Database    ");
		chkLocal.set_TextAlign((ContentAlignment)64);
		((ButtonBase)chkLocal).set_UseVisualStyleBackColor(true);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)msksDatabaseName);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lblPort);
		((Control)GroupBox2).get_Controls().Add((Control)(object)lblIPAddress);
		((Control)GroupBox2).get_Controls().Add((Control)(object)MskSQLPort);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mskIPAddress);
		GroupBox groupBox3 = GroupBox2;
		location = new Point(28, 57);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox4 = GroupBox2;
		size = new Size(263, 97);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox2).set_TabIndex(81);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("SQL Parameters");
		Label3.set_AutoSize(true);
		Label label = Label3;
		location = new Point(6, 71);
		((Control)label).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label2 = Label3;
		size = new Size(84, 13);
		((Control)label2).set_Size(size);
		((Control)Label3).set_TabIndex(78);
		Label3.set_Text("Database Name");
		MaskedTextBox obj7 = msksDatabaseName;
		location = new Point(106, 68);
		((Control)obj7).set_Location(location);
		((Control)msksDatabaseName).set_Name("msksDatabaseName");
		MaskedTextBox obj8 = msksDatabaseName;
		size = new Size(149, 20);
		((Control)obj8).set_Size(size);
		((Control)msksDatabaseName).set_TabIndex(75);
		lblPort.set_AutoSize(true);
		Label obj9 = lblPort;
		location = new Point(6, 45);
		((Control)obj9).set_Location(location);
		((Control)lblPort).set_Name("lblPort");
		Label obj10 = lblPort;
		size = new Size(50, 13);
		((Control)obj10).set_Size(size);
		((Control)lblPort).set_TabIndex(77);
		lblPort.set_Text("SQL Port");
		lblIPAddress.set_AutoSize(true);
		Label obj11 = lblIPAddress;
		location = new Point(6, 16);
		((Control)obj11).set_Location(location);
		((Control)lblIPAddress).set_Name("lblIPAddress");
		Label obj12 = lblIPAddress;
		size = new Size(92, 13);
		((Control)obj12).set_Size(size);
		((Control)lblIPAddress).set_TabIndex(76);
		lblIPAddress.set_Text("Server IP Address");
		MaskedTextBox mskSQLPort = MskSQLPort;
		location = new Point(106, 42);
		((Control)mskSQLPort).set_Location(location);
		MskSQLPort.set_Mask("####");
		((Control)MskSQLPort).set_Name("MskSQLPort");
		MaskedTextBox mskSQLPort2 = MskSQLPort;
		size = new Size(149, 20);
		((Control)mskSQLPort2).set_Size(size);
		((Control)MskSQLPort).set_TabIndex(74);
		MaskedTextBox obj13 = mskIPAddress;
		location = new Point(106, 13);
		((Control)obj13).set_Location(location);
		((Control)mskIPAddress).set_Name("mskIPAddress");
		MaskedTextBox obj14 = mskIPAddress;
		size = new Size(149, 20);
		((Control)obj14).set_Size(size);
		((Control)mskIPAddress).set_TabIndex(73);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox3).get_Controls().Add((Control)(object)MskPassword);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox3).get_Controls().Add((Control)(object)MskUserName);
		GroupBox groupBox5 = GroupBox3;
		location = new Point(30, 160);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox6 = GroupBox3;
		size = new Size(260, 76);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox3).set_TabIndex(82);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("SQL Authentification");
		Label4.set_AutoSize(true);
		Label label3 = Label4;
		location = new Point(6, 44);
		((Control)label3).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label4 = Label4;
		size = new Size(53, 13);
		((Control)label4).set_Size(size);
		((Control)Label4).set_TabIndex(80);
		Label4.set_Text("Password");
		MaskedTextBox mskPassword = MskPassword;
		location = new Point(104, 41);
		((Control)mskPassword).set_Location(location);
		((Control)MskPassword).set_Name("MskPassword");
		MaskedTextBox mskPassword2 = MskPassword;
		size = new Size(149, 20);
		((Control)mskPassword2).set_Size(size);
		((Control)MskPassword).set_TabIndex(78);
		Label5.set_AutoSize(true);
		Label label5 = Label5;
		location = new Point(6, 18);
		((Control)label5).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label6 = Label5;
		size = new Size(60, 13);
		((Control)label6).set_Size(size);
		((Control)Label5).set_TabIndex(79);
		Label5.set_Text("User Name");
		MaskedTextBox mskUserName = MskUserName;
		location = new Point(104, 15);
		((Control)mskUserName).set_Location(location);
		((Control)MskUserName).set_Name("MskUserName");
		MaskedTextBox mskUserName2 = MskUserName;
		size = new Size(149, 20);
		((Control)mskUserName2).set_Size(size);
		((Control)MskUserName).set_TabIndex(77);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		size = new Size(384, 248);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)GroupBox3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)cmdNew);
		((Control)this).get_Controls().Add((Control)(object)CmdClose);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmConnectionInterface");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Connection Interface");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void frmConnectionInterface_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		if ((int)e.get_KeyCode() == 13)
		{
			((Control)this).SelectNextControl((Control)sender, true, true, false, true);
		}
	}

	private void frmConnectionInterface_Load(object sender, EventArgs e)
	{
		ConnOK = true;
		objconnectionconfig.initialise();
		Refreshdata();
		Viewmode();
	}

	private void Refreshdata()
	{
		mskIPAddress.set_Text(Conversions.ToString(objconnectionconfig.SQLIPAddress));
		MskSQLPort.set_Text(Conversions.ToString(objconnectionconfig.SQLPort));
		msksDatabaseName.set_Text(Conversions.ToString(objconnectionconfig.Initcatalog));
		MskPassword.set_Text(Conversions.ToString(objconnectionconfig.nPassword));
		MskUserName.set_Text(Conversions.ToString(objconnectionconfig.nUsername));
		if (Operators.ConditionalCompareObjectEqual(objconnectionconfig.netWorkSource, (object)true, false))
		{
			chknetwork.set_Checked(true);
			chkLocal.set_Checked(false);
		}
		else
		{
			chkLocal.set_Checked(true);
			chknetwork.set_Checked(false);
		}
	}

	private void Viewmode()
	{
		isEditing = false;
		((Control)chkLocal).set_Enabled(false);
		((Control)chknetwork).set_Enabled(false);
		mskIPAddress.set_ReadOnly(true);
		MskSQLPort.set_ReadOnly(true);
		msksDatabaseName.set_ReadOnly(true);
		MskUserName.set_ReadOnly(true);
		MskPassword.set_ReadOnly(true);
		((TextBoxBase)mskIPAddress).set_BackColor(Color.White);
		((TextBoxBase)MskSQLPort).set_BackColor(Color.White);
		((TextBoxBase)msksDatabaseName).set_BackColor(Color.White);
		((TextBoxBase)MskUserName).set_BackColor(Color.White);
		((TextBoxBase)MskPassword).set_BackColor(Color.White);
		((ButtonBase)cmdNew).set_Text("&Edit");
		((ButtonBase)CmdClose).set_Text("&Close");
	}

	private void Editmode()
	{
		isEditing = true;
		((ButtonBase)cmdNew).set_Text("&Save");
		((ButtonBase)CmdClose).set_Text("&Cancel");
		((Control)chkLocal).set_Enabled(true);
		((Control)chknetwork).set_Enabled(true);
		mskIPAddress.set_ReadOnly(false);
		MskSQLPort.set_ReadOnly(false);
		msksDatabaseName.set_ReadOnly(false);
		MskUserName.set_ReadOnly(false);
		MskPassword.set_ReadOnly(false);
	}

	private void objconnectionconfig_Configured()
	{
		((ButtonBase)cmdNew).set_Text("&Edit");
		ConnOK = true;
	}

	private void objconnectionconfig_DataValidated(bool blnIsValid)
	{
		if (Operators.CompareString(((ButtonBase)cmdNew).get_Text(), "&Save", false) == 0)
		{
			if (blnIsValid)
			{
				((Control)cmdNew).set_Enabled(true);
			}
			else
			{
				((Control)cmdNew).set_Enabled(false);
			}
		}
	}

	private void objconnectionconfig_InvalidDataSource()
	{
		ConnOK = false;
	}

	private void objconnectionconfig_Notconfigured()
	{
		((ButtonBase)cmdNew).set_Text("&New");
		((ButtonBase)CmdClose).set_Text("&Close");
		((Control)cmdNew).set_Enabled(true);
	}

	private void CmdClose_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(((ButtonBase)CmdClose).get_Text(), "&Cancel", false) == 0)
		{
			((ButtonBase)CmdClose).set_Text("&Close");
			((ButtonBase)cmdNew).set_Text("&Edit");
			Viewmode();
		}
		else
		{
			((Form)this).Close();
		}
	}

	private void cmdNew_Click(object sender, EventArgs e)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((ButtonBase)cmdNew).get_Text(), "&Edit", false) == 0)
		{
			((Control)mskIPAddress).Focus();
			((TextBoxBase)mskIPAddress).SelectAll();
			Editmode();
			objconnectionconfig.IsValid();
			return;
		}
		objconnectionconfig.IsValid();
		objconnectionconfig.Testconnection();
		if (ConnOK)
		{
			objconnectionconfig.SaveConfig();
			Refreshdata();
			Interaction.MsgBox((object)"Connection Configuration\r\nSuccessfully Saved", (MsgBoxStyle)64, (object)"Information");
			Viewmode();
			Refreshdata();
		}
	}

	private void mskIPAddress_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)mskIPAddress).SelectAll();
	}

	private void mskIPAddress_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			if (((Control)MskSQLPort).get_Visible())
			{
				((Control)MskSQLPort).Focus();
			}
			else
			{
				((Control)msksDatabaseName).Focus();
			}
		}
	}

	private void mskIPAddress_TextChanged(object sender, EventArgs e)
	{
		objconnectionconfig.SQLIPAddress = mskIPAddress.get_Text();
		objconnectionconfig.IsValid();
	}

	private void MskSQLPort_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)MskSQLPort).SelectAll();
	}

	private void MskSQLPort_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			((Control)msksDatabaseName).Focus();
		}
	}

	private void MskSQLPort_TextChanged(object sender, EventArgs e)
	{
		objconnectionconfig.SQLPort = MskSQLPort.get_Text();
		objconnectionconfig.IsValid();
	}

	private void msksDatabaseName_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)msksDatabaseName).SelectAll();
	}

	private void msksDatabaseName_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			((Control)MskUserName).Focus();
		}
	}

	private void msksDatabaseName_TextChanged(object sender, EventArgs e)
	{
		objconnectionconfig.Initcatalog = msksDatabaseName.get_Text();
		objconnectionconfig.IsValid();
	}

	private void MskUserName_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)MskUserName).SelectAll();
	}

	private void MskUserName_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			((Control)MskPassword).Focus();
		}
	}

	private void MskPassword_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)MskPassword).SelectAll();
	}

	private void MskPassword_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		if ((int)e.get_KeyCode() == 13)
		{
			((Control)this).SelectNextControl((Control)sender, true, false, false, true);
		}
	}

	private void MskPassword_TextChanged(object sender, EventArgs e)
	{
		objconnectionconfig.nPassword = MskPassword.get_Text();
		objconnectionconfig.IsValid();
	}

	private void MskUserName_TextChanged(object sender, EventArgs e)
	{
		objconnectionconfig.nUsername = MskUserName.get_Text();
		objconnectionconfig.IsValid();
	}

	private void msksDatabaseName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
	{
	}

	private void chkLocal_CheckedChanged(object sender, EventArgs e)
	{
		if (chkLocal.get_Checked())
		{
			chknetwork.set_Checked(false);
			lblIPAddress.set_Text("Data Source");
			mskIPAddress.set_Text("Local");
			mskIPAddress.set_ReadOnly(true);
			((TextBoxBase)mskIPAddress).set_BackColor(Color.White);
			((Control)lblPort).set_Visible(false);
			((Control)MskSQLPort).set_Visible(false);
			objconnectionconfig.netWorkSource = false;
		}
		else
		{
			chknetwork.set_Checked(true);
		}
	}

	private void chkLocal_TextChanged(object sender, EventArgs e)
	{
	}

	private void chknetwork_CheckedChanged(object sender, EventArgs e)
	{
		if (chknetwork.get_Checked())
		{
			chkLocal.set_Checked(false);
			lblIPAddress.set_Text("Server IP Address");
			mskIPAddress.set_ReadOnly(false);
			chknetwork.set_Checked(true);
			((Control)lblPort).set_Visible(true);
			((Control)MskSQLPort).set_Visible(true);
		}
		else
		{
			chkLocal.set_Checked(true);
			objconnectionconfig.netWorkSource = true;
		}
	}

	private void mskIPAddress_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
	{
	}
}

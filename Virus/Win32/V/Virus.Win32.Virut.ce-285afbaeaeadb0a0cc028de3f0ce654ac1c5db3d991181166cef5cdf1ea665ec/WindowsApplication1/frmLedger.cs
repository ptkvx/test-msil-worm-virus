using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxThreed;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class frmLedger : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("AxSSPanel1")]
	private AxSSPanel _AxSSPanel1;

	[AccessedThroughProperty("cmdClose")]
	private AxSSCommand _cmdClose;

	[AccessedThroughProperty("cmdLast")]
	private AxSSCommand _cmdLast;

	[AccessedThroughProperty("cmdNext")]
	private AxSSCommand _cmdNext;

	[AccessedThroughProperty("cmdPrevious")]
	private AxSSCommand _cmdPrevious;

	[AccessedThroughProperty("cmdFirst")]
	private AxSSCommand _cmdFirst;

	[AccessedThroughProperty("cmdPrint")]
	private AxSSCommand _cmdPrint;

	[AccessedThroughProperty("cmdDelete")]
	private AxSSCommand _cmdDelete;

	[AccessedThroughProperty("cmdEdit")]
	private AxSSCommand _cmdEdit;

	[AccessedThroughProperty("cmdnew")]
	private AxSSCommand _cmdnew;

	[AccessedThroughProperty("txtAcref")]
	private TextBox _txtAcref;

	[AccessedThroughProperty("txtAcname")]
	private TextBox _txtAcname;

	[AccessedThroughProperty("cmbAccountType")]
	private ComboBox _cmbAccountType;

	[AccessedThroughProperty("txtExportAcref")]
	private TextBox _txtExportAcref;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtaccounttype")]
	private TextBox _txtaccounttype;

	[AccessedThroughProperty("objledger")]
	private Cledger _objledger;

	private long msgAns;

	public bool IsnewRecord;

	private Control MyControl;

	internal virtual AxSSPanel AxSSPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _AxSSPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AxSSPanel1 = value;
		}
	}

	internal virtual AxSSCommand cmdClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdClose != null)
			{
				((Control)_cmdClose).remove_Enter((EventHandler)cmdClose_Enter);
				_cmdClose.remove_ClickEvent((EventHandler)cmdClose_ClickEvent);
			}
			_cmdClose = value;
			if (_cmdClose != null)
			{
				((Control)_cmdClose).add_Enter((EventHandler)cmdClose_Enter);
				_cmdClose.add_ClickEvent((EventHandler)cmdClose_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdLast
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdLast;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdLast != null)
			{
				((Control)_cmdLast).remove_Enter((EventHandler)cmdLast_Enter);
				_cmdLast.remove_ClickEvent((EventHandler)cmdLast_ClickEvent);
			}
			_cmdLast = value;
			if (_cmdLast != null)
			{
				((Control)_cmdLast).add_Enter((EventHandler)cmdLast_Enter);
				_cmdLast.add_ClickEvent((EventHandler)cmdLast_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdNext
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdNext;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdNext != null)
			{
				((Control)_cmdNext).remove_Enter((EventHandler)cmdNext_Enter);
				_cmdNext.remove_ClickEvent((EventHandler)cmdNext_ClickEvent);
			}
			_cmdNext = value;
			if (_cmdNext != null)
			{
				((Control)_cmdNext).add_Enter((EventHandler)cmdNext_Enter);
				_cmdNext.add_ClickEvent((EventHandler)cmdNext_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdPrevious
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPrevious;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdPrevious != null)
			{
				((Control)_cmdPrevious).remove_Enter((EventHandler)cmdPrevious_Enter);
				_cmdPrevious.remove_ClickEvent((EventHandler)cmdPrevious_ClickEvent);
			}
			_cmdPrevious = value;
			if (_cmdPrevious != null)
			{
				((Control)_cmdPrevious).add_Enter((EventHandler)cmdPrevious_Enter);
				_cmdPrevious.add_ClickEvent((EventHandler)cmdPrevious_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdFirst
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdFirst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdFirst != null)
			{
				((Control)_cmdFirst).remove_Enter((EventHandler)cmdFirst_Enter);
				_cmdFirst.remove_ClickEvent((EventHandler)cmdFirst_ClickEvent);
			}
			_cmdFirst = value;
			if (_cmdFirst != null)
			{
				((Control)_cmdFirst).add_Enter((EventHandler)cmdFirst_Enter);
				_cmdFirst.add_ClickEvent((EventHandler)cmdFirst_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdPrint
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPrint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmdPrint = value;
		}
	}

	internal virtual AxSSCommand cmdDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).remove_Enter((EventHandler)cmdDelete_Enter);
				_cmdDelete.remove_ClickEvent((EventHandler)cmdDelete_ClickEvent);
			}
			_cmdDelete = value;
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).add_Enter((EventHandler)cmdDelete_Enter);
				_cmdDelete.add_ClickEvent((EventHandler)cmdDelete_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdEdit
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdEdit != null)
			{
				((Control)_cmdEdit).remove_Enter((EventHandler)cmdEdit_Enter);
				_cmdEdit.remove_ClickEvent((EventHandler)cmdEdit_ClickEvent);
			}
			_cmdEdit = value;
			if (_cmdEdit != null)
			{
				((Control)_cmdEdit).add_Enter((EventHandler)cmdEdit_Enter);
				_cmdEdit.add_ClickEvent((EventHandler)cmdEdit_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdnew
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdnew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdnew != null)
			{
				((Control)_cmdnew).remove_Enter((EventHandler)cmdnew_Enter);
				_cmdnew.remove_ClickEvent((EventHandler)cmdnew_ClickEvent);
			}
			_cmdnew = value;
			if (_cmdnew != null)
			{
				((Control)_cmdnew).add_Enter((EventHandler)cmdnew_Enter);
				_cmdnew.add_ClickEvent((EventHandler)cmdnew_ClickEvent);
			}
		}
	}

	internal virtual TextBox txtAcref
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAcref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_txtAcref != null)
			{
				((Control)_txtAcref).remove_LostFocus((EventHandler)txtAcref_LostFocus);
				((Control)_txtAcref).remove_KeyDown(new KeyEventHandler(txtAcref_KeyDown));
				((Control)_txtAcref).remove_GotFocus((EventHandler)txtAcref_GotFocus);
				((Control)_txtAcref).remove_TextChanged((EventHandler)txtAcref_TextChanged);
			}
			_txtAcref = value;
			if (_txtAcref != null)
			{
				((Control)_txtAcref).add_LostFocus((EventHandler)txtAcref_LostFocus);
				((Control)_txtAcref).add_KeyDown(new KeyEventHandler(txtAcref_KeyDown));
				((Control)_txtAcref).add_GotFocus((EventHandler)txtAcref_GotFocus);
				((Control)_txtAcref).add_TextChanged((EventHandler)txtAcref_TextChanged);
			}
		}
	}

	internal virtual TextBox txtAcname
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAcname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtAcname != null)
			{
				((Control)_txtAcname).remove_TextChanged((EventHandler)txtAcname_TextChanged);
				((Control)_txtAcname).remove_KeyDown(new KeyEventHandler(txtAcname_KeyDown));
				((Control)_txtAcname).remove_GotFocus((EventHandler)txtAcname_GotFocus);
			}
			_txtAcname = value;
			if (_txtAcname != null)
			{
				((Control)_txtAcname).add_TextChanged((EventHandler)txtAcname_TextChanged);
				((Control)_txtAcname).add_KeyDown(new KeyEventHandler(txtAcname_KeyDown));
				((Control)_txtAcname).add_GotFocus((EventHandler)txtAcname_GotFocus);
			}
		}
	}

	internal virtual ComboBox cmbAccountType
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbAccountType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_cmbAccountType != null)
			{
				((Control)_cmbAccountType).remove_TextChanged((EventHandler)cmbAccountType_TextChanged);
				_cmbAccountType.remove_SelectedIndexChanged((EventHandler)cmbAccountType_SelectedIndexChanged);
				((Control)_cmbAccountType).remove_KeyDown(new KeyEventHandler(cmbAccountType_KeyDown));
			}
			_cmbAccountType = value;
			if (_cmbAccountType != null)
			{
				((Control)_cmbAccountType).add_TextChanged((EventHandler)cmbAccountType_TextChanged);
				_cmbAccountType.add_SelectedIndexChanged((EventHandler)cmbAccountType_SelectedIndexChanged);
				((Control)_cmbAccountType).add_KeyDown(new KeyEventHandler(cmbAccountType_KeyDown));
			}
		}
	}

	internal virtual TextBox txtExportAcref
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtExportAcref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtExportAcref != null)
			{
				((Control)_txtExportAcref).remove_TextChanged((EventHandler)txtExportAcref_TextChanged);
				((Control)_txtExportAcref).remove_KeyDown(new KeyEventHandler(txtExportAcref_KeyDown));
				((Control)_txtExportAcref).remove_GotFocus((EventHandler)txtExportAcref_GotFocus);
			}
			_txtExportAcref = value;
			if (_txtExportAcref != null)
			{
				((Control)_txtExportAcref).add_TextChanged((EventHandler)txtExportAcref_TextChanged);
				((Control)_txtExportAcref).add_KeyDown(new KeyEventHandler(txtExportAcref_KeyDown));
				((Control)_txtExportAcref).add_GotFocus((EventHandler)txtExportAcref_GotFocus);
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

	internal virtual TextBox txtaccounttype
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtaccounttype;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtaccounttype != null)
			{
				((Control)_txtaccounttype).remove_TextChanged((EventHandler)txtaccounttype_TextChanged);
				((Control)_txtaccounttype).remove_KeyDown(new KeyEventHandler(txtaccounttype_KeyDown));
			}
			_txtaccounttype = value;
			if (_txtaccounttype != null)
			{
				((Control)_txtaccounttype).add_TextChanged((EventHandler)txtaccounttype_TextChanged);
				((Control)_txtaccounttype).add_KeyDown(new KeyEventHandler(txtaccounttype_KeyDown));
			}
		}
	}

	private virtual Cledger objledger
	{
		[DebuggerNonUserCode]
		get
		{
			return _objledger;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objledger != null)
			{
				_objledger.RecordExits -= objledger_RecordExits;
				_objledger.NoRecords -= objledger_NoRecords;
				_objledger.MoveForward -= objledger_MoveForward;
				_objledger.MoveBackward -= objledger_MoveBackward;
				_objledger.DataValidated -= objledger_DataValidated;
			}
			_objledger = value;
			if (_objledger != null)
			{
				_objledger.RecordExits += objledger_RecordExits;
				_objledger.NoRecords += objledger_NoRecords;
				_objledger.MoveForward += objledger_MoveForward;
				_objledger.MoveBackward += objledger_MoveBackward;
				_objledger.DataValidated += objledger_DataValidated;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmLedger()
	{
		((Form)this).add_Load((EventHandler)frmLedger_Load);
		__ENCList.Add(new WeakReference(this));
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Expected O, but got Unknown
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLedger));
		txtAcref = new TextBox();
		txtAcname = new TextBox();
		cmbAccountType = new ComboBox();
		txtExportAcref = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		cmdClose = new AxSSCommand();
		cmdLast = new AxSSCommand();
		cmdNext = new AxSSCommand();
		cmdPrevious = new AxSSCommand();
		cmdFirst = new AxSSCommand();
		cmdPrint = new AxSSCommand();
		cmdDelete = new AxSSCommand();
		cmdEdit = new AxSSCommand();
		cmdnew = new AxSSCommand();
		AxSSPanel1 = new AxSSPanel();
		txtaccounttype = new TextBox();
		((ISupportInitialize)cmdClose).BeginInit();
		((ISupportInitialize)cmdLast).BeginInit();
		((ISupportInitialize)cmdNext).BeginInit();
		((ISupportInitialize)cmdPrevious).BeginInit();
		((ISupportInitialize)cmdFirst).BeginInit();
		((ISupportInitialize)cmdPrint).BeginInit();
		((ISupportInitialize)cmdDelete).BeginInit();
		((ISupportInitialize)cmdEdit).BeginInit();
		((ISupportInitialize)cmdnew).BeginInit();
		((ISupportInitialize)AxSSPanel1).BeginInit();
		((Control)this).SuspendLayout();
		TextBox obj = txtAcref;
		Point location = new Point(148, 67);
		((Control)obj).set_Location(location);
		((Control)txtAcref).set_Name("txtAcref");
		TextBox obj2 = txtAcref;
		Size size = new Size(164, 20);
		((Control)obj2).set_Size(size);
		((Control)txtAcref).set_TabIndex(42);
		TextBox obj3 = txtAcname;
		location = new Point(148, 93);
		((Control)obj3).set_Location(location);
		((Control)txtAcname).set_Name("txtAcname");
		TextBox obj4 = txtAcname;
		size = new Size(164, 20);
		((Control)obj4).set_Size(size);
		((Control)txtAcname).set_TabIndex(43);
		((ListControl)cmbAccountType).set_FormattingEnabled(true);
		ComboBox obj5 = cmbAccountType;
		location = new Point(148, 120);
		((Control)obj5).set_Location(location);
		((Control)cmbAccountType).set_Name("cmbAccountType");
		ComboBox obj6 = cmbAccountType;
		size = new Size(164, 21);
		((Control)obj6).set_Size(size);
		((Control)cmbAccountType).set_TabIndex(44);
		TextBox obj7 = txtExportAcref;
		location = new Point(148, 169);
		((Control)obj7).set_Location(location);
		((Control)txtExportAcref).set_Name("txtExportAcref");
		TextBox obj8 = txtExportAcref;
		size = new Size(164, 20);
		((Control)obj8).set_Size(size);
		((Control)txtExportAcref).set_TabIndex(45);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(32, 70);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(61, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(46);
		Label1.set_Text("Account ID");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(32, 96);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(78, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(47);
		Label2.set_Text("Account Name");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(32, 123);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(74, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(48);
		Label3.set_Text("Account Type");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(32, 172);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(100, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(49);
		Label4.set_Text("Export Account Ref");
		AxSSCommand obj9 = cmdClose;
		location = new Point(406, 251);
		((Control)obj9).set_Location(location);
		((Control)cmdClose).set_Name("cmdClose");
		((AxHost)cmdClose).set_OcxState((State)componentResourceManager.GetObject("cmdClose.OcxState"));
		AxSSCommand obj10 = cmdClose;
		size = new Size(61, 24);
		((Control)obj10).set_Size(size);
		((Control)cmdClose).set_TabIndex(41);
		AxSSCommand obj11 = cmdLast;
		location = new Point(232, 251);
		((Control)obj11).set_Location(location);
		((Control)cmdLast).set_Name("cmdLast");
		((AxHost)cmdLast).set_OcxState((State)componentResourceManager.GetObject("cmdLast.OcxState"));
		AxSSCommand obj12 = cmdLast;
		size = new Size(61, 24);
		((Control)obj12).set_Size(size);
		((Control)cmdLast).set_TabIndex(40);
		AxSSCommand obj13 = cmdNext;
		location = new Point(159, 251);
		((Control)obj13).set_Location(location);
		((Control)cmdNext).set_Name("cmdNext");
		((AxHost)cmdNext).set_OcxState((State)componentResourceManager.GetObject("cmdNext.OcxState"));
		AxSSCommand obj14 = cmdNext;
		size = new Size(61, 24);
		((Control)obj14).set_Size(size);
		((Control)cmdNext).set_TabIndex(39);
		AxSSCommand obj15 = cmdPrevious;
		location = new Point(85, 251);
		((Control)obj15).set_Location(location);
		((Control)cmdPrevious).set_Name("cmdPrevious");
		((AxHost)cmdPrevious).set_OcxState((State)componentResourceManager.GetObject("cmdPrevious.OcxState"));
		AxSSCommand obj16 = cmdPrevious;
		size = new Size(61, 24);
		((Control)obj16).set_Size(size);
		((Control)cmdPrevious).set_TabIndex(38);
		AxSSCommand obj17 = cmdFirst;
		location = new Point(11, 251);
		((Control)obj17).set_Location(location);
		((Control)cmdFirst).set_Name("cmdFirst");
		((AxHost)cmdFirst).set_OcxState((State)componentResourceManager.GetObject("cmdFirst.OcxState"));
		AxSSCommand obj18 = cmdFirst;
		size = new Size(61, 24);
		((Control)obj18).set_Size(size);
		((Control)cmdFirst).set_TabIndex(37);
		AxSSCommand obj19 = cmdPrint;
		location = new Point(406, 135);
		((Control)obj19).set_Location(location);
		((Control)cmdPrint).set_Name("cmdPrint");
		((AxHost)cmdPrint).set_OcxState((State)componentResourceManager.GetObject("cmdPrint.OcxState"));
		AxSSCommand obj20 = cmdPrint;
		size = new Size(61, 24);
		((Control)obj20).set_Size(size);
		((Control)cmdPrint).set_TabIndex(36);
		AxSSCommand obj21 = cmdDelete;
		location = new Point(406, 101);
		((Control)obj21).set_Location(location);
		((Control)cmdDelete).set_Name("cmdDelete");
		((AxHost)cmdDelete).set_OcxState((State)componentResourceManager.GetObject("cmdDelete.OcxState"));
		AxSSCommand obj22 = cmdDelete;
		size = new Size(61, 24);
		((Control)obj22).set_Size(size);
		((Control)cmdDelete).set_TabIndex(35);
		AxSSCommand obj23 = cmdEdit;
		location = new Point(406, 67);
		((Control)obj23).set_Location(location);
		((Control)cmdEdit).set_Name("cmdEdit");
		((AxHost)cmdEdit).set_OcxState((State)componentResourceManager.GetObject("cmdEdit.OcxState"));
		AxSSCommand obj24 = cmdEdit;
		size = new Size(61, 24);
		((Control)obj24).set_Size(size);
		((Control)cmdEdit).set_TabIndex(34);
		AxSSCommand obj25 = cmdnew;
		location = new Point(406, 33);
		((Control)obj25).set_Location(location);
		((Control)cmdnew).set_Name("cmdnew");
		((AxHost)cmdnew).set_OcxState((State)componentResourceManager.GetObject("cmdnew.OcxState"));
		AxSSCommand obj26 = cmdnew;
		size = new Size(61, 24);
		((Control)obj26).set_Size(size);
		((Control)cmdnew).set_TabIndex(33);
		AxSSPanel axSSPanel = AxSSPanel1;
		location = new Point(11, 12);
		((Control)axSSPanel).set_Location(location);
		((Control)AxSSPanel1).set_Name("AxSSPanel1");
		((AxHost)AxSSPanel1).set_OcxState((State)componentResourceManager.GetObject("AxSSPanel1.OcxState"));
		AxSSPanel axSSPanel2 = AxSSPanel1;
		size = new Size(389, 233);
		((Control)axSSPanel2).set_Size(size);
		((Control)AxSSPanel1).set_TabIndex(0);
		TextBox obj27 = txtaccounttype;
		location = new Point(148, 121);
		((Control)obj27).set_Location(location);
		((Control)txtaccounttype).set_Name("txtaccounttype");
		TextBox obj28 = txtaccounttype;
		size = new Size(164, 20);
		((Control)obj28).set_Size(size);
		((Control)txtaccounttype).set_TabIndex(50);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		size = new Size(474, 287);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)txtaccounttype);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtExportAcref);
		((Control)this).get_Controls().Add((Control)(object)cmbAccountType);
		((Control)this).get_Controls().Add((Control)(object)txtAcname);
		((Control)this).get_Controls().Add((Control)(object)txtAcref);
		((Control)this).get_Controls().Add((Control)(object)cmdClose);
		((Control)this).get_Controls().Add((Control)(object)cmdLast);
		((Control)this).get_Controls().Add((Control)(object)cmdNext);
		((Control)this).get_Controls().Add((Control)(object)cmdPrevious);
		((Control)this).get_Controls().Add((Control)(object)cmdFirst);
		((Control)this).get_Controls().Add((Control)(object)cmdPrint);
		((Control)this).get_Controls().Add((Control)(object)cmdDelete);
		((Control)this).get_Controls().Add((Control)(object)cmdEdit);
		((Control)this).get_Controls().Add((Control)(object)cmdnew);
		((Control)this).get_Controls().Add((Control)(object)AxSSPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmLedger");
		((Form)this).set_Text("Chart of Accounts");
		((ISupportInitialize)cmdClose).EndInit();
		((ISupportInitialize)cmdLast).EndInit();
		((ISupportInitialize)cmdNext).EndInit();
		((ISupportInitialize)cmdPrevious).EndInit();
		((ISupportInitialize)cmdFirst).EndInit();
		((ISupportInitialize)cmdPrint).EndInit();
		((ISupportInitialize)cmdDelete).EndInit();
		((ISupportInitialize)cmdEdit).EndInit();
		((ISupportInitialize)cmdnew).EndInit();
		((ISupportInitialize)AxSSPanel1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdClose_ClickEvent(object sender, EventArgs e)
	{
		objledger = null;
		((Form)this).Close();
	}

	private void cmdClose_Enter(object sender, EventArgs e)
	{
	}

	private void frmLedger_Load(object sender, EventArgs e)
	{
		objledger = new Cledger();
		objledger.Initialise(Startup.dBcon);
		GetAccountTypes();
		viewmode();
		Refreshdata();
	}

	private void GetAccountTypes()
	{
		cmbAccountType.get_Items().Add((object)"Fixed Assets");
		cmbAccountType.get_Items().Add((object)"Current Assets");
		cmbAccountType.get_Items().Add((object)"Current Liability");
		cmbAccountType.get_Items().Add((object)"Equit/Capital");
		cmbAccountType.get_Items().Add((object)"Incomes");
		cmbAccountType.get_Items().Add((object)"Cost of Goods");
		cmbAccountType.get_Items().Add((object)"Direct Expenses");
		cmbAccountType.get_Items().Add((object)"Expenses");
	}

	private void ClearData()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				MyControl = (Control)enumerator.Current;
				if (MyControl is TextBox)
				{
					TextBox val = (TextBox)MyControl;
					val.set_Text("");
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void viewmode()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (val is TextBox)
				{
					TextBox val2 = (TextBox)val;
					((TextBoxBase)val2).set_ReadOnly(true);
					((TextBoxBase)val2).set_BackColor(Color.White);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Control)cmbAccountType).set_Visible(false);
		((Control)txtaccounttype).set_Visible(true);
		cmdNext.set_Enabled(true);
		cmdPrevious.set_Enabled(true);
		cmdLast.set_Enabled(true);
		cmdFirst.set_Enabled(true);
		cmdnew.set_Enabled(true);
		cmdnew.set_Caption("&New");
		cmdEdit.set_Caption("&Edit");
		cmdDelete.set_Enabled(true);
		cmdPrint.set_Enabled(true);
		cmdClose.set_Enabled(true);
	}

	private void editmode()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (val is TextBox)
				{
					TextBox val2 = (TextBox)val;
					((TextBoxBase)val2).set_ReadOnly(false);
					((TextBoxBase)val2).set_BackColor(Color.White);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Control)txtaccounttype).set_Visible(false);
		((Control)cmbAccountType).set_Visible(true);
		cmdNext.set_Enabled(false);
		cmdPrevious.set_Enabled(false);
		cmdLast.set_Enabled(false);
		cmdFirst.set_Enabled(false);
		cmdnew.set_Enabled(true);
		cmdnew.set_Caption("&Save");
		cmdEdit.set_Caption("&Cance");
		cmdEdit.set_Enabled(true);
		cmdDelete.set_Enabled(false);
		cmdPrint.set_Enabled(false);
		cmdClose.set_Enabled(false);
	}

	private void Refreshdata()
	{
		txtAcref.set_Text(Conversions.ToString(objledger.Acref));
		txtAcname.set_Text(Conversions.ToString(objledger.Acname));
		cmbAccountType.set_Text(Conversions.ToString(objledger.Actype));
		txtaccounttype.set_Text(Conversions.ToString(objledger.Actype));
		txtExportAcref.set_Text(Conversions.ToString(objledger.ExportAcref));
	}

	private void txtAcref_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtAcref).SelectAll();
	}

	private void txtAcref_KeyDown(object sender, KeyEventArgs e)
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

	private void txtAcref_LostFocus(object sender, EventArgs e)
	{
		if ((Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0) & IsnewRecord)
		{
			objledger.FindRecord(txtAcref.get_Text());
		}
	}

	private void txtAcref_TextChanged(object sender, EventArgs e)
	{
		objledger.Acref = txtAcref.get_Text();
		objledger.IsValid();
	}

	private void txtAcname_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtAcname).SelectAll();
	}

	private void txtAcname_KeyDown(object sender, KeyEventArgs e)
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

	private void txtAcname_TextChanged(object sender, EventArgs e)
	{
		objledger.Acname = txtAcname.get_Text();
		objledger.IsValid();
	}

	private void cmbAccountType_KeyDown(object sender, KeyEventArgs e)
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

	private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0)
		{
			objledger.Actype = RuntimeHelpers.GetObjectValue(cmbAccountType.get_SelectedItem());
			txtaccounttype.set_Text(Conversions.ToString(cmbAccountType.get_SelectedItem()));
			objledger.ActypeId = cmbAccountType.get_SelectedIndex();
			objledger.IsValid();
		}
	}

	private void txtExportAcref_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtExportAcref).SelectAll();
	}

	private void txtExportAcref_KeyDown(object sender, KeyEventArgs e)
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

	private void txtExportAcref_TextChanged(object sender, EventArgs e)
	{
		objledger.ExportAcref = txtExportAcref.get_Text();
		objledger.IsValid();
	}

	private void cmdFirst_ClickEvent(object sender, EventArgs e)
	{
		objledger.MoveFirst();
		Refreshdata();
	}

	private void cmdFirst_Enter(object sender, EventArgs e)
	{
	}

	private void cmdPrevious_ClickEvent(object sender, EventArgs e)
	{
		objledger.MovePrevious();
		Refreshdata();
	}

	private void cmdPrevious_Enter(object sender, EventArgs e)
	{
	}

	private void cmdNext_ClickEvent(object sender, EventArgs e)
	{
		objledger.MoveNext();
		Refreshdata();
	}

	private void cmdNext_Enter(object sender, EventArgs e)
	{
	}

	private void cmdLast_ClickEvent(object sender, EventArgs e)
	{
		objledger.MoveLast();
		Refreshdata();
	}

	private void cmdLast_Enter(object sender, EventArgs e)
	{
	}

	private void cmdnew_ClickEvent(object sender, EventArgs e)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(cmdnew.get_Caption(), "&New", false) == 0)
		{
			IsnewRecord = true;
			ClearData();
			cmbAccountType.set_SelectedItem(RuntimeHelpers.GetObjectValue(cmbAccountType.get_Items().get_Item(0)));
			cmbAccountType.set_Text(Conversions.ToString(cmbAccountType.get_Items().get_Item(0)));
			txtaccounttype.set_Text(Conversions.ToString(cmbAccountType.get_Items().get_Item(0)));
			editmode();
			((Control)txtAcref).Focus();
			cmdnew.set_Enabled(false);
		}
		else
		{
			objledger.Save(IsnewRecord);
			Interaction.MsgBox((object)"Data Successfully Saved", (MsgBoxStyle)64, (object)"information");
			viewmode();
		}
	}

	private void cmdnew_Enter(object sender, EventArgs e)
	{
	}

	private void cmdEdit_ClickEvent(object sender, EventArgs e)
	{
		if (Operators.CompareString(cmdEdit.get_Caption(), "&Edit", false) == 0)
		{
			IsnewRecord = false;
			editmode();
			((TextBoxBase)txtAcref).set_ReadOnly(true);
			((TextBoxBase)txtAcref).set_BackColor(Color.White);
			((Control)txtAcname).Focus();
		}
		else
		{
			viewmode();
			objledger.Initialise(Startup.dBcon);
			Refreshdata();
		}
	}

	private void cmdEdit_Enter(object sender, EventArgs e)
	{
	}

	private void objledger_DataValidated(bool blnIsValid)
	{
		cmdnew.set_Enabled(blnIsValid);
	}

	private void objledger_MoveBackward(bool blnMoveBack)
	{
		cmdPrevious.set_Enabled(blnMoveBack);
		cmdFirst.set_Enabled(blnMoveBack);
	}

	private void objledger_MoveForward(bool blnMoveForward)
	{
		cmdNext.set_Enabled(blnMoveForward);
		cmdLast.set_Enabled(blnMoveForward);
	}

	private void objledger_NoRecords()
	{
		ClearData();
		cmdNext.set_Enabled(false);
		cmdPrevious.set_Enabled(false);
		cmdLast.set_Enabled(false);
		cmdFirst.set_Enabled(false);
		cmdnew.set_Enabled(true);
		cmdnew.set_Caption("&New");
		cmdEdit.set_Enabled(false);
		cmdEdit.set_Caption("&Edit");
		cmdDelete.set_Enabled(false);
		cmdPrint.set_Enabled(false);
		cmdClose.set_Enabled(true);
	}

	private void objledger_RecordExits()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"Accounts Ledger ID Already Exits", (MsgBoxStyle)69, (object)"Information");
		if (msgAns == 4L)
		{
			((Control)txtAcref).Focus();
		}
		else
		{
			cmdEdit.DoClick();
		}
	}

	private void cmdDelete_ClickEvent(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"You are about to delete this record.\r\nDo you want to proceed?", (MsgBoxStyle)68, (object)"Information");
		if (msgAns == 6L)
		{
			objledger.Delete(txtAcref.get_Text());
			Refreshdata();
		}
	}

	private void cmdDelete_Enter(object sender, EventArgs e)
	{
	}

	private void txtaccounttype_KeyDown(object sender, KeyEventArgs e)
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

	private void txtaccounttype_TextChanged(object sender, EventArgs e)
	{
	}

	private void cmbAccountType_TextChanged(object sender, EventArgs e)
	{
		objledger.Actype = cmbAccountType.get_Text();
		objledger.ActypeId = cmbAccountType.get_SelectedIndex();
	}
}

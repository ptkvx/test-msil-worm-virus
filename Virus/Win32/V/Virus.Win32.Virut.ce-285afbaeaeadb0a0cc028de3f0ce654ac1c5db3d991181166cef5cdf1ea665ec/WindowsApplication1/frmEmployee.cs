using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxThreed;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class frmEmployee : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("AxSSPanel1")]
	private AxSSPanel _AxSSPanel1;

	[AccessedThroughProperty("txtAcname")]
	private TextBox _txtAcname;

	[AccessedThroughProperty("txtAcref")]
	private TextBox _txtAcref;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TxtEmployeeID")]
	private TextBox _TxtEmployeeID;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TxtFname")]
	private TextBox _TxtFname;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TxtLname")]
	private TextBox _TxtLname;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("CmbEGender")]
	private ComboBox _CmbEGender;

	[AccessedThroughProperty("DGVEmployee")]
	private DataGridView _DGVEmployee;

	[AccessedThroughProperty("CmbDGender")]
	private ComboBox _CmbDGender;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtDLname")]
	private TextBox _txtDLname;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("TxtDFname")]
	private TextBox _TxtDFname;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("TxtDependantID")]
	private TextBox _TxtDependantID;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("txtRelationship")]
	private TextBox _txtRelationship;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("DGVDependantw2")]
	private DataGridView _DGVDependantw2;

	[AccessedThroughProperty("AxSSPanel2")]
	private AxSSPanel _AxSSPanel2;

	[AccessedThroughProperty("AxSSPanel3")]
	private AxSSPanel _AxSSPanel3;

	[AccessedThroughProperty("CmdEnew")]
	private AxSSCommand _CmdEnew;

	[AccessedThroughProperty("CmdEdelete")]
	private AxSSCommand _CmdEdelete;

	[AccessedThroughProperty("CmdEedit")]
	private AxSSCommand _CmdEedit;

	[AccessedThroughProperty("CmdDedit")]
	private AxSSCommand _CmdDedit;

	[AccessedThroughProperty("CmdDdelete")]
	private AxSSCommand _CmdDdelete;

	[AccessedThroughProperty("CmdDnew")]
	private AxSSCommand _CmdDnew;

	[AccessedThroughProperty("cmdClose")]
	private AxSSCommand _cmdClose;

	[AccessedThroughProperty("cmdPrint")]
	private AxSSCommand _cmdPrint;

	[AccessedThroughProperty("cmdLast")]
	private AxSSCommand _cmdLast;

	[AccessedThroughProperty("cmdNext")]
	private AxSSCommand _cmdNext;

	[AccessedThroughProperty("cmdPrevious")]
	private AxSSCommand _cmdPrevious;

	[AccessedThroughProperty("cmdFirst")]
	private AxSSCommand _cmdFirst;

	[AccessedThroughProperty("DTPEDOB")]
	private DateTimePicker _DTPEDOB;

	[AccessedThroughProperty("DTPDDOB")]
	private DateTimePicker _DTPDDOB;

	[AccessedThroughProperty("DependantID")]
	private DataGridViewTextBoxColumn _DependantID;

	[AccessedThroughProperty("DFirstname")]
	private DataGridViewTextBoxColumn _DFirstname;

	[AccessedThroughProperty("Dlastname")]
	private DataGridViewTextBoxColumn _Dlastname;

	[AccessedThroughProperty("DGender")]
	private DataGridViewTextBoxColumn _DGender;

	[AccessedThroughProperty("dDOB")]
	private DataGridViewTextBoxColumn _dDOB;

	[AccessedThroughProperty("Relationshif")]
	private DataGridViewTextBoxColumn _Relationshif;

	[AccessedThroughProperty("txtEgender")]
	private TextBox _txtEgender;

	[AccessedThroughProperty("txtEdob")]
	private TextBox _txtEdob;

	[AccessedThroughProperty("txtDDOB")]
	private TextBox _txtDDOB;

	[AccessedThroughProperty("txtDgender")]
	private TextBox _txtDgender;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("objEmployee")]
	private CEmployee _objEmployee;

	[AccessedThroughProperty("objcustomer")]
	private Ccustomer _objcustomer;

	[AccessedThroughProperty("objdependant")]
	private Cdependant _objdependant;

	private long msgAns;

	public bool IsnewERecord;

	public bool IsnewDRecord;

	private Control MyControl;

	private SqlDataAdapter dagroup;

	private DataSet dsgroup;

	private string StrEmployee;

	private SqlDataAdapter daEmployee;

	private DataSet dsEmployee;

	private DataRow drowEmployee;

	private DataTable DtEmployee;

	private string StrDependant;

	private SqlDataAdapter daDependant;

	private DataSet dsDependant;

	private string StrSQL;

	private double isNum;

	private Form nform;

	private DataRow nrowgroup;

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
			_txtAcname = value;
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
			if (_txtAcref != null)
			{
				((Control)_txtAcref).remove_TextChanged((EventHandler)txtAcref_TextChanged);
			}
			_txtAcref = value;
			if (_txtAcref != null)
			{
				((Control)_txtAcref).add_TextChanged((EventHandler)txtAcref_TextChanged);
			}
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

	internal virtual TextBox TxtEmployeeID
	{
		[DebuggerNonUserCode]
		get
		{
			return _TxtEmployeeID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_TxtEmployeeID != null)
			{
				((Control)_TxtEmployeeID).remove_TextChanged((EventHandler)TxtEmployeeID_TextChanged);
			}
			_TxtEmployeeID = value;
			if (_TxtEmployeeID != null)
			{
				((Control)_TxtEmployeeID).add_TextChanged((EventHandler)TxtEmployeeID_TextChanged);
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

	internal virtual TextBox TxtFname
	{
		[DebuggerNonUserCode]
		get
		{
			return _TxtFname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_TxtFname != null)
			{
				((Control)_TxtFname).remove_TextChanged((EventHandler)TxtFname_TextChanged);
			}
			_TxtFname = value;
			if (_TxtFname != null)
			{
				((Control)_TxtFname).add_TextChanged((EventHandler)TxtFname_TextChanged);
			}
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

	internal virtual TextBox TxtLname
	{
		[DebuggerNonUserCode]
		get
		{
			return _TxtLname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_TxtLname != null)
			{
				((Control)_TxtLname).remove_TextChanged((EventHandler)TxtLname_TextChanged);
			}
			_TxtLname = value;
			if (_TxtLname != null)
			{
				((Control)_TxtLname).add_TextChanged((EventHandler)TxtLname_TextChanged);
			}
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

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual ComboBox CmbEGender
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmbEGender;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CmbEGender != null)
			{
				((Control)_CmbEGender).remove_TextChanged((EventHandler)CmbEGender_TextChanged);
				_CmbEGender.remove_SelectedIndexChanged((EventHandler)CmbGender_SelectedIndexChanged);
			}
			_CmbEGender = value;
			if (_CmbEGender != null)
			{
				((Control)_CmbEGender).add_TextChanged((EventHandler)CmbEGender_TextChanged);
				_CmbEGender.add_SelectedIndexChanged((EventHandler)CmbGender_SelectedIndexChanged);
			}
		}
	}

	internal virtual DataGridView DGVEmployee
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVEmployee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_DGVEmployee != null)
			{
				((Control)_DGVEmployee).remove_KeyDown(new KeyEventHandler(DGVEmployee_KeyDown));
				_DGVEmployee.remove_CellEnter(new DataGridViewCellEventHandler(DGVEmployee_CellEnter));
				_DGVEmployee.remove_CellContentClick(new DataGridViewCellEventHandler(DGVEmployee_CellContentClick));
			}
			_DGVEmployee = value;
			if (_DGVEmployee != null)
			{
				((Control)_DGVEmployee).add_KeyDown(new KeyEventHandler(DGVEmployee_KeyDown));
				_DGVEmployee.add_CellEnter(new DataGridViewCellEventHandler(DGVEmployee_CellEnter));
				_DGVEmployee.add_CellContentClick(new DataGridViewCellEventHandler(DGVEmployee_CellContentClick));
			}
		}
	}

	internal virtual ComboBox CmbDGender
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmbDGender;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CmbDGender != null)
			{
				((Control)_CmbDGender).remove_TextChanged((EventHandler)CmbDGender_TextChanged);
			}
			_CmbDGender = value;
			if (_CmbDGender != null)
			{
				((Control)_CmbDGender).add_TextChanged((EventHandler)CmbDGender_TextChanged);
			}
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual TextBox txtDLname
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDLname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDLname = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual TextBox TxtDFname
	{
		[DebuggerNonUserCode]
		get
		{
			return _TxtDFname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TxtDFname = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual TextBox TxtDependantID
	{
		[DebuggerNonUserCode]
		get
		{
			return _TxtDependantID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TxtDependantID = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual TextBox txtRelationship
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtRelationship;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtRelationship = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual DataGridView DGVDependantw2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGVDependantw2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGVDependantw2 = value;
		}
	}

	internal virtual AxSSPanel AxSSPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _AxSSPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_AxSSPanel2 != null)
			{
				((Control)_AxSSPanel2).remove_Enter((EventHandler)AxSSPanel2_Enter);
			}
			_AxSSPanel2 = value;
			if (_AxSSPanel2 != null)
			{
				((Control)_AxSSPanel2).add_Enter((EventHandler)AxSSPanel2_Enter);
			}
		}
	}

	internal virtual AxSSPanel AxSSPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _AxSSPanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AxSSPanel3 = value;
		}
	}

	internal virtual AxSSCommand CmdEnew
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdEnew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CmdEnew != null)
			{
				((Control)_CmdEnew).remove_Enter((EventHandler)CmdEnew_Enter);
				_CmdEnew.remove_ClickEvent((EventHandler)CmdEnew_ClickEvent);
			}
			_CmdEnew = value;
			if (_CmdEnew != null)
			{
				((Control)_CmdEnew).add_Enter((EventHandler)CmdEnew_Enter);
				_CmdEnew.add_ClickEvent((EventHandler)CmdEnew_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand CmdEdelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdEdelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CmdEdelete != null)
			{
				((Control)_CmdEdelete).remove_Enter((EventHandler)CmdEdelete_Enter);
				_CmdEdelete.remove_ClickEvent((EventHandler)CmdEdelete_ClickEvent);
			}
			_CmdEdelete = value;
			if (_CmdEdelete != null)
			{
				((Control)_CmdEdelete).add_Enter((EventHandler)CmdEdelete_Enter);
				_CmdEdelete.add_ClickEvent((EventHandler)CmdEdelete_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand CmdEedit
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdEedit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CmdEedit != null)
			{
				((Control)_CmdEedit).remove_Enter((EventHandler)CmdEedit_Enter);
				_CmdEedit.remove_ClickEvent((EventHandler)CmdEedit_ClickEvent);
			}
			_CmdEedit = value;
			if (_CmdEedit != null)
			{
				((Control)_CmdEedit).add_Enter((EventHandler)CmdEedit_Enter);
				_CmdEedit.add_ClickEvent((EventHandler)CmdEedit_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand CmdDedit
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdDedit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CmdDedit = value;
		}
	}

	internal virtual AxSSCommand CmdDdelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdDdelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CmdDdelete = value;
		}
	}

	internal virtual AxSSCommand CmdDnew
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdDnew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CmdDnew = value;
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
			}
			_cmdLast = value;
			if (_cmdLast != null)
			{
				((Control)_cmdLast).add_Enter((EventHandler)cmdLast_Enter);
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

	internal virtual DateTimePicker DTPEDOB
	{
		[DebuggerNonUserCode]
		get
		{
			return _DTPEDOB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_DTPEDOB != null)
			{
				_DTPEDOB.remove_ValueChanged((EventHandler)DTPEDOB_ValueChanged);
			}
			_DTPEDOB = value;
			if (_DTPEDOB != null)
			{
				_DTPEDOB.add_ValueChanged((EventHandler)DTPEDOB_ValueChanged);
			}
		}
	}

	internal virtual DateTimePicker DTPDDOB
	{
		[DebuggerNonUserCode]
		get
		{
			return _DTPDDOB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_DTPDDOB != null)
			{
				_DTPDDOB.remove_ValueChanged((EventHandler)DTPDDOB_ValueChanged);
				_DTPDDOB.remove_TextChanged((EventHandler)DTPDDOB_TextChanged);
			}
			_DTPDDOB = value;
			if (_DTPDDOB != null)
			{
				_DTPDDOB.add_ValueChanged((EventHandler)DTPDDOB_ValueChanged);
				_DTPDDOB.add_TextChanged((EventHandler)DTPDDOB_TextChanged);
			}
		}
	}

	internal virtual DataGridViewTextBoxColumn DependantID
	{
		[DebuggerNonUserCode]
		get
		{
			return _DependantID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DependantID = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DFirstname
	{
		[DebuggerNonUserCode]
		get
		{
			return _DFirstname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DFirstname = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Dlastname
	{
		[DebuggerNonUserCode]
		get
		{
			return _Dlastname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Dlastname = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn DGender
	{
		[DebuggerNonUserCode]
		get
		{
			return _DGender;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DGender = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn dDOB
	{
		[DebuggerNonUserCode]
		get
		{
			return _dDOB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dDOB = value;
		}
	}

	internal virtual DataGridViewTextBoxColumn Relationshif
	{
		[DebuggerNonUserCode]
		get
		{
			return _Relationshif;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Relationshif = value;
		}
	}

	internal virtual TextBox txtEgender
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEgender;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEgender = value;
		}
	}

	internal virtual TextBox txtEdob
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtEdob;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtEdob = value;
		}
	}

	internal virtual TextBox txtDDOB
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDDOB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDDOB = value;
		}
	}

	internal virtual TextBox txtDgender
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtDgender;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtDgender = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click((EventHandler)Button1_Click);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click((EventHandler)Button1_Click);
			}
		}
	}

	private virtual CEmployee objEmployee
	{
		[DebuggerNonUserCode]
		get
		{
			return _objEmployee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objEmployee != null)
			{
				_objEmployee.RecordExits -= objEmployee_RecordExits;
				_objEmployee.DataValidated -= objEmployee_DataValidated;
				_objEmployee.NoRecords -= objEmployee_NoRecords;
			}
			_objEmployee = value;
			if (_objEmployee != null)
			{
				_objEmployee.RecordExits += objEmployee_RecordExits;
				_objEmployee.DataValidated += objEmployee_DataValidated;
				_objEmployee.NoRecords += objEmployee_NoRecords;
			}
		}
	}

	private virtual Ccustomer objcustomer
	{
		[DebuggerNonUserCode]
		get
		{
			return _objcustomer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objcustomer != null)
			{
				_objcustomer.NoRecords -= objcustomer_NoRecords;
				_objcustomer.MoveForward -= objcustomer_MoveForward;
				_objcustomer.MoveBackward -= objcustomer_MoveBackward;
			}
			_objcustomer = value;
			if (_objcustomer != null)
			{
				_objcustomer.NoRecords += objcustomer_NoRecords;
				_objcustomer.MoveForward += objcustomer_MoveForward;
				_objcustomer.MoveBackward += objcustomer_MoveBackward;
			}
		}
	}

	private virtual Cdependant objdependant
	{
		[DebuggerNonUserCode]
		get
		{
			return _objdependant;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objdependant != null)
			{
				_objdependant.RecordExits -= objdependant_RecordExits;
				_objdependant.NoRecords -= objdependant_NoRecords;
				_objdependant.DataValidated -= objdependant_DataValidated;
			}
			_objdependant = value;
			if (_objdependant != null)
			{
				_objdependant.RecordExits += objdependant_RecordExits;
				_objdependant.NoRecords += objdependant_NoRecords;
				_objdependant.DataValidated += objdependant_DataValidated;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmEmployee()
	{
		((Form)this).add_Load((EventHandler)frmEmployee_Load);
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
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Expected O, but got Unknown
		//IL_0eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected O, but got Unknown
		//IL_0f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected O, but got Unknown
		//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Expected O, but got Unknown
		//IL_1033: Unknown result type (might be due to invalid IL or missing references)
		//IL_103d: Expected O, but got Unknown
		//IL_109f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a9: Expected O, but got Unknown
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected O, but got Unknown
		//IL_117a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Expected O, but got Unknown
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f0: Expected O, but got Unknown
		//IL_1255: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f: Expected O, but got Unknown
		//IL_12c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ce: Expected O, but got Unknown
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_133d: Expected O, but got Unknown
		//IL_139f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a9: Expected O, but got Unknown
		//IL_140b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1415: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmEmployee));
		AxSSPanel1 = new AxSSPanel();
		txtAcname = new TextBox();
		txtAcref = new TextBox();
		Label3 = new Label();
		TxtEmployeeID = new TextBox();
		Label1 = new Label();
		TxtFname = new TextBox();
		Label2 = new Label();
		TxtLname = new TextBox();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		CmbEGender = new ComboBox();
		DGVEmployee = new DataGridView();
		CmbDGender = new ComboBox();
		Label7 = new Label();
		Label8 = new Label();
		txtDLname = new TextBox();
		Label9 = new Label();
		TxtDFname = new TextBox();
		Label10 = new Label();
		TxtDependantID = new TextBox();
		Label11 = new Label();
		txtRelationship = new TextBox();
		Label12 = new Label();
		DGVDependantw2 = new DataGridView();
		DependantID = new DataGridViewTextBoxColumn();
		DFirstname = new DataGridViewTextBoxColumn();
		Dlastname = new DataGridViewTextBoxColumn();
		DGender = new DataGridViewTextBoxColumn();
		dDOB = new DataGridViewTextBoxColumn();
		Relationshif = new DataGridViewTextBoxColumn();
		AxSSPanel2 = new AxSSPanel();
		AxSSPanel3 = new AxSSPanel();
		CmdEnew = new AxSSCommand();
		CmdEdelete = new AxSSCommand();
		CmdEedit = new AxSSCommand();
		CmdDedit = new AxSSCommand();
		CmdDdelete = new AxSSCommand();
		CmdDnew = new AxSSCommand();
		cmdClose = new AxSSCommand();
		cmdPrint = new AxSSCommand();
		cmdLast = new AxSSCommand();
		cmdNext = new AxSSCommand();
		cmdPrevious = new AxSSCommand();
		cmdFirst = new AxSSCommand();
		DTPEDOB = new DateTimePicker();
		DTPDDOB = new DateTimePicker();
		txtEgender = new TextBox();
		txtEdob = new TextBox();
		txtDDOB = new TextBox();
		txtDgender = new TextBox();
		Button1 = new Button();
		((ISupportInitialize)AxSSPanel1).BeginInit();
		((ISupportInitialize)DGVEmployee).BeginInit();
		((ISupportInitialize)DGVDependantw2).BeginInit();
		((ISupportInitialize)AxSSPanel2).BeginInit();
		((ISupportInitialize)AxSSPanel3).BeginInit();
		((ISupportInitialize)CmdEnew).BeginInit();
		((ISupportInitialize)CmdEdelete).BeginInit();
		((ISupportInitialize)CmdEedit).BeginInit();
		((ISupportInitialize)CmdDedit).BeginInit();
		((ISupportInitialize)CmdDdelete).BeginInit();
		((ISupportInitialize)CmdDnew).BeginInit();
		((ISupportInitialize)cmdClose).BeginInit();
		((ISupportInitialize)cmdPrint).BeginInit();
		((ISupportInitialize)cmdLast).BeginInit();
		((ISupportInitialize)cmdNext).BeginInit();
		((ISupportInitialize)cmdPrevious).BeginInit();
		((ISupportInitialize)cmdFirst).BeginInit();
		((Control)this).SuspendLayout();
		AxSSPanel axSSPanel = AxSSPanel1;
		Point location = new Point(12, 3);
		((Control)axSSPanel).set_Location(location);
		((Control)AxSSPanel1).set_Name("AxSSPanel1");
		((AxHost)AxSSPanel1).set_OcxState((State)componentResourceManager.GetObject("AxSSPanel1.OcxState"));
		AxSSPanel axSSPanel2 = AxSSPanel1;
		Size size = new Size(510, 38);
		((Control)axSSPanel2).set_Size(size);
		((Control)AxSSPanel1).set_TabIndex(127);
		TextBox obj = txtAcname;
		location = new Point(256, 12);
		((Control)obj).set_Location(location);
		((Control)txtAcname).set_Name("txtAcname");
		TextBox obj2 = txtAcname;
		size = new Size(256, 20);
		((Control)obj2).set_Size(size);
		((Control)txtAcname).set_TabIndex(129);
		TextBox obj3 = txtAcref;
		location = new Point(137, 12);
		((Control)obj3).set_Location(location);
		((Control)txtAcref).set_Name("txtAcref");
		TextBox obj4 = txtAcref;
		size = new Size(113, 20);
		((Control)obj4).set_Size(size);
		((Control)txtAcref).set_TabIndex(1);
		Label3.set_AutoSize(true);
		Label label = Label3;
		location = new Point(28, 15);
		((Control)label).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label2 = Label3;
		size = new Size(65, 13);
		((Control)label2).set_Size(size);
		((Control)Label3).set_TabIndex(131);
		Label3.set_Text("Company ID");
		TextBox txtEmployeeID = TxtEmployeeID;
		location = new Point(134, 55);
		((Control)txtEmployeeID).set_Location(location);
		((Control)TxtEmployeeID).set_Name("TxtEmployeeID");
		TextBox txtEmployeeID2 = TxtEmployeeID;
		size = new Size(81, 20);
		((Control)txtEmployeeID2).set_Size(size);
		((Control)TxtEmployeeID).set_TabIndex(2);
		Label1.set_AutoSize(true);
		Label label3 = Label1;
		location = new Point(25, 55);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(67, 13);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(133);
		Label1.set_Text("Employee ID");
		TextBox txtFname = TxtFname;
		location = new Point(134, 78);
		((Control)txtFname).set_Location(location);
		((Control)TxtFname).set_Name("TxtFname");
		TextBox txtFname2 = TxtFname;
		size = new Size(138, 20);
		((Control)txtFname2).set_Size(size);
		((Control)TxtFname).set_TabIndex(3);
		Label2.set_AutoSize(true);
		Label label5 = Label2;
		location = new Point(25, 81);
		((Control)label5).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label6 = Label2;
		size = new Size(57, 13);
		((Control)label6).set_Size(size);
		((Control)Label2).set_TabIndex(135);
		Label2.set_Text("First Name");
		TextBox txtLname = TxtLname;
		location = new Point(134, 102);
		((Control)txtLname).set_Location(location);
		((Control)TxtLname).set_Name("TxtLname");
		TextBox txtLname2 = TxtLname;
		size = new Size(138, 20);
		((Control)txtLname2).set_Size(size);
		((Control)TxtLname).set_TabIndex(4);
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(25, 105);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(58, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(137);
		Label4.set_Text("Last Name");
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(322, 106);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(66, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(139);
		Label5.set_Text("Date of Birth");
		Label6.set_AutoSize(true);
		Label label11 = Label6;
		location = new Point(322, 81);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(42, 13);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(141);
		Label6.set_Text("Gender");
		((ListControl)CmbEGender).set_FormattingEnabled(true);
		ComboBox cmbEGender = CmbEGender;
		location = new Point(394, 78);
		((Control)cmbEGender).set_Location(location);
		((Control)CmbEGender).set_Name("CmbEGender");
		ComboBox cmbEGender2 = CmbEGender;
		size = new Size(115, 21);
		((Control)cmbEGender2).set_Size(size);
		((Control)CmbEGender).set_TabIndex(5);
		DGVEmployee.set_BackgroundColor(SystemColors.ActiveCaptionText);
		DGVEmployee.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView dGVEmployee = DGVEmployee;
		location = new Point(16, 128);
		((Control)dGVEmployee).set_Location(location);
		DGVEmployee.set_MultiSelect(false);
		((Control)DGVEmployee).set_Name("DGVEmployee");
		DataGridView dGVEmployee2 = DGVEmployee;
		size = new Size(496, 94);
		((Control)dGVEmployee2).set_Size(size);
		((Control)DGVEmployee).set_TabIndex(7);
		((ListControl)CmbDGender).set_FormattingEnabled(true);
		ComboBox cmbDGender = CmbDGender;
		location = new Point(391, 323);
		((Control)cmbDGender).set_Location(location);
		((Control)CmbDGender).set_Name("CmbDGender");
		ComboBox cmbDGender2 = CmbDGender;
		size = new Size(118, 21);
		((Control)cmbDGender2).set_Size(size);
		((Control)CmbDGender).set_TabIndex(12);
		Label7.set_AutoSize(true);
		Label label13 = Label7;
		location = new Point(322, 331);
		((Control)label13).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label14 = Label7;
		size = new Size(42, 13);
		((Control)label14).set_Size(size);
		((Control)Label7).set_TabIndex(152);
		Label7.set_Text("Gender");
		Label8.set_AutoSize(true);
		Label label15 = Label8;
		location = new Point(322, 351);
		((Control)label15).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label16 = Label8;
		size = new Size(66, 13);
		((Control)label16).set_Size(size);
		((Control)Label8).set_TabIndex(151);
		Label8.set_Text("Date of Birth");
		TextBox obj5 = txtDLname;
		location = new Point(137, 323);
		((Control)obj5).set_Location(location);
		((Control)txtDLname).set_Name("txtDLname");
		TextBox obj6 = txtDLname;
		size = new Size(135, 20);
		((Control)obj6).set_Size(size);
		((Control)txtDLname).set_TabIndex(10);
		Label9.set_AutoSize(true);
		Label label17 = Label9;
		location = new Point(28, 325);
		((Control)label17).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label18 = Label9;
		size = new Size(58, 13);
		((Control)label18).set_Size(size);
		((Control)Label9).set_TabIndex(150);
		Label9.set_Text("Last Name");
		TextBox txtDFname = TxtDFname;
		location = new Point(137, 298);
		((Control)txtDFname).set_Location(location);
		((Control)TxtDFname).set_Name("TxtDFname");
		TextBox txtDFname2 = TxtDFname;
		size = new Size(135, 20);
		((Control)txtDFname2).set_Size(size);
		((Control)TxtDFname).set_TabIndex(9);
		Label10.set_AutoSize(true);
		Label label19 = Label10;
		location = new Point(28, 298);
		((Control)label19).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label20 = Label10;
		size = new Size(57, 13);
		((Control)label20).set_Size(size);
		((Control)Label10).set_TabIndex(148);
		Label10.set_Text("First Name");
		TextBox txtDependantID = TxtDependantID;
		location = new Point(137, 275);
		((Control)txtDependantID).set_Location(location);
		((Control)TxtDependantID).set_Name("TxtDependantID");
		TextBox txtDependantID2 = TxtDependantID;
		size = new Size(81, 20);
		((Control)txtDependantID2).set_Size(size);
		((Control)TxtDependantID).set_TabIndex(8);
		Label11.set_AutoSize(true);
		Label label21 = Label11;
		location = new Point(28, 272);
		((Control)label21).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label22 = Label11;
		size = new Size(74, 13);
		((Control)label22).set_Size(size);
		((Control)Label11).set_TabIndex(146);
		Label11.set_Text("Dependant ID");
		TextBox obj7 = txtRelationship;
		location = new Point(137, 347);
		((Control)obj7).set_Location(location);
		((Control)txtRelationship).set_Name("txtRelationship");
		TextBox obj8 = txtRelationship;
		size = new Size(135, 20);
		((Control)obj8).set_Size(size);
		((Control)txtRelationship).set_TabIndex(11);
		Label12.set_AutoSize(true);
		Label label23 = Label12;
		location = new Point(25, 354);
		((Control)label23).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label24 = Label12;
		size = new Size(65, 13);
		((Control)label24).set_Size(size);
		((Control)Label12).set_TabIndex(156);
		Label12.set_Text("Relationship");
		DGVDependantw2.set_BackgroundColor(SystemColors.ActiveCaptionText);
		DGVDependantw2.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DGVDependantw2.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)DependantID,
			(DataGridViewColumn)DFirstname,
			(DataGridViewColumn)Dlastname,
			(DataGridViewColumn)DGender,
			(DataGridViewColumn)dDOB,
			(DataGridViewColumn)Relationshif
		});
		DataGridView dGVDependantw = DGVDependantw2;
		location = new Point(28, 373);
		((Control)dGVDependantw).set_Location(location);
		((Control)DGVDependantw2).set_Name("DGVDependantw2");
		DataGridView dGVDependantw2 = DGVDependantw2;
		size = new Size(484, 94);
		((Control)dGVDependantw2).set_Size(size);
		((Control)DGVDependantw2).set_TabIndex(14);
		((DataGridViewColumn)DependantID).set_HeaderText("Dependant ID");
		((DataGridViewColumn)DependantID).set_Name("DependantID");
		((DataGridViewColumn)DFirstname).set_HeaderText("First Name");
		((DataGridViewColumn)DFirstname).set_Name("DFirstname");
		((DataGridViewColumn)Dlastname).set_HeaderText("Last Name");
		((DataGridViewColumn)Dlastname).set_Name("Dlastname");
		((DataGridViewColumn)DGender).set_HeaderText("Gender");
		((DataGridViewColumn)DGender).set_Name("DGender");
		((DataGridViewColumn)DGender).set_Width(50);
		((DataGridViewColumn)dDOB).set_HeaderText("D.O.B");
		((DataGridViewColumn)dDOB).set_Name("dDOB");
		((DataGridViewColumn)dDOB).set_Width(80);
		((DataGridViewColumn)Relationshif).set_HeaderText("Relationship");
		((DataGridViewColumn)Relationshif).set_Name("Relationshif");
		((DataGridViewColumn)Relationshif).set_Width(80);
		AxSSPanel axSSPanel3 = AxSSPanel2;
		location = new Point(12, 265);
		((Control)axSSPanel3).set_Location(location);
		((Control)AxSSPanel2).set_Name("AxSSPanel2");
		((AxHost)AxSSPanel2).set_OcxState((State)componentResourceManager.GetObject("AxSSPanel2.OcxState"));
		AxSSPanel axSSPanel4 = AxSSPanel2;
		size = new Size(510, 238);
		((Control)axSSPanel4).set_Size(size);
		((Control)AxSSPanel2).set_TabIndex(158);
		AxSSPanel axSSPanel5 = AxSSPanel3;
		location = new Point(11, 47);
		((Control)axSSPanel5).set_Location(location);
		((Control)AxSSPanel3).set_Name("AxSSPanel3");
		((AxHost)AxSSPanel3).set_OcxState((State)componentResourceManager.GetObject("AxSSPanel3.OcxState"));
		AxSSPanel axSSPanel6 = AxSSPanel3;
		size = new Size(511, 215);
		((Control)axSSPanel6).set_Size(size);
		((Control)AxSSPanel3).set_TabIndex(159);
		AxSSCommand cmdEnew = CmdEnew;
		location = new Point(28, 228);
		((Control)cmdEnew).set_Location(location);
		((Control)CmdEnew).set_Name("CmdEnew");
		((AxHost)CmdEnew).set_OcxState((State)componentResourceManager.GetObject("CmdEnew.OcxState"));
		AxSSCommand cmdEnew2 = CmdEnew;
		size = new Size(51, 20);
		((Control)cmdEnew2).set_Size(size);
		((Control)CmdEnew).set_TabIndex(7);
		AxSSCommand cmdEdelete = CmdEdelete;
		location = new Point(142, 228);
		((Control)cmdEdelete).set_Location(location);
		((Control)CmdEdelete).set_Name("CmdEdelete");
		((AxHost)CmdEdelete).set_OcxState((State)componentResourceManager.GetObject("CmdEdelete.OcxState"));
		AxSSCommand cmdEdelete2 = CmdEdelete;
		size = new Size(51, 20);
		((Control)cmdEdelete2).set_Size(size);
		((Control)CmdEdelete).set_TabIndex(162);
		AxSSCommand cmdEedit = CmdEedit;
		location = new Point(85, 228);
		((Control)cmdEedit).set_Location(location);
		((Control)CmdEedit).set_Name("CmdEedit");
		((AxHost)CmdEedit).set_OcxState((State)componentResourceManager.GetObject("CmdEedit.OcxState"));
		AxSSCommand cmdEedit2 = CmdEedit;
		size = new Size(51, 20);
		((Control)cmdEedit2).set_Size(size);
		((Control)CmdEedit).set_TabIndex(163);
		AxSSCommand cmdDedit = CmdDedit;
		location = new Point(85, 473);
		((Control)cmdDedit).set_Location(location);
		((Control)CmdDedit).set_Name("CmdDedit");
		((AxHost)CmdDedit).set_OcxState((State)componentResourceManager.GetObject("CmdDedit.OcxState"));
		AxSSCommand cmdDedit2 = CmdDedit;
		size = new Size(51, 20);
		((Control)cmdDedit2).set_Size(size);
		((Control)CmdDedit).set_TabIndex(166);
		AxSSCommand cmdDdelete = CmdDdelete;
		location = new Point(142, 473);
		((Control)cmdDdelete).set_Location(location);
		((Control)CmdDdelete).set_Name("CmdDdelete");
		((AxHost)CmdDdelete).set_OcxState((State)componentResourceManager.GetObject("CmdDdelete.OcxState"));
		AxSSCommand cmdDdelete2 = CmdDdelete;
		size = new Size(51, 20);
		((Control)cmdDdelete2).set_Size(size);
		((Control)CmdDdelete).set_TabIndex(165);
		AxSSCommand cmdDnew = CmdDnew;
		location = new Point(28, 473);
		((Control)cmdDnew).set_Location(location);
		((Control)CmdDnew).set_Name("CmdDnew");
		((AxHost)CmdDnew).set_OcxState((State)componentResourceManager.GetObject("CmdDnew.OcxState"));
		AxSSCommand cmdDnew2 = CmdDnew;
		size = new Size(51, 20);
		((Control)cmdDnew2).set_Size(size);
		((Control)CmdDnew).set_TabIndex(14);
		AxSSCommand obj9 = cmdClose;
		location = new Point(461, 512);
		((Control)obj9).set_Location(location);
		((Control)cmdClose).set_Name("cmdClose");
		((AxHost)cmdClose).set_OcxState((State)componentResourceManager.GetObject("cmdClose.OcxState"));
		AxSSCommand obj10 = cmdClose;
		size = new Size(61, 24);
		((Control)obj10).set_Size(size);
		((Control)cmdClose).set_TabIndex(171);
		AxSSCommand obj11 = cmdPrint;
		location = new Point(308, 512);
		((Control)obj11).set_Location(location);
		((Control)cmdPrint).set_Name("cmdPrint");
		((AxHost)cmdPrint).set_OcxState((State)componentResourceManager.GetObject("cmdPrint.OcxState"));
		AxSSCommand obj12 = cmdPrint;
		size = new Size(61, 24);
		((Control)obj12).set_Size(size);
		((Control)cmdPrint).set_TabIndex(170);
		AxSSCommand obj13 = cmdLast;
		location = new Point(232, 512);
		((Control)obj13).set_Location(location);
		((Control)cmdLast).set_Name("cmdLast");
		((AxHost)cmdLast).set_OcxState((State)componentResourceManager.GetObject("cmdLast.OcxState"));
		AxSSCommand obj14 = cmdLast;
		size = new Size(61, 24);
		((Control)obj14).set_Size(size);
		((Control)cmdLast).set_TabIndex(175);
		AxSSCommand obj15 = cmdNext;
		location = new Point(159, 512);
		((Control)obj15).set_Location(location);
		((Control)cmdNext).set_Name("cmdNext");
		((AxHost)cmdNext).set_OcxState((State)componentResourceManager.GetObject("cmdNext.OcxState"));
		AxSSCommand obj16 = cmdNext;
		size = new Size(61, 24);
		((Control)obj16).set_Size(size);
		((Control)cmdNext).set_TabIndex(174);
		AxSSCommand obj17 = cmdPrevious;
		location = new Point(85, 512);
		((Control)obj17).set_Location(location);
		((Control)cmdPrevious).set_Name("cmdPrevious");
		((AxHost)cmdPrevious).set_OcxState((State)componentResourceManager.GetObject("cmdPrevious.OcxState"));
		AxSSCommand obj18 = cmdPrevious;
		size = new Size(61, 24);
		((Control)obj18).set_Size(size);
		((Control)cmdPrevious).set_TabIndex(173);
		AxSSCommand obj19 = cmdFirst;
		location = new Point(11, 512);
		((Control)obj19).set_Location(location);
		((Control)cmdFirst).set_Name("cmdFirst");
		((AxHost)cmdFirst).set_OcxState((State)componentResourceManager.GetObject("cmdFirst.OcxState"));
		AxSSCommand obj20 = cmdFirst;
		size = new Size(61, 24);
		((Control)obj20).set_Size(size);
		((Control)cmdFirst).set_TabIndex(172);
		DTPEDOB.set_Format((DateTimePickerFormat)2);
		DateTimePicker dTPEDOB = DTPEDOB;
		location = new Point(394, 102);
		((Control)dTPEDOB).set_Location(location);
		DateTimePicker dTPEDOB2 = DTPEDOB;
		DateTime minDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
		dTPEDOB2.set_MinDate(minDate);
		((Control)DTPEDOB).set_Name("DTPEDOB");
		DateTimePicker dTPEDOB3 = DTPEDOB;
		size = new Size(115, 20);
		((Control)dTPEDOB3).set_Size(size);
		((Control)DTPEDOB).set_TabIndex(6);
		DateTimePicker dTPEDOB4 = DTPEDOB;
		minDate = new DateTime(1975, 1, 1, 0, 0, 0, 0);
		dTPEDOB4.set_Value(minDate);
		DTPDDOB.set_Format((DateTimePickerFormat)2);
		DateTimePicker dTPDDOB = DTPDDOB;
		location = new Point(391, 347);
		((Control)dTPDDOB).set_Location(location);
		((Control)DTPDDOB).set_Name("DTPDDOB");
		DateTimePicker dTPDDOB2 = DTPDDOB;
		size = new Size(118, 20);
		((Control)dTPDDOB2).set_Size(size);
		((Control)DTPDDOB).set_TabIndex(13);
		DateTimePicker dTPDDOB3 = DTPDDOB;
		minDate = new DateTime(1975, 1, 1, 0, 0, 0, 0);
		dTPDDOB3.set_Value(minDate);
		TextBox obj21 = txtEgender;
		location = new Point(394, 78);
		((Control)obj21).set_Location(location);
		((Control)txtEgender).set_Name("txtEgender");
		TextBox obj22 = txtEgender;
		size = new Size(115, 20);
		((Control)obj22).set_Size(size);
		((Control)txtEgender).set_TabIndex(176);
		TextBox obj23 = txtEdob;
		location = new Point(394, 102);
		((Control)obj23).set_Location(location);
		((Control)txtEdob).set_Name("txtEdob");
		TextBox obj24 = txtEdob;
		size = new Size(115, 20);
		((Control)obj24).set_Size(size);
		((Control)txtEdob).set_TabIndex(177);
		TextBox obj25 = txtDDOB;
		location = new Point(391, 347);
		((Control)obj25).set_Location(location);
		((Control)txtDDOB).set_Name("txtDDOB");
		TextBox obj26 = txtDDOB;
		size = new Size(118, 20);
		((Control)obj26).set_Size(size);
		((Control)txtDDOB).set_TabIndex(179);
		TextBox obj27 = txtDgender;
		location = new Point(391, 324);
		((Control)obj27).set_Location(location);
		((Control)txtDgender).set_Name("txtDgender");
		TextBox obj28 = txtDgender;
		size = new Size(118, 20);
		((Control)obj28).set_Size(size);
		((Control)txtDgender).set_TabIndex(178);
		Button button = Button1;
		location = new Point(256, 224);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(180);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		size = new Size(534, 548);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)txtDDOB);
		((Control)this).get_Controls().Add((Control)(object)txtDgender);
		((Control)this).get_Controls().Add((Control)(object)txtEdob);
		((Control)this).get_Controls().Add((Control)(object)txtEgender);
		((Control)this).get_Controls().Add((Control)(object)DTPDDOB);
		((Control)this).get_Controls().Add((Control)(object)DTPEDOB);
		((Control)this).get_Controls().Add((Control)(object)cmdLast);
		((Control)this).get_Controls().Add((Control)(object)cmdNext);
		((Control)this).get_Controls().Add((Control)(object)cmdPrevious);
		((Control)this).get_Controls().Add((Control)(object)cmdFirst);
		((Control)this).get_Controls().Add((Control)(object)cmdClose);
		((Control)this).get_Controls().Add((Control)(object)cmdPrint);
		((Control)this).get_Controls().Add((Control)(object)CmdDedit);
		((Control)this).get_Controls().Add((Control)(object)CmdDdelete);
		((Control)this).get_Controls().Add((Control)(object)CmdDnew);
		((Control)this).get_Controls().Add((Control)(object)CmdEedit);
		((Control)this).get_Controls().Add((Control)(object)CmdEdelete);
		((Control)this).get_Controls().Add((Control)(object)CmdEnew);
		((Control)this).get_Controls().Add((Control)(object)DGVDependantw2);
		((Control)this).get_Controls().Add((Control)(object)txtRelationship);
		((Control)this).get_Controls().Add((Control)(object)Label12);
		((Control)this).get_Controls().Add((Control)(object)CmbDGender);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)txtDLname);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)TxtDFname);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)TxtDependantID);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)DGVEmployee);
		((Control)this).get_Controls().Add((Control)(object)CmbEGender);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)TxtLname);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)TxtFname);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)TxtEmployeeID);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtAcname);
		((Control)this).get_Controls().Add((Control)(object)txtAcref);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)AxSSPanel1);
		((Control)this).get_Controls().Add((Control)(object)AxSSPanel3);
		((Control)this).get_Controls().Add((Control)(object)AxSSPanel2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmEmployee");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Company Employee");
		((ISupportInitialize)AxSSPanel1).EndInit();
		((ISupportInitialize)DGVEmployee).EndInit();
		((ISupportInitialize)DGVDependantw2).EndInit();
		((ISupportInitialize)AxSSPanel2).EndInit();
		((ISupportInitialize)AxSSPanel3).EndInit();
		((ISupportInitialize)CmdEnew).EndInit();
		((ISupportInitialize)CmdEdelete).EndInit();
		((ISupportInitialize)CmdEedit).EndInit();
		((ISupportInitialize)CmdDedit).EndInit();
		((ISupportInitialize)CmdDdelete).EndInit();
		((ISupportInitialize)CmdDnew).EndInit();
		((ISupportInitialize)cmdClose).EndInit();
		((ISupportInitialize)cmdPrint).EndInit();
		((ISupportInitialize)cmdLast).EndInit();
		((ISupportInitialize)cmdNext).EndInit();
		((ISupportInitialize)cmdPrevious).EndInit();
		((ISupportInitialize)cmdFirst).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmEmployee_Load(object sender, EventArgs e)
	{
		objcustomer = new Ccustomer();
		objEmployee = new CEmployee();
		objdependant = new Cdependant();
		dsgroup = new DataSet();
		objcustomer.Initialise(Startup.dBcon);
		DTPEDOB.set_Format((DateTimePickerFormat)2);
		DTPDDOB.set_Format((DateTimePickerFormat)2);
		GetGenderItems();
		viewEmode();
		viewDmode();
		Refreshdata();
	}

	private void GetGenderItems()
	{
		CmbEGender.get_Items().Clear();
		CmbEGender.get_Items().Add((object)"Male");
		CmbEGender.get_Items().Add((object)"Female");
		CmbDGender.get_Items().Clear();
		CmbDGender.get_Items().Add((object)"Male");
		CmbDGender.get_Items().Add((object)"Female");
	}

	private void ClearEData()
	{
		TxtEmployeeID.set_Text("");
		TxtFname.set_Text("");
		TxtLname.set_Text("");
		CmbEGender.set_Text("");
		DTPEDOB.set_Value(DateTime.Now);
	}

	private void ClearDData()
	{
		TxtDependantID.set_Text("");
		TxtDFname.set_Text("");
		txtDLname.set_Text("");
		CmbDGender.set_Text("");
		DTPDDOB.set_Value(DateTime.Now);
	}

	private void editEmode()
	{
		((TextBoxBase)TxtEmployeeID).set_ReadOnly(false);
		((TextBoxBase)TxtFname).set_ReadOnly(false);
		((TextBoxBase)TxtLname).set_ReadOnly(false);
		((Control)DTPEDOB).set_Visible(true);
		((Control)txtEdob).set_Visible(false);
		((Control)CmbEGender).set_Visible(true);
		((Control)txtEgender).set_Visible(false);
		CmdEnew.set_Enabled(true);
		CmdEnew.set_Caption("&Save");
		CmdEedit.set_Caption("&Cancel");
		CmdEedit.set_Enabled(true);
		CmdEdelete.set_Enabled(false);
	}

	private void viewEmode()
	{
		((TextBoxBase)TxtEmployeeID).set_ReadOnly(true);
		((TextBoxBase)TxtFname).set_ReadOnly(true);
		((TextBoxBase)TxtLname).set_ReadOnly(true);
		((Control)DTPEDOB).set_Visible(false);
		((Control)txtEdob).set_Visible(true);
		((Control)CmbEGender).set_Visible(false);
		((Control)txtEgender).set_Visible(true);
		((TextBoxBase)txtEgender).set_ReadOnly(true);
		((TextBoxBase)txtEdob).set_ReadOnly(true);
		((TextBoxBase)TxtEmployeeID).set_BackColor(Color.White);
		((TextBoxBase)TxtFname).set_BackColor(Color.White);
		((TextBoxBase)TxtLname).set_BackColor(Color.White);
		((TextBoxBase)txtEgender).set_BackColor(Color.White);
		((TextBoxBase)txtEdob).set_BackColor(Color.White);
		CmdEnew.set_Enabled(true);
		CmdEnew.set_Caption("&New");
		CmdEedit.set_Caption("&Edit");
		CmdEedit.set_Enabled(true);
		CmdEdelete.set_Enabled(true);
	}

	private void editDmode()
	{
		((TextBoxBase)TxtDependantID).set_ReadOnly(false);
		((TextBoxBase)TxtDFname).set_ReadOnly(false);
		((TextBoxBase)txtDLname).set_ReadOnly(false);
		((Control)DTPDDOB).set_Visible(true);
		((Control)CmbDGender).set_Visible(true);
		((Control)txtDDOB).set_Visible(false);
		((Control)txtDgender).set_Visible(false);
		CmdDnew.set_Enabled(true);
		CmdDnew.set_Caption("&Save");
		CmdDedit.set_Caption("&Cancel");
		CmdDedit.set_Enabled(true);
		CmdDdelete.set_Enabled(false);
	}

	private void viewDmode()
	{
		((TextBoxBase)TxtDependantID).set_ReadOnly(true);
		((TextBoxBase)TxtDFname).set_ReadOnly(true);
		((TextBoxBase)txtDLname).set_ReadOnly(true);
		((Control)DTPDDOB).set_Visible(false);
		((Control)CmbDGender).set_Visible(false);
		((Control)txtDDOB).set_Visible(true);
		((Control)txtDgender).set_Visible(true);
		((TextBoxBase)TxtDependantID).set_BackColor(Color.White);
		((TextBoxBase)TxtDFname).set_BackColor(Color.White);
		((TextBoxBase)txtDLname).set_BackColor(Color.White);
		CmdDnew.set_Enabled(true);
		CmdDnew.set_Caption("&New");
		CmdDedit.set_Caption("&Edit");
		CmdDedit.set_Enabled(true);
		CmdDdelete.set_Enabled(true);
	}

	private void Refreshdata()
	{
		txtAcref.set_Text(Conversions.ToString(objcustomer.CustomerID));
		txtAcname.set_Text(Conversions.ToString(objcustomer.CustomerName));
	}

	private void GetEmployees()
	{
		if (Operators.CompareString(txtAcref.get_Text(), "", false) == 0)
		{
			return;
		}
		objEmployee.Initialise(Startup.dBcon, txtAcref.get_Text());
		if (Operators.ConditionalCompareObjectNotEqual(objEmployee.RecordCount, (object)0, false))
		{
			TxtEmployeeID.set_Text(Conversions.ToString(objEmployee.EmployeeID));
			TxtFname.set_Text(Conversions.ToString(objEmployee.Fname));
			TxtLname.set_Text(Conversions.ToString(objEmployee.Lname));
			txtEdob.set_Text(Conversions.ToString(objEmployee.DOB));
			txtEgender.set_Text(Conversions.ToString(objEmployee.Sex));
			if (Operators.CompareString(TxtEmployeeID.get_Text(), "", false) != 0)
			{
				GetDependants();
			}
			viewEmode();
			GetEmployeeList();
		}
		else
		{
			GetEmployeeList();
			objEmployee_NoRecords();
		}
	}

	private void GetEmployeeList()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		StrEmployee = "select Employeeid  as [Employee ID], fname as [First Name],  lname as [Last Name], Sex as Gender, Dob as DOB from Employee  Where Acref = '" + txtAcref.get_Text() + "' order by acref, employeeid";
		dsEmployee = new DataSet();
		daEmployee = new SqlDataAdapter(StrEmployee, Startup.dBcon);
		((DbDataAdapter)(object)daEmployee).FillSchema(dsEmployee, SchemaType.Mapped, "Employee");
		((DbDataAdapter)(object)daEmployee).Fill(dsEmployee, "Employee");
		if (dsEmployee != null && dsEmployee.Tables["employee"]!.Rows.Count != 0)
		{
			DGVEmployee.set_DataSource((object)dsEmployee);
			DGVEmployee.set_DataMember("Employee");
			DGVEmployee.get_Columns().get_Item(0).set_Width(100);
			DGVEmployee.get_Columns().get_Item(1).set_Width(110);
			DGVEmployee.get_Columns().get_Item(2).set_Width(110);
			DGVEmployee.get_Columns().get_Item(3).set_Width(50);
			DGVEmployee.get_Columns().get_Item(4).set_Width(80);
		}
		dsEmployee = null;
	}

	private void GetDependants()
	{
	}

	private void objEmployee_DataValidated(bool blnIsValid)
	{
		CmdEnew.set_Enabled(blnIsValid);
	}

	private void objEmployee_NoRecords()
	{
		CmdEnew.set_Caption("&New");
		CmdEnew.set_Enabled(true);
		CmdEdelete.set_Enabled(false);
		CmdEedit.set_Enabled(false);
		TxtEmployeeID.set_Text("");
		TxtFname.set_Text("");
		TxtLname.set_Text("");
		txtEdob.set_Text("");
		txtEgender.set_Text("");
	}

	private void objEmployee_RecordExits()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"Employee ID Already Exits.\r\nPlease Enter A Unique ID\r\nTo Continue", (MsgBoxStyle)69, (object)"Information");
		if (msgAns == 4L)
		{
			((Control)TxtEmployeeID).Focus();
			TxtEmployeeID.set_Text("");
		}
		else
		{
			CmdEedit.DoClick();
		}
	}

	private void cmdFirst_ClickEvent(object sender, EventArgs e)
	{
		objcustomer.MoveFirst();
		Refreshdata();
	}

	private void cmdFirst_Enter(object sender, EventArgs e)
	{
	}

	private void cmdnew_Enter(object sender, EventArgs e)
	{
	}

	private void cmdEdit_Enter(object sender, EventArgs e)
	{
	}

	private void cmdDelete_ClickEvent(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"You are about to delete this record.\r\nDo you want to proceed?", (MsgBoxStyle)68, (object)"Information");
		if (msgAns == 6L)
		{
			objEmployee.Delete(TxtEmployeeID.get_Text());
			Refreshdata();
		}
	}

	private void cmdDelete_Enter(object sender, EventArgs e)
	{
	}

	private void cmdClose_ClickEvent(object sender, EventArgs e)
	{
		((Form)this).Close();
		objEmployee = null;
	}

	private void cmdClose_Enter(object sender, EventArgs e)
	{
	}

	private void txtAcref_TextChanged(object sender, EventArgs e)
	{
		objEmployee.Acref = txtAcref.get_Text();
		GetEmployees();
	}

	private void ValidateNow()
	{
		if (Operators.CompareString(CmdEnew.get_Caption(), "&Save", false) == 0)
		{
			objEmployee.IsValid();
		}
	}

	private void TxtEmployeeID_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(CmdEnew.get_Caption(), "&Save", false) == 0)
		{
			objEmployee.EmployeeID = TxtEmployeeID.get_Text();
			ValidateNow();
		}
	}

	private void TxtFname_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(CmdEnew.get_Caption(), "&Save", false) == 0)
		{
			objEmployee.Fname = TxtFname.get_Text();
			ValidateNow();
		}
	}

	private void TxtLname_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(CmdEnew.get_Caption(), "&Save", false) == 0)
		{
			objEmployee.Lname = TxtLname.get_Text();
			ValidateNow();
		}
	}

	private void txtDOB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
	{
	}

	private void CmbGender_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void CmbGender_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(CmdEnew.get_Caption(), "&Save", false) == 0)
		{
			objEmployee.Sex = CmbEGender.get_Text();
			ValidateNow();
		}
	}

	private void DTPDDOB_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(CmdDnew.get_Caption(), "&Save", false) == 0)
		{
			objdependant.DOB = DTPDDOB.get_Text();
		}
	}

	private void DTPDDOB_ValueChanged(object sender, EventArgs e)
	{
	}

	private void DTPEDOB_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(CmdEnew.get_Caption(), "&Save", false) == 0)
		{
			objEmployee.DOB = DTPEDOB.get_Text();
			ValidateNow();
		}
	}

	private void DTPEDOB_ValueChanged(object sender, EventArgs e)
	{
	}

	private void objcustomer_MoveBackward(bool blnMoveBack)
	{
		cmdPrevious.set_Enabled(blnMoveBack);
		cmdFirst.set_Enabled(blnMoveBack);
	}

	private void objcustomer_MoveForward(bool blnMoveForward)
	{
		cmdNext.set_Enabled(blnMoveForward);
		cmdLast.set_Enabled(blnMoveForward);
	}

	private void objcustomer_NoRecords()
	{
		ClearEData();
		ClearDData();
	}

	private void cmdPrevious_ClickEvent(object sender, EventArgs e)
	{
		objcustomer.MovePrevious();
		Refreshdata();
	}

	private void cmdPrevious_Enter(object sender, EventArgs e)
	{
	}

	private void cmdNext_ClickEvent(object sender, EventArgs e)
	{
		objcustomer.MoveNext();
		Refreshdata();
	}

	private void cmdNext_Enter(object sender, EventArgs e)
	{
	}

	private void cmdLast_ClickEvent(object sender, EventArgs e)
	{
		objcustomer.MoveLast();
		Refreshdata();
	}

	private void cmdLast_Enter(object sender, EventArgs e)
	{
	}

	private void CmdEnew_ClickEvent(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(CmdEnew.get_Caption(), "&New", false) == 0)
		{
			IsnewERecord = true;
			ClearEData();
			editEmode();
			((Control)TxtEmployeeID).Focus();
			CmdEnew.set_Enabled(false);
		}
		else
		{
			objEmployee.Save(IsnewERecord);
			Interaction.MsgBox((object)"Employee Record\r\nSuccessfully Saved", (MsgBoxStyle)64, (object)"information");
			viewEmode();
			RefreshEdata();
		}
	}

	private void RefreshEdata()
	{
		if (Operators.ConditionalCompareObjectEqual(objEmployee.RecordCount, (object)0, false))
		{
			objEmployee_NoRecords();
		}
		else
		{
			viewEmode();
		}
		TxtEmployeeID.set_Text(Conversions.ToString(objEmployee.EmployeeID));
		TxtFname.set_Text(Conversions.ToString(objEmployee.Fname));
		TxtLname.set_Text(Conversions.ToString(objEmployee.Lname));
		txtEdob.set_Text(Conversions.ToString(objEmployee.DOB));
		txtEgender.set_Text(Conversions.ToString(objEmployee.Sex));
	}

	private void RefreshDdata()
	{
		TxtDependantID.set_Text(Conversions.ToString(objdependant.DependantID));
		TxtDFname.set_Text(Conversions.ToString(objdependant.Fname));
		txtDLname.set_Text(Conversions.ToString(objdependant.Lname));
		txtDDOB.set_Text(Conversions.ToString(objdependant.DOB));
		txtDgender.set_Text(Conversions.ToString(objdependant.Sex));
		txtRelationship.set_Text(Conversions.ToString(objdependant.Relationship));
	}

	private void CmdEnew_Enter(object sender, EventArgs e)
	{
	}

	private void CmdEdelete_ClickEvent(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"You are about to delete this record.\r\nDo you want to proceed?", (MsgBoxStyle)68, (object)"Information");
		if (msgAns == 6L)
		{
			objEmployee.Delete(TxtEmployeeID.get_Text());
			Refreshdata();
		}
	}

	private void CmdEdelete_Enter(object sender, EventArgs e)
	{
	}

	private void CmdEedit_ClickEvent(object sender, EventArgs e)
	{
		if (Operators.CompareString(CmdEedit.get_Caption(), "&Edit", false) == 0)
		{
			IsnewERecord = false;
			editEmode();
			((TextBoxBase)TxtEmployeeID).set_ReadOnly(true);
			((TextBoxBase)TxtEmployeeID).set_BackColor(Color.White);
			((Control)TxtFname).Focus();
		}
		else
		{
			objEmployee.Initialise(Startup.dBcon, txtAcref.get_Text());
			viewEmode();
			RefreshEdata();
		}
	}

	private void CmdEedit_Enter(object sender, EventArgs e)
	{
	}

	private void AxSSPanel2_Enter(object sender, EventArgs e)
	{
	}

	private void objdependant_DataValidated(bool blnIsValid)
	{
		CmdDnew.set_Enabled(true);
	}

	private void objdependant_NoRecords()
	{
		CmdDnew.set_Caption("&New");
		CmdDnew.set_Enabled(true);
		CmdDedit.set_Enabled(false);
		CmdDdelete.set_Enabled(false);
	}

	private void objdependant_RecordExits()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"Dependant ID Already Exits.\r\nPlease Enter A Unique ID\r\nTo Continue", (MsgBoxStyle)69, (object)"Information");
		if (msgAns == 4L)
		{
			((Control)TxtDependantID).Focus();
			TxtDependantID.set_Text("");
		}
		else
		{
			CmdEedit.DoClick();
		}
	}

	private void CmbEGender_TextChanged(object sender, EventArgs e)
	{
		objEmployee.Sex = CmbEGender.get_Text();
	}

	private void CmbDGender_TextChanged(object sender, EventArgs e)
	{
		objdependant.Sex = CmbDGender.get_Text();
	}

	private void DGVEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DGVEmployee_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DGVEmployee_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}
}

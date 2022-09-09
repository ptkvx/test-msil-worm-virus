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
public class frmCustomer : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

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

	[AccessedThroughProperty("txtContactPerson")]
	private TextBox _txtContactPerson;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("txtMobile")]
	private TextBox _txtMobile;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("txtCountry")]
	private TextBox _txtCountry;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("txtTown")]
	private TextBox _txtTown;

	[AccessedThroughProperty("txtAddress")]
	private TextBox _txtAddress;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("AxSSPanel1")]
	private AxSSPanel _AxSSPanel1;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("txtBalance")]
	private TextBox _txtBalance;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("txtLastDate")]
	private TextBox _txtLastDate;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("txtLastPayment")]
	private TextBox _txtLastPayment;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txtLastBill")]
	private TextBox _txtLastBill;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txtVATno")]
	private TextBox _txtVATno;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtCustomername")]
	private TextBox _txtCustomername;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("txtCustomerID")]
	private TextBox _txtCustomerID;

	[AccessedThroughProperty("txtTelephone")]
	private TextBox _txtTelephone;

	[AccessedThroughProperty("txtGroupname")]
	private TextBox _txtGroupname;

	[AccessedThroughProperty("cmdGroupId")]
	private AxSSCommand _cmdGroupId;

	[AccessedThroughProperty("txtGroupid")]
	private TextBox _txtGroupid;

	[AccessedThroughProperty("objCustomer")]
	private Ccustomer _objCustomer;

	private long msgAns;

	public bool IsnewRecord;

	private Control MyControl;

	private SqlDataAdapter dagroup;

	private DataSet dsgroup;

	private string StrSQL;

	private double isNum;

	private Form nform;

	private DataRow nrowgroup;

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
				_cmdLast.remove_ClickEvent((EventHandler)cmdLast_ClickEvent);
			}
			_cmdLast = value;
			if (_cmdLast != null)
			{
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
				_cmdNext.remove_ClickEvent((EventHandler)cmdNext_ClickEvent);
			}
			_cmdNext = value;
			if (_cmdNext != null)
			{
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
				_cmdPrevious.remove_ClickEvent((EventHandler)cmdPrevious_ClickEvent);
			}
			_cmdPrevious = value;
			if (_cmdPrevious != null)
			{
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
				_cmdFirst.remove_ClickEvent((EventHandler)cmdFirst_ClickEvent);
			}
			_cmdFirst = value;
			if (_cmdFirst != null)
			{
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
			}
			_cmdDelete = value;
			if (_cmdDelete != null)
			{
				((Control)_cmdDelete).add_Enter((EventHandler)cmdDelete_Enter);
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

	internal virtual TextBox txtContactPerson
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtContactPerson;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtContactPerson != null)
			{
				((Control)_txtContactPerson).remove_TextChanged((EventHandler)txtContactPerson_TextChanged);
				((Control)_txtContactPerson).remove_KeyDown(new KeyEventHandler(txtContactPerson_KeyDown));
				((Control)_txtContactPerson).remove_GotFocus((EventHandler)txtContactPerson_GotFocus);
			}
			_txtContactPerson = value;
			if (_txtContactPerson != null)
			{
				((Control)_txtContactPerson).add_TextChanged((EventHandler)txtContactPerson_TextChanged);
				((Control)_txtContactPerson).add_KeyDown(new KeyEventHandler(txtContactPerson_KeyDown));
				((Control)_txtContactPerson).add_GotFocus((EventHandler)txtContactPerson_GotFocus);
			}
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual TextBox txtMobile
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMobile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtMobile != null)
			{
				((Control)_txtMobile).remove_TextChanged((EventHandler)txtMobile_TextChanged);
				((Control)_txtMobile).remove_KeyDown(new KeyEventHandler(txtMobile_KeyDown));
			}
			_txtMobile = value;
			if (_txtMobile != null)
			{
				((Control)_txtMobile).add_TextChanged((EventHandler)txtMobile_TextChanged);
				((Control)_txtMobile).add_KeyDown(new KeyEventHandler(txtMobile_KeyDown));
			}
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

	internal virtual TextBox txtCountry
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCountry;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtCountry != null)
			{
				((Control)_txtCountry).remove_TextChanged((EventHandler)txtCountry_TextChanged);
				((Control)_txtCountry).remove_KeyDown(new KeyEventHandler(txtCountry_KeyDown));
				((Control)_txtCountry).remove_GotFocus((EventHandler)txtCountry_GotFocus);
			}
			_txtCountry = value;
			if (_txtCountry != null)
			{
				((Control)_txtCountry).add_TextChanged((EventHandler)txtCountry_TextChanged);
				((Control)_txtCountry).add_KeyDown(new KeyEventHandler(txtCountry_KeyDown));
				((Control)_txtCountry).add_GotFocus((EventHandler)txtCountry_GotFocus);
			}
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

	internal virtual TextBox txtTown
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtTown != null)
			{
				((Control)_txtTown).remove_TextChanged((EventHandler)txtTown_TextChanged);
				((Control)_txtTown).remove_KeyDown(new KeyEventHandler(txtTown_KeyDown));
				((Control)_txtTown).remove_GotFocus((EventHandler)txtTown_GotFocus);
			}
			_txtTown = value;
			if (_txtTown != null)
			{
				((Control)_txtTown).add_TextChanged((EventHandler)txtTown_TextChanged);
				((Control)_txtTown).add_KeyDown(new KeyEventHandler(txtTown_KeyDown));
				((Control)_txtTown).add_GotFocus((EventHandler)txtTown_GotFocus);
			}
		}
	}

	internal virtual TextBox txtAddress
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtAddress != null)
			{
				((Control)_txtAddress).remove_TextChanged((EventHandler)txtAddress_TextChanged);
				((Control)_txtAddress).remove_KeyDown(new KeyEventHandler(txtAddress_KeyDown));
			}
			_txtAddress = value;
			if (_txtAddress != null)
			{
				((Control)_txtAddress).add_TextChanged((EventHandler)txtAddress_TextChanged);
				((Control)_txtAddress).add_KeyDown(new KeyEventHandler(txtAddress_KeyDown));
			}
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
			if (_AxSSPanel1 != null)
			{
				((Control)_AxSSPanel1).remove_Enter((EventHandler)AxSSPanel1_Enter);
			}
			_AxSSPanel1 = value;
			if (_AxSSPanel1 != null)
			{
				((Control)_AxSSPanel1).add_Enter((EventHandler)AxSSPanel1_Enter);
			}
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual TextBox txtBalance
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtBalance;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtBalance != null)
			{
				((Control)_txtBalance).remove_TextChanged((EventHandler)txtBalance_TextChanged);
				((Control)_txtBalance).remove_KeyDown(new KeyEventHandler(txtBalance_KeyDown));
				((Control)_txtBalance).remove_GotFocus((EventHandler)txtBalance_GotFocus);
			}
			_txtBalance = value;
			if (_txtBalance != null)
			{
				((Control)_txtBalance).add_TextChanged((EventHandler)txtBalance_TextChanged);
				((Control)_txtBalance).add_KeyDown(new KeyEventHandler(txtBalance_KeyDown));
				((Control)_txtBalance).add_GotFocus((EventHandler)txtBalance_GotFocus);
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

	internal virtual TextBox txtLastDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLastDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			if (_txtLastDate != null)
			{
				((Control)_txtLastDate).remove_TextChanged((EventHandler)txtLastDate_TextChanged);
				((Control)_txtLastDate).remove_KeyDown(new KeyEventHandler(txtLastDate_KeyDown));
				((Control)_txtLastDate).remove_HelpRequested(new HelpEventHandler(txtLastDate_HelpRequested));
				((Control)_txtLastDate).remove_GotFocus((EventHandler)txtLastDate_GotFocus);
			}
			_txtLastDate = value;
			if (_txtLastDate != null)
			{
				((Control)_txtLastDate).add_TextChanged((EventHandler)txtLastDate_TextChanged);
				((Control)_txtLastDate).add_KeyDown(new KeyEventHandler(txtLastDate_KeyDown));
				((Control)_txtLastDate).add_HelpRequested(new HelpEventHandler(txtLastDate_HelpRequested));
				((Control)_txtLastDate).add_GotFocus((EventHandler)txtLastDate_GotFocus);
			}
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

	internal virtual TextBox txtLastPayment
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLastPayment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtLastPayment != null)
			{
				((Control)_txtLastPayment).remove_TextChanged((EventHandler)txtLastPayment_TextChanged);
				((Control)_txtLastPayment).remove_KeyDown(new KeyEventHandler(txtLastPayment_KeyDown));
				((Control)_txtLastPayment).remove_GotFocus((EventHandler)txtLastPayment_GotFocus);
			}
			_txtLastPayment = value;
			if (_txtLastPayment != null)
			{
				((Control)_txtLastPayment).add_TextChanged((EventHandler)txtLastPayment_TextChanged);
				((Control)_txtLastPayment).add_KeyDown(new KeyEventHandler(txtLastPayment_KeyDown));
				((Control)_txtLastPayment).add_GotFocus((EventHandler)txtLastPayment_GotFocus);
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

	internal virtual TextBox txtLastBill
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLastBill;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtLastBill != null)
			{
				((Control)_txtLastBill).remove_TextChanged((EventHandler)txtLastBill_TextChanged);
				((Control)_txtLastBill).remove_KeyDown(new KeyEventHandler(txtLastBill_KeyDown));
				((Control)_txtLastBill).remove_GotFocus((EventHandler)txtLastBill_GotFocus);
			}
			_txtLastBill = value;
			if (_txtLastBill != null)
			{
				((Control)_txtLastBill).add_TextChanged((EventHandler)txtLastBill_TextChanged);
				((Control)_txtLastBill).add_KeyDown(new KeyEventHandler(txtLastBill_KeyDown));
				((Control)_txtLastBill).add_GotFocus((EventHandler)txtLastBill_GotFocus);
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

	internal virtual TextBox txtVATno
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtVATno;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtVATno != null)
			{
				((Control)_txtVATno).remove_TextChanged((EventHandler)txtVATno_TextChanged);
				((Control)_txtVATno).remove_KeyDown(new KeyEventHandler(txtVATno_KeyDown));
				((Control)_txtVATno).remove_GotFocus((EventHandler)txtVATno_GotFocus);
			}
			_txtVATno = value;
			if (_txtVATno != null)
			{
				((Control)_txtVATno).add_TextChanged((EventHandler)txtVATno_TextChanged);
				((Control)_txtVATno).add_KeyDown(new KeyEventHandler(txtVATno_KeyDown));
				((Control)_txtVATno).add_GotFocus((EventHandler)txtVATno_GotFocus);
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

	internal virtual TextBox txtCustomername
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCustomername;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtCustomername != null)
			{
				((Control)_txtCustomername).remove_TextChanged((EventHandler)txtCustomername_TextChanged);
				((Control)_txtCustomername).remove_KeyDown(new KeyEventHandler(txtCustomername_KeyDown));
				((Control)_txtCustomername).remove_GotFocus((EventHandler)txtCustomername_GotFocus);
			}
			_txtCustomername = value;
			if (_txtCustomername != null)
			{
				((Control)_txtCustomername).add_TextChanged((EventHandler)txtCustomername_TextChanged);
				((Control)_txtCustomername).add_KeyDown(new KeyEventHandler(txtCustomername_KeyDown));
				((Control)_txtCustomername).add_GotFocus((EventHandler)txtCustomername_GotFocus);
			}
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

	internal virtual TextBox txtCustomerID
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCustomerID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			if (_txtCustomerID != null)
			{
				((Control)_txtCustomerID).remove_Validated((EventHandler)txtCustomerID_Validated);
				((Control)_txtCustomerID).remove_TextChanged((EventHandler)txtCustomerID_TextChanged);
				((Control)_txtCustomerID).remove_LostFocus((EventHandler)txtCustomerID_LostFocus);
				((Control)_txtCustomerID).remove_KeyDown(new KeyEventHandler(txtCustomerID_KeyDown));
				((Control)_txtCustomerID).remove_GotFocus((EventHandler)txtCustomerID_GotFocus);
			}
			_txtCustomerID = value;
			if (_txtCustomerID != null)
			{
				((Control)_txtCustomerID).add_Validated((EventHandler)txtCustomerID_Validated);
				((Control)_txtCustomerID).add_TextChanged((EventHandler)txtCustomerID_TextChanged);
				((Control)_txtCustomerID).add_LostFocus((EventHandler)txtCustomerID_LostFocus);
				((Control)_txtCustomerID).add_KeyDown(new KeyEventHandler(txtCustomerID_KeyDown));
				((Control)_txtCustomerID).add_GotFocus((EventHandler)txtCustomerID_GotFocus);
			}
		}
	}

	internal virtual TextBox txtTelephone
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtTelephone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtTelephone != null)
			{
				((Control)_txtTelephone).remove_KeyDown(new KeyEventHandler(txtTelephone_KeyDown));
				((Control)_txtTelephone).remove_GotFocus((EventHandler)txtTelephone_GotFocus);
				((Control)_txtTelephone).remove_TextChanged((EventHandler)txtTelephone_TextChanged);
			}
			_txtTelephone = value;
			if (_txtTelephone != null)
			{
				((Control)_txtTelephone).add_KeyDown(new KeyEventHandler(txtTelephone_KeyDown));
				((Control)_txtTelephone).add_GotFocus((EventHandler)txtTelephone_GotFocus);
				((Control)_txtTelephone).add_TextChanged((EventHandler)txtTelephone_TextChanged);
			}
		}
	}

	internal virtual TextBox txtGroupname
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGroupname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			if (_txtGroupname != null)
			{
				((Control)_txtGroupname).remove_KeyDown(new KeyEventHandler(txtGroupname_KeyDown));
			}
			_txtGroupname = value;
			if (_txtGroupname != null)
			{
				((Control)_txtGroupname).add_KeyDown(new KeyEventHandler(txtGroupname_KeyDown));
			}
		}
	}

	internal virtual AxSSCommand cmdGroupId
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdGroupId;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdGroupId != null)
			{
				((Control)_cmdGroupId).remove_Enter((EventHandler)cmdGroupId_Enter);
				_cmdGroupId.remove_ClickEvent((EventHandler)cmdGroupId_ClickEvent);
			}
			_cmdGroupId = value;
			if (_cmdGroupId != null)
			{
				((Control)_cmdGroupId).add_Enter((EventHandler)cmdGroupId_Enter);
				_cmdGroupId.add_ClickEvent((EventHandler)cmdGroupId_ClickEvent);
			}
		}
	}

	internal virtual TextBox txtGroupid
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtGroupid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtGroupid != null)
			{
				((Control)_txtGroupid).remove_TextChanged((EventHandler)txtGroupid_TextChanged);
				((Control)_txtGroupid).remove_KeyDown(new KeyEventHandler(txtGroupid_KeyDown));
				((Control)_txtGroupid).remove_GotFocus((EventHandler)txtGroupid_GotFocus);
			}
			_txtGroupid = value;
			if (_txtGroupid != null)
			{
				((Control)_txtGroupid).add_TextChanged((EventHandler)txtGroupid_TextChanged);
				((Control)_txtGroupid).add_KeyDown(new KeyEventHandler(txtGroupid_KeyDown));
				((Control)_txtGroupid).add_GotFocus((EventHandler)txtGroupid_GotFocus);
			}
		}
	}

	private virtual Ccustomer objCustomer
	{
		[DebuggerNonUserCode]
		get
		{
			return _objCustomer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objCustomer != null)
			{
				_objCustomer.RecordExits -= objCustomer_RecordExits;
				_objCustomer.NoRecords -= objCustomer_NoRecords;
				_objCustomer.MoveForward -= objCustomer_MoveForward;
				_objCustomer.DataValidated -= objCustomer_DataValidated;
				_objCustomer.MoveBackward -= objCustomer_MoveBackward;
			}
			_objCustomer = value;
			if (_objCustomer != null)
			{
				_objCustomer.RecordExits += objCustomer_RecordExits;
				_objCustomer.NoRecords += objCustomer_NoRecords;
				_objCustomer.MoveForward += objCustomer_MoveForward;
				_objCustomer.DataValidated += objCustomer_DataValidated;
				_objCustomer.MoveBackward += objCustomer_MoveBackward;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmCustomer()
	{
		((Form)this).add_Load((EventHandler)frmCustomer_Load);
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
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected O, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected O, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected O, but got Unknown
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected O, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected O, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected O, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_113b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1145: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCustomer));
		txtContactPerson = new TextBox();
		Label13 = new Label();
		txtMobile = new TextBox();
		Label12 = new Label();
		Label11 = new Label();
		txtCountry = new TextBox();
		Label10 = new Label();
		txtTown = new TextBox();
		txtAddress = new TextBox();
		Label9 = new Label();
		Label1 = new Label();
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
		Label14 = new Label();
		txtBalance = new TextBox();
		Label7 = new Label();
		txtLastDate = new TextBox();
		Label6 = new Label();
		txtLastPayment = new TextBox();
		Label5 = new Label();
		txtLastBill = new TextBox();
		Label4 = new Label();
		txtVATno = new TextBox();
		Label3 = new Label();
		Label2 = new Label();
		txtCustomername = new TextBox();
		Label8 = new Label();
		txtCustomerID = new TextBox();
		txtTelephone = new TextBox();
		txtGroupname = new TextBox();
		cmdGroupId = new AxSSCommand();
		txtGroupid = new TextBox();
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
		((ISupportInitialize)cmdGroupId).BeginInit();
		((Control)this).SuspendLayout();
		TextBox obj = txtContactPerson;
		Point location = new Point(138, 446);
		((Control)obj).set_Location(location);
		((Control)txtContactPerson).set_Name("txtContactPerson");
		TextBox obj2 = txtContactPerson;
		Size size = new Size(206, 20);
		((Control)obj2).set_Size(size);
		((Control)txtContactPerson).set_TabIndex(14);
		Label13.set_AutoSize(true);
		Label label = Label13;
		location = new Point(35, 450);
		((Control)label).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label2 = Label13;
		size = new Size(80, 13);
		((Control)label2).set_Size(size);
		((Control)Label13).set_TabIndex(124);
		Label13.set_Text("Contact Person");
		TextBox obj3 = txtMobile;
		location = new Point(138, 420);
		((Control)obj3).set_Location(location);
		((Control)txtMobile).set_Name("txtMobile");
		TextBox obj4 = txtMobile;
		size = new Size(206, 20);
		((Control)obj4).set_Size(size);
		((Control)txtMobile).set_TabIndex(13);
		Label12.set_AutoSize(true);
		Label label3 = Label12;
		location = new Point(35, 424);
		((Control)label3).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label4 = Label12;
		size = new Size(55, 13);
		((Control)label4).set_Size(size);
		((Control)Label12).set_TabIndex(122);
		Label12.set_Text("Mobile No");
		Label11.set_AutoSize(true);
		Label label5 = Label11;
		location = new Point(35, 401);
		((Control)label5).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label6 = Label11;
		size = new Size(61, 13);
		((Control)label6).set_Size(size);
		((Control)Label11).set_TabIndex(121);
		Label11.set_Text("Telephone ");
		TextBox obj5 = txtCountry;
		location = new Point(138, 356);
		((Control)obj5).set_Location(location);
		((Control)txtCountry).set_Name("txtCountry");
		TextBox obj6 = txtCountry;
		size = new Size(206, 20);
		((Control)obj6).set_Size(size);
		((Control)txtCountry).set_TabIndex(11);
		Label10.set_AutoSize(true);
		Label label7 = Label10;
		location = new Point(35, 359);
		((Control)label7).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label8 = Label10;
		size = new Size(43, 13);
		((Control)label8).set_Size(size);
		((Control)Label10).set_TabIndex(119);
		Label10.set_Text("Country");
		TextBox obj7 = txtTown;
		location = new Point(138, 330);
		((Control)obj7).set_Location(location);
		((Control)txtTown).set_Name("txtTown");
		TextBox obj8 = txtTown;
		size = new Size(206, 20);
		((Control)obj8).set_Size(size);
		((Control)txtTown).set_TabIndex(10);
		TextBox obj9 = txtAddress;
		location = new Point(138, 277);
		((Control)obj9).set_Location(location);
		txtAddress.set_Multiline(true);
		((Control)txtAddress).set_Name("txtAddress");
		txtAddress.set_ScrollBars((ScrollBars)2);
		TextBox obj10 = txtAddress;
		size = new Size(206, 47);
		((Control)obj10).set_Size(size);
		((Control)txtAddress).set_TabIndex(9);
		Label9.set_AutoSize(true);
		Label label9 = Label9;
		location = new Point(35, 333);
		((Control)label9).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label10 = Label9;
		size = new Size(34, 13);
		((Control)label10).set_Size(size);
		((Control)Label9).set_TabIndex(116);
		Label9.set_Text("Town");
		Label1.set_AutoSize(true);
		Label label11 = Label1;
		location = new Point(35, 278);
		((Control)label11).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label12 = Label1;
		size = new Size(87, 13);
		((Control)label12).set_Size(size);
		((Control)Label1).set_TabIndex(115);
		Label1.set_Text("Physical Address");
		AxSSCommand obj11 = cmdClose;
		location = new Point(434, 484);
		((Control)obj11).set_Location(location);
		((Control)cmdClose).set_Name("cmdClose");
		((AxHost)cmdClose).set_OcxState((State)componentResourceManager.GetObject("cmdClose.OcxState"));
		AxSSCommand obj12 = cmdClose;
		size = new Size(61, 24);
		((Control)obj12).set_Size(size);
		((Control)cmdClose).set_TabIndex(32);
		AxSSCommand obj13 = cmdLast;
		location = new Point(236, 484);
		((Control)obj13).set_Location(location);
		((Control)cmdLast).set_Name("cmdLast");
		((AxHost)cmdLast).set_OcxState((State)componentResourceManager.GetObject("cmdLast.OcxState"));
		AxSSCommand obj14 = cmdLast;
		size = new Size(61, 24);
		((Control)obj14).set_Size(size);
		((Control)cmdLast).set_TabIndex(31);
		AxSSCommand obj15 = cmdNext;
		location = new Point(163, 484);
		((Control)obj15).set_Location(location);
		((Control)cmdNext).set_Name("cmdNext");
		((AxHost)cmdNext).set_OcxState((State)componentResourceManager.GetObject("cmdNext.OcxState"));
		AxSSCommand obj16 = cmdNext;
		size = new Size(61, 24);
		((Control)obj16).set_Size(size);
		((Control)cmdNext).set_TabIndex(30);
		AxSSCommand obj17 = cmdPrevious;
		location = new Point(89, 484);
		((Control)obj17).set_Location(location);
		((Control)cmdPrevious).set_Name("cmdPrevious");
		((AxHost)cmdPrevious).set_OcxState((State)componentResourceManager.GetObject("cmdPrevious.OcxState"));
		AxSSCommand obj18 = cmdPrevious;
		size = new Size(61, 24);
		((Control)obj18).set_Size(size);
		((Control)cmdPrevious).set_TabIndex(29);
		AxSSCommand obj19 = cmdFirst;
		location = new Point(15, 484);
		((Control)obj19).set_Location(location);
		((Control)cmdFirst).set_Name("cmdFirst");
		((AxHost)cmdFirst).set_OcxState((State)componentResourceManager.GetObject("cmdFirst.OcxState"));
		AxSSCommand obj20 = cmdFirst;
		size = new Size(61, 24);
		((Control)obj20).set_Size(size);
		((Control)cmdFirst).set_TabIndex(28);
		AxSSCommand obj21 = cmdPrint;
		location = new Point(433, 278);
		((Control)obj21).set_Location(location);
		((Control)cmdPrint).set_Name("cmdPrint");
		((AxHost)cmdPrint).set_OcxState((State)componentResourceManager.GetObject("cmdPrint.OcxState"));
		AxSSCommand obj22 = cmdPrint;
		size = new Size(61, 24);
		((Control)obj22).set_Size(size);
		((Control)cmdPrint).set_TabIndex(27);
		AxSSCommand obj23 = cmdDelete;
		location = new Point(433, 244);
		((Control)obj23).set_Location(location);
		((Control)cmdDelete).set_Name("cmdDelete");
		((AxHost)cmdDelete).set_OcxState((State)componentResourceManager.GetObject("cmdDelete.OcxState"));
		AxSSCommand obj24 = cmdDelete;
		size = new Size(61, 24);
		((Control)obj24).set_Size(size);
		((Control)cmdDelete).set_TabIndex(26);
		AxSSCommand obj25 = cmdEdit;
		location = new Point(433, 210);
		((Control)obj25).set_Location(location);
		((Control)cmdEdit).set_Name("cmdEdit");
		((AxHost)cmdEdit).set_OcxState((State)componentResourceManager.GetObject("cmdEdit.OcxState"));
		AxSSCommand obj26 = cmdEdit;
		size = new Size(61, 24);
		((Control)obj26).set_Size(size);
		((Control)cmdEdit).set_TabIndex(25);
		AxSSCommand obj27 = cmdnew;
		location = new Point(433, 176);
		((Control)obj27).set_Location(location);
		((Control)cmdnew).set_Name("cmdnew");
		((AxHost)cmdnew).set_OcxState((State)componentResourceManager.GetObject("cmdnew.OcxState"));
		AxSSCommand obj28 = cmdnew;
		size = new Size(61, 24);
		((Control)obj28).set_Size(size);
		((Control)cmdnew).set_TabIndex(24);
		AxSSPanel axSSPanel = AxSSPanel1;
		location = new Point(14, 12);
		((Control)axSSPanel).set_Location(location);
		((Control)AxSSPanel1).set_Name("AxSSPanel1");
		((AxHost)AxSSPanel1).set_OcxState((State)componentResourceManager.GetObject("AxSSPanel1.OcxState"));
		AxSSPanel axSSPanel2 = AxSSPanel1;
		size = new Size(411, 467);
		((Control)axSSPanel2).set_Size(size);
		((Control)AxSSPanel1).set_TabIndex(126);
		Label14.set_AutoSize(true);
		Label label13 = Label14;
		location = new Point(35, 213);
		((Control)label13).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label14 = Label14;
		size = new Size(83, 13);
		((Control)label14).set_Size(size);
		((Control)Label14).set_TabIndex(157);
		Label14.set_Text("Current Balance");
		TextBox obj29 = txtBalance;
		location = new Point(138, 210);
		((Control)obj29).set_Location(location);
		((Control)txtBalance).set_Name("txtBalance");
		TextBox obj30 = txtBalance;
		size = new Size(127, 20);
		((Control)obj30).set_Size(size);
		((Control)txtBalance).set_TabIndex(7);
		txtBalance.set_TextAlign((HorizontalAlignment)1);
		Label7.set_AutoSize(true);
		Label label15 = Label7;
		location = new Point(35, 239);
		((Control)label15).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label16 = Label7;
		size = new Size(83, 13);
		((Control)label16).set_Size(size);
		((Control)Label7).set_TabIndex(156);
		Label7.set_Text("Last Trans Date");
		TextBox obj31 = txtLastDate;
		location = new Point(138, 236);
		((Control)obj31).set_Location(location);
		((Control)txtLastDate).set_Name("txtLastDate");
		TextBox obj32 = txtLastDate;
		size = new Size(127, 20);
		((Control)obj32).set_Size(size);
		((Control)txtLastDate).set_TabIndex(8);
		Label6.set_AutoSize(true);
		Label label17 = Label6;
		location = new Point(35, 187);
		((Control)label17).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label18 = Label6;
		size = new Size(71, 13);
		((Control)label18).set_Size(size);
		((Control)Label6).set_TabIndex(154);
		Label6.set_Text("Last Payment");
		TextBox obj33 = txtLastPayment;
		location = new Point(138, 184);
		((Control)obj33).set_Location(location);
		((Control)txtLastPayment).set_Name("txtLastPayment");
		TextBox obj34 = txtLastPayment;
		size = new Size(127, 20);
		((Control)obj34).set_Size(size);
		((Control)txtLastPayment).set_TabIndex(6);
		txtLastPayment.set_TextAlign((HorizontalAlignment)1);
		Label5.set_AutoSize(true);
		Label label19 = Label5;
		location = new Point(35, 161);
		((Control)label19).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label20 = Label5;
		size = new Size(46, 13);
		((Control)label20).set_Size(size);
		((Control)Label5).set_TabIndex(151);
		Label5.set_Text("Last Bill ");
		TextBox obj35 = txtLastBill;
		location = new Point(138, 158);
		((Control)obj35).set_Location(location);
		((Control)txtLastBill).set_Name("txtLastBill");
		TextBox obj36 = txtLastBill;
		size = new Size(127, 20);
		((Control)obj36).set_Size(size);
		((Control)txtLastBill).set_TabIndex(5);
		txtLastBill.set_TextAlign((HorizontalAlignment)1);
		Label4.set_AutoSize(true);
		Label label21 = Label4;
		location = new Point(35, 126);
		((Control)label21).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label22 = Label4;
		size = new Size(68, 13);
		((Control)label22).set_Size(size);
		((Control)Label4).set_TabIndex(149);
		Label4.set_Text("VAT Number");
		TextBox obj37 = txtVATno;
		location = new Point(138, 124);
		((Control)obj37).set_Location(location);
		((Control)txtVATno).set_Name("txtVATno");
		TextBox obj38 = txtVATno;
		size = new Size(127, 20);
		((Control)obj38).set_Size(size);
		((Control)txtVATno).set_TabIndex(4);
		Label3.set_AutoSize(true);
		Label label23 = Label3;
		location = new Point(35, 89);
		((Control)label23).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label24 = Label3;
		size = new Size(96, 13);
		((Control)label24).set_Size(size);
		((Control)Label3).set_TabIndex(147);
		Label3.set_Text("Company Category");
		Label2.set_AutoSize(true);
		Label label25 = Label2;
		location = new Point(35, 62);
		((Control)label25).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label26 = Label2;
		size = new Size(82, 13);
		((Control)label26).set_Size(size);
		((Control)Label2).set_TabIndex(145);
		Label2.set_Text("Company Name");
		TextBox obj39 = txtCustomername;
		location = new Point(138, 60);
		((Control)obj39).set_Location(location);
		((Control)txtCustomername).set_Name("txtCustomername");
		TextBox obj40 = txtCustomername;
		size = new Size(270, 20);
		((Control)obj40).set_Size(size);
		((Control)txtCustomername).set_TabIndex(2);
		Label8.set_AutoSize(true);
		Label label27 = Label8;
		location = new Point(35, 34);
		((Control)label27).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label28 = Label8;
		size = new Size(65, 13);
		((Control)label28).set_Size(size);
		((Control)Label8).set_TabIndex(143);
		Label8.set_Text("Company ID");
		TextBox obj41 = txtCustomerID;
		location = new Point(138, 34);
		((Control)obj41).set_Location(location);
		((Control)txtCustomerID).set_Name("txtCustomerID");
		TextBox obj42 = txtCustomerID;
		size = new Size(127, 20);
		((Control)obj42).set_Size(size);
		((Control)txtCustomerID).set_TabIndex(1);
		TextBox obj43 = txtTelephone;
		location = new Point(138, 394);
		((Control)obj43).set_Location(location);
		((Control)txtTelephone).set_Name("txtTelephone");
		TextBox obj44 = txtTelephone;
		size = new Size(206, 20);
		((Control)obj44).set_Size(size);
		((Control)txtTelephone).set_TabIndex(12);
		TextBox obj45 = txtGroupname;
		location = new Point(253, 86);
		((Control)obj45).set_Location(location);
		((Control)txtGroupname).set_Name("txtGroupname");
		TextBox obj46 = txtGroupname;
		size = new Size(155, 20);
		((Control)obj46).set_Size(size);
		((Control)txtGroupname).set_TabIndex(15);
		AxSSCommand obj47 = cmdGroupId;
		location = new Point(219, 86);
		((Control)obj47).set_Location(location);
		((Control)cmdGroupId).set_Name("cmdGroupId");
		((AxHost)cmdGroupId).set_OcxState((State)componentResourceManager.GetObject("cmdGroupId.OcxState"));
		AxSSCommand obj48 = cmdGroupId;
		size = new Size(28, 20);
		((Control)obj48).set_Size(size);
		((Control)cmdGroupId).set_TabIndex(161);
		TextBox obj49 = txtGroupid;
		location = new Point(138, 86);
		((Control)obj49).set_Location(location);
		((Control)txtGroupid).set_Name("txtGroupid");
		TextBox obj50 = txtGroupid;
		size = new Size(85, 20);
		((Control)obj50).set_Size(size);
		((Control)txtGroupid).set_TabIndex(3);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		size = new Size(507, 518);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)txtGroupname);
		((Control)this).get_Controls().Add((Control)(object)cmdGroupId);
		((Control)this).get_Controls().Add((Control)(object)txtGroupid);
		((Control)this).get_Controls().Add((Control)(object)txtTelephone);
		((Control)this).get_Controls().Add((Control)(object)Label14);
		((Control)this).get_Controls().Add((Control)(object)txtBalance);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)txtLastDate);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)txtLastPayment);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)txtLastBill);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)txtVATno);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)txtCustomername);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)txtCustomerID);
		((Control)this).get_Controls().Add((Control)(object)txtContactPerson);
		((Control)this).get_Controls().Add((Control)(object)Label13);
		((Control)this).get_Controls().Add((Control)(object)txtMobile);
		((Control)this).get_Controls().Add((Control)(object)Label12);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)txtCountry);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)txtTown);
		((Control)this).get_Controls().Add((Control)(object)txtAddress);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)Label1);
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
		((Control)this).set_Name("frmCustomer");
		((Form)this).set_Text("Company Account");
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
		((ISupportInitialize)cmdGroupId).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmCustomer_Load(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		objCustomer = new Ccustomer();
		dsgroup = new DataSet();
		objCustomer.Initialise(Startup.dBcon);
		StrSQL = "select * from debtorgroups order by groupid";
		dagroup = new SqlDataAdapter(StrSQL, Startup.dBcon);
		((DbDataAdapter)(object)dagroup).FillSchema(dsgroup, SchemaType.Mapped, "debtorgroups");
		((DbDataAdapter)(object)dagroup).Fill(dsgroup, "debtorgroups");
		Refreshdata();
		viewmode();
		if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(objCustomer.RecordCount, (object)1), (object)0, false))
		{
			objCustomer_NoRecords();
		}
		Refreshdata();
		viewmode();
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
		txtLastDate.set_Text(Conversions.ToString(DateTime.Today));
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
		cmdGroupId.set_Enabled(false);
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
		((TextBoxBase)txtLastPayment).set_ReadOnly(true);
		((TextBoxBase)txtLastBill).set_ReadOnly(true);
		((TextBoxBase)txtBalance).set_ReadOnly(true);
		((TextBoxBase)txtLastDate).set_ReadOnly(true);
		((TextBoxBase)txtLastPayment).set_BackColor(Color.White);
		((TextBoxBase)txtLastBill).set_BackColor(Color.White);
		((TextBoxBase)txtBalance).set_BackColor(Color.White);
		((TextBoxBase)txtLastDate).set_BackColor(Color.White);
		cmdGroupId.set_Enabled(true);
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
		txtCustomerID.set_Text(Conversions.ToString(objCustomer.CustomerID));
		txtCustomername.set_Text(Conversions.ToString(objCustomer.CustomerName));
		txtGroupid.set_Text(Conversions.ToString(objCustomer.GroupId));
		txtVATno.set_Text(Conversions.ToString(objCustomer.VatNo));
		txtLastPayment.set_Text(Conversions.ToString(objCustomer.LastPayment));
		txtLastBill.set_Text(Conversions.ToString(objCustomer.LastBill));
		txtBalance.set_Text(Conversions.ToString(objCustomer.Balance));
		txtAddress.set_Text(Conversions.ToString(objCustomer.PhysicalAddress));
		txtTown.set_Text(Conversions.ToString(objCustomer.Town));
		txtCountry.set_Text(Conversions.ToString(objCustomer.Country));
		txtTelephone.set_Text(Conversions.ToString(objCustomer.Telephone));
		txtMobile.set_Text(Conversions.ToString(objCustomer.Cellno));
		txtLastDate.set_Text(Conversions.ToString(objCustomer.LastTransDate));
		txtContactPerson.set_Text(Conversions.ToString(objCustomer.ContactPerson1));
		FormatThem();
	}

	private void Label13_Click(object sender, EventArgs e)
	{
	}

	private void cmdClose_ClickEvent(object sender, EventArgs e)
	{
		objCustomer = null;
		((Form)this).Close();
	}

	private void cmdClose_Enter(object sender, EventArgs e)
	{
	}

	private void CmbcustomerGroup_KeyDown(object sender, KeyEventArgs e)
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

	private void CmbcustomerGroup_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void objCustomer_DataValidated(bool blnIsValid)
	{
		cmdnew.set_Enabled(blnIsValid);
	}

	private void objCustomer_MoveBackward(bool blnMoveBack)
	{
		cmdPrevious.set_Enabled(blnMoveBack);
		cmdFirst.set_Enabled(blnMoveBack);
	}

	private void objCustomer_MoveForward(bool blnMoveForward)
	{
		cmdNext.set_Enabled(blnMoveForward);
		cmdLast.set_Enabled(blnMoveForward);
	}

	private void objCustomer_NoRecords()
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

	private void FormatThem()
	{
		txtBalance.set_Text(Strings.FormatNumber((object)txtBalance.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		txtLastBill.set_Text(Strings.FormatNumber((object)txtLastBill.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		txtLastPayment.set_Text(Strings.FormatNumber((object)txtLastPayment.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
	}

	private void objCustomer_RecordExits()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"Company ID Already Exits.\r\nPlease Enter A Unique ID\r\nTo Continue", (MsgBoxStyle)69, (object)"Information");
		if (msgAns == 4L)
		{
			((Control)txtCustomerID).Focus();
			txtCustomerID.set_Text("");
		}
		else
		{
			cmdEdit.DoClick();
		}
	}

	private void cmdFirst_ClickEvent(object sender, EventArgs e)
	{
		objCustomer.MoveFirst();
		Refreshdata();
	}

	private void cmdPrevious_ClickEvent(object sender, EventArgs e)
	{
		objCustomer.MovePrevious();
		Refreshdata();
	}

	private void cmdNext_ClickEvent(object sender, EventArgs e)
	{
		objCustomer.MoveNext();
		Refreshdata();
	}

	private void cmdLast_ClickEvent(object sender, EventArgs e)
	{
		objCustomer.MoveLast();
		Refreshdata();
	}

	private void txtGroupid_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtGroupid).SelectAll();
	}

	private void txtGroupid_KeyDown(object sender, KeyEventArgs e)
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

	private void txtGroupid_TextChanged(object sender, EventArgs e)
	{
		objCustomer.GroupId = txtGroupid.get_Text();
		try
		{
			nrowgroup = dsgroup.Tables["debtorgroups"]!.Rows.Find(txtGroupid.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (nrowgroup == null)
		{
			txtGroupname.set_Text("");
		}
		else
		{
			txtGroupname.set_Text(nrowgroup["group"].ToString());
		}
		ValidateNow();
	}

	private void txtGroupname_KeyDown(object sender, KeyEventArgs e)
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

	private void txtAddress_KeyDown(object sender, KeyEventArgs e)
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

	private void txtAddress_TextChanged(object sender, EventArgs e)
	{
		objCustomer.PhysicalAddress = txtAddress.get_Text();
		ValidateNow();
	}

	private void txtTown_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtTown).SelectAll();
	}

	private void txtTown_KeyDown(object sender, KeyEventArgs e)
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

	private void txtTown_TextChanged(object sender, EventArgs e)
	{
		objCustomer.Town = txtTown.get_Text();
		ValidateNow();
	}

	private void txtCountry_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtCountry).SelectAll();
	}

	private void txtCountry_KeyDown(object sender, KeyEventArgs e)
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

	private void txtCountry_TextChanged(object sender, EventArgs e)
	{
		objCustomer.Country = txtCountry.get_Text();
		ValidateNow();
	}

	private void txtTelephone_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtTelephone).SelectAll();
	}

	private void txtTelephone_KeyDown(object sender, KeyEventArgs e)
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

	private void txtTelephone_TextChanged(object sender, EventArgs e)
	{
		objCustomer.Telephone = txtTelephone.get_Text();
		ValidateNow();
	}

	private void txtMobile_KeyDown(object sender, KeyEventArgs e)
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

	private void txtMobile_TextChanged(object sender, EventArgs e)
	{
		objCustomer.Cellno = txtMobile.get_Text();
		ValidateNow();
	}

	private void txtContactPerson_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtContactPerson).SelectAll();
	}

	private void txtContactPerson_KeyDown(object sender, KeyEventArgs e)
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

	private void txtContactPerson_TextChanged(object sender, EventArgs e)
	{
		objCustomer.ContactPerson1 = txtContactPerson.get_Text();
		ValidateNow();
	}

	private void txtCustomerID_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtCustomerID).SelectAll();
	}

	private void txtCustomerID_KeyDown(object sender, KeyEventArgs e)
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

	private void ValidateNow()
	{
		if (Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0)
		{
			objCustomer.IsValid();
		}
	}

	private void txtCustomerID_LostFocus(object sender, EventArgs e)
	{
		if ((Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0) & IsnewRecord)
		{
			objCustomer.FindRecord(txtCustomerID.get_Text());
		}
	}

	private void txtCustomerID_TextChanged(object sender, EventArgs e)
	{
		objCustomer.CustomerID = txtCustomerID.get_Text();
		ValidateNow();
	}

	private void txtCustomername_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtCustomername).SelectAll();
	}

	private void txtCustomername_KeyDown(object sender, KeyEventArgs e)
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

	private void txtCustomername_TextChanged(object sender, EventArgs e)
	{
		objCustomer.CustomerName = txtCustomername.get_Text();
		ValidateNow();
	}

	private void txtVATno_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtVATno).SelectAll();
	}

	private void txtVATno_KeyDown(object sender, KeyEventArgs e)
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

	private void txtVATno_TextChanged(object sender, EventArgs e)
	{
		objCustomer.VatNo = txtVATno.get_Text();
		ValidateNow();
	}

	private void txtLastBill_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtLastBill).SelectAll();
	}

	private void txtLastBill_KeyDown(object sender, KeyEventArgs e)
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

	private void txtLastBill_TextChanged(object sender, EventArgs e)
	{
		Valtextbox(txtLastBill);
		objCustomer.LastBill = txtLastBill.get_Text();
		ValidateNow();
	}

	private void Valtextbox(TextBox objTxtbox)
	{
		if (Operators.CompareString(objTxtbox.get_Text(), "", false) == 0)
		{
			objTxtbox.set_Text(Conversions.ToString(0));
		}
		try
		{
			isNum = Conversions.ToDouble(objTxtbox.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)objTxtbox).Focus();
			ProjectData.ClearProjectError();
		}
	}

	private void txtLastPayment_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtLastPayment).SelectAll();
	}

	private void txtLastPayment_KeyDown(object sender, KeyEventArgs e)
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

	private void txtLastPayment_TextChanged(object sender, EventArgs e)
	{
		Valtextbox(txtLastPayment);
		objCustomer.LastPayment = txtLastPayment.get_Text();
		ValidateNow();
	}

	private void txtBalance_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtBalance).SelectAll();
	}

	private void txtBalance_KeyDown(object sender, KeyEventArgs e)
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

	private void txtBalance_TextChanged(object sender, EventArgs e)
	{
		Valtextbox(txtBalance);
		objCustomer.Balance = txtBalance.get_Text();
		ValidateNow();
	}

	private void txtLastDate_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtLastDate).SelectAll();
	}

	private void txtLastDate_HelpRequested(object sender, HelpEventArgs e)
	{
	}

	private void txtLastDate_KeyDown(object sender, KeyEventArgs e)
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

	private void txtLastDate_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(txtLastDate.get_Text(), "", false) == 0)
		{
			txtLastDate.set_Text(Conversions.ToString(DateTime.Today));
		}
		objCustomer.LastTransDate = txtLastDate.get_Text();
	}

	private void txtCustomerID_Validated(object sender, EventArgs e)
	{
	}

	private void cmdGroupId_ClickEvent(object sender, EventArgs e)
	{
		frmcommonlookup frmcommonlookup2 = new frmcommonlookup();
		nform = (Form)(object)this;
		frmcommonlookup2.InitialiseLookup(nform, txtGroupid, txtGroupname, "debtorgroups", "groupid");
		((Form)frmcommonlookup2).Close();
		frmcommonlookup2 = null;
	}

	private void cmdGroupId_Enter(object sender, EventArgs e)
	{
	}

	private void cmdnew_ClickEvent(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(cmdnew.get_Caption(), "&New", false) == 0)
		{
			IsnewRecord = true;
			ClearData();
			editmode();
			((Control)txtCustomerID).Focus();
			cmdnew.set_Enabled(false);
		}
		else
		{
			objCustomer.Save(IsnewRecord);
			Interaction.MsgBox((object)"Data Successfully Saved", (MsgBoxStyle)64, (object)"information");
			viewmode();
		}
	}

	private void txtGroupid_Validated(object sender, EventArgs e)
	{
		nrowgroup = dsgroup.Tables["debtorgroups"]!.Rows.Find(txtGroupid.get_Text());
		if (nrowgroup == null)
		{
			txtGroupname.set_Text("");
			txtGroupid.set_Text("");
			cmdGroupId.DoClick();
		}
		else
		{
			txtGroupname.set_Text(nrowgroup["group"].ToString());
		}
	}

	private void cmdEdit_ClickEvent(object sender, EventArgs e)
	{
		if (Operators.CompareString(cmdEdit.get_Caption(), "&Edit", false) == 0)
		{
			IsnewRecord = false;
			editmode();
			((TextBoxBase)txtCustomerID).set_ReadOnly(true);
			((TextBoxBase)txtCustomerID).set_BackColor(Color.White);
			((Control)txtCustomername).Focus();
		}
		else
		{
			viewmode();
			objCustomer.Initialise(Startup.dBcon);
			Refreshdata();
		}
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
			objCustomer.Delete(txtCustomerID.get_Text());
			Refreshdata();
		}
	}

	private void cmdDelete_Enter(object sender, EventArgs e)
	{
	}

	private void cmdnew_Enter(object sender, EventArgs e)
	{
	}

	private void AxSSPanel1_Enter(object sender, EventArgs e)
	{
	}
}

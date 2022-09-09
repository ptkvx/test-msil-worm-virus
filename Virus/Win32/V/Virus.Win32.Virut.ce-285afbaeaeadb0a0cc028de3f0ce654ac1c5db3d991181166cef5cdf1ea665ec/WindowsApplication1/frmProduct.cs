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
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class frmProduct : Form
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

	[AccessedThroughProperty("AxSSPanel1")]
	private AxSSPanel _AxSSPanel1;

	[AccessedThroughProperty("txtUnits")]
	private TextBox _txtUnits;

	[AccessedThroughProperty("chkService")]
	private CheckBox _chkService;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("txtsalesacref")]
	private TextBox _txtsalesacref;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtProductID")]
	private TextBox _txtProductID;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("txtcogsacref")]
	private TextBox _txtcogsacref;

	[AccessedThroughProperty("txtstockacref")]
	private TextBox _txtstockacref;

	[AccessedThroughProperty("txtProductNam")]
	private TextBox _txtProductNam;

	[AccessedThroughProperty("txtGroupid")]
	private TextBox _txtGroupid;

	[AccessedThroughProperty("txtPrice")]
	private TextBox _txtPrice;

	[AccessedThroughProperty("txtstockqty")]
	private TextBox _txtstockqty;

	[AccessedThroughProperty("txtunitcost")]
	private TextBox _txtunitcost;

	[AccessedThroughProperty("txtstockvalue")]
	private TextBox _txtstockvalue;

	[AccessedThroughProperty("ComboBoxArray1")]
	private ComboBoxArray _ComboBoxArray1;

	[AccessedThroughProperty("cmdGroupId")]
	private AxSSCommand _cmdGroupId;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("cmdstockacref")]
	private AxSSCommand _cmdstockacref;

	[AccessedThroughProperty("cmdsalesacref")]
	private AxSSCommand _cmdsalesacref;

	[AccessedThroughProperty("cmdcogsacref")]
	private AxSSCommand _cmdcogsacref;

	[AccessedThroughProperty("txtGroupname")]
	private TextBox _txtGroupname;

	[AccessedThroughProperty("txtStockAcname")]
	private TextBox _txtStockAcname;

	[AccessedThroughProperty("txtSalesAcname")]
	private TextBox _txtSalesAcname;

	[AccessedThroughProperty("txtCogsAcname")]
	private TextBox _txtCogsAcname;

	[AccessedThroughProperty("objProduct")]
	private Cproduct _objProduct;

	private long msgAns;

	private double isNum;

	public bool IsnewRecord;

	private Control MyControl;

	private DataView dv;

	private DataSet dsledger;

	private SqlDataAdapter daledger;

	private DataRow nrowledger;

	private DataSet dsgroup;

	private SqlDataAdapter dagroup;

	private DataRow nrowgroup;

	private string StrSQL;

	private string StrSqlLedger;

	private Form nform;

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
				((Control)_cmdLast).remove_Enter((EventHandler)cmdLast_Enter);
			}
			_cmdLast = value;
			if (_cmdLast != null)
			{
				_cmdLast.add_ClickEvent((EventHandler)cmdLast_ClickEvent);
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
				_cmdNext.remove_ClickEvent((EventHandler)cmdNext_ClickEvent);
				((Control)_cmdNext).remove_Enter((EventHandler)cmdNext_Enter);
			}
			_cmdNext = value;
			if (_cmdNext != null)
			{
				_cmdNext.add_ClickEvent((EventHandler)cmdNext_ClickEvent);
				((Control)_cmdNext).add_Enter((EventHandler)cmdNext_Enter);
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
				((Control)_cmdPrevious).remove_Enter((EventHandler)cmdPrevious_Enter);
			}
			_cmdPrevious = value;
			if (_cmdPrevious != null)
			{
				_cmdPrevious.add_ClickEvent((EventHandler)cmdPrevious_ClickEvent);
				((Control)_cmdPrevious).add_Enter((EventHandler)cmdPrevious_Enter);
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
				((Control)_cmdFirst).remove_Enter((EventHandler)cmdFirst_Enter);
			}
			_cmdFirst = value;
			if (_cmdFirst != null)
			{
				_cmdFirst.add_ClickEvent((EventHandler)cmdFirst_ClickEvent);
				((Control)_cmdFirst).add_Enter((EventHandler)cmdFirst_Enter);
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
				_cmdEdit.remove_ClickEvent((EventHandler)cmdEdit_ClickEvent);
				((Control)_cmdEdit).remove_Enter((EventHandler)cmdEdit_Enter);
			}
			_cmdEdit = value;
			if (_cmdEdit != null)
			{
				_cmdEdit.add_ClickEvent((EventHandler)cmdEdit_ClickEvent);
				((Control)_cmdEdit).add_Enter((EventHandler)cmdEdit_Enter);
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

	internal virtual TextBox txtUnits
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtUnits;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			if (_txtUnits != null)
			{
				((Control)_txtUnits).remove_TextChanged((EventHandler)txtUnits_TextChanged);
				((Control)_txtUnits).remove_LostFocus((EventHandler)txtUnits_LostFocus);
				((Control)_txtUnits).remove_KeyDown(new KeyEventHandler(txtUnits_KeyDown));
				((Control)_txtUnits).remove_GotFocus((EventHandler)txtUnits_GotFocus);
			}
			_txtUnits = value;
			if (_txtUnits != null)
			{
				((Control)_txtUnits).add_TextChanged((EventHandler)txtUnits_TextChanged);
				((Control)_txtUnits).add_LostFocus((EventHandler)txtUnits_LostFocus);
				((Control)_txtUnits).add_KeyDown(new KeyEventHandler(txtUnits_KeyDown));
				((Control)_txtUnits).add_GotFocus((EventHandler)txtUnits_GotFocus);
			}
		}
	}

	internal virtual CheckBox chkService
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkService;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			if (_chkService != null)
			{
				((Control)_chkService).remove_KeyDown(new KeyEventHandler(chkService_KeyDown));
				_chkService.remove_CheckedChanged((EventHandler)chkService_CheckedChanged);
			}
			_chkService = value;
			if (_chkService != null)
			{
				((Control)_chkService).add_KeyDown(new KeyEventHandler(chkService_KeyDown));
				_chkService.add_CheckedChanged((EventHandler)chkService_CheckedChanged);
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

	internal virtual TextBox txtsalesacref
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtsalesacref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_txtsalesacref != null)
			{
				((Control)_txtsalesacref).remove_Validated((EventHandler)txtsalesacref_Validated);
				((Control)_txtsalesacref).remove_TextChanged((EventHandler)txtsalesacref_TextChanged);
				((Control)_txtsalesacref).remove_KeyDown(new KeyEventHandler(txtsalesacref_KeyDown));
			}
			_txtsalesacref = value;
			if (_txtsalesacref != null)
			{
				((Control)_txtsalesacref).add_Validated((EventHandler)txtsalesacref_Validated);
				((Control)_txtsalesacref).add_TextChanged((EventHandler)txtsalesacref_TextChanged);
				((Control)_txtsalesacref).add_KeyDown(new KeyEventHandler(txtsalesacref_KeyDown));
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

	internal virtual TextBox txtProductID
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtProductID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_txtProductID != null)
			{
				((Control)_txtProductID).remove_TextChanged((EventHandler)txtProductID_TextChanged);
				((Control)_txtProductID).remove_LostFocus((EventHandler)txtProductID_LostFocus);
				((Control)_txtProductID).remove_KeyDown(new KeyEventHandler(txtProductID_KeyDown));
			}
			_txtProductID = value;
			if (_txtProductID != null)
			{
				((Control)_txtProductID).add_TextChanged((EventHandler)txtProductID_TextChanged);
				((Control)_txtProductID).add_LostFocus((EventHandler)txtProductID_LostFocus);
				((Control)_txtProductID).add_KeyDown(new KeyEventHandler(txtProductID_KeyDown));
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

	internal virtual TextBox txtcogsacref
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtcogsacref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_txtcogsacref != null)
			{
				((Control)_txtcogsacref).remove_Validated((EventHandler)txtcogsacref_Validated);
				((Control)_txtcogsacref).remove_TextChanged((EventHandler)txtcogsacref_TextChanged);
			}
			_txtcogsacref = value;
			if (_txtcogsacref != null)
			{
				((Control)_txtcogsacref).add_Validated((EventHandler)txtcogsacref_Validated);
				((Control)_txtcogsacref).add_TextChanged((EventHandler)txtcogsacref_TextChanged);
			}
		}
	}

	internal virtual TextBox txtstockacref
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtstockacref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if (_txtstockacref != null)
			{
				((Control)_txtstockacref).remove_Validated((EventHandler)txtstockacref_Validated);
				((Control)_txtstockacref).remove_TextChanged((EventHandler)txtstockacref_TextChanged);
				((Control)_txtstockacref).remove_KeyDown(new KeyEventHandler(txtstockacref_KeyDown));
			}
			_txtstockacref = value;
			if (_txtstockacref != null)
			{
				((Control)_txtstockacref).add_Validated((EventHandler)txtstockacref_Validated);
				((Control)_txtstockacref).add_TextChanged((EventHandler)txtstockacref_TextChanged);
				((Control)_txtstockacref).add_KeyDown(new KeyEventHandler(txtstockacref_KeyDown));
			}
		}
	}

	internal virtual TextBox txtProductNam
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtProductNam;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtProductNam != null)
			{
				((Control)_txtProductNam).remove_TextChanged((EventHandler)txtProductNam_TextChanged);
				((Control)_txtProductNam).remove_KeyDown(new KeyEventHandler(txtProductNam_KeyDown));
			}
			_txtProductNam = value;
			if (_txtProductNam != null)
			{
				((Control)_txtProductNam).add_TextChanged((EventHandler)txtProductNam_TextChanged);
				((Control)_txtProductNam).add_KeyDown(new KeyEventHandler(txtProductNam_KeyDown));
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
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			if (_txtGroupid != null)
			{
				((Control)_txtGroupid).remove_Validated((EventHandler)txtGroupid_Validated);
				((Control)_txtGroupid).remove_LostFocus((EventHandler)txtGroupid_LostFocus);
				((Control)_txtGroupid).remove_TextChanged((EventHandler)txtGroupid_TextChanged);
				((Control)_txtGroupid).remove_KeyDown(new KeyEventHandler(txtGroupid_KeyDown));
			}
			_txtGroupid = value;
			if (_txtGroupid != null)
			{
				((Control)_txtGroupid).add_Validated((EventHandler)txtGroupid_Validated);
				((Control)_txtGroupid).add_LostFocus((EventHandler)txtGroupid_LostFocus);
				((Control)_txtGroupid).add_TextChanged((EventHandler)txtGroupid_TextChanged);
				((Control)_txtGroupid).add_KeyDown(new KeyEventHandler(txtGroupid_KeyDown));
			}
		}
	}

	internal virtual TextBox txtPrice
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPrice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			if (_txtPrice != null)
			{
				((Control)_txtPrice).remove_TextChanged((EventHandler)txtPrice_TextChanged);
				((Control)_txtPrice).remove_ParentChanged((EventHandler)txtPrice_ParentChanged);
				((Control)_txtPrice).remove_LostFocus((EventHandler)txtPrice_LostFocus);
				((Control)_txtPrice).remove_KeyPress(new KeyPressEventHandler(txtPrice_KeyPress));
				((Control)_txtPrice).remove_KeyDown(new KeyEventHandler(txtPrice_KeyDown));
				((Control)_txtPrice).remove_GotFocus((EventHandler)txtPrice_GotFocus);
			}
			_txtPrice = value;
			if (_txtPrice != null)
			{
				((Control)_txtPrice).add_TextChanged((EventHandler)txtPrice_TextChanged);
				((Control)_txtPrice).add_ParentChanged((EventHandler)txtPrice_ParentChanged);
				((Control)_txtPrice).add_LostFocus((EventHandler)txtPrice_LostFocus);
				((Control)_txtPrice).add_KeyPress(new KeyPressEventHandler(txtPrice_KeyPress));
				((Control)_txtPrice).add_KeyDown(new KeyEventHandler(txtPrice_KeyDown));
				((Control)_txtPrice).add_GotFocus((EventHandler)txtPrice_GotFocus);
			}
		}
	}

	internal virtual TextBox txtstockqty
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtstockqty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			if (_txtstockqty != null)
			{
				((Control)_txtstockqty).remove_TextChanged((EventHandler)txtstockqty_TextChanged);
				((Control)_txtstockqty).remove_LostFocus((EventHandler)txtstockqty_LostFocus);
				((Control)_txtstockqty).remove_KeyPress(new KeyPressEventHandler(txtstockqty_KeyPress));
				((Control)_txtstockqty).remove_KeyDown(new KeyEventHandler(txtstockqty_KeyDown));
				((Control)_txtstockqty).remove_GotFocus((EventHandler)txtstockqty_GotFocus);
			}
			_txtstockqty = value;
			if (_txtstockqty != null)
			{
				((Control)_txtstockqty).add_TextChanged((EventHandler)txtstockqty_TextChanged);
				((Control)_txtstockqty).add_LostFocus((EventHandler)txtstockqty_LostFocus);
				((Control)_txtstockqty).add_KeyPress(new KeyPressEventHandler(txtstockqty_KeyPress));
				((Control)_txtstockqty).add_KeyDown(new KeyEventHandler(txtstockqty_KeyDown));
				((Control)_txtstockqty).add_GotFocus((EventHandler)txtstockqty_GotFocus);
			}
		}
	}

	internal virtual TextBox txtunitcost
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtunitcost;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			if (_txtunitcost != null)
			{
				((Control)_txtunitcost).remove_TextChanged((EventHandler)txtunitcost_TextChanged);
				((Control)_txtunitcost).remove_LostFocus((EventHandler)txtunitcost_LostFocus);
				((Control)_txtunitcost).remove_KeyPress(new KeyPressEventHandler(txtunitcost_KeyPress));
				((Control)_txtunitcost).remove_KeyDown(new KeyEventHandler(txtunitcost_KeyDown));
				((Control)_txtunitcost).remove_GotFocus((EventHandler)txtunitcost_GotFocus);
			}
			_txtunitcost = value;
			if (_txtunitcost != null)
			{
				((Control)_txtunitcost).add_TextChanged((EventHandler)txtunitcost_TextChanged);
				((Control)_txtunitcost).add_LostFocus((EventHandler)txtunitcost_LostFocus);
				((Control)_txtunitcost).add_KeyPress(new KeyPressEventHandler(txtunitcost_KeyPress));
				((Control)_txtunitcost).add_KeyDown(new KeyEventHandler(txtunitcost_KeyDown));
				((Control)_txtunitcost).add_GotFocus((EventHandler)txtunitcost_GotFocus);
			}
		}
	}

	internal virtual TextBox txtstockvalue
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtstockvalue;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected O, but got Unknown
			if (_txtstockvalue != null)
			{
				((Control)_txtstockvalue).remove_TextChanged((EventHandler)txtstockvalue_TextChanged);
				((Control)_txtstockvalue).remove_LostFocus((EventHandler)txtstockvalue_LostFocus);
				((Control)_txtstockvalue).remove_KeyPress(new KeyPressEventHandler(txtstockvalue_KeyPress));
				((Control)_txtstockvalue).remove_KeyDown(new KeyEventHandler(txtstockvalue_KeyDown));
				((Control)_txtstockvalue).remove_GotFocus((EventHandler)txtstockvalue_GotFocus);
			}
			_txtstockvalue = value;
			if (_txtstockvalue != null)
			{
				((Control)_txtstockvalue).add_TextChanged((EventHandler)txtstockvalue_TextChanged);
				((Control)_txtstockvalue).add_LostFocus((EventHandler)txtstockvalue_LostFocus);
				((Control)_txtstockvalue).add_KeyPress(new KeyPressEventHandler(txtstockvalue_KeyPress));
				((Control)_txtstockvalue).add_KeyDown(new KeyEventHandler(txtstockvalue_KeyDown));
				((Control)_txtstockvalue).add_GotFocus((EventHandler)txtstockvalue_GotFocus);
			}
		}
	}

	internal virtual ComboBoxArray ComboBoxArray1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBoxArray1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBoxArray1 = value;
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
				((Control)_cmdGroupId).remove_GotFocus((EventHandler)cmdGroupId_GotFocus);
			}
			_cmdGroupId = value;
			if (_cmdGroupId != null)
			{
				((Control)_cmdGroupId).add_Enter((EventHandler)cmdGroupId_Enter);
				_cmdGroupId.add_ClickEvent((EventHandler)cmdGroupId_ClickEvent);
				((Control)_cmdGroupId).add_GotFocus((EventHandler)cmdGroupId_GotFocus);
			}
		}
	}

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual AxSSCommand cmdstockacref
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdstockacref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdstockacref != null)
			{
				((Control)_cmdstockacref).remove_Enter((EventHandler)cmdstockacref_Enter);
				_cmdstockacref.remove_ClickEvent((EventHandler)cmdstockacref_ClickEvent);
			}
			_cmdstockacref = value;
			if (_cmdstockacref != null)
			{
				((Control)_cmdstockacref).add_Enter((EventHandler)cmdstockacref_Enter);
				_cmdstockacref.add_ClickEvent((EventHandler)cmdstockacref_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdsalesacref
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdsalesacref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdsalesacref != null)
			{
				((Control)_cmdsalesacref).remove_Enter((EventHandler)cmdsalesacref_Enter);
				_cmdsalesacref.remove_ClickEvent((EventHandler)cmdsalesacref_ClickEvent);
			}
			_cmdsalesacref = value;
			if (_cmdsalesacref != null)
			{
				((Control)_cmdsalesacref).add_Enter((EventHandler)cmdsalesacref_Enter);
				_cmdsalesacref.add_ClickEvent((EventHandler)cmdsalesacref_ClickEvent);
			}
		}
	}

	internal virtual AxSSCommand cmdcogsacref
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdcogsacref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdcogsacref != null)
			{
				((Control)_cmdcogsacref).remove_Enter((EventHandler)cmdcogsacref_Enter);
				_cmdcogsacref.remove_ClickEvent((EventHandler)cmdcogsacref_ClickEvent);
			}
			_cmdcogsacref = value;
			if (_cmdcogsacref != null)
			{
				((Control)_cmdcogsacref).add_Enter((EventHandler)cmdcogsacref_Enter);
				_cmdcogsacref.add_ClickEvent((EventHandler)cmdcogsacref_ClickEvent);
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
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtGroupname != null)
			{
				((Control)_txtGroupname).remove_TextChanged((EventHandler)txtGroupname_TextChanged);
				((Control)_txtGroupname).remove_KeyDown(new KeyEventHandler(txtGroupname_KeyDown));
			}
			_txtGroupname = value;
			if (_txtGroupname != null)
			{
				((Control)_txtGroupname).add_TextChanged((EventHandler)txtGroupname_TextChanged);
				((Control)_txtGroupname).add_KeyDown(new KeyEventHandler(txtGroupname_KeyDown));
			}
		}
	}

	internal virtual TextBox txtStockAcname
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtStockAcname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtStockAcname != null)
			{
				((Control)_txtStockAcname).remove_TextChanged((EventHandler)txtStockAcname_TextChanged);
				((Control)_txtStockAcname).remove_KeyDown(new KeyEventHandler(txtStockAcname_KeyDown));
			}
			_txtStockAcname = value;
			if (_txtStockAcname != null)
			{
				((Control)_txtStockAcname).add_TextChanged((EventHandler)txtStockAcname_TextChanged);
				((Control)_txtStockAcname).add_KeyDown(new KeyEventHandler(txtStockAcname_KeyDown));
			}
		}
	}

	internal virtual TextBox txtSalesAcname
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSalesAcname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			if (_txtSalesAcname != null)
			{
				((Control)_txtSalesAcname).remove_TextChanged((EventHandler)txtSalesAcname_TextChanged);
				((Control)_txtSalesAcname).remove_KeyDown(new KeyEventHandler(txtSalesAcname_KeyDown));
			}
			_txtSalesAcname = value;
			if (_txtSalesAcname != null)
			{
				((Control)_txtSalesAcname).add_TextChanged((EventHandler)txtSalesAcname_TextChanged);
				((Control)_txtSalesAcname).add_KeyDown(new KeyEventHandler(txtSalesAcname_KeyDown));
			}
		}
	}

	internal virtual TextBox txtCogsAcname
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCogsAcname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_txtCogsAcname != null)
			{
				((Control)_txtCogsAcname).remove_TextChanged((EventHandler)txtCogsAcname_TextChanged);
			}
			_txtCogsAcname = value;
			if (_txtCogsAcname != null)
			{
				((Control)_txtCogsAcname).add_TextChanged((EventHandler)txtCogsAcname_TextChanged);
			}
		}
	}

	private virtual Cproduct objProduct
	{
		[DebuggerNonUserCode]
		get
		{
			return _objProduct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objProduct != null)
			{
				_objProduct.RecordExits -= objProduct_RecordExits;
				_objProduct.MoveForward -= objProduct_MoveForward;
				_objProduct.MoveBackward -= objProduct_MoveBackward;
				_objProduct.DataValidated -= objProduct_DataValidated;
				_objProduct.NoRecords -= objProduct_NoRecords;
			}
			_objProduct = value;
			if (_objProduct != null)
			{
				_objProduct.RecordExits += objProduct_RecordExits;
				_objProduct.MoveForward += objProduct_MoveForward;
				_objProduct.MoveBackward += objProduct_MoveBackward;
				_objProduct.DataValidated += objProduct_DataValidated;
				_objProduct.NoRecords += objProduct_NoRecords;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmProduct()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Control)this).add_KeyDown(new KeyEventHandler(frmProduct_KeyDown));
		((Form)this).add_Load((EventHandler)frmProduct_Load);
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
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected O, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected O, but got Unknown
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Expected O, but got Unknown
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected O, but got Unknown
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected O, but got Unknown
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Expected O, but got Unknown
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected O, but got Unknown
		//IL_1037: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Expected O, but got Unknown
		//IL_1076: Unknown result type (might be due to invalid IL or missing references)
		//IL_1080: Expected O, but got Unknown
		//IL_10fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Expected O, but got Unknown
		//IL_1166: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Expected O, but got Unknown
		//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11dc: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmProduct));
		txtUnits = new TextBox();
		chkService = new CheckBox();
		Label2 = new Label();
		Label1 = new Label();
		txtProductID = new TextBox();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
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
		Label12 = new Label();
		txtcogsacref = new TextBox();
		txtsalesacref = new TextBox();
		txtstockacref = new TextBox();
		txtProductNam = new TextBox();
		txtGroupid = new TextBox();
		txtPrice = new TextBox();
		txtstockqty = new TextBox();
		txtunitcost = new TextBox();
		txtstockvalue = new TextBox();
		ComboBoxArray1 = new ComboBoxArray(components);
		cmdGroupId = new AxSSCommand();
		ImageList1 = new ImageList(components);
		cmdstockacref = new AxSSCommand();
		cmdsalesacref = new AxSSCommand();
		cmdcogsacref = new AxSSCommand();
		txtGroupname = new TextBox();
		txtStockAcname = new TextBox();
		txtSalesAcname = new TextBox();
		txtCogsAcname = new TextBox();
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
		((ISupportInitialize)ComboBoxArray1).BeginInit();
		((ISupportInitialize)cmdGroupId).BeginInit();
		((ISupportInitialize)cmdstockacref).BeginInit();
		((ISupportInitialize)cmdsalesacref).BeginInit();
		((ISupportInitialize)cmdcogsacref).BeginInit();
		((Control)this).SuspendLayout();
		TextBox obj = txtUnits;
		Point location = new Point(164, 159);
		((Control)obj).set_Location(location);
		((Control)txtUnits).set_Name("txtUnits");
		TextBox obj2 = txtUnits;
		Size size = new Size(119, 20);
		((Control)obj2).set_Size(size);
		((Control)txtUnits).set_TabIndex(5);
		((ButtonBase)chkService).set_AutoSize(true);
		chkService.set_CheckAlign((ContentAlignment)1);
		CheckBox obj3 = chkService;
		location = new Point(164, 36);
		((Control)obj3).set_Location(location);
		((Control)chkService).set_Name("chkService");
		CheckBox obj4 = chkService;
		size = new Size(32, 17);
		((Control)obj4).set_Size(size);
		((Control)chkService).set_TabIndex(1);
		((ButtonBase)chkService).set_Text("  ");
		chkService.set_TextAlign((ContentAlignment)4);
		((ButtonBase)chkService).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		Label label = Label2;
		location = new Point(55, 94);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		size = new Size(75, 13);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(53);
		Label2.set_Text("Product Name");
		Label1.set_AutoSize(true);
		Label label3 = Label1;
		location = new Point(55, 68);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(58, 13);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(51);
		Label1.set_Text("Product ID");
		TextBox obj5 = txtProductID;
		location = new Point(164, 65);
		((Control)obj5).set_Location(location);
		((Control)txtProductID).set_Name("txtProductID");
		TextBox obj6 = txtProductID;
		size = new Size(119, 20);
		((Control)obj6).set_Size(size);
		((Control)txtProductID).set_TabIndex(2);
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(55, 120);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(76, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(61);
		Label3.set_Text("Product Group");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(55, 162);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(31, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(62);
		Label4.set_Text("Units");
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(55, 188);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(65, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(63);
		Label5.set_Text("Selling Price");
		Label6.set_AutoSize(true);
		Label label11 = Label6;
		location = new Point(55, 225);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(53, 13);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(64);
		Label6.set_Text("Unit Cost ");
		Label7.set_AutoSize(true);
		Label label13 = Label7;
		location = new Point(55, 251);
		((Control)label13).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label14 = Label7;
		size = new Size(54, 13);
		((Control)label14).set_Size(size);
		((Control)Label7).set_TabIndex(65);
		Label7.set_Text("Stock Qty");
		Label8.set_AutoSize(true);
		Label label15 = Label8;
		location = new Point(55, 277);
		((Control)label15).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label16 = Label8;
		size = new Size(65, 13);
		((Control)label16).set_Size(size);
		((Control)Label8).set_TabIndex(66);
		Label8.set_Text("Stock Value");
		Label9.set_AutoSize(true);
		Label label17 = Label9;
		location = new Point(55, 40);
		((Control)label17).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label18 = Label9;
		size = new Size(94, 13);
		((Control)label18).set_Size(size);
		((Control)Label9).set_TabIndex(67);
		Label9.set_Text("Product Is Service");
		Label10.set_AutoSize(true);
		Label label19 = Label10;
		location = new Point(55, 322);
		((Control)label19).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label20 = Label10;
		size = new Size(78, 13);
		((Control)label20).set_Size(size);
		((Control)Label10).set_TabIndex(71);
		Label10.set_Text("Stock Account");
		Label11.set_AutoSize(true);
		Label label21 = Label11;
		location = new Point(55, 349);
		((Control)label21).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label22 = Label11;
		size = new Size(75, 13);
		((Control)label22).set_Size(size);
		((Control)Label11).set_TabIndex(72);
		Label11.set_Text("Issue Account");
		AxSSCommand obj7 = cmdClose;
		location = new Point(487, 422);
		((Control)obj7).set_Location(location);
		((Control)cmdClose).set_Name("cmdClose");
		((AxHost)cmdClose).set_OcxState((State)componentResourceManager.GetObject("cmdClose.OcxState"));
		AxSSCommand obj8 = cmdClose;
		size = new Size(61, 24);
		((Control)obj8).set_Size(size);
		((Control)cmdClose).set_TabIndex(41);
		AxSSCommand obj9 = cmdLast;
		location = new Point(233, 422);
		((Control)obj9).set_Location(location);
		((Control)cmdLast).set_Name("cmdLast");
		((AxHost)cmdLast).set_OcxState((State)componentResourceManager.GetObject("cmdLast.OcxState"));
		AxSSCommand obj10 = cmdLast;
		size = new Size(61, 24);
		((Control)obj10).set_Size(size);
		((Control)cmdLast).set_TabIndex(40);
		AxSSCommand obj11 = cmdNext;
		location = new Point(160, 422);
		((Control)obj11).set_Location(location);
		((Control)cmdNext).set_Name("cmdNext");
		((AxHost)cmdNext).set_OcxState((State)componentResourceManager.GetObject("cmdNext.OcxState"));
		AxSSCommand obj12 = cmdNext;
		size = new Size(61, 24);
		((Control)obj12).set_Size(size);
		((Control)cmdNext).set_TabIndex(39);
		AxSSCommand obj13 = cmdPrevious;
		location = new Point(86, 422);
		((Control)obj13).set_Location(location);
		((Control)cmdPrevious).set_Name("cmdPrevious");
		((AxHost)cmdPrevious).set_OcxState((State)componentResourceManager.GetObject("cmdPrevious.OcxState"));
		AxSSCommand obj14 = cmdPrevious;
		size = new Size(61, 24);
		((Control)obj14).set_Size(size);
		((Control)cmdPrevious).set_TabIndex(38);
		AxSSCommand obj15 = cmdFirst;
		location = new Point(12, 422);
		((Control)obj15).set_Location(location);
		((Control)cmdFirst).set_Name("cmdFirst");
		((AxHost)cmdFirst).set_OcxState((State)componentResourceManager.GetObject("cmdFirst.OcxState"));
		AxSSCommand obj16 = cmdFirst;
		size = new Size(61, 24);
		((Control)obj16).set_Size(size);
		((Control)cmdFirst).set_TabIndex(37);
		AxSSCommand obj17 = cmdPrint;
		location = new Point(487, 222);
		((Control)obj17).set_Location(location);
		((Control)cmdPrint).set_Name("cmdPrint");
		((AxHost)cmdPrint).set_OcxState((State)componentResourceManager.GetObject("cmdPrint.OcxState"));
		AxSSCommand obj18 = cmdPrint;
		size = new Size(61, 24);
		((Control)obj18).set_Size(size);
		((Control)cmdPrint).set_TabIndex(36);
		AxSSCommand obj19 = cmdDelete;
		location = new Point(487, 188);
		((Control)obj19).set_Location(location);
		((Control)cmdDelete).set_Name("cmdDelete");
		((AxHost)cmdDelete).set_OcxState((State)componentResourceManager.GetObject("cmdDelete.OcxState"));
		AxSSCommand obj20 = cmdDelete;
		size = new Size(61, 24);
		((Control)obj20).set_Size(size);
		((Control)cmdDelete).set_TabIndex(35);
		AxSSCommand obj21 = cmdEdit;
		location = new Point(487, 154);
		((Control)obj21).set_Location(location);
		((Control)cmdEdit).set_Name("cmdEdit");
		((AxHost)cmdEdit).set_OcxState((State)componentResourceManager.GetObject("cmdEdit.OcxState"));
		AxSSCommand obj22 = cmdEdit;
		size = new Size(61, 24);
		((Control)obj22).set_Size(size);
		((Control)cmdEdit).set_TabIndex(34);
		AxSSCommand obj23 = cmdnew;
		location = new Point(487, 120);
		((Control)obj23).set_Location(location);
		((Control)cmdnew).set_Name("cmdnew");
		((AxHost)cmdnew).set_OcxState((State)componentResourceManager.GetObject("cmdnew.OcxState"));
		AxSSCommand obj24 = cmdnew;
		size = new Size(61, 24);
		((Control)obj24).set_Size(size);
		((Control)cmdnew).set_TabIndex(33);
		AxSSPanel axSSPanel = AxSSPanel1;
		location = new Point(12, 12);
		((Control)axSSPanel).set_Location(location);
		((Control)AxSSPanel1).set_Name("AxSSPanel1");
		((AxHost)AxSSPanel1).set_OcxState((State)componentResourceManager.GetObject("AxSSPanel1.OcxState"));
		AxSSPanel axSSPanel2 = AxSSPanel1;
		size = new Size(469, 404);
		((Control)axSSPanel2).set_Size(size);
		((Control)AxSSPanel1).set_TabIndex(42);
		Label12.set_AutoSize(true);
		Label label23 = Label12;
		location = new Point(55, 376);
		((Control)label23).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label24 = Label12;
		size = new Size(95, 13);
		((Control)label24).set_Size(size);
		((Control)Label12).set_TabIndex(73);
		Label12.set_Text("Purchase Account");
		TextBox obj25 = txtcogsacref;
		location = new Point(163, 366);
		((Control)obj25).set_Location(location);
		((Control)txtcogsacref).set_Name("txtcogsacref");
		TextBox obj26 = txtcogsacref;
		size = new Size(99, 20);
		((Control)obj26).set_Size(size);
		((Control)txtcogsacref).set_TabIndex(12);
		TextBox obj27 = txtsalesacref;
		location = new Point(163, 340);
		((Control)obj27).set_Location(location);
		((Control)txtsalesacref).set_Name("txtsalesacref");
		TextBox obj28 = txtsalesacref;
		size = new Size(99, 20);
		((Control)obj28).set_Size(size);
		((Control)txtsalesacref).set_TabIndex(11);
		TextBox obj29 = txtstockacref;
		location = new Point(163, 314);
		((Control)obj29).set_Location(location);
		((Control)txtstockacref).set_Name("txtstockacref");
		TextBox obj30 = txtstockacref;
		size = new Size(99, 20);
		((Control)obj30).set_Size(size);
		((Control)txtstockacref).set_TabIndex(10);
		TextBox obj31 = txtProductNam;
		location = new Point(164, 91);
		((Control)obj31).set_Location(location);
		((Control)txtProductNam).set_Name("txtProductNam");
		TextBox obj32 = txtProductNam;
		size = new Size(290, 20);
		((Control)obj32).set_Size(size);
		((Control)txtProductNam).set_TabIndex(3);
		TextBox obj33 = txtGroupid;
		location = new Point(164, 117);
		((Control)obj33).set_Location(location);
		((Control)txtGroupid).set_Name("txtGroupid");
		TextBox obj34 = txtGroupid;
		size = new Size(98, 20);
		((Control)obj34).set_Size(size);
		((Control)txtGroupid).set_TabIndex(4);
		TextBox obj35 = txtPrice;
		location = new Point(164, 185);
		((Control)obj35).set_Location(location);
		((Control)txtPrice).set_Name("txtPrice");
		TextBox obj36 = txtPrice;
		size = new Size(119, 20);
		((Control)obj36).set_Size(size);
		((Control)txtPrice).set_TabIndex(6);
		txtPrice.set_TextAlign((HorizontalAlignment)1);
		TextBox obj37 = txtstockqty;
		location = new Point(163, 248);
		((Control)obj37).set_Location(location);
		((Control)txtstockqty).set_Name("txtstockqty");
		TextBox obj38 = txtstockqty;
		size = new Size(120, 20);
		((Control)obj38).set_Size(size);
		((Control)txtstockqty).set_TabIndex(8);
		txtstockqty.set_TextAlign((HorizontalAlignment)1);
		TextBox obj39 = txtunitcost;
		location = new Point(164, 218);
		((Control)obj39).set_Location(location);
		((Control)txtunitcost).set_Name("txtunitcost");
		TextBox obj40 = txtunitcost;
		size = new Size(119, 20);
		((Control)obj40).set_Size(size);
		((Control)txtunitcost).set_TabIndex(7);
		txtunitcost.set_TextAlign((HorizontalAlignment)1);
		TextBox obj41 = txtstockvalue;
		location = new Point(164, 274);
		((Control)obj41).set_Location(location);
		((Control)txtstockvalue).set_Name("txtstockvalue");
		TextBox obj42 = txtstockvalue;
		size = new Size(119, 20);
		((Control)obj42).set_Size(size);
		((Control)txtstockvalue).set_TabIndex(9);
		txtstockvalue.set_TextAlign((HorizontalAlignment)1);
		AxSSCommand obj43 = cmdGroupId;
		location = new Point(255, 117);
		((Control)obj43).set_Location(location);
		((Control)cmdGroupId).set_Name("cmdGroupId");
		((AxHost)cmdGroupId).set_OcxState((State)componentResourceManager.GetObject("cmdGroupId.OcxState"));
		AxSSCommand obj44 = cmdGroupId;
		size = new Size(28, 20);
		((Control)obj44).set_Size(size);
		((Control)cmdGroupId).set_TabIndex(20);
		ImageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream"));
		ImageList1.set_TransparentColor(Color.Transparent);
		ImageList1.get_Images().SetKeyName(0, "VALET.BMP");
		ImageList1.get_Images().SetKeyName(1, "search.ico");
		AxSSCommand obj45 = cmdstockacref;
		location = new Point(255, 314);
		((Control)obj45).set_Location(location);
		((Control)cmdstockacref).set_Name("cmdstockacref");
		((AxHost)cmdstockacref).set_OcxState((State)componentResourceManager.GetObject("cmdstockacref.OcxState"));
		AxSSCommand obj46 = cmdstockacref;
		size = new Size(28, 20);
		((Control)obj46).set_Size(size);
		((Control)cmdstockacref).set_TabIndex(21);
		AxSSCommand obj47 = cmdsalesacref;
		location = new Point(255, 340);
		((Control)obj47).set_Location(location);
		((Control)cmdsalesacref).set_Name("cmdsalesacref");
		((AxHost)cmdsalesacref).set_OcxState((State)componentResourceManager.GetObject("cmdsalesacref.OcxState"));
		AxSSCommand obj48 = cmdsalesacref;
		size = new Size(28, 20);
		((Control)obj48).set_Size(size);
		((Control)cmdsalesacref).set_TabIndex(22);
		AxSSCommand obj49 = cmdcogsacref;
		location = new Point(255, 366);
		((Control)obj49).set_Location(location);
		((Control)cmdcogsacref).set_Name("cmdcogsacref");
		((AxHost)cmdcogsacref).set_OcxState((State)componentResourceManager.GetObject("cmdcogsacref.OcxState"));
		AxSSCommand obj50 = cmdcogsacref;
		size = new Size(28, 20);
		((Control)obj50).set_Size(size);
		((Control)cmdcogsacref).set_TabIndex(23);
		TextBox obj51 = txtGroupname;
		location = new Point(289, 117);
		((Control)obj51).set_Location(location);
		((Control)txtGroupname).set_Name("txtGroupname");
		TextBox obj52 = txtGroupname;
		size = new Size(165, 20);
		((Control)obj52).set_Size(size);
		((Control)txtGroupname).set_TabIndex(13);
		TextBox obj53 = txtStockAcname;
		location = new Point(289, 315);
		((Control)obj53).set_Location(location);
		((Control)txtStockAcname).set_Name("txtStockAcname");
		TextBox obj54 = txtStockAcname;
		size = new Size(165, 20);
		((Control)obj54).set_Size(size);
		((Control)txtStockAcname).set_TabIndex(14);
		TextBox obj55 = txtSalesAcname;
		location = new Point(289, 340);
		((Control)obj55).set_Location(location);
		((Control)txtSalesAcname).set_Name("txtSalesAcname");
		TextBox obj56 = txtSalesAcname;
		size = new Size(165, 20);
		((Control)obj56).set_Size(size);
		((Control)txtSalesAcname).set_TabIndex(15);
		TextBox obj57 = txtCogsAcname;
		location = new Point(289, 366);
		((Control)obj57).set_Location(location);
		((Control)txtCogsAcname).set_Name("txtCogsAcname");
		TextBox obj58 = txtCogsAcname;
		size = new Size(165, 20);
		((Control)obj58).set_Size(size);
		((Control)txtCogsAcname).set_TabIndex(16);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		size = new Size(558, 452);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)txtCogsAcname);
		((Control)this).get_Controls().Add((Control)(object)txtSalesAcname);
		((Control)this).get_Controls().Add((Control)(object)txtStockAcname);
		((Control)this).get_Controls().Add((Control)(object)txtGroupname);
		((Control)this).get_Controls().Add((Control)(object)cmdcogsacref);
		((Control)this).get_Controls().Add((Control)(object)cmdsalesacref);
		((Control)this).get_Controls().Add((Control)(object)cmdstockacref);
		((Control)this).get_Controls().Add((Control)(object)cmdGroupId);
		((Control)this).get_Controls().Add((Control)(object)txtstockvalue);
		((Control)this).get_Controls().Add((Control)(object)txtstockqty);
		((Control)this).get_Controls().Add((Control)(object)txtunitcost);
		((Control)this).get_Controls().Add((Control)(object)txtPrice);
		((Control)this).get_Controls().Add((Control)(object)txtGroupid);
		((Control)this).get_Controls().Add((Control)(object)txtProductNam);
		((Control)this).get_Controls().Add((Control)(object)txtcogsacref);
		((Control)this).get_Controls().Add((Control)(object)txtsalesacref);
		((Control)this).get_Controls().Add((Control)(object)txtstockacref);
		((Control)this).get_Controls().Add((Control)(object)Label12);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)txtUnits);
		((Control)this).get_Controls().Add((Control)(object)chkService);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtProductID);
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
		((Control)this).set_Name("frmProduct");
		((Form)this).set_Text("Products");
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
		((ISupportInitialize)ComboBoxArray1).EndInit();
		((ISupportInitialize)cmdGroupId).EndInit();
		((ISupportInitialize)cmdstockacref).EndInit();
		((ISupportInitialize)cmdsalesacref).EndInit();
		((ISupportInitialize)cmdcogsacref).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void cmdClose_ClickEvent(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void cmdClose_Enter(object sender, EventArgs e)
	{
	}

	private void cmdDelete_ClickEvent(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"You are about to delete this record.\r\nDo you want to proceed?", (MsgBoxStyle)68, (object)"Information");
		if (msgAns == 6L)
		{
			objProduct.Delete(txtProductID.get_Text());
			Refreshdata();
		}
	}

	private void cmdDelete_Enter(object sender, EventArgs e)
	{
	}

	private void frmProduct_KeyDown(object sender, KeyEventArgs e)
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

	private void frmProduct_Load(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		objProduct = new Cproduct();
		objProduct.Initialise(Startup.dBcon);
		dsgroup = new DataSet();
		dagroup = new SqlDataAdapter();
		dsledger = new DataSet();
		daledger = new SqlDataAdapter();
		StrSQL = "select * from productgroup order by productgroupid";
		StrSqlLedger = "select * from ledger order by acref";
		dagroup = new SqlDataAdapter(StrSQL, Startup.dBcon);
		((DbDataAdapter)(object)dagroup).FillSchema(dsgroup, SchemaType.Mapped, "productgroup");
		((DbDataAdapter)(object)dagroup).Fill(dsgroup, "productgroup");
		daledger = new SqlDataAdapter(StrSqlLedger, Startup.dBcon);
		((DbDataAdapter)(object)daledger).FillSchema(dsledger, SchemaType.Mapped, "ledger");
		((DbDataAdapter)(object)daledger).Fill(dsledger, "ledger");
		Refreshdata();
		viewmode();
		if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(objProduct.RecordCount, (object)1), (object)0, false))
		{
			objProduct_NoRecords();
		}
	}

	private void FormatThem()
	{
		txtPrice.set_Text(Strings.FormatNumber((object)txtPrice.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		txtstockqty.set_Text(Strings.FormatNumber((object)txtstockqty.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		txtunitcost.set_Text(Strings.FormatNumber((object)txtunitcost.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		txtstockvalue.set_Text(Strings.FormatNumber((object)txtstockvalue.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
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
		chkService.set_Checked(false);
		txtPrice.set_Text(Conversions.ToString(0));
		txtunitcost.set_Text(Conversions.ToString(0));
		txtstockqty.set_Text(Conversions.ToString(0));
		txtstockvalue.set_Text(Conversions.ToString(0));
		FormatThem();
	}

	private void viewmode()
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
					((TextBoxBase)val).set_ReadOnly(true);
					((TextBoxBase)val).set_BackColor(Color.White);
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
		((Control)chkService).set_Enabled(false);
		((ButtonBase)chkService).set_BackColor(Color.Transparent);
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
		cmdGroupId.set_Enabled(false);
		cmdstockacref.set_Enabled(false);
		cmdsalesacref.set_Enabled(false);
		cmdcogsacref.set_Enabled(false);
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
		((Control)chkService).set_Enabled(true);
		((ButtonBase)chkService).set_BackColor(Color.Transparent);
		((TextBoxBase)txtGroupname).set_ReadOnly(true);
		((TextBoxBase)txtGroupname).set_BackColor(Color.White);
		((TextBoxBase)txtCogsAcname).set_ReadOnly(true);
		((TextBoxBase)txtCogsAcname).set_BackColor(Color.White);
		((TextBoxBase)txtSalesAcname).set_ReadOnly(true);
		((TextBoxBase)txtSalesAcname).set_BackColor(Color.White);
		((TextBoxBase)txtStockAcname).set_ReadOnly(true);
		((TextBoxBase)txtStockAcname).set_BackColor(Color.White);
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
		cmdGroupId.set_Enabled(true);
		cmdstockacref.set_Enabled(true);
		cmdsalesacref.set_Enabled(true);
		cmdcogsacref.set_Enabled(true);
	}

	private void Refreshdata()
	{
		if (Operators.ConditionalCompareObjectEqual(objProduct.IsService, (object)true, false))
		{
			chkService.set_Checked(true);
		}
		else
		{
			chkService.set_Checked(false);
		}
		txtProductID.set_Text(Conversions.ToString(objProduct.ProductiD));
		txtProductNam.set_Text(Conversions.ToString(objProduct.ProductName));
		txtGroupid.set_Text(Conversions.ToString(objProduct.ProductGroupId));
		txtUnits.set_Text(Conversions.ToString(objProduct.Units));
		txtPrice.set_Text(Conversions.ToString(objProduct.SellingPrice1));
		txtunitcost.set_Text(Conversions.ToString(objProduct.Unitcost));
		txtstockqty.set_Text(Conversions.ToString(objProduct.StockQty));
		txtstockvalue.set_Text(Conversions.ToString(objProduct.Stockvalue));
		txtstockacref.set_Text(Conversions.ToString(objProduct.Stockacref));
		txtsalesacref.set_Text(Conversions.ToString(objProduct.Salesacref));
		txtcogsacref.set_Text(Conversions.ToString(objProduct.Cogsacref));
		FormatThem();
	}

	private void txtProductID_KeyDown(object sender, KeyEventArgs e)
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

	private void txtProductID_LostFocus(object sender, EventArgs e)
	{
		if ((Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0) & IsnewRecord)
		{
			objProduct.FindRecord(txtProductID.get_Text());
		}
	}

	private void txtProductID_TextChanged(object sender, EventArgs e)
	{
		objProduct.ProductiD = txtProductID.get_Text();
		ValidateNow();
	}

	private void txtProductNam_KeyDown(object sender, KeyEventArgs e)
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

	private void txtProductNam_TextChanged(object sender, EventArgs e)
	{
		objProduct.ProductName = txtProductNam.get_Text();
		ValidateNow();
	}

	private void AxSSPanel1_Enter(object sender, EventArgs e)
	{
	}

	private void CmbGroupID_KeyDown(object sender, KeyEventArgs e)
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

	private void CmbGroupID_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void txtUnits_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtUnits).SelectAll();
	}

	private void txtUnits_KeyDown(object sender, KeyEventArgs e)
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

	private void txtUnits_LostFocus(object sender, EventArgs e)
	{
	}

	private void txtUnits_TextChanged(object sender, EventArgs e)
	{
		objProduct.Units = txtUnits.get_Text();
		objProduct.IsValid();
	}

	private void CmbStockAcref_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		if (Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0 && (int)e.get_KeyCode() == 13)
		{
			((Control)this).SelectNextControl((Control)sender, true, false, false, true);
		}
	}

	private void CmbStockAcref_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void CmbSalesAcref_KeyDown(object sender, KeyEventArgs e)
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

	private void CmbSalesAcref_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void CmbCogsAcref_KeyDown(object sender, KeyEventArgs e)
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

	private void CmbCogsAcref_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void chkService_CheckedChanged(object sender, EventArgs e)
	{
		if (chkService.get_Checked())
		{
			objProduct.IsService = true;
		}
		else
		{
			objProduct.IsService = false;
		}
	}

	private void chkService_KeyDown(object sender, KeyEventArgs e)
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

	private void objProduct_DataValidated(bool blnIsValid)
	{
		cmdnew.set_Enabled(blnIsValid);
	}

	private void objProduct_MoveBackward(bool blnMoveBack)
	{
		cmdPrevious.set_Enabled(blnMoveBack);
		cmdFirst.set_Enabled(blnMoveBack);
	}

	private void objProduct_MoveForward(bool blnMoveForward)
	{
		cmdNext.set_Enabled(blnMoveForward);
		cmdLast.set_Enabled(blnMoveForward);
	}

	private void objProduct_NoRecords()
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

	private void objProduct_RecordExits()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"Product ID Already Exits.\r\nPlease Enter A Unique ID\r\nTo Continue", (MsgBoxStyle)69, (object)"Information");
		if (msgAns == 4L)
		{
			((Control)txtProductID).Focus();
			txtProductID.set_Text("");
		}
		else
		{
			cmdEdit.DoClick();
		}
	}

	private void cmdEdit_ClickEvent(object sender, EventArgs e)
	{
		if (Operators.CompareString(cmdEdit.get_Caption(), "&Edit", false) == 0)
		{
			IsnewRecord = false;
			editmode();
			((TextBoxBase)txtProductID).set_ReadOnly(true);
			((TextBoxBase)txtProductID).set_BackColor(Color.White);
			((Control)txtProductNam).Focus();
		}
		else
		{
			viewmode();
			objProduct.Initialise(Startup.dBcon);
			Refreshdata();
		}
	}

	private void cmdEdit_Enter(object sender, EventArgs e)
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
			((Control)txtProductID).Focus();
			cmdnew.set_Enabled(false);
		}
		else
		{
			objProduct.Save(IsnewRecord);
			Interaction.MsgBox((object)"Data Successfully Saved", (MsgBoxStyle)64, (object)"information");
			viewmode();
		}
	}

	private void cmdnew_Enter(object sender, EventArgs e)
	{
	}

	private void cmdFirst_ClickEvent(object sender, EventArgs e)
	{
		objProduct.MoveFirst();
		Refreshdata();
	}

	private void cmdFirst_Enter(object sender, EventArgs e)
	{
	}

	private void cmdPrevious_ClickEvent(object sender, EventArgs e)
	{
		objProduct.MovePrevious();
		Refreshdata();
	}

	private void cmdPrevious_Enter(object sender, EventArgs e)
	{
	}

	private void cmdNext_ClickEvent(object sender, EventArgs e)
	{
		objProduct.MoveNext();
		Refreshdata();
	}

	private void cmdNext_Enter(object sender, EventArgs e)
	{
	}

	private void cmdLast_ClickEvent(object sender, EventArgs e)
	{
		objProduct.MoveLast();
		Refreshdata();
	}

	private void cmdLast_Enter(object sender, EventArgs e)
	{
	}

	private void txtPrice_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtPrice).SelectAll();
	}

	private void txtPrice_KeyDown(object sender, KeyEventArgs e)
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

	private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.set_Handled(Trapkey(Conversions.ToString(Strings.Asc(e.get_KeyChar()))));
	}

	private void txtPrice_LostFocus(object sender, EventArgs e)
	{
		try
		{
			txtPrice.set_Text(Strings.FormatNumber((object)txtPrice.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)txtPrice).Focus();
			ProjectData.ClearProjectError();
		}
	}

	private bool Trapkey(string kcode)
	{
		if (((Conversions.ToDouble(kcode) >= 48.0) & (Conversions.ToDouble(kcode) <= 57.0)) | (Conversions.ToDouble(kcode) == 8.0) | (Conversions.ToDouble(kcode) == 46.0))
		{
			return false;
		}
		return true;
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

	private void txtPrice_ParentChanged(object sender, EventArgs e)
	{
	}

	private void txtPrice_TextChanged(object sender, EventArgs e)
	{
		Valtextbox(txtPrice);
		if (Operators.CompareString(txtPrice.get_Text(), "", false) == 0)
		{
			txtPrice.set_Text(Conversions.ToString(0));
		}
		objProduct.SellingPrice1 = Conversions.ToDouble(txtPrice.get_Text());
		ValidateNow();
	}

	private void txtunitcost_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtunitcost).SelectAll();
	}

	private void txtunitcost_KeyDown(object sender, KeyEventArgs e)
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

	private void txtunitcost_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.set_Handled(Trapkey(Conversions.ToString(Strings.Asc(e.get_KeyChar()))));
	}

	private void txtunitcost_LostFocus(object sender, EventArgs e)
	{
		try
		{
			txtunitcost.set_Text(Strings.FormatNumber((object)txtunitcost.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)txtunitcost).Focus();
			ProjectData.ClearProjectError();
		}
	}

	private void txtunitcost_TextChanged(object sender, EventArgs e)
	{
		Valtextbox(txtunitcost);
		if (Operators.CompareString(txtunitcost.get_Text(), "", false) == 0)
		{
			txtunitcost.set_Text(Conversions.ToString(0));
		}
		objProduct.Unitcost = Conversions.ToDouble(txtunitcost.get_Text());
		ValidateNow();
	}

	private void txtstockqty_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtstockqty).SelectAll();
	}

	private void txtstockqty_KeyDown(object sender, KeyEventArgs e)
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

	private void txtstockqty_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.set_Handled(Trapkey(Conversions.ToString(Strings.Asc(e.get_KeyChar()))));
	}

	private void txtstockqty_LostFocus(object sender, EventArgs e)
	{
		try
		{
			txtstockqty.set_Text(Strings.FormatNumber((object)txtstockqty.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)txtstockqty).Focus();
			ProjectData.ClearProjectError();
		}
	}

	private void txtstockqty_TextChanged(object sender, EventArgs e)
	{
		Valtextbox(txtstockqty);
		if (Operators.CompareString(cmdnew.get_Caption(), "Save", false) == 0)
		{
			if (Operators.CompareString(txtstockqty.get_Text(), "", false) == 0)
			{
				txtstockqty.set_Text(Conversions.ToString(0));
			}
			objProduct.StockQty = Conversions.ToDouble(txtstockqty.get_Text());
			objProduct.IsValid();
		}
	}

	private void txtstockvalue_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtstockvalue).SelectAll();
	}

	private void txtstockvalue_KeyDown(object sender, KeyEventArgs e)
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

	private void txtstockvalue_KeyPress(object sender, KeyPressEventArgs e)
	{
		e.set_Handled(Trapkey(Conversions.ToString(Strings.Asc(e.get_KeyChar()))));
	}

	private void txtstockvalue_LostFocus(object sender, EventArgs e)
	{
		try
		{
			txtstockvalue.set_Text(Strings.FormatNumber((object)txtstockvalue.get_Text(), 2, (TriState)(-2), (TriState)(-2), (TriState)(-2)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)txtstockvalue).Focus();
			ProjectData.ClearProjectError();
		}
	}

	private void txtstockvalue_TextChanged(object sender, EventArgs e)
	{
		Valtextbox(txtstockvalue);
		if (Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0)
		{
			if (Operators.CompareString(txtstockvalue.get_Text(), "", false) == 0)
			{
				txtstockvalue.set_Text(Conversions.ToString(0));
			}
			objProduct.Stockvalue = Conversions.ToDouble(txtstockvalue.get_Text());
		}
		ValidateNow();
	}

	private void cmdGroupId_ClickEvent(object sender, EventArgs e)
	{
		frmcommonlookup frmcommonlookup2 = new frmcommonlookup();
		nform = (Form)(object)this;
		frmcommonlookup2.InitialiseLookup(nform, txtGroupid, txtGroupname, "Productgroup", "productgroupid");
		((Form)frmcommonlookup2).Close();
		frmcommonlookup2 = null;
	}

	private void cmdGroupId_Enter(object sender, EventArgs e)
	{
	}

	private void cmdGroupId_GotFocus(object sender, EventArgs e)
	{
	}

	private void cmdstockacref_ClickEvent(object sender, EventArgs e)
	{
		frmcommonlookup frmcommonlookup2 = new frmcommonlookup();
		nform = (Form)(object)this;
		frmcommonlookup2.InitialiseLookup(nform, txtstockacref, txtStockAcname, "ledger", "acref");
		((Form)frmcommonlookup2).Close();
		frmcommonlookup2 = null;
	}

	private void cmdstockacref_Enter(object sender, EventArgs e)
	{
	}

	private void cmdsalesacref_ClickEvent(object sender, EventArgs e)
	{
		frmcommonlookup frmcommonlookup2 = new frmcommonlookup();
		nform = (Form)(object)this;
		frmcommonlookup2.InitialiseLookup(nform, txtsalesacref, txtSalesAcname, "ledger", "acref");
		((Form)frmcommonlookup2).Close();
		frmcommonlookup2 = null;
	}

	private void cmdsalesacref_Enter(object sender, EventArgs e)
	{
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

	private void txtGroupid_LostFocus(object sender, EventArgs e)
	{
	}

	private void txtGroupid_TextChanged(object sender, EventArgs e)
	{
		objProduct.ProductGroupId = txtGroupid.get_Text();
		try
		{
			nrowgroup = dsgroup.Tables["productgroup"]!.Rows.Find(txtGroupid.get_Text());
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
			txtGroupname.set_Text(nrowgroup["productgroup"].ToString());
		}
		ValidateNow();
	}

	protected override void Finalize()
	{
		((Component)this).Finalize();
	}

	private void cmdcogsacref_ClickEvent(object sender, EventArgs e)
	{
		frmcommonlookup frmcommonlookup2 = new frmcommonlookup();
		nform = (Form)(object)this;
		frmcommonlookup2.InitialiseLookup(nform, txtcogsacref, txtCogsAcname, "ledger", "acref");
		((Form)frmcommonlookup2).Close();
		frmcommonlookup2 = null;
	}

	private void cmdcogsacref_Enter(object sender, EventArgs e)
	{
	}

	private void txtstockacref_KeyDown(object sender, KeyEventArgs e)
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

	private void txtstockacref_TextChanged(object sender, EventArgs e)
	{
		objProduct.Stockacref = txtstockacref.get_Text();
		try
		{
			nrowledger = dsledger.Tables["ledger"]!.Rows.Find(txtstockacref.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (nrowledger == null)
		{
			txtStockAcname.set_Text("");
		}
		else
		{
			txtStockAcname.set_Text(nrowledger["Acname"].ToString());
		}
		ValidateNow();
	}

	private void txtsalesacref_KeyDown(object sender, KeyEventArgs e)
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

	private void txtsalesacref_TextChanged(object sender, EventArgs e)
	{
		objProduct.Salesacref = txtsalesacref.get_Text();
		try
		{
			nrowledger = dsledger.Tables["ledger"]!.Rows.Find(txtsalesacref.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (nrowledger == null)
		{
			txtSalesAcname.set_Text("");
		}
		else
		{
			txtSalesAcname.set_Text(nrowledger["Acname"].ToString());
		}
		ValidateNow();
	}

	private void txtcogsacref_KeyDown(object sender, KeyEventArgs e)
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

	private void txtcogsacref_KeyDown1(object sender, KeyEventArgs e)
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

	private void txtcogsacref_TextChanged(object sender, EventArgs e)
	{
		objProduct.Cogsacref = txtcogsacref.get_Text();
		try
		{
			nrowledger = dsledger.Tables["ledger"]!.Rows.Find(txtcogsacref.get_Text());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (nrowledger == null)
		{
			txtCogsAcname.set_Text("");
		}
		else
		{
			txtCogsAcname.set_Text(nrowledger["Acname"].ToString());
		}
		ValidateNow();
	}

	private void ValidateNow()
	{
		if (Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0)
		{
			objProduct.IsValid();
		}
	}

	private void txtGroupid_Validated(object sender, EventArgs e)
	{
		nrowgroup = dsgroup.Tables["productgroup"]!.Rows.Find(txtGroupid.get_Text());
		if (nrowgroup == null)
		{
			txtGroupname.set_Text("");
			txtGroupid.set_Text("");
			cmdGroupId.DoClick();
		}
		else
		{
			txtGroupname.set_Text(nrowgroup["productgroup"].ToString());
		}
	}

	private void txtstockacref_Validated(object sender, EventArgs e)
	{
		nrowledger = dsledger.Tables["ledger"]!.Rows.Find(txtstockacref.get_Text());
		if (nrowledger == null)
		{
			txtStockAcname.set_Text("");
			txtstockacref.set_Text("");
			cmdstockacref.DoClick();
		}
		else
		{
			txtStockAcname.set_Text(nrowledger["Acname"].ToString());
		}
	}

	private void txtsalesacref_Validated(object sender, EventArgs e)
	{
		nrowledger = dsledger.Tables["ledger"]!.Rows.Find(txtsalesacref.get_Text());
		if (nrowledger == null)
		{
			txtSalesAcname.set_Text("");
			txtsalesacref.set_Text("");
			cmdsalesacref.DoClick();
		}
		else
		{
			txtSalesAcname.set_Text(nrowledger["Acname"].ToString());
		}
	}

	private void txtcogsacref_Validated(object sender, EventArgs e)
	{
		nrowledger = dsledger.Tables["ledger"]!.Rows.Find(txtcogsacref.get_Text());
		if (nrowledger == null)
		{
			txtCogsAcname.set_Text("");
			txtcogsacref.set_Text("");
			cmdcogsacref.DoClick();
		}
		else
		{
			txtCogsAcname.set_Text(nrowledger["Acname"].ToString());
		}
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

	private void txtGroupname_TextChanged(object sender, EventArgs e)
	{
	}

	private void txtStockAcname_KeyDown(object sender, KeyEventArgs e)
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

	private void txtStockAcname_TextChanged(object sender, EventArgs e)
	{
	}

	private void txtSalesAcname_KeyDown(object sender, KeyEventArgs e)
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

	private void txtSalesAcname_TextChanged(object sender, EventArgs e)
	{
	}

	private void txtCogsAcname_KeyDown(object sender, KeyEventArgs e)
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

	private void txtCogsAcname_TextChanged(object sender, EventArgs e)
	{
	}
}

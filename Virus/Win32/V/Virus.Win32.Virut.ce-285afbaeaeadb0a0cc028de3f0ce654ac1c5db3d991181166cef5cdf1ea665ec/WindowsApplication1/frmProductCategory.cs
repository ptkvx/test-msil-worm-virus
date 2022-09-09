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
public class frmProductCategory : Form
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

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtCategoryName")]
	private TextBox _txtCategoryName;

	[AccessedThroughProperty("txtProductCategoryId")]
	private TextBox _txtProductCategoryId;

	[AccessedThroughProperty("AxSSPanel1")]
	private AxSSPanel _AxSSPanel1;

	[AccessedThroughProperty("objProductCategory")]
	private CproductCategory _objProductCategory;

	private long msgAns;

	public bool IsnewRecord;

	private Control MyControl;

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
			}
			_cmdEdit = value;
			if (_cmdEdit != null)
			{
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
				_cmdnew.remove_ClickEvent((EventHandler)cmdnew_ClickEvent);
			}
			_cmdnew = value;
			if (_cmdnew != null)
			{
				_cmdnew.add_ClickEvent((EventHandler)cmdnew_ClickEvent);
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

	internal virtual TextBox txtCategoryName
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCategoryName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtCategoryName != null)
			{
				((Control)_txtCategoryName).remove_TextChanged((EventHandler)txtCategoryName_TextChanged);
				((Control)_txtCategoryName).remove_KeyDown(new KeyEventHandler(txtCategoryName_KeyDown));
				((Control)_txtCategoryName).remove_GotFocus((EventHandler)txtCategoryName_GotFocus);
			}
			_txtCategoryName = value;
			if (_txtCategoryName != null)
			{
				((Control)_txtCategoryName).add_TextChanged((EventHandler)txtCategoryName_TextChanged);
				((Control)_txtCategoryName).add_KeyDown(new KeyEventHandler(txtCategoryName_KeyDown));
				((Control)_txtCategoryName).add_GotFocus((EventHandler)txtCategoryName_GotFocus);
			}
		}
	}

	internal virtual TextBox txtProductCategoryId
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtProductCategoryId;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			if (_txtProductCategoryId != null)
			{
				((Control)_txtProductCategoryId).remove_KeyDown(new KeyEventHandler(txtProductCategoryId_KeyDown));
				((Control)_txtProductCategoryId).remove_GotFocus((EventHandler)txtProductCategoryId_GotFocus);
				((Control)_txtProductCategoryId).remove_TextChanged((EventHandler)txtProductCategoryId_TextChanged);
				((Control)_txtProductCategoryId).remove_LostFocus((EventHandler)txtProductCategoryId_LostFocus);
			}
			_txtProductCategoryId = value;
			if (_txtProductCategoryId != null)
			{
				((Control)_txtProductCategoryId).add_KeyDown(new KeyEventHandler(txtProductCategoryId_KeyDown));
				((Control)_txtProductCategoryId).add_GotFocus((EventHandler)txtProductCategoryId_GotFocus);
				((Control)_txtProductCategoryId).add_TextChanged((EventHandler)txtProductCategoryId_TextChanged);
				((Control)_txtProductCategoryId).add_LostFocus((EventHandler)txtProductCategoryId_LostFocus);
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
			_AxSSPanel1 = value;
		}
	}

	private virtual CproductCategory objProductCategory
	{
		[DebuggerNonUserCode]
		get
		{
			return _objProductCategory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objProductCategory != null)
			{
				_objProductCategory.MoveForward -= objProductCategory_MoveForward;
				_objProductCategory.MoveBackward -= objProductCategory_MoveBackward;
				_objProductCategory.DataValidated -= objProductCategory_DataValidated;
				_objProductCategory.NoRecords -= objProductCategory_NoRecords;
				_objProductCategory.RecordExits -= objProductCategory_RecordExits;
			}
			_objProductCategory = value;
			if (_objProductCategory != null)
			{
				_objProductCategory.MoveForward += objProductCategory_MoveForward;
				_objProductCategory.MoveBackward += objProductCategory_MoveBackward;
				_objProductCategory.DataValidated += objProductCategory_DataValidated;
				_objProductCategory.NoRecords += objProductCategory_NoRecords;
				_objProductCategory.RecordExits += objProductCategory_RecordExits;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmProductCategory()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmProductCategory_FormClosing));
		((Form)this).add_Load((EventHandler)frmProductCategory_Load);
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
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmProductCategory));
		Label2 = new Label();
		Label1 = new Label();
		txtCategoryName = new TextBox();
		txtProductCategoryId = new TextBox();
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
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.InactiveCaptionText);
		Label label = Label2;
		Point location = new Point(33, 80);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		Size size = new Size(52, 13);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(28);
		Label2.set_Text("Category ");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(SystemColors.InactiveCaptionText);
		Label label3 = Label1;
		location = new Point(33, 50);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(63, 13);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(27);
		Label1.set_Text("Category ID");
		TextBox obj = txtCategoryName;
		location = new Point(102, 80);
		((Control)obj).set_Location(location);
		((Control)txtCategoryName).set_Name("txtCategoryName");
		TextBox obj2 = txtCategoryName;
		size = new Size(185, 20);
		((Control)obj2).set_Size(size);
		((Control)txtCategoryName).set_TabIndex(26);
		TextBox obj3 = txtProductCategoryId;
		location = new Point(102, 47);
		((Control)obj3).set_Location(location);
		((Control)txtProductCategoryId).set_Name("txtProductCategoryId");
		TextBox obj4 = txtProductCategoryId;
		size = new Size(119, 20);
		((Control)obj4).set_Size(size);
		((Control)txtProductCategoryId).set_TabIndex(25);
		AxSSCommand obj5 = cmdClose;
		location = new Point(323, 161);
		((Control)obj5).set_Location(location);
		((Control)cmdClose).set_Name("cmdClose");
		((AxHost)cmdClose).set_OcxState((State)componentResourceManager.GetObject("cmdClose.OcxState"));
		AxSSCommand obj6 = cmdClose;
		size = new Size(61, 24);
		((Control)obj6).set_Size(size);
		((Control)cmdClose).set_TabIndex(37);
		AxSSCommand obj7 = cmdLast;
		location = new Point(233, 161);
		((Control)obj7).set_Location(location);
		((Control)cmdLast).set_Name("cmdLast");
		((AxHost)cmdLast).set_OcxState((State)componentResourceManager.GetObject("cmdLast.OcxState"));
		AxSSCommand obj8 = cmdLast;
		size = new Size(61, 24);
		((Control)obj8).set_Size(size);
		((Control)cmdLast).set_TabIndex(36);
		AxSSCommand obj9 = cmdNext;
		location = new Point(160, 161);
		((Control)obj9).set_Location(location);
		((Control)cmdNext).set_Name("cmdNext");
		((AxHost)cmdNext).set_OcxState((State)componentResourceManager.GetObject("cmdNext.OcxState"));
		AxSSCommand obj10 = cmdNext;
		size = new Size(61, 24);
		((Control)obj10).set_Size(size);
		((Control)cmdNext).set_TabIndex(35);
		AxSSCommand obj11 = cmdPrevious;
		location = new Point(86, 161);
		((Control)obj11).set_Location(location);
		((Control)cmdPrevious).set_Name("cmdPrevious");
		((AxHost)cmdPrevious).set_OcxState((State)componentResourceManager.GetObject("cmdPrevious.OcxState"));
		AxSSCommand obj12 = cmdPrevious;
		size = new Size(61, 24);
		((Control)obj12).set_Size(size);
		((Control)cmdPrevious).set_TabIndex(34);
		AxSSCommand obj13 = cmdFirst;
		location = new Point(12, 161);
		((Control)obj13).set_Location(location);
		((Control)cmdFirst).set_Name("cmdFirst");
		((AxHost)cmdFirst).set_OcxState((State)componentResourceManager.GetObject("cmdFirst.OcxState"));
		AxSSCommand obj14 = cmdFirst;
		size = new Size(61, 24);
		((Control)obj14).set_Size(size);
		((Control)cmdFirst).set_TabIndex(33);
		AxSSCommand obj15 = cmdPrint;
		location = new Point(323, 114);
		((Control)obj15).set_Location(location);
		((Control)cmdPrint).set_Name("cmdPrint");
		((AxHost)cmdPrint).set_OcxState((State)componentResourceManager.GetObject("cmdPrint.OcxState"));
		AxSSCommand obj16 = cmdPrint;
		size = new Size(61, 24);
		((Control)obj16).set_Size(size);
		((Control)cmdPrint).set_TabIndex(32);
		AxSSCommand obj17 = cmdDelete;
		location = new Point(323, 80);
		((Control)obj17).set_Location(location);
		((Control)cmdDelete).set_Name("cmdDelete");
		((AxHost)cmdDelete).set_OcxState((State)componentResourceManager.GetObject("cmdDelete.OcxState"));
		AxSSCommand obj18 = cmdDelete;
		size = new Size(61, 24);
		((Control)obj18).set_Size(size);
		((Control)cmdDelete).set_TabIndex(31);
		AxSSCommand obj19 = cmdEdit;
		location = new Point(323, 46);
		((Control)obj19).set_Location(location);
		((Control)cmdEdit).set_Name("cmdEdit");
		((AxHost)cmdEdit).set_OcxState((State)componentResourceManager.GetObject("cmdEdit.OcxState"));
		AxSSCommand obj20 = cmdEdit;
		size = new Size(61, 24);
		((Control)obj20).set_Size(size);
		((Control)cmdEdit).set_TabIndex(30);
		AxSSCommand obj21 = cmdnew;
		location = new Point(323, 12);
		((Control)obj21).set_Location(location);
		((Control)cmdnew).set_Name("cmdnew");
		((AxHost)cmdnew).set_OcxState((State)componentResourceManager.GetObject("cmdnew.OcxState"));
		AxSSCommand obj22 = cmdnew;
		size = new Size(61, 24);
		((Control)obj22).set_Size(size);
		((Control)cmdnew).set_TabIndex(29);
		AxSSPanel axSSPanel = AxSSPanel1;
		location = new Point(12, 12);
		((Control)axSSPanel).set_Location(location);
		((Control)AxSSPanel1).set_Name("AxSSPanel1");
		((AxHost)AxSSPanel1).set_OcxState((State)componentResourceManager.GetObject("AxSSPanel1.OcxState"));
		AxSSPanel axSSPanel2 = AxSSPanel1;
		size = new Size(305, 143);
		((Control)axSSPanel2).set_Size(size);
		((Control)AxSSPanel1).set_TabIndex(24);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		size = new Size(396, 195);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)cmdClose);
		((Control)this).get_Controls().Add((Control)(object)cmdLast);
		((Control)this).get_Controls().Add((Control)(object)cmdNext);
		((Control)this).get_Controls().Add((Control)(object)cmdPrevious);
		((Control)this).get_Controls().Add((Control)(object)cmdFirst);
		((Control)this).get_Controls().Add((Control)(object)cmdPrint);
		((Control)this).get_Controls().Add((Control)(object)cmdDelete);
		((Control)this).get_Controls().Add((Control)(object)cmdEdit);
		((Control)this).get_Controls().Add((Control)(object)cmdnew);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)txtCategoryName);
		((Control)this).get_Controls().Add((Control)(object)txtProductCategoryId);
		((Control)this).get_Controls().Add((Control)(object)AxSSPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmProductCategory");
		((Form)this).set_Text("Product Category");
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

	private void frmProductCategory_FormClosing(object sender, FormClosingEventArgs e)
	{
		objProductCategory = null;
	}

	private void frmProductCategory_Load(object sender, EventArgs e)
	{
		objProductCategory = new CproductCategory();
		objProductCategory.Initialise(Startup.dBcon);
		Refreshdata();
		viewmode();
		if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(objProductCategory.RecordCount, (object)1), (object)0, false))
		{
			objProductCategory_NoRecords();
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
		txtProductCategoryId.set_Text(Conversions.ToString(objProductCategory.CategoryID));
		txtCategoryName.set_Text(Conversions.ToString(objProductCategory.CategoryName));
	}

	private void cmdClose_ClickEvent(object sender, EventArgs e)
	{
		objProductCategory = null;
		((Form)this).Close();
	}

	private void cmdNext_ClickEvent(object sender, EventArgs e)
	{
		objProductCategory.MoveNext();
		Refreshdata();
	}

	private void cmdPrevious_ClickEvent(object sender, EventArgs e)
	{
		objProductCategory.MovePrevious();
		Refreshdata();
	}

	private void cmdFirst_ClickEvent(object sender, EventArgs e)
	{
		objProductCategory.MoveFirst();
		Refreshdata();
	}

	private void cmdLast_ClickEvent(object sender, EventArgs e)
	{
		objProductCategory.MoveLast();
		Refreshdata();
	}

	private void objProductCategory_DataValidated(bool blnIsValid)
	{
		cmdnew.set_Enabled(blnIsValid);
	}

	private void objProductCategory_MoveBackward(bool blnMoveBack)
	{
		cmdFirst.set_Enabled(blnMoveBack);
		cmdPrevious.set_Enabled(blnMoveBack);
	}

	private void objProductCategory_MoveForward(bool blnMoveForward)
	{
		cmdNext.set_Enabled(blnMoveForward);
		cmdLast.set_Enabled(blnMoveForward);
	}

	private void cmdEdit_ClickEvent(object sender, EventArgs e)
	{
		if (Operators.CompareString(cmdEdit.get_Caption(), "&Edit", false) == 0)
		{
			IsnewRecord = false;
			editmode();
			((TextBoxBase)txtProductCategoryId).set_ReadOnly(true);
			((TextBoxBase)txtProductCategoryId).set_BackColor(Color.White);
			((Control)txtCategoryName).Focus();
		}
		else
		{
			viewmode();
			objProductCategory.Initialise(Startup.dBcon);
			Refreshdata();
		}
	}

	private void cmdnew_ClickEvent(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(cmdnew.get_Caption(), "&New", false) == 0)
		{
			IsnewRecord = true;
			ClearData();
			editmode();
			((Control)txtProductCategoryId).Focus();
			cmdnew.set_Enabled(false);
		}
		else
		{
			objProductCategory.Save(IsnewRecord);
			Interaction.MsgBox((object)"Data Successfully Saved", (MsgBoxStyle)64, (object)"information");
			viewmode();
		}
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

	private void txtProductCategoryId_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtProductCategoryId).SelectAll();
	}

	private void txtProductCategoryId_KeyDown(object sender, KeyEventArgs e)
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

	private void txtProductCategoryId_LostFocus(object sender, EventArgs e)
	{
		if ((Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0) & IsnewRecord)
		{
			objProductCategory.FindRecord(txtProductCategoryId.get_Text());
		}
	}

	private void txtProductCategoryId_TextChanged(object sender, EventArgs e)
	{
		objProductCategory.CategoryID = txtProductCategoryId.get_Text();
		objProductCategory.IsValid();
	}

	private void txtCategoryName_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtCategoryName).SelectAll();
	}

	private void txtCategoryName_KeyDown(object sender, KeyEventArgs e)
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

	private void txtCategoryName_TextChanged(object sender, EventArgs e)
	{
		objProductCategory.CategoryName = txtCategoryName.get_Text();
		objProductCategory.IsValid();
	}

	private void cmdDelete_ClickEvent(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"You are about to delete this record.\r\nDo you want to proceed?", (MsgBoxStyle)68, (object)"Information");
		if (msgAns == 6L)
		{
			objProductCategory.Delete(txtProductCategoryId.get_Text());
			Refreshdata();
		}
	}

	private void objProductCategory_NoRecords()
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

	private void objProductCategory_RecordExits()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"Category ID Already Exits", (MsgBoxStyle)69, (object)"Information");
		if (msgAns == 4L)
		{
			((Control)txtProductCategoryId).Focus();
		}
		else
		{
			cmdEdit.DoClick();
		}
	}

	private void cmdDelete_Enter(object sender, EventArgs e)
	{
	}

	private void cmdClose_Enter(object sender, EventArgs e)
	{
	}
}

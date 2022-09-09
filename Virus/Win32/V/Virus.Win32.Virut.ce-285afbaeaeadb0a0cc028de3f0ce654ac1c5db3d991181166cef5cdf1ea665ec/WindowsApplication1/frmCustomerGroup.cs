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
public class frmCustomerGroup : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ImgButtons")]
	private ImageList _ImgButtons;

	[AccessedThroughProperty("ToolTip1")]
	private ToolTip _ToolTip1;

	[AccessedThroughProperty("AxSSPanel1")]
	private AxSSPanel _AxSSPanel1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtCategoryName")]
	private TextBox _txtCategoryName;

	[AccessedThroughProperty("txtcategoryId")]
	private TextBox _txtcategoryId;

	[AccessedThroughProperty("cmdnew")]
	private AxSSCommand _cmdnew;

	[AccessedThroughProperty("cmdEdit")]
	private AxSSCommand _cmdEdit;

	[AccessedThroughProperty("cmdPrint")]
	private AxSSCommand _cmdPrint;

	[AccessedThroughProperty("cmdDelete")]
	private AxSSCommand _cmdDelete;

	[AccessedThroughProperty("cmdFirst")]
	private AxSSCommand _cmdFirst;

	[AccessedThroughProperty("cmdPrevious")]
	private AxSSCommand _cmdPrevious;

	[AccessedThroughProperty("cmdNext")]
	private AxSSCommand _cmdNext;

	[AccessedThroughProperty("cmdLast")]
	private AxSSCommand _cmdLast;

	[AccessedThroughProperty("cmdClose")]
	private AxSSCommand _cmdClose;

	[AccessedThroughProperty("objCustomerCategory")]
	private Ccustomercategory _objCustomerCategory;

	private long msgAns;

	public bool IsnewRecord;

	private Control MyControl;

	internal virtual ImageList ImgButtons
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImgButtons;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImgButtons = value;
		}
	}

	internal virtual ToolTip ToolTip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTip1 = value;
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

	internal virtual TextBox txtcategoryId
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtcategoryId;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			if (_txtcategoryId != null)
			{
				((Control)_txtcategoryId).remove_TextChanged((EventHandler)txtcategoryId_TextChanged);
				((Control)_txtcategoryId).remove_LostFocus((EventHandler)txtcategoryId_LostFocus);
				((Control)_txtcategoryId).remove_KeyDown(new KeyEventHandler(txtcategoryId_KeyDown));
				((Control)_txtcategoryId).remove_GotFocus((EventHandler)txtcategoryId_GotFocus);
			}
			_txtcategoryId = value;
			if (_txtcategoryId != null)
			{
				((Control)_txtcategoryId).add_TextChanged((EventHandler)txtcategoryId_TextChanged);
				((Control)_txtcategoryId).add_LostFocus((EventHandler)txtcategoryId_LostFocus);
				((Control)_txtcategoryId).add_KeyDown(new KeyEventHandler(txtcategoryId_KeyDown));
				((Control)_txtcategoryId).add_GotFocus((EventHandler)txtcategoryId_GotFocus);
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

	private virtual Ccustomercategory objCustomerCategory
	{
		[DebuggerNonUserCode]
		get
		{
			return _objCustomerCategory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_objCustomerCategory != null)
			{
				_objCustomerCategory.NoRecords -= objCustomerCategory_NoRecords;
				_objCustomerCategory.RecordExits -= objCustomerCategory_RecordExits;
				_objCustomerCategory.MoveForward -= objCustomerCategory_MoveForward;
				_objCustomerCategory.MoveBackward -= objCustomerCategory_MoveBackward;
				_objCustomerCategory.DataValidated -= objCustomerCategory_DataValidated;
			}
			_objCustomerCategory = value;
			if (_objCustomerCategory != null)
			{
				_objCustomerCategory.NoRecords += objCustomerCategory_NoRecords;
				_objCustomerCategory.RecordExits += objCustomerCategory_RecordExits;
				_objCustomerCategory.MoveForward += objCustomerCategory_MoveForward;
				_objCustomerCategory.MoveBackward += objCustomerCategory_MoveBackward;
				_objCustomerCategory.DataValidated += objCustomerCategory_DataValidated;
			}
		}
	}

	[DebuggerNonUserCode]
	public frmCustomerGroup()
	{
		((Form)this).add_Load((EventHandler)frmCustomerGroup_Load);
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCustomerGroup));
		ImgButtons = new ImageList(components);
		ToolTip1 = new ToolTip(components);
		AxSSPanel1 = new AxSSPanel();
		Label2 = new Label();
		Label1 = new Label();
		txtCategoryName = new TextBox();
		txtcategoryId = new TextBox();
		cmdnew = new AxSSCommand();
		cmdEdit = new AxSSCommand();
		cmdPrint = new AxSSCommand();
		cmdDelete = new AxSSCommand();
		cmdFirst = new AxSSCommand();
		cmdPrevious = new AxSSCommand();
		cmdNext = new AxSSCommand();
		cmdLast = new AxSSCommand();
		cmdClose = new AxSSCommand();
		((ISupportInitialize)AxSSPanel1).BeginInit();
		((ISupportInitialize)cmdnew).BeginInit();
		((ISupportInitialize)cmdEdit).BeginInit();
		((ISupportInitialize)cmdPrint).BeginInit();
		((ISupportInitialize)cmdDelete).BeginInit();
		((ISupportInitialize)cmdFirst).BeginInit();
		((ISupportInitialize)cmdPrevious).BeginInit();
		((ISupportInitialize)cmdNext).BeginInit();
		((ISupportInitialize)cmdLast).BeginInit();
		((ISupportInitialize)cmdClose).BeginInit();
		((Control)this).SuspendLayout();
		ImgButtons.set_ColorDepth((ColorDepth)8);
		ImageList imgButtons = ImgButtons;
		Size imageSize = new Size(16, 16);
		imgButtons.set_ImageSize(imageSize);
		ImgButtons.set_TransparentColor(Color.Transparent);
		AxSSPanel axSSPanel = AxSSPanel1;
		Point location = new Point(12, 12);
		((Control)axSSPanel).set_Location(location);
		((Control)AxSSPanel1).set_Name("AxSSPanel1");
		((AxHost)AxSSPanel1).set_OcxState((State)componentResourceManager.GetObject("AxSSPanel1.OcxState"));
		AxSSPanel axSSPanel2 = AxSSPanel1;
		imageSize = new Size(298, 143);
		((Control)axSSPanel2).set_Size(imageSize);
		((Control)AxSSPanel1).set_TabIndex(10);
		Label2.set_AutoSize(true);
		Label label = Label2;
		location = new Point(33, 80);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		imageSize = new Size(52, 13);
		((Control)label2).set_Size(imageSize);
		((Control)Label2).set_TabIndex(14);
		Label2.set_Text("Category ");
		Label1.set_AutoSize(true);
		Label label3 = Label1;
		location = new Point(33, 50);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		imageSize = new Size(63, 13);
		((Control)label4).set_Size(imageSize);
		((Control)Label1).set_TabIndex(13);
		Label1.set_Text("Category ID");
		TextBox obj = txtCategoryName;
		location = new Point(102, 80);
		((Control)obj).set_Location(location);
		((Control)txtCategoryName).set_Name("txtCategoryName");
		TextBox obj2 = txtCategoryName;
		imageSize = new Size(185, 20);
		((Control)obj2).set_Size(imageSize);
		((Control)txtCategoryName).set_TabIndex(12);
		TextBox obj3 = txtcategoryId;
		location = new Point(102, 47);
		((Control)obj3).set_Location(location);
		((Control)txtcategoryId).set_Name("txtcategoryId");
		TextBox obj4 = txtcategoryId;
		imageSize = new Size(119, 20);
		((Control)obj4).set_Size(imageSize);
		((Control)txtcategoryId).set_TabIndex(11);
		AxSSCommand obj5 = cmdnew;
		location = new Point(316, 12);
		((Control)obj5).set_Location(location);
		((Control)cmdnew).set_Name("cmdnew");
		((AxHost)cmdnew).set_OcxState((State)componentResourceManager.GetObject("cmdnew.OcxState"));
		AxSSCommand obj6 = cmdnew;
		imageSize = new Size(61, 24);
		((Control)obj6).set_Size(imageSize);
		((Control)cmdnew).set_TabIndex(15);
		AxSSCommand obj7 = cmdEdit;
		location = new Point(316, 46);
		((Control)obj7).set_Location(location);
		((Control)cmdEdit).set_Name("cmdEdit");
		((AxHost)cmdEdit).set_OcxState((State)componentResourceManager.GetObject("cmdEdit.OcxState"));
		AxSSCommand obj8 = cmdEdit;
		imageSize = new Size(61, 24);
		((Control)obj8).set_Size(imageSize);
		((Control)cmdEdit).set_TabIndex(16);
		AxSSCommand obj9 = cmdPrint;
		location = new Point(316, 114);
		((Control)obj9).set_Location(location);
		((Control)cmdPrint).set_Name("cmdPrint");
		((AxHost)cmdPrint).set_OcxState((State)componentResourceManager.GetObject("cmdPrint.OcxState"));
		AxSSCommand obj10 = cmdPrint;
		imageSize = new Size(61, 24);
		((Control)obj10).set_Size(imageSize);
		((Control)cmdPrint).set_TabIndex(18);
		AxSSCommand obj11 = cmdDelete;
		location = new Point(316, 80);
		((Control)obj11).set_Location(location);
		((Control)cmdDelete).set_Name("cmdDelete");
		((AxHost)cmdDelete).set_OcxState((State)componentResourceManager.GetObject("cmdDelete.OcxState"));
		AxSSCommand obj12 = cmdDelete;
		imageSize = new Size(61, 24);
		((Control)obj12).set_Size(imageSize);
		((Control)cmdDelete).set_TabIndex(17);
		AxSSCommand obj13 = cmdFirst;
		location = new Point(12, 161);
		((Control)obj13).set_Location(location);
		((Control)cmdFirst).set_Name("cmdFirst");
		((AxHost)cmdFirst).set_OcxState((State)componentResourceManager.GetObject("cmdFirst.OcxState"));
		AxSSCommand obj14 = cmdFirst;
		imageSize = new Size(61, 24);
		((Control)obj14).set_Size(imageSize);
		((Control)cmdFirst).set_TabIndex(19);
		AxSSCommand obj15 = cmdPrevious;
		location = new Point(86, 161);
		((Control)obj15).set_Location(location);
		((Control)cmdPrevious).set_Name("cmdPrevious");
		((AxHost)cmdPrevious).set_OcxState((State)componentResourceManager.GetObject("cmdPrevious.OcxState"));
		AxSSCommand obj16 = cmdPrevious;
		imageSize = new Size(61, 24);
		((Control)obj16).set_Size(imageSize);
		((Control)cmdPrevious).set_TabIndex(20);
		AxSSCommand obj17 = cmdNext;
		location = new Point(160, 161);
		((Control)obj17).set_Location(location);
		((Control)cmdNext).set_Name("cmdNext");
		((AxHost)cmdNext).set_OcxState((State)componentResourceManager.GetObject("cmdNext.OcxState"));
		AxSSCommand obj18 = cmdNext;
		imageSize = new Size(61, 24);
		((Control)obj18).set_Size(imageSize);
		((Control)cmdNext).set_TabIndex(21);
		AxSSCommand obj19 = cmdLast;
		location = new Point(233, 161);
		((Control)obj19).set_Location(location);
		((Control)cmdLast).set_Name("cmdLast");
		((AxHost)cmdLast).set_OcxState((State)componentResourceManager.GetObject("cmdLast.OcxState"));
		AxSSCommand obj20 = cmdLast;
		imageSize = new Size(61, 24);
		((Control)obj20).set_Size(imageSize);
		((Control)cmdLast).set_TabIndex(22);
		AxSSCommand obj21 = cmdClose;
		location = new Point(316, 161);
		((Control)obj21).set_Location(location);
		((Control)cmdClose).set_Name("cmdClose");
		((AxHost)cmdClose).set_OcxState((State)componentResourceManager.GetObject("cmdClose.OcxState"));
		AxSSCommand obj22 = cmdClose;
		imageSize = new Size(61, 24);
		((Control)obj22).set_Size(imageSize);
		((Control)cmdClose).set_TabIndex(23);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		imageSize = new Size(389, 197);
		((Form)this).set_ClientSize(imageSize);
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
		((Control)this).get_Controls().Add((Control)(object)txtcategoryId);
		((Control)this).get_Controls().Add((Control)(object)AxSSPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("frmCustomerGroup");
		((Form)this).set_Text("Company Category");
		((ISupportInitialize)AxSSPanel1).EndInit();
		((ISupportInitialize)cmdnew).EndInit();
		((ISupportInitialize)cmdEdit).EndInit();
		((ISupportInitialize)cmdPrint).EndInit();
		((ISupportInitialize)cmdDelete).EndInit();
		((ISupportInitialize)cmdFirst).EndInit();
		((ISupportInitialize)cmdPrevious).EndInit();
		((ISupportInitialize)cmdNext).EndInit();
		((ISupportInitialize)cmdLast).EndInit();
		((ISupportInitialize)cmdClose).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmCustomerGroup_Load(object sender, EventArgs e)
	{
		objCustomerCategory = new Ccustomercategory();
		objCustomerCategory.Initialise(Startup.dBcon);
		Refreshdata();
		viewmode();
		if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(objCustomerCategory.RecordCount, (object)1), (object)0, false))
		{
			objCustomerCategory_NoRecords();
		}
	}

	private void cmdNext_ClickEvent(object sender, EventArgs e)
	{
		objCustomerCategory.MoveNext();
		Refreshdata();
	}

	private void cmdPrevious_ClickEvent(object sender, EventArgs e)
	{
		objCustomerCategory.MovePrevious();
		Refreshdata();
	}

	private void cmdFirst_ClickEvent(object sender, EventArgs e)
	{
		objCustomerCategory.MoveFirst();
		Refreshdata();
	}

	private void cmdLast_ClickEvent(object sender, EventArgs e)
	{
		objCustomerCategory.MoveLast();
		Refreshdata();
	}

	private void cmdEdit_ClickEvent(object sender, EventArgs e)
	{
		if (Operators.CompareString(cmdEdit.get_Caption(), "&Edit", false) == 0)
		{
			IsnewRecord = false;
			editmode();
			((TextBoxBase)txtcategoryId).set_ReadOnly(true);
			((TextBoxBase)txtcategoryId).set_BackColor(Color.White);
			((Control)txtCategoryName).Focus();
		}
		else
		{
			viewmode();
			objCustomerCategory.Initialise(Startup.dBcon);
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
			((Control)txtcategoryId).Focus();
			cmdnew.set_Enabled(false);
		}
		else
		{
			objCustomerCategory.Save(IsnewRecord);
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
		txtcategoryId.set_Text(Conversions.ToString(objCustomerCategory.CategoryID));
		txtCategoryName.set_Text(Conversions.ToString(objCustomerCategory.CategoryName));
	}

	private void cmdClose_ClickEvent(object sender, EventArgs e)
	{
		objCustomerCategory = null;
		((Form)this).Close();
	}

	private void cmdnew_Enter(object sender, EventArgs e)
	{
	}

	private void cmdClose_Enter(object sender, EventArgs e)
	{
	}

	private void txtcategoryId_GotFocus(object sender, EventArgs e)
	{
		((TextBoxBase)txtcategoryId).SelectAll();
	}

	private void txtcategoryId_KeyDown(object sender, KeyEventArgs e)
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

	private void txtcategoryId_LostFocus(object sender, EventArgs e)
	{
		if ((Operators.CompareString(cmdnew.get_Caption(), "&Save", false) == 0) & IsnewRecord)
		{
			objCustomerCategory.FindRecord(txtcategoryId.get_Text());
		}
	}

	private void txtcategoryId_TextChanged(object sender, EventArgs e)
	{
		objCustomerCategory.CategoryID = txtcategoryId.get_Text();
		objCustomerCategory.IsValid();
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
		objCustomerCategory.m_CategoryName = txtCategoryName.get_Text();
		objCustomerCategory.IsValid();
	}

	private void objCustomerCategory_DataValidated(bool blnIsValid)
	{
		cmdnew.set_Enabled(blnIsValid);
	}

	private void objCustomerCategory_MoveBackward(bool blnMoveBack)
	{
		cmdPrevious.set_Enabled(blnMoveBack);
		cmdFirst.set_Enabled(blnMoveBack);
	}

	private void objCustomerCategory_MoveForward(bool blnMoveForward)
	{
		cmdNext.set_Enabled(blnMoveForward);
		cmdLast.set_Enabled(blnMoveForward);
	}

	private void objCustomerCategory_NoRecords()
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

	private void objCustomerCategory_RecordExits()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		msgAns = (long)Interaction.MsgBox((object)"Category ID Already Exits", (MsgBoxStyle)69, (object)"Information");
		if (msgAns == 4L)
		{
			((Control)txtcategoryId).Focus();
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
			objCustomerCategory.Delete(txtcategoryId.get_Text());
			Refreshdata();
		}
	}

	private void cmdPrevious_Enter(object sender, EventArgs e)
	{
	}

	private void cmdDelete_Enter(object sender, EventArgs e)
	{
	}

	private void cmdFirst_Enter(object sender, EventArgs e)
	{
	}

	private void cmdEdit_Enter(object sender, EventArgs e)
	{
	}
}

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Autodesk.ExpressTools.LispSurf.Autodesk.ExpressTools.LispSurf;

internal class lspmaint : Form
{
	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("Option3")]
	private RadioButton _Option3;

	[AccessedThroughProperty("Option2")]
	private RadioButton _Option2;

	[AccessedThroughProperty("Option1")]
	private RadioButton _Option1;

	[AccessedThroughProperty("Frame1")]
	private GroupBox _Frame1;

	[AccessedThroughProperty("Text1")]
	private TextBox _Text1;

	[AccessedThroughProperty("Text4")]
	private TextBox _Text4;

	[AccessedThroughProperty("Combo1")]
	private ComboBox _Combo1;

	[AccessedThroughProperty("Text3")]
	private TextBox _Text3;

	[AccessedThroughProperty("Text2")]
	private TextBox _Text2;

	[AccessedThroughProperty("Command1")]
	private Button _Command1;

	[AccessedThroughProperty("_Label2_1")]
	private Label __Label2_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("HelpProvider1")]
	private HelpProvider _HelpProvider1;

	private string currentDirectory;

	private string currentFile;

	[AccessedThroughProperty("File1")]
	private ListBox _File1;

	[AccessedThroughProperty("Drive1")]
	private ComboBox _Drive1;

	[AccessedThroughProperty("Dir2")]
	private ListBox _Dir2;

	[AccessedThroughProperty("Dir1")]
	private TreeView _Dir1;

	private static lspmaint m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private string[] txt;

	private string[] txt2;

	private short[] lsp;

	private short[,] defuns;

	private ImageList myImageList;

	private ResourceManager resources;

	public virtual RadioButton Option3
	{
		get
		{
			return _Option3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Option3_CheckedChanged;
			if (_Option3 != null)
			{
				_Option3.remove_CheckedChanged(eventHandler);
			}
			_Option3 = value;
			if (_Option3 != null)
			{
				_Option3.add_CheckedChanged(eventHandler);
			}
		}
	}

	public virtual RadioButton Option2
	{
		get
		{
			return _Option2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Option2_CheckedChanged;
			if (_Option2 != null)
			{
				_Option2.remove_CheckedChanged(eventHandler);
			}
			_Option2 = value;
			if (_Option2 != null)
			{
				_Option2.add_CheckedChanged(eventHandler);
			}
		}
	}

	public virtual RadioButton Option1
	{
		get
		{
			return _Option1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Option1_CheckedChanged;
			if (_Option1 != null)
			{
				_Option1.remove_CheckedChanged(eventHandler);
			}
			_Option1 = value;
			if (_Option1 != null)
			{
				_Option1.add_CheckedChanged(eventHandler);
			}
		}
	}

	public virtual GroupBox Frame1
	{
		get
		{
			return _Frame1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Frame1 = value;
		}
	}

	public virtual TextBox Text1
	{
		get
		{
			return _Text1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Text1 = value;
		}
	}

	public virtual TextBox Text4
	{
		get
		{
			return _Text4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Text4 = value;
		}
	}

	public virtual ComboBox Combo1
	{
		get
		{
			return _Combo1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Combo1_SelectedIndexChanged;
			if (_Combo1 != null)
			{
				_Combo1.remove_SelectedIndexChanged(eventHandler);
			}
			_Combo1 = value;
			if (_Combo1 != null)
			{
				_Combo1.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public virtual TextBox Text3
	{
		get
		{
			return _Text3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Text3 = value;
		}
	}

	public virtual TextBox Text2
	{
		get
		{
			return _Text2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Text2 = value;
		}
	}

	public virtual Button Command1
	{
		get
		{
			return _Command1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Command1_Click;
			if (_Command1 != null)
			{
				((Control)_Command1).remove_Click(eventHandler);
			}
			_Command1 = value;
			if (_Command1 != null)
			{
				((Control)_Command1).add_Click(eventHandler);
			}
		}
	}

	public virtual Label _Label2_1
	{
		get
		{
			return __Label2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__Label2_1 = value;
		}
	}

	public virtual Label _Label1_0
	{
		get
		{
			return __Label1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__Label1_0 = value;
		}
	}

	public virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	public virtual HelpProvider HelpProvider1
	{
		get
		{
			return _HelpProvider1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HelpProvider1 = value;
		}
	}

	internal virtual ListBox File1
	{
		get
		{
			return _File1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = File1_SelectedIndexChanged;
			if (_File1 != null)
			{
				_File1.remove_SelectedIndexChanged(eventHandler);
			}
			_File1 = value;
			if (_File1 != null)
			{
				_File1.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ComboBox Drive1
	{
		get
		{
			return _Drive1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Drive1_SelectedIndexChanged;
			if (_Drive1 != null)
			{
				_Drive1.remove_SelectedIndexChanged(eventHandler);
			}
			_Drive1 = value;
			if (_Drive1 != null)
			{
				_Drive1.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ListBox Dir2
	{
		get
		{
			return _Dir2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Dir2 = value;
		}
	}

	internal virtual TreeView Dir1
	{
		get
		{
			return _Dir1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			TreeViewEventHandler val = new TreeViewEventHandler(Dir1_SelectedIndexChanged);
			EventHandler eventHandler = Dir1_DoubleClick;
			if (_Dir1 != null)
			{
				_Dir1.remove_AfterSelect(val);
				((Control)_Dir1).remove_DoubleClick(eventHandler);
			}
			_Dir1 = value;
			if (_Dir1 != null)
			{
				_Dir1.add_AfterSelect(val);
				((Control)_Dir1).add_DoubleClick(eventHandler);
			}
		}
	}

	public static lspmaint DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || ((Control)m_vb6FormDefInstance).get_IsDisposed())
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new lspmaint();
				m_InitializingDefInstance = false;
			}
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
		}
	}

	public lspmaint()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_Resize((EventHandler)Form1_Resize);
		myImageList = new ImageList();
		resources = new ResourceManager(typeof(lspmaint));
		if (m_vb6FormDefInstance == null)
		{
			if (m_InitializingDefInstance)
			{
				m_vb6FormDefInstance = this;
			}
			else
			{
				try
				{
					if ((object)Assembly.GetExecutingAssembly().EntryPoint!.DeclaringType == ((object)this).GetType())
					{
						m_vb6FormDefInstance = this;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		InitializeComponent();
	}

	protected override void Dispose(bool Disposing)
	{
		if (Disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
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
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Expected O, but got Unknown
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected O, but got Unknown
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Expected O, but got Unknown
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected O, but got Unknown
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected O, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbe: Expected O, but got Unknown
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected O, but got Unknown
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Expected O, but got Unknown
		//IL_1370: Unknown result type (might be due to invalid IL or missing references)
		//IL_137a: Expected O, but got Unknown
		//IL_13d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Expected O, but got Unknown
		//IL_165c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1666: Expected O, but got Unknown
		//IL_16bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Expected O, but got Unknown
		//IL_197e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1988: Expected O, but got Unknown
		//IL_19df: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e9: Expected O, but got Unknown
		//IL_1c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c83: Expected O, but got Unknown
		//IL_1cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cff: Expected O, but got Unknown
		//IL_1d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d83: Expected O, but got Unknown
		//IL_1fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc4: Expected O, but got Unknown
		//IL_203e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2048: Expected O, but got Unknown
		//IL_227f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2289: Expected O, but got Unknown
		//IL_2303: Unknown result type (might be due to invalid IL or missing references)
		//IL_230d: Expected O, but got Unknown
		//IL_2544: Unknown result type (might be due to invalid IL or missing references)
		//IL_254e: Expected O, but got Unknown
		//IL_25c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d2: Expected O, but got Unknown
		//IL_2798: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a2: Expected O, but got Unknown
		//IL_2804: Unknown result type (might be due to invalid IL or missing references)
		//IL_280e: Expected O, but got Unknown
		//IL_2a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a57: Expected O, but got Unknown
		//IL_2ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac3: Expected O, but got Unknown
		//IL_2d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d0c: Expected O, but got Unknown
		//IL_2d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d5d: Expected O, but got Unknown
		//IL_2f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa1: Expected O, but got Unknown
		//IL_2fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff2: Expected O, but got Unknown
		//IL_32cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d9: Expected O, but got Unknown
		//IL_3449: Unknown result type (might be due to invalid IL or missing references)
		//IL_3453: Expected O, but got Unknown
		//IL_34a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_34b3: Expected O, but got Unknown
		Application.EnableVisualStyles();
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(lspmaint));
		ToolTip1 = new ToolTip(components);
		Option3 = new RadioButton();
		Option2 = new RadioButton();
		Option1 = new RadioButton();
		Frame1 = new GroupBox();
		Text1 = new TextBox();
		Text4 = new TextBox();
		Combo1 = new ComboBox();
		Text3 = new TextBox();
		Text2 = new TextBox();
		Command1 = new Button();
		_Label2_1 = new Label();
		_Label1_0 = new Label();
		Label3 = new Label();
		Dir2 = new ListBox();
		File1 = new ListBox();
		Drive1 = new ComboBox();
		Dir1 = new TreeView();
		HelpProvider1 = new HelpProvider();
		((Control)this).SuspendLayout();
		((Control)Option3).set_AccessibleDescription(resourceManager.GetString("Option3.AccessibleDescription"));
		((Control)Option3).set_AccessibleName(resourceManager.GetString("Option3.AccessibleName"));
		((Control)Option3).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Option3.Anchor")));
		Option3.set_Appearance((Appearance)Conversions.ToInteger(resourceManager.GetObject("Option3.Appearance")));
		((ButtonBase)Option3).set_BackColor(SystemColors.Control);
		((Control)Option3).set_BackgroundImage((Image)resourceManager.GetObject("Option3.BackgroundImage"));
		Option3.set_CheckAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option3.CheckAlign")));
		Option3.set_Checked(true);
		((Control)Option3).set_Cursor(Cursors.get_Default());
		((Control)Option3).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Option3.Dock")));
		((Control)Option3).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Option3.Enabled")));
		((ButtonBase)Option3).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("Option3.FlatStyle")));
		((Control)Option3).set_Font((Font)resourceManager.GetObject("Option3.Font"));
		((Control)Option3).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)Option3, resourceManager.GetString("Option3.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Option3, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Option3.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Option3, resourceManager.GetString("Option3.HelpString"));
		((ButtonBase)Option3).set_Image((Image)resourceManager.GetObject("Option3.Image"));
		((ButtonBase)Option3).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option3.ImageAlign")));
		((ButtonBase)Option3).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Option3.ImageIndex")));
		((ButtonBase)Option3).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Option3.ImeMode")));
		RadioButton option = Option3;
		object? @object = resourceManager.GetObject("Option3.Location");
		Point point = default(Point);
		((Control)option).set_Location((@object != null) ? ((Point)@object) : point);
		((Control)Option3).set_Name("Option3");
		((Control)Option3).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Option3.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Option3, Conversions.ToBoolean(resourceManager.GetObject("Option3.ShowHelp")));
		RadioButton option2 = Option3;
		object? object2 = resourceManager.GetObject("Option3.Size");
		Size size = default(Size);
		((Control)option2).set_Size((object2 != null) ? ((Size)object2) : size);
		((Control)Option3).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Option3.TabIndex")));
		Option3.set_TabStop(true);
		((ButtonBase)Option3).set_Text(resourceManager.GetString("Option3.Text"));
		Option3.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option3.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Option3, resourceManager.GetString("Option3.ToolTip"));
		((Control)Option3).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Option3.Visible")));
		((Control)Option2).set_AccessibleDescription(resourceManager.GetString("Option2.AccessibleDescription"));
		((Control)Option2).set_AccessibleName(resourceManager.GetString("Option2.AccessibleName"));
		((Control)Option2).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Option2.Anchor")));
		Option2.set_Appearance((Appearance)Conversions.ToInteger(resourceManager.GetObject("Option2.Appearance")));
		((ButtonBase)Option2).set_BackColor(SystemColors.Control);
		((Control)Option2).set_BackgroundImage((Image)resourceManager.GetObject("Option2.BackgroundImage"));
		Option2.set_CheckAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option2.CheckAlign")));
		((Control)Option2).set_Cursor(Cursors.get_Default());
		((Control)Option2).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Option2.Dock")));
		((Control)Option2).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Option2.Enabled")));
		((ButtonBase)Option2).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("Option2.FlatStyle")));
		((Control)Option2).set_Font((Font)resourceManager.GetObject("Option2.Font"));
		((Control)Option2).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)Option2, resourceManager.GetString("Option2.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Option2, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Option2.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Option2, resourceManager.GetString("Option2.HelpString"));
		((ButtonBase)Option2).set_Image((Image)resourceManager.GetObject("Option2.Image"));
		((ButtonBase)Option2).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option2.ImageAlign")));
		((ButtonBase)Option2).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Option2.ImageIndex")));
		((ButtonBase)Option2).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Option2.ImeMode")));
		RadioButton option3 = Option2;
		object? object3 = resourceManager.GetObject("Option2.Location");
		((Control)option3).set_Location((object3 != null) ? ((Point)object3) : point);
		((Control)Option2).set_Name("Option2");
		((Control)Option2).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Option2.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Option2, Conversions.ToBoolean(resourceManager.GetObject("Option2.ShowHelp")));
		RadioButton option4 = Option2;
		object? object4 = resourceManager.GetObject("Option2.Size");
		((Control)option4).set_Size((object4 != null) ? ((Size)object4) : size);
		((Control)Option2).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Option2.TabIndex")));
		Option2.set_TabStop(true);
		((ButtonBase)Option2).set_Text(resourceManager.GetString("Option2.Text"));
		Option2.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option2.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Option2, resourceManager.GetString("Option2.ToolTip"));
		((Control)Option2).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Option2.Visible")));
		((Control)Option1).set_AccessibleDescription(resourceManager.GetString("Option1.AccessibleDescription"));
		((Control)Option1).set_AccessibleName(resourceManager.GetString("Option1.AccessibleName"));
		((Control)Option1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Option1.Anchor")));
		Option1.set_Appearance((Appearance)Conversions.ToInteger(resourceManager.GetObject("Option1.Appearance")));
		((ButtonBase)Option1).set_BackColor(SystemColors.Control);
		((Control)Option1).set_BackgroundImage((Image)resourceManager.GetObject("Option1.BackgroundImage"));
		Option1.set_CheckAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option1.CheckAlign")));
		((Control)Option1).set_Cursor(Cursors.get_Default());
		((Control)Option1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Option1.Dock")));
		((Control)Option1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Option1.Enabled")));
		((ButtonBase)Option1).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("Option1.FlatStyle")));
		((Control)Option1).set_Font((Font)resourceManager.GetObject("Option1.Font"));
		((Control)Option1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)Option1, resourceManager.GetString("Option1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Option1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Option1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Option1, resourceManager.GetString("Option1.HelpString"));
		((ButtonBase)Option1).set_Image((Image)resourceManager.GetObject("Option1.Image"));
		((ButtonBase)Option1).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option1.ImageAlign")));
		((ButtonBase)Option1).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Option1.ImageIndex")));
		((ButtonBase)Option1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Option1.ImeMode")));
		RadioButton option5 = Option1;
		object? object5 = resourceManager.GetObject("Option1.Location");
		((Control)option5).set_Location((object5 != null) ? ((Point)object5) : point);
		((Control)Option1).set_Name("Option1");
		((Control)Option1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Option1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Option1, Conversions.ToBoolean(resourceManager.GetObject("Option1.ShowHelp")));
		RadioButton option6 = Option1;
		object? object6 = resourceManager.GetObject("Option1.Size");
		((Control)option6).set_Size((object6 != null) ? ((Size)object6) : size);
		((Control)Option1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Option1.TabIndex")));
		Option1.set_TabStop(true);
		((ButtonBase)Option1).set_Text(resourceManager.GetString("Option1.Text"));
		Option1.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Option1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Option1, resourceManager.GetString("Option1.ToolTip"));
		((Control)Option1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Option1.Visible")));
		((Control)Frame1).set_AccessibleDescription(resourceManager.GetString("Frame1.AccessibleDescription"));
		((Control)Frame1).set_AccessibleName(resourceManager.GetString("Frame1.AccessibleName"));
		((Control)Frame1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Frame1.Anchor")));
		((Control)Frame1).set_BackColor(SystemColors.Control);
		((Control)Frame1).set_BackgroundImage((Image)resourceManager.GetObject("Frame1.BackgroundImage"));
		((Control)Frame1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Frame1.Dock")));
		((Control)Frame1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Frame1.Enabled")));
		((Control)Frame1).set_Font((Font)resourceManager.GetObject("Frame1.Font"));
		((Control)Frame1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)Frame1, resourceManager.GetString("Frame1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Frame1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Frame1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Frame1, resourceManager.GetString("Frame1.HelpString"));
		((Control)Frame1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Frame1.ImeMode")));
		GroupBox frame = Frame1;
		object? object7 = resourceManager.GetObject("Frame1.Location");
		((Control)frame).set_Location((object7 != null) ? ((Point)object7) : point);
		((Control)Frame1).set_Name("Frame1");
		((Control)Frame1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Frame1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Frame1, Conversions.ToBoolean(resourceManager.GetObject("Frame1.ShowHelp")));
		GroupBox frame2 = Frame1;
		object? object8 = resourceManager.GetObject("Frame1.Size");
		((Control)frame2).set_Size((object8 != null) ? ((Size)object8) : size);
		((Control)Frame1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Frame1.TabIndex")));
		Frame1.set_TabStop(false);
		Frame1.set_Text(resourceManager.GetString("Frame1.Text"));
		ToolTip1.SetToolTip((Control)(object)Frame1, resourceManager.GetString("Frame1.ToolTip"));
		((Control)Frame1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Frame1.Visible")));
		Text1.set_AcceptsReturn(true);
		((Control)Text1).set_AccessibleDescription(resourceManager.GetString("Text1.AccessibleDescription"));
		((Control)Text1).set_AccessibleName(resourceManager.GetString("Text1.AccessibleName"));
		((Control)Text1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Text1.Anchor")));
		((TextBoxBase)Text1).set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("Text1.AutoSize")));
		((TextBoxBase)Text1).set_BackColor(SystemColors.Window);
		((TextBoxBase)Text1).set_BackgroundImage((Image)resourceManager.GetObject("Text1.BackgroundImage"));
		((Control)Text1).set_Cursor(Cursors.get_IBeam());
		((Control)Text1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Text1.Dock")));
		((Control)Text1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Text1.Enabled")));
		((Control)Text1).set_Font((Font)resourceManager.GetObject("Text1.Font"));
		((TextBoxBase)Text1).set_ForeColor(SystemColors.WindowText);
		HelpProvider1.SetHelpKeyword((Control)(object)Text1, resourceManager.GetString("Text1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Text1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Text1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Text1, resourceManager.GetString("Text1.HelpString"));
		((Control)Text1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Text1.ImeMode")));
		TextBox text = Text1;
		object? object9 = resourceManager.GetObject("Text1.Location");
		((Control)text).set_Location((object9 != null) ? ((Point)object9) : point);
		((TextBoxBase)Text1).set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("Text1.MaxLength")));
		Text1.set_Multiline(Conversions.ToBoolean(resourceManager.GetObject("Text1.Multiline")));
		((Control)Text1).set_Name("Text1");
		Text1.set_PasswordChar(Conversions.ToChar(resourceManager.GetObject("Text1.PasswordChar")));
		((Control)Text1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Text1.RightToLeft")));
		Text1.set_ScrollBars((ScrollBars)Conversions.ToInteger(resourceManager.GetObject("Text1.ScrollBars")));
		HelpProvider1.SetShowHelp((Control)(object)Text1, Conversions.ToBoolean(resourceManager.GetObject("Text1.ShowHelp")));
		TextBox text2 = Text1;
		object? object10 = resourceManager.GetObject("Text1.Size");
		((Control)text2).set_Size((object10 != null) ? ((Size)object10) : size);
		((Control)Text1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Text1.TabIndex")));
		Text1.set_Text(resourceManager.GetString("Text1.Text"));
		Text1.set_TextAlign((HorizontalAlignment)Conversions.ToInteger(resourceManager.GetObject("Text1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Text1, resourceManager.GetString("Text1.ToolTip"));
		((Control)Text1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Text1.Visible")));
		((TextBoxBase)Text1).set_WordWrap(Conversions.ToBoolean(resourceManager.GetObject("Text1.WordWrap")));
		Text4.set_AcceptsReturn(true);
		((Control)Text4).set_AccessibleDescription(resourceManager.GetString("Text4.AccessibleDescription"));
		((Control)Text4).set_AccessibleName(resourceManager.GetString("Text4.AccessibleName"));
		((Control)Text4).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Text4.Anchor")));
		((TextBoxBase)Text4).set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("Text4.AutoSize")));
		((TextBoxBase)Text4).set_BackColor(SystemColors.Window);
		((TextBoxBase)Text4).set_BackgroundImage((Image)resourceManager.GetObject("Text4.BackgroundImage"));
		((Control)Text4).set_Cursor(Cursors.get_IBeam());
		((Control)Text4).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Text4.Dock")));
		((Control)Text4).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Text4.Enabled")));
		((Control)Text4).set_Font((Font)resourceManager.GetObject("Text4.Font"));
		((TextBoxBase)Text4).set_ForeColor(SystemColors.WindowText);
		HelpProvider1.SetHelpKeyword((Control)(object)Text4, resourceManager.GetString("Text4.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Text4, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Text4.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Text4, resourceManager.GetString("Text4.HelpString"));
		((Control)Text4).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Text4.ImeMode")));
		TextBox text3 = Text4;
		object? object11 = resourceManager.GetObject("Text4.Location");
		((Control)text3).set_Location((object11 != null) ? ((Point)object11) : point);
		((TextBoxBase)Text4).set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("Text4.MaxLength")));
		Text4.set_Multiline(Conversions.ToBoolean(resourceManager.GetObject("Text4.Multiline")));
		((Control)Text4).set_Name("Text4");
		Text4.set_PasswordChar(Conversions.ToChar(resourceManager.GetObject("Text4.PasswordChar")));
		((Control)Text4).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Text4.RightToLeft")));
		Text4.set_ScrollBars((ScrollBars)Conversions.ToInteger(resourceManager.GetObject("Text4.ScrollBars")));
		HelpProvider1.SetShowHelp((Control)(object)Text4, Conversions.ToBoolean(resourceManager.GetObject("Text4.ShowHelp")));
		TextBox text4 = Text4;
		object? object12 = resourceManager.GetObject("Text4.Size");
		((Control)text4).set_Size((object12 != null) ? ((Size)object12) : size);
		((Control)Text4).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Text4.TabIndex")));
		Text4.set_Text(resourceManager.GetString("Text4.Text"));
		Text4.set_TextAlign((HorizontalAlignment)Conversions.ToInteger(resourceManager.GetObject("Text4.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Text4, resourceManager.GetString("Text4.ToolTip"));
		((Control)Text4).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Text4.Visible")));
		((TextBoxBase)Text4).set_WordWrap(Conversions.ToBoolean(resourceManager.GetObject("Text4.WordWrap")));
		((Control)Combo1).set_AccessibleDescription(resourceManager.GetString("Combo1.AccessibleDescription"));
		((Control)Combo1).set_AccessibleName(resourceManager.GetString("Combo1.AccessibleName"));
		((Control)Combo1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Combo1.Anchor")));
		Combo1.set_BackColor(SystemColors.Window);
		Combo1.set_BackgroundImage((Image)resourceManager.GetObject("Combo1.BackgroundImage"));
		((Control)Combo1).set_Cursor(Cursors.get_Default());
		((Control)Combo1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Combo1.Dock")));
		((Control)Combo1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Combo1.Enabled")));
		((Control)Combo1).set_Font((Font)resourceManager.GetObject("Combo1.Font"));
		Combo1.set_ForeColor(SystemColors.WindowText);
		HelpProvider1.SetHelpKeyword((Control)(object)Combo1, resourceManager.GetString("Combo1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Combo1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Combo1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Combo1, resourceManager.GetString("Combo1.HelpString"));
		((Control)Combo1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Combo1.ImeMode")));
		Combo1.set_IntegralHeight(Conversions.ToBoolean(resourceManager.GetObject("Combo1.IntegralHeight")));
		Combo1.set_ItemHeight(Conversions.ToInteger(resourceManager.GetObject("Combo1.ItemHeight")));
		ComboBox combo = Combo1;
		object? object13 = resourceManager.GetObject("Combo1.Location");
		((Control)combo).set_Location((object13 != null) ? ((Point)object13) : point);
		Combo1.set_MaxDropDownItems(Conversions.ToInteger(resourceManager.GetObject("Combo1.MaxDropDownItems")));
		Combo1.set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("Combo1.MaxLength")));
		((Control)Combo1).set_Name("Combo1");
		((Control)Combo1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Combo1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Combo1, Conversions.ToBoolean(resourceManager.GetObject("Combo1.ShowHelp")));
		ComboBox combo2 = Combo1;
		object? object14 = resourceManager.GetObject("Combo1.Size");
		((Control)combo2).set_Size((object14 != null) ? ((Size)object14) : size);
		((Control)Combo1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Combo1.TabIndex")));
		Combo1.set_Text(resourceManager.GetString("Combo1.Text"));
		ToolTip1.SetToolTip((Control)(object)Combo1, resourceManager.GetString("Combo1.ToolTip"));
		((Control)Combo1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Combo1.Visible")));
		Text3.set_AcceptsReturn(true);
		((Control)Text3).set_AccessibleDescription(resourceManager.GetString("Text3.AccessibleDescription"));
		((Control)Text3).set_AccessibleName(resourceManager.GetString("Text3.AccessibleName"));
		((Control)Text3).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Text3.Anchor")));
		((TextBoxBase)Text3).set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("Text3.AutoSize")));
		((TextBoxBase)Text3).set_BackColor(SystemColors.Window);
		((TextBoxBase)Text3).set_BackgroundImage((Image)resourceManager.GetObject("Text3.BackgroundImage"));
		((Control)Text3).set_Cursor(Cursors.get_IBeam());
		((Control)Text3).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Text3.Dock")));
		((Control)Text3).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Text3.Enabled")));
		((Control)Text3).set_Font((Font)resourceManager.GetObject("Text3.Font"));
		((TextBoxBase)Text3).set_ForeColor(SystemColors.WindowText);
		HelpProvider1.SetHelpKeyword((Control)(object)Text3, resourceManager.GetString("Text3.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Text3, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Text3.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Text3, resourceManager.GetString("Text3.HelpString"));
		((Control)Text3).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Text3.ImeMode")));
		TextBox text5 = Text3;
		object? object15 = resourceManager.GetObject("Text3.Location");
		((Control)text5).set_Location((object15 != null) ? ((Point)object15) : point);
		((TextBoxBase)Text3).set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("Text3.MaxLength")));
		Text3.set_Multiline(Conversions.ToBoolean(resourceManager.GetObject("Text3.Multiline")));
		((Control)Text3).set_Name("Text3");
		Text3.set_PasswordChar(Conversions.ToChar(resourceManager.GetObject("Text3.PasswordChar")));
		((Control)Text3).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Text3.RightToLeft")));
		Text3.set_ScrollBars((ScrollBars)Conversions.ToInteger(resourceManager.GetObject("Text3.ScrollBars")));
		HelpProvider1.SetShowHelp((Control)(object)Text3, Conversions.ToBoolean(resourceManager.GetObject("Text3.ShowHelp")));
		TextBox text6 = Text3;
		object? object16 = resourceManager.GetObject("Text3.Size");
		((Control)text6).set_Size((object16 != null) ? ((Size)object16) : size);
		((Control)Text3).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Text3.TabIndex")));
		Text3.set_Text(resourceManager.GetString("Text3.Text"));
		Text3.set_TextAlign((HorizontalAlignment)Conversions.ToInteger(resourceManager.GetObject("Text3.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Text3, resourceManager.GetString("Text3.ToolTip"));
		((Control)Text3).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Text3.Visible")));
		((TextBoxBase)Text3).set_WordWrap(Conversions.ToBoolean(resourceManager.GetObject("Text3.WordWrap")));
		Text2.set_AcceptsReturn(true);
		((Control)Text2).set_AccessibleDescription(resourceManager.GetString("Text2.AccessibleDescription"));
		((Control)Text2).set_AccessibleName(resourceManager.GetString("Text2.AccessibleName"));
		((Control)Text2).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Text2.Anchor")));
		((TextBoxBase)Text2).set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("Text2.AutoSize")));
		((TextBoxBase)Text2).set_BackColor(SystemColors.Window);
		((TextBoxBase)Text2).set_BackgroundImage((Image)resourceManager.GetObject("Text2.BackgroundImage"));
		((Control)Text2).set_Cursor(Cursors.get_IBeam());
		((Control)Text2).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Text2.Dock")));
		((Control)Text2).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Text2.Enabled")));
		((Control)Text2).set_Font((Font)resourceManager.GetObject("Text2.Font"));
		((TextBoxBase)Text2).set_ForeColor(SystemColors.WindowText);
		HelpProvider1.SetHelpKeyword((Control)(object)Text2, resourceManager.GetString("Text2.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Text2, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Text2.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Text2, resourceManager.GetString("Text2.HelpString"));
		((Control)Text2).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Text2.ImeMode")));
		TextBox text7 = Text2;
		object? object17 = resourceManager.GetObject("Text2.Location");
		((Control)text7).set_Location((object17 != null) ? ((Point)object17) : point);
		((TextBoxBase)Text2).set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("Text2.MaxLength")));
		Text2.set_Multiline(Conversions.ToBoolean(resourceManager.GetObject("Text2.Multiline")));
		((Control)Text2).set_Name("Text2");
		Text2.set_PasswordChar(Conversions.ToChar(resourceManager.GetObject("Text2.PasswordChar")));
		((Control)Text2).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Text2.RightToLeft")));
		Text2.set_ScrollBars((ScrollBars)Conversions.ToInteger(resourceManager.GetObject("Text2.ScrollBars")));
		HelpProvider1.SetShowHelp((Control)(object)Text2, Conversions.ToBoolean(resourceManager.GetObject("Text2.ShowHelp")));
		TextBox text8 = Text2;
		object? object18 = resourceManager.GetObject("Text2.Size");
		((Control)text8).set_Size((object18 != null) ? ((Size)object18) : size);
		((Control)Text2).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Text2.TabIndex")));
		Text2.set_Text(resourceManager.GetString("Text2.Text"));
		Text2.set_TextAlign((HorizontalAlignment)Conversions.ToInteger(resourceManager.GetObject("Text2.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Text2, resourceManager.GetString("Text2.ToolTip"));
		((Control)Text2).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Text2.Visible")));
		((TextBoxBase)Text2).set_WordWrap(Conversions.ToBoolean(resourceManager.GetObject("Text2.WordWrap")));
		((Control)Command1).set_AccessibleDescription(resourceManager.GetString("Command1.AccessibleDescription"));
		((Control)Command1).set_AccessibleName(resourceManager.GetString("Command1.AccessibleName"));
		((Control)Command1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Command1.Anchor")));
		((ButtonBase)Command1).set_BackColor(SystemColors.Control);
		((Control)Command1).set_BackgroundImage((Image)resourceManager.GetObject("Command1.BackgroundImage"));
		((Control)Command1).set_Cursor(Cursors.get_Default());
		((Control)Command1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Command1.Dock")));
		((Control)Command1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Command1.Enabled")));
		((ButtonBase)Command1).set_FlatStyle((FlatStyle)Conversions.ToInteger(resourceManager.GetObject("Command1.FlatStyle")));
		((Control)Command1).set_Font((Font)resourceManager.GetObject("Command1.Font"));
		((Control)Command1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)Command1, resourceManager.GetString("Command1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Command1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Command1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Command1, resourceManager.GetString("Command1.HelpString"));
		((ButtonBase)Command1).set_Image((Image)resourceManager.GetObject("Command1.Image"));
		((ButtonBase)Command1).set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Command1.ImageAlign")));
		((ButtonBase)Command1).set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Command1.ImageIndex")));
		((ButtonBase)Command1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Command1.ImeMode")));
		Button command = Command1;
		object? object19 = resourceManager.GetObject("Command1.Location");
		((Control)command).set_Location((object19 != null) ? ((Point)object19) : point);
		((Control)Command1).set_Name("Command1");
		((Control)Command1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Command1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Command1, Conversions.ToBoolean(resourceManager.GetObject("Command1.ShowHelp")));
		Button command2 = Command1;
		object? object20 = resourceManager.GetObject("Command1.Size");
		((Control)command2).set_Size((object20 != null) ? ((Size)object20) : size);
		((Control)Command1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Command1.TabIndex")));
		((ButtonBase)Command1).set_Text(resourceManager.GetString("Command1.Text"));
		((ButtonBase)Command1).set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Command1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Command1, resourceManager.GetString("Command1.ToolTip"));
		((Control)Command1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Command1.Visible")));
		((Control)_Label2_1).set_AccessibleDescription(resourceManager.GetString("_Label2_1.AccessibleDescription"));
		((Control)_Label2_1).set_AccessibleName(resourceManager.GetString("_Label2_1.AccessibleName"));
		((Control)_Label2_1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_Label2_1.Anchor")));
		_Label2_1.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("_Label2_1.AutoSize")));
		((Control)_Label2_1).set_BackColor(SystemColors.Control);
		((Control)_Label2_1).set_Cursor(Cursors.get_Default());
		((Control)_Label2_1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_Label2_1.Dock")));
		((Control)_Label2_1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_Label2_1.Enabled")));
		((Control)_Label2_1).set_Font((Font)resourceManager.GetObject("_Label2_1.Font"));
		((Control)_Label2_1).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_Label2_1, resourceManager.GetString("_Label2_1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_Label2_1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_Label2_1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_Label2_1, resourceManager.GetString("_Label2_1.HelpString"));
		_Label2_1.set_Image((Image)resourceManager.GetObject("_Label2_1.Image"));
		_Label2_1.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_Label2_1.ImageAlign")));
		_Label2_1.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_Label2_1.ImageIndex")));
		_Label2_1.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_Label2_1.ImeMode")));
		Label label2_ = _Label2_1;
		object? object21 = resourceManager.GetObject("_Label2_1.Location");
		((Control)label2_).set_Location((object21 != null) ? ((Point)object21) : point);
		((Control)_Label2_1).set_Name("_Label2_1");
		((Control)_Label2_1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_Label2_1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_Label2_1, Conversions.ToBoolean(resourceManager.GetObject("_Label2_1.ShowHelp")));
		Label label2_2 = _Label2_1;
		object? object22 = resourceManager.GetObject("_Label2_1.Size");
		((Control)label2_2).set_Size((object22 != null) ? ((Size)object22) : size);
		((Control)_Label2_1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_Label2_1.TabIndex")));
		_Label2_1.set_Text(resourceManager.GetString("_Label2_1.Text"));
		_Label2_1.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_Label2_1.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_Label2_1, resourceManager.GetString("_Label2_1.ToolTip"));
		((Control)_Label2_1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_Label2_1.Visible")));
		((Control)_Label1_0).set_AccessibleDescription(resourceManager.GetString("_Label1_0.AccessibleDescription"));
		((Control)_Label1_0).set_AccessibleName(resourceManager.GetString("_Label1_0.AccessibleName"));
		((Control)_Label1_0).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("_Label1_0.Anchor")));
		_Label1_0.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("_Label1_0.AutoSize")));
		((Control)_Label1_0).set_BackColor(SystemColors.Control);
		((Control)_Label1_0).set_Cursor(Cursors.get_Default());
		((Control)_Label1_0).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("_Label1_0.Dock")));
		((Control)_Label1_0).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("_Label1_0.Enabled")));
		((Control)_Label1_0).set_Font((Font)resourceManager.GetObject("_Label1_0.Font"));
		((Control)_Label1_0).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)_Label1_0, resourceManager.GetString("_Label1_0.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)_Label1_0, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("_Label1_0.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)_Label1_0, resourceManager.GetString("_Label1_0.HelpString"));
		_Label1_0.set_Image((Image)resourceManager.GetObject("_Label1_0.Image"));
		_Label1_0.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_Label1_0.ImageAlign")));
		_Label1_0.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("_Label1_0.ImageIndex")));
		_Label1_0.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("_Label1_0.ImeMode")));
		Label label1_ = _Label1_0;
		object? object23 = resourceManager.GetObject("_Label1_0.Location");
		((Control)label1_).set_Location((object23 != null) ? ((Point)object23) : point);
		((Control)_Label1_0).set_Name("_Label1_0");
		((Control)_Label1_0).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("_Label1_0.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)_Label1_0, Conversions.ToBoolean(resourceManager.GetObject("_Label1_0.ShowHelp")));
		Label label1_2 = _Label1_0;
		object? object24 = resourceManager.GetObject("_Label1_0.Size");
		((Control)label1_2).set_Size((object24 != null) ? ((Size)object24) : size);
		((Control)_Label1_0).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("_Label1_0.TabIndex")));
		_Label1_0.set_Text(resourceManager.GetString("_Label1_0.Text"));
		_Label1_0.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("_Label1_0.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)_Label1_0, resourceManager.GetString("_Label1_0.ToolTip"));
		((Control)_Label1_0).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("_Label1_0.Visible")));
		((Control)Label3).set_AccessibleDescription(resourceManager.GetString("Label3.AccessibleDescription"));
		((Control)Label3).set_AccessibleName(resourceManager.GetString("Label3.AccessibleName"));
		((Control)Label3).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Label3.Anchor")));
		Label3.set_AutoSize(Conversions.ToBoolean(resourceManager.GetObject("Label3.AutoSize")));
		((Control)Label3).set_BackColor(SystemColors.Control);
		((Control)Label3).set_Cursor(Cursors.get_Default());
		((Control)Label3).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Label3.Dock")));
		((Control)Label3).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Label3.Enabled")));
		((Control)Label3).set_Font((Font)resourceManager.GetObject("Label3.Font"));
		((Control)Label3).set_ForeColor(SystemColors.ControlText);
		HelpProvider1.SetHelpKeyword((Control)(object)Label3, resourceManager.GetString("Label3.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Label3, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Label3.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Label3, resourceManager.GetString("Label3.HelpString"));
		Label3.set_Image((Image)resourceManager.GetObject("Label3.Image"));
		Label3.set_ImageAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Label3.ImageAlign")));
		Label3.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Label3.ImageIndex")));
		Label3.set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Label3.ImeMode")));
		Label label = Label3;
		object? object25 = resourceManager.GetObject("Label3.Location");
		((Control)label).set_Location((object25 != null) ? ((Point)object25) : point);
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Label3.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Label3, Conversions.ToBoolean(resourceManager.GetObject("Label3.ShowHelp")));
		Label label2 = Label3;
		object? object26 = resourceManager.GetObject("Label3.Size");
		((Control)label2).set_Size((object26 != null) ? ((Size)object26) : size);
		((Control)Label3).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Label3.TabIndex")));
		Label3.set_Text(resourceManager.GetString("Label3.Text"));
		Label3.set_TextAlign((ContentAlignment)Conversions.ToInteger(resourceManager.GetObject("Label3.TextAlign")));
		ToolTip1.SetToolTip((Control)(object)Label3, resourceManager.GetString("Label3.ToolTip"));
		((Control)Label3).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Label3.Visible")));
		((Control)Dir2).set_AccessibleDescription(resourceManager.GetString("Dir2.AccessibleDescription"));
		((Control)Dir2).set_AccessibleName(resourceManager.GetString("Dir2.AccessibleName"));
		((Control)Dir2).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Dir2.Anchor")));
		Dir2.set_BackgroundImage((Image)resourceManager.GetObject("Dir2.BackgroundImage"));
		Dir2.set_ColumnWidth(Conversions.ToInteger(resourceManager.GetObject("Dir2.ColumnWidth")));
		((Control)Dir2).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Dir2.Dock")));
		((Control)Dir2).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Dir2.Enabled")));
		Dir2.set_Font((Font)resourceManager.GetObject("Dir2.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)Dir2, resourceManager.GetString("Dir2.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Dir2, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Dir2.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Dir2, resourceManager.GetString("Dir2.HelpString"));
		Dir2.set_HorizontalExtent(Conversions.ToInteger(resourceManager.GetObject("Dir2.HorizontalExtent")));
		Dir2.set_HorizontalScrollbar(Conversions.ToBoolean(resourceManager.GetObject("Dir2.HorizontalScrollbar")));
		((Control)Dir2).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Dir2.ImeMode")));
		Dir2.set_IntegralHeight(Conversions.ToBoolean(resourceManager.GetObject("Dir2.IntegralHeight")));
		Dir2.set_ItemHeight(Conversions.ToInteger(resourceManager.GetObject("Dir2.ItemHeight")));
		ListBox dir = Dir2;
		object? object27 = resourceManager.GetObject("Dir2.Location");
		((Control)dir).set_Location((object27 != null) ? ((Point)object27) : point);
		((Control)Dir2).set_Name("Dir2");
		Dir2.set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Dir2.RightToLeft")));
		Dir2.set_ScrollAlwaysVisible(Conversions.ToBoolean(resourceManager.GetObject("Dir2.ScrollAlwaysVisible")));
		HelpProvider1.SetShowHelp((Control)(object)Dir2, Conversions.ToBoolean(resourceManager.GetObject("Dir2.ShowHelp")));
		ListBox dir2 = Dir2;
		object? object28 = resourceManager.GetObject("Dir2.Size");
		((Control)dir2).set_Size((object28 != null) ? ((Size)object28) : size);
		((Control)Dir2).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Dir2.TabIndex")));
		ToolTip1.SetToolTip((Control)(object)Dir2, resourceManager.GetString("Dir2.ToolTip"));
		((Control)Dir2).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Dir2.Visible")));
		((Control)File1).set_AccessibleDescription(resourceManager.GetString("File1.AccessibleDescription"));
		((Control)File1).set_AccessibleName(resourceManager.GetString("File1.AccessibleName"));
		((Control)File1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("File1.Anchor")));
		File1.set_BackgroundImage((Image)resourceManager.GetObject("File1.BackgroundImage"));
		File1.set_ColumnWidth(Conversions.ToInteger(resourceManager.GetObject("File1.ColumnWidth")));
		((Control)File1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("File1.Dock")));
		((Control)File1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("File1.Enabled")));
		File1.set_Font((Font)resourceManager.GetObject("File1.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)File1, resourceManager.GetString("File1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)File1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("File1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)File1, resourceManager.GetString("File1.HelpString"));
		File1.set_HorizontalExtent(Conversions.ToInteger(resourceManager.GetObject("File1.HorizontalExtent")));
		File1.set_HorizontalScrollbar(Conversions.ToBoolean(resourceManager.GetObject("File1.HorizontalScrollbar")));
		((Control)File1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("File1.ImeMode")));
		File1.set_IntegralHeight(Conversions.ToBoolean(resourceManager.GetObject("File1.IntegralHeight")));
		File1.set_ItemHeight(Conversions.ToInteger(resourceManager.GetObject("File1.ItemHeight")));
		ListBox file = File1;
		object? object29 = resourceManager.GetObject("File1.Location");
		((Control)file).set_Location((object29 != null) ? ((Point)object29) : point);
		((Control)File1).set_Name("File1");
		File1.set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("File1.RightToLeft")));
		File1.set_ScrollAlwaysVisible(Conversions.ToBoolean(resourceManager.GetObject("File1.ScrollAlwaysVisible")));
		HelpProvider1.SetShowHelp((Control)(object)File1, Conversions.ToBoolean(resourceManager.GetObject("File1.ShowHelp")));
		ListBox file2 = File1;
		object? object30 = resourceManager.GetObject("File1.Size");
		((Control)file2).set_Size((object30 != null) ? ((Size)object30) : size);
		((Control)File1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("File1.TabIndex")));
		ToolTip1.SetToolTip((Control)(object)File1, resourceManager.GetString("File1.ToolTip"));
		((Control)File1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("File1.Visible")));
		((Control)Drive1).set_AccessibleDescription(resourceManager.GetString("Drive1.AccessibleDescription"));
		((Control)Drive1).set_AccessibleName(resourceManager.GetString("Drive1.AccessibleName"));
		((Control)Drive1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Drive1.Anchor")));
		Drive1.set_BackgroundImage((Image)resourceManager.GetObject("Drive1.BackgroundImage"));
		((Control)Drive1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Drive1.Dock")));
		((Control)Drive1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Drive1.Enabled")));
		((Control)Drive1).set_Font((Font)resourceManager.GetObject("Drive1.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)Drive1, resourceManager.GetString("Drive1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Drive1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Drive1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Drive1, resourceManager.GetString("Drive1.HelpString"));
		((Control)Drive1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Drive1.ImeMode")));
		Drive1.set_IntegralHeight(Conversions.ToBoolean(resourceManager.GetObject("Drive1.IntegralHeight")));
		Drive1.set_ItemHeight(Conversions.ToInteger(resourceManager.GetObject("Drive1.ItemHeight")));
		ComboBox drive = Drive1;
		object? object31 = resourceManager.GetObject("Drive1.Location");
		((Control)drive).set_Location((object31 != null) ? ((Point)object31) : point);
		Drive1.set_MaxDropDownItems(Conversions.ToInteger(resourceManager.GetObject("Drive1.MaxDropDownItems")));
		Drive1.set_MaxLength(Conversions.ToInteger(resourceManager.GetObject("Drive1.MaxLength")));
		((Control)Drive1).set_Name("Drive1");
		((Control)Drive1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Drive1.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)Drive1, Conversions.ToBoolean(resourceManager.GetObject("Drive1.ShowHelp")));
		ComboBox drive2 = Drive1;
		object? object32 = resourceManager.GetObject("Drive1.Size");
		((Control)drive2).set_Size((object32 != null) ? ((Size)object32) : size);
		((Control)Drive1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Drive1.TabIndex")));
		Drive1.set_Text(resourceManager.GetString("Drive1.Text"));
		ToolTip1.SetToolTip((Control)(object)Drive1, resourceManager.GetString("Drive1.ToolTip"));
		((Control)Drive1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Drive1.Visible")));
		((Control)Dir1).set_AccessibleDescription(resourceManager.GetString("Dir1.AccessibleDescription"));
		((Control)Dir1).set_AccessibleName(resourceManager.GetString("Dir1.AccessibleName"));
		((Control)Dir1).set_Anchor((AnchorStyles)Conversions.ToInteger(resourceManager.GetObject("Dir1.Anchor")));
		Dir1.set_BackgroundImage((Image)resourceManager.GetObject("Dir1.BackgroundImage"));
		((Control)Dir1).set_Dock((DockStyle)Conversions.ToInteger(resourceManager.GetObject("Dir1.Dock")));
		((Control)Dir1).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("Dir1.Enabled")));
		((Control)Dir1).set_Font((Font)resourceManager.GetObject("Dir1.Font"));
		Dir1.set_FullRowSelect(true);
		HelpProvider1.SetHelpKeyword((Control)(object)Dir1, resourceManager.GetString("Dir1.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)Dir1, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("Dir1.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)Dir1, resourceManager.GetString("Dir1.HelpString"));
		Dir1.set_ImageIndex(Conversions.ToInteger(resourceManager.GetObject("Dir1.ImageIndex")));
		((Control)Dir1).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("Dir1.ImeMode")));
		Dir1.set_Indent(Conversions.ToInteger(resourceManager.GetObject("Dir1.Indent")));
		Dir1.set_ItemHeight(Conversions.ToInteger(resourceManager.GetObject("Dir1.ItemHeight")));
		TreeView dir3 = Dir1;
		object? object33 = resourceManager.GetObject("Dir1.Location");
		((Control)dir3).set_Location((object33 != null) ? ((Point)object33) : point);
		((Control)Dir1).set_Name("Dir1");
		((Control)Dir1).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("Dir1.RightToLeft")));
		Dir1.set_SelectedImageIndex(Conversions.ToInteger(resourceManager.GetObject("Dir1.SelectedImageIndex")));
		HelpProvider1.SetShowHelp((Control)(object)Dir1, Conversions.ToBoolean(resourceManager.GetObject("Dir1.ShowHelp")));
		Dir1.set_ShowLines(false);
		Dir1.set_ShowPlusMinus(false);
		Dir1.set_ShowRootLines(false);
		TreeView dir4 = Dir1;
		object? object34 = resourceManager.GetObject("Dir1.Size");
		((Control)dir4).set_Size((object34 != null) ? ((Size)object34) : size);
		((Control)Dir1).set_TabIndex(Conversions.ToInteger(resourceManager.GetObject("Dir1.TabIndex")));
		Dir1.set_Text(resourceManager.GetString("Dir1.Text"));
		ToolTip1.SetToolTip((Control)(object)Dir1, resourceManager.GetString("Dir1.ToolTip"));
		((Control)Dir1).set_Visible(Conversions.ToBoolean(resourceManager.GetObject("Dir1.Visible")));
		HelpProvider1.set_HelpNamespace(resourceManager.GetString("HelpProvider1.HelpNamespace"));
		((Control)this).set_AccessibleDescription(resourceManager.GetString("$this.AccessibleDescription"));
		((Control)this).set_AccessibleName(resourceManager.GetString("$this.AccessibleName"));
		object? object35 = resourceManager.GetObject("$this.AutoScaleBaseSize");
		((Form)this).set_AutoScaleBaseSize((object35 != null) ? ((Size)object35) : size);
		((Form)this).set_AutoScroll(Conversions.ToBoolean(resourceManager.GetObject("$this.AutoScroll")));
		object? object36 = resourceManager.GetObject("$this.AutoScrollMargin");
		((ScrollableControl)this).set_AutoScrollMargin((object36 != null) ? ((Size)object36) : size);
		object? object37 = resourceManager.GetObject("$this.AutoScrollMinSize");
		((ScrollableControl)this).set_AutoScrollMinSize((object37 != null) ? ((Size)object37) : size);
		((Form)this).set_BackColor(SystemColors.Control);
		((Control)this).set_BackgroundImage((Image)resourceManager.GetObject("$this.BackgroundImage"));
		object? object38 = resourceManager.GetObject("$this.ClientSize");
		((Form)this).set_ClientSize((object38 != null) ? ((Size)object38) : size);
		((Control)this).get_Controls().Add((Control)(object)Dir1);
		((Control)this).get_Controls().Add((Control)(object)Drive1);
		((Control)this).get_Controls().Add((Control)(object)File1);
		((Control)this).get_Controls().Add((Control)(object)Dir2);
		((Control)this).get_Controls().Add((Control)(object)Option3);
		((Control)this).get_Controls().Add((Control)(object)Option2);
		((Control)this).get_Controls().Add((Control)(object)Option1);
		((Control)this).get_Controls().Add((Control)(object)Frame1);
		((Control)this).get_Controls().Add((Control)(object)Text1);
		((Control)this).get_Controls().Add((Control)(object)Text4);
		((Control)this).get_Controls().Add((Control)(object)Text3);
		((Control)this).get_Controls().Add((Control)(object)Text2);
		((Control)this).get_Controls().Add((Control)(object)Combo1);
		((Control)this).get_Controls().Add((Control)(object)Command1);
		((Control)this).get_Controls().Add((Control)(object)_Label2_1);
		((Control)this).get_Controls().Add((Control)(object)_Label1_0);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_Enabled(Conversions.ToBoolean(resourceManager.GetObject("$this.Enabled")));
		((Control)this).set_Font((Font)resourceManager.GetObject("$this.Font"));
		HelpProvider1.SetHelpKeyword((Control)(object)this, resourceManager.GetString("$this.HelpKeyword"));
		HelpProvider1.SetHelpNavigator((Control)(object)this, (HelpNavigator)Conversions.ToInteger(resourceManager.GetObject("$this.HelpNavigator")));
		HelpProvider1.SetHelpString((Control)(object)this, resourceManager.GetString("$this.HelpString"));
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Control)this).set_ImeMode((ImeMode)Conversions.ToInteger(resourceManager.GetObject("$this.ImeMode")));
		object? object39 = resourceManager.GetObject("$this.Location");
		((Form)this).set_Location((object39 != null) ? ((Point)object39) : point);
		object? object40 = resourceManager.GetObject("$this.MaximumSize");
		((Form)this).set_MaximumSize((object40 != null) ? ((Size)object40) : size);
		object? object41 = resourceManager.GetObject("$this.MinimumSize");
		((Form)this).set_MinimumSize((object41 != null) ? ((Size)object41) : size);
		((Control)this).set_Name("lspmaint");
		((Control)this).set_RightToLeft((RightToLeft)Conversions.ToInteger(resourceManager.GetObject("$this.RightToLeft")));
		HelpProvider1.SetShowHelp((Control)(object)this, Conversions.ToBoolean(resourceManager.GetObject("$this.ShowHelp")));
		((Form)this).set_StartPosition((FormStartPosition)Conversions.ToInteger(resourceManager.GetObject("$this.StartPosition")));
		((Form)this).set_Text(resourceManager.GetString("$this.Text"));
		ToolTip1.SetToolTip((Control)(object)this, resourceManager.GetString("$this.ToolTip"));
		((Control)this).ResumeLayout(false);
	}

	public object GetCommandLine(ref object MaxArgs = 10)
	{
		short num = 0;
		checked
		{
			object[] array = new object[Conversions.ToInteger(MaxArgs) + 1];
			object obj = 0;
			object obj2 = true;
			object obj3 = Interaction.Command();
			object obj4 = Strings.Len(RuntimeHelpers.GetObjectValue(obj3));
			object obj5 = default(object);
			object obj6 = default(object);
			if (ForLoopControl.ForLoopInitObj(obj5, (object)1, obj4, (object)1, ref obj6, ref obj5))
			{
				do
				{
					object obj7 = Strings.Mid(Conversions.ToString(obj3), Conversions.ToInteger(obj5), 1);
					if (Operators.ConditionalCompareObjectEqual(obj7, (object)'"', false))
					{
						num = (short)(num + 1);
					}
					if (Conversions.ToBoolean(Operators.OrObject(Operators.AndObject((object)((double)num == Conversion.Fix((double)num / 2.0) * 2.0), Operators.CompareObjectEqual(obj7, (object)" ", false)), Operators.CompareObjectEqual(obj7, (object)"\t", false))))
					{
						obj2 = false;
						continue;
					}
					if (Conversions.ToBoolean(Operators.NotObject(obj2)))
					{
						if (Operators.ConditionalCompareObjectEqual(obj, MaxArgs, false))
						{
							break;
						}
						obj = Operators.AddObject(obj, (object)1);
						obj2 = true;
					}
					array[Conversions.ToInteger(obj)] = Operators.ConcatenateObject(array[Conversions.ToInteger(obj)], obj7);
				}
				while (ForLoopControl.ForNextCheckObj(obj5, obj6, ref obj5));
			}
			return (object[])Utils.CopyArray((Array)array, (Array)new object[Conversions.ToInteger(obj) + 1]);
		}
	}

	public object GetFileExt(ref string fna)
	{
		string oldstr = "\"";
		string newstr = "";
		string text = Conversions.ToString(StrReplace(ref oldstr, ref newstr, ref fna));
		string result = "";
		checked
		{
			if (Strings.Len(text) >= 3)
			{
				short num = (short)(Strings.Len(text) - 4);
				if (num < 1)
				{
					num = 1;
				}
				num = (short)Strings.InStr(unchecked((int)num), text, ".", (CompareMethod)1);
				if (num > 0)
				{
					result = Strings.Mid(text, unchecked((int)num), Strings.Len(text) - num + 1);
				}
			}
			return result;
		}
	}

	public object GetFilePath(ref string fna)
	{
		short num = checked((short)Strings.Len(fna));
		object obj = 0;
		object obj2 = 1;
		while (Operators.ConditionalCompareObjectLessEqual(obj2, (object)num, false))
		{
			string text = Strings.Mid(fna, Conversions.ToInteger(obj2), 1);
			if ((Operators.CompareString(text, "\\", false) == 0) | (Operators.CompareString(text, "/", false) == 0))
			{
				obj = RuntimeHelpers.GetObjectValue(obj2);
			}
			obj2 = Operators.AddObject(obj2, (object)1);
		}
		return Strings.Left(fna, Conversions.ToInteger(obj));
	}

	public object ExpandPath(ref string fna)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		checked
		{
			short num = (short)Strings.Len(fna);
			short num2 = 0;
			object obj = default(object);
			object obj2 = default(object);
			if (ForLoopControl.ForLoopInitObj(obj, (object)1, (object)num, (object)1, ref obj2, ref obj))
			{
				do
				{
					text = Strings.Mid(fna, Conversions.ToInteger(obj), 1);
					if (Operators.CompareString(text, "%", false) != 0)
					{
						if ((double)num2 == Conversion.Fix((double)num2 / 2.0) * 2.0)
						{
							text3 += text;
						}
						else
						{
							text2 += text;
						}
						continue;
					}
					num2 = (short)(num2 + 1);
					if ((double)num2 == Conversion.Fix((double)num2 / 2.0) * 2.0 && ((Strings.Len(text2) > 0) & (Operators.CompareString(Interaction.Environ(text2), "", false) != 0)))
					{
						text3 += Interaction.Environ(text2);
						text2 = "";
					}
				}
				while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
			}
			return text3;
		}
	}

	public object StrReplace(ref string oldstr, ref string newstr, ref string mainstr)
	{
		checked
		{
			_ = (short)Strings.Len(newstr);
			short num = (short)Strings.Len(oldstr);
			short num2 = (short)Strings.Len(mainstr);
			string text = "";
			string text2 = "";
			short num3 = 1;
			while (num3 <= Strings.Len(mainstr) - num + 1)
			{
				text = unchecked(Strings.Mid(mainstr, (int)num3, (int)num));
				if (Operators.CompareString(text, oldstr, false) == 0)
				{
					text2 += newstr;
					num3 = (short)unchecked(num3 + num);
				}
				else
				{
					text2 += Strings.Mid(mainstr, unchecked((int)num3), 1);
					num3 = (short)(num3 + 1);
				}
			}
			return text2 + Strings.Mid(mainstr, unchecked((int)num3), (short)unchecked(num2 - num3) + 1);
		}
	}

	public object StrDelim(ref string delim, ref string str_Renamed)
	{
		object[] array = new object[257];
		object obj = Strings.Len(delim);
		object obj2 = Strings.Len(str_Renamed);
		object obj3 = 1;
		object obj4 = 0;
		checked
		{
			short num = (short)Strings.InStr(Conversions.ToInteger(obj3), str_Renamed, delim, (CompareMethod)1);
			while (Conversions.ToBoolean(Operators.AndObject((object)(num > 0), Operators.CompareObjectLessEqual(obj3, Operators.SubtractObject(obj2, obj), false))))
			{
				array[Conversions.ToInteger(obj4)] = Strings.Mid(str_Renamed, Conversions.ToInteger(obj3), Conversions.ToInteger(Operators.SubtractObject((object)num, obj3)));
				obj3 = Operators.AddObject((object)num, obj);
				obj4 = Operators.AddObject(obj4, (object)1);
				num = (short)Strings.InStr(Conversions.ToInteger(obj3), str_Renamed, delim, (CompareMethod)1);
			}
			array[Conversions.ToInteger(obj4)] = Strings.Mid(str_Renamed, Conversions.ToInteger(obj3), Conversions.ToInteger(Operators.AddObject(Operators.SubtractObject(obj2, obj3), (object)1)));
			return (object[])Utils.CopyArray((Array)array, (Array)new object[Conversions.ToInteger(obj4) + 1]);
		}
	}

	public object FindFile(ref string fna)
	{
		object obj = "";
		object obj2 = 0;
		checked
		{
			if (!((Strings.Len(FileSystem.Dir(fna, (FileAttribute)0)) == 0) & (Strings.InStr(1, fna, "/", (CompareMethod)1) + Strings.InStr(1, fna, "\\", (CompareMethod)1) == 0)))
			{
				obj = ((Strings.Len(FileSystem.Dir(fna, (FileAttribute)0)) <= 0) ? "" : fna);
			}
			else
			{
				string mainstr = Interaction.Environ("PATH");
				string oldstr = "\"";
				string newstr = "";
				mainstr = Conversions.ToString(StrReplace(ref oldstr, ref newstr, ref mainstr));
				mainstr = Conversions.ToString(ExpandPath(ref mainstr));
				newstr = ";";
				object objectValue = RuntimeHelpers.GetObjectValue(StrDelim(ref newstr, ref mainstr));
				short num = (short)Information.UBound((Array)objectValue, 1);
				object obj3 = 0;
				while (Operators.ConditionalCompareObjectLess(obj3, (object)num, false))
				{
					if ((Operators.CompareString(Strings.Right(Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null)), Strings.Len(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null)))), "\\", false) != 0) & (Operators.CompareString(Strings.Right(Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null)), Strings.Len(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null)))), "/", false) != 0))
					{
						NewLateBinding.LateIndexSet(objectValue, new object[2]
						{
							RuntimeHelpers.GetObjectValue(obj3),
							Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null), (object)"\\")
						}, (string[])null);
					}
					obj = FileSystem.Dir(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[1] { RuntimeHelpers.GetObjectValue(obj3) }, (string[])null), (object)fna)), (FileAttribute)0);
					if (Strings.Len(RuntimeHelpers.GetObjectValue(obj)) > 0)
					{
						obj2 = RuntimeHelpers.GetObjectValue(obj3);
						obj3 = num;
					}
					obj3 = Operators.AddObject(obj3, (object)1);
				}
				if (Strings.Len(RuntimeHelpers.GetObjectValue(obj)) > 0)
				{
					obj = Operators.ConcatenateObject(NewLateBinding.LateIndexGet(objectValue, new object[1] { RuntimeHelpers.GetObjectValue(obj2) }, (string[])null), (object)fna);
				}
			}
			return RuntimeHelpers.GetObjectValue(obj);
		}
	}

	public object LeftStrip(ref string str_Renamed, ref short strlen)
	{
		while ((strlen > 0) & (Operators.CompareString(Strings.Left(str_Renamed, 1), " ", false) == 0))
		{
			checked
			{
				strlen--;
			}
			str_Renamed = Strings.Mid(str_Renamed, 2, (int)strlen);
		}
		return str_Renamed;
	}

	public object RightStrip(ref string str_Renamed, ref short strlen)
	{
		while ((strlen > 0) & (Operators.CompareString(Strings.Right(str_Renamed, 1), " ", false) == 0))
		{
			checked
			{
				strlen--;
			}
			str_Renamed = Strings.Left(str_Renamed, (int)strlen);
		}
		return str_Renamed;
	}

	public object ReadtxtFile(ref string fna, ref string[] txt, ref short flen)
	{
		int num = FileSystem.FreeFile();
		FileSystem.FileOpen(num, fna, (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
		checked
		{
			int num2 = (int)FileSystem.LOF(num);
			num2 = (int)Math.Round(Conversion.Fix((double)num2 / 80.0) + 1.0);
			txt = new string[num2 + 1];
			short num3 = 0;
			while (!FileSystem.EOF(num))
			{
				string text = FileSystem.LineInput(num);
				if (num3 > num2)
				{
					num2 = Conversion.Fix(num2 * 2);
					txt = (string[])Utils.CopyArray((Array)txt, (Array)new string[num2 + 1]);
				}
				txt[num3] = text;
				num3 = (short)(num3 + 1);
			}
			FileSystem.FileClose(new int[1] { num });
			txt = (string[])Utils.CopyArray((Array)txt, (Array)new string[num3 + 1]);
			flen = num3;
			return 0;
		}
	}

	public object ReadLspFile(ref string fna, ref string[] txt, ref short[] lsp, ref short flen)
	{
		int num = FileSystem.FreeFile();
		FileSystem.FileOpen(num, fna, (OpenMode)1, (OpenAccess)(-1), (OpenShare)(-1), -1);
		checked
		{
			int num2 = (int)FileSystem.LOF(num);
			num2 = (int)Math.Round(Conversion.Fix((double)num2 / 80.0) + 1.0);
			txt = new string[num2 + 1];
			lsp = new short[num2 + 1];
			object obj = 0;
			object obj2 = 0;
			while (!FileSystem.EOF(num))
			{
				object obj3 = FileSystem.LineInput(num);
				if (Operators.ConditionalCompareObjectGreater(obj, (object)num2, false))
				{
					num2 = Conversion.Fix(num2 * 2);
					txt = (string[])Utils.CopyArray((Array)txt, (Array)new string[num2 + 1]);
					lsp = (short[])Utils.CopyArray((Array)lsp, (Array)new short[num2 + 1]);
				}
				string strbuffer = Conversions.ToString(obj3);
				strbuffer = Conversions.ToString(PreProcessLSP(ref strbuffer));
				if (Strings.Len(strbuffer) > 0)
				{
					lsp[Conversions.ToInteger(obj2)] = Conversions.ToShort(obj);
					txt[Conversions.ToInteger(obj)] = strbuffer;
					obj2 = Operators.AddObject(obj2, (object)1);
				}
				else
				{
					txt[Conversions.ToInteger(obj)] = Conversions.ToString(obj3);
				}
				obj = Operators.AddObject(obj, (object)1);
			}
			FileSystem.FileClose(new int[1] { num });
			txt = (string[])Utils.CopyArray((Array)txt, (Array)new string[Conversions.ToInteger(obj) + 1]);
			lsp = (short[])Utils.CopyArray((Array)lsp, (Array)new short[Conversions.ToInteger(obj2) + 1]);
			flen = Conversions.ToShort(obj);
			return 0;
		}
	}

	public object PreProcessLSP(ref string strbuffer)
	{
		strbuffer = Strings.UCase(strbuffer);
		string oldstr = "\t";
		string newstr = " ";
		strbuffer = Conversions.ToString(StrReplace(ref oldstr, ref newstr, ref strbuffer));
		checked
		{
			short strlen = (short)Strings.Len(strbuffer);
			strbuffer = Conversions.ToString(LeftStrip(ref strbuffer, ref strlen));
			strbuffer = Conversions.ToString(RightStrip(ref strbuffer, ref strlen));
			strlen = (short)Strings.Len(strbuffer);
			object obj;
			if ((strlen > 0) & (Operators.CompareString(";", Strings.Left(strbuffer, 1), false) != 0))
			{
				newstr = "\\\\";
				oldstr = "/";
				strbuffer = Conversions.ToString(StrReplace(ref newstr, ref oldstr, ref strbuffer));
				newstr = "\\\"";
				oldstr = "";
				strbuffer = Conversions.ToString(StrReplace(ref newstr, ref oldstr, ref strbuffer));
				strlen = (short)Strings.Len(strbuffer);
				if (Strings.InStr(1, strbuffer, "\"", (CompareMethod)0) > 0)
				{
					string text = "";
					short num = 0;
					obj = 1;
					while (Operators.ConditionalCompareObjectLessEqual(obj, (object)strlen, false))
					{
						object obj2 = Strings.Mid(strbuffer, Conversions.ToInteger(obj), 1);
						if (Operators.ConditionalCompareObjectEqual(obj2, (object)'"', false))
						{
							num = (short)(num + 1);
						}
						if ((double)num != 2.0 * Conversion.Fix((double)num / 2.0))
						{
							if (Operators.ConditionalCompareObjectEqual(obj2, (object)";", false))
							{
								obj2 = "";
							}
							else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(obj2, (object)'(', false), Operators.CompareObjectEqual(obj2, (object)')', false))))
							{
								obj2 = "";
							}
						}
						text = Conversions.ToString(Operators.ConcatenateObject((object)text, obj2));
						obj = Operators.AddObject(obj, (object)1);
					}
					strbuffer = text;
				}
			}
			else
			{
				strbuffer = "";
			}
			obj = Strings.InStr(1, strbuffer, ";", (CompareMethod)1);
			if (Operators.ConditionalCompareObjectGreater(obj, (object)0, false))
			{
				strbuffer = Strings.Mid(strbuffer, 1, Conversions.ToInteger(Operators.SubtractObject(obj, (object)1)));
			}
			return strbuffer;
		}
	}

	public object parencount(ref string str_Renamed)
	{
		short num = checked((short)Strings.Len(str_Renamed));
		object obj = 0;
		object obj2 = 1;
		while (Operators.ConditionalCompareObjectLessEqual(obj2, (object)num, false))
		{
			string text = Strings.Mid(str_Renamed, Conversions.ToInteger(obj2), 1);
			if (Operators.CompareString(text, "(", false) == 0)
			{
				obj = Operators.AddObject(obj, (object)1);
			}
			else if (Operators.CompareString(text, ")", false) == 0)
			{
				obj = Operators.SubtractObject(obj, (object)1);
			}
			obj2 = Operators.AddObject(obj2, (object)1);
		}
		return RuntimeHelpers.GetObjectValue(obj);
	}

	public object FindFunCalls(ref string[] txt, ref short[] lsp, ref string fun, ref short[,] funcalls, ref short spos, ref short epos)
	{
		checked
		{
			short[] array = new short[(short)unchecked(epos - spos) + 1];
			_ = (short)Information.UBound((Array)lsp, 1);
			_ = (object)Information.UBound((Array)txt, 1);
			object obj = 0;
			object obj2 = spos;
			while (Operators.ConditionalCompareObjectLessEqual(obj2, (object)epos, false))
			{
				object obj3 = lsp[Conversions.ToInteger(obj2)];
				string text = txt[Conversions.ToInteger(obj3)];
				if (Strings.InStr(1, text, fun, (CompareMethod)0) > 0)
				{
					array[Conversions.ToInteger(obj)] = Conversions.ToShort(obj2);
					obj = Operators.AddObject(obj, (object)1);
				}
				obj2 = Operators.AddObject(obj2, (object)1);
			}
			array = (short[])Utils.CopyArray((Array)array, (Array)new short[Conversions.ToInteger(obj) + 1]);
			funcalls = new short[Conversions.ToInteger(obj) + 1, 2];
			obj2 = 0;
			while (Operators.ConditionalCompareObjectLessEqual(obj2, obj, false))
			{
				object obj3 = array[Conversions.ToInteger(obj2)];
				funcalls[Conversions.ToInteger(obj2), 0] = Conversions.ToShort(obj3);
				object obj4 = 0;
				do
				{
					object obj5 = lsp[Conversions.ToInteger(obj3)];
					string text = txt[Conversions.ToInteger(obj5)];
					obj4 = Operators.AddObject(obj4, parencount(ref text));
					obj3 = Operators.AddObject(obj3, (object)1);
				}
				while (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(obj4, (object)0, false), Operators.CompareObjectGreater(obj3, (object)epos, false))));
				funcalls[Conversions.ToInteger(obj2), 1] = Conversions.ToShort(Operators.SubtractObject(obj3, (object)1));
				obj2 = Operators.AddObject(obj2, (object)1);
			}
			return 0;
		}
	}

	private void Command1_Click(object sender, EventArgs e)
	{
		((Control)DefInstance).set_Cursor(Cursors.get_WaitCursor());
		txt = null;
		txt2 = null;
		lsp = null;
		defuns = null;
		Text4.set_Text("");
		Combo1.get_Items().Clear();
		string fna = Text1.get_Text();
		fna = Conversions.ToString(FindFile(ref fna));
		checked
		{
			if (Strings.Len(fna) > 0)
			{
				Text4.set_Text("Reading File: " + fna);
				Application.DoEvents();
				short flen = default(short);
				ReadLspFile(ref fna, ref txt, ref lsp, ref flen);
				ReadtxtFile(ref fna, ref txt2, ref flen);
				Text4.set_Text("");
				Text4.set_Text("Searching for defun's...");
				Application.DoEvents();
				short epos = (short)Information.UBound((Array)lsp, 1);
				ref string[] reference = ref txt;
				ref short[] reference2 = ref lsp;
				string fun = "(DEFUN ";
				ref short[,] funcalls = ref defuns;
				short spos = 0;
				FindFunCalls(ref reference, ref reference2, ref fun, ref funcalls, ref spos, ref epos);
				Text4.set_Text("Done.");
				object obj = Information.UBound((Array)defuns, 1);
				object obj2 = 0;
				short num;
				while (Operators.ConditionalCompareObjectLess(obj2, obj, false))
				{
					num = defuns[Conversions.ToInteger(obj2), 0];
					num = lsp[num];
					fna = txt[num];
					num = (short)(Strings.InStr(1, fna, "(DEFUN ", (CompareMethod)1) + 7);
					fna = Strings.Mid(fna, unchecked((int)num));
					if (Strings.InStr(1, fna, " ", (CompareMethod)1) > 0)
					{
						num = (short)Strings.InStr(1, fna, " ", (CompareMethod)1);
						fna = Strings.Mid(fna, 1, num - 1);
					}
					if (Strings.InStr(1, fna, "(", (CompareMethod)1) > 0)
					{
						num = (short)Strings.InStr(1, fna, "(", (CompareMethod)1);
						fna = Strings.Mid(fna, 1, num - 1);
					}
					Combo1.get_Items().Add((object)fna);
					obj2 = Operators.AddObject(obj2, (object)1);
				}
				num = defuns[0, 0];
				num = lsp[num];
				fna = txt[num];
				num = (short)(Strings.InStr(1, fna, "(DEFUN ", (CompareMethod)1) + 7);
				fna = Strings.Mid(fna, unchecked((int)num));
				if (Strings.InStr(1, fna, " ", (CompareMethod)1) > 0)
				{
					num = (short)Strings.InStr(1, fna, " ", (CompareMethod)1);
					fna = Strings.Mid(fna, 1, num - 1);
				}
				if (Strings.InStr(1, fna, "(", (CompareMethod)1) > 0)
				{
					num = (short)Strings.InStr(1, fna, "(", (CompareMethod)1);
					fna = Strings.Mid(fna, 1, num - 1);
				}
				Combo1.set_Text(fna);
				if (Combo1.get_SelectedIndex() != -1)
				{
					Combo1.set_SelectedIndex(0);
				}
			}
			else
			{
				Text4.set_Text(resources.GetString("cantFindFile"));
			}
			((Control)DefInstance).set_Cursor(Cursors.get_Default());
		}
	}

	private void Combo1_SelectedIndexChanged(object sender, EventArgs e)
	{
		short n = checked((short)Combo1.get_SelectedIndex());
		clik_it(ref n);
	}

	public object clik_it(ref short n)
	{
		((Control)DefInstance).set_Cursor(Cursors.get_WaitCursor());
		checked
		{
			if (n >= 0)
			{
				short num;
				object obj;
				if (Option1.get_Checked())
				{
					obj = defuns[n, 0] - 1;
					if (Operators.ConditionalCompareObjectLess(obj, (object)0, false))
					{
						obj = 0;
					}
					else
					{
						obj = lsp[Conversions.ToInteger(obj)];
						obj = Operators.AddObject(obj, (object)1);
					}
					num = lsp[defuns[n, 0]];
				}
				else if (Option2.get_Checked())
				{
					obj = defuns[n, 0];
					obj = lsp[Conversions.ToInteger(obj)];
					num = lsp[defuns[n, 1]];
				}
				else
				{
					obj = defuns[n, 0] - 1;
					if (Operators.ConditionalCompareObjectLess(obj, (object)0, false))
					{
						obj = 0;
					}
					else
					{
						obj = lsp[Conversions.ToInteger(obj)];
						obj = Operators.AddObject(obj, (object)1);
					}
					num = lsp[defuns[n, 1]];
				}
				Text2.set_Text(Conversions.ToString(obj));
				Text3.set_Text(Conversions.ToString(unchecked((int)num)));
				n = Conversions.ToShort(obj);
				string text = "";
				while (n <= num)
				{
					text = text + txt2[n] + "\r\n";
					n++;
				}
				Text4.set_Text(text);
			}
			((Control)DefInstance).set_Cursor(Cursors.get_Default());
			return 0;
		}
	}

	private void Drive1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = Conversions.ToString(Drive1.get_Items().get_Item(Drive1.get_SelectedIndex()));
		text = Strings.Left(text, 1);
		currentFile = (currentDirectory = FileSystem.CurDir(Conversions.ToChar(text)));
		RefreshFile();
		RefreshDir();
	}

	private void RefreshFile()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
		File1.get_Items().Clear();
		if (directoryInfo.get_Exists())
		{
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				if ((Operators.CompareString(fileInfo.Extension, ".lsp", false) == 0) | (Operators.CompareString(fileInfo.Extension, ".mnl", false) == 0))
				{
					File1.get_Items().Add((object)fileInfo.get_Name());
				}
			}
		}
		((Control)File1).Update();
	}

	private void RefreshDir()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
		Dir1.BeginUpdate();
		Dir1.get_Nodes().Clear();
		checked
		{
			if (directoryInfo.get_Exists())
			{
				ArrayList arrayList = new ArrayList();
				for (DirectoryInfo directoryInfo2 = directoryInfo; directoryInfo2 != null; directoryInfo2 = directoryInfo2.Parent)
				{
					arrayList.Add(directoryInfo2);
				}
				DirectoryInfo directoryInfo3 = (DirectoryInfo)arrayList[arrayList.Count - 1];
				TreeNode val = new TreeNode(directoryInfo3.get_Name(), 0, 0);
				Dir1.get_Nodes().Add(val);
				for (int i = arrayList.Count - 2; i >= 0; i += -1)
				{
					directoryInfo3 = (DirectoryInfo)arrayList[i];
					val.get_Nodes().Add(new TreeNode(directoryInfo3.get_Name(), 0, 0));
					val = val.get_Nodes().get_Item(0);
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo4 in directories)
				{
					val.get_Nodes().Add(new TreeNode(directoryInfo4.get_Name(), 1, 1));
				}
				Dir1.get_Nodes().get_Item(0).ExpandAll();
				Dir1.set_SelectedNode(val);
			}
			Dir1.EndUpdate();
		}
	}

	private void Dir1_DoubleClick(object sender, EventArgs e)
	{
		currentDirectory = Dir1.get_SelectedNode().get_FullPath().Replace("\\\\", "\\");
		RefreshDir();
	}

	private void Dir1_SelectedIndexChanged(object sender, TreeViewEventArgs e)
	{
		currentDirectory = Dir1.get_SelectedNode().get_FullPath().Replace("\\\\", "\\");
		RefreshFile();
	}

	private void File1_SelectedIndexChanged(object sender, EventArgs e)
	{
		currentFile = Conversions.ToString(File1.get_SelectedItem());
		Text1.set_Text(Dir1.get_SelectedNode().get_FullPath() + "\\" + currentFile);
		Text1.set_Text(Text1.get_Text().Replace("\\\\", "\\"));
	}

	private void Form1_Resize(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)((Form)DefInstance).get_WindowState() != 1)
		{
			if (((Control)DefInstance).get_Width() < 760)
			{
				((Control)DefInstance).set_Width(760);
			}
			if (((Control)DefInstance).get_Height() < 489)
			{
				((Control)DefInstance).set_Height(489);
			}
			((Control)Text4).set_Top(48);
			checked
			{
				((Control)Text4).set_Width(((Control)DefInstance).get_Width() - 310);
				((Control)Text4).set_Height(((Control)DefInstance).get_Height() - 90);
			}
		}
	}

	private void Option1_CheckedChanged(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			short n = checked((short)Combo1.get_SelectedIndex());
			clik_it(ref n);
		}
	}

	private void Option2_CheckedChanged(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			short n = checked((short)Combo1.get_SelectedIndex());
			clik_it(ref n);
		}
	}

	private void Option3_CheckedChanged(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			short n = checked((short)Combo1.get_SelectedIndex());
			clik_it(ref n);
		}
	}

	private void GetDrives()
	{
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text in array)
		{
			Drive1.get_Items().Add((object)text);
		}
		Drive1.set_SelectedIndex(Drive1.get_Items().IndexOf((object)Path.GetPathRoot(currentDirectory)));
	}

	private void getProductInfoFromRegistryString(string productReg, ref string prodInfo)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					char[] separator = new char[1] { '\\' };
					string[] array = productReg.Split(separator, 5);
					if (array.GetLength(0) == 5)
					{
						prodInfo = array[4].Substring(checked(array[4].IndexOf(":") + 1));
					}
					break;
				}
				case 67:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_007b;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 67;
				continue;
			}
			break;
			IL_007b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void LoadResource()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						string location = Assembly.GetEntryAssembly()!.Location;
						string path = location.Substring(0, location.LastIndexOf("\\") + 1) + "..\\identity.ini";
						if (!File.Exists(path))
						{
							break;
						}
						StreamReader streamReader = File.OpenText(path);
						string text = streamReader.ReadLine();
						if (!text.Equals("[ProductIdentity]"))
						{
							break;
						}
						text = streamReader.ReadLine();
						streamReader.Close();
						int num3 = text.IndexOf("=");
						if (num3 < 0)
						{
							break;
						}
						string text2 = text.Substring(num3 + 1);
						char[] separator = new char[1] { '\\' };
						string[] array = text2.Split(separator, 5);
						if (array.Length == 5)
						{
							string prodInfo = "";
							getProductInfoFromRegistryString(text2, ref prodInfo);
							if (!(Conversions.ToDouble(prodInfo) > 3.0))
							{
								int culture = int.Parse(prodInfo, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
								Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture, useUserOverride: true);
							}
						}
						break;
					}
					case 263:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0141;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 263;
				continue;
			}
			break;
			IL_0141:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		LoadResource();
		HelpProvider1.set_HelpNamespace(Path.GetDirectoryName(Application.get_ExecutablePath()) + "\\acet.chm");
		((Control)Dir1).set_Font(new Font("Times New Roman", 10f));
		((Control)Drive1).set_Font(new Font("Times New Roman", 10f));
		File1.set_Font(new Font("Times New Roman", 10f));
		((Control)Text1).set_Font(new Font("Times New Roman", 8f));
		((Control)Text4).set_Font(new Font("Times New Roman", 10f));
		((Control)Combo1).set_Font(new Font("Times New Roman", 10f));
		currentDirectory = Path.GetDirectoryName(Application.get_ExecutablePath());
		NewLateBinding.LateCall((object)myImageList.get_Images(), (Type)null, "Add", new object[1] { RuntimeHelpers.GetObjectValue(resources.GetObject("sgna_subfldr.ico")) }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall((object)myImageList.get_Images(), (Type)null, "Add", new object[1] { RuntimeHelpers.GetObjectValue(resources.GetObject("sgna_folder.ico")) }, (string[])null, (Type[])null, (bool[])null, true);
		Dir1.set_ImageList(myImageList);
		GetDrives();
	}
}

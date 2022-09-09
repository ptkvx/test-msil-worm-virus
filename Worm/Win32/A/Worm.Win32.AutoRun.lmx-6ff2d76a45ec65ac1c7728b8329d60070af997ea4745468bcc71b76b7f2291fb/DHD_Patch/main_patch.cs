using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DHD_Patch.Properties;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Microsoft.Win32;

namespace DHD_Patch;

public class main_patch : XtraForm
{
	public delegate void my_mod_stat(string stat);

	public delegate void my_enable_install();

	public delegate void my_install_progress(int count);

	private IContainer components;

	private SplitContainer splitContainer1;

	private PictureBox pictureBox1;

	private DefaultLookAndFeel defaultLookAndFeel1;

	private SimpleButton simpleButton3;

	private SimpleButton sel_all;

	private SimpleButton d_install;

	private ProgressBarControl install_progressBar;

	private LabelControl labelControl1;

	private XtraTabControl tabControl1;

	private XtraTabPage xtraTabPage1;

	private XtraTabPage xtraTabPage2;

	private TreeList install_list;

	private TreeListColumn patch_list;

	private TreeList un_installed_patch;

	private TreeListColumn kb_num;

	private TreeListColumn descp;

	private TreeListColumn down_url;

	private TreeListColumn sta;

	private ImageList imageList1;

	private string kb_list = "";

	private Mutex ltt;

	private bool is_check_all;

	private Point MouseCurrrnetPos;

	private Point MouseNewPos;

	private Point formPos;

	private Point formNewPos;

	private bool mouseDown;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((XtraForm)this).Dispose(disposing);
	}

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
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbb: Expected O, but got Unknown
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected O, but got Unknown
		//IL_1b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(main_patch));
		splitContainer1 = new SplitContainer();
		tabControl1 = new XtraTabControl();
		xtraTabPage1 = new XtraTabPage();
		un_installed_patch = new TreeList();
		kb_num = new TreeListColumn();
		descp = new TreeListColumn();
		down_url = new TreeListColumn();
		sta = new TreeListColumn();
		imageList1 = new ImageList(components);
		xtraTabPage2 = new XtraTabPage();
		install_list = new TreeList();
		patch_list = new TreeListColumn();
		labelControl1 = new LabelControl();
		install_progressBar = new ProgressBarControl();
		simpleButton3 = new SimpleButton();
		sel_all = new SimpleButton();
		d_install = new SimpleButton();
		pictureBox1 = new PictureBox();
		defaultLookAndFeel1 = new DefaultLookAndFeel(components);
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((ISupportInitialize)tabControl1).BeginInit();
		((Control)tabControl1).SuspendLayout();
		((Control)xtraTabPage1).SuspendLayout();
		((ISupportInitialize)un_installed_patch).BeginInit();
		((Control)xtraTabPage2).SuspendLayout();
		((ISupportInitialize)install_list).BeginInit();
		((ISupportInitialize)install_progressBar.get_Properties()).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)splitContainer1).set_BackColor(Color.White);
		splitContainer1.set_Dock((DockStyle)5);
		splitContainer1.set_IsSplitterFixed(true);
		((Control)splitContainer1).set_Location(new Point(0, 0));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Orientation((Orientation)0);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)tabControl1);
		((Control)splitContainer1.get_Panel2()).set_BackColor(Color.White);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)labelControl1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)install_progressBar);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)simpleButton3);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)sel_all);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)d_install);
		((Control)splitContainer1).set_Size(new Size(752, 456));
		splitContainer1.set_SplitterDistance(360);
		((Control)splitContainer1).set_TabIndex(0);
		((Control)tabControl1).set_Dock((DockStyle)5);
		((Control)tabControl1).set_Location(new Point(0, 0));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedTabPage(xtraTabPage1);
		((Control)tabControl1).set_Size(new Size(752, 360));
		((Control)tabControl1).set_TabIndex(0);
		tabControl1.get_TabPages().AddRange((XtraTabPage[])(object)new XtraTabPage[2] { xtraTabPage1, xtraTabPage2 });
		((Control)tabControl1).set_Text("xtraTabControl1");
		((Control)xtraTabPage1).get_Controls().Add((Control)(object)un_installed_patch);
		xtraTabPage1.set_Image((Image)(object)Resources.Bitmap_0);
		((Control)xtraTabPage1).set_Name("xtraTabPage1");
		xtraTabPage1.set_Size(new Size(743, 312));
		((Control)xtraTabPage1).set_Text("未安装补丁");
		un_installed_patch.get_Appearance().get_Empty().set_BackColor(Color.White);
		un_installed_patch.get_Appearance().get_Empty().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_EvenRow().set_BackColor(Color.FromArgb(231, 242, 254));
		un_installed_patch.get_Appearance().get_EvenRow().set_ForeColor(Color.Black);
		un_installed_patch.get_Appearance().get_EvenRow().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_EvenRow().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_FocusedCell().set_BackColor(Color.White);
		un_installed_patch.get_Appearance().get_FocusedCell().set_ForeColor(Color.Black);
		un_installed_patch.get_Appearance().get_FocusedCell().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_FocusedCell().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_FocusedRow().set_BackColor(Color.FromArgb(49, 106, 197));
		un_installed_patch.get_Appearance().get_FocusedRow().set_ForeColor(Color.White);
		un_installed_patch.get_Appearance().get_FocusedRow().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_FocusedRow().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_FooterPanel().set_BackColor(Color.FromArgb(221, 236, 254));
		un_installed_patch.get_Appearance().get_FooterPanel().set_BackColor2(Color.FromArgb(132, 171, 228));
		un_installed_patch.get_Appearance().get_FooterPanel().set_BorderColor(Color.FromArgb(221, 236, 254));
		un_installed_patch.get_Appearance().get_FooterPanel().set_ForeColor(Color.Black);
		un_installed_patch.get_Appearance().get_FooterPanel().set_GradientMode((LinearGradientMode)1);
		un_installed_patch.get_Appearance().get_FooterPanel().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_FooterPanel().get_Options()
			.set_UseBorderColor(true);
		un_installed_patch.get_Appearance().get_FooterPanel().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_GroupButton().set_BackColor(Color.FromArgb(193, 216, 247));
		un_installed_patch.get_Appearance().get_GroupButton().set_BorderColor(Color.FromArgb(193, 216, 247));
		un_installed_patch.get_Appearance().get_GroupButton().set_ForeColor(Color.Black);
		un_installed_patch.get_Appearance().get_GroupButton().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_GroupButton().get_Options()
			.set_UseBorderColor(true);
		un_installed_patch.get_Appearance().get_GroupButton().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_GroupFooter().set_BackColor(Color.FromArgb(193, 216, 247));
		un_installed_patch.get_Appearance().get_GroupFooter().set_BorderColor(Color.FromArgb(193, 216, 247));
		un_installed_patch.get_Appearance().get_GroupFooter().set_ForeColor(Color.Black);
		un_installed_patch.get_Appearance().get_GroupFooter().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_GroupFooter().get_Options()
			.set_UseBorderColor(true);
		un_installed_patch.get_Appearance().get_GroupFooter().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_HeaderPanel().set_BackColor(Color.FromArgb(221, 236, 254));
		un_installed_patch.get_Appearance().get_HeaderPanel().set_BackColor2(Color.FromArgb(132, 171, 228));
		un_installed_patch.get_Appearance().get_HeaderPanel().set_BorderColor(Color.FromArgb(221, 236, 254));
		un_installed_patch.get_Appearance().get_HeaderPanel().set_ForeColor(Color.Black);
		un_installed_patch.get_Appearance().get_HeaderPanel().set_GradientMode((LinearGradientMode)1);
		un_installed_patch.get_Appearance().get_HeaderPanel().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_HeaderPanel().get_Options()
			.set_UseBorderColor(true);
		un_installed_patch.get_Appearance().get_HeaderPanel().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_HideSelectionRow().set_BackColor(Color.FromArgb(106, 153, 228));
		un_installed_patch.get_Appearance().get_HideSelectionRow().set_ForeColor(Color.FromArgb(208, 224, 251));
		un_installed_patch.get_Appearance().get_HideSelectionRow().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_HideSelectionRow().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_HorzLine().set_BackColor(Color.FromArgb(99, 127, 196));
		un_installed_patch.get_Appearance().get_HorzLine().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_OddRow().set_BackColor(Color.White);
		un_installed_patch.get_Appearance().get_OddRow().set_ForeColor(Color.Black);
		un_installed_patch.get_Appearance().get_OddRow().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_OddRow().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_Preview().set_BackColor(Color.FromArgb(249, 252, 255));
		un_installed_patch.get_Appearance().get_Preview().set_ForeColor(Color.FromArgb(88, 129, 185));
		un_installed_patch.get_Appearance().get_Preview().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_Preview().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_Row().set_BackColor(Color.White);
		un_installed_patch.get_Appearance().get_Row().set_ForeColor(Color.Black);
		un_installed_patch.get_Appearance().get_Row().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_Row().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_SelectedRow().set_BackColor(Color.FromArgb(69, 126, 217));
		un_installed_patch.get_Appearance().get_SelectedRow().set_ForeColor(Color.White);
		un_installed_patch.get_Appearance().get_SelectedRow().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_SelectedRow().get_Options()
			.set_UseForeColor(true);
		un_installed_patch.get_Appearance().get_TreeLine().set_BackColor(Color.FromArgb(59, 97, 156));
		un_installed_patch.get_Appearance().get_TreeLine().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Appearance().get_VertLine().set_BackColor(Color.FromArgb(99, 127, 196));
		un_installed_patch.get_Appearance().get_VertLine().get_Options()
			.set_UseBackColor(true);
		un_installed_patch.get_Columns().AddRange((TreeListColumn[])(object)new TreeListColumn[4] { kb_num, descp, down_url, sta });
		((Control)un_installed_patch).set_Dock((DockStyle)5);
		((Control)un_installed_patch).set_Location(new Point(0, 0));
		((Control)un_installed_patch).set_Name("un_installed_patch");
		un_installed_patch.get_OptionsView().set_EnableAppearanceEvenRow(true);
		un_installed_patch.get_OptionsView().set_EnableAppearanceOddRow(true);
		un_installed_patch.get_OptionsView().set_ShowRoot(false);
		((Control)un_installed_patch).set_Size(new Size(743, 312));
		un_installed_patch.set_StateImageList((object)imageList1);
		((Control)un_installed_patch).set_TabIndex(1);
		((Control)un_installed_patch).add_MouseDown(new MouseEventHandler(un_installed_patch_MouseDown));
		kb_num.set_Caption("补丁编号");
		kb_num.set_FieldName("补丁编号");
		kb_num.set_MinWidth(27);
		kb_num.set_Name("kb_num");
		kb_num.get_OptionsColumn().set_AllowEdit(false);
		kb_num.get_OptionsColumn().set_ReadOnly(true);
		kb_num.set_Visible(true);
		kb_num.set_VisibleIndex(0);
		descp.set_Caption("描述");
		descp.set_FieldName("描述");
		descp.set_Name("descp");
		descp.get_OptionsColumn().set_AllowEdit(false);
		descp.get_OptionsColumn().set_ReadOnly(true);
		descp.set_Visible(true);
		descp.set_VisibleIndex(1);
		down_url.set_Caption("下载地址");
		down_url.set_FieldName("下载地址");
		down_url.set_Name("down_url");
		down_url.get_OptionsColumn().set_AllowEdit(false);
		down_url.get_OptionsColumn().set_ReadOnly(true);
		down_url.set_Visible(true);
		down_url.set_VisibleIndex(2);
		sta.set_Caption("状态");
		sta.set_FieldName("状态");
		sta.set_Name("sta");
		sta.get_OptionsColumn().set_AllowEdit(false);
		sta.get_OptionsColumn().set_ReadOnly(true);
		sta.set_Visible(true);
		sta.set_VisibleIndex(3);
		imageList1.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream"));
		imageList1.set_TransparentColor(Color.Magenta);
		imageList1.get_Images().SetKeyName(0, "");
		imageList1.get_Images().SetKeyName(1, "");
		imageList1.get_Images().SetKeyName(2, "");
		((Control)xtraTabPage2).get_Controls().Add((Control)(object)install_list);
		xtraTabPage2.set_Image((Image)(object)Resources.Bitmap_1);
		((Control)xtraTabPage2).set_Name("xtraTabPage2");
		xtraTabPage2.set_Size(new Size(743, 312));
		((Control)xtraTabPage2).set_Text("已安装补丁");
		install_list.get_Appearance().get_Empty().set_BackColor(Color.White);
		install_list.get_Appearance().get_Empty().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_EvenRow().set_BackColor(Color.FromArgb(231, 242, 254));
		install_list.get_Appearance().get_EvenRow().set_ForeColor(Color.Black);
		install_list.get_Appearance().get_EvenRow().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_EvenRow().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_FocusedCell().set_BackColor(Color.White);
		install_list.get_Appearance().get_FocusedCell().set_ForeColor(Color.Black);
		install_list.get_Appearance().get_FocusedCell().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_FocusedCell().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_FocusedRow().set_BackColor(Color.FromArgb(49, 106, 197));
		install_list.get_Appearance().get_FocusedRow().set_ForeColor(Color.White);
		install_list.get_Appearance().get_FocusedRow().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_FocusedRow().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_FooterPanel().set_BackColor(Color.FromArgb(221, 236, 254));
		install_list.get_Appearance().get_FooterPanel().set_BackColor2(Color.FromArgb(132, 171, 228));
		install_list.get_Appearance().get_FooterPanel().set_BorderColor(Color.FromArgb(221, 236, 254));
		install_list.get_Appearance().get_FooterPanel().set_ForeColor(Color.Black);
		install_list.get_Appearance().get_FooterPanel().set_GradientMode((LinearGradientMode)1);
		install_list.get_Appearance().get_FooterPanel().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_FooterPanel().get_Options()
			.set_UseBorderColor(true);
		install_list.get_Appearance().get_FooterPanel().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_GroupButton().set_BackColor(Color.FromArgb(193, 216, 247));
		install_list.get_Appearance().get_GroupButton().set_BorderColor(Color.FromArgb(193, 216, 247));
		install_list.get_Appearance().get_GroupButton().set_ForeColor(Color.Black);
		install_list.get_Appearance().get_GroupButton().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_GroupButton().get_Options()
			.set_UseBorderColor(true);
		install_list.get_Appearance().get_GroupButton().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_GroupFooter().set_BackColor(Color.FromArgb(193, 216, 247));
		install_list.get_Appearance().get_GroupFooter().set_BorderColor(Color.FromArgb(193, 216, 247));
		install_list.get_Appearance().get_GroupFooter().set_ForeColor(Color.Black);
		install_list.get_Appearance().get_GroupFooter().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_GroupFooter().get_Options()
			.set_UseBorderColor(true);
		install_list.get_Appearance().get_GroupFooter().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_HeaderPanel().set_BackColor(Color.FromArgb(221, 236, 254));
		install_list.get_Appearance().get_HeaderPanel().set_BackColor2(Color.FromArgb(132, 171, 228));
		install_list.get_Appearance().get_HeaderPanel().set_BorderColor(Color.FromArgb(221, 236, 254));
		install_list.get_Appearance().get_HeaderPanel().set_ForeColor(Color.Black);
		install_list.get_Appearance().get_HeaderPanel().set_GradientMode((LinearGradientMode)1);
		install_list.get_Appearance().get_HeaderPanel().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_HeaderPanel().get_Options()
			.set_UseBorderColor(true);
		install_list.get_Appearance().get_HeaderPanel().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_HideSelectionRow().set_BackColor(Color.FromArgb(106, 153, 228));
		install_list.get_Appearance().get_HideSelectionRow().set_ForeColor(Color.FromArgb(208, 224, 251));
		install_list.get_Appearance().get_HideSelectionRow().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_HideSelectionRow().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_HorzLine().set_BackColor(Color.FromArgb(99, 127, 196));
		install_list.get_Appearance().get_HorzLine().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_OddRow().set_BackColor(Color.White);
		install_list.get_Appearance().get_OddRow().set_ForeColor(Color.Black);
		install_list.get_Appearance().get_OddRow().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_OddRow().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_Preview().set_BackColor(Color.FromArgb(249, 252, 255));
		install_list.get_Appearance().get_Preview().set_ForeColor(Color.FromArgb(88, 129, 185));
		install_list.get_Appearance().get_Preview().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_Preview().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_Row().set_BackColor(Color.White);
		install_list.get_Appearance().get_Row().set_ForeColor(Color.Black);
		install_list.get_Appearance().get_Row().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_Row().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_SelectedRow().set_BackColor(Color.FromArgb(69, 126, 217));
		install_list.get_Appearance().get_SelectedRow().set_ForeColor(Color.White);
		install_list.get_Appearance().get_SelectedRow().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_SelectedRow().get_Options()
			.set_UseForeColor(true);
		install_list.get_Appearance().get_TreeLine().set_BackColor(Color.FromArgb(59, 97, 156));
		install_list.get_Appearance().get_TreeLine().get_Options()
			.set_UseBackColor(true);
		install_list.get_Appearance().get_VertLine().set_BackColor(Color.FromArgb(99, 127, 196));
		install_list.get_Appearance().get_VertLine().get_Options()
			.set_UseBackColor(true);
		install_list.get_Columns().AddRange((TreeListColumn[])(object)new TreeListColumn[1] { patch_list });
		((Control)install_list).set_Dock((DockStyle)5);
		((Control)install_list).set_Location(new Point(0, 0));
		((Control)install_list).set_Name("install_list");
		install_list.get_OptionsView().set_EnableAppearanceEvenRow(true);
		install_list.get_OptionsView().set_EnableAppearanceOddRow(true);
		install_list.get_OptionsView().set_ShowRoot(false);
		((Control)install_list).set_Size(new Size(743, 312));
		((Control)install_list).set_TabIndex(1);
		patch_list.set_Caption("已安装补丁");
		patch_list.set_FieldName("已安装补丁");
		patch_list.set_Name("patch_list");
		patch_list.get_OptionsColumn().set_AllowEdit(false);
		patch_list.get_OptionsColumn().set_ReadOnly(true);
		patch_list.set_Visible(true);
		patch_list.set_VisibleIndex(0);
		((Control)labelControl1).set_Location(new Point(11, 21));
		((Control)labelControl1).set_Name("labelControl1");
		((Control)labelControl1).set_Size(new Size(60, 14));
		((Control)labelControl1).set_TabIndex(7);
		((Control)labelControl1).set_Text("安装进度：");
		((Control)install_progressBar).set_Location(new Point(83, 19));
		((Control)install_progressBar).set_Name("install_progressBar");
		((Control)install_progressBar).set_Size(new Size(613, 18));
		((Control)install_progressBar).set_TabIndex(6);
		((Control)simpleButton3).set_Location(new Point(343, 50));
		((Control)simpleButton3).set_Name("simpleButton3");
		((Control)simpleButton3).set_Size(new Size(106, 23));
		((Control)simpleButton3).set_TabIndex(5);
		((Control)simpleButton3).set_Text("检测未安装补丁");
		((Control)simpleButton3).add_Click((EventHandler)start_Click);
		((Control)sel_all).set_Location(new Point(466, 50));
		((Control)sel_all).set_Name("sel_all");
		((Control)sel_all).set_Size(new Size(106, 23));
		((Control)sel_all).set_TabIndex(4);
		((Control)sel_all).set_Text("全选");
		((Control)sel_all).add_Click((EventHandler)sel_all_Click);
		((Control)d_install).set_Location(new Point(590, 50));
		((Control)d_install).set_Name("d_install");
		((Control)d_install).set_Size(new Size(106, 23));
		((Control)d_install).set_TabIndex(3);
		((Control)d_install).set_Text("下载并安装");
		((Control)d_install).add_Click((EventHandler)d_install_Click);
		((Control)pictureBox1).set_Dock((DockStyle)5);
		pictureBox1.set_Image((Image)(object)Resources.Bitmap_2);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(752, 456));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		defaultLookAndFeel1.get_LookAndFeel().set_SkinName("Black");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(752, 456));
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("main_patch");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("DHD补丁升级工具");
		((Form)this).add_Load((EventHandler)main_patch_Load);
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).PerformLayout();
		((Control)splitContainer1).ResumeLayout(false);
		((ISupportInitialize)tabControl1).EndInit();
		((Control)tabControl1).ResumeLayout(false);
		((Control)xtraTabPage1).ResumeLayout(false);
		((ISupportInitialize)un_installed_patch).EndInit();
		((Control)xtraTabPage2).ResumeLayout(false);
		((ISupportInitialize)install_list).EndInit();
		((ISupportInitialize)install_progressBar.get_Properties()).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public main_patch()
	{
		InitializeComponent();
	}

	private void main_patch_Load(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		SkinProject2 val = new SkinProject2();
		try
		{
			int num = Environment.CommandLine.IndexOf("style");
			num += 6;
			string skinName = Environment.CommandLine.Substring(num);
			defaultLookAndFeel1.get_LookAndFeel().set_SkinName(skinName);
		}
		catch
		{
		}
		defaultLookAndFeel1.get_LookAndFeel().set_SkinName(val.get_SkinInfo1()[0]);
		ltt = new Mutex(initiallyOwned: true, "DHD_PATCH_CDBD", out var createdNew);
		if (!createdNew)
		{
			MessageBox.Show("你已经运行了一个程序！", "运行失败", (MessageBoxButtons)0, (MessageBoxIcon)16);
			ltt.Close();
			((Form)this).Close();
		}
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("http://sc.dhd365.com/dhd/patch_list.dat", "tmp.dat");
			webClient.Dispose();
			File.Copy("tmp.dat", "patch.dat", overwrite: true);
		}
		catch
		{
		}
		try
		{
			list_patch();
			tabControl1.set_SelectedTabPageIndex(0);
			cmp_patch("patch.dat");
			if (Environment.CommandLine.IndexOf("update_all") != -1)
			{
				check_all();
				update();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	public void list_patch()
	{
		try
		{
			RegistryKey localMachine = Registry.LocalMachine;
			RegistryKey registryKey = localMachine.OpenSubKey("SOFTWARE\\Microsoft\\Updates");
			string[] subKeyNames = registryKey.GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				RegistryKey registryKey2 = registryKey.OpenSubKey(text);
				if (text.StartsWith("KB"))
				{
					kb_list = kb_list + "<" + text + ">";
					install_list.AppendNode((object)null, (TreeListNode)null).SetValue((object)0, (object)text);
				}
				string[] subKeyNames2 = registryKey2.GetSubKeyNames();
				foreach (string text2 in subKeyNames2)
				{
					RegistryKey registryKey3 = registryKey2.OpenSubKey(text2);
					if (text2.StartsWith("KB"))
					{
						kb_list = kb_list + "<" + text2 + ">";
						install_list.AppendNode((object)null, (TreeListNode)null).SetValue((object)0, (object)text2);
					}
					string[] subKeyNames3 = registryKey3.GetSubKeyNames();
					foreach (string text3 in subKeyNames3)
					{
						if (text3.StartsWith("KB"))
						{
							kb_list = kb_list + "<" + text3 + ">";
							install_list.AppendNode((object)null, (TreeListNode)null).SetValue((object)0, (object)text3);
						}
					}
					registryKey3.Close();
				}
				registryKey2.Close();
			}
			registryKey.Close();
		}
		catch
		{
			string systemDirectory = Environment.SystemDirectory;
			systemDirectory = systemDirectory.Substring(0, systemDirectory.LastIndexOf("\\"));
			systemDirectory += "\\SoftwareDistribution\\";
			string[] files = Directory.GetFiles(systemDirectory, "*KB*CA*", SearchOption.AllDirectories);
			string[] array = files;
			foreach (string text4 in array)
			{
				try
				{
					string text5 = text4.ToUpper();
					text5 = text5.Substring(text5.LastIndexOf("KB"));
					text5 = text5.Substring(0, 8);
					if (install_list.FindNodeByFieldValue("patch_list", (object)text5) == null)
					{
						install_list.AppendNode((object)null, (TreeListNode)null).SetValue((object)0, (object)text5);
					}
				}
				catch
				{
				}
			}
		}
	}

	private void start_Click(object sender, EventArgs e)
	{
		list_patch();
		tabControl1.set_SelectedTabPageIndex(0);
		cmp_patch("patch.dat");
	}

	private void cmp_patch(string patch_list)
	{
		un_installed_patch.get_Nodes().Clear();
		try
		{
			FileStream fileStream = File.OpenRead(patch_list);
			long length = fileStream.Length;
			byte[] array = new byte[length];
			fileStream.Read(array, 0, (int)length);
			fileStream.Dispose();
			fileStream.Close();
			OperatingSystem oSVersion = Environment.OSVersion;
			string versionString = oSVersion.VersionString;
			string @string = Encoding.Default.GetString(array);
			string[] array2 = @string.Split(new char[1] { '\n' });
			foreach (string text in array2)
			{
				string text2 = text.Substring(1, text.Length - 3);
				char[] separator = new char[1] { '|' };
				string[] array3 = text2.Split(separator);
				string text3 = array3[0];
				string text4 = array3[1];
				string text5 = array3[2];
				string text6 = array3[3];
				if (text6 == versionString && !kb_list.Contains(text3))
				{
					TreeListNode val = un_installed_patch.AppendNode((object)null, (TreeListNode)null);
					val.SetValue((object)0, (object)text3);
					val.SetValue((object)1, (object)text4);
					val.SetValue((object)2, (object)text5);
					val.SetValue((object)3, (object)"未安装");
					val.set_StateImageIndex(0);
				}
			}
		}
		catch
		{
		}
	}

	private void sel_all_Click(object sender, EventArgs e)
	{
		if (!is_check_all)
		{
			check_all();
			((Control)sel_all).set_Text("取消所有");
		}
		else
		{
			un_check_all();
			((Control)sel_all).set_Text("全选");
		}
		is_check_all = !is_check_all;
	}

	private void check_all()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		foreach (TreeListNode node in un_installed_patch.get_Nodes())
		{
			TreeListNode val = node;
			if ((int)GetCheckState(val.get_Tag()) != 1)
			{
				SetCheckedNode(val);
			}
		}
	}

	private void SetCheckedNode(TreeListNode node)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		CheckState checkState = GetCheckState(node.get_Tag());
		if ((int)checkState != 2 && (int)checkState != 0)
		{
			checkState = (CheckState)0;
			node.set_StateImageIndex(0);
		}
		else
		{
			checkState = (CheckState)1;
			node.set_StateImageIndex(1);
		}
		un_installed_patch.BeginUpdate();
		node.set_Tag((object)checkState);
		un_installed_patch.EndUpdate();
	}

	private CheckState GetCheckState(object obj)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (obj != null)
		{
			return (CheckState)obj;
		}
		return (CheckState)0;
	}

	private void un_check_all()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		foreach (TreeListNode node in un_installed_patch.get_Nodes())
		{
			TreeListNode val = node;
			if ((int)GetCheckState(val.get_Tag()) == 1)
			{
				SetCheckedNode(val);
			}
		}
	}

	private void d_install_Click(object sender, EventArgs e)
	{
		((Control)install_progressBar).set_Text("2");
		((Control)d_install).set_Enabled(false);
		update();
	}

	private void update()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		string text = "";
		foreach (TreeListNode node in un_installed_patch.get_Nodes())
		{
			TreeListNode val = node;
			if ((int)GetCheckState(val.get_Tag()) == 1)
			{
				string text2 = text;
				text = text2 + "<" + val.GetValue((object)0).ToString() + "|" + val.GetValue((object)1).ToString() + "|" + val.GetValue((object)2).ToString() + ">";
			}
		}
		ThreadPool.QueueUserWorkItem(download_and_install, text);
	}

	public void mod_stat(string stat)
	{
		try
		{
			string text = stat.Substring(0, stat.IndexOf("|"));
			TreeListNode val = un_installed_patch.FindNodeByFieldValue("补丁编号", (object)text);
			val.SetValue((object)3, (object)stat.Substring(stat.IndexOf("|") + 1));
		}
		catch (Exception)
		{
		}
	}

	public void enable_install()
	{
		((Control)d_install).set_Enabled(true);
	}

	public void install_progress(int count)
	{
		install_progressBar.set_Position(count);
	}

	public void download_and_install(object stateInfo)
	{
		try
		{
			string text = (string)stateInfo;
			text.IndexOf("<");
			text.IndexOf(">");
			char[] array = new char[2] { '>', '\0' };
			int num = text.Split(new char[1] { '>' }).Length - 1;
			int num2 = 0;
			string[] array2 = text.Split(new char[1] { '>' });
			foreach (string text2 in array2)
			{
				if (text2.Length == 0)
				{
					continue;
				}
				string text3 = text2;
				if (text3.StartsWith("<"))
				{
					text3 = text3.Substring(1);
				}
				if (text3.EndsWith(">"))
				{
					text3 = text3.Substring(0, text3.Length - 1);
				}
				char[] separator = new char[1] { '|' };
				string[] array3 = text3.Split(separator);
				string text4 = array3[0];
				string text5 = array3[2];
				string currentDirectory = Environment.CurrentDirectory;
				if (!Directory.Exists(currentDirectory + "\\windows_patch\\"))
				{
					Directory.CreateDirectory(currentDirectory + "\\windows_patch\\");
				}
				string text6 = currentDirectory + "\\windows_patch\\" + text4 + text5.Substring(text5.LastIndexOf("."));
				try
				{
					if (!File.Exists(text6))
					{
						WebClient webClient = new WebClient();
						webClient.DownloadFile(text5, text6);
						webClient.Dispose();
						((Control)this).BeginInvoke((Delegate)new my_mod_stat(mod_stat), new object[1] { text4 + "|下载完成" });
					}
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.Arguments = "/passive /norestart";
					processStartInfo.FileName = text6;
					Process process = Process.Start(processStartInfo);
					process.WaitForExit();
					int exitCode = process.ExitCode;
					if (exitCode != 0 && exitCode != 3010)
					{
						((Control)this).BeginInvoke((Delegate)new my_mod_stat(mod_stat), new object[1] { text4 + "|安装错误：" + exitCode });
					}
					else
					{
						((Control)this).BeginInvoke((Delegate)new my_mod_stat(mod_stat), new object[1] { text4 + "|安装完成" });
					}
				}
				catch (Exception ex)
				{
					((Control)this).BeginInvoke((Delegate)new my_mod_stat(mod_stat), new object[1] { text4 + "|失败:" + ex.Message });
					if (File.Exists(text6))
					{
						File.Delete(text6);
					}
				}
				num2++;
				((Control)this).BeginInvoke((Delegate)new my_install_progress(install_progress), new object[1] { num2 * 100 / num });
			}
		}
		catch
		{
		}
		((Control)this).BeginInvoke((Delegate)new my_enable_install(enable_install));
		if (Environment.CommandLine.IndexOf("update_all") != -1)
		{
			((Form)this).Close();
		}
	}

	private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			mouseDown = true;
			MouseCurrrnetPos = Control.get_MousePosition();
			formPos = ((Form)this).get_Location();
		}
	}

	private void Form1_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			MouseNewPos = Control.get_MousePosition();
			formNewPos.X = MouseNewPos.X - MouseCurrrnetPos.X + formPos.X;
			formNewPos.Y = MouseNewPos.Y - MouseCurrrnetPos.Y + formPos.Y;
			((Form)this).set_Location(formNewPos);
			formPos = formNewPos;
			MouseCurrrnetPos = MouseNewPos;
		}
	}

	private void Form1_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			mouseDown = false;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void un_installed_patch_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			TreeListHitInfo val = un_installed_patch.CalcHitInfo(new Point(e.get_X(), e.get_Y()));
			if ((int)val.get_HitInfoType() == 14)
			{
				SetCheckedNode(val.get_Node());
			}
		}
	}
}

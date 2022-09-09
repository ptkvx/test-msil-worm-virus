using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace Autodesk.AutoCAD.ADMigrator;

public class ExportDialog : Form
{
	private bool m_includeNetworkedFiles = true;

	private MainForm parent;

	private IContainer components;

	private Button btnExport;

	private Button btnCancel;

	private Button btnHelp;

	private CheckBox cbIncNetFiles;

	private Label ExportBodyLabel;

	private BindingSource exportDialogBindingSource;

	public bool IncludeNetworkedFiles => m_includeNetworkedFiles;

	public Label BodyMessage => ExportBodyLabel;

	public ExportDialog(MainForm mf)
	{
		parent = mf;
		InitializeComponent();
	}

	private void cbIncNetFiles_CheckedChanged(object sender, EventArgs e)
	{
		m_includeNetworkedFiles = cbIncNetFiles.get_Checked();
	}

	private void btnHelp_Click(object sender, EventArgs e)
	{
		string location = Assembly.GetEntryAssembly()!.Location;
		string text = (MainForm.isACAD ? "acad" : "acadlt") + "_sig.chm";
		string text2 = location.Substring(0, location.LastIndexOf("\\") + 1) + "help\\" + text;
		string text3 = "adExpCustSettings.htm";
		if (MainForm.m_isVertMigration)
		{
			object[] parameters = new object[3] { this, text2, text3 };
			parent.CallVerticalMigration("VerticalHelp", parameters);
		}
		else
		{
			Help.ShowHelp((Control)(object)this, text2, (HelpNavigator)(-2147483647), (object)text3);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ExportDialog));
		btnExport = new Button();
		btnCancel = new Button();
		btnHelp = new Button();
		cbIncNetFiles = new CheckBox();
		ExportBodyLabel = new Label();
		exportDialogBindingSource = new BindingSource(components);
		((ISupportInitialize)exportDialogBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(btnExport, "btnExport");
		btnExport.set_DialogResult((DialogResult)1);
		((Control)btnExport).set_Name("btnExport");
		((ButtonBase)btnExport).set_UseVisualStyleBackColor(true);
		componentResourceManager.ApplyResources(btnCancel, "btnCancel");
		btnCancel.set_DialogResult((DialogResult)2);
		((Control)btnCancel).set_Name("btnCancel");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		componentResourceManager.ApplyResources(btnHelp, "btnHelp");
		((Control)btnHelp).set_Name("btnHelp");
		((ButtonBase)btnHelp).set_UseVisualStyleBackColor(true);
		((Control)btnHelp).add_Click((EventHandler)btnHelp_Click);
		componentResourceManager.ApplyResources(cbIncNetFiles, "cbIncNetFiles");
		cbIncNetFiles.set_Checked(true);
		cbIncNetFiles.set_CheckState((CheckState)1);
		((Control)cbIncNetFiles).set_Name("cbIncNetFiles");
		((ButtonBase)cbIncNetFiles).set_UseVisualStyleBackColor(true);
		cbIncNetFiles.add_CheckedChanged((EventHandler)cbIncNetFiles_CheckedChanged);
		componentResourceManager.ApplyResources(ExportBodyLabel, "ExportBodyLabel");
		((Control)ExportBodyLabel).set_Name("ExportBodyLabel");
		ExportBodyLabel.set_UseCompatibleTextRendering(true);
		exportDialogBindingSource.set_DataSource((object)typeof(ExportDialog));
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)ExportBodyLabel);
		((Control)this).get_Controls().Add((Control)(object)cbIncNetFiles);
		((Control)this).get_Controls().Add((Control)(object)btnHelp);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnExport);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ExportDialog");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((ISupportInitialize)exportDialogBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}

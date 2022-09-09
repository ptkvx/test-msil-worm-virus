using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Autodesk.AutoCAD.ADMigrator;

public class ImportDialog : Form
{
	private IContainer components;

	private Button btnOK;

	private Label lblSuccess;

	private Label lblLog;

	private CheckBox chkBxViewLog;

	public string successMsg
	{
		get
		{
			return ((Control)lblSuccess).get_Text();
		}
		set
		{
			((Control)lblSuccess).set_Text(value);
		}
	}

	public string labelLogText
	{
		get
		{
			return ((Control)lblLog).get_Text();
		}
		set
		{
			((Control)lblLog).set_Text(value);
		}
	}

	public bool displayLog => chkBxViewLog.get_Checked();

	public ImportDialog()
	{
		InitializeComponent();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ImportDialog));
		btnOK = new Button();
		lblSuccess = new Label();
		lblLog = new Label();
		chkBxViewLog = new CheckBox();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(btnOK, "btnOK");
		btnOK.set_DialogResult((DialogResult)1);
		((Control)btnOK).set_MinimumSize(new Size(75, 23));
		((Control)btnOK).set_Name("btnOK");
		((ButtonBase)btnOK).set_UseVisualStyleBackColor(true);
		componentResourceManager.ApplyResources(lblSuccess, "lblSuccess");
		((Control)lblSuccess).set_Name("lblSuccess");
		componentResourceManager.ApplyResources(lblLog, "lblLog");
		((Control)lblLog).set_MaximumSize(new Size(600, 0));
		((Control)lblLog).set_Name("lblLog");
		componentResourceManager.ApplyResources(chkBxViewLog, "chkBxViewLog");
		chkBxViewLog.set_Checked(true);
		chkBxViewLog.set_CheckState((CheckState)1);
		((Control)chkBxViewLog).set_Name("chkBxViewLog");
		((ButtonBase)chkBxViewLog).set_UseVisualStyleBackColor(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnOK);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)chkBxViewLog);
		((Control)this).get_Controls().Add((Control)(object)lblLog);
		((Control)this).get_Controls().Add((Control)(object)lblSuccess);
		((Control)this).get_Controls().Add((Control)(object)btnOK);
		((Control)this).set_Name("ImportDialog");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}

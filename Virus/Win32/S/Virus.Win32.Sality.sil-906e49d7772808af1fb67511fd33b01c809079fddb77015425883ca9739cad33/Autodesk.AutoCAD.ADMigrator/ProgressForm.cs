using System.ComponentModel;
using System.Windows.Forms;

namespace Autodesk.AutoCAD.ADMigrator;

public class ProgressForm : Form
{
	private IContainer components;

	private Label m_label;

	public ProgressForm()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProgressForm));
		m_label = new Label();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(m_label, "m_label");
		((Control)m_label).set_Name("m_label");
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)m_label);
		((Control)this).set_Name("ProgressForm");
		((Form)this).set_ShowIcon(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}

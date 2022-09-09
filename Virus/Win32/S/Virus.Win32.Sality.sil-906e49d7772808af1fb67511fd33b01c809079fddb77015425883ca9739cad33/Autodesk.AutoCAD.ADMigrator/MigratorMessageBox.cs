using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Autodesk.AutoCAD.ADMigrator;

public class MigratorMessageBox : Form
{
	private Button YesButton;

	private Button NoButton;

	private Label MessageText;

	private Container components;

	private PictureBox pictureBox1;

	private Label WarningText;

	private DialogResult mResult = (DialogResult)2;

	public DialogResult DlgResult => mResult;

	public MigratorMessageBox()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		pictureBox1.set_Image((Image)(object)SystemIcons.get_Question().ToBitmap());
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
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MigratorMessageBox));
		YesButton = new Button();
		NoButton = new Button();
		MessageText = new Label();
		pictureBox1 = new PictureBox();
		WarningText = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(YesButton, "YesButton");
		YesButton.set_DialogResult((DialogResult)1);
		((Control)YesButton).set_Name("YesButton");
		componentResourceManager.ApplyResources(NoButton, "NoButton");
		NoButton.set_DialogResult((DialogResult)2);
		((Control)NoButton).set_Name("NoButton");
		componentResourceManager.ApplyResources(MessageText, "MessageText");
		((Control)MessageText).set_Name("MessageText");
		componentResourceManager.ApplyResources(pictureBox1, "pictureBox1");
		((Control)pictureBox1).set_Name("pictureBox1");
		pictureBox1.set_TabStop(false);
		componentResourceManager.ApplyResources(WarningText, "WarningText");
		((Control)WarningText).set_Name("WarningText");
		componentResourceManager.ApplyResources(this, "$this");
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)MessageText);
		((Control)this).get_Controls().Add((Control)(object)NoButton);
		((Control)this).get_Controls().Add((Control)(object)YesButton);
		((Control)this).get_Controls().Add((Control)(object)WarningText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MigratorMessageBox");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public static DialogResult Show(string msg, string msgCaregory, string title)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		MigratorMessageBox migratorMessageBox = new MigratorMessageBox();
		((Control)migratorMessageBox).set_Text(title);
		((Control)migratorMessageBox.WarningText).set_Text(msgCaregory);
		((Control)migratorMessageBox.MessageText).set_Text(msg);
		return ((Form)migratorMessageBox).ShowDialog();
	}
}

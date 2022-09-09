using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace HP.CUE.Gallery.StubApp;

public class ErrorDialog : Form
{
	private Button _okButton;

	private Label _errorMsgLabel;

	private Container components = null;

	public ErrorDialog()
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(ErrorDialog));
		_okButton = new Button();
		_errorMsgLabel = new Label();
		((Control)this).SuspendLayout();
		((Control)_okButton).set_AccessibleDescription(resourceManager.GetString("_okButton.AccessibleDescription"));
		((Control)_okButton).set_AccessibleName(resourceManager.GetString("_okButton.AccessibleName"));
		((Control)_okButton).set_Anchor((AnchorStyles)resourceManager.GetObject("_okButton.Anchor"));
		((Control)_okButton).set_BackgroundImage((Image)resourceManager.GetObject("_okButton.BackgroundImage"));
		_okButton.set_DialogResult((DialogResult)2);
		((Control)_okButton).set_Dock((DockStyle)resourceManager.GetObject("_okButton.Dock"));
		((Control)_okButton).set_Enabled((bool)resourceManager.GetObject("_okButton.Enabled"));
		((ButtonBase)_okButton).set_FlatStyle((FlatStyle)resourceManager.GetObject("_okButton.FlatStyle"));
		((Control)_okButton).set_Font((Font)resourceManager.GetObject("_okButton.Font"));
		((ButtonBase)_okButton).set_Image((Image)resourceManager.GetObject("_okButton.Image"));
		((ButtonBase)_okButton).set_ImageAlign((ContentAlignment)resourceManager.GetObject("_okButton.ImageAlign"));
		((ButtonBase)_okButton).set_ImageIndex((int)resourceManager.GetObject("_okButton.ImageIndex"));
		((ButtonBase)_okButton).set_ImeMode((ImeMode)resourceManager.GetObject("_okButton.ImeMode"));
		((Control)_okButton).set_Location((Point)resourceManager.GetObject("_okButton.Location"));
		((Control)_okButton).set_Name("_okButton");
		((Control)_okButton).set_RightToLeft((RightToLeft)resourceManager.GetObject("_okButton.RightToLeft"));
		((Control)_okButton).set_Size((Size)resourceManager.GetObject("_okButton.Size"));
		((Control)_okButton).set_TabIndex((int)resourceManager.GetObject("_okButton.TabIndex"));
		((Control)_okButton).set_Text(resourceManager.GetString("_okButton.Text"));
		((ButtonBase)_okButton).set_TextAlign((ContentAlignment)resourceManager.GetObject("_okButton.TextAlign"));
		((Control)_okButton).set_Visible((bool)resourceManager.GetObject("_okButton.Visible"));
		((Control)_okButton).add_Click((EventHandler)OnOKClick);
		((Control)_errorMsgLabel).set_AccessibleDescription(resourceManager.GetString("_errorMsgLabel.AccessibleDescription"));
		((Control)_errorMsgLabel).set_AccessibleName(resourceManager.GetString("_errorMsgLabel.AccessibleName"));
		((Control)_errorMsgLabel).set_Anchor((AnchorStyles)resourceManager.GetObject("_errorMsgLabel.Anchor"));
		_errorMsgLabel.set_AutoSize((bool)resourceManager.GetObject("_errorMsgLabel.AutoSize"));
		((Control)_errorMsgLabel).set_Dock((DockStyle)resourceManager.GetObject("_errorMsgLabel.Dock"));
		((Control)_errorMsgLabel).set_Enabled((bool)resourceManager.GetObject("_errorMsgLabel.Enabled"));
		((Control)_errorMsgLabel).set_Font((Font)resourceManager.GetObject("_errorMsgLabel.Font"));
		_errorMsgLabel.set_Image((Image)resourceManager.GetObject("_errorMsgLabel.Image"));
		_errorMsgLabel.set_ImageAlign((ContentAlignment)resourceManager.GetObject("_errorMsgLabel.ImageAlign"));
		_errorMsgLabel.set_ImageIndex((int)resourceManager.GetObject("_errorMsgLabel.ImageIndex"));
		_errorMsgLabel.set_ImeMode((ImeMode)resourceManager.GetObject("_errorMsgLabel.ImeMode"));
		((Control)_errorMsgLabel).set_Location((Point)resourceManager.GetObject("_errorMsgLabel.Location"));
		((Control)_errorMsgLabel).set_Name("_errorMsgLabel");
		((Control)_errorMsgLabel).set_RightToLeft((RightToLeft)resourceManager.GetObject("_errorMsgLabel.RightToLeft"));
		((Control)_errorMsgLabel).set_Size((Size)resourceManager.GetObject("_errorMsgLabel.Size"));
		((Control)_errorMsgLabel).set_TabIndex((int)resourceManager.GetObject("_errorMsgLabel.TabIndex"));
		((Control)_errorMsgLabel).set_Text(resourceManager.GetString("_errorMsgLabel.Text"));
		_errorMsgLabel.set_TextAlign((ContentAlignment)resourceManager.GetObject("_errorMsgLabel.TextAlign"));
		((Control)_errorMsgLabel).set_Visible((bool)resourceManager.GetObject("_errorMsgLabel.Visible"));
		((Form)this).set_AcceptButton((IButtonControl)(object)_okButton);
		((Control)this).set_AccessibleDescription(resourceManager.GetString("$this.AccessibleDescription"));
		((Control)this).set_AccessibleName(resourceManager.GetString("$this.AccessibleName"));
		((Form)this).set_AutoScaleBaseSize((Size)resourceManager.GetObject("$this.AutoScaleBaseSize"));
		((ScrollableControl)this).set_AutoScroll((bool)resourceManager.GetObject("$this.AutoScroll"));
		((ScrollableControl)this).set_AutoScrollMargin((Size)resourceManager.GetObject("$this.AutoScrollMargin"));
		((ScrollableControl)this).set_AutoScrollMinSize((Size)resourceManager.GetObject("$this.AutoScrollMinSize"));
		((Control)this).set_BackgroundImage((Image)resourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_CancelButton((IButtonControl)(object)_okButton);
		((Form)this).set_ClientSize((Size)resourceManager.GetObject("$this.ClientSize"));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)_errorMsgLabel);
		((Control)this).get_Controls().Add((Control)(object)_okButton);
		((Control)this).set_Enabled((bool)resourceManager.GetObject("$this.Enabled"));
		((Control)this).set_Font((Font)resourceManager.GetObject("$this.Font"));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Control)this).set_ImeMode((ImeMode)resourceManager.GetObject("$this.ImeMode"));
		((Control)this).set_Location((Point)resourceManager.GetObject("$this.Location"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize((Size)resourceManager.GetObject("$this.MaximumSize"));
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MinimumSize((Size)resourceManager.GetObject("$this.MinimumSize"));
		((Control)this).set_Name("ErrorDialog");
		((Control)this).set_RightToLeft((RightToLeft)resourceManager.GetObject("$this.RightToLeft"));
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)resourceManager.GetObject("$this.StartPosition"));
		((Control)this).set_Text(resourceManager.GetString("$this.Text"));
		((Control)this).ResumeLayout(false);
	}

	private void OnOKClick(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}

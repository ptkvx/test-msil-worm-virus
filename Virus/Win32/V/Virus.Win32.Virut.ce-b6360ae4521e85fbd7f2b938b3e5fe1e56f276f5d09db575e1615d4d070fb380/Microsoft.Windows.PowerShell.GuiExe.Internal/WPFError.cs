using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Microsoft.Windows.PowerShell.GuiExe.Internal;

internal class WPFError : Form
{
	private IContainer components;

	private Button ok;

	private RichTextBox message;

	private PictureBox errorIcon;

	internal WPFError()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		InitializeComponent();
		((Control)this).set_Text(Strings.GraphicalPowerShell);
		((Control)message).set_Text(string.Format(CultureInfo.CurrentCulture, Strings.WPFRequired, new object[1] { "http://go.microsoft.com/fwlink/?LinkID=105983" }));
		message.add_LinkClicked(new LinkClickedEventHandler(Message_LinkClicked));
		((Control)ok).set_Text(Strings.OK);
		errorIcon.set_Image((Image)(object)SystemIcons.get_Error().ToBitmap());
	}

	private void Message_LinkClicked(object sender, LinkClickedEventArgs e)
	{
		Process.Start(e.get_LinkText());
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		ok = new Button();
		message = new RichTextBox();
		errorIcon = new PictureBox();
		((ISupportInitialize)errorIcon).BeginInit();
		((Control)this).SuspendLayout();
		ok.set_DialogResult((DialogResult)1);
		((Control)ok).set_Location(new Point(370, 120));
		((Control)ok).set_Size(new Size(75, 23));
		((Control)ok).set_TabIndex(2);
		((ButtonBase)ok).set_UseVisualStyleBackColor(true);
		((Control)message).set_BackColor(SystemColors.Control);
		((Control)message).set_Location(new Point(49, 10));
		((TextBoxBase)message).set_ReadOnly(true);
		((Control)message).set_Size(new Size(396, 104));
		((Control)message).set_TabIndex(4);
		errorIcon.set_ImageLocation(string.Empty);
		((Control)errorIcon).set_Location(new Point(11, 30));
		((Control)errorIcon).set_Size(new Size(32, 32));
		errorIcon.set_TabIndex(5);
		errorIcon.set_TabStop(false);
		((Form)this).set_AcceptButton((IButtonControl)(object)ok);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(455, 150));
		((Control)this).get_Controls().Add((Control)(object)errorIcon);
		((Control)this).get_Controls().Add((Control)(object)message);
		((Control)this).get_Controls().Add((Control)(object)ok);
		((Form)this).set_ShowIcon(false);
		((ISupportInitialize)errorIcon).EndInit();
		((Control)this).ResumeLayout(false);
	}
}

using System.Drawing;
using System.Windows.Forms;

namespace ns0;

internal class Control4 : Control3
{
	private Color color_1;

	private Color color_2;

	private Pen pen_0;

	private Pen pen_1;

	public Control4()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		Int32_0 = 29;
		color_1 = Color.FromArgb(41, 41, 41);
		color_2 = Color.FromArgb(25, 25, 25);
		pen_0 = new Pen(Color.FromArgb(58, 58, 58));
		pen_1 = new Pen(color_2);
		((Control)this).set_BackColor(color_1);
		((Control)this).set_ForeColor(Color.FromArgb(100, 100, 100));
		Color_0 = Color.Fuchsia;
	}

	public override void vmethod_0()
	{
		base.graphics_0.Clear(color_1);
		method_8(color_2, color_1, 0, 0, ((Control)this).get_Width(), 28, 90f);
		base.graphics_0.DrawLine(pen_1, 0, 28, ((Control)this).get_Width(), 28);
		base.graphics_0.DrawLine(pen_0, 0, 29, ((Control)this).get_Width(), 29);
		method_4((HorizontalAlignment)0, ((Control)this).get_ForeColor(), checked(5 + Int32_1));
		method_6((HorizontalAlignment)0, 5);
		method_3(Pens.get_Black(), pen_0, ((Control)this).get_ClientRectangle());
		method_2(Color.Fuchsia, ((Control)this).get_ClientRectangle());
	}
}

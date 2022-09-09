using System.Drawing;
using System.Windows.Forms;

namespace ns0;

internal class Control2 : Control1
{
	private Pen pen_0;

	private Pen pen_1;

	private Color color_0;

	private Color color_1;

	public Control2()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		pen_0 = new Pen(Color.FromArgb(25, 25, 25));
		pen_1 = new Pen(Color.FromArgb(11, Color.White));
		color_0 = Color.FromArgb(41, 41, 41);
		color_1 = Color.FromArgb(51, 51, 51);
	}

	public override void vmethod_0()
	{
		if (base.enum0_0 == Enum0.const_2)
		{
			method_8(color_0, color_1, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), 90f);
		}
		else
		{
			method_8(color_1, color_0, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), 90f);
		}
		method_4((HorizontalAlignment)2, ((Control)this).get_ForeColor(), 0);
		method_6((HorizontalAlignment)0, 0);
		method_3(pen_0, pen_1, ((Control)this).get_ClientRectangle());
		method_2(((Control)this).get_BackColor(), ((Control)this).get_ClientRectangle());
	}
}

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class90 : Class89, Interface3
{
	private Office2007ColorTable office2007ColorTable_0;

	public Office2007ColorTable Office2007ColorTable_0
	{
		get
		{
			return office2007ColorTable_0;
		}
		set
		{
			office2007ColorTable_0 = value;
		}
	}

	public override void PaintCaptionBackground(FormCaptionRendererEventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.Graphics;
		Office2007FormStateColorTable office2007FormStateColorTable = office2007ColorTable_0.Form.Active;
		Form form = e.Form;
		bool flag = false;
		if (form != null && form is Office2007RibbonForm)
		{
			if (!((Office2007RibbonForm)(object)form).Boolean_0)
			{
				office2007FormStateColorTable = office2007ColorTable_0.Form.Inactive;
			}
		}
		else if (form != null && ((form != Form.get_ActiveForm() && form.get_MdiParent() == null) || (form.get_MdiParent() != null && form.get_MdiParent().get_ActiveMdiChild() != form)))
		{
			office2007FormStateColorTable = office2007ColorTable_0.Form.Inactive;
		}
		if (form is Office2007Form)
		{
			flag = true;
		}
		Rectangle bounds = e.Bounds;
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)0);
		Rectangle rectangle_ = new Rectangle(bounds.X, bounds.Y, bounds.Width, (int)((double)bounds.Height * 0.3));
		Class50.smethod_25(graphics, rectangle_, office2007FormStateColorTable.CaptionTopBackground);
		Rectangle rectangle_2 = new Rectangle(bounds.X, rectangle_.Bottom, bounds.Width, bounds.Height - rectangle_.Height);
		Class50.smethod_25(graphics, rectangle_2, office2007FormStateColorTable.CaptionBottomBackground);
		if (flag && office2007FormStateColorTable.CaptionBottomBorder != null && office2007FormStateColorTable.CaptionBottomBorder.Length > 0)
		{
			int num = office2007FormStateColorTable.CaptionBottomBorder.Length;
			for (int i = 0; i < num; i++)
			{
				Class50.smethod_32(graphics, bounds.X, bounds.Bottom - num + i, bounds.Right, bounds.Bottom - num + i, office2007FormStateColorTable.CaptionBottomBorder[i], 1);
			}
		}
		graphics.set_SmoothingMode(smoothingMode);
	}
}

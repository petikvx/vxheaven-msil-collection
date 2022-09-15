using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.Editors;

public class VisualCheckBox : VisualToggleButton
{
	private Size size_1 = new Size(13, 13);

	public override void PerformLayout(PaintInfo pi)
	{
		base.Size = new Size(size_1.Width + 2, size_1.Height);
		base.PerformLayout(pi);
	}

	protected override void OnPaint(PaintInfo p)
	{
		Graphics graphics = p.Graphics;
		Rectangle rectangle = new Rectangle(base.RenderBounds.X + 1, base.RenderBounds.Y + (base.RenderBounds.Height - size_1.Height) / 2, size_1.Width, size_1.Height);
		Class229 @class = Class274.smethod_16(null);
		Office2007CheckBoxColorTable office2007CheckBoxColorTable = method_1();
		Office2007CheckBoxStateColorTable office2007CheckBoxStateColorTable_ = office2007CheckBoxColorTable.Default;
		if (!GetIsEnabled(p))
		{
			office2007CheckBoxStateColorTable_ = office2007CheckBoxColorTable.Disabled;
		}
		else if (base.IsMouseDown)
		{
			office2007CheckBoxStateColorTable_ = office2007CheckBoxColorTable.Pressed;
		}
		else if (base.IsMouseOver)
		{
			office2007CheckBoxStateColorTable_ = office2007CheckBoxColorTable.MouseOver;
		}
		@class.method_1(graphics, rectangle, office2007CheckBoxStateColorTable_, (CheckState)(Checked ? 1 : 0));
		base.OnPaint(p);
	}

	private Office2007CheckBoxColorTable method_1()
	{
		if (method_2() is Office2007Renderer office2007Renderer)
		{
			return office2007Renderer.ColorTable.CheckBoxItem;
		}
		return null;
	}

	private BaseRenderer method_2()
	{
		return GlobalManager.Renderer;
	}
}

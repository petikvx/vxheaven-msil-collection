using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class260 : Class258
{
	protected override void ArrangeInternal(Rectangle bounds, Class263 d)
	{
		base.ArrangeInternal(bounds, d);
		base.Bounds = new Rectangle(base.Bounds.X, base.Bounds.Y, base.Bounds.Width, base.Bounds.Height + d.font_0.get_Height());
	}
}

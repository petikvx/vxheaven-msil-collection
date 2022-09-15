using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class246 : Class245
{
	protected Font font_0;

	public override void Measure(Size availableSize, Class263 d)
	{
		base.Bounds = Rectangle.Empty;
		SetFont(d);
	}

	public override void Render(Class263 d)
	{
		SetFont(d);
	}

	protected virtual void SetFont(Class263 d)
	{
	}

	public override void RenderEnd(Class263 d)
	{
		if (font_0 != null)
		{
			d.font_0 = font_0;
		}
		font_0 = null;
		base.RenderEnd(d);
	}

	public override void MeasureEnd(Size availableSize, Class263 d)
	{
		if (font_0 != null)
		{
			d.font_0 = font_0;
		}
		font_0 = null;
		base.MeasureEnd(availableSize, d);
	}

	protected override void ArrangeCore(Rectangle finalRect, Class263 d)
	{
	}
}

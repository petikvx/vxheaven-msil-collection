using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class250 : Class246
{
	protected override void SetFont(Class263 d)
	{
		d.bool_2 = true;
		base.SetFont(d);
	}

	public override void MeasureEnd(Size availableSize, Class263 d)
	{
		d.bool_2 = false;
		base.MeasureEnd(availableSize, d);
	}

	public override void RenderEnd(Class263 d)
	{
		d.bool_2 = false;
		base.RenderEnd(d);
	}
}

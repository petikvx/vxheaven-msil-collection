using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class255 : Class245
{
	private Class245 class245_1;

	public Class245 Class245_0 => class245_1;

	public Class255(Class245 startElement)
	{
		class245_1 = startElement;
	}

	public override void Measure(Size availableSize, Class263 d)
	{
		class245_1.MeasureEnd(availableSize, d);
		base.Bounds = Rectangle.Empty;
	}

	public override void Render(Class263 d)
	{
		class245_1.RenderEnd(d);
	}

	protected override void ArrangeCore(Rectangle finalRect, Class263 d)
	{
		base.Bounds = Rectangle.Empty;
	}
}

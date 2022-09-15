using System.Drawing;

namespace DevComponents.DotNetBar;

public class ElementStyleDisplayInfo
{
	public ElementStyle Style;

	public Graphics Graphics;

	public Rectangle Bounds = Rectangle.Empty;

	public bool RightToLeft;

	public ElementStyleDisplayInfo()
	{
	}

	public ElementStyleDisplayInfo(ElementStyle style, Graphics g, Rectangle bounds)
	{
		Style = style;
		Graphics = g;
		Bounds = bounds;
	}
}

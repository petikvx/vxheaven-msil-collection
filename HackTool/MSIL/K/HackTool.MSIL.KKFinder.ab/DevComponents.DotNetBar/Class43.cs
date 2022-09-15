using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class43
{
	public ElementStyle elementStyle_0;

	public Graphics graphics_0;

	public ISimpleElement isimpleElement_0;

	public Font font_0;

	public Rectangle rectangle_0 = Rectangle.Empty;

	public bool bool_0;

	public Class43(ElementStyle style, Graphics g, ISimpleElement elem, Font font, bool rightToLeft)
	{
		elementStyle_0 = style;
		graphics_0 = g;
		isimpleElement_0 = elem;
		font_0 = font;
		bool_0 = rightToLeft;
	}
}

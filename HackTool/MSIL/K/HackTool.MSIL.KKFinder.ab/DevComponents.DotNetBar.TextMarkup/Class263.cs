using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class263
{
	public Graphics graphics_0;

	public Font font_0;

	public Color color_0 = SystemColors.ControlText;

	public bool bool_0;

	public Point point_0 = Point.Empty;

	public bool bool_1;

	public HyperlinkStyle hyperlinkStyle_0;

	public bool bool_2;

	public Rectangle rectangle_0 = Rectangle.Empty;

	public bool bool_3;

	public object object_0;

	public bool bool_4 = true;

	public bool bool_5;

	public Class263(Graphics g, Font currentFont, Color currentForeColor, bool rightToLeft)
		: this(g, currentFont, currentForeColor, rightToLeft, Rectangle.Empty, hotKeyPrefixVisible: false)
	{
	}

	public Class263(Graphics g, Font currentFont, Color currentForeColor, bool rightToLeft, Rectangle clipRectangle, bool hotKeyPrefixVisible)
	{
		graphics_0 = g;
		font_0 = currentFont;
		color_0 = currentForeColor;
		bool_0 = rightToLeft;
		rectangle_0 = clipRectangle;
		bool_3 = hotKeyPrefixVisible;
	}

	public Class263(Graphics g, Font currentFont, Color currentForeColor, bool rightToLeft, Rectangle clipRectangle, bool hotKeyPrefixVisible, object contextObject)
	{
		graphics_0 = g;
		font_0 = currentFont;
		color_0 = currentForeColor;
		bool_0 = rightToLeft;
		rectangle_0 = clipRectangle;
		bool_3 = hotKeyPrefixVisible;
		object_0 = contextObject;
	}
}

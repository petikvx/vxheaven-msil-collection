using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class KeyTipsRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public Rectangle Bounds = Rectangle.Empty;

	public string KeyTip = "";

	public Font Font;

	public object ReferenceObject;

	public KeyTipsRendererEventArgs(Graphics g, Rectangle bounds, string keyTip, Font font, object referenceObject)
	{
		Graphics = g;
		Bounds = bounds;
		KeyTip = keyTip;
		Font = font;
		ReferenceObject = referenceObject;
	}
}

using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class AutoHideDisplayEventArgs : EventArgs
{
	public Rectangle DisplayRectangle = Rectangle.Empty;

	public AutoHideDisplayEventArgs(Rectangle displayRectangle)
	{
		DisplayRectangle = displayRectangle;
	}
}

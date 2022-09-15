using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class ColorPreviewEventArgs : EventArgs
{
	public Color Color = Color.Empty;

	public ColorItem ColorItem;

	public ColorPreviewEventArgs(Color c, ColorItem ci)
	{
		Color = c;
		ColorItem = ci;
	}
}

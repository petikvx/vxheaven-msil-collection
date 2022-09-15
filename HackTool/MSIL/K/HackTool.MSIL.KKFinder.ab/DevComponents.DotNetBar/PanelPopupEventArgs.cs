using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class PanelPopupEventArgs : EventArgs
{
	public bool Cancel;

	public Rectangle PopupBounds = Rectangle.Empty;

	public PanelPopupEventArgs(Rectangle popupBounds)
	{
		PopupBounds = popupBounds;
	}
}

using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class RenderTabItemEventArgs : EventArgs
{
	public readonly TabItem TabItem;

	public bool Cancel;

	public readonly Graphics Graphics;

	public RenderTabItemEventArgs(TabItem tab, Graphics g)
	{
		TabItem = tab;
		Graphics = g;
	}
}

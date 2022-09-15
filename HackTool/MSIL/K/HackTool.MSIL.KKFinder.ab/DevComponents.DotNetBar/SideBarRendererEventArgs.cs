using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class SideBarRendererEventArgs : EventArgs
{
	public readonly SideBar SideBar;

	public Graphics Graphics;

	internal ItemPaintArgs itemPaintArgs_0;

	public SideBarRendererEventArgs(SideBar sideBar, Graphics graphics)
	{
		SideBar = sideBar;
		Graphics = graphics;
	}
}

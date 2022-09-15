using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class MdiSystemItemRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public MDISystemItem MdiSystemItem;

	public MdiSystemItemRendererEventArgs(Graphics g, MDISystemItem mdi)
	{
		Graphics = g;
		MdiSystemItem = mdi;
	}
}

using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class QatOverflowItemRendererEventArgs : EventArgs
{
	public QatOverflowItem OverflowItem;

	public Graphics Graphics;

	public QatOverflowItemRendererEventArgs(QatOverflowItem overflowItem, Graphics g)
	{
		OverflowItem = overflowItem;
		Graphics = g;
	}
}

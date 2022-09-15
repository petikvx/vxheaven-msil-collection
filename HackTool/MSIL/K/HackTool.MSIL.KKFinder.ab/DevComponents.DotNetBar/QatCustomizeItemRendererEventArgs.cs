using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class QatCustomizeItemRendererEventArgs : EventArgs
{
	public QatCustomizeItem CustomizeItem;

	public Graphics Graphics;

	public QatCustomizeItemRendererEventArgs(QatCustomizeItem customizeItem, Graphics g)
	{
		CustomizeItem = customizeItem;
		Graphics = g;
	}
}

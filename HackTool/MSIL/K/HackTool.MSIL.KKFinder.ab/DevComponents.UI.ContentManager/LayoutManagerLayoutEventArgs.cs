using System;
using System.Drawing;

namespace DevComponents.UI.ContentManager;

public class LayoutManagerLayoutEventArgs : EventArgs
{
	public IBlock Block;

	public Point CurrentPosition = Point.Empty;

	public bool CancelLayout;

	public int BlockVisibleIndex;

	public LayoutManagerLayoutEventArgs(IBlock block, Point currentPosition, int visibleIndex)
	{
		Block = block;
		CurrentPosition = currentPosition;
		BlockVisibleIndex = visibleIndex;
	}
}

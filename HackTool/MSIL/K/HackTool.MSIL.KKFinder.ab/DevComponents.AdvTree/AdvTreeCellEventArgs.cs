using System;

namespace DevComponents.AdvTree;

public class AdvTreeCellEventArgs : EventArgs
{
	public eTreeAction Action = eTreeAction.Code;

	public Cell Cell;

	public AdvTreeCellEventArgs(eTreeAction action, Cell cell)
	{
		Action = action;
		Cell = cell;
	}
}

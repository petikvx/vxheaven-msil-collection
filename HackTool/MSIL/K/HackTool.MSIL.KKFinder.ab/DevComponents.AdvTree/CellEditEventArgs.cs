using System;

namespace DevComponents.AdvTree;

public class CellEditEventArgs : EventArgs
{
	public eTreeAction Action = eTreeAction.Code;

	public Cell Cell;

	public string NewText = "";

	public bool Cancel;

	public CellEditEventArgs(Cell cell, eTreeAction action, string newText)
	{
		Action = action;
		Cell = cell;
		NewText = newText;
	}
}

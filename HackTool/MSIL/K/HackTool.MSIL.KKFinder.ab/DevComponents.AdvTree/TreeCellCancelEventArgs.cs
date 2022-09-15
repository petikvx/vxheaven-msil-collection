namespace DevComponents.AdvTree;

public class TreeCellCancelEventArgs : AdvTreeCellEventArgs
{
	public bool Cancel;

	public TreeCellCancelEventArgs(eTreeAction action, Cell cell)
		: base(action, cell)
	{
	}
}

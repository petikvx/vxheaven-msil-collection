using System.Windows.Forms;

namespace DevComponents.AdvTree;

public class AdvTreeCellBeforeCheckEventArgs : TreeCellCancelEventArgs
{
	public CheckState NewCheckState = (CheckState)2;

	public AdvTreeCellBeforeCheckEventArgs(eTreeAction action, Cell cell, CheckState newCheckState)
		: base(action, cell)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		NewCheckState = newCheckState;
	}
}

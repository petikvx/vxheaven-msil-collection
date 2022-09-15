using System.ComponentModel;

namespace DevComponents.DotNetBar;

public class CrumbBarSelectionEventArgs : CancelEventArgs
{
	public CrumbBarItem NewSelectedItem;

	public CrumbBarSelectionEventArgs(CrumbBarItem newSelectedItem)
	{
		NewSelectedItem = newSelectedItem;
	}
}

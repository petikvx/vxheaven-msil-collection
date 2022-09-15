using System;

namespace DevComponents.DotNetBar;

public class PanelChangingEventArgs : EventArgs
{
	public bool Cancel;

	public readonly NavigationPanePanel NewPanel;

	public readonly NavigationPanePanel OldPanel;

	public PanelChangingEventArgs(NavigationPanePanel oldpanel, NavigationPanePanel newpanel)
	{
		NewPanel = newpanel;
		OldPanel = oldpanel;
	}
}

using System;
using System.Collections;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public interface IOwnerBarSupport
{
	ArrayList WereVisible { get; }

	DockSite LeftDockSite { get; set; }

	DockSite RightDockSite { get; set; }

	DockSite TopDockSite { get; set; }

	DockSite BottomDockSite { get; set; }

	DockSite FillDockSite { get; set; }

	DockSite ToolbarLeftDockSite { get; set; }

	DockSite ToolbarRightDockSite { get; set; }

	DockSite ToolbarTopDockSite { get; set; }

	DockSite ToolbarBottomDockSite { get; set; }

	bool ApplyDocumentBarStyle { get; set; }

	void InvokeDockTabChange(Bar bar, DockTabChangeEventArgs e);

	void InvokeBarDock(Bar bar, EventArgs e);

	void InvokeBarUndock(Bar bar, EventArgs e);

	void InvokeAutoHideChanged(Bar bar, EventArgs e);

	void InvokeBarClosing(Bar bar, BarClosingEventArgs e);

	void InvokeAutoHideDisplay(Bar bar, AutoHideDisplayEventArgs e);

	void InvokeBarTearOff(Bar bar, EventArgs e);

	void InvokeBeforeDockTabDisplay(BaseItem item, EventArgs e);

	DockSiteInfo GetDockInfo(IDockInfo pDock, int x, int y);

	void DockComplete();

	void BarContextMenu(Control bar, MouseEventArgs e);

	void AddShortcutsFromBar(Bar bar);

	void RemoveShortcutsFromBar(Bar bar);
}

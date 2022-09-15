using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public interface IDockInfo
{
	bool CanDockTop { get; }

	bool CanDockBottom { get; }

	bool CanDockLeft { get; }

	bool CanDockRight { get; }

	bool CanDockDocument { get; }

	bool CanDockTab { get; }

	bool Stretch { get; set; }

	int DockOffset { get; set; }

	int DockLine { get; set; }

	eOrientation DockOrientation { get; set; }

	bool Docked { get; }

	Control DockedSite { get; }

	eDockSide DockSide { get; set; }

	bool LockDockPosition { get; set; }

	Size MinimumDockSize(eOrientation dockOrientation);

	Size PreferredDockSize(eOrientation dockOrientation);

	void SetDockLine(int iLine);
}

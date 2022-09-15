using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public struct DockSiteInfo
{
	public DockStyle DockSide;

	public DockSite objDockSite;

	public int DockOffset;

	public int DockLine;

	public int DockedWidth;

	public int DockedHeight;

	public int InsertPosition;

	public bool NewLine;

	public Bar TabDockContainer;

	public bool UseOutline;

	public bool FullSizeDock;

	public bool PartialSizeDock;

	public int DockSiteZOrderIndex;

	public Bar MouseOverBar;

	public eDockSide MouseOverDockSide;

	public bool IsEmpty()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if ((int)DockSide == 0 && objDockSite == null && DockOffset == 0 && DockLine == 0 && DockedWidth == 0 && DockedHeight == 0 && InsertPosition == 0 && !NewLine)
		{
			return true;
		}
		return false;
	}
}

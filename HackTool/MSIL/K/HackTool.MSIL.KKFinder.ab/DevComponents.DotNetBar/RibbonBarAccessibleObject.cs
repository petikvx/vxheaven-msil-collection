using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class RibbonBarAccessibleObject : ItemControlAccessibleObject
{
	public RibbonBarAccessibleObject(ItemControl owner)
		: base(owner)
	{
	}

	public override int GetChildCount()
	{
		int num = base.GetChildCount();
		if (base.Owner is RibbonBar && ((RibbonBar)base.Owner).DialogLauncherVisible)
		{
			num++;
		}
		return num;
	}

	public override AccessibleObject GetChild(int iIndex)
	{
		if (base.Owner is RibbonBar ribbonBar && ribbonBar.DialogLauncherVisible && iIndex == ((AccessibleObject)this).GetChildCount() - 1)
		{
			return (AccessibleObject)(object)new DialogLauncherAccessibleObject(ribbonBar);
		}
		return base.GetChild(iIndex);
	}
}

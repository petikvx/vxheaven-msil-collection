using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class SideBarPanelItemDesigner : BaseItemDesigner
{
	protected override void BeforeNewItemAdded(BaseItem item)
	{
		base.BeforeNewItemAdded(item);
		if (item is ButtonItem)
		{
			ButtonItem buttonItem = item as ButtonItem;
			SideBarPanelItem sideBarPanelItem = ((ComponentDesigner)this).get_Component() as SideBarPanelItem;
			if (sideBarPanelItem.ESideBarAppearance_0 == eSideBarAppearance.Flat)
			{
				buttonItem.ImagePosition = eImagePosition.Right;
				buttonItem.ButtonStyle = eButtonStyle.ImageAndText;
			}
			else
			{
				buttonItem.ImagePosition = eImagePosition.Top;
			}
		}
	}
}

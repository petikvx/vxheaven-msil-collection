using System.Collections;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class ContextMenuBarDesigner : BarDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] array = null;
			array = new DesignerVerb[1]
			{
				new DesignerVerb("Add Context Menu", CreateButton)
			};
			return new DesignerVerbCollection(array);
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		base.PreFilterProperties(properties);
		string[] array = new string[47]
		{
			"AccessibleDescription", "AccessibleName", "AccessibleRole", "AlwaysDisplayDockTab", "AlwaysDisplayKeyAccelerators", "AutoCreateCaptionMenu", "AutoHide", "AutoHideAnimationTime", "AutoSyncBarCaption", "BackColor",
			"BackgroundImage", "BackgroundImageAlpha", "BackgroundImageLayout", "BarType", "CanDockBottom", "CanDockTop", "CanDockLeft", "CanDockRight", "CanDockTab", "CanHide",
			"CanReorderTabs", "CanUndock", "DisplayMoreItemsOnMenu", "DockedBorderStyle", "DockOrientation", "DockTabAlignment", "Enabled", "EqualButtonSize", "FadeEffect", "GrabHandleStyle",
			"ImageSize", "ImagesLarge", "ImagesMedium", "ItemSpacing", "LayoutType", "MenuBar", "PaddingBottom", "PaddingTop", "PaddingLeft", "PaddingRight",
			"RoundCorners", "SaveLayoutChanges", "SingleLineColor", "SelectedDockTab", "TabNavigation", "ThemeAware", "WrapItemsDock"
		};
		string[] array2 = array;
		foreach (string key in array2)
		{
			properties.Remove(key);
		}
	}

	protected override void OnitemCreated(BaseItem item)
	{
		if (item is ButtonItem)
		{
			((ButtonItem)item).AutoExpandOnClick = true;
		}
		base.OnitemCreated(item);
	}
}

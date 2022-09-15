using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

internal class Class108
{
	public static ItemContainer smethod_0(IDesignerServices idesignerServices_0, BaseItem baseItem_0, eOrientation eOrientation_0)
	{
		IDesignerHost designerHost = idesignerServices_0.GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService componentChangeService = idesignerServices_0.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		if (designerHost != null && baseItem_0 != null && componentChangeService != null)
		{
			ItemContainer itemContainer = null;
			DesignerTransaction designerTransaction = designerHost.CreateTransaction("New DotNetBar Item Container");
			try
			{
				itemContainer = designerHost.CreateComponent(typeof(ItemContainer)) as ItemContainer;
				TypeDescriptor.GetProperties(itemContainer)["LayoutOrientation"]!.SetValue(itemContainer, eOrientation_0);
				componentChangeService.OnComponentChanging(baseItem_0, TypeDescriptor.GetProperties(itemContainer)["SubItems"]);
				baseItem_0.SubItems.Add(itemContainer);
				componentChangeService.OnComponentChanged(baseItem_0, TypeDescriptor.GetProperties(itemContainer)["SubItems"], null, null);
				return itemContainer;
			}
			finally
			{
				if (!designerTransaction.Canceled)
				{
					designerTransaction.Commit();
				}
			}
		}
		return null;
	}

	public static RibbonTabItemGroup smethod_1(RibbonStrip ribbonStrip_0, IServiceProvider iserviceProvider_0)
	{
		IDesignerHost designerHost = iserviceProvider_0.GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService componentChangeService = iserviceProvider_0.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		if (designerHost != null && componentChangeService != null)
		{
			DesignerTransaction designerTransaction = designerHost.CreateTransaction("New RibbonTabItemGroup");
			RibbonTabItemGroup ribbonTabItemGroup = null;
			try
			{
				ribbonTabItemGroup = designerHost.CreateComponent(typeof(RibbonTabItemGroup)) as RibbonTabItemGroup;
				componentChangeService.OnComponentChanging(ribbonStrip_0, TypeDescriptor.GetProperties(ribbonStrip_0)["TabGroups"]);
				ribbonStrip_0.TabGroups.Add(ribbonTabItemGroup);
				componentChangeService.OnComponentChanged(ribbonStrip_0, TypeDescriptor.GetProperties(ribbonStrip_0)["TabGroups"], null, null);
				smethod_3(ribbonTabItemGroup);
				return ribbonTabItemGroup;
			}
			catch
			{
				designerTransaction.Cancel();
				throw;
			}
			finally
			{
				if (!designerTransaction.Canceled)
				{
					designerTransaction.Commit();
				}
			}
		}
		return null;
	}

	public static GalleryGroup smethod_2(GalleryContainer galleryContainer_0, IServiceProvider iserviceProvider_0)
	{
		IDesignerHost designerHost = iserviceProvider_0.GetService(typeof(IDesignerHost)) as IDesignerHost;
		IComponentChangeService componentChangeService = iserviceProvider_0.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		if (designerHost != null && componentChangeService != null)
		{
			DesignerTransaction designerTransaction = designerHost.CreateTransaction("New GalleryGroup");
			GalleryGroup galleryGroup = null;
			try
			{
				galleryGroup = designerHost.CreateComponent(typeof(GalleryGroup)) as GalleryGroup;
				componentChangeService.OnComponentChanging(galleryContainer_0, TypeDescriptor.GetProperties(galleryContainer_0)["GalleryGroups"]);
				galleryContainer_0.GalleryGroups.Add(galleryGroup);
				componentChangeService.OnComponentChanged(galleryContainer_0, TypeDescriptor.GetProperties(galleryContainer_0)["GalleryGroups"], null, null);
				galleryGroup.Text = galleryGroup.Name;
				return galleryGroup;
			}
			catch
			{
				designerTransaction.Cancel();
				throw;
			}
			finally
			{
				if (!designerTransaction.Canceled)
				{
					designerTransaction.Commit();
				}
			}
		}
		return null;
	}

	public static void smethod_3(RibbonTabItemGroup ribbonTabItemGroup_0)
	{
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0)["GroupTitle"]!.SetValue(ribbonTabItemGroup_0, "New Group");
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["Border"]!.SetValue(ribbonTabItemGroup_0.Style, eStyleBorderType.Solid);
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["BorderColor"]!.SetValue(ribbonTabItemGroup_0.Style, ColorScheme.GetColor("9A3A3B"));
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["CornerType"]!.SetValue(ribbonTabItemGroup_0.Style, eCornerType.Square);
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["BackColor"]!.SetValue(ribbonTabItemGroup_0.Style, ColorScheme.GetColor("AE6D94"));
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["BackColor2"]!.SetValue(ribbonTabItemGroup_0.Style, ColorScheme.GetColor("90487B"));
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["BackColorGradientAngle"]!.SetValue(ribbonTabItemGroup_0.Style, 90);
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["BorderWidth"]!.SetValue(ribbonTabItemGroup_0.Style, 1);
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["TextColor"]!.SetValue(ribbonTabItemGroup_0.Style, Color.White);
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["TextShadowColor"]!.SetValue(ribbonTabItemGroup_0.Style, Color.Black);
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["TextShadowOffset"]!.SetValue(ribbonTabItemGroup_0.Style, new Point(1, 1));
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["TextAlignment"]!.SetValue(ribbonTabItemGroup_0.Style, eStyleTextAlignment.Center);
		TypeDescriptor.GetProperties(ribbonTabItemGroup_0.Style)["TextLineAlignment"]!.SetValue(ribbonTabItemGroup_0.Style, eStyleTextAlignment.Near);
	}
}

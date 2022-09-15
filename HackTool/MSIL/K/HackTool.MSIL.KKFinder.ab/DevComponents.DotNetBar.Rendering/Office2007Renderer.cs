using System;
using System.Runtime.CompilerServices;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007Renderer : BaseRenderer
{
	private EventHandler eventHandler_0;

	private Office2007ColorTable office2007ColorTable_0;

	public Office2007ColorTable ColorTable
	{
		get
		{
			return office2007ColorTable_0;
		}
		set
		{
			office2007ColorTable_0 = value;
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
	}

	public event EventHandler ColorTableChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public Office2007Renderer()
	{
		office2007ColorTable_0 = new Office2007ColorTable();
	}

	public override void DrawKeyTips(KeyTipsRendererEventArgs e)
	{
		Class53 @class = Class274.smethod_6();
		if (@class is Interface3)
		{
			((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
		}
		@class.PaintKeyTips(e);
		base.DrawKeyTips(e);
	}

	public override void DrawRibbonTabGroup(RibbonTabGroupRendererEventArgs e)
	{
		Class116 @class = Class274.smethod_8(e.RibbonTabItemGroup);
		if (@class is Interface3)
		{
			((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
		}
		@class.PaintTabGroup(e);
		base.DrawRibbonTabGroup(e);
	}

	public override void DrawItemContainer(ItemContainerRendererEventArgs e)
	{
		Class98 @class = Class274.smethod_4(e.ItemContainer);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintBackground(e);
		}
		base.DrawItemContainer(e);
	}

	public override void DrawItemContainerSeparator(ItemContainerSeparatorRendererEventArgs e)
	{
		base.DrawItemContainerSeparator(e);
		Class98 @class = Class274.smethod_4(e.ItemContainer);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintItemSeparator(e);
		}
	}

	public override void DrawButtonItem(ButtonItemRendererEventArgs e)
	{
		Class265 @class = Class274.smethod_0(e.ButtonItem);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintButton(e.ButtonItem, e.itemPaintArgs_0);
		}
		base.DrawButtonItem(e);
	}

	public override void DrawRibbonTabItem(RibbonTabItemRendererEventArgs e)
	{
		Class265 @class = Class274.smethod_3(e.RibbonTabItem);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintButton(e.RibbonTabItem, e.itemPaintArgs_0);
		}
		base.DrawRibbonTabItem(e);
	}

	public override void DrawPopupToolbarBackground(ToolbarRendererEventArgs e)
	{
		Class84 @class = Class274.smethod_5(e.Bar);
		if (@class is Interface3)
		{
			((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
		}
		@class.PaintPopupBackground(e);
		base.DrawPopupToolbarBackground(e);
	}

	public override void DrawToolbarBackground(ToolbarRendererEventArgs e)
	{
		Class84 @class = Class274.smethod_5(e.Bar);
		if (@class is Interface3)
		{
			((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
		}
		if (e.Bar.BarState == eBarState.Docked)
		{
			@class.PaintDockedBackground(e);
		}
		else if (e.Bar.BarState == eBarState.Floating)
		{
			@class.PaintFloatingBackground(e);
		}
		base.DrawToolbarBackground(e);
	}

	protected virtual void DrawFloatingToolbarBackground(ToolbarRendererEventArgs e)
	{
	}

	public override void DrawRibbonDialogLauncher(RibbonBarRendererEventArgs e)
	{
		Class86 @class = Class274.smethod_7(e.RibbonBar);
		if (@class is Interface3)
		{
			((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
		}
		@class.PaintDialogLauncher(e);
		base.DrawRibbonDialogLauncher(e);
	}

	public override void DrawColorItem(ColorItemRendererEventArgs e)
	{
		Class220 @class = Class274.smethod_9(e.ColorItem);
		if (@class is Interface3)
		{
			((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
		}
		@class.PaintColorItem(e);
		base.DrawColorItem(e);
	}

	public override void DrawRibbonControlBackground(RibbonControlRendererEventArgs e)
	{
		Class168 @class = Class274.smethod_10(e.RibbonControl);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintBackground(e);
			base.DrawRibbonControlBackground(e);
		}
	}

	public override void DrawRibbonFormCaptionText(RibbonControlRendererEventArgs e)
	{
		base.DrawRibbonFormCaptionText(e);
		Class168 @class = Class274.smethod_10(e.RibbonControl);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintCaptionText(e);
		}
	}

	public override void DrawQuickAccessToolbarBackground(RibbonControlRendererEventArgs e)
	{
		base.DrawQuickAccessToolbarBackground(e);
		Class168 @class = Class274.smethod_10(e.RibbonControl);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintQuickAccessToolbarBackground(e);
		}
	}

	public override void DrawSystemCaptionItem(SystemCaptionItemRendererEventArgs e)
	{
		Class114 @class = Class274.smethod_11(e.SystemCaptionItem);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.Paint(e);
			base.DrawSystemCaptionItem(e);
		}
	}

	public override void DrawMdiSystemItem(MdiSystemItemRendererEventArgs e)
	{
		Class95 @class = Class274.smethod_12(e.MdiSystemItem);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.Paint(e);
			base.DrawMdiSystemItem(e);
		}
	}

	public override void DrawFormCaptionBackground(FormCaptionRendererEventArgs e)
	{
		Class89 @class = Class274.smethod_13(e.Form);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintCaptionBackground(e);
			base.DrawFormCaptionBackground(e);
		}
	}

	public override void DrawQatOverflowItem(QatOverflowItemRendererEventArgs e)
	{
		Class230 @class = Class274.smethod_14(e.OverflowItem);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.Paint(e);
			base.DrawQatOverflowItem(e);
		}
	}

	public override void DrawQatCustomizeItem(QatCustomizeItemRendererEventArgs e)
	{
		Class236 @class = Class274.smethod_15(e.CustomizeItem);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.Paint(e);
			base.DrawQatCustomizeItem(e);
		}
	}

	public override void DrawCheckBoxItem(CheckBoxItemRenderEventArgs e)
	{
		Class228 @class = Class274.smethod_16(e.CheckBoxItem);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.Paint(e);
			base.DrawCheckBoxItem(e);
		}
	}

	public override void DrawProgressBarItem(ProgressBarItemRenderEventArgs e)
	{
		Class222 @class = Class274.smethod_18(e.ProgressBarItem);
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.Paint(e);
			base.DrawProgressBarItem(e);
		}
	}

	public override void DrawNavPaneButtonBackground(NavPaneRenderEventArgs e)
	{
		Class234 @class = Class274.smethod_19();
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintButtonBackground(e);
			base.DrawNavPaneButtonBackground(e);
		}
	}

	public override void DrawSliderItem(SliderItemRendererEventArgs e)
	{
		Class232 @class = Class274.smethod_20();
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.Paint(e);
			base.DrawSliderItem(e);
		}
	}

	public override void DrawSideBar(SideBarRendererEventArgs e)
	{
		Class226 @class = Class274.smethod_21();
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintSideBar(e);
			base.DrawSideBar(e);
		}
	}

	public override void DrawSideBarPanelItem(SideBarPanelItemRendererEventArgs e)
	{
		Class226 @class = Class274.smethod_21();
		if (@class != null)
		{
			if (@class is Interface3)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.PaintSideBarPanelItem(e);
			base.DrawSideBarPanelItem(e);
		}
	}

	public override void DrawCrumbBarItemView(ButtonItemRendererEventArgs e)
	{
		Class102 @class = Class274.smethod_1(e.ButtonItem);
		if (@class != null)
		{
			if (@class != null)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.method_0(e.ButtonItem, e.itemPaintArgs_0);
		}
		base.DrawCrumbBarItemView(e);
	}

	public override void DrawCrumbBarOverflowItem(ButtonItemRendererEventArgs e)
	{
		Class102 @class = Class274.smethod_1(e.ButtonItem);
		if (@class != null)
		{
			if (@class != null)
			{
				((Interface3)@class).Office2007ColorTable_0 = office2007ColorTable_0;
			}
			@class.method_3(e.ButtonItem, e.itemPaintArgs_0);
		}
		base.DrawCrumbBarOverflowItem(e);
	}
}

using System;
using System.Runtime.CompilerServices;

namespace DevComponents.DotNetBar.Rendering;

public abstract class BaseRenderer
{
	private KeyTipsRendererEventHandler keyTipsRendererEventHandler_0;

	private RibbonTabGroupRendererEventHandler ribbonTabGroupRendererEventHandler_0;

	private ItemContainerRendererEventHandler itemContainerRendererEventHandler_0;

	private ItemContainerSeparatorRendererEventHandler itemContainerSeparatorRendererEventHandler_0;

	private ButtonItemRendererEventHandler buttonItemRendererEventHandler_0;

	private RibbonTabItemRendererEventHandler ribbonTabItemRendererEventHandler_0;

	private ToolbarRendererEventHandler toolbarRendererEventHandler_0;

	private ToolbarRendererEventHandler toolbarRendererEventHandler_1;

	private RibbonBarRendererEventHandler ribbonBarRendererEventHandler_0;

	private RibbonControlRendererEventHandler ribbonControlRendererEventHandler_0;

	private RibbonControlRendererEventHandler ribbonControlRendererEventHandler_1;

	private RibbonControlRendererEventHandler ribbonControlRendererEventHandler_2;

	private ColorItemRendererEventHandler colorItemRendererEventHandler_0;

	private SystemCaptionItemRendererEventHandler systemCaptionItemRendererEventHandler_0;

	private MdiSystemItemRendererEventHandler mdiSystemItemRendererEventHandler_0;

	private FormCaptionRendererEventHandler formCaptionRendererEventHandler_0;

	private QatOverflowItemRendererEventHandler qatOverflowItemRendererEventHandler_0;

	private QatCustomizeItemRendererEventHandler qatCustomizeItemRendererEventHandler_0;

	private CheckBoxItemRendererEventHandler checkBoxItemRendererEventHandler_0;

	private ProgressBarItemRendererEventHandler progressBarItemRendererEventHandler_0;

	private NavPaneRendererEventHandler navPaneRendererEventHandler_0;

	private SliderItemRendererEventHandler sliderItemRendererEventHandler_0;

	private SideBarRendererEventHandler sideBarRendererEventHandler_0;

	private SideBarPanelItemRendererEventHandler sideBarPanelItemRendererEventHandler_0;

	private ButtonItemRendererEventHandler buttonItemRendererEventHandler_1;

	private ButtonItemRendererEventHandler buttonItemRendererEventHandler_2;

	public event KeyTipsRendererEventHandler RenderKeyTips
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			keyTipsRendererEventHandler_0 = (KeyTipsRendererEventHandler)Delegate.Combine(keyTipsRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			keyTipsRendererEventHandler_0 = (KeyTipsRendererEventHandler)Delegate.Remove(keyTipsRendererEventHandler_0, value);
		}
	}

	public event RibbonTabGroupRendererEventHandler RenderRibbonTabGroup
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ribbonTabGroupRendererEventHandler_0 = (RibbonTabGroupRendererEventHandler)Delegate.Combine(ribbonTabGroupRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ribbonTabGroupRendererEventHandler_0 = (RibbonTabGroupRendererEventHandler)Delegate.Remove(ribbonTabGroupRendererEventHandler_0, value);
		}
	}

	public event ItemContainerRendererEventHandler RenderItemContainer
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			itemContainerRendererEventHandler_0 = (ItemContainerRendererEventHandler)Delegate.Combine(itemContainerRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			itemContainerRendererEventHandler_0 = (ItemContainerRendererEventHandler)Delegate.Remove(itemContainerRendererEventHandler_0, value);
		}
	}

	public event ItemContainerSeparatorRendererEventHandler RenderItemContainerSeparator
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			itemContainerSeparatorRendererEventHandler_0 = (ItemContainerSeparatorRendererEventHandler)Delegate.Combine(itemContainerSeparatorRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			itemContainerSeparatorRendererEventHandler_0 = (ItemContainerSeparatorRendererEventHandler)Delegate.Remove(itemContainerSeparatorRendererEventHandler_0, value);
		}
	}

	public event ButtonItemRendererEventHandler RenderButtonItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			buttonItemRendererEventHandler_0 = (ButtonItemRendererEventHandler)Delegate.Combine(buttonItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			buttonItemRendererEventHandler_0 = (ButtonItemRendererEventHandler)Delegate.Remove(buttonItemRendererEventHandler_0, value);
		}
	}

	public event RibbonTabItemRendererEventHandler RenderRibbonTabItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ribbonTabItemRendererEventHandler_0 = (RibbonTabItemRendererEventHandler)Delegate.Combine(ribbonTabItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ribbonTabItemRendererEventHandler_0 = (RibbonTabItemRendererEventHandler)Delegate.Remove(ribbonTabItemRendererEventHandler_0, value);
		}
	}

	public event ToolbarRendererEventHandler RenderToolbarBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			toolbarRendererEventHandler_0 = (ToolbarRendererEventHandler)Delegate.Combine(toolbarRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			toolbarRendererEventHandler_0 = (ToolbarRendererEventHandler)Delegate.Remove(toolbarRendererEventHandler_0, value);
		}
	}

	public event ToolbarRendererEventHandler RenderPopupToolbarBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			toolbarRendererEventHandler_1 = (ToolbarRendererEventHandler)Delegate.Combine(toolbarRendererEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			toolbarRendererEventHandler_1 = (ToolbarRendererEventHandler)Delegate.Remove(toolbarRendererEventHandler_1, value);
		}
	}

	public event RibbonBarRendererEventHandler RenderRibbonDialogLauncher
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ribbonBarRendererEventHandler_0 = (RibbonBarRendererEventHandler)Delegate.Combine(ribbonBarRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ribbonBarRendererEventHandler_0 = (RibbonBarRendererEventHandler)Delegate.Remove(ribbonBarRendererEventHandler_0, value);
		}
	}

	public event RibbonControlRendererEventHandler RenderRibbonControlBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ribbonControlRendererEventHandler_0 = (RibbonControlRendererEventHandler)Delegate.Combine(ribbonControlRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ribbonControlRendererEventHandler_0 = (RibbonControlRendererEventHandler)Delegate.Remove(ribbonControlRendererEventHandler_0, value);
		}
	}

	public event RibbonControlRendererEventHandler RenderRibbonFormCaptionText
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ribbonControlRendererEventHandler_1 = (RibbonControlRendererEventHandler)Delegate.Combine(ribbonControlRendererEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ribbonControlRendererEventHandler_1 = (RibbonControlRendererEventHandler)Delegate.Remove(ribbonControlRendererEventHandler_1, value);
		}
	}

	public event RibbonControlRendererEventHandler RenderQuickAccessToolbarBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ribbonControlRendererEventHandler_2 = (RibbonControlRendererEventHandler)Delegate.Combine(ribbonControlRendererEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ribbonControlRendererEventHandler_2 = (RibbonControlRendererEventHandler)Delegate.Remove(ribbonControlRendererEventHandler_2, value);
		}
	}

	public event ColorItemRendererEventHandler RenderColorItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			colorItemRendererEventHandler_0 = (ColorItemRendererEventHandler)Delegate.Combine(colorItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			colorItemRendererEventHandler_0 = (ColorItemRendererEventHandler)Delegate.Remove(colorItemRendererEventHandler_0, value);
		}
	}

	public event SystemCaptionItemRendererEventHandler RenderSystemCaptionItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			systemCaptionItemRendererEventHandler_0 = (SystemCaptionItemRendererEventHandler)Delegate.Combine(systemCaptionItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			systemCaptionItemRendererEventHandler_0 = (SystemCaptionItemRendererEventHandler)Delegate.Remove(systemCaptionItemRendererEventHandler_0, value);
		}
	}

	public event MdiSystemItemRendererEventHandler RenderMdiSystemItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			mdiSystemItemRendererEventHandler_0 = (MdiSystemItemRendererEventHandler)Delegate.Combine(mdiSystemItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			mdiSystemItemRendererEventHandler_0 = (MdiSystemItemRendererEventHandler)Delegate.Remove(mdiSystemItemRendererEventHandler_0, value);
		}
	}

	public event FormCaptionRendererEventHandler RenderFormCaptionBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			formCaptionRendererEventHandler_0 = (FormCaptionRendererEventHandler)Delegate.Combine(formCaptionRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			formCaptionRendererEventHandler_0 = (FormCaptionRendererEventHandler)Delegate.Remove(formCaptionRendererEventHandler_0, value);
		}
	}

	public event QatOverflowItemRendererEventHandler RenderQatOverflowItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			qatOverflowItemRendererEventHandler_0 = (QatOverflowItemRendererEventHandler)Delegate.Combine(qatOverflowItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			qatOverflowItemRendererEventHandler_0 = (QatOverflowItemRendererEventHandler)Delegate.Remove(qatOverflowItemRendererEventHandler_0, value);
		}
	}

	public event QatCustomizeItemRendererEventHandler RenderQatCustomizeItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			qatCustomizeItemRendererEventHandler_0 = (QatCustomizeItemRendererEventHandler)Delegate.Combine(qatCustomizeItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			qatCustomizeItemRendererEventHandler_0 = (QatCustomizeItemRendererEventHandler)Delegate.Remove(qatCustomizeItemRendererEventHandler_0, value);
		}
	}

	public event CheckBoxItemRendererEventHandler RenderCheckBoxItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			checkBoxItemRendererEventHandler_0 = (CheckBoxItemRendererEventHandler)Delegate.Combine(checkBoxItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			checkBoxItemRendererEventHandler_0 = (CheckBoxItemRendererEventHandler)Delegate.Remove(checkBoxItemRendererEventHandler_0, value);
		}
	}

	public event ProgressBarItemRendererEventHandler RenderProgressBarItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			progressBarItemRendererEventHandler_0 = (ProgressBarItemRendererEventHandler)Delegate.Combine(progressBarItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			progressBarItemRendererEventHandler_0 = (ProgressBarItemRendererEventHandler)Delegate.Remove(progressBarItemRendererEventHandler_0, value);
		}
	}

	public event NavPaneRendererEventHandler RenderNavPaneButtonBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			navPaneRendererEventHandler_0 = (NavPaneRendererEventHandler)Delegate.Combine(navPaneRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			navPaneRendererEventHandler_0 = (NavPaneRendererEventHandler)Delegate.Remove(navPaneRendererEventHandler_0, value);
		}
	}

	public event SliderItemRendererEventHandler RenderSliderItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			sliderItemRendererEventHandler_0 = (SliderItemRendererEventHandler)Delegate.Combine(sliderItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			sliderItemRendererEventHandler_0 = (SliderItemRendererEventHandler)Delegate.Remove(sliderItemRendererEventHandler_0, value);
		}
	}

	public event SideBarRendererEventHandler RenderSideBar
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			sideBarRendererEventHandler_0 = (SideBarRendererEventHandler)Delegate.Combine(sideBarRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			sideBarRendererEventHandler_0 = (SideBarRendererEventHandler)Delegate.Remove(sideBarRendererEventHandler_0, value);
		}
	}

	public event SideBarPanelItemRendererEventHandler RenderSideBarPanelItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			sideBarPanelItemRendererEventHandler_0 = (SideBarPanelItemRendererEventHandler)Delegate.Combine(sideBarPanelItemRendererEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			sideBarPanelItemRendererEventHandler_0 = (SideBarPanelItemRendererEventHandler)Delegate.Remove(sideBarPanelItemRendererEventHandler_0, value);
		}
	}

	public event ButtonItemRendererEventHandler RenderCrumbBarItemView
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			buttonItemRendererEventHandler_1 = (ButtonItemRendererEventHandler)Delegate.Combine(buttonItemRendererEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			buttonItemRendererEventHandler_1 = (ButtonItemRendererEventHandler)Delegate.Remove(buttonItemRendererEventHandler_1, value);
		}
	}

	public event ButtonItemRendererEventHandler RenderCrumbBarOverflowItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			buttonItemRendererEventHandler_2 = (ButtonItemRendererEventHandler)Delegate.Combine(buttonItemRendererEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			buttonItemRendererEventHandler_2 = (ButtonItemRendererEventHandler)Delegate.Remove(buttonItemRendererEventHandler_2, value);
		}
	}

	protected virtual void OnRenderKeyTips(KeyTipsRendererEventArgs e)
	{
		if (keyTipsRendererEventHandler_0 != null)
		{
			keyTipsRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawKeyTips(KeyTipsRendererEventArgs e)
	{
		OnRenderKeyTips(e);
	}

	protected virtual void OnRenderRibbonTabGroup(RibbonTabGroupRendererEventArgs e)
	{
		if (ribbonTabGroupRendererEventHandler_0 != null)
		{
			ribbonTabGroupRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawRibbonTabGroup(RibbonTabGroupRendererEventArgs e)
	{
		OnRenderRibbonTabGroup(e);
	}

	protected virtual void OnRenderItemContainer(ItemContainerRendererEventArgs e)
	{
		if (itemContainerRendererEventHandler_0 != null)
		{
			itemContainerRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawItemContainerSeparator(ItemContainerSeparatorRendererEventArgs e)
	{
		OnRenderItemContainerSeparator(e);
	}

	protected virtual void OnRenderItemContainerSeparator(ItemContainerSeparatorRendererEventArgs e)
	{
		if (itemContainerSeparatorRendererEventHandler_0 != null)
		{
			itemContainerSeparatorRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawItemContainer(ItemContainerRendererEventArgs e)
	{
		OnRenderItemContainer(e);
	}

	protected virtual void OnRenderButtonItem(ButtonItemRendererEventArgs e)
	{
		if (buttonItemRendererEventHandler_0 != null)
		{
			buttonItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawButtonItem(ButtonItemRendererEventArgs e)
	{
		OnRenderButtonItem(e);
	}

	protected virtual void OnRenderRibbonTabItem(RibbonTabItemRendererEventArgs e)
	{
		if (ribbonTabItemRendererEventHandler_0 != null)
		{
			ribbonTabItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawRibbonTabItem(RibbonTabItemRendererEventArgs e)
	{
		OnRenderRibbonTabItem(e);
	}

	protected virtual void OnRenderToolbarBackground(ToolbarRendererEventArgs e)
	{
		if (toolbarRendererEventHandler_0 != null)
		{
			toolbarRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawToolbarBackground(ToolbarRendererEventArgs e)
	{
		OnRenderToolbarBackground(e);
	}

	protected virtual void OnRenderPopupToolbarBackground(ToolbarRendererEventArgs e)
	{
		if (toolbarRendererEventHandler_1 != null)
		{
			toolbarRendererEventHandler_1(this, e);
		}
	}

	public virtual void DrawPopupToolbarBackground(ToolbarRendererEventArgs e)
	{
		OnRenderPopupToolbarBackground(e);
	}

	protected virtual void OnRenderRibbonDialogLauncher(RibbonBarRendererEventArgs e)
	{
		if (ribbonBarRendererEventHandler_0 != null)
		{
			ribbonBarRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawRibbonDialogLauncher(RibbonBarRendererEventArgs e)
	{
		OnRenderRibbonDialogLauncher(e);
	}

	protected virtual void OnRenderColorItem(ColorItemRendererEventArgs e)
	{
		if (colorItemRendererEventHandler_0 != null)
		{
			colorItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawColorItem(ColorItemRendererEventArgs e)
	{
		OnRenderColorItem(e);
	}

	protected virtual void OnRenderRibbonControlBackground(RibbonControlRendererEventArgs e)
	{
		if (ribbonControlRendererEventHandler_0 != null)
		{
			ribbonControlRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawRibbonControlBackground(RibbonControlRendererEventArgs e)
	{
		OnRenderRibbonControlBackground(e);
	}

	protected virtual void OnRenderSystemCaptionItem(SystemCaptionItemRendererEventArgs e)
	{
		if (systemCaptionItemRendererEventHandler_0 != null)
		{
			systemCaptionItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawSystemCaptionItem(SystemCaptionItemRendererEventArgs e)
	{
		OnRenderSystemCaptionItem(e);
	}

	protected virtual void OnRenderRibbonFormCaptionText(RibbonControlRendererEventArgs e)
	{
		if (ribbonControlRendererEventHandler_1 != null)
		{
			ribbonControlRendererEventHandler_1(this, e);
		}
	}

	public virtual void DrawRibbonFormCaptionText(RibbonControlRendererEventArgs e)
	{
		OnRenderRibbonFormCaptionText(e);
	}

	protected virtual void OnRenderQuickAccessToolbarBackground(RibbonControlRendererEventArgs e)
	{
		if (ribbonControlRendererEventHandler_2 != null)
		{
			ribbonControlRendererEventHandler_2(this, e);
		}
	}

	public virtual void DrawQuickAccessToolbarBackground(RibbonControlRendererEventArgs e)
	{
		OnRenderQuickAccessToolbarBackground(e);
	}

	protected virtual void OnRenderMdiSystemItem(MdiSystemItemRendererEventArgs e)
	{
		if (mdiSystemItemRendererEventHandler_0 != null)
		{
			mdiSystemItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawMdiSystemItem(MdiSystemItemRendererEventArgs e)
	{
		OnRenderMdiSystemItem(e);
	}

	protected virtual void OnRenderFormCaptionBackground(FormCaptionRendererEventArgs e)
	{
		if (formCaptionRendererEventHandler_0 != null)
		{
			formCaptionRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawFormCaptionBackground(FormCaptionRendererEventArgs e)
	{
		OnRenderFormCaptionBackground(e);
	}

	protected virtual void OnRenderQatOverflowItem(QatOverflowItemRendererEventArgs e)
	{
		if (qatOverflowItemRendererEventHandler_0 != null)
		{
			qatOverflowItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawQatOverflowItem(QatOverflowItemRendererEventArgs e)
	{
		OnRenderQatOverflowItem(e);
	}

	protected virtual void OnRenderQatCustomizeItem(QatCustomizeItemRendererEventArgs e)
	{
		if (qatCustomizeItemRendererEventHandler_0 != null)
		{
			qatCustomizeItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawQatCustomizeItem(QatCustomizeItemRendererEventArgs e)
	{
		OnRenderQatCustomizeItem(e);
	}

	protected virtual void OnRenderCheckBoxItem(CheckBoxItemRenderEventArgs e)
	{
		if (checkBoxItemRendererEventHandler_0 != null)
		{
			checkBoxItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawCheckBoxItem(CheckBoxItemRenderEventArgs e)
	{
		OnRenderCheckBoxItem(e);
	}

	protected virtual void OnRenderProgressBarItem(ProgressBarItemRenderEventArgs e)
	{
		if (progressBarItemRendererEventHandler_0 != null)
		{
			progressBarItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawProgressBarItem(ProgressBarItemRenderEventArgs e)
	{
		OnRenderProgressBarItem(e);
	}

	protected virtual void OnRenderNavPaneButtonBackground(NavPaneRenderEventArgs e)
	{
		if (navPaneRendererEventHandler_0 != null)
		{
			navPaneRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawNavPaneButtonBackground(NavPaneRenderEventArgs e)
	{
		OnRenderNavPaneButtonBackground(e);
	}

	protected virtual void OnRenderSliderItem(SliderItemRendererEventArgs e)
	{
		if (sliderItemRendererEventHandler_0 != null)
		{
			sliderItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawSliderItem(SliderItemRendererEventArgs e)
	{
		OnRenderSliderItem(e);
	}

	protected virtual void OnRenderSideBar(SideBarRendererEventArgs e)
	{
		if (sideBarRendererEventHandler_0 != null)
		{
			sideBarRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawSideBar(SideBarRendererEventArgs e)
	{
		OnRenderSideBar(e);
	}

	protected virtual void OnRenderSideBarPanelItem(SideBarPanelItemRendererEventArgs e)
	{
		if (sideBarPanelItemRendererEventHandler_0 != null)
		{
			sideBarPanelItemRendererEventHandler_0(this, e);
		}
	}

	public virtual void DrawSideBarPanelItem(SideBarPanelItemRendererEventArgs e)
	{
		OnRenderSideBarPanelItem(e);
	}

	protected virtual void OnRenderCrumbBarItemView(ButtonItemRendererEventArgs e)
	{
		if (buttonItemRendererEventHandler_1 != null)
		{
			buttonItemRendererEventHandler_1(this, e);
		}
	}

	public virtual void DrawCrumbBarItemView(ButtonItemRendererEventArgs e)
	{
		OnRenderCrumbBarItemView(e);
	}

	protected virtual void OnRenderCrumbBarOverflowItem(ButtonItemRendererEventArgs e)
	{
		if (buttonItemRendererEventHandler_2 != null)
		{
			buttonItemRendererEventHandler_2(this, e);
		}
	}

	public virtual void DrawCrumbBarOverflowItem(ButtonItemRendererEventArgs e)
	{
		OnRenderCrumbBarOverflowItem(e);
	}
}

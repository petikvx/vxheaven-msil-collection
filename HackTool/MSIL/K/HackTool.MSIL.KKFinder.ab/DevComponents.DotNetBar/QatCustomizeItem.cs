using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.Ribbon;

namespace DevComponents.DotNetBar;

public class QatCustomizeItem : CustomizeItem
{
	private const string string_10 = "Customize Quick Access Toolbar";

	private const int int_6 = 14;

	[Browsable(false)]
	[DefaultValue(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
	[Description("Indicates whether Customize menu item is visible.")]
	public override bool CustomizeItemVisible
	{
		get
		{
			return base.CustomizeItemVisible;
		}
		set
		{
			base.CustomizeItemVisible = value;
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue("Customize Quick Access Toolbar")]
	[Description("Indicates the text that is displayed when mouse hovers over the item.")]
	[Category("Appearance")]
	[Localizable(true)]
	public override string Tooltip
	{
		get
		{
			return base.Tooltip;
		}
		set
		{
			base.Tooltip = value;
		}
	}

	public QatCustomizeItem()
	{
		Tooltip = "Customize Quick Access Toolbar";
	}

	public override BaseItem Copy()
	{
		QatCustomizeItem qatCustomizeItem = new QatCustomizeItem();
		CopyToItem(qatCustomizeItem);
		return qatCustomizeItem;
	}

	public override void Paint(ItemPaintArgs p)
	{
		BaseRenderer baseRenderer_ = p.BaseRenderer_0;
		if (baseRenderer_ != null)
		{
			baseRenderer_.DrawQatCustomizeItem(new QatCustomizeItemRendererEventArgs(this, p.Graphics));
			return;
		}
		Class236 @class = Class274.smethod_15(this);
		if (@class != null)
		{
			@class.Paint(new QatCustomizeItemRendererEventArgs(this, p.Graphics));
		}
		else
		{
			base.Paint(p);
		}
	}

	private bool method_28(RibbonControl ribbonControl_0, string string_11)
	{
		if (ribbonControl_0.QuickToolbarItems.Contains(string_11))
		{
			return true;
		}
		if (Parent is QatOverflowItem && Parent.SubItems.Contains(string_11))
		{
			return true;
		}
		return false;
	}

	protected override void SetupCustomizeItem()
	{
		SubItems.Clear();
		string itemText = "&Customize Quick Access Toolbar...";
		RibbonControl ribbonControl = method_33();
		if (ribbonControl != null)
		{
			itemText = ribbonControl.SystemText.QatCustomizeText;
		}
		string itemText2 = "<b>Customize Quick Access Toolbar</b>";
		if (ribbonControl != null)
		{
			itemText2 = ribbonControl.SystemText.QatCustomizeMenuLabel;
		}
		LabelItem labelItem = new LabelItem(RibbonControl.SysQatCustomizeLabelName, itemText2);
		labelItem.PaddingBottom = 2;
		labelItem.PaddingTop = 2;
		labelItem.PaddingLeft = 12;
		labelItem.BorderSide = eBorderSide.Bottom;
		labelItem.BorderType = eBorderType.SingleLine;
		labelItem.CanCustomize = false;
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			labelItem.BackColor = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.QuickAccessToolbar.QatCustomizeMenuLabelBackground;
			labelItem.ForeColor = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.QuickAccessToolbar.QatCustomizeMenuLabelText;
		}
		SubItems.Add(labelItem);
		bool beginGroup = false;
		if (ribbonControl.QatFrequentCommands.Count > 0)
		{
			beginGroup = true;
			foreach (BaseItem qatFrequentCommand in ribbonControl.QatFrequentCommands)
			{
				if (qatFrequentCommand.Text.Length > 0)
				{
					ButtonItem buttonItem = new ButtonItem(RibbonControl.SysFrequentlyQatNamePart + qatFrequentCommand.Name, qatFrequentCommand.Text);
					if (method_28(ribbonControl, qatFrequentCommand.Name))
					{
						buttonItem.Checked = true;
					}
					buttonItem.CanCustomize = false;
					SubItems.Add(buttonItem);
					buttonItem.Click += method_29;
					buttonItem.Tag = qatFrequentCommand.Name;
				}
			}
		}
		ButtonItem buttonItem2 = new ButtonItem(RibbonControl.SysQatCustomizeItemName, itemText);
		buttonItem2.BeginGroup = beginGroup;
		buttonItem2.CanCustomize = false;
		SubItems.Add(buttonItem2);
		buttonItem2.Click += method_32;
		if (ribbonControl != null && ribbonControl.EnableQatPlacement)
		{
			ButtonItem buttonItem3 = new ButtonItem(RibbonControl.SysQatPlaceItemName);
			buttonItem3.CanCustomize = false;
			if (ribbonControl.QatPositionedBelowRibbon)
			{
				buttonItem3.Text = ribbonControl.SystemText.QatPlaceAboveRibbonText;
			}
			else
			{
				buttonItem3.Text = ribbonControl.SystemText.QatPlaceBelowRibbonText;
			}
			buttonItem3.Click += method_31;
			SubItems.Add(buttonItem3);
		}
		if (ribbonControl != null)
		{
			ButtonItem buttonItem4 = null;
			buttonItem4 = ((!ribbonControl.Expanded) ? new ButtonItem(RibbonControl.SysMaximizeRibbon, ribbonControl.SystemText.MaximizeRibbonText) : new ButtonItem(RibbonControl.SysMinimizeRibbon, ribbonControl.SystemText.MinimizeRibbonText));
			buttonItem4.CanCustomize = false;
			buttonItem4.BeginGroup = true;
			buttonItem4.Click += method_30;
			SubItems.Add(buttonItem4);
		}
	}

	private void method_29(object sender, EventArgs e)
	{
		RibbonControl ribbonControl = method_33();
		if (ribbonControl == null)
		{
			return;
		}
		BaseItem.CollapseAll(this);
		ribbonControl.RibbonStrip.ClosePopups();
		if (sender is ButtonItem buttonItem && buttonItem.Tag is string && buttonItem.Tag.ToString()!.Length > 0)
		{
			if (buttonItem.Checked)
			{
				ribbonControl.RemoveItemFromQuickAccessToolbar(ribbonControl.QuickToolbarItems[buttonItem.Tag.ToString()]);
			}
			else
			{
				ribbonControl.AddItemToQuickAccessToolbar(ribbonControl.QatFrequentCommands[buttonItem.Tag.ToString()]);
			}
		}
	}

	private void method_30(object sender, EventArgs e)
	{
		BaseItem.CollapseAll(this);
		if (!(sender is ButtonItem buttonItem))
		{
			return;
		}
		RibbonControl ribbonControl = method_33();
		if (ribbonControl != null)
		{
			ribbonControl.RibbonStrip.ClosePopups();
			if (buttonItem.Name == RibbonControl.SysMinimizeRibbon)
			{
				ribbonControl.Expanded = false;
			}
			else if (buttonItem.Name == RibbonControl.SysMaximizeRibbon)
			{
				ribbonControl.Expanded = true;
			}
		}
	}

	private void method_31(object sender, EventArgs e)
	{
		BaseItem.CollapseAll(this);
		RibbonControl ribbonControl = method_33();
		if (ribbonControl != null)
		{
			ribbonControl.RibbonStrip.ClosePopups();
			ribbonControl.method_36();
		}
	}

	private void method_32(object sender, EventArgs e)
	{
		RibbonControl ribbonControl = method_33();
		BaseItem.CollapseAll(this);
		if (ribbonControl != null)
		{
			ribbonControl.RibbonStrip.ClosePopups();
			ribbonControl.ShowQatCustomizeDialog();
		}
	}

	private RibbonControl method_33()
	{
		RibbonStrip ribbonStrip = ContainerControl as RibbonStrip;
		if (ribbonStrip == null)
		{
			BaseItem baseItem = this;
			while (baseItem != null && ribbonStrip == null)
			{
				baseItem = baseItem.Parent;
				if (baseItem == null)
				{
					continue;
				}
				if (baseItem.ContainerControl is Control7)
				{
					Control7 control = baseItem.ContainerControl as Control7;
					if (((Control)control).get_Parent() is RibbonControl)
					{
						ribbonStrip = ((RibbonControl)(object)((Control)control).get_Parent()).RibbonStrip;
						break;
					}
				}
				else
				{
					ribbonStrip = baseItem.ContainerControl as RibbonStrip;
				}
			}
		}
		RibbonControl result = null;
		if (ribbonStrip != null)
		{
			result = ((Control)ribbonStrip).get_Parent() as RibbonControl;
		}
		if (ContainerControl is Control7 control2 && ((Control)control2).get_Parent() is RibbonControl)
		{
			return ((Control)control2).get_Parent() as RibbonControl;
		}
		return result;
	}

	protected override void ClearCustomizeItem()
	{
	}

	protected override void LoadResources()
	{
	}

	protected override void SetCustomTooltip(string text)
	{
	}

	protected internal override void OnExpandChange()
	{
		PopupSide = ePopupSide.Bottom;
		base.OnExpandChange();
	}

	public override void RecalcSize()
	{
		if (!SuspendLayout)
		{
			if (m_Orientation == eOrientation.Vertical)
			{
				m_Rect.Height = 14;
				m_Rect.Width = 22;
			}
			else
			{
				m_Rect.Width = 14;
				m_Rect.Height = 22;
			}
			SetCustomTooltip(GetTooltipText());
		}
	}

	protected override string GetTooltipText()
	{
		if (Tooltip == "Customize Quick Access Toolbar")
		{
			string text = "";
			using (Class264 @class = new Class264(GetOwner() as IOwnerLocalize))
			{
				text = @class.method_1(LocalizationKeys.QatCustomizeTooltip);
			}
			if (text == "")
			{
				text = "Customize Quick Access Toolbar";
			}
			return text;
		}
		return base.GetTooltipText();
	}

	protected override void MouseHoverCustomize()
	{
	}
}

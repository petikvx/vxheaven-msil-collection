using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
public class NavigationBarContainer : ImageItem
{
	private const int int_4 = 32;

	private ButtonItem buttonItem_0;

	private int int_5 = 2;

	private int int_6 = 2;

	private int int_7 = -1;

	private bool bool_22 = true;

	private bool bool_23 = true;

	private bool bool_24 = true;

	private bool bool_25 = true;

	private bool bool_26 = true;

	private Size size_3 = new Size(16, 16);

	private bool bool_27 = true;

	[Browsable(false)]
	public int SummaryLineStartItemIndex => int_7;

	[DefaultValue(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool Expanded
	{
		get
		{
			return base.Expanded;
		}
		set
		{
			if (value)
			{
				return;
			}
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem.Expanded)
				{
					subItem.Expanded = false;
				}
			}
			if (buttonItem_0 != null && buttonItem_0.Expanded)
			{
				buttonItem_0.Expanded = false;
			}
		}
	}

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates Configure Buttons button is visible.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public bool ConfigureItemVisible
	{
		get
		{
			return bool_22;
		}
		set
		{
			if (bool_22 != value)
			{
				bool_22 = value;
				NeedRecalcSize = true;
				if (!bool_22 && buttonItem_0 != null)
				{
					buttonItem_0 = null;
				}
			}
		}
	}

	[Description("Indicates whether Show More Buttons and Show Fewer Buttons menu items are visible on Configure buttons menu.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[DefaultValue(true)]
	public bool ConfigureShowHideVisible
	{
		get
		{
			return bool_23;
		}
		set
		{
			if (bool_23 != value)
			{
				bool_23 = value;
				if (!bool_23 && buttonItem_0 != null)
				{
					buttonItem_0 = null;
				}
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Indicates whether Show More Buttons and Show Fewer Buttons menu items are visible on Configure buttons menu.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	public bool ConfigureNavOptionsVisible
	{
		get
		{
			return bool_24;
		}
		set
		{
			if (bool_24 != value)
			{
				bool_24 = value;
				if (!bool_24 && buttonItem_0 != null)
				{
					buttonItem_0 = null;
				}
				NeedRecalcSize = true;
			}
		}
	}

	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	[Description("Indicates whether Navigation Pane Add/Remove Buttons menu item is visible on Configure buttons menu.")]
	public bool ConfigureAddRemoveVisible
	{
		get
		{
			return bool_25;
		}
		set
		{
			if (bool_25 != value)
			{
				bool_25 = value;
				if (!bool_24 && buttonItem_0 != null)
				{
					buttonItem_0 = null;
				}
			}
		}
	}

	[Browsable(true)]
	[Category("Layout")]
	[Description("Indicates the padding in pixels at the top portion of the item.")]
	[DefaultValue(2)]
	[DevCoBrowsable(true)]
	public int ItemPaddingTop
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			NeedRecalcSize = true;
			if (DesignMode)
			{
				Refresh();
			}
		}
	}

	[Category("Layout")]
	[Browsable(true)]
	[DefaultValue(2)]
	[DevCoBrowsable(true)]
	[Description("Indicates the padding in pixels at the bottom of the item.")]
	public int ItemPaddingBottom
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
			NeedRecalcSize = true;
			if (DesignMode)
			{
				Refresh();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates whether images are automatically resized to size specified in ImageSizeSummaryLine when button is on the bottom summary line of navigation bar.")]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	public bool AutoSizeButtonImage
	{
		get
		{
			return bool_26;
		}
		set
		{
			if (bool_26 != value)
			{
				bool_26 = value;
				NeedRecalcSize = true;
				if (DesignMode)
				{
					Refresh();
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates size of the image that will be use to resize images to when button button is on the bottom summary line of navigation bar and AutoSizeButtonImage=true.")]
	public Size ImageSizeSummaryLine
	{
		get
		{
			return size_3;
		}
		set
		{
			size_3 = value;
			if (bool_26)
			{
				NeedRecalcSize = true;
				if (DesignMode)
				{
					Refresh();
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Indicates whether summary line is visible.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool SummaryLineVisible
	{
		get
		{
			return bool_27;
		}
		set
		{
			if (bool_27 != value)
			{
				bool_27 = value;
				NeedRecalcSize = true;
				if (DesignMode)
				{
					Refresh();
				}
			}
		}
	}

	public NavigationBarContainer()
		: this("", "")
	{
	}

	public NavigationBarContainer(string sItemName)
		: this(sItemName, "")
	{
	}

	public NavigationBarContainer(string sItemName, string ItemText)
		: base(sItemName, ItemText)
	{
		m_IsContainer = true;
		SubItemsImageSize = Size.Empty;
	}

	public override BaseItem Copy()
	{
		NavigationBarContainer navigationBarContainer = new NavigationBarContainer();
		CopyToItem(navigationBarContainer);
		return navigationBarContainer;
	}

	public override void RecalcSize()
	{
		m_RecalculatingSize = true;
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		method_18(m_Rect.Bottom, 32);
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is ButtonItem)
			{
				((ButtonItem)subItem).ButtonStyle = eButtonStyle.ImageAndText;
				((ButtonItem)subItem).ImageFixedSize = Size.Empty;
			}
			if (bool_26 && !size_3.IsEmpty)
			{
				((ButtonItem)subItem).ImageFixedSize = size_3;
			}
			subItem.RecalcSize();
			subItem.HeightInternal += int_5 + int_6;
			if (subItem.Visible && subItem.HeightInternal > num)
			{
				num = subItem.HeightInternal;
			}
			if (bool_26 && !size_3.IsEmpty)
			{
				((ButtonItem)subItem).ImageFixedSize = Size.Empty;
				subItem.RecalcSize();
				subItem.HeightInternal += int_5 + int_6;
			}
		}
		int num4 = m_Rect.Top;
		int num5 = m_Rect.Left + num3;
		int num6 = 0;
		int widthInternal = WidthInternal - num3 * 2;
		bool flag = false;
		bool flag2 = false;
		int num7 = -1;
		foreach (BaseItem subItem2 in SubItems)
		{
			if (subItem2.Visible)
			{
				if (num4 + subItem2.HeightInternal + num2 <= m_Rect.Bottom - (bool_27 ? num : 0))
				{
					subItem2.TopInternal = num4;
					subItem2.LeftInternal = num5;
					subItem2.WidthInternal = widthInternal;
					subItem2.Displayed = true;
					num4 += subItem2.HeightInternal + num2;
					num6 += subItem2.HeightInternal + num2;
				}
				else if (bool_27)
				{
					if (!flag)
					{
						num6 += num;
						flag = true;
						num7 = SubItems.IndexOf(subItem2);
					}
					if (subItem2 is ButtonItem)
					{
						((ButtonItem)subItem2).ButtonStyle = eButtonStyle.Default;
						if (bool_26 && !size_3.IsEmpty)
						{
							((ButtonItem)subItem2).ImageFixedSize = size_3;
						}
						subItem2.RecalcSize();
						subItem2.HeightInternal += int_5 + int_6;
						if (!flag2 && num5 + subItem2.WidthInternal <= m_Rect.Right - method_19())
						{
							subItem2.TopInternal = num4;
							subItem2.LeftInternal = num5;
							subItem2.HeightInternal = num;
							num5 += subItem2.WidthInternal;
							subItem2.Displayed = true;
						}
						else
						{
							flag2 = true;
							subItem2.Displayed = false;
						}
					}
				}
				else
				{
					subItem2.Displayed = false;
				}
			}
			else
			{
				subItem2.Displayed = false;
			}
		}
		if (num == 0)
		{
			num = 32;
		}
		method_18(num4, num);
		if (!flag && bool_27)
		{
			num6 += num;
		}
		if (num7 >= 0)
		{
			num5 = m_Rect.Right - num3;
			if (buttonItem_0 != null)
			{
				num5 -= buttonItem_0.WidthInternal;
			}
			for (int num8 = SubItems.Count - 1; num8 >= num7; num8--)
			{
				if (SubItems[num8].Displayed)
				{
					num5 -= SubItems[num8].WidthInternal;
					SubItems[num8].LeftInternal = num5;
				}
			}
		}
		int_7 = num7;
		if (num6 == 0)
		{
			num6 = 32;
		}
		m_Rect.Height = num6;
		m_RecalculatingSize = false;
	}

	private void method_17(ItemPaintArgs itemPaintArgs_0, Rectangle rectangle_0, eDotNetBarStyle eDotNetBarStyle_0)
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007 && itemPaintArgs_0.BaseRenderer_0 != null)
		{
			itemPaintArgs_0.BaseRenderer_0.DrawNavPaneButtonBackground(new NavPaneRenderEventArgs(itemPaintArgs_0.Graphics, rectangle_0));
		}
		else if (itemPaintArgs_0.Colors.ItemBackground.IsEmpty && itemPaintArgs_0.Colors.ItemBackground2.IsEmpty)
		{
			if (!itemPaintArgs_0.Colors.BarBackground.IsEmpty || !itemPaintArgs_0.Colors.BarBackground2.IsEmpty)
			{
				Class50.smethod_26(itemPaintArgs_0.Graphics, rectangle_0, itemPaintArgs_0.Colors.BarBackground, itemPaintArgs_0.Colors.BarBackground2, itemPaintArgs_0.Colors.BarBackgroundGradientAngle);
			}
		}
		else
		{
			Class50.smethod_26(itemPaintArgs_0.Graphics, rectangle_0, itemPaintArgs_0.Colors.ItemBackground, itemPaintArgs_0.Colors.ItemBackground2, itemPaintArgs_0.Colors.ItemBackgroundGradientAngle);
		}
		Pen val = new Pen(itemPaintArgs_0.Colors.PanelBorder, 1f);
		try
		{
			itemPaintArgs_0.Graphics.DrawLine(val, rectangle_0.Left, rectangle_0.Top - 1, rectangle_0.Right, rectangle_0.Top - 1);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		if (m_Rect.Width == 0 || m_Rect.Height == 0)
		{
			return;
		}
		if (buttonItem_0 != null)
		{
			Rectangle rectangle_ = new Rectangle(m_Rect.X, buttonItem_0.TopInternal, m_Rect.Width, buttonItem_0.HeightInternal);
			method_17(pa, rectangle_, Style);
		}
		else if (int_7 >= 0)
		{
			Rectangle rectangle_2 = new Rectangle(m_Rect.X, SubItems[int_7].TopInternal, m_Rect.Width, SubItems[int_7].HeightInternal);
			method_17(pa, rectangle_2, Style);
		}
		else if (bool_27)
		{
			int num = -1;
			int num2 = SubItems.Count - 1;
			while (num2 >= 0)
			{
				BaseItem baseItem = SubItems[num2];
				if (!baseItem.Visible || !baseItem.Displayed)
				{
					num2--;
					continue;
				}
				num = baseItem.DisplayRectangle.Bottom;
				break;
			}
			if (num >= 0)
			{
				Rectangle rectangle_3 = new Rectangle(m_Rect.X, num, m_Rect.Width, m_Rect.Bottom - num);
				method_17(pa, rectangle_3, Style);
				Class50.smethod_32(pa.Graphics, m_Rect.X, num, m_Rect.Right, num, pa.Colors.PanelBorder, 1);
			}
		}
		bool flag = pa.Colors.ItemBackground.IsEmpty && pa.Colors.ItemBackground2.IsEmpty;
		for (int i = 0; i < SubItems.Count; i++)
		{
			BaseItem baseItem2 = SubItems[i];
			if (!baseItem2.Visible || !baseItem2.Displayed)
			{
				continue;
			}
			if (flag)
			{
				if (Style == eDotNetBarStyle.Office2007 && pa.BaseRenderer_0 != null)
				{
					pa.BaseRenderer_0.DrawNavPaneButtonBackground(new NavPaneRenderEventArgs(pa.Graphics, baseItem2.DisplayRectangle));
				}
				else
				{
					Class50.smethod_26(pa.Graphics, baseItem2.DisplayRectangle, pa.Colors.BarBackground, pa.Colors.BarBackground2, pa.Colors.BarBackgroundGradientAngle);
				}
			}
			baseItem2.Paint(pa);
			if (i > 0)
			{
				Pen val = new Pen(pa.Colors.PanelBorder, 1f);
				try
				{
					pa.Graphics.DrawLine(val, m_Rect.Left, baseItem2.TopInternal - 1, m_Rect.Right, baseItem2.TopInternal - 1);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
		}
		if (buttonItem_0 != null)
		{
			buttonItem_0.Paint(pa);
		}
	}

	private void method_18(int int_8, int int_9)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		if (!bool_22)
		{
			return;
		}
		if (buttonItem_0 == null)
		{
			Class264 @class = new Class264(GetOwner() as IOwnerLocalize);
			buttonItem_0 = new ButtonItem();
			buttonItem_0.Image = (Image)new Bitmap(typeof(DotNetBarManager), "SystemImages.NavBarConfigure.png");
			buttonItem_0.Style = m_Style;
			buttonItem_0.ShowSubItems = false;
			buttonItem_0.method_11(bool_22: true);
			if (bool_23)
			{
				ButtonItem buttonItem = new ButtonItem("sysShowMoreButtons");
				buttonItem.Image = (Image)new Bitmap(typeof(DotNetBarManager), "SystemImages.NavBarShowMore.png");
				buttonItem.Text = @class.method_0(LocalizationKeys.NavBarShowMoreButtons);
				buttonItem.method_11(bool_22: true);
				buttonItem.Click += method_21;
				buttonItem_0.SubItems.Add(buttonItem);
				buttonItem = new ButtonItem("sysShowFewerButtons");
				buttonItem.Image = (Image)new Bitmap(typeof(DotNetBarManager), "SystemImages.NavBarShowLess.png");
				buttonItem.Text = @class.method_0(LocalizationKeys.NavBarShowFewerButtons);
				buttonItem.method_11(bool_22: true);
				buttonItem.Click += method_23;
				buttonItem_0.SubItems.Add(buttonItem);
			}
			if (bool_24)
			{
				ButtonItem buttonItem = new ButtonItem("sysNavPaneOptions");
				buttonItem.Text = @class.method_0(LocalizationKeys.NavBarOptions);
				buttonItem.Click += method_26;
				buttonItem.method_11(bool_22: true);
				buttonItem_0.SubItems.Add(buttonItem);
			}
			if (bool_25)
			{
				CustomizeItem customizeItem = new CustomizeItem();
				customizeItem.Name = "sysNavPaneAddRemove";
				customizeItem.CustomizeItemVisible = false;
				buttonItem_0.SubItems.Add(customizeItem);
			}
			buttonItem_0.SetParent(this);
			buttonItem_0.Click += buttonItem_0_Click;
			buttonItem_0.ExpandChange += buttonItem_0_ExpandChange;
			buttonItem_0.PopupShowing += buttonItem_0_PopupShowing;
			buttonItem_0.PopupSide = ePopupSide.Right;
			@class.Dispose();
			if (ContainerControl is BarBaseControl barBaseControl && ((Control)barBaseControl).get_Font() != null)
			{
				buttonItem_0.PopupFont = new Font(((Control)barBaseControl).get_Font(), (FontStyle)0);
			}
			else
			{
				buttonItem_0.PopupFont = SystemInformation.get_MenuFont();
			}
		}
		buttonItem_0.PopupType = ePopupType.Menu;
		buttonItem_0.Displayed = true;
		buttonItem_0.RecalcSize();
		buttonItem_0.LeftInternal = m_Rect.Right - buttonItem_0.WidthInternal;
		buttonItem_0.TopInternal = int_8;
		buttonItem_0.HeightInternal = int_9;
	}

	private int method_19()
	{
		if (buttonItem_0 != null && bool_22)
		{
			return buttonItem_0.WidthInternal;
		}
		return 0;
	}

	private void buttonItem_0_Click(object sender, EventArgs e)
	{
		buttonItem_0.Expanded = !buttonItem_0.Expanded;
	}

	private void buttonItem_0_ExpandChange(object sender, EventArgs e)
	{
		if (buttonItem_0.Expanded)
		{
			if (bool_23)
			{
				buttonItem_0.SubItems["sysShowMoreButtons"].Enabled = int_7 >= 0;
				buttonItem_0.SubItems["sysShowFewerButtons"].Enabled = int_7 != 0;
			}
			bool flag = true;
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem.Visible && !subItem.Displayed)
				{
					BaseItem baseItem2 = subItem.Clone() as BaseItem;
					if (flag)
					{
						baseItem2.GlobalItem = false;
						baseItem2.BeginGroup = true;
						baseItem2.Click += method_20;
						flag = false;
					}
					else
					{
						baseItem2.GlobalItem = false;
						baseItem2.BeginGroup = false;
						baseItem2.Click += method_20;
					}
					baseItem2.Tag = subItem;
					if (baseItem2 is ButtonItem)
					{
						((ButtonItem)baseItem2).ImageFixedSize = new Size(16, 16);
					}
					buttonItem_0.SubItems.Insert(buttonItem_0.SubItems.Count - 1, baseItem2);
				}
			}
			Size popupSize = buttonItem_0.PopupSize;
			Point point = new Point(buttonItem_0.DisplayRectangle.Right, buttonItem_0.DisplayRectangle.Top + buttonItem_0.DisplayRectangle.Height / 2 - popupSize.Height);
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				Point point2 = val.PointToScreen(point);
				Class273 @class = Class109.smethod_53(val);
				if (point2.Y < @class.rectangle_1.Top)
				{
					point.Y = val.PointToClient(@class.rectangle_1.Location).Y;
				}
			}
			buttonItem_0.PopupLocation = point;
			return;
		}
		int heightInternal = buttonItem_0.HeightInternal;
		ArrayList arrayList = new ArrayList();
		foreach (BaseItem subItem2 in buttonItem_0.SubItems)
		{
			if (!subItem2.SystemItem)
			{
				arrayList.Add(subItem2);
			}
		}
		buttonItem_0.SuspendLayout = true;
		foreach (BaseItem item in arrayList)
		{
			buttonItem_0.SubItems.Remove(item);
		}
		buttonItem_0.SuspendLayout = false;
		buttonItem_0.RecalcSize();
		buttonItem_0.HeightInternal = heightInternal;
	}

	private void method_20(object sender, EventArgs e)
	{
		if (sender is ButtonItem buttonItem && buttonItem.Tag is ButtonItem buttonItem2)
		{
			buttonItem2.Checked = true;
			buttonItem.Checked = true;
		}
	}

	private void method_21(object sender, EventArgs e)
	{
		ShowMoreButtons();
		BaseItem.CollapseAll(sender as BaseItem);
	}

	public void ShowMoreButtons()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			val.set_Height(val.get_Height() + (method_22(bool_28: false) + 1));
		}
	}

	internal int method_22(bool bool_28)
	{
		int result = 0;
		BaseItem baseItem = method_24(bool_28);
		if (baseItem == null)
		{
			return result;
		}
		result = baseItem.HeightInternal;
		if (baseItem is ButtonItem && AutoSizeButtonImage && !ImageSizeSummaryLine.IsEmpty && !((ButtonItem)baseItem).ImageFixedSize.IsEmpty)
		{
			Size imageFixedSize = ((ButtonItem)baseItem).ImageFixedSize;
			((ButtonItem)baseItem).ImageFixedSize = Size.Empty;
			baseItem.RecalcSize();
			result = baseItem.HeightInternal;
			result += ItemPaddingBottom + ItemPaddingTop;
			((ButtonItem)baseItem).ImageFixedSize = imageFixedSize;
			baseItem.RecalcSize();
		}
		return result;
	}

	private void method_23(object sender, EventArgs e)
	{
		ShowFewerButtons();
		BaseItem.CollapseAll(sender as BaseItem);
	}

	internal BaseItem method_24(bool bool_28)
	{
		if (bool_28 && SummaryLineStartItemIndex > 1)
		{
			return SubItems[SummaryLineStartItemIndex - 1];
		}
		if (SummaryLineStartItemIndex >= 0)
		{
			return SubItems[SummaryLineStartItemIndex];
		}
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem.Visible && subItem.Displayed)
			{
				return subItem;
			}
		}
		return null;
	}

	internal BaseItem method_25()
	{
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem.Visible && subItem.Displayed)
			{
				return subItem;
			}
		}
		return null;
	}

	public void ShowFewerButtons()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			int num = method_22(bool_28: true);
			if (val.get_Height() - num > 0)
			{
				val.set_Height(val.get_Height() - num);
			}
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Invalid comparison between Unknown and I4
		BaseItem.CollapseAll(sender as BaseItem);
		NavPaneOptions navPaneOptions = new NavPaneOptions();
		Class264 @class = new Class264(GetOwner() as IOwnerLocalize);
		if (@class != null)
		{
			string text = @class.method_0(LocalizationKeys.NavBarDialogCancel);
			if (text != "")
			{
				((Control)navPaneOptions.cmdCancel).set_Text(text);
			}
			text = @class.method_0(LocalizationKeys.NavBarDialogMoveDown);
			if (text != "")
			{
				((Control)navPaneOptions.cmdMoveDown).set_Text(text);
			}
			text = @class.method_0(LocalizationKeys.NavBarDialogMoveUp);
			if (text != "")
			{
				((Control)navPaneOptions.cmdMoveUp).set_Text(text);
			}
			text = @class.method_0(LocalizationKeys.NavBarDialogOK);
			if (text != "")
			{
				((Control)navPaneOptions.cmdOK).set_Text(text);
			}
			text = @class.method_0(LocalizationKeys.NavBarDialogReset);
			if (text != "")
			{
				((Control)navPaneOptions.cmdReset).set_Text(text);
			}
			text = @class.method_0(LocalizationKeys.NavBarDialogTitle);
			if (text != "")
			{
				((Control)navPaneOptions).set_Text(text);
			}
			text = @class.method_0(LocalizationKeys.NavBarDialogListLabel);
			if (text != "")
			{
				((Control)navPaneOptions.labelListCaption).set_Text(text);
			}
		}
		((Form)navPaneOptions).set_StartPosition((FormStartPosition)1);
		navPaneOptions.NavBarContainer = this;
		DialogResult val = ((Form)navPaneOptions).ShowDialog();
		((Component)(object)navPaneOptions).Dispose();
		if ((int)val == 1 && ContainerControl is BarBaseControl)
		{
			((BarBaseControl)ContainerControl).RecalcLayout();
		}
	}

	private void buttonItem_0_PopupShowing(object sender, EventArgs e)
	{
		if (ContainerControl is NavigationBar && Style == eDotNetBarStyle.Office2007)
		{
			((MenuPanel)(object)buttonItem_0.PopupControl).ColorScheme = ((NavigationBar)ContainerControl).GetColorScheme();
		}
		else
		{
			((MenuPanel)(object)buttonItem_0.PopupControl).ColorScheme = new ColorScheme(Style);
		}
	}

	public override void InternalMouseHover()
	{
		if (buttonItem_0 != null && buttonItem_0.Expanded && m_HotSubItem != buttonItem_0 && DesignMode)
		{
			buttonItem_0.Expanded = false;
		}
		base.InternalMouseHover();
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		if (buttonItem_0 != null && buttonItem_0.Expanded && m_HotSubItem != buttonItem_0 && !DesignMode)
		{
			buttonItem_0.Expanded = false;
		}
		base.InternalMouseDown(objArg);
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		if (buttonItem_0 != null && buttonItem_0.DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()) && !DesignMode)
		{
			BaseItem baseItem = buttonItem_0;
			if (baseItem != m_HotSubItem)
			{
				if (m_HotSubItem != null)
				{
					m_HotSubItem.InternalMouseLeave();
					if (baseItem != null && m_HotSubItem.Expanded)
					{
						m_HotSubItem.Expanded = false;
					}
				}
				if (baseItem != null)
				{
					if (m_AutoExpand)
					{
						BaseItem baseItem2 = ExpandedItem();
						if (baseItem2 != null && baseItem2 != baseItem)
						{
							baseItem2.Expanded = false;
						}
					}
					baseItem.InternalMouseEnter();
					baseItem.InternalMouseMove(objArg);
					if (m_AutoExpand && baseItem.Enabled && baseItem.ShowSubItems)
					{
						if (baseItem is PopupItem)
						{
							PopupItem popupItem = baseItem as PopupItem;
							ePopupAnimation popupAnimation = popupItem.PopupAnimation;
							popupItem.PopupAnimation = ePopupAnimation.None;
							baseItem.Expanded = true;
							popupItem.PopupAnimation = popupAnimation;
						}
						else
						{
							baseItem.Expanded = true;
						}
					}
					m_HotSubItem = baseItem;
				}
				else
				{
					m_HotSubItem = null;
				}
			}
			else if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalMouseMove(objArg);
			}
		}
		else
		{
			base.InternalMouseMove(objArg);
		}
	}

	protected internal override void OnSubItemExpandChange(BaseItem objItem)
	{
		base.OnSubItemExpandChange(objItem);
		if (!objItem.Expanded)
		{
			return;
		}
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem != objItem && subItem is PopupItem && subItem.Expanded)
			{
				subItem.Expanded = false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImageSizeSummaryLine()
	{
		if (size_3.Width == 16)
		{
			return size_3.Height != 16;
		}
		return true;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void RefreshImageSize()
	{
	}

	public override void OnSubItemImageSizeChanged(BaseItem objItem)
	{
	}

	protected internal override void OnItemAdded(BaseItem item)
	{
		GetIOwnerItemEvents()?.InvokeItemAdded(item, new EventArgs());
	}

	public override void InternalKeyDown(KeyEventArgs objArg)
	{
		base.InternalKeyDown(objArg);
		Class104.smethod_0(this, objArg);
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
[Designer(typeof(RibbonTabItemDesigner))]
public class RibbonTabItem : ButtonItem
{
	private RibbonPanel ribbonPanel_0;

	private RibbonTabItemGroup ribbonTabItemGroup_0;

	private eRibbonTabColor eRibbonTabColor_0;

	private string string_11 = "Default";

	private bool bool_49;

	private int int_21;

	private DateTime dateTime_0 = DateTime.MinValue;

	[DefaultValue(0)]
	[Description("Indicates additional padding added around the tab item in pixels.")]
	[Browsable(true)]
	[Category("Layout")]
	public int PaddingHorizontal
	{
		get
		{
			return int_21;
		}
		set
		{
			int_21 = value;
			method_45();
		}
	}

	internal new bool Boolean_8
	{
		get
		{
			return bool_49;
		}
		set
		{
			bool_49 = value;
		}
	}

	[Category("Appearance")]
	[Description("Indicates predefined color of item when Office 2007 style is used.")]
	[Browsable(true)]
	[DefaultValue(eRibbonTabColor.Default)]
	public new eRibbonTabColor ColorTable
	{
		get
		{
			return eRibbonTabColor_0;
		}
		set
		{
			if (eRibbonTabColor_0 != value)
			{
				eRibbonTabColor_0 = value;
				string_11 = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor_0);
				Refresh();
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Indicates the group tab belongs to.")]
	[Category("Tab Group")]
	[Editor(typeof(RibbonTabItemGroupTypeEditor), typeof(UITypeEditor))]
	[DevCoBrowsable(true)]
	public RibbonTabItemGroup Group
	{
		get
		{
			return ribbonTabItemGroup_0;
		}
		set
		{
			ribbonTabItemGroup_0 = value;
			if (DesignMode && ContainerControl is ItemControl itemControl)
			{
				itemControl.RecalcLayout();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	public RibbonPanel Panel
	{
		get
		{
			return ribbonPanel_0;
		}
		set
		{
			ribbonPanel_0 = value;
			method_43();
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DefaultValue("")]
	public override string OptionGroup
	{
		get
		{
			return base.OptionGroup;
		}
		set
		{
			base.OptionGroup = value;
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public override SubItemsCollection SubItems => base.SubItems;

	[Category("Behavior")]
	[Browsable(false)]
	[DefaultValue(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	[Description("Indicates whether the item will auto-collapse (fold) when clicked.")]
	public override bool AutoCollapseOnClick
	{
		get
		{
			return base.AutoCollapseOnClick;
		}
		set
		{
			base.AutoCollapseOnClick = value;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
	[DefaultValue(false)]
	[Description("Indicates whether the item will auto-collapse (fold) when clicked.")]
	public override bool AutoExpandOnClick
	{
		get
		{
			return base.AutoExpandOnClick;
		}
		set
		{
			base.AutoExpandOnClick = value;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Description("Indicates whether item can be customized by user.")]
	[Category("Behavior")]
	[DefaultValue(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool CanCustomize
	{
		get
		{
			return base.CanCustomize;
		}
		set
		{
			base.CanCustomize = value;
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	[Category("Appearance")]
	[DevCoBrowsable(false)]
	[Description("Indicates whether item is checked or not.")]
	public override bool Checked
	{
		get
		{
			return base.Checked;
		}
		set
		{
			base.Checked = value;
		}
	}

	[Browsable(false)]
	[Category("Behavior")]
	[DefaultValue(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Description("Gets or sets whether Click event will be auto repeated when mouse button is kept pressed over the item.")]
	[DevCoBrowsable(false)]
	public override bool ClickAutoRepeat
	{
		get
		{
			return base.ClickAutoRepeat;
		}
		set
		{
			base.ClickAutoRepeat = value;
		}
	}

	[DevCoBrowsable(false)]
	[Category("Behavior")]
	[Browsable(false)]
	[Description("Gets or sets the auto-repeat interval for the click event when mouse button is kept pressed over the item.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DefaultValue(600)]
	public override int ClickRepeatInterval
	{
		get
		{
			return base.ClickRepeatInterval;
		}
		set
		{
			base.ClickRepeatInterval = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(true)]
	[Browsable(false)]
	[Description("Indicates whether is item enabled.")]
	[DevCoBrowsable(false)]
	public override bool Enabled
	{
		get
		{
			return base.Enabled;
		}
		set
		{
			base.Enabled = value;
		}
	}

	[Browsable(false)]
	[Description("Indicates item's visiblity when on pop-up menu.")]
	[Category("Appearance")]
	[DevCoBrowsable(false)]
	[DefaultValue(eMenuVisibility.VisibleAlways)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override eMenuVisibility MenuVisibility
	{
		get
		{
			return base.MenuVisibility;
		}
		set
		{
			base.MenuVisibility = value;
		}
	}

	[DevCoBrowsable(false)]
	[Description("Indicates when menu items are displayed when MenuVisiblity is set to VisibleIfRecentlyUsed and RecentlyUsed is true.")]
	[Browsable(false)]
	[DefaultValue(ePersonalizedMenus.Disabled)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Category("Appearance")]
	public override ePersonalizedMenus PersonalizedMenus
	{
		get
		{
			return base.PersonalizedMenus;
		}
		set
		{
			base.PersonalizedMenus = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Description("Indicates Animation type for Popups.")]
	[Category("Behavior")]
	[DefaultValue(ePopupAnimation.ManagerControlled)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public override ePopupAnimation PopupAnimation
	{
		get
		{
			return base.PopupAnimation;
		}
		set
		{
			base.PopupAnimation = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Description("Indicates the font that will be used on the popup window.")]
	[Category("Appearance")]
	[DefaultValue(null)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public override Font PopupFont
	{
		get
		{
			return base.PopupFont;
		}
		set
		{
			base.PopupFont = value;
		}
	}

	[DevCoBrowsable(false)]
	[DefaultValue(ePopupType.Menu)]
	[Description("Indicates whether sub-items are shown on popup Bar or popup menu.")]
	[Browsable(false)]
	[Category("Appearance")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override ePopupType PopupType
	{
		get
		{
			return base.PopupType;
		}
		set
		{
			base.PopupType = value;
		}
	}

	[Category("Layout")]
	[DefaultValue(200)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Description("Specifies the inital width for the Bar that hosts pop-up items. Applies to PopupType.Toolbar only.")]
	public override int PopupWidth
	{
		get
		{
			return base.PopupWidth;
		}
		set
		{
			base.PopupWidth = value;
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[Description("Determines whether sub-items are displayed.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool ShowSubItems
	{
		get
		{
			return base.ShowSubItems;
		}
		set
		{
			base.ShowSubItems = value;
		}
	}

	[Category("Appearance")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DefaultValue(false)]
	[Description("Indicates whether item will stretch to consume empty space. Items on stretchable, no-wrap Bars only.")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool Stretch
	{
		get
		{
			return base.Stretch;
		}
		set
		{
			base.Stretch = value;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DefaultValue(12)]
	[Category("Behavior")]
	[Description("Indicates the width of the expand part of the button item.")]
	public override int SubItemsExpandWidth
	{
		get
		{
			return base.SubItemsExpandWidth;
		}
		set
		{
			base.SubItemsExpandWidth = value;
		}
	}

	[Category("Design")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DefaultValue("")]
	[Description("Gets or set the alternative Shortcut Text.  This text appears next to the Text instead of any shortcuts")]
	public override string AlternateShortCutText
	{
		get
		{
			return base.AlternateShortCutText;
		}
		set
		{
			base.AlternateShortCutText = value;
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether this item is beginning of the group.")]
	[Browsable(false)]
	[Category("Appearance")]
	[DevCoBrowsable(false)]
	public override bool BeginGroup
	{
		get
		{
			return base.BeginGroup;
		}
		set
		{
			base.BeginGroup = value;
		}
	}

	[Description("Indicates item category used to group similar items at design-time.")]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Category("Design")]
	[DefaultValue("")]
	[DevCoBrowsable(false)]
	public override string Category
	{
		get
		{
			return base.Category;
		}
		set
		{
			base.Category = value;
		}
	}

	[Description("The foreground color used to display text when mouse is over the item.")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Category("Appearance")]
	public override Color HotForeColor
	{
		get
		{
			return base.HotForeColor;
		}
		set
		{
			base.HotForeColor = value;
		}
	}

	[Description("Indicates the way item is painting the picture when mouse is over it. Setting the value to Color will render the image in gray-scale when mouse is not over the item.")]
	[DefaultValue(eHotTrackingStyle.Default)]
	[Browsable(false)]
	[Category("Appearance")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	public override eHotTrackingStyle HotTrackingStyle
	{
		get
		{
			return base.HotTrackingStyle;
		}
		set
		{
			base.HotTrackingStyle = value;
		}
	}

	[Browsable(false)]
	[Category("Appearance")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	[Description("The foreground color used to display text.")]
	public override Color ForeColor
	{
		get
		{
			return base.ForeColor;
		}
		set
		{
			base.ForeColor = value;
		}
	}

	public void Select()
	{
		Checked = true;
	}

	internal override string vmethod_1()
	{
		if (!(CustomColorName != ""))
		{
			return string_11;
		}
		return CustomColorName;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetGroup()
	{
		TypeDescriptor.GetProperties(this)["Group"]!.SetValue(this, null);
	}

	private void method_43()
	{
		method_44();
	}

	protected override void OnCheckedChanged()
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (Checked && Parent != null)
		{
			method_44();
			foreach (BaseItem subItem in Parent.SubItems)
			{
				if (subItem != this && subItem is RibbonTabItem ribbonTabItem && ribbonTabItem.Checked)
				{
					if (DesignMode)
					{
						TypeDescriptor.GetProperties(ribbonTabItem)["Checked"]!.SetValue(ribbonTabItem, false);
					}
					else
					{
						ribbonTabItem.Checked = false;
					}
				}
			}
		}
		dateTime_0 = DateTime.MinValue;
		if (Style == eDotNetBarStyle.Office2007 && ContainerControl is Control)
		{
			((Control)ContainerControl).Invalidate();
		}
		if (!Checked)
		{
			method_44();
		}
		InvokeCheckedChanged();
	}

	private void method_44()
	{
		if (Checked && ribbonPanel_0 != null)
		{
			if (DesignMode)
			{
				if (!ribbonPanel_0.Visible)
				{
					ribbonPanel_0.Visible = true;
				}
				TypeDescriptor.GetProperties(ribbonPanel_0)["Visible"]!.SetValue(ribbonPanel_0, true);
				((Control)ribbonPanel_0).BringToFront();
			}
			else
			{
				((Control)ribbonPanel_0).SuspendLayout();
				ribbonPanel_0.Visible = true;
				((Control)ribbonPanel_0).ResumeLayout(true);
				((Control)ribbonPanel_0).BringToFront();
			}
		}
		else if (!Checked && ribbonPanel_0 != null && !ribbonPanel_0.Boolean_0)
		{
			if (DesignMode)
			{
				TypeDescriptor.GetProperties(ribbonPanel_0)["Visible"]!.SetValue(ribbonPanel_0, false);
			}
			else
			{
				ribbonPanel_0.Visible = false;
			}
		}
	}

	protected override void OnClick()
	{
		base.OnClick();
		if (!Checked)
		{
			if (DesignMode)
			{
				TypeDescriptor.GetProperties(this)["Checked"]!.SetValue(this, true);
			}
			else
			{
				Checked = true;
			}
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (!(val is RibbonStrip) || !((RibbonStrip)(object)val).Boolean_5 || !(val.get_Parent() is RibbonControl))
		{
			return;
		}
		RibbonControl ribbonControl = (RibbonControl)(object)val.get_Parent();
		if (!ribbonControl.Expanded)
		{
			TimeSpan timeSpan = DateTime.Now.Subtract(dateTime_0);
			if (dateTime_0 == DateTime.MinValue || Math.Abs(timeSpan.TotalMilliseconds) > (double)SystemInformation.get_DoubleClickTime())
			{
				ribbonControl.method_21(this);
				dateTime_0 = DateTime.MinValue;
			}
		}
	}

	protected override void InvokeDoubleClick()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val is RibbonStrip && ((RibbonStrip)(object)val).Boolean_5 && val.get_Parent() is RibbonControl)
		{
			((RibbonControl)(object)val.get_Parent()).method_22(this);
			dateTime_0 = DateTime.Now;
		}
		base.InvokeDoubleClick();
	}

	protected internal override void OnVisibleChanged(bool bVisible)
	{
		base.OnVisibleChanged(bVisible);
		if (bVisible || !Checked)
		{
			return;
		}
		TypeDescriptor.GetProperties(this)["Checked"]!.SetValue(this, false);
		if (Parent == null)
		{
			return;
		}
		foreach (BaseItem subItem in Parent.SubItems)
		{
			if (subItem != this && subItem.method_2() && subItem.Visible && subItem is RibbonTabItem component)
			{
				TypeDescriptor.GetProperties(component)["Checked"]!.SetValue(this, true);
				break;
			}
		}
	}

	protected override void OnStyleChanged()
	{
		base.OnStyleChanged();
		method_45();
	}

	private void method_45()
	{
		if (Style == eDotNetBarStyle.Office2007)
		{
			base.Int32_1 = 0;
			base.Int32_2 = 12 + int_21;
		}
		else if (Style == eDotNetBarStyle.Office2003)
		{
			base.Int32_1 = -1;
			base.Int32_2 = 2 + int_21;
		}
		else
		{
			base.Int32_1 = 0;
			base.Int32_2 = int_21;
		}
		NeedRecalcSize = true;
		OnAppearanceChanged();
	}

	internal override void vmethod_0()
	{
		Checked = true;
	}

	protected override void Invalidate(Control containerControl)
	{
		Rectangle rect = m_Rect;
		rect.Width++;
		rect.Height++;
		containerControl.Invalidate(rect, true);
	}
}

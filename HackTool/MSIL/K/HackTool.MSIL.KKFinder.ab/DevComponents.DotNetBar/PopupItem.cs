using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public abstract class PopupItem : ImageItem, IDesignTimeProvider
{
	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	private DotNetBarManager.PopupOpenEventHandler popupOpenEventHandler_0;

	private EventHandler eventHandler_16;

	private EventHandler eventHandler_17;

	private EventHandler eventHandler_18;

	private MenuPanel menuPanel_0;

	private Bar bar_0;

	private PopupContainerControl popupContainerControl_0;

	private bool bool_22;

	protected SideBarImage m_SideBar;

	private ePopupType ePopupType_0;

	private bool bool_23;

	private Size size_3;

	private int int_4 = 200;

	private ePersonalizedMenus ePersonalizedMenus_0;

	private Point point_2 = Point.Empty;

	private ePopupAnimation ePopupAnimation_0 = ePopupAnimation.ManagerControlled;

	private Font font_0;

	private Control control_0;

	private ePopupSide ePopupSide_0;

	private bool bool_24;

	private bool Boolean_3
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Invalid comparison between Unknown and I4
			if (Class92.Boolean_4)
			{
				return true;
			}
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				return (int)val.get_RightToLeft() == 1;
			}
			return false;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Size PopupSize
	{
		get
		{
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			if (SubItemsImageSize.Width == ImageItem.size_2.Width && SubItemsImageSize.Height == ImageItem.size_2.Height)
			{
				size_3 = SubItemsImageSize;
				SubItemsImageSize = new Size(16, 16);
			}
			foreach (BaseItem subItem in SubItems)
			{
				subItem.Orientation = eOrientation.Horizontal;
			}
			MenuPanel menuPanel = new MenuPanel();
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			IOwnerMenuSupport iOwnerMenuSupport = GetIOwnerMenuSupport();
			menuPanel.Owner = GetOwner();
			if (font_0 != null)
			{
				((Control)menuPanel).set_Font(font_0);
			}
			else if (val != null && val.get_Font() != null)
			{
				((Control)menuPanel).set_Font((Font)val.get_Font().Clone());
			}
			if (iOwnerMenuSupport != null && iOwnerMenuSupport.AlwaysShowFullMenus)
			{
				menuPanel.PersonalizedMenus = ePersonalizedMenus.Disabled;
			}
			else
			{
				menuPanel.PersonalizedMenus = ePersonalizedMenus_0;
			}
			if (iOwnerMenuSupport != null && !iOwnerMenuSupport.ShowFullMenusOnHover && (menuPanel.PersonalizedMenus == ePersonalizedMenus.DisplayOnHover || menuPanel.PersonalizedMenus == ePersonalizedMenus.Both))
			{
				menuPanel.PersonalizedMenus = ePersonalizedMenus.DisplayOnClick;
			}
			menuPanel.PopupAnimation = ePopupAnimation_0;
			if (iOwnerMenuSupport != null && (IsOnMenuBar || base.IsOnMenu))
			{
				menuPanel.PersonalizedAllVisible = iOwnerMenuSupport.PersonalizedAllVisible;
			}
			if (Parent is CustomizeItem || (this is CustomizeItem && !(this is QatCustomizeItem)))
			{
				menuPanel.Boolean_6 = true;
			}
			if (GetOwner() is DotNetBarManager && ((DotNetBarManager)GetOwner()).UseGlobalColorScheme)
			{
				menuPanel.ColorScheme = ((DotNetBarManager)GetOwner()).ColorScheme;
			}
			if (val is Bar)
			{
				menuPanel.ColorScheme = ((Bar)(object)val).ColorScheme;
			}
			else if (val is MenuPanel)
			{
				menuPanel.ColorScheme = ((MenuPanel)(object)val).ColorScheme;
			}
			else if (val is PopupItemControl)
			{
				menuPanel.ColorScheme = ((PopupItemControl)(object)val).GetColorScheme();
			}
			else if (Style == eDotNetBarStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer)
			{
				menuPanel.ColorScheme = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.LegacyColors;
			}
			else
			{
				menuPanel.ColorScheme = new ColorScheme(Style);
			}
			menuPanel.SideBar = m_SideBar;
			menuPanel.ParentItem = this;
			((Control)menuPanel).CreateControl();
			menuPanel.RecalcSize();
			Size size = ((Control)menuPanel).get_Size();
			((Component)(object)menuPanel).Dispose();
			menuPanel = null;
			return size;
		}
	}

	[DefaultValue(ePopupType.Menu)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Description("Indicates whether sub-items are shown on popup Bar or popup menu.")]
	public virtual ePopupType PopupType
	{
		get
		{
			return ePopupType_0;
		}
		set
		{
			if (ePopupType_0 != value)
			{
				ePopupType_0 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "PopupType");
				}
				NeedRecalcSize = true;
				Refresh();
			}
		}
	}

	[Description("Indicates the font that will be used on the popup window.")]
	[DevCoBrowsable(true)]
	[DefaultValue(null)]
	[Category("Appearance")]
	[Browsable(true)]
	public virtual Font PopupFont
	{
		get
		{
			return font_0;
		}
		set
		{
			if (font_0 != value)
			{
				font_0 = value;
			}
		}
	}

	[Category("Appearance")]
	[Browsable(false)]
	[Description("Indicates side bar for pop-up window.")]
	public virtual SideBarImage PopUpSideBar
	{
		get
		{
			return m_SideBar;
		}
		set
		{
			m_SideBar = value;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(true)]
	[Description("Indicates location of popup in relation to it's parent.")]
	[DefaultValue(ePopupSide.Default)]
	public virtual ePopupSide PopupSide
	{
		get
		{
			return ePopupSide_0;
		}
		set
		{
			ePopupSide_0 = value;
			OnAppearanceChanged();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Point PopupLocation
	{
		get
		{
			if (menuPanel_0 != null)
			{
				return ((Control)menuPanel_0).get_Location();
			}
			if (bar_0 != null)
			{
				return bar_0.Location;
			}
			if (popupContainerControl_0 != null)
			{
				return ((Control)popupContainerControl_0).get_Location();
			}
			return point_2;
		}
		set
		{
			point_2 = value;
			if (menuPanel_0 != null)
			{
				((Control)menuPanel_0).set_Location(value);
			}
			else if (bar_0 != null)
			{
				bar_0.Location = value;
			}
			else if (popupContainerControl_0 != null)
			{
				((Control)popupContainerControl_0).set_Location(value);
			}
		}
	}

	[Description("Indicates when menu items are displayed when MenuVisiblity is set to VisibleIfRecentlyUsed and RecentlyUsed is true.")]
	[DevCoBrowsable(true)]
	[DefaultValue(ePersonalizedMenus.Disabled)]
	[Category("Appearance")]
	[Browsable(true)]
	public virtual ePersonalizedMenus PersonalizedMenus
	{
		get
		{
			return ePersonalizedMenus_0;
		}
		set
		{
			ePersonalizedMenus_0 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(ePopupAnimation.ManagerControlled)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Indicates Animation type for Popups.")]
	public virtual ePopupAnimation PopupAnimation
	{
		get
		{
			return ePopupAnimation_0;
		}
		set
		{
			ePopupAnimation_0 = value;
		}
	}

	internal bool Boolean_4
	{
		get
		{
			return bool_22;
		}
		set
		{
			bool_22 = true;
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Layout")]
	[DefaultValue(200)]
	[Description("Specifies the inital width for the Bar that hosts pop-up items. Applies to PopupType.Toolbar only.")]
	public virtual int PopupWidth
	{
		get
		{
			return int_4;
		}
		set
		{
			if (int_4 != value && value > 0)
			{
				int_4 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "PopupWidth");
				}
			}
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Description("Gets the control that is displaying the context menu.")]
	public Control SourceControl => control_0;

	[Browsable(false)]
	public PopupContainerControl PopupContainerControl => popupContainerControl_0;

	[Browsable(false)]
	public Control PopupControl
	{
		get
		{
			if (menuPanel_0 != null)
			{
				return (Control)(object)menuPanel_0;
			}
			if (bar_0 != null)
			{
				return (Control)(object)bar_0;
			}
			if (popupContainerControl_0 != null)
			{
				return (Control)(object)popupContainerControl_0;
			}
			return null;
		}
	}

	internal virtual bool Boolean_8
	{
		get
		{
			return bool_24;
		}
		set
		{
			bool_24 = value;
		}
	}

	public event EventHandler PopupContainerLoad
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_14 = (EventHandler)Delegate.Combine(eventHandler_14, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_14 = (EventHandler)Delegate.Remove(eventHandler_14, value);
		}
	}

	public event EventHandler PopupContainerUnload
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_15 = (EventHandler)Delegate.Combine(eventHandler_15, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_15 = (EventHandler)Delegate.Remove(eventHandler_15, value);
		}
	}

	[Description("Occurs when popup item is about to open.")]
	public event DotNetBarManager.PopupOpenEventHandler PopupOpen
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			popupOpenEventHandler_0 = (DotNetBarManager.PopupOpenEventHandler)Delegate.Combine(popupOpenEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			popupOpenEventHandler_0 = (DotNetBarManager.PopupOpenEventHandler)Delegate.Remove(popupOpenEventHandler_0, value);
		}
	}

	[Description("Occurs when popup item is closing.")]
	public event EventHandler PopupClose
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_16 = (EventHandler)Delegate.Combine(eventHandler_16, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_16 = (EventHandler)Delegate.Remove(eventHandler_16, value);
		}
	}

	[Description("Occurs after popup item has been closed.")]
	public event EventHandler PopupFinalized
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_17 = (EventHandler)Delegate.Combine(eventHandler_17, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_17 = (EventHandler)Delegate.Remove(eventHandler_17, value);
		}
	}

	[Description("Occurs just before popup window is shown.")]
	public event EventHandler PopupShowing
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_18 = (EventHandler)Delegate.Combine(eventHandler_18, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_18 = (EventHandler)Delegate.Remove(eventHandler_18, value);
		}
	}

	public PopupItem()
		: this("", "")
	{
	}

	public PopupItem(string sName)
		: this(sName, "")
	{
	}

	public PopupItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		menuPanel_0 = null;
		bar_0 = null;
		bool_22 = false;
		ePopupType_0 = ePopupType.Menu;
		m_SideBar = default(SideBarImage);
		bool_23 = false;
		size_3 = Size.Empty;
	}

	public override void Dispose()
	{
		if (Expanded)
		{
			ClosePopup();
		}
		base.Dispose();
	}

	protected override void CopyToItem(BaseItem copy)
	{
		base.CopyToItem(copy);
		PopupItem popupItem = copy as PopupItem;
		popupItem.eventHandler_14 = eventHandler_14;
		popupItem.eventHandler_15 = eventHandler_15;
		popupItem.PersonalizedMenus = PersonalizedMenus;
		popupItem.PopUpSideBar = PopUpSideBar;
		popupItem.PopupAnimation = PopupAnimation;
		popupItem.PopupSide = PopupSide;
		popupItem.PopupWidth = PopupWidth;
		popupItem.eventHandler_16 = eventHandler_16;
		popupItem.eventHandler_14 = eventHandler_14;
		popupItem.eventHandler_15 = eventHandler_15;
		popupItem.eventHandler_17 = eventHandler_17;
		popupItem.popupOpenEventHandler_0 = popupOpenEventHandler_0;
		popupItem.eventHandler_18 = eventHandler_18;
		popupItem.PopupType = PopupType;
		popupItem.PopupWidth = PopupWidth;
	}

	protected internal override void OnItemAdded(BaseItem objItem)
	{
		base.OnItemAdded(objItem);
		if (SubItems.Count > 1)
		{
			m_NeedRecalcSize = false;
		}
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected I4, but got Unknown
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		itemXmlElement.SetAttribute("PopupType", XmlConvert.ToString((int)ePopupType_0));
		itemXmlElement.SetAttribute("PopupWidth", XmlConvert.ToString(int_4));
		itemXmlElement.SetAttribute("PersonalizedMenus", XmlConvert.ToString((int)ePersonalizedMenus_0));
		itemXmlElement.SetAttribute("panim", XmlConvert.ToString((int)ePopupAnimation_0));
		if (font_0 != null)
		{
			itemXmlElement.SetAttribute("fontname", font_0.get_Name());
			itemXmlElement.SetAttribute("fontemsize", XmlConvert.ToString(font_0.get_Size()));
			itemXmlElement.SetAttribute("fontstyle", XmlConvert.ToString((int)font_0.get_Style()));
		}
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		ePopupType_0 = (ePopupType)XmlConvert.ToInt32(itemXmlElement.GetAttribute("PopupType"));
		int_4 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("PopupWidth"));
		ePersonalizedMenus_0 = (ePersonalizedMenus)XmlConvert.ToInt32(itemXmlElement.GetAttribute("PersonalizedMenus"));
		if (itemXmlElement.HasAttribute("panim"))
		{
			ePopupAnimation_0 = (ePopupAnimation)XmlConvert.ToInt32(itemXmlElement.GetAttribute("panim"));
		}
		else
		{
			ePopupAnimation_0 = ePopupAnimation.SystemDefault;
		}
		font_0 = null;
		if (itemXmlElement.HasAttribute("fontname"))
		{
			string attribute = itemXmlElement.GetAttribute("fontname");
			float num = XmlConvert.ToSingle(itemXmlElement.GetAttribute("fontemsize"));
			FontStyle val = (FontStyle)XmlConvert.ToInt32(itemXmlElement.GetAttribute("fontstyle"));
			try
			{
				font_0 = new Font(attribute, num, val);
			}
			catch (Exception)
			{
				font_0 = null;
			}
		}
	}

	public override void InternalKeyDown(KeyEventArgs objArg)
	{
		if (Expanded)
		{
			if (menuPanel_0 != null)
			{
				if (menuPanel_0.FocusedItem() != null)
				{
					menuPanel_0.FocusedItem().InternalKeyDown(objArg);
				}
				if (menuPanel_0 != null)
				{
					menuPanel_0.method_27(objArg);
				}
			}
			else if (bar_0 != null)
			{
				bar_0.method_70(objArg);
			}
		}
		else
		{
			base.InternalKeyDown(objArg);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		base.InternalMouseMove(objArg);
		if (Expanded && menuPanel_0 != null && !DesignMode)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				Point point = val.PointToScreen(new Point(objArg.get_X(), objArg.get_Y()));
				point = ((Control)menuPanel_0).PointToClient(point);
				menuPanel_0.method_16(new MouseEventArgs(objArg.get_Button(), objArg.get_Clicks(), point.X, point.Y, objArg.get_Delta()));
			}
		}
		else if (Expanded && bar_0 != null && !DesignMode)
		{
			object containerControl2 = ContainerControl;
			Control val2 = (Control)((containerControl2 is Control) ? containerControl2 : null);
			if (val2 != null)
			{
				Point point2 = val2.PointToScreen(new Point(objArg.get_X(), objArg.get_Y()));
				point2 = ((Control)bar_0).PointToClient(point2);
				bar_0.method_48(new MouseEventArgs((MouseButtons)0, objArg.get_Clicks(), point2.X, point2.Y, objArg.get_Delta()));
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		base.InternalMouseUp(objArg);
		if (Expanded && menuPanel_0 != null && !DesignMode)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				Point point = val.PointToScreen(new Point(objArg.get_X(), objArg.get_Y()));
				point = ((Control)menuPanel_0).PointToClient(point);
				menuPanel_0.method_24(new MouseEventArgs(objArg.get_Button(), objArg.get_Clicks(), point.X, point.Y, objArg.get_Delta()));
			}
		}
		else if (Expanded && bar_0 != null && !DesignMode)
		{
			object containerControl2 = ContainerControl;
			Control val2 = (Control)((containerControl2 is Control) ? containerControl2 : null);
			if (val2 != null)
			{
				Point point2 = val2.PointToScreen(new Point(objArg.get_X(), objArg.get_Y()));
				point2 = ((Control)bar_0).PointToClient(point2);
				bar_0.method_58(new MouseEventArgs(objArg.get_Button(), objArg.get_Clicks(), point2.X, point2.Y, objArg.get_Delta()));
			}
		}
	}

	protected override void OnSubItemGotFocus(BaseItem objItem)
	{
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is PopupItem popupItem && popupItem.Expanded && objItem != subItem)
			{
				popupItem.Expanded = false;
			}
		}
		base.OnSubItemGotFocus(objItem);
	}

	public override void ContainerLostFocus(bool appLostFocus)
	{
		base.ContainerLostFocus(appLostFocus);
		if (Expanded)
		{
			Expanded = false;
			if (m_Parent != null)
			{
				m_Parent.AutoExpand = false;
			}
		}
	}

	public override void SubItemSizeChanged(BaseItem objChildItem)
	{
		if (menuPanel_0 != null)
		{
			menuPanel_0.RecalcSize();
		}
		else if (bar_0 != null)
		{
			bar_0.RecalcLayout();
		}
	}

	protected internal override void OnExpandChange()
	{
		base.OnExpandChange();
		if (!Expanded)
		{
			point_2 = Point.Empty;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (!BaseItem.IsOnPopup(this) || Parent == null)
		{
			if (GetOwner() is IOwner owner && Name != "syscustomizepopupmenu")
			{
				if (Expanded)
				{
					owner.SetExpandedItem(this);
				}
				else if (owner.GetExpandedItem() == this)
				{
					owner.SetExpandedItem(null);
				}
				IOwner owner2 = null;
			}
			if (val is Bar && !DesignMode)
			{
				if (Expanded)
				{
					bool_23 = false;
					if (val.get_Focused())
					{
						bool_23 = true;
					}
					else if (val is Bar)
					{
						Bar bar = val as Bar;
						if (bar.BarState != eBarState.Floating || bar.MenuBar)
						{
							bar.Boolean_11 = true;
						}
					}
					else
					{
						val.Focus();
					}
				}
				else
				{
					if (!bool_23)
					{
						((Bar)(object)val).ReleaseFocus();
					}
					Bar bar2 = val as Bar;
					if (bar2.BarState != eBarState.Floating && !bar2.MenuBar)
					{
						bar2.Boolean_11 = false;
					}
					bool_23 = false;
				}
			}
			else if (val is ItemControl && !DesignMode)
			{
				if (Expanded)
				{
					bool_23 = false;
					if (val.get_Focused())
					{
						bool_23 = true;
					}
					else
					{
						ItemControl itemControl = val as ItemControl;
						itemControl.Boolean_3 = true;
					}
				}
				else
				{
					if (!bool_23)
					{
						((ItemControl)(object)val).ReleaseFocus();
					}
					((ItemControl)(object)val).Boolean_3 = false;
					bool_23 = false;
				}
			}
		}
		if (!Expanded && (menuPanel_0 != null || bar_0 != null || popupContainerControl_0 != null))
		{
			ClosePopup();
		}
		if (val == null)
		{
			return;
		}
		if (BaseItem.IsHandleValid(val))
		{
			Refresh();
		}
		if (Expanded && menuPanel_0 == null && bar_0 == null && popupContainerControl_0 == null && BaseItem.IsHandleValid(val))
		{
			if (ePopupType_0 == ePopupType.Menu)
			{
				Point point = ((!point_2.IsEmpty) ? point_2 : ((ePopupSide_0 != 0) ? method_17() : ((!(Parent is CustomizeItem) && !(this is CustomizeItem)) ? (base.IsOnMenu ? ((!Boolean_3) ? new Point(m_Rect.Right, m_Rect.Top - 2) : new Point(m_Rect.Left + 2, m_Rect.Top - 2)) : ((m_Orientation != 0) ? new Point(m_Rect.Right, m_Rect.Top) : ((!Boolean_3) ? new Point(m_Rect.Left, m_Rect.Bottom) : new Point(m_Rect.Right, m_Rect.Bottom)))) : ((!Boolean_3) ? new Point(m_Rect.Right - 2, m_Rect.Top - 2) : new Point(m_Rect.Left + 3, m_Rect.Top)))));
				Point p = val.PointToScreen(point);
				PopupMenu(p);
			}
			else if (ePopupType_0 == ePopupType.ToolBar)
			{
				Point point2 = ((!point_2.IsEmpty) ? point_2 : ((ePopupSide_0 != 0) ? method_17() : (base.IsOnMenu ? ((!Boolean_3) ? new Point(m_Rect.Right, m_Rect.Top - 2) : new Point(m_Rect.Left + 2, m_Rect.Top - 2)) : ((m_Orientation != 0) ? new Point(m_Rect.Right, m_Rect.Top) : ((!Boolean_3) ? new Point(m_Rect.Left, m_Rect.Bottom) : new Point(m_Rect.Right, m_Rect.Bottom))))));
				Point p2 = val.PointToScreen(point2);
				PopupBar(p2);
			}
			else if (ePopupType_0 == ePopupType.Container)
			{
				Point point3 = ((!point_2.IsEmpty) ? point_2 : ((ePopupSide_0 != 0) ? method_17() : (base.IsOnMenu ? ((!Boolean_3) ? new Point(m_Rect.Right, m_Rect.Top - 2) : new Point(m_Rect.Left + 2, m_Rect.Top - 2)) : ((m_Orientation != 0) ? new Point(m_Rect.Right, m_Rect.Top) : ((!Boolean_3) ? new Point(m_Rect.Left, m_Rect.Bottom) : new Point(m_Rect.Right, m_Rect.Bottom))))));
				Point p3 = val.PointToScreen(point3);
				PopupContainer(p3);
			}
		}
		val = null;
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
			if (subItem.Expanded && subItem != objItem)
			{
				subItem.Expanded = false;
			}
		}
	}

	public void PopupMenu(Point p)
	{
		PopupMenu(p.X, p.Y);
	}

	protected internal IOwnerMenuSupport GetIOwnerMenuSupport()
	{
		return GetOwner() as IOwnerMenuSupport;
	}

	protected virtual void OnPopupOpen(PopupOpenEventArgs e)
	{
		if (popupOpenEventHandler_0 != null)
		{
			popupOpenEventHandler_0(this, e);
		}
		if (!e.Cancel)
		{
			GetIOwnerMenuSupport()?.InvokePopupOpen(this, e);
		}
	}

	public virtual void PopupMenu(int x, int y)
	{
		PopupMenu(x, y, verifyScreenPosition: true);
	}

	public virtual void PopupMenu(int x, int y, bool verifyScreenPosition)
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		Boolean_8 = false;
		IOwnerMenuSupport iOwnerMenuSupport = GetIOwnerMenuSupport();
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (iOwnerMenuSupport != null)
		{
			PopupOpenEventArgs popupOpenEventArgs = new PopupOpenEventArgs();
			OnPopupOpen(popupOpenEventArgs);
			if (popupOpenEventArgs.Cancel)
			{
				Expanded = false;
				return;
			}
		}
		if (SubItemsImageSize.Width == ImageItem.size_2.Width && SubItemsImageSize.Height == ImageItem.size_2.Height)
		{
			size_3 = SubItemsImageSize;
			SubItemsImageSize = new Size(16, 16);
		}
		foreach (BaseItem subItem in SubItems)
		{
			subItem.Orientation = eOrientation.Horizontal;
		}
		if (menuPanel_0 == null)
		{
			menuPanel_0 = new MenuPanel();
			menuPanel_0.Owner = GetOwner();
			menuPanel_0.bool_11 = !verifyScreenPosition;
			if (font_0 != null)
			{
				((Control)menuPanel_0).set_Font(font_0);
			}
			else if (val != null && val.get_Font() != null)
			{
				((Control)menuPanel_0).set_Font((Font)val.get_Font().Clone());
			}
			if (iOwnerMenuSupport != null && iOwnerMenuSupport.AlwaysShowFullMenus)
			{
				menuPanel_0.PersonalizedMenus = ePersonalizedMenus.Disabled;
			}
			else
			{
				menuPanel_0.PersonalizedMenus = ePersonalizedMenus_0;
			}
			if (iOwnerMenuSupport != null && !iOwnerMenuSupport.ShowFullMenusOnHover && (menuPanel_0.PersonalizedMenus == ePersonalizedMenus.DisplayOnHover || menuPanel_0.PersonalizedMenus == ePersonalizedMenus.Both))
			{
				menuPanel_0.PersonalizedMenus = ePersonalizedMenus.DisplayOnClick;
			}
			menuPanel_0.PopupAnimation = ePopupAnimation_0;
			if (iOwnerMenuSupport != null && (IsOnMenuBar || base.IsOnMenu))
			{
				menuPanel_0.PersonalizedAllVisible = iOwnerMenuSupport.PersonalizedAllVisible;
			}
			if (Parent is CustomizeItem || (this is CustomizeItem && !(this is QatCustomizeItem)))
			{
				menuPanel_0.Boolean_6 = true;
			}
			if (val is Bar)
			{
				Bar bar = (Bar)(object)val;
				menuPanel_0.ColorScheme = bar.GetColorScheme();
				menuPanel_0.ShowToolTips = bar.ShowToolTips;
				menuPanel_0.AntiAlias = bar.AntiAlias;
				if (val is ContextMenuBar)
				{
					menuPanel_0.bool_11 = true;
				}
			}
			else if (val is MenuPanel)
			{
				MenuPanel menuPanel = (MenuPanel)(object)val;
				menuPanel_0.ColorScheme = menuPanel.ColorScheme;
				menuPanel_0.ShowToolTips = menuPanel.ShowToolTips;
				menuPanel_0.AntiAlias = menuPanel.AntiAlias;
			}
			else if (val is SideBar)
			{
				menuPanel_0.ColorScheme = ((SideBar)(object)val).ColorScheme;
			}
			else if (val is ExplorerBar)
			{
				ExplorerBar explorerBar = val as ExplorerBar;
				menuPanel_0.ColorScheme = explorerBar.ColorScheme;
				menuPanel_0.AntiAlias = explorerBar.AntiAlias;
			}
			else if (val is BarBaseControl)
			{
				menuPanel_0.ColorScheme = ((BarBaseControl)(object)val).ColorScheme;
			}
			else if (val is ItemControl)
			{
				ItemControl itemControl = (ItemControl)(object)val;
				menuPanel_0.ColorScheme = itemControl.ColorScheme;
				menuPanel_0.AntiAlias = itemControl.AntiAlias;
			}
			else if (val is PopupItemControl)
			{
				PopupItemControl popupItemControl = (PopupItemControl)(object)val;
				menuPanel_0.ColorScheme = popupItemControl.GetColorScheme();
				menuPanel_0.AntiAlias = popupItemControl.AntiAlias;
			}
			else
			{
				menuPanel_0.ColorScheme = new ColorScheme(Style);
				object owner = GetOwner();
				if (owner is ItemControl)
				{
					menuPanel_0.AntiAlias = ((ItemControl)owner).AntiAlias;
				}
				else if (owner is Bar)
				{
					menuPanel_0.AntiAlias = ((Bar)owner).AntiAlias;
				}
			}
			if (val != null)
			{
				((Control)menuPanel_0).set_RightToLeft(val.get_RightToLeft());
			}
			menuPanel_0.SideBar = m_SideBar;
			menuPanel_0.ParentItem = this;
			((Control)menuPanel_0).CreateControl();
			menuPanel_0.RecalcSize();
		}
		Class273 @class = Class109.smethod_52(new Point(x, y));
		if (@class == null && BaseItem.IsHandleValid(val))
		{
			@class = Class109.smethod_53(val);
		}
		Rectangle rectangle = @class.rectangle_1;
		if (Parent == null)
		{
			rectangle = @class.rectangle_0;
		}
		if (Boolean_3)
		{
			x -= ((Control)menuPanel_0).get_Width();
			if (@class != null && x < rectangle.Left && verifyScreenPosition)
			{
				Boolean_8 = true;
				if (Displayed && val != null && (menuPanel_0.Boolean_6 || base.IsOnMenu))
				{
					Point point = ((!menuPanel_0.Boolean_6) ? new Point(m_Rect.Right, m_Rect.Top) : new Point(m_Rect.Right, m_Rect.Bottom));
					x = val.PointToScreen(point).X;
					if (x + ((Control)menuPanel_0).get_Width() > rectangle.Right)
					{
						x = rectangle.Right - ((Control)menuPanel_0).get_Width();
					}
				}
				else
				{
					x = rectangle.Left;
				}
			}
		}
		else if (@class != null && (x + ((Control)menuPanel_0).get_Width() > rectangle.Right || x < rectangle.Left) && verifyScreenPosition)
		{
			Boolean_8 = true;
			if (x + ((Control)menuPanel_0).get_Width() > rectangle.Right)
			{
				if (Displayed && val != null && !(val is ContextMenuBar))
				{
					Point point2 = (menuPanel_0.Boolean_6 ? new Point(m_Rect.Left, m_Rect.Bottom) : ((!base.IsOnMenu) ? new Point(m_Rect.Right, m_Rect.Top) : new Point(m_Rect.Left, m_Rect.Top)));
					x = val.PointToScreen(point2).X - ((Control)menuPanel_0).get_Width();
					if (x + ((Control)menuPanel_0).get_Width() > rectangle.Right)
					{
						x = rectangle.Right - ((Control)menuPanel_0).get_Width();
					}
				}
				else
				{
					x = rectangle.Right - ((Control)menuPanel_0).get_Width();
				}
			}
			else if (x < rectangle.Left)
			{
				x = rectangle.Left;
			}
		}
		if (@class != null && verifyScreenPosition && y + ((Control)menuPanel_0).get_Height() > rectangle.Bottom)
		{
			if (Displayed && val != null && val.get_Visible())
			{
				Point point3 = new Point(m_Rect.Left, m_Rect.Bottom - 1);
				Point point4 = val.PointToScreen(point3);
				point4.Y += 2;
				if (point4.Y - ((Control)menuPanel_0).get_Height() >= rectangle.Top)
				{
					y = Math.Min(rectangle.Bottom, point4.Y) - ((Control)menuPanel_0).get_Height();
				}
				else if (this is Office2007StartButton)
				{
					y = rectangle.Bottom - ((Control)menuPanel_0).get_Height() - 4;
				}
			}
			else
			{
				y = rectangle.Bottom - ((Control)menuPanel_0).get_Height();
			}
			if (y < rectangle.Top)
			{
				y = rectangle.Top;
			}
			Boolean_8 = true;
		}
		((Control)menuPanel_0).set_Location(new Point(x, y));
		if (iOwnerMenuSupport != null)
		{
			if (eventHandler_18 != null)
			{
				eventHandler_18(this, new EventArgs());
			}
			iOwnerMenuSupport.InvokePopupShowing(this, new EventArgs());
		}
		menuPanel_0.Show();
		if (ContainerControl is IKeyTipsControl)
		{
			IKeyTipsControl keyTipsControl = ContainerControl as IKeyTipsControl;
			menuPanel_0.ShowKeyTips = keyTipsControl.ShowKeyTips;
			keyTipsControl.ShowKeyTips = false;
		}
		Expanded = true;
		if (iOwnerMenuSupport == null)
		{
			return;
		}
		if (!(val is Bar) && !(val is MenuPanel))
		{
			iOwnerMenuSupport.RegisterPopup(this);
			bool_22 = true;
		}
		else if (val is Bar)
		{
			Bar bar2 = val as Bar;
			if (bar2.BarState != 0)
			{
				iOwnerMenuSupport.RegisterPopup(this);
				bool_22 = true;
			}
			bar2 = null;
		}
	}

	public void PopupBar(Point p)
	{
		PopupBar(p.X, p.Y);
	}

	public virtual void PopupBar(int x, int y)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		IOwnerMenuSupport iOwnerMenuSupport = GetIOwnerMenuSupport();
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (iOwnerMenuSupport != null)
		{
			PopupOpenEventArgs popupOpenEventArgs = new PopupOpenEventArgs();
			if (popupOpenEventHandler_0 != null)
			{
				popupOpenEventHandler_0(this, popupOpenEventArgs);
			}
			if (!popupOpenEventArgs.Cancel)
			{
				iOwnerMenuSupport.InvokePopupOpen(this, popupOpenEventArgs);
			}
			if (popupOpenEventArgs.Cancel)
			{
				Expanded = false;
				return;
			}
		}
		foreach (BaseItem subItem in SubItems)
		{
			subItem.Orientation = eOrientation.Horizontal;
		}
		if (bar_0 == null)
		{
			bar_0 = new Bar();
			if (font_0 != null)
			{
				((Control)bar_0).set_Font(font_0);
			}
			else if (val != null && val.get_Font() != null)
			{
				((Control)bar_0).set_Font((Font)val.get_Font().Clone());
			}
			if (val is Bar && ((Bar)(object)val).ColorScheme != null)
			{
				bar_0.ColorScheme = ((Bar)(object)val).ColorScheme;
			}
			else if (val is MenuPanel && ((MenuPanel)(object)val).ColorScheme != null)
			{
				bar_0.ColorScheme = ((MenuPanel)(object)val).ColorScheme;
			}
			else if (val is ItemControl && ((ItemControl)(object)val).ColorScheme != null)
			{
				bar_0.ColorScheme = ((ItemControl)(object)val).ColorScheme;
			}
			else if (val is ButtonX && ((ButtonX)(object)val).ColorScheme != null)
			{
				bar_0.ColorScheme = ((ButtonX)(object)val).ColorScheme;
			}
			else
			{
				bar_0.ColorScheme = new ColorScheme(Style);
			}
			bar_0.method_88(eBarState.Popup);
			bar_0.PopupAnimation = ePopupAnimation_0;
			bar_0.Owner = GetOwner();
			bar_0.ParentItem = this;
			if (val != null)
			{
				((Control)bar_0).set_RightToLeft(val.get_RightToLeft());
			}
			((Control)bar_0).CreateControl();
			bar_0.SetDesignMode(DesignMode);
			bar_0.ThemeAware = ThemeAware;
			if (val is IBarImageSize)
			{
				bar_0.ImageSize = ((IBarImageSize)val).ImageSize;
			}
			bar_0.Int32_7 = int_4;
			bar_0.RecalcSize();
		}
		Class273 @class = null;
		@class = ((!BaseItem.IsHandleValid(val)) ? Class109.smethod_52(new Point(x, y)) : Class109.smethod_53(val));
		if (Boolean_3)
		{
			x -= ((Control)bar_0).get_Width();
		}
		if (@class != null && x + ((Control)bar_0).get_Width() > @class.rectangle_1.Right)
		{
			x = @class.rectangle_1.Right - ((Control)bar_0).get_Width();
		}
		else if (@class != null && x < @class.rectangle_1.Left)
		{
			x = @class.rectangle_1.Left;
		}
		if (@class != null && y + ((Control)bar_0).get_Height() > @class.rectangle_1.Bottom && Displayed && val != null)
		{
			Point point = new Point(m_Rect.Left, m_Rect.Bottom);
			Point point2 = val.PointToScreen(point);
			point2.Y += 2;
			if (point2.Y - ((Control)bar_0).get_Height() >= @class.rectangle_1.Top)
			{
				y = point2.Y - ((Control)bar_0).get_Height();
			}
		}
		bar_0.Location = new Point(x, y);
		iOwnerMenuSupport?.InvokePopupShowing(this, new EventArgs());
		bar_0.method_97();
		Expanded = true;
		if (iOwnerMenuSupport == null)
		{
			return;
		}
		if (!(val is Bar) && !(val is MenuPanel))
		{
			iOwnerMenuSupport.RegisterPopup(this);
			bool_22 = true;
		}
		else if (val is Bar)
		{
			Bar bar = val as Bar;
			if (bar.BarState != 0)
			{
				iOwnerMenuSupport.RegisterPopup(this);
				bool_22 = true;
			}
			bar = null;
		}
	}

	public void PopupContainer(Point p)
	{
		PopupContainer(p.X, p.Y);
	}

	public virtual void CreatePopupContainer(bool fireLoadEvents)
	{
		if (PopupType != ePopupType.Container)
		{
			throw new InvalidOperationException("Method can only be called for PopupType set to ePopupType.Container");
		}
		if (popupContainerControl_0 != null)
		{
			return;
		}
		popupContainerControl_0 = new PopupContainerControl();
		popupContainerControl_0.Owner = GetOwner();
		popupContainerControl_0.ParentItem = this;
		((Control)popupContainerControl_0).CreateControl();
		popupContainerControl_0.method_0(DesignMode);
		((Control)popupContainerControl_0).set_Width(int_4);
		if (fireLoadEvents)
		{
			IOwnerMenuSupport iOwnerMenuSupport = GetIOwnerMenuSupport();
			if (eventHandler_14 != null)
			{
				eventHandler_14(this, new EventArgs());
			}
			iOwnerMenuSupport?.InvokePopupContainerLoad(this, new EventArgs());
			popupContainerControl_0.RecalcSize();
		}
	}

	public virtual void PopupContainer(int x, int y)
	{
		IOwnerMenuSupport iOwnerMenuSupport = GetIOwnerMenuSupport();
		if (iOwnerMenuSupport == null)
		{
			throw new InvalidOperationException("Current owner is not assigned or it does not have popup bar support.");
		}
		CreatePopupContainer(fireLoadEvents: true);
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		Class273 @class = null;
		@class = ((!BaseItem.IsHandleValid(val)) ? Class109.smethod_52(new Point(x, y)) : Class109.smethod_53(val));
		if (Boolean_3)
		{
			x -= ((Control)popupContainerControl_0).get_Width();
		}
		if (@class != null && x + ((Control)popupContainerControl_0).get_Width() > @class.rectangle_1.Right)
		{
			x = @class.rectangle_1.Right - ((Control)popupContainerControl_0).get_Width();
		}
		else if (@class != null && x < @class.rectangle_1.Left)
		{
			x = @class.rectangle_1.Left;
		}
		if (@class != null && y + ((Control)popupContainerControl_0).get_Height() > @class.rectangle_1.Bottom && Displayed && val != null)
		{
			Point point = new Point(m_Rect.Left, m_Rect.Top);
			Point point2 = val.PointToScreen(point);
			point2.Y += 2;
			if (point2.Y - ((Control)popupContainerControl_0).get_Height() >= @class.rectangle_1.Top)
			{
				y = point2.Y - ((Control)popupContainerControl_0).get_Height();
			}
		}
		((Control)popupContainerControl_0).set_Location(new Point(x, y));
		iOwnerMenuSupport?.InvokePopupShowing(this, new EventArgs());
		popupContainerControl_0.Show();
		Expanded = true;
		if (iOwnerMenuSupport == null)
		{
			return;
		}
		if (!(val is Bar) && !(val is MenuPanel))
		{
			iOwnerMenuSupport.RegisterPopup(this);
			bool_22 = true;
		}
		else if (val is Bar)
		{
			Bar bar = val as Bar;
			if (bar.BarState != 0)
			{
				iOwnerMenuSupport.RegisterPopup(this);
				bool_22 = true;
			}
			bar = null;
		}
	}

	public virtual void Popup(Point p)
	{
		Popup(p.X, p.Y);
	}

	public virtual void Popup(int x, int y)
	{
		if (bar_0 != null || menuPanel_0 != null || popupContainerControl_0 != null)
		{
			ClosePopup();
		}
		switch (ePopupType_0)
		{
		case ePopupType.Menu:
			PopupMenu(x, y);
			break;
		case ePopupType.ToolBar:
			PopupBar(x, y);
			break;
		case ePopupType.Container:
			PopupContainer(x, y);
			break;
		}
	}

	public virtual void ClosePopup()
	{
		if (size_3 != Size.Empty)
		{
			SubItemsImageSize = size_3;
			size_3 = Size.Empty;
		}
		IOwnerMenuSupport iOwnerMenuSupport = GetIOwnerMenuSupport();
		iOwnerMenuSupport?.UnregisterPopup(this);
		bool_22 = false;
		if (popupContainerControl_0 != null)
		{
			if (eventHandler_15 != null)
			{
				eventHandler_15(this, new EventArgs());
			}
			iOwnerMenuSupport?.InvokePopupContainerUnload(this, new EventArgs());
		}
		if ((bar_0 != null || menuPanel_0 != null || popupContainerControl_0 != null) && iOwnerMenuSupport != null)
		{
			if (eventHandler_16 != null)
			{
				eventHandler_16(this, new EventArgs());
			}
			iOwnerMenuSupport.InvokePopupClose(this, new EventArgs());
		}
		if (menuPanel_0 != null)
		{
			if (ContainerControl is IKeyTipsControl)
			{
				IKeyTipsControl keyTipsControl = ContainerControl as IKeyTipsControl;
				keyTipsControl.ShowKeyTips = menuPanel_0.ShowKeyTips;
				menuPanel_0.ShowKeyTips = false;
			}
			menuPanel_0.method_15(null);
			menuPanel_0.Hide();
			((Component)(object)menuPanel_0).Dispose();
			menuPanel_0 = null;
		}
		if (bar_0 != null)
		{
			bar_0.Hide();
			((Component)(object)bar_0).Dispose();
			bar_0 = null;
		}
		if (popupContainerControl_0 != null)
		{
			((Control)popupContainerControl_0).Hide();
			((Component)(object)popupContainerControl_0).Dispose();
			popupContainerControl_0 = null;
		}
		Expanded = false;
		if (GetOwner() is IOwner owner && owner.ParentForm != null)
		{
			((Control)owner.ParentForm).Update();
		}
		if (eventHandler_17 != null)
		{
			eventHandler_17(this, new EventArgs());
		}
	}

	private Point method_17()
	{
		Point empty = Point.Empty;
		if (Parent == null && !(ContainerControl is ButtonX))
		{
			return empty;
		}
		if (ePopupSide_0 == ePopupSide.Right)
		{
			empty.X = m_Rect.Right;
			empty.Y = m_Rect.Top;
		}
		else if (ePopupSide_0 == ePopupSide.Left)
		{
			Size popupSize = PopupSize;
			empty.X = m_Rect.Left - popupSize.Width;
			empty.Y = m_Rect.Top;
		}
		else if (ePopupSide_0 == ePopupSide.Top)
		{
			Size popupSize2 = PopupSize;
			empty.Y = m_Rect.Top - popupSize2.Height;
			if (popupSize2.Width > m_Rect.Width)
			{
				empty.X = m_Rect.Left;
			}
			else
			{
				empty.X = m_Rect.Right - popupSize2.Width;
			}
		}
		else if (ePopupSide_0 == ePopupSide.Bottom)
		{
			Size popupSize3 = PopupSize;
			empty.Y = m_Rect.Bottom;
			if (popupSize3.Width > m_Rect.Width)
			{
				empty.X = m_Rect.Left;
			}
			else
			{
				empty.X = m_Rect.Right - popupSize3.Width;
			}
		}
		return empty;
	}

	protected internal override void OnBeforeItemRemoved(BaseItem objItem)
	{
		base.OnBeforeItemRemoved(objItem);
		if (bar_0 != null && objItem != null)
		{
			bar_0.Items.Remove(objItem);
		}
	}

	protected internal override void OnAfterItemRemoved(BaseItem objItem)
	{
		base.OnAfterItemRemoved(objItem);
		if (Expanded && objItem == null)
		{
			Expanded = false;
		}
		if (menuPanel_0 != null && !SuspendLayout)
		{
			menuPanel_0.RecalcSize();
		}
		else if (bar_0 != null && !SuspendLayout)
		{
			bar_0.RecalcLayout();
		}
	}

	protected internal override bool IsAnyOnHandle(int iHandle)
	{
		bool result;
		if (!(result = base.IsAnyOnHandle(iHandle)) && popupContainerControl_0 != null && ((Control)popupContainerControl_0).get_Handle().ToInt32() == iHandle)
		{
			result = true;
		}
		return result;
	}

	public InsertPosition GetInsertPosition(Point pScreen, BaseItem DragItem)
	{
		if (!Expanded)
		{
			return null;
		}
		if (menuPanel_0 != null)
		{
			return menuPanel_0.GetInsertPosition(pScreen, DragItem);
		}
		if (bar_0 != null)
		{
			return ((IDesignTimeProvider)bar_0.ItemsContainer).GetInsertPosition(pScreen, DragItem);
		}
		return null;
	}

	public void DrawReversibleMarker(int iPos, bool Before)
	{
		if (Expanded)
		{
			if (menuPanel_0 != null)
			{
				menuPanel_0.DrawReversibleMarker(iPos, Before);
			}
			else if (bar_0 != null)
			{
				((IDesignTimeProvider)bar_0.Items).DrawReversibleMarker(iPos, Before);
			}
		}
	}

	public void InsertItemAt(BaseItem objItem, int iPos, bool Before)
	{
		if (Expanded)
		{
			if (menuPanel_0 != null)
			{
				menuPanel_0.InsertItemAt(objItem, iPos, Before);
			}
			else
			{
				((IDesignTimeProvider)bar_0.Items).InsertItemAt(objItem, iPos, Before);
			}
		}
	}

	public void SetSourceControl(Control ctrl)
	{
		control_0 = ctrl;
	}

	protected override void OnDisplayedChanged()
	{
		if (!Displayed && Expanded)
		{
			Expanded = false;
		}
	}
}

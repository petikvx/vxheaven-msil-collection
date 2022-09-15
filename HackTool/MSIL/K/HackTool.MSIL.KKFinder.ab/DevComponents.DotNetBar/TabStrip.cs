using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[Designer(typeof(TabStripDesigner))]
[ComVisible(false)]
public class TabStrip : Control
{
	public delegate void SelectedTabChangedEventHandler(object sender, TabStripTabChangedEventArgs e);

	public delegate void SelectedTabChangingEventHandler(object sender, TabStripTabChangingEventArgs e);

	public delegate void TabMovedEventHandler(object sender, TabStripTabMovedEventArgs e);

	public delegate void UserActionEventHandler(object sender, TabStripActionEventArgs e);

	private SelectedTabChangedEventHandler selectedTabChangedEventHandler_0;

	private SelectedTabChangingEventHandler selectedTabChangingEventHandler_0;

	private TabMovedEventHandler tabMovedEventHandler_0;

	private UserActionEventHandler userActionEventHandler_0;

	private UserActionEventHandler userActionEventHandler_1;

	private UserActionEventHandler userActionEventHandler_2;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private EventHandler eventHandler_3;

	private EventHandler eventHandler_4;

	private MeasureTabItemEventHandler measureTabItemEventHandler_0;

	private RenderTabItemEventHandler renderTabItemEventHandler_0;

	private RenderTabItemEventHandler renderTabItemEventHandler_1;

	private eTabStripAlignment eTabStripAlignment_0 = eTabStripAlignment.Bottom;

	private TabsCollection tabsCollection_0;

	private ImageList imageList_0;

	private TabItem tabItem_0;

	private bool bool_0 = true;

	private bool bool_1;

	private Bar bar_0;

	private bool bool_2;

	private bool bool_3 = true;

	private bool bool_4 = true;

	private int int_0;

	private Class26 class26_0;

	private bool bool_5 = true;

	private bool bool_6;

	private Form form_0;

	private bool bool_7;

	private int int_1 = 32;

	private bool bool_8 = true;

	private bool bool_9 = true;

	private bool bool_10 = true;

	private Font font_0;

	private bool bool_11;

	private bool bool_12;

	private Class59 class59_0;

	private TabItem tabItem_1;

	private eTabStripStyle eTabStripStyle_0;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private Color color_2 = Color.Empty;

	private Color color_3 = Color.Empty;

	private bool bool_13;

	private int int_2 = 300;

	private TabColorScheme tabColorScheme_0;

	private TabItem tabItem_2;

	private bool bool_14 = true;

	private bool bool_15;

	private int int_3 = 4;

	private int int_4;

	private eTabLayoutType eTabLayoutType_0;

	private ToolTip toolTip_0;

	private TabItem tabItem_3;

	private bool bool_16;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Size size_0 = Size.Empty;

	private bool bool_17;

	private eTabCloseButtonPosition eTabCloseButtonPosition_0;

	private static Size size_1 = new Size(11, 11);

	private Size size_2 = size_1;

	private Image image_0;

	private Image image_1;

	private bool bool_18 = true;

	private bool bool_19;

	private bool bool_20 = true;

	private int int_5 = -1;

	private bool bool_21 = true;

	private Point point_0 = Point.Empty;

	private bool bool_22;

	private Cursor cursor_0;

	private Cursor cursor_1;

	internal bool bool_23;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Appearance")]
	public bool AntiAlias
	{
		get
		{
			return bool_19;
		}
		set
		{
			if (bool_19 != value)
			{
				bool_19 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[Browsable(false)]
	public int MinTabStripHeight
	{
		get
		{
			if (eTabStripStyle_0 != eTabStripStyle.SimulatedTheme && eTabStripStyle_0 != eTabStripStyle.Office2007Document && eTabStripStyle_0 != eTabStripStyle.Office2007Dock)
			{
				if (eTabStripStyle_0 != eTabStripStyle.OneNote && eTabStripStyle_0 != eTabStripStyle.VS2005Document)
				{
					return Int32_0 + 5;
				}
				return Int32_0 + 6;
			}
			if (rectangle_0.IsEmpty || bool_0)
			{
				if (Tabs.Count == 0 || !bool_0)
				{
					return Int32_0 + 6;
				}
				RecalcSize();
			}
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				return rectangle_0.Width + 3;
			}
			return rectangle_0.Height + 3;
		}
	}

	private int Int32_0
	{
		get
		{
			if (int_5 <= 0)
			{
				Graphics val = null;
				if (Class109.smethod_11((Control)(object)this))
				{
					val = ((Control)this).CreateGraphics();
				}
				else
				{
					try
					{
						val = Graphics.FromHwnd(IntPtr.Zero);
					}
					catch
					{
					}
				}
				if (val != null)
				{
					try
					{
						int_5 = method_14(val);
					}
					finally
					{
						val.Dispose();
					}
				}
			}
			return int_5;
		}
	}

	private bool Boolean_0
	{
		get
		{
			if ((eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right) && Style != eTabStripStyle.SimulatedTheme)
			{
				return true;
			}
			return false;
		}
	}

	internal Rectangle Rectangle_0 => rectangle_0;

	private bool Boolean_1 => (int)((Control)this).get_RightToLeft() == 1;

	private bool Boolean_2
	{
		get
		{
			if (((Style != eTabStripStyle.RoundHeader && Style != eTabStripStyle.VS2005Dock) || Boolean_13) && Style != eTabStripStyle.SimulatedTheme && Style != eTabStripStyle.Office2007Document && Style != eTabStripStyle.Office2007Dock)
			{
				return false;
			}
			return true;
		}
	}

	internal bool Boolean_3 => measureTabItemEventHandler_0 != null;

	internal bool Boolean_4 => renderTabItemEventHandler_0 != null;

	internal bool Boolean_5 => renderTabItemEventHandler_1 != null;

	internal TabItem TabItem_0
	{
		get
		{
			return tabItem_2;
		}
		set
		{
			tabItem_2 = value;
			((Control)this).Invalidate();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public int SelectedTabIndex
	{
		get
		{
			if (tabItem_0 == null)
			{
				return -1;
			}
			return tabsCollection_0.IndexOf(tabItem_0);
		}
		set
		{
			if (value >= 0 && value < tabsCollection_0.Count && tabsCollection_0.Count != 0)
			{
				SelectedTab = tabsCollection_0[value];
			}
		}
	}

	[Description("Indicates selected tab.")]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Browsable(true)]
	public TabItem SelectedTab
	{
		get
		{
			if (tabItem_0 == null && tabsCollection_0.Count > 0)
			{
				tabItem_0 = tabsCollection_0[0];
			}
			return tabItem_0;
		}
		set
		{
			method_28(value, eEventSource.Code);
		}
	}

	[Category("Behavior")]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	[Description("Indicates whether tabs are scrolled continuously while mouse is pressed over the scroll tab button.")]
	[Browsable(true)]
	public virtual bool TabScrollAutoRepeat
	{
		get
		{
			return bool_13;
		}
		set
		{
			bool_13 = value;
		}
	}

	[Description("Indicates auto-repeat interval for the tab scrolling while mouse button is kept pressed over the scroll tab button.")]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	[DefaultValue(300)]
	[Browsable(true)]
	public virtual int TabScrollRepeatInterval
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	[Description("Indicates whether the Close button that closes the active tab is visible.")]
	[Category("Close Button")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public bool CloseButtonVisible
	{
		get
		{
			if (class26_0 != null)
			{
				return class26_0.Boolean_0;
			}
			return true;
		}
		set
		{
			if (class26_0 != null)
			{
				class26_0.Boolean_0 = value;
			}
			((Control)this).Invalidate();
		}
	}

	[Category("Close Button")]
	[DefaultValue(false)]
	[Description("Indicates whether close button is visible on each tab instead of in system box.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public bool CloseButtonOnTabsVisible
	{
		get
		{
			return bool_17;
		}
		set
		{
			bool_17 = value;
			bool_0 = true;
			((Control)this).Invalidate();
		}
	}

	[DevCoBrowsable(true)]
	[Category("Close Button")]
	[Browsable(true)]
	[Description("Indicates whether close button on tabs when visible is displayed for every tab state.")]
	[DefaultValue(true)]
	public bool CloseButtonOnTabsAlwaysDisplayed
	{
		get
		{
			return bool_18;
		}
		set
		{
			bool_18 = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates position of the close button displayed on each tab.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Close Button")]
	[DefaultValue(eTabCloseButtonPosition.Left)]
	public eTabCloseButtonPosition CloseButtonPosition
	{
		get
		{
			return eTabCloseButtonPosition_0;
		}
		set
		{
			eTabCloseButtonPosition_0 = value;
			bool_0 = true;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates custom image that is used on tabs as Close button that allows user to close the tab.")]
	[Category("Close Button")]
	[Browsable(true)]
	[DefaultValue(null)]
	public Image TabCloseButtonNormal
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			if (image_0 != null)
			{
				size_2 = image_0.get_Size();
			}
			else
			{
				size_2 = size_1;
			}
			bool_0 = true;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(null)]
	[Browsable(true)]
	[Description("Indicates custom image that is used on tabs as Close button whem mouse is over the close button.")]
	[Category("Close Button")]
	public Image TabCloseButtonHot
	{
		get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Returns the collection of Tabs.")]
	[Editor(typeof(TabStripTabsEditor), typeof(UITypeEditor))]
	[Category("Data")]
	public TabsCollection Tabs => tabsCollection_0;

	[Browsable(false)]
	public bool AutoSelectAttachedControl
	{
		get
		{
			return bool_20;
		}
		set
		{
			bool_20 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(null)]
	public ImageList ImageList
	{
		get
		{
			return imageList_0;
		}
		set
		{
			imageList_0 = value;
		}
	}

	[DefaultValue(eTabLayoutType.FitContainer)]
	[Browsable(true)]
	[Description("Indicates the type of the tab layout.")]
	[Category("Appearance")]
	public eTabLayoutType TabLayoutType
	{
		get
		{
			return eTabLayoutType_0;
		}
		set
		{
			eTabLayoutType_0 = value;
			bool_0 = true;
			class26_0.rectangle_0 = Rectangle.Empty;
			method_42();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Obsolete("Please use TabLayoutType property instead.", true)]
	[DevCoBrowsable(false)]
	public bool VariableTabWidth
	{
		get
		{
			return bool_4;
		}
		set
		{
			if (value)
			{
				eTabLayoutType_0 = eTabLayoutType.FitContainer;
			}
			else
			{
				eTabLayoutType_0 = eTabLayoutType.FixedWithNavigationBox;
			}
		}
	}

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(0)]
	public int ScrollOffset
	{
		get
		{
			return int_0;
		}
		set
		{
			if (int_0 != value)
			{
				int_0 = value;
				bool_0 = true;
				((Control)this).Invalidate();
			}
		}
	}

	internal bool Boolean_6
	{
		get
		{
			if (((Control)this).get_Parent() != null && ((Control)this).get_Parent() is TabControl && ((Component)(object)((Control)this).get_Parent()).Site != null)
			{
				return ((Component)(object)((Control)this).get_Parent()).Site!.DesignMode;
			}
			return ((Component)this).DesignMode;
		}
	}

	internal Class26 Class26_0 => class26_0;

	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Indicates whether keyboard navigation using Left and Right arrow keys to select tabs is enabled.")]
	public bool KeyboardNavigationEnabled
	{
		get
		{
			return bool_21;
		}
		set
		{
			bool_21 = value;
		}
	}

	internal bool Boolean_7
	{
		get
		{
			if (eTabLayoutType_0 != eTabLayoutType.FixedWithNavigationBox)
			{
				return eTabLayoutType_0 == eTabLayoutType.MultilineWithNavigationBox;
			}
			return true;
		}
	}

	internal bool Boolean_8
	{
		get
		{
			if (eTabLayoutType_0 != eTabLayoutType.MultilineNoNavigationBox)
			{
				return eTabLayoutType_0 == eTabLayoutType.MultilineWithNavigationBox;
			}
			return true;
		}
	}

	private bool Boolean_9
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_1 == value)
			{
				return;
			}
			bool_1 = value;
			if (bool_1)
			{
				if (!Boolean_10)
				{
					cursor_0 = ((Control)this).get_Cursor();
					((Control)this).set_Cursor(method_35());
				}
			}
			else if (!Boolean_10)
			{
				((Control)this).set_Cursor(cursor_0);
			}
		}
	}

	[Category("Appearance")]
	[Description("Specifies the mouse cursor that is displayed when tab is dragged.")]
	[DefaultValue(null)]
	[Browsable(true)]
	public Cursor TabDragCursor
	{
		get
		{
			return cursor_1;
		}
		set
		{
			cursor_1 = value;
		}
	}

	private bool Boolean_10 => ((Control)this).get_Parent() is Bar;

	internal TabItem TabItem_1 => tabItem_1;

	internal int Int32_1
	{
		get
		{
			int num = 0;
			foreach (TabItem item in tabsCollection_0)
			{
				if (item.Visible)
				{
					num++;
				}
			}
			return num;
		}
	}

	internal bool Boolean_11 => bool_2;

	[DevCoBrowsable(true)]
	[Category("Style")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Gets or sets the selected tab Font")]
	public Font SelectedTabFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
			if (font_0 == null)
			{
				bool_11 = false;
			}
			else
			{
				bool_11 = true;
			}
			bool_0 = true;
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(eTabStripAlignment.Bottom)]
	[Category("Appearance")]
	[Description("Indicates the tab alignment within the Tab-Strip control.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public eTabStripAlignment TabAlignment
	{
		get
		{
			return eTabStripAlignment_0;
		}
		set
		{
			if (eTabStripAlignment_0 != value)
			{
				eTabStripAlignment_0 = value;
				bool_0 = true;
				((Control)this).Invalidate();
			}
		}
	}

	internal bool Boolean_12
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[Category("Behavior")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifes whether end-user can reorder the tabs.")]
	public bool CanReorderTabs
	{
		get
		{
			return bool_3;
		}
		set
		{
			if (bool_3 != value)
			{
				bool_3 = value;
			}
		}
	}

	[Description("Indicates whether system box that enables scrolling and closing of the tabs is automatically hidden when tab items size does not exceed the size of the control.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Behavior")]
	public bool AutoHideSystemBox
	{
		get
		{
			return bool_15;
		}
		set
		{
			if (bool_15 != value)
			{
				bool_15 = value;
				bool_0 = true;
				if (Boolean_6)
				{
					((Control)this).Invalidate();
				}
			}
		}
	}

	[Obsolete("This property is obsolete. Please use ColorScheme property to change all tab colors.")]
	[Description("Indicates the background color.")]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			((Control)this).set_BackColor(value);
		}
	}

	[DefaultValue(false)]
	[Description("Specifes whether only selected tab is displaying it's text.")]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public bool DisplaySelectedTextOnly
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
			bool_0 = true;
			((Control)this).Invalidate();
		}
	}

	[Description("Specifes the TabStrip style.")]
	[Browsable(true)]
	[DefaultValue(eTabStripStyle.Flat)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public eTabStripStyle Style
	{
		get
		{
			return eTabStripStyle_0;
		}
		set
		{
			eTabStripStyle_0 = value;
			method_42();
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	[Description("Specifies whether tab is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[DefaultValue(false)]
	public virtual bool ThemeAware
	{
		get
		{
			return bool_16;
		}
		set
		{
			bool_16 = value;
			bool_0 = true;
			tabColorScheme_0.Boolean_0 = Boolean_13;
			((Control)this).Invalidate();
		}
	}

	internal bool Boolean_13
	{
		get
		{
			if (bool_16 && Class109.Boolean_0 && Class58.bool_0 && eTabStripStyle_0 != eTabStripStyle.SimulatedTheme && eTabStripStyle_0 != eTabStripStyle.Office2007Dock && eTabStripStyle_0 != eTabStripStyle.Office2007Document)
			{
				return true;
			}
			return false;
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[Description("Gets or sets Tab Color Scheme.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public TabColorScheme ColorScheme
	{
		get
		{
			return tabColorScheme_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentException("NULL is not a valid value for this property.");
			}
			if (tabColorScheme_0 != null)
			{
				tabColorScheme_0.ColorChanged -= tabColorScheme_0_ColorChanged;
			}
			tabColorScheme_0 = value;
			tabColorScheme_0.ColorChanged += tabColorScheme_0_ColorChanged;
			if (((Control)this).get_Visible())
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether the tab scrolling is animanted.")]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	public bool Animate
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
		}
	}

	[Browsable(true)]
	[Description("Gets or sets the fixed tab size in pixels. Either Height or Width can be set or both.")]
	[Category("Appearance")]
	public Size FixedTabSize
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
			bool_0 = true;
			if (((Component)this).DesignMode)
			{
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Behavior")]
	[Description("Indicates whether focus rectangle is displayed when tab has input focus.")]
	public bool ShowFocusRectangle
	{
		get
		{
			return bool_14;
		}
		set
		{
			bool_14 = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates whether Tab-Strip control provides Tabbed MDI Child form support.")]
	[DefaultValue(false)]
	[Category("Mdi Support")]
	public bool MdiTabbedDocuments
	{
		get
		{
			return bool_6;
		}
		set
		{
			if (bool_6 == value)
			{
				return;
			}
			bool_6 = value;
			if (form_0 == null && bool_6)
			{
				Form val = ((Control)this).FindForm();
				if (val != null && val.get_IsMdiContainer())
				{
					MdiForm = val;
				}
			}
			else if (!bool_6)
			{
				MdiForm = null;
				tabsCollection_0.Clear();
				((Control)this).Invalidate();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(32)]
	[Description("Indicates the maximum number of characters that will be used as Tab text from Mdi Child caption.")]
	[Category("Mdi Support")]
	[Browsable(true)]
	public int MaxMdiCaptionLength
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 != value)
			{
				int_1 = value;
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Mdi Support")]
	[Description("Indicates whether the Mdi Child Icon is displayed on Tab.")]
	[DefaultValue(true)]
	public bool ShowMdiChildIcon
	{
		get
		{
			return bool_8;
		}
		set
		{
			if (bool_8 != value)
			{
				bool_8 = value;
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether the Tab-strip is automatically hidden when there are not Mdi Child forms open.")]
	[Category("Mdi Support")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public bool MdiAutoHide
	{
		get
		{
			return bool_9;
		}
		set
		{
			if (bool_9 != value)
			{
				bool_9 = value;
			}
		}
	}

	[Description("Indicates whether flicker associated with switching maximized Mdi child forms is attempted to eliminate.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	[Category("Mdi Support")]
	public bool MdiNoFormActivateFlicker
	{
		get
		{
			return bool_10;
		}
		set
		{
			if (bool_10 != value)
			{
				bool_10 = value;
			}
		}
	}

	[DefaultValue(null)]
	[Description("Indicates Mdi Container form for which Tab-Strip is providing Tabbed MDI Child support.")]
	[Browsable(true)]
	public Form MdiForm
	{
		get
		{
			return form_0;
		}
		set
		{
			if (form_0 != null)
			{
				method_52();
			}
			form_0 = value;
			if (form_0 != null && !((Component)this).DesignMode)
			{
				method_51();
				method_55();
			}
		}
	}

	public event SelectedTabChangedEventHandler SelectedTabChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			selectedTabChangedEventHandler_0 = (SelectedTabChangedEventHandler)Delegate.Combine(selectedTabChangedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			selectedTabChangedEventHandler_0 = (SelectedTabChangedEventHandler)Delegate.Remove(selectedTabChangedEventHandler_0, value);
		}
	}

	public event SelectedTabChangingEventHandler SelectedTabChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			selectedTabChangingEventHandler_0 = (SelectedTabChangingEventHandler)Delegate.Combine(selectedTabChangingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			selectedTabChangingEventHandler_0 = (SelectedTabChangingEventHandler)Delegate.Remove(selectedTabChangingEventHandler_0, value);
		}
	}

	public event TabMovedEventHandler TabMoved
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			tabMovedEventHandler_0 = (TabMovedEventHandler)Delegate.Combine(tabMovedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			tabMovedEventHandler_0 = (TabMovedEventHandler)Delegate.Remove(tabMovedEventHandler_0, value);
		}
	}

	public event UserActionEventHandler NavigateBack
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			userActionEventHandler_0 = (UserActionEventHandler)Delegate.Combine(userActionEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			userActionEventHandler_0 = (UserActionEventHandler)Delegate.Remove(userActionEventHandler_0, value);
		}
	}

	public event UserActionEventHandler NavigateForward
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			userActionEventHandler_1 = (UserActionEventHandler)Delegate.Combine(userActionEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			userActionEventHandler_1 = (UserActionEventHandler)Delegate.Remove(userActionEventHandler_1, value);
		}
	}

	public event UserActionEventHandler TabItemClose
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			userActionEventHandler_2 = (UserActionEventHandler)Delegate.Combine(userActionEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			userActionEventHandler_2 = (UserActionEventHandler)Delegate.Remove(userActionEventHandler_2, value);
		}
	}

	public event EventHandler TabItemOpen
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

	public event EventHandler BeforeTabDisplay
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public event EventHandler TabRemoved
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_2 = (EventHandler)Delegate.Combine(eventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_2 = (EventHandler)Delegate.Remove(eventHandler_2, value);
		}
	}

	public event EventHandler TabsCleared
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
		}
	}

	internal event EventHandler Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_4 = (EventHandler)Delegate.Combine(eventHandler_4, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_4 = (EventHandler)Delegate.Remove(eventHandler_4, value);
		}
	}

	public event MeasureTabItemEventHandler MeasureTabItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			measureTabItemEventHandler_0 = (MeasureTabItemEventHandler)Delegate.Combine(measureTabItemEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			measureTabItemEventHandler_0 = (MeasureTabItemEventHandler)Delegate.Remove(measureTabItemEventHandler_0, value);
		}
	}

	public event RenderTabItemEventHandler PreRenderTabItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			renderTabItemEventHandler_0 = (RenderTabItemEventHandler)Delegate.Combine(renderTabItemEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			renderTabItemEventHandler_0 = (RenderTabItemEventHandler)Delegate.Remove(renderTabItemEventHandler_0, value);
		}
	}

	public event RenderTabItemEventHandler PostRenderTabItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			renderTabItemEventHandler_1 = (RenderTabItemEventHandler)Delegate.Combine(renderTabItemEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			renderTabItemEventHandler_1 = (RenderTabItemEventHandler)Delegate.Remove(renderTabItemEventHandler_1, value);
		}
	}

	public TabStrip()
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		tabsCollection_0 = new TabsCollection(this);
		((Control)this).SetStyle((ControlStyles)512, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		class26_0 = new Class26(this);
		class26_0.Event_0 += method_45;
		class26_0.Event_2 += method_49;
		class26_0.Event_1 += method_47;
		tabColorScheme_0 = new TabColorScheme(eTabStripStyle_0);
		tabColorScheme_0.ColorChanged += tabColorScheme_0_ColorChanged;
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			int_0 = 0;
			RecalcSize();
			EnsureVisible(SelectedTab);
		}
	}

	private Rectangle method_0(Rectangle rectangle_1)
	{
		rectangle_1.Inflate(-1, -1);
		return rectangle_1;
	}

	internal void method_1(Graphics graphics_0)
	{
		if (Boolean_7 && class26_0.bool_5)
		{
			class26_0.method_9(graphics_0);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = e.get_Graphics().get_SmoothingMode();
		TextRenderingHint textRenderingHint = e.get_Graphics().get_TextRenderingHint();
		if (bool_19)
		{
			e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
			if (!SystemInformation.get_IsFontSmoothingEnabled())
			{
				e.get_Graphics().set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
		}
		if (((Control)this).get_BackColor() == Color.Transparent || ColorScheme.TabBackground == Color.Transparent)
		{
			((Control)this).OnPaintBackground(e);
		}
		if (eTabStripStyle_0 == eTabStripStyle.SimulatedTheme)
		{
			if (bool_0)
			{
				method_16(e.get_Graphics(), method_4(((Control)this).get_DisplayRectangle(), TabLayoutType == eTabLayoutType.MultilineWithNavigationBox, bool_25: false));
			}
			Class37 @class = new Class37();
			@class.Boolean_1 = bool_17;
			@class.Paint(e.get_Graphics(), this);
		}
		else if (Boolean_13)
		{
			method_9(e.get_Graphics());
		}
		else if (eTabStripStyle_0 != eTabStripStyle.OneNote && eTabStripStyle_0 != eTabStripStyle.VS2005Document)
		{
			if (eTabStripStyle_0 == eTabStripStyle.VS2005)
			{
				method_11(e.get_Graphics());
			}
			else if (eTabStripStyle_0 == eTabStripStyle.RoundHeader)
			{
				if (bool_0)
				{
					method_16(e.get_Graphics(), method_4(((Control)this).get_DisplayRectangle(), TabLayoutType == eTabLayoutType.MultilineWithNavigationBox, bool_25: false));
				}
				Class38 class2 = new Class38();
				class2.Boolean_1 = bool_17;
				class2.Paint(e.get_Graphics(), this);
			}
			else if (eTabStripStyle_0 == eTabStripStyle.Office2007Dock)
			{
				if (bool_0)
				{
					method_16(e.get_Graphics(), method_4(((Control)this).get_DisplayRectangle(), TabLayoutType == eTabLayoutType.MultilineWithNavigationBox, bool_25: false));
				}
				Class39 class3 = new Class39();
				class3.Boolean_1 = bool_17;
				class3.Paint(e.get_Graphics(), this);
			}
			else if (eTabStripStyle_0 == eTabStripStyle.VS2005Dock)
			{
				if (bool_0)
				{
					method_16(e.get_Graphics(), method_4(((Control)this).get_DisplayRectangle(), TabLayoutType == eTabLayoutType.MultilineWithNavigationBox, bool_25: false));
				}
				Class40 class4 = new Class40();
				class4.Boolean_1 = bool_17;
				class4.Paint(e.get_Graphics(), this);
			}
			else if (eTabStripStyle_0 == eTabStripStyle.Office2007Document)
			{
				if (bool_0)
				{
					method_16(e.get_Graphics(), method_4(((Control)this).get_DisplayRectangle(), TabLayoutType == eTabLayoutType.MultilineWithNavigationBox, bool_25: false));
				}
				Class41 class5 = new Class41();
				class5.Boolean_1 = bool_17;
				class5.Paint(e.get_Graphics(), this);
			}
			else
			{
				method_2(e.get_Graphics());
			}
		}
		else
		{
			method_6(e.get_Graphics());
		}
		e.get_Graphics().set_SmoothingMode(smoothingMode);
		e.get_Graphics().set_TextRenderingHint(textRenderingHint);
	}

	private void method_2(Graphics graphics_0)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected O, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected O, but got Unknown
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Expected O, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a78: Expected O, but got Unknown
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0dfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Expected O, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Expected O, but got Unknown
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed9: Expected O, but got Unknown
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3b: Expected O, but got Unknown
		//IL_0f96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Expected O, but got Unknown
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff6: Expected O, but got Unknown
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected O, but got Unknown
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_111a: Expected O, but got Unknown
		//IL_11ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected O, but got Unknown
		//IL_11f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fa: Expected O, but got Unknown
		//IL_125c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1263: Expected O, but got Unknown
		//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected O, but got Unknown
		//IL_1358: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Expected O, but got Unknown
		//IL_1685: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d3: Expected O, but got Unknown
		//IL_16ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1745: Expected O, but got Unknown
		TabColorScheme tabColorScheme = tabColorScheme_0;
		if (!tabColorScheme.TabBackground2.IsEmpty && ((Control)this).get_Height() > 0 && ((Control)this).get_Width() > 0)
		{
			LinearGradientBrush val = Class109.smethod_40(((Control)this).get_ClientRectangle(), tabColorScheme.TabBackground, tabColorScheme.TabBackground2, tabColorScheme.TabBackgroundGradientAngle);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			SolidBrush val2 = new SolidBrush(tabColorScheme.TabBackground);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val2, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		if (!tabColorScheme.TabBorder.IsEmpty)
		{
			Pen val3 = new Pen(tabColorScheme.TabBorder, 1f);
			try
			{
				graphics_0.DrawRectangle(val3, new Rectangle(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Y, ((Control)this).get_ClientRectangle().Width - 1, ((Control)this).get_ClientRectangle().Height - 1));
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
		switch (eTabStripAlignment_0)
		{
		case eTabStripAlignment.Top:
			displayRectangle.Y++;
			displayRectangle.Height -= 3;
			break;
		case eTabStripAlignment.Bottom:
			displayRectangle.Height -= 3;
			break;
		}
		TabItem selectedTab = SelectedTab;
		eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		int num = ((!tabColorScheme.TabBorder.IsEmpty) ? 1 : 0);
		switch (eTabStripAlignment_0)
		{
		default:
			if (!(((Control)this).get_Parent() is TabControl))
			{
				graphics_0.FillRectangle((Brush)new SolidBrush(tabColorScheme.TabItemSelectedBackground), displayRectangle.X, 0, displayRectangle.Width, displayRectangle.Y);
			}
			else
			{
				Pen val5 = new Pen(tabColorScheme.TabItemSelectedBorder, 1f);
				try
				{
					graphics_0.DrawLine(val5, displayRectangle.X, displayRectangle.Y, displayRectangle.X, 0);
					graphics_0.DrawLine(val5, displayRectangle.Right - 1, displayRectangle.Y, displayRectangle.Right - 1, 0);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
			graphics_0.DrawLine(new Pen(tabColorScheme.TabItemSelectedBorderLight, 1f), displayRectangle.X, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y);
			displayRectangle.Inflate(-4, 0);
			break;
		case eTabStripAlignment.Left:
			graphics_0.DrawLine(new Pen(tabColorScheme.TabItemSelectedBorderLight, 1f), displayRectangle.Right - 1, displayRectangle.Y + num, displayRectangle.Right - 1, displayRectangle.Bottom - num);
			displayRectangle.Inflate(0, -4);
			break;
		case eTabStripAlignment.Right:
			graphics_0.DrawLine(new Pen(tabColorScheme.TabItemSelectedBorderLight, 1f), displayRectangle.X, displayRectangle.Y + num, displayRectangle.X, displayRectangle.Bottom - num);
			displayRectangle.Inflate(0, -4);
			break;
		case eTabStripAlignment.Top:
			if (!(((Control)this).get_Parent() is TabControl))
			{
				graphics_0.FillRectangle((Brush)new SolidBrush(tabColorScheme.TabItemSelectedBackground2.IsEmpty ? tabColorScheme.TabItemSelectedBackground : tabColorScheme.TabItemSelectedBackground2), displayRectangle.X + num, displayRectangle.Bottom, displayRectangle.Width - num * 2, ((Control)this).get_Height() - displayRectangle.Bottom);
			}
			else
			{
				Pen val4 = new Pen(tabColorScheme.TabItemSelectedBorder, 1f);
				try
				{
					graphics_0.DrawLine(val4, displayRectangle.X, displayRectangle.Bottom, displayRectangle.X, ((Control)this).get_ClientRectangle().Bottom);
					graphics_0.DrawLine(val4, displayRectangle.Right - 1, displayRectangle.Bottom, displayRectangle.Right - 1, ((Control)this).get_ClientRectangle().Bottom);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			graphics_0.DrawLine(new Pen(tabColorScheme.TabItemSelectedBorderLight, 1f), displayRectangle.X + num, displayRectangle.Bottom, displayRectangle.Right - 1 - num, displayRectangle.Bottom);
			displayRectangle.Inflate(-4, 0);
			break;
		}
		if (Boolean_7 && class26_0.bool_5)
		{
			if (eTabStripAlignment_0 != eTabStripAlignment.Right && eTabStripAlignment_0 != 0)
			{
				if (class26_0.rectangle_0.Width > 0)
				{
					displayRectangle.Width -= class26_0.rectangle_0.Width;
				}
				else
				{
					displayRectangle.Width -= class26_0.int_0;
				}
				if (Boolean_1)
				{
					displayRectangle.X += class26_0.int_0;
				}
			}
			else if (class26_0.rectangle_0.Height > 0)
			{
				displayRectangle.Height -= class26_0.rectangle_0.Height;
			}
			else
			{
				displayRectangle.Height -= class26_0.int_0;
			}
		}
		if (bool_0)
		{
			method_16(graphics_0, method_4(((Control)this).get_DisplayRectangle(), bool_24: false, bool_25: false));
		}
		if (eTabStripAlignment_0 == eTabStripAlignment.Top)
		{
			displayRectangle.Height++;
		}
		Rectangle rectangle = displayRectangle;
		graphics_0.SetClip(displayRectangle);
		foreach (TabItem item in tabsCollection_0)
		{
			if (!item.Visible || !displayRectangle.IntersectsWith(item.DisplayRectangle))
			{
				continue;
			}
			if (Boolean_4)
			{
				RenderTabItemEventArgs renderTabItemEventArgs = new RenderTabItemEventArgs(item, graphics_0);
				method_19(renderTabItemEventArgs);
				if (renderTabItemEventArgs.Cancel)
				{
					continue;
				}
			}
			Rectangle rectangle_ = item.DisplayRectangle;
			TabColors tabColors = method_44(item);
			if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
			{
				if (item == selectedTab)
				{
					if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
					{
						if (tabColors.BackColor2.IsEmpty)
						{
							SolidBrush val6 = new SolidBrush(graphics_0.GetNearestColor(tabColors.BackColor));
							try
							{
								graphics_0.FillRectangle((Brush)(object)val6, rectangle_);
							}
							finally
							{
								((IDisposable)val6)?.Dispose();
							}
						}
						else
						{
							LinearGradientBrush val7 = Class109.smethod_40(rectangle_, tabColors.BackColor, tabColors.BackColor2, tabColors.BackColorGradientAngle);
							try
							{
								graphics_0.FillRectangle((Brush)(object)val7, rectangle_);
							}
							finally
							{
								((IDisposable)val7)?.Dispose();
							}
						}
						Pen val8 = new Pen(tabColors.LightBorderColor, 1f);
						try
						{
							graphics_0.DrawLine(val8, rectangle_.X, rectangle_.Y, rectangle_.X, rectangle_.Bottom);
						}
						finally
						{
							((IDisposable)val8)?.Dispose();
						}
						Pen val9 = new Pen(tabColors.BorderColor, 1f);
						try
						{
							graphics_0.DrawLine(val9, rectangle_.X + 1, rectangle_.Bottom, rectangle_.Right, rectangle_.Bottom);
							graphics_0.DrawLine(val9, rectangle_.Right, rectangle_.Y, rectangle_.Right, rectangle_.Bottom);
						}
						finally
						{
							((IDisposable)val9)?.Dispose();
						}
					}
					else
					{
						if (tabColors.BackColor2.IsEmpty)
						{
							SolidBrush val10 = new SolidBrush(graphics_0.GetNearestColor(tabColors.BackColor));
							try
							{
								graphics_0.FillRectangle((Brush)(object)val10, rectangle_.X, rectangle_.Y, rectangle_.Width, rectangle_.Height + 1);
							}
							finally
							{
								((IDisposable)val10)?.Dispose();
							}
						}
						else
						{
							LinearGradientBrush val11 = Class109.smethod_40(new Rectangle(rectangle_.X, rectangle_.Y, rectangle_.Width, rectangle_.Height + 1), tabColors.BackColor, tabColors.BackColor2, tabColors.BackColorGradientAngle);
							try
							{
								graphics_0.FillRectangle((Brush)(object)val11, rectangle_.X, rectangle_.Y, rectangle_.Width, rectangle_.Height + 1);
							}
							finally
							{
								((IDisposable)val11)?.Dispose();
							}
						}
						Pen val12 = new Pen(tabColors.LightBorderColor, 1f);
						try
						{
							graphics_0.DrawLine(val12, rectangle_.X, rectangle_.Y, rectangle_.X, rectangle_.Bottom);
							graphics_0.DrawLine(val12, rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
						}
						finally
						{
							((IDisposable)val12)?.Dispose();
						}
						Pen val13 = new Pen(tabColors.BorderColor, 1f);
						try
						{
							graphics_0.DrawLine(val13, rectangle_.Right, rectangle_.Y, rectangle_.Right, rectangle_.Bottom);
						}
						finally
						{
							((IDisposable)val13)?.Dispose();
						}
					}
				}
				else
				{
					if (!tabColors.BackColor.IsEmpty)
					{
						Rectangle rectangle2 = rectangle_;
						rectangle2.Width--;
						rectangle2.X++;
						rectangle2.Height--;
						rectangle2.Y++;
						if (!tabColors.BackColor2.IsEmpty)
						{
							LinearGradientBrush val14 = Class109.smethod_40(rectangle_, tabColors.BackColor, tabColors.BackColor2, tabColors.BackColorGradientAngle);
							try
							{
								graphics_0.FillRectangle((Brush)(object)val14, rectangle2);
							}
							finally
							{
								((IDisposable)val14)?.Dispose();
							}
						}
						else
						{
							SolidBrush val15 = new SolidBrush(tabColors.BackColor);
							try
							{
								graphics_0.FillRectangle((Brush)(object)val15, rectangle2);
							}
							finally
							{
								((IDisposable)val15)?.Dispose();
							}
						}
					}
					if (!tabColors.LightBorderColor.IsEmpty)
					{
						if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
						{
							Pen val16 = new Pen(tabColors.LightBorderColor, 1f);
							try
							{
								graphics_0.DrawLine(val16, rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
								graphics_0.DrawLine(val16, rectangle_.X, rectangle_.Y, rectangle_.X, rectangle_.Bottom);
							}
							finally
							{
								((IDisposable)val16)?.Dispose();
							}
						}
						else
						{
							Pen val17 = new Pen(tabColors.LightBorderColor, 1f);
							try
							{
								graphics_0.DrawLine(val17, rectangle_.X, rectangle_.Y, rectangle_.X, rectangle_.Bottom);
								graphics_0.DrawLine(val17, rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
							}
							finally
							{
								((IDisposable)val17)?.Dispose();
							}
						}
					}
					if (!tabColors.BorderColor.IsEmpty)
					{
						if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
						{
							Pen val18 = new Pen(tabColors.BorderColor, 1f);
							try
							{
								graphics_0.DrawLine(val18, rectangle_.X + 1, rectangle_.Bottom, rectangle_.Right, rectangle_.Bottom);
								graphics_0.DrawLine(val18, rectangle_.Right, rectangle_.Y, rectangle_.Right, rectangle_.Bottom);
							}
							finally
							{
								((IDisposable)val18)?.Dispose();
							}
						}
						else
						{
							Pen val19 = new Pen(tabColors.BorderColor, 1f);
							try
							{
								graphics_0.DrawLine(val19, rectangle_.Right - 1, rectangle_.Y, rectangle_.Right - 1, rectangle_.Bottom);
								graphics_0.DrawLine(val19, rectangle_.X, rectangle_.Bottom, rectangle_.Right, rectangle_.Bottom);
							}
							finally
							{
								((IDisposable)val19)?.Dispose();
							}
						}
					}
				}
				if (eTabStripAlignment_0 == eTabStripAlignment.Top)
				{
					rectangle_.Offset(0, 1);
				}
				if (bool_17 && item.CloseButtonVisible)
				{
					item.CloseButtonBounds = method_7(graphics_0, bool_24: false, item.CloseButtonMouseOver, item == tabItem_1 || item == SelectedTab, ref rectangle_);
				}
				else
				{
					item.CloseButtonBounds = Rectangle.Empty;
				}
				Image image = item.GetImage();
				Icon icon = item.Icon;
				if ((image != null && image.get_Width() + 4 < rectangle_.Width) || (icon != null && item.IconSize.Width + 4 < rectangle_.Width))
				{
					if (icon != null)
					{
						Rectangle rectangle3 = new Rectangle(rectangle_.X + 4, rectangle_.Y + (rectangle_.Height - item.IconSize.Height) / 2, item.IconSize.Width, item.IconSize.Height);
						if (rectangle.Contains(rectangle3))
						{
							graphics_0.DrawIcon(icon, rectangle3);
						}
						rectangle_.X += item.IconSize.Width + 2;
						rectangle_.Width -= item.IconSize.Width + 2;
					}
					else if (image != null)
					{
						graphics_0.DrawImage(image, rectangle_.X + 4, rectangle_.Y + (rectangle_.Height - image.get_Height()) / 2, image.get_Width(), image.get_Height());
						rectangle_.X += image.get_Width() + 2;
						rectangle_.Width -= image.get_Width() + 2;
					}
					rectangle_.Inflate(0, -1);
					rectangle_.Width -= 4;
					rectangle_.X += 3;
				}
				else
				{
					rectangle_.X += 2;
					rectangle_.Width -= 2;
				}
				if (!bool_12 || item == tabItem_0)
				{
					Font font = ((Control)this).get_Font();
					if (item == selectedTab && font_0 != null)
					{
						font = font_0;
					}
					if (rectangle_.Width > int_3)
					{
						Class55.smethod_1(graphics_0, item.Text, font, tabColors.TextColor, rectangle_, eTextFormat_);
					}
					if (bool_14 && ((Control)this).get_Focused() && item == tabItem_0)
					{
						ControlPaint.DrawFocusRectangle(graphics_0, method_0(rectangle_));
					}
				}
				if (item != selectedTab)
				{
					Rectangle displayRectangle2 = item.DisplayRectangle;
					if (Boolean_1)
					{
						displayRectangle2.Width -= 2;
					}
					Pen val20 = new Pen(tabColorScheme.TabItemSeparator, 1f);
					try
					{
						graphics_0.DrawLine(val20, displayRectangle2.Right, displayRectangle2.Y + 2, displayRectangle2.Right, displayRectangle2.Bottom - 4);
					}
					finally
					{
						((IDisposable)val20)?.Dispose();
					}
					if (!tabColorScheme.TabItemSeparatorShade.IsEmpty)
					{
						Pen val21 = new Pen(tabColorScheme.TabItemSeparatorShade, 1f);
						try
						{
							graphics_0.DrawLine(val21, displayRectangle2.Right + 1, displayRectangle2.Y + 2 + 1, displayRectangle2.Right + 1, displayRectangle2.Bottom - 4 + 1);
						}
						finally
						{
							((IDisposable)val21)?.Dispose();
						}
					}
				}
			}
			else
			{
				if (item == selectedTab)
				{
					if (eTabStripAlignment_0 == eTabStripAlignment.Left)
					{
						if (tabColors.BackColor2.IsEmpty)
						{
							SolidBrush val22 = new SolidBrush(graphics_0.GetNearestColor(tabColors.BackColor));
							try
							{
								graphics_0.FillRectangle((Brush)(object)val22, rectangle_);
							}
							finally
							{
								((IDisposable)val22)?.Dispose();
							}
						}
						else
						{
							LinearGradientBrush val23 = Class109.smethod_40(rectangle_, tabColors.BackColor, tabColors.BackColor2, tabColors.BackColorGradientAngle);
							try
							{
								graphics_0.FillRectangle((Brush)(object)val23, rectangle_);
							}
							finally
							{
								((IDisposable)val23)?.Dispose();
							}
						}
						Pen val24 = new Pen(tabColors.LightBorderColor, 1f);
						graphics_0.DrawLine(val24, rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
						graphics_0.DrawLine(val24, rectangle_.X, rectangle_.Y, rectangle_.X, rectangle_.Bottom);
						val24.Dispose();
						val24 = new Pen(tabColors.BorderColor, 1f);
						graphics_0.DrawLine(val24, rectangle_.X + 1, rectangle_.Bottom, rectangle_.Right - 2, rectangle_.Bottom);
						val24.Dispose();
					}
					else
					{
						if (tabColors.BackColor2.IsEmpty)
						{
							SolidBrush val25 = new SolidBrush(graphics_0.GetNearestColor(tabColors.BackColor));
							try
							{
								graphics_0.FillRectangle((Brush)(object)val25, rectangle_.X, rectangle_.Y, rectangle_.Width, rectangle_.Height + 1);
							}
							finally
							{
								((IDisposable)val25)?.Dispose();
							}
						}
						else
						{
							LinearGradientBrush val26 = Class109.smethod_40(new Rectangle(rectangle_.X, rectangle_.Y, rectangle_.Width, rectangle_.Height + 1), tabColors.BackColor, tabColors.BackColor2, tabColors.BackColorGradientAngle);
							try
							{
								graphics_0.FillRectangle((Brush)(object)val26, rectangle_.X, rectangle_.Y, rectangle_.Width, rectangle_.Height + 1);
							}
							finally
							{
								((IDisposable)val26)?.Dispose();
							}
						}
						Pen val27 = new Pen(tabColors.LightBorderColor, 1f);
						graphics_0.DrawLine(val27, rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
						graphics_0.DrawLine(val27, rectangle_.Right - 1, rectangle_.Y, rectangle_.Right - 1, rectangle_.Bottom);
						val27.Dispose();
						val27 = new Pen(tabColors.BorderColor, 1f);
						graphics_0.DrawLine(val27, rectangle_.X, rectangle_.Bottom, rectangle_.Right - 3, rectangle_.Bottom);
						val27.Dispose();
					}
				}
				else
				{
					if (!tabColors.BackColor.IsEmpty)
					{
						if (!tabColors.BackColor2.IsEmpty)
						{
							LinearGradientBrush val28 = Class109.smethod_40(rectangle_, tabColors.BackColor, tabColors.BackColor2, tabColors.BackColorGradientAngle);
							try
							{
								graphics_0.FillRectangle((Brush)(object)val28, rectangle_);
							}
							finally
							{
								((IDisposable)val28)?.Dispose();
							}
						}
						else
						{
							SolidBrush val29 = new SolidBrush(tabColors.BackColor);
							try
							{
								graphics_0.FillRectangle((Brush)(object)val29, rectangle_);
							}
							finally
							{
								((IDisposable)val29)?.Dispose();
							}
						}
					}
					if (!tabColors.LightBorderColor.IsEmpty)
					{
						if (eTabStripAlignment_0 == eTabStripAlignment.Left)
						{
							Pen val30 = new Pen(tabColors.LightBorderColor, 1f);
							try
							{
								graphics_0.DrawLine(val30, rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
								graphics_0.DrawLine(val30, rectangle_.X, rectangle_.Y, rectangle_.X, rectangle_.Bottom);
							}
							finally
							{
								((IDisposable)val30)?.Dispose();
							}
						}
						else
						{
							Pen val31 = new Pen(tabColors.LightBorderColor, 1f);
							try
							{
								graphics_0.DrawLine(val31, rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
								graphics_0.DrawLine(val31, rectangle_.Right - 1, rectangle_.Y, rectangle_.Right - 1, rectangle_.Bottom);
							}
							finally
							{
								((IDisposable)val31)?.Dispose();
							}
						}
					}
					if (!tabColors.BorderColor.IsEmpty)
					{
						if (eTabStripAlignment_0 == eTabStripAlignment.Left)
						{
							Pen val32 = new Pen(tabColors.BorderColor, 1f);
							try
							{
								graphics_0.DrawLine(val32, rectangle_.X + 1, rectangle_.Bottom, rectangle_.Right - 2, rectangle_.Bottom);
								graphics_0.DrawLine(val32, rectangle_.Right - 1, rectangle_.Bottom, rectangle_.Right - 1, rectangle_.Y + 1);
							}
							finally
							{
								((IDisposable)val32)?.Dispose();
							}
						}
						else
						{
							Pen val33 = new Pen(tabColors.BorderColor, 1f);
							try
							{
								graphics_0.DrawLine(val33, rectangle_.X, rectangle_.Y + 1, rectangle_.X, rectangle_.Bottom);
								graphics_0.DrawLine(val33, rectangle_.X + 1, rectangle_.Bottom, rectangle_.Right - 2, rectangle_.Bottom);
							}
							finally
							{
								((IDisposable)val33)?.Dispose();
							}
						}
					}
				}
				if (bool_17 && item.CloseButtonVisible)
				{
					item.CloseButtonBounds = method_7(graphics_0, bool_24: true, item.CloseButtonMouseOver, item == tabItem_1 || item == SelectedTab, ref rectangle_);
				}
				else
				{
					item.CloseButtonBounds = Rectangle.Empty;
				}
				Image image2 = item.GetImage();
				Icon icon2 = item.Icon;
				if ((image2 != null && image2.get_Width() + 4 <= rectangle_.Width) || (icon2 != null && item.IconSize.Width + 4 <= rectangle_.Width))
				{
					if (icon2 != null)
					{
						Rectangle rectangle4 = new Rectangle(rectangle_.X + (rectangle_.Width - item.IconSize.Width) / 2, rectangle_.Y + 4, item.IconSize.Width, item.IconSize.Height);
						if (rectangle.Contains(rectangle4))
						{
							graphics_0.DrawIcon(icon2, rectangle4);
						}
						rectangle_.Y += item.IconSize.Height + 2;
						rectangle_.Height -= item.IconSize.Height + 2;
					}
					else if (image2 != null)
					{
						graphics_0.DrawImage(image2, rectangle_.X + (rectangle_.Width - image2.get_Width()) / 2, rectangle_.Y + 4, image2.get_Width(), image2.get_Height());
						rectangle_.Y += image2.get_Height() + 2;
						rectangle_.Height -= image2.get_Height() + 2;
					}
					rectangle_.Inflate(0, -1);
					rectangle_.Height -= 4;
					rectangle_.Y += 3;
				}
				else
				{
					rectangle_.Y += 2;
					rectangle_.Height -= 2;
				}
				graphics_0.RotateTransform(90f);
				if (!bool_12 || item == tabItem_0)
				{
					Font font2 = ((Control)this).get_Font();
					if (item == selectedTab && font_0 != null)
					{
						font2 = font_0;
					}
					Rectangle rectangle_2 = new Rectangle(rectangle_.Top, -rectangle_.Right, rectangle_.Height, rectangle_.Width);
					if (rectangle_2.Height > int_3)
					{
						Class55.smethod_2(graphics_0, item.Text, font2, tabColors.TextColor, rectangle_2, eTextFormat_);
					}
					if (bool_14 && ((Control)this).get_Focused() && item == tabItem_0)
					{
						ControlPaint.DrawFocusRectangle(graphics_0, method_0(rectangle_2));
					}
					graphics_0.ResetTransform();
				}
				if (item != selectedTab)
				{
					graphics_0.DrawLine(new Pen(tabColorScheme.TabItemSeparator, 1f), item.DisplayRectangle.X + 1, item.DisplayRectangle.Bottom, item.DisplayRectangle.Right - 4, item.DisplayRectangle.Bottom);
					if (!tabColorScheme.TabItemSeparatorShade.IsEmpty)
					{
						graphics_0.DrawLine(new Pen(tabColorScheme.TabItemSeparatorShade, 1f), item.DisplayRectangle.X + 1 + 1, item.DisplayRectangle.Bottom + 1, item.DisplayRectangle.Right - 4 + 1, item.DisplayRectangle.Bottom + 1);
					}
				}
			}
			if (Boolean_5)
			{
				RenderTabItemEventArgs renderTabItemEventArgs_ = new RenderTabItemEventArgs(item, graphics_0);
				method_20(renderTabItemEventArgs_);
			}
		}
		graphics_0.ResetClip();
		if (Boolean_7 && class26_0.bool_5)
		{
			graphics_0.SetClip(class26_0.rectangle_0);
			class26_0.method_9(graphics_0);
			graphics_0.ResetClip();
		}
	}

	private Rectangle method_3(Rectangle rectangle_1)
	{
		switch (eTabStripAlignment_0)
		{
		case eTabStripAlignment.Left:
			rectangle_1.Width -= 5;
			rectangle_1.X++;
			break;
		case eTabStripAlignment.Right:
			rectangle_1.Width -= 5;
			rectangle_1.X += 3;
			break;
		case eTabStripAlignment.Top:
			rectangle_1.Y++;
			rectangle_1.Height -= 5;
			break;
		case eTabStripAlignment.Bottom:
			rectangle_1.Y += 3;
			rectangle_1.Height -= 5;
			break;
		}
		return rectangle_1;
	}

	internal Rectangle method_4(Rectangle rectangle_1, bool bool_24, bool bool_25)
	{
		int num = method_13();
		if ((eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document) && !Boolean_13)
		{
			rectangle_1 = method_3(rectangle_1);
			switch (eTabStripAlignment_0)
			{
			default:
				rectangle_1.Inflate(-4, 0);
				break;
			case eTabStripAlignment.Left:
				rectangle_1.Inflate(0, -4);
				break;
			case eTabStripAlignment.Right:
				rectangle_1.Inflate(0, -4);
				break;
			case eTabStripAlignment.Top:
				rectangle_1.Inflate(-4, 0);
				break;
			}
			if (bool_24 && Boolean_7)
			{
				if (eTabStripAlignment_0 != eTabStripAlignment.Right && eTabStripAlignment_0 != 0)
				{
					if (Boolean_1)
					{
						rectangle_1.X += class26_0.int_0 + 3;
						rectangle_1.Width -= class26_0.int_0 + 3;
					}
					else
					{
						rectangle_1.Width -= class26_0.int_0 + 3;
					}
				}
				else
				{
					rectangle_1.Height -= class26_0.int_0 + 3;
				}
			}
			if (!bool_25 && (eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document) && !Boolean_13)
			{
				if (eTabStripAlignment_0 != eTabStripAlignment.Right && eTabStripAlignment_0 != 0)
				{
					rectangle_1.Width -= num;
					rectangle_1.X += num;
				}
				else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
				{
					rectangle_1.Height -= num;
					rectangle_1.Y += num;
				}
				else
				{
					rectangle_1.Height -= num;
				}
			}
		}
		else
		{
			switch (eTabStripAlignment_0)
			{
			case eTabStripAlignment.Left:
				if (Boolean_13 && ((Control)this).get_Parent() is TabControl)
				{
					rectangle_1.Width -= 2;
				}
				break;
			case eTabStripAlignment.Right:
				if (Boolean_13 && ((Control)this).get_Parent() is TabControl)
				{
					rectangle_1.X += 2;
					rectangle_1.Width -= 2;
				}
				break;
			case eTabStripAlignment.Top:
				rectangle_1.Y++;
				rectangle_1.Height -= 3;
				break;
			case eTabStripAlignment.Bottom:
				if (Boolean_13 && ((Control)this).get_Parent() is TabControl)
				{
					rectangle_1.Y += 2;
				}
				rectangle_1.Height -= 3;
				break;
			}
			if ((eTabStripStyle_0 != eTabStripStyle.VS2005 && eTabStripStyle_0 != eTabStripStyle.Office2007Document) || Boolean_13)
			{
				switch (eTabStripAlignment_0)
				{
				default:
					rectangle_1.Inflate(-4, 0);
					break;
				case eTabStripAlignment.Left:
					rectangle_1.Inflate(0, -4);
					break;
				case eTabStripAlignment.Right:
					rectangle_1.Inflate(0, -4);
					break;
				case eTabStripAlignment.Top:
					rectangle_1.Inflate(-4, 0);
					break;
				}
			}
			if (Boolean_7 && bool_24)
			{
				if (eTabStripAlignment_0 != eTabStripAlignment.Right && eTabStripAlignment_0 != 0)
				{
					rectangle_1.Width -= class26_0.int_0;
				}
				else
				{
					rectangle_1.Height -= class26_0.int_0;
				}
			}
		}
		return rectangle_1;
	}

	internal void method_5(Graphics graphics_0)
	{
		Rectangle systemBoxRectangle = GetSystemBoxRectangle();
		if (!systemBoxRectangle.IsEmpty)
		{
			graphics_0.SetClip(systemBoxRectangle, (CombineMode)4);
		}
	}

	public Rectangle GetSystemBoxRectangle()
	{
		if (class26_0.bool_5 && Boolean_7)
		{
			Rectangle result = Rectangle.Empty;
			result = ((eTabStripAlignment_0 == eTabStripAlignment.Right || eTabStripAlignment_0 == eTabStripAlignment.Left) ? new Rectangle(0, class26_0.rectangle_0.Y, ((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Bottom - class26_0.rectangle_0.Y) : ((!Boolean_1) ? new Rectangle(class26_0.rectangle_0.X, 0, ((Control)this).get_ClientRectangle().Right - class26_0.rectangle_0.X, ((Control)this).get_ClientRectangle().Height) : class26_0.rectangle_0));
			if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
			{
				result.Y++;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Top)
			{
				result.Height -= 2;
			}
			return result;
		}
		return Rectangle.Empty;
	}

	private void method_6(Graphics graphics_0)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected O, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected O, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected O, but got Unknown
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be7: Expected O, but got Unknown
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected O, but got Unknown
		//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f4: Expected O, but got Unknown
		//IL_117d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Expected O, but got Unknown
		//IL_11de: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e5: Expected O, but got Unknown
		//IL_1214: Unknown result type (might be due to invalid IL or missing references)
		//IL_121b: Expected O, but got Unknown
		//IL_12fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1305: Expected O, but got Unknown
		//IL_13e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ef: Expected O, but got Unknown
		//IL_1489: Unknown result type (might be due to invalid IL or missing references)
		//IL_1490: Expected O, but got Unknown
		//IL_17d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_181e: Expected O, but got Unknown
		//IL_1837: Unknown result type (might be due to invalid IL or missing references)
		//IL_188d: Expected O, but got Unknown
		//IL_18cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d4: Expected O, but got Unknown
		Rectangle rectangle = method_4(((Control)this).get_DisplayRectangle(), bool_24: false, bool_25: false);
		if (bool_0)
		{
			method_16(graphics_0, method_4(((Control)this).get_DisplayRectangle(), bool_24: false, bool_25: false));
		}
		if (!tabColorScheme_0.TabBackground2.IsEmpty && ((Control)this).get_Height() > 0 && ((Control)this).get_Width() > 0)
		{
			int num = tabColorScheme_0.TabBackgroundGradientAngle;
			if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
			{
				num -= 180;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
			{
				num -= 90;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
			{
				num += 90;
			}
			LinearGradientBrush val = Class109.smethod_40(((Control)this).get_DisplayRectangle(), tabColorScheme_0.TabBackground, tabColorScheme_0.TabBackground2, num);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			SolidBrush val2 = new SolidBrush(tabColorScheme_0.TabBackground);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val2, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		if (!tabColorScheme_0.TabBorder.IsEmpty)
		{
			Pen val3 = new Pen(tabColorScheme_0.TabBorder, 1f);
			try
			{
				graphics_0.DrawRectangle(val3, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		TabItem selectedTab = SelectedTab;
		eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		Rectangle rectangle2 = method_3(((Control)this).get_DisplayRectangle());
		Color color = (tabColorScheme_0.TabItemSelectedBackground2.IsEmpty ? tabColorScheme_0.TabItemSelectedBackground : tabColorScheme_0.TabItemSelectedBackground2);
		if (selectedTab != null && selectedTab.PredefinedColor != 0 && !selectedTab.BackColor2.IsEmpty)
		{
			color = selectedTab.BackColor2;
		}
		switch (eTabStripAlignment_0)
		{
		default:
		{
			SolidBrush val6 = new SolidBrush(color);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val6, rectangle2.X, 0, rectangle2.Width, rectangle2.Y);
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
			Pen val7 = new Pen(tabColorScheme_0.TabItemSelectedBorder, 1f);
			try
			{
				graphics_0.DrawLine(val7, rectangle2.X, rectangle2.Y, rectangle2.Right, rectangle2.Y);
				if (((Control)this).get_Parent() is TabControl)
				{
					graphics_0.DrawLine(val7, rectangle2.X, rectangle2.Y, rectangle2.X, 0);
					graphics_0.DrawLine(val7, rectangle2.Right - 1, rectangle2.Y, rectangle2.Right - 1, 0);
				}
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
			break;
		}
		case eTabStripAlignment.Left:
		{
			SolidBrush val8 = new SolidBrush(color);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val8, rectangle2.Right, rectangle2.Y, ((Control)this).get_Width() - rectangle2.Width, ((Control)this).get_Height());
			}
			finally
			{
				((IDisposable)val8)?.Dispose();
			}
			Pen val9 = new Pen(tabColorScheme_0.TabItemSelectedBorder, 1f);
			try
			{
				graphics_0.DrawLine(val9, rectangle2.Right - 1, rectangle2.Y, rectangle2.Right - 1, rectangle2.Bottom);
				if (((Control)this).get_Parent() is TabControl)
				{
					graphics_0.DrawLine(val9, rectangle2.Right - 1, rectangle2.Y, ((Control)this).get_ClientRectangle().Right, rectangle2.Y);
					graphics_0.DrawLine(val9, rectangle2.Right - 1, rectangle2.Bottom - 1, ((Control)this).get_ClientRectangle().Right, rectangle2.Bottom - 1);
				}
			}
			finally
			{
				((IDisposable)val9)?.Dispose();
			}
			break;
		}
		case eTabStripAlignment.Right:
		{
			SolidBrush val10 = new SolidBrush(color);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val10, 0, 0, ((Control)this).get_Width() - rectangle2.Width, ((Control)this).get_Height());
			}
			finally
			{
				((IDisposable)val10)?.Dispose();
			}
			Pen val11 = new Pen(tabColorScheme_0.TabItemSelectedBorder, 1f);
			try
			{
				graphics_0.DrawLine(val11, rectangle2.X, rectangle2.Y, rectangle2.X, rectangle2.Bottom);
				if (((Control)this).get_Parent() is TabControl)
				{
					graphics_0.DrawLine(val11, rectangle2.X, rectangle2.Y, 0, rectangle2.Y);
					graphics_0.DrawLine(val11, rectangle2.X, rectangle2.Bottom - 1, 0, rectangle2.Bottom - 1);
				}
			}
			finally
			{
				((IDisposable)val11)?.Dispose();
			}
			break;
		}
		case eTabStripAlignment.Top:
		{
			SolidBrush val4 = new SolidBrush(color);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val4, rectangle2.X, rectangle2.Bottom, rectangle2.Width, ((Control)this).get_Height() - rectangle.Bottom);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			if (selectedTab == null)
			{
				break;
			}
			Pen val5 = new Pen(tabColorScheme_0.TabItemSelectedBorder, 1f);
			try
			{
				Rectangle displayRectangle = selectedTab.DisplayRectangle;
				displayRectangle.Width += displayRectangle.Height;
				displayRectangle.X -= displayRectangle.Height - 1;
				if (Boolean_7 && displayRectangle.Right > class26_0.rectangle_0.X)
				{
					displayRectangle.Width -= displayRectangle.Right - class26_0.rectangle_0.X + 2;
				}
				graphics_0.DrawLine(val5, rectangle2.X, rectangle2.Bottom, displayRectangle.X - 1, rectangle2.Bottom);
				graphics_0.DrawLine(val5, displayRectangle.Right + 1, rectangle2.Bottom, rectangle2.Right, rectangle2.Bottom);
				if (((Control)this).get_Parent() is TabControl)
				{
					graphics_0.DrawLine(val5, rectangle2.X, rectangle2.Bottom, rectangle2.X, ((Control)this).get_ClientRectangle().Bottom);
					graphics_0.DrawLine(val5, rectangle2.Right - 1, rectangle2.Bottom, rectangle2.Right - 1, ((Control)this).get_ClientRectangle().Bottom);
				}
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			break;
		}
		}
		rectangle = method_4(((Control)this).get_DisplayRectangle(), class26_0.bool_5, bool_25: true);
		Rectangle rectangle3 = rectangle;
		graphics_0.SetClip(rectangle);
		bool flag = true;
		bool flag2 = tabsCollection_0.Count > 0;
		int num2 = 0;
		bool flag3 = false;
		if (eTabStripAlignment_0 == eTabStripAlignment.Left || (Boolean_1 && (eTabStripAlignment_0 == eTabStripAlignment.Top || eTabStripAlignment_0 == eTabStripAlignment.Bottom)))
		{
			num2 = tabsCollection_0.Count - 1;
			flag3 = true;
		}
		int num3 = -1;
		while (flag2)
		{
			TabItem tabItem = tabsCollection_0[num2];
			if (flag3)
			{
				num2--;
				if (num2 < 0)
				{
					flag2 = false;
				}
			}
			else
			{
				num2++;
				if (num2 >= tabsCollection_0.Count)
				{
					flag2 = false;
				}
			}
			if (!tabItem.Visible || !rectangle.IntersectsWith(tabItem.DisplayRectangle))
			{
				continue;
			}
			if (Boolean_4)
			{
				RenderTabItemEventArgs renderTabItemEventArgs = new RenderTabItemEventArgs(tabItem, graphics_0);
				method_19(renderTabItemEventArgs);
				if (renderTabItemEventArgs.Cancel)
				{
					continue;
				}
			}
			TabColors tabColors = method_44(tabItem);
			Rectangle rectangle_ = tabItem.DisplayRectangle;
			if (eTabStripAlignment_0 == eTabStripAlignment.Right)
			{
				rectangle_.Height--;
			}
			if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
			{
				if (num3 == -1)
				{
					num3 = tabItem.DisplayRectangle.Y;
				}
				if (num3 != tabItem.DisplayRectangle.Y)
				{
					num3 = tabItem.DisplayRectangle.Y;
					flag = true;
				}
				GraphicsPath val12 = method_8(rectangle_, 2, eTabStripAlignment_0, bool_24: true);
				Region clip = graphics_0.get_Clip();
				if (!flag && tabItem != tabItem_0)
				{
					if (eTabStripAlignment_0 == eTabStripAlignment.Top)
					{
						graphics_0.SetClip(new Rectangle(rectangle_.X + 1, rectangle_.Y, rectangle_.Width + 1, rectangle_.Height), (CombineMode)0);
					}
					else
					{
						graphics_0.SetClip(new Rectangle(rectangle_.X + 1, rectangle_.Y + 1, rectangle_.Width + 1, rectangle_.Height + 1), (CombineMode)0);
					}
				}
				else
				{
					Rectangle rectangle4 = rectangle_;
					rectangle4.Width += rectangle4.Height;
					rectangle4.X -= rectangle4.Height;
					rectangle4.Width++;
					rectangle4.Height++;
					if (eTabStripAlignment_0 == eTabStripAlignment.Bottom && flag && tabItem != tabItem_0)
					{
						rectangle4.Y++;
					}
					graphics_0.SetClip(rectangle4, (CombineMode)0);
				}
				method_5(graphics_0);
				if (tabColors.BackColor2.IsEmpty)
				{
					SolidBrush val13 = new SolidBrush(tabColors.BackColor);
					try
					{
						graphics_0.FillPath((Brush)(object)val13, val12);
					}
					finally
					{
						((IDisposable)val13)?.Dispose();
					}
				}
				else
				{
					LinearGradientBrush val14 = Class109.smethod_41(val12.GetBounds(), tabColors.BackColor, tabColors.BackColor2, (eTabStripAlignment_0 == eTabStripAlignment.Top) ? tabColors.BackColorGradientAngle : (-tabColors.BackColorGradientAngle));
					try
					{
						graphics_0.FillPath((Brush)(object)val14, val12);
					}
					finally
					{
						((IDisposable)val14)?.Dispose();
					}
				}
				val12 = method_8(rectangle_, 2, eTabStripAlignment_0, bool_24: false);
				Pen val15 = new Pen(tabColors.BorderColor, 1f);
				try
				{
					graphics_0.DrawPath(val15, val12);
				}
				finally
				{
					((IDisposable)val15)?.Dispose();
				}
				if (class26_0.bool_5 && Boolean_7 && val12.GetBounds().IntersectsWith(class26_0.rectangle_0))
				{
					Region val16 = new Region(val12);
					val16.Intersect(class26_0.rectangle_0);
					RectangleF bounds = val16.GetBounds(graphics_0);
					val16.Dispose();
					Pen val17 = new Pen(tabColors.BorderColor, 1f);
					try
					{
						val17.set_DashPattern(new float[2] { 2f, 2f });
						graphics_0.DrawLine(val17, bounds.X - 1f, bounds.Y, bounds.X - 1f, bounds.Bottom);
						graphics_0.DrawLine(val17, bounds.X - 2f, bounds.Y + 2f, bounds.X - 2f, bounds.Bottom);
					}
					finally
					{
						((IDisposable)val17)?.Dispose();
					}
				}
				else if (val12.GetBounds().X < -1f && val12.GetBounds().Right > 0f)
				{
					RectangleF bounds2 = val12.GetBounds();
					Pen val18 = new Pen(tabColors.BorderColor, 1f);
					try
					{
						val18.set_DashPattern(new float[2] { 2f, 2f });
						graphics_0.DrawLine(val18, 0f, bounds2.Y, 0f, bounds2.Bottom);
						graphics_0.DrawLine(val18, 1f, bounds2.Y + 2f, 1f, bounds2.Bottom);
					}
					finally
					{
						((IDisposable)val18)?.Dispose();
					}
				}
				Rectangle rectangle_2 = rectangle_;
				if (eTabStripAlignment_0 == eTabStripAlignment.Top)
				{
					rectangle_2.Offset(1, 1);
					rectangle_2.X--;
					rectangle_2.Width--;
				}
				else
				{
					rectangle_2.Offset(1, -1);
					rectangle_2.X--;
					rectangle_2.Width--;
				}
				val12 = method_8(rectangle_2, 1, eTabStripAlignment_0, bool_24: false);
				if (!tabColors.LightBorderColor.IsEmpty)
				{
					RectangleF bounds3 = val12.GetBounds();
					bounds3.Height -= 1f;
					Region val19 = graphics_0.get_Clip().Clone();
					graphics_0.SetClip(bounds3, (CombineMode)1);
					Pen val20 = new Pen(tabColors.LightBorderColor, 1f);
					try
					{
						graphics_0.DrawPath(val20, val12);
					}
					finally
					{
						((IDisposable)val20)?.Dispose();
					}
					graphics_0.SetClip(val19, (CombineMode)0);
				}
				if (!tabColors.DarkBorderColor.IsEmpty)
				{
					RectangleF bounds4 = val12.GetBounds();
					bounds4.X = bounds4.Right - 1f;
					bounds4.Width = 2f;
					bounds4.Height -= 1f;
					graphics_0.SetClip(clip, (CombineMode)0);
					graphics_0.SetClip(bounds4, (CombineMode)1);
					Pen val21 = new Pen(tabColors.DarkBorderColor, 1f);
					try
					{
						graphics_0.DrawPath(val21, val12);
					}
					finally
					{
						((IDisposable)val21)?.Dispose();
					}
				}
				graphics_0.SetClip(clip, (CombineMode)0);
				rectangle_.Offset(0, 1);
				if (bool_17 && tabItem.CloseButtonVisible)
				{
					tabItem.CloseButtonBounds = method_7(graphics_0, bool_24: false, tabItem.CloseButtonMouseOver, tabItem == tabItem_1 || tabItem == SelectedTab, ref rectangle_);
				}
				else
				{
					tabItem.CloseButtonBounds = Rectangle.Empty;
				}
				Image image = tabItem.GetImage();
				Icon icon = tabItem.Icon;
				if (icon != null)
				{
					Rectangle rectangle5 = new Rectangle(rectangle_.X + rectangle_.Height / 3 + ((eTabStripAlignment_0 == eTabStripAlignment.Top) ? (-2) : 0), rectangle_.Y + (rectangle_.Height - tabItem.IconSize.Height) / 2, tabItem.IconSize.Width, tabItem.IconSize.Height);
					if (rectangle3.Contains(rectangle5))
					{
						graphics_0.DrawIcon(icon, rectangle5);
					}
					rectangle_.X += tabItem.IconSize.Width + 2;
					rectangle_.Width -= tabItem.IconSize.Width + 2;
				}
				else if (image != null)
				{
					graphics_0.DrawImage(image, rectangle_.X + rectangle_.Height / 3 + ((eTabStripAlignment_0 == eTabStripAlignment.Top) ? (-2) : 0), rectangle_.Y + (rectangle_.Height - image.get_Height()) / 2, image.get_Width(), image.get_Height());
					rectangle_.X += image.get_Width() + 2;
					rectangle_.Width -= image.get_Width() + 2;
				}
				rectangle_.Inflate(0, -1);
				rectangle_.Width -= 4;
				if (eTabStripStyle_0 == eTabStripStyle.OneNote)
				{
					rectangle_.X += 3;
				}
				if (!bool_12 || tabItem == tabItem_0)
				{
					Font font = ((Control)this).get_Font();
					if (tabItem == selectedTab && font_0 != null)
					{
						font = font_0;
					}
					if (tabItem != selectedTab)
					{
						if (rectangle_.Width > int_3)
						{
							Class55.smethod_1(graphics_0, tabItem.Text, font, tabColors.TextColor, rectangle_, eTextFormat_);
						}
						if (bool_14 && ((Control)this).get_Focused() && tabItem == tabItem_0)
						{
							ControlPaint.DrawFocusRectangle(graphics_0, method_0(rectangle_));
						}
					}
					else
					{
						if (rectangle_.Width > int_3)
						{
							Class55.smethod_1(graphics_0, tabItem.Text, font, tabColors.TextColor, rectangle_, eTextFormat_);
						}
						if (bool_14 && ((Control)this).get_Focused() && tabItem == tabItem_0)
						{
							ControlPaint.DrawFocusRectangle(graphics_0, method_0(rectangle_));
						}
					}
				}
			}
			else
			{
				if (num3 == -1)
				{
					num3 = tabItem.DisplayRectangle.X;
				}
				if (num3 != tabItem.DisplayRectangle.X)
				{
					num3 = tabItem.DisplayRectangle.X;
					flag = true;
				}
				GraphicsPath val22 = method_8(rectangle_, 2, eTabStripAlignment_0, bool_24: true);
				Region clip2 = graphics_0.get_Clip();
				if (!flag && tabItem != tabItem_0)
				{
					if (eTabStripAlignment_0 == eTabStripAlignment.Right)
					{
						graphics_0.SetClip(new Rectangle(rectangle_.X + 1, rectangle_.Y + 1, rectangle_.Width + 1, rectangle_.Height + 1));
					}
					else
					{
						graphics_0.SetClip(new Rectangle(rectangle_.X, rectangle_.Y, rectangle_.Width - 1, rectangle_.Height));
					}
				}
				else
				{
					RectangleF bounds5 = val22.GetBounds();
					bounds5.Width += 1f;
					if (eTabStripAlignment_0 == eTabStripAlignment.Left)
					{
						if (flag && tabItem != tabItem_0)
						{
							bounds5.Width -= 1f;
						}
					}
					else
					{
						bounds5.Height += 1f;
						if (flag && tabItem != tabItem_0)
						{
							bounds5.X += 1f;
						}
					}
					graphics_0.SetClip(bounds5);
				}
				method_5(graphics_0);
				if (tabColors.BackColor2.IsEmpty)
				{
					SolidBrush val23 = new SolidBrush(tabColors.BackColor);
					try
					{
						graphics_0.FillPath((Brush)(object)val23, val22);
					}
					finally
					{
						((IDisposable)val23)?.Dispose();
					}
				}
				else
				{
					LinearGradientBrush val24 = Class109.smethod_41(val22.GetBounds(), tabColors.BackColor, tabColors.BackColor2, (eTabStripAlignment_0 == eTabStripAlignment.Left) ? (tabColors.BackColorGradientAngle - 90) : (tabColors.BackColorGradientAngle + 90));
					try
					{
						graphics_0.FillPath((Brush)(object)val24, val22);
					}
					finally
					{
						((IDisposable)val24)?.Dispose();
					}
				}
				val22 = method_8(rectangle_, 2, eTabStripAlignment_0, bool_24: false);
				Pen val25 = new Pen(tabColors.BorderColor, 1f);
				try
				{
					graphics_0.DrawPath(val25, val22);
				}
				finally
				{
					((IDisposable)val25)?.Dispose();
				}
				if (class26_0.bool_5 && Boolean_7 && val22.GetBounds().IntersectsWith(class26_0.rectangle_0))
				{
					Region val26 = new Region(val22);
					val26.Intersect(class26_0.rectangle_0);
					RectangleF bounds6 = val26.GetBounds(graphics_0);
					val26.Dispose();
					Pen val27 = new Pen(tabColors.BorderColor, 1f);
					try
					{
						val27.set_DashPattern(new float[2] { 2f, 2f });
						graphics_0.DrawLine(val27, bounds6.X, bounds6.Y - 1f, bounds6.Right, bounds6.Y - 1f);
						graphics_0.DrawLine(val27, bounds6.X + 2f, bounds6.Y - 2f, bounds6.Right, bounds6.Y - 2f);
					}
					finally
					{
						((IDisposable)val27)?.Dispose();
					}
				}
				else if (val22.GetBounds().Y < -1f && val22.GetBounds().Bottom > 0f)
				{
					RectangleF bounds7 = val22.GetBounds();
					Pen val28 = new Pen(tabColors.BorderColor, 1f);
					try
					{
						val28.set_DashPattern(new float[2] { 2f, 2f });
						graphics_0.DrawLine(val28, bounds7.X, 0f, bounds7.Right, 0f);
						graphics_0.DrawLine(val28, bounds7.X + 2f, 1f, bounds7.Right, 1f);
					}
					finally
					{
						((IDisposable)val28)?.Dispose();
					}
				}
				Rectangle rectangle_3 = rectangle_;
				if (eTabStripAlignment_0 == eTabStripAlignment.Right)
				{
					rectangle_3.Offset(-1, 0);
					rectangle_3.Height--;
				}
				else
				{
					rectangle_3.Offset(1, 0);
					rectangle_3.Height--;
					rectangle_3.Y++;
				}
				val22 = method_8(rectangle_3, 1, eTabStripAlignment_0, bool_24: false);
				Pen val29 = new Pen(tabColors.LightBorderColor, 1f);
				try
				{
					graphics_0.DrawPath(val29, val22);
				}
				finally
				{
					((IDisposable)val29)?.Dispose();
				}
				if (!tabColors.DarkBorderColor.IsEmpty)
				{
					RectangleF bounds8 = val22.GetBounds();
					if (eTabStripAlignment_0 == eTabStripAlignment.Right)
					{
						bounds8.Y = bounds8.Bottom - 1f;
						bounds8.Height = 2f;
					}
					else
					{
						bounds8.Height = 2f;
						bounds8.Width -= 2f;
					}
					graphics_0.SetClip(bounds8);
					method_5(graphics_0);
					Pen val30 = new Pen(tabColors.DarkBorderColor, 1f);
					try
					{
						graphics_0.DrawPath(val30, val22);
					}
					finally
					{
						((IDisposable)val30)?.Dispose();
					}
				}
				graphics_0.SetClip(clip2, (CombineMode)0);
				if (bool_17 && tabItem.CloseButtonVisible)
				{
					rectangle_.Y += 3;
					rectangle_.Height -= 3;
					tabItem.CloseButtonBounds = method_7(graphics_0, bool_24: true, tabItem.CloseButtonMouseOver, tabItem == tabItem_1 || tabItem == SelectedTab, ref rectangle_);
				}
				else
				{
					tabItem.CloseButtonBounds = Rectangle.Empty;
				}
				Image image2 = tabItem.GetImage();
				Icon icon2 = tabItem.Icon;
				if (icon2 != null)
				{
					Rectangle rectangle6 = new Rectangle(rectangle_.X + (rectangle_.Width - tabItem.IconSize.Width) / 2, rectangle_.Y + 6, tabItem.IconSize.Width, tabItem.IconSize.Height);
					if (rectangle3.Contains(rectangle6))
					{
						graphics_0.DrawIcon(icon2, rectangle6);
					}
					rectangle_.Y += tabItem.IconSize.Height + 2;
					rectangle_.Height -= tabItem.IconSize.Height + 2;
				}
				else if (image2 != null)
				{
					graphics_0.DrawImage(image2, rectangle_.X + (rectangle_.Width - image2.get_Width()) / 2, rectangle_.Y + 6, image2.get_Width(), image2.get_Height());
					rectangle_.Y += image2.get_Height() + 2;
					rectangle_.Height -= image2.get_Height() + 2;
				}
				rectangle_.Inflate(0, -1);
				rectangle_.Height -= 4;
				if (eTabStripStyle_0 == eTabStripStyle.OneNote)
				{
					rectangle_.Y += 3;
				}
				graphics_0.RotateTransform(90f);
				if (!bool_12 || tabItem == tabItem_0)
				{
					Font font2 = ((Control)this).get_Font();
					if (tabItem == selectedTab && font_0 != null)
					{
						font2 = font_0;
					}
					if (tabItem != selectedTab)
					{
						Rectangle rectangle_4 = new Rectangle(rectangle_.Top, -rectangle_.Right, rectangle_.Height, rectangle_.Width);
						if (rectangle_4.Height > int_3)
						{
							Class55.smethod_2(graphics_0, tabItem.Text, font2, tabColors.TextColor, rectangle_4, eTextFormat_);
						}
						if (bool_14 && ((Control)this).get_Focused() && tabItem == tabItem_0)
						{
							ControlPaint.DrawFocusRectangle(graphics_0, method_0(rectangle_4));
						}
					}
					else
					{
						Rectangle rectangle_5 = new Rectangle(rectangle_.Top, -rectangle_.Right, rectangle_.Height, rectangle_.Width);
						if (rectangle_5.Height > int_3)
						{
							Class55.smethod_2(graphics_0, tabItem.Text, font2, tabColors.TextColor, rectangle_5, eTextFormat_);
						}
						if (bool_14 && ((Control)this).get_Focused() && tabItem == tabItem_0)
						{
							ControlPaint.DrawFocusRectangle(graphics_0, method_0(rectangle_5));
						}
					}
					graphics_0.ResetTransform();
				}
				if (tabItem != selectedTab)
				{
					graphics_0.DrawLine(new Pen(color_2, 1f), tabItem.DisplayRectangle.X + 1, tabItem.DisplayRectangle.Bottom, tabItem.DisplayRectangle.Right - 4, tabItem.DisplayRectangle.Bottom);
					if (!color_3.IsEmpty)
					{
						graphics_0.DrawLine(new Pen(color_3, 1f), tabItem.DisplayRectangle.X + 1 + 1, tabItem.DisplayRectangle.Bottom + 1, tabItem.DisplayRectangle.Right - 4 + 1, tabItem.DisplayRectangle.Bottom + 1);
					}
				}
			}
			if (Boolean_5)
			{
				RenderTabItemEventArgs renderTabItemEventArgs_ = new RenderTabItemEventArgs(tabItem, graphics_0);
				method_20(renderTabItemEventArgs_);
			}
			flag = false;
		}
		graphics_0.ResetClip();
		if (Boolean_7 && class26_0.bool_5)
		{
			class26_0.method_9(graphics_0);
		}
	}

	private Rectangle method_7(Graphics graphics_0, bool bool_24, bool bool_25, bool bool_26, ref Rectangle rectangle_1)
	{
		Size size = size_2;
		bool flag;
		int num = ((flag = eTabCloseButtonPosition_0 == eTabCloseButtonPosition.Left) ? 2 : 4);
		Rectangle empty = Rectangle.Empty;
		empty = (flag ? ((!bool_24) ? new Rectangle(rectangle_1.X + num, rectangle_1.Y + (rectangle_1.Height - size.Height) / 2, size.Width, size.Height) : new Rectangle(rectangle_1.X + (rectangle_1.Width - size.Width) / 2, rectangle_1.Y + num, size.Width, size.Height)) : ((!bool_24) ? new Rectangle(rectangle_1.Right - num - size.Width, rectangle_1.Y + (rectangle_1.Height - size.Height) / 2, size.Width, size.Height) : new Rectangle(rectangle_1.X + (rectangle_1.Width - size.Width) / 2, rectangle_1.Bottom - num - size.Height, size.Width, size.Height)));
		if (bool_26 || bool_18)
		{
			Class36.smethod_0(graphics_0, empty, bool_25, this);
		}
		if (bool_24)
		{
			if (flag)
			{
				rectangle_1.Y += empty.Height + num;
			}
			rectangle_1.Height -= empty.Height + num;
		}
		else
		{
			if (flag)
			{
				rectangle_1.X += empty.Width + num;
			}
			rectangle_1.Width -= empty.Width + num;
		}
		return empty;
	}

	private GraphicsPath method_8(Rectangle rectangle_1, int int_6, eTabStripAlignment eTabStripAlignment_1, bool bool_24)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		Rectangle rectangle = rectangle_1;
		switch (eTabStripAlignment_1)
		{
		case eTabStripAlignment.Left:
			rectangle = new Rectangle(rectangle_1.X, rectangle_1.Y, rectangle_1.Height, rectangle_1.Width);
			break;
		case eTabStripAlignment.Right:
			rectangle = new Rectangle(rectangle_1.Right - rectangle_1.Height, rectangle_1.Y, rectangle_1.Height, rectangle_1.Width);
			break;
		}
		GraphicsPath val = new GraphicsPath();
		Point[] array = new Point[4];
		array[0].X = rectangle.X + 2 - (rectangle.Height + 1);
		array[0].Y = rectangle.Bottom - 1;
		array[1].X = array[0].X + 3;
		array[1].Y = array[0].Y - 2;
		array[2].X = array[1].X + rectangle.Height - 6;
		array[2].Y = rectangle.Y + 3;
		array[3].X = array[2].X + 4;
		array[3].Y = rectangle.Y + 1;
		val.AddCurve(array, 0, 3, 0.5f);
		val.AddLine(array[3].X + 1, rectangle.Y, rectangle.Right - int_6, rectangle.Y);
		val.AddLine(rectangle.Right - int_6, rectangle.Y, rectangle.Right, rectangle.Y + int_6);
		val.AddLine(rectangle.Right, rectangle.Y + int_6, rectangle.Right, rectangle.Bottom - 1);
		if (bool_24)
		{
			val.AddLine(array[0].X, rectangle.Bottom, rectangle.Right, rectangle.Bottom);
			val.CloseAllFigures();
		}
		switch (eTabStripAlignment_1)
		{
		case eTabStripAlignment.Bottom:
			val.Dispose();
			val = new GraphicsPath();
			array = new Point[4];
			array[0].X = rectangle.X + 2 - (rectangle.Height + 1);
			array[0].Y = rectangle.Top + 1;
			array[1].X = array[0].X + 3;
			array[1].Y = array[0].Y + 2;
			array[2].X = array[1].X + rectangle.Height - 6;
			array[2].Y = rectangle.Bottom - 3;
			array[3].X = array[2].X + 4;
			array[3].Y = rectangle.Bottom - 1;
			val.AddCurve(array, 0, 3, 0.5f);
			val.AddLine(array[3].X + 1, rectangle.Bottom, rectangle.Right - int_6, rectangle.Bottom);
			val.AddLine(rectangle.Right - int_6, rectangle.Bottom, rectangle.Right, rectangle.Bottom - int_6);
			val.AddLine(rectangle.Right, rectangle.Bottom - int_6, rectangle.Right, rectangle.Y + 1);
			if (bool_24)
			{
				val.AddLine(array[0].X, rectangle.Y, rectangle.Right, rectangle.Y);
				val.CloseAllFigures();
			}
			break;
		case eTabStripAlignment.Left:
		{
			Matrix val3 = new Matrix();
			val3.RotateAt(-90f, new PointF(rectangle.X, rectangle.Bottom));
			val3.Translate((float)rectangle.Height, (float)(rectangle.Width - rectangle.Height), (MatrixOrder)1);
			val.Transform(val3);
			break;
		}
		case eTabStripAlignment.Right:
		{
			Matrix val2 = new Matrix();
			val2.RotateAt(90f, new PointF(rectangle.Right, rectangle.Bottom));
			val2.Translate((float)(-rectangle.Height), (float)(rectangle.Width - (rectangle.Height - 1)), (MatrixOrder)1);
			val.Transform(val2);
			break;
		}
		}
		return val;
	}

	private void method_9(Graphics graphics_0)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		if (class59_0 == null)
		{
			method_24();
		}
		if (tabColorScheme_0.TabBackground.IsEmpty)
		{
			class59_0.method_0(graphics_0, Class119.class119_9, Class144.class144_0, ((Control)this).get_ClientRectangle());
		}
		else if (!tabColorScheme_0.TabBackground2.IsEmpty && ((Control)this).get_Width() > 0 && ((Control)this).get_Height() > 0)
		{
			LinearGradientBrush val = Class109.smethod_40(((Control)this).get_ClientRectangle(), tabColorScheme_0.TabBackground, tabColorScheme_0.TabBackground2, tabColorScheme_0.TabBackgroundGradientAngle);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			SolidBrush val2 = new SolidBrush(tabColorScheme_0.TabBackground);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val2, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		Rectangle rectangle = method_4(((Control)this).get_DisplayRectangle(), bool_24: false, bool_25: false);
		TabItem selectedTab = SelectedTab;
		eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		if (bool_0)
		{
			method_16(graphics_0, rectangle);
		}
		if (((Control)this).get_Parent() is TabControl)
		{
			if (eTabStripAlignment_0 == eTabStripAlignment.Top)
			{
				class59_0.method_0(graphics_0, Class119.class119_8, Class144.class144_1, new Rectangle(0, rectangle.Bottom, ((Control)this).get_ClientRectangle().Width, ((Control)this).get_ClientRectangle().Height));
			}
			else
			{
				Size size = new Size(((Control)this).get_Width(), 5);
				if (eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right)
				{
					size = new Size(((Control)this).get_Height(), 5);
				}
				Bitmap val3 = new Bitmap(size.Width, size.Height, graphics_0);
				try
				{
					Graphics val4 = Graphics.FromImage((Image)(object)val3);
					try
					{
						class59_0.method_0(val4, Class119.class119_8, Class144.class144_1, new Rectangle(0, 0, size.Width, size.Height));
					}
					finally
					{
						val4.Dispose();
					}
					if (eTabStripAlignment_0 == eTabStripAlignment.Left)
					{
						((Image)val3).RotateFlip((RotateFlipType)3);
						graphics_0.DrawImageUnscaled((Image)(object)val3, rectangle.Right, 0);
					}
					else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
					{
						((Image)val3).RotateFlip((RotateFlipType)1);
						graphics_0.DrawImageUnscaled((Image)(object)val3, rectangle.X - ((Image)val3).get_Width(), 0);
					}
					else if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
					{
						((Image)val3).RotateFlip((RotateFlipType)2);
						graphics_0.DrawImageUnscaled((Image)(object)val3, 0, rectangle.Y - ((Image)val3).get_Height());
					}
				}
				finally
				{
					((Image)val3).Dispose();
				}
			}
		}
		if (eTabStripAlignment_0 == eTabStripAlignment.Top)
		{
			rectangle.Height++;
		}
		Rectangle clip = rectangle;
		if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
		{
			clip.Y--;
			clip.Height++;
		}
		else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
		{
			clip.Width++;
		}
		else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
		{
			clip.X--;
			clip.Width++;
		}
		if (Boolean_7)
		{
			if (eTabStripAlignment_0 != eTabStripAlignment.Right && eTabStripAlignment_0 != 0)
			{
				clip.Width -= class26_0.rectangle_0.Width;
			}
			else
			{
				clip.Height -= class26_0.rectangle_0.Height;
			}
		}
		graphics_0.SetClip(clip);
		foreach (TabItem item in tabsCollection_0)
		{
			if (!item.Visible || !rectangle.IntersectsWith(item.DisplayRectangle))
			{
				continue;
			}
			if (Boolean_4)
			{
				RenderTabItemEventArgs renderTabItemEventArgs = new RenderTabItemEventArgs(item, graphics_0);
				method_19(renderTabItemEventArgs);
				if (renderTabItemEventArgs.Cancel)
				{
					continue;
				}
			}
			Rectangle displayRectangle = item.DisplayRectangle;
			Rectangle rectangle2 = new Rectangle(0, 0, displayRectangle.Width, displayRectangle.Height);
			if (eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right)
			{
				rectangle2 = new Rectangle(0, 0, displayRectangle.Height, displayRectangle.Width);
			}
			if (item == selectedTab)
			{
				if (eTabStripAlignment_0 == eTabStripAlignment.Top)
				{
					rectangle2.Height += 2;
				}
				else if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
				{
					rectangle2.Height += 2;
					displayRectangle.Y--;
				}
				else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
				{
					rectangle2.Height += 2;
					displayRectangle.X--;
				}
				else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
				{
					rectangle2.Height += 2;
					displayRectangle.X--;
				}
			}
			Bitmap val5 = new Bitmap(rectangle2.Width, rectangle2.Height, graphics_0);
			try
			{
				Graphics val6 = Graphics.FromImage((Image)(object)val5);
				try
				{
					SolidBrush val7 = new SolidBrush(Color.Transparent);
					try
					{
						val6.FillRectangle((Brush)(object)val7, 0, 0, ((Image)val5).get_Width(), ((Image)val5).get_Height());
					}
					finally
					{
						((IDisposable)val7)?.Dispose();
					}
					if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
					{
						method_10(val6, rectangle2, item, eTextFormat_, rectangle2, bool_24: true, bool_25: false);
						((Image)val5).RotateFlip((RotateFlipType)2);
						method_10(val6, rectangle2, item, eTextFormat_, rectangle2, bool_24: false, bool_25: true);
					}
					else
					{
						method_10(val6, rectangle2, item, eTextFormat_, rectangle2, bool_24: true, bool_25: true);
					}
				}
				finally
				{
					val6.Dispose();
				}
			}
			finally
			{
				if (eTabStripAlignment_0 == eTabStripAlignment.Left)
				{
					((Image)val5).RotateFlip((RotateFlipType)3);
				}
				else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
				{
					((Image)val5).RotateFlip((RotateFlipType)1);
				}
				graphics_0.DrawImageUnscaled((Image)(object)val5, displayRectangle);
				((Image)val5).Dispose();
			}
			if (Boolean_5)
			{
				RenderTabItemEventArgs renderTabItemEventArgs_ = new RenderTabItemEventArgs(item, graphics_0);
				method_20(renderTabItemEventArgs_);
			}
		}
		graphics_0.ResetClip();
		if (Boolean_7 && class26_0.bool_5)
		{
			graphics_0.SetClip(class26_0.rectangle_0);
			SolidBrush val8 = new SolidBrush(tabColorScheme_0.TabBackground);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val8, class26_0.rectangle_0);
			}
			finally
			{
				((IDisposable)val8)?.Dispose();
			}
			class26_0.method_9(graphics_0);
			graphics_0.ResetClip();
		}
	}

	private void method_10(Graphics graphics_0, Rectangle rectangle_1, TabItem tabItem_4, eTextFormat eTextFormat_0, Rectangle rectangle_2, bool bool_24, bool bool_25)
	{
		TabColors tabColors = method_44(tabItem_4);
		Class144 class144_ = Class144.class144_2;
		if (tabItem_1 == tabItem_4)
		{
			class144_ = Class144.class144_3;
		}
		else if (tabItem_4 == tabItem_0)
		{
			class144_ = Class144.class144_4;
		}
		if (bool_24)
		{
			if (tabItem_4 == tabItem_0)
			{
				class59_0.method_0(graphics_0, Class119.class119_0, class144_, new Rectangle(rectangle_1.X, rectangle_1.Y, rectangle_1.Width, rectangle_1.Height + 1));
			}
			else
			{
				class59_0.method_0(graphics_0, Class119.class119_0, class144_, new Rectangle(rectangle_1.X, rectangle_1.Y, rectangle_1.Width, rectangle_1.Height + 1));
			}
		}
		rectangle_1.Offset(0, 1);
		if (!bool_25)
		{
			return;
		}
		if (bool_17 && tabItem_4.CloseButtonVisible)
		{
			Rectangle closeButtonBounds = method_7(graphics_0, eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right, tabItem_4.CloseButtonMouseOver, tabItem_4 == tabItem_1 || tabItem_4 == SelectedTab, ref rectangle_1);
			closeButtonBounds.Offset(tabItem_4.DisplayRectangle.Location);
			tabItem_4.CloseButtonBounds = closeButtonBounds;
		}
		else
		{
			tabItem_4.CloseButtonBounds = Rectangle.Empty;
		}
		Image image = tabItem_4.GetImage();
		Icon icon = tabItem_4.Icon;
		if ((image != null && image.get_Width() + 4 <= rectangle_1.Width) || (icon != null && tabItem_4.IconSize.Width + 4 <= rectangle_1.Width))
		{
			if (icon != null)
			{
				Rectangle rectangle = new Rectangle(rectangle_1.X + 4, rectangle_1.Y + (rectangle_1.Height - tabItem_4.IconSize.Height) / 2, tabItem_4.IconSize.Width, tabItem_4.IconSize.Height);
				if (rectangle_2.Contains(rectangle))
				{
					graphics_0.DrawIcon(icon, rectangle);
				}
				rectangle_1.X += tabItem_4.IconSize.Width + 2;
				rectangle_1.Width -= tabItem_4.IconSize.Width + 2;
			}
			else if (image != null)
			{
				graphics_0.DrawImage(image, rectangle_1.X + 4, rectangle_1.Y + (rectangle_1.Height - image.get_Height()) / 2, image.get_Width(), image.get_Height());
				rectangle_1.X += image.get_Width() + 2;
				rectangle_1.Width -= image.get_Width() + 2;
			}
			rectangle_1.Inflate(0, -1);
			rectangle_1.Width -= 4;
			rectangle_1.X += 3;
		}
		if (!bool_12 || tabItem_4 == tabItem_0)
		{
			Font font = ((Control)this).get_Font();
			if (tabItem_4 == tabItem_0 && font_0 != null)
			{
				font = font_0;
			}
			if (rectangle_1.Width > int_3)
			{
				Class55.smethod_1(graphics_0, tabItem_4.Text, font, tabColors.TextColor, rectangle_1, eTextFormat_0);
			}
			if (bool_14 && ((Control)this).get_Focused() && tabItem_4 == tabItem_0)
			{
				ControlPaint.DrawFocusRectangle(graphics_0, method_0(rectangle_1));
			}
		}
	}

	private void method_11(Graphics graphics_0)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected O, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_0d3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		if (!tabColorScheme_0.TabBackground2.IsEmpty && ((Control)this).get_Width() > 0 && ((Control)this).get_Height() > 0)
		{
			LinearGradientBrush val = Class109.smethod_40(((Control)this).get_ClientRectangle(), tabColorScheme_0.TabBackground, tabColorScheme_0.TabBackground2, tabColorScheme_0.TabBackgroundGradientAngle);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			SolidBrush val2 = new SolidBrush(tabColorScheme_0.TabBackground);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val2, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		Rectangle rectangle = method_4(((Control)this).get_DisplayRectangle(), bool_24: false, bool_25: false);
		Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
		if (bool_0)
		{
			method_16(graphics_0, rectangle);
		}
		TabItem selectedTab = SelectedTab;
		Rectangle rectangle2 = Rectangle.Empty;
		if (selectedTab != null)
		{
			rectangle2 = selectedTab.DisplayRectangle;
		}
		eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		switch (eTabStripAlignment_0)
		{
		case eTabStripAlignment.Left:
		{
			Pen val4 = new Pen(tabColorScheme_0.TabItemSelectedBorder, 1f);
			try
			{
				if (!rectangle2.IsEmpty)
				{
					graphics_0.DrawLine(val4, displayRectangle.Right - 1, displayRectangle.Y, displayRectangle.Right - 1, rectangle2.Y);
					graphics_0.DrawLine(val4, displayRectangle.Right - 1, rectangle2.Bottom - 1, displayRectangle.Right - 1, displayRectangle.Bottom);
				}
				else
				{
					graphics_0.DrawLine(val4, displayRectangle.Right - 1, displayRectangle.Y, displayRectangle.Right - 1, displayRectangle.Bottom);
				}
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			rectangle.Width--;
			break;
		}
		case eTabStripAlignment.Right:
		{
			Pen val6 = new Pen(tabColorScheme_0.TabItemSelectedBorder, 1f);
			try
			{
				if (!rectangle2.IsEmpty)
				{
					graphics_0.DrawLine(val6, displayRectangle.X, displayRectangle.Y, displayRectangle.X, rectangle2.Y);
					graphics_0.DrawLine(val6, displayRectangle.X, rectangle2.Bottom - 1, displayRectangle.X, displayRectangle.Bottom);
				}
				else
				{
					graphics_0.DrawLine(val6, displayRectangle.X, displayRectangle.Y, displayRectangle.X, displayRectangle.Bottom);
				}
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
			rectangle.Width--;
			rectangle.X++;
			break;
		}
		case eTabStripAlignment.Top:
		{
			Pen val5 = new Pen(tabColorScheme_0.TabItemSelectedBorder, 1f);
			try
			{
				if (!rectangle2.IsEmpty)
				{
					graphics_0.DrawLine(val5, displayRectangle.X, rectangle.Bottom, rectangle2.X, rectangle.Bottom);
					graphics_0.DrawLine(val5, rectangle2.Right - 1, rectangle.Bottom, displayRectangle.Right, rectangle.Bottom);
				}
				else
				{
					graphics_0.DrawLine(val5, displayRectangle.X, displayRectangle.Bottom - 1, displayRectangle.Right, displayRectangle.Bottom - 1);
				}
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			break;
		}
		case eTabStripAlignment.Bottom:
		{
			Pen val3 = new Pen(tabColorScheme_0.TabItemSelectedBorder, 1f);
			try
			{
				if (!rectangle2.IsEmpty)
				{
					graphics_0.DrawLine(val3, displayRectangle.X, displayRectangle.Y, rectangle2.X, displayRectangle.Y);
					graphics_0.DrawLine(val3, rectangle2.Right - 1, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y);
				}
				else
				{
					graphics_0.DrawLine(val3, displayRectangle.X, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y);
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			rectangle.Y++;
			rectangle.Height--;
			break;
		}
		}
		if (Boolean_7 && class26_0.bool_5)
		{
			if (eTabStripAlignment_0 != eTabStripAlignment.Right && eTabStripAlignment_0 != 0)
			{
				rectangle.Width -= class26_0.rectangle_0.Width;
				if (Boolean_1)
				{
					rectangle.X += class26_0.rectangle_0.Width;
				}
			}
			else
			{
				rectangle.Height -= class26_0.rectangle_0.Height;
			}
		}
		Rectangle clip = rectangle;
		if (eTabStripAlignment_0 == eTabStripAlignment.Right)
		{
			clip.Width++;
		}
		graphics_0.SetClip(clip);
		foreach (TabItem item in tabsCollection_0)
		{
			if (!item.Visible || !rectangle.IntersectsWith(item.DisplayRectangle))
			{
				continue;
			}
			if (Boolean_4)
			{
				RenderTabItemEventArgs renderTabItemEventArgs = new RenderTabItemEventArgs(item, graphics_0);
				method_19(renderTabItemEventArgs);
				if (renderTabItemEventArgs.Cancel)
				{
					continue;
				}
			}
			Rectangle rectangle_ = item.DisplayRectangle;
			TabColors tabColors = method_44(item);
			GraphicsPath val7 = new GraphicsPath();
			switch (eTabStripAlignment_0)
			{
			case eTabStripAlignment.Left:
				rectangle_.Height--;
				val7.AddLine(rectangle_.X + 2, rectangle_.Y, rectangle_.Right, rectangle_.Y);
				val7.AddLine(rectangle_.Right, rectangle_.Bottom, rectangle_.X + 2, rectangle_.Bottom);
				val7.AddLine(rectangle_.X, rectangle_.Bottom - 2, rectangle_.X, rectangle_.Y + 2);
				val7.CloseAllFigures();
				break;
			case eTabStripAlignment.Right:
				rectangle_.Height--;
				rectangle_.Width -= 2;
				val7.AddLine(rectangle_.X, rectangle_.Y, rectangle_.Right - 2, rectangle_.Y);
				val7.AddLine(rectangle_.Right, rectangle_.Y + 2, rectangle_.Right, rectangle_.Bottom - 2);
				val7.AddLine(rectangle_.Right - 2, rectangle_.Bottom, rectangle_.X, rectangle_.Bottom);
				val7.CloseAllFigures();
				break;
			case eTabStripAlignment.Top:
				rectangle_.Width--;
				val7.AddLine(rectangle_.X + 2, rectangle_.Y, rectangle_.Right - 2, rectangle_.Y);
				val7.AddLine(rectangle_.Right, rectangle_.Y + 2, rectangle_.Right, rectangle_.Bottom);
				val7.AddLine(rectangle_.Right, rectangle_.Bottom, rectangle_.X, rectangle_.Bottom);
				val7.AddLine(rectangle_.X, rectangle_.Y + 2, rectangle_.X + 2, rectangle_.Y);
				val7.CloseAllFigures();
				break;
			case eTabStripAlignment.Bottom:
				rectangle_.Width--;
				val7.AddLine(rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
				val7.AddLine(rectangle_.Right, rectangle_.Y, rectangle_.Right, rectangle_.Bottom - 2);
				val7.AddLine(rectangle_.Right - 2, rectangle_.Bottom, rectangle_.X + 2, rectangle_.Bottom);
				val7.AddLine(rectangle_.X, rectangle_.Bottom - 2, rectangle_.X, rectangle_.Y);
				val7.CloseAllFigures();
				break;
			}
			if (tabColors.BackColor2.IsEmpty)
			{
				if (!tabColors.BackColor.IsEmpty)
				{
					SolidBrush val8 = new SolidBrush(tabColors.BackColor);
					try
					{
						graphics_0.FillPath((Brush)(object)val8, val7);
					}
					finally
					{
						((IDisposable)val8)?.Dispose();
					}
				}
			}
			else
			{
				LinearGradientBrush val9 = Class109.smethod_40(rectangle_, tabColors.BackColor, tabColors.BackColor2, tabColors.BackColorGradientAngle);
				try
				{
					graphics_0.FillPath((Brush)(object)val9, val7);
				}
				finally
				{
					((IDisposable)val9)?.Dispose();
				}
			}
			if (!tabColors.BorderColor.IsEmpty)
			{
				Pen val10 = new Pen(tabColors.BorderColor, 1f);
				try
				{
					graphics_0.DrawPath(val10, val7);
				}
				finally
				{
					((IDisposable)val10)?.Dispose();
				}
			}
			if (bool_17 && item.CloseButtonVisible)
			{
				item.CloseButtonBounds = method_7(graphics_0, eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right, item.CloseButtonMouseOver, item == tabItem_1 || item == SelectedTab, ref rectangle_);
			}
			else
			{
				item.CloseButtonBounds = Rectangle.Empty;
			}
			Class271 @class = method_12(item);
			if (@class != null && @class.Int32_0 + 4 <= rectangle_.Width)
			{
				if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
				{
					@class.method_0(graphics_0, new Rectangle(rectangle_.X + (rectangle_.Width - @class.Int32_0) / 2, rectangle_.Y + 3, @class.Int32_0, @class.Int32_1));
					int num = @class.Int32_1 + 2;
					rectangle_.Y += num;
					rectangle_.Height -= num;
				}
				else
				{
					@class.method_0(graphics_0, new Rectangle(rectangle_.X + 3, rectangle_.Y + (rectangle_.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
					int num2 = @class.Int32_0 + 2;
					rectangle_.X += num2;
					rectangle_.Width -= num2;
				}
			}
			if (!bool_12 || item == tabItem_0)
			{
				Font font = ((Control)this).get_Font();
				if (item == selectedTab && font_0 != null)
				{
					font = font_0;
				}
				Rectangle rectangle3 = rectangle_;
				if (eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right)
				{
					graphics_0.RotateTransform(90f);
					rectangle3 = new Rectangle(rectangle3.Top, -rectangle3.Right, rectangle3.Height, rectangle3.Width);
				}
				if (rectangle3.Width > int_3)
				{
					if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
					{
						Class55.smethod_1(graphics_0, item.Text, font, tabColors.TextColor, rectangle3, eTextFormat_);
					}
					else
					{
						Class55.smethod_2(graphics_0, item.Text, font, tabColors.TextColor, rectangle3, eTextFormat_);
					}
				}
				if (eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right)
				{
					graphics_0.ResetTransform();
				}
				if (bool_14 && ((Control)this).get_Focused() && item == selectedTab)
				{
					ControlPaint.DrawFocusRectangle(graphics_0, method_0(rectangle_));
				}
			}
			if (!item.IsSelected && tabsCollection_0.IndexOf(item) < tabsCollection_0.Count - 1 && tabsCollection_0.IndexOf(item) + 1 != tabsCollection_0.IndexOf(tabItem_0))
			{
				if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
				{
					Class50.smethod_32(graphics_0, item.DisplayRectangle.Right - 1, item.DisplayRectangle.Y + 3, item.DisplayRectangle.Right - 1, item.DisplayRectangle.Bottom - 3, tabColorScheme_0.TabItemSeparator, 1);
					Class50.smethod_32(graphics_0, item.DisplayRectangle.Right, item.DisplayRectangle.Y + 3, item.DisplayRectangle.Right, item.DisplayRectangle.Bottom - 3, tabColorScheme_0.TabItemSeparatorShade, 1);
				}
				else
				{
					Class50.smethod_32(graphics_0, item.DisplayRectangle.X + 3, item.DisplayRectangle.Bottom - 1, item.DisplayRectangle.Right - 3, item.DisplayRectangle.Bottom - 1, tabColorScheme_0.TabItemSeparator, 1);
					Class50.smethod_32(graphics_0, item.DisplayRectangle.X + 3, item.DisplayRectangle.Bottom, item.DisplayRectangle.Right - 3, item.DisplayRectangle.Bottom, tabColorScheme_0.TabItemSeparatorShade, 1);
				}
			}
			if (Boolean_5)
			{
				RenderTabItemEventArgs renderTabItemEventArgs_ = new RenderTabItemEventArgs(item, graphics_0);
				method_20(renderTabItemEventArgs_);
			}
		}
		graphics_0.ResetClip();
		if (Boolean_7 && class26_0.bool_5)
		{
			graphics_0.SetClip(class26_0.rectangle_0);
			SolidBrush val11 = new SolidBrush(tabColorScheme_0.TabBackground);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val11, class26_0.rectangle_0);
			}
			finally
			{
				((IDisposable)val11)?.Dispose();
			}
			class26_0.method_9(graphics_0);
			graphics_0.ResetClip();
		}
	}

	private Class271 method_12(TabItem tabItem_4)
	{
		Image image = tabItem_4.GetImage();
		if (image != null)
		{
			return new Class271(image, dispose: false);
		}
		Icon icon = tabItem_4.Icon;
		if (icon != null)
		{
			return new Class271(icon, dispose: false, tabItem_4.IconSize);
		}
		return null;
	}

	internal void ResetTabHeight()
	{
		int_5 = 0;
	}

	private int method_13()
	{
		if (Boolean_8)
		{
			int result = 0;
			if (Class109.smethod_11((Control)(object)this))
			{
				Graphics val = ((Control)this).CreateGraphics();
				try
				{
					return method_14(val);
				}
				finally
				{
					val.Dispose();
				}
			}
			return result;
		}
		return Int32_0;
	}

	private int method_14(Graphics graphics_0)
	{
		if (size_0.Height > 0)
		{
			return size_0.Height;
		}
		int num = 16;
		if ((eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right) && eTabStripStyle_0 != eTabStripStyle.OneNote && eTabStripStyle_0 != eTabStripStyle.VS2005Document && eTabStripStyle_0 != eTabStripStyle.Office2007Document)
		{
			num = 20;
		}
		if (imageList_0 != null)
		{
			num = imageList_0.get_ImageSize().Height;
		}
		else
		{
			Font font = ((Control)this).get_Font();
			if (font_0 != null)
			{
				font = font_0;
			}
			foreach (TabItem item in tabsCollection_0)
			{
				if (item.Icon != null && item.Icon.get_Height() > num)
				{
					num = item.IconSize.Height;
				}
				else if (item.Image != null && item.Image.get_Height() > num)
				{
					num = item.Image.get_Height();
				}
				string text = item.Text;
				if (text != "")
				{
					Size empty = Size.Empty;
					empty = ((!Boolean_0) ? Class55.smethod_3(graphics_0, item.Text, font) : Class55.smethod_7(graphics_0, item.Text, font, Size.Empty, eTextFormat.Default));
					if (empty.Height > num)
					{
						num = empty.Height;
					}
				}
			}
		}
		if (((Control)this).get_Font().get_Height() > num)
		{
			num = ((Control)this).get_Font().get_Height();
		}
		num += 4;
		if (Boolean_13)
		{
			num++;
		}
		return num;
	}

	public void RecalcSize()
	{
		if (!Class109.smethod_11((Control)(object)this))
		{
			bool_0 = true;
			return;
		}
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			method_16(val, method_4(((Control)this).get_DisplayRectangle(), TabLayoutType == eTabLayoutType.MultilineWithNavigationBox, bool_25: false));
		}
		finally
		{
			val.Dispose();
		}
	}

	private void method_15(Graphics graphics_0, Rectangle rectangle_1)
	{
		if (Tabs.Count == 0)
		{
			if (Boolean_1)
			{
				method_22(rectangle_1, Rectangle.Empty);
			}
			else
			{
				method_22(rectangle_1, Rectangle.Empty);
			}
			return;
		}
		SerialContentLayoutManager serialContentLayoutManager = new SerialContentLayoutManager();
		TabItemLayoutManager tabItemLayoutManager = new TabItemLayoutManager(this);
		tabItemLayoutManager.FixedTabSize = size_0;
		tabItemLayoutManager.CloseButtonOnTabs = bool_17;
		tabItemLayoutManager.CloseButtonSize = size_2;
		serialContentLayoutManager.RightToLeft = Boolean_1;
		if (eTabStripStyle_0 == eTabStripStyle.RoundHeader)
		{
			serialContentLayoutManager.ContentAlignment = eContentAlignment.Center;
			serialContentLayoutManager.EvenHeight = true;
			serialContentLayoutManager.FitContainerOversize = true;
		}
		else if (eTabStripStyle_0 == eTabStripStyle.Office2007Document)
		{
			serialContentLayoutManager.EvenHeight = true;
			if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Top)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Bottom;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Bottom;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Right;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
			}
			serialContentLayoutManager.BlockSpacing = 0;
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				rectangle_1.Height -= 2;
			}
			else
			{
				rectangle_1.Width -= 2;
			}
			tabItemLayoutManager.PaddingHeight = 6;
		}
		else if (eTabStripStyle_0 == eTabStripStyle.Office2007Dock)
		{
			serialContentLayoutManager.EvenHeight = true;
			if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Top)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Bottom;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Bottom;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Right;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
			}
			serialContentLayoutManager.BlockSpacing = 2;
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				rectangle_1.Y += 2;
				rectangle_1.Height -= 2;
			}
			else
			{
				rectangle_1.X += 2;
				rectangle_1.Width -= 2;
			}
			tabItemLayoutManager.PaddingHeight = 6;
		}
		else if (eTabStripStyle_0 == eTabStripStyle.VS2005Dock)
		{
			serialContentLayoutManager.EvenHeight = true;
			if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Top)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Bottom;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Bottom;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Right;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
			}
			serialContentLayoutManager.BlockSpacing = 8;
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				rectangle_1.Y += 4;
				rectangle_1.Height -= 8;
			}
			else
			{
				rectangle_1.X += 4;
				rectangle_1.Width -= 8;
			}
		}
		else if (eTabStripStyle_0 == eTabStripStyle.SimulatedTheme)
		{
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				rectangle_1.Height -= 3;
			}
			else
			{
				rectangle_1.Width -= 3;
			}
			if (eTabStripAlignment_0 == eTabStripAlignment.Bottom)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
				serialContentLayoutManager.EvenHeight = true;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Top)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Bottom;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Bottom;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
				serialContentLayoutManager.EvenHeight = true;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Right;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
				serialContentLayoutManager.EvenHeight = true;
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Right)
			{
				serialContentLayoutManager.ContentAlignment = eContentAlignment.Left;
				serialContentLayoutManager.ContentVerticalAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.BlockLineAlignment = eContentVerticalAlignment.Top;
				serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
				serialContentLayoutManager.EvenHeight = true;
			}
			tabItemLayoutManager.HorizontalText = true;
			tabItemLayoutManager.PaddingHeight = 10;
			tabItemLayoutManager.PaddingWidth = 2;
		}
		if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
		{
			serialContentLayoutManager.ContentOrientation = eContentOrientation.Horizontal;
		}
		else
		{
			serialContentLayoutManager.ContentOrientation = eContentOrientation.Vertical;
		}
		if (eTabStripStyle_0 != eTabStripStyle.RoundHeader)
		{
			if (eTabLayoutType_0 == eTabLayoutType.FitContainer)
			{
				serialContentLayoutManager.FitContainerOversize = true;
				serialContentLayoutManager.OversizeDistribute = true;
				serialContentLayoutManager.MultiLine = false;
			}
			else if (eTabLayoutType_0 == eTabLayoutType.FixedWithNavigationBox)
			{
				serialContentLayoutManager.FitContainerOversize = false;
				serialContentLayoutManager.MultiLine = false;
			}
			else if (eTabLayoutType_0 == eTabLayoutType.MultilineNoNavigationBox || eTabLayoutType_0 == eTabLayoutType.MultilineWithNavigationBox)
			{
				serialContentLayoutManager.FitContainerOversize = false;
				serialContentLayoutManager.MultiLine = true;
			}
		}
		tabItemLayoutManager.Graphics = graphics_0;
		TabItem[] array = new TabItem[Tabs.Count];
		Tabs.CopyTo(array, 0);
		Rectangle rectangle = rectangle_1;
		if (int_0 != 0)
		{
			if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
			{
				rectangle.X -= int_0;
			}
			else
			{
				rectangle.Y -= int_0;
			}
		}
		if (Boolean_1)
		{
			if (Boolean_7 && class26_0.bool_5)
			{
				rectangle.X += class26_0.int_0;
			}
			rectangle_0 = serialContentLayoutManager.Layout(rectangle, array, tabItemLayoutManager);
			method_22(rectangle_1, rectangle);
		}
		else
		{
			rectangle_0 = serialContentLayoutManager.Layout(rectangle, array, tabItemLayoutManager);
			method_22(rectangle_1, rectangle_0);
		}
	}

	private void method_16(Graphics graphics_0, Rectangle rectangle_1)
	{
		if (Boolean_2)
		{
			method_15(graphics_0, rectangle_1);
		}
		else
		{
			method_17(graphics_0, rectangle_1);
		}
		bool_0 = false;
		method_23();
	}

	private void method_17(Graphics graphics_0, Rectangle rectangle_1)
	{
		int num = rectangle_1.Width;
		int num2 = 0;
		int num3 = 0;
		int num4 = -1;
		eTextFormat eTextFormat_ = eTextFormat.Default;
		if (eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right)
		{
			num = rectangle_1.Height;
		}
		int num5 = (int_5 = method_14(graphics_0));
		int num6 = rectangle_1.X;
		int num7 = rectangle_1.Y;
		if (eTabStripAlignment_0 == eTabStripAlignment.Top)
		{
			num7 = rectangle_1.Bottom - num5;
		}
		else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
		{
			num6 = rectangle_1.Right - num5;
		}
		if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
		{
			num6 -= int_0;
		}
		else
		{
			num7 -= int_0;
		}
		int num8 = num6;
		int num9 = num7;
		bool flag = false;
		if (Boolean_7)
		{
			num -= class26_0.int_0;
			num -= 4;
		}
		ArrayList arrayList = new ArrayList();
		foreach (TabItem item in tabsCollection_0)
		{
			int num10 = 4;
			if (!item.Visible)
			{
				continue;
			}
			if (num4 < 0)
			{
				num4 = tabsCollection_0.IndexOf(item);
			}
			num3++;
			if (size_0.Width == 0)
			{
				Image image = item.GetImage();
				if (item.Icon != null)
				{
					num10 += item.IconSize.Width;
					if (eTabStripStyle_0 != eTabStripStyle.OneNote || Boolean_13)
					{
						num10 += 4;
					}
				}
				else if (image != null)
				{
					num10 += image.get_Width();
					if (eTabStripStyle_0 != eTabStripStyle.OneNote || Boolean_13)
					{
						num10 += 4;
					}
				}
				if (eTabStripStyle_0 == eTabStripStyle.OneNote && !Boolean_13)
				{
					num10 += num5 - 6;
				}
				else if (eTabStripStyle_0 == eTabStripStyle.VS2005Document && !Boolean_13)
				{
					num10 += 4;
				}
				if (item.Text != "" && (!bool_12 || item == tabItem_0))
				{
					Font font = ((Control)this).get_Font();
					if (font_0 != null && item == tabItem_0)
					{
						font = font_0;
					}
					Size empty = Size.Empty;
					num10 += ((!Boolean_0) ? Class55.smethod_4(graphics_0, item.Text, font, 0, eTextFormat_) : Class55.smethod_7(graphics_0, item.Text, font, Size.Empty, eTextFormat_)).Width;
					if ((eTabStripStyle_0 != eTabStripStyle.OneNote && eTabStripStyle_0 != eTabStripStyle.VS2005Document) || Boolean_13 || eTabStripAlignment_0 == eTabStripAlignment.Top || eTabStripAlignment_0 == eTabStripAlignment.Bottom)
					{
						num10 += 4;
					}
					if (Boolean_13)
					{
						num10 += 10;
					}
				}
				if (bool_17 && item.CloseButtonVisible && eTabStripStyle_0 != eTabStripStyle.OneNote)
				{
					num10 += size_2.Width;
				}
			}
			else
			{
				num10 = size_0.Width;
			}
			if (Boolean_8 && num2 + num10 > num && num3 > 1)
			{
				flag = true;
				switch (eTabStripAlignment_0)
				{
				case eTabStripAlignment.Left:
				case eTabStripAlignment.Right:
					if (arrayList.Count == 0)
					{
						arrayList.Add(num6);
					}
					num6 += num5 + int_4;
					num7 = num9;
					arrayList.Add(num6);
					break;
				case eTabStripAlignment.Top:
				case eTabStripAlignment.Bottom:
					if (arrayList.Count == 0)
					{
						arrayList.Add(num7);
					}
					num7 += num5 + int_4;
					num6 = num8;
					arrayList.Add(num7);
					break;
				}
				int_5 += num5 + int_4;
				num2 = 0;
			}
			if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
			{
				item._DisplayRectangle = new Rectangle(num6, num7, num10, num5);
			}
			else
			{
				item._DisplayRectangle = new Rectangle(num6, num7, num5, num10);
			}
			if (measureTabItemEventHandler_0 != null)
			{
				MeasureTabItemEventArgs measureTabItemEventArgs = new MeasureTabItemEventArgs(item, item.DisplayRectangle.Size);
				measureTabItemEventHandler_0(this, measureTabItemEventArgs);
				item._DisplayRectangle = new Rectangle(item._DisplayRectangle.Location, measureTabItemEventArgs.Size);
				num10 = ((eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right) ? measureTabItemEventArgs.Size.Height : measureTabItemEventArgs.Size.Width);
			}
			if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
			{
				num6 += num10;
			}
			else
			{
				num7 += num10;
			}
			num2 += num10;
		}
		if (flag)
		{
			if (eTabStripAlignment_0 == eTabStripAlignment.Top)
			{
				int num11 = num9 - num7;
				foreach (TabItem item2 in tabsCollection_0)
				{
					item2._DisplayRectangle = new Rectangle(item2.DisplayRectangle.X, item2.DisplayRectangle.Y + num11, item2.DisplayRectangle.Width, item2.DisplayRectangle.Height);
				}
				for (int i = 0; i < arrayList.Count; i++)
				{
					arrayList[i] = (int)arrayList[i] + num11;
				}
			}
			else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
			{
				int num12 = num8 - num6;
				foreach (TabItem item3 in tabsCollection_0)
				{
					item3._DisplayRectangle = new Rectangle(item3.DisplayRectangle.X + num12, item3.DisplayRectangle.Y, item3.DisplayRectangle.Width, item3.DisplayRectangle.Height);
				}
				for (int j = 0; j < arrayList.Count; j++)
				{
					arrayList[j] = (int)arrayList[j] + num12;
				}
			}
			switch (eTabStripAlignment_0)
			{
			case eTabStripAlignment.Left:
			{
				if (tabItem_0.DisplayRectangle.X == (int)arrayList[arrayList.Count - 1])
				{
					break;
				}
				int x2 = tabItem_0.DisplayRectangle.X;
				int num16 = (int)arrayList[arrayList.Count - 1];
				foreach (TabItem item4 in tabsCollection_0)
				{
					if (item4.DisplayRectangle.X == num16)
					{
						item4._DisplayRectangle = new Rectangle(x2, item4.DisplayRectangle.Y, item4.DisplayRectangle.Width, item4.DisplayRectangle.Height);
					}
					else if (item4.DisplayRectangle.X == x2)
					{
						item4._DisplayRectangle = new Rectangle(num16, item4.DisplayRectangle.Y, item4.DisplayRectangle.Width, item4.DisplayRectangle.Height);
					}
				}
				break;
			}
			case eTabStripAlignment.Right:
			{
				if (tabItem_0.DisplayRectangle.X == (int)arrayList[0])
				{
					break;
				}
				int x = tabItem_0.DisplayRectangle.X;
				int num14 = (int)arrayList[0];
				foreach (TabItem item5 in tabsCollection_0)
				{
					if (item5.DisplayRectangle.X == num14)
					{
						item5._DisplayRectangle = new Rectangle(x, item5.DisplayRectangle.Y, item5.DisplayRectangle.Width, item5.DisplayRectangle.Height);
					}
					else if (item5.DisplayRectangle.X == x)
					{
						item5._DisplayRectangle = new Rectangle(num14, item5.DisplayRectangle.Y, item5.DisplayRectangle.Width, item5.DisplayRectangle.Height);
					}
				}
				break;
			}
			case eTabStripAlignment.Top:
			{
				if (tabItem_0.DisplayRectangle.Y == (int)arrayList[arrayList.Count - 1])
				{
					break;
				}
				int y2 = tabItem_0.DisplayRectangle.Y;
				int num15 = (int)arrayList[arrayList.Count - 1];
				foreach (TabItem item6 in tabsCollection_0)
				{
					if (item6.DisplayRectangle.Y == num15)
					{
						item6._DisplayRectangle = new Rectangle(item6.DisplayRectangle.X, y2, item6.DisplayRectangle.Width, item6.DisplayRectangle.Height);
					}
					else if (item6.DisplayRectangle.Y == y2)
					{
						item6._DisplayRectangle = new Rectangle(item6.DisplayRectangle.X, num15, item6.DisplayRectangle.Width, item6.DisplayRectangle.Height);
					}
				}
				break;
			}
			case eTabStripAlignment.Bottom:
			{
				if (tabItem_0.DisplayRectangle.Y == (int)arrayList[0])
				{
					break;
				}
				int y = tabItem_0.DisplayRectangle.Y;
				int num13 = (int)arrayList[0];
				foreach (TabItem item7 in tabsCollection_0)
				{
					if (item7.DisplayRectangle.Y == num13)
					{
						item7._DisplayRectangle = new Rectangle(item7.DisplayRectangle.X, y, item7.DisplayRectangle.Width, item7.DisplayRectangle.Height);
					}
					else if (item7.DisplayRectangle.Y == y)
					{
						item7._DisplayRectangle = new Rectangle(item7.DisplayRectangle.X, num13, item7.DisplayRectangle.Width, item7.DisplayRectangle.Height);
					}
				}
				break;
			}
			}
		}
		if (Boolean_7)
		{
			if (int_0 != 0)
			{
				class26_0.Boolean_2 = true;
			}
			else
			{
				class26_0.Boolean_2 = false;
			}
			if (num2 - int_0 > num)
			{
				class26_0.Boolean_1 = true;
			}
			else
			{
				class26_0.Boolean_1 = false;
			}
			if (bool_15 && !Boolean_8)
			{
				if (num2 > num)
				{
					class26_0.bool_5 = true;
				}
				else
				{
					class26_0.bool_5 = false;
				}
			}
			else
			{
				class26_0.bool_5 = true;
			}
			Rectangle rectangle = Rectangle.Empty;
			switch (eTabStripAlignment_0)
			{
			default:
				rectangle = ((!Boolean_1) ? new Rectangle(((Control)this).get_ClientRectangle().Right - class26_0.int_0 - 2, rectangle_1.Y, class26_0.int_0 + 2, (num4 < 0) ? rectangle_1.Height : tabsCollection_0[num4].DisplayRectangle.Height) : new Rectangle(((Control)this).get_ClientRectangle().Left, rectangle_1.Y, class26_0.int_0 + 2, (num4 < 0) ? rectangle_1.Height : tabsCollection_0[num4].DisplayRectangle.Height));
				if (eTabStripStyle_0 == eTabStripStyle.VS2005 && !Boolean_13)
				{
					rectangle.Y++;
				}
				break;
			case eTabStripAlignment.Left:
				rectangle = new Rectangle((num4 < 0) ? rectangle_1.X : tabsCollection_0[num4].DisplayRectangle.X, ((Control)this).get_ClientRectangle().Bottom - class26_0.int_0 - 3, (num4 < 0) ? rectangle_1.Width : tabsCollection_0[num4].DisplayRectangle.Width, class26_0.int_0);
				if (eTabStripStyle_0 == eTabStripStyle.VS2005 && !Boolean_13)
				{
					rectangle.X--;
				}
				break;
			case eTabStripAlignment.Right:
				rectangle = new Rectangle(rectangle_1.X, ((Control)this).get_ClientRectangle().Bottom - class26_0.int_0 - 3, (num4 < 0) ? rectangle_1.Width : tabsCollection_0[num4].DisplayRectangle.Width, class26_0.int_0);
				if (eTabStripStyle_0 == eTabStripStyle.VS2005 && !Boolean_13)
				{
					rectangle.X++;
				}
				break;
			case eTabStripAlignment.Top:
				rectangle = ((!Boolean_1) ? new Rectangle(((Control)this).get_ClientRectangle().Right - class26_0.int_0 - 3, (num4 < 0) ? rectangle_1.Y : tabsCollection_0[num4].DisplayRectangle.Y, class26_0.int_0, (num4 < 0) ? rectangle_1.Height : tabsCollection_0[num4].DisplayRectangle.Height) : new Rectangle(((Control)this).get_ClientRectangle().Left, (num4 < 0) ? rectangle_1.Y : tabsCollection_0[num4].DisplayRectangle.Y, class26_0.int_0, (num4 < 0) ? rectangle_1.Height : tabsCollection_0[num4].DisplayRectangle.Height));
				if (eTabStripStyle_0 == eTabStripStyle.VS2005 && !Boolean_13)
				{
					rectangle.Y--;
				}
				break;
			}
			class26_0.rectangle_0 = rectangle;
		}
		if (num2 > num && eTabLayoutType_0 == eTabLayoutType.FitContainer && !Boolean_8)
		{
			if (num3 <= 0)
			{
				return;
			}
			if (eTabStripAlignment_0 != 0 && eTabStripAlignment_0 != eTabStripAlignment.Right)
			{
				num6 = rectangle_1.X;
				int num17 = num / num3;
				int num18 = 0;
				foreach (TabItem item8 in tabsCollection_0)
				{
					if (item8.Visible)
					{
						if (item8.DisplayRectangle.Width > num17)
						{
							num18++;
							continue;
						}
						num -= item8.DisplayRectangle.Width;
						num2 -= item8.DisplayRectangle.Width;
					}
				}
				float num19 = (float)num / (float)num2;
				{
					foreach (TabItem item9 in tabsCollection_0)
					{
						if (!item9.Visible)
						{
							continue;
						}
						if (item9.DisplayRectangle.Width > num17)
						{
							if (num18 == num3)
							{
								item9._DisplayRectangle = new Rectangle(num6, num7, num17, item9.DisplayRectangle.Height);
							}
							else
							{
								item9._DisplayRectangle = new Rectangle(num6, num7, (int)((float)item9.DisplayRectangle.Width * num19), item9.DisplayRectangle.Height);
							}
						}
						else
						{
							item9._DisplayRectangle = new Rectangle(num6, num7, item9.DisplayRectangle.Width, item9.DisplayRectangle.Height);
						}
						num6 += item9.DisplayRectangle.Width;
					}
					return;
				}
			}
			num6 = rectangle_1.X;
			num7 = rectangle_1.Y;
			if (eTabStripAlignment_0 == eTabStripAlignment.Left)
			{
				num6 = rectangle_1.Right - num5;
			}
			int num20 = num / num3;
			int num21 = 0;
			foreach (TabItem item10 in tabsCollection_0)
			{
				if (item10.Visible)
				{
					if (item10.DisplayRectangle.Height > num20)
					{
						num21++;
						continue;
					}
					num -= item10.DisplayRectangle.Height;
					num2 -= item10.DisplayRectangle.Height;
				}
			}
			float num22 = (float)num / (float)num2;
			{
				foreach (TabItem item11 in tabsCollection_0)
				{
					if (!item11.Visible)
					{
						continue;
					}
					if (item11.DisplayRectangle.Height > num20)
					{
						if (num21 == num3)
						{
							item11._DisplayRectangle = new Rectangle(num6, num7, item11.DisplayRectangle.Width, num20);
						}
						else
						{
							item11._DisplayRectangle = new Rectangle(num6, num7, item11.DisplayRectangle.Width, (int)((float)item11.DisplayRectangle.Height * num22));
						}
					}
					else
					{
						item11._DisplayRectangle = new Rectangle(num6, num7, item11.DisplayRectangle.Width, item11.DisplayRectangle.Height);
					}
					num7 += item11.DisplayRectangle.Height;
				}
				return;
			}
		}
		if (!Boolean_1 || eTabLayoutType_0 == eTabLayoutType.FitContainer || (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom))
		{
			return;
		}
		if (num2 > num)
		{
			int num23 = tabsCollection_0.Count - 1;
			while (num23 >= 0)
			{
				if (!tabsCollection_0[num23].Visible)
				{
					num23--;
					continue;
				}
				num6 = tabsCollection_0[num23].DisplayRectangle.Right;
				break;
			}
			if (class26_0.bool_5)
			{
				num6 += class26_0.rectangle_0.Right;
			}
		}
		else
		{
			num6 = rectangle_1.Right;
		}
		foreach (TabItem item12 in tabsCollection_0)
		{
			if (item12.Visible)
			{
				num6 -= item12.DisplayRectangle.Width;
				item12._DisplayRectangle = new Rectangle(num6, item12.DisplayRectangle.Y, item12.DisplayRectangle.Width, item12.DisplayRectangle.Height);
			}
		}
	}

	internal void method_18(MeasureTabItemEventArgs measureTabItemEventArgs_0)
	{
		if (measureTabItemEventHandler_0 != null)
		{
			measureTabItemEventHandler_0(this, measureTabItemEventArgs_0);
		}
	}

	internal void method_19(RenderTabItemEventArgs renderTabItemEventArgs_0)
	{
		if (renderTabItemEventHandler_0 != null)
		{
			renderTabItemEventHandler_0(this, renderTabItemEventArgs_0);
		}
	}

	internal void method_20(RenderTabItemEventArgs renderTabItemEventArgs_0)
	{
		if (renderTabItemEventHandler_1 != null)
		{
			renderTabItemEventHandler_1(this, renderTabItemEventArgs_0);
		}
	}

	private TabItem method_21()
	{
		foreach (TabItem item in tabsCollection_0)
		{
			if (item.Visible)
			{
				return item;
			}
		}
		return null;
	}

	internal void method_22(Rectangle rectangle_1, Rectangle rectangle_2)
	{
		if (!Boolean_7)
		{
			return;
		}
		Rectangle rectangle = rectangle_2;
		if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
		{
			rectangle.Offset(0, int_0);
		}
		else
		{
			rectangle.Offset(int_0, 0);
		}
		bool flag = false;
		if ((rectangle.Right > rectangle_1.Right - ((!bool_15) ? class26_0.int_0 : 0) && (eTabStripAlignment_0 == eTabStripAlignment.Top || eTabStripAlignment_0 == eTabStripAlignment.Bottom)) || (rectangle.Bottom > rectangle_1.Bottom - ((!bool_15) ? class26_0.int_0 : 0) && (eTabStripAlignment_0 == eTabStripAlignment.Right || eTabStripAlignment_0 == eTabStripAlignment.Left)))
		{
			flag = true;
		}
		if (int_0 != 0)
		{
			class26_0.Boolean_2 = true;
		}
		else
		{
			class26_0.Boolean_2 = false;
		}
		if (bool_15 && !Boolean_8)
		{
			class26_0.bool_5 = flag;
		}
		else
		{
			class26_0.bool_5 = true;
		}
		if ((rectangle_2.Right + int_0 > rectangle_1.Right - (class26_0.bool_5 ? class26_0.int_0 : 0) && (eTabStripAlignment_0 == eTabStripAlignment.Top || eTabStripAlignment_0 == eTabStripAlignment.Bottom)) || (rectangle_2.Bottom + int_0 > rectangle_1.Bottom - (class26_0.bool_5 ? class26_0.int_0 : 0) && (eTabStripAlignment_0 == eTabStripAlignment.Right || eTabStripAlignment_0 == eTabStripAlignment.Left)))
		{
			class26_0.Boolean_1 = true;
		}
		else
		{
			class26_0.Boolean_1 = false;
		}
		TabItem tabItem = method_21();
		Rectangle rectangle2 = Rectangle.Empty;
		switch (eTabStripAlignment_0)
		{
		default:
			rectangle2 = ((!Boolean_1) ? new Rectangle(((Control)this).get_ClientRectangle().Right - class26_0.int_0 - 2, rectangle_1.Y, class26_0.int_0 + 2, tabItem?.DisplayRectangle.Height ?? rectangle_1.Height) : new Rectangle(rectangle_1.X, rectangle_1.Y, class26_0.int_0 + 2, tabItem?.DisplayRectangle.Height ?? rectangle_1.Height));
			if (eTabStripStyle_0 == eTabStripStyle.VS2005 && !Boolean_13)
			{
				rectangle2.Y++;
			}
			break;
		case eTabStripAlignment.Left:
			rectangle2 = new Rectangle(tabItem?.DisplayRectangle.X ?? rectangle_1.X, ((Control)this).get_ClientRectangle().Bottom - class26_0.int_0 - 3, tabItem?.DisplayRectangle.Width ?? rectangle_1.Width, class26_0.int_0);
			if (eTabStripStyle_0 == eTabStripStyle.VS2005 && !Boolean_13)
			{
				rectangle2.X--;
			}
			break;
		case eTabStripAlignment.Right:
			rectangle2 = new Rectangle(rectangle_1.X, ((Control)this).get_ClientRectangle().Bottom - class26_0.int_0 - 3, tabItem?.DisplayRectangle.Width ?? rectangle_1.Width, class26_0.int_0);
			if (eTabStripStyle_0 == eTabStripStyle.VS2005 && !Boolean_13)
			{
				rectangle2.X++;
			}
			break;
		case eTabStripAlignment.Top:
			rectangle2 = ((!Boolean_1) ? new Rectangle(((Control)this).get_ClientRectangle().Right - class26_0.int_0 - 3, tabItem?.DisplayRectangle.Y ?? rectangle_1.Y, class26_0.int_0, tabItem?.DisplayRectangle.Height ?? rectangle_1.Height) : new Rectangle(rectangle_1.X, tabItem?.DisplayRectangle.Y ?? rectangle_1.Y, class26_0.int_0, tabItem?.DisplayRectangle.Height ?? rectangle_1.Height));
			if (eTabStripStyle_0 == eTabStripStyle.VS2005 && !Boolean_13)
			{
				rectangle2.Y--;
			}
			break;
		}
		class26_0.rectangle_0 = rectangle2;
	}

	private void method_23()
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(this, new EventArgs());
		}
		if (Boolean_8 && !(((Control)this).get_Parent() is TabControl))
		{
			switch (TabAlignment)
			{
			default:
				((Control)this).set_Height(MinTabStripHeight);
				break;
			case eTabStripAlignment.Left:
			case eTabStripAlignment.Right:
				((Control)this).set_Width(MinTabStripHeight);
				break;
			}
		}
	}

	private void method_24()
	{
		if (class59_0 != null)
		{
			class59_0.Dispose();
		}
		class59_0 = new Class59((Control)(object)this);
	}

	private void method_25()
	{
		if (class59_0 != null)
		{
			class59_0.Dispose();
			class59_0 = null;
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 794)
		{
			Class58.smethod_1();
			method_24();
		}
		((Control)this).WndProc(ref m);
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_25();
		((Control)this).OnHandleDestroyed(e);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		if (bool_0)
		{
			RecalcSize();
			if (((Control)this).get_Parent() is TabControl)
			{
				((TabControl)(object)((Control)this).get_Parent()).SyncTabStripSize();
			}
		}
		method_55();
	}

	internal void method_26(int int_6, TabItem tabItem_4)
	{
		if (int_6 >= Tabs.Count)
		{
			int_6 = Tabs.Count - 1;
		}
		int num = -1;
		for (int i = int_6; i < Tabs.Count; i++)
		{
			if (Tabs[i].Visible)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			for (int j = 0; j < Tabs.Count; j++)
			{
				if (Tabs[j].Visible)
				{
					num = j;
					break;
				}
			}
		}
		if (num >= 0)
		{
			SelectedTab = Tabs[num];
		}
		else
		{
			tabItem_0 = null;
		}
	}

	internal void method_27(TabItem tabItem_4)
	{
		if (!bool_22)
		{
			HideToolTip();
			if (eventHandler_2 != null)
			{
				eventHandler_2(tabItem_4, new EventArgs());
			}
			if (Int32_1 == 0)
			{
				SelectedTab = null;
			}
		}
	}

	private void method_28(TabItem tabItem_4, eEventSource eEventSource_0)
	{
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Invalid comparison between Unknown and I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Invalid comparison between Unknown and I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		if (tabItem_0 == tabItem_4)
		{
			return;
		}
		TabItem oldtab = tabItem_0;
		if (selectedTabChangingEventHandler_0 != null)
		{
			TabStripTabChangingEventArgs tabStripTabChangingEventArgs = new TabStripTabChangingEventArgs(tabItem_0, tabItem_4, eEventSource_0);
			selectedTabChangingEventHandler_0(this, tabStripTabChangingEventArgs);
			if (tabStripTabChangingEventArgs.Cancel)
			{
				return;
			}
		}
		method_41(tabItem_4);
		Control val = null;
		if (tabItem_0 != null && tabItem_0.AttachedItem != null)
		{
			tabItem_0.AttachedItem.Displayed = false;
		}
		else if (tabItem_0 != null && tabItem_0.AttachedControl != null && !bool_6)
		{
			val = tabItem_0.AttachedControl;
		}
		tabItem_0 = tabItem_4;
		bool_0 = true;
		EnsureVisible(tabItem_0);
		if (tabItem_0 != null && tabItem_0.AttachedItem != null)
		{
			tabItem_0.AttachedItem.Displayed = true;
			if (tabItem_0.AttachedItem is DockContainerItem && ((DockContainerItem)tabItem_0.AttachedItem).Control != null && bool_20)
			{
				((DockContainerItem)tabItem_0.AttachedItem).Control.Select();
			}
		}
		else if (tabItem_0 != null && tabItem_0.AttachedControl != null)
		{
			if (!bool_6)
			{
				tabItem_0.AttachedControl.set_Visible(true);
				if (bool_20 && (!((Control)this).get_TabStop() || !(((Control)this).get_Parent() is TabControl) || !((Control)this).get_Focused() || eEventSource_0 != 0))
				{
					tabItem_0.AttachedControl.Select();
				}
				if (val == tabItem_0.AttachedControl)
				{
					val = null;
				}
			}
			else if (tabItem_0.AttachedControl is Form)
			{
				MdiClient val2 = method_58(form_0);
				bool flag = false;
				Form activeMdiChild = form_0.get_ActiveMdiChild();
				if (val2 != null && bool_10 && tabItem_0.AttachedControl is Form && ((int)((Form)tabItem_0.AttachedControl).get_WindowState() == 2 || (activeMdiChild != null && (int)activeMdiChild.get_WindowState() == 2)))
				{
					Class92.SendMessage(((Control)val2).get_Handle(), 11, 0, 0);
					flag = true;
				}
				((Form)tabItem_0.AttachedControl).Activate();
				if (flag)
				{
					Class92.SendMessage(((Control)val2).get_Handle(), 11, 1, 0);
					((Control)val2).Refresh();
				}
				if (activeMdiChild != null && (int)activeMdiChild.get_WindowState() == 0 && Class109.Boolean_0)
				{
					string text = ((Control)activeMdiChild).get_Text();
					((Control)activeMdiChild).set_Text(text + " ");
					((Control)activeMdiChild).set_Text(text);
				}
			}
		}
		if (val != null)
		{
			val.set_Visible(false);
		}
		((Control)this).Invalidate();
		if (selectedTabChangedEventHandler_0 != null)
		{
			TabStripTabChangedEventArgs e = new TabStripTabChangedEventArgs(oldtab, tabItem_0, eEventSource_0);
			selectedTabChangedEventHandler_0(this, e);
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (bool_21)
		{
			if ((int)keyData == 37)
			{
				if (method_29(eEventSource.Keyboard))
				{
					return true;
				}
			}
			else if ((int)keyData == 39 && method_30(eEventSource.Keyboard))
			{
				return true;
			}
		}
		return ((Control)this).ProcessCmdKey(ref msg, keyData);
	}

	public bool SelectPreviousTab()
	{
		return method_29(eEventSource.Code);
	}

	private bool method_29(eEventSource eEventSource_0)
	{
		if (SelectedTab != null && Tabs.IndexOf(SelectedTab) > 0)
		{
			int num = Tabs.IndexOf(SelectedTab) - 1;
			while (num >= 0)
			{
				if (!Tabs[num].Visible)
				{
					num--;
					continue;
				}
				method_28(Tabs[num], eEventSource_0);
				return true;
			}
		}
		return false;
	}

	public bool SelectNextTab()
	{
		return method_30(eEventSource.Code);
	}

	private bool method_30(eEventSource eEventSource_0)
	{
		if (SelectedTab != null && Tabs.IndexOf(SelectedTab) < Tabs.Count)
		{
			for (int i = Tabs.IndexOf(SelectedTab) + 1; i < Tabs.Count; i++)
			{
				if (Tabs[i].Visible)
				{
					method_28(Tabs[i], eEventSource_0);
					return true;
				}
			}
		}
		return false;
	}

	protected override void OnClick(EventArgs e)
	{
		((Control)this).OnClick(e);
		Point point = ((Control)this).PointToClient(Control.get_MousePosition());
		if (!Boolean_7 || !class26_0.bool_5 || !class26_0.rectangle_0.Contains(point.X, point.Y))
		{
			HitTest(point.X, point.Y)?.InvokeClick(e);
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		method_31(e);
	}

	internal void method_31(MouseEventArgs mouseEventArgs_0)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Invalid comparison between Unknown and I4
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Invalid comparison between Unknown and I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		HideToolTip();
		if (Boolean_7 && class26_0.bool_5 && class26_0.rectangle_0.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			class26_0.method_5(mouseEventArgs_0);
			return;
		}
		point_0 = new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
		if ((int)mouseEventArgs_0.get_Button() == 1048576)
		{
			Rectangle rectangle = method_33();
			foreach (TabItem item in tabsCollection_0)
			{
				if ((!item.DisplayRectangle.Contains(new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y())) && !rectangle.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y())) || !item.Visible)
				{
					continue;
				}
				TabItem tabItem2 = item;
				if (rectangle.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
				{
					tabItem2 = tabItem_0;
				}
				if (tabItem_0 != tabItem2)
				{
					TabItem oldtab = tabItem_0;
					if (selectedTabChangingEventHandler_0 != null)
					{
						TabStripTabChangingEventArgs tabStripTabChangingEventArgs = new TabStripTabChangingEventArgs(tabItem_0, tabItem2, eEventSource.Mouse);
						selectedTabChangingEventHandler_0(this, tabStripTabChangingEventArgs);
						if (tabStripTabChangingEventArgs.Cancel)
						{
							break;
						}
					}
					method_41(tabItem2);
					if (tabItem_0.AttachedItem is DockContainerItem && ((DockContainerItem)tabItem_0.AttachedItem).Control != null && ((DockContainerItem)tabItem_0.AttachedItem).Control.get_Focused())
					{
						((Control)this).Focus();
					}
					if (tabItem_0.AttachedItem != null)
					{
						tabItem_0.AttachedItem.Displayed = false;
					}
					else if (tabItem_0.AttachedControl != null && !bool_6)
					{
						tabItem_0.AttachedControl.set_Visible(false);
					}
					tabItem_0 = tabItem2;
					bool_0 = true;
					EnsureVisible(tabItem_0);
					if (tabItem_0.AttachedItem != null)
					{
						tabItem_0.AttachedItem.Displayed = true;
						if (tabItem_0.AttachedItem is DockContainerItem && ((DockContainerItem)tabItem_0.AttachedItem).Control != null && bool_20)
						{
							((DockContainerItem)tabItem_0.AttachedItem).Control.Select();
						}
					}
					else if (tabItem_0.AttachedControl != null)
					{
						if (!bool_6)
						{
							tabItem_0.AttachedControl.set_Visible(true);
							if (bool_20)
							{
								tabItem_0.AttachedControl.Select();
							}
						}
						else if (tabItem_0.AttachedControl is Form)
						{
							MdiClient val = method_58(form_0);
							bool flag = false;
							Form activeMdiChild = form_0.get_ActiveMdiChild();
							if (val != null && bool_10 && tabItem_0.AttachedControl is Form && ((int)((Form)tabItem_0.AttachedControl).get_WindowState() == 2 || (activeMdiChild != null && (int)activeMdiChild.get_WindowState() == 2)))
							{
								Class92.SendMessage(((Control)val).get_Handle(), 11, 0, 0);
								flag = true;
							}
							((Form)tabItem_0.AttachedControl).Activate();
							if (flag)
							{
								Class92.SendMessage(((Control)val).get_Handle(), 11, 1, 0);
								((Control)val).Refresh();
							}
							if (activeMdiChild != null && (int)activeMdiChild.get_WindowState() == 0 && Class109.Boolean_0)
							{
								string text = ((Control)activeMdiChild).get_Text();
								((Control)activeMdiChild).set_Text(text + " ");
								((Control)activeMdiChild).set_Text(text);
							}
						}
					}
					((Control)this).Invalidate();
					if (selectedTabChangedEventHandler_0 != null)
					{
						TabStripTabChangedEventArgs e = new TabStripTabChangedEventArgs(oldtab, tabItem_0, eEventSource.Mouse);
						selectedTabChangedEventHandler_0(this, e);
					}
				}
				else if (tabItem_0 != null && tabItem_0.AttachedItem is DockContainerItem && tabItem_0.AttachedItem.ContainerControl is Bar && ((Bar)tabItem_0.AttachedItem.ContainerControl).DockSide == eDockSide.Document && ((DockContainerItem)tabItem_0.AttachedItem).Control != null && bool_20)
				{
					((DockContainerItem)tabItem_0.AttachedItem).Control.Select();
				}
				break;
			}
		}
		HitTest(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y())?.InvokeMouseDown(mouseEventArgs_0);
	}

	private void method_32()
	{
		if (tabItem_1 == null)
		{
			return;
		}
		if (eTabStripStyle_0 != eTabStripStyle.OneNote && eTabStripStyle_0 != eTabStripStyle.VS2005Document)
		{
			if (eTabStripStyle_0 == eTabStripStyle.Office2007Document)
			{
				Rectangle displayRectangle = tabItem_1.DisplayRectangle;
				if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
				{
					displayRectangle.Height += displayRectangle.Width * 2;
					displayRectangle.Width += 2;
				}
				else
				{
					displayRectangle.Width += displayRectangle.Height * 2;
					displayRectangle.Height += 2;
				}
				((Control)this).Invalidate(displayRectangle);
			}
			else if (eTabStripStyle_0 == eTabStripStyle.VS2005Dock)
			{
				Rectangle displayRectangle2 = tabItem_1.DisplayRectangle;
				displayRectangle2.Inflate(6, 0);
				((Control)this).Invalidate(displayRectangle2);
			}
			else
			{
				Rectangle displayRectangle3 = tabItem_1.DisplayRectangle;
				displayRectangle3.Inflate(2, 2);
				((Control)this).Invalidate(displayRectangle3);
			}
		}
		else
		{
			Rectangle displayRectangle4 = tabItem_1.DisplayRectangle;
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				displayRectangle4.Y -= displayRectangle4.Width;
				displayRectangle4.Height += displayRectangle4.Width * 2;
				displayRectangle4.Width += 2;
			}
			else
			{
				displayRectangle4.X -= displayRectangle4.Height;
				displayRectangle4.Width += displayRectangle4.Height * 2;
				displayRectangle4.Height += 2;
			}
			((Control)this).Invalidate(displayRectangle4);
		}
	}

	private Rectangle method_33()
	{
		if (SelectedTab == null)
		{
			return Rectangle.Empty;
		}
		Rectangle displayRectangle = SelectedTab.DisplayRectangle;
		if (eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document)
		{
			switch (eTabStripAlignment_0)
			{
			case eTabStripAlignment.Left:
				displayRectangle.Height += displayRectangle.Width - 6;
				break;
			case eTabStripAlignment.Right:
				displayRectangle.Y -= displayRectangle.Width - 6;
				displayRectangle.Height += displayRectangle.Width - 6;
				break;
			case eTabStripAlignment.Top:
				displayRectangle.X -= displayRectangle.Height - 6;
				displayRectangle.Width += displayRectangle.Height - 6;
				break;
			case eTabStripAlignment.Bottom:
				displayRectangle.X -= displayRectangle.Height - 6;
				displayRectangle.Width += displayRectangle.Height - 6;
				break;
			}
		}
		return displayRectangle;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		method_34(e);
	}

	internal void method_34(MouseEventArgs mouseEventArgs_0)
	{
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Invalid comparison between Unknown and I4
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		if (tabItem_3 != null && !tabItem_3.DisplayRectangle.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			HideToolTip();
			method_61();
		}
		if (tabItem_1 != null)
		{
			if (tabItem_1.DisplayRectangle.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
			{
				tabItem_1.InvokeMouseMove(mouseEventArgs_0);
			}
			else
			{
				tabItem_1.InvokeMouseLeave((EventArgs)(object)mouseEventArgs_0);
				TabItem tabItem = HitTest(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
				if (tabItem != null)
				{
					tabItem.InvokeMouseEnter((EventArgs)(object)mouseEventArgs_0);
					method_61();
				}
			}
		}
		else
		{
			TabItem tabItem2 = HitTest(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
			if (tabItem2 != null)
			{
				tabItem2.InvokeMouseEnter((EventArgs)(object)mouseEventArgs_0);
				method_61();
			}
		}
		if (Boolean_7 && !Boolean_9)
		{
			class26_0.method_4(mouseEventArgs_0);
			if (class26_0.bool_5 && class26_0.rectangle_0.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
			{
				if (tabItem_1 != null)
				{
					if (tabsCollection_0.Contains(tabItem_1))
					{
						method_32();
						tabItem_1 = null;
						((Control)this).Update();
					}
					else
					{
						tabItem_1 = null;
					}
				}
				return;
			}
		}
		if (bar_0 != null)
		{
			bar_0.method_46();
		}
		else
		{
			if (bool_2)
			{
				return;
			}
			if ((int)mouseEventArgs_0.get_Button() == 1048576)
			{
				if (tabItem_1 != null && tabItem_1.CloseButtonMouseOver)
				{
					tabItem_1.CloseButtonMouseOver = false;
					method_32();
				}
				if (Boolean_9)
				{
					if (((Control)this).get_DisplayRectangle().Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
					{
						if (!bool_3 && !method_36())
						{
							return;
						}
						{
							foreach (TabItem item in tabsCollection_0)
							{
								Rectangle displayRectangle = item.DisplayRectangle;
								if (mouseEventArgs_0.get_X() < displayRectangle.Right && (eTabStripAlignment_0 == eTabStripAlignment.Bottom || eTabStripAlignment_0 == eTabStripAlignment.Top))
								{
									displayRectangle.Width = tabItem_0.DisplayRectangle.Width;
								}
								else if (mouseEventArgs_0.get_Y() < displayRectangle.Bottom && (eTabStripAlignment_0 == eTabStripAlignment.Left || eTabStripAlignment_0 == eTabStripAlignment.Right))
								{
									displayRectangle.Height = tabItem_0.DisplayRectangle.Height;
								}
								if (!displayRectangle.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
								{
									continue;
								}
								if (tabItem_0 == item)
								{
									break;
								}
								int newindex = tabsCollection_0.IndexOf(item);
								if (tabMovedEventHandler_0 != null)
								{
									TabStripTabMovedEventArgs tabStripTabMovedEventArgs = new TabStripTabMovedEventArgs(tabItem_0, tabsCollection_0.IndexOf(tabItem_0), newindex);
									tabMovedEventHandler_0(this, tabStripTabMovedEventArgs);
									if (tabStripTabMovedEventArgs.Cancel)
									{
										break;
									}
								}
								TabItem selectedTab = tabItem_0;
								bool_22 = true;
								tabsCollection_0.method_2(selectedTab);
								tabsCollection_0.method_1(newindex, selectedTab);
								SelectedTab = selectedTab;
								bool_22 = false;
								((Control)this).Refresh();
								break;
							}
							return;
						}
					}
					Rectangle displayRectangle2 = ((Control)this).get_DisplayRectangle();
					displayRectangle2.Inflate(16, 16);
					if (displayRectangle2.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
					{
						return;
					}
					int int32_ = Int32_1;
					if (((Control)this).get_Parent() is Bar && ((Bar)(object)((Control)this).get_Parent()).CanTearOffTabs && (int32_ > 1 || (int32_ == 1 && ((Bar)(object)((Control)this).get_Parent()).GrabHandleStyle == eGrabHandleStyle.None)))
					{
						Boolean_9 = false;
						bool_2 = true;
						bar_0 = ((Bar)(object)((Control)this).get_Parent()).method_62();
						if (bar_0 != null)
						{
							((Control)this).set_Capture(true);
							((Control)this).Refresh();
						}
						else
						{
							bool_2 = false;
						}
					}
				}
				else if ((Math.Abs(mouseEventArgs_0.get_X() - point_0.X) >= 4 || Math.Abs(mouseEventArgs_0.get_Y() - point_0.Y) >= 4) && tabsCollection_0.Count > 0 && !Boolean_8 && CanReorderTabs)
				{
					Boolean_9 = true;
				}
			}
			else
			{
				if ((int)mouseEventArgs_0.get_Button() != 0)
				{
					return;
				}
				if (method_33().Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
				{
					method_37(SelectedTab, mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
					return;
				}
				foreach (TabItem item2 in tabsCollection_0)
				{
					if (item2.DisplayRectangle.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
					{
						method_37(item2, mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
						return;
					}
				}
				method_37(null, mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
			}
		}
	}

	private Cursor method_35()
	{
		if (cursor_1 != (Cursor)null)
		{
			return cursor_1;
		}
		return Cursors.get_SizeAll();
	}

	private bool method_36()
	{
		if (((Control)this).get_Parent() is TabControl)
		{
			TabControl tabControl = ((Control)this).get_Parent() as TabControl;
			if (((Component)(object)tabControl).Site != null)
			{
				return ((Component)(object)tabControl).Site!.DesignMode;
			}
		}
		return ((Component)this).DesignMode;
	}

	private void method_37(TabItem tabItem_4, int int_6, int int_7)
	{
		if (tabItem_1 != tabItem_4)
		{
			if (tabsCollection_0.Contains(tabItem_1))
			{
				method_32();
			}
			if (tabItem_1 != null)
			{
				tabItem_1.CloseButtonMouseOver = false;
			}
			tabItem_1 = tabItem_4;
			if (tabItem_1 != null)
			{
				if (!tabItem_1.CloseButtonBounds.IsEmpty && tabItem_1.CloseButtonBounds.Contains(int_6, int_7))
				{
					tabItem_1.CloseButtonMouseOver = true;
				}
				method_32();
			}
			((Control)this).Update();
			method_61();
		}
		else
		{
			if (tabItem_1 == null || tabItem_1.CloseButtonBounds.IsEmpty)
			{
				return;
			}
			if (tabItem_1.CloseButtonBounds.Contains(int_6, int_7))
			{
				if (!tabItem_1.CloseButtonMouseOver)
				{
					tabItem_1.CloseButtonMouseOver = true;
					method_32();
					((Control)this).Update();
				}
			}
			else if (tabItem_1.CloseButtonMouseOver)
			{
				tabItem_1.CloseButtonMouseOver = false;
				method_32();
				((Control)this).Update();
			}
		}
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		((Control)this).OnMouseWheel(e);
		class26_0.method_7(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		method_38(e);
	}

	internal void method_38(MouseEventArgs mouseEventArgs_0)
	{
		if (Boolean_7)
		{
			class26_0.method_6(mouseEventArgs_0);
			if (class26_0.bool_5 && class26_0.rectangle_0.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
			{
				return;
			}
		}
		point_0 = Point.Empty;
		if (bool_2)
		{
			((Control)this).set_Capture(false);
		}
		if (bar_0 != null)
		{
			bar_0.method_47();
			bar_0 = null;
		}
		bool_2 = false;
		Boolean_9 = false;
		TabItem tabItem = HitTest(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
		tabItem?.InvokeMouseUp(mouseEventArgs_0);
		if (SelectedTab != null && SelectedTab == tabItem && !SelectedTab.CloseButtonBounds.IsEmpty && SelectedTab.CloseButtonBounds.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			method_50();
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		method_39(e);
		((Control)this).OnMouseLeave(e);
	}

	internal void method_39(EventArgs eventArgs_0)
	{
		HideToolTip();
		if (Boolean_7)
		{
			class26_0.method_2();
		}
		if (tabItem_1 != null)
		{
			tabItem_1.InvokeMouseLeave(eventArgs_0);
			if (tabsCollection_0.Contains(tabItem_1))
			{
				tabItem_1.CloseButtonMouseOver = false;
				method_32();
				tabItem_1 = null;
				((Control)this).Update();
			}
			else
			{
				tabItem_1 = null;
			}
		}
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		if (Boolean_7)
		{
			class26_0.method_3();
		}
		method_62();
	}

	internal void method_40()
	{
		HideToolTip();
		OnTabsCleared(new EventArgs());
		if (tabItem_0 != null)
		{
			if (selectedTabChangedEventHandler_0 != null)
			{
				TabStripTabChangedEventArgs e = new TabStripTabChangedEventArgs(tabItem_0, null, eEventSource.Code);
				selectedTabChangedEventHandler_0(this, e);
			}
			tabItem_0 = null;
		}
	}

	protected virtual void OnTabsCleared(EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
		}
	}

	public void EnsureVisible(TabItem tab)
	{
		if (tab == null || !tabsCollection_0.Contains(tab) || eTabLayoutType_0 == eTabLayoutType.FitContainer || Boolean_8 || !Class109.smethod_11((Control)(object)this))
		{
			return;
		}
		if (tab.DisplayRectangle.IsEmpty)
		{
			((Control)this).Invalidate();
			RecalcSize();
		}
		Rectangle displayRectangle = tab.DisplayRectangle;
		if (eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document || eTabStripStyle_0 == eTabStripStyle.Office2007Document)
		{
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				if (eTabStripAlignment_0 == eTabStripAlignment.Right)
				{
					if (eTabStripStyle_0 != eTabStripStyle.Office2007Document)
					{
						displayRectangle.Y -= Int32_0 - 6;
					}
					displayRectangle.Height += Int32_0 - 6;
				}
				else if (eTabStripAlignment_0 == eTabStripAlignment.Left)
				{
					displayRectangle.Height += Int32_0 - 6;
				}
			}
			else
			{
				if (eTabStripStyle_0 != eTabStripStyle.Office2007Document)
				{
					displayRectangle.X -= Int32_0 - 6;
				}
				displayRectangle.Width += Int32_0 - 6;
			}
		}
		int scrollOffset = ScrollOffset;
		if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
		{
			if (displayRectangle.Y < 0)
			{
				scrollOffset += displayRectangle.Y - 4;
				if (scrollOffset < 0)
				{
					scrollOffset = 0;
				}
				ScrollOffset = scrollOffset;
			}
			else if (displayRectangle.Bottom > class26_0.rectangle_0.Top && class26_0.bool_5 && !class26_0.rectangle_0.IsEmpty)
			{
				scrollOffset = (ScrollOffset = scrollOffset + displayRectangle.Bottom - class26_0.rectangle_0.Top + 4);
			}
		}
		else if (displayRectangle.X >= 0 && (!Boolean_1 || displayRectangle.X >= class26_0.rectangle_0.Right || !class26_0.bool_5))
		{
			if (!Boolean_1 && displayRectangle.Right > class26_0.rectangle_0.Left && class26_0.bool_5 && !class26_0.rectangle_0.IsEmpty)
			{
				scrollOffset = (ScrollOffset = scrollOffset + displayRectangle.Right - class26_0.rectangle_0.Left + 2);
			}
			else if (Boolean_1 && displayRectangle.Right > ((Control)this).get_DisplayRectangle().Right)
			{
				scrollOffset = (ScrollOffset = scrollOffset + displayRectangle.Right - ((Control)this).get_DisplayRectangle().Right + 2);
			}
		}
		else
		{
			scrollOffset += displayRectangle.X - 4;
			if (Boolean_1 && (eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document || eTabStripStyle_0 == eTabStripStyle.Office2007Document))
			{
				scrollOffset -= displayRectangle.Height;
			}
			if (scrollOffset < 0 || (Boolean_1 && scrollOffset < class26_0.rectangle_0.Right))
			{
				scrollOffset = 0;
			}
			ScrollOffset = scrollOffset;
		}
	}

	internal void method_41(TabItem tabItem_4)
	{
		if (!bool_23 && eventHandler_1 != null)
		{
			eventHandler_1(tabItem_4, new EventArgs());
		}
	}

	protected override void Dispose(bool disposing)
	{
		((Control)this).Dispose(disposing);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetSelectedTabFont()
	{
		font_0 = null;
	}

	private void method_42()
	{
		bool_0 = true;
		tabColorScheme_0.Style = eTabStripStyle_0;
		tabColorScheme_0.Boolean_0 = Boolean_13;
		tabColorScheme_0.Refresh();
		int_0 = 0;
		if ((eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document || eTabStripStyle_0 == eTabStripStyle.Office2007Document) && !Boolean_13 && eTabLayoutType_0 == eTabLayoutType.FitContainer)
		{
			eTabLayoutType_0 = eTabLayoutType.FixedWithNavigationBox;
		}
		((Control)this).Invalidate();
		EnsureVisible(SelectedTab);
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		method_42();
	}

	protected override void OnFontChanged(EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		((Control)this).OnFontChanged(e);
		int_5 = 0;
		bool_0 = true;
		if (Boolean_6)
		{
			if ((eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document || eTabStripStyle_0 == eTabStripStyle.Office2007Document) && !bool_11)
			{
				font_0 = new Font(((Control)this).get_Font(), (FontStyle)1);
			}
			((Control)this).Invalidate();
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		if (ShowFocusRectangle)
		{
			((Control)this).Invalidate();
		}
	}

	protected override void OnLostFocus(EventArgs e)
	{
		((Control)this).OnLostFocus(e);
		if (ShowFocusRectangle)
		{
			((Control)this).Invalidate();
		}
	}

	internal void method_43(TabItem tabItem_4)
	{
		bool_0 = true;
		if (tabItem_4 == tabItem_3)
		{
			HideToolTip();
		}
		if (!tabItem_4.Visible && tabItem_0 == tabItem_4)
		{
			int num = Tabs.IndexOf(tabItem_4) - 1;
			TabItem tabItem = null;
			while (num >= 0)
			{
				if (!Tabs[num].Visible)
				{
					num--;
					continue;
				}
				tabItem = Tabs[num];
				break;
			}
			if (tabItem == null)
			{
				if (num < 0)
				{
					num = 0;
				}
				for (int i = num; i < Tabs.Count; i++)
				{
					if (Tabs[i].Visible)
					{
						tabItem = Tabs[i];
						break;
					}
				}
			}
			SelectedTab = tabItem;
		}
		else if (Int32_1 == 1 && tabItem_4.Visible)
		{
			SelectedTab = tabItem_4;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeColorScheme()
	{
		return tabColorScheme_0.SchemeChanged;
	}

	public void ResetColorScheme()
	{
		tabColorScheme_0.ResetChangedFlag();
		tabColorScheme_0.Refresh();
		if (Boolean_6)
		{
			((Control)this).Invalidate();
		}
	}

	private void tabColorScheme_0_ColorChanged(object sender, EventArgs e)
	{
		if (Boolean_6 || ((Control)this).get_Parent() is TabControl)
		{
			((Control)this).Invalidate();
		}
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		string text = "&" + charCode;
		text = text.ToLower();
		foreach (TabItem tab in Tabs)
		{
			string text2 = tab.Text.ToLower();
			if (text2.IndexOf(text) >= 0)
			{
				method_28(tab, eEventSource.Keyboard);
				return true;
			}
		}
		return ((Control)this).ProcessMnemonic(charCode);
	}

	internal TabColors method_44(TabItem tabItem_4)
	{
		TabColors tabColors = new TabColors();
		if (tabItem_4 == tabItem_1)
		{
			tabColors.BackColor = tabColorScheme_0.TabItemHotBackground;
			tabColors.BackColor2 = tabColorScheme_0.TabItemHotBackground2;
			tabColors.BackColorGradientAngle = tabColorScheme_0.TabItemHotBackgroundGradientAngle;
			tabColors.TextColor = tabColorScheme_0.TabItemHotText;
			tabColors.LightBorderColor = tabColorScheme_0.TabItemHotBorderLight;
			tabColors.DarkBorderColor = tabColorScheme_0.TabItemHotBorderDark;
			tabColors.BorderColor = tabColorScheme_0.TabItemHotBorder;
			tabColors.BackgroundColorBlend.CopyFrom(tabColorScheme_0.TabItemHotBackgroundColorBlend);
		}
		if (SelectedTab == tabItem_4)
		{
			if (tabItem_4.PredefinedColor != 0)
			{
				tabColors.BackColor = tabItem_4.BackColor;
				tabColors.BackColor2 = tabItem_4.BackColor2;
				tabColors.BackColorGradientAngle = tabItem_4.BackColorGradientAngle;
			}
			if (tabColors.BackColor.IsEmpty)
			{
				tabColors.BackColor = tabColorScheme_0.TabItemSelectedBackground;
				tabColors.BackColor2 = tabColorScheme_0.TabItemSelectedBackground2;
				tabColors.BackColorGradientAngle = tabColorScheme_0.TabItemSelectedBackgroundGradientAngle;
				tabColors.BackgroundColorBlend.CopyFrom(tabColorScheme_0.TabItemSelectedBackgroundColorBlend);
			}
			if (tabColors.TextColor.IsEmpty)
			{
				if (tabColorScheme_0.TabItemSelectedText.IsEmpty)
				{
					tabColors.TextColor = tabColorScheme_0.TabItemText;
				}
				else
				{
					tabColors.TextColor = tabColorScheme_0.TabItemSelectedText;
				}
			}
			if (tabColors.BorderColor.IsEmpty)
			{
				tabColors.LightBorderColor = tabColorScheme_0.TabItemSelectedBorderLight;
				tabColors.DarkBorderColor = tabColorScheme_0.TabItemSelectedBorderDark;
				tabColors.BorderColor = tabColorScheme_0.TabItemSelectedBorder;
			}
		}
		if (tabColors.BackColor.IsEmpty)
		{
			if (tabItem_4.BackColor.IsEmpty && tabItem_4.BackColor2.IsEmpty)
			{
				tabColors.BackColor = tabColorScheme_0.TabItemBackground;
				tabColors.BackColor2 = tabColorScheme_0.TabItemBackground2;
				tabColors.BackColorGradientAngle = tabColorScheme_0.TabItemBackgroundGradientAngle;
				tabColors.BackgroundColorBlend.CopyFrom(tabColorScheme_0.TabItemBackgroundColorBlend);
			}
			else
			{
				tabColors.BackColor = tabItem_4.BackColor;
				tabColors.BackColor2 = tabItem_4.BackColor2;
				tabColors.BackColorGradientAngle = tabItem_4.BackColorGradientAngle;
			}
		}
		if (tabColors.TextColor.IsEmpty)
		{
			if (tabItem_4.TextColor.IsEmpty)
			{
				tabColors.TextColor = tabColorScheme_0.TabItemText;
			}
			else
			{
				tabColors.TextColor = tabItem_4.TextColor;
			}
		}
		if (tabColors.BorderColor.IsEmpty)
		{
			if (tabItem_4.BorderColor.IsEmpty && tabItem_4.LightBorderColor.IsEmpty && tabItem_4.DarkBorderColor.IsEmpty)
			{
				tabColors.DarkBorderColor = tabColorScheme_0.TabItemBorderDark;
				tabColors.LightBorderColor = tabColorScheme_0.TabItemBorderLight;
				tabColors.BorderColor = tabColorScheme_0.TabItemBorder;
			}
			else
			{
				tabColors.LightBorderColor = tabItem_4.LightBorderColor;
				tabColors.DarkBorderColor = tabItem_4.DarkBorderColor;
				tabColors.BorderColor = tabItem_4.BorderColor;
			}
		}
		return tabColors;
	}

	private void method_45(object sender, EventArgs e)
	{
		method_46();
	}

	internal void method_46()
	{
		if (userActionEventHandler_0 != null)
		{
			TabStripActionEventArgs tabStripActionEventArgs = new TabStripActionEventArgs();
			userActionEventHandler_0(this, tabStripActionEventArgs);
			if (tabStripActionEventArgs.Cancel)
			{
				return;
			}
		}
		int num = 0;
		for (int num2 = tabsCollection_0.Count - 1; num2 >= 0; num2--)
		{
			TabItem tabItem = tabsCollection_0[num2];
			if (tabItem.Visible)
			{
				if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
				{
					if (tabItem.DisplayRectangle.Y < 4)
					{
						num = -tabItem.DisplayRectangle.Height;
						if (eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document)
						{
							num -= tabItem.DisplayRectangle.Height;
						}
						break;
					}
				}
				else if (tabItem.DisplayRectangle.X < 4)
				{
					num = -tabItem.DisplayRectangle.Width;
					if (eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document)
					{
						num -= tabItem.DisplayRectangle.Height;
					}
					break;
				}
			}
		}
		if (num == 0 && int_0 > 0)
		{
			num = -int_0;
		}
		int num3 = int_0;
		int num4 = int_0 + num;
		if (num4 < 0)
		{
			num4 = 0;
		}
		if (bool_5)
		{
			DateTime now = DateTime.Now;
			for (int num5 = num3; num5 > num4; num5--)
			{
				ScrollOffset = num5;
				if (DateTime.Now.Subtract(now).TotalMilliseconds > 200.0)
				{
					break;
				}
			}
		}
		ScrollOffset = num4;
	}

	private void method_47(object sender, EventArgs e)
	{
		method_48();
	}

	internal void method_48()
	{
		if (userActionEventHandler_1 != null)
		{
			TabStripActionEventArgs tabStripActionEventArgs = new TabStripActionEventArgs();
			userActionEventHandler_1(this, tabStripActionEventArgs);
			if (tabStripActionEventArgs.Cancel)
			{
				return;
			}
		}
		int num = 0;
		TabItem tabItem = null;
		foreach (TabItem item in tabsCollection_0)
		{
			if (!item.Visible)
			{
				continue;
			}
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				if (item.DisplayRectangle.Y >= 4)
				{
					tabItem = item;
					num = item.DisplayRectangle.Height;
					if (item.DisplayRectangle.Bottom > ((Control)this).get_Height() - class26_0.int_0)
					{
						break;
					}
				}
			}
			else if (item.DisplayRectangle.X >= 4)
			{
				tabItem = item;
				num = item.DisplayRectangle.Width;
				if (item.DisplayRectangle.Right > ((Control)this).get_Width() - class26_0.int_0)
				{
					break;
				}
			}
		}
		if (tabItem != null)
		{
			if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
			{
				if (tabItem.DisplayRectangle.Bottom + 2 < ((Control)this).get_Height() - class26_0.int_0)
				{
					return;
				}
			}
			else if (tabItem.DisplayRectangle.Right + 2 < ((Control)this).get_Width() - class26_0.int_0)
			{
				return;
			}
		}
		int num2 = int_0;
		int num3 = int_0 + num;
		if (eTabStripAlignment_0 != eTabStripAlignment.Top && eTabStripAlignment_0 != eTabStripAlignment.Bottom)
		{
			if (num3 > tabsCollection_0[tabsCollection_0.Count - 1].DisplayRectangle.Bottom + int_0)
			{
				num3 = tabsCollection_0[tabsCollection_0.Count - 1].DisplayRectangle.Bottom + int_0 + class26_0.int_0;
			}
		}
		else if (num3 > tabsCollection_0[tabsCollection_0.Count - 1].DisplayRectangle.Right + int_0)
		{
			num3 = tabsCollection_0[tabsCollection_0.Count - 1].DisplayRectangle.Right + int_0 + class26_0.int_0;
		}
		if (bool_5)
		{
			DateTime now = DateTime.Now;
			for (int i = num2; i < num3; i++)
			{
				ScrollOffset = i;
				if (DateTime.Now.Subtract(now).TotalMilliseconds > 200.0)
				{
					break;
				}
			}
		}
		ScrollOffset = num3;
	}

	private void method_49(object sender, EventArgs e)
	{
		method_50();
	}

	private void method_50()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if (userActionEventHandler_2 != null)
		{
			TabStripActionEventArgs tabStripActionEventArgs = new TabStripActionEventArgs();
			userActionEventHandler_2(this, tabStripActionEventArgs);
			if (tabStripActionEventArgs.Cancel)
			{
				return;
			}
		}
		if (SelectedTab == null)
		{
			return;
		}
		if (bool_6 && SelectedTab != null && SelectedTab.AttachedControl is Form)
		{
			((Form)SelectedTab.AttachedControl).Close();
		}
		else if (SelectedTab != null && SelectedTab.AttachedItem != null && SelectedTab.AttachedItem is DockContainerItem)
		{
			if (SelectedTab.AttachedItem.ContainerControl is Bar bar)
			{
				bar.CloseDockTab((DockContainerItem)SelectedTab.AttachedItem, eEventSource.Mouse);
			}
			else
			{
				SelectedTab.AttachedItem.Visible = false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFixedTabSize()
	{
		return !size_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetFixedTabSize()
	{
		TypeDescriptor.GetProperties(this)["FixedTabSize"]!.SetValue(this, Size.Empty);
	}

	public TabItem HitTest(int x, int y)
	{
		if ((eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document || eTabStripStyle_0 == eTabStripStyle.Office2007Document) && method_33().Contains(x, y))
		{
			return SelectedTab;
		}
		GetSystemBoxRectangle();
		foreach (TabItem tab in Tabs)
		{
			if (tab.Visible && tab.DisplayRectangle.Contains(x, y))
			{
				return tab;
			}
		}
		return null;
	}

	protected override void OnParentChanged(EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		((Control)this).OnParentChanged(e);
		if (bool_6 && form_0 == null)
		{
			Form val = ((Control)this).FindForm();
			if (val != null && val.get_IsMdiContainer())
			{
				MdiForm = val;
			}
		}
		if ((eTabStripStyle_0 == eTabStripStyle.OneNote || eTabStripStyle_0 == eTabStripStyle.VS2005Document || eTabStripStyle_0 == eTabStripStyle.Office2007Document) && font_0 == null)
		{
			font_0 = new Font(((Control)this).get_Font(), (FontStyle)1);
		}
	}

	private void method_51()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		MdiClient val = method_58(form_0);
		if (val == null)
		{
			form_0.add_Load((EventHandler)form_0_Load);
			return;
		}
		((Control)val).add_ControlAdded(new ControlEventHandler(MdiFormAdded));
		((Control)val).add_ControlRemoved(new ControlEventHandler(MdiFormRemoved));
		form_0.add_MdiChildActivate((EventHandler)form_0_MdiChildActivate);
		bool_7 = true;
	}

	private void method_52()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (bool_7)
		{
			MdiClient val = method_58(form_0);
			if (val != null)
			{
				((Control)val).remove_ControlAdded(new ControlEventHandler(MdiFormAdded));
				((Control)val).remove_ControlRemoved(new ControlEventHandler(MdiFormRemoved));
				form_0.remove_MdiChildActivate((EventHandler)form_0_MdiChildActivate);
				bool_7 = false;
			}
		}
	}

	private void form_0_Load(object sender, EventArgs e)
	{
		form_0.remove_Load((EventHandler)form_0_Load);
		if (!bool_7)
		{
			method_51();
		}
	}

	internal void method_53(TabItem tabItem_4)
	{
		HideToolTip();
		if (!bool_22)
		{
			if (eventHandler_0 != null)
			{
				eventHandler_0(tabItem_4, new EventArgs());
			}
			if (Int32_1 == 1 && tabItem_4.Visible && tabItem_0 == null)
			{
				SelectedTab = tabItem_4;
			}
		}
	}

	private string method_54(Form form_1)
	{
		if (form_1 == null)
		{
			return "";
		}
		string text = ((Control)form_1).get_Text().Replace("&", "&&");
		if (text.Length > int_1)
		{
			int num = int_1 / 2;
			return text.Substring(0, num) + "..." + text.Substring(text.Length - (int_1 - num));
		}
		return text;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void MdiFormAdded(object sender, ControlEventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		if (form_0 == null || !bool_7)
		{
			return;
		}
		Control control = e.get_Control();
		Form val = (Form)(object)((control is Form) ? control : null);
		if (val == null)
		{
			method_55();
			return;
		}
		string text = method_54(val);
		TabItem tabItem = new TabItem();
		tabItem.Text = text;
		tabItem.AttachedControl = (Control)(object)val;
		if (bool_8 && val.get_Icon() != null)
		{
			tabItem.Icon = new Icon(val.get_Icon(), tabItem.IconSize);
		}
		tabsCollection_0.Add(tabItem);
		((Control)val).add_TextChanged((EventHandler)method_56);
		((Control)val).add_VisibleChanged((EventHandler)method_57);
		if (form_0.get_ActiveMdiChild() == val)
		{
			SelectedTab = tabItem;
		}
		if (bool_9 && form_0 != null && !((Control)this).get_Visible() && !Boolean_6)
		{
			Class109.smethod_4((Control)(object)this, bool_3: true);
		}
		((Control)this).Invalidate();
	}

	private void method_55()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		if (form_0 == null || !bool_6 || !Class109.smethod_11((Control)(object)this))
		{
			return;
		}
		tabsCollection_0.Clear();
		Form[] mdiChildren = form_0.get_MdiChildren();
		foreach (Form val in mdiChildren)
		{
			string text = method_54(val);
			TabItem tabItem = new TabItem();
			tabItem.Text = text;
			tabItem.AttachedControl = (Control)(object)val;
			if (bool_8 && val.get_Icon() != null)
			{
				tabItem.Icon = new Icon(val.get_Icon(), tabItem.IconSize);
			}
			tabsCollection_0.Add(tabItem);
			tabItem.Visible = ((Control)val).get_Visible();
			((Control)val).add_TextChanged((EventHandler)method_56);
			((Control)val).add_VisibleChanged((EventHandler)method_57);
			if (form_0.get_ActiveMdiChild() == val)
			{
				SelectedTab = tabItem;
			}
		}
		if (bool_9 && form_0 != null)
		{
			if (form_0.get_MdiChildren().Length == 0 && ((Control)this).get_Visible() && !Boolean_6)
			{
				((Control)this).set_Visible(false);
			}
			else if (form_0.get_MdiChildren().Length > 0 && !((Control)this).get_Visible() && !Boolean_6)
			{
				Class109.smethod_4((Control)(object)this, bool_3: true);
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void MdiFormRemoved(object sender, ControlEventArgs e)
	{
		Control control = e.get_Control();
		Form val = (Form)(object)((control is Form) ? control : null);
		if (val == null)
		{
			if (userActionEventHandler_2 != null)
			{
				TabStripActionEventArgs e2 = new TabStripActionEventArgs();
				userActionEventHandler_2(this, e2);
			}
			method_55();
			return;
		}
		foreach (TabItem item in tabsCollection_0)
		{
			if (item.AttachedControl == val)
			{
				if (userActionEventHandler_2 != null)
				{
					TabStripActionEventArgs e3 = new TabStripActionEventArgs();
					userActionEventHandler_2(item, e3);
				}
				tabsCollection_0.Remove(item);
				((Control)val).remove_TextChanged((EventHandler)method_56);
				((Control)val).remove_VisibleChanged((EventHandler)method_57);
				((Control)this).Invalidate();
				break;
			}
		}
		if (bool_9 && form_0 != null && form_0.get_MdiChildren().Length == 0 && !Boolean_6)
		{
			((Control)this).set_Visible(false);
		}
	}

	private void form_0_MdiChildActivate(object sender, EventArgs e)
	{
		Form activeMdiChild = form_0.get_ActiveMdiChild();
		foreach (TabItem item in tabsCollection_0)
		{
			if (item.AttachedControl == activeMdiChild)
			{
				if (SelectedTab != item)
				{
					SelectedTab = item;
				}
				break;
			}
		}
	}

	private void method_56(object sender, EventArgs e)
	{
		Form val = (Form)((sender is Form) ? sender : null);
		if (val == null)
		{
			return;
		}
		foreach (TabItem item in tabsCollection_0)
		{
			if (item.AttachedControl == val)
			{
				item.Text = method_54(val);
				break;
			}
		}
	}

	private void method_57(object sender, EventArgs e)
	{
		Form val = (Form)((sender is Form) ? sender : null);
		if (val == null)
		{
			return;
		}
		foreach (TabItem item in tabsCollection_0)
		{
			if (item.AttachedControl == val)
			{
				item.Visible = ((Control)val).get_Visible();
				break;
			}
		}
	}

	private MdiClient method_58(Form form_1)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (!form_1.get_IsMdiContainer())
		{
			return null;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)form_1).get_Controls())
		{
			Control val = item;
			if (val is MdiClient)
			{
				return (MdiClient)(object)((val is MdiClient) ? val : null);
			}
		}
		return null;
	}

	internal Color method_59()
	{
		Color result = ControlPaint.Light(SystemColors.Control);
		if (Class109.Boolean_0 && Class92.int_74 >= 16)
		{
			if (SystemColors.Control.ToArgb() == Color.FromArgb(236, 233, 216).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(49, 106, 197).ToArgb())
			{
				result = Color.FromArgb(255, 251, 233);
			}
			else if (SystemColors.Control.ToArgb() == Color.FromArgb(224, 223, 227).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(178, 180, 191).ToArgb())
			{
				result = Color.FromArgb(251, 250, 255);
			}
			else if (SystemColors.Control.ToArgb() == Color.FromArgb(236, 233, 216).ToArgb() && SystemColors.Highlight.ToArgb() == Color.FromArgb(147, 160, 112).ToArgb())
			{
				result = Color.FromArgb(255, 251, 233);
			}
		}
		return result;
	}

	public void HideToolTip()
	{
		if (toolTip_0 != null)
		{
			((Control)toolTip_0).Hide();
			((Component)(object)toolTip_0).Dispose();
			toolTip_0 = null;
		}
		tabItem_3 = null;
	}

	private void method_60(TabItem tabItem_4)
	{
		if (toolTip_0 != null)
		{
			HideToolTip();
		}
		if (tabItem_4.Tooltip != null && !(tabItem_4.Tooltip == "") && ((Control)this).get_Visible())
		{
			if (toolTip_0 == null)
			{
				toolTip_0 = new ToolTip();
			}
			toolTip_0.Text = tabItem_4.Tooltip;
			toolTip_0.ShowToolTip();
			tabItem_3 = tabItem_4;
		}
	}

	private void method_61()
	{
		Class92.TRACKMOUSEEVENT tme = default(Class92.TRACKMOUSEEVENT);
		tme.dwFlags = 1073741824u;
		tme.hwndTrack = ((Control)this).get_Handle();
		tme.cbSize = Marshal.SizeOf((object)tme);
		Class92.TrackMouseEvent(ref tme);
		tme.dwFlags |= 1u;
		Class92.TrackMouseEvent(ref tme);
	}

	private void method_62()
	{
		Point mousePosition = Control.get_MousePosition();
		mousePosition = ((Control)this).PointToClient(mousePosition);
		TabItem tabItem = HitTest(mousePosition.X, mousePosition.Y);
		tabItem?.InvokeMouseHover(new EventArgs());
		if (tabItem == null)
		{
			HideToolTip();
		}
		else
		{
			if (tabItem_3 == tabItem)
			{
				return;
			}
			HideToolTip();
			if (Style == eTabStripStyle.Office2007Document)
			{
				Rectangle systemBoxRectangle = GetSystemBoxRectangle();
				if (!systemBoxRectangle.IsEmpty && systemBoxRectangle.IntersectsWith(tabItem.DisplayRectangle))
				{
					return;
				}
			}
			method_60(tabItem);
		}
	}
}

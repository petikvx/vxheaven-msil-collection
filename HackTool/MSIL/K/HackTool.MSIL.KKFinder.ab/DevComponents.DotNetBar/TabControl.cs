using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[Designer(typeof(TabControlDesigner))]
[ToolboxItem(true)]
public class TabControl : Control, ISupportInitialize
{
	private TabStrip.SelectedTabChangedEventHandler selectedTabChangedEventHandler_0;

	private TabStrip.SelectedTabChangingEventHandler selectedTabChangingEventHandler_0;

	private TabStrip.TabMovedEventHandler tabMovedEventHandler_0;

	private TabStrip.UserActionEventHandler userActionEventHandler_0;

	private TabStrip.UserActionEventHandler userActionEventHandler_1;

	private TabStrip.UserActionEventHandler userActionEventHandler_2;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private TabStrip tabStrip1;

	private Timer timer_0;

	private bool bool_0;

	private bool bool_1 = true;

	private int int_0 = -1;

	private bool bool_2;

	private Container container_0;

	private bool bool_3;

	private bool bool_4;

	[Description("Indicates the background color.")]
	[Browsable(true)]
	[Category("Style")]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			((Control)this).set_BackColor(value);
			if (tabStrip1 != null)
			{
				((Control)tabStrip1).set_BackColor(value);
			}
		}
	}

	[Category("Data")]
	[Description("Returns the collection of Tabs.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[Editor(typeof(TabStripTabsEditor), typeof(UITypeEditor))]
	public TabsCollection Tabs => tabStrip1.Tabs;

	[Category("Appearance")]
	[Description("Indicates whether tabs are visible")]
	[DefaultValue(true)]
	public bool TabsVisible
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((Control)tabStrip1).set_Visible(value);
			method_1();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public TabStrip TabStrip => tabStrip1;

	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Gets or sets whether TabStrip will get focus when Tab key is used.")]
	public bool TabStripTabStop
	{
		get
		{
			return ((Control)tabStrip1).get_TabStop();
		}
		set
		{
			((Control)tabStrip1).set_TabStop(value);
		}
	}

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

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Gets or sets whether tabs use anti-aliasing when painted.")]
	[Category("Appearance")]
	public bool AntiAlias
	{
		get
		{
			return tabStrip1.AntiAlias;
		}
		set
		{
			tabStrip1.AntiAlias = value;
		}
	}

	[Description("Indicates whether the tab scrolling is animanted.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[DefaultValue(true)]
	public bool Animate
	{
		get
		{
			return tabStrip1.Animate;
		}
		set
		{
			tabStrip1.Animate = value;
		}
	}

	[Category("Behavior")]
	[Description("Indicates whether system box that enables scrolling and closing of the tabs is automatically hidden when tab items size does not exceed the size of the control.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool AutoHideSystemBox
	{
		get
		{
			return tabStrip1.AutoHideSystemBox;
		}
		set
		{
			tabStrip1.AutoHideSystemBox = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[Description("Specifes whether end-user can reorder the tabs.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	public bool CanReorderTabs
	{
		get
		{
			return tabStrip1.CanReorderTabs;
		}
		set
		{
			tabStrip1.CanReorderTabs = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Close Button")]
	[Description("Indicates whether tab is automatically closed when close button is clicked.")]
	public bool AutoCloseTabs
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

	[DefaultValue(false)]
	[Category("Close Button")]
	[Browsable(true)]
	[Description("Indicates whether the Close button that closes the active tab is visible.")]
	[DevCoBrowsable(true)]
	public bool CloseButtonVisible
	{
		get
		{
			return tabStrip1.CloseButtonVisible;
		}
		set
		{
			tabStrip1.CloseButtonVisible = value;
		}
	}

	[Description("Indicates whether close button is visible on each tab instead of in system box.")]
	[Category("Close Button")]
	[Browsable(true)]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	public bool CloseButtonOnTabsVisible
	{
		get
		{
			return tabStrip1.CloseButtonOnTabsVisible;
		}
		set
		{
			tabStrip1.CloseButtonOnTabsVisible = value;
			((Control)this).Refresh();
		}
	}

	[DevCoBrowsable(true)]
	[Description("Indicates whether close button on tabs when visible is displayed for every tab state.")]
	[Browsable(true)]
	[Category("Close Button")]
	[DefaultValue(true)]
	public bool CloseButtonOnTabsAlwaysDisplayed
	{
		get
		{
			return tabStrip1.CloseButtonOnTabsAlwaysDisplayed;
		}
		set
		{
			tabStrip1.CloseButtonOnTabsAlwaysDisplayed = value;
		}
	}

	[DefaultValue(eTabCloseButtonPosition.Left)]
	[Category("Close Button")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates position of the close button displayed on each tab.")]
	public eTabCloseButtonPosition CloseButtonPosition
	{
		get
		{
			return tabStrip1.CloseButtonPosition;
		}
		set
		{
			tabStrip1.CloseButtonPosition = value;
		}
	}

	[Description("Indicates custom image that is used on tabs as Close button that allows user to close the tab.")]
	[Browsable(true)]
	[Category("Close Button")]
	[DefaultValue(null)]
	public Image TabCloseButtonNormal
	{
		get
		{
			return tabStrip1.TabCloseButtonNormal;
		}
		set
		{
			tabStrip1.TabCloseButtonNormal = value;
		}
	}

	[Description("Indicates custom image that is used on tabs as Close button whem mouse is over the close button.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Close Button")]
	public Image TabCloseButtonHot
	{
		get
		{
			return tabStrip1.TabCloseButtonHot;
		}
		set
		{
			tabStrip1.TabCloseButtonHot = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Specifes whether only selected tab is displaying it's text.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public bool DisplaySelectedTextOnly
	{
		get
		{
			return tabStrip1.DisplaySelectedTextOnly;
		}
		set
		{
			tabStrip1.DisplaySelectedTextOnly = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	public ImageList ImageList
	{
		get
		{
			return tabStrip1.ImageList;
		}
		set
		{
			tabStrip1.ImageList = value;
		}
	}

	[DevCoBrowsable(false)]
	[DefaultValue(0)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int ScrollOffset
	{
		get
		{
			return tabStrip1.ScrollOffset;
		}
		set
		{
			tabStrip1.ScrollOffset = value;
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies the Tab Control style.")]
	[DefaultValue(eTabStripStyle.OneNote)]
	[Browsable(true)]
	[Category("Appearance")]
	public eTabStripStyle Style
	{
		get
		{
			return tabStrip1.Style;
		}
		set
		{
			tabStrip1.Style = value;
			SyncTabStripSize();
			method_1();
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies whether tab is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[Category("Appearance")]
	[DefaultValue(false)]
	[Browsable(true)]
	public virtual bool ThemeAware
	{
		get
		{
			return tabStrip1.ThemeAware;
		}
		set
		{
			tabStrip1.ThemeAware = value;
			method_1();
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether tabs are scrolled continuously while mouse is pressed over the scroll tab button.")]
	[Category("Behavior")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public virtual bool TabScrollAutoRepeat
	{
		get
		{
			return tabStrip1.TabScrollAutoRepeat;
		}
		set
		{
			tabStrip1.TabScrollAutoRepeat = value;
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates auto-repeat interval for the tab scrolling while mouse button is kept pressed over the scroll tab button.")]
	[DefaultValue(300)]
	[Category("Behavior")]
	public virtual int TabScrollRepeatInterval
	{
		get
		{
			return tabStrip1.TabScrollRepeatInterval;
		}
		set
		{
			tabStrip1.TabScrollRepeatInterval = value;
		}
	}

	[Description("Gets or sets Tab Color Scheme.")]
	[DevCoBrowsable(true)]
	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	public TabColorScheme ColorScheme
	{
		get
		{
			return tabStrip1.ColorScheme;
		}
		set
		{
			tabStrip1.ColorScheme = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[Description("Indicates the tab alignment within the Tab-Strip control.")]
	[DevCoBrowsable(true)]
	[DefaultValue(eTabStripAlignment.Top)]
	[Browsable(true)]
	[Category("Appearance")]
	public eTabStripAlignment TabAlignment
	{
		get
		{
			return tabStrip1.TabAlignment;
		}
		set
		{
			if (tabStrip1.TabAlignment == value)
			{
				return;
			}
			((Control)this).SuspendLayout();
			try
			{
				switch (value)
				{
				case eTabStripAlignment.Left:
					((Control)tabStrip1).set_Dock((DockStyle)3);
					break;
				case eTabStripAlignment.Right:
					((Control)tabStrip1).set_Dock((DockStyle)4);
					break;
				case eTabStripAlignment.Top:
					((Control)tabStrip1).set_Dock((DockStyle)1);
					break;
				case eTabStripAlignment.Bottom:
					((Control)tabStrip1).set_Dock((DockStyle)2);
					break;
				}
				tabStrip1.TabAlignment = value;
				method_1();
			}
			finally
			{
				ResumeLayout(performLayout: true);
			}
			if (((Control)this).get_Visible())
			{
				SyncTabStripSize();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Category("Behavior")]
	[Description("Indicates selected tab.")]
	public TabItem SelectedTab
	{
		get
		{
			return tabStrip1.SelectedTab;
		}
		set
		{
			tabStrip1.SelectedTab = value;
		}
	}

	[Description("Gets or sets the selected tab Font")]
	[Browsable(true)]
	[DefaultValue(null)]
	[DevCoBrowsable(true)]
	[Category("Style")]
	public Font SelectedTabFont
	{
		get
		{
			return tabStrip1.SelectedTabFont;
		}
		set
		{
			tabStrip1.SelectedTabFont = value;
		}
	}

	[Description("Indicates whether focus rectangle is displayed on the tab when tab has input focus.")]
	[Category("Behavior")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool ShowFocusRectangle
	{
		get
		{
			return tabStrip1.ShowFocusRectangle;
		}
		set
		{
			tabStrip1.ShowFocusRectangle = value;
		}
	}

	[Category("Behavior")]
	[Description("Indicates whether keyboard navigation using Left and Right arrow keys to select tabs is enabled.")]
	[DefaultValue(true)]
	public bool KeyboardNavigationEnabled
	{
		get
		{
			return tabStrip1.KeyboardNavigationEnabled;
		}
		set
		{
			tabStrip1.KeyboardNavigationEnabled = value;
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates the index of selected tab.")]
	[Category("Behavior")]
	public int SelectedTabIndex
	{
		get
		{
			return tabStrip1.SelectedTabIndex;
		}
		set
		{
			if (bool_4)
			{
				int_0 = value;
			}
			else
			{
				tabStrip1.SelectedTabIndex = value;
			}
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TabControlPanel SelectedPanel
	{
		get
		{
			if (tabStrip1.SelectedTab != null)
			{
				return tabStrip1.SelectedTab.AttachedControl as TabControlPanel;
			}
			return null;
		}
		set
		{
			if (value != null && ((Control)this).get_Controls().Contains((Control)(object)value) && value.TabItem != null && Tabs.Contains(value.TabItem))
			{
				tabStrip1.SelectedTab = value.TabItem;
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(eTabLayoutType.FitContainer)]
	[Category("Appearance")]
	[Description("Indicates the type of the tab layout.")]
	public eTabLayoutType TabLayoutType
	{
		get
		{
			return tabStrip1.TabLayoutType;
		}
		set
		{
			tabStrip1.TabLayoutType = value;
		}
	}

	[Description("Gets or sets the fixed tab size in pixels. Either Height or Width can be set or both.")]
	[Category("Appearance")]
	[Browsable(true)]
	public Size FixedTabSize
	{
		get
		{
			return tabStrip1.FixedTabSize;
		}
		set
		{
			tabStrip1.FixedTabSize = value;
			RecalcLayout();
		}
	}

	public event TabStrip.SelectedTabChangedEventHandler SelectedTabChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			selectedTabChangedEventHandler_0 = (TabStrip.SelectedTabChangedEventHandler)Delegate.Combine(selectedTabChangedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			selectedTabChangedEventHandler_0 = (TabStrip.SelectedTabChangedEventHandler)Delegate.Remove(selectedTabChangedEventHandler_0, value);
		}
	}

	public event TabStrip.SelectedTabChangingEventHandler SelectedTabChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			selectedTabChangingEventHandler_0 = (TabStrip.SelectedTabChangingEventHandler)Delegate.Combine(selectedTabChangingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			selectedTabChangingEventHandler_0 = (TabStrip.SelectedTabChangingEventHandler)Delegate.Remove(selectedTabChangingEventHandler_0, value);
		}
	}

	public event TabStrip.TabMovedEventHandler TabMoved
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			tabMovedEventHandler_0 = (TabStrip.TabMovedEventHandler)Delegate.Combine(tabMovedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			tabMovedEventHandler_0 = (TabStrip.TabMovedEventHandler)Delegate.Remove(tabMovedEventHandler_0, value);
		}
	}

	public event TabStrip.UserActionEventHandler NavigateBack
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			userActionEventHandler_0 = (TabStrip.UserActionEventHandler)Delegate.Combine(userActionEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			userActionEventHandler_0 = (TabStrip.UserActionEventHandler)Delegate.Remove(userActionEventHandler_0, value);
		}
	}

	public event TabStrip.UserActionEventHandler NavigateForward
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			userActionEventHandler_1 = (TabStrip.UserActionEventHandler)Delegate.Combine(userActionEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			userActionEventHandler_1 = (TabStrip.UserActionEventHandler)Delegate.Remove(userActionEventHandler_1, value);
		}
	}

	public event TabStrip.UserActionEventHandler TabItemClose
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			userActionEventHandler_2 = (TabStrip.UserActionEventHandler)Delegate.Combine(userActionEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			userActionEventHandler_2 = (TabStrip.UserActionEventHandler)Delegate.Remove(userActionEventHandler_2, value);
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

	public TabControl()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		InitializeComponent();
		tabStrip1.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
		tabStrip1.Event_0 += method_2;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
		((Control)this).SuspendLayout();
		this.tabStrip1.CanReorderTabs = true;
		this.tabStrip1.CloseButtonVisible = true;
		((Control)this.tabStrip1).set_Dock((DockStyle)1);
		this.tabStrip1.ImageList = null;
		((Control)this.tabStrip1).set_Name("tabStrip1");
		this.tabStrip1.SelectedTab = null;
		((Control)this.tabStrip1).set_Size(new System.Drawing.Size(256, 26));
		this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.OneNote;
		this.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
		((Control)this.tabStrip1).set_TabIndex(0);
		((Control)this.tabStrip1).set_Text("tabStrip1");
		this.tabStrip1.AutoHideSystemBox = true;
		this.tabStrip1.CloseButtonVisible = false;
		this.tabStrip1.TabRemoved += new System.EventHandler(tabStrip1_TabRemoved);
		this.tabStrip1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(tabStrip1_SelectedTabChanged);
		this.tabStrip1.SelectedTabChanging += new DevComponents.DotNetBar.TabStrip.SelectedTabChangingEventHandler(tabStrip1_SelectedTabChanging);
		this.tabStrip1.TabMoved += new DevComponents.DotNetBar.TabStrip.TabMovedEventHandler(tabStrip1_TabMoved);
		this.tabStrip1.NavigateBack += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(tabStrip1_NavigateBack);
		this.tabStrip1.NavigateForward += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(tabStrip1_NavigateForward);
		this.tabStrip1.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(tabStrip1_TabItemClose);
		this.tabStrip1.TabItemOpen += new System.EventHandler(tabStrip1_TabItemOpen);
		this.tabStrip1.TabsCleared += new System.EventHandler(tabStrip1_TabsCleared);
		this.tabStrip1.BeforeTabDisplay += new System.EventHandler(tabStrip1_BeforeTabDisplay);
		((Control)this.tabStrip1).set_TabStop(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[1] { this.tabStrip1 });
		((Control)this).set_Name("TabControl");
		((Control)this).set_Size(new System.Drawing.Size(256, 152));
		this.ResumeLayout(false);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor()
	{
		return ((Control)this).get_BackColor() != SystemColors.Control;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ValidateChildren()
	{
		return ValidateChildren((ValidationConstraints)1);
	}

	[Browsable(false)]
	public virtual bool ValidateChildren(ValidationConstraints validationConstraints)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected I4, but got Unknown
		if ((int)validationConstraints >= 0 && (int)validationConstraints <= 31)
		{
			Type typeFromHandle = typeof(Control);
			MethodInfo method = typeFromHandle.GetMethod("PerformContainerValidation", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod);
			if ((object)method != null)
			{
				return !(bool)method.Invoke(this, new object[1] { validationConstraints });
			}
			return true;
		}
		throw new InvalidEnumArgumentException("validationConstraints", (int)validationConstraints, typeof(ValidationConstraints));
	}

	public void RecalcLayout()
	{
		((Control)tabStrip1).Refresh();
		SyncTabStripSize();
	}

	private void tabStrip1_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
	{
		if (e.NewTab != null && e.NewTab.AttachedControl != null)
		{
			e.NewTab.AttachedControl.BringToFront();
		}
		InvokeSelectedTabChanged(e);
	}

	protected virtual void InvokeSelectedTabChanged(TabStripTabChangedEventArgs e)
	{
		if (selectedTabChangedEventHandler_0 != null)
		{
			selectedTabChangedEventHandler_0(this, e);
		}
	}

	private void tabStrip1_SelectedTabChanging(object sender, TabStripTabChangingEventArgs e)
	{
		InvokeSelectedTabChanging(e);
	}

	protected virtual void InvokeSelectedTabChanging(TabStripTabChangingEventArgs e)
	{
		if (selectedTabChangingEventHandler_0 != null)
		{
			selectedTabChangingEventHandler_0(this, e);
		}
	}

	private void tabStrip1_TabMoved(object sender, TabStripTabMovedEventArgs e)
	{
		InvokeTabMoved(e);
	}

	protected virtual void InvokeTabMoved(TabStripTabMovedEventArgs e)
	{
		if (tabMovedEventHandler_0 != null)
		{
			tabMovedEventHandler_0(this, e);
		}
	}

	private void tabStrip1_NavigateBack(object sender, TabStripActionEventArgs e)
	{
		InvokeNavigateBack(e);
	}

	protected virtual void InvokeNavigateBack(TabStripActionEventArgs e)
	{
		if (userActionEventHandler_0 != null)
		{
			userActionEventHandler_0(this, e);
		}
	}

	private void tabStrip1_NavigateForward(object sender, TabStripActionEventArgs e)
	{
		InvokeNavigateForward(e);
	}

	protected virtual void InvokeNavigateForward(TabStripActionEventArgs e)
	{
		if (userActionEventHandler_1 != null)
		{
			userActionEventHandler_1(this, e);
		}
	}

	private void tabStrip1_TabItemClose(object sender, TabStripActionEventArgs e)
	{
		InvokeTabItemClose(e);
		if (e.Cancel || !bool_0 || ((Component)this).DesignMode)
		{
			return;
		}
		TabItem selectedTab = tabStrip1.SelectedTab;
		if (selectedTab != null)
		{
			tabStrip1.Tabs.Remove(selectedTab);
			Control attachedControl = selectedTab.AttachedControl;
			if (attachedControl != null)
			{
				if (((Control)this).get_Controls().Contains(attachedControl))
				{
					((Control)this).get_Controls().Remove(attachedControl);
				}
				((Component)(object)attachedControl).Dispose();
			}
		}
		RecalcLayout();
	}

	protected virtual void InvokeTabItemClose(TabStripActionEventArgs e)
	{
		if (userActionEventHandler_2 != null)
		{
			userActionEventHandler_2(this, e);
		}
	}

	private void tabStrip1_TabItemOpen(object sender, EventArgs e)
	{
		InvokeTabItemOpen(e);
	}

	protected virtual void InvokeTabItemOpen(EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	private void tabStrip1_BeforeTabDisplay(object sender, EventArgs e)
	{
		InvokeBeforeTabDisplay(e);
	}

	protected virtual void InvokeBeforeTabDisplay(EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
		}
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		((Control)this).OnControlAdded(e);
		if (((Component)this).DesignMode || !(e.get_Control() is TabControlPanel tabControlPanel))
		{
			return;
		}
		if (tabControlPanel.TabItem != null)
		{
			if (Tabs.Contains(tabControlPanel.TabItem) && SelectedTab == tabControlPanel.TabItem)
			{
				((Control)tabControlPanel).set_Visible(true);
				((Control)tabControlPanel).BringToFront();
			}
			else
			{
				((Control)tabControlPanel).set_Visible(false);
			}
		}
		else
		{
			((Control)tabControlPanel).set_Visible(false);
		}
	}

	protected override void OnControlRemoved(ControlEventArgs e)
	{
		((Control)this).OnControlRemoved(e);
		if (e.get_Control() is TabControlPanel tabControlPanel && tabControlPanel.TabItem != null && Tabs.Contains(tabControlPanel.TabItem))
		{
			Tabs.Remove(tabControlPanel.TabItem);
		}
	}

	private void tabStrip1_TabRemoved(object sender, EventArgs e)
	{
		if (sender is TabItem)
		{
			TabItem tabItem = sender as TabItem;
			if (tabItem.AttachedControl != null && ((Control)this).get_Controls().Contains(tabItem.AttachedControl))
			{
				((Control)this).get_Controls().Remove(tabItem.AttachedControl);
			}
		}
		InvokeTabRemoved(e);
	}

	protected virtual void InvokeTabRemoved(EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, e);
		}
	}

	private void tabStrip1_TabsCleared(object sender, EventArgs e)
	{
		if (((Component)this).DesignMode)
		{
			return;
		}
		Control[] array = (Control[])(object)new Control[((ArrangedElementCollection)((Control)this).get_Controls()).get_Count()];
		((ArrangedElementCollection)((Control)this).get_Controls()).CopyTo((Array)array, 0);
		Control[] array2 = array;
		foreach (Control val in array2)
		{
			if (val is TabControlPanel)
			{
				((Control)this).get_Controls().Remove(val);
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		if (((Control)this).get_BackColor() == Color.Transparent || ColorScheme.TabBackground == Color.Transparent)
		{
			((Control)this).OnPaintBackground(e);
		}
		if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() <= 1)
		{
			SolidBrush val = new SolidBrush(SystemColors.Control);
			try
			{
				e.get_Graphics().FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0 && tabStrip1.Boolean_8)
		{
			method_0();
		}
	}

	private void method_0()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if (timer_0 == null)
		{
			timer_0 = new Timer();
			timer_0.set_Interval(10);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.set_Enabled(true);
			timer_0.Start();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		timer_0.set_Enabled(false);
		timer_0 = null;
		try
		{
			((Control)this).PerformLayout();
		}
		catch
		{
		}
	}

	public void ApplyDefaultPanelStyle(TabControlPanel panel)
	{
		if (panel == null || panel.UseCustomStyle)
		{
			return;
		}
		if (panel.TabItem != null && !panel.TabItem.BackColor.IsEmpty)
		{
			if (!panel.TabItem.BackColor2.IsEmpty)
			{
				panel.Style.BackColor1.Color = panel.TabItem.BackColor;
				panel.Style.BackColor2.Color = panel.TabItem.BackColor2;
				switch (tabStrip1.TabAlignment)
				{
				case eTabStripAlignment.Left:
					panel.Style.GradientAngle = panel.TabItem.BackColorGradientAngle - 90;
					break;
				case eTabStripAlignment.Right:
					panel.Style.GradientAngle = panel.TabItem.BackColorGradientAngle + 90;
					break;
				case eTabStripAlignment.Top:
					panel.Style.GradientAngle = panel.TabItem.BackColorGradientAngle - 180;
					break;
				case eTabStripAlignment.Bottom:
					panel.Style.GradientAngle = panel.TabItem.BackColorGradientAngle;
					break;
				}
			}
		}
		else
		{
			panel.Style.BackColor1.Color = tabStrip1.ColorScheme.TabPanelBackground;
			panel.Style.BackColor2.Color = tabStrip1.ColorScheme.TabPanelBackground2;
			switch (tabStrip1.TabAlignment)
			{
			case eTabStripAlignment.Left:
				panel.Style.GradientAngle = tabStrip1.ColorScheme.TabPanelBackgroundGradientAngle - 90;
				break;
			case eTabStripAlignment.Right:
				panel.Style.GradientAngle = tabStrip1.ColorScheme.TabPanelBackgroundGradientAngle + 90;
				break;
			case eTabStripAlignment.Top:
				panel.Style.GradientAngle = tabStrip1.ColorScheme.TabPanelBackgroundGradientAngle;
				break;
			case eTabStripAlignment.Bottom:
				panel.Style.GradientAngle = tabStrip1.ColorScheme.TabPanelBackgroundGradientAngle - 180;
				break;
			}
			panel.Style.BorderColor.Color = tabStrip1.ColorScheme.TabPanelBorder;
		}
		panel.Style.Border = eBorderType.SingleLine;
		if (bool_1)
		{
			switch (tabStrip1.TabAlignment)
			{
			case eTabStripAlignment.Left:
				panel.Style.BorderSide = eBorderSide.Right | eBorderSide.Top | eBorderSide.Bottom;
				break;
			case eTabStripAlignment.Right:
				panel.Style.BorderSide = eBorderSide.Left | eBorderSide.Top | eBorderSide.Bottom;
				break;
			case eTabStripAlignment.Top:
				panel.Style.BorderSide = eBorderSide.Left | eBorderSide.Right | eBorderSide.Bottom;
				break;
			case eTabStripAlignment.Bottom:
				panel.Style.BorderSide = eBorderSide.Left | eBorderSide.Right | eBorderSide.Top;
				break;
			}
		}
		else
		{
			panel.Style.BorderSide = eBorderSide.All;
		}
		if (tabStrip1.Boolean_13)
		{
			panel.bool_10 = true;
		}
		else
		{
			panel.bool_10 = false;
		}
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (val is TabControlPanel)
			{
				TabControlPanel panel = val as TabControlPanel;
				ApplyDefaultPanelStyle(panel);
			}
		}
	}

	public void ResumeLayout(bool performLayout)
	{
		((Control)this).ResumeLayout(performLayout);
		if (!((Control)this).get_IsHandleCreated())
		{
			bool_3 = true;
			return;
		}
		tabStrip1.ResetTabHeight();
		SyncTabStripSize();
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (bool_3)
		{
			bool_3 = false;
			tabStrip1.ResetTabHeight();
			SyncTabStripSize();
		}
		((Control)this).OnHandleCreated(e);
	}

	private void method_1()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (val is TabControlPanel)
			{
				ApplyDefaultPanelStyle(val as TabControlPanel);
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		SyncTabStripSize();
	}

	public void SyncTabStripSize()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected I4, but got Unknown
		if (bool_2)
		{
			return;
		}
		bool_2 = true;
		try
		{
			DockStyle dock = ((Control)tabStrip1).get_Dock();
			switch (dock - 3)
			{
			default:
				((Control)tabStrip1).set_Height(tabStrip1.MinTabStripHeight);
				break;
			case 0:
			case 1:
				((Control)tabStrip1).set_Width(tabStrip1.MinTabStripHeight);
				break;
			}
			((Control)tabStrip1).SendToBack();
		}
		finally
		{
			bool_2 = false;
		}
	}

	public TabItem CreateTab(string tabText)
	{
		return CreateTab(tabText, -1);
	}

	public TabItem CreateTab(string tabText, int insertAt)
	{
		TabItem tabItem = new TabItem();
		tabItem.Text = tabText;
		TabControlPanel tabControlPanel = new TabControlPanel();
		ApplyDefaultPanelStyle(tabControlPanel);
		tabItem.AttachedControl = (Control)(object)tabControlPanel;
		tabControlPanel.TabItem = tabItem;
		if (insertAt >= 0 && insertAt < tabStrip1.Tabs.Count)
		{
			tabStrip1.Tabs.Insert(insertAt, tabItem);
			((Control)this).get_Controls().Add((Control)(object)tabControlPanel);
		}
		else
		{
			tabStrip1.Tabs.Add(tabItem);
			((Control)this).get_Controls().Add((Control)(object)tabControlPanel);
		}
		((Control)tabControlPanel).set_Dock((DockStyle)5);
		((Control)tabControlPanel).SendToBack();
		RecalcLayout();
		return tabItem;
	}

	void ISupportInitialize.BeginInit()
	{
		bool_4 = true;
	}

	void ISupportInitialize.EndInit()
	{
		bool_4 = false;
		method_1();
		if (int_0 >= 0)
		{
			tabStrip1.SelectedTabIndex = int_0;
		}
		int_0 = -1;
		if (tabStrip1.SelectedTab != null && tabStrip1.SelectedTab.AttachedControl != null)
		{
			tabStrip1.SelectedTab.AttachedControl.set_Visible(true);
		}
	}

	public bool SelectPreviousTab()
	{
		return tabStrip1.SelectPreviousTab();
	}

	public bool SelectNextTab()
	{
		return tabStrip1.SelectNextTab();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColorScheme()
	{
		return tabStrip1.ColorScheme.SchemeChanged;
	}

	public void ResetColorScheme()
	{
		tabStrip1.ResetColorScheme();
		if (((Component)this).DesignMode)
		{
			((Control)this).Refresh();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetSelectedTabFont()
	{
		tabStrip1.ResetSelectedTabFont();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFixedTabSize()
	{
		return tabStrip1.ShouldSerializeFixedTabSize();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetFixedTabSize()
	{
		TypeDescriptor.GetProperties(this)["FixedTabSize"]!.SetValue(this, Size.Empty);
	}
}

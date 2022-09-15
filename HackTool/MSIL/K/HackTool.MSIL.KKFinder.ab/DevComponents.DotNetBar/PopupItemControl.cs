using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public abstract class PopupItemControl : Control, IAccessibilitySupport, IOwner, IOwnerLocalize, IOwnerMenuSupport, IRenderingSupport, Interface5, Interface6
{
	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private EventHandler eventHandler_3;

	private EventHandler eventHandler_4;

	private DotNetBarManager.LocalizeStringEventHandler localizeStringEventHandler_0;

	private PopupItem popupItem_0;

	private ColorScheme colorScheme_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private Timer timer_0;

	private IntPtr intptr_0 = IntPtr.Zero;

	private IntPtr intptr_1 = IntPtr.Zero;

	private Hashtable hashtable_0 = new Hashtable();

	private BaseItem baseItem_0;

	private BaseItem baseItem_1;

	private ImageList imageList_0;

	private ImageList imageList_1;

	private ImageList imageList_2;

	private bool bool_4 = true;

	private Class77 class77_0;

	private Class78 class78_0;

	private Class79 class79_0;

	private Class65 class65_0;

	private Class63 class63_0;

	private Class81 class81_0;

	private Class64 class64_0;

	private Class82 class82_0;

	private BaseItem baseItem_2;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	private Class94 class94_0;

	private ArrayList arrayList_0 = new ArrayList();

	private Class197 class197_0;

	[Category("Appearance")]
	[Description("Specifies the visual style of the button.")]
	[DefaultValue(eDotNetBarStyle.Office2007)]
	public virtual eDotNetBarStyle Style
	{
		get
		{
			return popupItem_0.Style;
		}
		set
		{
			colorScheme_0.EDotNetBarStyle_0 = value;
			popupItem_0.Style = value;
			RecalcLayout();
		}
	}

	[DefaultValue(eRenderMode.Global)]
	[Browsable(false)]
	public eRenderMode RenderMode
	{
		get
		{
			return eRenderMode_0;
		}
		set
		{
			if (eRenderMode_0 != value)
			{
				eRenderMode_0 = value;
				((Control)this).Invalidate(true);
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public BaseRenderer Renderer
	{
		get
		{
			return baseRenderer_1;
		}
		set
		{
			baseRenderer_1 = value;
		}
	}

	[Category("Appearance")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	public bool AntiAlias
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				InvalidateAutoSize();
				((Control)this).Invalidate();
			}
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Description("Gets or sets Bar Color Scheme.")]
	[Category("Appearance")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ColorScheme ColorScheme
	{
		get
		{
			return colorScheme_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentException("NULL is not a valid value for this property.");
			}
			colorScheme_0 = value;
			if (((Control)this).get_Visible())
			{
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Description("Specifies whether button is drawn using Themes when running on OS that supports themes like Windows XP.")]
	public virtual bool ThemeAware
	{
		get
		{
			return popupItem_0.ThemeAware;
		}
		set
		{
			popupItem_0.ThemeAware = value;
			RecalcLayout();
		}
	}

	protected bool IsThemed
	{
		get
		{
			if (ThemeAware && popupItem_0.Style != eDotNetBarStyle.Office2000 && Class109.Boolean_0 && Class58.bool_0)
			{
				return true;
			}
			return false;
		}
	}

	internal BaseItem BaseItem_0 => popupItem_0;

	bool IOwnerMenuSupport.PersonalizedAllVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool IOwnerMenuSupport.ShowFullMenusOnHover
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	bool IOwnerMenuSupport.AlwaysShowFullMenus
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool IOwnerMenuSupport.ShowPopupShadow => true;

	eMenuDropShadow IOwnerMenuSupport.MenuDropShadow
	{
		get
		{
			return eMenuDropShadow.SystemDefault;
		}
		set
		{
		}
	}

	ePopupAnimation IOwnerMenuSupport.PopupAnimation
	{
		get
		{
			return ePopupAnimation.SystemDefault;
		}
		set
		{
		}
	}

	bool IOwnerMenuSupport.AlphaBlendShadow
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	internal bool Boolean_0
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
				if (bool_3)
				{
					SetupActiveWindowTimer();
				}
				else
				{
					ReleaseActiveWindowTimer();
					ClosePopups();
				}
				((Control)this).Invalidate();
			}
		}
	}

	bool Interface5.Boolean_0
	{
		get
		{
			Form val = ((Control)this).FindForm();
			if (val != null && val.get_Modal() && Form.get_ActiveForm() == val)
			{
				return true;
			}
			return false;
		}
	}

	protected bool IsParentFormActive
	{
		get
		{
			Form val = ((Control)this).FindForm();
			if (val == null)
			{
				return false;
			}
			if (val.get_IsMdiChild())
			{
				if (val.get_MdiParent() == null)
				{
					return false;
				}
				if (val.get_MdiParent().get_ActiveMdiChild() != val)
				{
					return false;
				}
			}
			else if (val != Form.get_ActiveForm())
			{
				return false;
			}
			return true;
		}
	}

	Class77 Interface6.Class77_0
	{
		get
		{
			if (class77_0 == null)
			{
				class77_0 = new Class77((Control)(object)this);
			}
			return class77_0;
		}
	}

	Class78 Interface6.Class78_0
	{
		get
		{
			if (class78_0 == null)
			{
				class78_0 = new Class78((Control)(object)this);
			}
			return class78_0;
		}
	}

	Class79 Interface6.Class79_0
	{
		get
		{
			if (class79_0 == null)
			{
				class79_0 = new Class79((Control)(object)this);
			}
			return class79_0;
		}
	}

	Class65 Interface6.Class65_0
	{
		get
		{
			if (class65_0 == null)
			{
				class65_0 = new Class65((Control)(object)this);
			}
			return class65_0;
		}
	}

	Class63 Interface6.Class63_0
	{
		get
		{
			if (class63_0 == null)
			{
				class63_0 = new Class63((Control)(object)this);
			}
			return class63_0;
		}
	}

	Class81 Interface6.Class81_0
	{
		get
		{
			if (class81_0 == null)
			{
				class81_0 = new Class81((Control)(object)this);
			}
			return class81_0;
		}
	}

	Class64 Interface6.Class64_0
	{
		get
		{
			if (class64_0 == null)
			{
				class64_0 = new Class64((Control)(object)this);
			}
			return class64_0;
		}
	}

	Class82 Interface6.Class82_0
	{
		get
		{
			if (class82_0 == null)
			{
				class82_0 = new Class82((Control)(object)this);
			}
			return class82_0;
		}
	}

	Form IOwner.ParentForm
	{
		get
		{
			return ((Control)this).FindForm();
		}
		set
		{
		}
	}

	bool IOwner.DesignMode => method_2();

	Form IOwner.ActiveMdiChild
	{
		get
		{
			Form val = ((Control)this).FindForm();
			if (val == null)
			{
				return null;
			}
			if (val.get_IsMdiContainer())
			{
				return val.get_ActiveMdiChild();
			}
			return null;
		}
	}

	bool IOwner.AlwaysDisplayKeyAccelerators
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	bool IOwner.ShowResetButton
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool IOwner.DragInProgress => false;

	BaseItem IOwner.DragItem => null;

	[Category("Data")]
	[DefaultValue(null)]
	[Browsable(false)]
	[Description("ImageList for images used on Items. Images specified here will always be used on menu-items and are by default used on all Bars.")]
	public ImageList Images
	{
		get
		{
			return imageList_0;
		}
		set
		{
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed -= imageList_2_Disposed;
			}
			imageList_0 = value;
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed += imageList_2_Disposed;
			}
		}
	}

	[Browsable(false)]
	[Category("Data")]
	[Description("ImageList for medium-sized images used on Items.")]
	[DefaultValue(null)]
	public ImageList ImagesMedium
	{
		get
		{
			return imageList_1;
		}
		set
		{
			if (imageList_1 != null)
			{
				((Component)(object)imageList_1).Disposed -= imageList_2_Disposed;
			}
			imageList_1 = value;
			if (imageList_1 != null)
			{
				((Component)(object)imageList_1).Disposed += imageList_2_Disposed;
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	[Category("Data")]
	[Description("ImageList for large-sized images used on Items.")]
	public ImageList ImagesLarge
	{
		get
		{
			return imageList_2;
		}
		set
		{
			if (imageList_2 != null)
			{
				((Component)(object)imageList_2).Disposed -= imageList_2_Disposed;
			}
			imageList_2 = value;
			if (imageList_2 != null)
			{
				((Component)(object)imageList_2).Disposed += imageList_2_Disposed;
			}
		}
	}

	bool IOwner.ShowToolTips
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	bool IOwner.ShowShortcutKeysInToolTips
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Gets or sets whether gray-scale algorithm is used to create automatic gray-scale images.")]
	public virtual bool DisabledImagesGrayScale
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
		}
	}

	BaseItem IAccessibilitySupport.DoDefaultActionItem
	{
		get
		{
			return baseItem_2;
		}
		set
		{
			baseItem_2 = value;
		}
	}

	[Description("Occurs when popup of type container is loading.")]
	public event EventHandler PopupContainerLoad
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

	[Description("Occurs when popup of type container is unloading.")]
	public event EventHandler PopupContainerUnload
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

	[Description("Occurs when popup item is about to open.")]
	public event EventHandler PopupOpen
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

	[Description("Occurs when popup item is closing.")]
	public event EventHandler PopupClose
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

	[Description("Occurs just before popup window is shown.")]
	public event EventHandler PopupShowing
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

	public event DotNetBarManager.LocalizeStringEventHandler LocalizeString
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			localizeStringEventHandler_0 = (DotNetBarManager.LocalizeStringEventHandler)Delegate.Combine(localizeStringEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			localizeStringEventHandler_0 = (DotNetBarManager.LocalizeStringEventHandler)Delegate.Remove(localizeStringEventHandler_0, value);
		}
	}

	public PopupItemControl()
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		Class274.smethod_17();
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		popupItem_0 = CreatePopupItem();
		popupItem_0.GlobalItem = false;
		popupItem_0.ContainerControl = this;
		popupItem_0.Style = eDotNetBarStyle.Office2007;
		popupItem_0.method_6(this);
		colorScheme_0 = new ColorScheme(popupItem_0.Style);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).SetStyle((ControlStyles)1, false);
		((Control)this).SetStyle((ControlStyles)512, true);
	}

	protected abstract PopupItem CreatePopupItem();

	internal void method_0(AccessibleEvents accessibleEvents_0, int int_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).AccessibilityNotifyClients(accessibleEvents_0, int_0);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Control)this).OnFontChanged(e);
		RecalcLayout();
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		popupItem_0.Enabled = ((Control)this).get_Enabled();
		((Control)this).OnEnabledChanged(e);
	}

	protected internal virtual ColorScheme GetColorScheme()
	{
		if (Style == eDotNetBarStyle.Office2007)
		{
			BaseRenderer renderer = GetRenderer();
			if (renderer is Office2007Renderer)
			{
				return ((Office2007Renderer)renderer).ColorTable.LegacyColors;
			}
		}
		return colorScheme_0;
	}

	public void RecalcLayout()
	{
		RecalcSize();
		((Control)this).Invalidate();
	}

	protected abstract void RecalcSize();

	internal void method_1(bool bool_5)
	{
		popupItem_0.SetDesignMode(bool_5);
	}

	public Graphics CreateGraphics()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = ((Control)this).CreateGraphics();
		if (bool_0)
		{
			val.set_SmoothingMode((SmoothingMode)4);
			if (!SystemInformation.get_IsFontSmoothingEnabled())
			{
				val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
		}
		return val;
	}

	internal virtual ItemPaintArgs vmethod_0(Graphics graphics_0)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this, (Control)(object)this, graphics_0, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		itemPaintArgs.ButtonStringFormat &= ~(itemPaintArgs.ButtonStringFormat & eTextFormat.SingleLine);
		itemPaintArgs.ButtonStringFormat |= eTextFormat.EndEllipsis | eTextFormat.WordBreak;
		return itemPaintArgs;
	}

	public virtual BaseRenderer GetRenderer()
	{
		if (eRenderMode_0 == eRenderMode.Global && GlobalManager.Renderer != null)
		{
			return GlobalManager.Renderer;
		}
		if (eRenderMode_0 == eRenderMode.Custom && baseRenderer_1 != null)
		{
			return baseRenderer_1;
		}
		if (baseRenderer_0 == null && Style == eDotNetBarStyle.Office2007)
		{
			baseRenderer_0 = new Office2007Renderer();
		}
		return baseRenderer_1;
	}

	protected virtual void InvalidateAutoSize()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private bool ShouldSerializeColorScheme()
	{
		return colorScheme_0.SchemeChanged;
	}

	private bool method_2()
	{
		return ((Component)this).DesignMode;
	}

	void IOwnerMenuSupport.RegisterPopup(PopupItem objPopup)
	{
		Boolean_0 = true;
		if (arrayList_0.Contains(objPopup))
		{
			return;
		}
		if (!method_2())
		{
			if (!bool_1)
			{
				Class107.smethod_0(this);
				bool_1 = true;
			}
		}
		else if (class94_0 == null)
		{
			class94_0 = new Class94(this);
		}
		if (!bool_2)
		{
			method_6();
		}
		arrayList_0.Add(objPopup);
		if (objPopup.GetOwner() != this)
		{
			objPopup.method_6(this);
		}
	}

	void IOwnerMenuSupport.UnregisterPopup(PopupItem objPopup)
	{
		if (arrayList_0.Contains(objPopup))
		{
			arrayList_0.Remove(objPopup);
		}
		if (arrayList_0.Count == 0)
		{
			method_7();
			if (class94_0 != null)
			{
				class94_0.Dispose();
				class94_0 = null;
			}
			Boolean_0 = false;
		}
	}

	bool IOwnerMenuSupport.RelayMouseHover()
	{
		foreach (PopupItem item in arrayList_0)
		{
			Control popupControl = item.PopupControl;
			if (popupControl != null && popupControl.get_DisplayRectangle().Contains(Control.get_MousePosition()))
			{
				if (popupControl is MenuPanel)
				{
					((MenuPanel)(object)popupControl).method_23();
				}
				else if (popupControl is Bar)
				{
					((Bar)(object)popupControl).method_57();
				}
				return true;
			}
		}
		return false;
	}

	void IOwnerMenuSupport.ClosePopups()
	{
		ClosePopups();
	}

	private void ClosePopups()
	{
		ArrayList arrayList = new ArrayList(arrayList_0);
		foreach (PopupItem item in arrayList)
		{
			item.ClosePopup();
		}
	}

	void IOwnerMenuSupport.InvokePopupClose(PopupItem item, EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupContainerLoad(PopupItem item, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupContainerUnload(PopupItem item, EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupOpen(PopupItem item, PopupOpenEventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupShowing(PopupItem item, EventArgs e)
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(item, e);
		}
	}

	protected virtual void SetupActiveWindowTimer()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if (timer_0 == null)
		{
			timer_0 = new Timer();
			timer_0.set_Interval(100);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			intptr_0 = Class92.GetForegroundWindow();
			intptr_1 = Class92.GetActiveWindow();
			timer_0.Start();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (timer_0 == null)
		{
			return;
		}
		IntPtr foregroundWindow = Class92.GetForegroundWindow();
		IntPtr activeWindow = Class92.GetActiveWindow();
		if (!(foregroundWindow != intptr_0) && !(activeWindow != intptr_1))
		{
			return;
		}
		Control val = Control.FromChildHandle(activeWindow);
		if (val != null)
		{
			do
			{
				if (!(val is MenuPanel) && !(val is Bar) && !(val is PopupContainer) && !(val is PopupContainerControl))
				{
					val = val.get_Parent();
					continue;
				}
				return;
			}
			while (val != null && val.get_Parent() != null);
		}
		timer_0.Stop();
		OnActiveWindowChanged();
	}

	protected virtual void OnActiveWindowChanged()
	{
		if (Boolean_0)
		{
			Boolean_0 = false;
		}
	}

	protected virtual void ReleaseActiveWindowTimer()
	{
		if (timer_0 != null)
		{
			Timer val = timer_0;
			timer_0 = null;
			val.Stop();
			val.remove_Tick((EventHandler)timer_0_Tick);
			((Component)(object)val).Dispose();
		}
	}

	bool Interface5.imethod_5(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return vmethod_1(intptr_2, intptr_3, intptr_4);
	}

	protected virtual bool vmethod_1(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return false;
	}

	bool Interface5.imethod_2(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return vmethod_2(intptr_2, intptr_3, intptr_4);
	}

	protected virtual bool vmethod_2(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected I4, but got Unknown
		if (arrayList_0.Count > 0 && ((BaseItem)arrayList_0[arrayList_0.Count - 1]).Parent == null)
		{
			PopupItem popupItem = (PopupItem)arrayList_0[arrayList_0.Count - 1];
			Control popupControl = popupItem.PopupControl;
			Control val = Control.FromChildHandle(intptr_2);
			if (val != null)
			{
				while (val.get_Parent() != null)
				{
					val = val.get_Parent();
				}
			}
			bool flag = false;
			if (val != null && popupItem != null)
			{
				flag = popupItem.IsAnyOnHandle(val.get_Handle().ToInt32());
			}
			bool flag2 = (popupControl != null && val != null && popupControl.get_Handle() == val.get_Handle()) || flag;
			if (!flag)
			{
				Keys val2 = (Keys)Class92.MapVirtualKey((uint)(int)intptr_3, 2u);
				if ((int)val2 == 0)
				{
					val2 = (Keys)intptr_3.ToInt32();
				}
				popupItem.InternalKeyDown(new KeyEventArgs(val2));
			}
			if (flag2)
			{
				return false;
			}
			return true;
		}
		if (Boolean_0)
		{
			bool flag3 = true;
			Control val3 = Control.FromChildHandle(intptr_2);
			if (val3 != null)
			{
				while (val3.get_Parent() != null)
				{
					val3 = val3.get_Parent();
				}
				if ((val3 is MenuPanel || val3 is ItemControl || val3 is PopupContainer || val3 is PopupContainerControl) && val3.get_Handle() != intptr_2)
				{
					flag3 = false;
				}
			}
			if (flag3)
			{
				Keys val4 = (Keys)Class92.MapVirtualKey((uint)(int)intptr_3, 2u);
				if ((int)val4 == 0)
				{
					val4 = (Keys)intptr_3.ToInt32();
				}
				popupItem_0.InternalKeyDown(new KeyEventArgs(val4));
				return true;
			}
		}
		if (!IsParentFormActive)
		{
			return false;
		}
		if (intptr_3.ToInt32() < 112 && (int)Control.get_ModifierKeys() == 0 && (intptr_4.ToInt32() & 0x1000000000L) == 0L && intptr_3.ToInt32() != 46 && intptr_3.ToInt32() != 45)
		{
			return false;
		}
		int eShortcut_ = Control.get_ModifierKeys() | intptr_3.ToInt32();
		return method_3((eShortcut)eShortcut_);
	}

	private bool method_3(eShortcut eShortcut_0)
	{
		foreach (eShortcut shortcut in popupItem_0.Shortcuts)
		{
			if (shortcut == eShortcut_0)
			{
				PerformClick();
				return true;
			}
		}
		return Class109.smethod_5(eShortcut_0, hashtable_0);
	}

	public abstract void PerformClick();

	private Class197 method_4()
	{
		if (class197_0 == null)
		{
			class197_0 = new Class197();
		}
		return class197_0;
	}

	internal void method_5()
	{
		method_4().method_3();
	}

	bool Interface5.imethod_3(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		if (arrayList_0.Count == 0)
		{
			return false;
		}
		BaseItem[] array = new BaseItem[arrayList_0.Count];
		arrayList_0.CopyTo(array);
		for (int num = array.Length - 1; num >= 0; num--)
		{
			PopupItem popupItem = array[num] as PopupItem;
			bool flag;
			if (!(flag = popupItem.IsAnyOnHandle(intptr_2.ToInt32())))
			{
				Control val = Control.FromChildHandle(intptr_2);
				if (val != null)
				{
					if (val is MenuPanel)
					{
						flag = true;
					}
					else
					{
						while (val.get_Parent() != null)
						{
							val = val.get_Parent();
							if (((object)val).GetType().FullName!.IndexOf("DropDownHolder") >= 0 || val is MenuPanel || val is PopupContainerControl)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						flag = popupItem.IsAnyOnHandle(val.get_Handle().ToInt32());
					}
				}
				else
				{
					string text = Class92.smethod_8(intptr_2);
					text = text.ToLower();
					if (text.IndexOf("combolbox") >= 0)
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				Control val2 = popupItem.PopupControl;
				if (val2 != null)
				{
					while (val2.get_Parent() != null)
					{
						val2 = val2.get_Parent();
					}
				}
				if (val2 != null && val2.get_Bounds().Contains(Control.get_MousePosition()))
				{
					flag = true;
				}
			}
			if (flag)
			{
				break;
			}
			if (popupItem.Displayed)
			{
				Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
				if (popupItem.DisplayRectangle.Contains(pt))
				{
					break;
				}
			}
			if (method_2())
			{
				method_4().method_2(popupItem);
			}
			else
			{
				popupItem.ClosePopup();
			}
			if (arrayList_0.Count == 0)
			{
				break;
			}
		}
		if (arrayList_0.Count == 0)
		{
			Boolean_0 = false;
		}
		return false;
	}

	bool Interface5.imethod_4(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		if (arrayList_0.Count > 0)
		{
			foreach (BaseItem item in arrayList_0)
			{
				if (item.Parent == null)
				{
					Control popupControl = ((PopupItem)item).PopupControl;
					if (popupControl != null && popupControl.get_Handle() != intptr_2 && !item.IsAnyOnHandle(intptr_2.ToInt32()) && (popupControl.get_Parent() == null || !(popupControl.get_Parent().get_Handle() != intptr_2)))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	bool Interface5.imethod_0(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return vmethod_3(intptr_2, intptr_3, intptr_4);
	}

	protected virtual bool vmethod_3(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		if (!method_2() && ((int)Control.get_ModifierKeys() != 0 || (intptr_3.ToInt32() >= 112 && intptr_3.ToInt32() <= 123)))
		{
			int eShortcut_ = Control.get_ModifierKeys() | intptr_3.ToInt32();
			if (method_3((eShortcut)eShortcut_))
			{
				return true;
			}
		}
		return false;
	}

	bool Interface5.imethod_1(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return vmethod_4(intptr_2, intptr_3, intptr_4);
	}

	protected virtual bool vmethod_4(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return false;
	}

	private void method_6()
	{
		if (!bool_2)
		{
			bool_2 = true;
			Form val = ((Control)this).FindForm();
			if (val == null)
			{
				bool_2 = false;
				return;
			}
			((Control)val).add_Resize((EventHandler)method_8);
			val.add_Deactivate((EventHandler)method_9);
			DotNetBarManager.RegisterParentMsgHandler(this, val);
		}
	}

	private void method_7()
	{
		if (bool_2)
		{
			bool_2 = false;
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				DotNetBarManager.UnRegisterParentMsgHandler(this, val);
				((Control)val).remove_Resize((EventHandler)method_8);
				val.remove_Deactivate((EventHandler)method_9);
			}
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 794)
		{
			RefreshThemes();
		}
		else if (((Message)(ref m)).get_Msg() == 1131 && baseItem_2 != null)
		{
			if (!baseItem_2.bool_21)
			{
				PerformClick();
			}
			baseItem_2.vmethod_0();
			baseItem_2 = null;
		}
		((Control)this).WndProc(ref m);
	}

	protected void RefreshThemes()
	{
		if (class77_0 != null)
		{
			class77_0.Dispose();
			class77_0 = new Class77((Control)(object)this);
		}
		if (class78_0 != null)
		{
			class78_0.Dispose();
			class78_0 = new Class78((Control)(object)this);
		}
		if (class79_0 != null)
		{
			class79_0.Dispose();
			class79_0 = new Class79((Control)(object)this);
		}
		if (class65_0 != null)
		{
			class65_0.Dispose();
			class65_0 = new Class65((Control)(object)this);
		}
		if (class63_0 != null)
		{
			class63_0.Dispose();
			class63_0 = new Class63((Control)(object)this);
		}
		if (class64_0 != null)
		{
			class64_0.Dispose();
			class64_0 = new Class64((Control)(object)this);
		}
		if (class81_0 != null)
		{
			class81_0.Dispose();
			class81_0 = new Class81((Control)(object)this);
		}
		if (class82_0 != null)
		{
			class82_0.Dispose();
			class82_0 = new Class82((Control)(object)this);
		}
	}

	private void method_10()
	{
		if (class77_0 != null)
		{
			class77_0.Dispose();
			class77_0 = null;
		}
		if (class78_0 != null)
		{
			class78_0.Dispose();
			class78_0 = null;
		}
		if (class79_0 != null)
		{
			class79_0.Dispose();
			class79_0 = null;
		}
		if (class65_0 != null)
		{
			class65_0.Dispose();
			class65_0 = null;
		}
		if (class63_0 != null)
		{
			class63_0.Dispose();
			class63_0 = null;
		}
		if (class64_0 != null)
		{
			class64_0.Dispose();
			class64_0 = null;
		}
		if (class81_0 != null)
		{
			class81_0.Dispose();
			class81_0 = null;
		}
		if (class82_0 != null)
		{
			class82_0.Dispose();
			class82_0 = null;
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		if (!bool_1 && !((Component)this).DesignMode)
		{
			Class107.smethod_0(this);
			bool_1 = true;
		}
		if (((Control)this).get_AutoSize())
		{
			AdjustSize();
		}
		RecalcLayout();
	}

	protected virtual void AdjustSize()
	{
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_10();
		method_7();
		((Control)this).OnHandleDestroyed(e);
		if (bool_1)
		{
			Class107.smethod_1(this);
			bool_1 = false;
		}
	}

	ArrayList IOwner.GetItems(string ItemName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_46(popupItem_0, ItemName, arrayList);
		return arrayList;
	}

	ArrayList IOwner.GetItems(string ItemName, Type itemType)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_48(popupItem_0, ItemName, arrayList, itemType);
		return arrayList;
	}

	ArrayList IOwner.GetItems(string ItemName, Type itemType, bool useGlobalName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_49(popupItem_0, ItemName, arrayList, itemType, useGlobalName);
		return arrayList;
	}

	BaseItem IOwner.GetItem(string ItemName)
	{
		BaseItem baseItem = Class109.smethod_44(popupItem_0, ItemName);
		if (baseItem != null)
		{
			return baseItem;
		}
		return null;
	}

	void IOwner.SetExpandedItem(BaseItem objItem)
	{
		if (objItem != null && objItem.Parent is PopupItem)
		{
			return;
		}
		if (baseItem_0 != null)
		{
			if (baseItem_0.Expanded)
			{
				baseItem_0.Expanded = false;
			}
			baseItem_0 = null;
		}
		baseItem_0 = objItem;
	}

	BaseItem IOwner.GetExpandedItem()
	{
		return baseItem_0;
	}

	void IOwner.SetFocusItem(BaseItem objFocusItem)
	{
		if (baseItem_1 != null && baseItem_1 != objFocusItem)
		{
			baseItem_1.OnLostFocus();
		}
		baseItem_1 = objFocusItem;
		if (baseItem_1 != null)
		{
			baseItem_1.OnGotFocus();
		}
	}

	BaseItem IOwner.GetFocusItem()
	{
		return baseItem_1;
	}

	void IOwner.DesignTimeContextMenu(BaseItem objItem)
	{
	}

	void IOwner.RemoveShortcutsFromItem(BaseItem objItem)
	{
		Class49 @class = null;
		if (objItem.ShortcutString != "")
		{
			foreach (eShortcut shortcut in objItem.Shortcuts)
			{
				if (!hashtable_0.ContainsKey(shortcut))
				{
					continue;
				}
				@class = (Class49)hashtable_0[shortcut];
				try
				{
					@class.hashtable_0.Remove(objItem.Id);
					if (@class.hashtable_0.Count == 0)
					{
						hashtable_0.Remove(@class.eShortcut_0);
					}
				}
				catch (ArgumentException)
				{
				}
			}
		}
		foreach (BaseItem subItem in objItem.SubItems)
		{
			((IOwner)this).RemoveShortcutsFromItem(subItem);
		}
	}

	void IOwner.AddShortcutsFromItem(BaseItem objItem)
	{
		Class49 @class = null;
		if (objItem.ShortcutString != "")
		{
			foreach (eShortcut shortcut in objItem.Shortcuts)
			{
				if (hashtable_0.ContainsKey(shortcut))
				{
					@class = (Class49)hashtable_0[objItem.Shortcuts[0]];
				}
				else
				{
					@class = new Class49(shortcut);
					hashtable_0.Add(@class.eShortcut_0, @class);
				}
				try
				{
					@class.hashtable_0.Add(objItem.Id, objItem);
				}
				catch (ArgumentException)
				{
				}
			}
		}
		foreach (BaseItem subItem in objItem.SubItems)
		{
			((IOwner)this).AddShortcutsFromItem(subItem);
		}
	}

	void IOwner.Customize()
	{
	}

	void IOwner.InvokeResetDefinition(BaseItem item, EventArgs e)
	{
	}

	void IOwner.OnApplicationActivate()
	{
	}

	void IOwner.OnApplicationDeactivate()
	{
		ClosePopups();
	}

	void IOwner.OnParentPositionChanging()
	{
	}

	void IOwner.StartItemDrag(BaseItem objItem)
	{
	}

	void IOwner.InvokeUserCustomize(object sender, EventArgs e)
	{
	}

	void IOwner.InvokeEndUserCustomize(object sender, EndUserCustomizeEventArgs e)
	{
	}

	MdiClient IOwner.GetMdiClient(Form MdiForm)
	{
		return Class109.smethod_58(MdiForm);
	}

	private void imageList_2_Disposed(object sender, EventArgs e)
	{
		if (sender == imageList_0)
		{
			imageList_0 = null;
		}
		else if (sender == imageList_2)
		{
			imageList_2 = null;
		}
		else if (sender == imageList_1)
		{
			imageList_1 = null;
		}
	}

	protected override void OnParentChanged(EventArgs e)
	{
		((Control)this).OnParentChanged(e);
		if (((Component)this).DesignMode)
		{
			popupItem_0.SetDesignMode(((Component)this).DesignMode);
		}
	}

	void IOwner.InvokeDefinitionLoaded(object sender, EventArgs e)
	{
	}

	void IOwnerLocalize.InvokeLocalizeString(LocalizeEventArgs e)
	{
		if (localizeStringEventHandler_0 != null)
		{
			localizeStringEventHandler_0(this, e);
		}
	}
}

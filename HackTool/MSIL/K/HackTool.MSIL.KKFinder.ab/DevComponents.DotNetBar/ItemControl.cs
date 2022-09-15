using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[ComVisible(false)]
[DefaultEvent("ItemClick")]
public abstract class ItemControl : ContainerControl, Interface0, IBarDesignerServices, IAccessibilitySupport, IBarImageSize, IKeyTipsControl, IOwner, IOwnerItemEvents, IOwnerLocalize, IOwnerMenuSupport, IRenderingSupport, IRibbonCustomize, Interface5, Interface6
{
	public delegate void ItemRemovedEventHandler(object sender, ItemRemovedEventArgs e);

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private EventHandler eventHandler_3;

	private EventHandler eventHandler_4;

	private EventHandler eventHandler_5;

	private EventHandler eventHandler_6;

	private EventHandler eventHandler_7;

	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private EventHandler eventHandler_8;

	private EventHandler eventHandler_9;

	private MouseEventHandler mouseEventHandler_2;

	private EventHandler eventHandler_10;

	private EventHandler eventHandler_11;

	private EventHandler eventHandler_12;

	private EventHandler eventHandler_13;

	private ItemRemovedEventHandler itemRemovedEventHandler_0;

	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	private EventHandler eventHandler_16;

	private ControlContainerItem.ControlContainerSerializationEventHandler controlContainerSerializationEventHandler_0;

	private ControlContainerItem.ControlContainerSerializationEventHandler controlContainerSerializationEventHandler_1;

	private EventHandler eventHandler_17;

	private DotNetBarManager.LocalizeStringEventHandler localizeStringEventHandler_0;

	private OptionGroupChangingEventHandler optionGroupChangingEventHandler_0;

	private EventHandler eventHandler_18;

	private BaseItem baseItem_0;

	private BaseItem baseItem_1;

	private BaseItem baseItem_2;

	private Hashtable hashtable_0 = new Hashtable();

	private ImageList imageList_0;

	private ImageList imageList_1;

	private ImageList imageList_2;

	private BaseItem baseItem_3;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private Cursor cursor_0;

	private Cursor cursor_1;

	private bool bool_6 = true;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private IDesignTimeProvider idesignTimeProvider_0;

	private int int_0;

	private bool bool_11;

	private Timer timer_0;

	private BaseItem baseItem_4;

	private Class77 class77_0;

	private Class78 class78_0;

	private Class79 class79_0;

	private Class65 class65_0;

	private Class63 class63_0;

	private Class81 class81_0;

	private Class64 class64_0;

	private Class82 class82_0;

	private ColorScheme colorScheme_0;

	private bool bool_12;

	private string string_0 = "Right-click to add more items...";

	private ElementStyle elementStyle_0 = new ElementStyle();

	private bool bool_13;

	private bool bool_14 = true;

	private bool bool_15;

	private bool bool_16;

	private BarBaseControlDesigner barBaseControlDesigner_0;

	private bool bool_17;

	private Font font_0;

	private string string_1 = "";

	private Control1 control1_0;

	private bool bool_18;

	private int int_1;

	private Timer timer_1;

	private IntPtr intptr_0 = IntPtr.Zero;

	private IntPtr intptr_1 = IntPtr.Zero;

	private bool bool_19 = true;

	private BaseItem baseItem_5;

	private eBarImageSize eBarImageSize_0;

	private bool bool_20 = true;

	private bool bool_21;

	private bool bool_22;

	private Class94 class94_0;

	private ArrayList arrayList_0 = new ArrayList();

	private Class197 class197_0;

	private int int_2;

	private bool bool_23 = true;

	private bool bool_24 = true;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	private int int_3;

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

	bool IOwner.DesignMode => GetDesignMode();

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

	[Category("Run-time Behavior")]
	[Description("Indicates whether accelerator letters for buttons are underlined regardless of current Windows settings.")]
	[Browsable(true)]
	[DefaultValue(false)]
	public bool AlwaysDisplayKeyAccelerators
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
				((Control)this).Invalidate();
			}
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

	[Browsable(false)]
	public bool DragInProgress => bool_4;

	BaseItem IOwner.DragItem => baseItem_3;

	[Description("ImageList for images used on Items. Images specified here will always be used on menu-items and are by default used on all Bars.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Data")]
	public virtual ImageList Images
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

	[DefaultValue(null)]
	[Browsable(true)]
	[Description("ImageList for medium-sized images used on Items.")]
	[Category("Data")]
	public virtual ImageList ImagesMedium
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

	[Description("ImageList for large-sized images used on Items.")]
	[Browsable(true)]
	[Category("Data")]
	[DefaultValue(null)]
	public virtual ImageList ImagesLarge
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

	[Category("Run-time Behavior")]
	[Browsable(true)]
	[Description("Indicates whether Tooltips are shown on Bars and menus.")]
	[DefaultValue(true)]
	public bool ShowToolTips
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	[DefaultValue(false)]
	[Category("Run-time Behavior")]
	[Description("Indicates whether item shortcut is displayed in Tooltips.")]
	[Browsable(true)]
	public virtual bool ShowShortcutKeysInToolTips
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

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

	[Category("Behavior")]
	[Description("Gets or sets whether hooks are used for internal DotNetBar system functionality. Using hooks is recommended only if DotNetBar is used in hybrid environments like Visual Studio designers or IE.")]
	[DefaultValue(false)]
	[Browsable(false)]
	public bool UseHook
	{
		get
		{
			return bool_21;
		}
		set
		{
			if (bool_21 != value)
			{
				bool_21 = value;
			}
		}
	}

	bool IOwnerMenuSupport.ShowPopupShadow => true;

	eMenuDropShadow IOwnerMenuSupport.MenuDropShadow
	{
		get
		{
			return eMenuDropShadow.Hide;
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

	internal virtual bool Boolean_3
	{
		get
		{
			return bool_18;
		}
		set
		{
			if (bool_18 == value)
			{
				return;
			}
			method_4(value);
			if (bool_18)
			{
				if (baseItem_0 is GenericItemContainer)
				{
					((GenericItemContainer)baseItem_0).method_29();
				}
				else if (baseItem_0 is RibbonStripContainerItem)
				{
					((RibbonStripContainerItem)baseItem_0).method_19();
				}
				SetupActiveWindowTimer();
			}
			else
			{
				ReleaseActiveWindowTimer();
				if (baseItem_0 is GenericItemContainer)
				{
					((GenericItemContainer)baseItem_0).AutoExpand = false;
					((GenericItemContainer)baseItem_0).method_30();
					((GenericItemContainer)baseItem_0).ContainerLostFocus(appLostFocus: false);
				}
				else if (baseItem_0 is RibbonStripContainerItem)
				{
					((RibbonStripContainerItem)baseItem_0).AutoExpand = false;
					((RibbonStripContainerItem)baseItem_0).method_18();
					((RibbonStripContainerItem)baseItem_0).ContainerLostFocus(appLostFocus: false);
				}
			}
			((Control)this).Refresh();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public Control LastFocusControl
	{
		get
		{
			if (((Control)this).get_Focused() && int_1 != 0)
			{
				return Control.FromChildHandle(new IntPtr(int_1));
			}
			return null;
		}
	}

	bool Interface5.Boolean_0
	{
		get
		{
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				return val.get_Modal();
			}
			return false;
		}
	}

	internal bool Boolean_0 => arrayList_0.Count > 0;

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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool ShortcutsEnabled
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

	BaseItem IAccessibilitySupport.DoDefaultActionItem
	{
		get
		{
			return baseItem_5;
		}
		set
		{
			baseItem_5 = value;
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether control height is set automatically.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Layout")]
	public override bool AutoSize
	{
		get
		{
			return bool_15;
		}
		set
		{
			bool_15 = value;
			method_15();
		}
	}

	protected virtual string EmptyContainerDesignTimeHint
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets bar background style.")]
	[Category("Style")]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Indicates whether shortucts handled by items are dispatched to the next handler or control.")]
	[Category("Behavior")]
	public bool DispatchShortcuts
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
		}
	}

	[Description("Gets or sets Bar Color Scheme.")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
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
				((Control)this).Refresh();
			}
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool AntiAlias
	{
		get
		{
			return bool_14;
		}
		set
		{
			if (bool_14 != value)
			{
				bool_14 = value;
				((Control)this).Invalidate();
			}
		}
	}

	protected bool IsThemed
	{
		get
		{
			if (bool_12 && baseItem_0.Style != eDotNetBarStyle.Office2000 && Class109.Boolean_0 && Class58.bool_0)
			{
				return true;
			}
			return false;
		}
	}

	[Description("Gets or sets whether gray-scale algorithm is used to create automatic gray-scale images.")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool DisabledImagesGrayScale
	{
		get
		{
			return bool_23;
		}
		set
		{
			bool_23 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Appearance")]
	[Description("Specifies whether SideBar is drawn using Themes when running on OS that supports themes like Windows XP.")]
	public virtual bool ThemeAware
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
			baseItem_0.ThemeAware = value;
			if (GetDesignMode())
			{
				((Control)this).Refresh();
			}
		}
	}

	internal bool Boolean_1
	{
		get
		{
			return bool_16;
		}
		set
		{
			if (bool_16 != value)
			{
				bool_16 = value;
				((Control)this).Refresh();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool ShowKeyTips
	{
		get
		{
			return bool_17;
		}
		set
		{
			if (bool_17 != value)
			{
				bool_17 = value;
				OnShowKeyTipsChanged();
			}
		}
	}

	string IKeyTipsControl.KeyTipsKeysStack
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			if (control1_0 != null && ((Control)control1_0).get_Parent() != null)
			{
				((Control)control1_0).get_Parent().Invalidate(true);
			}
		}
	}

	[Description("Indicates font that is used to display Key Tips (accelerator keys) when they are displayed.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(null)]
	public virtual Font KeyTipsFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
		}
	}

	internal virtual bool Boolean_6
	{
		get
		{
			if (GetDesignMode())
			{
				return false;
			}
			return Class51.Boolean_0;
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

	[Browsable(false)]
	[DefaultValue(null)]
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

	protected virtual bool NeedsTopLevelKeyTipCanvasParent => false;

	[Description("Indicates whether mouse over fade effect is enabled")]
	[DefaultValue(true)]
	[Category("Appearance")]
	[Browsable(true)]
	public bool FadeEffect
	{
		get
		{
			return bool_19;
		}
		set
		{
			bool_19 = value;
		}
	}

	internal bool Boolean_2
	{
		get
		{
			if (!((Component)this).DesignMode && baseItem_0.Style == eDotNetBarStyle.Office2007 && (!bool_19 || !Class92.smethod_7()) && !Class55.bool_1)
			{
				return bool_19;
			}
			return false;
		}
	}

	[Browsable(false)]
	public bool IsUpdateSuspended => int_3 > 0;

	BarBaseControlDesigner IBarDesignerServices.Designer
	{
		get
		{
			return barBaseControlDesigner_0;
		}
		set
		{
			barBaseControlDesigner_0 = value;
		}
	}

	[Description("Specifies the Image size that will be used by items on this bar.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(eBarImageSize.Default)]
	[Category("Behavior")]
	public virtual eBarImageSize ImageSize
	{
		get
		{
			return eBarImageSize_0;
		}
		set
		{
			eBarImageSize_0 = value;
			if (baseItem_0 is ImageItem)
			{
				((ImageItem)baseItem_0).RefreshImageSize();
			}
			RecalcLayout();
		}
	}

	[Category("Behavior")]
	[Browsable(false)]
	[Description("Gets or sets whether external ButtonItem object is accepted in drag and drop operation.")]
	[DefaultValue(false)]
	public virtual bool AllowExternalDrop
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	[Category("Behavior")]
	[Description("Specifies whether native .NET Drag and Drop is used by control to perform drag and drop operations.")]
	[DefaultValue(false)]
	[Browsable(false)]
	public virtual bool UseNativeDragDrop
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	[Category("Behavior")]
	[Description("Indicates whether internal automatic drag & drop support is enabled")]
	protected virtual bool DragDropSupport
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

	public event EventHandler ButtonCheckedChanged
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

	[Description("Occurs when Item is clicked.")]
	public event EventHandler ItemClick
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

	[Description("Occurs when popup of type container is loading.")]
	public event EventHandler PopupContainerLoad
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

	[Description("Occurs when popup of type container is unloading.")]
	public event EventHandler PopupContainerUnload
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

	[Description("Occurs when popup item is about to open.")]
	public event EventHandler PopupOpen
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

	[Description("Occurs when popup item is closing.")]
	public event EventHandler PopupClose
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_5 = (EventHandler)Delegate.Combine(eventHandler_5, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_5 = (EventHandler)Delegate.Remove(eventHandler_5, value);
		}
	}

	[Description("Occurs just before popup window is shown.")]
	public event EventHandler PopupShowing
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_6 = (EventHandler)Delegate.Combine(eventHandler_6, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_6 = (EventHandler)Delegate.Remove(eventHandler_6, value);
		}
	}

	[Description("Occurs when Item Expanded property has changed.")]
	public event EventHandler ExpandedChange
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_7 = (EventHandler)Delegate.Combine(eventHandler_7, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_7 = (EventHandler)Delegate.Remove(eventHandler_7, value);
		}
	}

	[Description("Occurs when mouse button is pressed.")]
	public event MouseEventHandler MouseDown
	{
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when mouse button is released.")]
	public event MouseEventHandler MouseUp
	{
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when mouse enters the item.")]
	public event EventHandler MouseEnter
	{
		add
		{
			eventHandler_8 = (EventHandler)Delegate.Combine(eventHandler_8, value);
		}
		remove
		{
			eventHandler_8 = (EventHandler)Delegate.Remove(eventHandler_8, value);
		}
	}

	[Description("Occurs when mouse leaves the item.")]
	public event EventHandler MouseLeave
	{
		add
		{
			eventHandler_9 = (EventHandler)Delegate.Combine(eventHandler_9, value);
		}
		remove
		{
			eventHandler_9 = (EventHandler)Delegate.Remove(eventHandler_9, value);
		}
	}

	[Description("Occurs when mouse moves over the item.")]
	public event MouseEventHandler MouseMove
	{
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when mouse remains still inside an item for an amount of time.")]
	public event EventHandler MouseHover
	{
		add
		{
			eventHandler_10 = (EventHandler)Delegate.Combine(eventHandler_10, value);
		}
		remove
		{
			eventHandler_10 = (EventHandler)Delegate.Remove(eventHandler_10, value);
		}
	}

	[Description("Occurs when item loses input focus.")]
	public event EventHandler LostFocus
	{
		add
		{
			eventHandler_11 = (EventHandler)Delegate.Combine(eventHandler_11, value);
		}
		remove
		{
			eventHandler_11 = (EventHandler)Delegate.Remove(eventHandler_11, value);
		}
	}

	[Description("Occurs when item receives input focus.")]
	public event EventHandler GotFocus
	{
		add
		{
			eventHandler_12 = (EventHandler)Delegate.Combine(eventHandler_12, value);
		}
		remove
		{
			eventHandler_12 = (EventHandler)Delegate.Remove(eventHandler_12, value);
		}
	}

	[Description("Occurs when user changes the item position.")]
	public event EventHandler UserCustomize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_13 = (EventHandler)Delegate.Combine(eventHandler_13, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_13 = (EventHandler)Delegate.Remove(eventHandler_13, value);
		}
	}

	[Description("Occurs after an Item is removed from SubItemsCollection.")]
	public event ItemRemovedEventHandler ItemRemoved
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			itemRemovedEventHandler_0 = (ItemRemovedEventHandler)Delegate.Combine(itemRemovedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			itemRemovedEventHandler_0 = (ItemRemovedEventHandler)Delegate.Remove(itemRemovedEventHandler_0, value);
		}
	}

	[Description("Occurs after an Item has been added to the SubItemsCollection.")]
	public event EventHandler ItemAdded
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

	[Description("Occurs when ControlContainerControl is created and contained control is needed.")]
	public event EventHandler ContainerLoadControl
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

	[Description("Occurs when Text property of an Item has changed.")]
	public event EventHandler ItemTextChanged
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

	public event ControlContainerItem.ControlContainerSerializationEventHandler ContainerControlSerialize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			controlContainerSerializationEventHandler_0 = (ControlContainerItem.ControlContainerSerializationEventHandler)Delegate.Combine(controlContainerSerializationEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			controlContainerSerializationEventHandler_0 = (ControlContainerItem.ControlContainerSerializationEventHandler)Delegate.Remove(controlContainerSerializationEventHandler_0, value);
		}
	}

	public event ControlContainerItem.ControlContainerSerializationEventHandler ContainerControlDeserialize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			controlContainerSerializationEventHandler_1 = (ControlContainerItem.ControlContainerSerializationEventHandler)Delegate.Combine(controlContainerSerializationEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			controlContainerSerializationEventHandler_1 = (ControlContainerItem.ControlContainerSerializationEventHandler)Delegate.Remove(controlContainerSerializationEventHandler_1, value);
		}
	}

	[Description("Occurs after DotNetBar definition is loaded.")]
	public event EventHandler DefinitionLoaded
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

	public event OptionGroupChangingEventHandler OptionGroupChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			optionGroupChangingEventHandler_0 = (OptionGroupChangingEventHandler)Delegate.Combine(optionGroupChangingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			optionGroupChangingEventHandler_0 = (OptionGroupChangingEventHandler)Delegate.Remove(optionGroupChangingEventHandler_0, value);
		}
	}

	public event EventHandler ToolTipShowing
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

	public ItemControl()
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		cursor_0 = null;
		cursor_1 = null;
		colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2003);
		elementStyle_0.method_4(colorScheme_0);
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		((Control)this).set_IsAccessible(true);
	}

	protected bool GetDesignMode()
	{
		if (!bool_13)
		{
			return ((Component)this).DesignMode;
		}
		return bool_13;
	}

	internal void method_0(bool bool_25)
	{
		bool_13 = bool_25;
		baseItem_0.SetDesignMode(bool_25);
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new ItemControlAccessibleObject(this);
	}

	internal void method_1(AccessibleEvents accessibleEvents_0, int int_4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).AccessibilityNotifyClients(accessibleEvents_0, int_4);
	}

	public virtual ArrayList GetItems(string ItemName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_46(baseItem_0, ItemName, arrayList);
		return arrayList;
	}

	public virtual ArrayList GetItems(string ItemName, Type itemType)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_48(baseItem_0, ItemName, arrayList, itemType);
		return arrayList;
	}

	public virtual ArrayList GetItems(string ItemName, Type itemType, bool useGlobalName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_49(baseItem_0, ItemName, arrayList, itemType, useGlobalName);
		return arrayList;
	}

	public virtual BaseItem GetItem(string ItemName)
	{
		BaseItem baseItem = Class109.smethod_44(baseItem_0, ItemName);
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
		if (baseItem_1 != null)
		{
			if (baseItem_1.Expanded)
			{
				baseItem_1.Expanded = false;
			}
			baseItem_1 = null;
		}
		baseItem_1 = objItem;
	}

	BaseItem IOwner.GetExpandedItem()
	{
		return baseItem_1;
	}

	void IOwner.SetFocusItem(BaseItem objFocusItem)
	{
		if (baseItem_2 != null && baseItem_2 != objFocusItem)
		{
			baseItem_2.OnLostFocus();
		}
		OnSetFocusItem(objFocusItem);
		baseItem_2 = objFocusItem;
		if (baseItem_2 != null)
		{
			baseItem_2.OnGotFocus();
		}
	}

	protected virtual void OnSetFocusItem(BaseItem objFocusItem)
	{
	}

	BaseItem IOwner.GetFocusItem()
	{
		return baseItem_2;
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
		if (baseItem_0 is GenericItemContainer)
		{
			((GenericItemContainer)baseItem_0).ContainerLostFocus(appLostFocus: true);
		}
		else if (baseItem_0 is RibbonStripContainerItem)
		{
			((RibbonStripContainerItem)baseItem_0).ContainerLostFocus(appLostFocus: true);
		}
	}

	void IOwner.OnParentPositionChanging()
	{
	}

	public void StartItemDrag(BaseItem item)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_0 || baseItem_3 != null)
		{
			return;
		}
		baseItem_3 = item;
		if (!bool_3)
		{
			((Control)this).set_Capture(true);
			if (cursor_0 != (Cursor)null)
			{
				Cursor.set_Current(cursor_0);
			}
			else
			{
				Cursor.set_Current(Cursors.get_Hand());
			}
			bool_4 = true;
		}
		else
		{
			bool_4 = true;
			((Control)this).DoDragDrop((object)item, (DragDropEffects)(-2147483645));
		}
	}

	void IOwner.InvokeUserCustomize(object sender, EventArgs e)
	{
		if (eventHandler_13 != null)
		{
			eventHandler_13(sender, e);
		}
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
		((ContainerControl)this).OnParentChanged(e);
		if (((Control)this).get_Parent() != null && (Images != null || ImagesLarge != null || ImagesMedium != null))
		{
			foreach (BaseItem subItem in baseItem_0.SubItems)
			{
				foreach (BaseItem subItem2 in subItem.SubItems)
				{
					if (subItem2 is ImageItem)
					{
						((ImageItem)subItem2).OnImageChanged();
					}
				}
			}
		}
		if (((Component)this).DesignMode)
		{
			baseItem_0.SetDesignMode(((Component)this).DesignMode);
		}
	}

	void IOwner.InvokeDefinitionLoaded(object sender, EventArgs e)
	{
		if (eventHandler_17 != null)
		{
			eventHandler_17(sender, e);
		}
	}

	internal void method_2()
	{
		if (!bool_8)
		{
			Class107.smethod_0(this);
			bool_8 = true;
		}
	}

	void IOwnerMenuSupport.RegisterPopup(PopupItem objPopup)
	{
		if (arrayList_0.Contains(objPopup))
		{
			return;
		}
		if (!GetDesignMode() && !bool_21)
		{
			method_2();
			if (!bool_10)
			{
				method_8();
			}
		}
		else if (class94_0 == null)
		{
			class94_0 = new Class94(this);
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
			method_9();
			if (class94_0 != null)
			{
				class94_0.Dispose();
				class94_0 = null;
			}
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

	void IOwnerMenuSupport.InvokePopupClose(PopupItem item, EventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupContainerLoad(PopupItem item, EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupContainerUnload(PopupItem item, EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupOpen(PopupItem item, PopupOpenEventArgs e)
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupShowing(PopupItem item, EventArgs e)
	{
		if (eventHandler_6 != null)
		{
			eventHandler_6(item, e);
		}
	}

	void IOwnerMenuSupport.ClosePopups()
	{
		ClosePopups();
	}

	internal void ClosePopups()
	{
		ArrayList arrayList = new ArrayList(arrayList_0);
		foreach (PopupItem item in arrayList)
		{
			item.ClosePopup();
		}
	}

	internal void method_3(string string_2)
	{
		ArrayList arrayList = new ArrayList(arrayList_0);
		foreach (PopupItem item in arrayList)
		{
			if (item.Name == string_2)
			{
				item.ClosePopup();
			}
		}
	}

	internal void method_4(bool bool_25)
	{
		bool_18 = bool_25;
	}

	public void ReleaseFocus()
	{
		if (!((Control)this).get_Focused() || int_1 == 0)
		{
			return;
		}
		Control val = Control.FromChildHandle(new IntPtr(int_1));
		if (val != null)
		{
			val.Select();
			if (!val.get_Focused())
			{
				Class92.SetFocus(int_1);
			}
		}
		else
		{
			Class92.SetFocus(int_1);
		}
		int_1 = 0;
		if (baseItem_0 is GenericItemContainer)
		{
			((GenericItemContainer)baseItem_0).AutoExpand = false;
		}
	}

	protected void CopyIOwnerEvents(ItemControl target)
	{
		target.eventHandler_1 = eventHandler_1;
	}

	void IOwnerItemEvents.InvokeItemAdded(BaseItem item, EventArgs e)
	{
		if (eventHandler_14 != null)
		{
			eventHandler_14(item, e);
		}
	}

	void IOwnerItemEvents.InvokeItemRemoved(BaseItem item, BaseItem parent)
	{
		if (itemRemovedEventHandler_0 != null)
		{
			itemRemovedEventHandler_0(item, new ItemRemovedEventArgs(parent));
		}
	}

	void IOwnerItemEvents.InvokeMouseEnter(BaseItem item, EventArgs e)
	{
		if (eventHandler_8 != null)
		{
			eventHandler_8(item, e);
		}
	}

	void IOwnerItemEvents.InvokeMouseHover(BaseItem item, EventArgs e)
	{
		if (eventHandler_10 != null)
		{
			eventHandler_10(item, e);
		}
	}

	void IOwnerItemEvents.InvokeMouseLeave(BaseItem item, EventArgs e)
	{
		if (eventHandler_9 != null)
		{
			eventHandler_9(item, e);
		}
	}

	void IOwnerItemEvents.InvokeMouseDown(BaseItem item, MouseEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		if (mouseEventHandler_0 != null)
		{
			mouseEventHandler_0.Invoke((object)item, e);
		}
		if (item.ClickAutoRepeat && (int)e.get_Button() == 1048576)
		{
			baseItem_4 = item;
			if (timer_0 == null)
			{
				timer_0 = new Timer();
			}
			timer_0.set_Interval(item.ClickRepeatInterval);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.Start();
		}
	}

	void IOwnerItemEvents.InvokeMouseUp(BaseItem item, MouseEventArgs e)
	{
		if (mouseEventHandler_1 != null)
		{
			mouseEventHandler_1.Invoke((object)item, e);
		}
		if (timer_0 != null && timer_0.get_Enabled())
		{
			timer_0.Stop();
			timer_0.set_Enabled(false);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (baseItem_4 != null)
		{
			baseItem_4.RaiseClick();
		}
		else
		{
			timer_0.Stop();
		}
	}

	void IOwnerItemEvents.InvokeMouseMove(BaseItem item, MouseEventArgs e)
	{
		if (mouseEventHandler_2 != null)
		{
			mouseEventHandler_2.Invoke((object)item, e);
		}
	}

	void IOwnerItemEvents.InvokeItemClick(BaseItem objItem)
	{
		OnItemClick(objItem);
	}

	protected virtual void OnItemClick(BaseItem item)
	{
		GetRibbonControl()?.method_13(item);
		if (ShowKeyTips)
		{
			ShowKeyTips = false;
		}
		if (eventHandler_1 != null)
		{
			eventHandler_1(item, new EventArgs());
		}
	}

	void IOwnerItemEvents.InvokeGotFocus(BaseItem item, EventArgs e)
	{
		if (eventHandler_12 != null)
		{
			eventHandler_12(item, e);
		}
	}

	void IOwnerItemEvents.InvokeLostFocus(BaseItem item, EventArgs e)
	{
		if (eventHandler_11 != null)
		{
			eventHandler_11(item, e);
		}
	}

	void IOwnerItemEvents.InvokeExpandedChange(BaseItem item, EventArgs e)
	{
		if (eventHandler_7 != null)
		{
			eventHandler_7(item, e);
		}
	}

	void IOwnerItemEvents.InvokeItemTextChanged(BaseItem item, EventArgs e)
	{
		if (eventHandler_16 != null)
		{
			eventHandler_16(item, e);
		}
	}

	void IOwnerItemEvents.InvokeContainerControlDeserialize(BaseItem item, ControlContainerSerializationEventArgs e)
	{
		if (controlContainerSerializationEventHandler_1 != null)
		{
			controlContainerSerializationEventHandler_1(item, e);
		}
	}

	void IOwnerItemEvents.InvokeContainerControlSerialize(BaseItem item, ControlContainerSerializationEventArgs e)
	{
		if (controlContainerSerializationEventHandler_0 != null)
		{
			controlContainerSerializationEventHandler_0(item, e);
		}
	}

	void IOwnerItemEvents.InvokeContainerLoadControl(BaseItem item, EventArgs e)
	{
		if (eventHandler_15 != null)
		{
			eventHandler_15(item, e);
		}
	}

	void IOwnerItemEvents.InvokeOptionGroupChanging(BaseItem item, OptionGroupChangingEventArgs e)
	{
		if (optionGroupChangingEventHandler_0 != null)
		{
			optionGroupChangingEventHandler_0(item, e);
		}
	}

	void IOwnerItemEvents.InvokeToolTipShowing(object item, EventArgs e)
	{
		if (eventHandler_18 != null)
		{
			eventHandler_18(item, e);
		}
	}

	void IOwnerItemEvents.InvokeCheckedChanged(ButtonItem item, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(item, e);
		}
	}

	bool Interface5.imethod_5(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return vmethod_0(intptr_2, intptr_3, intptr_4);
	}

	protected virtual bool vmethod_0(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return false;
	}

	bool Interface5.imethod_2(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return vmethod_1(intptr_2, intptr_3, intptr_4);
	}

	protected virtual bool vmethod_1(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected I4, but got Unknown
		bool designMode = GetDesignMode();
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
			return !designMode;
		}
		if (Boolean_3 && !designMode)
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
				vmethod_4(new KeyEventArgs(val4));
				return !designMode;
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
		if (method_5((eShortcut)eShortcut_))
		{
			return !designMode;
		}
		return false;
	}

	private bool method_5(eShortcut eShortcut_0)
	{
		if (!bool_20)
		{
			return false;
		}
		Form val = ((Control)this).FindForm();
		if (val != null && (((val == Form.get_ActiveForm() || val.get_MdiParent() != null) && (val.get_MdiParent() == null || val.get_MdiParent().get_ActiveMdiChild() == val)) || val.get_IsMdiContainer()) && (Form.get_ActiveForm() == null || !Form.get_ActiveForm().get_Modal() || Form.get_ActiveForm() == val))
		{
			bool result = Class109.smethod_5(eShortcut_0, hashtable_0);
			if (!bool_9)
			{
				return result;
			}
			return false;
		}
		return false;
	}

	private Class197 method_6()
	{
		if (class197_0 == null)
		{
			class197_0 = new Class197();
		}
		return class197_0;
	}

	internal void method_7()
	{
		method_6().method_3();
	}

	protected virtual bool OnSysMouseDown(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		if (arrayList_0.Count != 0 && !GetDesignMode())
		{
			BaseItem[] array = new BaseItem[arrayList_0.Count];
			arrayList_0.CopyTo(array);
			for (int num = array.Length - 1; num >= 0; num--)
			{
				PopupItem popupItem = array[num] as PopupItem;
				bool flag;
				if (!(flag = popupItem.IsAnyOnHandle(hWnd.ToInt32())))
				{
					Control val = Control.FromChildHandle(hWnd);
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
							if (!flag)
							{
								flag = popupItem.IsAnyOnHandle(val.get_Handle().ToInt32());
							}
						}
					}
					else
					{
						string text = Class92.smethod_8(hWnd);
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
					if (val2 != null && val2.get_Parent() != null)
					{
						val2 = val2.get_Parent();
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
				if (popupItem.Displayed && !((Control)this).get_IsDisposed())
				{
					Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
					if (popupItem.DisplayRectangle.Contains(pt))
					{
						break;
					}
				}
				if (popupItem.PopupControl is IKeyTipsControl)
				{
					((IKeyTipsControl)popupItem.PopupControl).ShowKeyTips = false;
				}
				if (GetDesignMode())
				{
					method_6().method_2(popupItem);
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
				Boolean_3 = false;
			}
			return false;
		}
		return false;
	}

	bool Interface5.imethod_3(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return OnSysMouseDown(intptr_2, intptr_3, intptr_4);
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
		return vmethod_2(intptr_2, intptr_3, intptr_4);
	}

	protected virtual bool vmethod_2(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I4, but got Unknown
		if (!GetDesignMode())
		{
			if (intptr_3.ToInt32() == 18 && (int)Control.get_ModifierKeys() == 262144)
			{
				ClosePopups();
			}
			if ((int)Control.get_ModifierKeys() != 0 || (intptr_3.ToInt32() >= 112 && intptr_3.ToInt32() <= 123))
			{
				int eShortcut_ = Control.get_ModifierKeys() | intptr_3.ToInt32();
				if (method_5((eShortcut)eShortcut_))
				{
					return true;
				}
			}
		}
		return false;
	}

	bool Interface5.imethod_1(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return vmethod_3(intptr_2, intptr_3, intptr_4);
	}

	protected virtual bool vmethod_3(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		return false;
	}

	private void method_8()
	{
		if (!bool_10)
		{
			bool_10 = true;
			Form val = ((Control)this).FindForm();
			if (val == null)
			{
				bool_10 = false;
				return;
			}
			((Control)val).add_Resize((EventHandler)method_10);
			val.add_Deactivate((EventHandler)method_11);
			DotNetBarManager.RegisterParentMsgHandler(this, val);
		}
	}

	private void method_9()
	{
		if (bool_10)
		{
			bool_10 = false;
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				DotNetBarManager.UnRegisterParentMsgHandler(this, val);
				((Control)val).remove_Resize((EventHandler)method_10);
				val.remove_Deactivate((EventHandler)method_11);
			}
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	private void method_11(object sender, EventArgs e)
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
		if (((Message)(ref m)).get_Msg() == 7)
		{
			int value = ((Message)(ref m)).get_WParam().ToInt32();
			Control val = Control.FromChildHandle(new IntPtr(value));
			if (val != null && !(val is Bar) && !(val is MenuPanel) && !(val is TextBoxX) && !(val is ComboBoxEx))
			{
				Form val2 = val.FindForm();
				if (val2 == ((Control)this).FindForm())
				{
					int_1 = ((Message)(ref m)).get_WParam().ToInt32();
				}
				else if (val2 != null)
				{
					int_1 = ((Message)(ref m)).get_WParam().ToInt32();
				}
			}
		}
		else if (((Message)(ref m)).get_Msg() == 1131)
		{
			if (baseItem_5 != null)
			{
				baseItem_5.vmethod_0();
				baseItem_5 = null;
			}
		}
		else if (((Message)(ref m)).get_Msg() == 794)
		{
			RefreshThemes();
		}
		((ContainerControl)this).WndProc(ref m);
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

	private void method_12()
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
		if (class82_0 != null)
		{
			class82_0.Dispose();
			class82_0 = null;
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		if (!bool_8 && !((Component)this).DesignMode)
		{
			Class107.smethod_0(this);
			bool_8 = true;
		}
		RecalcLayout();
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_12();
		method_9();
		((Control)this).OnHandleDestroyed(e);
		if (bool_8)
		{
			Class107.smethod_1(this);
			bool_8 = false;
		}
		if (class94_0 != null)
		{
			class94_0.Dispose();
			class94_0 = null;
		}
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		Point mousePos = ((Control)this).PointToClient(Control.get_MousePosition());
		InternalOnClick(Control.get_MouseButtons(), mousePos);
		((Control)this).OnClick(e);
	}

	protected virtual void InternalOnClick(MouseButtons mb, Point mousePos)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		baseItem_0.InternalClick(mb, mousePos);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		baseItem_0.InternalDoubleClick(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnDoubleClick(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		vmethod_4(e);
		((Control)this).OnKeyDown(e);
	}

	internal virtual void vmethod_4(KeyEventArgs keyEventArgs_0)
	{
		baseItem_0.InternalKeyDown(keyEventArgs_0);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		eventHandler_8?.Invoke(this, e);
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		baseItem_0.InternalMouseDown(e);
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		baseItem_0.InternalMouseHover();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (((Control)this).get_Cursor() != Cursors.get_Arrow())
		{
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
		baseItem_0.InternalMouseLeave();
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		if (bool_0 && !bool_3)
		{
			MouseDragDrop(e.get_X(), e.get_Y(), null);
		}
		baseItem_0.InternalMouseUp(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		InternalMouseMove(e);
	}

	protected virtual void InternalMouseMove(MouseEventArgs e)
	{
		if (bool_0 && bool_4)
		{
			if (!bool_3)
			{
				method_13(e.get_X(), e.get_Y(), null);
			}
		}
		else
		{
			baseItem_0.InternalMouseMove(e);
		}
	}

	protected override void OnDragOver(DragEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (bool_0 && (bool_4 || bool_5))
		{
			e.set_Effect((DragDropEffects)2);
			((Control)this).OnDragOver(e);
			if ((int)e.get_Effect() != 0)
			{
				Point point = ((Control)this).PointToClient(new Point(e.get_X(), e.get_Y()));
				method_13(point.X, point.Y, e);
			}
			bool_1 = false;
		}
		else
		{
			((Control)this).OnDragOver(e);
		}
	}

	protected override void OnDragLeave(EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (bool_0)
		{
			if (bool_4 || bool_5)
			{
				if ((int)Control.get_MouseButtons() == 0)
				{
					MouseDragDrop(-1, -1, null);
				}
				else
				{
					method_13(-1, -1, null);
				}
			}
			bool_1 = true;
			bool_5 = false;
		}
		((Control)this).OnDragLeave(e);
	}

	protected override void OnDragEnter(DragEventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		((Control)this).OnDragEnter(e);
		if (!bool_0 || bool_4 || !bool_2)
		{
			return;
		}
		if (e.get_Data().GetData(typeof(ButtonItem)) == null)
		{
			if ((int)e.get_Effect() != 0)
			{
				bool_5 = true;
			}
			return;
		}
		if ((e.get_AllowedEffect() & 2) == 2)
		{
			e.set_Effect((DragDropEffects)2);
		}
		else if ((e.get_AllowedEffect() & 1) == 1)
		{
			e.set_Effect((DragDropEffects)2);
		}
		else
		{
			if ((e.get_AllowedEffect() & 4) != 4)
			{
				return;
			}
			e.set_Effect((DragDropEffects)2);
		}
		bool_5 = true;
	}

	protected override void OnDragDrop(DragEventArgs e)
	{
		if (bool_0)
		{
			if (bool_4)
			{
				Point point = ((Control)this).PointToClient(new Point(e.get_X(), e.get_Y()));
				MouseDragDrop(point.X, point.Y, null);
			}
			else if (bool_5)
			{
				Point point2 = ((Control)this).PointToClient(new Point(e.get_X(), e.get_Y()));
				MouseDragDrop(point2.X, point2.Y, e);
			}
		}
		((Control)this).OnDragDrop(e);
	}

	protected override void OnQueryContinueDrag(QueryContinueDragEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		((Control)this).OnQueryContinueDrag(e);
		if (bool_0 && bool_4 && ((bool_1 && (int)e.get_Action() == 1) || (int)e.get_Action() == 2))
		{
			MouseDragDrop(-1, -1, null);
		}
	}

	private void method_13(int int_4, int int_5, DragEventArgs dragEventArgs_0)
	{
		if (!bool_4 && !bool_5)
		{
			return;
		}
		BaseItem baseItem = baseItem_3;
		if (bool_5 && dragEventArgs_0 != null)
		{
			baseItem = dragEventArgs_0.get_Data().GetData(typeof(ButtonItem)) as BaseItem;
		}
		if (idesignTimeProvider_0 != null)
		{
			idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_11);
			idesignTimeProvider_0 = null;
		}
		if (bool_5 && baseItem == null)
		{
			return;
		}
		Point pScreen = ((Control)this).PointToScreen(new Point(int_4, int_5));
		InsertPosition insertPosition = ((IDesignTimeProvider)baseItem_0).GetInsertPosition(pScreen, baseItem);
		if (insertPosition != null)
		{
			if (insertPosition.TargetProvider == null)
			{
				if (!bool_3)
				{
					if (cursor_1 != (Cursor)null)
					{
						Cursor.set_Current(cursor_1);
					}
					else
					{
						Cursor.set_Current(Cursors.get_No());
					}
				}
				return;
			}
			insertPosition.TargetProvider.DrawReversibleMarker(insertPosition.Position, insertPosition.Before);
			int_0 = insertPosition.Position;
			bool_11 = insertPosition.Before;
			idesignTimeProvider_0 = insertPosition.TargetProvider;
			if (!bool_3)
			{
				if (cursor_0 != (Cursor)null)
				{
					Cursor.set_Current(cursor_0);
				}
				else
				{
					Cursor.set_Current(Cursors.get_Hand());
				}
			}
			else if (dragEventArgs_0 != null)
			{
				dragEventArgs_0.set_Effect((DragDropEffects)2);
			}
		}
		else if (!bool_3)
		{
			if (cursor_1 != (Cursor)null)
			{
				Cursor.set_Current(cursor_1);
			}
			else
			{
				Cursor.set_Current(Cursors.get_No());
			}
		}
		else if (dragEventArgs_0 != null)
		{
			dragEventArgs_0.set_Effect((DragDropEffects)0);
		}
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		if (ProcessMnemonicEx(charCode))
		{
			return true;
		}
		return ((ContainerControl)this).ProcessMnemonic(charCode);
	}

	public virtual bool ProcessMnemonicEx(char charCode)
	{
		if (ProcessMnemonic(baseItem_0, charCode))
		{
			return true;
		}
		return false;
	}

	protected virtual bool ProcessMnemonic(BaseItem container, char charCode)
	{
		BaseItem itemForMnemonic = GetItemForMnemonic(container, charCode, deepScan: true, stackKeys: true);
		return ProcessItemMnemonicKey(itemForMnemonic);
	}

	protected virtual bool ProcessItemMnemonicKey(BaseItem item)
	{
		if (item != null && item.Visible && item.method_2())
		{
			if (item is QatOverflowItem)
			{
				((QatOverflowItem)item).Expanded = true;
			}
			else if (item is ButtonItem && (item.ShowSubItems || ((ButtonItem)item).AutoExpandOnClick) && ((item.SubItems.Count > 0 && item.VisibleSubItems > 0) || ((ButtonItem)item).PopupType == ePopupType.Container) && !item.Expanded)
			{
				item.Expanded = true;
				PopupItem popupItem = item as PopupItem;
				if (popupItem.PopupType == ePopupType.Menu && popupItem.PopupControl is MenuPanel)
				{
					((MenuPanel)(object)popupItem.PopupControl).method_21();
				}
				if (baseItem_0 is GenericItemContainer)
				{
					baseItem_0.AutoExpand = true;
				}
			}
			else if (item is ComboBoxItem)
			{
				((Control)((ComboBoxItem)item).ComboBoxEx).Focus();
				((ComboBox)((ComboBoxItem)item).ComboBoxEx).set_DroppedDown(true);
			}
			else if (item is TextBoxItem)
			{
				((Control)((TextBoxItem)item).TextBox).Focus();
			}
			else if (item is ControlContainerItem && ((ControlContainerItem)item).Control != null)
			{
				((ControlContainerItem)item).Control.Focus();
			}
			else if (item is GalleryContainer)
			{
				((GalleryContainer)item).PopupGallery();
			}
			else
			{
				item.RaiseClick();
			}
			return true;
		}
		return false;
	}

	protected virtual BaseItem GetItemForMnemonic(BaseItem container, char charCode, bool deepScan, bool stackKeys)
	{
		bool bool_ = false;
		return method_14(container, charCode, deepScan, stackKeys, ref bool_);
	}

	private BaseItem method_14(BaseItem baseItem_6, char char_0, bool bool_25, bool bool_26, ref bool bool_27)
	{
		string text = string_1 + char_0;
		text = text.ToUpper();
		Class181 @class = baseItem_6 as Class181;
		int num = baseItem_6.SubItems.Count;
		if (@class != null && @class.DisplayMoreItem_0 != null && @class.DisplayMoreItem_0.Visible)
		{
			num++;
		}
		BaseItem[] array = new BaseItem[num];
		baseItem_6.SubItems.CopyTo(array, 0);
		if (@class != null && @class.DisplayMoreItem_0 != null && @class.DisplayMoreItem_0.Visible)
		{
			array[num - 1] = @class.DisplayMoreItem_0;
		}
		BaseItem[] array2 = array;
		int num2 = 0;
		BaseItem baseItem2;
		while (true)
		{
			if (num2 < array2.Length)
			{
				BaseItem baseItem = array2[num2];
				if (!(baseItem.KeyTips != "") && !(string_1 != ""))
				{
					if (Control.IsMnemonic(char_0, baseItem.Text) && baseItem.Visible && baseItem.method_2())
					{
						return baseItem;
					}
				}
				else if (baseItem.KeyTips != "")
				{
					if (baseItem.KeyTips == text)
					{
						if (baseItem.Visible && baseItem.method_2())
						{
							return baseItem;
						}
					}
					else if (baseItem.KeyTips.StartsWith(text))
					{
						bool_27 = true;
					}
				}
				if (bool_25 && baseItem.IsContainer)
				{
					baseItem2 = method_14(baseItem, char_0, bool_25, bool_26: false, ref bool_27);
					if (baseItem2 != null)
					{
						break;
					}
				}
				num2++;
				continue;
			}
			if (bool_27 && bool_26)
			{
				((IKeyTipsControl)this).KeyTipsKeysStack += char_0.ToString().ToUpper();
			}
			return null;
		}
		return baseItem2;
	}

	void IOwnerLocalize.InvokeLocalizeString(LocalizeEventArgs e)
	{
		if (localizeStringEventHandler_0 != null)
		{
			localizeStringEventHandler_0(this, e);
		}
	}

	protected override void OnBindingContextChanged(EventArgs e)
	{
		((Control)this).OnBindingContextChanged(e);
		if (baseItem_0 != null)
		{
			baseItem_0.method_16();
		}
	}

	protected virtual RibbonControl GetRibbonControl()
	{
		Control parent = ((Control)this).get_Parent();
		while (parent != null && !(parent is RibbonControl))
		{
			if (!(parent is RibbonPanel) || ((RibbonPanel)(object)parent).method_4() == null)
			{
				parent = parent.get_Parent();
				continue;
			}
			return ((RibbonPanel)(object)parent).method_4();
		}
		return parent as RibbonControl;
	}

	public virtual BaseItem HitTest(int x, int y)
	{
		return baseItem_0.ItemAtLocation(x, y);
	}

	private void method_15()
	{
		AutoSyncSize();
	}

	public virtual void AutoSyncSize()
	{
		if (!bool_15 || int_2 > 2 || baseItem_0.NeedRecalcSize)
		{
			return;
		}
		int_2++;
		try
		{
			int autoSizeHeight = GetAutoSizeHeight();
			if (((Control)this).get_Height() != autoSizeHeight && baseItem_0.HeightInternal > 0)
			{
				((Control)this).set_Height(autoSizeHeight);
				RecalcSize();
			}
		}
		finally
		{
			int_2--;
		}
	}

	protected virtual ElementStyle GetBackgroundStyle()
	{
		return elementStyle_0;
	}

	internal ElementStyle method_16()
	{
		return GetBackgroundStyle();
	}

	public virtual int GetAutoSizeHeight()
	{
		return baseItem_0.HeightInternal + Class52.smethod_2(GetBackgroundStyle());
	}

	protected void SetBaseItemContainer(BaseItem item)
	{
		baseItem_0 = item;
	}

	internal BaseItem method_17()
	{
		return baseItem_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (timer_0 != null)
			{
				timer_0.Stop();
				((Component)(object)timer_0).Dispose();
				timer_0 = null;
			}
			if (class197_0 != null)
			{
				class197_0.method_0();
				class197_0 = null;
			}
		}
		((ContainerControl)this).Dispose(disposing);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackgroundStyle()
	{
		elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		((Control)this).Invalidate();
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		OnVisualPropertyChanged();
	}

	protected virtual void OnVisualPropertyChanged()
	{
		if (GetDesignMode() || (((Control)this).get_Parent() != null && ((Component)(object)((Control)this).get_Parent()).Site != null && ((Component)(object)((Control)this).get_Parent()).Site!.DesignMode))
		{
			RecalcLayout();
		}
	}

	protected virtual void MouseDragDrop(int x, int y, DragEventArgs dragArgs)
	{
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		if (!bool_4 && !bool_5)
		{
			return;
		}
		BaseItem baseItem = baseItem_3;
		if (bool_5)
		{
			baseItem = dragArgs.get_Data().GetData(typeof(ButtonItem)) as BaseItem;
		}
		baseItem?.InternalMouseLeave();
		if (idesignTimeProvider_0 != null)
		{
			if (x == -1 && y == -1)
			{
				idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_11);
			}
			else
			{
				idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_11);
				if (baseItem != null)
				{
					BaseItem parent = baseItem.Parent;
					if (parent != null)
					{
						if (parent == (BaseItem)idesignTimeProvider_0 && int_0 > 0 && parent.SubItems.IndexOf(baseItem) < int_0)
						{
							int_0--;
						}
						parent.SubItems.Remove(baseItem);
						parent.Refresh();
						if (parent.ContainerControl != this)
						{
							object containerControl = parent.ContainerControl;
							BarUtilities.smethod_2((Control)((containerControl is Control) ? containerControl : null));
						}
					}
					idesignTimeProvider_0.InsertItemAt(baseItem, int_0, bool_11);
					idesignTimeProvider_0 = null;
					((IOwner)this).InvokeUserCustomize((object)baseItem, new EventArgs());
				}
			}
		}
		idesignTimeProvider_0 = null;
		bool_4 = false;
		bool_5 = false;
		if (!bool_3)
		{
			Cursor.set_Current(Cursors.get_Default());
		}
		((Control)this).set_Capture(false);
		if (baseItem != null)
		{
			baseItem.bool_12 = true;
		}
		baseItem_0.InternalMouseUp(new MouseEventArgs((MouseButtons)1048576, 0, x, y, 0));
		if (baseItem != null)
		{
			baseItem.bool_12 = false;
		}
		baseItem_3 = null;
		if (eventHandler_13 != null)
		{
			eventHandler_13(this, new EventArgs());
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeColorScheme()
	{
		return colorScheme_0.SchemeChanged;
	}

	public virtual void SetDesignTimeDefaults()
	{
	}

	protected virtual void OnShowKeyTipsChanged()
	{
		string_1 = "";
		if (ShowKeyTips)
		{
			CreateKeyTipCanvas();
		}
		else
		{
			DestroyKeyTipCanvas();
		}
	}

	public Graphics CreateGraphics()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = ((Control)this).CreateGraphics();
		if (bool_14)
		{
			val.set_SmoothingMode((SmoothingMode)4);
			if (!SystemInformation.get_IsFontSmoothingEnabled())
			{
				val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
		}
		return val;
	}

	internal virtual ItemPaintArgs vmethod_5(Graphics graphics_0)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this, (Control)(object)this, graphics_0, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		itemPaintArgs.DesignerSelection = bool_16;
		itemPaintArgs.GlassEnabled = !((Component)this).DesignMode && Boolean_6;
		return itemPaintArgs;
	}

	protected virtual ColorScheme GetColorScheme()
	{
		if (baseItem_0.Style == eDotNetBarStyle.Office2007)
		{
			BaseRenderer renderer = GetRenderer();
			if (renderer is Office2007Renderer)
			{
				return ((Office2007Renderer)renderer).ColorTable.LegacyColors;
			}
		}
		return colorScheme_0;
	}

	internal void method_18(PaintEventArgs paintEventArgs_0)
	{
		method_20(paintEventArgs_0, bool_25: true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		method_20(e, bool_25: false);
		method_19();
	}

	internal void method_19()
	{
		if (control1_0 != null)
		{
			((Control)control1_0).Invalidate();
		}
	}

	private void method_20(PaintEventArgs paintEventArgs_0, bool bool_25)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = paintEventArgs_0.get_Graphics().get_SmoothingMode();
		TextRenderingHint textRenderingHint = paintEventArgs_0.get_Graphics().get_TextRenderingHint();
		if (((Control)this).get_BackColor().IsEmpty || ((Control)this).get_BackColor() == Color.Transparent)
		{
			((ScrollableControl)this).OnPaintBackground(paintEventArgs_0);
		}
		if (elementStyle_0 != null)
		{
			elementStyle_0.method_4(GetColorScheme());
		}
		ItemPaintArgs itemPaintArgs = vmethod_5(paintEventArgs_0.get_Graphics());
		itemPaintArgs.ClipRectangle = paintEventArgs_0.get_ClipRectangle();
		if (bool_24 && ((ScrollableControl)this).get_AutoScroll() && ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0)
		{
			itemPaintArgs.ClipRectangle = Rectangle.Empty;
			bool_24 = false;
		}
		itemPaintArgs.bool_0 = bool_25;
		PaintControl(itemPaintArgs);
		paintEventArgs_0.get_Graphics().set_SmoothingMode(smoothingMode);
		paintEventArgs_0.get_Graphics().set_TextRenderingHint(textRenderingHint);
	}

	protected virtual void ClearBackground(ItemPaintArgs pa)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
		try
		{
			pa.Graphics.FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected virtual void PaintControl(ItemPaintArgs pa)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (baseItem_0 == null || ((Control)this).get_IsDisposed())
		{
			return;
		}
		if (baseItem_0.NeedRecalcSize)
		{
			RecalcSize();
		}
		if (!((Control)this).get_BackColor().IsEmpty && ((Control)this).get_BackColor() != Color.Transparent)
		{
			ClearBackground(pa);
		}
		if (Class92.smethod_0())
		{
			pa.Graphics.DrawString("Your DotNetBar Trial has expired.", ((Control)this).get_Font(), SystemBrushes.get_ControlText(), 0f, 0f);
			return;
		}
		if (bool_14)
		{
			pa.Graphics.set_SmoothingMode((SmoothingMode)4);
			pa.Graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		PaintControlBackground(pa);
		Region clip = pa.Graphics.get_Clip();
		pa.Graphics.SetClip(GetPaintClipRectangle(), (CombineMode)1);
		PaintItemContainer(pa);
		pa.Graphics.set_Clip(clip);
		if (baseItem_0.SubItems.Count == 0 && GetDesignMode())
		{
			PaintDesignTimeEmptyHint(pa);
		}
	}

	protected virtual Rectangle GetPaintClipRectangle()
	{
		return GetItemContainerRectangle();
	}

	protected virtual void PaintControlBackground(ItemPaintArgs pa)
	{
		ElementStyle backgroundStyle = GetBackgroundStyle();
		if (backgroundStyle != null)
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			ElementStyleDisplayInfo e = new ElementStyleDisplayInfo(backgroundStyle, pa.Graphics, clientRectangle);
			ElementStyleDisplay.Paint(e);
		}
	}

	protected virtual void PaintItemContainer(ItemPaintArgs pa)
	{
		baseItem_0.Paint(pa);
	}

	protected virtual void PaintDesignTimeEmptyHint(ItemPaintArgs pa)
	{
		string text = string_0;
		Rectangle itemContainerRectangle = GetItemContainerRectangle();
		itemContainerRectangle.Inflate(-2, -2);
		if (itemContainerRectangle.Width >= 0 && itemContainerRectangle.Height >= 0)
		{
			StringFormat val = Class109.smethod_3();
			val.set_Alignment((StringAlignment)1);
			val.set_LineAlignment((StringAlignment)1);
			pa.Graphics.DrawString(text, ((Control)this).get_Font(), SystemBrushes.get_ControlDark(), (RectangleF)itemContainerRectangle, val);
		}
	}

	protected virtual void vmethod_6(Graphics graphics_0)
	{
		if (bool_17)
		{
			KeyTipsRendererEventArgs keyTipsRendererEventArgs_ = new KeyTipsRendererEventArgs(graphics_0, Rectangle.Empty, "", GetKeyTipFont(), null);
			BaseRenderer renderer = GetRenderer();
			vmethod_7(baseItem_0, renderer, keyTipsRendererEventArgs_);
		}
	}

	protected virtual Font GetKeyTipFont()
	{
		Font font = ((Control)this).get_Font();
		if (font_0 != null)
		{
			font = font_0;
		}
		return font;
	}

	internal virtual void vmethod_7(BaseItem baseItem_6, BaseRenderer baseRenderer_2, KeyTipsRendererEventArgs keyTipsRendererEventArgs_0)
	{
		foreach (BaseItem subItem in baseItem_6.SubItems)
		{
			method_21(subItem, baseRenderer_2, keyTipsRendererEventArgs_0);
		}
		if (baseItem_6 is Class181 @class && @class.DisplayMoreItem_0 != null && @class.DisplayMoreItem_0.Visible)
		{
			method_21(@class.DisplayMoreItem_0, baseRenderer_2, keyTipsRendererEventArgs_0);
		}
	}

	private void method_21(BaseItem baseItem_6, BaseRenderer baseRenderer_2, KeyTipsRendererEventArgs keyTipsRendererEventArgs_0)
	{
		if (!baseItem_6.Visible || !baseItem_6.Displayed)
		{
			return;
		}
		if (baseItem_6.IsContainer)
		{
			vmethod_7(baseItem_6, baseRenderer_2, keyTipsRendererEventArgs_0);
		}
		if ((baseItem_6.AccessKey != 0 || !(baseItem_6.KeyTips == "")) && (!(string_1 != "") || baseItem_6.KeyTips.StartsWith(string_1)) && (!(baseItem_6.KeyTips == "") || !(string_1 != "")))
		{
			if (baseItem_6.KeyTips != "")
			{
				keyTipsRendererEventArgs_0.KeyTip = baseItem_6.KeyTips;
			}
			else
			{
				keyTipsRendererEventArgs_0.KeyTip = baseItem_6.AccessKey.ToString().ToUpper();
			}
			keyTipsRendererEventArgs_0.Bounds = GetKeyTipRectangle(keyTipsRendererEventArgs_0.Graphics, baseItem_6, keyTipsRendererEventArgs_0.Font, keyTipsRendererEventArgs_0.KeyTip);
			keyTipsRendererEventArgs_0.ReferenceObject = baseItem_6;
			baseRenderer_2.DrawKeyTips(keyTipsRendererEventArgs_0);
		}
	}

	protected virtual Rectangle GetKeyTipRectangle(Graphics g, BaseItem item, Font font, string keyTip)
	{
		Size size_ = Class53.size_0;
		Size size = Class55.smethod_3(g, keyTip, font);
		size.Width += size_.Width;
		size.Height += size_.Height;
		Rectangle displayRectangle = item.DisplayRectangle;
		Rectangle result = new Rectangle(displayRectangle.X + (displayRectangle.Width - size.Width) / 2, displayRectangle.Bottom - size.Height, size.Width, size.Height);
		if (item is RibbonTabItem)
		{
			result.Y = displayRectangle.Bottom - 7;
		}
		return result;
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
		if (baseRenderer_0 == null)
		{
			baseRenderer_0 = new Office2007Renderer();
		}
		return baseRenderer_1;
	}

	protected virtual Rectangle GetKeyTipCanvasBounds()
	{
		if (((Control)this).get_Parent() != null)
		{
			return new Rectangle(((Control)this).get_Bounds().X, ((Control)this).get_Bounds().Y, ((Control)this).get_Bounds().Width, ((Control)this).get_Bounds().Height + 16);
		}
		return new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected virtual void CreateKeyTipCanvas()
	{
		if (control1_0 != null)
		{
			((Control)control1_0).BringToFront();
			if (((Control)control1_0).get_Parent() != null)
			{
				((Control)control1_0).get_Parent().Invalidate(((Control)control1_0).get_Bounds());
			}
			return;
		}
		control1_0 = new Control1(this);
		((Control)control1_0).set_Bounds(GetKeyTipCanvasBounds());
		((Control)control1_0).set_Visible(true);
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null)
		{
			if (ribbonControl.Expanded && !NeedsTopLevelKeyTipCanvasParent)
			{
				((Control)ribbonControl).get_Controls().Add((Control)(object)control1_0);
			}
			else
			{
				Form val = ((Control)ribbonControl).FindForm();
				if (val != null)
				{
					((Control)val).get_Controls().Add((Control)(object)control1_0);
				}
				else
				{
					((Control)ribbonControl).get_Controls().Add((Control)(object)control1_0);
				}
			}
		}
		else
		{
			((Control)this).get_Controls().Add((Control)(object)control1_0);
		}
		((Control)control1_0).BringToFront();
	}

	internal void method_22()
	{
		if (control1_0 != null)
		{
			((Control)control1_0).Refresh();
		}
	}

	protected virtual void DestroyKeyTipCanvas()
	{
		if (control1_0 != null)
		{
			((Control)control1_0).set_Visible(false);
			if (((Control)control1_0).get_Parent() != null)
			{
				((Control)control1_0).get_Parent().get_Controls().Remove((Control)(object)control1_0);
			}
			((Component)(object)control1_0).Dispose();
			control1_0 = null;
		}
	}

	void Interface0.imethod_0(Graphics graphics_0)
	{
		vmethod_6(graphics_0);
	}

	public void BeginUpdate()
	{
		int_3++;
	}

	public void EndUpdate()
	{
		EndUpdate(callRecalcLayout: true);
	}

	public void EndUpdate(bool callRecalcLayout)
	{
		if (int_3 > 0)
		{
			int_3--;
			if (int_3 == 0 && callRecalcLayout)
			{
				RecalcLayout();
			}
		}
	}

	protected virtual Rectangle GetItemContainerRectangle()
	{
		ElementStyle backgroundStyle = GetBackgroundStyle();
		if (backgroundStyle == null)
		{
			return ((Control)this).get_ClientRectangle();
		}
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.X += Class52.smethod_3(backgroundStyle);
		clientRectangle.Width -= Class52.smethod_1(backgroundStyle);
		clientRectangle.Y += Class52.smethod_7(backgroundStyle);
		clientRectangle.Height -= Class52.smethod_2(backgroundStyle);
		return clientRectangle;
	}

	protected virtual void RecalcSize()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Invalid comparison between Unknown and I4
		if (!Class109.smethod_11((Control)(object)this) || IsUpdateSuspended || baseItem_0.IsRecalculatingSize)
		{
			return;
		}
		Form val = ((Control)this).FindForm();
		if (val == null || (int)val.get_WindowState() != 1)
		{
			if (baseItem_0.NeedRecalcSize)
			{
				Rectangle itemContainerRectangle = GetItemContainerRectangle();
				baseItem_0.IsRightToLeft = (int)((Control)this).get_RightToLeft() == 1;
				baseItem_0.LeftInternal = itemContainerRectangle.X;
				baseItem_0.TopInternal = itemContainerRectangle.Y;
				baseItem_0.WidthInternal = itemContainerRectangle.Width;
				baseItem_0.HeightInternal = itemContainerRectangle.Height;
				baseItem_0.RecalcSize();
			}
			AutoSyncSize();
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		method_23();
		InvalidateLayout();
		RecalcLayout();
		((ContainerControl)this).OnFontChanged(e);
	}

	private void method_23()
	{
		BarUtilities.smethod_0(baseItem_0.SubItems);
	}

	public void InvalidateLayout()
	{
		baseItem_0.NeedRecalcSize = true;
	}

	public virtual void RecalcLayout()
	{
		if (!baseItem_0.IsRecalculatingSize && !IsUpdateSuspended)
		{
			RecalcSize();
			((Control)this).Invalidate();
		}
	}

	protected override void OnResize(EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		((Control)this).OnResize(e);
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			Form val = ((Control)this).FindForm();
			if (val == null || (int)val.get_WindowState() != 1)
			{
				baseItem_0.NeedRecalcSize = true;
				RecalcSize();
			}
		}
	}

	protected virtual void SetupActiveWindowTimer()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if (timer_1 == null)
		{
			timer_1 = new Timer();
			timer_1.set_Interval(100);
			timer_1.add_Tick((EventHandler)timer_1_Tick);
			intptr_0 = Class92.GetForegroundWindow();
			intptr_1 = Class92.GetActiveWindow();
			timer_1.Start();
		}
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (timer_1 == null)
		{
			return;
		}
		IntPtr foregroundWindow = Class92.GetForegroundWindow();
		IntPtr activeWindow = Class92.GetActiveWindow();
		if (!(foregroundWindow != intptr_0) && !(activeWindow != intptr_1))
		{
			return;
		}
		if (activeWindow != IntPtr.Zero)
		{
			Control val = Control.FromHandle(activeWindow);
			if (val is PopupContainer || val is PopupContainerControl)
			{
				return;
			}
		}
		timer_1.Stop();
		OnActiveWindowChanged();
	}

	protected virtual void OnActiveWindowChanged()
	{
		if (Boolean_3)
		{
			Boolean_3 = false;
		}
	}

	protected virtual void ReleaseActiveWindowTimer()
	{
		if (timer_1 != null)
		{
			Timer val = timer_1;
			timer_1 = null;
			val.Stop();
			val.remove_Tick((EventHandler)timer_1_Tick);
			((Component)(object)val).Dispose();
		}
	}

	void IRibbonCustomize.ItemRightClick(BaseItem item)
	{
		OnPopupItemRightClick(item);
	}

	protected virtual void OnPopupItemRightClick(BaseItem item)
	{
	}
}

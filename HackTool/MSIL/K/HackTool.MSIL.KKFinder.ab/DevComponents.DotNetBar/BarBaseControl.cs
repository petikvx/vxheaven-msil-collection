using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[ComVisible(false)]
public abstract class BarBaseControl : Control, IBarDesignerServices, IAccessibilitySupport, IOwner, IOwnerItemEvents, IOwnerLocalize, IOwnerMenuSupport, IRenderingSupport, Interface5, Interface6
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

	private EventHandler eventHandler_19;

	private EventHandler eventHandler_20;

	private Delegate4 delegate4_0;

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

	private Cursor cursor_2;

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

	private ItemStyle itemStyle_0 = new ItemStyle();

	private bool bool_13;

	private BarBaseControlDesigner barBaseControlDesigner_0;

	private BaseItem baseItem_5;

	private bool bool_14;

	private Class94 class94_0;

	private ArrayList arrayList_0 = new ArrayList();

	private bool bool_15 = true;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

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

	bool IOwner.AlwaysDisplayKeyAccelerators
	{
		get
		{
			return false;
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

	bool IOwner.DragInProgress => bool_4;

	BaseItem IOwner.DragItem => baseItem_3;

	[Description("ImageList for images used on Items. Images specified here will always be used on menu-items and are by default used on all Bars.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Data")]
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

	[Category("Data")]
	[Description("ImageList for medium-sized images used on Items.")]
	[Browsable(true)]
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

	[Browsable(true)]
	[DefaultValue(null)]
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

	[Browsable(true)]
	[Category("Run-time Behavior")]
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

	[Description("Indicates whether item shortcut is displayed in Tooltips.")]
	[Category("Run-time Behavior")]
	[DefaultValue(false)]
	[Browsable(true)]
	public bool ShowShortcutKeysInToolTips
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

	bool IOwnerMenuSupport.ShowPopupShadow => false;

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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Category("Style")]
	[Description("Gets or sets bar background style.")]
	[DevCoBrowsable(true)]
	public ItemStyle BackgroundStyle => itemStyle_0;

	[Description("Indicates whether shortucts handled by items are dispatched to the next handler or control.")]
	[Browsable(true)]
	[DefaultValue(false)]
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets Bar Color Scheme.")]
	[Browsable(false)]
	[Category("Appearance")]
	[DevCoBrowsable(false)]
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
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool DisabledImagesGrayScale
	{
		get
		{
			return bool_15;
		}
		set
		{
			bool_15 = value;
		}
	}

	[DefaultValue(false)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Specifies whether SideBar is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[DevCoBrowsable(true)]
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

	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[Category("Appearance")]
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

	internal event EventHandler Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_19 = (EventHandler)Delegate.Combine(eventHandler_19, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_19 = (EventHandler)Delegate.Remove(eventHandler_19, value);
		}
	}

	internal event EventHandler Event_1
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_20 = (EventHandler)Delegate.Combine(eventHandler_20, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_20 = (EventHandler)Delegate.Remove(eventHandler_20, value);
		}
	}

	internal event Delegate4 Event_2
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate4_0 = (Delegate4)Delegate.Combine(delegate4_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate4_0 = (Delegate4)Delegate.Remove(delegate4_0, value);
		}
	}

	public BarBaseControl()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
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
		try
		{
			cursor_0 = new Cursor(typeof(DotNetBarManager), "DRAGMOVE.CUR");
			cursor_1 = new Cursor(typeof(DotNetBarManager), "DRAGCOPY.CUR");
			cursor_2 = new Cursor(typeof(DotNetBarManager), "DRAGNONE.CUR");
		}
		catch (Exception)
		{
			cursor_0 = null;
			cursor_1 = null;
			cursor_2 = null;
		}
		colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2003);
		itemStyle_0.BackColor1.Color = SystemColors.Control;
		itemStyle_0.Event_0 += method_11;
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

	internal void method_0(bool bool_16)
	{
		bool_13 = bool_16;
		baseItem_0.SetDesignMode(bool_16);
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new BarBaseControlAccessibleObject(this);
	}

	internal void method_1(AccessibleEvents accessibleEvents_0, int int_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).AccessibilityNotifyClients(accessibleEvents_0, int_1);
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
		if (eventHandler_19 != null)
		{
			eventHandler_19(this, new EventArgs());
		}
	}

	void IOwner.OnApplicationDeactivate()
	{
		ClosePopups();
		if (eventHandler_20 != null)
		{
			eventHandler_20(this, new EventArgs());
		}
	}

	void IOwner.OnParentPositionChanging()
	{
	}

	void IOwner.StartItemDrag(BaseItem objItem)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_0 || baseItem_3 != null)
		{
			return;
		}
		baseItem_3 = objItem;
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
			((Control)this).DoDragDrop((object)objItem, (DragDropEffects)(-2147483645));
			if (bool_4)
			{
				MouseDragDrop(-1, -1, null);
			}
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
		((Control)this).OnParentChanged(e);
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

	void IOwnerMenuSupport.RegisterPopup(PopupItem objPopup)
	{
		if (arrayList_0.Contains(objPopup))
		{
			return;
		}
		if (!GetDesignMode())
		{
			if (!bool_8)
			{
				Class107.smethod_0(this);
				bool_8 = true;
			}
		}
		else if (class94_0 == null)
		{
			class94_0 = new Class94(this);
		}
		if (!bool_10)
		{
			method_3();
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
			method_4();
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

	void IOwnerItemEvents.InvokeCheckedChanged(ButtonItem item, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(item, e);
		}
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
		if (eventHandler_1 != null)
		{
			eventHandler_1(objItem, new EventArgs());
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

	bool Interface5.imethod_5(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	bool Interface5.imethod_2(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected I4, but got Unknown
		if (arrayList_0.Count > 0 && ((BaseItem)arrayList_0[arrayList_0.Count - 1]).Parent == null)
		{
			PopupItem popupItem = (PopupItem)arrayList_0[arrayList_0.Count - 1];
			Control popupControl = popupItem.PopupControl;
			Control val = Control.FromChildHandle(intptr_0);
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
				Keys val2 = (Keys)Class92.MapVirtualKey((uint)(int)intptr_1, 2u);
				if ((int)val2 == 0)
				{
					val2 = (Keys)intptr_1.ToInt32();
				}
				popupItem.InternalKeyDown(new KeyEventArgs(val2));
			}
			if (flag2)
			{
				return false;
			}
			return true;
		}
		if (!IsParentFormActive)
		{
			return false;
		}
		if (intptr_1.ToInt32() < 112 && (int)Control.get_ModifierKeys() == 0 && (intptr_2.ToInt32() & 0x1000000000L) == 0L && intptr_1.ToInt32() != 46 && intptr_1.ToInt32() != 45)
		{
			return false;
		}
		int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
		return method_2((eShortcut)eShortcut_);
	}

	private bool method_2(eShortcut eShortcut_0)
	{
		bool result = Class109.smethod_5(eShortcut_0, hashtable_0);
		if (!bool_9)
		{
			return result;
		}
		return false;
	}

	bool Interface5.imethod_3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (delegate4_0 != null)
		{
			delegate4_0(this, new EventArgs1(intptr_0, intptr_1, intptr_2));
		}
		if (arrayList_0.Count == 0)
		{
			return false;
		}
		for (int num = arrayList_0.Count - 1; num >= 0; num--)
		{
			PopupItem popupItem = arrayList_0[num] as PopupItem;
			bool flag;
			if (!(flag = popupItem.IsAnyOnHandle(intptr_0.ToInt32())))
			{
				Control val = Control.FromChildHandle(intptr_0);
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
					string text = Class92.smethod_8(intptr_0);
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
			popupItem.ClosePopup();
			if (arrayList_0.Count == 0)
			{
				break;
			}
		}
		return false;
	}

	bool Interface5.imethod_4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (arrayList_0.Count > 0)
		{
			foreach (BaseItem item in arrayList_0)
			{
				if (item.Parent == null)
				{
					Control popupControl = ((PopupItem)item).PopupControl;
					if (popupControl != null && popupControl.get_Handle() != intptr_0 && !item.IsAnyOnHandle(intptr_0.ToInt32()) && (popupControl.get_Parent() == null || !(popupControl.get_Parent().get_Handle() != intptr_0)))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	bool Interface5.imethod_0(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		if (!GetDesignMode() && ((int)Control.get_ModifierKeys() != 0 || (intptr_1.ToInt32() >= 112 && intptr_1.ToInt32() <= 123)))
		{
			int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
			if (method_2((eShortcut)eShortcut_))
			{
				return true;
			}
		}
		return false;
	}

	bool Interface5.imethod_1(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	private void method_3()
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
			((Control)val).add_Resize((EventHandler)method_5);
			val.add_Deactivate((EventHandler)method_6);
			DotNetBarManager.RegisterParentMsgHandler(this, val);
		}
	}

	private void method_4()
	{
		if (bool_10)
		{
			bool_10 = false;
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				DotNetBarManager.UnRegisterParentMsgHandler(this, val);
				((Control)val).remove_Resize((EventHandler)method_5);
				val.remove_Deactivate((EventHandler)method_6);
			}
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	private void method_6(object sender, EventArgs e)
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
		else if (((Message)(ref m)).get_Msg() == 1131 && baseItem_5 != null)
		{
			baseItem_5.vmethod_0();
			baseItem_5 = null;
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

	private void method_7()
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
		if (!bool_8 && !((Component)this).DesignMode)
		{
			Class107.smethod_0(this);
			bool_8 = true;
		}
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_7();
		method_4();
		((Control)this).OnHandleDestroyed(e);
		if (bool_8)
		{
			Class107.smethod_1(this);
			bool_8 = false;
		}
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		baseItem_0.InternalClick(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnClick(e);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		baseItem_0.InternalDoubleClick(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnDoubleClick(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		method_8(e);
		((Control)this).OnKeyDown(e);
	}

	internal void method_8(KeyEventArgs keyEventArgs_0)
	{
		baseItem_0.InternalKeyDown(keyEventArgs_0);
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
		if (bool_0 && bool_4)
		{
			if (!bool_3)
			{
				method_9(e.get_X(), e.get_Y(), null);
			}
		}
		else
		{
			baseItem_0.InternalMouseMove(e);
		}
	}

	protected override void OnDragOver(DragEventArgs e)
	{
		if (bool_0 && (bool_4 || bool_5))
		{
			Point point = ((Control)this).PointToClient(new Point(e.get_X(), e.get_Y()));
			method_9(point.X, point.Y, e);
			bool_1 = false;
		}
		((Control)this).OnDragOver(e);
	}

	protected override void OnDragLeave(EventArgs e)
	{
		if (bool_0)
		{
			if (bool_4 || bool_5)
			{
				method_9(-1, -1, null);
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		if (bool_0 && bool_4 && ((bool_1 && (int)e.get_Action() == 1) || (int)e.get_Action() == 2))
		{
			MouseDragDrop(-1, -1, null);
		}
		((Control)this).OnQueryContinueDrag(e);
	}

	private void method_9(int int_1, int int_2, DragEventArgs dragEventArgs_0)
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
		Point pScreen = ((Control)this).PointToScreen(new Point(int_1, int_2));
		foreach (SideBarPanelItem subItem in baseItem_0.SubItems)
		{
			if (!subItem.Visible)
			{
				continue;
			}
			InsertPosition insertPosition = ((IDesignTimeProvider)subItem).GetInsertPosition(pScreen, baseItem);
			if (insertPosition == null)
			{
				if (!bool_3)
				{
					if (cursor_2 != (Cursor)null)
					{
						Cursor.set_Current(cursor_2);
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
				continue;
			}
			if (insertPosition.TargetProvider == null)
			{
				if (!bool_3)
				{
					if (cursor_2 != (Cursor)null)
					{
						Cursor.set_Current(cursor_2);
					}
					else
					{
						Cursor.set_Current(Cursors.get_No());
					}
				}
				break;
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
			break;
		}
	}

	void IOwnerLocalize.InvokeLocalizeString(LocalizeEventArgs e)
	{
		if (localizeStringEventHandler_0 != null)
		{
			localizeStringEventHandler_0(this, e);
		}
	}

	protected void SetBaseItemContainer(BaseItem item)
	{
		baseItem_0 = item;
	}

	internal BaseItem method_10()
	{
		return baseItem_0;
	}

	protected override void OnBindingContextChanged(EventArgs e)
	{
		((Control)this).OnBindingContextChanged(e);
		if (baseItem_0 != null)
		{
			baseItem_0.method_16();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
		((Control)this).Dispose(disposing);
	}

	public void ResetBackgroundStyle()
	{
		itemStyle_0.Event_0 -= method_11;
		itemStyle_0 = new ItemStyle();
		itemStyle_0.Event_0 += method_11;
	}

	private void method_11(object sender, EventArgs e)
	{
		if (itemStyle_0 != null)
		{
			itemStyle_0.method_1(ColorScheme);
		}
		if (GetDesignMode())
		{
			((Control)this).Refresh();
		}
	}

	protected virtual void MouseDragDrop(int x, int y, DragEventArgs dragArgs)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
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
						_ = parent.ContainerControl;
						parent.Refresh();
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

	internal ColorScheme GetColorScheme()
	{
		if (baseItem_0.Style == eDotNetBarStyle.Office2007 && GetRenderer() is Office2007Renderer office2007Renderer && office2007Renderer.ColorTable.LegacyColors != null)
		{
			return office2007Renderer.ColorTable.LegacyColors;
		}
		return colorScheme_0;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (baseItem_0 != null && !((Control)this).get_IsDisposed())
		{
			ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this, (Control)(object)this, e.get_Graphics(), GetColorScheme());
			itemPaintArgs.BaseRenderer_0 = GetRenderer();
			if (bool_14)
			{
				itemPaintArgs.Graphics.set_SmoothingMode((SmoothingMode)4);
				itemPaintArgs.Graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			PaintControlBackground(itemPaintArgs);
			itemPaintArgs.Graphics.SetClip(GetItemContainerRectangle());
			PaintItemContainer(itemPaintArgs);
			itemPaintArgs.Graphics.ResetClip();
			if (baseItem_0.SubItems.Count == 0 && GetDesignMode())
			{
				PaintDesignTimeEmptyHint(itemPaintArgs);
			}
		}
	}

	protected virtual void PaintControlBackground(ItemPaintArgs pa)
	{
		if (itemStyle_0 != null)
		{
			itemStyle_0.method_1(pa.Colors);
			itemStyle_0.Paint(pa.Graphics, ((Control)this).get_ClientRectangle());
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
			Class55.smethod_1(pa.Graphics, text, ((Control)this).get_Font(), SystemColors.ControlDark, itemContainerRectangle, eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
		}
	}

	protected virtual Rectangle GetItemContainerRectangle()
	{
		if (itemStyle_0 == null)
		{
			return ((Control)this).get_ClientRectangle();
		}
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if (itemStyle_0.Border == eBorderType.SingleLine)
		{
			if (itemStyle_0.BorderSide == eBorderSide.All)
			{
				clientRectangle.Inflate(-1, -1);
			}
			else
			{
				if ((itemStyle_0.BorderSide & eBorderSide.Left) != 0)
				{
					clientRectangle.X++;
				}
				if ((itemStyle_0.BorderSide & eBorderSide.Right) != 0)
				{
					clientRectangle.Width--;
				}
				if ((itemStyle_0.BorderSide & eBorderSide.Top) != 0)
				{
					clientRectangle.Y++;
				}
				if ((itemStyle_0.BorderSide & eBorderSide.Bottom) != 0)
				{
					clientRectangle.Height--;
				}
			}
		}
		else if (itemStyle_0.Border != 0)
		{
			if (itemStyle_0.BorderSide == eBorderSide.All)
			{
				clientRectangle.Inflate(-2, -2);
			}
			else
			{
				if ((itemStyle_0.BorderSide & eBorderSide.Left) != 0)
				{
					clientRectangle.X += 2;
				}
				if ((itemStyle_0.BorderSide & eBorderSide.Right) != 0)
				{
					clientRectangle.Width -= 2;
				}
				if ((itemStyle_0.BorderSide & eBorderSide.Top) != 0)
				{
					clientRectangle.Y += 2;
				}
				if ((itemStyle_0.BorderSide & eBorderSide.Bottom) != 0)
				{
					clientRectangle.Height -= 2;
				}
			}
		}
		return clientRectangle;
	}

	protected virtual void RecalcSize()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		if (!baseItem_0.IsRecalculatingSize)
		{
			Rectangle itemContainerRectangle = GetItemContainerRectangle();
			baseItem_0.IsRightToLeft = (int)((Control)this).get_RightToLeft() == 1;
			baseItem_0.LeftInternal = itemContainerRectangle.X;
			baseItem_0.TopInternal = itemContainerRectangle.Y;
			baseItem_0.WidthInternal = itemContainerRectangle.Width;
			baseItem_0.HeightInternal = itemContainerRectangle.Height;
			baseItem_0.RecalcSize();
		}
	}

	public virtual void RecalcLayout()
	{
		if (!baseItem_0.IsRecalculatingSize)
		{
			RecalcSize();
			((Control)this).Invalidate();
		}
	}
}

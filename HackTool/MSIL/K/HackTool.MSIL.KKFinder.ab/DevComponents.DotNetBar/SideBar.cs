using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[ComVisible(false)]
[Designer(typeof(SideBarDesigner))]
public class SideBar : Control, IBarDesignerServices, ICustomSerialization, IOwner, IOwnerItemEvents, IOwnerMenuSupport, Interface5, Interface6
{
	public delegate void ItemRemovedEventHandler(object sender, ItemRemovedEventArgs e);

	public class SideBarAccessibleObject : ControlAccessibleObject
	{
		private SideBar sideBar_0;

		public override string Name
		{
			get
			{
				return ((Control)sideBar_0).get_AccessibleName();
			}
			set
			{
				((Control)sideBar_0).set_AccessibleName(value);
			}
		}

		public override string Description => ((Control)sideBar_0).get_AccessibleDescription();

		public override AccessibleRole Role => ((Control)sideBar_0).get_AccessibleRole();

		public override AccessibleObject Parent
		{
			get
			{
				if (((Control)sideBar_0).get_Parent() != null)
				{
					return ((Control)sideBar_0).get_Parent().get_AccessibilityObject();
				}
				return null;
			}
		}

		public override Rectangle Bounds
		{
			get
			{
				if (((Control)sideBar_0).get_Parent() != null)
				{
					return ((Control)sideBar_0).get_Parent().RectangleToScreen(((Control)sideBar_0).get_Bounds());
				}
				return ((Control)sideBar_0).get_DisplayRectangle();
			}
		}

		public override AccessibleStates State
		{
			get
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				AccessibleStates result = (AccessibleStates)256;
				if (((Control)sideBar_0).get_Focused())
				{
					result = (AccessibleStates)4;
				}
				return result;
			}
		}

		public SideBarAccessibleObject(SideBar owner)
			: base((Control)(object)owner)
		{
			sideBar_0 = owner;
		}

		internal void method_0(BaseItem baseItem_0, AccessibleEvents accessibleEvents_0)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			int num = sideBar_0.Panels.IndexOf(baseItem_0);
			if (num >= 0)
			{
				((Control)sideBar_0).AccessibilityNotifyClients(accessibleEvents_0, num);
			}
		}

		public override int GetChildCount()
		{
			return sideBar_0.Panels.Count;
		}

		public override AccessibleObject GetChild(int iIndex)
		{
			return sideBar_0.Panels[iIndex].AccessibleObject;
		}
	}

	private const string string_0 = "Right-click and choose Add New Panel or use Panels collection to create new panels. Right-click to Choose Color Scheme.";

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

	private OptionGroupChangingEventHandler optionGroupChangingEventHandler_0;

	private EventHandler eventHandler_18;

	private SerializeItemEventHandler serializeItemEventHandler_0;

	private SerializeItemEventHandler serializeItemEventHandler_1;

	private SideBarContainerItem sideBarContainerItem_0;

	private Timer timer_0;

	private BaseItem baseItem_0;

	private BaseItem baseItem_1;

	private BaseItem baseItem_2;

	private ImageList imageList_0;

	private ImageList imageList_1;

	private ImageList imageList_2;

	private bool bool_0 = true;

	private bool bool_1;

	private Hashtable hashtable_0 = new Hashtable();

	private eBorderType eBorderType_0 = eBorderType.Sunken;

	private SideBarPanelItem sideBarPanelItem_0;

	private BaseItem baseItem_3;

	private bool bool_2;

	private Cursor cursor_0;

	private Cursor cursor_1;

	private Cursor cursor_2;

	private IDesignTimeProvider idesignTimeProvider_0;

	private int int_0;

	private bool bool_3;

	private bool bool_4 = true;

	private bool bool_5;

	private Class77 class77_0;

	private Class78 class78_0;

	private Class79 class79_0;

	private Class65 class65_0;

	private Class63 class63_0;

	private Class81 class81_0;

	private Class64 class64_0;

	private Class82 class82_0;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private ColorScheme colorScheme_0;

	private eSideBarAppearance eSideBarAppearance_0;

	private eSideBarColorScheme eSideBarColorScheme_0 = eSideBarColorScheme.Blue;

	private bool bool_12;

	private bool bool_13;

	private BarBaseControlDesigner barBaseControlDesigner_0;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	private bool bool_14 = true;

	private ArrayList arrayList_0 = new ArrayList();

	private Class94 class94_0;

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

	[Browsable(false)]
	[DefaultValue(eRenderMode.Global)]
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

	[Description("Indicates visual appearance for the control.")]
	[Category("Appearance")]
	[DefaultValue(eSideBarAppearance.Traditional)]
	[Browsable(true)]
	public eSideBarAppearance Appearance
	{
		get
		{
			return eSideBarAppearance_0;
		}
		set
		{
			if (eSideBarAppearance_0 == value)
			{
				return;
			}
			eSideBarAppearance_0 = value;
			sideBarContainerItem_0.ESideBarAppearance_0 = value;
			if (eSideBarAppearance_0 == eSideBarAppearance.Flat && Panels.Count > 0 && Panels[0] is SideBarPanelItem && !((SideBarPanelItem)Panels[0]).BackgroundStyle.Boolean_0)
			{
				PredefinedColorScheme = eSideBarColorScheme.SystemColors;
				if (((Component)this).DesignMode)
				{
					method_3(eSideBarColorScheme.SystemColors);
				}
			}
			((Control)this).Refresh();
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	public bool UsingSystemColors
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
		}
	}

	[Browsable(false)]
	[DesignOnly(true)]
	public eSideBarColorScheme PredefinedColorScheme
	{
		get
		{
			return eSideBarColorScheme_0;
		}
		set
		{
			eSideBarColorScheme_0 = value;
			if (eSideBarColorScheme_0 == eSideBarColorScheme.SystemColors)
			{
				bool_12 = true;
			}
			else
			{
				bool_12 = false;
			}
			if (!((Component)this).DesignMode)
			{
				method_3(eSideBarColorScheme_0);
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(false)]
	[Category("Appearance")]
	[Description("Gets or sets Bar Color Scheme.")]
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

	[Category("Appearance")]
	[Description("Specifies the visual style of the side bar.")]
	[Browsable(true)]
	[DefaultValue(eDotNetBarStyle.OfficeXP)]
	[DevCoBrowsable(true)]
	public eDotNetBarStyle Style
	{
		get
		{
			return sideBarContainerItem_0.Style;
		}
		set
		{
			if (sideBarContainerItem_0.Style != value)
			{
				colorScheme_0.EDotNetBarStyle_0 = value;
				sideBarContainerItem_0.Style = value;
				((Control)this).Invalidate();
				RecalcLayout();
			}
		}
	}

	protected bool IsThemed
	{
		get
		{
			if (bool_5 && (sideBarContainerItem_0.Style == eDotNetBarStyle.OfficeXP || sideBarContainerItem_0.Style == eDotNetBarStyle.Office2003 || sideBarContainerItem_0.Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(sideBarContainerItem_0.Style)) && Class109.Boolean_0 && Class58.bool_0)
			{
				return true;
			}
			return false;
		}
	}

	[Description("Specifies whether SideBar is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[DefaultValue(false)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public virtual bool ThemeAware
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
			sideBarContainerItem_0.ThemeAware = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
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

	[Category("Data")]
	[Description("Returns the collection of side-bar Panels.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Editor(typeof(SideBarPanelsEditor), typeof(UITypeEditor))]
	public SubItemsCollection Panels => sideBarContainerItem_0.SubItems;

	[Category("Data")]
	[Description("Gets or sets the expanded panel. Only one panel can be expanded at a time.")]
	[Browsable(true)]
	public SideBarPanelItem ExpandedPanel
	{
		get
		{
			return sideBarContainerItem_0.ExpandedItem() as SideBarPanelItem;
		}
		set
		{
			if (!sideBarContainerItem_0.SubItems.Contains(value))
			{
				sideBarPanelItem_0 = value;
			}
			else
			{
				value.Expanded = true;
			}
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

	bool IOwner.DesignMode => ((Component)this).DesignMode;

	[Description("Specifies whether end-user can rearrange the items inside the panels.")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Behavior")]
	public bool AllowUserCustomize
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

	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Specifies whether native .NET Drag and Drop is used by side-bar to perform drag and drop operations.")]
	[Category("Behavior")]
	public bool UseNativeDragDrop
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

	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Gets or sets whether external ButtonItem object is accepted in drag and drop operation.")]
	public bool AllowExternalDrop
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

	[Browsable(true)]
	[Description("Gets or sets whether gray-scale algorithm is used to create automatic gray-scale images.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool DisabledImagesGrayScale
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

	[Browsable(true)]
	[Description("ImageList for medium-sized images used on Items.")]
	[DefaultValue(null)]
	[Category("Data")]
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

	[Category("Data")]
	[Browsable(true)]
	[Description("ImageList for large-sized images used on Items.")]
	[DefaultValue(null)]
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

	bool IOwner.DragInProgress => bool_2;

	BaseItem IOwner.DragItem => baseItem_3;

	[DefaultValue(true)]
	[Category("Run-time Behavior")]
	[Browsable(true)]
	[Description("Indicates whether Tooltips are shown on Bars and menus.")]
	public bool ShowToolTips
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

	[Browsable(true)]
	[Description("Indicates whether item shortcut is displayed in Tooltips.")]
	[Category("Run-time Behavior")]
	[DefaultValue(false)]
	public bool ShowShortcutKeysInToolTips
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
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
	public SideBarContainerItem ItemsContainer => sideBarContainerItem_0;

	[Description("Indicates border style when Bar is docked.")]
	[Category("Appearance")]
	[DefaultValue(eBorderType.Sunken)]
	[Browsable(true)]
	public eBorderType BorderStyle
	{
		get
		{
			return eBorderType_0;
		}
		set
		{
			if (eBorderType_0 != value)
			{
				if (eBorderType_0 == eBorderType.None)
				{
					eBorderType_0 = value;
					RecalcSize();
				}
				else
				{
					eBorderType_0 = value;
				}
				((Control)this).Refresh();
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
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

	bool ICustomSerialization.HasSerializeItemHandlers => serializeItemEventHandler_0 != null;

	bool ICustomSerialization.HasDeserializeItemHandlers => serializeItemEventHandler_1 != null;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public string Definition
	{
		get
		{
			XmlDocument xmlDocument = new XmlDocument();
			method_8(xmlDocument);
			return xmlDocument.OuterXml;
		}
		set
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(value);
			method_11(xmlDocument);
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether shortucts handled by items are dispatched to the next handler or control.")]
	[Category("Behavior")]
	public bool DispatchShortcuts
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
		}
	}

	private bool Boolean_0
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

	public event SerializeItemEventHandler SerializeItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			serializeItemEventHandler_0 = (SerializeItemEventHandler)Delegate.Combine(serializeItemEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			serializeItemEventHandler_0 = (SerializeItemEventHandler)Delegate.Remove(serializeItemEventHandler_0, value);
		}
	}

	public event SerializeItemEventHandler DeserializeItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			serializeItemEventHandler_1 = (SerializeItemEventHandler)Delegate.Combine(serializeItemEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			serializeItemEventHandler_1 = (SerializeItemEventHandler)Delegate.Remove(serializeItemEventHandler_1, value);
		}
	}

	public SideBar()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		sideBarContainerItem_0 = new SideBarContainerItem();
		sideBarContainerItem_0.GlobalItem = false;
		sideBarContainerItem_0.ContainerControl = this;
		sideBarContainerItem_0.Stretch = false;
		sideBarContainerItem_0.Displayed = true;
		sideBarContainerItem_0.method_6(this);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		_003F val = this;
		object obj = SystemInformation.get_MenuFont().Clone();
		((Control)val).set_Font((Font)((obj is Font) ? obj : null));
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		RemindForm remindForm = new RemindForm();
		remindForm.method_0();
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
		((Control)this).set_AccessibleRole((AccessibleRole)22);
		colorScheme_0 = new ColorScheme();
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

	protected override void OnBindingContextChanged(EventArgs e)
	{
		((Control)this).OnBindingContextChanged(e);
		if (sideBarContainerItem_0 != null)
		{
			sideBarContainerItem_0.method_16();
		}
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new SideBarAccessibleObject(this);
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		sideBarContainerItem_0.InternalClick(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnClick(e);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		sideBarContainerItem_0.InternalDoubleClick(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnDoubleClick(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		method_0(e);
		((Control)this).OnKeyDown(e);
	}

	internal void method_0(KeyEventArgs keyEventArgs_0)
	{
		sideBarContainerItem_0.InternalKeyDown(keyEventArgs_0);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		((Control)this).OnLostFocus(e);
		((IOwner)this).SetFocusItem((BaseItem)null);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		if (sideBarContainerItem_0 != null)
		{
			sideBarContainerItem_0.FocusNextItem();
		}
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_Focused())
		{
			if ((int)keyData == 40)
			{
				if (sideBarContainerItem_0 != null)
				{
					sideBarContainerItem_0.FocusNextItem();
				}
				if (((IOwner)this).GetFocusItem() != null)
				{
					return true;
				}
			}
			else if ((int)keyData == 38)
			{
				if (sideBarContainerItem_0 != null)
				{
					sideBarContainerItem_0.FocusPreviousItem();
				}
				if (((IOwner)this).GetFocusItem() != null)
				{
					return true;
				}
			}
			else if ((int)keyData == 13 && ((IOwner)this).GetFocusItem() != null)
			{
				BaseItem focusItem = ((IOwner)this).GetFocusItem();
				if (focusItem is SideBarPanelItem)
				{
					focusItem.Expanded = !focusItem.Expanded;
				}
				else
				{
					focusItem.RaiseClick();
				}
				return true;
			}
		}
		return ((Control)this).ProcessDialogKey(keyData);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		sideBarContainerItem_0.InternalMouseDown(e);
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		sideBarContainerItem_0.InternalMouseHover();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (((Control)this).get_Cursor() != Cursors.get_Arrow())
		{
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
		sideBarContainerItem_0.InternalMouseLeave();
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (bool_2)
		{
			if (!bool_6)
			{
				method_1(e.get_X(), e.get_Y(), null);
			}
		}
		else
		{
			sideBarContainerItem_0.InternalMouseMove(e);
		}
	}

	protected override void OnDragOver(DragEventArgs e)
	{
		if (bool_2 || bool_8)
		{
			Point point = ((Control)this).PointToClient(new Point(e.get_X(), e.get_Y()));
			method_1(point.X, point.Y, e);
			bool_9 = false;
		}
		((Control)this).OnDragOver(e);
	}

	protected override void OnDragLeave(EventArgs e)
	{
		if (bool_2 || bool_8)
		{
			method_1(-1, -1, null);
		}
		bool_9 = true;
		bool_8 = false;
		((Control)this).OnDragLeave(e);
	}

	protected override void OnDragEnter(DragEventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		((Control)this).OnDragEnter(e);
		if (bool_2 || !bool_7)
		{
			return;
		}
		if (e.get_Data().GetData(typeof(ButtonItem)) == null)
		{
			if ((int)e.get_Effect() != 0)
			{
				bool_8 = true;
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
		bool_8 = true;
	}

	protected override void OnDragDrop(DragEventArgs e)
	{
		if (bool_2)
		{
			Point point = ((Control)this).PointToClient(new Point(e.get_X(), e.get_Y()));
			method_2(point.X, point.Y, null);
		}
		else if (bool_8)
		{
			Point point2 = ((Control)this).PointToClient(new Point(e.get_X(), e.get_Y()));
			method_2(point2.X, point2.Y, e);
		}
		((Control)this).OnDragDrop(e);
	}

	protected override void OnQueryContinueDrag(QueryContinueDragEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (bool_2 && ((bool_9 && (int)e.get_Action() == 1) || (int)e.get_Action() == 2))
		{
			method_2(-1, -1, null);
		}
		((Control)this).OnQueryContinueDrag(e);
	}

	private void method_1(int int_1, int int_2, DragEventArgs dragEventArgs_0)
	{
		if (!bool_2 && !bool_8)
		{
			return;
		}
		BaseItem baseItem = baseItem_3;
		if (bool_8 && dragEventArgs_0 != null)
		{
			baseItem = dragEventArgs_0.get_Data().GetData(typeof(ButtonItem)) as BaseItem;
		}
		if (idesignTimeProvider_0 != null)
		{
			idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_3);
			idesignTimeProvider_0 = null;
		}
		if (bool_8 && baseItem == null)
		{
			return;
		}
		Point pScreen = ((Control)this).PointToScreen(new Point(int_1, int_2));
		foreach (SideBarPanelItem subItem in sideBarContainerItem_0.SubItems)
		{
			if (!subItem.Visible)
			{
				continue;
			}
			InsertPosition insertPosition = ((IDesignTimeProvider)subItem).GetInsertPosition(pScreen, baseItem);
			if (insertPosition == null)
			{
				if (!bool_6)
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
				if (!bool_6)
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
			bool_3 = insertPosition.Before;
			idesignTimeProvider_0 = insertPosition.TargetProvider;
			if (!bool_6)
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

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		if (!bool_6)
		{
			method_2(e.get_X(), e.get_Y(), null);
		}
		sideBarContainerItem_0.InternalMouseUp(e);
	}

	private void method_2(int int_1, int int_2, DragEventArgs dragEventArgs_0)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		if (!bool_2 && !bool_8)
		{
			return;
		}
		BaseItem baseItem = baseItem_3;
		if (bool_8)
		{
			baseItem = dragEventArgs_0.get_Data().GetData(typeof(ButtonItem)) as BaseItem;
		}
		baseItem?.InternalMouseLeave();
		if (idesignTimeProvider_0 != null)
		{
			if (int_1 == -1 && int_2 == -1)
			{
				idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_3);
			}
			else
			{
				idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_3);
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
					idesignTimeProvider_0.InsertItemAt(baseItem, int_0, bool_3);
					idesignTimeProvider_0 = null;
					((IOwner)this).InvokeUserCustomize((object)baseItem, new EventArgs());
				}
			}
		}
		idesignTimeProvider_0 = null;
		bool_2 = false;
		bool_8 = false;
		if (!bool_6)
		{
			Cursor.set_Current(Cursors.get_Default());
		}
		((Control)this).set_Capture(false);
		if (baseItem != null)
		{
			baseItem.bool_12 = true;
		}
		sideBarContainerItem_0.InternalMouseUp(new MouseEventArgs((MouseButtons)1048576, 0, int_1, int_2, 0));
		if (baseItem != null)
		{
			baseItem.bool_12 = false;
		}
		baseItem_3 = null;
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

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		if (sideBarContainerItem_0 == null || ((Control)this).get_IsDisposed())
		{
			return;
		}
		Graphics graphics = e.get_Graphics();
		graphics.set_PageUnit((GraphicsUnit)2);
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if (Style != eDotNetBarStyle.Office2007)
		{
			Class109.smethod_28(graphics, eBorderType_0, clientRectangle, SystemColors.ControlText);
		}
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this, (Control)(object)this, e.get_Graphics(), colorScheme_0);
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		if (Style == eDotNetBarStyle.Office2007)
		{
			BaseRenderer baseRenderer = itemPaintArgs.BaseRenderer_0;
			SideBarRendererEventArgs sideBarRendererEventArgs = new SideBarRendererEventArgs(this, graphics);
			sideBarRendererEventArgs.itemPaintArgs_0 = itemPaintArgs;
			baseRenderer.DrawSideBar(sideBarRendererEventArgs);
		}
		else if (((Control)this).get_BackColor() == SystemColors.Control && IsThemed)
		{
			if (eBorderType_0 == eBorderType.SingleLine)
			{
				clientRectangle.Inflate(-1, -1);
			}
			else if (eBorderType_0 != 0)
			{
				clientRectangle.Inflate(-2, -2);
			}
			Class78 @class = ((Interface6)this).Class78_0;
			@class.method_0(e.get_Graphics(), Class139.class139_0, Class164.class164_0, clientRectangle);
		}
		else
		{
			if (eBorderType_0 == eBorderType.None)
			{
				SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
				try
				{
					graphics.FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			else if (eBorderType_0 == eBorderType.SingleLine)
			{
				clientRectangle.Inflate(-1, -1);
			}
			else
			{
				clientRectangle.Inflate(-2, -2);
			}
			graphics.FillRectangle((Brush)new SolidBrush(((Control)this).get_BackColor()), clientRectangle);
		}
		sideBarContainerItem_0.Paint(itemPaintArgs);
		if (sideBarContainerItem_0.SubItems.Count == 0 && ((Component)this).DesignMode)
		{
			string text = "Right-click and choose Add New Panel or use Panels collection to create new panels. Right-click to Choose Color Scheme.";
			Rectangle clientRectangle2 = ((Control)this).get_ClientRectangle();
			clientRectangle.Inflate(-2, -2);
			Class55.smethod_1(graphics, text, ((Control)this).get_Font(), SystemColors.ControlDark, clientRectangle2, eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeColorScheme()
	{
		return colorScheme_0.SchemeChanged;
	}

	internal void method_3(eSideBarColorScheme eSideBarColorScheme_1)
	{
		if (sideBarContainerItem_0 == null)
		{
			return;
		}
		ApplyColorScheme(ColorScheme, eSideBarColorScheme_1);
		foreach (BaseItem subItem in sideBarContainerItem_0.SubItems)
		{
			if (subItem is SideBarPanelItem)
			{
				ApplyColorScheme((SideBarPanelItem)subItem, eSideBarColorScheme_1);
			}
		}
		((Control)this).Refresh();
	}

	internal void method_4()
	{
		eSideBarAppearance_0 = eSideBarAppearance.Traditional;
		colorScheme_0.EDotNetBarStyle_0 = sideBarContainerItem_0.Style;
		sideBarContainerItem_0.Style = sideBarContainerItem_0.Style;
		foreach (SideBarPanelItem panel in Panels)
		{
			panel.ResetHeaderHotStyle();
			panel.ResetHeaderMouseDownStyle();
			panel.ResetHeaderSideHotStyle();
			panel.ResetHeaderSideMouseDownStyle();
			panel.ResetHeaderSideStyle();
			panel.ResetHeaderStyle();
			panel.ResetBackgroundStyle();
		}
		((Control)this).Invalidate();
		RecalcLayout();
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		colorScheme_0.Refresh(null, bSystemColorEvent: true);
		if (sideBarContainerItem_0 != null)
		{
			foreach (SideBarPanelItem subItem in sideBarContainerItem_0.SubItems)
			{
				subItem.method_18();
			}
		}
		if (bool_12 && Appearance != 0)
		{
			PredefinedColorScheme = eSideBarColorScheme.SystemColors;
			((Control)this).Invalidate(true);
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 794)
		{
			method_5();
		}
		((Control)this).WndProc(ref m);
	}

	private void method_5()
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

	private void method_6()
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

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_6();
		method_14();
		((Control)this).OnHandleDestroyed(e);
		if (bool_11)
		{
			Class107.smethod_1(this);
			bool_11 = false;
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			RecalcSize();
		}
	}

	protected virtual void RecalcSize()
	{
		if (!Class109.smethod_11((Control)(object)this))
		{
			return;
		}
		if (eBorderType_0 == eBorderType.None)
		{
			if (Style == eDotNetBarStyle.Office2007)
			{
				sideBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - 2;
				sideBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - 2;
				sideBarContainerItem_0.LeftInternal = 1;
				sideBarContainerItem_0.TopInternal = 1;
			}
			else if (eSideBarAppearance_0 == eSideBarAppearance.Traditional)
			{
				sideBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - 2;
				sideBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - 2;
			}
			else
			{
				sideBarContainerItem_0.WidthInternal = ((Control)this).get_Width();
				sideBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - 2;
			}
		}
		else
		{
			sideBarContainerItem_0.LeftInternal = 2;
			sideBarContainerItem_0.TopInternal = 2;
			sideBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - 4;
			sideBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - 4;
		}
		sideBarContainerItem_0.RecalcSize();
	}

	public void RecalcLayout()
	{
		RecalcSize();
		((Control)this).Refresh();
	}

	internal void method_7()
	{
		sideBarContainerItem_0.SetDesignMode(b: true);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (((Component)this).DesignMode)
		{
			method_7();
		}
		((Control)this).OnHandleCreated(e);
		if (!bool_11 && !((Component)this).DesignMode)
		{
			Class107.smethod_0(this);
			bool_11 = true;
		}
		RecalcLayout();
	}

	protected override void OnParentChanged(EventArgs e)
	{
		((Control)this).OnParentChanged(e);
		if (sideBarPanelItem_0 != null)
		{
			if (sideBarContainerItem_0.SubItems.Contains(sideBarPanelItem_0))
			{
				sideBarPanelItem_0.Expanded = true;
			}
			sideBarPanelItem_0 = null;
		}
		if (((Control)this).get_Parent() == null || (Images == null && ImagesLarge == null && ImagesMedium == null))
		{
			return;
		}
		foreach (SideBarPanelItem subItem in sideBarContainerItem_0.SubItems)
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
			baseItem_0 = item;
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

	void IOwnerItemEvents.InvokeCheckedChanged(ButtonItem item, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(item, e);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (baseItem_0 != null)
		{
			baseItem_0.RaiseClick();
		}
		else
		{
			timer_0.Stop();
		}
	}

	public ArrayList GetItems(string ItemName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_46(sideBarContainerItem_0, ItemName, arrayList);
		return arrayList;
	}

	public ArrayList GetItems(string ItemName, Type itemType)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_48(sideBarContainerItem_0, ItemName, arrayList, itemType);
		return arrayList;
	}

	public ArrayList GetItems(string ItemName, Type itemType, bool useGlobalName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_49(sideBarContainerItem_0, ItemName, arrayList, itemType, useGlobalName);
		return arrayList;
	}

	public BaseItem GetItem(string ItemName)
	{
		BaseItem baseItem = Class109.smethod_44(sideBarContainerItem_0, ItemName);
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
		if (objFocusItem == null)
		{
			objFocusItem = null;
		}
		if (((Component)this).DesignMode && Panels.Contains(objFocusItem))
		{
			foreach (BaseItem panel in Panels)
			{
				BaseItem.CollapseSubItems(panel);
			}
		}
		baseItem_2 = objFocusItem;
		if (baseItem_2 != null)
		{
			baseItem_2.OnGotFocus();
		}
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

	void IOwner.StartItemDrag(BaseItem objItem)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if (baseItem_3 != null)
		{
			return;
		}
		baseItem_3 = objItem;
		if (!bool_6)
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
			bool_2 = true;
		}
		else
		{
			bool_2 = true;
			((Control)this).DoDragDrop((object)objItem, (DragDropEffects)(-2147483645));
			if (bool_2)
			{
				method_2(-1, -1, null);
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

	void ICustomSerialization.InvokeSerializeItem(SerializeItemEventArgs e)
	{
		if (serializeItemEventHandler_0 != null)
		{
			serializeItemEventHandler_0(this, e);
		}
	}

	void ICustomSerialization.InvokeDeserializeItem(SerializeItemEventArgs e)
	{
		if (serializeItemEventHandler_1 != null)
		{
			serializeItemEventHandler_1(this, e);
		}
	}

	internal void method_8(XmlDocument xmlDocument_0)
	{
		XmlElement xmlElement = xmlDocument_0.CreateElement("sidebar");
		xmlDocument_0.AppendChild(xmlElement);
		method_9(xmlElement);
	}

	internal void method_9(XmlElement xmlElement_0)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected I4, but got Unknown
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		itemSerializationContext.Serializer = this;
		itemSerializationContext.HasDeserializeItemHandlers = ((ICustomSerialization)this).HasDeserializeItemHandlers;
		itemSerializationContext.HasSerializeItemHandlers = ((ICustomSerialization)this).HasSerializeItemHandlers;
		xmlElement_0.SetAttribute("name", ((Control)this).get_Name());
		xmlElement_0.SetAttribute("style", XmlConvert.ToString((int)sideBarContainerItem_0.Style));
		xmlElement_0.SetAttribute("app", XmlConvert.ToString((int)eSideBarAppearance_0));
		xmlElement_0.SetAttribute("psc", XmlConvert.ToString((int)eSideBarColorScheme_0));
		if (((Control)this).get_Font() != null && (((Control)this).get_Font().get_Name() != SystemInformation.get_MenuFont().get_Name() || ((Control)this).get_Font().get_Size() != SystemInformation.get_MenuFont().get_Size() || ((Control)this).get_Font().get_Style() != SystemInformation.get_MenuFont().get_Style()))
		{
			xmlElement_0.SetAttribute("fontname", ((Control)this).get_Font().get_Name());
			xmlElement_0.SetAttribute("fontemsize", XmlConvert.ToString(((Control)this).get_Font().get_Size()));
			xmlElement_0.SetAttribute("fontstyle", XmlConvert.ToString((int)((Control)this).get_Font().get_Style()));
		}
		if (((Control)this).get_BackColor() != SystemColors.Control)
		{
			xmlElement_0.SetAttribute("backcolor", Class109.smethod_50(((Control)this).get_BackColor()));
		}
		if (((Control)this).get_ForeColor() != SystemColors.ControlText)
		{
			xmlElement_0.SetAttribute("forecolor", Class109.smethod_50(((Control)this).get_ForeColor()));
		}
		xmlElement_0.SetAttribute("width", XmlConvert.ToString(((Control)this).get_Width()));
		xmlElement_0.SetAttribute("height", XmlConvert.ToString(((Control)this).get_Height()));
		XmlElement xmlElement = xmlElement_0.OwnerDocument.CreateElement("items");
		xmlElement_0.AppendChild(xmlElement);
		foreach (BaseItem subItem in sideBarContainerItem_0.SubItems)
		{
			if (subItem.ShouldSerialize)
			{
				XmlElement xmlElement2 = xmlElement_0.OwnerDocument.CreateElement("item");
				xmlElement.AppendChild(xmlElement2);
				itemSerializationContext.ItemXmlElement = xmlElement2;
				subItem.Serialize(itemSerializationContext);
			}
		}
		if (colorScheme_0.SchemeChanged)
		{
			XmlElement xmlElement3 = xmlElement_0.OwnerDocument.CreateElement("colorscheme");
			colorScheme_0.Serialize(xmlElement3);
			xmlElement_0.AppendChild(xmlElement3);
		}
	}

	internal void method_10(XmlElement xmlElement_0)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		itemSerializationContext.Serializer = this;
		itemSerializationContext.HasDeserializeItemHandlers = ((ICustomSerialization)this).HasDeserializeItemHandlers;
		itemSerializationContext.HasSerializeItemHandlers = ((ICustomSerialization)this).HasSerializeItemHandlers;
		((Control)this).set_Name(xmlElement_0.GetAttribute("name"));
		sideBarContainerItem_0.Style = (eDotNetBarStyle)XmlConvert.ToInt32(xmlElement_0.GetAttribute("style"));
		if (xmlElement_0.HasAttribute("backcolor"))
		{
			((Control)this).set_BackColor(Class109.smethod_51(xmlElement_0.GetAttribute("backcolor")));
		}
		if (xmlElement_0.HasAttribute("forecolor"))
		{
			((Control)this).set_ForeColor(Class109.smethod_51(xmlElement_0.GetAttribute("forecolor")));
		}
		((Control)this).set_Size(new Size(XmlConvert.ToInt32(xmlElement_0.GetAttribute("width")), XmlConvert.ToInt32(xmlElement_0.GetAttribute("height"))));
		if (xmlElement_0.HasAttribute("fontname"))
		{
			string attribute = xmlElement_0.GetAttribute("fontname");
			float num = XmlConvert.ToSingle(xmlElement_0.GetAttribute("fontemsize"));
			FontStyle val = (FontStyle)XmlConvert.ToInt32(xmlElement_0.GetAttribute("fontstyle"));
			try
			{
				((Control)this).set_Font(new Font(attribute, num, val));
			}
			catch (Exception)
			{
				_003F val2 = this;
				object obj = SystemInformation.get_MenuFont().Clone();
				((Control)val2).set_Font((Font)((obj is Font) ? obj : null));
			}
		}
		foreach (XmlElement childNode in xmlElement_0.ChildNodes)
		{
			if (childNode.Name == "items")
			{
				foreach (XmlElement childNode2 in childNode.ChildNodes)
				{
					BaseItem baseItem = Class109.smethod_18(childNode2);
					sideBarContainerItem_0.SubItems.Add(baseItem);
					itemSerializationContext.ItemXmlElement = childNode2;
					baseItem.Deserialize(itemSerializationContext);
				}
			}
			else if (childNode.Name == "colorscheme")
			{
				colorScheme_0.Deserialize(childNode);
			}
		}
		if (xmlElement_0.HasAttribute("app"))
		{
			Appearance = (eSideBarAppearance)XmlConvert.ToInt32(xmlElement_0.GetAttribute("app"));
		}
		xmlElement_0.SetAttribute("app", XmlConvert.ToString((int)eSideBarAppearance_0));
		if (xmlElement_0.HasAttribute("psc") && Appearance != 0)
		{
			PredefinedColorScheme = (eSideBarColorScheme)XmlConvert.ToInt32(xmlElement_0.GetAttribute("psc"));
		}
	}

	public void LoadDefinition(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(FileName);
		method_11(xmlDocument);
	}

	internal void method_11(XmlDocument xmlDocument_0)
	{
		if (xmlDocument_0.FirstChild!.Name != "sidebar")
		{
			throw new InvalidOperationException("XML Format not recognized");
		}
		sideBarContainerItem_0.SubItems.Clear();
		method_10(xmlDocument_0.FirstChild as XmlElement);
		((IOwner)this)?.AddShortcutsFromItem((BaseItem)sideBarContainerItem_0);
		((IOwner)this).InvokeDefinitionLoaded((object)this, new EventArgs());
		RecalcSize();
	}

	public void SaveDefinition(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		method_8(xmlDocument);
		xmlDocument.Save(FileName);
	}

	void IOwner.InvokeDefinitionLoaded(object sender, EventArgs e)
	{
		if (eventHandler_17 != null)
		{
			eventHandler_17(sender, e);
		}
	}

	private bool method_12(eShortcut eShortcut_0)
	{
		bool result = Class109.smethod_5(eShortcut_0, hashtable_0);
		if (!bool_10)
		{
			return result;
		}
		return false;
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
		if (!Boolean_0)
		{
			return false;
		}
		if (intptr_1.ToInt32() < 112 && (int)Control.get_ModifierKeys() == 0 && (intptr_2.ToInt32() & 0x1000000000L) == 0L && intptr_1.ToInt32() != 46 && intptr_1.ToInt32() != 45)
		{
			return false;
		}
		int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
		return method_12((eShortcut)eShortcut_);
	}

	bool Interface5.imethod_3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (arrayList_0.Count != 0 && !((Component)this).DesignMode)
		{
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
		if (!((Component)this).DesignMode && ((int)Control.get_ModifierKeys() != 0 || (intptr_1.ToInt32() >= 112 && intptr_1.ToInt32() <= 123)))
		{
			int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
			if (method_12((eShortcut)eShortcut_))
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

	private void method_13()
	{
		if (!bool_13)
		{
			bool_13 = true;
			Form val = ((Control)this).FindForm();
			if (val == null)
			{
				bool_13 = false;
				return;
			}
			((Control)val).add_Resize((EventHandler)method_15);
			val.add_Deactivate((EventHandler)method_16);
			DotNetBarManager.RegisterParentMsgHandler(this, val);
		}
	}

	private void method_14()
	{
		if (bool_13)
		{
			bool_13 = false;
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				DotNetBarManager.UnRegisterParentMsgHandler(this, val);
				((Control)val).remove_Resize((EventHandler)method_15);
				val.remove_Deactivate((EventHandler)method_16);
			}
		}
	}

	private void method_15(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	void IOwnerMenuSupport.RegisterPopup(PopupItem objPopup)
	{
		if (arrayList_0.Contains(objPopup))
		{
			return;
		}
		if (!((Component)this).DesignMode)
		{
			if (!bool_11)
			{
				Class107.smethod_0(this);
				bool_11 = true;
			}
			if (!bool_13)
			{
				method_13();
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
			method_14();
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

	public static void ApplyColorScheme(SideBarPanelItem item, eSideBarColorScheme scheme)
	{
		Class35 colorScheme = GetColorScheme(scheme);
		colorScheme.method_0(item);
	}

	public static void ApplyColorScheme(ColorScheme cs, eSideBarColorScheme scheme)
	{
		Class35 colorScheme = GetColorScheme(scheme);
		colorScheme.method_1(cs);
	}

	private static Class35 GetColorScheme(eSideBarColorScheme scheme)
	{
		Class35 result = null;
		switch (scheme)
		{
		case eSideBarColorScheme.SystemColors:
			result = smethod_2();
			break;
		case eSideBarColorScheme.Blue:
		case eSideBarColorScheme.Silver:
		case eSideBarColorScheme.Green:
		case eSideBarColorScheme.Orange:
		case eSideBarColorScheme.Red:
		case eSideBarColorScheme.LightBlue:
		case eSideBarColorScheme.Money:
			result = smethod_0(scheme);
			break;
		case eSideBarColorScheme.Brick:
		case eSideBarColorScheme.Wheat:
		case eSideBarColorScheme.Storm:
		case eSideBarColorScheme.Spruce:
		case eSideBarColorScheme.Slate:
		case eSideBarColorScheme.Rose:
		case eSideBarColorScheme.Fire:
		case eSideBarColorScheme.Pumpkin:
		case eSideBarColorScheme.Plum:
		case eSideBarColorScheme.Marine:
		case eSideBarColorScheme.Sunset:
			result = smethod_1(scheme);
			break;
		}
		return result;
	}

	private static Class35 smethod_0(eSideBarColorScheme eSideBarColorScheme_1)
	{
		Color color_ = Color.Empty;
		Color color = Color.Empty;
		Color color2 = Color.Empty;
		Color color3 = Color.Empty;
		Color color4 = Color.Empty;
		Color color_2 = Color.Empty;
		Color color_3 = Color.Empty;
		Color color_4 = Color.Empty;
		Color color5 = Color.Empty;
		Color color6 = Color.Empty;
		Color color7 = Color.Empty;
		Color color_5 = Color.Empty;
		Color color_6 = Color.Empty;
		Color color8 = Color.Empty;
		Color color_7 = Color.Empty;
		Color color_8 = Color.Empty;
		Color color_9 = Color.Empty;
		Color color_10 = Color.Empty;
		switch (eSideBarColorScheme_1)
		{
		case eSideBarColorScheme.Blue:
			color_ = Color.FromArgb(59, 97, 156);
			color = Color.FromArgb(232, 232, 232);
			color2 = Color.White;
			color5 = Color.FromArgb(200, 220, 248);
			color6 = Color.FromArgb(94, 137, 207);
			color3 = Color.FromArgb(221, 236, 254);
			color4 = Color.FromArgb(133, 171, 228);
			color_3 = Color.FromArgb(0, 51, 102);
			color7 = Color.Black;
			color_5 = Color.FromArgb(255, 244, 204);
			color_6 = Color.FromArgb(255, 209, 147);
			color8 = Color.FromArgb(0, 0, 128);
			color_8 = Color.FromArgb(254, 142, 75);
			color_9 = Color.FromArgb(255, 207, 139);
			Color.FromArgb(255, 213, 140);
			Color.FromArgb(255, 173, 85);
			break;
		case eSideBarColorScheme.Silver:
			color_ = Color.FromArgb(87, 86, 113);
			color = Color.FromArgb(232, 232, 232);
			color2 = Color.White;
			color5 = Color.FromArgb(225, 226, 236);
			color6 = Color.FromArgb(126, 125, 157);
			color3 = Color.FromArgb(243, 244, 250);
			color4 = Color.FromArgb(155, 153, 183);
			color_3 = Color.FromArgb(87, 86, 113);
			color7 = Color.Black;
			color_5 = Color.FromArgb(255, 244, 204);
			color_6 = Color.FromArgb(255, 209, 147);
			color8 = Color.FromArgb(87, 86, 113);
			color_8 = Color.FromArgb(254, 142, 75);
			color_9 = Color.FromArgb(255, 207, 139);
			Color.FromArgb(255, 213, 140);
			Color.FromArgb(255, 173, 85);
			break;
		case eSideBarColorScheme.Green:
			color_ = Color.FromArgb(96, 128, 88);
			color = Color.FromArgb(232, 232, 232);
			color2 = Color.White;
			color5 = Color.FromArgb(217, 225, 188);
			color6 = Color.FromArgb(151, 170, 111);
			color3 = Color.FromArgb(244, 247, 222);
			color4 = Color.FromArgb(183, 198, 145);
			color_3 = Color.FromArgb(85, 114, 78);
			color7 = Color.Black;
			color_5 = Color.FromArgb(255, 244, 204);
			color_6 = Color.FromArgb(255, 209, 147);
			color8 = Color.FromArgb(96, 128, 88);
			color_8 = Color.FromArgb(254, 142, 75);
			color_9 = Color.FromArgb(255, 207, 139);
			Color.FromArgb(255, 213, 140);
			Color.FromArgb(255, 173, 85);
			break;
		case eSideBarColorScheme.Orange:
			color_ = Color.FromArgb(137, 105, 28);
			color = Color.FromArgb(232, 232, 232);
			color2 = Color.White;
			color5 = Color.FromArgb(249, 225, 164);
			color6 = Color.FromArgb(227, 185, 82);
			color3 = Color.FromArgb(255, 239, 201);
			color4 = Color.FromArgb(242, 210, 132);
			color_3 = Color.FromArgb(117, 83, 2);
			color7 = Color.Black;
			color_5 = Color.FromArgb(255, 244, 204);
			color_6 = Color.FromArgb(255, 209, 147);
			color8 = Color.FromArgb(137, 105, 28);
			color_8 = Color.FromArgb(254, 142, 75);
			color_9 = Color.FromArgb(255, 207, 139);
			Color.FromArgb(255, 213, 140);
			Color.FromArgb(255, 173, 85);
			break;
		case eSideBarColorScheme.Red:
			color_ = Color.FromArgb(144, 0, 34);
			color = Color.FromArgb(232, 232, 232);
			color2 = Color.White;
			color5 = Color.FromArgb(255, 174, 193);
			color6 = Color.FromArgb(226, 78, 113);
			color3 = Color.FromArgb(252, 219, 227);
			color4 = Color.FromArgb(254, 150, 174);
			color_3 = Color.FromArgb(144, 0, 34);
			color7 = Color.Black;
			color_5 = Color.FromArgb(255, 244, 204);
			color_6 = Color.FromArgb(255, 209, 147);
			color8 = Color.FromArgb(144, 0, 34);
			color_8 = Color.FromArgb(254, 142, 75);
			color_9 = Color.FromArgb(255, 207, 139);
			Color.FromArgb(255, 213, 140);
			Color.FromArgb(255, 173, 85);
			break;
		case eSideBarColorScheme.LightBlue:
			color_ = Color.FromArgb(81, 100, 136);
			color = Color.FromArgb(232, 232, 232);
			color2 = Color.White;
			color5 = Color.FromArgb(226, 235, 253);
			color6 = Color.FromArgb(175, 190, 218);
			color3 = Color.FromArgb(255, 255, 255);
			color4 = Color.FromArgb(210, 224, 252);
			color_3 = Color.FromArgb(69, 84, 115);
			color7 = Color.Black;
			color_5 = Color.FromArgb(255, 244, 204);
			color_6 = Color.FromArgb(255, 209, 147);
			color8 = Color.FromArgb(81, 100, 136);
			color_8 = Color.FromArgb(254, 142, 75);
			color_9 = Color.FromArgb(255, 207, 139);
			Color.FromArgb(255, 213, 140);
			Color.FromArgb(255, 173, 85);
			break;
		case eSideBarColorScheme.Money:
			color_ = Color.FromArgb(44, 72, 112);
			color = Color.FromArgb(91, 91, 91);
			color2 = Color.FromArgb(127, 127, 127);
			color_10 = Color.White;
			color5 = Color.FromArgb(163, 187, 224);
			color6 = Color.FromArgb(99, 131, 177);
			color3 = Color.FromArgb(77, 108, 152);
			color4 = Color.Empty;
			color_2 = Color.FromArgb(55, 85, 128);
			color_3 = Color.White;
			color7 = Color.White;
			color_7 = Color.FromArgb(255, 223, 127);
			color_4 = Color.FromArgb(255, 223, 127);
			color_5 = Color.FromArgb(80, 80, 80);
			color_6 = Color.FromArgb(60, 60, 60);
			color8 = Color.Black;
			color_8 = Color.FromArgb(110, 110, 110);
			color_9 = Color.FromArgb(80, 80, 80);
			Color.FromArgb(60, 60, 60);
			Color.FromArgb(80, 80, 80);
			break;
		}
		Class35 @class = new Class35();
		@class.color_1 = color;
		@class.color_2 = color2;
		@class.color_0 = color_;
		@class.color_4 = color3;
		@class.color_5 = color4;
		@class.color_6 = color5;
		@class.color_7 = color6;
		@class.color_13 = color_3;
		@class.color_10 = color_4;
		if (color_2.IsEmpty)
		{
			@class.color_8 = color4;
			@class.color_9 = color3;
		}
		else
		{
			@class.color_8 = color_2;
		}
		@class.color_11 = color4;
		@class.color_12 = color3;
		@class.color_31 = color8;
		@class.color_32 = color7;
		if (color_7.IsEmpty)
		{
			@class.color_17 = color7;
		}
		else
		{
			@class.color_17 = color_7;
		}
		@class.color_14 = color_5;
		@class.color_15 = color_6;
		@class.color_16 = color8;
		@class.color_23 = color7;
		@class.color_20 = color_8;
		@class.color_21 = color_9;
		@class.color_22 = color8;
		@class.color_19 = color7;
		@class.color_24 = color;
		@class.color_25 = color2;
		@class.color_26 = color8;
		@class.color_27 = color5;
		@class.color_27 = color6;
		@class.color_3 = color_10;
		return @class;
	}

	private static Class35 smethod_1(eSideBarColorScheme eSideBarColorScheme_1)
	{
		Color color = Color.Empty;
		Color color2 = Color.Empty;
		Color color3 = Color.Empty;
		Color color_ = Color.Empty;
		Color color4 = Color.Empty;
		Color color5 = Color.Empty;
		Color color6 = Color.Empty;
		Color color_2 = Color.Empty;
		Color empty = Color.Empty;
		switch (eSideBarColorScheme_1)
		{
		case eSideBarColorScheme.Brick:
			color = Color.FromArgb(66, 0, 0);
			color2 = Color.White;
			color3 = Color.FromArgb(204, 102, 102);
			color_ = Color.FromArgb(227, 220, 198);
			color4 = Color.Black;
			color6 = Color.FromArgb(255, 153, 153);
			color_2 = Color.FromArgb(132, 0, 0);
			color5 = Color.FromArgb(245, 238, 217);
			break;
		case eSideBarColorScheme.Wheat:
			color = Color.FromArgb(132, 130, 0);
			color2 = Color.White;
			color3 = Color.FromArgb(177, 174, 0);
			color_ = Color.FromArgb(239, 240, 120);
			color4 = Color.Black;
			color6 = Color.FromArgb(244, 245, 169);
			color_2 = Color.FromArgb(132, 130, 0);
			color5 = Color.FromArgb(254, 255, 178);
			break;
		case eSideBarColorScheme.Storm:
			color = Color.FromArgb(132, 0, 132);
			color2 = Color.White;
			color3 = Color.FromArgb(162, 78, 162);
			color_ = Color.FromArgb(226, 189, 226);
			color4 = Color.Black;
			color6 = Color.FromArgb(226, 189, 226);
			color_2 = Color.FromArgb(132, 0, 132);
			color5 = Color.FromArgb(244, 223, 244);
			break;
		case eSideBarColorScheme.Spruce:
			color = Color.FromArgb(51, 102, 51);
			color2 = Color.White;
			color3 = Color.FromArgb(90, 150, 99);
			color_ = Color.FromArgb(165, 228, 165);
			color4 = Color.Black;
			color6 = Color.FromArgb(204, 255, 204);
			color_2 = Color.FromArgb(51, 102, 51);
			color5 = Color.FromArgb(204, 231, 204);
			break;
		case eSideBarColorScheme.Slate:
			color = Color.FromArgb(34, 82, 127);
			color2 = Color.White;
			color3 = Color.FromArgb(123, 167, 184);
			color_ = Color.FromArgb(186, 204, 216);
			color4 = Color.Black;
			color6 = Color.FromArgb(129, 191, 232);
			color_2 = Color.FromArgb(34, 82, 127);
			color5 = Color.FromArgb(232, 232, 232);
			break;
		case eSideBarColorScheme.Rose:
			color = Color.FromArgb(102, 45, 63);
			color2 = Color.White;
			color3 = Color.FromArgb(182, 100, 125);
			color_ = Color.FromArgb(206, 174, 181);
			color4 = Color.Black;
			color6 = Color.FromArgb(241, 163, 180);
			color_2 = Color.FromArgb(102, 45, 63);
			color5 = Color.FromArgb(242, 200, 209);
			break;
		case eSideBarColorScheme.Fire:
			color = Color.FromArgb(92, 0, 0);
			color2 = Color.White;
			color3 = Color.FromArgb(175, 32, 32);
			color_ = Color.FromArgb(198, 198, 198);
			color4 = Color.Black;
			color6 = Color.FromArgb(242, 84, 84);
			color_2 = Color.FromArgb(92, 0, 0);
			color5 = Color.FromArgb(255, 142, 142);
			break;
		case eSideBarColorScheme.Pumpkin:
			color = Color.FromArgb(123, 96, 27);
			color2 = Color.White;
			color3 = Color.FromArgb(214, 166, 41);
			color_ = Color.FromArgb(239, 215, 156);
			color4 = Color.Black;
			color6 = Color.FromArgb(239, 191, 97);
			color_2 = Color.FromArgb(123, 96, 27);
			color5 = Color.FromArgb(255, 239, 198);
			break;
		case eSideBarColorScheme.Plum:
			color = Color.FromArgb(74, 65, 99);
			color2 = Color.White;
			color3 = Color.FromArgb(119, 106, 154);
			color_ = Color.FromArgb(173, 154, 148);
			color4 = Color.Black;
			color6 = Color.FromArgb(205, 188, 182);
			color_2 = Color.FromArgb(74, 65, 99);
			color5 = Color.FromArgb(219, 195, 188);
			break;
		case eSideBarColorScheme.Marine:
			color = Color.FromArgb(0, 0, 132);
			color2 = Color.White;
			color3 = Color.FromArgb(83, 168, 159);
			color_ = Color.FromArgb(154, 214, 207);
			color4 = Color.Black;
			color6 = Color.FromArgb(79, 198, 185);
			color_2 = Color.FromArgb(0, 0, 132);
			color5 = Color.FromArgb(188, 231, 226);
			break;
		case eSideBarColorScheme.Sunset:
			color = Color.FromArgb(176, 87, 0);
			color2 = Color.White;
			color3 = Color.FromArgb(219, 155, 0);
			color_ = Color.FromArgb(255, 212, 110);
			color4 = Color.Black;
			color6 = Color.FromArgb(247, 193, 77);
			color_2 = Color.FromArgb(176, 87, 0);
			color5 = Color.FromArgb(253, 226, 162);
			break;
		}
		empty = ControlPaint.Light(color6);
		Class35 @class = new Class35();
		@class.color_1 = color2;
		@class.color_0 = color;
		@class.color_4 = color_;
		@class.color_6 = color3;
		@class.color_8 = color5;
		@class.color_11 = color5;
		@class.color_13 = color4;
		@class.color_31 = color;
		@class.color_32 = color4;
		@class.color_17 = color4;
		@class.color_14 = color6;
		@class.color_16 = color_2;
		@class.color_23 = color4;
		@class.color_20 = empty;
		@class.color_22 = color;
		@class.color_19 = color4;
		@class.color_24 = color2;
		@class.color_26 = color;
		@class.color_27 = color3;
		return @class;
	}

	private static Class35 smethod_2()
	{
		ColorScheme colorScheme = new ColorScheme(eDotNetBarStyle.Office2003);
		Class35 @class = new Class35();
		@class.color_1 = colorScheme.MenuBackground;
		@class.color_2 = ControlPaint.LightLight(colorScheme.MenuBackground);
		@class.color_0 = colorScheme.BarPopupBorder;
		@class.color_4 = colorScheme.MenuSide;
		@class.color_5 = colorScheme.MenuSide2;
		@class.color_6 = colorScheme.BarBackground;
		@class.color_7 = colorScheme.BarBackground2;
		@class.color_13 = colorScheme.ItemText;
		@class.color_10 = colorScheme.ItemHotText;
		@class.color_8 = @class.color_5;
		@class.color_9 = @class.color_4;
		@class.color_11 = @class.color_8;
		@class.color_12 = @class.color_9;
		@class.color_31 = colorScheme.ItemCheckedBorder;
		@class.color_32 = colorScheme.ItemCheckedText;
		@class.color_17 = colorScheme.ItemHotText;
		@class.color_14 = colorScheme.ItemHotBackground;
		@class.color_15 = colorScheme.ItemHotBackground2;
		@class.color_16 = colorScheme.ItemHotBorder;
		@class.color_23 = colorScheme.ItemPressedText;
		@class.color_20 = colorScheme.ItemPressedBackground;
		@class.color_21 = colorScheme.ItemPressedBackground2;
		@class.color_22 = colorScheme.ItemPressedBorder;
		@class.color_19 = colorScheme.ItemText;
		@class.color_24 = colorScheme.MenuBackground;
		@class.color_25 = colorScheme.MenuBackground2;
		@class.color_26 = colorScheme.MenuBorder;
		@class.color_27 = colorScheme.MenuSide;
		@class.color_28 = colorScheme.MenuSide2;
		@class.color_3 = colorScheme.ItemText;
		return @class;
	}
}

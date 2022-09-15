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
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[Designer(typeof(ExplorerBarDesigner))]
[ComVisible(false)]
[ToolboxItem(true)]
public class ExplorerBar : Control, ISupportInitialize, IBarDesignerServices, IAccessibilitySupport, ICustomSerialization, IOwner, IOwnerItemEvents, IOwnerMenuSupport, Interface5, Interface6
{
	public class ExplorerBarAccessibleObject : AccessibleObject
	{
		private ExplorerBar explorerBar_0;

		public override string Name
		{
			get
			{
				return ((Control)explorerBar_0).get_AccessibleName();
			}
			set
			{
				((Control)explorerBar_0).set_AccessibleName(value);
			}
		}

		public override string Description => ((Control)explorerBar_0).get_AccessibleDescription();

		public override AccessibleRole Role => ((Control)explorerBar_0).get_AccessibleRole();

		public override AccessibleObject Parent
		{
			get
			{
				if (((Control)explorerBar_0).get_Parent() != null)
				{
					return ((Control)explorerBar_0).get_Parent().get_AccessibilityObject();
				}
				return null;
			}
		}

		public override Rectangle Bounds
		{
			get
			{
				if (((Control)explorerBar_0).get_Parent() != null)
				{
					return ((Control)explorerBar_0).get_Parent().RectangleToScreen(((Control)explorerBar_0).get_Bounds());
				}
				return ((Control)explorerBar_0).get_DisplayRectangle();
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
				if (((Control)explorerBar_0).get_Focused())
				{
					result = (AccessibleStates)4;
				}
				return result;
			}
		}

		public ExplorerBarAccessibleObject(ExplorerBar owner)
		{
			explorerBar_0 = owner;
		}

		internal void method_0(BaseItem baseItem_0, AccessibleEvents accessibleEvents_0)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			int num = explorerBar_0.Groups.IndexOf(baseItem_0);
			if (num >= 0)
			{
				((Control)explorerBar_0).AccessibilityNotifyClients(accessibleEvents_0, num);
			}
		}

		public override int GetChildCount()
		{
			return explorerBar_0.Groups.Count;
		}

		public override AccessibleObject GetChild(int iIndex)
		{
			return explorerBar_0.Groups[iIndex].AccessibleObject;
		}
	}

	public delegate void ItemRemovedEventHandler(object sender, ItemRemovedEventArgs e);

	private const string string_0 = "Right-click and choose Add New Group or use Groups collection to create new groups.";

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

	private ExplorerBarContainerItem explorerBarContainerItem_0;

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

	private eBorderType eBorderType_0;

	private ExplorerBarGroupItem explorerBarGroupItem_0;

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

	private VScrollBar vscrollBar_0;

	private int int_1 = 4;

	private ItemStyleMapper itemStyleMapper_0;

	private ElementStyle elementStyle_0 = new ElementStyle();

	private eExplorerBarStockStyle eExplorerBarStockStyle_0 = eExplorerBarStockStyle.Custom;

	private bool bool_10 = true;

	private int int_2 = 100;

	private bool bool_11;

	private bool bool_12;

	private bool bool_13;

	private bool bool_14;

	private ColorScheme colorScheme_0;

	private bool bool_15 = true;

	private BarBaseControlDesigner barBaseControlDesigner_0;

	private bool bool_16;

	private Image image_0;

	private Image image_1;

	private Image image_2;

	private Image image_3;

	private Image image_4;

	private Image image_5;

	private BaseItem baseItem_4;

	private bool bool_17;

	private bool bool_18 = true;

	private Class94 class94_0;

	private ArrayList arrayList_0 = new ArrayList();

	internal bool Boolean_0
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
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	public bool SuspendLayoutDisplay
	{
		get
		{
			return bool_16;
		}
		set
		{
			bool_16 = value;
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	[Description("Gets or sets Color Scheme.")]
	[Editor(typeof(ColorSchemeVSEditor), typeof(UITypeEditor))]
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
			bool_14 = true;
			foreach (ExplorerBarGroupItem group in Groups)
			{
				group.method_17();
			}
			if (((Control)this).get_Visible())
			{
				((Control)this).Refresh();
			}
		}
	}

	private bool Boolean_1
	{
		get
		{
			if ((elementStyle_0.BackColor.IsEmpty && elementStyle_0.BackColor2.IsEmpty) || (elementStyle_0.BackColor == Color.Transparent && elementStyle_0.BackColor2 == Color.Transparent))
			{
				return true;
			}
			return false;
		}
	}

	protected bool IsThemed
	{
		get
		{
			if (bool_5 && (explorerBarContainerItem_0.Style == eDotNetBarStyle.OfficeXP || explorerBarContainerItem_0.Style == eDotNetBarStyle.Office2003) && Class109.Boolean_0 && Class58.bool_0)
			{
				return true;
			}
			return false;
		}
	}

	[Description("Specifies whether ExplorerBar is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	public virtual bool ThemeAware
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
			explorerBarContainerItem_0.ThemeAware = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets bar background style.")]
	public ElementStyle BackStyle => elementStyle_0;

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[Obsolete("This property is obsolete. Use BackStyle property instead")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ItemStyleMapper BackgroundStyle => itemStyleMapper_0;

	[DefaultValue(15)]
	[Browsable(true)]
	[Category("Appearance")]
	[Description("Specifies the vertical spacing between the group items.")]
	[DevCoBrowsable(true)]
	public int GroupSpacing
	{
		get
		{
			return explorerBarContainerItem_0.int_4;
		}
		set
		{
			explorerBarContainerItem_0.int_4 = value;
			RecalcLayout();
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

	[Browsable(true)]
	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool AntiAlias
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
				((Control)this).Refresh();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Editor(typeof(ExplorerBarPanelsEditor), typeof(UITypeEditor))]
	[Category("Data")]
	[Description("Returns the collection of Explorer Bar Groups.")]
	public SubItemsCollection Groups => explorerBarContainerItem_0.SubItems;

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

	[DefaultValue(4)]
	[Browsable(true)]
	[Description("Indicates margin in pixels between the explorer bar groups and the edge of the control.")]
	[Category("Layout")]
	public int ContentMargin
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			RecalcLayout();
		}
	}

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

	[Browsable(true)]
	[Category("Behavior")]
	[Description("Specifies whether animation is enabled.")]
	[DefaultValue(true)]
	public bool AnimationEnabled
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

	[DevCoBrowsable(true)]
	[DefaultValue(100)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Indicates maximum animation time in milliseconds, default value is 100.")]
	public int AnimationTime
	{
		get
		{
			return int_2;
		}
		set
		{
			if (int_2 > 0)
			{
				int_2 = value;
			}
		}
	}

	[DefaultValue(false)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Specifies whether native .NET Drag and Drop is used by side-bar to perform drag and drop operations.")]
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
	[Description("Gets or sets whether external ButtonItem object is accepted in drag and drop operation.")]
	[DefaultValue(false)]
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

	[DefaultValue(eExplorerBarStockStyle.Custom)]
	[Category("Style")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Applies the stock style to the object.")]
	public eExplorerBarStockStyle StockStyle
	{
		get
		{
			return eExplorerBarStockStyle_0;
		}
		set
		{
			Class109.smethod_55(this, eExplorerBarStockStyle_0);
			foreach (BaseItem subItem in explorerBarContainerItem_0.SubItems)
			{
				if (subItem is ExplorerBarGroupItem && ((ExplorerBarGroupItem)subItem).StockStyle != eExplorerBarStockStyle.Custom)
				{
					((ExplorerBarGroupItem)subItem).StockStyle = value;
				}
			}
			eExplorerBarStockStyle_0 = value;
			((Control)this).Refresh();
		}
	}

	[Description("Gets or sets whether gray-scale algorithm is used to create automatic gray-scale images.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	[Browsable(true)]
	public bool DisabledImagesGrayScale
	{
		get
		{
			return bool_18;
		}
		set
		{
			bool_18 = value;
		}
	}

	[Description("Specifies custom image to be used as button on ExplorerBarGroup item to expand the group.")]
	[Category("Group Expand Button")]
	[Browsable(true)]
	[DefaultValue(null)]
	public Image GroupButtonExpandNormal
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			((Control)this).Refresh();
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Specifies custom image to be used as button on ExplorerBarGroup item to expand the group.")]
	[Category("Group Expand Button")]
	public Image GroupButtonExpandHot
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

	[Description("Specifies custom image to be used as button on ExplorerBarGroup item to expand the group.")]
	[DefaultValue(null)]
	[Category("Group Expand Button")]
	[Browsable(true)]
	public Image GroupButtonExpandPressed
	{
		get
		{
			return image_2;
		}
		set
		{
			image_2 = value;
		}
	}

	[Category("Group Expand Button")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Description("Specifies custom image to be used as button on ExplorerBarGroup item to collapse the group.")]
	public Image GroupButtonCollapseNormal
	{
		get
		{
			return image_3;
		}
		set
		{
			image_3 = value;
			((Control)this).Refresh();
		}
	}

	[Category("Group Expand Button")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Description("Specifies custom image to be used as button on ExplorerBarGroup item to collapse the group.")]
	public Image GroupButtonCollapseHot
	{
		get
		{
			return image_4;
		}
		set
		{
			image_4 = value;
		}
	}

	[DefaultValue(null)]
	[Category("Group Expand Button")]
	[Browsable(true)]
	[Description("Specifies custom image to be used as button on ExplorerBarGroup item to collapse the group.")]
	public Image GroupButtonCollapsePressed
	{
		get
		{
			return image_5;
		}
		set
		{
			image_5 = value;
		}
	}

	[Description("ImageList for images used on Items. Images specified here will always be used on menu-items and are by default used on all Bars.")]
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
	[Category("Data")]
	[Description("ImageList for images displayed on the Group Item.")]
	public ImageList GroupImages
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

	ImageList IOwner.ImagesMedium
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

	ImageList IOwner.ImagesLarge
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

	[Browsable(true)]
	[Description("Indicates whether Tooltips are shown on Bars and menus.")]
	[DefaultValue(true)]
	[Category("Run-time Behavior")]
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
	[DefaultValue(false)]
	[Category("Run-time Behavior")]
	[Description("Indicates whether item shortcut is displayed in Tooltips.")]
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

	BaseItem IAccessibilitySupport.DoDefaultActionItem
	{
		get
		{
			return baseItem_4;
		}
		set
		{
			baseItem_4 = value;
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

	bool IOwner.DesignMode => ((Component)this).DesignMode;

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
	public ExplorerBarContainerItem ItemsContainer => explorerBarContainerItem_0;

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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
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

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Color ForeColor
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	bool ICustomSerialization.HasSerializeItemHandlers => serializeItemEventHandler_0 != null;

	bool ICustomSerialization.HasDeserializeItemHandlers => serializeItemEventHandler_1 != null;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string Definition
	{
		get
		{
			XmlDocument xmlDocument = new XmlDocument();
			method_19(xmlDocument);
			return xmlDocument.OuterXml;
		}
		set
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(value);
			method_25(xmlDocument);
			((Control)this).Refresh();
		}
	}

	[Browsable(true)]
	[Description("Indicates whether shortucts handled by items are dispatched to the next handler or control.")]
	[Category("Behavior")]
	[DefaultValue(false)]
	public bool DispatchShortcuts
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
		}
	}

	private bool Boolean_2
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

	public ExplorerBar()
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2003);
		explorerBarContainerItem_0 = new ExplorerBarContainerItem();
		explorerBarContainerItem_0.GlobalItem = false;
		explorerBarContainerItem_0.ContainerControl = this;
		explorerBarContainerItem_0.Stretch = false;
		explorerBarContainerItem_0.Displayed = true;
		explorerBarContainerItem_0.method_6(this);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)1, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		((Control)this).set_TabStop(true);
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
		method_4();
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		((Control)this).set_AccessibleRole((AccessibleRole)22);
		itemStyleMapper_0 = new ItemStyleMapper(elementStyle_0);
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
			if (explorerBarContainerItem_0 != null)
			{
				explorerBarContainerItem_0.Dispose();
			}
			explorerBarContainerItem_0 = null;
		}
		((Control)this).Dispose(disposing);
	}

	protected override void OnBindingContextChanged(EventArgs e)
	{
		((Control)this).OnBindingContextChanged(e);
		if (explorerBarContainerItem_0 != null)
		{
			explorerBarContainerItem_0.method_16();
		}
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new ExplorerBarAccessibleObject(this);
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		bool_14 = true;
		ColorScheme colorScheme = ColorScheme;
		elementStyle_0.method_4(colorScheme);
		if (Boolean_1)
		{
			((Control)this).set_BackColor(Color.Transparent);
		}
		else
		{
			((Control)this).set_BackColor(SystemColors.Control);
		}
		if (((Component)this).DesignMode)
		{
			((Control)this).Refresh();
		}
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		explorerBarContainerItem_0.InternalClick(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnClick(e);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		explorerBarContainerItem_0.InternalDoubleClick(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnDoubleClick(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		method_0(e);
		((Control)this).OnKeyDown(e);
	}

	internal void method_0(KeyEventArgs keyEventArgs_0)
	{
		explorerBarContainerItem_0.InternalKeyDown(keyEventArgs_0);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		((Control)this).OnLostFocus(e);
		((IOwner)this).SetFocusItem((BaseItem)null);
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		if (explorerBarContainerItem_0 != null)
		{
			explorerBarContainerItem_0.FocusNextItem();
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
				if (explorerBarContainerItem_0 != null)
				{
					explorerBarContainerItem_0.FocusNextItem();
				}
				if (((IOwner)this).GetFocusItem() != null)
				{
					return true;
				}
			}
			else if ((int)keyData == 38)
			{
				if (explorerBarContainerItem_0 != null)
				{
					explorerBarContainerItem_0.FocusPreviousItem();
				}
				if (((IOwner)this).GetFocusItem() != null)
				{
					return true;
				}
			}
			else if ((int)keyData == 13 && ((IOwner)this).GetFocusItem() != null)
			{
				BaseItem focusItem = ((IOwner)this).GetFocusItem();
				if (focusItem is ExplorerBarGroupItem)
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
		explorerBarContainerItem_0.InternalMouseDown(e);
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		explorerBarContainerItem_0.InternalMouseHover();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (((Control)this).get_Cursor() != Cursors.get_Arrow())
		{
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
		explorerBarContainerItem_0.InternalMouseLeave();
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
			explorerBarContainerItem_0.InternalMouseMove(e);
		}
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		((Control)this).OnMouseWheel(e);
		if (vscrollBar_0 == null)
		{
			return;
		}
		int num = Math.Abs(e.get_Delta()) / 120 * ((ScrollBar)vscrollBar_0).get_SmallChange();
		if (e.get_Delta() < 0)
		{
			int num2 = ((ScrollBar)vscrollBar_0).get_Value() + num;
			if (num2 > ((ScrollBar)vscrollBar_0).get_Maximum())
			{
				num2 = ((ScrollBar)vscrollBar_0).get_Maximum();
			}
			((ScrollBar)vscrollBar_0).set_Value(num2);
		}
		else
		{
			int num3 = ((ScrollBar)vscrollBar_0).get_Value() - num;
			if (num3 < 0)
			{
				num3 = 0;
			}
			((ScrollBar)vscrollBar_0).set_Value(num3);
		}
		method_12(((ScrollBar)vscrollBar_0).get_Value());
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

	private void method_1(int int_3, int int_4, DragEventArgs dragEventArgs_0)
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
		Point pScreen = ((Control)this).PointToScreen(new Point(int_3, int_4));
		foreach (ExplorerBarGroupItem subItem in explorerBarContainerItem_0.SubItems)
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
		explorerBarContainerItem_0.InternalMouseUp(e);
	}

	private void method_2(int int_3, int int_4, DragEventArgs dragEventArgs_0)
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
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
			if (int_3 == -1 && int_4 == -1)
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
		explorerBarContainerItem_0.InternalMouseUp(new MouseEventArgs((MouseButtons)1048576, 0, int_3, int_4, 0));
		if (baseItem != null)
		{
			baseItem.bool_12 = false;
		}
		baseItem_3 = null;
		RecalcLayout();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColorScheme()
	{
		return colorScheme_0.SchemeChanged;
	}

	public void ResetColorScheme()
	{
		colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2003);
	}

	public Graphics CreateGraphics()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = ((Control)this).CreateGraphics();
		if (bool_15)
		{
			val.set_SmoothingMode((SmoothingMode)4);
			if (!SystemInformation.get_IsFontSmoothingEnabled())
			{
				val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
		}
		return val;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		if (explorerBarContainerItem_0 != null && !((Control)this).get_IsDisposed() && !bool_16)
		{
			SolidBrush val = new SolidBrush(Color.White);
			try
			{
				e.get_Graphics().FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			Graphics graphics = e.get_Graphics();
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			TextRenderingHint textRenderingHint = graphics.get_TextRenderingHint();
			if (bool_15)
			{
				e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
				e.get_Graphics().set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			graphics.set_PageUnit((GraphicsUnit)2);
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			ColorScheme colorScheme = ColorScheme;
			if (bool_14)
			{
				elementStyle_0.method_4(colorScheme);
				bool_14 = false;
			}
			Rectangle bounds = clientRectangle;
			bounds.Inflate(1, 1);
			ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(elementStyle_0, graphics, bounds);
			ElementStyleDisplay.Paint(e2);
			if (eBorderType_0 == eBorderType.SingleLine)
			{
				clientRectangle.Inflate(-1, -1);
			}
			else if (eBorderType_0 != 0)
			{
				clientRectangle.Inflate(-2, -2);
			}
			if (Boolean_1)
			{
				((Control)this).OnPaintBackground(e);
			}
			Region clip = e.get_Graphics().get_Clip();
			e.get_Graphics().SetClip(clientRectangle);
			ItemPaintArgs itemPaintArgs = new ItemPaintArgs(this, (Control)(object)this, e.get_Graphics(), colorScheme);
			itemPaintArgs.BaseRenderer_0 = method_3();
			itemPaintArgs.DesignerSelection = bool_17;
			itemPaintArgs.GlassEnabled = !((Component)this).DesignMode && Class51.Boolean_0;
			explorerBarContainerItem_0.Paint(itemPaintArgs);
			if (clip != null)
			{
				e.get_Graphics().SetClip(clip, (CombineMode)0);
			}
			else
			{
				e.get_Graphics().ResetClip();
			}
			if (explorerBarContainerItem_0.SubItems.Count == 0 && ((Component)this).DesignMode)
			{
				string text = "Right-click and choose Add New Group or use Groups collection to create new groups.";
				Rectangle clientRectangle2 = ((Control)this).get_ClientRectangle();
				clientRectangle.Inflate(-2, -2);
				Font val2 = new Font(((Control)this).get_Font().get_FontFamily(), 7f);
				Class55.smethod_1(graphics, text, val2, SystemColors.ControlText, clientRectangle2, eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
				val2.Dispose();
			}
			graphics.set_SmoothingMode(smoothingMode);
			graphics.set_TextRenderingHint(textRenderingHint);
		}
	}

	private BaseRenderer method_3()
	{
		return GlobalManager.Renderer;
	}

	internal void method_4()
	{
		ColorScheme colorScheme = ColorScheme;
		elementStyle_0.BackColorSchemePart = eColorSchemePart.ExplorerBarBackground;
		elementStyle_0.BackColor2SchemePart = eColorSchemePart.ExplorerBarBackground2;
		elementStyle_0.BackColorGradientAngle = colorScheme.ExplorerBarBackgroundGradientAngle;
		elementStyle_0.method_4(colorScheme);
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		method_5();
		ColorScheme.Refresh(null, bSystemColorEvent: true);
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
		if (class81_0 != null)
		{
			class81_0.Dispose();
			class81_0 = new Class81((Control)(object)this);
		}
		if (class64_0 != null)
		{
			class64_0.Dispose();
			class64_0 = new Class64((Control)(object)this);
		}
		if (class82_0 != null)
		{
			class82_0.Dispose();
			class82_0 = new Class82((Control)(object)this);
		}
		method_7();
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
		if (class82_0 != null)
		{
			class82_0.Dispose();
			class82_0 = null;
		}
	}

	private void method_7()
	{
		foreach (BaseItem subItem in explorerBarContainerItem_0.SubItems)
		{
			if (subItem is ExplorerBarGroupItem explorerBarGroupItem && explorerBarGroupItem.StockStyle == eExplorerBarStockStyle.SystemColors)
			{
				explorerBarGroupItem.StockStyle = eExplorerBarStockStyle.SystemColors;
			}
		}
	}

	private eExplorerBarStockStyle method_8(eExplorerBarStockStyle eExplorerBarStockStyle_1)
	{
		eExplorerBarStockStyle result = eExplorerBarStockStyle.Custom;
		switch (eExplorerBarStockStyle_1)
		{
		case eExplorerBarStockStyle.Blue:
			result = eExplorerBarStockStyle.BlueSpecial;
			break;
		case eExplorerBarStockStyle.OliveGreen:
			result = eExplorerBarStockStyle.OliveGreenSpecial;
			break;
		case eExplorerBarStockStyle.Silver:
			result = eExplorerBarStockStyle.SilverSpecial;
			break;
		case eExplorerBarStockStyle.BlueSpecial:
		case eExplorerBarStockStyle.OliveGreenSpecial:
		case eExplorerBarStockStyle.SilverSpecial:
			result = eExplorerBarStockStyle_1;
			break;
		}
		return result;
	}

	private bool method_9(eExplorerBarStockStyle eExplorerBarStockStyle_1)
	{
		if (eExplorerBarStockStyle_1 != eExplorerBarStockStyle.BlueSpecial && eExplorerBarStockStyle_1 != eExplorerBarStockStyle.OliveGreenSpecial && eExplorerBarStockStyle_1 != eExplorerBarStockStyle.SilverSpecial)
		{
			return false;
		}
		return true;
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_6();
		method_16();
		((Control)this).OnHandleDestroyed(e);
		if (bool_12)
		{
			Class107.smethod_1(this);
			bool_12 = false;
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (((Control)this).get_Visible())
		{
			method_7();
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		if (!bool_16 && Class109.smethod_11((Control)(object)this))
		{
			if ((int)((Control)this).get_RightToLeft() == 1)
			{
				explorerBarContainerItem_0.IsRightToLeft = (int)((Control)this).get_RightToLeft() == 1;
			}
			if (eBorderType_0 == eBorderType.None)
			{
				explorerBarContainerItem_0.LeftInternal = int_1;
				explorerBarContainerItem_0.TopInternal = int_1;
				explorerBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - int_1 * 2;
				explorerBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - int_1;
			}
			else
			{
				explorerBarContainerItem_0.LeftInternal = int_1;
				explorerBarContainerItem_0.TopInternal = int_1;
				explorerBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - 4 - int_1 * 2;
				explorerBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - int_1 - 2;
			}
			explorerBarContainerItem_0.RecalcSize();
			if (explorerBarContainerItem_0.HeightInternal > ((Control)this).get_ClientRectangle().Height || (explorerBarContainerItem_0.HeightInternal <= ((Control)this).get_ClientRectangle().Height && vscrollBar_0 != null))
			{
				method_10();
			}
		}
	}

	internal void method_10()
	{
		if (explorerBarContainerItem_0.HeightInternal > ((Control)this).get_ClientRectangle().Height)
		{
			method_11();
			if (eBorderType_0 == eBorderType.None)
			{
				explorerBarContainerItem_0.LeftInternal = int_1;
				explorerBarContainerItem_0.TopInternal = int_1;
				explorerBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - ((Control)vscrollBar_0).get_Width() - int_1 * 2;
				explorerBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - int_1;
			}
			else
			{
				explorerBarContainerItem_0.LeftInternal = int_1;
				explorerBarContainerItem_0.TopInternal = int_1;
				explorerBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - 4 - ((Control)vscrollBar_0).get_Width() - int_1 * 2;
				explorerBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - int_1 - 2;
			}
			explorerBarContainerItem_0.RecalcSize();
			method_11();
			explorerBarContainerItem_0.TopInternal = -((ScrollBar)vscrollBar_0).get_Value() + int_1;
		}
		else if (vscrollBar_0 != null)
		{
			((Control)this).get_Controls().Remove((Control)(object)vscrollBar_0);
			((Component)(object)vscrollBar_0).Dispose();
			vscrollBar_0 = null;
			if (eBorderType_0 == eBorderType.None)
			{
				explorerBarContainerItem_0.LeftInternal = int_1;
				explorerBarContainerItem_0.TopInternal = int_1;
				explorerBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - int_1 * 2;
				explorerBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - int_1;
			}
			else
			{
				explorerBarContainerItem_0.LeftInternal = int_1;
				explorerBarContainerItem_0.TopInternal = int_1;
				explorerBarContainerItem_0.WidthInternal = ((Control)this).get_Width() - 4 - int_1 * 2;
				explorerBarContainerItem_0.HeightInternal = ((Control)this).get_Height() - int_1 - 2;
			}
			explorerBarContainerItem_0.RecalcSize();
		}
	}

	private void method_11()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		if (vscrollBar_0 == null)
		{
			vscrollBar_0 = new VScrollBar();
			((Control)vscrollBar_0).set_Width(SystemInformation.get_VerticalScrollBarWidth());
			((Control)vscrollBar_0).set_Dock((DockStyle)4);
			((Control)vscrollBar_0).set_Visible(true);
			((Control)this).get_Controls().Add((Control)(object)vscrollBar_0);
			((ScrollBar)vscrollBar_0).add_Scroll(new ScrollEventHandler(vscrollBar_0_Scroll));
			((Component)(object)vscrollBar_0).Site = null;
		}
		((ScrollBar)vscrollBar_0).set_LargeChange(((Control)this).get_Height() / 2);
		((ScrollBar)vscrollBar_0).set_SmallChange(((ScrollBar)vscrollBar_0).get_LargeChange() / 5);
		int num = explorerBarContainerItem_0.HeightInternal - ((Control)this).get_Height() + ((ScrollBar)vscrollBar_0).get_LargeChange() + ((ScrollBar)vscrollBar_0).get_SmallChange();
		if (((ScrollBar)vscrollBar_0).get_SmallChange() > 0 && Math.Ceiling((float)num / (float)((ScrollBar)vscrollBar_0).get_SmallChange()) > (double)(num / ((ScrollBar)vscrollBar_0).get_SmallChange()))
		{
			num = (int)Math.Ceiling((float)num / (float)((ScrollBar)vscrollBar_0).get_SmallChange()) * ((ScrollBar)vscrollBar_0).get_SmallChange();
		}
		if (((ScrollBar)vscrollBar_0).get_Maximum() != num)
		{
			((ScrollBar)vscrollBar_0).set_Maximum(num);
		}
	}

	private void vscrollBar_0_Scroll(object sender, ScrollEventArgs e)
	{
		method_12(e.get_NewValue());
	}

	private void method_12(int int_3)
	{
		explorerBarContainerItem_0.TopInternal = -int_3 + int_1;
		((Control)this).Invalidate(((Control)this).get_ClientRectangle(), false);
	}

	public void RecalcLayout()
	{
		if (!bool_16)
		{
			RecalcSize();
			((Control)this).Refresh();
		}
	}

	internal void method_13()
	{
		explorerBarContainerItem_0.SetDesignMode(b: true);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		if (((Component)this).DesignMode)
		{
			method_13();
		}
		if (!bool_12 && !((Component)this).DesignMode)
		{
			Class107.smethod_0(this);
			bool_12 = true;
		}
		RecalcLayout();
	}

	protected override void OnParentChanged(EventArgs e)
	{
		((Control)this).OnParentChanged(e);
		if (explorerBarGroupItem_0 != null)
		{
			if (explorerBarContainerItem_0.SubItems.Contains(explorerBarGroupItem_0))
			{
				explorerBarGroupItem_0.Expanded = true;
			}
			explorerBarGroupItem_0 = null;
		}
		if (Images != null || ((IOwner)this).ImagesLarge != null || ((IOwner)this).ImagesMedium != null)
		{
			foreach (ExplorerBarGroupItem subItem in explorerBarContainerItem_0.SubItems)
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
		RecalcLayout();
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
		Class109.smethod_46(explorerBarContainerItem_0, ItemName, arrayList);
		return arrayList;
	}

	public ArrayList GetItems(string ItemName, Type itemType)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_48(explorerBarContainerItem_0, ItemName, arrayList, itemType);
		return arrayList;
	}

	public ArrayList GetItems(string ItemName, Type itemType, bool useGlobalName)
	{
		ArrayList arrayList = new ArrayList(15);
		Class109.smethod_49(explorerBarContainerItem_0, ItemName, arrayList, itemType, useGlobalName);
		return arrayList;
	}

	public BaseItem GetItem(string ItemName)
	{
		BaseItem baseItem = Class109.smethod_44(explorerBarContainerItem_0, ItemName);
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
		if (((Component)this).DesignMode && Groups.Contains(objFocusItem))
		{
			foreach (BaseItem group in Groups)
			{
				BaseItem.CollapseSubItems(group);
			}
		}
		baseItem_2 = objFocusItem;
		if (baseItem_2 != null)
		{
			baseItem_2.OnGotFocus();
		}
		if (!((Component)this).DesignMode)
		{
			EnsureVisible(baseItem_2);
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

	public void EnsureVisible(BaseItem item)
	{
		if (item == null || item.ContainerControl != this)
		{
			return;
		}
		if (item.Parent is ExplorerBarGroupItem)
		{
			if (!item.Parent.Visible)
			{
				return;
			}
			if (!item.Parent.Expanded)
			{
				item.Parent.Expanded = true;
			}
		}
		if (vscrollBar_0 == null || !((Control)vscrollBar_0).get_Visible())
		{
			return;
		}
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		Rectangle rect = item.DisplayRectangle;
		if (item is ExplorerBarGroupItem)
		{
			rect = ((ExplorerBarGroupItem)item).PanelRect;
			rect.Y = item.TopInternal;
		}
		if (clientRectangle.Contains(rect))
		{
			return;
		}
		int num = 0;
		if (rect.Top < 0)
		{
			num = ((ScrollBar)vscrollBar_0).get_Value() + rect.Top - int_1;
			if (num < 0)
			{
				num = 0;
			}
		}
		else
		{
			num = Math.Abs(explorerBarContainerItem_0.TopInternal) + rect.Bottom - clientRectangle.Height + int_1;
		}
		((ScrollBar)vscrollBar_0).set_Value(num);
		method_12(((ScrollBar)vscrollBar_0).get_Value());
	}

	void ISupportInitialize.BeginInit()
	{
	}

	void ISupportInitialize.EndInit()
	{
		if (Images != null)
		{
			foreach (BaseItem subItem in explorerBarContainerItem_0.SubItems)
			{
				method_14(subItem as ImageItem);
			}
		}
		RecalcLayout();
	}

	private void method_14(ImageItem imageItem_0)
	{
		if (imageItem_0 == null)
		{
			return;
		}
		imageItem_0.OnImageChanged();
		foreach (BaseItem subItem in imageItem_0.SubItems)
		{
			method_14(subItem as ImageItem);
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

	public BaseItem HitTest(int clientX, int clientY)
	{
		BaseItem result = null;
		foreach (BaseItem subItem in explorerBarContainerItem_0.SubItems)
		{
			if (!subItem.DisplayRectangle.Contains(clientX, clientY))
			{
				continue;
			}
			result = subItem;
			foreach (BaseItem subItem2 in subItem.SubItems)
			{
				if (subItem2.DisplayRectangle.Contains(clientX, clientY))
				{
					result = subItem2;
					break;
				}
			}
		}
		return result;
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 1131 && baseItem_4 != null)
		{
			baseItem_4.vmethod_0();
			baseItem_4 = null;
		}
		((Control)this).WndProc(ref m);
	}

	private void method_15()
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
			((Control)val).add_Resize((EventHandler)method_17);
			val.add_Deactivate((EventHandler)method_18);
			DotNetBarManager.RegisterParentMsgHandler(this, val);
		}
	}

	private void method_16()
	{
		if (bool_13)
		{
			bool_13 = false;
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				DotNetBarManager.UnRegisterParentMsgHandler(this, val);
				((Control)val).remove_Resize((EventHandler)method_17);
				val.remove_Deactivate((EventHandler)method_18);
			}
		}
	}

	private void method_17(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	private void method_18(object sender, EventArgs e)
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
			if (!bool_12)
			{
				Class107.smethod_0(this);
				bool_12 = true;
			}
		}
		else if (class94_0 == null)
		{
			class94_0 = new Class94(this);
		}
		if (!bool_13)
		{
			method_15();
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
			method_16();
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

	internal void method_19(XmlDocument xmlDocument_0)
	{
		XmlElement xmlElement = xmlDocument_0.CreateElement("ExplorerBar");
		xmlDocument_0.AppendChild(xmlElement);
		method_20(xmlElement);
	}

	internal void method_20(XmlElement xmlElement_0)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected I4, but got Unknown
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		itemSerializationContext.Serializer = this;
		itemSerializationContext.HasDeserializeItemHandlers = ((ICustomSerialization)this).HasDeserializeItemHandlers;
		itemSerializationContext.HasSerializeItemHandlers = ((ICustomSerialization)this).HasSerializeItemHandlers;
		xmlElement_0.SetAttribute("name", ((Control)this).get_Name());
		if (((Control)this).get_Font() != null && (((Control)this).get_Font().get_Name() != SystemInformation.get_MenuFont().get_Name() || ((Control)this).get_Font().get_Size() != SystemInformation.get_MenuFont().get_Size() || ((Control)this).get_Font().get_Style() != SystemInformation.get_MenuFont().get_Style()))
		{
			xmlElement_0.SetAttribute("fontname", ((Control)this).get_Font().get_Name());
			xmlElement_0.SetAttribute("fontemsize", XmlConvert.ToString(((Control)this).get_Font().get_Size()));
			xmlElement_0.SetAttribute("fontstyle", XmlConvert.ToString((int)((Control)this).get_Font().get_Style()));
		}
		xmlElement_0.SetAttribute("width", XmlConvert.ToString(((Control)this).get_Width()));
		xmlElement_0.SetAttribute("height", XmlConvert.ToString(((Control)this).get_Height()));
		if (!bool_10)
		{
			xmlElement_0.SetAttribute("animate", XmlConvert.ToString(bool_10));
		}
		XmlElement xmlElement = xmlElement_0.OwnerDocument.CreateElement("items");
		xmlElement_0.AppendChild(xmlElement);
		foreach (BaseItem subItem in explorerBarContainerItem_0.SubItems)
		{
			if (subItem.ShouldSerialize)
			{
				XmlElement xmlElement2 = xmlElement_0.OwnerDocument.CreateElement("item");
				xmlElement.AppendChild(xmlElement2);
				itemSerializationContext.ItemXmlElement = xmlElement2;
				subItem.Serialize(itemSerializationContext);
			}
		}
		XmlElement xmlElement3 = xmlElement_0.OwnerDocument.CreateElement("backstyle");
		xmlElement_0.AppendChild(xmlElement3);
		method_21(elementStyle_0, xmlElement3);
	}

	private void method_21(ElementStyle elementStyle_1, XmlElement xmlElement_0)
	{
		ElementSerializer.Serialize(elementStyle_1, xmlElement_0);
	}

	private void method_22(ElementStyle elementStyle_1, XmlElement xmlElement_0)
	{
		ElementSerializer.Deserialize(elementStyle_1, xmlElement_0);
	}

	private bool method_23(eShortcut eShortcut_0)
	{
		bool result = Class109.smethod_5(eShortcut_0, hashtable_0);
		if (!bool_11)
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
		if (!Boolean_2)
		{
			return false;
		}
		if (intptr_1.ToInt32() < 112 && (int)Control.get_ModifierKeys() == 0 && (intptr_2.ToInt32() & 0x1000000000L) == 0L && intptr_1.ToInt32() != 46 && intptr_1.ToInt32() != 45)
		{
			return false;
		}
		int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
		return method_23((eShortcut)eShortcut_);
	}

	bool Interface5.imethod_3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
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
		if (!((Component)this).DesignMode && ((int)Control.get_ModifierKeys() != 0 || (intptr_1.ToInt32() >= 112 && intptr_1.ToInt32() <= 123)))
		{
			int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
			if (method_23((eShortcut)eShortcut_))
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

	internal void method_24(XmlElement xmlElement_0)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		itemSerializationContext.Serializer = this;
		itemSerializationContext.HasDeserializeItemHandlers = ((ICustomSerialization)this).HasDeserializeItemHandlers;
		itemSerializationContext.HasSerializeItemHandlers = ((ICustomSerialization)this).HasSerializeItemHandlers;
		hashtable_0.Clear();
		((Control)this).set_Name(xmlElement_0.GetAttribute("name"));
		((Control)this).set_Size(new Size(XmlConvert.ToInt32(xmlElement_0.GetAttribute("width")), XmlConvert.ToInt32(xmlElement_0.GetAttribute("height"))));
		if (xmlElement_0.HasAttribute("animate"))
		{
			bool_10 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("animate"));
		}
		else
		{
			bool_10 = true;
		}
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
			switch (childNode.Name)
			{
			case "backstyle":
				method_22(elementStyle_0, childNode);
				bool_14 = true;
				break;
			case "items":
				foreach (XmlElement childNode2 in childNode.ChildNodes)
				{
					BaseItem baseItem = Class109.smethod_18(childNode2);
					explorerBarContainerItem_0.SubItems.Add(baseItem);
					itemSerializationContext.ItemXmlElement = childNode2;
					baseItem.Deserialize(itemSerializationContext);
				}
				break;
			}
		}
	}

	public void LoadDefinition(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(FileName);
		method_25(xmlDocument);
		((Control)this).Refresh();
	}

	internal void method_25(XmlDocument xmlDocument_0)
	{
		if (xmlDocument_0.FirstChild!.Name != "ExplorerBar")
		{
			throw new InvalidOperationException("XML Format not recognized");
		}
		explorerBarContainerItem_0.SubItems.Clear();
		method_24(xmlDocument_0.FirstChild as XmlElement);
		((IOwner)this)?.AddShortcutsFromItem((BaseItem)explorerBarContainerItem_0);
		((IOwner)this).InvokeDefinitionLoaded((object)this, new EventArgs());
		RecalcSize();
	}

	public void SaveDefinition(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		method_19(xmlDocument);
		xmlDocument.Save(FileName);
	}

	void IOwner.InvokeDefinitionLoaded(object sender, EventArgs e)
	{
		if (eventHandler_17 != null)
		{
			eventHandler_17(sender, e);
		}
	}
}

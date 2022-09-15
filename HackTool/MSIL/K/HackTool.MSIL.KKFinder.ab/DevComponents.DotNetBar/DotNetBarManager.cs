using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxBitmap(typeof(DotNetBarManager), "DotNetBarManager.ico")]
[ToolboxItem(true)]
[DefaultEvent("ItemClick")]
[Designer(typeof(DotNetBarManagerDesigner))]
[ComVisible(false)]
public class DotNetBarManager : Component, IExtenderProvider, ICustomSerialization, IOwner, IOwnerAutoHideSupport, IOwnerBarSupport, IOwnerItemEvents, IOwnerLocalize, IOwnerMenuSupport, Interface5
{
	public delegate void AutoHideDisplayEventHandler(object sender, AutoHideDisplayEventArgs e);

	public delegate void BarClosingEventHandler(object sender, BarClosingEventArgs e);

	public delegate void CustomizeContextMenuEventHandler(object sender, CustomizeContextMenuEventArgs e);

	public delegate void DockTabChangeEventHandler(object sender, DockTabChangeEventArgs e);

	public delegate void ItemRemovedEventHandler(object sender, ItemRemovedEventArgs e);

	public delegate void LocalizeStringEventHandler(object sender, LocalizeEventArgs e);

	public delegate void PopupOpenEventHandler(object sender, PopupOpenEventArgs e);

	private CustomizeContextMenuEventHandler customizeContextMenuEventHandler_0;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private PopupOpenEventHandler popupOpenEventHandler_0;

	private EventHandler eventHandler_3;

	private EventHandler eventHandler_4;

	private EventHandler eventHandler_5;

	private EventHandler eventHandler_6;

	private EventHandler eventHandler_7;

	private EventHandler eventHandler_8;

	private EventHandler eventHandler_9;

	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private EventHandler eventHandler_10;

	private EventHandler eventHandler_11;

	private MouseEventHandler mouseEventHandler_2;

	private EventHandler eventHandler_12;

	private EventHandler eventHandler_13;

	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	private EventHandler eventHandler_16;

	private EventHandler eventHandler_17;

	private ItemRemovedEventHandler itemRemovedEventHandler_0;

	private EventHandler eventHandler_18;

	private EventHandler eventHandler_19;

	private EventHandler eventHandler_20;

	private EventHandler eventHandler_21;

	private EventHandler eventHandler_22;

	private ControlContainerItem.ControlContainerSerializationEventHandler controlContainerSerializationEventHandler_0;

	private ControlContainerItem.ControlContainerSerializationEventHandler controlContainerSerializationEventHandler_1;

	private DockTabChangeEventHandler dockTabChangeEventHandler_0;

	private BarClosingEventHandler barClosingEventHandler_0;

	private AutoHideDisplayEventHandler autoHideDisplayEventHandler_0;

	private EventHandler eventHandler_23;

	private EventHandler eventHandler_24;

	private LocalizeStringEventHandler localizeStringEventHandler_0;

	private OptionGroupChangingEventHandler optionGroupChangingEventHandler_0;

	private EventHandler eventHandler_25;

	private EndUserCustomizeEventHandler endUserCustomizeEventHandler_0;

	private DockTabClosingEventHandler dockTabClosingEventHandler_0;

	private SerializeItemEventHandler serializeItemEventHandler_0;

	private SerializeItemEventHandler serializeItemEventHandler_1;

	private EventHandler eventHandler_26;

	private EventHandler eventHandler_27;

	private EventHandler eventHandler_28;

	private static Hashtable hashtable_0 = new Hashtable(10);

	private License license_0;

	private DockSite dockSite_0;

	private DockSite dockSite_1;

	private DockSite dockSite_2;

	private DockSite dockSite_3;

	private DockSite dockSite_4;

	private DockSite dockSite_5;

	private DockSite dockSite_6;

	private DockSite dockSite_7;

	private DockSite dockSite_8;

	private Bars bars_0;

	private ArrayList arrayList_0;

	private Items items_0;

	private Hashtable hashtable_1;

	private bool bool_0;

	private frmCustomize frmCustomize_0;

	private ArrayList arrayList_1;

	private BaseItem baseItem_0;

	private BaseItem baseItem_1;

	private ArrayList arrayList_2;

	private Class33 class33_0;

	private Form form_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private ImageList imageList_0;

	private ImageList imageList_1;

	private ImageList imageList_2;

	private DotNetBarStreamer dotNetBarStreamer_0;

	private Form form_1;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private Timer timer_0;

	private BaseItem baseItem_2;

	private bool bool_7 = true;

	private PopupItem popupItem_0;

	private ContextMenusCollection contextMenusCollection_0;

	private eMenuDropShadow eMenuDropShadow_0;

	private bool bool_8 = true;

	private bool bool_9;

	private Class94 class94_0;

	private bool bool_10;

	private bool bool_11;

	private bool bool_12 = true;

	private bool bool_13 = true;

	private bool bool_14;

	private ePopupAnimation ePopupAnimation_0 = ePopupAnimation.SystemDefault;

	private Hashtable hashtable_2 = new Hashtable();

	private Hashtable hashtable_3 = new Hashtable();

	private bool bool_15 = true;

	private bool bool_16;

	private bool bool_17;

	private bool bool_18;

	private bool bool_19;

	private bool bool_20 = true;

	private bool bool_21;

	private ShortcutsCollection shortcutsCollection_0;

	private AutoHidePanel autoHidePanel_0;

	private AutoHidePanel autoHidePanel_1;

	private AutoHidePanel autoHidePanel_2;

	private AutoHidePanel autoHidePanel_3;

	private bool bool_22;

	private string string_0 = "";

	private bool bool_23;

	private bool bool_24;

	private bool bool_25;

	private eDotNetBarStyle eDotNetBarStyle_0 = eDotNetBarStyle.Office2003;

	private bool bool_26;

	private Bar bar_0;

	private Control control_0;

	private bool bool_27 = true;

	internal bool bool_28;

	private bool bool_29;

	private bool bool_30 = true;

	private bool bool_31;

	private bool bool_32;

	private ColorScheme colorScheme_0;

	private bool bool_33;

	private bool bool_34 = true;

	private bool bool_35;

	private bool bool_36;

	private Size size_0 = new Size(48, 48);

	private ContextMenuBar contextMenuBar_0;

	private int int_0;

	private int int_1 = 96;

	private bool bool_37 = true;

	private DockingHint dockingHint_0;

	private DockingHint dockingHint_1;

	private DockingHint dockingHint_2;

	private DockingHint dockingHint_3;

	private DockingHint dockingHint_4;

	private bool bool_38;

	private bool bool_39;

	private bool bool_40 = true;

	private bool bool_41;

	private bool bool_42;

	[DefaultValue(null)]
	[Category("Data")]
	[Description("Indicates Context menu bar associated with the DotNetBarManager which is used as part of Global Items feature.")]
	public ContextMenuBar GlobalContextMenuBar
	{
		get
		{
			return contextMenuBar_0;
		}
		set
		{
			if (contextMenuBar_0 != null)
			{
				contextMenuBar_0.GlobalParentComponent = null;
			}
			contextMenuBar_0 = value;
			if (contextMenuBar_0 != null)
			{
				contextMenuBar_0.GlobalParentComponent = this;
			}
		}
	}

	[Browsable(true)]
	[Category("Data")]
	[Description("Gets or sets the form DotNetBarManager is attached to.")]
	public Form ParentForm
	{
		get
		{
			return form_1;
		}
		set
		{
			if (form_1 != null)
			{
				ReleaseParentFormHooks();
			}
			form_1 = value;
			OnParentChanged();
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public Control ParentUserControl
	{
		get
		{
			return control_0;
		}
		set
		{
			control_0 = value;
			SetupParentUserControl();
		}
	}

	private bool IsPopupProviderOnly
	{
		get
		{
			if (dockSite_0 == null && dockSite_1 == null && dockSite_2 == null)
			{
				return dockSite_3 == null;
			}
			return false;
		}
	}

	ArrayList IOwnerBarSupport.WereVisible => arrayList_0;

	[Browsable(false)]
	public bool IsDisposed => bool_4;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool DisposeGCCollect
	{
		get
		{
			return bool_37;
		}
		set
		{
			bool_37 = value;
		}
	}

	[Category("Docking")]
	[Browsable(true)]
	[Description("Indicates minimum client size that docking windows will try to maintain for the client area (not occupied by dock windows).")]
	public Size MinimumClientSize
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
		}
	}

	[Description("Indicates whether DotNetBar provides docking hints for easy docking of bars.")]
	[Obsolete]
	[Browsable(false)]
	[DefaultValue(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Category("Docking")]
	public bool DockingHintsEnabled
	{
		get
		{
			return bool_27;
		}
		set
		{
			bool_27 = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates whether user can control how first bar is docked when using docking hints.")]
	[Category("Docking")]
	[DefaultValue(true)]
	public bool EnableFullSizeDock
	{
		get
		{
			return bool_30;
		}
		set
		{
			bool_30 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Docking")]
	[Description("")]
	public bool ApplyDocumentBarStyle
	{
		get
		{
			return bool_34;
		}
		set
		{
			bool_34 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public Bars Bars => bars_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(false)]
	public string DefinitionName
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			bool_23 = false;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	public bool IsDefinitionLoaded => bool_23;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(false)]
	public DotNetBarStreamer BarStream
	{
		get
		{
			if (DefinitionName != "")
			{
				return null;
			}
			if (dotNetBarStreamer_0 != null)
			{
				return dotNetBarStreamer_0;
			}
			return new DotNetBarStreamer(this);
		}
		set
		{
			dotNetBarStreamer_0 = null;
			if (value != null && value.Data != null)
			{
				dotNetBarStreamer_0 = value;
				bool_23 = false;
				BarStreamLoad();
			}
		}
	}

	[Browsable(false)]
	public Items Items => items_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[Obsolete("ContextMenus on DotNetBarManager is removed. Use ContextMenuBar control instead.")]
	public ContextMenusCollection ContextMenus => contextMenusCollection_0;

	private bool IsDocumentDockingEnabled => dockSite_4 != null;

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether shortucts handled by items are dispatched to the next handler or control.")]
	[Category("Behavior")]
	public bool DispatchShortcuts
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

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[TypeConverter(typeof(ShortcutsConverter))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Editor(typeof(ShortcutsDesigner), typeof(UITypeEditor))]
	[Description("Indicates list of shortcut keys that are automatically dispatched to the control that has focus even if they are handled and used by one of the items.")]
	[Category("Behavior")]
	public ShortcutsCollection AutoDispatchShortcuts
	{
		get
		{
			return shortcutsCollection_0;
		}
		set
		{
			shortcutsCollection_0 = value;
			shortcutsCollection_0.BaseItem_0 = null;
		}
	}

	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Behavior")]
	[Description("Indicates whether Reset buttons is shown that allows end-user to reset the toolbar state.")]
	public bool ShowResetButton
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

	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Data")]
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
				((Component)(object)imageList_0).Disposed -= ImageListDisposed;
			}
			imageList_0 = value;
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed += ImageListDisposed;
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
				((Component)(object)imageList_1).Disposed -= ImageListDisposed;
			}
			imageList_1 = value;
			if (imageList_1 != null)
			{
				((Component)(object)imageList_1).Disposed += ImageListDisposed;
			}
		}
	}

	[Category("Data")]
	[Description("ImageList for large-sized images used on Items.")]
	[Browsable(true)]
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
				((Component)(object)imageList_2).Disposed -= ImageListDisposed;
			}
			imageList_2 = value;
			if (imageList_2 != null)
			{
				((Component)(object)imageList_2).Disposed += ImageListDisposed;
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	public bool SuspendLayout
	{
		get
		{
			return bool_22;
		}
		set
		{
			if (bool_22 == value)
			{
				return;
			}
			bool_22 = value;
			if (!bool_22)
			{
				if (dockSite_0 != null && dockSite_0.NeedsLayout)
				{
					dockSite_0.RecalcLayout();
				}
				if (dockSite_1 != null && dockSite_1.NeedsLayout)
				{
					dockSite_1.RecalcLayout();
				}
				if (dockSite_2 != null && dockSite_2.NeedsLayout)
				{
					dockSite_2.RecalcLayout();
				}
				if (dockSite_3 != null && dockSite_3.NeedsLayout)
				{
					dockSite_3.RecalcLayout();
				}
				if (dockSite_4 != null && dockSite_4.NeedsLayout)
				{
					dockSite_4.RecalcLayout();
				}
				if (dockSite_5 != null && dockSite_5.NeedsLayout)
				{
					dockSite_5.RecalcLayout();
				}
				if (dockSite_6 != null && dockSite_6.NeedsLayout)
				{
					dockSite_6.RecalcLayout();
				}
				if (dockSite_7 != null && dockSite_7.NeedsLayout)
				{
					dockSite_7.RecalcLayout();
				}
				if (dockSite_8 != null && dockSite_8.NeedsLayout)
				{
					dockSite_8.RecalcLayout();
				}
			}
		}
	}

	[DefaultValue(eMenuDropShadow.SystemDefault)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Specifes whether drop shadow is displayed for Menus and pop-up Bars. OfficeXP Style only.")]
	public eMenuDropShadow MenuDropShadow
	{
		get
		{
			return eMenuDropShadow_0;
		}
		set
		{
			eMenuDropShadow_0 = value;
		}
	}

	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Specifes whether to use Alpha-Blending shadows for pop-up items if supported by target OS. Disabling Alpha-Blended shadows can improve performance.")]
	public bool AlphaBlendShadow
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(true)]
	[Description("Gets or sets whether gray-scale algorithm is used to create automatic gray-scale images.")]
	public bool DisabledImagesGrayScale
	{
		get
		{
			return bool_40;
		}
		set
		{
			bool_40 = value;
		}
	}

	[Browsable(true)]
	[Description("Gets or sets whether hooks are used for internal DotNetBar system functionality. Using hooks is recommended only if DotNetBar is used in hybrid environments like Visual Studio designers or IE.")]
	[DefaultValue(false)]
	[Category("Behavior")]
	public bool UseHook
	{
		get
		{
			return bool_9;
		}
		set
		{
			if (bool_9 == value)
			{
				return;
			}
			bool_9 = value;
			if (form_1 == null)
			{
				return;
			}
			if (bool_9)
			{
				if (bool_0)
				{
					Class107.smethod_1(this);
				}
				bool_0 = false;
				if (class94_0 == null)
				{
					class94_0 = new Class94(this);
				}
				return;
			}
			if (class94_0 != null)
			{
				class94_0.Dispose();
				class94_0 = null;
			}
			if (!base.DesignMode)
			{
				if (!bool_0)
				{
					Class107.smethod_0(this);
				}
				bool_0 = true;
			}
		}
	}

	bool IOwnerMenuSupport.ShowPopupShadow
	{
		get
		{
			if (eMenuDropShadow_0 == eMenuDropShadow.Show)
			{
				return true;
			}
			if (eMenuDropShadow_0 == eMenuDropShadow.Hide)
			{
				return false;
			}
			if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor < 1) || Environment.OSVersion.Version.Major < 5)
			{
				return true;
			}
			return Class92.Boolean_1;
		}
	}

	bool ICustomSerialization.HasSerializeItemHandlers => serializeItemEventHandler_0 != null;

	bool ICustomSerialization.HasDeserializeItemHandlers => serializeItemEventHandler_1 != null;

	internal bool IsLoadingDefinition => bool_31;

	[Browsable(false)]
	[DefaultValue(false)]
	public bool IncludeDockDocumentsInDefinition
	{
		get
		{
			return bool_36;
		}
		set
		{
			bool_36 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public string Definition
	{
		get
		{
			XmlDocument xmlDocument = new XmlDocument();
			SaveDefinition(xmlDocument);
			return xmlDocument.OuterXml;
		}
		set
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(value);
			LoadDefinition(xmlDocument);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string LayoutDefinition
	{
		get
		{
			XmlDocument xmlDocument = new XmlDocument();
			SaveLayout(xmlDocument);
			return xmlDocument.OuterXml;
		}
		set
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(value);
			LoadLayout(xmlDocument);
		}
	}

	[Browsable(false)]
	public bool IsLoadingLayout => bool_32;

	internal bool IsCustomizing => bool_42;

	[Category("Run-time Behavior")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Specifies that custom customize dialog will be used. Use EnterCustomize event to show your custom dialog box.")]
	public bool UseCustomCustomizeDialog
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

	BaseItem IOwner.DragItem
	{
		get
		{
			if (frmCustomize_0 != null)
			{
				return frmCustomize_0.DragItem;
			}
			return null;
		}
	}

	bool IOwner.DragInProgress
	{
		get
		{
			if (frmCustomize_0 != null)
			{
				return frmCustomize_0.DragInProgress;
			}
			return false;
		}
	}

	internal Form CustomizeForm => (Form)(object)frmCustomize_0;

	[DefaultValue(null)]
	[Browsable(false)]
	public DockSite ToolbarTopDockSite
	{
		get
		{
			return dockSite_5;
		}
		set
		{
			dockSite_5 = value;
			if (dockSite_5 != null)
			{
				((Control)dockSite_5).set_Dock((DockStyle)1);
				dockSite_5.method_23(this);
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	public DockSite ToolbarBottomDockSite
	{
		get
		{
			return dockSite_6;
		}
		set
		{
			dockSite_6 = value;
			if (dockSite_6 != null)
			{
				((Control)dockSite_6).set_Dock((DockStyle)2);
				dockSite_6.method_23(this);
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	public DockSite ToolbarLeftDockSite
	{
		get
		{
			return dockSite_7;
		}
		set
		{
			dockSite_7 = value;
			if (dockSite_7 != null)
			{
				((Control)dockSite_7).set_Dock((DockStyle)3);
				dockSite_7.method_23(this);
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public DockSite ToolbarRightDockSite
	{
		get
		{
			return dockSite_8;
		}
		set
		{
			dockSite_8 = value;
			if (dockSite_8 != null)
			{
				((Control)dockSite_8).set_Dock((DockStyle)4);
				dockSite_8.method_23(this);
			}
		}
	}

	[Browsable(false)]
	public DockSite TopDockSite
	{
		get
		{
			return dockSite_0;
		}
		set
		{
			dockSite_0 = value;
			if (dockSite_0 == null)
			{
				return;
			}
			((Control)dockSite_0).set_Dock((DockStyle)1);
			dockSite_0.method_23(this);
			if (((Control)dockSite_0).get_Parent() == null)
			{
				((Control)dockSite_0).add_ParentChanged((EventHandler)DockSiteParentChanged);
				return;
			}
			if (((Control)dockSite_0).get_Parent() is UserControl)
			{
				SetupParentUserControl();
			}
			BarStreamLoad();
			ProcessDelayedCommands();
		}
	}

	[Browsable(false)]
	public DockSite BottomDockSite
	{
		get
		{
			return dockSite_1;
		}
		set
		{
			dockSite_1 = value;
			if (dockSite_1 != null)
			{
				((Control)dockSite_1).set_Dock((DockStyle)2);
				dockSite_1.method_23(this);
				if (((Control)dockSite_1).get_Parent() == null)
				{
					((Control)dockSite_1).add_ParentChanged((EventHandler)DockSiteParentChanged);
					return;
				}
				BarStreamLoad();
				ProcessDelayedCommands();
			}
		}
	}

	[Browsable(false)]
	public DockSite LeftDockSite
	{
		get
		{
			return dockSite_2;
		}
		set
		{
			dockSite_2 = value;
			if (dockSite_2 != null)
			{
				((Control)dockSite_2).set_Dock((DockStyle)3);
				dockSite_2.method_23(this);
				if (((Control)dockSite_2).get_Parent() == null)
				{
					((Control)dockSite_2).add_ParentChanged((EventHandler)DockSiteParentChanged);
					return;
				}
				BarStreamLoad();
				ProcessDelayedCommands();
			}
		}
	}

	[Browsable(false)]
	public DockSite RightDockSite
	{
		get
		{
			return dockSite_3;
		}
		set
		{
			dockSite_3 = value;
			if (dockSite_3 != null)
			{
				((Control)dockSite_3).set_Dock((DockStyle)4);
				dockSite_3.method_23(this);
				if (((Control)dockSite_3).get_Parent() == null)
				{
					((Control)dockSite_3).add_ParentChanged((EventHandler)DockSiteParentChanged);
					return;
				}
				BarStreamLoad();
				ProcessDelayedCommands();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	public DockSite FillDockSite
	{
		get
		{
			return dockSite_4;
		}
		set
		{
			dockSite_4 = value;
			if (dockSite_4 != null)
			{
				dockSite_4.method_23(this);
			}
		}
	}

	AutoHidePanel IOwnerAutoHideSupport.LeftAutoHidePanel
	{
		get
		{
			if (autoHidePanel_0 == null)
			{
				if (((Control)dockSite_2).get_Parent() == null)
				{
					return null;
				}
				autoHidePanel_0 = new AutoHidePanel();
				_003F val = autoHidePanel_0;
				object obj = SystemInformation.get_MenuFont().Clone();
				((Control)val).set_Font((Font)((obj is Font) ? obj : null));
				autoHidePanel_0.method_0(this);
				((Control)autoHidePanel_0).set_Dock((DockStyle)3);
				((Control)autoHidePanel_0).set_Width(0);
				((Control)autoHidePanel_0).set_Visible(false);
				((Control)dockSite_2).get_Parent().get_Controls().Add((Control)(object)autoHidePanel_0);
				if (dockSite_2.Boolean_3)
				{
					((Control)dockSite_2).get_Parent().get_Controls().SetChildIndex((Control)(object)autoHidePanel_0, ((Control)dockSite_2).get_Parent().get_Controls().GetChildIndex((Control)(object)dockSite_2));
				}
				else
				{
					((Control)dockSite_2).get_Parent().get_Controls().SetChildIndex((Control)(object)autoHidePanel_0, ((Control)dockSite_2).get_Parent().get_Controls().GetChildIndex((Control)(object)dockSite_2) + 1);
				}
			}
			return autoHidePanel_0;
		}
		set
		{
			autoHidePanel_0 = value;
		}
	}

	bool IOwnerAutoHideSupport.HasLeftAutoHidePanel => autoHidePanel_0 != null;

	AutoHidePanel IOwnerAutoHideSupport.RightAutoHidePanel
	{
		get
		{
			if (autoHidePanel_1 == null)
			{
				if (((Control)dockSite_3).get_Parent() == null)
				{
					return null;
				}
				autoHidePanel_1 = new AutoHidePanel();
				autoHidePanel_1.method_0(this);
				((Control)autoHidePanel_1).set_Dock((DockStyle)4);
				((Control)autoHidePanel_1).set_Width(0);
				((Control)autoHidePanel_1).set_Visible(false);
				((Control)dockSite_3).get_Parent().get_Controls().Add((Control)(object)autoHidePanel_1);
				if (dockSite_3.Boolean_3)
				{
					((Control)dockSite_3).get_Parent().get_Controls().SetChildIndex((Control)(object)autoHidePanel_1, ((Control)dockSite_3).get_Parent().get_Controls().GetChildIndex((Control)(object)dockSite_3));
				}
				else
				{
					((Control)dockSite_3).get_Parent().get_Controls().SetChildIndex((Control)(object)autoHidePanel_1, ((Control)dockSite_3).get_Parent().get_Controls().GetChildIndex((Control)(object)dockSite_3) + 1);
				}
			}
			return autoHidePanel_1;
		}
		set
		{
			autoHidePanel_1 = value;
		}
	}

	bool IOwnerAutoHideSupport.HasRightAutoHidePanel => autoHidePanel_1 != null;

	AutoHidePanel IOwnerAutoHideSupport.TopAutoHidePanel
	{
		get
		{
			if (autoHidePanel_2 == null)
			{
				if (((Control)dockSite_0).get_Parent() == null)
				{
					return null;
				}
				autoHidePanel_2 = new AutoHidePanel();
				_003F val = autoHidePanel_2;
				object obj = SystemInformation.get_MenuFont().Clone();
				((Control)val).set_Font((Font)((obj is Font) ? obj : null));
				autoHidePanel_2.method_0(this);
				((Control)autoHidePanel_2).set_Dock((DockStyle)1);
				((Control)autoHidePanel_2).set_Width(0);
				((Control)autoHidePanel_2).set_Visible(false);
				((Control)dockSite_0).get_Parent().get_Controls().Add((Control)(object)autoHidePanel_2);
				if (dockSite_0.Boolean_3)
				{
					((Control)dockSite_0).get_Parent().get_Controls().SetChildIndex((Control)(object)autoHidePanel_2, ((Control)dockSite_0).get_Parent().get_Controls().GetChildIndex((Control)(object)dockSite_0));
				}
				else
				{
					((Control)dockSite_0).get_Parent().get_Controls().SetChildIndex((Control)(object)autoHidePanel_2, ((Control)dockSite_0).get_Parent().get_Controls().GetChildIndex((Control)(object)dockSite_0) + 1);
				}
			}
			return autoHidePanel_2;
		}
		set
		{
			autoHidePanel_2 = value;
		}
	}

	bool IOwnerAutoHideSupport.HasTopAutoHidePanel => autoHidePanel_2 != null;

	AutoHidePanel IOwnerAutoHideSupport.BottomAutoHidePanel
	{
		get
		{
			if (autoHidePanel_3 == null)
			{
				if (((Control)dockSite_1).get_Parent() == null)
				{
					return null;
				}
				autoHidePanel_3 = new AutoHidePanel();
				_003F val = autoHidePanel_3;
				object obj = SystemInformation.get_MenuFont().Clone();
				((Control)val).set_Font((Font)((obj is Font) ? obj : null));
				autoHidePanel_3.method_0(this);
				((Control)autoHidePanel_3).set_Dock((DockStyle)2);
				((Control)autoHidePanel_3).set_Width(0);
				((Control)autoHidePanel_3).set_Visible(false);
				((Control)dockSite_1).get_Parent().get_Controls().Add((Control)(object)autoHidePanel_3);
				if (dockSite_1.Boolean_3)
				{
					((Control)dockSite_1).get_Parent().get_Controls().SetChildIndex((Control)(object)autoHidePanel_3, ((Control)dockSite_1).get_Parent().get_Controls().GetChildIndex((Control)(object)dockSite_1));
				}
				else
				{
					((Control)dockSite_1).get_Parent().get_Controls().SetChildIndex((Control)(object)autoHidePanel_3, ((Control)dockSite_1).get_Parent().get_Controls().GetChildIndex((Control)(object)dockSite_1) + 1);
				}
			}
			return autoHidePanel_3;
		}
		set
		{
			autoHidePanel_3 = value;
		}
	}

	bool IOwnerAutoHideSupport.HasBottomAutoHidePanel => autoHidePanel_3 != null;

	[Category("Appearance")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Specifies whether new bars created are drawn using Themes when running on OS that supports themes like Windows XP.")]
	[DevCoBrowsable(false)]
	public virtual bool ThemeAware
	{
		get
		{
			return bool_25;
		}
		set
		{
			foreach (Bar item in bars_0)
			{
				item.ThemeAware = value;
			}
			bool_25 = value;
			if (base.DesignMode)
			{
				if (dockSite_0 != null)
				{
					dockSite_0.RecalcLayout();
				}
				if (dockSite_1 != null)
				{
					dockSite_1.RecalcLayout();
				}
				if (dockSite_2 != null)
				{
					dockSite_2.RecalcLayout();
				}
				if (dockSite_3 != null)
				{
					dockSite_3.RecalcLayout();
				}
			}
			else
			{
				if (dockSite_0 != null && ((ArrangedElementCollection)((Control)dockSite_0).get_Controls()).get_Count() > 0)
				{
					dockSite_0.NeedsLayout = true;
				}
				if (dockSite_1 != null && ((ArrangedElementCollection)((Control)dockSite_1).get_Controls()).get_Count() > 0)
				{
					dockSite_1.NeedsLayout = true;
				}
				if (dockSite_2 != null && ((ArrangedElementCollection)((Control)dockSite_2).get_Controls()).get_Count() > 0)
				{
					dockSite_2.NeedsLayout = true;
				}
				if (dockSite_3 != null && ((ArrangedElementCollection)((Control)dockSite_3).get_Controls()).get_Count() > 0)
				{
					dockSite_3.NeedsLayout = true;
				}
			}
		}
	}

	[Description("Specifies the default visual style of the Bars.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Color Scheme")]
	public eDotNetBarStyle Style
	{
		get
		{
			return eDotNetBarStyle_0;
		}
		set
		{
			foreach (Bar item in bars_0)
			{
				TypeDescriptor.GetProperties(item)["Style"]!.SetValue(item, value);
			}
			foreach (BaseItem item2 in contextMenusCollection_0)
			{
				item2.Style = value;
			}
			foreach (DictionaryEntry item3 in items_0)
			{
				((BaseItem)item3.Value).Style = value;
			}
			if (eDotNetBarStyle_0 != value)
			{
				colorScheme_0.method_0(value);
			}
			eDotNetBarStyle_0 = value;
		}
	}

	[Description("Indicates Color Scheme for all bars.")]
	[DevCoBrowsable(true)]
	[Editor(typeof(ColorSchemeVSEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Color Scheme")]
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
		}
	}

	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	[Category("Color Scheme")]
	[Description("Indicates whether ColorScheme object on DotNetBarManager is used as a default ColorScheme for all bars managed by DotNetBarManager.")]
	[Browsable(true)]
	public bool UseGlobalColorScheme
	{
		get
		{
			return bool_33;
		}
		set
		{
			bool_33 = value;
		}
	}

	[Category("Run-time Behavior")]
	[Browsable(true)]
	[Description("Indicates whether the Personalized menu setting is ignored and full menus are always shown.")]
	[DefaultValue(false)]
	public bool AlwaysShowFullMenus
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

	[Description("Indicates whether accelerator letters for menu or toolbar commands are underlined regardless of current Windows settings.")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Run-time Behavior")]
	public bool AlwaysDisplayKeyAccelerators
	{
		get
		{
			return bool_29;
		}
		set
		{
			bool_29 = value;
			Bar menuBar = GetMenuBar();
			if (menuBar != null)
			{
				((Control)menuBar).Refresh();
			}
		}
	}

	[Browsable(false)]
	public bool IsThemeActive
	{
		get
		{
			if (!Class109.Boolean_0)
			{
				return false;
			}
			return Class58.bool_0;
		}
	}

	[Category("Run-time Behavior")]
	[Description("Indicates whether the CustomizeItem (allows toolbar customization) is added for new Bars end users are creating.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool AllowUserBarCustomize
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

	[Browsable(true)]
	[Description("Indicates whether DotNetBar ignores the F10 key which when pressed sets the focus to menu bar.")]
	[DefaultValue(false)]
	[Category("Run-time Behavior")]
	public bool IgnoreF10Key
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

	[Category("Run-time Behavior")]
	[Description("Indicates whether the items that are not most recenly used are shown after mouse hovers over the expand button.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool ShowFullMenusOnHover
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

	[Browsable(true)]
	[Category("Run-time Behavior")]
	[Description("Indicates whether Tooltips are shown on Bars and menus.")]
	[DefaultValue(true)]
	public bool ShowToolTips
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

	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Run-time Behavior")]
	[Description("Indicates whether item shortcut is displayed in Tooltips.")]
	public bool ShowShortcutKeysInToolTips
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
	[Description("Specifies the pop-up animation style.")]
	[Category("Run-time Behavior")]
	[DefaultValue(ePopupAnimation.SystemDefault)]
	public ePopupAnimation PopupAnimation
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

	[Browsable(true)]
	[Description("Specifies whether the MDI system buttons are displayed in menu bar when MDI Child window is maximized.")]
	[DefaultValue(true)]
	[Category("Run-time Behavior")]
	public bool MdiSystemItemVisible
	{
		get
		{
			return bool_20;
		}
		set
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Invalid comparison between Unknown and I4
			bool_20 = value;
			if (base.DesignMode)
			{
				return;
			}
			Bar menuBar = GetMenuBar();
			if (menuBar == null)
			{
				return;
			}
			if (bool_20)
			{
				if (form_1 != null && form_1.get_IsMdiContainer() && form_1.get_ActiveMdiChild() != null && (int)form_1.get_ActiveMdiChild().get_WindowState() == 2)
				{
					menuBar.method_90(form_1.get_ActiveMdiChild(), bool_67: true);
					bool_1 = true;
				}
			}
			else
			{
				menuBar.method_89(bool_67: true);
			}
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether MDI Child form System Menu is hidden. Default value is false.")]
	[Browsable(true)]
	[Category("Run-time Behavior")]
	public bool HideMdiSystemMenu
	{
		get
		{
			return bool_35;
		}
		set
		{
			bool_35 = value;
		}
	}

	bool IOwner.DesignMode => base.DesignMode;

	Form IOwner.ActiveMdiChild => form_0;

	internal Bar FocusedBar
	{
		get
		{
			return bar_0;
		}
		set
		{
			bar_0 = value;
		}
	}

	bool Interface5.Boolean_0
	{
		get
		{
			if (form_1 != null && bool_5)
			{
				return form_1.get_Modal();
			}
			return false;
		}
	}

	[Description("Gets or sets whether customize context menu is shown on all bars or dock sites.")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Run-time Behavior")]
	public bool ShowCustomizeContextMenu
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool PersonalizedAllVisible
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

	[Description("Occurs just before customize popup menu is shown.")]
	[Category("Item")]
	public event CustomizeContextMenuEventHandler CustomizeContextMenu
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customizeContextMenuEventHandler_0 = (CustomizeContextMenuEventHandler)Delegate.Combine(customizeContextMenuEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customizeContextMenuEventHandler_0 = (CustomizeContextMenuEventHandler)Delegate.Remove(customizeContextMenuEventHandler_0, value);
		}
	}

	[Description("Occurs when Item is clicked.")]
	[Category("Item")]
	public event EventHandler ItemClick
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

	[Description("Occurs when popup of type container is loading.")]
	[Category("Item")]
	public event EventHandler PopupContainerLoad
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

	[Category("Item")]
	[Description("Occurs when popup of type container is unloading.")]
	public event EventHandler PopupContainerUnload
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

	[Category("Item")]
	[Description("Occurs when popup item is about to open.")]
	public event PopupOpenEventHandler PopupOpen
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			popupOpenEventHandler_0 = (PopupOpenEventHandler)Delegate.Combine(popupOpenEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			popupOpenEventHandler_0 = (PopupOpenEventHandler)Delegate.Remove(popupOpenEventHandler_0, value);
		}
	}

	[Category("Item")]
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
	[Category("Item")]
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

	[Category("Item")]
	[Description("Occurs when Item Expanded property has changed.")]
	public event EventHandler ExpandedChange
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

	[Category("Bar")]
	[Description("Occurs when Bar is docked.")]
	public event EventHandler BarDock
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

	[Category("Bar")]
	[Description("Occurs when Bar is Undocked.")]
	public event EventHandler BarUndock
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

	[Category("Bar")]
	[Description("Occurs before dock tab is displayed.")]
	public event EventHandler BeforeDockTabDisplay
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_8 = (EventHandler)Delegate.Combine(eventHandler_8, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_8 = (EventHandler)Delegate.Remove(eventHandler_8, value);
		}
	}

	[Description("Occurs when Bar auto-hide state has changed.")]
	[Category("Bar")]
	public event EventHandler AutoHideChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_9 = (EventHandler)Delegate.Combine(eventHandler_9, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_9 = (EventHandler)Delegate.Remove(eventHandler_9, value);
		}
	}

	[Category("Item")]
	[Description("Occurs when mouse button is pressed.")]
	public event MouseEventHandler MouseDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
	}

	[Category("Item")]
	[Description("Occurs when mouse button is released.")]
	public event MouseEventHandler MouseUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
	}

	[Category("Item")]
	[Description("Occurs when mouse enters the item.")]
	public event EventHandler MouseEnter
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_10 = (EventHandler)Delegate.Combine(eventHandler_10, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_10 = (EventHandler)Delegate.Remove(eventHandler_10, value);
		}
	}

	[Description("Occurs when mouse leaves the item.")]
	[Category("Item")]
	public event EventHandler MouseLeave
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_11 = (EventHandler)Delegate.Combine(eventHandler_11, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_11 = (EventHandler)Delegate.Remove(eventHandler_11, value);
		}
	}

	[Category("Item")]
	[Description("Occurs when mouse moves over the item.")]
	public event MouseEventHandler MouseMove
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
	}

	[Category("Item")]
	[Description("Occurs when mouse remains still inside an item for an amount of time.")]
	public event EventHandler MouseHover
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_12 = (EventHandler)Delegate.Combine(eventHandler_12, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_12 = (EventHandler)Delegate.Remove(eventHandler_12, value);
		}
	}

	[Description("Occurs when item loses input focus.")]
	[Category("Item")]
	public event EventHandler LostFocus
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

	[Category("Item")]
	[Description("Occurs when item receives input focus.")]
	public event EventHandler GotFocus
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

	[Category("Item")]
	[Description("Occurs when user changes the item position, removes the item, adds new item or creates new bar.")]
	public event EventHandler UserCustomize
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

	[Category("General")]
	[Description("Occurs after DotNetBar definition is loaded.")]
	public event EventHandler DefinitionLoaded
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

	[Category("General")]
	[Description("Occurs when users wants to reset the DotNetBar to default state.")]
	public event EventHandler ResetDefinition
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

	[Category("Item")]
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

	[Category("Item")]
	[Description("Occurs after an Item has been added to the SubItemsCollection.")]
	public event EventHandler ItemAdded
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

	[Category("Item")]
	[Description("Occurs when ControlContainerControl is created and contained control is needed.")]
	public event EventHandler ContainerLoadControl
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

	[Description("Occurs when Text property of an Item has changed.")]
	[Category("Item")]
	public event EventHandler ItemTextChanged
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

	[Category("General")]
	[Description("Occurs when Customize Dialog is about to be shown.")]
	public event EventHandler EnterCustomize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_21 = (EventHandler)Delegate.Combine(eventHandler_21, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_21 = (EventHandler)Delegate.Remove(eventHandler_21, value);
		}
	}

	[Description("Occurs when Customize Dialog is closed.")]
	[Category("General")]
	public event EventHandler ExitCustomize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_22 = (EventHandler)Delegate.Combine(eventHandler_22, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_22 = (EventHandler)Delegate.Remove(eventHandler_22, value);
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

	[Category("Bar")]
	[Description("Occurs when current Dock tab has changed.")]
	public event DockTabChangeEventHandler DockTabChange
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dockTabChangeEventHandler_0 = (DockTabChangeEventHandler)Delegate.Combine(dockTabChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dockTabChangeEventHandler_0 = (DockTabChangeEventHandler)Delegate.Remove(dockTabChangeEventHandler_0, value);
		}
	}

	[Category("Bar")]
	[Description("Occurs when Bar is about to be closed as a result of user clicking the Close button on the bar.")]
	public event BarClosingEventHandler BarClosing
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			barClosingEventHandler_0 = (BarClosingEventHandler)Delegate.Combine(barClosingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			barClosingEventHandler_0 = (BarClosingEventHandler)Delegate.Remove(barClosingEventHandler_0, value);
		}
	}

	[Category("Bar")]
	[Description("Occurs when Bar in auto-hide state is about to be displayed.")]
	public event AutoHideDisplayEventHandler AutoHideDisplay
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			autoHideDisplayEventHandler_0 = (AutoHideDisplayEventHandler)Delegate.Combine(autoHideDisplayEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			autoHideDisplayEventHandler_0 = (AutoHideDisplayEventHandler)Delegate.Remove(autoHideDisplayEventHandler_0, value);
		}
	}

	[Description("Occurs when user start to drag item when customize dialog is open.")]
	public event EventHandler CustomizeStartItemDrag
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_23 = (EventHandler)Delegate.Combine(eventHandler_23, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_23 = (EventHandler)Delegate.Remove(eventHandler_23, value);
		}
	}

	[Description("Occurs when users Tears-off the Tab from the Bar and new Bar is created as result of that action.")]
	public event EventHandler BarTearOff
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_24 = (EventHandler)Delegate.Combine(eventHandler_24, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_24 = (EventHandler)Delegate.Remove(eventHandler_24, value);
		}
	}

	public event LocalizeStringEventHandler LocalizeString
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			localizeStringEventHandler_0 = (LocalizeStringEventHandler)Delegate.Combine(localizeStringEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			localizeStringEventHandler_0 = (LocalizeStringEventHandler)Delegate.Remove(localizeStringEventHandler_0, value);
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
			eventHandler_25 = (EventHandler)Delegate.Combine(eventHandler_25, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_25 = (EventHandler)Delegate.Remove(eventHandler_25, value);
		}
	}

	public event EndUserCustomizeEventHandler EndUserCustomize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			endUserCustomizeEventHandler_0 = (EndUserCustomizeEventHandler)Delegate.Combine(endUserCustomizeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			endUserCustomizeEventHandler_0 = (EndUserCustomizeEventHandler)Delegate.Remove(endUserCustomizeEventHandler_0, value);
		}
	}

	[Description("Occurs on dockable bars when end-user attempts to close the individual DockContainerItem objects using system buttons on dock tab.")]
	public event DockTabClosingEventHandler DockTabClosing
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dockTabClosingEventHandler_0 = (DockTabClosingEventHandler)Delegate.Combine(dockTabClosingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dockTabClosingEventHandler_0 = (DockTabClosingEventHandler)Delegate.Remove(dockTabClosingEventHandler_0, value);
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

	public event EventHandler TextBoxItemTextChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_26 = (EventHandler)Delegate.Combine(eventHandler_26, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_26 = (EventHandler)Delegate.Remove(eventHandler_26, value);
		}
	}

	[Description("Occurs when color is choosen from drop-down color picker or from Custom Colors dialog box.")]
	public event EventHandler ColorPickerSelectedColorChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_27 = (EventHandler)Delegate.Combine(eventHandler_27, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_27 = (EventHandler)Delegate.Remove(eventHandler_27, value);
		}
	}

	public event EventHandler ButtonCheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_28 = (EventHandler)Delegate.Combine(eventHandler_28, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_28 = (EventHandler)Delegate.Remove(eventHandler_28, value);
		}
	}

	public DotNetBarManager()
		: this(null)
	{
	}

	public DotNetBarManager(IContainer cont)
	{
		RemindForm remindForm = new RemindForm();
		remindForm.method_0();
		((Component)(object)remindForm).Dispose();
		InitializeComponent(cont);
	}

	private void InitializeComponent(IContainer cont)
	{
		dockSite_0 = null;
		dockSite_1 = null;
		dockSite_2 = null;
		dockSite_3 = null;
		bars_0 = new Bars(this);
		arrayList_0 = new ArrayList();
		items_0 = new Items(this);
		hashtable_1 = new Hashtable();
		bool_0 = false;
		frmCustomize_0 = null;
		arrayList_1 = null;
		baseItem_0 = null;
		baseItem_1 = null;
		arrayList_2 = new ArrayList();
		class33_0 = null;
		form_0 = null;
		bool_2 = false;
		imageList_0 = null;
		form_1 = null;
		contextMenusCollection_0 = new ContextMenusCollection(this);
		cont?.Add(this);
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		shortcutsCollection_0 = new ShortcutsCollection(null);
		colorScheme_0 = new ColorScheme(eDotNetBarStyle_0);
	}

	internal static bool IsManagerRegistered(IOwner manager, Form parentForm)
	{
		if (hashtable_0.Contains(parentForm))
		{
			Class275 @class = hashtable_0[parentForm] as Class275;
			return @class.method_2(manager);
		}
		return false;
	}

	internal static void RegisterParentMsgHandler(IOwner manager, Form parentForm)
	{
		if (hashtable_0.Contains(parentForm))
		{
			Class275 @class = hashtable_0[parentForm] as Class275;
			if (!@class.method_2(manager))
			{
				@class.method_0(manager);
			}
		}
		else
		{
			Class275 class2 = new Class275(manager.DesignMode);
			((NativeWindow)class2).AssignHandle(((Control)parentForm).get_Handle());
			class2.method_0(manager);
			hashtable_0[parentForm] = class2;
		}
	}

	internal static void UnRegisterParentMsgHandler(IOwner manager, Form parentForm)
	{
		if (parentForm == null)
		{
			return;
		}
		if (hashtable_0.Contains(parentForm))
		{
			Class275 @class = hashtable_0[parentForm] as Class275;
			if (@class.method_2(manager))
			{
				@class.method_1(manager);
				if (@class.Int32_0 == 0 && @class.Int32_1 == 0)
				{
					((NativeWindow)@class).ReleaseHandle();
					hashtable_0.Remove(parentForm);
				}
			}
			return;
		}
		foreach (DictionaryEntry item in hashtable_0)
		{
			Class275 class2 = item.Value as Class275;
			if (class2.method_2(manager))
			{
				class2.method_1(manager);
				if (class2.Int32_0 == 0 && class2.Int32_1 == 0)
				{
					((NativeWindow)class2).ReleaseHandle();
					hashtable_0.Remove(parentForm);
				}
				break;
			}
		}
	}

	internal static void RegisterOwnerParentMsgHandler(IOwner owner, Form parentForm)
	{
		if (hashtable_0.Contains(parentForm))
		{
			Class275 @class = hashtable_0[parentForm] as Class275;
			if (!@class.method_5(owner))
			{
				@class.method_3(owner);
			}
		}
		else
		{
			Class275 class2 = new Class275(designmode: true);
			((NativeWindow)class2).AssignHandle(((Control)parentForm).get_Handle());
			class2.method_3(owner);
			hashtable_0[parentForm] = class2;
		}
	}

	internal static void UnRegisterOwnerParentMsgHandler(IOwner owner, Form parentForm)
	{
		if (parentForm == null)
		{
			return;
		}
		if (hashtable_0.Contains(parentForm))
		{
			Class275 @class = hashtable_0[parentForm] as Class275;
			if (@class.method_5(owner))
			{
				@class.method_4(owner);
				if (@class.Int32_0 == 0 && @class.Int32_1 == 0)
				{
					((NativeWindow)@class).ReleaseHandle();
					hashtable_0.Remove(parentForm);
				}
			}
			return;
		}
		foreach (DictionaryEntry item in hashtable_0)
		{
			Class275 class2 = item.Value as Class275;
			if (class2.method_5(owner))
			{
				class2.method_4(owner);
				if (class2.Int32_0 == 0 && class2.Int32_1 == 0)
				{
					((NativeWindow)class2).ReleaseHandle();
					hashtable_0.Remove(parentForm);
				}
				break;
			}
		}
	}

	internal static void RelayApplicationActivate(bool bActivate)
	{
		Class275[] array = new Class275[hashtable_0.Count];
		hashtable_0.Values.CopyTo(array, 0);
		Class275[] array2 = array;
		foreach (Class275 @class in array2)
		{
			if (bActivate)
			{
				@class.method_6();
			}
			else
			{
				@class.method_7();
			}
		}
	}

	bool IExtenderProvider.CanExtend(object target)
	{
		if (target is Control)
		{
			return true;
		}
		return false;
	}

	void IOwnerItemEvents.InvokeItemClick(BaseItem objItem)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(objItem, new EventArgs());
		}
	}

	internal void InvokeDockTabClosing(Bar bar, DockTabClosingEventArgs e)
	{
		if (dockTabClosingEventHandler_0 != null)
		{
			dockTabClosingEventHandler_0(this, e);
		}
	}

	internal void InvokeTextBoxItemTextChanged(TextBoxItem ti)
	{
		if (eventHandler_26 != null)
		{
			eventHandler_26(ti, new EventArgs());
		}
	}

	internal void InvokeColorPickerSelectedColorChanged(ColorPickerDropDown d)
	{
		if (eventHandler_27 != null)
		{
			eventHandler_27(d, new EventArgs());
		}
	}

	[Browsable(false)]
	public Bar GetItemBar(BaseItem item)
	{
		while (item.Parent != null)
		{
			item = item.Parent;
		}
		return item.ContainerControl as Bar;
	}

	internal bool GetDesignMode()
	{
		return base.DesignMode;
	}

	private void OnParentChanged()
	{
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		if (form_1 == null)
		{
			return;
		}
		if (!base.DesignMode)
		{
			UnRegisterParentMsgHandler(this, form_1);
		}
		if (((Control)form_1).get_IsHandleCreated() && !base.DesignMode)
		{
			if (form_1.get_IsMdiChild() && form_1.get_MdiParent() != null)
			{
				RegisterParentMsgHandler(this, form_1.get_MdiParent());
			}
			else
			{
				RegisterParentMsgHandler(this, form_1);
			}
		}
		((Control)form_1).add_HandleDestroyed((EventHandler)ParentHandleDestroyed);
		((Control)form_1).add_HandleCreated((EventHandler)ParentHandleCreated);
		if (!base.DesignMode)
		{
			form_1.add_Activated((EventHandler)ParentActivated);
			form_1.add_Deactivate((EventHandler)ParentDeactivate);
			form_1.add_Load((EventHandler)ParentLoad);
			((Control)form_1).add_VisibleChanged((EventHandler)ParentVisibleChanged);
			((Control)form_1).add_Resize((EventHandler)ParentResize);
		}
		if (!base.DesignMode)
		{
			if (!bool_0 && !bool_9)
			{
				Class107.smethod_0(this);
				bool_0 = true;
			}
			else if (bool_9 && class94_0 == null)
			{
				class94_0 = new Class94(this);
			}
		}
		if (class33_0 != null)
		{
			((NativeWindow)class33_0).ReleaseHandle();
			class33_0 = null;
		}
		MdiClient mdiClient = ((IOwner)this).GetMdiClient(form_1);
		if (mdiClient != null)
		{
			SetupMdiHandler(mdiClient);
		}
		else
		{
			((Control)form_1).add_ControlAdded(new ControlEventHandler(ParentControlAdded));
			bool_16 = true;
		}
		BarStreamLoad();
	}

	private void ParentHandleDestroyed(object sender, EventArgs e)
	{
		if (!base.DesignMode)
		{
			UnRegisterParentMsgHandler(this, form_1);
		}
	}

	private void ParentHandleCreated(object sender, EventArgs e)
	{
		if (!base.DesignMode)
		{
			if (form_1.get_IsMdiChild() && form_1.get_MdiParent() != null)
			{
				RegisterParentMsgHandler(this, form_1.get_MdiParent());
			}
			else
			{
				RegisterParentMsgHandler(this, form_1);
			}
			if (class33_0 != null)
			{
				((NativeWindow)class33_0).ReleaseHandle();
				class33_0 = null;
				MdiClient mdiClient = ((IOwner)this).GetMdiClient(form_1);
				if (mdiClient != null)
				{
					SetupMdiHandler(mdiClient);
				}
			}
		}
		BarStreamLoad(bForceLoad: true);
	}

	private void SetupMdiHandler(MdiClient client)
	{
		if (((Control)client).get_IsHandleCreated())
		{
			SetupClientMsgHandler(client);
		}
		else if (!bool_18)
		{
			((Control)client).add_HandleCreated((EventHandler)MdiClientHandleCreates);
			bool_18 = true;
		}
		if (!bool_17)
		{
			form_1.add_MdiChildActivate((EventHandler)OnMdiChildActivate);
			bool_17 = true;
			if (form_1.get_ActiveMdiChild() != null)
			{
				OnMdiChildActivate(form_1, new EventArgs());
			}
		}
	}

	private void SetupClientMsgHandler(MdiClient client)
	{
		if (client != null)
		{
			if (class33_0 != null)
			{
				((NativeWindow)class33_0).ReleaseHandle();
				class33_0 = null;
			}
			class33_0 = new Class33();
			class33_0.Event_0 += OnMdiSetMenu;
			((NativeWindow)class33_0).AssignHandle(((Control)client).get_Handle());
			if (bool_18)
			{
				((Control)client).remove_HandleCreated((EventHandler)MdiClientHandleCreates);
				bool_18 = false;
			}
		}
	}

	private void MdiClientHandleCreates(object sender, EventArgs e)
	{
		SetupClientMsgHandler((MdiClient)((sender is MdiClient) ? sender : null));
	}

	private void ParentResize(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		if (form_1 != null && (int)form_1.get_WindowState() != 1 && bool_5 && arrayList_0.Count > 0)
		{
			((IOwner)this).OnApplicationActivate();
		}
		else if (form_1 != null && (int)form_1.get_WindowState() == 1 && arrayList_0.Count == 0)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	private void ParentActivated(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		bool_5 = true;
		if (arrayList_0.Count > 0 && form_1 != null && (int)form_1.get_WindowState() != 1)
		{
			((IOwner)this).OnApplicationActivate();
		}
	}

	private void ParentDeactivate(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		bool_5 = false;
		if (form_1 != null && (int)form_1.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	private void ParentVisibleChanged(object sender, EventArgs e)
	{
		if (form_1 == null)
		{
			return;
		}
		if (((Control)form_1).get_Visible())
		{
			if (!bool_0 && !bool_9)
			{
				bool_0 = true;
				Class107.smethod_0(this);
			}
			else if (bool_9 && class94_0 == null)
			{
				class94_0 = new Class94(this);
			}
		}
		else if (bool_0)
		{
			Class107.smethod_1(this);
			bool_0 = false;
		}
		else if (class94_0 != null)
		{
			class94_0.Dispose();
			class94_0 = null;
		}
	}

	private void ParentLoad(object sender, EventArgs e)
	{
		if (class33_0 == null)
		{
			MdiClient mdiClient = ((IOwner)this).GetMdiClient(form_1);
			if (mdiClient != null)
			{
				SetupMdiHandler(mdiClient);
			}
		}
		if (((Control)form_1).get_IsHandleCreated() && !base.DesignMode)
		{
			if (form_1.get_IsMdiChild() && form_1.get_MdiParent() != null)
			{
				if (!IsManagerRegistered(this, form_1.get_MdiParent()))
				{
					UnRegisterParentMsgHandler(this, form_1);
					RegisterParentMsgHandler(this, form_1.get_MdiParent());
				}
			}
			else
			{
				RegisterParentMsgHandler(this, form_1);
			}
		}
		BarStreamLoad(bForceLoad: true);
	}

	private void ParentControlAdded(object sender, ControlEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (e.get_Control() is MdiClient)
		{
			SetupMdiHandler((MdiClient)e.get_Control());
		}
	}

	private void BarStreamLoad()
	{
		BarStreamLoad(bForceLoad: false);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void BarStreamLoad(bool bForceLoad)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		if (bool_23)
		{
			return;
		}
		if (string_0 != "" && ((dockSite_0 != null && ((Control)dockSite_0).get_Parent() != null && dockSite_1 != null && ((Control)dockSite_1).get_Parent() != null && dockSite_2 != null && ((Control)dockSite_2).get_Parent() != null && dockSite_3 != null && ((Control)dockSite_3).get_Parent() != null) || bForceLoad || (IsPopupProviderOnly && ParentForm != null && control_0 != null)))
		{
			if (base.DesignMode)
			{
				string text = DesignTimeDte.GetDefinitionPath(string_0, Site);
				if (text != null && text != "")
				{
					if (!text.EndsWith("\\"))
					{
						text += "\\";
					}
					if (File.Exists(text + string_0))
					{
						LoadDefinition(text + string_0);
					}
					else
					{
						MessageBox.Show("DotNetBar definition file not found: " + text + string_0, "DotNetBar Designer", (MessageBoxButtons)0, (MessageBoxIcon)48);
						string_0 = "";
					}
				}
			}
			else if ((ParentForm != null && (((Control)ParentForm).get_IsHandleCreated() || bForceLoad || IsPopupProviderOnly)) || (dockSite_0 != null && ((Control)dockSite_0).get_Parent() is UserControl))
			{
				Stream stream = null;
				Hashtable hashtable = new Hashtable();
				if (dockSite_0 != null && ((Control)dockSite_0).get_Parent() is UserControl)
				{
					hashtable.Add(((object)((Control)dockSite_0).get_Parent()).GetType().Assembly.FullName, ((object)((Control)dockSite_0).get_Parent()).GetType().Assembly);
					stream = ((object)((Control)dockSite_0).get_Parent()).GetType().Assembly.GetManifestResourceStream(((object)((Control)dockSite_0).get_Parent()).GetType().Namespace + "." + string_0);
				}
				else
				{
					if (((object)ParentForm).GetType().BaseType!.FullName != "System.Windows.Forms.Form")
					{
						Type type = ((object)ParentForm).GetType();
						Stack stack = new Stack(10);
						for (int i = 0; i < 64; i++)
						{
							stack.Push(type);
							if (!hashtable.ContainsKey(type.Assembly.FullName))
							{
								hashtable.Add(type.Assembly.FullName, type.Assembly);
							}
							if (type.BaseType!.FullName == "System.Windows.Forms.Form")
							{
								break;
							}
							type = type.BaseType;
						}
						stream = type.Assembly.GetManifestResourceStream(type.Namespace + "." + string_0);
						if (stream == null)
						{
							while (stack.Count > 0 && stream == null)
							{
								type = stack.Pop() as Type;
								stream = type.Assembly.GetManifestResourceStream(type.Namespace + "." + string_0);
							}
						}
						stack.Clear();
					}
					else
					{
						stream = ((object)ParentForm).GetType().Assembly.GetManifestResourceStream(((object)ParentForm).GetType().Namespace + "." + string_0);
						hashtable.Add(((object)ParentForm).GetType().Assembly.FullName, ((object)ParentForm).GetType().Assembly);
					}
					if (control_0 != null && !hashtable.Contains(((object)control_0).GetType().Assembly.FullName))
					{
						hashtable.Add(((object)control_0).GetType().Assembly.FullName, ((object)control_0).GetType().Assembly);
					}
				}
				if (stream == null)
				{
					Assembly[] array = new Assembly[hashtable.Count];
					hashtable.Values.CopyTo(array, 0);
					for (int num = array.Length - 1; num >= 0; num--)
					{
						Assembly assembly = array[num];
						string[] manifestResourceNames = assembly.GetManifestResourceNames();
						string[] array2 = manifestResourceNames;
						foreach (string text2 in array2)
						{
							if (text2.EndsWith(string_0))
							{
								stream = assembly.GetManifestResourceStream(text2);
								break;
							}
						}
						if (stream != null)
						{
							break;
						}
					}
				}
				hashtable.Clear();
				if (stream != null)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(stream);
					LoadDefinition(xmlDocument);
					bool_23 = true;
				}
			}
			dotNetBarStreamer_0 = null;
		}
		else if (dotNetBarStreamer_0 != null && ((dockSite_0 != null && ((Control)dockSite_0).get_Parent() != null && dockSite_1 != null && ((Control)dockSite_1).get_Parent() != null && dockSite_2 != null && ((Control)dockSite_2).get_Parent() != null && dockSite_3 != null && ((Control)dockSite_3).get_Parent() != null) || bForceLoad))
		{
			if (dotNetBarStreamer_0.Data != null)
			{
				LoadDefinition(dotNetBarStreamer_0.Data);
				bool_23 = true;
			}
			dotNetBarStreamer_0 = null;
		}
	}

	void IOwner.OnApplicationDeactivate()
	{
		CloseDockingHints();
		if (arrayList_0.Count == 0)
		{
			if (bars_0 != null)
			{
				foreach (Bar item in bars_0)
				{
					if (item.Boolean_14)
					{
						return;
					}
				}
				foreach (Bar item2 in bars_0)
				{
					item2.method_93();
					if (item2.BarState == eBarState.Floating && item2.Visible && item2.HideFloatingInactive)
					{
						item2.method_95();
						arrayList_0.Add(item2);
					}
				}
			}
			ArrayList arrayList = new ArrayList(arrayList_2);
			foreach (PopupItem item3 in arrayList)
			{
				item3.ClosePopup();
			}
		}
		Bar menuBar = GetMenuBar();
		if (menuBar != null && menuBar.Boolean_11)
		{
			menuBar.Boolean_11 = false;
		}
	}

	void IOwner.OnApplicationActivate()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		if (form_1 == null || (int)form_1.get_WindowState() == 1)
		{
			return;
		}
		Form activeForm = Form.get_ActiveForm();
		if (activeForm == null || (activeForm.get_Modal() && activeForm != form_1))
		{
			return;
		}
		try
		{
			foreach (Bar item in arrayList_0)
			{
				item.method_97();
			}
		}
		finally
		{
			arrayList_0.Clear();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (bool_4)
		{
			base.Dispose(disposing);
			return;
		}
		bool_4 = true;
		if (disposing && license_0 != null)
		{
			license_0.Dispose();
			license_0 = null;
		}
		if (form_0 != null)
		{
			((Control)form_0).remove_Resize((EventHandler)OnMdiChildResize);
			((Control)form_0).remove_VisibleChanged((EventHandler)OnMdiChildVisibleChanged);
			form_0 = null;
		}
		Images = null;
		ImagesMedium = null;
		ImagesLarge = null;
		if (timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
		if (arrayList_2 != null && arrayList_2.Count > 0)
		{
			BaseItem[] array;
			lock (this)
			{
				array = (BaseItem[])arrayList_2.ToArray(typeof(BaseItem));
			}
			BaseItem[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				PopupItem popupItem = (PopupItem)array2[i];
				if (popupItem.Expanded)
				{
					popupItem.ClosePopup();
				}
			}
			arrayList_2 = null;
		}
		ReleaseParentFormHooks();
		if (bool_0)
		{
			Class107.smethod_1(this);
			bool_0 = false;
		}
		if (class94_0 != null)
		{
			class94_0.Dispose();
			class94_0 = null;
		}
		if (frmCustomize_0 != null)
		{
			((Form)frmCustomize_0).Close();
			if (frmCustomize_0 != null)
			{
				((Component)(object)frmCustomize_0).Dispose();
			}
		}
		if (bars_0 != null)
		{
			bars_0 = null;
		}
		if (items_0 != null)
		{
			items_0.Dispose();
			items_0 = null;
		}
		if (contextMenusCollection_0 != null)
		{
			contextMenusCollection_0.method_0(null);
			contextMenusCollection_0 = null;
		}
		if (bool_37)
		{
			GC.Collect();
		}
		base.Dispose(disposing);
	}

	private void ReleaseParentFormHooks()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		if (form_1 != null)
		{
			if (!base.DesignMode)
			{
				UnRegisterParentMsgHandler(this, form_1);
			}
			((Control)form_1).remove_HandleDestroyed((EventHandler)ParentHandleDestroyed);
			((Control)form_1).remove_HandleCreated((EventHandler)ParentHandleCreated);
			if (bool_16)
			{
				((Control)form_1).remove_ControlAdded(new ControlEventHandler(ParentControlAdded));
				bool_16 = false;
			}
			if (!base.DesignMode)
			{
				form_1.remove_Activated((EventHandler)ParentActivated);
				form_1.remove_Deactivate((EventHandler)ParentDeactivate);
				form_1.remove_Load((EventHandler)ParentLoad);
				((Control)form_1).remove_VisibleChanged((EventHandler)ParentVisibleChanged);
				((Control)form_1).remove_Resize((EventHandler)ParentResize);
			}
			if (bool_17)
			{
				form_1.remove_MdiChildActivate((EventHandler)OnMdiChildActivate);
				bool_17 = false;
			}
		}
	}

	private void ImageListDisposed(object sender, EventArgs e)
	{
		if (sender == imageList_0)
		{
			Images = null;
		}
		else if (sender == imageList_2)
		{
			ImagesLarge = null;
		}
		else if (sender == imageList_1)
		{
			ImagesMedium = null;
		}
	}

	public bool ShouldSerializeMinimumClientSize()
	{
		if (size_0.Width == 48)
		{
			return size_0.Height != 48;
		}
		return true;
	}

	public void RemoveBar(Bar bar)
	{
		if (!bars_0.Contains(bar))
		{
			throw new ArgumentException("Bar not part of Bars collections.");
		}
		bars_0.Remove(bar);
		if (((Control)bar).get_Parent() != null && ((Control)bar).get_Parent() is DockSite)
		{
			if (!((DockSite)(object)((Control)bar).get_Parent()).Boolean_2 && ((DockSite)(object)((Control)bar).get_Parent()).DocumentDockContainer == null)
			{
				((DockSite)(object)((Control)bar).get_Parent()).method_21((Control)(object)bar);
			}
			else
			{
				((DockSite)(object)((Control)bar).get_Parent()).GetDocumentUIManager().UnDock(bar);
			}
		}
		((IOwnerBarSupport)this).RemoveShortcutsFromBar(bar);
	}

	void IOwnerBarSupport.AddShortcutsFromBar(Bar bar)
	{
		foreach (BaseItem item in bar.Items)
		{
			((IOwner)this).AddShortcutsFromItem(item);
		}
	}

	void IOwner.AddShortcutsFromItem(BaseItem objItem)
	{
		Class49 @class = null;
		if (objItem.ShortcutString != "")
		{
			foreach (eShortcut shortcut in objItem.Shortcuts)
			{
				if (hashtable_1.ContainsKey(shortcut))
				{
					@class = (Class49)hashtable_1[objItem.Shortcuts[0]];
				}
				else
				{
					@class = new Class49(shortcut);
					hashtable_1.Add(@class.eShortcut_0, @class);
				}
				try
				{
					if (!@class.hashtable_0.ContainsKey(objItem.Id))
					{
						@class.hashtable_0.Add(objItem.Id, objItem);
					}
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

	void IOwnerBarSupport.RemoveShortcutsFromBar(Bar bar)
	{
		if (bar.Items == null)
		{
			return;
		}
		foreach (BaseItem item in bar.Items)
		{
			((IOwner)this).RemoveShortcutsFromItem(item);
		}
	}

	void IOwner.RemoveShortcutsFromItem(BaseItem objItem)
	{
		Class49 @class = null;
		if (objItem.ShortcutString != "")
		{
			foreach (eShortcut shortcut in objItem.Shortcuts)
			{
				if (!hashtable_1.ContainsKey(shortcut))
				{
					continue;
				}
				@class = (Class49)hashtable_1[shortcut];
				try
				{
					@class.hashtable_0.Remove(objItem.Id);
					if (@class.hashtable_0.Count == 0)
					{
						hashtable_1.Remove(@class.eShortcut_0);
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

	[DevCoBrowsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBars()
	{
		if (bool_26)
		{
			return true;
		}
		return false;
	}

	public void ForceDefinitionLoad()
	{
		if (!bool_23)
		{
			BarStreamLoad(bForceLoad: true);
		}
	}

	protected bool ShouldSerializeBarStream()
	{
		return false;
	}

	internal bool IsDesignTime()
	{
		return base.DesignMode;
	}

	DockSiteInfo IOwnerBarSupport.GetDockInfo(IDockInfo pDock, int x, int y)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		DockSiteInfo dockInfo = default(DockSiteInfo);
		if ((Control.get_ModifierKeys() & 0x20000) != 0)
		{
			return dockInfo;
		}
		if (((Bar)pDock).LayoutType == eLayoutType.DockContainer)
		{
			if ((pDock.CanDockBottom || pDock.CanDockLeft || pDock.CanDockRight || pDock.CanDockTop || pDock.CanDockDocument) && DockingHintHandler(ref dockInfo, pDock, x, y))
			{
				return dockInfo;
			}
			return dockInfo;
		}
		if (pDock.CanDockTop && dockSite_5 != null)
		{
			dockInfo = dockSite_5.GetDockSiteInfo(pDock, x, y);
			if (dockInfo.objDockSite != null)
			{
				return dockInfo;
			}
		}
		if (pDock.CanDockBottom && dockSite_6 != null)
		{
			dockInfo = dockSite_6.GetDockSiteInfo(pDock, x, y);
			if (dockInfo.objDockSite != null)
			{
				return dockInfo;
			}
		}
		if (pDock.CanDockLeft && dockSite_7 != null)
		{
			dockInfo = dockSite_7.GetDockSiteInfo(pDock, x, y);
			if (dockInfo.objDockSite != null)
			{
				return dockInfo;
			}
		}
		if (pDock.CanDockRight && dockSite_8 != null)
		{
			dockInfo = dockSite_8.GetDockSiteInfo(pDock, x, y);
			if (dockInfo.objDockSite != null)
			{
				return dockInfo;
			}
		}
		return dockInfo;
	}

	void IOwnerBarSupport.DockComplete()
	{
		CloseDockingHints();
		bool_38 = false;
	}

	private bool CanDockToBar(IDockInfo barDockInfo, Bar referenceBar)
	{
		if (!referenceBar.AcceptDropItems)
		{
			return false;
		}
		if (referenceBar.DockSide == eDockSide.Bottom && !barDockInfo.CanDockBottom)
		{
			return false;
		}
		if (referenceBar.DockSide == eDockSide.Left && !barDockInfo.CanDockLeft)
		{
			return false;
		}
		if (referenceBar.DockSide == eDockSide.Right && !barDockInfo.CanDockRight)
		{
			return false;
		}
		if (referenceBar.DockSide == eDockSide.Document && !barDockInfo.CanDockDocument)
		{
			return false;
		}
		if (referenceBar.DockSide == eDockSide.Top && !barDockInfo.CanDockTop)
		{
			return false;
		}
		return true;
	}

	private bool DockingHintHandler(ref DockSiteInfo dockInfo, IDockInfo barDockInfo, int x, int y)
	{
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_38)
		{
			bool_38 = true;
			return true;
		}
		Bar bar = null;
		foreach (Bar bar2 in Bars)
		{
			if (bar2.Visible && (bar2 != barDockInfo || base.DesignMode || bar2.DockSide == eDockSide.Document))
			{
				Point pt = ((Control)bar2).PointToClient(new Point(x, y));
				if (bar2.LayoutType == eLayoutType.DockContainer && ((Control)bar2).get_ClientRectangle().Contains(pt) && bar2.DockSide != 0 && CanDockToBar(barDockInfo, bar2))
				{
					bar = bar2;
					break;
				}
			}
		}
		SetupDockingHintWindows(bar, barDockInfo);
		bool flag = false;
		dockInfo.DockSiteZOrderIndex = -1;
		Enum12 @enum = Enum12.const_0;
		if (dockingHint_0 != null)
		{
			@enum = dockingHint_0.method_4(x, y);
		}
		if (dockingHint_1 != null)
		{
			Enum12 enum2 = dockingHint_1.method_4(x, y);
			if (@enum == Enum12.const_0)
			{
				@enum = enum2;
			}
		}
		if (dockingHint_2 != null)
		{
			Enum12 enum3 = dockingHint_2.method_4(x, y);
			if (@enum == Enum12.const_0)
			{
				@enum = enum3;
			}
		}
		if (dockingHint_3 != null)
		{
			Enum12 enum4 = dockingHint_3.method_4(x, y);
			if (@enum == Enum12.const_0)
			{
				@enum = enum4;
			}
		}
		if (dockingHint_4 != null)
		{
			Enum12 enum5 = dockingHint_4.method_4(x, y);
			if (@enum == Enum12.const_0)
			{
				@enum = enum5;
				if (enum5 != 0)
				{
					flag = true;
				}
				if (flag && IsDocumentDockingEnabled && barDockInfo.CanDockDocument && bar == null && barDockInfo.CanDockDocument)
				{
					if (!barDockInfo.CanDockTop && enum5 == Enum12.const_3)
					{
						@enum = Enum12.const_5;
					}
					else if (!barDockInfo.CanDockBottom && enum5 == Enum12.const_4)
					{
						@enum = Enum12.const_5;
					}
					else if (!barDockInfo.CanDockLeft && enum5 == Enum12.const_1)
					{
						@enum = Enum12.const_5;
					}
					else if (!barDockInfo.CanDockRight && enum5 == Enum12.const_2)
					{
						@enum = Enum12.const_5;
					}
				}
			}
		}
		dockInfo.MouseOverBar = bar;
		if (bar != null && flag)
		{
			switch (@enum)
			{
			case Enum12.const_1:
				dockInfo.MouseOverDockSide = eDockSide.Left;
				dockInfo.DockSide = ((Control)bar).get_Parent().get_Dock();
				dockInfo.objDockSite = bar.DockedSite as DockSite;
				switch (bar.DockSide)
				{
				default:
					dockInfo.DockLine = 0;
					dockInfo.InsertPosition = ((Control)bar).get_Parent().get_Controls().IndexOf((Control)(object)bar);
					dockInfo.NewLine = true;
					break;
				case eDockSide.Top:
				case eDockSide.Bottom:
					dockInfo.DockLine = 0;
					dockInfo.InsertPosition = ((Control)bar).get_Parent().get_Controls().IndexOf((Control)(object)bar);
					dockInfo.DockOffset = bar.DockOffset - 1;
					break;
				}
				break;
			case Enum12.const_2:
				dockInfo.MouseOverDockSide = eDockSide.Right;
				dockInfo.DockSide = ((Control)bar).get_Parent().get_Dock();
				dockInfo.objDockSite = bar.DockedSite as DockSite;
				switch (bar.DockSide)
				{
				default:
					dockInfo.DockLine = bar.DockLine + 1;
					dockInfo.InsertPosition = ((Control)bar).get_Parent().get_Controls().IndexOf((Control)(object)bar);
					dockInfo.InsertPosition++;
					dockInfo.NewLine = true;
					break;
				case eDockSide.Top:
				case eDockSide.Bottom:
					dockInfo.DockLine = 0;
					dockInfo.InsertPosition = ((Control)bar).get_Parent().get_Controls().IndexOf((Control)(object)bar) + 1;
					dockInfo.DockOffset = bar.DockOffset + 1;
					break;
				}
				break;
			case Enum12.const_3:
				dockInfo.MouseOverDockSide = eDockSide.Top;
				dockInfo.DockSide = ((Control)bar).get_Parent().get_Dock();
				dockInfo.objDockSite = bar.DockedSite as DockSite;
				switch (bar.DockSide)
				{
				default:
					dockInfo.DockLine = 0;
					dockInfo.InsertPosition = ((Control)bar).get_Parent().get_Controls().IndexOf((Control)(object)bar);
					dockInfo.DockOffset = bar.DockOffset - 1;
					break;
				case eDockSide.Top:
				case eDockSide.Bottom:
					dockInfo.DockLine = 0;
					dockInfo.InsertPosition = ((Control)bar).get_Parent().get_Controls().IndexOf((Control)(object)bar);
					dockInfo.NewLine = true;
					break;
				}
				break;
			case Enum12.const_4:
				dockInfo.MouseOverDockSide = eDockSide.Bottom;
				dockInfo.DockSide = ((Control)bar).get_Parent().get_Dock();
				dockInfo.objDockSite = bar.DockedSite as DockSite;
				switch (bar.DockSide)
				{
				default:
					dockInfo.DockLine = 0;
					dockInfo.InsertPosition = ((Control)bar).get_Parent().get_Controls().IndexOf((Control)(object)bar) + 1;
					dockInfo.DockOffset = bar.DockOffset + 1;
					break;
				case eDockSide.Top:
				case eDockSide.Bottom:
					dockInfo.DockLine = bar.DockLine + 1;
					dockInfo.InsertPosition = ((Control)bar).get_Parent().get_Controls().IndexOf((Control)(object)bar);
					if (bar.DockSide == eDockSide.Bottom)
					{
						dockInfo.InsertPosition++;
					}
					dockInfo.NewLine = true;
					break;
				}
				break;
			case Enum12.const_5:
				dockInfo.MouseOverDockSide = eDockSide.Document;
				if (bar != null)
				{
					dockInfo.TabDockContainer = bar;
					dockInfo.DockSide = ((Control)bar).get_Parent().get_Dock();
					dockInfo.objDockSite = ((Control)bar).get_Parent() as DockSite;
				}
				break;
			}
		}
		else
		{
			if (bool_30)
			{
				dockInfo.FullSizeDock = !flag;
				dockInfo.PartialSizeDock = flag;
			}
			switch (@enum)
			{
			case Enum12.const_1:
				dockInfo.MouseOverDockSide = eDockSide.Left;
				if (barDockInfo.DockSide != eDockSide.Left)
				{
					dockInfo.DockSide = (DockStyle)3;
					if (flag)
					{
						dockInfo.DockLine = 999;
						dockInfo.InsertPosition = 999;
					}
					else
					{
						dockInfo.DockLine = -1;
						dockInfo.InsertPosition = 0;
					}
					dockInfo.NewLine = true;
				}
				else
				{
					dockInfo.DockSide = (DockStyle)3;
					dockInfo.DockLine = barDockInfo.DockLine;
					dockInfo.DockOffset = barDockInfo.DockOffset;
					dockInfo.InsertPosition = ((Control)dockSite_2).get_Controls().IndexOf((Control)((barDockInfo is Control) ? barDockInfo : null));
				}
				dockInfo.objDockSite = dockSite_2;
				break;
			case Enum12.const_2:
				dockInfo.MouseOverDockSide = eDockSide.Right;
				if (barDockInfo.DockSide != eDockSide.Right)
				{
					dockInfo.DockSide = (DockStyle)4;
					if (flag)
					{
						dockInfo.DockLine = -1;
						dockInfo.InsertPosition = 0;
					}
					else
					{
						dockInfo.DockLine = 999;
						dockInfo.InsertPosition = 999;
					}
					dockInfo.NewLine = true;
				}
				else
				{
					dockInfo.DockSide = (DockStyle)4;
					dockInfo.DockLine = barDockInfo.DockLine;
					dockInfo.DockOffset = barDockInfo.DockOffset;
					dockInfo.InsertPosition = ((Control)dockSite_3).get_Controls().IndexOf((Control)((barDockInfo is Control) ? barDockInfo : null));
				}
				dockInfo.objDockSite = dockSite_3;
				break;
			case Enum12.const_3:
				dockInfo.MouseOverDockSide = eDockSide.Top;
				if (barDockInfo.DockSide != eDockSide.Top)
				{
					dockInfo.DockSide = (DockStyle)1;
					if (flag)
					{
						dockInfo.DockLine = 999;
						dockInfo.InsertPosition = 999;
					}
					else
					{
						dockInfo.DockLine = -1;
						dockInfo.InsertPosition = 0;
					}
					dockInfo.NewLine = true;
				}
				else
				{
					dockInfo.DockSide = (DockStyle)1;
					dockInfo.DockLine = barDockInfo.DockLine;
					dockInfo.DockOffset = barDockInfo.DockOffset;
					dockInfo.InsertPosition = ((Control)dockSite_0).get_Controls().IndexOf((Control)((barDockInfo is Control) ? barDockInfo : null));
				}
				dockInfo.objDockSite = dockSite_0;
				break;
			case Enum12.const_4:
				dockInfo.MouseOverDockSide = eDockSide.Bottom;
				if (barDockInfo.DockSide != eDockSide.Bottom)
				{
					dockInfo.DockSide = (DockStyle)2;
					if (flag)
					{
						dockInfo.DockLine = -1;
						dockInfo.InsertPosition = 0;
					}
					else
					{
						dockInfo.DockLine = 999;
						dockInfo.InsertPosition = 999;
					}
					dockInfo.NewLine = true;
				}
				else
				{
					dockInfo.DockSide = (DockStyle)2;
					dockInfo.DockLine = barDockInfo.DockLine;
					dockInfo.DockOffset = barDockInfo.DockOffset;
					dockInfo.InsertPosition = ((Control)dockSite_1).get_Controls().IndexOf((Control)((barDockInfo is Control) ? barDockInfo : null));
				}
				dockInfo.objDockSite = dockSite_1;
				break;
			case Enum12.const_5:
				if (IsDocumentDockingEnabled)
				{
					dockInfo.objDockSite = dockSite_4;
					dockInfo.DockSide = (DockStyle)5;
					dockInfo.MouseOverDockSide = eDockSide.Document;
				}
				break;
			}
		}
		dockInfo.UseOutline = true;
		return true;
	}

	private void CloseDockingHints()
	{
		if (bool_39)
		{
			return;
		}
		try
		{
			bool_39 = true;
			if (dockingHint_0 != null)
			{
				Class92.SetWindowPos(((Control)dockingHint_0).get_Handle(), 0, 0, 0, 0, 0, 147);
				((Form)dockingHint_0).Close();
				((Component)(object)dockingHint_0).Dispose();
				dockingHint_0 = null;
			}
			if (dockingHint_1 != null)
			{
				Class92.SetWindowPos(((Control)dockingHint_1).get_Handle(), 0, 0, 0, 0, 0, 147);
				((Form)dockingHint_1).Close();
				((Component)(object)dockingHint_1).Dispose();
				dockingHint_1 = null;
			}
			if (dockingHint_2 != null)
			{
				Class92.SetWindowPos(((Control)dockingHint_2).get_Handle(), 0, 0, 0, 0, 0, 147);
				((Form)dockingHint_2).Close();
				((Component)(object)dockingHint_2).Dispose();
				dockingHint_2 = null;
			}
			if (dockingHint_3 != null)
			{
				Class92.SetWindowPos(((Control)dockingHint_3).get_Handle(), 0, 0, 0, 0, 0, 147);
				((Form)dockingHint_3).Close();
				((Component)(object)dockingHint_3).Dispose();
				dockingHint_3 = null;
			}
			if (dockingHint_4 != null)
			{
				Class92.SetWindowPos(((Control)dockingHint_4).get_Handle(), 0, 0, 0, 0, 0, 147);
				((Form)dockingHint_4).Close();
				((Component)(object)dockingHint_4).Dispose();
				dockingHint_4 = null;
			}
		}
		catch
		{
		}
		finally
		{
			bool_39 = false;
		}
	}

	private void SetupDockingHintWindows(Bar barMouseOver, IDockInfo barDockInfo)
	{
		Rectangle empty = Rectangle.Empty;
		if (((Control)dockSite_0).get_Parent().get_Parent() != null)
		{
			empty = new Rectangle(((Control)dockSite_0).get_Parent().PointToScreen(Point.Empty), ((Control)dockSite_0).get_Parent().get_Size());
			empty.Y += ((Control)dockSite_0).get_Height();
			empty.Height -= ((Control)dockSite_0).get_Height();
		}
		else
		{
			empty = ((Control)dockSite_0).get_Parent().get_Bounds();
			empty.Y += ((Control)dockSite_0).get_Height();
			empty.Height -= ((Control)dockSite_0).get_Height();
		}
		if (!base.DesignMode)
		{
			if (barDockInfo.CanDockLeft)
			{
				if (dockingHint_0 == null)
				{
					dockingHint_0 = new DockingHint(Enum7.flag_0);
					((Form)dockingHint_0).set_Location(new Point(empty.X + 32, empty.Y + (empty.Height - ((Control)dockingHint_0).get_Height()) / 2));
					dockingHint_0.method_0();
				}
			}
			else if (dockingHint_0 != null)
			{
				((Form)dockingHint_0).Close();
				((Component)(object)dockingHint_0).Dispose();
				dockingHint_0 = null;
			}
			if (barDockInfo.CanDockRight)
			{
				if (dockingHint_1 == null)
				{
					dockingHint_1 = new DockingHint(Enum7.flag_1);
					((Form)dockingHint_1).set_Location(new Point(empty.Right - 32 - ((Control)dockingHint_1).get_Width(), empty.Y + (empty.Height - ((Control)dockingHint_1).get_Height()) / 2));
					dockingHint_1.method_0();
				}
			}
			else if (dockingHint_1 != null)
			{
				((Form)dockingHint_1).Close();
				((Component)(object)dockingHint_1).Dispose();
				dockingHint_1 = null;
			}
			if (barDockInfo.CanDockTop)
			{
				if (dockingHint_2 == null)
				{
					dockingHint_2 = new DockingHint(Enum7.flag_2);
					((Form)dockingHint_2).set_Location(new Point(empty.X + (empty.Width - ((Control)dockingHint_2).get_Width()) / 2, empty.Y + 32));
					dockingHint_2.method_0();
				}
			}
			else if (dockingHint_2 != null)
			{
				((Form)dockingHint_2).Close();
				((Component)(object)dockingHint_2).Dispose();
				dockingHint_2 = null;
			}
			if (barDockInfo.CanDockBottom)
			{
				if (dockingHint_3 == null)
				{
					dockingHint_3 = new DockingHint(Enum7.flag_3);
					((Form)dockingHint_3).set_Location(new Point(empty.X + (empty.Width - ((Control)dockingHint_3).get_Width()) / 2, empty.Bottom - 32 - ((Control)dockingHint_3).get_Height()));
					dockingHint_3.method_0();
				}
			}
			else if (dockingHint_3 != null)
			{
				((Form)dockingHint_3).Close();
				((Component)(object)dockingHint_3).Dispose();
				dockingHint_3 = null;
			}
		}
		bool flag = false;
		Enum7 @enum = Enum7.flag_5;
		if (barMouseOver == null)
		{
			@enum = Enum7.flag_2;
			if (barDockInfo.CanDockBottom)
			{
				@enum = Enum7.flag_3;
			}
			if (barDockInfo.CanDockLeft)
			{
				@enum |= Enum7.flag_0;
			}
			if (barDockInfo.CanDockRight)
			{
				@enum |= Enum7.flag_1;
			}
			@enum = ((!barDockInfo.CanDockTop) ? (@enum & ~(@enum & Enum7.flag_2)) : (@enum | Enum7.flag_2));
			if (IsDocumentDockingEnabled && barDockInfo.CanDockDocument)
			{
				@enum = Enum7.flag_5;
			}
		}
		else if (!barDockInfo.CanDockTab)
		{
			@enum &= ~(@enum & Enum7.flag_4);
		}
		if (dockingHint_4 == null)
		{
			if (barMouseOver != null)
			{
				dockingHint_4 = new DockingHint(@enum, middleDockingHint: true);
			}
			else
			{
				dockingHint_4 = new DockingHint(@enum, middleDockingHint: true);
			}
			flag = true;
		}
		else if (barMouseOver != null)
		{
			dockingHint_4.Enum7_0 = @enum;
		}
		else
		{
			dockingHint_4.Enum7_0 = @enum;
		}
		Point point = new Point(empty.X + (empty.Width - ((Control)dockingHint_4).get_Width()) / 2, empty.Y + (empty.Height - ((Control)dockingHint_4).get_Height()) / 2);
		if (barMouseOver != null)
		{
			Point point2 = ((Control)barMouseOver).PointToScreen(Point.Empty);
			point = new Point(point2.X + (((Control)barMouseOver).get_Width() - ((Control)dockingHint_4).get_Width()) / 2, point2.Y + (((Control)barMouseOver).get_Height() - ((Control)dockingHint_4).get_Height()) / 2);
		}
		Rectangle rectangle = new Rectangle(point, ((Form)dockingHint_4).get_Size());
		if (dockingHint_0 != null && rectangle.IntersectsWith(((Control)dockingHint_0).get_Bounds()))
		{
			if (Control.get_MousePosition().Y < ((Control)dockingHint_0).get_Top())
			{
				point.Y = ((Control)dockingHint_0).get_Top() - ((Control)dockingHint_4).get_Height();
			}
			else
			{
				point.Y = ((Control)dockingHint_0).get_Bottom();
			}
		}
		else if (dockingHint_1 != null && rectangle.IntersectsWith(((Control)dockingHint_1).get_Bounds()))
		{
			if (Control.get_MousePosition().Y < ((Control)dockingHint_1).get_Top())
			{
				point.Y = ((Control)dockingHint_1).get_Top() - ((Control)dockingHint_4).get_Height();
			}
			else
			{
				point.Y = ((Control)dockingHint_1).get_Bottom();
			}
		}
		else if (dockingHint_2 != null && rectangle.IntersectsWith(((Control)dockingHint_2).get_Bounds()))
		{
			if (Control.get_MousePosition().X > ((Control)dockingHint_2).get_Left())
			{
				point.X = ((Control)dockingHint_2).get_Right();
			}
			else
			{
				point.X = ((Control)dockingHint_2).get_Left() - ((Control)dockingHint_4).get_Width();
			}
		}
		else if (dockingHint_3 != null && rectangle.IntersectsWith(((Control)dockingHint_3).get_Bounds()))
		{
			if (Control.get_MousePosition().X > ((Control)dockingHint_3).get_Left())
			{
				point.X = ((Control)dockingHint_3).get_Right();
			}
			else
			{
				point.X = ((Control)dockingHint_3).get_Left() - ((Control)dockingHint_4).get_Width();
			}
		}
		if (((Form)dockingHint_4).get_Location() != point)
		{
			((Form)dockingHint_4).set_Location(point);
		}
		if (flag)
		{
			dockingHint_4.method_0();
		}
	}

	public void LoadDefinition(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(FileName);
		LoadDefinition(xmlDocument);
	}

	private Hashtable GetDockControls()
	{
		Hashtable hashtable = new Hashtable();
		foreach (Bar bar in Bars)
		{
			if (bar.LayoutType != eLayoutType.DockContainer)
			{
				continue;
			}
			foreach (BaseItem item in bar.Items)
			{
				if (!(item.Name != "") || !(item is DockContainerItem))
				{
					continue;
				}
				DockContainerItem dockContainerItem = item as DockContainerItem;
				if (dockContainerItem.Control != null)
				{
					try
					{
						hashtable.Add(dockContainerItem.Name, dockContainerItem.Control);
						dockContainerItem.Control = null;
					}
					catch
					{
					}
				}
			}
		}
		if (hashtable.Keys.Count == 0)
		{
			return null;
		}
		return hashtable;
	}

	internal void LoadDefinition(XmlDocument xmlDoc)
	{
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Invalid comparison between Unknown and I4
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Invalid comparison between Unknown and I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Invalid comparison between Unknown and I4
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Invalid comparison between Unknown and I4
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		XmlElement xmlElement = xmlDoc.FirstChild as XmlElement;
		if (xmlElement != null && (!xmlElement.HasAttribute(Class171.string_9) || XmlConvert.ToInt32(xmlElement.GetAttribute(Class171.string_9)) < 6))
		{
			return;
		}
		bool flag = false;
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		itemSerializationContext.Serializer = this;
		itemSerializationContext.HasDeserializeItemHandlers = ((ICustomSerialization)this).HasDeserializeItemHandlers;
		itemSerializationContext.HasSerializeItemHandlers = ((ICustomSerialization)this).HasSerializeItemHandlers;
		itemSerializationContext.hashtable_0 = GetDockControls();
		try
		{
			bool_31 = true;
			if (!SuspendLayout)
			{
				flag = true;
				SuspendLayout = true;
			}
			try
			{
				bool_28 = true;
				items_0.Clear();
				if (bool_36)
				{
					bars_0.Clear();
				}
				else
				{
					bars_0.method_0();
				}
				contextMenusCollection_0.Clear();
				hashtable_1.Clear();
			}
			finally
			{
				bool_28 = false;
			}
			DestroyAutoHidePanels();
			if (xmlElement == null)
			{
				if (flag)
				{
					SuspendLayout = false;
				}
				return;
			}
			if (xmlElement.Name != "dotnetbar")
			{
				throw new InvalidOperationException("Invalid file format (dotnetbar).");
			}
			if (xmlElement.HasAttribute("fullmenus"))
			{
				bool_11 = XmlConvert.ToBoolean(xmlElement.GetAttribute("fullmenus"));
			}
			else
			{
				bool_11 = false;
			}
			if (xmlElement.HasAttribute("fullmenushover"))
			{
				bool_12 = XmlConvert.ToBoolean(xmlElement.GetAttribute("fullmenushover"));
			}
			else
			{
				bool_12 = true;
			}
			if (xmlElement.HasAttribute("tooltips"))
			{
				bool_13 = XmlConvert.ToBoolean(xmlElement.GetAttribute("tooltips"));
			}
			else
			{
				bool_13 = true;
			}
			if (xmlElement.HasAttribute("scintooltip"))
			{
				bool_14 = XmlConvert.ToBoolean(xmlElement.GetAttribute("scintooltip"));
			}
			else
			{
				bool_14 = false;
			}
			if (xmlElement.HasAttribute("animation"))
			{
				if (XmlConvert.ToInt32(xmlElement.GetAttribute("animation")) != 6)
				{
					ePopupAnimation_0 = (ePopupAnimation)XmlConvert.ToInt32(xmlElement.GetAttribute("animation"));
				}
			}
			else
			{
				ePopupAnimation_0 = ePopupAnimation.SystemDefault;
			}
			foreach (XmlElement childNode in xmlElement.ChildNodes)
			{
				if (childNode.Name == "items")
				{
					foreach (XmlElement childNode2 in childNode.ChildNodes)
					{
						BaseItem baseItem = Class109.smethod_18(childNode2);
						if (baseItem != null)
						{
							itemSerializationContext.ItemXmlElement = childNode2;
							baseItem.Deserialize(itemSerializationContext);
							items_0.Add(baseItem);
							continue;
						}
						throw new InvalidOperationException("Invalid Item in file found (" + Class109.smethod_20(childNode2) + ").");
					}
				}
				else if (childNode.Name == "bars")
				{
					foreach (XmlElement childNode3 in childNode.ChildNodes)
					{
						Bar bar = new Bar();
						bar.Visible = false;
						bar.SetDesignMode(base.DesignMode);
						bars_0.Add(bar);
						bar.method_80(childNode3);
						((IOwnerBarSupport)this).AddShortcutsFromBar(bar);
					}
				}
				else if (childNode.Name == "popups")
				{
					foreach (XmlElement childNode4 in childNode.ChildNodes)
					{
						BaseItem baseItem2 = Class109.smethod_18(childNode4);
						if (baseItem2 != null)
						{
							itemSerializationContext.ItemXmlElement = childNode4;
							baseItem2.Deserialize(itemSerializationContext);
							contextMenusCollection_0.Add(baseItem2);
							continue;
						}
						throw new InvalidOperationException("Invalid Item in file found (" + Class109.smethod_20(childNode4) + ").");
					}
				}
				else if (childNode.Name == Class171.string_0 && bool_36)
				{
					itemSerializationContext.ItemXmlElement = childNode;
					if (dockSite_4 != null)
					{
						dockSite_4.GetDocumentUIManager().method_30(itemSerializationContext);
					}
				}
				else
				{
					if (!(childNode.Name == Class171.string_6))
					{
						continue;
					}
					itemSerializationContext.ItemXmlElement = childNode;
					DockStyle val = (DockStyle)Enum.Parse(typeof(DockStyle), childNode.GetAttribute(Class171.string_7));
					if ((int)val == 3)
					{
						if (dockSite_2 != null)
						{
							dockSite_2.GetDocumentUIManager().method_30(itemSerializationContext);
						}
					}
					else if ((int)val == 4)
					{
						if (dockSite_3 != null)
						{
							dockSite_3.GetDocumentUIManager().method_30(itemSerializationContext);
						}
					}
					else if ((int)val == 1)
					{
						if (dockSite_0 != null)
						{
							dockSite_0.GetDocumentUIManager().method_30(itemSerializationContext);
						}
					}
					else if ((int)val == 2 && dockSite_1 != null)
					{
						dockSite_1.GetDocumentUIManager().method_30(itemSerializationContext);
					}
				}
			}
		}
		finally
		{
			bool_31 = false;
			if (flag)
			{
				SuspendLayout = false;
			}
		}
		if (itemSerializationContext.hashtable_0 != null && itemSerializationContext.hashtable_0.Count > 0)
		{
			foreach (Control value in itemSerializationContext.hashtable_0.Values)
			{
				Control val2 = value;
				((Component)(object)val2).Dispose();
			}
		}
		((IOwner)this).InvokeDefinitionLoaded((object)this, new EventArgs());
		if (form_0 != null && bool_1)
		{
			bool_1 = false;
			OnMdiChildResize(form_0, new EventArgs());
		}
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

	public void SaveDefinition(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		SaveDefinition(xmlDocument);
		xmlDocument.Save(FileName);
	}

	internal void SaveDefinition(XmlDocument xmlDoc)
	{
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		itemSerializationContext.Serializer = this;
		itemSerializationContext.HasDeserializeItemHandlers = ((ICustomSerialization)this).HasDeserializeItemHandlers;
		itemSerializationContext.HasSerializeItemHandlers = ((ICustomSerialization)this).HasSerializeItemHandlers;
		XmlElement xmlElement = xmlDoc.CreateElement("dotnetbar");
		xmlElement.SetAttribute(Class171.string_9, "6");
		xmlDoc.AppendChild(xmlElement);
		xmlElement.SetAttribute("fullmenus", XmlConvert.ToString(bool_11));
		xmlElement.SetAttribute("fullmenushover", XmlConvert.ToString(bool_12));
		xmlElement.SetAttribute("tooltips", XmlConvert.ToString(bool_13));
		xmlElement.SetAttribute("scintooltip", XmlConvert.ToString(bool_14));
		xmlElement.SetAttribute("animation", XmlConvert.ToString((int)ePopupAnimation_0));
		XmlElement xmlElement2 = xmlDoc.CreateElement("items");
		xmlElement.AppendChild(xmlElement2);
		foreach (DictionaryEntry item in items_0)
		{
			BaseItem baseItem = item.Value as BaseItem;
			XmlElement xmlElement3 = xmlDoc.CreateElement("item");
			xmlElement2.AppendChild(xmlElement3);
			itemSerializationContext.ItemXmlElement = xmlElement3;
			baseItem.Serialize(itemSerializationContext);
		}
		XmlElement xmlElement4 = xmlDoc.CreateElement("bars");
		xmlElement.AppendChild(xmlElement4);
		if (dockSite_0 != null)
		{
			SerializeDockSite(dockSite_0, xmlElement);
		}
		if (dockSite_1 != null)
		{
			SerializeDockSite(dockSite_1, xmlElement);
		}
		if (dockSite_2 != null)
		{
			SerializeDockSite(dockSite_2, xmlElement);
		}
		if (dockSite_3 != null)
		{
			SerializeDockSite(dockSite_3, xmlElement);
		}
		if (bool_36 && dockSite_4 != null)
		{
			SerializeDockSite(dockSite_4, xmlElement);
		}
		if (dockSite_5 != null)
		{
			SerializeDockSite(dockSite_5, xmlElement4);
		}
		if (dockSite_6 != null)
		{
			SerializeDockSite(dockSite_6, xmlElement4);
		}
		if (dockSite_7 != null)
		{
			SerializeDockSite(dockSite_7, xmlElement4);
		}
		if (dockSite_8 != null)
		{
			SerializeDockSite(dockSite_8, xmlElement4);
		}
		foreach (Bar item2 in bars_0)
		{
			if (item2.DockSide == eDockSide.None)
			{
				XmlElement xmlElement5 = xmlDoc.CreateElement("bar");
				xmlElement4.AppendChild(xmlElement5);
				item2.method_78(xmlElement5);
			}
		}
		XmlElement xmlElement6 = xmlDoc.CreateElement("popups");
		xmlElement.AppendChild(xmlElement6);
		foreach (BaseItem item3 in contextMenusCollection_0)
		{
			XmlElement xmlElement7 = xmlDoc.CreateElement("item");
			xmlElement6.AppendChild(xmlElement7);
			itemSerializationContext.ItemXmlElement = xmlElement7;
			item3.Serialize(itemSerializationContext);
		}
	}

	public void LoadLayout(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(FileName);
		LoadLayout(xmlDocument);
	}

	internal void LoadLayout(XmlDocument xmlDoc)
	{
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Invalid comparison between Unknown and I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Invalid comparison between Unknown and I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Invalid comparison between Unknown and I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Invalid comparison between Unknown and I4
		if (!(xmlDoc.FirstChild is XmlElement xmlElement) || !xmlElement.HasAttribute(Class171.string_9) || XmlConvert.ToInt32(xmlElement.GetAttribute(Class171.string_9)) < 6)
		{
			return;
		}
		DestroyAutoHidePanels();
		bool flag = false;
		bool_32 = true;
		try
		{
			if (xmlElement.Name != "dotnetbarlayout")
			{
				throw new InvalidOperationException("Invalid file format (dotnetbarlayout expected).");
			}
			if (!SuspendLayout)
			{
				flag = true;
				SuspendLayout = true;
			}
			foreach (XmlElement childNode in xmlElement.ChildNodes)
			{
				if (childNode.Name == "bars")
				{
					foreach (XmlElement childNode2 in childNode.ChildNodes)
					{
						if (!(childNode2.Name != "bar"))
						{
							Bar bar = null;
							if (bars_0.Contains(bars_0[childNode2.GetAttribute("name")]))
							{
								bar = bars_0[childNode2.GetAttribute("name")];
							}
							else
							{
								bar = new Bar();
								Bars.Add(bar);
							}
							bar.method_86(childNode2);
						}
					}
				}
				else if (childNode.Name == Class171.string_0)
				{
					if (dockSite_4 != null)
					{
						dockSite_4.GetDocumentUIManager().method_29(childNode);
					}
				}
				else
				{
					if (!(childNode.Name == Class171.string_6))
					{
						continue;
					}
					DockStyle val = (DockStyle)Enum.Parse(typeof(DockStyle), childNode.GetAttribute(Class171.string_7));
					if ((int)val == 3)
					{
						if (dockSite_2 != null)
						{
							dockSite_2.GetDocumentUIManager().method_29(childNode);
						}
					}
					else if ((int)val == 4)
					{
						if (dockSite_3 != null)
						{
							dockSite_3.GetDocumentUIManager().method_29(childNode);
						}
					}
					else if ((int)val == 1)
					{
						if (dockSite_0 != null)
						{
							dockSite_0.GetDocumentUIManager().method_29(childNode);
						}
					}
					else if ((int)val == 2 && dockSite_1 != null)
					{
						dockSite_1.GetDocumentUIManager().method_29(childNode);
					}
				}
			}
			if (xmlElement.HasAttribute("zorder"))
			{
				RestoreDockSiteZOrder(xmlElement.GetAttribute("zorder"));
			}
			Bar[] array = new Bar[bars_0.Count];
			bars_0.CopyTo(array);
			Bar[] array2 = array;
			foreach (Bar bar2 in array2)
			{
				if (bar2.CustomBar && bar2.Items.Count == 0)
				{
					bar2.Visible = false;
					Bars.Remove(bar2);
					((Component)(object)bar2).Dispose();
				}
			}
		}
		finally
		{
			if (flag)
			{
				SuspendLayout = false;
			}
			bool_32 = false;
		}
		if (form_0 != null && bool_1)
		{
			bool_1 = false;
			OnMdiChildResize(form_0, new EventArgs());
		}
	}

	public void SaveLayout(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		SaveLayout(xmlDocument);
		xmlDocument.Save(FileName);
	}

	internal void SaveLayout(XmlDocument xmlDoc)
	{
		XmlElement xmlElement = xmlDoc.CreateElement("dotnetbarlayout");
		xmlElement.SetAttribute(Class171.string_9, "6");
		xmlDoc.AppendChild(xmlElement);
		xmlElement.SetAttribute("zorder", GetDockSitesZOrder());
		if (dockSite_0 != null)
		{
			SerializeDockSiteLayout(dockSite_0, xmlElement);
		}
		if (dockSite_1 != null)
		{
			SerializeDockSiteLayout(dockSite_1, xmlElement);
		}
		if (dockSite_2 != null)
		{
			SerializeDockSiteLayout(dockSite_2, xmlElement);
		}
		if (dockSite_3 != null)
		{
			SerializeDockSiteLayout(dockSite_3, xmlElement);
		}
		if (dockSite_4 != null)
		{
			SerializeDockSiteLayout(dockSite_4, xmlElement);
		}
		XmlElement xmlElement2 = xmlDoc.CreateElement("bars");
		xmlElement.AppendChild(xmlElement2);
		if (dockSite_5 != null)
		{
			SerializeDockSiteLayout(dockSite_5, xmlElement2);
		}
		if (dockSite_6 != null)
		{
			SerializeDockSiteLayout(dockSite_6, xmlElement2);
		}
		if (dockSite_7 != null)
		{
			SerializeDockSiteLayout(dockSite_7, xmlElement2);
		}
		if (dockSite_8 != null)
		{
			SerializeDockSiteLayout(dockSite_8, xmlElement2);
		}
		foreach (Bar item in bars_0)
		{
			if (item.DockSide == eDockSide.None && item.Name != "" && item.SaveLayoutChanges)
			{
				XmlElement xmlElement3 = xmlDoc.CreateElement("bar");
				xmlElement2.AppendChild(xmlElement3);
				item.method_85(xmlElement3);
			}
		}
	}

	private string GetDockSitesZOrder()
	{
		string text = "";
		if (dockSite_0 != null && ((Control)dockSite_0).get_Parent() != null)
		{
			text += ((Control)dockSite_0).get_Parent().get_Controls().IndexOf((Control)(object)dockSite_0);
		}
		text += ",";
		if (dockSite_1 != null && ((Control)dockSite_1).get_Parent() != null)
		{
			text += ((Control)dockSite_1).get_Parent().get_Controls().IndexOf((Control)(object)dockSite_1);
		}
		text += ",";
		if (dockSite_2 != null && ((Control)dockSite_2).get_Parent() != null)
		{
			text += ((Control)dockSite_2).get_Parent().get_Controls().IndexOf((Control)(object)dockSite_2);
		}
		text += ",";
		if (dockSite_3 != null)
		{
			text += ((Control)dockSite_3).get_Parent().get_Controls().IndexOf((Control)(object)dockSite_3);
		}
		return text;
	}

	private void RestoreDockSiteZOrder(string s)
	{
		try
		{
			string[] array = s.Split(new char[1] { ',' });
			if (array[0] != "" && dockSite_0 != null && ((Control)dockSite_0).get_Parent() != null)
			{
				((Control)dockSite_0).get_Parent().get_Controls().SetChildIndex((Control)(object)dockSite_0, int.Parse(array[0]));
			}
			if (array[1] != "" && dockSite_1 != null && ((Control)dockSite_1).get_Parent() != null)
			{
				((Control)dockSite_1).get_Parent().get_Controls().SetChildIndex((Control)(object)dockSite_1, int.Parse(array[1]));
			}
			if (array[2] != "" && dockSite_2 != null && ((Control)dockSite_2).get_Parent() != null)
			{
				((Control)dockSite_2).get_Parent().get_Controls().SetChildIndex((Control)(object)dockSite_2, int.Parse(array[2]));
			}
			if (array[3] != "" && dockSite_3 != null && ((Control)dockSite_3).get_Parent() != null)
			{
				((Control)dockSite_3).get_Parent().get_Controls().SetChildIndex((Control)(object)dockSite_3, int.Parse(array[3]));
			}
		}
		catch
		{
		}
	}

	private void SerializeDockSite(DockSite site, XmlElement xmlBars)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (!site.Boolean_2 && site.DocumentDockContainer == null)
		{
			foreach (Control item in (ArrangedElementCollection)((Control)site).get_Controls())
			{
				Control val = item;
				if (val is Bar bar)
				{
					XmlElement xmlElement = xmlBars.OwnerDocument.CreateElement("bar");
					xmlBars.AppendChild(xmlElement);
					bar.method_78(xmlElement);
				}
			}
			return;
		}
		site.GetDocumentUIManager().method_25(xmlBars);
	}

	private void SerializeDockSiteLayout(DockSite site, XmlElement xmlBars)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		if (!site.Boolean_2 && site.DocumentDockContainer == null)
		{
			foreach (Control item in (ArrangedElementCollection)((Control)site).get_Controls())
			{
				Control val = item;
				if (val is Bar bar && bar.Name != "" && bar.SaveLayoutChanges)
				{
					XmlElement xmlElement = xmlBars.OwnerDocument.CreateElement("bar");
					xmlBars.AppendChild(xmlElement);
					bar.method_85(xmlElement);
				}
			}
			return;
		}
		site.GetDocumentUIManager().method_26(xmlBars);
	}

	internal void SetFloatingBarVisible(bool bVisible)
	{
		foreach (Bar item in bars_0)
		{
			if (item.DockSide == eDockSide.None && item.Visible != bVisible)
			{
				item.Visible = bVisible;
			}
		}
	}

	public void Customize()
	{
		Customize(null);
	}

	public void Customize(DotNetBarManagerDesigner designerservices)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if (arrayList_1 == null)
		{
			arrayList_1 = new ArrayList();
		}
		Control topLevelControl = ((Control)form_1).get_TopLevelControl();
		Form val = (Form)(object)((topLevelControl is Form) ? topLevelControl : null);
		if (val == null)
		{
			val = ParentForm;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)val).get_Controls())
		{
			Control val2 = item;
			if (!(val2 is DockSite) && val2.get_Enabled())
			{
				val2.set_Enabled(false);
				arrayList_1.Add(val2);
			}
		}
		bool_42 = true;
		if (Items.Count == 0)
		{
			bool_41 = true;
			RescanCategories();
		}
		if (!bool_19)
		{
			if (frmCustomize_0 == null)
			{
				frmCustomize_0 = new frmCustomize(this);
			}
			if (eventHandler_21 != null)
			{
				eventHandler_21(frmCustomize_0, new EventArgs());
			}
			((Control)frmCustomize_0).Show();
			((Form)frmCustomize_0).set_Owner(ParentForm);
		}
		else if (eventHandler_21 != null)
		{
			eventHandler_21(null, new EventArgs());
		}
		else
		{
			MessageBox.Show("You need to add event handler for EnterCustomize event since your UseCustomCustomizeDialog property is set to true.");
		}
	}

	private void RescanCategories()
	{
		if (Bars.Count == 0)
		{
			return;
		}
		Items.Clear();
		foreach (Bar bar in Bars)
		{
			if (bar.LayoutType != 0)
			{
				continue;
			}
			foreach (BaseItem item in bar.Items)
			{
				AutoCategorizeItem(item);
			}
		}
	}

	private void AutoCategorizeItem(BaseItem item)
	{
		if (item.Category != "" && item.Name != "" && !Items.Contains(item.Name))
		{
			Items.Add(item.Copy());
		}
		foreach (BaseItem subItem in item.SubItems)
		{
			AutoCategorizeItem(subItem);
		}
	}

	public ArrayList GetItems(string ItemName)
	{
		ArrayList arrayList = new ArrayList(15);
		foreach (Bar item in bars_0)
		{
			if (!((Control)item).get_IsDisposed())
			{
				GetSubItemsByName(item.ItemsContainer, ItemName, arrayList);
			}
		}
		if (contextMenuBar_0 != null)
		{
			GetSubItemsByName(contextMenuBar_0.ItemsContainer, ItemName, arrayList);
		}
		return arrayList;
	}

	public ArrayList GetItems(string ItemName, bool FullSearch)
	{
		if (!FullSearch)
		{
			return GetItems(ItemName);
		}
		ArrayList arrayList = new ArrayList(15);
		foreach (Bar item in bars_0)
		{
			if (!((Control)item).get_IsDisposed())
			{
				GetSubItemsByName(item.ItemsContainer, ItemName, arrayList);
			}
		}
		foreach (DictionaryEntry item2 in items_0)
		{
			BaseItem baseItem = (BaseItem)item2.Value;
			if (baseItem.Name == ItemName)
			{
				arrayList.Add(baseItem);
			}
			GetSubItemsByName(baseItem, ItemName, arrayList);
		}
		foreach (BaseItem item3 in contextMenusCollection_0)
		{
			if (item3.Name == ItemName)
			{
				arrayList.Add(item3);
			}
			GetSubItemsByName(item3, ItemName, arrayList);
		}
		return arrayList;
	}

	public ArrayList GetItems(string itemName, Type itemType)
	{
		ArrayList result = new ArrayList(15);
		foreach (Bar item in bars_0)
		{
			if (!((Control)item).get_IsDisposed())
			{
				Class109.smethod_49(item.ItemsContainer, itemName, result, itemType, bool_3: false);
			}
		}
		if (contextMenuBar_0 != null && !((Control)contextMenuBar_0).get_IsDisposed())
		{
			Class109.smethod_49(contextMenuBar_0.ItemsContainer, itemName, result, itemType, bool_3: false);
		}
		return result;
	}

	public ArrayList GetItems(string itemName, Type itemType, bool fullSearch)
	{
		return GetItems(itemName, itemType, fullSearch, useGlobalName: false);
	}

	public ArrayList GetItems(string itemName, Type itemType, bool fullSearch, bool useGlobalName)
	{
		ArrayList arrayList = new ArrayList(15);
		if (bars_0 != null && !IsDisposed)
		{
			foreach (Bar item in bars_0)
			{
				if (!((Control)item).get_IsDisposed())
				{
					Class109.smethod_49(item.ItemsContainer, itemName, arrayList, itemType, useGlobalName);
				}
			}
			if (contextMenuBar_0 != null && !((Control)contextMenuBar_0).get_IsDisposed())
			{
				Class109.smethod_49(contextMenuBar_0.ItemsContainer, itemName, arrayList, itemType, useGlobalName);
			}
			if (fullSearch)
			{
				foreach (DictionaryEntry item2 in items_0)
				{
					BaseItem baseItem = (BaseItem)item2.Value;
					if (((!useGlobalName && baseItem.Name == itemName) || (useGlobalName && baseItem.GlobalName == itemName)) && (object)baseItem.GetType() == itemType)
					{
						arrayList.Add(baseItem);
					}
					Class109.smethod_49(baseItem, itemName, arrayList, itemType, useGlobalName);
				}
				{
					foreach (BaseItem item3 in contextMenusCollection_0)
					{
						if (((!useGlobalName && item3.Name == itemName) || (useGlobalName && item3.GlobalName == itemName)) && (object)item3.GetType() == itemType)
						{
							arrayList.Add(item3);
						}
						Class109.smethod_49(item3, itemName, arrayList, itemType, useGlobalName);
					}
					return arrayList;
				}
			}
			return arrayList;
		}
		return arrayList;
	}

	public BaseItem GetItem(string ItemName)
	{
		foreach (Bar item in bars_0)
		{
			if (!((Control)item).get_IsDisposed())
			{
				BaseItem subItemByName = GetSubItemByName(item.ItemsContainer, ItemName);
				if (subItemByName != null)
				{
					return subItemByName;
				}
			}
		}
		if (contextMenuBar_0 != null)
		{
			return GetSubItemByName(contextMenuBar_0.ItemsContainer, ItemName);
		}
		return null;
	}

	public BaseItem GetItem(string ItemName, bool FullSearch)
	{
		foreach (Bar item in bars_0)
		{
			if (!((Control)item).get_IsDisposed())
			{
				BaseItem subItemByName = GetSubItemByName(item.ItemsContainer, ItemName);
				if (subItemByName != null)
				{
					return subItemByName;
				}
			}
		}
		if (contextMenuBar_0 != null && !((Control)contextMenuBar_0).get_IsDisposed())
		{
			BaseItem subItemByName2 = GetSubItemByName(contextMenuBar_0.ItemsContainer, ItemName);
			if (subItemByName2 != null)
			{
				return subItemByName2;
			}
		}
		foreach (DictionaryEntry item2 in items_0)
		{
			BaseItem baseItem = (BaseItem)item2.Value;
			if (!(baseItem.Name == ItemName))
			{
				BaseItem subItemByName3 = GetSubItemByName(baseItem, ItemName);
				if (subItemByName3 != null)
				{
					return subItemByName3;
				}
				continue;
			}
			return baseItem;
		}
		foreach (BaseItem item3 in contextMenusCollection_0)
		{
			if (!(item3.Name == ItemName))
			{
				BaseItem subItemByName4 = GetSubItemByName(item3, ItemName);
				if (subItemByName4 != null)
				{
					return subItemByName4;
				}
				continue;
			}
			return item3;
		}
		return null;
	}

	private void GetSubItemsByName(BaseItem objParent, string ItemName, ArrayList list)
	{
		if (objParent is GenericItemContainer)
		{
			GenericItemContainer genericItemContainer = objParent as GenericItemContainer;
			if (genericItemContainer.DisplayMoreItem_0 != null)
			{
				GetSubItemsByName(genericItemContainer.DisplayMoreItem_0, ItemName, list);
			}
		}
		foreach (BaseItem subItem in objParent.SubItems)
		{
			if (subItem.Name == ItemName)
			{
				list.Add(subItem);
			}
			if (subItem.SubItems.Count > 0)
			{
				GetSubItemsByName(subItem, ItemName, list);
			}
		}
	}

	private void GetSubItemsByNameAndType(BaseItem objParent, string ItemName, ArrayList list, Type itemType)
	{
		if (objParent is GenericItemContainer)
		{
			GenericItemContainer genericItemContainer = objParent as GenericItemContainer;
			if (genericItemContainer.DisplayMoreItem_0 != null)
			{
				GetSubItemsByNameAndType(genericItemContainer.DisplayMoreItem_0, ItemName, list, itemType);
			}
		}
		if (objParent.SubItems == null)
		{
			return;
		}
		foreach (BaseItem subItem in objParent.SubItems)
		{
			if ((object)subItem.GetType() == itemType && subItem.Name == ItemName)
			{
				list.Add(subItem);
			}
			if (subItem.SubItems.Count > 0)
			{
				GetSubItemsByNameAndType(subItem, ItemName, list, itemType);
			}
		}
	}

	private BaseItem GetSubItemByName(BaseItem objParent, string ItemName)
	{
		if (objParent is GenericItemContainer)
		{
			GenericItemContainer genericItemContainer = objParent as GenericItemContainer;
			if (genericItemContainer.DisplayMoreItem_0 != null)
			{
				BaseItem subItemByName = GetSubItemByName(genericItemContainer.DisplayMoreItem_0, ItemName);
				if (subItemByName != null)
				{
					return subItemByName;
				}
			}
		}
		foreach (BaseItem subItem in objParent.SubItems)
		{
			if (!(subItem.Name == ItemName))
			{
				if (subItem.SubItems.Count > 0)
				{
					BaseItem subItemByName2 = GetSubItemByName(subItem, ItemName);
					if (subItemByName2 != null)
					{
						return subItemByName2;
					}
				}
				continue;
			}
			return subItem;
		}
		return null;
	}

	public void BeginModalDisplay()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (IsDisposed || bars_0 == null)
		{
			return;
		}
		foreach (Bar item in bars_0)
		{
			if (item.DockSide == eDockSide.None && ((Control)item).get_Parent() is Form && ((Control)item).get_Parent().get_Visible())
			{
				((Form)((Control)item).get_Parent()).set_TopMost(false);
			}
		}
	}

	public void EndModalDisplay()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (IsDisposed || bars_0 == null)
		{
			return;
		}
		foreach (Bar item in bars_0)
		{
			if (item.Visible && item.DockSide == eDockSide.None && ((Control)item).get_Parent() is Form && !((Form)((Control)item).get_Parent()).get_TopMost())
			{
				((Form)((Control)item).get_Parent()).set_TopMost(true);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void SetDesignMode(bool designmode)
	{
		foreach (Bar item in bars_0)
		{
			item.SetDesignMode(designmode);
			item.RecalcLayout();
		}
	}

	void IOwner.SetFocusItem(BaseItem objFocusItem)
	{
		if (baseItem_0 != null && baseItem_0 != objFocusItem)
		{
			baseItem_0.OnLostFocus();
		}
		baseItem_0 = objFocusItem;
		if (baseItem_0 != null)
		{
			baseItem_0.OnGotFocus();
		}
	}

	BaseItem IOwner.GetFocusItem()
	{
		return baseItem_0;
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

	[Browsable(false)]
	public void CustomizeClosing()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		bool_42 = false;
		if (arrayList_1 == null)
		{
			return;
		}
		foreach (Control item in arrayList_1)
		{
			Control val = item;
			val.set_Enabled(true);
		}
		arrayList_1.Clear();
		arrayList_1 = null;
		frmCustomize_0 = null;
		if (eventHandler_22 != null)
		{
			eventHandler_22(this, new EventArgs());
		}
		if (bool_41)
		{
			bool_41 = false;
			Items.Clear();
		}
	}

	void IOwner.DesignTimeContextMenu(BaseItem objItem)
	{
		if (frmCustomize_0 != null)
		{
			frmCustomize_0.DesignTimeContextMenu(objItem);
		}
		else if (bool_19)
		{
			OnCustomizeContextMenu(objItem, null);
		}
	}

	void IOwner.OnParentPositionChanging()
	{
		if (bars_0 == null)
		{
			return;
		}
		Bar[] array = new Bar[bars_0.Count];
		bars_0.CopyTo(array);
		Bar[] array2 = array;
		foreach (Bar bar in array2)
		{
			if (!((Control)bar).get_IsDisposed() && ((Control)bar).get_IsHandleCreated() && bar.BarState == eBarState.Floating)
			{
				Class92.PostMessage(((Control)bar).get_Handle().ToInt32(), 1125, 0, 0);
			}
		}
	}

	void IOwner.StartItemDrag(BaseItem objItem)
	{
		if (eventHandler_23 != null)
		{
			eventHandler_23(objItem, EventArgs.Empty);
		}
		if (frmCustomize_0 != null)
		{
			objItem.Expanded = false;
			frmCustomize_0.DragItem = objItem;
			Class92.PostMessage(((Control)frmCustomize_0).get_Handle().ToInt32(), 1731, 0, 0);
		}
	}

	internal void OnCustomizeContextMenu(object Sender, ButtonItem Parent)
	{
		if (customizeContextMenuEventHandler_0 != null)
		{
			customizeContextMenuEventHandler_0(Sender, new CustomizeContextMenuEventArgs(Parent));
		}
	}

	public void RegisterPopup(PopupItem objPopup)
	{
		if (arrayList_2.Contains(objPopup))
		{
			return;
		}
		if (!base.DesignMode)
		{
			if (!bool_0 && !bool_9)
			{
				Class107.smethod_0(this);
				bool_0 = true;
			}
			else if (bool_9 && class94_0 == null)
			{
				class94_0 = new Class94(this);
			}
		}
		else if (class94_0 == null)
		{
			class94_0 = new Class94(this);
		}
		arrayList_2.Add(objPopup);
		if (objPopup.GetOwner() == null)
		{
			objPopup.method_6(this);
		}
	}

	bool IOwnerMenuSupport.RelayMouseHover()
	{
		foreach (PopupItem item in arrayList_2)
		{
			Control popupControl = item.PopupControl;
			if (popupControl == null)
			{
				continue;
			}
			Point pt = popupControl.PointToClient(Control.get_MousePosition());
			if (popupControl.get_ClientRectangle().Contains(pt))
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

	public void UnregisterPopup(PopupItem objPopup)
	{
		if (arrayList_2.Contains(objPopup))
		{
			arrayList_2.Remove(objPopup);
		}
		if (arrayList_2.Count == 0 && class94_0 != null && (!bool_9 || base.DesignMode))
		{
			class94_0.Dispose();
			class94_0 = null;
		}
	}

	private void ProcessDelayedCommands()
	{
		if (!base.DesignMode || dockSite_0 == null || dockSite_1 == null || dockSite_2 == null || dockSite_3 == null || ((Control)dockSite_0).get_Parent() == null || ((Control)dockSite_1).get_Parent() == null || ((Control)dockSite_2).get_Parent() == null || ((Control)dockSite_3).get_Parent() == null)
		{
			return;
		}
		foreach (Bar bar in Bars)
		{
			bar.method_36();
		}
	}

	private void DestroyAutoHidePanels()
	{
		if (autoHidePanel_0 != null)
		{
			if (((Control)autoHidePanel_0).get_Parent() != null)
			{
				((Control)autoHidePanel_0).get_Parent().get_Controls().Remove((Control)(object)autoHidePanel_0);
			}
			((Component)(object)autoHidePanel_0).Dispose();
			autoHidePanel_0 = null;
		}
		if (autoHidePanel_1 != null)
		{
			if (((Control)autoHidePanel_1).get_Parent() != null)
			{
				((Control)autoHidePanel_1).get_Parent().get_Controls().Remove((Control)(object)autoHidePanel_1);
			}
			((Component)(object)autoHidePanel_1).Dispose();
			autoHidePanel_1 = null;
		}
		if (autoHidePanel_2 != null)
		{
			if (((Control)autoHidePanel_2).get_Parent() != null)
			{
				((Control)autoHidePanel_2).get_Parent().get_Controls().Remove((Control)(object)autoHidePanel_2);
			}
			((Component)(object)autoHidePanel_2).Dispose();
			autoHidePanel_2 = null;
		}
		if (autoHidePanel_3 != null)
		{
			if (((Control)autoHidePanel_3).get_Parent() != null)
			{
				((Control)autoHidePanel_3).get_Parent().get_Controls().Remove((Control)(object)autoHidePanel_3);
			}
			((Component)(object)autoHidePanel_3).Dispose();
			autoHidePanel_3 = null;
		}
	}

	private void DockSiteParentChanged(object sender, EventArgs e)
	{
		Control val = (Control)((sender is Control) ? sender : null);
		if (val != null)
		{
			if (val == dockSite_0 && val.get_Parent() is UserControl)
			{
				SetupParentUserControl();
			}
			val.remove_ParentChanged((EventHandler)DockSiteParentChanged);
			if ((val.get_Parent() != null && val.get_Parent().FindForm() != null) || base.DesignMode || !(val.get_Parent() is UserControl))
			{
				BarStreamLoad();
				ProcessDelayedCommands();
			}
		}
	}

	private void SetupParentUserControl()
	{
		if (((dockSite_0 != null && ((Control)dockSite_0).get_Parent() is UserControl) || control_0 != null) && !base.DesignMode)
		{
			Control val = null;
			val = (Control)((dockSite_0 == null) ? ((object)control_0) : ((object)/*isinst with value type is only supported in some contexts*/));
			Form val2 = val.FindForm();
			if (val2 != null)
			{
				ParentForm = val2;
			}
			else
			{
				val.add_ParentChanged((EventHandler)ParentUserControlParentChanged);
			}
		}
	}

	private void ParentUserControlParentChanged(object sender, EventArgs e)
	{
		Control val = null;
		val = (Control)((dockSite_0 == null) ? ((object)control_0) : ((object)/*isinst with value type is only supported in some contexts*/));
		Control val2 = (Control)((sender is Control) ? sender : null);
		if (val2 != null)
		{
			val2.remove_ParentChanged((EventHandler)ParentUserControlParentChanged);
		}
		Form val3 = val.FindForm();
		if (val3 != null)
		{
			ParentForm = val3;
		}
		else
		{
			if (val.get_Parent() == null)
			{
				return;
			}
			while (val2.get_Parent() != null)
			{
				val2 = val2.get_Parent();
			}
			if (val2 is PopupContainerControl)
			{
				PopupContainerControl popupContainerControl = val2 as PopupContainerControl;
				if (popupContainerControl.ParentItem != null && popupContainerControl.ParentItem.ContainerControl is Control)
				{
					object containerControl = popupContainerControl.ParentItem.ContainerControl;
					Control val4 = (Control)((containerControl is Control) ? containerControl : null);
					Form val5 = val4.FindForm();
					if (val5 != null)
					{
						ParentForm = val5;
						if (!bool_23)
						{
							BarStreamLoad(bForceLoad: true);
						}
						return;
					}
				}
			}
			val2.add_ParentChanged((EventHandler)ParentUserControlParentChanged);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColorScheme()
	{
		return colorScheme_0.SchemeChanged;
	}

	public void ResetColorScheme()
	{
		colorScheme_0.Refresh();
		foreach (Bar item in bars_0)
		{
			((Control)item).Invalidate();
		}
	}

	MdiClient IOwner.GetMdiClient(Form MdiForm)
	{
		return Class109.smethod_58(MdiForm);
	}

	public void MdiChildActivated()
	{
		OnMdiChildActivate(ParentForm, new EventArgs());
	}

	private void OnMdiChildActivate(object sender, EventArgs e)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		if (form_0 != null)
		{
			((Control)form_0).remove_Resize((EventHandler)OnMdiChildResize);
			((Control)form_0).remove_VisibleChanged((EventHandler)OnMdiChildVisibleChanged);
		}
		form_0 = null;
		if (ParentForm.get_ActiveMdiChild() != null)
		{
			if (GetMenuBar() != null)
			{
				form_0 = ParentForm.get_ActiveMdiChild();
				((Control)form_0).add_Resize((EventHandler)OnMdiChildResize);
				((Control)form_0).add_VisibleChanged((EventHandler)OnMdiChildVisibleChanged);
				if ((int)form_0.get_WindowState() == 2 || bool_1)
				{
					OnMdiChildResize(form_0, null);
				}
			}
		}
		else if (bool_1)
		{
			GetMenuBar()?.method_89(bool_67: true);
		}
	}

	private void OnMdiChildVisibleChanged(object sender, EventArgs e)
	{
		if (form_0 != null && !((Control)form_0).get_Visible() && bool_1)
		{
			GetMenuBar()?.method_89(bool_67: true);
			bool_1 = false;
		}
	}

	private void OnMdiChildResize(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		Bar menuBar = GetMenuBar();
		bool flag = false;
		if (form_0 != null && (int)form_0.get_WindowState() != 2)
		{
			if (bool_1 && bool_20)
			{
				if (e == null)
				{
					bool_1 = false;
					return;
				}
				menuBar?.method_89(bool_67: false);
				flag = true;
			}
			bool_1 = false;
			if (menuBar != null)
			{
				((Control)menuBar).Refresh();
			}
			return;
		}
		if (!bool_1)
		{
			if (bool_20)
			{
				if (menuBar == null)
				{
					return;
				}
				menuBar.method_90(form_0, bool_67: false);
				flag = true;
			}
			bool_1 = true;
		}
		if (menuBar != null && flag)
		{
			menuBar.RecalcLayout();
		}
	}

	private Bar GetMenuBar()
	{
		if (bars_0 == null)
		{
			return null;
		}
		try
		{
			foreach (Bar item in bars_0)
			{
				if (item.MenuBar && item.Visible)
				{
					return item;
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	private void OnMdiSetMenu(object sender, EventArgs e)
	{
		Class33 @class = sender as Class33;
		if (GetMenuBar() != null || bool_35)
		{
			@class.bool_0 = true;
		}
	}

	bool Interface5.OnSysKeyDown(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected I4, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected I4, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Invalid comparison between Unknown and I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Invalid comparison between Unknown and I4
		if (bool_5 && !base.DesignMode)
		{
			Bar menuBar = GetMenuBar();
			if (menuBar != null && menuBar.ItemsContainer != null && !menuBar.ItemsContainer.DesignMode)
			{
				GenericItemContainer itemsContainer = menuBar.ItemsContainer;
				if (itemsContainer == null)
				{
					return false;
				}
				if (wParam.ToInt32() != 18 && (wParam.ToInt32() != 121 || bool_24 || ((int)Control.get_ModifierKeys() != 0 && (int)Control.get_ModifierKeys() != 262144)))
				{
					if ((int)Control.get_ModifierKeys() != 0 || (wParam.ToInt32() >= 112 && wParam.ToInt32() <= 123))
					{
						int key = Control.get_ModifierKeys() | wParam.ToInt32();
						if (ProcessShortcut((eShortcut)key))
						{
							return true;
						}
					}
					bool_2 = true;
					if (wParam.ToInt32() >= 27 && wParam.ToInt32() <= 111)
					{
						int num = (int)Class92.MapVirtualKey((uint)(int)wParam, 2u);
						if (num == 0)
						{
							num = wParam.ToInt32();
						}
						if (itemsContainer.method_27(num))
						{
							return true;
						}
					}
				}
				else if (itemsContainer.ExpandedItem() != null && (((Control)menuBar).get_Focused() || menuBar.Boolean_11))
				{
					menuBar.ReleaseFocus();
					menuBar.Boolean_11 = false;
					bool_2 = true;
					return true;
				}
			}
			else if (menuBar == null && !base.DesignMode && ((int)Control.get_ModifierKeys() != 0 || (wParam.ToInt32() >= 112 && wParam.ToInt32() <= 123)))
			{
				int key2 = Control.get_ModifierKeys() | wParam.ToInt32();
				if (ProcessShortcut((eShortcut)key2))
				{
					return true;
				}
			}
			if ((Control.get_ModifierKeys() & 0x40000) == 262144 && wParam.ToInt32() > 27 && bars_0 != null)
			{
				bool_2 = true;
				int num2 = 0;
				if ((Control.get_ModifierKeys() & 0x10000) == 65536)
				{
					try
					{
						byte[] array = new byte[256];
						if (Class92.GetKeyboardState(array))
						{
							byte[] array2 = new byte[2];
							if (Class92.ToAscii((uint)(int)wParam, 0u, array, array2, 0u) != 0)
							{
								num2 = array2[0];
							}
						}
					}
					catch (Exception)
					{
						num2 = 0;
					}
				}
				if (num2 == 0)
				{
					num2 = (int)Class92.MapVirtualKey((uint)(int)wParam, 2u);
				}
				if (num2 != 0)
				{
					foreach (Bar item in bars_0)
					{
						if (item.ItemsContainer != null && !item.ItemsContainer.DesignMode && ((Control)item).get_Enabled() && item.Visible && item.ItemsContainer.method_27(num2))
						{
							return true;
						}
					}
				}
			}
			return false;
		}
		return false;
	}

	bool Interface5.OnSysKeyUp(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		if (bool_5 && !base.DesignMode)
		{
			if (wParam.ToInt32() == 18 || wParam.ToInt32() == 121)
			{
				if (bool_2)
				{
					bool_2 = false;
					return false;
				}
				if (bool_3)
				{
					bool_3 = false;
					return true;
				}
				foreach (Bar bar in Bars)
				{
					if (bar.Visible)
					{
						bar.method_112();
					}
				}
				if (wParam.ToInt32() == 18 || (wParam.ToInt32() == 121 && !bool_24))
				{
					Bar menuBar = GetMenuBar();
					if (menuBar != null && !menuBar.ItemsContainer.DesignMode)
					{
						if (menuBar.Boolean_11)
						{
							menuBar.Boolean_11 = false;
						}
						else
						{
							menuBar.Boolean_11 = true;
						}
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	bool Interface5.OnMouseWheel(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		return false;
	}

	bool Interface5.OnKeyDown(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected I4, but got Unknown
		bool designMode = base.DesignMode;
		if (arrayList_2.Count > 0 && ((BaseItem)arrayList_2[arrayList_2.Count - 1]).Parent == null)
		{
			PopupItem popupItem = (PopupItem)arrayList_2[arrayList_2.Count - 1];
			Control popupControl = popupItem.PopupControl;
			Control val = Control.FromChildHandle(hWnd);
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
				Keys val2 = (Keys)Class92.MapVirtualKey((uint)(int)wParam, 2u);
				if ((int)val2 == 0)
				{
					val2 = (Keys)wParam.ToInt32();
				}
				popupItem.InternalKeyDown(new KeyEventArgs(val2));
			}
			if (flag2)
			{
				return false;
			}
			return !designMode;
		}
		if (FocusedBar != null && !designMode)
		{
			bool flag3 = true;
			Control val3 = Control.FromChildHandle(hWnd);
			if (val3 != null)
			{
				while (val3.get_Parent() != null)
				{
					val3 = val3.get_Parent();
				}
				if ((val3 is MenuPanel || val3 is Bar || val3 is PopupContainer || val3 is PopupContainerControl) && val3.get_Handle() != hWnd)
				{
					flag3 = false;
				}
			}
			if (flag3)
			{
				Keys val4 = (Keys)Class92.MapVirtualKey((uint)(int)wParam, 2u);
				if ((int)val4 == 0)
				{
					val4 = (Keys)wParam.ToInt32();
				}
				FocusedBar.method_70(new KeyEventArgs(val4));
				return true;
			}
		}
		else if (wParam.ToInt32() == 27)
		{
			foreach (Bar bar in Bars)
			{
				if (bar.Boolean_6)
				{
					bar.method_49();
					break;
				}
			}
		}
		if ((!bool_5 && !(Form.get_ActiveForm() is Form0)) || designMode)
		{
			return false;
		}
		if (wParam.ToInt32() < 112 && (int)Control.get_ModifierKeys() == 0 && (lParam.ToInt32() & 0x1000000000L) == 0L && wParam.ToInt32() != 46 && wParam.ToInt32() != 45)
		{
			return false;
		}
		int key = Control.get_ModifierKeys() | wParam.ToInt32();
		return ProcessShortcut((eShortcut)key);
	}

	private bool ProcessShortcut(eShortcut key)
	{
		bool result = Class109.smethod_5(key, hashtable_1);
		if (shortcutsCollection_0 != null && shortcutsCollection_0.Contains(key))
		{
			result = false;
		}
		if (!bool_21)
		{
			return result;
		}
		return false;
	}

	bool Interface5.OnMouseDown(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		if (arrayList_2 != null && !base.DesignMode)
		{
			if (arrayList_2.Count == 0)
			{
				Bar menuBar = GetMenuBar();
				if (menuBar != null && menuBar.Boolean_11 && hWnd != ((Control)menuBar).get_Handle())
				{
					menuBar.Boolean_11 = false;
				}
				return false;
			}
			for (int num = arrayList_2.Count - 1; num >= 0; num--)
			{
				PopupItem popupItem = arrayList_2[num] as PopupItem;
				object containerControl = popupItem.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				bool flag;
				if (!(flag = popupItem.IsAnyOnHandle(hWnd.ToInt32())))
				{
					Control val2 = Control.FromChildHandle(hWnd);
					if (val2 != null)
					{
						if (val2 is MenuPanel)
						{
							flag = true;
						}
						else
						{
							while (val2.get_Parent() != null)
							{
								val2 = val2.get_Parent();
								if (((object)val2).GetType().FullName!.IndexOf("DropDownHolder") >= 0 || val2 is MenuPanel || val2 is PopupContainerControl)
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							flag = popupItem.IsAnyOnHandle(val2.get_Handle().ToInt32());
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
					Control val3 = popupItem.PopupControl;
					if (val3 != null)
					{
						while (val3.get_Parent() != null)
						{
							val3 = val3.get_Parent();
						}
					}
					if (val3 != null && val3.get_Bounds().Contains(Control.get_MousePosition()))
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (val != null && hWnd != val.get_Handle() && !flag)
				{
					if (popupItem.Parent != null)
					{
						_ = base.DesignMode;
					}
					popupItem.Expanded = !popupItem.Expanded;
					if (!popupItem.Expanded && popupItem.Parent != null)
					{
						popupItem.Parent.AutoExpand = false;
					}
				}
				else if (val == null && !flag)
				{
					popupItem.ClosePopup();
				}
				if (arrayList_2.Count == 0)
				{
					break;
				}
			}
			return false;
		}
		return false;
	}

	bool Interface5.OnMouseMove(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		if (arrayList_2.Count > 0)
		{
			bool flag = true;
			{
				foreach (BaseItem item in arrayList_2)
				{
					Control popupControl = ((PopupItem)item).PopupControl;
					Control val = null;
					if (item.Parent != null)
					{
						object containerControl = item.Parent.ContainerControl;
						val = (Control)((containerControl is Control) ? containerControl : null);
					}
					Control val2 = Control.FromChildHandle(hWnd);
					if (val2 is MenuPanel && val2.get_Parent() != null)
					{
						val2 = val2.get_Parent();
					}
					else if (val2 != null)
					{
						Control val3 = val2;
						while (val3.get_Parent() != null)
						{
							val3 = val3.get_Parent();
						}
						if (val3 is Bar || val3 is PopupContainerControl || val3 is PopupContainer)
						{
							val2 = val3;
						}
					}
					if (popupControl != null && val2 != null && popupControl != val2 && !item.IsAnyOnHandle(val2.get_Handle().ToInt32()) && (val == null || (val != null && val != val2)))
					{
						flag = flag;
						continue;
					}
					return false;
				}
				return flag;
			}
		}
		return false;
	}

	void IOwnerBarSupport.BarContextMenu(Control bar, MouseEventArgs e)
	{
		if (!ShowCustomizeContextMenu || frmCustomize_0 != null || base.DesignMode)
		{
			return;
		}
		popupItem_0 = new ButtonItem("sys_customizecontextnmenu");
		eDotNetBarStyle style = eDotNetBarStyle.OfficeXP;
		if (bars_0.Count > 0)
		{
			style = bars_0[0].Style;
		}
		popupItem_0.Style = style;
		ButtonItem buttonItem;
		foreach (Bar item in bars_0)
		{
			if ((item.LayoutType != eLayoutType.DockContainer || item.Items.Count != 0) && item.CanHide && ((item.LayoutType == eLayoutType.DockContainer && item.CanCustomize) || item.LayoutType != eLayoutType.DockContainer) && ((Control)item).get_Text() != "")
			{
				buttonItem = new ButtonItem();
				buttonItem.Text = ((Control)item).get_Text();
				buttonItem.Checked = item.Visible || item.AutoHide;
				buttonItem.method_11(bool_22: true);
				buttonItem.Tag = item;
				buttonItem.Click += CustomizeItemClick;
				popupItem_0.SubItems.Add(buttonItem);
			}
		}
		buttonItem = new ButtonItem("customize");
		if (popupItem_0.SubItems.Count > 0)
		{
			buttonItem.BeginGroup = true;
		}
		using (Class264 @class = new Class264(this))
		{
			buttonItem.Text = @class.method_1(LocalizationKeys.CustomizeItemCustomize);
		}
		buttonItem.method_11(bool_22: true);
		buttonItem.Style = style;
		buttonItem.Click += CustomizeItemClick;
		popupItem_0.SubItems.Add(buttonItem);
		RegisterPopup(popupItem_0);
		popupItem_0.PopupMenu(bar.PointToScreen(new Point(e.get_X(), e.get_Y())));
	}

	private void CustomizeItemClick(object sender, EventArgs e)
	{
		BaseItem baseItem = sender as BaseItem;
		popupItem_0.Expanded = false;
		if (baseItem.Name == "customize")
		{
			Customize();
		}
		else
		{
			Bar bar = baseItem.Tag as Bar;
			if (bar.AutoHide)
			{
				bar.AutoHide = false;
			}
			if (!bar.Visible && bar.LayoutType == eLayoutType.DockContainer && bar.VisibleItemCount == 0 && bar.Items.Count > 0)
			{
				bar.Items[0].Visible = true;
			}
			bar.Visible = !bar.Visible;
			bar.RecalcLayout();
			bar.method_65();
		}
		popupItem_0.Dispose();
		popupItem_0 = null;
	}

	public void ResetUsageData()
	{
		foreach (Bar item in bars_0)
		{
			foreach (BaseItem item2 in item.Items)
			{
				if (item2 is IPersonalizedMenuItem personalizedMenuItem && personalizedMenuItem.MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed)
				{
					personalizedMenuItem.RecentlyUsed = false;
				}
				if (item2.SubItems.Count > 0)
				{
					ResetItemUsageData(item2);
				}
			}
		}
	}

	private void ResetItemUsageData(BaseItem item)
	{
		foreach (BaseItem subItem in item.SubItems)
		{
			if (subItem is IPersonalizedMenuItem personalizedMenuItem && personalizedMenuItem.MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed)
			{
				personalizedMenuItem.RecentlyUsed = false;
			}
			if (subItem.SubItems.Count > 0)
			{
				ResetItemUsageData(subItem);
			}
		}
	}

	void IOwnerMenuSupport.ClosePopups()
	{
		ClosePopups();
	}

	private void ClosePopups()
	{
		ArrayList arrayList = new ArrayList(arrayList_2);
		foreach (PopupItem item in arrayList)
		{
			item.ClosePopup();
		}
	}

	void IOwnerItemEvents.InvokeItemTextChanged(BaseItem item, EventArgs e)
	{
		if (eventHandler_20 != null)
		{
			eventHandler_20(item, e);
		}
	}

	void IOwner.InvokeResetDefinition(BaseItem item, EventArgs e)
	{
		if (eventHandler_17 != null)
		{
			eventHandler_17(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupContainerLoad(PopupItem item, EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupContainerUnload(PopupItem item, EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupOpen(PopupItem item, PopupOpenEventArgs e)
	{
		if (popupOpenEventHandler_0 != null)
		{
			popupOpenEventHandler_0(item, e);
		}
		int_0++;
	}

	void IOwnerMenuSupport.InvokePopupClose(PopupItem item, EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(item, e);
		}
		if (int_0 > int_1 || int_1 <= 0)
		{
			int_0 = 0;
			RemindForm remindForm = new RemindForm();
			remindForm.method_0();
		}
	}

	void IOwnerMenuSupport.InvokePopupShowing(PopupItem item, EventArgs e)
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(item, e);
		}
	}

	void IOwnerItemEvents.InvokeExpandedChange(BaseItem item, EventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(item, e);
		}
	}

	void IOwnerBarSupport.InvokeBarDock(Bar bar, EventArgs e)
	{
		if (eventHandler_6 != null)
		{
			eventHandler_6(bar, e);
		}
	}

	void IOwnerBarSupport.InvokeBarUndock(Bar bar, EventArgs e)
	{
		if (eventHandler_7 != null)
		{
			eventHandler_7(bar, e);
		}
	}

	void IOwnerBarSupport.InvokeBeforeDockTabDisplay(BaseItem item, EventArgs e)
	{
		if (eventHandler_8 != null)
		{
			eventHandler_8(item, e);
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
			baseItem_2 = item;
			if (timer_0 == null)
			{
				timer_0 = new Timer();
			}
			timer_0.set_Interval(item.ClickRepeatInterval);
			timer_0.add_Tick((EventHandler)ClickTimerTick);
			timer_0.Start();
		}
	}

	void IOwnerItemEvents.InvokeMouseEnter(BaseItem item, EventArgs e)
	{
		if (eventHandler_10 != null)
		{
			eventHandler_10(item, e);
		}
	}

	void IOwnerItemEvents.InvokeMouseLeave(BaseItem item, EventArgs e)
	{
		if (eventHandler_11 != null)
		{
			eventHandler_11(item, e);
		}
	}

	void IOwnerItemEvents.InvokeMouseHover(BaseItem item, EventArgs e)
	{
		if (eventHandler_12 != null)
		{
			eventHandler_12(item, e);
		}
	}

	void IOwnerItemEvents.InvokeMouseMove(BaseItem item, MouseEventArgs e)
	{
		if (mouseEventHandler_2 != null)
		{
			mouseEventHandler_2.Invoke((object)item, e);
		}
	}

	private void ClickTimerTick(object sender, EventArgs e)
	{
		if (baseItem_2 != null)
		{
			baseItem_2.RaiseClick();
		}
		else
		{
			timer_0.Stop();
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

	void IOwnerItemEvents.InvokeGotFocus(BaseItem item, EventArgs e)
	{
		if (eventHandler_14 != null)
		{
			eventHandler_14(item, e);
		}
	}

	void IOwnerItemEvents.InvokeLostFocus(BaseItem item, EventArgs e)
	{
		if (eventHandler_13 != null)
		{
			eventHandler_13(item, e);
		}
	}

	void IOwner.InvokeUserCustomize(object sender, EventArgs e)
	{
		if (eventHandler_15 != null)
		{
			eventHandler_15(sender, e);
		}
	}

	void IOwner.InvokeEndUserCustomize(object sender, EndUserCustomizeEventArgs e)
	{
		if (endUserCustomizeEventHandler_0 != null)
		{
			endUserCustomizeEventHandler_0(sender, e);
		}
	}

	void IOwner.InvokeDefinitionLoaded(object sender, EventArgs e)
	{
		if (eventHandler_16 != null)
		{
			eventHandler_16(sender, e);
		}
	}

	void IOwnerItemEvents.InvokeItemRemoved(BaseItem item, BaseItem parent)
	{
		if (itemRemovedEventHandler_0 != null)
		{
			itemRemovedEventHandler_0(item, new ItemRemovedEventArgs(parent));
		}
	}

	void IOwnerItemEvents.InvokeItemAdded(BaseItem item, EventArgs e)
	{
		if (eventHandler_18 != null)
		{
			eventHandler_18(item, e);
		}
	}

	void IOwnerItemEvents.InvokeContainerLoadControl(BaseItem item, EventArgs e)
	{
		if (eventHandler_19 != null)
		{
			eventHandler_19(item, e);
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

	void IOwnerItemEvents.InvokeOptionGroupChanging(BaseItem item, OptionGroupChangingEventArgs e)
	{
		if (optionGroupChangingEventHandler_0 != null)
		{
			optionGroupChangingEventHandler_0(item, e);
		}
	}

	void IOwnerItemEvents.InvokeCheckedChanged(ButtonItem item, EventArgs e)
	{
		if (eventHandler_28 != null)
		{
			eventHandler_28(item, e);
		}
	}

	void IOwnerItemEvents.InvokeToolTipShowing(object sender, EventArgs e)
	{
		if (eventHandler_25 != null)
		{
			eventHandler_25(sender, e);
		}
	}

	void IOwnerBarSupport.InvokeDockTabChange(Bar bar, DockTabChangeEventArgs e)
	{
		if (dockTabChangeEventHandler_0 != null)
		{
			dockTabChangeEventHandler_0(bar, e);
		}
	}

	void IOwnerBarSupport.InvokeBarClosing(Bar bar, BarClosingEventArgs e)
	{
		if (barClosingEventHandler_0 != null)
		{
			barClosingEventHandler_0(bar, e);
		}
	}

	void IOwnerBarSupport.InvokeBarTearOff(Bar bar, EventArgs e)
	{
		if (eventHandler_24 != null)
		{
			eventHandler_24(bar, e);
		}
	}

	void IOwnerBarSupport.InvokeAutoHideChanged(Bar bar, EventArgs e)
	{
		if (eventHandler_9 != null)
		{
			eventHandler_9(bar, e);
		}
	}

	void IOwnerBarSupport.InvokeAutoHideDisplay(Bar bar, AutoHideDisplayEventArgs e)
	{
		if (autoHideDisplayEventHandler_0 != null)
		{
			autoHideDisplayEventHandler_0(bar, e);
		}
	}

	internal bool IsHandleOwnedByPopup(IntPtr handle)
	{
		if (arrayList_2.Count > 0)
		{
			foreach (BaseItem item in arrayList_2)
			{
				Control popupControl = ((PopupItem)item).PopupControl;
				if ((popupControl != null && popupControl.get_Handle() == handle) || item.IsAnyOnHandle(handle.ToInt32()))
				{
					return true;
				}
			}
		}
		return false;
	}

	void IOwnerLocalize.InvokeLocalizeString(LocalizeEventArgs e)
	{
		if (localizeStringEventHandler_0 != null)
		{
			localizeStringEventHandler_0(this, e);
		}
	}

	public string GetContextMenuEx(Control control)
	{
		string text = (string)hashtable_2[control];
		if (text == null)
		{
			text = string.Empty;
		}
		return text;
	}

	public void SetContextMenuEx(Control control, string value)
	{
		if (value == null)
		{
			value = string.Empty;
		}
		if (value.Length == 0)
		{
			if (hashtable_2.Contains(control))
			{
				hashtable_2.Remove(control);
			}
		}
		else if (hashtable_2.Contains(control))
		{
			hashtable_2[control] = value;
		}
		else
		{
			hashtable_2[control] = value;
		}
	}
}

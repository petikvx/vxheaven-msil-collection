using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.Ribbon;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

[ToolboxBitmap(typeof(RibbonControl), "Ribbon.RibbonControl.ico")]
[ToolboxItem(true)]
[Designer(typeof(RibbonControlDesigner))]
[ComVisible(false)]
public class RibbonControl : ContainerControl
{
	private const string string_0 = "syscustomizepopupmenu";

	private CustomizeMenuPopupEventHandler customizeMenuPopupEventHandler_0;

	private CustomizeMenuPopupEventHandler customizeMenuPopupEventHandler_1;

	private CustomizeMenuPopupEventHandler customizeMenuPopupEventHandler_2;

	private DotNetBarManager.LocalizeStringEventHandler localizeStringEventHandler_0;

	private EventHandler eventHandler_0;

	private QatCustomizeDialogEventHandler qatCustomizeDialogEventHandler_0;

	private QatCustomizeDialogEventHandler qatCustomizeDialogEventHandler_1;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private CancelEventHandler cancelEventHandler_0;

	private EventHandler eventHandler_3;

	private RibbonPopupCloseEventHandler ribbonPopupCloseEventHandler_0;

	private EventHandler eventHandler_4;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private EventHandler eventHandler_5;

	private RibbonStrip ribbonStrip_0;

	private bool bool_0 = true;

	private bool bool_1 = true;

	private Form form_0;

	private bool bool_2;

	private bool bool_3;

	private ShadowPaintInfo shadowPaintInfo_0;

	private bool bool_4 = true;

	private bool bool_5 = true;

	private eCategorizeMode eCategorizeMode_0;

	private Control7 control7_0;

	private bool bool_6;

	private int int_0 = 2;

	private Class242 class242_0;

	private bool bool_7;

	private RibbonLocalization ribbonLocalization_0 = new RibbonLocalization();

	private Form form_1;

	private bool bool_8 = true;

	private bool bool_9;

	private bool bool_10;

	private int int_1;

	private bool bool_11;

	private RibbonPanel ribbonPanel_0;

	private bool bool_12 = true;

	private ContextMenuBar contextMenuBar_0;

	private SubItemsCollection subItemsCollection_0 = new SubItemsCollection(null);

	public static readonly string SysQatCustomizeItemName = "sysCustomizeQuickAccessToolbar";

	public static readonly string SysQatAddToItemName = "sysAddToQuickAccessToolbar";

	public static readonly string SysQatRemoveFromItemName = "sysRemoveFromQuickAccessToolbar";

	public static readonly string SysQatPlaceItemName = "sysPlaceQuickAccessToolbar";

	public static readonly string SysMinimizeRibbon = "sysMinimizeRibbon";

	public static readonly string SysMaximizeRibbon = "sysMaximizeRibbon";

	public static readonly string SysQatCustomizeLabelName = "sysCustomizeQuickAccessToolbarLabel";

	public static readonly string SysFrequentlyQatNamePart = "sysQatFrequent_";

	private int int_2;

	private bool bool_13;

	private eOffice2007ColorScheme eOffice2007ColorScheme_0;

	private bool bool_14;

	private Timer timer_0;

	private IntPtr intptr_0 = IntPtr.Zero;

	private IntPtr intptr_1 = IntPtr.Zero;

	private bool bool_15;

	private bool bool_16;

	private int int_3;

	private bool bool_17;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public SubItemsCollection QatFrequentCommands => subItemsCollection_0;

	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Behavior")]
	[Description("Indicates whether KeyTips functionality is enabled.")]
	public bool KeyTipsEnabled
	{
		get
		{
			return ribbonStrip_0.KeyTipsEnabled;
		}
		set
		{
			ribbonStrip_0.KeyTipsEnabled = value;
		}
	}

	internal bool Boolean_0 => ((Component)this).DesignMode;

	[Category("Behaviour")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether merge functionality is enabled for the control.")]
	public bool AllowMerge
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

	[Description("Indicates whether control height is set automatically.")]
	[DefaultValue(false)]
	[Category("Layout")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override bool AutoSize
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			method_0();
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	[Browsable(true)]
	public bool AntiAlias
	{
		get
		{
			return ribbonStrip_0.AntiAlias;
		}
		set
		{
			ribbonStrip_0.AntiAlias = value;
			((Control)this).Invalidate();
		}
	}

	private bool Boolean_1
	{
		get
		{
			if (!((Component)this).DesignMode && CanSupportGlass)
			{
				return Class51.Boolean_0;
			}
			return false;
		}
	}

	[Description("Indicates text displayed on Ribbon Title instead of the Form.Text property.")]
	[Category("Appearance")]
	[DefaultValue("")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	public string TitleText
	{
		get
		{
			return ribbonStrip_0.TitleText;
		}
		set
		{
			ribbonStrip_0.TitleText = value;
		}
	}

	[Description("Indicates Context menu bar associated with the ribbon control which is used as part of Global Items feature.")]
	[DefaultValue(null)]
	[Category("Data")]
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
				contextMenuBar_0.GlobalParentComponent = (Component)(object)this;
			}
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether custom caption and quick access toolbar provided by the control is visible.")]
	[Browsable(true)]
	[Category("Caption")]
	public bool CaptionVisible
	{
		get
		{
			return ribbonStrip_0.CaptionVisible;
		}
		set
		{
			ribbonStrip_0.CaptionVisible = value;
			if (!value && ((Control)this).FindForm() is Office2007RibbonForm office2007RibbonForm)
			{
				office2007RibbonForm.method_2();
			}
		}
	}

	[Category("Caption")]
	[DefaultValue(null)]
	[Description("Indicates font for the form caption text when CaptionVisible=true.")]
	[Browsable(true)]
	public Font CaptionFont
	{
		get
		{
			return ribbonStrip_0.CaptionFont;
		}
		set
		{
			ribbonStrip_0.CaptionFont = value;
		}
	}

	[Description("Indicates explicit height of the caption provided by control")]
	[Browsable(true)]
	[DefaultValue(0)]
	[Category("Caption")]
	public int CaptionHeight
	{
		get
		{
			return ribbonStrip_0.CaptionHeight;
		}
		set
		{
			ribbonStrip_0.CaptionHeight = value;
			RecalcLayout();
		}
	}

	[DefaultValue(46)]
	[Description("Indicates indent of the ribbon strip.")]
	[Browsable(true)]
	[Category("Layout")]
	public int RibbonStripIndent
	{
		get
		{
			return ribbonStrip_0.RibbonStripIndent;
		}
		set
		{
			ribbonStrip_0.RibbonStripIndent = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether mouse over fade effect is enabled")]
	[Category("Appearance")]
	public bool FadeEffect
	{
		get
		{
			return ribbonStrip_0.FadeEffect;
		}
		set
		{
			ribbonStrip_0.FadeEffect = value;
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
			return ribbonStrip_0.KeyTipsFont;
		}
		set
		{
			ribbonStrip_0.KeyTipsFont = value;
		}
	}

	[Browsable(true)]
	[Editor(typeof(RibbonTabItemGroupCollectionEditor), typeof(UITypeEditor))]
	[Category("Tab Groups")]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public RibbonTabItemGroupCollection TabGroups => ribbonStrip_0.TabGroups;

	[DevCoBrowsable(true)]
	[Category("Tab Groups")]
	[Description("Indicates height in pixels of tab group line that is displayed above the RibbonTabItem objects that have group assigned.")]
	[DefaultValue(10)]
	[Browsable(true)]
	public int TabGroupHeight
	{
		get
		{
			return ribbonStrip_0.TabGroupHeight;
		}
		set
		{
			ribbonStrip_0.TabGroupHeight = value;
			if (((Component)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[Description("Indicates whether tab group line that is displayed above the RibbonTabItem objects that have group assigned is visible.")]
	[Browsable(true)]
	[Category("Tab Groups")]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	public bool TabGroupsVisible
	{
		get
		{
			return ribbonStrip_0.TabGroupsVisible;
		}
		set
		{
			ribbonStrip_0.TabGroupsVisible = value;
			if (((Component)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DefaultValue(null)]
	[DevCoBrowsable(true)]
	[Category("Tab Groups")]
	[Browsable(true)]
	public Font DefaultGroupFont
	{
		get
		{
			return ribbonStrip_0.DefaultGroupFont;
		}
		set
		{
			ribbonStrip_0.DefaultGroupFont = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[Description("Gets or sets bar background style.")]
	[Browsable(true)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ElementStyle BackgroundStyle => ribbonStrip_0.BackgroundStyle;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public RibbonTabItem SelectedRibbonTabItem
	{
		get
		{
			return ribbonStrip_0.SelectedRibbonTabItem;
		}
		set
		{
			if (value != null)
			{
				value.Checked = true;
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public RibbonStrip RibbonStrip => ribbonStrip_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public SubItemsCollection Items => ribbonStrip_0.Items;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public SubItemsCollection QuickToolbarItems => method_12();

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifies the visual style of the control.")]
	[Category("Appearance")]
	[DefaultValue(eDotNetBarStyle.Office2003)]
	public eDotNetBarStyle Style
	{
		get
		{
			return ribbonStrip_0.Style;
		}
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			ribbonStrip_0.Style = value;
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val = item;
				if (!(val is RibbonPanel))
				{
					continue;
				}
				((RibbonPanel)(object)val).ColorSchemeStyle = value;
				foreach (Control item2 in (ArrangedElementCollection)val.get_Controls())
				{
					Control val2 = item2;
					if (val2 is RibbonBar)
					{
						RibbonBar component = val2 as RibbonBar;
						TypeDescriptor.GetProperties(component)["Style"]!.SetValue(component, value);
					}
				}
			}
			if (((Component)this).DesignMode)
			{
				((Control)this).Invalidate();
				RecalcLayout();
			}
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(eOffice2007ColorScheme.Blue)]
	[Description("Indicates the Office 2007 Renderer global Color Table.")]
	public eOffice2007ColorScheme Office2007ColorTable
	{
		get
		{
			if (ribbonStrip_0.GetRenderer() is Office2007Renderer office2007Renderer)
			{
				return office2007Renderer.ColorTable.InitialColorScheme;
			}
			return eOffice2007ColorScheme.Blue;
		}
		set
		{
			Form val = ((Control)this).FindForm();
			if (val == null && ((Control)this).get_Parent() == null)
			{
				bool_14 = true;
				eOffice2007ColorScheme_0 = value;
			}
			else if (val == null && ((Control)this).get_Parent() != null)
			{
				RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(((Control)this).get_Parent(), value);
			}
			else
			{
				RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable((Control)(object)val, value);
			}
		}
	}

	[Browsable(false)]
	public bool IsPopupMode => bool_11;

	[Description("Gets or sets whether control is expanded or not. When control is expanded both the tabs and the tab ribbons are visible.")]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Layout")]
	public bool Expanded
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				if (!bool_17 && Class109.smethod_11((Control)(object)this))
				{
					bool_15 = false;
					bool_0 = value;
					method_23();
				}
				else
				{
					bool_15 = true;
					bool_16 = value;
				}
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether control is collapsed when RibbonTabItem is double clicked and expanded when RibbonTabItem is clicked.")]
	[Category("Layout")]
	public virtual bool AutoExpand
	{
		get
		{
			return ribbonStrip_0.Boolean_5;
		}
		set
		{
			ribbonStrip_0.Boolean_5 = value;
		}
	}

	[DefaultValue(null)]
	[Description("ImageList for images used on Items. Images specified here will always be used on menu-items and are by default used on all Bars.")]
	[Browsable(true)]
	[Category("Data")]
	public ImageList Images
	{
		get
		{
			return ribbonStrip_0.Images;
		}
		set
		{
			ribbonStrip_0.Images = value;
		}
	}

	[Category("Data")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("ImageList for medium-sized images used on Items.")]
	public ImageList ImagesMedium
	{
		get
		{
			return ribbonStrip_0.ImagesMedium;
		}
		set
		{
			ribbonStrip_0.ImagesMedium = value;
		}
	}

	[DefaultValue(null)]
	[Category("Data")]
	[Browsable(true)]
	[Description("ImageList for large-sized images used on Items.")]
	public ImageList ImagesLarge
	{
		get
		{
			return ribbonStrip_0.ImagesLarge;
		}
		set
		{
			ribbonStrip_0.ImagesLarge = value;
		}
	}

	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Indicates whether the user can give the focus to this control using the TAB key.")]
	public bool TabStop
	{
		get
		{
			return ((Control)this).get_TabStop();
		}
		set
		{
			((Control)this).set_TabStop(value);
		}
	}

	[Category("Run-time Behavior")]
	[Description("Specifies whether the MDI system buttons are displayed in menu bar when MDI Child window is maximized.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool MdiSystemItemVisible
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
			if (!((Component)this).DesignMode)
			{
				method_30();
				if (!bool_1 && form_0 != null)
				{
					((Control)form_0).remove_Resize((EventHandler)method_29);
					((Control)form_0).remove_VisibleChanged((EventHandler)method_28);
				}
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool CanSupportGlass
	{
		get
		{
			return ribbonStrip_0.CanSupportGlass;
		}
		set
		{
			ribbonStrip_0.CanSupportGlass = value;
		}
	}

	private bool Boolean_2
	{
		get
		{
			if (CanCustomize)
			{
				if (!CaptionVisible)
				{
					return bool_9;
				}
				return true;
			}
			return false;
		}
	}

	internal Control7 Control7_0 => control7_0;

	[Description("Indicates whether control can be customized. Caption must be visible for customization to be fully enabled.")]
	[Category("Quick Access Toolbar")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool CanCustomize
	{
		get
		{
			return ribbonStrip_0.CanCustomize;
		}
		set
		{
			ribbonStrip_0.CanCustomize = value;
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether external implementation for ribbon bar and menu item customization will be used for customizing the ribbon control.")]
	[Category("Quick Access Toolbar")]
	[Browsable(true)]
	public bool UseExternalCustomization
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

	[Category("Quick Access Toolbar")]
	[DefaultValue(true)]
	[Description("Indicates whether end-user customization of the placement of the Quick Access Toolbar is enabled.")]
	[Browsable(true)]
	public bool EnableQatPlacement
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
	[Description("Indicates whether customize dialog is used to customize the quick access toolbar.")]
	[DefaultValue(true)]
	[Category("Quick Access Toolbar")]
	public bool UseCustomizeDialog
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

	[DefaultValue(eCategorizeMode.RibbonBar)]
	[Browsable(true)]
	[Category("Quick Access Toolbar")]
	[Description("Indicates categorization mode for the items on Quick Access Toolbar customize dialog box.")]
	public eCategorizeMode CategorizeMode
	{
		get
		{
			return eCategorizeMode_0;
		}
		set
		{
			eCategorizeMode_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool QatPositionedBelowRibbon
	{
		get
		{
			return bool_6;
		}
		set
		{
			if (bool_6 != value)
			{
				method_36();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string QatLayout
	{
		get
		{
			return method_48();
		}
		set
		{
			method_49(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool QatLayoutChanged
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Localization")]
	[Description("Gets system text used by the component..")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[NotifyParentProperty(true)]
	public RibbonLocalization SystemText => ribbonLocalization_0;

	public event CustomizeMenuPopupEventHandler BeforeCustomizeMenuPopup
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customizeMenuPopupEventHandler_0 = (CustomizeMenuPopupEventHandler)Delegate.Combine(customizeMenuPopupEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customizeMenuPopupEventHandler_0 = (CustomizeMenuPopupEventHandler)Delegate.Remove(customizeMenuPopupEventHandler_0, value);
		}
	}

	public event CustomizeMenuPopupEventHandler BeforeAddItemToQuickAccessToolbar
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customizeMenuPopupEventHandler_1 = (CustomizeMenuPopupEventHandler)Delegate.Combine(customizeMenuPopupEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customizeMenuPopupEventHandler_1 = (CustomizeMenuPopupEventHandler)Delegate.Remove(customizeMenuPopupEventHandler_1, value);
		}
	}

	public event CustomizeMenuPopupEventHandler BeforeRemoveItemFromQuickAccessToolbar
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customizeMenuPopupEventHandler_2 = (CustomizeMenuPopupEventHandler)Delegate.Combine(customizeMenuPopupEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customizeMenuPopupEventHandler_2 = (CustomizeMenuPopupEventHandler)Delegate.Remove(customizeMenuPopupEventHandler_2, value);
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

	[Description("Occurs when Item on ribbon tab strip or quick access toolbar is clicked.")]
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

	public event QatCustomizeDialogEventHandler BeforeQatCustomizeDialog
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			qatCustomizeDialogEventHandler_0 = (QatCustomizeDialogEventHandler)Delegate.Combine(qatCustomizeDialogEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			qatCustomizeDialogEventHandler_0 = (QatCustomizeDialogEventHandler)Delegate.Remove(qatCustomizeDialogEventHandler_0, value);
		}
	}

	public event QatCustomizeDialogEventHandler AfterQatCustomizeDialog
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			qatCustomizeDialogEventHandler_1 = (QatCustomizeDialogEventHandler)Delegate.Combine(qatCustomizeDialogEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			qatCustomizeDialogEventHandler_1 = (QatCustomizeDialogEventHandler)Delegate.Remove(qatCustomizeDialogEventHandler_1, value);
		}
	}

	public event EventHandler AfterQatDialogChangesApplied
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

	public event EventHandler SelectedRibbonTabChanged
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

	[Description("Occurs before selected RibbonPanel is displayed on popup while ribbon is collapsed.")]
	public event CancelEventHandler BeforeRibbonPanelPopup
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_0, value);
		}
	}

	[Description("Occurs after selected RibbonPanel is displayed on popup while ribbon is collapsed.")]
	public event EventHandler AfterRibbonPanelPopup
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

	[Description("Occurs before RibbonPanel popup is closed.")]
	public event RibbonPopupCloseEventHandler BeforeRibbonPanelPopupClose
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ribbonPopupCloseEventHandler_0 = (RibbonPopupCloseEventHandler)Delegate.Combine(ribbonPopupCloseEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ribbonPopupCloseEventHandler_0 = (RibbonPopupCloseEventHandler)Delegate.Remove(ribbonPopupCloseEventHandler_0, value);
		}
	}

	[Description("Occurs after RibbonPanel popup is closed.")]
	public event EventHandler AfterRibbonPanelPopupClose
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

	[Description("Occurs when text markup link from TitleText markup is clicked.")]
	public event MarkupLinkClickEventHandler TitleTextMarkupLinkClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Combine(markupLinkClickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Remove(markupLinkClickEventHandler_0, value);
		}
	}

	[Description("Occurs after Expanded property has changed.")]
	public event EventHandler ExpandedChanged
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

	public RibbonControl()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		subItemsCollection_0.Boolean_1 = true;
		subItemsCollection_0.Boolean_0 = false;
		((Control)this).SetStyle((ControlStyles)(0x2010 | Class50.ControlStyles_0 | 2 | 4), true);
		ribbonStrip_0 = new RibbonStrip();
		((Control)ribbonStrip_0).set_Dock((DockStyle)1);
		((Control)ribbonStrip_0).set_Height(32);
		ribbonStrip_0.ItemAdded += ribbonStrip_0_ItemAdded;
		((Control)ribbonStrip_0).add_SizeChanged((EventHandler)ribbonStrip_0_SizeChanged);
		ribbonStrip_0.ItemRemoved += ribbonStrip_0_ItemRemoved;
		ribbonStrip_0.LocalizeString += ribbonStrip_0_LocalizeString;
		ribbonStrip_0.ItemClick += ribbonStrip_0_ItemClick;
		ribbonStrip_0.ButtonCheckedChanged += ribbonStrip_0_ButtonCheckedChanged;
		ribbonStrip_0.TitleTextMarkupLinkClick += ribbonStrip_0_TitleTextMarkupLinkClick;
		((Control)this).get_Controls().Add((Control)(object)ribbonStrip_0);
		TabStop = false;
		((ScrollableControl)this).get_DockPadding().set_Bottom(int_0);
	}

	protected virtual void OnSelectedRibbonTabChanged(EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, e);
		}
	}

	private void ribbonStrip_0_ButtonCheckedChanged(object sender, EventArgs e)
	{
		if (sender is RibbonTabItem && ((RibbonTabItem)sender).Checked)
		{
			AutoSyncSize();
			OnSelectedRibbonTabChanged(new EventArgs());
		}
	}

	private void ribbonStrip_0_ItemClick(object sender, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(sender, e);
		}
	}

	private void ribbonStrip_0_LocalizeString(object sender, LocalizeEventArgs e)
	{
		if (localizeStringEventHandler_0 != null)
		{
			localizeStringEventHandler_0(this, e);
		}
	}

	private void method_0()
	{
		AutoSyncSize();
	}

	public virtual void AutoSyncSize()
	{
		method_1(bool_18: true);
	}

	private void method_1(bool bool_18)
	{
		if (bool_3 && int_2 <= 0 && Class109.smethod_11((Control)(object)this))
		{
			int_2++;
			try
			{
				method_5(bool_18);
			}
			finally
			{
				int_2--;
			}
		}
	}

	private int method_2(ItemControl itemControl_0)
	{
		int num = itemControl_0.GetAutoSizeHeight();
		if (!((Control)itemControl_0).get_MinimumSize().IsEmpty && ((Control)itemControl_0).get_MinimumSize().Height > num)
		{
			num = ((Control)itemControl_0).get_MinimumSize().Height + Class52.smethod_2(itemControl_0.method_16());
		}
		else if (!((Control)itemControl_0).get_MaximumSize().IsEmpty && num > ((Control)itemControl_0).get_MaximumSize().Height)
		{
			num = ((Control)itemControl_0).get_MaximumSize().Height + Class52.smethod_2(itemControl_0.method_16());
		}
		return num;
	}

	private void method_3()
	{
		method_5(bool_18: true);
	}

	private int method_4(RibbonPanel ribbonPanel_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		int num = 0;
		if (ribbonPanel_1 == null)
		{
			return num;
		}
		int num2 = 0;
		foreach (Control item in (ArrangedElementCollection)((Control)ribbonPanel_1).get_Controls())
		{
			Control val = item;
			if (!(val is ItemControl itemControl))
			{
				continue;
			}
			int autoSizeHeight = itemControl.GetAutoSizeHeight();
			if (itemControl != null && autoSizeHeight > num2)
			{
				int num3 = method_2(itemControl);
				if (num3 > num2)
				{
					num2 = num3;
				}
			}
		}
		if (num2 > 0)
		{
			num += num2;
		}
		return num;
	}

	private void method_5(bool bool_18)
	{
		int height = ((Control)ribbonStrip_0).get_Height();
		if (Expanded)
		{
			if (SelectedRibbonTabItem != null)
			{
				RibbonPanel panel = SelectedRibbonTabItem.Panel;
				if (panel != null)
				{
					int num = method_4(panel);
					height = ((num > 0) ? (height + num) : 0);
				}
				else
				{
					height = 0;
				}
			}
			else
			{
				height = 0;
			}
		}
		else
		{
			height -= 4;
		}
		if (height > 0)
		{
			height += ((ScrollableControl)this).get_DockPadding().get_Bottom() + ((ScrollableControl)this).get_DockPadding().get_Top();
			if (bool_6)
			{
				height += ((Control)control7_0).get_Height();
			}
		}
		if (((Control)this).get_Height() == height || height <= 0)
		{
			return;
		}
		RibbonPanel ribbonPanel = null;
		if (!bool_18)
		{
			RibbonTabItem selectedRibbonTabItem = SelectedRibbonTabItem;
			if (selectedRibbonTabItem != null && selectedRibbonTabItem.Panel != null)
			{
				ribbonPanel = selectedRibbonTabItem.Panel;
				((Control)ribbonPanel).SuspendLayout();
			}
		}
		((Control)this).set_Height(height);
		if (ribbonPanel != null)
		{
			((Control)ribbonPanel).ResumeLayout(false);
		}
	}

	internal Office2007ColorTable method_6()
	{
		if (GlobalManager.Renderer is Office2007Renderer office2007Renderer)
		{
			return office2007Renderer.ColorTable;
		}
		return new Office2007ColorTable();
	}

	public void SetRibbonPanelStyle(RibbonPanel panel)
	{
		if (((Component)this).DesignMode)
		{
			TypeDescriptor.GetProperties(((ScrollableControl)panel).get_DockPadding())["Left"]!.SetValue(((ScrollableControl)panel).get_DockPadding(), 3);
			TypeDescriptor.GetProperties(((ScrollableControl)panel).get_DockPadding())["Right"]!.SetValue(((ScrollableControl)panel).get_DockPadding(), 3);
			TypeDescriptor.GetProperties(((ScrollableControl)panel).get_DockPadding())["Bottom"]!.SetValue(((ScrollableControl)panel).get_DockPadding(), 3);
		}
		else
		{
			((ScrollableControl)panel).get_DockPadding().set_Left(3);
			((ScrollableControl)panel).get_DockPadding().set_Right(3);
			((ScrollableControl)panel).get_DockPadding().set_Bottom(3);
		}
	}

	public RibbonTabItem CreateRibbonTab(string text, string name, int insertPosition)
	{
		RibbonTabItem ribbonTabItem = new RibbonTabItem();
		ribbonTabItem.Text = text;
		ribbonTabItem.Name = name;
		RibbonPanel ribbonPanel = new RibbonPanel();
		((Control)ribbonPanel).set_Dock((DockStyle)5);
		((Control)ribbonPanel).set_Width(((Control)this).get_Width() - 4);
		SetRibbonPanelStyle(ribbonPanel);
		((Control)this).get_Controls().Add((Control)(object)ribbonPanel);
		((Control)ribbonPanel).SendToBack();
		ribbonTabItem.Panel = ribbonPanel;
		if (insertPosition < 0)
		{
			insertPosition = Items.Count;
			for (int i = 0; i < Items.Count; i++)
			{
				if (Items[i].ItemAlignment == eItemAlignment.Far)
				{
					insertPosition = i;
					break;
				}
			}
			if (insertPosition >= Items.Count)
			{
				Items.Add(ribbonTabItem);
			}
			else
			{
				Items.Insert(insertPosition, ribbonTabItem);
			}
		}
		else if (insertPosition > Items.Count - 1)
		{
			Items.Add(ribbonTabItem);
		}
		else
		{
			Items.Insert(insertPosition, ribbonTabItem);
		}
		return ribbonTabItem;
	}

	public RibbonTabItem CreateRibbonTab(string text, string name)
	{
		return CreateRibbonTab(text, name, -1);
	}

	public void RecalcLayout()
	{
		ribbonStrip_0.RecalcLayout();
		if (control7_0 != null && ((Control)control7_0).get_Visible())
		{
			control7_0.RecalcLayout();
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		RemindForm remindForm = new RemindForm();
		remindForm.method_0();
		((Component)(object)remindForm).Dispose();
		((Control)this).OnHandleCreated(e);
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			val.get_Handle();
			if (!(val is RibbonPanel))
			{
				continue;
			}
			foreach (Control item2 in (ArrangedElementCollection)val.get_Controls())
			{
				Control val2 = item2;
				val2.get_Handle();
			}
		}
		method_11();
		RecalcLayout();
		if (bool_15)
		{
			Expanded = bool_16;
		}
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		((Control)this).OnControlAdded(e);
		if (((Component)this).DesignMode || !(e.get_Control() is RibbonPanel ribbonPanel))
		{
			return;
		}
		if (ribbonPanel.RibbonTabItem != null)
		{
			if (Items.Contains(ribbonPanel.RibbonTabItem) && SelectedRibbonTabItem == ribbonPanel.RibbonTabItem)
			{
				ribbonPanel.Visible = true;
				((Control)ribbonPanel).BringToFront();
			}
			else
			{
				ribbonPanel.Visible = false;
			}
		}
		else
		{
			ribbonPanel.Visible = false;
		}
	}

	private void ribbonStrip_0_SizeChanged(object sender, EventArgs e)
	{
		if (!bool_13 && bool_3)
		{
			AutoSyncSize();
		}
		bool_13 = false;
		if (!bool_0 && !bool_3)
		{
			((Control)this).set_Height(method_24());
		}
	}

	private void ribbonStrip_0_ItemAdded(object sender, EventArgs e)
	{
		if (((Component)this).DesignMode || !(sender is RibbonTabItem))
		{
			return;
		}
		RibbonTabItem ribbonTabItem = sender as RibbonTabItem;
		if (ribbonTabItem.Panel != null)
		{
			if (((Control)this).get_Controls().Contains((Control)(object)ribbonTabItem.Panel) && ribbonTabItem.Checked)
			{
				ribbonTabItem.Panel.Visible = true;
				((Control)ribbonTabItem.Panel).BringToFront();
			}
			else
			{
				ribbonTabItem.Panel.Visible = false;
			}
			ribbonTabItem.CheckedChanged += method_7;
		}
	}

	private void ribbonStrip_0_ItemRemoved(object sender, ItemRemovedEventArgs e)
	{
		if (sender is RibbonTabItem)
		{
			((RibbonTabItem)sender).CheckedChanged -= method_7;
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (sender is RibbonTabItem && ((RibbonTabItem)sender).Checked)
		{
			AutoSyncSize();
		}
	}

	protected override void OnControlRemoved(ControlEventArgs e)
	{
		((Control)this).OnControlRemoved(e);
		if (!bool_11 && e.get_Control() is RibbonPanel ribbonPanel && ribbonPanel.RibbonTabItem != null && Items.Contains(ribbonPanel.RibbonTabItem))
		{
			Items.Remove(ribbonPanel.RibbonTabItem);
		}
	}

	internal void method_8()
	{
		ribbonStrip_0.method_0(bool_25: true);
	}

	private ElementStyle method_9()
	{
		return ribbonStrip_0.method_30();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		ElementStyle elementStyle = method_9();
		if ((elementStyle.BackColor.A < byte.MaxValue && !elementStyle.BackColor.IsEmpty) || ((Control)this).get_BackColor() == Color.Transparent)
		{
			((ScrollableControl)this).OnPaintBackground(e);
		}
		if (Boolean_1 && ((Control)this).FindForm() is Office2007RibbonForm office2007RibbonForm)
		{
			e.get_Graphics().SetClip(new Rectangle(0, 0, ((Control)this).get_Width(), office2007RibbonForm.Int32_1), (CombineMode)4);
		}
		ElementStyleDisplayInfo e2 = new ElementStyleDisplayInfo(elementStyle, e.get_Graphics(), ((Control)this).get_ClientRectangle());
		ElementStyleDisplay.PaintBackground(e2);
		if (!bool_6 && ribbonStrip_0.Boolean_3)
		{
			ShadowPaintInfo shadowPaintInfo = method_10();
			shadowPaintInfo.Rectangle = new Rectangle(-2, 0, ((Control)this).get_Bounds().Width - shadowPaintInfo.Size + 1, ((Control)this).get_Bounds().Height - shadowPaintInfo.Size);
			shadowPaintInfo.Graphics = e.get_Graphics();
			ShadowPainter.Paint(shadowPaintInfo);
		}
	}

	private ShadowPaintInfo method_10()
	{
		if (shadowPaintInfo_0 == null)
		{
			shadowPaintInfo_0 = new ShadowPaintInfo();
		}
		shadowPaintInfo_0.Size = 4;
		return shadowPaintInfo_0;
	}

	protected override void OnResize(EventArgs e)
	{
		bool_13 = true;
		method_11();
		((Control)this).OnResize(e);
		AutoSyncSize();
	}

	protected override void NotifyInvalidate(Rectangle invalidatedArea)
	{
		((Control)this).NotifyInvalidate(invalidatedArea);
		method_11();
	}

	private void method_11()
	{
		if (((Control)this).get_Parent() is Office2007RibbonForm && ribbonStrip_0.CaptionVisible && !Boolean_1)
		{
			((Control)this).set_Region(GetControlRegion());
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 132)
		{
			int x = Class51.smethod_4(((Message)(ref m)).get_LParam());
			int y = Class51.smethod_5(((Message)(ref m)).get_LParam());
			Point pt = ((Control)this).PointToClient(new Point(x, y));
			if (Boolean_1 && CaptionVisible)
			{
				Rectangle rectangle = new Rectangle(((Control)this).get_Width() - SystemInformation.get_CaptionButtonSize().Width * 3, 0, SystemInformation.get_CaptionButtonSize().Width * 3, SystemInformation.get_CaptionButtonSize().Height);
				if (rectangle.Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(-1));
					return;
				}
				if (ribbonStrip_0 != null && !ribbonStrip_0.Boolean_4 && new Rectangle(0, 0, ((Control)this).get_Width(), 4).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(-1));
					return;
				}
			}
			else if (CaptionVisible && ribbonStrip_0 != null && !ribbonStrip_0.Boolean_4 && new Rectangle(0, 0, ((Control)this).get_Width(), 4).Contains(pt))
			{
				((Message)(ref m)).set_Result(new IntPtr(-1));
				return;
			}
		}
		((ContainerControl)this).WndProc(ref m);
	}

	protected virtual Region GetControlRegion()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_Parent() is Office2007RibbonForm && (int)((Form)((Control)this).get_Parent()).get_WindowState() == 2)
		{
			return null;
		}
		GraphicsPath val = new GraphicsPath();
		Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		bool flag = (int)((Control)this).get_RightToLeft() == 1;
		int num = 2;
		int num2 = 2;
		if (((Control)this).get_Parent() is Office2007RibbonForm)
		{
			Office2007RibbonForm office2007RibbonForm = ((Control)this).get_Parent() as Office2007RibbonForm;
			num = office2007RibbonForm.TopLeftCornerSize - 2;
			num2 = office2007RibbonForm.TopRightCornerSize - 1;
			if (num <= 0)
			{
				num = 0;
			}
			if (num2 <= 0)
			{
				num = 0;
			}
			if (flag)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			if (num > 0)
			{
				Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle_, num, Enum14.const_0);
				val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
			}
			else
			{
				val.AddLine(rectangle_.X, rectangle_.Y + 2, rectangle_.X, rectangle_.Y);
				val.AddLine(rectangle_.X, rectangle_.Y, rectangle_.X + 2, rectangle_.Y);
			}
			if (num2 > 0)
			{
				Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle_, num2, Enum14.const_1);
				val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
			}
			else
			{
				val.AddLine(rectangle_.Right - 2, rectangle_.Y, rectangle_.Right, rectangle_.Y);
				val.AddLine(rectangle_.Right, rectangle_.Y, rectangle_.Right, rectangle_.Y + 2);
			}
			val.AddLine(rectangle_.Right, rectangle_.Bottom - 2, rectangle_.Right, rectangle_.Bottom);
			val.AddLine(rectangle_.Right, rectangle_.Bottom, rectangle_.Right - 2, rectangle_.Bottom);
			val.AddLine(rectangle_.X + 2, rectangle_.Bottom, rectangle_.X, rectangle_.Bottom);
			val.AddLine(rectangle_.X, rectangle_.Bottom, rectangle_.X, rectangle_.Bottom - 2);
			val.CloseAllFigures();
			Region val2 = new Region();
			val2.MakeEmpty();
			val2.Union(val);
			val.Widen(SystemPens.get_Control());
			new Region(val);
			val2.Union(val);
			return val2;
		}
		return null;
	}

	private void ribbonStrip_0_TitleTextMarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(this, new MarkupLinkClickEventArgs(e.Name, e.HRef));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDefaultGroupFont()
	{
		TypeDescriptor.GetProperties(this)["DefaultGroupFont"]!.SetValue(this, null);
	}

	private SubItemsCollection method_12()
	{
		if (bool_6)
		{
			if (class242_0 == null)
			{
				class242_0 = new Class242(control7_0);
				BaseItem baseItem = method_47();
				if (baseItem != null)
				{
					class242_0.method_0(baseItem);
				}
				foreach (BaseItem item in control7_0.SubItemsCollection_0)
				{
					class242_0.method_0(item);
				}
			}
			return class242_0;
		}
		return ribbonStrip_0.QuickToolbarItems;
	}

	protected virtual void OnBeforeRibbonPanelPopupClose(RibbonPopupCloseEventArgs e)
	{
		if (ribbonPopupCloseEventHandler_0 != null)
		{
			ribbonPopupCloseEventHandler_0(this, e);
		}
	}

	protected virtual void OnAfterRibbonPanelPopupClose(EventArgs e)
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(this, e);
		}
	}

	protected virtual void OnBeforeRibbonPanelPopup(CancelEventArgs ce)
	{
		if (cancelEventHandler_0 != null)
		{
			cancelEventHandler_0(this, ce);
		}
	}

	protected virtual void OnAfterRibbonPanelPopup(EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
		}
	}

	internal void method_13(BaseItem baseItem_0)
	{
		ribbonStrip_0.method_42(baseItem_0);
		if (bool_11 && baseItem_0 != null && !(baseItem_0 is RibbonTabItem) && !baseItem_0.IsContainer && !baseItem_0.Name.StartsWith("sysgallery") && !(baseItem_0 is CheckBoxItem) && baseItem_0.AutoCollapseOnClick && (!(baseItem_0 is PopupItem) || !baseItem_0.Expanded))
		{
			CloseRibbonMenu(baseItem_0, eEventSource.Mouse);
		}
	}

	private void method_14()
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
		if (activeWindow != IntPtr.Zero)
		{
			Control val = Control.FromHandle(activeWindow);
			if (val is PopupContainer || val is PopupContainerControl || val is Balloon)
			{
				return;
			}
		}
		timer_0.Stop();
		method_15();
	}

	private void method_15()
	{
		if (bool_11)
		{
			CloseRibbonMenu(this, eEventSource.Code);
		}
		method_16();
	}

	private void method_16()
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

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (!((Control)this).get_Visible())
		{
			method_15();
		}
		((ScrollableControl)this).OnVisibleChanged(e);
	}

	internal void method_17()
	{
		method_15();
	}

	internal void method_18(IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4)
	{
		if (!bool_11)
		{
			return;
		}
		Control val = Control.FromChildHandle(intptr_2);
		if (val == null)
		{
			string text = Class92.smethod_8(intptr_2);
			text = text.ToLower();
			if (text.IndexOf("combolbox") < 0)
			{
				method_15();
			}
			return;
		}
		while (!(val is MenuPanel) && !(val is PopupContainer) && !(val is PopupContainerControl) && !(val is RibbonBar) && !(val is RibbonStrip) && !(val is RibbonPanel) && !(val is Balloon))
		{
			val = val.get_Parent();
			if (val == null)
			{
				method_15();
				break;
			}
		}
	}

	public void PopupRibbon(object source, eEventSource eventSource)
	{
		if (Expanded || SelectedRibbonTabItem == null || SelectedRibbonTabItem.Panel == null || ribbonPanel_0 == SelectedRibbonTabItem.Panel)
		{
			return;
		}
		Control val = (Control)(object)((Control)this).FindForm();
		if (val == null)
		{
			val = ((Control)this).get_Parent();
		}
		if (val == null)
		{
			return;
		}
		RibbonPanel ribbonPanel = ribbonPanel_0;
		if (ribbonPanel != null)
		{
			RibbonPopupCloseEventArgs ribbonPopupCloseEventArgs = new RibbonPopupCloseEventArgs(source, eventSource);
			OnBeforeRibbonPanelPopupClose(ribbonPopupCloseEventArgs);
			if (ribbonPopupCloseEventArgs.Cancel)
			{
				return;
			}
		}
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnBeforeRibbonPanelPopup(cancelEventArgs);
		if (!cancelEventArgs.Cancel)
		{
			bool_11 = true;
			RibbonPanel panel = SelectedRibbonTabItem.Panel;
			((Control)panel).SuspendLayout();
			((Control)this).get_Controls().Remove((Control)(object)panel);
			panel.Visible = false;
			((Control)panel).set_Dock((DockStyle)0);
			val.get_Controls().Add((Control)(object)panel);
			Point point = ((Control)ribbonStrip_0).PointToScreen(new Point(0, ((Control)ribbonStrip_0).get_Height()));
			point = val.PointToClient(point);
			((Control)panel).set_Font(((Control)this).get_Font());
			((Control)panel).set_Bounds(new Rectangle(point.X, point.Y - int_0 - 1, ((Control)this).get_Width(), method_20(ribbonPanel_0)));
			panel.method_5(bool_15: true, this);
			((Control)panel).ResumeLayout();
			panel.Visible = true;
			((Control)panel).BringToFront();
			method_19(ribbonPanel);
			method_14();
			ribbonPanel_0 = panel;
			OnAfterRibbonPanelPopup(new EventArgs());
		}
	}

	private void method_19(RibbonPanel ribbonPanel_1)
	{
		if (ribbonPanel_1 == null || ((Control)ribbonPanel_1).get_IsDisposed() || ((Control)ribbonPanel_1).get_Parent() == null)
		{
			return;
		}
		SuspendLayout();
		ribbonPanel_1.Visible = false;
		((Control)ribbonPanel_1).get_Parent().get_Controls().Remove((Control)(object)ribbonPanel_1);
		ribbonPanel_1.method_5(bool_15: false, this);
		((Control)ribbonPanel_1).set_Dock((DockStyle)5);
		((Control)this).get_Controls().Add((Control)(object)ribbonPanel_1);
		if (SelectedRibbonTabItem != null)
		{
			SelectedRibbonTabItem.Refresh();
			if (SelectedRibbonTabItem.Panel == ribbonPanel_1)
			{
				ribbonPanel_1.Visible = true;
			}
		}
		((Control)ribbonPanel_1).BringToFront();
		ResumeLayout(performLayout: true);
		OnAfterRibbonPanelPopupClose(new EventArgs());
	}

	public void CloseRibbonMenu()
	{
		CloseRibbonMenu(null, eEventSource.Code);
	}

	public void CloseRibbonMenu(object source, eEventSource eventSource)
	{
		if (bool_11 && ribbonPanel_0 != null)
		{
			RibbonPopupCloseEventArgs ribbonPopupCloseEventArgs = new RibbonPopupCloseEventArgs(source, eventSource);
			OnBeforeRibbonPanelPopupClose(ribbonPopupCloseEventArgs);
			if (!ribbonPopupCloseEventArgs.Cancel)
			{
				method_19(ribbonPanel_0);
				ribbonPanel_0 = null;
				bool_11 = false;
			}
		}
	}

	private int method_20(RibbonPanel ribbonPanel_1)
	{
		if (((Control)this).get_AutoSize())
		{
			return method_4(ribbonPanel_1);
		}
		int num = int_3 - ((Control)ribbonStrip_0).get_Height();
		if (bool_10)
		{
			num -= int_1 + 1;
		}
		return num;
	}

	internal void method_21(RibbonTabItem ribbonTabItem_0)
	{
		if (Expanded)
		{
			return;
		}
		if (bool_12)
		{
			if (ribbonTabItem_0.Panel == ribbonPanel_0)
			{
				CloseRibbonMenu(ribbonTabItem_0, eEventSource.Mouse);
			}
			else
			{
				PopupRibbon(ribbonTabItem_0, eEventSource.Mouse);
			}
		}
		else
		{
			Expanded = true;
		}
	}

	internal void method_22(RibbonTabItem ribbonTabItem_0)
	{
		if (bool_12 && !Expanded)
		{
			CloseRibbonMenu(ribbonTabItem_0, eEventSource.Code);
			Expanded = true;
		}
		else
		{
			Expanded = false;
		}
	}

	private void method_23()
	{
		if (bool_0 && control7_0 != null)
		{
			((Control)control7_0).SendToBack();
		}
		else if (!bool_0 && control7_0 != null)
		{
			((Control)control7_0).BringToFront();
		}
		((Control)ribbonStrip_0).Invalidate();
		if (((Control)this).get_AutoSize())
		{
			method_3();
		}
		else
		{
			int num = 0;
			if (!Expanded)
			{
				num = method_24();
				bool_10 = bool_6;
				if (bool_6)
				{
					int_1 = ((Control)control7_0).get_Height();
				}
			}
			if (Expanded)
			{
				num = int_3;
				if (!bool_6 && bool_10)
				{
					num -= int_1;
				}
				else if (bool_6 && !bool_10)
				{
					num += ((Control)control7_0).get_Height();
				}
			}
			else
			{
				int_3 = ((Control)this).get_Height();
			}
			if (((Control)this).get_Height() != num && num > 0)
			{
				((Control)this).set_Height(num);
			}
		}
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, new EventArgs());
		}
	}

	private int method_24()
	{
		int num = ((Control)ribbonStrip_0).get_Height();
		if (bool_6)
		{
			num += ((Control)control7_0).get_Height();
		}
		return num;
	}

	protected override void OnTabStopChanged(EventArgs e)
	{
		((Control)this).OnTabStopChanged(e);
		((Control)ribbonStrip_0).set_TabStop(TabStop);
	}

	public void SuspendLayout()
	{
		((Control)this).SuspendLayout();
		bool_17 = true;
	}

	public void ResumeLayout()
	{
		bool_17 = false;
		if (bool_14)
		{
			bool_14 = false;
			Office2007ColorTable = eOffice2007ColorScheme_0;
		}
		((Control)this).ResumeLayout();
	}

	public void ResumeLayout(bool performLayout)
	{
		bool_17 = false;
		if (bool_14)
		{
			bool_14 = false;
			Office2007ColorTable = eOffice2007ColorScheme_0;
		}
		((Control)this).ResumeLayout(performLayout);
	}

	protected override void OnParentChanged(EventArgs e)
	{
		((ContainerControl)this).OnParentChanged(e);
		Form val = ((Control)this).FindForm();
		if (val != null)
		{
			val.add_MdiChildActivate((EventHandler)method_25);
		}
		if (bool_14 && !bool_17)
		{
			bool_14 = false;
			Office2007ColorTable = eOffice2007ColorScheme_0;
		}
	}

	private void method_25(object sender, EventArgs e)
	{
		Form val = ((Control)this).FindForm();
		if (val == null)
		{
			return;
		}
		Form activeMdiChild = val.get_ActiveMdiChild();
		if (bool_1)
		{
			if (activeMdiChild != null)
			{
				((Control)activeMdiChild).add_Resize((EventHandler)method_29);
				((Control)activeMdiChild).add_VisibleChanged((EventHandler)method_28);
			}
			if (form_0 != null)
			{
				((Control)form_0).remove_Resize((EventHandler)method_29);
				((Control)form_0).remove_VisibleChanged((EventHandler)method_28);
			}
			bool_2 = false;
			form_0 = activeMdiChild;
			method_30();
		}
		method_26();
	}

	private void method_26()
	{
		if (!bool_8)
		{
			return;
		}
		Form val = ((Control)this).FindForm();
		if (val == null)
		{
			return;
		}
		Form activeMdiChild = val.get_ActiveMdiChild();
		if (activeMdiChild == form_1)
		{
			return;
		}
		bool flag = false;
		SuspendLayout();
		ribbonStrip_0.BeginUpdate();
		if (form_1 != null)
		{
			ArrayList arrayList = method_27(form_1);
			foreach (RibbonBarMergeContainer item in arrayList)
			{
				if (item.RibbonTabItem == SelectedRibbonTabItem)
				{
					flag = true;
				}
				item.RemoveMergedRibbonBars(this);
			}
			form_1 = null;
		}
		if (activeMdiChild != null)
		{
			ArrayList arrayList2 = method_27(activeMdiChild);
			if (arrayList2.Count > 0)
			{
				bool flag2 = true;
				foreach (RibbonBarMergeContainer item2 in arrayList2)
				{
					item2.MergeRibbonBars(this);
					if (flag2 && item2.RibbonTabItem != null && item2.AutoActivateTab)
					{
						item2.RibbonTabItem.Checked = true;
						flag = false;
					}
				}
				form_1 = activeMdiChild;
			}
		}
		if (flag)
		{
			SelectFirstVisibleRibbonTab();
		}
		ribbonStrip_0.EndUpdate(callRecalcLayout: false);
		ResumeLayout(performLayout: true);
		RecalcLayout();
	}

	public bool SelectFirstVisibleRibbonTab()
	{
		foreach (BaseItem item in Items)
		{
			if (item is RibbonTabItem && item.Visible)
			{
				((RibbonTabItem)item).Checked = true;
				return true;
			}
		}
		return false;
	}

	private ArrayList method_27(Form form_2)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		ArrayList arrayList = new ArrayList();
		foreach (Control item in (ArrangedElementCollection)((Control)form_2).get_Controls())
		{
			Control val = item;
			if (val is RibbonBarMergeContainer && ((RibbonBarMergeContainer)(object)val).AllowMerge)
			{
				arrayList.Add(val);
			}
		}
		return arrayList;
	}

	private void method_28(object sender, EventArgs e)
	{
		method_30();
	}

	private void method_29(object sender, EventArgs e)
	{
		method_30();
	}

	private void method_30()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		if (bool_1 && form_0 != null && (int)form_0.get_WindowState() == 2 && ((Control)form_0).get_Visible())
		{
			if (!bool_2)
			{
				ribbonStrip_0.method_47(form_0, bool_33: true);
				bool_2 = true;
			}
		}
		else
		{
			ribbonStrip_0.method_46(bool_33: true);
			bool_2 = false;
		}
	}

	internal void method_31(RibbonBar ribbonBar_0, int int_4, int int_5)
	{
		if (!Boolean_2)
		{
			return;
		}
		if (ribbonBar_0.CanCustomize && (ribbonBar_0.Rectangle_1.Contains(int_4, int_5) || ribbonBar_0.OverflowState))
		{
			vmethod_0(ribbonBar_0, bool_18: false);
			return;
		}
		BaseItem baseItem = ribbonBar_0.HitTest(int_4, int_5);
		if (baseItem != null && baseItem.CanCustomize && !baseItem.SystemItem)
		{
			vmethod_0(baseItem, bool_18: false);
		}
	}

	internal void method_32(RibbonStrip ribbonStrip_1, int int_4, int int_5)
	{
		if (Boolean_2)
		{
			BaseItem baseItem = ribbonStrip_1.HitTest(int_4, int_5);
			if (baseItem != null && baseItem.CanCustomize && !baseItem.SystemItem)
			{
				vmethod_0(baseItem, bool_18: true);
			}
		}
	}

	internal virtual void vmethod_0(object object_0, bool bool_18)
	{
		if (object_0 == null || !bool_4)
		{
			return;
		}
		ribbonStrip_0.method_3("syscustomizepopupmenu");
		ButtonItem buttonItem = new ButtonItem("syscustomizepopupmenu");
		buttonItem.Style = eDotNetBarStyle.Office2007;
		buttonItem.method_6(ribbonStrip_0);
		if ((method_40(object_0 as BaseItem) || object_0 is RibbonBar) && !bool_9)
		{
			if (object_0 is BaseItem && QuickToolbarItems.Contains((BaseItem)object_0))
			{
				ButtonItem buttonItem2 = new ButtonItem(SysQatRemoveFromItemName);
				buttonItem2.Text = SystemText.QatRemoveItemText;
				buttonItem2.Click += method_42;
				buttonItem2.Tag = object_0;
				buttonItem.SubItems.Add(buttonItem2);
			}
			else
			{
				BaseItem baseItem = object_0 as BaseItem;
				ButtonItem buttonItem3 = new ButtonItem(SysQatAddToItemName);
				buttonItem3.Text = SystemText.QatAddItemText;
				buttonItem3.Click += method_43;
				buttonItem3.Tag = object_0;
				buttonItem.SubItems.Add(buttonItem3);
				if ((baseItem != null && QuickToolbarItems.Contains(baseItem.Name)) || (object_0 is RibbonBar && QuickToolbarItems.Contains(method_41(object_0 as RibbonBar))))
				{
					buttonItem3.Enabled = false;
				}
				if (baseItem != null && BaseItem.IsOnPopup(baseItem) && baseItem.Parent != null)
				{
					object containerControl = baseItem.ContainerControl;
					Control val = (Control)((containerControl is Control) ? containerControl : null);
					if (val != null)
					{
						val.add_VisibleChanged((EventHandler)method_34);
					}
				}
			}
		}
		if (bool_4)
		{
			ButtonItem buttonItem4 = new ButtonItem(SysQatCustomizeItemName);
			buttonItem4.Text = SystemText.QatCustomizeText;
			buttonItem4.BeginGroup = true;
			buttonItem4.Click += method_39;
			buttonItem.SubItems.Add(buttonItem4);
		}
		if (bool_5 && !bool_9)
		{
			ButtonItem buttonItem5 = new ButtonItem(SysQatPlaceItemName);
			if (bool_6)
			{
				buttonItem5.Text = SystemText.QatPlaceAboveRibbonText;
			}
			else
			{
				buttonItem5.Text = SystemText.QatPlaceBelowRibbonText;
			}
			buttonItem5.Click += method_35;
			buttonItem.SubItems.Add(buttonItem5);
		}
		if (AutoExpand)
		{
			ButtonItem buttonItem6 = new ButtonItem(Expanded ? SysMinimizeRibbon : SysMaximizeRibbon, Expanded ? SystemText.MinimizeRibbonText : SystemText.MaximizeRibbonText);
			buttonItem6.Click += method_33;
			buttonItem6.BeginGroup = true;
			buttonItem.SubItems.Add(buttonItem6);
		}
		RibbonCustomizeEventArgs ribbonCustomizeEventArgs = new RibbonCustomizeEventArgs(object_0, buttonItem);
		OnBeforeCustomizeMenuPopup(ribbonCustomizeEventArgs);
		if (ribbonCustomizeEventArgs.Cancel)
		{
			buttonItem.Dispose();
			return;
		}
		((IOwnerMenuSupport)ribbonStrip_0).RegisterPopup((PopupItem)buttonItem);
		buttonItem.Popup(Control.get_MousePosition());
	}

	private void method_33(object sender, EventArgs e)
	{
		Expanded = !Expanded;
	}

	private void method_34(object sender, EventArgs e)
	{
		Control val = (Control)((sender is Control) ? sender : null);
		if (val != null)
		{
			val.remove_VisibleChanged((EventHandler)method_34);
			ribbonStrip_0.method_3("syscustomizepopupmenu");
		}
	}

	private void method_35(object sender, EventArgs e)
	{
		method_36();
	}

	internal void method_36()
	{
		ribbonStrip_0.ClosePopups();
		if (bool_6)
		{
			((Control)control7_0).set_Visible(false);
			ArrayList arrayList = new ArrayList(control7_0.SubItemsCollection_0.Count);
			control7_0.SubItemsCollection_0.method_4(arrayList);
			control7_0.SubItemsCollection_0.Clear();
			foreach (BaseItem item3 in arrayList)
			{
				ribbonStrip_0.CaptionContainerItem.SubItems.Add(item3);
			}
			if (class242_0 != null)
			{
				class242_0.method_2();
				class242_0 = null;
			}
			((ScrollableControl)this).get_DockPadding().set_Bottom(int_0);
			bool_6 = false;
			if (bool_3)
			{
				AutoSyncSize();
			}
			else
			{
				((Control)this).set_Height(((Control)this).get_Height() - (((Control)control7_0).get_Height() + ((ScrollableControl)control7_0).get_DockPadding().get_Top()));
			}
			((Component)(object)control7_0).Dispose();
			control7_0 = null;
		}
		else
		{
			if (control7_0 == null)
			{
				method_38();
			}
			((ScrollableControl)this).get_DockPadding().set_Bottom(1);
			control7_0.BeginUpdate();
			ArrayList arrayList2 = method_37(bool_18: true);
			foreach (BaseItem item4 in arrayList2)
			{
				QuickToolbarItems.Remove(item4);
				control7_0.SubItemsCollection_0.Add(item4);
			}
			control7_0.EndUpdate();
			((Control)control7_0).set_Height(control7_0.GetAutoSizeHeight());
			bool_6 = true;
			if (bool_3)
			{
				AutoSyncSize();
			}
			else
			{
				((Control)this).set_Height(((Control)this).get_Height() + (((Control)control7_0).get_Height() + ((ScrollableControl)control7_0).get_DockPadding().get_Top()));
			}
		}
		RecalcLayout();
		bool_7 = true;
	}

	private ArrayList method_37(bool bool_18)
	{
		ArrayList arrayList = new ArrayList();
		foreach (BaseItem quickToolbarItem in QuickToolbarItems)
		{
			if (!method_46(quickToolbarItem) && (!(quickToolbarItem is ButtonItem) || ((ButtonItem)quickToolbarItem).HotTrackingStyle != eHotTrackingStyle.Image || QuickToolbarItems.IndexOf(quickToolbarItem) != 0))
			{
				arrayList.Add(quickToolbarItem);
			}
			else if (bool_18 && quickToolbarItem is CustomizeItem)
			{
				arrayList.Add(quickToolbarItem);
			}
		}
		return arrayList;
	}

	private void method_38()
	{
		control7_0 = new Control7();
		control7_0.FadeEffect = ribbonStrip_0.FadeEffect;
		((Control)control7_0).set_Dock((DockStyle)2);
		((Control)this).get_Controls().Add((Control)(object)control7_0);
		if (!Expanded)
		{
			((Control)control7_0).BringToFront();
		}
	}

	private void method_39(object sender, EventArgs e)
	{
		ShowQatCustomizeDialog();
	}

	private bool method_40(BaseItem baseItem_0)
	{
		if (baseItem_0 == null)
		{
			return false;
		}
		if (baseItem_0.CanCustomize && !baseItem_0.SystemItem)
		{
			if (baseItem_0 is ItemContainer)
			{
				return false;
			}
			if (baseItem_0 is ButtonItem && QuickToolbarItems.IndexOf(baseItem_0) == 0)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private string method_41(RibbonBar ribbonBar_0)
	{
		return "qt_" + ((Control)ribbonBar_0).get_Name();
	}

	private void method_42(object sender, EventArgs e)
	{
		ButtonItem buttonItem = sender as ButtonItem;
		if (buttonItem.Tag is BaseItem)
		{
			BaseItem item = buttonItem.Tag as BaseItem;
			RemoveItemFromQuickAccessToolbar(item);
		}
		buttonItem.Tag = null;
	}

	public void RemoveItemFromQuickAccessToolbar(BaseItem item)
	{
		RibbonCustomizeEventArgs ribbonCustomizeEventArgs = new RibbonCustomizeEventArgs(item, null);
		OnBeforeRemoveItemFromQuickAccessToolbar(ribbonCustomizeEventArgs);
		if (!ribbonCustomizeEventArgs.Cancel)
		{
			QuickToolbarItems.Remove(item);
			RecalcLayout();
			bool_7 = true;
		}
	}

	private void method_43(object sender, EventArgs e)
	{
		ButtonItem buttonItem = sender as ButtonItem;
		AddItemToQuickAccessToolbar(buttonItem.Tag);
		buttonItem.Tag = null;
	}

	public void AddItemToQuickAccessToolbar(object originalItem)
	{
		BaseItem baseItem = method_44(originalItem);
		if (baseItem != null)
		{
			RibbonCustomizeEventArgs ribbonCustomizeEventArgs = new RibbonCustomizeEventArgs(baseItem, null);
			OnBeforeAddItemToQuickAccessToolbar(ribbonCustomizeEventArgs);
			if (!ribbonCustomizeEventArgs.Cancel)
			{
				QuickToolbarItems.Add(baseItem);
				RecalcLayout();
				bool_7 = true;
			}
		}
	}

	private BaseItem method_44(object object_0)
	{
		BaseItem result = null;
		if (object_0 is ButtonItem)
		{
			ButtonItem buttonItem = ((ButtonItem)object_0).Copy() as ButtonItem;
			buttonItem.ImageFixedSize = Size.Empty;
			buttonItem.FixedSize = Size.Empty;
			buttonItem.ButtonStyle = eButtonStyle.Default;
			buttonItem.ImagePosition = eImagePosition.Left;
			buttonItem.BeginGroup = false;
			buttonItem.UseSmallImage = true;
			if (buttonItem.Class261_0 != null && buttonItem.Class261_0.bool_2)
			{
				buttonItem.Text = Class243.smethod_3(buttonItem.Text);
			}
			if (buttonItem.Image == null && buttonItem.ImageIndex == -1 && buttonItem.Icon == null)
			{
				buttonItem.Image = (Image)(object)Class109.smethod_67("SystemImages.GreenLight.png");
			}
			else
			{
				buttonItem.ImageFixedSize = new Size(16, 16);
			}
			result = buttonItem;
		}
		else if (object_0 is BaseItem)
		{
			result = ((BaseItem)object_0).Copy();
		}
		else if (object_0 is RibbonBar)
		{
			RibbonBar ribbonBar = object_0 as RibbonBar;
			ButtonItem buttonItem2 = new ButtonItem(method_41(ribbonBar));
			buttonItem2.Image = ribbonBar.method_43();
			buttonItem2.ImageFixedSize = new Size(16, 16);
			buttonItem2.AutoExpandOnClick = true;
			buttonItem2.Tooltip = ((Control)ribbonBar).get_Text();
			buttonItem2.Text = ((Control)ribbonBar).get_Text();
			RibbonBar ribbonBar2 = null;
			bool flag = false;
			if (ribbonBar.Boolean_3)
			{
				ribbonBar.method_38();
				ribbonBar2 = ribbonBar.method_40(bool_38: true);
				flag = true;
			}
			else
			{
				ribbonBar2 = ribbonBar.method_40(bool_38: true);
			}
			foreach (BaseItem item2 in ribbonBar.Items)
			{
				BaseItem item = item2.Copy();
				ribbonBar2.Items.Add(item);
			}
			if (flag)
			{
				ribbonBar.RecalcLayout();
			}
			ItemContainer itemContainer = new ItemContainer();
			itemContainer.Stretch = true;
			ControlContainerItem controlContainerItem = new ControlContainerItem();
			controlContainerItem.AllowItemResize = false;
			itemContainer.SubItems.Add(controlContainerItem);
			controlContainerItem.Control = (Control)(object)ribbonBar2;
			buttonItem2.SubItems.Add(itemContainer);
			result = buttonItem2;
		}
		return result;
	}

	protected virtual void OnBeforeCustomizeMenuPopup(RibbonCustomizeEventArgs e)
	{
		if (customizeMenuPopupEventHandler_0 != null)
		{
			customizeMenuPopupEventHandler_0(this, e);
		}
	}

	protected virtual void OnBeforeAddItemToQuickAccessToolbar(RibbonCustomizeEventArgs e)
	{
		if (customizeMenuPopupEventHandler_1 != null)
		{
			customizeMenuPopupEventHandler_1(this, e);
		}
	}

	protected virtual void OnBeforeRemoveItemFromQuickAccessToolbar(RibbonCustomizeEventArgs e)
	{
		if (customizeMenuPopupEventHandler_2 != null)
		{
			customizeMenuPopupEventHandler_2(this, e);
		}
	}

	public virtual void ShowQatCustomizeDialog()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		Form val = (Form)(object)method_45();
		if (qatCustomizeDialogEventHandler_0 != null)
		{
			QatCustomizeDialogEventArgs qatCustomizeDialogEventArgs = new QatCustomizeDialogEventArgs(val);
			qatCustomizeDialogEventHandler_0(this, qatCustomizeDialogEventArgs);
			if (qatCustomizeDialogEventArgs.Cancel || qatCustomizeDialogEventArgs.Dialog == null)
			{
				((Component)(object)val).Dispose();
				return;
			}
			val = qatCustomizeDialogEventArgs.Dialog;
		}
		if (val is QatCustomizeDialog)
		{
			((QatCustomizeDialog)(object)val).LoadItems(this);
		}
		Form val2 = ((Control)this).FindForm();
		val.set_StartPosition((FormStartPosition)4);
		DialogResult val3 = val.ShowDialog((IWin32Window)(object)val2);
		if (qatCustomizeDialogEventHandler_1 != null)
		{
			QatCustomizeDialogEventArgs qatCustomizeDialogEventArgs2 = new QatCustomizeDialogEventArgs(val);
			qatCustomizeDialogEventHandler_1(this, qatCustomizeDialogEventArgs2);
			if (qatCustomizeDialogEventArgs2.Cancel)
			{
				((Component)(object)val).Dispose();
				return;
			}
		}
		if ((int)val3 == 2)
		{
			((Component)(object)val).Dispose();
		}
		else if (val is QatCustomizeDialog qatCustomizeDialog && qatCustomizeDialog.QatCustomizePanel.DataChanged)
		{
			ApplyQatCustomizePanelChanges(qatCustomizeDialog.QatCustomizePanel);
			((Component)(object)val).Dispose();
		}
	}

	public void ApplyQatCustomizePanelChanges(QatCustomizePanel customizePanel)
	{
		if (customizePanel == null || !customizePanel.DataChanged)
		{
			return;
		}
		ribbonStrip_0.BeginUpdate();
		try
		{
			ItemPanel itemPanelQat = customizePanel.itemPanelQat;
			int num = 0;
			BaseItem baseItem = method_47();
			if (baseItem != null)
			{
				num = QuickToolbarItems.IndexOf(baseItem) + 1;
			}
			ArrayList arrayList = new ArrayList();
			SubItemsCollection subItemsCollection = new SubItemsCollection(null);
			for (int i = num; i < QuickToolbarItems.Count; i++)
			{
				BaseItem baseItem2 = QuickToolbarItems[i];
				if (!method_46(baseItem2))
				{
					if (!itemPanelQat.Items.Contains(baseItem2.Name))
					{
						arrayList.Add(baseItem2);
					}
					else
					{
						subItemsCollection.method_0(baseItem2);
					}
				}
			}
			foreach (BaseItem item4 in arrayList)
			{
				QuickToolbarItems.Remove(item4);
			}
			foreach (BaseItem item5 in subItemsCollection)
			{
				QuickToolbarItems.Remove(item5);
			}
			foreach (BaseItem item6 in itemPanelQat.Items)
			{
				if (item6.Tag != null)
				{
					BaseItem item3 = method_44(item6.Tag as BaseItem);
					QuickToolbarItems.Add(item3);
					continue;
				}
				BaseItem baseItem4 = subItemsCollection[item6.Name];
				if (baseItem4 != null)
				{
					QuickToolbarItems.Add(baseItem4);
				}
			}
			bool_7 = true;
		}
		finally
		{
			ribbonStrip_0.EndUpdate();
		}
		if (customizePanel.checkQatBelowRibbon.Checked != bool_6)
		{
			method_36();
		}
		OnAfterQatDialogChangesApplied();
	}

	protected virtual void OnAfterQatDialogChangesApplied()
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, new EventArgs());
		}
	}

	private QatCustomizeDialog method_45()
	{
		QatCustomizeDialog qatCustomizeDialog = new QatCustomizeDialog();
		((Control)qatCustomizeDialog).set_Text(SystemText.QatDialogCaption);
		((Control)qatCustomizeDialog.buttonCancel).set_Text(SystemText.QatDialogCancelButton);
		((Control)qatCustomizeDialog.buttonOK).set_Text(SystemText.QatDialogOkButton);
		((Control)qatCustomizeDialog.QatCustomizePanel.buttonAddToQat).set_Text(SystemText.QatDialogAddButton);
		((Control)qatCustomizeDialog.QatCustomizePanel.buttonRemoveFromQat).set_Text(SystemText.QatDialogRemoveButton);
		((Control)qatCustomizeDialog.QatCustomizePanel.labelCategories).set_Text(SystemText.QatDialogCategoriesLabel);
		((Control)qatCustomizeDialog.QatCustomizePanel.checkQatBelowRibbon).set_Text(SystemText.QatDialogPlacementCheckbox);
		return qatCustomizeDialog;
	}

	private bool method_46(BaseItem baseItem_0)
	{
		if (!baseItem_0.SystemItem && !(baseItem_0 is ItemContainer) && !(baseItem_0 is CustomizeItem) && !(baseItem_0 is SystemCaptionItem))
		{
			return false;
		}
		return true;
	}

	internal BaseItem method_47()
	{
		return ribbonStrip_0.method_43();
	}

	private string method_48()
	{
		ArrayList arrayList = method_37(bool_18: false);
		StringBuilder stringBuilder = new StringBuilder();
		if (bool_6)
		{
			stringBuilder.Append("1");
		}
		else
		{
			stringBuilder.Append("0");
		}
		foreach (BaseItem item in arrayList)
		{
			if (item.Name != "")
			{
				stringBuilder.Append("," + item.Name);
			}
		}
		return stringBuilder.ToString();
	}

	private void method_49(string string_1)
	{
		if (string_1 == "" || string_1 == null)
		{
			return;
		}
		string[] array = string_1.Split(new char[1] { ',' });
		if (array.Length == 0)
		{
			return;
		}
		bool flag = array[0] == "1";
		ArrayList arrayList = new ArrayList();
		for (int i = 1; i < array.Length; i++)
		{
			if (QuickToolbarItems.Contains(array[i]))
			{
				arrayList.Add(QuickToolbarItems[array[i]]);
			}
			else if (array[i].StartsWith("qt_"))
			{
				RibbonBar ribbonBar = method_50(array[i].Substring(3));
				if (ribbonBar != null)
				{
					arrayList.Add(method_44(ribbonBar));
				}
			}
			else
			{
				BaseItem item = ribbonStrip_0.GetItem(array[i]);
				if (item != null && method_40(item))
				{
					arrayList.Add(method_44(item));
				}
			}
		}
		ArrayList arrayList2 = method_37(bool_18: false);
		foreach (BaseItem item4 in arrayList2)
		{
			QuickToolbarItems.Remove(item4);
		}
		foreach (BaseItem item5 in arrayList)
		{
			QuickToolbarItems.Add(item5);
		}
		if (bool_6 != flag)
		{
			method_36();
		}
		bool_7 = false;
	}

	private RibbonBar method_50(string string_1)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control control_ = item;
			RibbonBar ribbonBar = method_51(control_, string_1);
			if (ribbonBar != null)
			{
				return ribbonBar;
			}
		}
		return null;
	}

	private RibbonBar method_51(Control control_0, string string_1)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		if (control_0 is RibbonBar && control_0.get_Name() == string_1)
		{
			return control_0 as RibbonBar;
		}
		foreach (Control item in (ArrangedElementCollection)control_0.get_Controls())
		{
			Control control_ = item;
			RibbonBar ribbonBar = method_51(control_, string_1);
			if (ribbonBar != null)
			{
				return ribbonBar;
			}
		}
		return null;
	}
}

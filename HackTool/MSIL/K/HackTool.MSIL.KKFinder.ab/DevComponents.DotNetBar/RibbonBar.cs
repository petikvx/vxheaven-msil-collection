using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

[ToolboxBitmap(typeof(RibbonBar), "Ribbon.RibbonBar.ico")]
[ToolboxItem(true)]
[Designer(typeof(RibbonBarDesigner))]
[ComVisible(false)]
public class RibbonBar : ItemControl
{
	private EventHandler eventHandler_19;

	private OverflowButtonEventHandler overflowButtonEventHandler_0;

	private OverflowButtonEventHandler overflowButtonEventHandler_1;

	private OverflowButtonEventHandler overflowButtonEventHandler_2;

	private EventHandler eventHandler_20;

	private EventHandler eventHandler_21;

	private EventHandler eventHandler_22;

	private MouseEventHandler mouseEventHandler_3;

	private ItemContainer itemContainer_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private ElementStyle elementStyle_1;

	private ElementStyle elementStyle_2;

	private Class110 class110_0 = new Class110();

	private bool bool_25;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Image image_0;

	private Image image_1;

	private bool bool_26;

	private bool bool_27 = true;

	private Class184 sysOverflowButton;

	private RibbonBar ribbonBar_0;

	private string string_2 = "";

	private Image image_2;

	private int int_4;

	private bool bool_28;

	private int int_5 = 25;

	private Size size_0 = Size.Empty;

	private bool bool_29;

	private ElementStyle elementStyle_3 = new ElementStyle();

	private eRibbonTitlePosition eRibbonTitlePosition_0 = eRibbonTitlePosition.Bottom;

	private bool bool_30 = true;

	private bool bool_31;

	private ElementStyle elementStyle_4 = new ElementStyle();

	private ElementStyle elementStyle_5 = new ElementStyle();

	private ElementStyle elementStyle_6 = new ElementStyle();

	private ElementStyle elementStyle_7 = new ElementStyle();

	private bool bool_32 = true;

	private ArrayList arrayList_1 = new ArrayList();

	private bool bool_33 = true;

	private Size size_1 = Size.Empty;

	private Size size_2 = Size.Empty;

	private string string_3 = "";

	private bool bool_34;

	private GalleryContainer galleryContainer_0;

	private Timer timer_2;

	private bool bool_35 = true;

	private bool bool_36;

	private eVerticalItemsAlignment eVerticalItemsAlignment_0;

	private eOrientation eOrientation_0;

	private eHorizontalItemsAlignment eHorizontalItemsAlignment_0;

	private RibbonBar ribbonBar_1;

	private string string_4 = "";

	private Bitmap bitmap_0;

	private int int_6 = 1;

	private int int_7;

	private bool bool_37;

	private ReaderWriterLock readerWriterLock_0 = new ReaderWriterLock();

	[Description("Indicates whether Office 2007 Design Guidelines specification for positioning KeyTips is used.")]
	[DefaultValue(false)]
	[Category("KeyTips")]
	public bool UseSpecKeyTipsPositioning
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

	[Description("Indicates Accessible name for the Dialog Launcher button.")]
	[DefaultValue("")]
	[Category("Accessibility")]
	[Browsable(true)]
	public string DialogLauncherAccessibleName
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Description("Indicates mouse over background style.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public ElementStyle BackgroundMouseOverStyle => elementStyle_3;

	[DefaultValue(null)]
	[Category("Appearance")]
	[Description("Indicates image that is used as dialog luncher button in ribbon title bar.")]
	[Browsable(true)]
	public Image DialogLauncherButton
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			method_31();
		}
	}

	[Description("Indicates image that is used as dialog launcher button when mouse is over the button.")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Appearance")]
	public Image DialogLauncherMouseOverButton
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

	[DefaultValue(25)]
	[Category("Overflow")]
	[Description("Indicates maximum text length for automatic overflow button text.")]
	[Browsable(true)]
	public int MaximumOverflowTextLength
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
		}
	}

	[Category("Overflow")]
	[DefaultValue(0)]
	[Browsable(true)]
	[Description("Indicates resize order index of the control.")]
	public int ResizeOrderIndex
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
		}
	}

	public bool AutoOverflowEnabled
	{
		get
		{
			return bool_27;
		}
		set
		{
			if (bool_27 != value)
			{
				bool_27 = value;
				method_26();
			}
		}
	}

	[Category("Overflow")]
	[Browsable(true)]
	[Description("Indicates text for overflow button that is created when ribbon bar size is reduced so it cannot display all its content")]
	[DefaultValue("")]
	public string OverflowButtonText
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			method_27();
		}
	}

	[Description("Indicates image for overflow button that is created when ribbon bar size is reduced so it cannot display all its content")]
	[Browsable(true)]
	[Category("Overflow")]
	[DefaultValue(null)]
	public Image OverflowButtonImage
	{
		get
		{
			return image_2;
		}
		set
		{
			image_2 = value;
			method_27();
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether dialog launcher button is visible in title of the ribbon.")]
	[Category("Behavior")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public bool DialogLauncherVisible
	{
		get
		{
			return bool_25;
		}
		set
		{
			bool_25 = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(eOrientation.Horizontal)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Layout")]
	public virtual eOrientation LayoutOrientation
	{
		get
		{
			return itemContainer_0.LayoutOrientation;
		}
		set
		{
			itemContainer_0.LayoutOrientation = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DefaultValue(1)]
	[Description("Indicates spacing in pixels between items.")]
	[Category("Layout")]
	[Browsable(true)]
	public int ItemSpacing
	{
		get
		{
			return itemContainer_0.ItemSpacing;
		}
		set
		{
			itemContainer_0.ItemSpacing = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Layout")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool ResizeItemsToFit
	{
		get
		{
			return itemContainer_0.ResizeItemsToFit;
		}
		set
		{
			itemContainer_0.ResizeItemsToFit = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(eHorizontalItemsAlignment.Left)]
	[Category("Layout")]
	[Description("Indicates item alignment when container is in horizontal layout.")]
	[Browsable(true)]
	public eHorizontalItemsAlignment HorizontalItemAlignment
	{
		get
		{
			return itemContainer_0.HorizontalItemAlignment;
		}
		set
		{
			itemContainer_0.HorizontalItemAlignment = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates item item vertical alignment.")]
	[DefaultValue(eVerticalItemsAlignment.Top)]
	[Category("Layout")]
	public eVerticalItemsAlignment VerticalItemAlignment
	{
		get
		{
			return itemContainer_0.VerticalItemAlignment;
		}
		set
		{
			itemContainer_0.VerticalItemAlignment = value;
			if (((Component)(object)this).DesignMode)
			{
				RecalcLayout();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public SubItemsCollection Items
	{
		get
		{
			if (OverflowState && !((Component)(object)this).DesignMode)
			{
				return ribbonBar_0.Items;
			}
			return itemContainer_0.SubItems;
		}
	}

	internal Rectangle Rectangle_0 => rectangle_1;

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates whether ribbon bar can be customized by end user i.e. added to Quick Access Toolbar.")]
	[Browsable(true)]
	public virtual bool CanCustomize
	{
		get
		{
			return bool_32;
		}
		set
		{
			bool_32 = value;
		}
	}

	internal GalleryContainer GalleryContainer_0
	{
		get
		{
			return galleryContainer_0;
		}
		set
		{
			galleryContainer_0 = value;
		}
	}

	internal Size Size_0 => size_0;

	internal Size Size_1 => size_2;

	internal new bool Boolean_3 => arrayList_1.Count > 0;

	internal bool Boolean_4
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

	internal RibbonBar RibbonBar_0
	{
		get
		{
			return ribbonBar_1;
		}
		set
		{
			ribbonBar_1 = value;
		}
	}

	[Browsable(false)]
	public bool OverflowState
	{
		get
		{
			if (sysOverflowButton != null)
			{
				return true;
			}
			return false;
		}
	}

	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates whether ButtonItem objects hosted on control are resized to reduce the space consumed by ribbon bar when required.")]
	public bool AutoSizeItems
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

	public override Rectangle DisplayRectangle
	{
		get
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			if (!rectangle_0.IsEmpty && bool_30)
			{
				if (eRibbonTitlePosition_0 == eRibbonTitlePosition.Top)
				{
					clientRectangle.Y += rectangle_0.Height;
					clientRectangle.Height -= rectangle_0.Height;
				}
				else
				{
					clientRectangle.Height -= rectangle_0.Height;
				}
			}
			return clientRectangle;
		}
	}

	[Description("Specifies the visual style of the control.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public eDotNetBarStyle Style
	{
		get
		{
			return itemContainer_0.Style;
		}
		set
		{
			base.ColorScheme.EDotNetBarStyle_0 = value;
			itemContainer_0.Style = value;
			((Control)this).Invalidate();
			RecalcLayout();
		}
	}

	protected override bool NeedsTopLevelKeyTipCanvasParent
	{
		get
		{
			if (DialogLauncherVisible && DialogLauncherKeyTip != "")
			{
				return true;
			}
			return false;
		}
	}

	[Description("Indicates KeyTip for the dialog launcher button.")]
	[Category("Behavior")]
	[DefaultValue("")]
	public string DialogLauncherKeyTip
	{
		get
		{
			return string_4;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_4 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Appearance")]
	[Description("Indicates whether ribbon bar title is visible")]
	public bool TitleVisible
	{
		get
		{
			return bool_30;
		}
		set
		{
			bool_30 = value;
			RecalcLayout();
		}
	}

	[Category("Style")]
	[Description("Specifies the style of the title of the control")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public ElementStyle TitleStyle => elementStyle_1;

	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Specifies the style of the title of the control when mouse is over the control.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public ElementStyle TitleStyleMouseOver => elementStyle_2;

	internal Rectangle Rectangle_1 => class110_0.Bounds;

	[Description("Indicates whether control changes its background when mouse is over the control.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool BackgroundHoverEnabled
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

	[Category("Behavior")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Gets or sets whether external ButtonItem object is accepted in drag and drop operation.")]
	public override bool AllowExternalDrop
	{
		get
		{
			return base.AllowExternalDrop;
		}
		set
		{
			base.AllowExternalDrop = value;
		}
	}

	[Category("Behavior")]
	[Browsable(true)]
	[Description("Specifies whether native .NET Drag and Drop is used by control to perform drag and drop operations.")]
	[DefaultValue(false)]
	public override bool UseNativeDragDrop
	{
		get
		{
			return base.UseNativeDragDrop;
		}
		set
		{
			base.UseNativeDragDrop = value;
		}
	}

	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Specifies whether automatic drag & drop support is enabled.")]
	public virtual bool EnableDragDrop
	{
		get
		{
			return bool_31;
		}
		set
		{
			bool_31 = value;
		}
	}

	[Description("Specifies background color of the Bar.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DevCoBrowsable(true)]
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

	[Description("Occurs when dialog launcher button in title bar is clicked. Use DialogLauncherVisible property to show the button in title bar.")]
	public event EventHandler LaunchDialog
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

	[Description("Occurs when overflow button for control is created because control size is below the minimum size required to display complete content of the control.")]
	public event OverflowButtonEventHandler OverflowButtonSetup
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			overflowButtonEventHandler_0 = (OverflowButtonEventHandler)Delegate.Combine(overflowButtonEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			overflowButtonEventHandler_0 = (OverflowButtonEventHandler)Delegate.Remove(overflowButtonEventHandler_0, value);
		}
	}

	[Description("Occurs after overflow button setup is complete and all items contained by this control are moved to it.")]
	public event OverflowButtonEventHandler OverflowButtonSetupComplete
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			overflowButtonEventHandler_1 = (OverflowButtonEventHandler)Delegate.Combine(overflowButtonEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			overflowButtonEventHandler_1 = (OverflowButtonEventHandler)Delegate.Remove(overflowButtonEventHandler_1, value);
		}
	}

	[Description("Occurs before overflow button is destroyed.")]
	public event OverflowButtonEventHandler OverflowButtonDestroy
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			overflowButtonEventHandler_2 = (OverflowButtonEventHandler)Delegate.Combine(overflowButtonEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			overflowButtonEventHandler_2 = (OverflowButtonEventHandler)Delegate.Remove(overflowButtonEventHandler_2, value);
		}
	}

	[Description("")]
	public event EventHandler DialogLauncherMouseEnter
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

	[Description("Occurs when mouse leaves dialog launcher button.")]
	public event EventHandler DialogLauncherMouseLeave
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

	[Description("Occurs when mouse hovers over the dialog launcher button.")]
	public event EventHandler DialogLauncherMouseHover
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

	[Description("Occurs when mouse is pressed over the dialog launcher button.")]
	public event MouseEventHandler DialogLauncherMouseDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_3 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_3, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_3 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_3, (Delegate?)(object)value);
		}
	}

	public RibbonBar()
	{
		((Control)this).set_BackColor(Color.Transparent);
		itemContainer_0 = new ItemContainer();
		itemContainer_0.GlobalItem = false;
		itemContainer_0.ContainerControl = this;
		itemContainer_0.Stretch = false;
		itemContainer_0.Displayed = true;
		itemContainer_0.Style = eDotNetBarStyle.Office2007;
		base.ColorScheme.EDotNetBarStyle_0 = eDotNetBarStyle.Office2007;
		itemContainer_0.method_6(this);
		itemContainer_0.method_23(bool_26: true);
		SetBaseItemContainer(itemContainer_0);
		DragDropSupport = true;
		elementStyle_1 = new ElementStyle();
		elementStyle_1.method_4(GetColorScheme());
		elementStyle_1.StyleChanged += elementStyle_2_StyleChanged;
		elementStyle_2 = new ElementStyle();
		elementStyle_2.method_4(GetColorScheme());
		elementStyle_2.StyleChanged += elementStyle_2_StyleChanged;
		elementStyle_3.method_4(GetColorScheme());
		elementStyle_3.StyleChanged += elementStyle_3_StyleChanged;
		base.ItemAdded += RibbonBar_ItemAdded;
		base.ItemRemoved += RibbonBar_ItemRemoved;
	}

	protected override void Dispose(bool disposing)
	{
		method_29();
		base.Dispose(disposing);
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new RibbonBarAccessibleObject(this);
	}

	protected override void OnItemClick(BaseItem item)
	{
		base.OnItemClick(item);
		if (Boolean_4 && ((Control)this).get_Parent() is MenuPanel && item != null && item.AutoCollapseOnClick && item is ButtonItem && !item.Name.StartsWith("sysgallery"))
		{
			ButtonItem buttonItem = item as ButtonItem;
			if (!buttonItem.AutoExpandOnClick)
			{
				CloseOverflowPopup();
			}
		}
	}

	public void CloseOverflowPopup()
	{
		if (Boolean_4)
		{
			if (((Control)this).get_Parent() is MenuPanel && ((MenuPanel)(object)((Control)this).get_Parent()).ParentItem is Class184 @class && @class.Expanded)
			{
				@class.Expanded = false;
			}
		}
		else if (OverflowState && sysOverflowButton != null && sysOverflowButton.Expanded)
		{
			sysOverflowButton.Expanded = false;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackgroundMouseOverStyle()
	{
		elementStyle_3.StyleChanged -= elementStyle_3_StyleChanged;
		elementStyle_3 = new ElementStyle();
		elementStyle_3.StyleChanged += elementStyle_3_StyleChanged;
		((Control)this).Invalidate();
	}

	protected virtual ElementStyle GetBackgroundMouseOverStyle()
	{
		if (!bool_35)
		{
			return null;
		}
		if (OverflowState && sysOverflowButton.Expanded)
		{
			return GetBackgroundStyle();
		}
		if (elementStyle_3.Custom)
		{
			ElementStyle elementStyle = elementStyle_5.Copy();
			elementStyle.ApplyStyle(elementStyle_3);
			return elementStyle;
		}
		return elementStyle_5;
	}

	protected override ElementStyle GetBackgroundStyle()
	{
		if (OverflowState && sysOverflowButton.Expanded && GetRenderer() is Office2007Renderer office2007Renderer)
		{
			return RibbonPredefinedColorSchemes.smethod_8(office2007Renderer.ColorTable.RibbonBar.Expanded);
		}
		if (base.BackgroundStyle.Custom)
		{
			ElementStyle elementStyle = elementStyle_4.Copy();
			elementStyle.ApplyStyle(base.BackgroundStyle);
			return elementStyle;
		}
		return elementStyle_4;
	}

	private ElementStyle method_24()
	{
		if (elementStyle_1.Custom)
		{
			ElementStyle elementStyle = elementStyle_6.Copy();
			elementStyle.ApplyStyle(elementStyle_1);
			return elementStyle;
		}
		return elementStyle_6;
	}

	private ElementStyle method_25()
	{
		if (!bool_35)
		{
			return null;
		}
		if (elementStyle_2.Custom)
		{
			ElementStyle elementStyle = elementStyle_7.Copy();
			elementStyle.ApplyStyle(elementStyle_2);
			return elementStyle;
		}
		return elementStyle_7;
	}

	private void elementStyle_3_StyleChanged(object sender, EventArgs e)
	{
		if (GetDesignMode())
		{
			RecalcLayout();
		}
		else if (((Control)this).get_Parent() != null && ((Component)(object)((Control)this).get_Parent()).Site != null && ((Component)(object)((Control)this).get_Parent()).Site!.DesignMode)
		{
			RecalcLayout();
		}
	}

	private void method_26()
	{
		if (sysOverflowButton != null)
		{
			method_42();
		}
		RecalcLayout();
	}

	private void method_27()
	{
		if (sysOverflowButton != null)
		{
			sysOverflowButton.Text = string_2;
			sysOverflowButton.Image = image_2;
		}
	}

	public void DoLaunchDialog()
	{
		InvokeLaunchDialog(new EventArgs());
	}

	protected virtual void InvokeLaunchDialog(EventArgs e)
	{
		if (eventHandler_19 != null)
		{
			eventHandler_19(this, e);
		}
	}

	protected override void OnPopupItemRightClick(BaseItem item)
	{
		GetRibbonControl()?.vmethod_0(item, bool_18: false);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		base.OnMouseDown(e);
		if (rectangle_1.Contains(e.get_X(), e.get_Y()) && !rectangle_1.IsEmpty && bool_30 && !OverflowState)
		{
			((Control)this).Invalidate(rectangle_1);
			OnDialogLauncherMouseDown(e);
		}
		if ((int)e.get_Button() == 2097152)
		{
			GetRibbonControl()?.method_31(this, e.get_X(), e.get_Y());
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		base.OnMouseUp(e);
		if (!rectangle_1.Contains(e.get_X(), e.get_Y()) || (int)e.get_Button() != 1048576)
		{
			return;
		}
		if (!rectangle_1.IsEmpty)
		{
			((Control)this).Invalidate(rectangle_1);
		}
		if (((Control)this).get_Parent() is MenuPanel)
		{
			if (((MenuPanel)(object)((Control)this).get_Parent()).ParentItem is PopupItem popupItem)
			{
				popupItem.ClosePopup();
			}
		}
		else if (((Control)this).get_Parent() is Bar && ((Bar)(object)((Control)this).get_Parent()).BarState == eBarState.Popup && ((Bar)(object)((Control)this).get_Parent()).ParentItem is PopupItem popupItem2)
		{
			popupItem2.ClosePopup();
		}
		InvokeLaunchDialog(new EventArgs());
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		method_51(bool_38: true);
		if (((elementStyle_2 != null && elementStyle_2.Custom) || elementStyle_7.Custom) && bool_30 && !OverflowState)
		{
			((Control)this).Invalidate(GetTitleRectangle());
		}
		ElementStyle backgroundMouseOverStyle = GetBackgroundMouseOverStyle();
		if (backgroundMouseOverStyle != null && backgroundMouseOverStyle.Custom)
		{
			((Control)this).Invalidate();
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
		if (((Control)this).get_ClientRectangle().Contains(pt))
		{
			Form val = ((Control)this).FindForm();
			if (val != null && Form.get_ActiveForm() == val)
			{
				method_28();
				return;
			}
		}
		method_51(bool_38: false);
		method_30(bool_38: false);
		if (((elementStyle_2 != null && elementStyle_2.Custom) || elementStyle_7.Custom) && bool_30 && !OverflowState)
		{
			((Control)this).Invalidate(GetTitleRectangle());
		}
		ElementStyle backgroundMouseOverStyle = GetBackgroundMouseOverStyle();
		if (backgroundMouseOverStyle != null && backgroundMouseOverStyle.Custom)
		{
			((Control)this).Invalidate();
		}
	}

	private void method_28()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if (timer_2 == null)
		{
			timer_2 = new Timer();
			timer_2.set_Interval(500);
			timer_2.add_Tick((EventHandler)timer_2_Tick);
			timer_2.set_Enabled(true);
			timer_2.Start();
		}
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
		if (!((Control)this).get_ClientRectangle().Contains(pt) || !((Control)this).get_Visible())
		{
			timer_2.Stop();
			timer_2.set_Enabled(false);
			method_51(bool_38: false);
			method_29();
		}
	}

	private void method_29()
	{
		if (timer_2 != null)
		{
			timer_2.Stop();
			((Component)(object)timer_2).Dispose();
			timer_2 = null;
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (bool_25)
		{
			if (rectangle_1.Contains(e.get_X(), e.get_Y()))
			{
				method_30(bool_38: true);
			}
			else
			{
				method_30(bool_38: false);
			}
		}
	}

	protected override void InternalMouseMove(MouseEventArgs e)
	{
		if (bool_30 && !rectangle_0.IsEmpty && rectangle_0.Contains(e.get_X(), e.get_Y()))
		{
			if (itemContainer_0.BaseItem_1 != null)
			{
				itemContainer_0.InternalMouseLeave();
			}
		}
		else
		{
			base.InternalMouseMove(e);
		}
	}

	protected override void OnMouseHover(EventArgs e)
	{
		base.OnMouseHover(e);
		if (bool_26)
		{
			OnDialogLauncherMouseHover(new EventArgs());
		}
	}

	private void method_30(bool bool_38)
	{
		if (bool_26 != bool_38)
		{
			bool_26 = bool_38;
			((Control)this).Invalidate(rectangle_1);
			if (bool_38)
			{
				OnDialogLauncherMouseEnter(new EventArgs());
			}
			else
			{
				OnDialogLauncherMouseLeave(new EventArgs());
			}
		}
	}

	protected virtual void OnDialogLauncherMouseEnter(EventArgs e)
	{
		if (eventHandler_20 != null)
		{
			eventHandler_20(this, e);
		}
	}

	protected virtual void OnDialogLauncherMouseLeave(EventArgs e)
	{
		if (eventHandler_21 != null)
		{
			eventHandler_21(this, e);
		}
	}

	protected virtual void OnDialogLauncherMouseHover(EventArgs e)
	{
		if (eventHandler_22 != null)
		{
			eventHandler_22(this, e);
		}
	}

	protected virtual void OnDialogLauncherMouseDown(MouseEventArgs e)
	{
		if (mouseEventHandler_3 != null)
		{
			mouseEventHandler_3.Invoke((object)this, e);
		}
	}

	public override ArrayList GetItems(string ItemName)
	{
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl == null)
		{
			return base.GetItems(ItemName);
		}
		return ribbonControl.RibbonStrip.GetItems(ItemName);
	}

	public override ArrayList GetItems(string ItemName, Type itemType)
	{
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl == null)
		{
			return base.GetItems(ItemName, itemType);
		}
		return ribbonControl.RibbonStrip.GetItems(ItemName, itemType);
	}

	public override BaseItem GetItem(string ItemName)
	{
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl == null)
		{
			return base.GetItem(ItemName);
		}
		return ribbonControl.RibbonStrip.GetItem(ItemName);
	}

	public override ArrayList GetItems(string ItemName, Type itemType, bool useGlobalName)
	{
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl == null)
		{
			return base.GetItems(ItemName, itemType, useGlobalName);
		}
		return ribbonControl.RibbonStrip.GetItems(ItemName, itemType, useGlobalName);
	}

	protected override void OnShowKeyTipsChanged()
	{
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null && ShowKeyTips)
		{
			ribbonControl.RibbonStrip.method_38(this);
		}
		base.OnShowKeyTipsChanged();
	}

	protected override BaseItem GetItemForMnemonic(BaseItem container, char charCode, bool deepScan, bool stackKeys)
	{
		BaseItem itemForMnemonic = base.GetItemForMnemonic(container, charCode, deepScan, stackKeys);
		if (itemForMnemonic == null && OverflowState)
		{
			itemForMnemonic = ribbonBar_0.GetItemForMnemonic(ribbonBar_0.itemContainer_0, charCode, deepScan, stackKeys);
		}
		return itemForMnemonic;
	}

	protected override void OnTextChanged(EventArgs e)
	{
		class110_0.Text = ((Control)this).get_Text();
		if (sysOverflowButton != null)
		{
			sysOverflowButton.Text = method_44();
		}
		RecalcLayout();
		((Control)this).OnTextChanged(e);
	}

	private void method_31()
	{
		RecalcLayout();
	}

	private void method_32()
	{
		ColorScheme colorScheme = GetColorScheme();
		elementStyle_4.method_4(colorScheme);
		elementStyle_5.method_4(colorScheme);
		elementStyle_6.method_4(colorScheme);
		elementStyle_7.method_4(colorScheme);
		RibbonPredefinedColorSchemes.smethod_6(elementStyle_4, elementStyle_5, elementStyle_6, elementStyle_7, this);
	}

	private void RibbonBar_ItemRemoved(object sender, ItemRemovedEventArgs e)
	{
		if (sender == galleryContainer_0)
		{
			galleryContainer_0 = null;
		}
	}

	private void RibbonBar_ItemAdded(object sender, EventArgs e)
	{
		if (sender is GalleryContainer)
		{
			GalleryContainer galleryContainer = sender as GalleryContainer;
			if (galleryContainer.StretchGallery && galleryContainer_0 == null)
			{
				galleryContainer_0 = galleryContainer;
			}
		}
	}

	private Size method_33()
	{
		Rectangle itemContainerRectangle = base.GetItemContainerRectangle();
		if (bool_30)
		{
			Rectangle titleRectangle = GetTitleRectangle();
			if (eRibbonTitlePosition_0 == eRibbonTitlePosition.Top)
			{
				titleRectangle.Height++;
				itemContainerRectangle.Y += titleRectangle.Height;
				itemContainerRectangle.Height -= titleRectangle.Height;
			}
			else
			{
				titleRectangle.Height++;
				itemContainerRectangle.Height -= titleRectangle.Height;
			}
		}
		return itemContainerRectangle.Size;
	}

	protected override void RecalcSize()
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Invalid comparison between Unknown and I4
		if (!Class109.smethod_11((Control)(object)this) || bool_28)
		{
			return;
		}
		method_32();
		ElementStyle backgroundStyle = GetBackgroundStyle();
		if (bool_30)
		{
			Class100 @class = new Class100();
			class110_0.Image = image_0;
			if (image_0 != null && bool_25)
			{
				class110_0.ImageAlignment = eSimplePartAlignment.FarCenter;
			}
			@class.isimpleElement_0 = class110_0;
			@class.elementStyle_0 = method_24();
			@class.font_0 = ((Control)this).get_Font();
			@class.bool_0 = (int)((Control)this).get_RightToLeft() != 1;
			@class.bool_1 = false;
			@class.int_0 = ((Control)this).get_ClientRectangle().X;
			@class.int_1 = ((Control)this).get_ClientRectangle().Y;
			class110_0.FixedWidth = ((Control)this).get_ClientRectangle().Width;
			if (backgroundStyle != null)
			{
				if (backgroundStyle.Boolean_2)
				{
					class110_0.FixedWidth -= backgroundStyle.BorderRightWidth;
				}
				if (backgroundStyle.Boolean_3)
				{
					@class.int_1 += backgroundStyle.BorderTopWidth;
				}
			}
			Graphics val = CreateGraphics();
			try
			{
				@class.graphics_0 = val;
				Class101.smethod_0(@class);
				if (eRibbonTitlePosition_0 == eRibbonTitlePosition.Bottom)
				{
					@class.int_1 = ((Control)this).get_ClientRectangle().Bottom - class110_0.Bounds.Height;
					if (backgroundStyle != null && backgroundStyle.Boolean_4)
					{
						@class.int_1 -= backgroundStyle.BorderBottomWidth;
					}
					Class101.smethod_0(@class);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			rectangle_0 = class110_0.Bounds;
		}
		else
		{
			rectangle_0 = Rectangle.Empty;
		}
		method_38();
		size_1 = Size.Empty;
		if (((Control)this).get_Parent() is RibbonPanel)
		{
			RibbonControl ribbonControl = GetRibbonControl();
			if (ribbonControl != null && !((Control)ribbonControl).get_AutoSize())
			{
				itemContainer_0.MinimumSize = new Size(0, method_33().Height);
			}
		}
		else if (Boolean_4 && !((Control)this).get_AutoSize())
		{
			itemContainer_0.MinimumSize = new Size(0, method_33().Height);
		}
		else
		{
			itemContainer_0.MinimumSize = Size.Empty;
		}
		base.RecalcSize();
		Size size = method_45();
		if (method_34(size.Width))
		{
			size_2 = Size.Empty;
		}
		else
		{
			if (!AutoOverflowEnabled || ((Component)(object)this).DesignMode)
			{
				return;
			}
			if (size.Width > ((Control)this).get_Width())
			{
				if (arrayList_1.Count == 0 && bool_33 && ((Control)this).get_Width() > 1 && !OverflowState)
				{
					method_36(size.Width);
					base.RecalcSize();
					Size size2 = method_45();
					if (size2.Width > ((Control)this).get_Width())
					{
						method_38();
					}
					else
					{
						size_2 = size2;
						size_1 = size;
						size = size2;
					}
				}
				if (!OverflowState && size.Width > ((Control)this).get_Width())
				{
					size_0 = size;
					method_41();
					base.RecalcSize();
				}
			}
			else if (OverflowState)
			{
				if (size_0.IsEmpty)
				{
					method_42();
					base.RecalcSize();
					if (method_45().Width > ((Control)this).get_Width())
					{
						method_41();
						base.RecalcSize();
					}
				}
				else if (size_0.Width <= ((Control)this).get_Width())
				{
					method_42();
					base.RecalcSize();
					if (method_34(method_45().Width))
					{
						size_2 = Size.Empty;
					}
				}
				else if (!size_2.IsEmpty && size_2.Width <= ((Control)this).get_Width())
				{
					method_42();
					method_36(size_2.Width);
					base.RecalcSize();
					if (method_34(method_45().Width))
					{
						size_2 = Size.Empty;
					}
				}
			}
			else
			{
				size_2 = Size.Empty;
			}
		}
	}

	private bool method_34(int int_8)
	{
		if (galleryContainer_0 != null && galleryContainer_0.Visible)
		{
			int num = ((Control)this).get_Width() - int_8;
			if (galleryContainer_0.DisplayRectangle.Width + num >= galleryContainer_0.MinimumSize.Width)
			{
				int width = galleryContainer_0.DisplayRectangle.Width;
				galleryContainer_0.Size_0 = new Size(galleryContainer_0.DisplayRectangle.Width + num, galleryContainer_0.DefaultSize.Height);
				galleryContainer_0.RecalcSize();
				int num2 = galleryContainer_0.DisplayRectangle.Width - width;
				method_35(galleryContainer_0.Parent, galleryContainer_0.Parent.SubItems.IndexOf(galleryContainer_0) + 1, num2);
				return Math.Abs(num2) >= Math.Abs(num);
			}
			return false;
		}
		return false;
	}

	private void method_35(BaseItem baseItem_6, int int_8, int int_9)
	{
		int count = baseItem_6.SubItems.Count;
		for (int i = int_8; i < count; i++)
		{
			BaseItem baseItem = baseItem_6.SubItems[i];
			if (baseItem.Visible)
			{
				Rectangle bounds = baseItem.Bounds;
				bounds.Offset(int_9, 0);
				baseItem.Bounds = bounds;
			}
		}
		baseItem_6.method_4(new Rectangle(baseItem_6.DisplayRectangle.X, baseItem_6.DisplayRectangle.Y, baseItem_6.DisplayRectangle.Width + int_9, baseItem_6.DisplayRectangle.Height));
	}

	private void method_36(int int_8)
	{
		if (arrayList_1.Count <= 0)
		{
			if (galleryContainer_0 != null)
			{
				galleryContainer_0.Size_0 = new Size(galleryContainer_0.MinimumSize.Width, galleryContainer_0.HeightInternal);
			}
			method_37(itemContainer_0);
		}
	}

	private void method_37(ItemContainer itemContainer_1)
	{
		if (itemContainer_1.LayoutOrientation == eOrientation.Vertical)
		{
			foreach (BaseItem subItem in itemContainer_1.SubItems)
			{
				if (subItem is ButtonItem buttonItem && buttonItem.ButtonStyle == eButtonStyle.ImageAndText && (buttonItem.ImagePosition == eImagePosition.Left || buttonItem.ImagePosition == eImagePosition.Right))
				{
					Class111 @class = Class30.smethod_0(buttonItem);
					@class.RecordSetting(buttonItem);
					bool globalItem = buttonItem.GlobalItem;
					buttonItem.GlobalItem = false;
					buttonItem.ButtonStyle = eButtonStyle.Default;
					buttonItem.ImageFixedSize = new Size(16, 16);
					buttonItem.UseSmallImage = true;
					buttonItem.GlobalItem = globalItem;
					arrayList_1.Add(@class);
				}
				else if (subItem is ItemContainer && !(subItem is GalleryContainer))
				{
					method_37(subItem as ItemContainer);
				}
			}
			return;
		}
		ArrayList arrayList = new ArrayList();
		foreach (BaseItem subItem2 in itemContainer_1.SubItems)
		{
			if (subItem2 is ItemContainer && !(subItem2 is GalleryContainer))
			{
				method_37(subItem2 as ItemContainer);
			}
			else if (subItem2 is ButtonItem)
			{
				ButtonItem buttonItem2 = subItem2 as ButtonItem;
				if (buttonItem2.ImagePosition == eImagePosition.Top || buttonItem2.ImagePosition == eImagePosition.Bottom)
				{
					arrayList.Add(buttonItem2);
				}
			}
		}
		if (arrayList.Count <= 1)
		{
			return;
		}
		int num = arrayList.Count / 3;
		int num2 = arrayList.Count - num * 3;
		for (int num3 = arrayList.Count - 1; num3 >= num2; num3--)
		{
			ButtonItem buttonItem3 = arrayList[num3] as ButtonItem;
			Class111 class2 = Class30.smethod_0(buttonItem3);
			class2.RecordSetting(buttonItem3);
			bool globalItem2 = buttonItem3.GlobalItem;
			buttonItem3.GlobalItem = false;
			buttonItem3.ImagePosition = eImagePosition.Left;
			buttonItem3.ButtonStyle = eButtonStyle.ImageAndText;
			buttonItem3.ImageFixedSize = new Size(16, 16);
			if (buttonItem3.Class261_0 != null && buttonItem3.Class261_0.bool_2)
			{
				buttonItem3.Text = Class243.smethod_3(buttonItem3.Text);
			}
			buttonItem3.GlobalItem = globalItem2;
			arrayList_1.Add(class2);
		}
		Class111 class3 = Class30.smethod_1(itemContainer_1);
		arrayList_1.Add(class3);
		class3.RecordSetting(itemContainer_1);
		itemContainer_1.LayoutOrientation = eOrientation.Vertical;
		itemContainer_1.MultiLine = true;
	}

	internal void method_38()
	{
		if (galleryContainer_0 != null)
		{
			galleryContainer_0.Size_0 = Size.Empty;
		}
		if (arrayList_1.Count == 0)
		{
			return;
		}
		foreach (Class111 item in arrayList_1)
		{
			item.RestoreSettings();
		}
		arrayList_1.Clear();
	}

	private RibbonBar method_39()
	{
		return method_40(bool_38: false);
	}

	internal RibbonBar method_40(bool bool_38)
	{
		RibbonBar ribbonBar = new RibbonBar();
		ribbonBar.ShortcutsEnabled = false;
		ribbonBar.AutoOverflowEnabled = false;
		ribbonBar.Style = Style;
		ribbonBar.BackgroundStyle.ApplyStyle(base.BackgroundStyle);
		ribbonBar.BackgroundMouseOverStyle.ApplyStyle(BackgroundMouseOverStyle);
		((Control)ribbonBar).set_Text(((Control)this).get_Text());
		ribbonBar.TitleStyle.ApplyStyle(TitleStyle);
		ribbonBar.TitleStyleMouseOver.ApplyStyle(TitleStyleMouseOver);
		ribbonBar.LayoutOrientation = LayoutOrientation;
		CopyIOwnerEvents(ribbonBar);
		ribbonBar.DialogLauncherVisible = DialogLauncherVisible;
		ribbonBar.mouseEventHandler_3 = mouseEventHandler_3;
		ribbonBar.eventHandler_20 = eventHandler_20;
		ribbonBar.eventHandler_22 = eventHandler_22;
		ribbonBar.eventHandler_21 = eventHandler_21;
		ribbonBar.DialogLauncherButton = DialogLauncherButton;
		ribbonBar.DialogLauncherMouseOverButton = DialogLauncherMouseOverButton;
		ribbonBar.Images = Images;
		ribbonBar.ImagesLarge = ImagesLarge;
		ribbonBar.ImagesMedium = ImagesMedium;
		ribbonBar.FadeEffect = base.FadeEffect;
		ribbonBar.eventHandler_19 = eventHandler_19;
		ribbonBar.ItemSpacing = ItemSpacing;
		ribbonBar.HorizontalItemAlignment = HorizontalItemAlignment;
		ribbonBar.Boolean_4 = true;
		ribbonBar.AutoSizeItems = AutoSizeItems;
		ribbonBar.MaximumOverflowTextLength = MaximumOverflowTextLength;
		ribbonBar.VerticalItemAlignment = VerticalItemAlignment;
		if (bool_38 && !Class109.smethod_11((Control)(object)this))
		{
			((Control)this).CreateHandle();
			RecalcLayout();
		}
		if (OverflowState && !size_0.IsEmpty)
		{
			Size size = size_0;
			((Control)ribbonBar).set_Size(size);
		}
		else
		{
			((Control)ribbonBar).set_Size(method_47());
		}
		ribbonBar.TitleVisible = TitleVisible;
		((Control)ribbonBar).set_Visible(true);
		return ribbonBar;
	}

	private void method_41()
	{
		if (sysOverflowButton != null || itemContainer_0.SubItems.Count == 0)
		{
			return;
		}
		bool_28 = true;
		sysOverflowButton = new Class184();
		sysOverflowButton.Name = "sysOverflowButton";
		sysOverflowButton.Text = method_44();
		sysOverflowButton.ribbonBar_0 = this;
		sysOverflowButton.Image = method_43();
		sysOverflowButton.ButtonStyle = eButtonStyle.ImageAndText;
		sysOverflowButton.ImagePosition = eImagePosition.Top;
		sysOverflowButton.AutoExpandOnClick = true;
		sysOverflowButton.PopupType = ePopupType.Menu;
		sysOverflowButton.ImagePaddingHorizontal = 16;
		sysOverflowButton.Int32_1 = 12;
		sysOverflowButton.SubItemsExpandWidth = 14;
		sysOverflowButton.HotTrackingStyle = eHotTrackingStyle.None;
		sysOverflowButton.PopupOpen += sysOverflowButton_PopupOpen;
		if (overflowButtonEventHandler_0 != null)
		{
			overflowButtonEventHandler_0(this, new OverflowButtonEventArgs(sysOverflowButton));
		}
		ArrayList arrayList = new ArrayList();
		itemContainer_0.SubItems.method_4(arrayList);
		itemContainer_0.SubItems.Clear();
		itemContainer_0.SubItems.Add(sysOverflowButton);
		ribbonBar_0 = method_39();
		ribbonBar_0.RibbonBar_0 = this;
		eVerticalItemsAlignment_0 = itemContainer_0.VerticalItemAlignment;
		eOrientation_0 = itemContainer_0.LayoutOrientation;
		eHorizontalItemsAlignment_0 = itemContainer_0.HorizontalItemAlignment;
		itemContainer_0.VerticalItemAlignment = eVerticalItemsAlignment.Top;
		itemContainer_0.LayoutOrientation = eOrientation.Horizontal;
		itemContainer_0.HorizontalItemAlignment = eHorizontalItemsAlignment.Center;
		foreach (BaseItem item in arrayList)
		{
			ribbonBar_0.Items.Add(item);
			((IOwner)this).AddShortcutsFromItem(item);
		}
		ItemContainer itemContainer = new ItemContainer();
		itemContainer.Stretch = true;
		ControlContainerItem controlContainerItem = new ControlContainerItem();
		controlContainerItem.AllowItemResize = false;
		itemContainer.SubItems.Add(controlContainerItem);
		controlContainerItem.Control = (Control)(object)ribbonBar_0;
		sysOverflowButton.SubItems.Add(itemContainer);
		itemContainer_0.RefreshImageSize();
		if (overflowButtonEventHandler_1 != null)
		{
			overflowButtonEventHandler_1(this, new OverflowButtonEventArgs(sysOverflowButton));
		}
		bool_28 = false;
	}

	private void sysOverflowButton_PopupOpen(object sender, PopupOpenEventArgs e)
	{
		if (ribbonBar_0 != null)
		{
			ribbonBar_0.BackgroundStyle.ApplyStyle(base.BackgroundStyle);
			ribbonBar_0.BackgroundMouseOverStyle.ApplyStyle(BackgroundMouseOverStyle);
			ribbonBar_0.TitleStyle.ApplyStyle(TitleStyle);
			ribbonBar_0.TitleStyleMouseOver.ApplyStyle(TitleStyleMouseOver);
			if (ShowKeyTips)
			{
				ribbonBar_0.ShowKeyTips = true;
			}
		}
	}

	private void method_42()
	{
		if (sysOverflowButton == null)
		{
			return;
		}
		bool_28 = true;
		if (overflowButtonEventHandler_2 != null)
		{
			overflowButtonEventHandler_2(this, new OverflowButtonEventArgs(sysOverflowButton));
		}
		sysOverflowButton.PopupOpen -= sysOverflowButton_PopupOpen;
		itemContainer_0.SubItems.Remove(sysOverflowButton);
		itemContainer_0.VerticalItemAlignment = eVerticalItemsAlignment_0;
		itemContainer_0.LayoutOrientation = eOrientation_0;
		itemContainer_0.HorizontalItemAlignment = eHorizontalItemsAlignment_0;
		ArrayList arrayList = new ArrayList();
		ribbonBar_0.Items.method_4(arrayList);
		ribbonBar_0.Items.Clear();
		sysOverflowButton.SubItems.Clear();
		foreach (BaseItem item in arrayList)
		{
			((IOwner)this).RemoveShortcutsFromItem(item);
			itemContainer_0.SubItems.Add(item);
		}
		if (image_2 == null)
		{
			sysOverflowButton.Image.Dispose();
			sysOverflowButton.Image = null;
		}
		sysOverflowButton.Dispose();
		((Component)(object)ribbonBar_0).Dispose();
		sysOverflowButton = null;
		ribbonBar_0 = null;
		bool_28 = false;
	}

	internal Image method_43()
	{
		if (image_2 == null)
		{
			return (Image)(object)Class109.smethod_67("SystemImages.RibbonOverflow.png");
		}
		return image_2;
	}

	private string method_44()
	{
		string text = string_2;
		if (text == "")
		{
			text = ((Control)this).get_Text();
			if (int_5 > 0 && text.Length >= int_5)
			{
				text = text.Substring(0, int_5) + "...";
			}
			else if (text.IndexOf(' ') > 0)
			{
				text += " <expand/>";
			}
		}
		return text;
	}

	protected override void OnResize(EventArgs e)
	{
		if (OverflowState)
		{
			sysOverflowButton.Bounds = GetItemContainerRectangle();
		}
		base.OnResize(e);
	}

	public void ResetCachedContentSize()
	{
		size_0 = Size.Empty;
	}

	internal Size method_45()
	{
		return method_46(new Size(itemContainer_0.WidthInternal, itemContainer_0.HeightInternal));
	}

	private Size method_46(Size size_3)
	{
		ElementStyle backgroundStyle = GetBackgroundStyle();
		Size result = new Size(((size_3.Width > 0) ? size_3.Width : 32) + Class52.smethod_1(backgroundStyle), size_3.Height + Class52.smethod_2(backgroundStyle));
		if (bool_30 && !OverflowState)
		{
			result.Height += rectangle_0.Height;
		}
		if (Style == eDotNetBarStyle.Office2007)
		{
			result.Width++;
			result.Height += 4;
		}
		return result;
	}

	internal Size method_47()
	{
		if (!size_1.IsEmpty)
		{
			return method_46(size_1);
		}
		return method_45();
	}

	public override void AutoSyncSize()
	{
		if (((Control)this).get_AutoSize() && !OverflowState && !itemContainer_0.NeedRecalcSize)
		{
			((Control)this).set_Height(method_45().Height);
		}
	}

	public override int GetAutoSizeHeight()
	{
		return method_45().Height;
	}

	public int GetAutoSizeWidth()
	{
		return method_45().Width;
	}

	protected override Rectangle GetItemContainerRectangle()
	{
		Rectangle itemContainerRectangle = base.GetItemContainerRectangle();
		if (bool_30 && !OverflowState)
		{
			Rectangle titleRectangle = GetTitleRectangle();
			if (eRibbonTitlePosition_0 == eRibbonTitlePosition.Top)
			{
				titleRectangle.Height++;
				itemContainerRectangle.Y += titleRectangle.Height;
				itemContainerRectangle.Height -= titleRectangle.Height;
			}
			else
			{
				titleRectangle.Height++;
				itemContainerRectangle.Height -= titleRectangle.Height;
			}
		}
		return itemContainerRectangle;
	}

	private Rectangle method_48()
	{
		return ((Control)this).get_ClientRectangle();
	}

	public Rectangle GetTitleRectangle()
	{
		return rectangle_0;
	}

	protected override Font GetKeyTipFont()
	{
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null)
		{
			RibbonStrip ribbonStrip = ribbonControl.RibbonStrip;
			if (ribbonStrip.KeyTipsFont != null)
			{
				return ribbonStrip.KeyTipsFont;
			}
		}
		return base.GetKeyTipFont();
	}

	internal override void vmethod_7(BaseItem baseItem_6, BaseRenderer baseRenderer_2, KeyTipsRendererEventArgs keyTipsRendererEventArgs_0)
	{
		base.vmethod_7(baseItem_6, baseRenderer_2, keyTipsRendererEventArgs_0);
		if (DialogLauncherVisible && DialogLauncherKeyTip != "")
		{
			string keyTipsKeysStack = ((IKeyTipsControl)this).KeyTipsKeysStack;
			string dialogLauncherKeyTip = DialogLauncherKeyTip;
			if (!(keyTipsKeysStack != "") || dialogLauncherKeyTip.StartsWith(keyTipsKeysStack))
			{
				keyTipsRendererEventArgs_0.ReferenceObject = this;
				keyTipsRendererEventArgs_0.KeyTip = dialogLauncherKeyTip;
				Size size = Class53.size_0;
				Size size2 = Class55.smethod_3(keyTipsRendererEventArgs_0.Graphics, dialogLauncherKeyTip, keyTipsRendererEventArgs_0.Font);
				size2.Width += size.Width;
				size2.Height += size.Height;
				Rectangle rectangle = (keyTipsRendererEventArgs_0.Bounds = new Rectangle(((Control)this).get_Width() - size2.Width, ((Control)this).get_Height() + 4, size2.Width, size2.Height));
				baseRenderer_2.DrawKeyTips(keyTipsRendererEventArgs_0);
			}
		}
	}

	protected override Rectangle GetKeyTipCanvasBounds()
	{
		RibbonControl ribbonControl = GetRibbonControl();
		if (ribbonControl != null)
		{
			Point point = ((Control)ribbonControl).PointToClient(((Control)this).PointToScreen(Point.Empty));
			return new Rectangle(point.X, point.Y - 8, ((Control)this).get_Bounds().Width + 12, ((Control)this).get_Bounds().Height + 20);
		}
		return new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
	}

	protected override Rectangle GetKeyTipRectangle(Graphics g, BaseItem item, Font font, string keyTip)
	{
		Size size = Class53.size_0;
		Size size2 = Class55.smethod_3(g, keyTip, font);
		size2.Width += size.Width;
		size2.Height += size.Height;
		Rectangle rectangle = method_49(item);
		Rectangle result = new Rectangle(rectangle.Right - size2.Width - 1, rectangle.Bottom - size2.Height + size2.Height / 3 + 8, size2.Width, size2.Height);
		if (item == sysOverflowButton)
		{
			result.Y = ((Control)this).get_Height() - 2;
			result.X = rectangle.X + (rectangle.Width - size2.Width - 2) / 2;
		}
		else if (bool_36)
		{
			if (!((double)item.HeightInternal * 1.2 >= (double)itemContainer_0.HeightInternal) && !(item is GalleryContainer))
			{
				if ((double)rectangle.Bottom * 1.2 >= (double)itemContainer_0.HeightInternal)
				{
					result.Y = ((Control)this).get_Height() - size2.Height - 5;
				}
				else if (item.Parent is ItemContainer && rectangle.Y >= 0 && rectangle.Y <= 12)
				{
					result.Y = 0;
				}
				else if (result.Bottom > ((Control)this).get_Height())
				{
					result.Y = ((Control)this).get_Height() - size2.Height;
				}
				else if ((double)rectangle.Y >= (double)((Control)this).get_Height() * 0.25)
				{
					result.Y = (int)((double)((Control)this).get_Height() * 0.4);
				}
			}
			else
			{
				result.Y = ((Control)this).get_Height() - size2.Height - 5;
				if (item is GalleryContainer)
				{
					result.X = rectangle.Right - (size2.Width - 2) / 2;
				}
				else
				{
					result.X = rectangle.X + (rectangle.Width - size2.Width - 2) / 2;
				}
			}
		}
		else if (item is GalleryContainer)
		{
			result.X = rectangle.Right - (size2.Width - 2) / 2;
		}
		return result;
	}

	private Rectangle method_49(BaseItem baseItem_6)
	{
		return baseItem_6.DisplayRectangle;
	}

	protected override bool ProcessMnemonic(BaseItem container, char charCode)
	{
		if (((Control)this).get_Parent() is IKeyTipsControl && !((IKeyTipsControl)((Control)this).get_Parent()).ShowKeyTips)
		{
			return false;
		}
		bool result;
		if (!(result = base.ProcessMnemonic(container, charCode)) && DialogLauncherVisible && DialogLauncherKeyTip != "")
		{
			string keyTipsKeysStack = ((IKeyTipsControl)this).KeyTipsKeysStack;
			string text = keyTipsKeysStack + charCode;
			text = text.ToUpper();
			if (DialogLauncherKeyTip.ToUpper() == text)
			{
				DoLaunchDialog();
				result = true;
			}
			else if (DialogLauncherKeyTip.ToUpper().StartsWith(text))
			{
				((IKeyTipsControl)this).KeyTipsKeysStack += charCode.ToString().ToUpper();
			}
		}
		return result;
	}

	protected override void PaintControlBackground(ItemPaintArgs pa)
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Invalid comparison between Unknown and I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Invalid comparison between Unknown and I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		bool flag = bool_29;
		if (bitmap_0 != null)
		{
			flag = false;
		}
		GraphicsPath val = null;
		ElementStyle elementStyle = GetBackgroundStyle();
		if (elementStyle != null)
		{
			Rectangle rectangle = method_48();
			pa.Graphics.SetClip(rectangle, (CombineMode)0);
			ElementStyle backgroundMouseOverStyle = GetBackgroundMouseOverStyle();
			if (flag && elementStyle != null && backgroundMouseOverStyle != null && backgroundMouseOverStyle.Custom)
			{
				elementStyle = elementStyle.Copy();
				elementStyle.ApplyStyle(backgroundMouseOverStyle);
			}
			ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo(elementStyle, pa.Graphics, rectangle);
			ElementStyleDisplay.Paint(elementStyleDisplayInfo);
			pa.Graphics.ResetClip();
			elementStyleDisplayInfo.Bounds = method_48();
			elementStyleDisplayInfo.Bounds.X--;
			elementStyleDisplayInfo.Bounds.Width++;
			val = ElementStyleDisplay.GetInsideClip(elementStyleDisplayInfo);
			elementStyleDisplayInfo.Bounds.X++;
			elementStyleDisplayInfo.Bounds.Width--;
		}
		if (val != null)
		{
			pa.Graphics.SetClip(val, (CombineMode)0);
		}
		rectangle_1 = Rectangle.Empty;
		if (bool_30 && !OverflowState)
		{
			ElementStyle elementStyle2 = method_24();
			ElementStyle elementStyle3 = method_25();
			if (flag && elementStyle2 != null && elementStyle3 != null && elementStyle3.Custom)
			{
				elementStyle2 = elementStyle2.Copy();
				elementStyle2.ApplyStyle(elementStyle3);
			}
			if (elementStyle2 != null)
			{
				Class43 @class = new Class43(elementStyle2, pa.Graphics, class110_0, ((Control)this).get_Font(), (int)((Control)this).get_RightToLeft() == 1);
				if (bool_25)
				{
					if (image_0 == null)
					{
						Rectangle textBounds = class110_0.TextBounds;
						textBounds.Width -= rectangle_0.Height;
						if ((int)((Control)this).get_RightToLeft() == 1)
						{
							textBounds.X += rectangle_0.Height;
						}
						@class.rectangle_0 = textBounds;
					}
					else if (bool_26 && image_1 != null)
					{
						class110_0.Image = image_1;
					}
					else
					{
						class110_0.Image = image_0;
					}
				}
				Class42.smethod_0(@class);
				if (bool_25 && class110_0.Image == null)
				{
					method_50(pa);
				}
				else
				{
					rectangle_1 = class110_0.ImageBounds;
				}
			}
		}
		pa.Graphics.ResetClip();
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			if (bitmap_0 != null)
			{
				Graphics graphics = pa.Graphics;
				Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				ColorMatrix val2 = new ColorMatrix();
				val2.set_Item(3, 3, (float)int_7 / 255f);
				ImageAttributes val3 = new ImageAttributes();
				val3.SetColorMatrix(val2);
				graphics.DrawImage((Image)(object)bitmap_0, rectangle2, 0, 0, rectangle2.Width, rectangle2.Height, (GraphicsUnit)2, val3);
			}
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
	}

	private void method_50(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		Rectangle rectangle = new Rectangle(rectangle_0.Right - (rectangle_0.Height - 5) - 3, rectangle_0.Y + 2, rectangle_0.Height - 5, rectangle_0.Height - 5);
		if ((int)((Control)this).get_RightToLeft() == 1)
		{
			rectangle.X = rectangle_0.X;
		}
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (Style == eDotNetBarStyle.Office2007)
		{
			int num = Math.Min(15, rectangle_0.Height - 1);
			rectangle = new Rectangle(rectangle_0.Right - num - 2, rectangle_0.Y + (rectangle_0.Height - num) / 2, num, num);
			if ((int)((Control)this).get_RightToLeft() == 1)
			{
				rectangle.X = rectangle_0.X + 2;
			}
			RibbonBarRendererEventArgs ribbonBarRendererEventArgs = new RibbonBarRendererEventArgs(graphics, rectangle, this);
			if (bool_26)
			{
				if ((int)Control.get_MouseButtons() == 1048576)
				{
					ribbonBarRendererEventArgs.Pressed = true;
				}
				else
				{
					ribbonBarRendererEventArgs.MouseOver = true;
				}
			}
			GetRenderer().DrawRibbonDialogLauncher(ribbonBarRendererEventArgs);
			rectangle_1 = rectangle;
			return;
		}
		if (base.AntiAlias)
		{
			graphics.set_SmoothingMode((SmoothingMode)0);
		}
		LinearGradientBrush val = Class50.smethod_0(rectangle, ControlPaint.LightLight(itemPaintArgs_0.Colors.BarBackground), itemPaintArgs_0.Colors.BarBackground, 90f);
		try
		{
			graphics.FillRectangle((Brush)(object)val, rectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Rectangle rectangle2 = new Rectangle(rectangle.X + (int)Math.Ceiling((float)(rectangle.Width - 8) / 2f), rectangle.Bottom - 4, 2, 2);
		graphics.FillRectangle(SystemBrushes.get_ControlText(), rectangle2);
		rectangle2.Offset(rectangle2.Width + 1, 0);
		graphics.FillRectangle(SystemBrushes.get_ControlText(), rectangle2);
		rectangle2.Offset(rectangle2.Width + 1, 0);
		graphics.FillRectangle(SystemBrushes.get_ControlText(), rectangle2);
		if (base.AntiAlias)
		{
			graphics.set_SmoothingMode((SmoothingMode)4);
		}
		rectangle_1 = rectangle;
	}

	public void ResetTitleStyle()
	{
		elementStyle_1.StyleChanged -= elementStyle_2_StyleChanged;
		elementStyle_1 = new ElementStyle();
		elementStyle_1.StyleChanged += elementStyle_2_StyleChanged;
		((Control)this).Invalidate();
	}

	public void ResetTitleStyleMouseOver()
	{
		elementStyle_2.StyleChanged -= elementStyle_2_StyleChanged;
		elementStyle_2 = new ElementStyle();
		elementStyle_2.StyleChanged += elementStyle_2_StyleChanged;
		((Control)this).Invalidate();
	}

	private void elementStyle_2_StyleChanged(object sender, EventArgs e)
	{
		if (((Component)(object)this).DesignMode)
		{
			RecalcLayout();
		}
	}

	private void method_51(bool bool_38)
	{
		if (bool_38 == bool_29)
		{
			return;
		}
		if (base.Boolean_2 && ((Control)this).get_Enabled() && ((Control)this).get_Visible() && ((Control)this).get_Width() > 0 && ((Control)this).get_Height() > 0)
		{
			bool flag = false;
			bool flag2 = false;
			try
			{
				readerWriterLock_0.AcquireReaderLock(-1);
				try
				{
					flag = bitmap_0 == null;
				}
				finally
				{
					readerWriterLock_0.ReleaseReaderLock();
				}
				if (flag)
				{
					bool_29 = true;
					bool isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld;
					LockCookie lockCookie = default(LockCookie);
					if (isReaderLockHeld)
					{
						lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
					}
					else
					{
						readerWriterLock_0.AcquireWriterLock(-1);
					}
					try
					{
						bitmap_0 = method_55();
					}
					finally
					{
						if (isReaderLockHeld)
						{
							readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
						}
						else
						{
							readerWriterLock_0.ReleaseWriterLock();
						}
					}
				}
			}
			catch (ApplicationException)
			{
				flag2 = true;
			}
			int_6 = 1;
			bool_29 = bool_38;
			if (!flag2)
			{
				if (!bool_29)
				{
					int_6 = -1;
				}
				else
				{
					int_7 = 10;
				}
				Class27.smethod_0(this, method_54);
				bool_37 = true;
			}
		}
		else
		{
			bool_29 = bool_38;
		}
	}

	private void method_52()
	{
		if (bool_37)
		{
			bool_37 = false;
			Class27.smethod_2(this, method_54);
			bool flag = false;
			readerWriterLock_0.AcquireReaderLock(-1);
			try
			{
				flag = bitmap_0 != null;
			}
			finally
			{
				readerWriterLock_0.ReleaseReaderLock();
			}
			if (flag)
			{
				method_53();
			}
			if (int_7 > 230)
			{
				int_7 = 255;
			}
			else if (int_7 < 0)
			{
				int_7 = 0;
			}
		}
	}

	private void method_53()
	{
		bool isReaderLockHeld = readerWriterLock_0.IsReaderLockHeld;
		LockCookie lockCookie = default(LockCookie);
		if (isReaderLockHeld)
		{
			lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
		}
		else
		{
			readerWriterLock_0.AcquireWriterLock(-1);
		}
		try
		{
			((Image)bitmap_0).Dispose();
			bitmap_0 = null;
		}
		finally
		{
			if (isReaderLockHeld)
			{
				readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
			}
			else
			{
				readerWriterLock_0.ReleaseWriterLock();
			}
		}
	}

	private void method_54(object sender, EventArgs e)
	{
		int_7 += int_6 * 65;
		if ((int_6 < 0 && int_7 <= 0) || (int_6 > 0 && int_7 >= 255))
		{
			method_52();
		}
		((Control)this).Invalidate();
	}

	private Bitmap method_55()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height(), (PixelFormat)925707);
		val.MakeTransparent();
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			bool antiAlias = base.AntiAlias;
			GetColorScheme();
			if (antiAlias)
			{
				val2.set_SmoothingMode((SmoothingMode)4);
				val2.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			ItemPaintArgs pa = vmethod_5(val2);
			PaintControlBackground(pa);
			return val;
		}
		finally
		{
			val2.Dispose();
		}
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_52();
		base.OnHandleDestroyed(e);
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (!((Control)this).get_Visible())
		{
			method_52();
			if (Boolean_4)
			{
				((IOwner)this).OnApplicationDeactivate();
			}
		}
		((ScrollableControl)this).OnVisibleChanged(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		ColorScheme colorScheme = GetColorScheme();
		elementStyle_1.method_4(colorScheme);
		elementStyle_2.method_4(colorScheme);
		elementStyle_3.method_4(colorScheme);
		method_32();
		base.OnPaint(e);
		if (Class92.smethod_0() || !Class92.bool_0)
		{
			e.get_Graphics().Clear(SystemColors.Control);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void ResetBackColor()
	{
		((Control)this).set_BackColor(Color.Transparent);
	}

	public bool ShouldSerializeBackColor()
	{
		return ((Control)this).get_BackColor() != Color.Transparent;
	}
}

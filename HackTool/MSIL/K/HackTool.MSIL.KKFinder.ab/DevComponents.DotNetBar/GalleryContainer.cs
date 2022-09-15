using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.ScrollBar;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

[ProvideProperty("GalleryGroup", typeof(BaseItem))]
[Designer(typeof(GalleryContainerDesigner))]
[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class GalleryContainer : ItemContainer, IExtenderProvider
{
	private class Class201 : IComparer
	{
		int IComparer.Compare(object x, object y)
		{
			if (x is GalleryGroup && y is GalleryGroup)
			{
				return ((GalleryGroup)x).DisplayOrder - ((GalleryGroup)y).DisplayOrder;
			}
			return new CaseInsensitiveComparer().Compare(x, y);
		}
	}

	private bool bool_26 = true;

	private ButtonItem buttonItem_0;

	private ButtonItem buttonItem_1;

	private ButtonItem buttonItem_2;

	private Size size_5 = new Size(15, 20);

	private int int_6 = 1;

	private Size size_6 = Size.Empty;

	private Point point_2 = Point.Empty;

	private Size size_7 = Size.Empty;

	private ScrollBarCore scrollBarCore_0;

	private bool bool_27;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Size size_8 = Size.Empty;

	private bool bool_28;

	internal bool bool_29;

	private bool bool_30 = true;

	private GalleryGroupCollection galleryGroupCollection_0;

	private bool bool_31 = true;

	private Class29 class29_0;

	private bool bool_32 = true;

	private DotNetBarManager.PopupOpenEventHandler popupOpenEventHandler_0;

	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	private EventHandler eventHandler_16;

	private bool bool_33;

	private Bitmap bitmap_0;

	private int int_7;

	private int int_8;

	private int int_9;

	internal bool Boolean_4
	{
		get
		{
			return bool_27;
		}
		set
		{
			bool_27 = value;
			if (scrollBarCore_0 != null)
			{
				scrollBarCore_0.Dispose();
				scrollBarCore_0 = null;
			}
			if (bool_27 && bool_32)
			{
				scrollBarCore_0 = new ScrollBarCore();
				scrollBarCore_0.ValueChanged += scrollBarCore_0_ValueChanged;
			}
		}
	}

	internal Size Size_0
	{
		get
		{
			return size_8;
		}
		set
		{
			size_8 = value;
		}
	}

	internal new Rectangle Rectangle_0 => buttonItem_2.DisplayRectangle;

	internal ButtonItem ButtonItem_0 => buttonItem_2;

	[Category("Layout")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(eOrientation.Horizontal)]
	[Browsable(false)]
	public override eOrientation LayoutOrientation
	{
		get
		{
			return base.LayoutOrientation;
		}
		set
		{
			base.LayoutOrientation = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override eHorizontalItemsAlignment HorizontalItemAlignment
	{
		get
		{
			return base.HorizontalItemAlignment;
		}
		set
		{
			base.HorizontalItemAlignment = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override eVerticalItemsAlignment VerticalItemAlignment
	{
		get
		{
			return base.VerticalItemAlignment;
		}
		set
		{
			base.VerticalItemAlignment = value;
		}
	}

	[Browsable(true)]
	[Category("Layout")]
	[Description("Indicates whether items in horizontal layout are wrapped into the new line when they cannot fit allotted container size.")]
	[DefaultValue(true)]
	public override bool MultiLine
	{
		get
		{
			return base.MultiLine;
		}
		set
		{
			base.MultiLine = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool ResizeItemsToFit
	{
		get
		{
			return base.ResizeItemsToFit;
		}
		set
		{
			base.ResizeItemsToFit = value;
		}
	}

	[Description("Indicates whether Gallery when on popup is using standard scrollbars to scroll the content.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	[Browsable(true)]
	public bool PopupUsesStandardScrollbars
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

	[Category("Layout")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether gallery is using incremental sizing when stretched.")]
	public bool IncrementalSizing
	{
		get
		{
			return bool_30;
		}
		set
		{
			bool_30 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Description("Indicates whether Gallery width is determined based on the Ribbon container size.")]
	[DefaultValue(false)]
	[Category("Layout")]
	public bool StretchGallery
	{
		get
		{
			return bool_28;
		}
		set
		{
			if (bool_28 == value)
			{
				return;
			}
			bool_28 = value;
			if (ContainerControl is RibbonBar ribbonBar)
			{
				if (bool_28)
				{
					if (ribbonBar.GalleryContainer_0 == null)
					{
						ribbonBar.GalleryContainer_0 = this;
					}
				}
				else if (ribbonBar.GalleryContainer_0 == this)
				{
					ribbonBar.GalleryContainer_0 = null;
				}
			}
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public SubItemsCollection PopupGalleryItems => buttonItem_2.SubItems;

	[Browsable(true)]
	[Description("Indicates the default size of the gallery.")]
	[Category("Layout")]
	public Size DefaultSize
	{
		get
		{
			return size_6;
		}
		set
		{
			size_6 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Category("Layout")]
	[Description("Indicates the default size of the gallery when gallery is displayed on the popup menu.")]
	[Browsable(true)]
	public Size PopupGallerySize
	{
		get
		{
			return size_7;
		}
		set
		{
			size_7 = value;
		}
	}

	[DefaultValue(true)]
	[Category("Gallery")]
	[Browsable(true)]
	[Description("Indicates whether gallery can be displayed on the popup.")]
	public bool EnableGalleryPopup
	{
		get
		{
			return bool_26;
		}
		set
		{
			bool_26 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	internal ScrollBarCore ScrollBarCore_0 => scrollBarCore_0;

	internal bool Boolean_5
	{
		get
		{
			if (bool_30 && SubItems.Count > 0)
			{
				return WidthInternal - SubItems[0].WidthInternal <= base.MinimumSize.Width;
			}
			return WidthInternal <= base.MinimumSize.Width;
		}
	}

	public override Rectangle Bounds
	{
		get
		{
			return base.Bounds;
		}
		set
		{
			base.Bounds = value;
			method_41(DisplayRectangle);
		}
	}

	[DefaultValue(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override bool Expanded
	{
		get
		{
			return m_Expanded;
		}
		set
		{
			base.Expanded = value;
			if (!value && buttonItem_2.Expanded)
			{
				buttonItem_2.Expanded = false;
			}
		}
	}

	[Browsable(false)]
	public bool IsGalleryPopupOpen => buttonItem_2.Expanded;

	[DefaultValue("")]
	[Category("Appearance")]
	[Description("Indicates the Key Tips access key or keys for the item when on Ribbon Control or Ribbon Bar.")]
	[Browsable(true)]
	public override string KeyTips
	{
		get
		{
			return base.KeyTips;
		}
		set
		{
			base.KeyTips = value;
		}
	}

	private bool Boolean_6
	{
		get
		{
			if (!DesignMode && bool_31 && Displayed && !Class55.bool_1)
			{
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					if (val is ItemControl)
					{
						return ((ItemControl)(object)val).Boolean_2;
					}
					if (val is Bar)
					{
						return ((Bar)(object)val).Boolean_15;
					}
					if (val is ButtonX)
					{
						return ((ButtonX)(object)val).Boolean_1;
					}
				}
				return bool_31;
			}
			return false;
		}
	}

	[Description("Indicates whether scroll animation is enabled.")]
	[Category("Animation")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool ScrollAnimation
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Editor(typeof(GalleryGroupCollectionEditor), typeof(UITypeEditor))]
	[Category("Groups")]
	[Description("Gets the collection of GalleryGroup objects associated with this gallery.")]
	public GalleryGroupCollection GalleryGroups => galleryGroupCollection_0;

	[Description("Occurs when Gallery popup item is about to open.")]
	public event DotNetBarManager.PopupOpenEventHandler GalleryPopupOpen
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			popupOpenEventHandler_0 = (DotNetBarManager.PopupOpenEventHandler)Delegate.Combine(popupOpenEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			popupOpenEventHandler_0 = (DotNetBarManager.PopupOpenEventHandler)Delegate.Remove(popupOpenEventHandler_0, value);
		}
	}

	[Description("Occurs just before Gallery popup window is shown.")]
	public event EventHandler GalleryPopupShowing
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

	[Description("Occurs before the Gallery popup item is closed")]
	public event EventHandler GalleryPopupClose
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

	[Description("Occurs after popup item has been closed.")]
	public event EventHandler GalleryPopupFinalized
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

	public GalleryContainer()
	{
		size_6 = method_30();
		size_7 = method_31();
		galleryGroupCollection_0 = new GalleryGroupCollection();
		galleryGroupCollection_0.GalleryContainer_0 = this;
		MultiLine = true;
		method_32();
		base.MinimumSize = new Size(42 + size_5.Width + int_6, size_6.Height);
		class29_0 = new Class29(method_51, method_53, method_52);
	}

	private Size method_30()
	{
		return new Size(140 + size_5.Width + int_6, size_5.Height * 3 - 2);
	}

	private Size method_31()
	{
		return Size.Empty;
	}

	public override BaseItem Copy()
	{
		GalleryContainer galleryContainer = new GalleryContainer();
		CopyToItem(galleryContainer);
		return galleryContainer;
	}

	protected override void CopyToItem(BaseItem c)
	{
		GalleryContainer galleryContainer = c as GalleryContainer;
		galleryContainer.DefaultSize = DefaultSize;
		galleryContainer.PopupGallerySize = PopupGallerySize;
		galleryContainer.StretchGallery = StretchGallery;
		galleryContainer.PopupUsesStandardScrollbars = PopupUsesStandardScrollbars;
		foreach (BaseItem popupGalleryItem in PopupGalleryItems)
		{
			galleryContainer.PopupGalleryItems.Add(popupGalleryItem.Copy());
		}
		base.CopyToItem((BaseItem)galleryContainer);
		foreach (GalleryGroup galleryGroup3 in GalleryGroups)
		{
			GalleryGroup galleryGroup2 = new GalleryGroup();
			galleryGroup2.Name = galleryGroup3.Name;
			galleryGroup2.Text = galleryGroup3.Text;
			galleryGroup2.DisplayOrder = galleryGroup3.DisplayOrder;
			galleryContainer.GalleryGroups.Add(galleryGroup2);
			foreach (BaseItem item in galleryGroup3.Items)
			{
				galleryContainer.SetGalleryGroup(galleryContainer.SubItems[item.Name], galleryGroup2);
			}
		}
	}

	public override void Dispose()
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.Dispose();
			scrollBarCore_0 = null;
		}
		class29_0.method_1();
		base.Dispose();
	}

	private void method_32()
	{
		buttonItem_0 = new ButtonItem("sysgalleryscrollup");
		buttonItem_0.Text = "<expand direction=\"top\"/>";
		buttonItem_0.Style = Style;
		buttonItem_0.ColorTable = eButtonColor.OrangeWithBackground;
		buttonItem_0.SetParent(this);
		buttonItem_0.Click += buttonItem_0_Click;
		buttonItem_0.ClickAutoRepeat = true;
		buttonItem_0.ClickRepeatInterval = 200;
		buttonItem_0.CanCustomize = false;
		buttonItem_0.AutoCollapseOnClick = false;
		buttonItem_1 = new ButtonItem("sysgalleryscrolldown");
		buttonItem_1.Text = "<expand direction=\"bottom\"/>";
		buttonItem_1.Style = Style;
		buttonItem_1.ColorTable = eButtonColor.OrangeWithBackground;
		buttonItem_1.SetParent(this);
		buttonItem_1.Click += buttonItem_1_Click;
		buttonItem_1.ClickAutoRepeat = true;
		buttonItem_1.ClickRepeatInterval = 200;
		buttonItem_1.CanCustomize = false;
		buttonItem_1.AutoCollapseOnClick = false;
		buttonItem_2 = new ButtonItem("sysgallerypopup");
		buttonItem_2.Text = "<expand direction=\"popup\"/>";
		buttonItem_2.ButtonStyle = eButtonStyle.TextOnlyAlways;
		buttonItem_2.Style = Style;
		buttonItem_2.ColorTable = eButtonColor.OrangeWithBackground;
		buttonItem_2.SetParent(this);
		buttonItem_2.Click += buttonItem_2_Click;
		buttonItem_2.CanCustomize = false;
		buttonItem_2.PopupOpen += buttonItem_2_PopupOpen;
		buttonItem_2.PopupShowing += buttonItem_2_PopupShowing;
		buttonItem_2.PopupClose += buttonItem_2_PopupClose;
		buttonItem_2.PopupFinalized += buttonItem_2_PopupFinalized;
	}

	private void buttonItem_2_PopupShowing(object sender, EventArgs e)
	{
		OnGalleryPopupShowing(sender, e);
	}

	private void buttonItem_2_PopupOpen(object sender, PopupOpenEventArgs e)
	{
		OnGalleryPopupOpen(sender, e);
	}

	private void buttonItem_2_Click(object sender, EventArgs e)
	{
		PopupGallery();
	}

	private Size method_33(Point point_3)
	{
		Size result = Size.Empty;
		if (DisplayRectangle.Width >= DefaultSize.Width && !rectangle_1.Size.IsEmpty)
		{
			result = new Size(DisplayRectangle.Width, rectangle_1.Height);
		}
		else
		{
			int num = DefaultSize.Width;
			int num2 = 0;
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem.Visible)
				{
					num2 += subItem.WidthInternal + base.ItemSpacing;
					if (num2 > num)
					{
						break;
					}
				}
			}
			if (num2 > 0)
			{
				num = num2;
				if (bool_32)
				{
					num += int_6 + size_5.Width;
				}
			}
			result = new Size(num, Math.Max(DefaultSize.Height, rectangle_1.Height));
		}
		Class273 @class = null;
		@class = Class109.smethod_52(point_3);
		if (galleryGroupCollection_0.Count > 0 && @class != null && @class.rectangle_1.Bottom - point_3.Y > result.Height)
		{
			result.Height = @class.rectangle_1.Bottom - point_3.Y;
		}
		if (@class != null)
		{
			int num3 = 16;
			num3 = 16 + PopupGalleryItems.Count * 26;
			int num4 = 0;
			int num5 = 0;
			if (point_3.Y + result.Height > @class.rectangle_1.Bottom - num3)
			{
				num4 = point_3.Y + result.Height - (@class.rectangle_1.Bottom - num3);
			}
			if (point_3.X + result.Width > @class.rectangle_1.Right - num3)
			{
				num5 = point_3.X + result.Width - (@class.rectangle_1.Right - num3);
			}
			if (result.Width - num5 > base.MinimumSize.Width)
			{
				result.Width -= num5;
			}
			else
			{
				result.Width = base.MinimumSize.Width + int_6 + size_5.Width;
			}
			if (result.Height - num4 > base.MinimumSize.Height)
			{
				result.Height -= num4;
			}
			else
			{
				result.Height = base.MinimumSize.Height;
			}
		}
		return result;
	}

	private void method_34()
	{
		if (DesignMode)
		{
			return;
		}
		foreach (BaseItem subItem in buttonItem_2.SubItems)
		{
			if (subItem is GalleryContainer galleryContainer && galleryContainer.bool_29)
			{
				buttonItem_2.SubItems.Remove(galleryContainer);
				galleryContainer.Dispose();
				break;
			}
		}
	}

	private void buttonItem_2_PopupFinalized(object sender, EventArgs e)
	{
		OnGalleryPopupFinalized(sender, e);
		method_34();
	}

	private void buttonItem_2_PopupClose(object sender, EventArgs e)
	{
		OnGalleryPopupClose(sender, e);
		method_35();
	}

	private void method_35()
	{
	}

	private void buttonItem_0_Click(object sender, EventArgs e)
	{
		ScrollUp();
	}

	private void buttonItem_1_Click(object sender, EventArgs e)
	{
		ScrollDown();
	}

	internal bool method_36(int int_10, int int_11)
	{
		if (buttonItem_0.Enabled && buttonItem_0.DisplayRectangle.Contains(int_10, int_11))
		{
			return true;
		}
		if (buttonItem_1.Enabled && buttonItem_1.DisplayRectangle.Contains(int_10, int_11))
		{
			return true;
		}
		if (scrollBarCore_0 != null && scrollBarCore_0.Visible)
		{
			if (scrollBarCore_0.ThumbIncreaseRectangle.Contains(int_10, int_11))
			{
				return true;
			}
			if (scrollBarCore_0.ThumbDecreaseRectangle.Contains(int_10, int_11))
			{
				return true;
			}
		}
		return false;
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		if (base.IsDisposed)
		{
			return;
		}
		bool_33 = false;
		if (bool_27 && bool_32)
		{
			scrollBarCore_0.MouseDown(objArg);
			if (scrollBarCore_0.DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()))
			{
				bool_33 = true;
			}
		}
		base.InternalMouseDown(objArg);
		if (!DesignMode)
		{
			return;
		}
		if (buttonItem_0.Enabled && buttonItem_0.DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			ScrollUp();
		}
		else if (buttonItem_1.Enabled && buttonItem_1.DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			ScrollDown();
		}
		else if (buttonItem_2.Enabled && buttonItem_2.DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			PopupGallery();
		}
		else if (scrollBarCore_0 != null && scrollBarCore_0.Visible)
		{
			if (scrollBarCore_0.ThumbIncreaseRectangle.Contains(objArg.get_X(), objArg.get_Y()))
			{
				ScrollDown();
			}
			else if (scrollBarCore_0.ThumbDecreaseRectangle.Contains(objArg.get_X(), objArg.get_Y()))
			{
				ScrollUp();
			}
		}
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		if (bool_27 && !base.IsDisposed && bool_32)
		{
			scrollBarCore_0.MouseMove(objArg);
		}
		base.InternalMouseMove(objArg);
	}

	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		if (bool_27 && bool_32 && !base.IsDisposed)
		{
			scrollBarCore_0.MouseUp(objArg);
			if (scrollBarCore_0.DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()) || bool_33)
			{
				bool_33 = false;
				return;
			}
		}
		base.InternalMouseUp(objArg);
	}

	public override void InternalMouseLeave()
	{
		if (bool_27 && !base.IsDisposed && bool_32)
		{
			scrollBarCore_0.MouseLeave();
		}
		base.InternalMouseLeave();
	}

	public override void InternalKeyDown(KeyEventArgs objArg)
	{
		if (IsGalleryPopupOpen)
		{
			buttonItem_2.InternalKeyDown(objArg);
		}
		else
		{
			base.InternalKeyDown(objArg);
		}
	}

	protected virtual void OnGalleryPopupOpen(object sender, PopupOpenEventArgs e)
	{
		if (popupOpenEventHandler_0 != null)
		{
			popupOpenEventHandler_0(sender, e);
		}
	}

	protected virtual void OnGalleryPopupShowing(object sender, EventArgs e)
	{
		if (eventHandler_14 != null)
		{
			eventHandler_14(sender, e);
		}
	}

	protected virtual void OnGalleryPopupClose(object sender, EventArgs e)
	{
		if (eventHandler_15 != null)
		{
			eventHandler_15(sender, e);
		}
	}

	protected virtual void OnGalleryPopupFinalized(object sender, EventArgs e)
	{
		if (eventHandler_16 != null)
		{
			eventHandler_16(sender, e);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDefaultSize()
	{
		return size_6 != method_30();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDefaultSize()
	{
		TypeDescriptor.GetProperties(this)["DefaultSize"]!.SetValue(this, method_30());
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializePopupGallerySize()
	{
		return size_7 != method_31();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetPopupGallerySize()
	{
		TypeDescriptor.GetProperties(this)["PopupGallerySize"]!.SetValue(this, method_31());
	}

	public void EnsureVisible(BaseItem item)
	{
		if (item == null)
		{
			throw new NullReferenceException("Item must be non null value.");
		}
		if (item.TopInternal < 0 || item.Bounds.Bottom > Bounds.Bottom)
		{
			int num = DisplayRectangle.Top - item.TopInternal + method_38().Y;
			if (item.Bounds.Bottom > Bounds.Bottom)
			{
				num = DisplayRectangle.Bottom - item.Bounds.Bottom + method_38().Y;
			}
			if (Math.Abs(num) <= 4)
			{
				num = 0;
			}
			method_37(num);
		}
	}

	public void ScrollDown()
	{
		method_37(method_43());
	}

	public void ScrollUp()
	{
		method_37(method_44());
	}

	public override BaseItem ItemAtLocation(int x, int y)
	{
		if (!DesignMode && (!bool_27 || !bool_32))
		{
			if (buttonItem_0.DisplayRectangle.Contains(x, y) && buttonItem_0.Visible)
			{
				return buttonItem_0;
			}
			if (buttonItem_1.DisplayRectangle.Contains(x, y) && buttonItem_1.Visible)
			{
				return buttonItem_1;
			}
			if (bool_26 && buttonItem_2.DisplayRectangle.Contains(x, y))
			{
				return buttonItem_2;
			}
		}
		else if (!DesignMode && bool_27 && bool_32 && !bool_29 && BaseItem.IsOnPopup(this) && scrollBarCore_0 != null && (scrollBarCore_0.DisplayRectangle.Contains(x, y) || scrollBarCore_0.IsMouseDown))
		{
			return this;
		}
		if (bool_33)
		{
			return this;
		}
		return base.ItemAtLocation(x, y);
	}

	private void scrollBarCore_0_ValueChanged(object sender, EventArgs e)
	{
		method_37(-scrollBarCore_0.Value);
	}

	private void method_37(int int_10)
	{
		if (point_2.Y != int_10)
		{
			int y = int_10 - point_2.Y;
			int y2 = point_2.Y;
			point_2.Y = int_10;
			method_22(new Point(0, y));
			if (!bool_27 || !bool_32)
			{
				method_40(DisplayRectangle);
			}
			if (Boolean_6)
			{
				method_50(y2, int_10);
			}
			else
			{
				Refresh();
			}
		}
	}

	public override void Paint(ItemPaintArgs p)
	{
		class29_0.method_3();
		try
		{
			if (bitmap_0 != null)
			{
				base.PaintBackground(p);
				Graphics graphics = p.Graphics;
				Rectangle clipRectangle = GetClipRectangle();
				Region clip = graphics.get_Clip();
				graphics.SetClip(clipRectangle, (CombineMode)1);
				p.Graphics.DrawImage((Image)(object)bitmap_0, clipRectangle.X, clipRectangle.Y + int_8);
				if (clip != null)
				{
					graphics.set_Clip(clip);
				}
				else
				{
					graphics.ResetClip();
				}
			}
			else
			{
				base.Paint(p);
			}
		}
		finally
		{
			class29_0.method_4();
		}
		if (bool_27 && bool_32)
		{
			if (scrollBarCore_0.ParentControl == null)
			{
				scrollBarCore_0.ParentControl = p.ContainerControl;
			}
			scrollBarCore_0.Paint(p);
			return;
		}
		if (buttonItem_0.Visible)
		{
			buttonItem_0.Paint(p);
		}
		if (buttonItem_1.Visible)
		{
			buttonItem_1.Paint(p);
		}
		if (bool_26)
		{
			buttonItem_2.Paint(p);
		}
	}

	private Point method_38()
	{
		return point_2;
	}

	private Size method_39()
	{
		if (!size_8.IsEmpty && size_8.Width >= base.MinimumSize.Width && size_8.Height >= base.MinimumSize.Height)
		{
			return size_8;
		}
		Size result = size_6;
		if (Boolean_4 && !bool_29)
		{
			if (base.MinimumSize.Width > result.Width)
			{
				result.Width = base.MinimumSize.Width;
			}
			if (base.MinimumSize.Height > result.Height)
			{
				result.Height = base.MinimumSize.Height;
			}
		}
		return result;
	}

	protected override Rectangle GetLayoutRectangle(Rectangle bounds)
	{
		Rectangle result = new Rectangle(bounds.Location, method_39());
		if (bool_32 || !bool_27)
		{
			result.Width -= size_5.Width + int_6;
			if (IsRightToLeft)
			{
				result.X += size_5.Width + int_6;
			}
		}
		ElementStyle elementStyle = ElementStyleDisplay.smethod_5(base.BackgroundStyle);
		result.X += Class52.smethod_3(elementStyle);
		result.Y += Class52.smethod_7(elementStyle);
		result.Width -= Class52.smethod_1(elementStyle);
		result.Height -= Class52.smethod_2(elementStyle);
		result.Offset(method_38());
		return result;
	}

	protected override Rectangle LayoutItems(Rectangle bounds)
	{
		rectangle_1 = base.LayoutItems(bounds);
		if (rectangle_1.Height < Math.Abs(point_2.Y))
		{
			method_37(0);
		}
		Size size = method_39();
		if (((bool_29 && !EnableGalleryPopup) || base.IsOnMenu) && size.Height > rectangle_1.Height)
		{
			size.Height = rectangle_1.Height;
		}
		if (bool_30 && !Boolean_4)
		{
			size.Width = rectangle_1.Width + (size_5.Width + int_6);
		}
		Rectangle rectangle = new Rectangle(bounds.Location, size);
		int num = size_5.Height * 2 - 1;
		if (bool_26)
		{
			num += size_5.Height - 1;
		}
		rectangle.Height = Math.Max(num, rectangle.Height);
		method_41(rectangle);
		if (bool_27 && bool_32)
		{
			if (rectangle_1.Bottom - rectangle.Bottom > 0)
			{
				scrollBarCore_0.Enabled = true;
				scrollBarCore_0.Maximum = rectangle_1.Bottom - rectangle.Bottom;
				scrollBarCore_0.Minimum = 0;
				scrollBarCore_0.SmallChange = method_42();
				scrollBarCore_0.LargeChange = (int)((float)scrollBarCore_0.Maximum * ((float)rectangle.Height / (float)rectangle_1.Height));
			}
			else
			{
				scrollBarCore_0.Enabled = false;
			}
		}
		else
		{
			method_40(rectangle);
		}
		return rectangle;
	}

	protected override Size GetEmptyDesignTimeSize()
	{
		if (bool_27 && !bool_29)
		{
			Size minimumSize = base.MinimumSize;
			if (!minimumSize.IsEmpty)
			{
				return minimumSize;
			}
		}
		return base.GetEmptyDesignTimeSize();
	}

	private void method_40(Rectangle rectangle_2)
	{
		if (method_38().Y == 0)
		{
			buttonItem_0.Enabled = false;
		}
		else
		{
			buttonItem_0.Enabled = true;
		}
		if (bool_27 && !bool_32)
		{
			buttonItem_0.Visible = buttonItem_0.Enabled;
			buttonItem_0.Displayed = buttonItem_0.Enabled;
		}
		if (rectangle_1.Bottom + method_38().Y > rectangle_2.Bottom)
		{
			buttonItem_1.Enabled = true;
		}
		else
		{
			buttonItem_1.Enabled = false;
		}
		if (bool_27 && !bool_32)
		{
			buttonItem_1.Visible = buttonItem_1.Enabled;
			buttonItem_1.Displayed = buttonItem_1.Enabled;
		}
	}

	protected override void OnExternalSizeChange()
	{
		if (Boolean_4)
		{
			method_41(DisplayRectangle);
		}
		base.OnExternalSizeChange();
	}

	private void method_41(Rectangle rectangle_2)
	{
		int x = rectangle_2.Right - size_5.Width;
		int y = rectangle_2.Y;
		if (IsRightToLeft)
		{
			x = rectangle_2.X + size_5.Width;
		}
		if (!rectangle_1.IsEmpty)
		{
			if (rectangle_1.Y != rectangle_2.Y)
			{
				rectangle_1.Y = rectangle_2.Y;
			}
			if (rectangle_1.X != rectangle_2.X)
			{
				rectangle_1.X = rectangle_2.X;
			}
		}
		if (bool_27 && scrollBarCore_0 != null)
		{
			scrollBarCore_0.DisplayRectangle = new Rectangle(x, y, size_5.Width, rectangle_2.Height);
			return;
		}
		if (bool_27 && !bool_32)
		{
			Size size = new Size(rectangle_2.Width, 12);
			buttonItem_0.RecalcSize();
			buttonItem_0.Size = size;
			buttonItem_0.method_4(new Rectangle(rectangle_2.X, rectangle_2.Y, size.Width, size.Height));
			buttonItem_1.RecalcSize();
			buttonItem_1.Size = size;
			buttonItem_1.method_4(new Rectangle(rectangle_2.X, rectangle_2.Bottom - size.Height, size.Width, size.Height));
			return;
		}
		Rectangle rectangle = new Rectangle(x, y, size_5.Width, size_5.Height);
		buttonItem_0.Displayed = true;
		buttonItem_0.RecalcSize();
		buttonItem_0.Size = rectangle.Size;
		buttonItem_0.method_4(rectangle);
		if (bool_26)
		{
			y = rectangle_2.Bottom - size_5.Height;
			rectangle = new Rectangle(x, y, size_5.Width, size_5.Height);
			buttonItem_2.Displayed = true;
			buttonItem_2.RecalcSize();
			buttonItem_2.Size = rectangle.Size;
			buttonItem_2.method_4(rectangle);
			rectangle.Offset(0, -(size_5.Height - 1));
		}
		else
		{
			buttonItem_2.Displayed = false;
			y = rectangle_2.Bottom - size_5.Height;
			rectangle = new Rectangle(x, y, size_5.Width, size_5.Height);
		}
		buttonItem_1.Displayed = true;
		buttonItem_1.RecalcSize();
		buttonItem_1.Size = rectangle.Size;
		buttonItem_1.method_4(rectangle);
	}

	protected override void OnLeftLocationChanged(int oldValue)
	{
		base.OnLeftLocationChanged(oldValue);
		method_41(DisplayRectangle);
	}

	protected override void OnTopLocationChanged(int oldValue)
	{
		base.OnTopLocationChanged(oldValue);
		method_41(DisplayRectangle);
	}

	protected override void OnStyleChanged()
	{
		buttonItem_0.Style = Style;
		buttonItem_1.Style = Style;
		buttonItem_2.Style = Style;
		base.OnStyleChanged();
	}

	private int method_42()
	{
		int num = DisplayRectangle.Bottom + method_38().Y;
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem.Visible && subItem.TopInternal > num)
			{
				return subItem.HeightInternal;
			}
		}
		return 24;
	}

	private int method_43()
	{
		bool flag = false;
		int num = 0;
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem.Visible)
			{
				if (flag && subItem.TopInternal > num)
				{
					return method_45(subItem);
				}
				if (!flag && subItem.TopInternal >= TopInternal)
				{
					flag = true;
					num = subItem.TopInternal;
				}
			}
		}
		return method_38().Y;
	}

	private int method_44()
	{
		if (method_38().Y == 0)
		{
			return 0;
		}
		int num = SubItems.Count - 1;
		int num2 = num;
		BaseItem baseItem;
		while (true)
		{
			if (num2 >= 0)
			{
				baseItem = SubItems[num2];
				if (baseItem.Visible && baseItem.TopInternal < TopInternal)
				{
					break;
				}
				num2--;
				continue;
			}
			return 0;
		}
		return method_45(baseItem);
	}

	private int method_45(BaseItem baseItem_0)
	{
		int num = DisplayRectangle.Top - baseItem_0.TopInternal + method_38().Y;
		if (Math.Abs(num) <= 4)
		{
			num = 0;
		}
		return num;
	}

	public void PopupGallery()
	{
		if (buttonItem_2.Expanded)
		{
			buttonItem_2.Expanded = false;
		}
		else if (!DesignMode)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			Point point = val.PointToScreen(DisplayRectangle.Location);
			GalleryContainer galleryContainer = null;
			if (galleryGroupCollection_0.Count > 0)
			{
				galleryContainer = new GalleryContainer();
				galleryContainer.DefaultSize = DefaultSize;
				galleryContainer.StretchGallery = StretchGallery;
				galleryContainer.MultiLine = false;
				galleryContainer.LayoutOrientation = eOrientation.Vertical;
				foreach (BaseItem popupGalleryItem in PopupGalleryItems)
				{
					galleryContainer.PopupGalleryItems.Add(popupGalleryItem.Copy());
				}
				method_46(galleryContainer);
			}
			else
			{
				galleryContainer = Copy() as GalleryContainer;
			}
			galleryContainer.EnableGalleryPopup = false;
			galleryContainer.bool_29 = true;
			galleryContainer.IncrementalSizing = false;
			galleryContainer.PopupUsesStandardScrollbars = bool_32;
			if (PopupGallerySize.IsEmpty)
			{
				galleryContainer.DefaultSize = method_33(point);
			}
			else
			{
				galleryContainer.DefaultSize = PopupGallerySize;
			}
			galleryContainer.BackgroundStyle.Reset();
			galleryContainer.Boolean_4 = true;
			buttonItem_2.SubItems.Insert(0, galleryContainer);
			buttonItem_2.PopupMenu(point);
		}
		else
		{
			buttonItem_2.Expanded = true;
		}
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		if (!bool_29 && BaseItem.IsOnPopup(this))
		{
			method_37(0);
			Boolean_4 = true;
		}
		base.OnContainerChanged(objOldContainer);
	}

	private void method_46(GalleryContainer galleryContainer_0)
	{
		ArrayList arrayList = method_49();
		foreach (GalleryGroup item3 in arrayList)
		{
			if (item3.Items.Count != 0)
			{
				LabelItem item = method_48(item3);
				galleryContainer_0.SubItems.Add(item);
				ItemContainer item2 = method_47(item3);
				galleryContainer_0.SubItems.Add(item2);
			}
		}
	}

	private ItemContainer method_47(GalleryGroup galleryGroup_0)
	{
		ItemContainer itemContainer = new ItemContainer();
		itemContainer.LayoutOrientation = eOrientation.Horizontal;
		itemContainer.MultiLine = true;
		itemContainer.Name = "container_" + galleryGroup_0.Name;
		foreach (BaseItem item in galleryGroup_0.Items)
		{
			itemContainer.SubItems.Add(item.Copy());
		}
		return itemContainer;
	}

	private LabelItem method_48(GalleryGroup galleryGroup_0)
	{
		LabelItem labelItem = new LabelItem("label_" + galleryGroup_0.Name, galleryGroup_0.Text);
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			Office2007ColorTable colorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			labelItem.BackColor = colorTable.Gallery.GroupLabelBackground;
			labelItem.ForeColor = colorTable.Gallery.GroupLabelText;
			labelItem.SingleLineColor = colorTable.Gallery.GroupLabelBorder;
			labelItem.BorderType = eBorderType.SingleLine;
			labelItem.BorderSide = eBorderSide.Bottom;
			labelItem.PaddingTop = 1;
			labelItem.PaddingLeft = 10;
			labelItem.PaddingBottom = 1;
		}
		return labelItem;
	}

	private ArrayList method_49()
	{
		ArrayList arrayList = new ArrayList(galleryGroupCollection_0.Count);
		foreach (GalleryGroup item in galleryGroupCollection_0)
		{
			arrayList.Add(item);
		}
		arrayList.Sort(new Class201());
		return arrayList;
	}

	protected override InsertPosition GetContainerInsertPosition(Point pScreen, BaseItem dragItem)
	{
		InsertPosition insertPosition = DesignTimeProviderContainer.GetInsertPosition(this, pScreen, dragItem);
		if (insertPosition == null && buttonItem_2.Expanded)
		{
			insertPosition = buttonItem_2.GetInsertPosition(pScreen, dragItem);
		}
		return insertPosition;
	}

	protected override IContentLayout GetContentLayout()
	{
		SerialContentLayoutManager serialContentLayoutManager = base.GetContentLayout() as SerialContentLayoutManager;
		if (serialContentLayoutManager != null)
		{
			serialContentLayoutManager.HorizontalFitContainerHeight = false;
		}
		return serialContentLayoutManager;
	}

	private void method_50(int int_10, int int_11)
	{
		int_7 = int_11;
		int_8 = int_10;
		int_9 = Math.Max(8, Math.Abs(int_11 - int_10) / 3);
		if (int_11 < int_10)
		{
			int_9 *= -1;
		}
		class29_0.method_0();
	}

	private void method_51(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		bitmap_0 = new Bitmap(rectangle_1.Width, rectangle_1.Height, (PixelFormat)925707);
		Graphics val = Graphics.FromImage((Image)(object)bitmap_0);
		BufferedBitmap bufferedBitmap = new BufferedBitmap(val, new Rectangle(0, 0, rectangle_1.Width, rectangle_1.Height));
		Graphics graphics = bufferedBitmap.Graphics;
		Color color = Color.Empty;
		try
		{
			ElementStyle elementStyle = ElementStyleDisplay.smethod_5(base.BackgroundStyle);
			color = ((!elementStyle.BackColor.IsEmpty) ? elementStyle.BackColor : ((elementStyle.BackColorBlend.Count <= 0 || elementStyle.BackColorBlend[0].Color.IsEmpty) ? Color.WhiteSmoke : elementStyle.BackColorBlend[0].Color));
			if (!color.IsEmpty)
			{
				SolidBrush val2 = new SolidBrush(color);
				try
				{
					graphics.FillRectangle((Brush)(object)val2, 0, 0, ((Image)bitmap_0).get_Width(), ((Image)bitmap_0).get_Height());
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			object containerControl = ContainerControl;
			Control val3 = (Control)((containerControl is Control) ? containerControl : null);
			bool flag = false;
			ItemPaintArgs itemPaintArgs = null;
			if (val3 is ItemControl)
			{
				flag = ((ItemControl)(object)val3).AntiAlias;
				itemPaintArgs = ((ItemControl)(object)val3).vmethod_5(graphics);
			}
			else if (val3 is Bar)
			{
				flag = ((Bar)(object)val3).AntiAlias;
				itemPaintArgs = ((Bar)(object)val3).method_5(graphics);
			}
			else if (val3 is ButtonX)
			{
				flag = ((ButtonX)(object)val3).AntiAlias;
				itemPaintArgs = ((ButtonX)(object)val3).vmethod_0(graphics);
			}
			else if (val3 is MenuPanel)
			{
				flag = ((MenuPanel)(object)val3).AntiAlias;
				itemPaintArgs = ((MenuPanel)(object)val3).method_2(graphics);
			}
			Rectangle clipRectangle = GetClipRectangle();
			Matrix val4 = new Matrix();
			val4.Translate((float)(-(clipRectangle.X + point_2.X)), (float)(-(clipRectangle.Y + point_2.Y)), (MatrixOrder)1);
			graphics.set_Transform(val4);
			if (flag)
			{
				graphics.set_SmoothingMode((SmoothingMode)4);
				graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			if (itemPaintArgs == null)
			{
				((Image)bitmap_0).Dispose();
				bitmap_0 = null;
			}
			Class103 @class = method_27();
			@class.method_0(this, itemPaintArgs);
			bufferedBitmap.Render(val);
		}
		finally
		{
			graphics = null;
			bufferedBitmap.Dispose();
			val.Dispose();
		}
		if (!color.IsEmpty)
		{
			bitmap_0.MakeTransparent(color);
		}
	}

	private void method_52(object sender, EventArgs e)
	{
		if (bitmap_0 != null)
		{
			((Image)bitmap_0).Dispose();
			bitmap_0 = null;
		}
	}

	private void method_53(object sender, EventArgs e)
	{
		int_8 += int_9;
		if ((int_8 <= int_7 && int_7 < 0 && int_9 < 0) || (int_8 >= int_7 && int_7 >= 0 && int_9 > 0) || (int_8 >= int_7 && int_7 < 0 && int_9 > 0) || (int_8 <= int_7 && int_7 >= 0 && int_9 < 0))
		{
			class29_0.method_1();
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			val.Invalidate(DisplayRectangle);
		}
	}

	protected override void OnDisplayedChanged()
	{
		if (!Displayed && !bool_29 && Boolean_4)
		{
			method_37(0);
		}
		base.OnDisplayedChanged();
	}

	protected internal override void OnVisibleChanged(bool newValue)
	{
		base.OnVisibleChanged(newValue);
		if (!newValue)
		{
			class29_0.method_1();
		}
	}

	public bool CanExtend(object extendee)
	{
		if (!(extendee is BaseItem value))
		{
			return false;
		}
		return SubItems.Contains(value);
	}

	[DefaultValue(null)]
	[Editor(typeof(GalleryGroupTypeEditor), typeof(UITypeEditor))]
	public GalleryGroup GetGalleryGroup(BaseItem item)
	{
		if (item == null)
		{
			return null;
		}
		return method_54(item);
	}

	public void SetGalleryGroup(BaseItem item, GalleryGroup group)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item argument cannot be null.");
		}
		if (group == null)
		{
			method_54(item)?.Items.Remove(item);
			return;
		}
		method_54(item)?.Items.Remove(item);
		group.Items.Add(item);
	}

	private GalleryGroup method_54(BaseItem baseItem_0)
	{
		foreach (GalleryGroup item in galleryGroupCollection_0)
		{
			if (item.Items.Contains(baseItem_0))
			{
				return item;
			}
		}
		return null;
	}
}

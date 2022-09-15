using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[Designer(typeof(ItemContainerDesigner))]
[ToolboxItem(false)]
public class ItemContainer : ImageItem, IDesignTimeProvider
{
	private eOrientation eOrientation_0;

	private Size size_3 = new Size(24, 24);

	private bool bool_22;

	private int int_4 = 1;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private bool bool_23 = true;

	private eHorizontalItemsAlignment eHorizontalItemsAlignment_0;

	private eVerticalItemsAlignment eVerticalItemsAlignment_0;

	private Size size_4 = Size.Empty;

	private ElementStyle elementStyle_0 = new ElementStyle();

	private int int_5 = 2;

	private bool bool_24;

	private bool bool_25;

	private SerialContentLayoutManager serialContentLayoutManager_0;

	private Class103 class103_0;

	public Size MinimumSize
	{
		get
		{
			return size_4;
		}
		set
		{
			size_4 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Description("Gets or sets container background style.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[Description("Indicates item alignment when container is in horizontal layout.")]
	[DefaultValue(eHorizontalItemsAlignment.Left)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Layout")]
	public virtual eHorizontalItemsAlignment HorizontalItemAlignment
	{
		get
		{
			return eHorizontalItemsAlignment_0;
		}
		set
		{
			eHorizontalItemsAlignment_0 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[DefaultValue(eVerticalItemsAlignment.Top)]
	[DevCoBrowsable(true)]
	[Category("Layout")]
	[Browsable(true)]
	[Description("Indicates item item vertical alignment.")]
	public virtual eVerticalItemsAlignment VerticalItemAlignment
	{
		get
		{
			return eVerticalItemsAlignment_0;
		}
		set
		{
			eVerticalItemsAlignment_0 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Category("Layout")]
	[DefaultValue(false)]
	[Description("Indicates whether items in horizontal layout are wrapped into the new line when they cannot fit allotted container size.")]
	public virtual bool MultiLine
	{
		get
		{
			return bool_24;
		}
		set
		{
			bool_24 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[DefaultValue(1)]
	[Description("Indicates spacing in pixels between items.")]
	[Category("Layout")]
	public int ItemSpacing
	{
		get
		{
			return int_4;
		}
		set
		{
			if (int_4 != value)
			{
				int_4 = value;
				NeedRecalcSize = true;
				OnAppearanceChanged();
			}
		}
	}

	internal bool Boolean_3
	{
		get
		{
			return bool_25;
		}
		set
		{
			bool_25 = value;
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override eOrientation Orientation
	{
		get
		{
			return eOrientation.Horizontal;
		}
		set
		{
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	[Category("Layout")]
	[DevCoBrowsable(true)]
	[DefaultValue(eOrientation.Horizontal)]
	public virtual eOrientation LayoutOrientation
	{
		get
		{
			return eOrientation_0;
		}
		set
		{
			eOrientation_0 = value;
			method_21();
		}
	}

	[DevCoBrowsable(true)]
	[Category("Layout")]
	[DefaultValue(true)]
	[Description("Indicates whether items contained by container are resized to fit the container bounds. When container is in horizontal layout mode then all items will have the same height. When container is in vertical layout mode then all items will have the same width.")]
	[Browsable(true)]
	public virtual bool ResizeItemsToFit
	{
		get
		{
			return bool_23;
		}
		set
		{
			bool_23 = value;
			OnAppearanceChanged();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public override Rectangle Bounds
	{
		get
		{
			return base.Bounds;
		}
		set
		{
			Point point_ = new Point(value.X - m_Rect.X, value.Y - m_Rect.Y);
			base.Bounds = value;
			if (eHorizontalItemsAlignment_0 == eHorizontalItemsAlignment.Left && (serialContentLayoutManager_0 == null || !serialContentLayoutManager_0.RightToLeft))
			{
				if (!point_.IsEmpty)
				{
					method_22(point_);
				}
			}
			else
			{
				LayoutItems(value);
			}
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool Expanded
	{
		get
		{
			return m_Expanded;
		}
		set
		{
			base.Expanded = value;
			if (!value)
			{
				BaseItem.CollapseSubItems(this);
			}
		}
	}

	[Browsable(false)]
	public bool SystemContainer => bool_22;

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[Description("Gets or sets the accessible role of the item.")]
	[Category("Accessibility")]
	[DevCoBrowsable(true)]
	public override AccessibleRole AccessibleRole
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return base.AccessibleRole;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			base.AccessibleRole = value;
		}
	}

	[Browsable(false)]
	[DefaultValue("")]
	[Description("Indicates the Key Tips access key or keys for the item when on Ribbon Control or Ribbon Bar.")]
	[Category("Appearance")]
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

	[Description("Indicates whether the item will auto-collapse (fold) when clicked.")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[Category("Behavior")]
	[DefaultValue(true)]
	public override bool AutoCollapseOnClick
	{
		get
		{
			return base.AutoCollapseOnClick;
		}
		set
		{
			base.AutoCollapseOnClick = value;
		}
	}

	[Description("Indicates whether item can be customized by user.")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Category("Behavior")]
	[DefaultValue(true)]
	public override bool CanCustomize
	{
		get
		{
			return base.CanCustomize;
		}
		set
		{
			base.CanCustomize = value;
		}
	}

	[Description("Indicates item category used to group similar items at design-time.")]
	[DefaultValue("")]
	[DevCoBrowsable(false)]
	[Category("Design")]
	[Browsable(false)]
	public override string Category
	{
		get
		{
			return base.Category;
		}
		set
		{
			base.Category = value;
		}
	}

	[DefaultValue(false)]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
	[Description("Gets or sets whether Click event will be auto repeated when mouse button is kept pressed over the item.")]
	[Browsable(false)]
	public override bool ClickAutoRepeat
	{
		get
		{
			return base.ClickAutoRepeat;
		}
		set
		{
			base.ClickAutoRepeat = value;
		}
	}

	[Description("Gets or sets the auto-repeat interval for the click event when mouse button is kept pressed over the item.")]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
	[DefaultValue(600)]
	[Browsable(false)]
	public override int ClickRepeatInterval
	{
		get
		{
			return base.ClickRepeatInterval;
		}
		set
		{
			base.ClickRepeatInterval = value;
		}
	}

	[Description("Specifies the mouse cursor displayed when mouse is over the item.")]
	[Category("Appearance")]
	[Browsable(false)]
	[DefaultValue(null)]
	[DevCoBrowsable(false)]
	public override Cursor Cursor
	{
		get
		{
			return base.Cursor;
		}
		set
		{
			base.Cursor = value;
		}
	}

	[DefaultValue("")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[Category("Design")]
	[Description("Indicates description of the item that is displayed during design.")]
	public override string Description
	{
		get
		{
			return base.Description;
		}
		set
		{
			base.Description = value;
		}
	}

	[DefaultValue(true)]
	[Browsable(false)]
	[Category("Behavior")]
	[Description("Indicates whether is item enabled.")]
	[DevCoBrowsable(false)]
	public override bool Enabled
	{
		get
		{
			return base.Enabled;
		}
		set
		{
			base.Enabled = value;
		}
	}

	[Description("Indicates whether certain global properties are propagated to all items with the same name when changed.")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DefaultValue(true)]
	[Category("Behavior")]
	public override bool GlobalItem
	{
		get
		{
			return base.GlobalItem;
		}
		set
		{
			base.GlobalItem = value;
		}
	}

	[Description("Determines alignment of the item inside the container.")]
	[DefaultValue(eItemAlignment.Near)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Category("Appearance")]
	public override eItemAlignment ItemAlignment
	{
		get
		{
			return base.ItemAlignment;
		}
		set
		{
			base.ItemAlignment = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(false)]
	[Category("Design")]
	[Description("Indicates list of shortcut keys for this item.")]
	[TypeConverter(typeof(ShortcutsConverter))]
	[Editor(typeof(ShortcutsDesigner), typeof(UITypeEditor))]
	[Browsable(false)]
	public override ShortcutsCollection Shortcuts
	{
		get
		{
			return base.Shortcuts;
		}
		set
		{
			base.Shortcuts = value;
		}
	}

	[Category("Behavior")]
	[Description("Determines whether sub-items are displayed.")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DefaultValue(true)]
	public override bool ShowSubItems
	{
		get
		{
			return base.ShowSubItems;
		}
		set
		{
			base.ShowSubItems = value;
		}
	}

	[DefaultValue(false)]
	[Category("Appearance")]
	[Description("Indicates whether item will stretch to consume empty space. Items on stretchable, no-wrap Bars only.")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public override bool Stretch
	{
		get
		{
			return base.Stretch;
		}
		set
		{
			base.Stretch = value;
		}
	}

	[Category("Appearance")]
	[Description("Specifies whether item is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DefaultValue(false)]
	public override bool ThemeAware
	{
		get
		{
			return base.ThemeAware;
		}
		set
		{
			base.ThemeAware = value;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Localizable(true)]
	[Category("Appearance")]
	[DefaultValue("")]
	[Description("Indicates the text that is displayed when mouse hovers over the item.")]
	public override string Tooltip
	{
		get
		{
			return base.Tooltip;
		}
		set
		{
			base.Tooltip = value;
		}
	}

	public ItemContainer()
	{
		m_IsContainer = true;
		AutoCollapseOnClick = true;
		AccessibleRole = (AccessibleRole)20;
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
	}

	private void method_17(object sender, EventArgs e)
	{
		NeedRecalcSize = true;
		OnAppearanceChanged();
	}

	private void method_18(object sender, EventArgs e)
	{
		NeedRecalcSize = true;
		OnAppearanceChanged();
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		OnAppearanceChanged();
	}

	private bool ShouldSerializeMinimumSize()
	{
		return !size_4.IsEmpty;
	}

	protected virtual Rectangle GetClipRectangle()
	{
		Rectangle displayRectangle = DisplayRectangle;
		ElementStyle elementStyle = ElementStyleDisplay.smethod_5(elementStyle_0);
		displayRectangle.X += Class52.smethod_3(elementStyle);
		displayRectangle.Width -= Class52.smethod_1(elementStyle);
		displayRectangle.Y += Class52.smethod_7(elementStyle);
		displayRectangle.Height -= Class52.smethod_2(elementStyle);
		return displayRectangle;
	}

	internal void method_19(ItemPaintArgs itemPaintArgs_0)
	{
		PaintBackground(itemPaintArgs_0);
	}

	protected virtual void PaintBackground(ItemPaintArgs p)
	{
		elementStyle_0.method_4(p.Colors);
		Graphics graphics = p.Graphics;
		BaseRenderer baseRenderer_ = p.BaseRenderer_0;
		if (baseRenderer_ != null)
		{
			ItemContainerRendererEventArgs itemContainerRendererEventArgs = new ItemContainerRendererEventArgs(p.Graphics, this);
			itemContainerRendererEventArgs.itemPaintArgs_0 = p;
			baseRenderer_.DrawItemContainer(itemContainerRendererEventArgs);
		}
		else
		{
			ElementStyleDisplay.Paint(new ElementStyleDisplayInfo(elementStyle_0, graphics, DisplayRectangle));
		}
	}

	public override void Paint(ItemPaintArgs p)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		Graphics graphics = p.Graphics;
		Region val = null;
		bool flag = false;
		PaintBackground(p);
		if (Style == eDotNetBarStyle.Office2007 && BeginGroup)
		{
			Rectangle displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-1, -1);
			val = graphics.get_Clip();
			graphics.SetClip(displayRectangle, (CombineMode)0);
			flag = true;
		}
		else
		{
			Rectangle clipRectangle = GetClipRectangle();
			val = graphics.get_Clip();
			graphics.SetClip(clipRectangle, (CombineMode)1);
			flag = true;
		}
		Class103 @class = method_27();
		@class.method_0(this, p);
		if (flag)
		{
			if (val != null)
			{
				graphics.set_Clip(val);
			}
			else
			{
				graphics.ResetClip();
			}
		}
		if (DesignMode && !SystemContainer && p.DesignerSelection)
		{
			Rectangle displayRectangle2 = DisplayRectangle;
			Pen val2 = null;
			val2 = ((!Focused) ? new Pen(Color.FromArgb(80, Color.Black), 1f) : new Pen(Color.FromArgb(190, Color.Navy), 1f));
			val2.set_DashStyle((DashStyle)2);
			Class50.smethod_11(graphics, val2, displayRectangle2, 3);
			val2.Dispose();
			val2 = null;
			Image val3 = (Image)(object)Class109.smethod_67("SystemImages.AddMoreItemsContainer.png");
			if (Parent is ItemContainer && !((ItemContainer)Parent).SystemContainer)
			{
				ItemContainer itemContainer = Parent as ItemContainer;
				while (itemContainer != null && !itemContainer.SystemContainer)
				{
					if (new Rectangle(itemContainer.DisplayRectangle.Location, val3.get_Size()).Contains(DisplayRectangle.Location))
					{
						if (displayRectangle2.X + val3.get_Width() + 1 > DisplayRectangle.Right)
						{
							displayRectangle2.X = DisplayRectangle.X;
							if (displayRectangle2.Y + val3.get_Height() >= DisplayRectangle.Bottom)
							{
								break;
							}
							displayRectangle2.Y += val3.get_Height() + 1;
						}
						displayRectangle2.X += val3.get_Width() + 1;
					}
					itemContainer = itemContainer.Parent as ItemContainer;
				}
			}
			rectangle_0 = new Rectangle(displayRectangle2.X + 1, displayRectangle2.Y + 1, val3.get_Width(), val3.get_Height());
			graphics.DrawImageUnscaled(val3, rectangle_0.Location);
		}
		DrawInsertMarker(p.Graphics);
	}

	protected virtual Size GetEmptyDesignTimeSize()
	{
		Size result = size_3;
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			result.Width += 12;
		}
		else
		{
			result.Height += 12;
		}
		return result;
	}

	public override void RecalcSize()
	{
		if (SuspendLayout)
		{
			return;
		}
		if (SubItems.Count == 0)
		{
			if (DesignMode && !SystemContainer)
			{
				m_Rect.Size = GetEmptyDesignTimeSize();
			}
			else
			{
				m_Rect = Rectangle.Empty;
			}
			base.RecalcSize();
		}
		else
		{
			m_Rect = LayoutItems(m_Rect);
			base.RecalcSize();
		}
	}

	protected virtual Rectangle LayoutItems(Rectangle bounds)
	{
		IContentLayout contentLayout = GetContentLayout();
		BlockLayoutManager blockLayout = method_26();
		Rectangle layoutRectangle = GetLayoutRectangle(bounds);
		BaseItem[] array = new BaseItem[SubItems.Count];
		if (bool_25)
		{
			for (int i = 0; i < SubItems.Count; i++)
			{
				if (SubItems[i] is ButtonItem buttonItem)
				{
					buttonItem.bool_36 = true;
					buttonItem.WidthInternal = layoutRectangle.Width;
				}
				array[i] = SubItems[i];
			}
		}
		else
		{
			SubItems.CopyTo(array, 0);
		}
		ElementStyle elementStyle = ElementStyleDisplay.smethod_5(elementStyle_0);
		layoutRectangle = contentLayout.Layout(layoutRectangle, array, blockLayout);
		if (!SystemContainer)
		{
			layoutRectangle = new Rectangle(bounds.Location, layoutRectangle.Size);
		}
		if (size_4.Width > 0 && size_4.Width > layoutRectangle.Width)
		{
			layoutRectangle.Width = size_4.Width;
		}
		if (size_4.Height > 0 && size_4.Height > layoutRectangle.Height)
		{
			layoutRectangle.Height = size_4.Height;
		}
		layoutRectangle.Width += Class52.smethod_1(elementStyle);
		layoutRectangle.Height += Class52.smethod_2(elementStyle);
		return layoutRectangle;
	}

	protected virtual Rectangle GetLayoutRectangle(Rectangle bounds)
	{
		if (bounds.Width == 0)
		{
			bounds.Width = 16;
		}
		if (bounds.Height == 0)
		{
			bounds.Height = 16;
		}
		if (size_4.Width > 0)
		{
			bounds.Width = size_4.Width;
		}
		if (size_4.Height > 0)
		{
			bounds.Height = size_4.Height;
		}
		ElementStyle elementStyle = ElementStyleDisplay.smethod_5(elementStyle_0);
		bounds.X += Class52.smethod_3(elementStyle);
		bounds.Y += Class52.smethod_7(elementStyle);
		bounds.Width -= Class52.smethod_1(elementStyle);
		bounds.Height -= Class52.smethod_2(elementStyle);
		return bounds;
	}

	protected override void OnExternalSizeChange()
	{
		base.OnExternalSizeChange();
		if ((eVerticalItemsAlignment_0 != 0 || IsRightToLeft) && SubItems.Count > 0 && !SuspendLayout)
		{
			LayoutItems(m_Rect);
		}
	}

	protected internal override void OnAfterItemRemoved(BaseItem item)
	{
		if (item is ButtonItem && bool_25)
		{
			((ButtonItem)item).bool_36 = false;
		}
		base.OnAfterItemRemoved(item);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		if (DesignMode && !SystemContainer)
		{
			BaseItem baseItem = ItemAtLocation(objArg.get_X(), objArg.get_Y());
			if (baseItem == this && GetOwner() is IOwner owner)
			{
				owner.SetFocusItem(this);
				return;
			}
		}
		else if (!DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			if (DesignMode)
			{
				if (GetOwner() is IOwner owner2)
				{
					owner2.SetFocusItem(null);
				}
				LeaveHotSubItem(null);
			}
			return;
		}
		base.InternalMouseDown(objArg);
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		if (!DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			LeaveHotSubItem(null);
			if (!SystemContainer)
			{
				return;
			}
		}
		base.InternalMouseMove(objArg);
	}

	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		if (DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			base.InternalMouseUp(objArg);
		}
	}

	public override BaseItem ItemAtLocation(int x, int y)
	{
		if (DesignMode && !SystemContainer && !rectangle_0.IsEmpty && rectangle_0.Contains(x, y))
		{
			return this;
		}
		if (Visible && DisplayRectangle.Contains(x, y))
		{
			if (m_SubItems != null)
			{
				foreach (BaseItem subItem in m_SubItems)
				{
					if (subItem.IsContainer)
					{
						BaseItem baseItem2 = subItem.ItemAtLocation(x, y);
						if (baseItem2 != null)
						{
							return baseItem2;
						}
					}
					else if ((subItem.Visible || base.IsOnCustomizeMenu) && subItem.Displayed && subItem.DisplayRectangle.Contains(x, y) && (!DesignMode || DisplayRectangle.IntersectsWith(subItem.DisplayRectangle)))
					{
						return subItem;
					}
				}
			}
			if (DisplayRectangle.Contains(x, y) && !SystemContainer)
			{
				return this;
			}
			return null;
		}
		return null;
	}

	private void method_20()
	{
		NeedRecalcSize = true;
		OnAppearanceChanged();
	}

	private void method_21()
	{
		NeedRecalcSize = true;
		if (serialContentLayoutManager_0 != null)
		{
			serialContentLayoutManager_0.ContentOrientation = ((LayoutOrientation != 0) ? eContentOrientation.Vertical : eContentOrientation.Horizontal);
		}
		OnAppearanceChanged();
	}

	internal void method_22(Point point_2)
	{
		if (point_2.IsEmpty)
		{
			return;
		}
		foreach (IBlock subItem in SubItems)
		{
			Rectangle bounds = subItem.Bounds;
			bounds.Offset(point_2);
			subItem.Bounds = bounds;
		}
	}

	protected override void OnTopLocationChanged(int oldValue)
	{
		base.OnTopLocationChanged(oldValue);
		Point point_ = new Point(0, TopInternal - oldValue);
		method_22(point_);
	}

	protected override void OnLeftLocationChanged(int oldValue)
	{
		base.OnLeftLocationChanged(oldValue);
		Point point_ = new Point(LeftInternal - oldValue, 0);
		method_22(point_);
	}

	public override BaseItem Copy()
	{
		ItemContainer itemContainer = new ItemContainer();
		CopyToItem(itemContainer);
		return itemContainer;
	}

	protected override void CopyToItem(BaseItem c)
	{
		ItemContainer itemContainer = c as ItemContainer;
		itemContainer.BackgroundStyle.ApplyStyle(elementStyle_0);
		itemContainer.HorizontalItemAlignment = HorizontalItemAlignment;
		itemContainer.ItemSpacing = ItemSpacing;
		itemContainer.LayoutOrientation = LayoutOrientation;
		itemContainer.MinimumSize = MinimumSize;
		itemContainer.MultiLine = MultiLine;
		itemContainer.ResizeItemsToFit = ResizeItemsToFit;
		itemContainer.VerticalItemAlignment = VerticalItemAlignment;
		base.CopyToItem(itemContainer);
	}

	protected internal override void OnSubItemExpandChange(BaseItem item)
	{
		base.OnSubItemExpandChange(item);
		if (item.Expanded)
		{
			Expanded = true;
		}
	}

	protected internal override void OnSubItemsClear()
	{
		RefreshImageSize();
		base.OnSubItemsClear();
	}

	protected override void OnDisplayedChanged()
	{
		base.OnDisplayedChanged();
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem.Visible)
			{
				subItem.Displayed = Displayed;
			}
		}
		if (!Displayed)
		{
			InternalMouseLeave();
		}
	}

	internal void method_23(bool bool_26)
	{
		bool_22 = bool_26;
	}

	protected virtual IContentLayout GetContentLayout()
	{
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Invalid comparison between Unknown and I4
		if (serialContentLayoutManager_0 == null)
		{
			serialContentLayoutManager_0 = new SerialContentLayoutManager();
			serialContentLayoutManager_0.BlockSpacing = 1;
			serialContentLayoutManager_0.FitContainerOversize = false;
			serialContentLayoutManager_0.FitContainer = false;
			serialContentLayoutManager_0.BeforeNewBlockLayout += serialContentLayoutManager_0_BeforeNewBlockLayout;
		}
		serialContentLayoutManager_0.MultiLine = bool_24;
		serialContentLayoutManager_0.EvenHeight = bool_23;
		if (size_4.Width > 0 && eOrientation_0 == eOrientation.Vertical)
		{
			serialContentLayoutManager_0.VerticalFitContainerWidth = true;
		}
		else
		{
			serialContentLayoutManager_0.VerticalFitContainerWidth = false;
		}
		if (size_4.Height > 0 && eOrientation_0 == eOrientation.Horizontal)
		{
			serialContentLayoutManager_0.HorizontalFitContainerHeight = true;
		}
		else
		{
			serialContentLayoutManager_0.HorizontalFitContainerHeight = false;
		}
		serialContentLayoutManager_0.BlockLineAlignment = eContentVerticalAlignment.Top;
		serialContentLayoutManager_0.ContentAlignment = method_24();
		serialContentLayoutManager_0.ContentVerticalAlignment = method_25();
		serialContentLayoutManager_0.ContentOrientation = ((LayoutOrientation != 0) ? eContentOrientation.Vertical : eContentOrientation.Horizontal);
		serialContentLayoutManager_0.RightToLeft = false;
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null && (int)val.get_RightToLeft() == 1)
		{
			serialContentLayoutManager_0.RightToLeft = true;
		}
		else
		{
			serialContentLayoutManager_0.RightToLeft = false;
		}
		serialContentLayoutManager_0.BlockSpacing = int_4 - (BeginGroup ? 1 : 0);
		return serialContentLayoutManager_0;
	}

	private void serialContentLayoutManager_0_BeforeNewBlockLayout(object sender, LayoutManagerLayoutEventArgs e)
	{
		if (e.Block is BaseItem baseItem && baseItem.BeginGroup && !(baseItem is ItemContainer) && e.BlockVisibleIndex > 0)
		{
			if (eOrientation_0 == eOrientation.Horizontal)
			{
				e.CurrentPosition.X += int_5;
			}
			else
			{
				e.CurrentPosition.Y += int_5;
			}
		}
	}

	private eContentAlignment method_24()
	{
		if (eHorizontalItemsAlignment_0 == eHorizontalItemsAlignment.Left)
		{
			return eContentAlignment.Left;
		}
		if (eHorizontalItemsAlignment_0 == eHorizontalItemsAlignment.Center)
		{
			return eContentAlignment.Center;
		}
		return eContentAlignment.Right;
	}

	private eContentVerticalAlignment method_25()
	{
		if (eVerticalItemsAlignment_0 == eVerticalItemsAlignment.Top)
		{
			return eContentVerticalAlignment.Top;
		}
		if (eVerticalItemsAlignment_0 == eVerticalItemsAlignment.Middle)
		{
			return eContentVerticalAlignment.Middle;
		}
		if (eVerticalItemsAlignment_0 == eVerticalItemsAlignment.Bottom)
		{
			return eContentVerticalAlignment.Bottom;
		}
		return eContentVerticalAlignment.Top;
	}

	private BlockLayoutManager method_26()
	{
		return new ItemBlockLayoutManager();
	}

	internal Class103 method_27()
	{
		if (class103_0 == null)
		{
			class103_0 = new Class103();
		}
		return class103_0;
	}

	protected virtual InsertPosition GetContainerInsertPosition(Point pScreen, BaseItem dragItem)
	{
		return DesignTimeProviderContainer.GetInsertPosition(this, pScreen, dragItem);
	}

	InsertPosition IDesignTimeProvider.GetInsertPosition(Point pScreen, BaseItem DragItem)
	{
		return GetContainerInsertPosition(pScreen, DragItem);
	}

	void IDesignTimeProvider.DrawReversibleMarker(int iPos, bool Before)
	{
		DesignTimeProviderContainer.DrawReversibleMarker(this, iPos, Before);
	}

	void IDesignTimeProvider.InsertItemAt(BaseItem objItem, int iPos, bool Before)
	{
		DesignTimeProviderContainer.InsertItemAt(this, objItem, iPos, Before);
	}

	internal bool method_28()
	{
		foreach (BaseItem subItem in SubItems)
		{
			if (!subItem.Visible || !subItem.Displayed)
			{
				continue;
			}
			if (subItem is ItemContainer)
			{
				if (((ItemContainer)subItem).method_28())
				{
					SetHotSubItem(null);
					m_HotSubItem = subItem;
					return true;
				}
			}
			else if (method_29(subItem))
			{
				SetHotSubItem(subItem);
				return true;
			}
		}
		return false;
	}

	private bool method_29(BaseItem baseItem_0)
	{
		if (baseItem_0 is LabelItem)
		{
			return false;
		}
		return true;
	}

	public void SetHotSubItem(BaseItem item)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		if (item == m_HotSubItem)
		{
			return;
		}
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseLeave();
			if (m_AutoExpand && m_HotSubItem.Expanded)
			{
				m_HotSubItem.Expanded = false;
			}
			m_HotSubItem = null;
		}
		if (item != null)
		{
			m_HotSubItem = item;
			m_HotSubItem.InternalMouseEnter();
			m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.LeftInternal + 1, m_HotSubItem.TopInternal + 1, 0));
			if (ContainerControl is IScrollableItemControl scrollableItemControl)
			{
				scrollableItemControl.KeyboardItemSelected(m_HotSubItem);
			}
		}
	}

	public override void InternalKeyDown(KeyEventArgs objArg)
	{
		base.InternalKeyDown(objArg);
		Class104.smethod_0(this, objArg);
	}
}

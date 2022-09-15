using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Design;

namespace DevComponents.Editors.DateTimeAdv;

public class CalendarBase : ImageItem, IDesignTimeProvider
{
	private ElementStyle elementStyle_0 = new ElementStyle();

	private Class103 class103_0;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Description("Gets or sets container background style.")]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[Description("Indicates the name used to identify item.")]
	[Category("Design")]
	[DefaultValue("")]
	public override string Name
	{
		get
		{
			return base.Name;
		}
		set
		{
			base.Name = value;
		}
	}

	[DevCoBrowsable(true)]
	[Description("Gets or sets the accessible role of the item.")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[Category("Accessibility")]
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

	[Category("Appearance")]
	[Description("Indicates the Key Tips access key or keys for the item when on Ribbon Control or Ribbon Bar.")]
	[Browsable(false)]
	[DefaultValue("")]
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

	[DevCoBrowsable(false)]
	[Category("Behavior")]
	[Description("Indicates whether the item will auto-collapse (fold) when clicked.")]
	[Browsable(false)]
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
	[Category("Behavior")]
	[Browsable(false)]
	[DefaultValue(true)]
	[DevCoBrowsable(false)]
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

	[Category("Design")]
	[DefaultValue("")]
	[Description("Indicates item category used to group similar items at design-time.")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
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
	[Browsable(false)]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
	[Description("Gets or sets whether Click event will be auto repeated when mouse button is kept pressed over the item.")]
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

	[Category("Behavior")]
	[DefaultValue(600)]
	[Description("Gets or sets the auto-repeat interval for the click event when mouse button is kept pressed over the item.")]
	[DevCoBrowsable(false)]
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

	[DefaultValue(null)]
	[Category("Appearance")]
	[Browsable(false)]
	[Description("Specifies the mouse cursor displayed when mouse is over the item.")]
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

	[Description("Indicates description of the item that is displayed during design.")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[Category("Design")]
	[DefaultValue("")]
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
	[Category("Behavior")]
	[Description("Indicates whether certain global properties are propagated to all items with the same name when changed.")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
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

	[Category("Appearance")]
	[Description("Determines alignment of the item inside the container.")]
	[DevCoBrowsable(false)]
	[DefaultValue(DevComponents.DotNetBar.eItemAlignment.Near)]
	[Browsable(false)]
	public override DevComponents.DotNetBar.eItemAlignment ItemAlignment
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
	[Browsable(false)]
	[Category("Design")]
	[Description("Indicates list of shortcut keys for this item.")]
	[TypeConverter(typeof(ShortcutsConverter))]
	[Editor(typeof(ShortcutsDesigner), typeof(UITypeEditor))]
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

	[Browsable(false)]
	[DefaultValue(true)]
	[Description("Determines whether sub-items are displayed.")]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
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

	[Description("Specifies whether item is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DefaultValue(false)]
	[Category("Appearance")]
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

	[Description("Indicates the text that is displayed when mouse hovers over the item.")]
	[Category("Appearance")]
	[Browsable(false)]
	[DefaultValue("")]
	[DevCoBrowsable(false)]
	[Localizable(true)]
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

	[Browsable(false)]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
		}
	}

	public CalendarBase()
	{
		m_IsContainer = true;
		AutoCollapseOnClick = true;
		AccessibleRole = (AccessibleRole)20;
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
	}

	public override void Paint(ItemPaintArgs p)
	{
		Graphics graphics = p.Graphics;
		Region val = null;
		PaintBackground(p);
		Rectangle clipRectangle = GetClipRectangle();
		val = graphics.get_Clip();
		graphics.SetClip(clipRectangle, (CombineMode)1);
		Class103 @class = method_17();
		@class.method_1(this, p);
		if (val != null)
		{
			graphics.set_Clip(val);
		}
		else
		{
			graphics.ResetClip();
		}
		DrawInsertMarker(p.Graphics);
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

	protected virtual void PaintBackground(ItemPaintArgs p)
	{
		elementStyle_0.method_4(p.Colors);
		ElementStyle renderBackgroundStyle = GetRenderBackgroundStyle();
		Graphics graphics = p.Graphics;
		ElementStyleDisplay.Paint(new ElementStyleDisplayInfo(renderBackgroundStyle, graphics, DisplayRectangle));
	}

	protected virtual ElementStyle GetRenderBackgroundStyle()
	{
		return ElementStyleDisplay.smethod_5(elementStyle_0);
	}

	internal Class103 method_17()
	{
		if (class103_0 == null)
		{
			class103_0 = new Class103();
		}
		return class103_0;
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		OnAppearanceChanged();
	}

	public override BaseItem Copy()
	{
		CalendarBase calendarBase = new CalendarBase();
		CopyToItem(calendarBase);
		return calendarBase;
	}

	protected override void CopyToItem(BaseItem c)
	{
		SingleMonthCalendar singleMonthCalendar = c as SingleMonthCalendar;
		singleMonthCalendar.BackgroundStyle.ApplyStyle(elementStyle_0);
		base.CopyToItem(singleMonthCalendar);
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
}

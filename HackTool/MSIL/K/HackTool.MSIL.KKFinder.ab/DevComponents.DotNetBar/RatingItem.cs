using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;
using DevComponents.Editors;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
[Designer(typeof(RatingItemDesigner))]
[DefaultEvent("RatingChanged")]
public class RatingItem : PopupItem
{
	private struct Struct19
	{
		public Image image_0;

		public Rectangle rectangle_0;

		public Struct19(Image image, Rectangle sourceBounds)
		{
			image_0 = image;
			rectangle_0 = sourceBounds;
		}
	}

	private struct Struct20
	{
		public Rectangle rectangle_0;

		public bool bool_0;
	}

	private EventHandler eventHandler_19;

	private EventHandler eventHandler_20;

	private RatingChangeEventHandler ratingChangeEventHandler_0;

	private EventHandler eventHandler_21;

	private EventHandler eventHandler_22;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private ParseIntegerValueEventHandler parseIntegerValueEventHandler_0;

	private ParseDoubleValueEventHandler parseDoubleValueEventHandler_0;

	private double double_0;

	private int int_5;

	private bool bool_25 = true;

	private Struct20[] struct20_0 = new Struct20[5];

	private Size size_4 = new Size(13, 13);

	private Image image_0;

	private int int_6 = -1;

	private int int_7 = 8;

	private Size size_5 = Size.Empty;

	private bool bool_26;

	private ElementStyle elementStyle_0 = new ElementStyle();

	private RatingImages ratingImages_0;

	private bool bool_27 = true;

	private Color color_0 = Color.Empty;

	private int int_8;

	private eOrientation eOrientation_0;

	private bool bool_28 = true;

	[Category("Data")]
	[Description("Indicates average rating shown by control.")]
	[DefaultValue(0.0)]
	public double AverageRating
	{
		get
		{
			return double_0;
		}
		set
		{
			if (value < 0.0)
			{
				value = 0.0;
			}
			if (value > 5.0)
			{
				value = 5.0;
			}
			if (value != double_0)
			{
				double_0 = value;
				OnAverageRatingChanged(EventArgs.Empty);
				Refresh();
			}
		}
	}

	[Browsable(false)]
	[TypeConverter(typeof(StringConverter))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[RefreshProperties(RefreshProperties.All)]
	[Bindable(true)]
	public object AverageRatingValue
	{
		get
		{
			return AverageRating;
		}
		set
		{
			if (method_18(value))
			{
				return;
			}
			if (IsNull(value))
			{
				AverageRating = 0.0;
			}
			else if (!(value is double) && !(value is int) && !(value is float))
			{
				if (value is long)
				{
					string s = value.ToString();
					AverageRating = double.Parse(s);
					return;
				}
				if (!(value is string))
				{
					throw new ArgumentException("AverageRatingValue property expects either null/nothing value or double type.");
				}
				double result = 0.0;
				if (!double.TryParse(value.ToString(), out result))
				{
					throw new ArgumentException("AverageRatingValue property expects either null/nothing value or double type.");
				}
				AverageRating = result;
			}
			else
			{
				AverageRating = (double)value;
			}
		}
	}

	[DefaultValue(0)]
	[Category("Data")]
	[Description("Indicates rating value represented by the control.")]
	public int Rating
	{
		get
		{
			return int_5;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			if (value > 5)
			{
				value = 5;
			}
			if (int_5 != value)
			{
				SetRating(value, eEventSource.Code);
			}
		}
	}

	[Browsable(false)]
	[RefreshProperties(RefreshProperties.All)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Bindable(true)]
	public object RatingValue
	{
		get
		{
			return int_5;
		}
		set
		{
			if (method_19(value))
			{
				return;
			}
			if (IsNull(value))
			{
				Rating = 0;
				return;
			}
			if (value is int)
			{
				Rating = (int)value;
				return;
			}
			if (value is string)
			{
				int result = 0;
				if (!int.TryParse(value.ToString(), out result))
				{
					throw new ArgumentException("RatingValue property expects either null/nothing value or int type.");
				}
				Rating = result;
				return;
			}
			throw new ArgumentException("RatingValue property expects either null/nothing value or int type.");
		}
	}

	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Indicates whether rating can be edited.")]
	public bool IsEditable
	{
		get
		{
			return bool_25;
		}
		set
		{
			if (bool_25 != value)
			{
				bool_25 = value;
				method_29(-1);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Style")]
	[Description("Gets or sets control background style.")]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[Browsable(true)]
	[Description("Gets the reference to custom rating images.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Images")]
	public RatingImages CustomImages => ratingImages_0;

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(true)]
	[Description("Indicates whether text assigned to the check box is visible.")]
	public bool TextVisible
	{
		get
		{
			return bool_27;
		}
		set
		{
			bool_27 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates text color.")]
	public Color TextColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[Description("Gets or sets the spacing between optional text and the rating.")]
	[DefaultValue(0)]
	public int TextSpacing
	{
		get
		{
			return int_8;
		}
		set
		{
			if (int_8 != value)
			{
				int_8 = value;
				NeedRecalcSize = true;
				OnAppearanceChanged();
			}
		}
	}

	[DefaultValue(eOrientation.Horizontal)]
	[Category("Appearance")]
	[Description("Gets or sets the orientation of rating control.")]
	public eOrientation RatingOrientation
	{
		get
		{
			return eOrientation_0;
		}
		set
		{
			if (eOrientation_0 != value)
			{
				eOrientation_0 = value;
				NeedRecalcSize = true;
				Refresh();
			}
		}
	}

	protected override bool IsMarkupSupported => bool_28;

	[DefaultValue(true)]
	[Description("Indicates whether text-markup support is enabled for items Text property.")]
	[Category("Appearance")]
	public bool EnableMarkup
	{
		get
		{
			return bool_28;
		}
		set
		{
			if (bool_28 != value)
			{
				bool_28 = value;
				NeedRecalcSize = true;
				OnTextChanged();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override SubItemsCollection SubItems => base.SubItems;

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

	[Browsable(false)]
	public override ePersonalizedMenus PersonalizedMenus
	{
		get
		{
			return base.PersonalizedMenus;
		}
		set
		{
			base.PersonalizedMenus = value;
		}
	}

	[Browsable(false)]
	public override ePopupAnimation PopupAnimation
	{
		get
		{
			return base.PopupAnimation;
		}
		set
		{
			base.PopupAnimation = value;
		}
	}

	[Browsable(false)]
	public override Font PopupFont
	{
		get
		{
			return base.PopupFont;
		}
		set
		{
			base.PopupFont = value;
		}
	}

	[Browsable(false)]
	public override ePopupSide PopupSide
	{
		get
		{
			return base.PopupSide;
		}
		set
		{
			base.PopupSide = value;
		}
	}

	[Browsable(false)]
	public override ePopupType PopupType
	{
		get
		{
			return base.PopupType;
		}
		set
		{
			base.PopupType = value;
		}
	}

	[Browsable(false)]
	public override int PopupWidth
	{
		get
		{
			return base.PopupWidth;
		}
		set
		{
			base.PopupWidth = value;
		}
	}

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

	[Browsable(false)]
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

	[Browsable(false)]
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

	[DefaultValue(false)]
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

	[Description("Occurs when Rating property has changed.")]
	public event EventHandler RatingChanged
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

	[Description("Occurs when Rating property has changed.")]
	public event EventHandler RatingValueChanged
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

	[Description("Occurs when Rating property has changed.")]
	public event RatingChangeEventHandler RatingChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ratingChangeEventHandler_0 = (RatingChangeEventHandler)Delegate.Combine(ratingChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ratingChangeEventHandler_0 = (RatingChangeEventHandler)Delegate.Remove(ratingChangeEventHandler_0, value);
		}
	}

	[Description("Occurs when AverageRating property has changed.")]
	public event EventHandler AverageRatingChanged
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

	[Description("Occurs when AverageRatingValue property has changed.")]
	public event EventHandler AverageRatingValueChanged
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

	public event MarkupLinkClickEventHandler MarkupLinkClick
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

	public event ParseIntegerValueEventHandler ParseRatingValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			parseIntegerValueEventHandler_0 = (ParseIntegerValueEventHandler)Delegate.Combine(parseIntegerValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			parseIntegerValueEventHandler_0 = (ParseIntegerValueEventHandler)Delegate.Remove(parseIntegerValueEventHandler_0, value);
		}
	}

	public event ParseDoubleValueEventHandler ParseAverageRatingValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			parseDoubleValueEventHandler_0 = (ParseDoubleValueEventHandler)Delegate.Combine(parseDoubleValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			parseDoubleValueEventHandler_0 = (ParseDoubleValueEventHandler)Delegate.Remove(parseDoubleValueEventHandler_0, value);
		}
	}

	public RatingItem()
	{
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		ratingImages_0 = new RatingImages(this);
		AutoCollapseOnClick = false;
	}

	public override BaseItem Copy()
	{
		RatingItem ratingItem = new RatingItem();
		ratingItem.Name = Name;
		CopyToItem(ratingItem);
		return ratingItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		RatingItem ratingItem = copy as RatingItem;
		ratingItem.AverageRating = AverageRating;
		ratingItem.Rating = Rating;
		ratingItem.RatingOrientation = RatingOrientation;
		ratingItem.IsEditable = IsEditable;
		ratingItem.TextSpacing = TextSpacing;
		ratingItem.TextColor = TextColor;
		ratingItem.TextVisible = TextVisible;
		base.CopyToItem((BaseItem)ratingItem);
	}

	protected virtual void OnAverageRatingChanged(EventArgs eventArgs)
	{
		if (eventHandler_21 != null)
		{
			eventHandler_21(this, eventArgs);
		}
		if (eventHandler_22 != null)
		{
			eventHandler_22(this, eventArgs);
		}
	}

	private bool method_18(object object_2)
	{
		ParseDoubleValueEventArgs parseDoubleValueEventArgs = new ParseDoubleValueEventArgs(object_2);
		OnParseAverageRatingValue(parseDoubleValueEventArgs);
		if (parseDoubleValueEventArgs.IsParsed)
		{
			AverageRating = parseDoubleValueEventArgs.ParsedValue;
		}
		return parseDoubleValueEventArgs.IsParsed;
	}

	protected virtual void OnParseAverageRatingValue(ParseDoubleValueEventArgs e)
	{
		if (parseDoubleValueEventHandler_0 != null)
		{
			parseDoubleValueEventHandler_0(this, e);
		}
	}

	public void SetRating(int newRating, eEventSource source)
	{
		if (newRating != int_5)
		{
			RatingChangeEventArgs ratingChangeEventArgs = new RatingChangeEventArgs(newRating, int_5, source);
			OnRatingChanging(ratingChangeEventArgs);
			if (!ratingChangeEventArgs.Cancel)
			{
				newRating = ratingChangeEventArgs.NewRating;
				int_5 = newRating;
				OnRatingChanged(ratingChangeEventArgs);
				ExecuteCommand();
				Refresh();
			}
		}
	}

	protected virtual void OnRatingChanging(RatingChangeEventArgs e)
	{
		if (ratingChangeEventHandler_0 != null)
		{
			ratingChangeEventHandler_0(this, e);
		}
	}

	protected virtual void OnRatingChanged(EventArgs eventArgs)
	{
		eventHandler_19?.Invoke(this, eventArgs);
		eventHandler_20?.Invoke(this, eventArgs);
	}

	protected virtual bool IsNull(object value)
	{
		if (value != null && !(value is DBNull))
		{
			return false;
		}
		return true;
	}

	private bool method_19(object object_2)
	{
		ParseIntegerValueEventArgs parseIntegerValueEventArgs = new ParseIntegerValueEventArgs(object_2);
		OnParseRatingValue(parseIntegerValueEventArgs);
		if (parseIntegerValueEventArgs.IsParsed)
		{
			Rating = parseIntegerValueEventArgs.ParsedValue;
		}
		return parseIntegerValueEventArgs.IsParsed;
	}

	protected virtual void OnParseRatingValue(ParseIntegerValueEventArgs e)
	{
		if (parseIntegerValueEventHandler_0 != null)
		{
			parseIntegerValueEventHandler_0(this, e);
		}
	}

	public override void Paint(ItemPaintArgs p)
	{
		PaintBackground(p);
		Rectangle rectangle_ = DisplayRectangle;
		if (bool_26)
		{
			method_22(p, ref rectangle_);
		}
		rectangle_ = method_31(rectangle_);
		if (bool_27 && !size_5.IsEmpty)
		{
			method_20(p, rectangle_);
		}
		Graphics graphics = p.Graphics;
		if (int_6 >= 0)
		{
			Struct19 @struct = method_27();
			Struct19 struct2 = method_26();
			for (int i = 0; i < 5; i++)
			{
				if (struct20_0[i].bool_0)
				{
					graphics.DrawImage(@struct.image_0, struct20_0[i].rectangle_0, @struct.rectangle_0, (GraphicsUnit)2);
				}
				else
				{
					graphics.DrawImage(struct2.image_0, struct20_0[i].rectangle_0, struct2.rectangle_0, (GraphicsUnit)2);
				}
			}
		}
		else if (double_0 > 0.0 && int_5 == 0)
		{
			Struct19 struct3 = method_23();
			Struct19 struct4 = method_25();
			for (int j = 0; j < 5; j++)
			{
				if ((double)(j + 1) <= double_0)
				{
					graphics.DrawImage(struct3.image_0, struct20_0[j].rectangle_0, struct3.rectangle_0, (GraphicsUnit)2);
				}
				else if ((double)(j + 1) == Math.Ceiling(double_0))
				{
					int num = (int)((double)((RatingOrientation == eOrientation.Horizontal) ? struct20_0[j].rectangle_0.Width : struct20_0[j].rectangle_0.Height) * (double_0 - Math.Floor(double_0)));
					graphics.DrawImage(struct4.image_0, struct20_0[j].rectangle_0, struct4.rectangle_0, (GraphicsUnit)2);
					if (num > 0)
					{
						Region clip = graphics.get_Clip();
						if (RatingOrientation == eOrientation.Horizontal)
						{
							graphics.SetClip(new Rectangle(struct20_0[j].rectangle_0.X, struct20_0[j].rectangle_0.Y, num, struct20_0[j].rectangle_0.Height), (CombineMode)1);
						}
						else
						{
							graphics.SetClip(new Rectangle(struct20_0[j].rectangle_0.X + (struct20_0[j].rectangle_0.Height - num), struct20_0[j].rectangle_0.Y, struct20_0[j].rectangle_0.Width, num), (CombineMode)1);
						}
						graphics.DrawImage(struct3.image_0, struct20_0[j].rectangle_0, struct3.rectangle_0, (GraphicsUnit)2);
						graphics.set_Clip(clip);
					}
				}
				else
				{
					graphics.DrawImage(struct4.image_0, struct20_0[j].rectangle_0, struct4.rectangle_0, (GraphicsUnit)2);
				}
			}
		}
		else
		{
			Struct19 struct5 = method_24();
			Struct19 struct6 = method_25();
			for (int k = 0; k < 5; k++)
			{
				if (int_5 > 0 && k + 1 <= int_5)
				{
					graphics.DrawImage(struct5.image_0, struct20_0[k].rectangle_0, struct5.rectangle_0, (GraphicsUnit)2);
				}
				else
				{
					graphics.DrawImage(struct6.image_0, struct20_0[k].rectangle_0, struct6.rectangle_0, (GraphicsUnit)2);
				}
			}
		}
		if (Focused && DesignMode)
		{
			Rectangle displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-1, -1);
			Class32.smethod_0(graphics, displayRectangle, p.Colors.ItemDesignTimeBorder);
		}
	}

	private void method_20(ItemPaintArgs itemPaintArgs_0, Rectangle rectangle_0)
	{
		Color empty = Color.Empty;
		empty = (color_0.IsEmpty ? method_21(itemPaintArgs_0) : color_0);
		bool rightToLeft = itemPaintArgs_0.RightToLeft;
		Rectangle rectangle = rectangle_0;
		if ((elementStyle_0.TextAlignment == eStyleTextAlignment.Far && !rightToLeft) || (rightToLeft && elementStyle_0.TextAlignment == eStyleTextAlignment.Near))
		{
			rectangle.X = rectangle.Right - size_5.Width;
			rectangle.Width = size_5.Width;
		}
		else
		{
			rectangle.Width = size_5.Width;
		}
		Graphics graphics = itemPaintArgs_0.Graphics;
		Font font = itemPaintArgs_0.Font;
		eTextFormat eTextFormat_ = elementStyle_0.ETextFormat_0;
		if (!bool_27 || !(Text != "") || rectangle.IsEmpty || empty.IsEmpty)
		{
			return;
		}
		if (base.Class261_0 != null)
		{
			Class263 @class = new Class263(graphics, font, empty, rightToLeft);
			@class.bool_3 = (eTextFormat_ & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
			if ((eTextFormat_ & eTextFormat.VerticalCenter) == eTextFormat.VerticalCenter)
			{
				rectangle.Y = TopInternal + (Bounds.Height - rectangle.Height) / 2;
			}
			else if ((eTextFormat_ & eTextFormat.Bottom) == eTextFormat.Bottom)
			{
				rectangle.Y += Bounds.Height - rectangle.Height + 1;
			}
			base.Class261_0.Bounds = rectangle;
			base.Class261_0.Render(@class);
		}
		else if (itemPaintArgs_0.GlassEnabled && Parent is Class181)
		{
			if (!itemPaintArgs_0.bool_0)
			{
				Class169.smethod_0(graphics, Text, font, rectangle, Class55.smethod_12(eTextFormat_));
			}
		}
		else
		{
			Class55.smethod_1(graphics, Text, font, empty, rectangle, eTextFormat_);
		}
	}

	private Color method_21(ItemPaintArgs itemPaintArgs_0)
	{
		if (Style == eDotNetBarStyle.Office2007 && itemPaintArgs_0.BaseRenderer_0 is Office2007Renderer)
		{
			if ((itemPaintArgs_0.IsOnMenu || itemPaintArgs_0.IsOnPopupBar) && ((Office2007Renderer)itemPaintArgs_0.BaseRenderer_0).ColorTable.ButtonItemColors.Count > 0)
			{
				if (!method_1(itemPaintArgs_0.ContainerControl))
				{
					return itemPaintArgs_0.Colors.ItemDisabledText;
				}
				return ((Office2007Renderer)itemPaintArgs_0.BaseRenderer_0).ColorTable.ButtonItemColors[0].Default.Text;
			}
			if ((itemPaintArgs_0.ContainerControl is RibbonStrip || itemPaintArgs_0.ContainerControl is Bar) && ((Office2007Renderer)itemPaintArgs_0.BaseRenderer_0).ColorTable.RibbonTabItemColors.Count > 0)
			{
				return ((Office2007Renderer)itemPaintArgs_0.BaseRenderer_0).ColorTable.RibbonTabItemColors[0].Default.Text;
			}
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = ((Office2007Renderer)itemPaintArgs_0.BaseRenderer_0).ColorTable.ButtonItemColors[Enum.GetName(typeof(eButtonColor), eButtonColor.Orange)];
			if (office2007ButtonItemColorTable != null && !office2007ButtonItemColorTable.Default.Text.IsEmpty)
			{
				if (!method_1(itemPaintArgs_0.ContainerControl))
				{
					return itemPaintArgs_0.Colors.ItemDisabledText;
				}
				return office2007ButtonItemColorTable.Default.Text;
			}
			return color_0;
		}
		return itemPaintArgs_0.Colors.ItemText;
	}

	private void method_22(ItemPaintArgs itemPaintArgs_0, ref Rectangle rectangle_0)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		bool flag = base.IsOnMenu && !(Parent is ItemContainer);
		Size size = method_33();
		if (flag && (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style)))
		{
			Graphics graphics = itemPaintArgs_0.Graphics;
			size.Width += 7;
			rectangle_0.Width -= size.Width + int_7;
			if (!itemPaintArgs_0.RightToLeft)
			{
				rectangle_0.X += size.Width + int_7;
			}
			if (base.IsOnCustomizeMenu)
			{
				size.Width += size.Height + 8;
			}
			Rectangle rectangle = new Rectangle(m_Rect.Left, m_Rect.Top, size.Width, m_Rect.Height);
			if (itemPaintArgs_0.RightToLeft)
			{
				rectangle.X = m_Rect.Right - rectangle.Width;
			}
			if (!itemPaintArgs_0.Colors.MenuSide2.IsEmpty)
			{
				LinearGradientBrush val = Class109.smethod_40(rectangle, itemPaintArgs_0.Colors.MenuSide, itemPaintArgs_0.Colors.MenuSide2, itemPaintArgs_0.Colors.MenuSideGradientAngle);
				graphics.FillRectangle((Brush)(object)val, rectangle);
				((Brush)val).Dispose();
			}
			else
			{
				graphics.FillRectangle((Brush)new SolidBrush(itemPaintArgs_0.Colors.MenuSide), rectangle);
			}
			if (Class109.smethod_69(Style) && GlobalManager.Renderer is Office2007Renderer)
			{
				Office2007MenuColorTable menu = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.Menu;
				if (menu != null && !menu.SideBorder.IsEmpty)
				{
					if (itemPaintArgs_0.RightToLeft)
					{
						Class50.smethod_42(graphics, rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom - 1, menu.SideBorder, 1);
					}
					else
					{
						Class50.smethod_42(graphics, rectangle.Right - 2, rectangle.Y, rectangle.Right - 2, rectangle.Bottom - 1, menu.SideBorder, 1);
					}
				}
				if (menu != null && !menu.SideBorderLight.IsEmpty)
				{
					if (itemPaintArgs_0.RightToLeft)
					{
						Class50.smethod_42(graphics, rectangle.X + 1, rectangle.Y, rectangle.X + 1, rectangle.Bottom - 1, menu.SideBorderLight, 1);
					}
					else
					{
						Class50.smethod_42(graphics, rectangle.Right - 1, rectangle.Y, rectangle.Right - 1, rectangle.Bottom - 1, menu.SideBorderLight, 1);
					}
				}
			}
		}
		if (base.IsOnCustomizeMenu)
		{
			if (Style != 0 && Style != eDotNetBarStyle.Office2003 && Style != eDotNetBarStyle.VS2005 && !Class109.smethod_69(Style))
			{
				rectangle_0.X += size.Height + 4;
				rectangle_0.Width -= size.Height + 4;
			}
			else
			{
				rectangle_0.X += size.Height + 8;
				rectangle_0.Width -= size.Height + 8;
			}
		}
	}

	private Struct19 method_23()
	{
		if (ratingImages_0.AverageRated != null)
		{
			return new Struct19(ratingImages_0.AverageRated, new Rectangle(Point.Empty, ratingImages_0.AverageRated.get_Size()));
		}
		method_28();
		return new Struct19(image_0, new Rectangle(0, 52, size_4.Width, size_4.Height));
	}

	private Struct19 method_24()
	{
		if (ratingImages_0.Rated != null)
		{
			return new Struct19(ratingImages_0.Rated, new Rectangle(Point.Empty, ratingImages_0.Rated.get_Size()));
		}
		method_28();
		return new Struct19(image_0, new Rectangle(0, 26, size_4.Width, size_4.Height));
	}

	private Struct19 method_25()
	{
		if (ratingImages_0.Unrated != null)
		{
			return new Struct19(ratingImages_0.Unrated, new Rectangle(Point.Empty, ratingImages_0.Unrated.get_Size()));
		}
		method_28();
		return new Struct19(image_0, new Rectangle(0, 0, size_4.Width, size_4.Height));
	}

	private Struct19 method_26()
	{
		if (ratingImages_0.UnratedMouseOver != null)
		{
			return new Struct19(ratingImages_0.UnratedMouseOver, new Rectangle(Point.Empty, ratingImages_0.UnratedMouseOver.get_Size()));
		}
		method_28();
		return new Struct19(image_0, new Rectangle(0, 13, size_4.Width, size_4.Height));
	}

	private Struct19 method_27()
	{
		if (ratingImages_0.RatedMouseOver != null)
		{
			return new Struct19(ratingImages_0.RatedMouseOver, new Rectangle(Point.Empty, ratingImages_0.RatedMouseOver.get_Size()));
		}
		method_28();
		return new Struct19(image_0, new Rectangle(0, 39, size_4.Width, size_4.Height));
	}

	private void method_28()
	{
		if (image_0 == null)
		{
			image_0 = (Image)(object)Class109.smethod_67("SystemImages.Rating.png");
		}
	}

	public override void InternalMouseMove(MouseEventArgs e)
	{
		if (bool_25)
		{
			int int_ = -1;
			if (RatingOrientation == eOrientation.Horizontal)
			{
				for (int i = 0; i < 5; i++)
				{
					if (e.get_X() >= struct20_0[i].rectangle_0.X && e.get_X() <= struct20_0[i].rectangle_0.Right)
					{
						int_ = i;
						break;
					}
				}
			}
			else
			{
				for (int j = 0; j < 5; j++)
				{
					if ((e.get_Y() >= struct20_0[j].rectangle_0.Y && e.get_Y() <= struct20_0[j].rectangle_0.Bottom && (!bool_27 || size_5.IsEmpty)) || struct20_0[j].rectangle_0.Contains(e.get_X(), e.get_Y()))
					{
						int_ = j;
						break;
					}
				}
			}
			method_29(int_);
		}
		else
		{
			method_29(-1);
		}
		base.InternalMouseMove(e);
	}

	public override void InternalClick(MouseButtons buttons, Point position)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (int_6 >= 0)
		{
			SetRating(int_6 + 1, eEventSource.Mouse);
		}
		base.InternalClick(buttons, position);
	}

	private void method_29(int int_9)
	{
		if (int_9 != int_6)
		{
			int_6 = int_9;
			for (int i = 0; i < 5; i++)
			{
				struct20_0[i].bool_0 = int_9 >= 0 && i <= int_9;
			}
			Refresh();
		}
	}

	public override void InternalMouseLeave()
	{
		if (bool_25)
		{
			method_29(-1);
		}
		base.InternalMouseLeave();
	}

	private Rectangle method_30()
	{
		return method_31(DisplayRectangle);
	}

	private Rectangle method_31(Rectangle rectangle_0)
	{
		rectangle_0.X += Class52.smethod_3(elementStyle_0);
		rectangle_0.Y += Class52.smethod_7(elementStyle_0);
		rectangle_0.Width -= Class52.smethod_1(elementStyle_0);
		rectangle_0.Height -= Class52.smethod_2(elementStyle_0);
		return rectangle_0;
	}

	private void method_32()
	{
		Rectangle rectangle = method_30();
		if (bool_27 && !size_5.IsEmpty && ((elementStyle_0.TextAlignment == eStyleTextAlignment.Far && IsRightToLeft) || (!IsRightToLeft && elementStyle_0.TextAlignment == eStyleTextAlignment.Near)))
		{
			rectangle.X += int_8 + size_5.Width + (bool_26 ? int_7 : 0);
		}
		if (bool_26 && ((elementStyle_0.TextAlignment == eStyleTextAlignment.Far && IsRightToLeft) || (!IsRightToLeft && elementStyle_0.TextAlignment == eStyleTextAlignment.Near)))
		{
			Size size = method_33();
			rectangle.X += size.Width + 7;
			if (base.IsOnCustomizeMenu)
			{
				rectangle.X += rectangle.Height + 2;
			}
		}
		Size size2 = Class50.smethod_48(size_4, ratingImages_0.Size_0);
		if (rectangle.Height > size2.Height && RatingOrientation == eOrientation.Horizontal)
		{
			rectangle.Y += (rectangle.Height - size2.Height) / 2;
		}
		if (RatingOrientation == eOrientation.Horizontal)
		{
			Point location = rectangle.Location;
			for (int i = 0; i < 5; i++)
			{
				struct20_0[i].rectangle_0 = new Rectangle(location, size2);
				location.X += size2.Width;
			}
		}
		else
		{
			Point location2 = new Point(rectangle.X, rectangle.Bottom - size2.Height);
			for (int j = 0; j < 5; j++)
			{
				struct20_0[j].rectangle_0 = new Rectangle(location2, size2);
				location2.Y -= size2.Height;
			}
		}
	}

	public override void RecalcSize()
	{
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		Rectangle displayRectangle = DisplayRectangle;
		Size size = Class50.smethod_48(size_4, ratingImages_0.Size_0);
		if (RatingOrientation == eOrientation.Horizontal)
		{
			size.Width *= 5;
		}
		else
		{
			size.Height *= 5;
		}
		size.Width += Class52.smethod_1(elementStyle_0);
		size.Height += Class52.smethod_2(elementStyle_0);
		bool_26 = false;
		if (base.IsOnMenu && !(Parent is ItemContainer) && (Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style)))
		{
			Size size2 = method_33();
			size.Width += size2.Width + 7;
			if (base.IsOnCustomizeMenu)
			{
				size.Width += size.Height + 2;
			}
			size.Width += int_7;
			bool_26 = true;
		}
		size_5 = Size.Empty;
		if (bool_27)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val == null || val.get_Disposing() || val.get_IsDisposed())
			{
				return;
			}
			Graphics val2 = Class109.smethod_68(val);
			if (val2 == null)
			{
				return;
			}
			try
			{
				Size size3 = Class88.smethod_1(this, val2, 0, val.get_Font(), eTextFormat.Default, (int)val.get_RightToLeft() == 1);
				size3.Width++;
				size.Width += int_8 + size3.Width;
				size.Height = Math.Max(size.Height, size3.Height);
				size_5 = size3;
			}
			finally
			{
				val2.Dispose();
			}
		}
		displayRectangle.Size = size;
		m_Rect = displayRectangle;
		method_32();
		base.RecalcSize();
	}

	private Size method_33()
	{
		if (m_Parent != null)
		{
			if (m_Parent is ImageItem imageItem)
			{
				return imageItem.SubItemsImageSize;
			}
			return ImageSize;
		}
		return ImageSize;
	}

	protected override void OnLeftLocationChanged(int oldValue)
	{
		method_32();
		base.OnLeftLocationChanged(oldValue);
	}

	protected override void OnTopLocationChanged(int oldValue)
	{
		method_32();
		base.OnTopLocationChanged(oldValue);
	}

	protected override void OnExternalSizeChange()
	{
		method_32();
		base.OnExternalSizeChange();
	}

	protected virtual void PaintBackground(ItemPaintArgs p)
	{
		elementStyle_0.method_4(p.Colors);
		Graphics graphics = p.Graphics;
		ElementStyleDisplay.Paint(new ElementStyleDisplayInfo(elementStyle_0, graphics, DisplayRectangle));
	}

	internal void method_34(ElementStyle elementStyle_1)
	{
		elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		elementStyle_0 = elementStyle_1;
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		NeedRecalcSize = true;
		OnAppearanceChanged();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}

	protected override void TextMarkupLinkClick(object sender, EventArgs e)
	{
		if (sender is Class262 @class)
		{
			OnMarkupLinkClick(new MarkupLinkClickEventArgs(@class.String_1, @class.String_0));
		}
		base.TextMarkupLinkClick(sender, e);
	}

	protected virtual void OnMarkupLinkClick(MarkupLinkClickEventArgs e)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(this, e);
		}
	}
}

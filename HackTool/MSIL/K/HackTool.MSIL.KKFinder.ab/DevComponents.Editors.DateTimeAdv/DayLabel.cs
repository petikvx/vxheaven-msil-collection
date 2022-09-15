using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.Editors.DateTimeAdv;

public class DayLabel : PopupItem
{
	private ElementStyle elementStyle_0 = new ElementStyle();

	private Rectangle rectangle_0 = Rectangle.Empty;

	private DayPaintEventHandler dayPaintEventHandler_0;

	private DateTime dateTime_0 = DateTime.MinValue;

	private bool bool_25;

	private bool bool_26;

	private bool bool_27;

	private bool bool_28;

	private bool bool_29;

	private bool bool_30;

	private bool bool_31 = true;

	private bool bool_32 = true;

	private Color color_0 = Color.Empty;

	private bool bool_33;

	private eLabelPartAlignment eLabelPartAlignment_0 = eLabelPartAlignment.MiddleCenter;

	private eLabelPartAlignment eLabelPartAlignment_1 = eLabelPartAlignment.MiddleRight;

	private Image image_0;

	private bool bool_34;

	private bool bool_35;

	private bool bool_36;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DateTime Date
	{
		get
		{
			return dateTime_0;
		}
		set
		{
			if (dateTime_0 != value)
			{
				dateTime_0 = value;
			}
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	public bool IsDayLabel
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
				Refresh();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	public bool IsWeekOfYear
	{
		get
		{
			return bool_26;
		}
		set
		{
			if (bool_26 != value)
			{
				bool_26 = value;
				Refresh();
			}
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	public bool IsTrailing
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
				Refresh();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool IsMouseOver
	{
		get
		{
			return bool_28;
		}
		set
		{
			bool_28 = value;
			Refresh();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool IsMouseDown
	{
		get
		{
			return bool_29;
		}
		set
		{
			bool_29 = value;
			Refresh();
		}
	}

	[Category("Style")]
	[Browsable(true)]
	[Description("Gets or sets container background style.")]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ElementStyle BackgroundStyle => elementStyle_0;

	[DefaultValue(false)]
	[Browsable(false)]
	public bool IsSelected
	{
		get
		{
			return bool_30;
		}
		set
		{
			if (bool_30 != value)
			{
				bool_30 = value;
				Refresh();
			}
		}
	}

	[Description("Indicates whether label provides visual indicator when mouse is over the label or pressed while over the label.")]
	[DefaultValue(true)]
	public bool TrackMouse
	{
		get
		{
			return bool_31;
		}
		set
		{
			if (bool_31 != value)
			{
				bool_31 = value;
				Refresh();
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether label is selectable.")]
	public bool Selectable
	{
		get
		{
			return bool_32;
		}
		set
		{
			if (bool_32 != value)
			{
				bool_32 = value;
				Refresh();
			}
		}
	}

	[Description("Indicates label text color.")]
	[Category("Colors")]
	public Color TextColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			Refresh();
		}
	}

	[Description("Indicates whether text is drawn using Bold font.")]
	[DefaultValue(false)]
	public bool IsBold
	{
		get
		{
			return bool_33;
		}
		set
		{
			if (bool_33 != value)
			{
				bool_33 = value;
				Refresh();
			}
		}
	}

	[DefaultValue(eLabelPartAlignment.MiddleCenter)]
	[Description("Indicates text alignment.")]
	public eLabelPartAlignment TextAlign
	{
		get
		{
			return eLabelPartAlignment_0;
		}
		set
		{
			if (eLabelPartAlignment_0 != value)
			{
				eLabelPartAlignment_0 = value;
				Refresh();
			}
		}
	}

	[Description("Indicates image alignment.")]
	[DefaultValue(eLabelPartAlignment.MiddleRight)]
	public eLabelPartAlignment ImageAlign
	{
		get
		{
			return eLabelPartAlignment_1;
		}
		set
		{
			if (eLabelPartAlignment_1 != value)
			{
				eLabelPartAlignment_1 = value;
				Refresh();
			}
		}
	}

	[DefaultValue(null)]
	[Description("Indicates image displayed on the label.")]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			if (image_0 != value)
			{
				image_0 = value;
				rectangle_0 = Rectangle.Empty;
				Refresh();
			}
		}
	}

	[DefaultValue(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool FlatOffice2007Style
	{
		get
		{
			return bool_34;
		}
		set
		{
			bool_34 = value;
			Refresh();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool IsToday
	{
		get
		{
			return bool_35;
		}
		set
		{
			if (bool_35 != value)
			{
				bool_35 = value;
				Refresh();
			}
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether popup is displayed when mouse is pressed anywhere over the item.")]
	public bool ExpandOnMouseDown
	{
		get
		{
			return bool_36;
		}
		set
		{
			if (bool_36 != value)
			{
				bool_36 = value;
			}
		}
	}

	public event DayPaintEventHandler PaintLabel
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dayPaintEventHandler_0 = (DayPaintEventHandler)Delegate.Combine(dayPaintEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dayPaintEventHandler_0 = (DayPaintEventHandler)Delegate.Remove(dayPaintEventHandler_0, value);
		}
	}

	public DayLabel()
	{
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		bool_15 = true;
	}

	public override void Paint(ItemPaintArgs p)
	{
		DayPaintEventArgs dayPaintEventArgs = new DayPaintEventArgs(p, this);
		OnPaintLabel(dayPaintEventArgs);
		if (dayPaintEventArgs.RenderParts == eDayPaintParts.None)
		{
			return;
		}
		if (Parent is SingleMonthCalendar singleMonthCalendar)
		{
			singleMonthCalendar.method_41(this, dayPaintEventArgs);
		}
		if (dayPaintEventArgs.RenderParts != 0)
		{
			if (Enabled && (dayPaintEventArgs.RenderParts & eDayPaintParts.Background) == eDayPaintParts.Background)
			{
				method_20(p);
			}
			if ((dayPaintEventArgs.RenderParts & eDayPaintParts.Text) == eDayPaintParts.Text)
			{
				method_21(p, null, Color.Empty, eLabelPartAlignment_0);
			}
			if ((dayPaintEventArgs.RenderParts & eDayPaintParts.Image) == eDayPaintParts.Image)
			{
				method_18(p, image_0, eLabelPartAlignment_1);
			}
		}
	}

	internal void method_18(ItemPaintArgs itemPaintArgs_0, Image image_1, eLabelPartAlignment eLabelPartAlignment_2)
	{
		if (image_1 != null)
		{
			Graphics graphics = itemPaintArgs_0.Graphics;
			Rectangle rectangle = method_19(DisplayRectangle, image_1.get_Size(), eLabelPartAlignment_2);
			Class271 @class = new Class271(image_1, dispose: false);
			@class.method_0(graphics, rectangle);
			@class.Dispose();
			rectangle_0 = rectangle;
		}
	}

	private Rectangle method_19(Rectangle rectangle_1, Size size_4, eLabelPartAlignment eLabelPartAlignment_2)
	{
		Rectangle result = new Rectangle(rectangle_1.Right - size_4.Width, rectangle_1.Y, size_4.Width, size_4.Height);
		switch (eLabelPartAlignment_2)
		{
		case eLabelPartAlignment.BottomCenter:
			result.Location = new Point(rectangle_1.X + (rectangle_1.Width - size_4.Width) / 2, rectangle_1.Bottom - size_4.Height);
			break;
		case eLabelPartAlignment.BottomLeft:
			result.Location = new Point(rectangle_1.X, rectangle_1.Bottom - size_4.Height);
			break;
		case eLabelPartAlignment.BottomRight:
			result.Location = new Point(rectangle_1.Right - size_4.Width, rectangle_1.Bottom - size_4.Height);
			break;
		case eLabelPartAlignment.MiddleCenter:
			result.Location = new Point(rectangle_1.X + (rectangle_1.Width - size_4.Width) / 2, rectangle_1.Y + (rectangle_1.Height - size_4.Height) / 2);
			break;
		case eLabelPartAlignment.MiddleLeft:
			result.Location = new Point(rectangle_1.X, rectangle_1.Y + (rectangle_1.Height - size_4.Height) / 2);
			break;
		case eLabelPartAlignment.MiddleRight:
			result.Location = new Point(rectangle_1.Right - size_4.Width, rectangle_1.Y + (rectangle_1.Height - size_4.Height) / 2);
			break;
		case eLabelPartAlignment.TopCenter:
			result.Location = new Point(rectangle_1.X + (rectangle_1.Width - size_4.Width) / 2, rectangle_1.Y);
			break;
		case eLabelPartAlignment.TopLeft:
			result.Location = new Point(rectangle_1.X, rectangle_1.Y);
			break;
		}
		return result;
	}

	protected virtual void OnPaintLabel(DayPaintEventArgs e)
	{
		if (dayPaintEventHandler_0 != null)
		{
			dayPaintEventHandler_0(this, e);
		}
	}

	internal void method_20(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = itemPaintArgs_0.Graphics;
		Rectangle displayRectangle = DisplayRectangle;
		Color color = Color.Empty;
		Color color_ = Color.Empty;
		Color color2 = Color.Empty;
		if (elementStyle_0.Custom && ((!IsMouseOver && !IsMouseDown) || !bool_31))
		{
			elementStyle_0.method_4(itemPaintArgs_0.Colors);
			ElementStyle style = ElementStyleDisplay.smethod_5(elementStyle_0);
			ElementStyleDisplay.Paint(new ElementStyleDisplayInfo(style, graphics, displayRectangle));
		}
		bool flag = false;
		SingleMonthCalendar singleMonthCalendar = Parent as SingleMonthCalendar;
		MonthCalendarColors monthCalendarColors = null;
		if (singleMonthCalendar != null)
		{
			monthCalendarColors = singleMonthCalendar.method_30();
		}
		if (IsMouseDown && bool_31)
		{
			color = itemPaintArgs_0.Colors.ItemPressedBackground;
			color_ = itemPaintArgs_0.Colors.ItemPressedBackground2;
			color2 = itemPaintArgs_0.Colors.ItemPressedBorder;
		}
		else if (IsMouseOver && bool_31)
		{
			color = itemPaintArgs_0.Colors.ItemHotBackground;
			color_ = itemPaintArgs_0.Colors.ItemHotBackground2;
			color2 = itemPaintArgs_0.Colors.ItemHotBorder;
		}
		else if (IsSelected)
		{
			color = itemPaintArgs_0.Colors.ItemCheckedBackground;
			if (monthCalendarColors != null && monthCalendarColors.Selection.IsCustomized)
			{
				if (!monthCalendarColors.Selection.BackColor.IsEmpty)
				{
					color = monthCalendarColors.Selection.BackColor;
					if (!monthCalendarColors.Selection.BackColor2.IsEmpty)
					{
						color_ = monthCalendarColors.Selection.BackColor2;
					}
				}
				if (!monthCalendarColors.Selection.BorderColor.IsEmpty)
				{
					color2 = monthCalendarColors.Selection.BorderColor;
				}
				flag = true;
			}
		}
		else if (bool_35)
		{
			color2 = itemPaintArgs_0.Colors.ItemCheckedBorder;
			if (monthCalendarColors != null && monthCalendarColors.Today.IsCustomized)
			{
				if (!monthCalendarColors.Today.BorderColor.IsEmpty)
				{
					color2 = monthCalendarColors.Today.BorderColor;
				}
				if (!monthCalendarColors.Today.BackColor.IsEmpty)
				{
					color = monthCalendarColors.Today.BackColor;
					if (!monthCalendarColors.Today.BackColor2.IsEmpty)
					{
						color_ = monthCalendarColors.Today.BackColor2;
					}
				}
				flag = true;
			}
		}
		else if (IsWeekOfYear)
		{
			color = Color.LightGray;
			if (monthCalendarColors != null && monthCalendarColors.WeekOfYear.IsCustomized)
			{
				if (!monthCalendarColors.WeekOfYear.BorderColor.IsEmpty)
				{
					color2 = monthCalendarColors.WeekOfYear.BorderColor;
				}
				if (!monthCalendarColors.WeekOfYear.BackColor.IsEmpty)
				{
					color = monthCalendarColors.WeekOfYear.BackColor;
					if (!monthCalendarColors.WeekOfYear.BackColor2.IsEmpty)
					{
						color_ = monthCalendarColors.WeekOfYear.BackColor2;
					}
				}
				flag = true;
			}
		}
		else if (IsTrailing)
		{
			if (monthCalendarColors != null && monthCalendarColors.TrailingDay.IsCustomized)
			{
				if (!monthCalendarColors.TrailingDay.BackColor.IsEmpty)
				{
					color = monthCalendarColors.TrailingDay.BackColor;
					if (!monthCalendarColors.TrailingDay.BackColor2.IsEmpty)
					{
						color_ = monthCalendarColors.TrailingDay.BackColor2;
					}
				}
				if (!monthCalendarColors.TrailingDay.BorderColor.IsEmpty)
				{
					color2 = monthCalendarColors.TrailingDay.BorderColor;
				}
				flag = true;
			}
			if (smethod_0(Date) && monthCalendarColors != null && monthCalendarColors.TrailingWeekend.IsCustomized)
			{
				if (!monthCalendarColors.TrailingWeekend.BackColor.IsEmpty)
				{
					color = monthCalendarColors.TrailingWeekend.BackColor;
					if (!monthCalendarColors.TrailingWeekend.BackColor2.IsEmpty)
					{
						color_ = monthCalendarColors.TrailingWeekend.BackColor2;
					}
				}
				if (!monthCalendarColors.TrailingWeekend.BorderColor.IsEmpty)
				{
					color2 = monthCalendarColors.TrailingWeekend.BorderColor;
				}
				flag = true;
			}
		}
		else if (IsDayLabel)
		{
			if (monthCalendarColors != null && monthCalendarColors.DayLabel.IsCustomized)
			{
				if (!monthCalendarColors.DayLabel.BackColor.IsEmpty)
				{
					color = monthCalendarColors.DayLabel.BackColor;
					if (!monthCalendarColors.DayLabel.BackColor2.IsEmpty)
					{
						color_ = monthCalendarColors.DayLabel.BackColor2;
					}
				}
				if (!monthCalendarColors.DayLabel.BorderColor.IsEmpty)
				{
					color2 = monthCalendarColors.DayLabel.BorderColor;
				}
				flag = true;
			}
		}
		else if (Date != DateTime.MinValue)
		{
			if (monthCalendarColors != null && monthCalendarColors.Day.IsCustomized)
			{
				if (!monthCalendarColors.Day.BackColor.IsEmpty)
				{
					color = monthCalendarColors.Day.BackColor;
					if (!monthCalendarColors.Day.BackColor2.IsEmpty)
					{
						color_ = monthCalendarColors.Day.BackColor2;
					}
				}
				if (!monthCalendarColors.Day.BorderColor.IsEmpty)
				{
					color2 = monthCalendarColors.Day.BorderColor;
				}
				flag = true;
			}
			if (smethod_0(Date) && monthCalendarColors != null && monthCalendarColors.Weekend.IsCustomized)
			{
				if (!monthCalendarColors.Weekend.BackColor.IsEmpty)
				{
					color = monthCalendarColors.Weekend.BackColor;
					if (!monthCalendarColors.Weekend.BackColor2.IsEmpty)
					{
						color_ = monthCalendarColors.Weekend.BackColor2;
					}
				}
				if (!monthCalendarColors.Weekend.BorderColor.IsEmpty)
				{
					color2 = monthCalendarColors.Weekend.BorderColor;
				}
				flag = true;
			}
		}
		if (Style == eDotNetBarStyle.Office2007 && !FlatOffice2007Style && !flag)
		{
			Office2007ButtonItemStateColorTable office2007StateColorTable = GetOffice2007StateColorTable(itemPaintArgs_0);
			if (office2007StateColorTable != null)
			{
				Class268.smethod_4(graphics, office2007StateColorTable, displayRectangle, RoundRectangleShapeDescriptor.RectangleShape);
				color = Color.Empty;
				color_ = Color.Empty;
				color2 = Color.Empty;
			}
		}
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)3);
		if (!color.IsEmpty)
		{
			Class50.smethod_24(graphics, displayRectangle, color, color_);
		}
		if (!color2.IsEmpty)
		{
			Class50.smethod_6(graphics, color2, displayRectangle);
		}
		if (IsDayLabel)
		{
			color2 = itemPaintArgs_0.Colors.BarDockedBorder;
			if (monthCalendarColors != null && !monthCalendarColors.DaysDividerBorderColors.IsEmpty)
			{
				color2 = monthCalendarColors.DaysDividerBorderColors;
			}
			if (!color2.IsEmpty)
			{
				Class50.smethod_32(graphics, displayRectangle.X, displayRectangle.Bottom - 1, displayRectangle.Right, displayRectangle.Bottom - 1, color2, 1);
			}
		}
		graphics.set_SmoothingMode(smoothingMode);
	}

	protected Office2007ButtonItemStateColorTable GetOffice2007StateColorTable(ItemPaintArgs p)
	{
		if (Style == eDotNetBarStyle.Office2007 && !FlatOffice2007Style && p.BaseRenderer_0 is Office2007Renderer)
		{
			Office2007ColorTable colorTable = ((Office2007Renderer)p.BaseRenderer_0).ColorTable;
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = colorTable.ButtonItemColors[Enum.GetName(typeof(eButtonColor), eButtonColor.Orange)];
			if (!Enabled)
			{
				return office2007ButtonItemColorTable.Disabled;
			}
			if (IsMouseDown && bool_31)
			{
				return office2007ButtonItemColorTable.Pressed;
			}
			if (IsMouseOver && bool_31)
			{
				return office2007ButtonItemColorTable.MouseOver;
			}
			if (IsSelected)
			{
				return office2007ButtonItemColorTable.Checked;
			}
		}
		return null;
	}

	internal static bool smethod_0(DateTime dateTime_1)
	{
		if (dateTime_1.DayOfWeek != DayOfWeek.Saturday)
		{
			return dateTime_1.DayOfWeek == DayOfWeek.Sunday;
		}
		return true;
	}

	internal void method_21(ItemPaintArgs itemPaintArgs_0, Font font_1, Color color_1, eLabelPartAlignment eLabelPartAlignment_2)
	{
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		string text = Text;
		if (dateTime_0 != DateTime.MinValue)
		{
			text = dateTime_0.Day.ToString();
		}
		bool isBold = bool_33;
		if (color_1.IsEmpty)
		{
			if (!color_0.IsEmpty)
			{
				color_1 = color_0;
			}
			else if (!Enabled)
			{
				color_1 = itemPaintArgs_0.Colors.ItemDisabledText;
			}
			else
			{
				color_1 = (bool_27 ? itemPaintArgs_0.Colors.ItemDisabledText : itemPaintArgs_0.Colors.ItemText);
				SingleMonthCalendar singleMonthCalendar = Parent as SingleMonthCalendar;
				MonthCalendarColors monthCalendarColors = null;
				if (singleMonthCalendar != null)
				{
					monthCalendarColors = singleMonthCalendar.method_30();
				}
				if (monthCalendarColors != null)
				{
					if (dateTime_0 != DateTime.MinValue)
					{
						if (bool_30 && monthCalendarColors.Selection.IsCustomized)
						{
							if (!monthCalendarColors.Selection.TextColor.IsEmpty)
							{
								color_1 = monthCalendarColors.Selection.TextColor;
							}
							if (monthCalendarColors.Selection.IsBold)
							{
								isBold = monthCalendarColors.Selection.IsBold;
							}
						}
						else
						{
							if (bool_27)
							{
								if (!monthCalendarColors.TrailingDay.TextColor.IsEmpty)
								{
									color_1 = monthCalendarColors.TrailingDay.TextColor;
								}
								if (monthCalendarColors.TrailingDay.IsBold)
								{
									isBold = monthCalendarColors.TrailingDay.IsBold;
								}
							}
							else if (monthCalendarColors.Day.IsCustomized)
							{
								if (!monthCalendarColors.Day.TextColor.IsEmpty)
								{
									color_1 = monthCalendarColors.Day.TextColor;
								}
								if (monthCalendarColors.Day.IsBold)
								{
									isBold = monthCalendarColors.Day.IsBold;
								}
							}
							if (smethod_0(dateTime_0))
							{
								if (bool_27)
								{
									if (!monthCalendarColors.TrailingWeekend.TextColor.IsEmpty)
									{
										color_1 = monthCalendarColors.TrailingWeekend.TextColor;
									}
									if (monthCalendarColors.TrailingWeekend.IsBold)
									{
										isBold = monthCalendarColors.TrailingWeekend.IsBold;
									}
								}
								else
								{
									if (!monthCalendarColors.Weekend.TextColor.IsEmpty)
									{
										color_1 = monthCalendarColors.Weekend.TextColor;
									}
									if (monthCalendarColors.Weekend.IsBold)
									{
										isBold = monthCalendarColors.TrailingWeekend.IsBold;
									}
								}
							}
						}
					}
					else if (IsWeekOfYear)
					{
						if (monthCalendarColors.WeekOfYear.IsCustomized)
						{
							if (!monthCalendarColors.WeekOfYear.TextColor.IsEmpty)
							{
								color_1 = monthCalendarColors.WeekOfYear.TextColor;
							}
							if (monthCalendarColors.WeekOfYear.IsBold)
							{
								isBold = monthCalendarColors.WeekOfYear.IsBold;
							}
						}
					}
					else if (IsDayLabel)
					{
						if (!monthCalendarColors.DayLabel.TextColor.IsEmpty)
						{
							color_1 = monthCalendarColors.DayLabel.TextColor;
						}
						if (monthCalendarColors.DayLabel.IsBold)
						{
							isBold = monthCalendarColors.DayLabel.IsBold;
						}
					}
				}
			}
		}
		bool flag = false;
		if (font_1 == null)
		{
			if (isBold)
			{
				font_1 = new Font(itemPaintArgs_0.Font, (FontStyle)1);
				flag = true;
			}
			else
			{
				font_1 = itemPaintArgs_0.Font;
			}
		}
		if (dateTime_0 != DateTime.MinValue)
		{
			Size size_ = Class55.smethod_3(graphics, "32", font_1);
			Rectangle rectangle = method_19(DisplayRectangle, size_, eLabelPartAlignment_2);
			Class55.smethod_1(graphics, text, font_1, color_1, rectangle, eTextFormat.Right | eTextFormat.VerticalCenter);
		}
		else
		{
			eTextFormat eTextFormat_ = eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter;
			switch (eLabelPartAlignment_2)
			{
			case eLabelPartAlignment.BottomCenter:
				eTextFormat_ = eTextFormat.Bottom | eTextFormat.HorizontalCenter;
				break;
			case eLabelPartAlignment.BottomLeft:
				eTextFormat_ = eTextFormat.Bottom;
				break;
			case eLabelPartAlignment.BottomRight:
				eTextFormat_ = eTextFormat.Bottom | eTextFormat.Right;
				break;
			case eLabelPartAlignment.MiddleLeft:
				eTextFormat_ = eTextFormat.VerticalCenter;
				break;
			case eLabelPartAlignment.MiddleRight:
				eTextFormat_ = eTextFormat.Right | eTextFormat.VerticalCenter;
				break;
			case eLabelPartAlignment.TopCenter:
				eTextFormat_ = eTextFormat.VerticalCenter;
				break;
			case eLabelPartAlignment.TopLeft:
				eTextFormat_ = eTextFormat.Default;
				break;
			case eLabelPartAlignment.TopRight:
				eTextFormat_ = eTextFormat.Right;
				break;
			}
			Class55.smethod_1(graphics, text, font_1, color_1, Bounds, eTextFormat_);
		}
		if (flag)
		{
			font_1.Dispose();
		}
	}

	public override void RecalcSize()
	{
		Bounds = new Rectangle(Bounds.Location, SingleMonthCalendar.size_3);
		base.RecalcSize();
	}

	public override BaseItem Copy()
	{
		DayLabel dayLabel = new DayLabel();
		CopyToItem(dayLabel);
		return dayLabel;
	}

	protected override void CopyToItem(BaseItem c)
	{
		DayLabel copy = c as DayLabel;
		base.CopyToItem((BaseItem)copy);
	}

	public override void InternalMouseEnter()
	{
		IsMouseOver = true;
		base.InternalMouseEnter();
		if (Parent is SingleMonthCalendar singleMonthCalendar)
		{
			singleMonthCalendar.method_45(this, new EventArgs());
		}
	}

	public override void InternalMouseLeave()
	{
		IsMouseOver = false;
		base.InternalMouseLeave();
		if (Parent is SingleMonthCalendar singleMonthCalendar)
		{
			singleMonthCalendar.method_46(this, new EventArgs());
		}
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)objArg.get_Button() == 1048576)
		{
			IsMouseDown = true;
		}
		if (IsMouseDown && SubItems.Count > 0 && ShowSubItems && (rectangle_0.Contains(objArg.get_X(), objArg.get_Y()) || bool_36))
		{
			Expanded = !Expanded;
		}
		base.InternalMouseDown(objArg);
		if (Parent is SingleMonthCalendar singleMonthCalendar)
		{
			singleMonthCalendar.method_43(this, objArg);
		}
	}

	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)objArg.get_Button() == 1048576)
		{
			IsMouseDown = false;
		}
		base.InternalMouseUp(objArg);
		if (Parent is SingleMonthCalendar singleMonthCalendar)
		{
			singleMonthCalendar.method_44(this, objArg);
		}
	}

	protected override void OnClick()
	{
		if (Parent is SingleMonthCalendar singleMonthCalendar)
		{
			singleMonthCalendar.method_42(this);
		}
		base.OnClick();
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		base.InternalMouseMove(objArg);
		if (Parent is SingleMonthCalendar singleMonthCalendar)
		{
			singleMonthCalendar.method_47(this, objArg);
		}
	}

	public override void InternalMouseHover()
	{
		base.InternalMouseHover();
		if (Parent is SingleMonthCalendar singleMonthCalendar)
		{
			singleMonthCalendar.method_48(this, new EventArgs());
		}
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		OnAppearanceChanged();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		return !TextColor.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}
}

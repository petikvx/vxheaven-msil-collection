using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Events;

namespace DevComponents.Editors.DateTimeAdv;

[ToolboxItem(false)]
[Designer(typeof(ItemContainerDesigner))]
[DesignTimeVisible(false)]
public class SingleMonthCalendar : CalendarBase
{
	private const string string_7 = "monthLabel";

	private const string string_8 = "yearLabel";

	private const string string_9 = "decreaseMonth";

	private const string string_10 = "increaseMonth";

	private const string string_11 = "decreaseYear";

	private const string string_12 = "increaseYear";

	private const string string_13 = "monthsPopupMenu";

	internal static readonly Size size_3 = new Size(24, 15);

	private ButtonItem buttonItem_0;

	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	private DayPaintEventHandler dayPaintEventHandler_0;

	private MouseEventHandler mouseEventHandler_3;

	private MouseEventHandler mouseEventHandler_4;

	private EventHandler eventHandler_16;

	private EventHandler eventHandler_17;

	private MouseEventHandler mouseEventHandler_5;

	private EventHandler eventHandler_18;

	private EventHandler eventHandler_19;

	private DateTime dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

	private DayOfWeek dayOfWeek_0;

	internal bool bool_22 = true;

	internal bool bool_23 = true;

	internal bool bool_24 = true;

	private bool bool_25;

	private CalendarWeekRule calendarWeekRule_0;

	private Size size_4 = size_3;

	private MonthCalendarColors monthCalendarColors_0 = new MonthCalendarColors();

	private bool bool_26;

	private bool bool_27 = true;

	private DateTime dateTime_1 = DateTime.MinValue;

	private bool bool_28 = true;

	private eLabelPartAlignment eLabelPartAlignment_0 = eLabelPartAlignment.MiddleCenter;

	private bool bool_29 = true;

	private string[] string_14;

	private bool bool_30 = true;

	private bool bool_31 = true;

	private DateTime dateTime_2 = DateTime.MinValue;

	private DateTime dateTime_3 = DateTimeGroup.MinDateTime;

	private DateTime dateTime_4 = DateTimeGroup.MaxDateTime;

	private int int_4 = 1;

	[Description("")]
	public DateTime DisplayMonth
	{
		get
		{
			return dateTime_0;
		}
		set
		{
			if (value < MinDate)
			{
				value = MinDate;
			}
			else if (value > MaxDate)
			{
				value = MaxDate;
			}
			method_21(value.Month, value.Year, eEventSource.Code);
		}
	}

	[DefaultValue(DayOfWeek.Sunday)]
	[Description("Indicates first day of week displayed on the calendar.")]
	public DayOfWeek FirstDayOfWeek
	{
		get
		{
			return dayOfWeek_0;
		}
		set
		{
			if (dayOfWeek_0 != value)
			{
				dayOfWeek_0 = value;
				method_21(dateTime_0.Month, dateTime_0.Year, eEventSource.Code);
			}
		}
	}

	[DefaultValue(true)]
	public bool TrailingDaysVisible
	{
		get
		{
			return bool_22;
		}
		set
		{
			if (bool_22 != value)
			{
				bool_22 = value;
				method_38();
			}
		}
	}

	internal bool Boolean_3
	{
		get
		{
			return bool_23;
		}
		set
		{
			if (bool_23 != value)
			{
				bool_23 = value;
				method_38();
			}
		}
	}

	internal bool Boolean_4
	{
		get
		{
			return bool_24;
		}
		set
		{
			if (bool_24 != value)
			{
				bool_24 = value;
				method_38();
			}
		}
	}

	[Description("Indicates whether week of year is visible.")]
	[DefaultValue(false)]
	public bool ShowWeekNumbers
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
				method_39();
				NeedRecalcSize = true;
				OnAppearanceChanged();
			}
		}
	}

	[Description("Indicates rule used to determine first week of the year for week of year display on calendar.")]
	[DefaultValue(CalendarWeekRule.FirstDay)]
	public CalendarWeekRule WeekOfYearRule
	{
		get
		{
			return calendarWeekRule_0;
		}
		set
		{
			calendarWeekRule_0 = value;
			if (bool_25)
			{
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override SubItemsCollection SubItems => base.SubItems;

	[Description("Indicate size of each day item on the calendar.")]
	public Size DaySize
	{
		get
		{
			return size_4;
		}
		set
		{
			size_4 = value;
			method_40();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets colors used by control.")]
	[Category("Appearance")]
	[NotifyParentProperty(true)]
	public MonthCalendarColors Colors => monthCalendarColors_0;

	[DefaultValue(false)]
	[Description("Indicates whether multiple days can be selected by clicking each day.")]
	public bool MultiSelect
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
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether selection of dates using mouse is enabled.")]
	public bool MouseSelectionEnabled
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
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DateTime SelectedDate
	{
		get
		{
			return dateTime_1;
		}
		set
		{
			dateTime_1 = value;
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is DayLabel dayLabel && !(dayLabel.Date == DateTime.MinValue))
				{
					if (dayLabel.Date == dateTime_1)
					{
						dayLabel.IsSelected = true;
					}
					else
					{
						dayLabel.IsSelected = false;
					}
				}
			}
			OnSelectedDateChanged(new EventArgs());
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether weekend days can be selected.")]
	public bool WeekendDaysSelectable
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
				method_21(dateTime_0.Month, dateTime_0.Year, eEventSource.Code);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(false)]
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

	[Description("Indicates default text alignment for the DayLabel items representing calendar days.")]
	[DefaultValue(eLabelPartAlignment.MiddleCenter)]
	public eLabelPartAlignment DefaultDayLabelTextAlign
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
				method_21(dateTime_0.Month, dateTime_0.Year, eEventSource.Code);
				Refresh();
			}
		}
	}

	[Description("Indicates whether control uses the two letter day names.")]
	[DefaultValue(true)]
	public bool TwoLetterDayName
	{
		get
		{
			return bool_29;
		}
		set
		{
			if (bool_29 != value)
			{
				bool_29 = value;
				method_21(dateTime_0.Month, dateTime_0.Year, eEventSource.Code);
				Refresh();
			}
		}
	}

	[DefaultValue(null)]
	[Description("Indicates array of custom names for days displayed on calendar header.")]
	[Localizable(true)]
	public string[] DayNames
	{
		get
		{
			return string_14;
		}
		set
		{
			if (value != null && value.Length != 7)
			{
				throw new ArgumentException("DayNames must have exactly 7 items in collection.");
			}
			string_14 = value;
		}
	}

	[Description("Indicates whether header navigation buttons for month and year are visible.")]
	[DefaultValue(true)]
	public bool HeaderNavigationEnabled
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
				method_54();
			}
		}
	}

	[Description("Indicates navigation container background style.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	public ElementStyle NavigationBackgroundStyle => method_35().BackgroundStyle;

	[DefaultValue(true)]
	[Description("Indicates whether today marker that indicates TodayDate is visible on the calendar.")]
	public bool ShowTodayMarker
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
				method_55();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DateTime TodayDate
	{
		get
		{
			return dateTime_2;
		}
		set
		{
			value = value.Date;
			if (dateTime_2 != value)
			{
				dateTime_2 = value;
				if (bool_31)
				{
					method_55();
				}
			}
		}
	}

	[Browsable(false)]
	public bool TodayDateSet => dateTime_2 != DateTime.MinValue;

	[Description("Indicates minimum date and time that can be selected in the control.")]
	public DateTime MinDate
	{
		get
		{
			return dateTime_3;
		}
		set
		{
			dateTime_3 = value;
		}
	}

	[Description("Indicates maximum date and time that can be selected in the control.")]
	public DateTime MaxDate
	{
		get
		{
			return dateTime_4;
		}
		set
		{
			dateTime_4 = value;
		}
	}

	internal int Int32_1
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
				method_22();
			}
		}
	}

	public event EventHandler MonthChanged
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

	public event EventHandler MonthChanging
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

	[Description("Occurs when mouse button is pressed over the day/week label inside of the calendar.")]
	public event MouseEventHandler LabelMouseDown
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

	[Description("Occurs when mouse button is released over day/week label inside of the calendar.")]
	public event MouseEventHandler LabelMouseUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_4 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_4, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_4 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_4, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when mouse enters the day/week label inside of the calendar.")]
	public event EventHandler LabelMouseEnter
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

	[Description("Occurs when mouse leaves the day/week label inside of the calendar.")]
	public event EventHandler LabelMouseLeave
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

	[Description("Occurs when mouse moves over the day/week label inside of the calendar.")]
	public event MouseEventHandler LabelMouseMove
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_5 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_5, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_5 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_5, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when mouse remains still inside an day/week label of the calendar for an amount of time.")]
	public event EventHandler LabelMouseHover
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

	[Description("Occurs when SelectedDate property has changed.")]
	public event EventHandler DateChanged
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

	public SingleMonthCalendar()
	{
		dayOfWeek_0 = DateTimeInput.GetActiveCulture().DateTimeFormat.FirstDayOfWeek;
		m_IsContainer = true;
		AutoCollapseOnClick = true;
		bool_15 = true;
		AccessibleRole = (AccessibleRole)20;
		monthCalendarColors_0.BaseItem_0 = this;
		for (int i = 0; i < 49; i++)
		{
			DayLabel item = new DayLabel
			{
				Visible = false
			};
			SubItems.Add(item);
		}
		Size fixedSize = new Size(13, 18);
		ItemContainer itemContainer = new ItemContainer
		{
			AutoCollapseOnClick = false,
			MinimumSize = new Size(0, fixedSize.Height),
			LayoutOrientation = eOrientation.Horizontal,
			HorizontalItemAlignment = eHorizontalItemsAlignment.Center,
			VerticalItemAlignment = eVerticalItemsAlignment.Middle,
			ItemSpacing = 2
		};
		ButtonItem buttonItem = new ButtonItem("decreaseMonth");
		buttonItem.GlobalItem = false;
		buttonItem.bool_47 = false;
		buttonItem.Text = "<expand direction=\"left\"/>";
		buttonItem.Click += method_49;
		buttonItem.AutoCollapseOnClick = false;
		buttonItem.FixedSize = fixedSize;
		buttonItem.bool_45 = true;
		buttonItem.ClickAutoRepeat = true;
		itemContainer.SubItems.Add(buttonItem);
		LabelItem labelItem = new LabelItem("monthLabel");
		labelItem.AutoCollapseOnClick = false;
		labelItem.GlobalItem = false;
		labelItem.TextAlignment = (StringAlignment)1;
		labelItem.TextLineAlignment = (StringAlignment)1;
		labelItem.PaddingBottom = 2;
		labelItem.Click += method_18;
		itemContainer.SubItems.Add(labelItem);
		buttonItem = new ButtonItem("increaseMonth");
		buttonItem.GlobalItem = false;
		buttonItem.bool_47 = false;
		buttonItem.Text = "<expand direction=\"right\"/>";
		buttonItem.Click += method_51;
		buttonItem.AutoCollapseOnClick = false;
		buttonItem.FixedSize = fixedSize;
		buttonItem.bool_45 = true;
		buttonItem.ClickAutoRepeat = true;
		itemContainer.SubItems.Add(buttonItem);
		buttonItem = new ButtonItem("decreaseYear");
		buttonItem.GlobalItem = false;
		buttonItem.bool_47 = false;
		buttonItem.Text = "<expand direction=\"left\"/>";
		buttonItem.Click += method_52;
		buttonItem.AutoCollapseOnClick = false;
		buttonItem.FixedSize = fixedSize;
		buttonItem.bool_45 = true;
		buttonItem.ClickAutoRepeat = true;
		itemContainer.SubItems.Add(buttonItem);
		labelItem = new LabelItem("yearLabel")
		{
			AutoCollapseOnClick = false,
			GlobalItem = false,
			TextAlignment = (StringAlignment)1,
			TextLineAlignment = (StringAlignment)1,
			PaddingBottom = 2
		};
		itemContainer.SubItems.Add(labelItem);
		buttonItem = new ButtonItem("increaseYear");
		buttonItem.GlobalItem = false;
		buttonItem.bool_47 = false;
		buttonItem.Text = "<expand direction=\"right\"/>";
		buttonItem.Click += method_53;
		buttonItem.AutoCollapseOnClick = false;
		buttonItem.FixedSize = fixedSize;
		buttonItem.bool_45 = true;
		buttonItem.ClickAutoRepeat = true;
		itemContainer.SubItems.Add(buttonItem);
		buttonItem_0 = new ButtonItem("monthsPopupMenu");
		buttonItem_0.Visible = false;
		itemContainer.SubItems.Add(buttonItem_0);
		SubItems.Add(itemContainer);
	}

	private void method_18(object sender, EventArgs e)
	{
		if (!HeaderNavigationEnabled)
		{
			return;
		}
		ButtonItem buttonItem = buttonItem_0;
		foreach (BaseItem subItem in buttonItem.SubItems)
		{
			subItem.Click -= method_19;
		}
		buttonItem.SubItems.Clear();
		string[] monthNames = DateTimeInput.GetActiveCulture().DateTimeFormat.MonthNames;
		for (int i = 0; i < monthNames.Length; i++)
		{
			if (monthNames[i] != null && monthNames[i].Length != 0)
			{
				ButtonItem buttonItem2 = new ButtonItem((i + 1).ToString(), monthNames[i]);
				buttonItem2.AutoCollapseOnClick = false;
				buttonItem.SubItems.Add(buttonItem2);
				buttonItem2.Click += method_19;
			}
		}
		buttonItem.Popup(Control.get_MousePosition());
	}

	private void method_19(object sender, EventArgs e)
	{
		if (sender is ButtonItem buttonItem)
		{
			int int_ = int.Parse(buttonItem.Name);
			((PopupItem)buttonItem.Parent).Expanded = false;
			method_21(int_, DisplayMonth.Year, eEventSource.Mouse);
		}
	}

	public override void RecalcSize()
	{
		int num = 49;
		int num2 = 0;
		int num3 = 0;
		int num4 = 2;
		Point location = m_Rect.Location;
		ElementStyle elementStyle = ElementStyleDisplay.smethod_5(base.BackgroundStyle);
		location.X += Class52.smethod_3(elementStyle);
		location.Y += Class52.smethod_7(elementStyle);
		Point location2 = location;
		Point point = location;
		if (bool_25)
		{
			point.X += size_4.Width;
		}
		ItemContainer itemContainer = method_35();
		itemContainer.LeftInternal = location.X;
		itemContainer.TopInternal = location.Y;
		itemContainer.WidthInternal = size_4.Width * (bool_25 ? 8 : 7);
		itemContainer.RecalcSize();
		itemContainer.WidthInternal = size_4.Width * (bool_25 ? 8 : 7);
		location2.Y += itemContainer.HeightInternal + 1;
		point.Y += itemContainer.HeightInternal + 1;
		Point location3 = point;
		int num5 = 0;
		for (int i = 0; i < num; i++)
		{
			BaseItem baseItem = SubItems[i];
			if (baseItem is DayLabel dayLabel)
			{
				dayLabel.RecalcSize();
				dayLabel.Bounds = new Rectangle(location3, size_4);
			}
			else
			{
				baseItem.RecalcSize();
			}
			if (baseItem.Visible)
			{
				if (baseItem.HeightInternal > num3)
				{
					num3 = baseItem.HeightInternal;
				}
				location3.X += baseItem.WidthInternal;
			}
			num2++;
			if (num2 != 7)
			{
				continue;
			}
			if (bool_25)
			{
				if (num5 > 0)
				{
					DayLabel dayLabel2 = SubItems[num + num5 - 1] as DayLabel;
					dayLabel2.RecalcSize();
					dayLabel2.Bounds = new Rectangle(location2, size_4);
					location2.Y += num3;
				}
				else
				{
					location2.Y += num3 + num4;
				}
			}
			num2 = 0;
			location3.Y += num3;
			if (num5 == 0)
			{
				location3.Y += num4;
			}
			location3.X = point.X;
			num3 = 0;
			num5++;
		}
		m_Rect.Width = size_4.Width * 7;
		m_Rect.Height = size_4.Height * 7 + num4;
		if (bool_25)
		{
			m_Rect.Width += size_4.Width;
		}
		m_Rect.Width += Class52.smethod_1(elementStyle);
		m_Rect.Height += Class52.smethod_2(elementStyle) + itemContainer.HeightInternal + 1;
		base.RecalcSize();
	}

	public override void Paint(ItemPaintArgs p)
	{
		ItemContainer itemContainer = method_35();
		LabelItem labelItem = itemContainer.SubItems["monthLabel"] as LabelItem;
		labelItem.ForeColor = p.Colors.ItemText;
		labelItem = itemContainer.SubItems["yearLabel"] as LabelItem;
		labelItem.ForeColor = p.Colors.ItemText;
		base.Paint(p);
	}

	public override BaseItem Copy()
	{
		SingleMonthCalendar singleMonthCalendar = new SingleMonthCalendar();
		CopyToItem(singleMonthCalendar);
		return singleMonthCalendar;
	}

	protected override void CopyToItem(BaseItem c)
	{
		SingleMonthCalendar c2 = c as SingleMonthCalendar;
		base.CopyToItem((BaseItem)c2);
	}

	private void method_20(DateTime dateTime_5, eEventSource eEventSource_0)
	{
		method_21(dateTime_5.Month, dateTime_5.Year, eEventSource_0);
	}

	private void method_21(int int_5, int int_6, eEventSource eEventSource_0)
	{
		DateTime dateTime = new DateTime(int_6, int_5, 1);
		bool flag;
		if (flag = dateTime != dateTime_0)
		{
			OnMonthChanging(new EventSourceArgs(eEventSource_0));
		}
		dateTime_0 = dateTime;
		string[] abbreviatedDayNames = DateTimeInput.GetActiveCulture().DateTimeFormat.AbbreviatedDayNames;
		if (string_14 != null)
		{
			abbreviatedDayNames = string_14;
		}
		int num = (int)dayOfWeek_0;
		int num2 = num;
		for (int i = 0; i < 7; i++)
		{
			DayLabel dayLabel = SubItems[i] as DayLabel;
			dayLabel.Text = (bool_29 ? method_37(abbreviatedDayNames[num2]) : abbreviatedDayNames[num2]);
			dayLabel.Visible = true;
			dayLabel.Displayed = true;
			dayLabel.TrackMouse = false;
			dayLabel.Selectable = false;
			dayLabel.IsDayLabel = true;
			method_26(dayLabel);
			num2++;
			if (num2 > 6)
			{
				num2 = 0;
			}
		}
		bool[] array = method_33();
		bool[] array2 = method_34(int_5);
		bool[] array3 = method_28(int_5, int_6);
		DateTime dateTime2 = ((!bool_31) ? DateTime.MinValue : ((dateTime_2 == DateTime.MinValue) ? DateTime.Today : dateTime_2));
		bool flag2 = dateTime2 != DateTime.MinValue;
		int num3 = (int)(dateTime.DayOfWeek - num);
		if (num3 < 0)
		{
			num3 = 7 + num3;
		}
		int num4 = 7;
		if (num3 > 0)
		{
			DateTime dateTime3 = dateTime;
			dateTime3 = dateTime3.AddDays(-num3);
			for (int j = num4; j < num4 + num3; j++)
			{
				DayLabel dayLabel2 = SubItems[j] as DayLabel;
				dayLabel2.Date = dateTime3;
				dayLabel2.Visible = true;
				method_36(dayLabel2);
				if (array[dateTime3.Day - 1])
				{
					method_31(dayLabel2);
				}
				if (int_5 == dateTime3.Month && array2[dateTime3.Day - 1])
				{
					method_29(dayLabel2);
				}
				if (int_5 == dateTime3.Month && int_6 == dateTime3.Year && array3[dateTime3.Day - 1])
				{
					method_27(dayLabel2);
				}
				if (flag2 && dateTime2 == dateTime3)
				{
					dayLabel2.IsToday = true;
				}
				if (!bool_28 && DayLabel.smethod_0(dateTime3))
				{
					dayLabel2.Selectable = false;
					dayLabel2.TrackMouse = false;
				}
				dayLabel2.Enabled = method_24(dateTime3);
				dayLabel2.Displayed = bool_22 && bool_23;
				dayLabel2.IsTrailing = true;
				dateTime3 = dateTime3.AddDays(1.0);
			}
			num4 += num3;
		}
		int num5 = 0;
		int num6 = num4 % 7;
		for (int k = num4; k < 49; k++)
		{
			DayLabel dayLabel3 = SubItems[k] as DayLabel;
			dayLabel3.Date = dateTime;
			method_36(dayLabel3);
			if (array[dateTime.Day - 1])
			{
				method_31(dayLabel3);
			}
			if (int_5 == dateTime.Month && array2[dateTime.Day - 1])
			{
				method_29(dayLabel3);
			}
			if (int_5 == dateTime.Month && array3[dateTime.Day - 1])
			{
				method_27(dayLabel3);
			}
			if (flag2 && dateTime2 == dateTime)
			{
				dayLabel3.IsToday = true;
			}
			if (!bool_28 && DayLabel.smethod_0(dateTime))
			{
				dayLabel3.Selectable = false;
				dayLabel3.TrackMouse = false;
			}
			dayLabel3.Enabled = method_24(dateTime);
			dayLabel3.Visible = true;
			if (dateTime.Month != int_5)
			{
				dayLabel3.IsTrailing = true;
				dayLabel3.Displayed = bool_22 && bool_24;
			}
			else
			{
				dayLabel3.Displayed = true;
				dayLabel3.IsTrailing = false;
				if (dayLabel3.Date == dateTime_1)
				{
					dayLabel3.IsSelected = true;
				}
			}
			if (num6 == 6)
			{
				if (bool_25)
				{
					DayLabel dayLabel4 = SubItems[49 + num5] as DayLabel;
					dayLabel4.Text = DateTimeInput.GetActiveCulture().Calendar.GetWeekOfYear(dateTime, calendarWeekRule_0, dayOfWeek_0).ToString();
					dayLabel4.Visible = true;
					dayLabel4.TrackMouse = false;
					dayLabel4.Selectable = false;
					if (dateTime.Month != int_5 && dateTime.AddDays(-num6).Month != int_5)
					{
						dayLabel4.Displayed = bool_22;
					}
					else
					{
						dayLabel4.Displayed = true;
					}
					method_25(dayLabel4);
				}
				num5++;
				num6 = -1;
			}
			dateTime = dateTime.AddDays(1.0);
			num6++;
		}
		ItemContainer itemContainer = method_35();
		itemContainer.Visible = true;
		itemContainer.Displayed = true;
		LabelItem labelItem = itemContainer.SubItems["monthLabel"] as LabelItem;
		labelItem.Width = size_4.Width * 3;
		labelItem.Text = DateTimeInput.GetActiveCulture().DateTimeFormat.MonthNames[int_5 - 1];
		labelItem = itemContainer.SubItems["yearLabel"] as LabelItem;
		labelItem.Text = int_6.ToString();
		labelItem.Width = (int)((double)size_4.Width * 1.3);
		method_22();
		OnAppearanceChanged();
		Refresh();
		if (flag)
		{
			OnMonthChanged(new EventSourceArgs(eEventSource_0));
		}
	}

	private void method_22()
	{
		ItemContainer itemContainer = method_35();
		DateTime dateTime = dateTime_0.AddMonths(int_4);
		if (dateTime > MaxDate)
		{
			itemContainer.SubItems["increaseMonth"].Enabled = false;
			itemContainer.SubItems["increaseYear"].Enabled = false;
		}
		else
		{
			itemContainer.SubItems["increaseMonth"].Enabled = true;
			dateTime = dateTime_0.AddYears(1);
			itemContainer.SubItems["increaseYear"].Enabled = MaxDate > dateTime;
		}
		dateTime = dateTime_0.AddMonths(-1);
		if (dateTime < method_23(MinDate))
		{
			itemContainer.SubItems["decreaseMonth"].Enabled = false;
			itemContainer.SubItems["decreaseYear"].Enabled = false;
		}
		else
		{
			itemContainer.SubItems["decreaseMonth"].Enabled = true;
			dateTime = dateTime_0.AddYears(-1);
			itemContainer.SubItems["decreaseYear"].Enabled = dateTime > MinDate;
		}
	}

	private DateTime method_23(DateTime dateTime_5)
	{
		if (dateTime_5.Day > 1)
		{
			dateTime_5 = dateTime_5.AddDays(-dateTime_5.Day);
		}
		return dateTime_5;
	}

	private bool method_24(DateTime dateTime_5)
	{
		if (!(dateTime_5 > MaxDate) && !(dateTime_5 < MinDate))
		{
			return true;
		}
		return false;
	}

	private void method_25(DayLabel dayLabel_0)
	{
		MonthCalendarColors monthCalendarColors = method_30();
		if (monthCalendarColors != null && monthCalendarColors.WeekOfYear.IsCustomized)
		{
			method_32(dayLabel_0, monthCalendarColors.WeekOfYear);
		}
	}

	private void method_26(DayLabel dayLabel_0)
	{
		MonthCalendarColors monthCalendarColors = method_30();
		if (monthCalendarColors != null && monthCalendarColors.DayLabel.IsCustomized)
		{
			method_32(dayLabel_0, monthCalendarColors.DayLabel);
		}
	}

	private void method_27(DayLabel dayLabel_0)
	{
		MonthCalendarColors monthCalendarColors = method_30();
		if (monthCalendarColors != null && monthCalendarColors.DayMarker.IsCustomized)
		{
			method_32(dayLabel_0, monthCalendarColors.DayMarker);
		}
	}

	private bool[] method_28(int int_5, int int_6)
	{
		bool[] array = new bool[31];
		if (Parent is MonthCalendarItem)
		{
			MonthCalendarItem monthCalendarItem = Parent as MonthCalendarItem;
			DateTime[] markedDates = monthCalendarItem.MarkedDates;
			DateTime[] array2 = markedDates;
			for (int i = 0; i < array2.Length; i++)
			{
				DateTime dateTime = array2[i];
				if (dateTime.Month == int_5 && dateTime.Year == int_6)
				{
					array[dateTime.Day - 1] = true;
				}
			}
		}
		return array;
	}

	private void method_29(DayLabel dayLabel_0)
	{
		MonthCalendarColors monthCalendarColors = method_30();
		if (monthCalendarColors != null && monthCalendarColors.AnnualMarker.IsCustomized)
		{
			method_32(dayLabel_0, monthCalendarColors.AnnualMarker);
		}
	}

	internal MonthCalendarColors method_30()
	{
		MonthCalendarItem monthCalendarItem = Parent as MonthCalendarItem;
		MonthCalendarColors monthCalendarColors = null;
		if (monthCalendarItem != null)
		{
			return monthCalendarItem.Colors;
		}
		return monthCalendarColors_0;
	}

	private void method_31(DayLabel dayLabel_0)
	{
		MonthCalendarColors monthCalendarColors = method_30();
		if (monthCalendarColors != null && monthCalendarColors.MonthlyMarker.IsCustomized)
		{
			method_32(dayLabel_0, monthCalendarColors.MonthlyMarker);
		}
	}

	private void method_32(DayLabel dayLabel_0, DateAppearanceDescription dateAppearanceDescription_0)
	{
		dayLabel_0.BackgroundStyle.BackColor = dateAppearanceDescription_0.BackColor;
		dayLabel_0.BackgroundStyle.BackColor2 = dateAppearanceDescription_0.BackColor2;
		dayLabel_0.BackgroundStyle.BackColorGradientAngle = dateAppearanceDescription_0.BackColorGradientAngle;
		if (!dateAppearanceDescription_0.BorderColor.IsEmpty)
		{
			dayLabel_0.BackgroundStyle.Border = eStyleBorderType.Solid;
			dayLabel_0.BackgroundStyle.BorderColor = dateAppearanceDescription_0.BorderColor;
			dayLabel_0.BackgroundStyle.BorderWidth = 1;
		}
		dayLabel_0.IsBold = dateAppearanceDescription_0.IsBold;
		if (!dateAppearanceDescription_0.TextColor.IsEmpty)
		{
			dayLabel_0.TextColor = dateAppearanceDescription_0.TextColor;
		}
		dayLabel_0.Selectable = dateAppearanceDescription_0.Selectable;
		if (!dateAppearanceDescription_0.Selectable)
		{
			dayLabel_0.TrackMouse = false;
		}
	}

	private bool[] method_33()
	{
		bool[] array = new bool[31];
		if (Parent is MonthCalendarItem)
		{
			MonthCalendarItem monthCalendarItem = Parent as MonthCalendarItem;
			DateTime[] monthlyMarkedDates = monthCalendarItem.MonthlyMarkedDates;
			DateTime[] array2 = monthlyMarkedDates;
			foreach (DateTime dateTime in array2)
			{
				array[dateTime.Day - 1] = true;
			}
		}
		return array;
	}

	private bool[] method_34(int int_5)
	{
		bool[] array = new bool[31];
		if (Parent is MonthCalendarItem)
		{
			MonthCalendarItem monthCalendarItem = Parent as MonthCalendarItem;
			DateTime[] annuallyMarkedDates = monthCalendarItem.AnnuallyMarkedDates;
			DateTime[] array2 = annuallyMarkedDates;
			for (int i = 0; i < array2.Length; i++)
			{
				DateTime dateTime = array2[i];
				if (dateTime.Month == int_5)
				{
					array[dateTime.Day - 1] = true;
				}
			}
		}
		return array;
	}

	private ItemContainer method_35()
	{
		return SubItems[SubItems.Count - 1] as ItemContainer;
	}

	private void method_36(DayLabel dayLabel_0)
	{
		dayLabel_0.IsSelected = false;
		dayLabel_0.Selectable = true;
		dayLabel_0.TrackMouse = true;
		dayLabel_0.IsToday = false;
		dayLabel_0.IsBold = false;
		dayLabel_0.Image = null;
		dayLabel_0.ImageAlign = eLabelPartAlignment.MiddleRight;
		dayLabel_0.TextAlign = eLabelPartAlignment_0;
		dayLabel_0.TextColor = Color.Empty;
		dayLabel_0.Tooltip = "";
		dayLabel_0.ExpandOnMouseDown = false;
		dayLabel_0.SubItems.Clear();
		dayLabel_0.BackgroundStyle.Reset();
	}

	protected virtual void OnMonthChanged(EventArgs e)
	{
		if (eventHandler_14 != null)
		{
			eventHandler_14(this, e);
		}
	}

	protected virtual void OnMonthChanging(EventArgs e)
	{
		if (eventHandler_15 != null)
		{
			eventHandler_15(this, e);
		}
	}

	private string method_37(string string_15)
	{
		if (string_15.Length > 2)
		{
			return string_15.Substring(0, 2);
		}
		return string_15;
	}

	private void method_38()
	{
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is DayLabel dayLabel && dayLabel.IsTrailing)
			{
				bool flag = bool_22;
				flag = (dayLabel.Displayed = ((!(dayLabel.Date < DisplayMonth)) ? (flag & bool_24) : (flag & bool_23)));
			}
		}
		Refresh();
	}

	private void method_39()
	{
		if (bool_25)
		{
			for (int i = 0; i < 6; i++)
			{
				DayLabel dayLabel = new DayLabel();
				dayLabel.IsWeekOfYear = true;
				SubItems.Insert(49 + i, dayLabel);
			}
			return;
		}
		for (int j = 0; j < 7; j++)
		{
			if (SubItems[49] is DayLabel dayLabel2 && dayLabel2.IsWeekOfYear)
			{
				SubItems.Remove(49);
			}
		}
	}

	private void method_40()
	{
		ItemContainer itemContainer = method_35();
		if (itemContainer.MinimumSize.Height < size_4.Height)
		{
			itemContainer.MinimumSize = new Size(itemContainer.MinimumSize.Width, size_4.Height);
		}
		OnAppearanceChanged();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDaySize()
	{
		int width = size_4.Width;
		Size size = size_3;
		if (width == size.Width)
		{
			int height = size_4.Height;
			Size size2 = size_3;
			return height != size2.Height;
		}
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDaySize()
	{
		DaySize = size_3;
	}

	internal void method_41(DayLabel dayLabel_0, DayPaintEventArgs dayPaintEventArgs_0)
	{
		if (dayPaintEventHandler_0 != null)
		{
			dayPaintEventHandler_0(dayLabel_0, dayPaintEventArgs_0);
		}
	}

	internal void method_42(DayLabel dayLabel_0)
	{
		if (!bool_27 || !dayLabel_0.Selectable || !(dayLabel_0.Date != DateTime.MinValue) || (!bool_28 && DayLabel.smethod_0(dayLabel_0.Date)))
		{
			return;
		}
		if (MultiSelect)
		{
			if (dateTime_1 == DateTime.MinValue)
			{
				dateTime_1 = dayLabel_0.Date;
			}
			dayLabel_0.IsSelected = !dayLabel_0.IsSelected;
		}
		else
		{
			SelectedDate = dayLabel_0.Date;
		}
	}

	protected virtual void OnSelectedDateChanged(EventArgs e)
	{
		if (eventHandler_19 != null)
		{
			eventHandler_19(this, e);
		}
	}

	public DayLabel GetDayLabel(DateTime date)
	{
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is DayLabel dayLabel && dayLabel.Date.Date == date.Date && dayLabel.Visible && dayLabel.Displayed)
			{
				return dayLabel;
			}
		}
		return null;
	}

	protected internal override void OnSubItemExpandChange(BaseItem item)
	{
		base.OnSubItemExpandChange(item);
		if (item.Expanded)
		{
			Expanded = true;
		}
	}

	internal void method_43(DayLabel dayLabel_0, MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventHandler_3 != null)
		{
			mouseEventHandler_3.Invoke((object)dayLabel_0, mouseEventArgs_0);
		}
	}

	internal void method_44(DayLabel dayLabel_0, MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventHandler_4 != null)
		{
			mouseEventHandler_4.Invoke((object)dayLabel_0, mouseEventArgs_0);
		}
	}

	internal void method_45(DayLabel dayLabel_0, EventArgs eventArgs_0)
	{
		if (eventHandler_16 != null)
		{
			eventHandler_16(dayLabel_0, eventArgs_0);
		}
	}

	internal void method_46(DayLabel dayLabel_0, EventArgs eventArgs_0)
	{
		if (eventHandler_17 != null)
		{
			eventHandler_17(dayLabel_0, eventArgs_0);
		}
	}

	internal void method_47(DayLabel dayLabel_0, MouseEventArgs mouseEventArgs_0)
	{
		if (mouseEventHandler_5 != null)
		{
			mouseEventHandler_5.Invoke((object)dayLabel_0, mouseEventArgs_0);
		}
	}

	internal void method_48(DayLabel dayLabel_0, EventArgs eventArgs_0)
	{
		if (eventHandler_18 != null)
		{
			eventHandler_18(dayLabel_0, eventArgs_0);
		}
	}

	private void method_49(object sender, EventArgs e)
	{
		method_20(dateTime_0.AddMonths(-1), eEventSource.Mouse);
		if (method_50())
		{
			SelectedDate = DisplayMonth;
		}
	}

	private bool method_50()
	{
		BaseItem parent = Parent;
		DateTimeInput dateTimeInput;
		while (true)
		{
			if (parent != null)
			{
				parent = parent.Parent;
				if (parent != null && parent.Name == "sysPopupProvider")
				{
					dateTimeInput = parent.ContainerControl as DateTimeInput;
					if (dateTimeInput != null)
					{
						break;
					}
				}
				continue;
			}
			return false;
		}
		return dateTimeInput.AutoSelectDate;
	}

	private void method_51(object sender, EventArgs e)
	{
		method_20(dateTime_0.AddMonths(1), eEventSource.Mouse);
		if (method_50())
		{
			SelectedDate = DisplayMonth;
		}
	}

	private void method_52(object sender, EventArgs e)
	{
		method_20(dateTime_0.AddMonths(-12), eEventSource.Mouse);
		if (method_50())
		{
			SelectedDate = DisplayMonth;
		}
	}

	private void method_53(object sender, EventArgs e)
	{
		method_20(dateTime_0.AddMonths(12), eEventSource.Mouse);
		if (method_50())
		{
			SelectedDate = DisplayMonth;
		}
	}

	private void method_54()
	{
		ItemContainer itemContainer = method_35();
		bool visible = bool_30;
		itemContainer.SubItems["decreaseMonth"].Visible = visible;
		itemContainer.SubItems["increaseMonth"].Visible = visible;
		itemContainer.SubItems["decreaseYear"].Visible = visible;
		itemContainer.SubItems["increaseYear"].Visible = visible;
		itemContainer.NeedRecalcSize = true;
		OnAppearanceChanged();
		Refresh();
	}

	private void method_55()
	{
		DateTime dateTime = ((!bool_31) ? DateTime.MinValue : ((dateTime_2 == DateTime.MinValue) ? DateTime.Today : DateTime.MinValue));
		bool flag = dateTime == DateTime.MinValue;
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is DayLabel dayLabel)
			{
				if (flag)
				{
					dayLabel.IsToday = false;
				}
				else
				{
					dayLabel.IsToday = dayLabel.Date == dateTime;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMinDate()
	{
		return !MinDate.Equals(DateTimeGroup.MinDateTime);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetMinDate()
	{
		MinDate = DateTimeGroup.MinDateTime;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMaxDate()
	{
		return !dateTime_4.Equals(DateTimeGroup.MaxDateTime);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetMaxDate()
	{
		MaxDate = DateTimeGroup.MaxDateTime;
	}
}

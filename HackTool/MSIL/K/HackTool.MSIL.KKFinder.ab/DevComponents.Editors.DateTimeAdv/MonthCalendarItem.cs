using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Events;

namespace DevComponents.Editors.DateTimeAdv;

public class MonthCalendarItem : CalendarBase
{
	private Size size_3 = new Size(10, 8);

	private List<DateTime> list_0 = new List<DateTime>();

	private List<DateTime> list_1 = new List<DateTime>();

	private List<DateTime> list_2 = new List<DateTime>();

	private static string string_7 = "sysCalBottomContainer";

	private static string string_8 = "sysTodayButton";

	private static string string_9 = "sysClearSelectionButton";

	private ItemContainer itemContainer_0;

	private ButtonItem buttonItem_0;

	private ButtonItem buttonItem_1;

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

	private DateRangeEventHandler dateRangeEventHandler_0;

	private int int_4 = 7;

	private DateTime dateTime_0 = DateTime.MinValue;

	private DateTime dateTime_1 = DateTime.MinValue;

	private bool bool_22;

	private Point point_2 = Point.Empty;

	private DateTime dateTime_2 = DateTime.MinValue;

	private DateTime dateTime_3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

	private MonthCalendarColors monthCalendarColors_0 = new MonthCalendarColors();

	private Size size_4 = Size.Empty;

	private bool bool_23;

	private DateTime dateTime_4 = DateTime.MinValue;

	private bool bool_24;

	private bool bool_25;

	[DefaultValue(7)]
	[Description("Gets or sets the maximum number of days that can be selected in a month calendar control.")]
	public int MaxSelectionCount
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

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DateTime SelectionStart
	{
		get
		{
			return dateTime_0;
		}
		set
		{
			if (dateTime_0 != value)
			{
				SetSelectionRange(value, (SelectionEnd == DateTime.MinValue) ? value : SelectionEnd);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DateTime SelectionEnd
	{
		get
		{
			return dateTime_1;
		}
		set
		{
			if (dateTime_1 != value)
			{
				SetSelectionRange((SelectionStart == DateTime.MinValue) ? value : SelectionStart, value);
			}
		}
	}

	[Description("Indicates selected range of dates for a month calendar control.")]
	[Bindable(true)]
	public SelectionRange SelectionRange
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return new SelectionRange(SelectionStart, SelectionEnd);
		}
		set
		{
			SetSelectionRange(value.get_Start(), value.get_End());
		}
	}

	[Description("Indicates whether selection of multiple dates up to the MaxSelectionCount is enabled.")]
	[DefaultValue(false)]
	public bool MultiSelect
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
				method_19();
			}
		}
	}

	[Localizable(true)]
	[DefaultValue(null)]
	[Description("Indicates array of DateTime objects that determine which monthly days to mark using Colors.MonthlyMarker settings. ")]
	public DateTime[] MonthlyMarkedDates
	{
		get
		{
			return list_1.ToArray();
		}
		set
		{
			method_20(value);
		}
	}

	[Description("Indicates array of DateTime objects that determines which annual days are marked using Colors.AnnualMarker settings.")]
	[Localizable(true)]
	[DefaultValue(null)]
	public DateTime[] AnnuallyMarkedDates
	{
		get
		{
			return list_0.ToArray();
		}
		set
		{
			method_21(value);
		}
	}

	[Description("Indicates array of DateTime objects that determines which nonrecurring dates are marked using Colors.DayMarker settings.")]
	[Localizable(true)]
	[DefaultValue(null)]
	public DateTime[] MarkedDates
	{
		get
		{
			return list_2.ToArray();
		}
		set
		{
			method_22(value);
		}
	}

	[Description("Indicates the first month displayed on the control.")]
	public DateTime DisplayMonth
	{
		get
		{
			return dateTime_3;
		}
		set
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			dateTime_3 = value.Date;
			m_NeedRecalcSize = true;
			if (ContainerControl is Control)
			{
				Class109.smethod_2((Control)ContainerControl, bool_3: true);
			}
			ApplySelection();
			Refresh();
		}
	}

	[Browsable(false)]
	public int DisplayedMonthCount
	{
		get
		{
			int num = 0;
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar)
				{
					num++;
				}
			}
			return num;
		}
	}

	[Description("Gets colors used by control.")]
	[NotifyParentProperty(true)]
	[Category("Appearance")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public MonthCalendarColors Colors => monthCalendarColors_0;

	private SingleMonthCalendar SingleMonthCalendar_0 => (SingleMonthCalendar)SubItems[0];

	[Description("Indicate size of each day item on the calendar.")]
	public Size DaySize
	{
		get
		{
			return SingleMonthCalendar_0.DaySize;
		}
		set
		{
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar singleMonthCalendar)
				{
					singleMonthCalendar.DaySize = value;
				}
			}
			NeedRecalcSize = true;
			OnAppearanceChanged();
			Refresh();
		}
	}

	[Description("Indicates minimum date and time that can be selected in the control.")]
	public DateTime MinDate
	{
		get
		{
			return SingleMonthCalendar_0.MinDate;
		}
		set
		{
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar singleMonthCalendar)
				{
					singleMonthCalendar.MinDate = value;
				}
			}
		}
	}

	[Description("Indicates maximum date and time that can be selected in the control.")]
	public DateTime MaxDate
	{
		get
		{
			return SingleMonthCalendar_0.MaxDate;
		}
		set
		{
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar singleMonthCalendar)
				{
					singleMonthCalendar.MaxDate = value;
				}
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Category("Style")]
	[Description("Specifies the commands container background style. Commands container displays Today and Clear buttons if they are visible.")]
	public ElementStyle CommandsBackgroundStyle => itemContainer_0.BackgroundStyle;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Indicates navigation container background style.")]
	[Category("Style")]
	public ElementStyle NavigationBackgroundStyle => SingleMonthCalendar_0.NavigationBackgroundStyle;

	[Description("Indicates number of columns and rows of months displayed on control.")]
	public Size CalendarDimensions
	{
		get
		{
			return size_4;
		}
		set
		{
			if (value.Width >= 0 && value.Height >= 0)
			{
				if ((value.Width == 0 && value.Height > 0) || (value.Width > 0 && value.Height == 0))
				{
					throw new ArgumentOutOfRangeException("Calendar dimension values must be both set to values grater than zero.");
				}
				if (size_4 != value)
				{
					size_4 = value;
					NeedRecalcSize = true;
					OnAppearanceChanged();
					Refresh();
				}
				return;
			}
			throw new ArgumentOutOfRangeException("Calendar dimension values must be greater or equal to zero.");
		}
	}

	[Description("Indicates whether weekend days can be selected.")]
	[DefaultValue(true)]
	public bool WeekendDaysSelectable
	{
		get
		{
			return SingleMonthCalendar_0.WeekendDaysSelectable;
		}
		set
		{
			if (WeekendDaysSelectable == value)
			{
				return;
			}
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar singleMonthCalendar)
				{
					singleMonthCalendar.WeekendDaysSelectable = value;
				}
			}
		}
	}

	[DefaultValue(CalendarWeekRule.FirstDay)]
	[Description("Indicates rule used to determine first week of the year for week of year display on calendar.")]
	public CalendarWeekRule WeekOfYearRule
	{
		get
		{
			return SingleMonthCalendar_0.WeekOfYearRule;
		}
		set
		{
			if (WeekOfYearRule == value)
			{
				return;
			}
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar singleMonthCalendar)
				{
					singleMonthCalendar.WeekOfYearRule = value;
				}
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DateTime TodayDate
	{
		get
		{
			return SingleMonthCalendar_0.TodayDate;
		}
		set
		{
			value = value.Date;
			if (!(TodayDate != value))
			{
				return;
			}
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar singleMonthCalendar)
				{
					singleMonthCalendar.TodayDate = value;
				}
			}
		}
	}

	[Browsable(false)]
	public bool TodayDateSet => SingleMonthCalendar_0.TodayDateSet;

	[DefaultValue(true)]
	[Description("Indicates whether today marker that indicates TodayDate is visible on the calendar.")]
	public bool ShowTodayMarker
	{
		get
		{
			return SingleMonthCalendar_0.ShowTodayMarker;
		}
		set
		{
			if (ShowTodayMarker == value)
			{
				return;
			}
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar singleMonthCalendar)
				{
					singleMonthCalendar.ShowTodayMarker = value;
				}
			}
		}
	}

	[Description("Indicates whether week of year is visible.")]
	[DefaultValue(false)]
	public bool ShowWeekNumbers
	{
		get
		{
			return SingleMonthCalendar_0.ShowWeekNumbers;
		}
		set
		{
			if (ShowWeekNumbers != value)
			{
				SingleMonthCalendar_0.ShowWeekNumbers = value;
				NeedRecalcSize = true;
				OnAppearanceChanged();
				Refresh();
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether control uses the two letter day names.")]
	public bool TwoLetterDayName
	{
		get
		{
			return SingleMonthCalendar_0.TwoLetterDayName;
		}
		set
		{
			SingleMonthCalendar_0.TwoLetterDayName = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
			Refresh();
		}
	}

	[Description("Indicates array of custom names for days displayed on calendar header.")]
	[DefaultValue(null)]
	[Localizable(true)]
	public string[] DayNames
	{
		get
		{
			return SingleMonthCalendar_0.DayNames;
		}
		set
		{
			if (value != null && value.Length != 7)
			{
				throw new ArgumentException("DayNames must have exactly 7 items in collection.");
			}
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is SingleMonthCalendar singleMonthCalendar)
				{
					singleMonthCalendar.DayNames = value;
				}
			}
			NeedRecalcSize = true;
			OnAppearanceChanged();
			Refresh();
		}
	}

	[Description("Indicates first day of week displayed on the calendar.")]
	[DefaultValue(DayOfWeek.Sunday)]
	public DayOfWeek FirstDayOfWeek
	{
		get
		{
			return SingleMonthCalendar_0.FirstDayOfWeek;
		}
		set
		{
			if (FirstDayOfWeek != value)
			{
				foreach (BaseItem subItem in SubItems)
				{
					if (subItem is SingleMonthCalendar singleMonthCalendar)
					{
						singleMonthCalendar.FirstDayOfWeek = value;
					}
				}
			}
			OnAppearanceChanged();
			Refresh();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DateTime SelectedDate
	{
		get
		{
			return dateTime_4;
		}
		set
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			if (!(dateTime_4 != value))
			{
				return;
			}
			dateTime_4 = value;
			try
			{
				bool_23 = true;
				foreach (BaseItem subItem in SubItems)
				{
					if (subItem is SingleMonthCalendar singleMonthCalendar_)
					{
						method_33(singleMonthCalendar_);
					}
				}
				OnDateChanged(new EventArgs());
				OnDateSelected(new DateRangeEventArgs(value, value));
			}
			finally
			{
				bool_23 = false;
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ItemContainer BottomContainer => itemContainer_0;

	[DefaultValue(false)]
	[Description("Indicates whether Today button displayed at the bottom of the calendar is visible.")]
	public bool TodayButtonVisible
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
				NeedRecalcSize = true;
				method_41();
				OnAppearanceChanged();
				Refresh();
			}
		}
	}

	[Description("Indicates whether Clear button displayed at the bottom of the calendar is visible. Clear button clears the currently selected date.")]
	[DefaultValue(false)]
	public bool ClearButtonVisible
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
				NeedRecalcSize = true;
				method_41();
				OnAppearanceChanged();
				Refresh();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(false)]
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
			if (!value)
			{
				BaseItem.CollapseSubItems(this);
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

	[Description("Occurs when the user makes an explicit date selection using the mouse.")]
	public event DateRangeEventHandler DateSelected
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			dateRangeEventHandler_0 = (DateRangeEventHandler)Delegate.Combine((Delegate?)(object)dateRangeEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			dateRangeEventHandler_0 = (DateRangeEventHandler)Delegate.Remove((Delegate?)(object)dateRangeEventHandler_0, (Delegate?)(object)value);
		}
	}

	public MonthCalendarItem()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		monthCalendarColors_0.BaseItem_0 = this;
		SingleMonthCalendar singleMonthCalendar = new SingleMonthCalendar();
		singleMonthCalendar.MonthChanging += method_23;
		singleMonthCalendar.MonthChanged += method_24;
		singleMonthCalendar.PaintLabel += method_25;
		singleMonthCalendar.LabelMouseDown += new MouseEventHandler(method_31);
		singleMonthCalendar.LabelMouseEnter += method_30;
		singleMonthCalendar.LabelMouseHover += method_29;
		singleMonthCalendar.LabelMouseLeave += method_28;
		singleMonthCalendar.LabelMouseMove += new MouseEventHandler(method_27);
		singleMonthCalendar.LabelMouseUp += new MouseEventHandler(method_26);
		singleMonthCalendar.NavigationBackgroundStyle.StyleChanged += method_32;
		singleMonthCalendar.DateChanged += method_34;
		SubItems.Add(singleMonthCalendar);
		itemContainer_0 = new ItemContainer();
		itemContainer_0.AutoCollapseOnClick = false;
		itemContainer_0.Visible = false;
		itemContainer_0.HorizontalItemAlignment = eHorizontalItemsAlignment.Center;
		itemContainer_0.LayoutOrientation = eOrientation.Horizontal;
		itemContainer_0.ItemSpacing = 6;
		itemContainer_0.Name = string_7;
		buttonItem_0 = method_35();
		itemContainer_0.SubItems.Add(buttonItem_0);
		buttonItem_1 = method_38();
		itemContainer_0.SubItems.Add(buttonItem_1);
		SubItems.Add(itemContainer_0);
		method_41();
	}

	public override void RecalcSize()
	{
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		if (!(SubItems[0] is SingleMonthCalendar singleMonthCalendar))
		{
			return;
		}
		bool_23 = true;
		int num = 1;
		int num2 = 1;
		DateTime displayMonth = dateTime_3;
		Size empty = Size.Empty;
		ElementStyle renderBackgroundStyle = GetRenderBackgroundStyle();
		Rectangle rectangle = Class52.smethod_12(renderBackgroundStyle, Bounds);
		SingleMonthCalendar singleMonthCalendar2 = singleMonthCalendar;
		SingleMonthCalendar singleMonthCalendar3 = null;
		singleMonthCalendar.TrailingDaysVisible = false;
		singleMonthCalendar.DisplayMonth = displayMonth;
		singleMonthCalendar.LeftInternal = rectangle.X;
		singleMonthCalendar.TopInternal = rectangle.Y;
		singleMonthCalendar.RecalcSize();
		singleMonthCalendar.Displayed = true;
		singleMonthCalendar.MouseSelectionEnabled = !bool_22;
		if (!bool_22)
		{
			method_33(singleMonthCalendar);
		}
		else
		{
			singleMonthCalendar.SelectedDate = DateTime.MinValue;
		}
		empty = singleMonthCalendar.Size;
		Size size = singleMonthCalendar.Size;
		Point location = rectangle.Location;
		location.X += size.Width + size_3.Width;
		int num3 = empty.Width;
		Size size2 = new Size(1, 1);
		while ((location.Y < rectangle.Bottom && size_4.IsEmpty) || (!size_4.IsEmpty && size_4.Height + 1 > size2.Height))
		{
			if (num < SubItems.Count && SubItems[num] == itemContainer_0)
			{
				num++;
			}
			if ((location.X + size.Width > rectangle.Right && size_4.IsEmpty) || (!size_4.IsEmpty && size2.Width >= size_4.Width))
			{
				location.Y += size.Height + size_3.Height;
				location.X = rectangle.X;
				if (num3 > empty.Width)
				{
					empty.Width = num3 - ((size2.Height > 1) ? size_3.Width : 0);
				}
				num3 = 0;
				size2.Height++;
				size2.Width = 0;
				if ((location.Y + size.Height > rectangle.Bottom && size_4.IsEmpty) || (!size_4.IsEmpty && size2.Height > size_4.Height))
				{
					break;
				}
				empty.Height += size.Height + size_3.Height;
			}
			SingleMonthCalendar singleMonthCalendar4;
			if (SubItems.Count == num)
			{
				singleMonthCalendar4 = new SingleMonthCalendar();
				singleMonthCalendar4.DaySize = singleMonthCalendar2.DaySize;
				singleMonthCalendar4.Visible = true;
				singleMonthCalendar4.Displayed = true;
				singleMonthCalendar4.TrailingDaysVisible = false;
				singleMonthCalendar4.HeaderNavigationEnabled = false;
				singleMonthCalendar4.PaintLabel += method_25;
				singleMonthCalendar4.LabelMouseDown += new MouseEventHandler(method_31);
				singleMonthCalendar4.LabelMouseEnter += method_30;
				singleMonthCalendar4.LabelMouseHover += method_29;
				singleMonthCalendar4.LabelMouseLeave += method_28;
				singleMonthCalendar4.LabelMouseMove += new MouseEventHandler(method_27);
				singleMonthCalendar4.LabelMouseUp += new MouseEventHandler(method_26);
				singleMonthCalendar4.NavigationBackgroundStyle.ApplyStyle(singleMonthCalendar2.NavigationBackgroundStyle);
				singleMonthCalendar4.DateChanged += method_34;
				method_18(singleMonthCalendar4);
				if (SubItems[SubItems.Count - 1] == itemContainer_0)
				{
					SubItems.Insert(SubItems.Count - 1, singleMonthCalendar4);
				}
				else
				{
					SubItems.Add(singleMonthCalendar4);
				}
			}
			else
			{
				singleMonthCalendar4 = (SingleMonthCalendar)SubItems[num];
			}
			singleMonthCalendar4.TwoLetterDayName = TwoLetterDayName;
			singleMonthCalendar4.MinDate = MinDate;
			singleMonthCalendar4.MaxDate = MaxDate;
			singleMonthCalendar4.WeekOfYearRule = WeekOfYearRule;
			singleMonthCalendar4.WeekendDaysSelectable = WeekendDaysSelectable;
			singleMonthCalendar4.TodayDate = TodayDate;
			singleMonthCalendar4.ShowTodayMarker = ShowTodayMarker;
			singleMonthCalendar4.ShowWeekNumbers = ShowWeekNumbers;
			singleMonthCalendar4.FirstDayOfWeek = FirstDayOfWeek;
			singleMonthCalendar4.DayNames = DayNames;
			singleMonthCalendar4.TrailingDaysVisible = false;
			singleMonthCalendar4.MouseSelectionEnabled = !bool_22;
			if (!bool_22)
			{
				method_33(singleMonthCalendar4);
			}
			else
			{
				singleMonthCalendar4.SelectedDate = DateTime.MinValue;
			}
			num++;
			num2++;
			size2.Width++;
			num3 += size_3.Width;
			singleMonthCalendar4.TopInternal = location.Y;
			singleMonthCalendar4.LeftInternal = location.X;
			displayMonth = (singleMonthCalendar4.DisplayMonth = displayMonth.AddMonths(1));
			singleMonthCalendar4.RecalcSize();
			singleMonthCalendar3 = singleMonthCalendar4;
			num3 += singleMonthCalendar4.WidthInternal;
			location.X += singleMonthCalendar4.WidthInternal + size_3.Width;
		}
		for (int i = num; i < SubItems.Count; i++)
		{
			if (SubItems[i] is SingleMonthCalendar singleMonthCalendar5)
			{
				singleMonthCalendar5.PaintLabel -= method_25;
				singleMonthCalendar5.LabelMouseDown -= new MouseEventHandler(method_31);
				singleMonthCalendar5.LabelMouseEnter -= method_30;
				singleMonthCalendar5.LabelMouseHover -= method_29;
				singleMonthCalendar5.LabelMouseLeave -= method_28;
				singleMonthCalendar5.LabelMouseMove -= new MouseEventHandler(method_27);
				singleMonthCalendar5.LabelMouseUp -= new MouseEventHandler(method_26);
				singleMonthCalendar5.DateChanged -= method_34;
			}
			if (SubItems[i] != itemContainer_0)
			{
				SubItems.Remove(i);
			}
		}
		if (string_7 != null && itemContainer_0.Visible)
		{
			ItemContainer itemContainer = itemContainer_0;
			itemContainer.Displayed = true;
			itemContainer.TopInternal = location.Y;
			itemContainer.LeftInternal = location.X;
			itemContainer.WidthInternal = empty.Width;
			itemContainer.RecalcSize();
			itemContainer.WidthInternal = empty.Width;
			empty.Height += itemContainer.HeightInternal + size_3.Height;
		}
		empty.Width += Class52.smethod_1(renderBackgroundStyle);
		empty.Height += Class52.smethod_2(renderBackgroundStyle);
		if (SubItems.Count != 1 && (SubItems.Count != 2 || itemContainer_0 == null))
		{
			singleMonthCalendar2.bool_24 = false;
			singleMonthCalendar2.bool_23 = true;
			singleMonthCalendar2.TrailingDaysVisible = true;
			singleMonthCalendar3.bool_24 = true;
			singleMonthCalendar3.bool_23 = false;
			singleMonthCalendar3.TrailingDaysVisible = true;
		}
		else
		{
			singleMonthCalendar2.bool_24 = true;
			singleMonthCalendar2.bool_23 = true;
			singleMonthCalendar2.TrailingDaysVisible = true;
		}
		singleMonthCalendar2.Int32_1 = num2;
		Bounds = new Rectangle(Bounds.Location, empty);
		base.RecalcSize();
		ApplySelection();
		OnMonthChanged(new EventArgs());
		bool_23 = false;
	}

	private void method_18(SingleMonthCalendar singleMonthCalendar_0)
	{
		singleMonthCalendar_0.DisplayMonth = DateTime.Today;
	}

	protected internal override void OnItemAdded(BaseItem item)
	{
		if (!(item is SingleMonthCalendar) && item != itemContainer_0)
		{
			throw new InvalidOperationException("MultiMonthCalendar can only accept CalendarMonth items.");
		}
		base.OnItemAdded(item);
	}

	public override BaseItem Copy()
	{
		MonthCalendarItem monthCalendarItem = new MonthCalendarItem();
		CopyToItem(monthCalendarItem);
		return monthCalendarItem;
	}

	protected override void CopyToItem(BaseItem c)
	{
		MonthCalendarItem c2 = c as MonthCalendarItem;
		base.CopyToItem((BaseItem)c2);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSelectionRange()
	{
		return !DateTime.Equals(SelectionEnd, SelectionStart);
	}

	public void SetSelectionRange(DateTime startDate, DateTime endDate)
	{
		if (startDate > endDate)
		{
			DateTime dateTime = startDate;
			startDate = endDate;
			endDate = dateTime;
		}
		if (startDate < MinDate)
		{
			throw new ArgumentOutOfRangeException("startDate is less than the minimum date allowable for a month calendar control");
		}
		if (startDate > MaxDate)
		{
			throw new ArgumentOutOfRangeException("startDate is greater than the maximum allowable date for a month calendar control");
		}
		if (endDate < MinDate)
		{
			throw new ArgumentOutOfRangeException("endDate is less than the minimum date allowable for a month calendar control");
		}
		if (endDate > MaxDate)
		{
			throw new ArgumentOutOfRangeException("endDate is greater than the maximum allowable date for a month calendar control");
		}
		dateTime_0 = startDate;
		dateTime_1 = endDate;
		ApplySelection();
		OnDateChanged(new EventArgs());
	}

	public void ApplySelection()
	{
		if (!bool_22 || dateTime_0 == DateTime.MinValue || dateTime_1 == DateTime.MinValue)
		{
			return;
		}
		DateTime dateTime = dateTime_0;
		DateTime dateTime2 = dateTime_1;
		foreach (BaseItem subItem in SubItems)
		{
			if (!(subItem is SingleMonthCalendar singleMonthCalendar))
			{
				continue;
			}
			foreach (BaseItem subItem2 in singleMonthCalendar.SubItems)
			{
				if (subItem2 is DayLabel dayLabel && dayLabel.Selectable && !(dayLabel.Date == DateTime.MinValue))
				{
					if (dayLabel.Date >= dateTime && dayLabel.Date <= dateTime2)
					{
						dayLabel.IsSelected = true;
					}
					else
					{
						dayLabel.IsSelected = false;
					}
				}
			}
		}
	}

	private void method_19()
	{
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is SingleMonthCalendar singleMonthCalendar)
			{
				singleMonthCalendar.MouseSelectionEnabled = !bool_22;
				if (bool_22)
				{
					singleMonthCalendar.SelectedDate = DateTime.MinValue;
				}
			}
		}
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		base.InternalMouseDown(objArg);
		if (bool_22 && (int)objArg.get_Button() == 1048576)
		{
			int x = objArg.get_X();
			int y = objArg.get_Y();
			point_2 = new Point(x, y);
			DayLabel dayAt = GetDayAt(x, y);
			if (dayAt != null)
			{
				dateTime_2 = dayAt.Date;
				SetSelectionRange(dayAt.Date, dayAt.Date);
			}
		}
	}

	public DayLabel GetDayAt(int x, int y)
	{
		BaseItem baseItem = ItemAtLocation(x, y);
		if (baseItem != null && baseItem is SingleMonthCalendar && baseItem.ItemAtLocation(x, y) is DayLabel dayLabel && dayLabel.Date > DateTime.MinValue)
		{
			return dayLabel;
		}
		return null;
	}

	public DayLabel GetDay(DateTime date)
	{
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is SingleMonthCalendar singleMonthCalendar)
			{
				DayLabel dayLabel = singleMonthCalendar.GetDayLabel(date);
				if (dayLabel != null)
				{
					return dayLabel;
				}
			}
		}
		return null;
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		base.InternalMouseMove(objArg);
		if (!bool_22 || (int)objArg.get_Button() != 1048576)
		{
			return;
		}
		DayLabel dayAt = GetDayAt(objArg.get_X(), objArg.get_Y());
		if (dayAt != null && SelectionStart > DateTime.MinValue)
		{
			DateTime dateTime = dayAt.Date;
			DateTime dateTime2 = dateTime_2;
			if (Math.Abs(dateTime2.Subtract(dateTime).TotalDays) > (double)MaxSelectionCount)
			{
				dateTime = dateTime2.AddDays((MaxSelectionCount - 1) * Math.Sign(dateTime.Subtract(dateTime2).TotalDays));
			}
			if (dateTime2 < MinDate)
			{
				dateTime2 = MinDate;
			}
			if (dateTime2 > MaxDate)
			{
				dateTime2 = MaxDate;
			}
			if (dateTime > MaxDate)
			{
				dateTime = MaxDate;
			}
			if (dateTime < MinDate)
			{
				dateTime = MinDate;
			}
			SetSelectionRange(dateTime2, dateTime);
		}
	}

	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		base.InternalMouseUp(objArg);
		if ((int)objArg.get_Button() == 1048576 && dateTime_2 > DateTime.MinValue)
		{
			dateTime_2 = DateTime.MinValue;
			OnDateSelected(new DateRangeEventArgs(SelectionStart, SelectionEnd));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMonthlyMarkedDates()
	{
		return list_1.Count > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetMonthlyMarkedDates()
	{
		MonthlyMarkedDates = null;
	}

	private void method_20(DateTime[] dateTime_5)
	{
		list_1.Clear();
		if (dateTime_5 != null)
		{
			list_1.AddRange(dateTime_5);
		}
	}

	public void RemoveAllMonthlyMarkedDates()
	{
		MonthlyMarkedDates = null;
	}

	public void RemoveMonthlyMarkedDate(DateTime dt)
	{
		DateTime[] monthlyMarkedDates = MonthlyMarkedDates;
		DateTime[] array = monthlyMarkedDates;
		for (int i = 0; i < array.Length; i++)
		{
			DateTime item = array[i];
			if (item.Day == dt.Day)
			{
				list_1.Remove(item);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeAnnuallyMarkedDates()
	{
		return list_0.Count > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetAnnuallyMarkedDates()
	{
		AnnuallyMarkedDates = null;
	}

	private void method_21(DateTime[] dateTime_5)
	{
		list_0.Clear();
		if (dateTime_5 != null)
		{
			list_0.AddRange(dateTime_5);
		}
	}

	public void RemoveAllAnnuallyMarkedDates()
	{
		AnnuallyMarkedDates = null;
	}

	public void RemoveAnnuallyMarkedDate(DateTime dt)
	{
		DateTime[] annuallyMarkedDates = AnnuallyMarkedDates;
		DateTime[] array = annuallyMarkedDates;
		for (int i = 0; i < array.Length; i++)
		{
			DateTime item = array[i];
			if (item.Month == dt.Month && dt.Day == item.Day)
			{
				list_0.Remove(item);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMarkedDates()
	{
		return list_2.Count > 0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetMarkedDates()
	{
		MarkedDates = null;
	}

	private void method_22(DateTime[] dateTime_5)
	{
		list_2.Clear();
		if (dateTime_5 != null)
		{
			list_2.AddRange(dateTime_5);
		}
	}

	public void RemoveAllMarkedDates()
	{
		MarkedDates = null;
	}

	public void RemoveMarkedDate(DateTime dt)
	{
		DateTime[] markedDates = MarkedDates;
		DateTime[] array = markedDates;
		foreach (DateTime dateTime in array)
		{
			if (dateTime == dt)
			{
				list_2.Remove(dateTime);
			}
		}
	}

	public void UpdateMarkedDates()
	{
		DisplayMonth = dateTime_3;
	}

	private void method_23(object sender, EventArgs e)
	{
		OnMonthChanging(e);
	}

	private void method_24(object sender, EventArgs e)
	{
		if (e is EventSourceArgs eventSourceArgs && eventSourceArgs.Source == eEventSource.Mouse)
		{
			SingleMonthCalendar singleMonthCalendar = SubItems[0] as SingleMonthCalendar;
			dateTime_3 = singleMonthCalendar.DisplayMonth;
			DateTime displayMonth = dateTime_3.AddMonths(1);
			bool_23 = true;
			for (int i = 1; i < SubItems.Count; i++)
			{
				if (SubItems[i] is SingleMonthCalendar singleMonthCalendar2)
				{
					singleMonthCalendar2.DisplayMonth = displayMonth;
					displayMonth = displayMonth.AddMonths(1);
					method_33(singleMonthCalendar2);
				}
			}
			bool_23 = false;
			NeedRecalcSize = false;
		}
		if (!NeedRecalcSize)
		{
			OnMonthChanged(e);
		}
	}

	protected virtual void OnMonthChanged(EventArgs e)
	{
		if (eventHandler_14 != null)
		{
			bool needRecalcSize = NeedRecalcSize;
			eventHandler_14(this, e);
			if (NeedRecalcSize != needRecalcSize)
			{
				NeedRecalcSize = false;
			}
		}
	}

	protected virtual void OnMonthChanging(EventArgs e)
	{
		if (eventHandler_15 != null)
		{
			eventHandler_15(this, e);
		}
	}

	private void method_25(object sender, DayPaintEventArgs e)
	{
		OnPaintLabel(e.dayLabel_0, e);
	}

	protected virtual void OnPaintLabel(DayLabel label, DayPaintEventArgs e)
	{
		if (dayPaintEventHandler_0 != null)
		{
			dayPaintEventHandler_0(label, e);
		}
	}

	private void method_26(object sender, MouseEventArgs e)
	{
		OnLabelMouseUp(sender, e);
	}

	private void method_27(object sender, MouseEventArgs e)
	{
		OnLabelMouseMove(sender, e);
	}

	private void method_28(object sender, EventArgs e)
	{
		OnLabelMouseLeave(sender, e);
	}

	private void method_29(object sender, EventArgs e)
	{
		OnLabelMouseHover(sender, e);
	}

	private void method_30(object sender, EventArgs e)
	{
		OnLabelMouseEnter(sender, e);
	}

	private void method_31(object sender, MouseEventArgs e)
	{
		OnLabelMouseDown(sender, e);
	}

	protected virtual void OnLabelMouseDown(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_3 != null)
		{
			mouseEventHandler_3.Invoke(sender, e);
		}
	}

	protected virtual void OnLabelMouseUp(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_4 != null)
		{
			mouseEventHandler_4.Invoke(sender, e);
		}
	}

	protected virtual void OnLabelMouseEnter(object sender, EventArgs e)
	{
		if (eventHandler_16 != null)
		{
			eventHandler_16(sender, e);
		}
	}

	protected virtual void OnLabelMouseLeave(object sender, EventArgs e)
	{
		if (eventHandler_17 != null)
		{
			eventHandler_17(sender, e);
		}
	}

	protected virtual void OnLabelMouseMove(object sender, MouseEventArgs e)
	{
		if (mouseEventHandler_5 != null)
		{
			mouseEventHandler_5.Invoke(sender, e);
		}
	}

	protected virtual void OnLabelMouseHover(object sender, EventArgs e)
	{
		if (eventHandler_18 != null)
		{
			eventHandler_18(sender, e);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDaySize()
	{
		int width = DaySize.Width;
		Size size = SingleMonthCalendar.size_3;
		if (width == size.Width)
		{
			int height = DaySize.Height;
			Size size2 = SingleMonthCalendar.size_3;
			return height != size2.Height;
		}
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDaySize()
	{
		DaySize = SingleMonthCalendar.size_3;
	}

	public bool ShouldSerializeMinDate()
	{
		return !MinDate.Equals(DateTimeGroup.MinDateTime);
	}

	public void ResetMinDate()
	{
		MinDate = DateTimeGroup.MinDateTime;
	}

	public bool ShouldSerializeMaxDate()
	{
		return !MaxDate.Equals(DateTimeGroup.MaxDateTime);
	}

	public void ResetMaxDate()
	{
		MaxDate = DateTimeGroup.MaxDateTime;
	}

	private void method_32(object sender, EventArgs e)
	{
		SingleMonthCalendar singleMonthCalendar_ = SingleMonthCalendar_0;
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem is SingleMonthCalendar singleMonthCalendar && singleMonthCalendar != singleMonthCalendar_)
			{
				singleMonthCalendar.NavigationBackgroundStyle.Reset();
				singleMonthCalendar.NavigationBackgroundStyle.ApplyStyle(singleMonthCalendar_.NavigationBackgroundStyle);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetCalendarDimensions()
	{
		CalendarDimensions = Size.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCalendarDimensions()
	{
		return CalendarDimensions != Size.Empty;
	}

	public void SetCalendarDimensions(int columns, int rows)
	{
		CalendarDimensions = new Size(columns, rows);
	}

	private void method_33(SingleMonthCalendar singleMonthCalendar_0)
	{
		if ((singleMonthCalendar_0.DisplayMonth.Month == dateTime_4.Month && singleMonthCalendar_0.DisplayMonth.Year == dateTime_4.Year) || (singleMonthCalendar_0.TrailingDaysVisible && singleMonthCalendar_0.GetDayLabel(dateTime_4) != null))
		{
			singleMonthCalendar_0.SelectedDate = dateTime_4;
		}
		else if (singleMonthCalendar_0.SelectedDate != DateTime.MinValue)
		{
			singleMonthCalendar_0.SelectedDate = DateTime.MinValue;
		}
	}

	protected virtual void OnDateChanged(EventArgs e)
	{
		if (eventHandler_19 != null)
		{
			eventHandler_19(this, e);
		}
	}

	protected virtual void OnDateSelected(DateRangeEventArgs e)
	{
		if (dateRangeEventHandler_0 != null)
		{
			dateRangeEventHandler_0.Invoke((object)this, e);
		}
	}

	private void method_34(object sender, EventArgs e)
	{
		if (!bool_23)
		{
			SingleMonthCalendar singleMonthCalendar = sender as SingleMonthCalendar;
			SelectedDate = singleMonthCalendar.SelectedDate;
		}
	}

	private ButtonItem method_35()
	{
		ButtonItem buttonItem = new ButtonItem(string_8);
		buttonItem.GlobalItem = false;
		buttonItem.Text = method_37();
		buttonItem.AutoCollapseOnClick = false;
		buttonItem.bool_47 = false;
		buttonItem.Click += method_36;
		return buttonItem;
	}

	private void method_36(object sender, EventArgs e)
	{
		DateTime dateTime3 = (SelectedDate = (DisplayMonth = (TodayDateSet ? TodayDate : DateTime.Today)));
	}

	private string method_37()
	{
		string text = "";
		using (Class264 @class = new Class264(GetOwner() as IOwnerLocalize))
		{
			text = @class.method_1(LocalizationKeys.MonthCalendarTodayButtonText);
		}
		if (text == "")
		{
			text = "Today";
		}
		return text;
	}

	private ButtonItem method_38()
	{
		ButtonItem buttonItem = new ButtonItem(string_9);
		buttonItem.GlobalItem = false;
		buttonItem.Text = method_40();
		buttonItem.AutoCollapseOnClick = false;
		buttonItem.bool_47 = false;
		buttonItem.Click += method_39;
		return buttonItem;
	}

	private void method_39(object sender, EventArgs e)
	{
		SelectedDate = DateTime.MinValue;
	}

	private string method_40()
	{
		string text = "";
		using (Class264 @class = new Class264(GetOwner() as IOwnerLocalize))
		{
			text = @class.method_1(LocalizationKeys.MonthCalendarClearButtonText);
		}
		if (text == "")
		{
			text = "Clear";
		}
		return text;
	}

	private void method_41()
	{
		if (bool_24 != buttonItem_0.Visible)
		{
			buttonItem_0.Visible = bool_24;
		}
		if (bool_25 != buttonItem_1.Visible)
		{
			buttonItem_1.Visible = bool_25;
		}
		bool visible;
		if ((visible = bool_25 | bool_24) != itemContainer_0.Visible)
		{
			itemContainer_0.Visible = visible;
		}
	}
}

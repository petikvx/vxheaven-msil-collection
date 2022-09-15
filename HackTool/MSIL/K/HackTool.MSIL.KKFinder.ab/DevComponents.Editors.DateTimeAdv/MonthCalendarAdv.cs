using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Editors.Design;

namespace DevComponents.Editors.DateTimeAdv;

[Designer(typeof(MonthCalendarAdvDesigner))]
[ToolboxItem(true)]
[ToolboxBitmap(typeof(DotNetBarManager), "MonthCalendarAdv.ico")]
public class MonthCalendarAdv : ItemControl
{
	private MonthCalendarItem monthCalendarItem_0;

	private EventHandler eventHandler_19;

	private EventHandler eventHandler_20;

	private DayPaintEventHandler dayPaintEventHandler_0;

	private MouseEventHandler mouseEventHandler_3;

	private MouseEventHandler mouseEventHandler_4;

	private EventHandler eventHandler_21;

	private EventHandler eventHandler_22;

	private MouseEventHandler mouseEventHandler_5;

	private EventHandler eventHandler_23;

	private EventHandler eventHandler_24;

	private DateRangeEventHandler dateRangeEventHandler_0;

	private Size size_0 = Size.Empty;

	[Localizable(true)]
	[DefaultValue(null)]
	[Description("Indicates array of DateTime objects that determine which monthly days to mark using Colors.MonthlyMarker settings. ")]
	public DateTime[] MonthlyMarkedDates
	{
		get
		{
			return monthCalendarItem_0.MonthlyMarkedDates;
		}
		set
		{
			monthCalendarItem_0.MonthlyMarkedDates = value;
		}
	}

	[Localizable(true)]
	[DefaultValue(null)]
	[Description("Indicates array of DateTime objects that determines which annual days are marked using Colors.AnnualMarker settings.")]
	public DateTime[] AnnuallyMarkedDates
	{
		get
		{
			return monthCalendarItem_0.AnnuallyMarkedDates;
		}
		set
		{
			monthCalendarItem_0.AnnuallyMarkedDates = value;
		}
	}

	[DefaultValue(null)]
	[Description("Indicates array of DateTime objects that determines which nonrecurring dates are marked using Colors.DayMarker settings.")]
	[Localizable(true)]
	public DateTime[] MarkedDates
	{
		get
		{
			return monthCalendarItem_0.MarkedDates;
		}
		set
		{
			monthCalendarItem_0.MarkedDates = value;
		}
	}

	[Description("Indicates the first month displayed on the control.")]
	public DateTime DisplayMonth
	{
		get
		{
			return monthCalendarItem_0.DisplayMonth;
		}
		set
		{
			monthCalendarItem_0.DisplayMonth = value;
		}
	}

	[Browsable(false)]
	public int DisplayedMonthCount => monthCalendarItem_0.DisplayedMonthCount;

	[NotifyParentProperty(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Appearance")]
	[Description("Gets colors used by control.")]
	public MonthCalendarColors Colors => monthCalendarItem_0.Colors;

	[Description("Indicate size of each day item on the calendar.")]
	public Size DaySize
	{
		get
		{
			return monthCalendarItem_0.DaySize;
		}
		set
		{
			monthCalendarItem_0.DaySize = value;
		}
	}

	[Description("Indicates minimum date and time that can be selected in the control.")]
	public DateTime MinDate
	{
		get
		{
			return monthCalendarItem_0.MinDate;
		}
		set
		{
			monthCalendarItem_0.MinDate = value;
		}
	}

	[Description("Indicates maximum date and time that can be selected in the control.")]
	public DateTime MaxDate
	{
		get
		{
			return monthCalendarItem_0.MaxDate;
		}
		set
		{
			monthCalendarItem_0.MaxDate = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Browsable(true)]
	[Description("Specifies the commands container background style. Commands container displays Today and Clear buttons if they are visible.")]
	public ElementStyle CommandsBackgroundStyle => monthCalendarItem_0.CommandsBackgroundStyle;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Description("Indicates navigation container background style.")]
	[Category("Style")]
	public ElementStyle NavigationBackgroundStyle => monthCalendarItem_0.NavigationBackgroundStyle;

	[Description("Indicates number of columns and rows of months displayed on control.")]
	public Size CalendarDimensions
	{
		get
		{
			return monthCalendarItem_0.CalendarDimensions;
		}
		set
		{
			monthCalendarItem_0.CalendarDimensions = value;
			InvalidateAutoSize();
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether weekend days can be selected.")]
	public bool WeekendDaysSelectable
	{
		get
		{
			return monthCalendarItem_0.WeekendDaysSelectable;
		}
		set
		{
			monthCalendarItem_0.WeekendDaysSelectable = value;
		}
	}

	[DefaultValue(CalendarWeekRule.FirstDay)]
	[Description("Indicates rule used to determine first week of the year for week of year display on calendar.")]
	public CalendarWeekRule WeekOfYearRule
	{
		get
		{
			return monthCalendarItem_0.WeekOfYearRule;
		}
		set
		{
			monthCalendarItem_0.WeekOfYearRule = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DateTime TodayDate
	{
		get
		{
			return monthCalendarItem_0.TodayDate;
		}
		set
		{
			monthCalendarItem_0.TodayDate = value;
		}
	}

	[Browsable(false)]
	public bool TodayDateSet => monthCalendarItem_0.TodayDateSet;

	[DefaultValue(true)]
	[Description("Indicates whether today marker that indicates TodayDate is visible on the calendar.")]
	public bool ShowTodayMarker
	{
		get
		{
			return monthCalendarItem_0.ShowTodayMarker;
		}
		set
		{
			monthCalendarItem_0.ShowTodayMarker = value;
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether week of year is visible.")]
	public bool ShowWeekNumbers
	{
		get
		{
			return monthCalendarItem_0.ShowWeekNumbers;
		}
		set
		{
			monthCalendarItem_0.ShowWeekNumbers = value;
			InvalidateAutoSize();
		}
	}

	[Localizable(true)]
	[DefaultValue(null)]
	[Description("Indicates array of custom names for days displayed on calendar header.")]
	public string[] DayNames
	{
		get
		{
			return monthCalendarItem_0.DayNames;
		}
		set
		{
			monthCalendarItem_0.DayNames = value;
		}
	}

	[DefaultValue(DayOfWeek.Sunday)]
	[Description("Indicates first day of week displayed on the calendar.")]
	public DayOfWeek FirstDayOfWeek
	{
		get
		{
			return monthCalendarItem_0.FirstDayOfWeek;
		}
		set
		{
			monthCalendarItem_0.FirstDayOfWeek = value;
		}
	}

	[Description("Indicates whether control uses the two letter day names.")]
	[DefaultValue(true)]
	public bool TwoLetterDayName
	{
		get
		{
			return monthCalendarItem_0.TwoLetterDayName;
		}
		set
		{
			monthCalendarItem_0.TwoLetterDayName = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DateTime SelectedDate
	{
		get
		{
			return monthCalendarItem_0.SelectedDate;
		}
		set
		{
			monthCalendarItem_0.SelectedDate = value;
		}
	}

	[Description("Indicates whether selection of multiple dates up to the MaxSelectionCount is enabled.")]
	[DefaultValue(false)]
	public bool MultiSelect
	{
		get
		{
			return monthCalendarItem_0.MultiSelect;
		}
		set
		{
			monthCalendarItem_0.MultiSelect = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ItemContainer BottomContainer => monthCalendarItem_0.BottomContainer;

	[Description("Indicates whether Today button displayed at the bottom of the calendar is visible.")]
	[DefaultValue(false)]
	public bool TodayButtonVisible
	{
		get
		{
			return monthCalendarItem_0.TodayButtonVisible;
		}
		set
		{
			monthCalendarItem_0.TodayButtonVisible = value;
		}
	}

	[Description("Indicates whether Clear button displayed at the bottom of the calendar is visible. Clear button clears the currently selected date.")]
	[DefaultValue(false)]
	public bool ClearButtonVisible
	{
		get
		{
			return monthCalendarItem_0.ClearButtonVisible;
		}
		set
		{
			monthCalendarItem_0.ClearButtonVisible = value;
		}
	}

	[Description("Gets or sets the maximum number of days that can be selected in a month calendar control.")]
	[DefaultValue(7)]
	public int MaxSelectionCount
	{
		get
		{
			return monthCalendarItem_0.MaxSelectionCount;
		}
		set
		{
			monthCalendarItem_0.MaxSelectionCount = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DateTime SelectionStart
	{
		get
		{
			return monthCalendarItem_0.SelectionStart;
		}
		set
		{
			monthCalendarItem_0.SelectionStart = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DateTime SelectionEnd
	{
		get
		{
			return monthCalendarItem_0.SelectionEnd;
		}
		set
		{
			monthCalendarItem_0.SelectionEnd = value;
		}
	}

	[Description("Indicates selected range of dates for a month calendar control. ")]
	[Bindable(true)]
	public SelectionRange SelectionRange
	{
		get
		{
			return monthCalendarItem_0.SelectionRange;
		}
		set
		{
			monthCalendarItem_0.SelectionRange = value;
		}
	}

	[DefaultValue(false)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	public override bool AutoSize
	{
		get
		{
			return base.AutoSize;
		}
		set
		{
			if (((Control)this).get_AutoSize() != value)
			{
				base.AutoSize = value;
				method_24();
			}
		}
	}

	public event EventHandler MonthChanged
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

	public event EventHandler MonthChanging
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
			eventHandler_21 = (EventHandler)Delegate.Combine(eventHandler_21, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_21 = (EventHandler)Delegate.Remove(eventHandler_21, value);
		}
	}

	[Description("Occurs when mouse leaves the day/week label inside of the calendar.")]
	public event EventHandler LabelMouseLeave
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
			eventHandler_23 = (EventHandler)Delegate.Combine(eventHandler_23, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_23 = (EventHandler)Delegate.Remove(eventHandler_23, value);
		}
	}

	[Description("Occurs when SelectedDate property has changed.")]
	public event EventHandler DateChanged
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

	public MonthCalendarAdv()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		monthCalendarItem_0 = new MonthCalendarItem();
		monthCalendarItem_0.GlobalItem = false;
		monthCalendarItem_0.ContainerControl = this;
		monthCalendarItem_0.Stretch = false;
		monthCalendarItem_0.Displayed = true;
		monthCalendarItem_0.Style = eDotNetBarStyle.Office2007;
		base.ColorScheme.EDotNetBarStyle_0 = eDotNetBarStyle.Office2007;
		monthCalendarItem_0.method_6(this);
		monthCalendarItem_0.MonthChanged += monthCalendarItem_0_MonthChanged;
		monthCalendarItem_0.MonthChanging += monthCalendarItem_0_MonthChanging;
		monthCalendarItem_0.PaintLabel += monthCalendarItem_0_PaintLabel;
		monthCalendarItem_0.LabelMouseDown += new MouseEventHandler(monthCalendarItem_0_LabelMouseDown);
		monthCalendarItem_0.LabelMouseUp += new MouseEventHandler(monthCalendarItem_0_LabelMouseUp);
		monthCalendarItem_0.LabelMouseEnter += monthCalendarItem_0_LabelMouseEnter;
		monthCalendarItem_0.LabelMouseLeave += monthCalendarItem_0_LabelMouseLeave;
		monthCalendarItem_0.LabelMouseMove += new MouseEventHandler(monthCalendarItem_0_LabelMouseMove);
		monthCalendarItem_0.LabelMouseHover += monthCalendarItem_0_LabelMouseHover;
		monthCalendarItem_0.DateChanged += monthCalendarItem_0_DateChanged;
		monthCalendarItem_0.DateSelected += new DateRangeEventHandler(monthCalendarItem_0_DateSelected);
		SetBaseItemContainer(monthCalendarItem_0);
	}

	private void monthCalendarItem_0_DateSelected(object sender, DateRangeEventArgs e)
	{
		OnDateSelected(e);
	}

	private void monthCalendarItem_0_DateChanged(object sender, EventArgs e)
	{
		OnDateChanged(e);
	}

	private void monthCalendarItem_0_LabelMouseHover(object sender, EventArgs e)
	{
		OnLabelMouseHover(sender, e);
	}

	private void monthCalendarItem_0_LabelMouseMove(object sender, MouseEventArgs e)
	{
		OnLabelMouseMove(sender, e);
	}

	private void monthCalendarItem_0_LabelMouseLeave(object sender, EventArgs e)
	{
		OnLabelMouseLeave(sender, e);
	}

	private void monthCalendarItem_0_LabelMouseEnter(object sender, EventArgs e)
	{
		OnLabelMouseEnter(sender, e);
	}

	private void monthCalendarItem_0_LabelMouseUp(object sender, MouseEventArgs e)
	{
		OnLabelMouseUp(sender, e);
	}

	private void monthCalendarItem_0_LabelMouseDown(object sender, MouseEventArgs e)
	{
		OnLabelMouseDown(sender, e);
	}

	private void monthCalendarItem_0_PaintLabel(object sender, DayPaintEventArgs e)
	{
		OnPaintLabel(sender, e);
	}

	private void monthCalendarItem_0_MonthChanging(object sender, EventArgs e)
	{
		OnMonthChanging(e);
	}

	private void monthCalendarItem_0_MonthChanged(object sender, EventArgs e)
	{
		OnMonthChanged(e);
	}

	public DayLabel GetDayAt(int x, int y)
	{
		return monthCalendarItem_0.GetDayAt(x, y);
	}

	public DayLabel GetDay(DateTime date)
	{
		return monthCalendarItem_0.GetDay(date);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMonthlyMarkedDates()
	{
		return monthCalendarItem_0.ShouldSerializeMonthlyMarkedDates();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetMonthlyMarkedDates()
	{
		monthCalendarItem_0.ResetMonthlyMarkedDates();
	}

	public void RemoveAllMonthlyMarkedDates()
	{
		monthCalendarItem_0.RemoveAllMonthlyMarkedDates();
	}

	public void RemoveMonthlyMarkedDate(DateTime dt)
	{
		monthCalendarItem_0.RemoveMonthlyMarkedDate(dt);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeAnnuallyMarkedDates()
	{
		return monthCalendarItem_0.ShouldSerializeAnnuallyMarkedDates();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetAnnuallyMarkedDates()
	{
		monthCalendarItem_0.ResetAnnuallyMarkedDates();
	}

	public void RemoveAllAnnuallyMarkedDates()
	{
		monthCalendarItem_0.RemoveAllAnnuallyMarkedDates();
	}

	public void RemoveAnnuallyMarkedDate(DateTime dt)
	{
		monthCalendarItem_0.RemoveAnnuallyMarkedDate(dt);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMarkedDates()
	{
		return monthCalendarItem_0.ShouldSerializeMarkedDates();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetMarkedDates()
	{
		monthCalendarItem_0.ResetMarkedDates();
	}

	public void RemoveAllMarkedDates()
	{
		monthCalendarItem_0.RemoveAllMarkedDates();
	}

	public void RemoveMarkedDate(DateTime dt)
	{
		monthCalendarItem_0.RemoveMarkedDate(dt);
	}

	public void UpdateMarkedDates()
	{
		monthCalendarItem_0.UpdateMarkedDates();
	}

	protected virtual void OnDateChanged(EventArgs e)
	{
		if (eventHandler_24 != null)
		{
			eventHandler_24(this, e);
		}
	}

	protected virtual void OnDateSelected(DateRangeEventArgs e)
	{
		if (dateRangeEventHandler_0 != null)
		{
			dateRangeEventHandler_0.Invoke((object)this, e);
		}
	}

	protected virtual void OnMonthChanged(EventArgs e)
	{
		if (eventHandler_19 != null)
		{
			eventHandler_19(this, e);
		}
	}

	protected virtual void OnMonthChanging(EventArgs e)
	{
		if (eventHandler_20 != null)
		{
			eventHandler_20(this, e);
		}
	}

	protected virtual void OnPaintLabel(object sender, DayPaintEventArgs e)
	{
		if (dayPaintEventHandler_0 != null)
		{
			dayPaintEventHandler_0(sender, e);
		}
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
		if (eventHandler_21 != null)
		{
			eventHandler_21(sender, e);
		}
	}

	protected virtual void OnLabelMouseLeave(object sender, EventArgs e)
	{
		if (eventHandler_22 != null)
		{
			eventHandler_22(sender, e);
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
		if (eventHandler_23 != null)
		{
			eventHandler_23(sender, e);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDaySize()
	{
		return monthCalendarItem_0.ShouldSerializeDaySize();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDaySize()
	{
		monthCalendarItem_0.ResetDaySize();
	}

	public bool ShouldSerializeMinDate()
	{
		return monthCalendarItem_0.ShouldSerializeMinDate();
	}

	public void ResetMinDate()
	{
		monthCalendarItem_0.ResetMinDate();
	}

	public bool ShouldSerializeMaxDate()
	{
		return monthCalendarItem_0.ShouldSerializeMaxDate();
	}

	public void ResetMaxDate()
	{
		monthCalendarItem_0.ResetMaxDate();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetCalendarDimensions()
	{
		monthCalendarItem_0.ResetCalendarDimensions();
		InvalidateAutoSize();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCalendarDimensions()
	{
		return monthCalendarItem_0.ShouldSerializeCalendarDimensions();
	}

	public void SetCalendarDimensions(int columns, int rows)
	{
		monthCalendarItem_0.SetCalendarDimensions(columns, rows);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSelectionRange()
	{
		return monthCalendarItem_0.ShouldSerializeSelectionRange();
	}

	public void SetSelectionRange(DateTime startDate, DateTime endDate)
	{
		monthCalendarItem_0.SetSelectionRange(startDate, endDate);
	}

	public void InvalidateAutoSize()
	{
		size_0 = Size.Empty;
		method_24();
	}

	private void method_24()
	{
		if (((Control)this).get_AutoSize())
		{
			((Control)this).set_Size(((Control)this).get_PreferredSize());
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		InvalidateAutoSize();
		base.OnFontChanged(e);
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		if (!size_0.IsEmpty)
		{
			return size_0;
		}
		if (!Class109.smethod_11((Control)(object)this))
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		ElementStyle backgroundStyle = GetBackgroundStyle();
		monthCalendarItem_0.RecalcSize();
		size_0 = monthCalendarItem_0.Size;
		if (backgroundStyle != null)
		{
			size_0.Width += Class52.smethod_1(backgroundStyle);
			size_0.Height += Class52.smethod_2(backgroundStyle);
		}
		return size_0;
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_AutoSize())
		{
			Size preferredSize = ((Control)this).get_PreferredSize();
			width = preferredSize.Width;
			height = preferredSize.Height;
		}
		((Control)this).SetBoundsCore(x, y, width, height, specified);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (((Control)this).get_AutoSize())
		{
			method_24();
		}
		base.OnHandleCreated(e);
	}
}

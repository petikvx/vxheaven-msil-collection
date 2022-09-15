using System.ComponentModel;
using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.Editors.DateTimeAdv;

[DesignTimeVisible(false)]
[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
public class MonthCalendarColors
{
	private BaseItem baseItem_0;

	private DateAppearanceDescription dateAppearanceDescription_0 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_1 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_2 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_3 = new DateAppearanceDescription();

	private Color color_0 = Color.Empty;

	private DateAppearanceDescription dateAppearanceDescription_4 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_5 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_6 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_7 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_8 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_9 = new DateAppearanceDescription();

	private DateAppearanceDescription dateAppearanceDescription_10 = new DateAppearanceDescription();

	internal BaseItem BaseItem_0
	{
		get
		{
			return baseItem_0;
		}
		set
		{
			baseItem_0 = value;
			dateAppearanceDescription_3.BaseItem_0 = value;
			dateAppearanceDescription_4.BaseItem_0 = value;
			dateAppearanceDescription_5.BaseItem_0 = value;
			dateAppearanceDescription_2.BaseItem_0 = value;
			dateAppearanceDescription_0.BaseItem_0 = value;
			dateAppearanceDescription_6.BaseItem_0 = value;
			dateAppearanceDescription_7.BaseItem_0 = value;
			dateAppearanceDescription_10.BaseItem_0 = value;
			dateAppearanceDescription_8.BaseItem_0 = value;
			dateAppearanceDescription_9.BaseItem_0 = value;
			dateAppearanceDescription_1.BaseItem_0 = value;
		}
	}

	[Description("Indicates appearance settings for the todays date.")]
	[NotifyParentProperty(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DateAppearanceDescription Today => dateAppearanceDescription_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[NotifyParentProperty(true)]
	[Description("Indicates appearance settings for selected days.")]
	public DateAppearanceDescription Selection => dateAppearanceDescription_1;

	[NotifyParentProperty(true)]
	[Description("Indicates appearance settings for the trailing days on calendar.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DateAppearanceDescription TrailingDay => dateAppearanceDescription_2;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Indicates appearance settings for the labels that show week of year number.")]
	[NotifyParentProperty(true)]
	public DateAppearanceDescription WeekOfYear => dateAppearanceDescription_3;

	[Description("Indicates days divider line color.")]
	[Category("Colors")]
	public Color DaysDividerBorderColors
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			method_0();
		}
	}

	[Description("Indicates appearance settings for the numeric day of month label.")]
	[NotifyParentProperty(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DateAppearanceDescription Day => dateAppearanceDescription_4;

	[NotifyParentProperty(true)]
	[Description("Indicates appearance settings for the weekend days on calendar (Saturday and Sunday).")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DateAppearanceDescription Weekend => dateAppearanceDescription_5;

	[NotifyParentProperty(true)]
	[Description("Indicates appearance settings for the trailing weekend days on calendar (Saturday and Sunday).")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DateAppearanceDescription TrailingWeekend => dateAppearanceDescription_6;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Indicates appearance settings for the labels that display day name in calendar header.")]
	[NotifyParentProperty(true)]
	public DateAppearanceDescription DayLabel => dateAppearanceDescription_7;

	[NotifyParentProperty(true)]
	[Description("Gets marker settings for days specified by MonthCalendarAdv.MonthlyMarkedDates property.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DateAppearanceDescription MonthlyMarker => dateAppearanceDescription_8;

	[Description("Gets marker settings for days specified by MonthCalendarAdv.AnnuallyMarkedDates property.")]
	[NotifyParentProperty(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DateAppearanceDescription AnnualMarker => dateAppearanceDescription_9;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets marker settings for days specified by MonthCalendarAdv.MarkedDates property.")]
	[NotifyParentProperty(true)]
	public DateAppearanceDescription DayMarker => dateAppearanceDescription_10;

	private void method_0()
	{
		if (baseItem_0 != null)
		{
			baseItem_0.NeedRecalcSize = true;
			baseItem_0.Refresh();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetToday()
	{
		dateAppearanceDescription_0 = new DateAppearanceDescription();
		dateAppearanceDescription_0.BaseItem_0 = baseItem_0;
		method_0();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetSelection()
	{
		dateAppearanceDescription_1 = new DateAppearanceDescription();
		dateAppearanceDescription_1.BaseItem_0 = baseItem_0;
		method_0();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTrailingDay()
	{
		dateAppearanceDescription_2 = new DateAppearanceDescription();
		dateAppearanceDescription_2.BaseItem_0 = baseItem_0;
		method_0();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWeekOfYear()
	{
		dateAppearanceDescription_3 = new DateAppearanceDescription();
		dateAppearanceDescription_3.BaseItem_0 = baseItem_0;
		method_0();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDaysDividerBorderColors()
	{
		return !DaysDividerBorderColors.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDaysDividerBorderColors()
	{
		DaysDividerBorderColors = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDay()
	{
		dateAppearanceDescription_4 = new DateAppearanceDescription();
		dateAppearanceDescription_4.BaseItem_0 = baseItem_0;
		method_0();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetWeekend()
	{
		dateAppearanceDescription_5 = new DateAppearanceDescription();
		dateAppearanceDescription_5.BaseItem_0 = baseItem_0;
		method_0();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTrailingWeekend()
	{
		dateAppearanceDescription_6 = new DateAppearanceDescription();
		dateAppearanceDescription_6.BaseItem_0 = baseItem_0;
		method_0();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetDayLabel()
	{
		dateAppearanceDescription_7 = new DateAppearanceDescription();
		dateAppearanceDescription_7.BaseItem_0 = baseItem_0;
		method_0();
	}
}

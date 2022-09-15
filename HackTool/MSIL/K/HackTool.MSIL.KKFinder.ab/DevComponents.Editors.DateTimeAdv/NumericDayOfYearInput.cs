namespace DevComponents.Editors.DateTimeAdv;

public class NumericDayOfYearInput : VisualIntegerInput, IDateTimePartInput
{
	eDateTimePart IDateTimePartInput.Part => eDateTimePart.DayOfYear;

	public NumericDayOfYearInput()
	{
		base.MinValue = 1;
		base.MaxValue = 366;
	}
}

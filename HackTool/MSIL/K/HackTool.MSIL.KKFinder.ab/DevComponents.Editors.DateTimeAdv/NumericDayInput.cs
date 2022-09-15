namespace DevComponents.Editors.DateTimeAdv;

public class NumericDayInput : VisualIntegerInput, IDateTimePartInput
{
	public eDateTimePart Part => eDateTimePart.Day;

	public NumericDayInput()
	{
		base.MinValue = 1;
		base.MaxValue = 31;
	}
}

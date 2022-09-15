namespace DevComponents.Editors.DateTimeAdv;

public class NumericMinuteInput : VisualIntegerInput, IDateTimePartInput
{
	eDateTimePart IDateTimePartInput.Part => eDateTimePart.Minute;

	public NumericMinuteInput()
	{
		base.MinValue = 0;
		base.MaxValue = 59;
	}
}

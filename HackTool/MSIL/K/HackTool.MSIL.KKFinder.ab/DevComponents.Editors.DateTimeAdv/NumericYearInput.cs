using System;
using System.ComponentModel;

namespace DevComponents.Editors.DateTimeAdv;

public class NumericYearInput : VisualIntegerInput, IDateTimePartInput
{
	private eYearDisplayFormat eYearDisplayFormat_0;

	[DefaultValue(eYearDisplayFormat.FourDigit)]
	public eYearDisplayFormat YearDisplayFormat
	{
		get
		{
			return eYearDisplayFormat_0;
		}
		set
		{
			if (eYearDisplayFormat_0 != value)
			{
				eYearDisplayFormat_0 = value;
				InvalidateArrange();
			}
		}
	}

	eDateTimePart IDateTimePartInput.Part => eDateTimePart.Year;

	public NumericYearInput()
	{
		DateTime minValue = DateTime.MinValue;
		base.MinValue = minValue.Year;
		DateTime maxValue = DateTime.MaxValue;
		base.MaxValue = maxValue.Year;
	}

	protected override string GetMeasureString()
	{
		return method_9(base.GetMeasureString());
	}

	protected override string GetRenderString()
	{
		return method_9(base.GetRenderString());
	}

	private string method_9(string string_4)
	{
		if (!base.IsFocused && string_4.Length >= 4 && eYearDisplayFormat_0 != 0)
		{
			if (eYearDisplayFormat_0 == eYearDisplayFormat.TwoDigit)
			{
				return string_4.Substring(2);
			}
			return string_4.Substring(3);
		}
		return string_4;
	}

	protected override void InputComplete(bool sendNotification)
	{
		method_10();
		base.InputComplete(sendNotification);
	}

	protected override void OnInputLostFocus()
	{
		method_10();
		base.OnInputLostFocus();
	}

	private void method_10()
	{
		if (!IsEmpty && Value < 100)
		{
			Value = int.Parse(DateTime.Now.Year.ToString().Substring(0, 2) + Value.ToString("00"));
		}
	}
}

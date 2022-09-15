namespace DevComponents.Editors.DateTimeAdv;

public class NumericHourInput : VisualIntegerInput, IDateTimePartInput
{
	private bool bool_13 = true;

	private eHourPeriod eHourPeriod_0;

	public bool Is24HourFormat
	{
		get
		{
			return bool_13;
		}
		set
		{
			if (bool_13 != value)
			{
				bool_13 = value;
				method_9();
			}
		}
	}

	public eHourPeriod Period
	{
		get
		{
			return eHourPeriod_0;
		}
		set
		{
			if (eHourPeriod_0 != value)
			{
				eHourPeriod_0 = value;
				if (!bool_13)
				{
					method_10();
					Value = Value;
				}
			}
		}
	}

	public override int Value
	{
		get
		{
			return base.Value;
		}
		set
		{
			if (!bool_13)
			{
				if (value == 0)
				{
					value = 12;
					eHourPeriod_0 = eHourPeriod.AM;
				}
				else if (value > 12)
				{
					eHourPeriod_0 = eHourPeriod.PM;
					value -= 12;
				}
				method_10();
			}
			base.Value = value;
		}
	}

	eDateTimePart IDateTimePartInput.Part => eDateTimePart.Hour;

	public NumericHourInput()
	{
		method_10();
	}

	private void method_9()
	{
		if (!bool_13 && Value > 12)
		{
			Value = Value;
		}
		method_10();
	}

	private void method_10()
	{
		if (bool_13)
		{
			base.MinValue = 0;
			base.MaxValue = 23;
		}
		else if (eHourPeriod_0 == eHourPeriod.AM)
		{
			base.MinValue = 1;
			base.MaxValue = 12;
		}
		else
		{
			base.MinValue = 1;
			base.MaxValue = 12;
		}
	}

	protected override void OnValueChanged()
	{
		if (bool_13)
		{
			if (Value >= 0 && Value <= 12)
			{
				Period = eHourPeriod.AM;
			}
			else
			{
				Period = eHourPeriod.PM;
			}
		}
		base.OnValueChanged();
	}

	protected override bool ValidateNewInputStack(string s)
	{
		if (!bool_13 && s.Length > 0)
		{
			int result = 0;
			if (int.TryParse(s, out result) && result > 12 && result < 24)
			{
				SetInputStack("");
				SetInputPosition(0);
				Value = result;
				return false;
			}
		}
		return base.ValidateNewInputStack(s);
	}

	protected override void OnIsEmptyChanged()
	{
		if (IsEmpty)
		{
			eHourPeriod_0 = eHourPeriod.AM;
			method_10();
		}
		base.OnIsEmptyChanged();
	}
}

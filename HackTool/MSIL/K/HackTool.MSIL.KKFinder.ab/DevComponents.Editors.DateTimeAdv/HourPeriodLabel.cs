using System;
using System.ComponentModel;

namespace DevComponents.Editors.DateTimeAdv;

public class HourPeriodLabel : VisualLabel
{
	private NumericHourInput numericHourInput_0;

	private string string_1 = "";

	private string string_2 = "";

	private bool bool_6;

	public NumericHourInput HourInput
	{
		get
		{
			return numericHourInput_0;
		}
		set
		{
			if (numericHourInput_0 != null)
			{
				numericHourInput_0.ValueChanged -= numericHourInput_0_ValueChanged;
			}
			numericHourInput_0 = value;
			if (numericHourInput_0 != null)
			{
				numericHourInput_0.ValueChanged += numericHourInput_0_ValueChanged;
			}
		}
	}

	[DefaultValue("")]
	public string AMText
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			InvalidateArrange();
		}
	}

	[DefaultValue("")]
	public string PMText
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			InvalidateArrange();
		}
	}

	public bool UseSingleLetterLabel
	{
		get
		{
			return bool_6;
		}
		set
		{
			if (bool_6 != value)
			{
				bool_6 = value;
				InvalidateArrange();
			}
		}
	}

	private void numericHourInput_0_ValueChanged(object sender, EventArgs e)
	{
		if (numericHourInput_0 == null)
		{
			return;
		}
		string text = "";
		if (!numericHourInput_0.IsEmpty)
		{
			text = ((numericHourInput_0.Period == eHourPeriod.AM) ? ((string_1 == null || string_1.Length <= 0) ? DateTimeInput.GetActiveCulture().DateTimeFormat.AMDesignator : string_1) : ((string_2 == null || string_2.Length <= 0) ? DateTimeInput.GetActiveCulture().DateTimeFormat.PMDesignator : string_2));
			if (bool_6 && text.Length > 0)
			{
				text = text[0].ToString();
			}
		}
		base.Text = text;
	}
}

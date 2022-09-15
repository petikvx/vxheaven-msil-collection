using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevComponents.Editors.DateTimeAdv;

public class HourPeriodInput : VisualStringListInput
{
	private NumericHourInput numericHourInput_0;

	private bool bool_13;

	private string string_6 = "";

	private string string_7 = "";

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
				numericHourInput_0.IsEmptyChanged -= numericHourInput_0_IsEmptyChanged;
			}
			numericHourInput_0 = value;
			if (numericHourInput_0 != null)
			{
				numericHourInput_0.ValueChanged += numericHourInput_0_ValueChanged;
				numericHourInput_0.IsEmptyChanged += numericHourInput_0_IsEmptyChanged;
			}
		}
	}

	public bool UseSingleLetterLabel
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
				InvalidateArrange();
			}
		}
	}

	[DefaultValue("")]
	public string AMText
	{
		get
		{
			return string_6;
		}
		set
		{
			string_6 = value;
			InvalidateArrange();
		}
	}

	[DefaultValue("")]
	public string PMText
	{
		get
		{
			return string_7;
		}
		set
		{
			string_7 = value;
			InvalidateArrange();
		}
	}

	private void numericHourInput_0_IsEmptyChanged(object sender, EventArgs e)
	{
		if (numericHourInput_0 != null && numericHourInput_0.IsEmpty)
		{
			IsEmpty = true;
		}
	}

	private void numericHourInput_0_ValueChanged(object sender, EventArgs e)
	{
		if (numericHourInput_0 == null)
		{
			return;
		}
		if (!numericHourInput_0.IsEmpty)
		{
			if (numericHourInput_0.Period == eHourPeriod.AM)
			{
				base.SelectedIndex = 0;
			}
			else
			{
				base.SelectedIndex = 1;
			}
		}
		else
		{
			base.SelectedIndex = -1;
		}
	}

	protected override List<string> GetItems()
	{
		List<string> list = new List<string>(2);
		list.Add(method_1());
		list.Add(method_0());
		return list;
	}

	private string method_0()
	{
		string text = "";
		text = ((string_7 == null || string_7.Length <= 0) ? DateTimeInput.GetActiveCulture().DateTimeFormat.PMDesignator : string_7);
		if (bool_13 && text.Length > 0)
		{
			text = text[0].ToString();
		}
		return text;
	}

	private string method_1()
	{
		string text = "";
		text = ((string_6 == null || string_6.Length <= 0) ? DateTimeInput.GetActiveCulture().DateTimeFormat.AMDesignator : string_6);
		if (bool_13 && text.Length > 0)
		{
			text = text[0].ToString();
		}
		return text;
	}

	protected override void OnSelectedIndexChanged(EventArgs eventArgs)
	{
		if (numericHourInput_0 != null && !numericHourInput_0.IsEmpty)
		{
			eHourPeriod eHourPeriod = ((base.SelectedIndex == 1) ? eHourPeriod.PM : eHourPeriod.AM);
			if (numericHourInput_0.Period != eHourPeriod)
			{
				numericHourInput_0.Period = eHourPeriod;
			}
		}
		base.OnSelectedIndexChanged(eventArgs);
	}
}

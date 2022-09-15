using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevComponents.Editors.DateTimeAdv;

public class DayLabelItem : VisualLabel, IDateTimePartInput
{
	private int int_0 = -1;

	private List<string> list_0;

	private bool bool_6;

	[DefaultValue(-1)]
	public int Day
	{
		get
		{
			return int_0;
		}
		set
		{
			if (int_0 != value)
			{
				if (int_0 < -1 || int_0 > 6)
				{
					throw new ArgumentException("Day must be value between -1 and 6");
				}
				int_0 = value;
				method_0();
			}
		}
	}

	public List<string> DayNames
	{
		get
		{
			return list_0;
		}
		set
		{
			if (value != null && value.Count != 7)
			{
				throw new ArgumentException("DayNames must have exactly 7 items in collection.");
			}
			list_0 = value;
		}
	}

	[DefaultValue(false)]
	public bool UseAbbreviatedNames
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
				method_1();
			}
		}
	}

	int IDateTimePartInput.Value
	{
		get
		{
			return int_0;
		}
		set
		{
			Day = value;
		}
	}

	int IDateTimePartInput.MinValue
	{
		get
		{
			return 0;
		}
		set
		{
			throw new Exception("The method or operation is not implemented.");
		}
	}

	int IDateTimePartInput.MaxValue
	{
		get
		{
			return 6;
		}
		set
		{
			throw new Exception("The method or operation is not implemented.");
		}
	}

	eDateTimePart IDateTimePartInput.Part => eDateTimePart.DayName;

	bool IDateTimePartInput.IsEmpty
	{
		get
		{
			return int_0 == -1;
		}
		set
		{
			Day = -1;
		}
	}

	private void method_0()
	{
		method_1();
	}

	private void method_1()
	{
		if (int_0 == -1)
		{
			base.Text = "";
		}
		else if (list_0 != null)
		{
			base.Text = list_0[int_0];
		}
		else if (bool_6)
		{
			base.Text = DateTimeInput.GetActiveCulture().DateTimeFormat.AbbreviatedDayNames[int_0];
		}
		else
		{
			base.Text = DateTimeInput.GetActiveCulture().DateTimeFormat.DayNames[int_0];
		}
	}

	void IDateTimePartInput.UndoInput()
	{
	}
}

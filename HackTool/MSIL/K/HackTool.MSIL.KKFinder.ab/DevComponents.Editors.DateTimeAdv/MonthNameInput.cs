using System.Collections.Generic;
using System.ComponentModel;

namespace DevComponents.Editors.DateTimeAdv;

public class MonthNameInput : VisualStringListInput, IDateTimePartInput
{
	private List<string> list_1;

	private int int_1 = 1;

	private int int_2 = 12;

	private bool bool_13;

	int IDateTimePartInput.Value
	{
		get
		{
			return base.SelectedIndex + 1;
		}
		set
		{
			base.SelectedIndex = value - 1;
		}
	}

	int IDateTimePartInput.MinValue
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 != value)
			{
				int_1 = value;
				if (!IsEmpty && base.SelectedIndex < int_1)
				{
					base.SelectedIndex = int_1;
				}
			}
		}
	}

	int IDateTimePartInput.MaxValue
	{
		get
		{
			return int_2;
		}
		set
		{
			if (int_2 != value)
			{
				int_2 = value;
				if (!IsEmpty && base.SelectedIndex > int_2)
				{
					base.SelectedIndex = int_2;
				}
			}
		}
	}

	eDateTimePart IDateTimePartInput.Part => eDateTimePart.Month;

	[DefaultValue(false)]
	public bool UseAbbreviatedNames
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
				list_1 = null;
				InvalidateArrange();
			}
		}
	}

	protected override List<string> GetItems()
	{
		if (base.Items.Count != 12)
		{
			if (list_1 == null)
			{
				list_1 = new List<string>(12);
				if (bool_13)
				{
					list_1.AddRange(DateTimeInput.GetActiveCulture().DateTimeFormat.AbbreviatedMonthNames);
				}
				else
				{
					list_1.AddRange(DateTimeInput.GetActiveCulture().DateTimeFormat.MonthNames);
				}
				if (list_1.Count == 13 && list_1[12] == "")
				{
					list_1.RemoveAt(12);
				}
			}
			return list_1;
		}
		return base.GetItems();
	}

	protected override bool ValidateNewInputStack(string s)
	{
		if (s.Length > 0)
		{
			int result = 0;
			int.TryParse(s, out result);
			if (result > 0 && result >= int_1 && result <= int_2)
			{
				List<string> items = GetItems();
				base.LastMatch = items[result - 1];
				base.LastValidatedInputStack = s;
				if (result > 1)
				{
					base.LastMatchComplete = true;
				}
				return true;
			}
		}
		bool result2;
		if ((result2 = base.ValidateNewInputStack(s)) && base.LastValidatedInputStack.Length > 0)
		{
			List<string> items2 = GetItems();
			int num = items2.IndexOf(base.LastMatch) + 1;
			if (num < int_1 || num > int_2)
			{
				return false;
			}
		}
		return result2;
	}
}

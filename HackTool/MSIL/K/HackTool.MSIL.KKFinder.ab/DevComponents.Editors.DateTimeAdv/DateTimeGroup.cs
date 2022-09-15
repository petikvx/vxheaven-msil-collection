using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.Editors.DateTimeAdv;

public class DateTimeGroup : VisualInputGroup
{
	private IDateTimePartInput idateTimePartInput_0;

	private IDateTimePartInput idateTimePartInput_1;

	private IDateTimePartInput idateTimePartInput_2;

	private IDateTimePartInput idateTimePartInput_3;

	private IDateTimePartInput idateTimePartInput_4;

	private IDateTimePartInput idateTimePartInput_5;

	private IDateTimePartInput idateTimePartInput_6;

	public static readonly DateTime MinDateTime = new DateTime(1753, 1, 1);

	public static readonly DateTime MaxDateTime = new DateTime(9998, 12, 31);

	private EventHandler eventHandler_3;

	private bool bool_17;

	private bool bool_18;

	private DateTime dateTime_0;

	private bool bool_19;

	private bool bool_20;

	private DateTime dateTime_1 = MinDateTime;

	private DateTime dateTime_2 = MaxDateTime;

	private bool Boolean_0
	{
		get
		{
			foreach (VisualItem item in Items)
			{
				if (item is VisualGroup)
				{
					return true;
				}
			}
			return false;
		}
	}

	public DateTime Value
	{
		get
		{
			if (base.IsFocused)
			{
				UpdateValue(updateDirect: true);
			}
			return dateTime_0;
		}
		set
		{
			bool flag = dateTime_0 != value;
			dateTime_0 = value;
			base.IsEmpty = false;
			method_13();
			if (flag)
			{
				OnValueChanged();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DateTime[] Values
	{
		get
		{
			if (Boolean_0)
			{
				List<DateTime> list = new List<DateTime>();
				foreach (VisualItem item in Items)
				{
					if (item is DateTimeGroup dateTimeGroup)
					{
						list.Add(dateTimeGroup.Value);
					}
				}
				return list.ToArray();
			}
			return new DateTime[1] { Value };
		}
		set
		{
			if (value == null || value.Length == 0)
			{
				return;
			}
			if (Boolean_0)
			{
				int num = 0;
				{
					foreach (VisualItem item in Items)
					{
						if (item is DateTimeGroup dateTimeGroup)
						{
							dateTimeGroup.Value = value[num];
							num++;
							if (num >= value.Length)
							{
								break;
							}
						}
					}
					return;
				}
			}
			Value = value[0];
		}
	}

	public DateTime MinDate
	{
		get
		{
			return dateTime_1;
		}
		set
		{
			dateTime_1 = value;
			method_14();
		}
	}

	public DateTime MaxDate
	{
		get
		{
			return dateTime_2;
		}
		set
		{
			dateTime_2 = value;
			method_15();
		}
	}

	public event EventHandler ValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
		}
	}

	protected override void OnItemsCollectionChanged(CollectionChangedInfo collectionChangedInfo)
	{
		if (collectionChangedInfo.ChangeType == eCollectionChangeType.Cleared)
		{
			idateTimePartInput_0 = null;
			idateTimePartInput_1 = null;
			idateTimePartInput_2 = null;
			idateTimePartInput_3 = null;
			idateTimePartInput_4 = null;
			idateTimePartInput_5 = null;
			idateTimePartInput_6 = null;
		}
		if (collectionChangedInfo.Removed != null)
		{
			VisualItem[] removed = collectionChangedInfo.Removed;
			foreach (VisualItem visualItem in removed)
			{
				if (visualItem == idateTimePartInput_0)
				{
					idateTimePartInput_0 = null;
				}
				else if (visualItem == idateTimePartInput_1)
				{
					idateTimePartInput_1 = null;
				}
				else if (visualItem == idateTimePartInput_2)
				{
					idateTimePartInput_2 = null;
				}
				else if (visualItem == idateTimePartInput_3)
				{
					idateTimePartInput_3 = null;
				}
				else if (visualItem == idateTimePartInput_4)
				{
					idateTimePartInput_4 = null;
				}
				else if (visualItem == idateTimePartInput_5)
				{
					idateTimePartInput_5 = null;
				}
				else if (visualItem == idateTimePartInput_6)
				{
					idateTimePartInput_6 = null;
				}
			}
		}
		if (collectionChangedInfo.Added != null)
		{
			new List<VisualItem>();
			VisualItem[] added = collectionChangedInfo.Added;
			foreach (VisualItem visualItem2 in added)
			{
				if (visualItem2 is HourPeriodLabel)
				{
					if (idateTimePartInput_3 != null && idateTimePartInput_3 is NumericHourInput)
					{
						((HourPeriodLabel)visualItem2).HourInput = (NumericHourInput)idateTimePartInput_3;
					}
				}
				else if (visualItem2 is HourPeriodInput && idateTimePartInput_3 != null && idateTimePartInput_3 is NumericHourInput)
				{
					((HourPeriodInput)visualItem2).HourInput = (NumericHourInput)idateTimePartInput_3;
				}
				if (!(visualItem2 is IDateTimePartInput dateTimePartInput))
				{
					continue;
				}
				if (dateTimePartInput.Part == eDateTimePart.Day)
				{
					idateTimePartInput_0 = dateTimePartInput;
				}
				else if (dateTimePartInput.Part == eDateTimePart.Hour)
				{
					idateTimePartInput_3 = dateTimePartInput;
					if (!(idateTimePartInput_3 is NumericHourInput))
					{
						continue;
					}
					foreach (VisualItem item in Items)
					{
						if (item is HourPeriodLabel)
						{
							((HourPeriodLabel)item).HourInput = (NumericHourInput)idateTimePartInput_3;
						}
						else if (item is HourPeriodInput)
						{
							((HourPeriodInput)item).HourInput = (NumericHourInput)idateTimePartInput_3;
						}
					}
				}
				else if (dateTimePartInput.Part == eDateTimePart.Minute)
				{
					idateTimePartInput_4 = dateTimePartInput;
				}
				else if (dateTimePartInput.Part == eDateTimePart.Month)
				{
					idateTimePartInput_1 = dateTimePartInput;
				}
				else if (dateTimePartInput.Part == eDateTimePart.Second)
				{
					idateTimePartInput_5 = dateTimePartInput;
				}
				else if (dateTimePartInput.Part == eDateTimePart.Year)
				{
					idateTimePartInput_2 = dateTimePartInput;
				}
				else if (dateTimePartInput.Part == eDateTimePart.DayOfYear)
				{
					idateTimePartInput_6 = dateTimePartInput;
				}
			}
		}
		method_16();
		method_13();
		base.OnItemsCollectionChanged(collectionChangedInfo);
	}

	protected override void OnInputChanged(VisualInputBase input)
	{
		if (!bool_17 && !bool_20)
		{
			try
			{
				bool_17 = true;
				if ((input == idateTimePartInput_1 || input == idateTimePartInput_2) && idateTimePartInput_0 != null)
				{
					method_9();
				}
				if (input == idateTimePartInput_2 && idateTimePartInput_6 != null)
				{
					method_8();
				}
				if (input != idateTimePartInput_2 && idateTimePartInput_2 != null && idateTimePartInput_2.IsEmpty)
				{
					idateTimePartInput_2.Value = Math.Min(DateTime.Now.Year, dateTime_2.Year);
				}
				if (input != idateTimePartInput_1 && idateTimePartInput_1 != null && idateTimePartInput_1.IsEmpty)
				{
					if (idateTimePartInput_2 != null && idateTimePartInput_2.Value == dateTime_2.Year)
					{
						idateTimePartInput_1.Value = dateTime_2.Month;
					}
					else
					{
						idateTimePartInput_1.Value = DateTime.Now.Month;
					}
					method_9();
				}
				if (input != idateTimePartInput_0 && idateTimePartInput_0 != null && idateTimePartInput_0.IsEmpty)
				{
					if (idateTimePartInput_2 != null && idateTimePartInput_2.Value == dateTime_2.Year && idateTimePartInput_1 != null && idateTimePartInput_1.Value == dateTime_2.Month)
					{
						idateTimePartInput_0.Value = dateTime_2.Day;
					}
					else
					{
						idateTimePartInput_0.Value = DateTime.Now.Day;
					}
				}
				if (input != idateTimePartInput_3 && idateTimePartInput_3 != null && idateTimePartInput_3.IsEmpty)
				{
					idateTimePartInput_3.Value = 0;
				}
				if (input != idateTimePartInput_4 && idateTimePartInput_4 != null && idateTimePartInput_4.IsEmpty)
				{
					idateTimePartInput_4.Value = 0;
				}
				if (input != idateTimePartInput_5 && idateTimePartInput_5 != null && idateTimePartInput_5.IsEmpty)
				{
					idateTimePartInput_5.Value = 0;
				}
				if ((idateTimePartInput_2 != null && !idateTimePartInput_2.IsEmpty) || (idateTimePartInput_1 != null && !idateTimePartInput_1.IsEmpty) || (idateTimePartInput_0 != null && !idateTimePartInput_0.IsEmpty) || (idateTimePartInput_3 != null && !idateTimePartInput_3.IsEmpty) || (idateTimePartInput_4 != null && !idateTimePartInput_4.IsEmpty) || (idateTimePartInput_5 != null && !idateTimePartInput_5.IsEmpty))
				{
					base.IsEmpty = false;
				}
				method_10(input);
			}
			finally
			{
				bool_17 = false;
			}
			if (base.IsUserInput && method_11())
			{
				OnValueChanged();
			}
		}
		base.OnInputChanged(input);
	}

	private void method_8()
	{
		if (idateTimePartInput_2 != null && !idateTimePartInput_2.IsEmpty && idateTimePartInput_6 != null)
		{
			idateTimePartInput_6.MaxValue = DateTimeInput.GetActiveCulture().Calendar.GetDaysInYear(idateTimePartInput_2.Value);
		}
	}

	protected override void OnFocusedItemChanged(VisualItem previousFocus)
	{
		if (base.FocusedItem == idateTimePartInput_0 && idateTimePartInput_0 is NumericDayInput)
		{
			method_9();
		}
		else if (previousFocus != idateTimePartInput_2 && previousFocus != idateTimePartInput_0)
		{
			method_10(previousFocus);
		}
		else
		{
			method_9();
		}
		base.OnFocusedItemChanged(previousFocus);
	}

	private void method_9()
	{
		if (idateTimePartInput_0 != null && (base.FocusedItem == idateTimePartInput_0 || base.FocusedItem == idateTimePartInput_1) && idateTimePartInput_0 is NumericDayInput)
		{
			idateTimePartInput_0.MaxValue = 31;
		}
		else if (idateTimePartInput_2 != null && idateTimePartInput_1 != null && !idateTimePartInput_1.IsEmpty && idateTimePartInput_0 != null)
		{
			idateTimePartInput_0.MaxValue = DateTime.DaysInMonth(idateTimePartInput_2.IsEmpty ? DateTime.Now.Year : idateTimePartInput_2.Value, idateTimePartInput_1.Value);
		}
	}

	protected override void OnInputComplete()
	{
		method_10(base.FocusedItem);
		base.OnInputComplete();
	}

	protected override bool ValidateInput(VisualItem inputItem)
	{
		if (!bool_18 && inputItem is IDateTimePartInput && !base.IsEmpty)
		{
			IDateTimePartInput dateTimePartInput = (IDateTimePartInput)inputItem;
			DateTime dateTime = method_12();
			if (dateTime < dateTime_1 || dateTime > dateTime_2)
			{
				try
				{
					bool_18 = true;
					dateTimePartInput.UndoInput();
				}
				finally
				{
					bool_18 = false;
				}
				return false;
			}
		}
		return base.ValidateInput(inputItem);
	}

	private void method_10(VisualItem visualItem_3)
	{
		if (!(visualItem_3 is IDateTimePartInput dateTimePartInput))
		{
			return;
		}
		for (int i = 0; i < Items.Count; i++)
		{
			if (!(Items[i] is IDateTimePartInput dateTimePartInput2))
			{
				continue;
			}
			if (dateTimePartInput2.Part == dateTimePartInput.Part && dateTimePartInput2 != dateTimePartInput)
			{
				dateTimePartInput2.Value = dateTimePartInput.Value;
			}
			else if (dateTimePartInput2 != dateTimePartInput && dateTimePartInput.Part == eDateTimePart.DayOfYear && (dateTimePartInput2.Part == eDateTimePart.Day || dateTimePartInput2.Part == eDateTimePart.Month))
			{
				if (idateTimePartInput_2 != null && !idateTimePartInput_2.IsEmpty)
				{
					DateTime dateTime = smethod_0(idateTimePartInput_2.Value, dateTimePartInput.Value);
					if (dateTimePartInput2.Part == eDateTimePart.Day)
					{
						dateTimePartInput2.Value = dateTime.Day;
					}
					else if (dateTimePartInput2.Part == eDateTimePart.Month)
					{
						dateTimePartInput2.Value = dateTime.Month;
					}
				}
			}
			else
			{
				if (dateTimePartInput2.Part != eDateTimePart.DayName)
				{
					continue;
				}
				if (idateTimePartInput_2 != null && !idateTimePartInput_2.IsEmpty && ((idateTimePartInput_1 != null && !idateTimePartInput_1.IsEmpty && idateTimePartInput_0 != null && !idateTimePartInput_0.IsEmpty) || (idateTimePartInput_6 != null && !idateTimePartInput_6.IsEmpty)))
				{
					try
					{
						dateTimePartInput2.Value = (int)((idateTimePartInput_6 == null) ? new DateTime(idateTimePartInput_2.Value, idateTimePartInput_1.Value, idateTimePartInput_0.Value) : smethod_0(idateTimePartInput_2.Value, idateTimePartInput_6.Value)).DayOfWeek;
					}
					catch
					{
						dateTimePartInput2.IsEmpty = true;
					}
				}
				else
				{
					dateTimePartInput2.IsEmpty = true;
				}
			}
		}
	}

	internal static DateTime smethod_0(int int_1, int int_2)
	{
		DateTime result = new DateTime(int_1, 1, 1);
		if (int_2 > 0)
		{
			result.AddDays(int_2 - 1);
		}
		return result;
	}

	protected override void OnLostFocus()
	{
		UpdateValue(updateDirect: false);
		base.OnLostFocus();
	}

	protected override void OnGroupInputComplete()
	{
		UpdateValue(updateDirect: false);
		base.OnGroupInputComplete();
	}

	protected internal void UpdateValue(bool updateDirect)
	{
		DateTime now = DateTime.Now;
		if ((idateTimePartInput_2 != null && idateTimePartInput_2.IsEmpty) || (idateTimePartInput_1 != null && idateTimePartInput_1.IsEmpty) || (idateTimePartInput_0 != null && idateTimePartInput_0.IsEmpty) || (idateTimePartInput_3 != null && idateTimePartInput_3.IsEmpty) || (idateTimePartInput_4 != null && idateTimePartInput_4.IsEmpty) || (idateTimePartInput_5 != null && idateTimePartInput_5.IsEmpty))
		{
			if (Boolean_0)
			{
				UpdateIsEmpty();
			}
			else
			{
				base.IsEmpty = true;
			}
			return;
		}
		now = method_12();
		if (now > dateTime_2)
		{
			now = dateTime_2;
		}
		else if (now < dateTime_1)
		{
			now = dateTime_1;
		}
		if (updateDirect)
		{
			dateTime_0 = now;
		}
		else
		{
			Value = now;
		}
	}

	private bool method_11()
	{
		DateTime dateTime = method_12();
		if (!(dateTime < dateTime_1) && !(dateTime > dateTime_2))
		{
			return true;
		}
		return false;
	}

	private DateTime method_12()
	{
		DateTime now = DateTime.Now;
		if (now < dateTime_1)
		{
			now = dateTime_1;
		}
		else if (now > dateTime_2)
		{
			now = dateTime_2;
		}
		int num = now.Year;
		int month = now.Month;
		int num2 = now.Day;
		int num3 = now.Hour;
		int minute = now.Minute;
		int second = now.Second;
		int dayOfYear = now.DayOfYear;
		if (idateTimePartInput_2 != null)
		{
			num = idateTimePartInput_2.Value;
		}
		if (idateTimePartInput_1 != null)
		{
			month = idateTimePartInput_1.Value;
		}
		if (idateTimePartInput_0 != null)
		{
			num2 = idateTimePartInput_0.Value;
			num2 = Math.Min(num2, DateTime.DaysInMonth(idateTimePartInput_2.IsEmpty ? DateTime.Now.Year : idateTimePartInput_2.Value, idateTimePartInput_1.Value));
		}
		if (idateTimePartInput_3 != null)
		{
			num3 = idateTimePartInput_3.Value;
			if (num3 == 12 && idateTimePartInput_3 is NumericHourInput && ((NumericHourInput)idateTimePartInput_3).Period == eHourPeriod.AM && !((NumericHourInput)idateTimePartInput_3).Is24HourFormat)
			{
				num3 = 0;
			}
			else if (num3 < 12 && idateTimePartInput_3 is NumericHourInput && ((NumericHourInput)idateTimePartInput_3).Period == eHourPeriod.PM && !((NumericHourInput)idateTimePartInput_3).Is24HourFormat)
			{
				num3 += 12;
			}
		}
		if (idateTimePartInput_4 != null)
		{
			minute = idateTimePartInput_4.Value;
		}
		second = ((idateTimePartInput_5 != null) ? idateTimePartInput_5.Value : 0);
		if (idateTimePartInput_6 != null)
		{
			dayOfYear = idateTimePartInput_6.Value;
			if (dayOfYear > 0)
			{
				DateTime dateTime = smethod_0(num, dayOfYear);
				month = dateTime.Month;
				num2 = dateTime.Day;
			}
		}
		if (DateTime.DaysInMonth(num, month) < num2)
		{
			num2 = DateTime.DaysInMonth(num, month);
		}
		return (idateTimePartInput_3 == null) ? new DateTime(num, month, num2) : new DateTime(num, month, num2, num3, minute, second);
	}

	protected virtual void OnValueChanged()
	{
		if (bool_19)
		{
			return;
		}
		try
		{
			bool_19 = true;
			if (eventHandler_3 != null)
			{
				eventHandler_3(this, new EventArgs());
			}
			if (base.Parent is DateTimeGroup)
			{
				((DateTimeGroup)base.Parent).OnValueChanged();
			}
			InvalidateArrange();
		}
		finally
		{
			bool_19 = false;
		}
	}

	private void method_13()
	{
		DateTime dateTime = dateTime_0;
		if (idateTimePartInput_2 != null)
		{
			if (base.IsEmpty)
			{
				idateTimePartInput_2.IsEmpty = true;
			}
			else
			{
				idateTimePartInput_2.Value = dateTime.Year;
			}
		}
		if (idateTimePartInput_1 != null)
		{
			if (base.IsEmpty)
			{
				idateTimePartInput_1.IsEmpty = true;
			}
			else
			{
				idateTimePartInput_1.Value = dateTime.Month;
			}
		}
		if (idateTimePartInput_0 != null)
		{
			if (base.IsEmpty)
			{
				idateTimePartInput_0.IsEmpty = true;
			}
			else if (base.FocusedItem != idateTimePartInput_0 || !(idateTimePartInput_0 is NumericDayInput) || !bool_17)
			{
				idateTimePartInput_0.Value = dateTime.Day;
			}
		}
		if (idateTimePartInput_3 != null)
		{
			if (base.IsEmpty)
			{
				idateTimePartInput_3.IsEmpty = true;
			}
			else
			{
				if (idateTimePartInput_3 is NumericHourInput)
				{
					((NumericHourInput)idateTimePartInput_3).Period = eHourPeriod.AM;
				}
				idateTimePartInput_3.Value = dateTime.Hour;
				if (idateTimePartInput_3 is NumericHourInput && !((NumericHourInput)idateTimePartInput_3).Is24HourFormat && dateTime.Hour >= 12)
				{
					((NumericHourInput)idateTimePartInput_3).Period = eHourPeriod.PM;
				}
			}
		}
		if (idateTimePartInput_4 != null)
		{
			if (base.IsEmpty)
			{
				idateTimePartInput_4.IsEmpty = true;
			}
			else
			{
				idateTimePartInput_4.Value = dateTime.Minute;
			}
		}
		if (idateTimePartInput_5 != null)
		{
			if (base.IsEmpty)
			{
				idateTimePartInput_5.IsEmpty = true;
			}
			else
			{
				idateTimePartInput_5.Value = dateTime.Second;
			}
		}
		for (int i = 0; i < Items.Count; i++)
		{
			if (!(Items[i] is IDateTimePartInput dateTimePartInput))
			{
				continue;
			}
			if (dateTimePartInput.Part == eDateTimePart.DayName)
			{
				dateTimePartInput.Value = (int)(base.IsEmpty ? ((DayOfWeek)(-1)) : dateTime_0.DayOfWeek);
			}
			else if (dateTimePartInput.Part == eDateTimePart.DayOfYear)
			{
				if (base.IsEmpty)
				{
					dateTimePartInput.IsEmpty = true;
				}
				else
				{
					dateTimePartInput.Value = dateTime_0.DayOfYear;
				}
			}
		}
		InvalidateArrange();
	}

	protected override void ResetValue()
	{
		bool_20 = true;
		try
		{
			if (base.AllowEmptyState)
			{
				if (idateTimePartInput_0 != null)
				{
					idateTimePartInput_0.IsEmpty = true;
				}
				if (idateTimePartInput_1 != null)
				{
					idateTimePartInput_1.IsEmpty = true;
				}
				if (idateTimePartInput_2 != null)
				{
					idateTimePartInput_2.IsEmpty = true;
				}
				if (idateTimePartInput_3 != null)
				{
					idateTimePartInput_3.IsEmpty = true;
				}
				if (idateTimePartInput_4 != null)
				{
					idateTimePartInput_4.IsEmpty = true;
				}
				if (idateTimePartInput_5 != null)
				{
					idateTimePartInput_5.IsEmpty = true;
				}
				foreach (VisualItem item in Items)
				{
					if (item is DateTimeGroup)
					{
						((DateTimeGroup)item).IsEmpty = true;
					}
					else if (item is IDateTimePartInput && !((IDateTimePartInput)item).IsEmpty)
					{
						((IDateTimePartInput)item).IsEmpty = true;
					}
				}
				dateTime_0 = DateTime.MinValue;
			}
			else
			{
				method_17();
			}
		}
		finally
		{
			bool_20 = false;
		}
		OnValueChanged();
	}

	private void method_14()
	{
		method_16();
	}

	private void method_15()
	{
		method_16();
	}

	private void method_16()
	{
		foreach (VisualItem item in Items)
		{
			if (item is DateTimeGroup dateTimeGroup)
			{
				dateTimeGroup.MinDate = dateTime_1;
				dateTimeGroup.MaxDate = dateTime_2;
			}
		}
	}

	protected override void OnAllowEmptyStateChanged()
	{
		if (!base.AllowEmptyState && base.IsEmpty)
		{
			method_17();
		}
		base.OnAllowEmptyStateChanged();
	}

	private void method_17()
	{
		if (MinDate > MinDateTime)
		{
			Value = MinDate;
		}
		else
		{
			Value = DateTime.Now;
		}
	}

	internal override void vmethod_8(KeyEventArgs keyEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)keyEventArgs_0.get_KeyCode() != 8 && (int)keyEventArgs_0.get_KeyCode() != 46)
		{
			base.IsUserInput = true;
		}
		base.vmethod_8(keyEventArgs_0);
		base.IsUserInput = false;
	}

	internal override void vmethod_10(KeyPressEventArgs keyPressEventArgs_0)
	{
		base.IsUserInput = true;
		base.vmethod_10(keyPressEventArgs_0);
		base.IsUserInput = false;
	}

	internal override bool vmethod_11(ref Message message_0, Keys keys_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		base.IsUserInput = true;
		bool result = base.vmethod_11(ref message_0, keys_0);
		base.IsUserInput = false;
		return result;
	}

	internal override void vmethod_3(MouseEventArgs mouseEventArgs_0)
	{
		base.IsUserInput = true;
		base.vmethod_3(mouseEventArgs_0);
		base.IsUserInput = false;
	}
}

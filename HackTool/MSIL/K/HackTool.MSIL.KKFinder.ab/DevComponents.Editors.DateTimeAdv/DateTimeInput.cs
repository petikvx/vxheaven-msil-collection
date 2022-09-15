using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Editors.Design;

namespace DevComponents.Editors.DateTimeAdv;

[ToolboxItem(true)]
[ToolboxBitmap(typeof(DotNetBarManager), "DateTimeInput.ico")]
[Designer(typeof(DateTimeInputDesigner))]
public class DateTimeInput : VisualControlBase, ICommandSource
{
	private DateTimeGroup dateTimeGroup_0;

	private ButtonItem buttonItem_0;

	private MonthCalendarItem monthCalendarItem_0;

	private EventHandler eventHandler_7;

	private EventHandler eventHandler_8;

	private EventHandler eventHandler_9;

	private CancelEventHandler cancelEventHandler_0;

	private CancelEventHandler cancelEventHandler_1;

	private ParseDateTimeValueEventHandler parseDateTimeValueEventHandler_0;

	private EventHandler eventHandler_10;

	private bool bool_9;

	private bool bool_10;

	private eDateTimePickerFormat eDateTimePickerFormat_0 = eDateTimePickerFormat.Short;

	private string string_1 = "";

	private static CultureInfo cultureInfo_0;

	private bool bool_11 = true;

	private InputButtonSettings inputButtonSettings_2;

	private InputButtonSettings inputButtonSettings_3;

	private DateTime dateTime_0 = DateTime.MinValue;

	private bool bool_12;

	private bool bool_13;

	private ICommand icommand_0;

	private object object_0;

	protected override bool IsWatermarkRendered
	{
		get
		{
			if (!((Control)this).get_Focused())
			{
				return dateTimeGroup_0.IsEmpty;
			}
			return false;
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether a check box is displayed to the left of the input value which allows locking of the control.")]
	public bool ShowCheckBox
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
			method_18();
		}
	}

	[DefaultValue(false)]
	public bool ShowUpDown
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
			method_18();
		}
	}

	[Bindable(BindableSupport.Yes)]
	[Description("Indicates date time value of the control")]
	public DateTime Value
	{
		get
		{
			return dateTimeGroup_0.Value;
		}
		set
		{
			if (AllowEmptyState && value.Equals(new DateTime(0L)))
			{
				IsEmpty = true;
			}
			else
			{
				dateTimeGroup_0.Value = value;
			}
		}
	}

	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			ValueObject = value;
		}
	}

	[TypeConverter(typeof(DateTimeConverter))]
	[RefreshProperties(RefreshProperties.All)]
	[Bindable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public object ValueObject
	{
		get
		{
			if (IsEmpty)
			{
				return null;
			}
			return Value;
		}
		set
		{
			if (method_17(value))
			{
				return;
			}
			if (!IsNull(value) && (!(value is string) || value != ""))
			{
				if (value is DateTime)
				{
					Value = (DateTime)value;
					return;
				}
				if (!(value is string))
				{
					throw new ArgumentException("ValueObject property expects either null/nothing value or DateTime type.");
				}
				DateTime result = default(DateTime);
				if (!DateTime.TryParse(value.ToString(), out result))
				{
					throw new ArgumentException("ValueObject property expects either null/nothing value or DateTime type.");
				}
				Value = result;
			}
			else
			{
				IsEmpty = true;
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DateTime[] Values
	{
		get
		{
			return dateTimeGroup_0.Values;
		}
		set
		{
			dateTimeGroup_0.Values = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether empty null/nothing state of the control is allowed.")]
	public bool AllowEmptyState
	{
		get
		{
			return dateTimeGroup_0.AllowEmptyState;
		}
		set
		{
			dateTimeGroup_0.AllowEmptyState = value;
			((Control)this).Invalidate();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool IsEmpty
	{
		get
		{
			return dateTimeGroup_0.IsEmpty;
		}
		set
		{
			dateTimeGroup_0.IsEmpty = value;
		}
	}

	[Description("Indicates minimum date and time that can be selected in the control.")]
	public DateTime MinDate
	{
		get
		{
			return dateTimeGroup_0.MinDate;
		}
		set
		{
			dateTimeGroup_0.MinDate = value;
		}
	}

	[Description("Indicates maximum date and time that can be selected in the control.")]
	public DateTime MaxDate
	{
		get
		{
			return dateTimeGroup_0.MaxDate;
		}
		set
		{
			dateTimeGroup_0.MaxDate = value;
		}
	}

	[DefaultValue(eDateTimePickerFormat.Short)]
	public eDateTimePickerFormat Format
	{
		get
		{
			return eDateTimePickerFormat_0;
		}
		set
		{
			if (eDateTimePickerFormat_0 != value)
			{
				eDateTimePickerFormat_0 = value;
				method_18();
			}
		}
	}

	[Description("Indicates the custom date/time format string. ")]
	[Localizable(true)]
	[DefaultValue("")]
	public string CustomFormat
	{
		get
		{
			return string_1;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			if (value != string_1)
			{
				string_1 = value;
				method_18();
			}
		}
	}

	public static CultureInfo CurrentCulture
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether auto-overwrite functionality for input is enabled.")]
	public bool AutoOverwrite
	{
		get
		{
			return dateTimeGroup_0.AutoOverwrite;
		}
		set
		{
			dateTimeGroup_0.AutoOverwrite = value;
		}
	}

	private LockUpdateCheckBox LockUpdateCheckBox_0
	{
		get
		{
			if (dateTimeGroup_0.Items[0] is LockUpdateCheckBox)
			{
				return (LockUpdateCheckBox)dateTimeGroup_0.Items[0];
			}
			return null;
		}
	}

	[Description("Indicates whether check box shown using ShowCheckBox property which locks/unlocks the control update is checked.")]
	[DefaultValue(true)]
	public bool LockUpdateChecked
	{
		get
		{
			return bool_11;
		}
		set
		{
			if (bool_11 != value)
			{
				bool_11 = value;
				LockUpdateCheckBox lockUpdateCheckBox_ = LockUpdateCheckBox_0;
				if (lockUpdateCheckBox_ != null)
				{
					lockUpdateCheckBox_.Checked = bool_11;
				}
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Buttons")]
	[Description("Describes the settings for the button that shows drop-down calendar when clicked.")]
	public InputButtonSettings ButtonDropDown => inputButtonSettings_2;

	[Category("Buttons")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Describes the settings for the button that clears the content of the control when clicked.")]
	public InputButtonSettings ButtonClear => inputButtonSettings_3;

	[DefaultValue(false)]
	[Description("Indicates whether input part of the control is read-only.")]
	public bool IsInputReadOnly
	{
		get
		{
			return dateTimeGroup_0.IsReadOnly;
		}
		set
		{
			dateTimeGroup_0.IsReadOnly = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets the reference to the internal MonthCalendarAdv control which is used to display calendar when drop-down is open.")]
	public MonthCalendarItem MonthCalendar => monthCalendarItem_0;

	protected override Size DefaultSize => new Size(200, base.DefaultSize.Height);

	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Behavior")]
	[Description("Indicates whether first day in month is automatically selected on popup date picker when month or year is changed.")]
	public bool AutoSelectDate
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
		}
	}

	[Description("Indicates whether input focus is automatically advanced to next input field when input is complete in current one.")]
	[DefaultValue(false)]
	[Category("Behavior")]
	public bool AutoAdvance
	{
		get
		{
			return dateTimeGroup_0.AutoAdvance;
		}
		set
		{
			if (dateTimeGroup_0.AutoAdvance != value)
			{
				dateTimeGroup_0.AutoAdvance = value;
			}
		}
	}

	[Description("List of characters that when pressed would select next input field.")]
	[DefaultValue("")]
	[Category("Behavior")]
	public string SelectNextInputCharacters
	{
		get
		{
			return dateTimeGroup_0.SelectNextInputCharacters;
		}
		set
		{
			if (dateTimeGroup_0.SelectNextInputCharacters != value)
			{
				dateTimeGroup_0.SelectNextInputCharacters = value;
			}
		}
	}

	[DefaultValue(null)]
	[Category("Commands")]
	[Description("Indicates the command assigned to the item.")]
	public Command Command
	{
		get
		{
			return (Command)((ICommandSource)this).Command;
		}
		set
		{
			((ICommandSource)this).Command = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	ICommand ICommandSource.Command
	{
		get
		{
			return icommand_0;
		}
		set
		{
			bool flag = false;
			if (icommand_0 != value)
			{
				flag = true;
			}
			if (icommand_0 != null)
			{
				CommandManager.UnRegisterCommandSource(this, icommand_0);
			}
			icommand_0 = value;
			if (value != null)
			{
				CommandManager.RegisterCommand(this, value);
			}
			if (flag)
			{
				OnCommandChanged();
			}
		}
	}

	[TypeConverter(typeof(StringConverter))]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[Localizable(true)]
	[Category("Commands")]
	[Browsable(true)]
	[DefaultValue(null)]
	public object CommandParameter
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	public event EventHandler ValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_7 = (EventHandler)Delegate.Combine(eventHandler_7, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_7 = (EventHandler)Delegate.Remove(eventHandler_7, value);
		}
	}

	public event EventHandler ValueObjectChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_8 = (EventHandler)Delegate.Combine(eventHandler_8, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_8 = (EventHandler)Delegate.Remove(eventHandler_8, value);
		}
	}

	public event EventHandler FormatChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_9 = (EventHandler)Delegate.Combine(eventHandler_9, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_9 = (EventHandler)Delegate.Remove(eventHandler_9, value);
		}
	}

	public event CancelEventHandler ButtonClearClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_0, value);
		}
	}

	public event CancelEventHandler ButtonDropDownClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_1, value);
		}
	}

	public event ParseDateTimeValueEventHandler ParseValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			parseDateTimeValueEventHandler_0 = (ParseDateTimeValueEventHandler)Delegate.Combine(parseDateTimeValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			parseDateTimeValueEventHandler_0 = (ParseDateTimeValueEventHandler)Delegate.Remove(parseDateTimeValueEventHandler_0, value);
		}
	}

	public event EventHandler LockUpdateChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_10 = (EventHandler)Delegate.Combine(eventHandler_10, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_10 = (EventHandler)Delegate.Remove(eventHandler_10, value);
		}
	}

	protected override PopupItem CreatePopupItem()
	{
		ButtonItem buttonItem = new ButtonItem("sysPopupProvider");
		buttonItem.PopupClose += method_24;
		MonthCalendarItem monthCalendarItem = new MonthCalendarItem();
		monthCalendarItem.BackgroundStyle.BackColor = SystemColors.Window;
		monthCalendarItem.DateChanged += method_16;
		buttonItem.SubItems.Add(monthCalendarItem);
		buttonItem_0 = buttonItem;
		monthCalendarItem_0 = monthCalendarItem;
		return buttonItem;
	}

	private void method_16(object sender, EventArgs e)
	{
		if (monthCalendarItem_0.SelectedDate == DateTime.MinValue)
		{
			IsEmpty = true;
			return;
		}
		DateTime dateTime = monthCalendarItem_0.SelectedDate;
		if (MinDate != DateTime.MinValue && dateTime < MinDate)
		{
			dateTime = MinDate;
		}
		dateTimeGroup_0.Value = dateTime;
	}

	protected override VisualItem CreateRootVisual()
	{
		inputButtonSettings_3 = new InputButtonSettings(this);
		inputButtonSettings_2 = new InputButtonSettings(this);
		dateTimeGroup_0 = new DateTimeGroup();
		dateTimeGroup_0.IsRootVisual = true;
		dateTimeGroup_0.ValueChanged += dateTimeGroup_0_ValueChanged;
		method_19();
		return dateTimeGroup_0;
	}

	private void dateTimeGroup_0_ValueChanged(object sender, EventArgs e)
	{
		OnValueChanged(e);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeValue()
	{
		if (!AllowEmptyState && Value.Date == DateTime.Today)
		{
			return false;
		}
		return !dateTimeGroup_0.IsEmpty;
	}

	public void ResetValue()
	{
		if (AllowEmptyState)
		{
			IsEmpty = true;
		}
		else
		{
			Value = DateTime.Now;
		}
	}

	private bool method_17(object object_1)
	{
		ParseDateTimeValueEventArgs parseDateTimeValueEventArgs = new ParseDateTimeValueEventArgs(object_1);
		OnParseValue(parseDateTimeValueEventArgs);
		if (parseDateTimeValueEventArgs.IsParsed)
		{
			Value = parseDateTimeValueEventArgs.ParsedValue;
		}
		return parseDateTimeValueEventArgs.IsParsed;
	}

	protected virtual void OnParseValue(ParseDateTimeValueEventArgs e)
	{
		if (parseDateTimeValueEventHandler_0 != null)
		{
			parseDateTimeValueEventHandler_0(this, e);
		}
	}

	public bool ShouldSerializeMinDate()
	{
		return !MinDate.Equals(DateTimeGroup.MinDateTime);
	}

	public void ResetMinDate()
	{
		MinDate = DateTimeGroup.MinDateTime;
	}

	public bool ShouldSerializeMaxDate()
	{
		return !dateTimeGroup_0.MaxDate.Equals(DateTimeGroup.MaxDateTime);
	}

	public void ResetMaxDate()
	{
		MaxDate = DateTimeGroup.MaxDateTime;
	}

	private void method_18()
	{
		method_19();
		((Control)this).Invalidate();
		if (eventHandler_9 != null)
		{
			eventHandler_9(this, new EventArgs());
		}
	}

	private void method_19()
	{
		if (string_1.Length > 0 && eDateTimePickerFormat_0 == eDateTimePickerFormat.Custom)
		{
			method_21(CustomFormat);
		}
		else if (eDateTimePickerFormat_0 != 0)
		{
			method_21(method_20(eDateTimePickerFormat_0));
		}
		else
		{
			dateTimeGroup_0.Items.Clear();
		}
	}

	private string method_20(eDateTimePickerFormat eDateTimePickerFormat_1)
	{
		return eDateTimePickerFormat_1 switch
		{
			eDateTimePickerFormat.Long => GetActiveCulture().DateTimeFormat.LongDatePattern, 
			eDateTimePickerFormat.Short => GetActiveCulture().DateTimeFormat.ShortDatePattern, 
			eDateTimePickerFormat.ShortTime => GetActiveCulture().DateTimeFormat.ShortTimePattern, 
			eDateTimePickerFormat.LongTime => GetActiveCulture().DateTimeFormat.LongTimePattern, 
			_ => "", 
		};
	}

	public static CultureInfo GetActiveCulture()
	{
		if (cultureInfo_0 == null)
		{
			return CultureInfo.CurrentCulture;
		}
		return cultureInfo_0;
	}

	private void method_21(string string_2)
	{
		dateTimeGroup_0.Items.Clear();
		if (bool_9)
		{
			LockUpdateCheckBox lockUpdateCheckBox = new LockUpdateCheckBox();
			dateTimeGroup_0.Items.Add(lockUpdateCheckBox);
			lockUpdateCheckBox.CheckedChanged += method_22;
		}
		if (string_2.Length == 0)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(string_2.Length);
		bool flag = false;
		Stack<VisualGroup> stack = new Stack<VisualGroup>();
		VisualGroup visualGroup = dateTimeGroup_0;
		for (int i = 0; i < string_2.Length; i++)
		{
			if (string_2[i] == '\'')
			{
				flag = ((!flag) ? true : false);
				continue;
			}
			if (flag)
			{
				stringBuilder.Append(string_2[i]);
				continue;
			}
			string text = string_2.Substring(i, Math.Min(4, string_2.Length - i));
			bool flag2 = false;
			switch (text)
			{
			case "dddd":
			{
				DayLabelItem item3 = new DayLabelItem();
				visualGroup.Items.Add(item3);
				i += 3;
				flag2 = true;
				break;
			}
			case "MMMM":
			{
				MonthNameInput item2 = new MonthNameInput();
				visualGroup.Items.Add(item2);
				i += 3;
				flag2 = true;
				break;
			}
			case "yyyy":
			{
				NumericYearInput item = new NumericYearInput();
				visualGroup.Items.Add(item);
				i += 3;
				flag2 = true;
				break;
			}
			}
			if (!flag2)
			{
				switch (string_2.Substring(i, Math.Min(3, string_2.Length - i)))
				{
				case "ddd":
				{
					DayLabelItem dayLabelItem = new DayLabelItem();
					dayLabelItem.UseAbbreviatedNames = true;
					visualGroup.Items.Add(dayLabelItem);
					i += 2;
					flag2 = true;
					break;
				}
				case "MMM":
				{
					MonthNameInput monthNameInput = new MonthNameInput();
					monthNameInput.UseAbbreviatedNames = true;
					visualGroup.Items.Add(monthNameInput);
					i += 2;
					flag2 = true;
					break;
				}
				case "jjj":
				{
					NumericDayOfYearInput numericDayOfYearInput = new NumericDayOfYearInput();
					numericDayOfYearInput.DisplayFormat = "000";
					visualGroup.Items.Add(numericDayOfYearInput);
					i += 2;
					flag2 = true;
					break;
				}
				}
			}
			if (!flag2)
			{
				switch (string_2.Substring(i, Math.Min(2, string_2.Length - i)))
				{
				case "dd":
				{
					NumericDayInput numericDayInput = new NumericDayInput();
					numericDayInput.DisplayFormat = "00";
					visualGroup.Items.Add(numericDayInput);
					i++;
					flag2 = true;
					break;
				}
				case "hh":
				{
					NumericHourInput numericHourInput2 = new NumericHourInput();
					numericHourInput2.DisplayFormat = "00";
					numericHourInput2.Is24HourFormat = false;
					visualGroup.Items.Add(numericHourInput2);
					i++;
					flag2 = true;
					break;
				}
				case "HH":
				{
					NumericHourInput numericHourInput = new NumericHourInput();
					numericHourInput.DisplayFormat = "00";
					numericHourInput.Is24HourFormat = true;
					visualGroup.Items.Add(numericHourInput);
					i++;
					flag2 = true;
					break;
				}
				case "mm":
				{
					NumericMinuteInput numericMinuteInput = new NumericMinuteInput();
					numericMinuteInput.DisplayFormat = "00";
					visualGroup.Items.Add(numericMinuteInput);
					i++;
					flag2 = true;
					break;
				}
				case "MM":
				{
					NumericMonthInput numericMonthInput = new NumericMonthInput();
					numericMonthInput.DisplayFormat = "00";
					visualGroup.Items.Add(numericMonthInput);
					i++;
					flag2 = true;
					break;
				}
				case "ss":
				{
					NumericSecondInput numericSecondInput = new NumericSecondInput();
					numericSecondInput.DisplayFormat = "00";
					visualGroup.Items.Add(numericSecondInput);
					i++;
					flag2 = true;
					break;
				}
				case "tt":
				{
					HourPeriodInput item4 = new HourPeriodInput();
					visualGroup.Items.Add(item4);
					i++;
					flag2 = true;
					break;
				}
				case "yy":
				{
					NumericYearInput numericYearInput = new NumericYearInput();
					numericYearInput.YearDisplayFormat = eYearDisplayFormat.TwoDigit;
					visualGroup.Items.Add(numericYearInput);
					i++;
					flag2 = true;
					break;
				}
				}
			}
			if (!flag2)
			{
				switch (string_2[i].ToString())
				{
				case "d":
				{
					NumericDayInput item5 = new NumericDayInput();
					visualGroup.Items.Add(item5);
					flag2 = true;
					break;
				}
				case "h":
				{
					NumericHourInput numericHourInput3 = new NumericHourInput();
					numericHourInput3.Is24HourFormat = false;
					visualGroup.Items.Add(numericHourInput3);
					flag2 = true;
					break;
				}
				case "H":
				{
					NumericHourInput numericHourInput4 = new NumericHourInput();
					numericHourInput4.Is24HourFormat = true;
					visualGroup.Items.Add(numericHourInput4);
					flag2 = true;
					break;
				}
				case "m":
				{
					NumericMinuteInput item9 = new NumericMinuteInput();
					visualGroup.Items.Add(item9);
					flag2 = true;
					break;
				}
				case "M":
				{
					NumericMonthInput item8 = new NumericMonthInput();
					visualGroup.Items.Add(item8);
					flag2 = true;
					break;
				}
				case "s":
				{
					NumericSecondInput item7 = new NumericSecondInput();
					visualGroup.Items.Add(item7);
					flag2 = true;
					break;
				}
				case "t":
				{
					HourPeriodInput hourPeriodInput = new HourPeriodInput();
					hourPeriodInput.UseSingleLetterLabel = true;
					visualGroup.Items.Add(hourPeriodInput);
					flag2 = true;
					break;
				}
				case "y":
				{
					NumericYearInput numericYearInput2 = new NumericYearInput();
					numericYearInput2.YearDisplayFormat = eYearDisplayFormat.OneDigit;
					visualGroup.Items.Add(numericYearInput2);
					flag2 = true;
					break;
				}
				case "j":
				{
					NumericDayOfYearInput item6 = new NumericDayOfYearInput();
					visualGroup.Items.Add(item6);
					flag2 = true;
					break;
				}
				case "{":
				{
					if (stringBuilder.Length > 0)
					{
						VisualLabel visualLabel = new VisualLabel();
						visualLabel.Text = stringBuilder.ToString();
						visualGroup.Items.Add(visualLabel);
						stringBuilder = new StringBuilder(string_2.Length);
					}
					DateTimeGroup dateTimeGroup = new DateTimeGroup();
					visualGroup.Items.Add(dateTimeGroup);
					stack.Push(visualGroup);
					visualGroup = dateTimeGroup;
					flag2 = true;
					break;
				}
				case "}":
					visualGroup = stack.Pop();
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				if (stringBuilder.Length > 0)
				{
					VisualLabel visualLabel2 = new VisualLabel();
					visualLabel2.Text = stringBuilder.ToString();
					visualGroup.Items.Insert(visualGroup.Items.Count - 1, visualLabel2);
					stringBuilder = new StringBuilder(string_2.Length);
				}
			}
			else
			{
				stringBuilder.Append(string_2[i]);
			}
		}
		if (stringBuilder.Length > 0)
		{
			VisualLabel visualLabel3 = new VisualLabel();
			visualLabel3.Text = stringBuilder.ToString();
			visualGroup.Items.Add(visualLabel3);
		}
		RecreateButtons();
		if (bool_10)
		{
			VisualUpDownButton visualUpDownButton = new VisualUpDownButton();
			visualUpDownButton.Alignment = eItemAlignment.Right;
			visualUpDownButton.AutoChange = eUpDownButtonAutoChange.FocusedItem;
			dateTimeGroup_0.Items.Add(visualUpDownButton);
		}
		if (bool_9)
		{
			LockUpdateCheckBox_0.Checked = bool_11;
		}
	}

	private void method_22(object sender, EventArgs e)
	{
		LockUpdateCheckBox lockUpdateCheckBox_ = LockUpdateCheckBox_0;
		if (lockUpdateCheckBox_ != null)
		{
			bool_11 = lockUpdateCheckBox_.Checked;
		}
		OnLockUpdateChanged(e);
	}

	protected virtual void OnLockUpdateChanged(EventArgs e)
	{
		if (eventHandler_10 != null)
		{
			eventHandler_10(this, e);
		}
	}

	protected virtual void OnValueChanged(EventArgs e)
	{
		if (IsInitializing)
		{
			return;
		}
		if (eventHandler_7 != null)
		{
			eventHandler_7(this, e);
		}
		if (eventHandler_8 != null)
		{
			eventHandler_8(this, e);
		}
		if (IsEmpty)
		{
			base.Text = "";
		}
		else
		{
			string text = "";
			text = ((Format != 0) ? method_20(Format) : CustomFormat);
			if (text == "")
			{
				text = method_20(eDateTimePickerFormat.Short);
			}
			if (text == "")
			{
				base.Text = Value.ToString();
			}
			else
			{
				try
				{
					base.Text = Value.ToString(text);
				}
				catch
				{
					base.Text = "";
				}
			}
		}
		ExecuteCommand();
	}

	protected override void OnValidating(CancelEventArgs e)
	{
		dateTimeGroup_0.UpdateValue(updateDirect: false);
		((Control)this).OnValidating(e);
	}

	protected override SortedList CreateSortedButtonList()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		SortedList sortedList = base.CreateSortedButtonList();
		if (inputButtonSettings_3.Visible)
		{
			VisualItem visualItem = CreateButton(inputButtonSettings_3);
			if (inputButtonSettings_3.ItemReference != null)
			{
				inputButtonSettings_3.ItemReference.Click -= method_25;
			}
			inputButtonSettings_3.ItemReference = visualItem;
			visualItem.Click += method_25;
			sortedList.Add(inputButtonSettings_3, visualItem);
		}
		if (inputButtonSettings_2.Visible)
		{
			VisualItem visualItem2 = CreateButton(inputButtonSettings_2);
			if (inputButtonSettings_2.ItemReference != null)
			{
				inputButtonSettings_2.ItemReference.MouseDown -= new MouseEventHandler(method_23);
			}
			inputButtonSettings_2.ItemReference = visualItem2;
			visualItem2.MouseDown += new MouseEventHandler(method_23);
			sortedList.Add(inputButtonSettings_2, visualItem2);
		}
		return sortedList;
	}

	private void method_23(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.get_Button() == 1048576 && (!(dateTime_0 != DateTime.MinValue) || DateTime.Now.Subtract(dateTime_0).TotalMilliseconds >= 150.0))
		{
			CancelEventArgs cancelEventArgs = new CancelEventArgs();
			OnButtonDropDownClick(cancelEventArgs);
			if (!cancelEventArgs.Cancel)
			{
				buttonItem_0.method_4(((Control)this).get_ClientRectangle());
				if (((Control)this).get_Font().get_Height() > monthCalendarItem_0.DaySize.Height)
				{
					monthCalendarItem_0.DaySize = new Size((int)Math.Ceiling((float)((Control)this).get_Font().get_Height() * 1.6f), ((Control)this).get_Font().get_Height() + 1);
				}
				if ((int)((Control)this).get_RightToLeft() == 0)
				{
					buttonItem_0.PopupLocation = new Point(((Control)this).get_Width() - buttonItem_0.PopupSize.Width, ((Control)this).get_Height());
				}
				if (MinDate != DateTime.MinValue)
				{
					monthCalendarItem_0.MinDate = MinDate;
				}
				else
				{
					monthCalendarItem_0.MinDate = MinDate;
				}
				monthCalendarItem_0.MaxDate = MaxDate;
				if (!IsEmpty)
				{
					monthCalendarItem_0.SelectedDate = Value;
				}
				else
				{
					monthCalendarItem_0.SelectedDate = DateTime.MinValue;
				}
				if (monthCalendarItem_0.SelectedDate != DateTime.MinValue)
				{
					monthCalendarItem_0.DisplayMonth = monthCalendarItem_0.SelectedDate;
				}
				else
				{
					monthCalendarItem_0.DisplayMonth = DateTime.Today;
				}
				buttonItem_0.Expanded = !buttonItem_0.Expanded;
			}
		}
		else
		{
			dateTime_0 = DateTime.MinValue;
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		dateTime_0 = DateTime.Now;
	}

	private void method_25(object sender, EventArgs e)
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnButtonClearClick(cancelEventArgs);
		if (!cancelEventArgs.Cancel)
		{
			IsEmpty = true;
		}
	}

	protected override VisualItem CreateButton(InputButtonSettings buttonSettings)
	{
		VisualItem visualItem = null;
		if (buttonSettings == inputButtonSettings_2)
		{
			visualItem = new VisualDropDownButton();
			ApplyButtonSettings(buttonSettings, visualItem as VisualButton);
		}
		else
		{
			visualItem = base.CreateButton(buttonSettings);
		}
		VisualButton visualButton = visualItem as VisualButton;
		visualButton.ClickAutoRepeat = false;
		if (buttonSettings == inputButtonSettings_3 && buttonSettings.Image == null)
		{
			visualButton.Image = (Image)(object)Class109.smethod_67("SystemImages.DateReset.png");
		}
		return visualItem;
	}

	protected virtual void OnButtonClearClick(CancelEventArgs e)
	{
		if (cancelEventHandler_0 != null)
		{
			cancelEventHandler_0(this, e);
		}
	}

	protected virtual void OnButtonDropDownClick(CancelEventArgs e)
	{
		if (cancelEventHandler_1 != null)
		{
			cancelEventHandler_1(this, e);
		}
	}

	protected virtual void ExecuteCommand()
	{
		if (icommand_0 != null)
		{
			CommandManager.smethod_0(this);
		}
	}

	protected virtual void OnCommandChanged()
	{
	}
}

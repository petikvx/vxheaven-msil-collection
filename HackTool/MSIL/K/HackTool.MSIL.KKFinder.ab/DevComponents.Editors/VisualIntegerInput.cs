using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using DevComponents.Editors.DateTimeAdv;

namespace DevComponents.Editors;

public class VisualIntegerInput : VisualNumericInput
{
	private int int_1;

	private int int_2 = int.MinValue;

	private int int_3 = int.MaxValue;

	private int int_4 = 1;

	private string string_3 = "";

	public int MinValue
	{
		get
		{
			return int_2;
		}
		set
		{
			if (int_2 == value)
			{
				return;
			}
			int_2 = value;
			if (int_2 >= 0)
			{
				base.AllowsNegativeValue = false;
			}
			else
			{
				base.AllowsNegativeValue = true;
			}
			if (int_1 < int_2 && (!IsEmpty || (IsEmpty && !base.AllowEmptyState)))
			{
				if (base.IsFocused)
				{
					method_5(method_4(int_2));
				}
				else
				{
					method_3(int_2);
				}
			}
		}
	}

	public int MaxValue
	{
		get
		{
			return int_3;
		}
		set
		{
			if (int_3 == value)
			{
				return;
			}
			int_3 = value;
			if (int_1 > int_3 && (!IsEmpty || (IsEmpty && !base.AllowEmptyState)))
			{
				if (base.IsFocused)
				{
					method_5(method_4(int_3));
				}
				else
				{
					method_3(int_3);
				}
			}
		}
	}

	[DefaultValue(1)]
	public int Increment
	{
		get
		{
			return int_4;
		}
		set
		{
			value = Math.Abs(value);
			if (int_4 != value)
			{
				int_4 = value;
			}
		}
	}

	[Browsable(false)]
	public virtual string Text
	{
		get
		{
			if (IsEmpty && base.AllowEmptyState)
			{
				return "";
			}
			return method_8(int_1, bool_13: true, bool_14: true);
		}
	}

	public virtual int Value
	{
		get
		{
			if (int_1 < int_2)
			{
				return int_2;
			}
			if (int_1 > int_3)
			{
				return int_3;
			}
			return int_1;
		}
		set
		{
			if (value < int_2)
			{
				value = int_2;
			}
			if (value > int_3)
			{
				value = int_3;
			}
			method_5(method_6(value));
			if (base.IsFocused)
			{
				InputComplete(sendNotification: false);
			}
		}
	}

	[Description("Indicates Numeric String Format that is used to format the numeric value entered for display purpose.")]
	public string DisplayFormat
	{
		get
		{
			return string_3;
		}
		set
		{
			if (value != null)
			{
				string_3 = value;
			}
		}
	}

	protected override void OnInputStackChanged()
	{
		if (base.InputStack.Length > 0)
		{
			IsEmpty = false;
			if (base.InputStack == "-")
			{
				method_2(0, bool_13: true);
				return;
			}
			int int_ = int.Parse(base.InputStack);
			method_2(int_, bool_13: true);
		}
		else
		{
			if (base.AllowEmptyState)
			{
				IsEmpty = true;
			}
			method_2(0, bool_13: true);
		}
		base.OnInputStackChanged();
	}

	protected override void OnInputKeyAccepted()
	{
		method_0(bool_13: true);
		base.OnInputKeyAccepted();
	}

	private void method_0(bool bool_13)
	{
		int num = method_1(int_1);
		if (int_1 == int_3 || (method_6(int_1).Length >= method_6(int_3).Length && method_6(int_1).Length >= method_6(int_2).Length) || num > int_3)
		{
			InputComplete(bool_13);
		}
	}

	private int method_1(int int_5)
	{
		string text = "";
		text = ((int_5 != 0) ? (method_6(int_5) + "0") : "1");
		int result = int_5;
		int.TryParse(text, out result);
		return result;
	}

	protected override void OnLostFocus()
	{
		ValidateValue();
		base.OnLostFocus();
	}

	protected virtual void ValidateValue()
	{
		if (int_1 < int_2 && !IsEmpty)
		{
			Value = int_2;
		}
		else if (int_1 > int_3 && !IsEmpty)
		{
			Value = int_3;
		}
	}

	private void method_2(int int_5, bool bool_13)
	{
		bool flag = int_1 != int_5 || bool_13;
		int_1 = int_5;
		if (flag)
		{
			OnValueChanged();
		}
		InvalidateArrange();
	}

	private void method_3(int int_5)
	{
		method_2(int_5, bool_13: false);
	}

	protected override string GetMeasureString()
	{
		string result = method_7(int_1, bool_13: true);
		if (IsEmpty && base.AllowEmptyState)
		{
			result = "T";
		}
		else if (base.InputStack == "-" && int_1 == 0)
		{
			result = "-";
		}
		return result;
	}

	protected override string GetRenderString()
	{
		if (base.InputStack == "-" && int_1 == 0)
		{
			return "-";
		}
		if (IsEmpty && base.AllowEmptyState)
		{
			return "";
		}
		return method_7(int_1, bool_13: true);
	}

	protected override void NegateValue()
	{
		if (!IsEmpty && int_3 >= 0)
		{
			int int_ = -int_1;
			method_5(method_4(int_));
		}
	}

	protected override void ResetValue()
	{
		int num = 0;
		if (int_2 > 0)
		{
			num = int_2;
		}
		if (num > int_3)
		{
			num = int_3;
		}
		method_3(num);
		InvalidateArrange();
	}

	private string method_4(int int_5)
	{
		CultureInfo activeCulture = DateTimeInput.GetActiveCulture();
		if (activeCulture.GetFormat(typeof(NumberFormatInfo)) is IFormatProvider formatProvider)
		{
			return int_5.ToString(formatProvider);
		}
		return int_5.ToString();
	}

	protected override void OnClipboardPaste()
	{
		if (Clipboard.ContainsText())
		{
			string text = Clipboard.GetText();
			int result = 0;
			if (!int.TryParse(text, out result) || result > int_3 || result < int_2)
			{
				return;
			}
		}
		base.OnClipboardPaste();
	}

	protected override bool ValidateNewInputStack(string s)
	{
		if (s.Length > 0)
		{
			if (s == "-" && base.AllowsNegativeValue)
			{
				return true;
			}
			int result = 0;
			if (int.TryParse(s, out result))
			{
				if ((result > int_3 && int_3 >= 0) || (result < int_2 && int_2 < 0))
				{
					return false;
				}
				return true;
			}
			return false;
		}
		return base.ValidateNewInputStack(s);
	}

	public override void IncreaseValue()
	{
		int num = int_1 + int_4;
		if (int_1 < int_3 && num > int_3)
		{
			num = int_3;
		}
		if (num <= int_3)
		{
			if (IsEmpty && base.AllowEmptyState)
			{
				num = Math.Max(0, int_2);
			}
			method_5(method_4(num));
			method_0(bool_13: false);
		}
		base.IncreaseValue();
	}

	public override void DecreaseValue()
	{
		int num = int_1 - int_4;
		if (int_1 > int_2 && num < int_2)
		{
			num = int_2;
		}
		if (num >= int_2)
		{
			method_5(method_4(num));
			method_0(bool_13: false);
		}
		base.DecreaseValue();
	}

	private void method_5(string string_4)
	{
		if (SetInputStack(string_4))
		{
			SetInputPosition(base.InputStack.Length);
		}
	}

	private string method_6(int int_5)
	{
		return method_7(int_5, bool_13: false);
	}

	private string method_7(int int_5, bool bool_13)
	{
		return method_8(int_5, bool_13, bool_14: false);
	}

	private string method_8(int int_5, bool bool_13, bool bool_14)
	{
		if ((!bool_14 && (!bool_13 || base.IsFocused)) || string_3.Length == 0)
		{
			return method_4(int_5);
		}
		CultureInfo activeCulture = DateTimeInput.GetActiveCulture();
		if (activeCulture.GetFormat(typeof(NumberFormatInfo)) is IFormatProvider formatProvider)
		{
			return int_5.ToString(string_3, formatProvider);
		}
		return int_5.ToString(string_3);
	}

	protected override string GetInputStringValue()
	{
		return method_6(int_1);
	}
}

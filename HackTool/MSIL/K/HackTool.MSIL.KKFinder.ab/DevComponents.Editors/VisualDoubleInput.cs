using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using DevComponents.Editors.DateTimeAdv;

namespace DevComponents.Editors;

public class VisualDoubleInput : VisualNumericInput
{
	private double double_0;

	private double double_1 = double.MinValue;

	private double double_2 = double.MaxValue;

	private double double_3 = 1.0;

	private string string_3 = "";

	public double MinValue
	{
		get
		{
			return double_1;
		}
		set
		{
			if (double_1 != value)
			{
				double_1 = value;
				if (double_1 >= 0.0)
				{
					base.AllowsNegativeValue = false;
				}
				else
				{
					base.AllowsNegativeValue = true;
				}
				ValidateValue();
			}
		}
	}

	public double MaxValue
	{
		get
		{
			return double_2;
		}
		set
		{
			if (double_2 != value)
			{
				double_2 = value;
				ValidateValue();
			}
		}
	}

	[DefaultValue(1)]
	public double Increment
	{
		get
		{
			return double_3;
		}
		set
		{
			value = Math.Abs(value);
			if (double_3 != value)
			{
				double_3 = value;
			}
		}
	}

	public double Value
	{
		get
		{
			if (double_0 < double_1)
			{
				return double_1;
			}
			if (double_0 > double_2)
			{
				return double_2;
			}
			return double_0;
		}
		set
		{
			if (value < double_1)
			{
				value = double_1;
			}
			if (value > double_2)
			{
				value = double_2;
			}
			method_6(method_11(method_10(value)));
			if (base.IsFocused)
			{
				InputComplete(sendNotification: false);
			}
		}
	}

	[DefaultValue("")]
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

	private string String_0 => DateTimeInput.GetActiveCulture().NumberFormat.NumberDecimalSeparator;

	[Browsable(false)]
	public virtual string Text
	{
		get
		{
			if (IsEmpty && base.AllowEmptyState)
			{
				return "";
			}
			return method_9(double_0, bool_13: true, bool_14: true);
		}
	}

	protected override void OnLostFocus()
	{
		ValidateValue();
		base.OnLostFocus();
	}

	protected virtual void ValidateValue()
	{
		if (double_0 < double_1)
		{
			Value = double_1;
		}
		else if (double_0 > double_2)
		{
			Value = double_2;
		}
	}

	protected override bool AcceptKeyPress(KeyPressEventArgs e)
	{
		string text = String_0;
		if (e.get_KeyChar().ToString() == text && !base.InputStack.Contains(text))
		{
			return true;
		}
		return base.AcceptKeyPress(e);
	}

	protected override void OnInputStackChanged()
	{
		if (base.InputStack.Length > 0)
		{
			IsEmpty = false;
			if (base.InputStack == "-")
			{
				method_2(0.0, bool_13: true);
				return;
			}
			if (base.InputStack == String_0 || base.InputStack == "-" + String_0)
			{
				method_2(0.0, bool_13: true);
				return;
			}
			method_2(method_0(base.InputStack), bool_13: true);
		}
		else
		{
			if (base.AllowEmptyState)
			{
				IsEmpty = true;
			}
			method_3(0.0);
		}
		base.OnInputStackChanged();
	}

	private double method_0(string string_4)
	{
		CultureInfo activeCulture = DateTimeInput.GetActiveCulture();
		if (activeCulture.GetFormat(typeof(NumberFormatInfo)) is IFormatProvider provider)
		{
			return double.Parse(string_4, provider);
		}
		return double.Parse(string_4);
	}

	protected override void OnInputKeyAccepted()
	{
		method_1(bool_13: true);
		base.OnInputKeyAccepted();
	}

	private void method_1(bool bool_13)
	{
		string text = "";
		string s = "";
		if (base.InputStack.Length > 0)
		{
			if (base.InputStack.Contains(String_0))
			{
				text = base.InputStack + "1";
				s = text;
			}
			else
			{
				text = base.InputStack + String_0;
				s = base.InputStack + "0";
			}
		}
		if (!(base.InputStack == "-") && !base.InputStack.StartsWith(String_0) && !(base.InputStack == "-" + String_0) && (double_0 == double_2 || (!ValidateNewInputStack(text) && !ValidateNewInputStack(s))))
		{
			InputComplete(bool_13);
		}
	}

	private void method_2(double double_4, bool bool_13)
	{
		bool flag = double_0 != double_4 || bool_13;
		double_0 = double_4;
		if (flag)
		{
			OnValueChanged();
		}
		InvalidateArrange();
	}

	private void method_3(double double_4)
	{
		method_2(double_4, bool_13: false);
	}

	protected override string GetMeasureString()
	{
		string result = GetRenderString();
		if (IsEmpty && base.AllowEmptyState)
		{
			result = "T";
		}
		else if (base.InputStack == "-" && double_0 == 0.0)
		{
			result = "-";
		}
		else if ((base.InputStack == String_0 || base.InputStack == "-" + String_0) && double_0 == 0.0)
		{
			return base.InputStack;
		}
		return result;
	}

	protected override string GetRenderString()
	{
		if (base.InputStack == "-" && double_0 == 0.0)
		{
			return "-";
		}
		if ((base.InputStack == String_0 || base.InputStack == "-" + String_0) && double_0 == 0.0)
		{
			return base.InputStack;
		}
		string text = "";
		return method_8(double_0, bool_13: true);
	}

	protected override void NegateValue()
	{
		if (!(double_2 < 0.0))
		{
			double double_ = 0.0 - double_0;
			method_6(method_10(double_));
		}
	}

	protected override void ResetValue()
	{
		double num = 0.0;
		if (double_1 > num)
		{
			num = double_1;
		}
		if (num > double_2)
		{
			num = double_2;
		}
		method_3(num);
		InvalidateArrange();
	}

	private bool method_4(string string_4, out double double_4)
	{
		CultureInfo activeCulture = DateTimeInput.GetActiveCulture();
		if (activeCulture.GetFormat(typeof(NumberFormatInfo)) is IFormatProvider provider)
		{
			return double.TryParse(string_4, NumberStyles.Number, provider, out double_4);
		}
		return double.TryParse(string_4, out double_4);
	}

	protected override void OnClipboardPaste()
	{
		if (Clipboard.ContainsText())
		{
			string text = Clipboard.GetText();
			double double_ = 0.0;
			if (!method_4(text, out double_) || double_ > double_2 || double_ < double_1)
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
			if (!(s == String_0) && !(s == "-" + String_0))
			{
				double double_ = 0.0;
				if (method_4(s, out double_))
				{
					if ((double_ > double_2 && double_2 >= 0.0) || (double_ < double_1 && double_1 < 0.0))
					{
						return false;
					}
					string text = method_9(double_, bool_13: true, bool_14: true);
					if (s.Contains(String_0) && text.Contains(String_0))
					{
						int num = method_5();
						int length = s.Substring(s.IndexOf(String_0) + 1).Length;
						if (num > 0 && length > num)
						{
							return false;
						}
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return base.ValidateNewInputStack(s);
	}

	private int method_5()
	{
		if (DisplayFormat != null && DisplayFormat.Length != 0)
		{
			string text = method_9(11.111111111111, bool_13: true, bool_14: true);
			return text.Substring(text.IndexOf(String_0) + 1).Length;
		}
		CultureInfo activeCulture = DateTimeInput.GetActiveCulture();
		if (activeCulture.GetFormat(typeof(NumberFormatInfo)) is IFormatProvider formatProvider && formatProvider is NumberFormatInfo)
		{
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)formatProvider;
			return numberFormatInfo.NumberDecimalDigits;
		}
		return 2;
	}

	public override void IncreaseValue()
	{
		double num = double_0 + double_3;
		if (double_0 < double_2 && num > double_2)
		{
			num = double_2;
		}
		if (num <= double_2)
		{
			if (IsEmpty && base.AllowEmptyState)
			{
				num = Math.Max(0.0, double_1);
			}
			method_6(method_11(method_10(num)));
			method_1(bool_13: false);
		}
		base.IncreaseValue();
	}

	public override void DecreaseValue()
	{
		double num = double_0 - double_3;
		if (double_0 > double_1 && num < double_1)
		{
			num = double_1;
		}
		if (num >= double_1)
		{
			method_6(method_11(method_10(num)));
			method_1(bool_13: false);
		}
		base.DecreaseValue();
	}

	private void method_6(string string_4)
	{
		string text = string_4;
		if (string_4.Contains(String_0) && text.Contains(String_0))
		{
			int num = method_5();
			int length = string_4.Substring(string_4.IndexOf(String_0) + 1).Length;
			if (num > 0 && length > num)
			{
				string_4 = string_4.Substring(0, string_4.IndexOf(String_0) + 1 + num);
			}
		}
		if (SetInputStack(string_4))
		{
			SetInputPosition(base.InputStack.Length);
		}
	}

	private string method_7(double double_4)
	{
		return method_9(double_4, bool_13: false, bool_14: false);
	}

	private string method_8(double double_4, bool bool_13)
	{
		return method_9(double_4, bool_13, bool_14: false);
	}

	private string method_9(double double_4, bool bool_13, bool bool_14)
	{
		string text = method_10(double_4);
		if (!bool_14 && (string_3.Length == 0 || base.IsFocused || !bool_13))
		{
			if (base.InputStack.Contains(String_0))
			{
				if (!text.Contains(String_0))
				{
					text += base.InputStack.Substring(base.InputStack.IndexOf(String_0));
				}
				else if (text.Substring(text.IndexOf(String_0)) != base.InputStack.Substring(base.InputStack.IndexOf(String_0)))
				{
					text = text.Substring(0, text.IndexOf(String_0)) + base.InputStack.Substring(base.InputStack.IndexOf(String_0));
				}
			}
		}
		else if (string_3.Length > 0)
		{
			try
			{
				CultureInfo activeCulture = DateTimeInput.GetActiveCulture();
				if (activeCulture.GetFormat(typeof(NumberFormatInfo)) is IFormatProvider formatProvider)
				{
					return double_4.ToString(string_3, formatProvider);
				}
				return double_4.ToString(string_3);
			}
			catch
			{
				return double_4.ToString();
			}
		}
		return text;
	}

	private string method_10(double double_4)
	{
		CultureInfo activeCulture = DateTimeInput.GetActiveCulture();
		if (activeCulture.GetFormat(typeof(NumberFormatInfo)) is IFormatProvider formatProvider)
		{
			return double_4.ToString(formatProvider);
		}
		return double_4.ToString();
	}

	private string method_11(string string_4)
	{
		string text = "";
		for (int i = 0; i < string_4.Length; i++)
		{
			if (!(string_4[i].ToString() == String_0) && (string_4[i] < '0' || string_4[i] > '9') && (i != 0 || string_4[i] != '-'))
			{
				if (text.Length > 0)
				{
					break;
				}
			}
			else
			{
				text += string_4[i];
			}
		}
		return text;
	}

	protected override string GetInputStringValue()
	{
		return method_7(double_0);
	}
}

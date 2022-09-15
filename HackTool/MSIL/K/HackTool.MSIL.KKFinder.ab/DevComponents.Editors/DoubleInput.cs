using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Editors.Design;

namespace DevComponents.Editors;

[ToolboxItem(true)]
[Designer(typeof(NumericInputBaseDesigner))]
[ToolboxBitmap(typeof(DotNetBarManager), "DoubleInput.ico")]
public class DoubleInput : NumericInputBase
{
	private VisualDoubleInput visualDoubleInput_0;

	private VisualInputGroup visualInputGroup_1;

	private ParseDoubleValueEventHandler parseDoubleValueEventHandler_0;

	[Description("Indicates value displayed in the control.")]
	[DefaultValue(0.0)]
	public double Value
	{
		get
		{
			return visualDoubleInput_0.Value;
		}
		set
		{
			if (Value != value || visualDoubleInput_0.IsEmpty)
			{
				visualDoubleInput_0.Value = value;
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[TypeConverter(typeof(StringConverter))]
	[RefreshProperties(RefreshProperties.All)]
	[Bindable(true)]
	public object ValueObject
	{
		get
		{
			if (base.IsEmpty)
			{
				return null;
			}
			return Value;
		}
		set
		{
			if (method_21(value))
			{
				return;
			}
			if (IsNull(value))
			{
				base.IsEmpty = true;
			}
			else if (!(value is double) && !(value is int) && !(value is float))
			{
				if (value is long)
				{
					string s = value.ToString();
					Value = double.Parse(s);
					return;
				}
				if (!(value is string))
				{
					throw new ArgumentException("ValueObject property expects either null/nothing value or double type.");
				}
				double result = 0.0;
				if (!double.TryParse(value.ToString(), out result))
				{
					throw new ArgumentException("ValueObject property expects either null/nothing value or double type.");
				}
				Value = result;
			}
			else
			{
				Value = (double)value;
			}
		}
	}

	[DefaultValue(double.MaxValue)]
	[Description("Indicates maximum value that can be entered.")]
	public double MaxValue
	{
		get
		{
			return visualDoubleInput_0.MaxValue;
		}
		set
		{
			visualDoubleInput_0.MaxValue = value;
		}
	}

	[DefaultValue(double.MinValue)]
	[Description("Indicates minimum value that can be entered.")]
	public double MinValue
	{
		get
		{
			return visualDoubleInput_0.MinValue;
		}
		set
		{
			visualDoubleInput_0.MinValue = value;
		}
	}

	[Description("Indicates value to increment or decrement the value of the control when the up or down buttons are clicked. ")]
	[DefaultValue(1)]
	public double Increment
	{
		get
		{
			return visualDoubleInput_0.Increment;
		}
		set
		{
			visualDoubleInput_0.Increment = value;
		}
	}

	protected override bool IsWatermarkRendered
	{
		get
		{
			if (!((Control)this).get_Focused())
			{
				return visualDoubleInput_0.IsEmpty;
			}
			return false;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override string Text
	{
		get
		{
			return visualDoubleInput_0.Text;
		}
		set
		{
			ValueObject = value;
		}
	}

	public event ParseDoubleValueEventHandler ParseValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			parseDoubleValueEventHandler_0 = (ParseDoubleValueEventHandler)Delegate.Combine(parseDoubleValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			parseDoubleValueEventHandler_0 = (ParseDoubleValueEventHandler)Delegate.Remove(parseDoubleValueEventHandler_0, value);
		}
	}

	protected override VisualItem CreateRootVisual()
	{
		VisualInputGroup visualInputGroup = new VisualInputGroup();
		VisualDoubleInput visualDoubleInput = new VisualDoubleInput();
		visualDoubleInput.ValueChanged += method_20;
		visualInputGroup.Items.Add(visualDoubleInput);
		visualInputGroup_1 = visualInputGroup;
		visualDoubleInput_0 = visualDoubleInput;
		return visualInputGroup;
	}

	private void method_20(object sender, EventArgs e)
	{
		OnValueChanged(e);
	}

	protected override void OnDisplayFormatChanged()
	{
		visualDoubleInput_0.DisplayFormat = base.DisplayFormat;
	}

	private bool method_21(object object_1)
	{
		ParseDoubleValueEventArgs parseDoubleValueEventArgs = new ParseDoubleValueEventArgs(object_1);
		OnParseValue(parseDoubleValueEventArgs);
		if (parseDoubleValueEventArgs.IsParsed)
		{
			Value = parseDoubleValueEventArgs.ParsedValue;
		}
		return parseDoubleValueEventArgs.IsParsed;
	}

	protected virtual void OnParseValue(ParseDoubleValueEventArgs e)
	{
		if (parseDoubleValueEventHandler_0 != null)
		{
			parseDoubleValueEventHandler_0(this, e);
		}
	}
}

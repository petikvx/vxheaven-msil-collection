using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.Editors.Design;

namespace DevComponents.Editors;

[ToolboxItem(true)]
[ToolboxBitmap(typeof(DotNetBarManager), "IntegerInput.ico")]
[Designer(typeof(NumericInputBaseDesigner))]
public class IntegerInput : NumericInputBase
{
	private VisualIntegerInput visualIntegerInput_0;

	private VisualInputGroup visualInputGroup_1;

	private ParseIntegerValueEventHandler parseIntegerValueEventHandler_0;

	[DefaultValue(0)]
	[Description("Indicates value displayed in the control.")]
	public int Value
	{
		get
		{
			return visualIntegerInput_0.Value;
		}
		set
		{
			if (Value != value || visualIntegerInput_0.IsEmpty)
			{
				visualIntegerInput_0.Value = value;
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[RefreshProperties(RefreshProperties.All)]
	[Bindable(true)]
	[DefaultValue(null)]
	[TypeConverter(typeof(StringConverter))]
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
				return;
			}
			if (value is int)
			{
				Value = (int)value;
				return;
			}
			if (value is string)
			{
				int result = 0;
				if (!int.TryParse(value.ToString(), out result))
				{
					throw new ArgumentException("ValueObject property expects either null/nothing value or int type.");
				}
				Value = result;
				return;
			}
			throw new ArgumentException("ValueObject property expects either null/nothing value or int type.");
		}
	}

	[Description("Indicates maximum value that can be entered.")]
	[DefaultValue(int.MaxValue)]
	public int MaxValue
	{
		get
		{
			return visualIntegerInput_0.MaxValue;
		}
		set
		{
			visualIntegerInput_0.MaxValue = value;
		}
	}

	[Description("Indicates minimum value that can be entered.")]
	[DefaultValue(int.MinValue)]
	public int MinValue
	{
		get
		{
			return visualIntegerInput_0.MinValue;
		}
		set
		{
			visualIntegerInput_0.MinValue = value;
		}
	}

	[DefaultValue(1)]
	[Description("Indicates value to increment or decrement the value of the control when the up or down buttons are clicked. ")]
	public int Increment
	{
		get
		{
			return visualIntegerInput_0.Increment;
		}
		set
		{
			visualIntegerInput_0.Increment = value;
		}
	}

	protected override bool IsWatermarkRendered
	{
		get
		{
			if (!((Control)this).get_Focused())
			{
				return visualIntegerInput_0.IsEmpty;
			}
			return false;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override string Text
	{
		get
		{
			return visualIntegerInput_0.Text;
		}
		set
		{
			ValueObject = value;
		}
	}

	public event ParseIntegerValueEventHandler ParseValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			parseIntegerValueEventHandler_0 = (ParseIntegerValueEventHandler)Delegate.Combine(parseIntegerValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			parseIntegerValueEventHandler_0 = (ParseIntegerValueEventHandler)Delegate.Remove(parseIntegerValueEventHandler_0, value);
		}
	}

	protected override VisualItem CreateRootVisual()
	{
		VisualInputGroup visualInputGroup = new VisualInputGroup();
		VisualIntegerInput visualIntegerInput = new VisualIntegerInput();
		visualIntegerInput.ValueChanged += method_20;
		visualInputGroup.Items.Add(visualIntegerInput);
		visualInputGroup_1 = visualInputGroup;
		visualIntegerInput_0 = visualIntegerInput;
		return visualInputGroup;
	}

	private void method_20(object sender, EventArgs e)
	{
		OnValueChanged(e);
	}

	protected override void OnDisplayFormatChanged()
	{
		visualIntegerInput_0.DisplayFormat = base.DisplayFormat;
	}

	private bool method_21(object object_1)
	{
		ParseIntegerValueEventArgs parseIntegerValueEventArgs = new ParseIntegerValueEventArgs(object_1);
		OnParseValue(parseIntegerValueEventArgs);
		if (parseIntegerValueEventArgs.IsParsed)
		{
			Value = parseIntegerValueEventArgs.ParsedValue;
		}
		return parseIntegerValueEventArgs.IsParsed;
	}

	protected virtual void OnParseValue(ParseIntegerValueEventArgs e)
	{
		if (parseIntegerValueEventHandler_0 != null)
		{
			parseIntegerValueEventHandler_0(this, e);
		}
	}
}

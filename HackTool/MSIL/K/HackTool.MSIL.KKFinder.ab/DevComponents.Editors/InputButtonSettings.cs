using System;
using System.ComponentModel;
using System.Drawing;

namespace DevComponents.Editors;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
[TypeConverter(typeof(ExpandableObjectConverter))]
public class InputButtonSettings : IComparable
{
	private IInputButtonControl iinputButtonControl_0;

	private bool bool_0;

	private bool bool_1 = true;

	private int int_0;

	private Image image_0;

	private string string_0 = "";

	private VisualItem visualItem_0;

	[DefaultValue(false)]
	[Description("Indicates whether button is visible.")]
	public bool Visible
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				method_0();
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether button is enabled.")]
	public bool Enabled
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_1 != value)
			{
				bool_1 = value;
				method_4();
			}
		}
	}

	[Description("Indicates display position index of the button.")]
	[DefaultValue(0)]
	[Localizable(true)]
	public int DisplayPosition
	{
		get
		{
			return int_0;
		}
		set
		{
			if (int_0 != value)
			{
				int_0 = value;
				method_1();
			}
		}
	}

	[DefaultValue(null)]
	[Localizable(true)]
	[Description("Indicates image displayed on the face of the button.")]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			if (image_0 != value)
			{
				image_0 = value;
				method_2();
			}
		}
	}

	[DefaultValue("")]
	[Description("Input text displayed on the input button face.")]
	[Localizable(true)]
	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			if (string_0 != value)
			{
				string_0 = value;
				method_3();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public VisualItem ItemReference
	{
		get
		{
			return visualItem_0;
		}
		set
		{
			visualItem_0 = value;
		}
	}

	public InputButtonSettings()
	{
	}

	public InputButtonSettings(IInputButtonControl parent)
	{
		iinputButtonControl_0 = parent;
	}

	private void method_0()
	{
		method_4();
	}

	private void method_1()
	{
		method_4();
	}

	private void method_2()
	{
		method_4();
	}

	private void method_3()
	{
		method_4();
	}

	private void method_4()
	{
		if (iinputButtonControl_0 != null)
		{
			iinputButtonControl_0.InputButtonSettingsChanged(this);
		}
	}

	int IComparable.CompareTo(object obj)
	{
		if (obj is InputButtonSettings)
		{
			int num = ((InputButtonSettings)obj).DisplayPosition - DisplayPosition;
			if (num == 0 && obj != this)
			{
				num = -1;
			}
			return num;
		}
		return 0;
	}
}

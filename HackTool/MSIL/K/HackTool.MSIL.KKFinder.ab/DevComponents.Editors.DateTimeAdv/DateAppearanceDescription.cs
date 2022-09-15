using System.ComponentModel;
using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.Editors.DateTimeAdv;

[DesignTimeVisible(false)]
[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
public class DateAppearanceDescription
{
	private BaseItem baseItem_0;

	private bool bool_0;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private int int_0 = 90;

	private Color color_2 = Color.Empty;

	private Color color_3 = Color.Empty;

	private bool bool_1 = true;

	[DefaultValue(false)]
	[Description("Indicates whether text is drawn using bold font.")]
	public bool IsBold
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

	[Description("Indicates background color for the marked day.")]
	[Category("Colors")]
	public Color BackColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			method_0();
		}
	}

	[Description("Indicates background target gradient color for the marked date.")]
	[Category("Colors")]
	public Color BackColor2
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			method_0();
		}
	}

	[Description("Indicates background gradient fill angle.")]
	[DefaultValue(90)]
	public int BackColorGradientAngle
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
				method_0();
			}
		}
	}

	[Description("Indicates text color for the marked date.")]
	[Category("Colors")]
	public Color TextColor
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			method_0();
		}
	}

	[Browsable(false)]
	public bool IsCustomized
	{
		get
		{
			if (color_0.IsEmpty && color_1.IsEmpty && color_2.IsEmpty && !bool_0)
			{
				return !color_3.IsEmpty;
			}
			return true;
		}
	}

	internal BaseItem BaseItem_0
	{
		get
		{
			return baseItem_0;
		}
		set
		{
			if (baseItem_0 != value)
			{
				baseItem_0 = value;
			}
		}
	}

	[Category("Colors")]
	[Description("Indicates borderColor color.")]
	public Color BorderColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			method_0();
		}
	}

	[Description("Indicates whether day marked is selectable by end user.")]
	[DefaultValue(true)]
	public bool Selectable
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
			}
		}
	}

	public DateAppearanceDescription()
	{
	}

	public DateAppearanceDescription(BaseItem parent)
	{
		baseItem_0 = parent;
	}

	private void method_0()
	{
		if (baseItem_0 != null)
		{
			baseItem_0.Refresh();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor()
	{
		return !BackColor.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor()
	{
		BackColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor2()
	{
		return !BackColor2.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor2()
	{
		BackColor2 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		return !TextColor.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderColor()
	{
		return !BorderColor.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderColor()
	{
		BorderColor = Color.Empty;
	}
}

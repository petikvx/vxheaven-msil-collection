using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace DevComponents.Editors;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class ComboItem : Component
{
	private string string_0 = "";

	private int int_0 = -1;

	private Image image_0;

	private StringFormat stringFormat_0;

	private HorizontalAlignment horizontalAlignment_0;

	private string string_1 = "";

	private FontStyle fontStyle_0;

	private float float_0 = 8f;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private object object_0;

	internal ComboBoxEx comboBoxEx_0;

	internal bool bool_0;

	[DefaultValue("")]
	[Browsable(true)]
	[Localizable(true)]
	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Localizable(true)]
	public int ImageIndex
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public StringAlignment TextAlignment
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return stringFormat_0.get_Alignment();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			stringFormat_0.set_Alignment(value);
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public StringAlignment TextLineAlignment
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return stringFormat_0.get_LineAlignment();
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			stringFormat_0.set_LineAlignment(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public StringFormat TextFormat
	{
		get
		{
			return stringFormat_0;
		}
		set
		{
			stringFormat_0 = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public HorizontalAlignment ImagePosition
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return horizontalAlignment_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			horizontalAlignment_0 = value;
		}
	}

	[DefaultValue("")]
	public string FontName
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public Color ForeColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	public Color BackColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	public FontStyle FontStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return fontStyle_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			fontStyle_0 = value;
		}
	}

	[DefaultValue(8f)]
	public float FontSize
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
		}
	}

	[DefaultValue(null)]
	[Localizable(true)]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public object Tag
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public ImageList ImageList
	{
		get
		{
			if (comboBoxEx_0 != null)
			{
				return comboBoxEx_0.Images;
			}
			return null;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public ComboBoxEx Parent => comboBoxEx_0;

	public ComboItem()
	{
		stringFormat_0 = Class109.smethod_3();
		stringFormat_0.set_Alignment((StringAlignment)0);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeForeColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor()
	{
		return !color_1.IsEmpty;
	}

	public override string ToString()
	{
		return string_0;
	}
}

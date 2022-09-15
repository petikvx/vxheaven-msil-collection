using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
public class ColorExMapper
{
	private ElementStyle elementStyle_0;

	private string string_0 = "";

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Color Color
	{
		get
		{
			return (Color)TypeDescriptor.GetProperties(elementStyle_0)[string_0]!.GetValue(elementStyle_0);
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)[string_0]!.SetValue(elementStyle_0, value);
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public byte Alpha
	{
		get
		{
			return ((Color)TypeDescriptor.GetProperties(elementStyle_0)[string_0]!.GetValue(elementStyle_0)).A;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)[string_0]!.SetValue(elementStyle_0, Color.FromArgb(value, Color));
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	public eColorSchemePart ColorSchemePart
	{
		get
		{
			return (eColorSchemePart)TypeDescriptor.GetProperties(elementStyle_0)[string_0 + "SchemePart"]!.GetValue(elementStyle_0);
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)[string_0 + "SchemePart"]!.SetValue(elementStyle_0, value);
		}
	}

	public ColorExMapper(string colorProperty, ElementStyle style)
	{
		string_0 = colorProperty;
		elementStyle_0 = style;
	}
}

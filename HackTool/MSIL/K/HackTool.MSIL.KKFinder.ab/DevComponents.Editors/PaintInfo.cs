using System.Drawing;

namespace DevComponents.Editors;

public class PaintInfo
{
	private Graphics graphics_0;

	private Point point_0;

	private Font font_0;

	private Color color_0 = SystemColors.ControlText;

	private Color color_1 = SystemColors.ControlDark;

	private bool bool_0;

	private Font font_1;

	private Color color_2 = Color.Empty;

	private Size size_0;

	private bool bool_1 = true;

	private bool bool_2;

	private InputControlColors inputControlColors_0;

	public Graphics Graphics
	{
		get
		{
			return graphics_0;
		}
		set
		{
			graphics_0 = value;
		}
	}

	public Point RenderOffset
	{
		get
		{
			return point_0;
		}
		set
		{
			point_0 = value;
		}
	}

	public Font DefaultFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
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

	public Color DisabledForeColor
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

	public bool WatermarkEnabled
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public Font WatermarkFont
	{
		get
		{
			return font_1;
		}
		set
		{
			font_1 = value;
		}
	}

	public Color WatermarkColor
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
		}
	}

	public Size AvailableSize
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
		}
	}

	public bool ParentEnabled
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public bool MouseOver
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	public InputControlColors Colors
	{
		get
		{
			return inputControlColors_0;
		}
		set
		{
			inputControlColors_0 = value;
		}
	}
}

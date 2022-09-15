using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class110 : ISimpleElement
{
	private Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private Image image_0;

	private eSimplePartAlignment eSimplePartAlignment_0;

	private string string_0 = "";

	private int int_0;

	public int FixedWidth
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

	public bool ImageVisible => image_0 != null;

	public Size ImageLayoutSize
	{
		get
		{
			if (image_0 == null)
			{
				return Size.Empty;
			}
			return image_0.get_Size();
		}
	}

	public eSimplePartAlignment ImageAlignment
	{
		get
		{
			return eSimplePartAlignment_0;
		}
		set
		{
			eSimplePartAlignment_0 = value;
		}
	}

	public int ImageTextSpacing => 1;

	public bool TextVisible => true;

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

	public Rectangle Bounds
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	public Rectangle TextBounds
	{
		get
		{
			return rectangle_2;
		}
		set
		{
			rectangle_2 = value;
		}
	}

	public Rectangle ImageBounds
	{
		get
		{
			return rectangle_1;
		}
		set
		{
			rectangle_1 = value;
		}
	}

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
}

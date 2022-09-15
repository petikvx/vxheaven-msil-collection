using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

public class HyperlinkStyle
{
	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private eHyperlinkUnderlineStyle eHyperlinkUnderlineStyle_0;

	public Color TextColor
	{
		get
		{
			return color_0;
		}
		set
		{
			if (color_0 != value)
			{
				color_0 = value;
			}
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
			if (color_1 != value)
			{
				color_1 = value;
			}
		}
	}

	public eHyperlinkUnderlineStyle UnderlineStyle
	{
		get
		{
			return eHyperlinkUnderlineStyle_0;
		}
		set
		{
			if (eHyperlinkUnderlineStyle_0 != value)
			{
				eHyperlinkUnderlineStyle_0 = value;
			}
		}
	}

	public bool IsChanged
	{
		get
		{
			if (color_0.IsEmpty && color_1.IsEmpty)
			{
				return eHyperlinkUnderlineStyle_0 != eHyperlinkUnderlineStyle.None;
			}
			return true;
		}
	}

	public HyperlinkStyle()
	{
	}

	public HyperlinkStyle(Color textColor, eHyperlinkUnderlineStyle underlineStyle)
	{
		color_0 = textColor;
		eHyperlinkUnderlineStyle_0 = underlineStyle;
	}

	public HyperlinkStyle(Color textColor, Color backColor, eHyperlinkUnderlineStyle underlineStyle)
	{
		color_0 = textColor;
		color_1 = backColor;
		eHyperlinkUnderlineStyle_0 = underlineStyle;
	}
}

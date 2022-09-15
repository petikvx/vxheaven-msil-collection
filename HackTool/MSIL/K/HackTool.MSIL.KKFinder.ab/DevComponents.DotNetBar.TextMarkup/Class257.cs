using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class257 : Class256
{
	private int int_0 = 1;

	private Font font_0;

	public int Int32_0
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

	public Class257()
	{
	}

	public Class257(int level)
	{
		int_0 = level;
	}

	public override void Measure(Size availableSize, Class263 d)
	{
		SetFont(d);
		base.Measure(availableSize, d);
		if (font_0 != null)
		{
			d.font_0 = font_0;
		}
	}

	public override void Render(Class263 d)
	{
		SetFont(d);
		base.Render(d);
		if (font_0 != null)
		{
			d.font_0 = font_0;
		}
	}

	protected virtual void SetFont(Class263 d)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		Font val = d.font_0;
		try
		{
			float num = d.font_0.get_SizeInPoints();
			if (int_0 == 1)
			{
				num += 12f;
			}
			else if (int_0 == 2)
			{
				num += 8f;
			}
			else if (int_0 == 3)
			{
				num += 6f;
			}
			else if (int_0 == 4)
			{
				num += 4f;
			}
			else if (int_0 == 5)
			{
				num += 2f;
			}
			else if (int_0 == 6)
			{
				num += 1f;
			}
			d.font_0 = new Font(d.font_0.get_FontFamily(), num, (FontStyle)1);
		}
		catch
		{
			val = null;
		}
		if (val != null)
		{
			font_0 = val;
		}
	}
}

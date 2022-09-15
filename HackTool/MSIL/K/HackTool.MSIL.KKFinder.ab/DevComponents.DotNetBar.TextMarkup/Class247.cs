using System.Drawing;
using System.Xml;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class247 : Class246
{
	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private int int_0;

	private bool bool_2;

	private string string_0 = "";

	private string string_1 = "";

	public Color Color_0
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

	public string String_0
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

	protected override void SetFont(Class263 d)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		Font val = d.font_0;
		try
		{
			if (!(string_0 != "") && (int_0 == 0 || !bool_2) && (int_0 <= 4 || bool_2))
			{
				val = null;
			}
			else if (string_0 != "")
			{
				d.font_0 = new Font(string_0, (bool_2 || int_0 == 0) ? (val.get_SizeInPoints() + (float)int_0) : ((float)int_0), val.get_Style());
			}
			else
			{
				d.font_0 = new Font(val.get_FontFamily(), (bool_2 || int_0 == 0) ? (val.get_SizeInPoints() + (float)int_0) : ((float)int_0), val.get_Style());
			}
		}
		catch
		{
			val = null;
		}
		if (val != null)
		{
			font_0 = val;
		}
		if (!d.bool_5)
		{
			if (!color_0.IsEmpty)
			{
				color_1 = d.color_0;
				d.color_0 = color_0;
			}
			else if (string_1 != "" && GlobalManager.Renderer is Office2007Renderer)
			{
				color_1 = d.color_0;
				d.color_0 = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.Form.Active.CaptionTextExtra;
			}
		}
	}

	public override void RenderEnd(Class263 d)
	{
		RestoreForeColor(d);
		base.RenderEnd(d);
	}

	public override void MeasureEnd(Size availableSize, Class263 d)
	{
		RestoreForeColor(d);
		base.MeasureEnd(availableSize, d);
	}

	protected virtual void RestoreForeColor(Class263 d)
	{
		if (!color_1.IsEmpty)
		{
			d.color_0 = color_1;
		}
		color_1 = Color.Empty;
	}

	private Color method_3(string string_2)
	{
		string text = string_2.ToLower();
		string_1 = "";
		if (text == "syscaptiontextextra")
		{
			string_1 = text;
			return Color.Empty;
		}
		return Color.FromName(string_2);
	}

	public override void ReadAttributes(XmlTextReader reader)
	{
		bool_2 = false;
		for (int i = 0; i < reader.AttributeCount; i++)
		{
			reader.MoveToAttribute(i);
			if (reader.Name.ToLower() == "color")
			{
				try
				{
					string value = reader.Value;
					if (value.StartsWith("#"))
					{
						if (value.Length == 7)
						{
							color_0 = ColorScheme.GetColor(value.Substring(1));
						}
					}
					else
					{
						color_0 = method_3(value);
					}
				}
				catch
				{
					color_0 = Color.Empty;
				}
			}
			else if (reader.Name.ToLower() == "size")
			{
				string value2 = reader.Value;
				if (value2.StartsWith("+"))
				{
					try
					{
						int_0 = int.Parse(value2.Substring(1));
						bool_2 = true;
					}
					catch
					{
						int_0 = 0;
					}
					continue;
				}
				if (value2.StartsWith("-"))
				{
					bool_2 = true;
				}
				try
				{
					int_0 = int.Parse(value2);
				}
				catch
				{
					int_0 = 0;
				}
			}
			else if (reader.Name.ToLower() == "face")
			{
				string_0 = reader.Value;
			}
		}
	}
}

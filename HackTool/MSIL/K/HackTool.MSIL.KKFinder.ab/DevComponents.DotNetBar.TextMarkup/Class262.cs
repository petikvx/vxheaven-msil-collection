using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class262 : Class245, Interface4
{
	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private string string_0 = "";

	private string string_1 = "";

	private Cursor cursor_0;

	private bool bool_2;

	private bool bool_3;

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

	public string String_1
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

	public override void Measure(Size availableSize, Class263 d)
	{
		base.Bounds = Rectangle.Empty;
		SetForeColor(d);
	}

	public override void Render(Class263 d)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		d.bool_1 = true;
		d.hyperlinkStyle_0 = method_3();
		if (!d.hyperlinkStyle_0.BackColor.IsEmpty)
		{
			GraphicsPath val = new GraphicsPath();
			try
			{
				Class244 elements = Parent.Elements;
				int num = elements.method_2(this) + 1;
				for (int i = num; i < elements.Count; i++)
				{
					Class245 @class = elements[i];
					if (@class.Visible)
					{
						if (@class is Class255 && ((Class255)@class).Class245_0 == this)
						{
							break;
						}
						val.AddRectangle(@class.Rectangle_0);
					}
				}
				SolidBrush val2 = new SolidBrush(d.hyperlinkStyle_0.BackColor);
				try
				{
					d.graphics_0.FillPath((Brush)(object)val2, val);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		SetForeColor(d);
	}

	private HyperlinkStyle method_3()
	{
		if (bool_2 && MarkupSettings.MouseOverHyperlink.IsChanged)
		{
			return MarkupSettings.MouseOverHyperlink;
		}
		if (bool_3 && MarkupSettings.VisitedHyperlink.IsChanged)
		{
			return MarkupSettings.VisitedHyperlink;
		}
		return MarkupSettings.NormalHyperlink;
	}

	protected virtual void SetForeColor(Class263 d)
	{
		Color color = Color.Empty;
		HyperlinkStyle hyperlinkStyle = method_3();
		if (hyperlinkStyle != null && !hyperlinkStyle.TextColor.IsEmpty)
		{
			color = hyperlinkStyle.TextColor;
		}
		if (!color_0.IsEmpty)
		{
			color = color_0;
		}
		if (!color.IsEmpty)
		{
			color_1 = d.color_0;
			d.color_0 = color;
		}
	}

	public override void RenderEnd(Class263 d)
	{
		RestoreForeColor(d);
		d.bool_1 = false;
		d.hyperlinkStyle_0 = null;
		base.RenderEnd(d);
	}

	public override void MeasureEnd(Size availableSize, Class263 d)
	{
		RestoreForeColor(d);
		base.MeasureEnd(availableSize, d);
	}

	protected override void ArrangeCore(Rectangle finalRect, Class263 d)
	{
	}

	protected virtual void RestoreForeColor(Class263 d)
	{
		if (!color_1.IsEmpty)
		{
			d.color_0 = color_1;
		}
		color_1 = Color.Empty;
	}

	public override void ReadAttributes(XmlTextReader reader)
	{
		for (int i = 0; i < reader.AttributeCount; i++)
		{
			reader.MoveToAttribute(i);
			if (reader.Name.ToLower() == "href")
			{
				string_0 = reader.Value;
			}
			else if (reader.Name.ToLower() == "name")
			{
				string_1 = reader.Value;
			}
		}
	}

	public bool imethod_0(int int_0, int int_1)
	{
		if (Parent == null)
		{
			return false;
		}
		Class244 elements = Parent.Elements;
		int num = elements.method_2(this) + 1;
		int num2 = num;
		while (true)
		{
			if (num2 < elements.Count)
			{
				Class245 @class = elements[num2];
				if (!(@class is Class255) || ((Class255)@class).Class245_0 != this)
				{
					if (elements[num2].Rectangle_0.Contains(int_0, int_1))
					{
						break;
					}
					num2++;
					continue;
				}
			}
			return false;
		}
		return true;
	}

	public void imethod_1(Control control_0)
	{
		cursor_0 = control_0.get_Cursor();
		control_0.set_Cursor(Cursors.get_Hand());
		bool_2 = true;
		if (MarkupSettings.MouseOverHyperlink.IsChanged)
		{
			method_4(control_0);
		}
	}

	public void imethod_2(Control control_0)
	{
		if (cursor_0 != (Cursor)null && control_0 != null)
		{
			control_0.set_Cursor(cursor_0);
		}
		cursor_0 = null;
		bool_2 = false;
		if (MarkupSettings.MouseOverHyperlink.IsChanged)
		{
			method_4(control_0);
		}
	}

	public void imethod_3(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
	}

	public void imethod_4(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
	}

	public void imethod_5(Control control_0)
	{
		bool_3 = true;
		if (MarkupSettings.VisitedHyperlink.IsChanged)
		{
			method_4(control_0);
		}
	}

	private void method_4(Control control_0)
	{
		if (Parent == null)
		{
			return;
		}
		Class244 elements = Parent.Elements;
		int num = elements.method_2(this) + 1;
		for (int i = num; i < elements.Count; i++)
		{
			Class245 @class = elements[i];
			if (@class.Visible)
			{
				if (@class is Class255 && ((Class255)@class).Class245_0 == this)
				{
					break;
				}
				control_0.Invalidate(@class.Rectangle_0);
			}
		}
	}
}

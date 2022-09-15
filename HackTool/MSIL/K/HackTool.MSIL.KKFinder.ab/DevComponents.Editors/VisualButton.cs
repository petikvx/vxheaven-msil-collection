using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.Editors;

public class VisualButton : VisualButtonBase
{
	private bool bool_8;

	private bool bool_9;

	private string string_0 = "";

	private Image image_0;

	private Image image_1;

	public bool IsMouseOver
	{
		get
		{
			return bool_8;
		}
		internal set
		{
			if (bool_8 != value)
			{
				bool_8 = value;
				InvalidateRender();
			}
		}
	}

	public bool IsMouseDown
	{
		get
		{
			return bool_9;
		}
		internal set
		{
			if (bool_9 != value)
			{
				bool_9 = value;
				InvalidateRender();
			}
		}
	}

	[DefaultValue("")]
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
				InvalidateArrange();
			}
		}
	}

	[DefaultValue(null)]
	public Image Image
	{
		get
		{
			return image_1;
		}
		set
		{
			if (image_1 != value)
			{
				image_1 = value;
				if (image_0 != null)
				{
					image_0.Dispose();
					image_0 = null;
				}
				InvalidateArrange();
			}
		}
	}

	public override void PerformLayout(PaintInfo pi)
	{
		Size size = new Size(0, pi.AvailableSize.Height);
		Graphics graphics = pi.Graphics;
		size.Width += 6;
		if (string_0.Length > 0)
		{
			Size size2 = Class55.smethod_3(graphics, string_0, pi.DefaultFont);
			size.Width += size2.Width;
			if (image_1 != null)
			{
				size.Width += 4;
			}
		}
		if (image_1 != null)
		{
			size.Width += image_1.get_Width();
		}
		if (string_0.Length == 0 && image_1 == null)
		{
			size.Width += 9;
		}
		base.Size = size;
		base.PerformLayout(pi);
	}

	protected override void OnPaint(PaintInfo p)
	{
		Graphics graphics = p.Graphics;
		Rectangle renderBounds = base.RenderBounds;
		PaintButtonBackground(p);
		Rectangle rectangle = renderBounds;
		rectangle.Inflate(-3, -3);
		if (string_0.Length > 0)
		{
			Class55.smethod_1(graphics, string_0, p.DefaultFont, GetIsEnabled(p) ? p.ForeColor : p.DisabledForeColor, rectangle, eTextFormat.VerticalCenter);
		}
		if (image_1 != null)
		{
			Image val = (GetIsEnabled(p) ? image_1 : method_1());
			graphics.DrawImage(val, new Rectangle(rectangle.Right - image_1.get_Width(), rectangle.Y + (rectangle.Height - image_1.get_Height()) / 2, image_1.get_Width(), image_1.get_Height()));
		}
		base.OnPaint(p);
	}

	protected virtual void PaintButtonBackground(PaintInfo p)
	{
		PaintButtonBackground(p, GetOffice2007StateColorTable(p));
	}

	protected virtual void PaintButtonBackground(PaintInfo p, Office2007ButtonItemStateColorTable ct)
	{
		Graphics graphics = p.Graphics;
		Rectangle renderBounds = base.RenderBounds;
		if (method_0(p))
		{
			Class268.smethod_4(graphics, ct, renderBounds, RoundRectangleShapeDescriptor.RectangleShape);
		}
	}

	private bool method_0(PaintInfo paintInfo_0)
	{
		if (base.RenderDefaultBackground)
		{
			return true;
		}
		if ((!paintInfo_0.MouseOver && !IsMouseDown && !IsMouseOver) || !GetIsEnabled())
		{
			return false;
		}
		return true;
	}

	protected Office2007ButtonItemStateColorTable GetOffice2007StateColorTable(PaintInfo p)
	{
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			Office2007ColorTable colorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = colorTable.ButtonItemColors[Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground)];
			if (!GetIsEnabled(p))
			{
				return office2007ButtonItemColorTable.Disabled;
			}
			if (IsMouseDown)
			{
				return office2007ButtonItemColorTable.Pressed;
			}
			if (IsMouseOver)
			{
				return office2007ButtonItemColorTable.MouseOver;
			}
			return office2007ButtonItemColorTable.Default;
		}
		return null;
	}

	protected override void OnMouseEnter()
	{
		if (GetIsEnabled())
		{
			IsMouseOver = true;
		}
		base.OnMouseEnter();
	}

	protected override void OnMouseLeave()
	{
		IsMouseOver = false;
		base.OnMouseLeave();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			IsMouseDown = true;
		}
		base.OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			IsMouseDown = false;
		}
		base.OnMouseUp(e);
	}

	private Image method_1()
	{
		if (image_0 == null && image_1 != null)
		{
			ref Image reference = ref image_0;
			Image obj = image_1;
			reference = (Image)(object)Class31.smethod_1((obj is Bitmap) ? obj : null);
		}
		return image_0;
	}
}

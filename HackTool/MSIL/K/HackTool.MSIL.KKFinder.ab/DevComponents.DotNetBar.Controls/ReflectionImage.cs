using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar.Controls;

[Designer(typeof(ReflectionImageDesigner))]
[ToolboxBitmap(typeof(ReflectionImage), "Controls.ReflectionImage.ico")]
[ToolboxItem(true)]
public class ReflectionImage : ControlWithBackgroundStyle
{
	private Bitmap bitmap_0;

	private Bitmap bitmap_1;

	private Image image_0;

	private bool bool_1 = true;

	[DefaultValue(null)]
	[Description("Indicates image displayed on the control.")]
	[Category("Appearance")]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			if (image_0 != value)
			{
				image_0 = value;
				method_0();
			}
		}
	}

	protected override Size DefaultSize => new Size(128, 128);

	[Description("Indicates whether reflection effect is enabled.")]
	[DefaultValue(true)]
	public bool ReflectionEnabled
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
				((Control)this).Invalidate();
			}
		}
	}

	[Browsable(false)]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[Browsable(false)]
	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
		}
	}

	[Browsable(false)]
	public override Color ForeColor
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	[Browsable(false)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_BackgroundImageLayout();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_BackgroundImageLayout(value);
		}
	}

	[Browsable(false)]
	public Padding Padding
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Padding();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Padding(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_3();
		method_4();
		((Control)this).Dispose(disposing);
	}

	private void method_0()
	{
		method_4();
		method_1();
	}

	private void method_1()
	{
		method_3();
		Image val = method_2();
		if (val != null)
		{
			bitmap_0 = Class31.smethod_0(val);
		}
		((Control)this).Invalidate();
	}

	private Image method_2()
	{
		if (((Control)this).get_Enabled())
		{
			return image_0;
		}
		if (bitmap_1 == null)
		{
			bitmap_1 = Class31.smethod_1(image_0);
		}
		return (Image)(object)bitmap_1;
	}

	private void method_3()
	{
		if (bitmap_0 != null)
		{
			((Image)bitmap_0).Dispose();
			bitmap_0 = null;
		}
	}

	private void method_4()
	{
		if (bitmap_1 != null)
		{
			((Image)bitmap_1).Dispose();
			bitmap_1 = null;
		}
	}

	protected override void PaintContent(PaintEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		Image val = method_2();
		if (val != null)
		{
			Graphics graphics = e.get_Graphics();
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			if (base.AntiAlias)
			{
				graphics.set_SmoothingMode((SmoothingMode)2);
			}
			ElementStyle backgroundStyle = GetBackgroundStyle();
			Rectangle contentRectangle = GetContentRectangle();
			Point location = contentRectangle.Location;
			if (backgroundStyle.TextAlignment == eStyleTextAlignment.Center && contentRectangle.Width > val.get_Width())
			{
				location.X += (contentRectangle.Width - val.get_Width()) / 2;
			}
			else if (backgroundStyle.TextAlignment == eStyleTextAlignment.Far && contentRectangle.Width > val.get_Width())
			{
				location.X += contentRectangle.Width - val.get_Width();
			}
			float num = 0.52f;
			if (backgroundStyle.TextLineAlignment == eStyleTextAlignment.Center && (float)contentRectangle.Height > (float)val.get_Height() + (float)val.get_Height() * num)
			{
				location.Y += (int)(((float)contentRectangle.Height - ((float)val.get_Height() + (float)val.get_Height() * num)) / 2f);
			}
			else if (backgroundStyle.TextLineAlignment == eStyleTextAlignment.Far && (float)contentRectangle.Height > (float)val.get_Height() + (float)val.get_Height() * num)
			{
				location.Y += (int)((float)contentRectangle.Height - ((float)val.get_Height() + (float)val.get_Height() * num));
			}
			graphics.DrawImage(val, location.X, location.Y, val.get_Width(), val.get_Height());
			if (bitmap_0 != null && bool_1)
			{
				location.Y += val.get_Height();
				graphics.DrawImage((Image)(object)bitmap_0, location);
			}
			if (base.AntiAlias)
			{
				graphics.set_SmoothingMode(smoothingMode);
			}
		}
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		method_1();
		((Control)this).OnEnabledChanged(e);
	}
}

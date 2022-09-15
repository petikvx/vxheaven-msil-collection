using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar.Controls;

[ToolboxBitmap(typeof(LabelX), "Controls.ReflectionLabel.ico")]
[ToolboxItem(true)]
[Designer(typeof(ReflectionLabelDesigner))]
public class ReflectionLabel : ControlWithBackgroundStyle
{
	private Class261 class261_0;

	private Bitmap bitmap_0;

	private float float_0 = 0.52f;

	private Size size_0 = Size.Empty;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private bool bool_1 = true;

	protected override Size DefaultSize => new Size(175, 70);

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

	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Description("Gets or sets the text displayed on label.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue("")]
	[EditorBrowsable(EditorBrowsableState.Always)]
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

	public event MarkupLinkClickEventHandler MarkupLinkClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Combine(markupLinkClickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Remove(markupLinkClickEventHandler_0, value);
		}
	}

	protected override void Dispose(bool disposing)
	{
		method_3();
		((Control)this).Dispose(disposing);
	}

	protected override void PaintContent(PaintEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.get_Graphics();
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		if (base.AntiAlias)
		{
			graphics.set_SmoothingMode((SmoothingMode)4);
			graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		Rectangle contentRectangle = GetContentRectangle();
		Point location = contentRectangle.Location;
		ElementStyle backgroundStyle = GetBackgroundStyle();
		if (class261_0 != null)
		{
			Class263 @class = new Class263(graphics, ((Control)this).get_Font(), backgroundStyle.TextColor.IsEmpty ? ((Control)this).get_ForeColor() : backgroundStyle.TextColor, (int)((Control)this).get_RightToLeft() == 1, Rectangle.Empty, hotKeyPrefixVisible: true);
			if (!((Control)this).get_Enabled())
			{
				@class.bool_5 = true;
				@class.color_0 = SystemColors.ControlDark;
			}
			class261_0.Render(@class);
			location.Y = class261_0.Bounds.Bottom;
			location.X = 0;
		}
		else
		{
			int num = (int)((float)size_0.Height * (1f + float_0));
			int num2 = contentRectangle.Y;
			int x = contentRectangle.X;
			if (backgroundStyle.TextLineAlignment == eStyleTextAlignment.Center)
			{
				num2 += (contentRectangle.Height - num) / 2;
			}
			else if (backgroundStyle.TextLineAlignment == eStyleTextAlignment.Far)
			{
				num2 += contentRectangle.Height - num;
			}
			Class55.smethod_1(graphics, ((Control)this).get_Text(), ((Control)this).get_Font(), backgroundStyle.TextColor.IsEmpty ? ((Control)this).get_ForeColor() : backgroundStyle.TextColor, new Rectangle(x, num2, contentRectangle.Width, contentRectangle.Height), method_2());
			location.Y = num2 + size_0.Height;
		}
		Rectangle rectangle = new Rectangle(0, location.Y, ((Control)this).get_Width(), ((Control)this).get_Height() - location.Y);
		graphics.SetClip(rectangle, (CombineMode)0);
		int num3 = (int)Math.Floor(((Control)this).get_Font().get_Size() * (float)((Control)this).get_Font().get_FontFamily().GetCellDescent(((Control)this).get_Font().get_Style()) / (float)((Control)this).get_Font().get_FontFamily().GetEmHeight(((Control)this).get_Font().get_Style()));
		location.Y -= num3;
		if (bitmap_0 != null && bool_1)
		{
			graphics.DrawImage((Image)(object)bitmap_0, location);
		}
		graphics.ResetClip();
		if (base.AntiAlias)
		{
			graphics.set_SmoothingMode(smoothingMode);
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		method_0();
		((Control)this).OnTextChanged(e);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		method_0();
		((Control)this).OnFontChanged(e);
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		method_0();
		((Control)this).OnForeColorChanged(e);
	}

	protected override void OnVisualPropertyChanged()
	{
		method_0();
		base.OnVisualPropertyChanged();
	}

	protected override void OnResize(EventArgs e)
	{
		method_0();
		((Control)this).OnResize(e);
	}

	private void method_0()
	{
		string string_ = ((Control)this).get_Text();
		if (class261_0 != null)
		{
			class261_0.method_4((Control)(object)this);
			class261_0.Event_0 -= method_4;
			class261_0 = null;
		}
		if (Class243.smethod_2(ref string_))
		{
			class261_0 = Class243.smethod_0(string_);
		}
		if (class261_0 != null)
		{
			class261_0.Event_0 += method_4;
		}
		method_1();
		((Control)this).Invalidate();
	}

	private void method_1()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Invalid comparison between Unknown and I4
		method_3();
		if (((Control)this).get_Text().Length == 0 || ((Control)this).get_Width() <= 0 || ((Control)this).get_Height() <= 0 || ((Control)this).get_Font() == null)
		{
			return;
		}
		Bitmap val = null;
		if (class261_0 == null)
		{
			Graphics val2 = ((Control)this).CreateGraphics();
			try
			{
				if (base.AntiAlias)
				{
					val2.set_SmoothingMode((SmoothingMode)4);
					val2.set_TextRenderingHint(Class50.TextRenderingHint_0);
				}
				Size size = Class55.smethod_3(val2, ((Control)this).get_Text(), ((Control)this).get_Font());
				val = new Bitmap(((Control)this).get_Width(), size.Height, (PixelFormat)2498570);
				size_0 = size;
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			val.MakeTransparent();
			Color color = Color.Empty;
			Graphics val3 = Graphics.FromImage((Image)(object)val);
			try
			{
				ElementStyle backgroundStyle = GetBackgroundStyle();
				if (base.AntiAlias)
				{
					val3.set_SmoothingMode((SmoothingMode)4);
					val3.set_TextRenderingHint(Class50.TextRenderingHint_0);
					color = (backgroundStyle.BackColor.IsEmpty ? ((Control)this).get_BackColor() : backgroundStyle.BackColor);
					if (color.IsEmpty || color == Color.Transparent)
					{
						color = Color.WhiteSmoke;
					}
					Class50.smethod_23(val3, new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()), color);
				}
				Class55.smethod_1(val3, ((Control)this).get_Text(), ((Control)this).get_Font(), backgroundStyle.TextColor.IsEmpty ? ((Control)this).get_ForeColor() : backgroundStyle.TextColor, new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()), method_2());
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			if (!color.IsEmpty)
			{
				val.MakeTransparent(color);
			}
		}
		else
		{
			ResizeMarkup();
			if (class261_0.Bounds.Height > 0)
			{
				val = new Bitmap(((Control)this).get_Width(), class261_0.Bounds.Height, (PixelFormat)2498570);
				Color color2 = Color.Empty;
				Graphics val4 = Graphics.FromImage((Image)(object)val);
				try
				{
					ElementStyle backgroundStyle2 = GetBackgroundStyle();
					if (base.AntiAlias)
					{
						val4.set_SmoothingMode((SmoothingMode)4);
						val4.set_TextRenderingHint(Class50.TextRenderingHint_0);
						color2 = (backgroundStyle2.BackColor.IsEmpty ? ((Control)this).get_BackColor() : backgroundStyle2.BackColor);
						if (color2.IsEmpty || color2 == Color.Transparent)
						{
							color2 = Color.WhiteSmoke;
						}
						Class50.smethod_23(val4, new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height()), color2);
					}
					if (class261_0.Bounds.Top > 0)
					{
						val4.TranslateTransform(0f, (float)(-(class261_0.Bounds.Top - GetContentRectangle().Y)));
					}
					Class263 @class = new Class263(val4, ((Control)this).get_Font(), backgroundStyle2.TextColor.IsEmpty ? ((Control)this).get_ForeColor() : backgroundStyle2.TextColor, (int)((Control)this).get_RightToLeft() == 1, Rectangle.Empty, hotKeyPrefixVisible: true);
					if (!((Control)this).get_Enabled())
					{
						@class.bool_5 = true;
						@class.color_0 = SystemColors.ControlDark;
					}
					class261_0.Render(@class);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				if (!color2.IsEmpty)
				{
					val.MakeTransparent(color2);
				}
			}
		}
		if (val != null)
		{
			bitmap_0 = Class31.smethod_0((Image)(object)val);
			((Image)val).Dispose();
		}
	}

	private eTextFormat method_2()
	{
		ElementStyle backgroundStyle = GetBackgroundStyle();
		if (backgroundStyle.TextAlignment == eStyleTextAlignment.Center)
		{
			return eTextFormat.HorizontalCenter;
		}
		if (backgroundStyle.TextAlignment == eStyleTextAlignment.Far)
		{
			return eTextFormat.Right;
		}
		return eTextFormat.Default;
	}

	private void method_3()
	{
		if (bitmap_0 != null)
		{
			((Image)bitmap_0).Dispose();
			bitmap_0 = null;
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		if (sender is Class262 @class)
		{
			OnMarkupLinkClick(new MarkupLinkClickEventArgs(@class.String_1, @class.String_0));
		}
	}

	protected virtual void OnMarkupLinkClick(MarkupLinkClickEventArgs e)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(this, e);
		}
	}

	protected virtual void ResizeMarkup()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Invalid comparison between Unknown and I4
		if (class261_0 == null)
		{
			return;
		}
		Rectangle contentRectangle = GetContentRectangle();
		if (contentRectangle.Width <= 0 || contentRectangle.Height <= 0)
		{
			return;
		}
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			if (base.AntiAlias)
			{
				val.set_SmoothingMode((SmoothingMode)4);
				val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			Class263 @class = new Class263(val, ((Control)this).get_Font(), SystemColors.Control, (int)((Control)this).get_RightToLeft() == 1);
			Size availableSize = new Size(10000, contentRectangle.Height);
			class261_0.Measure(availableSize, @class);
			ElementStyle backgroundStyle = GetBackgroundStyle();
			int num = (int)((float)class261_0.Bounds.Height * (1f + float_0));
			if (num < contentRectangle.Height)
			{
				if (backgroundStyle.TextLineAlignment == eStyleTextAlignment.Center)
				{
					contentRectangle.Y += (contentRectangle.Height - num) / 2;
					contentRectangle.Height = class261_0.Bounds.Height;
				}
				else if (backgroundStyle.TextLineAlignment == eStyleTextAlignment.Far)
				{
					contentRectangle.Y = contentRectangle.Bottom - num;
					contentRectangle.Height = class261_0.Bounds.Height;
				}
			}
			if (class261_0.Bounds.Width < contentRectangle.Width)
			{
				if (backgroundStyle.TextAlignment == eStyleTextAlignment.Center)
				{
					contentRectangle.X += (contentRectangle.Width - class261_0.Bounds.Width) / 2;
					contentRectangle.Width = class261_0.Bounds.Width;
				}
				else if ((backgroundStyle.TextAlignment == eStyleTextAlignment.Far && (int)((Control)this).get_RightToLeft() == 0) || (backgroundStyle.TextAlignment == eStyleTextAlignment.Near && (int)((Control)this).get_RightToLeft() == 1))
				{
					contentRectangle.X = contentRectangle.Right - class261_0.Bounds.Width;
					contentRectangle.Width = class261_0.Bounds.Width;
				}
			}
			class261_0.method_2(contentRectangle, @class);
		}
		finally
		{
			val.Dispose();
		}
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		method_1();
		((Control)this).Invalidate();
		((Control)this).OnEnabledChanged(e);
	}
}

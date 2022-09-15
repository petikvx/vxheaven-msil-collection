using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
public class SuperTooltipControl : PanelControl
{
	private const long long_0 = 2147483648L;

	private const long long_1 = 67108864L;

	private const long long_2 = 33554432L;

	private const long long_3 = 128L;

	private const long long_4 = 8L;

	private string string_1 = "";

	private Class261 class261_1;

	private string string_2 = "";

	private Class261 class261_2;

	private Image image_0;

	private Image image_1;

	private Size size_0 = new Size(100, 18);

	private bool bool_9 = true;

	private bool bool_10 = true;

	private bool bool_11 = true;

	private int int_1 = 8;

	private Control8 control8_0;

	private bool bool_12;

	private Class261 class261_3;

	private bool bool_13 = true;

	private int int_2;

	private bool bool_14 = true;

	private eTooltipColor eTooltipColor_0;

	[Browsable(true)]
	[Category("Behavior")]
	[Description("Indicates whether complete tooltip is shown including header, body and footer. When set to false only tooltip header is shown.")]
	[DefaultValue(true)]
	public bool ShowTooltipDescription
	{
		get
		{
			return bool_14;
		}
		set
		{
			bool_14 = value;
		}
	}

	[Description("Indicates maximum width of the super tooltip.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(0)]
	public int MaximumWidth
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	[DefaultValue(eTooltipColor.Default)]
	public eTooltipColor PredefinedColor
	{
		get
		{
			return eTooltipColor_0;
		}
		set
		{
			eTooltipColor_0 = value;
			method_10(value);
			((Control)this).Refresh();
		}
	}

	internal Class261 Class261_1 => class261_3;

	public Size MinimumTooltipSize
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

	[DefaultValue(null)]
	public Image BodyImage
	{
		get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
		}
	}

	[DefaultValue(null)]
	public Image FooterImage
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

	[DefaultValue("")]
	[Browsable(true)]
	public string HeaderText
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			if (Class243.smethod_2(ref string_1))
			{
				class261_1 = Class243.smethod_0(string_1);
				if (class261_1 != null)
				{
					class261_1.Event_0 += method_4;
				}
			}
			else
			{
				class261_1 = null;
			}
		}
	}

	[DefaultValue(true)]
	public bool HeaderVisible
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue("")]
	public string FooterText
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			if (Class243.smethod_2(ref string_2))
			{
				class261_2 = Class243.smethod_0(string_2);
				if (class261_2 != null)
				{
					class261_2.Event_0 += method_4;
				}
			}
			else
			{
				class261_2 = null;
			}
		}
	}

	[DefaultValue(true)]
	public bool FooterVisible
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	public bool FooterSeparator
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
		}
	}

	[DefaultValue(true)]
	public bool MouseActivateEnabled
	{
		get
		{
			return bool_13;
		}
		set
		{
			bool_13 = value;
		}
	}

	public bool StandardControl
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Panel)this).get_CreateParams();
			if (!bool_12)
			{
				createParams.set_Style(-2046820352);
				createParams.set_ExStyle(136);
				createParams.set_Caption("");
			}
			return createParams;
		}
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		if (!Class109.smethod_11((Control)(object)this))
		{
			return proposedSize;
		}
		return method_9();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		string text = ((Control)this).get_Text();
		if (Class243.smethod_2(ref text))
		{
			class261_3 = Class243.smethod_0(text);
			if (class261_3 != null)
			{
				class261_3.Event_0 += method_4;
			}
		}
		else
		{
			class261_3 = null;
		}
		base.OnTextChanged(e);
	}

	private void method_4(object sender, EventArgs e)
	{
		if (sender is Class262 @class)
		{
			OnMarkupLinkClick(new MarkupLinkClickEventArgs(@class.String_1, @class.String_0));
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (class261_3 != null)
		{
			class261_3.method_5((Control)(object)this, e);
		}
		if (class261_1 != null)
		{
			class261_1.method_5((Control)(object)this, e);
		}
		if (class261_2 != null)
		{
			class261_2.method_5((Control)(object)this, e);
		}
		base.OnMouseMove(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (class261_3 != null)
		{
			class261_3.method_6((Control)(object)this, e);
		}
		if (class261_1 != null)
		{
			class261_1.method_6((Control)(object)this, e);
		}
		if (class261_2 != null)
		{
			class261_2.method_6((Control)(object)this, e);
		}
		base.OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (class261_3 != null)
		{
			class261_3.method_7((Control)(object)this, e);
		}
		if (class261_1 != null)
		{
			class261_1.method_7((Control)(object)this, e);
		}
		if (class261_2 != null)
		{
			class261_2.method_7((Control)(object)this, e);
		}
		base.OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (class261_3 != null)
		{
			class261_3.method_4((Control)(object)this);
		}
		if (class261_1 != null)
		{
			class261_1.method_4((Control)(object)this);
		}
		if (class261_2 != null)
		{
			class261_2.method_4((Control)(object)this);
		}
		base.OnMouseLeave(e);
	}

	protected override void OnClick(EventArgs e)
	{
		if (class261_3 != null)
		{
			class261_3.method_8((Control)(object)this);
		}
		if (class261_1 != null)
		{
			class261_1.method_8((Control)(object)this);
		}
		if (class261_2 != null)
		{
			class261_2.method_8((Control)(object)this);
		}
		base.OnClick(e);
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 33 && !bool_13)
		{
			((Message)(ref m)).set_Result(new IntPtr(3));
		}
		else
		{
			base.WndProc(ref m);
		}
	}

	protected override void PaintInnerContent(PaintEventArgs e, ElementStyle style, bool paintText)
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Invalid comparison between Unknown and I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Invalid comparison between Unknown and I4
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Invalid comparison between Unknown and I4
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Invalid comparison between Unknown and I4
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Invalid comparison between Unknown and I4
		base.PaintInnerContent(e, style, paintText: false);
		if (!paintText)
		{
			return;
		}
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.X += Class52.smethod_3(Style);
		clientRectangle.Width -= Class52.smethod_1(Style);
		clientRectangle.Y += Class52.smethod_7(Style);
		clientRectangle.Height -= Class52.smethod_2(Style);
		if (clientRectangle.Width <= 4 || clientRectangle.Height <= 4)
		{
			return;
		}
		Graphics graphics = e.get_Graphics();
		Font font = ((Control)this).get_Font();
		if (Style.Font != null)
		{
			font = Style.Font;
		}
		Font val = new Font(font, (FontStyle)((bool_14 || string_1 == "") ? 1 : 0));
		Padding padding = method_5();
		Padding padding2 = method_6();
		Padding padding3 = method_7();
		Padding padding4 = method_8();
		try
		{
			ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo(style, graphics, Rectangle.Empty);
			if (string_1 != "" && HeaderVisible)
			{
				Rectangle rectangle = new Rectangle(clientRectangle.X + padding.Left, clientRectangle.Y + padding.Top, clientRectangle.Width - padding.Horizontal, clientRectangle.Height - padding.Vertical);
				Size size = Size.Empty;
				if (class261_1 == null)
				{
					elementStyleDisplayInfo.Bounds = rectangle;
					eTextFormat eTextFormat2 = eTextFormat.WordBreak;
					if ((int)((Control)this).get_RightToLeft() == 1)
					{
						eTextFormat2 |= eTextFormat.RightToLeft;
					}
					ElementStyleDisplay.PaintText(elementStyleDisplayInfo, string_1, val, useDefaultFont: true, eTextFormat2);
					size = Class55.smethod_4(graphics, string_1, val, rectangle.Width, eTextFormat2);
				}
				else if (rectangle.Width > 0 && rectangle.Height > 0)
				{
					Class263 @class = new Class263(graphics, font, elementStyleDisplayInfo.Style.TextColor, (int)((Control)this).get_RightToLeft() == 1, rectangle, hotKeyPrefixVisible: true);
					class261_1.method_2(rectangle, @class);
					class261_1.Render(@class);
					size = class261_1.Bounds.Size;
				}
				size.Width += padding.Horizontal;
				size.Height += padding.Vertical;
				clientRectangle.Y += size.Height;
				clientRectangle.Height -= size.Height;
			}
			if (string_2 != "" && FooterVisible && clientRectangle.Width > 0 && clientRectangle.Height > 0 && (bool_14 || string_1 == ""))
			{
				Size empty = Size.Empty;
				eTextFormat eTextFormat3 = eTextFormat.WordBreak;
				empty = ((class261_2 != null) ? class261_2.Bounds.Size : Class55.smethod_4(graphics, string_2, val, clientRectangle.Width - padding2.Horizontal, eTextFormat3));
				if (image_0 != null && image_0.get_Height() > empty.Height)
				{
					empty.Height = image_0.get_Height();
				}
				Rectangle rectangle2 = new Rectangle(clientRectangle.X + padding2.Left, clientRectangle.Bottom - empty.Height - padding2.Bottom, clientRectangle.Width - padding2.Horizontal, empty.Height);
				if (FooterSeparator)
				{
					Pen val2 = new Pen(style.BorderColor, 1f);
					try
					{
						graphics.DrawLine(val2, 0, rectangle2.Y - padding2.Top - 1, ((Control)this).get_ClientRectangle().Right, rectangle2.Y - padding2.Top - 1);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				if (image_0 != null)
				{
					graphics.DrawImage(image_0, new Rectangle(rectangle2.X, rectangle2.Y + (rectangle2.Height - image_0.get_Height()) / 2, image_0.get_Width(), image_0.get_Height()));
					rectangle2.X += image_0.get_Width() + int_1;
					rectangle2.Width -= image_0.get_Width() + int_1;
				}
				if (rectangle2.Width > 0 && rectangle2.Height > 0)
				{
					if (class261_2 == null)
					{
						elementStyleDisplayInfo.Bounds = rectangle2;
						eTextFormat3 |= eTextFormat.VerticalCenter;
						if ((int)((Control)this).get_RightToLeft() == 1)
						{
							eTextFormat3 |= eTextFormat.RightToLeft;
						}
						ElementStyleDisplay.PaintText(elementStyleDisplayInfo, string_2, val, useDefaultFont: true, eTextFormat3);
					}
					else
					{
						Class263 class2 = new Class263(graphics, font, elementStyleDisplayInfo.Style.TextColor, (int)((Control)this).get_RightToLeft() == 1, rectangle2, hotKeyPrefixVisible: true);
						class261_2.method_2(rectangle2, class2);
						class261_2.Render(class2);
						empty = class261_2.Bounds.Size;
					}
				}
				empty.Width += padding2.Horizontal;
				empty.Height += padding2.Vertical;
				clientRectangle.Height -= empty.Height;
			}
			if (!bool_14 && !(string_1 == ""))
			{
				return;
			}
			if (image_1 != null)
			{
				Rectangle rectangle3 = new Rectangle(clientRectangle.X + padding4.Left, clientRectangle.Y + padding4.Top, image_1.get_Width(), image_1.get_Height());
				graphics.DrawImage(image_1, rectangle3);
				clientRectangle.X += padding4.Horizontal + image_1.get_Width();
				clientRectangle.Width -= padding4.Horizontal + image_1.get_Width();
			}
			if (!(((Control)this).get_Text() != "") || clientRectangle.Width <= 0 || clientRectangle.Height <= 0)
			{
				return;
			}
			Rectangle rectangle4 = new Rectangle(clientRectangle.X + padding3.Left, clientRectangle.Y + padding3.Top, clientRectangle.Width - padding3.Horizontal, clientRectangle.Height - padding3.Vertical);
			if (class261_3 == null)
			{
				elementStyleDisplayInfo.Bounds = rectangle4;
				if (rectangle4.Width > 0 && rectangle4.Height > 0)
				{
					eTextFormat eTextFormat4 = elementStyleDisplayInfo.Style.ETextFormat_0;
					if ((int)((Control)this).get_RightToLeft() == 1)
					{
						eTextFormat4 |= eTextFormat.RightToLeft;
					}
					ElementStyleDisplay.PaintText(elementStyleDisplayInfo, ((Control)this).get_Text(), font, useDefaultFont: false, eTextFormat4);
				}
			}
			else if (rectangle4.Width > 0 && rectangle4.Height > 0)
			{
				Class263 class3 = new Class263(graphics, font, elementStyleDisplayInfo.Style.TextColor, (int)((Control)this).get_RightToLeft() == 1, rectangle4, hotKeyPrefixVisible: true);
				class261_3.method_2(rectangle4, class3);
				class261_3.Render(class3);
			}
		}
		finally
		{
			val.Dispose();
		}
	}

	private Padding method_5()
	{
		return new Padding(6, 6, 2, 2);
	}

	private Padding method_6()
	{
		return new Padding(6, 6, 4, 6);
	}

	private Padding method_7()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		if ((!(string_1 == "") && HeaderVisible) || (!(string_2 == "") && FooterVisible))
		{
			if ((int)((Control)this).get_RightToLeft() == 1)
			{
				return new Padding(6, 14, 4, 4);
			}
			return new Padding(14, 6, 4, 4);
		}
		return new Padding(1, 1, 1, 1);
	}

	private Padding method_8()
	{
		return new Padding(6, 6, 6, 6);
	}

	public void RecalcSize()
	{
		((Control)this).set_Size(method_9());
	}

	public Size GetFixedWidthSize(int width)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Invalid comparison between Unknown and I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Invalid comparison between Unknown and I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Invalid comparison between Unknown and I4
		Padding padding = method_5();
		Padding padding2 = method_6();
		Padding padding3 = method_7();
		Padding padding4 = method_8();
		Size empty = Size.Empty;
		int num = width - Class52.smethod_1(Style);
		if (num <= 6)
		{
			num = 16;
		}
		Font font = ((Control)this).get_Font();
		if (Style.Font != null)
		{
			font = Style.Font;
		}
		Font val = new Font(font, (FontStyle)((bool_14 || string_1 == "") ? 1 : 0));
		Graphics val2 = ((Control)this).CreateGraphics();
		if (base.AntiAlias)
		{
			val2.set_SmoothingMode((SmoothingMode)4);
			val2.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		try
		{
			if (string_1 != "" && HeaderVisible)
			{
				Size empty2 = Size.Empty;
				int num2 = num - padding.Horizontal;
				if (num2 <= 1)
				{
					num2 = 2;
				}
				if (class261_1 == null)
				{
					empty2 = Class55.smethod_4(val2, string_1, val, num2, eTextFormat.WordBreak);
				}
				else
				{
					Class263 @class = new Class263(val2, font, Color.Black, (int)((Control)this).get_RightToLeft() == 1);
					class261_1.Measure(new Size(num2, 1), @class);
					empty2 = class261_1.Bounds.Size;
					class261_1.method_2(new Rectangle(Point.Empty, empty2), @class);
					empty2 = class261_1.Bounds.Size;
				}
				empty2.Height += 2;
				empty2.Height += padding.Vertical;
				empty.Height += empty2.Height;
			}
			if (string_2 != "" && FooterVisible && (bool_14 || string_1 == ""))
			{
				Size empty3 = Size.Empty;
				int num3 = num - padding2.Horizontal;
				if (image_0 != null)
				{
					num3 -= image_0.get_Width() + int_1;
				}
				if (num3 <= 1)
				{
					num3 = 2;
				}
				if (class261_2 == null)
				{
					empty3 = Class55.smethod_4(val2, string_2, val, num3, eTextFormat.WordBreak);
				}
				else
				{
					Class263 class2 = new Class263(val2, font, Color.Black, (int)((Control)this).get_RightToLeft() == 1);
					class261_2.Measure(new Size(num3, 1), class2);
					empty3 = class261_2.Bounds.Size;
					class261_2.method_2(new Rectangle(Point.Empty, empty3), class2);
					empty3 = class261_2.Bounds.Size;
				}
				empty3.Height += 2;
				if (image_0 != null && image_0.get_Height() > empty3.Height)
				{
					empty3.Height = image_0.get_Height();
				}
				empty3.Height += padding2.Vertical;
				empty.Height += empty3.Height;
			}
			if (bool_14 || string_1 == "")
			{
				if (((Control)this).get_Text() != "")
				{
					int num4 = num - padding3.Horizontal;
					if (image_1 != null)
					{
						num4 -= image_1.get_Width() + padding4.Horizontal;
					}
					if (num4 <= 1)
					{
						num4 = 2;
					}
					Size empty4 = Size.Empty;
					if (class261_3 == null)
					{
						empty4 = Class55.smethod_4(val2, ((Control)this).get_Text(), font, num4, Style.ETextFormat_0);
					}
					else
					{
						Class263 class3 = new Class263(val2, font, Color.Black, (int)((Control)this).get_RightToLeft() == 1);
						class261_3.Measure(new Size(num4, 1), class3);
						empty4 = class261_3.Bounds.Size;
						if ((double)empty4.Height > (double)empty4.Width * 1.75)
						{
							num4 = (int)((double)empty4.Height * 0.75);
						}
						class261_3.method_2(new Rectangle(Point.Empty, new Size(num4, 1)), class3);
						empty4 = class261_3.Bounds.Size;
					}
					empty4.Height += padding3.Vertical;
					if (image_1 != null && image_1.get_Height() + padding4.Vertical > empty4.Height)
					{
						empty4.Height = image_1.get_Height() + padding4.Vertical;
					}
					empty.Height += empty4.Height;
				}
				else if (image_1 != null)
				{
					empty.Height += image_1.get_Height() + padding4.Vertical;
				}
			}
		}
		finally
		{
			val2.Dispose();
			val.Dispose();
		}
		empty.Width = width;
		empty.Height += Class52.smethod_2(Style);
		return empty;
	}

	private Size method_9()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Invalid comparison between Unknown and I4
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Invalid comparison between Unknown and I4
		Padding padding = method_5();
		Padding padding2 = method_6();
		Padding padding3 = method_7();
		Padding padding4 = method_8();
		Size empty = Size.Empty;
		Font font = ((Control)this).get_Font();
		if (Style.Font != null)
		{
			font = Style.Font;
		}
		Font val = new Font(font, (FontStyle)((bool_14 || string_1 == "") ? 1 : 0));
		Graphics val2 = ((Control)this).CreateGraphics();
		if (base.AntiAlias)
		{
			val2.set_SmoothingMode((SmoothingMode)4);
			val2.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		try
		{
			if (string_1 != "" && HeaderVisible)
			{
				Size empty2 = Size.Empty;
				if (class261_1 == null)
				{
					empty2 = Class55.smethod_3(val2, string_1, val);
				}
				else
				{
					Class263 @class = new Class263(val2, font, Color.Black, (int)((Control)this).get_RightToLeft() == 1);
					class261_1.Measure(new Size(1024, 1), @class);
					empty2 = class261_1.Bounds.Size;
					class261_1.method_2(new Rectangle(Point.Empty, empty2), @class);
					empty2 = class261_1.Bounds.Size;
				}
				empty2.Width += 2;
				empty2.Height += 2;
				empty2.Width += padding.Horizontal;
				empty2.Height += padding.Vertical;
				if (empty2.Width > empty.Width)
				{
					empty.Width = empty2.Width;
				}
				empty.Height += empty2.Height;
			}
			if (string_2 != "" && FooterVisible && (bool_14 || string_1 == ""))
			{
				Size empty3 = Size.Empty;
				if (class261_2 == null)
				{
					empty3 = Class55.smethod_3(val2, string_2, val);
				}
				else
				{
					Class263 class2 = new Class263(val2, font, Color.Black, (int)((Control)this).get_RightToLeft() == 1);
					class261_2.Measure(new Size(1024, 1), class2);
					empty3 = class261_2.Bounds.Size;
					class261_2.method_2(new Rectangle(Point.Empty, empty3), class2);
					empty3 = class261_2.Bounds.Size;
				}
				empty3.Width += 2;
				empty3.Height += 2;
				if (image_0 != null)
				{
					empty3.Width += image_0.get_Width() + int_1;
					if (image_0.get_Height() > empty3.Height)
					{
						empty3.Height = image_0.get_Height();
					}
				}
				empty3.Width += padding2.Horizontal;
				empty3.Height += padding2.Vertical;
				if (empty3.Width > empty.Width)
				{
					empty.Width = empty3.Width;
				}
				empty.Height += empty3.Height;
			}
			if (bool_14 || string_1 == "")
			{
				if (((Control)this).get_Text() != "")
				{
					int num = empty.Width;
					if (num < size_0.Width)
					{
						num = size_0.Width;
					}
					if (int_2 > 0)
					{
						num = 5000;
					}
					Size empty4 = Size.Empty;
					if (class261_3 == null)
					{
						empty4 = Class55.smethod_4(val2, ((Control)this).get_Text(), font, num, Style.ETextFormat_0);
						if ((double)empty4.Height > (double)empty4.Width * 1.75 && empty4.Width > font.get_Height() * 2)
						{
							num = (int)((double)empty4.Height * 0.75);
							empty4 = Class55.smethod_4(val2, ((Control)this).get_Text(), font, num, Style.ETextFormat_0);
						}
					}
					else
					{
						Class263 class3 = new Class263(val2, font, Color.Black, (int)((Control)this).get_RightToLeft() == 1);
						class261_3.Measure(new Size(num, 1), class3);
						empty4 = class261_3.Bounds.Size;
						if ((double)empty4.Height > (double)empty4.Width * 1.75 && empty4.Width > font.get_Height() * 2)
						{
							num = (int)((double)empty4.Height * 0.75);
						}
						class261_3.method_2(new Rectangle(Point.Empty, new Size(num, 1)), class3);
						empty4 = class261_3.Bounds.Size;
					}
					empty4.Width += padding3.Horizontal;
					empty4.Height += padding3.Vertical;
					if (image_1 != null)
					{
						empty4.Width += image_1.get_Width() + padding4.Horizontal;
						if (image_1.get_Height() + padding4.Vertical > empty4.Height)
						{
							empty4.Height = image_1.get_Height() + padding4.Vertical;
						}
					}
					if (empty4.Width > empty.Width)
					{
						empty.Width = empty4.Width;
					}
					empty.Height += empty4.Height;
				}
				else if (image_1 != null)
				{
					if (image_1.get_Width() + padding4.Horizontal > empty.Width)
					{
						empty.Width = image_1.get_Width() + padding4.Horizontal;
					}
					empty.Height += image_1.get_Height() + padding4.Vertical;
				}
			}
		}
		finally
		{
			val2.Dispose();
			val.Dispose();
		}
		empty.Width += Class52.smethod_1(Style);
		empty.Height += Class52.smethod_2(Style);
		if (empty.Width < size_0.Width)
		{
			empty.Width = size_0.Width;
		}
		if (empty.Height < size_0.Height)
		{
			empty.Height = size_0.Height;
		}
		return empty;
	}

	private void method_10(eTooltipColor eTooltipColor_1)
	{
		ResetStyle();
		ResetStyleMouseOver();
		ResetStyleMouseDown();
		ElementStyle style = Style;
		Color color = Color.Empty;
		Color color2 = Color.Empty;
		TypeDescriptor.GetProperties(style)["WordWrap"]!.SetValue(style, true);
		TypeDescriptor.GetProperties(style)["TextAlignment"]!.SetValue(style, eStyleTextAlignment.Near);
		TypeDescriptor.GetProperties(style)["TextLineAlignment"]!.SetValue(style, eStyleTextAlignment.Near);
		TypeDescriptor.GetProperties(style)["BackColorGradientAngle"]!.SetValue(style, 90);
		TypeDescriptor.GetProperties(style)["BorderColor"]!.SetValue(style, Color.DimGray);
		TypeDescriptor.GetProperties(style)["BorderWidth"]!.SetValue(style, 1);
		TypeDescriptor.GetProperties(style)["TextColor"]!.SetValue(style, Color.Black);
		TypeDescriptor.GetProperties(style)["Border"]!.SetValue(style, eStyleBorderType.Solid);
		TypeDescriptor.GetProperties(style)["CornerType"]!.SetValue(style, eCornerType.Rounded);
		TypeDescriptor.GetProperties(style)["CornerDiameter"]!.SetValue(style, 2);
		switch (eTooltipColor_1)
		{
		default:
			color = Color.Empty;
			color2 = Color.Empty;
			break;
		case eTooltipColor.Blue:
			color = Color.FromArgb(221, 230, 247);
			color2 = Color.FromArgb(138, 168, 228);
			break;
		case eTooltipColor.Yellow:
			color = Color.FromArgb(255, 244, 213);
			color2 = Color.FromArgb(255, 216, 105);
			break;
		case eTooltipColor.Green:
			color = Color.FromArgb(234, 240, 226);
			color2 = Color.FromArgb(183, 201, 151);
			break;
		case eTooltipColor.Red:
			color = Color.FromArgb(249, 225, 226);
			color2 = Color.FromArgb(238, 149, 151);
			break;
		case eTooltipColor.Purple:
			color = Color.FromArgb(234, 227, 245);
			color2 = Color.FromArgb(180, 158, 222);
			break;
		case eTooltipColor.Cyan:
			color = Color.FromArgb(227, 236, 243);
			color2 = Color.FromArgb(155, 187, 210);
			break;
		case eTooltipColor.Orange:
			color = Color.FromArgb(252, 233, 217);
			color2 = Color.FromArgb(246, 176, 120);
			break;
		case eTooltipColor.Magenta:
			color = Color.FromArgb(243, 229, 236);
			color2 = Color.FromArgb(213, 164, 187);
			break;
		case eTooltipColor.BlueMist:
			color = Color.FromArgb(227, 236, 243);
			color2 = Color.FromArgb(155, 187, 210);
			break;
		case eTooltipColor.PurpleMist:
			color = Color.FromArgb(232, 227, 234);
			color2 = Color.FromArgb(171, 156, 183);
			break;
		case eTooltipColor.Tan:
			color = Color.FromArgb(248, 242, 226);
			color2 = Color.FromArgb(232, 209, 153);
			break;
		case eTooltipColor.Lemon:
			color = Color.FromArgb(252, 253, 215);
			color2 = Color.FromArgb(245, 249, 111);
			break;
		case eTooltipColor.Apple:
			color = Color.FromArgb(232, 248, 224);
			color2 = Color.FromArgb(173, 231, 146);
			break;
		case eTooltipColor.Teal:
			color = Color.FromArgb(205, 236, 240);
			color2 = Color.FromArgb(78, 188, 202);
			break;
		case eTooltipColor.Silver:
			color = Color.FromArgb(225, 225, 232);
			color2 = Color.FromArgb(149, 149, 170);
			break;
		case eTooltipColor.Office2003:
			TypeDescriptor.GetProperties(style)["BackColor"]!.SetValue(style, Color.White);
			TypeDescriptor.GetProperties(style)["BackColor2SchemePart"]!.SetValue(style, eColorSchemePart.MenuSide);
			break;
		case eTooltipColor.Gray:
			color = Color.White;
			color2 = ColorScheme.GetColor("E4E4F0");
			break;
		case eTooltipColor.System:
			if (GlobalManager.Renderer is Office2007Renderer)
			{
				Office2007ColorTable colorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
				color = colorTable.SuperTooltip.BackgroundColors.Start;
				color2 = colorTable.SuperTooltip.BackgroundColors.End;
				style.TextColor = colorTable.SuperTooltip.TextColor;
			}
			break;
		}
		if (!color.IsEmpty)
		{
			TypeDescriptor.GetProperties(style)["BackColor"]!.SetValue(style, color);
		}
		if (!color2.IsEmpty)
		{
			TypeDescriptor.GetProperties(style)["BackColor2"]!.SetValue(style, color2);
		}
		SetRegion();
	}

	public void UpdateWithSuperTooltipInfo(SuperTooltipInfo info)
	{
		if (info.BodyText == null)
		{
			info.BodyText = "";
		}
		if (info.FooterText == null)
		{
			info.FooterText = "";
		}
		image_1 = info.BodyImage;
		((Control)this).set_Text(info.BodyText);
		image_0 = info.FooterImage;
		FooterText = info.FooterText;
		bool_10 = info.FooterVisible;
		HeaderText = info.HeaderText;
		bool_9 = info.HeaderVisible;
		PredefinedColor = info.Color;
	}

	internal void method_11(SuperTooltipInfo superTooltipInfo_0)
	{
		UpdateWithSuperTooltipInfo(superTooltipInfo_0);
		if (superTooltipInfo_0.CustomSize.Width > Class52.smethod_1(GetStyle()) + 4 && superTooltipInfo_0.CustomSize.Height == 0)
		{
			((Control)this).set_Size(GetFixedWidthSize(superTooltipInfo_0.CustomSize.Width));
			return;
		}
		if (!superTooltipInfo_0.CustomSize.IsEmpty && superTooltipInfo_0.CustomSize.Width >= Class52.smethod_1(GetStyle()) + 4 && superTooltipInfo_0.CustomSize.Height >= Class52.smethod_2(GetStyle()) + 4)
		{
			((Control)this).set_Size(superTooltipInfo_0.CustomSize);
			return;
		}
		RecalcSize();
		if (int_2 > 0 && ((Control)this).get_Size().Width > int_2)
		{
			((Control)this).set_Size(GetFixedWidthSize(int_2));
		}
	}

	public void ShowTooltip(SuperTooltipInfo info, int x, int y, bool enforceScreenPosition)
	{
		UpdateWithSuperTooltipInfo(info);
		if (info.CustomSize.Width > Class52.smethod_1(GetStyle()) + 4 && info.CustomSize.Height == 0)
		{
			((Control)this).set_Size(GetFixedWidthSize(info.CustomSize.Width));
		}
		else if (!info.CustomSize.IsEmpty && info.CustomSize.Width >= Class52.smethod_1(GetStyle()) + 4 && info.CustomSize.Height >= Class52.smethod_2(GetStyle()) + 4)
		{
			((Control)this).set_Size(info.CustomSize);
		}
		else
		{
			RecalcSize();
			if (int_2 > 0 && ((Control)this).get_Size().Width > int_2)
			{
				((Control)this).set_Size(GetFixedWidthSize(int_2));
			}
		}
		bool flag = true;
		if (enforceScreenPosition)
		{
			Point mousePosition = Control.get_MousePosition();
			Class273 @class = Class109.smethod_52(mousePosition);
			if (@class != null)
			{
				Rectangle bounds = new Rectangle(x, y, ((Control)this).get_Width(), ((Control)this).get_Height());
				Size size = @class.rectangle_1.Size;
				size.Width -= (int)((float)size.Width * 0.2f);
				if (bounds.Right > @class.rectangle_1.Right)
				{
					bounds.X -= bounds.Right - @class.rectangle_1.Right;
				}
				if (bounds.Bottom > @class.rectangle_0.Bottom)
				{
					bounds.Y = @class.rectangle_0.Bottom - bounds.Height;
				}
				if (bounds.Contains(Control.get_MousePosition().X, Control.get_MousePosition().Y))
				{
					if (bounds.Height + Control.get_MousePosition().Y + 1 <= @class.rectangle_1.Height)
					{
						bounds.Y = Control.get_MousePosition().Y + SystemInformation.get_CursorSize().Height;
					}
					else
					{
						bounds.Y = Control.get_MousePosition().Y - bounds.Height - SystemInformation.get_CursorSize().Height;
					}
				}
				((Control)this).set_Bounds(bounds);
				flag = false;
			}
		}
		if (!((Control)this).get_IsHandleCreated())
		{
			((Control)this).CreateControl();
		}
		Point empty = Point.Empty;
		if (flag)
		{
			empty = new Point(x, y);
			((Control)this).set_Location(empty);
		}
		else
		{
			empty = ((Control)this).get_Location();
		}
		if (Class92.Boolean_1)
		{
			if (control8_0 == null)
			{
				control8_0 = new Control8(Class92.Boolean_2);
				((Control)control8_0).CreateControl();
			}
			((Control)control8_0).Hide();
		}
		if (Class92.Boolean_1 && Environment.OSVersion.Version.Major >= 5 && !Class92.smethod_7())
		{
			Class92.AnimateWindow(((Control)this).get_Handle().ToInt32(), 100, 524288);
		}
		else
		{
			Class92.SetWindowPos(((Control)this).get_Handle(), 0, 0, 0, 0, 0, 83);
		}
		if (control8_0 != null)
		{
			Class92.SetWindowPos(((Control)control8_0).get_Handle(), ((Control)this).get_Handle().ToInt32(), empty.X + 5, empty.Y + 5, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 80);
			control8_0.method_1();
		}
	}

	public void UpdateShadow()
	{
		if (control8_0 != null)
		{
			Class92.SetWindowPos(((Control)control8_0).get_Handle(), ((Control)this).get_Handle().ToInt32(), ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 80);
			control8_0.method_1();
		}
	}

	protected override void OnLocationChanged(EventArgs e)
	{
		((Control)this).OnLocationChanged(e);
		if (control8_0 != null)
		{
			Class92.SetWindowPos(((Control)control8_0).get_Handle(), 0, ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, 0, 0, 81);
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (!((Control)this).get_Visible() && control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
		((ScrollableControl)this).OnVisibleChanged(e);
	}
}

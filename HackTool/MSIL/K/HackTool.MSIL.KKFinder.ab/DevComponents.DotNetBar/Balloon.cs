using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[Designer(typeof(ParentControlDesigner))]
[ToolboxItem(false)]
[ComVisible(false)]
public class Balloon : Form
{
	private class Class177
	{
		private Rectangle rectangle_0 = Rectangle.Empty;

		private Control control_0;

		private bool bool_0;

		private bool bool_1;

		public Image image_0;

		public Image image_1;

		public Image image_2;

		private EventHandler eventHandler_0;

		public bool Boolean_0 => bool_1;

		public bool Boolean_1 => bool_0;

		public Rectangle Rectangle_0
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

		public Point Point_0
		{
			get
			{
				return rectangle_0.Location;
			}
			set
			{
				rectangle_0.Location = value;
			}
		}

		public Size Size_0
		{
			get
			{
				return rectangle_0.Size;
			}
			set
			{
				rectangle_0.Size = value;
			}
		}

		public event EventHandler Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
			}
		}

		public Class177(Control parent, Rectangle bounds)
		{
			control_0 = parent;
			rectangle_0 = bounds;
		}

		public virtual void Paint(Graphics g)
		{
			if (bool_1)
			{
				if (image_2 != null)
				{
					g.DrawImage(image_2, rectangle_0);
				}
			}
			else if (bool_0)
			{
				if (image_1 != null)
				{
					g.DrawImage(image_1, rectangle_0);
				}
			}
			else if (image_0 != null)
			{
				g.DrawImage(image_0, rectangle_0);
			}
		}

		public virtual void OnMouseMove(MouseEventArgs e)
		{
			if (bool_1)
			{
				return;
			}
			if (rectangle_0.Contains(e.get_X(), e.get_Y()))
			{
				if (!bool_0)
				{
					bool_0 = true;
					if (control_0 != null)
					{
						control_0.Invalidate(rectangle_0);
					}
				}
			}
			else if (bool_0)
			{
				bool_0 = false;
				if (control_0 != null)
				{
					control_0.Invalidate(rectangle_0);
				}
			}
		}

		public virtual void OnMouseDown(MouseEventArgs e)
		{
			if (rectangle_0.Contains(e.get_X(), e.get_Y()) && !bool_1)
			{
				bool_1 = true;
				if (control_0 != null)
				{
					control_0.Invalidate(rectangle_0);
				}
			}
		}

		public virtual void OnMouseUp(MouseEventArgs e)
		{
			if (rectangle_0.Contains(e.get_X(), e.get_Y()) && bool_1)
			{
				bool_1 = false;
				if (control_0 != null)
				{
					control_0.Invalidate(rectangle_0);
				}
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
			}
			else if (bool_0 || bool_1)
			{
				bool_1 = false;
				bool_0 = false;
				if (control_0 != null)
				{
					control_0.Invalidate(rectangle_0);
				}
			}
		}

		public virtual void OnMouseLeave(EventArgs e)
		{
			if (bool_0 && !bool_1)
			{
				bool_0 = false;
				if (control_0 != null)
				{
					control_0.Invalidate(rectangle_0);
				}
			}
		}
	}

	private const int int_0 = 4;

	private const int int_1 = 4;

	private const int int_2 = 1;

	private const int int_3 = 1;

	private const int int_4 = 33;

	private const int int_5 = 3;

	private IContainer icontainer_0;

	private CustomPaintEventHandler customPaintEventHandler_0;

	private CustomPaintEventHandler customPaintEventHandler_1;

	private CustomPaintEventHandler customPaintEventHandler_2;

	private CustomPaintEventHandler customPaintEventHandler_3;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private int int_6 = 16;

	private int int_7 = 8;

	private int int_8 = 32;

	private eTipPosition eTipPosition_0;

	private Color color_0 = Color.Empty;

	private int int_9 = 90;

	private eBackgroundImagePosition eBackgroundImagePosition_0;

	private int int_10 = 255;

	private Color color_1 = SystemColors.InfoText;

	private bool bool_0 = true;

	private Class177 class177_0;

	private eBallonStyle eBallonStyle_0;

	private Image image_0;

	private Image image_1;

	private Image image_2;

	private Image image_3;

	private Icon icon_0;

	private Font font_0;

	private string string_0 = "";

	private StringAlignment stringAlignment_0;

	private Color color_2 = SystemColors.InfoText;

	private StringAlignment stringAlignment_1;

	private StringAlignment stringAlignment_2 = (StringAlignment)1;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private bool bool_1 = true;

	private int int_11;

	private Timer timer_0;

	private Color color_3 = Color.FromArgb(241, 239, 226);

	private Color color_4 = Color.White;

	private Color color_5 = Color.FromArgb(236, 233, 216);

	private Color color_6 = Color.FromArgb(172, 168, 153);

	private Color color_7 = Color.FromArgb(113, 111, 100);

	private eAlertAnimation eAlertAnimation_0 = eAlertAnimation.BottomToTop;

	private int int_12 = 200;

	private bool bool_2;

	private bool bool_3;

	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	public bool AntiAlias
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			((Control)this).Invalidate();
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the target gradient background color.")]
	public Color BackColor2
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[Category("Style")]
	[DefaultValue(90)]
	[Description("Indicates gradient fill angle.")]
	[Browsable(true)]
	public int BackColorGradientAngle
	{
		get
		{
			return int_9;
		}
		set
		{
			if (value != int_9)
			{
				int_9 = value;
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[DefaultValue(255)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the transparency of background image.")]
	public int BackgroundImageAlpha
	{
		get
		{
			return int_10;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			else if (value > 255)
			{
				value = 255;
			}
			if (int_10 != value)
			{
				int_10 = value;
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies background image position when container is larger than image.")]
	[Category("Appearance")]
	[DefaultValue(eBackgroundImagePosition.Stretch)]
	public eBackgroundImagePosition BackgroundImagePosition
	{
		get
		{
			return eBackgroundImagePosition_0;
		}
		set
		{
			if (eBackgroundImagePosition_0 != value)
			{
				eBackgroundImagePosition_0 = value;
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates border color.")]
	public Color BorderColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			if (((Component)this).DesignMode)
			{
				((Control)this).Refresh();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(eBallonStyle.Balloon)]
	[Browsable(true)]
	[Description("Specifies balloon style.")]
	[Category("Style")]
	public eBallonStyle Style
	{
		get
		{
			return eBallonStyle_0;
		}
		set
		{
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			if (eBallonStyle_0 != value)
			{
				eBallonStyle_0 = value;
				if (eBallonStyle_0 == eBallonStyle.Alert)
				{
					((Control)this).set_BackColor(Color.FromArgb(207, 221, 244));
					BackColor2 = Color.White;
					((Control)this).set_ForeColor(Color.FromArgb(102, 114, 196));
					stringAlignment_1 = (StringAlignment)1;
				}
				else if (eBallonStyle_0 == eBallonStyle.Office2007Alert)
				{
					Office2007ColorTable office2007ColorTable = method_5();
					ColorScheme legacyColors = office2007ColorTable.LegacyColors;
					((Control)this).set_BackColor(legacyColors.PanelBackground);
					BackColor2 = legacyColors.PanelBackground2;
					((Control)this).set_ForeColor(legacyColors.PanelText);
					color_1 = legacyColors.PanelBorder;
					stringAlignment_1 = (StringAlignment)0;
				}
				else
				{
					stringAlignment_1 = (StringAlignment)0;
					color_1 = SystemColors.InfoText;
				}
				if (bool_0)
				{
					method_7();
				}
				RecalcLayout();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Description("Indicates whether the Close button is displayed.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(true)]
	public bool ShowCloseButton
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (value != bool_0)
			{
				bool_0 = value;
				method_6();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Category("Behavior")]
	[DefaultValue(eAlertAnimation.BottomToTop)]
	[Browsable(true)]
	[Description("Gets or sets the animation type used to display Alert type balloon.")]
	public eAlertAnimation AlertAnimation
	{
		get
		{
			return eAlertAnimation_0;
		}
		set
		{
			eAlertAnimation_0 = value;
		}
	}

	[Category("Behavior")]
	[Description("Gets or sets the total time in milliseconds alert animation takes.")]
	[DefaultValue(200)]
	[Browsable(true)]
	public int AlertAnimationDuration
	{
		get
		{
			return int_12;
		}
		set
		{
			int_12 = value;
		}
	}

	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Indicates whether balloon will close automatically when user click the close button.")]
	public bool AutoClose
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

	[Browsable(true)]
	[DefaultValue(0)]
	[Category("Behavior")]
	[Description("Indicates time period in seconds after balloon closes automatically.")]
	public int AutoCloseTimeOut
	{
		get
		{
			return int_11;
		}
		set
		{
			int_11 = value;
			OnAutoCloseTimeOutChanged();
		}
	}

	[Browsable(true)]
	[Description("Indicates custom image for Close Button.")]
	[Category("Appearance")]
	public Image CloseButtonNormal
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
				method_6();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[DefaultValue(null)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates custom image for Close Button when mouse is over the button.")]
	public Image CloseButtonHot
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
				method_6();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Description("Indicates custom image for Close Button when button is pressed.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(null)]
	public Image CloseButtonPressed
	{
		get
		{
			return image_2;
		}
		set
		{
			if (image_2 != value)
			{
				image_2 = value;
				method_6();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates Caption image.")]
	[Category("Appearance")]
	[DefaultValue(null)]
	public Image CaptionImage
	{
		get
		{
			return image_3;
		}
		set
		{
			if (image_3 != value)
			{
				image_3 = value;
				RecalcLayout();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(true)]
	[Description("Indicates Caption icon. Icon is used to provide support for alpha-blended images in caption.")]
	[Category("Appearance")]
	public Icon CaptionIcon
	{
		get
		{
			return icon_0;
		}
		set
		{
			if (icon_0 != value)
			{
				icon_0 = value;
				RecalcLayout();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	private Class271 Class271_0
	{
		get
		{
			if (icon_0 != null)
			{
				return new Class271(icon_0, dispose: false);
			}
			if (image_3 != null)
			{
				return new Class271(image_3, dispose: false);
			}
			return null;
		}
	}

	[Description("Indicates Caption font.")]
	[Browsable(true)]
	[Category("Appearance")]
	public Font CaptionFont
	{
		get
		{
			return font_0;
		}
		set
		{
			if (font_0 != value)
			{
				font_0 = value;
				RecalcLayout();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Description("Indicates text displayed in caption.")]
	[Localizable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue("")]
	public string CaptionText
	{
		get
		{
			return string_0;
		}
		set
		{
			if (string_0 != value)
			{
				string_0 = value;
				RecalcLayout();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates color of caption text")]
	public Color CaptionColor
	{
		get
		{
			return color_2;
		}
		set
		{
			if (color_2 != value)
			{
				color_2 = value;
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Description("Indicates position of the balloon tip.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eTipPosition.Top)]
	public eTipPosition TipPosition
	{
		get
		{
			return eTipPosition_0;
		}
		set
		{
			if (eTipPosition_0 != value)
			{
				eTipPosition_0 = value;
				RecalcLayout();
				if (eventHandler_1 != null)
				{
					eventHandler_1(this, new EventArgs());
				}
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates tip distance from the edge of the balloon.")]
	[DefaultValue(32)]
	public int TipOffset
	{
		get
		{
			return int_8;
		}
		set
		{
			if (int_8 != value)
			{
				if (value < int_7)
				{
					value = int_7 + 1;
				}
				else if ((eTipPosition_0 == eTipPosition.Top || eTipPosition_0 == eTipPosition.Bottom) && value > ((Control)this).get_Width() - int_7 - int_6)
				{
					value = ((Control)this).get_Width() - int_7 - int_6;
				}
				else if ((eTipPosition_0 == eTipPosition.Left || eTipPosition_0 == eTipPosition.Right) && value > ((Control)this).get_Height() - int_7 - int_6)
				{
					value = ((Control)this).get_Height() - int_7 - int_6;
				}
				int_8 = value;
				RecalcLayout();
				if (((Component)this).DesignMode)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[Browsable(false)]
	[Description("Returns tip length")]
	[Category("Appearance")]
	public int TipLength => int_6;

	[DevCoBrowsable(true)]
	public bool Visible
	{
		get
		{
			return ((Control)this).get_Visible();
		}
		set
		{
			if (value)
			{
				Show();
			}
			else
			{
				Hide();
			}
		}
	}

	public event CustomPaintEventHandler PaintBackground
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customPaintEventHandler_0 = (CustomPaintEventHandler)Delegate.Combine(customPaintEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customPaintEventHandler_0 = (CustomPaintEventHandler)Delegate.Remove(customPaintEventHandler_0, value);
		}
	}

	public event CustomPaintEventHandler PaintCaptionImage
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customPaintEventHandler_1 = (CustomPaintEventHandler)Delegate.Combine(customPaintEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customPaintEventHandler_1 = (CustomPaintEventHandler)Delegate.Remove(customPaintEventHandler_1, value);
		}
	}

	public event CustomPaintEventHandler PaintCaptionText
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customPaintEventHandler_2 = (CustomPaintEventHandler)Delegate.Combine(customPaintEventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customPaintEventHandler_2 = (CustomPaintEventHandler)Delegate.Remove(customPaintEventHandler_2, value);
		}
	}

	public event CustomPaintEventHandler PaintText
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			customPaintEventHandler_3 = (CustomPaintEventHandler)Delegate.Combine(customPaintEventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			customPaintEventHandler_3 = (CustomPaintEventHandler)Delegate.Remove(customPaintEventHandler_3, value);
		}
	}

	public event EventHandler CloseButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event EventHandler TipPositionChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public Balloon()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		method_7();
		InitializeComponent();
		if (icontainer_0 == null)
		{
			icontainer_0 = new Container();
		}
		font_0 = new Font(((Control)this).get_Font(), (FontStyle)1);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)1, true);
	}

	protected override void Dispose(bool disposing)
	{
		method_9();
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).set_AccessibleRole((AccessibleRole)31);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Control)this).set_BackColor(SystemColors.Info);
		((Form)this).set_ClientSize(new Size(192, 80));
		((Form)this).set_ControlBox(false);
		((Control)this).set_ForeColor(SystemColors.InfoText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Balloon");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
	}

	protected override void OnClick(EventArgs e)
	{
		if (!bool_0 || !class177_0.Rectangle_0.Contains(((Control)this).PointToClient(Control.get_MousePosition())))
		{
			((Control)this).OnClick(e);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = e.get_Graphics().get_SmoothingMode();
		TextRenderingHint textRenderingHint = e.get_Graphics().get_TextRenderingHint();
		if (bool_3)
		{
			e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
			e.get_Graphics().set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		if (eBallonStyle_0 == eBallonStyle.Balloon)
		{
			method_1(e.get_Graphics());
		}
		else
		{
			method_0(e.get_Graphics());
		}
		e.get_Graphics().set_SmoothingMode(smoothingMode);
		e.get_Graphics().set_TextRenderingHint(textRenderingHint);
	}

	private void method_0(Graphics graphics_0)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Invalid comparison between Unknown and I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Invalid comparison between Unknown and I4
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Invalid comparison between Unknown and I4
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Invalid comparison between Unknown and I4
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Invalid comparison between Unknown and I4
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Invalid comparison between Unknown and I4
		Rectangle rectangle = method_2();
		if (customPaintEventHandler_0 != null)
		{
			customPaintEventHandler_0(this, new CustomPaintEventArgs(graphics_0, rectangle));
		}
		else
		{
			method_4(graphics_0);
			if (eBallonStyle_0 == eBallonStyle.Alert)
			{
				Rectangle rectangle2 = rectangle;
				rectangle2.Height = Math.Max(rectangle_0.Bottom, rectangle_1.Bottom) - rectangle2.Top;
				rectangle2.Height++;
				if (rectangle2.Width > 0 && rectangle2.Height > 0)
				{
					LinearGradientBrush val = Class109.smethod_40(rectangle2, ((Control)this).get_BackColor(), color_0, int_9);
					try
					{
						Blend val2 = new Blend(4);
						val2.set_Positions(new float[4] { 0f, 0.5f, 0.5f, 1f });
						val2.set_Factors(new float[4] { 0f, 1f, 1f, 0f });
						val.set_Blend(val2);
						graphics_0.FillRectangle((Brush)(object)val, rectangle2);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
			}
		}
		Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
		if (eBallonStyle_0 == eBallonStyle.Office2007Alert)
		{
			Class50.smethod_6(graphics_0, color_1, displayRectangle);
		}
		else
		{
			displayRectangle.Width--;
			displayRectangle.Height--;
			Pen val3 = new Pen(color_3, 1f);
			try
			{
				graphics_0.DrawLine(val3, displayRectangle.X, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y);
				graphics_0.DrawLine(val3, displayRectangle.X, displayRectangle.Y, displayRectangle.X, displayRectangle.Bottom);
				graphics_0.DrawLine(val3, displayRectangle.X + 4, displayRectangle.Bottom - 4, displayRectangle.Right - 4, displayRectangle.Bottom - 4);
				graphics_0.DrawLine(val3, displayRectangle.Right - 4, displayRectangle.Y + 4, displayRectangle.Right - 4, displayRectangle.Bottom - 4);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			Pen val4 = new Pen(color_4, 1f);
			try
			{
				graphics_0.DrawLine(val4, displayRectangle.X + 1, displayRectangle.Y + 1, displayRectangle.Right - 1, displayRectangle.Y + 1);
				graphics_0.DrawLine(val4, displayRectangle.X + 1, displayRectangle.Y + 1, displayRectangle.X + 1, displayRectangle.Bottom - 1);
				graphics_0.DrawLine(val4, displayRectangle.X + 3, displayRectangle.Bottom - 3, displayRectangle.Right - 3, displayRectangle.Bottom - 3);
				graphics_0.DrawLine(val4, displayRectangle.Right - 3, displayRectangle.Y + 3, displayRectangle.Right - 3, displayRectangle.Bottom - 3);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			Pen val5 = new Pen(color_5, 1f);
			try
			{
				graphics_0.DrawLine(val5, displayRectangle.X + 2, displayRectangle.Y + 2, displayRectangle.Right - 2, displayRectangle.Y + 2);
				graphics_0.DrawLine(val5, displayRectangle.X + 2, displayRectangle.Y + 2, displayRectangle.X + 2, displayRectangle.Bottom - 2);
				graphics_0.DrawLine(val5, displayRectangle.X + 2, displayRectangle.Bottom - 2, displayRectangle.Right - 2, displayRectangle.Bottom - 2);
				graphics_0.DrawLine(val5, displayRectangle.Right - 2, displayRectangle.Y + 2, displayRectangle.Right - 2, displayRectangle.Bottom - 2);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			Pen val6 = new Pen(color_6, 1f);
			try
			{
				graphics_0.DrawLine(val6, displayRectangle.X + 3, displayRectangle.Y + 3, displayRectangle.Right - 3, displayRectangle.Y + 3);
				graphics_0.DrawLine(val6, displayRectangle.X + 3, displayRectangle.Y + 3, displayRectangle.X + 3, displayRectangle.Bottom - 3);
				graphics_0.DrawLine(val6, displayRectangle.X + 1, displayRectangle.Bottom - 1, displayRectangle.Right - 1, displayRectangle.Bottom - 1);
				graphics_0.DrawLine(val6, displayRectangle.Right - 1, displayRectangle.Y + 1, displayRectangle.Right - 1, displayRectangle.Bottom - 1);
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
			Pen val7 = new Pen(color_7, 1f);
			try
			{
				graphics_0.DrawLine(val7, displayRectangle.X + 4, displayRectangle.Y + 4, displayRectangle.Right - 4, displayRectangle.Y + 4);
				graphics_0.DrawLine(val7, displayRectangle.X + 4, displayRectangle.Y + 4, displayRectangle.X + 4, displayRectangle.Bottom - 4);
				graphics_0.DrawLine(val7, displayRectangle.X, displayRectangle.Bottom, displayRectangle.Right, displayRectangle.Bottom);
				graphics_0.DrawLine(val7, displayRectangle.Right, displayRectangle.Y, displayRectangle.Right, displayRectangle.Bottom);
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
		if (class177_0 != null)
		{
			class177_0.Paint(graphics_0);
		}
		if (customPaintEventHandler_1 != null)
		{
			customPaintEventHandler_1(this, new CustomPaintEventArgs(graphics_0, rectangle_0));
		}
		else
		{
			Class271 class271_ = Class271_0;
			if (class271_ != null && !rectangle_0.IsEmpty)
			{
				class271_.method_0(graphics_0, rectangle_0);
			}
		}
		if (customPaintEventHandler_2 != null)
		{
			customPaintEventHandler_2(this, new CustomPaintEventArgs(graphics_0, rectangle_1));
		}
		else if (string_0 != "" && !rectangle_1.IsEmpty)
		{
			eTextFormat eTextFormat2 = eTextFormat.WordBreak;
			if ((int)stringAlignment_0 == 1)
			{
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
			else if ((int)stringAlignment_0 == 2)
			{
				eTextFormat2 |= eTextFormat.Right;
			}
			Font font = font_0;
			if (font == null)
			{
				font = ((Control)this).get_Font();
			}
			Class55.smethod_1(graphics_0, string_0, font, color_2, rectangle_1, eTextFormat2);
		}
		if (customPaintEventHandler_3 != null)
		{
			customPaintEventHandler_3(this, new CustomPaintEventArgs(graphics_0, rectangle_2));
		}
		else if (((Control)this).get_Text() != "")
		{
			eTextFormat eTextFormat3 = eTextFormat.WordBreak;
			if ((int)stringAlignment_1 == 1)
			{
				eTextFormat3 |= eTextFormat.HorizontalCenter;
			}
			else if ((int)stringAlignment_1 == 2)
			{
				eTextFormat3 |= eTextFormat.Right;
			}
			if ((int)stringAlignment_2 == 1)
			{
				eTextFormat3 |= eTextFormat.VerticalCenter;
			}
			else if ((int)stringAlignment_2 == 2)
			{
				eTextFormat3 |= eTextFormat.Bottom;
			}
			Class55.smethod_1(graphics_0, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_ForeColor(), rectangle_2, eTextFormat3);
		}
	}

	private void method_1(Graphics graphics_0)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		GraphicsPath val = method_3(rectangle);
		if (customPaintEventHandler_0 != null)
		{
			customPaintEventHandler_0(this, new CustomPaintEventArgs(graphics_0, rectangle));
		}
		else
		{
			method_4(graphics_0);
		}
		Pen val2 = new Pen(color_1, 1f);
		try
		{
			val2.set_Alignment((PenAlignment)1);
			graphics_0.DrawPath(val2, val);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (class177_0 != null)
		{
			class177_0.Paint(graphics_0);
		}
		if (customPaintEventHandler_1 != null)
		{
			customPaintEventHandler_1(this, new CustomPaintEventArgs(graphics_0, rectangle_0));
		}
		else
		{
			Class271 class271_ = Class271_0;
			if (class271_ != null && !rectangle_0.IsEmpty)
			{
				class271_.method_0(graphics_0, rectangle_0);
			}
		}
		if (customPaintEventHandler_2 != null)
		{
			customPaintEventHandler_2(this, new CustomPaintEventArgs(graphics_0, rectangle_1));
		}
		else if (string_0 != "" && !rectangle_1.IsEmpty)
		{
			eTextFormat eTextFormat_ = Class55.smethod_8(stringAlignment_0) | eTextFormat.WordBreak;
			Font font = font_0;
			if (font == null)
			{
				font = ((Control)this).get_Font();
			}
			Class55.smethod_1(graphics_0, string_0, font, color_2, rectangle_1, eTextFormat_);
		}
		if (customPaintEventHandler_3 != null)
		{
			customPaintEventHandler_3(this, new CustomPaintEventArgs(graphics_0, rectangle_2));
		}
		else if (((Control)this).get_Text() != "")
		{
			eTextFormat eTextFormat_2 = Class55.smethod_8(stringAlignment_1) | Class55.smethod_9(stringAlignment_2) | eTextFormat.WordBreak;
			Class55.smethod_1(graphics_0, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_ForeColor(), rectangle_2, eTextFormat_2);
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Form)this).OnResize(e);
		if (!bool_2)
		{
			RecalcLayout();
		}
	}

	public void AutoResize()
	{
		Size empty = Size.Empty;
		Size empty2 = Size.Empty;
		Font font = font_0;
		if (font == null)
		{
			font = ((Control)this).get_Font();
		}
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			empty2 = Class55.smethod_3(val, (string_0 != "") ? string_0 : " ", font);
			empty.Width = empty2.Width;
			if (class177_0 != null)
			{
				empty.Width += class177_0.Size_0.Width;
			}
			else
			{
				empty.Width += 18;
			}
			empty.Width += 4;
			int val2 = 0;
			if (icon_0 != null)
			{
				empty.Width += icon_0.get_Width() + 4;
				val2 = icon_0.get_Height();
			}
			else if (image_3 != null)
			{
				empty.Width += image_3.get_Width() + 4;
				val2 = image_3.get_Height();
			}
			empty.Height += Math.Max(val2, empty2.Height);
			empty.Height += 8;
			empty2 = Class55.smethod_4(val, (((Control)this).get_Text() != "") ? ((Control)this).get_Text() : " ", ((Control)this).get_Font(), empty.Width, eTextFormat.WordBreak);
			empty.Height += empty2.Height;
			empty.Width += int_7 * 2;
			empty.Height += int_7 * 2;
			if (eBallonStyle_0 == eBallonStyle.Balloon)
			{
				if (eTipPosition_0 != eTipPosition.Left && eTipPosition_0 != eTipPosition.Right)
				{
					empty.Height += int_6;
				}
				else
				{
					empty.Width += int_6;
				}
			}
			else
			{
				empty.Height += (int)((double)(float)empty.Height * 0.3);
			}
		}
		finally
		{
			val.Dispose();
		}
		((Form)this).set_Size(empty);
	}

	public void RecalcLayout()
	{
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Invalid comparison between Unknown and I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Invalid comparison between Unknown and I4
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Invalid comparison between Unknown and I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Invalid comparison between Unknown and I4
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		if (((Control)this).get_DisplayRectangle().Width == 0 || ((Control)this).get_DisplayRectangle().Height == 0)
		{
			return;
		}
		if (eBallonStyle_0 == eBallonStyle.Balloon)
		{
			Rectangle rectangle = new Rectangle(int_7 / 2, int_7 / 2, ((Control)this).get_Width() - int_7, ((Control)this).get_Height() - int_7);
			if (eTipPosition_0 == eTipPosition.Bottom)
			{
				rectangle.Height -= int_6;
			}
			else if (eTipPosition_0 == eTipPosition.Left)
			{
				rectangle.X += int_6;
				rectangle.Width -= int_6;
			}
			else if (eTipPosition_0 == eTipPosition.Right)
			{
				rectangle.Width -= int_6;
			}
			else
			{
				rectangle.Y += int_6;
				rectangle.Height -= int_6;
			}
			Size size = Size.Empty;
			if (icon_0 != null)
			{
				size = icon_0.get_Size();
			}
			else if (image_3 != null)
			{
				size = image_3.get_Size();
			}
			rectangle_1 = rectangle;
			if (!size.IsEmpty)
			{
				rectangle_1.X += size.Width + 4;
				rectangle_1.Width -= size.Width + 4;
			}
			if (class177_0 != null)
			{
				class177_0.Point_0 = new Point(rectangle.Right - class177_0.Rectangle_0.Width, rectangle.Top);
				rectangle_1.Width -= class177_0.Size_0.Width + 4;
			}
			Font font = font_0;
			if (font == null)
			{
				font = ((Control)this).get_Font();
			}
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				eTextFormat eTextFormat_ = eTextFormat.WordBreak;
				if ((int)stringAlignment_0 == 1)
				{
					eTextFormat_ = eTextFormat.HorizontalCenter;
				}
				else if ((int)stringAlignment_0 == 2)
				{
					eTextFormat_ = eTextFormat.Right;
				}
				Size size2 = Class55.smethod_4(val, (string_0 != "") ? string_0 : " ", font, rectangle_1.Width, eTextFormat_);
				rectangle_1.Height = size2.Height;
			}
			finally
			{
				val.Dispose();
			}
			if (!size.IsEmpty)
			{
				rectangle_0 = new Rectangle(rectangle.X, rectangle.Y, size.Width, size.Height);
				if (rectangle_1.Height > size.Height)
				{
					rectangle_0.Y += (rectangle_1.Height - size.Height) / 2;
				}
				else if (size.Height > rectangle_1.Height)
				{
					rectangle_1.Y += (size.Height - rectangle_1.Height) / 2;
				}
			}
			else if (class177_0 != null && class177_0.Size_0.Height > rectangle_1.Height)
			{
				rectangle_1.Y += (class177_0.Size_0.Height - rectangle_1.Height) / 2;
			}
			if (rectangle_1.Bottom > rectangle_0.Bottom)
			{
				rectangle_2 = new Rectangle(rectangle.X, rectangle_1.Bottom + 1, rectangle.Width, rectangle.Bottom - (rectangle_1.Bottom + 1));
			}
			else
			{
				rectangle_2 = new Rectangle(rectangle.X, rectangle_0.Bottom + 1, rectangle.Width, rectangle.Bottom - (rectangle_0.Bottom + 1));
			}
			GraphicsPath val2 = method_3(((Control)this).get_DisplayRectangle());
			GraphicsPath val3 = (GraphicsPath)val2.Clone();
			val3.Widen(Pens.get_Black());
			Region val4 = new Region(val3);
			val4.Union(val2);
			((Control)this).set_Region(val4);
			return;
		}
		Rectangle rectangle2 = method_2();
		Size size3 = Size.Empty;
		if (icon_0 != null)
		{
			size3 = icon_0.get_Size();
		}
		else if (image_3 != null)
		{
			size3 = image_3.get_Size();
		}
		rectangle_1 = rectangle2;
		if (!size3.IsEmpty)
		{
			rectangle_1.X += size3.Width + 8;
			rectangle_1.Width -= size3.Width + 8;
		}
		if (class177_0 != null)
		{
			class177_0.Point_0 = new Point(rectangle2.Right - class177_0.Rectangle_0.Width - 1, rectangle2.Top);
			rectangle_1.Width -= class177_0.Size_0.Width + 4 + 1;
		}
		Font font2 = font_0;
		if (font2 == null)
		{
			font2 = ((Control)this).get_Font();
		}
		Graphics val5 = ((Control)this).CreateGraphics();
		try
		{
			eTextFormat eTextFormat_2 = eTextFormat.WordBreak;
			if ((int)stringAlignment_0 == 1)
			{
				eTextFormat_2 = eTextFormat.HorizontalCenter;
			}
			else if ((int)stringAlignment_0 == 2)
			{
				eTextFormat_2 = eTextFormat.Right;
			}
			Size size4 = Class55.smethod_4(val5, (string_0 != "") ? string_0 : " ", font2, rectangle_1.Width, eTextFormat_2);
			rectangle_1.Height = size4.Height;
		}
		finally
		{
			val5.Dispose();
		}
		if (!size3.IsEmpty)
		{
			rectangle_0 = new Rectangle(rectangle2.X + 4, rectangle2.Y, size3.Width, size3.Height);
			if (rectangle_1.Height > size3.Height)
			{
				rectangle_0.Y += (rectangle_1.Height - size3.Height) / 2;
			}
			else if (size3.Height > rectangle_1.Height)
			{
				rectangle_1.Y += (size3.Height + -rectangle_1.Height) / 2;
			}
		}
		else if (class177_0 != null && class177_0.Size_0.Height > rectangle_1.Height)
		{
			rectangle_1.Y += (class177_0.Size_0.Height - rectangle_1.Height) / 2;
		}
		rectangle_1.Offset(0, 1);
		rectangle_0.Offset(0, 1);
		if (class177_0 != null)
		{
			class177_0.Point_0 = new Point(class177_0.Point_0.X, rectangle_1.Y + (rectangle_1.Height - class177_0.Size_0.Height) / 2);
		}
		if (rectangle_1.Bottom > rectangle_0.Bottom)
		{
			rectangle_2 = new Rectangle(rectangle2.X, rectangle_1.Bottom + 4, rectangle2.Width, rectangle2.Bottom - (rectangle_1.Bottom + 4));
		}
		else
		{
			rectangle_2 = new Rectangle(rectangle2.X, rectangle_0.Bottom + 4, rectangle2.Width, rectangle2.Bottom - (rectangle_0.Bottom + 4));
		}
		((Control)this).set_Region(new Region(((Control)this).get_DisplayRectangle()));
	}

	private Rectangle method_2()
	{
		Rectangle result = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		result.Inflate(-4, -4);
		return result;
	}

	private GraphicsPath method_3(Rectangle rectangle_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Invalid comparison between Unknown and I4
		GraphicsPath val = new GraphicsPath();
		Rectangle rectangle = rectangle_3;
		int num = int_7 * 2;
		Matrix val2 = new Matrix();
		Point[] array = new Point[3];
		int num2 = int_8;
		rectangle.Size = new Size(rectangle.Width - 1, rectangle.Height - 1);
		bool flag = false;
		if (eTipPosition_0 == eTipPosition.Bottom)
		{
			flag = true;
			val2.Translate((float)rectangle.Width, (float)rectangle.Height);
			val2.Rotate(180f);
		}
		else if ((eTipPosition_0 == eTipPosition.Left && (int)((Control)this).get_RightToLeft() == 0) || (eTipPosition_0 == eTipPosition.Right && (int)((Control)this).get_RightToLeft() == 1))
		{
			flag = true;
			rectangle.Size = new Size(rectangle.Height, rectangle.Width);
			val2.Translate(0f, (float)rectangle.Width);
			val2.Rotate(-90f);
		}
		else if ((eTipPosition_0 == eTipPosition.Right && (int)((Control)this).get_RightToLeft() == 0) || (eTipPosition_0 == eTipPosition.Left && (int)((Control)this).get_RightToLeft() == 1))
		{
			rectangle.Size = new Size(rectangle.Height, rectangle.Width);
			val2.Translate((float)rectangle.Height, 0f);
			val2.Rotate(90f);
		}
		int num3 = (rectangle.Width - int_7 * 2) / 2 + 1;
		int num4 = int_7;
		if (flag)
		{
			num2 = rectangle.Width - num4 * 2 - int_8 + 1;
		}
		if (num2 < num3)
		{
			ref Point reference = ref array[0];
			reference = new Point(num2 + num4, rectangle.Y + int_6);
			ref Point reference2 = ref array[1];
			reference2 = new Point(num2 + num4, rectangle.Y);
			ref Point reference3 = ref array[2];
			reference3 = new Point(num2 + int_6 + num4, rectangle.Y + int_6);
		}
		else if (num2 > num3)
		{
			ref Point reference4 = ref array[0];
			reference4 = new Point(num2 - int_6 + num4, rectangle.Y + int_6);
			ref Point reference5 = ref array[1];
			reference5 = new Point(num2 + num4, rectangle.Y);
			ref Point reference6 = ref array[2];
			reference6 = new Point(num2 + num4, rectangle.Y + int_6);
		}
		else
		{
			ref Point reference7 = ref array[0];
			reference7 = new Point(num2 - int_6 + num4, rectangle.Y + int_6);
			ref Point reference8 = ref array[1];
			reference8 = new Point(num2 + num4, rectangle.Y);
			ref Point reference9 = ref array[2];
			reference9 = new Point(num2 + int_6 + num4, rectangle.Y + int_6);
		}
		val.AddArc(rectangle.Left, rectangle.Top + int_6, num, num, 180f, 90f);
		val.AddLine(array[0], array[1]);
		val.AddLine(array[1], array[2]);
		val.AddArc(rectangle.Width - num, rectangle.Top + int_6, num, num, -90f, 90f);
		val.AddArc(rectangle.Width - num, rectangle.Bottom - num, num, num, 0f, 90f);
		val.AddArc(rectangle.Left, rectangle.Bottom - num, num, num, 90f, 90f);
		val.CloseFigure();
		val.Transform(val2);
		return val;
	}

	private void method_4(Graphics graphics_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if (clientRectangle.Width == 0 || clientRectangle.Height == 0)
		{
			return;
		}
		if (color_0.IsEmpty)
		{
			SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
			try
			{
				graphics_0.FillRectangle((Brush)(object)val, clientRectangle);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			LinearGradientBrush val2 = Class109.smethod_40(clientRectangle, ((Control)this).get_BackColor(), color_0, int_9);
			try
			{
				if (eBallonStyle_0 == eBallonStyle.Alert)
				{
					Blend val3 = new Blend(4);
					val3.set_Positions(new float[8] { 0f, 0.25f, 0.4f, 0.5f, 0.5f, 0.85f, 0.85f, 1f });
					val3.set_Factors(new float[8] { 0f, 1f, 1f, 0f, 0f, 0f, 0f, 1f });
					val2.set_Blend(val3);
				}
				graphics_0.FillRectangle((Brush)(object)val2, clientRectangle);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		if (((Control)this).get_BackgroundImage() != null)
		{
			Class109.smethod_63(graphics_0, clientRectangle, ((Control)this).get_BackgroundImage(), eBackgroundImagePosition_0, int_10);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBackColor2()
	{
		return !color_0.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor2()
	{
		color_0 = Color.Empty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderColor()
	{
		return color_1 != SystemColors.InfoText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetBorderColor()
	{
		color_1 = SystemColors.InfoText;
	}

	private Office2007ColorTable method_5()
	{
		if (GlobalManager.Renderer is Office2007Renderer office2007Renderer)
		{
			return office2007Renderer.ColorTable;
		}
		return new Office2007ColorTable();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		if (class177_0 != null)
		{
			class177_0.OnMouseDown(e);
		}
		if (((Control)this).get_Focused())
		{
			((Control)this).Focus();
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (class177_0 != null)
		{
			class177_0.OnMouseMove(e);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		if (class177_0 != null)
		{
			class177_0.OnMouseUp(e);
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		if (class177_0 != null)
		{
			class177_0.OnMouseLeave(e);
		}
	}

	private void method_6()
	{
		if (bool_0)
		{
			method_7();
			RecalcLayout();
		}
		else
		{
			class177_0 = null;
		}
	}

	private void method_7()
	{
		if (image_0 != null)
		{
			class177_0 = new Class177((Control)(object)this, new Rectangle(0, 0, image_0.get_Width(), image_0.get_Height()));
			class177_0.image_0 = image_0;
			class177_0.image_1 = image_1;
			class177_0.image_2 = image_2;
		}
		else if (eBallonStyle_0 == eBallonStyle.Balloon)
		{
			class177_0 = new Class177((Control)(object)this, new Rectangle(0, 0, 18, 18));
			class177_0.image_0 = (Image)(object)Class109.smethod_67("BalloonImages.BalloonNormal.png");
			class177_0.image_1 = (Image)(object)Class109.smethod_67("BalloonImages.BalloonHot.png");
			class177_0.image_2 = (Image)(object)Class109.smethod_67("BalloonImages.BalloonPress.png");
		}
		else
		{
			class177_0 = new Class177((Control)(object)this, new Rectangle(0, 0, 13, 13));
			class177_0.image_0 = (Image)(object)Class109.smethod_67("BalloonImages.AlertNormal.png");
			class177_0.image_1 = (Image)(object)Class109.smethod_67("BalloonImages.AlertHot.png");
			class177_0.image_2 = (Image)(object)Class109.smethod_67("BalloonImages.AlertPress.png");
		}
		class177_0.Event_0 += method_8;
	}

	private void method_8(object sender, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
		if (bool_1)
		{
			Hide();
			((Form)this).Close();
		}
	}

	protected void OnAutoCloseTimeOutChanged()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		if (int_11 > 0 && !((Component)this).DesignMode)
		{
			if (timer_0 == null)
			{
				timer_0 = new Timer(icontainer_0);
			}
			timer_0.set_Enabled(false);
			timer_0.set_Interval(int_11 * 1000);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			if (Visible)
			{
				timer_0.set_Enabled(true);
				timer_0.Start();
			}
		}
		else
		{
			method_9();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (!((Control)this).get_IsDisposed())
		{
			method_9();
			Hide();
			((Form)this).Close();
		}
	}

	private void method_9()
	{
		if (timer_0 != null)
		{
			timer_0.set_Enabled(false);
			timer_0.remove_Tick((EventHandler)timer_0_Tick);
			icontainer_0.Remove((IComponent?)timer_0);
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((Form)this).OnVisibleChanged(e);
		if (Visible)
		{
			if (timer_0 != null && !timer_0.get_Enabled())
			{
				timer_0.set_Enabled(true);
				timer_0.Start();
			}
		}
		else if (timer_0 != null && timer_0.get_Enabled())
		{
			timer_0.Stop();
			timer_0.set_Enabled(false);
		}
	}

	private void method_10(eTipPosition eTipPosition_1)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0 || Style != 0)
		{
			return;
		}
		if (eTipPosition_1 == eTipPosition.Top && eTipPosition_0 == eTipPosition.Bottom)
		{
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val = item;
				val.set_Top(val.get_Top() + int_6);
			}
			return;
		}
		if (eTipPosition_1 != eTipPosition.Bottom || eTipPosition_0 != 0)
		{
			return;
		}
		foreach (Control item2 in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val2 = item2;
			val2.set_Top(val2.get_Top() - int_6);
		}
	}

	public void Show(Control referenceControl)
	{
		Show(referenceControl, balloonFocus: true);
	}

	public void Show(Control referenceControl, bool balloonFocus)
	{
		if (referenceControl == null)
		{
			Show();
			return;
		}
		Point empty = Point.Empty;
		empty = ((referenceControl.get_Parent() == null) ? referenceControl.get_Location() : referenceControl.get_Parent().PointToScreen(referenceControl.get_Location()));
		Show(new Rectangle(empty, referenceControl.get_Size()), balloonFocus);
	}

	public void Show(Rectangle referenceScreenRect, bool balloonFocus)
	{
		if (referenceScreenRect.IsEmpty)
		{
			Show();
			return;
		}
		int num = int_6 + int_7 * 3;
		int tipOffset = int_6 / 2 + int_7 * 3;
		Point empty = Point.Empty;
		Class273 @class = Class109.smethod_52(referenceScreenRect.Location);
		if (referenceScreenRect.X + referenceScreenRect.Width / 2 + ((Control)this).get_Width() > @class.rectangle_1.Right)
		{
			empty.X = referenceScreenRect.X + referenceScreenRect.Width / 2 - ((Control)this).get_Width() + num;
			tipOffset = ((Control)this).get_Width() - num;
		}
		else
		{
			empty.X = referenceScreenRect.X + referenceScreenRect.Width / 2 - num;
		}
		if (referenceScreenRect.Y + referenceScreenRect.Height + ((Control)this).get_Height() > @class.rectangle_1.Bottom)
		{
			empty.Y = referenceScreenRect.Y - ((Control)this).get_Height();
			method_10(eTipPosition.Bottom);
			TipPosition = eTipPosition.Bottom;
		}
		else
		{
			empty.Y = referenceScreenRect.Y + referenceScreenRect.Height;
			method_10(eTipPosition.Top);
			TipPosition = eTipPosition.Top;
		}
		TipOffset = tipOffset;
		((Form)this).set_Location(empty);
		Show(balloonFocus);
	}

	public void Show(BaseItem item, bool balloonFocus)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (item != null && item.ContainerControl != null)
		{
			Point location = ((Control)item.ContainerControl).PointToScreen(item.DisplayRectangle.Location);
			Show(new Rectangle(location, item.DisplayRectangle.Size), balloonFocus);
		}
		else
		{
			Show();
		}
	}

	public void Show(bool balloonFocus)
	{
		Rectangle rectangle = new Rectangle(((Form)this).get_Location(), ((Form)this).get_Size());
		Rectangle rectangle2 = method_12();
		if (!balloonFocus)
		{
			if (((Form)this).get_TopMost())
			{
				((Form)this).set_TopMost(false);
				Class92.SetWindowPos(((Control)this).get_Handle(), 0, 0, 0, 0, 0, 83);
				((Form)this).set_TopMost(true);
			}
			else
			{
				Class92.SetWindowPos(((Control)this).get_Handle(), 0, 0, 0, 0, 0, 83);
			}
		}
		if (method_11())
		{
			try
			{
				bool_2 = true;
				Class109.smethod_66((Control)(object)this, bool_3: true, int_12, rectangle2, rectangle);
				return;
			}
			finally
			{
				bool_2 = false;
			}
		}
		((Control)this).Show();
	}

	public void Show()
	{
		Show(balloonFocus: true);
	}

	public void Hide()
	{
		method_9();
		if (method_11())
		{
			Rectangle rectangle = new Rectangle(((Form)this).get_Location(), ((Form)this).get_Size());
			Rectangle rectangle2 = method_12();
			try
			{
				bool_2 = true;
				Class109.smethod_66((Control)(object)this, bool_3: false, int_12, rectangle, rectangle2);
				return;
			}
			finally
			{
				bool_2 = false;
			}
		}
		((Control)this).Hide();
	}

	private bool method_11()
	{
		if (eBallonStyle_0 == eBallonStyle.Alert && eAlertAnimation_0 != 0 && !((Component)this).DesignMode)
		{
			return true;
		}
		return false;
	}

	private Rectangle method_12()
	{
		Rectangle result = new Rectangle(((Form)this).get_Location(), ((Form)this).get_Size());
		if (eAlertAnimation_0 == eAlertAnimation.BottomToTop)
		{
			result.Y = result.Bottom - 1;
			result.Height = 1;
		}
		else if (eAlertAnimation_0 == eAlertAnimation.TopToBottom)
		{
			result.Height = 1;
		}
		else if (eAlertAnimation_0 == eAlertAnimation.LeftToRight)
		{
			result.Width = 2;
		}
		else if (eAlertAnimation_0 == eAlertAnimation.RightToLeft)
		{
			result.X = result.Right - 1;
			result.Width = 1;
		}
		return result;
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 33)
		{
			((Message)(ref m)).set_Result(new IntPtr(3));
		}
		else
		{
			((Form)this).WndProc(ref m);
		}
	}
}

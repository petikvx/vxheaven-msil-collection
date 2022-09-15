using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

[Description("Raises an event when the user clicks it.")]
[ToolboxItem(true)]
[ToolboxBitmap(typeof(GlassButton))]
[ToolboxItemFilter("System.Windows.Forms")]
public class GlassButton : Button
{
	private class TransparentControl : Control
	{
		[DebuggerNonUserCode]
		public TransparentControl()
		{
		}

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		protected override void OnPaint(PaintEventArgs e)
		{
		}
	}

	private Color _backColor;

	private Color _innerBorderColor;

	private Color _outerBorderColor;

	private Color _shineColor;

	private Color _glowColor;

	private bool _fadeOnFocus;

	private bool _IsHovered;

	private bool _IsFocused;

	private bool _IsFocusedByKey;

	private bool _IsKeyDown;

	[AccessedThroughProperty("timer")]
	private Timer _timer;

	private IContainer components;

	private bool _IsMouseDown;

	private EventHandler InnerBorderColorChangedEvent;

	private EventHandler OuterBorderColorChangedEvent;

	private EventHandler ShineColorChangedEvent;

	private EventHandler GlowColorChangedEvent;

	private PaintEventHandler PaintEvent;

	private Button _imageButton;

	private List<Image> _frames;

	private const int FRAME_DISABLED = 0;

	private const int FRAME_PRESSED = 1;

	private const int FRAME_NORMAL = 2;

	private const int FRAME_ANIMATED = 3;

	private const int animationLength = 300;

	private const int framesCount = 10;

	private int _currentFrame;

	private int _direction;

	[DefaultValue(typeof(Color), "Black")]
	public virtual Color BackColor
	{
		get
		{
			return _backColor;
		}
		set
		{
			if (!_backColor.Equals((object?)value))
			{
				_backColor = value;
				UseVisualStyleBackColor = false;
				CreateFrames();
				((Control)this).OnBackColorChanged(EventArgs.Empty);
			}
		}
	}

	[DefaultValue(typeof(Color), "White")]
	public virtual Color ForeColor
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

	[DefaultValue(typeof(Color), "Black")]
	[Category("Appearance")]
	[Description("The inner border color of the control.")]
	public virtual Color InnerBorderColor
	{
		get
		{
			return _innerBorderColor;
		}
		set
		{
			if (_innerBorderColor != value)
			{
				_innerBorderColor = value;
				CreateFrames();
				if (((Control)this).get_IsHandleCreated())
				{
					((Control)this).Invalidate();
				}
				OnInnerBorderColorChanged(EventArgs.Empty);
			}
		}
	}

	[Category("Appearance")]
	[DefaultValue(typeof(Color), "White")]
	[Description("The outer border color of the control.")]
	public virtual Color OuterBorderColor
	{
		get
		{
			return _outerBorderColor;
		}
		set
		{
			if (_outerBorderColor != value)
			{
				_outerBorderColor = value;
				CreateFrames();
				if (((Control)this).get_IsHandleCreated())
				{
					((Control)this).Invalidate();
				}
				OnOuterBorderColorChanged(EventArgs.Empty);
			}
		}
	}

	[DefaultValue(typeof(Color), "White")]
	[Category("Appearance")]
	[Description("The shine color of the control.")]
	public virtual Color ShineColor
	{
		get
		{
			return _shineColor;
		}
		set
		{
			if (_shineColor != value)
			{
				_shineColor = value;
				CreateFrames();
				if (((Control)this).get_IsHandleCreated())
				{
					((Control)this).Invalidate();
				}
				OnShineColorChanged(EventArgs.Empty);
			}
		}
	}

	[Category("Appearance")]
	[Description("The glow color of the control.")]
	[DefaultValue(typeof(Color), "255,141,189,255")]
	public virtual Color GlowColor
	{
		get
		{
			return _glowColor;
		}
		set
		{
			if (_glowColor != value)
			{
				_glowColor = value;
				CreateFrames();
				if (((Control)this).get_IsHandleCreated())
				{
					((Control)this).Invalidate();
				}
				OnGlowColorChanged(EventArgs.Empty);
			}
		}
	}

	[Description("Indicates whether the button should fade in and fade out when it is getting and loosing the focus.")]
	[Category("Appearance")]
	[DefaultValue(false)]
	public virtual bool FadeOnFocus
	{
		get
		{
			return _fadeOnFocus;
		}
		set
		{
			if (_fadeOnFocus != value)
			{
				_fadeOnFocus = value;
			}
		}
	}

	internal virtual Timer timer
	{
		[DebuggerNonUserCode]
		get
		{
			return _timer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = timer_Tick;
			if (_timer != null)
			{
				_timer.remove_Tick(eventHandler);
			}
			_timer = value;
			if (_timer != null)
			{
				_timer.add_Tick(eventHandler);
			}
		}
	}

	private bool IsPressed
	{
		get
		{
			if (!_IsKeyDown && (!_IsMouseDown || !_IsHovered))
			{
				return false;
			}
			return true;
		}
	}

	[Browsable(false)]
	public PushButtonState State
	{
		get
		{
			if (((Control)this).get_Enabled())
			{
				if (!IsPressed)
				{
					if (!_IsHovered)
					{
						if (!_IsFocused && !((ButtonBase)this).get_IsDefault())
						{
							return (PushButtonState)1;
						}
						return (PushButtonState)5;
					}
					return (PushButtonState)2;
				}
				return (PushButtonState)3;
			}
			return (PushButtonState)4;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FlatButtonAppearance FlatAppearance => ((ButtonBase)this).get_FlatAppearance();

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public FlatStyle FlatStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((ButtonBase)this).get_FlatStyle();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((ButtonBase)this).set_FlatStyle(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool UseVisualStyleBackColor
	{
		get
		{
			return ((ButtonBase)this).get_UseVisualStyleBackColor();
		}
		set
		{
			((ButtonBase)this).set_UseVisualStyleBackColor(value);
		}
	}

	private bool HasAnimationFrames
	{
		get
		{
			if (_frames != null && _frames.Count > 3)
			{
				return true;
			}
			return false;
		}
	}

	private bool IsAnimating => _direction != 0;

	[Description("Event raised when the value of the InnerBorderColor property is changed.")]
	[Category("Property Changed")]
	public event EventHandler InnerBorderColorChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			InnerBorderColorChangedEvent = (EventHandler)Delegate.Combine(InnerBorderColorChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			InnerBorderColorChangedEvent = (EventHandler)Delegate.Remove(InnerBorderColorChangedEvent, value);
		}
	}

	[Description("Event raised when the value of the OuterBorderColor property is changed.")]
	[Category("Property Changed")]
	public event EventHandler OuterBorderColorChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			OuterBorderColorChangedEvent = (EventHandler)Delegate.Combine(OuterBorderColorChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			OuterBorderColorChangedEvent = (EventHandler)Delegate.Remove(OuterBorderColorChangedEvent, value);
		}
	}

	[Description("Event raised when the value of the ShineColor property is changed.")]
	[Category("Property Changed")]
	public event EventHandler ShineColorChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			ShineColorChangedEvent = (EventHandler)Delegate.Combine(ShineColorChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			ShineColorChangedEvent = (EventHandler)Delegate.Remove(ShineColorChangedEvent, value);
		}
	}

	[Category("Property Changed")]
	[Description("Event raised when the value of the GlowColor property is changed.")]
	public event EventHandler GlowColorChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			GlowColorChangedEvent = (EventHandler)Delegate.Combine(GlowColorChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			GlowColorChangedEvent = (EventHandler)Delegate.Remove(GlowColorChangedEvent, value);
		}
	}

	public event PaintEventHandler Paint
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			PaintEvent = (PaintEventHandler)Delegate.Combine((Delegate?)(object)PaintEvent, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			PaintEvent = (PaintEventHandler)Delegate.Remove((Delegate?)(object)PaintEvent, (Delegate?)(object)value);
		}
	}

	public GlassButton()
	{
		InitializeComponent();
		timer.set_Interval(30);
		((ButtonBase)this).set_BackColor(Color.Transparent);
		BackColor = Color.Black;
		ForeColor = Color.White;
		OuterBorderColor = Color.White;
		InnerBorderColor = Color.Black;
		ShineColor = Color.White;
		GlowColor = Color.FromArgb(-7488001);
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).SetStyle((ControlStyles)4, false);
	}

	protected virtual void OnInnerBorderColorChanged(EventArgs e)
	{
		InnerBorderColorChangedEvent?.Invoke(this, e);
	}

	protected virtual void OnOuterBorderColorChanged(EventArgs e)
	{
		OuterBorderColorChangedEvent?.Invoke(this, e);
	}

	protected virtual void OnShineColorChanged(EventArgs e)
	{
		ShineColorChangedEvent?.Invoke(this, e);
	}

	protected virtual void OnGlowColorChanged(EventArgs e)
	{
		GlowColorChangedEvent?.Invoke(this, e);
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		CreateFrames();
		((Control)this).OnSizeChanged(e);
	}

	protected override void OnClick(EventArgs e)
	{
		_IsKeyDown = false;
		_IsMouseDown = false;
		((Button)this).OnClick(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		_IsFocused = true;
		_IsFocusedByKey = true;
		((Control)this).OnEnter(e);
		if (_fadeOnFocus)
		{
			FadeIn();
		}
	}

	protected override void OnLeave(EventArgs e)
	{
		((Control)this).OnLeave(e);
		_IsFocused = false;
		_IsFocusedByKey = false;
		_IsKeyDown = false;
		_IsMouseDown = false;
		((Control)this).Invalidate();
		if (_fadeOnFocus)
		{
			FadeOut();
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 32)
		{
			_IsKeyDown = true;
			((Control)this).Invalidate();
		}
		((ButtonBase)this).OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if (_IsKeyDown && (int)e.get_KeyCode() == 32)
		{
			_IsKeyDown = false;
			((Control)this).Invalidate();
		}
		((ButtonBase)this).OnKeyUp(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if (!_IsMouseDown && (int)e.get_Button() == 1048576)
		{
			_IsMouseDown = true;
			_IsFocusedByKey = false;
			((Control)this).Invalidate();
		}
		((ButtonBase)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (_IsMouseDown)
		{
			_IsMouseDown = false;
			((Control)this).Invalidate();
		}
		((Button)this).OnMouseUp(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		((ButtonBase)this).OnMouseMove(e);
		if ((int)e.get_Button() == 0)
		{
			return;
		}
		if (!((Control)this).get_ClientRectangle().Contains(e.get_X(), e.get_Y()))
		{
			if (_IsHovered)
			{
				_IsHovered = false;
				((Control)this).Invalidate();
			}
		}
		else if (!_IsHovered)
		{
			_IsHovered = true;
			((Control)this).Invalidate();
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		_IsHovered = true;
		FadeIn();
		((Control)this).Invalidate();
		((Button)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		_IsHovered = false;
		if (!FadeOnFocus || !_IsFocusedByKey)
		{
			FadeOut();
		}
		((Control)this).Invalidate();
		((Button)this).OnMouseLeave(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		DrawButtonBackgroundFromBuffer(e.get_Graphics());
		DrawForegroundFromButton(e);
		DrawButtonForeground(e.get_Graphics());
		PaintEventHandler paintEvent = PaintEvent;
		if (paintEvent != null)
		{
			paintEvent.Invoke((object)this, e);
		}
	}

	private void DrawButtonBackgroundFromBuffer(Graphics graphics)
	{
		int index;
		if (!((Control)this).get_Enabled())
		{
			index = 0;
		}
		else if (IsPressed)
		{
			index = 1;
		}
		else if (!IsAnimating && _currentFrame == 0)
		{
			index = 2;
		}
		else
		{
			if (!HasAnimationFrames)
			{
				CreateFrames(withAnimationFrames: true);
			}
			index = checked(3 + _currentFrame);
		}
		if (_frames == null || _frames.Count == 0)
		{
			CreateFrames();
		}
		graphics.DrawImage(_frames[index], Point.Empty);
	}

	private Image CreateBackgroundFrame(bool pressed, bool hovered, bool animating, bool enabled, float glowOpacity)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if (clientRectangle.Width <= 0)
		{
			clientRectangle.Width = 1;
		}
		if (clientRectangle.Height <= 0)
		{
			clientRectangle.Height = 1;
		}
		Image val = (Image)new Bitmap(clientRectangle.Width, clientRectangle.Height);
		Graphics val2 = Graphics.FromImage(val);
		try
		{
			val2.Clear(Color.Transparent);
			DrawButtonBackground(val2, clientRectangle, pressed, hovered, animating, enabled, _outerBorderColor, _backColor, _glowColor, _shineColor, _innerBorderColor, glowOpacity);
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	private static void DrawButtonBackground(Graphics g, Rectangle rectangle, bool pressed, bool hovered, bool animating, bool enabled, Color outerBorderColor, Color backColor, Color glowColor, Color shineColor, Color innerBorderColor, float glowOpacity)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)4);
		Rectangle rectangle2 = rectangle;
		checked
		{
			rectangle2.Width--;
			rectangle2.Height--;
			GraphicsPath val = CreateRoundRectangle(rectangle2, 4);
			try
			{
				Pen val2 = new Pen(outerBorderColor);
				try
				{
					g.DrawPath(val2, val);
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
			rectangle2.X++;
			rectangle2.Y++;
			rectangle2.Width -= 2;
			rectangle2.Height -= 2;
			Rectangle rectangle3 = rectangle2;
			rectangle3.Height >>= 1;
			GraphicsPath val3 = CreateRoundRectangle(rectangle2, 2);
			try
			{
				int alpha = If(pressed, 204, 127);
				Brush val4 = (Brush)new SolidBrush(Color.FromArgb(alpha, backColor));
				try
				{
					g.FillPath(val4, val3);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			if ((hovered || animating) && !pressed)
			{
				GraphicsPath val5 = CreateRoundRectangle(rectangle2, 2);
				try
				{
					g.SetClip(val5, (CombineMode)1);
					GraphicsPath val6 = CreateBottomRadialPath(rectangle2);
					try
					{
						PathGradientBrush val7 = new PathGradientBrush(val6);
						try
						{
							int alpha2 = Convert.ToInt32(178f * glowOpacity + 0.5f);
							RectangleF bounds = val6.GetBounds();
							PointF centerPoint = new PointF((bounds.Left + bounds.Right) / 2f, (bounds.Top + bounds.Bottom) / 2f);
							val7.set_CenterPoint(centerPoint);
							val7.set_CenterColor(Color.FromArgb(alpha2, glowColor));
							val7.set_SurroundColors(new Color[1] { Color.FromArgb(0, glowColor) });
							g.FillPath((Brush)(object)val7, val6);
						}
						finally
						{
							((IDisposable)val7)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val6)?.Dispose();
					}
					g.ResetClip();
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
			if (rectangle3.Width > 0 && rectangle3.Height > 0)
			{
				rectangle3.Height++;
				GraphicsPath val8 = CreateTopRoundRectangle(rectangle3, 2);
				try
				{
					rectangle3.Height++;
					int num = 153;
					unchecked
					{
						if (pressed || !enabled)
						{
							num = Convert.ToInt32(0.4f * (float)num + 0.5f);
						}
						LinearGradientBrush val9 = new LinearGradientBrush(rectangle3, Color.FromArgb(num, shineColor), Color.FromArgb(num / 3, shineColor), (LinearGradientMode)1);
						try
						{
							g.FillPath((Brush)(object)val9, val8);
						}
						finally
						{
							((IDisposable)val9)?.Dispose();
						}
					}
				}
				finally
				{
					((IDisposable)val8)?.Dispose();
				}
				rectangle3.Height -= 2;
			}
			GraphicsPath val10 = CreateRoundRectangle(rectangle2, 3);
			try
			{
				Pen val11 = new Pen(innerBorderColor);
				try
				{
					g.DrawPath(val11, val10);
				}
				finally
				{
					((IDisposable)val11)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val10)?.Dispose();
			}
			g.set_SmoothingMode(smoothingMode);
		}
	}

	private void DrawButtonForeground(Graphics g)
	{
		if (((Control)this).get_Focused() && ((Control)this).get_ShowFocusCues())
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			clientRectangle.Inflate(-4, -4);
			ControlPaint.DrawFocusRectangle(g, clientRectangle);
		}
	}

	private void DrawForegroundFromButton(PaintEventArgs pevent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		if (_imageButton == null)
		{
			_imageButton = new Button();
			((Control)_imageButton).set_Parent((Control)(object)new TransparentControl());
			((Control)_imageButton).SuspendLayout();
			((ButtonBase)_imageButton).set_BackColor(Color.Transparent);
			((ButtonBase)_imageButton).get_FlatAppearance().set_BorderSize(0);
			((ButtonBase)_imageButton).set_FlatStyle((FlatStyle)0);
		}
		else
		{
			((Control)_imageButton).SuspendLayout();
		}
		((ButtonBase)_imageButton).set_AutoEllipsis(((ButtonBase)this).get_AutoEllipsis());
		checked
		{
			if (((Control)this).get_Enabled())
			{
				((Control)_imageButton).set_ForeColor(ForeColor);
			}
			else
			{
				((Control)_imageButton).set_ForeColor(Color.FromArgb(3 * unchecked((int)ForeColor.R) + unchecked((int)_backColor.R) >> 2, 3 * unchecked((int)ForeColor.G) + unchecked((int)_backColor.G) >> 2, 3 * unchecked((int)ForeColor.B) + unchecked((int)_backColor.B) >> 2));
			}
			((Control)_imageButton).set_Font(((Control)this).get_Font());
			((Control)_imageButton).set_RightToLeft(((Control)this).get_RightToLeft());
			((ButtonBase)_imageButton).set_Image(((ButtonBase)this).get_Image());
			if (((ButtonBase)this).get_Image() != null && !((Control)this).get_Enabled())
			{
				Size size = ((ButtonBase)this).get_Image().get_Size();
				ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
				{
					new float[5] { 0.2125f, 0.2125f, 0.2125f, 0f, 0f },
					new float[5] { 0.2577f, 0.2577f, 0.2577f, 0f, 0f },
					new float[5] { 0.0361f, 0.0361f, 0.0361f, 0f, 0f },
					new float[5] { 0f, 0f, 0f, 1f, 0f },
					new float[5] { 0.38f, 0.38f, 0.38f, 0f, 1f }
				});
				ImageAttributes val = new ImageAttributes();
				val.ClearColorKey();
				val.SetColorMatrix(colorMatrix);
				((ButtonBase)_imageButton).set_Image((Image)new Bitmap(((ButtonBase)this).get_Image().get_Width(), ((ButtonBase)this).get_Image().get_Height()));
				Graphics val2 = Graphics.FromImage(((ButtonBase)_imageButton).get_Image());
				try
				{
					Image image = ((ButtonBase)this).get_Image();
					Rectangle rectangle = new Rectangle(0, 0, size.Width, size.Height);
					val2.DrawImage(image, rectangle, 0, 0, size.Width, size.Height, (GraphicsUnit)2, val);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			((ButtonBase)_imageButton).set_ImageAlign(((ButtonBase)this).get_ImageAlign());
			((ButtonBase)_imageButton).set_ImageIndex(((ButtonBase)this).get_ImageIndex());
			((ButtonBase)_imageButton).set_ImageKey(((ButtonBase)this).get_ImageKey());
			((ButtonBase)_imageButton).set_ImageList(((ButtonBase)this).get_ImageList());
			((Control)_imageButton).set_Padding(((Control)this).get_Padding());
			((Control)_imageButton).set_Size(((Control)this).get_Size());
			((ButtonBase)_imageButton).set_Text(((ButtonBase)this).get_Text());
			((ButtonBase)_imageButton).set_TextAlign(((ButtonBase)this).get_TextAlign());
			((ButtonBase)_imageButton).set_TextImageRelation(((ButtonBase)this).get_TextImageRelation());
			((ButtonBase)_imageButton).set_UseCompatibleTextRendering(((ButtonBase)this).get_UseCompatibleTextRendering());
			((ButtonBase)_imageButton).set_UseMnemonic(((ButtonBase)this).get_UseMnemonic());
			((Control)_imageButton).ResumeLayout();
			((Control)this).InvokePaint((Control)(object)_imageButton, pevent);
			if (((ButtonBase)_imageButton).get_Image() != null && ((ButtonBase)_imageButton).get_Image() != ((ButtonBase)this).get_Image())
			{
				((ButtonBase)_imageButton).get_Image().Dispose();
				((ButtonBase)_imageButton).set_Image((Image)null);
			}
		}
	}

	private static GraphicsPath CreateRoundRectangle(Rectangle rectangle, int radius)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		int left = rectangle.Left;
		int top = rectangle.Top;
		int width = rectangle.Width;
		int height = rectangle.Height;
		int num = radius << 1;
		val.AddArc(left, top, num, num, 180f, 90f);
		checked
		{
			val.AddLine(left + radius, top, left + width - radius, top);
			val.AddArc(left + width - num, top, num, num, 270f, 90f);
			val.AddLine(left + width, top + radius, left + width, top + height - radius);
			val.AddArc(left + width - num, top + height - num, num, num, 0f, 90f);
			val.AddLine(left + width - radius, top + height, left + radius, top + height);
			val.AddArc(left, top + height - num, num, num, 90f, 90f);
			val.AddLine(left, top + height - radius, left, top + radius);
			val.CloseFigure();
			return val;
		}
	}

	private static GraphicsPath CreateTopRoundRectangle(Rectangle rectangle, int radius)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		int left = rectangle.Left;
		int top = rectangle.Top;
		int width = rectangle.Width;
		int height = rectangle.Height;
		int num = radius << 1;
		val.AddArc(left, top, num, num, 180f, 90f);
		checked
		{
			val.AddLine(left + radius, top, left + width - radius, top);
			val.AddArc(left + width - num, top, num, num, 270f, 90f);
			val.AddLine(left + width, top + radius, left + width, top + height);
			val.AddLine(left + width, top + height, left, top + height);
			val.AddLine(left, top + height, left, top + radius);
			val.CloseFigure();
			return val;
		}
	}

	private static GraphicsPath CreateBottomRadialPath(Rectangle rectangle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		RectangleF rectangleF = rectangle;
		rectangleF.X -= rectangleF.Width * 0.35f;
		rectangleF.Y -= rectangleF.Height * 0.15f;
		rectangleF.Width *= 1.7f;
		rectangleF.Height *= 2.3f;
		val.AddEllipse(rectangleF);
		val.CloseFigure();
		return val;
	}

	private void CreateFrames()
	{
		CreateFrames(withAnimationFrames: false);
	}

	private void CreateFrames(bool withAnimationFrames)
	{
		DestroyFrames();
		if (!((Control)this).get_IsHandleCreated())
		{
			return;
		}
		if (_frames == null)
		{
			_frames = new List<Image>();
		}
		_frames.Add(CreateBackgroundFrame(pressed: false, hovered: false, animating: false, enabled: false, 0f));
		_frames.Add(CreateBackgroundFrame(pressed: true, hovered: true, animating: false, enabled: true, 0f));
		_frames.Add(CreateBackgroundFrame(pressed: false, hovered: false, animating: false, enabled: true, 0f));
		if (withAnimationFrames)
		{
			int num = 0;
			do
			{
				_frames.Add(CreateBackgroundFrame(pressed: false, hovered: true, animating: true, enabled: true, Convert.ToSingle(num) / 9f));
				num = checked(num + 1);
			}
			while (num <= 9);
		}
	}

	private void DestroyFrames()
	{
		checked
		{
			if (_frames != null)
			{
				while (_frames.Count > 0)
				{
					_frames[_frames.Count - 1].Dispose();
					_frames.RemoveAt(_frames.Count - 1);
				}
			}
		}
	}

	private void FadeIn()
	{
		_direction = 1;
		timer.set_Enabled(true);
	}

	private void FadeOut()
	{
		_direction = -1;
		timer.set_Enabled(true);
	}

	private void timer_Tick(object sender, EventArgs e)
	{
		checked
		{
			if (timer.get_Enabled())
			{
				((Control)this).Refresh();
				_currentFrame += _direction;
				if (_currentFrame == -1)
				{
					_currentFrame = 0;
					timer.set_Enabled(false);
					_direction = 0;
				}
				else if (_currentFrame == 10)
				{
					_currentFrame = 9;
					timer.set_Enabled(false);
					_direction = 0;
				}
			}
		}
	}

	private static T If<T>(bool condition, T obj1, T obj2)
	{
		if (condition)
		{
			return obj1;
		}
		return obj2;
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		timer = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)this).ResumeLayout(false);
	}
}

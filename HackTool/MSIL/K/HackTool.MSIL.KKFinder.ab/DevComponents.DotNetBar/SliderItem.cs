using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[Browsable(false)]
[Designer(typeof(SimpleItemDesigner))]
public class SliderItem : BaseItem
{
	private int int_4 = 100;

	private int int_5;

	private int int_6;

	private int int_7 = 1;

	private bool bool_22 = true;

	private int int_8 = 136;

	private int int_9 = 38;

	private eSliderLabelPosition eSliderLabelPosition_0;

	private eSliderPart eSliderPart_0;

	private eSliderPart eSliderPart_1;

	private int int_10 = 18;

	private Size size_0 = new Size(11, 15);

	private bool bool_23 = true;

	private Color color_0 = Color.Empty;

	private string string_7 = "";

	private string string_8 = "";

	private string string_9 = "";

	private EventHandler eventHandler_14;

	private CancelIntValueEventHandler cancelIntValueEventHandler_0;

	private Timer timer_0;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private Rectangle rectangle_3 = Rectangle.Empty;

	private Rectangle rectangle_4 = Rectangle.Empty;

	private bool bool_24 = true;

	private eOrientation eOrientation_0;

	internal eSliderPart ESliderPart_0
	{
		get
		{
			return eSliderPart_0;
		}
		set
		{
			eSliderPart_0 = value;
			method_22();
			Refresh();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public eSliderPart MouseDownPart
	{
		get
		{
			return eSliderPart_1;
		}
		set
		{
			eSliderPart_1 = value;
			Refresh();
		}
	}

	internal new Rectangle Rectangle_0 => rectangle_0;

	internal Rectangle Rectangle_1 => rectangle_1;

	internal Rectangle Rectangle_2 => rectangle_2;

	internal Rectangle Rectangle_3 => rectangle_3;

	internal Rectangle Rectangle_4
	{
		get
		{
			return rectangle_4;
		}
		set
		{
			rectangle_4 = value;
		}
	}

	[Category("Appearance")]
	[Localizable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[DefaultValue("")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("The text contained in the item.")]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
		}
	}

	protected override bool IsMarkupSupported => bool_24;

	[Description("Indicates whether text-markup support is enabled for items Text property.")]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool EnableMarkup
	{
		get
		{
			return bool_24;
		}
		set
		{
			if (bool_24 != value)
			{
				bool_24 = value;
				NeedRecalcSize = true;
				OnTextChanged();
			}
		}
	}

	[Description("Gets or sets the maximum value of the range of the control.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(100)]
	public int Maximum
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
			Refresh();
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Gets or sets the minimum value of the range of the control.")]
	[DefaultValue(0)]
	public int Minimum
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			Refresh();
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Gets or sets the current position of the slider.")]
	[Category("Behavior")]
	public int Value
	{
		get
		{
			return int_6;
		}
		set
		{
			CancelIntValueEventArgs cancelIntValueEventArgs = new CancelIntValueEventArgs();
			cancelIntValueEventArgs.NewValue = value;
			OnValueChanging(cancelIntValueEventArgs);
			if (!cancelIntValueEventArgs.Cancel)
			{
				if (value < int_5)
				{
					int_6 = int_5;
				}
				else if (value > int_4)
				{
					int_6 = int_4;
				}
				else
				{
					int_6 = value;
				}
				OnValueChanged();
				Refresh();
				OnAppearanceChanged();
				ExecuteCommand();
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Gets or sets the amount by which a call to the PerformStep method increases the current position of the slider.")]
	[DefaultValue(1)]
	public int Step
	{
		get
		{
			return int_7;
		}
		set
		{
			if (int_7 > 0)
			{
				int_7 = value;
			}
		}
	}

	[Category("Behavior")]
	[DefaultValue(true)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Gets or sets whether the label text is displayed.")]
	public bool LabelVisible
	{
		get
		{
			return bool_22;
		}
		set
		{
			bool_22 = value;
			OnAppearanceChanged();
			Refresh();
		}
	}

	[Category("Layout")]
	[DevCoBrowsable(true)]
	[DefaultValue(136)]
	[Description("Indicates the width of the slider part of the item in pixels.")]
	[Browsable(true)]
	public int Width
	{
		get
		{
			return int_8;
		}
		set
		{
			if (int_8 != value && value > 0)
			{
				int_8 = value;
				NeedRecalcSize = true;
				OnAppearanceChanged();
				Refresh();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(38)]
	[Category("Layout")]
	[Description("Indicates width of the label part of the item in pixels.")]
	public int LabelWidth
	{
		get
		{
			return int_9;
		}
		set
		{
			if (int_9 != value && value > 0)
			{
				int_9 = value;
				NeedRecalcSize = true;
				OnAppearanceChanged();
				Refresh();
			}
		}
	}

	[Description("Indicates text label position in relationship to the slider")]
	[Browsable(true)]
	[DefaultValue(eSliderLabelPosition.Left)]
	[Category("Layout")]
	public eSliderLabelPosition LabelPosition
	{
		get
		{
			return eSliderLabelPosition_0;
		}
		set
		{
			eSliderLabelPosition_0 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
			Refresh();
		}
	}

	[Category("Behavior")]
	[DefaultValue(false)]
	[DevCoBrowsable(false)]
	[Description("Gets or sets whether Click event will be auto repeated when mouse button is kept pressed over the item.")]
	[Browsable(false)]
	public override bool ClickAutoRepeat
	{
		get
		{
			return base.ClickAutoRepeat;
		}
		set
		{
			base.ClickAutoRepeat = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(200)]
	[DevCoBrowsable(true)]
	[Description("Gets or sets the auto-repeat interval for the click event when mouse button is kept pressed over the item.")]
	[Category("Behavior")]
	public override int ClickRepeatInterval
	{
		get
		{
			return base.ClickRepeatInterval;
		}
		set
		{
			base.ClickRepeatInterval = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether vertical line track marker is displayed on the slide line.")]
	[Category("Appearance")]
	[Browsable(true)]
	public virtual bool TrackMarker
	{
		get
		{
			return bool_23;
		}
		set
		{
			bool_23 = value;
			Refresh();
		}
	}

	[Browsable(true)]
	[Description("Indicates color of the label text.")]
	[Category("Appearance")]
	public Color TextColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			Refresh();
		}
	}

	[Browsable(false)]
	[Description("Indicates the Key Tips access key or keys for the item when on Ribbon Control or Ribbon Bar.")]
	[Category("Appearance")]
	[DefaultValue("")]
	public override string KeyTips
	{
		get
		{
			return base.KeyTips;
		}
		set
		{
			base.KeyTips = value;
		}
	}

	[Category("Design")]
	[Description("Indicates list of shortcut keys for this item.")]
	[DevCoBrowsable(false)]
	[TypeConverter(typeof(ShortcutsConverter))]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Editor(typeof(ShortcutsDesigner), typeof(UITypeEditor))]
	public override ShortcutsCollection Shortcuts
	{
		get
		{
			return base.Shortcuts;
		}
		set
		{
			base.Shortcuts = value;
		}
	}

	[Category("Behavior")]
	[DevCoBrowsable(false)]
	[DefaultValue(true)]
	[Browsable(false)]
	[Description("Determines whether sub-items are displayed.")]
	public override bool ShowSubItems
	{
		get
		{
			return base.ShowSubItems;
		}
		set
		{
			base.ShowSubItems = value;
		}
	}

	[DefaultValue(false)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Description("Specifies whether item is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[Category("Appearance")]
	public override bool ThemeAware
	{
		get
		{
			return base.ThemeAware;
		}
		set
		{
			base.ThemeAware = value;
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(false)]
	[Description("Indicates whether item will stretch to consume empty space. Items on stretchable, no-wrap Bars only.")]
	[Browsable(false)]
	[DefaultValue(false)]
	public override bool Stretch
	{
		get
		{
			return base.Stretch;
		}
		set
		{
			base.Stretch = value;
		}
	}

	[DefaultValue("")]
	[Browsable(true)]
	[Localizable(true)]
	[Category("Appearance")]
	[Description("Indicates tooltip for the Increase button of the slider.")]
	public string IncreaseTooltip
	{
		get
		{
			return string_8;
		}
		set
		{
			string_8 = value;
			method_22();
		}
	}

	[Localizable(true)]
	[Description("Indicates tooltip for the Increase button of the slider.")]
	[Category("Appearance")]
	[DefaultValue("")]
	[Browsable(true)]
	public string DecreaseTooltip
	{
		get
		{
			return string_7;
		}
		set
		{
			string_7 = value;
			method_22();
		}
	}

	[Category("Appearance")]
	[DefaultValue(eOrientation.Horizontal)]
	[Description("Indicates slider orientation.")]
	public eOrientation SliderOrientation
	{
		get
		{
			return eOrientation_0;
		}
		set
		{
			if (eOrientation_0 != value)
			{
				eOrientation_0 = value;
				NeedRecalcSize = true;
				Refresh();
			}
		}
	}

	public event EventHandler ValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_14 = (EventHandler)Delegate.Combine(eventHandler_14, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_14 = (EventHandler)Delegate.Remove(eventHandler_14, value);
		}
	}

	public event CancelIntValueEventHandler ValueChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelIntValueEventHandler_0 = (CancelIntValueEventHandler)Delegate.Combine(cancelIntValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelIntValueEventHandler_0 = (CancelIntValueEventHandler)Delegate.Remove(cancelIntValueEventHandler_0, value);
		}
	}

	public SliderItem()
		: this("", "")
	{
	}

	public SliderItem(string sItemName)
		: this(sItemName, "")
	{
	}

	public SliderItem(string sItemName, string ItemText)
		: base(sItemName, ItemText)
	{
		ClickRepeatInterval = 200;
		bool_15 = true;
		bool_16 = true;
	}

	public override BaseItem Copy()
	{
		SliderItem sliderItem = new SliderItem(m_Name);
		CopyToItem(sliderItem);
		return sliderItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		SliderItem sliderItem = copy as SliderItem;
		base.CopyToItem(sliderItem);
		sliderItem.Maximum = Maximum;
		sliderItem.Minimum = Minimum;
		sliderItem.Value = Value;
		sliderItem.Text = Text;
		sliderItem.LabelWidth = LabelWidth;
		sliderItem.LabelVisible = LabelVisible;
		sliderItem.LabelPosition = LabelPosition;
		sliderItem.Width = Width;
	}

	public override void Dispose()
	{
		method_17();
		base.Dispose();
	}

	public override void Paint(ItemPaintArgs p)
	{
		BaseRenderer baseRenderer_ = p.BaseRenderer_0;
		if (baseRenderer_ != null)
		{
			SliderItemRendererEventArgs sliderItemRendererEventArgs = new SliderItemRendererEventArgs(this, p.Graphics);
			sliderItemRendererEventArgs.itemPaintArgs_0 = p;
			baseRenderer_.DrawSliderItem(sliderItemRendererEventArgs);
		}
		else
		{
			Class232 @class = Class274.smethod_20();
			if (@class != null)
			{
				SliderItemRendererEventArgs sliderItemRendererEventArgs2 = new SliderItemRendererEventArgs(this, p.Graphics);
				sliderItemRendererEventArgs2.itemPaintArgs_0 = p;
				@class.Paint(sliderItemRendererEventArgs2);
			}
		}
		if (DesignMode && Focused)
		{
			Rectangle rect = m_Rect;
			rect.Inflate(-1, -1);
			Class32.smethod_0(p.Graphics, rect, p.Colors.ItemDesignTimeBorder);
		}
	}

	public override void RecalcSize()
	{
		Font val = method_21(null);
		int num = int_10;
		Size size = new Size(int_8, num);
		object containerControl = ContainerControl;
		Control val2 = (Control)((containerControl is Control) ? containerControl : null);
		if (val2 == null || val2.get_Disposing() || val2.get_IsDisposed())
		{
			return;
		}
		Graphics val3 = Class109.smethod_68(val2);
		if (val3 == null)
		{
			return;
		}
		if (bool_22)
		{
			Size size2 = Class88.smethod_1(this, val3, size.Width, val, eTextFormat.Default, IsRightToLeft);
			if (eSliderLabelPosition_0 != 0 && eSliderLabelPosition_0 != eSliderLabelPosition.Right)
			{
				size.Height = num + Math.Max(size2.Height, val.get_Height());
			}
			else
			{
				size.Height = Math.Max(num, Math.Max(size2.Height, val.get_Height()));
				size.Width += int_9;
			}
		}
		if (eOrientation_0 == eOrientation.Vertical)
		{
			size = new Size(size.Height, size.Width);
		}
		m_Rect.Size = size;
		method_20();
		base.RecalcSize();
	}

	public eSliderPart HitTest(int x, int y)
	{
		eSliderPart result = eSliderPart.None;
		Rectangle rectangle = Rectangle_1;
		rectangle.Offset(Bounds.Location);
		if (rectangle.Contains(x, y))
		{
			result = eSliderPart.DecreaseButton;
		}
		else
		{
			rectangle = Rectangle_2;
			rectangle.Offset(Bounds.Location);
			if (rectangle.Contains(x, y))
			{
				result = eSliderPart.IncreaseButton;
			}
			else
			{
				rectangle = Rectangle_3;
				rectangle.Offset(Bounds.Location);
				if (rectangle.Contains(x, y))
				{
					result = eSliderPart.TrackArea;
				}
			}
		}
		return result;
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		if (method_2() && !DesignMode)
		{
			if (MouseDownPart == eSliderPart.None)
			{
				eSliderPart eSliderPart2 = HitTest(objArg.get_X(), objArg.get_Y());
				if (ESliderPart_0 != eSliderPart2)
				{
					ESliderPart_0 = eSliderPart2;
				}
			}
			else if (MouseDownPart == eSliderPart.TrackArea)
			{
				if (SliderOrientation == eOrientation.Horizontal)
				{
					Value = method_18(objArg.get_X());
				}
				else
				{
					Value = method_19(objArg.get_Y());
				}
			}
		}
		base.InternalMouseMove(objArg);
	}

	public override void InternalMouseLeave()
	{
		if (eSliderPart_0 != 0)
		{
			ESliderPart_0 = eSliderPart.None;
		}
		method_17();
		if (MouseDownPart != 0)
		{
			MouseDownPart = eSliderPart.None;
		}
		base.InternalMouseLeave();
	}

	private void method_17()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		if (method_2() && !DesignMode && (int)objArg.get_Button() == 1048576)
		{
			eSliderPart eSliderPart3 = (MouseDownPart = HitTest(objArg.get_X(), objArg.get_Y()));
			if (MouseDownPart == eSliderPart.DecreaseButton)
			{
				Value -= Step;
			}
			else if (MouseDownPart == eSliderPart.IncreaseButton)
			{
				PerformStep();
			}
			else if (eSliderPart3 == eSliderPart.TrackArea && !rectangle_4.Contains(objArg.get_X(), objArg.get_Y()))
			{
				if (SliderOrientation == eOrientation.Horizontal)
				{
					Value = method_18(objArg.get_X());
				}
				else
				{
					Value = method_19(objArg.get_Y());
				}
			}
			if (eSliderPart3 == eSliderPart.IncreaseButton || eSliderPart3 == eSliderPart.DecreaseButton)
			{
				if (timer_0 == null)
				{
					timer_0 = new Timer();
				}
				timer_0.set_Interval(ClickRepeatInterval);
				timer_0.add_Tick((EventHandler)timer_0_Tick);
				timer_0.Start();
			}
		}
		base.InternalMouseDown(objArg);
	}

	private int method_18(int int_11)
	{
		int_11 -= (size_0.Width - 2) / 2;
		Rectangle rectangle = Rectangle_3;
		rectangle.Width -= size_0.Width;
		rectangle.Offset(DisplayRectangle.Location);
		if (int_11 <= rectangle.X)
		{
			if (IsRightToLeft)
			{
				return Maximum;
			}
			return Minimum;
		}
		if (int_11 >= rectangle.Right)
		{
			if (IsRightToLeft)
			{
				return Minimum;
			}
			return Maximum;
		}
		float num = (float)(int_11 - rectangle.X) / (float)(rectangle.Right - rectangle.X);
		if (IsRightToLeft)
		{
			num = 1f - num;
		}
		int num2 = Minimum + (int)((float)(Maximum - Minimum) * num);
		if (Step > 1 && Math.Ceiling((float)(num2 - Minimum) / (float)Step) * (double)Step != (double)(num2 - Minimum))
		{
			num2 = Minimum + (int)Math.Ceiling((float)(num2 - Minimum) / (float)Step) * Step;
		}
		return num2;
	}

	private int method_19(int int_11)
	{
		int_11 -= (size_0.Width - 2) / 2;
		Rectangle rectangle = Rectangle_3;
		rectangle.Height -= size_0.Width;
		rectangle.Offset(DisplayRectangle.Location);
		if (int_11 <= rectangle.Y)
		{
			return Maximum;
		}
		if (int_11 >= rectangle.Bottom)
		{
			return Minimum;
		}
		float num = 1f - (float)(int_11 - rectangle.Y) / (float)(rectangle.Bottom - rectangle.Y);
		int num2 = Minimum + (int)((float)(Maximum - Minimum) * num);
		if (Step > 1 && Math.Ceiling((float)(num2 - Minimum) / (float)Step) * (double)Step != (double)(num2 - Minimum))
		{
			num2 = Minimum + (int)Math.Ceiling((float)(num2 - Minimum) / (float)Step) * Step;
		}
		return num2;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (MouseDownPart == eSliderPart.DecreaseButton)
		{
			Value -= Step;
		}
		else if (MouseDownPart == eSliderPart.IncreaseButton)
		{
			PerformStep();
		}
	}

	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		method_17();
		if (MouseDownPart != 0)
		{
			MouseDownPart = eSliderPart.None;
		}
		base.InternalMouseUp(objArg);
	}

	protected override void OnExternalSizeChange()
	{
		method_20();
		base.OnExternalSizeChange();
	}

	private void method_20()
	{
		bool isRightToLeft = IsRightToLeft;
		Rectangle rectangle = new Rectangle(Point.Empty, DisplayRectangle.Size);
		if (bool_22)
		{
			if ((eSliderLabelPosition_0 == eSliderLabelPosition.Left && (!isRightToLeft || eOrientation_0 == eOrientation.Vertical)) || (eSliderLabelPosition_0 == eSliderLabelPosition.Right && isRightToLeft))
			{
				if (eOrientation_0 == eOrientation.Vertical)
				{
					rectangle_0 = new Rectangle(0, 2, rectangle.Width, int_9 - 2);
					rectangle.Height -= int_9;
					rectangle.Y += int_9;
				}
				else
				{
					rectangle_0 = new Rectangle(2, 0, int_9 - 2, rectangle.Height);
					rectangle.Width -= int_9;
					rectangle.X += int_9;
				}
			}
			else if ((eSliderLabelPosition_0 == eSliderLabelPosition.Left && isRightToLeft) || (eSliderLabelPosition_0 == eSliderLabelPosition.Right && (!isRightToLeft || eOrientation_0 == eOrientation.Vertical)))
			{
				if (eOrientation_0 == eOrientation.Vertical)
				{
					rectangle_0 = new Rectangle(0, rectangle.Height - int_9 + 2, rectangle.Width, int_9 - 2);
					rectangle.Height -= int_9;
				}
				else
				{
					rectangle_0 = new Rectangle(rectangle.Width - int_9 + 2, 0, int_9 - 2, rectangle.Height);
					rectangle.Width -= int_9;
				}
			}
			else if (eSliderLabelPosition_0 == eSliderLabelPosition.Top)
			{
				Font val = method_21(null);
				int num = ((val != null) ? val.get_Height() : 14);
				if (base.Class261_0 != null)
				{
					num = base.Class261_0.Bounds.Height;
				}
				int num2 = int_10 + num;
				if (eOrientation_0 == eOrientation.Vertical)
				{
					rectangle_0 = new Rectangle((rectangle.Width - num2) / 2, 0, num, rectangle.Height);
					rectangle.X = rectangle_0.Right;
					rectangle.Width = int_10;
				}
				else
				{
					rectangle_0 = new Rectangle(0, (rectangle.Height - num2) / 2, rectangle.Width, num);
					rectangle.Y = rectangle_0.Bottom;
					rectangle.Height = int_10;
				}
			}
			else if (eSliderLabelPosition_0 == eSliderLabelPosition.Bottom)
			{
				Font val2 = method_21(null);
				int num3 = ((val2 != null) ? val2.get_Height() : 14);
				if (base.Class261_0 != null)
				{
					num3 = base.Class261_0.Bounds.Height;
				}
				int num4 = int_10 + num3;
				if (eOrientation_0 == eOrientation.Vertical)
				{
					rectangle_0 = new Rectangle((rectangle.Width - num4) / 2 + int_10, 0, num3, rectangle.Height);
					rectangle.X = (rectangle.Width - num4) / 2;
					rectangle.Width = int_10;
				}
				else
				{
					rectangle_0 = new Rectangle(0, (rectangle.Height - num4) / 2 + int_10, rectangle.Width, num3);
					rectangle.Y = (rectangle.Height - num4) / 2;
					rectangle.Height = int_10;
				}
			}
		}
		else
		{
			rectangle_0 = Rectangle.Empty;
		}
		if (isRightToLeft && eOrientation_0 == eOrientation.Horizontal)
		{
			rectangle_1 = new Rectangle(rectangle.Right - int_10, rectangle.Y + (rectangle.Height - int_10) / 2, int_10, int_10);
			rectangle_2 = new Rectangle(rectangle.X, rectangle.Y + (rectangle.Height - int_10) / 2, int_10, int_10);
		}
		else if (eOrientation_0 == eOrientation.Horizontal)
		{
			rectangle_1 = new Rectangle(rectangle.X, rectangle.Y + (rectangle.Height - int_10) / 2, int_10, int_10);
			rectangle_2 = new Rectangle(rectangle.Right - int_10, rectangle.Y + (rectangle.Height - int_10) / 2, int_10, int_10);
		}
		else
		{
			rectangle_1 = new Rectangle(rectangle.X + (rectangle.Width - int_10) / 2, rectangle.Bottom - int_10, int_10, int_10);
			rectangle_2 = new Rectangle(rectangle.X + (rectangle.Width - int_10) / 2, rectangle.Y, int_10, int_10);
		}
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			rectangle_3 = new Rectangle(rectangle.X + int_10, rectangle.Y, rectangle.Width - int_10 * 2, rectangle.Height);
		}
		else
		{
			rectangle_3 = new Rectangle(rectangle.X, rectangle.Y + int_10, rectangle.Width, rectangle.Height - int_10 * 2);
		}
	}

	private Font method_21(ItemPaintArgs itemPaintArgs_0)
	{
		Font val = null;
		if (itemPaintArgs_0 != null)
		{
			val = itemPaintArgs_0.Font;
		}
		if (val == null)
		{
			Control val2 = null;
			if (itemPaintArgs_0 != null)
			{
				val2 = itemPaintArgs_0.ContainerControl;
			}
			if (val2 == null)
			{
				object containerControl = ContainerControl;
				val2 = (Control)((containerControl is Control) ? containerControl : null);
			}
			val = ((val2 == null || val2.get_Font() == null) ? SystemInformation.get_MenuFont() : val2.get_Font());
		}
		return val;
	}

	public virtual void PerformStep()
	{
		Value += int_7;
	}

	public virtual void Increment(int value)
	{
		Value += value;
	}

	protected virtual void OnValueChanged()
	{
		if (eventHandler_14 != null)
		{
			eventHandler_14(this, new EventArgs());
		}
	}

	protected virtual void OnValueChanging(CancelIntValueEventArgs e)
	{
		if (cancelIntValueEventHandler_0 != null)
		{
			cancelIntValueEventHandler_0(this, e);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}

	protected override void OnTooltipChanged()
	{
		string_9 = Tooltip;
		method_22();
		base.OnTooltipChanged();
	}

	private void method_22()
	{
		if (!DesignMode)
		{
			if (eSliderPart_0 == eSliderPart.DecreaseButton && string_7 != "")
			{
				method_23(string_7);
			}
			else if (eSliderPart_0 == eSliderPart.IncreaseButton && string_8 != "")
			{
				method_23(string_8);
			}
			else if (m_Tooltip != string_9)
			{
				method_23(string_9);
			}
		}
	}

	private void method_23(string string_10)
	{
		if (m_Tooltip != string_10)
		{
			m_Tooltip = string_10;
			if (base.ToolTipVisible)
			{
				ShowToolTip();
			}
		}
	}
}

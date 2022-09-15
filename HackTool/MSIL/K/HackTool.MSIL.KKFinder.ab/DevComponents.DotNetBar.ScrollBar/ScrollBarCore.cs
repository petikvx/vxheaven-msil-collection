using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.ScrollBar;

public class ScrollBarCore : IDisposable
{
	internal enum Enum27
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4
	}

	private Rectangle rectangle_0 = Rectangle.Empty;

	private eOrientation eOrientation_0 = eOrientation.Vertical;

	private Size size_0 = new Size(15, 17);

	private Size size_1 = new Size(17, 15);

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private Rectangle rectangle_3 = Rectangle.Empty;

	private Enum27 enum27_0 = Enum27.const_4;

	private Control control_0;

	private bool bool_0;

	private Timer timer_0;

	private int int_0;

	private Bitmap bitmap_0;

	private bool bool_1 = true;

	private bool bool_2;

	private bool bool_3;

	private EventHandler eventHandler_0;

	private bool bool_4;

	private bool bool_5;

	private int int_1;

	private ScrollEventHandler scrollEventHandler_0;

	private bool bool_6 = true;

	private bool bool_7;

	private int int_2;

	private int int_3;

	private int int_4 = 1;

	private int int_5 = 16;

	private int int_6;

	private bool bool_8;

	private bool bool_9 = true;

	private bool bool_10 = true;

	private bool Boolean_0
	{
		get
		{
			if (bool_5 && control_0.get_Focused())
			{
				return true;
			}
			return false;
		}
	}

	public bool IsMouseDown => bool_0;

	private ScrollOrientation ScrollOrientation_0
	{
		get
		{
			if (Orientation == eOrientation.Horizontal)
			{
				return (ScrollOrientation)0;
			}
			return (ScrollOrientation)1;
		}
	}

	internal bool Boolean_1
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	internal bool Boolean_2
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

	public Rectangle ThumbDecreaseRectangle
	{
		get
		{
			return rectangle_1;
		}
		set
		{
			rectangle_1 = value;
			method_0();
		}
	}

	public Rectangle ThumbIncreaseRectangle
	{
		get
		{
			return rectangle_2;
		}
		set
		{
			rectangle_2 = value;
			method_0();
		}
	}

	public Rectangle TrackRectangle
	{
		get
		{
			return rectangle_3;
		}
		set
		{
			rectangle_3 = value;
			method_0();
		}
	}

	public Rectangle DisplayRectangle
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
			method_0();
			method_6();
		}
	}

	public eOrientation Orientation
	{
		get
		{
			return eOrientation_0;
		}
		set
		{
			eOrientation_0 = value;
			method_0();
		}
	}

	public int Minimum
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			method_0();
			method_6();
		}
	}

	public int Maximum
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			method_0();
			method_6();
		}
	}

	public int SmallChange
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
		}
	}

	public int LargeChange
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			method_0();
			method_6();
		}
	}

	public int Value
	{
		get
		{
			return int_6;
		}
		set
		{
			value = method_11(value);
			if (int_6 == value && (!bool_4 || bool_5))
			{
				return;
			}
			int_6 = value;
			if (!bool_2)
			{
				method_0();
				method_6();
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				method_5();
			}
		}
	}

	internal Enum27 Enum27_0
	{
		get
		{
			return enum27_0;
		}
		set
		{
			enum27_0 = value;
		}
	}

	public bool Visible
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

	public Control ParentControl
	{
		get
		{
			return control_0;
		}
		set
		{
			control_0 = value;
		}
	}

	public bool Enabled
	{
		get
		{
			return bool_10;
		}
		set
		{
			if (bool_10 != value)
			{
				bool_10 = value;
				method_5();
			}
		}
	}

	public bool IsAppScrollBarStyle
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			method_0();
		}
	}

	public event EventHandler ValueChanged
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

	public event ScrollEventHandler Scroll
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			scrollEventHandler_0 = (ScrollEventHandler)Delegate.Combine((Delegate?)(object)scrollEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			scrollEventHandler_0 = (ScrollEventHandler)Delegate.Remove((Delegate?)(object)scrollEventHandler_0, (Delegate?)(object)value);
		}
	}

	public ScrollBarCore()
		: this(null)
	{
	}

	public ScrollBarCore(Control parentControl)
		: this(parentControl, isPassive: false)
	{
	}

	public ScrollBarCore(Control parentControl, bool isPassive)
	{
		control_0 = parentControl;
		bool_4 = control_0 is ScrollBar || control_0 is ScrollBarAdv;
		bool_5 = control_0 is ScrollBarAdv;
		bool_2 = isPassive;
		method_0();
	}

	internal void method_0()
	{
		if (bitmap_0 != null)
		{
			((Image)bitmap_0).Dispose();
			bitmap_0 = null;
		}
	}

	public void Paint(ItemPaintArgs p)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Invalid comparison between Unknown and I4
		if (rectangle_0.IsEmpty || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || p.Graphics == null)
		{
			return;
		}
		Class241 @class = new Class241();
		@class.Office2007ColorTable_0 = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
		@class.Boolean_0 = bool_3;
		if (bitmap_0 == null)
		{
			try
			{
				bitmap_0 = new Bitmap(rectangle_0.Width, rectangle_0.Height, p.Graphics);
			}
			catch
			{
				return;
			}
			bitmap_0.MakeTransparent();
			bool_1 = true;
		}
		if (!bool_1)
		{
			p.Graphics.DrawImageUnscaled((Image)(object)bitmap_0, rectangle_0.Location);
			return;
		}
		Graphics val = Graphics.FromImage((Image)(object)bitmap_0);
		try
		{
			if (!rectangle_0.Location.IsEmpty)
			{
				val.TranslateTransform((float)(-rectangle_0.X), (float)(-rectangle_0.Y));
			}
			Enum26 state = ((!bool_10) ? Enum26.const_4 : Enum26.const_0);
			if (bool_10 && (enum27_0 != Enum27.const_4 || Boolean_0))
			{
				state = Enum26.const_2;
			}
			bool rtl = false;
			if (control_0 != null)
			{
				rtl = (int)control_0.get_RightToLeft() == 1;
			}
			@class.PaintBackground(val, rectangle_0, state, eOrientation_0 == eOrientation.Horizontal, bool_7, rtl);
			Enum25 position = Enum25.const_0;
			if (eOrientation_0 == eOrientation.Horizontal)
			{
				position = Enum25.const_2;
			}
			if (enum27_0 == Enum27.const_1 && bool_10)
			{
				state = ((!bool_0) ? Enum26.const_1 : Enum26.const_3);
			}
			@class.PaintThumb(val, rectangle_1, position, state);
			position = Enum25.const_1;
			if (enum27_0 == Enum27.const_0 && bool_10)
			{
				state = ((!bool_0) ? Enum26.const_1 : Enum26.const_3);
			}
			else if (enum27_0 != Enum27.const_4 && bool_10)
			{
				state = Enum26.const_2;
			}
			if (eOrientation_0 == eOrientation.Horizontal)
			{
				position = Enum25.const_3;
			}
			@class.PaintThumb(val, rectangle_2, position, state);
			if (enum27_0 == Enum27.const_2 && bool_10)
			{
				state = ((!bool_0) ? Enum26.const_1 : Enum26.const_3);
			}
			else if ((enum27_0 != Enum27.const_4 || Boolean_0) && bool_10)
			{
				state = Enum26.const_2;
			}
			if (eOrientation_0 == eOrientation.Horizontal)
			{
				@class.PaintTrackHorizontal(val, rectangle_3, state);
			}
			else
			{
				@class.PaintTrackVertical(val, rectangle_3, state);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		p.Graphics.DrawImageUnscaled((Image)(object)bitmap_0, rectangle_0.Location);
		bool_1 = false;
	}

	public void MouseMove(MouseEventArgs e)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_10)
		{
			return;
		}
		Point point = new Point(e.get_X(), e.get_Y());
		if (bool_0 && enum27_0 == Enum27.const_2)
		{
			if (!bool_2)
			{
				int int_ = method_1(point);
				method_10(int_, (ScrollEventType)5);
			}
		}
		else
		{
			if ((int)e.get_Button() != 0 && enum27_0 != Enum27.const_4)
			{
				return;
			}
			if (rectangle_0.Contains(point))
			{
				Enum27 @enum = Enum27.const_3;
				if (rectangle_1.Contains(point))
				{
					@enum = Enum27.const_1;
				}
				else if (rectangle_2.Contains(point))
				{
					@enum = Enum27.const_0;
				}
				else if (rectangle_3.Contains(point))
				{
					@enum = Enum27.const_2;
				}
				if (enum27_0 != @enum)
				{
					enum27_0 = @enum;
					method_5();
				}
			}
			else if (enum27_0 != Enum27.const_4)
			{
				enum27_0 = Enum27.const_4;
				method_5();
			}
		}
	}

	private int method_1(Point point_0)
	{
		if (eOrientation_0 == eOrientation.Vertical)
		{
			int val = point_0.Y - int_0;
			val = Math.Max(val, rectangle_1.Bottom);
			val = Math.Min(val, rectangle_2.Y - method_7());
			val -= rectangle_1.Bottom;
			int num = method_8() - method_7();
			return (int)((float)(method_13() - Minimum) * ((float)val / (float)num));
		}
		int val2 = point_0.X - int_0;
		val2 = Math.Max(val2, rectangle_1.Right);
		val2 = Math.Min(val2, rectangle_2.X - method_7());
		val2 -= rectangle_1.Right;
		int num2 = method_8() - method_7();
		return (int)((float)(method_13() - Minimum) * ((float)val2 / (float)num2));
	}

	public void MouseLeave()
	{
		if (enum27_0 != Enum27.const_4 && (!bool_0 || (enum27_0 != Enum27.const_2 && (enum27_0 == Enum27.const_4 || !bool_2))))
		{
			enum27_0 = Enum27.const_4;
			method_5();
		}
	}

	public void MouseDown(MouseEventArgs e)
	{
		if (enum27_0 == Enum27.const_4)
		{
			return;
		}
		bool_0 = true;
		if (bool_2)
		{
			bool_1 = true;
			return;
		}
		if (eOrientation_0 == eOrientation.Vertical)
		{
			int_0 = e.get_Y() - rectangle_3.Y;
		}
		else
		{
			int_0 = e.get_X() - rectangle_3.X;
		}
		if (enum27_0 == Enum27.const_1)
		{
			method_10(Value - int_4, (ScrollEventType)0);
		}
		else if (enum27_0 == Enum27.const_0)
		{
			method_10(Value + int_4, (ScrollEventType)1);
		}
		else if (enum27_0 == Enum27.const_2)
		{
			method_5();
			if (control_0 != null)
			{
				control_0.set_Capture(true);
			}
		}
		else if (enum27_0 == Enum27.const_3)
		{
			method_2(new Point(e.get_X(), e.get_Y()));
		}
		method_4();
	}

	private void method_2(Point point_0)
	{
		if ((eOrientation_0 == eOrientation.Vertical && rectangle_3.Y > point_0.Y) || (eOrientation_0 == eOrientation.Horizontal && rectangle_3.X > point_0.X))
		{
			method_10(Value - LargeChange, (ScrollEventType)2);
		}
		else if (bool_4)
		{
			if (Value + LargeChange > method_13())
			{
				method_10(Value + (Maximum - LargeChange - 1), (ScrollEventType)3);
			}
			else
			{
				method_10(Value + LargeChange, (ScrollEventType)3);
			}
		}
		else
		{
			method_10(Value + LargeChange, (ScrollEventType)3);
		}
	}

	public void MouseUp(MouseEventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		if (control_0 != null && control_0.get_Capture())
		{
			control_0.set_Capture(false);
		}
		if (bool_0)
		{
			if (enum27_0 != Enum27.const_4 && bool_8)
			{
				if (enum27_0 == Enum27.const_2)
				{
					method_12(new ScrollEventArgs((ScrollEventType)4, Value, Value, ScrollOrientation_0));
				}
				method_12(new ScrollEventArgs((ScrollEventType)8, Value, Value, ScrollOrientation_0));
				bool_8 = false;
			}
			method_3();
			bool_0 = false;
			method_5();
		}
		if (!DisplayRectangle.Contains(e.get_X(), e.get_Y()))
		{
			MouseLeave();
		}
	}

	private void method_3()
	{
		if (timer_0 != null)
		{
			timer_0.set_Enabled(false);
			timer_0.remove_Tick((EventHandler)timer_0_Tick);
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	private void method_4()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		if (timer_0 == null)
		{
			int_1 = 0;
			timer_0 = new Timer();
			timer_0.set_Interval(200);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.set_Enabled(true);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_0 && enum27_0 == Enum27.const_1)
		{
			method_10(Value - int_4, (ScrollEventType)0);
		}
		else if (bool_0 && enum27_0 == Enum27.const_0)
		{
			method_10(Value + int_4, (ScrollEventType)1);
		}
		else if (bool_0 && enum27_0 == Enum27.const_3 && control_0 != null)
		{
			Point point = control_0.PointToClient(Control.get_MousePosition());
			if (rectangle_3.Contains(point))
			{
				method_3();
				bool_0 = false;
			}
			else
			{
				method_2(point);
			}
		}
		int_1++;
		if (int_1 > 4 && timer_0 != null && timer_0.get_Interval() > 20)
		{
			Timer obj = timer_0;
			obj.set_Interval(obj.get_Interval() - 10);
		}
	}

	private void method_5()
	{
		bool_1 = true;
		if (control_0 != null && !bool_2)
		{
			control_0.Invalidate(rectangle_0);
			control_0.Update();
		}
	}

	private void method_6()
	{
		if (!bool_2)
		{
			Rectangle rectangle = rectangle_0;
			if (bool_6)
			{
				rectangle.Inflate(-1, -1);
			}
			if (eOrientation_0 == eOrientation.Vertical)
			{
				rectangle_1 = new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, size_0.Height);
				rectangle_2 = new Rectangle(rectangle.X, rectangle.Bottom - size_0.Height, rectangle.Width, size_0.Height);
				int height = method_7();
				rectangle_3 = new Rectangle(rectangle.X, rectangle.Y + method_9(), rectangle.Width, height);
			}
			else
			{
				rectangle_1 = new Rectangle(rectangle.X, rectangle.Y, size_1.Width, rectangle.Height);
				rectangle_2 = new Rectangle(rectangle.Right - size_1.Width, rectangle.Y, size_1.Width, rectangle.Height);
				int width = method_7();
				rectangle_3 = new Rectangle(rectangle.X + method_9(), rectangle.Y, width, rectangle.Height);
			}
		}
	}

	private int method_7()
	{
		int num = 0;
		int num2 = method_8();
		num = (int)((float)num2 * ((float)int_5 / (float)(int_3 - int_2 + 1)));
		num = Math.Max(14, num);
		return Math.Min(num, num2);
	}

	private int method_8()
	{
		Rectangle rectangle = rectangle_0;
		if (bool_6)
		{
			rectangle.Inflate(-1, -1);
		}
		int height = rectangle.Height;
		height = ((eOrientation_0 != 0) ? (height - size_0.Height * 2) : (rectangle.Width - size_1.Width * 2));
		return Math.Max(height, 8);
	}

	private int method_9()
	{
		int num = method_7();
		int num2 = method_8() - num;
		int num3 = Math.Min(num2, Math.Max((int)((float)num2 * ((float)int_6 / (float)method_13())), 0));
		if (eOrientation_0 == eOrientation.Vertical)
		{
			return num3 + size_0.Height;
		}
		return num3 + size_1.Width;
	}

	private void method_10(int int_7, ScrollEventType scrollEventType_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		int_7 = method_11(int_7);
		method_12(new ScrollEventArgs(scrollEventType_0, int_6, int_7, ScrollOrientation_0));
		Value = int_7;
		bool_8 = true;
	}

	private int method_11(int int_7)
	{
		int num = (bool_5 ? method_13() : int_3);
		if (int_7 < int_2)
		{
			int_7 = int_2;
		}
		if (int_7 > num)
		{
			int_7 = num;
		}
		return int_7;
	}

	private void method_12(ScrollEventArgs scrollEventArgs_0)
	{
		ScrollEventHandler val = scrollEventHandler_0;
		if (val != null)
		{
			val.Invoke((object)this, scrollEventArgs_0);
		}
	}

	internal int method_13()
	{
		if (bool_4)
		{
			return int_3 - int_5 + 1;
		}
		return int_3;
	}

	internal bool method_14(ref Message message_0, Keys keys_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		if ((int)keys_0 == 34)
		{
			method_10(Value + int_5, (ScrollEventType)3);
			return true;
		}
		if ((int)keys_0 == 33)
		{
			method_10(Value - int_5, (ScrollEventType)3);
			return true;
		}
		if ((int)keys_0 != 38 && (int)keys_0 != 37)
		{
			if ((int)keys_0 != 40 && (int)keys_0 != 39)
			{
				if ((int)keys_0 == 36)
				{
					method_10(int_2, (ScrollEventType)6);
					return true;
				}
				if ((int)keys_0 == 35)
				{
					method_10(int_3, (ScrollEventType)7);
					return true;
				}
				return false;
			}
			method_10(Value + int_4, (ScrollEventType)1);
			return true;
		}
		method_10(Value - int_4, (ScrollEventType)0);
		return true;
	}

	public void Dispose()
	{
		method_3();
	}

	internal void method_15()
	{
		method_0();
		if (control_0 != null)
		{
			control_0.Invalidate();
		}
	}
}

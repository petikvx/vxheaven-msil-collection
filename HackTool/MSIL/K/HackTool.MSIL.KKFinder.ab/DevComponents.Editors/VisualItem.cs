using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.Editors;

public class VisualItem
{
	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private MouseEventHandler mouseEventHandler_2;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private VisualGroup visualGroup_0;

	private Size size_0 = Size.Empty;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Point point_0;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private eItemAlignment eItemAlignment_0;

	private Enum31 enum31_0;

	public bool Focusable
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				OnFocusableChanged();
			}
		}
	}

	[DefaultValue(true)]
	public bool Enabled
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
				OnRenderInvalid();
			}
		}
	}

	public bool Visible
	{
		get
		{
			return bool_2;
		}
		set
		{
			if (bool_2 != value)
			{
				bool_2 = value;
				OnVisibleChanged();
			}
		}
	}

	public VisualGroup Parent
	{
		get
		{
			return visualGroup_0;
		}
		internal set
		{
			if (visualGroup_0 != value)
			{
				visualGroup_0 = value;
				OnParentChanged();
			}
		}
	}

	public Size Size
	{
		get
		{
			return size_0;
		}
		internal set
		{
			size_0 = value;
		}
	}

	public Rectangle RenderBounds
	{
		get
		{
			return rectangle_0;
		}
		internal set
		{
			rectangle_0 = value;
		}
	}

	public Point Location
	{
		get
		{
			return point_0;
		}
		internal set
		{
			point_0 = value;
		}
	}

	public bool IsRightToLeft
	{
		get
		{
			return bool_3;
		}
		set
		{
			if (bool_3 != value)
			{
				bool_3 = value;
				OnIsRightToLeftChanged();
			}
		}
	}

	public virtual bool IsLayoutValid => bool_4;

	public bool IsFocused => bool_5;

	[DefaultValue(eItemAlignment.Left)]
	public eItemAlignment Alignment
	{
		get
		{
			return eItemAlignment_0;
		}
		set
		{
			if (eItemAlignment_0 != value)
			{
				eItemAlignment_0 = value;
				InvalidateArrange();
			}
		}
	}

	internal Enum31 Enum31_0
	{
		get
		{
			return enum31_0;
		}
		set
		{
			enum31_0 = value;
		}
	}

	public event EventHandler ArrangeInvalid
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

	public event EventHandler RenderInvalid
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

	public event EventHandler Click
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_2 = (EventHandler)Delegate.Combine(eventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_2 = (EventHandler)Delegate.Remove(eventHandler_2, value);
		}
	}

	public event MouseEventHandler MouseClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
	}

	public event MouseEventHandler MouseDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
	}

	public event MouseEventHandler MouseUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
	}

	internal virtual void vmethod_0()
	{
		if (GetIsEnabled())
		{
			OnMouseEnter();
		}
	}

	protected virtual void OnMouseEnter()
	{
	}

	internal virtual void vmethod_1()
	{
		if (GetIsEnabled())
		{
			OnMouseLeave();
		}
	}

	protected virtual void OnMouseLeave()
	{
	}

	internal virtual void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		if (GetIsEnabled())
		{
			OnMouseMove(mouseEventArgs_0);
		}
	}

	protected virtual void OnMouseMove(MouseEventArgs e)
	{
	}

	internal virtual void vmethod_3(MouseEventArgs mouseEventArgs_0)
	{
		if (GetIsEnabled())
		{
			OnMouseWheel(mouseEventArgs_0);
		}
	}

	protected virtual void OnMouseWheel(MouseEventArgs e)
	{
	}

	internal virtual void vmethod_4(MouseEventArgs mouseEventArgs_0)
	{
		if (GetIsEnabled())
		{
			OnMouseDown(mouseEventArgs_0);
		}
	}

	protected virtual void OnMouseDown(MouseEventArgs e)
	{
		if (mouseEventHandler_1 != null)
		{
			mouseEventHandler_1.Invoke((object)this, e);
		}
	}

	internal virtual void vmethod_5(MouseEventArgs mouseEventArgs_0)
	{
		if (GetIsEnabled())
		{
			OnMouseUp(mouseEventArgs_0);
		}
	}

	protected virtual void OnMouseUp(MouseEventArgs e)
	{
		if (mouseEventHandler_2 != null)
		{
			mouseEventHandler_2.Invoke((object)this, e);
		}
	}

	internal virtual void vmethod_6()
	{
		if (GetIsEnabled())
		{
			OnClick();
		}
	}

	protected virtual void OnClick()
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, new EventArgs());
		}
	}

	internal virtual void vmethod_7(MouseEventArgs mouseEventArgs_0)
	{
		if (GetIsEnabled())
		{
			OnMouseClick(mouseEventArgs_0);
		}
	}

	protected virtual void OnMouseClick(MouseEventArgs e)
	{
		if (mouseEventHandler_0 != null)
		{
			mouseEventHandler_0.Invoke((object)this, e);
		}
	}

	internal virtual void vmethod_8(KeyEventArgs keyEventArgs_0)
	{
		OnKeyDown(keyEventArgs_0);
	}

	protected virtual void OnKeyDown(KeyEventArgs e)
	{
	}

	internal virtual void vmethod_9(KeyEventArgs keyEventArgs_0)
	{
		OnKeyUp(keyEventArgs_0);
	}

	protected virtual void OnKeyUp(KeyEventArgs e)
	{
	}

	internal virtual void vmethod_10(KeyPressEventArgs keyPressEventArgs_0)
	{
		OnKeyPress(keyPressEventArgs_0);
	}

	protected virtual void OnKeyPress(KeyPressEventArgs e)
	{
	}

	internal virtual bool vmethod_11(ref Message message_0, Keys keys_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return OnCmdKey(ref message_0, keys_0);
	}

	protected virtual bool OnCmdKey(ref Message msg, Keys keyData)
	{
		return false;
	}

	internal virtual void vmethod_12()
	{
		OnGotFocus();
	}

	protected virtual void OnGotFocus()
	{
		bool_5 = true;
		OnFocusChanged();
	}

	internal virtual void vmethod_13()
	{
		OnLostFocus();
	}

	protected virtual void OnLostFocus()
	{
		bool_5 = false;
		OnFocusChanged();
	}

	protected virtual void OnFocusChanged()
	{
	}

	internal virtual void vmethod_14(PaintInfo paintInfo_0)
	{
		OnPaint(paintInfo_0);
	}

	protected virtual void OnPaint(PaintInfo p)
	{
	}

	protected virtual void OnFocusableChanged()
	{
	}

	protected virtual bool GetIsEnabled()
	{
		if (!bool_1)
		{
			return bool_1;
		}
		VisualItem parent = Parent;
		while (true)
		{
			if (parent != null)
			{
				if (!parent.Enabled)
				{
					break;
				}
				parent = parent.Parent;
				continue;
			}
			return bool_1;
		}
		return false;
	}

	protected virtual bool GetIsEnabled(PaintInfo p)
	{
		if (p.ParentEnabled)
		{
			return bool_1;
		}
		return false;
	}

	protected virtual void OnVisibleChanged()
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.method_0(this);
		}
	}

	public virtual void InvalidateArrange()
	{
		rectangle_0 = Rectangle.Empty;
		point_0 = Point.Empty;
		bool_4 = false;
		if (visualGroup_0 != null)
		{
			visualGroup_0.InvalidateArrange();
		}
		OnArrangeInvalid();
	}

	public virtual void InvalidateRender()
	{
		if (visualGroup_0 != null)
		{
			visualGroup_0.InvalidateRender();
		}
		OnRenderInvalid();
	}

	protected virtual void OnRenderInvalid()
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, new EventArgs());
		}
	}

	protected virtual void OnArrangeInvalid()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}

	protected virtual void OnParentChanged()
	{
	}

	protected virtual void OnIsRightToLeftChanged()
	{
		InvalidateArrange();
	}

	public virtual void PerformLayout(PaintInfo pi)
	{
		bool_4 = true;
	}
}

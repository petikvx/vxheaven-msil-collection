using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.Editors;

public class VisualToggleButton : VisualItem
{
	private EventHandler eventHandler_3;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	[DefaultValue(false)]
	public virtual bool Checked
	{
		get
		{
			return bool_6;
		}
		set
		{
			if (bool_6 != value)
			{
				bool_6 = value;
				InvalidateRender();
				OnCheckedChanged(new EventArgs());
			}
		}
	}

	[Browsable(false)]
	public bool IsMouseDown
	{
		get
		{
			return bool_7;
		}
		internal set
		{
			if (value != bool_7)
			{
				bool_7 = value;
				InvalidateRender();
			}
		}
	}

	[Browsable(false)]
	public bool IsMouseOver
	{
		get
		{
			return bool_8;
		}
		internal set
		{
			if (value != bool_8)
			{
				bool_8 = value;
				InvalidateRender();
			}
		}
	}

	public event EventHandler CheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
		}
	}

	public VisualToggleButton()
	{
		base.Focusable = true;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && GetIsEnabled())
		{
			method_0();
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

	protected override void OnMouseEnter()
	{
		IsMouseOver = true;
		base.OnMouseEnter();
	}

	protected override void OnMouseLeave()
	{
		IsMouseOver = false;
		base.OnMouseLeave();
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 32 && GetIsEnabled())
		{
			method_0();
			e.set_Handled(true);
		}
		base.OnKeyDown(e);
	}

	private void method_0()
	{
		Checked = !Checked;
	}

	protected virtual void OnCheckedChanged(EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
		}
	}
}

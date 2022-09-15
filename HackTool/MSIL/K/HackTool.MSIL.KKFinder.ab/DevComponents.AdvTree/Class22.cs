using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.AdvTree;

[ToolboxItem(false)]
[Designer(typeof(ControlDesigner))]
internal class Class22 : TextBox, ICellEditControl
{
	private bool bool_0;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	public bool EditWordWrap
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			if (bool_0)
			{
				((TextBoxBase)this).set_Multiline(true);
				((TextBox)this).set_ScrollBars((ScrollBars)0);
			}
			else
			{
				((TextBoxBase)this).set_Multiline(false);
			}
		}
	}

	public object CurrentValue
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value.ToString());
		}
	}

	public event EventHandler EditComplete
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

	public event EventHandler CancelEdit
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

	public Class22()
	{
		((Control)this).set_AutoSize(false);
		((TextBoxBase)this).set_BorderStyle((BorderStyle)0);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		((Control)this).OnKeyDown(e);
		if (((int)e.get_KeyCode() == 13 && !bool_0) || ((int)e.get_KeyCode() == 13 && (int)e.get_Modifiers() == 131072))
		{
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
		else if ((int)e.get_KeyCode() == 27 && eventHandler_1 != null)
		{
			eventHandler_1(this, new EventArgs());
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((TextBoxBase)this).OnTextChanged(e);
		method_0();
	}

	private void method_0()
	{
		Graphics val = ((Control)this).CreateGraphics();
		SizeF sizeF = val.MeasureString(((Control)this).get_Text(), ((Control)this).get_Font());
		int num = (int)Math.Ceiling(sizeF.Width);
		int num2 = (int)Math.Ceiling(sizeF.Height);
		if (((Control)this).get_Parent() == null || ((Control)this).get_Right() + (num - ((Control)this).get_Width()) <= ((Control)this).get_Parent().get_Right())
		{
			if (num > ((Control)this).get_Width())
			{
				((Control)this).set_Width(num);
			}
			if (bool_0 && (((Control)this).get_Parent() == null || ((Control)this).get_Bottom() + (num2 - ((Control)this).get_Height()) <= ((Control)this).get_Parent().get_Bottom()) && num2 > ((Control)this).get_Height())
			{
				((Control)this).set_Height(num2);
			}
		}
	}

	public void BeginEdit()
	{
	}

	public void EndEdit()
	{
	}
}

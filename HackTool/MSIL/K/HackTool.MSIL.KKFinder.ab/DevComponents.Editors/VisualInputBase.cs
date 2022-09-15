using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DevComponents.Editors;

public class VisualInputBase : VisualItem
{
	private int int_0;

	private string string_0 = "";

	private bool bool_6 = true;

	private string string_1 = "";

	private EventHandler eventHandler_3;

	private InputValidationEventHandler inputValidationEventHandler_0;

	private EventHandler eventHandler_4;

	private bool bool_7 = true;

	private bool bool_8 = true;

	private string string_2 = "";

	private bool bool_9 = true;

	private bool bool_10;

	protected string InputStack => string_0;

	public int InputPosition => int_0;

	protected bool IsInputStackEmpty => string_0.Length == 0;

	protected virtual bool DrawWatermark
	{
		get
		{
			if (WatermarkEnabled && IsEmpty && WatermarkText.Length > 0)
			{
				return !base.IsFocused;
			}
			return false;
		}
	}

	public virtual bool IsEmpty
	{
		get
		{
			return bool_7;
		}
		set
		{
			if (value != bool_7)
			{
				if (value)
				{
					ResetValue();
				}
				bool_7 = value;
				InvalidateArrange();
				if (base.Parent is VisualInputGroup)
				{
					((VisualInputGroup)base.Parent).UpdateIsEmpty();
				}
				OnIsEmptyChanged();
			}
		}
	}

	public bool AutoOverwrite
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
		}
	}

	public string WatermarkText
	{
		get
		{
			return string_2;
		}
		set
		{
			if (value != null)
			{
				string_2 = value;
			}
		}
	}

	[Description("Indicates whether watermark text is displayed if set.")]
	[DefaultValue(true)]
	public virtual bool WatermarkEnabled
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

	public virtual bool IsReadOnly
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

	public event EventHandler InputChanged
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

	public event InputValidationEventHandler ValidateInput
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			inputValidationEventHandler_0 = (InputValidationEventHandler)Delegate.Combine(inputValidationEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			inputValidationEventHandler_0 = (InputValidationEventHandler)Delegate.Remove(inputValidationEventHandler_0, value);
		}
	}

	public event EventHandler IsEmptyChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_4 = (EventHandler)Delegate.Combine(eventHandler_4, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_4 = (EventHandler)Delegate.Remove(eventHandler_4, value);
		}
	}

	public VisualInputBase()
	{
		base.Focusable = true;
	}

	internal override void vmethod_8(KeyEventArgs keyEventArgs_0)
	{
		if (!bool_10)
		{
			base.vmethod_8(keyEventArgs_0);
		}
	}

	internal override void vmethod_10(KeyPressEventArgs keyPressEventArgs_0)
	{
		if (!bool_10)
		{
			base.vmethod_10(keyPressEventArgs_0);
		}
	}

	internal override void vmethod_9(KeyEventArgs keyEventArgs_0)
	{
		if (!bool_10)
		{
			base.vmethod_9(keyEventArgs_0);
		}
	}

	internal override bool vmethod_11(ref Message message_0, Keys keys_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_10)
		{
			return base.vmethod_11(ref message_0, keys_0);
		}
		return false;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		OnInputKeyDown(e);
		base.OnKeyDown(e);
	}

	protected virtual void OnInputKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 8)
		{
			ProcessBackSpace(e);
		}
		else if ((int)e.get_KeyCode() == 46)
		{
			ProcessDelete(e);
		}
		else if ((int)e.get_KeyCode() == 67 && (int)e.get_Modifiers() == 131072)
		{
			vmethod_16();
			e.set_Handled(true);
		}
		else if ((int)e.get_KeyCode() == 88 && (int)e.get_Modifiers() == 131072)
		{
			vmethod_17();
			e.set_Handled(true);
		}
		else if ((int)e.get_KeyCode() == 86 && (int)e.get_Modifiers() == 131072)
		{
			vmethod_18();
			e.set_Handled(true);
		}
		else if ((int)e.get_KeyCode() == 90 && (int)e.get_Modifiers() == 131072)
		{
			vmethod_19();
			e.set_Handled(true);
		}
	}

	internal virtual void vmethod_15()
	{
		OnClear();
	}

	internal virtual void vmethod_16()
	{
		OnClipboardCopy();
	}

	internal virtual void vmethod_17()
	{
		OnClipboardCut();
	}

	internal virtual void vmethod_18()
	{
		OnClipboardPaste();
	}

	internal virtual void vmethod_19()
	{
		OnUndo();
	}

	protected virtual void OnUndo()
	{
		if (SetInputStack(string_1))
		{
			int_0 = string_0.Length;
			OnInputKeyAccepted();
		}
	}

	public void UndoInput()
	{
		vmethod_19();
	}

	protected virtual void OnClear()
	{
		if (SetInputStack(""))
		{
			int_0 = 0;
		}
	}

	protected virtual void OnClipboardCut()
	{
		OnClipboardCopy();
		OnClear();
	}

	protected virtual void OnClipboardPaste()
	{
		if (Clipboard.ContainsText() && SetInputStack(Clipboard.GetText()))
		{
			int_0 = string_0.Length;
			OnInputKeyAccepted();
		}
	}

	protected virtual void OnClipboardCopy()
	{
		Clipboard.SetText(GetInputStringValue());
	}

	protected virtual string GetInputStringValue()
	{
		return string_0;
	}

	protected virtual void ProcessDelete(KeyEventArgs e)
	{
		OnClear();
		e.set_Handled(true);
	}

	protected virtual void ProcessBackSpace(KeyEventArgs e)
	{
		if (string_0.Length > 0 && int_0 > 0)
		{
			string inputStack = string_0.Substring(0, int_0 - 1) + string_0.Substring(int_0);
			if (SetInputStack(inputStack))
			{
				int_0--;
			}
		}
		else
		{
			OnClear();
		}
		e.set_Handled(true);
	}

	protected virtual void ResetValue()
	{
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		OnInputKeyPress(e);
		base.OnKeyPress(e);
	}

	protected virtual void OnInputKeyPress(KeyPressEventArgs e)
	{
		if (AcceptKeyPress(e))
		{
			UpdateInputStack(e.get_KeyChar());
		}
	}

	protected virtual void UpdateInputStack(char c)
	{
		string text = string_0;
		if (int_0 >= string_0.Length)
		{
			if (int_0 > string_0.Length)
			{
				int_0 = string_0.Length;
			}
			text += c;
		}
		else if (bool_6)
		{
			text.Insert(int_0, c.ToString());
		}
		else
		{
			text = string_0.Substring(0, int_0 - 1) + c + string_0.Substring(int_0 + 1);
		}
		if (SetInputStack(text))
		{
			int_0++;
			OnInputKeyAccepted();
		}
	}

	protected virtual void OnInputKeyAccepted()
	{
	}

	protected virtual bool SetInputStack(string s)
	{
		if (ValidateNewInputStack(s))
		{
			string_0 = s;
			OnInputStackChanged();
			return true;
		}
		return false;
	}

	protected virtual bool ValidateNewInputStack(string s)
	{
		if (inputValidationEventHandler_0 != null)
		{
			InputValidationEventArgs inputValidationEventArgs = new InputValidationEventArgs(s);
			inputValidationEventHandler_0(this, inputValidationEventArgs);
			return inputValidationEventArgs.AcceptInput;
		}
		return true;
	}

	protected virtual void OnInputStackChanged()
	{
		OnInputChanged();
	}

	protected virtual void OnInputChanged()
	{
		if (base.Parent != null)
		{
			base.Parent.method_2(this);
		}
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, new EventArgs());
		}
	}

	protected virtual bool AcceptKeyPress(KeyPressEventArgs e)
	{
		e.set_Handled(true);
		return true;
	}

	protected override void OnGotFocus()
	{
		OnInputGotFocus();
		base.OnGotFocus();
	}

	protected override void OnLostFocus()
	{
		OnInputLostFocus();
		base.OnLostFocus();
	}

	protected virtual void OnInputGotFocus()
	{
		ResetInputStack();
		string_1 = GetInputStringValue();
		InvalidateArrange();
	}

	protected virtual void OnInputLostFocus()
	{
		InvalidateArrange();
	}

	protected void SetInputPosition(int position)
	{
		int_0 = position;
	}

	protected virtual void InputComplete(bool sendNotification)
	{
		if (bool_8)
		{
			ResetInputStack();
		}
		if (sendNotification && base.Parent != null)
		{
			base.Parent.vmethod_16();
		}
	}

	protected void ResetInputStack()
	{
		string_0 = "";
		int_0 = 0;
	}

	public override void PerformLayout(PaintInfo p)
	{
		if (p.WatermarkEnabled && DrawWatermark)
		{
			Font font_ = p.DefaultFont;
			if (p.WatermarkFont != null)
			{
				font_ = p.WatermarkFont;
			}
			Size size2 = (base.Size = Class55.smethod_3(p.Graphics, WatermarkText, font_));
		}
		base.PerformLayout(p);
	}

	protected override void OnPaint(PaintInfo p)
	{
		if (p.WatermarkEnabled && DrawWatermark)
		{
			Font font_ = p.DefaultFont;
			if (p.WatermarkFont != null)
			{
				font_ = p.WatermarkFont;
			}
			Class55.smethod_1(p.Graphics, WatermarkText, font_, p.WatermarkColor, base.RenderBounds, eTextFormat.Default);
		}
		base.OnPaint(p);
	}

	protected virtual void OnIsEmptyChanged()
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(this, new EventArgs());
		}
	}
}

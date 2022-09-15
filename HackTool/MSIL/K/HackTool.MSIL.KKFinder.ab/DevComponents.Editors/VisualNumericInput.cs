using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DevComponents.Editors;

public class VisualNumericInput : VisualInputBase
{
	private EventHandler eventHandler_5;

	private bool bool_11 = true;

	private bool bool_12 = true;

	public bool AllowEmptyState
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

	public bool AllowsNegativeValue
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

	public event EventHandler ValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_5 = (EventHandler)Delegate.Combine(eventHandler_5, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_5 = (EventHandler)Delegate.Remove(eventHandler_5, value);
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if (((int)e.get_KeyCode() == 109 || (int)e.get_KeyCode() == 189) && AllowsNegativeValue)
		{
			if (!IsEmpty)
			{
				NegateValue();
			}
			e.set_Handled(true);
		}
		base.OnKeyDown(e);
	}

	protected override bool OnCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!IsReadOnly)
		{
			if ((int)keyData == 38)
			{
				IncreaseValue();
				return true;
			}
			if ((int)keyData == 40)
			{
				DecreaseValue();
				return true;
			}
		}
		return base.OnCmdKey(ref msg, keyData);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		if (!IsReadOnly)
		{
			if (e.get_Delta() > 0)
			{
				IncreaseValue();
			}
			else
			{
				DecreaseValue();
			}
		}
		base.OnMouseWheel(e);
	}

	public virtual void DecreaseValue()
	{
		InputComplete(sendNotification: true);
	}

	public virtual void IncreaseValue()
	{
		InputComplete(sendNotification: true);
	}

	protected virtual void NegateValue()
	{
	}

	protected override bool AcceptKeyPress(KeyPressEventArgs e)
	{
		if ((e.get_KeyChar() >= '0' && e.get_KeyChar() <= '9') || (AllowsNegativeValue && e.get_KeyChar() == '-' && (IsEmpty || (!IsEmpty && (base.InputStack == "" || base.InputStack == "0")))))
		{
			e.set_Handled(true);
			return true;
		}
		return false;
	}

	public override void PerformLayout(PaintInfo p)
	{
		Size empty = Size.Empty;
		Graphics graphics = p.Graphics;
		Font defaultFont = p.DefaultFont;
		string measureString = GetMeasureString();
		empty = (base.Size = Class55.smethod_4(graphics, measureString, defaultFont, 0, eTextFormat.Default));
		base.PerformLayout(p);
	}

	protected virtual string GetMeasureString()
	{
		return "";
	}

	protected override void OnPaint(PaintInfo p)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		Graphics graphics = p.Graphics;
		Font defaultFont = p.DefaultFont;
		Color color_ = p.ForeColor;
		if (!GetIsEnabled(p))
		{
			color_ = p.DisabledForeColor;
		}
		eTextFormat eTextFormat_ = eTextFormat.Default;
		if (base.IsFocused)
		{
			if (p.Colors.Highlight.IsEmpty)
			{
				graphics.FillRectangle(SystemBrushes.get_Highlight(), base.RenderBounds);
			}
			else
			{
				SolidBrush val = new SolidBrush(p.Colors.Highlight);
				try
				{
					graphics.FillRectangle((Brush)(object)val, base.RenderBounds);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			color_ = (p.Colors.HighlightText.IsEmpty ? SystemColors.HighlightText : p.Colors.HighlightText);
		}
		if (!IsEmpty || !AllowEmptyState)
		{
			string renderString = GetRenderString();
			Class55.smethod_1(graphics, renderString, defaultFont, color_, base.RenderBounds, eTextFormat_);
		}
		base.OnPaint(p);
	}

	protected virtual string GetRenderString()
	{
		return "";
	}

	protected override bool SetInputStack(string s)
	{
		if (base.InputStack == "0" && s != "0" && s.StartsWith("0"))
		{
			s = s.Substring(1);
			SetInputPosition(base.InputPosition - 1);
		}
		return base.SetInputStack(s);
	}

	protected virtual void OnValueChanged()
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, new EventArgs());
		}
	}

	protected override void OnInputLostFocus()
	{
		if (base.InputStack == "-")
		{
			OnClear();
		}
		base.OnInputLostFocus();
	}
}

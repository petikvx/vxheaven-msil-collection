using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.Editors;

namespace DevComponents.AdvTree;

internal class Class206 : IntegerInput, ICellEditControl
{
	private EventHandler eventHandler_10;

	private EventHandler eventHandler_11;

	public object CurrentValue
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			if (value is int)
			{
				base.Value = (int)value;
				return;
			}
			if (value == null)
			{
				base.ValueObject = null;
				return;
			}
			string s = Utilities.smethod_5(value.ToString());
			int result = 0;
			int.TryParse(s, out result);
			base.Value = result;
		}
	}

	public bool EditWordWrap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event EventHandler EditComplete
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_10 = (EventHandler)Delegate.Combine(eventHandler_10, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_10 = (EventHandler)Delegate.Remove(eventHandler_10, value);
		}
	}

	public event EventHandler CancelEdit
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_11 = (EventHandler)Delegate.Combine(eventHandler_11, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_11 = (EventHandler)Delegate.Remove(eventHandler_11, value);
		}
	}

	public void BeginEdit()
	{
		((Control)this).set_MinimumSize(new Size(32, 10));
	}

	public void EndEdit()
	{
		((Component)(object)this).Dispose();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 13)
		{
			if (eventHandler_10 != null)
			{
				eventHandler_10(this, new EventArgs());
			}
			return true;
		}
		if ((int)keyData == 27)
		{
			if (eventHandler_11 != null)
			{
				eventHandler_11(this, new EventArgs());
			}
			return true;
		}
		return base.ProcessCmdKey(ref msg, keyData);
	}
}

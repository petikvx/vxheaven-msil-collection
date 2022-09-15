using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevComponents.Editors;

public class VisualButtonBase : VisualItem
{
	private bool bool_6;

	private Timer timer_0;

	private int int_0 = 300;

	private bool bool_7 = true;

	[DefaultValue(false)]
	public bool ClickAutoRepeat
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

	[Browsable(true)]
	[Category("Behavior")]
	[Description("Gets or sets the auto-repeat interval for the click event when mouse button is kept pressed over the item.")]
	[DefaultValue(300)]
	public virtual int ClickRepeatInterval
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public bool RenderDefaultBackground
	{
		get
		{
			return bool_7;
		}
		set
		{
			if (bool_7 != value)
			{
				bool_7 = value;
				InvalidateRender();
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		if ((int)e.get_Button() == 1048576 && GetIsEnabled() && bool_6)
		{
			if (timer_0 == null)
			{
				timer_0 = new Timer();
			}
			timer_0.set_Interval(ClickRepeatInterval);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.Start();
		}
		base.OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (timer_0 != null)
		{
			Timer val = timer_0;
			timer_0 = null;
			val.Stop();
			val.remove_Tick((EventHandler)timer_0_Tick);
			((Component)(object)val).Dispose();
		}
		base.OnMouseUp(e);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		vmethod_6();
		OnClickAutoRepeat();
	}

	protected virtual void OnClickAutoRepeat()
	{
	}
}

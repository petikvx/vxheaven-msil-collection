using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ComVisible(false)]
[ProvideProperty("BalloonCaption", typeof(Control))]
[ToolboxItem(true)]
[ProvideProperty("BalloonText", typeof(Control))]
public class BalloonTip : Component, IExtenderProvider
{
	private class Class178
	{
		public string string_0;

		public string string_1;
	}

	private EventHandler eventHandler_0;

	private CancelEventHandler cancelEventHandler_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2;

	private eBallonStyle eBallonStyle_0;

	private int int_0 = 500;

	private bool bool_3 = true;

	private int int_1 = 5;

	private eAlertAnimation eAlertAnimation_0 = eAlertAnimation.BottomToTop;

	private int int_2 = 200;

	private bool bool_4;

	private bool bool_5 = true;

	private Balloon balloon_0;

	private Image image_0;

	private Icon icon_0;

	private Hashtable hashtable_0 = new Hashtable();

	private Control control_0;

	private Control control_1;

	private Timer timer_0;

	private Control control_2;

	private int int_3 = 256;

	private bool bool_6;

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Appearance")]
	public bool AntiAlias
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

	[Description("Gets or sets a value indicating whether the BalloonTip is currently active.")]
	[DefaultValue(true)]
	[Category("Misc")]
	public bool Enabled
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public Control BalloonTriggerControl => control_2;

	[DefaultValue(false)]
	[Category("Misc")]
	[Description("Gets or sets a value indicating whether Balloon receives input focus when displayed.")]
	public bool BalloonFocus
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	[Category("Misc")]
	[DefaultValue(500)]
	[Description("Indicates the time (in milliseconds) that passes before the BalloonTip appears.")]
	public int InitialDelay
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

	[DefaultValue(false)]
	[Description("Indicates whether a Balloon window is displayed even when its parent form is not active.")]
	[Category("Misc")]
	public bool ShowAlways
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Balloon BalloonControl
	{
		get
		{
			return balloon_0;
		}
		set
		{
			balloon_0 = value;
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(eBallonStyle.Balloon)]
	[Browsable(true)]
	[Category("Style")]
	[Description("Specifies balloon style.")]
	public eBallonStyle Style
	{
		get
		{
			return eBallonStyle_0;
		}
		set
		{
			if (eBallonStyle_0 != value)
			{
				eBallonStyle_0 = value;
			}
		}
	}

	[DefaultValue(eAlertAnimation.BottomToTop)]
	[Description("Gets or sets the animation type used to display Alert type balloon.")]
	[Category("Behavior")]
	[Browsable(true)]
	public eAlertAnimation AlertAnimation
	{
		get
		{
			return eAlertAnimation_0;
		}
		set
		{
			eAlertAnimation_0 = value;
		}
	}

	[DefaultValue(200)]
	[Browsable(true)]
	[Description("Gets or sets the total time in milliseconds alert animation takes.")]
	[Category("Behavior")]
	public int AlertAnimationDuration
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates whether balloon will close automatically when user click the close button.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	public bool AutoClose
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	[Category("Behavior")]
	[Browsable(true)]
	[Description("Indicates time period in seconds after balloon closes automatically.")]
	[DefaultValue(5)]
	public int AutoCloseTimeOut
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether Balloon is shown after control receives input focus.")]
	[Category("Behavior")]
	[Browsable(true)]
	public bool ShowBalloonOnFocus
	{
		get
		{
			return bool_4;
		}
		set
		{
			if (bool_4 != value)
			{
				bool_4 = value;
			}
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Behavior")]
	[Description("Indicates whether the Balloon Close button is displayed.")]
	public bool ShowCloseButton
	{
		get
		{
			return bool_5;
		}
		set
		{
			if (value != bool_5)
			{
				bool_5 = value;
			}
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(256)]
	[Description("Indicates default balloon width. Usually the width of the balloon is calculated based on the width of the caption text. If caption text is not set then this value will be used as default width of the balloon.")]
	public int DefaultBalloonWidth
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
		}
	}

	[Description("Indicates Balloon Caption image.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Appearance")]
	public Image CaptionImage
	{
		get
		{
			return image_0;
		}
		set
		{
			if (image_0 != value)
			{
				image_0 = value;
			}
		}
	}

	[Description("Indicates Balloon Caption icon. Icon is used to provide support for alpha-blended images in caption.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Appearance")]
	public Icon CaptionIcon
	{
		get
		{
			return icon_0;
		}
		set
		{
			if (icon_0 != value)
			{
				icon_0 = value;
			}
		}
	}

	public event EventHandler BalloonDisplaying
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

	public event CancelEventHandler BalloonClosing
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_0, value);
		}
	}

	protected override void Dispose(bool disposing)
	{
		RemoveAll();
		control_0 = null;
		control_1 = null;
		control_2 = null;
		DestroyDelayTimer();
		base.Dispose(disposing);
	}

	bool IExtenderProvider.CanExtend(object target)
	{
		if (target is Control)
		{
			return true;
		}
		return false;
	}

	[DefaultValue("")]
	[Localizable(true)]
	public string GetBalloonCaption(Control control)
	{
		if (hashtable_0.Contains(control) && hashtable_0[control] is Class178 @class)
		{
			return @class.string_0;
		}
		return "";
	}

	[Localizable(true)]
	public void SetBalloonCaption(Control control, string caption)
	{
		if (caption == null)
		{
			caption = "";
		}
		if (hashtable_0.Contains(control))
		{
			if (hashtable_0[control] is Class178 @class)
			{
				@class.string_0 = caption;
				if (@class.string_0 == "" && @class.string_1 == "")
				{
					Remove(control);
				}
			}
		}
		else if (caption != "")
		{
			Class178 class2 = new Class178();
			class2.string_0 = caption;
			AddControl(control, class2);
		}
	}

	[Localizable(true)]
	[DefaultValue("")]
	public string GetBalloonText(Control control)
	{
		if (hashtable_0.Contains(control) && hashtable_0[control] is Class178 @class)
		{
			return @class.string_1;
		}
		return "";
	}

	[Localizable(true)]
	public void SetBalloonText(Control control, string text)
	{
		if (text == null)
		{
			text = "";
		}
		if (hashtable_0.Contains(control))
		{
			if (hashtable_0[control] is Class178 @class)
			{
				@class.string_1 = text;
				if (@class.string_0 == "" && @class.string_1 == "")
				{
					Remove(control);
				}
			}
		}
		else if (text != "")
		{
			Class178 class2 = new Class178();
			class2.string_1 = text;
			AddControl(control, class2);
		}
	}

	public void RemoveAll()
	{
		Control[] array = (Control[])(object)new Control[hashtable_0.Keys.Count];
		hashtable_0.Keys.CopyTo(array, 0);
		Control[] array2 = array;
		foreach (Control control in array2)
		{
			Remove(control);
		}
		hashtable_0.Clear();
	}

	public void Remove(Control control)
	{
		if (hashtable_0.Contains(control))
		{
			try
			{
				control.remove_MouseEnter((EventHandler)ControlMouseEnter);
				control.remove_MouseLeave((EventHandler)ControlMouseLeave);
				control.remove_Enter((EventHandler)ControlGotFocus);
				control.remove_Leave((EventHandler)ControlLeave);
			}
			catch
			{
			}
			hashtable_0.Remove(control);
		}
	}

	private void AddControl(Control control, Class178 info)
	{
		if (!hashtable_0.Contains(control))
		{
			hashtable_0.Add(control, info);
			control.add_MouseEnter((EventHandler)ControlMouseEnter);
			control.add_MouseLeave((EventHandler)ControlMouseLeave);
			control.add_Enter((EventHandler)ControlGotFocus);
			control.add_Leave((EventHandler)ControlLeave);
		}
	}

	public virtual void ShowBalloon(Control control)
	{
		if (!hashtable_0.Contains(control) || !(hashtable_0[control] is Class178 info))
		{
			return;
		}
		CloseBalloon();
		if (balloon_0 != null)
		{
			return;
		}
		balloon_0 = CreateBalloonControl(info);
		((Form)balloon_0).set_Location(new Point(0, 0));
		control_2 = control;
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
		if (balloon_0 != null)
		{
			Form val = control.FindForm();
			if (val != null)
			{
				((Form)balloon_0).set_Owner(val);
			}
			if (!((Form)balloon_0).get_Location().IsEmpty)
			{
				balloon_0.Show(bool_0);
			}
			else
			{
				balloon_0.Show(control, bool_0);
			}
		}
	}

	private Balloon CreateBalloonControl(Class178 info)
	{
		Balloon balloon = new Balloon();
		balloon.CaptionText = info.string_0;
		((Control)balloon).set_Text(info.string_1);
		balloon.AutoClose = bool_3;
		balloon.AutoCloseTimeOut = int_1;
		balloon.CaptionImage = CaptionImage;
		balloon.CaptionIcon = CaptionIcon;
		balloon.AlertAnimation = eAlertAnimation_0;
		balloon.AlertAnimationDuration = int_2;
		balloon.ShowCloseButton = bool_5;
		balloon.Style = eBallonStyle_0;
		if (!(info.string_0 == "") && info.string_0 != null)
		{
			balloon.AutoResize();
		}
		else
		{
			((Control)balloon).set_Width(DefaultBalloonWidth);
		}
		return balloon;
	}

	public virtual void CloseBalloon()
	{
		control_2 = null;
		if (balloon_0 == null)
		{
			return;
		}
		CancelEventArgs cancelEventArgs = new CancelEventArgs(cancel: false);
		if (cancelEventHandler_0 != null)
		{
			cancelEventHandler_0(this, cancelEventArgs);
		}
		if (!cancelEventArgs.Cancel)
		{
			if (balloon_0.Visible)
			{
				balloon_0.Hide();
			}
			((Form)balloon_0).Close();
			((Component)(object)balloon_0).Dispose();
			balloon_0 = null;
		}
	}

	private void DestroyDelayTimer()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			timer_0.remove_Tick((EventHandler)DelayTimerTick);
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	private void DelayTimerTick(object sender, EventArgs e)
	{
		timer_0.set_Enabled(false);
		DestroyDelayTimer();
		if (bool_1)
		{
			if (bool_4 && control_1 != null)
			{
				ShowBalloon(control_1);
			}
			else if (!bool_4 && control_0 != null)
			{
				ShowBalloon(control_0);
			}
		}
	}

	private void ShowBalloonDelayed(Control control)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		if (control == null || !bool_1)
		{
			return;
		}
		if (!bool_2)
		{
			Form val = control.FindForm();
			if (val.get_IsMdiChild())
			{
				if (val.get_MdiParent() != null && val.get_MdiParent().get_ActiveMdiChild() != val)
				{
					return;
				}
			}
			else if (Form.get_ActiveForm() != val)
			{
				return;
			}
		}
		if (int_0 == 0)
		{
			ShowBalloon(control);
		}
		else if (timer_0 == null)
		{
			timer_0 = new Timer();
			timer_0.add_Tick((EventHandler)DelayTimerTick);
			timer_0.set_Interval(int_0);
			timer_0.Start();
		}
	}

	private void OnMouseEnter()
	{
		if (bool_1 && control_0 != null && !bool_4 && hashtable_0.Contains(control_0))
		{
			ShowBalloonDelayed(control_0);
		}
	}

	private void OnMouseLeave()
	{
		if (!bool_4)
		{
			DestroyDelayTimer();
			CloseBalloon();
		}
	}

	private void OnControlGotFocus()
	{
		if (bool_1 && control_1 != null && bool_4 && hashtable_0.Contains(control_1))
		{
			ShowBalloonDelayed(control_1);
		}
	}

	private void OnControlLeave()
	{
		if (bool_4)
		{
			DestroyDelayTimer();
			CloseBalloon();
		}
	}

	private void ControlMouseEnter(object sender, EventArgs e)
	{
		control_0 = (Control)((sender is Control) ? sender : null);
		OnMouseEnter();
	}

	private void ControlMouseLeave(object sender, EventArgs e)
	{
		control_0 = null;
		OnMouseLeave();
	}

	private void ControlGotFocus(object sender, EventArgs e)
	{
		control_1 = (Control)((sender is Control) ? sender : null);
		OnControlGotFocus();
	}

	private void ControlLeave(object sender, EventArgs e)
	{
		control_1 = null;
		OnControlLeave();
	}
}

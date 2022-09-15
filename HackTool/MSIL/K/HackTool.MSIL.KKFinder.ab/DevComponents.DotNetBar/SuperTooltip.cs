using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[Designer(typeof(SuperTooltipDesigner))]
[ProvideProperty("SuperTooltip", typeof(IComponent))]
[ToolboxItem(true)]
[ToolboxBitmap(typeof(SuperTooltip), "Ribbon.SuperTooltip.ico")]
[ComVisible(false)]
public class SuperTooltip : Component, IExtenderProvider
{
	private const string string_0 = "DevComponents.Tree.Node";

	private const string string_1 = "DevComponents.AdvTree.Node";

	private SuperTooltipEventHandler superTooltipEventHandler_0;

	private EventHandler eventHandler_0;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private bool bool_0 = true;

	private Hashtable hashtable_0 = new Hashtable();

	private SuperTooltipControl superTooltipControl_0;

	private Timer timer_0;

	private Timer timer_1;

	private bool bool_1 = true;

	private IntPtr intptr_0 = IntPtr.Zero;

	private int int_0 = 20;

	private long long_0;

	private SuperTooltipInfo superTooltipInfo_0 = new SuperTooltipInfo();

	private static SuperTooltipInfo superTooltipInfo_1;

	private Font font_0;

	private int int_1;

	private int int_2 = 2;

	private Size size_0 = new Size(150, 24);

	private bool bool_2 = true;

	private bool bool_3 = true;

	private int int_3;

	private bool bool_4;

	private bool bool_5;

	private int int_4;

	private bool bool_6 = true;

	private bool bool_7 = true;

	private bool bool_8 = true;

	private bool bool_9;

	private bool bool_10;

	[Description("Indicates maximum width of the super tooltip.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(0)]
	public int MaximumWidth
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

	[Category("Behavior")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether form active state is ignored when control is deciding whether to show tooltip.")]
	public bool IgnoreFormActiveState
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	[Browsable(true)]
	public bool AntiAlias
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

	[Description("Indicates whether SuperTooltip will be shown for the controls assigned to it.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(true)]
	public bool Enabled
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

	[Browsable(true)]
	[Description("Indicates whether tooltip is shown immediately after the mouse enters the control.")]
	[DefaultValue(false)]
	[Category("Behavior")]
	public bool ShowTooltipImmediately
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
		}
	}

	[Category("Appearance")]
	[Description("Indicates minimum tooltip size.")]
	[Browsable(true)]
	public Size MinimumTooltipSize
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
		}
	}

	[DefaultValue(20)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Indicates duration in seconds that tooltip is kept on screen after it is displayed.")]
	public int TooltipDuration
	{
		get
		{
			return int_0;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			int_0 = value;
		}
	}

	[DefaultValue(0)]
	[Description("Indicates delay time for hiding the tooltip in milliseconds after mouse has left the control.")]
	[Browsable(true)]
	[Category("Behavior")]
	public int DelayTooltipHideDuration
	{
		get
		{
			return int_3;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			int_3 = value;
		}
	}

	[Description("Indicates whether tooltip position is checked before tooltip is displayed and adjusted to tooltip always falls into screen bounds.")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Behavior")]
	public bool CheckOnScreenPosition
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

	[Category("Behavior")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether tooltip position is checked before tooltip is displayed and adjusted so tooltip does not overlap control its displayed for")]
	public bool CheckTooltipPosition
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

	[Category("Behavior")]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("")]
	public bool PositionBelowControl
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

	[Localizable(true)]
	[Editor(typeof(SuperTooltipInfoEditor), typeof(UITypeEditor))]
	[DefaultValue(null)]
	[Description("Indicates default setting for new Tooltips you create in design time.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public SuperTooltipInfo DefaultTooltipSettings
	{
		get
		{
			return superTooltipInfo_0;
		}
		set
		{
			superTooltipInfo_0 = value;
			superTooltipInfo_1 = value;
		}
	}

	[Browsable(false)]
	public static SuperTooltipInfo DefaultSuperTooltipInfo => superTooltipInfo_1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Hashtable SuperTooltipInfoTable => hashtable_0;

	private bool IsMouseOverSuperTooltip
	{
		get
		{
			if (bool_9)
			{
				return true;
			}
			if (superTooltipControl_0 != null && ((Control)superTooltipControl_0).get_Visible() && ((Control)superTooltipControl_0).get_Bounds().Contains(Control.get_MousePosition()))
			{
				return true;
			}
			return false;
		}
	}

	[Browsable(false)]
	public bool IsTooltipVisible
	{
		get
		{
			if (superTooltipControl_0 != null && ((Control)superTooltipControl_0).get_Visible())
			{
				return true;
			}
			return false;
		}
	}

	[Browsable(false)]
	public SuperTooltipControl SuperTooltipControl => superTooltipControl_0;

	[Category("Appearance")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Description("Indicates default tooltip font.")]
	public Font DefaultFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether complete tooltip is shown including header, body and footer. When set to false only tooltip header is shown.")]
	[Category("Behavior")]
	public bool ShowTooltipDescription
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

	[Description("Indicates whether tooltip is shown when control that tooltip is assigned to is focused.")]
	[Category("Behavior")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool ShowTooltipForFocusedControl
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

	public event SuperTooltipEventHandler BeforeTooltipDisplay
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			superTooltipEventHandler_0 = (SuperTooltipEventHandler)Delegate.Combine(superTooltipEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			superTooltipEventHandler_0 = (SuperTooltipEventHandler)Delegate.Remove(superTooltipEventHandler_0, value);
		}
	}

	public event EventHandler TooltipClosed
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

	public event MarkupLinkClickEventHandler MarkupLinkClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Combine(markupLinkClickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Remove(markupLinkClickEventHandler_0, value);
		}
	}

	protected override void Dispose(bool disposing)
	{
		HideTooltip();
		DestroyActiveWindowTimer();
		DisposeHideDelayedTimer();
		base.Dispose(disposing);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMinimumTooltipSize()
	{
		if (size_0.Width == 150)
		{
			return size_0.Height != 24;
		}
		return true;
	}

	[Localizable(true)]
	[DefaultValue(null)]
	[Editor(typeof(SuperTooltipInfoEditor), typeof(UITypeEditor))]
	public SuperTooltipInfo GetSuperTooltip(IComponent c)
	{
		if (hashtable_0.Contains(c) && hashtable_0[c] is SuperTooltipInfo result)
		{
			return result;
		}
		return null;
	}

	public void SetSuperTooltip(IComponent c, SuperTooltipInfo info)
	{
		if (info != null)
		{
			if (info.BodyText == null)
			{
				info.BodyText = "";
			}
			if (info.FooterText == null)
			{
				info.FooterText = "";
			}
		}
		if (hashtable_0.Contains(c))
		{
			if (info == null)
			{
				RemoveSuperTooltipInfo(c);
			}
			else
			{
				hashtable_0[c] = info;
			}
		}
		else if (info != null)
		{
			AddSuperTooltipInfo(c, info);
		}
	}

	private void RemoveSuperTooltipInfo(IComponent c)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		hashtable_0.Remove(c);
		if (base.DesignMode)
		{
			return;
		}
		if (c is ComboBoxItem)
		{
			ComboBoxItem comboBoxItem = c as ComboBoxItem;
			comboBoxItem.MouseHover -= ComponentMouseHover;
			comboBoxItem.MouseLeave -= ComponentMouseLeave;
			comboBoxItem.MouseEnter -= ComponentMouseEnter;
			comboBoxItem.MouseDown -= new MouseEventHandler(ComponentMouseDown);
			((Control)comboBoxItem.ComboBoxEx).remove_MouseHover((EventHandler)ComponentMouseHover);
			((Control)comboBoxItem.ComboBoxEx).remove_MouseLeave((EventHandler)ComponentMouseLeave);
			((Control)comboBoxItem.ComboBoxEx).remove_MouseEnter((EventHandler)ComponentMouseEnter);
			((Control)comboBoxItem.ComboBoxEx).remove_MouseDown(new MouseEventHandler(ComponentMouseDown));
			return;
		}
		if (c is TextBoxItem)
		{
			TextBoxItem textBoxItem = c as TextBoxItem;
			textBoxItem.MouseHover -= ComponentMouseHover;
			textBoxItem.MouseLeave -= ComponentMouseLeave;
			textBoxItem.MouseEnter -= ComponentMouseEnter;
			textBoxItem.MouseDown -= new MouseEventHandler(ComponentMouseDown);
			((Control)textBoxItem.TextBox).remove_MouseHover((EventHandler)ComponentMouseHover);
			((Control)textBoxItem.TextBox).remove_MouseLeave((EventHandler)ComponentMouseLeave);
			((Control)textBoxItem.TextBox).remove_MouseEnter((EventHandler)ComponentMouseEnter);
			((Control)textBoxItem.TextBox).remove_MouseDown(new MouseEventHandler(ComponentMouseDown));
			return;
		}
		if (c is BaseItem)
		{
			BaseItem baseItem = c as BaseItem;
			baseItem.MouseHover -= ComponentMouseHover;
			baseItem.MouseLeave -= ComponentMouseLeave;
			baseItem.MouseEnter -= ComponentMouseEnter;
			baseItem.MouseDown -= new MouseEventHandler(ComponentMouseDown);
			return;
		}
		if (c is RibbonBar)
		{
			RibbonBar ribbonBar = c as RibbonBar;
			ribbonBar.DialogLauncherMouseHover -= ComponentMouseHover;
			ribbonBar.DialogLauncherMouseLeave -= ComponentMouseLeave;
			ribbonBar.DialogLauncherMouseDown -= new MouseEventHandler(ComponentMouseDown);
			ribbonBar.DialogLauncherMouseEnter -= ComponentMouseEnter;
			return;
		}
		if (c is Control)
		{
			Control val = (Control)((c is Control) ? c : null);
			val.remove_MouseHover((EventHandler)ComponentMouseHover);
			val.remove_MouseLeave((EventHandler)ComponentMouseLeave);
			val.remove_MouseDown(new MouseEventHandler(ComponentMouseDown));
			val.remove_MouseEnter((EventHandler)ComponentMouseEnter);
			return;
		}
		if (c is ISuperTooltipInfoProvider)
		{
			ISuperTooltipInfoProvider superTooltipInfoProvider = c as ISuperTooltipInfoProvider;
			superTooltipInfoProvider.DisplayTooltip -= ComponentMouseHover;
			superTooltipInfoProvider.HideTooltip -= ComponentHideTooltip;
			return;
		}
		if (c is ToolStripButton)
		{
			ToolStripButton val2 = (ToolStripButton)((c is ToolStripButton) ? c : null);
			((ToolStripItem)val2).remove_MouseHover((EventHandler)ComponentMouseHover);
			((ToolStripItem)val2).remove_MouseLeave((EventHandler)ComponentMouseLeave);
			((ToolStripItem)val2).remove_MouseEnter((EventHandler)ComponentMouseEnter);
			((ToolStripItem)val2).remove_MouseDown(new MouseEventHandler(ComponentMouseDown));
			return;
		}
		if (!(c.GetType().FullName == "DevComponents.Tree.Node") && !(c.GetType().FullName == "DevComponents.AdvTree.Node"))
		{
			if (c is TabItem)
			{
				TabItem tabItem = c as TabItem;
				tabItem.MouseHover -= ComponentMouseHover;
				tabItem.MouseLeave -= ComponentMouseLeave;
				tabItem.MouseEnter -= ComponentMouseEnter;
				tabItem.MouseDown -= new MouseEventHandler(ComponentMouseDown);
			}
			return;
		}
		Type type = c.GetType();
		EventInfo @event = type.GetEvent("NodeMouseHover");
		if ((object)@event != null)
		{
			Delegate handler = Delegate.CreateDelegate(typeof(EventHandler), this, "ComponentMouseHover");
			@event.RemoveEventHandler(c, handler);
		}
		@event = type.GetEvent("NodeMouseLeave");
		if ((object)@event != null)
		{
			Delegate handler2 = Delegate.CreateDelegate(typeof(EventHandler), this, "ComponentMouseLeave");
			@event.RemoveEventHandler(c, handler2);
		}
		@event = type.GetEvent("NodeMouseEnter");
		if ((object)@event != null)
		{
			Delegate handler3 = Delegate.CreateDelegate(typeof(EventHandler), this, "ComponentMouseEnter");
			@event.RemoveEventHandler(c, handler3);
		}
		@event = type.GetEvent("NodeMouseDown");
		if ((object)@event != null)
		{
			Delegate handler4 = Delegate.CreateDelegate(typeof(MouseEventHandler), this, "ComponentMouseDown");
			@event.RemoveEventHandler(c, handler4);
		}
	}

	private void AddSuperTooltipInfo(IComponent c, SuperTooltipInfo info)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		hashtable_0[c] = info;
		if (c is ISuperTooltipInfoProvider)
		{
			ISuperTooltipInfoProvider superTooltipInfoProvider = c as ISuperTooltipInfoProvider;
			superTooltipInfoProvider.DisplayTooltip += ComponentMouseHover;
			superTooltipInfoProvider.HideTooltip += ComponentHideTooltip;
			return;
		}
		if (c is ComboBoxItem)
		{
			ComboBoxItem comboBoxItem = c as ComboBoxItem;
			comboBoxItem.MouseHover += ComponentMouseHover;
			comboBoxItem.MouseLeave += ComponentMouseLeave;
			comboBoxItem.MouseEnter += ComponentMouseEnter;
			comboBoxItem.MouseDown += new MouseEventHandler(ComponentMouseDown);
			((Control)comboBoxItem.ComboBoxEx).add_MouseHover((EventHandler)ComponentMouseHover);
			((Control)comboBoxItem.ComboBoxEx).add_MouseLeave((EventHandler)ComponentMouseLeave);
			((Control)comboBoxItem.ComboBoxEx).add_MouseEnter((EventHandler)ComponentMouseEnter);
			((Control)comboBoxItem.ComboBoxEx).add_MouseDown(new MouseEventHandler(ComponentMouseDown));
			return;
		}
		if (c is TextBoxItem)
		{
			TextBoxItem textBoxItem = c as TextBoxItem;
			textBoxItem.MouseHover += ComponentMouseHover;
			textBoxItem.MouseLeave += ComponentMouseLeave;
			textBoxItem.MouseEnter += ComponentMouseEnter;
			textBoxItem.MouseDown += new MouseEventHandler(ComponentMouseDown);
			((Control)textBoxItem.TextBox).add_MouseHover((EventHandler)ComponentMouseHover);
			((Control)textBoxItem.TextBox).add_MouseLeave((EventHandler)ComponentMouseLeave);
			((Control)textBoxItem.TextBox).add_MouseEnter((EventHandler)ComponentMouseEnter);
			((Control)textBoxItem.TextBox).add_MouseDown(new MouseEventHandler(ComponentMouseDown));
			return;
		}
		if (c is BaseItem)
		{
			BaseItem baseItem = c as BaseItem;
			baseItem.MouseHover += ComponentMouseHover;
			baseItem.MouseLeave += ComponentMouseLeave;
			baseItem.MouseEnter += ComponentMouseEnter;
			baseItem.MouseDown += new MouseEventHandler(ComponentMouseDown);
			return;
		}
		if (c is RibbonBar)
		{
			RibbonBar ribbonBar = c as RibbonBar;
			ribbonBar.DialogLauncherMouseHover += ComponentMouseHover;
			ribbonBar.DialogLauncherMouseEnter += ComponentMouseEnter;
			ribbonBar.DialogLauncherMouseLeave += ComponentMouseLeave;
			ribbonBar.DialogLauncherMouseDown += new MouseEventHandler(ComponentMouseDown);
			return;
		}
		if (c is Control)
		{
			Control val = (Control)((c is Control) ? c : null);
			val.add_MouseHover((EventHandler)ComponentMouseHover);
			val.add_MouseLeave((EventHandler)ComponentMouseLeave);
			val.add_MouseDown(new MouseEventHandler(ComponentMouseDown));
			val.add_MouseEnter((EventHandler)ComponentMouseEnter);
			return;
		}
		if (c is ToolStripButton)
		{
			ToolStripButton val2 = (ToolStripButton)((c is ToolStripButton) ? c : null);
			((ToolStripItem)val2).add_MouseHover((EventHandler)ComponentMouseHover);
			((ToolStripItem)val2).add_MouseLeave((EventHandler)ComponentMouseLeave);
			((ToolStripItem)val2).add_MouseEnter((EventHandler)ComponentMouseEnter);
			((ToolStripItem)val2).add_MouseDown(new MouseEventHandler(ComponentMouseDown));
			val2.set_AutoToolTip(false);
			((ToolStripItem)val2).set_ToolTipText("");
			return;
		}
		if (!(c.GetType().FullName == "DevComponents.Tree.Node") && !(c.GetType().FullName == "DevComponents.AdvTree.Node"))
		{
			if (c is TabItem)
			{
				TabItem tabItem = c as TabItem;
				tabItem.MouseHover += ComponentMouseHover;
				tabItem.MouseLeave += ComponentMouseLeave;
				tabItem.MouseEnter += ComponentMouseEnter;
				tabItem.MouseDown += new MouseEventHandler(ComponentMouseDown);
			}
			return;
		}
		Type type = c.GetType();
		EventInfo @event = type.GetEvent("NodeMouseHover");
		if ((object)@event != null)
		{
			Delegate handler = Delegate.CreateDelegate(typeof(EventHandler), this, "ComponentMouseHover");
			@event.AddEventHandler(c, handler);
		}
		@event = type.GetEvent("NodeMouseLeave");
		if ((object)@event != null)
		{
			Delegate handler2 = Delegate.CreateDelegate(typeof(EventHandler), this, "ComponentMouseLeave");
			@event.AddEventHandler(c, handler2);
		}
		@event = type.GetEvent("NodeMouseEnter");
		if ((object)@event != null)
		{
			Delegate handler3 = Delegate.CreateDelegate(typeof(EventHandler), this, "ComponentMouseEnter");
			@event.AddEventHandler(c, handler3);
		}
		@event = type.GetEvent("NodeMouseDown");
		if ((object)@event != null)
		{
			Delegate handler4 = Delegate.CreateDelegate(typeof(MouseEventHandler), this, "ComponentMouseDown");
			@event.AddEventHandler(c, handler4);
		}
	}

	private void ComponentHideTooltip(object sender, EventArgs e)
	{
		HideTooltip();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ComponentMouseDown(object sender, MouseEventArgs e)
	{
		HideTooltip();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ComponentMouseEnter(object sender, EventArgs e)
	{
		if (sender is Control)
		{
			ResetHover((Control)((sender is Control) ? sender : null));
		}
		if (bool_4 && bool_2)
		{
			ShowTooltip(sender);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ComponentMouseLeave(object sender, EventArgs e)
	{
		if (!IsMouseOverSuperTooltip)
		{
			HideDelayed();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ComponentMouseHover(object sender, EventArgs e)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (!bool_4)
		{
			int_1++;
			if (sender is Control && int_1 < int_2)
			{
				ResetHover((Control)((sender is Control) ? sender : null));
			}
			else if (sender is BaseItem && int_1 < int_2)
			{
				ResetHover((Control)((BaseItem)sender).ContainerControl);
			}
			else if (sender is TabItem && int_1 < int_2)
			{
				ResetHover((Control)(object)((TabItem)sender).Parent);
			}
			else if (bool_2)
			{
				ShowTooltip(sender);
			}
		}
	}

	private ComboBoxItem GetComboBoxItemFromComboBoxEx(ComboBoxEx c)
	{
		foreach (object key in hashtable_0.Keys)
		{
			if (key is ComboBoxItem && ((ComboBoxItem)key).ComboBoxEx == c)
			{
				return key as ComboBoxItem;
			}
		}
		return null;
	}

	protected virtual void OnMarkupLinkClick(MarkupLinkClickEventArgs e)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(this, e);
		}
	}

	public void ShowTooltip(object sender, Point screenPosition)
	{
		ShowTooltip(sender, screenPosition, useScreenPosition: true);
	}

	public void ShowTooltip(object sender)
	{
		ShowTooltip(sender, Point.Empty, useScreenPosition: false);
	}

	private void ShowTooltip(object sender, Point screenPosition, bool useScreenPosition)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Invalid comparison between Unknown and I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Invalid comparison between Unknown and I4
		if (sender is Control && ((Control)sender).get_Focused() && !bool_8)
		{
			return;
		}
		Rectangle rectangle = Rectangle.Empty;
		Rectangle rect = Rectangle.Empty;
		bool flag = false;
		if (!IsFormActive(sender))
		{
			return;
		}
		if (sender is ComboBoxEx)
		{
			BaseItem comboBoxItemFromComboBoxEx = GetComboBoxItemFromComboBoxEx(sender as ComboBoxEx);
			if (comboBoxItemFromComboBoxEx != null)
			{
				sender = comboBoxItemFromComboBoxEx;
			}
		}
		if (sender is BaseItem)
		{
			BaseItem baseItem = sender as BaseItem;
			if (baseItem is PopupItem && ((PopupItem)baseItem).Expanded && (baseItem.ContainerControl is RibbonBar || baseItem.ContainerControl is RibbonStrip))
			{
				return;
			}
			object containerControl = baseItem.ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				rectangle = ((!bool_0 || (val is RibbonStrip && ((RibbonStrip)(object)val).QuickToolbarItems.Contains(baseItem))) ? new Rectangle(val.PointToScreen(baseItem.DisplayRectangle.Location), baseItem.DisplayRectangle.Size) : new Rectangle(val.PointToScreen(Point.Empty), val.get_Size()));
				rect = new Rectangle(val.PointToScreen(baseItem.DisplayRectangle.Location), baseItem.DisplayRectangle.Size);
				flag = (int)((Control)baseItem.ContainerControl).get_RightToLeft() == 1;
			}
		}
		else if (sender is Control)
		{
			Control val2 = (Control)((sender is Control) ? sender : null);
			rectangle = new Rectangle(val2.PointToScreen(Point.Empty), val2.get_Size());
			rect = rectangle;
			flag = (int)val2.get_RightToLeft() == 1;
		}
		else if (sender is TabItem)
		{
			TabItem tabItem = sender as TabItem;
			TabStrip parent = tabItem.Parent;
			rectangle = new Rectangle(((Control)parent).PointToScreen(Point.Empty), ((Control)parent).get_Size());
			rect = rectangle;
			flag = (int)((Control)parent).get_RightToLeft() == 1;
		}
		else if (sender is ISuperTooltipInfoProvider)
		{
			ISuperTooltipInfoProvider superTooltipInfoProvider = sender as ISuperTooltipInfoProvider;
			rectangle = superTooltipInfoProvider.ComponentRectangle;
			rect = rectangle;
		}
		else if (!(sender.GetType().FullName == "DevComponents.Tree.Node") && !(sender.GetType().FullName == "DevComponents.AdvTree.Node"))
		{
			if (sender is ToolStripButton)
			{
				ToolStripButton val3 = (ToolStripButton)((sender is ToolStripButton) ? sender : null);
				rectangle = ((ToolStripItem)val3).get_Bounds();
				rect = ((ToolStripItem)val3).get_Bounds();
			}
		}
		else
		{
			rectangle = (Rectangle)TypeDescriptor.GetProperties(sender)["CellsBounds"]!.GetValue(sender);
			object? value = TypeDescriptor.GetProperties(sender)["TreeControl"]!.GetValue(sender);
			Control val4 = (Control)((value is Control) ? value : null);
			if (val4 != null)
			{
				rectangle = ((!bool_0) ? new Rectangle(val4.PointToScreen(rectangle.Location), rectangle.Size) : new Rectangle(val4.PointToScreen(Point.Empty), val4.get_Size()));
				flag = (int)val4.get_RightToLeft() == 1;
			}
			rect = rectangle;
		}
		if (rectangle.IsEmpty)
		{
			return;
		}
		SuperTooltipInfo superTooltipInfo = GetSuperTooltipInfo(sender);
		if (superTooltipInfo == null && sender is BaseItem)
		{
			foreach (object key in hashtable_0.Keys)
			{
				if (key is BaseItem && ((BaseItem)key).Name == ((BaseItem)sender).Name)
				{
					superTooltipInfo = hashtable_0[key] as SuperTooltipInfo;
					break;
				}
			}
		}
		if (superTooltipInfo == null)
		{
			return;
		}
		HideTooltip();
		Point point = new Point(Control.get_MousePosition().X, Control.get_MousePosition().Y + (int)((float)SystemInformation.get_CursorSize().Height * 0.6f));
		if (bool_0)
		{
			point.Y = Math.Max(rectangle.Bottom + 1, point.Y);
		}
		if (useScreenPosition)
		{
			point = screenPosition;
		}
		superTooltipControl_0 = new SuperTooltipControl();
		superTooltipControl_0.ShowTooltipDescription = bool_7;
		superTooltipControl_0.MaximumWidth = int_4;
		superTooltipControl_0.MouseActivateEnabled = false;
		((Control)superTooltipControl_0).add_MouseEnter((EventHandler)SuperTooltip_MouseEnter);
		((Control)superTooltipControl_0).add_MouseLeave((EventHandler)SuperTooltip_MouseLeave);
		superTooltipControl_0.MarkupLinkClick += Tooltip_MarkupLinkClick;
		if (font_0 != null)
		{
			((Control)superTooltipControl_0).set_Font(font_0);
		}
		if (flag)
		{
			((Control)superTooltipControl_0).set_RightToLeft((RightToLeft)1);
		}
		superTooltipControl_0.MinimumTooltipSize = size_0;
		superTooltipControl_0.AntiAlias = bool_3;
		Size size = Size.Empty;
		if (bool_6 || bool_1)
		{
			if (!superTooltipInfo.CustomSize.IsEmpty && superTooltipInfo.CustomSize.Width > 0 && superTooltipInfo.CustomSize.Height > 0)
			{
				size = superTooltipInfo.CustomSize;
			}
			else
			{
				superTooltipControl_0.UpdateWithSuperTooltipInfo(superTooltipInfo);
				superTooltipControl_0.method_11(superTooltipInfo);
				size = ((Control)superTooltipControl_0).get_Size();
			}
		}
		if (bool_1)
		{
			Class273 @class = Class109.smethod_52(point);
			if (@class != null)
			{
				Rectangle rectangle2 = new Rectangle(point, size);
				_ = @class.rectangle_1.Size;
				if (rectangle2.Right > @class.rectangle_1.Right)
				{
					rectangle2.X -= rectangle2.Right - @class.rectangle_1.Right;
				}
				if (rectangle2.Bottom > @class.rectangle_0.Bottom)
				{
					rectangle2.Y = @class.rectangle_0.Bottom - rectangle2.Height;
				}
				point = rectangle2.Location;
			}
		}
		if (bool_6 && !rect.IsEmpty)
		{
			Rectangle rectangle3 = new Rectangle(point, size);
			if (rectangle3.IntersectsWith(rect))
			{
				if (rect.Y - rectangle3.Height >= 0)
				{
					rectangle3.Y = rect.Y - rectangle3.Height;
				}
				else if (rect.X - rectangle3.Width >= 0)
				{
					rectangle3.Width = rect.X - rectangle3.Width;
				}
				point = rectangle3.Location;
			}
		}
		if (superTooltipEventHandler_0 != null)
		{
			SuperTooltipEventArgs superTooltipEventArgs = new SuperTooltipEventArgs(sender, superTooltipInfo, point);
			superTooltipEventHandler_0(this, superTooltipEventArgs);
			if (superTooltipEventArgs.Cancel)
			{
				((Component)(object)superTooltipControl_0).Dispose();
				superTooltipControl_0 = null;
				return;
			}
			point = superTooltipEventArgs.Location;
		}
		superTooltipControl_0.ShowTooltip(superTooltipInfo, point.X, point.Y, enforceScreenPosition: false);
		long_0 = 0L;
		CreateActiveWindowTimer();
	}

	protected virtual void OnTooltipClosed(EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	private SuperTooltipInfo GetSuperTooltipInfo(object sender)
	{
		if (sender is TextBoxX && !hashtable_0.Contains(sender))
		{
			foreach (object key in hashtable_0.Keys)
			{
				if (key is TextBoxItem && ((TextBoxItem)key).TextBox == sender)
				{
					return hashtable_0[key] as SuperTooltipInfo;
				}
			}
		}
		else if (sender is ComboBoxEx && !hashtable_0.Contains(sender))
		{
			foreach (object key2 in hashtable_0.Keys)
			{
				if (key2 is ComboBoxItem && ((ComboBoxItem)key2).ComboBoxEx == sender)
				{
					return hashtable_0[key2] as SuperTooltipInfo;
				}
			}
		}
		return hashtable_0[sender] as SuperTooltipInfo;
	}

	private bool IsFormActive(object sender)
	{
		if (bool_5)
		{
			return true;
		}
		Control val = null;
		if (sender is Control)
		{
			val = (Control)((sender is Control) ? sender : null);
		}
		else if (sender is BaseItem)
		{
			object containerControl = ((BaseItem)sender).ContainerControl;
			val = (Control)((containerControl is Control) ? containerControl : null);
		}
		if (val != null)
		{
			Form val2 = val.FindForm();
			if (val2 != null && val2.get_IsMdiChild() && val2.get_MdiParent().get_ActiveMdiChild() == val2)
			{
				return true;
			}
			if (val2 != null && Form.get_ActiveForm() != val2)
			{
				return false;
			}
		}
		return true;
	}

	private void Tooltip_MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
	{
		OnMarkupLinkClick(e);
	}

	private void SuperTooltip_MouseLeave(object sender, EventArgs e)
	{
		bool_9 = false;
		HideTooltip();
	}

	private void SuperTooltip_MouseEnter(object sender, EventArgs e)
	{
		bool_9 = true;
	}

	public void HideTooltip()
	{
		int_1 = 0;
		DestroyActiveWindowTimer();
		DisposeHideDelayedTimer();
		if (superTooltipControl_0 != null)
		{
			((Control)superTooltipControl_0).Hide();
			((Component)(object)superTooltipControl_0).Dispose();
			superTooltipControl_0 = null;
			OnTooltipClosed(new EventArgs());
		}
		bool_9 = false;
	}

	private void HideDelayed()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (int_3 <= 100)
		{
			HideTooltip();
		}
		else if (timer_1 == null)
		{
			timer_1 = new Timer();
			timer_1.add_Tick((EventHandler)HideDelayedTimer_Tick);
			timer_1.set_Interval(int_3);
			timer_1.set_Enabled(true);
		}
	}

	private void HideDelayedTimer_Tick(object sender, EventArgs e)
	{
		if (!IsMouseOverSuperTooltip)
		{
			HideTooltip();
		}
	}

	private void DisposeHideDelayedTimer()
	{
		if (timer_1 != null)
		{
			timer_1.Stop();
			timer_1.set_Enabled(false);
			((Component)(object)timer_1).Dispose();
			timer_1 = null;
		}
	}

	private void CreateActiveWindowTimer()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		if (timer_0 == null && !bool_10)
		{
			bool_10 = true;
			try
			{
				intptr_0 = Class92.GetActiveWindow();
				timer_0 = new Timer();
				timer_0.set_Interval(300);
				timer_0.add_Tick((EventHandler)ActiveWindowTimerTick);
				timer_0.Start();
			}
			finally
			{
				bool_10 = false;
			}
		}
	}

	private void ActiveWindowTimerTick(object sender, EventArgs e)
	{
		long_0 += timer_0.get_Interval();
		if (intptr_0 != IntPtr.Zero)
		{
			IntPtr activeWindow = Class92.GetActiveWindow();
			if (activeWindow != intptr_0)
			{
				timer_0.Stop();
				HideTooltip();
				return;
			}
		}
		if (int_0 > 0 && long_0 > int_0 * 1000 && !bool_9)
		{
			timer_0.Stop();
			HideTooltip();
		}
	}

	private void DestroyActiveWindowTimer()
	{
		if (bool_10)
		{
			return;
		}
		bool_10 = true;
		try
		{
			if (timer_0 != null)
			{
				timer_0.set_Enabled(false);
				timer_0.Stop();
				timer_0.remove_Tick((EventHandler)ActiveWindowTimerTick);
				((Component)(object)timer_0).Dispose();
				timer_0 = null;
			}
		}
		finally
		{
			bool_10 = false;
		}
	}

	private void ResetHover(Control c)
	{
		if (c != null && Class109.smethod_11(c))
		{
			Class92.TRACKMOUSEEVENT tme = default(Class92.TRACKMOUSEEVENT);
			tme.dwFlags = 1073741824u;
			tme.hwndTrack = c.get_Handle();
			tme.cbSize = Marshal.SizeOf((object)tme);
			Class92.TrackMouseEvent(ref tme);
			tme.dwFlags |= 1u;
			Class92.TrackMouseEvent(ref tme);
		}
	}

	public bool CanExtend(object extendee)
	{
		if (!(extendee is Control) && !(extendee is BaseItem) && !(extendee is ISuperTooltipInfoProvider) && !(extendee.GetType().FullName == "DevComponents.Tree.Node") && !(extendee is TabItem))
		{
			if (extendee is ToolStripButton)
			{
				return true;
			}
			if (extendee is Node)
			{
				return true;
			}
			return false;
		}
		return true;
	}
}

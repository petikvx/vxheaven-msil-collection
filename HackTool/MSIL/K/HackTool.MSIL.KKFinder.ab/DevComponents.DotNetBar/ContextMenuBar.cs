using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[Designer(typeof(ContextMenuBarDesigner))]
[ProvideProperty("ContextMenuEx", typeof(Control))]
[ComVisible(false)]
[DefaultEvent("ItemClick")]
public class ContextMenuBar : Bar, IExtenderProvider
{
	private class EventArgs2 : EventArgs
	{
		private readonly int int_0;

		private readonly int int_1;

		private readonly MouseButtons mouseButtons_0;

		private readonly IntPtr intptr_0;

		private readonly bool bool_0;

		public bool bool_1;

		public int Int32_0 => int_0;

		public int Int32_1 => int_1;

		public MouseButtons MouseButtons_0 => mouseButtons_0;

		public IntPtr IntPtr_0 => intptr_0;

		public bool Boolean_0 => bool_0;

		public EventArgs2(IntPtr phwnd, int ix, int iy, MouseButtons eButton, bool WmContextMessage)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			int_0 = ix;
			int_1 = iy;
			mouseButtons_0 = eButton;
			intptr_0 = phwnd;
			bool_0 = WmContextMessage;
		}
	}

	private delegate void Delegate5(object sender, EventArgs2 e);

	private class Class187 : NativeWindow
	{
		private const int int_0 = 123;

		private const int int_1 = 517;

		private const int int_2 = 165;

		private const int int_3 = 516;

		private Delegate5 delegate5_0;

		public Control control_0;

		public event Delegate5 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				delegate5_0 = (Delegate5)Delegate.Combine(delegate5_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				delegate5_0 = (Delegate5)Delegate.Remove(delegate5_0, value);
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (((Message)(ref m)).get_Msg() == 123 && delegate5_0 != null)
			{
				int num = ((Message)(ref m)).get_LParam().ToInt32();
				int num2 = num >> 16;
				int num3 = num & 0xFFFF;
				IntPtr intPtr = ((Message)(ref m)).get_WParam();
				if (intPtr == IntPtr.Zero)
				{
					intPtr = ((Message)(ref m)).get_HWnd();
				}
				bool wmContextMessage = true;
				if (((Message)(ref m)).get_HWnd() != ((Message)(ref m)).get_WParam())
				{
					wmContextMessage = false;
				}
				EventArgs2 eventArgs = new EventArgs2(intPtr, num3, num2, (MouseButtons)((num3 != 65535 || num2 != -1) ? 2097152 : 0), wmContextMessage);
				delegate5_0(this, eventArgs);
				if (eventArgs.bool_1)
				{
					return;
				}
			}
			((NativeWindow)this).WndProc(ref m);
		}
	}

	private Hashtable hashtable_2 = new Hashtable();

	private Hashtable hashtable_3 = new Hashtable();

	private bool bool_67 = true;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	public new bool Visible
	{
		get
		{
			return base.Visible;
		}
		set
		{
			base.Visible = value;
		}
	}

	public ContextMenuBar()
	{
		Visible = false;
		base.WrapItemsDock = true;
		base.WrapItemsFloat = true;
	}

	protected override bool IsContextPopup(BaseItem popup)
	{
		if (base.Items.Contains(popup))
		{
			return true;
		}
		return base.IsContextPopup(popup);
	}

	bool IExtenderProvider.CanExtend(object extendee)
	{
		if (extendee is Control)
		{
			return true;
		}
		return false;
	}

	[DefaultValue(null)]
	[Editor(typeof(ContextExMenuTypeEditor), typeof(UITypeEditor))]
	public BaseItem GetContextMenuEx(Control control)
	{
		return (BaseItem)hashtable_2[control];
	}

	public void SetContextMenuEx(Control control, BaseItem value)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		if (value == null)
		{
			if (hashtable_2.Contains(control))
			{
				hashtable_2.Remove(control);
				control.remove_MouseUp(new MouseEventHandler(method_149));
				try
				{
					control.remove_HandleDestroyed((EventHandler)method_147);
				}
				catch
				{
				}
				try
				{
					control.remove_HandleCreated((EventHandler)method_148);
					return;
				}
				catch
				{
					return;
				}
			}
			return;
		}
		if (hashtable_2.Contains(control))
		{
			hashtable_2[control] = value;
			return;
		}
		hashtable_2[control] = value;
		if (!hashtable_3.Contains(control) && !((Component)(object)this).DesignMode)
		{
			if (!(control is TreeView) && !(control is Form) && !(control is Panel) && !(control is DataGridView) && bool_67)
			{
				if (control.get_IsHandleCreated())
				{
					Class187 @class = new Class187();
					@class.Event_0 += method_152;
					@class.control_0 = control;
					((NativeWindow)@class).AssignHandle(control.get_Handle());
					hashtable_3[control] = @class;
				}
				control.add_HandleDestroyed((EventHandler)method_147);
				control.add_HandleCreated((EventHandler)method_148);
			}
			if (control is ComboBox)
			{
				ComboBox val = (ComboBox)(object)((control is ComboBox) ? control : null);
				((Control)val).set_ContextMenu(new ContextMenu());
			}
		}
		try
		{
			control.add_MouseUp(new MouseEventHandler(method_149));
		}
		catch
		{
		}
	}

	internal bool method_146(Control control_0)
	{
		return hashtable_2.Contains(control_0);
	}

	private void method_147(object sender, EventArgs e)
	{
		Control val = (Control)((sender is Control) ? sender : null);
		if (val != null)
		{
			if (hashtable_3[val] is Class187 @class)
			{
				((NativeWindow)@class).ReleaseHandle();
				Class187 class2 = null;
			}
			hashtable_3.Remove(val);
		}
	}

	private void method_148(object sender, EventArgs e)
	{
		Control val = (Control)((sender is Control) ? sender : null);
		if (val != null && !hashtable_3.Contains(val))
		{
			Class187 @class = new Class187();
			@class.Event_0 += method_152;
			@class.control_0 = val;
			((NativeWindow)@class).AssignHandle(val.get_Handle());
			hashtable_3[val] = @class;
		}
	}

	private void method_149(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 2097152)
		{
			Control val = (Control)((sender is Control) ? sender : null);
			if (val != null && method_151(val) is PopupItem popupItem && !popupItem.Expanded)
			{
				popupItem.Style = base.Style;
				popupItem.SetSourceControl(val);
				popupItem.Popup(val.PointToScreen(new Point(e.get_X(), e.get_Y())));
			}
		}
	}

	private Control method_150(Control control_0, IntPtr intptr_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)control_0.get_Controls())
		{
			Control val = item;
			if (!(val.get_Handle() == intptr_0))
			{
				if (((ArrangedElementCollection)val.get_Controls()).get_Count() > 0)
				{
					Control val2 = method_150(val, intptr_0);
					if (val2 != null)
					{
						return val2;
					}
				}
				continue;
			}
			return val;
		}
		return control_0;
	}

	private BaseItem method_151(Control control_0)
	{
		return (BaseItem)hashtable_2[control_0];
	}

	private void method_152(object sender, EventArgs2 e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (!(sender is Class187 @class))
		{
			return;
		}
		BaseItem baseItem = method_151(@class.control_0);
		if (baseItem == null)
		{
			return;
		}
		PopupItem popupItem = baseItem as PopupItem;
		popupItem.Style = base.Style;
		if ((int)e.MouseButtons_0 == 0)
		{
			Control val = Control.FromChildHandle(e.IntPtr_0);
			if (val != null && val.get_Handle() != e.IntPtr_0)
			{
				val = method_150(val, e.IntPtr_0);
			}
			popupItem.SetSourceControl(@class.control_0);
			if (val != null)
			{
				popupItem.Popup(val.PointToScreen(Point.Empty));
			}
			else
			{
				popupItem.Popup(Control.get_MousePosition());
			}
			if (base.Boolean_19)
			{
				base.Boolean_19 = false;
				base.Boolean_20 = true;
			}
		}
		else if (!e.Boolean_0)
		{
			popupItem.SetSourceControl(@class.control_0);
			popupItem.Popup(e.Int32_0, e.Int32_1);
		}
		e.bool_1 = true;
	}
}

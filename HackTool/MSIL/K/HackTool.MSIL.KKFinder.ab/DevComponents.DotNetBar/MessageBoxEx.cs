using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class MessageBoxEx
{
	private static MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private static bool bool_0 = false;

	private static bool bool_1 = true;

	public static bool UseSystemLocalizedString
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

	public static bool EnableGlass
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

	public static event MarkupLinkClickEventHandler MarkupLinkClick
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

	internal static void smethod_0(object sender, MarkupLinkClickEventArgs e)
	{
		markupLinkClickEventHandler_0?.Invoke(sender, e);
	}

	public static DialogResult Show(string text)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(null, text, "", (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, bool_2: false);
	}

	public static DialogResult Show(IWin32Window owner, string text)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(null, text, "", (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, smethod_2(owner));
	}

	public static DialogResult Show(string text, string caption)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(null, text, caption, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, bool_2: false);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(owner, text, caption, (MessageBoxButtons)0, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, smethod_2(owner));
	}

	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(null, text, caption, buttons, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, bool_2: false);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(owner, text, caption, buttons, (MessageBoxIcon)0, (MessageBoxDefaultButton)0, smethod_2(owner));
	}

	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(null, text, caption, buttons, icon, (MessageBoxDefaultButton)0, bool_2: false);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(owner, text, caption, buttons, icon, (MessageBoxDefaultButton)0, smethod_2(owner));
	}

	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(null, text, caption, buttons, icon, defaultButton, bool_2: false);
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(owner, text, caption, buttons, icon, defaultButton, smethod_2(owner));
	}

	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, bool topMost)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return smethod_1(owner, text, caption, buttons, icon, defaultButton, topMost);
	}

	private static DialogResult smethod_1(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0, MessageBoxDefaultButton messageBoxDefaultButton_0, bool bool_2)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxDialog messageBoxDialog = new MessageBoxDialog();
		messageBoxDialog.EnableGlass = bool_1;
		((Form)messageBoxDialog).set_StartPosition((FormStartPosition)1);
		DialogResult result = messageBoxDialog.method_29(iwin32Window_0, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0, messageBoxDefaultButton_0, bool_2);
		((Component)(object)messageBoxDialog).Dispose();
		return result;
	}

	private static bool smethod_2(IWin32Window iwin32Window_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (iwin32Window_0 is Form)
		{
			return ((Form)iwin32Window_0).get_TopMost();
		}
		return false;
	}
}

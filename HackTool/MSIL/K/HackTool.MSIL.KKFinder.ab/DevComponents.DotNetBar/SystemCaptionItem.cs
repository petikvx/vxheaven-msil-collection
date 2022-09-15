using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class SystemCaptionItem : MDISystemItem
{
	private bool bool_29 = true;

	private bool bool_30 = true;

	private bool bool_31 = true;

	private bool bool_32;

	private bool bool_33;

	protected override bool ShowToolTips => !bool_33;

	[DefaultValue(true)]
	[Browsable(false)]
	public bool MinimizeVisible
	{
		get
		{
			return bool_29;
		}
		set
		{
			bool_29 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(false)]
	[DefaultValue(true)]
	public bool RestoreMaximizeVisible
	{
		get
		{
			return bool_30;
		}
		set
		{
			bool_30 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(false)]
	[DefaultValue(true)]
	public bool CloseVisible
	{
		get
		{
			return bool_31;
		}
		set
		{
			bool_31 = value;
			OnAppearanceChanged();
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	public bool HelpVisible
	{
		get
		{
			return bool_32;
		}
		set
		{
			bool_32 = value;
			OnAppearanceChanged();
		}
	}

	internal override Size vmethod_1()
	{
		Size result = SystemInformation.get_CaptionButtonSize();
		if (Environment.OSVersion.Version.Major < 6 && ContainerControl is RibbonStrip)
		{
			result = new Size(25, 25);
		}
		if (Environment.OSVersion.Version.Major >= 6 && result.Height == 19 && Parent is Class181)
		{
			result.Height += 3;
		}
		return result;
	}

	public override void Paint(ItemPaintArgs pa)
	{
		if (!SuspendLayout)
		{
			bool_33 = pa.GlassEnabled;
			if (pa.BaseRenderer_0 != null)
			{
				pa.BaseRenderer_0.DrawSystemCaptionItem(new SystemCaptionItemRendererEventArgs(pa.Graphics, this, pa.GlassEnabled));
			}
			else
			{
				base.Paint(pa);
			}
		}
	}

	public override void RecalcSize()
	{
		if (SuspendLayout)
		{
			return;
		}
		if (base.IsSystemIcon)
		{
			base.RecalcSize();
		}
		else
		{
			Size size = vmethod_1();
			int num = 0;
			if (bool_29)
			{
				num++;
			}
			if (bool_30)
			{
				num++;
			}
			if (bool_31)
			{
				num++;
			}
			if (bool_32)
			{
				num++;
			}
			if (Orientation == eOrientation.Horizontal)
			{
				m_Rect.Size = new Size(size.Width * num + num - 1, size.Height);
			}
			else
			{
				m_Rect.Size = new Size(size.Width, size.Height * num + num - 1);
			}
		}
		m_NeedRecalcSize = false;
	}

	internal override Enum13 vmethod_2(int int_5, int int_6)
	{
		Rectangle rectangle = new Rectangle(DisplayRectangle.Location, vmethod_1());
		rectangle.Location = DisplayRectangle.Location;
		if (Orientation == eOrientation.Horizontal)
		{
			rectangle.Offset(0, (DisplayRectangle.Height - rectangle.Height) / 2);
		}
		else
		{
			rectangle.Offset((WidthInternal - rectangle.Width) / 2, 0);
		}
		if (bool_32 && (!IsRightToLeft || (bool_31 && IsRightToLeft)))
		{
			if (rectangle.Contains(int_5, int_6))
			{
				if (IsRightToLeft)
				{
					return Enum13.const_3;
				}
				return Enum13.const_4;
			}
			if (Orientation == eOrientation.Horizontal)
			{
				rectangle.Offset(rectangle.Width + 1, 0);
			}
			else
			{
				rectangle.Offset(0, rectangle.Height + 1);
			}
		}
		if ((bool_29 && bool_32) || (!bool_32 && bool_29 && (!IsRightToLeft || (bool_31 && IsRightToLeft))))
		{
			if (rectangle.Contains(int_5, int_6))
			{
				if (IsRightToLeft)
				{
					return Enum13.const_3;
				}
				return Enum13.const_1;
			}
			if (Orientation == eOrientation.Horizontal)
			{
				rectangle.Offset(rectangle.Width + 1, 0);
			}
			else
			{
				rectangle.Offset(0, rectangle.Height + 1);
			}
		}
		if (bool_30)
		{
			if (rectangle.Contains(int_5, int_6))
			{
				if (base.RestoreEnabled)
				{
					return Enum13.const_2;
				}
				return Enum13.const_5;
			}
			if (Orientation == eOrientation.Horizontal)
			{
				rectangle.Offset(rectangle.Width + 3, 0);
			}
			else
			{
				rectangle.Offset(0, rectangle.Height + 3);
			}
		}
		if (((bool_31 && !IsRightToLeft) || (bool_29 && IsRightToLeft)) && rectangle.Contains(int_5, int_6))
		{
			if (IsRightToLeft)
			{
				return Enum13.const_1;
			}
			return Enum13.const_3;
		}
		return Enum13.const_0;
	}

	public override void Refresh()
	{
		base.Refresh();
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null && BaseItem.IsHandleValid(val))
		{
			Class92.RECT lprcUpdate = new Class92.RECT(0, 0, val.get_Width(), SystemInformation.get_Border3DSize().Height + SystemInformation.get_CaptionHeight());
			Class92.RedrawWindow(val.get_Handle(), ref lprcUpdate, IntPtr.Zero, 1025u);
		}
	}
}

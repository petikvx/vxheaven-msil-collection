using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Controls;

internal class Class191 : HScrollBar, Class192.Interface2
{
	private Class192 class192_0;

	private bool bool_0 = true;

	protected override CreateParams CreateParams
	{
		get
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Invalid comparison between Unknown and I4
			CreateParams createParams = ((HScrollBar)this).get_CreateParams();
			if (bool_0)
			{
				createParams.set_ClassName((string)null);
				createParams.set_Style(33554432);
				createParams.set_Style(createParams.get_Style() | 0x44000000);
				if (((Control)this).get_Visible())
				{
					createParams.set_Style(createParams.get_Style() | 0x10000000);
				}
				if (!((Control)this).get_Enabled())
				{
					createParams.set_Style(createParams.get_Style() | 0x8000000);
				}
				if ((int)((Control)this).get_RightToLeft() == 1)
				{
					createParams.set_ExStyle(createParams.get_ExStyle() | 0x2000);
					createParams.set_ExStyle(createParams.get_ExStyle() | 0x1000);
					createParams.set_ExStyle(createParams.get_ExStyle() | 0x4000);
				}
			}
			return createParams;
		}
	}

	[Category("Appearance")]
	[Description("Indicates whether custom styling (Office 2007 style) is enabled.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				if (((Control)this).get_IsHandleCreated())
				{
					((Control)this).RecreateHandle();
				}
			}
		}
	}

	public bool Boolean_1
	{
		get
		{
			return class192_0.Boolean_1;
		}
		set
		{
			class192_0.Boolean_1 = value;
		}
	}

	public Class191()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		class192_0 = new Class192((ScrollBar)(object)this);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, false);
	}

	protected override void Dispose(bool disposing)
	{
		class192_0.Dispose();
		((Control)this).Dispose(disposing);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		class192_0.method_0();
		((ScrollBar)this).OnHandleCreated(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (bool_0)
		{
			class192_0.method_6(e);
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (bool_0)
		{
			class192_0.method_7(e);
		}
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		if (bool_0)
		{
			class192_0.method_2(e);
		}
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (bool_0)
		{
			class192_0.method_3(e);
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (bool_0)
		{
			class192_0.method_4(e);
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (bool_0)
		{
			class192_0.method_9(e);
		}
		((Control)this).OnPaint(e);
	}

	protected override void NotifyInvalidate(Rectangle invalidatedArea)
	{
		if (bool_0)
		{
			class192_0.method_5(invalidatedArea);
		}
		((Control)this).NotifyInvalidate(invalidatedArea);
	}

	public void method_0()
	{
		class192_0.method_1();
	}

	protected override void OnParentChanged(EventArgs e)
	{
		if (((Control)this).get_Parent() is DataGridView)
		{
			class192_0.ScrollBarCore_0.Boolean_2 = true;
			class192_0.ScrollBarCore_0.Boolean_1 = false;
		}
		else
		{
			class192_0.ScrollBarCore_0.Boolean_2 = false;
			class192_0.ScrollBarCore_0.Boolean_1 = true;
		}
		((Control)this).OnParentChanged(e);
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		method_0();
	}

	void Class192.Interface2.imethod_0(int int_0, ScrollEventType scrollEventType_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (int_0 != ((ScrollBar)this).get_Value())
		{
			int value = ((ScrollBar)this).get_Value();
			((ScrollBar)this).set_Value(int_0);
			ScrollEventArgs val = new ScrollEventArgs(scrollEventType_0, value, int_0, (ScrollOrientation)0);
			((ScrollBar)this).OnScroll(val);
		}
	}
}

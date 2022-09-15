using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.ScrollBar;

namespace DevComponents.DotNetBar.Controls;

internal class Class192 : IDisposable
{
	internal interface Interface2
	{
		void imethod_0(int int_0, ScrollEventType scrollEventType_0);
	}

	private ScrollBarCore scrollBarCore_0;

	private ScrollBar scrollBar_0;

	private Interface2 interface2_0;

	private bool bool_0;

	private ColorScheme colorScheme_0;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	private bool Boolean_0 => bool_0;

	public eRenderMode ERenderMode_0
	{
		get
		{
			return eRenderMode_0;
		}
		set
		{
			if (eRenderMode_0 != value)
			{
				eRenderMode_0 = value;
				((Control)scrollBar_0).Invalidate(true);
			}
		}
	}

	public BaseRenderer BaseRenderer_0
	{
		get
		{
			return baseRenderer_1;
		}
		set
		{
			baseRenderer_1 = value;
		}
	}

	internal ScrollBarCore ScrollBarCore_0 => scrollBarCore_0;

	public bool Boolean_1
	{
		get
		{
			return scrollBarCore_0.IsAppScrollBarStyle;
		}
		set
		{
			scrollBarCore_0.IsAppScrollBarStyle = value;
		}
	}

	public Class192(ScrollBar sb)
	{
		scrollBar_0 = sb;
		interface2_0 = (Interface2)scrollBar_0;
		bool_0 = scrollBar_0 is VScrollBar;
		scrollBarCore_0 = new ScrollBarCore((Control)(object)scrollBar_0, isPassive: false);
		scrollBarCore_0.ValueChanged += scrollBarCore_0_ValueChanged;
		if (scrollBar_0 is HScrollBar)
		{
			scrollBarCore_0.Orientation = eOrientation.Horizontal;
		}
		else
		{
			scrollBarCore_0.Orientation = eOrientation.Vertical;
		}
		scrollBarCore_0.Minimum = scrollBar_0.get_Minimum();
		scrollBarCore_0.Maximum = scrollBar_0.get_Maximum();
		scrollBarCore_0.Value = scrollBar_0.get_Value();
		scrollBarCore_0.Enabled = ((Control)scrollBar_0).get_Enabled();
		((Control)scrollBar_0).add_EnabledChanged((EventHandler)scrollBar_0_EnabledChanged);
	}

	private void scrollBar_0_EnabledChanged(object sender, EventArgs e)
	{
		scrollBarCore_0.Enabled = ((Control)scrollBar_0).get_Enabled();
	}

	internal void method_0()
	{
		method_1();
	}

	internal void method_1()
	{
		Rectangle rectangle = new Rectangle(0, 0, ((Control)scrollBar_0).get_Width(), ((Control)scrollBar_0).get_Height());
		if (scrollBarCore_0.Minimum != scrollBar_0.get_Minimum())
		{
			scrollBarCore_0.Minimum = scrollBar_0.get_Minimum();
		}
		if (scrollBarCore_0.Maximum != scrollBar_0.get_Maximum())
		{
			scrollBarCore_0.Maximum = scrollBar_0.get_Maximum();
		}
		if (scrollBarCore_0.SmallChange != scrollBar_0.get_SmallChange())
		{
			scrollBarCore_0.SmallChange = scrollBar_0.get_SmallChange();
		}
		if (scrollBarCore_0.LargeChange != scrollBar_0.get_LargeChange())
		{
			scrollBarCore_0.LargeChange = scrollBar_0.get_LargeChange();
		}
		if (scrollBarCore_0.Value != scrollBar_0.get_Value())
		{
			scrollBarCore_0.Value = scrollBar_0.get_Value();
		}
		if (rectangle != scrollBarCore_0.DisplayRectangle)
		{
			scrollBarCore_0.DisplayRectangle = rectangle;
		}
	}

	internal void method_2(EventArgs eventArgs_0)
	{
		if (((Control)scrollBar_0).get_Capture())
		{
			((Control)scrollBar_0).set_Capture(false);
		}
	}

	internal void method_3(EventArgs eventArgs_0)
	{
		scrollBarCore_0.MouseLeave();
	}

	internal void method_4(MouseEventArgs mouseEventArgs_0)
	{
		scrollBarCore_0.MouseMove(mouseEventArgs_0);
	}

	internal void method_5(Rectangle rectangle_0)
	{
		scrollBarCore_0.method_0();
	}

	internal void method_6(MouseEventArgs mouseEventArgs_0)
	{
		scrollBarCore_0.MouseDown(mouseEventArgs_0);
	}

	internal void method_7(MouseEventArgs mouseEventArgs_0)
	{
		scrollBarCore_0.MouseUp(mouseEventArgs_0);
	}

	private void scrollBarCore_0_ValueChanged(object sender, EventArgs e)
	{
		method_8(scrollBarCore_0.Value);
	}

	private void method_8(int int_0)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (scrollBar_0.get_Value() != int_0 || scrollBar_0.get_Value() == scrollBarCore_0.method_13())
		{
			ScrollEventType val = (ScrollEventType)1;
			if (scrollBarCore_0.Enum27_0 == ScrollBarCore.Enum27.const_1)
			{
				val = (ScrollEventType)0;
			}
			else if (scrollBarCore_0.Enum27_0 == ScrollBarCore.Enum27.const_2)
			{
				val = (ScrollEventType)5;
			}
			else if (scrollBarCore_0.Enum27_0 == ScrollBarCore.Enum27.const_3)
			{
				val = ((int_0 <= scrollBar_0.get_Value()) ? ((ScrollEventType)2) : ((ScrollEventType)3));
			}
			if ((int)val == 1 && scrollBar_0.get_Value() == int_0 && scrollBar_0.get_Value() == scrollBarCore_0.method_13())
			{
				val = (ScrollEventType)7;
			}
			interface2_0.imethod_0(int_0, val);
		}
	}

	public void Dispose()
	{
	}

	internal void method_9(PaintEventArgs paintEventArgs_0)
	{
		Graphics graphics = paintEventArgs_0.get_Graphics();
		method_1();
		scrollBarCore_0.Paint(method_10(graphics));
	}

	private ItemPaintArgs method_10(Graphics graphics_0)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(scrollBar_0 as IOwner, (Control)(object)scrollBar_0, graphics_0, GetColorScheme());
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		itemPaintArgs.DesignerSelection = false;
		itemPaintArgs.GlassEnabled = false;
		return itemPaintArgs;
	}

	protected virtual ColorScheme GetColorScheme()
	{
		BaseRenderer renderer = GetRenderer();
		if (renderer is Office2007Renderer)
		{
			return ((Office2007Renderer)renderer).ColorTable.LegacyColors;
		}
		if (colorScheme_0 == null)
		{
			colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2007);
		}
		return colorScheme_0;
	}

	public virtual BaseRenderer GetRenderer()
	{
		if (eRenderMode_0 == eRenderMode.Global && GlobalManager.Renderer != null)
		{
			return GlobalManager.Renderer;
		}
		if (eRenderMode_0 == eRenderMode.Custom && baseRenderer_1 != null)
		{
			return baseRenderer_1;
		}
		if (baseRenderer_0 == null)
		{
			baseRenderer_0 = new Office2007Renderer();
		}
		return baseRenderer_0;
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[DefaultEvent("ExpandedChanged")]
[ToolboxItem(true)]
[Designer(typeof(ExpandableSplitterDesigner))]
[ComVisible(false)]
public class ExpandableSplitter : Splitter, Interface5
{
	private int int_0 = 100;

	private Control control_0;

	private bool bool_0 = true;

	private eSplitterStyle eSplitterStyle_0;

	private bool bool_1 = true;

	private eShortcut eShortcut_0;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private Point point_0 = Point.Empty;

	private ColorScheme colorScheme_0;

	private eColorSchemePart eColorSchemePart_0 = eColorSchemePart.None;

	private Color color_0 = Color.Empty;

	private eColorSchemePart eColorSchemePart_1 = eColorSchemePart.None;

	private int int_1;

	private Color color_1 = Color.Empty;

	private eColorSchemePart eColorSchemePart_2 = eColorSchemePart.None;

	private Color color_2 = Color.Empty;

	private eColorSchemePart eColorSchemePart_3 = eColorSchemePart.None;

	private Color color_3 = Color.Empty;

	private eColorSchemePart eColorSchemePart_4 = eColorSchemePart.None;

	private Color color_4 = Color.Empty;

	private eColorSchemePart eColorSchemePart_5 = eColorSchemePart.None;

	private Color color_5 = Color.Empty;

	private eColorSchemePart eColorSchemePart_6 = eColorSchemePart.None;

	private Color color_6 = Color.Empty;

	private eColorSchemePart eColorSchemePart_7 = eColorSchemePart.None;

	private int int_2;

	private Color color_7 = Color.Empty;

	private eColorSchemePart eColorSchemePart_8 = eColorSchemePart.None;

	private Color color_8 = Color.Empty;

	private eColorSchemePart eColorSchemePart_9 = eColorSchemePart.None;

	private Color color_9 = Color.Empty;

	private eColorSchemePart eColorSchemePart_10 = eColorSchemePart.None;

	private Color color_10 = Color.Empty;

	private eColorSchemePart eColorSchemePart_11 = eColorSchemePart.None;

	private Class44 class44_0;

	private Class47 class47_0 = new Class47();

	private bool bool_6 = true;

	private bool bool_7;

	private ExpandChangeEventHandler expandChangeEventHandler_0;

	private ExpandChangeEventHandler expandChangeEventHandler_1;

	[Browsable(true)]
	[Category("Expand")]
	[Description("Indicates whether expandable control ExpandableControl assigned to this splitter is expaned or not. Default value is true.")]
	[DefaultValue(true)]
	public bool Expanded
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				method_8(value, eEventSource.Code);
			}
		}
	}

	[Description("Indicates whether Click event is triggering expand/collapse of the splitter. Default value is true.")]
	[Category("Expand")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool ExpandActionClick
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

	[DefaultValue(false)]
	[Description("Indicates whether DoubleClick event is triggering expand/collapse of the splitter. Default value is false.")]
	[Browsable(true)]
	[Category("Expand")]
	public bool ExpandActionDoubleClick
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

	[DefaultValue(true)]
	[Category("Expand")]
	[Description("Indicates whether splitter will act as expandable splitter. Default value is true.")]
	[Browsable(true)]
	public bool Expandable
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((Control)this).Refresh();
		}
	}

	[DefaultValue(null)]
	[Description("Indicates control that will be expanded/collapsed by the splitter.")]
	[Browsable(true)]
	[Category("Expand")]
	public Control ExpandableControl
	{
		get
		{
			return control_0;
		}
		set
		{
			if (value != this)
			{
				control_0 = value;
				method_5();
			}
		}
	}

	[DefaultValue(eSplitterStyle.Office2003)]
	[Description("Indicates visual style of the control.")]
	[Category("Appearance")]
	[Browsable(true)]
	public eSplitterStyle Style
	{
		get
		{
			return eSplitterStyle_0;
		}
		set
		{
			eSplitterStyle_0 = value;
			method_9();
		}
	}

	[DefaultValue(100)]
	[Category("Expand")]
	[Browsable(true)]
	[Description("Indicates animation time in milliseconds, default value is 100.")]
	public int AnimationTime
	{
		get
		{
			return int_0;
		}
		set
		{
			if (int_0 >= 0)
			{
				int_0 = value;
			}
		}
	}

	[Description("Indicates shortcut key to expand/collapse splitter.")]
	[Browsable(true)]
	[DefaultValue(eShortcut.None)]
	[Category("Expand")]
	public eShortcut Shortcut
	{
		get
		{
			return eShortcut_0;
		}
		set
		{
			eShortcut_0 = value;
			if (eShortcut_0 != 0 && ((Control)this).get_IsHandleCreated())
			{
				method_13();
			}
		}
	}

	[Description("Gets or sets the background color for UI element.")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Category("Colors")]
	public Color BackColor
	{
		get
		{
			return method_10(((Control)this).get_BackColor(), eColorSchemePart_0);
		}
		set
		{
			if (eColorSchemePart_0 != eColorSchemePart.None && !value.IsEmpty)
			{
				BackColorSchemePart = eColorSchemePart.None;
			}
			((Control)this).set_BackColor(value);
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart BackColorSchemePart
	{
		get
		{
			return eColorSchemePart_0;
		}
		set
		{
			eColorSchemePart_0 = value;
			method_9();
		}
	}

	[Description("Gets or sets the target gradient background color for UI element.")]
	[Browsable(true)]
	[Category("Colors")]
	public Color BackColor2
	{
		get
		{
			return method_10(color_0, eColorSchemePart_1);
		}
		set
		{
			if (eColorSchemePart_1 != eColorSchemePart.None && !value.IsEmpty)
			{
				BackColor2SchemePart = eColorSchemePart.None;
			}
			color_0 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart BackColor2SchemePart
	{
		get
		{
			return eColorSchemePart_1;
		}
		set
		{
			eColorSchemePart_1 = value;
			method_9();
		}
	}

	[Description("Gets or sets the background gradient angle.")]
	[DefaultValue(0)]
	[Browsable(true)]
	[Category("Background")]
	public int BackColorGradientAngle
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 != value)
			{
				int_1 = value;
				method_9();
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates expand part fill color.")]
	[Category("Colors")]
	public Color ExpandFillColor
	{
		get
		{
			return method_10(color_1, eColorSchemePart_2);
		}
		set
		{
			if (eColorSchemePart_2 != eColorSchemePart.None && !value.IsEmpty)
			{
				ExpandFillColorSchemePart = eColorSchemePart.None;
			}
			color_1 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart ExpandFillColorSchemePart
	{
		get
		{
			return eColorSchemePart_2;
		}
		set
		{
			eColorSchemePart_2 = value;
			method_9();
		}
	}

	[Category("Colors")]
	[Description("Indicates expand part line color.")]
	[Browsable(true)]
	public Color ExpandLineColor
	{
		get
		{
			return method_10(color_2, eColorSchemePart_3);
		}
		set
		{
			if (eColorSchemePart_3 != eColorSchemePart.None && !value.IsEmpty)
			{
				ExpandLineColorSchemePart = eColorSchemePart.None;
			}
			color_2 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart ExpandLineColorSchemePart
	{
		get
		{
			return eColorSchemePart_3;
		}
		set
		{
			eColorSchemePart_3 = value;
			method_9();
		}
	}

	[Category("Colors")]
	[Browsable(true)]
	[Description("Indicates expand part line color.")]
	public Color GripDarkColor
	{
		get
		{
			return method_10(color_3, eColorSchemePart_4);
		}
		set
		{
			if (eColorSchemePart_4 != eColorSchemePart.None && !value.IsEmpty)
			{
				GripDarkColorSchemePart = eColorSchemePart.None;
			}
			color_3 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart GripDarkColorSchemePart
	{
		get
		{
			return eColorSchemePart_4;
		}
		set
		{
			eColorSchemePart_4 = value;
			method_9();
		}
	}

	[Description("Indicates expand part line color.")]
	[Browsable(true)]
	[Category("Colors")]
	public Color GripLightColor
	{
		get
		{
			return method_10(color_4, eColorSchemePart_5);
		}
		set
		{
			if (eColorSchemePart_5 != eColorSchemePart.None && !value.IsEmpty)
			{
				GripLightColorSchemePart = eColorSchemePart.None;
			}
			color_4 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart GripLightColorSchemePart
	{
		get
		{
			return eColorSchemePart_5;
		}
		set
		{
			eColorSchemePart_5 = value;
			method_9();
		}
	}

	[Browsable(true)]
	[Description("Gets or sets the background color for UI element when mouse is over the element.")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[Category("Colors")]
	public Color HotBackColor
	{
		get
		{
			return method_10(color_5, eColorSchemePart_6);
		}
		set
		{
			if (eColorSchemePart_6 != eColorSchemePart.None && !value.IsEmpty)
			{
				HotBackColorSchemePart = eColorSchemePart.None;
			}
			color_5 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart HotBackColorSchemePart
	{
		get
		{
			return eColorSchemePart_6;
		}
		set
		{
			eColorSchemePart_6 = value;
			method_9();
		}
	}

	[Category("Colors")]
	[Description("Gets or sets the target gradient background color for UI element when mouse is over the element.")]
	[Browsable(true)]
	public Color HotBackColor2
	{
		get
		{
			return method_10(color_6, eColorSchemePart_7);
		}
		set
		{
			if (eColorSchemePart_7 != eColorSchemePart.None && !value.IsEmpty)
			{
				HotBackColor2SchemePart = eColorSchemePart.None;
			}
			color_6 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart HotBackColor2SchemePart
	{
		get
		{
			return eColorSchemePart_7;
		}
		set
		{
			eColorSchemePart_7 = value;
			method_9();
		}
	}

	[Browsable(true)]
	[DefaultValue(0)]
	[Category("Background")]
	[Description("Gets or sets the background gradient angle when mouse is over the element.")]
	public int HotBackColorGradientAngle
	{
		get
		{
			return int_2;
		}
		set
		{
			if (int_2 != value)
			{
				int_2 = value;
				method_9();
			}
		}
	}

	[Description("Indicates expand part fill color when mouse is over the element.")]
	[Browsable(true)]
	[Category("Colors")]
	public Color HotExpandFillColor
	{
		get
		{
			return method_10(color_7, eColorSchemePart_8);
		}
		set
		{
			if (eColorSchemePart_8 != eColorSchemePart.None && !value.IsEmpty)
			{
				HotExpandFillColorSchemePart = eColorSchemePart.None;
			}
			color_7 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart HotExpandFillColorSchemePart
	{
		get
		{
			return eColorSchemePart_8;
		}
		set
		{
			eColorSchemePart_8 = value;
			method_9();
		}
	}

	[Description("Indicates expand part line color when mouse is over the element.")]
	[Browsable(true)]
	[Category("Colors")]
	public Color HotExpandLineColor
	{
		get
		{
			return method_10(color_8, eColorSchemePart_9);
		}
		set
		{
			if (eColorSchemePart_9 != eColorSchemePart.None && !value.IsEmpty)
			{
				HotExpandLineColorSchemePart = eColorSchemePart.None;
			}
			color_8 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart HotExpandLineColorSchemePart
	{
		get
		{
			return eColorSchemePart_9;
		}
		set
		{
			eColorSchemePart_9 = value;
			method_9();
		}
	}

	[Browsable(true)]
	[Description("Indicates expand part line color when mouse is over the element.")]
	[Category("Colors")]
	public Color HotGripDarkColor
	{
		get
		{
			return method_10(color_9, eColorSchemePart_10);
		}
		set
		{
			if (eColorSchemePart_10 != eColorSchemePart.None && !value.IsEmpty)
			{
				HotGripDarkColorSchemePart = eColorSchemePart.None;
			}
			color_9 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart HotGripDarkColorSchemePart
	{
		get
		{
			return eColorSchemePart_10;
		}
		set
		{
			eColorSchemePart_10 = value;
			method_9();
		}
	}

	[Browsable(true)]
	[Description("Indicates grip part light color when mouse is over the element.")]
	[Category("Colors")]
	public Color HotGripLightColor
	{
		get
		{
			return method_10(color_10, eColorSchemePart_11);
		}
		set
		{
			if (eColorSchemePart_11 != eColorSchemePart.None && !value.IsEmpty)
			{
				HotGripLightColorSchemePart = eColorSchemePart.None;
			}
			color_10 = value;
			method_9();
		}
	}

	[Browsable(false)]
	public eColorSchemePart HotGripLightColorSchemePart
	{
		get
		{
			return eColorSchemePart_11;
		}
		set
		{
			eColorSchemePart_11 = value;
			method_9();
		}
	}

	bool Interface5.Boolean_0
	{
		get
		{
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				return val.get_Modal();
			}
			return false;
		}
	}

	public event ExpandChangeEventHandler ExpandedChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			expandChangeEventHandler_0 = (ExpandChangeEventHandler)Delegate.Combine(expandChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			expandChangeEventHandler_0 = (ExpandChangeEventHandler)Delegate.Remove(expandChangeEventHandler_0, value);
		}
	}

	public event ExpandChangeEventHandler ExpandedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			expandChangeEventHandler_1 = (ExpandChangeEventHandler)Delegate.Combine(expandChangeEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			expandChangeEventHandler_1 = (ExpandChangeEventHandler)Delegate.Remove(expandChangeEventHandler_1, value);
		}
	}

	public ExpandableSplitter()
	{
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2003);
		ApplyStyle(eSplitterStyle.Office2003);
	}

	private Class44 method_0()
	{
		if (class44_0 == null)
		{
			switch (eSplitterStyle_0)
			{
			case eSplitterStyle.Mozilla:
				class44_0 = new Class46();
				break;
			case eSplitterStyle.Office2003:
			case eSplitterStyle.Office2007:
				class44_0 = new Class45();
				break;
			}
		}
		return class44_0;
	}

	private Class47 method_1(Graphics graphics_0)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		class47_0.graphics_0 = graphics_0;
		class47_0.class48_0 = method_11();
		class47_0.bool_0 = bool_1;
		class47_0.bool_1 = bool_0;
		class47_0.dockStyle_0 = ((Control)this).get_Dock();
		class47_0.rectangle_0 = ((Control)this).get_DisplayRectangle();
		return class47_0;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		method_0().Paint(method_1(e.get_Graphics()));
	}

	private void method_2()
	{
		if (ExpandableControl == null)
		{
			return;
		}
		if (Expanded)
		{
			if (!ExpandableControl.get_Visible())
			{
				if (AnimationTime != 0 && !((Component)this).DesignMode)
				{
					Rectangle rectangle_ = method_3(ExpandableControl, bool_8: false);
					Rectangle bounds = ExpandableControl.get_Bounds();
					Class109.smethod_66(ExpandableControl, bool_3: true, int_0, rectangle_, bounds);
				}
				else
				{
					if (((Component)this).DesignMode)
					{
						TypeDescriptor.GetProperties(ExpandableControl)["Visible"]!.SetValue(ExpandableControl, true);
					}
					ExpandableControl.set_Visible(true);
				}
			}
		}
		else if (ExpandableControl.get_Visible())
		{
			if (AnimationTime != 0 && !((Component)this).DesignMode)
			{
				Rectangle bounds2 = ExpandableControl.get_Bounds();
				Rectangle rectangle_2 = method_3(ExpandableControl, bool_8: false);
				Class109.smethod_66(ExpandableControl, bool_3: false, int_0, bounds2, rectangle_2);
				ExpandableControl.set_Visible(false);
				ExpandableControl.set_Bounds(bounds2);
			}
			else
			{
				if (((Component)this).DesignMode)
				{
					TypeDescriptor.GetProperties(ExpandableControl)["Visible"]!.SetValue(ExpandableControl, false);
				}
				ExpandableControl.set_Visible(false);
			}
		}
		((Control)this).Refresh();
	}

	private Rectangle method_3(Control control_1, bool bool_8)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Invalid comparison between Unknown and I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Invalid comparison between Unknown and I4
		Rectangle result = Rectangle.Empty;
		DockStyle val = method_4(control_1);
		if (!bool_8)
		{
			if ((int)val == 3)
			{
				result = new Rectangle(control_1.get_Left(), control_1.get_Top(), 0, control_1.get_Height());
			}
			else if ((int)val == 4)
			{
				result = new Rectangle(control_1.get_Right(), control_1.get_Top(), 0, control_1.get_Height());
			}
			else if ((int)val == 1)
			{
				result = new Rectangle(control_1.get_Left(), control_1.get_Top(), control_1.get_Width(), 0);
			}
			else if ((int)val == 2)
			{
				result = new Rectangle(control_1.get_Left(), control_1.get_Bottom(), control_1.get_Width(), 0);
			}
		}
		else if ((int)val == 3)
		{
			result = new Rectangle(control_1.get_Left(), control_1.get_Top(), control_1.get_Width(), control_1.get_Height());
		}
		else if ((int)val == 4)
		{
			result = new Rectangle(control_1.get_Left() - control_1.get_Width(), control_1.get_Top(), control_1.get_Width(), control_1.get_Height());
		}
		else if ((int)val == 1)
		{
			result = new Rectangle(control_1.get_Left(), control_1.get_Top(), control_1.get_Width(), control_1.get_Height());
		}
		else if ((int)val == 2)
		{
			result = new Rectangle(control_1.get_Left(), control_1.get_Top() - control_1.get_Height(), control_1.get_Width(), control_1.get_Height());
		}
		return result;
	}

	private DockStyle method_4(Control control_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if ((int)control_1.get_Dock() == 0)
		{
			if (control_1.get_Right() >= ((Control)this).get_Left())
			{
				if (control_1.get_Left() <= ((Control)this).get_Right())
				{
					if (control_1.get_Bottom() >= ((Control)this).get_Top())
					{
						if (control_1.get_Top() <= ((Control)this).get_Bottom())
						{
							return (DockStyle)3;
						}
						return (DockStyle)2;
					}
					return (DockStyle)1;
				}
				return (DockStyle)4;
			}
			return (DockStyle)3;
		}
		if ((int)control_1.get_Dock() == 5)
		{
			return (DockStyle)3;
		}
		return control_1.get_Dock();
	}

	private void method_5()
	{
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		method_13();
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		((Control)this).OnHandleDestroyed(e);
		method_14();
	}

	protected override void OnClick(EventArgs e)
	{
		((Control)this).OnClick(e);
		if (Expandable && bool_3 && !bool_5 && bool_6)
		{
			method_8(!Expanded, eEventSource.Mouse);
		}
		bool_5 = false;
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		((Control)this).OnDoubleClick(e);
		if (Expandable && bool_3 && bool_7)
		{
			method_8(!Expanded, eEventSource.Mouse);
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (bool_4)
		{
			((Splitter)this).OnMouseDown(e);
			return;
		}
		bool_5 = false;
		point_0 = new Point(e.get_X(), e.get_Y());
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		bool_4 = false;
		((Splitter)this).OnMouseUp(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		bool_3 = true;
		((Control)this).Refresh();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		bool_3 = false;
		((Control)this).Refresh();
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		((Splitter)this).OnMouseMove(e);
		if (!((Control)this).get_DisplayRectangle().Contains(e.get_X(), e.get_Y()) && !bool_4 && (int)e.get_Button() == 1048576)
		{
			bool_4 = true;
			bool_5 = true;
			((Control)this).OnMouseDown(new MouseEventArgs(e.get_Button(), 1, point_0.X, point_0.Y, e.get_Delta()));
		}
	}

	private void method_6(ExpandedChangeEventArgs expandedChangeEventArgs_0)
	{
		if (expandChangeEventHandler_0 != null)
		{
			expandChangeEventHandler_0(this, expandedChangeEventArgs_0);
		}
	}

	private void method_7(ExpandedChangeEventArgs expandedChangeEventArgs_0)
	{
		if (expandChangeEventHandler_1 != null)
		{
			expandChangeEventHandler_1(this, expandedChangeEventArgs_0);
		}
	}

	private void method_8(bool bool_8, eEventSource eEventSource_0)
	{
		ExpandedChangeEventArgs expandedChangeEventArgs = new ExpandedChangeEventArgs(eEventSource_0, bool_8);
		method_6(expandedChangeEventArgs);
		if (!expandedChangeEventArgs.Cancel)
		{
			bool_0 = bool_8;
			method_2();
			method_7(expandedChangeEventArgs);
		}
	}

	private void method_9()
	{
		class44_0 = null;
		((Control)this).Invalidate();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor()
	{
		((Control)this).set_BackColor(Color.Empty);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor2()
	{
		color_0 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetExpandFillColor()
	{
		color_1 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetExpandLineColor()
	{
		color_2 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetGripDarkColor()
	{
		color_3 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetGripLightColor()
	{
		color_4 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetHotBackColor()
	{
		color_5 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetHotBackColor2()
	{
		color_6 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetHotExpandFillColor()
	{
		color_7 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetHotExpandLineColor()
	{
		color_8 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetHotGripDarkColor()
	{
		color_9 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetHotGripLightColor()
	{
		color_10 = Color.Empty;
	}

	private Color method_10(Color color_11, eColorSchemePart eColorSchemePart_12)
	{
		if (eColorSchemePart_12 != eColorSchemePart.None && eColorSchemePart_12 != eColorSchemePart.Custom)
		{
			ColorScheme colorScheme = GetColorScheme();
			if (colorScheme == null)
			{
				return color_11;
			}
			return (Color)colorScheme.GetType().GetProperty(eColorSchemePart_12.ToString())!.GetValue(colorScheme, null);
		}
		return color_11;
	}

	private ColorScheme GetColorScheme()
	{
		if (Style == eSplitterStyle.Office2007 && GlobalManager.Renderer is Office2007Renderer)
		{
			return ((Office2007Renderer)GlobalManager.Renderer).ColorTable.LegacyColors;
		}
		return colorScheme_0;
	}

	private Class48 method_11()
	{
		Class48 @class = new Class48();
		if (bool_3 && !HotBackColor.IsEmpty)
		{
			@class.color_0 = HotBackColor;
			@class.color_1 = HotBackColor2;
			@class.int_0 = HotBackColorGradientAngle;
			@class.color_5 = HotExpandFillColor;
			@class.color_4 = HotExpandLineColor;
			@class.color_2 = HotGripDarkColor;
			@class.color_3 = HotGripLightColor;
		}
		else
		{
			@class.color_0 = BackColor;
			@class.color_1 = BackColor2;
			@class.int_0 = BackColorGradientAngle;
			@class.color_5 = ExpandFillColor;
			@class.color_4 = ExpandLineColor;
			@class.color_2 = GripDarkColor;
			@class.color_3 = GripLightColor;
		}
		return @class;
	}

	public void ApplyStyle(eSplitterStyle style)
	{
		switch (style)
		{
		case eSplitterStyle.Office2003:
			colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2003);
			BackColorSchemePart = eColorSchemePart.PanelBackground;
			BackColor2SchemePart = eColorSchemePart.PanelBorder;
			GripLightColorSchemePart = eColorSchemePart.BarBackground;
			GripDarkColorSchemePart = eColorSchemePart.ItemText;
			ExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
			ExpandLineColorSchemePart = eColorSchemePart.ItemText;
			HotBackColorSchemePart = eColorSchemePart.ItemPressedBackground;
			HotBackColor2SchemePart = eColorSchemePart.ItemPressedBackground2;
			HotGripLightColorSchemePart = eColorSchemePart.BarBackground;
			HotGripDarkColorSchemePart = eColorSchemePart.PanelBorder;
			HotExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
			HotExpandLineColorSchemePart = eColorSchemePart.ItemText;
			break;
		case eSplitterStyle.Office2007:
			colorScheme_0 = new ColorScheme(eDotNetBarStyle.Office2007);
			BackColorSchemePart = eColorSchemePart.PanelBackground;
			BackColor2SchemePart = eColorSchemePart.PanelBorder;
			GripLightColorSchemePart = eColorSchemePart.BarBackground;
			GripDarkColorSchemePart = eColorSchemePart.ItemText;
			ExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
			ExpandLineColorSchemePart = eColorSchemePart.ItemText;
			HotBackColorSchemePart = eColorSchemePart.ItemPressedBackground;
			HotBackColor2SchemePart = eColorSchemePart.ItemPressedBackground2;
			HotGripLightColorSchemePart = eColorSchemePart.BarBackground;
			HotGripDarkColorSchemePart = eColorSchemePart.PanelBorder;
			HotExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
			HotExpandLineColorSchemePart = eColorSchemePart.ItemText;
			break;
		case eSplitterStyle.Mozilla:
			colorScheme_0 = new ColorScheme(eDotNetBarStyle.VS2005);
			BackColorSchemePart = eColorSchemePart.None;
			BackColor = SystemColors.ControlLight;
			BackColor2SchemePart = eColorSchemePart.None;
			BackColor2 = Color.Empty;
			GripLightColorSchemePart = eColorSchemePart.MenuBackground;
			GripDarkColorSchemePart = eColorSchemePart.ItemPressedBorder;
			ExpandFillColorSchemePart = eColorSchemePart.ItemPressedBackground;
			ExpandLineColorSchemePart = eColorSchemePart.ItemPressedBorder;
			HotBackColorSchemePart = eColorSchemePart.ItemCheckedBackground;
			HotBackColor2 = Color.Empty;
			HotBackColor2SchemePart = eColorSchemePart.None;
			HotGripLightColorSchemePart = eColorSchemePart.MenuBackground;
			HotGripDarkColorSchemePart = eColorSchemePart.ItemPressedBorder;
			HotExpandFillColorSchemePart = eColorSchemePart.ItemPressedBackground;
			HotExpandLineColorSchemePart = eColorSchemePart.ItemPressedBorder;
			break;
		}
	}

	bool Interface5.imethod_5(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	bool Interface5.imethod_2(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		if ((int)Control.get_ModifierKeys() != 0 || (intptr_1.ToInt32() >= 112 && intptr_1.ToInt32() <= 123))
		{
			int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
			if (method_12((eShortcut)eShortcut_))
			{
				return true;
			}
		}
		return false;
	}

	private bool method_12(eShortcut eShortcut_1)
	{
		if (eShortcut_1 == eShortcut_0 && Expandable)
		{
			method_8(!Expanded, eEventSource.Keyboard);
		}
		return false;
	}

	bool Interface5.imethod_3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	bool Interface5.imethod_4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	bool Interface5.imethod_0(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		if (!((Component)this).DesignMode && ((int)Control.get_ModifierKeys() != 0 || (intptr_1.ToInt32() >= 112 && intptr_1.ToInt32() <= 123)))
		{
			int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
			if (method_12((eShortcut)eShortcut_))
			{
				return true;
			}
		}
		return false;
	}

	bool Interface5.imethod_1(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	private void method_13()
	{
		if (!bool_2 && !((Component)this).DesignMode && eShortcut_0 != 0)
		{
			Class107.smethod_0(this);
			bool_2 = true;
		}
	}

	private void method_14()
	{
		if (bool_2)
		{
			Class107.smethod_1(this);
			bool_2 = false;
		}
	}
}

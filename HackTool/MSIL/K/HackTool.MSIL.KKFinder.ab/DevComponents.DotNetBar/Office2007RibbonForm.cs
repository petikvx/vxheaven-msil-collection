using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public class Office2007RibbonForm : Form
{
	private IContainer icontainer_0;

	private int int_0 = 6;

	private int int_1 = 6;

	private int int_2 = 6;

	private int int_3 = 6;

	protected int m_DisplayRectangleReductionTop = 1;

	protected int m_DisplayRectangleReductionBottom = 2;

	protected int m_DisplayRectangleReductionHorizontal = 4;

	private RibbonControl ribbonControl_0;

	private FormWindowState formWindowState_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2 = true;

	private bool bool_3 = true;

	private Point point_0 = Point.Empty;

	protected bool m_EnableCustomStyle = true;

	private int int_4;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6 = true;

	private BufferedBitmap bufferedBitmap_0;

	private Rectangle[] rectangle_0;

	private Point point_1 = Point.Empty;

	private bool bool_7;

	private bool bool_8;

	internal int Int32_0 => m_DisplayRectangleReductionHorizontal;

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates whether Windows Vista Glass support is enabled when form is running on Windows Vista with Glass support.")]
	[DefaultValue(true)]
	public bool EnableGlass
	{
		get
		{
			return bool_6;
		}
		set
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Invalid comparison between Unknown and I4
			if (bool_6 == value)
			{
				return;
			}
			bool_6 = value;
			if (ribbonControl_0 != null)
			{
				ribbonControl_0.CanSupportGlass = bool_6;
			}
			if (bool_4 && ((Control)this).get_IsHandleCreated() && !((Component)this).DesignMode)
			{
				bool flag = false;
				if (((Form)this).get_IsMdiContainer() && ((Form)this).get_ActiveMdiChild() != null && (int)((Form)this).get_ActiveMdiChild().get_WindowState() == 2)
				{
					flag = true;
				}
				((Control)this).RecreateHandle();
				if (flag && ((Form)this).get_IsMdiContainer() && ((Form)this).get_ActiveMdiChild() != null)
				{
					((Form)this).get_ActiveMdiChild().set_WindowState((FormWindowState)2);
				}
			}
		}
	}

	[Browsable(false)]
	protected virtual RibbonControl RibbonControl
	{
		get
		{
			return ribbonControl_0;
		}
		set
		{
			ribbonControl_0 = value;
			if (ribbonControl_0 != null)
			{
				method_1();
			}
		}
	}

	protected virtual bool EnableGlassExtend => true;

	internal int Int32_1 => int_4;

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	public FormWindowState WindowState
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			if (bool_0)
			{
				return formWindowState_0;
			}
			return ((Form)this).get_WindowState();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Invalid comparison between Unknown and I4
			((Form)this).set_WindowState(value);
			if ((int)value == 2 && !((Control)this).get_IsHandleCreated() && !bool_1)
			{
				((Form)this).set_StartPosition((FormStartPosition)1);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool EnableCustomStyle
	{
		get
		{
			return m_EnableCustomStyle;
		}
		set
		{
			m_EnableCustomStyle = value;
			OnEnableCustomStyleChanged();
		}
	}

	[Category("Border")]
	[DefaultValue(6)]
	[Description("Indicates top left rounded corner size")]
	[Browsable(true)]
	public int TopLeftCornerSize
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
			((Control)this).set_Region((Region)null);
		}
	}

	[Category("Border")]
	[Browsable(true)]
	[Description("Indicates top right rounded corner size")]
	[DefaultValue(6)]
	public int TopRightCornerSize
	{
		get
		{
			return int_1;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			int_1 = value;
			((Control)this).set_Region((Region)null);
		}
	}

	[Description("Indicates bottom left rounded corner size")]
	[DefaultValue(6)]
	[Browsable(true)]
	[Category("Border")]
	public int BottomLeftCornerSize
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			int_2 = value;
			((Control)this).set_Region((Region)null);
		}
	}

	[Description("Indicates bottom right rounded corner size")]
	[Category("Border")]
	[DefaultValue(6)]
	[Browsable(true)]
	public int BottomRightCornerSize
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
			((Control)this).set_Region((Region)null);
		}
	}

	protected virtual bool PaintClientBorder => IsCustomFormStyleEnabled();

	protected virtual bool PaintRibbonCaption => ribbonControl_0 != null;

	[DefaultValue(true)]
	[Description("Indicates whether 3D MDI border is removed.")]
	[Browsable(true)]
	[Category("Appearance")]
	public bool FlattenMDIBorder
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			method_5();
		}
	}

	public override Rectangle DisplayRectangle
	{
		get
		{
			Rectangle displayRectangle = ((ScrollableControl)this).get_DisplayRectangle();
			return ReduceDisplayRectangle(displayRectangle);
		}
	}

	protected virtual bool HasCustomRegion
	{
		get
		{
			if (IsCustomFormStyleEnabled())
			{
				return !Boolean_1;
			}
			return false;
		}
	}

	internal bool Boolean_0
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

	internal bool Boolean_1
	{
		get
		{
			if (!((Component)this).DesignMode && !((Form)this).get_IsMdiChild())
			{
				if (bool_4)
				{
					return bool_6;
				}
				return false;
			}
			return false;
		}
	}

	protected virtual bool IsSizable
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (((int)((Form)this).get_FormBorderStyle() == 4 || (int)((Form)this).get_FormBorderStyle() == 6) && (int)WindowState == 0)
			{
				return true;
			}
			return false;
		}
	}

	public Office2007RibbonForm()
	{
		bool_4 = method_11();
		method_0();
		UpdateFormStyle();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		if (bufferedBitmap_0 != null)
		{
			bufferedBitmap_0.Dispose();
			bufferedBitmap_0 = null;
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
	}

	protected virtual void UpdateFormStyle()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (IsCustomFormStyleEnabled())
		{
			if (!((Control)this).GetStyle((ControlStyles)8192))
			{
				((Control)this).SetStyle((ControlStyles)(0x2010 | Class50.ControlStyles_0 | 2), true);
			}
		}
		else if (((Control)this).GetStyle((ControlStyles)8192))
		{
			((Control)this).SetStyle((ControlStyles)(0x2010 | Class50.ControlStyles_0), false);
		}
	}

	protected override void OnLoad(EventArgs e)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).OnLoad(e);
		if (IsCustomFormStyleEnabled() && ((Control)this).get_BackColor() == SystemColors.Control && GlobalManager.Renderer is Office2007Renderer)
		{
			((Control)this).set_BackColor(((Office2007Renderer)GlobalManager.Renderer).ColorTable.Form.BackColor);
		}
		bool_1 = true;
		if (bool_0)
		{
			((Form)this).set_WindowState(formWindowState_0);
			bool_0 = false;
		}
	}

	protected override void OnActivated(EventArgs e)
	{
		((Form)this).OnActivated(e);
		method_3();
	}

	protected override void OnDeactivate(EventArgs e)
	{
		((Form)this).OnDeactivate(e);
		method_3();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Form)this).OnTextChanged(e);
		method_3();
	}

	protected override void OnStyleChanged(EventArgs e)
	{
		method_1();
		UpdateFormStyle();
		((Form)this).OnStyleChanged(e);
	}

	private void method_1()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		if (ribbonControl_0 != null && IsCustomFormStyleEnabled())
		{
			ribbonControl_0.RibbonStrip.SystemCaptionItem_0.MinimizeVisible = ((Form)this).get_MinimizeBox();
			if (Boolean_1 && ((Form)this).get_MinimizeBox() && (int)((Form)this).get_FormBorderStyle() == 4)
			{
				ribbonControl_0.RibbonStrip.SystemCaptionItem_0.RestoreMaximizeVisible = true;
			}
			else
			{
				ribbonControl_0.RibbonStrip.SystemCaptionItem_0.RestoreMaximizeVisible = ((Form)this).get_MaximizeBox();
			}
			ribbonControl_0.RibbonStrip.SystemCaptionItem_0.HelpVisible = ((Form)this).get_HelpButton();
			ribbonControl_0.RibbonStrip.SystemCaptionItem_0.Visible = ((Form)this).get_ControlBox();
			ribbonControl_0.RecalcLayout();
		}
	}

	internal void method_2()
	{
		if (Boolean_1 && Class109.smethod_11((Control)(object)this) && EnableGlassExtend)
		{
			int num = 0;
			num = ((ribbonControl_0 == null || !ribbonControl_0.CaptionVisible) ? (SystemInformation.get_FrameBorderSize().Height * Class92.Int32_0) : ribbonControl_0.RibbonStrip.method_35());
			Class51.smethod_7(((Control)this).get_Handle(), num);
			int_4 = num;
		}
	}

	internal void method_3()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		if (IsCustomFormStyleEnabled())
		{
			if (ribbonControl_0 != null && ribbonControl_0.RibbonStrip.CaptionVisible)
			{
				((Control)ribbonControl_0.RibbonStrip).Invalidate(ribbonControl_0.RibbonStrip.Rectangle_1);
			}
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			clientRectangle.Inflate(-m_DisplayRectangleReductionHorizontal * 2, -(m_DisplayRectangleReductionTop * 2 + m_DisplayRectangleReductionBottom * 2));
			Region val = new Region(((Control)this).get_ClientRectangle());
			val.Exclude(GetFormPath(clientRectangle));
			((Control)this).Invalidate(val);
		}
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		if (e.get_Control() is RibbonControl)
		{
			ribbonControl_0 = e.get_Control() as RibbonControl;
			ribbonControl_0.CanSupportGlass = bool_6;
			method_1();
			method_2();
		}
		((Control)this).OnControlAdded(e);
	}

	protected override void OnControlRemoved(ControlEventArgs e)
	{
		if (e.get_Control() == ribbonControl_0)
		{
			ribbonControl_0.CanSupportGlass = false;
			ribbonControl_0 = null;
		}
		((Control)this).OnControlRemoved(e);
	}

	protected override void OnMdiChildActivate(EventArgs e)
	{
		method_3();
		((Form)this).OnMdiChildActivate(e);
		if (Boolean_1)
		{
			IntPtr menu = Class51.GetMenu(((Control)this).get_Handle());
			if (menu != IntPtr.Zero)
			{
				Class51.SetMenu(((Control)this).get_Handle(), IntPtr.Zero);
			}
		}
	}

	private bool method_4()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)WindowState == 2 && RibbonControl != null)
		{
			return !Boolean_1;
		}
		return false;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		if (method_4() && (e.get_X() <= m_DisplayRectangleReductionHorizontal || e.get_X() >= ((Control)this).get_ClientRectangle().Width - m_DisplayRectangleReductionHorizontal) && e.get_Y() <= m_DisplayRectangleReductionHorizontal)
		{
			MouseEventArgs mouseEventArgs_ = e;
			if (e.get_X() >= ((Control)this).get_ClientRectangle().Width - m_DisplayRectangleReductionHorizontal)
			{
				mouseEventArgs_ = new MouseEventArgs(e.get_Button(), e.get_Clicks(), e.get_X() - m_DisplayRectangleReductionHorizontal * 2, e.get_Y(), e.get_Delta());
			}
			RibbonControl.RibbonStrip.method_49(mouseEventArgs_);
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		if (method_4() && (e.get_X() <= m_DisplayRectangleReductionHorizontal || e.get_X() >= ((Control)this).get_ClientRectangle().Width - m_DisplayRectangleReductionHorizontal) && e.get_Y() <= m_DisplayRectangleReductionHorizontal)
		{
			MouseEventArgs mouseEventArgs_ = e;
			if (e.get_X() >= ((Control)this).get_ClientRectangle().Width - m_DisplayRectangleReductionHorizontal)
			{
				mouseEventArgs_ = new MouseEventArgs(e.get_Button(), e.get_Clicks(), e.get_X() - m_DisplayRectangleReductionHorizontal * 2, e.get_Y(), e.get_Delta());
			}
			RibbonControl.RibbonStrip.method_51(mouseEventArgs_);
		}
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		if (method_4() && (e.get_X() <= m_DisplayRectangleReductionHorizontal || e.get_X() >= ((Control)this).get_ClientRectangle().Width - m_DisplayRectangleReductionHorizontal))
		{
			MouseEventArgs mouseEventArgs_ = e;
			if (e.get_X() >= ((Control)this).get_ClientRectangle().Width - m_DisplayRectangleReductionHorizontal)
			{
				mouseEventArgs_ = new MouseEventArgs(e.get_Button(), e.get_Clicks(), e.get_X() - m_DisplayRectangleReductionHorizontal * 2, e.get_Y(), e.get_Delta());
			}
			RibbonControl.RibbonStrip.method_50(mouseEventArgs_);
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (((Form)this).get_IsMdiContainer())
		{
			BarUtilities.ChangeMDIClientBorder((Form)(object)this, bool_2);
		}
		method_2();
		((Form)this).OnHandleCreated(e);
	}

	private void method_5()
	{
		if (((Form)this).get_IsMdiContainer() && ((Control)this).get_IsHandleCreated())
		{
			BarUtilities.ChangeMDIClientBorder((Form)(object)this, bool_2);
		}
	}

	protected virtual void OnEnableCustomStyleChanged()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Region((Region)null);
		FormBorderStyle formBorderStyle = ((Form)this).get_FormBorderStyle();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_FormBorderStyle(formBorderStyle);
		if (Boolean_1)
		{
			Class51.smethod_7(((Control)this).get_Handle(), 0);
		}
	}

	protected virtual bool IsCustomFormStyleEnabled()
	{
		return m_EnableCustomStyle;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		if (HasCustomRegion && ((Control)this).get_Region() == null)
		{
			((Control)this).set_Region(GetRegion());
		}
		if (Boolean_1 && int_4 > 0)
		{
			e.get_Graphics().SetClip(new Rectangle(0, 0, ((Control)this).get_Width(), int_4), (CombineMode)4);
		}
		if (((Form)this).get_RightToLeftLayout())
		{
			SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
			try
			{
				e.get_Graphics().FillRectangle((Brush)(object)val, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			((Form)this).OnPaint(e);
		}
		if (PaintClientBorder && !Boolean_1)
		{
			PaintFormBorder(e);
		}
		if (PaintRibbonCaption && !Boolean_1)
		{
			PaintCaptionParts(e.get_Graphics());
		}
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
		if (Boolean_1 && int_4 > 0)
		{
			e.get_Graphics().SetClip(new Rectangle(0, 0, ((Control)this).get_Width(), int_4), (CombineMode)4);
		}
		((ScrollableControl)this).OnPaintBackground(e);
	}

	protected virtual void PaintFormBorder(PaintEventArgs e)
	{
		PaintFormBorder(e.get_Graphics(), GetBorderColors().Length);
	}

	protected virtual void PaintFormBorder(Graphics g, int borderSize)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		if (Boolean_1)
		{
			return;
		}
		Color[] borderColors = GetBorderColors();
		Rectangle bounds = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)2);
		bounds.Inflate(-1, -1);
		GraphicsPath formPath = GetFormPath(bounds);
		try
		{
			Region clip = g.get_Clip();
			g.SetClip(formPath, (CombineMode)4);
			Class50.smethod_23(g, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()), borderColors[0]);
			g.set_Clip(clip);
		}
		finally
		{
			((IDisposable)formPath)?.Dispose();
		}
		bounds.Inflate(1, 1);
		int num = 0;
		for (int i = 0; i < borderSize; i++)
		{
			Color color_ = borderColors[num];
			GraphicsPath formPath2 = GetFormPath(bounds);
			try
			{
				Class50.smethod_40(g, formPath2, color_, (i + 1 == borderSize) ? ((Control)this).get_BackColor() : Color.Empty, 90, 1);
			}
			finally
			{
				((IDisposable)formPath2)?.Dispose();
			}
			bounds.Inflate(-1, -1);
			if (num < borderColors.Length - 1)
			{
				num++;
			}
		}
		g.set_SmoothingMode(smoothingMode);
	}

	protected virtual void PaintCaptionParts(Graphics g)
	{
		if (ribbonControl_0 == null || !ribbonControl_0.CaptionVisible || m_DisplayRectangleReductionHorizontal <= 2)
		{
			return;
		}
		RibbonControlRendererEventArgs e = new RibbonControlRendererEventArgs(g, ribbonControl_0, Boolean_1);
		BaseRenderer renderer = ribbonControl_0.RibbonStrip.GetRenderer();
		if (renderer == null)
		{
			return;
		}
		Region clip = g.get_Clip();
		Rectangle rectangle_ = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
		Region val = method_7(rectangle_);
		Rectangle rectangle = new Rectangle(rectangle_.X, ribbonControl_0.RibbonStrip.Rectangle_1.Height + 2, rectangle_.Width, ((Control)this).get_Height() - (ribbonControl_0.RibbonStrip.Rectangle_1.Height + 2));
		g.SetClip(val, (CombineMode)0);
		g.SetClip(rectangle, (CombineMode)4);
		g.TranslateTransform(1f, 1f);
		renderer.DrawRibbonControlBackground(e);
		renderer.DrawQuickAccessToolbarBackground(e);
		g.ResetTransform();
		Bar bar = method_6();
		if (bar != null && Class109.smethod_69(bar.Style) && !bar.IsThemed)
		{
			renderer = bar.GetRenderer();
			if (renderer != null)
			{
				g.SetClip(val, (CombineMode)0);
				ToolbarRendererEventArgs toolbarRendererEventArgs = new ToolbarRendererEventArgs(bar, g, new Rectangle(0, ((Control)bar).get_Top(), ((Control)this).get_Width(), ((Control)bar).get_Height() + 4));
				toolbarRendererEventArgs.itemPaintArgs_0 = bar.method_5(g);
				toolbarRendererEventArgs.itemPaintArgs_0.bool_0 = true;
				renderer.DrawToolbarBackground(toolbarRendererEventArgs);
			}
		}
		g.set_Clip(clip);
		val.Dispose();
	}

	private Bar method_6()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if ((int)val.get_Dock() == 2 && val is Bar)
			{
				return val as Bar;
			}
		}
		return null;
	}

	protected virtual Color[] GetBorderColors()
	{
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			Office2007FormStateColorTable office2007FormStateColorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.Form.Active;
			if (!bool_3 && !((Component)this).DesignMode)
			{
				office2007FormStateColorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.Form.Inactive;
			}
			return office2007FormStateColorTable.BorderColors;
		}
		return new Color[2]
		{
			Color.FromArgb(59, 90, 130),
			Color.FromArgb(177, 198, 225)
		};
	}

	protected virtual Rectangle ReduceDisplayRectangle(Rectangle r)
	{
		if (IsCustomFormStyleEnabled() && !Boolean_1)
		{
			r.Inflate(-m_DisplayRectangleReductionHorizontal, 0);
			r.Y += m_DisplayRectangleReductionTop;
			r.Height -= m_DisplayRectangleReductionTop + m_DisplayRectangleReductionBottom;
		}
		return r;
	}

	protected override void OnResize(EventArgs e)
	{
		if (HasCustomRegion)
		{
			((Control)this).set_Region(GetRegion());
			((Control)this).Invalidate();
		}
		((Form)this).OnResize(e);
	}

	protected virtual Region GetRegion()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		bool flag;
		if ((flag = IsCustomFormStyleEnabled()) && (int)WindowState == 2 && Class109.Boolean_0 && !Class58.bool_0)
		{
			int num = SystemInformation.get_FrameBorderSize().Width * Class92.Int32_0;
			return method_7(new Rectangle(num, 0, ((Control)this).get_Width() - (num * 2 + 1), ((Control)this).get_Height() - 1));
		}
		if ((int)WindowState != 2 && flag)
		{
			return method_7(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
		}
		return null;
	}

	private Region method_7(Rectangle rectangle_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		GraphicsPath formPath = GetFormPath(rectangle_1);
		Region val = new Region();
		val.MakeEmpty();
		val.Union(formPath);
		formPath.Widen(SystemPens.get_Control());
		new Region(formPath);
		val.Union(formPath);
		return val;
	}

	protected virtual GraphicsPath GetFormPath(Rectangle bounds)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		GraphicsPath val = new GraphicsPath();
		Rectangle rectangle = bounds;
		bool flag;
		int num = ((flag = (int)((Control)this).get_RightToLeft() == 1) ? int_1 : (int_0 + 1));
		if (num > 0)
		{
			Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle, num, Enum14.const_0);
			val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		}
		else
		{
			val.AddLine(bounds.X, bounds.Y + 2, bounds.X, bounds.Y);
			val.AddLine(bounds.X, bounds.Y, bounds.X + 2, bounds.Y);
		}
		num = (flag ? (int_0 + 1) : int_1);
		if (num > 0)
		{
			Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle, num, Enum14.const_1);
			val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		}
		else
		{
			val.AddLine(bounds.Right - 2, bounds.Y, bounds.Right, bounds.Y);
			val.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Y + 2);
		}
		if (int_3 > 0)
		{
			Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle, int_3, Enum14.const_3);
			val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		}
		else
		{
			val.AddLine(bounds.Right, bounds.Bottom - 2, bounds.Right, bounds.Bottom);
			val.AddLine(bounds.Right, bounds.Bottom, bounds.Right - 2, bounds.Bottom);
		}
		if (int_2 > 0)
		{
			Struct10 @struct = ElementStyleDisplay.smethod_10(rectangle, int_2, Enum14.const_2);
			val.AddArc(@struct.int_0, @struct.int_1, @struct.int_2, @struct.int_3, @struct.float_0, @struct.float_1);
		}
		else
		{
			val.AddLine(bounds.X + 2, bounds.Bottom, bounds.X, bounds.Bottom);
			val.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Bottom - 2);
		}
		val.CloseAllFigures();
		return val;
	}

	protected virtual bool WindowsMessageNCPaint(ref Message m)
	{
		if (Boolean_1)
		{
			return true;
		}
		((Message)(ref m)).set_Result(IntPtr.Zero);
		return false;
	}

	protected virtual bool WindowsMessageNCCalcSize(ref Message m)
	{
		if (((Message)(ref m)).get_WParam() == IntPtr.Zero)
		{
			Class51.RECT rECT = Class51.RECT.FromRectangle(GetClientRectangle(((Class51.RECT)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.RECT))).ToRectangle()));
			Marshal.StructureToPtr((object)rECT, ((Message)(ref m)).get_LParam(), fDeleteOld: false);
			((Message)(ref m)).set_Result(IntPtr.Zero);
		}
		else
		{
			Class51.NCCALCSIZE_PARAMS nCCALCSIZE_PARAMS = (Class51.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(Class51.NCCALCSIZE_PARAMS));
			Class51.WINDOWPOS wINDOWPOS = (Class51.WINDOWPOS)Marshal.PtrToStructure(nCCALCSIZE_PARAMS.lppos, typeof(Class51.WINDOWPOS));
			nCCALCSIZE_PARAMS.rgrc1 = (nCCALCSIZE_PARAMS.rgrc0 = Class51.RECT.FromRectangle(GetClientRectangle(new Rectangle(wINDOWPOS.x, wINDOWPOS.y, wINDOWPOS.cx, wINDOWPOS.cy))));
			Marshal.StructureToPtr((object)nCCALCSIZE_PARAMS, ((Message)(ref m)).get_LParam(), fDeleteOld: false);
			((Message)(ref m)).set_Result(new IntPtr(1024));
		}
		return false;
	}

	protected virtual Rectangle GetClientRectangle(Rectangle r)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Invalid comparison between Unknown and I4
		if ((int)WindowState == 2 && !Boolean_1)
		{
			Class51.RECT lpRect = new Class51.RECT(0, 0, 100, 100);
			CreateParams createParams = ((Control)this).get_CreateParams();
			Class51.AdjustWindowRectEx(ref lpRect, createParams.get_Style(), bMenu: false, createParams.get_ExStyle());
			Rectangle rectangle = lpRect.ToRectangle();
			int num = Math.Abs(rectangle.X);
			_ = rectangle.Bottom;
			int num2 = m_DisplayRectangleReductionHorizontal + 1 - 3;
			point_0.X = num - num2;
			point_0.Y = num - 3 - 1;
			r.X += point_0.X;
			r.Width -= num * 2 - num2 * 2 - 1;
			r.Height -= num * 2 - 6 - 1;
			r.Y += point_0.Y;
			Screen val = Screen.FromHandle(((Control)this).get_Handle());
			if (r.Height > val.get_Bounds().Height && val.get_Primary())
			{
				r.Height = val.get_Bounds().Height;
			}
		}
		else
		{
			point_0 = Point.Empty;
			if (Boolean_1)
			{
				int num3 = SystemInformation.get_FrameBorderSize().Width * Class92.Int32_0;
				int num4 = SystemInformation.get_FrameBorderSize().Height * Class92.Int32_0;
				r.X += num3;
				r.Width -= num3 * 2;
				r.Height -= num4;
				if ((int)WindowState == 2 || Class51.IsZoomed(((Control)this).get_Handle()))
				{
					Screen val2 = Screen.FromHandle(((Control)this).get_Handle());
					if (r.Height > val2.get_Bounds().Height && val2.get_Primary())
					{
						r.Height = val2.get_Bounds().Height + num4 - 2;
					}
				}
			}
		}
		return r;
	}

	protected virtual bool WindowsMessageNCActivate(ref Message m)
	{
		if (((Message)(ref m)).get_WParam() != IntPtr.Zero)
		{
			bool_3 = true;
		}
		else
		{
			bool_3 = false;
		}
		method_8();
		IntPtr lParam = ((Message)(ref m)).get_LParam();
		((Message)(ref m)).set_LParam(new IntPtr(-1));
		((Form)this).WndProc(ref m);
		((Message)(ref m)).set_LParam(lParam);
		method_9();
		return false;
	}

	private void method_8()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Invalid comparison between Unknown and I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		if (ribbonControl_0 == null || (int)WindowState == 1 || !((Control)this).get_IsHandleCreated() || !((Control)ribbonControl_0).get_IsHandleCreated() || ribbonControl_0.RibbonStrip == null || ((Control)ribbonControl_0.RibbonStrip).get_Width() <= 0 || ((Control)ribbonControl_0.RibbonStrip).get_Height() <= 0 || !((Control)ribbonControl_0).get_Visible())
		{
			return;
		}
		if (bufferedBitmap_0 != null)
		{
			bufferedBitmap_0.Dispose();
			bufferedBitmap_0 = null;
		}
		if (rectangle_0 != null)
		{
			rectangle_0 = null;
		}
		Rectangle bounds = ((Control)ribbonControl_0.RibbonStrip).get_Bounds();
		bounds.Location = ((Control)ribbonControl_0).PointToScreen(bounds.Location);
		bounds.Location = ((Control)this).PointToClient(bounds.Location);
		if (Boolean_1)
		{
			bounds.X += SystemInformation.get_FrameBorderSize().Width * Class92.Int32_0;
		}
		point_1 = bounds.Location;
		if ((int)WindowState == 2)
		{
			point_1.Offset(point_0.X, point_0.Y);
		}
		Size size = new Size(((Control)ribbonControl_0.RibbonStrip).get_Width(), Math.Min(((Control)ribbonControl_0.RibbonStrip).get_Height(), ((Control)ribbonControl_0).get_Height()));
		IntPtr windowDC = Class51.GetWindowDC(((Control)this).get_Handle());
		bufferedBitmap_0 = new BufferedBitmap(windowDC, new Rectangle(point_1, size));
		Class51.ReleaseDC(((Control)this).get_Handle(), windowDC);
		ribbonControl_0.RibbonStrip.method_18(new PaintEventArgs(bufferedBitmap_0.Graphics, Rectangle.Empty));
		ArrayList arrayList = new ArrayList(10);
		foreach (Control item in (ArrangedElementCollection)((Control)ribbonControl_0.RibbonStrip).get_Controls())
		{
			Control val = item;
			if (val.get_Visible())
			{
				Rectangle bounds2 = val.get_Bounds();
				bounds2.Location = ((Control)ribbonControl_0.RibbonStrip).PointToScreen(bounds2.Location);
				bounds2.Location = ((Control)this).PointToClient(bounds2.Location);
				arrayList.Add(bounds2);
			}
		}
		rectangle_0 = new Rectangle[arrayList.Count];
		arrayList.CopyTo(rectangle_0);
	}

	private void method_9()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		if (bufferedBitmap_0 == null)
		{
			return;
		}
		try
		{
			IntPtr windowDC = Class51.GetWindowDC(((Control)this).get_Handle());
			try
			{
				Graphics val = Graphics.FromHdc(windowDC);
				try
				{
					bufferedBitmap_0.Render(val, rectangle_0);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			finally
			{
				Class51.ReleaseDC(((Control)this).get_Handle(), windowDC);
			}
		}
		finally
		{
			bufferedBitmap_0.Dispose();
			bufferedBitmap_0 = null;
			rectangle_0 = null;
		}
		if (Environment.OSVersion.Version.Major >= 6)
		{
			RedrawBorder();
		}
		else
		{
			if (ribbonControl_0 == null)
			{
				return;
			}
			foreach (Control item in (ArrangedElementCollection)((Control)ribbonControl_0.RibbonStrip).get_Controls())
			{
				Control val2 = item;
				if (val2.get_Visible())
				{
					val2.Refresh();
				}
			}
		}
	}

	protected virtual void Redraw()
	{
		Class51.RedrawWindow(((Control)this).get_Handle(), IntPtr.Zero, IntPtr.Zero, (Class51.RedrawWindowFlags)387u);
	}

	protected virtual void RedrawBorder()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Region val = new Region();
		Size size = new Size(SystemInformation.get_Border3DSize().Width * Class92.Int32_0, SystemInformation.get_Border3DSize().Height * Class92.Int32_0);
		val.Union(new Rectangle(0, 0, ((Control)this).get_Width(), size.Height));
		val.Union(new Rectangle(((Control)this).get_Height() - size.Height, 0, ((Control)this).get_Width(), size.Height));
		val.Union(new Rectangle(0, 0, size.Width, ((Control)this).get_Height()));
		val.Union(new Rectangle(((Control)this).get_Width() - size.Width, 0, size.Width, ((Control)this).get_Height()));
		((Control)this).Invalidate(val, true);
		val.Dispose();
		((Control)this).Update();
	}

	protected virtual bool WindowsMessageNCHitTest(ref Message m)
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Invalid comparison between Unknown and I4
		int x = Class51.smethod_4(((Message)(ref m)).get_LParam());
		int y = Class51.smethod_5(((Message)(ref m)).get_LParam());
		Point pt = ((Control)this).PointToClient(new Point(x, y));
		int num = 5;
		int num2 = 1;
		if (Boolean_1)
		{
			num = SystemInformation.get_FrameBorderSize().Width * Class92.Int32_0;
			IntPtr plResult = IntPtr.Zero;
			Class51.DwmDefWindowProc(((Control)this).get_Handle(), ((Message)(ref m)).get_Msg(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam(), out plResult);
			int num3 = plResult.ToInt32();
			if (num3 == 8 || num3 == 9 || num3 == 20 || num3 == 9 || num3 == 21)
			{
				((Message)(ref m)).set_Result(plResult);
				bool_5 = true;
				return false;
			}
			pt.X += SystemInformation.get_FrameBorderSize().Width * Class92.Int32_0;
		}
		Rectangle empty = Rectangle.Empty;
		if (IsSizable)
		{
			if (new Rectangle(int_0, 0, ((Control)this).get_Width() - (int_2 + int_3), num).Contains(pt))
			{
				((Message)(ref m)).set_Result(new IntPtr(12));
				return false;
			}
			if (new Rectangle(int_2, ((Control)this).get_Height() - num, ((Control)this).get_Width() - (int_2 + int_3), num).Contains(pt))
			{
				((Message)(ref m)).set_Result(new IntPtr(15));
				return false;
			}
			if (((Form)this).get_RightToLeftLayout() && (int)((Control)this).get_RightToLeft() == 1)
			{
				if (new Rectangle(((Control)this).get_Width() - int_1, 0, int_1 + num2, int_1 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(13));
					return false;
				}
				if (new Rectangle(0, 0, int_0 + num2, int_0 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(14));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - int_3, ((Control)this).get_Height() - int_3, int_3 + num2, int_3 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(16));
					return false;
				}
				if (new Rectangle(0, ((Control)this).get_Height() - int_2, int_2 + num2, int_2 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(17));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - num, 0, num, ((Control)this).get_Height()).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(10));
					return false;
				}
				if (new Rectangle(0, 0, num, ((Control)this).get_Height()).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(11));
					return false;
				}
			}
			else
			{
				if (new Rectangle(0, 0, int_0 + num2, int_0 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(13));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - int_1, 0, int_1 + num2, int_1 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(14));
					return false;
				}
				if (new Rectangle(0, ((Control)this).get_Height() - int_2, int_2 + num2, int_2 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(16));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - int_3, ((Control)this).get_Height() - int_3, int_3 + num2, int_3 + num2).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(17));
					return false;
				}
				if (new Rectangle(0, 0, num, ((Control)this).get_Height()).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(10));
					return false;
				}
				if (new Rectangle(((Control)this).get_Width() - num, 0, num, ((Control)this).get_Height()).Contains(pt))
				{
					((Message)(ref m)).set_Result(new IntPtr(11));
					return false;
				}
			}
		}
		return true;
	}

	protected virtual bool WindowsMessageSetText(ref Message m)
	{
		bool flag = Class51.smethod_1(((Message)(ref m)).get_HWnd(), 268435456, 0);
		((Form)this).DefWndProc(ref m);
		if (ribbonControl_0 != null && ribbonControl_0.RibbonStrip != null)
		{
			((Control)ribbonControl_0.RibbonStrip).Refresh();
		}
		if (flag)
		{
			Class51.smethod_1(((Message)(ref m)).get_HWnd(), 0, 268435456);
		}
		return false;
	}

	protected virtual bool WindowsMessageInitMenuPopup(ref Message m)
	{
		((Form)this).WndProc(ref m);
		((Control)this).Invalidate(true);
		return false;
	}

	protected virtual bool WindowsMessageWindowsPosChanged(ref Message m)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if ((int)WindowState != 1 && (int)WindowState != 2)
		{
			return true;
		}
		bool_8 = true;
		((Form)this).WndProc(ref m);
		bool_8 = true;
		return false;
	}

	protected virtual bool WindowsMessageNCMouseMove(ref Message m)
	{
		return true;
	}

	protected virtual bool WindowsMessageNCMouseLeave(ref Message m)
	{
		if (bool_5)
		{
			IntPtr plResult = IntPtr.Zero;
			Class51.DwmDefWindowProc(((Control)this).get_Handle(), 132, IntPtr.Zero, IntPtr.Zero, out plResult);
			plResult.ToInt32();
			bool_5 = false;
		}
		return true;
	}

	protected virtual bool WindowsMessageNCLButtonDown(ref Message m)
	{
		return true;
	}

	protected virtual bool WindowsMessageNCLButtonUp(ref Message m)
	{
		return true;
	}

	protected virtual bool WindowsMessageNCDblClk(ref Message m)
	{
		return true;
	}

	protected virtual bool WindowsMessageMouseActivate(ref Message m)
	{
		((Form)this).Activate();
		return true;
	}

	protected virtual bool WindowsMessageMdiSetMenu(ref Message m)
	{
		return false;
	}

	protected virtual bool WindowsMessageMdiRefreshMenu(ref Message m)
	{
		return false;
	}

	private bool method_10(ref Message message_0)
	{
		if (Boolean_1 && ribbonControl_0 != null)
		{
			IntPtr menu = Class51.GetMenu(((Control)this).get_Handle());
			if (menu != IntPtr.Zero)
			{
				Class51.SetMenu(((Control)this).get_Handle(), IntPtr.Zero);
			}
		}
		return true;
	}

	protected virtual bool WindowsMessageSetIcon(ref Message m)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)WindowState == 2)
		{
			bool flag = Class51.smethod_1(((Message)(ref m)).get_HWnd(), 12582912, 0);
			method_8();
			((Form)this).WndProc(ref m);
			if (flag)
			{
				Class51.smethod_1(((Message)(ref m)).get_HWnd(), 0, 12582912);
			}
			method_9();
			return false;
		}
		return true;
	}

	protected virtual bool WindowsMessageDwmCompositionChanged(ref Message m)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		bool_4 = method_11();
		bool flag = false;
		if (((Form)this).get_IsMdiContainer() && ((Form)this).get_ActiveMdiChild() != null && (int)((Form)this).get_ActiveMdiChild().get_WindowState() == 2)
		{
			((Form)this).get_ActiveMdiChild().set_WindowState((FormWindowState)0);
			flag = true;
		}
		string text = ((Control)this).get_Text();
		((Control)this).RecreateHandle();
		if (Boolean_1)
		{
			((Control)this).set_Region((Region)null);
			if (ribbonControl_0 != null)
			{
				((Control)ribbonControl_0).set_Region((Region)null);
			}
			method_2();
		}
		if (flag && ((Form)this).get_IsMdiContainer() && ((Form)this).get_ActiveMdiChild() != null)
		{
			((Form)this).get_ActiveMdiChild().set_WindowState((FormWindowState)2);
		}
		((Control)this).set_Text(text);
		return true;
	}

	private bool method_11()
	{
		if (((Component)this).DesignMode)
		{
			return false;
		}
		return Class51.Boolean_0;
	}

	protected virtual bool WindowsMessageStyleChanged(ref Message m)
	{
		if (!bool_7)
		{
			method_8();
			((Form)this).WndProc(ref m);
			method_9();
			return false;
		}
		return true;
	}

	protected virtual bool WindowsMessageSetCursor(ref Message m)
	{
		if ((bool_3 || (Class51.smethod_5(((Message)(ref m)).get_LParam()) != 514 && Class51.smethod_5(((Message)(ref m)).get_LParam()) != 513) || Class51.smethod_4(((Message)(ref m)).get_LParam()) != -2) && !Boolean_1 && ((Control)this).get_Enabled() && !BarUtilities.Boolean_0)
		{
			bool_7 = true;
			IntPtr intPtr = Class51.smethod_0(((Control)this).get_Handle(), -16);
			int num = intPtr.ToInt32();
			num &= ~(num & 0x10000000);
			Class51.SetWindowLong(((Control)this).get_Handle(), -16, num);
			((Form)this).WndProc(ref m);
			Class51.SetWindowLong(((Control)this).get_Handle(), -16, intPtr.ToInt32());
			bool_7 = false;
			return false;
		}
		return true;
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		if (IsCustomFormStyleEnabled() && (bool_8 || (((Component)this).DesignMode && ((specified & 8) == 8 || (specified & 4) == 4))))
		{
			if (width != ((Control)this).get_Width() || height != ((Control)this).get_Height())
			{
				AdjustBounds(ref width, ref height, specified);
			}
			bool_8 = false;
		}
		((Form)this).SetBoundsCore(x, y, width, height, specified);
	}

	protected virtual void AdjustBounds(ref int width, ref int height)
	{
		AdjustBounds(ref width, ref height, (BoundsSpecified)12);
	}

	protected virtual void AdjustBounds(ref int width, ref int height, BoundsSpecified specified)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		Class51.RECT lpRect = new Class51.RECT(0, 0, width, height);
		CreateParams createParams = ((Control)this).get_CreateParams();
		Class51.AdjustWindowRectEx(ref lpRect, createParams.get_Style(), bMenu: false, createParams.get_ExStyle());
		if ((specified & 8) == 8)
		{
			height -= lpRect.Height - height;
			if (Boolean_1)
			{
				height += SystemInformation.get_FrameBorderSize().Height * Class92.Int32_0;
			}
		}
		if ((specified & 4) == 4 && !Boolean_1)
		{
			width -= lpRect.Width - width;
		}
	}

	protected override void SetClientSizeCore(int x, int y)
	{
		if (!((Component)this).DesignMode && IsCustomFormStyleEnabled())
		{
			bool_8 = true;
			AdjustBounds(ref x, ref y);
		}
		((Form)this).SetClientSizeCore(x, y);
	}

	private Type method_12()
	{
		Type baseType = ((object)this).GetType().BaseType;
		while ((object)baseType != null && baseType.Name != "Control")
		{
			baseType = baseType.BaseType;
		}
		return baseType;
	}

	protected virtual void BaseWndProc(ref Message m)
	{
		((Form)this).WndProc(ref m);
	}

	protected override void WndProc(ref Message m)
	{
		if (!IsCustomFormStyleEnabled())
		{
			((Form)this).WndProc(ref m);
			return;
		}
		bool flag = true;
		switch (((Message)(ref m)).get_Msg())
		{
		case 32:
			flag = WindowsMessageSetCursor(ref m);
			break;
		case 33:
			flag = WindowsMessageMouseActivate(ref m);
			break;
		case 20:
			flag = false;
			((Message)(ref m)).set_Result(new IntPtr(1));
			break;
		case 12:
			flag = WindowsMessageSetText(ref m);
			break;
		case 125:
			flag = WindowsMessageStyleChanged(ref m);
			break;
		case 128:
			flag = WindowsMessageSetIcon(ref m);
			break;
		case 131:
			((Form)this).WndProc(ref m);
			WindowsMessageNCCalcSize(ref m);
			flag = false;
			break;
		case 132:
			flag = WindowsMessageNCHitTest(ref m);
			break;
		case 133:
			flag = WindowsMessageNCPaint(ref m);
			break;
		case 134:
			flag = WindowsMessageNCActivate(ref m);
			break;
		case 71:
			flag = WindowsMessageWindowsPosChanged(ref m);
			break;
		case 160:
			flag = WindowsMessageNCMouseMove(ref m);
			break;
		case 161:
			flag = WindowsMessageNCLButtonDown(ref m);
			break;
		case 162:
			flag = WindowsMessageNCLButtonUp(ref m);
			break;
		case 163:
			flag = WindowsMessageNCDblClk(ref m);
			break;
		case 546:
			flag = method_10(ref m);
			break;
		case 279:
			flag = WindowsMessageInitMenuPopup(ref m);
			break;
		case 146:
		case 174:
			flag = false;
			break;
		case 564:
			flag = WindowsMessageMdiRefreshMenu(ref m);
			break;
		case 560:
			flag = WindowsMessageMdiSetMenu(ref m);
			break;
		case 798:
			flag = WindowsMessageDwmCompositionChanged(ref m);
			break;
		case 674:
			flag = WindowsMessageNCMouseLeave(ref m);
			break;
		}
		if (flag)
		{
			((Form)this).WndProc(ref m);
		}
	}
}

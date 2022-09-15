using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[Designer(typeof(RibbonPanelDesigner))]
[ToolboxItem(false)]
public class RibbonPanel : PanelControl, IKeyTipsControl
{
	private class Class238 : IComparer
	{
		int IComparer.Compare(object x, object y)
		{
			if (x is RibbonBar && y is RibbonBar)
			{
				return ((RibbonBar)x).ResizeOrderIndex - ((RibbonBar)y).ResizeOrderIndex;
			}
			return new CaseInsensitiveComparer().Compare(x, y);
		}
	}

	private class Class239 : IComparer
	{
		int IComparer.Compare(object x, object y)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			if (x is Control && y is Control)
			{
				return ((Control)x).get_Left() - ((Control)y).get_Left();
			}
			return new CaseInsensitiveComparer().Compare(x, y);
		}
	}

	private const string string_1 = "Drop RibbonBar or other controls here. Drag and Drop tabs and items to re-order.";

	private RibbonTabItem ribbonTabItem_0;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private ElementStyle elementStyle_3 = new ElementStyle();

	private RightToLeft rightToLeft_0;

	private bool bool_12;

	private ButtonX buttonX_0;

	private ButtonX buttonX_1;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private int int_1;

	private bool bool_13;

	private RibbonControl ribbonControl_0;

	private bool bool_14;

	private string string_2 = "";

	internal bool Boolean_0 => bool_13;

	internal bool Boolean_1
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
		}
	}

	[Browsable(true)]
	[Category("Layout")]
	[DefaultValue(false)]
	[Description("Indicates whether default control layout is used instead of Rendering layout for RibbonBar controls positioning.")]
	public bool DefaultLayout
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
			((Control)this).PerformLayout();
		}
	}

	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates whether style of the panel is managed by tab control automatically. Set this to true if you would like to control style of the panel.")]
	public bool UseCustomStyle
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DefaultValue(null)]
	public RibbonTabItem RibbonTabItem
	{
		get
		{
			return ribbonTabItem_0;
		}
		set
		{
			ribbonTabItem_0 = value;
		}
	}

	[Category("Layout")]
	[Description("Whether last RibbonBar is stretched to fill available space inside of the panel.")]
	[DefaultValue(false)]
	[Browsable(true)]
	public bool StretchLastRibbonBar
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
			((Control)this).PerformLayout();
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(false)]
	public override DockStyle Dock
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Dock();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Dock(value);
		}
	}

	[Browsable(false)]
	public Size Size
	{
		get
		{
			return ((Control)this).get_Size();
		}
		set
		{
			((Control)this).set_Size(value);
		}
	}

	[Browsable(false)]
	public Point Location
	{
		get
		{
			return ((Control)this).get_Location();
		}
		set
		{
			((Control)this).set_Location(value);
		}
	}

	[Browsable(false)]
	public bool Visible
	{
		get
		{
			return ((Control)this).get_Visible();
		}
		set
		{
			((Control)this).set_Visible(value);
		}
	}

	[Browsable(false)]
	public override AnchorStyles Anchor
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Anchor();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Anchor(value);
		}
	}

	[Browsable(false)]
	[DefaultValue("")]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
		}
	}

	bool IKeyTipsControl.ShowKeyTips
	{
		get
		{
			return bool_14;
		}
		set
		{
			bool_14 = value;
			Control[] array = (Control[])(object)new Control[((ArrangedElementCollection)((Control)this).get_Controls()).get_Count()];
			((ArrangedElementCollection)((Control)this).get_Controls()).CopyTo((Array)array, 0);
			Control[] array2 = array;
			foreach (Control val in array2)
			{
				if (val is IKeyTipsControl && val.get_Enabled() && (val.get_Visible() || !bool_14))
				{
					((IKeyTipsControl)val).ShowKeyTips = bool_14;
				}
			}
		}
	}

	string IKeyTipsControl.KeyTipsKeysStack
	{
		get
		{
			return string_2;
		}
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			string_2 = value;
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val = item;
				if (val is IKeyTipsControl && val.get_Visible() && val.get_Enabled())
				{
					((IKeyTipsControl)val).KeyTipsKeysStack = string_2;
				}
			}
		}
	}

	public RibbonPanel()
	{
		((Control)this).set_BackColor(SystemColors.Control);
	}

	protected override ElementStyle GetStyle()
	{
		if (!Style.Custom)
		{
			return method_6();
		}
		return base.GetStyle();
	}

	internal RibbonControl method_4()
	{
		if (bool_13)
		{
			return ribbonControl_0;
		}
		return ((Control)this).get_Parent() as RibbonControl;
	}

	internal void method_5(bool bool_15, RibbonControl ribbonControl_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		bool_13 = bool_15;
		if (bool_13)
		{
			ribbonControl_0 = ribbonControl_1;
			Padding padding = ((Control)this).get_Padding();
			if (((Padding)(ref padding)).get_Bottom() > 0)
			{
				int height = ((Control)this).get_Height();
				Padding padding2 = ((Control)this).get_Padding();
				((Control)this).set_Height(height + ((Padding)(ref padding2)).get_Bottom());
				Padding padding3 = ((Control)this).get_Padding();
				int left = ((Padding)(ref padding3)).get_Left();
				Padding padding4 = ((Control)this).get_Padding();
				int bottom = ((Padding)(ref padding4)).get_Bottom();
				Padding padding5 = ((Control)this).get_Padding();
				int right = ((Padding)(ref padding5)).get_Right();
				Padding padding6 = ((Control)this).get_Padding();
				((Control)this).set_Padding(new Padding(left, bottom, right, ((Padding)(ref padding6)).get_Bottom()));
			}
		}
		else
		{
			Padding padding7 = ((Control)this).get_Padding();
			if (((Padding)(ref padding7)).get_Top() > 0)
			{
				int height2 = ((Control)this).get_Height();
				Padding padding8 = ((Control)this).get_Padding();
				((Control)this).set_Height(height2 - ((Padding)(ref padding8)).get_Top());
				Padding padding9 = ((Control)this).get_Padding();
				int left2 = ((Padding)(ref padding9)).get_Left();
				Padding padding10 = ((Control)this).get_Padding();
				int right2 = ((Padding)(ref padding10)).get_Right();
				Padding padding11 = ((Control)this).get_Padding();
				((Control)this).set_Padding(new Padding(left2, 0, right2, ((Padding)(ref padding11)).get_Bottom()));
			}
			ribbonControl_0 = null;
		}
	}

	private ElementStyle method_6()
	{
		RibbonControl ribbonControl = method_4();
		if (ribbonControl != null && base.ColorSchemeStyle != ribbonControl.Style)
		{
			base.ColorSchemeStyle = ribbonControl.Style;
		}
		elementStyle_3.method_4(base.ColorScheme);
		if (base.ColorSchemeStyle != eDotNetBarStyle.Office2007 && (ribbonControl == null || ribbonControl.Style != eDotNetBarStyle.Office2007))
		{
			ApplyLabelStyle(elementStyle_3);
			elementStyle_3.BorderBottom = eStyleBorderType.Solid;
		}
		else
		{
			elementStyle_3.Reset();
			Office2007ColorTable office2007ColorTable = null;
			if (ribbonControl != null)
			{
				office2007ColorTable = ribbonControl.method_6();
			}
			else
			{
				if (!(GlobalManager.Renderer is Office2007Renderer))
				{
					return Style;
				}
				office2007ColorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			}
			elementStyle_3.Border = eStyleBorderType.Double;
			if (ribbonControl == null || !ribbonControl.IsPopupMode)
			{
				elementStyle_3.BorderTop = eStyleBorderType.None;
			}
			elementStyle_3.BorderWidth = 1;
			elementStyle_3.CornerDiameter = office2007ColorTable.RibbonControl.CornerSize;
			elementStyle_3.CornerType = eCornerType.Rounded;
			if (!bool_13)
			{
				elementStyle_3.CornerTypeTopLeft = eCornerType.Square;
				elementStyle_3.CornerTypeTopRight = eCornerType.Square;
			}
			else if (office2007ColorTable.InitialColorScheme == eOffice2007ColorScheme.Black)
			{
				elementStyle_3.BorderTop = eStyleBorderType.None;
			}
			elementStyle_3.BorderColor = office2007ColorTable.RibbonControl.OuterBorder.Start;
			elementStyle_3.BorderColor2 = office2007ColorTable.RibbonControl.OuterBorder.End;
			elementStyle_3.BorderColorLight = office2007ColorTable.RibbonControl.InnerBorder.Start;
			elementStyle_3.BorderColorLight2 = office2007ColorTable.RibbonControl.InnerBorder.End;
			elementStyle_3.BackColorGradientAngle = 90;
			elementStyle_3.BackColor = office2007ColorTable.RibbonBar.Default.TopBackground.Start;
			elementStyle_3.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable.RibbonControl.PanelTopBackground.Start, 0f));
			elementStyle_3.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable.RibbonControl.PanelTopBackground.End, office2007ColorTable.RibbonControl.PanelTopBackgroundHeight));
			elementStyle_3.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable.RibbonControl.PanelBottomBackground.Start, office2007ColorTable.RibbonControl.PanelTopBackgroundHeight));
			elementStyle_3.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable.RibbonControl.PanelBottomBackground.End, 1f));
		}
		return elementStyle_3;
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		if (!(e.get_Control() is RibbonBar))
		{
			bool_10 = false;
		}
		base.OnControlAdded(e);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected override void OnLayout(LayoutEventArgs levent)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		if (!bool_10 && !((Component)(object)this).DesignMode)
		{
			if (((Control)this).get_ClientRectangle().Width == 0 || ((Control)this).get_ClientRectangle().Height == 0 || !((Control)this).get_IsHandleCreated())
			{
				return;
			}
			Form val = ((Control)this).FindForm();
			if (val != null && (int)val.get_WindowState() == 1)
			{
				return;
			}
			if (rightToLeft_0 != ((Control)this).get_RightToLeft())
			{
				rightToLeft_0 = ((Control)this).get_RightToLeft();
				Rectangle rectangle = method_7();
				foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
				{
					Control val2 = item;
					if (val2 is RibbonBar)
					{
						val2.set_Left(rectangle.Width - val2.get_Width() - val2.get_Left());
					}
				}
			}
			if (!bool_12)
			{
				method_8();
			}
		}
		else
		{
			((ScrollableControl)this).OnLayout(levent);
		}
	}

	private Rectangle method_7()
	{
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.X += ((ScrollableControl)this).get_DockPadding().get_Left();
		clientRectangle.Width -= ((ScrollableControl)this).get_DockPadding().get_Left() + ((ScrollableControl)this).get_DockPadding().get_Right();
		clientRectangle.Y += ((ScrollableControl)this).get_DockPadding().get_Top();
		clientRectangle.Height -= ((ScrollableControl)this).get_DockPadding().get_Top() + ((ScrollableControl)this).get_DockPadding().get_Bottom();
		return clientRectangle;
	}

	internal void method_8()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		int num = 2;
		Rectangle rectangle_ = method_7();
		int num2 = -2;
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		ArrayList arrayList3 = new ArrayList();
		Control val = null;
		int num3 = 0;
		bool flag = false;
		RibbonBar ribbonBar = null;
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val2 = item;
			if (val2 is RibbonBar ribbonBar2 && ((Control)ribbonBar2).get_Visible())
			{
				int width = ribbonBar2.method_45().Width;
				num2 += width + num;
				if (ribbonBar2.GalleryContainer_0 != null && ribbonBar2.GalleryContainer_0.Visible)
				{
					ribbonBar = ribbonBar2;
				}
				if (ribbonBar2.ResizeOrderIndex != 0)
				{
					flag = true;
				}
				arrayList.Add(ribbonBar2);
				arrayList2.Add(ribbonBar2);
				if (ribbonBar2.OverflowState)
				{
					arrayList3.Add(ribbonBar2);
				}
				if (((Control)ribbonBar2).get_Left() > num3)
				{
					num3 = ((Control)ribbonBar2).get_Left();
					val = val2;
				}
			}
		}
		arrayList2.Sort(new Class239());
		if (flag)
		{
			arrayList.Sort(new Class238());
			arrayList3.Sort(new Class238());
		}
		else
		{
			arrayList.Sort(new Class239());
			arrayList3.Sort(new Class239());
		}
		int int_ = 0;
		if (num2 > rectangle_.Width)
		{
			int num4 = num2 - rectangle_.Width;
			if (ribbonBar != null && !ribbonBar.GalleryContainer_0.Boolean_5)
			{
				int width2 = ribbonBar.method_45().Width;
				if (ribbonBar.GalleryContainer_0.WidthInternal - ribbonBar.GalleryContainer_0.MinimumSize.Width >= num4)
				{
					((Control)ribbonBar).set_Size(new Size(width2 - num4, rectangle_.Height));
				}
				else
				{
					((Control)ribbonBar).set_Size(new Size(width2 - (ribbonBar.GalleryContainer_0.WidthInternal - ribbonBar.GalleryContainer_0.MinimumSize.Width), rectangle_.Height));
				}
				num4 -= width2 - ribbonBar.method_45().Width;
			}
			if (num4 > 0)
			{
				int num5 = arrayList.Count - 1;
				for (int num6 = num5; num6 >= 0; num6--)
				{
					RibbonBar ribbonBar3 = arrayList[num6] as RibbonBar;
					int width3 = ribbonBar3.method_45().Width;
					if (width3 > num4 && ribbonBar3.AutoSizeItems)
					{
						((Control)ribbonBar3).set_Size(new Size(width3 - num4, rectangle_.Height));
					}
					else
					{
						((Control)ribbonBar3).set_Size(new Size(1, rectangle_.Height));
					}
					num4 -= width3 - ribbonBar3.method_45().Width;
					if (num4 <= 0)
					{
						break;
					}
				}
			}
			if (num4 != 0)
			{
				int_ = Math.Abs(num4);
			}
		}
		else if (num2 < rectangle_.Width)
		{
			int num7 = rectangle_.Width - num2;
			foreach (RibbonBar item2 in arrayList3)
			{
				int width4 = item2.method_45().Width;
				((Control)item2).set_Size(new Size(width4 + num7, rectangle_.Height));
				num7 -= item2.method_45().Width - width4;
				if (num7 <= 0 || item2.method_45().Width - width4 == 0)
				{
					break;
				}
			}
			if (num7 > 0 && arrayList3.Count == 0)
			{
				int num8 = arrayList.Count - 1;
				for (int num9 = num8; num9 >= 0; num9--)
				{
					RibbonBar ribbonBar5 = arrayList[num9] as RibbonBar;
					if (!ribbonBar5.OverflowState)
					{
						int width5 = ribbonBar5.method_45().Width;
						if (width5 != ((Control)ribbonBar5).get_Width() || !ribbonBar5.Size_1.IsEmpty || !ribbonBar5.Size_0.IsEmpty || ribbonBar5.GalleryContainer_0 != null)
						{
							if (((Control)ribbonBar5).get_Width() == width5 + num7)
							{
								if (ribbonBar5 != val || !bool_11)
								{
									num7 = 0;
								}
								break;
							}
							((Control)ribbonBar5).set_Size(new Size(width5 + num7, rectangle_.Height));
							num7 -= ribbonBar5.method_45().Width - width5;
							if (num7 <= 0)
							{
								break;
							}
						}
					}
				}
			}
			if (num7 > 0)
			{
				int_ = num7;
			}
		}
		method_9(arrayList2, rectangle_, num, val, int_);
	}

	private void method_9(ArrayList arrayList_0, Rectangle rectangle_2, int int_2, Control control_0, int int_3)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Point location = rectangle_2.Location;
		int num = 0;
		if ((int)((Control)this).get_RightToLeft() == 1)
		{
			int num2 = 0;
			foreach (RibbonBar item in arrayList_0)
			{
				num2 += ((Control)item).get_Width() + int_2;
			}
			if (num2 < rectangle_2.Width)
			{
				num = int_2 + rectangle_2.Width - num2;
			}
		}
		Rectangle b = Rectangle.Empty;
		location.X += int_1;
		foreach (RibbonBar item2 in arrayList_0)
		{
			Size size = item2.method_45();
			if (item2 == control_0 && bool_11 && !item2.OverflowState)
			{
				size.Width += int_3;
			}
			Rectangle rectangle = new Rectangle(location.X + num, location.Y, size.Width, rectangle_2.Height);
			if (((Component)(object)this).DesignMode)
			{
				TypeDescriptor.GetProperties(item2)["Bounds"]!.SetValue(item2, rectangle);
			}
			else
			{
				((Control)item2).set_Bounds(rectangle);
			}
			b = Rectangle.Union(rectangle, b);
			location.X += ((Control)item2).get_Width() + int_2;
		}
		rectangle_1 = b;
		if (rectangle_1.Right > ((Control)this).get_Width())
		{
			if (buttonX_0 == null)
			{
				buttonX_0 = new ButtonX();
				((Control)buttonX_0).set_Text("<expand direction=\"right\"/>");
				buttonX_0.ColorTable = eButtonColor.OrangeWithBackground;
				((Control)buttonX_0).add_Click((EventHandler)buttonX_0_Click);
			}
			((Control)buttonX_0).set_Bounds(new Rectangle(((Control)this).get_Width() - 12, 0, 12, ((Control)this).get_Height() - 2));
			((Control)this).get_Controls().Add((Control)(object)buttonX_0);
			((Control)buttonX_0).BringToFront();
		}
		else if (buttonX_0 != null)
		{
			((Control)buttonX_0).set_Visible(false);
			((Control)this).get_Controls().Remove((Control)(object)buttonX_0);
			((Component)(object)buttonX_0).Dispose();
			buttonX_0 = null;
		}
		if (int_1 < 0)
		{
			if (buttonX_1 == null)
			{
				buttonX_1 = new ButtonX();
				((Control)buttonX_1).set_Text("<expand direction=\"left\"/>");
				buttonX_1.ColorTable = eButtonColor.OrangeWithBackground;
				((Control)buttonX_1).add_Click((EventHandler)buttonX_1_Click);
			}
			((Control)buttonX_1).set_Bounds(new Rectangle(0, 0, 12, ((Control)this).get_Height() - 2));
			((Control)this).get_Controls().Add((Control)(object)buttonX_1);
			((Control)buttonX_1).BringToFront();
		}
		else if (buttonX_1 != null)
		{
			((Control)buttonX_1).set_Visible(false);
			((Control)this).get_Controls().Remove((Control)(object)buttonX_1);
			((Component)(object)buttonX_1).Dispose();
			buttonX_1 = null;
		}
	}

	private void buttonX_0_Click(object sender, EventArgs e)
	{
		ScrollRight();
	}

	public void ScrollRight()
	{
		if (int_1 + rectangle_1.Width > ((Control)this).get_Width())
		{
			method_10(-Math.Min(((Control)this).get_Width(), rectangle_1.Right - ((Control)this).get_Width() + 2));
		}
	}

	private void buttonX_1_Click(object sender, EventArgs e)
	{
		ScrollLeft();
	}

	public void ScrollLeft()
	{
		method_10(Math.Min(Math.Abs(int_1), ((Control)this).get_Width()));
	}

	public void ResetScrollPosition()
	{
		method_10(-int_1);
	}

	private void method_10(int int_2)
	{
		int_1 += int_2;
		((Control)this).PerformLayout();
	}

	private Rectangle method_11(Rectangle rectangle_2)
	{
		rectangle_2.Y -= 6;
		rectangle_2.Height += 6;
		return rectangle_2;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		bool flag = true;
		if (bool_8 && Class109.Boolean_0)
		{
			Rectangle rectangle = method_11(((Control)this).get_ClientRectangle());
			eTabStripAlignment eTabStripAlignment2 = eTabStripAlignment.Top;
			Rectangle rectangle2 = new Rectangle(0, 0, rectangle.Width, rectangle.Height);
			if (m_ThemeCachedBitmap != null && !(((Image)m_ThemeCachedBitmap).get_Size() != rectangle2.Size))
			{
				e.get_Graphics().DrawImageUnscaled((Image)(object)m_ThemeCachedBitmap, rectangle.X, rectangle.Y);
			}
			else
			{
				DisposeThemeCachedBitmap();
				Bitmap val = new Bitmap(rectangle2.Width, rectangle2.Height, e.get_Graphics());
				try
				{
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					try
					{
						SolidBrush val3 = new SolidBrush(Color.Transparent);
						try
						{
							val2.FillRectangle((Brush)(object)val3, 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
						}
						finally
						{
							((IDisposable)val3)?.Dispose();
						}
						base.Class59_0.method_0(val2, Class119.class119_8, Class144.class144_2, rectangle2);
					}
					finally
					{
						val2.Dispose();
					}
				}
				finally
				{
					switch (eTabStripAlignment2)
					{
					case eTabStripAlignment.Left:
						((Image)val).RotateFlip((RotateFlipType)3);
						break;
					case eTabStripAlignment.Right:
						((Image)val).RotateFlip((RotateFlipType)1);
						break;
					case eTabStripAlignment.Bottom:
						((Image)val).RotateFlip((RotateFlipType)2);
						break;
					}
					e.get_Graphics().DrawImageUnscaled((Image)(object)val, rectangle.X, rectangle.Y);
					m_ThemeCachedBitmap = val;
				}
			}
			flag = false;
		}
		if (flag)
		{
			base.OnPaint(e);
		}
		if (((Component)(object)this).DesignMode && ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0 && ((Control)this).get_Text() == "")
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			clientRectangle.Inflate(-2, -2);
			StringFormat val4 = Class109.smethod_3();
			val4.set_Alignment((StringAlignment)1);
			val4.set_LineAlignment((StringAlignment)1);
			val4.set_Trimming((StringTrimming)3);
			Font val5 = new Font(((Control)this).get_Font(), (FontStyle)1);
			e.get_Graphics().DrawString("Drop RibbonBar or other controls here. Drag and Drop tabs and items to re-order.", val5, (Brush)new SolidBrush(ControlPaint.Dark(Style.BackColor)), (RectangleF)clientRectangle, val4);
			val5.Dispose();
			val4.Dispose();
		}
		if (((Control)this).get_Parent() is RibbonControl)
		{
			((RibbonControl)(object)((Control)this).get_Parent()).RibbonStrip.method_19();
		}
	}

	protected override void OnResize(EventArgs e)
	{
		int_1 = 0;
		DisposeThemeCachedBitmap();
		base.OnResize(e);
	}

	bool IKeyTipsControl.ProcessMnemonicEx(char charCode)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0)
		{
			return false;
		}
		Control[] array = (Control[])(object)new Control[((ArrangedElementCollection)((Control)this).get_Controls()).get_Count()];
		((ArrangedElementCollection)((Control)this).get_Controls()).CopyTo((Array)array, 0);
		ArrayList arrayList = new ArrayList(array);
		arrayList.Sort(new Class239());
		foreach (Control item in arrayList)
		{
			Control val = item;
			if (val is IKeyTipsControl keyTipsControl && val.get_Visible() && val.get_Enabled())
			{
				string keyTipsKeysStack = keyTipsControl.KeyTipsKeysStack;
				if (keyTipsControl.ProcessMnemonicEx(charCode))
				{
					return true;
				}
				if (keyTipsControl.KeyTipsKeysStack != keyTipsKeysStack)
				{
					((IKeyTipsControl)this).KeyTipsKeysStack = keyTipsControl.KeyTipsKeysStack;
					return false;
				}
			}
		}
		return false;
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxBitmap(typeof(ExpandablePanel), "ExpandablePanel.ico")]
[Designer(typeof(ExpandablePanelDesigner))]
[ToolboxItem(true)]
public class ExpandablePanel : PanelEx
{
	private ExpandChangeEventHandler expandChangeEventHandler_0;

	private ExpandChangeEventHandler expandChangeEventHandler_1;

	private Class204 class204_0 = new Class204();

	private bool bool_11 = true;

	private int int_1 = 100;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Image image_0;

	private Image image_1;

	private eCollapseDirection eCollapseDirection_0;

	private Image image_2;

	private Image image_3;

	private Image image_4;

	private Image image_5;

	private PanelEx panelEx_0;

	private bool bool_12;

	[Description("Indicates whether panel is collapsed/expanded when title bar is clicked.")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Expand")]
	public bool ExpandOnTitleClick
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

	[Category("Expand")]
	[Browsable(true)]
	[Description("Indicates collapse/expand direction for the control.")]
	[DefaultValue(eCollapseDirection.BottomToTop)]
	public eCollapseDirection CollapseDirection
	{
		get
		{
			return eCollapseDirection_0;
		}
		set
		{
			eCollapseDirection_0 = value;
			method_23();
		}
	}

	[Description("Indicates whether panel is expaned or not. Default value is true.")]
	[Category("Expand")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool Expanded
	{
		get
		{
			return bool_11;
		}
		set
		{
			if (bool_11 != value)
			{
				method_10(value, eEventSource.Code);
			}
		}
	}

	[Browsable(true)]
	[Category("Expand")]
	[DefaultValue(100)]
	[Description("Indicates animation time in milliseconds, set to 0 to disable animation.")]
	public int AnimationTime
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 >= 0)
			{
				int_1 = value;
			}
		}
	}

	[Browsable(false)]
	public Rectangle ExpandedBounds
	{
		get
		{
			return rectangle_1;
		}
		set
		{
			rectangle_1 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Expand Button")]
	[Description("Indicates whether expand button is visible or not.")]
	public bool ExpandButtonVisible
	{
		get
		{
			return class204_0.Boolean_3;
		}
		set
		{
			class204_0.Boolean_3 = value;
		}
	}

	[Browsable(false)]
	public Rectangle ExpandButtonBounds => class204_0.ButtonItem_0.DisplayRectangle;

	[Category("Title")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Indicates image used on title bar to collapse panel.")]
	public Image ButtonImageCollapse
	{
		get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
			method_15();
		}
	}

	[DefaultValue(null)]
	[Description("Indicates image used on title bar to expand panel.")]
	[Category("Title")]
	[Browsable(true)]
	public Image ButtonImageExpand
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			method_15();
		}
	}

	[Localizable(true)]
	[DefaultValue("")]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Category("Title")]
	[Description("Indicates text for the title of the panel.")]
	public string TitleText
	{
		get
		{
			return ((Control)class204_0).get_Text();
		}
		set
		{
			((Control)class204_0).set_Text(value);
			if (panelEx_0 != null)
			{
				((Control)panelEx_0).set_Text(value);
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	[NotifyParentProperty(true)]
	[Category("Title")]
	[Description("Gets or sets title style.")]
	public ItemStyle TitleStyle => class204_0.Style;

	[Browsable(true)]
	[Description("Gets or sets the title style when mouse hovers over the title.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Title")]
	[DevCoBrowsable(true)]
	[NotifyParentProperty(true)]
	public ItemStyle TitleStyleMouseOver => class204_0.StyleMouseOver;

	[NotifyParentProperty(true)]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Title")]
	[Browsable(true)]
	[Description("Gets or sets the Title style when mouse button is pressed on the title.")]
	public ItemStyle TitleStyleMouseDown => class204_0.StyleMouseDown;

	[Description("Indicates height of the title portion of the panel.")]
	[DefaultValue(26)]
	[Browsable(true)]
	[Category("Title")]
	public int TitleHeight
	{
		get
		{
			return method_21();
		}
		set
		{
			method_22(value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public PanelEx TitlePanel => class204_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ButtonItem ExpandButton => class204_0.ButtonItem_0;

	[Browsable(false)]
	public PanelEx VerticalExpandPanel => panelEx_0;

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

	public ExpandablePanel()
	{
		((Control)class204_0).set_Text("Title Bar");
		((Control)class204_0).set_Location(new Point(0, 0));
		((Control)class204_0).set_Size(new Size(24, 26));
		((Control)class204_0).set_Dock((DockStyle)1);
		((Control)this).get_Controls().Add((Control)(object)class204_0);
		class204_0.ColorScheme = base.ColorScheme;
		class204_0.Event_0 += method_9;
		((Control)class204_0).add_Click((EventHandler)class204_0_Click);
		method_15();
	}

	private void class204_0_Click(object sender, EventArgs e)
	{
		if (bool_12 && !class204_0.ButtonItem_0.DisplayRectangle.Contains(((Control)class204_0).PointToClient(Control.get_MousePosition())))
		{
			Expanded = !Expanded;
		}
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		base.OnControlAdded(e);
		((Control)class204_0).SendToBack();
	}

	private void method_9(object sender, EventArgs e)
	{
		Expanded = !Expanded;
	}

	private void method_10(bool bool_13, eEventSource eEventSource_0)
	{
		ExpandedChangeEventArgs expandedChangeEventArgs = new ExpandedChangeEventArgs(eEventSource_0, bool_13);
		method_17(expandedChangeEventArgs);
		if (!expandedChangeEventArgs.Cancel)
		{
			bool_11 = bool_13;
			method_13();
			method_18(expandedChangeEventArgs);
		}
	}

	private DockStyle method_11(Control control_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)control_0.get_Dock() == 0 || (int)control_0.get_Dock() == 5)
		{
			return (DockStyle)1;
		}
		return control_0.get_Dock();
	}

	private Rectangle method_12()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Invalid comparison between Unknown and I4
		Rectangle result = rectangle_1;
		DockStyle val = method_11((Control)(object)class204_0);
		if ((int)val == 3)
		{
			result = new Rectangle(((Control)this).get_Bounds().Location, rectangle_1.Size);
		}
		else if ((int)val == 4)
		{
			result = new Rectangle(((Control)this).get_Bounds().X - (rectangle_1.Width - ((Control)this).get_Width()), ((Control)this).get_Bounds().Y, rectangle_1.Width, rectangle_1.Height);
		}
		else if ((int)val == 1)
		{
			result = ((eCollapseDirection_0 == eCollapseDirection.LeftToRight) ? new Rectangle(((Control)this).get_Bounds().X - (rectangle_1.Width - ((Control)this).get_Bounds().Width), ((Control)this).get_Bounds().Y, rectangle_1.Width, rectangle_1.Height) : ((eCollapseDirection_0 != eCollapseDirection.TopToBottom) ? new Rectangle(((Control)this).get_Bounds().Location, rectangle_1.Size) : new Rectangle(((Control)this).get_Bounds().X, rectangle_1.Y, rectangle_1.Width, rectangle_1.Height)));
		}
		else if ((int)val == 2)
		{
			result = new Rectangle(((Control)this).get_Bounds().X, ((Control)this).get_Bounds().Y - (rectangle_1.Height - ((Control)this).get_Height()), rectangle_1.Width, rectangle_1.Height);
		}
		return result;
	}

	private void method_13()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		if (Expanded)
		{
			class204_0.Boolean_1 = true;
			base.Boolean_1 = true;
			if (!rectangle_1.IsEmpty)
			{
				if (panelEx_0 != null)
				{
					method_14();
				}
				((Control)this).SuspendLayout();
				foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
				{
					Control val = item;
					if (val != TitlePanel)
					{
						val.set_Visible(true);
					}
				}
				((Control)this).ResumeLayout();
				Rectangle rectangle = method_12();
				if (AnimationTime != 0 && !((Component)(object)this).DesignMode)
				{
					Rectangle bounds = ((Control)this).get_Bounds();
					Class109.smethod_66((Control)(object)this, bool_3: true, int_1, bounds, rectangle);
				}
				else
				{
					TypeDescriptor.GetProperties(this)["Bounds"]!.SetValue(this, rectangle);
				}
				TypeDescriptor.GetProperties(this)["ExpandedBounds"]!.SetValue(this, Rectangle.Empty);
			}
		}
		else
		{
			TypeDescriptor.GetProperties(this)["ExpandedBounds"]!.SetValue(this, ((Control)this).get_Bounds());
			Point point = ((Control)this).PointToScreen(Point.Empty);
			point = ((((Control)this).get_Parent() == null) ? Point.Empty : ((Control)this).get_Parent().PointToClient(point));
			Rectangle rectangle2 = new Rectangle(point, new Size(((Control)class204_0).get_Width() + ((ScrollableControl)this).get_DockPadding().get_Left() + ((ScrollableControl)this).get_DockPadding().get_Right(), Math.Max(((Control)class204_0).get_Height() + ((ScrollableControl)this).get_DockPadding().get_Top() + ((ScrollableControl)this).get_DockPadding().get_Bottom(), class204_0.ButtonItem_0.HeightInternal)));
			if (eCollapseDirection_0 == eCollapseDirection.RightToLeft)
			{
				rectangle2 = new Rectangle(point, new Size(Math.Max(((Control)class204_0).get_Height() + ((ScrollableControl)this).get_DockPadding().get_Top() + ((ScrollableControl)this).get_DockPadding().get_Bottom(), class204_0.ButtonItem_0.WidthInternal + 6), ((Control)this).get_Height()));
			}
			else if (eCollapseDirection_0 == eCollapseDirection.LeftToRight)
			{
				Size size = new Size(Math.Max(((Control)class204_0).get_Height() + ((ScrollableControl)this).get_DockPadding().get_Top() + ((ScrollableControl)this).get_DockPadding().get_Bottom(), class204_0.ButtonItem_0.WidthInternal + 6), ((Control)this).get_Height());
				if (!point.IsEmpty)
				{
					point.X += ((Control)this).get_Width() - size.Width;
				}
				rectangle2 = new Rectangle(point, size);
			}
			else if (eCollapseDirection_0 == eCollapseDirection.TopToBottom)
			{
				Size size2 = new Size(((Control)class204_0).get_Width() + ((ScrollableControl)this).get_DockPadding().get_Left() + ((ScrollableControl)this).get_DockPadding().get_Right(), Math.Max(((Control)class204_0).get_Height() + ((ScrollableControl)this).get_DockPadding().get_Top() + ((ScrollableControl)this).get_DockPadding().get_Bottom(), class204_0.ButtonItem_0.HeightInternal));
				if (!point.IsEmpty)
				{
					point.Y += ((Control)this).get_Height() - size2.Height;
				}
				rectangle2 = new Rectangle(point, size2);
			}
			if (AnimationTime != 0 && !((Component)(object)this).DesignMode)
			{
				Rectangle bounds2 = ((Control)this).get_Bounds();
				Class109.smethod_66((Control)(object)this, bool_3: true, int_1, bounds2, rectangle2);
			}
			else
			{
				TypeDescriptor.GetProperties(this)["Bounds"]!.SetValue(this, rectangle2);
			}
			if (eCollapseDirection_0 == eCollapseDirection.LeftToRight || eCollapseDirection_0 == eCollapseDirection.RightToLeft)
			{
				class204_0.Boolean_1 = false;
				base.Boolean_1 = false;
			}
			((Control)this).SuspendLayout();
			foreach (Control item2 in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val2 = item2;
				if (val2 != TitlePanel)
				{
					val2.set_Visible(false);
				}
			}
			((Control)this).ResumeLayout();
			((Control)class204_0).SendToBack();
			if (eCollapseDirection_0 == eCollapseDirection.LeftToRight || eCollapseDirection_0 == eCollapseDirection.RightToLeft)
			{
				method_24();
			}
		}
		method_15();
		((Control)this).Refresh();
	}

	private void method_14()
	{
		if (panelEx_0 != null)
		{
			((Control)this).get_Controls().Remove((Control)(object)panelEx_0);
			((Component)(object)panelEx_0).Dispose();
			panelEx_0 = null;
		}
	}

	private void method_15()
	{
		Image image = null;
		Image hoverImage = null;
		if (Expanded)
		{
			if (image_1 != null)
			{
				image = image_1;
			}
			else if (base.ColorSchemeStyle == eDotNetBarStyle.Office2007)
			{
				if (eCollapseDirection_0 != 0 && eCollapseDirection_0 != eCollapseDirection.RightToLeft)
				{
					image = image_2;
					hoverImage = image_4;
				}
				else
				{
					image = image_3;
					hoverImage = image_5;
				}
			}
			else if (eCollapseDirection_0 == eCollapseDirection.BottomToTop)
			{
				image = (Image)(object)Class109.smethod_67("SystemImages.ExpandTitle.png");
			}
			else if (eCollapseDirection_0 == eCollapseDirection.TopToBottom)
			{
				image = (Image)(object)Class109.smethod_67("SystemImages.CollapseTitle.png");
			}
			else if (eCollapseDirection_0 == eCollapseDirection.LeftToRight)
			{
				Bitmap val = Class109.smethod_67("SystemImages.ExpandTitle.png");
				((Image)val).RotateFlip((RotateFlipType)3);
				image = (Image)(object)val;
			}
			else if (eCollapseDirection_0 == eCollapseDirection.RightToLeft)
			{
				Bitmap val2 = Class109.smethod_67("SystemImages.ExpandTitle.png");
				((Image)val2).RotateFlip((RotateFlipType)1);
				image = (Image)(object)val2;
			}
		}
		else if (image_0 != null)
		{
			image = image_0;
		}
		else if (base.ColorSchemeStyle == eDotNetBarStyle.Office2007)
		{
			if (eCollapseDirection_0 != 0 && eCollapseDirection_0 != eCollapseDirection.RightToLeft)
			{
				image = image_3;
				hoverImage = image_5;
			}
			else
			{
				image = image_2;
				hoverImage = image_4;
			}
		}
		else if (eCollapseDirection_0 == eCollapseDirection.BottomToTop)
		{
			image = (Image)(object)Class109.smethod_67("SystemImages.CollapseTitle.png");
		}
		else if (eCollapseDirection_0 == eCollapseDirection.TopToBottom)
		{
			image = (Image)(object)Class109.smethod_67("SystemImages.ExpandTitle.png");
		}
		else if (eCollapseDirection_0 == eCollapseDirection.LeftToRight)
		{
			Bitmap val3 = Class109.smethod_67("SystemImages.CollapseTitle.png");
			((Image)val3).RotateFlip((RotateFlipType)3);
			image = (Image)(object)val3;
		}
		else if (eCollapseDirection_0 == eCollapseDirection.RightToLeft)
		{
			Bitmap val4 = Class109.smethod_67("SystemImages.CollapseTitle.png");
			((Image)val4).RotateFlip((RotateFlipType)1);
			image = (Image)(object)val4;
		}
		class204_0.ButtonItem_0.Image = image;
		class204_0.ButtonItem_0.HoverImage = hoverImage;
		class204_0.method_9();
		((Control)class204_0).Invalidate();
	}

	private void method_16()
	{
		if (image_3 != null)
		{
			image_3.Dispose();
		}
		if (image_2 != null)
		{
			image_2.Dispose();
		}
		if (image_5 != null)
		{
			image_5.Dispose();
		}
		if (image_4 != null)
		{
			image_4.Dispose();
		}
		bool flag = eCollapseDirection_0 == eCollapseDirection.TopToBottom || eCollapseDirection_0 == eCollapseDirection.BottomToTop;
		image_3 = Class34.smethod_1(bool_0: true, base.ColorScheme.PanelText, flag);
		image_5 = Class34.smethod_1(bool_0: true, base.ColorScheme.ItemHotText, flag);
		image_2 = Class34.smethod_1(bool_0: false, base.ColorScheme.PanelText, flag);
		image_4 = Class34.smethod_1(bool_0: false, base.ColorScheme.ItemHotText, flag);
	}

	private void method_17(ExpandedChangeEventArgs expandedChangeEventArgs_0)
	{
		if (expandChangeEventHandler_0 != null)
		{
			expandChangeEventHandler_0(this, expandedChangeEventArgs_0);
		}
	}

	private void method_18(ExpandedChangeEventArgs expandedChangeEventArgs_0)
	{
		if (expandChangeEventHandler_1 != null)
		{
			expandChangeEventHandler_1(this, expandedChangeEventArgs_0);
		}
	}

	protected override void OnColorSchemeChanged()
	{
		base.OnColorSchemeChanged();
		class204_0.ColorScheme = base.ColorScheme;
		method_19();
	}

	private void method_19()
	{
		method_20();
		if (base.ColorSchemeStyle == eDotNetBarStyle.Office2007)
		{
			method_16();
		}
		method_15();
	}

	private void method_20()
	{
		if (image_3 != null)
		{
			image_3.Dispose();
			image_3 = null;
		}
		if (image_5 != null)
		{
			image_5.Dispose();
			image_5 = null;
		}
		if (image_2 != null)
		{
			image_2.Dispose();
			image_2 = null;
		}
		if (image_4 != null)
		{
			image_4.Dispose();
			image_4 = null;
		}
	}

	private int method_21()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if ((int)((Control)class204_0).get_Dock() != 3 && (int)((Control)class204_0).get_Dock() != 4)
		{
			return ((Control)class204_0).get_Height();
		}
		return ((Control)class204_0).get_Width();
	}

	private void method_22(int int_2)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		if ((int)((Control)class204_0).get_Dock() != 3 && (int)((Control)class204_0).get_Dock() != 4)
		{
			((Control)class204_0).set_Height(int_2);
			if (!Expanded)
			{
				TypeDescriptor.GetProperties(this)["Height"]!.SetValue(this, int_2);
			}
		}
		else
		{
			((Control)class204_0).set_Width(int_2);
			if (!Expanded)
			{
				TypeDescriptor.GetProperties(this)["Width"]!.SetValue(this, int_2);
			}
		}
	}

	private void method_23()
	{
		method_19();
	}

	protected override void Dispose(bool disposing)
	{
		method_20();
		base.Dispose(disposing);
	}

	private void method_24()
	{
		panelEx_0 = new PanelEx();
		panelEx_0.ColorSchemeStyle = base.ColorSchemeStyle;
		panelEx_0.ColorScheme = base.ColorScheme;
		panelEx_0.ApplyButtonStyle();
		panelEx_0.Style.VerticalText = true;
		panelEx_0.Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
		panelEx_0.Style.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
		panelEx_0.Style.ResetBackColor2();
		panelEx_0.StyleMouseOver.VerticalText = true;
		panelEx_0.StyleMouseDown.VerticalText = true;
		((Control)panelEx_0).set_Dock((DockStyle)5);
		((Control)panelEx_0).set_Text(((Control)TitlePanel).get_Text());
		((Control)this).get_Controls().Add((Control)(object)panelEx_0);
		if (TitleStyle.Font != null)
		{
			((Control)panelEx_0).set_Font(TitleStyle.Font);
		}
		else if (((Control)TitlePanel).get_Font() != null)
		{
			((Control)panelEx_0).set_Font(((Control)TitlePanel).get_Font());
		}
		((Control)panelEx_0).add_Click((EventHandler)panelEx_0_Click);
	}

	private void panelEx_0_Click(object sender, EventArgs e)
	{
		Expanded = !Expanded;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExpandedBounds()
	{
		return !rectangle_1.IsEmpty;
	}

	public void ResetTitleStyle()
	{
		class204_0.ResetStyle();
	}

	public void ResetTitleStyleMouseOver()
	{
		class204_0.ResetStyleMouseOver();
	}

	public void ResetTitleStyleMouseDown()
	{
		class204_0.ResetStyleMouseDown();
	}

	protected override void OnAntiAliasChanged()
	{
		class204_0.AntiAlias = base.AntiAlias;
	}
}

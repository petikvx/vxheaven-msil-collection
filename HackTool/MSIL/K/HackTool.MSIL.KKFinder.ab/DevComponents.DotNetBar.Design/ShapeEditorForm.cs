using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Design;

public class ShapeEditorForm : Form
{
	private IShapeDescriptor ishapeDescriptor_0;

	private IContainer icontainer_0;

	private ItemPanel itemPanel1;

	private ButtonItem buttonRect;

	private ButtonItem buttonRound;

	private LabelItem labelItem1;

	private ItemContainer itemContainer1;

	private Button button1;

	private Button button2;

	private TabControl tabControl1;

	private TabControlPanel tabControlPanel1;

	private TabItem tabDefault;

	private ButtonItem buttonDefault;

	private TabControlPanel tabControlPanel3;

	private TabItem tabRound;

	private TabControlPanel tabControlPanel2;

	private TabItem tabRect;

	private IntegerInput roundBottomRight;

	private IntegerInput roundTopRight;

	private IntegerInput roundBottomLeft;

	private IntegerInput roundTopLeft;

	private ButtonX buttonRoundPreview;

	private ButtonItem buttonEllipse;

	private TabControlPanel tabControlPanel4;

	private TabItem tabItem1;

	public IShapeDescriptor Value
	{
		get
		{
			return ishapeDescriptor_0;
		}
		set
		{
			ishapeDescriptor_0 = value;
			method_0();
		}
	}

	public ShapeEditorForm()
	{
		InitializeComponent();
	}

	private void itemPanel1_OptionGroupChanging(object sender, OptionGroupChangingEventArgs e)
	{
		BaseItem parent = e.NewChecked.Parent;
		tabControl1.SelectedTabIndex = parent.SubItems.IndexOf(e.NewChecked);
	}

	private void method_0()
	{
		if (ishapeDescriptor_0 is RoundRectangleShapeDescriptor)
		{
			RoundRectangleShapeDescriptor roundRectangleShapeDescriptor = (RoundRectangleShapeDescriptor)ishapeDescriptor_0;
			if (roundRectangleShapeDescriptor.IsEmpty)
			{
				buttonRect.Checked = true;
			}
			else
			{
				buttonRound.Checked = true;
			}
		}
		else if (ishapeDescriptor_0 is EllipticalShapeDescriptor)
		{
			buttonEllipse.Checked = true;
		}
		else
		{
			buttonDefault.Checked = true;
		}
	}

	private void tabControl1_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
	{
		if (e.NewTab == tabRound)
		{
			RoundRectangleShapeDescriptor roundRectangleShapeDescriptor = ishapeDescriptor_0 as RoundRectangleShapeDescriptor;
			if (roundRectangleShapeDescriptor == null)
			{
				roundRectangleShapeDescriptor = new RoundRectangleShapeDescriptor(2);
			}
			roundTopLeft.Value = roundRectangleShapeDescriptor.TopLeft;
			roundTopRight.Value = roundRectangleShapeDescriptor.TopRight;
			roundBottomLeft.Value = roundRectangleShapeDescriptor.BottomLeft;
			roundBottomRight.Value = roundRectangleShapeDescriptor.BottomRight;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (buttonDefault.Checked)
		{
			ishapeDescriptor_0 = null;
		}
		else if (buttonRect.Checked)
		{
			ishapeDescriptor_0 = new RoundRectangleShapeDescriptor(0);
		}
		else if (buttonRound.Checked)
		{
			ishapeDescriptor_0 = new RoundRectangleShapeDescriptor(roundTopLeft.Value, roundTopRight.Value, roundBottomLeft.Value, roundBottomRight.Value);
		}
		else if (buttonEllipse.Checked)
		{
			ishapeDescriptor_0 = new EllipticalShapeDescriptor();
		}
	}

	private void roundTopLeft_ValueChanged(object sender, EventArgs e)
	{
		RoundRectangleShapeDescriptor shape = new RoundRectangleShapeDescriptor(roundTopLeft.Value, roundTopRight.Value, roundBottomLeft.Value, roundBottomRight.Value);
		buttonRoundPreview.Shape = shape;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ShapeEditorForm));
		itemPanel1 = new ItemPanel();
		labelItem1 = new LabelItem();
		itemContainer1 = new ItemContainer();
		buttonDefault = new ButtonItem();
		buttonRect = new ButtonItem();
		buttonRound = new ButtonItem();
		buttonEllipse = new ButtonItem();
		button1 = new Button();
		button2 = new Button();
		tabControl1 = new TabControl();
		tabControlPanel1 = new TabControlPanel();
		tabDefault = new TabItem(icontainer_0);
		tabControlPanel4 = new TabControlPanel();
		tabItem1 = new TabItem(icontainer_0);
		tabControlPanel2 = new TabControlPanel();
		tabRect = new TabItem(icontainer_0);
		tabControlPanel3 = new TabControlPanel();
		roundBottomRight = new IntegerInput();
		roundTopRight = new IntegerInput();
		roundBottomLeft = new IntegerInput();
		roundTopLeft = new IntegerInput();
		buttonRoundPreview = new ButtonX();
		tabRound = new TabItem(icontainer_0);
		((ISupportInitialize)tabControl1).BeginInit();
		((Control)tabControl1).SuspendLayout();
		((Control)tabControlPanel3).SuspendLayout();
		((ISupportInitialize)roundBottomRight).BeginInit();
		((ISupportInitialize)roundTopRight).BeginInit();
		((ISupportInitialize)roundBottomLeft).BeginInit();
		((ISupportInitialize)roundTopLeft).BeginInit();
		((Control)this).SuspendLayout();
		itemPanel1.BackgroundStyle.BackColor = Color.White;
		itemPanel1.BackgroundStyle.BorderBottom = eStyleBorderType.Solid;
		itemPanel1.BackgroundStyle.BorderBottomWidth = 1;
		itemPanel1.BackgroundStyle.BorderColor = Color.FromArgb(127, 157, 185);
		itemPanel1.BackgroundStyle.BorderLeft = eStyleBorderType.Solid;
		itemPanel1.BackgroundStyle.BorderLeftWidth = 1;
		itemPanel1.BackgroundStyle.BorderRight = eStyleBorderType.Solid;
		itemPanel1.BackgroundStyle.BorderRightWidth = 1;
		itemPanel1.BackgroundStyle.BorderTop = eStyleBorderType.Solid;
		itemPanel1.BackgroundStyle.BorderTopWidth = 1;
		itemPanel1.BackgroundStyle.PaddingBottom = 1;
		itemPanel1.BackgroundStyle.PaddingLeft = 1;
		itemPanel1.BackgroundStyle.PaddingRight = 1;
		itemPanel1.BackgroundStyle.PaddingTop = 1;
		((Control)itemPanel1).set_Dock((DockStyle)1);
		itemPanel1.Items.AddRange(new BaseItem[2] { labelItem1, itemContainer1 });
		itemPanel1.ItemSpacing = 2;
		itemPanel1.LayoutOrientation = eOrientation.Vertical;
		((Control)itemPanel1).set_Location(new Point(0, 0));
		((Control)itemPanel1).set_Name("itemPanel1");
		((Control)itemPanel1).set_Size(new Size(387, 69));
		((Control)itemPanel1).set_TabIndex(0);
		((Control)itemPanel1).set_Text("itemPanel1");
		itemPanel1.OptionGroupChanging += itemPanel1_OptionGroupChanging;
		labelItem1.BackColor = Color.FromArgb(224, 224, 224);
		labelItem1.BorderSide = eBorderSide.Bottom;
		labelItem1.BorderType = eBorderType.SingleLine;
		labelItem1.Name = "labelItem1";
		labelItem1.PaddingBottom = 2;
		labelItem1.PaddingLeft = 2;
		labelItem1.PaddingTop = 2;
		labelItem1.SingleLineColor = Color.DarkGray;
		labelItem1.Text = "<b>Choose the shape you want to use:</b>";
		itemContainer1.Name = "itemContainer1";
		itemContainer1.SubItems.AddRange(new BaseItem[4] { buttonDefault, buttonRect, buttonRound, buttonEllipse });
		buttonDefault.AutoCheckOnClick = true;
		buttonDefault.Image = (Image)componentResourceManager.GetObject("buttonDefault.Image");
		buttonDefault.ImagePaddingHorizontal = 8;
		buttonDefault.Name = "buttonDefault";
		buttonDefault.OptionGroup = "shape";
		buttonDefault.Text = "Default";
		buttonDefault.Tooltip = "Use Default Shape";
		buttonRect.AutoCheckOnClick = true;
		buttonRect.Image = (Image)componentResourceManager.GetObject("buttonRect.Image");
		buttonRect.ImagePaddingHorizontal = 8;
		buttonRect.Name = "buttonRect";
		buttonRect.OptionGroup = "shape";
		buttonRect.Text = "Rect";
		buttonRect.Tooltip = "Rectangle Shape";
		buttonRound.AutoCheckOnClick = true;
		buttonRound.Image = (Image)componentResourceManager.GetObject("buttonRound.Image");
		buttonRound.ImagePaddingHorizontal = 8;
		buttonRound.Name = "buttonRound";
		buttonRound.OptionGroup = "shape";
		buttonRound.Text = "Round";
		buttonRound.Tooltip = "Rounded Rectangle Shape";
		buttonEllipse.AutoCheckOnClick = true;
		buttonEllipse.Image = (Image)componentResourceManager.GetObject("buttonEllipse.Image");
		buttonEllipse.ImagePaddingHorizontal = 8;
		buttonEllipse.Name = "buttonEllipse";
		buttonEllipse.OptionGroup = "shape";
		buttonEllipse.Text = "Elliptical Shape";
		buttonEllipse.Tooltip = "Elliptical Shape";
		((Control)button1).set_Anchor((AnchorStyles)10);
		button1.set_DialogResult((DialogResult)1);
		((Control)button1).set_Location(new Point(228, 165));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 24));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("OK");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Anchor((AnchorStyles)10);
		button2.set_DialogResult((DialogResult)2);
		((Control)button2).set_Location(new Point(309, 165));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 24));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("Cancel");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)tabControl1).set_Anchor((AnchorStyles)15);
		tabControl1.CanReorderTabs = true;
		((Control)tabControl1).get_Controls().Add((Control)(object)tabControlPanel1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabControlPanel4);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabControlPanel2);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabControlPanel3);
		((Control)tabControl1).set_Location(new Point(0, 70));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1);
		tabControl1.SelectedTabIndex = 0;
		((Control)tabControl1).set_Size(new Size(387, 89));
		tabControl1.Style = eTabStripStyle.Office2007Dock;
		((Control)tabControl1).set_TabIndex(3);
		tabControl1.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
		tabControl1.Tabs.Add(tabDefault);
		tabControl1.Tabs.Add(tabRect);
		tabControl1.Tabs.Add(tabRound);
		tabControl1.Tabs.Add(tabItem1);
		tabControl1.TabsVisible = false;
		((Control)tabControl1).set_Text("tabControl1");
		tabControl1.SelectedTabChanged += tabControl1_SelectedTabChanged;
		((Control)tabControlPanel1).set_Dock((DockStyle)5);
		((Control)tabControlPanel1).set_Location(new Point(0, 22));
		((Control)tabControlPanel1).set_Name("tabControlPanel1");
		((Control)tabControlPanel1).set_Padding(new Padding(1));
		((Control)tabControlPanel1).set_Size(new Size(387, 67));
		tabControlPanel1.Style.Alignment = (StringAlignment)1;
		tabControlPanel1.Style.BackColor1.Color = Color.White;
		tabControlPanel1.Style.BackColor2.Color = Color.White;
		tabControlPanel1.Style.Border = eBorderType.SingleLine;
		tabControlPanel1.Style.BorderColor.Color = Color.FromArgb(127, 157, 185);
		tabControlPanel1.Style.BorderSide = eBorderSide.Left | eBorderSide.Right | eBorderSide.Bottom;
		tabControlPanel1.Style.ForeColor.Color = Color.DimGray;
		tabControlPanel1.Style.GradientAngle = 90;
		((Control)tabControlPanel1).set_TabIndex(1);
		tabControlPanel1.TabItem = tabDefault;
		((Control)tabControlPanel1).set_Text("No properties available for this shape.");
		tabControlPanel1.UseCustomStyle = true;
		tabDefault.AttachedControl = (Control)(object)tabControlPanel1;
		tabDefault.Name = "tabDefault";
		tabDefault.Text = "Default";
		((Control)tabControlPanel4).set_Dock((DockStyle)5);
		((Control)tabControlPanel4).set_Location(new Point(0, 22));
		((Control)tabControlPanel4).set_Name("tabControlPanel4");
		((Control)tabControlPanel4).set_Padding(new Padding(1));
		((Control)tabControlPanel4).set_Size(new Size(387, 67));
		tabControlPanel4.Style.Alignment = (StringAlignment)1;
		tabControlPanel4.Style.BackColor1.Color = Color.White;
		tabControlPanel4.Style.BackColor2.Color = Color.White;
		tabControlPanel4.Style.Border = eBorderType.SingleLine;
		tabControlPanel4.Style.BorderColor.Color = Color.FromArgb(146, 165, 199);
		tabControlPanel4.Style.BorderSide = eBorderSide.Left | eBorderSide.Right | eBorderSide.Bottom;
		tabControlPanel4.Style.ForeColor.Color = Color.DimGray;
		tabControlPanel4.Style.GradientAngle = 90;
		((Control)tabControlPanel4).set_TabIndex(4);
		tabControlPanel4.TabItem = tabItem1;
		((Control)tabControlPanel4).set_Text("No properties available for this shape.");
		tabControlPanel4.UseCustomStyle = true;
		tabItem1.AttachedControl = (Control)(object)tabControlPanel4;
		tabItem1.Name = "tabItem1";
		tabItem1.Text = "Ellipse";
		((Control)tabControlPanel2).set_Dock((DockStyle)5);
		((Control)tabControlPanel2).set_Location(new Point(0, 22));
		((Control)tabControlPanel2).set_Name("tabControlPanel2");
		((Control)tabControlPanel2).set_Padding(new Padding(1));
		((Control)tabControlPanel2).set_Size(new Size(387, 67));
		tabControlPanel2.Style.Alignment = (StringAlignment)1;
		tabControlPanel2.Style.BackColor1.Color = Color.White;
		tabControlPanel2.Style.BackColor2.Color = Color.White;
		tabControlPanel2.Style.Border = eBorderType.SingleLine;
		tabControlPanel2.Style.BorderColor.Color = Color.FromArgb(127, 157, 185);
		tabControlPanel2.Style.BorderSide = eBorderSide.Left | eBorderSide.Right | eBorderSide.Bottom;
		tabControlPanel2.Style.ForeColor.Color = Color.DimGray;
		tabControlPanel2.Style.GradientAngle = 90;
		((Control)tabControlPanel2).set_TabIndex(2);
		tabControlPanel2.TabItem = tabRect;
		((Control)tabControlPanel2).set_Text("No properties available for this shape.");
		tabControlPanel2.UseCustomStyle = true;
		tabRect.AttachedControl = (Control)(object)tabControlPanel2;
		tabRect.Name = "tabRect";
		tabRect.Text = "Rect";
		((Control)tabControlPanel3).get_Controls().Add((Control)(object)roundBottomRight);
		((Control)tabControlPanel3).get_Controls().Add((Control)(object)roundTopRight);
		((Control)tabControlPanel3).get_Controls().Add((Control)(object)roundBottomLeft);
		((Control)tabControlPanel3).get_Controls().Add((Control)(object)roundTopLeft);
		((Control)tabControlPanel3).get_Controls().Add((Control)(object)buttonRoundPreview);
		((Control)tabControlPanel3).set_Dock((DockStyle)5);
		((Control)tabControlPanel3).set_Location(new Point(0, 22));
		((Control)tabControlPanel3).set_Name("tabControlPanel3");
		((Control)tabControlPanel3).set_Padding(new Padding(1));
		((Control)tabControlPanel3).set_Size(new Size(387, 67));
		tabControlPanel3.Style.BackColor1.Color = Color.White;
		tabControlPanel3.Style.BackColor2.Color = Color.White;
		tabControlPanel3.Style.Border = eBorderType.SingleLine;
		tabControlPanel3.Style.BorderColor.Color = Color.FromArgb(127, 157, 185);
		tabControlPanel3.Style.BorderSide = eBorderSide.Left | eBorderSide.Right | eBorderSide.Bottom;
		tabControlPanel3.Style.GradientAngle = 90;
		((Control)tabControlPanel3).set_TabIndex(3);
		tabControlPanel3.TabItem = tabRound;
		tabControlPanel3.UseCustomStyle = true;
		roundBottomRight.AllowEmptyState = false;
		roundBottomRight.BackgroundStyle.Class = "DateTimeInputBackground";
		((Control)roundBottomRight).set_Location(new Point(231, 29));
		roundBottomRight.MaxValue = 999;
		roundBottomRight.MinValue = 0;
		((Control)roundBottomRight).set_Name("roundBottomRight");
		roundBottomRight.ShowUpDown = true;
		((Control)roundBottomRight).set_Size(new Size(46, 20));
		((Control)roundBottomRight).set_TabIndex(4);
		roundBottomRight.ValueChanged += roundTopLeft_ValueChanged;
		roundTopRight.AllowEmptyState = false;
		roundTopRight.BackgroundStyle.Class = "DateTimeInputBackground";
		((Control)roundTopRight).set_Location(new Point(231, 4));
		roundTopRight.MaxValue = 999;
		roundTopRight.MinValue = 0;
		((Control)roundTopRight).set_Name("roundTopRight");
		roundTopRight.ShowUpDown = true;
		((Control)roundTopRight).set_Size(new Size(46, 20));
		((Control)roundTopRight).set_TabIndex(3);
		roundTopRight.ValueChanged += roundTopLeft_ValueChanged;
		roundBottomLeft.AllowEmptyState = false;
		roundBottomLeft.BackgroundStyle.Class = "DateTimeInputBackground";
		((Control)roundBottomLeft).set_Location(new Point(96, 29));
		roundBottomLeft.MaxValue = 999;
		roundBottomLeft.MinValue = 0;
		((Control)roundBottomLeft).set_Name("roundBottomLeft");
		roundBottomLeft.ShowUpDown = true;
		((Control)roundBottomLeft).set_Size(new Size(46, 20));
		((Control)roundBottomLeft).set_TabIndex(2);
		roundBottomLeft.ValueChanged += roundTopLeft_ValueChanged;
		roundTopLeft.AllowEmptyState = false;
		roundTopLeft.BackgroundStyle.Class = "DateTimeInputBackground";
		((Control)roundTopLeft).set_Location(new Point(96, 4));
		roundTopLeft.MaxValue = 999;
		roundTopLeft.MinValue = 0;
		((Control)roundTopLeft).set_Name("roundTopLeft");
		roundTopLeft.ShowUpDown = true;
		((Control)roundTopLeft).set_Size(new Size(46, 20));
		((Control)roundTopLeft).set_TabIndex(1);
		roundTopLeft.ValueChanged += roundTopLeft_ValueChanged;
		((Control)buttonRoundPreview).set_AccessibleRole((AccessibleRole)43);
		buttonRoundPreview.ColorTable = eButtonColor.OrangeWithBackground;
		((Control)buttonRoundPreview).set_Location(new Point(148, 4));
		((Control)buttonRoundPreview).set_Name("buttonRoundPreview");
		buttonRoundPreview.Shape = new RoundRectangleShapeDescriptor(2);
		((Control)buttonRoundPreview).set_Size(new Size(77, 45));
		((Control)buttonRoundPreview).set_TabIndex(0);
		((Control)buttonRoundPreview).set_Text("Preview");
		tabRound.AttachedControl = (Control)(object)tabControlPanel3;
		tabRound.Name = "tabRound";
		tabRound.Text = "Round";
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_ClientSize(new Size(387, 194));
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)itemPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ShapeEditorForm");
		((Control)this).set_Text("Shape Editor");
		((ISupportInitialize)tabControl1).EndInit();
		tabControl1.ResumeLayout(performLayout: false);
		((Control)tabControlPanel3).ResumeLayout(false);
		((ISupportInitialize)roundBottomRight).EndInit();
		((ISupportInitialize)roundTopRight).EndInit();
		((ISupportInitialize)roundBottomLeft).EndInit();
		((ISupportInitialize)roundTopLeft).EndInit();
		((Control)this).ResumeLayout(false);
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.ColorPickerItem;

[ToolboxItem(false)]
internal class CustomColorDialog : Office2007Form
{
	internal Button buttonOK;

	internal Button buttonCancel;

	internal Label labelNewColor;

	internal Label labelCurrentColor;

	private Color color_0 = Color.Black;

	private Color color_1 = Color.Empty;

	private Control4 colorCombControl1;

	internal Label labelStandardColors;

	internal Label labelCustomColors;

	private NumericUpDown numericRed;

	internal Label labelGreen;

	internal Label labelBlue;

	private TabControl tabControl2;

	internal TabItem tabItemStandard;

	private TabControlPanel tabControlPanel1;

	internal TabItem tabItemCustom;

	private TabControlPanel tabControlPanel2;

	private Control5 customColorBlender3;

	internal Label labelRed;

	internal Label labelColorModel;

	private NumericUpDown numericBlue;

	private NumericUpDown numericGreen;

	internal ComboBox comboColorModel;

	private ColorContrastControl colorContrastControl1;

	private Control6 colorSelectionPreview;

	private IContainer icontainer_1;

	private bool bool_10;

	public Color Color_0
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			colorSelectionPreview.Color_1 = value;
		}
	}

	public Color Color_1 => color_1;

	public CustomColorDialog()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_1 != null)
		{
			icontainer_1.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected O, but got Unknown
		icontainer_1 = new Container();
		labelStandardColors = new Label();
		colorCombControl1 = new Control4();
		labelBlue = new Label();
		labelGreen = new Label();
		numericBlue = new NumericUpDown();
		numericGreen = new NumericUpDown();
		numericRed = new NumericUpDown();
		labelCustomColors = new Label();
		buttonOK = new Button();
		buttonCancel = new Button();
		labelNewColor = new Label();
		labelCurrentColor = new Label();
		tabControl2 = new TabControl();
		tabControlPanel1 = new TabControlPanel();
		tabItemStandard = new TabItem(icontainer_1);
		tabControlPanel2 = new TabControlPanel();
		colorContrastControl1 = new ColorContrastControl();
		customColorBlender3 = new Control5();
		comboColorModel = new ComboBox();
		labelRed = new Label();
		labelColorModel = new Label();
		tabItemCustom = new TabItem(icontainer_1);
		colorSelectionPreview = new Control6();
		((ISupportInitialize)numericBlue).BeginInit();
		((ISupportInitialize)numericGreen).BeginInit();
		((ISupportInitialize)numericRed).BeginInit();
		((ISupportInitialize)tabControl2).BeginInit();
		((Control)tabControl2).SuspendLayout();
		((Control)tabControlPanel1).SuspendLayout();
		((Control)tabControlPanel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)labelStandardColors).set_BackColor(Color.Transparent);
		((Control)labelStandardColors).set_Dock((DockStyle)1);
		((Control)labelStandardColors).set_Location(new Point(1, 1));
		((Control)labelStandardColors).set_Name("labelStandardColors");
		((Control)labelStandardColors).set_Size(new Size(224, 19));
		((Control)labelStandardColors).set_TabIndex(1);
		((Control)labelStandardColors).set_Text(" Colors:");
		labelStandardColors.set_TextAlign((ContentAlignment)256);
		((Control)colorCombControl1).set_BackColor(Color.Transparent);
		((Control)colorCombControl1).set_Dock((DockStyle)5);
		((Control)colorCombControl1).set_Location(new Point(1, 20));
		((Control)colorCombControl1).set_Name("colorCombControl1");
		((Control)colorCombControl1).set_Size(new Size(224, 267));
		((Control)colorCombControl1).set_TabIndex(0);
		colorCombControl1.Event_0 += method_30;
		((Control)labelBlue).set_BackColor(Color.Transparent);
		((Control)labelBlue).set_Location(new Point(4, 256));
		((Control)labelBlue).set_Name("labelBlue");
		((Control)labelBlue).set_Size(new Size(76, 16));
		((Control)labelBlue).set_TabIndex(10);
		((Control)labelBlue).set_Text("&Blue:");
		((Control)labelGreen).set_BackColor(Color.Transparent);
		((Control)labelGreen).set_Location(new Point(4, 232));
		((Control)labelGreen).set_Name("labelGreen");
		((Control)labelGreen).set_Size(new Size(76, 16));
		((Control)labelGreen).set_TabIndex(8);
		((Control)labelGreen).set_Text("&Green:");
		((Control)numericBlue).set_Location(new Point(84, 260));
		numericBlue.set_Maximum(new decimal(new int[4] { 255, 0, 0, 0 }));
		((Control)numericBlue).set_Name("numericBlue");
		((Control)numericBlue).set_Size(new Size(47, 20));
		((Control)numericBlue).set_TabIndex(11);
		numericBlue.add_ValueChanged((EventHandler)numericRed_ValueChanged);
		((Control)numericGreen).set_Location(new Point(84, 236));
		numericGreen.set_Maximum(new decimal(new int[4] { 255, 0, 0, 0 }));
		((Control)numericGreen).set_Name("numericGreen");
		((Control)numericGreen).set_Size(new Size(47, 20));
		((Control)numericGreen).set_TabIndex(9);
		numericGreen.add_ValueChanged((EventHandler)numericRed_ValueChanged);
		((Control)numericRed).set_Location(new Point(84, 212));
		numericRed.set_Maximum(new decimal(new int[4] { 255, 0, 0, 0 }));
		((Control)numericRed).set_Name("numericRed");
		((Control)numericRed).set_Size(new Size(47, 20));
		((Control)numericRed).set_TabIndex(7);
		numericRed.add_ValueChanged((EventHandler)numericRed_ValueChanged);
		((Control)labelCustomColors).set_BackColor(Color.Transparent);
		((Control)labelCustomColors).set_Dock((DockStyle)1);
		((Control)labelCustomColors).set_Location(new Point(1, 1));
		((Control)labelCustomColors).set_Name("labelCustomColors");
		((Control)labelCustomColors).set_Size(new Size(224, 20));
		((Control)labelCustomColors).set_TabIndex(2);
		((Control)labelCustomColors).set_Text(" Colors:");
		labelCustomColors.set_TextAlign((ContentAlignment)256);
		buttonOK.set_DialogResult((DialogResult)1);
		((ButtonBase)buttonOK).set_FlatStyle((FlatStyle)3);
		((Control)buttonOK).set_Location(new Point(242, 6));
		((Control)buttonOK).set_Name("buttonOK");
		((Control)buttonOK).set_Size(new Size(74, 24));
		((Control)buttonOK).set_TabIndex(1);
		((Control)buttonOK).set_Text("OK");
		buttonCancel.set_DialogResult((DialogResult)2);
		((ButtonBase)buttonCancel).set_FlatStyle((FlatStyle)3);
		((Control)buttonCancel).set_Location(new Point(242, 36));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(74, 24));
		((Control)buttonCancel).set_TabIndex(2);
		((Control)buttonCancel).set_Text("Cancel");
		((Control)labelNewColor).set_Location(new Point(256, 232));
		((Control)labelNewColor).set_Name("labelNewColor");
		((Control)labelNewColor).set_Size(new Size(44, 12));
		((Control)labelNewColor).set_TabIndex(4);
		((Control)labelNewColor).set_Text("New");
		labelNewColor.set_TextAlign((ContentAlignment)32);
		((Control)labelCurrentColor).set_Location(new Point(256, 306));
		((Control)labelCurrentColor).set_Name("labelCurrentColor");
		((Control)labelCurrentColor).set_Size(new Size(44, 16));
		((Control)labelCurrentColor).set_TabIndex(5);
		((Control)labelCurrentColor).set_Text("Current");
		labelCurrentColor.set_TextAlign((ContentAlignment)32);
		((Control)tabControl2).set_BackColor(Color.Transparent);
		tabControl2.CanReorderTabs = true;
		tabControl2.ColorScheme.TabBackground = Color.Transparent;
		((Control)tabControl2).get_Controls().Add((Control)(object)tabControlPanel2);
		((Control)tabControl2).get_Controls().Add((Control)(object)tabControlPanel1);
		tabControl2.FixedTabSize = new Size(60, 0);
		((Control)tabControl2).set_Location(new Point(8, 8));
		((Control)tabControl2).set_Name("tabControl2");
		tabControl2.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1);
		tabControl2.SelectedTabIndex = 0;
		((Control)tabControl2).set_Size(new Size(226, 314));
		tabControl2.Style = eTabStripStyle.VS2005;
		((Control)tabControl2).set_TabIndex(6);
		tabControl2.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
		tabControl2.Tabs.Add(tabItemStandard);
		tabControl2.Tabs.Add(tabItemCustom);
		tabControl2.ThemeAware = true;
		((Control)tabControlPanel1).get_Controls().Add((Control)(object)colorCombControl1);
		((Control)tabControlPanel1).get_Controls().Add((Control)(object)labelStandardColors);
		((Control)tabControlPanel1).set_Dock((DockStyle)5);
		((ScrollableControl)tabControlPanel1).get_DockPadding().set_All(1);
		((Control)tabControlPanel1).set_Location(new Point(0, 26));
		((Control)tabControlPanel1).set_Name("tabControlPanel1");
		((Control)tabControlPanel1).set_Size(new Size(226, 288));
		tabControlPanel1.Style.BackColor1.Color = SystemColors.Control;
		tabControlPanel1.Style.Border = eBorderType.SingleLine;
		tabControlPanel1.Style.BorderSide = eBorderSide.Left | eBorderSide.Right | eBorderSide.Bottom;
		tabControlPanel1.Style.GradientAngle = 90;
		((Control)tabControlPanel1).set_TabIndex(1);
		tabControlPanel1.TabItem = tabItemStandard;
		tabControlPanel1.ThemeAware = true;
		tabItemStandard.AttachedControl = (Control)(object)tabControlPanel1;
		tabItemStandard.CloseButtonBounds = new Rectangle(0, 0, 0, 0);
		tabItemStandard.Name = "tabItemStandard";
		tabItemStandard.Text = "Standard";
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)colorContrastControl1);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)numericGreen);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)labelGreen);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)numericRed);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)customColorBlender3);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)comboColorModel);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)labelRed);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)labelColorModel);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)numericBlue);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)labelBlue);
		((Control)tabControlPanel2).get_Controls().Add((Control)(object)labelCustomColors);
		((Control)tabControlPanel2).set_Dock((DockStyle)5);
		((ScrollableControl)tabControlPanel2).get_DockPadding().set_All(1);
		((Control)tabControlPanel2).set_Location(new Point(0, 26));
		((Control)tabControlPanel2).set_Name("tabControlPanel2");
		((Control)tabControlPanel2).set_Size(new Size(226, 288));
		tabControlPanel2.Style.BackColor1.Color = SystemColors.Control;
		tabControlPanel2.Style.Border = eBorderType.SingleLine;
		tabControlPanel2.Style.BorderSide = eBorderSide.Left | eBorderSide.Right | eBorderSide.Bottom;
		tabControlPanel2.Style.GradientAngle = 90;
		((Control)tabControlPanel2).set_TabIndex(2);
		tabControlPanel2.TabItem = tabItemCustom;
		tabControlPanel2.ThemeAware = true;
		((Control)colorContrastControl1).set_BackColor(Color.Transparent);
		((Control)colorContrastControl1).set_Location(new Point(188, 28));
		((Control)colorContrastControl1).set_Name("colorContrastControl1");
		colorContrastControl1.Color_0 = Color.FromArgb(255, 255, 255);
		((Control)colorContrastControl1).set_Size(new Size(32, 152));
		((Control)colorContrastControl1).set_TabIndex(12);
		colorContrastControl1.Event_0 += method_33;
		((Control)customColorBlender3).set_Location(new Point(8, 28));
		((Control)customColorBlender3).set_Name("customColorBlender3");
		((Control)customColorBlender3).set_Size(new Size(174, 152));
		((Control)customColorBlender3).set_TabIndex(3);
		customColorBlender3.Event_0 += method_31;
		comboColorModel.set_DropDownStyle((ComboBoxStyle)2);
		comboColorModel.get_Items().AddRange(new object[1] { "RGB" });
		((Control)comboColorModel).set_Location(new Point(84, 188));
		((Control)comboColorModel).set_Name("comboColorModel");
		((Control)comboColorModel).set_Size(new Size(89, 21));
		((Control)comboColorModel).set_TabIndex(5);
		((Control)labelRed).set_BackColor(Color.Transparent);
		((Control)labelRed).set_Location(new Point(4, 212));
		((Control)labelRed).set_Name("labelRed");
		((Control)labelRed).set_Size(new Size(76, 16));
		((Control)labelRed).set_TabIndex(6);
		((Control)labelRed).set_Text("&Red:");
		((Control)labelColorModel).set_BackColor(Color.Transparent);
		((Control)labelColorModel).set_Location(new Point(4, 192));
		((Control)labelColorModel).set_Name("labelColorModel");
		((Control)labelColorModel).set_Size(new Size(76, 16));
		((Control)labelColorModel).set_TabIndex(4);
		((Control)labelColorModel).set_Text("Color Mo&del:");
		tabItemCustom.AttachedControl = (Control)(object)tabControlPanel2;
		tabItemCustom.CloseButtonBounds = new Rectangle(0, 0, 0, 0);
		tabItemCustom.Name = "tabItemCustom";
		tabItemCustom.Text = "Custom";
		colorSelectionPreview.Color_1 = Color.Black;
		((Control)colorSelectionPreview).set_Location(new Point(252, 252));
		((Control)colorSelectionPreview).set_Name("colorSelectionPreview");
		colorSelectionPreview.Color_0 = Color.Empty;
		((Control)colorSelectionPreview).set_Size(new Size(56, 48));
		((Control)colorSelectionPreview).set_TabIndex(7);
		((Form)this).set_AcceptButton((IButtonControl)(object)buttonOK);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_CancelButton((IButtonControl)(object)buttonCancel);
		((Form)this).set_ClientSize(new Size(324, 326));
		((Control)this).get_Controls().Add((Control)(object)colorSelectionPreview);
		((Control)this).get_Controls().Add((Control)(object)tabControl2);
		((Control)this).get_Controls().Add((Control)(object)labelCurrentColor);
		((Control)this).get_Controls().Add((Control)(object)labelNewColor);
		((Control)this).get_Controls().Add((Control)(object)buttonCancel);
		((Control)this).get_Controls().Add((Control)(object)buttonOK);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("CustomColorDialog");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Colors");
		((Form)this).add_Load((EventHandler)CustomColorDialog_Load);
		((ISupportInitialize)numericBlue).EndInit();
		((ISupportInitialize)numericGreen).EndInit();
		((ISupportInitialize)numericRed).EndInit();
		((ISupportInitialize)tabControl2).EndInit();
		tabControl2.ResumeLayout(performLayout: false);
		((Control)tabControlPanel1).ResumeLayout(false);
		((Control)tabControlPanel2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);
		Size fixedTabSize = tabControl2.FixedTabSize;
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			Size size = Class55.smethod_3(val, tabItemCustom.Text, ((Control)this).get_Font());
			Size size2 = Class55.smethod_3(val, tabItemStandard.Text, ((Control)this).get_Font());
			fixedTabSize.Width = Math.Max(fixedTabSize.Width, size.Width + 5);
			fixedTabSize.Width = Math.Max(fixedTabSize.Width, size2.Width + 5);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		tabControl2.FixedTabSize = fixedTabSize;
		if (fixedTabSize.Width > ((Control)tabControl2).get_Width() / 2)
		{
			tabControl2.FixedTabSize = Size.Empty;
		}
	}

	internal void method_29(eDotNetBarStyle eDotNetBarStyle_0)
	{
		if (eDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			base.EnableCustomStyle = true;
			tabControl2.Style = eTabStripStyle.Office2007Dock;
		}
		else
		{
			base.EnableCustomStyle = false;
			tabControl2.Style = eTabStripStyle.VS2005;
		}
		((Control)tabControl2).set_BackColor(Color.Transparent);
		tabControl2.ColorScheme.TabBackground = Color.Transparent;
		tabControl2.ColorScheme.TabBackground2 = Color.Empty;
	}

	private void method_30(object sender, EventArgs e)
	{
		method_32(colorCombControl1.Color_0);
		colorContrastControl1.Color_0 = colorCombControl1.Color_0;
	}

	private void method_31(object sender, EventArgs e)
	{
		colorContrastControl1.Color_0 = customColorBlender3.Color_0;
		method_32(colorContrastControl1.Color_0);
	}

	private void method_32(Color color_2)
	{
		if (bool_10)
		{
			return;
		}
		bool_10 = true;
		try
		{
			color_1 = color_2;
			colorSelectionPreview.Color_0 = color_2;
			numericRed.set_Value((decimal)color_1.R);
			numericGreen.set_Value((decimal)color_1.G);
			numericBlue.set_Value((decimal)color_1.B);
		}
		finally
		{
			bool_10 = false;
		}
	}

	private void CustomColorDialog_Load(object sender, EventArgs e)
	{
		((ListControl)comboColorModel).set_SelectedIndex(0);
	}

	private void numericRed_ValueChanged(object sender, EventArgs e)
	{
		method_32(Color.FromArgb((int)numericRed.get_Value(), (int)numericGreen.get_Value(), (int)numericBlue.get_Value()));
	}

	private void method_33(object sender, EventArgs e)
	{
		method_32(colorContrastControl1.Color_0);
	}
}

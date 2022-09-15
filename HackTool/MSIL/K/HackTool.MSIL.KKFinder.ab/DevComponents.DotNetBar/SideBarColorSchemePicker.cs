using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
internal class SideBarColorSchemePicker : Form
{
	private ListBox listBox1;

	private Label label1;

	private Label label2;

	private Button button1;

	private Button button2;

	public eSideBarColorScheme SelectedColorScheme = eSideBarColorScheme.Blue;

	private SideBar sideBar1;

	private SideBarPanelItem sideBarPanelItem1;

	private ButtonItem buttonItem1;

	private ButtonItem buttonItem2;

	private ButtonItem buttonItem3;

	private ButtonItem buttonItem4;

	private SideBarPanelItem sideBarPanelItem2;

	private Container components;

	public SideBarColorSchemePicker()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected O, but got Unknown
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Expected O, but got Unknown
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected O, but got Unknown
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected O, but got Unknown
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected O, but got Unknown
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected O, but got Unknown
		//IL_0f23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2d: Expected O, but got Unknown
		//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f79: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(SideBarColorSchemePicker));
		listBox1 = new ListBox();
		label1 = new Label();
		label2 = new Label();
		button1 = new Button();
		button2 = new Button();
		sideBar1 = new SideBar();
		sideBarPanelItem1 = new SideBarPanelItem();
		buttonItem1 = new ButtonItem();
		buttonItem2 = new ButtonItem();
		buttonItem3 = new ButtonItem();
		buttonItem4 = new ButtonItem();
		sideBarPanelItem2 = new SideBarPanelItem();
		((Control)this).SuspendLayout();
		((Control)listBox1).set_Location(new Point(8, 24));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(152, 238));
		((Control)listBox1).set_TabIndex(1);
		listBox1.add_SelectedIndexChanged((EventHandler)listBox1_SelectedIndexChanged);
		((Control)label1).set_Location(new Point(8, 8));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(152, 16));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Available Color Schemes:");
		((Control)label2).set_Location(new Point(176, 8));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(208, 16));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Example of Color Scheme Applied:");
		button1.set_DialogResult((DialogResult)1);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)3);
		((Control)button1).set_Location(new Point(232, 272));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(72, 24));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("OK");
		button2.set_DialogResult((DialogResult)2);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)3);
		((Control)button2).set_Location(new Point(312, 272));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(72, 24));
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("Cancel");
		((Control)sideBar1).set_AccessibleRole((AccessibleRole)22);
		sideBar1.Appearance = eSideBarAppearance.Flat;
		sideBar1.BorderStyle = eBorderType.None;
		sideBar1.ColorScheme.BarBackground = Color.FromArgb(239, 237, 222);
		sideBar1.ColorScheme.BarBackground2 = Color.Empty;
		sideBar1.ColorScheme.BarCaptionBackground = Color.FromArgb(172, 168, 153);
		sideBar1.ColorScheme.BarCaptionInactiveBackground = SystemColors.Control;
		sideBar1.ColorScheme.BarCaptionInactiveText = SystemColors.ControlText;
		sideBar1.ColorScheme.BarCaptionText = Color.FromArgb(64, 64, 64);
		sideBar1.ColorScheme.BarDockedBorder = Color.Empty;
		sideBar1.ColorScheme.BarFloatingBorder = Color.FromArgb(172, 168, 153);
		sideBar1.ColorScheme.BarPopupBackground = Color.FromArgb(252, 252, 249);
		sideBar1.ColorScheme.BarPopupBorder = Color.FromArgb(138, 134, 122);
		sideBar1.ColorScheme.BarStripeColor = Color.FromArgb(191, 188, 177);
		sideBar1.ColorScheme.CustomizeBackground = Color.Empty;
		sideBar1.ColorScheme.CustomizeBackground2 = Color.Empty;
		sideBar1.ColorScheme.CustomizeText = Color.Empty;
		sideBar1.ColorScheme.ItemBackground = Color.Empty;
		sideBar1.ColorScheme.ItemCheckedBackground = Color.Empty;
		sideBar1.ColorScheme.ItemCheckedBackground2 = Color.Empty;
		sideBar1.ColorScheme.ItemCheckedBorder = Color.FromArgb(0, 0, 128);
		sideBar1.ColorScheme.ItemCheckedText = Color.Black;
		sideBar1.ColorScheme.ItemDesignTimeBorder = SystemColors.Highlight;
		sideBar1.ColorScheme.ItemDisabledBackground = Color.Empty;
		sideBar1.ColorScheme.ItemDisabledText = SystemColors.ControlDark;
		sideBar1.ColorScheme.ItemExpandedBackground = Color.FromArgb(254, 142, 75);
		sideBar1.ColorScheme.ItemExpandedBackground2 = Color.FromArgb(255, 207, 139);
		sideBar1.ColorScheme.ItemExpandedShadow = Color.Empty;
		sideBar1.ColorScheme.ItemExpandedText = Color.Black;
		sideBar1.ColorScheme.ItemHotBackground = Color.FromArgb(255, 244, 204);
		sideBar1.ColorScheme.ItemHotBackground2 = Color.FromArgb(255, 209, 147);
		sideBar1.ColorScheme.ItemHotBorder = Color.FromArgb(0, 0, 128);
		sideBar1.ColorScheme.ItemHotText = Color.Black;
		sideBar1.ColorScheme.ItemPressedBackground = Color.FromArgb(254, 142, 75);
		sideBar1.ColorScheme.ItemPressedBackground2 = Color.FromArgb(255, 207, 139);
		sideBar1.ColorScheme.ItemPressedBorder = Color.FromArgb(0, 0, 128);
		sideBar1.ColorScheme.ItemPressedText = Color.Black;
		sideBar1.ColorScheme.ItemSeparator = Color.FromArgb(197, 194, 184);
		sideBar1.ColorScheme.ItemSeparatorShade = Color.Empty;
		sideBar1.ColorScheme.ItemText = Color.Black;
		sideBar1.ColorScheme.MenuBackground = Color.FromArgb(232, 232, 232);
		sideBar1.ColorScheme.MenuBackground2 = Color.White;
		sideBar1.ColorScheme.MenuBarBackground = SystemColors.Control;
		sideBar1.ColorScheme.MenuBarBackground2 = Color.Empty;
		sideBar1.ColorScheme.MenuBorder = Color.FromArgb(0, 0, 128);
		sideBar1.ColorScheme.MenuSide = Color.FromArgb(94, 137, 207);
		sideBar1.ColorScheme.MenuSide2 = Color.Empty;
		sideBar1.ColorScheme.MenuUnusedBackground = Color.FromArgb(252, 252, 249);
		sideBar1.ColorScheme.MenuUnusedSide = Color.FromArgb(230, 227, 210);
		sideBar1.ColorScheme.MenuUnusedSide2 = Color.Empty;
		sideBar1.ExpandedPanel = sideBarPanelItem1;
		((Control)sideBar1).set_Font(new Font("Tahoma", 11f, (FontStyle)0, (GraphicsUnit)0));
		((Control)sideBar1).set_Location(new Point(176, 24));
		((Control)sideBar1).set_Name("sideBar1");
		sideBar1.Panels.AddRange(new BaseItem[2] { sideBarPanelItem1, sideBarPanelItem2 });
		((Control)sideBar1).set_Size(new Size(208, 240));
		((Control)sideBar1).set_TabIndex(6);
		((Control)sideBar1).set_TabStop(false);
		sideBarPanelItem1.BackgroundStyle.BackColor1.Color = Color.FromArgb(232, 232, 232);
		sideBarPanelItem1.BackgroundStyle.BackColor2.Color = Color.White;
		sideBarPanelItem1.BackgroundStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem1.BackgroundStyle.BorderColor.Color = Color.FromArgb(59, 97, 156);
		sideBarPanelItem1.HeaderHotStyle.BackColor1.Color = Color.FromArgb(133, 171, 228);
		sideBarPanelItem1.HeaderHotStyle.BackColor2.Color = Color.FromArgb(221, 236, 254);
		sideBarPanelItem1.HeaderHotStyle.GradientAngle = 90;
		sideBarPanelItem1.HeaderSideHotStyle.BackColor1.Color = Color.FromArgb(133, 171, 228);
		sideBarPanelItem1.HeaderSideHotStyle.BackColor2.Color = Color.FromArgb(221, 236, 254);
		sideBarPanelItem1.HeaderSideHotStyle.GradientAngle = 90;
		sideBarPanelItem1.HeaderSideStyle.BackColor1.Color = Color.FromArgb(200, 220, 248);
		sideBarPanelItem1.HeaderSideStyle.BackColor2.Color = Color.FromArgb(94, 137, 207);
		sideBarPanelItem1.HeaderSideStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem1.HeaderSideStyle.BorderColor.Color = Color.FromArgb(59, 97, 156);
		sideBarPanelItem1.HeaderSideStyle.BorderSide = eBorderSide.Left | eBorderSide.Top | eBorderSide.Bottom;
		sideBarPanelItem1.HeaderSideStyle.GradientAngle = 90;
		sideBarPanelItem1.HeaderStyle.BackColor1.Color = Color.FromArgb(221, 236, 254);
		sideBarPanelItem1.HeaderStyle.BackColor2.Color = Color.FromArgb(133, 171, 228);
		sideBarPanelItem1.HeaderStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem1.HeaderStyle.BorderColor.Color = Color.FromArgb(59, 97, 156);
		sideBarPanelItem1.HeaderStyle.BorderSide = eBorderSide.Right | eBorderSide.Top | eBorderSide.Bottom;
		sideBarPanelItem1.HeaderStyle.Font = new Font("Arial", 9f, (FontStyle)1);
		sideBarPanelItem1.HeaderStyle.ForeColor.Color = Color.FromArgb(0, 51, 102);
		sideBarPanelItem1.HeaderStyle.GradientAngle = 90;
		sideBarPanelItem1.Icon = (Icon)resourceManager.GetObject("sideBarPanelItem1.Icon");
		sideBarPanelItem1.Name = "sideBarPanelItem1";
		sideBarPanelItem1.SubItems.AddRange(new BaseItem[4] { buttonItem1, buttonItem2, buttonItem3, buttonItem4 });
		sideBarPanelItem1.Text = "My Mail Folders";
		buttonItem1.Icon = (Icon)resourceManager.GetObject("buttonItem1.Icon");
		buttonItem1.Name = "buttonItem1";
		buttonItem1.Text = "Inbox";
		buttonItem2.Icon = (Icon)resourceManager.GetObject("buttonItem2.Icon");
		buttonItem2.Name = "buttonItem2";
		buttonItem2.Text = "Sent Items";
		buttonItem3.Icon = (Icon)resourceManager.GetObject("buttonItem3.Icon");
		buttonItem3.Name = "buttonItem3";
		buttonItem3.Text = "Blocked Junk E-Mail";
		buttonItem4.BeginGroup = true;
		buttonItem4.Icon = (Icon)resourceManager.GetObject("buttonItem4.Icon");
		buttonItem4.Name = "buttonItem4";
		buttonItem4.Text = "Actions";
		sideBarPanelItem2.BackgroundStyle.BackColor1.Color = Color.FromArgb(232, 232, 232);
		sideBarPanelItem2.BackgroundStyle.BackColor2.Color = Color.White;
		sideBarPanelItem2.BackgroundStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem2.BackgroundStyle.BorderColor.Color = Color.FromArgb(59, 97, 156);
		sideBarPanelItem2.HeaderHotStyle.BackColor1.Color = Color.FromArgb(133, 171, 228);
		sideBarPanelItem2.HeaderHotStyle.BackColor2.Color = Color.FromArgb(221, 236, 254);
		sideBarPanelItem2.HeaderHotStyle.GradientAngle = 90;
		sideBarPanelItem2.HeaderSideHotStyle.BackColor1.Color = Color.FromArgb(133, 171, 228);
		sideBarPanelItem2.HeaderSideHotStyle.BackColor2.Color = Color.FromArgb(221, 236, 254);
		sideBarPanelItem2.HeaderSideHotStyle.GradientAngle = 90;
		sideBarPanelItem2.HeaderSideStyle.BackColor1.Color = Color.FromArgb(200, 220, 248);
		sideBarPanelItem2.HeaderSideStyle.BackColor2.Color = Color.FromArgb(94, 137, 207);
		sideBarPanelItem2.HeaderSideStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem2.HeaderSideStyle.BorderColor.Color = Color.FromArgb(59, 97, 156);
		sideBarPanelItem2.HeaderSideStyle.BorderSide = eBorderSide.Left | eBorderSide.Top | eBorderSide.Bottom;
		sideBarPanelItem2.HeaderSideStyle.GradientAngle = 90;
		sideBarPanelItem2.HeaderStyle.BackColor1.Color = Color.FromArgb(221, 236, 254);
		sideBarPanelItem2.HeaderStyle.BackColor2.Color = Color.FromArgb(133, 171, 228);
		sideBarPanelItem2.HeaderStyle.Border = eBorderType.SingleLine;
		sideBarPanelItem2.HeaderStyle.BorderColor.Color = Color.FromArgb(59, 97, 156);
		sideBarPanelItem2.HeaderStyle.BorderSide = eBorderSide.Right | eBorderSide.Top | eBorderSide.Bottom;
		sideBarPanelItem2.HeaderStyle.Font = new Font("Arial", 9f, (FontStyle)1);
		sideBarPanelItem2.HeaderStyle.ForeColor.Color = Color.FromArgb(0, 51, 102);
		sideBarPanelItem2.HeaderStyle.GradientAngle = 90;
		sideBarPanelItem2.Icon = (Icon)resourceManager.GetObject("sideBarPanelItem2.Icon");
		sideBarPanelItem2.Name = "sideBarPanelItem2";
		sideBarPanelItem2.Text = "My Calendar";
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(392, 304));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[6]
		{
			sideBar1,
			(Control)button2,
			(Control)button1,
			(Control)label2,
			(Control)label1,
			(Control)listBox1
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("SideBarColorSchemePicker");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("SideBar Color Scheme Picker");
		((Form)this).add_Closing((CancelEventHandler)SideBarColorSchemePicker_Closing);
		((Form)this).add_Load((EventHandler)SideBarColorSchemePicker_Load);
		((Control)this).ResumeLayout(false);
	}

	private void SideBarColorSchemePicker_Load(object sender, EventArgs e)
	{
		string[] names = Enum.GetNames(typeof(eSideBarColorScheme));
		foreach (string text in names)
		{
			listBox1.get_Items().Add((object)text);
		}
		((ListControl)listBox1).set_SelectedIndex(0);
	}

	private void SideBarColorSchemePicker_Closing(object sender, CancelEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (((ListControl)listBox1).get_SelectedIndex() < 0 && (int)((Form)this).get_DialogResult() == 1)
		{
			e.Cancel = true;
			MessageBox.Show("Please select color scheme to apply.", "Color Scheme Picker", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox1).get_SelectedIndex() >= 0)
		{
			string value = listBox1.get_SelectedItem().ToString();
			eSideBarColorScheme predefinedColorScheme = (SelectedColorScheme = (eSideBarColorScheme)Enum.Parse(typeof(eSideBarColorScheme), value, ignoreCase: false));
			sideBar1.PredefinedColorScheme = predefinedColorScheme;
		}
	}
}

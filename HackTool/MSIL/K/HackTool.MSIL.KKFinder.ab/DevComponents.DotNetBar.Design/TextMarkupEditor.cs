using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Design;

[ToolboxItem(false)]
public class TextMarkupEditor : PanelEx
{
	public Button buttonCancel;

	public Button buttonOK;

	private Timer timer_0;

	private PanelEx previewPanel;

	public TextBox inputText;

	private Label label2;

	private IContainer icontainer_0;

	private Bar bar1;

	private ButtonItem buttonBold;

	private ButtonItem buttonItalic;

	private ButtonItem buttonUnderline;

	private ColorPickerDropDown buttonColor;

	private SuperTooltipControl superTooltipControl_0;

	public TextMarkupEditor()
	{
		InitializeComponent();
		base.ColorSchemeStyle = eDotNetBarStyle.Office2007;
		ApplyLabelStyle();
		base.Style.BorderColor.ColorSchemePart = eColorSchemePart.BarDockedBorder;
		base.Style.Border = eBorderType.SingleLine;
		((Panel)this).set_TabStop(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		icontainer_0 = new Container();
		inputText = new TextBox();
		previewPanel = new PanelEx();
		buttonCancel = new Button();
		buttonOK = new Button();
		timer_0 = new Timer(icontainer_0);
		label2 = new Label();
		bar1 = new Bar();
		buttonBold = new ButtonItem();
		buttonItalic = new ButtonItem();
		buttonUnderline = new ButtonItem();
		buttonColor = new ColorPickerDropDown();
		((ISupportInitialize)bar1).BeginInit();
		((Control)this).SuspendLayout();
		inputText.set_AcceptsReturn(true);
		((Control)inputText).set_Anchor((AnchorStyles)15);
		((Control)inputText).set_Location(new Point(8, 8));
		((TextBoxBase)inputText).set_Multiline(true);
		((Control)inputText).set_Name("inputText");
		((Control)inputText).set_Size(new Size(332, 110));
		((Control)inputText).set_TabIndex(0);
		((Control)inputText).add_TextChanged((EventHandler)inputText_TextChanged);
		((Control)previewPanel).set_Anchor((AnchorStyles)14);
		((ScrollableControl)previewPanel).set_AutoScroll(true);
		previewPanel.CanvasColor = SystemColors.Control;
		((Control)previewPanel).set_Location(new Point(8, 152));
		((Control)previewPanel).set_Name("previewPanel");
		((Control)previewPanel).set_Size(new Size(332, 75));
		previewPanel.Style.BackColor1.Color = Color.White;
		previewPanel.Style.BackgroundImagePosition = eBackgroundImagePosition.Tile;
		previewPanel.Style.Border = eBorderType.SingleLine;
		previewPanel.Style.BorderColor.Color = Color.DarkGray;
		previewPanel.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
		previewPanel.Style.GradientAngle = 90;
		previewPanel.Style.LineAlignment = (StringAlignment)0;
		((Control)previewPanel).set_TabIndex(1);
		((Control)buttonCancel).set_Anchor((AnchorStyles)10);
		buttonCancel.set_DialogResult((DialogResult)2);
		((ButtonBase)buttonCancel).set_FlatStyle((FlatStyle)3);
		((Control)buttonCancel).set_Location(new Point(269, 233));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(71, 24));
		((Control)buttonCancel).set_TabIndex(4);
		((Control)buttonCancel).set_Text("Cancel");
		((Control)buttonCancel).add_Click((EventHandler)buttonCancel_Click);
		((Control)buttonOK).set_Anchor((AnchorStyles)10);
		buttonOK.set_DialogResult((DialogResult)1);
		((ButtonBase)buttonOK).set_FlatStyle((FlatStyle)3);
		((Control)buttonOK).set_Location(new Point(194, 233));
		((Control)buttonOK).set_Name("buttonOK");
		((Control)buttonOK).set_Size(new Size(71, 24));
		((Control)buttonOK).set_TabIndex(3);
		((Control)buttonOK).set_Text("OK");
		((Control)buttonOK).add_Click((EventHandler)buttonOK_Click);
		timer_0.set_Interval(1000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)label2).set_Anchor((AnchorStyles)10);
		((Control)label2).set_BackColor(Color.WhiteSmoke);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(316, 133));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(24, 16));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("?");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)label2).add_MouseLeave((EventHandler)label2_MouseLeave);
		((Control)label2).add_MouseEnter((EventHandler)label2_MouseEnter);
		bar1.Items.AddRange(new BaseItem[4] { buttonBold, buttonItalic, buttonUnderline, buttonColor });
		bar1.Location = new Point(8, 124);
		bar1.Name = "bar1";
		bar1.Size = new Size(174, 25);
		bar1.Style = eDotNetBarStyle.Office2007;
		bar1.TabIndex = 6;
		bar1.TabStop = false;
		((Control)bar1).set_Text("bar1");
		buttonBold.Name = "buttonBold";
		buttonBold.Shortcuts.Add(eShortcut.CtrlB);
		buttonBold.Text = "Bold";
		buttonBold.Click += buttonBold_Click;
		buttonItalic.Name = "buttonItalic";
		buttonItalic.Shortcuts.Add(eShortcut.CtrlI);
		buttonItalic.Text = "Italic";
		buttonItalic.Click += buttonItalic_Click;
		buttonUnderline.Name = "buttonUnderline";
		buttonUnderline.Shortcuts.Add(eShortcut.CtrlU);
		buttonUnderline.Text = "Underline";
		buttonUnderline.Click += buttonUnderline_Click;
		buttonColor.Name = "buttonColor";
		buttonColor.Tooltip = "Sets the text color";
		buttonColor.Image = (Image)(object)Class109.smethod_67("SystemImages.ColorPickerButtonImage.png");
		buttonColor.SelectedColorImageRectangle = new Rectangle(2, 2, 12, 12);
		buttonColor.Click += buttonColor_Click;
		((Control)this).get_Controls().Add((Control)(object)bar1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)buttonOK);
		((Control)this).get_Controls().Add((Control)(object)buttonCancel);
		((Control)this).get_Controls().Add((Control)(object)previewPanel);
		((Control)this).get_Controls().Add((Control)(object)inputText);
		((Control)this).set_Name("TextMarkupEditor");
		((Control)this).set_Size(new Size(348, 263));
		((ISupportInitialize)bar1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		method_10();
		base.DialogResult = (DialogResult)2;
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		method_10();
		base.DialogResult = (DialogResult)1;
	}

	private void inputText_TextChanged(object sender, EventArgs e)
	{
		timer_0.Stop();
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		method_9();
	}

	private void method_9()
	{
		((Control)previewPanel).set_Text(((Control)inputText).get_Text());
	}

	protected override void OnGotFocus(EventArgs e)
	{
		base.OnGotFocus(e);
		((Control)inputText).Focus();
	}

	private void label2_MouseEnter(object sender, EventArgs e)
	{
		method_10();
		superTooltipControl_0 = new SuperTooltipControl();
		superTooltipControl_0.AntiAlias = false;
		SuperTooltipInfo superTooltipInfo = new SuperTooltipInfo();
		superTooltipInfo.HeaderText = "Markup tags available";
		superTooltipInfo.BodyText = "<b>b</b> - Bold <br/><b>i</b> - Italic <br/><b>u</b> - Underline <br/><b>p</b> - Paragraph container, <b>width</b> attribute indicates width of block element <br/><b>div</b> - Block-level container, <b>width</b> attribute indicates width of block element<br/><b>span</b> - Inline container, <b>width</b> attribute indicates width of block element. Can be used to create tables<br/><b>br</b> - Line break<br/><b>font</b> - Changes font, color, size. <b>size</b> attribute indicates absolute or relative font size. <b>color</b> attribute to change the colorYou can use relative sizing for example +1 to increase font size by one point or -1 to decrease by one point. <b>face</b> attribute can be employed to set the specific font name to use.<br/><b>h1</b> - Header markup. You can use h1, h2, h3, h4, h5, h6 to represent header sizes<br/><b>a</b> - Denotes hypertext link. <b>href</b> and <b>name</b> attributes are supported<br/><b>expand</b> - Displays the expand part of the button<br/>All tags must be lower case and they must be well formed i.e. each tag must be closed with end tag or be an empty tag.";
		superTooltipInfo.Color = eTooltipColor.Default;
		Point point = ((Control)label2).PointToScreen(new Point(0, ((Control)label2).get_Height() + 1));
		superTooltipControl_0.ShowTooltip(superTooltipInfo, point.X, point.Y, enforceScreenPosition: true);
	}

	private void method_10()
	{
		if (superTooltipControl_0 != null)
		{
			((Control)superTooltipControl_0).Hide();
			((Component)(object)superTooltipControl_0).Dispose();
			superTooltipControl_0 = null;
		}
	}

	private void label2_MouseLeave(object sender, EventArgs e)
	{
		method_10();
	}

	private void buttonBold_Click(object sender, EventArgs e)
	{
		method_11("<b>", "</b>");
	}

	private void buttonItalic_Click(object sender, EventArgs e)
	{
		method_11("<i>", "</i>");
	}

	private void buttonUnderline_Click(object sender, EventArgs e)
	{
		method_11("<u>", "</u>");
	}

	private void buttonColor_Click(object sender, EventArgs e)
	{
		method_11("<font color=\"" + method_12(buttonColor.SelectedColor) + "\">", "</font>");
	}

	private void method_11(string string_1, string string_2)
	{
		if (((TextBoxBase)inputText).get_SelectionLength() == 0)
		{
			((TextBoxBase)inputText).set_SelectedText(string_1 + string_2);
		}
		else
		{
			((TextBoxBase)inputText).set_SelectedText(string_1 + ((TextBoxBase)inputText).get_SelectedText() + string_2);
		}
		method_9();
	}

	private string method_12(Color color_1)
	{
		return "#" + color_1.R.ToString("X02") + color_1.G.ToString("X02") + color_1.B.ToString("X02");
	}
}

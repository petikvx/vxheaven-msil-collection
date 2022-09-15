using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

[ToolboxItem(false)]
public class SuperTooltipVisualEditor : UserControl
{
	private IContainer icontainer_0;

	private PanelEx panelEx1;

	internal ButtonX buttonOK;

	internal ButtonX buttonCancel;

	private CheckBox footerVisible;

	private CheckBox headerVisible;

	private TextBox textFooter;

	private TextBox textBody;

	private TextBox textHeader;

	private PanelEx panelBodyImage;

	private PanelEx panelEx5;

	private ComboBox comboColors;

	private Label label1;

	private PanelEx panelFooterImage;

	private CheckBox checkCustomSize;

	private NumericUpDown customHeight;

	private NumericUpDown customWidth;

	private Label label2;

	private SuperTooltipInfo superTooltipInfo_0;

	private bool bool_0;

	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	private bool bool_1;

	private bool bool_2;

	private SuperTooltipControl superTooltipControl_0;

	private PanelEx resetBodyImage;

	private PanelEx resetFooterImage;

	private SuperTooltip superTooltip_0;

	private CustomTypeEditorProvider customTypeEditorProvider_0;

	private Font font_0;

	internal int int_0;

	private SuperTooltip superTooltip_1;

	public CustomTypeEditorProvider EditorProvider
	{
		get
		{
			return customTypeEditorProvider_0;
		}
		set
		{
			customTypeEditorProvider_0 = value;
		}
	}

	public SuperTooltipInfo SuperTooltipInfo
	{
		get
		{
			SuperTooltipInfo superTooltipInfo = new SuperTooltipInfo();
			method_1(superTooltipInfo);
			return superTooltipInfo;
		}
		set
		{
			superTooltipInfo_0 = value;
			method_0();
		}
	}

	public IWindowsFormsEditorService EditorService
	{
		get
		{
			return iwindowsFormsEditorService_0;
		}
		set
		{
			iwindowsFormsEditorService_0 = value;
		}
	}

	public bool Canceled => bool_0;

	public SuperTooltip ParentSuperTooltip
	{
		get
		{
			return superTooltip_1;
		}
		set
		{
			superTooltip_1 = value;
		}
	}

	public SuperTooltipVisualEditor()
	{
		InitializeComponent();
		panelBodyImage.Style.BackgroundImage = (Image)(object)Class109.smethod_67("SystemImages.ImagePlaceHolder.png");
		panelFooterImage.Style.BackgroundImage = (Image)(object)Class109.smethod_67("SystemImages.ImagePlaceHolder16x16.png");
		comboColors.get_Items().AddRange((object[])Enum.GetNames(typeof(eTooltipColor)));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_1360: Unknown result type (might be due to invalid IL or missing references)
		//IL_136a: Expected O, but got Unknown
		panelEx1 = new PanelEx();
		resetFooterImage = new PanelEx();
		resetBodyImage = new PanelEx();
		customWidth = new NumericUpDown();
		customHeight = new NumericUpDown();
		label2 = new Label();
		checkCustomSize = new CheckBox();
		panelFooterImage = new PanelEx();
		comboColors = new ComboBox();
		label1 = new Label();
		panelEx5 = new PanelEx();
		panelBodyImage = new PanelEx();
		textFooter = new TextBox();
		textBody = new TextBox();
		textHeader = new TextBox();
		footerVisible = new CheckBox();
		headerVisible = new CheckBox();
		buttonCancel = new ButtonX();
		buttonOK = new ButtonX();
		superTooltip_0 = new SuperTooltip();
		((Control)panelEx1).SuspendLayout();
		((ISupportInitialize)customWidth).BeginInit();
		((ISupportInitialize)customHeight).BeginInit();
		((Control)this).SuspendLayout();
		panelEx1.AntiAlias = true;
		panelEx1.CanvasColor = SystemColors.Control;
		((Control)panelEx1).get_Controls().Add((Control)(object)resetFooterImage);
		((Control)panelEx1).get_Controls().Add((Control)(object)resetBodyImage);
		((Control)panelEx1).get_Controls().Add((Control)(object)customWidth);
		((Control)panelEx1).get_Controls().Add((Control)(object)customHeight);
		((Control)panelEx1).get_Controls().Add((Control)(object)label2);
		((Control)panelEx1).get_Controls().Add((Control)(object)checkCustomSize);
		((Control)panelEx1).get_Controls().Add((Control)(object)panelFooterImage);
		((Control)panelEx1).get_Controls().Add((Control)(object)comboColors);
		((Control)panelEx1).get_Controls().Add((Control)(object)label1);
		((Control)panelEx1).get_Controls().Add((Control)(object)panelEx5);
		((Control)panelEx1).get_Controls().Add((Control)(object)panelBodyImage);
		((Control)panelEx1).get_Controls().Add((Control)(object)textFooter);
		((Control)panelEx1).get_Controls().Add((Control)(object)textBody);
		((Control)panelEx1).get_Controls().Add((Control)(object)textHeader);
		((Control)panelEx1).get_Controls().Add((Control)(object)footerVisible);
		((Control)panelEx1).get_Controls().Add((Control)(object)headerVisible);
		((Control)panelEx1).get_Controls().Add((Control)(object)buttonCancel);
		((Control)panelEx1).get_Controls().Add((Control)(object)buttonOK);
		((Control)panelEx1).set_Dock((DockStyle)5);
		((Control)panelEx1).set_Location(new Point(0, 0));
		((Control)panelEx1).set_Name("panelEx1");
		((Control)panelEx1).set_Size(new Size(432, 320));
		panelEx1.Style.Alignment = (StringAlignment)1;
		panelEx1.Style.BackColor1.Color = Color.WhiteSmoke;
		panelEx1.Style.BackColor2.Color = Color.White;
		panelEx1.Style.BackgroundImagePosition = eBackgroundImagePosition.Tile;
		panelEx1.Style.Border = eBorderType.SingleLine;
		panelEx1.Style.BorderColor.Color = Color.DimGray;
		panelEx1.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
		panelEx1.Style.GradientAngle = 90;
		((Control)panelEx1).set_TabIndex(1);
		((Control)resetFooterImage).set_Anchor((AnchorStyles)6);
		resetFooterImage.AntiAlias = true;
		resetFooterImage.CanvasColor = SystemColors.Control;
		resetFooterImage.DialogResult = (DialogResult)1;
		((Control)resetFooterImage).set_Location(new Point(29, 230));
		((Control)resetFooterImage).set_Name("resetFooterImage");
		((Control)resetFooterImage).set_Size(new Size(73, 20));
		resetFooterImage.Style.Alignment = (StringAlignment)1;
		resetFooterImage.Style.BackColor1.Color = Color.Gainsboro;
		resetFooterImage.Style.BackColor2.Color = Color.WhiteSmoke;
		resetFooterImage.Style.BackgroundImagePosition = eBackgroundImagePosition.Tile;
		resetFooterImage.Style.Border = eBorderType.SingleLine;
		resetFooterImage.Style.BorderColor.Color = Color.Gray;
		resetFooterImage.Style.CornerType = eCornerType.Rounded;
		resetFooterImage.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
		resetFooterImage.Style.GradientAngle = 90;
		resetFooterImage.StyleMouseDown.Alignment = (StringAlignment)1;
		resetFooterImage.StyleMouseDown.BackColor1.ColorSchemePart = eColorSchemePart.ItemPressedBackground;
		resetFooterImage.StyleMouseDown.BackColor2.ColorSchemePart = eColorSchemePart.ItemPressedBackground2;
		resetFooterImage.StyleMouseDown.BorderColor.ColorSchemePart = eColorSchemePart.ItemPressedBorder;
		resetFooterImage.StyleMouseDown.CornerType = eCornerType.Rounded;
		resetFooterImage.StyleMouseDown.ForeColor.ColorSchemePart = eColorSchemePart.ItemPressedText;
		resetFooterImage.StyleMouseOver.Alignment = (StringAlignment)1;
		resetFooterImage.StyleMouseOver.BackColor1.ColorSchemePart = eColorSchemePart.ItemHotBackground;
		resetFooterImage.StyleMouseOver.BackColor2.ColorSchemePart = eColorSchemePart.ItemHotBackground2;
		resetFooterImage.StyleMouseOver.BorderColor.ColorSchemePart = eColorSchemePart.ItemHotBorder;
		resetFooterImage.StyleMouseOver.CornerType = eCornerType.Rounded;
		resetFooterImage.StyleMouseOver.ForeColor.ColorSchemePart = eColorSchemePart.ItemHotText;
		superTooltip_0.SetSuperTooltip((IComponent)resetFooterImage, new SuperTooltipInfo("Reset footer image", "", "Click to reset footer image.", null, null, eTooltipColor.Lemon, headerVisible: true, footerVisible: false, new Size(0, 0)));
		((Control)resetFooterImage).set_TabIndex(17);
		((Control)resetFooterImage).set_Text("Reset Image");
		((Control)resetFooterImage).add_Click((EventHandler)resetFooterImage_Click);
		resetBodyImage.AntiAlias = true;
		resetBodyImage.CanvasColor = SystemColors.Control;
		resetBodyImage.DialogResult = (DialogResult)1;
		((Control)resetBodyImage).set_Location(new Point(7, 60));
		((Control)resetBodyImage).set_Name("resetBodyImage");
		((Control)resetBodyImage).set_Size(new Size(95, 20));
		resetBodyImage.Style.Alignment = (StringAlignment)1;
		resetBodyImage.Style.BackColor1.Color = Color.Gainsboro;
		resetBodyImage.Style.BackColor2.Color = Color.WhiteSmoke;
		resetBodyImage.Style.BackgroundImagePosition = eBackgroundImagePosition.Tile;
		resetBodyImage.Style.Border = eBorderType.SingleLine;
		resetBodyImage.Style.BorderColor.Color = Color.Gray;
		resetBodyImage.Style.CornerType = eCornerType.Rounded;
		resetBodyImage.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
		resetBodyImage.Style.GradientAngle = 90;
		resetBodyImage.StyleMouseDown.Alignment = (StringAlignment)1;
		resetBodyImage.StyleMouseDown.BackColor1.ColorSchemePart = eColorSchemePart.ItemPressedBackground;
		resetBodyImage.StyleMouseDown.BackColor2.ColorSchemePart = eColorSchemePart.ItemPressedBackground2;
		resetBodyImage.StyleMouseDown.BorderColor.ColorSchemePart = eColorSchemePart.ItemPressedBorder;
		resetBodyImage.StyleMouseDown.CornerType = eCornerType.Rounded;
		resetBodyImage.StyleMouseDown.ForeColor.ColorSchemePart = eColorSchemePart.ItemPressedText;
		resetBodyImage.StyleMouseOver.Alignment = (StringAlignment)1;
		resetBodyImage.StyleMouseOver.BackColor1.ColorSchemePart = eColorSchemePart.ItemHotBackground;
		resetBodyImage.StyleMouseOver.BackColor2.ColorSchemePart = eColorSchemePart.ItemHotBackground2;
		resetBodyImage.StyleMouseOver.BorderColor.ColorSchemePart = eColorSchemePart.ItemHotBorder;
		resetBodyImage.StyleMouseOver.CornerType = eCornerType.Rounded;
		resetBodyImage.StyleMouseOver.ForeColor.ColorSchemePart = eColorSchemePart.ItemHotText;
		superTooltip_0.SetSuperTooltip((IComponent)resetBodyImage, new SuperTooltipInfo("Reset Body Image", "", "Click to reset body image.", null, null, eTooltipColor.Lemon, headerVisible: true, footerVisible: false, new Size(0, 0)));
		((Control)resetBodyImage).set_TabIndex(16);
		((Control)resetBodyImage).set_Text("Reset Image");
		((Control)resetBodyImage).add_Click((EventHandler)resetBodyImage_Click);
		((Control)customWidth).set_Anchor((AnchorStyles)6);
		((Control)customWidth).set_Enabled(false);
		((Control)customWidth).set_Location(new Point(107, 256));
		customWidth.set_Maximum(new decimal(new int[4] { 10000, 0, 0, 0 }));
		customWidth.set_Minimum(new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)customWidth).set_Name("customWidth");
		((Control)customWidth).set_Size(new Size(52, 21));
		((Control)customWidth).set_TabIndex(13);
		customWidth.set_Value(new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)customHeight).set_Anchor((AnchorStyles)6);
		((Control)customHeight).set_Enabled(false);
		((Control)customHeight).set_Location(new Point(174, 256));
		customHeight.set_Maximum(new decimal(new int[4] { 10000, 0, 0, 0 }));
		NumericUpDown obj = customHeight;
		int[] bits = new int[4];
		obj.set_Minimum(new decimal(bits));
		((Control)customHeight).set_Name("customHeight");
		((Control)customHeight).set_Size(new Size(52, 21));
		((Control)customHeight).set_TabIndex(14);
		customHeight.set_Value(new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)label2).set_Anchor((AnchorStyles)6);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(160, 258));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(13, 13));
		((Control)label2).set_TabIndex(15);
		((Control)label2).set_Text("x");
		((Control)checkCustomSize).set_Anchor((AnchorStyles)6);
		((Control)checkCustomSize).set_Location(new Point(7, 260));
		((Control)checkCustomSize).set_Name("checkCustomSize");
		((Control)checkCustomSize).set_Size(new Size(83, 17));
		((Control)checkCustomSize).set_TabIndex(12);
		((Control)checkCustomSize).set_Text("Custom size");
		checkCustomSize.add_CheckedChanged((EventHandler)checkCustomSize_CheckedChanged);
		((Control)panelFooterImage).set_Anchor((AnchorStyles)6);
		panelFooterImage.AntiAlias = true;
		panelFooterImage.CanvasColor = SystemColors.Control;
		((Control)panelFooterImage).set_Location(new Point(76, 203));
		((Control)panelFooterImage).set_Name("panelFooterImage");
		((Control)panelFooterImage).set_Size(new Size(24, 24));
		panelFooterImage.Style.Alignment = (StringAlignment)1;
		panelFooterImage.Style.BackColor1.Color = Color.White;
		panelFooterImage.Style.BackColor2.Color = Color.White;
		panelFooterImage.Style.BackgroundImagePosition = eBackgroundImagePosition.Center;
		panelFooterImage.Style.Border = eBorderType.SingleLine;
		panelFooterImage.Style.BorderColor.Color = Color.DimGray;
		panelFooterImage.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
		panelFooterImage.Style.GradientAngle = 90;
		superTooltip_0.SetSuperTooltip((IComponent)panelFooterImage, new SuperTooltipInfo("Click to set footer image", "", "Allows you to choose footer image. Note that image displayed here is preview image. You can see tooltip preview below.", null, null, eTooltipColor.Lemon, headerVisible: true, footerVisible: false, new Size(280, 170)));
		((Control)panelFooterImage).set_TabIndex(11);
		((Control)panelFooterImage).add_Click((EventHandler)panelFooterImage_Click);
		((Control)comboColors).set_Anchor((AnchorStyles)13);
		comboColors.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboColors).set_Location(new Point(107, 6));
		((Control)comboColors).set_Name("comboColors");
		((Control)comboColors).set_Size(new Size(316, 21));
		comboColors.set_Sorted(true);
		((Control)comboColors).set_TabIndex(10);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(4, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(96, 13));
		((Control)label1).set_TabIndex(9);
		((Control)label1).set_Text("Predefined Colors:");
		((Control)panelEx5).set_Anchor((AnchorStyles)14);
		panelEx5.AntiAlias = true;
		panelEx5.CanvasColor = SystemColors.Control;
		((Control)panelEx5).set_Location(new Point(7, 287));
		((Control)panelEx5).set_Name("panelEx5");
		((Control)panelEx5).set_Size(new Size(283, 24));
		panelEx5.Style.Alignment = (StringAlignment)1;
		panelEx5.Style.BackColor1.Color = Color.LightGray;
		panelEx5.Style.BackColor2.Color = Color.DimGray;
		panelEx5.Style.Border = eBorderType.SingleLine;
		panelEx5.Style.BorderColor.Color = Color.DimGray;
		panelEx5.Style.CornerType = eCornerType.Rounded;
		panelEx5.Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
		panelEx5.Style.GradientAngle = 90;
		((Control)panelEx5).set_TabIndex(8);
		((Control)panelEx5).set_Text("Place mouse here to preview");
		((Control)panelEx5).add_MouseLeave((EventHandler)panelEx5_MouseLeave);
		((Control)panelEx5).add_MouseEnter((EventHandler)panelEx5_MouseEnter);
		((Control)panelBodyImage).set_Anchor((AnchorStyles)7);
		panelBodyImage.AntiAlias = true;
		panelBodyImage.CanvasColor = SystemColors.Control;
		((Control)panelBodyImage).set_Location(new Point(7, 83));
		((Control)panelBodyImage).set_Name("panelBodyImage");
		((Control)panelBodyImage).set_Size(new Size(94, 117));
		panelBodyImage.Style.Alignment = (StringAlignment)1;
		panelBodyImage.Style.BackColor1.Color = Color.White;
		panelBodyImage.Style.BackColor2.Color = Color.White;
		panelBodyImage.Style.BackgroundImagePosition = eBackgroundImagePosition.Center;
		panelBodyImage.Style.Border = eBorderType.SingleLine;
		panelBodyImage.Style.BorderColor.Color = Color.DimGray;
		panelBodyImage.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
		panelBodyImage.Style.GradientAngle = 90;
		superTooltip_0.SetSuperTooltip((IComponent)panelBodyImage, new SuperTooltipInfo("Click to set body image", "", "Allows you to choose body image. Note that image displayed here is preview image. You can see tooltip preview below", null, null, eTooltipColor.Lemon, headerVisible: true, footerVisible: false, Size.Empty));
		((Control)panelBodyImage).set_TabIndex(6);
		((Control)panelBodyImage).add_Click((EventHandler)panelBodyImage_Click);
		((Control)textFooter).set_Anchor((AnchorStyles)14);
		((Control)textFooter).set_Location(new Point(107, 206));
		((Control)textFooter).set_Name("textFooter");
		((Control)textFooter).set_Size(new Size(316, 21));
		((Control)textFooter).set_TabIndex(2);
		textBody.set_AcceptsReturn(true);
		((Control)textBody).set_Anchor((AnchorStyles)15);
		((Control)textBody).set_Location(new Point(107, 60));
		((TextBoxBase)textBody).set_Multiline(true);
		((Control)textBody).set_Name("textBody");
		textBody.set_ScrollBars((ScrollBars)2);
		((Control)textBody).set_Size(new Size(316, 140));
		((Control)textBody).set_TabIndex(1);
		((Control)textHeader).set_Anchor((AnchorStyles)13);
		((Control)textHeader).set_Location(new Point(107, 33));
		((Control)textHeader).set_Name("textHeader");
		((Control)textHeader).set_Size(new Size(316, 21));
		((Control)textHeader).set_TabIndex(0);
		((Control)footerVisible).set_Anchor((AnchorStyles)6);
		((Control)footerVisible).set_Location(new Point(7, 208));
		((Control)footerVisible).set_Name("footerVisible");
		((Control)footerVisible).set_Size(new Size(58, 17));
		((Control)footerVisible).set_TabIndex(7);
		((Control)footerVisible).set_Text("Footer");
		((Control)headerVisible).set_Location(new Point(7, 39));
		((Control)headerVisible).set_Name("headerVisible");
		((Control)headerVisible).set_Size(new Size(61, 17));
		((Control)headerVisible).set_TabIndex(5);
		((Control)headerVisible).set_Text("Header");
		((Control)buttonCancel).set_Anchor((AnchorStyles)10);
		buttonCancel.AntiAlias = true;
		buttonCancel.Style = eDotNetBarStyle.Office2007;
		buttonCancel.ColorTable = eButtonColor.Office2007WithBackground;
		buttonCancel.DialogResult = (DialogResult)2;
		((Control)buttonCancel).set_Location(new Point(364, 287));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(60, 25));
		((Control)buttonCancel).set_TabIndex(4);
		((Control)buttonCancel).set_Text("Cancel");
		((Control)buttonCancel).add_Click((EventHandler)buttonCancel_Click);
		((Control)buttonOK).set_Anchor((AnchorStyles)10);
		buttonOK.AntiAlias = true;
		buttonOK.DialogResult = (DialogResult)1;
		((Control)buttonOK).set_Location(new Point(296, 287));
		((Control)buttonOK).set_Name("buttonOK");
		((Control)buttonOK).set_Size(new Size(62, 25));
		buttonOK.Style = eDotNetBarStyle.Office2007;
		buttonOK.ColorTable = eButtonColor.Office2007WithBackground;
		((Control)buttonOK).set_TabIndex(3);
		((Control)buttonOK).set_Text("OK");
		((Control)buttonOK).add_Click((EventHandler)buttonOK_Click);
		((Control)this).set_BackColor(Color.WhiteSmoke);
		((Control)this).get_Controls().Add((Control)(object)panelEx1);
		((Control)this).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("SuperTooltipVisualEditor");
		((Control)this).set_Size(new Size(432, 320));
		((Control)panelEx1).ResumeLayout(false);
		((Control)panelEx1).PerformLayout();
		((ISupportInitialize)customWidth).EndInit();
		((ISupportInitialize)customHeight).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void panelBodyImage_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		Image val = null;
		if (customTypeEditorProvider_0 != null)
		{
			UITypeEditor val2 = (UITypeEditor)TypeDescriptor.GetEditor(typeof(Image), typeof(UITypeEditor));
			customTypeEditorProvider_0.SetInstance(superTooltipInfo_0, TypeDescriptor.GetProperties(superTooltipInfo_0)["BodyImage"]);
			object obj = val2.EditValue((ITypeDescriptorContext)customTypeEditorProvider_0, (IServiceProvider)customTypeEditorProvider_0, (object)superTooltipInfo_0.BodyImage);
			val = (Image)((obj is Image) ? obj : null);
		}
		if (superTooltipInfo_0.BodyImage != val)
		{
			superTooltipInfo_0.BodyImage = val;
			if (superTooltipInfo_0.BodyImage != null)
			{
				panelBodyImage.Style.BackgroundImage = superTooltipInfo_0.BodyImage;
			}
			else
			{
				panelBodyImage.Style.BackgroundImage = (Image)(object)Class109.smethod_67("SystemImages.ImagePlaceHolder.png");
			}
			bool_1 = true;
		}
	}

	private void method_0()
	{
		if (superTooltipInfo_0 != null)
		{
			((Control)textHeader).set_Text(superTooltipInfo_0.HeaderText);
			headerVisible.set_Checked(superTooltipInfo_0.HeaderVisible);
			((Control)textBody).set_Text(superTooltipInfo_0.BodyText);
			if (superTooltipInfo_0.BodyImage != null)
			{
				panelBodyImage.Style.BackgroundImage = superTooltipInfo_0.BodyImage;
				bool_1 = true;
			}
			else
			{
				panelBodyImage.Style.BackgroundImage = (Image)(object)Class109.smethod_67("SystemImages.ImagePlaceHolder.png");
			}
			if (superTooltipInfo_0.FooterImage != null)
			{
				panelFooterImage.Style.BackgroundImage = superTooltipInfo_0.FooterImage;
				bool_2 = true;
			}
			else
			{
				panelFooterImage.Style.BackgroundImage = (Image)(object)Class109.smethod_67("SystemImages.ImagePlaceHolder16x16.png");
			}
			((Control)textFooter).set_Text(superTooltipInfo_0.FooterText);
			footerVisible.set_Checked(superTooltipInfo_0.FooterVisible);
			comboColors.set_SelectedItem((object)Enum.GetName(typeof(eTooltipColor), superTooltipInfo_0.Color));
			if (superTooltipInfo_0.CustomSize.IsEmpty)
			{
				checkCustomSize.set_Checked(false);
			}
			else
			{
				checkCustomSize.set_Checked(true);
				customWidth.set_Value((decimal)superTooltipInfo_0.CustomSize.Width);
				customHeight.set_Value((decimal)superTooltipInfo_0.CustomSize.Height);
			}
			((Control)customHeight).set_Enabled(checkCustomSize.get_Checked());
			((Control)customWidth).set_Enabled(checkCustomSize.get_Checked());
		}
	}

	private void method_1(SuperTooltipInfo superTooltipInfo_1)
	{
		if (superTooltipInfo_1 != null)
		{
			superTooltipInfo_1.HeaderText = ((Control)textHeader).get_Text();
			superTooltipInfo_1.HeaderVisible = headerVisible.get_Checked();
			superTooltipInfo_1.BodyText = ((Control)textBody).get_Text();
			if (bool_1)
			{
				superTooltipInfo_1.BodyImage = panelBodyImage.Style.BackgroundImage;
			}
			else
			{
				superTooltipInfo_1.BodyImage = null;
			}
			if (bool_2)
			{
				superTooltipInfo_1.FooterImage = panelFooterImage.Style.BackgroundImage;
			}
			else
			{
				superTooltipInfo_1.FooterImage = null;
			}
			superTooltipInfo_1.FooterText = ((Control)textFooter).get_Text();
			superTooltipInfo_1.FooterVisible = footerVisible.get_Checked();
			superTooltipInfo_1.Color = (eTooltipColor)Enum.Parse(typeof(eTooltipColor), comboColors.get_SelectedItem().ToString());
			if (checkCustomSize.get_Checked())
			{
				superTooltipInfo_1.CustomSize = new Size((int)customWidth.get_Value(), (int)customHeight.get_Value());
			}
			else
			{
				superTooltipInfo_1.CustomSize = Size.Empty;
			}
		}
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		method_2();
		bool_0 = true;
		((Form)((Control)this).get_Parent()).Close();
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		method_2();
		bool_0 = false;
		((Form)((Control)this).get_Parent()).Close();
	}

	private void method_2()
	{
		if (superTooltipControl_0 != null)
		{
			((Control)superTooltipControl_0).Hide();
			((Component)(object)superTooltipControl_0).Dispose();
			superTooltipControl_0 = null;
		}
	}

	private void panelEx5_MouseEnter(object sender, EventArgs e)
	{
		method_2();
		superTooltipControl_0 = new SuperTooltipControl();
		if (font_0 != null)
		{
			((Control)superTooltipControl_0).set_Font(font_0);
		}
		if (superTooltip_1 != null)
		{
			superTooltipControl_0.MaximumWidth = superTooltip_1.MaximumWidth;
			superTooltipControl_0.MinimumTooltipSize = superTooltip_1.MinimumTooltipSize;
			superTooltipControl_0.AntiAlias = superTooltip_1.AntiAlias;
			if (superTooltip_1.DefaultFont != null)
			{
				((Control)superTooltipControl_0).set_Font(superTooltip_1.DefaultFont);
			}
		}
		else
		{
			superTooltipControl_0.MaximumWidth = int_0;
		}
		SuperTooltipInfo superTooltipInfo = new SuperTooltipInfo();
		method_1(superTooltipInfo);
		Point point = ((Control)panelEx5).PointToScreen(new Point(0, ((Control)panelEx5).get_Height() + 1));
		superTooltipControl_0.ShowTooltip(superTooltipInfo, point.X, point.Y, enforceScreenPosition: true);
	}

	private void panelEx5_MouseLeave(object sender, EventArgs e)
	{
		method_2();
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((ScrollableControl)this).OnVisibleChanged(e);
		if (!((Control)this).get_Visible())
		{
			method_2();
		}
	}

	private void panelFooterImage_Click(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		Image val = null;
		if (customTypeEditorProvider_0 != null)
		{
			UITypeEditor val2 = (UITypeEditor)TypeDescriptor.GetEditor(typeof(Image), typeof(UITypeEditor));
			customTypeEditorProvider_0.SetInstance(superTooltipInfo_0, TypeDescriptor.GetProperties(superTooltipInfo_0)["FooterImage"]);
			object obj = val2.EditValue((ITypeDescriptorContext)customTypeEditorProvider_0, (IServiceProvider)customTypeEditorProvider_0, (object)superTooltipInfo_0.FooterImage);
			val = (Image)((obj is Image) ? obj : null);
		}
		if (superTooltipInfo_0.FooterImage != val)
		{
			superTooltipInfo_0.FooterImage = val;
			if (superTooltipInfo_0.FooterImage != null)
			{
				panelFooterImage.Style.BackgroundImage = superTooltipInfo_0.FooterImage;
			}
			else
			{
				panelFooterImage.Style.BackgroundImage = (Image)(object)Class109.smethod_67("SystemImages.ImagePlaceHolder16x16.png");
			}
			bool_2 = true;
		}
	}

	private void checkCustomSize_CheckedChanged(object sender, EventArgs e)
	{
		((Control)customWidth).set_Enabled(checkCustomSize.get_Checked());
		((Control)customHeight).set_Enabled(checkCustomSize.get_Checked());
		if (checkCustomSize.get_Checked())
		{
			SuperTooltipInfo superTooltipInfo = new SuperTooltipInfo();
			method_1(superTooltipInfo);
			SuperTooltipControl superTooltipControl = new SuperTooltipControl();
			superTooltipControl.UpdateWithSuperTooltipInfo(superTooltipInfo);
			superTooltipControl.RecalcSize();
			customWidth.set_Value((decimal)((Control)superTooltipControl).get_Width());
			customHeight.set_Value((decimal)((Control)superTooltipControl).get_Height());
			((Component)(object)superTooltipControl).Dispose();
		}
	}

	private void resetBodyImage_Click(object sender, EventArgs e)
	{
		panelBodyImage.Style.BackgroundImage = (Image)(object)Class109.smethod_67("SystemImages.ImagePlaceHolder.png");
		superTooltipInfo_0.BodyImage = null;
		bool_1 = false;
	}

	private void resetFooterImage_Click(object sender, EventArgs e)
	{
		panelFooterImage.Style.BackgroundImage = (Image)(object)Class109.smethod_67("SystemImages.ImagePlaceHolder16x16.png");
		superTooltipInfo_0.FooterImage = null;
		bool_2 = false;
	}
}

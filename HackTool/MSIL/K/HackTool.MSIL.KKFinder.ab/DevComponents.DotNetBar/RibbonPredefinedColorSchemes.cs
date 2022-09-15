using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.Ribbon;

namespace DevComponents.DotNetBar;

public class RibbonPredefinedColorSchemes
{
	public static void ApplyGrayColorScheme(RibbonBar b)
	{
		b.BackgroundStyle.Reset();
		b.BackgroundMouseOverStyle.Reset();
		b.TitleStyle.Reset();
		b.TitleStyleMouseOver.Reset();
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColor"]!.SetValue(b.BackgroundStyle, ColorScheme.GetColor("CFD5E2"));
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColor2"]!.SetValue(b.BackgroundStyle, ColorScheme.GetColor("C2C9D9"));
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColorGradientAngle"]!.SetValue(b.BackgroundStyle, 90);
		TypeDescriptor.GetProperties(b.BackgroundMouseOverStyle)["BackColor"]!.SetValue(b.BackgroundMouseOverStyle, ColorScheme.GetColor("EFEFEF"));
		TypeDescriptor.GetProperties(b.BackgroundMouseOverStyle)["BackColor2"]!.SetValue(b.BackgroundMouseOverStyle, ColorScheme.GetColor("D2DAED"));
		TypeDescriptor.GetProperties(b.BackgroundMouseOverStyle)["BackColorGradientAngle"]!.SetValue(b.BackgroundMouseOverStyle, 90);
		TypeDescriptor.GetProperties(b.TitleStyle)["BackColor"]!.SetValue(b.TitleStyle, ColorScheme.GetColor("6A7080"));
		TypeDescriptor.GetProperties(b.TitleStyle)["BackColor2"]!.SetValue(b.TitleStyle, ColorScheme.GetColor("A8B2CC"));
		TypeDescriptor.GetProperties(b.TitleStyle)["BackColorGradientAngle"]!.SetValue(b.TitleStyle, 90);
		TypeDescriptor.GetProperties(b.TitleStyle)["TextColor"]!.SetValue(b.TitleStyle, Color.White);
		TypeDescriptor.GetProperties(b.TitleStyle)["PaddingTop"]!.SetValue(b.TitleStyle, 3);
		TypeDescriptor.GetProperties(b.TitleStyle)["PaddingBottom"]!.SetValue(b.TitleStyle, 2);
		TypeDescriptor.GetProperties(b.TitleStyle)["PaddingLeft"]!.SetValue(b.TitleStyle, 2);
		TypeDescriptor.GetProperties(b.TitleStyle)["PaddingRight"]!.SetValue(b.TitleStyle, 2);
		TypeDescriptor.GetProperties(b.TitleStyle)["TextShadowColor"]!.SetValue(b.TitleStyle, Color.Black);
		TypeDescriptor.GetProperties(b.TitleStyle)["TextShadowOffset"]!.SetValue(b.TitleStyle, new Point(1, 1));
		TypeDescriptor.GetProperties(b.TitleStyle)["Border"]!.SetValue(b.TitleStyle, eStyleBorderType.None);
		TypeDescriptor.GetProperties(b.TitleStyleMouseOver)["BackColor"]!.SetValue(b.TitleStyleMouseOver, ColorScheme.GetColor("53607D"));
		TypeDescriptor.GetProperties(b.TitleStyleMouseOver)["BackColor2"]!.SetValue(b.TitleStyleMouseOver, ColorScheme.GetColor("8BA1CA"));
		((Control)b).Invalidate();
	}

	public static void ApplyOrangeColorScheme(RibbonBar b)
	{
		b.BackgroundStyle.Reset();
		b.BackgroundMouseOverStyle.Reset();
		b.TitleStyle.Reset();
		b.TitleStyleMouseOver.Reset();
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColor"]!.SetValue(b.BackgroundStyle, ColorScheme.GetColor("CFD5E2"));
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColor2"]!.SetValue(b.BackgroundStyle, ColorScheme.GetColor("C2C9D9"));
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColorGradientAngle"]!.SetValue(b.BackgroundStyle, 90);
		TypeDescriptor.GetProperties(b.TitleStyle)["BackColor"]!.SetValue(b.TitleStyle, ColorScheme.GetColor("CBA950"));
		TypeDescriptor.GetProperties(b.TitleStyle)["BackColor2"]!.SetValue(b.TitleStyle, ColorScheme.GetColor("FED665"));
		TypeDescriptor.GetProperties(b.TitleStyle)["BackColorGradientAngle"]!.SetValue(b.TitleStyle, 90);
		TypeDescriptor.GetProperties(b.TitleStyle)["TextColor"]!.SetValue(b.TitleStyle, Color.White);
		TypeDescriptor.GetProperties(b.TitleStyle)["PaddingTop"]!.SetValue(b.TitleStyle, 3);
		TypeDescriptor.GetProperties(b.TitleStyle)["PaddingBottom"]!.SetValue(b.TitleStyle, 2);
		TypeDescriptor.GetProperties(b.TitleStyle)["PaddingLeft"]!.SetValue(b.TitleStyle, 2);
		TypeDescriptor.GetProperties(b.TitleStyle)["PaddingRight"]!.SetValue(b.TitleStyle, 2);
		TypeDescriptor.GetProperties(b.TitleStyle)["TextShadowColor"]!.SetValue(b.TitleStyle, Color.Black);
		TypeDescriptor.GetProperties(b.TitleStyle)["TextShadowOffset"]!.SetValue(b.TitleStyle, new Point(1, 1));
		TypeDescriptor.GetProperties(b.TitleStyle)["Border"]!.SetValue(b.TitleStyle, eStyleBorderType.None);
		((Control)b).Invalidate();
	}

	public static void ApplyOffice2003ColorScheme(RibbonBar b)
	{
		((Control)b).Invalidate();
	}

	internal static void smethod_0(ElementStyle elementStyle_0, ElementStyle elementStyle_1, ElementStyle elementStyle_2, ElementStyle elementStyle_3)
	{
		elementStyle_0.Reset();
		elementStyle_1.Reset();
		elementStyle_2.Reset();
		elementStyle_3.Reset();
		elementStyle_0.BackColorSchemePart = eColorSchemePart.BarBackground2;
		elementStyle_0.BackColor2SchemePart = eColorSchemePart.BarBackground;
		elementStyle_0.BackColorGradientAngle = 90;
		elementStyle_2.BackColorSchemePart = eColorSchemePart.PanelBackground;
		elementStyle_2.BackColor2SchemePart = eColorSchemePart.PanelBackground2;
		elementStyle_2.BackColorGradientAngle = 90;
		elementStyle_2.TextColorSchemePart = eColorSchemePart.PanelText;
		elementStyle_2.PaddingTop = 1;
		elementStyle_2.PaddingBottom = 1;
		elementStyle_2.PaddingLeft = 2;
		elementStyle_2.PaddingRight = 2;
		elementStyle_2.TextShadowColor = Color.Black;
		elementStyle_2.TextShadowOffset = new Point(1, 1);
		elementStyle_2.BorderColorSchemePart = eColorSchemePart.PanelBorder;
		elementStyle_2.Border = eStyleBorderType.Solid;
		elementStyle_2.BorderWidth = 1;
	}

	public static void ApplyOffice2003ColorScheme(RibbonControl b)
	{
		smethod_3(b.BackgroundStyle);
		((Control)b).Invalidate(true);
	}

	public static void ApplyGrayColorScheme(RibbonControl b)
	{
		b.BackgroundStyle.Reset();
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColor"]!.SetValue(b.BackgroundStyle, ColorScheme.GetColor("F4F4F4"));
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColor2"]!.SetValue(b.BackgroundStyle, ColorScheme.GetColor("CFCFCF"));
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColorGradientAngle"]!.SetValue(b.BackgroundStyle, 0);
		TypeDescriptor.GetProperties(b.BackgroundStyle)["BackColorGradientType"]!.SetValue(b.BackgroundStyle, eGradientType.Radial);
		((Control)b).Invalidate(true);
	}

	public static void ApplyOffice2007ColorScheme(RibbonControl b)
	{
		((Control)b).Invalidate(true);
	}

	internal static void smethod_1(ElementStyle elementStyle_0, RibbonControl ribbonControl_0)
	{
		if (ribbonControl_0 != null && ribbonControl_0.Style == eDotNetBarStyle.Office2007)
		{
			smethod_2(elementStyle_0, smethod_5(ribbonControl_0));
		}
		else
		{
			smethod_3(elementStyle_0);
		}
	}

	internal static void smethod_2(ElementStyle elementStyle_0, Office2007ColorTable office2007ColorTable_0)
	{
		elementStyle_0.Reset();
		elementStyle_0.BackColor = office2007ColorTable_0.RibbonControl.TabsBackground.Start;
		elementStyle_0.BackColor2 = office2007ColorTable_0.RibbonControl.TabsBackground.End;
		elementStyle_0.BackColorGradientAngle = office2007ColorTable_0.RibbonControl.TabsBackground.GradientAngle;
		elementStyle_0.BackColorGradientType = eGradientType.Linear;
	}

	internal static void smethod_3(ElementStyle elementStyle_0)
	{
		elementStyle_0.Reset();
		elementStyle_0.BackColorSchemePart = eColorSchemePart.BarBackground2;
		elementStyle_0.BackColor2SchemePart = eColorSchemePart.BarBackground;
		elementStyle_0.BackColorGradientAngle = 90;
	}

	public static void ApplyOffice2007ColorScheme(RibbonBar b)
	{
		((Control)b).Invalidate();
	}

	internal static Office2007ColorTable smethod_4(RibbonBar ribbonBar_0)
	{
		Office2007ColorTable office2007ColorTable = null;
		if ((ribbonBar_0.RenderMode == eRenderMode.Custom || ribbonBar_0.RenderMode == eRenderMode.Instance) && ribbonBar_0.Renderer != null)
		{
			if (ribbonBar_0.Renderer is Office2007Renderer office2007Renderer)
			{
				office2007ColorTable = office2007Renderer.ColorTable;
			}
		}
		else if (GlobalManager.Renderer is Office2007Renderer office2007Renderer2)
		{
			office2007ColorTable = office2007Renderer2.ColorTable;
		}
		if (office2007ColorTable == null)
		{
			office2007ColorTable = new Office2007ColorTable();
		}
		return office2007ColorTable;
	}

	internal static Office2007ColorTable smethod_5(RibbonControl ribbonControl_0)
	{
		Office2007ColorTable office2007ColorTable = null;
		if ((ribbonControl_0.RibbonStrip.RenderMode == eRenderMode.Custom || ribbonControl_0.RibbonStrip.RenderMode == eRenderMode.Instance) && ribbonControl_0.RibbonStrip.Renderer != null)
		{
			if (ribbonControl_0.RibbonStrip.Renderer is Office2007Renderer office2007Renderer)
			{
				office2007ColorTable = office2007Renderer.ColorTable;
			}
		}
		else if (GlobalManager.Renderer is Office2007Renderer office2007Renderer2)
		{
			office2007ColorTable = office2007Renderer2.ColorTable;
		}
		if (office2007ColorTable == null)
		{
			office2007ColorTable = new Office2007ColorTable();
		}
		return office2007ColorTable;
	}

	internal static void smethod_6(ElementStyle elementStyle_0, ElementStyle elementStyle_1, ElementStyle elementStyle_2, ElementStyle elementStyle_3, RibbonBar ribbonBar_0)
	{
		if (ribbonBar_0.Style == eDotNetBarStyle.Office2007)
		{
			Office2007ColorTable office2007ColorTable_ = smethod_4(ribbonBar_0);
			smethod_7(elementStyle_0, elementStyle_1, elementStyle_2, elementStyle_3, office2007ColorTable_);
		}
		else
		{
			smethod_0(elementStyle_0, elementStyle_1, elementStyle_2, elementStyle_3);
		}
	}

	internal static void smethod_7(ElementStyle elementStyle_0, ElementStyle elementStyle_1, ElementStyle elementStyle_2, ElementStyle elementStyle_3, Office2007ColorTable office2007ColorTable_0)
	{
		elementStyle_0.Reset();
		elementStyle_1.Reset();
		elementStyle_2.Reset();
		elementStyle_3.Reset();
		elementStyle_0.Border = eStyleBorderType.Etched;
		elementStyle_0.BorderWidth = 1;
		elementStyle_0.CornerType = eCornerType.Rounded;
		elementStyle_0.CornerDiameter = 2;
		elementStyle_0.BorderColor = office2007ColorTable_0.RibbonBar.Default.OuterBorder.Start;
		elementStyle_0.BorderColor2 = office2007ColorTable_0.RibbonBar.Default.OuterBorder.End;
		elementStyle_0.BorderColorLight = office2007ColorTable_0.RibbonBar.Default.InnerBorder.Start;
		elementStyle_0.BorderColorLight2 = office2007ColorTable_0.RibbonBar.Default.InnerBorder.End;
		elementStyle_0.BackColorGradientAngle = 90;
		elementStyle_0.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable_0.RibbonBar.Default.TopBackground.Start, 0f));
		elementStyle_0.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable_0.RibbonBar.Default.TopBackground.End, office2007ColorTable_0.RibbonBar.Default.TopBackgroundHeight));
		elementStyle_0.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable_0.RibbonBar.Default.BottomBackground.Start, office2007ColorTable_0.RibbonBar.Default.TopBackgroundHeight));
		elementStyle_0.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable_0.RibbonBar.Default.BottomBackground.End, 1f));
		elementStyle_0.PaddingLeft = 2;
		elementStyle_0.PaddingRight = 2;
		elementStyle_1.BorderColor = office2007ColorTable_0.RibbonBar.MouseOver.OuterBorder.Start;
		elementStyle_1.BorderColor2 = office2007ColorTable_0.RibbonBar.MouseOver.OuterBorder.End;
		elementStyle_1.BorderColorLight = office2007ColorTable_0.RibbonBar.MouseOver.InnerBorder.Start;
		elementStyle_1.BorderColorLight2 = office2007ColorTable_0.RibbonBar.MouseOver.InnerBorder.End;
		elementStyle_1.BackColorGradientAngle = 90;
		elementStyle_1.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable_0.RibbonBar.MouseOver.TopBackground.Start, 0f));
		elementStyle_1.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable_0.RibbonBar.MouseOver.TopBackground.End, office2007ColorTable_0.RibbonBar.MouseOver.TopBackgroundHeight));
		elementStyle_1.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable_0.RibbonBar.MouseOver.BottomBackground.Start, office2007ColorTable_0.RibbonBar.MouseOver.TopBackgroundHeight));
		elementStyle_1.BackColorBlend.Add(new BackgroundColorBlend(office2007ColorTable_0.RibbonBar.MouseOver.BottomBackground.End, 1f));
		elementStyle_2.BackColor = office2007ColorTable_0.RibbonBar.Default.TitleBackground.Start;
		elementStyle_2.BackColor2 = office2007ColorTable_0.RibbonBar.Default.TitleBackground.End;
		elementStyle_2.BackColorGradientAngle = 90;
		elementStyle_2.TextAlignment = eStyleTextAlignment.Center;
		elementStyle_2.TextColor = office2007ColorTable_0.RibbonBar.Default.TitleText;
		elementStyle_2.TextShadowOffset = Point.Empty;
		elementStyle_2.PaddingTop = 1;
		elementStyle_2.PaddingBottom = 1;
		elementStyle_3.BackColor = office2007ColorTable_0.RibbonBar.MouseOver.TitleBackground.Start;
		elementStyle_3.BackColor2 = office2007ColorTable_0.RibbonBar.MouseOver.TitleBackground.End;
		elementStyle_3.BackColorGradientAngle = 90;
		elementStyle_3.TextAlignment = eStyleTextAlignment.Center;
		elementStyle_3.TextColor = office2007ColorTable_0.RibbonBar.MouseOver.TitleText;
	}

	internal static ElementStyle smethod_8(Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Border = eStyleBorderType.Etched;
		elementStyle.BorderWidth = 1;
		elementStyle.CornerType = eCornerType.Rounded;
		elementStyle.CornerDiameter = 3;
		elementStyle.BorderColor = office2007RibbonBarStateColorTable_0.OuterBorder.Start;
		elementStyle.BorderColor2 = office2007RibbonBarStateColorTable_0.OuterBorder.End;
		elementStyle.BorderColorLight = office2007RibbonBarStateColorTable_0.InnerBorder.Start;
		elementStyle.BorderColorLight2 = office2007RibbonBarStateColorTable_0.InnerBorder.End;
		elementStyle.BackColorGradientAngle = 90;
		elementStyle.BackColorBlend.Add(new BackgroundColorBlend(office2007RibbonBarStateColorTable_0.TopBackground.Start, 0f));
		elementStyle.BackColorBlend.Add(new BackgroundColorBlend(office2007RibbonBarStateColorTable_0.TopBackground.End, office2007RibbonBarStateColorTable_0.TopBackgroundHeight));
		elementStyle.BackColorBlend.Add(new BackgroundColorBlend(office2007RibbonBarStateColorTable_0.BottomBackground.Start, office2007RibbonBarStateColorTable_0.TopBackgroundHeight));
		elementStyle.BackColorBlend.Add(new BackgroundColorBlend(office2007RibbonBarStateColorTable_0.BottomBackground.End, 1f));
		return elementStyle;
	}

	public static void SetRibbonControlStyle(RibbonControl r, eDotNetBarStyle style)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		r.BackgroundStyle.Reset();
		r.Style = style;
		foreach (Control item in (ArrangedElementCollection)((Control)r).get_Controls())
		{
			Control val = item;
			if (val is RibbonPanel)
			{
				RibbonPanel ribbonPanel = val as RibbonPanel;
				ribbonPanel.Style.Reset();
				ribbonPanel.StyleMouseDown.Reset();
				ribbonPanel.StyleMouseOver.Reset();
				ribbonPanel.ColorSchemeStyle = style;
			}
			else if (val is RibbonBar)
			{
				SetRibbonBarStyle(val as RibbonBar, style);
			}
			foreach (Control item2 in (ArrangedElementCollection)val.get_Controls())
			{
				Control val2 = item2;
				if (val2 is RibbonBar)
				{
					SetRibbonBarStyle(val2 as RibbonBar, style);
				}
			}
		}
		((Control)r).Invalidate(true);
	}

	internal static void smethod_9(ElementStyle elementStyle_0, Control7 control7_0)
	{
		elementStyle_0.Reset();
		if (control7_0.EDotNetBarStyle_0 == eDotNetBarStyle.Office2007)
		{
			Office2007ColorTable office2007ColorTable = smethod_5(((Control)control7_0).get_Parent() as RibbonControl);
			Office2007QuickAccessToolbarStateColorTable standalone = office2007ColorTable.QuickAccessToolbar.Standalone;
			elementStyle_0.BackColor = standalone.BottomBackground.Start;
			elementStyle_0.BackColor2 = standalone.BottomBackground.End;
			elementStyle_0.BackColorGradientAngle = standalone.BottomBackground.GradientAngle;
			elementStyle_0.Border = eStyleBorderType.Etched;
			elementStyle_0.BorderWidth = 1;
			elementStyle_0.CornerType = eCornerType.Rounded;
			elementStyle_0.CornerDiameter = 2;
			elementStyle_0.BorderColor = standalone.OutterBorderColor;
			elementStyle_0.BorderColorLight = standalone.InnerBorderColor;
		}
		else
		{
			elementStyle_0.BackColorSchemePart = eColorSchemePart.BarBackground;
			elementStyle_0.BackColor2SchemePart = eColorSchemePart.BarBackground2;
			elementStyle_0.BackColorGradientAngle = 90;
		}
	}

	public static void SetRibbonBarStyle(RibbonBar bar, eDotNetBarStyle style)
	{
		bar.BackgroundStyle.Reset();
		bar.BackgroundMouseOverStyle.Reset();
		bar.TitleStyle.Reset();
		bar.TitleStyleMouseOver.Reset();
		bar.Style = style;
		((Control)bar).Invalidate();
	}

	public static void SetupFileMenuContainer(ItemContainer topContainer)
	{
		Office2007MenuColorTable office2007MenuColorTable = smethod_10();
		if (office2007MenuColorTable != null)
		{
			topContainer.LayoutOrientation = eOrientation.Vertical;
			topContainer.BackgroundStyle.PaddingBottom = 3;
			topContainer.BackgroundStyle.PaddingLeft = 3;
			topContainer.BackgroundStyle.PaddingRight = 3;
			topContainer.BackgroundStyle.PaddingTop = 8;
			BackgroundColorBlend[] array = new BackgroundColorBlend[office2007MenuColorTable.FileBackgroundBlend.Count];
			office2007MenuColorTable.FileBackgroundBlend.method_0(array);
			topContainer.BackgroundStyle.BackColorBlend.Clear();
			topContainer.BackgroundStyle.BackColorBlend.AddRange(array);
		}
	}

	private static Office2007MenuColorTable smethod_10()
	{
		Office2007MenuColorTable result = null;
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			result = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.Menu;
		}
		return result;
	}

	public static void SetupTwoColumnMenuContainer(ItemContainer twoColumnMenu)
	{
		Office2007MenuColorTable office2007MenuColorTable = smethod_10();
		if (office2007MenuColorTable != null)
		{
			twoColumnMenu.BackgroundStyle.BorderBottom = eStyleBorderType.Double;
			twoColumnMenu.BackgroundStyle.BorderBottomWidth = 1;
			twoColumnMenu.BackgroundStyle.BorderColor = office2007MenuColorTable.FileContainerBorder;
			twoColumnMenu.BackgroundStyle.BorderColorLight = office2007MenuColorTable.FileContainerBorderLight;
			twoColumnMenu.BackgroundStyle.BorderLeft = eStyleBorderType.Double;
			twoColumnMenu.BackgroundStyle.BorderLeftWidth = 1;
			twoColumnMenu.BackgroundStyle.BorderRight = eStyleBorderType.Double;
			twoColumnMenu.BackgroundStyle.BorderRightWidth = 1;
			twoColumnMenu.BackgroundStyle.BorderTop = eStyleBorderType.Double;
			twoColumnMenu.BackgroundStyle.BorderTopWidth = 1;
			twoColumnMenu.BackgroundStyle.PaddingBottom = 2;
			twoColumnMenu.BackgroundStyle.PaddingLeft = 2;
			twoColumnMenu.BackgroundStyle.PaddingRight = 2;
			twoColumnMenu.BackgroundStyle.PaddingTop = 2;
			twoColumnMenu.ItemSpacing = 0;
		}
	}

	public static void SetupMenuColumnOneContainer(ItemContainer menuColumn)
	{
		Office2007MenuColorTable office2007MenuColorTable = smethod_10();
		if (office2007MenuColorTable != null)
		{
			menuColumn.BackgroundStyle.BackColor = office2007MenuColorTable.FileColumnOneBackground;
			menuColumn.BackgroundStyle.BorderRight = eStyleBorderType.Solid;
			menuColumn.BackgroundStyle.BorderRightColor = office2007MenuColorTable.FileColumnOneBorder;
			menuColumn.BackgroundStyle.BorderRightWidth = 1;
			menuColumn.BackgroundStyle.PaddingRight = 1;
			menuColumn.LayoutOrientation = eOrientation.Vertical;
			menuColumn.MinimumSize = new Size(120, 0);
		}
	}

	public static void SetupMenuColumnTwoContainer(ItemContainer columnTwo)
	{
		Office2007MenuColorTable office2007MenuColorTable = smethod_10();
		if (office2007MenuColorTable != null)
		{
			columnTwo.BackgroundStyle.BackColor = office2007MenuColorTable.FileColumnTwoBackground;
			columnTwo.LayoutOrientation = eOrientation.Vertical;
			columnTwo.MinimumSize = new Size(180, 0);
		}
	}

	public static void SetupMenuBottomContainer(ItemContainer bottomContainer)
	{
		Office2007MenuColorTable office2007MenuColorTable = smethod_10();
		if (office2007MenuColorTable != null)
		{
			BackgroundColorBlend[] array = new BackgroundColorBlend[office2007MenuColorTable.FileBottomContainerBackgroundBlend.Count];
			office2007MenuColorTable.FileBottomContainerBackgroundBlend.method_0(array);
			bottomContainer.BackgroundStyle.BackColorBlend.Clear();
			bottomContainer.BackgroundStyle.BackColorBlend.AddRange(array);
			bottomContainer.BackgroundStyle.BackColorGradientAngle = 90;
			bottomContainer.HorizontalItemAlignment = eHorizontalItemsAlignment.Right;
		}
	}

	public static void ChangeOffice2007ColorTable(eOffice2007ColorScheme colorTable)
	{
		if (!(GlobalManager.Renderer is Office2007Renderer))
		{
			throw new InvalidOperationException("GlobalManager.Renderer is not Office2007Renderer. Cannot change the color table. Make sure that renderer is set to Office2007Renderer");
		}
		((Office2007Renderer)GlobalManager.Renderer).ColorTable.Dispose();
		((Office2007Renderer)GlobalManager.Renderer).ColorTable = new Office2007ColorTable(colorTable);
		ApplyOffice2007ColorTable();
	}

	public static void ApplyOffice2007ColorTable()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (Form item in (ReadOnlyCollectionBase)(object)Application.get_OpenForms())
		{
			Form form = item;
			ApplyOffice2007ColorTable((Control)(object)form);
		}
	}

	public static void ChangeOffice2007ColorTable(Control form, eOffice2007ColorScheme colorTable)
	{
		if (!(GlobalManager.Renderer is Office2007Renderer))
		{
			throw new InvalidOperationException("GlobalManager.Renderer is not Office2007Renderer. Cannot change the color table. Make sure that renderer is set to Office2007Renderer");
		}
		((Office2007Renderer)GlobalManager.Renderer).ColorTable.Dispose();
		((Office2007Renderer)GlobalManager.Renderer).ColorTable = new Office2007ColorTable(colorTable);
		ApplyOffice2007ColorTable(form);
	}

	public static void ChangeOffice2007ColorTable(Control form, eOffice2007ColorScheme colorTable, Color baseSchemeColor)
	{
		if (!(GlobalManager.Renderer is Office2007Renderer))
		{
			throw new InvalidOperationException("GlobalManager.Renderer is not Office2007Renderer. Cannot change the color table. Make sure that renderer is set to Office2007Renderer");
		}
		((Office2007Renderer)GlobalManager.Renderer).ColorTable.Dispose();
		((Office2007Renderer)GlobalManager.Renderer).ColorTable = new Office2007ColorTable(colorTable, baseSchemeColor);
		ApplyOffice2007ColorTable(form);
	}

	public static void ChangeOffice2007ColorTable(eOffice2007ColorScheme colorTable, Color baseSchemeColor)
	{
		if (!(GlobalManager.Renderer is Office2007Renderer))
		{
			throw new InvalidOperationException("GlobalManager.Renderer is not Office2007Renderer. Cannot change the color table. Make sure that renderer is set to Office2007Renderer");
		}
		((Office2007Renderer)GlobalManager.Renderer).ColorTable.Dispose();
		((Office2007Renderer)GlobalManager.Renderer).ColorTable = new Office2007ColorTable(colorTable, baseSchemeColor);
		ApplyOffice2007ColorTable();
	}

	public static void ApplyOffice2007ColorTable(Control form)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		if (form == null)
		{
			return;
		}
		if (!(GlobalManager.Renderer is Office2007Renderer))
		{
			throw new InvalidOperationException("GlobalManager.Renderer is not Office2007Renderer. Cannot change the color table. Make sure that renderer is set to Office2007Renderer");
		}
		ColorScheme legacyColors = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.LegacyColors;
		foreach (Control item in (ArrangedElementCollection)form.get_Controls())
		{
			Control control_ = item;
			smethod_11(control_, legacyColors);
		}
		if (form is Office2007RibbonForm)
		{
			form.set_BackColor(((Office2007Renderer)GlobalManager.Renderer).ColorTable.Form.BackColor);
		}
		if (form is Office2007Form)
		{
			((Office2007Form)(object)form).InvalidateNonClient(invalidateForm: true);
		}
		form.Invalidate(true);
	}

	private static void smethod_11(Control control_0, ColorScheme colorScheme_0)
	{
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Invalid comparison between Unknown and I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		bool flag = true;
		if (control_0 is PanelEx && ((PanelEx)(object)control_0).ColorSchemeStyle == eDotNetBarStyle.Office2007)
		{
			PanelEx panelEx = control_0 as PanelEx;
			panelEx.ColorSchemeStyle = eDotNetBarStyle.Office2007;
			control_0.Invalidate();
		}
		if (control_0 is PanelControl && ((PanelControl)(object)control_0).ColorSchemeStyle == eDotNetBarStyle.Office2007)
		{
			PanelControl panelControl = control_0 as PanelControl;
			panelControl.RefreshStyleSystemColors();
			((Control)panelControl).Invalidate();
		}
		else if (control_0 is ExpandablePanel && ((ExpandablePanel)(object)control_0).ColorSchemeStyle == eDotNetBarStyle.Office2007)
		{
			control_0.Invalidate();
		}
		else if (control_0 is RibbonControl)
		{
			((RibbonControl)(object)control_0).RibbonStrip.method_29();
			control_0.Invalidate(true);
		}
		else if (control_0 is RibbonBar)
		{
			control_0.Invalidate();
		}
		else if (control_0 is TabControl)
		{
			TabControl tabControl = control_0 as TabControl;
			if (tabControl.Style == eTabStripStyle.Office2007Dock || tabControl.Style == eTabStripStyle.Office2007Document)
			{
				tabControl.Style = tabControl.Style;
			}
		}
		else if (control_0 is TabStrip)
		{
			TabStrip tabStrip = control_0 as TabStrip;
			if (tabStrip.Style == eTabStripStyle.Office2007Dock || tabStrip.Style == eTabStripStyle.Office2007Document)
			{
				tabStrip.Style = tabStrip.Style;
			}
		}
		else if (control_0 is SideBar)
		{
			SideBar sideBar = control_0 as SideBar;
			if (sideBar.Style == eDotNetBarStyle.Office2007)
			{
				((Control)sideBar).Invalidate();
			}
		}
		else if (control_0 is Office2007RibbonForm)
		{
			control_0.set_BackColor(((Office2007Renderer)GlobalManager.Renderer).ColorTable.Form.BackColor);
			if (control_0 is Office2007Form)
			{
				((Office2007Form)(object)control_0).InvalidateNonClient(invalidateForm: true);
			}
		}
		else if (control_0 is DockSite && (int)control_0.get_Dock() == 1)
		{
			DockSite dockSite = control_0 as DockSite;
			if (dockSite.Owner != null)
			{
				foreach (Bar bar in dockSite.Owner.Bars)
				{
					if (bar.DockSide == eDockSide.None)
					{
						((Control)bar).Invalidate(true);
						smethod_11((Control)(object)bar, colorScheme_0);
					}
				}
			}
		}
		else if (control_0 is ComboBoxEx)
		{
			((ComboBoxEx)(object)control_0).Style = ((ComboBoxEx)(object)control_0).Style;
		}
		else if (control_0 is NavigationPane)
		{
			((NavigationPane)(object)control_0).method_16();
		}
		else if (control_0 is BaseItemControl && ((BaseItemControl)(object)control_0).Style == eDotNetBarStyle.Office2007)
		{
			control_0.Invalidate();
		}
		else if (control_0 is ListViewEx)
		{
			ListViewEx listViewEx = control_0 as ListViewEx;
			((Control)listViewEx).Invalidate(true);
			listViewEx.ResetCachedColorTableReference();
		}
		else if (control_0 is DataGridViewX)
		{
			control_0.Invalidate(true);
		}
		else if (!(control_0 is Class191) && !(control_0 is Class190))
		{
			if (control_0 is DevComponents.AdvTree.AdvTree)
			{
				control_0.Invalidate();
			}
		}
		else
		{
			control_0.Invalidate();
		}
		if (!flag)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)control_0.get_Controls())
		{
			Control control_ = item;
			smethod_11(control_, colorScheme_0);
		}
	}
}

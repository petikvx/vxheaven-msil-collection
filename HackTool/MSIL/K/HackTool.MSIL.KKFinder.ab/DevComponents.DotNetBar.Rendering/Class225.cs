using System;
using System.Drawing;
using DevComponents.AdvTree.Display;

namespace DevComponents.DotNetBar.Rendering;

internal class Class225
{
	public static Office2007RibbonBarStateColorTable smethod_0(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12435393), colorFactory_0.GetColor(8750469));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16185337), colorFactory_0.GetColor(16448250));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15659510), colorFactory_0.GetColor(14804718));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14015463), colorFactory_0.GetColor(15660276));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14672879), colorFactory_0.GetColor(12830673));
		office2007RibbonBarStateColorTable.TitleText = colorFactory_0.GetColor(3355443);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable smethod_1(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12435393), colorFactory_0.GetColor(8750469));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16448508), colorFactory_0.GetColor(16448250));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16251130), colorFactory_0.GetColor(15987959));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15659253), colorFactory_0.GetColor(16251385));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14607086), colorFactory_0.GetColor(11778503));
		office2007RibbonBarStateColorTable.TitleText = colorFactory_0.GetColor(3355443);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable smethod_2(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(8224125), colorFactory_0.GetColor(9737364));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(Color.FromArgb(128, colorFactory_0.GetColor(10000537)), Color.Transparent);
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15066598), colorFactory_0.GetColor(12567500));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11778499), colorFactory_0.GetColor(14607588));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14607588), Color.Empty);
		office2007RibbonBarStateColorTable.TitleText = Color.Empty;
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_3(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15921908), colorFactory_0.GetColor(14936047));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15727097), colorFactory_0.GetColor(11926015));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12500670), colorFactory_0.GetColor(12500670));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15923194), colorFactory_0.GetColor(14804719));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(92, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16444610), colorFactory_0.GetColor(16777149));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15252338), colorFactory_0.GetColor(16699742));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(14406851), colorFactory_0.GetColor(15322765));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(13883359), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15264494), colorFactory_0.GetColor(14343652));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12435137), colorFactory_0.GetColor(12435137));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(3355443);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_4(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15452103), colorFactory_0.GetColor(16179165));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16180966), colorFactory_0.GetColor(15121339));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12827836), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16506522), colorFactory_0.GetColor(16642516));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16438654), colorFactory_0.GetColor(16309396));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14138493), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(14800345), colorFactory_0.GetColor(15108485));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(14735581), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14799831), colorFactory_0.GetColor(15173765));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12435137), colorFactory_0.GetColor(12500670));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(3355443);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_5(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(12706488), colorFactory_0.GetColor(14807515));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15004640), colorFactory_0.GetColor(12115633));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12501693), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16506782), colorFactory_0.GetColor(16642516));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16642773), colorFactory_0.GetColor(16308362));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13091250), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(14213089), colorFactory_0.GetColor(10143890));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(14278367), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14213089), colorFactory_0.GetColor(10143890));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12435137), colorFactory_0.GetColor(12500670));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(3355443);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_6(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16774559), colorFactory_0.GetColor(16775893));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16776150), colorFactory_0.GetColor(16642700));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13092276), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16506522), colorFactory_0.GetColor(16642516));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16372342), colorFactory_0.GetColor(16308362));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14138493), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(14737884), colorFactory_0.GetColor(11970867));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(14737884), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14737884), colorFactory_0.GetColor(15392621));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12435137), colorFactory_0.GetColor(12435137));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(3355443);
		return office2007RibbonTabItemColorTable;
	}

	public static void smethod_7(Office2007ButtonItemColorTable office2007ButtonItemColorTable_0, ColorFactory colorFactory_0)
	{
		Color color = colorFactory_0.GetColor(8355711);
		Color color2 = colorFactory_0.GetColor(15001320);
		office2007ButtonItemColorTable_0.Default.ExpandBackground = color;
		office2007ButtonItemColorTable_0.Default.ExpandLight = color2;
		office2007ButtonItemColorTable_0.Checked.ExpandBackground = color;
		office2007ButtonItemColorTable_0.Checked.ExpandLight = color2;
		office2007ButtonItemColorTable_0.Expanded.ExpandBackground = color;
		office2007ButtonItemColorTable_0.Expanded.ExpandLight = color2;
		office2007ButtonItemColorTable_0.MouseOver.ExpandBackground = color;
		office2007ButtonItemColorTable_0.MouseOver.ExpandLight = color2;
		office2007ButtonItemColorTable_0.Pressed.ExpandBackground = color;
		office2007ButtonItemColorTable_0.Pressed.ExpandLight = color2;
	}

	public static Office2007ButtonItemColorTable smethod_8(bool bool_0, ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14536603), colorFactory_0.GetColor(12625782));
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777207), colorFactory_0.GetColor(16775062));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16776151), colorFactory_0.GetColor(16770957));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16766792), colorFactory_0.GetColor(16770963));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14402420), colorFactory_0.GetColor(13155212));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16773311), colorFactory_0.GetColor(16774879));
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9139796), colorFactory_0.GetColor(12892584));
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15312993), colorFactory_0.GetColor(16624913));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16299370), colorFactory_0.GetColor(16556128));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16484924), colorFactory_0.GetColor(16694626));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16769199), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11566411), colorFactory_0.GetColor(9467987));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16433300), colorFactory_0.GetColor(16767404));
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10450265), colorFactory_0.GetColor(16764717));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15454644), Color.Transparent);
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16505781), colorFactory_0.GetColor(16697208));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16692310), colorFactory_0.GetColor(16640927));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16774559), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9339237), colorFactory_0.GetColor(13025458));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15052373), colorFactory_0.GetColor(16766538));
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16569255), colorFactory_0.GetColor(16427099));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(128, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16289065), colorFactory_0.GetColor(16639129));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16774857), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11566411), colorFactory_0.GetColor(9139796));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16433300), colorFactory_0.GetColor(16767147));
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(3355443);
		smethod_7(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_9(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_8(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15462138), colorFactory_0.GetColor(14080740));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12961745), colorFactory_0.GetColor(13949154));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9278621), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14936302), colorFactory_0.GetColor(13357787));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13357787), colorFactory_0.GetColor(13357787));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11776947), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_10(bool bool_0, ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3889794), Color.Empty);
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777211), colorFactory_0.GetColor(14741247));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12639487), colorFactory_0.GetColor(11128575));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10931711), colorFactory_0.GetColor(13296127));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(124, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7640514), colorFactory_0.GetColor(9482198));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14083059), colorFactory_0.GetColor(8627664));
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3889794), Color.Empty);
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777211), colorFactory_0.GetColor(14741247));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12967160), colorFactory_0.GetColor(11127543));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(96, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(9484010), colorFactory_0.GetColor(7640514));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(184, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7640514), colorFactory_0.GetColor(9482198));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14083059), colorFactory_0.GetColor(8627664));
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5668272), colorFactory_0.GetColor(5668272));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9484010), colorFactory_0.GetColor(7640514));
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14149369), colorFactory_0.GetColor(13098232));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11784437), colorFactory_0.GetColor(14149111));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(92, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(6391735), colorFactory_0.GetColor(5014472));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10663117), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14149369), colorFactory_0.GetColor(13098232));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11784437), colorFactory_0.GetColor(14149111));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5471928), colorFactory_0.GetColor(6915498));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(10141941), colorFactory_0.GetColor(12179455));
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(3355443);
		smethod_7(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_11(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_10(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15462138), colorFactory_0.GetColor(14080740));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12961745), colorFactory_0.GetColor(13949154));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9278621), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14936302), colorFactory_0.GetColor(13357787));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13357787), colorFactory_0.GetColor(13357787));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11776947), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_12(bool bool_0, ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7012448), colorFactory_0.GetColor(5636429));
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15525875), colorFactory_0.GetColor(15259391));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15917035), colorFactory_0.GetColor(15124187));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(96, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15378644), colorFactory_0.GetColor(14778817));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10714065), colorFactory_0.GetColor(8939694));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14271219), colorFactory_0.GetColor(12297939));
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7012448), colorFactory_0.GetColor(5636429));
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15525875), colorFactory_0.GetColor(15259391));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13807814), colorFactory_0.GetColor(13348289));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13793973), colorFactory_0.GetColor(13126815));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(184, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10714065), colorFactory_0.GetColor(8939694));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14271219), colorFactory_0.GetColor(12297939));
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7012448), colorFactory_0.GetColor(5636429));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15525875), colorFactory_0.GetColor(15259391));
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15325154), colorFactory_0.GetColor(14856401));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13603002), colorFactory_0.GetColor(13595568));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(92, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7012448), colorFactory_0.GetColor(5636429));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15525875), colorFactory_0.GetColor(15259391));
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15325154), colorFactory_0.GetColor(14856401));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13603002), colorFactory_0.GetColor(13595568));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10714065), colorFactory_0.GetColor(8939694));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14271219), colorFactory_0.GetColor(12297939));
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(0);
		Class224.smethod_1(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_13(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_12(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15462138), colorFactory_0.GetColor(14080740));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12961745), colorFactory_0.GetColor(13949154));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9278621), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14936302), colorFactory_0.GetColor(13357787));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13357787), colorFactory_0.GetColor(13357787));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11776947), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		return office2007ButtonItemColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_14(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(15985558));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(16704797)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_15(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(14658993));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(15884889)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(3355443);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_16(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(11918000));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(7125332)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(3355443);
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_17(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(15719840));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(15971611)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(3355443);
		return office2007RibbonTabGroupColorTable;
	}

	public static void smethod_18(Office2007ColorTable office2007ColorTable_0, ColorFactory colorFactory_0)
	{
		Office2007ScrollBarStateColorTable @default = office2007ColorTable_0.ScrollBar.Default;
		@default.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16579836), colorFactory_0.GetColor(15790320), 0);
		@default.Border = new LinearGradientColorTable(colorFactory_0.GetColor(15461871), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(7241382), colorFactory_0.GetColor(4344675), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(15462128), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(15133168), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13753060), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(12503771), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15264233), colorFactory_0.GetColor(15330546));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(6254227), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(6316128)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.ScrollBar.MouseOver;
		@default.Background = office2007ColorTable_0.ScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.ScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(15857406), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14674679), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(12243179), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13491955), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16448767), colorFactory_0.GetColor(15660284));
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9213861), colorFactory_0.GetColor(6713727));
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(3357780), colorFactory_0.GetColor(5596557));
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(12571114), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13295610), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11193334), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13886714), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15329771), colorFactory_0.GetColor(16580095));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3960496), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(6316128)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.ScrollBar.MouseOverControl;
		@default.Background = office2007ColorTable_0.ScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.ScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(16054783), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(16054783), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13623800), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14675196), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16514559), Color.Empty);
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9213861), colorFactory_0.GetColor(6713727));
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(7241382), colorFactory_0.GetColor(4344675));
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(15462128), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(15133168), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13753060), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(12503771), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15264233), colorFactory_0.GetColor(15330802));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(6254227), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(6316128)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.ScrollBar.Pressed;
		@default.Background = office2007ColorTable_0.ScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.ScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(15133164), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14869734), 0.6f),
			new BackgroundColorBlend(colorFactory_0.GetColor(12831442), 0.6f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14146785), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16119800), Color.Empty);
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9213861), colorFactory_0.GetColor(6647935));
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(7241382), colorFactory_0.GetColor(4344675));
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(10403561), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11259126), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(7251696), 0.5f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11915767), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12768231), colorFactory_0.GetColor(14543867));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(1526154), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(6316128)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.ScrollBar.Disabled;
		@default.Background = office2007ColorTable_0.ScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.ScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbInnerBorder = new LinearGradientColorTable();
		@default.ThumbOuterBorder = new LinearGradientColorTable();
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12570615), colorFactory_0.GetColor(7502996));
		@default.TrackBackground.Clear();
		@default.TrackInnerBorder = new LinearGradientColorTable();
		@default.TrackOuterBorder = new LinearGradientColorTable();
		@default.TrackSignBackground = new LinearGradientColorTable();
	}

	public static void smethod_19(Office2007ColorTable office2007ColorTable_0, ColorFactory colorFactory_0)
	{
		office2007ColorTable_0.RibbonBar.Default = smethod_0(colorFactory_0);
		office2007ColorTable_0.RibbonBar.MouseOver = smethod_1(colorFactory_0);
		office2007ColorTable_0.RibbonBar.Expanded = smethod_2(colorFactory_0);
		office2007ColorTable_0.RibbonTabItemColors.Clear();
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = smethod_3(colorFactory_0);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Default);
		office2007ColorTable_0.RibbonTabItemColors.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = smethod_5(colorFactory_0);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Green);
		office2007ColorTable_0.RibbonTabItemColors.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = smethod_4(colorFactory_0);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Magenta);
		office2007ColorTable_0.RibbonTabItemColors.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = smethod_6(colorFactory_0);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Orange);
		office2007ColorTable_0.RibbonTabItemColors.Add(office2007RibbonTabItemColorTable);
		office2007ColorTable_0.RibbonControl = new Office2007RibbonColorTable();
		office2007ColorTable_0.RibbonControl.TabsBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13685981), colorFactory_0.GetColor(13685981));
		office2007ColorTable_0.RibbonControl.InnerBorder = new LinearGradientColorTable();
		office2007ColorTable_0.RibbonControl.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12500670), colorFactory_0.GetColor(12500670));
		office2007ColorTable_0.RibbonControl.TabDividerBorder = colorFactory_0.GetColor(11317175);
		office2007ColorTable_0.RibbonControl.TabDividerBorderLight = Color.Empty;
		office2007ColorTable_0.RibbonControl.PanelTopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15659252), colorFactory_0.GetColor(14804718));
		office2007ColorTable_0.RibbonControl.PanelBottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14015463), colorFactory_0.GetColor(15792891));
		office2007ColorTable_0.RibbonControl.StartButtonDefault = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonNormalSilver.png");
		office2007ColorTable_0.RibbonControl.StartButtonMouseOver = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonHotSilver.png");
		office2007ColorTable_0.RibbonControl.StartButtonPressed = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonPressedSilver.png");
		office2007ColorTable_0.ItemGroup.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15856627), colorFactory_0.GetColor(15790834));
		office2007ColorTable_0.ItemGroup.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15198958), colorFactory_0.GetColor(16185336));
		office2007ColorTable_0.ItemGroup.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16382457), colorFactory_0.GetColor(16777215));
		office2007ColorTable_0.ItemGroup.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12961479), colorFactory_0.GetColor(12895942));
		office2007ColorTable_0.ItemGroup.ItemGroupDividerDark = Color.FromArgb(196, colorFactory_0.GetColor(13553358));
		office2007ColorTable_0.ItemGroup.ItemGroupDividerLight = Color.FromArgb(128, colorFactory_0.GetColor(16777215));
		office2007ColorTable_0.Bar.ToolbarTopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15198443), colorFactory_0.GetColor(11910087));
		office2007ColorTable_0.Bar.ToolbarBottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11120566), colorFactory_0.GetColor(13093326));
		office2007ColorTable_0.Bar.ToolbarBottomBorder = colorFactory_0.GetColor(7501952);
		office2007ColorTable_0.Bar.PopupToolbarBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16448250), Color.Empty);
		office2007ColorTable_0.Bar.PopupToolbarBorder = colorFactory_0.GetColor(3092271);
		office2007ColorTable_0.Bar.StatusBarTopBorder = colorFactory_0.GetColor(11317175);
		office2007ColorTable_0.Bar.StatusBarTopBorderLight = colorFactory_0.GetColor(Color.FromArgb(148, Color.White));
		office2007ColorTable_0.Bar.StatusBarAltBackground.Clear();
		office2007ColorTable_0.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15198443), 0f));
		office2007ColorTable_0.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_0.GetColor(11975623), 0.4f));
		office2007ColorTable_0.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_0.GetColor(10857391), 0.4f));
		office2007ColorTable_0.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_0.GetColor(11449530), 1f));
		office2007ColorTable_0.ButtonItemColors.Clear();
		office2007ColorTable_0.RibbonButtonItemColors.Clear();
		office2007ColorTable_0.MenuButtonItemColors.Clear();
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_8(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_9(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_10(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Blue);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_11(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.BlueWithBackground);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_12(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Magenta);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_13(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.MagentaWithBackground);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_8(bool_0: true, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_9(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_10(bool_0: true, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Blue);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_11(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.BlueWithBackground);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_12(bool_0: true, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Magenta);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_13(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.MagentaWithBackground);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = Class224.smethod_27(bool_0: true, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(3355443);
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(3355443);
		office2007ColorTable_0.MenuButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = Class224.smethod_8(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Office2007WithBackground);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ColorTable_0.ButtonItemColors.Add(ButtonItemStaticColorTables.CreateBlueOrbColorTable(colorFactory_0));
		office2007ColorTable_0.RibbonTabGroupColors.Clear();
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = smethod_14(colorFactory_0);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Default);
		office2007ColorTable_0.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = smethod_15(colorFactory_0);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Magenta);
		office2007ColorTable_0.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = smethod_16(colorFactory_0);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Green);
		office2007ColorTable_0.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = smethod_17(colorFactory_0);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Orange);
		office2007ColorTable_0.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007ColorTable_0.Menu.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16448250), Color.Empty);
		office2007ColorTable_0.Menu.Border = new LinearGradientColorTable(colorFactory_0.GetColor(8816262), Color.Empty);
		office2007ColorTable_0.Menu.Side = new LinearGradientColorTable(colorFactory_0.GetColor(15724527), Color.Empty);
		office2007ColorTable_0.Menu.SideBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12961221), Color.Empty);
		office2007ColorTable_0.Menu.SideBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16119285), Color.Empty);
		office2007ColorTable_0.Menu.SideUnused = new LinearGradientColorTable(colorFactory_0.GetColor(15066597), Color.Empty);
		office2007ColorTable_0.Menu.FileBackgroundBlend.Clear();
		office2007ColorTable_0.Menu.FileBackgroundBlend.AddRange(new BackgroundColorBlend[2]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(14607077), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13817820), 1f)
		});
		office2007ColorTable_0.Menu.FileContainerBorder = colorFactory_0.GetColor(11120308);
		office2007ColorTable_0.Menu.FileContainerBorderLight = colorFactory_0.GetColor(15987956);
		office2007ColorTable_0.Menu.FileColumnOneBackground = colorFactory_0.GetColor(16448250);
		office2007ColorTable_0.Menu.FileColumnOneBorder = colorFactory_0.GetColor(11120308);
		office2007ColorTable_0.Menu.FileColumnTwoBackground = colorFactory_0.GetColor(16448250);
		office2007ColorTable_0.Menu.FileBottomContainerBackgroundBlend.Clear();
		office2007ColorTable_0.Menu.FileBottomContainerBackgroundBlend.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(13291735), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13423064), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(12765392), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14279398), 1f)
		});
		office2007ColorTable_0.ComboBox.Default.Background = colorFactory_0.GetColor(15264492);
		office2007ColorTable_0.ComboBox.Default.Border = colorFactory_0.GetColor(11121080);
		office2007ColorTable_0.ComboBox.Default.ExpandBackground = new LinearGradientColorTable();
		office2007ColorTable_0.ComboBox.Default.ExpandBorderInner = new LinearGradientColorTable();
		office2007ColorTable_0.ComboBox.Default.ExpandBorderOuter = new LinearGradientColorTable();
		office2007ColorTable_0.ComboBox.Default.ExpandText = colorFactory_0.GetColor(8158332);
		office2007ColorTable_0.ComboBox.DefaultStandalone.Background = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.ComboBox.DefaultStandalone.Border = colorFactory_0.GetColor(10790052);
		office2007ColorTable_0.ComboBox.DefaultStandalone.ExpandBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15528181), colorFactory_0.GetColor(14673131), 90);
		office2007ColorTable_0.ComboBox.DefaultStandalone.ExpandBorderInner = new LinearGradientColorTable();
		office2007ColorTable_0.ComboBox.DefaultStandalone.ExpandBorderOuter = new LinearGradientColorTable(colorFactory_0.GetColor(12040119), Color.Empty, 90);
		office2007ColorTable_0.ComboBox.DefaultStandalone.ExpandText = colorFactory_0.GetColor(0);
		office2007ColorTable_0.ComboBox.MouseOver.Background = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.ComboBox.MouseOver.Border = colorFactory_0.GetColor(10790052);
		office2007ColorTable_0.ComboBox.MouseOver.ExpandBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16776418), colorFactory_0.GetColor(16770981), 90);
		office2007ColorTable_0.ComboBox.MouseOver.ExpandBorderInner = new LinearGradientColorTable(colorFactory_0.GetColor(16777211), colorFactory_0.GetColor(16776435), 90);
		office2007ColorTable_0.ComboBox.MouseOver.ExpandBorderOuter = new LinearGradientColorTable(colorFactory_0.GetColor(14405273), Color.Empty, 90);
		office2007ColorTable_0.ComboBox.MouseOver.ExpandText = colorFactory_0.GetColor(0);
		office2007ColorTable_0.ComboBox.DroppedDown.Background = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.ComboBox.DroppedDown.Border = colorFactory_0.GetColor(9013641);
		office2007ColorTable_0.ComboBox.DroppedDown.ExpandBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15392959), colorFactory_0.GetColor(16766038), 90);
		office2007ColorTable_0.ComboBox.DroppedDown.ExpandBorderInner = new LinearGradientColorTable(colorFactory_0.GetColor(15854549), colorFactory_0.GetColor(16770708), 90);
		office2007ColorTable_0.ComboBox.DroppedDown.ExpandBorderOuter = new LinearGradientColorTable(colorFactory_0.GetColor(10129251), Color.Empty, 90);
		office2007ColorTable_0.ComboBox.DroppedDown.ExpandText = colorFactory_0.GetColor(0);
		office2007ColorTable_0.DialogLauncher.Default.DialogLauncher = colorFactory_0.GetColor(6645872);
		office2007ColorTable_0.DialogLauncher.Default.DialogLauncherShade = colorFactory_0.GetColor(15461355);
		office2007ColorTable_0.DialogLauncher.MouseOver.DialogLauncher = colorFactory_0.GetColor(6645872);
		office2007ColorTable_0.DialogLauncher.MouseOver.DialogLauncherShade = colorFactory_0.GetColor(15461355);
		office2007ColorTable_0.DialogLauncher.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16776415), colorFactory_0.GetColor(16773031));
		office2007ColorTable_0.DialogLauncher.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16767349), colorFactory_0.GetColor(16769944));
		office2007ColorTable_0.DialogLauncher.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777211), colorFactory_0.GetColor(16776178));
		office2007ColorTable_0.DialogLauncher.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14405273), Color.Empty);
		office2007ColorTable_0.DialogLauncher.Pressed.DialogLauncher = colorFactory_0.GetColor(6645872);
		office2007ColorTable_0.DialogLauncher.Pressed.DialogLauncherShade = colorFactory_0.GetColor(15461355);
		office2007ColorTable_0.DialogLauncher.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15261373), colorFactory_0.GetColor(15386253));
		office2007ColorTable_0.DialogLauncher.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16754488), colorFactory_0.GetColor(16763982));
		office2007ColorTable_0.DialogLauncher.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15788756), colorFactory_0.GetColor(16769937));
		office2007ColorTable_0.DialogLauncher.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10129251), colorFactory_0.GetColor(11576434));
		smethod_20(office2007ColorTable_0.LegacyColors, colorFactory_0);
		office2007ColorTable_0.SystemButton.Default = new Office2007SystemButtonStateColorTable();
		office2007ColorTable_0.SystemButton.Default.Foreground = new LinearGradientColorTable(colorFactory_0.GetColor(7174537), colorFactory_0.GetColor(8952241));
		office2007ColorTable_0.SystemButton.Default.LightShade = colorFactory_0.GetColor(16645631);
		office2007ColorTable_0.SystemButton.Default.DarkShade = colorFactory_0.GetColor(4539717);
		office2007ColorTable_0.SystemButton.MouseOver = new Office2007SystemButtonStateColorTable();
		office2007ColorTable_0.SystemButton.MouseOver.Foreground = new LinearGradientColorTable(colorFactory_0.GetColor(7174537), colorFactory_0.GetColor(8952241));
		office2007ColorTable_0.SystemButton.MouseOver.LightShade = colorFactory_0.GetColor(16645631);
		office2007ColorTable_0.SystemButton.MouseOver.DarkShade = colorFactory_0.GetColor(4539717);
		office2007ColorTable_0.SystemButton.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16251387), colorFactory_0.GetColor(15857146));
		office2007ColorTable_0.SystemButton.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14936820), colorFactory_0.GetColor(14870770));
		office2007ColorTable_0.SystemButton.MouseOver.TopHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16514045), Color.Transparent);
		office2007ColorTable_0.SystemButton.MouseOver.BottomHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16382716), Color.Transparent);
		office2007ColorTable_0.SystemButton.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13159892), colorFactory_0.GetColor(12174032));
		office2007ColorTable_0.SystemButton.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16711423), colorFactory_0.GetColor(16580094));
		office2007ColorTable_0.SystemButton.Pressed = new Office2007SystemButtonStateColorTable();
		office2007ColorTable_0.SystemButton.Pressed.Foreground = new LinearGradientColorTable(colorFactory_0.GetColor(7174537), colorFactory_0.GetColor(8952241));
		office2007ColorTable_0.SystemButton.Pressed.LightShade = colorFactory_0.GetColor(16645631);
		office2007ColorTable_0.SystemButton.Pressed.DarkShade = colorFactory_0.GetColor(4539717);
		office2007ColorTable_0.SystemButton.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13291219), colorFactory_0.GetColor(11186102));
		office2007ColorTable_0.SystemButton.Pressed.TopHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(15001578), Color.Transparent);
		office2007ColorTable_0.SystemButton.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(9015447), colorFactory_0.GetColor(12832212));
		office2007ColorTable_0.SystemButton.Pressed.BottomHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(14017257), Color.Transparent);
		office2007ColorTable_0.SystemButton.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9936032), colorFactory_0.GetColor(11383480));
		office2007ColorTable_0.SystemButton.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15659509), colorFactory_0.GetColor(16514559));
		office2007ColorTable_0.Form.Active.BorderColors = new Color[4]
		{
			colorFactory_0.GetColor(7501952),
			colorFactory_0.GetColor(14605790),
			colorFactory_0.GetColor(12303034),
			colorFactory_0.GetColor(14605790)
		};
		office2007ColorTable_0.Form.Inactive.BorderColors = new Color[4]
		{
			colorFactory_0.GetColor(11844033),
			colorFactory_0.GetColor(15790320),
			colorFactory_0.GetColor(14737632),
			colorFactory_0.GetColor(15132133)
		};
		office2007ColorTable_0.Form.Active.CaptionTopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15198443), colorFactory_0.GetColor(13290961));
		office2007ColorTable_0.Form.Active.CaptionBottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12239306), colorFactory_0.GetColor(15331063));
		office2007ColorTable_0.Form.Active.CaptionBottomBorder = new Color[2]
		{
			colorFactory_0.GetColor(15331063),
			colorFactory_0.GetColor(11317175)
		};
		office2007ColorTable_0.Form.Active.CaptionText = colorFactory_0.GetColor(5067353);
		office2007ColorTable_0.Form.Active.CaptionTextExtra = colorFactory_0.GetColor(3501745);
		office2007ColorTable_0.Form.Inactive.CaptionTopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15658992), colorFactory_0.GetColor(15066856));
		office2007ColorTable_0.Form.Inactive.CaptionBottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14541029), colorFactory_0.GetColor(16054267));
		office2007ColorTable_0.Form.Inactive.CaptionText = colorFactory_0.GetColor(4473924);
		office2007ColorTable_0.Form.Inactive.CaptionTextExtra = colorFactory_0.GetColor(4473924);
		office2007ColorTable_0.Form.BackColor = colorFactory_0.GetColor(13290966);
		office2007ColorTable_0.Form.TextColor = colorFactory_0.GetColor(0);
		office2007ColorTable_0.QuickAccessToolbar.Active.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14146011), colorFactory_0.GetColor(14606306));
		office2007ColorTable_0.QuickAccessToolbar.Active.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13817821), colorFactory_0.GetColor(14343392));
		office2007ColorTable_0.QuickAccessToolbar.Active.OutterBorderColor = Color.Empty;
		office2007ColorTable_0.QuickAccessToolbar.Active.MiddleBorderColor = colorFactory_0.GetColor(11447984);
		office2007ColorTable_0.QuickAccessToolbar.Active.InnerBorderColor = Color.Empty;
		office2007ColorTable_0.QuickAccessToolbar.Inactive.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15198184), colorFactory_0.GetColor(15658992));
		office2007ColorTable_0.QuickAccessToolbar.Inactive.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15264493), colorFactory_0.GetColor(14277340));
		office2007ColorTable_0.QuickAccessToolbar.Inactive.OutterBorderColor = Color.Empty;
		office2007ColorTable_0.QuickAccessToolbar.Inactive.MiddleBorderColor = colorFactory_0.GetColor(11645362);
		office2007ColorTable_0.QuickAccessToolbar.Inactive.InnerBorderColor = Color.Empty;
		office2007ColorTable_0.QuickAccessToolbar.Standalone.TopBackground = new LinearGradientColorTable();
		office2007ColorTable_0.QuickAccessToolbar.Standalone.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14278374), colorFactory_0.GetColor(14080995));
		office2007ColorTable_0.QuickAccessToolbar.Standalone.OutterBorderColor = colorFactory_0.GetColor(12765652);
		office2007ColorTable_0.QuickAccessToolbar.Standalone.MiddleBorderColor = Color.Empty;
		office2007ColorTable_0.QuickAccessToolbar.Standalone.InnerBorderColor = colorFactory_0.GetColor(15593459);
		office2007ColorTable_0.QuickAccessToolbar.QatCustomizeMenuLabelBackground = colorFactory_0.GetColor(15461355);
		office2007ColorTable_0.QuickAccessToolbar.QatCustomizeMenuLabelText = colorFactory_0.GetColor(5002076);
		office2007ColorTable_0.QuickAccessToolbar.Active.GlassBorder = new LinearGradientColorTable(colorFactory_0.GetColor(Color.FromArgb(132, Color.Black)), Color.FromArgb(80, Color.Black));
		office2007ColorTable_0.QuickAccessToolbar.Inactive.GlassBorder = new LinearGradientColorTable(colorFactory_0.GetColor(Color.FromArgb(132, Color.Black)), Color.FromArgb(80, Color.Black));
		office2007ColorTable_0.TabControl.Default = new Office2007TabItemStateColorTable();
		office2007ColorTable_0.TabControl.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14475493), colorFactory_0.GetColor(14212578));
		office2007ColorTable_0.TabControl.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12829635), colorFactory_0.GetColor(14671839));
		office2007ColorTable_0.TabControl.Default.InnerBorder = colorFactory_0.GetColor(15594484);
		office2007ColorTable_0.TabControl.Default.OuterBorder = colorFactory_0.GetColor(7303284);
		office2007ColorTable_0.TabControl.Default.Text = colorFactory_0.GetColor(0);
		office2007ColorTable_0.TabControl.MouseOver = new Office2007TabItemStateColorTable();
		office2007ColorTable_0.TabControl.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16776683), colorFactory_0.GetColor(16772264));
		office2007ColorTable_0.TabControl.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16767577), colorFactory_0.GetColor(16770701));
		office2007ColorTable_0.TabControl.MouseOver.InnerBorder = colorFactory_0.GetColor(16777211);
		office2007ColorTable_0.TabControl.MouseOver.OuterBorder = colorFactory_0.GetColor(11967859);
		office2007ColorTable_0.TabControl.MouseOver.Text = colorFactory_0.GetColor(0);
		office2007ColorTable_0.TabControl.Selected = new Office2007TabItemStateColorTable();
		office2007ColorTable_0.TabControl.Selected.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(Color.White), colorFactory_0.GetColor(15264494));
		office2007ColorTable_0.TabControl.Selected.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15264494), colorFactory_0.GetColor(15264494));
		office2007ColorTable_0.TabControl.Selected.InnerBorder = colorFactory_0.GetColor(Color.White);
		office2007ColorTable_0.TabControl.Selected.OuterBorder = colorFactory_0.GetColor(7303284);
		office2007ColorTable_0.TabControl.Selected.Text = colorFactory_0.GetColor(0);
		office2007ColorTable_0.TabControl.TabBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13093587), colorFactory_0.GetColor(13093587));
		office2007ColorTable_0.TabControl.TabPanelBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15264494), colorFactory_0.GetColor(13948896));
		office2007ColorTable_0.TabControl.TabPanelBorder = colorFactory_0.GetColor(7303284);
		Office2007CheckBoxColorTable checkBoxItem = office2007ColorTable_0.CheckBoxItem;
		checkBoxItem.Default.CheckBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16053492), Color.Empty);
		checkBoxItem.Default.CheckBorder = colorFactory_0.GetColor(10198432);
		checkBoxItem.Default.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_0.GetColor(13291477)), Color.FromArgb(164, colorFactory_0.GetColor(16185078)));
		checkBoxItem.Default.CheckInnerBorder = colorFactory_0.GetColor(10661049);
		checkBoxItem.Default.CheckSign = new LinearGradientColorTable(colorFactory_0.GetColor(5204872), Color.Empty);
		checkBoxItem.Default.Text = colorFactory_0.GetColor(3355443);
		checkBoxItem.MouseOver.CheckBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16053492), Color.Empty);
		checkBoxItem.MouseOver.CheckBorder = colorFactory_0.GetColor(10198432);
		checkBoxItem.MouseOver.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_0.GetColor(16574383)), Color.FromArgb(128, colorFactory_0.GetColor(16709863)));
		checkBoxItem.MouseOver.CheckInnerBorder = colorFactory_0.GetColor(16438650);
		checkBoxItem.MouseOver.CheckSign = new LinearGradientColorTable(colorFactory_0.GetColor(5204872), Color.Empty);
		checkBoxItem.MouseOver.Text = colorFactory_0.GetColor(3355443);
		checkBoxItem.Pressed.CheckBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15068407), Color.Empty);
		checkBoxItem.Pressed.CheckBorder = colorFactory_0.GetColor(10198432);
		checkBoxItem.Pressed.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_0.GetColor(16765031)), Color.FromArgb(164, colorFactory_0.GetColor(16774357)));
		checkBoxItem.Pressed.CheckInnerBorder = colorFactory_0.GetColor(15894822);
		checkBoxItem.Pressed.CheckSign = new LinearGradientColorTable(colorFactory_0.GetColor(5204872), Color.Empty);
		checkBoxItem.Pressed.Text = colorFactory_0.GetColor(3355443);
		checkBoxItem.Disabled.CheckBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16777215), Color.Empty);
		checkBoxItem.Disabled.CheckBorder = colorFactory_0.GetColor(14014683);
		checkBoxItem.Disabled.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_0.GetColor(15659250)), Color.FromArgb(164, colorFactory_0.GetColor(16514043)));
		checkBoxItem.Disabled.CheckInnerBorder = colorFactory_0.GetColor(14738149);
		checkBoxItem.Disabled.CheckSign = new LinearGradientColorTable(colorFactory_0.GetColor(9276813), Color.Empty);
		checkBoxItem.Disabled.Text = colorFactory_0.GetColor(9276813);
		smethod_18(office2007ColorTable_0, colorFactory_0);
		Class224.smethod_39(office2007ColorTable_0, colorFactory_0);
		Office2007ProgressBarColorTable progressBarItem = office2007ColorTable_0.ProgressBarItem;
		progressBarItem.BackgroundColors = new GradientColorTable(13028309, 14738669);
		progressBarItem.OuterBorder = colorFactory_0.GetColor(16317439);
		progressBarItem.InnerBorder = colorFactory_0.GetColor(12632256);
		progressBarItem.Chunk = new GradientColorTable(6590497, 15072444, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(164, colorFactory_0.GetColor(14214851)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, colorFactory_0.GetColor(8958024)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, colorFactory_0.GetColor(6987039)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(11712968, 14015205, 0);
		progressBarItem = office2007ColorTable_0.ProgressBarItemPaused;
		progressBarItem.BackgroundColors = new GradientColorTable(13028309, 14738669);
		progressBarItem.OuterBorder = colorFactory_0.GetColor(16317439);
		progressBarItem.InnerBorder = colorFactory_0.GetColor(12632256);
		progressBarItem.Chunk = new GradientColorTable(11446016, 16776653, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(192, colorFactory_0.GetColor(16776099)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, colorFactory_0.GetColor(13814272)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, colorFactory_0.GetColor(16708608)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(11712968, 14015205, 0);
		progressBarItem = office2007ColorTable_0.ProgressBarItemError;
		progressBarItem.BackgroundColors = new GradientColorTable(13028309, 14738669);
		progressBarItem.OuterBorder = colorFactory_0.GetColor(16317439);
		progressBarItem.InnerBorder = colorFactory_0.GetColor(12632256);
		progressBarItem.Chunk = new GradientColorTable(13762560, 16764365, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(192, colorFactory_0.GetColor(16748431)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, colorFactory_0.GetColor(13762560)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, colorFactory_0.GetColor(16646144)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(11712968, 14015205, 0);
		Office2007GalleryColorTable gallery = office2007ColorTable_0.Gallery;
		gallery.GroupLabelBackground = colorFactory_0.GetColor(15461355);
		gallery.GroupLabelText = colorFactory_0.GetColor(5002076);
		gallery.GroupLabelBorder = colorFactory_0.GetColor(12961221);
		office2007ColorTable_0.ListViewEx.Border = colorFactory_0.GetColor(7303284);
		office2007ColorTable_0.ListViewEx.ColumnBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16777215), colorFactory_0.GetColor(13948891));
		office2007ColorTable_0.ListViewEx.ColumnSeparator = colorFactory_0.GetColor(7237007);
		office2007ColorTable_0.ListViewEx.SelectionBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10997232), Color.Empty);
		office2007ColorTable_0.ListViewEx.SelectionBorder = colorFactory_0.GetColor(14938111);
		office2007ColorTable_0.NavigationPane.ButtonBackground = new GradientColorTable();
		office2007ColorTable_0.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15462138), 0f));
		office2007ColorTable_0.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(14080740), 0.4f));
		office2007ColorTable_0.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(12961745), 0.4f));
		office2007ColorTable_0.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(13949154), 1f));
		office2007ColorTable_0.SuperTooltip.BackgroundColors = new LinearGradientColorTable(colorFactory_0.GetColor(16777215), colorFactory_0.GetColor(15000816));
		office2007ColorTable_0.SuperTooltip.TextColor = colorFactory_0.GetColor(5000268);
		Office2007SliderColorTable slider = office2007ColorTable_0.Slider;
		slider.Default.LabelColor = colorFactory_0.GetColor(2303530);
		slider.Default.PartBackground = new GradientColorTable();
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16777215), 0f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15856114), 0.15f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(12435651), 0.5f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(7896453), 0.5f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16316665), 0.85f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16777215), 1f));
		slider.Default.PartBorderColor = colorFactory_0.GetColor(4014923);
		slider.Default.PartBorderLightColor = Color.FromArgb(28, colorFactory_0.GetColor(16777215));
		slider.Default.PartForeColor = colorFactory_0.GetColor(6252401);
		slider.Default.PartForeLightColor = Color.FromArgb(168, colorFactory_0.GetColor(15461356));
		slider.Default.TrackLineColor = colorFactory_0.GetColor(2434341);
		slider.Default.TrackLineLightColor = colorFactory_0.GetColor(13421772);
		slider.MouseOver.LabelColor = colorFactory_0.GetColor(2303530);
		slider.MouseOver.PartBackground = new GradientColorTable();
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16777215), 0f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16776693), 0.2f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16768899), 0.5f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(14526221), 0.5f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16774350), 0.85f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16774350), 1f));
		slider.MouseOver.PartBorderColor = colorFactory_0.GetColor(3092271);
		slider.MouseOver.PartBorderLightColor = Color.FromArgb(28, colorFactory_0.GetColor(16777215));
		slider.MouseOver.PartForeColor = colorFactory_0.GetColor(6775369);
		slider.MouseOver.PartForeLightColor = Color.FromArgb(168, colorFactory_0.GetColor(16776955));
		slider.MouseOver.TrackLineColor = colorFactory_0.GetColor(2434341);
		slider.MouseOver.TrackLineLightColor = colorFactory_0.GetColor(13421772);
		slider.Pressed.LabelColor = colorFactory_0.GetColor(2303530);
		slider.Pressed.PartBackground = new GradientColorTable();
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15959586), 0f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15901267), 0.2f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16368011), 0.5f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15760912), 0.5f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15976092), 0.85f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16572615), 1f));
		slider.Pressed.PartBorderColor = colorFactory_0.GetColor(3092271);
		slider.Pressed.PartBorderLightColor = Color.FromArgb(28, colorFactory_0.GetColor(16777215));
		slider.Pressed.PartForeColor = colorFactory_0.GetColor(6771265);
		slider.Pressed.PartForeLightColor = Color.FromArgb(168, colorFactory_0.GetColor(16770766));
		slider.Pressed.TrackLineColor = colorFactory_0.GetColor(2434341);
		slider.Pressed.TrackLineLightColor = colorFactory_0.GetColor(13421772);
		ColorBlendFactory colorBlendFactory = new ColorBlendFactory(ColorScheme.GetColor(13619151));
		slider.Disabled.LabelColor = colorFactory_0.GetColor(9276813);
		slider.Disabled.PartBackground = new GradientColorTable();
		foreach (BackgroundColorBlend color in slider.Default.PartBackground.Colors)
		{
			slider.Disabled.PartBackground.Colors.Add(new BackgroundColorBlend(colorBlendFactory.GetColor(color.Color), color.Position));
		}
		slider.Disabled.PartBorderColor = colorBlendFactory.GetColor(slider.Default.PartBorderColor);
		slider.Disabled.PartBorderLightColor = colorBlendFactory.GetColor(slider.Default.PartBorderLightColor);
		slider.Disabled.PartForeColor = colorBlendFactory.GetColor(slider.Default.PartForeColor);
		slider.Disabled.PartForeLightColor = colorBlendFactory.GetColor(slider.Default.PartForeLightColor);
		slider.Disabled.TrackLineColor = colorBlendFactory.GetColor(slider.Default.TrackLineColor);
		slider.Disabled.TrackLineLightColor = colorBlendFactory.GetColor(slider.Default.TrackLineLightColor);
		office2007ColorTable_0.DataGridView.ColumnHeaderNormalBorder = colorFactory_0.GetColor(9474450);
		office2007ColorTable_0.DataGridView.ColumnHeaderNormalBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15856627), colorFactory_0.GetColor(13158858), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderSelectedBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16764057), colorFactory_0.GetColor(16751464), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderSelectedBorder = colorFactory_0.GetColor(13923901);
		office2007ColorTable_0.DataGridView.ColumnHeaderSelectedMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14145495), colorFactory_0.GetColor(10790052), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderSelectedMouseOverBorder = colorFactory_0.GetColor(13923901);
		office2007ColorTable_0.DataGridView.ColumnHeaderMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13684944), colorFactory_0.GetColor(10921638), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderMouseOverBorder = colorFactory_0.GetColor(10331049);
		office2007ColorTable_0.DataGridView.ColumnHeaderPressedBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13684944), colorFactory_0.GetColor(10921638), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderPressedBorder = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.DataGridView.RowNormalBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15198183));
		office2007ColorTable_0.DataGridView.RowNormalBorder = colorFactory_0.GetColor(9474450);
		office2007ColorTable_0.DataGridView.RowSelectedBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16107413));
		office2007ColorTable_0.DataGridView.RowSelectedBorder = colorFactory_0.GetColor(13923901);
		office2007ColorTable_0.DataGridView.RowSelectedMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15567694));
		office2007ColorTable_0.DataGridView.RowSelectedMouseOverBorder = colorFactory_0.GetColor(13923901);
		office2007ColorTable_0.DataGridView.RowMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12107716));
		office2007ColorTable_0.DataGridView.RowMouseOverBorder = colorFactory_0.GetColor(10331049);
		office2007ColorTable_0.DataGridView.RowPressedBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12107716));
		office2007ColorTable_0.DataGridView.RowPressedBorder = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.DataGridView.GridColor = colorFactory_0.GetColor(13686757);
		office2007ColorTable_0.DataGridView.SelectorBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13027014));
		office2007ColorTable_0.DataGridView.SelectorBorder = colorFactory_0.GetColor(9474450);
		office2007ColorTable_0.DataGridView.SelectorBorderDark = colorFactory_0.GetColor(12829635);
		office2007ColorTable_0.DataGridView.SelectorBorderLight = colorFactory_0.GetColor(16382457);
		office2007ColorTable_0.DataGridView.SelectorSign = new LinearGradientColorTable(colorFactory_0.GetColor(16645629), colorFactory_0.GetColor(15724527));
		office2007ColorTable_0.DataGridView.SelectorMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10592673));
		office2007ColorTable_0.DataGridView.SelectorMouseOverBorder = colorFactory_0.GetColor(9474450);
		office2007ColorTable_0.DataGridView.SelectorMouseOverBorderDark = colorFactory_0.GetColor(12829635);
		office2007ColorTable_0.DataGridView.SelectorMouseOverBorderLight = colorFactory_0.GetColor(16382457);
		office2007ColorTable_0.DataGridView.SelectorMouseOverSign = new LinearGradientColorTable(colorFactory_0.GetColor(16645629), colorFactory_0.GetColor(15724527));
		office2007ColorTable_0.SideBar.Background = new LinearGradientColorTable(colorFactory_0.GetColor(Color.White));
		office2007ColorTable_0.SideBar.Border = colorFactory_0.GetColor(7303284);
		office2007ColorTable_0.SideBar.SideBarPanelItemText = colorFactory_0.GetColor(3355443);
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault = new GradientColorTable();
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15462138), 0f));
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(14080740), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(12961745), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(13949154), 1f));
		office2007ColorTable_0.SideBar.SideBarPanelItemExpanded = new GradientColorTable();
		office2007ColorTable_0.SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16505781), 0f));
		office2007ColorTable_0.SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16697208), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16692310), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16640927), 1f));
		office2007ColorTable_0.SideBar.SideBarPanelItemMouseOver = new GradientColorTable();
		office2007ColorTable_0.SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16776409), 0f));
		office2007ColorTable_0.SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16770957), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16766792), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16770963), 1f));
		office2007ColorTable_0.SideBar.SideBarPanelItemPressed = new GradientColorTable();
		office2007ColorTable_0.SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16300137), 0f));
		office2007ColorTable_0.SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16622433), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16484924), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16694112), 1f));
		office2007ColorTable_0.AdvTree = new TreeColorTable();
		Class5.smethod_1(office2007ColorTable_0.AdvTree, colorFactory_0);
		office2007ColorTable_0.CrumbBarItemView = new CrumbBarItemViewColorTable();
		CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		office2007ColorTable_0.CrumbBarItemView.Default = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_0.GetColor(3355443);
		crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		office2007ColorTable_0.CrumbBarItemView.MouseOver = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_0.GetColor(3355443);
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFFCE4"), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFECA1"), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFD842"), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFE47B"), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_0.GetColor("FFDBCE99");
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_0.GetColor("90FFFFFF");
		crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		office2007ColorTable_0.CrumbBarItemView.MouseOverInactive = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_0.GetColor(3355443);
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFFDEC"), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFF4CA"), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFEBA6"), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFF2C5"), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_0.GetColor("FF8E8F8F");
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_0.GetColor("90FFFFFF");
		crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		office2007ColorTable_0.CrumbBarItemView.Pressed = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_0.GetColor(3355443);
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor("FFDCA36F"), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFF2B077"), 0.1f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFE57840"), 0.6f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFDE550A"), 0.6f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFEF7D31"), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_0.GetColor("FF8B7654");
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_0.GetColor("408B7654");
		office2007ColorTable_0.StyleClasses.Clear();
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonGalleryContainerKey;
		elementStyle.BorderColor = colorFactory_0.GetColor(11121080);
		elementStyle.Border = eStyleBorderType.Solid;
		elementStyle.BorderWidth = 1;
		elementStyle.CornerDiameter = 2;
		elementStyle.CornerType = eCornerType.Rounded;
		elementStyle.BackColor = colorFactory_0.GetColor(15264492);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_43(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_44(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_45(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_46(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_47(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_48(colorFactory_0.GetColor(10790052));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_53(colorFactory_0.GetColor(10790052));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_54(colorFactory_0, eOffice2007ColorScheme.Silver);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_55(office2007ColorTable_0.ListViewEx);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_56(office2007ColorTable_0.Bar);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_49(colorFactory_0.GetColor(10790052));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_50(colorFactory_0.GetColor(15856627), colorFactory_0.GetColor(13158858), colorFactory_0.GetColor(9474450));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_51(colorFactory_0.GetColor(15856627), colorFactory_0.GetColor(13158858), colorFactory_0.GetColor(9474450));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_52(colorFactory_0.GetColor(0));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_57(colorFactory_0.GetColor(Color.White), colorFactory_0.GetColor("FFACAFB7"), colorFactory_0.GetColor("FF5A5B5C"));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
	}

	public static void smethod_20(ColorScheme colorScheme_0, ColorFactory colorFactory_0)
	{
		colorScheme_0.BarBackground = colorFactory_0.GetColor(15921913);
		colorScheme_0.BarBackground2 = colorFactory_0.GetColor(10065845);
		colorScheme_0.BarStripeColor = colorFactory_0.GetColor(7237007);
		colorScheme_0.BarCaptionBackground = colorFactory_0.GetColor(8026521);
		colorScheme_0.BarCaptionBackground2 = colorFactory_0.GetColor(6447481);
		colorScheme_0.BarCaptionInactiveBackground = colorFactory_0.GetColor(16185336);
		colorScheme_0.BarCaptionInactiveBackground2 = colorFactory_0.GetColor(14344166);
		colorScheme_0.BarCaptionInactiveText = colorFactory_0.GetColor(3355443);
		colorScheme_0.BarCaptionText = colorFactory_0.GetColor(16777215);
		colorScheme_0.BarFloatingBorder = colorFactory_0.GetColor(8026521);
		colorScheme_0.BarPopupBackground = colorFactory_0.GetColor(16644863);
		colorScheme_0.BarPopupBorder = colorFactory_0.GetColor(8026521);
		colorScheme_0.ItemBackground = Color.Empty;
		colorScheme_0.ItemBackground2 = Color.Empty;
		colorScheme_0.ItemCheckedBackground = colorFactory_0.GetColor(16764818);
		colorScheme_0.ItemCheckedBackground2 = colorFactory_0.GetColor(16756553);
		colorScheme_0.ItemCheckedBorder = colorFactory_0.GetColor(16755519);
		colorScheme_0.ItemCheckedText = colorFactory_0.GetColor(0);
		colorScheme_0.ItemDisabledBackground = Color.Empty;
		colorScheme_0.ItemDisabledText = colorFactory_0.GetColor(9276813);
		colorScheme_0.ItemExpandedShadow = Color.Empty;
		colorScheme_0.ItemExpandedBackground = colorFactory_0.GetColor(15264241);
		colorScheme_0.ItemExpandedBackground2 = colorFactory_0.GetColor(12237261);
		colorScheme_0.ItemExpandedText = colorFactory_0.GetColor(0);
		colorScheme_0.ItemHotBackground = colorFactory_0.GetColor(16774604);
		colorScheme_0.ItemHotBackground2 = colorFactory_0.GetColor(16768900);
		colorScheme_0.ItemHotBorder = colorFactory_0.GetColor(16760169);
		colorScheme_0.ItemHotText = colorFactory_0.GetColor(0);
		colorScheme_0.ItemPressedBackground = colorFactory_0.GetColor(16553789);
		colorScheme_0.ItemPressedBackground2 = colorFactory_0.GetColor(16758878);
		colorScheme_0.ItemPressedBorder = colorFactory_0.GetColor(16485436);
		colorScheme_0.ItemPressedText = colorFactory_0.GetColor(0);
		colorScheme_0.ItemSeparator = Color.FromArgb(225, colorFactory_0.GetColor(7237007));
		colorScheme_0.ItemSeparatorShade = Color.FromArgb(180, colorFactory_0.GetColor(16777215));
		colorScheme_0.ItemText = colorFactory_0.GetColor(0);
		colorScheme_0.MenuBackground = colorFactory_0.GetColor(16644863);
		colorScheme_0.MenuBackground2 = Color.Empty;
		colorScheme_0.MenuBarBackground = colorFactory_0.GetColor(15066606);
		colorScheme_0.MenuBorder = colorFactory_0.GetColor(8158356);
		colorScheme_0.ItemExpandedBorder = colorScheme_0.MenuBorder;
		colorScheme_0.MenuSide = colorFactory_0.GetColor(15724527);
		colorScheme_0.MenuSide2 = Color.Empty;
		colorScheme_0.MenuUnusedBackground = colorScheme_0.MenuBackground;
		colorScheme_0.MenuUnusedSide = colorFactory_0.GetColor(15329769);
		colorScheme_0.MenuUnusedSide2 = Color.Empty;
		colorScheme_0.ItemDesignTimeBorder = Color.Black;
		colorScheme_0.BarDockedBorder = colorFactory_0.GetColor(7303284);
		colorScheme_0.DockSiteBackColor = colorFactory_0.GetColor(14145509);
		colorScheme_0.DockSiteBackColor2 = colorFactory_0.GetColor(15987703);
		colorScheme_0.CustomizeBackground = colorFactory_0.GetColor(11776712);
		colorScheme_0.CustomizeBackground2 = colorFactory_0.GetColor(7763090);
		colorScheme_0.CustomizeText = colorFactory_0.GetColor(0);
		colorScheme_0.PanelBackground = colorFactory_0.GetColor(15790578);
		colorScheme_0.PanelBackground2 = colorFactory_0.GetColor(12436169);
		colorScheme_0.PanelText = Color.Black;
		colorScheme_0.PanelBorder = colorFactory_0.GetColor(7303284);
		colorScheme_0.ExplorerBarBackground = colorFactory_0.GetColor(15987703);
		colorScheme_0.ExplorerBarBackground2 = colorFactory_0.GetColor(14145509);
	}
}

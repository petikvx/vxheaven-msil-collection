using System;
using System.Drawing;
using DevComponents.AdvTree.Display;

namespace DevComponents.DotNetBar.Rendering;

internal class Class224
{
	public static void smethod_0(Office2007ButtonItemColorTable office2007ButtonItemColorTable_0, ColorFactory colorFactory_0)
	{
		Color color = colorFactory_0.GetColor(5668273);
		Color color2 = colorFactory_0.GetColor(15397625);
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

	public static void smethod_1(Office2007ButtonItemColorTable office2007ButtonItemColorTable_0, ColorFactory colorFactory_0)
	{
		Color color = colorFactory_0.GetColor(4605510);
		Color color2 = colorFactory_0.GetColor(14408668);
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

	public static Office2007ButtonItemColorTable smethod_2(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(1393291);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14536603), colorFactory_0.GetColor(12625782));
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777207), colorFactory_0.GetColor(16773822));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16776409), colorFactory_0.GetColor(16770957));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16766792), colorFactory_0.GetColor(16770963));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(132, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14402420), colorFactory_0.GetColor(14402419));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16773311), colorFactory_0.GetColor(16774361));
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(1393291);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(6258614), colorFactory_0.GetColor(12892584));
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11636829), colorFactory_0.GetColor(16624913));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16300137), colorFactory_0.GetColor(16622433));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16484924), colorFactory_0.GetColor(16694112));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16768166), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11566411), colorFactory_0.GetColor(9467987));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16433300), colorFactory_0.GetColor(16767404));
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(5486);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13350041), colorFactory_0.GetColor(16770175));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15454644), Color.Transparent);
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16505781), colorFactory_0.GetColor(16697208));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16692310), colorFactory_0.GetColor(16640927));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16640927), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(5486);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9339237), colorFactory_0.GetColor(13025458));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15052373), colorFactory_0.GetColor(16764717));
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16569255), colorFactory_0.GetColor(16427099));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16289322), colorFactory_0.GetColor(16507286));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16642480), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11566411), colorFactory_0.GetColor(9467987));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16433300), colorFactory_0.GetColor(16767404));
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(5486);
		smethod_0(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_3(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_2(colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14938111), colorFactory_0.GetColor(12901887));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11391487), colorFactory_0.GetColor(12639231));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7836601), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15266300), colorFactory_0.GetColor(15331836));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13820404), colorFactory_0.GetColor(15463421));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7836601), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.Text = colorFactory_0.GetColor(9276813);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_4(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(1393291);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3889794), Color.Empty);
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777211), colorFactory_0.GetColor(14741247));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12639487), colorFactory_0.GetColor(11128575));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10931711), colorFactory_0.GetColor(13296127));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(124, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7640514), colorFactory_0.GetColor(9482198));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14083059), colorFactory_0.GetColor(8627664));
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(1393291);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3889794), Color.Empty);
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777211), colorFactory_0.GetColor(14741247));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12967160), colorFactory_0.GetColor(11127543));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(96, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(9484010), colorFactory_0.GetColor(7640514));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(184, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7640514), colorFactory_0.GetColor(9482198));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14083059), colorFactory_0.GetColor(8627664));
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(5486);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5668272), colorFactory_0.GetColor(5668272));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9484010), colorFactory_0.GetColor(7640514));
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14149369), colorFactory_0.GetColor(13098232));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11784437), colorFactory_0.GetColor(14149111));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(92, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(5486);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(6391735), colorFactory_0.GetColor(5014472));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10663117), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14149369), colorFactory_0.GetColor(13098232));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11784437), colorFactory_0.GetColor(14149111));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5471928), colorFactory_0.GetColor(6915498));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(10141941), colorFactory_0.GetColor(12179455));
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(5486);
		smethod_0(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_5(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_4(colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14938111), colorFactory_0.GetColor(12901887));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11391487), colorFactory_0.GetColor(12639231));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7836601), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15266300), colorFactory_0.GetColor(15331836));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13820404), colorFactory_0.GetColor(15463421));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7836601), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.Text = colorFactory_0.GetColor(9276813);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_6(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(1393291);
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
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(5486);
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
		smethod_0(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_7(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_6(colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14938111), colorFactory_0.GetColor(12901887));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11391487), colorFactory_0.GetColor(12639231));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7836601), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15266300), colorFactory_0.GetColor(15331836));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13820404), colorFactory_0.GetColor(15463421));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7836601), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.Text = colorFactory_0.GetColor(9276813);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_8(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13365499), colorFactory_0.GetColor(7322597));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(6731231), colorFactory_0.GetColor(10677750));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(11664639), Color.Empty);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.White, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7970230), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(Color.WhiteSmoke), colorFactory_0.GetColor(Color.LightGray));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(Color.Silver), colorFactory_0.GetColor(15463421));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.WhiteSmoke, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7970230), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.Text = colorFactory_0.GetColor(9276813);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16579042), colorFactory_0.GetColor(16510399));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16439370), colorFactory_0.GetColor(16573845));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(Color.White, Color.Empty);
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12560249), Color.Empty);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12560249), Color.Empty);
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Empty);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16300664), colorFactory_0.GetColor(16560718));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16555023), colorFactory_0.GetColor(16562743));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15837002), Color.Empty);
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Empty);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16579042), colorFactory_0.GetColor(16510399));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16439370), colorFactory_0.GetColor(16573845));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(Color.White, Color.Empty);
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15837002), Color.Empty);
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16562743), colorFactory_0.GetColor(16555023));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16560718), colorFactory_0.GetColor(16300664));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15837002), Color.Empty);
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Empty);
		return office2007ButtonItemColorTable;
	}

	public static Office2007RibbonBarStateColorTable smethod_9(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12964575), colorFactory_0.GetColor(10403803));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15199991), colorFactory_0.GetColor(15857661));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14608629), colorFactory_0.GetColor(13754352));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13097197), colorFactory_0.GetColor(14215413));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12769521), colorFactory_0.GetColor(12638447));
		office2007RibbonBarStateColorTable.TitleText = colorFactory_0.GetColor(4090538);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable smethod_10(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11388894), colorFactory_0.GetColor(8302035));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777215), colorFactory_0.GetColor(16777215));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15003645), colorFactory_0.GetColor(15266044));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14478075), colorFactory_0.GetColor(14477560));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13164799), colorFactory_0.GetColor(14085631));
		office2007RibbonBarStateColorTable.TitleText = colorFactory_0.GetColor(4090553);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable smethod_11(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(8821678), colorFactory_0.GetColor(11651033));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11387356), colorFactory_0.GetColor(8955856));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(7772616), colorFactory_0.GetColor(11851261));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12835314), Color.Empty);
		office2007RibbonBarStateColorTable.TitleText = Color.Empty;
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_12(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15791870), colorFactory_0.GetColor(14411509));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16317439), colorFactory_0.GetColor(12581631));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9943526), colorFactory_0.GetColor(9286371));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15463422), colorFactory_0.GetColor(14805750));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16444870), colorFactory_0.GetColor(16777149));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14138506), colorFactory_0.GetColor(16699742));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(13490912), colorFactory_0.GetColor(14995607));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(12902143), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14675455), colorFactory_0.GetColor(13099007));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10009577), colorFactory_0.GetColor(10009577));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(1393291);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_13(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(13945058), colorFactory_0.GetColor(15525874));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15525875), colorFactory_0.GetColor(13484767));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12499649), colorFactory_0.GetColor(12632001));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(13945058), colorFactory_0.GetColor(15525874));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15525875), colorFactory_0.GetColor(13484767));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12499649), colorFactory_0.GetColor(12632001));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(12899832), colorFactory_0.GetColor(12762344));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(14609663), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14741247), colorFactory_0.GetColor(13099007));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12699857), colorFactory_0.GetColor(12634064));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(1393291);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_14(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15004640), colorFactory_0.GetColor(15004383));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14019283), colorFactory_0.GetColor(12115633));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12173751), colorFactory_0.GetColor(12566974));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15004640), colorFactory_0.GetColor(15004383));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14019283), colorFactory_0.GetColor(12115633));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12173751), colorFactory_0.GetColor(12566974));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(11788003), colorFactory_0.GetColor(9100959));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(14609663), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14872575), colorFactory_0.GetColor(13099007));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12699857), colorFactory_0.GetColor(12634064));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(1393291);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_15(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16774559), colorFactory_0.GetColor(16775893));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16776150), colorFactory_0.GetColor(16642700));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13289388), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16774559), colorFactory_0.GetColor(16775893));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16776150), colorFactory_0.GetColor(16642700));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13289388), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(13623521), colorFactory_0.GetColor(15329177));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(13361919), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14872575), colorFactory_0.GetColor(13099007));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12699857), colorFactory_0.GetColor(12634064));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(1393291);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_16(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(13483991));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(13658313)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(1393291);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_17(ColorFactory colorFactory_0)
	{
		return smethod_16(colorFactory_0);
	}

	public static Office2007RibbonTabGroupColorTable smethod_18(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(10936974));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(7059796)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(1393291);
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_19(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(15527849));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(16770585)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(1393291);
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonBarStateColorTable smethod_20(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11448500), colorFactory_0.GetColor(8487297));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15330286), colorFactory_0.GetColor(15461355));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13554650), colorFactory_0.GetColor(12699343));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11844549), colorFactory_0.GetColor(15068396));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11974840), colorFactory_0.GetColor(10264222));
		office2007RibbonBarStateColorTable.TitleText = colorFactory_0.GetColor(16777215);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable smethod_21(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11448500), colorFactory_0.GetColor(8487297));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16119543), colorFactory_0.GetColor(15857142));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15527664), colorFactory_0.GetColor(15198700));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14935529), colorFactory_0.GetColor(16054006));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11185067), colorFactory_0.GetColor(7171694));
		office2007RibbonBarStateColorTable.TitleText = colorFactory_0.GetColor(16777215);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable smethod_22(ColorFactory colorFactory_0)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(8158332), colorFactory_0.GetColor(12237498));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12632256), colorFactory_0.GetColor(11383224));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10396588), colorFactory_0.GetColor(14014424));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12763842), Color.Empty);
		office2007RibbonBarStateColorTable.TitleText = Color.Empty;
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_23(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(16777215);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15658735), colorFactory_0.GetColor(13554393));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15988213), colorFactory_0.GetColor(12121852));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12500670), colorFactory_0.GetColor(12500670));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(0);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(15593199), colorFactory_0.GetColor(13291478));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(92, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16444354), colorFactory_0.GetColor(16777149));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15252338), colorFactory_0.GetColor(16699742));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(0);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(9737106), colorFactory_0.GetColor(9339471));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(15581735), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9934485), colorFactory_0.GetColor(9667917));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9868949), colorFactory_0.GetColor(11577734));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(16777215);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_24(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(16777215);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(13945058), colorFactory_0.GetColor(15459826));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14801387), colorFactory_0.GetColor(13484767));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12368321), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(0);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(13945058), colorFactory_0.GetColor(15459826));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13022937), colorFactory_0.GetColor(13484767));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12368321), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(0);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(9145745), colorFactory_0.GetColor(8352917));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(9008797), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9079695), colorFactory_0.GetColor(8352917));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10066074), colorFactory_0.GetColor(10526370));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(16777215);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_25(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(16777215);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(12706488), colorFactory_0.GetColor(14938589));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15004640), colorFactory_0.GetColor(12115633));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11583660), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(0);
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(12706488), colorFactory_0.GetColor(14938589));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10802326), colorFactory_0.GetColor(12115633));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11583660), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(0);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(9015431), colorFactory_0.GetColor(6656600));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(7118172), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(8883334), colorFactory_0.GetColor(6656599));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9935255), colorFactory_0.GetColor(10331035));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(16777215);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable smethod_26(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = colorFactory_0.GetColor(16777215);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16774559), colorFactory_0.GetColor(16775893));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16776150), colorFactory_0.GetColor(16577429));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13289387), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = colorFactory_0.GetColor(0);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16774559), colorFactory_0.GetColor(16775893));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16773233), colorFactory_0.GetColor(16577429));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13289387), colorFactory_0.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = colorFactory_0.GetColor(0);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(colorFactory_0.GetColor(9605251), colorFactory_0.GetColor(11970867));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(12760369), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9407875), colorFactory_0.GetColor(11641907));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10263446), colorFactory_0.GetColor(12500670));
		office2007RibbonTabItemColorTable.MouseOver.Text = colorFactory_0.GetColor(16777215);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_27(bool bool_0, ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14536603), colorFactory_0.GetColor(12626039));
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777207), colorFactory_0.GetColor(16775062));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16776409), colorFactory_0.GetColor(16770957));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16766792), colorFactory_0.GetColor(16770963));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14402420), colorFactory_0.GetColor(13155212));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16773311), colorFactory_0.GetColor(16774879));
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9139796), colorFactory_0.GetColor(12892584));
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15312993), colorFactory_0.GetColor(16624913));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16299370), colorFactory_0.GetColor(16556128));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16484924), colorFactory_0.GetColor(16694626));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16769199), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11566411), colorFactory_0.GetColor(9467987));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16433300), colorFactory_0.GetColor(16767404));
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10450265), colorFactory_0.GetColor(16764717));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15454644), Color.Transparent);
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16505781), colorFactory_0.GetColor(16697208));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16692310), colorFactory_0.GetColor(16640927));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16774559), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9339237), colorFactory_0.GetColor(13025458));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15052373), colorFactory_0.GetColor(16766538));
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16569255), colorFactory_0.GetColor(16427099));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(128, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16289065), colorFactory_0.GetColor(16639129));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(16774857), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11566411), colorFactory_0.GetColor(9139796));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16433300), colorFactory_0.GetColor(16767147));
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(0);
		smethod_1(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_28(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_27(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16316665), colorFactory_0.GetColor(14672612));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13093841), colorFactory_0.GetColor(14409442));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(128, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9013125), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13554650), colorFactory_0.GetColor(12699343));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11844549), colorFactory_0.GetColor(15068396));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12964318), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.Text = colorFactory_0.GetColor(9276813);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_29(bool bool_0, ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3889794), Color.Empty);
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777211), colorFactory_0.GetColor(14741247));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12639487), colorFactory_0.GetColor(11128575));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10931711), colorFactory_0.GetColor(13296127));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(124, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7640514), colorFactory_0.GetColor(9482198));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14083059), colorFactory_0.GetColor(8627664));
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3889794), Color.Empty);
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16777211), colorFactory_0.GetColor(14741247));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12967160), colorFactory_0.GetColor(11127543));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(96, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(9484010), colorFactory_0.GetColor(7640514));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(184, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7640514), colorFactory_0.GetColor(9482198));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(14083059), colorFactory_0.GetColor(8627664));
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5668272), colorFactory_0.GetColor(5668272));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9484010), colorFactory_0.GetColor(7640514));
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14149369), colorFactory_0.GetColor(13098232));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11784437), colorFactory_0.GetColor(14149111));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(92, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(6391735), colorFactory_0.GetColor(5014472));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(10663117), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14149369), colorFactory_0.GetColor(13098232));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11784437), colorFactory_0.GetColor(14149111));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5471928), colorFactory_0.GetColor(6915498));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(10141941), colorFactory_0.GetColor(12179455));
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(0);
		smethod_1(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_30(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_29(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16316665), colorFactory_0.GetColor(14672612));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13093841), colorFactory_0.GetColor(14409442));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(128, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9013125), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13554650), colorFactory_0.GetColor(12699343));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11844549), colorFactory_0.GetColor(15068396));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12964318), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.Text = colorFactory_0.GetColor(9276813);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_31(bool bool_0, ColorFactory colorFactory_0)
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
		smethod_1(office2007ButtonItemColorTable, colorFactory_0);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable smethod_32(ColorFactory colorFactory_0)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_31(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16316665), colorFactory_0.GetColor(14672612));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13093841), colorFactory_0.GetColor(14409442));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(128, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(9013125), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13554650), colorFactory_0.GetColor(12699343));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11844549), colorFactory_0.GetColor(15068396));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(4934475), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.Text = colorFactory_0.GetColor(9276813);
		return office2007ButtonItemColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_33(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(10526880));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(13487565)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(16777215);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_34(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(9465999));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(11500962)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(16777215);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_35(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(7249757));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, colorFactory_0.GetColor(7059796)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(16777215);
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable smethod_36(ColorFactory colorFactory_0)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, colorFactory_0.GetColor(10918721));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(255, colorFactory_0.GetColor(16769792)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		office2007RibbonTabGroupColorTable.Text = colorFactory_0.GetColor(16777215);
		return office2007RibbonTabGroupColorTable;
	}

	public static void smethod_37(Office2007ColorTable office2007ColorTable_0, ColorFactory colorFactory_0)
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
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(12571114), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13295610), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11193334), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11193334), 0.7f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13886714), 1f)
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

	public static void smethod_38(Office2007ColorTable office2007ColorTable_0, ColorFactory colorFactory_0)
	{
		Office2007ScrollBarStateColorTable @default = office2007ColorTable_0.AppScrollBar.Default;
		@default.Background = new LinearGradientColorTable(colorFactory_0.GetColor(9810130), colorFactory_0.GetColor(8166337), 0);
		@default.Border = new LinearGradientColorTable(colorFactory_0.GetColor(11718902));
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(7241382), colorFactory_0.GetColor(4344675), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[6]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(14935527), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14936560), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13161697), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11977944), 0.8f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11977944), 0.8f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14804975), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14935527), colorFactory_0.GetColor(14804975));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5859729), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(9146000)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.MouseOver;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(12571114), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13295610), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11193334), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11193334), 0.7f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13886714), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(15329771), colorFactory_0.GetColor(16580095));
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3960496), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(7241382), colorFactory_0.GetColor(4344675), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = @default.ThumbInnerBorder;
		@default.TrackOuterBorder = @default.ThumbOuterBorder;
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(8226450)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.MouseOverControl;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.CopyFrom(office2007ColorTable_0.AppScrollBar.Default.TrackBackground);
		@default.ThumbInnerBorder = office2007ColorTable_0.AppScrollBar.Default.TrackInnerBorder;
		@default.ThumbOuterBorder = office2007ColorTable_0.AppScrollBar.Default.TrackOuterBorder;
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(5596557), colorFactory_0.GetColor(3357780));
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(office2007ColorTable_0.AppScrollBar.Default.TrackBackground);
		@default.TrackInnerBorder = office2007ColorTable_0.AppScrollBar.Default.TrackInnerBorder;
		@default.TrackOuterBorder = office2007ColorTable_0.AppScrollBar.Default.TrackOuterBorder;
		@default.TrackSignBackground = office2007ColorTable_0.AppScrollBar.Default.TrackSignBackground;
		@default = office2007ColorTable_0.AppScrollBar.Pressed;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(10337767), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11259126), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(7251696), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(7251696), 0.7f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11915767), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12768231), colorFactory_0.GetColor(14543867));
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(1526154), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(7241382), colorFactory_0.GetColor(4344675), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12768231), colorFactory_0.GetColor(14543867));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(1526154), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(8487297)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.Disabled;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbInnerBorder = new LinearGradientColorTable();
		@default.ThumbOuterBorder = new LinearGradientColorTable();
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12570615), colorFactory_0.GetColor(7502996));
		@default.TrackBackground.Clear();
		@default.TrackInnerBorder = new LinearGradientColorTable();
		@default.TrackOuterBorder = new LinearGradientColorTable();
		@default.TrackSignBackground = new LinearGradientColorTable();
	}

	public static void smethod_39(Office2007ColorTable office2007ColorTable_0, ColorFactory colorFactory_0)
	{
		Office2007ScrollBarStateColorTable @default = office2007ColorTable_0.AppScrollBar.Default;
		@default.Background = new LinearGradientColorTable(colorFactory_0.GetColor(11843519));
		@default.Border = new LinearGradientColorTable(colorFactory_0.GetColor(10330022));
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(8225934), colorFactory_0.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(16119286), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(15395564), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14343133), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(12698053), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16382457), colorFactory_0.GetColor(13619154));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(7237491), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(7303023)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.MouseOver;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(14479611), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13232634), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11131894), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11131894), 0.7f),
			new BackgroundColorBlend(colorFactory_0.GetColor(9748696), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16645887), colorFactory_0.GetColor(14409183));
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3964849), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(8225934), colorFactory_0.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = @default.ThumbInnerBorder;
		@default.TrackOuterBorder = @default.ThumbOuterBorder;
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(7303023)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.MouseOverControl;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.CopyFrom(office2007ColorTable_0.AppScrollBar.Default.TrackBackground);
		@default.ThumbInnerBorder = office2007ColorTable_0.AppScrollBar.Default.TrackInnerBorder;
		@default.ThumbOuterBorder = office2007ColorTable_0.AppScrollBar.Default.TrackOuterBorder;
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(8225934), colorFactory_0.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(office2007ColorTable_0.AppScrollBar.Default.TrackBackground);
		@default.TrackInnerBorder = office2007ColorTable_0.AppScrollBar.Default.TrackInnerBorder;
		@default.TrackOuterBorder = office2007ColorTable_0.AppScrollBar.Default.TrackOuterBorder;
		@default.TrackSignBackground = office2007ColorTable_0.AppScrollBar.Default.TrackSignBackground;
		@default = office2007ColorTable_0.AppScrollBar.Pressed;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(12904953), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(10870518), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(7326448), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(7326448), 0.7f),
			new BackgroundColorBlend(colorFactory_0.GetColor(6468051), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14939644), colorFactory_0.GetColor(10405849));
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(1595786), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(8225934), colorFactory_0.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14939644), colorFactory_0.GetColor(10405849));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(1595786), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(8487297)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.Disabled;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbInnerBorder = new LinearGradientColorTable();
		@default.ThumbOuterBorder = new LinearGradientColorTable();
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12570615), colorFactory_0.GetColor(7502996));
		@default.TrackBackground.Clear();
		@default.TrackInnerBorder = new LinearGradientColorTable();
		@default.TrackOuterBorder = new LinearGradientColorTable();
		@default.TrackSignBackground = new LinearGradientColorTable();
	}

	public static void smethod_40(Office2007ColorTable office2007ColorTable_0, ColorFactory colorFactory_0)
	{
		Office2007ScrollBarStateColorTable @default = office2007ColorTable_0.AppScrollBar.Default;
		@default.Background = new LinearGradientColorTable(colorFactory_0.GetColor(4210752));
		@default.Border = new LinearGradientColorTable(colorFactory_0.GetColor(6447714));
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13290186), colorFactory_0.GetColor(7960953), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(16382457), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(15395564), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(14343133), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(12698053), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16382457), colorFactory_0.GetColor(13619154));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3092271), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(7303023)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.MouseOver;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(14479611), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(13232634), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11131894), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(11131894), 0.7f),
			new BackgroundColorBlend(colorFactory_0.GetColor(9748696), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(16645887), colorFactory_0.GetColor(14409183));
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(3964849), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(8618883), colorFactory_0.GetColor(5131854), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = @default.ThumbInnerBorder;
		@default.TrackOuterBorder = @default.ThumbOuterBorder;
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(7303023)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.MouseOverControl;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.CopyFrom(office2007ColorTable_0.AppScrollBar.Default.TrackBackground);
		@default.ThumbInnerBorder = office2007ColorTable_0.AppScrollBar.Default.TrackInnerBorder;
		@default.ThumbOuterBorder = office2007ColorTable_0.AppScrollBar.Default.TrackOuterBorder;
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(8618883), colorFactory_0.GetColor(5131854), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(office2007ColorTable_0.AppScrollBar.Default.TrackBackground);
		@default.TrackInnerBorder = office2007ColorTable_0.AppScrollBar.Default.TrackInnerBorder;
		@default.TrackOuterBorder = office2007ColorTable_0.AppScrollBar.Default.TrackOuterBorder;
		@default.TrackSignBackground = office2007ColorTable_0.AppScrollBar.Default.TrackSignBackground;
		@default = office2007ColorTable_0.AppScrollBar.Pressed;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(12904953), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(10870518), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(7326448), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(7326448), 0.7f),
			new BackgroundColorBlend(colorFactory_0.GetColor(6468051), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14939644), colorFactory_0.GetColor(10405849));
		@default.ThumbOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(1595786), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(8225934), colorFactory_0.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14939644), colorFactory_0.GetColor(10405849));
		@default.TrackOuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(1595786), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, colorFactory_0.GetColor(8487297)), Color.FromArgb(64, Color.White));
		@default = office2007ColorTable_0.AppScrollBar.Disabled;
		@default.Background = office2007ColorTable_0.AppScrollBar.Default.Background;
		@default.Border = office2007ColorTable_0.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbInnerBorder = new LinearGradientColorTable();
		@default.ThumbOuterBorder = new LinearGradientColorTable();
		@default.ThumbSignBackground = new LinearGradientColorTable(colorFactory_0.GetColor(12570615), colorFactory_0.GetColor(7502996));
		@default.TrackBackground.Clear();
		@default.TrackInnerBorder = new LinearGradientColorTable();
		@default.TrackOuterBorder = new LinearGradientColorTable();
		@default.TrackSignBackground = new LinearGradientColorTable();
	}

	public static void smethod_41(Office2007ColorTable office2007ColorTable_0, ColorFactory colorFactory_0)
	{
		office2007ColorTable_0.RibbonBar.Default = smethod_20(colorFactory_0);
		office2007ColorTable_0.RibbonBar.MouseOver = smethod_21(colorFactory_0);
		office2007ColorTable_0.RibbonBar.Expanded = smethod_22(colorFactory_0);
		office2007ColorTable_0.RibbonTabItemColors.Clear();
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = smethod_23(colorFactory_0);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Default);
		office2007ColorTable_0.RibbonTabItemColors.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = smethod_25(colorFactory_0);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Green);
		office2007ColorTable_0.RibbonTabItemColors.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = smethod_24(colorFactory_0);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Magenta);
		office2007ColorTable_0.RibbonTabItemColors.Add(office2007RibbonTabItemColorTable);
		office2007RibbonTabItemColorTable = smethod_26(colorFactory_0);
		office2007RibbonTabItemColorTable.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Orange);
		office2007ColorTable_0.RibbonTabItemColors.Add(office2007RibbonTabItemColorTable);
		office2007ColorTable_0.RibbonControl = new Office2007RibbonColorTable();
		office2007ColorTable_0.RibbonControl.TabsBackground = new LinearGradientColorTable(colorFactory_0.GetColor(5460819), colorFactory_0.GetColor(5460819));
		office2007ColorTable_0.RibbonControl.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13554393), colorFactory_0.GetColor(12500670));
		office2007ColorTable_0.RibbonControl.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5460819), colorFactory_0.GetColor(5197647));
		office2007ColorTable_0.RibbonControl.TabDividerBorder = colorFactory_0.GetColor(4276545);
		office2007ColorTable_0.RibbonControl.TabDividerBorderLight = colorFactory_0.GetColor(6710886);
		office2007ColorTable_0.RibbonControl.PanelTopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14146528), colorFactory_0.GetColor(12699343));
		office2007ColorTable_0.RibbonControl.PanelBottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11844549), colorFactory_0.GetColor(15461355));
		office2007ColorTable_0.RibbonControl.StartButtonDefault = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonNormalBlack.png");
		office2007ColorTable_0.RibbonControl.StartButtonMouseOver = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonHotBlack.png");
		office2007ColorTable_0.RibbonControl.StartButtonPressed = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonPressedBlack.png");
		office2007ColorTable_0.ItemGroup.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14081759), colorFactory_0.GetColor(14410468));
		office2007ColorTable_0.ItemGroup.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13883610), colorFactory_0.GetColor(14738919));
		office2007ColorTable_0.ItemGroup.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(14673638), colorFactory_0.GetColor(15593713));
		office2007ColorTable_0.ItemGroup.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(11384763), colorFactory_0.GetColor(9213338));
		office2007ColorTable_0.ItemGroup.ItemGroupDividerDark = Color.FromArgb(196, colorFactory_0.GetColor(13553358));
		office2007ColorTable_0.ItemGroup.ItemGroupDividerLight = Color.FromArgb(128, colorFactory_0.GetColor(16777215));
		office2007ColorTable_0.Bar.ToolbarTopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(3355443), colorFactory_0.GetColor(3882566));
		office2007ColorTable_0.Bar.ToolbarBottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(3092528), colorFactory_0.GetColor(4539717));
		office2007ColorTable_0.Bar.ToolbarBottomBorder = colorFactory_0.GetColor(5000268);
		office2007ColorTable_0.Bar.PopupToolbarBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16448250), Color.Empty);
		office2007ColorTable_0.Bar.PopupToolbarBorder = colorFactory_0.GetColor(3092271);
		office2007ColorTable_0.Bar.StatusBarTopBorder = colorFactory_0.GetColor(3355443);
		office2007ColorTable_0.Bar.StatusBarTopBorderLight = Color.Empty;
		office2007ColorTable_0.Bar.StatusBarAltBackground.Clear();
		office2007ColorTable_0.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_0.GetColor(13026758), 0f));
		office2007ColorTable_0.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_0.GetColor(11842740), 0.4f));
		office2007ColorTable_0.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_0.GetColor(9935000), 0.4f));
		office2007ColorTable_0.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(colorFactory_0.GetColor(4738130), 1f));
		office2007ColorTable_0.ButtonItemColors.Clear();
		office2007ColorTable_0.RibbonButtonItemColors.Clear();
		office2007ColorTable_0.MenuButtonItemColors.Clear();
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = smethod_27(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_28(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_29(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Blue);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_30(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.BlueWithBackground);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_31(bool_0: false, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Magenta);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_32(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.MagentaWithBackground);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_27(bool_0: true, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_28(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_29(bool_0: true, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Blue);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_30(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.BlueWithBackground);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_31(bool_0: true, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Magenta);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_32(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.MagentaWithBackground);
		office2007ColorTable_0.RibbonButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_27(bool_0: true, colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		office2007ButtonItemColorTable.Default.Text = colorFactory_0.GetColor(16777215);
		office2007ButtonItemColorTable.MouseOver.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Checked.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Expanded.Text = colorFactory_0.GetColor(0);
		office2007ButtonItemColorTable.Pressed.Text = colorFactory_0.GetColor(0);
		office2007ColorTable_0.MenuButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ButtonItemColorTable = smethod_8(colorFactory_0);
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Office2007WithBackground);
		office2007ColorTable_0.ButtonItemColors.Add(office2007ButtonItemColorTable);
		office2007ColorTable_0.ButtonItemColors.Add(ButtonItemStaticColorTables.CreateBlueOrbColorTable(colorFactory_0));
		office2007ColorTable_0.RibbonTabGroupColors.Clear();
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = smethod_33(colorFactory_0);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Default);
		office2007ColorTable_0.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = smethod_34(colorFactory_0);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Magenta);
		office2007ColorTable_0.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = smethod_35(colorFactory_0);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Green);
		office2007ColorTable_0.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = smethod_36(colorFactory_0);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Orange);
		office2007ColorTable_0.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007ColorTable_0.Menu.Background = new LinearGradientColorTable(colorFactory_0.GetColor(16448250), Color.Empty);
		office2007ColorTable_0.Menu.Border = new LinearGradientColorTable(colorFactory_0.GetColor(8816262), Color.Empty);
		office2007ColorTable_0.Menu.Side = new LinearGradientColorTable(colorFactory_0.GetColor(15331054), Color.Empty);
		office2007ColorTable_0.Menu.SideBorder = new LinearGradientColorTable(colorFactory_0.GetColor(12961221), Color.Empty);
		office2007ColorTable_0.Menu.SideBorderLight = new LinearGradientColorTable(colorFactory_0.GetColor(16119285), Color.Empty);
		office2007ColorTable_0.Menu.SideUnused = new LinearGradientColorTable(colorFactory_0.GetColor(15066597), Color.Empty);
		office2007ColorTable_0.Menu.FileBackgroundBlend.Clear();
		office2007ColorTable_0.Menu.FileBackgroundBlend.AddRange(new BackgroundColorBlend[2]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(5328976), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(5131855), 1f)
		});
		office2007ColorTable_0.Menu.FileContainerBorder = colorFactory_0.GetColor(7040113);
		office2007ColorTable_0.Menu.FileContainerBorderLight = colorFactory_0.GetColor(7040113);
		office2007ColorTable_0.Menu.FileColumnOneBackground = colorFactory_0.GetColor(16448250);
		office2007ColorTable_0.Menu.FileColumnOneBorder = colorFactory_0.GetColor(12961221);
		office2007ColorTable_0.Menu.FileColumnTwoBackground = colorFactory_0.GetColor(15330030);
		office2007ColorTable_0.Menu.FileBottomContainerBackgroundBlend.Clear();
		office2007ColorTable_0.Menu.FileBottomContainerBackgroundBlend.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor(4408914), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor(3948618), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(3092271), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor(4210752), 1f)
		});
		office2007ColorTable_0.ComboBox.Default.Background = colorFactory_0.GetColor(15263976);
		office2007ColorTable_0.ComboBox.Default.Border = colorFactory_0.GetColor(9013641);
		office2007ColorTable_0.ComboBox.Default.ExpandBackground = new LinearGradientColorTable();
		office2007ColorTable_0.ComboBox.Default.ExpandBorderInner = new LinearGradientColorTable();
		office2007ColorTable_0.ComboBox.Default.ExpandBorderOuter = new LinearGradientColorTable();
		office2007ColorTable_0.ComboBox.Default.ExpandText = colorFactory_0.GetColor(8158332);
		office2007ColorTable_0.ComboBox.DefaultStandalone.Background = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.ComboBox.DefaultStandalone.Border = colorFactory_0.GetColor(9013641);
		office2007ColorTable_0.ComboBox.DefaultStandalone.ExpandBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15528181), colorFactory_0.GetColor(14673131), 90);
		office2007ColorTable_0.ComboBox.DefaultStandalone.ExpandBorderInner = new LinearGradientColorTable();
		office2007ColorTable_0.ComboBox.DefaultStandalone.ExpandBorderOuter = new LinearGradientColorTable(colorFactory_0.GetColor(12040119), Color.Empty, 90);
		office2007ColorTable_0.ComboBox.DefaultStandalone.ExpandText = colorFactory_0.GetColor(0);
		office2007ColorTable_0.ComboBox.MouseOver.Background = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.ComboBox.MouseOver.Border = colorFactory_0.GetColor(9013641);
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
		smethod_42(office2007ColorTable_0.LegacyColors, colorFactory_0);
		office2007ColorTable_0.SystemButton.Default = new Office2007SystemButtonStateColorTable();
		office2007ColorTable_0.SystemButton.Default.Foreground = new LinearGradientColorTable(colorFactory_0.GetColor(8686741), colorFactory_0.GetColor(10463671));
		office2007ColorTable_0.SystemButton.Default.LightShade = colorFactory_0.GetColor(10463671);
		office2007ColorTable_0.SystemButton.Default.DarkShade = colorFactory_0.GetColor(8487040);
		office2007ColorTable_0.SystemButton.MouseOver = new Office2007SystemButtonStateColorTable();
		office2007ColorTable_0.SystemButton.MouseOver.Foreground = new LinearGradientColorTable(colorFactory_0.GetColor(3552565), colorFactory_0.GetColor(5199715));
		office2007ColorTable_0.SystemButton.MouseOver.LightShade = colorFactory_0.GetColor(10199464);
		office2007ColorTable_0.SystemButton.MouseOver.DarkShade = colorFactory_0.GetColor(4541526);
		office2007ColorTable_0.SystemButton.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11647169), colorFactory_0.GetColor(8950945));
		office2007ColorTable_0.SystemButton.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(6845829), colorFactory_0.GetColor(10334657));
		office2007ColorTable_0.SystemButton.MouseOver.TopHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(13489114), Color.Transparent);
		office2007ColorTable_0.SystemButton.MouseOver.BottomHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(11918836), Color.Transparent);
		office2007ColorTable_0.SystemButton.MouseOver.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(5726317), colorFactory_0.GetColor(6054505));
		office2007ColorTable_0.SystemButton.MouseOver.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(13489114), colorFactory_0.GetColor(14344163));
		office2007ColorTable_0.SystemButton.Pressed = new Office2007SystemButtonStateColorTable();
		office2007ColorTable_0.SystemButton.Pressed.Foreground = new LinearGradientColorTable(colorFactory_0.GetColor(7171180), colorFactory_0.GetColor(9148068));
		office2007ColorTable_0.SystemButton.Pressed.LightShade = colorFactory_0.GetColor(8358036);
		office2007ColorTable_0.SystemButton.Pressed.DarkShade = colorFactory_0.GetColor(7171180);
		office2007ColorTable_0.SystemButton.Pressed.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(3618615), colorFactory_0.GetColor(2829099));
		office2007ColorTable_0.SystemButton.Pressed.TopHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(6842472), Color.Transparent);
		office2007ColorTable_0.SystemButton.Pressed.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(0), colorFactory_0.GetColor(461067));
		office2007ColorTable_0.SystemButton.Pressed.BottomHighlight = new LinearGradientColorTable(colorFactory_0.GetColor(5335426), Color.Transparent);
		office2007ColorTable_0.SystemButton.Pressed.OuterBorder = new LinearGradientColorTable(colorFactory_0.GetColor(2237481), colorFactory_0.GetColor(1644825));
		office2007ColorTable_0.SystemButton.Pressed.InnerBorder = new LinearGradientColorTable(colorFactory_0.GetColor(4605510), colorFactory_0.GetColor(3355443));
		office2007ColorTable_0.Form.Active.BorderColors = new Color[4]
		{
			colorFactory_0.GetColor(3092271),
			colorFactory_0.GetColor(5066061),
			colorFactory_0.GetColor(6710886),
			colorFactory_0.GetColor(4210752)
		};
		office2007ColorTable_0.Form.Inactive.BorderColors = new Color[4]
		{
			colorFactory_0.GetColor(9605778),
			colorFactory_0.GetColor(10461087),
			colorFactory_0.GetColor(11250603),
			colorFactory_0.GetColor(10066329)
		};
		office2007ColorTable_0.Form.Active.CaptionTopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(4409170), colorFactory_0.GetColor(3816773));
		office2007ColorTable_0.Form.Active.CaptionBottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(3092528), colorFactory_0.GetColor(4079166));
		office2007ColorTable_0.Form.Active.CaptionBottomBorder = new Color[2]
		{
			colorFactory_0.GetColor(4737096),
			colorFactory_0.GetColor(4868682)
		};
		office2007ColorTable_0.Form.Active.CaptionText = colorFactory_0.GetColor(11457023);
		office2007ColorTable_0.Form.Active.CaptionTextExtra = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.Form.Inactive.CaptionTopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10132641), colorFactory_0.GetColor(9935004));
		office2007ColorTable_0.Form.Inactive.CaptionBottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(9605778), colorFactory_0.GetColor(10132122));
		office2007ColorTable_0.Form.Inactive.CaptionText = colorFactory_0.GetColor(14803425);
		office2007ColorTable_0.Form.Inactive.CaptionTextExtra = colorFactory_0.GetColor(14803425);
		office2007ColorTable_0.Form.BackColor = colorFactory_0.GetColor(8224125);
		office2007ColorTable_0.Form.TextColor = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.QuickAccessToolbar.Active.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(8093316), colorFactory_0.GetColor(7961472));
		office2007ColorTable_0.QuickAccessToolbar.Active.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(7171694), colorFactory_0.GetColor(4473924));
		office2007ColorTable_0.QuickAccessToolbar.Active.OutterBorderColor = colorFactory_0.GetColor(4671303);
		office2007ColorTable_0.QuickAccessToolbar.Active.MiddleBorderColor = colorFactory_0.GetColor(3487029);
		office2007ColorTable_0.QuickAccessToolbar.Active.InnerBorderColor = Color.Empty;
		office2007ColorTable_0.QuickAccessToolbar.Inactive.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10987434), colorFactory_0.GetColor(11776950));
		office2007ColorTable_0.QuickAccessToolbar.Inactive.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11382189), colorFactory_0.GetColor(9803157));
		office2007ColorTable_0.QuickAccessToolbar.Inactive.OutterBorderColor = colorFactory_0.GetColor(11119017);
		office2007ColorTable_0.QuickAccessToolbar.Inactive.MiddleBorderColor = colorFactory_0.GetColor(6118749);
		office2007ColorTable_0.QuickAccessToolbar.Inactive.InnerBorderColor = Color.Empty;
		office2007ColorTable_0.QuickAccessToolbar.Standalone.TopBackground = new LinearGradientColorTable();
		office2007ColorTable_0.QuickAccessToolbar.Standalone.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(9277587), colorFactory_0.GetColor(8750985));
		office2007ColorTable_0.QuickAccessToolbar.Standalone.OutterBorderColor = colorFactory_0.GetColor(6119524);
		office2007ColorTable_0.QuickAccessToolbar.Standalone.MiddleBorderColor = Color.Empty;
		office2007ColorTable_0.QuickAccessToolbar.Standalone.InnerBorderColor = colorFactory_0.GetColor(13356238);
		office2007ColorTable_0.QuickAccessToolbar.QatCustomizeMenuLabelBackground = colorFactory_0.GetColor(15461355);
		office2007ColorTable_0.QuickAccessToolbar.QatCustomizeMenuLabelText = colorFactory_0.GetColor(4605510);
		office2007ColorTable_0.QuickAccessToolbar.Active.GlassBorder = new LinearGradientColorTable(colorFactory_0.GetColor(Color.FromArgb(132, Color.Black)), Color.FromArgb(80, Color.Black));
		office2007ColorTable_0.QuickAccessToolbar.Inactive.GlassBorder = new LinearGradientColorTable(colorFactory_0.GetColor(Color.FromArgb(132, Color.Black)), Color.FromArgb(80, Color.Black));
		office2007ColorTable_0.TabControl.Default = new Office2007TabItemStateColorTable();
		office2007ColorTable_0.TabControl.Default.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14212322), colorFactory_0.GetColor(11845063));
		office2007ColorTable_0.TabControl.Default.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13949407), colorFactory_0.GetColor(15461355));
		office2007ColorTable_0.TabControl.Default.InnerBorder = colorFactory_0.GetColor(15461355);
		office2007ColorTable_0.TabControl.Default.OuterBorder = colorFactory_0.GetColor(4605510);
		office2007ColorTable_0.TabControl.Default.Text = colorFactory_0.GetColor(3158064);
		office2007ColorTable_0.TabControl.MouseOver = new Office2007TabItemStateColorTable();
		office2007ColorTable_0.TabControl.MouseOver.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16776683), colorFactory_0.GetColor(16772264));
		office2007ColorTable_0.TabControl.MouseOver.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16767577), colorFactory_0.GetColor(16770701));
		office2007ColorTable_0.TabControl.MouseOver.InnerBorder = colorFactory_0.GetColor(16777211);
		office2007ColorTable_0.TabControl.MouseOver.OuterBorder = colorFactory_0.GetColor(11967859);
		office2007ColorTable_0.TabControl.MouseOver.Text = colorFactory_0.GetColor(3552822);
		office2007ColorTable_0.TabControl.Selected = new Office2007TabItemStateColorTable();
		office2007ColorTable_0.TabControl.Selected.TopBackground = new LinearGradientColorTable(colorFactory_0.GetColor(Color.White), colorFactory_0.GetColor(16250871));
		office2007ColorTable_0.TabControl.Selected.BottomBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16250871), colorFactory_0.GetColor(16250871));
		office2007ColorTable_0.TabControl.Selected.InnerBorder = colorFactory_0.GetColor(Color.White);
		office2007ColorTable_0.TabControl.Selected.OuterBorder = colorFactory_0.GetColor(4605510);
		office2007ColorTable_0.TabControl.Selected.Text = colorFactory_0.GetColor(2565927);
		office2007ColorTable_0.TabControl.TabBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16645629), colorFactory_0.GetColor(12829635));
		office2007ColorTable_0.TabControl.TabPanelBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16250871), colorFactory_0.GetColor(12829635));
		office2007ColorTable_0.TabControl.TabPanelBorder = colorFactory_0.GetColor(4605510);
		Office2007CheckBoxColorTable checkBoxItem = office2007ColorTable_0.CheckBoxItem;
		checkBoxItem.Default.CheckBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16053492), Color.Empty);
		checkBoxItem.Default.CheckBorder = colorFactory_0.GetColor(8684676);
		checkBoxItem.Default.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_0.GetColor(10661049)), Color.FromArgb(164, colorFactory_0.GetColor(16185078)));
		checkBoxItem.Default.CheckInnerBorder = colorFactory_0.GetColor(10661049);
		checkBoxItem.Default.CheckSign = new LinearGradientColorTable(colorFactory_0.GetColor(5204093), Color.Empty);
		checkBoxItem.Default.Text = colorFactory_0.GetColor(0);
		checkBoxItem.MouseOver.CheckBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16053492), Color.Empty);
		checkBoxItem.MouseOver.CheckBorder = colorFactory_0.GetColor(8684676);
		checkBoxItem.MouseOver.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_0.GetColor(16438650)), Color.FromArgb(128, colorFactory_0.GetColor(16709863)));
		checkBoxItem.MouseOver.CheckInnerBorder = colorFactory_0.GetColor(16438650);
		checkBoxItem.MouseOver.CheckSign = new LinearGradientColorTable(colorFactory_0.GetColor(5204093), Color.Empty);
		checkBoxItem.MouseOver.Text = colorFactory_0.GetColor(0);
		checkBoxItem.Pressed.CheckBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15068407), Color.Empty);
		checkBoxItem.Pressed.CheckBorder = colorFactory_0.GetColor(8684676);
		checkBoxItem.Pressed.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_0.GetColor(15894822)), Color.FromArgb(164, colorFactory_0.GetColor(16774357)));
		checkBoxItem.Pressed.CheckInnerBorder = colorFactory_0.GetColor(15894822);
		checkBoxItem.Pressed.CheckSign = new LinearGradientColorTable(colorFactory_0.GetColor(5204093), Color.Empty);
		checkBoxItem.Pressed.Text = colorFactory_0.GetColor(0);
		checkBoxItem.Disabled.CheckBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16777215), Color.Empty);
		checkBoxItem.Disabled.CheckBorder = colorFactory_0.GetColor(11448757);
		checkBoxItem.Disabled.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, colorFactory_0.GetColor(14738149)), Color.FromArgb(164, colorFactory_0.GetColor(16514043)));
		checkBoxItem.Disabled.CheckInnerBorder = colorFactory_0.GetColor(14738149);
		checkBoxItem.Disabled.CheckSign = new LinearGradientColorTable(colorFactory_0.GetColor(9276813), Color.Empty);
		checkBoxItem.Disabled.Text = colorFactory_0.GetColor(9276813);
		smethod_37(office2007ColorTable_0, colorFactory_0);
		smethod_40(office2007ColorTable_0, colorFactory_0);
		Office2007ProgressBarColorTable progressBarItem = office2007ColorTable_0.ProgressBarItem;
		progressBarItem.BackgroundColors = new GradientColorTable(8882571, 9934999);
		progressBarItem.OuterBorder = colorFactory_0.GetColor(13421772);
		progressBarItem.InnerBorder = colorFactory_0.GetColor(2434341);
		progressBarItem.Chunk = new GradientColorTable(6788896, 12779350, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(164, colorFactory_0.GetColor(15663063)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, colorFactory_0.GetColor(9286228)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, colorFactory_0.GetColor(6918699)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(8750469, 9474448, 0);
		progressBarItem = office2007ColorTable_0.ProgressBarItemPaused;
		progressBarItem.BackgroundColors = new GradientColorTable(8882571, 9934999);
		progressBarItem.OuterBorder = colorFactory_0.GetColor(13421772);
		progressBarItem.InnerBorder = colorFactory_0.GetColor(2434341);
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
		progressBarItem.ChunkShadow = new GradientColorTable(8750469, 9474448, 0);
		progressBarItem = office2007ColorTable_0.ProgressBarItemError;
		progressBarItem.BackgroundColors = new GradientColorTable(8882571, 9934999);
		progressBarItem.OuterBorder = colorFactory_0.GetColor(13421772);
		progressBarItem.InnerBorder = colorFactory_0.GetColor(2434341);
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
		progressBarItem.ChunkShadow = new GradientColorTable(8750469, 9474448, 0);
		Office2007GalleryColorTable gallery = office2007ColorTable_0.Gallery;
		gallery.GroupLabelBackground = colorFactory_0.GetColor(15461355);
		gallery.GroupLabelText = colorFactory_0.GetColor(0);
		gallery.GroupLabelBorder = colorFactory_0.GetColor(12961221);
		office2007ColorTable_0.ListViewEx.Border = colorFactory_0.GetColor(5002076);
		office2007ColorTable_0.ListViewEx.ColumnBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16777215), colorFactory_0.GetColor(13948891));
		office2007ColorTable_0.ListViewEx.ColumnSeparator = colorFactory_0.GetColor(9542052);
		office2007ColorTable_0.ListViewEx.SelectionBackground = new LinearGradientColorTable(colorFactory_0.GetColor(10997232), Color.Empty);
		office2007ColorTable_0.ListViewEx.SelectionBorder = colorFactory_0.GetColor(14938111);
		office2007ColorTable_0.NavigationPane.ButtonBackground = new GradientColorTable();
		office2007ColorTable_0.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16316665), 0f));
		office2007ColorTable_0.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(14672612), 0.4f));
		office2007ColorTable_0.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(13093841), 0.4f));
		office2007ColorTable_0.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(14409442), 1f));
		office2007ColorTable_0.SuperTooltip.BackgroundColors = new LinearGradientColorTable(colorFactory_0.GetColor(16777215), colorFactory_0.GetColor(15000816));
		office2007ColorTable_0.SuperTooltip.TextColor = colorFactory_0.GetColor(5000268);
		Office2007SliderColorTable slider = office2007ColorTable_0.Slider;
		slider.Default.LabelColor = colorFactory_0.GetColor(16777215);
		slider.Default.PartBackground = new GradientColorTable();
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16777215), 0f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15724527), 0.15f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(12501699), 0.5f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(7106936), 0.5f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(14474462), 0.85f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16777215), 1f));
		slider.Default.PartBorderColor = colorFactory_0.GetColor(3751750);
		slider.Default.PartBorderLightColor = Color.FromArgb(28, colorFactory_0.GetColor(16777215));
		slider.Default.PartForeColor = colorFactory_0.GetColor(5989228);
		slider.Default.PartForeLightColor = Color.FromArgb(168, colorFactory_0.GetColor(15395562));
		slider.Default.TrackLineColor = colorFactory_0.GetColor(2434341);
		slider.Default.TrackLineLightColor = colorFactory_0.GetColor(13421772);
		slider.MouseOver.LabelColor = colorFactory_0.GetColor(16777215);
		slider.MouseOver.PartBackground = new GradientColorTable();
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16777215), 0f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16777214), 0.2f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16046995), 0.5f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15645223), 0.5f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16576191), 0.85f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16445650), 1f));
		slider.MouseOver.PartBorderColor = colorFactory_0.GetColor(2960685);
		slider.MouseOver.PartBorderLightColor = Color.FromArgb(28, colorFactory_0.GetColor(16777215));
		slider.MouseOver.PartForeColor = colorFactory_0.GetColor(6775369);
		slider.MouseOver.PartForeLightColor = Color.FromArgb(168, colorFactory_0.GetColor(16774356));
		slider.MouseOver.TrackLineColor = colorFactory_0.GetColor(2434341);
		slider.MouseOver.TrackLineLightColor = colorFactory_0.GetColor(13421772);
		slider.Pressed.LabelColor = colorFactory_0.GetColor(16777215);
		slider.Pressed.PartBackground = new GradientColorTable();
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15109178), 0f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15901267), 0.2f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16368011), 0.5f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15958807), 0.5f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16301446), 0.85f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(15979188), 1f));
		slider.Pressed.PartBorderColor = colorFactory_0.GetColor(2960685);
		slider.Pressed.PartBorderLightColor = Color.FromArgb(28, colorFactory_0.GetColor(16777215));
		slider.Pressed.PartForeColor = colorFactory_0.GetColor(6771523);
		slider.Pressed.PartForeLightColor = Color.FromArgb(168, colorFactory_0.GetColor(16768187));
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
		office2007ColorTable_0.DataGridView.ColumnHeaderNormalBorder = colorFactory_0.GetColor(11974326);
		office2007ColorTable_0.DataGridView.ColumnHeaderNormalBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16316664), colorFactory_0.GetColor(14606046), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderSelectedBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16374175), colorFactory_0.GetColor(15843679), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderSelectedBorder = colorFactory_0.GetColor(15897910);
		office2007ColorTable_0.DataGridView.ColumnHeaderSelectedMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16766349), colorFactory_0.GetColor(15897146), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderSelectedMouseOverBorder = colorFactory_0.GetColor(15897910);
		office2007ColorTable_0.DataGridView.ColumnHeaderMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14737632), colorFactory_0.GetColor(12829635), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderMouseOverBorder = colorFactory_0.GetColor(11974326);
		office2007ColorTable_0.DataGridView.ColumnHeaderPressedBackground = new LinearGradientColorTable(colorFactory_0.GetColor(14737632), colorFactory_0.GetColor(12829635), 90);
		office2007ColorTable_0.DataGridView.ColumnHeaderPressedBorder = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.DataGridView.RowNormalBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15592941));
		office2007ColorTable_0.DataGridView.RowNormalBorder = colorFactory_0.GetColor(11974326);
		office2007ColorTable_0.DataGridView.RowSelectedBackground = new LinearGradientColorTable(colorFactory_0.GetColor(16766349));
		office2007ColorTable_0.DataGridView.RowSelectedBorder = colorFactory_0.GetColor(15897910);
		office2007ColorTable_0.DataGridView.RowSelectedMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15843420));
		office2007ColorTable_0.DataGridView.RowSelectedMouseOverBorder = colorFactory_0.GetColor(15897910);
		office2007ColorTable_0.DataGridView.RowMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15843420));
		office2007ColorTable_0.DataGridView.RowMouseOverBorder = colorFactory_0.GetColor(11974326);
		office2007ColorTable_0.DataGridView.RowPressedBackground = new LinearGradientColorTable(colorFactory_0.GetColor(15843420));
		office2007ColorTable_0.DataGridView.RowPressedBorder = colorFactory_0.GetColor(16777215);
		office2007ColorTable_0.DataGridView.GridColor = colorFactory_0.GetColor(13686757);
		office2007ColorTable_0.DataGridView.SelectorBackground = new LinearGradientColorTable(colorFactory_0.GetColor(13224393));
		office2007ColorTable_0.DataGridView.SelectorBorder = colorFactory_0.GetColor(11974326);
		office2007ColorTable_0.DataGridView.SelectorBorderDark = colorFactory_0.GetColor(13421772);
		office2007ColorTable_0.DataGridView.SelectorBorderLight = colorFactory_0.GetColor(15461355);
		office2007ColorTable_0.DataGridView.SelectorSign = new LinearGradientColorTable(colorFactory_0.GetColor(8224125), colorFactory_0.GetColor(6776679));
		office2007ColorTable_0.DataGridView.SelectorMouseOverBackground = new LinearGradientColorTable(colorFactory_0.GetColor(11382189), colorFactory_0.GetColor(10461087));
		office2007ColorTable_0.DataGridView.SelectorMouseOverBorder = colorFactory_0.GetColor(11974326);
		office2007ColorTable_0.DataGridView.SelectorMouseOverBorderDark = colorFactory_0.GetColor(13421772);
		office2007ColorTable_0.DataGridView.SelectorMouseOverBorderLight = colorFactory_0.GetColor(15461355);
		office2007ColorTable_0.DataGridView.SelectorMouseOverSign = new LinearGradientColorTable(colorFactory_0.GetColor(8224125), colorFactory_0.GetColor(6776679));
		office2007ColorTable_0.AdvTree = new TreeColorTable();
		Class5.smethod_2(office2007ColorTable_0.AdvTree, colorFactory_0);
		office2007ColorTable_0.CrumbBarItemView = new CrumbBarItemViewColorTable();
		CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		office2007ColorTable_0.CrumbBarItemView.Default = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_0.GetColor(0);
		crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		office2007ColorTable_0.CrumbBarItemView.MouseOver = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_0.GetColor(0);
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFFCD9"), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFE78F"), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFD74A"), 0.4f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFFE794"), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_0.GetColor("FFDDCF9B");
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_0.GetColor("80FFFFFF");
		crumbBarItemViewStateColorTable = new CrumbBarItemViewStateColorTable();
		office2007ColorTable_0.CrumbBarItemView.MouseOverInactive = crumbBarItemViewStateColorTable;
		crumbBarItemViewStateColorTable.Foreground = colorFactory_0.GetColor(0);
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
		crumbBarItemViewStateColorTable.Foreground = colorFactory_0.GetColor(0);
		crumbBarItemViewStateColorTable.Background = new BackgroundColorBlendCollection();
		crumbBarItemViewStateColorTable.Background.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(colorFactory_0.GetColor("FFC89861"), 0f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFEDAE68"), 0.1f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFCA160"), 0.6f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFC8F3D"), 0.6f),
			new BackgroundColorBlend(colorFactory_0.GetColor("FFFEBD61"), 1f)
		});
		crumbBarItemViewStateColorTable.Border = colorFactory_0.GetColor("FF8B7654");
		crumbBarItemViewStateColorTable.BorderLight = colorFactory_0.GetColor("408B7654");
		office2007ColorTable_0.StyleClasses.Clear();
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonGalleryContainerKey;
		elementStyle.BorderColor = colorFactory_0.GetColor(11316396);
		elementStyle.Border = eStyleBorderType.Solid;
		elementStyle.BorderWidth = 1;
		elementStyle.CornerDiameter = 2;
		elementStyle.CornerType = eCornerType.Rounded;
		elementStyle.BackColor = colorFactory_0.GetColor(14344930);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_43(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_44(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_45(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_46(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_47(office2007ColorTable_0);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_48(colorFactory_0.GetColor(9013641));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_53(colorFactory_0.GetColor(9013641));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_54(colorFactory_0, eOffice2007ColorScheme.Black);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_55(office2007ColorTable_0.ListViewEx);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_56(office2007ColorTable_0.Bar);
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_49(colorFactory_0.GetColor(9013641));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_50(colorFactory_0.GetColor(16316664), colorFactory_0.GetColor(14606046), colorFactory_0.GetColor(11974326));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_51(colorFactory_0.GetColor(16316664), colorFactory_0.GetColor(14606046), colorFactory_0.GetColor(11974326));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_52(colorFactory_0.GetColor(0));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = smethod_57(colorFactory_0.GetColor(Color.White), colorFactory_0.GetColor("FF333333"), colorFactory_0.GetColor("FF252525"));
		office2007ColorTable_0.StyleClasses.Add(elementStyle.Class, elementStyle);
		office2007ColorTable_0.SideBar.Background = new LinearGradientColorTable(colorFactory_0.GetColor(Color.White));
		office2007ColorTable_0.SideBar.Border = colorFactory_0.GetColor(10988982);
		office2007ColorTable_0.SideBar.SideBarPanelItemText = colorFactory_0.GetColor(Color.Black);
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault = new GradientColorTable();
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(16316665), 0f));
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(14672612), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(13093841), 0.4f));
		office2007ColorTable_0.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(colorFactory_0.GetColor(14409442), 1f));
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
	}

	public static void smethod_42(ColorScheme colorScheme_0, ColorFactory colorFactory_0)
	{
		colorScheme_0.BarBackground = colorFactory_0.GetColor(13488341);
		colorScheme_0.BarBackground2 = colorFactory_0.GetColor(9147035);
		colorScheme_0.BarStripeColor = colorFactory_0.GetColor(3619907);
		colorScheme_0.BarCaptionBackground = colorFactory_0.GetColor(7766158);
		colorScheme_0.BarCaptionBackground2 = colorFactory_0.GetColor(5002076);
		colorScheme_0.BarCaptionInactiveBackground = colorFactory_0.GetColor(15790578);
		colorScheme_0.BarCaptionInactiveBackground2 = colorFactory_0.GetColor(12436169);
		colorScheme_0.BarCaptionInactiveText = colorFactory_0.GetColor(3619907);
		colorScheme_0.BarCaptionText = colorFactory_0.GetColor(16777215);
		colorScheme_0.BarFloatingBorder = colorFactory_0.GetColor(3619907);
		colorScheme_0.BarPopupBackground = colorFactory_0.GetColor(16185078);
		colorScheme_0.BarPopupBorder = colorFactory_0.GetColor(9542052);
		colorScheme_0.ItemBackground = Color.Empty;
		colorScheme_0.ItemBackground2 = Color.Empty;
		colorScheme_0.ItemCheckedBackground = colorFactory_0.GetColor(16765802);
		colorScheme_0.ItemCheckedBackground2 = colorFactory_0.GetColor(16500815);
		colorScheme_0.ItemCheckedBorder = colorFactory_0.GetColor(12276995);
		colorScheme_0.ItemCheckedText = colorFactory_0.GetColor(0);
		colorScheme_0.ItemDisabledBackground = Color.Empty;
		colorScheme_0.ItemDisabledText = colorFactory_0.GetColor(9276813);
		colorScheme_0.ItemExpandedShadow = Color.Empty;
		colorScheme_0.ItemExpandedBackground = colorFactory_0.GetColor(9542052);
		colorScheme_0.ItemExpandedBackground2 = colorFactory_0.GetColor(6647418);
		colorScheme_0.ItemExpandedText = colorFactory_0.GetColor(0);
		colorScheme_0.ItemHotBackground = colorFactory_0.GetColor(16774604);
		colorScheme_0.ItemHotBackground2 = colorFactory_0.GetColor(16767861);
		colorScheme_0.ItemHotBorder = colorFactory_0.GetColor(16760169);
		colorScheme_0.ItemHotText = colorFactory_0.GetColor(0);
		colorScheme_0.ItemPressedBackground = colorFactory_0.GetColor(16553789);
		colorScheme_0.ItemPressedBackground2 = colorFactory_0.GetColor(16758878);
		colorScheme_0.ItemPressedBorder = colorFactory_0.GetColor(16485436);
		colorScheme_0.ItemPressedText = colorFactory_0.GetColor(0);
		colorScheme_0.ItemSeparator = Color.FromArgb(225, colorFactory_0.GetColor(9542052));
		colorScheme_0.ItemSeparatorShade = Color.FromArgb(180, colorFactory_0.GetColor(16777215));
		colorScheme_0.ItemText = colorFactory_0.GetColor(0);
		colorScheme_0.MenuBackground = colorFactory_0.GetColor(16185078);
		colorScheme_0.MenuBackground2 = Color.Empty;
		colorScheme_0.MenuBarBackground = colorFactory_0.GetColor(5460819);
		colorScheme_0.MenuBorder = colorFactory_0.GetColor(9542052);
		colorScheme_0.ItemExpandedBorder = colorScheme_0.MenuBorder;
		colorScheme_0.MenuSide = colorFactory_0.GetColor(15724527);
		colorScheme_0.MenuSide2 = Color.Empty;
		colorScheme_0.MenuUnusedBackground = colorScheme_0.MenuBackground;
		colorScheme_0.MenuUnusedSide = colorFactory_0.GetColor(15329769);
		colorScheme_0.MenuUnusedSide2 = Color.Empty;
		colorScheme_0.ItemDesignTimeBorder = Color.Black;
		colorScheme_0.BarDockedBorder = colorFactory_0.GetColor(5002076);
		colorScheme_0.DockSiteBackColor = colorFactory_0.GetColor(5460819);
		colorScheme_0.DockSiteBackColor2 = Color.Empty;
		colorScheme_0.CustomizeBackground = colorFactory_0.GetColor(11712447);
		colorScheme_0.CustomizeBackground2 = colorFactory_0.GetColor(5331042);
		colorScheme_0.CustomizeText = colorFactory_0.GetColor(0);
		colorScheme_0.PanelBackground = colorFactory_0.GetColor(15790578);
		colorScheme_0.PanelBackground2 = colorFactory_0.GetColor(12436169);
		colorScheme_0.PanelText = Color.Black;
		colorScheme_0.PanelBorder = colorFactory_0.GetColor(10988982);
		colorScheme_0.ExplorerBarBackground = colorFactory_0.GetColor(15790578);
		colorScheme_0.ExplorerBarBackground2 = colorFactory_0.GetColor(12436169);
		colorScheme_0.MdiSystemItemForeground = Color.LightGray;
	}

	public static ElementStyle smethod_43(Office2007ColorTable office2007ColorTable_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonFileMenuContainerKey;
		Office2007MenuColorTable menu = office2007ColorTable_0.Menu;
		elementStyle.PaddingBottom = 3;
		elementStyle.PaddingLeft = 3;
		elementStyle.PaddingRight = 3;
		elementStyle.PaddingTop = 12;
		BackgroundColorBlend[] array = new BackgroundColorBlend[menu.FileBackgroundBlend.Count];
		menu.FileBackgroundBlend.method_0(array);
		elementStyle.BackColorBlend.Clear();
		elementStyle.BackColorBlend.AddRange(array);
		elementStyle.BackColorGradientAngle = 90;
		return elementStyle;
	}

	public static ElementStyle smethod_44(Office2007ColorTable office2007ColorTable_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonFileMenuTwoColumnContainerKey;
		Office2007MenuColorTable menu = office2007ColorTable_0.Menu;
		elementStyle.BorderBottom = eStyleBorderType.Double;
		elementStyle.BorderBottomWidth = 1;
		elementStyle.BorderColor = menu.FileContainerBorder;
		elementStyle.BorderColorLight = menu.FileContainerBorderLight;
		elementStyle.BorderLeft = eStyleBorderType.Double;
		elementStyle.BorderLeftWidth = 1;
		elementStyle.BorderRight = eStyleBorderType.Double;
		elementStyle.BorderRightWidth = 1;
		elementStyle.BorderTop = eStyleBorderType.Double;
		elementStyle.BorderTopWidth = 1;
		elementStyle.PaddingBottom = 1;
		elementStyle.PaddingLeft = 1;
		elementStyle.PaddingRight = 1;
		elementStyle.PaddingTop = 1;
		return elementStyle;
	}

	public static ElementStyle smethod_45(Office2007ColorTable office2007ColorTable_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonFileMenuColumnOneContainerKey;
		Office2007MenuColorTable menu = office2007ColorTable_0.Menu;
		elementStyle.BackColor = menu.FileColumnOneBackground;
		elementStyle.BorderRight = eStyleBorderType.Solid;
		elementStyle.BorderRightColor = menu.FileColumnOneBorder;
		elementStyle.BorderRightWidth = 1;
		elementStyle.PaddingRight = 1;
		return elementStyle;
	}

	public static ElementStyle smethod_46(Office2007ColorTable office2007ColorTable_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonFileMenuColumnTwoContainerKey;
		Office2007MenuColorTable menu = office2007ColorTable_0.Menu;
		elementStyle.BackColor = menu.FileColumnTwoBackground;
		return elementStyle;
	}

	public static ElementStyle smethod_47(Office2007ColorTable office2007ColorTable_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonFileMenuBottomContainerKey;
		Office2007MenuColorTable menu = office2007ColorTable_0.Menu;
		BackgroundColorBlend[] array = new BackgroundColorBlend[menu.FileBottomContainerBackgroundBlend.Count];
		menu.FileBottomContainerBackgroundBlend.method_0(array);
		elementStyle.BackColorBlend.Clear();
		elementStyle.BackColorBlend.AddRange(array);
		elementStyle.BackColorGradientAngle = 90;
		return elementStyle;
	}

	public static ElementStyle smethod_48(Color color_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.TextBoxBorderKey;
		elementStyle.BorderColor = color_0;
		elementStyle.BorderWidth = 1;
		elementStyle.Border = eStyleBorderType.Solid;
		elementStyle.PaddingBottom = 3;
		elementStyle.PaddingTop = 2;
		elementStyle.PaddingLeft = 2;
		elementStyle.PaddingRight = 2;
		return elementStyle;
	}

	public static ElementStyle smethod_49(Color color_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.TreeBorderKey;
		elementStyle.BorderColor = color_0;
		elementStyle.BorderWidth = 1;
		elementStyle.Border = eStyleBorderType.Solid;
		return elementStyle;
	}

	public static ElementStyle smethod_50(Color color_0, Color color_1, Color color_2)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.TreeColumnsHeaderKey;
		elementStyle.BackColor = color_0;
		elementStyle.BackColor2 = color_1;
		elementStyle.BackColorGradientAngle = 90;
		elementStyle.TextColor = Color.Black;
		elementStyle.BorderColor = color_2;
		elementStyle.BorderBottom = eStyleBorderType.Solid;
		elementStyle.BorderBottomWidth = 1;
		return elementStyle;
	}

	public static ElementStyle smethod_51(Color color_0, Color color_1, Color color_2)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.TreeNodesColumnsHeaderKey;
		elementStyle.BackColor = color_0;
		elementStyle.BackColor2 = color_1;
		elementStyle.BackColorGradientAngle = 90;
		elementStyle.TextColor = Color.Black;
		elementStyle.BorderColor = color_2;
		elementStyle.BorderBottom = eStyleBorderType.Solid;
		elementStyle.BorderBottomWidth = 1;
		elementStyle.BorderLeft = eStyleBorderType.Solid;
		elementStyle.BorderLeftWidth = 1;
		elementStyle.BorderTop = eStyleBorderType.Solid;
		elementStyle.BorderTopWidth = 1;
		return elementStyle;
	}

	public static ElementStyle smethod_52(Color color_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.TreeColumnKey;
		elementStyle.TextColor = color_0;
		return elementStyle;
	}

	public static ElementStyle smethod_53(Color color_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.DateTimeInputBackgroundKey;
		elementStyle.BorderColor = color_0;
		elementStyle.BorderWidth = 1;
		elementStyle.Border = eStyleBorderType.Solid;
		elementStyle.BackColor = SystemColors.Window;
		elementStyle.PaddingLeft = 1;
		elementStyle.PaddingRight = 1;
		elementStyle.PaddingTop = 1;
		elementStyle.PaddingBottom = 1;
		return elementStyle;
	}

	public static ElementStyle smethod_54(ColorFactory colorFactory_0, eOffice2007ColorScheme eOffice2007ColorScheme_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonClientPanelKey;
		elementStyle.BackColorGradientAngle = 90;
		switch (eOffice2007ColorScheme_0)
		{
		case eOffice2007ColorScheme.Blue:
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(12506352), 0f));
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(5668273), 0.8f));
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(6656461), 1f));
			break;
		case eOffice2007ColorScheme.Silver:
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(13422552), 0f));
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(11251382), 0.8f));
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(10198950), 1f));
			break;
		case eOffice2007ColorScheme.Black:
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(8289918), 0f));
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(3552822), 0.8f));
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(colorFactory_0.GetColor(657930), 1f));
			break;
		}
		return elementStyle;
	}

	public static ElementStyle smethod_55(Office2007ListViewColorTable office2007ListViewColorTable_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.ListViewBorderKey;
		elementStyle.Border = eStyleBorderType.Solid;
		elementStyle.BorderWidth = 1;
		elementStyle.CornerType = eCornerType.Square;
		elementStyle.BorderColor = office2007ListViewColorTable_0.Border;
		return elementStyle;
	}

	public static ElementStyle smethod_56(Office2007BarColorTable office2007BarColorTable_0)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.Office2007StatusBarBackground2Key;
		elementStyle.PaddingLeft = 4;
		elementStyle.BorderLeft = eStyleBorderType.Etched;
		elementStyle.BorderLeftWidth = 1;
		elementStyle.BorderLeftColor = Color.FromArgb(196, office2007BarColorTable_0.StatusBarTopBorder);
		elementStyle.BorderColorLight = Color.FromArgb(128, Color.White);
		if (office2007BarColorTable_0.StatusBarAltBackground.Count > 0)
		{
			elementStyle.BackColorBlend.CopyFrom(office2007BarColorTable_0.StatusBarAltBackground);
			elementStyle.BackColorGradientAngle = 90;
		}
		return elementStyle;
	}

	public static ElementStyle smethod_57(Color color_0, Color color_1, Color color_2)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.CrumbBarBackgroundKey;
		elementStyle.BackColor = color_0;
		elementStyle.BorderColor = color_1;
		elementStyle.BorderColor2 = color_2;
		elementStyle.Border = eStyleBorderType.Solid;
		elementStyle.BorderWidth = 1;
		return elementStyle;
	}
}

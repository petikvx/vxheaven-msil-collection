using System;
using System.Drawing;
using DevComponents.AdvTree.Display;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007VistaBlackColorTableFactory
{
	public static void SetBlueExpandColors(Office2007ButtonItemColorTable ct, ColorFactory factory)
	{
		Color color = factory.GetColor(5668273);
		Color color2 = factory.GetColor(15397625);
		ct.Default.ExpandBackground = color;
		ct.Default.ExpandLight = color2;
		ct.Checked.ExpandBackground = color;
		ct.Checked.ExpandLight = color2;
		ct.Expanded.ExpandBackground = color;
		ct.Expanded.ExpandLight = color2;
		ct.MouseOver.ExpandBackground = color;
		ct.MouseOver.ExpandLight = color2;
		ct.Pressed.ExpandBackground = color;
		ct.Pressed.ExpandLight = color2;
	}

	public static void SetBlackExpandColors(Office2007ButtonItemColorTable ct, ColorFactory factory)
	{
		Color color = factory.GetColor(4605510);
		Color color2 = factory.GetColor(14408668);
		ct.Default.ExpandBackground = color;
		ct.Default.ExpandLight = color2;
		ct.Checked.ExpandBackground = color;
		ct.Checked.ExpandLight = color2;
		ct.Expanded.ExpandBackground = color;
		ct.Expanded.ExpandLight = color2;
		ct.MouseOver.ExpandBackground = color;
		ct.MouseOver.ExpandLight = color2;
		ct.Pressed.ExpandBackground = color;
		ct.Pressed.ExpandLight = color2;
	}

	public static Office2007ButtonItemColorTable GetButtonItemOffice2007WithBackground(ColorFactory factory)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.TopBackground = new LinearGradientColorTable(factory.GetColor(13365499), factory.GetColor(7322597));
		office2007ButtonItemColorTable.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.BottomBackground = new LinearGradientColorTable(factory.GetColor(6731231), factory.GetColor(10677750));
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight = new LinearGradientColorTable(factory.GetColor(11664639), Color.Empty);
		office2007ButtonItemColorTable.Default.InnerBorder = new LinearGradientColorTable(Color.White, Color.Empty);
		office2007ButtonItemColorTable.Default.OuterBorder = new LinearGradientColorTable(factory.GetColor(7970230), Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.TopBackground = new LinearGradientColorTable(factory.GetColor(Color.WhiteSmoke), factory.GetColor(Color.LightGray));
		office2007ButtonItemColorTable.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.BottomBackground = new LinearGradientColorTable(factory.GetColor(Color.Silver), factory.GetColor(15463421));
		office2007ButtonItemColorTable.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.InnerBorder = new LinearGradientColorTable(Color.WhiteSmoke, Color.Empty);
		office2007ButtonItemColorTable.Disabled.OuterBorder = new LinearGradientColorTable(factory.GetColor(7970230), Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Disabled.Text = factory.GetColor(9276813);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(factory.GetColor(16579042), factory.GetColor(16510399));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(factory.GetColor(16439370), factory.GetColor(16573845));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(Color.White, Color.Empty);
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(12560249), Color.Empty);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(factory.GetColor(12560249), Color.Empty);
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Empty);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(factory.GetColor(16300664), factory.GetColor(16560718));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(factory.GetColor(16555023), factory.GetColor(16562743));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(factory.GetColor(15837002), Color.Empty);
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(factory.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(factory.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Empty);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(factory.GetColor(16579042), factory.GetColor(16510399));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(factory.GetColor(16439370), factory.GetColor(16573845));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(Color.White, Color.Empty);
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(factory.GetColor(15837002), Color.Empty);
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(factory.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(factory.GetColor(16562743), factory.GetColor(16555023));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(factory.GetColor(16560718), factory.GetColor(16300664));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(factory.GetColor(15837002), Color.Empty);
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(factory.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(factory.GetColor(9665882), Color.Empty);
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Empty);
		return office2007ButtonItemColorTable;
	}

	public static Office2007RibbonBarStateColorTable GetRibbonBarBlue(ColorFactory factory)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(factory.GetColor(12964575), factory.GetColor(10403803));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(factory.GetColor(15199991), factory.GetColor(15857661));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(factory.GetColor(14608629), factory.GetColor(13754352));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(factory.GetColor(13097197), factory.GetColor(14215413));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(factory.GetColor(12769521), factory.GetColor(12638447));
		office2007RibbonBarStateColorTable.TitleText = factory.GetColor(4090538);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable GetRibbonBarBlueMouseOver(ColorFactory factory)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(factory.GetColor(11388894), factory.GetColor(8302035));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(factory.GetColor(16777215), factory.GetColor(16777215));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(factory.GetColor(15003645), factory.GetColor(15266044));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(factory.GetColor(14478075), factory.GetColor(14477560));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(factory.GetColor(13164799), factory.GetColor(14085631));
		office2007RibbonBarStateColorTable.TitleText = factory.GetColor(4090553);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable GetRibbonBarBlueExpanded(ColorFactory factory)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(factory.GetColor(8821678), factory.GetColor(11651033));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(factory.GetColor(11387356), factory.GetColor(8955856));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(factory.GetColor(7772616), factory.GetColor(11851261));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(factory.GetColor(12835314), Color.Empty);
		office2007RibbonBarStateColorTable.TitleText = Color.Empty;
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonTabItemColorTable GetRibbonTabItemBlueDefault(ColorFactory factory)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(factory.GetColor(15791870), factory.GetColor(14411509));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(factory.GetColor(16317439), factory.GetColor(12581631));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(factory.GetColor(9943526), factory.GetColor(9286371));
		office2007RibbonTabItemColorTable.Selected.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(factory.GetColor(15463422), factory.GetColor(14805750));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(16444870), factory.GetColor(16777149));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(14138506), factory.GetColor(16699742));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(13490912), factory.GetColor(14995607));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(12902143), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(14675455), factory.GetColor(13099007));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(10009577), factory.GetColor(10009577));
		office2007RibbonTabItemColorTable.MouseOver.Text = factory.GetColor(1393291);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable GetRibbonTabItemBlueMagenta(ColorFactory factory)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(factory.GetColor(13945058), factory.GetColor(15525874));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(factory.GetColor(15525875), factory.GetColor(13484767));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(factory.GetColor(12499649), factory.GetColor(12632001));
		office2007RibbonTabItemColorTable.Selected.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(factory.GetColor(13945058), factory.GetColor(15525874));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(15525875), factory.GetColor(13484767));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(12499649), factory.GetColor(12632001));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(12899832), factory.GetColor(12762344));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(14609663), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(14741247), factory.GetColor(13099007));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(12699857), factory.GetColor(12634064));
		office2007RibbonTabItemColorTable.MouseOver.Text = factory.GetColor(1393291);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable GetRibbonTabItemBlueGreen(ColorFactory factory)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(factory.GetColor(15004640), factory.GetColor(15004383));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(factory.GetColor(14019283), factory.GetColor(12115633));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(factory.GetColor(12173751), factory.GetColor(12566974));
		office2007RibbonTabItemColorTable.Selected.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(factory.GetColor(15004640), factory.GetColor(15004383));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(14019283), factory.GetColor(12115633));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(12173751), factory.GetColor(12566974));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(11788003), factory.GetColor(9100959));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(14609663), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(14872575), factory.GetColor(13099007));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(12699857), factory.GetColor(12634064));
		office2007RibbonTabItemColorTable.MouseOver.Text = factory.GetColor(1393291);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable GetRibbonTabItemBlueOrange(ColorFactory factory)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(factory.GetColor(16774559), factory.GetColor(16775893));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(factory.GetColor(16776150), factory.GetColor(16642700));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(factory.GetColor(13289388), factory.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(factory.GetColor(16774559), factory.GetColor(16775893));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(16776150), factory.GetColor(16642700));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(13289388), factory.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = factory.GetColor(1393291);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(13623521), factory.GetColor(15329177));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(13361919), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(14872575), factory.GetColor(13099007));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(12699857), factory.GetColor(12634064));
		office2007RibbonTabItemColorTable.MouseOver.Text = factory.GetColor(1393291);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabGroupColorTable GetRibbonTabGroupBlueDefault(ColorFactory factory)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, factory.GetColor(13483991));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, factory.GetColor(13658313)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Text = factory.GetColor(1393291);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable GetRibbonTabGroupBlueMagenta(ColorFactory factory)
	{
		return GetRibbonTabGroupBlueDefault(factory);
	}

	public static Office2007RibbonTabGroupColorTable GetRibbonTabGroupBlueGreen(ColorFactory factory)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, factory.GetColor(10936974));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, factory.GetColor(7059796)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		office2007RibbonTabGroupColorTable.Text = factory.GetColor(1393291);
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonTabGroupColorTable GetRibbonTabGroupBlueOrange(ColorFactory factory)
	{
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = new Office2007RibbonTabGroupColorTable();
		office2007RibbonTabGroupColorTable.Background = new LinearGradientColorTable(Color.Transparent, factory.GetColor(15527849));
		office2007RibbonTabGroupColorTable.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, factory.GetColor(16770585)), Color.Transparent);
		office2007RibbonTabGroupColorTable.Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
		office2007RibbonTabGroupColorTable.Text = factory.GetColor(1393291);
		return office2007RibbonTabGroupColorTable;
	}

	public static Office2007RibbonBarStateColorTable GetRibbonBarBlack(ColorFactory factory)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(factory.GetColor(6055538), factory.GetColor(6055538));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(factory.GetColor(14083576), factory.GetColor(14083576));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(factory.GetColor(15595263), factory.GetColor(12440555));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(factory.GetColor(10532818), factory.GetColor(15790320));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(factory.GetColor(8556704), factory.GetColor(6384758));
		office2007RibbonBarStateColorTable.TitleText = factory.GetColor(16777215);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable GetRibbonBarBlackMouseOver(ColorFactory factory)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(factory.GetColor(6055538), factory.GetColor(6055538));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(factory.GetColor(14083576), factory.GetColor(14083576));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(factory.GetColor(15595263), factory.GetColor(13362172));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(factory.GetColor(11915758), factory.GetColor(15790320));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(factory.GetColor(10202304), factory.GetColor(6384758));
		office2007RibbonBarStateColorTable.TitleText = factory.GetColor(16777215);
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonBarStateColorTable GetRibbonBarBlackExpanded(ColorFactory factory)
	{
		Office2007RibbonBarStateColorTable office2007RibbonBarStateColorTable = new Office2007RibbonBarStateColorTable();
		office2007RibbonBarStateColorTable.TopBackgroundHeight = 15;
		office2007RibbonBarStateColorTable.OuterBorder = new LinearGradientColorTable(factory.GetColor(6055538), factory.GetColor(6055538));
		office2007RibbonBarStateColorTable.InnerBorder = new LinearGradientColorTable(factory.GetColor(14083576), factory.GetColor(14083576));
		office2007RibbonBarStateColorTable.TopBackground = new LinearGradientColorTable(factory.GetColor(15595263), factory.GetColor(13362172));
		office2007RibbonBarStateColorTable.BottomBackground = new LinearGradientColorTable(factory.GetColor(11915758), factory.GetColor(15790320));
		office2007RibbonBarStateColorTable.TitleBackground = new LinearGradientColorTable(factory.GetColor(10202304), factory.GetColor(6384758));
		office2007RibbonBarStateColorTable.TitleText = Color.Empty;
		return office2007RibbonBarStateColorTable;
	}

	public static Office2007RibbonTabItemColorTable GetRibbonTabItemBlackDefault(ColorFactory factory)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = factory.GetColor(16777215);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(factory.GetColor(7970529), factory.GetColor(1983647));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(5752559), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(factory.GetColor(8694251), factory.GetColor(1861244));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(factory.GetColor(0), factory.GetColor(0));
		office2007RibbonTabItemColorTable.Selected.Text = factory.GetColor(16777215);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(factory.GetColor(6001663), factory.GetColor(933319));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(7329023), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(8694251), factory.GetColor(2724522));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(0), factory.GetColor(0));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = factory.GetColor(16777215);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(9476266), factory.GetColor(4151437));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(3965390), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(12567758), factory.GetColor(5662612));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(0), factory.GetColor(0));
		office2007RibbonTabItemColorTable.MouseOver.Text = factory.GetColor(16777215);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable GetRibbonTabItemBlackMagenta(ColorFactory factory)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = factory.GetColor(16777215);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(factory.GetColor(13945058), factory.GetColor(15459826));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(factory.GetColor(14801387), factory.GetColor(13484767));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(factory.GetColor(12368321), factory.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = factory.GetColor(0);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(factory.GetColor(13945058), factory.GetColor(15459826));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(13022937), factory.GetColor(13484767));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(12368321), factory.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = factory.GetColor(0);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(9145745), factory.GetColor(8352917));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(9008797), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(9079695), factory.GetColor(8352917));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(10066074), factory.GetColor(10526370));
		office2007RibbonTabItemColorTable.MouseOver.Text = factory.GetColor(16777215);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable GetRibbonTabItemBlackGreen(ColorFactory factory)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = factory.GetColor(16777215);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(factory.GetColor(12706488), factory.GetColor(14938589));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(factory.GetColor(15004640), factory.GetColor(12115633));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(factory.GetColor(11583660), factory.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = factory.GetColor(0);
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(factory.GetColor(12706488), factory.GetColor(14938589));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(10802326), factory.GetColor(12115633));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(11583660), factory.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = factory.GetColor(0);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(9015431), factory.GetColor(6656600));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(7118172), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(8883334), factory.GetColor(6656599));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(9935255), factory.GetColor(10331035));
		office2007RibbonTabItemColorTable.MouseOver.Text = factory.GetColor(16777215);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007RibbonTabItemColorTable GetRibbonTabItemBlackOrange(ColorFactory factory)
	{
		Office2007RibbonTabItemColorTable office2007RibbonTabItemColorTable = new Office2007RibbonTabItemColorTable();
		office2007RibbonTabItemColorTable.Default.Text = factory.GetColor(16777215);
		office2007RibbonTabItemColorTable.Selected = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.Selected.Background = new LinearGradientColorTable(factory.GetColor(16774559), factory.GetColor(16775893));
		office2007RibbonTabItemColorTable.Selected.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.Selected.InnerBorder = new LinearGradientColorTable(factory.GetColor(16776150), factory.GetColor(16577429));
		office2007RibbonTabItemColorTable.Selected.OuterBorder = new LinearGradientColorTable(factory.GetColor(13289387), factory.GetColor(12763842));
		office2007RibbonTabItemColorTable.Selected.Text = factory.GetColor(0);
		office2007RibbonTabItemColorTable.SelectedMouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.SelectedMouseOver.Background = new LinearGradientColorTable(factory.GetColor(16774559), factory.GetColor(16775893));
		office2007RibbonTabItemColorTable.SelectedMouseOver.BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007RibbonTabItemColorTable.SelectedMouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(16773233), factory.GetColor(16577429));
		office2007RibbonTabItemColorTable.SelectedMouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(13289387), factory.GetColor(12763842));
		office2007RibbonTabItemColorTable.SelectedMouseOver.Text = factory.GetColor(0);
		office2007RibbonTabItemColorTable.MouseOver = new Office2007RibbonTabItemStateColorTable();
		office2007RibbonTabItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(9605251), factory.GetColor(11970867));
		office2007RibbonTabItemColorTable.MouseOver.BackgroundHighlight = new LinearGradientColorTable(factory.GetColor(12760369), Color.Transparent);
		office2007RibbonTabItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(9407875), factory.GetColor(11641907));
		office2007RibbonTabItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(10263446), factory.GetColor(12500670));
		office2007RibbonTabItemColorTable.MouseOver.Text = factory.GetColor(16777215);
		return office2007RibbonTabItemColorTable;
	}

	public static Office2007ButtonItemColorTable GetMenuItemBlue(bool p, ColorFactory factory)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.Background = new LinearGradientColorTable(factory.GetColor(15070202), factory.GetColor(13692156), 90);
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(11789561));
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(15792123), factory.GetColor(14939132));
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(factory.GetColor(12500670));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14417401));
		office2007ButtonItemColorTable.MouseOver.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(factory.GetColor(2908811));
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(factory.GetColor(10399930), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(factory.GetColor(15070460), factory.GetColor(12903926));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(factory.GetColor(10015215), factory.GetColor(6861787));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(factory.GetColor(12500670));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14417401));
		office2007ButtonItemColorTable.Pressed.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(factory.GetColor(3964849));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(Color.FromArgb(96, Color.White));
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(factory.GetColor(15463931), factory.GetColor(15069946));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(factory.GetColor(13362933), factory.GetColor(12180720));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(factory.GetColor(3964849));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(Color.FromArgb(96, Color.White));
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(factory.GetColor(15463931), factory.GetColor(15069946));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(factory.GetColor(13362933), factory.GetColor(12180720));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(factory.GetColor(12500670));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14417401));
		office2007ButtonItemColorTable.Expanded.Text = factory.GetColor(0);
		SetBlackExpandColors(office2007ButtonItemColorTable, factory);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable GetButtonItemBlackOrange(bool ribbonBar, ColorFactory factory)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(10855845), factory.GetColor(9803157));
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(Color.FromArgb(128, Color.White));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(factory.GetColor(15333374), factory.GetColor(14545661));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(255, factory.GetColor(14611451)), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(factory.GetColor(9813717), factory.GetColor(11920639));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, factory.GetColor(13893631)), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(factory.GetColor(12500670));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14417401));
		office2007ButtonItemColorTable.MouseOver.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(factory.GetColor(10855845), factory.GetColor(9803157));
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(Color.FromArgb(128, Color.White));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(factory.GetColor(15333374), factory.GetColor(12970491));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(factory.GetColor(6594239), factory.GetColor(8901631));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(factory.GetColor(13893631), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(factory.GetColor(12500670));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14417401));
		office2007ButtonItemColorTable.Pressed.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(factory.GetColor(9408142), factory.GetColor(6513507));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(Color.FromArgb(96, Color.White));
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(factory.GetColor(15790320), factory.GetColor(13159112));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(32, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(factory.GetColor(12039605), factory.GetColor(12501438));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(factory.GetColor(15527148), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(factory.GetColor(10855845), factory.GetColor(6513507));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(Color.FromArgb(96, Color.White));
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(factory.GetColor(15333374), factory.GetColor(14545661));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(128, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(factory.GetColor(9813717), factory.GetColor(11920639));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(factory.GetColor(14676733), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(factory.GetColor(12500670));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14417401));
		office2007ButtonItemColorTable.Expanded.Text = factory.GetColor(0);
		SetBlackExpandColors(office2007ButtonItemColorTable, factory);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable GetButtonItemBlackOrangeWithBackground(ColorFactory factory)
	{
		Office2007ButtonItemColorTable buttonItemBlackOrange = GetButtonItemBlackOrange(ribbonBar: false, factory);
		buttonItemBlackOrange.Default.TopBackground = new LinearGradientColorTable(factory.GetColor(16777215), factory.GetColor(14408667));
		buttonItemBlackOrange.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(228, Color.White), Color.Empty);
		buttonItemBlackOrange.Default.BottomBackground = new LinearGradientColorTable(factory.GetColor(14408667), factory.GetColor(13488082));
		buttonItemBlackOrange.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.White, Color.Transparent);
		buttonItemBlackOrange.Default.InnerBorder = new LinearGradientColorTable(Color.FromArgb(128, Color.White));
		buttonItemBlackOrange.Default.OuterBorder = new LinearGradientColorTable(factory.GetColor(8224125), factory.GetColor(6381921));
		buttonItemBlackOrange.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackOrange.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackOrange.Disabled = new Office2007ButtonItemStateColorTable();
		buttonItemBlackOrange.Disabled.TopBackground = new LinearGradientColorTable(factory.GetColor(13554650), factory.GetColor(12699343));
		buttonItemBlackOrange.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackOrange.Disabled.BottomBackground = new LinearGradientColorTable(factory.GetColor(11844549), factory.GetColor(15068396));
		buttonItemBlackOrange.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackOrange.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackOrange.Disabled.OuterBorder = new LinearGradientColorTable(factory.GetColor(12964318), Color.Empty);
		buttonItemBlackOrange.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackOrange.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackOrange.Disabled.Text = factory.GetColor(9276813);
		return buttonItemBlackOrange;
	}

	public static Office2007ButtonItemColorTable GetButtonItemBlackBlue(bool ribbonBar, ColorFactory factory)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = factory.GetColor(16777215);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(128, Color.White)), Color.Empty);
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(0), factory.GetColor(1388888));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(factory.GetColor(9672874), factory.GetColor(3620426));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(factory.GetColor(1119520), factory.GetColor(5664401));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(factory.GetColor(3965390), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(factory.GetColor(0));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(128, Color.White)));
		office2007ButtonItemColorTable.MouseOver.Text = factory.GetColor(16777215);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(96, Color.White)), Color.Empty);
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(factory.GetColor(0), factory.GetColor(1388888));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(factory.GetColor(5265782), factory.GetColor(3425632));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(factory.GetColor(986900), factory.GetColor(1649740));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(factory.GetColor(3241684), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(factory.GetColor(0));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(96, Color.White)));
		office2007ButtonItemColorTable.Pressed.Text = factory.GetColor(16777215);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(64, Color.White)), Color.Empty);
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(factory.GetColor(0));
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(factory.GetColor(7707617), factory.GetColor(5994687));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(factory.GetColor(1520793), factory.GetColor(2727890));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(factory.GetColor(5752559), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = factory.GetColor(16777215);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(96, Color.White)), Color.Empty);
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(factory.GetColor(0), factory.GetColor(1453906));
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(factory.GetColor(5265782), factory.GetColor(3427182));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable();
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(factory.GetColor(1053725), factory.GetColor(1914204));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(factory.GetColor(3307735), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(factory.GetColor(0));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(96, Color.White)));
		office2007ButtonItemColorTable.Expanded.Text = factory.GetColor(16777215);
		SetBlackExpandColors(office2007ButtonItemColorTable, factory);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable GetButtonItemBlackBlueWithBackground(ColorFactory factory)
	{
		Office2007ButtonItemColorTable buttonItemBlackBlue = GetButtonItemBlackBlue(ribbonBar: false, factory);
		buttonItemBlackBlue.Default.TopBackground = new LinearGradientColorTable(factory.GetColor(6450312), factory.GetColor(4147030));
		buttonItemBlackBlue.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackBlue.Default.BottomBackground = new LinearGradientColorTable(factory.GetColor(1381654), factory.GetColor(3950447));
		buttonItemBlackBlue.Default.BottomBackgroundHighlight = new LinearGradientColorTable();
		buttonItemBlackBlue.Default.InnerBorder = new LinearGradientColorTable(factory.GetColor(8028821), factory.GetColor(6581385));
		buttonItemBlackBlue.Default.OuterBorder = new LinearGradientColorTable(factory.GetColor(5663094), factory.GetColor(0));
		buttonItemBlackBlue.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackBlue.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackBlue.Default.Text = Color.White;
		buttonItemBlackBlue.Disabled = new Office2007ButtonItemStateColorTable();
		buttonItemBlackBlue.Disabled.TopBackground = new LinearGradientColorTable(factory.GetColor(6450312), factory.GetColor(4147030));
		buttonItemBlackBlue.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackBlue.Disabled.BottomBackground = new LinearGradientColorTable(factory.GetColor(4147030));
		buttonItemBlackBlue.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackBlue.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackBlue.Disabled.OuterBorder = new LinearGradientColorTable(factory.GetColor(12964318), Color.Empty);
		buttonItemBlackBlue.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackBlue.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackBlue.Disabled.Text = factory.GetColor(13027014);
		return buttonItemBlackBlue;
	}

	public static Office2007ButtonItemColorTable GetButtonItemBlackMagenta(bool ribbonBar, ColorFactory factory)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(7012448), factory.GetColor(5636429));
		office2007ButtonItemColorTable.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(15525875), factory.GetColor(15259391));
		office2007ButtonItemColorTable.MouseOver.TopBackground = new LinearGradientColorTable(factory.GetColor(15917035), factory.GetColor(15124187));
		office2007ButtonItemColorTable.MouseOver.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(96, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.BottomBackground = new LinearGradientColorTable(factory.GetColor(15378644), factory.GetColor(14778817));
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.MouseOver.SplitBorder = new LinearGradientColorTable(factory.GetColor(10714065), factory.GetColor(8939694));
		office2007ButtonItemColorTable.MouseOver.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14271219), factory.GetColor(12297939));
		office2007ButtonItemColorTable.MouseOver.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder = new LinearGradientColorTable(factory.GetColor(7012448), factory.GetColor(5636429));
		office2007ButtonItemColorTable.Pressed.InnerBorder = new LinearGradientColorTable(factory.GetColor(15525875), factory.GetColor(15259391));
		office2007ButtonItemColorTable.Pressed.TopBackground = new LinearGradientColorTable(factory.GetColor(13807814), factory.GetColor(13348289));
		office2007ButtonItemColorTable.Pressed.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(64, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.BottomBackground = new LinearGradientColorTable(factory.GetColor(13793973), factory.GetColor(13126815));
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(184, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Pressed.SplitBorder = new LinearGradientColorTable(factory.GetColor(10714065), factory.GetColor(8939694));
		office2007ButtonItemColorTable.Pressed.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14271219), factory.GetColor(12297939));
		office2007ButtonItemColorTable.Pressed.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder = new LinearGradientColorTable(factory.GetColor(7012448), factory.GetColor(5636429));
		office2007ButtonItemColorTable.Checked.InnerBorder = new LinearGradientColorTable(factory.GetColor(15525875), factory.GetColor(15259391));
		office2007ButtonItemColorTable.Checked.TopBackground = new LinearGradientColorTable(factory.GetColor(15325154), factory.GetColor(14856401));
		office2007ButtonItemColorTable.Checked.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(164, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.BottomBackground = new LinearGradientColorTable(factory.GetColor(13603002), factory.GetColor(13595568));
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(92, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Checked.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		office2007ButtonItemColorTable.Checked.Text = factory.GetColor(0);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder = new LinearGradientColorTable(factory.GetColor(7012448), factory.GetColor(5636429));
		office2007ButtonItemColorTable.Expanded.InnerBorder = new LinearGradientColorTable(factory.GetColor(15525875), factory.GetColor(15259391));
		office2007ButtonItemColorTable.Expanded.TopBackground = new LinearGradientColorTable(factory.GetColor(15325154), factory.GetColor(14856401));
		office2007ButtonItemColorTable.Expanded.TopBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.BottomBackground = new LinearGradientColorTable(factory.GetColor(13603002), factory.GetColor(13595568));
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, Color.White), Color.Transparent);
		office2007ButtonItemColorTable.Expanded.SplitBorder = new LinearGradientColorTable(factory.GetColor(10714065), factory.GetColor(8939694));
		office2007ButtonItemColorTable.Expanded.SplitBorderLight = new LinearGradientColorTable(factory.GetColor(14271219), factory.GetColor(12297939));
		office2007ButtonItemColorTable.Expanded.Text = factory.GetColor(0);
		SetBlackExpandColors(office2007ButtonItemColorTable, factory);
		return office2007ButtonItemColorTable;
	}

	public static Office2007ButtonItemColorTable GetButtonItemBlackMagentaWithBackground(ColorFactory factory)
	{
		Office2007ButtonItemColorTable buttonItemBlackMagenta = GetButtonItemBlackMagenta(ribbonBar: false, factory);
		buttonItemBlackMagenta.Default.TopBackground = new LinearGradientColorTable(factory.GetColor(16316665), factory.GetColor(14672612));
		buttonItemBlackMagenta.Default.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Default.BottomBackground = new LinearGradientColorTable(factory.GetColor(13093841), factory.GetColor(14409442));
		buttonItemBlackMagenta.Default.BottomBackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(128, Color.White), Color.Transparent);
		buttonItemBlackMagenta.Default.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Default.OuterBorder = new LinearGradientColorTable(factory.GetColor(9013125), Color.Empty);
		buttonItemBlackMagenta.Default.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Default.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Disabled = new Office2007ButtonItemStateColorTable();
		buttonItemBlackMagenta.Disabled.TopBackground = new LinearGradientColorTable(factory.GetColor(13554650), factory.GetColor(12699343));
		buttonItemBlackMagenta.Disabled.TopBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Disabled.BottomBackground = new LinearGradientColorTable(factory.GetColor(11844549), factory.GetColor(15068396));
		buttonItemBlackMagenta.Disabled.BottomBackgroundHighlight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Disabled.InnerBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Disabled.OuterBorder = new LinearGradientColorTable(factory.GetColor(4934475), Color.Empty);
		buttonItemBlackMagenta.Disabled.SplitBorder = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Disabled.SplitBorderLight = new LinearGradientColorTable(Color.Empty, Color.Empty);
		buttonItemBlackMagenta.Disabled.Text = factory.GetColor(9276813);
		return buttonItemBlackMagenta;
	}

	public static void InitializeScrollBarColorTable(Office2007ColorTable t, ColorFactory factory)
	{
		Office2007ScrollBarStateColorTable @default = t.ScrollBar.Default;
		@default.Background = new LinearGradientColorTable(factory.GetColor(16579836), factory.GetColor(15790320), 0);
		@default.Border = new LinearGradientColorTable(factory.GetColor(15461871), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(7241382), factory.GetColor(4344675), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(15462128), 0f),
			new BackgroundColorBlend(factory.GetColor(15133168), 0.5f),
			new BackgroundColorBlend(factory.GetColor(13753060), 0.5f),
			new BackgroundColorBlend(factory.GetColor(12503771), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(15264233), factory.GetColor(15330546));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(6254227), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(6316128)), Color.FromArgb(64, Color.White));
		@default = t.ScrollBar.MouseOver;
		@default.Background = t.ScrollBar.Default.Background;
		@default.Border = t.ScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(factory.GetColor(12571114), 0f),
			new BackgroundColorBlend(factory.GetColor(13295610), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11193334), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11193334), 0.7f),
			new BackgroundColorBlend(factory.GetColor(13886714), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(16448767), factory.GetColor(15660284));
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(9213861), factory.GetColor(6713727));
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(3357780), factory.GetColor(5596557));
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(12571114), 0f),
			new BackgroundColorBlend(factory.GetColor(13295610), 0.5f),
			new BackgroundColorBlend(factory.GetColor(11193334), 0.5f),
			new BackgroundColorBlend(factory.GetColor(13886714), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(15329771), factory.GetColor(16580095));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(3960496), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(6316128)), Color.FromArgb(64, Color.White));
		@default = t.ScrollBar.MouseOverControl;
		@default.Background = t.ScrollBar.Default.Background;
		@default.Border = t.ScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(16054783), 0f),
			new BackgroundColorBlend(factory.GetColor(16054783), 0.5f),
			new BackgroundColorBlend(factory.GetColor(13623800), 0.5f),
			new BackgroundColorBlend(factory.GetColor(14675196), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(16514559), Color.Empty);
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(9213861), factory.GetColor(6713727));
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(7241382), factory.GetColor(4344675));
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(15462128), 0f),
			new BackgroundColorBlend(factory.GetColor(15133168), 0.5f),
			new BackgroundColorBlend(factory.GetColor(13753060), 0.5f),
			new BackgroundColorBlend(factory.GetColor(12503771), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(15264233), factory.GetColor(15330802));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(6254227), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(6316128)), Color.FromArgb(64, Color.White));
		@default = t.ScrollBar.Pressed;
		@default.Background = t.ScrollBar.Default.Background;
		@default.Border = t.ScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(15133164), 0f),
			new BackgroundColorBlend(factory.GetColor(14869734), 0.6f),
			new BackgroundColorBlend(factory.GetColor(12831442), 0.6f),
			new BackgroundColorBlend(factory.GetColor(14146785), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(16119800), Color.Empty);
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(9213861), factory.GetColor(6647935));
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(7241382), factory.GetColor(4344675));
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(10403561), 0f),
			new BackgroundColorBlend(factory.GetColor(11259126), 0.5f),
			new BackgroundColorBlend(factory.GetColor(7251696), 0.5f),
			new BackgroundColorBlend(factory.GetColor(11915767), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(12768231), factory.GetColor(14543867));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(1526154), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(6316128)), Color.FromArgb(64, Color.White));
		@default = t.ScrollBar.Disabled;
		@default.Background = t.ScrollBar.Default.Background;
		@default.Border = t.ScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbInnerBorder = new LinearGradientColorTable();
		@default.ThumbOuterBorder = new LinearGradientColorTable();
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(12570615), factory.GetColor(7502996));
		@default.TrackBackground.Clear();
		@default.TrackInnerBorder = new LinearGradientColorTable();
		@default.TrackOuterBorder = new LinearGradientColorTable();
		@default.TrackSignBackground = new LinearGradientColorTable();
	}

	public static void InitializeAppBlueScrollBarColorTable(Office2007ColorTable t, ColorFactory factory)
	{
		Office2007ScrollBarStateColorTable @default = t.AppScrollBar.Default;
		@default.Background = new LinearGradientColorTable(factory.GetColor(9810130), factory.GetColor(8166337), 0);
		@default.Border = new LinearGradientColorTable(factory.GetColor(11718902));
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(7241382), factory.GetColor(4344675), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[6]
		{
			new BackgroundColorBlend(factory.GetColor(14935527), 0f),
			new BackgroundColorBlend(factory.GetColor(14936560), 0.4f),
			new BackgroundColorBlend(factory.GetColor(13161697), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11977944), 0.8f),
			new BackgroundColorBlend(factory.GetColor(11977944), 0.8f),
			new BackgroundColorBlend(factory.GetColor(14804975), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(14935527), factory.GetColor(14804975));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(5859729), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(9146000)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.MouseOver;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(factory.GetColor(12571114), 0f),
			new BackgroundColorBlend(factory.GetColor(13295610), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11193334), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11193334), 0.7f),
			new BackgroundColorBlend(factory.GetColor(13886714), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(15329771), factory.GetColor(16580095));
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(3960496), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(7241382), factory.GetColor(4344675), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = @default.ThumbInnerBorder;
		@default.TrackOuterBorder = @default.ThumbOuterBorder;
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(8226450)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.MouseOverControl;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.CopyFrom(t.AppScrollBar.Default.TrackBackground);
		@default.ThumbInnerBorder = t.AppScrollBar.Default.TrackInnerBorder;
		@default.ThumbOuterBorder = t.AppScrollBar.Default.TrackOuterBorder;
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(5596557), factory.GetColor(3357780));
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(t.AppScrollBar.Default.TrackBackground);
		@default.TrackInnerBorder = t.AppScrollBar.Default.TrackInnerBorder;
		@default.TrackOuterBorder = t.AppScrollBar.Default.TrackOuterBorder;
		@default.TrackSignBackground = t.AppScrollBar.Default.TrackSignBackground;
		@default = t.AppScrollBar.Pressed;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(factory.GetColor(10337767), 0f),
			new BackgroundColorBlend(factory.GetColor(11259126), 0.4f),
			new BackgroundColorBlend(factory.GetColor(7251696), 0.4f),
			new BackgroundColorBlend(factory.GetColor(7251696), 0.7f),
			new BackgroundColorBlend(factory.GetColor(11915767), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(12768231), factory.GetColor(14543867));
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(1526154), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(7241382), factory.GetColor(4344675), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(12768231), factory.GetColor(14543867));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(1526154), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(8487297)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.Disabled;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbInnerBorder = new LinearGradientColorTable();
		@default.ThumbOuterBorder = new LinearGradientColorTable();
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(12570615), factory.GetColor(7502996));
		@default.TrackBackground.Clear();
		@default.TrackInnerBorder = new LinearGradientColorTable();
		@default.TrackOuterBorder = new LinearGradientColorTable();
		@default.TrackSignBackground = new LinearGradientColorTable();
	}

	public static void InitializeAppSilverScrollBarColorTable(Office2007ColorTable t, ColorFactory factory)
	{
		Office2007ScrollBarStateColorTable @default = t.AppScrollBar.Default;
		@default.Background = new LinearGradientColorTable(factory.GetColor(11843519));
		@default.Border = new LinearGradientColorTable(factory.GetColor(10330022));
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(8225934), factory.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(16119286), 0f),
			new BackgroundColorBlend(factory.GetColor(15395564), 0.4f),
			new BackgroundColorBlend(factory.GetColor(14343133), 0.4f),
			new BackgroundColorBlend(factory.GetColor(12698053), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(16382457), factory.GetColor(13619154));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(7237491), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(7303023)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.MouseOver;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(factory.GetColor(14479611), 0f),
			new BackgroundColorBlend(factory.GetColor(13232634), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11131894), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11131894), 0.7f),
			new BackgroundColorBlend(factory.GetColor(9748696), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(16645887), factory.GetColor(14409183));
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(3964849), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(8225934), factory.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = @default.ThumbInnerBorder;
		@default.TrackOuterBorder = @default.ThumbOuterBorder;
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(7303023)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.MouseOverControl;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.CopyFrom(t.AppScrollBar.Default.TrackBackground);
		@default.ThumbInnerBorder = t.AppScrollBar.Default.TrackInnerBorder;
		@default.ThumbOuterBorder = t.AppScrollBar.Default.TrackOuterBorder;
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(8225934), factory.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(t.AppScrollBar.Default.TrackBackground);
		@default.TrackInnerBorder = t.AppScrollBar.Default.TrackInnerBorder;
		@default.TrackOuterBorder = t.AppScrollBar.Default.TrackOuterBorder;
		@default.TrackSignBackground = t.AppScrollBar.Default.TrackSignBackground;
		@default = t.AppScrollBar.Pressed;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(factory.GetColor(12904953), 0f),
			new BackgroundColorBlend(factory.GetColor(10870518), 0.4f),
			new BackgroundColorBlend(factory.GetColor(7326448), 0.4f),
			new BackgroundColorBlend(factory.GetColor(7326448), 0.7f),
			new BackgroundColorBlend(factory.GetColor(6468051), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(14939644), factory.GetColor(10405849));
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(1595786), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(8225934), factory.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(14939644), factory.GetColor(10405849));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(1595786), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(8487297)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.Disabled;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbInnerBorder = new LinearGradientColorTable();
		@default.ThumbOuterBorder = new LinearGradientColorTable();
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(12570615), factory.GetColor(7502996));
		@default.TrackBackground.Clear();
		@default.TrackInnerBorder = new LinearGradientColorTable();
		@default.TrackOuterBorder = new LinearGradientColorTable();
		@default.TrackSignBackground = new LinearGradientColorTable();
	}

	public static void InitializeAppBlackScrollBarColorTable(Office2007ColorTable t, ColorFactory factory)
	{
		Office2007ScrollBarStateColorTable @default = t.AppScrollBar.Default;
		@default.Background = new LinearGradientColorTable(factory.GetColor(4210752));
		@default.Border = new LinearGradientColorTable(factory.GetColor(6447714));
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(13290186), factory.GetColor(7960953), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(16382457), 0f),
			new BackgroundColorBlend(factory.GetColor(15395564), 0.4f),
			new BackgroundColorBlend(factory.GetColor(14343133), 0.4f),
			new BackgroundColorBlend(factory.GetColor(12698053), 1f)
		});
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(16382457), factory.GetColor(13619154));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(3092271), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(7303023)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.MouseOver;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(factory.GetColor(14479611), 0f),
			new BackgroundColorBlend(factory.GetColor(13232634), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11131894), 0.4f),
			new BackgroundColorBlend(factory.GetColor(11131894), 0.7f),
			new BackgroundColorBlend(factory.GetColor(9748696), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(16645887), factory.GetColor(14409183));
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(3964849), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(8618883), factory.GetColor(5131854), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = @default.ThumbInnerBorder;
		@default.TrackOuterBorder = @default.ThumbOuterBorder;
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(7303023)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.MouseOverControl;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.CopyFrom(t.AppScrollBar.Default.TrackBackground);
		@default.ThumbInnerBorder = t.AppScrollBar.Default.TrackInnerBorder;
		@default.ThumbOuterBorder = t.AppScrollBar.Default.TrackOuterBorder;
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(8618883), factory.GetColor(5131854), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(t.AppScrollBar.Default.TrackBackground);
		@default.TrackInnerBorder = t.AppScrollBar.Default.TrackInnerBorder;
		@default.TrackOuterBorder = t.AppScrollBar.Default.TrackOuterBorder;
		@default.TrackSignBackground = t.AppScrollBar.Default.TrackSignBackground;
		@default = t.AppScrollBar.Pressed;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbBackground.AddRange(new BackgroundColorBlend[5]
		{
			new BackgroundColorBlend(factory.GetColor(12904953), 0f),
			new BackgroundColorBlend(factory.GetColor(10870518), 0.4f),
			new BackgroundColorBlend(factory.GetColor(7326448), 0.4f),
			new BackgroundColorBlend(factory.GetColor(7326448), 0.7f),
			new BackgroundColorBlend(factory.GetColor(6468051), 1f)
		});
		@default.ThumbInnerBorder = new LinearGradientColorTable(factory.GetColor(14939644), factory.GetColor(10405849));
		@default.ThumbOuterBorder = new LinearGradientColorTable(factory.GetColor(1595786), Color.Empty);
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(8225934), factory.GetColor(4935509), 90);
		@default.TrackBackground.Clear();
		@default.TrackBackground.CopyFrom(@default.ThumbBackground);
		@default.TrackInnerBorder = new LinearGradientColorTable(factory.GetColor(14939644), factory.GetColor(10405849));
		@default.TrackOuterBorder = new LinearGradientColorTable(factory.GetColor(1595786), Color.Empty);
		@default.TrackSignBackground = new LinearGradientColorTable(Color.FromArgb(180, factory.GetColor(8487297)), Color.FromArgb(64, Color.White));
		@default = t.AppScrollBar.Disabled;
		@default.Background = t.AppScrollBar.Default.Background;
		@default.Border = t.AppScrollBar.Default.Border;
		@default.ThumbBackground.Clear();
		@default.ThumbInnerBorder = new LinearGradientColorTable();
		@default.ThumbOuterBorder = new LinearGradientColorTable();
		@default.ThumbSignBackground = new LinearGradientColorTable(factory.GetColor(12570615), factory.GetColor(7502996));
		@default.TrackBackground.Clear();
		@default.TrackInnerBorder = new LinearGradientColorTable();
		@default.TrackOuterBorder = new LinearGradientColorTable();
		@default.TrackSignBackground = new LinearGradientColorTable();
	}

	public static void InitializeVistaBlackColorTable(Office2007ColorTable t, ColorFactory factory)
	{
		t.RibbonBar.Default = GetRibbonBarBlack(factory);
		t.RibbonBar.MouseOver = GetRibbonBarBlackMouseOver(factory);
		t.RibbonBar.Expanded = GetRibbonBarBlackExpanded(factory);
		t.RibbonTabItemColors.Clear();
		Office2007RibbonTabItemColorTable ribbonTabItemBlackDefault = GetRibbonTabItemBlackDefault(factory);
		ribbonTabItemBlackDefault.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Default);
		t.RibbonTabItemColors.Add(ribbonTabItemBlackDefault);
		ribbonTabItemBlackDefault = Class224.smethod_25(factory);
		ribbonTabItemBlackDefault.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Green);
		t.RibbonTabItemColors.Add(ribbonTabItemBlackDefault);
		ribbonTabItemBlackDefault = Class224.smethod_24(factory);
		ribbonTabItemBlackDefault.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Magenta);
		t.RibbonTabItemColors.Add(ribbonTabItemBlackDefault);
		ribbonTabItemBlackDefault = Class224.smethod_26(factory);
		ribbonTabItemBlackDefault.Name = Enum.GetName(typeof(eRibbonTabColor), eRibbonTabColor.Orange);
		t.RibbonTabItemColors.Add(ribbonTabItemBlackDefault);
		t.RibbonControl = new Office2007RibbonColorTable();
		t.RibbonControl.TabsBackground = new LinearGradientColorTable(factory.GetColor(3949137));
		t.RibbonControl.InnerBorder = new LinearGradientColorTable(factory.GetColor(8028821), factory.GetColor(6581385));
		t.RibbonControl.OuterBorder = new LinearGradientColorTable(factory.GetColor(1118742), factory.GetColor(0));
		t.RibbonControl.TabDividerBorder = factory.GetColor(6581385);
		t.RibbonControl.TabDividerBorderLight = factory.GetColor(2236962);
		t.RibbonControl.PanelTopBackground = new LinearGradientColorTable(factory.GetColor(15595263), factory.GetColor(12440555));
		t.RibbonControl.PanelBottomBackground = new LinearGradientColorTable(factory.GetColor(10532818), factory.GetColor(15790320));
		t.RibbonControl.StartButtonDefault = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonNormalVistaBlack.png");
		t.RibbonControl.StartButtonMouseOver = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonHotVistaBlack.png");
		t.RibbonControl.StartButtonPressed = (Image)(object)Class109.smethod_67("SystemImages.BlankStartButtonPressedVistaBlack.png");
		t.ItemGroup.TopBackground = new LinearGradientColorTable(factory.GetColor(16711423), factory.GetColor(15067893));
		t.ItemGroup.BottomBackground = new LinearGradientColorTable(factory.GetColor(13949933), factory.GetColor(14804726));
		t.ItemGroup.InnerBorder = new LinearGradientColorTable(factory.GetColor(16777215));
		t.ItemGroup.OuterBorder = new LinearGradientColorTable(factory.GetColor(11713991));
		t.ItemGroup.ItemGroupDividerDark = Color.FromArgb(196, factory.GetColor(13553358));
		t.ItemGroup.ItemGroupDividerLight = Color.FromArgb(128, factory.GetColor(16777215));
		t.Bar.ToolbarTopBackground = new LinearGradientColorTable(factory.GetColor(5923975), factory.GetColor(3488325));
		t.Bar.ToolbarBottomBackground = new LinearGradientColorTable(factory.GetColor(986900), factory.GetColor(5004939));
		t.Bar.ToolbarBottomBorder = factory.GetColor(11187664);
		t.Bar.PopupToolbarBackground = new LinearGradientColorTable(factory.GetColor(16448250), Color.Empty);
		t.Bar.PopupToolbarBorder = factory.GetColor(3092271);
		t.Bar.StatusBarTopBorder = factory.GetColor(3355443);
		t.Bar.StatusBarTopBorderLight = Color.Empty;
		t.Bar.StatusBarAltBackground.Clear();
		t.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(factory.GetColor(11053995), 0f));
		t.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(factory.GetColor(6057849), 0.4f));
		t.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(factory.GetColor(12363), 0.4f));
		t.Bar.StatusBarAltBackground.Add(new BackgroundColorBlend(factory.GetColor(2901611), 1f));
		t.ButtonItemColors.Clear();
		t.RibbonButtonItemColors.Clear();
		t.MenuButtonItemColors.Clear();
		Office2007ButtonItemColorTable menuItemBlue = GetMenuItemBlue(p: false, factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		t.ButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackOrangeWithBackground(factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground);
		t.ButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackBlue(ribbonBar: false, factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Blue);
		t.ButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackBlueWithBackground(factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.BlueWithBackground);
		t.ButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackMagenta(ribbonBar: false, factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Magenta);
		t.ButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackMagentaWithBackground(factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.MagentaWithBackground);
		t.ButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackOrange(ribbonBar: true, factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		t.RibbonButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackOrangeWithBackground(factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground);
		t.RibbonButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackBlue(ribbonBar: true, factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Blue);
		t.RibbonButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackBlueWithBackground(factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.BlueWithBackground);
		t.RibbonButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackMagenta(ribbonBar: true, factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Magenta);
		t.RibbonButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetButtonItemBlackMagentaWithBackground(factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.MagentaWithBackground);
		t.RibbonButtonItemColors.Add(menuItemBlue);
		menuItemBlue = GetMenuItemBlue(p: true, factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Orange);
		t.MenuButtonItemColors.Add(menuItemBlue);
		menuItemBlue = Class224.smethod_8(factory);
		menuItemBlue.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.Office2007WithBackground);
		t.ButtonItemColors.Add(menuItemBlue);
		t.ButtonItemColors.Add(ButtonItemStaticColorTables.CreateBlueOrbColorTable(factory));
		t.RibbonTabGroupColors.Clear();
		Office2007RibbonTabGroupColorTable office2007RibbonTabGroupColorTable = Class224.smethod_33(factory);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Default);
		t.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = Class224.smethod_34(factory);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Magenta);
		t.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = Class224.smethod_35(factory);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Green);
		t.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		office2007RibbonTabGroupColorTable = Class224.smethod_36(factory);
		office2007RibbonTabGroupColorTable.Name = Enum.GetName(typeof(eRibbonTabGroupColor), eRibbonTabGroupColor.Orange);
		t.RibbonTabGroupColors.Add(office2007RibbonTabGroupColorTable);
		t.Menu.Background = new LinearGradientColorTable(factory.GetColor(15790320), Color.Empty);
		t.Menu.Border = new LinearGradientColorTable(factory.GetColor(6579300), Color.Empty);
		t.Menu.Side = new LinearGradientColorTable(factory.GetColor(15856113), Color.Empty);
		t.Menu.SideBorder = new LinearGradientColorTable(factory.GetColor(14869475), Color.Empty);
		t.Menu.SideBorderLight = new LinearGradientColorTable(factory.GetColor(16777215), Color.Empty);
		t.Menu.SideUnused = new LinearGradientColorTable(factory.GetColor(15066597), Color.Empty);
		t.Menu.FileBackgroundBlend.Clear();
		t.Menu.FileBackgroundBlend.AddRange(new BackgroundColorBlend[3]
		{
			new BackgroundColorBlend(factory.GetColor(6450312), 0f),
			new BackgroundColorBlend(factory.GetColor(3751757), 0.01f),
			new BackgroundColorBlend(factory.GetColor(3751757), 1f)
		});
		t.Menu.FileContainerBorder = factory.GetColor(2236962);
		t.Menu.FileContainerBorderLight = factory.GetColor(8028821);
		t.Menu.FileColumnOneBackground = factory.GetColor(16448250);
		t.Menu.FileColumnOneBorder = factory.GetColor(12961221);
		t.Menu.FileColumnTwoBackground = factory.GetColor(15330030);
		t.Menu.FileBottomContainerBackgroundBlend.Clear();
		t.Menu.FileBottomContainerBackgroundBlend.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(factory.GetColor(6450312), 0f),
			new BackgroundColorBlend(factory.GetColor(4147030), 0.5f),
			new BackgroundColorBlend(factory.GetColor(1381654), 0.5f),
			new BackgroundColorBlend(factory.GetColor(3950447), 1f)
		});
		t.ComboBox.Default.Background = factory.GetColor(15921906);
		t.ComboBox.Default.Border = factory.GetColor(9278368);
		t.ComboBox.Default.ExpandBackground = new LinearGradientColorTable();
		t.ComboBox.Default.ExpandBorderInner = new LinearGradientColorTable();
		t.ComboBox.Default.ExpandBorderOuter = new LinearGradientColorTable();
		t.ComboBox.Default.ExpandText = factory.GetColor(8158332);
		t.ComboBox.DefaultStandalone.Background = factory.GetColor(16777215);
		t.ComboBox.DefaultStandalone.Border = factory.GetColor(7368816);
		t.ComboBox.DefaultStandalone.ExpandBackground = new LinearGradientColorTable(factory.GetColor(15921906), factory.GetColor(13619151), 90);
		t.ComboBox.DefaultStandalone.ExpandBorderInner = new LinearGradientColorTable();
		t.ComboBox.DefaultStandalone.ExpandBorderOuter = new LinearGradientColorTable(factory.GetColor(7368816), Color.Empty, 90);
		t.ComboBox.DefaultStandalone.ExpandText = factory.GetColor(0);
		t.ComboBox.MouseOver.Background = factory.GetColor(16777215);
		t.ComboBox.MouseOver.Border = factory.GetColor(3964849);
		t.ComboBox.MouseOver.ExpandBackground = new LinearGradientColorTable(factory.GetColor(15398653), factory.GetColor(11000309), 90);
		t.ComboBox.MouseOver.ExpandBorderInner = new LinearGradientColorTable(factory.GetColor(16449022));
		t.ComboBox.MouseOver.ExpandBorderOuter = new LinearGradientColorTable(factory.GetColor(3964849), Color.Empty, 90);
		t.ComboBox.MouseOver.ExpandText = factory.GetColor(0);
		t.ComboBox.DroppedDown.Background = factory.GetColor(16777215);
		t.ComboBox.DroppedDown.Border = factory.GetColor(2908811);
		t.ComboBox.DroppedDown.ExpandBackground = new LinearGradientColorTable(factory.GetColor(15070460), factory.GetColor(6861787), 90);
		t.ComboBox.DroppedDown.ExpandBorderInner = new LinearGradientColorTable(factory.GetColor(10399930), Color.Transparent, 90);
		t.ComboBox.DroppedDown.ExpandBorderOuter = new LinearGradientColorTable(factory.GetColor(2908811), Color.Empty, 90);
		t.ComboBox.DroppedDown.ExpandText = factory.GetColor(0);
		t.DialogLauncher.Default.DialogLauncher = factory.GetColor(3950447);
		t.DialogLauncher.Default.DialogLauncherShade = factory.GetColor(15461355);
		t.DialogLauncher.MouseOver.DialogLauncher = factory.GetColor(3950447);
		t.DialogLauncher.MouseOver.DialogLauncherShade = factory.GetColor(15461355);
		t.DialogLauncher.MouseOver.TopBackground = new LinearGradientColorTable(factory.GetColor(15333374), factory.GetColor(14545661));
		t.DialogLauncher.MouseOver.BottomBackground = new LinearGradientColorTable(factory.GetColor(9813717), factory.GetColor(11920639));
		t.DialogLauncher.MouseOver.InnerBorder = new LinearGradientColorTable(Color.FromArgb(128, Color.White));
		t.DialogLauncher.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(10855845), factory.GetColor(9803157));
		t.DialogLauncher.Pressed.DialogLauncher = factory.GetColor(3950447);
		t.DialogLauncher.Pressed.DialogLauncherShade = factory.GetColor(15461355);
		t.DialogLauncher.Pressed.TopBackground = new LinearGradientColorTable(factory.GetColor(15333374), factory.GetColor(12970491));
		t.DialogLauncher.Pressed.BottomBackground = new LinearGradientColorTable(factory.GetColor(6594239), factory.GetColor(8901631));
		t.DialogLauncher.Pressed.InnerBorder = new LinearGradientColorTable(Color.FromArgb(128, Color.White));
		t.DialogLauncher.Pressed.OuterBorder = new LinearGradientColorTable(factory.GetColor(10855845), factory.GetColor(9803157));
		InitializeBlackLegacyColors(t.LegacyColors, factory);
		t.SystemButton.Default = new Office2007SystemButtonStateColorTable();
		t.SystemButton.Default.Foreground = new LinearGradientColorTable(factory.GetColor(8686741), factory.GetColor(10463671));
		t.SystemButton.Default.LightShade = factory.GetColor(10463671);
		t.SystemButton.Default.DarkShade = factory.GetColor(8487040);
		t.SystemButton.MouseOver = new Office2007SystemButtonStateColorTable();
		t.SystemButton.MouseOver.Foreground = new LinearGradientColorTable(factory.GetColor(3552565), factory.GetColor(5199715));
		t.SystemButton.MouseOver.LightShade = factory.GetColor(10199464);
		t.SystemButton.MouseOver.DarkShade = factory.GetColor(4541526);
		t.SystemButton.MouseOver.TopBackground = new LinearGradientColorTable(factory.GetColor(11647169), factory.GetColor(8950945));
		t.SystemButton.MouseOver.BottomBackground = new LinearGradientColorTable(factory.GetColor(6845829), factory.GetColor(10334657));
		t.SystemButton.MouseOver.TopHighlight = new LinearGradientColorTable(factory.GetColor(13489114), Color.Transparent);
		t.SystemButton.MouseOver.BottomHighlight = new LinearGradientColorTable(factory.GetColor(11918836), Color.Transparent);
		t.SystemButton.MouseOver.OuterBorder = new LinearGradientColorTable(factory.GetColor(5726317), factory.GetColor(6054505));
		t.SystemButton.MouseOver.InnerBorder = new LinearGradientColorTable(factory.GetColor(13489114), factory.GetColor(14344163));
		t.SystemButton.Pressed = new Office2007SystemButtonStateColorTable();
		t.SystemButton.Pressed.Foreground = new LinearGradientColorTable(factory.GetColor(7171180), factory.GetColor(9148068));
		t.SystemButton.Pressed.LightShade = factory.GetColor(8358036);
		t.SystemButton.Pressed.DarkShade = factory.GetColor(7171180);
		t.SystemButton.Pressed.TopBackground = new LinearGradientColorTable(factory.GetColor(3618615), factory.GetColor(2829099));
		t.SystemButton.Pressed.TopHighlight = new LinearGradientColorTable(factory.GetColor(6842472), Color.Transparent);
		t.SystemButton.Pressed.BottomBackground = new LinearGradientColorTable(factory.GetColor(0), factory.GetColor(461067));
		t.SystemButton.Pressed.BottomHighlight = new LinearGradientColorTable(factory.GetColor(5335426), Color.Transparent);
		t.SystemButton.Pressed.OuterBorder = new LinearGradientColorTable(factory.GetColor(2237481), factory.GetColor(1644825));
		t.SystemButton.Pressed.InnerBorder = new LinearGradientColorTable(factory.GetColor(4605510), factory.GetColor(3355443));
		t.Form.Active.BorderColors = new Color[4]
		{
			factory.GetColor(1052945),
			factory.GetColor(2236962),
			factory.GetColor(4934475),
			factory.GetColor(4934475)
		};
		t.Form.Inactive.BorderColors = new Color[4]
		{
			factory.GetColor(1052945),
			factory.GetColor(2236962),
			factory.GetColor(4934475),
			factory.GetColor(4934475)
		};
		t.Form.Active.CaptionTopBackground = new LinearGradientColorTable(factory.GetColor(6450312), factory.GetColor(3751757));
		t.Form.Active.CaptionBottomBackground = new LinearGradientColorTable(factory.GetColor(1381654), factory.GetColor(3950447));
		t.Form.Active.CaptionBottomBorder = new Color[2]
		{
			factory.GetColor(6581385),
			factory.GetColor(2236962)
		};
		t.Form.Active.CaptionText = factory.GetColor(16777215);
		t.Form.Active.CaptionTextExtra = factory.GetColor(1360604);
		t.Form.Inactive.CaptionTopBackground = new LinearGradientColorTable(factory.GetColor(6450312), factory.GetColor(3751757));
		t.Form.Inactive.CaptionBottomBackground = new LinearGradientColorTable(factory.GetColor(3751757), factory.GetColor(3751757));
		t.Form.Inactive.CaptionText = factory.GetColor(14803425);
		t.Form.Inactive.CaptionTextExtra = factory.GetColor(14803425);
		t.Form.BackColor = factory.GetColor(15660026);
		t.Form.TextColor = factory.GetColor(0);
		t.QuickAccessToolbar.Active.TopBackground = new LinearGradientColorTable(factory.GetColor(6450312), factory.GetColor(5923708));
		t.QuickAccessToolbar.Active.BottomBackground = new LinearGradientColorTable(factory.GetColor(5923708), factory.GetColor(3751757));
		t.QuickAccessToolbar.Active.OutterBorderColor = factory.GetColor(Color.FromArgb(32, Color.White));
		t.QuickAccessToolbar.Active.MiddleBorderColor = factory.GetColor(2236962);
		t.QuickAccessToolbar.Active.InnerBorderColor = Color.Empty;
		t.QuickAccessToolbar.Inactive.TopBackground = new LinearGradientColorTable(factory.GetColor(6450312), factory.GetColor(5923708));
		t.QuickAccessToolbar.Inactive.BottomBackground = new LinearGradientColorTable(factory.GetColor(5923708), factory.GetColor(3751757));
		t.QuickAccessToolbar.Inactive.OutterBorderColor = Color.Transparent;
		t.QuickAccessToolbar.Inactive.MiddleBorderColor = factory.GetColor(2236962);
		t.QuickAccessToolbar.Inactive.InnerBorderColor = Color.Empty;
		t.QuickAccessToolbar.Standalone.TopBackground = new LinearGradientColorTable();
		t.QuickAccessToolbar.Standalone.BottomBackground = new LinearGradientColorTable(factory.GetColor(16711423), factory.GetColor(15067893));
		t.QuickAccessToolbar.Standalone.OutterBorderColor = factory.GetColor(4673110);
		t.QuickAccessToolbar.Standalone.MiddleBorderColor = Color.Empty;
		t.QuickAccessToolbar.Standalone.InnerBorderColor = factory.GetColor(13356238);
		t.QuickAccessToolbar.QatCustomizeMenuLabelBackground = factory.GetColor(13949933);
		t.QuickAccessToolbar.QatCustomizeMenuLabelText = factory.GetColor(0);
		t.QuickAccessToolbar.Active.GlassBorder = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(132, Color.Black)), Color.FromArgb(80, Color.Black));
		t.QuickAccessToolbar.Inactive.GlassBorder = new LinearGradientColorTable(factory.GetColor(Color.FromArgb(132, Color.Black)), Color.FromArgb(80, Color.Black));
		t.TabControl.Default = new Office2007TabItemStateColorTable();
		t.TabControl.Default.TopBackground = new LinearGradientColorTable(factory.GetColor(15922682), factory.GetColor(15067893));
		t.TabControl.Default.BottomBackground = new LinearGradientColorTable(factory.GetColor(13621227), factory.GetColor(15527676));
		t.TabControl.Default.InnerBorder = factory.GetColor(16580093);
		t.TabControl.Default.OuterBorder = factory.GetColor(9541282);
		t.TabControl.Default.Text = factory.GetColor(0);
		t.TabControl.MouseOver = new Office2007TabItemStateColorTable();
		t.TabControl.MouseOver.TopBackground = new LinearGradientColorTable(factory.GetColor(15594492), factory.GetColor(13032695));
		t.TabControl.MouseOver.BottomBackground = new LinearGradientColorTable(factory.GetColor(10077934), factory.GetColor(14281209));
		t.TabControl.MouseOver.InnerBorder = factory.GetColor(16711423);
		t.TabControl.MouseOver.OuterBorder = factory.GetColor(9541282);
		t.TabControl.MouseOver.Text = factory.GetColor(0);
		t.TabControl.Selected = new Office2007TabItemStateColorTable();
		t.TabControl.Selected.TopBackground = new LinearGradientColorTable(factory.GetColor(16514558), factory.GetColor(15201787));
		t.TabControl.Selected.BottomBackground = new LinearGradientColorTable(factory.GetColor(13625338), factory.GetColor(12177914));
		t.TabControl.Selected.InnerBorder = factory.GetColor(16580351);
		t.TabControl.Selected.OuterBorder = factory.GetColor(9541282);
		t.TabControl.Selected.Text = factory.GetColor(0);
		t.TabControl.TabBackground = new LinearGradientColorTable(factory.GetColor(16777215), factory.GetColor(14936308));
		t.TabControl.TabPanelBackground = new LinearGradientColorTable(factory.GetColor(16777215));
		t.TabControl.TabPanelBorder = factory.GetColor(9278368);
		Office2007CheckBoxColorTable checkBoxItem = t.CheckBoxItem;
		checkBoxItem.Default.CheckBackground = new LinearGradientColorTable(factory.GetColor(16053492), Color.Empty);
		checkBoxItem.Default.CheckBorder = factory.GetColor(6381921);
		checkBoxItem.Default.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, factory.GetColor(10661049)), Color.FromArgb(164, factory.GetColor(16185078)));
		checkBoxItem.Default.CheckInnerBorder = factory.GetColor(10661049);
		checkBoxItem.Default.CheckSign = new LinearGradientColorTable(factory.GetColor(5204093), Color.Empty);
		checkBoxItem.Default.Text = factory.GetColor(0);
		checkBoxItem.MouseOver.CheckBackground = new LinearGradientColorTable(factory.GetColor(16053492), Color.Empty);
		checkBoxItem.MouseOver.CheckBorder = factory.GetColor(6381921);
		checkBoxItem.MouseOver.CheckInnerBackground = new LinearGradientColorTable(factory.GetColor(11461887), factory.GetColor(13692156), 90);
		checkBoxItem.MouseOver.CheckInnerBorder = factory.GetColor(11789561);
		checkBoxItem.MouseOver.CheckSign = new LinearGradientColorTable(factory.GetColor(5204093), Color.Empty);
		checkBoxItem.MouseOver.Text = factory.GetColor(0);
		checkBoxItem.Pressed.CheckBackground = new LinearGradientColorTable(factory.GetColor(15068407), Color.Empty);
		checkBoxItem.Pressed.CheckBorder = factory.GetColor(6381921);
		checkBoxItem.Pressed.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, factory.GetColor(6861787)), Color.FromArgb(164, factory.GetColor(15070460)));
		checkBoxItem.Pressed.CheckInnerBorder = factory.GetColor(2908811);
		checkBoxItem.Pressed.CheckSign = new LinearGradientColorTable(factory.GetColor(5204093), Color.Empty);
		checkBoxItem.Pressed.Text = factory.GetColor(0);
		checkBoxItem.Disabled.CheckBackground = new LinearGradientColorTable(factory.GetColor(16777215), Color.Empty);
		checkBoxItem.Disabled.CheckBorder = factory.GetColor(11448757);
		checkBoxItem.Disabled.CheckInnerBackground = new LinearGradientColorTable(Color.FromArgb(192, factory.GetColor(14738149)), Color.FromArgb(164, factory.GetColor(16514043)));
		checkBoxItem.Disabled.CheckInnerBorder = factory.GetColor(14738149);
		checkBoxItem.Disabled.CheckSign = new LinearGradientColorTable(factory.GetColor(9276813), Color.Empty);
		checkBoxItem.Disabled.Text = factory.GetColor(9276813);
		InitializeScrollBarColorTable(t, factory);
		InitializeAppBlackScrollBarColorTable(t, factory);
		Office2007ProgressBarColorTable progressBarItem = t.ProgressBarItem;
		progressBarItem.BackgroundColors = new GradientColorTable(8882571, 9934999);
		progressBarItem.OuterBorder = factory.GetColor(13421772);
		progressBarItem.InnerBorder = factory.GetColor(2434341);
		progressBarItem.Chunk = new GradientColorTable(6788896, 12779350, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(164, factory.GetColor(15663063)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, factory.GetColor(9286228)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, factory.GetColor(6918699)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(8750469, 9474448, 0);
		progressBarItem = t.ProgressBarItemPaused;
		progressBarItem.BackgroundColors = new GradientColorTable(8882571, 9934999);
		progressBarItem.OuterBorder = factory.GetColor(13421772);
		progressBarItem.InnerBorder = factory.GetColor(2434341);
		progressBarItem.Chunk = new GradientColorTable(11446016, 16776653, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(192, factory.GetColor(16776099)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, factory.GetColor(13814272)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, factory.GetColor(16708608)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(8750469, 9474448, 0);
		progressBarItem = t.ProgressBarItemError;
		progressBarItem.BackgroundColors = new GradientColorTable(8882571, 9934999);
		progressBarItem.OuterBorder = factory.GetColor(13421772);
		progressBarItem.InnerBorder = factory.GetColor(2434341);
		progressBarItem.Chunk = new GradientColorTable(13762560, 16764365, 0);
		progressBarItem.ChunkOverlay = new GradientColorTable();
		progressBarItem.ChunkOverlay.LinearGradientAngle = 90;
		progressBarItem.ChunkOverlay.Colors.AddRange(new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(192, factory.GetColor(16748431)), 0f),
			new BackgroundColorBlend(Color.FromArgb(128, factory.GetColor(13762560)), 0.5f),
			new BackgroundColorBlend(Color.FromArgb(64, factory.GetColor(16646144)), 0.5f),
			new BackgroundColorBlend(Color.Transparent, 1f)
		});
		progressBarItem.ChunkShadow = new GradientColorTable(8750469, 9474448, 0);
		Office2007GalleryColorTable gallery = t.Gallery;
		gallery.GroupLabelBackground = factory.GetColor(13949933);
		gallery.GroupLabelText = factory.GetColor(0);
		gallery.GroupLabelBorder = factory.GetColor(12961221);
		t.ListViewEx.Border = factory.GetColor(9278368);
		t.ListViewEx.ColumnBackground = new LinearGradientColorTable(factory.GetColor(16777215), factory.GetColor(15856372));
		t.ListViewEx.ColumnSeparator = factory.GetColor(14013909);
		t.ListViewEx.SelectionBackground = new LinearGradientColorTable(factory.GetColor(15857917), factory.GetColor(14020604));
		t.ListViewEx.SelectionBorder = factory.GetColor(10084093);
		t.NavigationPane.ButtonBackground = new GradientColorTable();
		t.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(16382457), 0f));
		t.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(14342876), 0.4f));
		t.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(13290188), 0.4f));
		t.NavigationPane.ButtonBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(16053494), 1f));
		t.SuperTooltip.BackgroundColors = new LinearGradientColorTable(factory.GetColor(16777215), factory.GetColor(15595263));
		t.SuperTooltip.TextColor = factory.GetColor(0);
		Office2007SliderColorTable slider = t.Slider;
		slider.Default.LabelColor = factory.GetColor(16777215);
		slider.Default.PartBackground = new GradientColorTable();
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(16777215), 0f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(15724527), 0.15f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(12501699), 0.5f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(7106936), 0.5f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(14474462), 0.85f));
		slider.Default.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(16777215), 1f));
		slider.Default.PartBorderColor = factory.GetColor(3751750);
		slider.Default.PartBorderLightColor = Color.FromArgb(28, factory.GetColor(16777215));
		slider.Default.PartForeColor = factory.GetColor(5989228);
		slider.Default.PartForeLightColor = Color.FromArgb(168, factory.GetColor(15395562));
		slider.Default.TrackLineColor = factory.GetColor(2434341);
		slider.Default.TrackLineLightColor = factory.GetColor(13421772);
		slider.MouseOver.LabelColor = factory.GetColor(16777215);
		slider.MouseOver.PartBackground = new GradientColorTable();
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(16777215), 0f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(15857917), 0.1f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(10084093), 0.9f));
		slider.MouseOver.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(15201789), 1f));
		slider.MouseOver.PartBorderColor = factory.GetColor(2960685);
		slider.MouseOver.PartBorderLightColor = Color.FromArgb(28, factory.GetColor(16777215));
		slider.MouseOver.PartForeColor = factory.GetColor(6775369);
		slider.MouseOver.PartForeLightColor = Color.FromArgb(168, factory.GetColor(16774356));
		slider.MouseOver.TrackLineColor = factory.GetColor(2434341);
		slider.MouseOver.TrackLineLightColor = factory.GetColor(13421772);
		slider.Pressed.LabelColor = factory.GetColor(16777215);
		slider.Pressed.PartBackground = new GradientColorTable();
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(15070460), 0f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(12903926), 0.5f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(10015215), 0.5f));
		slider.Pressed.PartBackground.Colors.Add(new BackgroundColorBlend(factory.GetColor(6861272), 1f));
		slider.Pressed.PartBorderColor = factory.GetColor(2960685);
		slider.Pressed.PartBorderLightColor = Color.FromArgb(28, factory.GetColor(16777215));
		slider.Pressed.PartForeColor = factory.GetColor(6771523);
		slider.Pressed.PartForeLightColor = Color.FromArgb(32, factory.GetColor(16768187));
		slider.Pressed.TrackLineColor = factory.GetColor(2434341);
		slider.Pressed.TrackLineLightColor = factory.GetColor(13421772);
		ColorBlendFactory colorBlendFactory = new ColorBlendFactory(ColorScheme.GetColor(13619151));
		slider.Disabled.LabelColor = factory.GetColor(9276813);
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
		t.DataGridView.ColumnHeaderNormalBorder = factory.GetColor(11974326);
		t.DataGridView.ColumnHeaderNormalBackground = new LinearGradientColorTable(factory.GetColor(16316664), factory.GetColor(14606046), 90);
		t.DataGridView.ColumnHeaderSelectedBackground = new LinearGradientColorTable(factory.GetColor(16374175), factory.GetColor(15843679), 90);
		t.DataGridView.ColumnHeaderSelectedBorder = factory.GetColor(15897910);
		t.DataGridView.ColumnHeaderSelectedMouseOverBackground = new LinearGradientColorTable(factory.GetColor(16766349), factory.GetColor(15897146), 90);
		t.DataGridView.ColumnHeaderSelectedMouseOverBorder = factory.GetColor(15897910);
		t.DataGridView.ColumnHeaderMouseOverBackground = new LinearGradientColorTable(factory.GetColor(14737632), factory.GetColor(12829635), 90);
		t.DataGridView.ColumnHeaderMouseOverBorder = factory.GetColor(11974326);
		t.DataGridView.ColumnHeaderPressedBackground = new LinearGradientColorTable(factory.GetColor(14737632), factory.GetColor(12829635), 90);
		t.DataGridView.ColumnHeaderPressedBorder = factory.GetColor(16777215);
		t.DataGridView.RowNormalBackground = new LinearGradientColorTable(factory.GetColor(15592941));
		t.DataGridView.RowNormalBorder = factory.GetColor(11974326);
		t.DataGridView.RowSelectedBackground = new LinearGradientColorTable(factory.GetColor(16186365), factory.GetColor(14020604));
		t.DataGridView.RowSelectedBorder = factory.GetColor(10084093);
		t.DataGridView.RowSelectedMouseOverBackground = new LinearGradientColorTable(factory.GetColor(15267581), factory.GetColor(12904698));
		t.DataGridView.RowSelectedMouseOverBorder = factory.GetColor(11986683);
		t.DataGridView.RowMouseOverBackground = new LinearGradientColorTable(factory.GetColor(16120573), factory.GetColor(15267325));
		t.DataGridView.RowMouseOverBorder = factory.GetColor(14217466);
		t.DataGridView.RowPressedBackground = new LinearGradientColorTable(factory.GetColor(12379385), factory.GetColor(9097717));
		t.DataGridView.RowPressedBorder = factory.GetColor(5149102);
		t.DataGridView.GridColor = factory.GetColor(13686757);
		t.DataGridView.SelectorBackground = new LinearGradientColorTable(factory.GetColor(13224393));
		t.DataGridView.SelectorBorder = factory.GetColor(11974326);
		t.DataGridView.SelectorBorderDark = factory.GetColor(13421772);
		t.DataGridView.SelectorBorderLight = factory.GetColor(15461355);
		t.DataGridView.SelectorSign = new LinearGradientColorTable(factory.GetColor(8224125), factory.GetColor(6776679));
		t.DataGridView.SelectorMouseOverBackground = new LinearGradientColorTable(factory.GetColor(11382189), factory.GetColor(10461087));
		t.DataGridView.SelectorMouseOverBorder = factory.GetColor(11974326);
		t.DataGridView.SelectorMouseOverBorderDark = factory.GetColor(13421772);
		t.DataGridView.SelectorMouseOverBorderLight = factory.GetColor(15461355);
		t.DataGridView.SelectorMouseOverSign = new LinearGradientColorTable(factory.GetColor(8224125), factory.GetColor(6776679));
		t.AdvTree = new TreeColorTable();
		Class5.smethod_3(t.AdvTree, factory);
		t.CrumbBarItemView = CrumbBar.smethod_0(factory);
		t.StyleClasses.Clear();
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.RibbonGalleryContainerKey;
		elementStyle.BorderColor = factory.GetColor(6055538);
		elementStyle.Border = eStyleBorderType.Solid;
		elementStyle.BorderWidth = 1;
		elementStyle.CornerDiameter = 2;
		elementStyle.CornerType = eCornerType.Rounded;
		elementStyle.BackColor = factory.GetColor(15398142);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_43(t);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_44(t);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_45(t);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_46(t);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_47(t);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_48(factory.GetColor(9278368));
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_53(factory.GetColor(9278368));
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_54(factory, eOffice2007ColorScheme.Black);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_55(t.ListViewEx);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = GetStatusBarAltStyle(t.Bar);
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_49(factory.GetColor(9278368));
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_50(factory.GetColor(16316664), factory.GetColor(14606046), factory.GetColor(11974326));
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_51(factory.GetColor(16316664), factory.GetColor(14606046), factory.GetColor(11974326));
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_52(factory.GetColor(0));
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		elementStyle = Class224.smethod_57(factory.GetColor(Color.White), factory.GetColor("FF333333"), factory.GetColor("FF252525"));
		t.StyleClasses.Add(elementStyle.Class, elementStyle);
		t.SideBar.Background = new LinearGradientColorTable(factory.GetColor(Color.White));
		t.SideBar.Border = factory.GetColor(9278368);
		t.SideBar.SideBarPanelItemText = factory.GetColor(Color.Black);
		t.SideBar.SideBarPanelItemDefault = new GradientColorTable();
		t.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(factory.GetColor(16316665), 0f));
		t.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(factory.GetColor(14672612), 0.4f));
		t.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(factory.GetColor(13093841), 0.4f));
		t.SideBar.SideBarPanelItemDefault.Colors.Add(new BackgroundColorBlend(factory.GetColor(14409442), 1f));
		t.SideBar.SideBarPanelItemExpanded = new GradientColorTable();
		t.SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(factory.GetColor(14940159), 0f));
		t.SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(factory.GetColor(14940159), 0.4f));
		t.SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(factory.GetColor(12447231), 0.4f));
		t.SideBar.SideBarPanelItemExpanded.Colors.Add(new BackgroundColorBlend(factory.GetColor(12052475), 1f));
		t.SideBar.SideBarPanelItemMouseOver = new GradientColorTable();
		t.SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(factory.GetColor(15070202), 0f));
		t.SideBar.SideBarPanelItemMouseOver.Colors.Add(new BackgroundColorBlend(factory.GetColor(13692156), 1f));
		t.SideBar.SideBarPanelItemPressed = new GradientColorTable();
		t.SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(factory.GetColor(15070460), 0f));
		t.SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(factory.GetColor(12903926), 0.4f));
		t.SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(factory.GetColor(10015215), 0.4f));
		t.SideBar.SideBarPanelItemPressed.Colors.Add(new BackgroundColorBlend(factory.GetColor(6861787), 1f));
	}

	public static void InitializeBlackLegacyColors(ColorScheme c, ColorFactory factory)
	{
		c.BarBackground = factory.GetColor(16711423);
		c.BarBackground2 = factory.GetColor(13949933);
		c.BarStripeColor = factory.GetColor(6713468);
		c.BarCaptionBackground = factory.GetColor(6052956);
		c.BarCaptionBackground2 = factory.GetColor(0);
		c.BarCaptionInactiveBackground = factory.GetColor(6450312);
		c.BarCaptionInactiveBackground2 = factory.GetColor(3751757);
		c.BarCaptionInactiveText = factory.GetColor(16777215);
		c.BarCaptionText = factory.GetColor(16777215);
		c.BarFloatingBorder = factory.GetColor(4739159);
		c.BarPopupBackground = factory.GetColor(15921906);
		c.BarPopupBorder = factory.GetColor(6579300);
		c.ItemBackground = Color.Empty;
		c.ItemBackground2 = Color.Empty;
		c.ItemCheckedBackground = factory.GetColor(15463931);
		c.ItemCheckedBackground2 = factory.GetColor(13362933);
		c.ItemCheckedBorder = factory.GetColor(3964849);
		c.ItemCheckedText = factory.GetColor(0);
		c.ItemDisabledBackground = Color.Empty;
		c.ItemDisabledText = factory.GetColor(9276813);
		c.ItemExpandedShadow = Color.Empty;
		c.ItemExpandedBackground = factory.GetColor(15463931);
		c.ItemExpandedBackground2 = factory.GetColor(13362933);
		c.ItemExpandedText = factory.GetColor(0);
		c.ItemHotBackground = factory.GetColor(15070202);
		c.ItemHotBackground2 = factory.GetColor(13692156);
		c.ItemHotBorder = factory.GetColor(9886714);
		c.ItemHotText = factory.GetColor(0);
		c.ItemPressedBackground = factory.GetColor(15070460);
		c.ItemPressedBackground2 = factory.GetColor(6861787);
		c.ItemPressedBorder = factory.GetColor(2908811);
		c.ItemPressedText = factory.GetColor(0);
		c.ItemSeparator = Color.FromArgb(225, factory.GetColor(9542052));
		c.ItemSeparatorShade = Color.FromArgb(180, factory.GetColor(16777215));
		c.ItemText = factory.GetColor(0);
		c.MenuBackground = factory.GetColor(15790320);
		c.MenuBackground2 = Color.Empty;
		c.MenuBarBackground = factory.GetColor(15067893);
		c.MenuBorder = factory.GetColor(6579300);
		c.ItemExpandedBorder = c.MenuBorder;
		c.MenuSide = factory.GetColor(15856113);
		c.MenuSide2 = Color.Empty;
		c.MenuUnusedBackground = c.MenuBackground;
		c.MenuUnusedSide = factory.GetColor(15066597);
		c.MenuUnusedSide2 = Color.Empty;
		c.ItemDesignTimeBorder = Color.Black;
		c.BarDockedBorder = factory.GetColor(6647931);
		c.DockSiteBackColor = factory.GetColor(15660026);
		c.DockSiteBackColor2 = Color.Empty;
		c.CustomizeBackground = factory.GetColor(8563391);
		c.CustomizeBackground2 = factory.GetColor(1990273);
		c.CustomizeText = factory.GetColor(16777215);
		c.PanelBackground = factory.GetColor(16711423);
		c.PanelBackground2 = factory.GetColor(15067893);
		c.PanelText = Color.Black;
		c.PanelBorder = factory.GetColor(6581881);
		c.ExplorerBarBackground = factory.GetColor(13949933);
		c.ExplorerBarBackground2 = factory.GetColor(14804726);
		c.MdiSystemItemForeground = Color.LightGray;
	}

	public static ElementStyle GetStatusBarAltStyle(Office2007BarColorTable t)
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.Class = ElementStyleClassKeys.Office2007StatusBarBackground2Key;
		elementStyle.PaddingLeft = 4;
		elementStyle.BorderLeft = eStyleBorderType.Etched;
		elementStyle.BorderLeftWidth = 1;
		elementStyle.BorderLeftColor = Color.FromArgb(196, t.StatusBarTopBorder);
		elementStyle.BorderColorLight = Color.FromArgb(128, Color.White);
		if (t.StatusBarAltBackground.Count > 0)
		{
			elementStyle.BackColorBlend.CopyFrom(t.StatusBarAltBackground);
			elementStyle.BackColorGradientAngle = 90;
		}
		return elementStyle;
	}
}

using System;
using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class ButtonItemStaticColorTables
{
	public static Office2007ButtonItemColorTable CreateBlueOrbColorTable()
	{
		return CreateBlueOrbColorTable(new ColorFactory());
	}

	public static Office2007ButtonItemColorTable CreateBlueOrbColorTable(ColorFactory factory)
	{
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = new Office2007ButtonItemColorTable();
		office2007ButtonItemColorTable.Name = Enum.GetName(typeof(eButtonColor), eButtonColor.BlueOrb);
		office2007ButtonItemColorTable.Default = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Default.OuterBorder.Start = factory.GetColor(5403567);
		office2007ButtonItemColorTable.Default.OuterBorder.End = factory.GetColor(538751);
		office2007ButtonItemColorTable.Default.InnerBorder.Start = factory.GetColor(14082031);
		office2007ButtonItemColorTable.Default.InnerBorder.End = factory.GetColor(192, 5675476);
		office2007ButtonItemColorTable.Default.TopBackground.Start = factory.GetColor(11910878);
		office2007ButtonItemColorTable.Default.TopBackground.End = factory.GetColor(3500209);
		office2007ButtonItemColorTable.Default.BottomBackground.Start = factory.GetColor(7007);
		office2007ButtonItemColorTable.Default.BottomBackground.End = factory.GetColor(4970239);
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight.Start = factory.GetColor(5692159);
		office2007ButtonItemColorTable.Default.BottomBackgroundHighlight.End = Color.Transparent;
		office2007ButtonItemColorTable.Default.Text = factory.GetColor(16777215);
		office2007ButtonItemColorTable.MouseOver = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.MouseOver.OuterBorder.Start = factory.GetColor(5342664);
		office2007ButtonItemColorTable.MouseOver.OuterBorder.End = factory.GetColor(480466);
		office2007ButtonItemColorTable.MouseOver.InnerBorder.Start = factory.GetColor(14411767);
		office2007ButtonItemColorTable.MouseOver.InnerBorder.End = factory.GetColor(128, 6715307);
		office2007ButtonItemColorTable.MouseOver.TopBackground.Start = factory.GetColor(11913963);
		office2007ButtonItemColorTable.MouseOver.TopBackground.End = factory.GetColor(4492246);
		office2007ButtonItemColorTable.MouseOver.BottomBackground.Start = factory.GetColor(15249);
		office2007ButtonItemColorTable.MouseOver.BottomBackground.End = factory.GetColor(6866427);
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight.Start = factory.GetColor(12451839);
		office2007ButtonItemColorTable.MouseOver.BottomBackgroundHighlight.End = Color.Transparent;
		office2007ButtonItemColorTable.MouseOver.Text = factory.GetColor(16777215);
		office2007ButtonItemColorTable.Pressed = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Pressed.OuterBorder.Start = factory.GetColor(3160393);
		office2007ButtonItemColorTable.Pressed.OuterBorder.End = factory.GetColor(141667);
		office2007ButtonItemColorTable.Pressed.InnerBorder.Start = factory.GetColor(10266813);
		office2007ButtonItemColorTable.Pressed.InnerBorder.End = Color.Transparent;
		office2007ButtonItemColorTable.Pressed.TopBackground.Start = factory.GetColor(7634069);
		office2007ButtonItemColorTable.Pressed.TopBackground.End = factory.GetColor(3296635);
		office2007ButtonItemColorTable.Pressed.BottomBackground.Start = factory.GetColor(14960);
		office2007ButtonItemColorTable.Pressed.BottomBackground.End = factory.GetColor(22939);
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight.Start = factory.GetColor(6413055);
		office2007ButtonItemColorTable.Pressed.BottomBackgroundHighlight.End = Color.Transparent;
		office2007ButtonItemColorTable.Pressed.Text = factory.GetColor(16777215);
		office2007ButtonItemColorTable.Disabled = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Disabled.OuterBorder.Start = factory.GetColor(8689833);
		office2007ButtonItemColorTable.Disabled.OuterBorder.End = factory.GetColor(3422535);
		office2007ButtonItemColorTable.Disabled.InnerBorder.Start = Color.Transparent;
		office2007ButtonItemColorTable.Disabled.InnerBorder.End = factory.GetColor(14148851);
		office2007ButtonItemColorTable.Disabled.TopBackground.Start = factory.GetColor(16054266);
		office2007ButtonItemColorTable.Disabled.TopBackground.End = factory.GetColor(12966376);
		office2007ButtonItemColorTable.Disabled.BottomBackground.Start = factory.GetColor(11453144);
		office2007ButtonItemColorTable.Disabled.BottomBackground.End = factory.GetColor(12505832);
		office2007ButtonItemColorTable.Disabled.Text = factory.GetColor(14478066);
		office2007ButtonItemColorTable.Expanded = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Expanded.OuterBorder.Start = factory.GetColor(5403567);
		office2007ButtonItemColorTable.Expanded.OuterBorder.End = factory.GetColor(538751);
		office2007ButtonItemColorTable.Expanded.InnerBorder.Start = factory.GetColor(14082031);
		office2007ButtonItemColorTable.Expanded.InnerBorder.End = factory.GetColor(192, 5675476);
		office2007ButtonItemColorTable.Expanded.TopBackground.Start = factory.GetColor(11910878);
		office2007ButtonItemColorTable.Expanded.TopBackground.End = factory.GetColor(3500209);
		office2007ButtonItemColorTable.Expanded.BottomBackground.Start = factory.GetColor(5718);
		office2007ButtonItemColorTable.Expanded.BottomBackground.End = factory.GetColor(4970239);
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight.Start = factory.GetColor(5692159);
		office2007ButtonItemColorTable.Expanded.BottomBackgroundHighlight.End = Color.Transparent;
		office2007ButtonItemColorTable.Expanded.Text = factory.GetColor(16777215);
		office2007ButtonItemColorTable.Checked = new Office2007ButtonItemStateColorTable();
		office2007ButtonItemColorTable.Checked.OuterBorder.Start = factory.GetColor(3160393);
		office2007ButtonItemColorTable.Checked.OuterBorder.End = factory.GetColor(141667);
		office2007ButtonItemColorTable.Checked.InnerBorder.Start = factory.GetColor(10266813);
		office2007ButtonItemColorTable.Checked.InnerBorder.End = Color.Transparent;
		office2007ButtonItemColorTable.Checked.TopBackground.Start = factory.GetColor(11910878);
		office2007ButtonItemColorTable.Checked.TopBackground.End = factory.GetColor(3500209);
		office2007ButtonItemColorTable.Checked.BottomBackground.Start = factory.GetColor(1590);
		office2007ButtonItemColorTable.Checked.BottomBackground.End = factory.GetColor(22939);
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight.Start = factory.GetColor(6413055);
		office2007ButtonItemColorTable.Checked.BottomBackgroundHighlight.End = Color.Transparent;
		office2007ButtonItemColorTable.Checked.Text = factory.GetColor(16777215);
		return office2007ButtonItemColorTable;
	}
}

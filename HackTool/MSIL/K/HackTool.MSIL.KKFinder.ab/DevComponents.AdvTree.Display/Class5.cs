using DevComponents.DotNetBar.Rendering;
using DevComponents.WinForms.Drawing;

namespace DevComponents.AdvTree.Display;

internal class Class5
{
	public static void smethod_0(TreeColorTable treeColorTable_0, ColorFactory colorFactory_0)
	{
		TreeSelectionColors treeSelectionColors = (treeColorTable_0.Selection = new TreeSelectionColors());
		SelectionColorTable selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(10997232));
		treeSelectionColors.FullRowSelect = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(15066597));
		treeSelectionColors.FullRowSelectInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(64, 3238597));
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(96, 3238597), 1);
		treeSelectionColors.NodeMarker = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(64, 15066597));
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(96, 0), 1);
		treeSelectionColors.NodeMarkerInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(new ColorStop[4]
		{
			new ColorStop(colorFactory_0.GetColor(16776409), 0f),
			new ColorStop(colorFactory_0.GetColor(16770957), 0.4f),
			new ColorStop(colorFactory_0.GetColor(16766792), 0.4f),
			new ColorStop(colorFactory_0.GetColor(16770963), 1f)
		});
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14536603), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(192, 16773822), 1);
		treeSelectionColors.HighlightCells = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(colorFactory_0.GetColor(16448251), colorFactory_0.GetColor(15066597), 90f);
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14277081), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(228, 16777215), 1);
		treeSelectionColors.HighlightCellsInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(colorFactory_0.GetColor(16448251), colorFactory_0.GetColor(15066597), 90f);
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14277081), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(228, 16777215), 1);
		treeSelectionColors.NodeHotTracking = selectionColorTable;
		TreeExpandColorTable treeExpandColorTable = new TreeExpandColorTable();
		treeExpandColorTable.CollapseBorder = new SolidBorder(colorFactory_0.GetColor(0), 1);
		treeExpandColorTable.CollapseFill = new SolidFill(colorFactory_0.GetColor(5855577));
		treeExpandColorTable.CollapseMouseOverBorder = new SolidBorder(colorFactory_0.GetColor(1885431), 1);
		treeExpandColorTable.CollapseMouseOverFill = new SolidFill(colorFactory_0.GetColor(8577019));
		treeExpandColorTable.ExpandBorder = new SolidBorder(colorFactory_0.GetColor(8684676), 1);
		treeExpandColorTable.ExpandFill = new SolidFill(colorFactory_0.GetColor(16777215));
		treeExpandColorTable.ExpandMouseOverBorder = new SolidBorder(colorFactory_0.GetColor(1885431), 1);
		treeExpandColorTable.ExpandMouseOverFill = new SolidFill(colorFactory_0.GetColor(13430266));
		treeColorTable_0.ExpandTriangle = treeExpandColorTable;
		treeExpandColorTable = new TreeExpandColorTable();
		treeExpandColorTable.CollapseForeground = new SolidFill(colorFactory_0.GetColor(0));
		treeExpandColorTable.CollapseBorder = new SolidBorder(colorFactory_0.GetColor(9868950), 1);
		treeExpandColorTable.CollapseFill = new GradientFill(new ColorStop[3]
		{
			new ColorStop(colorFactory_0.GetColor(16777215), 0f),
			new ColorStop(colorFactory_0.GetColor(16777215), 0.4f),
			new ColorStop(colorFactory_0.GetColor(11974326), 1f)
		}, 45);
		treeExpandColorTable.CollapseMouseOverForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.CollapseMouseOverBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.CollapseMouseOverFill = treeExpandColorTable.CollapseFill;
		treeExpandColorTable.ExpandForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.ExpandBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.ExpandFill = treeExpandColorTable.CollapseFill;
		treeExpandColorTable.ExpandMouseOverForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.ExpandMouseOverBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.ExpandMouseOverFill = treeExpandColorTable.CollapseFill;
		treeColorTable_0.ExpandRectangle = treeExpandColorTable;
		treeColorTable_0.ExpandEllipse = treeExpandColorTable;
		treeColorTable_0.GridLines = colorFactory_0.GetColor(14803425);
	}

	public static void smethod_1(TreeColorTable treeColorTable_0, ColorFactory colorFactory_0)
	{
		TreeSelectionColors treeSelectionColors = (treeColorTable_0.Selection = new TreeSelectionColors());
		SelectionColorTable selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(10997232));
		treeSelectionColors.FullRowSelect = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(15066597));
		treeSelectionColors.FullRowSelectInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(64, 3238597));
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(96, 3238597), 1);
		treeSelectionColors.NodeMarker = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(64, 15066597));
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(96, 0), 1);
		treeSelectionColors.NodeMarkerInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(new ColorStop[4]
		{
			new ColorStop(colorFactory_0.GetColor(16776409), 0f),
			new ColorStop(colorFactory_0.GetColor(16770957), 0.4f),
			new ColorStop(colorFactory_0.GetColor(16766792), 0.4f),
			new ColorStop(colorFactory_0.GetColor(16770963), 1f)
		});
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14536603), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(192, 16773822), 1);
		treeSelectionColors.HighlightCells = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(colorFactory_0.GetColor(16448251), colorFactory_0.GetColor(15066597), 90f);
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14277081), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(228, 16777215), 1);
		treeSelectionColors.HighlightCellsInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(colorFactory_0.GetColor(16448251), colorFactory_0.GetColor(15066597), 90f);
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14277081), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(228, 16777215), 1);
		treeSelectionColors.NodeHotTracking = selectionColorTable;
		TreeExpandColorTable treeExpandColorTable = new TreeExpandColorTable();
		treeExpandColorTable.CollapseBorder = new SolidBorder(colorFactory_0.GetColor(0), 1);
		treeExpandColorTable.CollapseFill = new SolidFill(colorFactory_0.GetColor(5855577));
		treeExpandColorTable.CollapseMouseOverBorder = new SolidBorder(colorFactory_0.GetColor(1885431), 1);
		treeExpandColorTable.CollapseMouseOverFill = new SolidFill(colorFactory_0.GetColor(8577019));
		treeExpandColorTable.ExpandBorder = new SolidBorder(colorFactory_0.GetColor(8684676), 1);
		treeExpandColorTable.ExpandFill = new SolidFill(colorFactory_0.GetColor(16777215));
		treeExpandColorTable.ExpandMouseOverBorder = new SolidBorder(colorFactory_0.GetColor(1885431), 1);
		treeExpandColorTable.ExpandMouseOverFill = new SolidFill(colorFactory_0.GetColor(13430266));
		treeColorTable_0.ExpandTriangle = treeExpandColorTable;
		treeExpandColorTable = new TreeExpandColorTable();
		treeExpandColorTable.CollapseForeground = new SolidFill(colorFactory_0.GetColor(0));
		treeExpandColorTable.CollapseBorder = new SolidBorder(colorFactory_0.GetColor(9868950), 1);
		treeExpandColorTable.CollapseFill = new GradientFill(new ColorStop[3]
		{
			new ColorStop(colorFactory_0.GetColor(16777215), 0f),
			new ColorStop(colorFactory_0.GetColor(16777215), 0.4f),
			new ColorStop(colorFactory_0.GetColor(11974326), 1f)
		}, 45);
		treeExpandColorTable.CollapseMouseOverForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.CollapseMouseOverBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.CollapseMouseOverFill = treeExpandColorTable.CollapseFill;
		treeExpandColorTable.ExpandForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.ExpandBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.ExpandFill = treeExpandColorTable.CollapseFill;
		treeExpandColorTable.ExpandMouseOverForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.ExpandMouseOverBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.ExpandMouseOverFill = treeExpandColorTable.CollapseFill;
		treeColorTable_0.ExpandRectangle = treeExpandColorTable;
		treeColorTable_0.ExpandEllipse = treeExpandColorTable;
		treeColorTable_0.GridLines = colorFactory_0.GetColor(14803425);
	}

	public static void smethod_2(TreeColorTable treeColorTable_0, ColorFactory colorFactory_0)
	{
		TreeSelectionColors treeSelectionColors = (treeColorTable_0.Selection = new TreeSelectionColors());
		SelectionColorTable selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(10997232));
		treeSelectionColors.FullRowSelect = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(15066597));
		treeSelectionColors.FullRowSelectInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(64, 3238597));
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(96, 3238597), 1);
		treeSelectionColors.NodeMarker = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(64, 15066597));
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(96, 0), 1);
		treeSelectionColors.NodeMarkerInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(new ColorStop[4]
		{
			new ColorStop(colorFactory_0.GetColor(16776409), 0f),
			new ColorStop(colorFactory_0.GetColor(16770957), 0.4f),
			new ColorStop(colorFactory_0.GetColor(16766792), 0.4f),
			new ColorStop(colorFactory_0.GetColor(16770963), 1f)
		});
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14536603), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(192, 16773822), 1);
		treeSelectionColors.HighlightCells = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(colorFactory_0.GetColor(16448251), colorFactory_0.GetColor(15066597), 90f);
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14277081), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(228, 16777215), 1);
		treeSelectionColors.HighlightCellsInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(colorFactory_0.GetColor(16448251), colorFactory_0.GetColor(15066597), 90f);
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14277081), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(228, 16777215), 1);
		treeSelectionColors.NodeHotTracking = selectionColorTable;
		TreeExpandColorTable treeExpandColorTable = new TreeExpandColorTable();
		treeExpandColorTable.CollapseBorder = new SolidBorder(colorFactory_0.GetColor(0), 1);
		treeExpandColorTable.CollapseFill = new SolidFill(colorFactory_0.GetColor(5855577));
		treeExpandColorTable.CollapseMouseOverBorder = new SolidBorder(colorFactory_0.GetColor(1885431), 1);
		treeExpandColorTable.CollapseMouseOverFill = new SolidFill(colorFactory_0.GetColor(8577019));
		treeExpandColorTable.ExpandBorder = new SolidBorder(colorFactory_0.GetColor(8684676), 1);
		treeExpandColorTable.ExpandFill = new SolidFill(colorFactory_0.GetColor(16777215));
		treeExpandColorTable.ExpandMouseOverBorder = new SolidBorder(colorFactory_0.GetColor(1885431), 1);
		treeExpandColorTable.ExpandMouseOverFill = new SolidFill(colorFactory_0.GetColor(13430266));
		treeColorTable_0.ExpandTriangle = treeExpandColorTable;
		treeExpandColorTable = new TreeExpandColorTable();
		treeExpandColorTable.CollapseForeground = new SolidFill(colorFactory_0.GetColor(0));
		treeExpandColorTable.CollapseBorder = new SolidBorder(colorFactory_0.GetColor(9868950), 1);
		treeExpandColorTable.CollapseFill = new GradientFill(new ColorStop[3]
		{
			new ColorStop(colorFactory_0.GetColor(16777215), 0f),
			new ColorStop(colorFactory_0.GetColor(16777215), 0.4f),
			new ColorStop(colorFactory_0.GetColor(11974326), 1f)
		}, 45);
		treeExpandColorTable.CollapseMouseOverForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.CollapseMouseOverBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.CollapseMouseOverFill = treeExpandColorTable.CollapseFill;
		treeExpandColorTable.ExpandForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.ExpandBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.ExpandFill = treeExpandColorTable.CollapseFill;
		treeExpandColorTable.ExpandMouseOverForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.ExpandMouseOverBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.ExpandMouseOverFill = treeExpandColorTable.CollapseFill;
		treeColorTable_0.ExpandRectangle = treeExpandColorTable;
		treeColorTable_0.ExpandEllipse = treeExpandColorTable;
		treeColorTable_0.GridLines = colorFactory_0.GetColor(14803425);
	}

	public static void smethod_3(TreeColorTable treeColorTable_0, ColorFactory colorFactory_0)
	{
		TreeSelectionColors treeSelectionColors = (treeColorTable_0.Selection = new TreeSelectionColors());
		SelectionColorTable selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(12904698));
		treeSelectionColors.FullRowSelect = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(15066597));
		treeSelectionColors.FullRowSelectInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(64, 3238597));
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(96, 3238597), 1);
		treeSelectionColors.NodeMarker = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new SolidFill(colorFactory_0.GetColor(64, 15066597));
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(96, 0), 1);
		treeSelectionColors.NodeMarkerInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(new ColorStop[2]
		{
			new ColorStop(colorFactory_0.GetColor(15857917), 0f),
			new ColorStop(colorFactory_0.GetColor(14020604), 1f)
		});
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(10084093), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(192, 16186365), 1);
		treeSelectionColors.HighlightCells = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(colorFactory_0.GetColor(16316664), colorFactory_0.GetColor(15066597), 90f);
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14277081), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(228, 16448251), 1);
		treeSelectionColors.HighlightCellsInactive = selectionColorTable;
		selectionColorTable = new SelectionColorTable();
		selectionColorTable.Fill = new GradientFill(colorFactory_0.GetColor(16120573), colorFactory_0.GetColor(15267325), 90f);
		selectionColorTable.Border = new SolidBorder(colorFactory_0.GetColor(14217466), 1);
		selectionColorTable.InnerBorder = new SolidBorder(colorFactory_0.GetColor(228, 16317694), 1);
		treeSelectionColors.NodeHotTracking = selectionColorTable;
		TreeExpandColorTable treeExpandColorTable = new TreeExpandColorTable();
		treeExpandColorTable.CollapseBorder = new SolidBorder(colorFactory_0.GetColor(0), 1);
		treeExpandColorTable.CollapseFill = new SolidFill(colorFactory_0.GetColor(5855577));
		treeExpandColorTable.CollapseMouseOverBorder = new SolidBorder(colorFactory_0.GetColor(1885431), 1);
		treeExpandColorTable.CollapseMouseOverFill = new SolidFill(colorFactory_0.GetColor(8577019));
		treeExpandColorTable.ExpandBorder = new SolidBorder(colorFactory_0.GetColor(8684676), 1);
		treeExpandColorTable.ExpandFill = new SolidFill(colorFactory_0.GetColor(16777215));
		treeExpandColorTable.ExpandMouseOverBorder = new SolidBorder(colorFactory_0.GetColor(1885431), 1);
		treeExpandColorTable.ExpandMouseOverFill = new SolidFill(colorFactory_0.GetColor(13430266));
		treeColorTable_0.ExpandTriangle = treeExpandColorTable;
		treeExpandColorTable = new TreeExpandColorTable();
		treeExpandColorTable.CollapseForeground = new SolidFill(colorFactory_0.GetColor(0));
		treeExpandColorTable.CollapseBorder = new SolidBorder(colorFactory_0.GetColor(9868950), 1);
		treeExpandColorTable.CollapseFill = new GradientFill(new ColorStop[3]
		{
			new ColorStop(colorFactory_0.GetColor(16777215), 0f),
			new ColorStop(colorFactory_0.GetColor(16777215), 0.4f),
			new ColorStop(colorFactory_0.GetColor(11974326), 1f)
		}, 45);
		treeExpandColorTable.CollapseMouseOverForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.CollapseMouseOverBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.CollapseMouseOverFill = treeExpandColorTable.CollapseFill;
		treeExpandColorTable.ExpandForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.ExpandBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.ExpandFill = treeExpandColorTable.CollapseFill;
		treeExpandColorTable.ExpandMouseOverForeground = treeExpandColorTable.CollapseForeground;
		treeExpandColorTable.ExpandMouseOverBorder = treeExpandColorTable.CollapseBorder;
		treeExpandColorTable.ExpandMouseOverFill = treeExpandColorTable.CollapseFill;
		treeColorTable_0.ExpandRectangle = treeExpandColorTable;
		treeColorTable_0.ExpandEllipse = treeExpandColorTable;
		treeColorTable_0.GridLines = colorFactory_0.GetColor(15592941);
	}
}

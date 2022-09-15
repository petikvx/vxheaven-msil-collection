using System.Drawing;
using DevComponents.WinForms.Drawing;

namespace DevComponents.AdvTree.Display;

internal class Class8
{
	private Class280[] class280_0;

	private Class280[] class280_1;

	private Class280[] class280_2;

	private TreeSelectionColors treeSelectionColors_0;

	public TreeSelectionColors TreeSelectionColors_0
	{
		get
		{
			return treeSelectionColors_0;
		}
		set
		{
			treeSelectionColors_0 = value;
		}
	}

	public void method_0(SelectionRendererEventArgs selectionRendererEventArgs_0)
	{
		if (selectionRendererEventArgs_0.SelectionBoxStyle == eSelectionStyle.HighlightCells)
		{
			method_4(selectionRendererEventArgs_0);
		}
		else if (selectionRendererEventArgs_0.SelectionBoxStyle == eSelectionStyle.FullRowSelect)
		{
			method_2(selectionRendererEventArgs_0);
		}
		else if (selectionRendererEventArgs_0.SelectionBoxStyle == eSelectionStyle.NodeMarker)
		{
			method_7(selectionRendererEventArgs_0);
		}
	}

	public void method_1(SelectionRendererEventArgs selectionRendererEventArgs_0)
	{
		Class280[] array = method_6();
		Graphics graphics = selectionRendererEventArgs_0.Graphics;
		Rectangle bounds = selectionRendererEventArgs_0.Bounds;
		bounds.Width--;
		bounds.Height--;
		Class280[] array2 = array;
		foreach (Class280 @class in array2)
		{
			@class.Paint(graphics, bounds);
		}
	}

	private void method_2(SelectionRendererEventArgs selectionRendererEventArgs_0)
	{
		Class280[] array = method_3(selectionRendererEventArgs_0.TreeActive);
		Graphics graphics = selectionRendererEventArgs_0.Graphics;
		Rectangle bounds = selectionRendererEventArgs_0.Bounds;
		Class280[] array2 = array;
		foreach (Class280 @class in array2)
		{
			@class.Paint(graphics, bounds);
		}
	}

	private Class280[] method_3(bool bool_0)
	{
		if (class280_0 == null)
		{
			class280_0 = new Class280[1];
			class280_0[0] = new Class281();
		}
		Class281 @class = (Class281)class280_0[0];
		SelectionColorTable selectionColorTable = (bool_0 ? treeSelectionColors_0.FullRowSelect : treeSelectionColors_0.FullRowSelectInactive);
		@class.Fill_0 = selectionColorTable.Fill;
		@class.Border_0 = selectionColorTable.Border;
		return class280_0;
	}

	private void method_4(SelectionRendererEventArgs selectionRendererEventArgs_0)
	{
		Class280[] array = method_5(selectionRendererEventArgs_0.TreeActive);
		Graphics graphics = selectionRendererEventArgs_0.Graphics;
		Rectangle bounds = selectionRendererEventArgs_0.Bounds;
		bounds.Width--;
		bounds.Height--;
		Class280[] array2 = array;
		foreach (Class280 @class in array2)
		{
			@class.Paint(graphics, bounds);
		}
	}

	private Class280[] method_5(bool bool_0)
	{
		if (class280_1 == null)
		{
			class280_1 = new Class280[1];
			Class281 @class = new Class281();
			@class.CornerRadius_0 = new CornerRadius(2);
			Class281 class3 = (Class281)(@class.Class280_0 = new Class281());
			class280_1[0] = @class;
		}
		SelectionColorTable selectionColorTable = (bool_0 ? treeSelectionColors_0.HighlightCells : treeSelectionColors_0.HighlightCellsInactive);
		Class281 class4 = (Class281)class280_1[0];
		class4.Fill_0 = selectionColorTable.Fill;
		class4.Border_0 = selectionColorTable.Border;
		class4 = (Class281)class4.Class280_0;
		class4.Border_0 = selectionColorTable.InnerBorder;
		return class280_1;
	}

	private Class280[] method_6()
	{
		if (class280_2 == null)
		{
			class280_2 = new Class280[1];
			Class281 @class = new Class281();
			@class.CornerRadius_0 = new CornerRadius(2);
			Class281 class3 = (Class281)(@class.Class280_0 = new Class281());
			class280_2[0] = @class;
		}
		SelectionColorTable nodeHotTracking = treeSelectionColors_0.NodeHotTracking;
		Class281 class4 = (Class281)class280_2[0];
		class4.Fill_0 = nodeHotTracking.Fill;
		class4.Border_0 = nodeHotTracking.Border;
		class4 = (Class281)class4.Class280_0;
		class4.Border_0 = nodeHotTracking.InnerBorder;
		return class280_2;
	}

	private void method_7(SelectionRendererEventArgs selectionRendererEventArgs_0)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		Rectangle bounds = selectionRendererEventArgs_0.Bounds;
		bounds.Inflate(1, 1);
		bounds.Width--;
		bounds.Height--;
		Rectangle bounds2 = selectionRendererEventArgs_0.Bounds;
		bounds2.Inflate(4, 4);
		bounds2.Width--;
		bounds2.Height--;
		SelectionColorTable selectionColorTable = (selectionRendererEventArgs_0.TreeActive ? treeSelectionColors_0.NodeMarker : treeSelectionColors_0.NodeMarkerInactive);
		if (selectionColorTable.Border != null)
		{
			Pen val = selectionColorTable.Border.CreatePen();
			if (val != null)
			{
				selectionRendererEventArgs_0.Graphics.DrawRectangle(val, bounds);
				selectionRendererEventArgs_0.Graphics.DrawRectangle(val, bounds2);
				val.Dispose();
			}
		}
		if (selectionColorTable.Fill != null)
		{
			Brush val2 = selectionColorTable.Fill.CreateBrush(bounds2);
			if (val2 != null)
			{
				Region val3 = new Region(bounds2);
				val3.Exclude(bounds);
				selectionRendererEventArgs_0.Graphics.FillRegion(val2, val3);
				val2.Dispose();
			}
		}
	}
}

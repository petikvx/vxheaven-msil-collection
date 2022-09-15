using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Display;

internal class Class12
{
	internal void method_0(ColumnHeaderRendererEventArgs columnHeaderRendererEventArgs_0, ElementStyleDisplayInfo elementStyleDisplayInfo_0)
	{
		ElementStyleDisplay.Paint(elementStyleDisplayInfo_0);
		elementStyleDisplayInfo_0.Bounds.Inflate(-1, -1);
		if (elementStyleDisplayInfo_0.Bounds.Width <= 1 || elementStyleDisplayInfo_0.Bounds.Height <= 1)
		{
			return;
		}
		if (columnHeaderRendererEventArgs_0.ColumnHeader.bool_7)
		{
			Rectangle bounds = elementStyleDisplayInfo_0.Bounds;
			bounds.Width -= 3;
			bounds.X += 3;
			elementStyleDisplayInfo_0.Bounds = bounds;
		}
		if (columnHeaderRendererEventArgs_0.ColumnHeader.Image != null)
		{
			Image image = columnHeaderRendererEventArgs_0.ColumnHeader.Image;
			Rectangle bounds2 = elementStyleDisplayInfo_0.Bounds;
			if (columnHeaderRendererEventArgs_0.ColumnHeader.ImageAlignment == eColumnImageAlignment.Left)
			{
				columnHeaderRendererEventArgs_0.Graphics.DrawImage(image, bounds2.X, bounds2.Y + (bounds2.Height - image.get_Height()) / 2, image.get_Width(), image.get_Height());
				bounds2.X += image.get_Width() + 2;
				bounds2.Width -= image.get_Width() + 2;
			}
			else if (columnHeaderRendererEventArgs_0.ColumnHeader.ImageAlignment == eColumnImageAlignment.Right)
			{
				columnHeaderRendererEventArgs_0.Graphics.DrawImage(image, bounds2.Right - image.get_Width(), bounds2.Y + (bounds2.Height - image.get_Height()) / 2, image.get_Width(), image.get_Height());
				bounds2.Width -= image.get_Width() + 2;
			}
			elementStyleDisplayInfo_0.Bounds = bounds2;
		}
		ElementStyleDisplay.PaintText(elementStyleDisplayInfo_0, columnHeaderRendererEventArgs_0.ColumnHeader.Text, ((Control)columnHeaderRendererEventArgs_0.Tree).get_Font());
	}
}

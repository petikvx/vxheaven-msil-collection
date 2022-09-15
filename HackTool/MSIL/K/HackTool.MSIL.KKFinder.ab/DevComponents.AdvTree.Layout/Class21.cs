using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Layout;

internal class Class21
{
	public static int smethod_0(Class20 class20_0, int int_0, int int_1, int int_2, int int_3)
	{
		ColumnHeaderCollection columnHeaderCollection = null;
		Node node_ = class20_0.node_0;
		columnHeaderCollection = ((node_ != null) ? node_.NodesColumns : class20_0.columnHeaderCollection_0);
		columnHeaderCollection.bool_0 = false;
		int num = 0;
		bool flag = false;
		Rectangle rectangle = Rectangle.Empty;
		ColumnHeader columnHeader = null;
		bool flag2 = true;
		bool bool_ = true;
		foreach (ColumnHeader item in columnHeaderCollection)
		{
			item.bool_6 = false;
			if (!item.Visible)
			{
				continue;
			}
			item.bool_7 = bool_;
			bool_ = false;
			Rectangle empty = Rectangle.Empty;
			empty.X = int_0;
			empty.Y = int_1;
			if (item.Width.Absolute > 0)
			{
				empty.Width = item.Width.Absolute;
				flag2 = false;
			}
			else if (item.Width.Absolute == -1)
			{
				empty.Width = 0;
				flag2 = false;
			}
			else if (item.Width.Relative > 0)
			{
				empty.Width = int_2 * item.Width.Relative / 100 - int_3;
				columnHeaderCollection.bool_0 = true;
			}
			columnHeader = item;
			if (item.StyleNormal == "" && item.StyleMouseDown == "" && item.StyleMouseOver == "")
			{
				empty.Height = class20_0.size_0.Height;
			}
			else
			{
				Size size = Size.Empty;
				if (item.StyleNormal != "")
				{
					Class52.smethod_0(class20_0.elementStyleCollection_0[item.StyleNormal], class20_0.font_0);
					size = class20_0.elementStyleCollection_0[item.StyleNormal].Size;
				}
				if (size.Height == 0)
				{
					empty.Height = class20_0.size_0.Height;
				}
				else
				{
					empty.Height = size.Height;
				}
			}
			if (item.Image != null && item.Image.get_Height() + 4 > empty.Height)
			{
				empty.Height = item.Image.get_Height() + 4;
			}
			item.SetBounds(empty);
			item.SizeChanged = false;
			int_0 += empty.Width + int_3;
			if (empty.Height > num)
			{
				if (num > 0)
				{
					flag = true;
				}
				num = empty.Height;
			}
			else if (empty.Height < num)
			{
				flag = true;
			}
			rectangle = ((!rectangle.IsEmpty) ? Rectangle.Union(rectangle, item.Bounds) : item.Bounds);
		}
		if (flag)
		{
			foreach (ColumnHeader item2 in columnHeaderCollection)
			{
				item2.SetBounds(new Rectangle(item2.Bounds.X, item2.Bounds.Y, item2.Bounds.Width, num));
			}
		}
		if (columnHeader != null && flag2)
		{
			columnHeader.SetBounds(new Rectangle(columnHeader.Bounds.X, columnHeader.Bounds.Y, columnHeader.Bounds.Width + int_3, columnHeader.Bounds.Height));
			rectangle = Rectangle.Union(rectangle, columnHeader.Bounds);
		}
		if (columnHeader != null)
		{
			columnHeader.bool_6 = true;
		}
		columnHeaderCollection.method_8(rectangle);
		return num;
	}
}

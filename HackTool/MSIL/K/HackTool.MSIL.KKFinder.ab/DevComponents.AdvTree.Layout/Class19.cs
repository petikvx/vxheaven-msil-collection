using System;
using System.Drawing;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.AdvTree.Layout;

internal class Class19
{
	private Size size_0 = new Size(12, 12);

	private Class3 class3_0;

	internal Size Size_0
	{
		get
		{
			return size_0;
		}
		set
		{
			size_0 = value;
		}
	}

	private int Int32_0 => 4;

	private int Int32_1 => 4;

	public int Int32_2 => 5;

	public int Int32_3 => 1;

	public int Int32_4 => 1;

	public void method_0(Cell cell_0, int int_0, int int_1)
	{
		cell_0.SetBounds(new Rectangle(cell_0.BoundsRelative.X + int_0, cell_0.BoundsRelative.Y + int_1, cell_0.BoundsRelative.Width, cell_0.BoundsRelative.Height));
		if (!cell_0.CheckBoxBoundsRelative.IsEmpty)
		{
			cell_0.SetCheckBoxBounds(new Rectangle(cell_0.CheckBoxBoundsRelative.X + int_0, cell_0.CheckBoxBoundsRelative.Y + int_1, cell_0.CheckBoxBoundsRelative.Width, cell_0.CheckBoxBoundsRelative.Height));
		}
		if (!cell_0.ImageBoundsRelative.IsEmpty)
		{
			cell_0.SetImageBounds(new Rectangle(cell_0.ImageBoundsRelative.X + int_0, cell_0.ImageBoundsRelative.Y + int_1, cell_0.ImageBoundsRelative.Width, cell_0.ImageBoundsRelative.Height));
		}
		if (!cell_0.TextContentBounds.IsEmpty)
		{
			cell_0.TextContentBounds = new Rectangle(cell_0.TextContentBounds.X + int_0, cell_0.TextContentBounds.Y + int_1, cell_0.TextContentBounds.Width, cell_0.TextContentBounds.Height);
		}
	}

	public void method_1(Class3 class3_1)
	{
		Size size = Size.Empty;
		Font val = class3_1.font_0;
		int num = 0;
		if (class3_1.elementStyle_0.Font != null)
		{
			val = class3_1.elementStyle_0.Font;
		}
		class3_1.cell_0.OnLayoutCell();
		if (class3_1.cell_0.Images.Size_0.IsEmpty && class3_1.cell_0.Images.ImageIndex >= 0)
		{
			class3_1.cell_0.Images.method_2();
		}
		if (class3_1.cell_0.HostedControl != null)
		{
			Size size2 = class3_1.cell_0.HostedControl.get_Size();
			if (!class3_1.cell_0.HostedControlSize.IsEmpty)
			{
				size2 = class3_1.cell_0.HostedControlSize;
			}
			if (class3_1.int_0 == 0)
			{
				size = new Size(size2.Width, size2.Height);
			}
			else
			{
				int width = class3_1.int_0 - Class52.smethod_1(class3_1.elementStyle_0);
				size = new Size(width, size2.Height);
			}
		}
		else if (class3_1.int_0 == 0)
		{
			if (class3_1.cell_0.TextMarkupBody == null)
			{
				string text = class3_1.cell_0.Text;
				if (text != "")
				{
					size = ((class3_1.elementStyle_0.WordWrap && class3_1.elementStyle_0.MaximumWidth > 0) ? Class55.smethod_5(class3_1.graphics_0, text, val, class3_1.elementStyle_0.MaximumWidth) : ((class3_1.cell_0.Parent == null || class3_1.cell_0.Parent.Style == null || !class3_1.cell_0.Parent.Style.WordWrap || class3_1.cell_0.Parent.Style.MaximumWidth <= 0) ? Class55.smethod_3(class3_1.graphics_0, text, val) : Class55.smethod_5(class3_1.graphics_0, text, val, class3_1.cell_0.Parent.Style.MaximumWidth)));
				}
				else if (class3_1.cell_0.Images.Size_0.IsEmpty && !class3_1.cell_0.CheckBoxVisible)
				{
					size = new Size(5, val.get_Height());
				}
			}
			else
			{
				Size availableSize = new Size(1600, 1);
				if (class3_1.elementStyle_0.WordWrap && class3_1.elementStyle_0.MaximumWidth > 0)
				{
					availableSize.Width = class3_1.elementStyle_0.MaximumWidth;
				}
				else if (class3_1.cell_0.Parent != null && class3_1.cell_0.Parent.Style != null && class3_1.cell_0.Parent.Style.WordWrap && class3_1.cell_0.Parent.Style.MaximumWidth > 0)
				{
					availableSize.Width = class3_1.cell_0.Parent.Style.MaximumWidth;
				}
				Class263 @class = new Class263(class3_1.graphics_0, val, Color.Empty, rightToLeft: false);
				class3_1.cell_0.TextMarkupBody.Measure(availableSize, @class);
				availableSize = class3_1.cell_0.TextMarkupBody.Bounds.Size;
				@class.bool_0 = !class3_1.bool_0;
				class3_1.cell_0.TextMarkupBody.method_2(new Rectangle(0, 0, availableSize.Width, availableSize.Height), @class);
				size = class3_1.cell_0.TextMarkupBody.Bounds.Size;
			}
		}
		else
		{
			int num2 = class3_1.int_0 - Class52.smethod_1(class3_1.elementStyle_0);
			num2 -= class3_1.cell_0.Images.Size_0.Width + ((class3_1.cell_0.Images.Size_0.Width > 0) ? (Int32_1 * 2) : 0);
			if (class3_1.cell_0.CheckBoxVisible)
			{
				num2 -= Size_0.Width + Int32_1 * 2;
			}
			int height = val.get_Height();
			if (!class3_1.elementStyle_0.WordWrap && class3_1.cell_0.TextMarkupBody == null)
			{
				size = new Size(num2, height);
			}
			else
			{
				height = class3_1.elementStyle_0.MaximumHeight - class3_1.elementStyle_0.MarginTop - class3_1.elementStyle_0.MarginBottom - class3_1.elementStyle_0.PaddingTop - class3_1.elementStyle_0.PaddingBottom;
				if (class3_1.cell_0.TextMarkupBody == null)
				{
					if (num2 > 0)
					{
						size = ((height <= 0) ? Class55.smethod_4(class3_1.graphics_0, class3_1.cell_0.Text, val, num2, class3_1.elementStyle_0.ETextFormat_0) : Class55.smethod_6(class3_1.graphics_0, class3_1.cell_0.Text, val, new Size(num2, height), class3_1.elementStyle_0.ETextFormat_0));
					}
				}
				else
				{
					Size availableSize2 = new Size(num2, 1);
					Class263 class2 = new Class263(class3_1.graphics_0, val, Color.Empty, rightToLeft: false);
					class3_1.cell_0.TextMarkupBody.Measure(availableSize2, class2);
					availableSize2 = class3_1.cell_0.TextMarkupBody.Bounds.Size;
					availableSize2.Width = num2;
					class2.bool_0 = !class3_1.bool_0;
					class3_1.cell_0.TextMarkupBody.method_2(new Rectangle(0, 0, availableSize2.Width, availableSize2.Height), class2);
					size = class3_1.cell_0.TextMarkupBody.Bounds.Size;
				}
			}
		}
		if (class3_1.elementStyle_0.WordWrap)
		{
			class3_1.cell_0.WordWrap = true;
		}
		else
		{
			class3_1.cell_0.WordWrap = false;
		}
		num = (int)Math.Max(num, Math.Ceiling((double)size.Height));
		if (class3_1.bool_1)
		{
			if (class3_1.cell_0.Images.Size_0.Height > 0)
			{
				num += class3_1.cell_0.Images.Size_0.Height + Int32_1;
			}
			if (class3_1.cell_0.CheckBoxVisible)
			{
				num += Size_0.Height + Int32_0;
			}
		}
		else
		{
			if (class3_1.cell_0.Images.Size_0.Height > num)
			{
				num = class3_1.cell_0.Images.Size_0.Height;
			}
			if (class3_1.cell_0.CheckBoxVisible && Size_0.Height > num)
			{
				num = Size_0.Height;
			}
		}
		Rectangle rectangle_ = new Rectangle(class3_1.int_2 + Class52.smethod_3(class3_1.elementStyle_0), class3_1.int_3 + Class52.smethod_7(class3_1.elementStyle_0), class3_1.int_0, num);
		if (rectangle_.Width == 0)
		{
			if (class3_1.bool_1)
			{
				rectangle_.Width = (int)Math.Ceiling((double)size.Width);
				if (class3_1.cell_0.Images.Size_0.Width > rectangle_.Width)
				{
					rectangle_.Width = class3_1.cell_0.Images.Size_0.Width + Int32_1;
				}
				if (class3_1.cell_0.CheckBoxVisible && Size_0.Width > rectangle_.Width)
				{
					rectangle_.Width += Size_0.Width + Int32_1;
				}
			}
			else
			{
				rectangle_.Width = (int)Math.Ceiling((double)size.Width);
				if (class3_1.cell_0.Images.Size_0.Width > 0)
				{
					rectangle_.Width += class3_1.cell_0.Images.Size_0.Width + Int32_1;
				}
				if (class3_1.cell_0.CheckBoxVisible)
				{
					rectangle_.Width += Size_0.Width + Int32_1;
				}
			}
		}
		Rectangle bounds = new Rectangle(class3_1.int_2, class3_1.int_3, class3_1.int_0, rectangle_.Height + class3_1.elementStyle_0.MarginTop + class3_1.elementStyle_0.MarginBottom + class3_1.elementStyle_0.PaddingTop + class3_1.elementStyle_0.PaddingBottom);
		if (bounds.Width == 0)
		{
			bounds.Width = rectangle_.Width + Class52.smethod_1(class3_1.elementStyle_0);
		}
		class3_1.cell_0.SetBounds(bounds);
		if (class3_1.cell_0.CheckBoxVisible && bounds.Width >= Size_0.Width)
		{
			Enum2 enum2_ = method_5(class3_1.cell_0.CheckBoxAlignment);
			Enum3 enum3_ = method_4(class3_1.cell_0.CheckBoxAlignment, class3_1.bool_0);
			if (class3_1.bool_1)
			{
				class3_1.cell_0.SetCheckBoxBounds(method_3(Size_0, ref rectangle_, enum3_, enum2_, Int32_1));
			}
			else
			{
				class3_1.cell_0.SetCheckBoxBounds(method_2(Size_0, ref rectangle_, enum3_, enum2_, Int32_1));
			}
		}
		else
		{
			class3_1.cell_0.SetCheckBoxBounds(Rectangle.Empty);
		}
		if (!class3_1.cell_0.Images.Size_0.IsEmpty && bounds.Width >= class3_1.cell_0.Images.Size_0.Width)
		{
			Enum2 enum2_2 = method_5(class3_1.cell_0.ImageAlignment);
			Enum3 enum3_2 = method_4(class3_1.cell_0.ImageAlignment, class3_1.bool_0);
			if (class3_1.bool_1)
			{
				class3_1.cell_0.SetImageBounds(method_3(class3_1.cell_0.Images.Size_0, ref rectangle_, enum3_2, enum2_2, Int32_1));
			}
			else
			{
				class3_1.cell_0.SetImageBounds(method_2(class3_1.cell_0.Images.Size_0, ref rectangle_, enum3_2, enum2_2, Int32_1));
			}
		}
		else
		{
			class3_1.cell_0.SetImageBounds(Rectangle.Empty);
		}
		if (!size.IsEmpty)
		{
			if (class3_1.int_0 > 0)
			{
				rectangle_.Width -= 2;
			}
			class3_1.cell_0.TextContentBounds = rectangle_;
		}
		else
		{
			class3_1.cell_0.TextContentBounds = Rectangle.Empty;
		}
	}

	private Rectangle method_2(Size size_1, ref Rectangle rectangle_0, Enum3 enum3_0, Enum2 enum2_0, int int_0)
	{
		Rectangle result = new Rectangle(Point.Empty, size_1);
		if (enum3_0 == Enum3.const_2)
		{
			result.X = rectangle_0.Right - result.Width;
			rectangle_0.Width -= result.Width + int_0;
		}
		else
		{
			result.X = rectangle_0.X;
			rectangle_0.X = result.Right + int_0;
			rectangle_0.Width -= result.Width + int_0;
		}
		switch (enum2_0)
		{
		case Enum2.const_0:
			result.Y = rectangle_0.Y;
			break;
		case Enum2.const_1:
			result.Y = rectangle_0.Y + (rectangle_0.Height - result.Height) / 2;
			break;
		case Enum2.const_2:
			result.Y = rectangle_0.Bottom - result.Height;
			break;
		}
		return result;
	}

	private Rectangle method_3(Size size_1, ref Rectangle rectangle_0, Enum3 enum3_0, Enum2 enum2_0, int int_0)
	{
		Rectangle result = new Rectangle(Point.Empty, size_1);
		switch (enum3_0)
		{
		case Enum3.const_0:
			result.X = rectangle_0.X;
			break;
		case Enum3.const_1:
			result.X = rectangle_0.X + (rectangle_0.Width - result.Width) / 2;
			break;
		case Enum3.const_2:
			result.X = rectangle_0.Right - result.Width;
			break;
		}
		if (enum2_0 == Enum2.const_2)
		{
			result.Y = rectangle_0.Bottom - result.Height;
			rectangle_0.Height -= result.Height + int_0;
		}
		else
		{
			result.Y = rectangle_0.Y;
			rectangle_0.Y = result.Bottom + int_0;
			rectangle_0.Height -= result.Height + int_0;
		}
		return result;
	}

	private Enum3 method_4(eCellPartAlignment eCellPartAlignment_0, bool bool_0)
	{
		if (((eCellPartAlignment_0 != eCellPartAlignment.NearBottom && eCellPartAlignment_0 != 0 && eCellPartAlignment_0 != eCellPartAlignment.NearTop) || !bool_0) && ((eCellPartAlignment_0 != eCellPartAlignment.FarBottom && eCellPartAlignment_0 != eCellPartAlignment.FarCenter && eCellPartAlignment_0 != eCellPartAlignment.FarTop) || bool_0))
		{
			if (eCellPartAlignment_0 != eCellPartAlignment.CenterBottom && eCellPartAlignment_0 != eCellPartAlignment.CenterTop)
			{
				return Enum3.const_2;
			}
			return Enum3.const_1;
		}
		return Enum3.const_0;
	}

	private Enum2 method_5(eCellPartAlignment eCellPartAlignment_0)
	{
		Enum2 result = Enum2.const_1;
		switch (eCellPartAlignment_0)
		{
		case eCellPartAlignment.NearTop:
		case eCellPartAlignment.CenterTop:
		case eCellPartAlignment.FarTop:
			result = Enum2.const_0;
			break;
		case eCellPartAlignment.NearBottom:
		case eCellPartAlignment.CenterBottom:
		case eCellPartAlignment.FarBottom:
			result = Enum2.const_2;
			break;
		}
		return result;
	}

	internal void ResetCheckBoxSize()
	{
		size_0 = new Size(12, 12);
	}

	public Size method_6(Class20 class20_0, int int_0, int int_1)
	{
		eCellLayout eCellLayout = class20_0.eCellLayout_0;
		if (class20_0.node_0.CellLayout != class20_0.eCellLayout_0 && class20_0.node_0.CellLayout != 0)
		{
			eCellLayout = class20_0.node_0.CellLayout;
		}
		if (eCellLayout != eCellLayout.Horizontal && eCellLayout != 0)
		{
			return method_8(class20_0, int_0, int_1);
		}
		return method_7(class20_0, int_0, int_1);
	}

	private Size method_7(Class20 class20_0, int int_0, int int_1)
	{
		Node node_ = class20_0.node_0;
		int num = 0;
		int num2 = 0;
		bool flag = false;
		for (int i = 0; i < node_.Cells.Count; i++)
		{
			Cell cell = node_.Cells[i];
			bool flag2 = true;
			Class3 @class = method_9();
			@class.int_3 = int_1;
			@class.int_2 = int_0;
			@class.int_0 = 0;
			@class.int_1 = 0;
			@class.cell_0 = cell;
			@class.graphics_0 = class20_0.graphics_0;
			@class.bool_0 = class20_0.bool_0;
			@class.font_0 = class20_0.font_0;
			if (cell.Layout != 0)
			{
				@class.bool_1 = cell.Layout == eCellPartLayout.Vertical;
			}
			else if (class20_0.eCellPartLayout_0 != 0)
			{
				@class.bool_1 = class20_0.eCellPartLayout_0 == eCellPartLayout.Vertical;
			}
			Class14 class2 = null;
			if ((class20_0.arrayList_0.Count > 0 || (class20_0.arrayList_1 != null && class20_0.arrayList_1.Count > 0)) && (node_.Cells.Count > 1 || node_.Cells.Count == class20_0.arrayList_0.Count || (class20_0.arrayList_1 != null && class20_0.arrayList_1.Count == node_.Cells.Count)))
			{
				bool flag3 = false;
				if (class20_0.arrayList_1 != null && class20_0.arrayList_1.Count > 0 && i < class20_0.arrayList_1.Count)
				{
					class2 = class20_0.arrayList_1[i] as Class14;
				}
				else if (i < class20_0.arrayList_0.Count)
				{
					class2 = class20_0.arrayList_0[i] as Class14;
					flag3 = true;
				}
				if (class2 != null)
				{
					flag2 = class2.bool_0;
					@class.int_0 = class2.int_0;
					if (i == 0 && flag3 && @class.int_0 > 0)
					{
						@class.int_0 = Math.Max(-1, @class.int_0 - (class20_0.int_0 + int_0));
					}
				}
			}
			if (cell.StyleNormal != null)
			{
				@class.elementStyle_0 = cell.StyleNormal;
			}
			else if (class20_0.node_0.Style != null)
			{
				ElementStyle elementStyle = class20_0.elementStyle_0.Copy();
				elementStyle.ApplyStyle(class20_0.node_0.Style);
				@class.elementStyle_0 = elementStyle;
			}
			else
			{
				@class.elementStyle_0 = class20_0.elementStyle_0;
			}
			method_1(@class);
			cell.SetVisible(flag2);
			if (!flag2)
			{
				continue;
			}
			int_0 += cell.BoundsRelative.Width;
			num2 += cell.BoundsRelative.Width;
			if (cell.BoundsRelative.Width > 0)
			{
				int_0 += Int32_2;
				num2 += Int32_2;
			}
			if (cell.BoundsRelative.Height > num)
			{
				if (num != 0)
				{
					flag = true;
				}
				num = cell.BoundsRelative.Height;
			}
			else if (i > 0 && cell.BoundsRelative.Height < num && !cell.TextContentBounds.IsEmpty)
			{
				flag = true;
			}
			if (class2 != null)
			{
				class2.int_1 = Math.Max(class2.int_1, cell.BoundsRelative.Width);
			}
		}
		if (flag)
		{
			for (int j = 0; j < node_.Cells.Count; j++)
			{
				Cell cell2 = node_.Cells[j];
				if (cell2.BoundsRelative.Height == num || cell2.TextContentBounds.IsEmpty)
				{
					continue;
				}
				cell2.TextContentBounds = new Rectangle(cell2.TextContentBounds.X, cell2.TextContentBounds.Y, cell2.TextContentBounds.Width, cell2.TextContentBounds.Height + (num - cell2.BoundsRelative.Height));
				int num3 = num - cell2.BoundsRelative.Height;
				if (!cell2.CheckBoxBoundsRelative.IsEmpty)
				{
					Enum2 @enum = method_5(cell2.CheckBoxAlignment);
					if (@enum == Enum2.const_1)
					{
						cell2.SetCheckBoxBounds(new Rectangle(cell2.CheckBoxBoundsRelative.X, cell2.CheckBoxBoundsRelative.Y + (int)Math.Ceiling((double)num3 / 2.0), cell2.CheckBoxBoundsRelative.Width, cell2.CheckBoxBoundsRelative.Height));
					}
					if (@enum == Enum2.const_2)
					{
						cell2.SetCheckBoxBounds(new Rectangle(cell2.CheckBoxBoundsRelative.X, cell2.CheckBoxBoundsRelative.Y + num3, cell2.CheckBoxBoundsRelative.Width, cell2.CheckBoxBoundsRelative.Height));
					}
				}
				cell2.SetBounds(new Rectangle(cell2.BoundsRelative.X, cell2.BoundsRelative.Y, cell2.BoundsRelative.Width, num));
			}
		}
		int_0 -= Int32_2;
		num2 -= Int32_2;
		return new Size(num2, num);
	}

	private Size method_8(Class20 class20_0, int int_0, int int_1)
	{
		Node node_ = class20_0.node_0;
		int num = 0;
		int num2 = 0;
		Enum3 @enum = Enum3.const_1;
		int num3 = 0;
		for (int i = 0; i < node_.Cells.Count; i++)
		{
			Cell cell = node_.Cells[i];
			bool flag = true;
			Class3 @class = method_9();
			@class.int_3 = int_1;
			@class.int_2 = int_0;
			@class.int_0 = 0;
			@class.cell_0 = cell;
			@class.graphics_0 = class20_0.graphics_0;
			@class.bool_0 = class20_0.bool_0;
			@class.font_0 = class20_0.font_0;
			if (cell.Layout != 0)
			{
				@class.bool_1 = cell.Layout == eCellPartLayout.Vertical;
			}
			else if (class20_0.eCellPartLayout_0 != 0)
			{
				@class.bool_1 = class20_0.eCellPartLayout_0 == eCellPartLayout.Vertical;
			}
			if (class20_0.arrayList_0.Count > 0 || (class20_0.arrayList_1 != null && class20_0.arrayList_1.Count > 0))
			{
				Class14 class2 = null;
				class2 = ((class20_0.arrayList_1 == null || class20_0.arrayList_1.Count <= 0) ? (class20_0.arrayList_0[i] as Class14) : (class20_0.arrayList_1[i] as Class14));
				flag = class2.bool_0;
				@class.int_0 = class2.int_0;
			}
			if (cell.StyleNormal != null)
			{
				@class.elementStyle_0 = cell.StyleNormal;
			}
			else
			{
				@class.elementStyle_0 = class20_0.elementStyle_0;
			}
			method_1(@class);
			cell.SetVisible(flag);
			if (flag)
			{
				num3++;
				int_1 += cell.BoundsRelative.Height;
				num += cell.BoundsRelative.Height;
				if (cell.BoundsRelative.Height > 0)
				{
					int_1 += Int32_3;
					num += Int32_3;
				}
				if (cell.BoundsRelative.Width > num2)
				{
					num2 = cell.BoundsRelative.Width;
				}
			}
		}
		int_1 -= Int32_3;
		num -= Int32_3;
		if (@enum != 0 && num3 > 1)
		{
			foreach (Cell cell2 in node_.Cells)
			{
				if (cell2.IsVisible)
				{
					if (@enum == Enum3.const_1)
					{
						method_0(cell2, (num2 - cell2.BoundsRelative.Width) / 2, 0);
					}
					else
					{
						method_0(cell2, num2 - cell2.BoundsRelative.Width, 0);
					}
				}
			}
		}
		return new Size(num2, num);
	}

	private Class3 method_9()
	{
		if (class3_0 == null)
		{
			class3_0 = new Class3();
		}
		return class3_0;
	}
}

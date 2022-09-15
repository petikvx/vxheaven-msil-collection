using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

public class TabItemLayoutManager : BlockLayoutManager
{
	private int int_0 = 4;

	private int int_1 = 2;

	private int int_2 = 4;

	private int int_3;

	private bool bool_0;

	private int int_4;

	private Size size_0 = Size.Empty;

	private bool bool_1;

	private Size size_1 = new Size(11, 11);

	private int int_5 = 3;

	private TabStrip tabStrip_0;

	public int TextPadding
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public int ImagePadding
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	public int PaddingHeight
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	public int PaddingWidth
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
		}
	}

	public bool HorizontalText
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public int SelectedPaddingWidth
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
		}
	}

	public Size FixedTabSize
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

	public bool CloseButtonOnTabs
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public Size CloseButtonSize
	{
		get
		{
			return size_1;
		}
		set
		{
			size_1 = value;
		}
	}

	public TabItemLayoutManager()
	{
	}

	public TabItemLayoutManager(TabStrip tabStrip)
	{
		tabStrip_0 = tabStrip;
	}

	public override void Layout(IBlock block, Size availableSize)
	{
		if (base.Graphics == null)
		{
			throw new InvalidOperationException("Graphics property must be set to valid instance of Graphics object.");
		}
		TabItem tabItem = block as TabItem;
		if (!tabItem.Visible)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		bool flag = tabItem.Parent != null && (tabItem.Parent.TabAlignment == eTabStripAlignment.Left || tabItem.Parent.TabAlignment == eTabStripAlignment.Right) && !bool_0;
		eTabStripStyle style = tabItem.Parent.Style;
		eTextFormat eTextFormat_ = eTextFormat.Default;
		Image image = tabItem.GetImage();
		if (tabItem.Icon != null)
		{
			num += tabItem.IconSize.Width;
			if (style != eTabStripStyle.OneNote && style != eTabStripStyle.Office2007Document)
			{
				num += int_1;
			}
			num2 = tabItem.IconSize.Height + int_2;
		}
		else if (image != null)
		{
			num += image.get_Width();
			if (style != eTabStripStyle.OneNote && style != eTabStripStyle.Office2007Document)
			{
				num += int_1;
			}
			num2 = image.get_Height() + int_2;
		}
		if (!tabItem.Parent.DisplaySelectedTextOnly || tabItem == tabItem.Parent.SelectedTab)
		{
			string text = tabItem.Text;
			if (text == "")
			{
				text = "M";
			}
			Font font_ = ((Control)tabItem.Parent).get_Font();
			if (tabItem.Parent.SelectedTabFont != null && (tabItem == tabItem.Parent.SelectedTab || ((tabItem.Parent.TabAlignment == eTabStripAlignment.Left || tabItem.Parent.TabAlignment == eTabStripAlignment.Right) && bool_0)))
			{
				font_ = tabItem.Parent.SelectedTabFont;
			}
			Size empty = Size.Empty;
			empty = ((!flag) ? Class55.smethod_4(base.Graphics, text, font_, 0, eTextFormat_) : Class55.smethod_7(base.Graphics, text, font_, Size.Empty, eTextFormat_));
			num += empty.Width;
			if (style != eTabStripStyle.OneNote)
			{
				num += int_0;
			}
			if (empty.Height > num2)
			{
				num2 = empty.Height + int_2;
			}
		}
		if (bool_1 && tabItem.CloseButtonVisible)
		{
			num += size_1.Width + int_5 * 2;
		}
		num += int_3;
		if (tabItem.IsSelected)
		{
			num += int_4;
		}
		if (size_0.Width > 0)
		{
			num = size_0.Width;
		}
		if (size_0.Height > 0)
		{
			num2 = size_0.Height;
		}
		if (style == eTabStripStyle.OneNote || style == eTabStripStyle.Office2007Document)
		{
			num += (int)((double)num2 * 0.5) - 4;
		}
		Rectangle bounds = new Rectangle(0, 0, num, num2);
		if (flag)
		{
			bounds = new Rectangle(0, 0, num2, num);
		}
		if (tabStrip_0 != null && tabStrip_0.Boolean_3)
		{
			MeasureTabItemEventArgs measureTabItemEventArgs = new MeasureTabItemEventArgs(tabItem, bounds.Size);
			tabStrip_0.method_18(measureTabItemEventArgs);
			bounds.Size = measureTabItemEventArgs.Size;
		}
		block.Bounds = bounds;
	}
}

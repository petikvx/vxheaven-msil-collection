using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public class CrumbBarOverflowButton : ButtonItem
{
	public CrumbBarOverflowButton()
		: this("", "")
	{
	}

	public CrumbBarOverflowButton(string sItemName)
		: this(sItemName, "")
	{
	}

	public CrumbBarOverflowButton(string itemName, string itemText)
		: base(itemName, itemText)
	{
		AutoExpandOnClick = true;
		ShowSubItems = false;
	}

	protected override void RenderButton(ItemPaintArgs p)
	{
		if (!p.IsOnMenu)
		{
			BaseRenderer baseRenderer_ = p.BaseRenderer_0;
			if (baseRenderer_ != null)
			{
				p.ButtonItemRendererEventArgs.Graphics = p.Graphics;
				p.ButtonItemRendererEventArgs.ButtonItem = this;
				p.ButtonItemRendererEventArgs.itemPaintArgs_0 = p;
				baseRenderer_.DrawCrumbBarOverflowItem(p.ButtonItemRendererEventArgs);
				return;
			}
		}
		base.RenderButton(p);
	}

	public override void RecalcSize()
	{
		m_Rect.Width = 16;
		m_Rect.Height = 11;
		m_NeedRecalcSize = false;
	}

	public override void InternalMouseEnter()
	{
		if (Parent is Class180 @class && @class.Expanded)
		{
			@class.Expanded = false;
			Expanded = true;
		}
		base.InternalMouseEnter();
	}

	public override BaseItem Copy()
	{
		CrumbBarOverflowButton crumbBarOverflowButton = new CrumbBarOverflowButton();
		CopyToItem(crumbBarOverflowButton);
		return crumbBarOverflowButton;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		CrumbBarOverflowButton copy2 = copy as CrumbBarOverflowButton;
		base.CopyToItem((BaseItem)copy2);
	}
}

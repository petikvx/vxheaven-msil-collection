using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public class QatOverflowItem : DisplayMoreItem
{
	public QatOverflowItem()
	{
		KeyTips = "00";
	}

	public override BaseItem Copy()
	{
		QatOverflowItem qatOverflowItem = new QatOverflowItem();
		CopyToItem(qatOverflowItem);
		return qatOverflowItem;
	}

	public override void Paint(ItemPaintArgs p)
	{
		BaseRenderer baseRenderer_ = p.BaseRenderer_0;
		if (baseRenderer_ != null)
		{
			baseRenderer_.DrawQatOverflowItem(new QatOverflowItemRendererEventArgs(this, p.Graphics));
			return;
		}
		Class230 @class = Class274.smethod_14(this);
		if (@class != null)
		{
			@class.Paint(new QatOverflowItemRendererEventArgs(this, p.Graphics));
		}
		else
		{
			base.Paint(p);
		}
	}

	protected override int GetReInsertIndex()
	{
		int num = m_Parent.SubItems.Count;
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			if (!(m_Parent.SubItems[num2] is CustomizeItem) && m_Parent.SubItems[num2].ItemAlignment != eItemAlignment.Far)
			{
				if (m_Parent.SubItems[num2].ItemAlignment == eItemAlignment.Near)
				{
					break;
				}
			}
			else
			{
				num = num2;
			}
		}
		return num;
	}
}

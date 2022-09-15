using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class180 : ImageItem
{
	private int int_4;

	private bool bool_22;

	internal int Int32_1 => int_4;

	internal LabelItem LabelItem_0 => m_SubItems[0] as LabelItem;

	internal CrumbBarOverflowButton CrumbBarOverflowButton_0 => (CrumbBarOverflowButton)m_SubItems[1];

	[DefaultValue(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool Expanded
	{
		get
		{
			return m_Expanded;
		}
		set
		{
			base.Expanded = value;
			if (!value)
			{
				BaseItem.CollapseSubItems(this);
			}
		}
	}

	public Class180()
	{
		LabelItem item = new LabelItem("sys_crumbbarimagelabel");
		SubItems.Add(item);
		CrumbBarOverflowButton item2 = new CrumbBarOverflowButton("sys_crumbbaroverflowbutton");
		SubItems.Add(item2);
		m_IsContainer = true;
	}

	public override void RecalcSize()
	{
		if (bool_22)
		{
			return;
		}
		_ = m_Rect.Location;
		Size size = m_Rect.Size;
		int_4 = 0;
		if (m_SubItems == null)
		{
			return;
		}
		method_17();
		ButtonItem crumbBarOverflowButton_ = CrumbBarOverflowButton_0;
		LabelItem labelItem_ = LabelItem_0;
		crumbBarOverflowButton_.Visible = false;
		Rectangle rect = m_Rect;
		if (labelItem_.Visible)
		{
			labelItem_.RecalcSize();
			if (labelItem_.HeightInternal > int_4)
			{
				int_4 = labelItem_.HeightInternal;
			}
			labelItem_.HeightInternal = size.Height;
			rect.X += labelItem_.WidthInternal;
			rect.Width -= labelItem_.WidthInternal;
			labelItem_.Displayed = true;
		}
		Point location = rect.Location;
		bool flag = false;
		BaseItem[] array = new BaseItem[m_SubItems.Count - 2];
		if (m_SubItems.Count > 2)
		{
			m_SubItems.method_5(array, 2);
		}
		for (int num = array.Length - 1; num >= 0; num--)
		{
			BaseItem baseItem = array[num];
			if (!baseItem.Visible)
			{
				baseItem.Displayed = false;
			}
			else
			{
				if (!flag)
				{
					baseItem.LeftInternal = location.X;
					baseItem.TopInternal = location.Y;
					baseItem.HeightInternal = rect.Height;
					baseItem.RecalcSize();
					if (baseItem.HeightInternal > int_4)
					{
						int_4 = baseItem.HeightInternal;
					}
					baseItem.HeightInternal = rect.Height;
					if (location.X + baseItem.WidthInternal <= rect.Right && (location.X + baseItem.WidthInternal + 16 <= rect.Right || num <= 0))
					{
						location.X += baseItem.WidthInternal;
						baseItem.Displayed = true;
					}
					else
					{
						flag = true;
					}
				}
				if (flag)
				{
					bool_22 = true;
					m_SubItems.Remove(baseItem);
					crumbBarOverflowButton_.SubItems.Insert(0, baseItem);
					bool_22 = false;
				}
			}
		}
		if (flag)
		{
			crumbBarOverflowButton_.Visible = true;
			crumbBarOverflowButton_.Displayed = true;
			crumbBarOverflowButton_.HeightInternal = rect.Height;
			crumbBarOverflowButton_.RecalcSize();
			crumbBarOverflowButton_.LeftInternal = rect.X;
			crumbBarOverflowButton_.TopInternal = rect.Y;
			crumbBarOverflowButton_.HeightInternal = rect.Height;
			rect.X += crumbBarOverflowButton_.WidthInternal;
			rect.Width -= crumbBarOverflowButton_.WidthInternal;
		}
		location = rect.Location;
		for (int i = 2; i < m_SubItems.Count; i++)
		{
			BaseItem baseItem2 = m_SubItems[i];
			if (baseItem2.Visible)
			{
				if (baseItem2.WidthInternal + location.X > rect.Right)
				{
					baseItem2.Displayed = false;
					location.X = rect.Right;
				}
				else
				{
					baseItem2.LeftInternal = location.X;
					location.X += baseItem2.WidthInternal;
				}
			}
		}
		base.RecalcSize();
	}

	internal void method_17()
	{
		ButtonItem crumbBarOverflowButton_ = CrumbBarOverflowButton_0;
		if (crumbBarOverflowButton_.SubItems.Count != 0)
		{
			BaseItem[] array = new BaseItem[crumbBarOverflowButton_.SubItems.Count];
			crumbBarOverflowButton_.SubItems.CopyTo(array, 0);
			crumbBarOverflowButton_.SubItems.Clear();
			for (int i = 0; i < array.Length; i++)
			{
				m_SubItems.Insert(i + 2, array[i]);
			}
		}
	}

	internal void method_18()
	{
		bool_22 = true;
		while (m_SubItems.Count > 2)
		{
			m_SubItems.RemoveAt(m_SubItems.Count - 1);
		}
		bool_22 = false;
	}

	public override void Paint(ItemPaintArgs pa)
	{
		if (SuspendLayout)
		{
			return;
		}
		if (m_NeedRecalcSize)
		{
			RecalcSize();
		}
		if (m_SubItems == null)
		{
			return;
		}
		foreach (BaseItem subItem in m_SubItems)
		{
			if (subItem.Visible && subItem.Displayed)
			{
				subItem.Paint(pa);
			}
		}
	}

	public override BaseItem Copy()
	{
		Class180 @class = new Class180();
		CopyToItem(@class);
		return @class;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		Class180 objCopy = copy as Class180;
		base.CopyToItem(objCopy);
	}

	protected internal override void OnSubItemExpandChange(BaseItem item)
	{
		base.OnSubItemExpandChange(item);
		if (item.Expanded)
		{
			Expanded = true;
		}
		else
		{
			base.Expanded = false;
		}
	}
}

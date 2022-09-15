using System.Collections;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

public class BubbleBarTabCollection : CollectionBase
{
	private BubbleBar bubbleBar_0;

	public BubbleBarTab this[int index]
	{
		get
		{
			return (BubbleBarTab)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public BubbleBarTabCollection(BubbleBar owner)
	{
		bubbleBar_0 = owner;
	}

	public int Add(BubbleBarTab tab)
	{
		return base.List.Add(tab);
	}

	public void Insert(int index, BubbleBarTab value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(BubbleBarTab value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(BubbleBarTab value)
	{
		return base.List.Contains(value);
	}

	public void Remove(BubbleBarTab value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		BubbleBarTab bubbleBarTab = value as BubbleBarTab;
		bubbleBar_0.method_34(bubbleBarTab);
		bubbleBarTab.SetParent(null);
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		BubbleBarTab bubbleBarTab = value as BubbleBarTab;
		bubbleBarTab.SetParent(bubbleBar_0);
		bubbleBar_0.method_35(bubbleBarTab);
	}

	public void CopyTo(BubbleBarTab[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(IBlock[] iblock_0)
	{
		base.List.CopyTo(iblock_0, 0);
	}

	internal void method_1(ISimpleTab[] isimpleTab_0)
	{
		base.List.CopyTo(isimpleTab_0, 0);
	}

	protected override void OnClear()
	{
		bubbleBar_0.method_36();
		base.OnClear();
	}

	internal BubbleBarTab method_2(BubbleBarTab bubbleBarTab_0)
	{
		int num = 0;
		if (bubbleBarTab_0 != null)
		{
			num = IndexOf(bubbleBarTab_0) + 1;
		}
		int num2 = num;
		while (true)
		{
			if (num2 < base.Count)
			{
				if (this[num2].Visible)
				{
					break;
				}
				num2++;
				continue;
			}
			return null;
		}
		return this[num2];
	}

	internal BubbleBarTab method_3(BubbleBarTab bubbleBarTab_0)
	{
		int num = 0;
		if (bubbleBarTab_0 != null)
		{
			num = IndexOf(bubbleBarTab_0) - 1;
		}
		int num2 = num;
		while (true)
		{
			if (num2 >= 0)
			{
				if (this[num2].Visible)
				{
					break;
				}
				num2--;
				continue;
			}
			return null;
		}
		return this[num2];
	}
}

namespace DevComponents.DotNetBar.Ribbon;

internal class Class242 : SubItemsCollection
{
	private Control7 control7_0;

	public Class242(Control7 qatToolbar)
		: base(null)
	{
		control7_0 = qatToolbar;
	}

	protected override void OnInsert(int index, object value)
	{
	}

	protected override void OnInsertComplete(int index, object value)
	{
		if (!m_IgnoreEvents)
		{
			if (control7_0.SubItemsCollection_0.Count <= index)
			{
				control7_0.SubItemsCollection_0.Add(value as BaseItem);
			}
			else
			{
				control7_0.SubItemsCollection_0.Insert(index, value as BaseItem);
			}
		}
	}

	protected override void RemoveInternal(int index, object value)
	{
		if (!m_IgnoreEvents)
		{
			control7_0.SubItemsCollection_0.Remove(value as BaseItem);
		}
	}

	protected override void RemoveCompleteInternal(int index, object value)
	{
	}
}

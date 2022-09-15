namespace DevComponents.DotNetBar;

internal class Class113 : Class111
{
	private bool bool_1;

	private eOrientation eOrientation_0;

	public override void RecordSetting(BaseItem item)
	{
		if (!base.Boolean_0)
		{
			ItemContainer itemContainer = item as ItemContainer;
			bool_1 = itemContainer.MultiLine;
			eOrientation_0 = itemContainer.LayoutOrientation;
			base.RecordSetting(item);
		}
	}

	public override void RestoreSettings()
	{
		if (base.Boolean_0)
		{
			ItemContainer itemContainer = baseItem_0 as ItemContainer;
			itemContainer.MultiLine = bool_1;
			itemContainer.LayoutOrientation = eOrientation_0;
			base.RestoreSettings();
		}
	}
}

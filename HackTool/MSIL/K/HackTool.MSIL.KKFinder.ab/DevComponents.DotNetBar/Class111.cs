namespace DevComponents.DotNetBar;

internal class Class111
{
	public BaseItem baseItem_0;

	private bool bool_0;

	protected bool Boolean_0
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

	public virtual void RecordSetting(BaseItem item)
	{
		baseItem_0 = item;
		bool_0 = true;
	}

	public virtual void RestoreSettings()
	{
		bool_0 = false;
	}
}

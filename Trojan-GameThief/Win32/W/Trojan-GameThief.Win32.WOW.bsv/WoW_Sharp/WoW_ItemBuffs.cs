namespace WoW_Sharp;

public class WoW_ItemBuffs
{
	private WoW woW_0;

	private WoW_Object woW_Object_0;

	private WoW_ItemBuff[] woW_ItemBuff_0;

	private int int_0 = 7;

	public WoW_ItemBuff this[int int_1]
	{
		get
		{
			if (int_1 >= 0 && int_1 < int_0)
			{
				if (woW_ItemBuff_0[int_1] == null)
				{
					woW_ItemBuff_0[int_1] = new WoW_ItemBuff(woW_0, woW_Object_0, int_1);
				}
				return woW_ItemBuff_0[int_1];
			}
			return null;
		}
	}

	public int Count => int_0;

	internal WoW_ItemBuffs(WoW woW_1, WoW_Object woW_Object_1)
	{
		woW_0 = woW_1;
		woW_Object_0 = woW_Object_1;
		woW_ItemBuff_0 = new WoW_ItemBuff[int_0];
		for (int i = 0; i < int_0; i++)
		{
			woW_ItemBuff_0[i] = null;
		}
	}
}

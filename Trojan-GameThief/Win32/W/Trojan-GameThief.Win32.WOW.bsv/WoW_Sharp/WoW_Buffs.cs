namespace WoW_Sharp;

public class WoW_Buffs
{
	private WoW woW_0;

	private int int_0 = 56;

	private WoW_Buff[] woW_Buff_0;

	public WoW_Buff this[int int_1]
	{
		get
		{
			if (int_1 >= 0 && int_1 < int_0)
			{
				return woW_Buff_0[int_1];
			}
			return null;
		}
	}

	public WoW_Buff this[string string_0]
	{
		get
		{
			int num = 0;
			while (true)
			{
				if (num < int_0)
				{
					if (woW_Buff_0[num].SpellName == string_0)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return woW_Buff_0[num];
		}
	}

	public int Count => int_0;

	internal WoW_Buffs(WoW woW_1)
	{
		woW_0 = woW_1;
		woW_Buff_0 = new WoW_Buff[int_0];
		for (int i = 0; i < int_0; i++)
		{
			woW_Buff_0[i] = new WoW_Buff(woW_1, i);
		}
	}
}

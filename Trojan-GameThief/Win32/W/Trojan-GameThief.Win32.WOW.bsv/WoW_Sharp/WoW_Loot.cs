using ns0;

namespace WoW_Sharp;

public class WoW_Loot
{
	private WoW woW_0;

	private int int_0 = 10;

	private WoW_LootSlot[] woW_LootSlot_0;

	public WoW_LootSlot this[int int_1]
	{
		get
		{
			if (int_1 >= 0 && int_1 < int_0)
			{
				return woW_LootSlot_0[int_1];
			}
			return null;
		}
	}

	internal WoW_Loot(WoW woW_1)
	{
		woW_0 = woW_1;
		woW_LootSlot_0 = new WoW_LootSlot[int_0];
		for (int i = 0; i < int_0; i++)
		{
			woW_LootSlot_0[i] = new WoW_LootSlot(woW_1, i);
		}
	}

	public int Count()
	{
		int num = 0;
		if (woW_0.Memory.ReadLong(woW_0.class3_0.method_0("CGLootInfo__m_object")) != 0L)
		{
			for (int i = 0; i < 10; i++)
			{
				if (woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_loot") + 4 + i * 28) > 0)
				{
					num = i + 1;
				}
			}
			if (woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_coins")) != 0)
			{
				num++;
			}
		}
		return num;
	}

	public void PickupLoot(int int_1)
	{
		if (int_1 >= 0 && int_1 < int_0)
		{
			woW_LootSlot_0[int_1].PickupLoot();
		}
	}

	public void PickupAllLoot()
	{
		if (woW_0.Injected)
		{
			Class1.PickupAllLoot();
		}
	}
}

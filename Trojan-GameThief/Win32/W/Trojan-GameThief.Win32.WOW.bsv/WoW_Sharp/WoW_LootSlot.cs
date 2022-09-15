using System;
using ns0;

namespace WoW_Sharp;

public class WoW_LootSlot
{
	private WoW woW_0;

	private int int_0;

	public bool IsItem
	{
		get
		{
			if (woW_0.Memory.ReadLong(woW_0.class3_0.method_0("CGLootInfo__m_object")) == 0L)
			{
				return false;
			}
			bool flag = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_coins")) != 0;
			if (int_0 == 0 && flag)
			{
				return false;
			}
			int num = int_0;
			if (flag)
			{
				num--;
			}
			return woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_loot") + 4 + num * 28) != 0;
		}
	}

	public bool IsCoins
	{
		get
		{
			if (woW_0.Memory.ReadLong(woW_0.class3_0.method_0("CGLootInfo__m_object")) == 0L)
			{
				return false;
			}
			if (int_0 == 0 && woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_coins")) != 0)
			{
				return true;
			}
			return false;
		}
	}

	public int ItemId
	{
		get
		{
			if (woW_0.Memory.ReadLong(woW_0.class3_0.method_0("CGLootInfo__m_object")) == 0L)
			{
				return 0;
			}
			bool flag = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_coins")) != 0;
			int num = int_0;
			if (flag)
			{
				num--;
			}
			return woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_loot") + 4 + num * 28);
		}
	}

	public string ItemName
	{
		get
		{
			if (woW_0.class10_0.method_1(ItemId) == 0)
			{
				return "";
			}
			return (string)woW_0.class10_0[ItemId];
		}
	}

	public int ItemQuality
	{
		get
		{
			int num = woW_0.class10_0.method_1(ItemId);
			if (num == 0)
			{
				return -1;
			}
			Console.WriteLine(ItemName + " : " + num.ToString("X"));
			return woW_0.Memory.ReadInteger(num + 24 + 28);
		}
	}

	public int ItemQuantity
	{
		get
		{
			if (woW_0.Memory.ReadLong(woW_0.class3_0.method_0("CGLootInfo__m_object")) == 0L)
			{
				return 0;
			}
			bool flag;
			if ((flag = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_coins")) != 0) && int_0 == 0)
			{
				return 0;
			}
			int num = int_0;
			if (flag)
			{
				num--;
			}
			return woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("CGLootInfo__m_loot") + 12 + num * 28);
		}
	}

	internal WoW_LootSlot(WoW woW_1, int int_1)
	{
		woW_0 = woW_1;
		int_0 = int_1;
	}

	public void PickupLoot()
	{
		if (woW_0.Injected)
		{
			Class1.PickupLoot(int_0);
		}
	}
}

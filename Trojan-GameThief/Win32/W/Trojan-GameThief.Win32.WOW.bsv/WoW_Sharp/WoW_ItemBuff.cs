using ns0;

namespace WoW_Sharp;

public class WoW_ItemBuff
{
	private WoW woW_0;

	private WoW_Object woW_Object_0;

	private int int_0;

	public int TimeLeft
	{
		get
		{
			int int_ = woW_Object_0.BasePtr + woW_0.class2_0.method_0("CGItem_C__BuffTimes") + int_0 * 4;
			int num = woW_0.Memory.ReadInteger(int_);
			if (num == 0)
			{
				return -1;
			}
			return (num - Class1.GetAsyncTimeMs()) / 1000;
		}
	}

	public int ChargesLeft
	{
		get
		{
			int num = woW_0.Descriptors[woW_Object_0.Type, "ITEM_FIELD_ENCHANTMENT"];
			if (num == 0)
			{
				return 0;
			}
			num += (int_0 * 3 + 2) * 4;
			return woW_Object_0.ReadStorageInt(num);
		}
	}

	public int EnchantmentId
	{
		get
		{
			int num = woW_0.Descriptors[woW_Object_0.Type, "ITEM_FIELD_ENCHANTMENT"];
			if (num == 0)
			{
				return 0;
			}
			num += int_0 * 4 * 3;
			return woW_Object_0.ReadStorageInt(num);
		}
		set
		{
			int num = woW_0.Descriptors[woW_Object_0.Type, "ITEM_FIELD_ENCHANTMENT"];
			if (num != 0)
			{
				num += int_0 * 4 * 3;
				woW_Object_0.WriteStorageInt(num, value);
			}
		}
	}

	public string EnchantmentName
	{
		get
		{
			int enchantmentId = EnchantmentId;
			if (enchantmentId == 0)
			{
				return "";
			}
			int num = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_spellItemEnchantment") + 8);
			int num2 = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_spellItemEnchantment") + 12);
			if (enchantmentId >= num2)
			{
				return "";
			}
			int num3 = woW_0.Memory.ReadInteger(num + enchantmentId * 4);
			if (num3 == 0)
			{
				return "";
			}
			int int_ = woW_0.Memory.ReadInteger(num3 + woW_0.class2_0.method_0("spellItemEnchantment_Name") * 4);
			return woW_0.Memory.ReadString(int_, 64);
		}
	}

	internal WoW_ItemBuff(WoW woW_1, WoW_Object woW_Object_1, int int_1)
	{
		woW_0 = woW_1;
		woW_Object_0 = woW_Object_1;
		int_0 = int_1;
	}
}

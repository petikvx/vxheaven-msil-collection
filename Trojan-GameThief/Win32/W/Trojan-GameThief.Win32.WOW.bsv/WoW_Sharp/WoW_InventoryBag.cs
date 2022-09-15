namespace WoW_Sharp;

public class WoW_InventoryBag
{
	private WoW woW_0;

	private WoW_Object woW_Object_0;

	private int int_0 = 0;

	private int int_1 = 0;

	private WoW_Object[] woW_Object_1;

	public WoW_Object Container => woW_Object_0;

	public WoW_Object this[int int_2]
	{
		get
		{
			if (int_2 >= 0 && int_2 < int_0)
			{
				return woW_Object_1[int_2];
			}
			return null;
		}
	}

	public int this[string string_0]
	{
		get
		{
			if (string_0 != null && !(string_0 == ""))
			{
				int num = 0;
				while (true)
				{
					if (num < int_0)
					{
						if (woW_Object_1[num] != null && woW_Object_1[num].Name == string_0)
						{
							break;
						}
						num++;
						continue;
					}
					return -1;
				}
				return num;
			}
			return -1;
		}
	}

	public int Count => int_0;

	internal WoW_InventoryBag(WoW woW_1, WoW_Object woW_Object_2)
	{
		woW_0 = woW_1;
		woW_Object_0 = woW_Object_2;
		if (woW_Object_2 == woW_1.Player)
		{
			int_0 = 16;
			int_1 = woW_1.Descriptors[WoW_ObjectTypes.Player, "PLAYER_FIELD_PACK_SLOT_1"];
		}
		else
		{
			int_0 = woW_Object_2.ReadStorageInt(woW_1.Descriptors[WoW_ObjectTypes.Container, "CONTAINER_FIELD_NUM_SLOTS"]);
			int_1 = woW_1.Descriptors[WoW_ObjectTypes.Container, "CONTAINER_FIELD_SLOT_1"];
		}
		woW_Object_1 = new WoW_Object[int_0];
	}

	internal void method_0()
	{
		for (int i = 0; i < int_0; i++)
		{
			int int_ = int_1 + i * 8;
			long num = woW_Object_0.ReadStorageLong(int_);
			if (num == 0L)
			{
				woW_Object_1[i] = null;
			}
			else
			{
				woW_Object_1[i] = (WoW_Object)woW_0.Objects[num];
			}
		}
	}
}

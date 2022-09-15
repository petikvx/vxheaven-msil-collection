using System.Collections;
using ns0;

namespace WoW_Sharp;

public class WoW_Inventory
{
	private WoW woW_0;

	private int int_0 = 5;

	private WoW_InventoryBag[] woW_InventoryBag_0;

	private Hashtable hashtable_0;

	public WoW_InventoryBag this[int int_1]
	{
		get
		{
			if (int_1 >= 0 && int_1 < int_0)
			{
				return woW_InventoryBag_0[int_1];
			}
			return null;
		}
	}

	public WoW_Object this[int int_1, int int_2]
	{
		get
		{
			if (int_1 >= 0 && int_1 < int_0)
			{
				if (woW_InventoryBag_0[int_1] == null)
				{
					return null;
				}
				return woW_InventoryBag_0[int_1][int_2];
			}
			return null;
		}
	}

	public WoW_Object this[string string_0]
	{
		get
		{
			if (string_0 != null && !(string_0 == ""))
			{
				int num = 0;
				int num2;
				while (true)
				{
					if (num < int_0)
					{
						if (woW_InventoryBag_0[num] != null)
						{
							num2 = woW_InventoryBag_0[num][string_0];
							if (num2 != -1)
							{
								break;
							}
						}
						num++;
						continue;
					}
					return null;
				}
				return woW_InventoryBag_0[num][num2];
			}
			return null;
		}
	}

	public int Count => int_0;

	internal WoW_Inventory(WoW woW_1)
	{
		woW_0 = woW_1;
		woW_InventoryBag_0 = new WoW_InventoryBag[int_0];
		for (int i = 0; i < int_0; i++)
		{
			woW_InventoryBag_0[i] = null;
		}
	}

	internal void method_0()
	{
		if (woW_0.Player == null)
		{
			for (int i = 0; i < int_0; i++)
			{
				woW_InventoryBag_0[i] = null;
			}
			return;
		}
		if (hashtable_0 == null)
		{
			hashtable_0 = new Hashtable();
			int num = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_slotNamesCount"));
			int num2 = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_slotNames"));
			for (int j = 0; j < num; j++)
			{
				int int_ = woW_0.Memory.ReadInteger(num2 + j * 16);
				string key = woW_0.Memory.ReadString(int_, 64);
				int num3 = woW_0.Memory.ReadInteger(num2 + j * 16 + 8);
				hashtable_0.Add(key, num3);
			}
		}
		if (woW_InventoryBag_0[0] == null || woW_InventoryBag_0[0].Container != woW_0.Player)
		{
			woW_InventoryBag_0[0] = new WoW_InventoryBag(woW_0, woW_0.Player);
		}
		woW_InventoryBag_0[0].method_0();
		for (int k = 1; k < int_0; k++)
		{
			int int_2 = woW_0.Descriptors[WoW_ObjectTypes.Player, "PLAYER_FIELD_INV_SLOT_HEAD"] + 144 + k * 8;
			long num4 = woW_0.Player.ReadStorageLong(int_2);
			if (num4 == 0L)
			{
				woW_InventoryBag_0[k] = null;
				continue;
			}
			WoW_Object woW_Object = (WoW_Object)woW_0.Objects[num4];
			if (woW_Object == null)
			{
				woW_InventoryBag_0[k] = null;
				continue;
			}
			if (woW_InventoryBag_0[k] == null || woW_InventoryBag_0[k].Container != woW_Object)
			{
				woW_InventoryBag_0[k] = new WoW_InventoryBag(woW_0, woW_Object);
			}
			woW_InventoryBag_0[k].method_0();
		}
	}

	public WoW_Object GetInventoryItem(string string_0)
	{
		if (hashtable_0 != null && hashtable_0.ContainsKey(string_0))
		{
			if (woW_0.Player == null)
			{
				return null;
			}
			int num = (int)hashtable_0[string_0] - 1;
			if (num == -1)
			{
				return null;
			}
			int num2 = woW_0.Descriptors[WoW_ObjectTypes.Player, "PLAYER_FIELD_INV_SLOT_HEAD"];
			long num3 = woW_0.Player.ReadStorageLong(num2 + num * 8);
			return (WoW_Object)woW_0.Objects[num3];
		}
		return null;
	}

	private string method_1(string string_0)
	{
		int num = 0;
		int num2;
		while (true)
		{
			if (num < int_0)
			{
				if (woW_InventoryBag_0[num] != null)
				{
					num2 = woW_InventoryBag_0[num][string_0];
					if (num2 != -1)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return "";
		}
		return $"({num},{num2 + 1})";
	}

	public bool UseItem(string string_0)
	{
		string text = method_1(string_0);
		string text2 = "UseContainerItem" + text;
		if (text == "")
		{
			return false;
		}
		if (!woW_0.Injected)
		{
			return false;
		}
		woW_0.LogLine("Executing script: " + text2);
		Class1.SendScript(text2);
		return true;
	}

	public void PickupInventoryItem(string string_0)
	{
		if (hashtable_0 != null && hashtable_0.ContainsKey(string_0) && woW_0.Player != null)
		{
			int num = (int)hashtable_0[string_0];
			Class1.SendScript($"PickupInventoryItem({num})");
		}
	}

	public int StackCount(string string_0)
	{
		int num = 0;
		if (string_0 != null && !(string_0 == ""))
		{
			for (int i = 0; i < int_0; i++)
			{
				if (woW_InventoryBag_0[i] != null)
				{
					int num2 = woW_InventoryBag_0[i][string_0];
					if (num2 != -1)
					{
						num += woW_InventoryBag_0[i][num2].StackCount;
					}
				}
			}
			return num;
		}
		return num;
	}

	public ArrayList GetAllItems()
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < int_0; i++)
		{
			if (woW_InventoryBag_0[i] == null)
			{
				continue;
			}
			for (int j = 0; j < woW_InventoryBag_0[i].Count; j++)
			{
				if (woW_InventoryBag_0[i][j] != null)
				{
					arrayList.Add(woW_InventoryBag_0[i][j]);
				}
			}
		}
		return arrayList;
	}

	public WoW_Object GetItemById(int int_1)
	{
		for (int i = 0; i < Count; i++)
		{
			if (woW_InventoryBag_0[i] == null)
			{
				continue;
			}
			for (int j = 0; j < woW_InventoryBag_0[i].Count; j++)
			{
				WoW_Object woW_Object = woW_InventoryBag_0[i][j];
				if (woW_Object != null && woW_Object.ItemId == int_1)
				{
					return woW_Object;
				}
			}
		}
		return null;
	}
}

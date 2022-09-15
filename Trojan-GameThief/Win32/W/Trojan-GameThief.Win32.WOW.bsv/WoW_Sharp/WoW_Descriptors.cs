using System.Collections;

namespace WoW_Sharp;

public class WoW_Descriptors
{
	private WoW woW_0;

	private Hashtable[] hashtable_0;

	public int this[WoW_ObjectTypes woW_ObjectTypes_0, string string_0] => (int)hashtable_0[(int)woW_ObjectTypes_0][string_0];

	public Hashtable this[WoW_ObjectTypes woW_ObjectTypes_0] => hashtable_0[(int)woW_ObjectTypes_0];

	internal WoW_Descriptors(WoW woW_1)
	{
		woW_0 = woW_1;
		hashtable_0 = new Hashtable[8];
		hashtable_0[0] = method_0("s_objDescriptors");
		hashtable_0[1] = method_0("s_itemDescriptors");
		hashtable_0[2] = method_0("s_containerDescriptors");
		hashtable_0[3] = method_0("s_unitDescriptors");
		hashtable_0[4] = method_0("s_playerDescriptors");
		hashtable_0[5] = method_0("s_gameObjectDescriptors");
		hashtable_0[6] = method_0("s_dynamicObjectDescriptors");
		hashtable_0[7] = method_0("s_corpseDescriptors");
	}

	private Hashtable method_0(string string_0)
	{
		Hashtable hashtable = new Hashtable();
		int num = 0;
		int num2 = woW_0.class3_0.method_0(string_0);
		while (true)
		{
			int num3 = woW_0.Memory.ReadInteger(num2);
			if ((num3 & 0x40000000) == 1073741824)
			{
				break;
			}
			string text = woW_0.Memory.ReadString(num3, 64);
			if (text == "OBJECT_FIELD_GUID" && num > 2)
			{
				break;
			}
			if (!hashtable.ContainsKey(text))
			{
				hashtable.Add(text, num * 4);
			}
			num2 += 20;
			num++;
		}
		return hashtable;
	}
}

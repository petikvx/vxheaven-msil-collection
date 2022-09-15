using System;
using System.Collections;
using WoW_Sharp;

namespace ns0;

internal class Class2
{
	private Hashtable hashtable_0;

	internal Guid guid_0;

	private WoW woW_0;

	internal Class2(WoW woW_1, Guid guid_1)
	{
		woW_0 = woW_1;
		guid_0 = guid_1;
		hashtable_0 = new Hashtable();
		try
		{
			Class4.smethod_2(guid_1, "offsets", hashtable_0, woW_1.byte_0);
		}
		catch
		{
		}
	}

	internal int method_0(string string_0)
	{
		if (!hashtable_0.ContainsKey(string_0))
		{
			int num = Class4.smethod_4(guid_0, string_0);
			hashtable_0.Add(string_0, num);
		}
		return (int)hashtable_0[string_0];
	}
}

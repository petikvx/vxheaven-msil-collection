using System.Collections;
using WoW_Sharp;

namespace ns0;

internal abstract class Class8
{
	internal WoW woW_0;

	internal int int_0;

	private int int_1;

	internal Hashtable hashtable_0;

	private Hashtable hashtable_1;

	public int Int32_0 => int_0;

	public virtual object this[object object_0] => hashtable_0[object_0];

	public int Count => hashtable_1.Count;

	internal Class8(WoW woW_1)
	{
		woW_0 = woW_1;
		int_0 = int_0;
		int_1 = 0;
		hashtable_0 = new Hashtable();
		hashtable_1 = new Hashtable();
	}

	public abstract object vmethod_0(int int_2);

	public abstract object vmethod_1(int int_2);

	public void method_0()
	{
		int num = 0;
		if (int_1 == 0)
		{
			int_1 = woW_0.Memory.ReadInteger(int_0 + 12);
		}
		num = int_1;
		while ((num & 1) == 0 && num != 0 && num != 28)
		{
			object key = vmethod_0(num);
			if (!hashtable_0.ContainsKey(key))
			{
				object obj = vmethod_1(num);
				if (obj != null)
				{
					hashtable_0.Add(key, obj);
					hashtable_1.Add(key, num);
				}
			}
			int_1 = num;
			num = woW_0.Memory.ReadInteger(num + 16);
			if (num == int_1)
			{
				break;
			}
		}
	}

	public int method_1(object object_0)
	{
		object obj = hashtable_1[object_0];
		if (obj == null)
		{
			return 0;
		}
		return (int)obj;
	}
}

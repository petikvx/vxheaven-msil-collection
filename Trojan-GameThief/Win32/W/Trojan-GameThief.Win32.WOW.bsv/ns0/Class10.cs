using WoW_Sharp;

namespace ns0;

internal class Class10 : Class8
{
	private class Class7
	{
		internal int int_0;

		internal string string_0;
	}

	public override object this[object object_0]
	{
		get
		{
			Class7 @class = (Class7)hashtable_0[object_0];
			if (@class == null)
			{
				return null;
			}
			if (@class.string_0 == null)
			{
				int num = woW_0.Memory.ReadInteger(@class.int_0 + 32);
				if (num != 0)
				{
					@class.string_0 = woW_0.Memory.ReadString(num, 64);
				}
				if (@class.string_0 == "")
				{
					@class.string_0 = null;
				}
			}
			return @class.string_0;
		}
	}

	internal Class10(WoW woW_1)
		: base(woW_1)
	{
		int_0 = woW_1.class3_0.method_0("g_itemDBCache");
	}

	public override object vmethod_0(int int_2)
	{
		return woW_0.Memory.ReadInteger(int_2 + 468);
	}

	public override object vmethod_1(int int_2)
	{
		Class7 @class = new Class7();
		@class.int_0 = int_2;
		int num = woW_0.Memory.ReadInteger(int_2 + 32);
		if (num == 0)
		{
			@class.string_0 = null;
		}
		else
		{
			@class.string_0 = woW_0.Memory.ReadString(num, 64);
			if (@class.string_0 == "")
			{
				@class.string_0 = null;
			}
		}
		return @class;
	}
}

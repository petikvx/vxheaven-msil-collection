using WoW_Sharp;

namespace ns0;

internal class Class9 : Class8
{
	private class Class6
	{
		internal int int_0;

		internal string string_0;
	}

	public override object this[object object_0]
	{
		get
		{
			Class6 @class = (Class6)hashtable_0[object_0];
			if (@class == null)
			{
				return null;
			}
			if (@class.string_0 == null)
			{
				@class.string_0 = woW_0.Memory.ReadString(@class.int_0 + 32, 64);
				if (@class.string_0 == "")
				{
					@class.string_0 = null;
				}
			}
			return @class.string_0;
		}
	}

	internal Class9(WoW woW_1)
		: base(woW_1)
	{
		int_0 = woW_1.class3_0.method_0("g_nameDBCache");
	}

	public override object vmethod_0(int int_2)
	{
		return woW_0.Memory.ReadLong(int_2 + 24);
	}

	public override object vmethod_1(int int_2)
	{
		Class6 @class = new Class6();
		@class.int_0 = int_2;
		@class.string_0 = woW_0.Memory.ReadString(int_2 + 32, 64);
		if (@class.string_0 == "")
		{
			@class.string_0 = null;
		}
		return @class;
	}
}

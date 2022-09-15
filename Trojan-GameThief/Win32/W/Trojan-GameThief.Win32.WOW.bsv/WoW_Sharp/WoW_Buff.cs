using ns0;

namespace WoW_Sharp;

public class WoW_Buff
{
	private WoW woW_0;

	private int int_0;

	private int int_1;

	public bool Active => woW_0.Memory.ReadInteger(int_1) != -1;

	public int SpellId => woW_0.Memory.ReadInteger(int_1 + 4);

	public string SpellName
	{
		get
		{
			if (!Active)
			{
				return "";
			}
			return woW_0.GetSpellName(SpellId, bool_4: false);
		}
	}

	public int TimeLeft
	{
		get
		{
			int num = woW_0.Memory.ReadInteger(int_1);
			if (num == -1)
			{
				return 0;
			}
			int int_ = woW_0.class3_0.method_0("CGBuffBar__m_durations") + num * 4;
			int num2 = woW_0.Memory.ReadInteger(int_) - Class1.GetAsyncTimeMs();
			return num2 / 1000;
		}
	}

	internal WoW_Buff(WoW woW_1, int int_2)
	{
		woW_0 = woW_1;
		int_0 = int_2;
		int_1 = woW_1.class3_0.method_0("CGBuffBar__m_buffs") + (int_2 << 4);
	}
}

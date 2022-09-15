using System;

namespace WoW_Sharp;

public class WoW_Object
{
	private WoW woW_0;

	internal bool bool_0 = false;

	private int int_0;

	private int int_1;

	private int int_2;

	private WoW_ObjectTypes woW_ObjectTypes_0;

	private WGUID wguid_0;

	private WoW_ItemBuffs woW_ItemBuffs_0;

	private float float_0;

	private float float_1;

	private float float_2;

	private float float_3;

	private float float_4;

	private string string_0;

	private int int_3 = 0;

	private int int_4 = 0;

	private int int_5 = 0;

	private string string_1 = null;

	private string string_2 = null;

	public WGUID GUID => wguid_0;

	public string Name => string_0;

	public WoW_ObjectTypes Type => woW_ObjectTypes_0;

	public bool IsValid
	{
		get
		{
			if (bool_0)
			{
				return false;
			}
			if (wguid_0.GUID != woW_0.Memory.ReadLong(int_0 + 48))
			{
				bool_0 = true;
				return false;
			}
			return true;
		}
	}

	public int BasePtr => int_0;

	public float X => float_0;

	public float Y => float_1;

	public float Z => float_2;

	public float Facing => float_3;

	public float Speed => float_4;

	public bool IsOpenable
	{
		get
		{
			if (Type != WoW_ObjectTypes.Item)
			{
				return false;
			}
			return (ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "ITEM_FIELD_FLAGS"]) & 4) != 0;
		}
	}

	public int ItemId
	{
		get
		{
			if (Type != WoW_ObjectTypes.Item)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "OBJECT_FIELD_ENTRY"]);
		}
	}

	public int StackCount
	{
		get
		{
			if (Type != WoW_ObjectTypes.Item)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "ITEM_FIELD_STACK_COUNT"]);
		}
	}

	public WoW_ItemBuffs ItemBuffs
	{
		get
		{
			if (Type != WoW_ObjectTypes.Item)
			{
				return null;
			}
			if (woW_ItemBuffs_0 == null)
			{
				woW_ItemBuffs_0 = new WoW_ItemBuffs(woW_0, this);
			}
			return woW_ItemBuffs_0;
		}
	}

	public bool IsMiningNode
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.GameObject)
			{
				int_3 = 1;
			}
			if (int_3 == 0)
			{
				string text = method_1();
				int_3 = 1;
				if (text.IndexOf("_miningnode_") > -1)
				{
					int_3 = 2;
				}
			}
			return int_3 == 2;
		}
	}

	public bool IsWeedNode
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.GameObject)
			{
				int_4 = 1;
			}
			if (int_4 == 0)
			{
				string text = method_1();
				int_4 = 1;
				if (text.IndexOf("tradeskillnodes\\bush") > -1)
				{
					int_4 = 2;
				}
			}
			return int_4 == 2;
		}
	}

	public bool IsTreasureNode
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.GameObject)
			{
				int_5 = 1;
			}
			if (int_5 == 0)
			{
				string text = method_1();
				int_5 = 1;
				if (text.IndexOf("treasure") > -1)
				{
					int_5 = 2;
				}
			}
			return int_5 == 2;
		}
	}

	public bool BobberBobbing
	{
		get
		{
			if (Type != WoW_ObjectTypes.GameObject)
			{
				return false;
			}
			return woW_0.Memory.ReadInteger(int_0 + 232) != 0;
		}
	}

	public int Health
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_HEALTH"]);
		}
	}

	public int MaximumHealth
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_MAXHEALTH"]);
		}
	}

	public float HealthPercentage => (float)Health / (float)MaximumHealth * 100f;

	public int Mana
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_POWER1"]);
		}
	}

	public int MaximumMana
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_MAXPOWER1"]);
		}
	}

	public float ManaPercentage
	{
		get
		{
			if (MaximumMana == 0)
			{
				return 100f;
			}
			return (float)Mana / (float)MaximumMana * 100f;
		}
	}

	public int Rage
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_POWER2"]) / 10;
		}
	}

	public int ComboPoints
	{
		get
		{
			if (Type != WoW_ObjectTypes.Player)
			{
				return 0;
			}
			int num = woW_0.Memory.ReadInteger(BasePtr + woW_0.class2_0.method_0("CGPlayer_C__ComboPoints_Ptr1"));
			return woW_0.Memory.ReadInteger(num + woW_0.class2_0.method_0("CGPlayer_C__ComboPoints_Ptr2")) & 0xFF;
		}
	}

	public int Focus
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_POWER3"]);
		}
	}

	public int Energy
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return 0;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_POWER4"]);
		}
	}

	public int HappinessPercentage
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit)
			{
				return 0;
			}
			float num = ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_POWER5"]);
			float num2 = ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_MAXPOWER5"]);
			if (num2 == 0f)
			{
				return 100;
			}
			return (int)(num / num2 * 100f);
		}
	}

	public WoW_Object Target
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return null;
			}
			long num = ReadStorageLong(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_TARGET"]);
			return (WoW_Object)woW_0.Objects[num];
		}
	}

	public WoW_Object Pet
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return null;
			}
			long num = ReadStorageLong(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_SUMMON"]);
			if (num == 0L)
			{
				num = ReadStorageLong(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_CHARM"]);
			}
			return (WoW_Object)woW_0.Objects[num];
		}
	}

	public WoW_Object Owner
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return null;
			}
			long num = ReadStorageLong(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_SUMMONEDBY"]);
			if (num == 0L)
			{
				num = ReadStorageLong(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_CHARMEDBY"]);
			}
			return (WoW_Object)woW_0.Objects[num];
		}
	}

	internal long Int64_0
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return 0L;
			}
			return ReadStorageLong(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_TARGET"]);
		}
	}

	public bool IsDead
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return false;
			}
			if (((uint)ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_FLAGS"]) & 0x40000u) != 0)
			{
				return Health == 0;
			}
			return false;
		}
	}

	public bool IsSitting
	{
		get
		{
			if (Type != WoW_ObjectTypes.Unit && Type != WoW_ObjectTypes.Player)
			{
				return false;
			}
			return (ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_BYTES_1"]) & 0xFF) != 0;
		}
	}

	public bool IsSkinnable
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Unit)
			{
				return false;
			}
			return (ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_FLAGS"]) & 0x4000000) != 0;
		}
	}

	public bool CanLoot
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Unit)
			{
				return false;
			}
			return (ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_DYNAMIC_FLAGS"]) & 1) != 0;
		}
	}

	public int Level
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Unit && woW_ObjectTypes_0 != WoW_ObjectTypes.Player)
			{
				if (woW_ObjectTypes_0 == WoW_ObjectTypes.GameObject)
				{
					return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "GAMEOBJECT_LEVEL"]);
				}
				return 1;
			}
			return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_LEVEL"]);
		}
	}

	public bool IsCasting
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Player)
			{
				return false;
			}
			if (woW_0.Memory.ReadInteger(BasePtr + woW_0.class2_0.method_0("CGPlayer_C__CastingSpellId")) == 0)
			{
				return ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_CHANNEL_SPELL"]) != 0;
			}
			return true;
		}
	}

	public bool IsAttacking
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Player)
			{
				return false;
			}
			return woW_0.Memory.ReadLong(BasePtr + woW_0.class2_0.method_0("CGPlayer_C__MeleeTarget")) != 0L;
		}
	}

	public bool IsInCombat
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Unit && woW_ObjectTypes_0 != WoW_ObjectTypes.Player)
			{
				return false;
			}
			return (ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_FLAGS"]) & 0x80000) != 0;
		}
	}

	public WoW_Object ChannelObject
	{
		get
		{
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Player)
			{
				return null;
			}
			long num = ReadStorageLong(woW_0.Descriptors[woW_ObjectTypes_0, "UNIT_FIELD_CHANNEL_OBJECT"]);
			return (WoW_Object)woW_0.Objects[num];
		}
	}

	public string UnitRace
	{
		get
		{
			if (string_1 != null)
			{
				return string_1;
			}
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Unit && woW_ObjectTypes_0 != WoW_ObjectTypes.Player)
			{
				return string_1 = "";
			}
			int num = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("WOW_LOCALE_CURRENT_LANGUAGE"));
			int num2 = woW_0.Memory.ReadInteger(int_0 + 272);
			int num3 = woW_0.Memory.ReadInteger(num2 + 120) & 0xFF;
			if (num3 != 0 && num3 <= woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_charRacesCount")))
			{
				int num4 = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_charRaces"));
				int num5 = woW_0.Memory.ReadInteger(num4 + num3 * 4);
				int num6 = woW_0.Memory.ReadInteger(num5 + 68 + num * 4);
				return string_1 = woW_0.Memory.ReadString(num6, 64);
			}
			return string_1 = "";
		}
	}

	public string UnitClass
	{
		get
		{
			if (string_2 != null)
			{
				return string_2;
			}
			if (woW_ObjectTypes_0 != WoW_ObjectTypes.Unit && woW_ObjectTypes_0 != WoW_ObjectTypes.Player)
			{
				return string_2 = "";
			}
			int num = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("WOW_LOCALE_CURRENT_LANGUAGE"));
			int num2 = woW_0.Memory.ReadInteger(int_0 + 272);
			int num3 = woW_0.Memory.ReadInteger(num2 + 121) & 0xFF;
			if (num3 != 0 && num3 <= woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_charClassesCount")))
			{
				int num4 = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_charClasses"));
				int num5 = woW_0.Memory.ReadInteger(num4 + num3 * 4);
				int num6 = woW_0.Memory.ReadInteger(num5 + 20 + num * 4);
				return string_2 = woW_0.Memory.ReadString(num6, 64);
			}
			return string_2 = "";
		}
	}

	internal WoW_Object(int int_6, WoW woW_1)
	{
		woW_0 = woW_1;
		int_0 = int_6;
		woW_ObjectTypes_0 = (WoW_ObjectTypes)woW_1.Memory.ReadInteger(int_0 + 20);
		wguid_0.GUID = woW_1.Memory.ReadLong(int_0 + 48);
		int_1 = woW_1.Memory.ReadInteger(int_0 + 8);
		int_2 = woW_1.Memory.ReadInteger(int_0 + 12);
		woW_ItemBuffs_0 = null;
	}

	public bool Update()
	{
		if (!IsValid)
		{
			return false;
		}
		woW_ObjectTypes_0 = (WoW_ObjectTypes)woW_0.Memory.ReadInteger(int_0 + 20);
		if (woW_ObjectTypes_0 == WoW_ObjectTypes.Item)
		{
			float num = 0f;
			float_4 = 0f;
			float num2 = num;
			num = 0f;
			float_3 = num2;
			float num3 = num;
			num = 0f;
			float_2 = num3;
			float num4 = num;
			num = 0f;
			float_1 = num4;
			float_0 = num;
			int num5 = ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "OBJECT_FIELD_ENTRY"]);
			string_0 = (string)woW_0.class10_0[num5];
		}
		if (woW_ObjectTypes_0 == WoW_ObjectTypes.Container)
		{
			float num = 0f;
			float_4 = 0f;
			float num6 = num;
			num = 0f;
			float_3 = num6;
			float num7 = num;
			num = 0f;
			float_2 = num7;
			float num8 = num;
			num = 0f;
			float_1 = num8;
			float_0 = num;
			int num9 = ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "OBJECT_FIELD_ENTRY"]);
			string_0 = (string)woW_0.class10_0[num9];
		}
		if (woW_ObjectTypes_0 == WoW_ObjectTypes.Unit)
		{
			float_1 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__Y"));
			float_0 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__X"));
			float_2 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__Z"));
			float_3 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__Facing"));
			float_4 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__Speed"));
			int num10 = woW_0.Memory.ReadInteger(int_0 + woW_0.class2_0.method_0("CGUnit_C__Name"));
			if (num10 != 0)
			{
				num10 = woW_0.Memory.ReadInteger(num10);
				if (num10 != 0)
				{
					string_0 = woW_0.Memory.ReadString(num10, 64);
				}
			}
		}
		if (woW_ObjectTypes_0 == WoW_ObjectTypes.Player)
		{
			float_1 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__Y"));
			float_0 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__X"));
			float_2 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__Z"));
			float_3 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__Facing"));
			float_4 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGPlayer_C__Speed"));
			string_0 = (string)woW_0.class9_0[GUID.GUID];
		}
		if (woW_ObjectTypes_0 == WoW_ObjectTypes.GameObject)
		{
			float_1 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGGameObject_C__Y"));
			float_0 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGGameObject_C__X"));
			float_2 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGGameObject_C__Z"));
			float_3 = woW_0.Memory.ReadFloat(int_0 + woW_0.class2_0.method_0("CGGameObject_C__Facing"));
			float_4 = 0f;
			int num11 = woW_0.Memory.ReadInteger(int_0 + woW_0.class2_0.method_0("CGGameObject_C__Name"));
			if (num11 != 0)
			{
				num11 = woW_0.Memory.ReadInteger(num11 + 8);
				if (num11 != 0)
				{
					string_0 = woW_0.Memory.ReadString(num11, 64);
				}
			}
		}
		if (woW_ObjectTypes_0 == WoW_ObjectTypes.Corpse)
		{
			int num12 = woW_0.Memory.ReadInteger(int_0 + 272);
			float num = 0f;
			float_4 = 0f;
			float num13 = num;
			num = 0f;
			float_3 = num13;
			float num14 = num;
			num = 0f;
			float_2 = num14;
			float num15 = num;
			num = 0f;
			float_1 = num15;
			float_0 = num;
			if (num12 != 0)
			{
				float_1 = woW_0.Memory.ReadFloat(num12 + 12);
				float_0 = woW_0.Memory.ReadFloat(num12 + 16);
				float_2 = woW_0.Memory.ReadFloat(num12 + 20);
				float_3 = woW_0.Memory.ReadFloat(num12 + 24);
				long num16 = ReadStorageLong(woW_0.Descriptors[woW_ObjectTypes_0, "CORPSE_FIELD_OWNER"]);
				string_0 = "Corpse of " + (string)woW_0.class9_0[num16];
			}
		}
		return true;
	}

	public int ReadStorageInt(int int_6)
	{
		if (int_1 + int_6 > int_2)
		{
			return -1;
		}
		return woW_0.Memory.ReadInteger(int_1 + int_6);
	}

	public long ReadStorageLong(int int_6)
	{
		if (int_1 + int_6 > int_2)
		{
			return -1L;
		}
		return woW_0.Memory.ReadLong(int_1 + int_6);
	}

	public float ReadStorageFloat(int int_6)
	{
		if (int_1 + int_6 > int_2)
		{
			return -1f;
		}
		return woW_0.Memory.ReadFloat(int_1 + int_6);
	}

	public void WriteStorageInt(int int_6, int int_7)
	{
		if (int_1 + int_6 <= int_2)
		{
			woW_0.Memory.WriteInteger(int_1 + int_6, int_7);
		}
	}

	public void WriteStorageLong(int int_6, long long_0)
	{
		if (int_1 + int_6 <= int_2)
		{
			woW_0.Memory.WriteLong(int_1 + int_6, long_0);
		}
	}

	public void WriteStorageFloat(int int_6, float float_5)
	{
		if (int_1 + int_6 <= int_2)
		{
			woW_0.Memory.WriteFloat(int_1 + int_6, float_5);
		}
	}

	internal int method_0()
	{
		int num = woW_0.Memory.ReadInteger(int_0 + 272);
		if (num == 0)
		{
			return -1;
		}
		int num2 = woW_0.Memory.ReadInteger(num + 116);
		return woW_0.Memory.ReadInteger(num2 * 4 + woW_0.class11_0.int_1);
	}

	internal string method_1()
	{
		int num = woW_0.Memory.ReadInteger(woW_0.class3_0.method_0("g_gameObjectDisplayInfoDB") + 8);
		int num2 = ReadStorageInt(woW_0.Descriptors[woW_ObjectTypes_0, "GAMEOBJECT_DISPLAYID"]);
		int num3 = woW_0.Memory.ReadInteger(num + num2 * 4);
		int num4 = woW_0.Memory.ReadInteger(num3 + 4);
		if (num4 == 0)
		{
			return "";
		}
		return woW_0.Memory.ReadString(num4, 128).ToLower();
	}

	internal float method_2(float float_5, float float_6)
	{
		float num = float_0 - float_5;
		float num2 = float_6 - float_1;
		float num3 = 0f;
		if ((double)num > 0.0 && (double)num2 >= 0.0)
		{
			num3 = (float)Math.Atan(num2 / num);
		}
		if ((double)num < 0.0 && (double)num2 >= 0.0)
		{
			num3 = (float)Math.Atan(num2 / num) + (float)Math.PI;
		}
		if ((double)num < 0.0 && (double)num2 < 0.0)
		{
			num3 = (float)Math.Atan(num2 / num) + (float)Math.PI;
		}
		if ((double)num > 0.0 && (double)num2 < 0.0)
		{
			num3 = (float)Math.Atan(num2 / num) + (float)Math.PI * 2f;
		}
		return num3 - (float)Math.PI / 2f;
	}

	public float GetDistance(WoW_Object woW_Object_0)
	{
		if (woW_Object_0 == null)
		{
			return 0f;
		}
		return GetDistance(woW_Object_0.X, woW_Object_0.Y, woW_Object_0.Z);
	}

	public float GetDistance(float float_5, float float_6, float float_7)
	{
		float num = X - float_5;
		float num2 = Y - float_6;
		float num3 = ((float_7 != 0f) ? (Z - float_7) : 0f);
		return (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3);
	}
}

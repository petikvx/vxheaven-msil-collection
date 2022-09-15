#define TRACE
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using ns0;

namespace WoW_Sharp;

public class WoW
{
	private const bool bool_0 = true;

	private const float float_0 = (float)Math.PI * 2f;

	private const float float_1 = 0.00328125f;

	private MemoryReader memoryReader_0;

	private int int_0 = 125;

	private bool bool_1 = false;

	private bool bool_2 = false;

	private bool bool_3 = false;

	private Thread thread_0;

	private ManualResetEvent manualResetEvent_0;

	private Hashtable hashtable_0;

	private Hashtable hashtable_1;

	private int int_1;

	private ArrayList arrayList_0;

	internal Class10 class10_0;

	internal Class9 class9_0;

	private WoW_Buffs woW_Buffs_0;

	private WoW_Inventory woW_Inventory_0;

	private WoW_Loot woW_Loot_0;

	private WoW_Descriptors woW_Descriptors_0;

	private WoW_ChatLog woW_ChatLog_0;

	private Hashtable hashtable_2 = null;

	private Hashtable hashtable_3 = null;

	private Hashtable hashtable_4 = null;

	private Hashtable hashtable_5 = null;

	private Class12 class12_0;

	private string string_0 = "";

	private string string_1 = "";

	private string string_2 = "";

	internal byte[] byte_0;

	private string string_3 = "";

	private ArrayList arrayList_1;

	private WoW_Object woW_Object_0;

	internal Class11 class11_0;

	internal Class3 class3_0;

	internal Class2 class2_0;

	private WoW_SharpEvent woW_SharpEvent_0;

	private OnLogLineDelegate onLogLineDelegate_0;

	public MemoryReader Memory => memoryReader_0;

	public int Interval
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public bool HasStarted => bool_2;

	public bool Injected => bool_1;

	public string ChatlogPath
	{
		get
		{
			if (!bool_1)
			{
				return "";
			}
			StringBuilder stringBuilder = new StringBuilder(256);
			Class1.GetChatlogPath(stringBuilder);
			return stringBuilder.ToString();
		}
	}

	public WoW_ChatLog ChatLog => woW_ChatLog_0;

	public Hashtable Objects => hashtable_1;

	public WoW_Object Player => class11_0.woW_Object_0;

	public bool HasCorpse => Memory.ReadInteger(class3_0.method_0("s_corpsePosition")) != 0;

	public float CorpseY => Memory.ReadFloat(class3_0.method_0("s_corpsePosition"));

	public float CorpseX => Memory.ReadFloat(class3_0.method_0("s_corpsePosition") + 4);

	public float CorpseZ => Memory.ReadFloat(class3_0.method_0("s_corpsePosition") + 8);

	public WoW_Object Target => (WoW_Object)hashtable_1[memoryReader_0.ReadLong(class3_0.method_0("CGGameUI__m_lockedTarget"))];

	public int NumberOfAttackers => int_1;

	public ArrayList AttackersByDistance => arrayList_0;

	public int CurrentContinent => memoryReader_0.ReadInteger(class3_0.method_0("CGWorldMap__m_currentContinent"));

	public WoW_Buffs Buffs => woW_Buffs_0;

	public WoW_Loot Loot => woW_Loot_0;

	public string GamePath
	{
		get
		{
			if (!memoryReader_0.IsOpen)
			{
				return null;
			}
			foreach (ProcessModule module in memoryReader_0.ReadProcess.Modules)
			{
				if (module.ModuleName!.ToLower() == "wow.exe")
				{
					return Path.GetDirectoryName(module.FileName);
				}
			}
			return null;
		}
	}

	public Hashtable KnownSpells
	{
		get
		{
			if (hashtable_2 == null)
			{
				hashtable_2 = method_5(class3_0.method_0("CGSpellBook__m_knownSpells"), bool_4: false);
			}
			return hashtable_2;
		}
	}

	public Hashtable KnownPetSpells
	{
		get
		{
			if (hashtable_4 == null)
			{
				hashtable_4 = method_5(class3_0.method_0("CGSpellBook__m_petSpells"), bool_4: false);
			}
			return hashtable_4;
		}
	}

	public Hashtable HighestKnownSpells
	{
		get
		{
			if (hashtable_3 == null)
			{
				hashtable_3 = method_5(class3_0.method_0("CGSpellBook__m_knownSpells"), bool_4: true);
			}
			return hashtable_3;
		}
	}

	public Hashtable HighestKnownPetSpells
	{
		get
		{
			if (hashtable_5 == null)
			{
				hashtable_5 = method_5(class3_0.method_0("CGSpellBook__m_petSpells"), bool_4: true);
			}
			return hashtable_5;
		}
	}

	public ArrayList PartyMembers => arrayList_1;

	public WoW_Object PartyLeader => woW_Object_0;

	public WoW_Inventory Inventory => woW_Inventory_0;

	public WoW_Descriptors Descriptors => woW_Descriptors_0;

	public string Username
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public string Password
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public string Application
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	public event WoW_SharpEvent AfterUpdate
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			woW_SharpEvent_0 = (WoW_SharpEvent)Delegate.Combine(woW_SharpEvent_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			woW_SharpEvent_0 = (WoW_SharpEvent)Delegate.Remove(woW_SharpEvent_0, value);
		}
	}

	public event OnLogLineDelegate OnLogLine
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			onLogLineDelegate_0 = (OnLogLineDelegate)Delegate.Combine(onLogLineDelegate_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			onLogLineDelegate_0 = (OnLogLineDelegate)Delegate.Remove(onLogLineDelegate_0, value);
		}
	}

	public bool Start()
	{
		if (bool_2)
		{
			Stop();
		}
		class12_0 = new Class12("debug.log");
		try
		{
			class12_0.Boolean_0 = true;
			LogLine("Starting WoW!Sharp");
			Process[] array;
			try
			{
				array = memoryReader_0.method_0("wow.exe");
				if (array.Length == 0)
				{
					throw new Exception("Unable to locate World of Warcraft");
				}
			}
			catch (Exception ex)
			{
				LogLine("Unable to retrieve process list: {0}", ex.Message);
				throw ex;
			}
			try
			{
				memoryReader_0.method_2(array[0]);
				if ((int)memoryReader_0.intptr_1 == 0)
				{
					throw new Exception("Unknown");
				}
			}
			catch (Exception ex2)
			{
				LogLine("Unable to open process: {0}", ex2.Message);
				throw ex2;
			}
			FileVersionInfo fileVersionInfo = null;
			ProcessModule processModule = null;
			foreach (ProcessModule module in array[0].Modules)
			{
				if (module.ModuleName!.ToLower() == "wow.exe")
				{
					processModule = module;
					fileVersionInfo = FileVersionInfo.GetVersionInfo(module.FileName);
					break;
				}
			}
			if (fileVersionInfo == null)
			{
				LogLine("Unable to locate WoW.exe module.");
				throw new Exception("Unable to locate WoW.exe module");
			}
			LogLine("World of Warcraft v" + fileVersionInfo.FileVersion);
			LogLine("Executable: " + processModule.FileName);
			Class5 @class;
			try
			{
				SHA512Managed sHA512Managed = new SHA512Managed();
				byte_0 = sHA512Managed.ComputeHash(Encoding.UTF8.GetBytes(string_1 + "|" + string_0.ToLower()));
				string_2 = "";
				byte[] array2 = byte_0;
				foreach (byte b in array2)
				{
					string_2 += $"{b:X2}";
				}
				LogLine("Logging in");
				@class = Class4.smethod_0(string_0, string_2, string_3, fileVersionInfo.FileMajorPart, fileVersionInfo.FileMinorPart, fileVersionInfo.FileBuildPart, fileVersionInfo.FilePrivatePart);
				if (!@class.bool_0)
				{
					throw new Exception(@class.string_0);
				}
			}
			catch (Exception ex3)
			{
				LogLine("Unable to login: {0}", ex3.Message);
				throw ex3;
			}
			hashtable_2 = null;
			hashtable_3 = null;
			hashtable_4 = null;
			hashtable_5 = null;
			class11_0 = new Class11(this);
			class3_0 = new Class3(this, @class.guid_0);
			class2_0 = new Class2(this, @class.guid_0);
			bool_3 = false;
			foreach (WoW_Object value in hashtable_0.Values)
			{
				value.bool_0 = true;
			}
			hashtable_0.Clear();
			hashtable_1.Clear();
			class10_0 = new Class10(this);
			class9_0 = new Class9(this);
			woW_Buffs_0 = new WoW_Buffs(this);
			woW_Loot_0 = new WoW_Loot(this);
			woW_Descriptors_0 = new WoW_Descriptors(this);
			manualResetEvent_0 = new ManualResetEvent(initialState: false);
			thread_0 = new Thread(method_0);
			thread_0.Start();
			LogLine("Waiting for first update to finish");
			if (!manualResetEvent_0.WaitOne(30000, exitContext: false))
			{
				LogLine("Update thread has taken longer then 30s.");
			}
			bool_2 = true;
			LogLine("Started WoW!Sharp");
		}
		catch (Exception ex4)
		{
			class12_0.Dispose();
			class12_0 = null;
			throw ex4;
		}
		return true;
	}

	private void method_0()
	{
		while (!bool_3)
		{
			try
			{
				int num = 0;
				ArrayList arrayList = new ArrayList();
				Hashtable hashtable = new Hashtable();
				Hashtable hashtable2 = new Hashtable();
				if (memoryReader_0.IsOpen)
				{
					class9_0.method_0();
					class10_0.method_0();
					class11_0.int_0 = memoryReader_0.ReadInteger(class3_0.method_0("g_factionDB"));
					class11_0.int_1 = memoryReader_0.ReadInteger(class3_0.method_0("g_factionGroupDB"));
					long num2 = memoryReader_0.ReadLong(class3_0.method_0("CGGameUI__m_player"));
					long num3 = memoryReader_0.ReadLong(class3_0.method_0("CGGameUI__m_lockedTarget"));
					int num4 = memoryReader_0.ReadInteger(class3_0.method_0("s_curMgr"));
					int num5 = class2_0.method_0("s_curMgr_NextObject");
					int num6 = num4 + (class2_0.method_0("s_curMgr_FirstObject") - num5);
					while (!bool_3 && num4 > 0)
					{
						num6 = memoryReader_0.ReadInteger(num6 + num5);
						if (((uint)num6 & (true ? 1u : 0u)) != 0 || num6 == 0 || num6 == 28)
						{
							break;
						}
						WoW_Object woW_Object = null;
						if (hashtable_0.Contains(num6))
						{
							woW_Object = (WoW_Object)hashtable_0[num6];
							if (!woW_Object.Update())
							{
								woW_Object = null;
							}
						}
						if (woW_Object == null)
						{
							woW_Object = new WoW_Object(num6, this);
							woW_Object.Update();
						}
						if (woW_Object.GUID.GUID == num2)
						{
							class11_0.woW_Object_0 = woW_Object;
						}
						else if (woW_Object.Int64_0 == num2)
						{
							if (woW_Object.Type == WoW_ObjectTypes.Player)
							{
								if (Player == null || GetUnitReaction(Player, woW_Object) == 1)
								{
									num++;
									arrayList.Add(woW_Object);
								}
							}
							else
							{
								num++;
								arrayList.Add(woW_Object);
							}
						}
						if (woW_Object.GUID.GUID == num3)
						{
							class11_0.woW_Object_1 = woW_Object;
						}
						hashtable2.Add(num6, woW_Object);
						if (!hashtable.Contains(woW_Object.GUID.GUID))
						{
							hashtable.Add(woW_Object.GUID.GUID, woW_Object);
							continue;
						}
						LogLine("Duplicate GUID: {0:X}", woW_Object.GUID.GUID);
					}
					if (class11_0.woW_Object_0 != null && class11_0.woW_Object_0.GUID.GUID != num2)
					{
						class11_0.woW_Object_0 = null;
					}
					if (class11_0.woW_Object_1 != null && class11_0.woW_Object_1.GUID.GUID != num3)
					{
						class11_0.woW_Object_1 = null;
					}
				}
				ArrayList arrayList2 = new ArrayList(arrayList.Count);
				if (Player != null)
				{
					foreach (WoW_Object item in arrayList)
					{
						float distance = Player.GetDistance(item);
						arrayList2.Add(new WoW_Distance(distance, item));
					}
				}
				arrayList2.Sort();
				hashtable_1 = hashtable;
				hashtable_0 = hashtable2;
				int_1 = num;
				arrayList_0 = arrayList2;
				woW_Inventory_0.method_0();
				ArrayList arrayList3 = new ArrayList();
				for (int i = 0; i < 4; i++)
				{
					long num7 = memoryReader_0.ReadLong(class3_0.method_0("CGPartyInfo__m_members") + i * 8);
					WoW_Object woW_Object2 = null;
					if (num7 != 0L)
					{
						woW_Object2 = (WoW_Object)hashtable_1[num7];
					}
					if (woW_Object2 != null)
					{
						arrayList3.Add(woW_Object2);
					}
				}
				if (arrayList3.Count > 0)
				{
					arrayList3.Add(class11_0.woW_Object_0);
				}
				arrayList_1 = arrayList3;
				long num8 = memoryReader_0.ReadLong(class3_0.method_0("CGPartyInfo__m_leader"));
				if (num8 != 0L)
				{
					woW_Object_0 = (WoW_Object)hashtable_1[num8];
				}
				manualResetEvent_0.Set();
				if (woW_SharpEvent_0 != null)
				{
					try
					{
						woW_SharpEvent_0(this);
					}
					catch (Exception ex)
					{
						LogLine("Exception in AfterUpdate.");
						LogLine("Message: {0}", ex.Message);
						LogLine("Source: {0}", ex.Source);
					}
				}
				Thread.Sleep(int_0);
			}
			catch (OutOfMemoryException ex2)
			{
				LogLine("Exception in updateProc: {0}", ex2.Message);
				LogLine("Totals: {0} objects, {1} itemnames, {2} playernames", Objects.Count, class10_0.Count, class9_0.Count);
			}
			catch (Exception ex3)
			{
				LogLine("Exception in updateProc: {0}", ex3.Message);
			}
		}
	}

	public void Stop()
	{
		if (bool_2)
		{
			LogLine("Stopping WoW!Sharp");
			if (bool_1)
			{
				EjectCode();
			}
			bool_3 = true;
			thread_0.Join();
			if (memoryReader_0.IsOpen)
			{
				memoryReader_0.method_3();
			}
			LogLine("Stopped WoW!Sharp");
			class12_0.Dispose();
			class12_0 = null;
			bool_2 = false;
		}
	}

	public WoW()
	{
		woW_Inventory_0 = new WoW_Inventory(this);
		hashtable_1 = new Hashtable();
		hashtable_0 = new Hashtable();
		memoryReader_0 = new MemoryReader();
		memoryReader_0.method_1();
		woW_ChatLog_0 = new WoW_ChatLog(this);
	}

	~WoW()
	{
		if (bool_1)
		{
			EjectCode();
		}
		if (bool_2)
		{
			Stop();
		}
	}

	public bool InjectCode()
	{
		if (!bool_2)
		{
			return false;
		}
		if (bool_1)
		{
			return false;
		}
		Class1.SetChatlogPath(Environment.CurrentDirectory + "\\chat.log");
		Class1.SetClearTargetPtr(class3_0.method_0("CGGameUI__ClearTarget"));
		Class1.SetFrameScriptExecutePtr(class3_0.method_0("FrameScript_Execute"));
		Class1.SetDetourPtr(class3_0.method_0("CGWorldFrame__RenderWorld"));
		Class1.SetAddChatMessagePtr(class3_0.method_0("CGChat__AddChatMessage"));
		Class1.SetRightClickPtr(class3_0.method_0("CGGameUI__RightClick"));
		Class1.SetLeftClickPtr(class3_0.method_0("CGGameUI__LeftClick"));
		Class1.SetLootSlotPtr(class3_0.method_0("CGLootInfo__LootSlot"));
		Class1.SetAutoStoreAllLootItemsPtr(class3_0.method_0("AutoStoreAllLootItems"));
		Class1.SetCastSpellByIDPtr(class3_0.method_0("Spell_C_CastSpellByID"));
		Class1.SetOsGetAsyncTimeMsPtr(class3_0.method_0("OsGetAsyncTimeMs"));
		Class1.SetMovementPtr(class3_0.method_0("CGInputControl__GetActive"), class3_0.method_0("CGInputControl__SetControlBit"));
		Class1.SetAntiAFKPtr(class3_0.method_0("s_currentWorldFrame"), class2_0.method_0("s_currentWorldFrame_AntiAFK_1"), class2_0.method_0("s_currentWorldFrame_AntiAFK_2"));
		int num = Class1.InjectExecuteDLL(memoryReader_0.intptr_1);
		bool_1 = num == 0;
		ChatLog.Reset();
		return bool_1;
	}

	public bool EjectCode()
	{
		if (!bool_1)
		{
			return false;
		}
		Class1.EjectExecuteDLL(memoryReader_0.intptr_1);
		bool_1 = false;
		return true;
	}

	public void RightClick(WoW_Object woW_Object_1)
	{
		if (bool_1)
		{
			Class1.RightClickTarget(woW_Object_1.GUID.GUID);
		}
	}

	public void ClearTarget()
	{
		if (bool_1 && Target != null)
		{
			Class1.ClearTarget(Target.GUID.GUID);
		}
	}

	public void LeftClick(WoW_Object woW_Object_1)
	{
		if (bool_1)
		{
			Class1.LeftClickTarget(woW_Object_1.GUID.GUID);
		}
	}

	public bool CastSpellByName(string string_4)
	{
		if (!bool_1)
		{
			return false;
		}
		int num = 0;
		if (KnownSpells.Contains(string_4))
		{
			num = (int)KnownSpells[string_4];
		}
		if (HighestKnownSpells.Contains(string_4))
		{
			num = (int)HighestKnownSpells[string_4];
		}
		if (KnownPetSpells.Contains(string_4))
		{
			num = (int)KnownPetSpells[string_4];
		}
		if (HighestKnownPetSpells.Contains(string_4))
		{
			num = (int)HighestKnownPetSpells[string_4];
		}
		if (num == 0)
		{
			return false;
		}
		CastSpellByID(num);
		return true;
	}

	public void CastSpellByID(int int_2)
	{
		if (bool_1)
		{
			Class1.CastSpellByID(int_2);
		}
	}

	public void SendScript(string string_4)
	{
		if (bool_1)
		{
			Class1.SendScript(string_4);
		}
	}

	public void StartMovement(WoW_Movement woW_Movement_0)
	{
		if (bool_1)
		{
			Class1.StartMovement((int)woW_Movement_0);
		}
	}

	public void StopMovement(WoW_Movement woW_Movement_0)
	{
		if (bool_1)
		{
			Class1.StopMovement((int)woW_Movement_0);
		}
	}

	public void TimedMovement(WoW_Movement woW_Movement_0, int int_2)
	{
		if (bool_1)
		{
			Class1.TimedMovement((int)woW_Movement_0, int_2);
			Thread.Sleep(int_2);
		}
	}

	internal float method_1(float float_2, float float_3, bool bool_4, out bool bool_5)
	{
		float float_4 = class11_0.woW_Object_0.method_2(float_2, float_3) + (bool_4 ? ((float)Math.PI) : 0f);
		return method_2(float_4, bool_4, out bool_5);
	}

	internal float method_2(float float_2, bool bool_4, out bool bool_5)
	{
		float num = class11_0.woW_Object_0.Facing;
		while (float_2 < 0f)
		{
			float_2 += (float)Math.PI * 2f;
		}
		while (float_2 > (float)Math.PI * 2f)
		{
			float_2 -= (float)Math.PI * 2f;
		}
		for (; num < 0f; num += (float)Math.PI * 2f)
		{
		}
		while (num > (float)Math.PI * 2f)
		{
			num -= (float)Math.PI * 2f;
		}
		float num2 = float_2 - num;
		if (num2 < 0f)
		{
			num2 += (float)Math.PI * 2f;
		}
		float num3 = num - float_2;
		if (num3 < 0f)
		{
			num3 += (float)Math.PI * 2f;
		}
		bool_5 = true;
		float result = num3;
		if (num2 < num3)
		{
			result = num2;
			bool_5 = false;
		}
		return result;
	}

	public void Face(WoW_Object woW_Object_1)
	{
		Face(woW_Object_1.X, woW_Object_1.Y);
	}

	public void Face(float float_2, float float_3)
	{
		if (bool_1 && class11_0.woW_Object_0 != null)
		{
			class11_0.woW_Object_0.Update();
			bool bool_ = true;
			float num = method_1(float_2, float_3, bool_4: false, out bool_);
			float num2 = num / 0.00328125f;
			if (!(num2 < 10f))
			{
				TimedMovement(bool_ ? WoW_Movement.Right : WoW_Movement.Left, (int)num2);
				class11_0.woW_Object_0.Update();
			}
		}
	}

	public void FaceAway(WoW_Object woW_Object_1, WoW_Object woW_Object_2)
	{
		if (bool_1 && class11_0.woW_Object_0 != null)
		{
			class11_0.woW_Object_0.Update();
			float num = class11_0.woW_Object_0.method_2(woW_Object_1.X, woW_Object_1.Y);
			float num2 = class11_0.woW_Object_0.method_2(woW_Object_2.X, woW_Object_2.Y);
			for (; num < 0f; num += (float)Math.PI * 2f)
			{
			}
			while (num > (float)Math.PI * 2f)
			{
				num -= (float)Math.PI * 2f;
			}
			for (; num2 < 0f; num2 += (float)Math.PI * 2f)
			{
			}
			while (num2 > (float)Math.PI * 2f)
			{
				num2 -= (float)Math.PI * 2f;
			}
			float num3 = 0f;
			if (num > num2)
			{
				float num4 = num - num2;
				num3 = num2 + num4 / 2f;
			}
			else
			{
				float num5 = num2 - num;
				num3 = num + num5 / 2f;
			}
			bool bool_ = true;
			float num6 = method_2(num3, bool_4: true, out bool_);
			float num7 = num6 / 0.00328125f;
			if (!(num7 < 10f))
			{
				TimedMovement(bool_ ? WoW_Movement.Right : WoW_Movement.Left, (int)num7);
				class11_0.woW_Object_0.Update();
			}
		}
	}

	public void FaceAway(float float_2, float float_3)
	{
		if (bool_1 && class11_0.woW_Object_0 != null)
		{
			class11_0.woW_Object_0.Update();
			bool bool_ = true;
			float num = method_1(float_2, float_3, bool_4: true, out bool_);
			float num2 = num / 0.00328125f;
			if (!(num2 < 10f))
			{
				TimedMovement(bool_ ? WoW_Movement.Right : WoW_Movement.Left, (int)num2);
				class11_0.woW_Object_0.Update();
			}
		}
	}

	public void MoveTo(WoW_Object woW_Object_1, float float_2, bool bool_4, bool bool_5)
	{
		if (!bool_1 || class11_0.woW_Object_0 == null)
		{
			return;
		}
		woW_Object_1.Update();
		class11_0.woW_Object_0.Update();
		float distance = class11_0.woW_Object_0.GetDistance(woW_Object_1.X, woW_Object_1.Y, woW_Object_1.Z);
		if (distance < float_2)
		{
			if (bool_4)
			{
				StopMovement(WoW_Movement.Forward);
			}
			Face(woW_Object_1.X, woW_Object_1.Y);
			return;
		}
		float x = woW_Object_1.X;
		float y = woW_Object_1.Y;
		bool bool_6 = false;
		float num = method_1(x, y, bool_4: false, out bool_6);
		float num2 = 0f;
		if ((double)num > Math.PI / 2.0)
		{
			Face(woW_Object_1.X, woW_Object_1.Y);
			class11_0.woW_Object_0.Update();
			woW_Object_1.Update();
			float x2 = woW_Object_1.X;
			float y2 = woW_Object_1.Y;
			bool_6 = false;
			num = method_1(x2, y2, bool_4: false, out bool_6);
		}
		num2 = num / 0.00328125f;
		StartMovement(WoW_Movement.Forward);
		int num3 = 0;
		int num4 = 0;
		int health = class11_0.woW_Object_0.Health;
		while (distance > float_2 && bool_1 && !class11_0.woW_Object_0.IsDead)
		{
			float x3 = class11_0.woW_Object_0.X;
			float y3 = class11_0.woW_Object_0.Y;
			float z = class11_0.woW_Object_0.Z;
			if (num2 > 10f)
			{
				if ((double)(distance - float_2) < 1.6)
				{
					LogLine("Stop to face at distance: {0}", distance - float_2);
					StopMovement(WoW_Movement.Forward);
					Face(woW_Object_1.X, woW_Object_1.Y);
					StartMovement(WoW_Movement.Forward);
				}
				else
				{
					Face(woW_Object_1.X, woW_Object_1.Y);
				}
			}
			else
			{
				Thread.Sleep(100);
				class11_0.woW_Object_0.Update();
				woW_Object_1.Update();
				float distance2 = class11_0.woW_Object_0.GetDistance(x3, y3, z);
				if ((double)distance2 < (double)class11_0.woW_Object_0.Speed * 0.05)
				{
					StartMovement(WoW_Movement.Forward);
					num4 = 0;
					num3++;
					if (num3 == 5)
					{
						TimedMovement(WoW_Movement.StrafeLeft, 500);
					}
					if (num3 == 15)
					{
						TimedMovement(WoW_Movement.StrafeRight, 500);
					}
					if (num3 == 25)
					{
						num2 = 478.7189f;
						StopMovement(WoW_Movement.Forward);
						FaceAway(woW_Object_1.X, woW_Object_1.Y);
						TimedMovement(WoW_Movement.Forward, 500);
						TimedMovement(WoW_Movement.Right, 478);
						TimedMovement(WoW_Movement.Forward, 1500);
						Face(woW_Object_1.X, woW_Object_1.Y);
						StartMovement(WoW_Movement.Forward);
					}
					if (num3 == 35)
					{
						bool_4 = true;
						break;
					}
				}
				else
				{
					num4++;
					if (num4 > 5)
					{
						num3 = 0;
					}
				}
			}
			class11_0.woW_Object_0.Update();
			woW_Object_1.Update();
			distance = class11_0.woW_Object_0.GetDistance(woW_Object_1.X, woW_Object_1.Y, woW_Object_1.Z);
			float x4 = woW_Object_1.X;
			float y4 = woW_Object_1.Y;
			bool_6 = false;
			num = method_1(x4, y4, bool_4: false, out bool_6);
			num2 = num / 0.00328125f;
			if (bool_5 && health > class11_0.woW_Object_0.Health)
			{
				break;
			}
			health = class11_0.woW_Object_0.Health;
		}
		Face(woW_Object_1.X, woW_Object_1.Y);
		if (bool_4)
		{
			StopMovement(WoW_Movement.Forward);
		}
	}

	public void MoveTo(float float_2, float float_3, float float_4, float float_5, bool bool_4, bool bool_5)
	{
		if (!bool_1 || class11_0.woW_Object_0 == null)
		{
			return;
		}
		class11_0.woW_Object_0.Update();
		float distance = class11_0.woW_Object_0.GetDistance(float_2, float_3, float_4);
		if (distance < float_5)
		{
			if (bool_4)
			{
				StopMovement(WoW_Movement.Forward);
			}
			Face(float_2, float_3);
			return;
		}
		bool bool_6 = false;
		float num = method_1(float_2, float_3, bool_4: false, out bool_6);
		float num2 = 0f;
		if ((double)num > Math.PI / 2.0)
		{
			Face(float_2, float_3);
			class11_0.woW_Object_0.Update();
			bool_6 = false;
			num = method_1(float_2, float_3, bool_4: false, out bool_6);
		}
		num2 = num / 0.00328125f;
		StartMovement(WoW_Movement.Forward);
		int num3 = 0;
		int num4 = 0;
		int health = class11_0.woW_Object_0.Health;
		while (distance > float_5 && bool_1 && !class11_0.woW_Object_0.IsDead)
		{
			float x = class11_0.woW_Object_0.X;
			float y = class11_0.woW_Object_0.Y;
			float z = class11_0.woW_Object_0.Z;
			if (num2 > 10f)
			{
				if ((double)(distance - float_5) < 1.6)
				{
					LogLine("Stop to face at distance: {0}", distance - float_5);
					StopMovement(WoW_Movement.Forward);
					Face(float_2, float_3);
					StartMovement(WoW_Movement.Forward);
				}
				else
				{
					Face(float_2, float_3);
				}
			}
			else
			{
				Thread.Sleep(100);
				class11_0.woW_Object_0.Update();
				float distance2 = class11_0.woW_Object_0.GetDistance(x, y, z);
				if ((double)distance2 < (double)class11_0.woW_Object_0.Speed * 0.05)
				{
					StartMovement(WoW_Movement.Forward);
					num4 = 0;
					num3++;
					if (num3 == 5)
					{
						TimedMovement(WoW_Movement.StrafeLeft, 500);
					}
					if (num3 == 15)
					{
						TimedMovement(WoW_Movement.StrafeRight, 500);
					}
					if (num3 == 25)
					{
						num2 = 478.7189f;
						StopMovement(WoW_Movement.Forward);
						FaceAway(float_2, float_3);
						TimedMovement(WoW_Movement.Forward, 500);
						TimedMovement(WoW_Movement.Right, 478);
						TimedMovement(WoW_Movement.Forward, 1500);
						Face(float_2, float_3);
						StartMovement(WoW_Movement.Forward);
					}
					if (num3 == 35)
					{
						bool_4 = true;
						break;
					}
				}
				else
				{
					num4++;
					if (num4 > 5)
					{
						num3 = 0;
					}
				}
			}
			class11_0.woW_Object_0.Update();
			distance = class11_0.woW_Object_0.GetDistance(float_2, float_3, float_4);
			bool_6 = false;
			num = method_1(float_2, float_3, bool_4: false, out bool_6);
			num2 = num / 0.00328125f;
			if (bool_5 && health > class11_0.woW_Object_0.Health)
			{
				break;
			}
			health = class11_0.woW_Object_0.Health;
		}
		Face(float_2, float_3);
		if (bool_4)
		{
			StopMovement(WoW_Movement.Forward);
		}
	}

	internal int method_3()
	{
		if (!bool_1)
		{
			return -1;
		}
		return Class1.GetFrequency();
	}

	internal float method_4()
	{
		if (!bool_1)
		{
			return -1f;
		}
		return Class1.GetAvgFrequency();
	}

	public int GetUnitReaction(WoW_Object woW_Object_1, WoW_Object woW_Object_2)
	{
		if (woW_Object_1.Type != WoW_ObjectTypes.Unit && woW_Object_1.Type != WoW_ObjectTypes.Player)
		{
			return -1;
		}
		if (woW_Object_2.Type != WoW_ObjectTypes.Unit && woW_Object_2.Type != WoW_ObjectTypes.Player)
		{
			return -2;
		}
		int num = woW_Object_1.method_0();
		int num2 = woW_Object_2.method_0();
		if ((memoryReader_0.ReadInteger(num + 12) & memoryReader_0.ReadInteger(num2 + 20)) != 0)
		{
			return 1;
		}
		int num3 = num2 + 24;
		for (int i = 0; i < 4; i++)
		{
			if (memoryReader_0.ReadInteger(num3) == 0)
			{
				break;
			}
			if (memoryReader_0.ReadInteger(num3) != memoryReader_0.ReadInteger(num + 4))
			{
				num3 += 4;
				continue;
			}
			return 1;
		}
		if ((memoryReader_0.ReadInteger(num + 12) & memoryReader_0.ReadInteger(num2 + 16)) != 0)
		{
			return 4;
		}
		num3 = num2 + 40;
		for (int j = 0; j < 4; j++)
		{
			if (memoryReader_0.ReadInteger(num3) == 0)
			{
				break;
			}
			if (memoryReader_0.ReadInteger(num3) != memoryReader_0.ReadInteger(num + 4))
			{
				num3 += 4;
				continue;
			}
			return 4;
		}
		if ((memoryReader_0.ReadInteger(num2 + 12) & memoryReader_0.ReadInteger(num + 20)) != 0)
		{
			return 4;
		}
		num3 = num + 40;
		for (int k = 0; k < 4; k++)
		{
			if (memoryReader_0.ReadInteger(num3) == 0)
			{
				break;
			}
			if (memoryReader_0.ReadInteger(num3) != memoryReader_0.ReadInteger(num2 + 4))
			{
				num3 += 4;
				continue;
			}
			return 4;
		}
		return 3;
	}

	public ArrayList GetNearest(WoW_Object woW_Object_1, int int_2, WoW_ObjectTypes woW_ObjectTypes_0)
	{
		return GetNearest(woW_Object_1.X, woW_Object_1.Y, woW_Object_1.Z, int_2, woW_ObjectTypes_0);
	}

	public ArrayList GetNearest(float float_2, float float_3, float float_4, int int_2, WoW_ObjectTypes woW_ObjectTypes_0)
	{
		ArrayList arrayList = new ArrayList();
		if (!bool_2)
		{
			return null;
		}
		foreach (WoW_Object value in hashtable_1.Values)
		{
			float distance = value.GetDistance(float_2, float_3, float_4);
			if (distance < (float)int_2 && value.X != float_2 && value.Y != float_3 && (woW_ObjectTypes_0 == WoW_ObjectTypes.Unknown || woW_ObjectTypes_0 == value.Type))
			{
				arrayList.Add(new WoW_Distance(distance, value));
			}
		}
		arrayList.Sort();
		return arrayList;
	}

	public void ActivateGame()
	{
		if (memoryReader_0.IsOpen)
		{
			Interaction.AppActivate(memoryReader_0.ReadProcess.Id);
		}
		else
		{
			Interaction.AppActivate("World of Warcraft");
		}
	}

	public string GetSpellName(int int_2, bool bool_4)
	{
		int num = memoryReader_0.ReadInteger(class3_0.method_0("WOW_LOCALE_CURRENT_LANGUAGE"));
		int num2 = memoryReader_0.ReadInteger(class3_0.method_0("g_SpellDB"));
		int num3 = memoryReader_0.ReadInteger(class3_0.method_0("g_SpellDBTotalRows"));
		if (int_2 > 0 && int_2 <= num3)
		{
			int num4 = memoryReader_0.ReadInteger(num2 + int_2 * 4);
			int int_3 = memoryReader_0.ReadInteger(num4 + num * 4 + class2_0.method_0("spellDB_spellName") * 4);
			string text = memoryReader_0.ReadString(int_3, 128);
			if (bool_4)
			{
				int int_4 = memoryReader_0.ReadInteger(num4 + num * 4 + class2_0.method_0("spellDB_spellRank") * 4);
				string text2 = memoryReader_0.ReadString(int_4, 128);
				if (text2 != "")
				{
					text = text + "(" + text2 + ")";
				}
			}
			return text;
		}
		return "";
	}

	private Hashtable method_5(int int_2, bool bool_4)
	{
		Hashtable hashtable = new Hashtable();
		for (int i = 0; i < 1024; i++)
		{
			int num = memoryReader_0.ReadInteger(int_2 + i * 4);
			string spellName = GetSpellName(num, !bool_4);
			if (!(spellName == ""))
			{
				if (hashtable.ContainsKey(spellName))
				{
					hashtable[spellName] = num;
				}
				else
				{
					hashtable.Add(spellName, num);
				}
			}
		}
		return hashtable;
	}

	public ArrayList GetKnownSpellNames(bool bool_4)
	{
		ArrayList arrayList = new ArrayList();
		Hashtable hashtable = ((!bool_4) ? HighestKnownSpells : KnownSpells);
		foreach (string key in hashtable.Keys)
		{
			arrayList.Add(key);
		}
		return arrayList;
	}

	public ArrayList GetKnownPetSpellNames(bool bool_4)
	{
		ArrayList arrayList = new ArrayList();
		Hashtable hashtable = ((!bool_4) ? HighestKnownPetSpells : KnownPetSpells);
		foreach (string key in hashtable.Keys)
		{
			arrayList.Add(key);
		}
		return arrayList;
	}

	public string GetRedMessage()
	{
		string text = memoryReader_0.ReadString(class3_0.method_0("CGGameUI__s_lastErrorString"), 128);
		if (text != "You are Dead" && text != "")
		{
			memoryReader_0.WriteString(class3_0.method_0("CGGameUI__s_lastErrorString"), "You are Dead");
			return text;
		}
		return "";
	}

	public int GetDifficulty(WoW_Object woW_Object_1)
	{
		int[] array = new int[20]
		{
			4, 4, 5, 5, 6, 6, 7, 7, 8, 9,
			10, 11, 12, 12, 12, 12, 12, 12, 12, 12
		};
		long num = class11_0.woW_Object_0.Level * 1717986919L >> 33;
		if (num >= array.Length)
		{
			num = array.Length - 1;
		}
		int num2 = woW_Object_1.Level - class11_0.woW_Object_0.Level;
		if (num2 >= 5)
		{
			return 4;
		}
		if (num2 >= 3)
		{
			return 3;
		}
		if (num2 >= -2)
		{
			return 2;
		}
		if (-num2 <= array[num])
		{
			return 1;
		}
		return 0;
	}

	public void LogLine(string string_4, params object[] object_0)
	{
		StringWriter stringWriter = new StringWriter();
		stringWriter.Write(string_4, object_0);
		string string_5 = stringWriter.ToString();
		LogLine(string_5);
	}

	public void LogLine(string string_4)
	{
		string_4 = string.Concat(DateTime.Now, "|", string_4);
		Trace.WriteLineIf(condition: true, string_4);
		if (onLogLineDelegate_0 != null)
		{
			onLogLineDelegate_0(this, string_4);
		}
		if (class12_0 != null)
		{
			class12_0.method_4(string_4);
			return;
		}
		Class12 @class = new Class12("debug.log");
		@class.Boolean_0 = true;
		@class.method_4(string_4);
		@class.Dispose();
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal class Class1
{
	[DllImport("WoW!Execute")]
	internal static extern void SetDetourPtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetAddChatMessagePtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetRightClickPtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetLeftClickPtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetClearTargetPtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetLootSlotPtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetAutoStoreAllLootItemsPtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetFrameScriptExecutePtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetCastSpellByIDPtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetOsGetAsyncTimeMsPtr(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void SetMovementPtr(int int_0, int int_1);

	[DllImport("WoW!Execute")]
	internal static extern void SetAntiAFKPtr(int int_0, int int_1, int int_2);

	[DllImport("WoW!Execute")]
	internal static extern int InjectExecuteDLL(IntPtr intptr_0);

	[DllImport("WoW!Execute")]
	internal static extern int EjectExecuteDLL(IntPtr intptr_0);

	[DllImport("WoW!Execute")]
	internal static extern void RightClickTarget(long long_0);

	[DllImport("WoW!Execute")]
	internal static extern void LeftClickTarget(long long_0);

	[DllImport("WoW!Execute")]
	internal static extern void ClearTarget(long long_0);

	[DllImport("WoW!Execute")]
	internal static extern void PickupLoot(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void PickupAllLoot();

	[DllImport("WoW!Execute")]
	internal static extern void SendScript(string string_0);

	[DllImport("WoW!Execute")]
	internal static extern void CastSpellByID(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern void LuaNoReturn(int int_0, int int_1);

	[DllImport("WoW!Execute")]
	internal static extern void LuaNoReturnSetDWORD(int int_0, int int_1, int int_2, float float_0);

	[DllImport("WoW!Execute")]
	internal static extern int GetAsyncTimeMs();

	[DllImport("WoW!Execute")]
	internal static extern int StartMovement(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern int StopMovement(int int_0);

	[DllImport("WoW!Execute")]
	internal static extern int TimedMovement(int int_0, int int_1);

	[DllImport("WoW!Execute")]
	internal static extern void UnhideDll();

	[DllImport("WoW!Execute")]
	internal static extern int GetCurrentEvent();

	[DllImport("WoW!Execute")]
	internal static extern bool SetChatlogPath(string string_0);

	[DllImport("WoW!Execute")]
	internal static extern void GetChatlogPath(StringBuilder stringBuilder_0);

	[DllImport("WoW!Execute")]
	internal static extern int GetFrequency();

	[DllImport("WoW!Execute")]
	internal static extern float GetAvgFrequency();
}

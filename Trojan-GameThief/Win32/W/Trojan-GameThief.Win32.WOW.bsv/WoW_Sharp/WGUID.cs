using System.Runtime.InteropServices;

namespace WoW_Sharp;

[StructLayout(LayoutKind.Explicit)]
public struct WGUID
{
	[FieldOffset(0)]
	public long GUID;

	[FieldOffset(0)]
	public int Low;

	[FieldOffset(4)]
	public int High;
}

using System;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 28)]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
[CLSCompliant(false)]
public struct GStruct3
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	public struct iterator
	{
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	public struct const_iterator
	{
	}
}

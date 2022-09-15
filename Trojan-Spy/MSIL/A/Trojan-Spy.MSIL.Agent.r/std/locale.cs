using System;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
[MiscellaneousBits(64)]
[CLSCompliant(false)]
[DebugInfoInPDB]
public struct locale
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	public struct id
	{
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	public struct facet
	{
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 52)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	public struct _Locimp
	{
	}
}

using System;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
[DebugInfoInPDB]
[CLSCompliant(false)]
[MiscellaneousBits(64)]
public struct ios_base
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	public struct failure
	{
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
	[MiscellaneousBits(65)]
	[DebugInfoInPDB]
	public struct _Iosarray
	{
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	[MiscellaneousBits(65)]
	[DebugInfoInPDB]
	public struct _Fnarray
	{
	}
}

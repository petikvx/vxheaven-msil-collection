using System;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
[CLSCompliant(false)]
[DebugInfoInPDB]
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
	[DebugInfoInPDB]
	[MiscellaneousBits(65)]
	public struct _Iosarray
	{
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
	[DebugInfoInPDB]
	[MiscellaneousBits(65)]
	public struct _Fnarray
	{
	}
}

using System;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 60)]
[CLSCompliant(false)]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
public struct GStruct8
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	public struct sentry
	{
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	public struct _Sentry_base
	{
	}
}

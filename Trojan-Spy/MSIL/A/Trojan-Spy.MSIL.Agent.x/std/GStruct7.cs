using System;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 56)]
[CLSCompliant(false)]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
public struct GStruct7
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	public struct sentry
	{
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	public struct _Sentry_base
	{
	}
}

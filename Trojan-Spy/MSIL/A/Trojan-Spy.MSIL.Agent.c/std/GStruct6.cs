using System;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 56)]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
[CLSCompliant(false)]
public struct GStruct6
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
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

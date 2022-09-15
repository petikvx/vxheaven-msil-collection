using System;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
[MiscellaneousBits(64)]
[CLSCompliant(false)]
[DebugInfoInPDB]
public struct bad_alloc
{
}

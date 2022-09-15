using System;

namespace DevComponents.DotNetBar;

[Flags]
public enum eBorderSide
{
	None = 0,
	Left = 1,
	Right = 2,
	Top = 4,
	Bottom = 8,
	All = 0xF
}

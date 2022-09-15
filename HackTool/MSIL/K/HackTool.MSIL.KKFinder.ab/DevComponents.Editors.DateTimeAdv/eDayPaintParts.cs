using System;

namespace DevComponents.Editors.DateTimeAdv;

[Flags]
public enum eDayPaintParts
{
	None = 0,
	Background = 1,
	Text = 2,
	Image = 4,
	All = 7
}

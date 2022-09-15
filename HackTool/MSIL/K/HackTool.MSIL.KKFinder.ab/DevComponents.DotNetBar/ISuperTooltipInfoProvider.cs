using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public interface ISuperTooltipInfoProvider
{
	Rectangle ComponentRectangle { get; }

	event EventHandler DisplayTooltip;

	event EventHandler HideTooltip;
}

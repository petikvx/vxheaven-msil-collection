using System;

namespace DevComponents.AdvTree;

public interface ICellEditControl
{
	object CurrentValue { get; set; }

	bool EditWordWrap { get; set; }

	event EventHandler EditComplete;

	event EventHandler CancelEdit;

	void BeginEdit();

	void EndEdit();
}

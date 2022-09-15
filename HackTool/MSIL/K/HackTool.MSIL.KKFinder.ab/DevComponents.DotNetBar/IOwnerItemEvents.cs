using System;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public interface IOwnerItemEvents
{
	void InvokeItemAdded(BaseItem item, EventArgs e);

	void InvokeItemRemoved(BaseItem item, BaseItem parent);

	void InvokeMouseEnter(BaseItem item, EventArgs e);

	void InvokeMouseHover(BaseItem item, EventArgs e);

	void InvokeMouseLeave(BaseItem item, EventArgs e);

	void InvokeMouseDown(BaseItem item, MouseEventArgs e);

	void InvokeMouseUp(BaseItem item, MouseEventArgs e);

	void InvokeMouseMove(BaseItem item, MouseEventArgs e);

	void InvokeItemClick(BaseItem objItem);

	void InvokeGotFocus(BaseItem item, EventArgs e);

	void InvokeLostFocus(BaseItem item, EventArgs e);

	void InvokeExpandedChange(BaseItem item, EventArgs e);

	void InvokeItemTextChanged(BaseItem item, EventArgs e);

	void InvokeContainerControlDeserialize(BaseItem item, ControlContainerSerializationEventArgs e);

	void InvokeContainerControlSerialize(BaseItem item, ControlContainerSerializationEventArgs e);

	void InvokeContainerLoadControl(BaseItem item, EventArgs e);

	void InvokeOptionGroupChanging(BaseItem item, OptionGroupChangingEventArgs e);

	void InvokeToolTipShowing(object sender, EventArgs e);

	void InvokeCheckedChanged(ButtonItem item, EventArgs e);
}

using System;

namespace DevComponents.DotNetBar;

public interface IOwnerMenuSupport
{
	bool PersonalizedAllVisible { get; set; }

	bool ShowFullMenusOnHover { get; set; }

	bool AlwaysShowFullMenus { get; set; }

	bool ShowPopupShadow { get; }

	eMenuDropShadow MenuDropShadow { get; set; }

	ePopupAnimation PopupAnimation { get; set; }

	bool AlphaBlendShadow { get; set; }

	void RegisterPopup(PopupItem objPopup);

	void UnregisterPopup(PopupItem objPopup);

	bool RelayMouseHover();

	void InvokePopupClose(PopupItem item, EventArgs e);

	void InvokePopupContainerLoad(PopupItem item, EventArgs e);

	void InvokePopupContainerUnload(PopupItem item, EventArgs e);

	void InvokePopupOpen(PopupItem item, PopupOpenEventArgs e);

	void InvokePopupShowing(PopupItem item, EventArgs e);

	void ClosePopups();
}

using System;
using System.Collections;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public interface IOwner
{
	Form ParentForm { get; set; }

	ImageList Images { get; set; }

	ImageList ImagesMedium { get; set; }

	ImageList ImagesLarge { get; set; }

	BaseItem DragItem { get; }

	bool DragInProgress { get; }

	bool ShowToolTips { get; set; }

	bool ShowShortcutKeysInToolTips { get; set; }

	bool AlwaysDisplayKeyAccelerators { get; set; }

	Form ActiveMdiChild { get; }

	bool ShowResetButton { get; set; }

	bool DesignMode { get; }

	bool DisabledImagesGrayScale { get; set; }

	ArrayList GetItems(string ItemName);

	ArrayList GetItems(string ItemName, Type itemType);

	ArrayList GetItems(string ItemName, Type itemType, bool useGlobalName);

	BaseItem GetItem(string ItemName);

	void SetExpandedItem(BaseItem objItem);

	BaseItem GetExpandedItem();

	void SetFocusItem(BaseItem objFocusItem);

	BaseItem GetFocusItem();

	void DesignTimeContextMenu(BaseItem objItem);

	void RemoveShortcutsFromItem(BaseItem objItem);

	void AddShortcutsFromItem(BaseItem objItem);

	void StartItemDrag(BaseItem objItem);

	MdiClient GetMdiClient(Form MdiForm);

	void Customize();

	void InvokeResetDefinition(BaseItem item, EventArgs e);

	void InvokeDefinitionLoaded(object sender, EventArgs e);

	void InvokeUserCustomize(object sender, EventArgs e);

	void InvokeEndUserCustomize(object sender, EndUserCustomizeEventArgs e);

	void OnApplicationActivate();

	void OnApplicationDeactivate();

	void OnParentPositionChanging();
}

using System.ComponentModel;
using System.Windows.Forms;

namespace DevComponents.Editors;

public class VisualInputGroup : VisualGroup
{
	private bool bool_7 = true;

	private bool bool_8 = true;

	private bool bool_9 = true;

	private bool bool_10;

	private bool bool_11;

	private bool bool_12 = true;

	private bool bool_13 = true;

	private bool bool_14;

	private bool bool_15 = true;

	private bool bool_16;

	private string string_0 = "";

	[DefaultValue(true)]
	public bool TabNavigationEnabled
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

	[DefaultValue(true)]
	public bool EnterNavigationEnabled
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
		}
	}

	[DefaultValue(true)]
	public bool ArrowNavigationEnabled
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
		}
	}

	[DefaultValue(false)]
	public bool AutoAdvance
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return bool_11;
		}
		set
		{
			if (bool_11 != value)
			{
				bool_11 = value;
				method_6();
			}
		}
	}

	[DefaultValue(true)]
	public bool AllowEmptyState
	{
		get
		{
			return bool_12;
		}
		set
		{
			if (bool_12 != value)
			{
				bool_12 = value;
				OnAllowEmptyStateChanged();
				InvalidateArrange();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(true)]
	public bool IsEmpty
	{
		get
		{
			return bool_13;
		}
		set
		{
			if (bool_13 != value)
			{
				bool_13 = value;
				if (bool_13)
				{
					ResetValue();
				}
				if (base.Parent is VisualInputGroup)
				{
					((VisualInputGroup)base.Parent).UpdateIsEmpty();
				}
			}
		}
	}

	public bool AutoOverwrite
	{
		get
		{
			return bool_15;
		}
		set
		{
			if (bool_15 != value)
			{
				bool_15 = value;
				method_7();
			}
		}
	}

	public bool IsUserInput
	{
		get
		{
			return bool_16;
		}
		set
		{
			bool_16 = value;
		}
	}

	public string SelectNextInputCharacters
	{
		get
		{
			return string_0;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			if (string_0 != value)
			{
				string_0 = value;
			}
		}
	}

	protected override bool OnCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (((int)keyData == 9 && (Control.get_ModifierKeys() & 0x10000) != 65536 && TabNavigationEnabled) || ((int)keyData == 13 && EnterNavigationEnabled) || ((int)keyData == 39 && ArrowNavigationEnabled))
		{
			ValidateInput(base.FocusedItem);
			if (method_3())
			{
				return true;
			}
		}
		else if (((int)keyData == 37 && ArrowNavigationEnabled) || ((keyData & 9) == 9 && (keyData & 0x10000) == 65536 && TabNavigationEnabled))
		{
			ValidateInput(base.FocusedItem);
			if (method_4())
			{
				return true;
			}
		}
		return base.OnCmdKey(ref msg, keyData);
	}

	protected override void OnInputComplete()
	{
		if (ValidateInput(base.FocusedItem) && bool_10 && !method_3())
		{
			OnGroupInputComplete();
		}
		base.OnInputComplete();
	}

	protected virtual bool ValidateInput(VisualItem inputItem)
	{
		return true;
	}

	protected virtual void OnGroupInputComplete()
	{
		if (base.Parent != null)
		{
			base.Parent.vmethod_16();
		}
	}

	private bool method_3()
	{
		return method_5(bool_17: true);
	}

	private bool method_4()
	{
		return method_5(bool_17: false);
	}

	internal bool method_5(bool bool_17)
	{
		if (base.FocusedItem is VisualInputGroup)
		{
			VisualInputGroup visualInputGroup = base.FocusedItem as VisualInputGroup;
			if (visualInputGroup.method_5(bool_17))
			{
				return true;
			}
		}
		Class276 @class = new Class276(Items, !bool_17 || base.IsRightToLeft);
		@class.Int32_0 = Items.IndexOf(base.FocusedItem);
		VisualInputGroup visualInputGroup2;
		while (true)
		{
			if (@class.MoveNext())
			{
				if (!(@class.Current is VisualInputBase visualInputBase) || !CanFocus(visualInputBase))
				{
					if (@class.Current is VisualInputGroup)
					{
						visualInputGroup2 = @class.Current as VisualInputGroup;
						if (visualInputGroup2.method_5(bool_17))
						{
							break;
						}
					}
					continue;
				}
				base.FocusedItem = visualInputBase;
				return true;
			}
			return false;
		}
		base.FocusedItem = visualInputGroup2;
		return true;
	}

	protected override void OnGroupFocused()
	{
		if (base.FocusedItem == null)
		{
			method_5(bool_17: true);
		}
	}

	private void method_6()
	{
		for (int i = 0; i < Items.Count; i++)
		{
			if (Items[i] is VisualInputBase visualInputBase)
			{
				visualInputBase.IsReadOnly = IsReadOnly;
			}
		}
	}

	protected override void OnItemsCollectionChanged(CollectionChangedInfo collectionChangedInfo)
	{
		if ((collectionChangedInfo.ChangeType == eCollectionChangeType.Adding || collectionChangedInfo.ChangeType == eCollectionChangeType.Removing || collectionChangedInfo.ChangeType == eCollectionChangeType.Clearing) && collectionChangedInfo.Added != null)
		{
			VisualItem[] added = collectionChangedInfo.Added;
			foreach (VisualItem visualItem in added)
			{
				if (visualItem is VisualInputBase visualInputBase)
				{
					visualInputBase.IsReadOnly = IsReadOnly;
					visualInputBase.AutoOverwrite = bool_15;
				}
			}
		}
		base.OnItemsCollectionChanged(collectionChangedInfo);
	}

	protected virtual void OnAllowEmptyStateChanged()
	{
		foreach (VisualItem item in Items)
		{
			if (item is VisualNumericInput)
			{
				((VisualNumericInput)item).AllowEmptyState = AllowEmptyState;
			}
		}
	}

	protected override void OnInputChanged(VisualInputBase input)
	{
		UpdateIsEmpty();
		base.OnInputChanged(input);
	}

	public virtual void UpdateIsEmpty()
	{
		bool isEmpty = true;
		foreach (VisualItem item in Items)
		{
			if (!(item is VisualInputBase) || ((VisualInputBase)item).IsEmpty)
			{
				if (item is VisualInputGroup && !((VisualInputGroup)item).IsEmpty)
				{
					isEmpty = false;
					break;
				}
				continue;
			}
			isEmpty = false;
			break;
		}
		IsEmpty = isEmpty;
	}

	protected virtual void ResetValue()
	{
		bool_14 = true;
		try
		{
			foreach (VisualItem item in Items)
			{
				if (item is VisualInputGroup)
				{
					((VisualInputGroup)item).IsEmpty = true;
				}
				else if (item is VisualInputBase)
				{
					((VisualInputBase)item).IsEmpty = true;
				}
			}
		}
		finally
		{
			bool_14 = false;
		}
	}

	private void method_7()
	{
		foreach (VisualItem item in Items)
		{
			if (item is VisualInputBase visualInputBase && visualInputBase.AutoOverwrite != bool_15)
			{
				visualInputBase.AutoOverwrite = bool_15;
			}
		}
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		if (string_0.Length > 0 && string_0.Contains(e.get_KeyChar().ToString()) && method_3())
		{
			e.set_Handled(true);
		}
		else
		{
			base.OnKeyPress(e);
		}
	}
}

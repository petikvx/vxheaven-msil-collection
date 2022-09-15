using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class ItemControlAccessibleObject : ControlAccessibleObject
{
	private ItemControl itemControl_0;

	protected ItemControl Owner => itemControl_0;

	public override string Name
	{
		get
		{
			if (itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed())
			{
				return ((Control)itemControl_0).get_AccessibleName();
			}
			return "";
		}
		set
		{
			if (itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed())
			{
				((Control)itemControl_0).set_AccessibleName(value);
			}
		}
	}

	public override string Description
	{
		get
		{
			if (itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed())
			{
				return ((Control)itemControl_0).get_AccessibleDescription();
			}
			return "";
		}
	}

	public override AccessibleRole Role
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			if (itemControl_0 == null || ((Control)itemControl_0).get_IsDisposed())
			{
				return (AccessibleRole)0;
			}
			return ((Control)itemControl_0).get_AccessibleRole();
		}
	}

	public override AccessibleObject Parent
	{
		get
		{
			if (itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed())
			{
				return ((Control)itemControl_0).get_Parent().get_AccessibilityObject();
			}
			return null;
		}
	}

	public override Rectangle Bounds
	{
		get
		{
			if (itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed() && ((Control)itemControl_0).get_Parent() != null)
			{
				return ((Control)itemControl_0).get_Parent().RectangleToScreen(((Control)itemControl_0).get_Bounds());
			}
			return Rectangle.Empty;
		}
	}

	public override AccessibleStates State
	{
		get
		{
			if (itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed())
			{
				return (AccessibleStates)0;
			}
			return (AccessibleStates)0;
		}
	}

	public ItemControlAccessibleObject(ItemControl owner)
		: base((Control)(object)owner)
	{
		itemControl_0 = owner;
	}

	internal void method_0(BaseItem baseItem_0, AccessibleEvents accessibleEvents_0)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		int num = itemControl_0.method_17().SubItems.IndexOf(baseItem_0);
		if (num >= 0 && itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed())
		{
			itemControl_0.method_1(accessibleEvents_0, num);
		}
	}

	public override int GetChildCount()
	{
		if (itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed() && itemControl_0.method_17() != null)
		{
			return itemControl_0.method_17().SubItems.Count;
		}
		return 0;
	}

	public override AccessibleObject GetChild(int iIndex)
	{
		if (itemControl_0 != null && !((Control)itemControl_0).get_IsDisposed() && itemControl_0.method_17() != null)
		{
			return itemControl_0.method_17().SubItems[iIndex].AccessibleObject;
		}
		return null;
	}
}

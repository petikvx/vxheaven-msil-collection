using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class BarBaseControlAccessibleObject : ControlAccessibleObject
{
	private BarBaseControl barBaseControl_0;

	public override string Name
	{
		get
		{
			if (barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed())
			{
				return ((Control)barBaseControl_0).get_AccessibleName();
			}
			return "";
		}
		set
		{
			if (barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed())
			{
				((Control)barBaseControl_0).set_AccessibleName(value);
			}
		}
	}

	public override string Description
	{
		get
		{
			if (barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed())
			{
				return ((Control)barBaseControl_0).get_AccessibleDescription();
			}
			return "";
		}
	}

	public override AccessibleRole Role
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			if (barBaseControl_0 == null || ((Control)barBaseControl_0).get_IsDisposed())
			{
				return (AccessibleRole)0;
			}
			return ((Control)barBaseControl_0).get_AccessibleRole();
		}
	}

	public override AccessibleObject Parent
	{
		get
		{
			if (barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed())
			{
				return ((Control)barBaseControl_0).get_Parent().get_AccessibilityObject();
			}
			return null;
		}
	}

	public override Rectangle Bounds
	{
		get
		{
			if (barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed() && ((Control)barBaseControl_0).get_Parent() != null)
			{
				return ((Control)barBaseControl_0).get_Parent().RectangleToScreen(((Control)barBaseControl_0).get_Bounds());
			}
			return Rectangle.Empty;
		}
	}

	public override AccessibleStates State
	{
		get
		{
			if (barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed())
			{
				return (AccessibleStates)0;
			}
			return (AccessibleStates)0;
		}
	}

	public BarBaseControlAccessibleObject(BarBaseControl owner)
		: base((Control)(object)owner)
	{
		barBaseControl_0 = owner;
	}

	internal void method_0(BaseItem baseItem_0, AccessibleEvents accessibleEvents_0)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		int num = barBaseControl_0.method_10().SubItems.IndexOf(baseItem_0);
		if (num >= 0 && barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed())
		{
			barBaseControl_0.method_1(accessibleEvents_0, num);
		}
	}

	public override int GetChildCount()
	{
		if (barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed() && barBaseControl_0.method_10() != null)
		{
			return barBaseControl_0.method_10().SubItems.Count;
		}
		return 0;
	}

	public override AccessibleObject GetChild(int iIndex)
	{
		if (barBaseControl_0 != null && !((Control)barBaseControl_0).get_IsDisposed() && barBaseControl_0.method_10() != null)
		{
			return barBaseControl_0.method_10().SubItems[iIndex].AccessibleObject;
		}
		return null;
	}
}

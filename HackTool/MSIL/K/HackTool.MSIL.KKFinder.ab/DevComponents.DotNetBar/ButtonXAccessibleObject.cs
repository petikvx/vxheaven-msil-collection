using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class ButtonXAccessibleObject : ControlAccessibleObject
{
	private ButtonX buttonX_0;

	protected ButtonX Owner => buttonX_0;

	public override string Name
	{
		get
		{
			if (buttonX_0 != null && !((Control)buttonX_0).get_IsDisposed())
			{
				return ((Control)buttonX_0).get_AccessibleName();
			}
			return "";
		}
		set
		{
			if (buttonX_0 != null && !((Control)buttonX_0).get_IsDisposed())
			{
				((Control)buttonX_0).set_AccessibleName(value);
			}
		}
	}

	public override string Description
	{
		get
		{
			if (buttonX_0 != null && !((Control)buttonX_0).get_IsDisposed())
			{
				return ((Control)buttonX_0).get_AccessibleDescription();
			}
			return "";
		}
	}

	public override AccessibleRole Role
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			if (buttonX_0 == null || ((Control)buttonX_0).get_IsDisposed())
			{
				return (AccessibleRole)0;
			}
			return ((Control)buttonX_0).get_AccessibleRole();
		}
	}

	public override AccessibleObject Parent
	{
		get
		{
			if (buttonX_0 != null && !((Control)buttonX_0).get_IsDisposed())
			{
				return ((Control)buttonX_0).get_Parent().get_AccessibilityObject();
			}
			return null;
		}
	}

	public override Rectangle Bounds
	{
		get
		{
			if (buttonX_0 != null && !((Control)buttonX_0).get_IsDisposed() && ((Control)buttonX_0).get_Parent() != null)
			{
				return ((Control)buttonX_0).get_Parent().RectangleToScreen(((Control)buttonX_0).get_Bounds());
			}
			return Rectangle.Empty;
		}
	}

	public override AccessibleStates State => buttonX_0.BaseItem_0.AccessibleObject.get_State();

	public override string Value
	{
		get
		{
			return ((Control)buttonX_0).get_Text();
		}
		set
		{
			((Control)buttonX_0).set_Text(value);
		}
	}

	public override string DefaultAction
	{
		get
		{
			if (buttonX_0 != null && ((Control)buttonX_0).get_AccessibleDefaultActionDescription() != "")
			{
				return ((Control)buttonX_0).get_AccessibleDefaultActionDescription();
			}
			return "Click";
		}
	}

	public ButtonXAccessibleObject(ButtonX owner)
		: base((Control)(object)owner)
	{
		buttonX_0 = owner;
	}

	public override int GetChildCount()
	{
		if (buttonX_0 != null && !((Control)buttonX_0).get_IsDisposed())
		{
			return buttonX_0.BaseItem_0.AccessibleObject.GetChildCount();
		}
		return 0;
	}

	public override AccessibleObject GetChild(int iIndex)
	{
		if (buttonX_0 != null && !((Control)buttonX_0).get_IsDisposed())
		{
			return buttonX_0.BaseItem_0.AccessibleObject.GetChild(iIndex);
		}
		return null;
	}

	public override void DoDefaultAction()
	{
		if (buttonX_0 != null)
		{
			buttonX_0.PerformClick();
		}
	}
}

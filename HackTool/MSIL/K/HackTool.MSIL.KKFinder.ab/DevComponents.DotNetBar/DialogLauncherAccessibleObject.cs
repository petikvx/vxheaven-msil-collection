using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class DialogLauncherAccessibleObject : AccessibleObject
{
	private RibbonBar ribbonBar_0;

	private bool bool_0;

	public override string Name
	{
		get
		{
			if (ribbonBar_0 == null)
			{
				return "";
			}
			if (ribbonBar_0.DialogLauncherAccessibleName != "")
			{
				return ribbonBar_0.DialogLauncherAccessibleName;
			}
			if (((Control)ribbonBar_0).get_Text() != null)
			{
				return ((Control)ribbonBar_0).get_Text().Replace("&", "");
			}
			return "";
		}
		set
		{
			ribbonBar_0.DialogLauncherAccessibleName = value;
		}
	}

	public override string Description => ((Control)ribbonBar_0).get_Text() + " Dialog Launcher";

	public override AccessibleRole Role
	{
		get
		{
			if (ribbonBar_0 != null && ((Control)ribbonBar_0).get_IsAccessible())
			{
				return (AccessibleRole)43;
			}
			return (AccessibleRole)0;
		}
	}

	public override AccessibleStates State
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			if (ribbonBar_0 == null)
			{
				return (AccessibleStates)1;
			}
			AccessibleStates val = (AccessibleStates)0;
			if (!((Control)ribbonBar_0).get_IsAccessible())
			{
				return (AccessibleStates)1;
			}
			if (!((Control)ribbonBar_0).get_Visible())
			{
				return (AccessibleStates)(val | 0x8000);
			}
			if (!((Control)ribbonBar_0).get_Enabled())
			{
				return (AccessibleStates)1;
			}
			val = (AccessibleStates)(val | 0x40000000);
			if (bool_0)
			{
				return (AccessibleStates)(val | 0x84);
			}
			return (AccessibleStates)(val | 0x100000);
		}
	}

	public override AccessibleObject Parent
	{
		get
		{
			if (ribbonBar_0 == null)
			{
				return null;
			}
			return ((Control)ribbonBar_0).get_AccessibilityObject();
		}
	}

	public override Rectangle Bounds
	{
		get
		{
			if (ribbonBar_0 == null)
			{
				return Rectangle.Empty;
			}
			return ((Control)ribbonBar_0).RectangleToScreen(ribbonBar_0.Rectangle_0);
		}
	}

	public override string DefaultAction => "Press";

	public override string KeyboardShortcut => "";

	public DialogLauncherAccessibleObject(RibbonBar owner)
	{
		ribbonBar_0 = owner;
		ribbonBar_0.DialogLauncherMouseEnter += ribbonBar_0_DialogLauncherMouseEnter;
		ribbonBar_0.DialogLauncherMouseLeave += ribbonBar_0_DialogLauncherMouseLeave;
	}

	private void ribbonBar_0_DialogLauncherMouseEnter(object sender, EventArgs e)
	{
		bool_0 = true;
	}

	private void ribbonBar_0_DialogLauncherMouseLeave(object sender, EventArgs e)
	{
		bool_0 = false;
	}

	public override int GetChildCount()
	{
		return 0;
	}

	public override AccessibleObject GetChild(int iIndex)
	{
		return null;
	}

	public override void DoDefaultAction()
	{
		if (ribbonBar_0 != null)
		{
			ribbonBar_0.DoLaunchDialog();
			((AccessibleObject)this).DoDefaultAction();
		}
	}

	public override AccessibleObject GetSelected()
	{
		if (ribbonBar_0 == null)
		{
			return ((AccessibleObject)this).GetSelected();
		}
		if (bool_0)
		{
			return (AccessibleObject)(object)this;
		}
		return ((AccessibleObject)this).GetSelected();
	}

	public override AccessibleObject HitTest(int x, int y)
	{
		if (ribbonBar_0 == null)
		{
			return ((AccessibleObject)this).HitTest(x, y);
		}
		Point point = new Point(x, y);
		Point pt = ((Control)ribbonBar_0).PointToClient(point);
		if (ribbonBar_0.Rectangle_0.Contains(pt))
		{
			return (AccessibleObject)(object)this;
		}
		return ((AccessibleObject)this).HitTest(x, y);
	}

	public override AccessibleObject Navigate(AccessibleNavigation navdir)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((AccessibleObject)this).Navigate(navdir);
	}
}

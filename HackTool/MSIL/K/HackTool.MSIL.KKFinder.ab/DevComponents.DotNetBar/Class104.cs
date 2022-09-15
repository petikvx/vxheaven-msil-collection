using System;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class104
{
	internal static void smethod_0(BaseItem baseItem_0, KeyEventArgs keyEventArgs_0)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Invalid comparison between Unknown and I4
		if (baseItem_0.SubItems.Count == 0 || keyEventArgs_0.get_Handled())
		{
			return;
		}
		BaseItem baseItem = baseItem_0.ExpandedItem();
		if (baseItem != null)
		{
			baseItem.InternalKeyDown(keyEventArgs_0);
			if (keyEventArgs_0.get_Handled())
			{
				return;
			}
		}
		eOrientation eOrientation2 = baseItem_0.Orientation;
		if (baseItem_0 is ItemContainer)
		{
			eOrientation2 = ((ItemContainer)baseItem_0).LayoutOrientation;
		}
		if ((eOrientation2 == eOrientation.Horizontal && ((int)keyEventArgs_0.get_KeyCode() == 37 || (int)keyEventArgs_0.get_KeyCode() == 39 || (baseItem_0.BaseItem_1 == null && ((int)keyEventArgs_0.get_KeyCode() == 40 || (int)keyEventArgs_0.get_KeyCode() == 38)))) || (eOrientation2 == eOrientation.Vertical && ((int)keyEventArgs_0.get_KeyCode() == 38 || (int)keyEventArgs_0.get_KeyCode() == 40 || (baseItem_0.BaseItem_1 == null && ((int)keyEventArgs_0.get_KeyCode() == 39 || (int)keyEventArgs_0.get_KeyCode() == 37)))))
		{
			if (baseItem_0.BaseItem_1 != null)
			{
				baseItem_0.BaseItem_1.InternalMouseLeave();
				if (baseItem_0.AutoExpand && baseItem_0.BaseItem_1.Expanded)
				{
					baseItem_0.BaseItem_1.Expanded = false;
				}
			}
			if ((int)keyEventArgs_0.get_KeyCode() != 37 && (int)keyEventArgs_0.get_KeyCode() != 38)
			{
				int i = 0;
				if (baseItem_0.BaseItem_1 != null)
				{
					i = baseItem_0.SubItems.IndexOf(baseItem_0.BaseItem_1) + 1;
				}
				for (; i < baseItem_0.SubItems.Count && !smethod_1(baseItem_0.SubItems[i]); i++)
				{
				}
				if (i >= baseItem_0.SubItems.Count)
				{
					i = 0;
				}
				BaseItem baseItem2 = null;
				for (int j = i; j < baseItem_0.SubItems.Count; j++)
				{
					baseItem2 = baseItem_0.SubItems[j];
					if (smethod_1(baseItem2))
					{
						i = j;
						break;
					}
				}
				baseItem_0.BaseItem_1 = baseItem_0.SubItems[i];
			}
			else
			{
				int num = 0;
				if (baseItem_0.BaseItem_1 != null)
				{
					num = baseItem_0.SubItems.IndexOf(baseItem_0.BaseItem_1) - 1;
				}
				if (num < 0)
				{
					num = baseItem_0.SubItems.Count - 1;
				}
				BaseItem baseItem3 = null;
				bool flag = false;
				do
				{
					int num2 = num;
					while (num2 >= 0)
					{
						baseItem3 = baseItem_0.SubItems[num2];
						if (!smethod_1(baseItem3))
						{
							num2--;
							continue;
						}
						num = num2;
						break;
					}
					if (!smethod_1(baseItem_0.SubItems[num]))
					{
						if (!flag)
						{
							num = baseItem_0.SubItems.Count - 1;
							flag = true;
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						flag = false;
					}
				}
				while (flag);
				baseItem_0.BaseItem_1 = baseItem_0.SubItems[num];
			}
			if (baseItem_0.BaseItem_1 != null)
			{
				if (baseItem_0.BaseItem_1 is ItemContainer)
				{
					((ItemContainer)baseItem_0.BaseItem_1).method_28();
				}
				else
				{
					baseItem_0.BaseItem_1.InternalMouseEnter();
					baseItem_0.BaseItem_1.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, baseItem_0.BaseItem_1.LeftInternal + 1, baseItem_0.BaseItem_1.TopInternal + 1, 0));
					if (baseItem_0.ContainerControl is IScrollableItemControl scrollableItemControl)
					{
						scrollableItemControl.KeyboardItemSelected(baseItem_0.BaseItem_1);
					}
				}
			}
			keyEventArgs_0.set_Handled(true);
			return;
		}
		if ((int)keyEventArgs_0.get_KeyCode() == 27)
		{
			if (baseItem != null)
			{
				baseItem.Expanded = false;
				keyEventArgs_0.set_Handled(true);
				return;
			}
			object containerControl = baseItem_0.ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val is Bar)
			{
				Bar bar = val as Bar;
				if (bar.BarState == eBarState.Popup)
				{
					bar.ParentItem.Expanded = false;
				}
				else if (baseItem_0.AutoExpand)
				{
					baseItem_0.AutoExpand = false;
				}
				else if (((Control)bar).get_Focused() || bar.Boolean_11)
				{
					bar.Boolean_11 = false;
					bar.ReleaseFocus();
				}
				keyEventArgs_0.set_Handled(true);
			}
			else if (val is ItemControl)
			{
				ItemControl itemControl = val as ItemControl;
				if (baseItem_0.AutoExpand)
				{
					baseItem_0.AutoExpand = false;
				}
				else if (((Control)itemControl).get_Focused() || itemControl.Boolean_3)
				{
					itemControl.Boolean_3 = false;
					itemControl.ReleaseFocus();
				}
			}
			return;
		}
		BaseItem baseItem4 = baseItem_0.ExpandedItem();
		if (baseItem4 != null)
		{
			baseItem4.InternalKeyDown(keyEventArgs_0);
			return;
		}
		int num3 = 0;
		if (keyEventArgs_0.get_Shift())
		{
			try
			{
				byte[] array = new byte[256];
				if (Class92.GetKeyboardState(array))
				{
					byte[] array2 = new byte[2];
					if (Class92.ToAscii((uint)keyEventArgs_0.get_KeyValue(), 0u, array, array2, 0u) != 0)
					{
						num3 = array2[0];
					}
				}
			}
			catch (Exception)
			{
				num3 = 0;
			}
		}
		if (num3 == 0)
		{
			num3 = (int)Class92.MapVirtualKey((uint)keyEventArgs_0.get_KeyValue(), 2u);
		}
		if (baseItem_0.BaseItem_1 != null)
		{
			baseItem_0.BaseItem_1.InternalKeyDown(keyEventArgs_0);
		}
	}

	private static bool smethod_1(BaseItem baseItem_0)
	{
		if (baseItem_0 == null)
		{
			return false;
		}
		if (baseItem_0.Visible && baseItem_0.method_2())
		{
			if (baseItem_0 is LabelItem)
			{
				return false;
			}
			return true;
		}
		return false;
	}
}

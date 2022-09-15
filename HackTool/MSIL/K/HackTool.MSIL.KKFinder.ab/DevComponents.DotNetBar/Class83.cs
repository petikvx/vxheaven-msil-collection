using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class83 : ListBox
{
	private ArrayList arrayList_0;

	internal eDotNetBarStyle eDotNetBarStyle_0 = eDotNetBarStyle.Office2003;

	internal Class83()
	{
		((ListBox)this).set_DrawMode((DrawMode)1);
		arrayList_0 = null;
		((ListBox)this).set_IntegralHeight(false);
		((Control)this).set_BackColor(SystemColors.Control);
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		((ListBox)this).OnDrawItem(e);
		if (arrayList_0 == null || e.get_Index() < 0)
		{
			return;
		}
		BaseItem baseItem = ((ListBox)this).get_Items().get_Item(e.get_Index()) as BaseItem;
		e.DrawBackground();
		if (baseItem != null)
		{
			baseItem.LeftInternal = e.get_Bounds().Left;
			baseItem.TopInternal = e.get_Bounds().Top;
			baseItem.WidthInternal = e.get_Bounds().Width;
			if ((e.get_State() & 1) == 1)
			{
				baseItem.InternalMouseEnter();
				baseItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, baseItem.LeftInternal + 2, baseItem.TopInternal + 2, 0));
			}
			ItemPaintArgs itemPaintArgs = new ItemPaintArgs(null, (Control)(object)this, e.get_Graphics(), new ColorScheme(eDotNetBarStyle_0));
			itemPaintArgs.BaseRenderer_0 = method_0();
			baseItem.Paint(itemPaintArgs);
			if ((e.get_State() & 1) == 1)
			{
				baseItem.InternalMouseLeave();
			}
		}
	}

	private BaseRenderer method_0()
	{
		return GlobalManager.Renderer;
	}

	internal void method_1(ArrayList arrayList_1)
	{
		arrayList_0 = arrayList_1;
		((ListBox)this).get_Items().Clear();
		int num = 0;
		foreach (BaseItem item in arrayList_0)
		{
			item.ContainerControl = this;
			item.method_10(bool_22: true);
			item.Visible = true;
			item.WidthInternal = ((Control)this).get_ClientSize().Width;
			item.RecalcSize();
			if (item.HeightInternal > num)
			{
				num = item.HeightInternal;
			}
		}
		if (num == 0)
		{
			num = 16;
		}
		((ListBox)this).set_ItemHeight(num);
		foreach (BaseItem item2 in arrayList_0)
		{
			item2.HeightInternal = num;
			((ListBox)this).get_Items().Add((object)item2);
		}
	}
}

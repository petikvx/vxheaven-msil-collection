using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class RibbonStripContainerItem : ImageItem, IDesignTimeProvider
{
	private Class182 class182_0;

	private Class181 class181_0;

	private SystemCaptionItem systemCaptionItem_0;

	private RibbonStrip ribbonStrip_0;

	private bool Boolean_3
	{
		get
		{
			if (!DesignMode && ribbonStrip_0.CanSupportGlass)
			{
				return Class51.Boolean_0;
			}
			return false;
		}
	}

	public GenericItemContainer RibbonStripContainer => class182_0;

	public GenericItemContainer CaptionContainer => class181_0;

	public SystemCaptionItem SystemCaptionItem => systemCaptionItem_0;

	[DefaultValue(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool Expanded
	{
		get
		{
			return base.Expanded;
		}
		set
		{
			base.Expanded = value;
			if (value)
			{
				return;
			}
			foreach (BaseItem subItem in SubItems)
			{
				subItem.Expanded = false;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Size SubItemsImageSize
	{
		get
		{
			return base.SubItemsImageSize;
		}
		set
		{
		}
	}

	public RibbonStripContainerItem(RibbonStrip parent)
	{
		ribbonStrip_0 = parent;
		m_IsContainer = true;
		AccessibleRole = (AccessibleRole)20;
		class182_0 = new Class182();
		class182_0.ContainerControl = parent;
		class182_0.GlobalItem = false;
		class182_0.WrapItems = false;
		class182_0.Boolean_3 = false;
		class182_0.Boolean_4 = false;
		class182_0.Stretch = true;
		class182_0.Displayed = true;
		class182_0.SystemContainer = true;
		class182_0.PaddingTop = 0;
		class182_0.PaddingBottom = 0;
		class182_0.ItemSpacing = 1;
		class181_0 = new Class181();
		class181_0.ContainerControl = parent;
		class181_0.GlobalItem = false;
		class181_0.WrapItems = false;
		class181_0.Boolean_3 = false;
		class181_0.EqualButtonSize = false;
		class181_0.EContainerVerticalAlignment_0 = eContainerVerticalAlignment.Top;
		class181_0.Boolean_4 = false;
		class181_0.Stretch = true;
		class181_0.Displayed = true;
		class181_0.SystemContainer = true;
		class181_0.PaddingBottom = 0;
		class181_0.PaddingTop = 0;
		class181_0.ItemSpacing = 1;
		class181_0.Boolean_5 = false;
		Class181 @class = class181_0;
		@class.eventHandler_14 = (EventHandler)Delegate.Combine(@class.eventHandler_14, new EventHandler(method_17));
		SubItems.Add(class181_0);
		SubItems.Add(class182_0);
		SystemCaptionItem item = new SystemCaptionItem
		{
			RestoreEnabled = false,
			IsSystemIcon = false,
			ItemAlignment = eItemAlignment.Far
		};
		class181_0.SubItems.Add(item);
		systemCaptionItem_0 = item;
	}

	private void method_17(object sender, EventArgs e)
	{
		if (sender is BaseItem)
		{
			BaseItem baseItem = sender as BaseItem;
			if (!(baseItem is SystemCaptionItem) && class181_0.SubItems.Contains(systemCaptionItem_0))
			{
				class181_0.SubItems.method_3(systemCaptionItem_0);
				class181_0.SubItems.method_0(systemCaptionItem_0);
			}
		}
	}

	internal void method_18()
	{
		class182_0.method_30();
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.method_30();
		}
	}

	public override void ContainerLostFocus(bool appLostFocus)
	{
		base.ContainerLostFocus(appLostFocus);
		class182_0.ContainerLostFocus(appLostFocus);
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.ContainerLostFocus(appLostFocus);
		}
	}

	internal void method_19()
	{
		if (ribbonStrip_0.CaptionVisible && class182_0.ExpandedItem() == null)
		{
			class181_0.method_29();
		}
		else
		{
			class182_0.method_29();
		}
	}

	public override void Paint(ItemPaintArgs pa)
	{
		if (!SuspendLayout)
		{
			class182_0.Paint(pa);
			if (ribbonStrip_0.CaptionVisible)
			{
				class181_0.Paint(pa);
			}
		}
	}

	public override void RecalcSize()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		if (SuspendLayout)
		{
			return;
		}
		class182_0.Bounds = method_20();
		class182_0.RecalcSize();
		if (class182_0.HeightInternal < 0)
		{
			class182_0.HeightInternal = 0;
		}
		bool flag = false;
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.Bounds = method_21();
			class181_0.RecalcSize();
			if (ribbonStrip_0.CaptionHeight == 0 && systemCaptionItem_0.TopInternal < SystemInformation.get_FrameBorderSize().Height - 1)
			{
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				Form val2 = null;
				if (val != null)
				{
					val2 = val.FindForm();
				}
				if (val2 != null && (int)val2.get_WindowState() == 2)
				{
					flag = true;
				}
				if (Environment.OSVersion.Version.Major >= 6 && !Boolean_3)
				{
					if (flag)
					{
						systemCaptionItem_0.TopInternal = 1;
					}
					else
					{
						systemCaptionItem_0.TopInternal = SystemInformation.get_FrameBorderSize().Height - 4;
					}
				}
				else
				{
					systemCaptionItem_0.TopInternal = SystemInformation.get_FrameBorderSize().Height - 1;
				}
			}
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int num = 2;
				if (!Boolean_3)
				{
					num++;
				}
				else if (flag)
				{
					num++;
				}
				foreach (BaseItem subItem in class181_0.SubItems)
				{
					if (!(subItem is Office2007StartButton) && subItem != systemCaptionItem_0)
					{
						subItem.TopInternal += num;
					}
				}
				if (class181_0.DisplayMoreItem_0 != null)
				{
					class181_0.DisplayMoreItem_0.TopInternal += num;
				}
			}
			else
			{
				foreach (BaseItem subItem2 in class181_0.SubItems)
				{
					if (subItem2.HeightInternal < systemCaptionItem_0.HeightInternal)
					{
						subItem2.TopInternal += systemCaptionItem_0.HeightInternal - subItem2.HeightInternal;
					}
				}
				if (class181_0.DisplayMoreItem_0 != null)
				{
					class181_0.DisplayMoreItem_0.TopInternal += systemCaptionItem_0.HeightInternal - class181_0.DisplayMoreItem_0.HeightInternal;
				}
			}
			if (class182_0.HeightInternal == 0)
			{
				HeightInternal = class181_0.HeightInternal;
			}
			else
			{
				HeightInternal = class182_0.Bounds.Bottom;
			}
		}
		else
		{
			int num2 = class182_0.HeightInternal;
			if (ribbonStrip_0.TabGroupsVisible)
			{
				num2 += ribbonStrip_0.TabGroupHeight + 1;
			}
			HeightInternal = num2;
		}
		base.RecalcSize();
	}

	private Rectangle method_20()
	{
		return ribbonStrip_0.method_31();
	}

	private Rectangle method_21()
	{
		return ribbonStrip_0.method_32();
	}

	public override BaseItem Copy()
	{
		RibbonStripContainerItem ribbonStripContainerItem = new RibbonStripContainerItem(ribbonStrip_0);
		CopyToItem(ribbonStripContainerItem);
		return ribbonStripContainerItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		RibbonStripContainerItem objCopy = copy as RibbonStripContainerItem;
		base.CopyToItem(objCopy);
	}

	public override void InternalClick(MouseButtons mb, Point mpos)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		class182_0.InternalClick(mb, mpos);
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.InternalClick(mb, mpos);
		}
	}

	public override void InternalDoubleClick(MouseButtons mb, Point mpos)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		class182_0.InternalDoubleClick(mb, mpos);
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.InternalDoubleClick(mb, mpos);
		}
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		class182_0.InternalMouseDown(objArg);
		if (ribbonStrip_0.CaptionVisible && ((DesignMode && class181_0.ItemAtLocation(objArg.get_X(), objArg.get_Y()) != null) || !DesignMode))
		{
			class181_0.InternalMouseDown(objArg);
		}
	}

	public override void InternalMouseHover()
	{
		class182_0.InternalMouseHover();
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.InternalMouseHover();
		}
	}

	public override void InternalMouseLeave()
	{
		class182_0.InternalMouseLeave();
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.InternalMouseLeave();
		}
	}

	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		class182_0.InternalMouseMove(objArg);
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.InternalMouseMove(objArg);
		}
	}

	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		class182_0.InternalMouseUp(objArg);
		if (ribbonStrip_0.CaptionVisible)
		{
			class181_0.InternalMouseUp(objArg);
		}
	}

	public override void InternalKeyDown(KeyEventArgs objArg)
	{
		BaseItem baseItem = ExpandedItem();
		if (baseItem == null)
		{
			baseItem = class181_0.ExpandedItem();
		}
		if (baseItem == null)
		{
			baseItem = class182_0.ExpandedItem();
		}
		if (baseItem != null && ribbonStrip_0.CaptionVisible)
		{
			if (baseItem.Parent == class182_0)
			{
				class182_0.InternalKeyDown(objArg);
			}
			else
			{
				class181_0.InternalKeyDown(objArg);
			}
			return;
		}
		class182_0.InternalKeyDown(objArg);
		if (!objArg.get_Handled() && ribbonStrip_0.CaptionVisible)
		{
			class181_0.InternalKeyDown(objArg);
		}
	}

	public override BaseItem ItemAtLocation(int x, int y)
	{
		if (class182_0.DisplayRectangle.Contains(x, y))
		{
			return class182_0.ItemAtLocation(x, y);
		}
		if (class181_0.DisplayRectangle.Contains(x, y))
		{
			return class181_0.ItemAtLocation(x, y);
		}
		return null;
	}

	public InsertPosition GetInsertPosition(Point pScreen, BaseItem DragItem)
	{
		InsertPosition insertPosition = class182_0.GetInsertPosition(pScreen, DragItem);
		if (insertPosition == null && ribbonStrip_0.CaptionVisible)
		{
			insertPosition = class181_0.GetInsertPosition(pScreen, DragItem);
		}
		return insertPosition;
	}

	public void DrawReversibleMarker(int iPos, bool Before)
	{
	}

	public void InsertItemAt(BaseItem objItem, int iPos, bool Before)
	{
	}
}

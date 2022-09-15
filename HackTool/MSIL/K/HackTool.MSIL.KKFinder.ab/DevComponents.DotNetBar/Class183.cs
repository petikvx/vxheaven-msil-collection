using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class183 : ButtonItem
{
	private CrumbBarItem crumbBarItem_0;

	private DateTime dateTime_0 = DateTime.MinValue;

	private bool bool_49;

	public CrumbBarItem CrumbBarItem_0
	{
		get
		{
			return crumbBarItem_0;
		}
		set
		{
			if (crumbBarItem_0 != null)
			{
				crumbBarItem_0.TextChanged -= crumbBarItem_0_TextChanged;
				crumbBarItem_0.SubItemsChanged -= crumbBarItem_0_SubItemsChanged;
				crumbBarItem_0.PopupClose -= crumbBarItem_0_PopupClose;
			}
			crumbBarItem_0 = value;
			if (crumbBarItem_0 != null)
			{
				Text = crumbBarItem_0.Text;
				Cursor = crumbBarItem_0.Cursor;
				ForeColor = crumbBarItem_0.ForeColor;
				HotForeColor = crumbBarItem_0.HotForeColor;
				Tooltip = crumbBarItem_0.Tooltip;
				crumbBarItem_0.TextChanged += crumbBarItem_0_TextChanged;
				crumbBarItem_0.SubItemsChanged += crumbBarItem_0_SubItemsChanged;
				crumbBarItem_0.PopupClose += crumbBarItem_0_PopupClose;
				if (Boolean_8)
				{
					PopupType = ePopupType.Container;
				}
				else
				{
					PopupType = ePopupType.Menu;
				}
			}
			else
			{
				PopupType = ePopupType.Menu;
			}
		}
	}

	private new bool Boolean_8
	{
		get
		{
			if (crumbBarItem_0 != null)
			{
				foreach (BaseItem subItem in crumbBarItem_0.SubItems)
				{
					if (subItem.Visible)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool Expanded
	{
		get
		{
			return bool_49;
		}
		set
		{
			if (bool_49 != value)
			{
				bool_49 = value;
				method_44();
			}
		}
	}

	public Class183()
	{
		SubItemsExpandWidth = 15;
		base.Int32_2 = 2;
	}

	private void crumbBarItem_0_PopupClose(object sender, EventArgs e)
	{
		bool_49 = false;
		if (Parent is Class180 @class)
		{
			@class.OnSubItemExpandChange(this);
		}
		dateTime_0 = DateTime.Now;
		Refresh();
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		if (dateTime_0 != DateTime.MinValue && DateTime.Now.Subtract(dateTime_0).TotalMilliseconds < 200.0)
		{
			dateTime_0 = DateTime.MinValue;
		}
		else
		{
			base.InternalMouseDown(objArg);
		}
	}

	public override void InternalMouseEnter()
	{
		if (Parent is Class180 @class && @class.Expanded && Boolean_8)
		{
			@class.Expanded = false;
			Expanded = true;
		}
		base.InternalMouseEnter();
	}

	private void crumbBarItem_0_SubItemsChanged(object sender, CollectionChangeEventArgs e)
	{
		method_43();
	}

	private void method_43()
	{
		if (Boolean_8 && !(Parent is CrumbBarOverflowButton))
		{
			PopupType = ePopupType.Container;
		}
		else
		{
			PopupType = ePopupType.Menu;
		}
	}

	protected override void OnParentChanged()
	{
		method_43();
		base.OnParentChanged();
	}

	private void crumbBarItem_0_TextChanged(object sender, EventArgs e)
	{
		Text = crumbBarItem_0.Text;
	}

	public override void Dispose()
	{
		CrumbBarItem_0 = null;
		base.Dispose();
	}

	internal static object smethod_0(CrumbBarItem crumbBarItem_1)
	{
		Class183 @class = new Class183();
		@class.CrumbBarItem_0 = crumbBarItem_1;
		return @class;
	}

	private void method_44()
	{
		if (!bool_49)
		{
			crumbBarItem_0.Expanded = false;
		}
		else
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val == null)
			{
				return;
			}
			Point point = new Point(base.Rectangle_1.X - 10, base.Rectangle_1.Bottom - 1);
			point.Offset(DisplayRectangle.Location.X, DisplayRectangle.Location.Y);
			point = val.PointToScreen(point);
			crumbBarItem_0.PopupMenu(point);
		}
		if (Parent is Class180 @class)
		{
			@class.OnSubItemExpandChange(this);
		}
	}

	protected override void OnClick()
	{
		CrumbBar crumbBar = ContainerControl as CrumbBar;
		if (crumbBar == null)
		{
			crumbBar = GetOwner() as CrumbBar;
		}
		base.OnClick();
		if (crumbBar != null)
		{
			crumbBar.SelectedItem = crumbBarItem_0;
		}
	}

	protected override void RenderButton(ItemPaintArgs p)
	{
		if (!p.IsOnMenu)
		{
			BaseRenderer baseRenderer_ = p.BaseRenderer_0;
			if (baseRenderer_ != null)
			{
				p.ButtonItemRendererEventArgs.Graphics = p.Graphics;
				p.ButtonItemRendererEventArgs.ButtonItem = this;
				p.ButtonItemRendererEventArgs.itemPaintArgs_0 = p;
				baseRenderer_.DrawCrumbBarItemView(p.ButtonItemRendererEventArgs);
				return;
			}
		}
		base.RenderButton(p);
	}

	public override BaseItem Copy()
	{
		Class183 @class = new Class183();
		CopyToItem(@class);
		return @class;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		Class183 copy2 = copy as Class183;
		base.CopyToItem((BaseItem)copy2);
	}
}

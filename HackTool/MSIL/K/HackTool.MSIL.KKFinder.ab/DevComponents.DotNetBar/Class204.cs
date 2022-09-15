using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
internal class Class204 : PanelEx
{
	private ItemContainer itemContainer_0;

	private ButtonItem buttonItem_0;

	private int int_1 = 3;

	private eTitleButtonAlignment eTitleButtonAlignment_0 = eTitleButtonAlignment.Right;

	private bool bool_11 = true;

	private EventHandler eventHandler_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ButtonItem ButtonItem_0 => buttonItem_0;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool Boolean_2
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
		}
	}

	[Description("Indicates whether expand button is visible or not.")]
	[Browsable(false)]
	[Category("Expand Button")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Boolean_3
	{
		get
		{
			return buttonItem_0.Visible;
		}
		set
		{
			buttonItem_0.Visible = value;
			method_9();
			((Control)this).Invalidate();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(eTitleButtonAlignment.Right)]
	[Browsable(false)]
	[Description("Indicates the alignment of button.")]
	[Category("Expand Button")]
	public eTitleButtonAlignment ETitleButtonAlignment_0
	{
		get
		{
			return eTitleButtonAlignment_0;
		}
		set
		{
			eTitleButtonAlignment_0 = value;
			method_9();
			((Control)this).Invalidate();
		}
	}

	[Browsable(true)]
	[Description("Indicates whether text markup if it occupies less space than control provides uses the Style Alignment and LineAlignment properties to align the markup inside of the control.")]
	[Category("Appearance")]
	[DefaultValue(true)]
	public override bool MarkupUsesStyleAlignment
	{
		get
		{
			return base.MarkupUsesStyleAlignment;
		}
		set
		{
			base.MarkupUsesStyleAlignment = value;
		}
	}

	public event EventHandler Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public Class204()
	{
		buttonItem_0 = new ButtonItem("close");
		buttonItem_0.Style = eDotNetBarStyle.Office2003;
		buttonItem_0.Image = (Image)(object)Class109.smethod_67("SystemImages.CollapseTitle.png");
		buttonItem_0.Displayed = true;
		buttonItem_0.Click += buttonItem_0_Click;
		itemContainer_0 = new ItemContainer();
		itemContainer_0.ContainerControl = this;
		itemContainer_0.Style = eDotNetBarStyle.Office2003;
		itemContainer_0.SubItems.Add(buttonItem_0);
		base.MarkupUsesStyleAlignment = true;
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		base.OnMouseEnter(e);
		itemContainer_0.InternalMouseEnter();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		itemContainer_0.InternalMouseLeave();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		itemContainer_0.InternalMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		itemContainer_0.InternalMouseUp(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		itemContainer_0.InternalMouseMove(e);
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Point point = ((Control)this).PointToClient(Control.get_MousePosition());
		itemContainer_0.InternalClick(Control.get_MouseButtons(), new Point(point.X, point.Y));
		base.OnClick(e);
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		method_9();
	}

	public void method_9()
	{
		buttonItem_0.FixedSize = Size.Empty;
		itemContainer_0.NeedRecalcSize = true;
		itemContainer_0.RecalcSize();
		if (itemContainer_0.HeightInternal >= ((Control)this).get_Height() && ((Control)this).get_Height() > 8)
		{
			buttonItem_0.FixedSize = new Size(((Control)this).get_Height() - 2, ((Control)this).get_Height() - 2);
			itemContainer_0.RecalcSize();
		}
		if (eTitleButtonAlignment_0 == eTitleButtonAlignment.Right)
		{
			itemContainer_0.LeftInternal = ((Control)this).get_Width() - itemContainer_0.WidthInternal - int_1;
			itemContainer_0.TopInternal = (((Control)this).get_Height() - itemContainer_0.HeightInternal) / 2;
		}
		else
		{
			itemContainer_0.LeftInternal = int_1;
			itemContainer_0.TopInternal = (((Control)this).get_Height() - itemContainer_0.HeightInternal) / 2;
		}
		itemContainer_0.RecalcSize();
		RefreshTextClientRectangle();
	}

	protected override void RefreshTextClientRectangle()
	{
		Rectangle displayRectangle = ((Control)this).get_DisplayRectangle();
		displayRectangle.Width -= itemContainer_0.WidthInternal + int_1;
		if (eTitleButtonAlignment_0 == eTitleButtonAlignment.Left)
		{
			displayRectangle.X += itemContainer_0.WidthInternal + int_1;
		}
		if (!bool_11)
		{
			displayRectangle.Width = 0;
		}
		base.ClientTextRectangle = displayRectangle;
		ResizeMarkup();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		ItemPaintArgs p = new ItemPaintArgs(null, (Control)(object)this, e.get_Graphics(), base.ColorScheme);
		itemContainer_0.Paint(p);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		method_9();
	}

	private void buttonItem_0_Click(object sender, EventArgs e)
	{
		InvokeExpandedClick(e);
	}

	protected virtual void InvokeExpandedClick(EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}
}

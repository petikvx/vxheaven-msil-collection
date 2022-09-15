using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.Editors;

public class VisualUpDownButton : VisualButtonBase
{
	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private EventHandler eventHandler_3;

	private EventHandler eventHandler_4;

	private Image image_0;

	private Image image_1;

	private int int_1 = 15;

	private eUpDownButtonAutoChange eUpDownButtonAutoChange_0;

	private VisualItem visualItem_0;

	private bool bool_12 = true;

	private bool bool_13 = true;

	[DefaultValue(null)]
	public Image UpImage
	{
		get
		{
			return image_0;
		}
		set
		{
			if (image_0 != value)
			{
				image_0 = value;
				InvalidateArrange();
			}
		}
	}

	[DefaultValue(null)]
	public Image DownImage
	{
		get
		{
			return image_1;
		}
		set
		{
			if (image_1 != value)
			{
				image_1 = value;
				InvalidateArrange();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool MouseOverButtonUp
	{
		get
		{
			return bool_8;
		}
		set
		{
			if (bool_8 != value)
			{
				bool_8 = value;
				InvalidateRender();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool MouseOverButtonDown
	{
		get
		{
			return bool_9;
		}
		set
		{
			if (bool_9 != value)
			{
				bool_9 = value;
				InvalidateRender();
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool MouseDownButtonDown
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
				InvalidateRender();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool MouseDownButtonUp
	{
		get
		{
			return bool_10;
		}
		set
		{
			if (bool_10 != value)
			{
				bool_10 = value;
				InvalidateRender();
			}
		}
	}

	[DefaultValue(15)]
	public int ButtonWidth
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 != value)
			{
				int_1 = value;
				InvalidateArrange();
			}
		}
	}

	[DefaultValue(eUpDownButtonAutoChange.None)]
	public eUpDownButtonAutoChange AutoChange
	{
		get
		{
			return eUpDownButtonAutoChange_0;
		}
		set
		{
			eUpDownButtonAutoChange_0 = value;
		}
	}

	[DefaultValue(null)]
	public VisualItem AutoChangeItem
	{
		get
		{
			return visualItem_0;
		}
		set
		{
			visualItem_0 = value;
		}
	}

	[DefaultValue(true)]
	public bool UpEnabled
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
				InvalidateRender();
			}
		}
	}

	[DefaultValue(true)]
	public bool DownEnabled
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
				InvalidateRender();
			}
		}
	}

	public event EventHandler UpClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
		}
	}

	public event EventHandler DownClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_4 = (EventHandler)Delegate.Combine(eventHandler_4, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_4 = (EventHandler)Delegate.Remove(eventHandler_4, value);
		}
	}

	public VisualUpDownButton()
	{
		base.Focusable = false;
		base.ClickAutoRepeat = true;
	}

	public override void PerformLayout(PaintInfo pi)
	{
		int num = pi.AvailableSize.Height;
		if (num % 2 != 0)
		{
			num++;
		}
		Size size = new Size(int_1, num);
		if (image_0 != null && image_1 != null)
		{
			size.Width = Math.Max(image_0.get_Width(), image_1.get_Width());
		}
		base.Size = size;
		base.PerformLayout(pi);
	}

	protected override void OnPaint(PaintInfo p)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		Graphics graphics = p.Graphics;
		Rectangle renderBounds = base.RenderBounds;
		if (renderBounds.Width <= 0 || renderBounds.Height <= 0)
		{
			return;
		}
		Rectangle r = new Rectangle(renderBounds.X, renderBounds.Y, renderBounds.Width, renderBounds.Height / 2);
		if (image_0 != null)
		{
			graphics.DrawImage(image_0, r.Location);
		}
		else
		{
			Office2007ButtonItemStateColorTable office2007StateColorTableButtonUp = GetOffice2007StateColorTableButtonUp(p);
			PaintButtonBackground(p, office2007StateColorTableButtonUp, r);
			SolidBrush val = new SolidBrush(office2007StateColorTableButtonUp.Text);
			try
			{
				p.Graphics.FillPolygon((Brush)(object)val, Class265.smethod_2(r, ePopupSide.Top));
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		rectangle_2 = r;
		r = new Rectangle(renderBounds.X, r.Bottom, renderBounds.Width, renderBounds.Height - r.Height);
		if (image_1 != null)
		{
			graphics.DrawImage(image_1, r.Location);
		}
		else
		{
			Office2007ButtonItemStateColorTable office2007StateColorTableButtonDown = GetOffice2007StateColorTableButtonDown(p);
			PaintButtonBackground(p, office2007StateColorTableButtonDown, r);
			SolidBrush val2 = new SolidBrush(office2007StateColorTableButtonDown.Text);
			try
			{
				p.Graphics.FillPolygon((Brush)(object)val2, Class265.smethod_2(r, ePopupSide.Bottom));
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		rectangle_1 = r;
		base.OnPaint(p);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (GetIsEnabled())
		{
			if (rectangle_1.Contains(e.get_X(), e.get_Y()))
			{
				MouseOverButtonDown = true;
				MouseOverButtonUp = false;
			}
			else if (rectangle_2.Contains(e.get_X(), e.get_Y()))
			{
				MouseOverButtonUp = true;
				MouseOverButtonDown = false;
			}
			else
			{
				MouseOverButtonUp = false;
				MouseOverButtonDown = false;
			}
		}
		base.OnMouseMove(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && GetIsEnabled())
		{
			if (MouseOverButtonUp)
			{
				MouseDownButtonUp = true;
			}
			else if (MouseOverButtonDown)
			{
				MouseDownButtonDown = true;
			}
			method_0();
		}
		base.OnMouseDown(e);
	}

	private void method_0()
	{
		if (MouseOverButtonUp)
		{
			if (eUpDownButtonAutoChange_0 != 0 || visualItem_0 != null)
			{
				method_2();
			}
			OnUpClick(new EventArgs());
		}
		else if (MouseOverButtonDown)
		{
			if (eUpDownButtonAutoChange_0 != 0 || visualItem_0 != null)
			{
				method_1();
			}
			OnDownClick(new EventArgs());
		}
	}

	protected override void OnClickAutoRepeat()
	{
		method_0();
		base.OnClickAutoRepeat();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		MouseDownButtonDown = false;
		MouseDownButtonUp = false;
		base.OnMouseUp(e);
	}

	protected override void OnMouseLeave()
	{
		MouseOverButtonDown = false;
		MouseOverButtonUp = false;
		base.OnMouseLeave();
	}

	private void method_1()
	{
		VisualItem visualItem = method_3();
		if (visualItem != null)
		{
			VisualInputGroup visualInputGroup = null;
			if (visualItem.Parent is VisualInputGroup && !((VisualInputGroup)base.Parent).IsUserInput)
			{
				visualInputGroup = (VisualInputGroup)base.Parent;
				visualInputGroup.IsUserInput = true;
			}
			if (visualItem is VisualNumericInput)
			{
				((VisualNumericInput)visualItem).DecreaseValue();
			}
			else if (visualItem is VisualListInput)
			{
				((VisualListInput)visualItem).SelectNext();
			}
			if (visualInputGroup != null)
			{
				visualInputGroup.IsUserInput = false;
			}
		}
	}

	private void method_2()
	{
		VisualItem visualItem = method_3();
		if (visualItem != null)
		{
			VisualInputGroup visualInputGroup = null;
			if (visualItem.Parent is VisualInputGroup && !((VisualInputGroup)base.Parent).IsUserInput)
			{
				visualInputGroup = (VisualInputGroup)base.Parent;
				visualInputGroup.IsUserInput = true;
			}
			if (visualItem is VisualNumericInput)
			{
				((VisualNumericInput)visualItem).IncreaseValue();
			}
			else if (visualItem is VisualListInput)
			{
				((VisualListInput)visualItem).SelectPrevious();
			}
			if (visualInputGroup != null)
			{
				visualInputGroup.IsUserInput = false;
			}
		}
	}

	private VisualItem method_3()
	{
		if (visualItem_0 != null)
		{
			return visualItem_0;
		}
		if (eUpDownButtonAutoChange_0 != 0 && base.Parent != null && base.Parent != null)
		{
			VisualGroup parent = base.Parent;
			if (eUpDownButtonAutoChange_0 == eUpDownButtonAutoChange.FocusedItem)
			{
				if (parent.FocusedItem is VisualInputGroup)
				{
					VisualInputGroup visualInputGroup = parent.FocusedItem as VisualInputGroup;
					while (visualInputGroup.FocusedItem is VisualInputGroup)
					{
						visualInputGroup = visualInputGroup.FocusedItem as VisualInputGroup;
					}
					return visualInputGroup.FocusedItem;
				}
				if (!(parent.FocusedItem is VisualInputBase))
				{
					foreach (VisualItem item in parent.Items)
					{
						if (item is VisualInputBase && item.Enabled && item.Visible && item.Focusable)
						{
							return item;
						}
					}
				}
				return parent.FocusedItem;
			}
			int num = parent.Items.IndexOf(this);
			int num2 = num;
			VisualItem visualItem2;
			while (true)
			{
				if (num2 >= 0)
				{
					visualItem2 = parent.Items[num2];
					if (visualItem2 is VisualInputBase && visualItem2.Visible)
					{
						break;
					}
					num2--;
					continue;
				}
				return null;
			}
			return visualItem2;
		}
		return null;
	}

	protected virtual void OnUpClick(EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
		}
	}

	protected virtual void OnDownClick(EventArgs e)
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(this, e);
		}
	}

	private bool method_4(PaintInfo paintInfo_0)
	{
		if (base.RenderDefaultBackground)
		{
			return true;
		}
		if ((!paintInfo_0.MouseOver && !MouseDownButtonUp && !MouseDownButtonDown && !MouseOverButtonUp && !MouseOverButtonDown) || !GetIsEnabled())
		{
			return false;
		}
		return true;
	}

	protected virtual void PaintButtonBackground(PaintInfo p, Office2007ButtonItemStateColorTable ct, Rectangle r)
	{
		Graphics graphics = p.Graphics;
		if (method_4(p))
		{
			Class268.smethod_4(graphics, ct, r, RoundRectangleShapeDescriptor.RectangleShape);
		}
	}

	protected Office2007ButtonItemStateColorTable GetOffice2007StateColorTableButtonUp(PaintInfo p)
	{
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			Office2007ColorTable colorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = colorTable.ButtonItemColors[Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground)];
			if (GetIsEnabled(p) && bool_12)
			{
				if (MouseDownButtonUp)
				{
					return office2007ButtonItemColorTable.Pressed;
				}
				if (MouseOverButtonUp)
				{
					return office2007ButtonItemColorTable.MouseOver;
				}
				return office2007ButtonItemColorTable.Default;
			}
			return office2007ButtonItemColorTable.Disabled;
		}
		return null;
	}

	protected Office2007ButtonItemStateColorTable GetOffice2007StateColorTableButtonDown(PaintInfo p)
	{
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			Office2007ColorTable colorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = colorTable.ButtonItemColors[Enum.GetName(typeof(eButtonColor), eButtonColor.OrangeWithBackground)];
			if (GetIsEnabled(p) && bool_13)
			{
				if (MouseDownButtonDown)
				{
					return office2007ButtonItemColorTable.Pressed;
				}
				if (MouseOverButtonDown)
				{
					return office2007ButtonItemColorTable.MouseOver;
				}
				return office2007ButtonItemColorTable.Default;
			}
			return office2007ButtonItemColorTable.Disabled;
		}
		return null;
	}
}

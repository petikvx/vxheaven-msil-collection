using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public class ItemPaintArgs
{
	public Graphics Graphics;

	public ColorScheme Colors;

	public Control ContainerControl;

	public eTextFormat ButtonStringFormat;

	public bool IsOnMenu;

	public bool IsOnPopupBar;

	public bool IsOnMenuBar;

	public bool IsOnRibbonBar;

	public bool IsOnNavigationBar;

	public Font Font;

	public IOwner Owner;

	public bool RightToLeft;

	private Class77 class77_0;

	private Class78 class78_0;

	private Class79 class79_0;

	private Class65 class65_0;

	private Class63 class63_0;

	private Class81 class81_0;

	private Class64 class64_0;

	private Class82 class82_0;

	public bool DesignerSelection;

	public bool GlassEnabled;

	private BaseRenderer baseRenderer_0;

	public ButtonItemRendererEventArgs ButtonItemRendererEventArgs = new ButtonItemRendererEventArgs();

	public Rectangle ClipRectangle = Rectangle.Empty;

	public bool ControlExpanded = true;

	internal bool bool_0;

	internal bool bool_1;

	public bool IsFlatOffice2007Representation;

	internal BaseRenderer BaseRenderer_0
	{
		get
		{
			return baseRenderer_0;
		}
		set
		{
			baseRenderer_0 = value;
		}
	}

	internal Class77 Class77_0
	{
		get
		{
			if (class77_0 == null)
			{
				if (ContainerControl is Bar)
				{
					class77_0 = ((Bar)(object)ContainerControl).Class77_0;
				}
				else if (ContainerControl is Interface6)
				{
					class77_0 = ((Interface6)ContainerControl).Class77_0;
				}
			}
			return class77_0;
		}
	}

	internal Class78 Class78_0
	{
		get
		{
			if (class78_0 == null)
			{
				if (ContainerControl is Bar)
				{
					class78_0 = ((Bar)(object)ContainerControl).Class78_0;
				}
				else if (ContainerControl is Interface6)
				{
					class78_0 = ((Interface6)ContainerControl).Class78_0;
				}
			}
			return class78_0;
		}
	}

	internal Class79 Class79_0
	{
		get
		{
			if (class79_0 == null)
			{
				if (ContainerControl is Bar)
				{
					class79_0 = ((Bar)(object)ContainerControl).Class79_0;
				}
				else if (ContainerControl is Interface6)
				{
					class79_0 = ((Interface6)ContainerControl).Class79_0;
				}
			}
			return class79_0;
		}
	}

	internal Class65 Class65_0
	{
		get
		{
			if (class65_0 == null)
			{
				if (ContainerControl is Bar)
				{
					class65_0 = ((Bar)(object)ContainerControl).Class65_0;
				}
				else if (ContainerControl is Interface6)
				{
					class65_0 = ((Interface6)ContainerControl).Class65_0;
				}
			}
			return class65_0;
		}
	}

	internal Class63 Class63_0
	{
		get
		{
			if (class63_0 == null)
			{
				if (ContainerControl is Bar)
				{
					class63_0 = ((Bar)(object)ContainerControl).Class63_0;
				}
				else if (ContainerControl is Interface6)
				{
					class63_0 = ((Interface6)ContainerControl).Class63_0;
				}
			}
			return class63_0;
		}
	}

	internal Class81 Class81_0
	{
		get
		{
			if (class81_0 == null && ContainerControl is Interface6)
			{
				class81_0 = ((Interface6)ContainerControl).Class81_0;
			}
			return class81_0;
		}
	}

	internal Class64 Class64_0
	{
		get
		{
			if (class64_0 == null)
			{
				if (ContainerControl is Bar)
				{
					class64_0 = ((Bar)(object)ContainerControl).Class64_0;
				}
				else if (ContainerControl is Interface6)
				{
					class64_0 = ((Interface6)ContainerControl).Class64_0;
				}
			}
			return class64_0;
		}
	}

	internal Class82 Class82_0
	{
		get
		{
			if (class82_0 == null && ContainerControl is Interface6)
			{
				class82_0 = ((Interface6)ContainerControl).Class82_0;
			}
			return class82_0;
		}
	}

	public ItemPaintArgs(IOwner owner, Control control, Graphics g, ColorScheme scheme)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		Graphics = g;
		Colors = scheme;
		ContainerControl = control;
		Owner = owner;
		if (control != null)
		{
			RightToLeft = (int)control.get_RightToLeft() == 1;
		}
		if (!(control is MenuPanel) && !(ContainerControl is Class83))
		{
			if (control is Bar && ((Bar)(object)control).MenuBar)
			{
				IsOnMenuBar = true;
			}
			else if (control is Bar && ((Bar)(object)control).BarState == eBarState.Popup)
			{
				IsOnPopupBar = true;
			}
			else if (control is RibbonBar)
			{
				IsOnRibbonBar = true;
			}
			else if (control is NavigationBar)
			{
				IsOnNavigationBar = true;
			}
		}
		else
		{
			IsOnMenu = true;
		}
		if (control != null)
		{
			Font = control.get_Font();
		}
		method_0();
	}

	private void method_0()
	{
		eTextFormat eTextFormat2 = eTextFormat.Default;
		if (ContainerControl is ItemControl && (Owner == null || !Owner.AlwaysDisplayKeyAccelerators))
		{
			eTextFormat2 |= eTextFormat.HidePrefix;
		}
		else if ((Owner == null || !Owner.AlwaysDisplayKeyAccelerators) && !Class92.Boolean_0 && !IsOnMenu)
		{
			Bar bar = ContainerControl as Bar;
			if ((ContainerControl == null || !ContainerControl.get_Focused()) && (bar == null || !bar.Boolean_11) && (bar == null || !bar.AlwaysDisplayKeyAccelerators) && !(ContainerControl is NavigationBar))
			{
				eTextFormat2 |= eTextFormat.HidePrefix;
			}
		}
		eTextFormat2 = (ButtonStringFormat = eTextFormat2 | (eTextFormat.EndEllipsis | eTextFormat.SingleLine | eTextFormat.VerticalCenter));
	}
}

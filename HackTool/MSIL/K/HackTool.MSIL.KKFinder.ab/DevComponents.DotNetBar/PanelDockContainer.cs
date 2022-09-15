using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[Designer(typeof(PanelDockContainerDesigner))]
public class PanelDockContainer : PanelEx
{
	private const string string_1 = "Drop controls here. Drag and Drop tabs to perform docking.";

	private DockContainerItem dockContainerItem_0;

	private bool bool_11;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool AutoSize
	{
		get
		{
			return ((Panel)this).get_AutoSize();
		}
		set
		{
			((Panel)this).set_AutoSize(value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override AutoSizeMode AutoSizeMode
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Panel)this).get_AutoSizeMode();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Panel)this).set_AutoSizeMode(value);
		}
	}

	private eTabStripAlignment ETabStripAlignment_0
	{
		get
		{
			if (dockContainerItem_0 != null && dockContainerItem_0.ContainerControl is Bar)
			{
				return ((Bar)dockContainerItem_0.ContainerControl).DockTabAlignment;
			}
			return eTabStripAlignment.Top;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates whether style of the panel is managed by tab control automatically. Set this to true if you would like to control style of the panel.")]
	[DefaultValue(false)]
	public bool UseCustomStyle
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

	[DefaultValue(null)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public DockContainerItem DockContainerItem
	{
		get
		{
			return dockContainerItem_0;
		}
		set
		{
			dockContainerItem_0 = value;
		}
	}

	[Browsable(false)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override DockStyle Dock
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Dock();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Dock(value);
		}
	}

	[Browsable(false)]
	public Size Size
	{
		get
		{
			return ((Control)this).get_Size();
		}
		set
		{
			((Control)this).set_Size(value);
		}
	}

	[Browsable(false)]
	public Point Location
	{
		get
		{
			return ((Control)this).get_Location();
		}
		set
		{
			((Control)this).set_Location(value);
		}
	}

	[Browsable(false)]
	public bool Visible
	{
		get
		{
			return ((Control)this).get_Visible();
		}
		set
		{
			((Control)this).set_Visible(value);
		}
	}

	[Browsable(false)]
	public override AnchorStyles Anchor
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Anchor();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Anchor(value);
		}
	}

	public PanelDockContainer()
	{
		((Control)this).set_BackColor(SystemColors.Control);
	}

	private Rectangle method_9(Rectangle rectangle_1)
	{
		switch (ETabStripAlignment_0)
		{
		case eTabStripAlignment.Left:
			rectangle_1.X -= 6;
			rectangle_1.Width += 6;
			break;
		case eTabStripAlignment.Right:
			rectangle_1.Width += 6;
			break;
		case eTabStripAlignment.Top:
			rectangle_1.Y -= 6;
			rectangle_1.Height += 6;
			break;
		case eTabStripAlignment.Bottom:
			rectangle_1.Height += 6;
			break;
		}
		return rectangle_1;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		bool flag = true;
		if (bool_10 && Class109.Boolean_0 && dockContainerItem_0 != null)
		{
			Rectangle rectangle = method_9(((Control)this).get_ClientRectangle());
			eTabStripAlignment eTabStripAlignment_ = ETabStripAlignment_0;
			Rectangle rectangle2 = new Rectangle(0, 0, rectangle.Width, rectangle.Height);
			if (eTabStripAlignment_ == eTabStripAlignment.Right || eTabStripAlignment_ == eTabStripAlignment.Left)
			{
				rectangle2 = new Rectangle(0, 0, rectangle2.Height, rectangle2.Width);
			}
			if (m_ThemeCachedBitmap != null && !(((Image)m_ThemeCachedBitmap).get_Size() != rectangle2.Size))
			{
				e.get_Graphics().DrawImageUnscaled((Image)(object)m_ThemeCachedBitmap, rectangle.X, rectangle.Y);
			}
			else
			{
				DisposeThemeCachedBitmap();
				Bitmap val = new Bitmap(rectangle2.Width, rectangle2.Height, e.get_Graphics());
				try
				{
					Graphics val2 = Graphics.FromImage((Image)(object)val);
					try
					{
						SolidBrush val3 = new SolidBrush(Color.Transparent);
						try
						{
							val2.FillRectangle((Brush)(object)val3, 0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
						}
						finally
						{
							((IDisposable)val3)?.Dispose();
						}
						base.Class59_0.method_0(val2, Class119.class119_8, Class144.class144_2, rectangle2);
					}
					finally
					{
						val2.Dispose();
					}
				}
				finally
				{
					switch (eTabStripAlignment_)
					{
					case eTabStripAlignment.Left:
						((Image)val).RotateFlip((RotateFlipType)3);
						break;
					case eTabStripAlignment.Right:
						((Image)val).RotateFlip((RotateFlipType)1);
						break;
					case eTabStripAlignment.Bottom:
						((Image)val).RotateFlip((RotateFlipType)2);
						break;
					}
					e.get_Graphics().DrawImageUnscaled((Image)(object)val, rectangle.X, rectangle.Y);
					m_ThemeCachedBitmap = val;
				}
			}
			flag = false;
		}
		if (flag)
		{
			base.OnPaint(e);
		}
		if (((Component)(object)this).DesignMode && ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0 && ((Control)this).get_Text() == "")
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			clientRectangle.Inflate(-2, -2);
			Font val4 = new Font(((Control)this).get_Font(), (FontStyle)1);
			Class55.smethod_1(e.get_Graphics(), "Drop controls here. Drag and Drop tabs to perform docking.", val4, ControlPaint.Dark(base.Style.BackColor1.Color), clientRectangle, eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
			val4.Dispose();
		}
	}

	protected override void OnResize(EventArgs e)
	{
		DisposeThemeCachedBitmap();
		base.OnResize(e);
	}

	private TabStrip method_10()
	{
		TabStrip result = null;
		if (dockContainerItem_0 != null && dockContainerItem_0.ContainerControl is Bar)
		{
			Bar bar = dockContainerItem_0.ContainerControl as Bar;
			if (bar.DockSide == eDockSide.Document)
			{
				result = bar.DockTabControl;
			}
		}
		return result;
	}

	protected override void OnEnter(EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		TabStrip tabStrip = method_10();
		if (tabStrip == null)
		{
			return;
		}
		try
		{
			if (tabStrip.SelectedTabFont == null)
			{
				tabStrip.SelectedTabFont = new Font(((Control)tabStrip).get_Font(), (FontStyle)1);
			}
		}
		catch
		{
		}
		if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0)
		{
			Form val = ((Control)this).FindForm();
			if (val != null && (((ContainerControl)val).get_ActiveControl() == this || (((ContainerControl)val).get_ActiveControl() == tabStrip && tabStrip != null)))
			{
				((Control)this).SelectNextControl((Control)null, true, true, true, true);
			}
		}
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		TabStrip tabStrip = method_10();
		if (tabStrip != null)
		{
			if (tabStrip.SelectedTabFont != null)
			{
				tabStrip.SelectedTabFont = null;
			}
			((Control)this).OnLeave(e);
		}
	}
}

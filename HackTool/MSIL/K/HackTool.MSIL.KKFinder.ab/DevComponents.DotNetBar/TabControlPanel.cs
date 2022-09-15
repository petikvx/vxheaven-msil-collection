using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[Designer(typeof(TabControlPanelDesigner))]
[ToolboxItem(false)]
public class TabControlPanel : PanelEx
{
	private const string string_1 = "Drop controls on this panel to associate them with currently selected tab.";

	private TabItem tabItem_0;

	private bool bool_11;

	[Browsable(false)]
	[DefaultValue(null)]
	public TabItem TabItem
	{
		get
		{
			return tabItem_0;
		}
		set
		{
			tabItem_0 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Appearance")]
	[Description("Indicates whether style of the panel is managed by tab control automatically. Set this to true if you would like to control style of the panel.")]
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

	[Browsable(false)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
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

	public TabControlPanel()
	{
		((ScrollableControl)this).get_DockPadding().set_All(1);
		((Control)this).set_BackColor(SystemColors.Control);
	}

	private Rectangle method_9(Rectangle rectangle_1)
	{
		switch (tabItem_0.Parent.TabAlignment)
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
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		if (((Control)this).get_ClientRectangle().Width == 0 || ((Control)this).get_ClientRectangle().Height == 0 || (((Control)this).get_Parent() is TabControl && ((TabControl)(object)((Control)this).get_Parent()).SelectedPanel != this))
		{
			return;
		}
		bool flag = true;
		if (bool_10 && Class109.Boolean_0 && tabItem_0 != null && tabItem_0.Parent != null)
		{
			Rectangle rectangle = method_9(((Control)this).get_ClientRectangle());
			Rectangle rectangle2 = new Rectangle(0, 0, rectangle.Width, rectangle.Height);
			if (tabItem_0.Parent.TabAlignment == eTabStripAlignment.Right || tabItem_0.Parent.TabAlignment == eTabStripAlignment.Left)
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
					if (tabItem_0.Parent.TabAlignment == eTabStripAlignment.Left)
					{
						((Image)val).RotateFlip((RotateFlipType)3);
					}
					else if (tabItem_0.Parent.TabAlignment == eTabStripAlignment.Right)
					{
						((Image)val).RotateFlip((RotateFlipType)1);
					}
					else if (tabItem_0.Parent.TabAlignment == eTabStripAlignment.Bottom)
					{
						((Image)val).RotateFlip((RotateFlipType)2);
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
			Class55.smethod_1(e.get_Graphics(), "Drop controls on this panel to associate them with currently selected tab.", val4, ControlPaint.Dark(base.Style.BackColor1.Color), clientRectangle, eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
			val4.Dispose();
		}
	}

	protected override void OnResize(EventArgs e)
	{
		DisposeThemeCachedBitmap();
		base.OnResize(e);
	}
}

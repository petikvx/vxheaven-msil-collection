using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class PopupContainerControl : UserControl
{
	private BaseItem baseItem_0;

	private bool bool_0;

	private object object_0;

	private Point point_0 = Point.Empty;

	private Control8 control8_0;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((UserControl)this).get_CreateParams();
			createParams.set_Style(-2046820352);
			createParams.set_ExStyle(136);
			createParams.set_Caption("");
			return createParams;
		}
	}

	public BaseItem ParentItem
	{
		get
		{
			return baseItem_0;
		}
		set
		{
			baseItem_0 = value;
			if (baseItem_0.Displayed)
			{
				object containerControl = baseItem_0.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (BaseItem.IsHandleValid(val))
				{
					point_0 = val.PointToScreen(new Point(baseItem_0.LeftInternal, baseItem_0.TopInternal));
					val = null;
				}
			}
		}
	}

	public object Owner
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	public Rectangle ClientRectangle
	{
		get
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			if (Boolean_0)
			{
				if ((Boolean_1 && Boolean_2) || !Boolean_1)
				{
					clientRectangle.Inflate(-1, -1);
				}
				else
				{
					clientRectangle.Inflate(-2, -2);
					clientRectangle.Width--;
					clientRectangle.Height--;
				}
			}
			else
			{
				clientRectangle.Inflate(-2, -2);
			}
			return clientRectangle;
		}
	}

	public Size ClientSize
	{
		get
		{
			return ClientRectangle.Size;
		}
		set
		{
			Size clientSize = value;
			if (Boolean_0)
			{
				if ((Boolean_1 && Boolean_2) || !Boolean_1)
				{
					clientSize.Width += 2;
					clientSize.Height += 2;
				}
				else
				{
					clientSize.Width += 5;
					clientSize.Height += 5;
				}
			}
			else
			{
				clientSize.Width += 4;
				clientSize.Height += 4;
			}
			((Control)this).set_ClientSize(clientSize);
		}
	}

	private bool Boolean_0
	{
		get
		{
			if (baseItem_0 != null)
			{
				if (baseItem_0.Style != 0 && baseItem_0.Style != eDotNetBarStyle.Office2003 && baseItem_0.Style != eDotNetBarStyle.VS2005)
				{
					return Class109.smethod_69(baseItem_0.Style);
				}
				return true;
			}
			return true;
		}
	}

	private bool Boolean_1
	{
		get
		{
			if (baseItem_0.GetOwner() is IOwnerMenuSupport ownerMenuSupport)
			{
				if (baseItem_0 != null && baseItem_0.Style == eDotNetBarStyle.Office2000)
				{
					if (ownerMenuSupport.MenuDropShadow == eMenuDropShadow.Show)
					{
						return true;
					}
					return false;
				}
				return ownerMenuSupport.ShowPopupShadow;
			}
			if (baseItem_0 != null && baseItem_0.Style == eDotNetBarStyle.Office2000)
			{
				return false;
			}
			return true;
		}
	}

	private bool Boolean_2
	{
		get
		{
			if (Environment.OSVersion.Version.Major < 5)
			{
				return false;
			}
			if (object_0 is IOwnerMenuSupport ownerMenuSupport && !ownerMenuSupport.AlphaBlendShadow)
			{
				return false;
			}
			return Class92.Boolean_3;
		}
	}

	public PopupContainerControl()
	{
		_003F val = this;
		object obj = SystemInformation.get_MenuFont().Clone();
		((Control)val).set_Font((Font)((obj is Font) ? obj : null));
		((Control)this).SetStyle((ControlStyles)512, false);
	}

	protected override void Dispose(bool disposing)
	{
		if (control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
		((ContainerControl)this).Dispose(disposing);
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 33)
		{
			((Message)(ref m)).set_Result(new IntPtr(3));
		}
		else
		{
			((UserControl)this).WndProc(ref m);
		}
	}

	internal void method_0(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public void RecalcSize()
	{
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		if (Boolean_0)
		{
			if (Boolean_1 && !Boolean_2)
			{
				method_1();
			}
			Pen val = null;
			val = ((baseItem_0 != null && baseItem_0.ContainerControl is Bar) ? new Pen(((Bar)baseItem_0.ContainerControl).ColorScheme.ItemHotBorder, 1f) : ((baseItem_0 == null || !(baseItem_0.ContainerControl is MenuPanel) || ((MenuPanel)baseItem_0.ContainerControl).ColorScheme == null) ? new Pen(ColorFunctions.MenuFocusBorderColor(graphics), 1f) : new Pen(((MenuPanel)baseItem_0.ContainerControl).ColorScheme.ItemHotBorder, 1f)));
			if (Boolean_1 && !Boolean_2)
			{
				Class92.smethod_3(graphics, val, 0, 0, ((Control)this).get_ClientSize().Width - 2, ((Control)this).get_ClientSize().Height - 2);
			}
			else
			{
				Class92.smethod_3(graphics, val, 0, 0, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height);
			}
			if (Boolean_1 && !Boolean_2)
			{
				val.Dispose();
				val = new Pen(SystemColors.ControlDark, 2f);
				Point[] array = new Point[3];
				array[0].X = 2;
				array[0].Y = ((Control)this).get_ClientSize().Height - 1;
				array[1].X = ((Control)this).get_ClientSize().Width - 1;
				array[1].Y = ((Control)this).get_ClientSize().Height - 1;
				array[2].X = ((Control)this).get_ClientSize().Width - 1;
				array[2].Y = 2;
				graphics.DrawLines(val, array);
			}
			if (baseItem_0 is ButtonItem && baseItem_0.Displayed && baseItem_0.Style != eDotNetBarStyle.Office2007 && point_0.Y < ((Control)this).get_Location().Y)
			{
				Point point = new Point(point_0.X - ((Control)this).get_Location().X + 1, 0);
				Point point2 = new Point(point.X + baseItem_0.WidthInternal - 5, 0);
				graphics.DrawLine(new Pen(ColorFunctions.ToolMenuFocusBackColor(graphics), 1f), point, point2);
			}
		}
		else
		{
			ControlPaint.DrawBorder3D(graphics, ((Control)this).get_ClientRectangle(), (Border3DStyle)5, (Border3DSide)15);
		}
	}

	private void method_1()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if ((!Boolean_1 || !Boolean_2) && Boolean_1 && baseItem_0 != null)
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Region val = new Region(rectangle);
			rectangle.X = ((Control)this).get_Width() - 2;
			rectangle.Y = 0;
			rectangle.Width = 2;
			rectangle.Height = 2;
			val.Xor(rectangle);
			rectangle.X = 0;
			rectangle.Y = ((Control)this).get_Height() - 2;
			rectangle.Width = 2;
			rectangle.Height = 2;
			val.Xor(rectangle);
			((Control)this).set_Region(val);
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((ScrollableControl)this).OnVisibleChanged(e);
		if (!((Control)this).get_Visible() && control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
	}

	public void Show()
	{
		if (Boolean_1 && Boolean_2)
		{
			if (control8_0 != null)
			{
				((Control)control8_0).Hide();
				((Component)(object)control8_0).Dispose();
			}
			control8_0 = new Control8(bAlphaShadow: true);
			((Control)control8_0).CreateControl();
			Class92.SetWindowPos(((Control)control8_0).get_Handle(), -2, ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 80);
		}
		((Control)this).Show();
	}

	protected override void OnResize(EventArgs e)
	{
		((UserControl)this).OnResize(e);
	}
}

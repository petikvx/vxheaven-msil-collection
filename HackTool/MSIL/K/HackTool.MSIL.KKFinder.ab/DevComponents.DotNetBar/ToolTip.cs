using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.TextMarkup;
using Microsoft.Win32;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class ToolTip : Control
{
	private const long long_0 = 2147483648L;

	private const long long_1 = 67108864L;

	private const long long_2 = 33554432L;

	private const long long_3 = 128L;

	private const long long_4 = 8L;

	private string string_0;

	private Class261 class261_0;

	private eDotNetBarStyle eDotNetBarStyle_0 = eDotNetBarStyle.Office2003;

	private Control8 control8_0;

	private bool bool_0;

	public Rectangle ReferenceRectangle = Rectangle.Empty;

	private static bool bool_1 = true;

	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			if (MarkupEnabled && Class243.smethod_2(ref string_0))
			{
				class261_0 = Class243.smethod_0(string_0);
			}
			if (class261_0 != null)
			{
				AntiAlias = true;
			}
		}
	}

	public static bool MarkupEnabled
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public bool AntiAlias
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Control)this).get_CreateParams();
			createParams.set_Style(-2046820352);
			createParams.set_ExStyle(136);
			createParams.set_Caption("");
			return createParams;
		}
	}

	public eDotNetBarStyle Style
	{
		get
		{
			return eDotNetBarStyle_0;
		}
		set
		{
			eDotNetBarStyle_0 = value;
			if (Class109.smethod_69(eDotNetBarStyle_0))
			{
				AntiAlias = true;
			}
		}
	}

	public ToolTip()
	{
		string_0 = "";
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		_003F val = this;
		object obj = SystemInformation.get_MenuFont().Clone();
		((Control)val).set_Font((Font)((obj is Font) ? obj : null));
		((Control)this).set_BackColor(SystemColors.Control);
		((Control)this).set_ForeColor(SystemColors.ControlText);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Invalid comparison between Unknown and I4
		Color infoText = SystemColors.InfoText;
		Color color_ = SystemColors.Info;
		Color color_2 = Color.Empty;
		Color color = ColorScheme.GetColor("767676");
		if (Class109.smethod_69(eDotNetBarStyle_0) && ((Control)this).get_BackColor() == SystemColors.Control)
		{
			color_ = ColorScheme.GetColor("FFFFFF");
			color_2 = ColorScheme.GetColor("E4E4F0");
			infoText = ColorScheme.GetColor("4C4C4C");
		}
		else
		{
			infoText = method_2();
			if (((Control)this).get_BackColor() != SystemColors.Control)
			{
				color_ = ((Control)this).get_BackColor();
			}
		}
		Graphics graphics = e.get_Graphics();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if (bool_0)
		{
			graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
			graphics.set_SmoothingMode((SmoothingMode)4);
		}
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)3);
		if (Class109.smethod_69(eDotNetBarStyle_0))
		{
			Class50.smethod_6(graphics, color, clientRectangle);
		}
		else
		{
			ControlPaint.DrawBorder3D(graphics, clientRectangle, (Border3DStyle)5, (Border3DSide)2063);
		}
		clientRectangle.Inflate(-1, -1);
		Class50.smethod_24(graphics, clientRectangle, color_, color_2);
		clientRectangle.Offset(1, 0);
		graphics.set_SmoothingMode(smoothingMode);
		if (class261_0 == null)
		{
			Class55.smethod_1(graphics, method_0(), ((Control)this).get_Font(), infoText, clientRectangle, method_1());
			return;
		}
		Class263 d = new Class263(graphics, ((Control)this).get_Font(), infoText, (int)((Control)this).get_RightToLeft() == 1, e.get_ClipRectangle(), hotKeyPrefixVisible: true);
		class261_0.Bounds = new Rectangle(clientRectangle.Location, class261_0.Bounds.Size);
		class261_0.Render(d);
	}

	public void ShowToolTip()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		if (!((Control)this).get_IsHandleCreated())
		{
			((Control)this).CreateControl();
		}
		Size size = Size.Empty;
		Graphics val = ((Control)this).CreateGraphics();
		if (bool_0)
		{
			val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			val.set_SmoothingMode((SmoothingMode)4);
		}
		try
		{
			val.set_PageUnit((GraphicsUnit)2);
			if (class261_0 == null)
			{
				size = Class55.smethod_6(val, method_0(), ((Control)this).get_Font(), Screen.get_PrimaryScreen().get_WorkingArea().Size, method_1());
			}
			else
			{
				Class263 @class = new Class263(val, ((Control)this).get_Font(), SystemColors.Control, (int)((Control)this).get_RightToLeft() == 1);
				class261_0.Measure(Screen.get_PrimaryScreen().get_WorkingArea().Size, @class);
				size = class261_0.Bounds.Size;
				class261_0.method_2(new Rectangle(Point.Empty, size), @class);
			}
		}
		finally
		{
			val.set_SmoothingMode((SmoothingMode)0);
			val.set_TextRenderingHint((TextRenderingHint)0);
			val.Dispose();
		}
		val = null;
		Point mousePosition = Control.get_MousePosition();
		Rectangle rectangle = new Rectangle(Control.get_MousePosition().X, Control.get_MousePosition().Y, size.Width, size.Height);
		rectangle.Inflate(2, 2);
		rectangle.Offset(12, 24);
		Class273 class2 = Class109.smethod_52(mousePosition);
		if (class2 != null)
		{
			Size size2 = class2.rectangle_1.Size;
			size2.Width -= (int)((float)size2.Width * 0.2f);
			if (rectangle.Right > class2.rectangle_1.Right)
			{
				rectangle.X = rectangle.Left - (rectangle.Right - class2.rectangle_1.Right);
			}
			if (rectangle.Bottom > class2.rectangle_0.Bottom)
			{
				if (ReferenceRectangle.IsEmpty)
				{
					rectangle.Y = mousePosition.Y - rectangle.Height;
				}
				else
				{
					rectangle.Y = ReferenceRectangle.Y - rectangle.Height - 1;
				}
			}
			if (rectangle.Contains(Control.get_MousePosition().X, Control.get_MousePosition().Y))
			{
				if (rectangle.Height + Control.get_MousePosition().Y + 1 <= class2.rectangle_1.Height && (ReferenceRectangle.IsEmpty || !ReferenceRectangle.IntersectsWith(new Rectangle(rectangle.X, Control.get_MousePosition().Y + 1, rectangle.Width, rectangle.Height))))
				{
					rectangle.Y = Control.get_MousePosition().Y + 1;
				}
				else
				{
					rectangle.Y = Control.get_MousePosition().Y - rectangle.Height - 1;
				}
			}
		}
		((Control)this).set_Location(rectangle.Location);
		((Control)this).set_ClientSize(rectangle.Size);
		if (Class92.Boolean_1)
		{
			if (control8_0 == null)
			{
				control8_0 = new Control8(Class92.Boolean_2);
				((Control)control8_0).CreateControl();
			}
			((Control)control8_0).Hide();
		}
		Class92.SetWindowPos(((Control)this).get_Handle(), 0, 0, 0, 0, 0, 83);
		if (control8_0 != null)
		{
			Class92.SetWindowPos(((Control)control8_0).get_Handle(), ((Control)this).get_Handle().ToInt32(), rectangle.Left + 5, rectangle.Top + 5, rectangle.Width - 2, rectangle.Height - 2, 80);
			control8_0.method_1();
		}
	}

	private string method_0()
	{
		string text = string_0.Replace("\\\\n", "{spec_nl}");
		text = text.Replace("\\n", Environment.NewLine);
		return text.Replace("{spec_nl}", "\\n");
	}

	private eTextFormat method_1()
	{
		return eTextFormat.VerticalCenter | eTextFormat.WordBreak;
	}

	private Color method_2()
	{
		if (((Control)this).get_ForeColor() != SystemColors.ControlText)
		{
			return ((Control)this).get_ForeColor();
		}
		Color result = SystemColors.WindowText;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Colors\\", writable: false);
			string text = registryKey.GetValue("InfoText")!.ToString();
			registryKey.Close();
			registryKey = null;
			if (text != null && !(text == ""))
			{
				char[] separator = new char[1] { ' ' };
				string[] array = text.Split(separator, 3);
				if (array.GetUpperBound(0) == 2)
				{
					result = Color.FromArgb(Convert.ToInt16(array[0]), Convert.ToInt16(array[1]), Convert.ToInt16(array[2]));
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	protected override void OnLocationChanged(EventArgs e)
	{
		((Control)this).OnLocationChanged(e);
		if (control8_0 != null)
		{
			Class92.SetWindowPos(((Control)control8_0).get_Handle(), 0, ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, 0, 0, 81);
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (!((Control)this).get_Visible() && control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
		((Control)this).OnVisibleChanged(e);
	}
}

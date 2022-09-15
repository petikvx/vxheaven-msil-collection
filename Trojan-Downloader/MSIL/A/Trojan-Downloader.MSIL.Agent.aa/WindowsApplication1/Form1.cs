using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

public class Form1 : Form
{
	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("botc")]
	private ComboBox comboBox_0;

	[AccessedThroughProperty("Button1")]
	private Button button_0;

	[AccessedThroughProperty("l")]
	private ListBox listBox_0;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;

	public Point point_0;

	public Bitmap bitmap_0;

	public bool bool_0;

	private string[] string_1;

	private IContainer icontainer_0;

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetDC(int hwnd);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int BitBlt(int srchDC, int srcX, int srcY, int srcW, int srcH, int desthDC, int destX, int destY, int op);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SetPixel(long hDC, long X, long Y, long crColor);

	[DllImport("GDI32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long PolyBezier(long hDC, Point lppt, long cPoints);

	[DllImport("GDI32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long GetPixel(long hDC, long X, long Y);

	public static bool smethod_0(Color color_0)
	{
		if ((color_0.R == 0) & (color_0.G == 0) & (color_0.B == 0))
		{
			return true;
		}
		return false;
	}

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDeviceCaps(int hdc, int nIndex);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateCompatibleBitmap(int hDC, int nWidth, int nHeight);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateCompatibleDC(int hDC);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetBkMode(int hDC, int BkMode);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr CreateCompatibleDC(IntPtr hDC);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateDCA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDriverName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDeviceName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpOutput, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpInitData);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int DeleteDC(int hDC);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SelectObject(int hDC, int hObject);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReleaseDC(int hwnd, int hdc);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetPixel(int hDC, int x, int y);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CreatePen(int nPenStyle, int nWidth, int crColor);

	[DllImport("GDI32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int DeleteObject(int hObj);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int Ellipse(int hDC, int X1, int Y1, int X2, int Y2);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowDC(int hwnd);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MoveToEx(int hDC, int x, int y, ref int lpPoint);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int Rectangle(int hDC, int X1, int Y1, int X2, int Y2);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int TextOutA(int hDC, int x, int y, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int nCount);

	[DllImport("gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int LineTo(int hDC, int x, int y);

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_1 = new string[16]
		{
			"QXJtb3I=", "TWFnZQ==", "TmFrbWFjaGluZQ==", "VHJpY28=", "QmlnZm9vdA==", "Qm9vbWVy", "UmFvbg==", "TGlnaHRuaW5n", "Si5ELg==", "QS4gU3RhdGU=",
			"SWNl", "VHVydGxl", "R3J1Yg==", "QWR1a2E=", "RHJhZ29u", "S25pZ2h0"
		};
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[SpecialName]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Timer timer_1)
	{
		if (timer_0 != null)
		{
			timer_0.remove_Tick((EventHandler)timer_0_Tick);
		}
		timer_0 = timer_1;
		if (timer_0 != null)
		{
			timer_0.add_Tick((EventHandler)timer_0_Tick);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_2(ListBox listBox_1)
	{
		if (listBox_0 == null)
		{
		}
		listBox_0 = listBox_1;
		if (listBox_0 != null)
		{
		}
	}

	[SpecialName]
	internal virtual ListBox vmethod_3()
	{
		return listBox_0;
	}

	[SpecialName]
	internal virtual ComboBox vmethod_4()
	{
		return comboBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(ComboBox comboBox_1)
	{
		if (comboBox_0 != null)
		{
			comboBox_0.remove_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		}
		comboBox_0 = comboBox_1;
		if (comboBox_0 != null)
		{
			comboBox_0.add_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		}
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label label_1)
	{
		if (label_0 == null)
		{
		}
		label_0 = label_1;
		if (label_0 != null)
		{
		}
	}

	[SpecialName]
	internal virtual Button vmethod_8()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Button button_1)
	{
		if (button_0 != null)
		{
			((Control)button_0).remove_Click((EventHandler)button_0_Click);
		}
		button_0 = button_1;
		if (button_0 != null)
		{
			((Control)button_0).add_Click((EventHandler)button_0_Click);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		icontainer_0 = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(Form1));
		vmethod_1(new Timer(icontainer_0));
		vmethod_2(new ListBox());
		vmethod_5(new ComboBox());
		vmethod_7(new Label());
		vmethod_9(new Button());
		((Control)this).SuspendLayout();
		vmethod_0().set_Enabled(true);
		vmethod_3().set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)vmethod_3()).set_Enabled(false);
		vmethod_3().set_ItemHeight(14);
		ListBox obj = vmethod_3();
		Point location = new Point(4, 28);
		((Control)obj).set_Location(location);
		((Control)vmethod_3()).set_Name("l");
		ListBox obj2 = vmethod_3();
		Size size = new Size(129, 60);
		((Control)obj2).set_Size(size);
		((Control)vmethod_3()).set_TabIndex(0);
		((Control)vmethod_4()).set_Anchor((AnchorStyles)11);
		vmethod_4().set_BackColor(Color.FromArgb(224, 224, 224));
		vmethod_4().set_DropDownStyle((ComboBoxStyle)2);
		vmethod_4().set_ItemHeight(14);
		ComboBox obj3 = vmethod_4();
		location = new Point(3, 3);
		((Control)obj3).set_Location(location);
		vmethod_4().set_MaxDropDownItems(16);
		((Control)vmethod_4()).set_Name("botc");
		ComboBox obj4 = vmethod_4();
		size = new Size(131, 22);
		((Control)obj4).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(4);
		vmethod_6().set_AutoSize(true);
		((Control)vmethod_6()).set_ForeColor(Color.FromArgb(64, 64, 64));
		Label obj5 = vmethod_6();
		location = new Point(22, 88);
		((Control)obj5).set_Location(location);
		((Control)vmethod_6()).set_Name("Label1");
		Label obj6 = vmethod_6();
		size = new Size(89, 18);
		((Control)obj6).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(5);
		((Control)vmethod_6()).set_Text("Lê Hồng Quang");
		((Control)vmethod_8()).set_ForeColor(Color.Black);
		Button obj7 = vmethod_8();
		location = new Point(20, 105);
		((Control)obj7).set_Location(location);
		((Control)vmethod_8()).set_Name("Button1");
		Button obj8 = vmethod_8();
		size = new Size(96, 26);
		((Control)obj8).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(6);
		((Control)vmethod_8()).set_Text("Hướng dẫn nè");
		size = new Size(6, 15);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_BackColor(Color.FromArgb(224, 224, 224));
		size = new Size(137, 135);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_3());
		((Control)this).set_Font(new Font("Tahoma", 12f, (FontStyle)0, (GraphicsUnit)2, (byte)0));
		((Control)this).set_ForeColor(Color.FromArgb(192, 192, 255));
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("  YM : le_hong_wang");
		((Control)this).ResumeLayout(false);
	}

	public static object smethod_1(string string_2)
	{
		string text = string_2.ToLower();
		if (StringType.StrCmp(text, "armor", false) == 0)
		{
			return 230;
		}
		if (StringType.StrCmp(text, "mage", false) == 0)
		{
			return 225;
		}
		if (StringType.StrCmp(text, "nakmachine", false) == 0)
		{
			return 205;
		}
		if (StringType.StrCmp(text, "trico", false) == 0)
		{
			return 215;
		}
		if (StringType.StrCmp(text, "bigfoot", false) == 0)
		{
			return 210;
		}
		if (StringType.StrCmp(text, "boomer", false) == 0)
		{
			return 175;
		}
		if (StringType.StrCmp(text, "raon", false) == 0)
		{
			return 220;
		}
		if (StringType.StrCmp(text, "lightning", false) == 0)
		{
			return 235;
		}
		if (StringType.StrCmp(text, "j.d.", false) == 0)
		{
			return 250;
		}
		if (StringType.StrCmp(text, "a. state", false) == 0)
		{
			return 225;
		}
		if (StringType.StrCmp(text, "ice", false) == 0)
		{
			return 250;
		}
		if (StringType.StrCmp(text, "turtle", false) == 0)
		{
			return 230;
		}
		if (StringType.StrCmp(text, "grub", false) == 0)
		{
			return 250;
		}
		if (StringType.StrCmp(text, "aduka", false) == 0)
		{
			return 240;
		}
		if (StringType.StrCmp(text, "dragon", false) == 0)
		{
			return 250;
		}
		if (StringType.StrCmp(text, "knight", false) == 0)
		{
			return 240;
		}
		object result = default(object);
		return result;
	}

	public static int smethod_2(string string_2)
	{
		string text = string_2.ToLower();
		if (StringType.StrCmp(text, "armor", false) == 0)
		{
			return Information.RGB(255, 0, 0);
		}
		if (StringType.StrCmp(text, "mage", false) == 0)
		{
			return Information.RGB(0, 0, 255);
		}
		if (StringType.StrCmp(text, "nakmachine", false) == 0)
		{
			return Information.RGB(255, 128, 64);
		}
		if (StringType.StrCmp(text, "trico", false) == 0)
		{
			return Information.RGB(0, 255, 0);
		}
		if (StringType.StrCmp(text, "bigfoot", false) == 0)
		{
			return Information.RGB(0, 0, 255);
		}
		if (StringType.StrCmp(text, "boomer", false) == 0)
		{
			return Information.RGB(128, 64, 255);
		}
		if (StringType.StrCmp(text, "raon", false) == 0)
		{
			return Information.RGB(255, 0, 0);
		}
		if (StringType.StrCmp(text, "lightning", false) == 0)
		{
			return Information.RGB(0, 0, 255);
		}
		if (StringType.StrCmp(text, "j.d.", false) == 0)
		{
			return Information.RGB(255, 0, 0);
		}
		if (StringType.StrCmp(text, "a. state", false) == 0)
		{
			return Information.RGB(0, 255, 0);
		}
		if (StringType.StrCmp(text, "ice", false) == 0)
		{
			return Information.RGB(0, 255, 255);
		}
		if (StringType.StrCmp(text, "turtle", false) == 0)
		{
			return Information.RGB(0, 255, 0);
		}
		if (StringType.StrCmp(text, "grub", false) == 0)
		{
			return 13382655;
		}
		if (StringType.StrCmp(text, "aduka", false) == 0)
		{
			return 13382655;
		}
		if (StringType.StrCmp(text, "dragon", false) == 0)
		{
			return 13382655;
		}
		if (StringType.StrCmp(text, "knight", false) == 0)
		{
			return Information.RGB((int)Color.Magenta.R, (int)Color.Magenta.B, (int)Color.Magenta.G);
		}
		int result = default(int);
		return result;
	}

	public static object smethod_3(string string_2)
	{
		string text = string_2.ToLower();
		if (StringType.StrCmp(text, "armor", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "mage", false) == 0)
		{
			return 90;
		}
		if (StringType.StrCmp(text, "nakmachine", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "trico", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "bigfoot", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "boomer", false) == 0)
		{
			return 45;
		}
		if (StringType.StrCmp(text, "raon", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "lightning", false) == 0)
		{
			return 90;
		}
		if (StringType.StrCmp(text, "j.d.", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "a. state", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "ice", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "turtle", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "grub", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "aduka", false) == 0)
		{
			return 94;
		}
		if (StringType.StrCmp(text, "dragon", false) == 0)
		{
			return 98;
		}
		if (StringType.StrCmp(text, "knight", false) == 0)
		{
			return 90;
		}
		object result = default(object);
		return result;
	}

	public static object smethod_4()
	{
		object result = default(object);
		try
		{
			ProjectData.ClearProjectError();
			int dC = GetDC(0);
			int num = CreateCompatibleDC(dC);
			int num2 = CreateCompatibleBitmap(dC, 1, 1);
			SelectObject(num, num2);
			BitBlt(num, 0, 0, 1, 1, dC, 1, 1, 13369376);
			Color color = Color.FromArgb(GetPixel(num, 0, 0));
			DeleteDC(num);
			DeleteObject(num2);
			ReleaseDC(0, dC);
			if ((color.B == 24) & (color.G == 97) & (color.R == 165))
			{
				ReleaseDC(0, dC);
				result = true;
			}
			else
			{
				ReleaseDC(0, dC);
				result = false;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int num3 = default(int);
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object smethod_5()
	{
		object result = default(object);
		int num6 = default(int);
		try
		{
			ProjectData.ClearProjectError();
			int num = 1;
			int dC = GetDC(0);
			int num2 = CreateCompatibleDC(dC);
			int num3 = CreateCompatibleBitmap(dC, 26, 12);
			SelectObject(num2, num3);
			BitBlt(num2, 0, 0, 26, 12, dC, 137, 580, 13369376);
			int value = SelectObject(num2, num3);
			IntPtr intPtr = new IntPtr(value);
			Bitmap val = Image.FromHbitmap(intPtr);
			DeleteDC(num2);
			DeleteObject(num3);
			ReleaseDC(0, dC);
			bool flag = ((StringType.StrCmp(val.GetPixel(1, 5).ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) ? true : false);
			Color pixel = val.GetPixel(8, 1);
			Color pixel2 = val.GetPixel(13, 1);
			Color pixel3 = val.GetPixel(13, 10);
			Color pixel4 = val.GetPixel(8, 10);
			Color pixel5 = val.GetPixel(11, 5);
			short num4 = default(short);
			bool flag2 = default(bool);
			Color pixel7;
			Color pixel6;
			if ((StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
			{
				num4 = 0;
				flag2 = true;
			}
			else
			{
				pixel5 = val.GetPixel(8, 1);
				pixel4 = val.GetPixel(13, 1);
				pixel3 = val.GetPixel(13, 10);
				pixel2 = val.GetPixel(8, 10);
				pixel = val.GetPixel(9, 6);
				if ((StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
				{
					num4 = 1;
					flag2 = true;
				}
				else
				{
					pixel5 = val.GetPixel(8, 1);
					pixel4 = val.GetPixel(13, 1);
					pixel3 = val.GetPixel(13, 10);
					pixel2 = val.GetPixel(8, 10);
					pixel = val.GetPixel(13, 8);
					if ((StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
					{
						num4 = 2;
						flag2 = true;
					}
					else
					{
						pixel5 = val.GetPixel(8, 1);
						pixel4 = val.GetPixel(8, 3);
						pixel3 = val.GetPixel(8, 5);
						pixel2 = val.GetPixel(8, 9);
						pixel = val.GetPixel(8, 7);
						if ((StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
						{
							num4 = 3;
							flag2 = true;
						}
						else
						{
							pixel5 = val.GetPixel(8, 1);
							pixel4 = val.GetPixel(13, 1);
							pixel3 = val.GetPixel(13, 10);
							pixel2 = val.GetPixel(8, 10);
							pixel = val.GetPixel(11, 1);
							if ((StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
							{
								num4 = 4;
								flag2 = true;
							}
							else
							{
								pixel5 = val.GetPixel(8, 1);
								pixel4 = val.GetPixel(13, 1);
								pixel3 = val.GetPixel(13, 10);
								pixel2 = val.GetPixel(8, 10);
								pixel = val.GetPixel(13, 4);
								if ((StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
								{
									num4 = 5;
									flag2 = true;
								}
								else
								{
									pixel5 = val.GetPixel(8, 1);
									pixel4 = val.GetPixel(13, 1);
									pixel3 = val.GetPixel(13, 10);
									pixel2 = val.GetPixel(8, 10);
									if ((StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0))
									{
										num4 = 6;
										flag2 = true;
									}
									else
									{
										pixel5 = val.GetPixel(8, 1);
										pixel4 = val.GetPixel(13, 1);
										pixel3 = val.GetPixel(13, 10);
										pixel2 = val.GetPixel(8, 10);
										pixel = val.GetPixel(9, 6);
										if ((StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
										{
											num4 = 7;
											flag2 = true;
										}
										else
										{
											pixel5 = val.GetPixel(8, 1);
											pixel4 = val.GetPixel(13, 1);
											pixel3 = val.GetPixel(13, 10);
											pixel2 = val.GetPixel(8, 10);
											pixel = val.GetPixel(10, 6);
											pixel6 = val.GetPixel(8, 7);
											pixel7 = val.GetPixel(13, 7);
											if ((StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0))
											{
												num4 = 8;
												flag2 = true;
											}
											else
											{
												pixel7 = val.GetPixel(8, 1);
												pixel6 = val.GetPixel(13, 1);
												pixel5 = val.GetPixel(13, 10);
												pixel4 = val.GetPixel(8, 10);
												pixel3 = val.GetPixel(8, 6);
												pixel2 = val.GetPixel(13, 4);
												pixel = val.GetPixel(11, 1);
												if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0))
												{
													num4 = 9;
													flag2 = true;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			pixel7 = val.GetPixel(16, 1);
			pixel6 = val.GetPixel(21, 1);
			pixel5 = val.GetPixel(21, 10);
			pixel4 = val.GetPixel(16, 10);
			pixel3 = val.GetPixel(19, 5);
			short num5 = default(short);
			bool flag3 = default(bool);
			if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
			{
				num5 = 0;
				flag3 = true;
			}
			else
			{
				pixel7 = val.GetPixel(16, 1);
				pixel6 = val.GetPixel(21, 1);
				pixel5 = val.GetPixel(21, 10);
				pixel4 = val.GetPixel(16, 10);
				pixel3 = val.GetPixel(17, 6);
				if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
				{
					num5 = 1;
					flag3 = true;
				}
				else
				{
					pixel7 = val.GetPixel(16, 1);
					pixel6 = val.GetPixel(21, 1);
					pixel5 = val.GetPixel(21, 10);
					pixel4 = val.GetPixel(16, 10);
					pixel3 = val.GetPixel(21, 8);
					if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
					{
						num5 = 2;
						flag3 = true;
					}
					else
					{
						pixel7 = val.GetPixel(16, 1);
						pixel6 = val.GetPixel(16, 3);
						pixel5 = val.GetPixel(16, 5);
						pixel4 = val.GetPixel(16, 9);
						pixel3 = val.GetPixel(16, 7);
						if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
						{
							num5 = 3;
							flag3 = true;
						}
						else
						{
							pixel7 = val.GetPixel(16, 1);
							pixel6 = val.GetPixel(21, 1);
							pixel5 = val.GetPixel(21, 10);
							pixel4 = val.GetPixel(16, 10);
							pixel3 = val.GetPixel(19, 1);
							if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
							{
								num5 = 4;
								flag3 = true;
							}
							else
							{
								pixel7 = val.GetPixel(16, 1);
								pixel6 = val.GetPixel(21, 1);
								pixel5 = val.GetPixel(21, 10);
								pixel4 = val.GetPixel(16, 10);
								pixel3 = val.GetPixel(21, 4);
								if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
								{
									num5 = 5;
									flag3 = true;
								}
								else
								{
									pixel7 = val.GetPixel(16, 1);
									pixel6 = val.GetPixel(21, 1);
									pixel5 = val.GetPixel(21, 10);
									pixel4 = val.GetPixel(16, 10);
									if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0))
									{
										num5 = 6;
										flag3 = true;
									}
									else
									{
										pixel7 = val.GetPixel(16, 1);
										pixel6 = val.GetPixel(21, 1);
										pixel5 = val.GetPixel(21, 10);
										pixel4 = val.GetPixel(16, 10);
										pixel3 = val.GetPixel(17, 6);
										if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0))
										{
											num5 = 7;
											flag3 = true;
										}
										else
										{
											pixel7 = val.GetPixel(16, 1);
											pixel6 = val.GetPixel(21, 1);
											pixel5 = val.GetPixel(21, 10);
											pixel4 = val.GetPixel(16, 10);
											pixel3 = val.GetPixel(18, 6);
											pixel2 = val.GetPixel(16, 7);
											pixel = val.GetPixel(21, 7);
											if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0))
											{
												num5 = 8;
												flag3 = true;
											}
											else
											{
												pixel7 = val.GetPixel(16, 1);
												pixel6 = val.GetPixel(21, 1);
												pixel5 = val.GetPixel(21, 10);
												pixel4 = val.GetPixel(16, 10);
												pixel3 = val.GetPixel(16, 6);
												pixel2 = val.GetPixel(21, 4);
												pixel = val.GetPixel(19, 1);
												if ((StringType.StrCmp(pixel7.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel6.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel5.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel4.ToString(), "Color [A=255, R=255, G=243, B=0]", false) != 0) & (StringType.StrCmp(pixel3.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel2.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0) & (StringType.StrCmp(pixel.ToString(), "Color [A=255, R=255, G=243, B=0]", false) == 0))
												{
													num5 = 9;
													flag3 = true;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			int num7;
			do
			{
				((Image)val).Dispose();
				if (!(flag2 && flag3))
				{
					string text = StringType.FromInteger(0);
					result = text;
				}
				else if (!flag)
				{
					string text = StringType.FromInteger(checked(num4 * 10 + num5));
					result = text;
				}
				else
				{
					string text = StringType.FromInteger(checked(-(num4 * 10 + num5)));
					result = text;
				}
				if (num6 == 0)
				{
					num6 = -1;
					num7 = num;
					continue;
				}
				break;
			}
			while (num7 == 1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (num6 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object smethod_6()
	{
		checked
		{
			object result = default(object);
			try
			{
				ProjectData.ClearProjectError();
				int dC = GetDC(0);
				int num = CreateCompatibleDC(dC);
				int num2 = CreateCompatibleBitmap(dC, 400, 1);
				SelectObject(num, num2);
				BitBlt(num, 0, 0, 400, 1, dC, 244, 566, 13369376);
				int value = SelectObject(num, num2);
				IntPtr intPtr = new IntPtr(value);
				Bitmap val = Image.FromHbitmap(intPtr);
				DeleteDC(num);
				DeleteObject(num2);
				ReleaseDC(0, dC);
				int num3 = 0;
				while (true)
				{
					Color pixel = val.GetPixel(num3, 0);
					if (!((pixel.R == 0) & (pixel.G == 0) & (pixel.B == 0)))
					{
						num3++;
						if (num3 > 400)
						{
							((Image)val).Dispose();
							result = 0;
							break;
						}
						continue;
					}
					((Image)val).Dispose();
					result = num3 + 5;
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			int num4 = default(int);
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static object smethod_7()
	{
		object result = default(object);
		try
		{
			ProjectData.ClearProjectError();
			int dC = GetDC(0);
			int num = CreateCompatibleDC(dC);
			int num2 = CreateCompatibleBitmap(dC, 23, 19);
			SelectObject(num, num2);
			BitBlt(num, 0, 0, 23, 19, dC, 389, 59, 13369376);
			int value = SelectObject(num, num2);
			IntPtr intPtr = new IntPtr(value);
			object obj = Image.FromHbitmap(intPtr);
			DeleteDC(num);
			DeleteObject(num2);
			ReleaseDC(0, dC);
			object[] array = new object[2] { 4, 1 };
			object[] array2 = new object[2] { 1, 1 };
			if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
			{
				array2 = new object[2] { 12, 1 };
				array = new object[2] { 21, 1 };
				object[] array3 = new object[2] { 12, 17 };
				object[] array4 = new object[2] { 21, 17 };
				object[] array5 = new object[2] { 16, 10 };
				if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
				{
					LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
					result = 10;
				}
				else
				{
					array5 = new object[2] { 10, 1 };
					array4 = new object[2] { 10, 17 };
					array3 = new object[2] { 15, 1 };
					array2 = new object[2] { 18, 1 };
					array = new object[2] { 18, 17 };
					object[] array6 = new object[2] { 14, 1 };
					if (!smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
					{
						LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
						result = 11;
					}
					else
					{
						array6 = new object[2] { 12, 1 };
						array5 = new object[2] { 12, 7 };
						array4 = new object[2] { 12, 10 };
						array3 = new object[2] { 12, 17 };
						array2 = new object[2] { 21, 12 };
						array = new object[2] { 21, 17 };
						if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
						{
							LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
							result = 12;
						}
						else
						{
							array6 = new object[2] { 12, 1 };
							array5 = new object[2] { 12, 5 };
							array4 = new object[2] { 12, 8 };
							array3 = new object[2] { 12, 12 };
							array2 = new object[2] { 12, 15 };
							array = new object[2] { 21, 9 };
							if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
							{
								LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
								result = 13;
							}
							else
							{
								array6 = new object[2] { 12, 1 };
								array5 = new object[2] { 12, 17 };
								array4 = new object[2] { 21, 1 };
								array3 = new object[2] { 12, 12 };
								array2 = new object[2] { 8, 1 };
								array = new object[2] { 16, 1 };
								if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
								{
									LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
									result = 14;
								}
								else
								{
									array6 = new object[2] { 12, 1 };
									array5 = new object[2] { 12, 10 };
									array4 = new object[2] { 12, 14 };
									array3 = new object[2] { 12, 17 };
									array2 = new object[2] { 21, 5 };
									array = new object[2] { 21, 17 };
									if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
									{
										LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
										result = 15;
									}
									else
									{
										array6 = new object[2] { 12, 1 };
										array5 = new object[2] { 12, 7 };
										array4 = new object[2] { 12, 14 };
										array3 = new object[2] { 16, 8 };
										array2 = new object[2] { 21, 7 };
										array = new object[2] { 17, 10 };
										if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
										{
											LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
											result = 16;
										}
										else
										{
											array6 = new object[2] { 12, 1 };
											array5 = new object[2] { 21, 1 };
											array4 = new object[2] { 21, 9 };
											array3 = new object[2] { 21, 17 };
											array2 = new object[2] { 12, 8 };
											array = new object[2] { 16, 9 };
											object[] array7 = new object[2] { 12, 17 };
											if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
											{
												LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
												result = 17;
											}
											else
											{
												array7 = new object[2] { 12, 1 };
												array6 = new object[2] { 12, 17 };
												array5 = new object[2] { 21, 1 };
												array4 = new object[2] { 17, 8 };
												array3 = new object[2] { 12, 12 };
												array2 = new object[2] { 21, 17 };
												if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
												{
													LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
													result = 18;
												}
												else
												{
													array7 = new object[2] { 12, 1 };
													array6 = new object[2] { 12, 17 };
													array5 = new object[2] { 21, 1 };
													array4 = new object[2] { 12, 11 };
													array3 = new object[2] { 16, 10 };
													array2 = new object[2] { 21, 13 };
													if (!(smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color))))))
													{
														goto IL_3e1f;
													}
													LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
													result = 19;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				object[] array7 = new object[2] { 1, 1 };
				if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
				{
					array7 = new object[2] { 12, 1 };
					object[] array6 = new object[2] { 21, 1 };
					object[] array5 = new object[2] { 12, 17 };
					object[] array4 = new object[2] { 21, 17 };
					object[] array3 = new object[2] { 16, 10 };
					if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
					{
						LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
						result = 20;
					}
					else
					{
						array7 = new object[2] { 10, 1 };
						array6 = new object[2] { 10, 17 };
						array5 = new object[2] { 15, 1 };
						array4 = new object[2] { 18, 1 };
						array3 = new object[2] { 18, 17 };
						array2 = new object[2] { 21, 17 };
						if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
						{
							LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
							result = 21;
						}
						else
						{
							array7 = new object[2] { 12, 1 };
							array6 = new object[2] { 12, 7 };
							array5 = new object[2] { 12, 10 };
							array4 = new object[2] { 12, 17 };
							array3 = new object[2] { 21, 12 };
							array2 = new object[2] { 21, 17 };
							if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
							{
								LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
								result = 22;
							}
							else
							{
								array7 = new object[2] { 12, 1 };
								array6 = new object[2] { 12, 5 };
								array5 = new object[2] { 12, 8 };
								array4 = new object[2] { 12, 12 };
								array3 = new object[2] { 12, 15 };
								array2 = new object[2] { 21, 9 };
								if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
								{
									LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
									result = 23;
								}
								else
								{
									array7 = new object[2] { 12, 1 };
									array6 = new object[2] { 12, 17 };
									array5 = new object[2] { 21, 1 };
									array4 = new object[2] { 12, 12 };
									array3 = new object[2] { 10, 10 };
									if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
									{
										LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
										result = 24;
									}
									else
									{
										array7 = new object[2] { 12, 1 };
										array6 = new object[2] { 12, 10 };
										array5 = new object[2] { 12, 14 };
										array4 = new object[2] { 12, 17 };
										array3 = new object[2] { 21, 5 };
										array2 = new object[2] { 21, 17 };
										if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
										{
											LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
											result = 25;
										}
										else
										{
											array7 = new object[2] { 12, 1 };
											array6 = new object[2] { 12, 7 };
											array5 = new object[2] { 12, 14 };
											array4 = new object[2] { 16, 8 };
											array3 = new object[2] { 21, 7 };
											array2 = new object[2] { 17, 10 };
											if (!(smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color))))))
											{
												goto IL_3e1f;
											}
											LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
											result = 26;
										}
									}
								}
							}
						}
					}
				}
				else
				{
					array7 = new object[2] { 7, 1 };
					object[] array6 = new object[2] { 16, 1 };
					object[] array5 = new object[2] { 7, 17 };
					object[] array4 = new object[2] { 16, 17 };
					object[] array3 = new object[2] { 11, 10 };
					if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
					{
						LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
						result = 0;
					}
					else
					{
						array7 = new object[2] { 7, 1 };
						array6 = new object[2] { 7, 17 };
						array5 = new object[2] { 10, 1 };
						array4 = new object[2] { 13, 1 };
						array3 = new object[2] { 13, 17 };
						if (!smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
						{
							LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
							result = 1;
						}
						else
						{
							array7 = new object[2] { 7, 1 };
							array6 = new object[2] { 7, 7 };
							array5 = new object[2] { 7, 10 };
							array4 = new object[2] { 7, 17 };
							array3 = new object[2] { 16, 12 };
							array2 = new object[2] { 16, 17 };
							if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
							{
								LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
								result = 2;
							}
							else
							{
								array7 = new object[2] { 7, 1 };
								array6 = new object[2] { 7, 5 };
								array5 = new object[2] { 7, 8 };
								array4 = new object[2] { 7, 12 };
								array3 = new object[2] { 7, 15 };
								array2 = new object[2] { 16, 9 };
								if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
								{
									LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
									result = 3;
								}
								else
								{
									array7 = new object[2] { 11, 1 };
									array6 = new object[2] { 7, 1 };
									array5 = new object[2] { 16, 1 };
									array4 = new object[2] { 7, 17 };
									if (!smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
									{
										LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
										result = 4;
									}
									else
									{
										array7 = new object[2] { 7, 1 };
										array6 = new object[2] { 7, 10 };
										array5 = new object[2] { 7, 14 };
										array4 = new object[2] { 7, 17 };
										array3 = new object[2] { 16, 5 };
										array2 = new object[2] { 16, 17 };
										if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
										{
											LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
											result = 5;
										}
										else
										{
											array7 = new object[2] { 7, 1 };
											array6 = new object[2] { 7, 7 };
											array5 = new object[2] { 7, 14 };
											array4 = new object[2] { 11, 8 };
											array3 = new object[2] { 16, 7 };
											array2 = new object[2] { 12, 10 };
											if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
											{
												LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
												result = 6;
											}
											else
											{
												array7 = new object[2] { 7, 1 };
												array6 = new object[2] { 16, 1 };
												array5 = new object[2] { 16, 9 };
												array4 = new object[2] { 16, 17 };
												array3 = new object[2] { 7, 8 };
												array2 = new object[2] { 11, 9 };
												array = new object[2] { 7, 17 };
												if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
												{
													LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
													result = 7;
												}
												else
												{
													array7 = new object[2] { 7, 1 };
													array6 = new object[2] { 7, 17 };
													array5 = new object[2] { 16, 1 };
													array4 = new object[2] { 12, 8 };
													array3 = new object[2] { 7, 13 };
													array2 = new object[2] { 16, 17 };
													array = new object[2] { 6, 13 };
													if (smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))))
													{
														LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
														result = 8;
													}
													else
													{
														array7 = new object[2] { 7, 1 };
														array6 = new object[2] { 7, 17 };
														array5 = new object[2] { 16, 1 };
														array4 = new object[2] { 7, 11 };
														array3 = new object[2] { 11, 10 };
														array2 = new object[2] { 16, 13 };
														if (!(smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array7, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array6, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array5, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & !smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array4, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array3, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color)))) & smethod_0((Color)(LateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), (Type)null, "GetPixel", array2, (string[])null, (bool[])null) ?? Activator.CreateInstance(typeof(Color))))))
														{
															goto IL_3e1f;
														}
														LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
														result = 9;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto end_IL_0001;
			IL_3e1f:
			LateBinding.LateCall(RuntimeHelpers.GetObjectValue(obj), (Type)null, "Dispose", new object[0], (string[])null, (bool[])null);
			result = 0;
			end_IL_0001:;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		int num3 = default(int);
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object smethod_8()
	{
		checked
		{
			object result = default(object);
			try
			{
				ProjectData.ClearProjectError();
				int dC = GetDC(0);
				int num = CreateCompatibleDC(dC);
				int num2 = CreateCompatibleBitmap(dC, 58, 55);
				SelectObject(num, num2);
				BitBlt(num, 0, 0, 58, 55, dC, 372, 44, 13369376);
				int value = SelectObject(num, num2);
				IntPtr intPtr = new IntPtr(value);
				Bitmap val = Image.FromHbitmap(intPtr);
				DeleteDC(num);
				DeleteObject(num2);
				ReleaseDC(0, dC);
				int num3 = 0;
				while (true)
				{
					int num4 = (int)Math.Round(Math.Round(25.0 * Math.Cos((double)num3 * Math.PI / 180.0) + 400.0));
					int num5 = (int)Math.Round(Math.Round(25.0 * Math.Sin((double)num3 * Math.PI / 180.0) + 71.0));
					Color pixel = val.GetPixel(num4 - 372, num5 - 44);
					if (!((pixel.R < 256) & (pixel.G < 52) & (pixel.B < 52)))
					{
						num3++;
						if (num3 > 360)
						{
							((Image)val).Dispose();
							result = 0;
							break;
						}
						continue;
					}
					((Image)val).Dispose();
					result = num3;
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			int num6 = default(int);
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public object method_0(long long_0, long long_1, long long_2, long long_3)
	{
		SetPixel(long_2, long_0, long_1, long_3);
		object result = default(object);
		return result;
	}

	public Point method_1(long long_0)
	{
		long num = 10L;
		checked
		{
			Point result = default(Point);
			do
			{
				long num2 = 50L;
				do
				{
					if (GetPixel(int_1, num, num2) != long_0)
					{
						num2 += 2L;
						continue;
					}
					result.X = (int)num;
					result.Y = (int)num2;
					break;
				}
				while (num2 <= 550L);
				num += 2L;
			}
			while (num <= 790L);
			return result;
		}
	}

	public Point method_2()
	{
		Point result = method_1(Information.RGB(231, 16, 0));
		if (!((result.X == 0) & (result.Y == 0)))
		{
			return result;
		}
		Point result2 = default(Point);
		return result2;
	}

	private void method_3()
	{
		checked
		{
			try
			{
				double num = Math.Cos(DoubleType.FromObject(smethod_5()) / 180.0 * 3.14159265358979);
				double num2 = Math.Cos(DoubleType.FromObject(ObjectType.DivObj(ObjectType.MulObj(smethod_8(), (object)3.14159265358979), (object)180)));
				double num3 = DoubleType.FromObject(ObjectType.SubObj(ObjectType.MulObj(smethod_7(), (object)2), (object)1));
				if (num3 < 0.0)
				{
					num3 = 0.0;
				}
				double num4 = num3 * num2;
				double num5 = DoubleType.FromObject(RuntimeHelpers.GetObjectValue(ObjectType.DivObj(RuntimeHelpers.GetObjectValue(ObjectType.MulObj(RuntimeHelpers.GetObjectValue(ObjectType.MulObj((object)num, RuntimeHelpers.GetObjectValue(ObjectType.DivObj(RuntimeHelpers.GetObjectValue(ObjectType.MulObj((object)400, RuntimeHelpers.GetObjectValue(smethod_1(string_0)))), (object)100)))), (object)DoubleType.FromObject(smethod_6()))), (object)400)));
				double num6 = Math.Sin(DoubleType.FromObject(smethod_5()) / 180.0 * 3.14159265358979);
				double num7 = Math.Sin(DoubleType.FromObject(ObjectType.DivObj(ObjectType.MulObj(smethod_8(), (object)3.14159265358979), (object)180)));
				double num8 = DoubleType.FromObject(ObjectType.SubObj(ObjectType.MulObj(smethod_7(), (object)2), (object)1));
				if (num8 < 0.0)
				{
					num8 = 0.0;
				}
				double num9 = num8 * num7;
				double num10 = DoubleType.FromObject(RuntimeHelpers.GetObjectValue(ObjectType.DivObj(RuntimeHelpers.GetObjectValue(ObjectType.MulObj(RuntimeHelpers.GetObjectValue(ObjectType.MulObj((object)num6, RuntimeHelpers.GetObjectValue(ObjectType.DivObj(RuntimeHelpers.GetObjectValue(ObjectType.MulObj((object)400, RuntimeHelpers.GetObjectValue(smethod_1(string_0)))), (object)100)))), (object)DoubleType.FromObject(smethod_6()))), (object)400)));
				int num11 = IntegerType.FromObject(RuntimeHelpers.GetObjectValue(smethod_3(string_0)));
				string lpClassName = "softnyx";
				string lpWindowName = null;
				int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
				int_1 = GetWindowDC(hwnd);
				int hDC = int_1;
				string lpString = "Created by Le Hong Quang";
				TextOutA(hDC, 10, 37, ref lpString, Strings.Len("Created by Le Hong Quang"));
				int_2 = CreatePen(0, 1, Information.RGB(255, 255, 255));
				int hObj = SelectObject(int_1, int_2);
				int num12 = 0;
				do
				{
					int num13 = (int)Math.Round(Math.Round(40.0 * Math.Cos((double)num12 * Math.PI / 180.0))) + point_0.X;
					int num14 = (int)Math.Round(Math.Round(40.0 * Math.Sin((double)num12 * Math.PI / 180.0))) + point_0.Y;
					if (num12 != 0)
					{
						LineTo(int_1, (int)Math.Round(Math.Round((double)(num13 - 2))), (int)Math.Round(Math.Round((double)(num14 - 2))));
					}
					else
					{
						int lpPoint = 0;
						MoveToEx(int_1, (int)Math.Round(Math.Round((double)(num13 - 2))), (int)Math.Round(Math.Round((double)(num14 - 2))), ref lpPoint);
					}
					num12 += 2;
				}
				while (num12 <= 360);
				if (bool_0)
				{
					if ((StringType.StrCmp(string_0.ToLower(), "nakmachine", false) == 0) | (StringType.StrCmp(string_0.ToLower(), "aduka", false) == 0))
					{
						double num15 = 0.0;
						do
						{
							decimal value = new decimal((double)point_0.X - (num5 * num15 - num4 * num15 * num15));
							decimal value2 = new decimal((double)point_0.Y - (num10 * num15 - num9 * num15 * num15 - 0.5 * (double)(num11 * 4 - 5) * num15 * num15));
							if (!((Convert.ToDouble(value2) > 610.0) | (Convert.ToDouble(value) > 810.0) | (Convert.ToDouble(value) < 0.0)))
							{
								if (num15 == 0.0)
								{
									int lpPoint = 0;
									MoveToEx(int_1, (int)Math.Round(Math.Round(Convert.ToDouble(value) - 2.0)), (int)Math.Round(Math.Round(Convert.ToDouble(value2) - 2.0)), ref lpPoint);
								}
								else
								{
									LineTo(int_1, (int)Math.Round(Math.Round(Convert.ToDouble(value) - 2.0)), (int)Math.Round(Math.Round(Convert.ToDouble(value2) - 2.0)));
								}
								num15 += 0.05;
								continue;
							}
							break;
						}
						while (FlowControl.ForNextCheckR8(num15, 12.0, 0.05));
					}
					else
					{
						double num15 = 0.0;
						do
						{
							decimal value3 = new decimal((double)point_0.X + (num5 * num15 + num4 * num15 * num15));
							decimal value4 = new decimal((double)point_0.Y - (num10 * num15 - num9 * num15 * num15 - 0.5 * (double)(num11 * 4 - 5) * num15 * num15));
							if (!((Convert.ToDouble(value4) > 610.0) | (Convert.ToDouble(value3) > 810.0) | (Convert.ToDouble(value3) < 0.0)))
							{
								if (num15 == 0.0)
								{
									int lpPoint = 0;
									MoveToEx(int_1, (int)Math.Round(Math.Round(Convert.ToDouble(value3) - 2.0)), (int)Math.Round(Math.Round(Convert.ToDouble(value4) - 2.0)), ref lpPoint);
								}
								else
								{
									LineTo(int_1, (int)Math.Round(Math.Round(Convert.ToDouble(value3) - 2.0)), (int)Math.Round(Math.Round(Convert.ToDouble(value4) - 2.0)));
								}
								num15 += 0.05;
								continue;
							}
							break;
						}
						while (FlowControl.ForNextCheckR8(num15, 12.0, 0.05));
					}
				}
				else if ((StringType.StrCmp(string_0.ToLower(), "nakmachine", false) == 0) | (StringType.StrCmp(string_0.ToLower(), "aduka", false) == 0))
				{
					double num15 = 0.0;
					do
					{
						decimal value5 = new decimal((double)point_0.X + (num5 * num15 + num4 * num15 * num15));
						decimal value6 = new decimal((double)point_0.Y - (num10 * num15 - num9 * num15 * num15 - 0.5 * (double)(num11 * 4 - 5) * num15 * num15));
						if (!((Convert.ToDouble(value6) > 610.0) | (Convert.ToDouble(value5) > 810.0) | (Convert.ToDouble(value5) < 0.0)))
						{
							if (num15 == 0.0)
							{
								int lpPoint = 0;
								MoveToEx(int_1, (int)Math.Round(Math.Round(Convert.ToDouble(value5) - 2.0)), (int)Math.Round(Math.Round(Convert.ToDouble(value6) - 2.0)), ref lpPoint);
							}
							else
							{
								LineTo(int_1, (int)Math.Round(Math.Round(Convert.ToDouble(value5) - 2.0)), (int)Math.Round(Math.Round(Convert.ToDouble(value6) - 2.0)));
							}
							num15 += 0.05;
							continue;
						}
						break;
					}
					while (FlowControl.ForNextCheckR8(num15, 12.0, 0.05));
				}
				else
				{
					double num15 = 0.0;
					do
					{
						decimal value7 = new decimal((double)point_0.X - (num5 * num15 - num4 * num15 * num15));
						decimal value8 = new decimal((double)point_0.Y - (num10 * num15 - num9 * num15 * num15 - 0.5 * (double)(num11 * 4 - 5) * num15 * num15));
						if ((Convert.ToDouble(value8) > 610.0) | (Convert.ToDouble(value7) > 810.0) | (Convert.ToDouble(value7) < 0.0))
						{
							break;
						}
						if (num15 == 0.0)
						{
							int lpPoint = 0;
							MoveToEx(int_1, (int)Math.Round(Math.Round(Convert.ToDouble(value7) - 2.0)), (int)Math.Round(Math.Round(Convert.ToDouble(value8) - 2.0)), ref lpPoint);
						}
						else
						{
							LineTo(int_1, (int)Math.Round(Math.Round(Convert.ToDouble(value7) - 2.0)), (int)Math.Round(Math.Round(Convert.ToDouble(value8) - 2.0)));
						}
						num15 += 0.05;
					}
					while (FlowControl.ForNextCheckR8(num15, 12.0, 0.05));
				}
				DeleteObject(int_2);
				DeleteObject(hObj);
				ReleaseDC(hwnd, int_1);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				ProjectData.ClearProjectError();
			}
		}
	}

	private bool method_4(Bitmap bitmap_1, bool bool_1)
	{
		if (!bool_1)
		{
			if (method_8(bitmap_1, bitmap_0, Color.FromArgb(255, 0, 0)))
			{
				((Image)bitmap_1).Dispose();
				return true;
			}
		}
		else if (method_8(bitmap_1, bitmap_0, Color.FromArgb(255, 0, 0)))
		{
			((Image)bitmap_1).Dispose();
			return true;
		}
		return false;
	}

	private int method_5(int int_3)
	{
		int result = default(int);
		try
		{
			string text;
			if (Math.Sign(int_3) == 1)
			{
				text = StringType.FromInteger(int_3);
				text = text.Substring(0, 1);
				if (IntegerType.FromString(text) == 1)
				{
					return 1;
				}
				return 2;
			}
			if (Math.Sign(int_3) != -1)
			{
				return result;
			}
			text = StringType.FromInteger(int_3);
			text = text.Substring(1, 1);
			if (IntegerType.FromString(text) == 1)
			{
				return -1;
			}
			result = -2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = 0;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private bool method_6(ref Color color_0)
	{
		if (color_0.R == 148 && color_0.G == 150 && color_0.B == 148)
		{
			return true;
		}
		return false;
	}

	private bool method_7(Color color_0, Color color_1)
	{
		return color_0.Equals((object?)color_1);
	}

	private bool method_8(Bitmap bitmap_1, Bitmap bitmap_2, Color color_0)
	{
		checked
		{
			int num = ((Image)bitmap_2).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)bitmap_2).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = bitmap_2.GetPixel(i, j);
					if (!method_7(pixel, color_0) && !pixel.Equals((object?)bitmap_1.GetPixel(i, j)))
					{
						((Image)bitmap_1).Dispose();
						((Image)bitmap_2).Dispose();
						return false;
					}
				}
			}
			((Image)bitmap_1).Dispose();
			((Image)bitmap_2).Dispose();
			return true;
		}
	}

	public Point method_9(int int_3 = 0)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		int dC = GetDC(0);
		int num = CreateCompatibleDC(dC);
		int num2 = CreateCompatibleBitmap(dC, 800, 600);
		SelectObject(num, num2);
		BitBlt(num, 0, 0, 800, 600, dC, 0, 116, 13369376);
		int value = SelectObject(num, num2);
		IntPtr intPtr = new IntPtr(value);
		Bitmap val = Image.FromHbitmap(intPtr);
		DeleteObject(num);
		DeleteObject(num2);
		ReleaseDC(0, dC);
		Bitmap val2 = new Bitmap(8, 10);
		Color[] array = new Color[2]
		{
			Color.FromArgb(0, 0, 0),
			Color.FromArgb(255, 255, 255)
		};
		Color[] array2 = array;
		checked
		{
			try
			{
				int num3 = 140;
				do
				{
					int num4 = 0;
					do
					{
						if (val.GetPixel(num4, num3).Equals((object?)array2[0]) && val.GetPixel(num4 + 1, num3 + 1).Equals((object?)array2[1]) && val.GetPixel(num4 + 1, num3).Equals((object?)array2[0]) && val.GetPixel(num4, num3 + 1).Equals((object?)array2[0]))
						{
							int num5 = 0;
							do
							{
								int num6 = 0;
								do
								{
									val2.SetPixel(num5, num6, val.GetPixel(num4 + num5, num3 + num6));
									num6++;
								}
								while (num6 <= 9);
								num5++;
							}
							while (num5 <= 7);
							int num7 = method_5(int_3);
							bool bool_ = ((num7 == 1 || num7 == -1) ? true : false);
							if (method_4(val2, bool_))
							{
								Point point3;
								switch (num7)
								{
								default:
								{
									Point point = new Point(num4 - 12, num3 + 94);
									Point point2 = point;
									point3 = point2;
									break;
								}
								case 1:
								case 2:
								{
									Point point = new Point(num4 - 12, num3 + 94);
									Point point2 = point;
									point3 = point2;
									break;
								}
								case -2:
								case -1:
								{
									Point point = new Point(num4 - 3, num3 + 90);
									Point point2 = point;
									point3 = point2;
									break;
								}
								}
								Point result = point3;
								((Image)val).Dispose();
								((Image)val2).Dispose();
								return result;
							}
						}
						num4++;
					}
					while (num4 <= 790);
					num3++;
				}
				while (num3 <= 516);
				((Image)val).Dispose();
				((Image)val2).Dispose();
				Point result2 = default(Point);
				return result2;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception projectError = ex;
				ProjectData.SetProjectError(projectError);
				Point point = new Point(408, 272);
				Point point2 = point;
				Point result = point2;
				Point point4 = result;
				ProjectData.ClearProjectError();
				Point result2 = point4;
				ProjectData.ClearProjectError();
				return result2;
			}
		}
	}

	public bool method_10()
	{
		int dC = GetDC(0);
		int num = CreateCompatibleDC(dC);
		int num2 = CreateCompatibleBitmap(dC, 800, 600);
		SelectObject(num, num2);
		BitBlt(num, 0, 0, 800, 600, dC, 0, 116, 13369376);
		int value = SelectObject(num, num2);
		IntPtr intPtr = new IntPtr(value);
		Bitmap val = Image.FromHbitmap(intPtr);
		DeleteObject(num);
		DeleteObject(num2);
		ReleaseDC(0, dC);
		bool result;
		try
		{
			Color pixel = val.GetPixel(0, 0);
			Color pixel2 = val.GetPixel(6, 0);
			if (pixel.R == 173 && pixel.G == 215 && pixel.B == 239 && pixel2.R == 0 && pixel2.G == 48 && pixel2.B == 66)
			{
				((Image)val).Dispose();
				return true;
			}
			((Image)val).Dispose();
			result = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		ProjectData.ClearProjectError();
		int num = 1;
		checked
		{
			do
			{
				int asyncKeyState = GetAsyncKeyState(num);
				if (asyncKeyState == -32767)
				{
					if (num == 39)
					{
						bool_0 = true;
					}
					if (num == 37)
					{
						bool_0 = false;
					}
					if (num == 17)
					{
						point_0.X = Cursor.get_Position().X + 1;
						point_0.Y = Cursor.get_Position().Y + 1;
					}
				}
				num++;
			}
			while (num <= 255);
			new Pen(Color.Red);
			if (ObjectType.ObjTst(RuntimeHelpers.GetObjectValue(smethod_4()), (object)true, false) == 0)
			{
				vmethod_3().get_Items().Clear();
				vmethod_3().get_Items().Add((object)("Sức gió : " + StringType.FromInteger(IntegerType.FromObject(smethod_7()))));
				vmethod_3().get_Items().Add((object)("Góc của gió : " + StringType.FromInteger(IntegerType.FromObject(smethod_8()))));
				vmethod_3().get_Items().Add((object)("Góc bán : " + StringType.FromInteger(IntegerType.FromObject(smethod_5()))));
				vmethod_3().get_Items().Add((object)("Sức bắn : " + StringType.FromDouble(DoubleType.FromObject(ObjectType.MulObj(smethod_6(), (object)0.25)))));
				method_3();
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		checked
		{
			int num = string_1.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				vmethod_4().get_Items().Add((object)method_12(string_1[i]));
			}
			vmethod_4().set_SelectedIndex(0);
			bool_0 = false;
			point_0.X = 400;
			point_0.Y = 300;
		}
	}

	public string method_11(string string_2)
	{
		string result = default(string);
		try
		{
			result = Convert.ToBase64String(Encoding.ASCII.GetBytes(string_2.ToCharArray()));
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string method_12(string string_2)
	{
		string @string = default(string);
		if (StringType.StrCmp(string_2, "", false) != 0)
		{
			try
			{
				@string = Encoding.ASCII.GetString(Convert.FromBase64String(string_2));
				return @string;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return @string;
			}
		}
		return "";
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		string_0 = method_12(string_1[vmethod_4().get_SelectedIndex()]);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"Chạy chương trình này trước khi login vào Gunbound\rChọn xe cho phù hợp\rLúc bắn nhau thì ấn Ctrl rồi di chuyển vòng tròn khớp vòng tròn con của mình\rKéo cái canh sức mạnh phía dưới để xem đường đạn sẽ bay và bắn đúng chỗ đã canh", (MsgBoxStyle)64, (object)"Hướng dẫn nè bà kon - Lê Hồng Quang");
	}
}

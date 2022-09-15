using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace DllInjector;

public class mainForm : Form
{
	public unsafe ushort* pathName;

	public unsafe ushort* pathName2;

	public unsafe ushort* pathName3;

	public unsafe sbyte* processName;

	public unsafe ushort* keyName;

	public unsafe ushort* keyName2;

	public unsafe ushort* keyName3;

	private Button button3;

	private TextBox textBox3;

	private MainMenu mainMenu1;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label label1;

	private TextBox textBox4;

	private PictureBox pictureBox3;

	private TextBox textBox5;

	private PictureBox pictureBox4;

	private TextBox textBox6;

	private PictureBox pictureBox5;

	private TextBox textBox7;

	private PictureBox pictureBox6;

	private Button button4;

	private Button button5;

	private Button button6;

	private Button button7;

	private PictureBox pictureBox7;

	private Label label2;

	private Label label3;

	private Label label4;

	private Button button8;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private Button button13;

	private Button button14;

	private Label label5;

	private NotifyIcon notifyIcon1;

	private Label label6;

	private bool injecting;

	private TextBox textBox1;

	private Button button1;

	private TextBox textBox2;

	private Button button2;

	private OpenFileDialog openFileDialog1;

	private IContainer components;

	public mainForm()
	{
		InitializeComponent();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private unsafe ushort* string2Chars(string item)
	{
		IntPtr intPtr = Marshal.StringToHGlobalUni(item);
		return (ushort*)(void*)intPtr;
	}

	private unsafe sbyte* string2CharsAnsi(string item)
	{
		IntPtr intPtr = Marshal.StringToHGlobalAnsi(item);
		return (sbyte*)(void*)intPtr;
	}

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected O, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected O, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Expected O, but got Unknown
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected O, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd6: Expected O, but got Unknown
		//IL_0d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Expected O, but got Unknown
		//IL_0e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected O, but got Unknown
		//IL_0f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f63: Expected O, but got Unknown
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected O, but got Unknown
		//IL_1117: Unknown result type (might be due to invalid IL or missing references)
		//IL_1121: Expected O, but got Unknown
		//IL_11c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d0: Expected O, but got Unknown
		//IL_11ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f9: Expected O, but got Unknown
		//IL_129e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a8: Expected O, but got Unknown
		//IL_12c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d1: Expected O, but got Unknown
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_1380: Expected O, but got Unknown
		//IL_139f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a9: Expected O, but got Unknown
		//IL_14fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1506: Expected O, but got Unknown
		//IL_15d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15db: Expected O, but got Unknown
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Expected O, but got Unknown
		//IL_175f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1769: Expected O, but got Unknown
		//IL_1788: Unknown result type (might be due to invalid IL or missing references)
		//IL_1792: Expected O, but got Unknown
		//IL_1837: Unknown result type (might be due to invalid IL or missing references)
		//IL_1841: Expected O, but got Unknown
		//IL_1860: Unknown result type (might be due to invalid IL or missing references)
		//IL_186a: Expected O, but got Unknown
		//IL_190f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1919: Expected O, but got Unknown
		//IL_1938: Unknown result type (might be due to invalid IL or missing references)
		//IL_1942: Expected O, but got Unknown
		//IL_19e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f1: Expected O, but got Unknown
		//IL_1a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1a: Expected O, but got Unknown
		//IL_1abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac9: Expected O, but got Unknown
		//IL_1ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af2: Expected O, but got Unknown
		//IL_1b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba1: Expected O, but got Unknown
		//IL_1bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bca: Expected O, but got Unknown
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c79: Expected O, but got Unknown
		//IL_1c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca2: Expected O, but got Unknown
		//IL_1d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6b: Expected O, but got Unknown
		//IL_1e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e23: Expected O, but got Unknown
		//IL_1e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4a: Expected O, but got Unknown
		//IL_1e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e94: Expected O, but got Unknown
		//IL_1f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f61: Expected O, but got Unknown
		//IL_21dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e6: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(mainForm));
		pictureBox1 = new PictureBox();
		textBox1 = new TextBox();
		button1 = new Button();
		textBox2 = new TextBox();
		button2 = new Button();
		openFileDialog1 = new OpenFileDialog();
		button3 = new Button();
		textBox3 = new TextBox();
		mainMenu1 = new MainMenu();
		pictureBox2 = new PictureBox();
		label1 = new Label();
		textBox4 = new TextBox();
		pictureBox3 = new PictureBox();
		textBox5 = new TextBox();
		pictureBox4 = new PictureBox();
		textBox6 = new TextBox();
		pictureBox5 = new PictureBox();
		textBox7 = new TextBox();
		pictureBox6 = new PictureBox();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		pictureBox7 = new PictureBox();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		button8 = new Button();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		button12 = new Button();
		button13 = new Button();
		button14 = new Button();
		label5 = new Label();
		notifyIcon1 = new NotifyIcon(components);
		label6 = new Label();
		((Control)this).SuspendLayout();
		Color lightGray = Color.LightGray;
		Color backColor = lightGray;
		((Control)pictureBox1).set_BackColor(backColor);
		Point point = default(Point);
		point = new Point(110, 182);
		((Control)pictureBox1).set_Location(point);
		((Control)pictureBox1).set_Name("pictureBox1");
		Size size = default(Size);
		size = new Size(172, 23);
		((Control)pictureBox1).set_Size(size);
		pictureBox1.set_TabIndex(22);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_MouseEnter((EventHandler)pictureBox1_MouseEnter);
		((Control)pictureBox1).add_MouseHover((EventHandler)pictureBox1_MouseHover);
		((Control)pictureBox1).add_MouseLeave((EventHandler)pictureBox1_MouseLeave);
		Color white = Color.White;
		Color backColor2 = white;
		((TextBoxBase)textBox1).set_BackColor(backColor2);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point2 = default(Point);
		point2 = new Point(112, 184);
		((Control)textBox1).set_Location(point2);
		((TextBoxBase)textBox1).set_MaxLength(512);
		((Control)textBox1).set_Name("textBox1");
		Size size2 = default(Size);
		size2 = new Size(168, 19);
		((Control)textBox1).set_Size(size2);
		((Control)textBox1).set_TabIndex(23);
		textBox1.set_Text("");
		((Control)textBox1).add_MouseEnter((EventHandler)textBox1_MouseEnter);
		((Control)textBox1).add_Leave((EventHandler)textBox1_Leave);
		((Control)textBox1).add_MouseLeave((EventHandler)textBox1_MouseLeave);
		((Control)textBox1).add_Enter((EventHandler)textBox1_Enter);
		((Control)button1).set_BackgroundImage((Image)resourceManager.GetObject("button1.BackgroundImage"));
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point3 = default(Point);
		point3 = new Point(392, 184);
		((Control)button1).set_Location(point3);
		((Control)button1).set_Name("button1");
		Size size3 = default(Size);
		size3 = new Size(96, 22);
		((Control)button1).set_Size(size3);
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Browse...");
		((Control)button1).add_Click((EventHandler)button1_Click);
		Color white2 = Color.White;
		Color backColor3 = white2;
		((TextBoxBase)textBox2).set_BackColor(backColor3);
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)0);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point4 = default(Point);
		point4 = new Point(148, 358);
		((Control)textBox2).set_Location(point4);
		((TextBoxBase)textBox2).set_MaxLength(512);
		((Control)textBox2).set_Name("textBox2");
		Size size4 = default(Size);
		size4 = new Size(132, 19);
		((Control)textBox2).set_Size(size4);
		((Control)textBox2).set_TabIndex(3);
		textBox2.set_Text("Rakion.bin");
		((Control)textBox2).add_MouseEnter((EventHandler)textBox2_MouseEnter);
		((Control)textBox2).add_Leave((EventHandler)textBox2_Leave);
		((Control)textBox2).add_MouseLeave((EventHandler)textBox2_MouseLeave);
		((Control)textBox2).add_Enter((EventHandler)textBox2_Enter);
		((Control)button2).set_BackgroundImage((Image)resourceManager.GetObject("button2.BackgroundImage"));
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point5 = default(Point);
		point5 = new Point(392, 358);
		((Control)button2).set_Location(point5);
		((Control)button2).set_Name("button2");
		Size size5 = default(Size);
		size5 = new Size(96, 22);
		((Control)button2).set_Size(size5);
		((Control)button2).set_TabIndex(5);
		((Control)button2).set_Text("Inject..");
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_BackgroundImage((Image)resourceManager.GetObject("button3.BackgroundImage"));
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point6 = default(Point);
		point6 = new Point(392, 213);
		((Control)button3).set_Location(point6);
		((Control)button3).set_Name("button3");
		Size size6 = default(Size);
		size6 = new Size(96, 22);
		((Control)button3).set_Size(size6);
		((Control)button3).set_TabIndex(7);
		((Control)button3).set_Text("Browse...");
		((Control)button3).add_Click((EventHandler)button3_Click);
		Color white3 = Color.White;
		Color backColor4 = white3;
		((TextBoxBase)textBox3).set_BackColor(backColor4);
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)0);
		((Control)textBox3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point7 = default(Point);
		point7 = new Point(112, 213);
		((Control)textBox3).set_Location(point7);
		((TextBoxBase)textBox3).set_MaxLength(512);
		((Control)textBox3).set_Name("textBox3");
		Size size7 = default(Size);
		size7 = new Size(168, 19);
		((Control)textBox3).set_Size(size7);
		((Control)textBox3).set_TabIndex(6);
		textBox3.set_Text("");
		((Control)textBox3).add_MouseEnter((EventHandler)textBox3_MouseEnter);
		((Control)textBox3).add_Leave((EventHandler)textBox3_Leave);
		((Control)textBox3).add_MouseLeave((EventHandler)textBox3_MouseLeave);
		((Control)textBox3).add_Enter((EventHandler)textBox3_Enter);
		Color lightGray2 = Color.LightGray;
		Color backColor5 = lightGray2;
		((Control)pictureBox2).set_BackColor(backColor5);
		Point point8 = default(Point);
		point8 = new Point(110, 211);
		((Control)pictureBox2).set_Location(point8);
		((Control)pictureBox2).set_Name("pictureBox2");
		Size size8 = default(Size);
		size8 = new Size(172, 23);
		((Control)pictureBox2).set_Size(size8);
		pictureBox2.set_TabIndex(24);
		pictureBox2.set_TabStop(false);
		Color transparent = Color.Transparent;
		Color backColor6 = transparent;
		((Control)label1).set_BackColor(backColor6);
		Point point9 = default(Point);
		point9 = new Point(0, 0);
		((Control)label1).set_Location(point9);
		((Control)label1).set_Name("label1");
		Size size9 = default(Size);
		size9 = new Size(512, 176);
		((Control)label1).set_Size(size9);
		((Control)label1).set_TabIndex(25);
		((Control)label1).add_MouseUp(new MouseEventHandler(label1_MouseUp));
		((Control)label1).add_MouseDown(new MouseEventHandler(label1_MouseDown));
		Color white4 = Color.White;
		Color backColor7 = white4;
		((TextBoxBase)textBox4).set_BackColor(backColor7);
		((TextBoxBase)textBox4).set_BorderStyle((BorderStyle)0);
		((Control)textBox4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point10 = default(Point);
		point10 = new Point(112, 271);
		((Control)textBox4).set_Location(point10);
		((TextBoxBase)textBox4).set_MaxLength(512);
		((Control)textBox4).set_Name("textBox4");
		Size size10 = default(Size);
		size10 = new Size(168, 19);
		((Control)textBox4).set_Size(size10);
		((Control)textBox4).set_TabIndex(26);
		textBox4.set_Text("");
		((Control)textBox4).add_MouseEnter((EventHandler)textBox4_MouseEnter);
		((Control)textBox4).add_Leave((EventHandler)textBox4_Leave);
		((Control)textBox4).add_MouseLeave((EventHandler)textBox4_MouseLeave);
		((Control)textBox4).add_Enter((EventHandler)textBox4_Enter);
		Color lightGray3 = Color.LightGray;
		Color backColor8 = lightGray3;
		((Control)pictureBox3).set_BackColor(backColor8);
		Point point11 = default(Point);
		point11 = new Point(110, 269);
		((Control)pictureBox3).set_Location(point11);
		((Control)pictureBox3).set_Name("pictureBox3");
		Size size11 = default(Size);
		size11 = new Size(172, 23);
		((Control)pictureBox3).set_Size(size11);
		pictureBox3.set_TabIndex(29);
		pictureBox3.set_TabStop(false);
		Color white5 = Color.White;
		Color backColor9 = white5;
		((TextBoxBase)textBox5).set_BackColor(backColor9);
		((TextBoxBase)textBox5).set_BorderStyle((BorderStyle)0);
		((Control)textBox5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point12 = default(Point);
		point12 = new Point(112, 242);
		((Control)textBox5).set_Location(point12);
		((TextBoxBase)textBox5).set_MaxLength(512);
		((Control)textBox5).set_Name("textBox5");
		Size size12 = default(Size);
		size12 = new Size(168, 19);
		((Control)textBox5).set_Size(size12);
		((Control)textBox5).set_TabIndex(28);
		textBox5.set_Text("");
		((Control)textBox5).add_MouseEnter((EventHandler)textBox5_MouseEnter);
		((Control)textBox5).add_Leave((EventHandler)textBox5_Leave);
		((Control)textBox5).add_MouseLeave((EventHandler)textBox5_MouseLeave);
		((Control)textBox5).add_Enter((EventHandler)textBox5_Enter);
		Color lightGray4 = Color.LightGray;
		Color backColor10 = lightGray4;
		((Control)pictureBox4).set_BackColor(backColor10);
		Point point13 = default(Point);
		point13 = new Point(110, 240);
		((Control)pictureBox4).set_Location(point13);
		((Control)pictureBox4).set_Name("pictureBox4");
		Size size13 = default(Size);
		size13 = new Size(172, 23);
		((Control)pictureBox4).set_Size(size13);
		pictureBox4.set_TabIndex(27);
		pictureBox4.set_TabStop(false);
		Color white6 = Color.White;
		Color backColor11 = white6;
		((TextBoxBase)textBox6).set_BackColor(backColor11);
		((TextBoxBase)textBox6).set_BorderStyle((BorderStyle)0);
		((Control)textBox6).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point14 = default(Point);
		point14 = new Point(112, 329);
		((Control)textBox6).set_Location(point14);
		((TextBoxBase)textBox6).set_MaxLength(512);
		((Control)textBox6).set_Name("textBox6");
		Size size14 = default(Size);
		size14 = new Size(168, 19);
		((Control)textBox6).set_Size(size14);
		((Control)textBox6).set_TabIndex(30);
		textBox6.set_Text("");
		((Control)textBox6).add_MouseEnter((EventHandler)textBox6_MouseEnter);
		((Control)textBox6).add_Layout(new LayoutEventHandler(textBox6_Layout));
		((Control)textBox6).add_Leave((EventHandler)textBox6_Leave);
		((Control)textBox6).add_MouseLeave((EventHandler)textBox6_MouseLeave);
		((Control)textBox6).add_Enter((EventHandler)textBox6_Enter);
		Color lightGray5 = Color.LightGray;
		Color backColor12 = lightGray5;
		((Control)pictureBox5).set_BackColor(backColor12);
		Point point15 = default(Point);
		point15 = new Point(110, 327);
		((Control)pictureBox5).set_Location(point15);
		((Control)pictureBox5).set_Name("pictureBox5");
		Size size15 = default(Size);
		size15 = new Size(172, 23);
		((Control)pictureBox5).set_Size(size15);
		pictureBox5.set_TabIndex(33);
		pictureBox5.set_TabStop(false);
		Color white7 = Color.White;
		Color backColor13 = white7;
		((TextBoxBase)textBox7).set_BackColor(backColor13);
		((TextBoxBase)textBox7).set_BorderStyle((BorderStyle)0);
		((Control)textBox7).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point16 = default(Point);
		point16 = new Point(112, 300);
		((Control)textBox7).set_Location(point16);
		((TextBoxBase)textBox7).set_MaxLength(512);
		((Control)textBox7).set_Name("textBox7");
		Size size16 = default(Size);
		size16 = new Size(168, 19);
		((Control)textBox7).set_Size(size16);
		((Control)textBox7).set_TabIndex(32);
		textBox7.set_Text("");
		((Control)textBox7).add_MouseEnter((EventHandler)textBox7_MouseEnter);
		((Control)textBox7).add_Leave((EventHandler)textBox7_Leave);
		((Control)textBox7).add_MouseLeave((EventHandler)textBox7_MouseLeave);
		((Control)textBox7).add_Enter((EventHandler)textBox7_Enter);
		Color lightGray6 = Color.LightGray;
		Color backColor14 = lightGray6;
		((Control)pictureBox6).set_BackColor(backColor14);
		Point point17 = default(Point);
		point17 = new Point(110, 298);
		((Control)pictureBox6).set_Location(point17);
		((Control)pictureBox6).set_Name("pictureBox6");
		Size size17 = default(Size);
		size17 = new Size(172, 23);
		((Control)pictureBox6).set_Size(size17);
		pictureBox6.set_TabIndex(31);
		pictureBox6.set_TabStop(false);
		((Control)button4).set_BackgroundImage((Image)resourceManager.GetObject("button4.BackgroundImage"));
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point18 = default(Point);
		point18 = new Point(392, 242);
		((Control)button4).set_Location(point18);
		((Control)button4).set_Name("button4");
		Size size18 = default(Size);
		size18 = new Size(96, 22);
		((Control)button4).set_Size(size18);
		((Control)button4).set_TabIndex(34);
		((Control)button4).set_Text("Browse...");
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button5).set_BackgroundImage((Image)resourceManager.GetObject("button5.BackgroundImage"));
		((ButtonBase)button5).set_FlatStyle((FlatStyle)0);
		((Control)button5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point19 = default(Point);
		point19 = new Point(392, 271);
		((Control)button5).set_Location(point19);
		((Control)button5).set_Name("button5");
		Size size19 = default(Size);
		size19 = new Size(96, 22);
		((Control)button5).set_Size(size19);
		((Control)button5).set_TabIndex(35);
		((Control)button5).set_Text("Browse...");
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_BackgroundImage((Image)resourceManager.GetObject("button6.BackgroundImage"));
		((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
		((Control)button6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point20 = default(Point);
		point20 = new Point(392, 300);
		((Control)button6).set_Location(point20);
		((Control)button6).set_Name("button6");
		Size size20 = default(Size);
		size20 = new Size(96, 22);
		((Control)button6).set_Size(size20);
		((Control)button6).set_TabIndex(36);
		((Control)button6).set_Text("Browse...");
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button7).set_BackgroundImage((Image)resourceManager.GetObject("button7.BackgroundImage"));
		((ButtonBase)button7).set_FlatStyle((FlatStyle)0);
		((Control)button7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point21 = default(Point);
		point21 = new Point(392, 329);
		((Control)button7).set_Location(point21);
		((Control)button7).set_Name("button7");
		Size size21 = default(Size);
		size21 = new Size(96, 22);
		((Control)button7).set_Size(size21);
		((Control)button7).set_TabIndex(37);
		((Control)button7).set_Text("Browse...");
		((Control)button7).add_Click((EventHandler)button7_Click);
		Color lightGray7 = Color.LightGray;
		Color backColor15 = lightGray7;
		((Control)pictureBox7).set_BackColor(backColor15);
		Point point22 = default(Point);
		point22 = new Point(146, 356);
		((Control)pictureBox7).set_Location(point22);
		((Control)pictureBox7).set_Name("pictureBox7");
		Size size22 = default(Size);
		size22 = new Size(136, 23);
		((Control)pictureBox7).set_Size(size22);
		pictureBox7.set_TabIndex(38);
		pictureBox7.set_TabStop(false);
		Color transparent2 = Color.Transparent;
		Color backColor16 = transparent2;
		((Control)label2).set_BackColor(backColor16);
		((Control)label2).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point23 = default(Point);
		point23 = new Point(8, 384);
		((Control)label2).set_Location(point23);
		((Control)label2).set_Name("label2");
		Size size23 = default(Size);
		size23 = new Size(480, 23);
		((Control)label2).set_Size(size23);
		((Control)label2).set_TabIndex(39);
		((Control)label2).set_Text("Version Information: V 1.1 -> Compiled 12 - 24 - 2007");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)label2).add_Click((EventHandler)label2_Click_1);
		Color transparent3 = Color.Transparent;
		Color backColor17 = transparent3;
		((Control)label3).set_BackColor(backColor17);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point24 = default(Point);
		point24 = new Point(464, 0);
		((Control)label3).set_Location(point24);
		((Control)label3).set_Name("label3");
		Size size24 = default(Size);
		size24 = new Size(32, 40);
		((Control)label3).set_Size(size24);
		((Control)label3).set_TabIndex(40);
		((Control)label3).set_Text("X");
		label3.set_TextAlign((ContentAlignment)32);
		((Control)label3).add_Click((EventHandler)label3_Click);
		Color transparent4 = Color.Transparent;
		Color backColor18 = transparent4;
		((Control)label4).set_BackColor(backColor18);
		((Control)label4).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point25 = default(Point);
		point25 = new Point(10, 408);
		((Control)label4).set_Location(point25);
		((Control)label4).set_Name("label4");
		Size size25 = default(Size);
		size25 = new Size(480, 23);
		((Control)label4).set_Size(size25);
		((Control)label4).set_TabIndex(41);
		((Control)label4).set_Text("Want To Generate Key Files For Your Own Dlls?");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)button8).set_BackgroundImage((Image)resourceManager.GetObject("button8.BackgroundImage"));
		((ButtonBase)button8).set_FlatStyle((FlatStyle)0);
		((Control)button8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point26 = default(Point);
		point26 = new Point(288, 329);
		((Control)button8).set_Location(point26);
		((Control)button8).set_Name("button8");
		Size size26 = default(Size);
		size26 = new Size(96, 22);
		((Control)button8).set_Size(size26);
		((Control)button8).set_TabIndex(48);
		((Control)button8).set_Text("Clear");
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)button9).set_BackgroundImage((Image)resourceManager.GetObject("button9.BackgroundImage"));
		((ButtonBase)button9).set_FlatStyle((FlatStyle)0);
		((Control)button9).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point27 = default(Point);
		point27 = new Point(288, 300);
		((Control)button9).set_Location(point27);
		((Control)button9).set_Name("button9");
		Size size27 = default(Size);
		size27 = new Size(96, 22);
		((Control)button9).set_Size(size27);
		((Control)button9).set_TabIndex(47);
		((Control)button9).set_Text("Clear");
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)button10).set_BackgroundImage((Image)resourceManager.GetObject("button10.BackgroundImage"));
		((ButtonBase)button10).set_FlatStyle((FlatStyle)0);
		((Control)button10).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point28 = default(Point);
		point28 = new Point(288, 271);
		((Control)button10).set_Location(point28);
		((Control)button10).set_Name("button10");
		Size size28 = default(Size);
		size28 = new Size(96, 22);
		((Control)button10).set_Size(size28);
		((Control)button10).set_TabIndex(46);
		((Control)button10).set_Text("Clear");
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)button11).set_BackgroundImage((Image)resourceManager.GetObject("button11.BackgroundImage"));
		((ButtonBase)button11).set_FlatStyle((FlatStyle)0);
		((Control)button11).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point29 = default(Point);
		point29 = new Point(288, 242);
		((Control)button11).set_Location(point29);
		((Control)button11).set_Name("button11");
		Size size29 = default(Size);
		size29 = new Size(96, 22);
		((Control)button11).set_Size(size29);
		((Control)button11).set_TabIndex(45);
		((Control)button11).set_Text("Clear");
		((Control)button11).add_Click((EventHandler)button11_Click);
		((Control)button12).set_BackgroundImage((Image)resourceManager.GetObject("button12.BackgroundImage"));
		((ButtonBase)button12).set_FlatStyle((FlatStyle)0);
		((Control)button12).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point30 = default(Point);
		point30 = new Point(288, 358);
		((Control)button12).set_Location(point30);
		((Control)button12).set_Name("button12");
		Size size30 = default(Size);
		size30 = new Size(96, 22);
		((Control)button12).set_Size(size30);
		((Control)button12).set_TabIndex(43);
		((Control)button12).set_Text("Reset");
		((Control)button12).add_Click((EventHandler)button12_Click);
		((Control)button13).set_BackgroundImage((Image)resourceManager.GetObject("button13.BackgroundImage"));
		((ButtonBase)button13).set_FlatStyle((FlatStyle)0);
		((Control)button13).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point31 = default(Point);
		point31 = new Point(288, 184);
		((Control)button13).set_Location(point31);
		((Control)button13).set_Name("button13");
		Size size31 = default(Size);
		size31 = new Size(96, 22);
		((Control)button13).set_Size(size31);
		((Control)button13).set_TabIndex(42);
		((Control)button13).set_Text("Clear");
		((Control)button13).add_Click((EventHandler)button13_Click);
		((Control)button14).set_BackgroundImage((Image)resourceManager.GetObject("button14.BackgroundImage"));
		((ButtonBase)button14).set_FlatStyle((FlatStyle)0);
		((Control)button14).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point32 = default(Point);
		point32 = new Point(288, 213);
		((Control)button14).set_Location(point32);
		((Control)button14).set_Name("button14");
		Size size32 = default(Size);
		size32 = new Size(96, 22);
		((Control)button14).set_Size(size32);
		((Control)button14).set_TabIndex(44);
		((Control)button14).set_Text("Clear");
		((Control)button14).add_Click((EventHandler)button14_Click);
		Color transparent5 = Color.Transparent;
		Color backColor19 = transparent5;
		((Control)label5).set_BackColor(backColor19);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point33 = default(Point);
		point33 = new Point(432, 0);
		((Control)label5).set_Location(point33);
		((Control)label5).set_Name("label5");
		Size size33 = default(Size);
		size33 = new Size(32, 40);
		((Control)label5).set_Size(size33);
		((Control)label5).set_TabIndex(49);
		((Control)label5).set_Text("-");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)label5).add_Click((EventHandler)label5_Click);
		notifyIcon1.set_Icon((Icon)resourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("Sacrafice Dll Injector");
		notifyIcon1.add_MouseDown(new MouseEventHandler(notifyIcon1_MouseDown));
		notifyIcon1.add_DoubleClick((EventHandler)notifyIcon1_DoubleClick);
		Color transparent6 = Color.Transparent;
		Color backColor20 = transparent6;
		((Control)label6).set_BackColor(backColor20);
		((Control)label6).set_Font(new Font("Courier New", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Point point34 = default(Point);
		point34 = new Point(8, 160);
		((Control)label6).set_Location(point34);
		((Control)label6).set_Name("label6");
		Size size34 = default(Size);
		size34 = new Size(480, 16);
		((Control)label6).set_Size(size34);
		((Control)label6).set_TabIndex(50);
		((Control)label6).set_Text("Waiting For User Input");
		label6.set_TextAlign((ContentAlignment)32);
		Size size35 = default(Size);
		size35 = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size35);
		Color control = SystemColors.Control;
		Color backColor21 = control;
		((Form)this).set_BackColor(backColor21);
		((Control)this).set_BackgroundImage((Image)resourceManager.GetObject("$this.BackgroundImage"));
		Size size36 = default(Size);
		size36 = new Size(499, 430);
		((Form)this).set_ClientSize(size36);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)button9);
		((Control)this).get_Controls().Add((Control)(object)button10);
		((Control)this).get_Controls().Add((Control)(object)button11);
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)button13);
		((Control)this).get_Controls().Add((Control)(object)button14);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)textBox6);
		((Control)this).get_Controls().Add((Control)(object)pictureBox5);
		((Control)this).get_Controls().Add((Control)(object)textBox7);
		((Control)this).get_Controls().Add((Control)(object)pictureBox6);
		((Control)this).get_Controls().Add((Control)(object)textBox4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)textBox5);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox7);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_Menu(mainMenu1);
		((Control)this).set_Name("mainForm");
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Control)this).set_Text("Sacrafice Dll Injector");
		((Form)this).add_Closing((CancelEventHandler)mainForm_Closing);
		((Form)this).add_Load((EventHandler)mainForm_Load);
		((Control)this).ResumeLayout(false);
	}

	private unsafe void button1_Click(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_00240x47914e9e _0024ArrayType_00240x47914e9e);
		_003CModule_003E.GetCurrentDirectoryW(260u, (ushort*)(&_0024ArrayType_00240x47914e9e));
		((FileDialog)openFileDialog1).set_InitialDirectory(new string((char*)(&_0024ArrayType_00240x47914e9e)));
		((FileDialog)openFileDialog1).set_Filter(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_0)));
		((FileDialog)openFileDialog1).set_FilterIndex(1);
		((FileDialog)openFileDialog1).set_RestoreDirectory(true);
		if ((int)((CommonDialog)openFileDialog1).ShowDialog() == 1)
		{
			Stream stream = openFileDialog1.OpenFile();
			if (stream != null)
			{
				string fileName = ((FileDialog)openFileDialog1).get_FileName();
				textBox1.set_Text(fileName);
				ushort* ptr = (pathName = string2Chars(fileName));
				stream.Close();
			}
		}
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
	}

	private unsafe void button2_Click(object sender, EventArgs e)
	{
		if (!injecting)
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x3bf64536_0)));
			new Thread(injectThread).Start();
		}
	}

	private unsafe void injectThread()
	{
		sbyte* ptr = string2CharsAnsi(textBox2.get_Text());
		if (_003CModule_003E._stricmp(ptr, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x9950811a_1)) != 0 && ptr != null)
		{
			if (pathName == null && pathName2 == null && pathName3 == null)
			{
				((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240xe9b02a11_4)));
				return;
			}
			if (pathName != null && keyName == null)
			{
				((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_1)));
				return;
			}
			if (pathName2 != null && keyName2 == null)
			{
				((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_1)));
				return;
			}
			if (pathName3 != null && keyName3 == null)
			{
				((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_1)));
				return;
			}
			processName = ptr;
			injecting = true;
			((Control)button2).set_Enabled(false);
			uint num = _003CModule_003E.Inject(processName, pathName, pathName2, pathName3, keyName, keyName2, keyName3);
			((Control)button2).set_Enabled(true);
			injecting = false;
			switch (num)
			{
			case 0u:
				((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240xe9b02a11_5)));
				break;
			case 1u:
				((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5c1e545c_1)));
				break;
			default:
				((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240xf0ab1b50_1)));
				break;
			}
		}
		else
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240xebf69448_0)));
		}
	}

	private void mainForm_Closing(object sender, CancelEventArgs e)
	{
		_003CModule_003E.ExitProcess(1u);
	}

	private void label2_Click(object sender, EventArgs e)
	{
		_003CModule_003E.ExitProcess(1u);
	}

	private void label2_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void label2_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private unsafe void label3_MouseDown(object sender, MouseEventArgs e)
	{
		IntPtr handle = ((Control)this).get_Handle();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out movWindow windowStats);
		System.Runtime.CompilerServices.Unsafe.As<movWindow, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref windowStats, 8)) = (int)handle;
		System.Runtime.CompilerServices.Unsafe.As<movWindow, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref windowStats, 4)) = ((Control)this).get_Height();
		*(int*)(&windowStats) = ((Control)this).get_Width();
		_003CModule_003E.moveWindow(windowStats);
	}

	private void label3_MouseUp(object sender, MouseEventArgs e)
	{
		_003CModule_003E.stopMoveWindow();
	}

	private unsafe void button3_Click(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_00240x47914e9e _0024ArrayType_00240x47914e9e);
		_003CModule_003E.GetCurrentDirectoryW(260u, (ushort*)(&_0024ArrayType_00240x47914e9e));
		((FileDialog)openFileDialog1).set_InitialDirectory(new string((char*)(&_0024ArrayType_00240x47914e9e)));
		((FileDialog)openFileDialog1).set_Filter(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_2)));
		((FileDialog)openFileDialog1).set_FilterIndex(2);
		((FileDialog)openFileDialog1).set_RestoreDirectory(true);
		if ((int)((CommonDialog)openFileDialog1).ShowDialog() == 1)
		{
			Stream stream = openFileDialog1.OpenFile();
			if (stream != null)
			{
				string fileName = ((FileDialog)openFileDialog1).get_FileName();
				textBox3.set_Text(fileName);
				ushort* ptr = (keyName = string2Chars(fileName));
				stream.Close();
			}
		}
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
	}

	private unsafe void mainForm_Load(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(mainForm));
		((TextBoxBase)textBox1).set_BackgroundImage((Image)resourceManager.GetObject("button1.BackgroundImage"));
		((Control)textBox1).BringToFront();
		((Control)label2).set_Text(new string(_003CModule_003E.getVersionInfo()));
		((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240xea34fe7f_0)));
	}

	private void textBox14_MouseHover(object sender, EventArgs e)
	{
	}

	private void radioButton6_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void pictureBox1_MouseHover(object sender, EventArgs e)
	{
	}

	private void pictureBox1_MouseEnter(object sender, EventArgs e)
	{
	}

	private void pictureBox1_MouseLeave(object sender, EventArgs e)
	{
	}

	private void textBox1_MouseEnter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox1).set_BackColor(backColor);
	}

	private void textBox1_MouseLeave(object sender, EventArgs e)
	{
		if (!((Control)textBox1).get_Focused())
		{
			Color lightGray = Color.LightGray;
			Color backColor = lightGray;
			((Control)pictureBox1).set_BackColor(backColor);
		}
	}

	private void textBox1_Enter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox1).set_BackColor(backColor);
	}

	private void textBox1_Leave(object sender, EventArgs e)
	{
		Color lightGray = Color.LightGray;
		Color backColor = lightGray;
		((Control)pictureBox1).set_BackColor(backColor);
	}

	private unsafe void label1_MouseDown(object sender, MouseEventArgs e)
	{
		IntPtr handle = ((Control)this).get_Handle();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out movWindow windowStats);
		System.Runtime.CompilerServices.Unsafe.As<movWindow, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref windowStats, 8)) = (int)handle;
		System.Runtime.CompilerServices.Unsafe.As<movWindow, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref windowStats, 4)) = ((Control)this).get_Height();
		*(int*)(&windowStats) = ((Control)this).get_Width();
		_003CModule_003E.moveWindow(windowStats);
	}

	private void label1_MouseUp(object sender, MouseEventArgs e)
	{
		_003CModule_003E.stopMoveWindow();
	}

	private void textBox3_Enter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox2).set_BackColor(backColor);
	}

	private void textBox3_Leave(object sender, EventArgs e)
	{
		Color lightGray = Color.LightGray;
		Color backColor = lightGray;
		((Control)pictureBox2).set_BackColor(backColor);
	}

	private void textBox3_MouseEnter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox2).set_BackColor(backColor);
	}

	private void textBox3_MouseLeave(object sender, EventArgs e)
	{
		if (!((Control)textBox3).get_Focused())
		{
			Color lightGray = Color.LightGray;
			Color backColor = lightGray;
			((Control)pictureBox2).set_BackColor(backColor);
		}
	}

	private unsafe void label2_Click_1(object sender, EventArgs e)
	{
		_003CModule_003E.MessageBoxA(null, _003CModule_003E.getUpdateInfo(), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x51890b12_0), 0u);
	}

	private void label3_Click(object sender, EventArgs e)
	{
		_003CModule_003E.ExitProcess(1u);
	}

	private void textBox5_MouseEnter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox4).set_BackColor(backColor);
	}

	private void textBox5_Enter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox4).set_BackColor(backColor);
	}

	private void textBox5_Leave(object sender, EventArgs e)
	{
		Color lightGray = Color.LightGray;
		Color backColor = lightGray;
		((Control)pictureBox4).set_BackColor(backColor);
	}

	private void textBox5_MouseLeave(object sender, EventArgs e)
	{
		if (!((Control)textBox5).get_Focused())
		{
			Color lightGray = Color.LightGray;
			Color backColor = lightGray;
			((Control)pictureBox4).set_BackColor(backColor);
		}
	}

	private void textBox4_MouseEnter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox3).set_BackColor(backColor);
	}

	private void textBox4_Enter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox3).set_BackColor(backColor);
	}

	private void textBox4_MouseLeave(object sender, EventArgs e)
	{
		if (!((Control)textBox4).get_Focused())
		{
			Color lightGray = Color.LightGray;
			Color backColor = lightGray;
			((Control)pictureBox3).set_BackColor(backColor);
		}
	}

	private void textBox4_Leave(object sender, EventArgs e)
	{
		Color lightGray = Color.LightGray;
		Color backColor = lightGray;
		((Control)pictureBox3).set_BackColor(backColor);
	}

	private void textBox7_MouseEnter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox6).set_BackColor(backColor);
	}

	private void textBox7_Enter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox6).set_BackColor(backColor);
	}

	private void textBox7_MouseLeave(object sender, EventArgs e)
	{
		if (!((Control)textBox7).get_Focused())
		{
			Color lightGray = Color.LightGray;
			Color backColor = lightGray;
			((Control)pictureBox6).set_BackColor(backColor);
		}
	}

	private void textBox7_Leave(object sender, EventArgs e)
	{
		Color lightGray = Color.LightGray;
		Color backColor = lightGray;
		((Control)pictureBox6).set_BackColor(backColor);
	}

	private void textBox6_MouseEnter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox5).set_BackColor(backColor);
	}

	private void textBox6_Enter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox5).set_BackColor(backColor);
	}

	private void textBox6_MouseLeave(object sender, EventArgs e)
	{
		if (!((Control)textBox6).get_Focused())
		{
			Color lightGray = Color.LightGray;
			Color backColor = lightGray;
			((Control)pictureBox5).set_BackColor(backColor);
		}
	}

	private void textBox6_Layout(object sender, LayoutEventArgs e)
	{
	}

	private void textBox6_Leave(object sender, EventArgs e)
	{
		Color lightGray = Color.LightGray;
		Color backColor = lightGray;
		((Control)pictureBox5).set_BackColor(backColor);
	}

	private void textBox2_MouseEnter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox7).set_BackColor(backColor);
	}

	private void textBox2_Enter(object sender, EventArgs e)
	{
		Color color = Color.FromArgb(39, 117, 205);
		Color backColor = color;
		((Control)pictureBox7).set_BackColor(backColor);
	}

	private void textBox2_MouseLeave(object sender, EventArgs e)
	{
		if (!((Control)textBox2).get_Focused())
		{
			Color lightGray = Color.LightGray;
			Color backColor = lightGray;
			((Control)pictureBox7).set_BackColor(backColor);
		}
	}

	private void textBox2_Leave(object sender, EventArgs e)
	{
		Color lightGray = Color.LightGray;
		Color backColor = lightGray;
		((Control)pictureBox7).set_BackColor(backColor);
	}

	private unsafe void button4_Click(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_00240x47914e9e _0024ArrayType_00240x47914e9e);
		_003CModule_003E.GetCurrentDirectoryW(260u, (ushort*)(&_0024ArrayType_00240x47914e9e));
		((FileDialog)openFileDialog1).set_InitialDirectory(new string((char*)(&_0024ArrayType_00240x47914e9e)));
		((FileDialog)openFileDialog1).set_Filter(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_0)));
		((FileDialog)openFileDialog1).set_FilterIndex(2);
		((FileDialog)openFileDialog1).set_RestoreDirectory(true);
		if ((int)((CommonDialog)openFileDialog1).ShowDialog() == 1)
		{
			Stream stream = openFileDialog1.OpenFile();
			if (stream != null)
			{
				string fileName = ((FileDialog)openFileDialog1).get_FileName();
				textBox5.set_Text(fileName);
				ushort* ptr = (pathName2 = string2Chars(fileName));
				stream.Close();
			}
		}
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
	}

	private unsafe void button6_Click(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_00240x47914e9e _0024ArrayType_00240x47914e9e);
		_003CModule_003E.GetCurrentDirectoryW(260u, (ushort*)(&_0024ArrayType_00240x47914e9e));
		((FileDialog)openFileDialog1).set_InitialDirectory(new string((char*)(&_0024ArrayType_00240x47914e9e)));
		((FileDialog)openFileDialog1).set_Filter(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_0)));
		((FileDialog)openFileDialog1).set_FilterIndex(2);
		((FileDialog)openFileDialog1).set_RestoreDirectory(true);
		if ((int)((CommonDialog)openFileDialog1).ShowDialog() == 1)
		{
			Stream stream = openFileDialog1.OpenFile();
			if (stream != null)
			{
				string fileName = ((FileDialog)openFileDialog1).get_FileName();
				textBox7.set_Text(fileName);
				ushort* ptr = (pathName3 = string2Chars(fileName));
				stream.Close();
			}
		}
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
	}

	private unsafe void button5_Click(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_00240x47914e9e _0024ArrayType_00240x47914e9e);
		_003CModule_003E.GetCurrentDirectoryW(260u, (ushort*)(&_0024ArrayType_00240x47914e9e));
		((FileDialog)openFileDialog1).set_InitialDirectory(new string((char*)(&_0024ArrayType_00240x47914e9e)));
		((FileDialog)openFileDialog1).set_Filter(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_2)));
		((FileDialog)openFileDialog1).set_FilterIndex(2);
		((FileDialog)openFileDialog1).set_RestoreDirectory(true);
		if ((int)((CommonDialog)openFileDialog1).ShowDialog() == 1)
		{
			Stream stream = openFileDialog1.OpenFile();
			if (stream != null)
			{
				string fileName = ((FileDialog)openFileDialog1).get_FileName();
				textBox4.set_Text(fileName);
				ushort* ptr = (keyName2 = string2Chars(fileName));
				stream.Close();
			}
		}
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
	}

	private unsafe void button7_Click(object sender, EventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_00240x47914e9e _0024ArrayType_00240x47914e9e);
		_003CModule_003E.GetCurrentDirectoryW(260u, (ushort*)(&_0024ArrayType_00240x47914e9e));
		((FileDialog)openFileDialog1).set_InitialDirectory(new string((char*)(&_0024ArrayType_00240x47914e9e)));
		((FileDialog)openFileDialog1).set_Filter(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x5e58ea05_2)));
		((FileDialog)openFileDialog1).set_FilterIndex(2);
		((FileDialog)openFileDialog1).set_RestoreDirectory(true);
		if ((int)((CommonDialog)openFileDialog1).ShowDialog() == 1)
		{
			Stream stream = openFileDialog1.OpenFile();
			if (stream != null)
			{
				string fileName = ((FileDialog)openFileDialog1).get_FileName();
				textBox6.set_Text(fileName);
				ushort* ptr = (keyName3 = string2Chars(fileName));
				stream.Close();
			}
		}
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
	}

	private unsafe void label4_Click(object sender, EventArgs e)
	{
		_003CModule_003E.MessageBoxA(null, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240xb0f28243_0), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x232f1e40_0), 0u);
	}

	private unsafe void button13_Click(object sender, EventArgs e)
	{
		if (injecting && _003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
		pathName = null;
		textBox1.set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x9950811a_1)));
	}

	private unsafe void button14_Click(object sender, EventArgs e)
	{
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
		keyName = null;
		textBox3.set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x9950811a_1)));
	}

	private unsafe void button11_Click(object sender, EventArgs e)
	{
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
		pathName2 = null;
		textBox5.set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x9950811a_1)));
	}

	private unsafe void button10_Click(object sender, EventArgs e)
	{
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
		keyName2 = null;
		textBox4.set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x9950811a_1)));
	}

	private unsafe void button9_Click(object sender, EventArgs e)
	{
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
		pathName3 = null;
		textBox7.set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x9950811a_1)));
	}

	private unsafe void button8_Click(object sender, EventArgs e)
	{
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
		keyName3 = null;
		textBox6.set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x9950811a_1)));
	}

	private unsafe void button12_Click(object sender, EventArgs e)
	{
		if (injecting && !_003CModule_003E.abortInjection())
		{
			((Control)label6).set_Text(new string((sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._0024ArrayType_00240x7575b9c6_0)));
		}
	}

	private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void notifyIcon1_DoubleClick(object sender, EventArgs e)
	{
		((Control)this).Show();
		notifyIcon1.set_Visible(false);
	}

	private void label5_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		notifyIcon1.set_Visible(true);
	}
}

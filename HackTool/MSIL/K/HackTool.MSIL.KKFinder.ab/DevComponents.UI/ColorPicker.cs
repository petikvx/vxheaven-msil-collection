using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar;

namespace DevComponents.UI;

[ToolboxItem(false)]
internal class ColorPicker : UserControl
{
	private Color[] color_0 = new Color[48];

	private Rectangle[] rectangle_0 = new Rectangle[48];

	private object object_0;

	private string string_0 = "";

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private TabPage tabPage3;

	private TabPage tabPage4;

	private Label label1;

	private ListBox listScheme;

	private Button btnOK;

	private Button btnCancel;

	private Panel colorPanel;

	private ListBox listSystem;

	private ListBox listWeb;

	private Color color_1 = Color.Empty;

	private string string_1 = "";

	private Panel colorPreview;

	private TrackBar transparencyTrack;

	private bool bool_0;

	private IWindowsFormsEditorService iwindowsFormsEditorService_0;

	private Container container_0;

	internal IWindowsFormsEditorService IWindowsFormsEditorService_0
	{
		get
		{
			return iwindowsFormsEditorService_0;
		}
		set
		{
			iwindowsFormsEditorService_0 = value;
		}
	}

	[Browsable(false)]
	[DefaultValue(null)]
	public object Object_0
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
			method_2();
		}
	}

	public Color Color_0
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			method_3();
		}
	}

	public string String_0
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public bool Boolean_0 => bool_0;

	public ColorPicker()
	{
		InitializeComponent();
		method_0();
		method_1();
		string_0 = ((Control)label1).get_Text();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected O, but got Unknown
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		listScheme = new ListBox();
		tabPage2 = new TabPage();
		listSystem = new ListBox();
		tabPage3 = new TabPage();
		listWeb = new ListBox();
		tabPage4 = new TabPage();
		colorPanel = new Panel();
		transparencyTrack = new TrackBar();
		label1 = new Label();
		colorPreview = new Panel();
		btnOK = new Button();
		btnCancel = new Button();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((Control)tabPage4).SuspendLayout();
		((ISupportInitialize)transparencyTrack).BeginInit();
		((Control)this).SuspendLayout();
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage3);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage4);
		((Control)tabControl1).set_Location(new Point(1, 1));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(208, 192));
		((Control)tabControl1).set_TabIndex(0);
		tabControl1.add_SelectedIndexChanged((EventHandler)tabControl1_SelectedIndexChanged);
		((Control)tabPage1).get_Controls().Add((Control)(object)listScheme);
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Size(new Size(200, 166));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("Scheme");
		((Control)listScheme).set_Dock((DockStyle)5);
		listScheme.set_DrawMode((DrawMode)1);
		listScheme.set_IntegralHeight(false);
		((Control)listScheme).set_Location(new Point(0, 0));
		((Control)listScheme).set_Name("listScheme");
		((Control)listScheme).set_Size(new Size(200, 166));
		((Control)listScheme).set_TabIndex(0);
		listScheme.add_DrawItem(new DrawItemEventHandler(listWeb_DrawItem));
		listScheme.add_SelectedIndexChanged((EventHandler)listWeb_SelectedIndexChanged);
		((Control)tabPage2).get_Controls().Add((Control)(object)listSystem);
		tabPage2.set_Location(new Point(4, 22));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Size(new Size(200, 166));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("System");
		((Control)listSystem).set_Dock((DockStyle)5);
		listSystem.set_DrawMode((DrawMode)1);
		listSystem.set_IntegralHeight(false);
		((Control)listSystem).set_Location(new Point(0, 0));
		((Control)listSystem).set_Name("listSystem");
		((Control)listSystem).set_Size(new Size(200, 166));
		((Control)listSystem).set_TabIndex(1);
		listSystem.add_DrawItem(new DrawItemEventHandler(listWeb_DrawItem));
		listSystem.add_SelectedIndexChanged((EventHandler)listWeb_SelectedIndexChanged);
		((Control)tabPage3).get_Controls().Add((Control)(object)listWeb);
		tabPage3.set_Location(new Point(4, 22));
		((Control)tabPage3).set_Name("tabPage3");
		((Control)tabPage3).set_Size(new Size(200, 166));
		tabPage3.set_TabIndex(2);
		((Control)tabPage3).set_Text("Web");
		((Control)listWeb).set_Dock((DockStyle)5);
		listWeb.set_DrawMode((DrawMode)1);
		listWeb.set_IntegralHeight(false);
		((Control)listWeb).set_Location(new Point(0, 0));
		((Control)listWeb).set_Name("listWeb");
		((Control)listWeb).set_Size(new Size(200, 166));
		((Control)listWeb).set_TabIndex(1);
		listWeb.add_DrawItem(new DrawItemEventHandler(listWeb_DrawItem));
		listWeb.add_SelectedIndexChanged((EventHandler)listWeb_SelectedIndexChanged);
		((Control)tabPage4).get_Controls().Add((Control)(object)colorPanel);
		tabPage4.set_Location(new Point(4, 22));
		((Control)tabPage4).set_Name("tabPage4");
		((Control)tabPage4).set_Size(new Size(200, 166));
		tabPage4.set_TabIndex(3);
		((Control)tabPage4).set_Text("Custom");
		((Control)colorPanel).set_Dock((DockStyle)5);
		((Control)colorPanel).set_Location(new Point(0, 0));
		((Control)colorPanel).set_Name("colorPanel");
		((Control)colorPanel).set_Size(new Size(200, 166));
		((Control)colorPanel).set_TabIndex(0);
		((Control)colorPanel).add_MouseUp(new MouseEventHandler(colorPanel_MouseUp));
		((Control)colorPanel).add_Paint(new PaintEventHandler(colorPanel_Paint));
		((Control)transparencyTrack).set_Enabled(false);
		((Control)transparencyTrack).set_Location(new Point(1, 204));
		transparencyTrack.set_Maximum(255);
		((Control)transparencyTrack).set_Name("transparencyTrack");
		((Control)transparencyTrack).set_Size(new Size(200, 45));
		((Control)transparencyTrack).set_TabIndex(1);
		transparencyTrack.set_TickFrequency(16);
		transparencyTrack.set_Value(255);
		transparencyTrack.add_ValueChanged((EventHandler)transparencyTrack_ValueChanged);
		((Control)label1).set_Location(new Point(1, 194));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(136, 16));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Transparency");
		((Control)colorPreview).set_BackColor(Color.White);
		colorPreview.set_BorderStyle((BorderStyle)1);
		((Control)colorPreview).set_Location(new Point(8, 240));
		((Control)colorPreview).set_Name("colorPreview");
		((Control)colorPreview).set_Size(new Size(40, 32));
		((Control)colorPreview).set_TabIndex(3);
		((Control)colorPreview).add_Paint(new PaintEventHandler(colorPreview_Paint));
		((ButtonBase)btnOK).set_FlatStyle((FlatStyle)3);
		((Control)btnOK).set_Location(new Point(72, 248));
		((Control)btnOK).set_Name("btnOK");
		((Control)btnOK).set_Size(new Size(64, 24));
		((Control)btnOK).set_TabIndex(4);
		((Control)btnOK).set_Text("OK");
		((Control)btnOK).add_Click((EventHandler)btnOK_Click);
		((ButtonBase)btnCancel).set_FlatStyle((FlatStyle)3);
		((Control)btnCancel).set_Location(new Point(142, 248));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(64, 24));
		((Control)btnCancel).set_TabIndex(5);
		((Control)btnCancel).set_Text("Cancel");
		((Control)btnCancel).add_Click((EventHandler)btnCancel_Click);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnOK);
		((Control)this).get_Controls().Add((Control)(object)colorPreview);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)transparencyTrack);
		((ScrollableControl)this).get_DockPadding().set_All(1);
		((Control)this).set_Name("ColorPicker");
		((Control)this).set_Size(new Size(211, 280));
		((Control)this).add_Paint(new PaintEventHandler(ColorPicker_Paint));
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage3).ResumeLayout(false);
		((Control)tabPage4).ResumeLayout(false);
		((ISupportInitialize)transparencyTrack).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void method_0()
	{
		ref Color reference = ref color_0[0];
		reference = Color.FromArgb(255, 255, 255);
		ref Color reference2 = ref color_0[1];
		reference2 = Color.FromArgb(255, 195, 198);
		ref Color reference3 = ref color_0[2];
		reference3 = Color.FromArgb(255, 227, 198);
		ref Color reference4 = ref color_0[3];
		reference4 = Color.FromArgb(255, 255, 198);
		ref Color reference5 = ref color_0[4];
		reference5 = Color.FromArgb(198, 255, 198);
		ref Color reference6 = ref color_0[5];
		reference6 = Color.FromArgb(198, 255, 255);
		ref Color reference7 = ref color_0[6];
		reference7 = Color.FromArgb(198, 195, 255);
		ref Color reference8 = ref color_0[7];
		reference8 = Color.FromArgb(255, 195, 255);
		ref Color reference9 = ref color_0[8];
		reference9 = Color.FromArgb(231, 227, 231);
		ref Color reference10 = ref color_0[9];
		reference10 = Color.FromArgb(255, 130, 132);
		ref Color reference11 = ref color_0[10];
		reference11 = Color.FromArgb(255, 195, 132);
		ref Color reference12 = ref color_0[11];
		reference12 = Color.FromArgb(255, 255, 132);
		ref Color reference13 = ref color_0[12];
		reference13 = Color.FromArgb(132, 255, 132);
		ref Color reference14 = ref color_0[13];
		reference14 = Color.FromArgb(132, 255, 255);
		ref Color reference15 = ref color_0[14];
		reference15 = Color.FromArgb(132, 130, 255);
		ref Color reference16 = ref color_0[15];
		reference16 = Color.FromArgb(255, 130, 255);
		ref Color reference17 = ref color_0[16];
		reference17 = Color.FromArgb(198, 195, 198);
		ref Color reference18 = ref color_0[17];
		reference18 = Color.FromArgb(255, 0, 0);
		ref Color reference19 = ref color_0[18];
		reference19 = Color.FromArgb(255, 130, 0);
		ref Color reference20 = ref color_0[19];
		reference20 = Color.FromArgb(255, 255, 0);
		ref Color reference21 = ref color_0[20];
		reference21 = Color.FromArgb(0, 255, 0);
		ref Color reference22 = ref color_0[21];
		reference22 = Color.FromArgb(0, 255, 255);
		ref Color reference23 = ref color_0[22];
		reference23 = Color.FromArgb(0, 0, 255);
		ref Color reference24 = ref color_0[23];
		reference24 = Color.FromArgb(255, 0, 255);
		ref Color reference25 = ref color_0[24];
		reference25 = Color.FromArgb(132, 130, 132);
		ref Color reference26 = ref color_0[25];
		reference26 = Color.FromArgb(198, 0, 0);
		ref Color reference27 = ref color_0[26];
		reference27 = Color.FromArgb(198, 65, 0);
		ref Color reference28 = ref color_0[27];
		reference28 = Color.FromArgb(198, 195, 0);
		ref Color reference29 = ref color_0[28];
		reference29 = Color.FromArgb(0, 195, 0);
		ref Color reference30 = ref color_0[29];
		reference30 = Color.FromArgb(0, 195, 198);
		ref Color reference31 = ref color_0[30];
		reference31 = Color.FromArgb(0, 0, 198);
		ref Color reference32 = ref color_0[31];
		reference32 = Color.FromArgb(198, 0, 198);
		ref Color reference33 = ref color_0[32];
		reference33 = Color.FromArgb(66, 65, 66);
		ref Color reference34 = ref color_0[33];
		reference34 = Color.FromArgb(132, 0, 0);
		ref Color reference35 = ref color_0[34];
		reference35 = Color.FromArgb(132, 65, 0);
		ref Color reference36 = ref color_0[35];
		reference36 = Color.FromArgb(132, 130, 0);
		ref Color reference37 = ref color_0[36];
		reference37 = Color.FromArgb(0, 130, 0);
		ref Color reference38 = ref color_0[37];
		reference38 = Color.FromArgb(0, 130, 132);
		ref Color reference39 = ref color_0[38];
		reference39 = Color.FromArgb(0, 0, 132);
		ref Color reference40 = ref color_0[39];
		reference40 = Color.FromArgb(132, 0, 132);
		ref Color reference41 = ref color_0[40];
		reference41 = Color.FromArgb(0, 0, 0);
		ref Color reference42 = ref color_0[41];
		reference42 = Color.FromArgb(66, 0, 0);
		ref Color reference43 = ref color_0[42];
		reference43 = Color.FromArgb(132, 65, 66);
		ref Color reference44 = ref color_0[43];
		reference44 = Color.FromArgb(66, 65, 0);
		ref Color reference45 = ref color_0[44];
		reference45 = Color.FromArgb(0, 65, 0);
		ref Color reference46 = ref color_0[45];
		reference46 = Color.FromArgb(0, 65, 66);
		ref Color reference47 = ref color_0[46];
		reference47 = Color.FromArgb(0, 0, 66);
		ref Color reference48 = ref color_0[47];
		reference48 = Color.FromArgb(66, 0, 66);
	}

	private void method_1()
	{
		listWeb.BeginUpdate();
		listWeb.get_Items().Clear();
		Type typeFromHandle = typeof(Color);
		PropertyInfo[] properties = typeFromHandle.GetProperties(BindingFlags.Static | BindingFlags.Public);
		Color color = default(Color);
		PropertyInfo[] array = properties;
		foreach (PropertyInfo propertyInfo in array)
		{
			listWeb.get_Items().Add(propertyInfo.GetValue(color, null));
		}
		listWeb.EndUpdate();
		listSystem.BeginUpdate();
		listSystem.get_Items().Clear();
		typeFromHandle = typeof(SystemColors);
		properties = typeFromHandle.GetProperties(BindingFlags.Static | BindingFlags.Public);
		PropertyInfo[] array2 = properties;
		foreach (PropertyInfo propertyInfo2 in array2)
		{
			listSystem.get_Items().Add(propertyInfo2.GetValue(color, null));
		}
		listSystem.EndUpdate();
	}

	private void method_2()
	{
		if (object_0 != null)
		{
			if (!tabControl1.get_TabPages().Contains(tabPage1))
			{
				tabControl1.get_TabPages().Add(tabPage1);
			}
			listScheme.BeginUpdate();
			listScheme.get_Items().Clear();
			Type type = object_0.GetType();
			PropertyInfo[] properties = type.GetProperties();
			PropertyInfo[] array = properties;
			foreach (PropertyInfo propertyInfo in array)
			{
				if ((object)propertyInfo.PropertyType == typeof(Color))
				{
					listScheme.get_Items().Add((object)propertyInfo.Name);
				}
			}
			listScheme.EndUpdate();
		}
		else if (tabControl1.get_TabPages().Contains(tabPage1))
		{
			tabControl1.get_TabPages().Remove(tabPage1);
		}
	}

	private void colorPanel_Paint(object sender, PaintEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		Rectangle empty = Rectangle.Empty;
		int num = 6;
		int num2 = 12;
		Graphics graphics = e.get_Graphics();
		Border3DSide val = (Border3DSide)15;
		int width = ((Control)colorPanel).get_ClientRectangle().Width;
		int num3 = 0;
		Color[] array = color_0;
		foreach (Color color in array)
		{
			empty = new Rectangle(num, num2, 21, 21);
			if (empty.Right > width)
			{
				num2 += 25;
				num = 6;
				empty.X = 6;
				empty.Y = num2;
			}
			ControlPaint.DrawBorder3D(graphics, num, num2, 21, 21, (Border3DStyle)10, val);
			empty.Inflate(-2, -2);
			graphics.FillRectangle((Brush)new SolidBrush(color), empty);
			rectangle_0[num3] = empty;
			num3++;
			num += 24;
		}
	}

	private void listWeb_DrawItem(object sender, DrawItemEventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		Rectangle bounds = e.get_Bounds();
		Rectangle rectangle = new Rectangle(bounds.X + 1, bounds.Y + 2, 24, bounds.Height - 4);
		ListBox val = (ListBox)((sender is ListBox) ? sender : null);
		Color color = SystemColors.ControlText;
		if ((e.get_State() & 1) != 0)
		{
			color = SystemColors.HighlightText;
			e.get_Graphics().FillRectangle(SystemBrushes.get_Highlight(), e.get_Bounds());
		}
		else
		{
			e.get_Graphics().FillRectangle(SystemBrushes.get_Window(), e.get_Bounds());
		}
		Color empty = Color.Empty;
		string text = "";
		if ((object)val.get_Items().get_Item(e.get_Index()).GetType() == typeof(Color))
		{
			empty = (Color)val.get_Items().get_Item(e.get_Index());
			text = empty.Name;
		}
		else
		{
			text = val.get_Items().get_Item(e.get_Index()).ToString();
			empty = (Color)object_0.GetType().GetProperty(text)!.GetValue(object_0, null);
		}
		e.get_Graphics().FillRectangle((Brush)new SolidBrush(empty), rectangle);
		e.get_Graphics().DrawRectangle(SystemPens.get_ControlText(), rectangle);
		bounds.Offset(30, 0);
		bounds.Width -= 30;
		Class55.smethod_1(e.get_Graphics(), text, ((Control)val).get_Font(), color, bounds, eTextFormat.Default);
	}

	private void colorPanel_MouseUp(object sender, MouseEventArgs e)
	{
		int num = 0;
		while (true)
		{
			if (num < 48)
			{
				if (rectangle_0[num].Contains(e.get_X(), e.get_Y()))
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Color_0 = color_0[num];
		string_1 = "";
	}

	private void listWeb_SelectedIndexChanged(object sender, EventArgs e)
	{
		ListBox val = (ListBox)((sender is ListBox) ? sender : null);
		if (val.get_SelectedItem() != null)
		{
			if (val.get_SelectedItem() is Color)
			{
				Color_0 = (Color)val.get_SelectedItem();
				string_1 = "";
			}
			else
			{
				string_1 = val.get_SelectedItem().ToString();
				Color_0 = (Color)object_0.GetType().GetProperty(String_0)!.GetValue(object_0, null);
			}
		}
		else
		{
			Color_0 = Color.Empty;
			string_1 = "";
		}
	}

	private void method_3()
	{
		((Control)colorPreview).set_BackColor(color_1);
		transparencyTrack.set_Value((int)color_1.A);
		method_6();
	}

	public void method_4()
	{
		((ListControl)listSystem).set_SelectedIndex(-1);
		((ListControl)listWeb).set_SelectedIndex(-1);
		((ListControl)listScheme).set_SelectedIndex(-1);
		if (color_1.IsSystemColor)
		{
			tabControl1.set_SelectedTab(tabPage2);
			method_5(listSystem, color_1.Name);
		}
		else if (color_1.IsNamedColor)
		{
			tabControl1.set_SelectedTab(tabPage3);
			method_5(listWeb, color_1.Name);
		}
		else if (string_1 != "")
		{
			tabControl1.set_SelectedTab(tabPage1);
			method_5(listScheme, string_1);
		}
		else
		{
			tabControl1.set_SelectedTab(tabPage4);
		}
	}

	private void method_5(ListBox listBox_0, string string_2)
	{
		foreach (object item in listBox_0.get_Items())
		{
			if (item.ToString() == string_2)
			{
				listBox_0.set_SelectedItem(item);
				break;
			}
		}
	}

	private void method_6()
	{
		if (!Color_0.IsEmpty)
		{
			((Control)label1).set_Text(string_0 + " (" + Color_0.A + ")");
		}
		else
		{
			((Control)label1).set_Text(string_0);
		}
	}

	private void transparencyTrack_ValueChanged(object sender, EventArgs e)
	{
		if (!Color_0.IsEmpty && Color_0.A != transparencyTrack.get_Value())
		{
			Color_0 = Color.FromArgb(transparencyTrack.get_Value(), Color_0);
			string_1 = "";
		}
		method_6();
	}

	private void colorPreview_Paint(object sender, PaintEventArgs e)
	{
		if (Color_0.IsEmpty)
		{
			Rectangle clientRectangle = ((Control)colorPreview).get_ClientRectangle();
			clientRectangle.Inflate(-2, -2);
			e.get_Graphics().DrawLine(SystemPens.get_ControlText(), clientRectangle.X, clientRectangle.Y, clientRectangle.Right, clientRectangle.Bottom);
			e.get_Graphics().DrawLine(SystemPens.get_ControlText(), clientRectangle.Right, clientRectangle.Y, clientRectangle.X, clientRectangle.Bottom);
		}
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		method_7();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		method_7();
	}

	private void method_7()
	{
		if (iwindowsFormsEditorService_0 != null)
		{
			iwindowsFormsEditorService_0.CloseDropDown();
		}
		else if (((Control)this).get_Parent() != null)
		{
			((Control)this).get_Parent().Hide();
		}
		else
		{
			((Control)this).Hide();
		}
	}

	private void ColorPicker_Paint(object sender, PaintEventArgs e)
	{
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		clientRectangle.Width--;
		clientRectangle.Height--;
		e.get_Graphics().DrawRectangle(SystemPens.get_ControlDarkDark(), clientRectangle);
	}

	private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (tabControl1.get_SelectedIndex() == 0 && object_0 != null && string_1 != "")
		{
			((Control)transparencyTrack).set_Enabled(false);
		}
		else
		{
			((Control)transparencyTrack).set_Enabled(true);
		}
	}
}

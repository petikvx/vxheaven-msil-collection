using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace DevComponents.DotNetBar;

public class ColorSchemeEditor : Form
{
	private PropertyGrid propertyGrid1;

	private GroupBox groupBox1;

	private Container container_0;

	private ColorScheme colorScheme_0;

	private Button button1;

	private Button button2;

	private MenuPanel menuPanel_0;

	private Bar bar_0;

	private Bar bar_1;

	private Button button3;

	private Bar bar_2;

	private Button btnSaveScheme;

	private Button btnLoadScheme;

	private OpenFileDialog openFileDialog_0;

	private SaveFileDialog saveFileDialog_0;

	public bool ColorSchemeChanged;

	public ColorScheme ColorScheme
	{
		get
		{
			return colorScheme_0;
		}
		set
		{
			if (menuPanel_0 == null)
			{
				method_0();
			}
			colorScheme_0 = value;
			propertyGrid1.set_SelectedObject((object)colorScheme_0);
			menuPanel_0.ColorScheme = colorScheme_0;
			bar_0.ColorScheme = colorScheme_0;
			bar_1.ColorScheme = colorScheme_0;
			bar_2.ColorScheme = colorScheme_0;
			ColorSchemeChanged = false;
		}
	}

	public ColorSchemeEditor()
	{
		InitializeComponent();
		((Form)this).set_StartPosition((FormStartPosition)1);
	}

	private void method_0()
	{
		if (menuPanel_0 != null)
		{
			menuPanel_0.RecalcSize();
			bar_0.Size = new Size(((Control)groupBox1).get_ClientRectangle().Width - 12, 16);
			bar_0.RecalcSize();
			bar_1.Size = new Size(((Control)groupBox1).get_ClientRectangle().Width, 16);
			bar_1.RecalcSize();
			bar_2.Size = new Size(((Control)groupBox1).get_ClientRectangle().Width, 24);
			bar_2.RecalcSize();
			return;
		}
		menuPanel_0 = new MenuPanel();
		menuPanel_0.PopupMenu = false;
		((Control)menuPanel_0).set_Location(new Point(8, 135));
		bar_0 = new Bar();
		bar_0.bool_25 = true;
		bar_0.Location = new Point(4, 16);
		bar_0.ThemeAware = false;
		bar_1 = new Bar();
		bar_1.bool_25 = true;
		bar_1.Location = new Point(4, 46);
		bar_1.ThemeAware = false;
		bar_2 = new Bar();
		bar_2.bool_25 = true;
		bar_2.Location = new Point(4, 96);
		bar_2.ThemeAware = false;
		ButtonItem buttonItem = new ButtonItem();
		Bitmap val = null;
		ButtonItem buttonItem2 = new ButtonItem("new", "&New...");
		val = Class109.smethod_67("BarEditorImages.FileNew.bmp");
		val.MakeTransparent(Color.Magenta);
		buttonItem2.Image = (Image)(object)val;
		bar_0.Items.Add(buttonItem2.Copy());
		bar_1.Items.Add(buttonItem2.Copy());
		bar_2.Items.Add(buttonItem2.Copy());
		buttonItem.SubItems.Add(buttonItem2);
		buttonItem2 = new ButtonItem("open", "&Open");
		val = Class109.smethod_67("BarEditorImages.FileOpen.bmp");
		val.MakeTransparent(Color.Magenta);
		buttonItem2.Image = (Image)(object)val;
		ButtonItem buttonItem3 = (ButtonItem)buttonItem2.Copy();
		buttonItem3.ButtonStyle = eButtonStyle.ImageAndText;
		bar_0.Items.Add(buttonItem3);
		bar_1.Items.Add(buttonItem3.Copy());
		bar_2.Items.Add(buttonItem3.Copy());
		buttonItem.SubItems.Add(buttonItem2);
		buttonItem2 = new ButtonItem("close", "&Close");
		val = Class109.smethod_67("BarEditorImages.FileClose.bmp");
		val.MakeTransparent(Color.Magenta);
		buttonItem2.Image = (Image)(object)val;
		buttonItem3 = (ButtonItem)buttonItem2.Copy();
		buttonItem3.Checked = true;
		buttonItem3.ButtonStyle = eButtonStyle.ImageAndText;
		bar_0.Items.Add(buttonItem3);
		bar_2.Items.Add(buttonItem3.Copy());
		buttonItem3 = (ButtonItem)buttonItem3.Copy();
		buttonItem3.Enabled = false;
		bar_1.Items.Add(buttonItem3.Copy());
		buttonItem.SubItems.Add(buttonItem2);
		buttonItem2 = new ButtonItem("open", "Add Ne&w Item...");
		buttonItem.SubItems.Add(buttonItem2);
		buttonItem2 = new ButtonItem("open", "Add Existin&g Item...");
		buttonItem.SubItems.Add(buttonItem2);
		buttonItem2 = new ButtonItem("opensol", "Open Solution...");
		buttonItem2.BeginGroup = true;
		val = Class109.smethod_67("BarEditorImages.FileOpenSol.bmp");
		val.MakeTransparent(Color.Magenta);
		buttonItem2.Image = (Image)(object)val;
		buttonItem3 = (ButtonItem)buttonItem2.Copy();
		buttonItem3.Enabled = false;
		bar_0.Items.Add(buttonItem3);
		bar_1.Items.Add(buttonItem3.Copy());
		bar_2.Items.Add(buttonItem3.Copy());
		buttonItem.SubItems.Add(buttonItem2);
		buttonItem2 = new ButtonItem("open", "Close Solution");
		val = Class109.smethod_67("BarEditorImages.FileCloseSol.bmp");
		val.MakeTransparent(Color.Magenta);
		buttonItem2.Image = (Image)(object)val;
		buttonItem2.Enabled = false;
		buttonItem.SubItems.Add(buttonItem2);
		menuPanel_0.ParentItem = buttonItem;
		((Control)groupBox1).get_Controls().Add((Control)(object)menuPanel_0);
		menuPanel_0.RecalcSize();
		menuPanel_0.Show();
		bar_0.Size = new Size(((Control)groupBox1).get_ClientRectangle().Width, 16);
		bar_0.GrabHandleStyle = eGrabHandleStyle.StripeFlat;
		((Control)groupBox1).get_Controls().Add((Control)(object)bar_0);
		bar_0.RecalcSize();
		bar_0.Show();
		bar_1.method_88(eBarState.Floating);
		bar_1.Size = new Size(((Control)groupBox1).get_ClientRectangle().Width, 16);
		((Control)groupBox1).get_Controls().Add((Control)(object)bar_1);
		((Control)bar_1).set_Text("Bar Caption");
		bar_1.RecalcSize();
		bar_1.Show();
		bar_2.method_88(eBarState.Popup);
		bar_2.Size = new Size(((Control)groupBox1).get_ClientRectangle().Width, 24);
		bar_2.Int32_7 = ((Control)groupBox1).get_ClientRectangle().Width;
		((Control)groupBox1).get_Controls().Add((Control)(object)bar_2);
		bar_2.RecalcSize();
		bar_2.Show();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((Form)this).Dispose(disposing);
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
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		propertyGrid1 = new PropertyGrid();
		groupBox1 = new GroupBox();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		btnSaveScheme = new Button();
		btnLoadScheme = new Button();
		openFileDialog_0 = new OpenFileDialog();
		saveFileDialog_0 = new SaveFileDialog();
		((Control)this).SuspendLayout();
		propertyGrid1.set_CommandsVisibleIfAvailable(true);
		propertyGrid1.set_LargeButtons(false);
		propertyGrid1.set_LineColor(SystemColors.ScrollBar);
		((Control)propertyGrid1).set_Location(new Point(208, 4));
		((Control)propertyGrid1).set_Name("propertyGrid1");
		((Control)propertyGrid1).set_Size(new Size(352, 299));
		((Control)propertyGrid1).set_TabIndex(0);
		((Control)propertyGrid1).set_Text("propertyGrid1");
		propertyGrid1.set_ViewBackColor(SystemColors.Window);
		propertyGrid1.set_ViewForeColor(SystemColors.WindowText);
		propertyGrid1.add_PropertyValueChanged(new PropertyValueChangedEventHandler(propertyGrid1_PropertyValueChanged));
		((Control)groupBox1).set_Location(new Point(10, 0));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(190, 303));
		((Control)groupBox1).set_TabIndex(1);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Color Scheme Preview:");
		((ButtonBase)button1).set_FlatStyle((FlatStyle)3);
		((Control)button1).set_Location(new Point(404, 307));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(76, 24));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("OK");
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)3);
		((Control)button2).set_Location(new Point(316, 307));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(76, 24));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("&Reset");
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)3);
		((Control)button3).set_Location(new Point(484, 307));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(76, 24));
		((Control)button3).set_TabIndex(4);
		((Control)button3).set_Text("Cancel");
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ButtonBase)btnSaveScheme).set_FlatStyle((FlatStyle)3);
		((Control)btnSaveScheme).set_Location(new Point(10, 308));
		((Control)btnSaveScheme).set_Name("btnSaveScheme");
		((Control)btnSaveScheme).set_Size(new Size(92, 24));
		((Control)btnSaveScheme).set_TabIndex(5);
		((Control)btnSaveScheme).set_Text("Save Scheme...");
		((Control)btnSaveScheme).add_Click((EventHandler)btnSaveScheme_Click);
		((ButtonBase)btnLoadScheme).set_FlatStyle((FlatStyle)3);
		((Control)btnLoadScheme).set_Location(new Point(107, 308));
		((Control)btnLoadScheme).set_Name("btnLoadScheme");
		((Control)btnLoadScheme).set_Size(new Size(92, 24));
		((Control)btnLoadScheme).set_TabIndex(6);
		((Control)btnLoadScheme).set_Text("Load Scheme...");
		((Control)btnLoadScheme).add_Click((EventHandler)btnLoadScheme_Click);
		((FileDialog)openFileDialog_0).set_DefaultExt("*.dcs");
		((FileDialog)openFileDialog_0).set_Filter("DotNetBar Color Scheme files|*.dcs|All files|*.*");
		((FileDialog)openFileDialog_0).set_Title("Open DotNetBar Color Scheme File");
		((FileDialog)saveFileDialog_0).set_DefaultExt("dcs");
		((FileDialog)saveFileDialog_0).set_FileName("colorscheme1");
		((FileDialog)saveFileDialog_0).set_Filter("DotNetBar Color Scheme files|*.dcs|All files|*.*");
		((FileDialog)saveFileDialog_0).set_Title("Save DotNetBar Color Scheme File");
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(567, 338));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[7]
		{
			(Control)btnLoadScheme,
			(Control)btnSaveScheme,
			(Control)button3,
			(Control)button2,
			(Control)button1,
			(Control)groupBox1,
			(Control)propertyGrid1
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ColorSchemeEditor");
		((Control)this).set_Text("ColorScheme Editor");
		((Form)this).add_Load((EventHandler)ColorSchemeEditor_Load);
		((Control)this).ResumeLayout(false);
	}

	private void ColorSchemeEditor_Load(object sender, EventArgs e)
	{
		method_0();
	}

	private void propertyGrid1_PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
	{
		((Control)menuPanel_0).Refresh();
		((Control)bar_0).Refresh();
		((Control)bar_1).Refresh();
		((Control)bar_2).Refresh();
		ColorSchemeChanged = true;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Reseting the Color Scheme will destroy any changes you made. Are you sure you want to reset the Color Scheme?", "Color Scheme Editor", (MessageBoxButtons)4) == 6)
		{
			ColorScheme = new ColorScheme(ColorScheme.EDotNetBarStyle_0);
			ColorSchemeChanged = true;
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		ColorSchemeChanged = false;
		((Control)this).Hide();
	}

	private void btnSaveScheme_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((CommonDialog)saveFileDialog_0).ShowDialog() == 1)
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlElement xmlElement = xmlDocument.CreateElement("colorschemes");
			xmlDocument.AppendChild(xmlElement);
			XmlElement xmlElement2 = xmlDocument.CreateElement("colorscheme");
			xmlElement.AppendChild(xmlElement2);
			colorScheme_0.Serialize(xmlElement2);
			xmlDocument.Save(((FileDialog)saveFileDialog_0).get_FileName());
			MessageBox.Show("Color Scheme has been saved.", "DotNetBar Color Scheme Editor", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void btnLoadScheme_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)openFileDialog_0).ShowDialog() == 1 && File.Exists(((FileDialog)openFileDialog_0).get_FileName()))
		{
			ColorScheme colorScheme = new ColorScheme();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(((FileDialog)openFileDialog_0).get_FileName());
			colorScheme.Deserialize(xmlDocument.FirstChild!.FirstChild as XmlElement);
			ColorScheme = colorScheme;
			ColorSchemeChanged = true;
		}
	}
}

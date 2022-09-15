#define TRACE
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using GoolagScan.Debug;
using GoolagScan.Properties;

namespace GoolagScan;

public class Options : Form
{
	private IContainer components;

	private Button saveButton;

	private Button abortButton;

	private TabControl OptionsTab;

	private TabPage Scanner;

	private GroupBox groupBox5;

	private CheckBox UseSysProxyCB;

	private TextBox ProxyText;

	private Label label14;

	private GroupBox groupBox3;

	private TextBox MimicBrowserTB;

	private Label label17;

	private ComboBox BlockDetectComboBox;

	private Label label15;

	private TextBox ParallelScansTextBox;

	private Label label16;

	private CheckBox showProgressDialogCB;

	private Label label13;

	private CheckBox freeScanCB;

	private Label label11;

	private TextBox requestPages;

	private Label label10;

	private Label label9;

	private TextBox stealthTime;

	private Label label8;

	private CheckBox summaryCheck;

	private Label label7;

	private Label label5;

	private TextBox timeOutTextBox;

	private Label label4;

	private TextBox warnScanTextBox;

	private Label label3;

	private TabPage Miscelaneous;

	private GroupBox groupBox1;

	private Button browseDorkFile;

	private TextBox dorkFileTextBox;

	private Label label1;

	private GroupBox groupBox4;

	private CheckBox showSplashCheckBox;

	private Label label12;

	private GroupBox groupBox2;

	private CheckBox UseSysBrowserCB;

	private Button browseBrowser;

	private TextBox preferredBrowserTextBox;

	private Label label2;

	private Label label18;

	private CheckBox RandomOrderCB;

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
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_11dc: Unknown result type (might be due to invalid IL or missing references)
		saveButton = new Button();
		abortButton = new Button();
		OptionsTab = new TabControl();
		Scanner = new TabPage();
		groupBox5 = new GroupBox();
		UseSysProxyCB = new CheckBox();
		ProxyText = new TextBox();
		label14 = new Label();
		groupBox3 = new GroupBox();
		RandomOrderCB = new CheckBox();
		label18 = new Label();
		MimicBrowserTB = new TextBox();
		label17 = new Label();
		BlockDetectComboBox = new ComboBox();
		label15 = new Label();
		ParallelScansTextBox = new TextBox();
		label16 = new Label();
		showProgressDialogCB = new CheckBox();
		label13 = new Label();
		freeScanCB = new CheckBox();
		label11 = new Label();
		requestPages = new TextBox();
		label10 = new Label();
		label9 = new Label();
		stealthTime = new TextBox();
		label8 = new Label();
		summaryCheck = new CheckBox();
		label7 = new Label();
		label5 = new Label();
		timeOutTextBox = new TextBox();
		label4 = new Label();
		warnScanTextBox = new TextBox();
		label3 = new Label();
		Miscelaneous = new TabPage();
		groupBox4 = new GroupBox();
		showSplashCheckBox = new CheckBox();
		label12 = new Label();
		groupBox2 = new GroupBox();
		UseSysBrowserCB = new CheckBox();
		browseBrowser = new Button();
		preferredBrowserTextBox = new TextBox();
		label2 = new Label();
		groupBox1 = new GroupBox();
		browseDorkFile = new Button();
		dorkFileTextBox = new TextBox();
		label1 = new Label();
		((Control)OptionsTab).SuspendLayout();
		((Control)Scanner).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)Miscelaneous).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)saveButton).set_Location(new Point(240, 415));
		((Control)saveButton).set_Name("saveButton");
		((Control)saveButton).set_Size(new Size(92, 26));
		((Control)saveButton).set_TabIndex(3);
		((Control)saveButton).set_Text("Save");
		((ButtonBase)saveButton).set_UseVisualStyleBackColor(true);
		((Control)saveButton).add_Click((EventHandler)saveButton_Click);
		((Control)abortButton).set_Location(new Point(345, 415));
		((Control)abortButton).set_Name("abortButton");
		((Control)abortButton).set_Size(new Size(92, 26));
		((Control)abortButton).set_TabIndex(1);
		((Control)abortButton).set_Text("Cancel");
		((ButtonBase)abortButton).set_UseVisualStyleBackColor(true);
		((Control)abortButton).add_Click((EventHandler)abortButton_Click);
		((Control)OptionsTab).get_Controls().Add((Control)(object)Scanner);
		((Control)OptionsTab).get_Controls().Add((Control)(object)Miscelaneous);
		((Control)OptionsTab).set_Location(new Point(3, 5));
		((Control)OptionsTab).set_Name("OptionsTab");
		OptionsTab.set_SelectedIndex(0);
		((Control)OptionsTab).set_Size(new Size(435, 396));
		((Control)OptionsTab).set_TabIndex(6);
		((Control)Scanner).get_Controls().Add((Control)(object)groupBox5);
		((Control)Scanner).get_Controls().Add((Control)(object)groupBox3);
		Scanner.set_Location(new Point(4, 22));
		((Control)Scanner).set_Name("Scanner");
		((Control)Scanner).set_Padding(new Padding(3));
		((Control)Scanner).set_Size(new Size(427, 370));
		Scanner.set_TabIndex(0);
		((Control)Scanner).set_Text("Scanner");
		Scanner.set_UseVisualStyleBackColor(true);
		((Control)groupBox5).get_Controls().Add((Control)(object)UseSysProxyCB);
		((Control)groupBox5).get_Controls().Add((Control)(object)ProxyText);
		((Control)groupBox5).get_Controls().Add((Control)(object)label14);
		((Control)groupBox5).set_Location(new Point(3, 290));
		((Control)groupBox5).set_Name("groupBox5");
		((Control)groupBox5).set_Size(new Size(418, 71));
		((Control)groupBox5).set_TabIndex(10);
		groupBox5.set_TabStop(false);
		((Control)groupBox5).set_Text("Proxification");
		((Control)UseSysProxyCB).set_AutoSize(true);
		((Control)UseSysProxyCB).set_Location(new Point(107, 43));
		((Control)UseSysProxyCB).set_Name("UseSysProxyCB");
		((Control)UseSysProxyCB).set_Size(new Size(200, 17));
		((Control)UseSysProxyCB).set_TabIndex(2);
		((Control)UseSysProxyCB).set_Text("Use system default (browser settings)");
		((ButtonBase)UseSysProxyCB).set_UseVisualStyleBackColor(true);
		((Control)ProxyText).set_Location(new Point(107, 17));
		((Control)ProxyText).set_Name("ProxyText");
		((Control)ProxyText).set_Size(new Size(293, 20));
		((Control)ProxyText).set_TabIndex(1);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(6, 20));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(73, 13));
		((Control)label14).set_TabIndex(0);
		((Control)label14).set_Text("Proxy address");
		((Control)groupBox3).get_Controls().Add((Control)(object)RandomOrderCB);
		((Control)groupBox3).get_Controls().Add((Control)(object)label18);
		((Control)groupBox3).get_Controls().Add((Control)(object)MimicBrowserTB);
		((Control)groupBox3).get_Controls().Add((Control)(object)label17);
		((Control)groupBox3).get_Controls().Add((Control)(object)BlockDetectComboBox);
		((Control)groupBox3).get_Controls().Add((Control)(object)label15);
		((Control)groupBox3).get_Controls().Add((Control)(object)ParallelScansTextBox);
		((Control)groupBox3).get_Controls().Add((Control)(object)label16);
		((Control)groupBox3).get_Controls().Add((Control)(object)showProgressDialogCB);
		((Control)groupBox3).get_Controls().Add((Control)(object)label13);
		((Control)groupBox3).get_Controls().Add((Control)(object)freeScanCB);
		((Control)groupBox3).get_Controls().Add((Control)(object)label11);
		((Control)groupBox3).get_Controls().Add((Control)(object)requestPages);
		((Control)groupBox3).get_Controls().Add((Control)(object)label10);
		((Control)groupBox3).get_Controls().Add((Control)(object)label9);
		((Control)groupBox3).get_Controls().Add((Control)(object)stealthTime);
		((Control)groupBox3).get_Controls().Add((Control)(object)label8);
		((Control)groupBox3).get_Controls().Add((Control)(object)summaryCheck);
		((Control)groupBox3).get_Controls().Add((Control)(object)label7);
		((Control)groupBox3).get_Controls().Add((Control)(object)label5);
		((Control)groupBox3).get_Controls().Add((Control)(object)timeOutTextBox);
		((Control)groupBox3).get_Controls().Add((Control)(object)label4);
		((Control)groupBox3).get_Controls().Add((Control)(object)warnScanTextBox);
		((Control)groupBox3).get_Controls().Add((Control)(object)label3);
		((Control)groupBox3).set_Location(new Point(3, 6));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(418, 282));
		((Control)groupBox3).set_TabIndex(8);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Scanning");
		((Control)RandomOrderCB).set_AutoSize(true);
		((Control)RandomOrderCB).set_Location(new Point(187, 178));
		((Control)RandomOrderCB).set_Name("RandomOrderCB");
		((Control)RandomOrderCB).set_Size(new Size(15, 14));
		((Control)RandomOrderCB).set_TabIndex(25);
		((ButtonBase)RandomOrderCB).set_UseVisualStyleBackColor(true);
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Location(new Point(6, 179));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(113, 13));
		((Control)label18).set_TabIndex(24);
		((Control)label18).set_Text("Randomize scan order");
		((Control)MimicBrowserTB).set_Location(new Point(187, 249));
		((Control)MimicBrowserTB).set_Name("MimicBrowserTB");
		((Control)MimicBrowserTB).set_Size(new Size(213, 20));
		((Control)MimicBrowserTB).set_TabIndex(23);
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Location(new Point(6, 252));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(131, 13));
		((Control)label17).set_TabIndex(22);
		((Control)label17).set_Text("Mimic Browser User Agent");
		((ListControl)BlockDetectComboBox).set_FormattingEnabled(true);
		BlockDetectComboBox.get_Items().AddRange(new object[3] { "Select on each block", "Select once, stop all ongoing scans", "Ignore blocks" });
		((Control)BlockDetectComboBox).set_Location(new Point(187, 222));
		((Control)BlockDetectComboBox).set_Name("BlockDetectComboBox");
		((Control)BlockDetectComboBox).set_Size(new Size(213, 21));
		((Control)BlockDetectComboBox).set_TabIndex(21);
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Location(new Point(6, 225));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(95, 13));
		((Control)label15).set_TabIndex(20);
		((Control)label15).set_Text("Blocking detection");
		((Control)ParallelScansTextBox).set_Location(new Point(187, 197));
		((Control)ParallelScansTextBox).set_Name("ParallelScansTextBox");
		((Control)ParallelScansTextBox).set_Size(new Size(47, 20));
		((Control)ParallelScansTextBox).set_TabIndex(19);
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Location(new Point(6, 200));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(105, 13));
		((Control)label16).set_TabIndex(18);
		((Control)label16).set_Text("Parallel scan threads");
		((Control)showProgressDialogCB).set_AutoSize(true);
		((Control)showProgressDialogCB).set_Location(new Point(187, 156));
		((Control)showProgressDialogCB).set_Name("showProgressDialogCB");
		((Control)showProgressDialogCB).set_Size(new Size(15, 14));
		((Control)showProgressDialogCB).set_TabIndex(17);
		((ButtonBase)showProgressDialogCB).set_UseVisualStyleBackColor(true);
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Location(new Point(6, 156));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(176, 13));
		((Control)label13).set_TabIndex(16);
		((Control)label13).set_Text("Show progress dialog on mass scan");
		((Control)freeScanCB).set_AutoSize(true);
		((Control)freeScanCB).set_Location(new Point(187, 135));
		((Control)freeScanCB).set_Name("freeScanCB");
		((Control)freeScanCB).set_Size(new Size(15, 14));
		((Control)freeScanCB).set_TabIndex(15);
		((ButtonBase)freeScanCB).set_UseVisualStyleBackColor(true);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(6, 135));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(177, 13));
		((Control)label11).set_TabIndex(14);
		((Control)label11).set_Text("Allow scanning without host entered");
		((Control)requestPages).set_Location(new Point(187, 109));
		((Control)requestPages).set_Name("requestPages");
		((Control)requestPages).set_Size(new Size(47, 20));
		((Control)requestPages).set_TabIndex(13);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(6, 112));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(118, 13));
		((Control)label10).set_TabIndex(12);
		((Control)label10).set_Text("Request pages at once");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(259, 88));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(32, 13));
		((Control)label9).set_TabIndex(11);
		((Control)label9).set_Text("msec");
		((Control)stealthTime).set_Location(new Point(187, 85));
		((Control)stealthTime).set_Name("stealthTime");
		((Control)stealthTime).set_Size(new Size(66, 20));
		((Control)stealthTime).set_TabIndex(10);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(6, 88));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(121, 13));
		((Control)label8).set_TabIndex(9);
		((Control)label8).set_Text("Sleep between requests");
		((Control)summaryCheck).set_AutoSize(true);
		((Control)summaryCheck).set_Location(new Point(187, 68));
		((Control)summaryCheck).set_Name("summaryCheck");
		((Control)summaryCheck).set_Size(new Size(15, 14));
		((Control)summaryCheck).set_TabIndex(8);
		((ButtonBase)summaryCheck).set_UseVisualStyleBackColor(true);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(6, 66));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(78, 13));
		((Control)label7).set_TabIndex(7);
		((Control)label7).set_Text("Show summary");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(259, 45));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(32, 13));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text("msec");
		((Control)timeOutTextBox).set_Location(new Point(187, 42));
		((Control)timeOutTextBox).set_Name("timeOutTextBox");
		((Control)timeOutTextBox).set_Size(new Size(66, 20));
		((Control)timeOutTextBox).set_TabIndex(3);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(6, 45));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(48, 13));
		((Control)label4).set_TabIndex(2);
		((Control)label4).set_Text("Time-out");
		((Control)warnScanTextBox).set_Location(new Point(187, 19));
		((Control)warnScanTextBox).set_Name("warnScanTextBox");
		((Control)warnScanTextBox).set_Size(new Size(47, 20));
		((Control)warnScanTextBox).set_TabIndex(1);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(6, 22));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(166, 13));
		((Control)label3).set_TabIndex(0);
		((Control)label3).set_Text("Warn if scanning more dorks than");
		((Control)Miscelaneous).get_Controls().Add((Control)(object)groupBox4);
		((Control)Miscelaneous).get_Controls().Add((Control)(object)groupBox2);
		((Control)Miscelaneous).get_Controls().Add((Control)(object)groupBox1);
		Miscelaneous.set_Location(new Point(4, 22));
		((Control)Miscelaneous).set_Name("Miscelaneous");
		((Control)Miscelaneous).set_Padding(new Padding(3));
		((Control)Miscelaneous).set_Size(new Size(427, 370));
		Miscelaneous.set_TabIndex(1);
		((Control)Miscelaneous).set_Text("Miscellaneous");
		Miscelaneous.set_UseVisualStyleBackColor(true);
		((Control)groupBox4).get_Controls().Add((Control)(object)showSplashCheckBox);
		((Control)groupBox4).get_Controls().Add((Control)(object)label12);
		((Control)groupBox4).set_Location(new Point(6, 138));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(415, 51));
		((Control)groupBox4).set_TabIndex(10);
		groupBox4.set_TabStop(false);
		((Control)groupBox4).set_Text("Appearance");
		((Control)showSplashCheckBox).set_AutoSize(true);
		((Control)showSplashCheckBox).set_Location(new Point(187, 23));
		((Control)showSplashCheckBox).set_Name("showSplashCheckBox");
		((Control)showSplashCheckBox).set_Size(new Size(15, 14));
		((Control)showSplashCheckBox).set_TabIndex(1);
		((ButtonBase)showSplashCheckBox).set_UseVisualStyleBackColor(true);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Location(new Point(6, 23));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(117, 13));
		((Control)label12).set_TabIndex(0);
		((Control)label12).set_Text("Show splash on startup");
		((Control)groupBox2).get_Controls().Add((Control)(object)UseSysBrowserCB);
		((Control)groupBox2).get_Controls().Add((Control)(object)browseBrowser);
		((Control)groupBox2).get_Controls().Add((Control)(object)preferredBrowserTextBox);
		((Control)groupBox2).get_Controls().Add((Control)(object)label2);
		((Control)groupBox2).set_Location(new Point(6, 62));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(415, 70));
		((Control)groupBox2).set_TabIndex(8);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Browsing");
		((Control)UseSysBrowserCB).set_AutoSize(true);
		((Control)UseSysBrowserCB).set_Location(new Point(107, 45));
		((Control)UseSysBrowserCB).set_Name("UseSysBrowserCB");
		((Control)UseSysBrowserCB).set_Size(new Size(115, 17));
		((Control)UseSysBrowserCB).set_TabIndex(6);
		((Control)UseSysBrowserCB).set_Text("Use system default");
		((ButtonBase)UseSysBrowserCB).set_UseVisualStyleBackColor(true);
		((Control)browseBrowser).set_Location(new Point(380, 18));
		((Control)browseBrowser).set_Name("browseBrowser");
		((Control)browseBrowser).set_Size(new Size(25, 20));
		((Control)browseBrowser).set_TabIndex(4);
		((Control)browseBrowser).set_Text("...");
		((ButtonBase)browseBrowser).set_UseVisualStyleBackColor(true);
		((Control)preferredBrowserTextBox).set_Location(new Point(107, 19));
		((Control)preferredBrowserTextBox).set_Name("preferredBrowserTextBox");
		((Control)preferredBrowserTextBox).set_Size(new Size(267, 20));
		((Control)preferredBrowserTextBox).set_TabIndex(1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(6, 22));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(91, 13));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("Preferred Browser");
		((Control)groupBox1).get_Controls().Add((Control)(object)browseDorkFile);
		((Control)groupBox1).get_Controls().Add((Control)(object)dorkFileTextBox);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).set_Location(new Point(6, 6));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(415, 50));
		((Control)groupBox1).set_TabIndex(7);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Dorks");
		((Control)browseDorkFile).set_Location(new Point(380, 17));
		((Control)browseDorkFile).set_Name("browseDorkFile");
		((Control)browseDorkFile).set_Size(new Size(25, 20));
		((Control)browseDorkFile).set_TabIndex(3);
		((Control)browseDorkFile).set_Text("...");
		((ButtonBase)browseDorkFile).set_UseVisualStyleBackColor(true);
		((Control)dorkFileTextBox).set_Location(new Point(70, 17));
		((Control)dorkFileTextBox).set_Name("dorkFileTextBox");
		((Control)dorkFileTextBox).set_Size(new Size(304, 20));
		((Control)dorkFileTextBox).set_TabIndex(2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(6, 20));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(49, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Dork File");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(441, 454));
		((Control)this).get_Controls().Add((Control)(object)abortButton);
		((Control)this).get_Controls().Add((Control)(object)saveButton);
		((Control)this).get_Controls().Add((Control)(object)OptionsTab);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Options");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Options");
		((Form)this).set_TopMost(true);
		((Control)OptionsTab).ResumeLayout(false);
		((Control)Scanner).ResumeLayout(false);
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)Miscelaneous).ResumeLayout(false);
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public Options()
	{
		InitializeComponent();
		((Control)dorkFileTextBox).set_Text(Settings.Default.DorkFile);
		((Control)preferredBrowserTextBox).set_Text(Settings.Default.PreferredBrowser);
		((Control)warnScanTextBox).set_Text(Settings.Default.WarnScan.ToString());
		((Control)timeOutTextBox).set_Text(Settings.Default.ScanTimeOut.ToString());
		summaryCheck.set_Checked(Settings.Default.ShowSummary);
		((Control)stealthTime).set_Text(Settings.Default.StealthTime.ToString());
		((Control)requestPages).set_Text(Settings.Default.RequestPages.ToString());
		freeScanCB.set_Checked(Settings.Default.AllowFreeScan);
		showSplashCheckBox.set_Checked(Settings.Default.ShowSplash);
		showProgressDialogCB.set_Checked(Settings.Default.ShowMassScanDialog);
		UseSysBrowserCB.set_Checked(Settings.Default.UseSystemBrowser);
		UseSysProxyCB.set_Checked(Settings.Default.UseSystemProxy);
		((Control)ProxyText).set_Text(Settings.Default.ProxyAddress);
		((Control)ParallelScansTextBox).set_Text(Settings.Default.MaxParallelScans.ToString());
		((Control)MimicBrowserTB).set_Text(Settings.Default.UserAgent);
		((ListControl)BlockDetectComboBox).set_SelectedIndex(Settings.Default.BlockDetectMode);
		RandomOrderCB.set_Checked(Settings.Default.RandomScanOrder);
		UpdateOptions();
		((Control)abortButton).Focus();
	}

	private void saveButton_Click(object sender, EventArgs e)
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		Settings.Default.DorkFile = ((Control)dorkFileTextBox).get_Text();
		Settings.Default.PreferredBrowser = ((Control)preferredBrowserTextBox).get_Text();
		Settings.Default.ShowSummary = summaryCheck.get_Checked();
		Settings.Default.AllowFreeScan = freeScanCB.get_Checked();
		Settings.Default.ShowSplash = showSplashCheckBox.get_Checked();
		Settings.Default.ShowMassScanDialog = showProgressDialogCB.get_Checked();
		Settings.Default.RandomScanOrder = RandomOrderCB.get_Checked();
		Settings.Default.UseSystemBrowser = UseSysBrowserCB.get_Checked();
		Settings.Default.UseSystemProxy = UseSysProxyCB.get_Checked();
		Settings.Default.ProxyAddress = ((Control)ProxyText).get_Text();
		Settings.Default.UserAgent = ((Control)MimicBrowserTB).get_Text();
		try
		{
			Settings.Default.WarnScan = Convert.ToInt32(((Control)warnScanTextBox).get_Text());
			Settings.Default.ScanTimeOut = Convert.ToInt32(((Control)timeOutTextBox).get_Text());
			Settings.Default.StealthTime = Convert.ToInt32(((Control)stealthTime).get_Text());
			Settings.Default.RequestPages = Convert.ToInt32(((Control)requestPages).get_Text());
			Settings.Default.MaxParallelScans = Convert.ToInt32(((Control)ParallelScansTextBox).get_Text());
			Settings.Default.BlockDetectMode = Convert.ToInt32(((ListControl)BlockDetectComboBox).get_SelectedIndex());
		}
		catch (Exception)
		{
			MessageBox.Show("Please enter a valid numeric value.");
			((ApplicationSettingsBase)Settings.Default).Reload();
			return;
		}
		((SettingsBase)Settings.Default).Save();
		System.Diagnostics.Trace.WriteLineIf(GoolagScan.Debug.Trace.TraceGoolag.TraceInfo, "Settings saved.");
		((Component)this).Dispose();
	}

	private void abortButton_Click(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void UpdateOptions()
	{
		((Control)preferredBrowserTextBox).set_Enabled(!UseSysBrowserCB.get_Checked());
		((Control)ProxyText).set_Enabled(!UseSysProxyCB.get_Checked());
	}

	private void browseDorkFile_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		string text = "";
		((FileDialog)val).set_AddExtension(true);
		((FileDialog)val).set_Filter("XML file (*.xml)|*.xml");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			text = ((FileDialog)val).get_FileName().Trim();
			if (text.Length > 0)
			{
				((Control)dorkFileTextBox).set_Text(text);
				((Control)this).Update();
			}
		}
	}

	private void browseBrowser_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		string text = "";
		((FileDialog)val).set_AddExtension(true);
		((FileDialog)val).set_Filter("Browser Executable (*.exe)|*.exe");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			text = ((FileDialog)val).get_FileName().Trim();
			if (text.Length > 0)
			{
				((Control)preferredBrowserTextBox).set_Text(text);
				((Control)this).Update();
			}
		}
	}

	private void UseSysBrowserCB_CheckedChanged(object sender, EventArgs e)
	{
		UpdateOptions();
	}

	private void UseSysProxyCB_CheckedChanged(object sender, EventArgs e)
	{
		UpdateOptions();
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GoolagScanner;

public class SummaryReport : Form
{
	private SummaryStat summaryStat;

	private IContainer components;

	private Button OkayButton;

	private GroupBox groupBox1;

	private Label label1;

	private Label labelScanDuration;

	private Label label4;

	private Label labelScanStart;

	private Label label2;

	private TextBox hostScannedBox;

	private ListView sumListView;

	private ImageList resultStates;

	private ColumnHeader columnHeader1;

	private ColumnHeader columnHeader2;

	private ColumnHeader columnHeader3;

	public SummaryReport(string hostScanned, SummaryStat summaryStat)
	{
		this.summaryStat = summaryStat;
		InitializeComponent();
		((Control)hostScannedBox).set_Text(hostScanned);
		if (summaryStat != null)
		{
			((Control)labelScanStart).set_Text(summaryStat.StartTime.ToLocalTime().ToString());
			TimeSpan timeSpan = summaryStat.EndTime - summaryStat.StartTime;
			((Control)labelScanDuration).set_Text($"{timeSpan.Hours:##00}:{timeSpan.Minutes:##00}:{timeSpan.Seconds:##00}");
			sumListView.get_Items().get_Item(0).get_SubItems()
				.Add("Successful dorks");
			sumListView.get_Items().get_Item(0).get_SubItems()
				.Add(summaryStat.ScansSuccess.ToString());
			sumListView.get_Items().get_Item(1).get_SubItems()
				.Add("Dorks without result");
			sumListView.get_Items().get_Item(1).get_SubItems()
				.Add(summaryStat.ScansNoResult.ToString());
			sumListView.get_Items().get_Item(2).get_SubItems()
				.Add("Failures while scanning");
			sumListView.get_Items().get_Item(2).get_SubItems()
				.Add(summaryStat.ScansFailed.ToString());
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Component)this).Dispose();
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
		//IL_0017: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		components = new Container();
		ListViewItem val = new ListViewItem("", 0);
		ListViewItem val2 = new ListViewItem("", 1);
		ListViewItem val3 = new ListViewItem("", 2);
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SummaryReport));
		OkayButton = new Button();
		groupBox1 = new GroupBox();
		labelScanDuration = new Label();
		label4 = new Label();
		labelScanStart = new Label();
		label2 = new Label();
		hostScannedBox = new TextBox();
		label1 = new Label();
		sumListView = new ListView();
		columnHeader1 = new ColumnHeader();
		columnHeader2 = new ColumnHeader();
		columnHeader3 = new ColumnHeader();
		resultStates = new ImageList(components);
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)OkayButton).set_Anchor((AnchorStyles)6);
		((Control)OkayButton).set_Location(new Point(179, 190));
		((Control)OkayButton).set_Name("OkayButton");
		((Control)OkayButton).set_Size(new Size(102, 24));
		((Control)OkayButton).set_TabIndex(0);
		((Control)OkayButton).set_Text("OK");
		((ButtonBase)OkayButton).set_UseVisualStyleBackColor(true);
		((Control)OkayButton).add_Click((EventHandler)button1_Click);
		((Control)groupBox1).get_Controls().Add((Control)(object)labelScanDuration);
		((Control)groupBox1).get_Controls().Add((Control)(object)label4);
		((Control)groupBox1).get_Controls().Add((Control)(object)labelScanStart);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)hostScannedBox);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).set_Location(new Point(6, 5));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(450, 89));
		((Control)groupBox1).set_TabIndex(1);
		groupBox1.set_TabStop(false);
		((Control)labelScanDuration).set_AutoSize(true);
		((Control)labelScanDuration).set_Location(new Point(96, 62));
		((Control)labelScanDuration).set_Name("labelScanDuration");
		((Control)labelScanDuration).set_Size(new Size(94, 13));
		((Control)labelScanDuration).set_TabIndex(5);
		((Control)labelScanDuration).set_Text("labelScanDuration");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(9, 62));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(73, 13));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("Scan duration");
		((Control)labelScanStart).set_AutoSize(true);
		((Control)labelScanStart).set_Location(new Point(96, 40));
		((Control)labelScanStart).set_Name("labelScanStart");
		((Control)labelScanStart).set_Size(new Size(76, 13));
		((Control)labelScanStart).set_TabIndex(3);
		((Control)labelScanStart).set_Text("labelScanStart");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(9, 40));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(67, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Scan started");
		((Control)hostScannedBox).set_Location(new Point(99, 13));
		((Control)hostScannedBox).set_Name("hostScannedBox");
		((TextBoxBase)hostScannedBox).set_ReadOnly(true);
		((Control)hostScannedBox).set_Size(new Size(342, 20));
		((Control)hostScannedBox).set_TabIndex(1);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(9, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(73, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Host scanned");
		sumListView.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader1, columnHeader2, columnHeader3 });
		sumListView.set_FullRowSelect(true);
		sumListView.set_GridLines(true);
		sumListView.get_Items().AddRange((ListViewItem[])(object)new ListViewItem[3] { val, val2, val3 });
		((Control)sumListView).set_Location(new Point(6, 103));
		((Control)sumListView).set_Name("sumListView");
		((Control)sumListView).set_Size(new Size(449, 72));
		sumListView.set_SmallImageList(resultStates);
		((Control)sumListView).set_TabIndex(2);
		sumListView.set_UseCompatibleStateImageBehavior(false);
		sumListView.set_View((View)1);
		columnHeader1.set_Text("");
		columnHeader1.set_Width(26);
		columnHeader2.set_Text("");
		columnHeader2.set_Width(325);
		columnHeader3.set_Text("");
		columnHeader3.set_Width(75);
		resultStates.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject("resultStates.ImageStream"));
		resultStates.set_TransparentColor(Color.Transparent);
		resultStates.get_Images().SetKeyName(0, "haken_blue.bmp");
		resultStates.get_Images().SetKeyName(1, "warn_yellow.bmp");
		resultStates.get_Images().SetKeyName(2, "red_cross_ball.bmp");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(459, 226));
		((Control)this).get_Controls().Add((Control)(object)sumListView);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)OkayButton);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("SummaryReport");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Summary");
		((Form)this).set_TopMost(true);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}

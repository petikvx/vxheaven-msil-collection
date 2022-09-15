using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GoolagScan.Properties;

namespace GoolagScan;

public class ScanningDialog : Form
{
	public delegate void DStop();

	private int DorkCount;

	private DStop StopScanner;

	private IContainer components;

	private PictureBox pictureBox1;

	private Button AbortButton;

	private ProgressBar DialogProgressBar;

	private Label PercentageOutput;

	public ScanningDialog(int dorkcount, DStop stopscan)
	{
		DorkCount = dorkcount;
		StopScanner = stopscan;
		InitializeComponent();
	}

	public void SetPercentage(int percentage)
	{
		if (percentage > 100)
		{
			percentage = 100;
		}
		DialogProgressBar.set_Value(percentage);
		((Control)PercentageOutput).set_Text(percentage + "%");
	}

	public void UpdateTitle(int currentDork)
	{
		((Control)this).set_Text("Scanning... (" + currentDork + "/" + DorkCount + ")");
		((Control)this).Update();
	}

	public void UpdateTitleWaiting()
	{
		((Control)this).set_Text("Waiting for pending scans...");
		((Control)this).Update();
	}

	private void AbortButton_Click(object sender, EventArgs e)
	{
		((Control)AbortButton).set_Enabled(false);
		StopScanner();
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
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ScanningDialog));
		pictureBox1 = new PictureBox();
		AbortButton = new Button();
		DialogProgressBar = new ProgressBar();
		PercentageOutput = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox1.set_Image((Image)(object)Resources.throbber);
		((Control)pictureBox1).set_Location(new Point(8, 3));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(45, 45));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)AbortButton).set_BackColor(SystemColors.Control);
		((Control)AbortButton).set_Location(new Point(311, 12));
		((Control)AbortButton).set_Name("AbortButton");
		((Control)AbortButton).set_Size(new Size(90, 26));
		((Control)AbortButton).set_TabIndex(1);
		((Control)AbortButton).set_Text("Abort");
		((ButtonBase)AbortButton).set_UseVisualStyleBackColor(false);
		((Control)AbortButton).add_Click((EventHandler)AbortButton_Click);
		((Control)DialogProgressBar).set_Location(new Point(60, 18));
		((Control)DialogProgressBar).set_Name("DialogProgressBar");
		((Control)DialogProgressBar).set_Size(new Size(238, 15));
		DialogProgressBar.set_Style((ProgressBarStyle)1);
		((Control)DialogProgressBar).set_TabIndex(2);
		((Control)PercentageOutput).set_AutoSize(true);
		((Control)PercentageOutput).set_Location(new Point(168, 36));
		((Control)PercentageOutput).set_Name("PercentageOutput");
		((Control)PercentageOutput).set_Size(new Size(21, 13));
		((Control)PercentageOutput).set_TabIndex(3);
		((Control)PercentageOutput).set_Text("0%");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(411, 52));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)PercentageOutput);
		((Control)this).get_Controls().Add((Control)(object)DialogProgressBar);
		((Control)this).get_Controls().Add((Control)(object)AbortButton);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ScanningDialog");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Scanning...");
		((Form)this).set_TopMost(true);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}

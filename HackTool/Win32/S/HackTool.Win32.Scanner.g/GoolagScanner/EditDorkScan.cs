using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GoolagScanner;

public class EditDorkScan : Form
{
	public delegate void singleScan(SSelectedDork s);

	private IContainer components;

	private Label label1;

	private Label label2;

	private TextBox QueryTextBox;

	private Button Revert;

	private Button CancelEditButtton;

	private Button Scanbutton;

	private Label DorkNameLabel;

	private SSelectedDork dorktoedit;

	private string originalQuery;

	public singleScan _singleScan;

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
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(EditDorkScan));
		label1 = new Label();
		label2 = new Label();
		QueryTextBox = new TextBox();
		Revert = new Button();
		CancelEditButtton = new Button();
		Scanbutton = new Button();
		DorkNameLabel = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(30, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Dork");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 42));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Query");
		((Control)QueryTextBox).set_Location(new Point(62, 39));
		((Control)QueryTextBox).set_Name("QueryTextBox");
		((Control)QueryTextBox).set_Size(new Size(337, 20));
		((Control)QueryTextBox).set_TabIndex(2);
		((Control)Revert).set_Location(new Point(348, 65));
		((Control)Revert).set_Name("Revert");
		((Control)Revert).set_Size(new Size(51, 21));
		((Control)Revert).set_TabIndex(3);
		((Control)Revert).set_Text("Revert");
		((ButtonBase)Revert).set_UseVisualStyleBackColor(true);
		((Control)Revert).add_Click((EventHandler)Revert_Click);
		((Control)CancelEditButtton).set_Location(new Point(323, 93));
		((Control)CancelEditButtton).set_Name("CancelEditButtton");
		((Control)CancelEditButtton).set_Size(new Size(77, 26));
		((Control)CancelEditButtton).set_TabIndex(4);
		((Control)CancelEditButtton).set_Text("Cancel");
		((ButtonBase)CancelEditButtton).set_UseVisualStyleBackColor(true);
		((Control)CancelEditButtton).add_Click((EventHandler)CancelButton_Click);
		((Control)Scanbutton).set_Location(new Point(240, 93));
		((Control)Scanbutton).set_Name("Scanbutton");
		((Control)Scanbutton).set_Size(new Size(77, 26));
		((Control)Scanbutton).set_TabIndex(5);
		((Control)Scanbutton).set_Text("Scan");
		((ButtonBase)Scanbutton).set_UseVisualStyleBackColor(true);
		((Control)Scanbutton).add_Click((EventHandler)Scanbutton_Click);
		((Control)DorkNameLabel).set_AutoSize(true);
		((Control)DorkNameLabel).set_Location(new Point(59, 12));
		((Control)DorkNameLabel).set_Name("DorkNameLabel");
		((Control)DorkNameLabel).set_Size(new Size(35, 13));
		((Control)DorkNameLabel).set_TabIndex(6);
		((Control)DorkNameLabel).set_Text("label3");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(413, 129));
		((Control)this).get_Controls().Add((Control)(object)DorkNameLabel);
		((Control)this).get_Controls().Add((Control)(object)Scanbutton);
		((Control)this).get_Controls().Add((Control)(object)CancelEditButtton);
		((Control)this).get_Controls().Add((Control)(object)Revert);
		((Control)this).get_Controls().Add((Control)(object)QueryTextBox);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("EditDorkScan");
		((Control)this).set_Text("Edit Dork");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public EditDorkScan(SSelectedDork DorkToEdit, singleScan SingleScanMethod)
	{
		_singleScan = SingleScanMethod;
		dorktoedit = DorkToEdit;
		originalQuery = DorkToEdit.Dork.Query;
		InitializeComponent();
		SetTextElements();
	}

	private void SetTextElements()
	{
		((Control)DorkNameLabel).set_Text(dorktoedit.Dork.Name);
		((Control)QueryTextBox).set_Text(originalQuery);
	}

	private void Revert_Click(object sender, EventArgs e)
	{
		((Control)QueryTextBox).set_Text(originalQuery);
		((Control)this).Update();
	}

	private void CancelButton_Click(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Scanbutton_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(((Control)QueryTextBox).get_Text()))
		{
			dorktoedit.Dork.Query = ((Control)QueryTextBox).get_Text();
			_singleScan(dorktoedit);
		}
	}
}

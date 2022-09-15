using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Account_Hacker_ID;

public class frmAccountHackerID : Form
{
	private IContainer components;

	private TextBox txtID;

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
		txtID = new TextBox();
		((Control)this).SuspendLayout();
		((Control)txtID).set_Location(new Point(12, 12));
		((Control)txtID).set_Name("txtID");
		((TextBoxBase)txtID).set_ReadOnly(true);
		((Control)txtID).set_Size(new Size(209, 20));
		((Control)txtID).set_TabIndex(0);
		txtID.set_TextAlign((HorizontalAlignment)2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(232, 45));
		((Control)this).get_Controls().Add((Control)(object)txtID);
		((Control)this).set_MaximumSize(new Size(240, 72));
		((Control)this).set_MinimumSize(new Size(240, 72));
		((Control)this).set_Name("frmAccountHackerID");
		((Control)this).set_Text("Account Hacker ID");
		((Form)this).add_Load((EventHandler)frmAccountHackerID_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmAccountHackerID()
	{
		InitializeComponent();
	}

	[DllImport("kernel32.dll")]
	private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, uint VolumeNameSize, ref uint VolumeSerialNumber, ref uint MaximumComponentLength, ref uint FileSystemFlags, StringBuilder FileSystemNameBuffer, uint FileSystemNameSize);

	private void frmAccountHackerID_Load(object sender, EventArgs e)
	{
		string text = "C";
		uint VolumeSerialNumber = 0u;
		uint MaximumComponentLength = 0u;
		StringBuilder stringBuilder = new StringBuilder(256);
		uint FileSystemFlags = 0u;
		StringBuilder stringBuilder2 = new StringBuilder(256);
		text += ":\\";
		GetVolumeInformation(text, stringBuilder, (uint)stringBuilder.Capacity, ref VolumeSerialNumber, ref MaximumComponentLength, ref FileSystemFlags, stringBuilder2, (uint)stringBuilder2.Capacity);
		((Control)txtID).set_Text(Convert.ToString(VolumeSerialNumber));
	}
}

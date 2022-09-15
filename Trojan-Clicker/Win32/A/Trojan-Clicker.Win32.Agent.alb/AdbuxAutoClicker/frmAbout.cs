using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AdbuxAutoClicker;

[DesignerGenerated]
public class frmAbout : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked));
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked));
			}
		}
	}

	[DebuggerNonUserCode]
	public frmAbout()
	{
		((Form)this).add_Load((EventHandler)frmAbout_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		LinkLabel1 = new LinkLabel();
		((Control)this).SuspendLayout();
		((Control)Label1).set_Anchor((AnchorStyles)0);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label = Label1;
		Point location = new Point(-1, 1);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(214, 22);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Adbux Auto Clicker");
		Label1.set_TextAlign((ContentAlignment)2);
		((Control)Label2).set_Anchor((AnchorStyles)0);
		Label label3 = Label2;
		location = new Point(0, 23);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(216, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Version 1.2.0");
		Label2.set_TextAlign((ContentAlignment)2);
		((Control)Label3).set_Anchor((AnchorStyles)0);
		Label label5 = Label3;
		location = new Point(-3, 36);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(219, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Copyright 2007 ML Software");
		Label3.set_TextAlign((ContentAlignment)2);
		((Control)Label4).set_Anchor((AnchorStyles)0);
		Label label7 = Label4;
		location = new Point(0, 49);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(216, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("All Rights Reserved.");
		Label4.set_TextAlign((ContentAlignment)2);
		((Control)LinkLabel1).set_Anchor((AnchorStyles)0);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(-3, 62);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(219, 18);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(4);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("www.mlwares.co.nr");
		((Label)LinkLabel1).set_TextAlign((ContentAlignment)2);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(214, 79);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("frmAbout");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("About");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.mlwares.co.nr/");
	}

	private void frmAbout_Load(object sender, EventArgs e)
	{
		Label2.set_Text("Version " + Strings.Left(Application.get_ProductVersion(), checked(Strings.Len(Application.get_ProductVersion()) - 2)));
	}
}

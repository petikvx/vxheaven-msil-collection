using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

[DesignerGenerated]
public class ErrorScreen : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	public string TheErrorText;

	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextBox1 = value;
		}
	}

	[DebuggerNonUserCode]
	public ErrorScreen()
	{
		((Form)this).add_Load((EventHandler)ErrorScreen_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		RichTextBox1 = new RichTextBox();
		((Control)this).SuspendLayout();
		((Control)RichTextBox1).set_Dock((DockStyle)5);
		RichTextBox richTextBox = RichTextBox1;
		Point location = new Point(0, 0);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		Size size = new Size(387, 275);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(0);
		RichTextBox1.set_Text("");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(387, 275);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).set_Name("ErrorScreen");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("Error Log:");
		((Control)this).ResumeLayout(false);
	}

	private void ErrorScreen_Load(object sender, EventArgs e)
	{
		RichTextBox1.set_Text(TheErrorText);
		TheErrorText = null;
	}
}

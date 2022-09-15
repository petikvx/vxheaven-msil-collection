using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace LiGHTX;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.remove_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted));
				_WebBrowser1.remove_CanGoBackChanged((EventHandler)WebBrowser1_CanGoBackChanged);
			}
			_WebBrowser1 = value;
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted));
				_WebBrowser1.add_CanGoBackChanged((EventHandler)WebBrowser1_CanGoBackChanged);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click((EventHandler)Button1_Click);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click((EventHandler)Button1_Click);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click((EventHandler)Button2_Click);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click((EventHandler)Button2_Click);
			}
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click((EventHandler)Button3_Click);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click((EventHandler)Button3_Click);
			}
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click((EventHandler)Button4_Click);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click((EventHandler)Button4_Click);
			}
		}
	}

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button5 != null)
			{
				((Control)_Button5).remove_Click((EventHandler)Button5_Click);
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).add_Click((EventHandler)Button5_Click);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		WebBrowser1 = new WebBrowser();
		TextBox1 = new TextBox();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button4 = new Button();
		Button5 = new Button();
		((Control)this).SuspendLayout();
		((Control)WebBrowser1).set_Dock((DockStyle)5);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(0, 0);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(569, 407);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(0);
		TextBox textBox = TextBox1;
		location = new Point(12, 12);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		minimumSize = new Size(156, 20);
		((Control)textBox2).set_Size(minimumSize);
		((Control)TextBox1).set_TabIndex(1);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientActiveCaption);
		Button button = Button1;
		location = new Point(174, 8);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		minimumSize = new Size(70, 23);
		((Control)button2).set_Size(minimumSize);
		((Control)Button1).set_TabIndex(2);
		((ButtonBase)Button1).set_Text("Go");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(SystemColors.GradientActiveCaption);
		Button button3 = Button2;
		location = new Point(250, 8);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		minimumSize = new Size(70, 23);
		((Control)button4).set_Size(minimumSize);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Back");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button3).set_BackColor(SystemColors.GradientActiveCaption);
		Button button5 = Button3;
		location = new Point(326, 8);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		minimumSize = new Size(70, 23);
		((Control)button6).set_Size(minimumSize);
		((Control)Button3).set_TabIndex(4);
		((ButtonBase)Button3).set_Text("Forward");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button4).set_BackColor(SystemColors.GradientActiveCaption);
		Button button7 = Button4;
		location = new Point(402, 8);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		minimumSize = new Size(70, 23);
		((Control)button8).set_Size(minimumSize);
		((Control)Button4).set_TabIndex(5);
		((ButtonBase)Button4).set_Text("Stop");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button5).set_BackColor(SystemColors.GradientActiveCaption);
		Button button9 = Button5;
		location = new Point(478, 8);
		((Control)button9).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button10 = Button5;
		minimumSize = new Size(70, 23);
		((Control)button10).set_Size(minimumSize);
		((Control)Button5).set_TabIndex(6);
		((ButtonBase)Button5).set_Text("Reload");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(569, 407);
		((Form)this).set_ClientSize(minimumSize);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("LiGHT X v1.0");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		WebBrowser1.Navigate(TextBox1.get_Text());
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		WebBrowser1.GoBack();
	}

	private void WebBrowser1_CanGoBackChanged(object sender, EventArgs e)
	{
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		WebBrowser1.GoForward();
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		WebBrowser1.Stop();
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		WebBrowser1.Refresh();
	}
}

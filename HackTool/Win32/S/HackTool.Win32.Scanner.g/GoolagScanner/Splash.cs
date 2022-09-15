using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GoolagScanner;

public class Splash : Form
{
	private Thread OpacThread;

	private double fadeinOffset;

	private double fadeoutOffset;

	private int waittime;

	private IContainer components;

	public Splash(int width, int height, Bitmap bitmap, double FadeInOffset, double FadeOutOffset, int WaitTime)
	{
		Control.set_CheckForIllegalCrossThreadCalls(false);
		InitializeComponent();
		fadeinOffset = FadeInOffset;
		fadeoutOffset = FadeOutOffset;
		waittime = WaitTime;
		((Control)this).set_BackgroundImage((Image)(object)bitmap);
		((Form)this).set_ClientSize(new Size(width, height));
		((Form)this).set_Opacity(0.0);
		((Control)this).Update();
		OpacThread = new Thread(OpacAnim);
		OpacThread.Start();
	}

	private void OpacAnim()
	{
		while (((Form)this).get_Opacity() < 1.0)
		{
			((Form)this).set_Opacity(((Form)this).get_Opacity() + fadeinOffset);
			Application.DoEvents();
			Thread.Sleep(60);
		}
		Thread.Sleep(waittime);
		while (((Form)this).get_Opacity() > 0.0)
		{
			((Form)this).set_Opacity(((Form)this).get_Opacity() - fadeoutOffset);
			Application.DoEvents();
			Thread.Sleep(60);
		}
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Window);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(18, 21));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Splash");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("SplashX");
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(Color.Transparent);
		((Control)this).ResumeLayout(false);
	}
}

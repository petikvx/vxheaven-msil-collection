using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Ycomment;

public class Form1 : Form
{
	private class Class0
	{
		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public string string_4;

		public string string_5;

		public string string_6;
	}

	private IContainer icontainer_0 = null;

	private WebBrowser webBrowser1;

	private Button btnVerification;

	private Label lblVerification;

	private TextBox textVerification;

	private Panel panel1;

	private Timer timer_0;

	public int int_0;

	private string string_0 = "";

	private string string_1 = "";

	private bool bool_0 = false;

	private bool bool_1 = false;

	private bool bool_2 = false;

	private bool bool_3 = false;

	private bool bool_4 = false;

	private bool bool_5 = false;

	private int int_1 = 20;

	private bool bool_6 = false;

	private Class0 class0_0 = new Class0();

	private string string_2 = "";

	private Random random_0 = new Random(DateTime.Now.Second);

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
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
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		icontainer_0 = new Container();
		webBrowser1 = new WebBrowser();
		btnVerification = new Button();
		lblVerification = new Label();
		textVerification = new TextBox();
		panel1 = new Panel();
		timer_0 = new Timer(icontainer_0);
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Dock((DockStyle)5);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(464, 315));
		((Control)webBrowser1).set_TabIndex(0);
		((Control)btnVerification).set_Dock((DockStyle)2);
		((Control)btnVerification).set_Location(new Point(0, 315));
		((Control)btnVerification).set_Name("btnVerification");
		((Control)btnVerification).set_Size(new Size(464, 19));
		((Control)btnVerification).set_TabIndex(89);
		((Control)btnVerification).set_Text("Go");
		((ButtonBase)btnVerification).set_UseVisualStyleBackColor(true);
		((Control)btnVerification).set_Visible(false);
		((Control)lblVerification).set_AutoSize(true);
		((Control)lblVerification).set_Dock((DockStyle)2);
		((Control)lblVerification).set_Font(new Font("宋体", 10.5f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)lblVerification).set_ForeColor(Color.Red);
		((Control)lblVerification).set_Location(new Point(0, 334));
		((Control)lblVerification).set_Name("lblVerification");
		((Control)lblVerification).set_Size(new Size(367, 14));
		((Control)lblVerification).set_TabIndex(88);
		((Control)lblVerification).set_Text("Enter verification code and click button [go]");
		((Control)lblVerification).set_Visible(false);
		((Control)textVerification).set_Dock((DockStyle)2);
		((Control)textVerification).set_Location(new Point(0, 348));
		((Control)textVerification).set_Name("textVerification");
		((Control)textVerification).set_Size(new Size(464, 21));
		((Control)textVerification).set_TabIndex(87);
		((Control)textVerification).set_Visible(false);
		((Control)panel1).get_Controls().Add((Control)(object)webBrowser1);
		((Control)panel1).set_Dock((DockStyle)5);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(464, 315));
		((Control)panel1).set_TabIndex(90);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(464, 369));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)btnVerification);
		((Control)this).get_Controls().Add((Control)(object)lblVerification);
		((Control)this).get_Controls().Add((Control)(object)textVerification);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("YoutubeComment");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_0()
	{
		try
		{
			if (webBrowser1.get_DocumentText().IndexOf("Can't read?") > 0)
			{
				bool_3 = true;
				webBrowser1.get_Document().get_Forms().get_Item("commentCaptchaForm")
					.get_Document()
					.GetElementById("verificationImage")
					.ScrollIntoView(true);
				((Control)lblVerification).set_Visible(true);
				((Control)btnVerification).set_Visible(true);
				((Control)textVerification).set_Visible(true);
			}
		}
		catch (Exception)
		{
		}
	}

	private void method_1()
	{
		try
		{
			webBrowser1.get_Document().get_Forms().get_Item("commentCaptchaForm")
				.get_Document()
				.GetElementById("response")
				.SetAttribute("value", ((Control)textVerification).get_Text());
			webBrowser1.get_Document().get_Forms().get_Item("commentCaptchaForm")
				.get_Document()
				.GetElementById("unlock_captcha")
				.InvokeMember("click");
		}
		catch (Exception)
		{
		}
	}

	[DllImport("User32.dll")]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

	private void method_2()
	{
		try
		{
			IntPtr zero = IntPtr.Zero;
			zero = FindWindow(null, "Windows Internet Explorer");
			int msg = 16;
			if (zero.ToInt32() != 0)
			{
				SendMessage(zero, msg, 0, (IntPtr)0);
				bool_5 = true;
				return;
			}
			zero = FindWindow(null, "Microsoft Internet Explorer");
			if (zero.ToInt32() != 0)
			{
				SendMessage(zero, msg, 0, (IntPtr)0);
				bool_5 = true;
			}
		}
		catch (Exception)
		{
		}
	}

	public Form1()
	{
		InitializeComponent();
	}

	public Form1(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, string s11)
	{
		class0_0.string_0 = s1;
		class0_0.string_3 = s2;
		class0_0.string_6 = s3;
		class0_0.string_1 = s4;
		class0_0.string_4 = s5;
		class0_0.string_2 = s6;
		class0_0.string_5 = s7;
		bool_0 = bool.Parse(s8);
		bool_1 = bool.Parse(s9);
		string_0 = s10;
		string_1 = s11;
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		timer_0.set_Enabled(true);
	}

	private bool method_3(Class0 class0_1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected O, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			bool_6 = false;
			string text = (string_2 = "http://www.youtube.com");
			((Control)this).Invoke((Delegate)new MethodInvoker(method_5));
			DateTime now = DateTime.Now;
			while (!bool_6)
			{
				Application.DoEvents();
				if ((DateTime.Now - now).TotalSeconds > 10.0)
				{
					bool_6 = true;
				}
				Thread.Sleep(100);
			}
			bool_6 = false;
			((Control)this).Invoke((Delegate)new MethodInvoker(method_6));
			now = DateTime.Now;
			while (!bool_6)
			{
				Application.DoEvents();
				if ((DateTime.Now - now).TotalSeconds > 10.0)
				{
					bool_6 = true;
				}
				Thread.Sleep(100);
			}
			text = (string_2 = "http://www.youtube.com");
			bool_6 = false;
			((Control)this).Invoke((Delegate)new MethodInvoker(method_5));
			now = DateTime.Now;
			while (!bool_6)
			{
				Application.DoEvents();
				if ((DateTime.Now - now).TotalSeconds > 10.0)
				{
					bool_6 = true;
				}
				Thread.Sleep(100);
			}
			class0_0.string_0 = class0_1.string_0;
			class0_0.string_3 = class0_1.string_3;
			class0_0.string_6 = class0_1.string_6;
			class0_0.string_1 = class0_1.string_1;
			class0_0.string_4 = class0_1.string_4;
			class0_0.string_2 = class0_1.string_2;
			class0_0.string_5 = class0_1.string_5;
			bool_6 = false;
			((Control)this).Invoke((Delegate)new MethodInvoker(method_7));
			now = DateTime.Now;
			while (!bool_6)
			{
				Application.DoEvents();
				if ((DateTime.Now - now).TotalSeconds > 10.0)
				{
					bool_6 = true;
				}
				Thread.Sleep(100);
			}
			if (!bool_0)
			{
				string_2 = "http://www.youtube.com/index";
				bool_6 = false;
				((Control)this).Invoke((Delegate)new MethodInvoker(method_5));
				now = DateTime.Now;
				while (!bool_6)
				{
					Application.DoEvents();
					if ((DateTime.Now - now).TotalSeconds > 10.0)
					{
						bool_6 = true;
					}
					Thread.Sleep(100);
				}
				string_2 = class0_1.string_2;
				bool_6 = false;
				((Control)this).Invoke((Delegate)new MethodInvoker(method_5));
				now = DateTime.Now;
				while (!bool_6)
				{
					Application.DoEvents();
					if ((DateTime.Now - now).TotalSeconds > 10.0)
					{
						bool_6 = true;
					}
					Thread.Sleep(100);
				}
				bool_3 = false;
				bool_4 = false;
				((Control)this).Invoke((Delegate)new MethodInvoker(method_0));
				if (bool_3)
				{
					DateTime now2 = DateTime.Now;
					while (!bool_4)
					{
						Application.DoEvents();
						Thread.Sleep(100);
						if ((DateTime.Now - now2).Seconds > int_1)
						{
							return false;
						}
					}
					if (bool_1)
					{
						bool_6 = false;
						((Control)this).Invoke((Delegate)new MethodInvoker(method_4));
						now = DateTime.Now;
						while (!bool_6)
						{
							Application.DoEvents();
							if ((DateTime.Now - now).TotalSeconds > 10.0)
							{
								bool_6 = true;
							}
							Thread.Sleep(100);
						}
					}
					bool_6 = false;
					((Control)this).Invoke((Delegate)new MethodInvoker(method_1));
					now2 = DateTime.Now;
					while (!bool_6)
					{
						Application.DoEvents();
						Thread.Sleep(100);
						if ((DateTime.Now - now2).Seconds > int_1)
						{
							return false;
						}
					}
				}
				if (bool_1)
				{
					bool_6 = false;
					((Control)this).Invoke((Delegate)new MethodInvoker(method_4));
					now = DateTime.Now;
					while (!bool_6)
					{
						Application.DoEvents();
						if ((DateTime.Now - now).TotalSeconds > 10.0)
						{
							bool_6 = true;
						}
						Thread.Sleep(100);
					}
				}
				bool_6 = false;
				((Control)this).Invoke((Delegate)new MethodInvoker(method_8));
				now = DateTime.Now;
				while (!bool_6)
				{
					Application.DoEvents();
					if ((DateTime.Now - now).TotalSeconds > 10.0)
					{
						bool_6 = true;
					}
					Thread.Sleep(100);
				}
				Thread.Sleep(3000);
				bool_5 = true;
			}
			else
			{
				string_2 = class0_1.string_2.Replace("watch", "video_response_upload");
				bool_6 = false;
				((Control)this).Invoke((Delegate)new MethodInvoker(method_5));
				now = DateTime.Now;
				while (!bool_6)
				{
					Application.DoEvents();
					if ((DateTime.Now - now).TotalSeconds > 10.0)
					{
						bool_6 = true;
					}
					Thread.Sleep(100);
				}
				if (bool_1)
				{
					bool_6 = false;
					((Control)this).Invoke((Delegate)new MethodInvoker(method_4));
					now = DateTime.Now;
					while (!bool_6)
					{
						Application.DoEvents();
						if ((DateTime.Now - now).TotalSeconds > 10.0)
						{
							bool_6 = true;
						}
						Thread.Sleep(100);
					}
				}
				bool_6 = false;
				((Control)this).Invoke((Delegate)new MethodInvoker(method_8));
				now = DateTime.Now;
				while (!bool_6)
				{
					Application.DoEvents();
					if ((DateTime.Now - now).TotalSeconds > 10.0)
					{
						bool_6 = true;
					}
					Thread.Sleep(100);
				}
				if (bool_2)
				{
					bool_5 = true;
				}
				else
				{
					bool_5 = false;
				}
				Thread.Sleep(5000);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
		DateTime now3 = DateTime.Now;
		while (true)
		{
			Application.DoEvents();
			if ((DateTime.Now - now3).TotalSeconds > 3.0)
			{
				break;
			}
			Thread.Sleep(100);
		}
		int_0 = 1;
		((Form)this).Close();
		return true;
	}

	private void method_4()
	{
		try
		{
			int num = random_0.Next(int.Parse(string_0), int.Parse(string_1) + 1);
			for (int i = 0; i < webBrowser1.get_Document().get_All().get_Count(); i++)
			{
				string text = "";
				text = webBrowser1.get_Document().get_All().get_Item(i)
					.GetAttribute("id");
				if (text.IndexOf("star__" + num.ToString().Trim()) >= 0)
				{
					webBrowser1.get_Document().get_All().get_Item(i)
						.Focus();
					webBrowser1.get_Document().get_All().get_Item(i)
						.InvokeMember("click");
					DateTime dateTime = default(DateTime);
					do
					{
						Application.DoEvents();
					}
					while ((DateTime.Now - dateTime).Seconds <= 2);
					break;
				}
			}
		}
		catch (Exception)
		{
		}
		bool_6 = true;
	}

	private void method_5()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		try
		{
			webBrowser1.Navigate(string_2);
			do
			{
				Application.DoEvents();
			}
			while ((int)webBrowser1.get_ReadyState() != 4);
			bool_6 = true;
		}
		catch
		{
		}
	}

	private void method_6()
	{
		try
		{
			webBrowser1.get_Document().get_Forms().get_Item("logoutForm")
				.InvokeMember("Submit");
		}
		catch (Exception)
		{
		}
	}

	private void method_7()
	{
		try
		{
			webBrowser1.get_Document().get_Forms().get_Item("loginForm")
				.get_Document()
				.GetElementById("username")
				.SetAttribute("value", class0_0.string_5);
			webBrowser1.get_Document().get_Forms().get_Item("loginForm")
				.get_Document()
				.GetElementById("password")
				.SetAttribute("value", class0_0.string_6);
			webBrowser1.get_Document().get_Forms().get_Item("loginForm")
				.InvokeMember("Submit");
		}
		catch (Exception)
		{
		}
	}

	private void method_8()
	{
		if (bool_0)
		{
			try
			{
				if (webBrowser1.get_Document().get_Body().get_InnerHtml()
					.IndexOf("You have no videos uploaded.") <= 0)
				{
					if (webBrowser1.get_Document().get_Body().get_InnerHtml()
						.IndexOf("Respond with a video I've already uploaded") <= 0)
					{
						bool_2 = false;
						bool_6 = true;
					}
					else
					{
						webBrowser1.get_Document().get_All().get_Item("respond")
							.InvokeMember("click");
						bool_2 = true;
						bool_6 = true;
					}
				}
				else
				{
					bool_2 = false;
					bool_6 = true;
				}
				return;
			}
			catch
			{
				bool_2 = false;
				bool_6 = true;
				return;
			}
		}
		try
		{
			webBrowser1.get_Document().get_Forms().get_Item(3)
				.get_Document()
				.GetElementById("comment")
				.SetAttribute("value", class0_0.string_4);
			webBrowser1.get_Document().get_Forms().get_Item(3)
				.get_Document()
				.GetElementById("add_comment_button")
				.InvokeMember("click");
		}
		catch (Exception)
		{
		}
		bool_6 = true;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.set_Enabled(false);
		method_3(class0_0);
	}
}

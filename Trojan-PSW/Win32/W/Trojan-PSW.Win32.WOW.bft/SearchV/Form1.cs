using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Sunisoft.IrisSkin;

namespace SearchV;

public class Form1 : Form
{
	private Random random_0 = new Random();

	private bool bool_0;

	private byte[] byte_0;

	private string string_0;

	private bool bool_1;

	private bool bool_2;

	private string string_1 = "";

	private int int_0 = 2;

	private GClass0 gclass0_0 = new GClass0();

	private WebClient webClient_0;

	private IContainer icontainer_0;

	private WebBrowser webBrowser1;

	private Label label1;

	private Button button9;

	public Label label20;

	private Button button7;

	private Button button3;

	public CheckedListBox checkedListBox1;

	private Button button2;

	private Label label8;

	private TextBox targetURL;

	private Label label2;

	private Button button1;

	private Button button4;

	private Label label3;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Button button8;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label4;

	private Label label5;

	private CheckBox checkBox2;

	private CheckBox checkBox1;

	private CheckBox checkBox3;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private Label label6;

	private ComboBox comboBox1;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Invalid comparison between Unknown and I4
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Invalid comparison between Unknown and I4
		//IL_1720: Unknown result type (might be due to invalid IL or missing references)
		if (radioButton1.get_Checked())
		{
			int_0 = 1;
		}
		((Control)radioButton1).set_Enabled(false);
		((Control)radioButton2).set_Enabled(false);
		string[] array = ((Control)textBox1).get_Text().Replace("\r\n", "#").Split(new char[1] { '#' });
		if (!checkBox1.get_Checked() && !checkBox2.get_Checked() && !checkBox3.get_Checked())
		{
			MessageBox.Show("Choose a search engine");
			return;
		}
		if (checkBox1.get_Checked())
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < 1; j++)
				{
					webBrowser1.Navigate("http://www.google.com/en");
					((Control)label2).set_Text("Search...");
					bool_0 = false;
					DateTime now = DateTime.Now;
					while ((int)webBrowser1.get_ReadyState() != 4)
					{
						((Control)label2).set_Text(((Control)label2).get_Text() + ".");
						if (((Control)label2).get_Text().Length > 60)
						{
							((Control)label2).set_Text("Search...");
						}
						if (bool_0)
						{
							goto end_IL_00a2;
						}
						Application.DoEvents();
						_ = (DateTime.Now - now).TotalSeconds;
					}
					int num = 1;
					HtmlDocument document = webBrowser1.get_Document();
					string text = "";
					text = ((j == 0) ? "\"powered by vbulletin\" \"send a private message\"" : "Powered by Coppermine Photo Gallery inurl:php?pid= add your comment ");
					for (int k = 0; k < document.get_All().get_Count(); k++)
					{
						try
						{
							if (document.get_All().get_Item(k).GetAttribute("title") == "Google Search")
							{
								document.get_All().get_Item(k).SetAttribute("value", text + array[i]);
							}
							else if (document.get_All().get_Item(k).GetAttribute("value") == "Google Search")
							{
								document.get_All().get_Item(k).InvokeMember("click");
								break;
							}
						}
						catch
						{
						}
					}
					while (true)
					{
						Application.DoEvents();
						now = DateTime.Now;
						while (true)
						{
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							if (bool_0)
							{
								break;
							}
							Application.DoEvents();
							long num2 = (long)(DateTime.Now - now).TotalSeconds;
							if (num2 <= 2L)
							{
								continue;
							}
							goto IL_02b4;
						}
						break;
						IL_072e:
						document = webBrowser1.get_Document();
						for (int l = 0; l < document.get_All().get_Count(); l++)
						{
							try
							{
								if (document.get_All().get_Item(l).GetAttribute("href")
									.IndexOf("start=" + num * 10) > 0)
								{
									document.get_All().get_Item(l).InvokeMember("click");
									break;
								}
							}
							catch
							{
							}
						}
						num++;
						continue;
						IL_02b4:
						DateTime now2 = DateTime.Now;
						while (true)
						{
							now = DateTime.Now;
							while (true)
							{
								((Control)label2).set_Text(((Control)label2).get_Text() + ".");
								if (((Control)label2).get_Text().Length > 60)
								{
									((Control)label2).set_Text("Search...");
								}
								if (bool_0)
								{
									break;
								}
								Application.DoEvents();
								long num3 = (long)(DateTime.Now - now).TotalSeconds;
								if (num3 <= 1L)
								{
									continue;
								}
								goto IL_033b;
							}
							break;
							IL_033b:
							long num4 = (long)(DateTime.Now - now2).TotalSeconds;
							if (num4 > 15L)
							{
								goto IL_07c5;
							}
							if (bool_0)
							{
								break;
							}
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							if (document == (HtmlDocument)null || document.get_Body() == (HtmlElement)null || document.get_Body().get_OuterHtml() == null)
							{
								continue;
							}
							Application.DoEvents();
							string text2;
							try
							{
								text2 = document.get_Body().get_OuterHtml().ToLower();
							}
							catch
							{
								continue;
							}
							if (text2.IndexOf("<span class=i>" + num + "</span>") <= 0 || text2.IndexOf("start=" + num * 10) <= 0)
							{
								if (text2.IndexOf("http 404") <= 0 && text2.IndexOf("您正在查找的页当前不可用") <= 0 && text2.IndexOf("in order to show you the most relevant results") <= 0 && ((text2.IndexOf("... but your query looks similar") <= 0 && text2.IndexOf("... 此刻我们无法回应您的要求") <= 0) || text2.IndexOf("please type the characters you see below") >= 0) && text2.IndexOf("was not found on this server") <= 0)
								{
									if (text2.IndexOf("name=captcha") > 0)
									{
										((Control)this).set_Width(930);
									}
									continue;
								}
								goto IL_07c5;
							}
							goto IL_04e5;
						}
						break;
						IL_069f:
						now = DateTime.Now;
						while (true)
						{
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							if (bool_0)
							{
								break;
							}
							Application.DoEvents();
							long num5 = (long)(DateTime.Now - now).TotalSeconds;
							if (num5 <= int.Parse(((Control)textBox2).get_Text()))
							{
								continue;
							}
							goto IL_072e;
						}
						break;
						IL_04e5:
						((Control)this).set_Width(523);
						((Control)this).set_Width(523);
						string text3 = document.get_Body().get_OuterHtml().ToLower();
						int num6 = 0;
						while (!bool_0)
						{
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							Application.DoEvents();
							int num7 = text3.IndexOf("')\" href=\"h", num6);
							if (num7 >= 0)
							{
								num6 = text3.IndexOf("\"", num7 + 15);
								if (num6 > 0)
								{
									string text4 = text3.Substring(num7 + 10, num6 - num7 - 10).Replace("amp;", "");
									string text5 = "";
									if (int_0 == 1)
									{
										string text6 = method_0(text4);
										string text7 = gclass0_0.method_0(text6).Trim().Replace("\r\n", "");
										if (int.Parse(text7) < int.Parse(((Control)comboBox1).get_Text()))
										{
											goto IL_069f;
										}
										text5 = "(" + text7 + ")";
										text4 = text5 + text4;
									}
									string text8 = text4.Substring(0, text4.LastIndexOf("/"));
									if (!((ObjectCollection)checkedListBox1.get_Items()).Contains((object)text8))
									{
										((ObjectCollection)checkedListBox1.get_Items()).Add((object)text8);
										((Control)label20).set_Text(((ObjectCollection)checkedListBox1.get_Items()).get_Count().ToString());
									}
									continue;
								}
							}
							goto IL_069f;
						}
						break;
					}
					goto end_IL_00a2;
					IL_07c5:;
				}
				continue;
				end_IL_00a2:
				break;
			}
			if (!checkBox2.get_Checked() && !checkBox3.get_Checked())
			{
				((Control)radioButton1).set_Enabled(true);
				((Control)radioButton2).set_Enabled(true);
				MessageBox.Show("Search Finished");
			}
		}
		if (checkBox2.get_Checked())
		{
			for (int m = 0; m < array.Length; m++)
			{
				for (int n = 0; n < 1; n++)
				{
					webBrowser1.Navigate("http://www.yahoo.com");
					((Control)label2).set_Text("Search...");
					bool_0 = false;
					DateTime now3 = DateTime.Now;
					while ((int)webBrowser1.get_ReadyState() != 4)
					{
						((Control)label2).set_Text(((Control)label2).get_Text() + ".");
						if (((Control)label2).get_Text().Length > 60)
						{
							((Control)label2).set_Text("Search...");
						}
						if (bool_0)
						{
							goto end_IL_0836;
						}
						Application.DoEvents();
						_ = (DateTime.Now - now3).TotalSeconds;
					}
					int num8 = 1;
					HtmlDocument document2 = webBrowser1.get_Document();
					string text9 = "";
					text9 = ((n == 0) ? "\"powered by vbulletin\" \"send a private message\"" : "Powered by Coppermine Photo Gallery inurl:php?pid= add your comment ");
					for (int num9 = 0; num9 < document2.get_All().get_Count(); num9++)
					{
						try
						{
							if (document2.get_All().get_Item(num9).GetAttribute("name") == "p")
							{
								document2.get_All().get_Item(num9).SetAttribute("value", text9 + array[m]);
							}
							else if (document2.get_All().get_Item(num9).GetAttribute("value") == "Web Search")
							{
								document2.get_All().get_Item(num9).InvokeMember("click");
								break;
							}
						}
						catch
						{
						}
					}
					while (true)
					{
						Application.DoEvents();
						now3 = DateTime.Now;
						while (true)
						{
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							if (bool_0)
							{
								break;
							}
							Application.DoEvents();
							long num10 = (long)(DateTime.Now - now3).TotalSeconds;
							if (num10 <= 2L)
							{
								continue;
							}
							goto IL_0a48;
						}
						break;
						IL_0ec6:
						document2 = webBrowser1.get_Document();
						for (int num11 = 0; num11 < document2.get_All().get_Count(); num11++)
						{
							try
							{
								if (document2.get_All().get_Item(num11).GetAttribute("title")
									.IndexOf(num8 * 10 + 1 + " - " + (num8 + 1) * 10) > 0)
								{
									document2.get_All().get_Item(num11).InvokeMember("click");
									break;
								}
							}
							catch
							{
							}
						}
						num8++;
						continue;
						IL_0a48:
						DateTime now4 = DateTime.Now;
						while (true)
						{
							now3 = DateTime.Now;
							while (true)
							{
								((Control)label2).set_Text(((Control)label2).get_Text() + ".");
								if (((Control)label2).get_Text().Length > 60)
								{
									((Control)label2).set_Text("Search...");
								}
								if (bool_0)
								{
									break;
								}
								Application.DoEvents();
								long num12 = (long)(DateTime.Now - now3).TotalSeconds;
								if (num12 <= 1L)
								{
									continue;
								}
								goto IL_0acf;
							}
							break;
							IL_0acf:
							long num13 = (long)(DateTime.Now - now4).TotalSeconds;
							if (num13 > 15L)
							{
								goto IL_0f72;
							}
							if (bool_0)
							{
								break;
							}
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							if (document2 == (HtmlDocument)null || document2.get_Body() == (HtmlElement)null || document2.get_Body().get_OuterHtml() == null)
							{
								continue;
							}
							Application.DoEvents();
							string text10;
							try
							{
								text10 = document2.get_Body().get_OuterHtml().ToLower();
							}
							catch
							{
								continue;
							}
							if (text10.IndexOf("<span>" + num8 + "</span>") <= 0)
							{
								if (text10.IndexOf("http 404") <= 0 && text10.IndexOf("您正在查找的页当前不可用") <= 0 && text10.IndexOf("we did not find results") <= 0 && ((text10.IndexOf("... but your query looks similar") <= 0 && text10.IndexOf("... 此刻我们无法回应您的要求") <= 0) || text10.IndexOf("please type the characters you see below") >= 0) && text10.IndexOf("to use open shortcuts") <= 0)
								{
									if (text10.IndexOf("name=captcha") > 0)
									{
										((Control)this).set_Width(930);
									}
									continue;
								}
								goto IL_0f72;
							}
							goto IL_0c57;
						}
						break;
						IL_0e37:
						now3 = DateTime.Now;
						while (true)
						{
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							if (bool_0)
							{
								break;
							}
							Application.DoEvents();
							long num14 = (long)(DateTime.Now - now3).TotalSeconds;
							if (num14 <= int.Parse(((Control)textBox2).get_Text()))
							{
								continue;
							}
							goto IL_0ec6;
						}
						break;
						IL_0c57:
						((Control)this).set_Width(523);
						((Control)this).set_Width(523);
						string text11 = document2.get_Body().get_OuterHtml().ToLower();
						int num15 = 0;
						while (!bool_0)
						{
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							Application.DoEvents();
							int num16 = text11.IndexOf("class=yschttl", num15);
							int num17 = text11.IndexOf("http%3a", num16 + 30);
							if (num16 >= 0)
							{
								num15 = text11.IndexOf("\">", num17 + 10);
								if (num15 > 0)
								{
									string text12 = text11.Substring(num17, num15 - num17).Replace("%3a", ":");
									if (text12.Trim().IndexOf("yahoo.com") < 0)
									{
										string text13 = "";
										if (int_0 == 1)
										{
											string text14 = method_0(text12);
											string text15 = gclass0_0.method_0(text14).Trim().Replace("\r\n", "");
											if (int.Parse(text15) < int.Parse(((Control)comboBox1).get_Text()))
											{
												goto IL_0e37;
											}
											text13 = "(" + text15 + ")";
											text12 = text13 + text12;
										}
										string text16 = text12.Substring(0, text12.LastIndexOf("/"));
										if (!((ObjectCollection)checkedListBox1.get_Items()).Contains((object)text16))
										{
											((ObjectCollection)checkedListBox1.get_Items()).Add((object)text16);
											((Control)label20).set_Text(((ObjectCollection)checkedListBox1.get_Items()).get_Count().ToString());
										}
										continue;
									}
								}
							}
							goto IL_0e37;
						}
						break;
					}
					goto end_IL_0836;
					IL_0f72:;
				}
				continue;
				end_IL_0836:
				break;
			}
			((Control)label2).set_Text("");
			if (!checkBox3.get_Checked())
			{
				((Control)radioButton1).set_Enabled(true);
				((Control)radioButton2).set_Enabled(true);
				MessageBox.Show("Search Finished");
			}
		}
		if (!checkBox3.get_Checked())
		{
			return;
		}
		for (int num18 = 0; num18 < array.Length; num18++)
		{
			for (int num19 = 0; num19 < 1; num19++)
			{
				webBrowser1.Navigate("http://www.live.com");
				((Control)label2).set_Text("Search...");
				bool_0 = false;
				DateTime now5 = DateTime.Now;
				while ((int)webBrowser1.get_ReadyState() != 4)
				{
					((Control)label2).set_Text(((Control)label2).get_Text() + ".");
					if (((Control)label2).get_Text().Length > 60)
					{
						((Control)label2).set_Text("Search...");
					}
					if (bool_0)
					{
						goto end_IL_0fe5;
					}
					Application.DoEvents();
					_ = (DateTime.Now - now5).TotalSeconds;
				}
				int num20 = 1;
				HtmlDocument document3 = webBrowser1.get_Document();
				string text17 = "";
				text17 = ((num19 == 0) ? "\"powered by vbulletin\" \"send a private message\"" : "Powered by Coppermine Photo Gallery inurl:php?pid= add your comment ");
				for (int num21 = 0; num21 < document3.get_All().get_Count(); num21++)
				{
					try
					{
						if (document3.get_All().get_Item(num21).GetAttribute("name") == "q")
						{
							document3.get_All().get_Item(num21).SetAttribute("value", text17 + array[num18]);
						}
						else if (document3.get_All().get_Item(num21).GetAttribute("value") == "Search")
						{
							document3.get_All().get_Item(num21).InvokeMember("click");
							break;
						}
					}
					catch
					{
					}
				}
				while (true)
				{
					Application.DoEvents();
					now5 = DateTime.Now;
					while (true)
					{
						((Control)label2).set_Text(((Control)label2).get_Text() + ".");
						if (((Control)label2).get_Text().Length > 60)
						{
							((Control)label2).set_Text("Search...");
						}
						if (bool_0)
						{
							break;
						}
						Application.DoEvents();
						long num22 = (long)(DateTime.Now - now5).TotalSeconds;
						if (num22 <= 2L)
						{
							continue;
						}
						goto IL_11f6;
					}
					break;
					IL_163d:
					document3 = webBrowser1.get_Document();
					for (int num23 = 0; num23 < document3.get_All().get_Count(); num23++)
					{
						try
						{
							if (document3.get_All().get_Item(num23).GetAttribute("href")
								.IndexOf("first=" + (num20 * 10 + 1)) > 0)
							{
								document3.get_All().get_Item(num23).InvokeMember("click");
								break;
							}
						}
						catch
						{
						}
					}
					num20++;
					continue;
					IL_11f6:
					DateTime now6 = DateTime.Now;
					while (true)
					{
						now5 = DateTime.Now;
						while (true)
						{
							((Control)label2).set_Text(((Control)label2).get_Text() + ".");
							if (((Control)label2).get_Text().Length > 60)
							{
								((Control)label2).set_Text("Search...");
							}
							if (bool_0)
							{
								break;
							}
							Application.DoEvents();
							long num24 = (long)(DateTime.Now - now5).TotalSeconds;
							if (num24 <= 1L)
							{
								continue;
							}
							goto IL_127d;
						}
						break;
						IL_127d:
						long num25 = (long)(DateTime.Now - now6).TotalSeconds;
						if (num25 > 15L)
						{
							goto IL_16d6;
						}
						if (bool_0)
						{
							break;
						}
						((Control)label2).set_Text(((Control)label2).get_Text() + ".");
						if (((Control)label2).get_Text().Length > 60)
						{
							((Control)label2).set_Text("Search...");
						}
						if (document3 == (HtmlDocument)null || document3.get_Body() == (HtmlElement)null || document3.get_Body().get_OuterHtml() == null)
						{
							continue;
						}
						Application.DoEvents();
						string text18;
						try
						{
							text18 = document3.get_Body().get_OuterHtml().ToLower();
						}
						catch
						{
							continue;
						}
						if (text18.IndexOf("form=pore\">next</a>") <= 0)
						{
							if (text18.IndexOf("http 404") <= 0 && text18.IndexOf("您正在查找的页当前不可用") <= 0 && text18.IndexOf("we did not find results") <= 0 && ((text18.IndexOf("... but your query looks similar") <= 0 && text18.IndexOf("... 此刻我们无法回应您的要求") <= 0) || text18.IndexOf("please type the characters you see below") >= 0) && text18.IndexOf("to use open shortcuts") <= 0)
							{
								if (text18.IndexOf("name=captcha") > 0)
								{
									((Control)this).set_Width(930);
								}
								continue;
							}
							goto IL_16d6;
						}
						goto IL_13ea;
					}
					break;
					IL_15aa:
					now5 = DateTime.Now;
					while (true)
					{
						((Control)label2).set_Text(((Control)label2).get_Text() + ".");
						if (((Control)label2).get_Text().Length > 60)
						{
							((Control)label2).set_Text("Search...");
						}
						if (bool_0)
						{
							break;
						}
						Application.DoEvents();
						long num26 = (long)(DateTime.Now - now5).TotalSeconds;
						if (num26 <= int.Parse(((Control)textBox2).get_Text()))
						{
							continue;
						}
						goto IL_163d;
					}
					break;
					IL_13ea:
					((Control)this).set_Width(523);
					((Control)this).set_Width(523);
					string text19 = document3.get_Body().get_OuterHtml().ToLower();
					int num27 = 0;
					while (!bool_0)
					{
						((Control)label2).set_Text(((Control)label2).get_Text() + ".");
						if (((Control)label2).get_Text().Length > 60)
						{
							((Control)label2).set_Text("Search...");
						}
						Application.DoEvents();
						int num28 = text19.IndexOf("<li class=dispurl>", num27);
						if (num28 >= 0)
						{
							num27 = text19.IndexOf("<li class=cached>", num28 + 10);
							if (num27 > 0)
							{
								string text20 = text19.Substring(num28 + 18, num27 - num28 - 18).Replace("<strong>", "").Replace("</strong>", "");
								text20 = "http://" + text20;
								string text21 = "";
								if (int_0 == 1)
								{
									string text22 = method_0(text20);
									string text23 = gclass0_0.method_0(text22).Trim().Replace("\r\n", "");
									if (int.Parse(text23) < int.Parse(((Control)comboBox1).get_Text()))
									{
										goto IL_15aa;
									}
									text21 = "(" + text23 + ")";
									text20 = text21 + text20;
								}
								if (!((ObjectCollection)checkedListBox1.get_Items()).Contains((object)text20))
								{
									((ObjectCollection)checkedListBox1.get_Items()).Add((object)text20);
									((Control)label20).set_Text(((ObjectCollection)checkedListBox1.get_Items()).get_Count().ToString());
								}
								continue;
							}
						}
						goto IL_15aa;
					}
					break;
				}
				goto end_IL_0fe5;
				IL_16d6:;
			}
			continue;
			end_IL_0fe5:
			break;
		}
		((Control)label2).set_Text("");
		((Control)radioButton1).set_Enabled(true);
		((Control)radioButton2).set_Enabled(true);
		MessageBox.Show("Search Finished");
	}

	private string method_0(string string_2)
	{
		string[] array = string_2.Replace("http://", "").Split(new char[1] { '/' });
		return array[0];
	}

	private void button9_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between I4 and Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_Filter("Text File|*.txt");
		if (1 == (int)((CommonDialog)val).ShowDialog())
		{
			string fileName = ((FileDialog)val).get_FileName();
			StreamWriter streamWriter = File.CreateText(fileName);
			for (int i = 0; i < checkedListBox1.get_CheckedItems().get_Count(); i++)
			{
				streamWriter.WriteLine(checkedListBox1.get_CheckedItems().get_Item(i).ToString());
			}
			streamWriter.Close();
			MessageBox.Show("File is saved!");
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		DialogResult val = MessageBox.Show((IWin32Window)(object)this, "Do you want to remove the duplicate item ?", "Caution", (MessageBoxButtons)4, (MessageBoxIcon)32);
		if ((int)val == 6)
		{
			ArrayList arrayList = new ArrayList();
			ArrayList arrayList2 = new ArrayList();
			for (int i = 0; i < ((ObjectCollection)checkedListBox1.get_Items()).get_Count(); i++)
			{
				string[] array = ((ObjectCollection)checkedListBox1.get_Items()).get_Item(i).ToString()!.ToLower().Replace("http://", "").Split(new char[1] { '/' });
				if (arrayList.Contains(array[0]))
				{
					arrayList2.Add(((ObjectCollection)checkedListBox1.get_Items()).get_Item(i).ToString());
				}
				else
				{
					arrayList.Add(array[0]);
				}
			}
			for (int j = 0; j < arrayList2.Count; j++)
			{
				((ObjectCollection)checkedListBox1.get_Items()).Remove(arrayList2[j]);
			}
		}
		MessageBox.Show("Finish!");
		((Control)label20).set_Text(((ObjectCollection)checkedListBox1.get_Items()).get_Count().ToString());
	}

	private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Control)targetURL).set_Text(((Control)checkedListBox1).get_Text());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (((Control)button2).get_Text() == "Select all")
		{
			for (int i = 0; i < ((ObjectCollection)checkedListBox1.get_Items()).get_Count(); i++)
			{
				checkedListBox1.SetItemChecked(i, true);
			}
			((Control)button2).set_Text("Cancel Select all");
		}
		else
		{
			for (int j = 0; j < ((ObjectCollection)checkedListBox1.get_Items()).get_Count(); j++)
			{
				checkedListBox1.SetItemChecked(j, false);
			}
			((Control)button2).set_Text("Select all");
		}
	}

	private void button7_Click(object sender, EventArgs e)
	{
		((ObjectCollection)checkedListBox1.get_Items()).Clear();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		bool_0 = true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		SkinEngine val = new SkinEngine((Component)(object)Application.get_OpenForms().get_Item(0), Application.get_StartupPath() + "\\mp10.ssk");
		val.set_Active(true);
	}

	private string[] method_1(string string_2, string string_3, string[] string_4)
	{
		string[] array = new string[string_4.Length + 1];
		string_4.CopyTo(array, 0);
		int num = string_2.IndexOf(string_3, 0);
		if (num >= 0)
		{
			array[string_4.Length] = string_2.Substring(0, num);
			return method_1(string_2.Substring(num + string_3.Length), string_3, array);
		}
		array[string_4.Length] = string_2;
		return array;
	}

	public string[] method_2(string string_2, string string_3)
	{
		string[] array = new string[1];
		int num = string_2.IndexOf(string_3, 0);
		if (num < 0)
		{
			array[0] = string_2;
			return array;
		}
		array[0] = string_2.Substring(0, num);
		return method_1(string_2.Substring(num + string_3.Length), string_3, array);
	}

	private void method_3()
	{
		try
		{
			byte[] bytes = webClient_0.UploadData(string_0, "POST", byte_0);
			string_1 = Encoding.UTF8.GetString(bytes);
		}
		catch
		{
		}
		bool_1 = false;
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void button8_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between I4 and Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).set_Filter("Text file|*.txt");
			if (1 != (int)((CommonDialog)val).ShowDialog())
			{
				return;
			}
			DialogResult val2 = MessageBox.Show((IWin32Window)(object)this, "Do you want to clear the old items in the box ?", "Caution", (MessageBoxButtons)3, (MessageBoxIcon)32);
			if ((int)val2 == 6)
			{
				((ObjectCollection)checkedListBox1.get_Items()).Clear();
			}
			if ((int)val2 != 2)
			{
				StreamReader streamReader = File.OpenText(((FileDialog)val).get_FileName());
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					((ObjectCollection)checkedListBox1.get_Items()).Add((object)text);
				}
				streamReader.Close();
			}
		}
		catch
		{
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		bool_0 = true;
	}

	private void method_6(object sender, EventArgs e)
	{
		bool_2 = true;
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButton1.get_Checked())
		{
			int_0 = 1;
		}
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButton2.get_Checked())
		{
			int_0 = 2;
		}
	}

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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		webBrowser1 = new WebBrowser();
		label1 = new Label();
		button9 = new Button();
		label20 = new Label();
		button7 = new Button();
		button3 = new Button();
		checkedListBox1 = new CheckedListBox();
		button2 = new Button();
		label8 = new Label();
		targetURL = new TextBox();
		label2 = new Label();
		button1 = new Button();
		button4 = new Button();
		label3 = new Label();
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		textBox1 = new TextBox();
		tabPage2 = new TabPage();
		comboBox1 = new ComboBox();
		label6 = new Label();
		radioButton2 = new RadioButton();
		radioButton1 = new RadioButton();
		checkBox3 = new CheckBox();
		checkBox2 = new CheckBox();
		checkBox1 = new CheckBox();
		label5 = new Label();
		textBox2 = new TextBox();
		label4 = new Label();
		button8 = new Button();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Location(new Point(511, -16));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(410, 621));
		((Control)webBrowser1).set_TabIndex(0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(11, 32));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(209, 12));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Please Enter One Keyword Per Line:");
		((Control)button9).set_BackColor(SystemColors.Control);
		((Control)button9).set_ForeColor(Color.Black);
		((Control)button9).set_Location(new Point(16, 544));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(108, 24));
		((Control)button9).set_TabIndex(77);
		((Control)button9).set_Text("Save");
		((ButtonBase)button9).set_UseVisualStyleBackColor(false);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)label20).set_BackColor(Color.White);
		((Control)label20).set_Location(new Point(90, 99));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(64, 16));
		((Control)label20).set_TabIndex(76);
		((Control)button7).set_BackColor(SystemColors.Control);
		((Control)button7).set_ForeColor(Color.Black);
		((Control)button7).set_Location(new Point(410, 100));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(72, 23));
		((Control)button7).set_TabIndex(75);
		((Control)button7).set_Text("Clear");
		((ButtonBase)button7).set_UseVisualStyleBackColor(false);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((Control)button3).set_BackColor(SystemColors.Control);
		((Control)button3).set_ForeColor(Color.Black);
		((Control)button3).set_Location(new Point(282, 544));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(202, 24));
		((Control)button3).set_TabIndex(73);
		((Control)button3).set_Text("Remove Reduplicate Domain");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)checkedListBox1).set_Location(new Point(16, 133));
		((Control)checkedListBox1).set_Name("checkedListBox1");
		((Control)checkedListBox1).set_Size(new Size(466, 340));
		((Control)checkedListBox1).set_TabIndex(72);
		((ListBox)checkedListBox1).add_SelectedIndexChanged((EventHandler)checkedListBox1_SelectedIndexChanged);
		((Control)button2).set_BackColor(SystemColors.Control);
		((Control)button2).set_ForeColor(Color.Black);
		((Control)button2).set_Location(new Point(282, 99));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(120, 24));
		((Control)button2).set_TabIndex(71);
		((Control)button2).set_Text("Select all");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label8).set_BackColor(Color.White);
		((Control)label8).set_Location(new Point(16, 100));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(73, 16));
		((Control)label8).set_TabIndex(70);
		((Control)label8).set_Text("Url List：");
		((Control)targetURL).set_Location(new Point(16, 481));
		((Control)targetURL).set_Name("targetURL");
		((Control)targetURL).set_Size(new Size(466, 21));
		((Control)targetURL).set_TabIndex(69);
		((Control)label2).set_BackColor(Color.FromArgb(128, 128, 255));
		((Control)label2).set_Location(new Point(14, 50));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(468, 16));
		((Control)label2).set_TabIndex(78);
		((Control)button1).set_Font(new Font("Arial", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(16, 6));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(228, 39));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Search");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button4).set_Font(new Font("Arial", 15f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button4).set_Location(new Point(256, 6));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(228, 39));
		((Control)button4).set_TabIndex(79);
		((Control)button4).set_Text("Stop");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)label3).set_BackColor(Color.FromArgb(255, 255, 128));
		((Control)label3).set_Location(new Point(593, 53));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(212, 40));
		((Control)label3).set_TabIndex(80);
		((Control)label3).set_Text("Please input validation code，press＂ＥＮＴＥＲ＂to continue.");
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).set_Location(new Point(3, 3));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(502, 606));
		((Control)tabControl1).set_TabIndex(81);
		((Control)tabPage1).set_BackColor(Color.White);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox1);
		((Control)tabPage1).get_Controls().Add((Control)(object)label1);
		tabPage1.set_Location(new Point(4, 21));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(494, 581));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("Keywords");
		tabPage1.set_UseVisualStyleBackColor(true);
		((Control)textBox1).set_Location(new Point(13, 62));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(461, 269));
		((Control)textBox1).set_TabIndex(1);
		((Control)tabPage2).set_BackColor(Color.White);
		((Control)tabPage2).get_Controls().Add((Control)(object)comboBox1);
		((Control)tabPage2).get_Controls().Add((Control)(object)label6);
		((Control)tabPage2).get_Controls().Add((Control)(object)radioButton2);
		((Control)tabPage2).get_Controls().Add((Control)(object)radioButton1);
		((Control)tabPage2).get_Controls().Add((Control)(object)checkBox3);
		((Control)tabPage2).get_Controls().Add((Control)(object)checkBox2);
		((Control)tabPage2).get_Controls().Add((Control)(object)checkBox1);
		((Control)tabPage2).get_Controls().Add((Control)(object)label5);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox2);
		((Control)tabPage2).get_Controls().Add((Control)(object)label4);
		((Control)tabPage2).get_Controls().Add((Control)(object)button8);
		((Control)tabPage2).get_Controls().Add((Control)(object)label2);
		((Control)tabPage2).get_Controls().Add((Control)(object)targetURL);
		((Control)tabPage2).get_Controls().Add((Control)(object)button4);
		((Control)tabPage2).get_Controls().Add((Control)(object)label8);
		((Control)tabPage2).get_Controls().Add((Control)(object)button1);
		((Control)tabPage2).get_Controls().Add((Control)(object)button2);
		((Control)tabPage2).get_Controls().Add((Control)(object)button9);
		((Control)tabPage2).get_Controls().Add((Control)(object)checkedListBox1);
		((Control)tabPage2).get_Controls().Add((Control)(object)label20);
		((Control)tabPage2).get_Controls().Add((Control)(object)button3);
		((Control)tabPage2).get_Controls().Add((Control)(object)button7);
		tabPage2.set_Location(new Point(4, 21));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Padding(new Padding(3));
		((Control)tabPage2).set_Size(new Size(494, 581));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("Search");
		tabPage2.set_UseVisualStyleBackColor(true);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
		((Control)comboBox1).set_Location(new Point(329, 99));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(51, 20));
		((Control)comboBox1).set_TabIndex(90);
		((Control)comboBox1).set_Text("0");
		((Control)comboBox1).set_Visible(false);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(16, 102));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(71, 12));
		((Control)label6).set_TabIndex(89);
		((Control)label6).set_Text("Page Rank：");
		((Control)label6).set_Visible(false);
		((Control)radioButton2).set_AutoSize(true);
		radioButton2.set_Checked(true);
		((Control)radioButton2).set_Location(new Point(93, 100));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(95, 16));
		((Control)radioButton2).set_TabIndex(88);
		radioButton2.set_TabStop(true);
		((Control)radioButton2).set_Text("No Page Rank");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		((Control)radioButton2).set_Visible(false);
		radioButton2.add_CheckedChanged((EventHandler)radioButton2_CheckedChanged);
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Location(new Point(194, 100));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(137, 16));
		((Control)radioButton1).set_TabIndex(87);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("Search Page Rank >=");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		((Control)radioButton1).set_Visible(false);
		radioButton1.add_CheckedChanged((EventHandler)radioButton1_CheckedChanged);
		((Control)checkBox3).set_AutoSize(true);
		((Control)checkBox3).set_Location(new Point(281, 78));
		((Control)checkBox3).set_Name("checkBox3");
		((Control)checkBox3).set_Size(new Size(78, 16));
		((Control)checkBox3).set_TabIndex(86);
		((Control)checkBox3).set_Text("Live(MSN)");
		((ButtonBase)checkBox3).set_UseVisualStyleBackColor(true);
		((Control)checkBox3).set_Visible(false);
		((Control)checkBox2).set_AutoSize(true);
		((Control)checkBox2).set_Location(new Point(220, 77));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(54, 16));
		((Control)checkBox2).set_TabIndex(85);
		((Control)checkBox2).set_Text("Yahoo");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(154, 77));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(60, 16));
		((Control)checkBox1).set_TabIndex(84);
		((Control)checkBox1).set_Text("Google");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(16, 78));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(137, 12));
		((Control)label5).set_TabIndex(83);
		((Control)label5).set_Text("Choose search engine：");
		((Control)textBox2).set_Location(new Point(175, 512));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(307, 21));
		((Control)textBox2).set_TabIndex(82);
		((Control)textBox2).set_Text("0");
		((Control)label4).set_Location(new Point(14, 516));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(169, 16));
		((Control)label4).set_TabIndex(81);
		((Control)label4).set_Text("Search interval time (s)：");
		((Control)button8).set_BackColor(SystemColors.Control);
		((Control)button8).set_ForeColor(Color.Black);
		((Control)button8).set_Location(new Point(130, 544));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(114, 24));
		((Control)button8).set_TabIndex(80);
		((Control)button8).set_Text("Load");
		((ButtonBase)button8).set_UseVisualStyleBackColor(false);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(192, 192, 255));
		((Form)this).set_ClientSize(new Size(513, 611));
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("PM Search Genius");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}

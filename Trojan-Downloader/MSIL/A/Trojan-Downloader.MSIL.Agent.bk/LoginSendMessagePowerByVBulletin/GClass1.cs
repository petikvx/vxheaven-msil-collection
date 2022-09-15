using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LoginSendMessagePowerByVBulletin;

public class GClass1
{
	private WebBrowser webBrowser_0;

	private string string_0;

	private HttpWebRequest httpWebRequest_0;

	private string string_1;

	public GClass1()
	{
		webBrowser_0 = Class0.form1_0.webBrowser1;
	}

	public bool method_0(string string_2)
	{
		try
		{
			string_0 = string_2;
			httpWebRequest_0 = WebRequest.Create(string_0) as HttpWebRequest;
			httpWebRequest_0.Method = "GET";
			httpWebRequest_0.KeepAlive = true;
			httpWebRequest_0.AllowAutoRedirect = true;
			httpWebRequest_0.CookieContainer = Class0.cookieContainer_0;
			httpWebRequest_0.Timeout = int.Parse(Class0.form1_0.string_4) * 1000;
			HttpWebResponse httpWebResponse = httpWebRequest_0.GetResponse() as HttpWebResponse;
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
			string text = streamReader.ReadToEnd();
			if (text.IndexOf("recipients") < 0)
			{
				return false;
			}
			if (text.IndexOf("pmrecips_txt") >= 0)
			{
				string_1 = text.Substring(text.IndexOf("pmrecips_txt"));
				string_1 = string_1.Substring(string_1.IndexOf(">") + 1);
				string_1 = string_1.Remove(string_1.IndexOf("<"));
			}
			if (string_1 == null)
			{
				string_1 = text.Substring(text.IndexOf("recipients"));
				string_1 = string_1.Substring(string_1.IndexOf("value=") + 7);
				string_1 = string_1.Remove(string_1.IndexOf("\""));
			}
			httpWebRequest_0 = WebRequest.Create("http://" + httpWebRequest_0.Headers["Host"]!.ToString() + Class0.string_0 + "/private.php?folderid=-1") as HttpWebRequest;
			httpWebRequest_0.Method = "GET";
			httpWebRequest_0.KeepAlive = true;
			httpWebRequest_0.AllowAutoRedirect = true;
			httpWebRequest_0.CookieContainer = Class0.cookieContainer_0;
			httpWebRequest_0.Timeout = int.Parse(Class0.form1_0.string_4) * 1000;
			httpWebResponse = httpWebRequest_0.GetResponse() as HttpWebResponse;
			responseStream = httpWebResponse.GetResponseStream();
			streamReader = new StreamReader(responseStream, Encoding.GetEncoding("GB2312"));
			string text2 = streamReader.ReadToEnd();
			if (text2.IndexOf("messages stored, of a total") >= 0)
			{
				try
				{
					int num = int.Parse(text2.Substring(text2.IndexOf("You have ")).Remove(text2.Substring(text2.IndexOf("You have ")).IndexOf(" messages stored")).Replace("You have ", ""));
					int num2 = int.Parse(text2.Substring(text2.IndexOf("of a total ")).Remove(text2.Substring(text2.IndexOf("of a total ")).IndexOf(" allowed")).Replace("of a total ", ""));
					string text3 = "";
					string text4 = "";
					string text5 = "";
					if (num2 - num > 0)
					{
						text3 = Class0.form1_0.string_6.Replace("[Name]", string_1);
						text4 = Class0.form1_0.string_5.Replace("[Name]", string_1);
						text5 = "recipients=" + string_1 + "&bccrecipients=&title=" + text4 + "&message=" + text3 + "&wysiwyg=0&iconid=0&s=&do=insertpm&pmid=&forward=&sbutton=Submit+Message&savecopy=1&parseurl=1";
						byte[] bytes = Encoding.ASCII.GetBytes(text5);
						httpWebRequest_0 = WebRequest.Create("http://" + httpWebRequest_0.Headers["Host"]!.ToString() + Class0.string_0 + "/private.php?do=insertpm;pmid=") as HttpWebRequest;
						httpWebRequest_0.Method = "POST";
						httpWebRequest_0.AllowAutoRedirect = true;
						httpWebRequest_0.ContentType = "application/x-www-form-urlencoded";
						httpWebRequest_0.CookieContainer = Class0.cookieContainer_0;
						httpWebRequest_0.ContentLength = bytes.Length;
						httpWebRequest_0.Timeout = int.Parse(Class0.form1_0.string_4) * 1000;
						Stream requestStream = httpWebRequest_0.GetRequestStream();
						requestStream.Write(bytes, 0, bytes.Length);
						requestStream.Close();
						httpWebResponse = httpWebRequest_0.GetResponse() as HttpWebResponse;
						responseStream = httpWebResponse.GetResponseStream();
						streamReader = new StreamReader(responseStream, Encoding.GetEncoding("GB2312"));
						text = streamReader.ReadToEnd();
						if (text.IndexOf("Private Messages in Folder") >= 0)
						{
							return true;
						}
						return false;
					}
					if (method_1())
					{
						text3 = Class0.form1_0.string_6.Replace("[Name]", string_1);
						text4 = Class0.form1_0.string_5.Replace("[Name]", string_1);
						text5 = "recipients=" + string_1 + "&bccrecipients=&title=" + text4 + "&message=" + text3 + "&wysiwyg=0&iconid=0&s=&do=insertpm&pmid=&forward=&sbutton=Submit+Message&savecopy=1&parseurl=1";
						byte[] bytes = Encoding.ASCII.GetBytes(text5);
						httpWebRequest_0 = WebRequest.Create("http://" + httpWebRequest_0.Headers["Host"]!.ToString() + Class0.string_0 + "/private.php?do=insertpm;pmid=") as HttpWebRequest;
						httpWebRequest_0.Method = "POST";
						httpWebRequest_0.AllowAutoRedirect = true;
						httpWebRequest_0.ContentType = "application/x-www-form-urlencoded";
						httpWebRequest_0.CookieContainer = Class0.cookieContainer_0;
						httpWebRequest_0.ContentLength = bytes.Length;
						httpWebRequest_0.Timeout = int.Parse(Class0.form1_0.string_4) * 1000;
						Stream requestStream2 = httpWebRequest_0.GetRequestStream();
						requestStream2.Write(bytes, 0, bytes.Length);
						requestStream2.Close();
						httpWebResponse = httpWebRequest_0.GetResponse() as HttpWebResponse;
						responseStream = httpWebResponse.GetResponseStream();
						streamReader = new StreamReader(responseStream, Encoding.GetEncoding("GB2312"));
						text = streamReader.ReadToEnd();
						if (text.IndexOf("Private Messages in Folder") < 0)
						{
							return false;
						}
						return true;
					}
					return false;
				}
				catch (Exception)
				{
					return false;
				}
			}
			return false;
		}
		catch (WebException ex2)
		{
			_ = ex2.Message;
			return false;
		}
	}

	private bool method_1()
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Invalid comparison between Unknown and I4
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Invalid comparison between Unknown and I4
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Invalid comparison between Unknown and I4
		webBrowser_0.Navigate("http://" + httpWebRequest_0.Headers["Host"]!.ToString() + Class0.string_0 + "/profile.php");
		DateTime now = DateTime.Now;
		while (true)
		{
			HtmlDocument document = webBrowser_0.get_Document();
			if (!Class0.form1_0.bool_0)
			{
				break;
			}
			Application.DoEvents();
			long num = (long)(DateTime.Now - now).TotalSeconds;
			if (num <= int.Parse(Class0.form1_0.string_4))
			{
				if (num <= 8L || document == (HtmlDocument)null)
				{
					continue;
				}
				HtmlElement body = document.get_Body();
				if (body == (HtmlElement)null || body.get_InnerText() == null)
				{
					continue;
				}
				if (body.get_OuterHtml().IndexOf("navbar_username") < 0 && body.get_OuterHtml().IndexOf("vb_login_username") < 0)
				{
					if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("navbar_username") < 0 && body.get_OuterHtml().IndexOf("vb_login_username") < 0)
					{
						return false;
					}
					continue;
				}
				now = DateTime.Now;
				HtmlElementCollection elementsByTagName = document.GetElementsByTagName("input");
				int i;
				for (i = 0; i < elementsByTagName.get_Count(); i++)
				{
					try
					{
						if (elementsByTagName.get_Item(i).GetAttribute("name") == "vb_login_username")
						{
							elementsByTagName.get_Item(i).SetAttribute("value", Class0.form1_0.string_2);
						}
						if (elementsByTagName.get_Item(i).GetAttribute("name") == "vb_login_password")
						{
							elementsByTagName.get_Item(i).SetAttribute("value", Class0.form1_0.string_3);
						}
						if (elementsByTagName.get_Item(i).GetAttribute("type") == "submit" && elementsByTagName.get_Item(i).GetAttribute("value") == "Log in")
						{
							elementsByTagName.get_Item(i).InvokeMember("click");
							break;
						}
					}
					catch (Exception)
					{
					}
				}
				if (i == elementsByTagName.get_Count())
				{
					return false;
				}
				now = DateTime.Now;
				while (true)
				{
					document = webBrowser_0.get_Document();
					if (!Class0.form1_0.bool_0)
					{
						break;
					}
					Application.DoEvents();
					long num2 = (long)(DateTime.Now - now).TotalSeconds;
					if (num2 <= int.Parse(Class0.form1_0.string_4))
					{
						if (num2 <= 8L || document == (HtmlDocument)null)
						{
							continue;
						}
						HtmlElement body2 = document.get_Body();
						if (body2 == (HtmlElement)null || body2.get_InnerText() == null)
						{
							continue;
						}
						if (body2.get_OuterHtml().IndexOf("You are not logged in") < 0)
						{
							if (body2.get_OuterHtml().IndexOf("Welcome") < 0)
							{
								if (body2.get_OuterHtml().IndexOf("Thank you for logging in") >= 0)
								{
									HtmlElementCollection elementsByTagName2 = document.GetElementsByTagName("a");
									for (i = 0; i < elementsByTagName2.get_Count(); i++)
									{
										if (elementsByTagName2.get_Item(i).get_InnerText().IndexOf("Click here if your browser does not automatically redirect you") >= 0)
										{
											elementsByTagName2.get_Item(i).InvokeMember("click");
											break;
										}
									}
								}
								if (body2.get_OuterHtml().IndexOf("You last visited") < 0 && body2.get_OuterHtml().IndexOf("Edit Profile") < 0)
								{
									if ((int)webBrowser_0.get_ReadyState() == 4 && body2.get_OuterHtml().IndexOf("Thank you for logging in") < 0 && body2.get_OuterHtml().IndexOf("You last visited") < 0 && body2.get_OuterHtml().IndexOf("Welcome") < 0)
									{
										return false;
									}
									continue;
								}
							}
							webBrowser_0.Navigate(string_0.Substring(0, string_0.LastIndexOf("/") + 1) + "private.php?do=emptyfolder&folderid=-1");
							now = DateTime.Now;
							while (true)
							{
								document = webBrowser_0.get_Document();
								if (!Class0.form1_0.bool_0)
								{
									break;
								}
								Application.DoEvents();
								long num3 = (long)(DateTime.Now - now).TotalSeconds;
								if (num3 <= int.Parse(Class0.form1_0.string_4))
								{
									if (num3 <= 8L || document == (HtmlDocument)null)
									{
										continue;
									}
									HtmlElement body3 = document.get_Body();
									if (body3 == (HtmlElement)null || body3.get_InnerText() == null)
									{
										continue;
									}
									if (body3.get_OuterHtml().IndexOf("Confirm Deletion") < 0 && body3.get_OuterHtml().IndexOf("Are you sure you want to permanently delete all items") < 0)
									{
										if (body3.get_OuterHtml().IndexOf("You are not logged in") < 0 && body3.get_OuterHtml().IndexOf("vBulletin Message") < 0)
										{
											if ((int)webBrowser_0.get_ReadyState() == 4 && body3.get_OuterHtml().IndexOf("Confirm Deletion") < 0 && body3.get_OuterHtml().IndexOf("Are you sure you want to permanently delete all items") < 0)
											{
												return false;
											}
											continue;
										}
										return false;
									}
									elementsByTagName = document.GetElementsByTagName("input");
									for (i = 0; i < elementsByTagName.get_Count(); i++)
									{
										if (elementsByTagName.get_Item(i).GetAttribute("value").IndexOf("Yes") >= 0)
										{
											elementsByTagName.get_Item(i).InvokeMember("click");
											break;
										}
									}
									if (i == elementsByTagName.get_Count())
									{
										return false;
									}
									DateTime now2 = DateTime.Now;
									while (true)
									{
										document = webBrowser_0.get_Document();
										if (!Class0.form1_0.bool_0)
										{
											break;
										}
										Application.DoEvents();
										long num4 = (long)(DateTime.Now - now2).TotalSeconds;
										if (num4 <= int.Parse(Class0.form1_0.string_4))
										{
											if (num4 <= 8L || document == (HtmlDocument)null)
											{
												continue;
											}
											HtmlElement body4 = document.get_Body();
											if (!(body4 == (HtmlElement)null) && body4.get_InnerText() != null)
											{
												if (body4.get_OuterHtml().IndexOf("you do not have permission to access this page") >= 0)
												{
													return false;
												}
												if (body4.get_OuterHtml().IndexOf("Private Messages in Folder") >= 0)
												{
													return true;
												}
												if ((int)webBrowser_0.get_ReadyState() == 4 && body4.get_OuterHtml().IndexOf("Private Messages in Folder") < 0)
												{
													return false;
												}
											}
											continue;
										}
										return false;
									}
									return false;
								}
								return false;
							}
							return false;
						}
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}
}

using System;
using System.Windows.Forms;

namespace EditSignaturePoweredbyVBulletin;

public class GClass0
{
	private HtmlDocument htmlDocument_0;

	private WebBrowser webBrowser_0;

	private string string_0;

	public GClass0()
	{
		webBrowser_0 = Class0.form1_0.webBrowser1;
	}

	public bool method_0()
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Invalid comparison between Unknown and I4
		webBrowser_0.Navigate(Class0.form1_0.string_0 + "profile.php");
		DateTime now = DateTime.Now;
		while (true)
		{
			htmlDocument_0 = webBrowser_0.get_Document();
			if (!Class0.form1_0.bool_0)
			{
				break;
			}
			Application.DoEvents();
			long num = (long)(DateTime.Now - now).TotalSeconds;
			if (num <= int.Parse(Class0.form1_0.string_3))
			{
				if (num <= 8L || htmlDocument_0 == (HtmlDocument)null)
				{
					continue;
				}
				HtmlElement body = htmlDocument_0.get_Body();
				if (!(body == (HtmlElement)null) && body.get_InnerText() != null)
				{
					if (body.get_OuterHtml().IndexOf("navbar_username") >= 0 || body.get_OuterHtml().IndexOf("vb_login_username") >= 0)
					{
						return true;
					}
					if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("navbar_username") < 0 && body.get_OuterHtml().IndexOf("vb_login_username") < 0)
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

	public bool method_1()
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Invalid comparison between Unknown and I4
		string_0 = webBrowser_0.get_Url().ToString();
		DateTime now = DateTime.Now;
		HtmlElementCollection elementsByTagName = htmlDocument_0.GetElementsByTagName("input");
		int i;
		for (i = 0; i < elementsByTagName.get_Count(); i++)
		{
			try
			{
				if (elementsByTagName.get_Item(i).GetAttribute("name") == "vb_login_username")
				{
					elementsByTagName.get_Item(i).SetAttribute("value", Class0.form1_0.string_1);
				}
				if (elementsByTagName.get_Item(i).GetAttribute("name") == "vb_login_password")
				{
					elementsByTagName.get_Item(i).SetAttribute("value", Class0.form1_0.string_2);
				}
				if (!(elementsByTagName.get_Item(i).GetAttribute("type") == "submit") || !(elementsByTagName.get_Item(i).GetAttribute("value") == "Log in"))
				{
					continue;
				}
				elementsByTagName.get_Item(i).InvokeMember("click");
				break;
			}
			catch (Exception)
			{
			}
		}
		if (i != elementsByTagName.get_Count())
		{
			now = DateTime.Now;
			while (true)
			{
				htmlDocument_0 = webBrowser_0.get_Document();
				if (Class0.form1_0.bool_0)
				{
					Application.DoEvents();
					long num = (long)(DateTime.Now - now).TotalSeconds;
					if (num > int.Parse(Class0.form1_0.string_3))
					{
						break;
					}
					if (num <= 8L || htmlDocument_0 == (HtmlDocument)null)
					{
						continue;
					}
					HtmlElement body = htmlDocument_0.get_Body();
					if (body == (HtmlElement)null || body.get_InnerText() == null)
					{
						continue;
					}
					if (body.get_OuterHtml().IndexOf("You are not logged in") < 0)
					{
						if (body.get_OuterHtml().IndexOf("Welcome") < 0)
						{
							if (body.get_OuterHtml().IndexOf("Thank you for logging in") < 0)
							{
								if (body.get_OuterHtml().IndexOf("You last visited") < 0 && body.get_OuterHtml().IndexOf("Edit Profile") < 0)
								{
									if ((int)webBrowser_0.get_ReadyState() != 4 || body.get_OuterHtml().IndexOf("Thank you for logging in") >= 0 || body.get_OuterHtml().IndexOf("You last visited") >= 0 || body.get_OuterHtml().IndexOf("Welcome") >= 0)
									{
										continue;
									}
									return false;
								}
								return true;
							}
							HtmlElementCollection elementsByTagName2 = htmlDocument_0.GetElementsByTagName("a");
							i = 0;
							while (true)
							{
								if (i < elementsByTagName2.get_Count())
								{
									if (elementsByTagName2.get_Item(i).get_InnerText().IndexOf("Click here if your browser does not automatically redirect you") >= 0)
									{
										break;
									}
									i++;
									continue;
								}
								return true;
							}
							elementsByTagName2.get_Item(i).InvokeMember("click");
							return true;
						}
						return true;
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

using System;
using System.Windows.Forms;

namespace LoginSendMessagePowerByVBulletin;

public class GClass0
{
	private HtmlDocument htmlDocument_0;

	private WebBrowser webBrowser_0;

	private string string_0;

	public GClass0()
	{
		webBrowser_0 = Class0.form1_0.webBrowser1;
	}

	public bool method_0(string string_1)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Invalid comparison between Unknown and I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Invalid comparison between Unknown and I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Invalid comparison between Unknown and I4
		string_0 = string_1;
		webBrowser_0.Navigate(string_1);
		DateTime now = DateTime.Now;
		while (true)
		{
			htmlDocument_0 = webBrowser_0.get_Document();
			if (Class0.form1_0.bool_0)
			{
				Application.DoEvents();
				long num = (long)(DateTime.Now - now).TotalSeconds;
				if (num > int.Parse(Class0.form1_0.string_4))
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
				if (body.get_OuterHtml().IndexOf("newreply.php?do=newreply&amp;noquote=1") < 0)
				{
					if (body.get_OuterHtml().IndexOf("No Thread specified. If you followed a valid link, please notify the administrator") < 0 && body.get_OuterHtml().IndexOf("vBulletin Message") < 0)
					{
						if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("newreply.php?do=newreply&amp;noquote=1") < 0)
						{
							return false;
						}
						continue;
					}
					return false;
				}
				HtmlElementCollection images = htmlDocument_0.get_Images();
				int i;
				for (i = 0; i < images.get_Count(); i++)
				{
					if (images.get_Item(i).GetAttribute("alt") == "Reply With Quote")
					{
						images.get_Item(i).InvokeMember("click");
						break;
					}
				}
				if (i != images.get_Count())
				{
					now = DateTime.Now;
					while (true)
					{
						htmlDocument_0 = webBrowser_0.get_Document();
						if (!Class0.form1_0.bool_0)
						{
							break;
						}
						Application.DoEvents();
						num = (long)(DateTime.Now - now).TotalSeconds;
						if (num <= int.Parse(Class0.form1_0.string_4))
						{
							if (num <= 8L || htmlDocument_0 == (HtmlDocument)null)
							{
								continue;
							}
							body = htmlDocument_0.get_Body();
							if (body == (HtmlElement)null || body.get_InnerText() == null)
							{
								continue;
							}
							if (body.get_OuterHtml().IndexOf("Reply to Thread") < 0)
							{
								if (body.get_OuterHtml().IndexOf("vBulletin Message") < 0)
								{
									if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("Reply to Thread") < 0)
									{
										return false;
									}
									continue;
								}
								return false;
							}
							while (true)
							{
								if ((int)webBrowser_0.get_ReadyState() != 4)
								{
									if (!Class0.form1_0.bool_0)
									{
										break;
									}
									Application.DoEvents();
									num = (long)(DateTime.Now - now).TotalSeconds;
									if (num > int.Parse(Class0.form1_0.string_4))
									{
										return false;
									}
									continue;
								}
								if (method_1(Class0.form1_0.string_5, Class0.form1_0.string_6))
								{
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
				return false;
			}
			return false;
		}
		return false;
	}

	public bool method_1(string string_1, string string_2)
	{
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Invalid comparison between Unknown and I4
		HtmlElementCollection elementsByTagName = htmlDocument_0.GetElementsByTagName("input");
		int i = 0;
		if (string_1.Trim() != "")
		{
			for (i = 0; i < elementsByTagName.get_Count(); i++)
			{
				if (elementsByTagName.get_Item(i).GetAttribute("name").IndexOf("title") >= 0)
				{
					elementsByTagName.get_Item(i).SetAttribute("value", string_1);
					break;
				}
			}
		}
		if (i != elementsByTagName.get_Count())
		{
			try
			{
				htmlDocument_0.get_Window().get_Frames().get_Item("vB_Editor_001_iframe")
					.get_Document()
					.get_Body()
					.set_InnerHtml(htmlDocument_0.get_Window().get_Frames().get_Item("vB_Editor_001_iframe")
						.get_Document()
						.get_Body()
						.get_InnerHtml() + "\r\n<p>" + string_2 + "</p>");
			}
			catch (Exception)
			{
				elementsByTagName = htmlDocument_0.GetElementsByTagName("textarea");
				for (i = 0; i < elementsByTagName.get_Count(); i++)
				{
					if (elementsByTagName.get_Item(i).GetAttribute("name").IndexOf("message") >= 0)
					{
						elementsByTagName.get_Item(i).set_InnerText(elementsByTagName.get_Item(i).get_InnerText() + "\r\n" + string_2);
						break;
					}
				}
				if (i == elementsByTagName.get_Count())
				{
					return false;
				}
			}
			elementsByTagName = htmlDocument_0.GetElementsByTagName("input");
			for (i = 0; i < elementsByTagName.get_Count(); i++)
			{
				if (elementsByTagName.get_Item(i).GetAttribute("name").IndexOf("sbutton") >= 0)
				{
					elementsByTagName.get_Item(i).InvokeMember("click");
					break;
				}
			}
			if (i != elementsByTagName.get_Count())
			{
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
					if (num <= int.Parse(Class0.form1_0.string_4))
					{
						if (num <= 5L || htmlDocument_0 == (HtmlDocument)null)
						{
							continue;
						}
						HtmlElement body = htmlDocument_0.get_Body();
						if (!(body == (HtmlElement)null) && body.get_InnerText() != null)
						{
							if (body.get_OuterHtml().IndexOf(Class0.form1_0.string_2) >= 0)
							{
								return true;
							}
							if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf(string_1) < 0)
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

using System;
using System.Windows.Forms;

namespace EditSignaturePoweredbyVBulletin;

public class GClass1
{
	private HtmlDocument htmlDocument_0;

	private WebBrowser webBrowser_0;

	private string string_0;

	public GClass1()
	{
		webBrowser_0 = Class0.form1_0.webBrowser1;
	}

	public bool method_0(string string_1)
	{
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Invalid comparison between Unknown and I4
		string_0 = string_1;
		webBrowser_0.Navigate(string_1);
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
				if (body == (HtmlElement)null || body.get_InnerText() == null)
				{
					continue;
				}
				if (body.get_OuterHtml().IndexOf("Edit Signature") < 0 && body.get_OuterHtml().IndexOf("Your Signature") < 0)
				{
					if (body.get_OuterHtml().IndexOf("vBulletin Message") < 0)
					{
						if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("Edit Signature") < 0 && body.get_OuterHtml().IndexOf("Your Signature") < 0)
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
						if (num > int.Parse(Class0.form1_0.string_3))
						{
							return false;
						}
						continue;
					}
					int num2 = 0;
					HtmlElementCollection elementsByTagName;
					try
					{
						htmlDocument_0.get_Window().get_Frames().get_Item("vB_Editor_001_iframe")
							.get_Document()
							.get_Body()
							.set_InnerHtml("<p>" + Class0.form1_0.string_4 + "</p>");
					}
					catch (Exception)
					{
						elementsByTagName = htmlDocument_0.GetElementsByTagName("textarea");
						for (num2 = 0; num2 < elementsByTagName.get_Count(); num2++)
						{
							if (elementsByTagName.get_Item(num2).GetAttribute("name").IndexOf("message") >= 0)
							{
								elementsByTagName.get_Item(num2).set_InnerText(Class0.form1_0.string_4);
								break;
							}
						}
						if (num2 == elementsByTagName.get_Count())
						{
							return false;
						}
					}
					string text = webBrowser_0.get_Url().ToString();
					elementsByTagName = htmlDocument_0.GetElementsByTagName("input");
					for (num2 = 0; num2 < elementsByTagName.get_Count(); num2++)
					{
						if (elementsByTagName.get_Item(num2).GetAttribute("value").IndexOf("Save Signature") >= 0)
						{
							elementsByTagName.get_Item(num2).InvokeMember("click");
							break;
						}
					}
					if (num2 != elementsByTagName.get_Count())
					{
						while (Class0.form1_0.bool_0)
						{
							Application.DoEvents();
							num = (long)(DateTime.Now - now).TotalSeconds;
							if (num <= int.Parse(Class0.form1_0.string_3))
							{
								if (text != webBrowser_0.get_Url().ToString())
								{
									return true;
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
			return false;
		}
		return false;
	}
}

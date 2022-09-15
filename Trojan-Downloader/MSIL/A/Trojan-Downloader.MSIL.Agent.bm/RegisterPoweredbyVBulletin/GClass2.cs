using System;
using System.Windows.Forms;

namespace RegisterPoweredbyVBulletin;

public class GClass2
{
	private WebBrowser webBrowser_0;

	private HtmlDocument htmlDocument_0;

	public bool bool_0;

	public GClass2(WebBrowser web)
	{
		webBrowser_0 = web;
	}

	public bool method_0(string string_0)
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Invalid comparison between Unknown and I4
		webBrowser_0.Navigate(string_0);
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
				if (num <= 4L || htmlDocument_0 == (HtmlDocument)null)
				{
					continue;
				}
				HtmlElement body = htmlDocument_0.get_Body();
				if (!(body == (HtmlElement)null) && body.get_InnerText() != null)
				{
					if (body.get_OuterHtml().IndexOf("Sorry! The administrator has disabled the list of members") >= 0)
					{
						return false;
					}
					if (body.get_OuterHtml().IndexOf("Page 1 of") >= 0 || body.get_OuterHtml().IndexOf("You are not logged in") >= 0)
					{
						return true;
					}
					if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("Page 1 of") < 0 && body.get_OuterHtml().IndexOf("You are not logged in") < 0)
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

	private bool method_1(string string_0)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		webBrowser_0.Navigate(string_0);
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
				if (num <= 8L || htmlDocument_0 == (HtmlDocument)null)
				{
					continue;
				}
				HtmlElement body = htmlDocument_0.get_Body();
				if (!(body == (HtmlElement)null) && body.get_InnerText() != null)
				{
					if (body.get_OuterHtml().IndexOf("Please Enter Your Date of Birth") >= 0)
					{
						bool_0 = true;
						return true;
					}
					if (body.get_OuterHtml().IndexOf("Rules") >= 0)
					{
						bool_0 = false;
						return true;
					}
					if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("Please Enter Your Date of Birth") < 0)
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

	public bool method_2(string string_0)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Invalid comparison between Unknown and I4
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Invalid comparison between Unknown and I4
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Invalid comparison between Unknown and I4
		if (method_1(string_0))
		{
			if (!bool_0)
			{
				try
				{
					htmlDocument_0.GetElementById("cb_rules_agree").SetAttribute("checked", "checked");
				}
				catch (Exception)
				{
					return false;
				}
				try
				{
					HtmlElementCollection elementsByTagName = htmlDocument_0.GetElementsByTagName("input");
					int i;
					for (i = 0; i < elementsByTagName.get_Count(); i++)
					{
						if (elementsByTagName.get_Item(i).GetAttribute("value") == "Register")
						{
							elementsByTagName.get_Item(i).InvokeMember("click");
							break;
						}
					}
					if (i != 0)
					{
						DateTime now = DateTime.Now;
						while (true)
						{
							htmlDocument_0 = webBrowser_0.get_Document();
							if (Class0.form1_0.bool_0)
							{
								Application.DoEvents();
								long num = (long)(DateTime.Now - now).TotalSeconds;
								if (num <= int.Parse(Class0.form1_0.string_4))
								{
									if (num <= 8L || htmlDocument_0 == (HtmlDocument)null)
									{
										continue;
									}
									HtmlElement body = htmlDocument_0.get_Body();
									if (!(body == (HtmlElement)null) && body.get_InnerText() != null)
									{
										if (body.get_OuterHtml().IndexOf("Complete Registration") >= 0)
										{
											break;
										}
										if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("Complete Registration") < 0)
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
						return true;
					}
					return false;
				}
				catch (Exception)
				{
					return false;
				}
			}
			try
			{
				HtmlElementCollection elementsByTagName2 = htmlDocument_0.GetElementsByTagName("select");
				int j;
				for (j = 0; j < elementsByTagName2.get_Count(); j++)
				{
					if (elementsByTagName2.get_Item(j).GetAttribute("name") == "month")
					{
						for (int k = 0; k < elementsByTagName2.get_Item(j).get_Children().get_Count(); k++)
						{
							if (elementsByTagName2.get_Item(j).get_Children().get_Item(k)
								.get_InnerText() == Class0.form1_0.string_6)
							{
								elementsByTagName2.get_Item(j).get_Children().get_Item(k)
									.SetAttribute("selected", "selected");
								break;
							}
						}
					}
					if (!(elementsByTagName2.get_Item(j).GetAttribute("name") == "day"))
					{
						continue;
					}
					for (int l = 0; l < elementsByTagName2.get_Item(j).get_Children().get_Count(); l++)
					{
						if (elementsByTagName2.get_Item(j).get_Children().get_Item(l)
							.get_InnerText() == Class0.form1_0.string_7)
						{
							elementsByTagName2.get_Item(j).get_Children().get_Item(l)
								.SetAttribute("selected", "selected");
							break;
						}
					}
				}
				if (j != 0)
				{
					elementsByTagName2 = htmlDocument_0.GetElementsByTagName("input");
					int m;
					for (m = 0; m < elementsByTagName2.get_Count(); m++)
					{
						if (elementsByTagName2.get_Item(m).GetAttribute("name") == "year")
						{
							elementsByTagName2.get_Item(m).SetAttribute("value", Class0.form1_0.string_5);
							break;
						}
					}
					if (m == 0)
					{
						return false;
					}
					elementsByTagName2 = htmlDocument_0.GetElementsByTagName("input");
					int n;
					for (n = 0; n < elementsByTagName2.get_Count(); n++)
					{
						if (elementsByTagName2.get_Item(n).GetAttribute("value").Trim() == "Proceed")
						{
							elementsByTagName2.get_Item(n).InvokeMember("click");
							break;
						}
					}
					if (n == 0)
					{
						return false;
					}
					DateTime now2 = DateTime.Now;
					while (true)
					{
						htmlDocument_0 = webBrowser_0.get_Document();
						if (Class0.form1_0.bool_0)
						{
							Application.DoEvents();
							long num2 = (long)(DateTime.Now - now2).TotalSeconds;
							if (num2 > int.Parse(Class0.form1_0.string_4))
							{
								break;
							}
							if (num2 <= 8L || htmlDocument_0 == (HtmlDocument)null)
							{
								continue;
							}
							HtmlElement body2 = htmlDocument_0.get_Body();
							if (body2 == (HtmlElement)null || body2.get_InnerText() == null)
							{
								continue;
							}
							if (body2.get_OuterHtml().IndexOf("Rules") < 0)
							{
								if ((int)webBrowser_0.get_ReadyState() == 4 && body2.get_OuterHtml().IndexOf("Rules") < 0)
								{
									return false;
								}
								continue;
							}
							htmlDocument_0.GetElementById("cb_rules_agree").SetAttribute("checked", "checked");
							elementsByTagName2 = htmlDocument_0.GetElementsByTagName("input");
							int num3;
							for (num3 = 0; num3 < elementsByTagName2.get_Count(); num3++)
							{
								if (elementsByTagName2.get_Item(num3).GetAttribute("value") == "Register")
								{
									elementsByTagName2.get_Item(num3).InvokeMember("click");
									break;
								}
							}
							if (num3 == 0)
							{
								return false;
							}
							now2 = DateTime.Now;
							while (true)
							{
								htmlDocument_0 = webBrowser_0.get_Document();
								if (!Class0.form1_0.bool_0)
								{
									break;
								}
								Application.DoEvents();
								long num4 = (long)(DateTime.Now - now2).TotalSeconds;
								if (num4 <= int.Parse(Class0.form1_0.string_4))
								{
									if (num4 <= 8L || htmlDocument_0 == (HtmlDocument)null)
									{
										continue;
									}
									HtmlElement body3 = htmlDocument_0.get_Body();
									if (!(body3 == (HtmlElement)null) && body3.get_InnerText() != null)
									{
										if (body3.get_OuterHtml().IndexOf("Complete Registration") >= 0)
										{
											return true;
										}
										if ((int)webBrowser_0.get_ReadyState() == 4 && body3.get_OuterHtml().IndexOf("Complete Registration") < 0)
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
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return false;
	}
}

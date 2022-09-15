using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegisterPoweredbyVBulletin;

public class GClass1
{
	private HtmlDocument htmlDocument_0;

	private WebBrowser webBrowser_0;

	private string string_0;

	public bool bool_0 = true;

	public string string_1;

	public string string_2;

	public bool bool_1;

	public GClass1()
	{
		webBrowser_0 = Class0.form1_0.webBrowser1;
		string_0 = webBrowser_0.get_Url().ToString();
	}

	public bool method_0()
	{
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		htmlDocument_0 = webBrowser_0.get_Document();
		HtmlElement body = htmlDocument_0.get_Body();
		if (body.get_OuterHtml().IndexOf("NoSpam") >= 0 || body.get_OuterHtml().IndexOf("Spammers") >= 0 || body.get_OuterHtml().IndexOf("Additional Required Information") >= 0 || body.get_OuterHtml().IndexOf("Verification Question") >= 0 || body.get_OuterHtml().IndexOf("spamming robot") >= 0)
		{
			if (Class0.form1_0.bool_2)
			{
				return false;
			}
			bool_1 = true;
		}
		try
		{
			string_1 = Class0.form1_0.string_3;
			string_2 = Class0.form1_0.string_10;
			if (body.get_OuterHtml().IndexOf("imagereg") < 0 && body.get_OuterHtml().IndexOf("Image Verification") < 0)
			{
				HtmlElementCollection elementsByTagName = htmlDocument_0.GetElementsByTagName("input");
				int i;
				for (i = 0; i < elementsByTagName.get_Count(); i++)
				{
					if (elementsByTagName.get_Item(i).GetAttribute("name").IndexOf("username") >= 0)
					{
						elementsByTagName.get_Item(i).SetAttribute("value", Class0.form1_0.string_1);
					}
					if (elementsByTagName.get_Item(i).GetAttribute("name").IndexOf("password") >= 0)
					{
						elementsByTagName.get_Item(i).SetAttribute("value", Class0.form1_0.string_2);
					}
					if (elementsByTagName.get_Item(i).GetAttribute("name").IndexOf("passwordconfirm") >= 0)
					{
						elementsByTagName.get_Item(i).SetAttribute("value", Class0.form1_0.string_2);
					}
					if (elementsByTagName.get_Item(i).GetAttribute("name").IndexOf("email") >= 0)
					{
						elementsByTagName.get_Item(i).SetAttribute("value", string_1);
					}
					if (elementsByTagName.get_Item(i).GetAttribute("name").IndexOf("emailconfirm") >= 0)
					{
						elementsByTagName.get_Item(i).SetAttribute("value", string_1);
					}
				}
				if (i != 0)
				{
					if (bool_1)
					{
						return false;
					}
					int j;
					for (j = 0; j < elementsByTagName.get_Count(); j++)
					{
						try
						{
							if (elementsByTagName.get_Item(j).GetAttribute("value").IndexOf("Complete Registration") >= 0)
							{
								elementsByTagName.get_Item(j).InvokeMember("click");
								break;
							}
						}
						catch (Exception)
						{
						}
					}
					if (j != 0)
					{
						try
						{
							if (method_1())
							{
								return true;
							}
							return false;
						}
						catch (Exception)
						{
							return true;
						}
					}
					return false;
				}
				return false;
			}
			string text = "";
			try
			{
				text = htmlDocument_0.GetElementById("imagereg").GetAttribute("src");
			}
			catch (Exception)
			{
				HtmlElementCollection elementsByTagName2 = htmlDocument_0.GetElementsByTagName("img");
				int k;
				for (k = 0; k < elementsByTagName2.get_Count(); k++)
				{
					if (elementsByTagName2.get_Item(k).GetAttribute("src").IndexOf("image.php?type=") >= 0)
					{
						text = elementsByTagName2.get_Item(k).GetAttribute("src");
						break;
					}
				}
				if (k == elementsByTagName2.get_Count())
				{
					return false;
				}
			}
			string text2 = "";
			for (int l = 0; l < 10; l++)
			{
				GClass0 gClass = new GClass0();
				text2 = gClass.method_1(text);
				if (text2 != null && text2 != "" && text2.Length > 20)
				{
					break;
				}
			}
			Form2 form = new Form2();
			try
			{
				Image image = Image.FromFile(text2);
				form.pictureBox1.set_Image(image);
				((Form)form).ShowDialog();
			}
			catch (Exception)
			{
				return false;
			}
			try
			{
				htmlDocument_0.GetElementById("imagestamp").SetAttribute("value", form.string_0);
				((Form)form).Close();
			}
			catch (Exception)
			{
				return false;
			}
			HtmlElementCollection elementsByTagName3 = htmlDocument_0.GetElementsByTagName("input");
			int m;
			for (m = 0; m < elementsByTagName3.get_Count(); m++)
			{
				if (elementsByTagName3.get_Item(m).GetAttribute("name") == "username")
				{
					elementsByTagName3.get_Item(m).SetAttribute("value", Class0.form1_0.string_1);
				}
				if (elementsByTagName3.get_Item(m).GetAttribute("name") == "password")
				{
					elementsByTagName3.get_Item(m).SetAttribute("value", Class0.form1_0.string_2);
				}
				if (elementsByTagName3.get_Item(m).GetAttribute("name") == "passwordconfirm")
				{
					elementsByTagName3.get_Item(m).SetAttribute("value", Class0.form1_0.string_2);
				}
				if (elementsByTagName3.get_Item(m).GetAttribute("name").IndexOf("email") >= 0)
				{
					elementsByTagName3.get_Item(m).SetAttribute("value", string_1);
				}
				if (elementsByTagName3.get_Item(m).GetAttribute("name").IndexOf("emailconfirm") >= 0)
				{
					elementsByTagName3.get_Item(m).SetAttribute("value", string_1);
				}
			}
			if (m != 0)
			{
				if (!bool_1)
				{
					int n;
					for (n = 0; n < elementsByTagName3.get_Count(); n++)
					{
						try
						{
							if (elementsByTagName3.get_Item(n).GetAttribute("value").IndexOf("Complete Registration") >= 0)
							{
								elementsByTagName3.get_Item(n).InvokeMember("click");
								break;
							}
						}
						catch (Exception)
						{
						}
					}
					if (n == 0)
					{
						return false;
					}
					if (!method_1())
					{
						return false;
					}
					return true;
				}
				return false;
			}
			return false;
		}
		catch (Exception ex7)
		{
			MessageBox.Show(ex7.Message);
			return false;
		}
	}

	public bool method_1()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
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
					if (body.get_OuterHtml().IndexOf("That username is already") >= 0)
					{
						MessageBox.Show("That username is already in use or does not meet the administrator's standards!");
						return false;
					}
					if (body.get_OuterHtml().IndexOf("The email address you entered is already in use") >= 0)
					{
						MessageBox.Show("The email address you entered is already in use");
						return false;
					}
					if (body.get_OuterHtml().IndexOf("activate your account") >= 0)
					{
						bool_0 = true;
						return true;
					}
					if (body.get_OuterHtml().IndexOf("An email has been dispatched") >= 0)
					{
						bool_0 = true;
						return true;
					}
					if (body.get_OuterHtml().IndexOf("Your registration is now complete") >= 0)
					{
						bool_0 = false;
						return true;
					}
					if (body.get_OuterHtml().IndexOf("string you entered for the image verification did not match what was displayed") >= 0)
					{
						MessageBox.Show("string you entered for the image verification did not match what was displayed!");
						method_0();
						return true;
					}
					if ((int)webBrowser_0.get_ReadyState() == 4 && body.get_OuterHtml().IndexOf("An email has been dispatched") < 0 && body.get_OuterHtml().IndexOf("Your registration is now complete") < 0)
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
}

using System.Collections;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class243
{
	private static string string_0 = "text";

	private static string string_1 = "body";

	public static Class261 smethod_0(string string_2)
	{
		StringBuilder stringBuilder = new StringBuilder(string_2.Length);
		Class261 @class = new Class261();
		@class.bool_2 = false;
		Class245 class2 = @class;
		Stack stack = new Stack();
		stack.Push(@class);
		string_2 = string_2.Replace("&nbsp;", "{ent_nbsp}");
		string_2 = string_2.Replace("&lt;", "{ent_lt}");
		string_2 = string_2.Replace("&gt;", "{ent_gt}");
		string_2 = string_2.Replace("&amp;", "{ent_amp}");
		string_2 = string_2.Replace("|", "{ent_l}");
		string_2 = string_2.Replace("&", "|");
		string_2 = string_2.Replace("{ent_nbsp}", "&nbsp;");
		string_2 = string_2.Replace("{ent_lt}", "&lt;");
		string_2 = string_2.Replace("{ent_gt}", "&gt;");
		StringReader input = new StringReader("<" + string_1 + ">" + string_2 + "</" + string_1 + ">");
		try
		{
			XmlTextReader xmlTextReader = new XmlTextReader(input);
			while (xmlTextReader.Read())
			{
				if (xmlTextReader.NodeType == XmlNodeType.Element)
				{
					if (xmlTextReader.Name == string_1)
					{
						continue;
					}
					Class245 class3 = smethod_1(xmlTextReader.Name);
					if (class3 == null)
					{
						xmlTextReader.Skip();
						continue;
					}
					if (class3 is Class252)
					{
						@class.bool_2 = true;
					}
					if (class3 is Interface4)
					{
						@class.Class244_0.method_0(class3);
					}
					if (xmlTextReader.AttributeCount > 0)
					{
						class3.ReadAttributes(xmlTextReader);
					}
					class2.Elements.method_0(class3);
					if (class3 is Class256)
					{
						class2 = class3;
					}
					if (!xmlTextReader.IsEmptyElement)
					{
						stack.Push(class3);
					}
				}
				else if (xmlTextReader.NodeType == XmlNodeType.Text)
				{
					if (xmlTextReader.Value.Length == 1)
					{
						Class254 class4 = smethod_1(string_0) as Class254;
						if (xmlTextReader.Value == " ")
						{
							class4.Boolean_0 = true;
							stringBuilder.Append(' ');
						}
						else
						{
							class4.String_0 = xmlTextReader.Value;
							class4.String_0 = class4.String_0.Replace("|", "&");
							class4.String_0 = class4.String_0.Replace("{ent_l}", "|");
							class4.String_0 = class4.String_0.Replace("{ent_amp}", "&&");
							stringBuilder.Append(class4.String_0 + " ");
						}
						class2.Elements.method_0(class4);
						continue;
					}
					string text = xmlTextReader.Value;
					if (text.StartsWith("\r\n"))
					{
						text = text.TrimStart('\r', '\n');
					}
					text = text.Replace("\r\n", " ");
					string[] array = text.Split(new char[1] { ' ' });
					bool flag = false;
					if (class2.Elements.Count > 0 && class2.Elements[class2.Elements.Count - 1] is Class253)
					{
						flag = true;
					}
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i].Length == 0)
						{
							if (flag)
							{
								continue;
							}
							flag = true;
						}
						else
						{
							flag = false;
						}
						Class254 class5 = smethod_1(string_0) as Class254;
						class5.String_0 = array[i].Replace("|", "&");
						class5.String_0 = class5.String_0.Replace("{ent_l}", "|");
						class5.String_0 = class5.String_0.Replace("{ent_amp}", "&&");
						stringBuilder.Append(class5.String_0 + " ");
						if (i < array.Length - 1)
						{
							class5.Boolean_0 = true;
							flag = true;
						}
						class2.Elements.method_0(class5);
					}
				}
				else if (xmlTextReader.NodeType == XmlNodeType.Whitespace)
				{
					if (xmlTextReader.Value.IndexOf(' ') >= 0)
					{
						Class254 class6 = smethod_1(string_0) as Class254;
						class6.Boolean_0 = true;
						class2.Elements.method_0(class6);
					}
				}
				else if (xmlTextReader.NodeType == XmlNodeType.EntityReference)
				{
					Class254 class7 = smethod_1(string_0) as Class254;
					if (xmlTextReader.Name == "nbsp")
					{
						class7.Boolean_0 = true;
					}
					else
					{
						class7.String_0 = xmlTextReader.Name;
					}
					class7.Boolean_1 = false;
					class2.Elements.method_0(class7);
				}
				else if (xmlTextReader.NodeType == XmlNodeType.EndElement)
				{
					Class245 class8 = stack.Pop() as Class245;
					if (class8 != class2)
					{
						class2.Elements.method_0(new Class255(class8));
					}
					else if (class2 != @class)
					{
						class2 = class2.Parent;
					}
				}
			}
		}
		catch
		{
			return null;
		}
		@class.string_0 = stringBuilder.ToString();
		return @class;
	}

	public static Class245 smethod_1(string string_2)
	{
		switch (string_2)
		{
		case "u":
			return new Class250();
		case "br":
			return new Class253();
		case "expand":
			return new Class252();
		case "a":
			return new Class262();
		case "p":
			return new Class260();
		case "div":
			return new Class258();
		case "span":
			return new Class259();
		case "img":
			return new Class251();
		case "h1":
			return new Class257();
		case "h2":
			return new Class257(2);
		case "h3":
			return new Class257(3);
		case "h4":
			return new Class257(4);
		case "h5":
			return new Class257(5);
		case "h6":
			return new Class257(6);
		case "font":
			return new Class247();
		default:
			if (string_2 == string_0)
			{
				return new Class254();
			}
			return null;
		case "i":
		case "em":
			return new Class249();
		case "b":
		case "strong":
			return new Class248();
		}
	}

	public static bool smethod_2(ref string string_2)
	{
		if (string_2.IndexOf("</") < 0 && string_2.IndexOf("/>") < 0)
		{
			return false;
		}
		return true;
	}

	internal static string smethod_3(string string_2)
	{
		return Regex.Replace(string_2, "<expand.*?>", "", RegexOptions.IgnoreCase);
	}
}

using System;
using System.Collections;
using System.Xml;

internal class Class18
{
	public string string_0;

	public TimeSpan timeSpan_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public double double_0;

	public bool bool_0;

	public TimeSpan timeSpan_1;

	public TimeSpan timeSpan_2;

	public TimeSpan timeSpan_3;

	public DateTime dateTime_0;

	public Class19[] class19_0;

	public Class23 class23_0;

	public Class11 class11_0;

	public Class18(Class23 class23_1)
	{
		double_0 = 0.25;
		bool_0 = true;
		base._002Ector();
		class23_0 = class23_1;
	}

	public Class18(Class23 class23_1, XmlNode xmlNode_0)
	{
		if (Class50.hashtable_5 == null)
		{
			Class50.hashtable_5 = new Hashtable(24, 0.5f)
			{
				{ "Name", 0 },
				{ "DwellTime", 1 },
				{ "TypeInRatio", 2 },
				{ "Enabled", 3 },
				{ "MinimumHostVisitSeparation", 4 },
				{ "MinimumAccountVisitSeparation", 5 },
				{ "MinimumSiteVisitSeparation", 6 },
				{ "SuccessCount", 7 },
				{ "FailureCount", 8 },
				{ "LastVisitDate", 9 },
				{ "PageProcessingInfo", 10 },
				{ "Program", 11 }
			};
		}
		double_0 = 0.25;
		bool_0 = true;
		base._002Ector();
		class23_0 = class23_1;
		ArrayList arrayList = new ArrayList();
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (GClass1.smethod_2(childNode))
			{
				continue;
			}
			try
			{
				object name;
				if ((name = childNode.Name) != null && (name = Class50.hashtable_5[name]) != null)
				{
					switch ((int)name)
					{
					case 0:
						string_0 = childNode.InnerText;
						break;
					case 1:
						timeSpan_0 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromSeconds(10.0));
						break;
					case 2:
						double_0 = GClass1.smethod_4(childNode.InnerText, double_0);
						break;
					case 3:
						bool_0 = GClass1.smethod_5(childNode.InnerText, bool_0: true);
						break;
					case 4:
						timeSpan_1 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromMinutes(2.0));
						break;
					case 5:
						timeSpan_2 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromMinutes(5.0));
						break;
					case 6:
						timeSpan_3 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromHours(2.0));
						break;
					case 7:
						int_0 = GClass1.smethod_3(childNode.InnerText, 0);
						break;
					case 8:
						int_1 = GClass1.smethod_3(childNode.InnerText, 0);
						break;
					case 9:
						dateTime_0 = GClass1.smethod_7(childNode.InnerText, DateTime.MinValue);
						break;
					case 10:
						arrayList.Add(new Class19(this, childNode));
						break;
					case 11:
						class11_0 = class23_0.class12_0.method_3(childNode);
						break;
					}
				}
			}
			catch (Exception exception_)
			{
				class23_0.method_13(exception_);
			}
		}
		class19_0 = arrayList.ToArray(typeof(Class19)) as Class19[];
	}

	public void method_0(XmlWriter xmlWriter_0, bool bool_1)
	{
		xmlWriter_0.WriteStartElement("AdHost");
		xmlWriter_0.WriteElementString("Name", string_0);
		if (bool_1)
		{
			xmlWriter_0.WriteElementString("DwellTime", timeSpan_0.ToString());
			xmlWriter_0.WriteElementString("Enabled", bool_0.ToString());
			xmlWriter_0.WriteElementString("TypeInRatio", double_0.ToString());
			xmlWriter_0.WriteElementString("MinimumHostVisitSeparation", timeSpan_1.ToString());
			xmlWriter_0.WriteElementString("MinimumAccountVisitSeparation", timeSpan_2.ToString());
			xmlWriter_0.WriteElementString("MinimumSiteVisitSeparation", timeSpan_3.ToString());
			Class19[] array = class19_0;
			foreach (Class19 @class in array)
			{
				@class.method_1(xmlWriter_0);
			}
			if (class11_0 != null)
			{
				class11_0.vmethod_0(xmlWriter_0);
			}
			else
			{
				class23_0.method_15(null, string_0, null, null, -1, null, $"Host {string_0} does not have a processing program.");
			}
		}
		xmlWriter_0.WriteElementString("SuccessCount", int_0.ToString());
		xmlWriter_0.WriteElementString("FailureCount", int_1.ToString());
		xmlWriter_0.WriteElementString("ClickthroughCount", int_2.ToString());
		xmlWriter_0.WriteElementString("LastVisitDate", GClass1.smethod_8(dateTime_0));
		xmlWriter_0.WriteEndElement();
	}
}

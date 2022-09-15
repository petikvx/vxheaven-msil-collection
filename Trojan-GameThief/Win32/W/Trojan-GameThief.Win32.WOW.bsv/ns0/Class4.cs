using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace ns0;

internal class Class4
{
	private const string string_0 = "http://schemas.xmlsoap.org/soap/envelope/";

	private const string string_1 = "http://www.wowsharp.net/WoW_Web/";

	internal static Class5 smethod_0(string string_2, string string_3, string string_4, int int_0, int int_1, int int_2, int int_3)
	{
		MemoryStream memoryStream = new MemoryStream();
		XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("soap", "Envelope", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextWriter.WriteStartElement("soap", "Body", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextWriter.WriteStartElement("", "Login", "http://www.wowsharp.net/WoW_Web/");
		xmlTextWriter.WriteStartElement("username");
		xmlTextWriter.WriteString(string_2);
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteStartElement("md5password");
		xmlTextWriter.WriteString(string_3);
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteStartElement("application");
		xmlTextWriter.WriteString(string_4);
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteStartElement("wow_major");
		xmlTextWriter.WriteString(int_0.ToString());
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteStartElement("wow_minor");
		xmlTextWriter.WriteString(int_1.ToString());
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteStartElement("wow_revision");
		xmlTextWriter.WriteString(int_2.ToString());
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteStartElement("wow_build");
		xmlTextWriter.WriteString(int_3.ToString());
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndDocument();
		xmlTextWriter.Flush();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.wowsharp.net/wow_web/wow_service.asmx");
		httpWebRequest.ProtocolVersion = HttpVersion.Version11;
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentLength = memoryStream.Length;
		httpWebRequest.ContentType = "text/xml; charset=utf-8";
		httpWebRequest.Headers.Add("SOAPAction", "http://www.wowsharp.net/WoW_Web/Login");
		Stream requestStream = httpWebRequest.GetRequestStream();
		memoryStream.WriteTo(requestStream);
		requestStream.Close();
		memoryStream.Close();
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		XmlTextReader xmlTextReader = new XmlTextReader(httpWebResponse.GetResponseStream());
		Class5 @class = new Class5();
		xmlTextReader.ReadStartElement("Envelope", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextReader.ReadStartElement("Body", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextReader.ReadStartElement("LoginResponse", "http://www.wowsharp.net/WoW_Web/");
		xmlTextReader.ReadStartElement("LoginResult");
		xmlTextReader.ReadStartElement("OK");
		@class.bool_0 = bool.Parse(xmlTextReader.ReadString());
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadStartElement("Response");
		@class.string_0 = xmlTextReader.ReadString();
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadStartElement("SessionID");
		ref Guid guid_ = ref @class.guid_0;
		guid_ = new Guid(xmlTextReader.ReadString());
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.Close();
		return @class;
	}

	private static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream2 = new MemoryStream(byte_0);
		byte[] array = new byte[24];
		byte[] array2 = new byte[8];
		for (int i = 0; i < 24; i++)
		{
			array[i] = byte_1[i * 2];
		}
		for (int j = 0; j < 8; j++)
		{
			array2[j] = byte_1[j * 6 + 1];
		}
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = array;
		tripleDESCryptoServiceProvider.IV = array2;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
		memoryStream2.WriteTo(cryptoStream);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	internal static void smethod_2(Guid guid_0, string string_2, Hashtable hashtable_0, byte[] byte_0)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"http://www.wowsharp.net/{string_2}.aspx?session={guid_0}");
		httpWebRequest.ProtocolVersion = HttpVersion.Version11;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		byte[] array = new byte[httpWebResponse.ContentLength];
		responseStream.Read(array, 0, (int)httpWebResponse.ContentLength);
		MemoryStream stream = new MemoryStream(smethod_1(array, byte_0));
		StreamReader streamReader = new StreamReader(stream);
		while (streamReader.Peek() != -1)
		{
			string text = streamReader.ReadLine();
			if (!(text == ""))
			{
				string[] array2 = text.Split(new char[1] { '|' });
				hashtable_0.Add(array2[0], int.Parse(array2[1]));
			}
		}
	}

	internal static int smethod_3(Guid guid_0, string string_2)
	{
		MemoryStream memoryStream = new MemoryStream();
		XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("soap", "Envelope", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextWriter.WriteStartElement("soap", "Body", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextWriter.WriteStartElement("", "GetPointer", "http://www.wowsharp.net/WoW_Web/");
		xmlTextWriter.WriteStartElement("sessionid");
		xmlTextWriter.WriteString(guid_0.ToString());
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteStartElement("pointername");
		xmlTextWriter.WriteString(string_2);
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndDocument();
		xmlTextWriter.Flush();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.wowsharp.net/wow_web/wow_service.asmx");
		httpWebRequest.ProtocolVersion = HttpVersion.Version11;
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentLength = memoryStream.Length;
		httpWebRequest.ContentType = "text/xml; charset=utf-8";
		httpWebRequest.Headers.Add("SOAPAction", "http://www.wowsharp.net/WoW_Web/GetPointer");
		Stream requestStream = httpWebRequest.GetRequestStream();
		memoryStream.WriteTo(requestStream);
		requestStream.Close();
		memoryStream.Close();
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		XmlTextReader xmlTextReader = new XmlTextReader(httpWebResponse.GetResponseStream());
		xmlTextReader.ReadStartElement("Envelope", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextReader.ReadStartElement("Body", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextReader.ReadStartElement("GetPointerResponse", "http://www.wowsharp.net/WoW_Web/");
		xmlTextReader.ReadStartElement("GetPointerResult");
		int result = int.Parse(xmlTextReader.ReadString());
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.Close();
		return result;
	}

	internal static int smethod_4(Guid guid_0, string string_2)
	{
		MemoryStream memoryStream = new MemoryStream();
		XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("soap", "Envelope", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextWriter.WriteStartElement("soap", "Body", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextWriter.WriteStartElement("", "GetOffset", "http://www.wowsharp.net/WoW_Web/");
		xmlTextWriter.WriteStartElement("sessionid");
		xmlTextWriter.WriteString(guid_0.ToString());
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteStartElement("offsetname");
		xmlTextWriter.WriteString(string_2);
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndDocument();
		xmlTextWriter.Flush();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.wowsharp.net/wow_web/wow_service.asmx");
		httpWebRequest.ProtocolVersion = HttpVersion.Version11;
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentLength = memoryStream.Length;
		httpWebRequest.ContentType = "text/xml; charset=utf-8";
		httpWebRequest.Headers.Add("SOAPAction", "http://www.wowsharp.net/WoW_Web/GetOffset");
		Stream requestStream = httpWebRequest.GetRequestStream();
		memoryStream.WriteTo(requestStream);
		requestStream.Close();
		memoryStream.Close();
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		XmlTextReader xmlTextReader = new XmlTextReader(httpWebResponse.GetResponseStream());
		xmlTextReader.ReadStartElement("Envelope", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextReader.ReadStartElement("Body", "http://schemas.xmlsoap.org/soap/envelope/");
		xmlTextReader.ReadStartElement("GetOffsetResponse", "http://www.wowsharp.net/WoW_Web/");
		xmlTextReader.ReadStartElement("GetOffsetResult");
		int result = int.Parse(xmlTextReader.ReadString());
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.ReadEndElement();
		xmlTextReader.Close();
		return result;
	}
}

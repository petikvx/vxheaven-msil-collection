using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace Absinthe;

public class LocalSettings
{
	private const string _SettingsFile = "/Absinthe-config.xml";

	private string _SettingsFullPath;

	private Hashtable _ProxyTable;

	private int _ProxyPort = 8080;

	private string _ProxyAddress;

	private bool _ProxyInUse = false;

	public Queue ProxyQueue
	{
		get
		{
			if (_ProxyInUse)
			{
				Queue queue = new Queue();
				{
					foreach (string key in _ProxyTable.Keys)
					{
						WebProxy obj = new WebProxy(key, (int)_ProxyTable[key]);
						queue.Enqueue(obj);
					}
					return queue;
				}
			}
			return null;
		}
	}

	public bool ProxyInUse => _ProxyInUse;

	public LocalSettings()
	{
		_SettingsFullPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Absinthe-config.xml";
		LoadSettings();
	}

	private void LoadSettings()
	{
		if (!File.Exists(_SettingsFullPath))
		{
			return;
		}
		FileStream fileStream = null;
		XmlDocument xmlDocument = new XmlDocument();
		try
		{
			fileStream = File.OpenRead(_SettingsFullPath);
			xmlDocument.Load(new XmlTextReader(fileStream));
			XmlNode documentElement = xmlDocument.DocumentElement;
			_ProxyTable = new Hashtable();
			foreach (XmlNode childNode in documentElement.ChildNodes)
			{
				if (childNode.Name.Equals("proxy"))
				{
					ReadProxyXml(childNode);
				}
				else
				{
					if (!childNode.Name.Equals("proxies"))
					{
						continue;
					}
					foreach (XmlNode childNode2 in childNode.ChildNodes)
					{
						if (childNode2.Name.Equals("proxy"))
						{
							ReadProxyXml(childNode2);
						}
					}
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			fileStream.Close();
		}
	}

	private void ReadProxyXml(XmlNode n)
	{
		if (n.Attributes!["address"] == null || n.Attributes!["port"] == null)
		{
			return;
		}
		string innerText = n.Attributes!["address"]!.get_InnerText();
		int num = int.Parse(n.Attributes!["port"]!.get_InnerText());
		if (n.Attributes!["active"] != null)
		{
			if (bool.Parse(n.Attributes!["active"]!.get_InnerText()))
			{
				_ProxyInUse = true;
				_ProxyTable.Add(innerText, num);
			}
		}
		else
		{
			_ProxyInUse = true;
			_ProxyTable.Add(innerText, num);
		}
	}

	public void AddProxy(string ProxyAddress, int ProxyPort)
	{
		_ProxyTable.Add(ProxyAddress, ProxyPort);
		SaveSettings();
	}

	public void ClearProxies()
	{
		_ProxyTable.Clear();
	}

	private void GeneratePath()
	{
		if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)))
		{
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		}
	}

	private void SaveSettings()
	{
		GeneratePath();
		XmlTextWriter xmlTextWriter = new XmlTextWriter(_SettingsFullPath, Encoding.UTF8);
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.Indentation = 4;
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("squeal-settings");
		xmlTextWriter.WriteStartElement("proxies");
		xmlTextWriter.WriteStartAttribute("active", null);
		xmlTextWriter.WriteString(_ProxyInUse.ToString());
		xmlTextWriter.WriteEndAttribute();
		if (_ProxyTable.Count > 0)
		{
			foreach (string key in _ProxyTable.Keys)
			{
				string text2 = key;
				int num = (int)_ProxyTable[key];
				xmlTextWriter.WriteStartElement("proxy");
				xmlTextWriter.WriteStartAttribute("address", null);
				xmlTextWriter.WriteString(text2);
				xmlTextWriter.WriteEndAttribute();
				xmlTextWriter.WriteStartAttribute("port", null);
				xmlTextWriter.WriteString(num.ToString());
				xmlTextWriter.WriteEndAttribute();
				xmlTextWriter.WriteEndElement();
			}
		}
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndDocument();
		xmlTextWriter.Close();
	}
}

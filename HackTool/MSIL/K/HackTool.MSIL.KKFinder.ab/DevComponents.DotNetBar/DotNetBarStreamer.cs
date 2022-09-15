using System;
using System.Runtime.Serialization;
using System.Xml;

namespace DevComponents.DotNetBar;

[Serializable]
public sealed class DotNetBarStreamer : IDisposable, ISerializable
{
	private XmlDocument m_XmlDoc;

	private DotNetBarManager m_Owner;

	internal XmlDocument Data => m_XmlDoc;

	private DotNetBarStreamer()
	{
	}

	private DotNetBarStreamer(SerializationInfo info, StreamingContext c)
	{
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		do
		{
			if (!enumerator.MoveNext())
			{
				return;
			}
		}
		while (!(enumerator.Name == "dotnetbardata"));
		string xml = (string)enumerator.Value;
		m_XmlDoc = new XmlDocument();
		m_XmlDoc.LoadXml(xml);
	}

	public DotNetBarStreamer(DotNetBarManager owner)
	{
		m_Owner = owner;
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (m_Owner == null && m_XmlDoc == null)
		{
			return;
		}
		string assemblyName = info.AssemblyName;
		string[] array = assemblyName.Split(new char[1] { ',' });
		assemblyName = "";
		for (int i = 0; i < array.Length; i++)
		{
			if (!((string)array.GetValue(i)).ToLower().Trim().StartsWith("version"))
			{
				if (assemblyName != "")
				{
					assemblyName += ",";
				}
				assemblyName += array.GetValue(i);
			}
		}
		info.AssemblyName = assemblyName;
		if (m_Owner != null)
		{
			XmlDocument xmlDocument = new XmlDocument();
			m_Owner.SaveDefinition(xmlDocument);
			info.AddValue("dotnetbardata", xmlDocument.OuterXml);
		}
		else
		{
			info.AddValue("dotnetbardata", m_XmlDoc.OuterXml);
		}
	}

	void IDisposable.Dispose()
	{
		m_Owner = null;
	}
}

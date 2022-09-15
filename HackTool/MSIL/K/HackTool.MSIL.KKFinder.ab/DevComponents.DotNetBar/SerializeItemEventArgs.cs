using System;
using System.Xml;

namespace DevComponents.DotNetBar;

public class SerializeItemEventArgs : EventArgs
{
	public BaseItem Item;

	public XmlElement ItemXmlElement;

	public XmlElement CustomXmlElement;

	public SerializeItemEventArgs(BaseItem item, XmlElement itemXmlElement, XmlElement customXmlElement)
	{
		Item = item;
		ItemXmlElement = itemXmlElement;
		CustomXmlElement = customXmlElement;
	}
}

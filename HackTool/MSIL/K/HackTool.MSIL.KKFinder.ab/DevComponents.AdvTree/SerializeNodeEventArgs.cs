using System;
using System.Xml;

namespace DevComponents.AdvTree;

public class SerializeNodeEventArgs : EventArgs
{
	public Node Node;

	public XmlElement ItemXmlElement;

	public XmlElement CustomXmlElement;

	public SerializeNodeEventArgs(Node node, XmlElement itemXmlElement, XmlElement customXmlElement)
	{
		Node = node;
		ItemXmlElement = itemXmlElement;
		CustomXmlElement = customXmlElement;
	}
}

using System;
using System.Xml;

namespace DevComponents.DotNetBar;

public class ControlContainerSerializationEventArgs : EventArgs
{
	private readonly XmlElement xmlElement_0;

	public XmlElement XmlStorage => xmlElement_0;

	public ControlContainerSerializationEventArgs(XmlElement xmlstorage)
	{
		xmlElement_0 = xmlstorage;
	}
}

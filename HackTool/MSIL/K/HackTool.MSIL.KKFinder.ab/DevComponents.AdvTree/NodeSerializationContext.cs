using System.Xml;

namespace DevComponents.AdvTree;

public class NodeSerializationContext
{
	public XmlElement RefXmlElement;

	public bool HasSerializeNodeHandlers;

	public bool HasDeserializeNodeHandlers;

	public AdvTree AdvTree;
}

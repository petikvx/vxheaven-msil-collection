using System.Collections;
using System.ComponentModel.Design;
using System.Xml;

namespace DevComponents.DotNetBar;

public class ItemSerializationContext
{
	public XmlElement ItemXmlElement;

	public bool HasSerializeItemHandlers;

	public bool HasDeserializeItemHandlers;

	public ICustomSerialization Serializer;

	internal IDesignerHost idesignerHost_0;

	internal Hashtable hashtable_0;

	internal BaseItem method_0(XmlElement xmlElement_0)
	{
		if (idesignerHost_0 != null)
		{
			BaseItem baseItem = null;
			string text = "";
			if (xmlElement_0.HasAttribute("name"))
			{
				text = xmlElement_0.GetAttribute("name");
			}
			try
			{
				baseItem = Class109.smethod_19(xmlElement_0, idesignerHost_0, text);
			}
			catch
			{
			}
			if (baseItem == null)
			{
				baseItem = Class109.smethod_19(xmlElement_0, idesignerHost_0, "");
			}
			if (text != "")
			{
				baseItem.GlobalName = text;
			}
			return baseItem;
		}
		return Class109.smethod_18(xmlElement_0);
	}
}

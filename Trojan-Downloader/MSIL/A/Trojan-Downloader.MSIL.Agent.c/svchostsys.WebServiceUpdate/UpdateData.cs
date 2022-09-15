using System.Xml.Serialization;

namespace svchostsys.WebServiceUpdate;

[XmlType(Namespace = "http://tempuri.org/")]
public class UpdateData
{
	public string ProjectName;

	public string ExeName;

	public string ZipName;

	public int VersionNumber;

	public bool DoUpdate;
}

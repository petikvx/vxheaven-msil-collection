using System;

namespace DevComponents.DotNetBar;

[AttributeUsage(AttributeTargets.Assembly)]
public class DotNetBarResourcesAttribute : Attribute
{
	private string m_NamespacePrefix = "";

	public virtual string NamespacePrefix => m_NamespacePrefix;

	public DotNetBarResourcesAttribute(string namespacePrefix)
	{
		m_NamespacePrefix = namespacePrefix;
	}
}

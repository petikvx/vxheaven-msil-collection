using System.ComponentModel;

namespace DevComponents.AdvTree;

public class HeaderDefinition
{
	private string string_0 = "";

	private ColumnHeaderCollection columnHeaderCollection_0 = new ColumnHeaderCollection();

	[Category("Columns")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets the reference to the collection that contains the columns associated with header.")]
	public ColumnHeaderCollection Columns => columnHeaderCollection_0;

	[Description("Indicates name associated with this header definition.")]
	[DefaultValue("")]
	[Category("Design")]
	[Browsable(true)]
	public string Name
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}
}

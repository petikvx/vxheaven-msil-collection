using System;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Controls;

public class TreeConvertEventArgs : ConvertEventArgs
{
	private object object_0;

	private string string_0 = "";

	public object ListItem => object_0;

	public string FieldName => string_0;

	public TreeConvertEventArgs(object value, Type desiredType, object listItem, string fieldName)
		: base(value, desiredType)
	{
		object_0 = listItem;
		string_0 = fieldName;
	}
}

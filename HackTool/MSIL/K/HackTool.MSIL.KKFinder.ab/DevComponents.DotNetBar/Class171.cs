using System;

namespace DevComponents.DotNetBar;

internal class Class171
{
	public static string string_0 = "documents";

	public static string string_1 = "dockcontainer";

	public static string string_2 = "barcontainer";

	public static string string_3 = "orientation";

	public static string string_4 = "w";

	public static string string_5 = "h";

	public static string string_6 = "docksite";

	public static string string_7 = "dockingside";

	public static string string_8 = "size";

	public static string string_9 = "version";

	public static DocumentBaseContainer smethod_0(string string_10)
	{
		if (string_10 == string_1)
		{
			return new DocumentDockContainer();
		}
		if (!(string_10 == string_2))
		{
			throw new InvalidOperationException("Document type not recognized: " + string_10);
		}
		return new DocumentBarContainer();
	}
}

using System;
using System.ComponentModel.Design;

namespace DevComponents.AdvTree;

internal class Class25
{
	private IDesignerHost idesignerHost_0;

	public Class25(IDesignerHost designer)
	{
		idesignerHost_0 = designer;
	}

	public Class25()
	{
	}

	public object method_0(Type type_0)
	{
		object obj = null;
		if (idesignerHost_0 != null)
		{
			return idesignerHost_0.CreateComponent(type_0);
		}
		return type_0.Assembly.CreateInstance(type_0.FullName);
	}
}

using System;
using System.Collections;
using System.ComponentModel;

namespace DevComponents.DotNetBar.Controls;

internal class Class189 : EnumConverter
{
	public Class189(Type type)
		: base(type)
	{
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		StandardValuesCollection standardValues = base.GetStandardValues(context);
		ArrayList arrayList = new ArrayList();
		int count = standardValues.Count;
		for (int i = 0; i < count; i++)
		{
			if (!standardValues[i]!.ToString()!.Equals("ListItems"))
			{
				arrayList.Add(standardValues[i]);
			}
		}
		return new StandardValuesCollection(arrayList);
	}
}

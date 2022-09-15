using System;
using System.Collections;
using System.Reflection;
using System.Xml;

internal class Class8 : Class1
{
	public Class8()
	{
	}

	public Class8(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class8(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	protected void method_12(Class13 class13_0, Class14 class14_0, out Type[] type_0, out object[] object_0)
	{
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		for (Class1 @class = vmethod_5(0); @class != null; @class = @class.class1_0)
		{
			Type type = null;
			if (!(@class.string_0 == "ClrNull") && !(@class.string_0 == "ClrCastTo"))
			{
				if (@class.string_0 == "ClrToArray")
				{
					type = Type.GetType(Class14.smethod_2(@class.vmethod_1(class13_0, "type")) + "[]");
				}
			}
			else
			{
				type = Type.GetType(Class14.smethod_2(@class.vmethod_1(class13_0, "type")));
			}
			Class14 class2 = method_0(class13_0, class14_0, @class)[0];
			object obj = class2.method_40();
			if ((object)type == null)
			{
				type = ((obj != null) ? obj.GetType() : typeof(string));
			}
			arrayList2.Add(type);
			arrayList.Add(obj);
		}
		type_0 = arrayList2.ToArray(typeof(Type)) as Type[];
		object_0 = arrayList.ToArray();
	}

	protected void method_13(Class13 class13_0, out object object_0, out PropertyInfo propertyInfo_0, out object[] object_1)
	{
		Type type = null;
		Class14 @class = vmethod_2(class13_0, "object", null);
		object_0 = @class.method_40();
		if (object_0 == null)
		{
			string typeName = Class14.smethod_2(vmethod_1(class13_0, "type"));
			type = Type.GetType(typeName);
		}
		else
		{
			type = object_0.GetType();
		}
		propertyInfo_0 = type.GetProperty(string_1);
		@class = vmethod_2(class13_0, "index", null);
		if (@class != null)
		{
			string text = Class14.smethod_2(vmethod_2(class13_0, "indexSeparator", null));
			string text2 = Class14.smethod_2(vmethod_2(class13_0, "indexType", Class14.smethod_3("System.Int32")));
			string[] array = null;
			if (text != null)
			{
				@class = Class14.smethod_0(@class.System_002EObject_002EToString().Split(text.ToCharArray()));
				array = text2.Split(text.ToCharArray());
			}
			else
			{
				array = new string[1] { text2 };
			}
			int num = 0;
			int num2 = 0;
			Type type2 = Type.GetType(array[0]);
			object_1 = new object[@class.method_5()];
			do
			{
				object_1[num] = @class.method_25(num).method_39(type2);
				if (++num2 < array.Length && array[num2] != "")
				{
					type2 = Type.GetType(array[num2]);
				}
				num++;
			}
			while (num < @class.method_5());
		}
		else
		{
			object_1 = new object[0];
		}
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		if (Class50.hashtable_3 == null)
		{
			Class50.hashtable_3 = new Hashtable(34, 0.5f)
			{
				{ "ClrNull", 0 },
				{ "ClrNew", 1 },
				{ "ClrNewArray", 2 },
				{ "ClrCastTo", 3 },
				{ "ClrToArray", 4 },
				{ "ClrArrayItem", 5 },
				{ "ClrInvokeMethod", 6 },
				{ "ClrGetProperty", 7 },
				{ "ClrSetProperty", 8 },
				{ "ClrTypeOf", 9 },
				{ "ClrType", 10 },
				{ "ClrToString", 11 },
				{ "ClrToInt", 12 },
				{ "ClrToBool", 13 },
				{ "ClrToDouble", 14 },
				{ "ClrToDateTime", 15 },
				{ "ClrToTimeSpan", 16 }
			};
		}
		Class14 result = null;
		object key;
		if ((key = string_0) != null && (key = Class50.hashtable_3[key]) != null)
		{
			switch ((int)key)
			{
			case 1:
			{
				string typeName4 = Class14.smethod_2(vmethod_1(session, "type"));
				Type type4 = Type.GetType(typeName4);
				method_12(session, args, out var type_, out var object_);
				ConstructorInfo constructor = type4.GetConstructor(type_);
				result = new Class14(constructor.Invoke(object_));
				break;
			}
			case 2:
			{
				string typeName2 = Class14.smethod_2(vmethod_1(session, "type"));
				int length = GClass1.smethod_3(Class14.smethod_2(vmethod_1(session, "size")), -1);
				Type type2 = Type.GetType(typeName2);
				result = new Class14(Array.CreateInstance(type2, length));
				break;
			}
			case 3:
			{
				string typeName = Class14.smethod_2(vmethod_1(session, "type"));
				Type type = Type.GetType(typeName);
				Class14 class7 = method_1(session, args, 1, 1)[0];
				result = new Class14(class7.method_39(type));
				break;
			}
			case 4:
			{
				string typeName3 = Class14.smethod_2(vmethod_1(session, "type"));
				Type type3 = Type.GetType(typeName3);
				result = new Class14(method_1(session, args, 1, 1)[0].method_35(type3));
				break;
			}
			case 5:
			{
				Array array = vmethod_1(session, "array").method_40() as Array;
				result = new Class14(array.GetValue(GClass1.smethod_3(Class14.smethod_2(vmethod_1(session, "index")), -1)));
				break;
			}
			case 6:
			{
				Type type5 = null;
				object obj2 = vmethod_2(session, "object", null)?.method_40();
				if (obj2 == null)
				{
					string typeName5 = Class14.smethod_2(vmethod_1(session, "type"));
					type5 = Type.GetType(typeName5);
				}
				else
				{
					type5 = obj2.GetType();
				}
				method_12(session, args, out var type_2, out var object_6);
				MethodInfo method = type5.GetMethod(string_1, type_2);
				result = new Class14(method.Invoke(obj2, object_6));
				break;
			}
			case 7:
			{
				method_13(session, out var object_4, out var propertyInfo_2, out var object_5);
				result = new Class14(propertyInfo_2.GetValue(object_4, object_5));
				break;
			}
			case 8:
			{
				method_13(session, out var object_2, out var propertyInfo_, out var object_3);
				Class14 class9 = method_1(session, args, 1, 1)[0];
				propertyInfo_.SetValue(object_2, class9.method_40(), object_3);
				result = class9;
				break;
			}
			case 9:
			{
				Class14 class8 = method_1(session, args, 1, 1)[0];
				object obj = class8.method_40();
				if (obj != null)
				{
					result = new Class14(obj.GetType());
				}
				break;
			}
			case 10:
			{
				Class14 class14_ = method_1(session, args, 1, 1)[0];
				result = new Class14(Type.GetType(Class14.smethod_2(class14_)));
				break;
			}
			case 11:
			{
				Class14 class6 = method_1(session, args, 1, 1)[0];
				result = Class14.smethod_3(class6.method_1() ? "" : class6.System_002EObject_002EToString());
				break;
			}
			case 12:
			{
				Class14 class5 = method_1(session, args, 1, 1)[0];
				result = new Class14(class5.method_42());
				break;
			}
			case 13:
			{
				Class14 class4 = method_1(session, args, 1, 1)[0];
				result = new Class14(class4.method_41());
				break;
			}
			case 14:
			{
				Class14 class3 = method_1(session, args, 1, 1)[0];
				result = new Class14(class3.method_43());
				break;
			}
			case 15:
			{
				Class14 class2 = method_1(session, args, 1, 1)[0];
				result = new Class14(class2.method_39(typeof(DateTime)));
				break;
			}
			case 16:
			{
				Class14 @class = method_1(session, args, 1, 1)[0];
				result = new Class14(@class.method_39(typeof(TimeSpan)));
				break;
			}
			}
		}
		return result;
	}
}

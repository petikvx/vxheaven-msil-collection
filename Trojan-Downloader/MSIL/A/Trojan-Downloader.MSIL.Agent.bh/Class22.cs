using System;
using System.Collections;
using System.Reflection;
using System.Xml;

internal class Class22 : Class15
{
	public Class22()
	{
	}

	public Class22(Class14 class14_0)
		: base(class14_0)
	{
	}

	public Class22(Class14 class14_0, XmlNode xmlNode_0)
		: base(class14_0, xmlNode_0)
	{
	}

	protected void method_15(Class27 class27_0, Class28 class28_0, ref Class14 class14_0, out Type[] type_0, out object[] object_0)
	{
		ArrayList arrayList = new ArrayList();
		ArrayList arrayList2 = new ArrayList();
		for (Class15 @class = vmethod_6(0); @class != null; @class = @class.class15_0)
		{
			Type type = null;
			if (!(@class.string_0 == "ClrNull") && !(@class.string_0 == "ClrCastTo"))
			{
				if (@class.string_0 == "ClrToArray")
				{
					type = Type.GetType(Class28.smethod_2(@class.vmethod_2(class27_0, "type")) + "[]");
				}
			}
			else
			{
				type = Type.GetType(Class28.smethod_2(@class.vmethod_2(class27_0, "type")));
			}
			Class28 class2 = method_1(class27_0, class28_0, ref class14_0, @class)[0];
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

	protected void method_16(Class27 class27_0, out object object_0, out PropertyInfo propertyInfo_0, out object[] object_1)
	{
		Type type = null;
		Class28 @class = vmethod_3(class27_0, "object", null);
		object_0 = @class.method_40();
		if (object_0 == null)
		{
			string typeName = Class28.smethod_2(vmethod_2(class27_0, "type"));
			type = Type.GetType(typeName);
		}
		else
		{
			type = object_0.GetType();
		}
		propertyInfo_0 = type.GetProperty(string_1);
		@class = vmethod_3(class27_0, "index", null);
		if (@class != null)
		{
			string text = Class28.smethod_2(vmethod_3(class27_0, "indexSeparator", null));
			string text2 = Class28.smethod_2(vmethod_3(class27_0, "indexType", Class28.smethod_3("System.Int32")));
			string[] array = null;
			if (text != null)
			{
				@class = Class28.smethod_0(Class51.smethod_7(@class).Split(text.ToCharArray()));
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
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		if (Class53.hashtable_6 == null)
		{
			Class53.hashtable_6 = new Hashtable(34, 0.5f)
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
		Class28 result = null;
		object key;
		if ((key = string_0) != null && (key = Class53.hashtable_6[key]) != null)
		{
			switch ((int)key)
			{
			case 1:
			{
				string typeName4 = Class28.smethod_2(vmethod_2(session, "type"));
				Type type4 = Type.GetType(typeName4);
				method_15(session, args, ref runningNode, out var type_, out var object_);
				ConstructorInfo constructor = type4.GetConstructor(type_);
				result = new Class28(constructor.Invoke(object_));
				break;
			}
			case 2:
			{
				string typeName2 = Class28.smethod_2(vmethod_2(session, "type"));
				int length = Class51.smethod_9(Class28.smethod_2(vmethod_2(session, "size")), -1);
				Type type2 = Type.GetType(typeName2);
				result = new Class28(Array.CreateInstance(type2, length));
				break;
			}
			case 3:
			{
				string typeName = Class28.smethod_2(vmethod_2(session, "type"));
				Type type = Type.GetType(typeName);
				Class28 class7 = method_2(session, args, ref runningNode, 1, 1)[0];
				result = new Class28(class7.method_39(type));
				break;
			}
			case 4:
			{
				string typeName3 = Class28.smethod_2(vmethod_2(session, "type"));
				Type type3 = Type.GetType(typeName3);
				result = new Class28(method_2(session, args, ref runningNode, 1, 1)[0].method_35(type3));
				break;
			}
			case 5:
			{
				Array array = vmethod_2(session, "array").method_40() as Array;
				result = new Class28(array.GetValue(Class51.smethod_9(Class28.smethod_2(vmethod_2(session, "index")), -1)));
				break;
			}
			case 6:
			{
				Type type5 = null;
				object obj2 = vmethod_3(session, "object", null)?.method_40();
				if (obj2 == null)
				{
					string typeName5 = Class28.smethod_2(vmethod_2(session, "type"));
					type5 = Type.GetType(typeName5);
				}
				else
				{
					type5 = obj2.GetType();
				}
				method_15(session, args, ref runningNode, out var type_2, out var object_6);
				MethodInfo method = type5.GetMethod(string_1, type_2);
				result = new Class28(method.Invoke(obj2, object_6));
				break;
			}
			case 7:
			{
				method_16(session, out var object_4, out var propertyInfo_2, out var object_5);
				result = new Class28(propertyInfo_2.GetValue(object_4, object_5));
				break;
			}
			case 8:
			{
				method_16(session, out var object_2, out var propertyInfo_, out var object_3);
				Class28 class9 = method_2(session, args, ref runningNode, 1, 1)[0];
				propertyInfo_.SetValue(object_2, class9.method_40(), object_3);
				result = class9;
				break;
			}
			case 9:
			{
				Class28 class8 = method_2(session, args, ref runningNode, 1, 1)[0];
				object obj = class8.method_40();
				if (obj != null)
				{
					result = new Class28(obj.GetType());
				}
				break;
			}
			case 10:
			{
				Class28 class28_ = method_2(session, args, ref runningNode, 1, 1)[0];
				result = new Class28(Type.GetType(Class28.smethod_2(class28_)));
				break;
			}
			case 11:
			{
				Class28 class6 = method_2(session, args, ref runningNode, 1, 1)[0];
				result = Class28.smethod_3(class6.method_1() ? "" : Class51.smethod_7(class6));
				break;
			}
			case 12:
			{
				Class28 class5 = method_2(session, args, ref runningNode, 1, 1)[0];
				result = new Class28(class5.method_42());
				break;
			}
			case 13:
			{
				Class28 class4 = method_2(session, args, ref runningNode, 1, 1)[0];
				result = new Class28(class4.method_41());
				break;
			}
			case 14:
			{
				Class28 class3 = method_2(session, args, ref runningNode, 1, 1)[0];
				result = new Class28(class3.method_43());
				break;
			}
			case 15:
			{
				Class28 class2 = method_2(session, args, ref runningNode, 1, 1)[0];
				result = new Class28(class2.method_39(typeof(DateTime)));
				break;
			}
			case 16:
			{
				Class28 @class = method_2(session, args, ref runningNode, 1, 1)[0];
				result = new Class28(@class.method_39(typeof(TimeSpan)));
				break;
			}
			}
		}
		return result;
	}
}

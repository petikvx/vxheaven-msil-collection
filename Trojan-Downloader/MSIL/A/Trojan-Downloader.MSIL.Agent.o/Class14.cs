using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
internal class Class14
{
	protected Class16 class16_0;

	public Class14(object object_0)
	{
		if (object_0 != null)
		{
			if (object_0 is Class14)
			{
				(object_0 as Class14).vmethod_4(this);
			}
			else
			{
				method_6(null, object_0);
			}
		}
	}

	public static Class14 smethod_0(IEnumerable ienumerable_0)
	{
		if (ienumerable_0 != null)
		{
			Class14 @class = new Class14();
			{
				foreach (object item in ienumerable_0)
				{
					@class.method_6(null, item);
				}
				return @class;
			}
		}
		return null;
	}

	public Class14()
	{
	}

	[SpecialName]
	public static Class14 smethod_1()
	{
		return new Class14();
	}

	[SpecialName]
	public static string smethod_2(Class14 class14_0)
	{
		return class14_0?.System_002EObject_002EToString();
	}

	[SpecialName]
	public static Class14 smethod_3(string string_0)
	{
		return new Class14(string_0);
	}

	protected Class16 method_0()
	{
		if (class16_0 == null)
		{
			return class16_0 = new Class16();
		}
		return class16_0;
	}

	[SpecialName]
	public bool method_1()
	{
		if (class16_0 != null && class16_0.method_9() != 0)
		{
			if (class16_0.method_9() == 1)
			{
				return class16_0.method_2("0") == null;
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	public bool method_2()
	{
		int num = method_5();
		if (num != 0)
		{
			if (num == 1 && class16_0.method_4(0) == null)
			{
				return !(class16_0.method_2("0") is Class14);
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	public bool method_3()
	{
		if (method_2())
		{
			if (method_5() != 0)
			{
				return class16_0.method_2("0") is string;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public bool method_4()
	{
		return !method_2();
	}

	[SpecialName]
	public int method_5()
	{
		if (class16_0 == null)
		{
			return 0;
		}
		return class16_0.method_9();
	}

	protected Class14 method_6(string string_0, object object_0)
	{
		if (object_0 != null && object_0 is Class14)
		{
			return method_7(string_0, object_0 as Class14);
		}
		if (string_0 == "")
		{
			string_0 = null;
		}
		if (string_0 == null)
		{
			method_0().method_5(object_0);
		}
		else
		{
			method_0().method_6(string_0, object_0);
		}
		return this;
	}

	protected Class14 method_7(string string_0, Class14 class14_0)
	{
		if (string_0 == "")
		{
			string_0 = null;
		}
		object object_ = ((class14_0 == null) ? null : ((!class14_0.method_2() || class14_0.method_1()) ? class14_0 : class14_0.class16_0.method_2("0")));
		if (string_0 == null)
		{
			method_0().method_5(object_);
		}
		else
		{
			method_0().method_6(string_0, object_);
		}
		return this;
	}

	public Class14 method_8(string string_0, object object_0)
	{
		return method_6(string_0, object_0);
	}

	public Class14 method_9(int int_0, object object_0)
	{
		return method_6(int_0.ToString(), object_0);
	}

	public Class14 method_10(object object_0)
	{
		return method_6(null, object_0);
	}

	public Class14 method_11(string string_0, Class14 class14_0)
	{
		return method_7(string_0, class14_0);
	}

	public Class14 method_12(int int_0, Class14 class14_0)
	{
		return method_7(int_0.ToString(), class14_0);
	}

	public Class14 method_13(Class14 class14_0)
	{
		return method_7(null, class14_0);
	}

	public Class14 method_14(Class14 class14_0)
	{
		if (class14_0 != null)
		{
			for (int i = 0; i < class14_0.method_5(); i++)
			{
				string text = class14_0.method_44(i);
				if (text != null)
				{
					method_22(text, class14_0.method_31(i));
				}
				else
				{
					method_6(null, class14_0.method_31(i));
				}
			}
		}
		return this;
	}

	public Class14 method_15(int int_0)
	{
		return method_16(int_0.ToString());
	}

	public Class14 method_16(string string_0)
	{
		if (class16_0 != null)
		{
			return method_19(class16_0.method_8(string_0));
		}
		return null;
	}

	public Class14 method_17(string[] string_0)
	{
		if (class16_0 == null)
		{
			return null;
		}
		return method_18(string_0, 0);
	}

	protected Class14 method_18(string[] string_0, int int_0)
	{
		if (string_0.Length - int_0 != 1)
		{
			return method_27(string_0[int_0]).method_18(string_0, int_0 + 1);
		}
		if (!class16_0.method_10(string_0[int_0]))
		{
			return null;
		}
		return method_19(class16_0.method_8(string_0[int_0]));
	}

	protected Class14 method_19(object object_0)
	{
		if (object_0 != null && !(object_0 is Class14))
		{
			return new Class14(object_0);
		}
		return object_0 as Class14;
	}

	protected Class14 method_20(string string_0)
	{
		return method_19(method_32(string_0));
	}

	protected Class14 method_21(string[] string_0)
	{
		return method_19(method_34(string_0));
	}

	protected void method_22(string string_0, object object_0)
	{
		method_0().method_3(string_0, object_0);
	}

	protected void method_23(string[] string_0, int int_0, object object_0)
	{
		if (string_0.Length - int_0 == 1)
		{
			method_22(string_0[int_0], object_0);
		}
		else
		{
			method_20(string_0[int_0]).method_23(string_0, int_0 + 1, object_0);
		}
	}

	protected void method_24(string[] string_0, object object_0)
	{
		method_23(string_0, 0, object_0);
	}

	[SpecialName]
	public Class14 method_25(int int_0)
	{
		return method_20(int_0.ToString());
	}

	[SpecialName]
	public void method_26(int int_0, Class14 class14_0)
	{
		method_22(int_0.ToString(), class14_0);
	}

	[SpecialName]
	public Class14 method_27(string string_0)
	{
		return method_20(string_0);
	}

	[SpecialName]
	public void method_28(string string_0, Class14 class14_0)
	{
		method_22(string_0, class14_0);
	}

	[SpecialName]
	public Class14 method_29(string[] string_0)
	{
		return method_21(string_0);
	}

	[SpecialName]
	public void method_30(string[] string_0, Class14 class14_0)
	{
		method_24(string_0, class14_0);
	}

	public object method_31(int int_0)
	{
		return method_32(int_0.ToString());
	}

	public object method_32(string string_0)
	{
		if (!method_0().method_10(string_0))
		{
			Class14 @class = new Class14();
			method_22(string_0, @class);
			return @class;
		}
		return class16_0.method_2(string_0);
	}

	protected object method_33(string[] string_0, int int_0)
	{
		if (string_0.Length - int_0 == 1)
		{
			return method_32(string_0[int_0]);
		}
		return method_20(string_0[int_0]).method_33(string_0, int_0 + 1);
	}

	public object method_34(string[] string_0)
	{
		return method_33(string_0, 0);
	}

	string object.ToString()
	{
		return ((class16_0 == null || class16_0.method_9() <= 0) ? null : class16_0.method_2("0"))?.ToString();
	}

	public Array method_35(Type type_0)
	{
		Array array = Array.CreateInstance(type_0, method_5());
		if ((object)type_0 == typeof(string))
		{
			return vmethod_1(array as string[]);
		}
		if ((object)type_0 == typeof(object))
		{
			return vmethod_0(array as object[]);
		}
		if ((object)type_0 == typeof(Class14))
		{
			return vmethod_2(array as Class14[]);
		}
		return vmethod_3(array, type_0);
	}

	public virtual object[] vmethod_0(object[] object_0)
	{
		for (int i = 0; i < method_5(); i++)
		{
			object_0[i] = class16_0.method_0(i);
		}
		return object_0;
	}

	public virtual string[] vmethod_1(string[] string_0)
	{
		for (int i = 0; i < method_5(); i++)
		{
			string_0[i] = class16_0.method_0(i)?.ToString();
		}
		return string_0;
	}

	public virtual Class14[] vmethod_2(Class14[] class14_0)
	{
		for (int i = 0; i < method_5(); i++)
		{
			object obj = class16_0.method_0(i);
			if (obj != null && !(obj is Class14))
			{
				class14_0[i] = new Class14(obj);
			}
			else
			{
				class14_0[i] = obj as Class14;
			}
		}
		return class14_0;
	}

	public virtual Array vmethod_3(Array array_0, Type type_0)
	{
		for (int i = 0; i < method_5(); i++)
		{
			object obj = class16_0.method_0(i);
			if (obj != null)
			{
				try
				{
					array_0.SetValue(Convert.ChangeType(obj, type_0), i);
				}
				catch
				{
				}
			}
			else
			{
				array_0.SetValue(null, i);
			}
		}
		return array_0;
	}

	public virtual Class14 vmethod_4(Class14 class14_0)
	{
		if (class14_0 != this)
		{
			if (class16_0 != null)
			{
				class14_0.method_0().method_11();
				for (int i = 0; i < class16_0.method_9(); i++)
				{
					object obj = class16_0.method_0(i);
					if (obj != null && obj is Class14)
					{
						Class14 @class = new Class14();
						(obj as Class14).vmethod_4(@class);
						obj = @class;
					}
					if (class16_0.method_4(i) == null)
					{
						class14_0.class16_0.method_5(obj);
					}
					else
					{
						class14_0.class16_0.method_6(class16_0.method_4(i), obj);
					}
				}
			}
			else
			{
				class14_0.class16_0 = null;
			}
		}
		return class14_0;
	}

	public bool method_36(string string_0)
	{
		if (class16_0 != null)
		{
			return class16_0.method_10(string_0);
		}
		return false;
	}

	protected bool method_37(string[] string_0, int int_0)
	{
		if (string_0.Length - int_0 != 1)
		{
			if (method_36(string_0[int_0]))
			{
				return method_25(int_0).method_37(string_0, int_0 + 1);
			}
			return false;
		}
		return class16_0.method_10(string_0[int_0]);
	}

	public bool method_38(string[] string_0)
	{
		if (class16_0 == null)
		{
			return false;
		}
		return method_37(string_0, 0);
	}

	public object method_39(Type type_0)
	{
		try
		{
			object obj = method_40();
			if (obj != null && (object)type_0 != typeof(object))
			{
				if ((object)type_0 == typeof(string))
				{
					return obj.ToString();
				}
				if (obj is IConvertible)
				{
					return Convert.ChangeType(method_40(), type_0);
				}
				return null;
			}
			return obj;
		}
		catch
		{
			return null;
		}
	}

	[SpecialName]
	public object method_40()
	{
		if (class16_0 != null && class16_0.method_9() > 0)
		{
			return class16_0.method_2("0");
		}
		return null;
	}

	[SpecialName]
	public bool method_41()
	{
		string text = System_002EObject_002EToString();
		if (!(text == "") && text != null)
		{
			return GClass1.smethod_5(text, bool_0: true);
		}
		return false;
	}

	[SpecialName]
	public int method_42()
	{
		string text = System_002EObject_002EToString();
		if (!(text == "") && text != null)
		{
			return GClass1.smethod_3(text, 0);
		}
		return 0;
	}

	[SpecialName]
	public double method_43()
	{
		string text = System_002EObject_002EToString();
		if (!(text == "") && text != null)
		{
			return GClass1.smethod_4(text, 0.0);
		}
		return 0.0;
	}

	public string method_44(int int_0)
	{
		if (class16_0 != null)
		{
			return class16_0.method_4(int_0);
		}
		return null;
	}
}

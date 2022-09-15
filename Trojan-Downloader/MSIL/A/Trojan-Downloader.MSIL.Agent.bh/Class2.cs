using System;
using System.Runtime.CompilerServices;
using ITWX;

internal abstract class Class2 : MarshalByRefObject, IDisposable
{
	protected string string_0;

	protected string string_1;

	protected string string_2;

	protected bool bool_0;

	protected GClass0.GEnum6 genum6_0;

	protected GClass0.GEnum2 genum2_0;

	protected GClass0.GEnum1 genum1_0;

	protected GClass0.GEnum4 genum4_0;

	protected GClass0.GEnum5 genum5_0;

	protected GClass0.GEnum3 genum3_0;

	protected GClass0.Struct0 struct0_0;

	protected IntPtr intptr_0;

	protected GClass0.GDelegate0 gdelegate0_0;

	protected bool bool_1 = false;

	internal Class2()
	{
		object[] customAttributes = GetType().GetCustomAttributes(typeof(ServiceAttribute), inherit: true);
		if (customAttributes.Length != 1)
		{
			throw new Exception("One, and only one, ServiceAttribute must be applied to the service class to be able to use it with this feature.");
		}
		ServiceAttribute serviceAttribute = customAttributes[0] as ServiceAttribute;
		string_0 = serviceAttribute.Name;
		string_1 = serviceAttribute.DisplayName;
		string_2 = serviceAttribute.Description;
		bool_0 = serviceAttribute.Run;
		genum2_0 = serviceAttribute.ServiceType;
		genum1_0 = serviceAttribute.ServiceAccessType;
		genum4_0 = serviceAttribute.ServiceStartType;
		genum5_0 = serviceAttribute.ServiceErrorControl;
		genum3_0 = serviceAttribute.ServiceControls;
		genum6_0 = GClass0.GEnum6.const_1;
		gdelegate0_0 = vmethod_1;
		struct0_0 = default(GClass0.Struct0);
		struct0_0.genum6_0 = genum6_0;
		struct0_0.genum2_0 = genum2_0;
		struct0_0.genum3_0 = genum3_0;
		struct0_0.uint_0 = 0u;
		struct0_0.uint_1 = 0u;
		struct0_0.uint_2 = 0u;
		struct0_0.uint_3 = 0u;
	}

	public virtual void vmethod_0(int int_0, string[] string_3)
	{
		genum6_0 = GClass0.GEnum6.const_2;
		struct0_0.uint_2 = 0u;
		struct0_0.uint_3 = 0u;
		intptr_0 = Class41.smethod_8(string_0, gdelegate0_0);
		if (intptr_0 == IntPtr.Zero)
		{
			return;
		}
		if (!method_15(string_3))
		{
			genum6_0 = GClass0.GEnum6.const_1;
			struct0_0.uint_2 = 0u;
			struct0_0.uint_3 = 0u;
			struct0_0.uint_0 = uint.MaxValue;
			struct0_0.uint_1 = uint.MaxValue;
			if (!method_0())
			{
				throw Class52.smethod_1();
			}
		}
		else
		{
			genum6_0 = GClass0.GEnum6.const_4;
			struct0_0.uint_2 = 0u;
			struct0_0.uint_3 = 0u;
			if (!method_0())
			{
				throw Class52.smethod_1();
			}
			method_16();
		}
	}

	protected virtual void vmethod_1(int int_0)
	{
		switch (int_0)
		{
		case 1:
			method_18();
			genum6_0 = GClass0.GEnum6.const_1;
			struct0_0.uint_0 = 0u;
			struct0_0.uint_2 = 0u;
			struct0_0.uint_3 = 0u;
			break;
		case 2:
			method_17();
			genum6_0 = GClass0.GEnum6.const_7;
			break;
		case 3:
			method_19();
			genum6_0 = GClass0.GEnum6.const_4;
			break;
		case 4:
			method_21();
			break;
		case 5:
			method_20();
			genum6_0 = GClass0.GEnum6.const_1;
			break;
		}
		method_0();
	}

	protected bool method_0()
	{
		struct0_0.genum6_0 = genum6_0;
		return Class41.smethod_11(intptr_0, ref struct0_0);
	}

	public bool method_1()
	{
		GClass0.Struct1 @struct = default(GClass0.Struct1);
		@struct.string_0 = string_0;
		@struct.gdelegate1_0 = vmethod_0;
		GClass0.Struct1[] struct1_ = new GClass0.Struct1[2]
		{
			@struct,
			GClass0.Struct1.smethod_0()
		};
		return Class41.smethod_9(struct1_);
	}

	[SpecialName]
	public string method_2()
	{
		return string_0;
	}

	[SpecialName]
	public string method_3()
	{
		return string_1;
	}

	[SpecialName]
	public string method_4()
	{
		return string_2;
	}

	[SpecialName]
	public bool method_5()
	{
		return bool_0;
	}

	[SpecialName]
	public GClass0.GEnum2 method_6()
	{
		return genum2_0;
	}

	[SpecialName]
	public GClass0.GEnum1 method_7()
	{
		return genum1_0;
	}

	[SpecialName]
	public GClass0.GEnum4 method_8()
	{
		return genum4_0;
	}

	[SpecialName]
	public GClass0.GEnum5 method_9()
	{
		return genum5_0;
	}

	[SpecialName]
	public GClass0.GEnum3 method_10()
	{
		return genum3_0;
	}

	[SpecialName]
	public GClass0.GEnum6 method_11()
	{
		return genum6_0;
	}

	[SpecialName]
	public bool method_12()
	{
		return bool_1;
	}

	protected virtual bool vmethod_2()
	{
		return true;
	}

	protected virtual bool vmethod_3()
	{
		return true;
	}

	protected virtual bool vmethod_4(string[] string_3)
	{
		return true;
	}

	protected virtual void vmethod_5()
	{
	}

	protected virtual void vmethod_6()
	{
	}

	protected virtual void vmethod_7()
	{
	}

	protected virtual void vmethod_8()
	{
	}

	protected virtual void vmethod_9()
	{
	}

	protected virtual void vmethod_10()
	{
	}

	public bool method_13()
	{
		try
		{
			return vmethod_2();
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_14()
	{
		try
		{
			return vmethod_3();
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_15(string[] string_3)
	{
		try
		{
			return vmethod_4(string_3);
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_16()
	{
		try
		{
			vmethod_5();
			return true;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_17()
	{
		try
		{
			vmethod_6();
			return true;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_18()
	{
		try
		{
			vmethod_7();
			return true;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_19()
	{
		try
		{
			vmethod_8();
			return true;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_20()
	{
		try
		{
			vmethod_9();
			return true;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	public bool method_21()
	{
		try
		{
			vmethod_10();
			return true;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return false;
		}
	}

	void IDisposable.Dispose()
	{
		if (!bool_1)
		{
			bool_1 = true;
		}
	}
}

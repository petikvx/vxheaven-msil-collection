using System.Xml;

internal class Class3 : Class2
{
	public Class3()
	{
	}

	public Class3(Class0 class0_0)
		: base(class0_0)
	{
	}

	public Class3(Class0 class0_0, XmlNode xmlNode_0)
		: base(class0_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class14 evaluate(Class13 session, Class14 args)
	{
		Class14 result = null;
		switch (string_0)
		{
		case "Foreach":
		{
			Class14 class2 = vmethod_1(session, "array");
			string text = vmethod_4("iterator", null);
			if (text == null)
			{
				text = "::ITERATOR";
				int num = 1;
				while (session.method_12(text))
				{
					text = "::ITERATOR" + num++;
				}
			}
			else if (!text.StartsWith(":") || (text.StartsWith(":") && !text.StartsWith("::")))
			{
				text = ((!text.StartsWith(":")) ? ("::" + text) : (":" + text));
			}
			bool flag = true;
			if (session.method_12(text))
			{
				flag = false;
			}
			try
			{
				Class1 class3 = vmethod_6(1, 1)[0];
				if (class3 != null)
				{
					for (int i = 0; i < class2.method_5(); i++)
					{
						try
						{
							session.method_14(text, class2.method_25(i));
							Class14 class4 = class3.vmethod_7(session, args);
							if (class4 != null)
							{
								result = class4;
							}
						}
						catch (Exception0 exception3)
						{
							if (exception3.int_0 > 1)
							{
								if (class1_2 != null)
								{
									class1_2.vmethod_8(exception3.int_0 - 1);
									return result;
								}
								return result;
							}
							return result;
						}
						catch (Exception1)
						{
						}
					}
					return result;
				}
				return result;
			}
			finally
			{
				if (flag)
				{
					session.method_11(text);
				}
			}
		}
		case "While":
		{
			Class1[] array = vmethod_6(1, 2);
			if (array[0] == null)
			{
				break;
			}
			while (array[0].vmethod_7(session, args).method_41())
			{
				if (array[1] == null)
				{
					continue;
				}
				try
				{
					Class14 @class = array[1].vmethod_7(session, args);
					if (@class != null)
					{
						result = @class;
					}
				}
				catch (Exception0 exception)
				{
					if (exception.int_0 > 1)
					{
						if (class1_2 != null)
						{
							class1_2.vmethod_8(exception.int_0 - 1);
							return result;
						}
						return result;
					}
					return result;
				}
				catch (Exception1)
				{
				}
			}
			break;
		}
		}
		return result;
	}

	public override void vmethod_8(int int_0)
	{
		throw new Exception0(int_0);
	}

	public override void vmethod_9()
	{
		throw new Exception1();
	}
}

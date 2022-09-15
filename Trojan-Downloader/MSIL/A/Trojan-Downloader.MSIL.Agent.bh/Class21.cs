using System.Xml;

internal class Class21 : Class15
{
	public Class21()
	{
	}

	public Class21(Class14 class14_0)
		: base(class14_0)
	{
	}

	public Class21(Class14 class14_0, XmlNode xmlNode_0)
		: base(class14_0, xmlNode_0)
	{
	}

	[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
	protected override Class28 evaluate(Class27 session, Class28 args, ref Class14 runningNode)
	{
		Class28 result = null;
		switch (string_0)
		{
		case "Foreach":
		{
			Class28 class2 = vmethod_2(session, "array");
			string text = vmethod_5("iterator", null);
			if (text == null)
			{
				text = "::ITERATOR";
				int num = 1;
				while (session.method_15(text))
				{
					text = "::ITERATOR" + Class51.smethod_3(num++);
				}
			}
			else if (!text.StartsWith(":") || (text.StartsWith(":") && !text.StartsWith("::")))
			{
				text = ((!text.StartsWith(":")) ? ("::" + text) : (":" + text));
			}
			bool flag = true;
			if (session.method_15(text))
			{
				flag = false;
			}
			try
			{
				Class15 class3 = vmethod_7(1, 1)[0];
				if (class3 != null)
				{
					for (int i = 0; i < class2.method_5(); i++)
					{
						try
						{
							session.method_18(text, class2.method_25(i));
							Class28 class4 = class3.vmethod_8(session, args, ref runningNode);
							if (class4 != null)
							{
								result = class4;
							}
						}
						catch (Exception0 exception3)
						{
							if (exception3.int_0 > 1)
							{
								if (class15_2 != null)
								{
									class15_2.vmethod_9(exception3.int_0 - 1);
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
					session.method_14(text);
				}
			}
		}
		case "While":
		{
			Class15[] array = vmethod_7(1, 2);
			if (array[0] == null)
			{
				break;
			}
			while (array[0].vmethod_8(session, args, ref runningNode).method_41())
			{
				if (array[1] == null)
				{
					continue;
				}
				try
				{
					Class28 @class = array[1].vmethod_8(session, args, ref runningNode);
					if (@class != null)
					{
						result = @class;
					}
				}
				catch (Exception0 exception)
				{
					if (exception.int_0 > 1)
					{
						if (class15_2 != null)
						{
							class15_2.vmethod_9(exception.int_0 - 1);
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

	public override void vmethod_9(int int_1)
	{
		throw new Exception0(int_1);
	}

	public override void vmethod_10()
	{
		throw new Exception1();
	}
}

using System;

internal class Class46
{
	public static void smethod_0(Delegate delegate_0, params object[] object_0)
	{
		if (delegate_0 == null)
		{
			return;
		}
		Delegate[] invocationList = delegate_0.GetInvocationList();
		Delegate[] array = invocationList;
		foreach (Delegate @delegate in array)
		{
			try
			{
				@delegate.DynamicInvoke(object_0);
			}
			catch (Exception exception_)
			{
				Class47.smethod_8(exception_);
			}
		}
	}
}

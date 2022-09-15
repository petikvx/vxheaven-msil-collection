using System;
using System.Reflection;

namespace VistalServiceAssistant;

public class ProxyObject : MarshalByRefObject
{
	private Assembly assembly;

	public void LoadAssembly(string filename)
	{
		assembly = Assembly.LoadFile(filename);
	}

	public bool Invoke(string fullClassName, string methodName, params object[] args)
	{
		if ((object)assembly == null)
		{
			return false;
		}
		Type type = assembly.GetType(fullClassName);
		if ((object)type != null)
		{
			MethodInfo method = type.GetMethod(methodName);
			if ((object)method != null)
			{
				object obj = Activator.CreateInstance(type);
				method.Invoke(obj, args);
				return true;
			}
			return false;
		}
		return false;
	}
}

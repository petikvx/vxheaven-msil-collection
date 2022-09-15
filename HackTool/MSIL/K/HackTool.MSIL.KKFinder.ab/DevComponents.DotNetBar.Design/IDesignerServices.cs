using System;
using System.ComponentModel;

namespace DevComponents.DotNetBar.Design;

public interface IDesignerServices
{
	object CreateComponent(Type componentClass);

	object CreateComponent(Type componentClass, string name);

	void DestroyComponent(IComponent c);

	object GetService(Type serviceType);
}

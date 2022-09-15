using System.ServiceProcess;

namespace COMService;

internal static class Class0
{
	private static void Main()
	{
		ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
		{
			new GClass0()
		};
		ServiceBase.Run(array);
	}
}

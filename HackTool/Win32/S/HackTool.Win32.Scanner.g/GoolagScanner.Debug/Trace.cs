using System.Diagnostics;

namespace GoolagScanner.Debug;

public class Trace
{
	public static TraceSwitch TraceGoolag = new TraceSwitch("GoolagTrace", "GoolagScanner");
}

using System.Diagnostics;

namespace GoolagScan.Debug;

public class Trace
{
	public static TraceSwitch TraceGoolag = new TraceSwitch("GoolagTrace", "GoolagScan");
}

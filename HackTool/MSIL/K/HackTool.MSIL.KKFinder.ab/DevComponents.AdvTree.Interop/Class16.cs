using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevComponents.AdvTree.Interop;

internal class Class16
{
	private struct Struct4
	{
		public int int_0;

		public uint uint_0;

		public int int_1;

		public int int_2;
	}

	private const uint uint_0 = 1u;

	private const uint uint_1 = 2u;

	private const uint uint_2 = 16u;

	private const uint uint_3 = 1073741824u;

	private const uint uint_4 = 2147483648u;

	private const uint uint_5 = uint.MaxValue;

	[DllImport("user32")]
	private static extern bool TrackMouseEvent(ref Struct4 tme);

	public static void smethod_0(Control control_0)
	{
		if (control_0 != null && control_0.get_IsHandleCreated())
		{
			Struct4 tme = default(Struct4);
			tme.uint_0 = 1073741824u;
			tme.int_2 = (int)control_0.get_Handle();
			tme.int_0 = Marshal.SizeOf((object)tme);
			TrackMouseEvent(ref tme);
			tme.uint_0 |= 1u;
			TrackMouseEvent(ref tme);
		}
	}
}

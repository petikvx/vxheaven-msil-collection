using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class106 : IMessageFilter
{
	public bool PreFilterMessage(ref Message m)
	{
		switch (((Message)(ref m)).get_Msg())
		{
		case 256:
			return Class107.smethod_8(((Message)(ref m)).get_HWnd(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
		case 512:
			return Class107.smethod_10(((Message)(ref m)).get_HWnd(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
		case 260:
			return Class107.smethod_6(((Message)(ref m)).get_HWnd(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
		case 261:
			return Class107.smethod_7(((Message)(ref m)).get_HWnd(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
		default:
			return false;
		case 522:
			return Class107.smethod_11(((Message)(ref m)).get_HWnd(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
		case 161:
		case 164:
		case 167:
		case 513:
		case 516:
		case 519:
			return Class107.smethod_9(((Message)(ref m)).get_HWnd(), ((Message)(ref m)).get_WParam(), ((Message)(ref m)).get_LParam());
		}
	}

	public void method_0(ref Message message_0)
	{
	}
}

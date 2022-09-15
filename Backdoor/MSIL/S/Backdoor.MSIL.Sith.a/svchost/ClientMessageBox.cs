using Microsoft.VisualBasic;

namespace svchost;

public class ClientMessageBox
{
	public static string Message;

	public void ShowMessage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)Message, (MsgBoxStyle)65536, (object)"Ghost");
	}
}

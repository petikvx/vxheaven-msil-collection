using System;
using System.Runtime.InteropServices;

namespace COSpeed;

internal static class Memoria
{
	public static int EscreverNaMemoria(IntPtr Processo, IntPtr Endereco, byte[] Valor)
	{
		WriteProcessMemory(Processo, Endereco, Valor, (uint)Valor.Length, out var lpNumberOfBytesWrite);
		return lpNumberOfBytesWrite.ToInt32();
	}

	[DllImport("kernel32.dll")]
	private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWrite);
}

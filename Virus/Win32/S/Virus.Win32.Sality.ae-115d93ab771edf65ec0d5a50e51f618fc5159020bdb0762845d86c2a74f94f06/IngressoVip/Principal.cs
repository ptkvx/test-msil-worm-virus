using System;
using Microsoft.VisualBasic.CompilerServices;

namespace IngressoVip;

[StandardModule]
internal sealed class Principal
{
	private static clsServidor Servidor = new clsServidor();

	[STAThread]
	public static void Main()
	{
		Servidor.Escuta();
	}
}

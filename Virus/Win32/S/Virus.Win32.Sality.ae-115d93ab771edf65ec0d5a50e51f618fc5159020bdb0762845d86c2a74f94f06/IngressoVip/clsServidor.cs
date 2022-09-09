using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IngressoVip;

public class clsServidor
{
	private Hashtable listaConexao;

	private clsFuncoes objFuncoes;

	private TcpClient Cnn;

	public clsServidor()
	{
		listaConexao = new Hashtable();
		objFuncoes = new clsFuncoes();
	}

	private TcpClient Conectar()
	{
		TcpClient tcpClient = new TcpClient();
		try
		{
			if (!tcpClient.Connected)
			{
				tcpClient.Connect("172.16.0.7", 64380);
				objFuncoes.MsgConsole("Conectado ao servidor remoto...");
			}
			return tcpClient;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			objFuncoes.MsgConsole("NÃO - Conectado ao servidor remoto...");
			TcpClient result = tcpClient;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void Escuta()
	{
		checked
		{
			try
			{
				TcpListener tcpListener = new TcpListener(7777);
				string text = null;
				tcpListener.Start();
				while (true)
				{
					TcpClient SkClient = tcpListener.AcceptTcpClient();
					SkClient.NoDelay = false;
					NetworkStream stream = SkClient.GetStream();
					byte[] array = new byte[SkClient.ReceiveBufferSize + 1];
					Thread.Sleep(2000);
					while (stream.DataAvailable)
					{
						stream.Read(array, 0, array.Length);
					}
					int i = 0;
					text = null;
					for (; Encoding.ASCII.GetString(array, 0, SkClient.ReceiveBufferSize)[i] != 0; i++)
					{
						text += Conversions.ToString(Encoding.ASCII.GetString(array, 0, SkClient.ReceiveBufferSize)[i]);
					}
					array = null;
					if (Operators.CompareString(text, "", false) == 0)
					{
						continue;
					}
					try
					{
						if (!Cnn.Connected)
						{
							Cnn = Conectar();
						}
						else
						{
							NetworkStream stream2 = Cnn.GetStream();
							StreamWriter streamWriter = new StreamWriter(stream2);
							streamWriter.WriteLine("99");
							objFuncoes.MsgConsole("99");
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						Cnn = Conectar();
						ProjectData.ClearProjectError();
					}
					listaConexao[text] = SkClient;
					clsExecuta clsExecuta2 = new clsExecuta();
					clsExecuta2.TrataString(ref SkClient, ref Cnn, ref text, ref listaConexao);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				FileSystem.WriteLine(Conversions.ToInteger(ex2.ToString()), new object[0]);
				ProjectData.ClearProjectError();
			}
		}
	}
}

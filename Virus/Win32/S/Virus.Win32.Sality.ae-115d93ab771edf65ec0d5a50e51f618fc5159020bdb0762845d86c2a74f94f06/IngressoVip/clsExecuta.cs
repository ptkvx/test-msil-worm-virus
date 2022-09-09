using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IngressoVip;

public class clsExecuta
{
	private clsLigacao objLigacao;

	private clsFutebol objTimes;

	private clsShows objArtista;

	private clsCinema objFilme;

	private clsCinema objShopping;

	private clsShows objShow;

	private clsShows objAcentoShow;

	private clsFutebol objJogos;

	private clsFutebol objLocais;

	private string strString;

	private TcpClient socketClienteUra;

	private TcpClient socketServidorRemoto;

	public clsExecuta()
	{
		objLigacao = new clsLigacao();
		objTimes = new clsFutebol();
		objArtista = new clsShows();
		objFilme = new clsCinema();
		objShopping = new clsCinema();
		objShow = new clsShows();
		objAcentoShow = new clsShows();
		objJogos = new clsFutebol();
		objLocais = new clsFutebol();
		socketClienteUra = new TcpClient();
		socketServidorRemoto = new TcpClient();
	}

	public void TrataString(ref TcpClient SkClient, ref TcpClient SkServidor, ref string TrataString, ref Hashtable listaCliente)
	{
		strString = TrataString;
		socketClienteUra = SkClient;
		socketServidorRemoto = SkServidor;
		Thread thread = new Thread(ProcessaString);
		thread.Start();
	}

	private void ProcessaString()
	{
		DataSet dataSet = new DataSet();
		DataSet dataSet2 = new DataSet();
		DataSet dataSet3 = new DataSet();
		DataSet dataSet4 = new DataSet();
		DataSet dataSet5 = new DataSet();
		clsMensagem clsMensagem2 = new clsMensagem();
		clsFuncoes clsFuncoes2 = new clsFuncoes();
		clsFuncoes2.MsgConsole(strString);
		clsFuncoes2.MsgConsole("");
		clsFuncoes2.MsgConsole("");
		checked
		{
			try
			{
				clsFuncoes2.MsgConsole("VALOR DE strString: " + strString);
				clsMensagem2 = clsMensagem2.Recupera_Mensagem(ref strString);
				clsFuncoes2.MsgConsole("Valor de protocolo " + clsMensagem2.msgProtocolo);
				if (Operators.CompareString(clsMensagem2.msgProtocolo, "P01", false) == 0)
				{
					clsFuncoes2.MsgConsole("Entrou no P01");
					NetworkStream stream = socketServidorRemoto.GetStream();
					StreamWriter streamWriter = new StreamWriter(stream);
					string text = Conversions.ToString(clsMensagem2.GeraMensagemP01());
					clsFuncoes2.MsgConsole("VALOR ENVIADO DO P01 " + text);
					streamWriter.WriteLine(text);
					streamWriter.Flush();
					StreamReader streamReader = new StreamReader(stream);
					text = streamReader.ReadLine()!.ToString();
					clsFuncoes2.MsgConsole(text);
					clsMensagem obj = clsMensagem2;
					string text2 = "1" + text;
					clsMensagem2 = obj.Recupera_Mensagem(ref text2);
					if (Conversions.ToInteger(clsFuncoes2.Calcular_Check_Sum(clsMensagem2.msgProtocolo + clsMensagem2.msgTN + clsMensagem2.msgVersao + clsMensagem2.msgTelefone + "*" + clsMensagem2.msgCelular + "*" + clsMensagem2.msgRespostaP01 + clsMensagem2.msgCodRegiao)) == Conversions.ToInteger(clsMensagem2.msgCheckSum))
					{
						if (Operators.CompareString(clsMensagem2.msgRespostaP01, "2", false) == 0)
						{
							text = clsMensagem2.msgTN + " " + clsMensagem2.msgRespostaP01 + " 0";
							clsFuncoes2.MsgConsole("VALOR DO strRespostaServidor no IF " + text);
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream2 = socketClienteUra.GetStream();
							byte[] bytes = Encoding.ASCII.GetBytes(text);
							stream2.Write(bytes, 0, bytes.Length);
							socketClienteUra.Close();
						}
						else if (Operators.CompareString(clsMensagem2.msgRespostaP01, "3", false) == 0)
						{
							text = clsMensagem2.msgTN + " " + clsMensagem2.msgRespostaP01 + " 0";
							clsFuncoes2.MsgConsole("VALOR DO strRespostaServidor no ELSE " + text);
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream3 = socketClienteUra.GetStream();
							byte[] bytes2 = Encoding.ASCII.GetBytes(text);
							stream3.Write(bytes2, 0, bytes2.Length);
							socketClienteUra.Close();
						}
						else if (Operators.CompareString(clsMensagem2.msgRespostaP01, "0", false) == 0)
						{
							text = clsMensagem2.msgTN + " " + clsMensagem2.msgRespostaP01 + " " + clsMensagem2.msgCodRegiao;
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream4 = socketClienteUra.GetStream();
							byte[] bytes3 = Encoding.ASCII.GetBytes(text);
							stream4.Write(bytes3, 0, bytes3.Length);
							socketClienteUra.Close();
						}
						else if (Operators.CompareString(clsMensagem2.msgRespostaP01, "1", false) == 0)
						{
							text = clsMensagem2.msgTN + " " + clsMensagem2.msgRespostaP01 + " " + clsMensagem2.msgCodRegiao;
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream5 = socketClienteUra.GetStream();
							byte[] bytes4 = Encoding.ASCII.GetBytes(text);
							stream5.Write(bytes4, 0, bytes4.Length);
							socketClienteUra.Close();
						}
					}
					else
					{
						text = clsMensagem2.msgTN + " " + clsMensagem2.msgRespostaP01 + " 0";
						NetworkStream stream6 = socketClienteUra.GetStream();
						byte[] bytes5 = Encoding.ASCII.GetBytes(text);
						stream6.Write(bytes5, 0, bytes5.Length);
						socketClienteUra.Close();
						clsFuncoes2.MsgConsole("VALOR DE strRespostaServidor Checksum nao valido: " + text);
					}
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P02", false) == 0)
				{
					clsFuncoes2.MsgConsole("Entrou no P02");
					NetworkStream stream7 = socketServidorRemoto.GetStream();
					StreamWriter streamWriter2 = new StreamWriter(stream7);
					string text = Conversions.ToString(clsMensagem2.GeraMensagemP02());
					streamWriter2.WriteLine(text);
					clsFuncoes2.MsgConsole(text);
					streamWriter2.Flush();
					StreamReader streamReader2 = new StreamReader(stream7);
					text = streamReader2.ReadLine()!.ToString();
					clsFuncoes2.MsgConsole(text);
					clsMensagem obj2 = clsMensagem2;
					string text2 = "1" + text;
					clsMensagem2 = obj2.Recupera_Mensagem(ref text2);
					if (Conversions.ToInteger(clsFuncoes2.Calcular_Check_Sum(clsMensagem2.msgProtocolo + clsMensagem2.msgTN + clsMensagem2.msgVersao + clsMensagem2.msgTelefone + "*" + clsMensagem2.msgCelular + "*" + clsMensagem2.msgDiversao + clsMensagem2.msgEvento + clsMensagem2.msgLocal + clsMensagem2.msgTipoLocal + clsMensagem2.msgQTD + clsMensagem2.msgQTDMeia + clsMensagem2.msgQTDIntMeia + clsMensagem2.msgValorCompra + clsMensagem2.msgTaxaServico + clsMensagem2.msgParcelado + clsMensagem2.msgRespostaP02)) == Conversions.ToInteger(clsMensagem2.msgCheckSum))
					{
						clsMensagem clsMensagem3 = clsMensagem2;
						text2 = clsMensagem3.msgTaxaServico;
						int num = clsFuncoes2.RemoveZeros(ref text2, 2);
						clsMensagem3.msgTaxaServico = text2;
						int num2 = num;
						Conversions.ToInteger(clsMensagem2.msgQTD);
						Conversions.ToInteger(clsMensagem2.msgQTDMeia);
						clsFuncoes2.MsgConsole("VALOR DA TAXA DE SERVICO CONVERTIDA: " + Conversions.ToString(num2));
						string text3 = Conversions.ToString(num2);
						text3 += "00";
						int length = text3.Length;
						for (int i = length; i <= 6; i++)
						{
							text3 = "0" + text3;
						}
						string strFrase = clsFuncoes2.NumeroToExtenso(clsMensagem2.msgValorCompra);
						clsFuncoes2.MsgConsole("VALOR DA COMPRA: " + strFrase);
						clsFuncoes2.MsgConsole("VALOR DE taxa: " + text3);
						clsFuncoes2.MsgConsole("VALOR DE taxa POR EXTENSO: " + clsFuncoes2.NumeroToExtenso(text3));
						string[] array = new string[14]
						{
							clsMensagem2.msgTN,
							" ",
							clsMensagem2.msgRespostaP02,
							" ",
							clsMensagem2.msgParcelado,
							" ",
							clsMensagem2.msgVagas,
							clsFuncoes2.ContaPalavras(ref strFrase).ToString(),
							" ",
							strFrase,
							" ",
							null,
							null,
							null
						};
						string[] array2 = array;
						text2 = clsFuncoes2.NumeroToExtenso(text3);
						array2[11] = clsFuncoes2.ContaPalavras(ref text2).ToString();
						array[12] = " ";
						array[13] = clsFuncoes2.NumeroToExtenso(text3);
						text = string.Concat(array);
						NetworkStream stream8 = socketClienteUra.GetStream();
						byte[] bytes6 = Encoding.ASCII.GetBytes(text);
						stream8.Write(bytes6, 0, bytes6.Length);
						socketClienteUra.Close();
						clsFuncoes2.MsgConsole(text);
					}
					else
					{
						streamWriter2.WriteLine("Erro no resultado do calculo de verificacao");
						NetworkStream stream9 = socketClienteUra.GetStream();
						byte[] array3 = (byte[])NewLateBinding.LateGet((object)Encoding.ASCII, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(clsMensagem2.GeraErro()) }, (string[])null, (Type[])null, (bool[])null);
						stream9.Write(array3, 0, array3.Length);
						socketClienteUra.Close();
						clsFuncoes2.MsgConsole(Conversions.ToString(clsMensagem2.GeraErro()));
					}
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P03", false) == 0)
				{
					clsFuncoes2.MsgConsole("Entrou no P03");
					NetworkStream stream10 = socketServidorRemoto.GetStream();
					StreamWriter streamWriter3 = new StreamWriter(stream10);
					string text = Conversions.ToString(clsMensagem2.GeraMensagemP03());
					clsFuncoes2.MsgConsole("strRespostaServidor do envio P03 " + text);
					streamWriter3.WriteLine(text);
					streamWriter3.Flush();
					StreamReader streamReader3 = new StreamReader(stream10);
					text = streamReader3.ReadLine()!.ToString();
					clsFuncoes2.MsgConsole("strRespostaServidor do recebimento P03 " + text);
					clsMensagem obj3 = clsMensagem2;
					string text2 = "1" + text;
					clsMensagem2 = obj3.Recupera_Mensagem(ref text2);
					if (Conversions.ToInteger(clsFuncoes2.Calcular_Check_Sum(clsMensagem2.msgProtocolo + clsMensagem2.msgTN + clsMensagem2.msgVersao + clsMensagem2.msgTelefone + "*" + clsMensagem2.msgCelular + "*" + clsMensagem2.msgDiversao + clsMensagem2.msgPromoto + clsMensagem2.msgEvento + clsMensagem2.msgLocal + clsMensagem2.msgTipoLocal + clsMensagem2.msgDataEvento + clsMensagem2.msgHoraEvento + clsMensagem2.msgQTD + clsMensagem2.msgQTDMeia + clsMensagem2.msgQTDIntMeia + clsMensagem2.msgCartao + "*" + clsMensagem2.msgVencimento + clsMensagem2.msgCodigo + "*" + clsMensagem2.msgFormaPagamento + clsMensagem2.msgParecela + "*" + clsMensagem2.msgRespostaP03)) == Conversions.ToInteger(clsMensagem2.msgCheckSum))
					{
						clsFuncoes2.MsgConsole("IF DO P03 VALOR DE msgRespostaP03 " + clsMensagem2.msgRespostaP03);
						NetworkStream stream11 = socketClienteUra.GetStream();
						byte[] bytes7 = Encoding.ASCII.GetBytes(clsMensagem2.msgRespostaP03);
						stream11.Write(bytes7, 0, bytes7.Length);
						socketClienteUra.Close();
						clsFuncoes2.MsgConsole("VALOR DE P03 IF " + clsMensagem2.msgRespostaP03);
					}
					else
					{
						clsFuncoes2.MsgConsole("ELSE DO P03 VALOR DE msgRespostaP03");
						streamWriter3.WriteLine("Erro no resultado do calculo de verificacao");
						NetworkStream stream12 = socketClienteUra.GetStream();
						byte[] array4 = (byte[])NewLateBinding.LateGet((object)Encoding.ASCII, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(clsMensagem2.GeraErro()) }, (string[])null, (Type[])null, (bool[])null);
						stream12.Write(array4, 0, array4.Length);
						socketClienteUra.Close();
						clsFuncoes2.MsgConsole(Conversions.ToString(Operators.ConcatenateObject((object)"VALOR DO P03 NO ELSE ", clsMensagem2.GeraErro())));
					}
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P04", false) == 0)
				{
					clsFuncoes2.MsgConsole("Entrou no P04");
					string msgDiversao = clsMensagem2.msgDiversao;
					if (msgDiversao.Equals("01"))
					{
						clsFutebol obj4 = objJogos;
						clsMensagem clsMensagem3 = clsMensagem2;
						string text2 = clsMensagem3.msgPromoto;
						DataSet dataSet6 = obj4.PegaJogos(ref text2);
						clsMensagem3.msgPromoto = text2;
						dataSet4 = dataSet6;
						string text4 = null;
						string text5 = null;
						string text6 = null;
						int num3 = 0;
						string text7 = "0";
						if (dataSet4.Tables[0].Rows.Count > 0)
						{
							num3 = ((dataSet4.Tables[0].Rows.Count <= 2) ? dataSet4.Tables[0].Rows.Count : 2);
							int num4 = num3 - 1;
							for (int j = 0; j <= num4; j++)
							{
								text5 = text5 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet4.Tables[0].Rows[j]["idjogo"]), 6).ToString() + " ";
								text4 = text4 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet4.Tables[0].Rows[j]["jogo"].ToString()!.Substring(0, 3)), 4) + " " + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet4.Tables[0].Rows[j]["jogo"].ToString()!.Substring(3, 3)), 4) + " ";
								text6 = text6 + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet4.Tables[0].Rows[j]["data"]), "dd") + " " + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet4.Tables[0].Rows[j]["data"]), "MM") + " ";
								clsFuncoes2.MsgConsole("CODIGO DO JOGO P04 " + text5);
								clsFuncoes2.MsgConsole("TIMES DO P04 " + text4);
								clsFuncoes2.MsgConsole("DATA JOGOS DO JOGO P04 " + text6);
							}
							text7 = num3.ToString();
							clsFuncoes2.MsgConsole("QUANTIDADE DO JOGO P04 " + text7);
							if (Operators.CompareString(text5, (string)null, false) != 0)
							{
								text5 = " " + text5;
							}
							string text = clsMensagem2.msgTN + " " + text7 + text5 + text4 + text6;
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream13 = socketClienteUra.GetStream();
							byte[] bytes8 = Encoding.ASCII.GetBytes(text);
							stream13.Write(bytes8, 0, bytes8.Length);
							socketClienteUra.Close();
						}
						else
						{
							num3 = 0;
							string text = clsMensagem2.msgTN + " " + text7;
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream14 = socketClienteUra.GetStream();
							byte[] bytes9 = Encoding.ASCII.GetBytes(text);
							stream14.Write(bytes9, 0, bytes9.Length);
							socketClienteUra.Close();
						}
					}
					else if (msgDiversao.Equals("02"))
					{
						string text8 = null;
						int num5 = 0;
						string text9 = "0";
						clsCinema obj5 = objFilme;
						clsMensagem clsMensagem3 = clsMensagem2;
						string text2 = clsMensagem3.msgPromoto;
						DataSet dataSet7 = obj5.PegaFilmes(ref text2);
						clsMensagem3.msgPromoto = text2;
						dataSet3 = dataSet7;
						if (dataSet3.Tables[0].Rows.Count > 0)
						{
							num5 = dataSet3.Tables[0].Rows.Count;
							int num6 = num5 - 1;
							for (int k = 0; k <= num6; k++)
							{
								text8 = text8 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet3.Tables[0].Rows[k]["filme"]), 6).ToString() + " ";
								clsFuncoes2.MsgConsole("CODIGO DO FILMES P04 " + text8);
							}
							text9 = num5.ToString();
							clsFuncoes2.MsgConsole("QUANTIDADE DO FILMES P04 " + text9);
							if (Operators.CompareString(text8, (string)null, false) != 0)
							{
								text8 = " " + text8;
							}
							string text = clsMensagem2.msgTN + " " + text9 + text8;
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream15 = socketClienteUra.GetStream();
							byte[] bytes10 = Encoding.ASCII.GetBytes(text);
							stream15.Write(bytes10, 0, bytes10.Length);
							socketClienteUra.Close();
						}
						else
						{
							num5 = 0;
							string text = clsMensagem2.msgTN + " " + text9;
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream16 = socketClienteUra.GetStream();
							byte[] bytes11 = Encoding.ASCII.GetBytes(text);
							stream16.Write(bytes11, 0, bytes11.Length);
							socketClienteUra.Close();
						}
					}
					else if (!msgDiversao.Equals("03") && msgDiversao.Equals("04"))
					{
						clsShows obj6 = objShow;
						clsMensagem clsMensagem3 = clsMensagem2;
						string text2 = clsMensagem3.msgPromoto;
						clsMensagem clsMensagem4 = clsMensagem2;
						string strLugar = clsMensagem4.msgLocal;
						DataSet dataSet8 = obj6.PegaShows(ref text2, ref strLugar);
						clsMensagem4.msgLocal = strLugar;
						clsMensagem3.msgPromoto = text2;
						dataSet2 = dataSet8;
						string text10 = null;
						string text11 = null;
						int num7 = 0;
						string text12 = "0";
						if (dataSet2.Tables[0].Rows.Count > 0)
						{
							num7 = ((dataSet2.Tables[0].Rows.Count <= 2) ? dataSet2.Tables[0].Rows.Count : 2);
							int num8 = num7 - 1;
							for (int l = 0; l <= num8; l++)
							{
								text10 = text10 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet2.Tables[0].Rows[l]["idshow"]), 6).ToString() + " ";
								text11 = text11 + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet2.Tables[0].Rows[l]["data"]), "dd") + " " + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet2.Tables[0].Rows[l]["data"]), "MM") + " ";
								clsFuncoes2.MsgConsole("CODIGO DO SHOW P04 " + text10);
								clsFuncoes2.MsgConsole("DATA SHOW DO JOGO P04 " + text11);
							}
							text12 = num7.ToString();
							clsFuncoes2.MsgConsole("QUANTIDADE DO JOGO P04 " + text12);
							if (Operators.CompareString(text10, (string)null, false) != 0)
							{
								text10 = " " + text10;
							}
							string text = clsMensagem2.msgTN + " " + text12 + text10 + text11;
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream17 = socketClienteUra.GetStream();
							byte[] bytes12 = Encoding.ASCII.GetBytes(text);
							stream17.Write(bytes12, 0, bytes12.Length);
							socketClienteUra.Close();
						}
						else
						{
							num7 = 0;
							string text = clsMensagem2.msgTN + " " + text12;
							clsFuncoes2.MsgConsole(text);
							NetworkStream stream18 = socketClienteUra.GetStream();
							byte[] bytes13 = Encoding.ASCII.GetBytes(text);
							stream18.Write(bytes13, 0, bytes13.Length);
							socketClienteUra.Close();
						}
					}
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P05", false) == 0)
				{
					clsFuncoes2.MsgConsole("Entrou no P05");
					string msgDiversao2 = clsMensagem2.msgDiversao;
					if (msgDiversao2.Equals("01"))
					{
						clsFutebol obj7 = objJogos;
						clsMensagem clsMensagem4 = clsMensagem2;
						string strLugar = clsMensagem4.msgEvento;
						DataSet dataSet9 = obj7.PegaJogoCod(ref strLugar);
						clsMensagem4.msgEvento = strLugar;
						dataSet4 = dataSet9;
						string text13 = null;
						if (dataSet4.Tables[0].Rows.Count > 0)
						{
							int num9 = dataSet4.Tables[0].Rows.Count - 1;
							for (int m = 0; m <= num9; m++)
							{
								text13 = text13 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet4.Tables[0].Rows[m]["jogo"].ToString()!.Substring(0, 3)), 4) + " " + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet4.Tables[0].Rows[m]["jogo"].ToString()!.Substring(3, 3)), 4) + " ";
							}
						}
						string text = clsMensagem2.msgTN + " " + text13;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream19 = socketClienteUra.GetStream();
						byte[] bytes14 = Encoding.ASCII.GetBytes(text);
						stream19.Write(bytes14, 0, bytes14.Length);
						socketClienteUra.Close();
					}
					else if (msgDiversao2.Equals("02"))
					{
						clsCinema obj8 = objFilme;
						clsMensagem clsMensagem4 = clsMensagem2;
						string strLugar = clsMensagem4.msgEvento;
						clsMensagem clsMensagem3 = clsMensagem2;
						string text2 = clsMensagem3.msgPromoto;
						clsMensagem clsMensagem5 = clsMensagem2;
						string strCodLocal = clsMensagem5.msgLocal;
						clsMensagem clsMensagem6 = clsMensagem2;
						string strCodData = clsMensagem6.msgTipoLocal;
						DataSet dataSet10 = obj8.PegaCodFilme(ref strLugar, ref text2, ref strCodLocal, ref strCodData);
						clsMensagem6.msgTipoLocal = strCodData;
						clsMensagem5.msgLocal = strCodLocal;
						clsMensagem3.msgPromoto = text2;
						clsMensagem4.msgEvento = strLugar;
						dataSet3 = dataSet10;
						string text14 = null;
						string text15 = null;
						if (dataSet3.Tables[0].Rows.Count > 0)
						{
							int num10 = dataSet3.Tables[0].Rows.Count - 1;
							for (int n = 0; n <= num10; n++)
							{
								text14 = text14 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet3.Tables[0].Rows[n]["idfilme"].ToString()), 6) + " ";
								text15 = text15 + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet3.Tables[0].Rows[n]["data"]), "dd") + " " + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet3.Tables[0].Rows[n]["data"]), "MM") + " ";
							}
						}
						string text = clsMensagem2.msgTN + " " + text14 + text15;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream20 = socketClienteUra.GetStream();
						byte[] bytes15 = Encoding.ASCII.GetBytes(text);
						stream20.Write(bytes15, 0, bytes15.Length);
						socketClienteUra.Close();
					}
					else if (!msgDiversao2.Equals("03") && msgDiversao2.Equals("04"))
					{
						clsShows obj9 = objShow;
						clsMensagem clsMensagem6 = clsMensagem2;
						string strCodData = clsMensagem6.msgEvento;
						DataSet dataSet11 = obj9.PegaShowCod(ref strCodData);
						clsMensagem6.msgEvento = strCodData;
						dataSet2 = dataSet11;
						string text16 = null;
						string text17 = null;
						string text18 = null;
						if (dataSet2.Tables[0].Rows.Count > 0)
						{
							int num11 = dataSet2.Tables[0].Rows.Count - 1;
							for (int num12 = 0; num12 <= num11; num12++)
							{
								text16 = text16 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet2.Tables[0].Rows[num12]["idshow"].ToString()), 6) + " ";
								text17 = text17 + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet2.Tables[0].Rows[num12]["data"]), "dd") + " " + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet2.Tables[0].Rows[num12]["data"]), "MM") + " ";
								text18 = text18 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet2.Tables[0].Rows[num12]["idartista"].ToString()), 4) + " ";
							}
						}
						string text = clsMensagem2.msgTN + " " + text16 + text18 + text17;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream21 = socketClienteUra.GetStream();
						byte[] bytes16 = Encoding.ASCII.GetBytes(text);
						stream21.Write(bytes16, 0, bytes16.Length);
						socketClienteUra.Close();
					}
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P06", false) == 0)
				{
					clsFuncoes2.MsgConsole("Entrou no P06");
					string msgDiversao3 = clsMensagem2.msgDiversao;
					if (msgDiversao3.Equals("01"))
					{
						clsFutebol obj10 = objLocais;
						clsMensagem clsMensagem6 = clsMensagem2;
						string strCodData = clsMensagem6.msgEvento;
						DataSet dataSet12 = obj10.PegaLocais(ref strCodData);
						clsMensagem6.msgEvento = strCodData;
						dataSet5 = dataSet12;
						string text19 = null;
						string text20 = "0";
						if (dataSet5.Tables[0].Rows.Count > 0)
						{
							int num13 = dataSet5.Tables[0].Rows.Count - 1;
							for (int num14 = 0; num14 <= num13; num14++)
							{
								text19 = text19 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet5.Tables[0].Rows[num14]["idlugar"]), 6).ToString() + " ";
							}
							text20 = Conversions.ToString(dataSet5.Tables[0].Rows.Count);
							clsFuncoes2.MsgConsole("QUANTIDADE LOCAIS NO P06 " + text20);
						}
						string text = clsMensagem2.msgTN + " " + text20 + " " + text19;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream22 = socketClienteUra.GetStream();
						byte[] bytes17 = Encoding.ASCII.GetBytes(text);
						stream22.Write(bytes17, 0, bytes17.Length);
						socketClienteUra.Close();
					}
					else if (msgDiversao3.Equals("02"))
					{
						clsCinema obj11 = objShopping;
						clsMensagem clsMensagem6 = clsMensagem2;
						string strCodData = clsMensagem6.msgEvento;
						clsMensagem clsMensagem5 = clsMensagem2;
						string strCodLocal = clsMensagem5.msgPromoto;
						clsMensagem clsMensagem4 = clsMensagem2;
						string strLugar = clsMensagem4.msgTipoLocal;
						DataSet dataSet13 = obj11.PegaShopping(ref strCodData, ref strCodLocal, ref strLugar);
						clsMensagem4.msgTipoLocal = strLugar;
						clsMensagem5.msgPromoto = strCodLocal;
						clsMensagem6.msgEvento = strCodData;
						dataSet5 = dataSet13;
						string text21 = null;
						string text22 = "0";
						if (dataSet5.Tables[0].Rows.Count > 0)
						{
							int num15 = dataSet5.Tables[0].Rows.Count - 1;
							for (int num16 = 0; num16 <= num15; num16++)
							{
								text21 = text21 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet5.Tables[0].Rows[num16]["idshopping"].ToString()), 6) + " ";
							}
							text22 = Conversions.ToString(dataSet5.Tables[0].Rows.Count);
							clsFuncoes2.MsgConsole("QUANTIDADE LOCAIS NO P06 " + text22);
						}
						string text = clsMensagem2.msgTN + " " + text22 + " " + text21;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream23 = socketClienteUra.GetStream();
						byte[] bytes18 = Encoding.ASCII.GetBytes(text);
						stream23.Write(bytes18, 0, bytes18.Length);
						socketClienteUra.Close();
					}
					else if (!msgDiversao3.Equals("03") && msgDiversao3.Equals("04"))
					{
						clsShows obj12 = objAcentoShow;
						clsMensagem clsMensagem6 = clsMensagem2;
						string strCodData = clsMensagem6.msgEvento;
						DataSet dataSet14 = obj12.PegaAcento(ref strCodData);
						clsMensagem6.msgEvento = strCodData;
						dataSet5 = dataSet14;
						string text23 = null;
						string text24 = null;
						string text25 = null;
						string text26 = "0";
						if (dataSet5.Tables[0].Rows.Count > 0)
						{
							int num17 = dataSet5.Tables[0].Rows.Count - 1;
							for (int num18 = 0; num18 <= num17; num18++)
							{
								text25 = text25 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet5.Tables[0].Rows[num18]["idacento"]), 6).ToString() + " ";
								text24 = dataSet5.Tables[0].Rows[num18]["nome"].ToString();
								text23 = text23 + text24.Trim() + " ";
							}
							text26 = Conversions.ToString(dataSet5.Tables[0].Rows.Count);
							clsFuncoes2.MsgConsole("QUANTIDADE LOCAIS NO P06 " + text26);
						}
						string text = clsMensagem2.msgTN + " " + text26 + " " + text25 + text23;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream24 = socketClienteUra.GetStream();
						byte[] bytes19 = Encoding.ASCII.GetBytes(text);
						stream24.Write(bytes19, 0, bytes19.Length);
						socketClienteUra.Close();
					}
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P07", false) == 0)
				{
					string msgDiversao4 = clsMensagem2.msgDiversao;
					if (msgDiversao4.Equals("01"))
					{
						clsFutebol obj13 = objTimes;
						clsMensagem clsMensagem6 = clsMensagem2;
						string strCodData = clsMensagem6.msgCodRegiao;
						DataSet dataSet15 = obj13.PegaTimes(ref strCodData);
						clsMensagem6.msgCodRegiao = strCodData;
						dataSet = dataSet15;
						string text27 = null;
						string text28 = "0";
						if (dataSet.Tables[0].Rows.Count > 0)
						{
							int num19 = dataSet.Tables[0].Rows.Count - 1;
							for (int num20 = 0; num20 <= num19; num20++)
							{
								text27 = text27 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet.Tables[0].Rows[num20]["idtimes"]), 4) + " ";
							}
							text28 = Conversions.ToString(dataSet.Tables[0].Rows.Count);
						}
						if (Operators.CompareString(text27, (string)null, false) != 0)
						{
							text27 = " " + text27;
						}
						string text = clsMensagem2.msgTN + " " + text28 + text27;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream25 = socketClienteUra.GetStream();
						byte[] bytes20 = Encoding.ASCII.GetBytes(text);
						stream25.Write(bytes20, 0, bytes20.Length);
						socketClienteUra.Close();
					}
					else if (msgDiversao4.Equals("02"))
					{
						clsCinema obj14 = objFilme;
						clsMensagem clsMensagem6 = clsMensagem2;
						string strCodData = clsMensagem6.msgCodRegiao;
						DataSet dataSet16 = obj14.PegaRedes(ref strCodData);
						clsMensagem6.msgCodRegiao = strCodData;
						dataSet3 = dataSet16;
						string text29 = null;
						string text30 = "0";
						if (dataSet3.Tables[0].Rows.Count > 0)
						{
							int num21 = dataSet3.Tables[0].Rows.Count - 1;
							for (int num22 = 0; num22 <= num21; num22++)
							{
								text29 = text29 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet3.Tables[0].Rows[num22]["idartista"]), 4) + " ";
							}
							text30 = Conversions.ToString(dataSet3.Tables[0].Rows.Count);
						}
						if (Operators.CompareString(text29, (string)null, false) != 0)
						{
							text29 = " " + text29;
						}
						string text = clsMensagem2.msgTN + " " + text30 + text29;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream26 = socketClienteUra.GetStream();
						byte[] bytes21 = Encoding.ASCII.GetBytes(text);
						stream26.Write(bytes21, 0, bytes21.Length);
						socketClienteUra.Close();
					}
					else if (!msgDiversao4.Equals("03") && msgDiversao4.Equals("04"))
					{
						clsShows obj15 = objArtista;
						clsMensagem clsMensagem6 = clsMensagem2;
						string strCodData = clsMensagem6.msgCodRegiao;
						DataSet dataSet17 = obj15.PegaArtistas(ref strCodData);
						clsMensagem6.msgCodRegiao = strCodData;
						dataSet2 = dataSet17;
						string text31 = null;
						string text32 = "0";
						if (dataSet2.Tables[0].Rows.Count > 0)
						{
							int num23 = dataSet2.Tables[0].Rows.Count - 1;
							for (int num24 = 0; num24 <= num23; num24++)
							{
								text31 = text31 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet2.Tables[0].Rows[num24]["idartista"]), 4) + " ";
							}
							text32 = Conversions.ToString(dataSet2.Tables[0].Rows.Count);
						}
						if (Operators.CompareString(text31, (string)null, false) != 0)
						{
							text31 = " " + text31;
						}
						string text = clsMensagem2.msgTN + " " + text32 + text31;
						clsFuncoes2.MsgConsole(text);
						NetworkStream stream27 = socketClienteUra.GetStream();
						byte[] bytes22 = Encoding.ASCII.GetBytes(text);
						stream27.Write(bytes22, 0, bytes22.Length);
						socketClienteUra.Close();
					}
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P08", false) == 0)
				{
					clsFuncoes2.MsgConsole("Entrou no P08");
					NetworkStream stream28 = socketServidorRemoto.GetStream();
					StreamWriter streamWriter4 = new StreamWriter(stream28);
					string text = Conversions.ToString(clsMensagem2.GeraMensagemP02());
					streamWriter4.WriteLine(text);
					clsFuncoes2.MsgConsole(text);
					streamWriter4.Flush();
					StreamReader streamReader4 = new StreamReader(stream28);
					text = streamReader4.ReadLine()!.ToString();
					clsFuncoes2.MsgConsole(text);
					clsMensagem obj16 = clsMensagem2;
					string strCodData = "1" + text;
					clsMensagem2 = obj16.Recupera_Mensagem(ref strCodData);
					if (Conversions.ToInteger(clsFuncoes2.Calcular_Check_Sum(clsMensagem2.msgProtocolo + clsMensagem2.msgTN + clsMensagem2.msgVersao + clsMensagem2.msgTelefone + "*" + clsMensagem2.msgCelular + "*" + clsMensagem2.msgDiversao + clsMensagem2.msgEvento + clsMensagem2.msgLocal + clsMensagem2.msgQTD + clsMensagem2.msgQTDMeia + clsMensagem2.msgQTDIntMeia + clsMensagem2.msgValorCompra + clsMensagem2.msgTaxaServico + clsMensagem2.msgParcelado + clsMensagem2.msgVagas + clsMensagem2.msgRespostaP02)) == Conversions.ToInteger(clsMensagem2.msgCheckSum))
					{
						text = clsMensagem2.msgTN + " " + clsMensagem2.msgRespostaP02;
						NetworkStream stream29 = socketClienteUra.GetStream();
						byte[] bytes23 = Encoding.ASCII.GetBytes(text);
						stream29.Write(bytes23, 0, bytes23.Length);
						socketClienteUra.Close();
						clsFuncoes2.MsgConsole(text);
					}
					else
					{
						streamWriter4.WriteLine("Erro no resultado do calculo de verificacao");
						NetworkStream stream30 = socketClienteUra.GetStream();
						byte[] array5 = (byte[])NewLateBinding.LateGet((object)Encoding.ASCII, (Type)null, "GetBytes", new object[1] { RuntimeHelpers.GetObjectValue(clsMensagem2.GeraErro()) }, (string[])null, (Type[])null, (bool[])null);
						stream30.Write(array5, 0, array5.Length);
						socketClienteUra.Close();
						clsFuncoes2.MsgConsole(Conversions.ToString(clsMensagem2.GeraErro()));
					}
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P09", false) == 0)
				{
					clsCinema obj17 = objFilme;
					clsMensagem clsMensagem6 = clsMensagem2;
					string strCodData = clsMensagem6.msgEvento;
					clsMensagem clsMensagem5 = clsMensagem2;
					string strCodLocal = clsMensagem5.msgPromoto;
					clsMensagem clsMensagem4 = clsMensagem2;
					string strLugar = clsMensagem4.msgLocal;
					DataSet dataSet18 = obj17.PegaDataFilme(ref strCodData, ref strCodLocal, ref strLugar);
					clsMensagem4.msgLocal = strLugar;
					clsMensagem5.msgPromoto = strCodLocal;
					clsMensagem6.msgEvento = strCodData;
					dataSet3 = dataSet18;
					string text33 = null;
					string text34 = null;
					string text35 = null;
					if (dataSet3.Tables[0].Rows.Count > 0)
					{
						int num25 = dataSet3.Tables[0].Rows.Count - 1;
						for (int num26 = 0; num26 <= num25; num26++)
						{
							text33 = text33 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet3.Tables[0].Rows[num26]["iddata"]), 2).ToString() + " ";
							text35 = text35 + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet3.Tables[0].Rows[num26]["data"]), "dd") + " " + Strings.Format(RuntimeHelpers.GetObjectValue(dataSet3.Tables[0].Rows[num26]["data"]), "MM") + " ";
						}
					}
					text34 = dataSet3.Tables[0].Rows.Count + " ";
					string text = clsMensagem2.msgTN + " " + text34 + text33 + text35;
					clsFuncoes2.MsgConsole(text);
					NetworkStream stream31 = socketClienteUra.GetStream();
					byte[] bytes24 = Encoding.ASCII.GetBytes(text);
					stream31.Write(bytes24, 0, bytes24.Length);
					socketClienteUra.Close();
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "P10", false) == 0)
				{
					clsCinema obj18 = objFilme;
					clsMensagem clsMensagem6 = clsMensagem2;
					string strCodData = clsMensagem6.msgEvento;
					clsMensagem clsMensagem5 = clsMensagem2;
					string strCodLocal = clsMensagem5.msgPromoto;
					clsMensagem clsMensagem4 = clsMensagem2;
					string strLugar = clsMensagem4.msgLocal;
					clsMensagem clsMensagem3 = clsMensagem2;
					string text2 = clsMensagem3.msgTipoLocal;
					DataSet dataSet19 = obj18.PegaHoraFilme(ref strCodData, ref strCodLocal, ref strLugar, ref text2);
					clsMensagem3.msgTipoLocal = text2;
					clsMensagem4.msgLocal = strLugar;
					clsMensagem5.msgPromoto = strCodLocal;
					clsMensagem6.msgEvento = strCodData;
					dataSet3 = dataSet19;
					string text36 = null;
					string text37 = null;
					string text38 = null;
					if (dataSet3.Tables[0].Rows.Count > 0)
					{
						int num27 = dataSet3.Tables[0].Rows.Count - 1;
						for (int num28 = 0; num28 <= num27; num28++)
						{
							text38 = text38 + dataSet3.Tables[0].Rows[num28]["hora"].ToString()!.Trim() + " ";
						}
						text36 = text36 + clsFuncoes2.ZerosEsquerda(Conversions.ToInteger(dataSet3.Tables[0].Rows[0]["idfilme"]), 6) + " ";
					}
					text37 = dataSet3.Tables[0].Rows.Count + " ";
					string text = clsMensagem2.msgTN + " " + text37 + text36 + text38;
					clsFuncoes2.MsgConsole(text);
					NetworkStream stream32 = socketClienteUra.GetStream();
					byte[] bytes25 = Encoding.ASCII.GetBytes(text);
					stream32.Write(bytes25, 0, bytes25.Length);
					socketClienteUra.Close();
				}
				else if (Operators.CompareString(clsMensagem2.msgProtocolo, "ERRO", false) == 0)
				{
					clsFuncoes2.MsgConsole("ERRO AO RECUPERAR OS DADOS ");
					clsFuncoes2.MsgConsole("CONEXAO FINALIZADA ");
					socketServidorRemoto.Close();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				clsFuncoes2.MsgConsole("CONEXAO FINALIZADA ");
				socketServidorRemoto.Close();
				ProjectData.ClearProjectError();
			}
			dataSet.Dispose();
			dataSet4.Dispose();
			dataSet5.Dispose();
			dataSet2.Dispose();
		}
	}
}

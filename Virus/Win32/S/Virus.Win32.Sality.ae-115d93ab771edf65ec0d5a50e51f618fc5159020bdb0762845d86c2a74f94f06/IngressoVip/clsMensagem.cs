using System;
using Microsoft.VisualBasic.CompilerServices;

namespace IngressoVip;

public class clsMensagem
{
	public enum TipoMensagem
	{
		URA,
		Servidor
	}

	private string strRetorno;

	private int intOrigem;

	private string strTelefone;

	private string strCelular;

	private string strProtocolo;

	private string strPromoto;

	private string _strTN;

	private string strVersao;

	private string strTipoLocal;

	private string strRespostaP01;

	private string strRespostaP02;

	private string strRespostaP03;

	private string strValorCompra;

	private string strDataEvento;

	private string strHoraEvento;

	private string strCheckSum;

	private string strEvento;

	private string strDiversao;

	private string strCodRegial;

	private string strPedido;

	private string strVagas;

	private string strParcelado;

	private string strPromotor;

	private string strLocal;

	private string strQTD;

	private string strQTDMeia;

	private string strQTDIntMeia;

	private string strCartao;

	private string strVencimento;

	private string strCodigo;

	private string strFormaPagamento;

	private string strNumParecelas;

	private string strValorUnitario;

	private string strTaxaServico;

	private clsFuncoes objFuncoes;

	public string msgCartao
	{
		get
		{
			return strCartao;
		}
		set
		{
			strCartao = value;
		}
	}

	public string msgVencimento
	{
		get
		{
			return strVencimento;
		}
		set
		{
			strVencimento = value;
		}
	}

	public string msgDataEvento
	{
		get
		{
			return strDataEvento;
		}
		set
		{
			strDataEvento = value;
		}
	}

	public string msgHoraEvento
	{
		get
		{
			return strHoraEvento;
		}
		set
		{
			strHoraEvento = value;
		}
	}

	public string msgCodigo
	{
		get
		{
			return strCodigo;
		}
		set
		{
			strCodigo = value;
		}
	}

	public string msgEvento
	{
		get
		{
			return strEvento;
		}
		set
		{
			strEvento = value;
		}
	}

	public string msgDiversao
	{
		get
		{
			return strDiversao;
		}
		set
		{
			strDiversao = value;
		}
	}

	public string msgPromoto
	{
		get
		{
			return strPromotor;
		}
		set
		{
			strPromotor = value;
		}
	}

	public string msgLocal
	{
		get
		{
			return strLocal;
		}
		set
		{
			strLocal = value;
		}
	}

	public string msgTipoLocal
	{
		get
		{
			return strTipoLocal;
		}
		set
		{
			strTipoLocal = value;
		}
	}

	public string msgQTD
	{
		get
		{
			return strQTD;
		}
		set
		{
			strQTD = value;
		}
	}

	public string msgQTDMeia
	{
		get
		{
			return strQTDMeia;
		}
		set
		{
			strQTDMeia = value;
		}
	}

	public string msgQTDIntMeia
	{
		get
		{
			return strQTDIntMeia;
		}
		set
		{
			strQTDIntMeia = value;
		}
	}

	public string msgPedido
	{
		get
		{
			return strPedido;
		}
		set
		{
			strPedido = value;
		}
	}

	public string msgVagas
	{
		get
		{
			return strVagas;
		}
		set
		{
			strVagas = value;
		}
	}

	public string msgCheckSum
	{
		get
		{
			return strCheckSum;
		}
		set
		{
			strCheckSum = value;
		}
	}

	public string msgRespostaP01
	{
		get
		{
			return strRespostaP01;
		}
		set
		{
			strRespostaP01 = value;
		}
	}

	public string msgRespostaP02
	{
		get
		{
			return strRespostaP02;
		}
		set
		{
			strRespostaP02 = value;
		}
	}

	public string msgRespostaP03
	{
		get
		{
			return strRespostaP03;
		}
		set
		{
			strRespostaP03 = value;
		}
	}

	public string msgValorCompra
	{
		get
		{
			return strValorCompra;
		}
		set
		{
			strValorCompra = value;
		}
	}

	public string msgVersao
	{
		get
		{
			return strVersao;
		}
		set
		{
			strVersao = value;
		}
	}

	public string msgTN
	{
		get
		{
			return _strTN;
		}
		set
		{
			_strTN = value;
		}
	}

	public int msgOrigem
	{
		get
		{
			return intOrigem;
		}
		set
		{
			intOrigem = value;
		}
	}

	public string msgProtocolo
	{
		get
		{
			return strProtocolo;
		}
		set
		{
			strProtocolo = value;
		}
	}

	public string msgParcelado
	{
		get
		{
			return strParcelado;
		}
		set
		{
			strParcelado = value;
		}
	}

	public string msgTelefone
	{
		get
		{
			return strTelefone;
		}
		set
		{
			strTelefone = value;
		}
	}

	public string msgCelular
	{
		get
		{
			return strCelular;
		}
		set
		{
			strCelular = value;
		}
	}

	public string msgCodRegiao
	{
		get
		{
			return strCodRegial;
		}
		set
		{
			strCodRegial = value;
		}
	}

	public string msgFormaPagamento
	{
		get
		{
			return strFormaPagamento;
		}
		set
		{
			strFormaPagamento = value;
		}
	}

	public string msgParecela
	{
		get
		{
			return strNumParecelas;
		}
		set
		{
			strNumParecelas = value;
		}
	}

	public string msgValorUnitario
	{
		get
		{
			return strValorUnitario;
		}
		set
		{
			strValorUnitario = value;
		}
	}

	public string msgTaxaServico
	{
		get
		{
			return strTaxaServico;
		}
		set
		{
			strTaxaServico = value;
		}
	}

	public clsMensagem()
	{
		objFuncoes = new clsFuncoes();
	}

	public clsMensagem Recupera_Mensagem(ref string strString)
	{
		clsMensagem clsMensagem2 = new clsMensagem();
		checked
		{
			try
			{
				clsMensagem clsMensagem3 = clsMensagem2;
				clsMensagem3.msgOrigem = Conversions.ToInteger(strString.Substring(0, 1));
				objFuncoes.MsgConsole("STRING: -- " + strString.ToString());
				if (clsMensagem3.msgOrigem == 0)
				{
					objFuncoes.MsgConsole("TIPO DE MENSAGEM: URA (" + strString.Length + ")");
					objFuncoes.MsgConsole("MENSAGEM: URA (" + strString + ")");
					clsMensagem3.msgProtocolo = strString.Substring(1, 3);
					objFuncoes.MsgConsole("VALOR PROTOCOLO " + clsMensagem3.msgProtocolo.ToString());
					clsMensagem3.msgTN = strString.Substring(4, 16);
					objFuncoes.MsgConsole("VALOR TN " + clsMensagem3.msgTN.ToString());
					int num = strString.IndexOf("*");
					objFuncoes.MsgConsole("VALOR DE CART " + num);
					int length = num - 20;
					objFuncoes.MsgConsole("VALOR DE tamCart " + length);
					clsMensagem3.msgTelefone = strString.Substring(20, length);
					objFuncoes.MsgConsole("VALOR TELEFONE " + clsMensagem3.msgTelefone.ToString());
					int num2 = strString.IndexOf("*", num + 1);
					objFuncoes.MsgConsole("VALOR tamCod " + num2);
					int num3 = num + 1;
					length = num2 - num3;
					objFuncoes.MsgConsole("VALOR tamCart " + length);
					clsMensagem3.msgCelular = strString.Substring(num + 1, length);
					objFuncoes.MsgConsole("VALOR CELULAR " + clsMensagem3.msgCelular.ToString());
					num3 = num2 + 1;
					objFuncoes.MsgConsole("VALOR cod " + num3);
					if (clsMensagem3.msgProtocolo.ToString().Equals("P07"))
					{
						clsMensagem3.msgCodRegiao = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR CODREGIAO NO P07 " + clsMensagem3.msgCodRegiao.ToString());
						num3 += 2;
						clsMensagem3.msgDiversao = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR DIVERSAO NO P07 " + clsMensagem3.msgDiversao.ToString());
					}
					else if (clsMensagem3.msgProtocolo.ToString().Equals("P03"))
					{
						clsMensagem3.msgPromoto = strString.Substring(num3, 4);
						objFuncoes.MsgConsole("VALOR PROMOTO " + clsMensagem3.msgPromoto.ToString());
						num3 += 4;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgDiversao = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR DIVERSAO " + clsMensagem3.msgDiversao.ToString());
						num3 += 2;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgEvento = strString.Substring(num3, 6);
						objFuncoes.MsgConsole("VALOR EVENTO " + clsMensagem3.msgEvento.ToString());
						num3 += 6;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgLocal = strString.Substring(num3, 6);
						objFuncoes.MsgConsole("VALOR LOCAL " + clsMensagem3.msgLocal.ToString());
						num3 += 6;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgTipoLocal = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR TIPO LOCAL " + clsMensagem3.msgTipoLocal.ToString());
						num3 += 2;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgDataEvento = strString.Substring(num3, 4);
						objFuncoes.MsgConsole("VALOR DATA EVENTO " + clsMensagem3.msgDataEvento.ToString());
						num3 += 4;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgHoraEvento = strString.Substring(num3, 4);
						objFuncoes.MsgConsole("VALOR HORA EVENTO " + clsMensagem3.msgHoraEvento.ToString());
						num3 += 4;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgQTD = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR QUANTIDADE INTEIRA " + clsMensagem3.msgQTD.ToString());
						num3 += 2;
						clsMensagem3.msgQTDMeia = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR QUANTIDADE MEIA " + clsMensagem3.msgQTDMeia.ToString());
						num3 += 2;
						clsMensagem3.msgQTDIntMeia = strString.Substring(num3, 3);
						objFuncoes.MsgConsole("VALOR QUANTIDADE MEIA-INTEIRA " + clsMensagem3.msgQTDIntMeia.ToString());
						num3 += 3;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						num = strString.IndexOf("*", num3);
						objFuncoes.MsgConsole("VALOR DE CART " + num);
						length = num - num3;
						objFuncoes.MsgConsole("VALOR DE tamCart " + length);
						clsMensagem3.msgCartao = strString.Substring(num3, length);
						objFuncoes.MsgConsole("VALOR DE CARTAO " + clsMensagem3.msgCartao.ToString());
						clsMensagem3.msgVencimento = strString.Substring(num + 1, 4);
						objFuncoes.MsgConsole("VALOR VENCIMENTO " + clsMensagem3.msgVencimento.ToString());
						num3 = num + 5;
						objFuncoes.MsgConsole("VALOR Cod " + num3);
						num2 = strString.IndexOf("*", num + 1);
						num2 -= num3;
						objFuncoes.MsgConsole("VALOR tamCod " + num2);
						clsMensagem3.msgCodigo = strString.Substring(num3, num2);
						objFuncoes.MsgConsole("VALOR CODIGO SEGURANCA " + clsMensagem3.msgCodigo.ToString());
						num3 += num2;
						clsMensagem3.msgFormaPagamento = strString.Substring(num3 + 1, 2);
						objFuncoes.MsgConsole("VALOR FORMA PAGAMENTO " + clsMensagem3.msgFormaPagamento.ToString());
						num3 += 2;
						objFuncoes.MsgConsole("VALOR Cod " + num3);
						clsMensagem3.msgParecela = strString.Substring(num3 + 1, strString.Length - (num3 + 1));
						objFuncoes.MsgConsole("VALOR PARCELAS " + clsMensagem3.msgParecela.ToString());
					}
					else
					{
						clsMensagem3.msgPromoto = strString.Substring(num3, 4);
						objFuncoes.MsgConsole("VALOR PROMOTOR " + clsMensagem3.msgPromoto.ToString());
						num3 += 4;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgDiversao = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR DIVERSAO " + clsMensagem3.msgDiversao.ToString());
						num3 += 2;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgEvento = strString.Substring(num3, 6);
						objFuncoes.MsgConsole("VALOR EVENTO " + clsMensagem3.msgEvento.ToString());
						num3 += 6;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgLocal = strString.Substring(num3, 6);
						objFuncoes.MsgConsole("VALOR LOCAL " + clsMensagem3.msgLocal.ToString());
						num3 += 6;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgTipoLocal = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR TIPO LOCAL " + clsMensagem3.msgTipoLocal.ToString());
						num3 += 2;
						objFuncoes.MsgConsole("VALOR cod " + num3);
						clsMensagem3.msgQTD = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR QUANTIDADE INTEIRA " + clsMensagem3.msgQTD.ToString());
						num3 += 2;
						clsMensagem3.msgQTDMeia = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR QUANTIDADE MEIA " + clsMensagem3.msgQTDMeia.ToString());
						num3 += 2;
						clsMensagem3.msgQTDIntMeia = strString.Substring(num3, 3);
						objFuncoes.MsgConsole("VALOR QUANTIDADE MEIA-INTEIRA " + clsMensagem3.msgQTDIntMeia.ToString());
						num3 += 3;
						clsMensagem3.msgPedido = strString.Substring(num3, 1);
						objFuncoes.MsgConsole("VALOR STATUS PEDIDO " + clsMensagem3.msgPedido.ToString());
						num3++;
					}
				}
				else if (clsMensagem3.msgOrigem == 1)
				{
					objFuncoes.MsgConsole("TIPO DE MENSAGEM: SERVIDOR (" + strString.Length + ")");
					objFuncoes.MsgConsole("MENSAGEM: SERVIDOR (" + strString + ")");
					clsMensagem3.msgProtocolo = strString.Substring(2, 3);
					if (Operators.CompareString(clsMensagem3.msgProtocolo, "P01", false) == 0)
					{
						clsMensagem3.msgTN = strString.Substring(5, 16);
						objFuncoes.MsgConsole("VALOR DO TN NO P01 " + clsMensagem3.msgTN.ToString());
						clsMensagem3.msgVersao = strString.Substring(21, 3);
						objFuncoes.MsgConsole("VALOR VERSAO NO P01 " + clsMensagem3.msgVersao.ToString());
						int num = strString.IndexOf("*");
						objFuncoes.MsgConsole("VALOR DE CART " + num);
						int length = num - 24;
						objFuncoes.MsgConsole("VALOR DE tamCart " + length);
						clsMensagem3.msgTelefone = strString.Substring(24, length);
						objFuncoes.MsgConsole("VALOR TELEFONE NO P01 " + clsMensagem3.msgTelefone.ToString());
						int num2 = strString.IndexOf("*", num + 1);
						objFuncoes.MsgConsole("VALOR tamCod " + num2);
						int num3 = num + 1;
						length = num2 - num3;
						objFuncoes.MsgConsole("VALOR tamCart " + length);
						clsMensagem3.msgCelular = strString.Substring(num + 1, length);
						objFuncoes.MsgConsole("VALOR CELULAR NO P01 " + clsMensagem3.msgCelular.ToString());
						num3 = num2 + 1;
						clsMensagem3.msgRespostaP01 = strString.Substring(num3, 1);
						objFuncoes.MsgConsole("VALOR RESPOSTA DO P01 " + clsMensagem3.msgRespostaP01.ToString());
						num3++;
						clsMensagem3.msgCodRegiao = strString.Substring(num3, 2);
						objFuncoes.MsgConsole("VALOR CODREGIAO NO P01 " + clsMensagem3.msgCodRegiao.ToString());
						clsMensagem3.msgCheckSum = strString.Substring(strString.Length - 4, 3);
						objFuncoes.MsgConsole("VALOR CHECKSUM " + clsMensagem3.msgCheckSum.ToString());
					}
					else if (Operators.CompareString(clsMensagem3.msgProtocolo, "P02", false) == 0)
					{
						clsMensagem3.msgTN = strString.Substring(5, 16);
						objFuncoes.MsgConsole("VALOR TN NO P02 " + clsMensagem3.msgTN.ToString());
						clsMensagem3.msgVersao = strString.Substring(21, 3);
						objFuncoes.MsgConsole("VALOR VERSAO NO P02 " + clsMensagem3.msgVersao.ToString());
						clsMensagem3.msgTelefone = strString.Substring(24, 10);
						objFuncoes.MsgConsole("VALOR TELEFONE NO P02 " + clsMensagem3.msgTelefone.ToString());
						clsMensagem3.msgCelular = strString.Substring(35, 10);
						objFuncoes.MsgConsole("VALOR CELULAR NO P02 " + clsMensagem3.msgCelular.ToString());
						clsMensagem3.msgDiversao = strString.Substring(46, 2);
						objFuncoes.MsgConsole("VALOR DIVERSAO NO P02 " + clsMensagem3.msgDiversao.ToString());
						clsMensagem3.msgEvento = strString.Substring(48, 6);
						objFuncoes.MsgConsole("VALOR EVENTO NO P02 " + clsMensagem3.msgEvento.ToString());
						clsMensagem3.msgLocal = strString.Substring(54, 6);
						objFuncoes.MsgConsole("VALOR LOCAL NO P02 " + clsMensagem3.msgLocal.ToString());
						clsMensagem3.msgTipoLocal = strString.Substring(60, 2);
						objFuncoes.MsgConsole("VALOR TIPO LOCAL NO P02 " + clsMensagem3.msgTipoLocal.ToString());
						clsMensagem3.msgQTD = strString.Substring(62, 2);
						objFuncoes.MsgConsole("VALOR QUANTIDADE INTEIRA NO P02 " + clsMensagem3.msgQTD.ToString());
						clsMensagem3.msgQTDMeia = strString.Substring(64, 2);
						objFuncoes.MsgConsole("VALOR QUANTIDADE MEIA NO P02 " + clsMensagem3.msgQTDMeia.ToString());
						clsMensagem3.msgQTDIntMeia = strString.Substring(66, 3);
						objFuncoes.MsgConsole("VALOR QUANTIDADE MEIA-INTEIRA NO P02 " + clsMensagem3.msgQTDIntMeia.ToString());
						clsMensagem3.msgValorCompra = strString.Substring(69, 12);
						objFuncoes.MsgConsole("VALOR VALOR COMPRA NO P02 " + clsMensagem3.msgValorCompra.ToString());
						clsMensagem3.msgTaxaServico = strString.Substring(81, 6);
						objFuncoes.MsgConsole("VALOR VALOR TAXA NO P02 " + clsMensagem3.msgTaxaServico.ToString());
						clsMensagem3.msgParcelado = strString.Substring(87, 2);
						objFuncoes.MsgConsole("VALOR VALOR PARCELADO NO P02 " + clsMensagem3.msgParcelado.ToString());
						clsMensagem3.msgRespostaP02 = strString.Substring(89, 1);
						objFuncoes.MsgConsole("VALOR RESPOSTAP02 NO P02 " + clsMensagem3.msgRespostaP02.ToString());
						clsMensagem3.msgCheckSum = strString.Substring(strString.Length - 4, 3);
						objFuncoes.MsgConsole("VALOR CHECKSUM NO P02 " + clsMensagem3.msgCheckSum.ToString());
					}
					else if (Operators.CompareString(clsMensagem3.msgProtocolo, "P03", false) == 0)
					{
						clsMensagem3.msgTN = strString.Substring(5, 16);
						objFuncoes.MsgConsole("VALOR TN NO P03 " + clsMensagem3.msgTN.ToString());
						clsMensagem3.msgVersao = strString.Substring(21, 3);
						objFuncoes.MsgConsole("VALOR VERSAO NO P03 " + clsMensagem3.msgVersao.ToString());
						clsMensagem3.msgTelefone = strString.Substring(24, 10);
						objFuncoes.MsgConsole("VALOR TELEFONE NO P03 " + clsMensagem3.msgTelefone.ToString());
						clsMensagem3.msgCelular = strString.Substring(35, 10);
						objFuncoes.MsgConsole("VALOR CELULAR NO P03 " + clsMensagem3.msgCelular.ToString());
						clsMensagem3.msgDiversao = strString.Substring(46, 2);
						objFuncoes.MsgConsole("VALOR DIVERSAO NO P03 " + clsMensagem3.msgDiversao.ToString());
						clsMensagem3.msgPromoto = strString.Substring(48, 4);
						objFuncoes.MsgConsole("VALOR PROMOTOR NO P03 " + clsMensagem3.msgPromoto.ToString());
						clsMensagem3.msgEvento = strString.Substring(52, 6);
						objFuncoes.MsgConsole("VALOR EVENTO NO P03 " + clsMensagem3.msgEvento.ToString());
						clsMensagem3.msgLocal = strString.Substring(58, 6);
						objFuncoes.MsgConsole("VALOR LOCAL NO P03 " + clsMensagem3.msgLocal.ToString());
						clsMensagem3.msgTipoLocal = strString.Substring(64, 2);
						objFuncoes.MsgConsole("VALOR TIPO LOCAL NO P03 " + clsMensagem3.msgTipoLocal.ToString());
						clsMensagem3.msgDataEvento = strString.Substring(66, 4);
						objFuncoes.MsgConsole("VALOR DATA EVENTO " + clsMensagem3.msgDataEvento.ToString());
						clsMensagem3.msgHoraEvento = strString.Substring(70, 4);
						objFuncoes.MsgConsole("VALOR HORA EVENTO " + clsMensagem3.msgHoraEvento.ToString());
						clsMensagem3.msgQTD = strString.Substring(74, 2);
						objFuncoes.MsgConsole("VALOR QUANTIDADE INTEIRA NO P03 " + clsMensagem3.msgQTD.ToString());
						clsMensagem3.msgQTDMeia = strString.Substring(76, 2);
						objFuncoes.MsgConsole("VALOR QUANTIDADE MEIA NO P03 " + clsMensagem3.msgQTDMeia.ToString());
						clsMensagem3.msgQTDIntMeia = strString.Substring(78, 3);
						objFuncoes.MsgConsole("VALOR QUANTIDADE MEIA-INTEIRA NO P03 " + clsMensagem3.msgQTDIntMeia.ToString());
						int num = strString.IndexOf("*", 80);
						objFuncoes.MsgConsole("VALOR DE CART " + num);
						int length = num - 81;
						objFuncoes.MsgConsole("VALOR DE tamCart " + length);
						clsMensagem3.msgCartao = strString.Substring(81, length);
						objFuncoes.MsgConsole("VALOR DE CARTAO NO P03 " + clsMensagem3.msgCartao.ToString());
						clsMensagem3.msgVencimento = strString.Substring(num + 1, 4);
						objFuncoes.MsgConsole("VALOR VENCIMENTO NO P03 " + clsMensagem3.msgVencimento.ToString());
						int num3 = num + 5;
						objFuncoes.MsgConsole("VALOR Cod " + num3);
						int num2 = strString.IndexOf("*", num + 1);
						num2 -= num3;
						objFuncoes.MsgConsole("VALOR tamCod " + num2);
						clsMensagem3.msgCodigo = strString.Substring(num3, num2);
						objFuncoes.MsgConsole("VALOR CODIGO SEGURANCA NO P03 " + clsMensagem3.msgCodigo.ToString());
						num3 += num2;
						clsMensagem3.msgFormaPagamento = strString.Substring(num3 + 1, 2);
						objFuncoes.MsgConsole("VALOR FORMA PAGAMENTO NO P03 " + clsMensagem3.msgFormaPagamento.ToString());
						num3 += 2;
						objFuncoes.MsgConsole("VALOR Cod " + num3);
						clsMensagem3.msgParecela = strString.Substring(num3 + 1, 2);
						objFuncoes.MsgConsole("VALOR PARCELAS NO P03 " + clsMensagem3.msgParecela.ToString());
						num3 += 3;
						objFuncoes.MsgConsole("VALOR Cod " + num3);
						clsMensagem3.msgRespostaP03 = strString.Substring(num3 + 1, 1);
						objFuncoes.MsgConsole("VALOR RESPOSTA DO P03 " + clsMensagem3.msgRespostaP03.ToString());
						clsMensagem3.msgCheckSum = strString.Substring(strString.Length - 4, 3);
						objFuncoes.MsgConsole("VALOR CHECKSUM NO P03 " + clsMensagem3.msgCheckSum.ToString());
					}
				}
				clsMensagem3 = null;
				return clsMensagem2;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Console.WriteLine("ERRO AO RECUPERAR MENSAGEM ");
				clsMensagem2.strProtocolo = "ERRO";
				ProjectData.ClearProjectError();
				return clsMensagem2;
			}
		}
	}

	public object GeraMensagemP01()
	{
		string text = null;
		string text2 = null;
		try
		{
			text += "P01";
			text += msgTN;
			text += "150";
			text += msgTelefone;
			text += "*";
			objFuncoes.MsgConsole("VALOR DO TELEFONE " + msgTelefone);
			text += msgCelular;
			text += "*";
			objFuncoes.MsgConsole("VALOR DO CELULAR " + msgCelular);
			text2 = objFuncoes.Calcular_Check_Sum(text);
			text += "                                                                                                                                               ";
			text += text2;
			text += "#";
			text = "$" + text;
			objFuncoes.MsgConsole("VALOR DO strRetorno GeraMensagemP01 " + text);
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.Write(ex2.ToString());
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object GeraMensagemP02()
	{
		string text = null;
		string text2 = null;
		try
		{
			text += "P02";
			text += msgTN;
			text += "150";
			text += msgTelefone;
			text += "*";
			objFuncoes.MsgConsole("VALOR DO TELEFONE " + msgTelefone);
			text += msgCelular;
			text += "*";
			text += msgDiversao;
			text += msgEvento;
			text += msgLocal;
			text += msgTipoLocal;
			text += msgQTD;
			text += msgQTDMeia;
			text += msgQTDIntMeia;
			text += msgPedido;
			text += msgVagas;
			text2 = objFuncoes.Calcular_Check_Sum(text);
			text += "                                                                                                                               ";
			text += text2;
			text += "#";
			return "$" + text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.Write(ex2.ToString());
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object GeraMensagemP03()
	{
		string text = null;
		string text2 = null;
		try
		{
			text += "P03";
			string text3 = text;
			clsFuncoes obj = objFuncoes;
			string strTN = msgTN;
			string text4 = obj.GeraTN(ref strTN);
			msgTN = strTN;
			text = text3 + text4;
			text += "150";
			text += msgTelefone;
			text += "*";
			objFuncoes.MsgConsole("VALOR DO TELEFONE " + msgTelefone);
			text += msgCelular;
			text += "*";
			text += msgDiversao;
			text += msgPromoto;
			text += msgEvento;
			text += msgLocal;
			text += msgTipoLocal;
			text += msgDataEvento;
			text += msgHoraEvento;
			text += msgQTD;
			text += msgQTDMeia;
			text += msgQTDIntMeia;
			msgCartao += "*";
			objFuncoes.MsgConsole("VALOR DO CARTAO " + msgCartao);
			text += msgCartao;
			objFuncoes.MsgConsole("VALOR DO VENCIMENTO " + msgVencimento);
			text += msgVencimento;
			msgCodigo += "*";
			objFuncoes.MsgConsole("VALOR DO CODIGO SEGURANCA " + msgCodigo);
			text += msgCodigo;
			text += msgFormaPagamento;
			text += msgParecela;
			text2 = objFuncoes.Calcular_Check_Sum(text);
			text += "                                                                                  ";
			text += text2;
			text += "#";
			text = "$" + text;
			objFuncoes.MsgConsole("VALOR P03 " + text.ToString());
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.Write(ex2.ToString());
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object GeraErro()
	{
		string text = null;
		try
		{
			return text + "-1";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.Write(ex2.ToString());
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}

using System;
using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Npgsql;

namespace IngressoVip;

public class clsCinema
{
	private clsConexao objConn;

	private NpgsqlConnection CnnRomoto;

	private clsMensagem msg;

	private clsFuncoes objFuncoes;

	public clsCinema()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		objConn = new clsConexao();
		CnnRomoto = new NpgsqlConnection(objConn.connRemoto());
		msg = new clsMensagem();
		objFuncoes = new clsFuncoes();
	}

	public DataSet PegaFilmes(ref string strCodRede)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select distinct filme from filmes where idrede= " + strCodRede;
			objFuncoes.MsgConsole("Valor do sql execultado em PegaFilmes " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "filmes");
			CnnRomoto.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			CnnRomoto.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public DataSet PegaRedes(ref string strCodArea)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select distinct idrede,nome from redecinema where codarea= " + strCodArea;
			objFuncoes.MsgConsole("Valor do sql execultado em PegaFilmes " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "redecinema");
			CnnRomoto.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			CnnRomoto.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public DataSet PegaShopping(ref string strCodFilme, ref string strCodRede, ref string strCodArea)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select distinct filmes.idshopping from filmes,shopping where idrede= " + strCodRede + " and filme= " + strCodFilme + " and shopping.idshopping=filmes.idshopping and shopping.codarea= " + strCodArea;
			objFuncoes.MsgConsole("Valor do sql execultado em PegaShopping " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "filmes");
			CnnRomoto.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			CnnRomoto.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public DataSet PegaDataFilme(ref string strCodFilme, ref string strCodRede, ref string strCodLocal)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select distinct datasfilme.iddata ,datasfilme.data from filmes,datasfilme where filmes.idshopping=" + strCodLocal + " and filmes.idrede=" + strCodRede + " and filmes.filme=" + strCodFilme;
			objFuncoes.MsgConsole("Valor do sql execultado em PegaDatas " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "datasfilme");
			CnnRomoto.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			CnnRomoto.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public DataSet PegaHoraFilme(ref string strCodFilme, ref string strCodRede, ref string strCodLocal, ref string strCodData)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select distinct filme.idfilme,horasfilme.hora from datahorafilme,horasfilme,filmes,datasfilme,filme where filmes.filme=" + strCodFilme + "  and filme.idfilme=filmes.filme and filmes.idrede= " + strCodRede + " and filmes.idshopping= " + strCodLocal + " and filmes.iddata=datahorafilme.iddata and datahorafilme.iddata= " + strCodData + " and horasfilme.idhora=datahorafilme.idhora";
			objFuncoes.MsgConsole("Valor do sql execultado em PegaDatas " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "filmes");
			CnnRomoto.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			CnnRomoto.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public DataSet PegaCodFilme(ref string strCodFilme, ref string strCodRede, ref string strCodLocal, ref string strCodData)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select distinct filme.idfilme,datasfilme.data from datahorafilme,horasfilme,filmes,datasfilme,filme where filmes.filme=" + strCodFilme + " and filme.idfilme=filmes.filme and filmes.idrede=" + strCodRede + " and filmes.idshopping=" + strCodLocal + " and filmes.iddata=" + strCodData + " and datahorafilme.iddata=filmes.iddata and datasfilme.iddata=datahorafilme.iddata";
			objFuncoes.MsgConsole("Valor do sql execultado em PegaDatas " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "filmes");
			CnnRomoto.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			CnnRomoto.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}

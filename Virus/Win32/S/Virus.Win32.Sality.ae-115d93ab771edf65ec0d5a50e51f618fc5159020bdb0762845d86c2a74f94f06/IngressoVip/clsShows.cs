using System;
using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Npgsql;

namespace IngressoVip;

public class clsShows
{
	private clsConexao objConn;

	private NpgsqlConnection CnnRomoto;

	private clsMensagem msg;

	private clsFuncoes objFuncoes;

	public clsShows()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		objConn = new clsConexao();
		CnnRomoto = new NpgsqlConnection(objConn.connRemoto());
		msg = new clsMensagem();
		objFuncoes = new clsFuncoes();
	}

	public DataSet PegaShows(ref string strCodArtista, ref string strLugar)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select * from buscar_shows(" + strCodArtista + "," + strLugar + ") as (idshow integer, idartista integer, data date, taxaservico integer, idlugar integer, lugar character(20))";
			objFuncoes.MsgConsole("Valor do sql execultado em PegaShows " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "shows");
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

	public DataSet PegaShowCod(ref string strCodShow)
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
			string text = "SELECT * FROM shows WHERE idshow = " + strCodShow;
			objFuncoes.MsgConsole("Valor do sql execultado em PegaCodShow " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "shows");
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

	public DataSet PegaArtistas(ref string strCodArea)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select * from buscar_artistas(" + strCodArea + ") as (idartista integer)";
			objFuncoes.MsgConsole("Valor do sql execultado em PegaShow: " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "shows");
			CnnRomoto.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			objFuncoes.MsgConsole("Erro na conexao em PegaShow: " + ex2.ToString());
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			CnnRomoto.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public DataSet PegaAcento(ref string strEvento)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "select * from buscar_acentoshow(" + strEvento + ")as (idacento integer, nome character(25))";
			objFuncoes.MsgConsole(text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "lugares");
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

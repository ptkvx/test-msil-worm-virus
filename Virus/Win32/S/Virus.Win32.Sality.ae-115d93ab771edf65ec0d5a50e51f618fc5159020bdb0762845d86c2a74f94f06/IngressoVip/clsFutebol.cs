using System;
using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Npgsql;

namespace IngressoVip;

public class clsFutebol
{
	private clsConexao objConn;

	private NpgsqlConnection CnnRomoto;

	private clsMensagem msg;

	private clsFuncoes objFuncoes;

	public clsFutebol()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		objConn = new clsConexao();
		CnnRomoto = new NpgsqlConnection(objConn.connRemoto());
		msg = new clsMensagem();
		objFuncoes = new clsFuncoes();
	}

	public DataSet PegaJogos(ref string strCodTime)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			DateTime today = DateTime.Today;
			string text = Strings.Format((object)today, "yyyy-MM-dd");
			string text2 = "SELECT * FROM jogos WHERE idtimes = " + strCodTime + " AND data > '" + text + "' ORDER by data";
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text2, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "jogos");
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

	public DataSet PegaJogoCod(ref string strCodJogo)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnRomoto.get_State() == ConnectionState.Closed)
			{
				objFuncoes.MsgConsole("Abrindo conexão com banco remoto...");
				CnnRomoto.Open();
				objFuncoes.MsgConsole("Conexão aberta...");
			}
			string text = "SELECT * FROM jogos WHERE idjogo = " + strCodJogo;
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "jogos");
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

	public DataSet PegaLocais(ref string strEvento)
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
			string text = "select * from buscar_lugares(" + strEvento + ") as (idlugar integer)";
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

	public DataSet PegaTimes(ref string strCodArea)
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
			string text = "select * from buscar_time(" + strCodArea + ")as (idtimes integer)";
			objFuncoes.MsgConsole("Valor do sql execultado em PegaTimes: " + text);
			NpgsqlDataAdapter val = new NpgsqlDataAdapter(text, CnnRomoto);
			((DbDataAdapter)(object)val).Fill(dataSet, "times");
			CnnRomoto.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			objFuncoes.MsgConsole("Erro na conexao em PegaTimes " + ex2.ToString());
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			CnnRomoto.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}

using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IngressoVip;

public class clsConexao
{
	private clsFuncoes objFuncoes;

	public clsConexao()
	{
		objFuncoes = new clsFuncoes();
	}

	public string connLocal()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		try
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXml("conexao.xml");
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			text = $"Server={RuntimeHelpers.GetObjectValue(dataRow[0])}; Database={RuntimeHelpers.GetObjectValue(dataRow[1])}; Uid={RuntimeHelpers.GetObjectValue(dataRow[2])}; Pwd={RuntimeHelpers.GetObjectValue(dataRow[3])}; Connect Timeout=30;";
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			string result = text;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string connRemoto()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		try
		{
			text = $"Server=187.54.196.79; Port=64399; Database=ingressodesenv; Uid=ingressouser; Pwd=ingressouser;";
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			objFuncoes.MsgConsole("Erro na conexao na funcao connRemoto " + ex2.ToString());
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			objFuncoes.MsgConsole("Valor de strString em connRemoto " + text);
			string result = text;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}

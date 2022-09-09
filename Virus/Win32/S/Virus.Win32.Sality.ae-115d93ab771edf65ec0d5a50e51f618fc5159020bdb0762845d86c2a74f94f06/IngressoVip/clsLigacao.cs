using System;
using System.Data;
using System.Data.Common;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace IngressoVip;

public class clsLigacao
{
	private clsConexao objConn;

	private MySqlConnection CnnLocal;

	private clsMensagem msg;

	private clsFuncoes objFuncoes;

	public clsLigacao()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		objConn = new clsConexao();
		CnnLocal = new MySqlConnection(objConn.connLocal());
		msg = new clsMensagem();
		objFuncoes = new clsFuncoes();
	}

	public void GravaLog(ref string msgTN, ref string msgTel, ref string msgCel, ref string codMenu, ref string codJogo, ref int intEtapa)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		DataSet dataSet = new DataSet();
		try
		{
			object msgTN2 = msgTN;
			DataSet dataSet2 = CarregaLog(ref msgTN2);
			msgTN = Conversions.ToString(msgTN2);
			dataSet = dataSet2;
			if (CnnLocal.get_State() == ConnectionState.Closed)
			{
				CnnLocal.Open();
			}
			if (intEtapa == 1)
			{
				if (dataSet.Tables[0].Rows.Count > 0)
				{
					string text = "UPDATE cad_ligacao SET str_tel = '" + msgTel + "',str_cel = '" + msgCel + "',int_cod_menu = " + codMenu + " ,int_cod_jogo = " + codJogo + "' WHERE str_tn = '" + dataSet.Tables[0].Rows[0]["str_tn"].ToString() + "'";
					MySqlCommand val = new MySqlCommand(text, CnnLocal);
					val.ExecuteNonQuery();
					CnnLocal.Close();
				}
				else
				{
					string text2 = "INSERT INTO cad_ligacao (dt_datahora, str_tn, str_tel, str_cel) VALUES (now(), '" + msgTN + "','" + msgTel + "','" + msgCel + "')";
					MySqlCommand val2 = new MySqlCommand(text2, CnnLocal);
					val2.ExecuteNonQuery();
					CnnLocal.Close();
				}
			}
			else if (intEtapa == 2)
			{
				if (dataSet.Tables[0].Rows.Count > 0)
				{
					string text3 = "UPDATE cad_ligacao SET str_tel = '" + msgTel + "',str_cel = '" + msgCel + "',int_cod_menu = " + codMenu + " ,int_cod_jogo = " + codJogo + "' WHERE str_tn = '" + dataSet.Tables[0].Rows[0]["str_tn"].ToString() + "'";
					MySqlCommand val3 = new MySqlCommand(text3, CnnLocal);
					val3.ExecuteNonQuery();
					CnnLocal.Close();
				}
				else
				{
					string text4 = "INSERT INTO cad_ligacao (dt_datahora, str_tn, str_tel, str_cel) VALUES (now(), '" + msgTN + "','" + msgTel + "','" + msgCel + "')";
					MySqlCommand val4 = new MySqlCommand(text4, CnnLocal);
					val4.ExecuteNonQuery();
					CnnLocal.Close();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			objFuncoes.MsgConsole(ex2.ToString());
			CnnLocal.Close();
			ProjectData.ClearProjectError();
		}
		dataSet.Dispose();
	}

	private DataSet CarregaLog(ref object msgTN)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		DataSet dataSet = new DataSet();
		try
		{
			if (CnnLocal.get_State() == ConnectionState.Closed)
			{
				CnnLocal.Open();
			}
			string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM cad_ligacao WHERE str_tn = '", msgTN), (object)"'"));
			MySqlCommand val = new MySqlCommand(text, CnnLocal);
			MySqlDataAdapter val2 = new MySqlDataAdapter(val);
			((DbDataAdapter)(object)val2).Fill(dataSet, "cad_ligacao");
			CnnLocal.Close();
			return dataSet;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			objFuncoes.MsgConsole(ex2.ToString());
			CnnLocal.Close();
			DataSet result = dataSet;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}

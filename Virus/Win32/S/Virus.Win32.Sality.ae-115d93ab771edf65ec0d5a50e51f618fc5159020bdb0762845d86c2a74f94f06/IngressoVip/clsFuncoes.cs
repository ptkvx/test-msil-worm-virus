using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IngressoVip;

public class clsFuncoes
{
	[DebuggerNonUserCode]
	public clsFuncoes()
	{
	}

	public string GeraTN(ref string strTN)
	{
		try
		{
			if (Operators.CompareString(strTN, "0000000000000000", false) == 0)
			{
				return DateTime.Now.ToString("yyyyMMddHHssffff");
			}
			return strTN;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine(ex2.ToString());
			string result = "0000000000000000";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public int ValidaTelefone(ref string strTelefone)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			switch (strTelefone.Substring(0, 3))
			{
			default:
				return 0;
			case "629":
			case "628":
			case "627":
				return 1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			int result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public int RemoveZeros(ref string valor, int qtd)
	{
		clsFuncoes clsFuncoes2 = new clsFuncoes();
		clsFuncoes2.MsgConsole("VALOR DE valor em REMOVEZEROS " + valor);
		int length = checked(valor.Length - qtd);
		string text = valor.Substring(0, length);
		clsFuncoes2.MsgConsole("VALOR DE strNum em REMOVEZEROS " + text);
		int num = Conversions.ToInteger(text);
		clsFuncoes2.MsgConsole("VALOR DE valorConv em REMOVEZEROS " + Conversions.ToString(num));
		return num;
	}

	public string ZerosEsquerda(int @int, int qtd)
	{
		string text = Conversions.ToString(@int);
		for (int i = 0; i <= qtd; i = checked(i + 1))
		{
			if (text.Length < qtd)
			{
				text = text.Insert(0, "0");
			}
		}
		return text;
	}

	public string Calcular_Check_Sum(string texto)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		clsFuncoes clsFuncoes2 = new clsFuncoes();
		clsFuncoes2.MsgConsole("VALOR DO PAYLOAD " + texto.ToString());
		checked
		{
			try
			{
				short num2 = (short)(texto.Length - 1);
				for (short num3 = 0; num3 <= num2; num3 = (short)unchecked(num3 + 1))
				{
					num += Strings.Asc(texto.Substring(num3, 1));
					if (num > 256)
					{
						num -= 256;
					}
				}
				num = 256 - num;
				string text = Strings.StrDup(3 - num.ToString().Length, "0") + num;
				clsFuncoes2.MsgConsole("VALOR DO CALCULO DO CHECKSUM " + text.ToString());
				return text;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			return "";
		}
	}

	public void MsgConsole(string texto)
	{
		Console.WriteLine("[" + DateTime.Now.ToString() + "] " + texto);
	}

	public string NumeroToExtenso(string strValor)
	{
		checked
		{
			string text = strValor.Substring(0, strValor.Length - 2) + "," + strValor.Substring(strValor.Length - 2);
			try
			{
				decimal num = new decimal(Conversions.ToDouble(text));
				if (decimal.Compare(num, 0m) == 0)
				{
					return "Zero Reais";
				}
				int num2 = Convert.ToInt32(decimal.Round(decimal.Multiply(decimal.Subtract(num, Conversion.Int(num)), new decimal(100L)), MidpointRounding.ToEven));
				num = Conversion.Int(num);
				if (num2 > 0)
				{
					if (decimal.Compare(num, 1m) == 0)
					{
						return "Um Real e " + getDecimal((byte)num2) + " centavos";
					}
					if (decimal.Compare(num, 0m) == 0)
					{
						return getDecimal((byte)num2) + " centavos";
					}
					return getInteger(num) + " Reais e " + getDecimal((byte)num2) + " centavos";
				}
				if (decimal.Compare(num, 1m) == 0)
				{
					return "Um Real";
				}
				return getInteger(num) + "Reais";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public string getDecimal(byte number)
	{
		try
		{
			byte b = number;
			if (b == 0)
			{
				return "";
			}
			if ((uint)b >= 1u && (uint)b <= 19u)
			{
				string[] array = new string[19]
				{
					"Um", "Dois", "Tres", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez",
					"Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove"
				};
				checked
				{
					return array[unchecked((int)number) - 1] + " ";
				}
			}
			if ((uint)b >= 20u && (uint)b <= 99u)
			{
				string[] array2 = new string[8] { "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta ", "Setenta", "Oitenta", "Noventa" };
				checked
				{
					if (unchecked((int)number % 10) == 0)
					{
						return array2[unchecked((int)number / 10) - 2] + " ";
					}
					return array2[unchecked((int)number / 10) - 2] + " e " + getDecimal((byte)unchecked((int)number % 10)) + " ";
				}
			}
			return "";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string getInteger(decimal number)
	{
		try
		{
			number = Conversion.Int(number);
			decimal d = number;
			if (decimal.Compare(d, 0m) < 0)
			{
				return "-" + getInteger(decimal.Negate(number));
			}
			if (decimal.Compare(d, 0m) == 0)
			{
				return "";
			}
			if (decimal.Compare(d, 1m) >= 0 && decimal.Compare(d, new decimal(19L)) <= 0)
			{
				string[] array = new string[19]
				{
					"Um", "Dois", "Tres", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez",
					"Onze", "Doze", "Treze", "Quatorze", "Quinze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove"
				};
				return array[Convert.ToInt32(decimal.Subtract(number, 1m))] + " ";
			}
			checked
			{
				if (decimal.Compare(d, new decimal(20L)) >= 0 && decimal.Compare(d, new decimal(99L)) <= 0)
				{
					string[] array2 = new string[8] { "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };
					if (decimal.Compare(decimal.Remainder(number, new decimal(10L)), 0m) == 0)
					{
						return array2[(int)(unchecked(Convert.ToInt64(number) / 10L) - 2L)] + " ";
					}
					return array2[(int)(unchecked(Convert.ToInt64(number) / 10L) - 2L)] + " e " + getInteger(decimal.Remainder(number, new decimal(10L)));
				}
				if (decimal.Compare(d, new decimal(100L)) == 0)
				{
					return "Cem ";
				}
				if (decimal.Compare(d, new decimal(101L)) >= 0 && decimal.Compare(d, new decimal(999L)) <= 0)
				{
					string[] array3 = new string[9] { "Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos", "Novecentos" };
					if (decimal.Compare(decimal.Remainder(number, new decimal(100L)), 0m) == 0)
					{
						return array3[(int)(unchecked(Convert.ToInt64(number) / 100L) - 1L)] + " ";
					}
					return array3[(int)(unchecked(Convert.ToInt64(number) / 100L) - 1L)] + " e " + getInteger(decimal.Remainder(number, new decimal(100L)));
				}
				if (decimal.Compare(d, new decimal(1000L)) >= 0 && decimal.Compare(d, new decimal(1999L)) <= 0)
				{
					decimal d2 = decimal.Remainder(number, new decimal(1000L));
					if (decimal.Compare(d2, 0m) == 0)
					{
						return "Mil ";
					}
					if (decimal.Compare(d2, new decimal(100L)) <= 0)
					{
						return "Mil e " + getInteger(decimal.Remainder(number, new decimal(1000L)));
					}
					return "Mil e " + getInteger(decimal.Remainder(number, new decimal(1000L)));
				}
			}
			if (decimal.Compare(d, new decimal(2000L)) >= 0 && decimal.Compare(d, new decimal(999999L)) <= 0)
			{
				decimal d3 = decimal.Remainder(number, new decimal(1000L));
				if (decimal.Compare(d3, 0m) == 0)
				{
					return getInteger(new decimal(Convert.ToInt64(number) / 1000L)) + "Mil ";
				}
				if (decimal.Compare(d3, new decimal(100L)) <= 0)
				{
					return getInteger(new decimal(Convert.ToInt64(number) / 1000L)) + "Mil e " + getInteger(decimal.Remainder(number, new decimal(1000L)));
				}
				return getInteger(new decimal(Convert.ToInt64(number) / 1000L)) + "Mil e " + getInteger(decimal.Remainder(number, new decimal(1000L)));
			}
			if (decimal.Compare(d, new decimal(1000000L)) >= 0 && decimal.Compare(d, new decimal(1999999L)) <= 0)
			{
				decimal d4 = decimal.Remainder(number, new decimal(1000000L));
				if (decimal.Compare(d4, 0m) == 0)
				{
					return "Um Milhão ";
				}
				if (decimal.Compare(d4, new decimal(100L)) <= 0)
				{
					return getInteger(new decimal(Convert.ToInt64(number) / 1000000L)) + "Milhão e " + getInteger(decimal.Remainder(number, new decimal(1000000L)));
				}
				return getInteger(new decimal(Convert.ToInt64(number) / 1000000L)) + "Milhão e " + getInteger(decimal.Remainder(number, new decimal(1000000L)));
			}
			if (decimal.Compare(d, new decimal(2000000L)) >= 0 && decimal.Compare(d, new decimal(999999999L)) <= 0)
			{
				decimal d5 = decimal.Remainder(number, new decimal(1000000L));
				if (decimal.Compare(d5, 0m) == 0)
				{
					return getInteger(new decimal(Convert.ToInt64(number) / 1000000L)) + "Milhões ";
				}
				if (decimal.Compare(d5, new decimal(100L)) <= 0)
				{
					return getInteger(new decimal(Convert.ToInt64(number) / 1000000L)) + "Milhões e " + getInteger(decimal.Remainder(number, new decimal(1000000L)));
				}
				return getInteger(new decimal(Convert.ToInt64(number) / 1000000L)) + "Milhões e " + getInteger(decimal.Remainder(number, new decimal(1000000L)));
			}
			if (decimal.Compare(d, new decimal(1000000000L)) >= 0 && decimal.Compare(d, new decimal(1999999999L)) <= 0)
			{
				decimal d6 = decimal.Remainder(number, new decimal(1000000000L));
				if (decimal.Compare(d6, 0m) == 0)
				{
					return "Um Bilhão ";
				}
				if (decimal.Compare(d6, new decimal(100L)) <= 0)
				{
					return getInteger(new decimal(Convert.ToInt64(number) / 1000000000L)) + "Bilhão e " + getInteger(decimal.Remainder(number, new decimal(1000000000L)));
				}
				return getInteger(new decimal(Convert.ToInt64(number) / 1000000000L)) + "Bilhão e " + getInteger(decimal.Remainder(number, new decimal(1000000000L)));
			}
			decimal d7 = decimal.Remainder(number, new decimal(1000000000L));
			if (decimal.Compare(d7, 0m) == 0)
			{
				return getInteger(new decimal(Convert.ToInt64(number) / 1000000000L)) + "Bilhões ";
			}
			if (decimal.Compare(d7, new decimal(100L)) <= 0)
			{
				return getInteger(new decimal(Convert.ToInt64(number) / 1000000000L)) + "Bilhões e " + getInteger(decimal.Remainder(number, new decimal(1000000000L)));
			}
			return getInteger(new decimal(Convert.ToInt64(number) / 1000000000L)) + "Bilhões e " + getInteger(decimal.Remainder(number, new decimal(1000000000L)));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public int ContaPalavras(ref string strFrase)
	{
		try
		{
			string text = strFrase;
			while (text.IndexOf(Strings.Space(2)) >= 0)
			{
				text = text.Replace(Strings.Space(2), Strings.Space(1));
			}
			return Strings.Split(text, Strings.Space(1), -1, (CompareMethod)0).Length;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}

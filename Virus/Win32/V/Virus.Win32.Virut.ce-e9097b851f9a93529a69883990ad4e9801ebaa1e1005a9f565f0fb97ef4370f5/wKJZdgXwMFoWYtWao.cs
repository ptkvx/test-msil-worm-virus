using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class wKJZdgXwMFoWYtWao
{
	private string hWqhYlveeSEfCOcKb;

	public string bafQJQuVHXadVtXCl
	{
		get
		{
			return hWqhYlveeSEfCOcKb;
		}
		set
		{
			hWqhYlveeSEfCOcKb = value;
		}
	}

	public wKJZdgXwMFoWYtWao(string bafQJQuVHXadVtXCl)
	{
		hWqhYlveeSEfCOcKb = "";
		this.bafQJQuVHXadVtXCl = bafQJQuVHXadVtXCl;
	}

	public wKJZdgXwMFoWYtWao()
	{
		hWqhYlveeSEfCOcKb = "";
		bafQJQuVHXadVtXCl = "";
	}

	public string WcYkBQXZiGBegNTmu(string GPZUxNfzTNDirrqvg)
	{
		return Encoding.Default.GetString(WcYkBQXZiGBegNTmu(Encoding.Default.GetBytes(GPZUxNfzTNDirrqvg)));
	}

	public byte[] WcYkBQXZiGBegNTmu(byte[] GPZUxNfzTNDirrqvg)
	{
		GPZUxNfzTNDirrqvg = HljRGaQHVfOOBCclx(GPZUxNfzTNDirrqvg, Encoding.Default.GetBytes(bafQJQuVHXadVtXCl));
		byte[] array = new byte[GPZUxNfzTNDirrqvg.Length - Convert.ToInt32(Conversions.ToString(10), 2) + 1];
		object obj = default(object);
		object obj2 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj, (object)(GPZUxNfzTNDirrqvg.Length - Convert.ToInt32(Conversions.ToString(1), 2)), (object)Convert.ToInt32(Conversions.ToString(1), 2), (object)(-Convert.ToInt32(Conversions.ToString(1), 2)), ref obj2, ref obj))
		{
			do
			{
				array[Conversions.ToInteger(Operators.SubtractObject(obj, (object)Convert.ToInt32(Conversions.ToString(1), 2)))] = jPLLKOzGOeFEUKNFd(GPZUxNfzTNDirrqvg[Conversions.ToInteger(obj)], (short)(-GPZUxNfzTNDirrqvg[Conversions.ToInteger(Operators.SubtractObject(obj, (object)Convert.ToInt32(Conversions.ToString(1), 2)))]));
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
		return array;
	}

	private byte jPLLKOzGOeFEUKNFd(byte oCMhuiUvSRsardhIi, short tnGDZuUMITkzVISpk)
	{
		while (tnGDZuUMITkzVISpk < Convert.ToInt32(Conversions.ToString(0), 2))
		{
			tnGDZuUMITkzVISpk = (short)(tnGDZuUMITkzVISpk + Convert.ToInt32(Conversions.ToString(100000000), 2));
		}
		return Convert.ToByte((short)(oCMhuiUvSRsardhIi + tnGDZuUMITkzVISpk) % Convert.ToInt32(Conversions.ToString(100000000), 2));
	}

	private byte[] HljRGaQHVfOOBCclx(byte[] oCMhuiUvSRsardhIi, byte[] ZgLYXnqtlKZSCkmHj)
	{
		object obj = default(object);
		object obj2 = default(object);
		if (ZgLYXnqtlKZSCkmHj.Length != 0 && ForLoopControl.ForLoopInitObj(obj, (object)Convert.ToInt32(Conversions.ToString(0), 2), (object)(oCMhuiUvSRsardhIi.Length - Convert.ToInt32(Conversions.ToString(1), 2)), (object)1, ref obj2, ref obj))
		{
			do
			{
				oCMhuiUvSRsardhIi[Conversions.ToInteger(obj)] = (byte)(oCMhuiUvSRsardhIi[Conversions.ToInteger(obj)] ^ jPLLKOzGOeFEUKNFd(ZgLYXnqtlKZSCkmHj[Conversions.ToInteger(Operators.ModObject(obj, (object)ZgLYXnqtlKZSCkmHj.Length))], ZgLYXnqtlKZSCkmHj[(int)ZgLYXnqtlKZSCkmHj[Conversions.ToInteger(Operators.ModObject(obj, (object)ZgLYXnqtlKZSCkmHj.Length))] % ZgLYXnqtlKZSCkmHj.Length]) ^ ZgLYXnqtlKZSCkmHj[Conversions.ToInteger(Operators.ModObject(Operators.ModObject(Operators.AddObject(obj, Operators.ModObject(obj, (object)Convert.ToInt32(Conversions.ToString(111), 2))), (object)ZgLYXnqtlKZSCkmHj.Length), (object)ZgLYXnqtlKZSCkmHj.Length))]);
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
		return oCMhuiUvSRsardhIi;
	}

	public string HljRGaQHVfOOBCclx(string NRrfcWolJeDJFRUiE, string ZgLYXnqtlKZSCkmHj)
	{
		return Encoding.Default.GetString(HljRGaQHVfOOBCclx(Encoding.Default.GetBytes(NRrfcWolJeDJFRUiE), Encoding.Default.GetBytes(ZgLYXnqtlKZSCkmHj)));
	}
}

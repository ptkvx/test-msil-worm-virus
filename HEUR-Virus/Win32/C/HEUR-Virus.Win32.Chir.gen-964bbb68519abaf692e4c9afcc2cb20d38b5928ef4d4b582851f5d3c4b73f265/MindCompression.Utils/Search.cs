using System.Collections;
using System.Windows.Forms;
using MindCompression.DataObjects;

namespace MindCompression.Utils;

public class Search
{
	public static ArrayList SearchItem(string searchString)
	{
		return SearchItem(searchString, new SearchOptions());
	}

	public static ArrayList SearchItem(string searchString, SearchOptions options)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		if (!options.CaseSensitive)
		{
			searchString = searchString.ToUpper();
		}
		foreach (object type2 in GetTypeList(options.SearchIn))
		{
			FmObjectType type = (FmObjectType)type2;
			foreach (FmObject item in FmObjectLists.Instance.GetList(type))
			{
				string text = item.ToString();
				if (!options.CaseSensitive)
				{
					text = text.ToUpper();
				}
				if (options.IgnoreAccents)
				{
					text = ChangeAccentedLetters(text);
				}
				if (text.IndexOf(searchString) >= 0)
				{
					arrayList.Add(item);
					if (arrayList.Count > 1000)
					{
						MessageBox.Show("More than 1000 items found, please refine your search");
						break;
					}
				}
			}
			if (arrayList.Count > 1000)
			{
				return arrayList;
			}
		}
		return arrayList;
	}

	private static ArrayList GetTypeList(FmObjectType type)
	{
		ArrayList arrayList = new ArrayList();
		for (int num = 1; num < 4351; num *= 2)
		{
			if (((uint)type & (uint)num) == (uint)num)
			{
				arrayList.Add((FmObjectType)num);
			}
		}
		return arrayList;
	}

	private static string ChangeAccentedLetters(string str)
	{
		str = str.Replace("â", "a");
		str = str.Replace("ä", "a");
		str = str.Replace("à", "a");
		str = str.Replace("å", "a");
		str = str.Replace("ã", "a");
		str = str.Replace("á", "a");
		str = str.Replace("æ", "a");
		str = str.Replace("Ä", "A");
		str = str.Replace("Á", "A");
		str = str.Replace("Å", "A");
		str = str.Replace("À", "A");
		str = str.Replace("Ã", "A");
		str = str.Replace("Â", "A");
		str = str.Replace("Æ", "A");
		str = str.Replace("é", "e");
		str = str.Replace("ê", "e");
		str = str.Replace("ë", "e");
		str = str.Replace("è", "e");
		str = str.Replace("É", "E");
		str = str.Replace("Ë", "E");
		str = str.Replace("È", "E");
		str = str.Replace("Ê", "E");
		str = str.Replace("ï", "i");
		str = str.Replace("î", "i");
		str = str.Replace("ì", "i");
		str = str.Replace("í", "i");
		str = str.Replace("Ï", "I");
		str = str.Replace("Î", "I");
		str = str.Replace("Ì", "I");
		str = str.Replace("Í", "I");
		str = str.Replace("ü", "u");
		str = str.Replace("û", "u");
		str = str.Replace("ù", "u");
		str = str.Replace("ú", "u");
		str = str.Replace("Ü", "U");
		str = str.Replace("Ú", "U");
		str = str.Replace("Û", "U");
		str = str.Replace("Ù", "U");
		str = str.Replace("ô", "o");
		str = str.Replace("ö", "o");
		str = str.Replace("ò", "o");
		str = str.Replace("ó", "o");
		str = str.Replace("õ", "o");
		str = str.Replace("ø", "o");
		str = str.Replace("Ö", "O");
		str = str.Replace("Ó", "O");
		str = str.Replace("Ô", "O");
		str = str.Replace("Ò", "O");
		str = str.Replace("Õ", "O");
		str = str.Replace("Ø", "O");
		str = str.Replace("¢", "c");
		str = str.Replace("ç", "c");
		str = str.Replace("ÿ", "y");
		str = str.Replace("ý", "y");
		str = str.Replace("Ý", "Y");
		str = str.Replace("ñ", "n");
		str = str.Replace("Ñ", "N");
		return str;
	}
}

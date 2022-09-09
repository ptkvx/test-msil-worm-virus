using System.Collections;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace HTTPAgent;

public class DataExtractor
{
	private DataExtractor()
	{
	}

	public static string[] ExtractDataArray(string input, string pattern, string replacement, RegexOptions options)
	{
		ArrayList arrayList = new ArrayList();
		MatchCollection matchCollection = Regex.Matches(input, pattern, options);
		foreach (Match item in matchCollection)
		{
			if (replacement == string.Empty)
			{
				arrayList.Add(item.Value);
			}
			else
			{
				arrayList.Add(item.Result(replacement));
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	public static string[] ExtractDataArray(string input, string pattern, string replacement)
	{
		return ExtractDataArray(input, pattern, replacement, RegexOptions.None);
	}

	public static NameValueCollection ExtractHiddenFields(string input, int x)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		MatchCollection matchCollection = Regex.Matches(input, "<form.+?</form>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
		if (matchCollection.Count > 0)
		{
			int num = x;
			if (num < 0)
			{
				num = 0;
			}
			if (num > matchCollection.Count - 1)
			{
				num = matchCollection.Count - 1;
			}
			string value = matchCollection[num].Value;
			MatchCollection matchCollection2 = Regex.Matches(value, "<input([^>]+?type=\"hidden\"[^>]+?)/?>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
			Regex regex = new Regex("(\\S+?)=\"(.*?)\"", RegexOptions.Compiled | RegexOptions.Singleline);
			{
				foreach (Match item in matchCollection2)
				{
					MatchCollection matchCollection3 = regex.Matches(item.Groups[1].Value);
					string name = "";
					string value2 = "";
					foreach (Match item2 in matchCollection3)
					{
						if (item2.Groups[1].Value.ToLower() == "name")
						{
							name = item2.Groups[2].Value;
						}
						if (item2.Groups[1].Value.ToLower() == "value")
						{
							value2 = item2.Groups[2].Value;
						}
					}
					nameValueCollection[name] = value2;
				}
				return nameValueCollection;
			}
		}
		return nameValueCollection;
	}
}

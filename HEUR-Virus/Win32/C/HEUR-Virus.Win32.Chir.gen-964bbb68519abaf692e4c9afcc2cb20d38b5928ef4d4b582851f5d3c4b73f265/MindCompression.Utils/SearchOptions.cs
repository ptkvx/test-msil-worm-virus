using MindCompression.DataObjects;

namespace MindCompression.Utils;

public class SearchOptions : PropertyObject
{
	private bool _caseSensitive;

	private bool _ignoreAccents;

	private FmObjectType _searchIn;

	[PropertyInfo("Case sensitive", "Indicates if the search should be case sensitive.")]
	public bool CaseSensitive
	{
		get
		{
			return _caseSensitive;
		}
		set
		{
			_caseSensitive = value;
		}
	}

	[PropertyInfo("Ignore accents", "Indicates if the search should ignore accents on letters (ä, é, õ, etc).")]
	public bool IgnoreAccents
	{
		get
		{
			return _ignoreAccents;
		}
		set
		{
			_ignoreAccents = value;
		}
	}

	[PropertyInfo("Search in", "The type of items to search in.")]
	public FmObjectType SearchIn
	{
		get
		{
			return _searchIn;
		}
		set
		{
			_searchIn = value;
		}
	}

	public SearchOptions()
	{
		CaseSensitive = false;
		IgnoreAccents = true;
		SearchIn = FmObjectType.All;
	}
}

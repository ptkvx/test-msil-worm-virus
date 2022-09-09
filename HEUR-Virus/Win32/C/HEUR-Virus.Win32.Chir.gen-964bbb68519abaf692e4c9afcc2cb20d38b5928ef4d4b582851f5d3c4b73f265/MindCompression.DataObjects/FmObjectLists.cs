using System.Collections;

namespace MindCompression.DataObjects;

public sealed class FmObjectLists
{
	private ArrayList _allObjects;

	private ArrayList _cities;

	private ArrayList _countries;

	private ArrayList _players;

	private ArrayList _coaches;

	private ArrayList _playercoaches;

	private ArrayList _teams;

	private static readonly FmObjectLists _instance = new FmObjectLists();

	public static FmObjectLists Instance => _instance;

	public ArrayList AllObjects
	{
		get
		{
			return _allObjects;
		}
		set
		{
			_allObjects = value;
			foreach (FmObject allObject in _allObjects)
			{
				switch (allObject.Type)
				{
				case FmObjectType.Team:
					_teams.Add(allObject);
					break;
				case FmObjectType.Country:
					_countries.Add(allObject);
					break;
				case FmObjectType.City:
					_cities.Add(allObject);
					break;
				case FmObjectType.PlayerCoach:
					_playercoaches.Add(allObject);
					break;
				case FmObjectType.Coach:
					_coaches.Add(allObject);
					break;
				case FmObjectType.Player:
					_players.Add(allObject);
					break;
				}
			}
			_cities.Sort();
			_countries.Sort();
		}
	}

	private FmObjectLists()
	{
		_allObjects = new ArrayList();
		_cities = new ArrayList();
		_countries = new ArrayList();
		_players = new ArrayList();
		_coaches = new ArrayList();
		_playercoaches = new ArrayList();
		_teams = new ArrayList();
	}

	public ArrayList GetList(FmObjectType type)
	{
		return type switch
		{
			FmObjectType.Team => _teams, 
			FmObjectType.Country => _countries, 
			FmObjectType.City => _cities, 
			FmObjectType.PlayerCoach => _playercoaches, 
			FmObjectType.Coach => _coaches, 
			FmObjectType.Player => _players, 
			_ => new ArrayList(), 
		};
	}
}
